using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000026 RID: 38
	public struct CoreWebView2PhysicalKeyStatus
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00006FF8 File Offset: 0x000051F8
		internal CoreWebView2PhysicalKeyStatus(global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_PHYSICAL_KEY_STATUS rawStruct)
		{
			this.RepeatCount = rawStruct.RepeatCount;
			this.ScanCode = rawStruct.ScanCode;
			this.IsExtendedKey = rawStruct.IsExtendedKey;
			this.IsMenuKeyDown = rawStruct.IsMenuKeyDown;
			this.WasKeyDown = rawStruct.WasKeyDown;
			this.IsKeyReleased = rawStruct.IsKeyReleased;
		}

		// Token: 0x040000EE RID: 238
		public uint RepeatCount;

		// Token: 0x040000EF RID: 239
		public uint ScanCode;

		// Token: 0x040000F0 RID: 240
		public int IsExtendedKey;

		// Token: 0x040000F1 RID: 241
		public int IsMenuKeyDown;

		// Token: 0x040000F2 RID: 242
		public int WasKeyDown;

		// Token: 0x040000F3 RID: 243
		public int IsKeyReleased;
	}
}
