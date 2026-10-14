using System;
using System.IO;
using System.Reflection;

namespace CefSharp
{
	// Token: 0x0200001D RID: 29
	public static class CefRuntime
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00002728 File Offset: 0x00000928
		public static void SubscribeAnyCpuAssemblyResolver(string basePath = null)
		{
			if (global::CefSharp.CefRuntime.currentDomainAssemblyResolveHandler != null)
			{
				throw new global::System.Exception("UseAnyCpuAssemblyResolver has already been called, call ");
			}
			if (basePath == null)
			{
				basePath = global::System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
			}
			global::CefSharp.CefRuntime.currentDomainAssemblyResolveHandler = delegate(object sender, global::System.ResolveEventArgs args)
			{
				if (!args.Name.StartsWith("CefSharp.Core.Runtime"))
				{
					return null;
				}
				string path = args.Name.Split(new char[]
				{
					','
				}, 2)[0] + ".dll";
				string path2 = global::System.IO.Path.Combine(basePath, global::System.Environment.Is64BitProcess ? "x64" : "x86", path);
				if (!global::System.IO.File.Exists(path2))
				{
					return null;
				}
				return global::System.Reflection.Assembly.LoadFile(path2);
			};
			global::System.AppDomain.CurrentDomain.AssemblyResolve += global::CefSharp.CefRuntime.currentDomainAssemblyResolveHandler;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002791 File Offset: 0x00000991
		public static void UnsubscribeAnyCpuAssemblyResolver()
		{
			global::System.AppDomain.CurrentDomain.AssemblyResolve -= global::CefSharp.CefRuntime.currentDomainAssemblyResolveHandler;
			global::CefSharp.CefRuntime.currentDomainAssemblyResolveHandler = null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000027A8 File Offset: 0x000009A8
		public static void LoadCefSharpCoreRuntimeAnyCpu(string basePath = null)
		{
			if (basePath == null)
			{
				basePath = global::System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
			}
			string text = global::System.Environment.Is64BitProcess ? "x64" : "x86";
			string text2 = global::System.IO.Path.Combine(basePath, text, "CefSharp.Core.Runtime.dll");
			if (global::System.IO.File.Exists(text2))
			{
				global::System.Reflection.Assembly.LoadFile(text2);
				return;
			}
			throw new global::System.IO.FileNotFoundException("Unable to load for arch " + text, text2);
		}

		// Token: 0x04000018 RID: 24
		private static global::System.ResolveEventHandler currentDomainAssemblyResolveHandler;
	}
}
