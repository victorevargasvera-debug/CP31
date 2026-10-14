using System;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200004E RID: 78
	public interface IPCRTemplateService : global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000678 RID: 1656
		bool ValidateCFS(global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate source, global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug target);

		// Token: 0x06000679 RID: 1657
		void GetSyncDataForUpgrade(global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate template, global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroup firmware, out global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate upgradedTemplate);

		// Token: 0x0600067A RID: 1658
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradePCRRadioBatch(global::System.Guid jobContainerGuid, global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroup firmware, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio radio, global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate upgradeTemplate);
	}
}
