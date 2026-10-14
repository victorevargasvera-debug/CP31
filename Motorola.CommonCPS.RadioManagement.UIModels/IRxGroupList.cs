using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000015 RID: 21
	public interface IRxGroupList : global::Motorola.CommonCPS.RadioManagement.UIModels.IScanList, global::Motorola.CommonCPS.RadioManagement.UIModels.IMultiSelectionListEdit
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000099 RID: 153
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> AffiliationsUI { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600009A RID: 154
		global::System.Windows.Input.ICommand SetAffiliationCommand { get; }
	}
}
