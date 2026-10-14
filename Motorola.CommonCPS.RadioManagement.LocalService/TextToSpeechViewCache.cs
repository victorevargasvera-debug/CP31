using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200008F RID: 143
	public class TextToSpeechViewCache : global::Motorola.CommonCPS.RadioManagement.LocalService.PackageViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech>
	{
		// Token: 0x060003CE RID: 974 RVA: 0x00057A60 File Offset: 0x00055C60
		public TextToSpeechViewCache(global::Motorola.CommonCPS.RadioManagement.ViewCache.IFilter<global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech> filter = null) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.TextToSpeech, filter)
		{
		}
	}
}
