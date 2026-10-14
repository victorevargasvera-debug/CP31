using System;
using System.IO;
using System.Reflection;
using CefSharp.Core;
using CefSharp.Internals;

namespace CefSharp.BrowserSubprocess
{
	// Token: 0x02000391 RID: 913
	public class SelfHost
	{
		// Token: 0x06001B7A RID: 7034 RVA: 0x0001D0AC File Offset: 0x0001B2AC
		public static int Main(string[] args)
		{
			string argumentValue = args.GetArgumentValue("--type");
			if (string.IsNullOrEmpty(argumentValue))
			{
				return -1;
			}
			string assemblyFile = global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(typeof(global::CefSharp.Core.BrowserSettings).Assembly.Location), "CefSharp.BrowserSubprocess.Core.dll");
			global::System.Reflection.Assembly assembly = global::System.Reflection.Assembly.LoadFrom(assemblyFile);
			global::System.Type type = assembly.GetType("CefSharp.BrowserSubprocess.BrowserSubprocessExecutable");
			object obj = global::System.Activator.CreateInstance(type);
			global::System.Reflection.MethodInfo method = type.GetMethod("MainSelfHost", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
			global::System.Reflection.ParameterInfo[] parameters = method.GetParameters();
			object[] parameters2 = new object[]
			{
				args
			};
			object obj2 = method.Invoke(null, parameters2);
			return (int)obj2;
		}
	}
}
