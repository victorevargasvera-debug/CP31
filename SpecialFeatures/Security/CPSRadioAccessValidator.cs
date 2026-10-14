using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using AcpASKLib;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpSecurityLib;
using AcpUtility;
using CommonResources;
using Motorola.Acp.PackUnpack.Ish;
using Motorola.Acp.PackUnpack.Ish.Layouts;
using Motorola.Common.Communication.CommonUtil;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;

namespace SpecialFeatures.Security
{
	// Token: 0x02000052 RID: 82
	public class CPSRadioAccessValidator : global::SpecialFeatures.Security.RadioAccessValidatorBase
	{
		// Token: 0x06000817 RID: 2071 RVA: 0x000028DD File Offset: 0x00000ADD
		public CPSRadioAccessValidator(global::SpecialFeatures.Comms.COMMS_OP WriteType, global::SpecialFeatures.Security.RadioSecurityData radSecData, global::SpecialFeatures.Security.RadioSecurityData cpgSecData, global::Motorola.Common.Communication.CommonUtil.IshItemCollection progHistoryItems, global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysBandPlan> radioTrkShuffledBandPlans, bool writeProtectWriteProtectedRadio = false, bool otapBatchProgramming = false, bool updateWriteProtect = false) : base(WriteType, radSecData, cpgSecData, writeProtectWriteProtectedRadio, otapBatchProgramming, false, false)
		{
			this.a = progHistoryItems;
			this.b = radioTrkShuffledBandPlans;
			this.c = updateWriteProtect;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00084984 File Offset: 0x00082B84
		protected override void RestoreRadioWideSecurityData()
		{
			short num = (short)2104098816;
			short num2 = num;
			num = (short)2099827087;
			short num3 = num;
			num = (short)1889063311;
			switch (num3 == num)
			{
			}
			num = (short)60686337;
			if (num != 0)
			{
			}
			num = (short)960495616;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)global::AcpCommonLib.FeatureManager.GetFeature(2045)[0];
			radioWide.Depot.AdvancedExternalMicOnly.SetValue(this.radSecData.WriteProtected);
			radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.SetValue(this.radSecData.OwnerAdvancedKeyType);
			radioWide.General.RadWideGeneralOwnerWACNID_A38656.SetValue(this.radSecData.OwnerWACNID);
			radioWide.General.RadWideGeneralOwnerSystemID_A37153.SetValue(this.radSecData.OwnerSystemID);
			radioWide.General.RadWideGeneralASKRequired_A37152.SetValue(this.radSecData.ASKRequired);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00084ACC File Offset: 0x00082CCC
		protected override void RestoreOwnerSystemData()
		{
			short num = (short)1922891776;
			short num2 = num;
			num = (short)1928969433;
			short num3 = num;
			num = (short)1579597017;
			switch (num3 == num)
			{
			}
			num = (short)1364459521;
			if (num != 0)
			{
			}
			num = (short)1217527808;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)global::AcpCommonLib.FeatureManager.GetFeature(2045)[0];
			radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.SetValue(this.radSecData.OwnerAdvancedKeyType);
			radioWide.General.RadWideGeneralOwnerSystemID_A37153.SetValue(this.radSecData.OwnerSystemID);
			radioWide.General.RadWideGeneralOwnerWACNID_A38656.SetValue(this.radSecData.OwnerWACNID);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00084BD8 File Offset: 0x00082DD8
		protected override bool RestoreASKRequiredFlag(bool bUnLimitedOwnASKAttached)
		{
			switch (0)
			{
			case 0:
				goto IL_42;
			}
			short num;
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)1451556865;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (radioWide != null)
					{
						num = (short)87162882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					return result;
				case 2:
				{
					radioWide.General.RadWideGeneralASKRequired_A37152.SetValue(this.radSecData.ASKRequired);
					result = true;
					num = (short)1207108374;
					short num3 = num;
					num = (short)1591345942;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)854458368;
						if (num != 0)
						{
						}
						num = (short)33816577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_42;
			}
			return result;
			IL_42:
			num = (short)770899968;
			short num4 = num;
			result = false;
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num = (short)227213312;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00084D24 File Offset: 0x00082F24
		protected override void RestoreWriteProtect()
		{
			short num = (short)1331757056;
			short num2 = num;
			num = (short)1308404086;
			short num3 = num;
			num = (short)1291561334;
			switch (num3 == num)
			{
			}
			num = (short)1718943744;
			if (num != 0)
			{
			}
			num = (short)765394945;
			if (num != 0)
			{
			}
			((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)global::AcpCommonLib.FeatureManager.GetFeature(2045)[0]).Depot.AdvancedExternalMicOnly.SetValue(this.radSecData.WriteProtected);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00084DFC File Offset: 0x00082FFC
		protected override bool HandleWriteProtect(out string stsMsg)
		{
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			short num;
			int num3;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				num = (short)1051459584;
				short num2 = num;
				switch (num3)
				{
				case 0:
					return result;
				case 1:
					return result;
				case 2:
					if (this.WriteProtectWriteProtectedRadio)
					{
						num = (short)48300041;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					stsMsg = global::CommonResources.AppResources.Write_Radio_Operation_Aborted_WP_Canceled_by_Batch;
					num = (short)50593793;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					radioWide.Depot.AdvancedExternalMicOnly.SetValue(true);
					result = true;
					goto IL_288;
				case 4:
					if (!this.c)
					{
						num = (short)711917569;
						if (num != 0)
						{
						}
						num = (short)270139402;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C2;
				case 5:
					num = (short)1031864324;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return result;
				case 7:
					if (!this.OtapBatchProgramming)
					{
						num = (short)1292107781;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C2;
				case 8:
					return result;
				case 9:
				{
					radioWide.Depot.AdvancedExternalMicOnly.SetValue(true);
					result = true;
					num = (short)896722924;
					short num4 = num;
					num = (short)117696492;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_288;
					default:
						num = (short)77332480;
						if (num != 0)
						{
						}
						num = (short)1816002566;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					num = (short)616300555;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Warning_You_are_about_to_write_protect_the_attached_radio, global::CommonResources.AppResources.Radio_Write_Protect_Warning, global::System.Windows.MessageBoxButton.OKCancel, global::System.Windows.MessageBoxImage.Exclamation) == global::System.Windows.MessageBoxResult.OK)
					{
						num = (short)1127088131;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					stsMsg = global::CommonResources.AppResources.Write_Radio_Operation_Aborted_WP_Canceled_by_User;
					num = (short)1240662016;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6A;
				IL_C2:
				num = (short)1412825090;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_288:
				num = (short)1113653256;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_6A:
			result = false;
			stsMsg = null;
			radioWide = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)global::AcpCommonLib.FeatureManager.GetFeature(2045)[0];
			num = (short)1021313031;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000850AC File Offset: 0x000832AC
		protected override bool IsCpgOwnerIDValid(out string statusMsg)
		{
			short num = (short)1733885952;
			short num2 = num;
			num = (short)667156481;
			if (num != 0)
			{
			}
			num = (short)1242728218;
			short num3 = num;
			num = (short)1339983642;
			switch (num3 == num)
			{
			}
			num = (short)177799168;
			if (num != 0)
			{
			}
			return global::SpecialFeatures.Security.RadioAccessValidator.IsCpgOwnerSystemIDValid(out statusMsg);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0008515C File Offset: 0x0008335C
		protected override global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> GetCodeplugTrkSystemIDs()
		{
			short num = (short)976224256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)372047873;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_65;
				}
				global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection;
				for (;;)
				{
					IL_4E:
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_399;
					case 1:
						if (trunkingSystemRecset != null)
						{
							num = (short)1049886720;
							short num3 = num;
							num = (short)1812922371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 2:
						try
						{
							num = (short)1822162948;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpASKLib.KeyType sysKeyType;
								int sysId;
								bool? askRequired;
								string systemName;
								switch (num2)
								{
								case 0:
									num = (short)1544290306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1CB;
								case 2:
									goto IL_2DD;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									if (trunkingSystem.General.TrkSysGeneralCoverageType_A7782Value == 5)
									{
										num = (short)1315897350;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									sysKeyType = global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
									sysId = trunkingSystem.General.TrkSysGeneralSystemID_A9239.Value;
									askRequired = new bool?(trunkingSystem.General.TrkSysGeneralAskRequired_A44909Value);
									systemName = trunkingSystem.General.TrkSysGeneralKeyofTrunkingSystem_A12658Value;
									num = (short)292356097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_176;
									}
									continue;
								case 6:
								{
									sysKeyType = global::AcpASKLib.KeyType.ADVANCED_WACN_KEY;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									sysId = trunkingSystem.General.TrkSysGeneralHomeWACNID_A8205Value;
									askRequired = null;
									num = (short)1125908487;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_1CB;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)702545920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
									systemName = null;
									num = (short)1519779843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_176;
								IL_1CB:
								global::SpecialFeatures.Security.TrkSysID item = new global::SpecialFeatures.Security.TrkSysID(sysKeyType, sysId, askRequired, systemName);
								collection.Add(item);
								num = (short)571473925;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FD:
								num = (short)341835784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_176:
								goto IL_1FD;
							}
							IL_2DD:
							goto IL_37A;
						}
						finally
						{
							num = (short)2009792512;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_314;
									}
									continue;
								case 1:
									goto IL_34C;
								case 2:
									enumerator.Dispose();
									num = (short)992935937;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_314:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1161297922;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_34C:;
						}
						goto IL_34F;
						IL_37A:
						this.SetUnlimitedAskRequiredFlagForSystemsWithAskReqModified(collection);
						num = (short)1086586880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_34F;
					}
					goto IL_65;
					IL_34F:
					collection = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID>();
					enumerator = trunkingSystemRecset.GetEnumerator();
					num = (short)1106051074;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_399:
				return collection;
				IL_65:
				num = (short)1041319954;
				short num4 = num;
				num = (short)1228490770;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return collection;
				default:
				{
					num = (short)1202323456;
					if (num != 0)
					{
					}
					collection = null;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset;
					num = (short)103415809;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_4E;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00085524 File Offset: 0x00083724
		internal void SetUnlimitedAskRequiredFlagForSystemsWithAskReqModified(global::System.Collections.Generic.ICollection<global::SpecialFeatures.Security.TrkSysID> trkSystems)
		{
			short num = (short)190382080;
			short num2 = num;
			num = (short)1990391665;
			short num3 = num;
			num = (short)696645489;
			switch (num3 == num)
			{
			}
			num = (short)619905025;
			if (num != 0)
			{
			}
			num = (short)204144640;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Security.RadioSecurityData radSecData = this.radSecData;
			this.SetUnlimitedAskRequiredFlag((radSecData != null) ? radSecData.RadioTrkSystemsWithAskRequiredOn : null, false, trkSystems);
			global::SpecialFeatures.Security.RadioSecurityData radSecData2 = this.radSecData;
			this.SetUnlimitedAskRequiredFlag((radSecData2 != null) ? radSecData2.RadioTrkSystemsWithAskRequiredOff : null, true, trkSystems);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0008560C File Offset: 0x0008380C
		internal void SetUnlimitedAskRequiredFlag(global::System.Collections.Generic.Dictionary<string, int> trkSystemsOnRadioWithOldAskReqValue, bool newAskRequiredValue, global::System.Collections.Generic.ICollection<global::SpecialFeatures.Security.TrkSysID> trkSystemsToBeWritten)
		{
			short num = (short)2101280768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)441974784;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_85;
				}
				for (;;)
				{
					IL_52:
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_204;
					case 1:
						num = (short)1695219713;
						if (num != 0)
						{
						}
						num = (short)737148931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_163;
					case 3:
					{
						if (!trkSystemsOnRadioWithOldAskReqValue.Any<global::System.Collections.Generic.KeyValuePair<string, int>>())
						{
							num = (short)336527360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Security.TrkSysID[] array = trkSystemsToBeWritten.Where(delegate(global::SpecialFeatures.Security.TrkSysID x)
						{
							while (x.AskRequired != null)
							{
								short num6 = (short)1779337793;
								short num7 = num6;
								num6 = (short)1749584449;
								switch ((num7 == num6) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								case 1:
									break;
								default:
								{
									num6 = (short)1206779904;
									short num8 = num6;
									break;
								}
								}
								num6 = (short)726990848;
								if (num6 != 0)
								{
								}
								num6 = (short)164560897;
								if (num6 != 0)
								{
								}
								return x.AskRequired.Value == newAskRequiredValue;
							}
							return false;
						}).ToArray<global::SpecialFeatures.Security.TrkSysID>();
						num4 = 0;
						goto IL_291;
					}
					case 4:
						return;
					case 5:
						goto IL_209;
					case 6:
						if (trkSystemsOnRadioWithOldAskReqValue != null)
						{
							num = (short)2003894273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						CS$<>8__locals2.trkSys.AskRequired = new bool?(CS$<>8__locals2.trkSys.UnlimitedAskRequired = true);
						num = (short)120848389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (trkSystemsOnRadioWithOldAskReqValue.Any(delegate(global::System.Collections.Generic.KeyValuePair<string, int> x)
						{
							while (x.Value == CS$<>8__locals2.trkSys.ID)
							{
								short num6 = (short)169345025;
								if (num6 != 0)
								{
								}
								num6 = (short)1373765632;
								short num7 = num6;
								num6 = (short)422119721;
								short num8 = num6;
								num6 = (short)748161321;
								switch ((num8 == num6) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num6 = (short)1357578240;
									if (num6 != 0)
									{
									}
									return x.Key == CS$<>8__locals2.trkSys.SystemName;
								}
							}
							return false;
						}))
						{
							num = (short)549781511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_209;
					case 9:
						goto IL_163;
					case 10:
					{
						global::SpecialFeatures.Security.TrkSysID[] array;
						if (num4 >= array.Length)
						{
							num = (short)1528692740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Security.TrkSysID trkSys = array[num4];
						num = (short)2067857416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_85;
					IL_163:
					num = (short)40828938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_209:
					num4++;
					num = (short)277176894;
					short num5 = num;
					num = (short)1936679486;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_291:
						num = (short)436207618;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1564344320;
						if (num != 0)
						{
						}
						num = (short)508887049;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return;
				IL_204:
				return;
				IL_85:
				num = (short)1778384902;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_52;
			}
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x000858CC File Offset: 0x00083ACC
		protected override void UpdateASKProgrammingHistory()
		{
			int a_ = 19;
			short num = (short)354877440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				int num6;
				int num7;
				int num11;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset askprogrammingHistoryInnerRecset;
				ushort num13;
				for (;;)
				{
					IL_32:
					int num3;
					int num4;
					global::System.Collections.Generic.SortedList<long, global::AcpBusinessLayer.FeatureNode> sortedList;
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					switch (num2)
					{
					case 0:
						if (num3 < 0)
						{
							num = (short)554237959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)749600769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num4 < 25)
						{
							num = (short)426573844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_786;
					case 2:
						goto IL_15E;
					case 3:
						sortedList.Remove(0L);
						num = (short)274923522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (sortedList.ContainsKey(0L))
						{
							num = (short)93650947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 5:
					{
						try
						{
							num = (short)1158086663;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.CommonUtil.IshHeader key;
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									int num5 = value.Data.Length - num6 - num7;
									num = (short)933101573;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_444;
										}
										int num9;
										global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader a_2;
										global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout a_3;
										for (;;)
										{
											IL_41D:
											switch (num2)
											{
											case 0:
												goto IL_508;
											case 1:
												goto IL_5A3;
											case 2:
											{
												long num8;
												if (!sortedList.ContainsKey(num8))
												{
													num = (short)1413873669;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_508;
											}
											case 3:
												goto IL_54F;
											case 4:
											{
												int num10;
												if (num9 >= num10)
												{
													num = (short)807206918;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												string radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411Value = this.a(a_2, a_3, num9 * num11);
												long num8 = this.a(a_2, 8 + num9 * num11);
												global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner askprogrammingHistoryInner = new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner(askprogrammingHistoryInnerRecset);
												askprogrammingHistoryInner.ASKProgrammingHistoryInnerSection.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411Value = radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411Value;
												askprogrammingHistoryInner.ASKProgrammingHistoryInnerSection.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410Value = num8;
												num = (short)1194262530;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												long num8;
												global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner askprogrammingHistoryInner;
												sortedList.Add(num8, askprogrammingHistoryInner);
												num = (short)171900928;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												num = (short)1317404673;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												goto IL_54F;
											}
											goto IL_444;
											IL_508:
											num9++;
											num = (short)238419975;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_54F:
											num = (short)8323076;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_5A3:
										break;
										IL_444:
										global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream input;
										a_2 = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader(input, true);
										a_3 = new global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕첗좙햛킝ﶡﺧﾫﾳﲽ閿雁郃觅蛇闉藋諍", a_), global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bch, 0, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Right, 16);
										num9 = 0;
										num = (short)1661599747;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_41D;
									}
									finally
									{
										num = (short)881328128;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream byteBufferStream;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_5DC;
												}
												continue;
											case 1:
												goto IL_615;
											case 2:
												((global::System.IDisposable)byteBufferStream).Dispose();
												num = (short)1571618817;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_5DC:
											if (byteBufferStream == null)
											{
												break;
											}
											num = (short)1343356930;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_615:;
									}
									goto IL_618;
								case 2:
								{
									int num5;
									int num10 = num5 / num11;
									byte[] array = new byte[num5];
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									global::System.Array.Copy(value.Data, 19, array, 0, num5);
									global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream input = null;
									global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream byteBufferStream;
									input = (byteBufferStream = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream(array));
									num = (short)1172242433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)69861384;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_3E9;
								case 5:
								{
									int num5;
									if (num5 % num11 == 0)
									{
										num = (short)168165378;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_618;
								}
								case 6:
									goto IL_632;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_237;
									}
									continue;
								case 8:
									goto IL_650;
								case 9:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									if (value.Data != null)
									{
										num = (short)328859648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									num = (short)1454571529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1022296067;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									key = keyValuePair.Key;
									num = (short)2135233149;
									short num12 = num;
									num = (short)1822823037;
									switch ((num12 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3E9;
									default:
										num = (short)2129068032;
										if (num != 0)
										{
										}
										num = (short)1605697540;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_2DB:
								num = (short)548470795;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3E9:
								if (key.IshType == num13)
								{
									num = (short)1912143882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_237:
								goto IL_2DB;
								IL_618:
								num = (short)1377894406;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_632:
							return;
							IL_650:
							goto IL_758;
						}
						finally
						{
							num = (short)2067922944;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_687;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1177092098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_6BF;
								}
								IL_687:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2095775745;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6BF:;
						}
						goto IL_6C2;
						IL_758:
						int num14 = 0;
						global::System.Collections.Generic.IEnumerator<string> enumerator2 = this.askSerialNumList.GetEnumerator();
						num = (short)1270415370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (this.a != null)
						{
							num = (short)215023630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						goto IL_786;
					case 8:
						num = (short)8781833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (radioInformation.AdvancedSystemKeyInfo != null)
						{
							num = (short)1682178069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						try
						{
							num = (short)1192820737;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int num14;
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<string> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1250689029;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = enumerator2.Current;
									global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner askprogrammingHistoryInner2 = new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner(askprogrammingHistoryInnerRecset);
									global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerSection askprogrammingHistoryInnerSection = askprogrammingHistoryInner2.ASKProgrammingHistoryInnerSection;
									askprogrammingHistoryInnerSection.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411Value = text.ToUpper();
									global::System.DateTime now = global::System.DateTime.Now;
									global::System.DateTime dateTime = new global::System.DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, now.Millisecond);
									long num15 = dateTime.ToUniversalTime().Ticks + (long)num14;
									askprogrammingHistoryInnerSection.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410Value = num15;
									num = (short)1513750534;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_8CF;
									}
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner askprogrammingHistoryInner2;
									long num15;
									sortedList.Add(num15, askprogrammingHistoryInner2);
									num = (short)1664155651;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_9FD;
								case 4:
									goto IL_A38;
								case 5:
									num = (short)1531969540;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									long num15;
									if (!sortedList.ContainsKey(num15))
									{
										num = (short)292290562;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9FD;
								}
								}
								IL_8F9:
								num = (short)339869696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8CF:
								goto IL_8F9;
								IL_9FD:
								num14++;
								num = (short)1768947719;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A38:
							goto IL_808;
						}
						finally
						{
							num = (short)46333952;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_A70;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)1687748610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_AAA;
								}
								IL_A70:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1922433025;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_AAA:;
						}
						goto IL_AAD;
						IL_808:
						num = (short)1198522386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1499136012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (askprogrammingHistoryInnerRecset != null)
						{
							num = (short)1091305495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C2;
					case 13:
						num = (short)4784132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_AAD;
					case 15:
						goto IL_6C2;
					case 16:
						if (askprogrammingHistoryInnerRecset != null)
						{
							num = (short)2017787926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						return;
					case 18:
					{
						int num14;
						if (num14 > 0)
						{
							num = (short)1662648333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					}
					case 19:
						if (sortedList.Count > 0)
						{
							num = (short)2011037707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 20:
					{
						num = (short)1585774592;
						short num16 = num;
						askprogrammingHistoryInnerRecset.AddRecord(sortedList.Values[num3]);
						num4++;
						num3--;
						num = (short)1743650841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						radioInformation.AdvancedSystemKeyInfo.EmbeddedRecset = askprogrammingHistoryInnerRecset;
						num = (short)1500708881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)227344390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						askprogrammingHistoryInnerRecset.Clear();
						num = (short)103677967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_1A1;
					case 25:
						num = (short)963641345;
						if (num != 0)
						{
						}
						goto IL_1A1;
					case 26:
						if (radioInformation != null)
						{
							num = (short)547160072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_A5;
					IL_15E:
					num = (short)416677907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A1:
					num = (short)396951552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C2:
					num4 = 0;
					num3 = sortedList.Count - 1;
					num = (short)1750007832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_786:
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)1915879450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AAD:
					sortedList = new global::System.Collections.Generic.SortedList<long, global::AcpBusinessLayer.FeatureNode>();
					askprogrammingHistoryInnerRecset.SetMax(25);
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._Min = 0;
					enumerator = this.a.GetEnumerator();
					num = (short)2078670853;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_A5:
				num13 = 1062;
				num11 = 16;
				num6 = 19;
				num7 = 2;
				askprogrammingHistoryInnerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset();
				num = (short)1391788048;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0008651C File Offset: 0x0008471C
		private string a(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout A_1, int A_2)
		{
			int a_ = 8;
			short num = (short)385810432;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				byte b;
				byte[] array;
				global::System.Text.StringBuilder stringBuilder;
				for (;;)
				{
					IL_30:
					int num3;
					char c;
					switch (num2)
					{
					case 0:
						goto IL_1B3;
					case 1:
					{
						if (num3 == 2)
						{
							num = (short)391577620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)357171200;
						short num4 = num;
						byte b2;
						b = (b2 & 15);
						num = (short)2073755658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (num3 <= 0)
						{
							num = (short)2096562187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1001193473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						int num5;
						num5++;
						num = (short)1382875158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_F5;
					case 5:
						goto IL_2A6;
					case 6:
						goto IL_34C;
					case 7:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1046020099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E7;
					}
					case 8:
						goto IL_2D0;
					case 9:
					{
						int num5;
						if (num5 >= A_1.Size)
						{
							num = (short)1713307654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b2 = array[num5];
						num3 = 2;
						num = (short)2078998546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						num = (short)1879061069;
						short num6 = num;
						num = (short)969880141;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_45E;
						default:
							num = (short)1757872128;
							if (num != 0)
							{
							}
							goto IL_43A;
						}
						break;
					}
					case 11:
						goto IL_1B3;
					case 12:
						if (A_1.Justification == global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Left)
						{
							num = (short)1680605201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 13:
					{
						if (array.Length != A_1.Size)
						{
							num = (short)2073165828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag = false;
						stringBuilder = new global::System.Text.StringBuilder(A_1.Size);
						int num5 = 0;
						num = (short)839188499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)929824783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (b > 9)
						{
							num = (short)770244613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A;
					case 16:
						if (c == A_1.Terminator)
						{
							num = (short)1347944469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 17:
						num = (short)795475984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1038680065;
						if (num != 0)
						{
						}
						goto IL_2D0;
					case 19:
						goto IL_30C;
					case 20:
					{
						byte b2;
						b = (byte)(b2 >> 4 & 15);
						num = (short)790036503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						bool flag = true;
						num = (short)13434880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_30C;
					case 23:
						goto IL_43A;
					case 24:
						if (A_1.Encoding == global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bcd)
						{
							goto IL_45E;
						}
						goto IL_11A;
					}
					goto IL_9B;
					IL_11A:
					c = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뮊벌붎ꊐꞒꂔꆖ꺘ꎚ꒜\ude9e", a_)[(int)b];
					num = (short)366608396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B3:
					num = (short)459407367;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21E:
					stringBuilder.Append(c);
					num3--;
					num = (short)1372454920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D0:
					num = (short)2116681730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30C:
					num = (short)662896649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43A:
					num = (short)1704394776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45E:
					num = (short)1164247054;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F5:
				throw new global::System.IO.IOException();
				IL_2A6:
				throw new global::System.IO.InvalidDataException(global::CommonResources.AppResources.Invalid_BCD_character_for_field.AcpStringFormat(new object[]
				{
					b,
					A_1.Name
				}));
				IL_34C:
				IL_4E7:
				return stringBuilder.ToString();
				IL_9B:
				A_0.BaseStream.Position = (long)A_2;
				array = A_0.ReadBytes(A_1.Size);
				num = (short)1922498573;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00086A18 File Offset: 0x00084C18
		private long a(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader A_0, int A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (A_0.BigEndian)
					{
						num2 = (short)1622999041;
						if (num2 != 0)
						{
						}
						num2 = (short)888537089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_129;
				case 1:
					goto IL_105;
				case 2:
					goto IL_127;
				}
				goto IL_1C;
			}
			IL_105:
			byte[] array;
			global::System.Array.Reverse(array, 0, 8);
			goto IL_10F;
			IL_127:
			IL_129:
			uint num3 = (uint)((int)array[0] | (int)array[1] << 8 | (int)array[2] << 16 | (int)array[3] << 24);
			return (long)((ulong)((int)array[4] | (int)array[5] << 8 | (int)array[6] << 16 | (int)array[7] << 24) << 32 | (ulong)num3);
			IL_1C:
			num2 = (short)501940224;
			short num4 = num2;
			A_0.BaseStream.Position = (long)A_1;
			array = A_0.ReadBytes(8);
			num2 = (short)1995097919;
			short num5 = num2;
			num2 = (short)1219872575;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_10F:
				num2 = (short)138215426;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1037762560;
				if (num2 != 0)
				{
				}
				num2 = (short)1237385216;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00086B84 File Offset: 0x00084D84
		protected override void UpdateTrkSysShuffledBandPlans()
		{
			short num = (short)1701249024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
				for (;;)
				{
					IL_27:
					bool flag;
					switch (num2)
					{
					case 0:
						if (trunkingSystemRecset != null)
						{
							num = (short)689963010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43D;
					case 1:
						if (this.b != null)
						{
							num = (short)167968772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43D;
					case 2:
						num = (short)864747521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)86769664;
						short num3 = num;
						try
						{
							flag = global::AcpCommonLib.ConstraintManager.Suspend();
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingSystemRecset.GetEnumerator();
							try
							{
								num = (short)359464961;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2BC;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_F0;
										}
										continue;
									case 2:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
										trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128.SetValue(true);
										num = (short)1635450883;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
										trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128.SetValue(true);
										num = (short)1760100358;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1297809416;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
										num = (short)1473511433;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										int trkSysGeneralSystemID_A9239Value;
										if (global::AcpSecurityLib.SecurityManager.IsSystemKeyLoaded(trkSysGeneralSystemID_A9239Value, 0, true))
										{
											num = (short)592838660;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
										trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128.SetValue(false);
										num = (short)1678508043;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										num = (short)591069184;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
										if (trunkingSystem.General.TrkSysGeneralSystemType_A9252Value == 2)
										{
											num = (short)273743884;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
									{
										int trkSysGeneralSystemID_A9239Value;
										if (this.a(2, trkSysGeneralSystemID_A9239Value, this.b))
										{
											num = (short)1298857986;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1678966791;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
										int trkSysGeneralSystemID_A9239Value = trunkingSystem.General.TrkSysGeneralSystemID_A9239Value;
										num = (short)343080970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_F2:
									num = (short)1862008837;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_F0:
									goto IL_F2;
								}
								IL_2BC:;
							}
							finally
							{
								num = (short)929628160;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_2F1;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1692991490;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_326;
									}
									IL_2F1:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1154809857;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_326:;
							}
							goto IL_43D;
						}
						catch (global::System.Exception ex)
						{
							throw new global::System.Exception(global::CommonResources.AppResources.Error_updating_Shuffled_Band_Plan + ex.Message);
						}
						finally
						{
							num = (short)1790967808;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_37A;
									}
									continue;
								case 1:
									global::AcpCommonLib.ConstraintManager.Resume();
									num = (short)1541144578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3B0;
								}
								IL_37A:
								if (!flag)
								{
									break;
								}
								num = (short)705232897;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3B0:;
						}
						goto IL_3B3;
					}
					case 4:
						goto IL_3B3;
					}
					goto IL_42;
					IL_3B5:
					num = (short)1545732099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43D:
					num = (short)728682766;
					short num4 = num;
					num = (short)1556795662;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B5;
					default:
						goto IL_474;
					}
					IL_3B3:
					flag = false;
					goto IL_3B5;
				}
				IL_474:
				num = (short)395444225;
				if (num != 0)
				{
				}
				num = (short)1251999744;
				if (num != 0)
				{
				}
				return;
				IL_42:
				trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
				num = (short)879034368;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00087090 File Offset: 0x00085290
		private bool a(int A_0, int A_1, global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysBandPlan> A_2)
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
				global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.TrkSysBandPlan> enumerator;
				switch (num)
				{
				case 0:
					IL_5A:
					if (A_2 != null)
					{
						num2 = (short)1715077121;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2AE;
				case 1:
					goto IL_260;
				case 2:
					try
					{
						num2 = (short)15859720;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_1F1;
							case 1:
								num2 = (short)778108934;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								num2 = (short)1924071424;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								goto IL_15C;
							case 4:
							{
								global::SpecialFeatures.Security.TrkSysBandPlan trkSysBandPlan;
								if (trkSysBandPlan.ShuffledBandPlan)
								{
									num2 = (short)44171274;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 5:
							{
								global::SpecialFeatures.Security.TrkSysBandPlan trkSysBandPlan;
								if (trkSysBandPlan.SystemType == A_0)
								{
									num2 = (short)1955201025;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 6:
							{
								global::SpecialFeatures.Security.TrkSysBandPlan trkSysBandPlan;
								if (trkSysBandPlan.SystemId == A_1)
								{
									num2 = (short)899612681;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 7:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)914358274;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::SpecialFeatures.Security.TrkSysBandPlan trkSysBandPlan = enumerator.Current;
								num2 = (short)1661206533;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 8:
								switch (0)
								{
								case 0:
									goto IL_CB;
								}
								continue;
							case 9:
								num2 = (short)2048589828;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 10:
								result = true;
								num2 = (short)385548291;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_CD:
							num2 = (short)1297547271;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_CB:
							goto IL_CD;
						}
						IL_15C:
						IL_1F1:
						goto IL_2AE;
					}
					finally
					{
						num2 = (short)981270528;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_227;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num2 = (short)421396482;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_25D;
							}
							IL_227:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1028325377;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_25D:;
					}
					goto IL_260;
				}
				goto IL_1C;
				IL_260:
				num2 = (short)1682046976;
				short num3 = num2;
				enumerator = A_2.GetEnumerator();
				num2 = (short)869597186;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2AE:
				num2 = (short)1945343795;
				short num4 = num2;
				num2 = (short)1190041395;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5A;
				default:
					goto IL_2E5;
				}
			}
			IL_2E5:
			num2 = (short)1715994624;
			if (num2 != 0)
			{
			}
			return result;
			IL_1C:
			num2 = (short)47513601;
			if (num2 != 0)
			{
			}
			result = false;
			num2 = (short)2056323072;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400031E RID: 798
		private global::Motorola.Common.Communication.CommonUtil.IshItemCollection a;

		// Token: 0x0400031F RID: 799
		private global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysBandPlan> b;

		// Token: 0x04000320 RID: 800
		private bool c;
	}
}
