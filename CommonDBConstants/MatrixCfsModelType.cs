using System;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000042 RID: 66
	[global::System.Flags]
	public enum MatrixCfsModelType : long
	{
		// Token: 0x04000254 RID: 596
		None = 0L,
		// Token: 0x04000255 RID: 597
		MatrixSubscriber = 1L,
		// Token: 0x04000256 RID: 598
		ParadiseSubscriberNormal = 2L,
		// Token: 0x04000257 RID: 599
		ParadisePA = 4L,
		// Token: 0x04000258 RID: 600
		ParadiseLightSubscriber = 8L,
		// Token: 0x04000259 RID: 601
		CypherRepeater = 16L,
		// Token: 0x0400025A RID: 602
		BanditRepeater = 32L,
		// Token: 0x0400025B RID: 603
		ParadiseRepeaterNormal = 64L,
		// Token: 0x0400025C RID: 604
		DMR3Controller = 128L,
		// Token: 0x0400025D RID: 605
		ParadiseRepeaterAndros = 256L,
		// Token: 0x0400025E RID: 606
		ParadiseSubscriber = 6L,
		// Token: 0x0400025F RID: 607
		AllSubscriber = 15L,
		// Token: 0x04000260 RID: 608
		MatrixRepeater = 48L,
		// Token: 0x04000261 RID: 609
		ParadiseRepeater = 320L,
		// Token: 0x04000262 RID: 610
		AllRepeater = 368L,
		// Token: 0x04000263 RID: 611
		AllModels = 4294967295L
	}
}
