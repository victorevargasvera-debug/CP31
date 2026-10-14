using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000044 RID: 68
	public interface IRadioDetailService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000618 RID: 1560
		bool ValidateRestore_PreSchedule(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> selectedItems, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetail, out string error);

		// Token: 0x06000619 RID: 1561
		global::Motorola.CommonCPS.Server.EntityModel.Codeplug FixIncorrectData_OfHistoricalCodeplug(global::Motorola.CommonCPS.Server.EntityModel.Codeplug restoreJob_Codeplug, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateEntitySet, byte[] historical_xPbaBytes, out bool restoreJob_PbaCanNotBeDirectlyModified);

		// Token: 0x0600061A RID: 1562
		void PacSpecial_Validate_AllowRestore(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.Common.Communication.Pba.PbaObject historical_PbaObject, global::Motorola.Common.Communication.CommonUtil.DeviceInfo historical_DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject current_PbaObject);
	}
}
