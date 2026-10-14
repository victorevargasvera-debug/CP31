using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using AcpASKLib;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpSecurityLib;
using AcpUtility;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;

namespace SpecialFeatures.Security
{
	// Token: 0x0200004D RID: 77
	public abstract class RadioAccessValidatorBase
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x0007AAE0 File Offset: 0x00078CE0
		internal RadioAccessValidatorBase(global::SpecialFeatures.Comms.COMMS_OP writeType, global::SpecialFeatures.Security.RadioSecurityData radioSecData, global::SpecialFeatures.Security.RadioSecurityData codeplugSecData, bool writeProtectWriteProtectedRadio = false, bool otapBatchProgramming = false, bool flashportFromCvnToTrk = false, bool IsSkipWorkingCPParticularContentCheck = false)
		{
			this.WriteType = writeType;
			this.radSecData = radioSecData;
			this.cpgSecData = codeplugSecData;
			this.WriteProtectWriteProtectedRadio = writeProtectWriteProtectedRadio;
			this.OtapBatchProgramming = otapBatchProgramming;
			this.askSerialNumList = new global::System.Collections.ObjectModel.Collection<string>();
			this.isFlashport = flashportFromCvnToTrk;
			this.IsSkipWorkingCPParticularContentCheck = IsSkipWorkingCPParticularContentCheck;
		}

		// Token: 0x060007D5 RID: 2005
		protected abstract void RestoreOwnerSystemData();

		// Token: 0x060007D6 RID: 2006
		protected abstract void RestoreRadioWideSecurityData();

		// Token: 0x060007D7 RID: 2007
		protected abstract void RestoreWriteProtect();

		// Token: 0x060007D8 RID: 2008
		protected abstract bool RestoreASKRequiredFlag(bool bUnLimitedOwnASKAttached);

		// Token: 0x060007D9 RID: 2009
		protected abstract bool HandleWriteProtect(out string stsMsg);

		// Token: 0x060007DA RID: 2010
		protected abstract bool IsCpgOwnerIDValid(out string stsMsg);

		// Token: 0x060007DB RID: 2011
		protected abstract void UpdateASKProgrammingHistory();

		// Token: 0x060007DC RID: 2012
		protected abstract void UpdateTrkSysShuffledBandPlans();

		// Token: 0x060007DD RID: 2013
		protected abstract global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> GetCodeplugTrkSystemIDs();

		// Token: 0x060007DE RID: 2014 RVA: 0x0007AB34 File Offset: 0x00078D34
		internal bool Validate(out string stsMsg, ref global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> attachedASKs, ref bool? isSpecialKeyAttached)
		{
			int a_ = 17;
			short num = (short)1373044736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_207;
				}
				bool flag;
				bool result;
				string text;
				string str;
				for (;;)
				{
					IL_30:
					global::AcpASKLib.SystemKeyData systemKeyData2;
					global::AcpASKLib.SystemKeyData systemKeyData;
					global::AcpASKLib.KeyType keyType;
					int num5;
					bool flag5;
					bool cloneDisabled;
					switch (num2)
					{
					case 0:
						systemKeyData = systemKeyData2;
						num = (short)745537599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_37D;
					case 2:
						if (this.radSecData.ProtectionOptn != global::SpecialFeatures.Security.ProtectionOption.LEGACY_SW)
						{
							num = (short)2088173614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF3;
					case 3:
						if (flag)
						{
							num = (short)977993740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 4:
						if (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.DEPOT)
						{
							num = (short)81854548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 5:
					{
						global::AcpASKLib.SystemKeyData systemKeyData3;
						this.a(systemKeyData3.iBtnSerialNum);
						bool flag2 = systemKeyData3.WriteProtectEnabled;
						num = (short)411762715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)830734336;
						short num3 = num;
						stsMsg = global::CommonResources.AppResources.Permission_Denied_ASK_OTAP_Enabled;
						flag = false;
						num = (short)392429683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (systemKeyData2 != null)
						{
							num = (short)489357402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A50;
					case 8:
						goto IL_9C0;
					case 9:
						if (!this.radSecData.IsConventionalOnly)
						{
							num = (short)1234567272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_321;
					case 10:
						if (systemKeyData.WriteProtectEnabled)
						{
							num = (short)1703739454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BE;
					case 11:
						goto IL_11E2;
					case 12:
						this.UpdateASKProgrammingHistory();
						num = (short)1979318276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)1745120947;
						short num4 = num;
						num = (short)431386291;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_94A;
						default:
						{
							num = (short)1202520064;
							if (num != 0)
							{
							}
							bool flag3 = true;
							bool? flag4 = isSpecialKeyAttached;
							if (flag3 == flag4.GetValueOrDefault() & flag4 != null)
							{
								num = (short)233898051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1175060522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 14:
						if (this.radSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED)
						{
							num = (short)348979252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1220;
					case 15:
						num = (short)1487208462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (this.WriteType != global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE)
						{
							num = (short)971964513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 17:
						goto IL_C0A;
					case 18:
						goto IL_567;
					case 19:
						goto IL_12FA;
					case 20:
						goto IL_3BE;
					case 21:
						goto IL_487;
					case 22:
						goto IL_12FA;
					case 23:
						goto IL_287;
					case 24:
						if (this.a())
						{
							num = (short)1432420367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C0;
					case 25:
					{
						int ownerAdvancedKeyType;
						if (ownerAdvancedKeyType != 0)
						{
							num = (short)1535049792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						keyType = global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
						num5 = this.radSecData.OwnerSystemID;
						num = (short)838008920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						stsMsg = global::CommonResources.AppResources.Permission_Denied_ASK_Loaded_OTAP_Enabled;
						num = (short)44171275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_9C0;
					case 28:
					{
						int ownerAdvancedKeyType;
						if (ownerAdvancedKeyType != 1)
						{
							num = (short)1193214037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						keyType = global::AcpASKLib.KeyType.ADVANCED_WACN_KEY;
						num5 = this.radSecData.OwnerWACNID;
						num = (short)4259859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						goto IL_2DB;
					case 30:
					{
						bool invalidKeysLoaded;
						bool unlimitedKeyLoaded;
						if (!this.CheckIfAllMatchingSysKeyAreLoaded(ref flag5, ref cloneDisabled, out invalidKeysLoaded, out unlimitedKeyLoaded))
						{
							num = (short)1599078451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2093088823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						result = false;
						num = (short)451215443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (this.radSecData.IsConventionalOnly)
						{
							num = (short)1845624907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8F0;
					case 33:
						num = (short)534904918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)343408650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_12FA;
					case 36:
						if (attachedASKs == null)
						{
							num = (short)385220652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_287;
					case 37:
						num = (short)936443958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_11E2;
					case 39:
						flag = this.b();
						num = (short)1144324154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						this.RestoreRadioWideSecurityData();
						num = (short)517734480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_12FA;
					case 42:
						if (global::AcpSecurityLib.SecurityManager.IsSpecialKeyLoaded)
						{
							num = (short)1441464337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1411579920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_94A;
					case 44:
						attachedASKs = global::AcpSecurityLib.SecurityManager.GetSysKeysFromLoadedAndAttachedASKs();
						num = (short)241631255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						if (!this.isFlashport)
						{
							num = (short)2090401903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int ownerAdvancedKeyType = this.cpgSecData.OwnerAdvancedKeyType;
						num = (short)2000093231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						num = (short)2063073325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
					{
						int ownerAdvancedKeyType;
						if (ownerAdvancedKeyType != 0)
						{
							num = (short)992739407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						keyType = global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
						num5 = this.cpgSecData.OwnerSystemID;
						num = (short)1822228572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						if (!flag5)
						{
							num = (short)187432966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E2;
					case 49:
						num = (short)1941831682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						this.UpdateTrkSysShuffledBandPlans();
						num = (short)431816705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						bool invalidKeysLoaded;
						bool unlimitedKeyLoaded;
						stsMsg = this.GetErrorMessageOfCloneFailureDueToIncorrectSystemKeysLoaded(cloneDisabled, invalidKeysLoaded, unlimitedKeyLoaded);
						flag = false;
						num = (short)1607991334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						num = (short)835584098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						goto IL_487;
					case 54:
						if (this.WriteType == global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_CLONE)
						{
							num = (short)410583153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)586088551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						if (this.WriteType == global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
						{
							num = (short)259063910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E2;
					case 56:
						isSpecialKeyAttached = new bool?(global::AcpSecurityLib.SecurityManager.CheckIfSpecialKeyIsAttached());
						num = (short)817692765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_1073;
					case 58:
						if (!flag)
						{
							num = (short)1031798810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E2;
					case 59:
					{
						global::AcpASKLib.SystemKeyData systemKeyData3 = null;
						num = (short)498991173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						if (!this.IsSkipWorkingCPParticularContentCheck)
						{
							num = (short)1397489697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E2;
					case 61:
						if (flag)
						{
							num = (short)1981218893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 62:
					{
						bool flag2 = true;
						this.a(systemKeyData.iBtnSerialNum);
						num = (short)1365245972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
						goto IL_487;
					case 64:
						num = (short)1994194945;
						if (num != 0)
						{
						}
						num = (short)1020526620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						if (systemKeyData != null)
						{
							num = (short)1892155426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BE;
					case 66:
						text = null;
						flag = this.HandleWriteProtect(out text);
						num = (short)771031118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						result = true;
						num = (short)819462212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.DEPOT)
						{
							num = (short)318636072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)47448138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
					{
						global::AcpASKLib.SystemKeyData systemKeyData3;
						if (!this.a(attachedASKs, out systemKeyData3))
						{
							num = (short)1249509433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)829816932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 70:
						if (!(bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힓秊ﶛ쒟춣좥춧ﲫﶭ", a_)])
						{
							num = (short)12451883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 71:
						if (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.LABTOOL)
						{
							num = (short)361103447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 72:
						if (global::SpecialFeatures.Security.RadioAccessValidatorBase.CheckIfTrkSystemsWithAskRequiredOnAreMissingUnlimitedKeys(this.radSecData, global::AcpSecurityLib.SecurityManager.LoadedASKs))
						{
							num = (short)1256521757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF3;
					case 73:
						if (systemKeyData2.WriteProtectEnabled)
						{
							num = (short)239861760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A50;
					case 74:
						if (!this.IsCpgOwnerIDValid(out stsMsg))
						{
							num = (short)1976959007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 75:
						num = (short)12517465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (this.a(systemKeyData2))
						{
							num = (short)519766111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125E;
					case 77:
					{
						bool flag2 = false;
						systemKeyData2 = null;
						num5 = 0;
						keyType = global::AcpASKLib.KeyType.UNDEFINED_KEY;
						num = (short)1944518752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 78:
						if (!flag)
						{
							num = (short)1505886302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125E;
					case 79:
						num = (short)926679145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						if (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.LABTOOL)
						{
							num = (short)2133327922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 81:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)290127938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125E;
					}
					case 82:
						if (this.WriteType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
						{
							num = (short)834142245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 83:
						goto IL_58F;
					case 84:
						this.RestoreOwnerSystemData();
						num = (short)886505543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						num = (short)714997801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						if (isSpecialKeyAttached == null)
						{
							num = (short)2000289848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1078;
					case 87:
						this.UpdateTrkSysShuffledBandPlans();
						num = (short)155713644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						goto IL_12FA;
					case 89:
						if (!this.isFlashport)
						{
							num = (short)1994850322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8F0;
					case 90:
						num = (short)1848574025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						if (!this.c(systemKeyData2, out str))
						{
							num = (short)277741680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1845624856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						goto IL_12FA;
					case 93:
						goto IL_1078;
					case 94:
						goto IL_D13;
					case 95:
						num = (short)1807876202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						if (!this.radSecData.IsConventionalOnly)
						{
							num = (short)1738866737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF3;
					case 97:
						num = (short)919142482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						if (!this.radSecData.IsConventionalOnly)
						{
							num = (short)707067963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1220;
					case 99:
						systemKeyData = null;
						num = (short)1136263177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
					{
						global::AcpASKLib.SystemKeyData systemKeyData3;
						if (systemKeyData3 != null)
						{
							num = (short)636616709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C0;
					}
					case 101:
						num = (short)390922275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						num = (short)950992944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						if (this.WriteType == global::SpecialFeatures.Comms.COMMS_OP.OTAP_READ_WRITE)
						{
							num = (short)810156071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E2;
					case 104:
						num = (short)227737707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
					{
						int ownerAdvancedKeyType;
						if (ownerAdvancedKeyType != 1)
						{
							num = (short)1722155109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						keyType = global::AcpASKLib.KeyType.ADVANCED_WACN_KEY;
						num5 = this.cpgSecData.OwnerWACNID;
						num = (short)1032912918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 106:
					{
						bool flag2;
						if (!flag2)
						{
							num = (short)1851523171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BE;
					}
					case 107:
						if (this.radSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED)
						{
							num = (short)1196359794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_321;
					case 108:
						return flag;
					case 109:
					{
						this.a(systemKeyData2.iBtnSerialNum);
						bool flag2 = systemKeyData2.WriteProtectEnabled;
						num = (short)1620115464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 110:
						if (systemKeyData2 != null)
						{
							num = (short)1783038061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9A;
					case 111:
					{
						int ownerAdvancedKeyType = this.radSecData.OwnerAdvancedKeyType;
						num = (short)508362777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 112:
						goto IL_E38;
					case 113:
						goto IL_43A;
					case 114:
						this.a(attachedASKs, out systemKeyData);
						num = (short)736690229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						goto IL_11E2;
					}
					goto IL_207;
					IL_287:
					global::SpecialFeatures.Security.RadioAccessValidatorBase.CheckIfOwnerASKIsAttached(num5, keyType, attachedASKs, out systemKeyData2);
					num = (short)1580138568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_321:
					num = (short)577896455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BE:
					num = (short)291766353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43A:
					flag5 = true;
					cloneDisabled = false;
					num = (short)1666580510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_487:
					num = (short)1684471873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8F0:
					num = (short)95879238;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_94A:
					num = (short)836763708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9C0:
					this.RestoreWriteProtect();
					num = (short)310050892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A50:
					this.a(num5, keyType, attachedASKs, out systemKeyData);
					num = (short)1345650709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DF3:
					str = null;
					num = (short)746192987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1078:
					num = (short)807010317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11E2:
					num = (short)660078653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1220:
					num = (short)1081016430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_125E:
					num = (short)1396703235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12FA:
					num = (short)1683554340;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2DB:
				stsMsg = global::CommonResources.AppResources.Missing_unlimited_ASK_required_for_write_or_clone.AcpStringFormat(new object[]
				{
					this.radSecData.IdAndNameOfTrkSysThatWillBeOverwritten.Key,
					this.radSecData.IdAndNameOfTrkSysThatWillBeOverwritten.Value
				});
				return false;
				IL_37D:
				return result;
				IL_567:
				this.RestoreRadioWideSecurityData();
				return true;
				IL_58F:
				return result;
				IL_C0A:
				stsMsg = global::CommonResources.AppResources.Permission_Denied_Attach_FTR_DEPOT_Key;
				return false;
				IL_C9A:
				stsMsg = global::CommonResources.AppResources.Permission_Denied_Write_Without_ASK;
				return false;
				IL_D13:
				stsMsg = text;
				return false;
				IL_E38:
				stsMsg = global::CommonResources.AppResources.Permission_Denied_Incompatible_RaCp_SK_Protection + str;
				return false;
				IL_1073:
				stsMsg = global::CommonResources.AppResources.Permission_Denied_Write_Without_ASK;
				return false;
				IL_207:
				stsMsg = null;
				flag = true;
				num = (short)860225568;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0007BE78 File Offset: 0x0007A078
		internal string GetErrorMessageOfCloneFailureDueToIncorrectSystemKeysLoaded(bool cloneDisabled, bool invalidKeysLoaded, bool unlimitedKeyLoaded)
		{
			short num = (short)1107165189;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_174;
				case 1:
				{
					num = (short)1140763915;
					short num3 = num;
					num = (short)1799007499;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_104;
					default:
						num = (short)594477056;
						if (num != 0)
						{
						}
						if (!invalidKeysLoaded)
						{
							num = (short)672858114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176;
					}
					break;
				}
				case 2:
					goto IL_104;
				case 3:
					goto IL_58;
				case 4:
				{
					if (!unlimitedKeyLoaded)
					{
						num = (short)1407909888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1265631232;
					short num4 = num;
					num = (short)1758330881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				IL_3D:
				if (cloneDisabled)
				{
					num = (short)2086993923;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1529348100;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_58:
			return global::CommonResources.AppResources.Permission_Denied_Clone_For_ASK_With_Clone_Disabled;
			IL_104:
			num = (short)2072510465;
			if (num != 0)
			{
			}
			return global::CommonResources.AppResources.Permission_Denied_SK_For_Trunking_Loaded;
			IL_174:
			return global::CommonResources.AppResources.Permission_Denied_Unlimited_ASK_Needed;
			IL_176:
			return global::CommonResources.AppResources.Permission_Denied_ASK_Needed;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0007C000 File Offset: 0x0007A200
		private void a(string A_0)
		{
			short num = (short)785252357;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					bool flag;
					if (!flag)
					{
						num = (short)2018639872;
						short num3 = num;
						num = (short)1471938562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					this.askSerialNumList.Add(A_0);
					num = (short)1727594496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					bool flag = false;
					global::System.Collections.Generic.IEnumerator<string> enumerator = this.askSerialNumList.GetEnumerator();
					num = (short)1563623428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					try
					{
						num = (short)660013062;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_225;
							case 1:
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator;
								if (string.Compare(enumerator.Current, A_0, true) == 0)
								{
									num = (short)2108162053;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_1C6;
							case 3:
								num = (short)1874591745;
								if (num != 0)
								{
								}
								num = (short)1637154816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)505872387;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)335020033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								bool flag = true;
								num = (short)767754242;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_14D;
								}
								continue;
							}
							IL_14F:
							num = (short)1773731844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_14D:
							goto IL_14F;
						}
						IL_1C6:
						IL_225:
						goto IL_5F;
					}
					finally
					{
						num = (short)1026686978;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_290;
							case 1:
								goto IL_273;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_25A;
								}
								continue;
							}
							IL_25A:
							global::System.Collections.Generic.IEnumerator<string> enumerator;
							if (enumerator != null)
							{
								num = (short)1398734849;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_290;
							IL_273:
							enumerator.Dispose();
							num = (short)653590528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_290:
							num = (short)1625997475;
							short num4 = num;
							num = (short)1586806947;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_273;
							default:
								goto IL_2C4;
							}
						}
						IL_2C4:
						num = (short)287244288;
						if (num != 0)
						{
						}
					}
					return;
					IL_5F:
					num = (short)2020016129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				}
				IL_3E:
				if (this.askSerialNumList == null)
				{
					break;
				}
				num = (short)403243011;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0007C304 File Offset: 0x0007A504
		internal bool CheckIfAllMatchingSysKeyAreLoaded(ref bool otapEnabled, ref bool cloneDisabled, out bool invalidKeysLoaded, out bool unlimitedKeyLoaded)
		{
			short num = (short)229572608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A8;
				}
				bool result;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
						if (codeplugTrkSystemIDs.Count > 0)
						{
							num = (short)1724907548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C6;
					}
					case 1:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection;
						if (collection.Count > 0)
						{
							num = (short)561971221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 2:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection2;
						if (collection2 != null)
						{
							num = (short)93061133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_302;
					}
					case 3:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection;
						if (collection != null)
						{
							num = (short)905969671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 4:
						goto IL_F8;
					case 5:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
						global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> collection3;
						this.CheckIfRequiredKeysAreLoaded(ref result, ref cloneDisabled, ref invalidKeysLoaded, ref unlimitedKeyLoaded, ref otapEnabled, codeplugTrkSystemIDs, collection3, true, global::AcpSecurityLib.SecurityManager.LoadedUserSystemKeys.Select(delegate(global::AcpASKLib.SystemKeyData x)
						{
							short num5 = (short)1888358651;
							short num6 = num5;
							num5 = (short)1331761403;
							switch (num6 == num5)
							{
							}
							num5 = (short)1717895168;
							if (num5 != 0)
							{
							}
							num5 = (short)1226833920;
							short num7 = num5;
							num5 = (short)210894849;
							if (num5 != 0)
							{
							}
							return x.SystemID;
						}).ToList<int>());
						num = (short)1450901518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1248985106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)1066598400;
						short num3 = num;
						num = (short)1947205633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						return result;
					case 9:
						goto IL_302;
					case 10:
						num = (short)274989080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
						if (codeplugTrkSystemIDs != null)
						{
							num = (short)389283862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C6;
					}
					case 12:
					{
						num = (short)1817837569;
						if (num != 0)
						{
						}
						bool flag;
						if (flag)
						{
							num = (short)287834137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2060517395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_7C5;
					case 14:
						goto IL_433;
					case 15:
						goto IL_4E0;
					case 16:
					{
						if (this.cpgSecData.IsConventionalOnly)
						{
							num = (short)1172766749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs = this.GetCodeplugTrkSystemIDs();
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection4 = null;
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection2 = null;
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection = null;
						num = (short)1599340555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> collection3;
						if (collection3 != null)
						{
							num = (short)2086666267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)519241736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> collection3;
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection4;
						this.CheckIfRequiredKeysAreLoaded(ref result, ref cloneDisabled, ref invalidKeysLoaded, ref unlimitedKeyLoaded, ref otapEnabled, collection4, global::AcpSecurityLib.SecurityManager.LoadedASKs, true, collection3.Select(delegate(global::AcpASKLib.SystemKeyData x)
						{
							short num5 = (short)1116975578;
							short num6 = num5;
							num5 = (short)967225818;
							switch (num6 == num5)
							{
							}
							num5 = (short)912982017;
							if (num5 != 0)
							{
							}
							num5 = (short)1830879232;
							short num7 = num5;
							num5 = (short)368771072;
							if (num5 != 0)
							{
							}
							return x.SystemID;
						}).ToList<int>());
						num = (short)219545604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection4;
						if (collection4 != null)
						{
							num = (short)1135476746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					}
					case 20:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection2;
						global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> collection3;
						this.CheckIfRequiredKeysAreLoaded(ref result, ref cloneDisabled, ref invalidKeysLoaded, ref unlimitedKeyLoaded, ref otapEnabled, collection2, collection3, false, null);
						num = (short)560005129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection;
						global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> collection3;
						this.CheckIfRequiredKeysAreLoaded(ref result, ref cloneDisabled, ref invalidKeysLoaded, ref unlimitedKeyLoaded, ref otapEnabled, collection, collection3, false, null);
						num = (short)1425211418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						num = (short)43909120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection2;
						if (collection2.Count > 0)
						{
							num = (short)516292628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_302;
					}
					case 24:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection4;
						if (collection4.Count > 0)
						{
							num = (short)400097286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					}
					case 25:
						num = (short)1217069061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_2FD;
					case 27:
						otapEnabled = false;
						num = (short)1679294476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						try
						{
							num = (short)1723596811;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> collection3;
								bool flag;
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
									global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection4 = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID>(codeplugTrkSystemIDs.Where(delegate(global::SpecialFeatures.Security.TrkSysID x)
									{
										if (x.AskRequired != null)
										{
											short num5 = (short)1917176817;
											short num6 = num5;
											num5 = (short)1033489393;
											switch ((num6 == num5) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
											{
												num5 = (short)1706622977;
												if (num5 != 0)
												{
												}
												num5 = (short)258736128;
												short num7 = num5;
												num5 = (short)781975552;
												if (num5 != 0)
												{
												}
												break;
											}
											}
											return x.AskRequired.Value;
										}
										return false;
									}).ToArray<global::SpecialFeatures.Security.TrkSysID>());
									num = (short)1368915972;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_5E2;
								case 2:
									goto IL_7B7;
								case 3:
								{
									global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
									global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID>(codeplugTrkSystemIDs.Where(delegate(global::SpecialFeatures.Security.TrkSysID x)
									{
										short num5 = (short)127275643;
										short num6 = num5;
										num5 = (short)1378488955;
										switch (num6 == num5)
										{
										}
										num5 = (short)245563393;
										if (num5 != 0)
										{
										}
										num5 = (short)1622474752;
										short num7 = num5;
										num5 = (short)893779968;
										if (num5 != 0)
										{
										}
										return x.SystemKeyType == global::AcpASKLib.KeyType.ADVANCED_WACN_KEY;
									}).ToArray<global::SpecialFeatures.Security.TrkSysID>());
									num = (short)1522991114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
									global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection2 = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID>(codeplugTrkSystemIDs.Where(delegate(global::SpecialFeatures.Security.TrkSysID x)
									{
										if (x.AskRequired != null)
										{
											short num5 = (short)2079557163;
											short num6 = num5;
											num5 = (short)1650558507;
											switch ((num6 == num5) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
											{
												num5 = (short)1963524096;
												if (num5 != 0)
												{
												}
												num5 = (short)2015232000;
												short num7 = num5;
												num5 = (short)1827012609;
												if (num5 != 0)
												{
												}
												break;
											}
											}
											return !x.AskRequired.Value;
										}
										return false;
									}).ToArray<global::SpecialFeatures.Security.TrkSysID>());
									num = (short)392298499;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)835846153;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_79F;
								case 7:
									goto IL_66E;
								case 8:
								{
									num = (short)774413035;
									short num4 = num;
									num = (short)1620744939;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)264044544;
										if (num != 0)
										{
										}
										if (this.cpgSecData.ProtectionOptn != global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED)
										{
											collection3 = global::AcpSecurityLib.SecurityManager.LoadedUserSystemKeys;
											flag = false;
											num = (short)1395589120;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									num = (short)169148423;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									if (!this.cpgSecData.ASKRequired)
									{
										num = (short)1873543169;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_66E;
								case 10:
									goto IL_79F;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_57D;
									}
									continue;
								}
								IL_57D:
								if (this.cpgSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
								{
									num = (short)1469054981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5E2:
								num = (short)1635188744;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_66E:
								collection3 = global::AcpSecurityLib.SecurityManager.LoadedASKs;
								flag = true;
								num = (short)1524563974;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_79F:
								num = (short)917635074;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7B7:
							goto IL_18C;
						}
						catch (global::System.Exception)
						{
							return false;
						}
						goto IL_7C5;
						IL_18C:
						num = (short)2042429457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						return true;
					}
					goto IL_A8;
					IL_F8:
					num = (short)1837105154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_302:
					num = (short)301989891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C6:
					result = false;
					num = (short)1983184911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7C5:
					num = (short)1016856599;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_2FD:
				IL_433:
				IL_4E0:
				return result;
				IL_A8:
				result = true;
				invalidKeysLoaded = false;
				unlimitedKeyLoaded = true;
				num = (short)1411317776;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0007CB38 File Offset: 0x0007AD38
		internal void CheckIfRequiredKeysAreLoaded(ref bool requiredKeysLoaded, ref bool cloneDisabled, ref bool invalidKeysLoaded, ref bool unlimitedKeyLoaded, ref bool otapEnabled, global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> cpTrkSysIds, global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> keys, bool hardwareKeyRequired, global::System.Collections.Generic.List<int> loadedUserSystemKeysIds = null)
		{
			short num = (short)1301086208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.TrkSysID> enumerator2;
				for (;;)
				{
					IL_29:
					global::System.Func<global::SpecialFeatures.Security.TrkSysID, int> selector;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						try
						{
							num = (short)618201090;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_54F;
								case 1:
									try
									{
										num = (short)2108882958;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::SpecialFeatures.Security.TrkSysID trkSysID;
												if (trkSysID.UnlimitedAskRequired)
												{
													num = (short)1379205124;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_34D;
											}
											case 1:
												goto IL_30E;
											case 2:
											{
												global::SpecialFeatures.Security.TrkSysID trkSysID;
												global::AcpASKLib.SystemKeyData systemKeyData;
												if (systemKeyData.Type == trkSysID.SystemKeyType)
												{
													num = (short)1918894091;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
											{
												global::SpecialFeatures.Security.TrkSysID trkSysID;
												global::AcpASKLib.SystemKeyData systemKeyData;
												if (systemKeyData.SystemID == trkSysID.ID)
												{
													num = (short)1430454282;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												num = (short)508362759;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												if (!otapEnabled)
												{
													num = (short)1939865606;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_46B;
											case 6:
											{
												global::AcpASKLib.SystemKeyData systemKeyData;
												otapEnabled = systemKeyData.OtapEnabled;
												num = (short)836108307;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												global::AcpASKLib.SystemKeyData systemKeyData;
												if (systemKeyData.AccessLevelType == global::AcpASKLib.KeyAccessLevelType.LIMITED_ACC)
												{
													num = (short)1518534674;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_34D;
											}
											case 8:
												goto IL_46B;
											case 9:
											{
												global::AcpASKLib.SystemKeyData systemKeyData;
												if (systemKeyData.AccessLevel.IsCloningEnabled())
												{
													num = (short)502071312;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												cloneDisabled = true;
												num = (short)1431961613;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 10:
												num = (short)833355778;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 11:
												num = (short)1865023488;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 12:
												goto IL_483;
											case 13:
												goto IL_30E;
											case 14:
												switch (0)
												{
												case 0:
													goto IL_206;
												}
												continue;
											case 15:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)2064842760;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
												num = (short)1506803715;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 16:
											{
												bool flag = true;
												num = (short)1527250945;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 17:
												goto IL_3AE;
											case 18:
												unlimitedKeyLoaded = false;
												num = (short)1340407825;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 19:
												goto IL_466;
											}
											IL_2CD:
											num = (short)584122383;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_206:
											goto IL_2CD;
											IL_30E:
											num = (short)945291269;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_34D:
											num = (short)1528233993;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_46B:
											num = (short)1791688716;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3AE:
										IL_466:
										IL_483:
										goto IL_158;
									}
									finally
									{
										num = (short)1951989761;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)1951989762;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_4BB;
												}
												continue;
											case 2:
												goto IL_4F2;
											}
											IL_4BB:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1210712064;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_4F2:;
									}
									break;
									IL_158:
									num = (short)240844803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_153;
									}
									continue;
								case 3:
								{
									bool flag;
									if (!flag)
									{
										num = (short)1077542918;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)450494469;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.Security.TrkSysID trkSysID = enumerator2.Current;
									bool flag = false;
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = keys.GetEnumerator();
									num = (short)1916928001;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1951399943;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									requiredKeysLoaded = false;
									num = (short)1618345984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_59C;
								}
								IL_4F5:
								num = (short)403439620;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_153:
								goto IL_4F5;
							}
							IL_54F:
							IL_59C:
							goto IL_629;
						}
						finally
						{
							num = (short)245628929;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)2023555074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5D5;
									}
									continue;
								case 2:
									goto IL_60A;
								}
								IL_5D5:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1494089728;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_60A:;
						}
						goto IL_60D;
						IL_629:
						num = (short)833748995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if ((selector = global::SpecialFeatures.Security.RadioAccessValidatorBase.<>c.<>9__24_0) == null)
						{
							goto IL_60D;
						}
						goto IL_C9;
					case 3:
					{
						num = (short)1510604801;
						if (num != 0)
						{
						}
						if (!hardwareKeyRequired)
						{
							return;
						}
						num = (short)750801758;
						short num3 = num;
						num = (short)528896862;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)172425216;
							short num4 = num;
							num = (short)805568512;
							if (num != 0)
							{
							}
							num = (short)1164247046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						num = (short)1483276290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (loadedUserSystemKeysIds != null)
						{
							num = (short)1139539972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num = (short)952238085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C;
					IL_C9:
					global::System.Collections.Generic.List<int> list = cpTrkSysIds.Select(selector).ToList<int>();
					invalidKeysLoaded = (list.Intersect(loadedUserSystemKeysIds).Count<int>() == list.Count);
					num = (short)299106304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60D:
					selector = (global::SpecialFeatures.Security.RadioAccessValidatorBase.<>c.<>9__24_0 = delegate(global::SpecialFeatures.Security.TrkSysID x)
					{
						short num5 = (short)826845685;
						short num6 = num5;
						num5 = (short)501787125;
						switch (num6 == num5)
						{
						}
						num5 = (short)633995264;
						if (num5 != 0)
						{
						}
						num5 = (short)1655504896;
						short num7 = num5;
						num5 = (short)1744306177;
						if (num5 != 0)
						{
						}
						return x.ID;
					});
					goto IL_C9;
				}
				return;
				IL_4C:
				enumerator2 = cpTrkSysIds.GetEnumerator();
				num = (short)1079312385;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0007D27C File Offset: 0x0007B47C
		private bool b()
		{
			short num = (short)606863360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_80;
				}
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> collection;
				bool flag;
				global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.TrkSysID> enumerator;
				for (;;)
				{
					IL_27:
					num = (short)837877761;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						try
						{
							collection = global::AcpSecurityLib.SecurityManager.LoadedASKs;
							goto IL_222;
						}
						catch (global::System.Exception)
						{
							return false;
						}
						goto Block_7;
						IL_222:
						num = (short)1540947978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1097684526;
						short num3 = num;
						num = (short)732845614;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_97;
						case 1:
							goto IL_209;
						}
						goto Block_4;
					}
					case 2:
					{
						collection = null;
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs = this.GetCodeplugTrkSystemIDs();
						num = (short)851976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_E7;
					case 4:
						num = (short)2021654537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_97;
					case 6:
					{
						flag = false;
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
						enumerator = codeplugTrkSystemIDs.GetEnumerator();
						num = (short)722534403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_147;
					case 8:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
						if (codeplugTrkSystemIDs != null)
						{
							num = (short)690946052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12D;
					}
					case 9:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
						if (codeplugTrkSystemIDs.Count > 0)
						{
							num = (short)273743872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12D;
					}
					case 10:
						if (collection != null)
						{
							num = (short)125435910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)410451969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_80;
					IL_97:
					if (!this.cpgSecData.IsConventionalOnly)
					{
						num = (short)1638662146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return flag;
					IL_12D:
					flag = false;
					num = (short)1575813127;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E7:
				goto IL_26D;
				IL_147:
				return flag;
				Block_4:
				num = (short)1184432128;
				short num4 = num;
				IL_209:
				num = (short)1413480448;
				if (num != 0)
				{
				}
				return flag;
				Block_7:
				try
				{
					IL_26D:
					num = (short)1974009858;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1704132609;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.Security.TrkSysID trkSysID = enumerator.Current;
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator2 = collection.GetEnumerator();
							num = (short)1695809539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)2039414791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2B4;
							}
							continue;
						case 3:
							try
							{
								num = (short)899547141;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)557580295;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::SpecialFeatures.Security.TrkSysID trkSysID;
										global::AcpASKLib.SystemKeyData systemKeyData;
										if (systemKeyData.SystemID == trkSysID.ID)
										{
											num = (short)1664352266;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1465384963;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.SystemKeyData systemKeyData = enumerator2.Current;
										num = (short)406323201;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)1970667526;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_412;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_335;
										}
										continue;
									case 6:
										goto IL_482;
									case 7:
									{
										global::AcpASKLib.SystemKeyData systemKeyData;
										if (systemKeyData.OtapEnabled)
										{
											num = (short)471400456;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										flag = true;
										num = (short)371851268;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										global::SpecialFeatures.Security.TrkSysID trkSysID;
										global::AcpASKLib.SystemKeyData systemKeyData;
										if (systemKeyData.Type == trkSysID.SystemKeyType)
										{
											num = (short)304545792;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
										num = (short)2057568265;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_337:
									num = (short)97976322;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_335:
									goto IL_337;
								}
								IL_412:
								IL_482:;
							}
							finally
							{
								num = (short)1367146497;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator2;
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)2081685506;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_4B7;
										}
										continue;
									case 2:
										goto IL_4EF;
									}
									IL_4B7:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1850146816;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4EF:;
							}
							num = (short)1568866310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)237633541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_540;
						case 6:
							if (flag)
							{
								num = (short)308346884;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 7:
							goto IL_59C;
						}
						IL_545:
						num = (short)420151296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B4:
						goto IL_545;
					}
					IL_540:
					IL_59C:
					return flag;
				}
				finally
				{
					num = (short)881000449;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)792526850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_5D3;
							}
							continue;
						case 2:
							goto IL_60B;
						}
						IL_5D3:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1164312576;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_60B:;
				}
				bool result;
				return result;
				IL_80:
				flag = true;
				num = (short)145424389;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0007D8E4 File Offset: 0x0007BAE4
		private bool a(global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> A_0, out global::AcpASKLib.SystemKeyData A_1)
		{
			short num = (short)256049152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				bool result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
						if (codeplugTrkSystemIDs.Count > 0)
						{
							num = (short)148635649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 1:
						num = (short)470089735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
						if (codeplugTrkSystemIDs != null)
						{
							num = (short)1414856708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 3:
					{
						global::AcpASKLib.SystemKeyData systemKeyData;
						if (systemKeyData != null)
						{
							num = (short)146604044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 4:
						num = (short)678952961;
						if (num != 0)
						{
						}
						goto IL_517;
					case 5:
					{
						global::AcpASKLib.SystemKeyData systemKeyData = null;
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = A_0.GetEnumerator();
						num = (short)246022154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return result;
					case 7:
						if (A_0 != null)
						{
							num = (short)782565381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 8:
						return result;
					case 9:
					{
						num = (short)1784020992;
						short num3 = num;
						global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs = this.GetCodeplugTrkSystemIDs();
						num = (short)1779105794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						try
						{
							num = (short)640942088;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_45C;
								case 1:
									goto IL_183;
								case 2:
									num = (short)1076690951;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpASKLib.SystemKeyData systemKeyData;
									if (systemKeyData != null)
									{
										num = (short)1571684354;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)2107965441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									try
									{
										num = (short)941424649;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::AcpASKLib.SystemKeyData systemKeyData2;
												global::AcpASKLib.SystemKeyData systemKeyData = systemKeyData2;
												num = (short)263454728;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												goto IL_25E;
											case 2:
											{
												global::AcpASKLib.SystemKeyData systemKeyData2;
												global::SpecialFeatures.Security.TrkSysID trkSysID;
												if (trkSysID.ID == systemKeyData2.SystemID)
												{
													num = (short)756678660;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
												goto IL_35B;
											case 4:
												num = (short)823132166;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												num = (short)148504577;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
											{
												global::AcpASKLib.SystemKeyData systemKeyData2;
												global::SpecialFeatures.Security.TrkSysID trkSysID;
												if (trkSysID.SystemKeyType == systemKeyData2.Type)
												{
													num = (short)182321152;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 7:
											{
												global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.TrkSysID> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)31260682;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::SpecialFeatures.Security.TrkSysID trkSysID = enumerator2.Current;
												num = (short)343277570;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
											{
												global::AcpASKLib.SystemKeyData systemKeyData2;
												if (systemKeyData2.WriteProtectEnabled)
												{
													num = (short)1402208261;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 9:
												switch (0)
												{
												case 0:
													goto IL_206;
												}
												continue;
											case 10:
												num = (short)36503555;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_208:
											num = (short)1636564999;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_206:
											goto IL_208;
										}
										IL_25E:
										IL_35B:;
									}
									finally
									{
										num = (short)935002114;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.TrkSysID> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)1920073729;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_3C8;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_391;
												}
												continue;
											}
											IL_391:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1534853120;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3C8:;
									}
									num = (short)505806851;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1092550665;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.SystemKeyData systemKeyData2 = enumerator.Current;
									global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> codeplugTrkSystemIDs;
									global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.TrkSysID> enumerator2 = codeplugTrkSystemIDs.GetEnumerator();
									num = (short)1879769093;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::AcpASKLib.SystemKeyData systemKeyData;
									if (systemKeyData.WriteProtectEnabled)
									{
										num = (short)2145583108;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_133;
									}
									continue;
								case 9:
									num = (short)403243008;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_135:
								num = (short)9109510;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_133:
								goto IL_135;
							}
							IL_183:
							IL_45C:
							goto IL_A7;
						}
						finally
						{
							num = (short)220659714;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1811546113;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_4CA;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_493;
									}
									continue;
								}
								IL_493:
								if (enumerator != null)
								{
									num = (short)769720320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4CA:
								num = (short)694080123;
								short num4 = num;
								num = (short)1593365115;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_493;
								default:
									goto IL_500;
								}
							}
							IL_500:
							num = (short)492240896;
							if (num != 0)
							{
							}
						}
						goto IL_517;
						IL_A7:
						num = (short)1346699267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (!this.cpgSecData.IsConventionalOnly)
						{
							num = (short)1929510921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)408158214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::AcpASKLib.SystemKeyData systemKeyData;
						A_1 = systemKeyData;
						result = true;
						num = (short)974979080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_63;
					IL_517:
					num = (short)892338176;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_63:
				A_1 = null;
				result = false;
				num = (short)423165963;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0007DFB4 File Offset: 0x0007C1B4
		private bool a(int A_0, global::AcpASKLib.KeyType A_1, global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> A_2, out global::AcpASKLib.SystemKeyData A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
				switch (num)
				{
				case 0:
					goto IL_2E5;
				case 1:
					try
					{
						num2 = (short)1136394249;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_196;
							case 1:
							{
								global::AcpASKLib.SystemKeyData systemKeyData;
								if (A_0 == systemKeyData.SystemID)
								{
									num2 = (short)1692401670;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 2:
							{
								global::AcpASKLib.SystemKeyData systemKeyData;
								if (systemKeyData.WriteProtectEnabled)
								{
									num2 = (short)1690632196;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 3:
								goto IL_278;
							case 4:
							{
								global::AcpASKLib.SystemKeyData systemKeyData;
								A_3 = systemKeyData;
								result = true;
								num2 = (short)1917386752;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 5:
							{
								num2 = (short)992414629;
								short num3 = num2;
								num2 = (short)387058597;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1D6;
								default:
									num2 = (short)1317208064;
									if (num2 != 0)
									{
									}
									num2 = (short)816513026;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 6:
								goto IL_1D6;
							case 7:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)1783693322;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
								num2 = (short)789250049;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 8:
							{
								global::AcpASKLib.SystemKeyData systemKeyData;
								if (A_1 == systemKeyData.Type)
								{
									num2 = (short)1632829445;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 9:
								switch (0)
								{
								case 0:
									goto IL_FC;
								}
								continue;
							case 10:
								num2 = (short)570228739;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_FE:
							num2 = (short)363593735;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_FC:
							goto IL_FE;
							IL_1D6:
							num2 = (short)1381629960;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_196:
						IL_278:
						return result;
					}
					finally
					{
						num2 = (short)399441922;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1888354305;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_2E2;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_2AF;
								}
								continue;
							}
							IL_2AF:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)747044864;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_2E2:;
					}
					goto IL_2E5;
				case 2:
					if (A_2 != null)
					{
						num2 = (short)1077542912;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_1C;
				IL_2E5:
				enumerator = A_2.GetEnumerator();
				num2 = (short)1578434561;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1C:
			num2 = (short)1084751873;
			if (num2 != 0)
			{
			}
			A_3 = null;
			result = false;
			num2 = (short)1785724928;
			short num4 = num2;
			num2 = (short)1127874562;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0007E2E8 File Offset: 0x0007C4E8
		public static bool CheckIfOwnerASKIsAttached(int homeSysId, global::AcpASKLib.KeyType homeKeyType, global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> attachedASKs, out global::AcpASKLib.SystemKeyData outASK)
		{
			short num = (short)1888288768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				global::AcpASKLib.SystemKeyData systemKeyData;
				global::AcpASKLib.SystemKeyData systemKeyData3;
				global::AcpASKLib.SystemKeyData systemKeyData4;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1362165761;
						if (num != 0)
						{
						}
						if (systemKeyData != null)
						{
							num = (short)1982005255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_596;
					case 1:
						try
						{
							num = (short)649658385;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpASKLib.SystemKeyData systemKeyData2;
								switch (num2)
								{
								case 0:
									if (systemKeyData2.AccessLevel != null)
									{
										num = (short)1894776835;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									num = (short)790167566;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3D0;
								case 3:
								{
									global::AcpASKLib.KeyAccessLevelType keyAccessLevelType = systemKeyData2.AccessLevel.GetKeyAccessLevelType();
									num = (short)1037565970;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)166854656;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)2117730314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::AcpASKLib.KeyAccessLevelType keyAccessLevelType;
									if (keyAccessLevelType == global::AcpASKLib.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
									{
										num = (short)392626178;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1956642832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)770899976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_409;
								case 11:
									if (homeSysId == systemKeyData2.SystemID)
									{
										num = (short)2017067009;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 12:
									systemKeyData3 = systemKeyData2;
									num = (short)1697710086;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_3EB;
								case 14:
									if (homeKeyType == systemKeyData2.Type)
									{
										num = (short)2022834180;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 15:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1442775047;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									systemKeyData2 = enumerator.Current;
									num = (short)1371734027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									if (systemKeyData2.WriteProtectEnabled)
									{
										num = (short)1512898572;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									systemKeyData = systemKeyData2;
									num = (short)822935557;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									switch (0)
									{
									case 0:
										goto IL_179;
									}
									continue;
								case 18:
								{
									global::AcpASKLib.KeyAccessLevelType keyAccessLevelType;
									if (keyAccessLevelType == global::AcpASKLib.KeyAccessLevelType.UNLM_ACC)
									{
										goto IL_3D0;
									}
									num = (short)1638112303;
									short num3 = num;
									num = (short)1467849775;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_409;
									default:
										num = (short)944242688;
										if (num != 0)
										{
										}
										num = (short)1675821065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_196:
								num = (short)29163535;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_179:
								goto IL_196;
								IL_3D0:
								systemKeyData4 = systemKeyData2;
								num = (short)1352073229;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3EB:
							IL_409:
							goto IL_55B;
						}
						finally
						{
							num = (short)1117650946;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)603848705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_476;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_440;
									}
									continue;
								}
								IL_440:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1394933760;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_476:;
						}
						goto IL_479;
						IL_55B:
						num = (short)991887366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1021181952;
						short num4 = num;
						outASK = systemKeyData4;
						num = (short)2051342347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (systemKeyData3 != null)
						{
							num = (short)96534533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_479;
					case 4:
						goto IL_B8;
					case 5:
						outASK = systemKeyData3;
						num = (short)786628612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (systemKeyData4 != null)
						{
							num = (short)186449922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)227016707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						outASK = systemKeyData;
						num = (short)1842806793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = attachedASKs.GetEnumerator();
						num = (short)1845755905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_559;
					case 10:
						if (attachedASKs != null)
						{
							num = (short)96075784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_596;
					case 11:
						goto IL_102;
					}
					goto IL_5E;
					IL_479:
					num = (short)2122448896;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B8:
				IL_102:
				IL_559:
				IL_596:
				return outASK != null;
				IL_5E:
				outASK = null;
				systemKeyData4 = null;
				systemKeyData3 = null;
				systemKeyData = null;
				num = (short)726925322;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0007E8AC File Offset: 0x0007CAAC
		private bool a()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					num2 = (short)841744389;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)112984068;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					num2 = (short)1295646721;
					if (num2 != 0)
					{
					}
					if (this.radSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED)
					{
						num2 = (short)773455883;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
					if (this.radSecData.ASKRequired)
					{
						num2 = (short)754057225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21A;
				case 6:
					if (!this.radSecData.IsConventionalOnly)
					{
						num2 = (short)730791938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 7:
					if (this.radSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)1535311873;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21A;
				case 8:
					num2 = (short)221446151;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					result = true;
					num2 = (short)22020096;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (this.radSecData.WriteProtected)
					{
						num2 = (short)2106392584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 11:
				{
					num2 = (short)620036096;
					short num3 = num2;
					result = true;
					num2 = (short)407382092;
					short num4 = num2;
					num2 = (short)1694640204;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)2076901376;
						if (num2 != 0)
						{
						}
						num2 = (short)1679884291;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_40;
				IL_21A:
				num2 = (short)574685190;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_40:
			result = false;
			num2 = (short)1570504714;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0007EB14 File Offset: 0x0007CD14
		private bool a(global::AcpASKLib.SystemKeyData A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_D4;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					goto IL_3D8;
				case 1:
					num2 = (short)2032467984;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)2034892805;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1863254017;
					if (num2 != 0)
					{
					}
					num2 = (short)1280442393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!this.cpgSecData.ASKRequired)
					{
						num2 = (short)2135031832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
					if (this.cpgSecData.ASKRequired)
					{
						num2 = (short)1349189680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					num2 = (short)946536479;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					result = true;
					num2 = (short)1629290531;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)169476140;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)686882842;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (this.radSecData.ASKRequired)
					{
						num2 = (short)1368719367;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17F;
				case 11:
					num2 = (short)513474593;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_5C2;
				case 13:
					num2 = (short)103415847;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (A_0 != null)
					{
						num2 = (short)863567872;
						short num3 = num2;
						num2 = (short)1719795720;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 15:
					if (!this.radSecData.WriteProtected)
					{
						num2 = (short)953221167;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 16:
					if (!this.radSecData.ASKRequired)
					{
						num2 = (short)1721761811;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 17:
					if (this.WriteType != global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_CLONE)
					{
						num2 = (short)2097217578;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 18:
					if (this.radSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)224395265;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 19:
					num2 = (short)1699807275;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					flag = true;
					goto IL_361;
				case 21:
					return result;
				case 22:
					if (this.WriteType != global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_CLONE)
					{
						num2 = (short)435486733;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 23:
					return result;
				case 24:
					result = false;
					num2 = (short)198574103;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (this.WriteType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
					{
						num2 = (short)706871326;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 26:
					flag = (A_0.AccessLevelType == global::AcpASKLib.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP);
					goto IL_361;
				case 27:
					num2 = (short)30015492;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					if (this.radSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)942669853;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17F;
				case 29:
				{
					num2 = (short)1882138063;
					short num4 = num2;
					num2 = (short)2027759055;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D8;
					default:
						num2 = (short)2139553792;
						if (num2 != 0)
						{
						}
						num2 = (short)1782972426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 30:
					num2 = (short)1026555921;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (A_0.AccessLevelType == global::AcpASKLib.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
					{
						num2 = (short)1505493004;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 32:
					if (!this.radSecData.IsConventionalOnly)
					{
						num2 = (short)1260716078;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_448;
				case 33:
					if (this.WriteType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
					{
						num2 = (short)814874660;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 34:
					if (this.cpgSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)141426715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 35:
					if (A_0 != null)
					{
						num2 = (short)1765146669;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 36:
					num2 = (short)290521110;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					if (A_0.AccessLevelType != global::AcpASKLib.KeyAccessLevelType.UNLM_ACC)
					{
						num2 = (short)862715913;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1879703572;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 38:
					return result;
				case 39:
					if (A_0.AccessLevelType != global::AcpASKLib.KeyAccessLevelType.UNLM_ACC)
					{
						num2 = (short)1977024518;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5C2;
				case 40:
					if (this.WriteType != global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE)
					{
						num2 = (short)1273298955;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 41:
					num2 = (short)557187104;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 42:
					num2 = (short)1145241637;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					if (this.cpgSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)1702887426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 44:
					if (this.WriteType != global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE)
					{
						num2 = (short)1104347139;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 45:
					num2 = (short)560332840;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					result = true;
					num2 = (short)603914278;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 47:
					num2 = (short)1310654464;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 48:
					num2 = (short)1371471886;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_D4;
				IL_17F:
				num2 = (short)582680594;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_361:
				result = flag;
				num2 = (short)1209991189;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3D8:
				if (this.radSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED)
				{
					num2 = (short)2045509673;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_448:
				num2 = (short)1793916956;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5C2:
				num2 = (short)1451950114;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_D4:
			result = false;
			num2 = (short)1332084751;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0007F2DC File Offset: 0x0007D4DC
		private bool c(global::AcpASKLib.SystemKeyData A_0, out string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1898250242;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
				{
					if (this.WriteType != global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_CLONE)
					{
						result = this.b(A_0, out A_1);
						num2 = (short)2228227;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1328740924;
					short num3 = num2;
					num2 = (short)1911224892;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6D;
					default:
					{
						num2 = (short)1652752384;
						if (num2 != 0)
						{
						}
						num2 = (short)1261174785;
						if (num2 != 0)
						{
						}
						num2 = (short)64356352;
						short num4 = num2;
						num2 = (short)357498886;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					return result;
				case 4:
					num2 = (short)1347420165;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (this.WriteType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
					{
						num2 = (short)1211498496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6D;
				case 6:
					goto IL_6D;
				case 7:
					if (this.WriteType != global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE)
					{
						num2 = (short)502398980;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6D;
				}
				goto IL_30;
				IL_6D:
				result = this.a(A_0, out A_1);
				num2 = (short)2079653889;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_30:
			result = false;
			A_1 = null;
			num2 = (short)585236487;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0007F4C0 File Offset: 0x0007D6C0
		private bool b(global::AcpASKLib.SystemKeyData A_0, out string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_B0;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				bool flag2;
				bool flag3;
				switch (num)
				{
				case 0:
					if (A_0 != null)
					{
						num2 = (short)543227922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19A;
				case 1:
					flag = true;
					this.a(A_0.iBtnSerialNum);
					num2 = (short)942735399;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)2098069541;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (this.radSecData.ASKRequired != this.cpgSecData.ASKRequired)
					{
						num2 = (short)603324439;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 4:
					num2 = (short)777191431;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)112721939;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1719992358;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (this.radSecData.ASKRequired == this.cpgSecData.ASKRequired)
					{
						num2 = (short)468713474;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3C4;
				case 8:
					num2 = (short)1797521436;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_4FB;
				case 10:
					flag = true;
					num2 = (short)335413261;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					num2 = (short)284075921;
					short num3 = num2;
					num2 = (short)283879313;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F2;
					default:
						num2 = (short)1279655936;
						if (num2 != 0)
						{
						}
						if (this.radSecData.ASKRequired)
						{
							num2 = (short)187105296;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_4FB;
					}
					break;
				}
				case 12:
					num2 = (short)203948065;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_4FB;
				case 14:
					if (A_0.AccessLevelType != global::AcpASKLib.KeyAccessLevelType.UNLM_ACC)
					{
						num2 = (short)1201340450;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1819410464;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					return flag;
				case 16:
					num2 = (short)48037917;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (!this.radSecData.ASKRequired)
					{
						num2 = (short)2883590;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_537;
				case 18:
					goto IL_1F2;
				case 19:
					if (!flag2)
					{
						num2 = (short)339083291;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 20:
					return flag;
				case 21:
					if (this.radSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)1411710977;
						if (num2 != 0)
						{
						}
						num2 = (short)727908360;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 22:
					if (!this.RestoreASKRequiredFlag(flag2))
					{
						num2 = (short)180879396;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 23:
					num2 = (short)1522204689;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					flag = true;
					num2 = (short)243728399;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (flag)
					{
						num2 = (short)1170669573;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 26:
					goto IL_19A;
				case 27:
					num2 = (short)1066467350;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					if (this.cpgSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)995098655;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 29:
					if (!this.cpgSecData.ASKRequired)
					{
						num2 = (short)1551761420;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4FB;
				case 30:
					if (this.radSecData.ProtectionOptn == this.cpgSecData.ProtectionOptn)
					{
						num2 = (short)1069613060;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3C4;
				case 31:
					num2 = (short)757596163;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					flag3 = true;
					goto IL_4DE;
				case 33:
					if (A_0 != null)
					{
						num2 = (short)1037697025;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_1 = global::CommonResources.AppResources.Advanced_System_key_of_the_Radio_Owner_System_ID_must_be_loaded_and_attached;
					num2 = (short)512294921;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					num2 = (short)1930756131;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					flag3 = (A_0.AccessLevelType == global::AcpASKLib.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP);
					goto IL_4DE;
				case 36:
					flag = false;
					A_1 = global::CommonResources.AppResources.Internal_Error;
					num2 = (short)1090846740;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					if (this.radSecData.IsConventionalOnly == this.cpgSecData.IsConventionalOnly)
					{
						num2 = (short)758382616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3C4;
				case 38:
					if (this.cpgSecData.ASKRequired)
					{
						num2 = (short)400031744;
						short num4 = num2;
						num2 = (short)1772879882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_537;
				case 39:
					goto IL_4FB;
				}
				goto IL_B0;
				IL_19A:
				num2 = (short)1134166041;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F2:
				num2 = (short)1696006158;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3C4:
				num2 = (short)834863125;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4DE:
				flag2 = flag3;
				num2 = (short)1441660954;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4FB:
				flag2 = false;
				num2 = (short)359727104;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_537:
				num2 = (short)1866530827;
				num = (int)((global::System.IntPtr)num2);
			}
			return flag;
			IL_B0:
			flag = false;
			A_1 = null;
			num2 = (short)1615069214;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0007FB68 File Offset: 0x0007DD68
		private bool a(global::AcpASKLib.SystemKeyData A_0, out string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_108;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				bool bUnLimitedOwnASKAttached;
				bool flag2;
				switch (num)
				{
				case 0:
					num2 = (short)595918859;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.radSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)1438711831;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_58E;
				case 2:
					if (this.cpgSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED)
					{
						num2 = (short)366346248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6DB;
				case 3:
					if (!this.radSecData.IsConventionalOnly)
					{
						num2 = (short)1708326927;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B5;
				case 4:
					goto IL_8CC;
				case 5:
					return flag;
				case 6:
					if (A_0.AccessLevelType != global::AcpASKLib.KeyAccessLevelType.UNLM_ACC)
					{
						num2 = (short)1189150755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)534642725;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (this.radSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)521404468;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8CC;
				case 8:
					num2 = (short)1796407328;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1557332021;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					flag = true;
					num2 = (short)1136328760;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (!this.cpgSecData.IsConventionalOnly)
					{
						num2 = (short)1542389805;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_548;
				case 12:
					num2 = (short)1826226231;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (this.cpgSecData.IsConventionalOnly)
					{
						num2 = (short)1388904458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_1 = global::CommonResources.AppResources.The_source_codeplug_must_use_Advanced_System_Key_only;
					num2 = (short)430506004;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)729088029;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)2112094241;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_1B5;
				case 17:
					if (this.radSecData.ASKRequired)
					{
						num2 = (short)318242873;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_58E;
				case 18:
					goto IL_1B5;
				case 19:
					goto IL_1B5;
				case 20:
					goto IL_1B5;
				case 21:
					goto IL_1B5;
				case 22:
					flag = true;
					num2 = (short)1011482678;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					num2 = (short)914030609;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					if (A_0 != null)
					{
						num2 = (short)92471356;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_1 = global::CommonResources.AppResources.Advanced_System_key_of_the_Radio_Owner_System_ID_must_be_loaded_and_attached;
					num2 = (short)1835728942;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					flag = true;
					num2 = (short)6815762;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					if (A_0 != null)
					{
						num2 = (short)160235560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_654;
				case 27:
					if (this.radSecData.ProtectionOptn != global::SpecialFeatures.Security.ProtectionOption.LEGACY_SW)
					{
						num2 = (short)2110193715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_805;
				case 28:
					if (!this.RestoreASKRequiredFlag(bUnLimitedOwnASKAttached))
					{
						num2 = (short)979042346;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 29:
					if (this.cpgSecData.ASKRequired)
					{
						num2 = (short)1861943318;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_503;
				case 30:
					if (this.radSecData.ASKRequired)
					{
						num2 = (short)1166737412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_805;
				case 31:
					goto IL_805;
				case 32:
					if (!this.cpgSecData.IsConventionalOnly)
					{
						num2 = (short)1431175207;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6DB;
				case 33:
					if (this.cpgSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED)
					{
						num2 = (short)308674560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_548;
				case 34:
					bUnLimitedOwnASKAttached = false;
					num2 = (short)1226440730;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					goto IL_338;
				case 36:
					goto IL_1B5;
				case 37:
					flag2 = true;
					goto IL_954;
				case 38:
					if (this.cpgSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.LEGACY_SW)
					{
						num2 = (short)81395724;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_276;
				case 39:
					flag = true;
					num2 = (short)632029205;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					num2 = (short)1516634113;
					if (num2 != 0)
					{
					}
					num2 = (short)2017001478;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					goto IL_1B5;
				case 42:
					flag = false;
					A_1 = global::CommonResources.AppResources.Internal_Error;
					num2 = (short)1456275461;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					num2 = (short)1531576323;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 44:
					flag = true;
					num2 = (short)1722417193;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 45:
					flag = true;
					num2 = (short)123404304;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					goto IL_1B5;
				case 47:
					if (this.cpgSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)1003552782;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_503;
				case 48:
					flag2 = (A_0.AccessLevelType == global::AcpASKLib.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP);
					goto IL_954;
				case 49:
					if (this.radSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED)
					{
						num2 = (short)755761195;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B5;
				case 50:
					if (this.radSecData.IsConventionalOnly)
					{
						num2 = (short)995819551;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1858142209;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 51:
					num2 = (short)1365966898;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 52:
					num2 = (short)1851457566;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 53:
					if (this.cpgSecData.ASKRequired)
					{
						num2 = (short)1958608921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_888;
				case 54:
					goto IL_1B5;
				case 55:
					if (!this.cpgSecData.IsConventionalOnly)
					{
						num2 = (short)1664221228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_276;
				case 56:
					goto IL_1B5;
				case 57:
					num2 = (short)874250298;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 58:
					if (this.cpgSecData.ProtectionOptn == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)1788084233;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_888;
				case 59:
					goto IL_654;
				case 60:
				{
					flag = true;
					this.a(A_0.iBtnSerialNum);
					num2 = (short)947828721;
					short num3 = num2;
					num2 = (short)1075623921;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_338;
					default:
						num2 = (short)1774190592;
						if (num2 != 0)
						{
						}
						num2 = (short)1777729572;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 61:
					if (flag)
					{
						num2 = (short)1001914402;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				}
				goto IL_108;
				IL_1B5:
				num2 = (short)1784283197;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_276:
				num2 = (short)595656751;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_338:
				num2 = (short)946274352;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_503:
				num2 = (short)1666187277;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_548:
				num2 = (short)885784614;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_58E:
				num2 = (short)1945632817;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_654:
				num2 = (short)375259164;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_6DB:
				num2 = (short)949026840;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_805:
				flag = true;
				num2 = (short)1993867264;
				short num4 = num2;
				num2 = (short)1516044307;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_888:
				num2 = (short)1817182210;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_8CC:
				num2 = (short)21430299;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_954:
				bUnLimitedOwnASKAttached = flag2;
				num2 = (short)1853620283;
				num = (int)((global::System.IntPtr)num2);
			}
			return flag;
			IL_108:
			flag = false;
			A_1 = null;
			num2 = (short)996802567;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00080528 File Offset: 0x0007E728
		internal static bool CheckIfTrkSystemsWithAskRequiredOnAreMissingUnlimitedKeys(global::SpecialFeatures.Security.RadioSecurityData radioSecurityData, global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> loadedAdvancedKeys)
		{
			short num = (short)610533376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::System.Collections.Generic.Dictionary<string, int> dictionary;
				global::System.Collections.Generic.Dictionary<string, int> dictionary2;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_F8;
					case 1:
						num = (short)1789788161;
						if (num != 0)
						{
						}
						if (!global::SpecialFeatures.Security.RadioAccessValidatorBase.AreNeededUnlimitedKeysMissing(loadedAdvancedKeys, ref radioSecurityData.IdAndNameOfTrkSysThatWillBeOverwritten, dictionary, radioSecurityData.RadioTrkSystemsWithAskRequiredOn))
						{
							num = (short)998506496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
					{
						num = (short)1676279808;
						short num3 = num;
						dictionary = new global::System.Collections.Generic.Dictionary<string, int>();
						dictionary2 = new global::System.Collections.Generic.Dictionary<string, int>();
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingSystemRecset.GetEnumerator();
						num = (short)856948740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (trunkingSystemRecset != null)
						{
							num = (short)1149698050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C;
					case 4:
						try
						{
							num = (short)843644931;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								int value;
								switch (num2)
								{
								case 0:
								{
									if (!trunkingSystem.General.TrkSysGeneralAskRequired_A44909Value)
									{
										dictionary.Add(trunkingSystem.General.TrkSysGeneralKeyofTrunkingSystem_A12658Value, value);
										num = (short)1207500808;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1314335732;
									short num4 = num;
									num = (short)1117531124;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_317;
									default:
										num = (short)2015690752;
										if (num != 0)
										{
										}
										num = (short)426508293;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									if (trunkingSystem.General.TrkSysGeneralCoverageType_A7782Value != 5)
									{
										num = (short)2059534342;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1B4;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)157024263;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
									num = (short)1174142977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_317;
								case 6:
									value = trunkingSystem.General.TrkSysGeneralSystemID_A9239.Value;
									num = (short)596508672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1648558089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_363;
								}
								IL_1E2:
								num = (short)1574109188;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B4:
								goto IL_1E2;
								IL_317:
								dictionary2.Add(trunkingSystem.General.TrkSysGeneralKeyofTrunkingSystem_A12658Value, value);
								num = (short)571539458;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_363:
							goto IL_8C;
						}
						finally
						{
							num = (short)241238017;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1302331394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_39B;
									}
									continue;
								case 2:
									goto IL_3D2;
								}
								IL_39B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1898577920;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3D2:;
						}
						return true;
					}
					goto IL_44;
					IL_8C:
					num = (short)1185087489;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F8:
				return global::SpecialFeatures.Security.RadioAccessValidatorBase.AreNeededUnlimitedKeysMissing(loadedAdvancedKeys, ref radioSecurityData.IdAndNameOfTrkSysThatWillBeOverwritten, dictionary2, radioSecurityData.RadioTrkSystemsWithAskRequiredOff);
				IL_44:
				dictionary = null;
				dictionary2 = null;
				trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
				num = (short)864485379;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00080928 File Offset: 0x0007EB28
		internal static bool AreNeededUnlimitedKeysMissing(global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> loadedAdvancedKeys, ref global::System.Collections.Generic.KeyValuePair<string, int> idAndNameOfTrkSysThatWillBeOverwritten, global::System.Collections.Generic.Dictionary<string, int> sysIdsAndNamesOfCodeplugTrkSystems, global::System.Collections.Generic.Dictionary<string, int> sysIdsAndNamesOfRadioTrkSystems)
		{
			short num = (short)2122383361;
			if (num != 0)
			{
			}
			num = (short)1096024064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_95;
				}
				global::SpecialFeatures.Security.RadioAccessValidatorBase.<>c__DisplayClass35_0 CS$<>8__locals1;
				for (;;)
				{
					IL_4E:
					int? num3;
					int? num4;
					int count;
					switch (num2)
					{
					case 0:
						num = (short)1257635841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (loadedAdvancedKeys == null)
						{
							num = (short)887750667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_303;
					case 2:
						num3 = new int?(loadedAdvancedKeys.Where(delegate(global::AcpASKLib.SystemKeyData x)
						{
							short num8 = (short)1941045250;
							int num9 = (int)((global::System.IntPtr)num8);
							for (;;)
							{
								switch (num9)
								{
								case 0:
								{
									num8 = (short)1429440945;
									short num10 = num8;
									num8 = (short)333482417;
									switch ((num10 == num8) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_128;
									case 1:
										break;
									default:
									{
										num8 = (short)1558052864;
										short num11 = num8;
										break;
									}
									}
									num8 = (short)656015361;
									if (num8 != 0)
									{
									}
									num8 = (short)1369309184;
									if (num8 != 0)
									{
									}
									num8 = (short)191561729;
									num9 = (int)((global::System.IntPtr)num8);
									continue;
								}
								case 1:
									goto IL_128;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_35;
									}
									continue;
								case 3:
									goto IL_147;
								}
								IL_35:
								if (CS$<>8__locals1.matches.Values.Contains(x.SystemID))
								{
									num8 = (short)2043805696;
									num9 = (int)((global::System.IntPtr)num8);
									continue;
								}
								return false;
								IL_128:
								if (x.Type != global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY)
								{
									return false;
								}
								num8 = (short)433192963;
								num9 = (int)((global::System.IntPtr)num8);
							}
							IL_147:
							return x.AccessLevel.GetKeyAccessLevelType() > global::AcpASKLib.KeyAccessLevelType.LIMITED_ACC;
						}).ToList<global::AcpASKLib.SystemKeyData>().Count);
						goto IL_367;
					case 3:
						if (num4.GetValueOrDefault() == count & num4 != null)
						{
							num = (short)967835663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)448200713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						int? num5;
						num3 = num5;
						goto IL_367;
					}
					case 5:
						if (sysIdsAndNamesOfCodeplugTrkSystems.Count <= 0)
						{
							num = (short)700776454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)998047754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return false;
					case 7:
						if (sysIdsAndNamesOfCodeplugTrkSystems != null)
						{
							num = (short)2073165838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						if (CS$<>8__locals1.matches != null)
						{
							num = (short)1082327053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						goto IL_3D6;
					case 10:
					{
						global::SpecialFeatures.Security.RadioAccessValidatorBase.<>c__DisplayClass35_0 CS$<>8__locals2 = CS$<>8__locals1;
						global::System.Collections.Generic.Dictionary<string, int> matches;
						if (sysIdsAndNamesOfRadioTrkSystems == null)
						{
							matches = null;
						}
						else
						{
							matches = sysIdsAndNamesOfRadioTrkSystems.Intersect(sysIdsAndNamesOfCodeplugTrkSystems).GroupBy(delegate(global::System.Collections.Generic.KeyValuePair<string, int> pair)
							{
								short num8 = (short)1194923820;
								short num9 = num8;
								num8 = (short)1086723884;
								switch (num9 == num8)
								{
								}
								num8 = (short)1944125441;
								if (num8 != 0)
								{
								}
								num8 = (short)1525874688;
								short num10 = num8;
								num8 = (short)441319424;
								if (num8 != 0)
								{
								}
								return pair.Value;
							}).Select(delegate(global::System.Linq.IGrouping<int, global::System.Collections.Generic.KeyValuePair<string, int>> group)
							{
								short num8 = (short)1207546622;
								short num9 = num8;
								num8 = (short)1816769278;
								switch (num9 == num8)
								{
								}
								num8 = (short)829751296;
								if (num8 != 0)
								{
								}
								num8 = (short)985137152;
								short num10 = num8;
								num8 = (short)400949249;
								if (num8 != 0)
								{
								}
								return group.First<global::System.Collections.Generic.KeyValuePair<string, int>>();
							}).ToDictionary(delegate(global::System.Collections.Generic.KeyValuePair<string, int> pair)
							{
								short num8 = (short)433900612;
								short num9 = num8;
								num8 = (short)825609284;
								switch (num9 == num8)
								{
								}
								num8 = (short)1865613313;
								if (num8 != 0)
								{
								}
								num8 = (short)1744896000;
								short num10 = num8;
								num8 = (short)1627193344;
								if (num8 != 0)
								{
								}
								return pair.Key;
							}, delegate(global::System.Collections.Generic.KeyValuePair<string, int> pair)
							{
								short num8 = (short)323030555;
								short num9 = num8;
								num8 = (short)427560475;
								switch (num9 == num8)
								{
								}
								num8 = (short)96600064;
								if (num8 != 0)
								{
								}
								num8 = (short)53346304;
								short num10 = num8;
								num8 = (short)1785266177;
								if (num8 != 0)
								{
								}
								return pair.Value;
							});
						}
						CS$<>8__locals2.matches = matches;
						num = (short)648216584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int? num5 = null;
						num = (short)407306244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (CS$<>8__locals1.matches.Count > 0)
						{
							num = (short)552009728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 13:
						num = (short)1244332044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)1856666453;
						short num6 = num;
						num = (short)1735818069;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_303;
						default:
							num = (short)152502272;
							if (num != 0)
							{
							}
							num = (short)310247429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
						return false;
					}
					goto IL_95;
					IL_303:
					num = (short)43319296;
					short num7 = num;
					num = (short)1180041218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_367:
					num4 = num3;
					count = CS$<>8__locals1.matches.Count;
					num = (short)1946484739;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_3D6:
				global::SpecialFeatures.Security.RadioAccessValidatorBase.<>c__DisplayClass35_0 CS$<>8__locals3 = CS$<>8__locals1;
				global::System.Collections.Generic.List<int> idsOfLoadedKeys;
				if (loadedAdvancedKeys == null)
				{
					idsOfLoadedKeys = null;
				}
				else
				{
					idsOfLoadedKeys = loadedAdvancedKeys.Where(delegate(global::AcpASKLib.SystemKeyData x)
					{
						if (x.Type == global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY)
						{
							short num8 = (short)1936841481;
							short num9 = num8;
							num8 = (short)882629385;
							switch ((num9 == num8) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num8 = (short)1197670401;
								if (num8 != 0)
								{
								}
								num8 = (short)826408960;
								short num10 = num8;
								num8 = (short)611713024;
								if (num8 != 0)
								{
								}
								break;
							}
							}
							return x.AccessLevel.GetKeyAccessLevelType() > global::AcpASKLib.KeyAccessLevelType.LIMITED_ACC;
						}
						return false;
					}).Select(delegate(global::AcpASKLib.SystemKeyData x)
					{
						short num8 = (short)1517136230;
						short num9 = num8;
						num8 = (short)631023974;
						switch (num9 == num8)
						{
						}
						num8 = (short)1974534145;
						if (num8 != 0)
						{
						}
						num8 = (short)1172766720;
						short num10 = num8;
						num8 = (short)1704460288;
						if (num8 != 0)
						{
						}
						return x.SystemID;
					}).ToList<int>();
				}
				CS$<>8__locals3.idsOfLoadedKeys = idsOfLoadedKeys;
				idAndNameOfTrkSysThatWillBeOverwritten = CS$<>8__locals1.matches.FirstOrDefault(delegate(global::System.Collections.Generic.KeyValuePair<string, int> x)
				{
					if (CS$<>8__locals1.idsOfLoadedKeys != null)
					{
						short num8 = (short)684783103;
						short num9 = num8;
						num8 = (short)415299071;
						switch ((num9 == num8) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num8 = (short)636485633;
							if (num8 != 0)
							{
							}
							num8 = (short)1476263936;
							short num10 = num8;
							num8 = (short)847314944;
							if (num8 != 0)
							{
							}
							break;
						}
						}
						return !CS$<>8__locals1.idsOfLoadedKeys.Contains(x.Value);
					}
					return false;
				});
				return true;
				IL_95:
				CS$<>8__locals1 = new global::SpecialFeatures.Security.RadioAccessValidatorBase.<>c__DisplayClass35_0();
				num = (short)765460487;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4E;
			}
			}
		}

		// Token: 0x04000304 RID: 772
		protected const int MAX_ASK_HISTORY_COUNT = 25;

		// Token: 0x04000305 RID: 773
		protected global::SpecialFeatures.Security.RadioSecurityData radSecData;

		// Token: 0x04000306 RID: 774
		protected global::SpecialFeatures.Security.RadioSecurityData cpgSecData;

		// Token: 0x04000307 RID: 775
		protected global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> cpSysIds;

		// Token: 0x04000308 RID: 776
		protected global::SpecialFeatures.Comms.COMMS_OP WriteType;

		// Token: 0x04000309 RID: 777
		protected bool WriteProtectWriteProtectedRadio;

		// Token: 0x0400030A RID: 778
		protected bool OtapBatchProgramming;

		// Token: 0x0400030B RID: 779
		protected global::System.Collections.ObjectModel.Collection<string> askSerialNumList;

		// Token: 0x0400030C RID: 780
		protected bool isFlashport;

		// Token: 0x0400030D RID: 781
		protected bool IsSkipWorkingCPParticularContentCheck;
	}
}
