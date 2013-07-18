using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace VisualTraceRoute
{
	public class EmbeddedAssembly
	{
		// Version 1.3

		static Dictionary<String, Assembly> dict = null;

		public static void Load(String embeddedResource, String fileName)
		{
			if (dict == null)
			{
				dict = new Dictionary<String, Assembly>();
			}

			byte[] data = null;
			Assembly asm = null;
			Assembly currentAsm = Assembly.GetExecutingAssembly();

			using (var stream = currentAsm.GetManifestResourceStream(embeddedResource))
			{
				// Either the file is not existed or it is not mark as embedded resource
				if (stream == null)
				{
					throw new Exception(embeddedResource + " is not found in Embedded Resources.");
				}

				// Get byte[] from the file from embedded resource
				data = new byte[(int)stream.Length];
				stream.Read(data, 0, (int)stream.Length);
				try
				{
					asm = Assembly.Load(data);

					// Add the assembly/dll into dictionary
					dict.Add(asm.FullName, asm);
					return;
				}
				catch
				{
					// Purposely do nothing
					// Unmanaged dll or assembly cannot be loaded directly from byte[]
					// Let the process fall through for next part
				}
			}

			bool isFileOk = false;
			String tempFile = "";

			using (SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider())
			{
				String fileHash = BitConverter.ToString(sha1.ComputeHash(data)).Replace("-", String.Empty); ;

				tempFile = Path.GetTempPath() + fileName;

				if (File.Exists(tempFile))
				{
					byte[] bb = File.ReadAllBytes(tempFile);
					String fileHash2 = BitConverter.ToString(sha1.ComputeHash(bb)).Replace("-", String.Empty);

					if (fileHash == fileHash2)
					{
						isFileOk = true;
					}
					else
					{
						isFileOk = false;
					}
				}
				else
				{
					isFileOk = false;
				}
			}

			if (!isFileOk)
			{
				System.IO.File.WriteAllBytes(tempFile, data);
			}

			asm = Assembly.LoadFile(tempFile);

			dict.Add(asm.FullName, asm);
		}

		public static Assembly Get(String assemblyFullName)
		{
			if (dict == null || dict.Count == 0)
			{
				return null;
			}

			if (dict.ContainsKey(assemblyFullName))
			{
				return dict[assemblyFullName];
			}

			return null;

		}
	}
}
