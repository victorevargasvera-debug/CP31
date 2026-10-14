using System;
using System.Collections.Generic;

namespace Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity
{
	// Token: 0x020000FC RID: 252
	public interface IRadioIdentityFields
	{
		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000C8D RID: 3213
		global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> Fields { get; }

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000C8E RID: 3214
		global::System.Collections.Generic.List<string> PbaFields { get; }

		// Token: 0x06000C8F RID: 3215
		global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase GetFieldBase(string pbaFieldId);

		// Token: 0x06000C90 RID: 3216
		bool GetVisibilityByFeature(global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType feature);

		// Token: 0x06000C91 RID: 3217
		void CombineRadioIpField(global::System.Collections.Generic.IDictionary<string, string> fieldValues);
	}
}
