using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200005A RID: 90
	internal class ASTROSystemService : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROSystemService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060006BF RID: 1727 RVA: 0x00045248 File Offset: 0x00043448
		public ASTROSystemService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService astroValidationService) : base(serverAccessor, astroValidationService)
		{
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00045260 File Offset: 0x00043460
		public global::Motorola.CommonCPS.Server.EntityModel.APXRadio GetASTRORadioRawData(global::System.Guid deviceID, bool deepLoad = true)
		{
			global::Motorola.CommonCPS.Server.EntityModel.Radio radioRawData;
			short num;
			for (;;)
			{
				radioRawData = base.GetRadioRawData(deviceID, deepLoad);
				if (radioRawData == null)
				{
					goto IL_B2;
				}
				num = (short)1232355606;
				short num2 = num;
				num = (short)729628950;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_48;
				}
			}
			IL_48:
			num = (short)1423966208;
			if (num != 0)
			{
			}
			num = (short)1683095553;
			if (num != 0)
			{
			}
			num = (short)700317696;
			short num3 = num;
			return radioRawData as global::Motorola.CommonCPS.Server.EntityModel.APXRadio;
			IL_B2:
			return null;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00045320 File Offset: 0x00043520
		public global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary EditSystemFields(global::Motorola.CommonCPS.Server.EntityModel.Radio apxRadio, global::System.Guid? systemID, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> fieldValues)
		{
			short num = (short)840171520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
				global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object> dictionary;
				global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
				for (;;)
				{
					IL_27:
					global::System.Guid? guid;
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)236257292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (apxRadio != null)
						{
							num = (short)1948975112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_421;
					case 2:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, apxRadio.LastJob);
						num = (short)1120010251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_165;
					case 4:
						goto IL_A6;
					case 5:
						if (fieldValues != null)
						{
							num = (short)412090368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_421;
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, apxRadio.WorkingCodeplug);
						num = (short)22216704;
						short num3 = num;
						num = (short)2091188228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (guid != null)
						{
							num = (short)999292930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD;
					case 8:
						goto IL_2E9;
					case 9:
						try
						{
							num = (short)736886785;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_22D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1A4;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1396047876;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object> keyValuePair = enumerator.Current;
									dictionary.Add(keyValuePair.Key, keyValuePair.Value);
									num = (short)2045902850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)365756416;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1A6:
								num = (short)1042677763;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A4:
								goto IL_1A6;
							}
							IL_22D:
							goto IL_455;
						}
						finally
						{
							num = (short)765035189;
							short num4 = num;
							num = (short)648905397;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_2AD:
								if (enumerator == null)
								{
									goto IL_2E8;
								}
								num = (short)1926823938;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1551433728;
								if (num != 0)
								{
								}
								num = (short)1221591041;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2E6;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2AD;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)533528576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2AD;
							}
							IL_2E6:
							IL_2E8:;
						}
						goto IL_2E9;
					case 10:
						if (guid != null)
						{
							num = (short)1156448262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A6;
					case 11:
						goto IL_DD;
					case 12:
						if (systemID == null)
						{
							num = (short)1288175619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						apxradioSystem = (apxRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).APXRadioSystems.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem s)
						{
							short num5 = (short)1987240273;
							short num6 = num5;
							num5 = (short)1168957777;
							global::System.Guid uuid;
							global::System.Guid? systemID2;
							switch ((num6 == num5) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num5 = (short)889061377;
								if (num5 != 0)
								{
								}
								num5 = (short)783351808;
								if (num5 != 0)
								{
								}
								uuid = s.Uuid;
								systemID2 = systemID;
								if (systemID2 == null)
								{
									num5 = (short)42991616;
									short num7 = num5;
									return false;
								}
								break;
							}
							return uuid == systemID2.GetValueOrDefault();
						}).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>();
						validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
						validateEntitySet.RelatedObject = new global::System.Guid?(apxRadio.Uuid);
						validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
						validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, apxRadio);
						guid = apxRadio.LastJobUuid;
						num = (short)932839431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62;
					IL_A6:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, apxradioSystem);
					dictionary = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>();
					enumerator = fieldValues.GetEnumerator();
					num = (short)486342665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DD:
					guid = apxRadio.WorkingCodeplugUuid;
					num = (short)627507210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E9:
					num = (short)388890629;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_165:
				IL_421:
				throw new global::System.ArgumentNullException();
				IL_455:
				num = (short)1159200769;
				if (num != 0)
				{
				}
				return base.ServerAccessor.EditAPXRadioSystem(apxRadio.Uuid, apxradioSystem.Uuid, dictionary, validateEntitySet);
				IL_62:
				num = (short)308412417;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000457D4 File Offset: 0x000439D4
		public bool ValidateASTROIndividualId(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem radioSys, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxCpg, string modelnumber, out string error)
		{
			int a_ = 1;
			short num = (short)730071040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					break;
				default:
				{
					bool flag;
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
							if (radioSys != null)
							{
								num = (short)350224389;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F4;
						case 1:
							if (apxCpg.AstroPurchasedFlashCode != null)
							{
								num = (short)680984579;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return flag;
						case 2:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = radioSys.SystemType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING;
							num = (short)1581252619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType = radioSys.SystemSubType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.TYPEII;
							num = (short)1872756744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_29A;
						case 5:
							num = (short)1645871111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)1018494977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (apxCpg != null)
							{
								num = (short)232062986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F4;
						case 8:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
							if (!(systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null))
							{
								num = (short)154337294;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_195;
						}
						case 9:
							goto IL_195;
						case 10:
							num = (short)617086993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType;
							if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
							{
								num = (short)1465909254;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return flag;
						}
						case 12:
							goto IL_190;
						case 13:
							if (flag)
							{
								num = (short)1105526786;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return flag;
						case 14:
							flag = this.a(radioSys, apxCpg);
							num = (short)2134441999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (!flag)
							{
								num = (short)162725904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_195;
						case 16:
							error = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udd97튟ﶡ장첧쎩쎫잵춷\udbb9킻蒿ꏁ냃Ʂ过룉ꏋ믍ꃏ鯑냓", a_));
							num = (short)1385955337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							if (string.IsNullOrEmpty(modelnumber))
							{
								num = (short)366805004;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = false;
							global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROValidationService astrovalidationService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ValidationService as global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROValidationService;
							int? radioId = radioSys.RadioId;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = radioSys.SystemType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType value = systemType.Value;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType = radioSys.SystemSubType;
							flag = astrovalidationService.ValidateRadioIdRange(radioId, value, systemSubType.Value, radioSys.ExpandedMDCIDRange, apxCpg.CodeplugVersion, out error);
							num = (short)680063081;
							short num3 = num;
							num = (short)1393553513;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_8F;
							default:
								num = (short)506003457;
								if (num != 0)
								{
								}
								num = (short)47972352;
								if (num != 0)
								{
								}
								num = (short)954793997;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 18:
						{
							num = (short)889651200;
							short num4 = num;
							if (flag)
							{
								num = (short)1761214483;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return flag;
						}
						case 19:
							flag = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.ValidateRadioIdWithASK(radioSys, apxCpg, modelnumber, out error, false);
							num = (short)1623195652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_87;
						IL_195:
						num = (short)1109458962;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_190:
					goto IL_2F4;
					IL_29A:
					return flag;
					IL_2F4:
					throw new global::System.ArgumentNullException();
				}
				}
				IL_87:
				error = string.Empty;
				IL_8F:
				num = (short)1633943552;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00045C28 File Offset: 0x00043E28
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem A_0, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_1)
		{
			short num = (short)11010048;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				bool result;
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.Astro25DataGroupID> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1479999488;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_117;
									}
									continue;
								case 1:
								{
									int? radioId;
									int dataGroupID;
									if (radioId.GetValueOrDefault() == dataGroupID & radioId != null)
									{
										num = (short)1597702148;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1E2;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2119827462;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.Astro25DataGroupID astro25DataGroupID = enumerator.Current;
									int? radioId = A_0.RadioId;
									int dataGroupID = astro25DataGroupID.DataGroupID;
									num = (short)424804353;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									result = false;
									num = (short)803340293;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_1C5;
								case 6:
									num = (short)1272578050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_119:
								num = (short)94633987;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_117:
								goto IL_119;
							}
							IL_1C5:
							IL_1E2:
							return result;
						}
						finally
						{
							num = (short)1463615490;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)517708107;
									short num3 = num;
									num = (short)1225431371;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_21F;
									default:
										goto IL_289;
									}
									break;
								}
								case 1:
									enumerator.Dispose();
									num = (short)1993342976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_219;
									}
									continue;
								}
								goto IL_219;
								IL_21F:
								num = (short)78512129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_219:
								if (enumerator != null)
								{
									goto IL_21F;
								}
								goto IL_2A0;
							}
							IL_289:
							num = (short)1032060928;
							if (num != 0)
							{
							}
							IL_2A0:;
						}
						goto IL_2A1;
					case 1:
					{
						num = (short)2103312384;
						short num4 = num;
						num = (short)843055105;
						if (num != 0)
						{
						}
						goto IL_2A1;
					}
					case 2:
						if (apxdataProfile != null)
						{
							num = (short)1704853505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_3A;
					IL_2A1:
					enumerator = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.AstroDataProfTrunkingGroupgIDs(apxdataProfile.TrunkingGroupIds).Recset.GetEnumerator();
					num = (short)152174592;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_3A:
				result = true;
				apxdataProfile = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().FindSelectedProfileInRadioSystem(A_0, A_1.APXDataProfiles);
				num = (short)245760002;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
