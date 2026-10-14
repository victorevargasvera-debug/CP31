using System;

namespace CefSharp
{
	// Token: 0x02000043 RID: 67
	[global::System.Flags]
	public enum TransitionType : uint
	{
		// Token: 0x0400023E RID: 574
		LinkClicked = 0U,
		// Token: 0x0400023F RID: 575
		Explicit = 1U,
		// Token: 0x04000240 RID: 576
		AutoBookmark = 2U,
		// Token: 0x04000241 RID: 577
		AutoSubFrame = 3U,
		// Token: 0x04000242 RID: 578
		ManualSubFrame = 4U,
		// Token: 0x04000243 RID: 579
		Generated = 5U,
		// Token: 0x04000244 RID: 580
		AutoToplevel = 6U,
		// Token: 0x04000245 RID: 581
		FormSubmit = 7U,
		// Token: 0x04000246 RID: 582
		Reload = 8U,
		// Token: 0x04000247 RID: 583
		Keyword = 9U,
		// Token: 0x04000248 RID: 584
		KeywordGenerated = 10U,
		// Token: 0x04000249 RID: 585
		SourceMask = 255U,
		// Token: 0x0400024A RID: 586
		Blocked = 8388608U,
		// Token: 0x0400024B RID: 587
		ForwardBack = 16777216U,
		// Token: 0x0400024C RID: 588
		DirectLoad = 33554432U,
		// Token: 0x0400024D RID: 589
		HomePage = 67108864U,
		// Token: 0x0400024E RID: 590
		FromApi = 134217728U,
		// Token: 0x0400024F RID: 591
		ChainStart = 268435456U,
		// Token: 0x04000250 RID: 592
		ChainEnd = 536870912U,
		// Token: 0x04000251 RID: 593
		ClientRedirect = 1073741824U,
		// Token: 0x04000252 RID: 594
		ServerRedirect = 2147483648U,
		// Token: 0x04000253 RID: 595
		IsRedirect = 3221225472U,
		// Token: 0x04000254 RID: 596
		QualifierMask = 4294967040U
	}
}
