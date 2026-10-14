using System;
using System.Runtime.CompilerServices;

namespace CefSharp.Internals
{
	// Token: 0x020000EE RID: 238
	public static class PathCheck
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x0000B88C File Offset: 0x00009A8C
		internal static int FindDriveLetter(string path)
		{
			if (path.Length >= 2 && path[1] == ':' && ((path[0] >= 'A' && path[0] <= 'Z') || (path[0] >= 'a' && path[0] <= 'z')))
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0000B8DC File Offset: 0x00009ADC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		internal static bool IsDirectorySeparator(char c)
		{
			return c == '\\' || c == '/';
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0000B8EA File Offset: 0x00009AEA
		public static void AssertAbsolute(string path, string settingName)
		{
			if (!string.IsNullOrEmpty(path) && global::CefSharp.Internals.PathCheck.EnableAssert && !global::CefSharp.Internals.PathCheck.IsAbsolute(path))
			{
				throw new global::System.Exception(settingName + " now requires an absolute path, the path provided is non-absolute. You can use System.IO.Path.GetFullPath to obtain an absolute path. Current value:" + path);
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0000B918 File Offset: 0x00009B18
		public static bool IsAbsolute(string path)
		{
			int num = global::CefSharp.Internals.PathCheck.FindDriveLetter(path);
			if (num != -1)
			{
				return path.Length > num + 1 && global::CefSharp.Internals.PathCheck.IsDirectorySeparator(path[num + 1]);
			}
			return path.Length > 1 && global::CefSharp.Internals.PathCheck.IsDirectorySeparator(path[0]) && global::CefSharp.Internals.PathCheck.IsDirectorySeparator(path[1]);
		}

		// Token: 0x040003C1 RID: 961
		internal const char DirectorySeparatorChar = '\\';

		// Token: 0x040003C2 RID: 962
		internal const char AltDirectorySeparatorChar = '/';

		// Token: 0x040003C3 RID: 963
		[global::System.Obsolete("This will be removed after further testing.")]
		public static bool EnableAssert = true;
	}
}
