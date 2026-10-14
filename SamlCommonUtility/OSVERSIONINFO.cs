using System;
using System.Runtime.InteropServices;

namespace Motorola.Security.SamlCommonUtility
{
	// Token: 0x0200001A RID: 26
	public struct OSVERSIONINFO
	{
		// Token: 0x0400009A RID: 154
		public int dwOSVersionInfoSize;

		// Token: 0x0400009B RID: 155
		public int dwMajorVersion;

		// Token: 0x0400009C RID: 156
		public int dwMinorVersion;

		// Token: 0x0400009D RID: 157
		public int dwBuildNumber;

		// Token: 0x0400009E RID: 158
		public int dwPlatformId;

		// Token: 0x0400009F RID: 159
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
		public string szCSDVersion;

		// Token: 0x040000A0 RID: 160
		public short wServicePackMajor;

		// Token: 0x040000A1 RID: 161
		public short wServicePackMinor;

		// Token: 0x040000A2 RID: 162
		public short wSuiteMask;

		// Token: 0x040000A3 RID: 163
		public byte wProductType;

		// Token: 0x040000A4 RID: 164
		public byte wReserved;
	}
}
