using System;
using System.IO;
using System.Runtime.InteropServices;

namespace CefSharp
{
	// Token: 0x0200001C RID: 28
	public class CefLibraryHandle : global::System.Runtime.InteropServices.SafeHandle
	{
		// Token: 0x0600006F RID: 111 RVA: 0x000026C8 File Offset: 0x000008C8
		public CefLibraryHandle(string path) : base(global::System.IntPtr.Zero, true)
		{
			if (!global::System.IO.File.Exists(path))
			{
				throw new global::System.IO.FileNotFoundException("NotFound", path);
			}
			global::System.IntPtr handle = global::CefSharp.CefLibraryHandle.LoadLibraryEx(path, global::System.IntPtr.Zero, global::CefSharp.CefLibraryHandle.LoadLibraryFlags.LOAD_WITH_ALTERED_SEARCH_PATH);
			base.SetHandle(handle);
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002709 File Offset: 0x00000909
		public override bool IsInvalid
		{
			get
			{
				return this.handle == global::System.IntPtr.Zero;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000271B File Offset: 0x0000091B
		protected override bool ReleaseHandle()
		{
			return global::CefSharp.CefLibraryHandle.FreeLibrary(this.handle);
		}

		// Token: 0x06000072 RID: 114
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		private static extern global::System.IntPtr LoadLibraryEx(string lpFileName, global::System.IntPtr hReservedNull, global::CefSharp.CefLibraryHandle.LoadLibraryFlags dwFlags);

		// Token: 0x06000073 RID: 115
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		private static extern bool FreeLibrary(global::System.IntPtr hModule);

		// Token: 0x0200012B RID: 299
		[global::System.Flags]
		private enum LoadLibraryFlags : uint
		{
			// Token: 0x0400048B RID: 1163
			DONT_RESOLVE_DLL_REFERENCES = 1U,
			// Token: 0x0400048C RID: 1164
			LOAD_IGNORE_CODE_AUTHZ_LEVEL = 16U,
			// Token: 0x0400048D RID: 1165
			LOAD_LIBRARY_AS_DATAFILE = 2U,
			// Token: 0x0400048E RID: 1166
			LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 64U,
			// Token: 0x0400048F RID: 1167
			LOAD_LIBRARY_AS_IMAGE_RESOURCE = 32U,
			// Token: 0x04000490 RID: 1168
			LOAD_WITH_ALTERED_SEARCH_PATH = 8U
		}
	}
}
