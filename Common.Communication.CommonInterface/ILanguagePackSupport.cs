using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000012 RID: 18
	public interface ILanguagePackSupport
	{
		// Token: 0x0600004D RID: 77
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo();

		// Token: 0x0600004E RID: 78
		void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData);

		// Token: 0x0600004F RID: 79
		void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData);
	}
}
