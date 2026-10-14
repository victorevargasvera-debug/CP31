using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200004C RID: 76
	public interface IASTROTemplateService : global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000663 RID: 1635
		void CloneConstraintFields(global::Motorola.CommonCPS.Server.EntityModel.APXRadio targetRadio, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate source);

		// Token: 0x06000664 RID: 1636
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> CloneRadioSystem(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate source, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug target, bool isApply = true);

		// Token: 0x06000665 RID: 1637
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> CloneDataProfile(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate source, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug target, bool isApply = true);
	}
}
