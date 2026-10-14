using System;
using System.Threading;
using System.Windows;
using AcpCommonLib;
using CommonResources;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.ReadWritePassword;
using SpecialFeatures.VoiceAnnouncements;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000167 RID: 359
	internal class Clone : global::SpecialFeatures.Comms.Comms
	{
		// Token: 0x0600121D RID: 4637 RVA: 0x000036CC File Offset: 0x000018CC
		public Clone()
		{
			this.g = global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.GetInstance();
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00189508 File Offset: 0x00187708
		internal global::SpecialFeatures.Comms.RadioIdInfo ReadRadioIds(global::SpecialFeatures.Comms.COMMS_OP WriteType, int Headless = 0, string HeadlessAddr = "192.168.128.1", bool WriteProtecWriteProtectedRadio = false, bool otapBatchProgramming = false)
		{
			short num = (short)2098838961;
			short num2 = num;
			num = (short)310705;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_364:
				num = (short)237961221;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1467809792;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				break;
			}
			global::SpecialFeatures.Comms.RadioIdInfo result;
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					num = (short)244514819;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					try
					{
						num = (short)826540036;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_2D0;
							case 1:
								goto IL_2D0;
							case 2:
								goto IL_15F;
							case 3:
							{
								result.TrkSysIds = this.m_RadioSystemIds;
								result.CnvSysIds = this.m_RadioCnvSysIds;
								result.AstroOtarRadioIds = this.m_AstroOtarRadioIds;
								result.DataProfIps = this.m_RadioDataProfIPs;
								result.SoftIds = this.m_SoftIds;
								result.BluetoothFriendlyName = this.m_BluetoothFriendlyName;
								global::SpecialFeatures.Comms.RadioParams radioParams = base.GetRadioParams();
								result.RadioAlias = base.GetRadioAlias();
								result.ESerialNumber = this.m_readRadioParams.ESerialNumber;
								result.IsEncryptedPwd = this.m_EncryptPasswordFlag;
								result.EncryptedPwd = this.m_EncryptPassword;
								result.SerialNumber = global::SpecialFeatures.Comms.ParseDataHelper.RadioSNToString(radioParams.SerialNumber);
								global::SpecialFeatures.Comms.Clone.a = false;
								global::SpecialFeatures.Comms.Clone.b = true;
								num = (short)1531904005;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_12F;
								}
								continue;
							case 5:
								if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
								{
									num = (short)262537223;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_15F;
							case 6:
								goto IL_2E9;
							case 7:
								global::SpecialFeatures.Comms.CloneParameters.LastCloneOTAPUserState = base.GetLastCommsOTAPUserState();
								num = (short)750911490;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_12F:
							if (!base.blockRadioWrite(WriteType, global::SpecialFeatures.Comms.CloneParameters.LastCloneOTAPUserState, Headless, HeadlessAddr, WriteProtecWriteProtectedRadio, otapBatchProgramming))
							{
								num = (short)1879506947;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.Comms.Clone.b = false;
							global::SpecialFeatures.Comms.Clone.a = true;
							num = (short)332988417;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_15F:
							base.GetReadWritePassword(ref this.c, ref this.d, ref this.e, ref this.f);
							num = (short)1800470528;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_2D0:
							num = (short)388366342;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2E9:
						return result;
					}
					catch
					{
						base.ForceClose();
						return result;
					}
					goto IL_2FA;
				case 2:
					if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
					{
						num = (short)1792671744;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FA;
				case 3:
					num = (short)2114846721;
					if (num != 0)
					{
					}
					if (global::SpecialFeatures.Comms.Clone.b)
					{
						goto IL_364;
					}
					goto IL_2FA;
				case 4:
					goto IL_2FA;
				case 5:
					global::System.Threading.Thread.Sleep(3000);
					num = (short)420413444;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_72;
				IL_2FA:
				result = default(global::SpecialFeatures.Comms.RadioIdInfo);
				num = (short)1452277761;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_72:
			this.c = false;
			this.d = false;
			this.e = false;
			num = (short)1664745472;
			short num4 = num;
			num = (short)1700397058;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x001898D8 File Offset: 0x00187AD8
		internal bool CloneRadio(bool ReadRadioIds, global::SpecialFeatures.Comms.COMMS_OP WriteType, object lastCommsUserState, global::System.Windows.Window win, bool inbatchMode = false)
		{
			short num = (short)663097871;
			short num2 = num;
			num = (short)1774653967;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)923074561;
				if (num != 0)
				{
				}
				num = (short)393478144;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9A;
				}
				int num3;
				for (;;)
				{
					IL_7C:
					switch (num3)
					{
					case 0:
						num = (short)1744175109;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_120;
					case 2:
						if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
						{
							num = (short)1856765952;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_175;
					case 3:
						goto IL_13F;
					case 4:
						global::SpecialFeatures.Comms.CloneParameters.LastCloneOTAPUserState = lastCommsUserState;
						num = (short)189399043;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (lastCommsUserState != null)
						{
							num = (short)1310130180;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Comms.CloneParameters.LastCloneOTAPUserState = null;
						num = (short)2005860353;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9A;
				}
				IL_120:
				break;
				IL_9A:
				num = (short)2145189888;
				short num4 = num;
				this.h = win;
				num = (short)1397358594;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7C;
			}
			}
			IL_13F:
			IL_175:
			return this.CloneRadio(ReadRadioIds, WriteType, inbatchMode);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00189A64 File Offset: 0x00187C64
		internal bool CloneRadio(bool ReadRadioIds, global::SpecialFeatures.Comms.COMMS_OP WriteType, bool inbatchMode = false)
		{
			int a_ = 10;
			short num = (short)892869212;
			short num2 = num;
			num = (short)1464277596;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)114950144;
				short num3 = num;
				num = (short)1100021761;
				if (num != 0)
				{
				}
				num = (short)975306752;
				if (num != 0)
				{
				}
				num = (short)37879808;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			bool flag = false;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			string radInfoGeneralCodeplugVersion_A7683_UIValue = "";
			string lastSetJobUuidField = "";
			try
			{
				switch (0)
				{
				case 0:
					goto IL_17F;
				}
				int num4;
				global::SpecialFeatures.Comms.RadioParams radioParams;
				for (;;)
				{
					IL_F0:
					bool flag2;
					bool flag3;
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
					switch (num4)
					{
					case 0:
						if (!ReadRadioIds)
						{
							num = (short)1049821185;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_489;
					case 1:
						this.c = false;
						this.d = false;
						this.e = false;
						global::SpecialFeatures.Comms.Clone.a = base.blockRadioWrite(WriteType, global::SpecialFeatures.Comms.CloneParameters.LastCloneOTAPUserState, 0, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붌ꆎꆐ붒ꖔ릖ꦘ", a_), false, false);
						num = (short)1956053004;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)659619863;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!flag)
						{
							num = (short)2008481796;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CC;
					case 4:
						num = (short)1616969757;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this.d)
						{
							num = (short)848691208;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F6;
					case 6:
						goto IL_221;
					case 7:
						goto IL_55F;
					case 8:
						num = (short)1757282321;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						if ((bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﲐﺒ練ﶘ힚쒠", a_)])
						{
							num = (short)825229326;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						radioParams = base.GetRadioParams();
						string serialNumber = global::SpecialFeatures.Comms.ParseDataHelper.RadioSNToString(radioParams.SerialNumber);
						num = (short)175112197;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_3CC;
					case 11:
					{
						string serialNumber;
						flag2 = this.g.ValidateOKToReadWrite(this.h, this.f, serialNumber, global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.ValidType.Write);
						goto IL_621;
					}
					case 12:
						if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
						{
							num = (short)1660289049;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_221;
					case 13:
						goto IL_63D;
					case 14:
						flag3 = true;
						num = (short)114491405;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (ishItemCollection != null)
						{
							num = (short)1571815426;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					case 16:
						ishItemCollection = global::SpecialFeatures.Comms.ParseDataHelper.ReplaceSecurityPartition(ishItemCollection, this.oldSecurityPartition);
						num = (short)1450115079;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (!global::SpecialFeatures.Comms.Clone.a)
						{
							num = (short)1727266838;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F6;
					case 18:
						if (!flag3)
						{
							num = (short)244973587;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_678;
					case 19:
						base.ForceClose();
						global::SpecialFeatures.Comms.Comms.DispalyUpdateStatusChanged(0.0, global::CommonResources.AppResources.Password_validation_failed);
						num = (short)2021851164;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_733;
					case 21:
						goto IL_1E5;
					case 22:
						num = (short)925302795;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if ((bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﲐﺒ練ﶘ힚쒠", a_)])
						{
							num = (short)699727888;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55F;
					case 24:
						flag2 = true;
						goto IL_621;
					case 25:
						global::SpecialFeatures.Comms.CloneParameters.LastCloneOTAPUserState = base.GetLastCommsOTAPUserState();
						num = (short)670826502;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue = radInfoGeneralCodeplugVersion_A7683_UIValue;
						num = (short)1061814282;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_714;
					case 28:
						goto IL_678;
					case 29:
						if (!(bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﲐﺒ練ﶘ힚쒠", a_)])
						{
							num = (short)750125082;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CC;
					case 30:
						goto IL_489;
					case 31:
						if (!global::SpecialFeatures.Comms.Clone.a && flag3)
						{
							num = (short)301465632;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_714;
					case 32:
					{
						string appVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
						radInfoGeneralCodeplugVersion_A7683_UIValue = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue;
						radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue = appVersion;
						lastSetJobUuidField = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolRCLastJobSetUUIDValue;
						global::SpecialFeatures.LastSetJobUuidHelper.SetLastSetJobUuidField(null);
						base.UpdatePINPasswordBeforeWrite();
						global::SpecialFeatures.VoiceAnnouncements.TtsDataTreeUpdater.AddTtsToFeatureManager();
						ishItemCollection = base.packToCodeplug();
						num = (short)972619791;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						goto IL_63D;
					}
					goto IL_17F;
					IL_1E5:
					num = (short)655228931;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_221:
					base.GetReadWritePassword(ref this.c, ref this.d, ref this.e, ref this.f);
					num = (short)529072158;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CC:
					global::SpecialFeatures.LastSetJobUuidHelper.SetLastSetJobUuidField(lastSetJobUuidField);
					global::SpecialFeatures.Comms.Clone.a = true;
					num = (short)167641115;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F6:
					num = (short)1374093336;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_489:
					flag3 = false;
					num = (short)1507065865;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_55F:
					flag = base.WriteRadio(ishItemCollection, WriteType, radioParams, inbatchMode);
					num = (short)419364885;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_621:
					flag3 = flag2;
					num = (short)922681377;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_63D:
					num = (short)2064973842;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_678:
					num = (short)686293023;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_714:
					global::SpecialFeatures.Comms.Clone.b = false;
					num = (short)33619988;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_733:
				return flag;
				IL_17F:
				radioParams = new global::SpecialFeatures.Comms.RadioParams();
				num = (short)1510932480;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_F0;
			}
			catch (global::System.Exception ex)
			{
				if (ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
				{
					if (!flag && !(bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﲐﺒ練ﶘ힚쒠", a_)])
					{
						radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue = radInfoGeneralCodeplugVersion_A7683_UIValue;
					}
					global::SpecialFeatures.LastSetJobUuidHelper.SetLastSetJobUuidField(lastSetJobUuidField);
					global::SpecialFeatures.Comms.Clone.a = true;
					throw new global::Motorola.Common.CustomException.CommonException(global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write);
				}
			}
			finally
			{
				this.g.ClearCachedPasswordValidation();
				base.ForceClose();
			}
			return flag;
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0018A254 File Offset: 0x00188454
		internal void FileCloneForceClose()
		{
			short num = (short)1645414153;
			short num2 = num;
			num = (short)493291273;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1975779328;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1570766848;
			if (num != 0)
			{
			}
			num = (short)1574174721;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Comms.Clone.b = false;
			base.ForceClose();
		}

		// Token: 0x040009D5 RID: 2517
		private static bool a;

		// Token: 0x040009D6 RID: 2518
		private static bool b;

		// Token: 0x040009D7 RID: 2519
		private bool c;

		// Token: 0x040009D8 RID: 2520
		private bool d;

		// Token: 0x040009D9 RID: 2521
		private bool e;

		// Token: 0x040009DA RID: 2522
		private string f = string.Empty;

		// Token: 0x040009DB RID: 2523
		private readonly global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp g;

		// Token: 0x040009DC RID: 2524
		private global::System.Windows.Window h;
	}
}
