using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ASK.Interface;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.GenericModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200005F RID: 95
	internal class ASTRORadioService : global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060006CF RID: 1743 RVA: 0x00046970 File Offset: 0x00044B70
		public ASTRORadioService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService astroValidationService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROTemplateService astroTemplateService) : base(serverAccessor, astroValidationService, astroTemplateService)
		{
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00046988 File Offset: 0x00044B88
		public void Reset(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio device, string password)
		{
			short num = (short)866648064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				global::System.Guid? guid;
				global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						if (guid == null)
						{
							goto IL_18E;
						}
						num = (short)1321524762;
						short num3 = num;
						num = (short)1213783578;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1735786496;
							if (num != 0)
							{
							}
							num = (short)1167523845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_189;
					case 2:
						goto IL_18E;
					case 3:
						if (guid != null)
						{
							num = (short)81199108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_257;
					case 4:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
						global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField2 = validatedField;
						guid = device.WorkingCodeplugUUID;
						validatedField2.Uuid = guid.Value;
						validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Codeplug;
						validatedField.Timestamp = device.CodeplugTimestamp;
						validateEntitySet.ValidateEntityList.Add(validatedField);
						num = (short)1824915457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField3 = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
						global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField4 = validatedField3;
						guid = device.JobUuid;
						validatedField4.Uuid = guid.Value;
						validatedField3.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Job;
						validatedField3.Timestamp = device.JobTimestamp;
						validateEntitySet.ValidateEntityList.Add(validatedField3);
						num = (short)934871042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_46;
					IL_18E:
					guid = device.WorkingCodeplugUUID;
					num = (short)543031296;
					short num4 = num;
					num = (short)1223819267;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_189:
				IL_257:
				num = (short)152502273;
				if (num != 0)
				{
				}
				base.ServerAccessor.Reset(device.DeviceUuid, null, null, password, null, validateEntitySet);
				return;
				IL_46:
				validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
				validateEntitySet.RelatedObject = new global::System.Guid?(device.DeviceUuid);
				validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
				validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
				global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField5 = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
				validatedField5.Uuid = device.DeviceUuid;
				validatedField5.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
				validatedField5.Timestamp = device.RadioTimestamp;
				validateEntitySet.ValidateEntityList.Add(validatedField5);
				guid = device.JobUuid;
				num = (short)840957952;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00046C48 File Offset: 0x00044E48
		public void ExportDVRS(global::System.Guid radioId, string fileName)
		{
			short num = (short)384565249;
			if (num != 0)
			{
			}
			num = (short)227606528;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid;
				for (;;)
				{
					IL_50:
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					switch (num2)
					{
					case 0:
						goto IL_127;
					case 1:
					{
						try
						{
							num = (short)1900871683;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1775566852;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem = enumerator.Current;
									string empty = string.Empty;
									num = (short)1905131525;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_288;
								case 2:
									goto IL_26A;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_196;
									}
									continue;
								case 4:
									num = (short)952762369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
									string empty;
									if (!((global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService)base.ValidationService).ValidateRadioIdRange(apxradioSystem.RadioId, apxradioSystem.SystemType.Value, apxradioSystem.SystemSubType.Value, apxradioSystem.ExpandedMDCIDRange, apxcodeplug.CodeplugVersion, out empty))
									{
										num = (short)1239089154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_198:
								num = (short)1142423552;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_196:
								goto IL_198;
							}
							IL_26A:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Invalid_Data_Export, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportCodeplug_Error, null);
							IL_288:
							goto IL_12C;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_29B;
						IL_12C:
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2 = apxcodeplug.APXDataProfiles.GetEnumerator();
						num = (short)926613508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_2DE;
					case 3:
					{
						num = (short)282049544;
						short num3 = num;
						num = (short)1264892936;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_42D;
						default:
						{
							num = (short)1482293248;
							short num4 = num;
							num = (short)2064777216;
							if (num != 0)
							{
							}
							if (radioByDeviceUuid == null)
							{
								num = (short)103022592;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_29B;
						}
						}
						break;
					}
					case 4:
						goto IL_152;
					case 5:
					{
						if (apxcodeplug == null)
						{
							num = (short)5373954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator = apxcodeplug.APXRadioSystems.GetEnumerator();
						num = (short)936378369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6F;
					IL_29B:
					apxcodeplug = (radioByDeviceUuid.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num = (short)786437;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_127:
				goto IL_3EE;
				IL_152:
				try
				{
					num = (short)1100808195;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
							global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile;
							string empty2;
							if (!((global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService)base.ValidationService).ValidateDateProfileValue(apxDataProfile, apxcodeplug, out empty2))
							{
								num = (short)2079784964;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_3DE;
						case 2:
							num = (short)1550450689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_322;
							}
							continue;
						case 4:
							goto IL_375;
						case 5:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2;
							if (!enumerator2.MoveNext())
							{
								num = (short)1118240770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile = enumerator2.Current;
							string empty2 = string.Empty;
							num = (short)1709637632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_388:
						num = (short)1152647173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_322:
						goto IL_388;
					}
					IL_375:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Invalid_Data_Export, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportCodeplug_Error, null);
					IL_3DE:
					goto IL_42D;
				}
				finally
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2;
					((global::System.IDisposable)enumerator2).Dispose();
				}
				goto IL_3EE;
				IL_2DE:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CodeplugNotExist);
				IL_3EE:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND);
				IL_42D:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().ExportDVRS(radioByDeviceUuid, fileName);
				return;
				IL_6F:
				radioByDeviceUuid = base.ServerAccessor.GetRadioByDeviceUuid(radioId, true);
				num = (short)2092761091;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000470C4 File Offset: 0x000452C4
		public void AutoGenerateRelatedIPs(ref string peerIP, ref string subscriberIP, ref string bluetoothDUNPeerIP, ref string bluetoothDUNSubscriberIP)
		{
			switch (0)
			{
			case 0:
				goto IL_8C;
			}
			int num;
			short num2;
			string empty;
			global::System.Collections.Generic.IList<string> list;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!string.IsNullOrEmpty(peerIP))
					{
						num2 = (short)2046427157;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DD;
				case 1:
					peerIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(subscriberIP, peerIP, out empty);
					peerIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(peerIP, list);
					list.Add(peerIP);
					num2 = (short)1531772952;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_DD;
				case 3:
					if (!string.IsNullOrEmpty(bluetoothDUNPeerIP))
					{
						num2 = (short)1307115542;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_420;
				case 4:
					list.Add(peerIP);
					num2 = (short)594739215;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1921646592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					list.Add(subscriberIP);
					num2 = (short)1213399057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (!string.IsNullOrEmpty(bluetoothDUNSubscriberIP))
					{
						num2 = (short)835059742;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_49D;
				case 8:
					goto IL_49D;
				case 9:
					if (string.IsNullOrEmpty(bluetoothDUNSubscriberIP))
					{
						num2 = (short)524025869;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					num2 = (short)1233518593;
					if (num2 != 0)
					{
					}
					bluetoothDUNSubscriberIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(bluetoothDUNPeerIP, bluetoothDUNSubscriberIP, out empty);
					bluetoothDUNSubscriberIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(bluetoothDUNSubscriberIP, list);
					list.Add(bluetoothDUNSubscriberIP);
					num2 = (short)1951662109;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (string.IsNullOrEmpty(peerIP))
					{
						num2 = (short)306839553;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11F;
				case 12:
					if (!string.IsNullOrEmpty(bluetoothDUNPeerIP))
					{
						num2 = (short)1667563530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 13:
					num2 = (short)1447165964;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_51C;
				case 15:
					goto IL_45E;
				case 16:
					if (!string.IsNullOrEmpty(subscriberIP))
					{
						num2 = (short)683737094;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15C;
				case 17:
					goto IL_15C;
				case 18:
					if (!string.IsNullOrEmpty(bluetoothDUNSubscriberIP))
					{
						num2 = (short)1720778775;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E6;
				case 19:
					num2 = (short)770310155;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (string.IsNullOrEmpty(bluetoothDUNPeerIP))
					{
						num2 = (short)1777664014;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E6;
				case 21:
					subscriberIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(peerIP, subscriberIP, out empty);
					subscriberIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(subscriberIP, list);
					list.Add(subscriberIP);
					num2 = (short)903479298;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
				{
					list.Add(bluetoothDUNPeerIP);
					num2 = (short)266076160;
					short num3 = num2;
					num2 = (short)449445913;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 23:
					num2 = (short)570425364;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					goto IL_DD;
				case 25:
					goto IL_420;
				case 26:
					if (string.IsNullOrEmpty(subscriberIP))
					{
						num2 = (short)750059525;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DD;
				case 27:
					if (!string.IsNullOrEmpty(subscriberIP))
					{
						num2 = (short)969146387;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11F;
				case 28:
					if (!string.IsNullOrEmpty(peerIP))
					{
						num2 = (short)1954283524;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_45E;
				case 29:
					goto IL_3D3;
				case 30:
					list.Add(bluetoothDUNSubscriberIP);
					num2 = (short)1852768264;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_8C;
				IL_DD:
				num2 = (short)1547829266;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_11F:
				num2 = (short)1241710618;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_15C:
				num2 = (short)886308867;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2E6:
				num2 = (short)1645382246;
				short num4 = num2;
				num2 = (short)315198054;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_15C;
				default:
					num2 = (short)1307574272;
					if (num2 != 0)
					{
					}
					num2 = (short)1343619081;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_420:
				num2 = (short)1027014663;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_45E:
				num2 = (short)1128202256;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_49D:
				num2 = (short)527237147;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_3D3:
			return;
			IL_51C:
			bluetoothDUNPeerIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(bluetoothDUNSubscriberIP, bluetoothDUNPeerIP, out empty);
			bluetoothDUNPeerIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(bluetoothDUNPeerIP, list);
			list.Add(bluetoothDUNPeerIP);
			return;
			IL_8C:
			empty = string.Empty;
			new global::System.Collections.Generic.List<string>();
			list = new global::System.Collections.Generic.List<string>();
			num2 = (short)2055667740;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00047674 File Offset: 0x00045874
		public void ValidateAstroWriting(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio, bool enableWriteProtect, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference Transport, bool isWriteProtected, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP)
		{
			short num = (short)745799681;
			if (num != 0)
			{
			}
			num = (short)425492888;
			short num2 = num;
			num = (short)94339480;
			switch (num2 == num)
			{
			}
			num = (short)1140588544;
			if (num != 0)
			{
			}
			num = (short)1666121728;
			short num3 = num;
			global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> collection = null;
			bool? flag = null;
			this.ValidateAstroWriting(radio, enableWriteProtect, Transport, isWriteProtected, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, out updatedCP, ref collection, ref flag);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00047740 File Offset: 0x00045940
		public void ValidateAstroWriting(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio, bool enableWriteProtect, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference Transport, bool isWriteProtected, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP, ref global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> attachedASKs, ref bool? isSpecialKeyAttached)
		{
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureOperation instance;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROTemplateOperation astrotemplateOperation;
			short num;
			for (;;)
			{
				instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance();
				astrotemplateOperation = (instance as global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROTemplateOperation);
				if (astrotemplateOperation != null)
				{
					break;
				}
				num = (short)46349654;
				short num2 = num;
				num = (short)1233337686;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_87;
				}
			}
			num = (short)1406468096;
			short num3 = num;
			astrotemplateOperation.ValidateAstroWriting(radio, enableWriteProtect, (int)Transport, isWriteProtected, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, out updatedCP, ref attachedASKs, ref isSpecialKeyAttached);
			return;
			IL_87:
			num = (short)439877632;
			if (num != 0)
			{
			}
			num = (short)301203457;
			if (num != 0)
			{
			}
			instance.ValidateAstroWriting(radio, enableWriteProtect, (int)Transport, isWriteProtected, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, out updatedCP);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00047824 File Offset: 0x00045A24
		public void ValidateForeignIP(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport)
		{
			short num = (short)1144258561;
			if (num != 0)
			{
			}
			num = (short)778230286;
			short num2 = num;
			num = (short)1387256334;
			switch (num2 == num)
			{
			}
			num = (short)1694826496;
			if (num != 0)
			{
			}
			num = (short)2059796480;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().ValidateForeignIP(radio, transport);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000478D8 File Offset: 0x00045AD8
		public void CheckDevicesIsMatchFlashKey(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> selectedDevices, out string newFlashCode, out string warning)
		{
			short num = (short)258774007;
			short num2 = num;
			num = (short)1755223031;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_21A;
			case 1:
				break;
			default:
			{
				num = (short)102039552;
				short num3 = num;
				break;
			}
			}
			num = (short)1407451136;
			if (num != 0)
			{
			}
			warning = null;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_9C;
				}
				int num4;
				for (;;)
				{
					IL_86:
					switch (num4)
					{
					case 0:
						goto IL_20B;
					case 1:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid = base.ServerAccessor.GetRadioByDeviceUuid(selectedDevices[0].Uuid, true);
						if (radioByDeviceUuid == null)
						{
							goto Block_3;
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = radioByDeviceUuid.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
						byte[] astroPurchasedFlashCode = apxcodeplug.AstroPurchasedFlashCode;
						if (apxcodeplug == null)
						{
							goto Block_4;
						}
						global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroReleaseFlashKey();
						global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo flashKeyInfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().ReadFlashKey(selectedDevices[0].ModelNumber, astroPurchasedFlashCode);
						if (flashKeyInfo == null)
						{
							goto Block_5;
						}
						newFlashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroDecodeFlashCode(flashKeyInfo.NewFlashCode);
						if (selectedDevices.Count > flashKeyInfo.UpgradesRemaining)
						{
							goto Block_6;
						}
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsEquals(flashKeyInfo.OldFlashCode, astroPurchasedFlashCode))
						{
							goto Block_7;
						}
						if (radioByDeviceUuid.RadioFeatures.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature ft)
						{
							short num5 = (short)582545625;
							short num6 = num5;
							num5 = (short)2103308505;
							switch (num6 == num5)
							{
							}
							num5 = (short)172228609;
							if (num5 != 0)
							{
							}
							num5 = (short)1102708736;
							if (num5 != 0)
							{
							}
							num5 = (short)1796210688;
							short num7 = num5;
							return ft.DisplayStatus == 16;
						}).ToList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>().Count > 0)
						{
							num = (short)1690959874;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F3;
					}
					case 2:
						warning = global::Motorola.CommonCPS.ResourceRepository.Resources.ASTRO_RMC_Flashport_HasRegisteredCFS;
						num = (short)539361283;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1F3;
					}
					goto IL_9C;
					IL_1F3:
					num = (short)1081606144;
					num4 = (int)((global::System.IntPtr)num);
				}
				Block_3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				Block_4:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				Block_5:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroReleaseFlashKey();
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_FlashKey_NotFound);
				Block_6:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_FlashKeyReminingCountNotEnough);
				Block_7:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_FlashKey_ValidateFailed);
				IL_20B:
				goto IL_21A;
				IL_9C:
				newFlashCode = null;
				num = (short)418054145;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_86;
			}
			catch (global::System.Exception)
			{
				global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroReleaseFlashKey();
				throw;
			}
			IL_21A:
			num = (short)1965555713;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00047B44 File Offset: 0x00045D44
		public bool IsRadioSupportWriteLPWhenUpgrade(global::System.Guid radioUuid, string packageVersion)
		{
			short num = (short)1986657241;
			short num2 = num;
			num = (short)1507261401;
			switch (num2 == num)
			{
			}
			num = (short)644546561;
			if (num != 0)
			{
			}
			num = (short)102825984;
			if (num != 0)
			{
			}
			num = (short)1785921536;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().IsRadioSupportWriteLPWhenUpgrade(radioUuid, packageVersion);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00047BFC File Offset: 0x00045DFC
		public void GetSyncDataForUpgrade(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware firmware, byte[] flashCode, string iButtonSerialNumber, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios, int allRadioCount, bool isRefresh, global::ASK.Interface.ISystemKeyData systemID, out global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData, string codeplugVersion = null)
		{
			short num = (short)1009883340;
			short num2 = num;
			num = (short)1253546188;
			switch (num2 == num)
			{
			}
			num = (short)1658781697;
			if (num != 0)
			{
			}
			num = (short)1374683136;
			if (num != 0)
			{
			}
			num = (short)727908352;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.GetSyncDataForUpgrade(radio, firmware, flashCode, iButtonSerialNumber, cross712Radios, allRadioCount, isRefresh, systemID, out syncData, codeplugVersion);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00047CC8 File Offset: 0x00045EC8
		public void CleanForUpgrade(global::System.Collections.Generic.IList<global::System.Guid> upgradeSuccessfulRadios, global::System.Collections.Generic.IList<global::System.Guid> Cross712Radios, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData)
		{
			short num = (short)806941822;
			short num2 = num;
			num = (short)1176702;
			switch (num2 == num)
			{
			}
			num = (short)275513344;
			if (num != 0)
			{
			}
			num = (short)1570177025;
			if (num != 0)
			{
			}
			num = (short)2047082496;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.CleanForUpgrade(upgradeSuccessfulRadios, Cross712Radios, syncData);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00047D80 File Offset: 0x00045F80
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeASTRORadioBatch(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radioToUpgrdae, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData, global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo flashKeyInfo, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios)
		{
			short num = (short)169937477;
			short num2 = num;
			num = (short)533596741;
			switch (num2 == num)
			{
			}
			num = (short)2046427137;
			if (num != 0)
			{
			}
			num = (short)1886978048;
			if (num != 0)
			{
			}
			num = (short)598605824;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.UpgradeASTRORadioBatch(batchJobContainerUuid, radioToUpgrdae, syncData, flashKeyInfo, cross712Radios);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00047E40 File Offset: 0x00046040
		public bool AstroCheckAskEnable(string flashcode, string modelNumber)
		{
			int a_ = 2;
			short num = (short)343462002;
			short num2 = num;
			num = (short)1880674418;
			switch (num2 == num)
			{
			}
			num = (short)40501249;
			if (num != 0)
			{
			}
			num = (short)1105199104;
			if (num != 0)
			{
			}
			num = (short)1283194880;
			short num3 = num;
			string hoption = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("좘\uda9a궜꺞鞠鞢鶤", a_);
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroCheckHoptionEnable(flashcode, hoption, modelNumber);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00047F10 File Offset: 0x00046110
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary TryDiscardCodeplug(global::System.Guid radioGuid, string serialNumber)
		{
			short num = (short)1601175553;
			if (num != 0)
			{
			}
			num = (short)2143286919;
			short num2 = num;
			num = (short)27850375;
			switch (num2 == num)
			{
			}
			num = (short)346095616;
			if (num != 0)
			{
			}
			num = (short)754778112;
			short num3 = num;
			return base.ServerAccessor.DiscardCodeplugChanges(null, radioGuid, serialNumber, null);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00047FD0 File Offset: 0x000461D0
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary TryDiscardCodeplugAndRadioFeature(global::System.Guid radioGuid, string serialNumber, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> originalRadioFeature)
		{
			short num = (short)1615360139;
			short num2 = num;
			num = (short)1359573131;
			switch (num2 == num)
			{
			}
			num = (short)69009409;
			if (num != 0)
			{
			}
			num = (short)2047934464;
			if (num != 0)
			{
			}
			num = (short)660471808;
			short num3 = num;
			return base.ServerAccessor.DiscardCodeplugAndRadioFeatureChanges(null, radioGuid, serialNumber, null, originalRadioFeature);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00048090 File Offset: 0x00046290
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary QueryAndUpdateRadio(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::ASK.Interface.KeyType type, int systemOwnerKeyId, bool writeProtected, bool askRequired)
		{
			short num = (short)1644309490;
			short num2 = num;
			num = (short)515582962;
			switch (num2 == num)
			{
			}
			num = (short)846987265;
			if (num != 0)
			{
			}
			num = (short)809500672;
			if (num != 0)
			{
			}
			num = (short)266797056;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio);
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.WorkingCodeplug);
			return base.ServerAccessor.QueryAndUpdateRadio(batchJobContainerUuid, radio.Uuid, new int?((int)type), new int?(systemOwnerKeyId), new bool?(writeProtected), new bool?(askRequired), validateEntitySet);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0004819C File Offset: 0x0004639C
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeRadioCodeplugVersion(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, string newCodeplugVersion)
		{
			short num = (short)2061697025;
			if (num != 0)
			{
			}
			num = (short)1051110373;
			short num2 = num;
			num = (short)1789307877;
			switch (num2 == num)
			{
			}
			num = (short)120717312;
			if (num != 0)
			{
			}
			num = (short)2113011712;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio);
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.WorkingCodeplug);
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.WorkingCodeplug.Configuration);
			global::Motorola.CommonCPS.Server.GenericModel.InputOfUpgradeCPVersion inputOfUpgradeCPVersion = new global::Motorola.CommonCPS.Server.GenericModel.InputOfUpgradeCPVersion();
			inputOfUpgradeCPVersion.EMRadio = new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug>(radio, radio.WorkingCodeplug);
			inputOfUpgradeCPVersion.EMConfiguration = radio.WorkingCodeplug.Configuration;
			inputOfUpgradeCPVersion.NewCPVersion = newCodeplugVersion;
			global::Motorola.CommonCPS.Server.GenericModel.ResultOfUpgradeCPVersion resultOfUpgradeCPVersion = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().UpgradeCPVersion(inputOfUpgradeCPVersion);
			return base.ServerAccessor.UpgradeRadioCodeplugVersion(batchJobContainerUuid, radio.Uuid, resultOfUpgradeCPVersion, radio.SerialNumber, validateEntitySet);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000482E8 File Offset: 0x000464E8
		public bool IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string modelNumber)
		{
			short num = (short)545036029;
			short num2 = num;
			num = (short)2135135997;
			switch (num2 == num)
			{
			}
			num = (short)519700481;
			if (num != 0)
			{
			}
			num = (short)1858666496;
			if (num != 0)
			{
			}
			num = (short)1576730624;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().IsFreon(productFamily, modelNumber);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000483A0 File Offset: 0x000465A0
		public override global::Motorola.CommonCPS.Server.EntityModel.RadioSummary EditRadioFields(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> fieldValues)
		{
			short num = (short)1234239488;
			switch (num)
			{
			default:
			{
				num = (short)555876362;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Guid? guid;
					global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> enumerator;
					switch (num2)
					{
					case 0:
						if (guid != null)
						{
							num = (short)765329417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_60B;
					case 1:
					{
						if (fieldValues != null)
						{
							num = (short)613416966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
						return result;
					}
					case 2:
						if (guid != null)
						{
							num = (short)1467482115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CF;
					case 3:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.LastJob);
						goto IL_640;
					case 4:
						goto IL_60B;
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
						return result;
					}
					case 6:
					{
						global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result = base.ServerAccessor.EditRadio(radio.Uuid, fieldValues, validateEntitySet);
						num = (short)33751045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1428291592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (fieldValues == null)
						{
							num = (short)1995505665;
							if (num != 0)
							{
							}
							num = (short)1848836109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result = null;
						validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
						validateEntitySet.RelatedObject = new global::System.Guid?(radio.Uuid);
						validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
						validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio);
						guid = radio.LastJobUuid;
						num = (short)508755968;
						short num3 = num;
						num = (short)939856142;
						short num4 = num;
						num = (short)893194510;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_640;
						default:
							num = (short)682426368;
							if (num != 0)
							{
							}
							num = (short)390987778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						goto IL_3CD;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 11:
						goto IL_4CF;
					case 12:
						try
						{
							num = (short)51249161;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
								switch (num2)
								{
								case 0:
									goto IL_35B;
								case 1:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object> keyValuePair;
									if (keyValuePair.Key == global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.SubscriberIP)
									{
										num = (short)383123464;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1300824075;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object> keyValuePair = enumerator.Current;
									num = (short)164823045;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2 = apxcodeplug.APXDataProfiles.GetEnumerator();
									num = (short)2029125636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									try
									{
										num = (short)235077633;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_330;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_2AC;
												}
												continue;
											case 3:
												num = (short)1112670208;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1148387331;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile entity = enumerator2.Current;
												global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, entity);
												num = (short)1790312450;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_2DD:
											num = (short)912850948;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2AC:
											goto IL_2DD;
										}
										IL_330:
										break;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_343;
								case 5:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object> keyValuePair;
									if (keyValuePair.Key != global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.PeerIP)
									{
										num = (short)378798087;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_17C;
								}
								case 6:
									if (apxcodeplug.APXDataProfiles != null)
									{
										num = (short)1416691715;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									num = (short)1816985601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_17C;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_F8;
									}
									continue;
								case 10:
									if (apxcodeplug != null)
									{
										num = (short)22151180;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 11:
									goto IL_343;
								case 12:
									num = (short)1264189446;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F8;
								IL_17C:
								apxcodeplug = (radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
								num = (short)366870538;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_231:
								num = (short)284491778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F8:
								goto IL_231;
								IL_343:
								num = (short)506986496;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_35B:
							goto IL_401;
						}
						finally
						{
							num = (short)199360512;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_393;
									}
									continue;
								case 1:
									goto IL_3CA;
								case 2:
									enumerator.Dispose();
									num = (short)379650049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_393:
								if (enumerator == null)
								{
									break;
								}
								num = (short)139329538;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3CA:;
						}
						goto IL_3CD;
						IL_401:
						num = (short)1327366145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_498;
					}
					IL_7E:
					if (radio != null)
					{
						num = (short)524615687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_3CD:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.WorkingCodeplug);
					num = (short)530055172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CF:
					guid = radio.WorkingCodeplugUuid;
					num = (short)1025769472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60B:
					enumerator = fieldValues.GetEnumerator();
					num = (short)816971788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_640:
					num = (short)436666379;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3FB:
				throw new global::System.ArgumentNullException();
				IL_498:
				goto IL_3FB;
			}
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00048A44 File Offset: 0x00046C44
		public override global::Motorola.CommonCPS.Server.EntityModel.RadioSummary SubmitTransferRadioIdentity(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> transferRadioIdentityRecords)
		{
			short num = (short)88080384;
			switch (num)
			{
			default:
			{
				num = (short)97386506;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
				for (;;)
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					global::System.Guid? guid;
					switch (num2)
					{
					case 0:
						goto IL_50F;
					case 1:
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>.Enumerator enumerator = transferRadioIdentityRecords.GetEnumerator();
						num = (short)1266876425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_552;
					case 3:
						goto IL_570;
					case 4:
						if (apxcodeplug != null)
						{
							num = (short)165281793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_632;
					case 5:
						goto IL_575;
					case 6:
						if (guid != null)
						{
							num = (short)703201288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_575;
					case 7:
						num = (short)230883330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.LastJob);
						num = (short)743243781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>.Enumerator enumerator;
						try
						{
							num = (short)1745879045;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem = apxcodeplug.APXRadioSystems.FirstOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem item)
									{
										short num5 = (short)1917468335;
										short num6 = num5;
										num5 = (short)1719287471;
										switch (num6 == num5)
										{
										default:
										{
											num5 = (short)1738276864;
											short num7 = num5;
											break;
										}
										case true:
											break;
										}
										num5 = (short)1569390593;
										if (num5 != 0)
										{
										}
										num5 = (short)1761345536;
										if (num5 != 0)
										{
										}
										return item.Uuid == CS$<>8__locals1.record.Key;
									});
									num = (short)1826684934;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)287637507;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> record = enumerator.Current;
									num = (short)170983426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									if (apxcodeplug.APXRadioSystems != null)
									{
										num = (short)1613561856;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									num = (short)514392068;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_482;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_35D;
									}
									continue;
								case 6:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
									if (apxradioSystem != null)
									{
										num = (short)875102216;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
									global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, apxradioSystem);
									num = (short)512294919;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_35F:
								num = (short)1691615233;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_35D:
								goto IL_35F;
							}
							IL_482:
							goto IL_4F0;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_492;
						IL_4F0:
						enumerator = transferRadioIdentityRecords.GetEnumerator();
						num = (short)1596063744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 11:
						goto IL_492;
					case 12:
					{
						if (guid == null)
						{
							goto IL_A0;
						}
						num = (short)821184156;
						short num3 = num;
						num = (short)2054112924;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_552;
						default:
							num = (short)2138767360;
							if (num != 0)
							{
							}
							num = (short)424673291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						goto IL_A0;
					}
					IL_7E:
					if (radio != null)
					{
						num = (short)305463303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_A0:
					apxcodeplug = (radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num = (short)814219268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_552:
					if (transferRadioIdentityRecords == null)
					{
						num = (short)270598147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1519058945;
					if (num != 0)
					{
					}
					validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
					validateEntitySet.RelatedObject = new global::System.Guid?(radio.Uuid);
					validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
					validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio);
					guid = radio.LastJobUuid;
					num = (short)1911226374;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_492:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.WorkingCodeplug);
					num = (short)2025783309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_575:
					guid = radio.WorkingCodeplugUuid;
					num = (short)107544576;
					short num4 = num;
					num = (short)1352335372;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_30C:
				throw new global::System.ArgumentNullException();
				IL_50F:
				try
				{
					num = (short)662568965;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>.Enumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)304873479;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> record = enumerator.Current;
							num = (short)1818099713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
							if (apxcodeplug.APXDataProfiles != null)
							{
								num = (short)1736179715;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
							global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = apxcodeplug.APXDataProfiles.FirstOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile item)
							{
								short num5 = (short)76851859;
								short num6 = num5;
								num5 = (short)1895148179;
								switch (num6 == num5)
								{
								default:
								{
									num5 = (short)1921843200;
									short num7 = num5;
									break;
								}
								case true:
									break;
								}
								num5 = (short)1011548161;
								if (num5 != 0)
								{
								}
								num5 = (short)1135149056;
								if (num5 != 0)
								{
								}
								return item.Uuid == CS$<>8__locals2.record.Key;
							});
							num = (short)23199750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_2F9;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_1D8;
							}
							continue;
						case 6:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
							if (apxdataProfile != null)
							{
								num = (short)410320904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							num = (short)1070202884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, apxdataProfile);
							num = (short)41680898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_2A1:
						num = (short)537853952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D8:
						goto IL_2A1;
					}
					IL_2F9:
					goto IL_632;
				}
				finally
				{
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>.Enumerator enumerator;
					((global::System.IDisposable)enumerator).Dispose();
				}
				IL_570:
				goto IL_30C;
				IL_632:
				return base.ServerAccessor.RadioIdentityTransfer(radio.Uuid, transferRadioIdentityRecords, validateEntitySet);
			}
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000490CC File Offset: 0x000472CC
		public override void CheckValidityForOverrideExistDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio curDevice, global::Motorola.CommonCPS.Server.EntityModel.Radio newDevice)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				switch (num)
				{
				case 0:
				{
					num2 = (short)681695514;
					short num3 = num2;
					num2 = (short)1037752602;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AB;
					default:
					{
						num2 = (short)1885011968;
						if (num2 != 0)
						{
						}
						num2 = (short)850526208;
						short num4 = num2;
						num2 = (short)2050883590;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
				{
					apxcodeplug = ((curDevice as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug2 = (newDevice as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
					num2 = (short)526712837;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug2;
					global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().ValidateAstroCompatibility(apxcodeplug, apxcodeplug2, curDevice.ModelNumber);
					num2 = (short)465305604;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (curDevice.RadioStatus != 0)
					{
						num2 = (short)1894973441;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					return;
				case 5:
					goto IL_1AB;
				case 6:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug2;
					if (apxcodeplug2 != null)
					{
						num2 = (short)1731854338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				goto IL_2C;
				IL_1AB:
				if (apxcodeplug == null)
				{
					break;
				}
				num2 = (short)441450496;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			num2 = (short)131596289;
			if (num2 != 0)
			{
			}
			base.CheckValidityForOverrideExistDevice(curDevice, newDevice);
			num2 = (short)1146748931;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000492A4 File Offset: 0x000474A4
		public override string AddFileSuffix(string filePath)
		{
			short num = (short)1330307149;
			short num2 = num;
			num = (short)723509325;
			switch (num2 == num)
			{
			}
			num = (short)2024472576;
			if (num != 0)
			{
			}
			num = (short)428146689;
			if (num != 0)
			{
			}
			num = (short)277413888;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AddFileSuffixForExportASTRORadio(filePath);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00049358 File Offset: 0x00047558
		public override global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet BuildValidateSetForScheduleJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug currentCodeplug, global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug)
		{
			short num = (short)1248526336;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
				for (;;)
				{
					IL_27:
					num = (short)1491927040;
					short num3 = num;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)761462785;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_19E;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_11B;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)360448004;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile entity = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, entity);
									num = (short)174063619;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)251658240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11D:
								num = (short)225902594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11B:
								goto IL_11D;
							}
							IL_19E:
							goto IL_B6;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_3;
						IL_B6:
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
						enumerator2 = apxcodeplug.APXRadioSystems.GetEnumerator();
						num = (short)433127428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_347;
					case 2:
						if (workingCodeplug != null)
						{
							num = (short)2057240581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return validateEntitySet;
					case 3:
						goto IL_92;
					case 4:
						goto IL_27C;
					case 5:
					{
						num = (short)721262519;
						short num4 = num;
						num = (short)675256247;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_92;
						default:
						{
							num = (short)1195442176;
							if (num != 0)
							{
							}
							num = (short)571998209;
							if (num != 0)
							{
							}
							global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.BuildValidateSetForASTROScheduleJob(radio, currentCodeplug, workingCodeplug, ref validateEntitySet);
							global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = workingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator = apxcodeplug.APXDataProfiles.GetEnumerator();
							num = (short)1643315200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 6:
						goto IL_1B1;
					}
					goto IL_72;
					IL_92:
					if (currentCodeplug != null)
					{
						num = (short)609746945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_375;
					IL_347:
					enumerator2 = (currentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).APXRadioSystems.GetEnumerator();
					num = (short)1588658182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_27C:
						num = (short)2092171265;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_334;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2B6;
								}
								continue;
							case 3:
								num = (short)1802305536;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)651952131;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem entity2 = enumerator2.Current;
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, entity2);
								num = (short)247267330;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_2E5:
							num = (short)729088004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2B6:
							goto IL_2E5;
						}
						IL_334:
						break;
					}
					finally
					{
						((global::System.IDisposable)enumerator2).Dispose();
					}
					goto IL_347;
					Block_3:
					try
					{
						IL_1B1:
						num = (short)1206714369;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_269;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1ED;
								}
								continue;
							case 3:
								num = (short)1202126848;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)701759491;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem entity3 = enumerator2.Current;
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, entity3);
								num = (short)1300168706;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_21A:
							num = (short)828112900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1ED:
							goto IL_21A;
						}
						IL_269:
						goto IL_375;
					}
					finally
					{
						((global::System.IDisposable)enumerator2).Dispose();
					}
					goto Block_4;
					IL_375:
					num = (short)920453122;
					num2 = (int)((global::System.IntPtr)num);
				}
				return validateEntitySet;
				IL_72:
				validateEntitySet = base.BuildValidateSetForScheduleJob(radio, currentCodeplug, workingCodeplug);
				num = (short)1576468483;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
