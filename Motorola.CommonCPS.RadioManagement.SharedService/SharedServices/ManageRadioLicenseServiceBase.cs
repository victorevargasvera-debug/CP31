using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using ASK.Interface;
using EntityModel.GenericModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000070 RID: 112
	internal abstract class ManageRadioLicenseServiceBase : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IManageRadioLicenseService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000797 RID: 1943 RVA: 0x0005AD80 File Offset: 0x00058F80
		public ManageRadioLicenseServiceBase(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase validationServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService radioLicenseService) : base(serverAccessor, validationServiceBase)
		{
			this.RadioLicenseService = radioLicenseService;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0005AD9C File Offset: 0x00058F9C
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x0005AE4C File Offset: 0x0005904C
		protected global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService RadioLicenseService
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1482752001;
				if (num != 0)
				{
				}
				num = (short)668815288;
				short num2 = num;
				num = (short)1168330680;
				switch (num2 == num)
				{
				}
				num = (short)1772158976;
				if (num != 0)
				{
				}
				num = (short)621281280;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1820342962;
				short num2 = num;
				num = (short)414792370;
				switch (num2 == num)
				{
				}
				num = (short)585760769;
				if (num != 0)
				{
				}
				num = (short)733216768;
				if (num != 0)
				{
				}
				num = (short)1602224128;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0005AF00 File Offset: 0x00059100
		public virtual global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetAvailableDevices(global::System.Guid? groupUUID, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails, int startIndex, int length, int featureType = 0)
		{
			short num = (short)271852922;
			short num2 = num;
			num = (short)1455367546;
			switch (num2 == num)
			{
			}
			num = (short)655228929;
			if (num != 0)
			{
			}
			num = (short)364576768;
			if (num != 0)
			{
			}
			num = (short)231669760;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter = this.PrepareLicenseFilter(selectedEIDDetails);
			return base.ServerAccessor.ListAvailableRadioForPurchase(groupUUID, filter, startIndex, length, featureType);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0005AFC4 File Offset: 0x000591C4
		public virtual int GetAvailableDevicesCount(global::System.Guid? groupUUID, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails, global::System.Collections.Generic.List<string> selectedSerialNumbers, int featureType = 0)
		{
			short num = (short)560560008;
			short num2 = num;
			num = (short)297564040;
			switch (num2 == num)
			{
			}
			num = (short)1296105473;
			if (num != 0)
			{
			}
			num = (short)1188233216;
			if (num != 0)
			{
			}
			num = (short)2124742656;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter = this.PrepareLicenseFilter(selectedEIDDetails);
			return base.ServerAccessor.GetAvailableRadioForPurchaseCount(groupUUID, filter, selectedSerialNumbers, featureType);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0005B084 File Offset: 0x00059284
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> GetEIDDetailList(string EID)
		{
			switch (0)
			{
			case 0:
				goto IL_9F;
			}
			short num;
			int num4;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> list;
			for (;;)
			{
				IL_0A:
				num = (short)709759622;
				short num2 = num;
				num = (short)1595806342;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F5;
				case 1:
					break;
				default:
				{
					num = (short)435814400;
					short num3 = num;
					break;
				}
				}
				num = (short)1039335424;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					num = (short)1623326721;
					if (num != 0)
					{
					}
					num = (short)1068892165;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (list != null)
					{
						num = (short)1439367168;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return list;
				case 2:
					num = (short)276037633;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (list != null)
					{
						num = (short)1943470082;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F5;
				case 4:
					goto IL_15B;
				case 5:
					if (list.Count == 0)
					{
						num = (short)1471545348;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return list;
				}
				goto IL_9F;
			}
			IL_F5:
			return new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>();
			IL_15B:
			goto IL_F5;
			IL_9F:
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> originalLicenseList = global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.Instance.QueryLicensesFromEntitlementID(EID);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> eidlist = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().FilterLicenseList(originalLicenseList);
			list = this.ConstructEIDDetailList(eidlist);
			num = (short)86835203;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600079D RID: 1949
		public abstract global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter PrepareLicenseFilter(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails);

		// Token: 0x0600079E RID: 1950
		public abstract global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> ConstructEIDDetailList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> EIDList);

		// Token: 0x0600079F RID: 1951
		public abstract global::EntityModel.GenericModel.CFSUpdateResult SubmitLicenseAssignment(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> EIDDetailList, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.Dictionary<string, global::System.Guid>> newTemplateDic, global::System.Guid JobContainerGuid, global::ASK.Interface.ISystemKeyData SelectedSystemID);

		// Token: 0x060007A0 RID: 1952
		public abstract global::EntityModel.GenericModel.CFSUpdateResult RestoreDevice(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> selectedList, global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.Dictionary<string, global::System.Guid>> newTemplateDic, global::System.Guid JobContainerGuid, global::ASK.Interface.ISystemKeyData SelectedSystemID = null);

		// Token: 0x060007A1 RID: 1953 RVA: 0x0005B228 File Offset: 0x00059428
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> GenerateTemplateForSubmission(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, string targetFlashcode, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> swLicenseList, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> requestList, out byte[] newTemplateContent, global::System.Collections.Generic.Dictionary<string, object> syncData, global::ASK.Interface.ISystemKeyData SelectedSystemID = null)
		{
			short num = (short)1958849584;
			short num2 = num;
			num = (short)274836528;
			switch (num2 == num)
			{
			}
			num = (short)1379205121;
			if (num != 0)
			{
			}
			num = (short)398393344;
			if (num != 0)
			{
			}
			num = (short)1183252480;
			short num3 = num;
			newTemplateContent = null;
			return null;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0005B2D8 File Offset: 0x000594D8
		public virtual global::EntityModel.GenericModel.CFSUpdateResult RecoverRadioLicense(string radioSerialNumber, out string warning)
		{
			short num = (short)183697408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> list;
				global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
				byte[] capacityResponse;
				for (;;)
				{
					IL_27:
					global::EntityModel.GenericModel.CFSUpdateResult cfsupdateResult;
					switch (num2)
					{
					case 0:
						goto IL_3BA;
					case 1:
						num = (short)183762947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!string.IsNullOrEmpty(warning))
						{
							num = (short)766705674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_118;
					case 3:
						if (list != null)
						{
							num = (short)1612382216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37D;
					case 4:
						if (list != null)
						{
							num = (short)324665345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A3;
					case 5:
						num = (short)1986920459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (cfsupdateResult.RadioFeatureObjs.CreatedList.Count == 0)
						{
							num = (short)1360855049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return cfsupdateResult;
					case 7:
						if (string.CompareOrdinal(warning, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_NO_Changed_Features) == 0)
						{
							num = (short)1324679181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_118;
					case 8:
						num = (short)938410001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_21C;
					case 10:
						num = (short)71041031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (cfsupdateResult.RadioFeatureObjs.UpdatedList.Count == 0)
						{
							num = (short)1840840720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return cfsupdateResult;
					case 12:
						if (!this.CheckFeatureCompatibilityForRecover(radio, list, out warning))
						{
							num = (short)771883008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1960181762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_19E;
					case 14:
						goto IL_281;
					case 15:
						if (cfsupdateResult != null)
						{
							num = (short)489619461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_288;
					case 16:
					{
						num = (short)62259200;
						short num3 = num;
						num = (short)1585315846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)703463425;
						if (num != 0)
						{
						}
						if (list.Count == 0)
						{
							num = (short)1562574862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37D;
					}
					goto IL_76;
					IL_118:
					cfsupdateResult = this.DoRecover(radio, list, capacityResponse);
					num = (short)260374543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37D:
					num = (short)1008467980;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19E:
				return null;
				IL_1A3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Licenses_Recover_Com_BackOfficeServer_NullError);
				IL_21C:
				goto IL_288;
				IL_281:
				goto IL_1A3;
				IL_288:
				throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Recover_LicenseUpdateToDate, radioSerialNumber));
				IL_76:
				radio = this.CheckRadio(radioSerialNumber);
				capacityResponse = null;
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense>();
				list = this.GetFlexServerRadioFeatureList(radioSerialNumber, out capacityResponse);
				num = (short)324537644;
				short num4 = num;
				num = (short)1815940396;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_3BA:
					throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Recover_LicenseFeatureCompatibility_Error, radioSerialNumber));
				default:
					num = (short)539754496;
					if (num != 0)
					{
					}
					num = (short)922353668;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}

		// Token: 0x060007A3 RID: 1955
		public abstract bool ConstructSoftwareLicense(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail theEIDDetail, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> licenseList, out global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense license);

		// Token: 0x060007A4 RID: 1956
		public abstract global::EntityModel.GenericModel.CFSUpdateResult DoRecover(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> radioSoftwareLicense, byte[] capacityResponse);

		// Token: 0x060007A5 RID: 1957
		public abstract bool CheckFeatureCompatibilityForRecover(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> softwareLicenseList, out string warning);

		// Token: 0x060007A6 RID: 1958 RVA: 0x0005B6A8 File Offset: 0x000598A8
		protected void CopyEIDInfo(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail detail, global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense license)
		{
			short num = (short)522715137;
			if (num != 0)
			{
			}
			num = (short)99524597;
			short num2 = num;
			num = (short)763928565;
			switch (num2 == num)
			{
			}
			num = (short)368640000;
			if (num != 0)
			{
			}
			num = (short)1949958144;
			short num3 = num;
			detail.IsSelected = false;
			detail.EntitlementID = license.EID;
			detail.CapabilityResponse = null;
			detail.PurchasedCount = license.TotalLicenseCount;
			detail.AvailableCount = license.AvailableLicenseCount;
			detail.ActivationID = license.License.AID;
			detail.RegistrationQuantity = 0;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0005B79C File Offset: 0x0005999C
		protected virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> FilterNotSupportedLicenses(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> licenseList)
		{
			short num = (short)2073122694;
			short num2 = num;
			num = (short)1020090246;
			switch (num2 == num)
			{
			}
			num = (short)1043791872;
			if (num != 0)
			{
			}
			num = (short)172163073;
			if (num != 0)
			{
			}
			num = (short)1653735424;
			short num3 = num;
			return licenseList;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0005B844 File Offset: 0x00059A44
		protected byte[] RegisterLicense(string radioSerialNumber, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> licenseList)
		{
			short num = (short)1740832769;
			if (num != 0)
			{
			}
			num = (short)1883127851;
			short num2 = num;
			num = (short)1749106731;
			switch (num2 == num)
			{
			}
			num = (short)208732160;
			if (num != 0)
			{
			}
			num = (short)2099118080;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.Instance.SubmitLicense(radioSerialNumber, licenseList);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0005B8FC File Offset: 0x00059AFC
		protected virtual global::Motorola.CommonCPS.Server.EntityModel.Radio CheckRadio(global::System.Guid deviceId, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device)
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1321664529;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_9A;
				case 2:
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(radio.Timestamp, device.RadioTimestamp))
					{
						num2 = (short)1596325898;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 3:
					if (device != null)
					{
						num2 = (short)1825898497;
						if (num2 != 0)
						{
						}
						num2 = (short)919535624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 4:
					if (radio == null)
					{
						num2 = (short)409665537;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)748158979;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1983905804;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (radio.Uuid != device.DeviceUuid)
					{
						num2 = (short)2107244553;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)763035650;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (radio.LastJob != null)
					{
						num2 = (short)2028601357;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return radio;
				case 8:
					num2 = (short)1650130950;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_16A;
				case 10:
					goto IL_2E3;
				case 11:
					if (radio.LastJob.JobStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_SCHEDULED)
					{
						num2 = (short)84738064;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_259;
				case 12:
				{
					num2 = (short)1766192303;
					short num3 = num2;
					num2 = (short)422376623;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16A;
					default:
						num2 = (short)926613504;
						if (num2 != 0)
						{
						}
						if (radio.LastJob.JobStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PENDING)
						{
							num2 = (short)323420160;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_259;
					}
					break;
				}
				case 13:
					num2 = (short)407175179;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_1B0;
				case 15:
					if (radio.LastJob.JobStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_RUNNING)
					{
						num2 = (short)1786839045;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_259;
				case 16:
					num2 = (short)1897791503;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (radio.LastJob.JobStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CREATED)
					{
						num2 = (short)1031667726;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return radio;
				}
				goto IL_58;
				IL_E4:
				num2 = (short)375848967;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_9A:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeviceNoExistForEditTemplate, null);
			IL_16A:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeviceNoExistForEditTemplate, null);
			IL_1B0:
			IL_259:
			num2 = (short)766640128;
			short num4 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Submit_SelectedRadioHasActiveJob, radio.SerialNumber));
			IL_2E3:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
			IL_58:
			radio = null;
			radio = base.ServerAccessor.GetRadioByDeviceUuid(deviceId, true);
			num2 = (short)1439432708;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0005BCAC File Offset: 0x00059EAC
		protected virtual global::Motorola.CommonCPS.Server.EntityModel.Radio CheckRadio(string radioSerialNumber)
		{
			global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceID = base.ServerAccessor.GetRadioByDeviceID(radioSerialNumber, true);
			if (radioByDeviceID == null)
			{
				short num = (short)708313089;
				if (num != 0)
				{
				}
				num = (short)1095784938;
				short num2 = num;
				num = (short)1405114858;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)822149120;
					short num3 = num;
					num = (short)1957429248;
					if (num != 0)
					{
					}
					break;
				}
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeviceNoExistForEditTemplate, null);
			}
			this.a(radioByDeviceID);
			return radioByDeviceID;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0005BD84 File Offset: 0x00059F84
		protected void CheckRadioHaveConfiguraion(global::Motorola.CommonCPS.Server.EntityModel.Radio device)
		{
			short num;
			if (device.WorkingCodeplug.ConfigurationUuid == null)
			{
				num = (short)1364700491;
				short num2 = num;
				num = (short)1508748619;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1526857728;
					if (num != 0)
					{
					}
					num = (short)518914048;
					short num3 = num;
					break;
				}
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_RadioNotHaveConfiguration);
			}
			num = (short)1932328961;
			if (num != 0)
			{
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0005BE54 File Offset: 0x0005A054
		protected byte[] RegisterLicense(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> EIDDetailList, string registerRadioIdentifier, bool reduceAvailableCount)
		{
			short num = (short)65601536;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> list;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> list2;
				byte[] result;
				int num5;
				for (;;)
				{
					IL_28:
					global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eiddetail;
					switch (num2)
					{
					case 0:
					{
						list.Add(eiddetail);
						global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense item;
						list2.Add(item);
						num = (short)967901190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (eiddetail.AvailableCount > 0)
						{
							num = (short)1188364295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 2:
						if (reduceAvailableCount)
						{
							num = (short)847446016;
							short num3 = num;
							num = (short)2133786627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>.Enumerator enumerator = list.GetEnumerator();
						num = (short)1002176521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense item;
						if (this.ConstructSoftwareLicense(eiddetail, list2, out item))
						{
							num = (short)1728708608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					}
					case 5:
						result = null;
						result = this.RegisterLicense(registerRadioIdentifier, list2);
						num = (short)377880578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_32C;
					case 7:
						num = (short)243269636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_A6;
					case 9:
						try
						{
							num = (short)1989148673;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1416626178;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)1941397554;
									short num4 = num;
									num = (short)357785650;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1FD;
									default:
										num = (short)936640512;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_1DC;
										}
										continue;
									}
									break;
								}
								case 2:
									goto IL_25C;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										goto IL_1FD;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eiddetail2 = enumerator.Current;
									int availableCount = eiddetail2.AvailableCount;
									eiddetail2.AvailableCount = availableCount - 1;
									num = (short)528220163;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1DE:
								num = (short)2140602372;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DC:
								goto IL_1DE;
								IL_1FD:
								num = (short)176357376;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_25C:
							return result;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_26F;
					case 10:
						num = (short)2096431105;
						if (num != 0)
						{
						}
						if (num5 >= EIDDetailList.Count)
						{
							num = (short)959905797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26F;
					case 11:
						goto IL_A6;
					}
					goto IL_5F;
					IL_A6:
					num = (short)908591114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26F:
					eiddetail = EIDDetailList[num5];
					num = (short)1747648513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32C:
					num5++;
					num = (short)1162280971;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_5F:
				list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense>();
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>();
				num5 = 0;
				num = (short)780271624;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0005C1F8 File Offset: 0x0005A3F8
		protected virtual bool CheckPendingLicenseForRecover(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> radioFeatures)
		{
			short num;
			bool result;
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>.Enumerator enumerator = radioFeatures.GetEnumerator())
			{
				num = (short)1837694980;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1337196549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.CommonCPS.Server.EntityModel.RadioFeature radioFeature;
						if (radioFeature.DisplayStatus != 32)
						{
							num = (short)516292608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_146;
					}
					case 2:
						goto IL_15F;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2015690760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.RadioFeature radioFeature = enumerator.Current;
						num = (short)680656897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.RadioFeature radioFeature;
						if (radioFeature.DisplayStatus == 64)
						{
							num = (short)2012217351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_1B7;
					case 7:
						goto IL_146;
					case 8:
						num = (short)1614348294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7D:
					num = (short)211787385;
					short num3 = num;
					num = (short)481730169;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_7B:
						goto IL_7D;
					default:
						num = (short)791609344;
						if (num != 0)
						{
						}
						num = (short)1658585091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_146:
					result = true;
					num = (short)1734017026;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_15F:
				goto IL_1CA;
				IL_1B7:
				goto IL_09;
			}
			goto IL_1CA;
			IL_09:
			num = (short)1017053185;
			if (num != 0)
			{
			}
			return false;
			IL_1CA:
			num = (short)1528168448;
			short num4 = num;
			return result;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0005C418 File Offset: 0x0005A618
		protected virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> GetFlexServerRadioFeatureList(string radioSerialNumber, out byte[] capabilityResponse)
		{
			short num = (short)1152909312;
			short num2 = num;
			num = (short)2057433367;
			short num3 = num;
			num = (short)2080698647;
			switch (num3 == num)
			{
			}
			num = (short)146604033;
			if (num != 0)
			{
			}
			num = (short)1857814528;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.Instance.RecoverLicenses(radioSerialNumber, out capabilityResponse);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0005C4CC File Offset: 0x0005A6CC
		protected virtual global::Motorola.CommonCPS.Server.EntityModel.FeatureList GetFlexServerDeviceFeatureList(string deviceID, out byte[] capabilityResponse)
		{
			short num = (short)292945920;
			short num2 = num;
			num = (short)323755516;
			short num3 = num;
			num = (short)1343102460;
			switch (num3 == num)
			{
			}
			num = (short)177405953;
			if (num != 0)
			{
			}
			num = (short)2045968384;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.Instance.RetrieveLicenses(deviceID, out capabilityResponse);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0005C580 File Offset: 0x0005A780
		protected global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet CreateValidateSetForRestoreAndRegisterCFS(global::Motorola.CommonCPS.Server.EntityModel.Radio existingDevice)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_121;
				case 1:
					if (validatedField == null)
					{
						num2 = (short)1212940290;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					validateEntitySet.ValidateEntityList.Add(validatedField);
					goto IL_1AC;
				case 2:
				{
					num2 = (short)1663942071;
					short num3 = num2;
					num2 = (short)961789367;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AC;
					default:
						goto IL_C4;
					}
					break;
				}
				case 3:
					if (existingDevice.WorkingCodeplug != null)
					{
						num2 = (short)1756626950;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return validateEntitySet;
				case 4:
					goto IL_176;
				case 5:
					if (validatedField == null)
					{
						num2 = (short)1119551488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					validateEntitySet.ValidateEntityList.Add(validatedField);
					num2 = (short)630521860;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(existingDevice.WorkingCodeplug);
					num2 = (short)604897285;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_1AC:
				num2 = (short)1451622403;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_C4:
			num2 = (short)1778712576;
			if (num2 != 0)
			{
			}
			num2 = (short)525402112;
			short num4 = num2;
			throw new global::System.Exception();
			IL_121:
			throw new global::System.Exception();
			IL_176:
			num2 = (short)1180696577;
			if (num2 != 0)
			{
			}
			return validateEntitySet;
			IL_2C:
			validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.RelatedObject = new global::System.Guid?(existingDevice.Uuid);
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(existingDevice);
			num2 = (short)1526202369;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0005C778 File Offset: 0x0005A978
		private void a(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radio.LastJob.JobStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_SCHEDULED)
					{
						num2 = (short)1563033614;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22E;
				case 1:
					goto IL_1CC;
				case 2:
					goto IL_2D2;
				case 3:
					num2 = (short)1606287367;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_67;
				case 5:
					if (radio.LastJob.JobStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_RUNNING)
					{
						num2 = (short)1763704841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22E;
				case 6:
					if (radio.LastJob.JobStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PENDING)
					{
						num2 = (short)1831600138;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22E;
				case 7:
				{
					num2 = (short)1132936780;
					short num3 = num2;
					num2 = (short)1707490892;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_67;
					default:
						num2 = (short)1937375232;
						if (num2 != 0)
						{
						}
						if (radio.LastJob != null)
						{
							num2 = (short)892928013;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 8:
					flag = false;
					num2 = (short)1929773058;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)272957446;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1961099276;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)2022572033;
					if (num2 != 0)
					{
					}
					goto IL_2D2;
				case 12:
				{
					num2 = (short)969408512;
					short num4 = num2;
					if (radio.LastJob.JobStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CREATED)
					{
						num2 = (short)793444353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 13:
					num2 = (short)20250624;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)1860829189;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (!flag)
					{
						num2 = (short)900268035;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22E;
				}
				goto IL_50;
				IL_67:
				if (radio is global::Motorola.CommonCPS.Server.EntityModel.PBBRadio)
				{
					num2 = (short)1236074504;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				flag = (radio.RadioStatus == 0);
				num2 = (short)1670643723;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2D2:
				num2 = (short)823787535;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1CC:
			IL_22E:
			throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.License_Recover_CheckRadioStatus, radio.SerialNumber));
			IL_50:
			flag = false;
			num2 = (short)1621753860;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400009D RID: 157
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService a;
	}
}
