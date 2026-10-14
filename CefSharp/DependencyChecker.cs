using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CefSharp
{
	// Token: 0x02000021 RID: 33
	public static class DependencyChecker
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00002AA7 File Offset: 0x00000CA7
		public static global::System.Collections.Generic.List<string> CheckDependencies(bool checkOptional, bool packLoadingDisabled, string path, string resourcesDirPath, string browserSubProcessPath, string localePackFile = "locales\\en-US.pak")
		{
			return global::CefSharp.DependencyChecker.CheckDependencies(checkOptional, packLoadingDisabled, path, path, resourcesDirPath, browserSubProcessPath, localePackFile);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002AB8 File Offset: 0x00000CB8
		public static global::System.Collections.Generic.List<string> CheckDependencies(bool checkOptional, bool packLoadingDisabled, string managedLibPath, string nativeLibPath, string resourcesDirPath, string browserSubProcessPath, string localePackFile = "locales\\en-US.pak")
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.AddRange(global::CefSharp.DependencyChecker.CheckDependencyList(nativeLibPath, global::CefSharp.DependencyChecker.CefDependencies));
			if (!packLoadingDisabled)
			{
				list.AddRange(global::CefSharp.DependencyChecker.CheckDependencyList(resourcesDirPath, global::CefSharp.DependencyChecker.CefResources));
			}
			if (checkOptional)
			{
				list.AddRange(global::CefSharp.DependencyChecker.CheckDependencyList(nativeLibPath, global::CefSharp.DependencyChecker.CefOptionalDependencies));
			}
			list.AddRange(global::CefSharp.DependencyChecker.CheckDependencyList(nativeLibPath, global::CefSharp.DependencyChecker.CefSharpArchSpecificDependencies));
			list.AddRange(global::CefSharp.DependencyChecker.CheckDependencyList(managedLibPath, global::CefSharp.DependencyChecker.CefSharpManagedDependencies));
			if (!global::System.IO.File.Exists(browserSubProcessPath))
			{
				list.Add(browserSubProcessPath);
			}
			string directoryName = global::System.IO.Path.GetDirectoryName(browserSubProcessPath);
			if (directoryName == null)
			{
				list.AddRange(global::CefSharp.DependencyChecker.BrowserSubprocessDependencies);
			}
			else
			{
				list.AddRange(global::CefSharp.DependencyChecker.CheckDependencyList(directoryName, global::CefSharp.DependencyChecker.BrowserSubprocessDependencies));
			}
			string path = global::System.IO.Path.IsPathRooted(localePackFile) ? localePackFile : global::System.IO.Path.Combine(nativeLibPath, localePackFile);
			if (!global::System.IO.File.Exists(path))
			{
				list.Add(localePackFile);
			}
			return list;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002B88 File Offset: 0x00000D88
		private static global::System.Collections.Generic.List<string> CheckDependencyList(string dir, global::System.Collections.Generic.IEnumerable<string> files)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (string text in files)
			{
				string text2 = string.IsNullOrEmpty(dir) ? text : global::System.IO.Path.Combine(dir, text);
				if (!global::System.IO.File.Exists(text2))
				{
					list.Add(text2);
				}
			}
			return list;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public static void AssertAllDependenciesPresent(string locale = null, string localesDirPath = null, string resourcesDirPath = null, bool packLoadingDisabled = false, string browserSubProcessPath = "CefSharp.BrowserSubProcess.exe")
		{
			string directoryName = global::System.IO.Path.GetDirectoryName(typeof(global::CefSharp.DependencyChecker).Assembly.Location);
			global::System.Uri uri;
			string directoryName2;
			if (global::System.Uri.TryCreate(browserSubProcessPath, global::System.UriKind.Absolute, out uri) && uri.IsAbsoluteUri)
			{
				directoryName2 = global::System.IO.Path.GetDirectoryName(browserSubProcessPath);
			}
			else
			{
				global::System.Reflection.Assembly executingAssembly = global::System.Reflection.Assembly.GetExecutingAssembly();
				directoryName2 = global::System.IO.Path.GetDirectoryName(executingAssembly.Location);
			}
			if (string.IsNullOrEmpty(locale))
			{
				locale = "en-US";
			}
			if (string.IsNullOrEmpty(localesDirPath))
			{
				localesDirPath = global::System.IO.Path.Combine(directoryName2, "locales");
			}
			if (string.IsNullOrEmpty(resourcesDirPath))
			{
				resourcesDirPath = directoryName2;
			}
			global::System.Collections.Generic.List<string> list = global::CefSharp.DependencyChecker.CheckDependencies(true, packLoadingDisabled, directoryName, directoryName2, resourcesDirPath, browserSubProcessPath, global::System.IO.Path.Combine(localesDirPath, locale + ".pak"));
			if (list.Count > 0)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.AppendLine("Unable to locate required Cef/CefSharp dependencies:");
				foreach (string str in list)
				{
					stringBuilder.AppendLine("Missing:" + str);
				}
				stringBuilder.AppendLine("Executing Assembly Path:" + directoryName2);
				throw new global::System.Exception(stringBuilder.ToString());
			}
		}

		// Token: 0x0400002E RID: 46
		public const string LocalesPackFile = "locales\\en-US.pak";

		// Token: 0x0400002F RID: 47
		private const string D3DCompilerDll = "d3dcompiler_47.dll";

		// Token: 0x04000030 RID: 48
		public static string[] CefDependencies = new string[]
		{
			"libcef.dll",
			"icudtl.dat",
			"snapshot_blob.bin",
			"v8_context_snapshot.bin"
		};

		// Token: 0x04000031 RID: 49
		public static string[] CefResources = new string[]
		{
			"resources.pak",
			"chrome_100_percent.pak",
			"chrome_200_percent.pak"
		};

		// Token: 0x04000032 RID: 50
		public static string[] CefOptionalDependencies = new string[]
		{
			"libEGL.dll",
			"libGLESv2.dll",
			"d3dcompiler_47.dll",
			"chrome_elf.dll"
		};

		// Token: 0x04000033 RID: 51
		public static string[] CefSharpManagedDependencies = new string[]
		{
			"CefSharp.Core.dll",
			"CefSharp.dll"
		};

		// Token: 0x04000034 RID: 52
		public static string[] CefSharpArchSpecificDependencies = new string[]
		{
			"CefSharp.Core.Runtime.dll"
		};

		// Token: 0x04000035 RID: 53
		public static string[] BrowserSubprocessDependencies = new string[]
		{
			"CefSharp.BrowserSubprocess.Core.dll",
			"CefSharp.dll",
			"icudtl.dat",
			"libcef.dll"
		};
	}
}
