using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTraceRoute
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			EmbeddedAssembly.Load("VisualTraceRoute.GMap.NET.Core.dll", "GMap.NET.Core.dll");
			EmbeddedAssembly.Load("VisualTraceRoute.GMap.NET.WindowsForms.dll", "GMap.NET.WindowsForms.dll");
			EmbeddedAssembly.Load("VisualTraceRoute.MRG.Controls.UI.dll", "MRG.Controls.UI.dll");

			AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new TraceForm());
		}

		static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			return EmbeddedAssembly.Get(args.Name);
		}
	}
}
