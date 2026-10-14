using System;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000060 RID: 96
	public enum RadioFeatureStatus
	{
		// Token: 0x040003C4 RID: 964
		RadioFreeAndConfigurationUsed,
		// Token: 0x040003C5 RID: 965
		RadioFreeAndConfigurationNotUsed,
		// Token: 0x040003C6 RID: 966
		RadioPurchasedAndConfigurationUsed,
		// Token: 0x040003C7 RID: 967
		RadioPurchasedAndConfigurationNotUsed,
		// Token: 0x040003C8 RID: 968
		RadioPurchasedAndConfigurationNotUsedButInvalid,
		// Token: 0x040003C9 RID: 969
		RadioNotPurchasedAndConfigurationUsed,
		// Token: 0x040003CA RID: 970
		RadioNotPurchasedAndConfigurationUsedButIgnore,
		// Token: 0x040003CB RID: 971
		RadioNotPurchasedAndConfigurationNotUsed,
		// Token: 0x040003CC RID: 972
		RadioCannotHaveThisFeature,
		// Token: 0x040003CD RID: 973
		RadioPermanentlyEnabled,
		// Token: 0x040003CE RID: 974
		RadioNotAvailableAndUsed,
		// Token: 0x040003CF RID: 975
		RadioAvailableAndUsed,
		// Token: 0x040003D0 RID: 976
		RadioAvailableAndNotUsed
	}
}
