using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000024 RID: 36
	internal abstract class DeviceServiceBase : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060004B9 RID: 1209 RVA: 0x0002D5A4 File Offset: 0x0002B7A4
		public DeviceServiceBase(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase validationServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService) : base(serverAccessor, validationServiceBase)
		{
			this.TemplateService = templateService;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0002D5C0 File Offset: 0x0002B7C0
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x0002D670 File Offset: 0x0002B870
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService TemplateService
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1928709215;
				short num2 = num;
				num = (short)1382728799;
				switch (num2 == num)
				{
				}
				num = (short)245104640;
				short num3 = num;
				num = (short)133038081;
				if (num != 0)
				{
				}
				num = (short)1510473728;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)731550511;
				short num2 = num;
				num = (short)191468335;
				switch (num2 == num)
				{
				}
				num = (short)1316880384;
				short num3 = num;
				num = (short)475070465;
				if (num != 0)
				{
				}
				num = (short)811401216;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0002D720 File Offset: 0x0002B920
		public virtual global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpdateCodeplugPassword(global::Motorola.CommonCPS.Server.EntityModel.PasswordInfo pwdInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet Set)
		{
			short num = (short)1952636132;
			short num2 = num;
			num = (short)1465703652;
			switch (num2 == num)
			{
			}
			num = (short)1213530112;
			short num3 = num;
			num = (short)1389756417;
			if (num != 0)
			{
			}
			num = (short)396034048;
			if (num != 0)
			{
			}
			return base.ServerAccessor.UpdateCodeplugPassword(pwdInfo, Set);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0002D7D8 File Offset: 0x0002B9D8
		public string GetFileNameForExportCodeplug(string serialNumber, string templateName, string configName, bool? hasPBA)
		{
			short num = (short)1370371314;
			short num2 = num;
			num = (short)354432242;
			switch (num2 == num)
			{
			}
			num = (short)966000640;
			short num3 = num;
			num = (short)1805320193;
			if (num != 0)
			{
			}
			num = (short)1311113216;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.GetFileNameForExportCodeplug(serialNumber, templateName, configName, hasPBA);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0002D898 File Offset: 0x0002BA98
		public void ExportCodeplug(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase selectedRadioModel, string fileName, global::Motorola.CommonCPS.Server.EntityModel.Radio existingDevice, string fieldError)
		{
			short num = (short)216858624;
			switch (num)
			{
			default:
			{
				num = (short)1231290369;
				if (num != 0)
				{
				}
				num = (short)1192230919;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Guid? fileUuid;
					switch (num2)
					{
					case 0:
					{
						fileUuid = existingDevice.CurrentCodeplug.FileUuid;
						num = (short)1392640000;
						short num3 = num;
						num = (short)830865417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)2144862213;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3A6;
								case 1:
									num = (short)468713472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile;
									string empty;
									if (!((global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService)base.ValidationService).ValidateDateProfileValue(apxDataProfile, (global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)existingDevice.CurrentCodeplug, out empty))
									{
										num = (short)571932675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_33A;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1704787969;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile = enumerator.Current;
									string empty = string.Empty;
									num = (short)388890626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_2DD;
									}
									continue;
								}
								IL_34D:
								num = (short)401408004;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2DD:
								goto IL_34D;
							}
							IL_33A:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Invalid_Data_Export, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportCodeplug_Error, null);
							IL_3A6:
							goto IL_C1;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_3B9;
					case 2:
						num = (short)448593924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (fileUuid == null)
						{
							num = (short)249757698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 4:
						if (selectedRadioModel.MismatchFlags)
						{
							num = (short)422445062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 5:
					{
						try
						{
							num = (short)1151860741;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_545;
								case 1:
								{
									num = (short)410588750;
									short num4 = num;
									num = (short)1672418894;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_4C6;
									default:
										goto IL_512;
									}
									break;
								}
								case 2:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1417740291;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem = enumerator2.Current;
									string empty2 = string.Empty;
									num = (short)697630724;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)111083520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
									string empty2;
									if (!((global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService)base.ValidationService).ValidateRadioIdRange(apxradioSystem.RadioId, apxradioSystem.SystemType.Value, apxradioSystem.SystemSubType.Value, apxradioSystem.ExpandedMDCIDRange, ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)existingDevice.CurrentCodeplug).CodeplugVersion, out empty2))
									{
										goto IL_4C6;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_403;
									}
									continue;
								}
								IL_405:
								num = (short)346095618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_403:
								goto IL_405;
								IL_4C6:
								num = (short)1187971073;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_512:
							num = (short)1987117056;
							if (num != 0)
							{
							}
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Invalid_Data_Export, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportCodeplug_Error, null);
							IL_545:
							goto IL_10B;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						return;
						IL_10B:
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)existingDevice.CurrentCodeplug).APXDataProfiles.GetEnumerator();
						num = (short)295239681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_299;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					case 8:
						if (existingDevice.CurrentCodeplug != null)
						{
							num = (short)1408696320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						if (fileUuid == null)
						{
							num = (short)1406140426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C1;
					case 10:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator2 = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)existingDevice.CurrentCodeplug).APXRadioSystems.GetEnumerator();
						num = (short)1464926213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_227;
					case 12:
						goto IL_BC;
					}
					IL_A1:
					if (existingDevice == null)
					{
						num = (short)1109327884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1653997576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C1:
					fileUuid = existingDevice.CurrentCodeplug.FileUuid;
					num = (short)1889861635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_204:
					this.a(existingDevice, fileName, fieldError);
					num = (short)759037963;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BC:
				goto IL_3B9;
				IL_227:
				return;
				IL_299:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ExportRadio_ConfigMismatch);
				IL_3B9:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND);
			}
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0002DE34 File Offset: 0x0002C034
		public virtual void ExportMNISXML(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase selectedRadioModel, string fileName, global::Motorola.CommonCPS.Server.EntityModel.Radio existingDevice, string fieldError)
		{
			short num = (short)283880143;
			short num2 = num;
			num = (short)508275407;
			switch (num2 == num)
			{
			}
			num = (short)322109440;
			if (num != 0)
			{
			}
			num = (short)1591017473;
			if (num != 0)
			{
			}
			num = (short)1802502144;
			short num3 = num;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0002DEDC File Offset: 0x0002C0DC
		public bool CanExportCodeplug(global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus, bool? hasPBA)
		{
			short num = (short)495242648;
			short num2 = num;
			num = (short)1499188632;
			switch (num2 == num)
			{
			}
			num = (short)2059534337;
			if (num != 0)
			{
			}
			num = (short)702939136;
			if (num != 0)
			{
			}
			num = (short)447938560;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.CanExportCodeplug(radioStatus, hasPBA);
		}

		// Token: 0x060004C1 RID: 1217
		public abstract global::Motorola.CommonCPS.Server.EntityModel.RadioSummary EditRadioFields(global::Motorola.CommonCPS.Server.EntityModel.Radio radioFromServer, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> fieldValues);

		// Token: 0x060004C2 RID: 1218
		public abstract global::Motorola.CommonCPS.Server.EntityModel.RadioSummary SubmitTransferRadioIdentity(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> transferRadioIdentityRecords);

		// Token: 0x060004C3 RID: 1219 RVA: 0x0002DF94 File Offset: 0x0002C194
		public global::Motorola.CommonCPS.Server.EntityModel.Radio ParseArchive(string filePath, bool IgnorePassword, string password, out global::System.Collections.Generic.Dictionary<int, int> optionCount)
		{
			short num = (short)930086913;
			if (num != 0)
			{
			}
			num = (short)1993003691;
			short num2 = num;
			num = (short)1604244139;
			switch (num2 == num)
			{
			}
			num = (short)875823104;
			if (num != 0)
			{
			}
			num = (short)295763968;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().ParseAchiveFile(filePath, IgnorePassword, password, out optionCount);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0002E050 File Offset: 0x0002C250
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult ValidateCanImportArchive(global::Motorola.CommonCPS.Server.EntityModel.Radio importingDevice, global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption? overwriteOption, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption importOption, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet overWriteRadioEntitySet, out global::Motorola.CommonCPS.Server.EntityModel.Radio existingDevice, out string warningMsg)
		{
			int a_ = 5;
			short num = (short)770375680;
			short num2 = num;
			num = (short)990445568;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_78;
				}
				for (;;)
				{
					IL_59:
					switch (num3)
					{
					case 0:
						goto IL_C6B;
					case 1:
						num = (short)1495793664;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1305477123;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (importingDevice.SerialNumber != null)
						{
							num = (short)212664324;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB4;
					case 4:
						importingDevice.SerialNumber = importingDevice.SerialNumber.ToUpper(global::System.Globalization.CultureInfo.CurrentCulture);
						num = (short)1428684801;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (importingDevice != null)
						{
							num = (short)2025455618;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB4;
					}
					goto IL_78;
				}
				IL_BB4:
				num = (short)1973878785;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ImportCodeplug_SaveError);
				IL_C6B:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_199;
					}
					string text;
					bool flag;
					for (;;)
					{
						IL_C2:
						global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField;
						global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption? overwriteOption2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption overwriteOption3;
						switch (num3)
						{
						case 0:
							if (existingDevice.LastJob != null)
							{
								num = (short)1575616533;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5D6;
						case 1:
							if (validatedField == null)
							{
								num = (short)29884436;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							overWriteRadioEntitySet.ValidateEntityList.Add(validatedField);
							num = (short)762708011;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeviceGroup_All;
							num = (short)967049234;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_3C6;
						case 4:
							num = (short)347406347;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							int? changeIndicator;
							if ((changeIndicator.Value & 2) != 0)
							{
								num = (short)1775894579;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_94E;
						}
						case 6:
							goto IL_A64;
						case 7:
						{
							global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService groupService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService;
							global::System.Guid? groupUuid = existingDevice.GroupUuid;
							string groupName = groupService.GetGroupName(groupUuid.Value);
							num = (short)920584232;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							if (overwriteOption2.GetValueOrDefault() == overwriteOption3 & overwriteOption2 != null)
							{
								num = (short)935264273;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_94E;
						case 9:
							if (groupUUID != null)
							{
								num = (short)1168310276;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4EE;
						case 10:
						{
							int? changeIndicator = existingDevice.WorkingCodeplug.ChangeIndicator;
							num = (short)796327941;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							if (!groupUUID.Equals(existingDevice.GroupUuid))
							{
								num = (short)1446576130;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4EE;
						case 12:
							text = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뺛", a_) + existingDevice.Group.Name + global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뺛", a_);
							num = (short)671416362;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (!(overwriteOption2.GetValueOrDefault() == overwriteOption3 & overwriteOption2 != null))
							{
								num = (short)1595015212;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_877;
						case 14:
							goto IL_4E9;
						case 15:
							goto IL_24C;
						case 16:
							if (existingDevice.WorkingCodeplug != null)
							{
								num = (short)1667301400;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_94E;
						case 17:
							num = (short)1798570000;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
						{
							if (existingDevice.Group != null)
							{
								num = (short)784269324;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Guid? groupUuid = existingDevice.GroupUuid;
							num = (short)77070367;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(existingDevice.WorkingCodeplug);
							num = (short)702087203;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							goto IL_A5F;
						case 21:
							validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(existingDevice.LastJob);
							num = (short)2044198913;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
						{
							int? changeIndicator = existingDevice.WorkingCodeplug.ChangeIndicator;
							num = (short)108855330;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							overwriteOption2 = overwriteOption;
							overwriteOption3 = global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption.Overwrite_Never;
							num = (short)977666061;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
						{
							int? changeIndicator = existingDevice.WorkingCodeplug.ChangeIndicator;
							num = (short)711000094;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							overwriteOption2 = overwriteOption;
							overwriteOption3 = global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption.Overwrite_Never;
							num = (short)894894112;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							goto IL_949;
						case 27:
							goto IL_81F;
						case 28:
							goto IL_9B4;
						case 29:
							if (existingDevice.WorkingCodeplug != null)
							{
								num = (short)1380646931;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24C;
						case 30:
						{
							int? changeIndicator;
							if (changeIndicator != null)
							{
								num = (short)2016411670;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_94E;
						}
						case 31:
						{
							global::System.Guid? groupUuid;
							if (groupUuid != null)
							{
								num = (short)670498823;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_326;
						}
						case 32:
							if (overwriteOption2.GetValueOrDefault() == overwriteOption3 & overwriteOption2 != null)
							{
								num = (short)511246362;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A64;
						case 33:
							if (validatedField == null)
							{
								num = (short)1613365276;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							overWriteRadioEntitySet.ValidateEntityList.Add(validatedField);
							num = (short)565837824;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
						{
							int? changeIndicator;
							if ((changeIndicator.Value & 16) != 0)
							{
								num = (short)1650917386;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_94E;
						}
						case 35:
							if (validatedField == null)
							{
								num = (short)939589659;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							overWriteRadioEntitySet.ValidateEntityList.Add(validatedField);
							num = (short)1493565455;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							goto IL_592;
						case 37:
							if (!string.IsNullOrEmpty(existingDevice.ModelNumber))
							{
								num = (short)639828013;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_592;
						case 38:
							if (flag)
							{
								num = (short)1858338839;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_877;
						case 39:
							if (existingDevice.LastJob != null)
							{
								num = (short)669253679;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C6;
						case 40:
						{
							string groupName;
							if (groupName == string.Empty)
							{
								num = (short)1001979952;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뺛", a_) + groupName + global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뺛", a_);
							num = (short)605814798;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 41:
							goto IL_73C;
						case 42:
							goto IL_6CC;
						case 43:
							goto IL_5D6;
						case 44:
							num = (short)28573745;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 45:
							this.ValidateIncompitableData(existingDevice, importingDevice);
							num = (short)550371364;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
							goto IL_A7C;
						case 47:
							base.CheckRadioWorkingCodeplugCanBeOverwrite(existingDevice);
							num = (short)1071054851;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 48:
							goto IL_67F;
						case 49:
							if (existingDevice == null)
							{
								num = (short)2074017833;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2106589223;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 50:
							if (flag)
							{
								num = (short)749666329;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A64;
						case 51:
							goto IL_2BA;
						}
						goto IL_199;
						IL_24C:
						result = global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult.Override;
						num = (short)1138556934;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_3C6:
						num = (short)104529957;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_4EE:
						overwriteOption2 = overwriteOption;
						overwriteOption3 = global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption.Overwrite_FlashCode_NOChange;
						num = (short)414056456;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_592:
						num = (short)1329201161;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_5D6:
						num = (short)1612251165;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_877:
						num = (short)1368522802;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_94E:
						overWriteRadioEntitySet.RelatedObject = new global::System.Guid?(existingDevice.Uuid);
						overWriteRadioEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
						overWriteRadioEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
						validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(existingDevice);
						num = (short)2080768033;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A64:
						num = (short)996016174;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2BA:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Warning_ImportCP_FlashCodeChanged_Override);
					IL_326:
					throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Exception_ImportCP_ExistedDevice, new string[]
					{
						existingDevice.SerialNumber,
						text
					}));
					IL_4E9:
					goto IL_326;
					IL_67F:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
					IL_6CC:
					goto IL_326;
					IL_73C:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
					IL_81F:
					throw new global::System.Exception();
					IL_949:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RADIO_HAS_EXISTS);
					IL_9B4:
					throw new global::System.Exception();
					IL_A5F:
					throw new global::System.Exception();
					IL_A7C:
					return result;
					IL_199:
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캛펝ﶡ쎥\udaa7첩쎫\udcad\uddaf펱\udab3햵\uddb7톽ꞿꗁꇃ듅", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햛킟춡횣튥\ud8a9쾫욭\ud9af쒱톳\ud9b7캹\udfbb횽辿닁", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쪛ﾝ첟쮡삣장\udca7쾩쾭\udeafﮱ\ud9b3욵ힷ좹좻ﾽ늿ꇁ곃꿅뻇꿉ﻏ雑믓돕ꯗ黙맛꣝觟臡臣ꏥ郧菩飫웭\ud9ef틱ꟳ苵駷裹裻", a_));
					flag = this.DoesDeviceExit(importingDevice.DeviceID, out existingDevice);
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캛펝ﶡ쎥\udaa7첩쎫\udcad\uddaf펱\udab3햵\uddb7톽ꞿꗁꇃ듅", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햛킟춡횣튥\ud8a9쾫욭\ud9af쒱톳\ud9b7캹\udfbb횽辿닁", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쪛ﾝ첟쮡삣장\udca7쾩쾭\udeafﮱ\ud9b3욵ힷ좹좻ﾽ늿ꇁ곃꿅뻇꿉ﻏ雑믓돕ꯗ黙맛꣝觟臡臣ꏥ郧菩飫웭\ud9ef틱뇳飵鳷", a_));
					num = (short)403439654;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_C2;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					if (!(ex.Message == global::Motorola.CommonCPS.ResourceRepository.Resources.RADIO_HAS_EXISTS))
					{
						if (!(ex.Message == global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Warning_ImportCP_FlashCodeChanged_Override))
						{
							throw;
						}
					}
					global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult resultForImportWithNeverOverride = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().GetResultForImportWithNeverOverride(importOption);
					if (resultForImportWithNeverOverride != global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult.NeverOverride)
					{
						if (resultForImportWithNeverOverride == global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult.NeverOverrideAndCreateConfig)
						{
							num = (short)486558033;
							short num4 = num;
							num = (short)1600014673;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_BA2;
							default:
								num = (short)716636160;
								if (num != 0)
								{
								}
								if (ex.Message == global::Motorola.CommonCPS.ResourceRepository.Resources.RADIO_HAS_EXISTS)
								{
									warningMsg = global::Motorola.CommonCPS.Common.CommonUtility.WarningMessageConverter.OriginalToSource(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(null, methodof(global::Motorola.CommonCPS.ResourceRepository.Resources.get_RADIO_HAS_EXISTS())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())), 0);
								}
								else
								{
									warningMsg = global::Motorola.CommonCPS.Common.CommonUtility.WarningMessageConverter.OriginalToSource(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(null, methodof(global::Motorola.CommonCPS.ResourceRepository.Resources.get_RMC_Warning_ImportCP_FlashCodeChanged_Override())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())), 0);
								}
								result = resultForImportWithNeverOverride;
								break;
							}
						}
						return result;
					}
					IL_BA2:
					throw new global::Motorola.Common.CustomException.CommonException(ex.Message);
				}
				goto IL_BB4;
				IL_78:
				result = global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult.NeverOverride;
				existingDevice = null;
				warningMsg = null;
				num = (short)994443269;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_59;
			}
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0002ECEC File Offset: 0x0002CEEC
		public virtual void CheckValidityForOverrideExistDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio curDevice, global::Motorola.CommonCPS.Server.EntityModel.Radio newDevice)
		{
			short num = (short)1984299008;
			short num2 = num;
			num = (short)840884794;
			short num3 = num;
			num = (short)3596858;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_11F:
				num = (short)1423376389;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1480589312;
				if (num != 0)
				{
				}
				num = (short)1330249731;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					num = (short)439287810;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (curDevice.ModelNumber != newDevice.ModelNumber)
					{
						num = (short)1131937799;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					if (newDevice == null)
					{
						num = (short)960430086;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11F;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_B8;
					}
					continue;
				case 4:
					num = (short)390397953;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)2085683201;
					if (num != 0)
					{
					}
					if (curDevice.RadioStatus != 0)
					{
						num = (short)1945436164;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					goto IL_1B6;
				case 7:
					goto IL_11A;
				}
				IL_B8:
				if (curDevice == null)
				{
					goto IL_1D7;
				}
				num = (short)1583415296;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_11A:
			throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ImportCodeplug_Override_ModelNumber_Error, new string[]
			{
				curDevice.SerialNumber
			}));
			IL_1B6:
			IL_1D7:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0002EEDC File Offset: 0x0002D0DC
		public bool DoesDeviceExit(string deviceID, out global::Motorola.CommonCPS.Server.EntityModel.Radio exisingDevice)
		{
			short num = (short)1173291008;
			short num2 = num;
			num = (short)1975840594;
			short num3 = num;
			num = (short)910028626;
			switch (num3 == num)
			{
			}
			num = (short)505610241;
			if (num != 0)
			{
			}
			num = (short)419233792;
			if (num != 0)
			{
			}
			exisingDevice = null;
			exisingDevice = base.ServerAccessor.GetRadioByDeviceID(deviceID, false);
			return exisingDevice != null;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0002EF9C File Offset: 0x0002D19C
		public void EditCodeplug(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, out string error)
		{
			byte[] fileContent;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radioRawData;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_E1;
					case 1:
						if (fileContent != null)
						{
							num2 = (short)947519488;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_17E;
					case 2:
					{
						global::System.Guid? fileUuid;
						if (fileUuid != null)
						{
							num2 = (short)1403060232;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_271;
					}
					case 3:
						goto IL_7D;
					case 4:
						num2 = (short)828506113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (radioRawData == null)
						{
							num2 = (short)502530051;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1267924999;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						goto IL_179;
					case 7:
					{
						if (radioRawData.WorkingCodeplug == null)
						{
							num2 = (short)690094086;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::System.Guid? fileUuid = radioRawData.WorkingCodeplug.Template.FileUuid;
						num2 = (short)674581992;
						short num3 = num2;
						num2 = (short)1619021288;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)90439680;
							if (num2 != 0)
							{
							}
							num2 = (short)647168002;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 8:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor = base.ServerAccessor;
						global::System.Guid? fileUuid = radioRawData.WorkingCodeplug.Template.FileUuid;
						fileContent = serverAccessor.GetFileContent(fileUuid.Value);
						num2 = (short)83361801;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 9:
						if (radioRawData != null)
						{
							num2 = (short)62062596;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_17E;
					}
					break;
				}
				IL_38:
				error = string.Empty;
				radioRawData = base.GetRadioRawData(device.DeviceUuid, true);
				num2 = (short)560726021;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_7D:
			num2 = (short)607191041;
			if (num2 != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_RadioNotExist);
			IL_E1:
			((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).EditTemplateByCPS(fileContent, radioRawData, null);
			return;
			IL_179:
			num2 = (short)1554120704;
			short num4 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CodeplugNotExist);
			IL_17E:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_EditCodeplug_MissArchive;
			return;
			IL_271:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_EditCodeplug_MissArchive;
		}

		// Token: 0x060004C8 RID: 1224
		public abstract string AddFileSuffix(string filePath);

		// Token: 0x060004C9 RID: 1225 RVA: 0x0002F224 File Offset: 0x0002D424
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary MoveDeviceToGroup(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.RadioManagement.UIModels.Group targetGp)
		{
			short num = (short)1040384000;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					if (targetGp == null)
					{
						num = (short)1907032066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18C;
				case 2:
					goto IL_17C;
				case 3:
					goto IL_5C;
				}
				IL_34:
				if (base.ServerAccessor.GetRadioByDeviceUuid(radio.Uuid, true) == null)
				{
					num = (short)1286275075;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)889411693;
					short num3 = num;
					num = (short)600529005;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5C;
					default:
					{
						num = (short)773193729;
						if (num != 0)
						{
						}
						num = (short)2424832;
						short num4 = num;
						num = (short)648413184;
						if (num != 0)
						{
						}
						validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
						validateEntitySet.RelatedObject = new global::System.Guid?(radio.Uuid);
						validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
						validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
						num = (short)2144141313;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
			IL_5C:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
			IL_17C:
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio);
			return base.ServerAccessor.MoveDeviceFromGroup(null, radio.Uuid, validateEntitySet);
			IL_18C:
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio);
			validateEntitySet.ValidateEntityList.Add(targetGp.AsValidatedField());
			return base.ServerAccessor.MoveDeviceFromGroup(targetGp.ID, radio.Uuid, validateEntitySet);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0002F3F4 File Offset: 0x0002D5F4
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary MoveDeviceToGroupBatch(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.RadioManagement.UIModels.Group targetGp)
		{
			short num = (short)1549533184;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					if (targetGp == null)
					{
						num = (short)1353121793;
						if (num != 0)
						{
						}
						num = (short)785121282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_195;
				case 2:
					goto IL_185;
				case 3:
					goto IL_5E;
				}
				IL_34:
				if (base.ServerAccessor.GetRadioByDeviceUuid(radio.Uuid, true) == null)
				{
					num = (short)302841859;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1735202952;
					short num3 = num;
					num = (short)1655773320;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5E;
					default:
					{
						num = (short)208732160;
						if (num != 0)
						{
						}
						num = (short)551288832;
						short num4 = num;
						validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
						validateEntitySet.RelatedObject = new global::System.Guid?(radio.Uuid);
						validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
						validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
						num = (short)274202625;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
			IL_5E:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
			IL_185:
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio);
			return base.ServerAccessor.MoveDevicesBatchOp(batchJobContainerUuid, null, radio.Uuid, validateEntitySet);
			IL_195:
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio);
			validateEntitySet.ValidateEntityList.Add(targetGp.AsValidatedField());
			return base.ServerAccessor.MoveDevicesBatchOp(batchJobContainerUuid, targetGp.ID, radio.Uuid, validateEntitySet);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0002F5CC File Offset: 0x0002D7CC
		public bool DeleteDevice(global::System.Guid batchJobContainerId, global::Motorola.CommonCPS.Server.EntityModel.Radio device)
		{
			short num = (short)909901824;
			short num2 = num;
			num = (short)1738035451;
			short num3 = num;
			num = (short)1490374907;
			switch (num3 == num)
			{
			}
			num = (short)1294139393;
			if (num != 0)
			{
			}
			num = (short)1023737856;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = global::Motorola.CommonCPS.RadioManagement.SharedServices.ValidateEntityBuilder.CreateValidateEntityForDeleteDevice(device);
			return base.ServerAccessor.DeleteDevice(batchJobContainerId, device, validateEntitySet);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0002F68C File Offset: 0x0002D88C
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary DiscardCodeplugChanges(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio)
		{
			short num = (short)149732181;
			short num2 = num;
			num = (short)766032725;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A1;
			case 1:
				break;
			default:
			{
				num = (short)1790181376;
				short num3 = num;
				break;
			}
			}
			num = (short)618921984;
			if (num != 0)
			{
			}
			num = (short)1367212033;
			if (num != 0)
			{
			}
			if (radio == null)
			{
				return null;
			}
			IL_A1:
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.RelatedObject = new global::System.Guid?(radio.DeviceUuid);
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
			validatedField.Uuid = radio.DeviceUuid;
			validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
			validatedField.Timestamp = radio.RadioTimestamp;
			validateEntitySet.ValidateEntityList.Add(validatedField);
			return base.ServerAccessor.DiscardCodeplugChanges(new global::System.Guid?(batchJobContainerUuid), radio.DeviceUuid, radio.SerialNumber, validateEntitySet);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0002F7B4 File Offset: 0x0002D9B4
		public virtual global::Motorola.CommonCPS.Server.EntityModel.RadioSummary AddRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio d)
		{
			short num = (short)550502400;
			short num2 = num;
			num = (short)2116320203;
			short num3 = num;
			num = (short)1303018443;
			switch (num3 == num)
			{
			}
			num = (short)2122252288;
			if (num != 0)
			{
			}
			num = (short)706150401;
			if (num != 0)
			{
			}
			return base.ServerAccessor.AddRadio(d);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0002F86C File Offset: 0x0002DA6C
		public global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioBySerialNumber(string deviceID, bool isDeep = false)
		{
			short num = (short)1625096192;
			short num2 = num;
			num = (short)1847903474;
			short num3 = num;
			num = (short)713082098;
			switch (num3 == num)
			{
			}
			num = (short)931069952;
			if (num != 0)
			{
			}
			num = (short)1418461185;
			if (num != 0)
			{
			}
			return base.ServerAccessor.GetRadioByDeviceID(deviceID, isDeep);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0002F920 File Offset: 0x0002DB20
		public global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioByDeviceID(string deviceID, bool isDeep = false)
		{
			short num = (short)1159987200;
			short num2 = num;
			num = (short)1654676471;
			short num3 = num;
			num = (short)1432443895;
			switch (num3 == num)
			{
			}
			num = (short)1127612417;
			if (num != 0)
			{
			}
			num = (short)1499856896;
			if (num != 0)
			{
			}
			return base.ServerAccessor.GetRadioByDeviceID(deviceID, isDeep);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0002F9D4 File Offset: 0x0002DBD4
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetRadioList(global::System.Collections.Generic.IList<global::System.Guid> rdIDList, bool isDeep = false)
		{
			short num = (short)1799421952;
			short num2 = num;
			num = (short)1349854361;
			short num3 = num;
			num = (short)649405593;
			switch (num3 == num)
			{
			}
			num = (short)1176961024;
			if (num != 0)
			{
			}
			num = (short)351404033;
			if (num != 0)
			{
			}
			return base.ServerAccessor.GetRadioList(rdIDList, isDeep);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0002FA8C File Offset: 0x0002DC8C
		public global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadio(global::System.Guid rdID, bool isDeep = false)
		{
			short num = (short)956104704;
			short num2 = num;
			num = (short)1653025082;
			short num3 = num;
			num = (short)1956981050;
			switch (num3 == num)
			{
			}
			num = (short)368181248;
			if (num != 0)
			{
			}
			num = (short)1039532033;
			if (num != 0)
			{
			}
			return base.ServerAccessor.GetRadio(rdID, isDeep);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0002FB44 File Offset: 0x0002DD44
		public bool ValidatePop25Enabled()
		{
			short num = (short)946864128;
			short num2 = num;
			num = (short)21272606;
			short num3 = num;
			num = (short)2021955614;
			switch (num3 == num)
			{
			}
			num = (short)1938030593;
			if (num != 0)
			{
			}
			num = (short)2049572864;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().CheckAstroPop25Enabled();
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0002FBF4 File Offset: 0x0002DDF4
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ImportRadioToServer(global::System.Guid batchJobContainerUuid, global::System.Guid? groupUUID, string filePath, global::Motorola.CommonCPS.Server.EntityModel.Radio deviceToImport, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption option, bool isOverwirted, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet, string warningMsg, global::System.Collections.Generic.Dictionary<int, int> optionCount)
		{
			int a_ = 8;
			short num = (short)546670923;
			short num2 = num;
			num = (short)1420855627;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_97:
				num = (short)763822080;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)716832768;
				if (num != 0)
				{
				}
				num = (short)621936642;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)504561667;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_369;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_93;
					}
					continue;
				case 3:
					if (deviceToImport.WorkingCodeplug == null)
					{
						num = (short)360054785;
						if (num != 0)
						{
						}
						num = (short)1646067713;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B0;
				case 4:
					goto IL_3F8;
				case 5:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
					{
						num = (short)1315110912;
						short num4 = num;
						num = (short)671285254;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3FA;
				case 6:
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂黊뷌ꏎ뻐닒뇔菖跘裚诜點짠쫢엤듦鷨諪鿬鯮", a_));
					this.UploadTTSVA(deviceToImport.WorkingCodeplug);
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂黊뷌ꏎ뻐닒뇔菖跘裚诜點짠쫢엤ꋦ蟨迪", a_));
					num = (short)2120679428;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_93;
				IL_B0:
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂鯊뿌꫎飐뻒ꗔ룖ꯘ꿚远뻞藠諢諤돦蛨룪裬鷮蟰雲蟴\udff6탸\udbfa껼课怀焂焄", a_));
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.PreImportRadioToServer(filePath, deviceToImport, option);
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂鯊뿌꫎飐뻒ꗔ룖ꯘ꿚远뻞藠諢諤돦蛨룪裬鷮蟰雲蟴\udff6탸\udbfa룼釾攀", a_));
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂黊뷌ꏎ뻐닒뇔臖飘￞닠韢蓤闦鷨", a_));
				this.UploadVA(deviceToImport.WorkingCodeplug);
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂黊뷌ꏎ뻐닒뇔臖飘￞ꓠ跢臤", a_));
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂黊뷌ꏎ뻐닒뇔铖飘飚룜귞闠諢菤軦諨諪駬諮苰\udbf2\udcf4ퟶ꫸迺鳼跾甀", a_));
				this.UploadCACertificates(deviceToImport.WorkingCodeplug);
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂黊뷌ꏎ뻐닒뇔铖飘飚룜귞闠諢菤軦諨諪駬諮苰\udbf2\udcf4ퟶ본闺駼", a_));
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂黊뷌ꏎ뻐닒뇔鏖还觚軜駞裠迢胤铦쇨싪췬볮藰鋲蟴菶", a_));
				this.UploadDVRSFiles(deviceToImport.WorkingCodeplug);
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂黊뷌ꏎ뻐닒뇔鏖还觚軜駞裠迢胤铦쇨싪췬ꫮ鿰韲", a_));
				num = (short)18022405;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_93:
				if (deviceToImport != null)
				{
					goto IL_97;
				}
				goto IL_B0;
			}
			IL_369:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CodeplugNotExist, global::Motorola.CommonCPS.ResourceRepository.Resources.ImportCodeplug_Error_NullCodeplug);
			IL_3F8:
			IL_3FA:
			this.IsSupportedLanguagePack(deviceToImport.WorkingCodeplug);
			deviceToImport.GroupUuid = groupUUID;
			string jobDescriptionForImportRadio = this.GetJobDescriptionForImportRadio(filePath, deviceToImport.SerialNumber);
			global::Motorola.CommonCPS.Server.EntityModel.ImportRadioBatchJobParameter importRadioBatchJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.ImportRadioBatchJobParameter(batchJobContainerUuid, deviceToImport, option, entitySet, new bool?(isOverwirted));
			importRadioBatchJobParameter.JobDescription = jobDescriptionForImportRadio;
			importRadioBatchJobParameter.WarningMessage = warningMsg;
			importRadioBatchJobParameter.OptionCount = optionCount;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂苊ꃌ뿎뻐ꇒꇔ藖룘뿚드냞짠쫢엤듦鷨諪鿬鯮", a_));
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result = base.ServerAccessor.ImportRadio(importRadioBatchJobParameter);
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춞瘝첨\ud9aa쮬삮쎰\udeb2풴\ud9b6\udab8\udeba껀꓂ꋄꋆ믈", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9e쒠햢첤쒦첨좬\uddae잰\udab2횴튶﮸\udaba캼\udabe", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횞철펢쪤햦\udda8寧첬쮮\ud8b0\udcb2\ud8b6\udeba쾼즾꓀뇂苊ꃌ뿎뻐ꇒꇔ藖룘뿚드냞짠쫢엤ꋦ蟨迪", a_));
			return result;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x000300C0 File Offset: 0x0002E2C0
		public string GetJobDescriptionForImportRadio(string filePath, string serialNumber)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1589224377;
					short num3 = num2;
					num2 = (short)1083155385;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_FC;
					}
					break;
				}
				case 1:
					if (!string.IsNullOrEmpty(serialNumber))
					{
						num2 = (short)1798242306;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 2:
				{
					num2 = (short)335872000;
					short num4 = num2;
					text = text + global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("놘", a_) + serialNumber + global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("나", a_);
					num2 = (short)2057699328;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_25;
			}
			IL_FC:
			num2 = (short)2059534336;
			if (num2 != 0)
			{
			}
			num2 = (short)492568577;
			if (num2 != 0)
			{
			}
			return text;
			IL_25:
			text = global::System.IO.Path.GetFileNameWithoutExtension(filePath);
			num2 = (short)585498625;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0003020C File Offset: 0x0002E40C
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ImportRadioFromCSV(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			short num = (short)173932544;
			short num2 = num;
			num = (short)59286336;
			short num3 = num;
			num = (short)104506176;
			switch (num3 == num)
			{
			}
			num = (short)1691746305;
			if (num != 0)
			{
			}
			num = (short)1707147264;
			if (num != 0)
			{
			}
			return base.ServerAccessor.ImportRadioFromCSV(batchJobContainerUuid, csvRequest, validateEntitySet);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000302C4 File Offset: 0x0002E4C4
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ApplyMVO(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug> defaultValues)
		{
			int a_ = 0;
			short num = (short)878641152;
			short num2 = num;
			num = (short)1618935808;
			switch (num)
			{
			default:
			{
				num = (short)604569600;
				int num3 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					case 1:
					{
						global::System.Guid? workingCodeplugUUID;
						if (workingCodeplugUUID != null)
						{
							num = (short)311164930;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8;
					}
					case 2:
					{
						num = (short)690023151;
						short num4 = num;
						num = (short)969992943;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8E;
						default:
						{
							num = (short)1147011072;
							if (num != 0)
							{
							}
							global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
							global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField2 = validatedField;
							global::System.Guid? workingCodeplugUUID = radio.WorkingCodeplugUUID;
							validatedField2.Uuid = workingCodeplugUUID.Value;
							validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Codeplug;
							validatedField.Timestamp = radio.CodeplugTimestamp;
							validateEntitySet.ValidateEntityList.Add(validatedField);
							num = (short)1677000708;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
						validateEntitySet.RelatedObject = new global::System.Guid?(radio.DeviceUuid);
						validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
						validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
						global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField3 = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
						validatedField3.Uuid = radio.DeviceUuid;
						validatedField3.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
						validatedField3.Timestamp = radio.RadioTimestamp;
						validateEntitySet.ValidateEntityList.Add(validatedField3);
						global::System.Guid? workingCodeplugUUID = radio.WorkingCodeplugUUID;
						num = (short)1394016257;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_189;
					}
					goto IL_88;
					IL_8E:
					num = (short)127336451;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_88:
					if (radio != null)
					{
						goto IL_8E;
					}
					goto IL_257;
				}
				IL_A8:
				global::Motorola.CommonCPS.Server.EntityModel.ApplyMVOBatchJobParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.ApplyMVOBatchJobParameter(batchJobContainerUuid, radio.DeviceUuid, defaultValues, validateEntitySet)
				{
					JobDescription = global::Motorola.CommonCPS.ResourceRepository.Resources.ApplyMVO + global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("궖릘", a_) + radio.SerialNumber
				};
				return base.ServerAccessor.ApplyMVO(parameter);
				IL_189:
				num = (short)1906835457;
				if (num != 0)
				{
				}
				goto IL_A8;
				IL_257:
				return null;
			}
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0003052C File Offset: 0x0002E72C
		public int GetCandidateMVORadioSummaryCount()
		{
			short num = (short)1232404480;
			short num2 = num;
			num = (short)526705672;
			short num3 = num;
			num = (short)229106696;
			switch (num3 == num)
			{
			}
			num = (short)2116550657;
			if (num != 0)
			{
			}
			num = (short)1803288576;
			if (num != 0)
			{
			}
			return base.ServerAccessor.GetCandidateMVORadioSummaryCount();
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x000305E0 File Offset: 0x0002E7E0
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListMVOCandidateRadioSummary(int startIndex, int length)
		{
			short num = (short)1573912576;
			short num2 = num;
			num = (short)408830072;
			short num3 = num;
			num = (short)1320894584;
			switch (num3 == num)
			{
			}
			num = (short)1796276225;
			if (num != 0)
			{
			}
			num = (short)1635844096;
			if (num != 0)
			{
			}
			return base.ServerAccessor.ListCandidateMVORadioSummary(startIndex, length);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00030698 File Offset: 0x0002E898
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption GetImportOption(bool isCreateRadio, bool isCreateTemplate, bool isCreateConfig, bool isApply)
		{
			short num = (short)918421504;
			short num2 = num;
			num = (short)1034593991;
			short num3 = num;
			num = (short)1086891719;
			switch (num3 == num)
			{
			}
			num = (short)1762131969;
			if (num != 0)
			{
			}
			num = (short)1978335232;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.GetImportOption(isCreateRadio, isCreateTemplate, isCreateConfig, isApply);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00030754 File Offset: 0x0002E954
		public bool CanImportRadio(bool isCreateRadio, bool isCreateConfig)
		{
			short num = (short)140115968;
			short num2 = num;
			num = (short)1786917595;
			short num3 = num;
			num = (short)1748447963;
			switch (num3 == num)
			{
			}
			num = (short)724107265;
			if (num != 0)
			{
			}
			num = (short)1542586368;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.CanImportRadio(isCreateRadio, isCreateConfig);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0003080C File Offset: 0x0002EA0C
		public bool IsInitializeImportRadio(out bool canOverride)
		{
			short num = (short)357040128;
			short num2 = num;
			num = (short)64744486;
			short num3 = num;
			num = (short)257223718;
			switch (num3 == num)
			{
			}
			num = (short)1567817728;
			if (num != 0)
			{
			}
			num = (short)1115881473;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.IsInitializeImportRadio(out canOverride);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000308C4 File Offset: 0x0002EAC4
		public global::System.Collections.Generic.List<string> GetSupportedCodelugVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio)
		{
			short num = (short)1062207488;
			short num2 = num;
			num = (short)2066121600;
			short num3 = num;
			num = (short)1787593600;
			switch (num3 == num)
			{
			}
			num = (short)510918656;
			if (num != 0)
			{
			}
			num = (short)1814364161;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().GetSupportedCodelugVersion(productFamily, maxCodeplugVersionOfRadio);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0003097C File Offset: 0x0002EB7C
		public global::System.Collections.Generic.List<string> GetSupportedCodelugVersion_forUpgradeCPVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio)
		{
			short num = (short)19529728;
			short num2 = num;
			num = (short)56843120;
			short num3 = num;
			num = (short)1580555120;
			switch (num3 == num)
			{
			}
			num = (short)1489633281;
			if (num != 0)
			{
			}
			num = (short)2101149696;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().GetSupportedCodelugVersion_forUpgradeCPVersion(productFamily, maxCodeplugVersionOfRadio);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00030A34 File Offset: 0x0002EC34
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? GetDefaultRegion()
		{
			short num = (short)1919156224;
			short num2 = num;
			num = (short)1781617298;
			short num3 = num;
			num = (short)1411863186;
			switch (num3 == num)
			{
			}
			num = (short)805961728;
			if (num != 0)
			{
			}
			num = (short)2012282881;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RegistryAndSettingProxy.GetInstance().RegistryAndSetting.GetDefaultRegion();
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00030AEC File Offset: 0x0002ECEC
		public global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest HandleTemplateAndConfigForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio, string templateName, string configName, string copiedRadioSN, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.RadioManagement.SharedServices.ImportCSVCache cache, ref global::System.Collections.Generic.List<string> warningList)
		{
			short num = (short)702414848;
			short num2 = num;
			num = (short)1752936148;
			short num3 = num;
			num = (short)662548180;
			switch (num3 == num)
			{
			}
			num = (short)1287913473;
			if (num != 0)
			{
			}
			num = (short)817889280;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.HandleTemplateAndConfigForImportCSV(existedRadio, templateName, configName, copiedRadioSN, radioRq, cache, ref warningList);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00030BB0 File Offset: 0x0002EDB0
		public global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest HandleIPProgramSystemForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio, string ipProgramSystem, string copiedRadioSN, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.RadioManagement.SharedServices.ImportCSVCache cache, ref global::System.Collections.Generic.List<string> warningList)
		{
			short num = (short)966524928;
			short num2 = num;
			num = (short)318598683;
			short num3 = num;
			num = (short)1812033051;
			switch (num3 == num)
			{
			}
			num = (short)1523908609;
			if (num != 0)
			{
			}
			num = (short)1837957120;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.HandleIPProgramSystemForImportCSV(existedRadio, ipProgramSystem, copiedRadioSN, radioRq, cache, ref warningList);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00030C70 File Offset: 0x0002EE70
		public global::Motorola.CommonCPS.Server.EntityModel.Job ScheduleJob(global::System.Guid batchJobContainerUuid, global::System.Guid? readWriteJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.JobRequest jobRq, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet)
		{
			short num = (short)2091384832;
			short num2 = num;
			num = (short)777573220;
			short num3 = num;
			num = (short)80335716;
			switch (num3 == num)
			{
			}
			num = (short)930349056;
			if (num != 0)
			{
			}
			num = (short)1937965057;
			if (num != 0)
			{
			}
			return base.ServerAccessor.AddReadWriteJob(batchJobContainerUuid, readWriteJobContainerUuid, jobRq, validateSet);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00030D2C File Offset: 0x0002EF2C
		public virtual global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet BuildValidateSetForScheduleJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug currentCodeplug, global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug)
		{
			short num = (short)91619328;
			short num2 = num;
			num = (short)1831629795;
			short num3 = num;
			num = (short)2048947171;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_124:
				num = (short)874840072;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1526923264;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				break;
			}
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet;
			for (;;)
			{
				IL_7B:
				switch (num4)
				{
				case 0:
					if (workingCodeplug != null)
					{
						num = (short)776273927;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return validateSet;
				case 1:
					if (currentCodeplug != null)
					{
						num = (short)544604163;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E4;
				case 2:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateSet.ValidateEntityList, radio.LastJob);
					num = (short)1619787782;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1C3;
				case 4:
					if (radio.LastJob != null)
					{
						num = (short)759234562;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18E;
				case 5:
					goto IL_18C;
				case 6:
					goto IL_18E;
				case 7:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateSet.ValidateEntityList, workingCodeplug);
					num = (short)2017984517;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_E4;
				}
				goto IL_A5;
				IL_E4:
				num = (short)1655504896;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_18E:
				num = (short)2023620609;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_18C:
			return validateSet;
			IL_1C3:
			num = (short)927596545;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateSet.ValidateEntityList, currentCodeplug);
			goto IL_124;
			IL_A5:
			validateSet = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidateSet(radio, null);
			num = (short)1613889540;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7B;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00030F28 File Offset: 0x0002F128
		protected virtual bool IsSupportedLanguagePack(global::Motorola.CommonCPS.Server.EntityModel.Codeplug cp)
		{
			short num = (short)2058835603;
			short num2 = num;
			num = (short)1717917331;
			switch (num2 == num)
			{
			}
			num = (short)1141964801;
			if (num != 0)
			{
			}
			num = (short)1265369088;
			if (num != 0)
			{
			}
			num = (short)877395968;
			short num3 = num;
			return true;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00030FD8 File Offset: 0x0002F1D8
		protected virtual void UploadVA(global::Motorola.CommonCPS.Server.EntityModel.Codeplug cp)
		{
			short num = (short)251894271;
			short num2 = num;
			num = (short)1693293055;
			switch (num2 == num)
			{
			}
			num = (short)845283329;
			if (num != 0)
			{
			}
			num = (short)551878656;
			if (num != 0)
			{
			}
			num = (short)767688704;
			short num3 = num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> vapackages = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().GetVAPackages(cp);
			base.UploadVAPackages(vapackages);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00031094 File Offset: 0x0002F294
		protected virtual void UploadTTSVA(global::Motorola.CommonCPS.Server.EntityModel.Codeplug cp)
		{
			short num = (short)2094373094;
			short num2 = num;
			num = (short)402692326;
			switch (num2 == num)
			{
			}
			num = (short)1523712001;
			if (num != 0)
			{
			}
			num = (short)754450432;
			if (num != 0)
			{
			}
			num = (short)15204352;
			short num3 = num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> ttspackages = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().GetTTSPackages(cp);
			base.UploadVAPackages(ttspackages);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00031154 File Offset: 0x0002F354
		protected virtual void UploadCACertificates(global::Motorola.CommonCPS.Server.EntityModel.Codeplug cp)
		{
			short num = (short)1720451073;
			if (num != 0)
			{
			}
			num = (short)244357630;
			short num2 = num;
			num = (short)1811388926;
			switch (num2 == num)
			{
			}
			num = (short)36831232;
			if (num != 0)
			{
			}
			num = (short)739246080;
			short num3 = num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> cacertificatePackages = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().GetCACertificatePackages(cp);
			base.UploadCACertificatePackages(cacertificatePackages);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0003120C File Offset: 0x0002F40C
		protected virtual void UploadDVRSFiles(global::Motorola.CommonCPS.Server.EntityModel.Codeplug cp)
		{
			short num = (short)24117249;
			if (num != 0)
			{
			}
			num = (short)842924118;
			short num2 = num;
			num = (short)1779236950;
			switch (num2 == num)
			{
			}
			num = (short)326565888;
			if (num != 0)
			{
			}
			num = (short)1808531456;
			short num3 = num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> dvrsfilePackages = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().GetDVRSFilePackages(cp);
			base.UploadDVRSFilePackages(dvrsfilePackages);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000312C8 File Offset: 0x0002F4C8
		protected virtual void UploadTTS(global::Motorola.CommonCPS.Server.EntityModel.Codeplug cp)
		{
			short num = (short)899993664;
			short num2 = num;
			num = (short)1408290880;
			switch (num2 == num)
			{
			}
			num = (short)162856961;
			if (num != 0)
			{
			}
			num = (short)1090453504;
			if (num != 0)
			{
			}
			num = (short)1054867456;
			short num3 = num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> ttspackages = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().GetTTSPackages(cp);
			base.UploadVAPackages(ttspackages);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00031384 File Offset: 0x0002F584
		protected virtual bool ValidateIncompitableData(global::Motorola.CommonCPS.Server.EntityModel.Radio existingDevice, global::Motorola.CommonCPS.Server.EntityModel.Radio importingDevice)
		{
			while (!(existingDevice.ModelNumber != importingDevice.ModelNumber))
			{
				short num = (short)87368768;
				short num2 = num;
				num = (short)1914774592;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2003435520;
					short num3 = num;
					num = (short)172687360;
					if (num != 0)
					{
					}
					num = (short)1885405185;
					if (num != 0)
					{
					}
					return true;
				}
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ImportCodeplug_Override_ModelNumber_Error, new string[]
			{
				existingDevice.SerialNumber
			}));
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00031464 File Offset: 0x0002F664
		private void a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, string A_1, string A_2)
		{
			short num = (short)1055522817;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BE;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					if (A_0.CurrentCodeplug != null)
					{
						num = (short)707198976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CB;
				case 3:
					goto IL_51;
				}
				IL_35:
				if (A_0.CurrentCodeplug == null)
				{
					num = (short)503316483;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)893583361;
					if (num != 0)
					{
					}
					num = (short)1409941506;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_51:
			goto IL_C0;
			IL_BE:
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().ExportDevice(A_0, A_1, A_2);
			return;
			IL_C0:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CodeplugNotExist);
			IL_CB:
			num = (short)723822531;
			short num3 = num;
			num = (short)164472771;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C0;
			case 1:
				break;
			default:
			{
				num = (short)378601472;
				short num4 = num;
				break;
			}
			}
			num = (short)859635712;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_CODEPLUG_NOT_FOUND, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportCodeplug_Error, null);
		}

		// Token: 0x0400003A RID: 58
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService a;
	}
}
