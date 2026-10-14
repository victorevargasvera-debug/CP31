using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ASK.Interface;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200003F RID: 63
	public interface IASTRORadioService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060005E6 RID: 1510
		void Reset(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio device, string password);

		// Token: 0x060005E7 RID: 1511
		void AutoGenerateRelatedIPs(ref string peerIP, ref string subscriberIP, ref string bluetoothDUNPeerIP, ref string bluetoothDUNSubscriberIP);

		// Token: 0x060005E8 RID: 1512
		void ValidateAstroWriting(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio, bool enableWriteProtect, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference Transport, bool IsWriteProtectedbool, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP);

		// Token: 0x060005E9 RID: 1513
		void ValidateAstroWriting(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio, bool enableWriteProtect, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference Transport, bool IsWriteProtectedbool, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP, ref global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> attachedASKs, ref bool? isSpecialKeyAttached);

		// Token: 0x060005EA RID: 1514
		void CheckDevicesIsMatchFlashKey(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> selectedDevices, out string newFlashCode, out string warning);

		// Token: 0x060005EB RID: 1515
		bool IsRadioSupportWriteLPWhenUpgrade(global::System.Guid radioUuid, string packageVersion);

		// Token: 0x060005EC RID: 1516
		void GetSyncDataForUpgrade(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware firmware, byte[] flashCode, string iButtonSerialNumber, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios, int allRadioCount, bool isRefresh, global::ASK.Interface.ISystemKeyData systemID, out global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData, string codeplugVersion = null);

		// Token: 0x060005ED RID: 1517
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeASTRORadioBatch(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radioToUpgrdae, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData, global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo flashKeyInfo, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios);

		// Token: 0x060005EE RID: 1518
		bool AstroCheckAskEnable(string flashcode, string modelNumber);

		// Token: 0x060005EF RID: 1519
		void CleanForUpgrade(global::System.Collections.Generic.IList<global::System.Guid> upgradeSuccessfulRadios, global::System.Collections.Generic.IList<global::System.Guid> Cross712Radios, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData);

		// Token: 0x060005F0 RID: 1520
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary TryDiscardCodeplug(global::System.Guid radioUuid, string serialNumber);

		// Token: 0x060005F1 RID: 1521
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary TryDiscardCodeplugAndRadioFeature(global::System.Guid radioUuid, string serialNumber, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> originalRadioFeature);

		// Token: 0x060005F2 RID: 1522
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary QueryAndUpdateRadio(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::ASK.Interface.KeyType type, int systemOwnerKeyId, bool writeProtected, bool askRequired);

		// Token: 0x060005F3 RID: 1523
		void ExportDVRS(global::System.Guid radioId, string fileName);

		// Token: 0x060005F4 RID: 1524
		void ValidateForeignIP(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport);

		// Token: 0x060005F5 RID: 1525
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeRadioCodeplugVersion(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, string newCodeplugVersion);

		// Token: 0x060005F6 RID: 1526
		bool IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string modelNumber);
	}
}
