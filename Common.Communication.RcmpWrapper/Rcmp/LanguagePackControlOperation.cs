using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000086 RID: 134
	[global::System.Flags]
	public enum LanguagePackControlOperation : byte
	{
		// Token: 0x0400029D RID: 669
		AddLanguagePackStart = 0,
		// Token: 0x0400029E RID: 670
		AddLanguagePackUnit = 1,
		// Token: 0x0400029F RID: 671
		AddLanguagePackEnd = 2,
		// Token: 0x040002A0 RID: 672
		SetDefaultLanguagePack = 3,
		// Token: 0x040002A1 RID: 673
		DeleteLanguagePack = 16
	}
}
