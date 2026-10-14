using System;
using System.Collections.Generic;
using System.Linq;
using CommonUtility;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200006E RID: 110
	internal abstract class RadioDetailService : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioDetailService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000776 RID: 1910 RVA: 0x00055FEC File Offset: 0x000541EC
		public RadioDetailService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase validateService) : base(serverAccessor, validateService)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00056004 File Offset: 0x00054204
		public virtual bool ValidateRestore_PreSchedule(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> selectedItems, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetail, out string error)
		{
			short num = (short)78381056;
			int num2 = (int)((global::System.IntPtr)num);
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
				{
					num = (short)1785528321;
					if (num != 0)
					{
					}
					num = (short)1853263750;
					short num3 = num;
					num = (short)158896006;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9C;
					default:
						goto IL_10A;
					}
					break;
				}
				case 2:
					goto IL_D1;
				case 3:
					goto IL_9C;
				}
				IL_34:
				if (selectedItems.Count != 1)
				{
					num = (short)441253889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)692912131;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9C:
				if (this.WorkMode_AreEqual(selectedItems[0].RawData.WorkMode, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier))
				{
					goto IL_129;
				}
				num = (short)1166737410;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D1:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.NotAllowRestoreAJobInWrongMode;
			return false;
			IL_10A:
			num = (short)20643840;
			if (num != 0)
			{
			}
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.A_Job_Must_Selected_Perform_Restore;
			return false;
			IL_129:
			num = (short)1744109568;
			short num4 = num;
			return this.CheckIfRestorableFromAndTo(selectedItems[0], device, out error);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00056178 File Offset: 0x00054378
		public virtual void PacSpecial_Validate_AllowRestore(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.Common.Communication.Pba.PbaObject historical_PbaObject, global::Motorola.Common.Communication.CommonUtil.DeviceInfo historical_DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject current_PbaObject)
		{
			short num = (short)675151872;
			short num2 = num;
			num = (short)1185575571;
			short num3 = num;
			num = (short)1511944851;
			switch (num3 == num)
			{
			}
			num = (short)1535311873;
			if (num != 0)
			{
			}
			num = (short)1404502016;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00056224 File Offset: 0x00054424
		public global::Motorola.CommonCPS.Server.EntityModel.Codeplug FixIncorrectData_OfHistoricalCodeplug(global::Motorola.CommonCPS.Server.EntityModel.Codeplug restoreJob_Codeplug, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateEntitySet, byte[] historical_xPbaBytes, out bool restoreJob_PbaCanNotBeDirectlyModified)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_6D;
				case 1:
					if (codeplug is global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug)
					{
						num2 = (short)920518656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1219493893;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_DE;
				case 3:
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(restoreJob_Codeplug.Timestamp, codeplug.Timestamp))
					{
						num2 = (short)1128726530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AA;
				case 4:
					goto IL_1A5;
				case 5:
					if (codeplug == null)
					{
						num2 = (short)1345680657;
						short num3 = num2;
						num2 = (short)1048933649;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F1;
						case 1:
							break;
						default:
						{
							num2 = (short)517144576;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)184614912;
						if (num2 != 0)
						{
						}
						num2 = (short)1758461956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1481703425;
					if (num2 != 0)
					{
					}
					num2 = (short)1816461315;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
			}
			IL_6D:
			restoreJob_PbaCanNotBeDirectlyModified = false;
			return codeplug;
			IL_DE:
			IL_F1:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
			IL_1A5:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CodeplugNotExist);
			IL_1AA:
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet, codeplug);
			codeplug.Template = null;
			codeplug.Configuration = null;
			this.a(codeplug, ref historical_xPbaBytes);
			string a_;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radio = this.ParseRadio_FromPBA(historical_xPbaBytes, out a_, out restoreJob_PbaCanNotBeDirectlyModified);
			this.a(codeplug, radio);
			codeplug.ChangeIndicator = new int?(1);
			this.a(a_, codeplug, radio, validateEntitySet);
			return codeplug;
			IL_28:
			codeplug = base.ServerAccessor.GetCodeplug(restoreJob_Codeplug.Uuid);
			num2 = (short)1277689857;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00056424 File Offset: 0x00054624
		private void a(global::Motorola.CommonCPS.Server.EntityModel.Codeplug A_0, ref byte[] A_1)
		{
			short num = (short)996147200;
			switch (num)
			{
			default:
			{
				num = (short)1028849666;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
				byte[] deviceInfo;
				global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData;
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc> list;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)265551872;
						short num3 = num;
						goto IL_326;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					case 3:
						if (this.a(A_1, out pbaObject, out deviceInfo))
						{
							num = (short)1138229249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20B;
					case 4:
					{
						num = (short)1796423758;
						short num4 = num;
						num = (short)2026651726;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_77;
						default:
							num = (short)352124928;
							if (num != 0)
							{
							}
							pbaObject.LanguagePackData = pbaObject.PreservedLanguagePackInfos;
							A_1 = global::Motorola.Common.CommonLib.CombineTool.Encode(pbaObject.SerializeToBytes(), deviceInfo);
							num = (short)1558839297;
							if (num != 0)
							{
							}
							num = (short)2041053184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug a_ = A_0 as global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug;
						num = (short)1846935559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1576075267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug a_;
						if (this.a(a_, out list))
						{
							num = (short)1712062470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20B;
					}
					case 8:
						try
						{
							num = (short)1758265344;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_28C;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)972226564;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo item = global::CommonUtility.LPVAUtitity.Convert_LanguageSettingDesc_to_PCRLanguagePackInfo(enumerator.Current);
									languagePackData.LanguagePacks.Add(item);
									num = (short)2077294594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_313;
								case 4:
									num = (short)876281859;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2C2:
								num = (short)122355713;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_28C:
								goto IL_2C2;
							}
							IL_313:
							goto IL_92;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_326;
					case 9:
						if (this.b(A_1, out pbaObject, out deviceInfo))
						{
							num = (short)1410334724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_6C;
					IL_77:
					num = (short)301072389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C:
					if (A_0 is global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug)
					{
						goto IL_77;
					}
					return;
					IL_20B:
					num = (short)677642249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_326:
					languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
					enumerator = list.GetEnumerator();
					num = (short)215941128;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_92:
				pbaObject.LanguagePackData = languagePackData;
				A_1 = global::Motorola.Common.CommonLib.CombineTool.Encode(pbaObject.SerializeToBytes(), deviceInfo);
				return;
			}
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00056794 File Offset: 0x00054994
		private bool b(byte[] A_0, out global::Motorola.Common.Communication.Pba.PbaObject A_1, out byte[] A_2)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (A_1.LanguagePackData.LanguagePacks.Count<global::Motorola.Common.Communication.Pba.LanguagePackBase>() != A_1.PreservedLanguagePackInfos.LanguagePacks.Count<global::Motorola.Common.Communication.Pba.LanguagePackBase>())
					{
						num2 = (short)466092037;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_BD;
				case 2:
				{
					num2 = (short)1327500656;
					short num3 = num2;
					num2 = (short)1451625840;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BD;
					default:
						goto IL_155;
					}
					break;
				}
				case 3:
					if (A_1.PreservedLanguagePackInfos != null)
					{
						num2 = (short)1139736577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					if (A_1.PreservedLanguagePackInfos.LanguagePacks.Count<global::Motorola.Common.Communication.Pba.LanguagePackBase>() > 0)
					{
						num2 = (short)390791175;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					goto IL_11A;
				case 6:
					if (A_1.LanguagePackData == null)
					{
						num2 = (short)1041891330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)323682304;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)432996353;
					if (num2 != 0)
					{
					}
					num2 = (short)893517830;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_39;
				IL_BD:
				num2 = (short)124583940;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_11A:
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).EventWarning(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾞쎠슢얦쎨캪캬\udbae龰잴튶쪸\udeba쾼즾꓀Ꟃ规ꛆꟈ곊료껎뛐뛒藔뛖뫘냚铜뇞蟠賢엤軦髨쯪觬蛮韰闲郴藶鳸闺觼\udffe瘀樂焄漆⤈嬊漌渎帐焒缔爖稘漚㌜匞䀠䴢䈤刦䠨䰪䠬缮倰倲帴猶堸伺尼", a_));
			return true;
			IL_155:
			num2 = (short)1045364736;
			if (num2 != 0)
			{
			}
			return true;
			IL_39:
			num2 = (short)1076953088;
			short num4 = num2;
			global::System.Collections.Generic.List<byte[]> list = global::Motorola.Common.CommonLib.CombineTool.Decode(A_0);
			byte[] buffer = list[0];
			A_2 = list[1];
			A_1 = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(buffer, false);
			num2 = (short)479002627;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000569E0 File Offset: 0x00054BE0
		private bool a(byte[] A_0, out global::Motorola.Common.Communication.Pba.PbaObject A_1, out byte[] A_2)
		{
			short num = (short)2087335079;
			short num2 = num;
			num = (short)957953191;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)903348224;
				short num3 = num;
				num = (short)2050818049;
				if (num != 0)
				{
				}
				num = (short)237436928;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<byte[]> list = global::Motorola.Common.CommonLib.CombineTool.Decode(A_0);
				byte[] buffer = list[0];
				A_2 = list[1];
				A_1 = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(buffer, false);
				if (A_1.LanguagePackData != null)
				{
					return false;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00056AB8 File Offset: 0x00054CB8
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug A_0, out global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc> A_1)
		{
			short num = (short)509018113;
			if (num != 0)
			{
			}
			num = (short)877395969;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					A_1 = global::Motorola.CommonCPS.Common.CommonUtility.ObjectSeralizeUtility.JsonToObject<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>>(A_0.LanguageSetting);
					num = (short)884736005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 2:
				{
					num = (short)631220539;
					short num3 = num;
					num = (short)81570107;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_159;
					default:
						goto IL_100;
					}
					break;
				}
				case 3:
					if (A_1.Count<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>() > 0)
					{
						num = (short)635109378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_187;
				case 4:
					goto IL_159;
				case 5:
					if (A_1 != null)
					{
						num = (short)1598160900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_187;
				}
				IL_63:
				if (!string.IsNullOrEmpty(A_0.LanguageSetting))
				{
					num = (short)2062876672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_187;
				IL_159:
				num = (short)1908736000;
				short num4 = num;
				num = (short)1161428995;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_100:
			num = (short)1365049344;
			if (num != 0)
			{
			}
			return true;
			IL_187:
			A_1 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>();
			return false;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00056C54 File Offset: 0x00054E54
		internal bool CheckIfRestorableFromAndTo(global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob selJob, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, out string error)
		{
			short num;
			bool result;
			try
			{
				num = (short)1000800256;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_C4;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus3;
					for (;;)
					{
						IL_29:
						global::System.Guid? fileUuid;
						switch (num2)
						{
						case 0:
							goto IL_60F;
						case 1:
							goto IL_1D4;
						case 2:
						{
							int? changeIndicator;
							int num3;
							if (!(changeIndicator.GetValueOrDefault() == num3 & changeIndicator != null))
							{
								num = (short)1229979673;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_229;
						}
						case 3:
							if (fileUuid == null)
							{
								num = (short)1783693343;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1487929377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_GeneralFaultException;
							result = false;
							num = (short)1082392602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2;
							if (!(uijobStatus.GetValueOrDefault() == uijobStatus2 & uijobStatus != null))
							{
								num = (short)2003370006;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_479;
						}
						case 6:
							error = global::Motorola.CommonCPS.ResourceRepository.Resources.Must_Restore_A_Perform_Completed_Job;
							result = false;
							num = (short)1078788111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)1605369875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_55A;
						case 9:
							error = global::Motorola.CommonCPS.ResourceRepository.Resources.RestoreJob_CrntCPHasNoXPBA;
							result = false;
							num = (short)1690566657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2;
							if (!(uijobStatus.GetValueOrDefault() == uijobStatus2 & uijobStatus != null))
							{
								num = (short)1176567840;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_479;
						}
						case 11:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2;
							if (!(uijobStatus.GetValueOrDefault() == uijobStatus2 & uijobStatus != null))
							{
								num = (short)2014183442;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_479;
						}
						case 12:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2;
							if (!(uijobStatus.GetValueOrDefault() == uijobStatus2 & uijobStatus != null))
							{
								num = (short)1660026901;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_479;
						}
						case 13:
							error = global::Motorola.CommonCPS.ResourceRepository.Resources.Restore_ModelNumberShallBeTheSame;
							result = false;
							num = (short)1084882979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_5ED;
						case 15:
							goto IL_5E8;
						case 16:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2;
							if (!(uijobStatus.GetValueOrDefault() == uijobStatus2 & uijobStatus != null))
							{
								num = (short)1840119814;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)795489678;
							short num4 = num;
							num = (short)314586510;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_40E;
							default:
							{
								num = (short)724303872;
								if (num != 0)
								{
								}
								int? changeIndicator = selJob.RawData.Codeplug.ChangeIndicator;
								num = (short)691142684;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 17:
						{
							if (fileUuid == null)
							{
								num = (short)1786052617;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus = selJob.JobStatus;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2 = global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Completed;
							num = (short)1084162064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus = uijobStatus3;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2 = global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Expired;
							num = (short)115539980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							if ((device.ChangeIndicator & 32) != 0)
							{
								num = (short)1339293710;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							fileUuid = selJob.RawData.Radio.CurrentCodeplug.FileUuid;
							num = (short)1822162961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2;
							if (!(uijobStatus.GetValueOrDefault() == uijobStatus2 & uijobStatus != null))
							{
								goto IL_40E;
							}
							goto IL_479;
						}
						case 21:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus = uijobStatus3;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2 = global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Failed;
							num = (short)578682885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus = uijobStatus3;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2 = global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Performed;
							num = (short)1228734484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							error = global::Motorola.CommonCPS.ResourceRepository.Resources.Radio_With_Job_Running_Can_Not_Be_Restored;
							result = false;
							num = (short)303890440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
						{
							if (uijobStatus3 == null)
							{
								num = (short)1443102724;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus = uijobStatus3;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2 = global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Canceled;
							num = (short)194052106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							error = global::Motorola.CommonCPS.ResourceRepository.Resources.Must_Restore_A_Completed_Job_Wi_RadioNoChangeIndicator;
							result = false;
							num = (short)2144993314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							goto IL_4E1;
						case 27:
							goto IL_44D;
						case 28:
						{
							int? changeIndicator;
							if (changeIndicator != null)
							{
								num = (short)219742244;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_229;
						}
						case 29:
							goto IL_6D6;
						case 30:
							if ((device.ChangeIndicator & 16) == 0)
							{
								num = (short)1326841863;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5ED;
						case 31:
							error = global::Motorola.CommonCPS.ResourceRepository.Resources.Restore_HistoryJobShallHasPbaObject;
							result = false;
							num = (short)197066779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus = uijobStatus3;
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2 = global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Completed;
							num = (short)418381835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 33:
							if (selJob.RawData.Radio.ModelNumber != device.ModelNumber)
							{
								num = (short)563085325;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = true;
							num = (short)2087518237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
							goto IL_5C1;
						case 35:
							goto IL_474;
						case 36:
						{
							int? changeIndicator = selJob.RawData.Codeplug.ChangeIndicator;
							int num3 = 0;
							num = (short)783024130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_C4;
						IL_229:
						fileUuid = selJob.RawData.Codeplug.FileUuid;
						num = (short)1373896707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_40E:
						num = (short)1714749463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_479:
						num = (short)1335951390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5ED:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RestoreFailOnFlashCodeChange;
						result = false;
						num = (short)1328283648;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1D4:
					IL_44D:
					IL_474:
					IL_4E1:
					IL_55A:
					IL_5C1:
					IL_5E8:
					IL_60F:
					IL_6D6:
					break;
					IL_C4:
					error = string.Empty;
					uijobStatus3 = device.UIJobStatus;
					num = (short)254607384;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				}
			}
			catch
			{
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_GeneralFaultException;
				result = false;
			}
			num = (short)2065694721;
			if (num != 0)
			{
			}
			num = (short)1766981632;
			short num5 = num;
			return result;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000573B4 File Offset: 0x000555B4
		protected virtual void FixIncorrectData_LPPackage(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration, ref global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateEntitySet)
		{
			short num = (short)1423304628;
			short num2 = num;
			num = (short)586540980;
			switch (num2 == num)
			{
			default:
			{
				num = (short)809041920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1319960576;
			if (num != 0)
			{
			}
			num = (short)249626625;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0005745C File Offset: 0x0005565C
		protected virtual void FixIncorrectData_VAPackage(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration, ref global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateEntitySet)
		{
			short num = (short)276085861;
			short num2 = num;
			num = (short)2057550949;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1532035072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1280049153;
			if (num != 0)
			{
			}
			num = (short)1066991616;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00057508 File Offset: 0x00055708
		protected global::Motorola.CommonCPS.Server.EntityModel.Radio ParseRadio_FromPBA(byte[] pbaData, out string ArchiveFilePath, out bool restoreJob_PbaCanNotBeDirectlyModified)
		{
			short num = (short)2102552738;
			short num2 = num;
			num = (short)1112041634;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1296629760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1300168705;
			if (num != 0)
			{
			}
			num = (short)257032192;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.Dictionary<int, int> dictionary;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().ParsePBA(pbaData, out dictionary, out ArchiveFilePath, out restoreJob_PbaCanNotBeDirectlyModified, true, "");
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000575C4 File Offset: 0x000557C4
		protected bool WorkMode_AreEqual(global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode, global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier modeIdentifier)
		{
			short num = (short)1383858183;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (modeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template)
					{
						num = (short)176095233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					goto IL_155;
				case 2:
					goto IL_BB;
				case 3:
					num = (short)694943744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1514602496;
					short num3 = num;
					num = (short)25231365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					IL_135:
					if (modeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
					{
						num = (short)1772093442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_155;
				case 6:
					if (workMode == global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Template)
					{
						num = (short)1297154051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				}
				IL_44:
				num = (short)15794177;
				if (num != 0)
				{
				}
				if (workMode == global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Configuration)
				{
					num = (short)689045508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BB:
				num = (short)560267270;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_155:
				num = (short)484445495;
				short num4 = num;
				num = (short)968625463;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_135;
				default:
					goto IL_18C;
				}
			}
			IL_18C:
			num = (short)1814691840;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00057778 File Offset: 0x00055978
		private void a(string A_0, global::Motorola.CommonCPS.Server.EntityModel.Codeplug A_1, global::Motorola.CommonCPS.Server.EntityModel.Radio A_2, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> A_3)
		{
			short num = (short)1992359938;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1F:
				switch (num2)
				{
				case 0:
					goto IL_114;
				case 1:
				{
					num = (short)2035548160;
					short num3 = num;
					num = (short)1555562497;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.PreImportRadioToServer(A_0, A_2, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption.BothWithApply);
					num = (short)1162149888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				while (A_0 != null)
				{
					num = (short)1394279721;
					short num4 = num;
					num = (short)1214186793;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1767178240;
						if (num != 0)
						{
						}
						num = (short)194379777;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1F;
					}
				}
				break;
			}
			IL_114:
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().UploadPackageFileContentToServer(A_1, A_3);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x000578A8 File Offset: 0x00055AA8
		private void a(global::Motorola.CommonCPS.Server.EntityModel.Codeplug A_0, global::Motorola.CommonCPS.Server.EntityModel.Radio A_1)
		{
			short num = (short)44225548;
			short num2 = num;
			num = (short)473158668;
			switch (num2 == num)
			{
			default:
			{
				num = (short)258146304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1695547393;
			if (num != 0)
			{
			}
			num = (short)1046085632;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().UpdateRestoreJobzCodeplug(A_0, A_1);
		}
	}
}
