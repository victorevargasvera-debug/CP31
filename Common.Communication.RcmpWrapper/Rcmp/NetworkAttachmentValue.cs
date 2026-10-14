using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200003E RID: 62
	public enum NetworkAttachmentValue : byte
	{
		// Token: 0x0400010F RID: 271
		NoDefaultGateway,
		// Token: 0x04000110 RID: 272
		OneG,
		// Token: 0x04000111 RID: 273
		TwoG,
		// Token: 0x04000112 RID: 274
		ThreeG,
		// Token: 0x04000113 RID: 275
		FourG,
		// Token: 0x04000114 RID: 276
		WiFi,
		// Token: 0x04000115 RID: 277
		LMR = 255
	}
}
