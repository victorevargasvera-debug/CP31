using System;
using System.Runtime.InteropServices;

namespace CefSharp.Wpf.Internals
{
	// Token: 0x02000016 RID: 22
	[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
	internal struct MonitorInfoEx
	{
		// Token: 0x06000192 RID: 402 RVA: 0x000061AD File Offset: 0x000043AD
		public void Init()
		{
			this.Size = 104;
			this.DeviceName = string.Empty;
		}

		// Token: 0x040000B7 RID: 183
		private const int CCHDEVICENAME = 32;

		// Token: 0x040000B8 RID: 184
		public int Size;

		// Token: 0x040000B9 RID: 185
		public global::CefSharp.Wpf.Internals.RectStruct Monitor;

		// Token: 0x040000BA RID: 186
		public global::CefSharp.Wpf.Internals.RectStruct WorkArea;

		// Token: 0x040000BB RID: 187
		public uint Flags;

		// Token: 0x040000BC RID: 188
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
		public string DeviceName;
	}
}
