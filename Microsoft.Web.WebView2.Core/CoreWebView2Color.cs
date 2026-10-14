using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000027 RID: 39
	public struct CoreWebView2Color
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x0000704E File Offset: 0x0000524E
		internal CoreWebView2Color(global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_COLOR rawStruct)
		{
			this.A = rawStruct.A;
			this.R = rawStruct.R;
			this.G = rawStruct.G;
			this.B = rawStruct.B;
		}

		// Token: 0x040000F4 RID: 244
		public byte A;

		// Token: 0x040000F5 RID: 245
		public byte R;

		// Token: 0x040000F6 RID: 246
		public byte G;

		// Token: 0x040000F7 RID: 247
		public byte B;
	}
}
