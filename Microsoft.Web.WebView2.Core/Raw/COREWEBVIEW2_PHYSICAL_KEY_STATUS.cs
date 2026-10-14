using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x0200007C RID: 124
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.TypeIdentifier("26D34152-879F-4065-BEA2-3DAA2CFADFB8", "Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_PHYSICAL_KEY_STATUS")]
	[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 4)]
	public struct COREWEBVIEW2_PHYSICAL_KEY_STATUS
	{
		// Token: 0x0400020E RID: 526
		public uint RepeatCount;

		// Token: 0x0400020F RID: 527
		public uint ScanCode;

		// Token: 0x04000210 RID: 528
		public int IsExtendedKey;

		// Token: 0x04000211 RID: 529
		public int IsMenuKeyDown;

		// Token: 0x04000212 RID: 530
		public int WasKeyDown;

		// Token: 0x04000213 RID: 531
		public int IsKeyReleased;
	}
}
