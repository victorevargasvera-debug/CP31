using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000088 RID: 136
	[global::System.Flags]
	public enum TTSLanguagePackControlOperation : byte
	{
		// Token: 0x040002A7 RID: 679
		AddTTSLanguagePackStart = 32,
		// Token: 0x040002A8 RID: 680
		AddTTSLanguagePackUnit = 33,
		// Token: 0x040002A9 RID: 681
		AddTTSLanguagePackEnd = 34,
		// Token: 0x040002AA RID: 682
		SetDefaultTTSLanguagePack = 35,
		// Token: 0x040002AB RID: 683
		DeleteTTSLanguagePack = 48
	}
}
