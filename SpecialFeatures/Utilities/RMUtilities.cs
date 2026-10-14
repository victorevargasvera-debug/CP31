using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpCommonLib;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace SpecialFeatures.Utilities
{
	// Token: 0x0200003E RID: 62
	public static class RMUtilities
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x0006C114 File Offset: 0x0006A314
		public static string PopulateTrunkingGroupIDs(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles RefDataProfile)
		{
			short num = (short)1534722048;
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
				global::SpecialFeatures.Utilities.AstroDataProfTrunkingGroupgIDs astroDataProfTrunkingGroupgIDs;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset trunkingGroupIDListInnerRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (trunkingGroupIDListInnerRecset != null)
						{
							num = (short)1736376323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36A;
					case 1:
						if (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeTrunking(RefDataProfile.TrunkingGroupID))
						{
							num = (short)1861484550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36A;
					case 2:
					{
						num = (short)1846870016;
						short num3 = num;
						if (RefDataProfile != null)
						{
							num = (short)974716929;
							if (num != 0)
							{
							}
							num = (short)469696516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36A;
					}
					case 3:
						goto IL_2BC;
					case 4:
						num = (short)620429313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						try
						{
							num = (short)690094082;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::SpecialFeatures.Utilities.Astro25DataGroupID astro25DataGroupID = new global::SpecialFeatures.Utilities.Astro25DataGroupID();
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerSection trunkingGroupIDListInnerSection;
									astro25DataGroupID.DataGroupID = trunkingGroupIDListInnerSection.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204Value;
									astroDataProfTrunkingGroupgIDs.Recset.Add(astro25DataGroupID);
									num = (short)1457979393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_11F;
									}
									continue;
								case 3:
									goto IL_24C;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)441909253;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerSection trunkingGroupIDListInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10507] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerSection;
									num = (short)1152385030;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)435486723;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerSection trunkingGroupIDListInnerSection;
									if (trunkingGroupIDListInnerSection != null)
									{
										num = (short)267300084;
										short num4 = num;
										num = (short)128625908;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)258015232;
											if (num != 0)
											{
											}
											num = (short)1766653952;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								}
								IL_121:
								num = (short)243269636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11F:
								goto IL_121;
							}
							IL_24C:
							goto IL_36A;
						}
						finally
						{
							num = (short)71892993;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1753808898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_283;
									}
									continue;
								case 2:
									goto IL_2B9;
								}
								IL_283:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1201668096;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2B9:;
						}
						goto IL_2BC;
					case 6:
						trunkingGroupIDListInnerRecset = (RefDataProfile.TrunkingGroupID.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset);
						num = (short)558301184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C;
					IL_2BC:
					enumerator = trunkingGroupIDListInnerRecset.GetEnumerator();
					num = (short)423493637;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_36A:
				return astroDataProfTrunkingGroupgIDs.ToXML();
				IL_4C:
				astroDataProfTrunkingGroupgIDs = new global::SpecialFeatures.Utilities.AstroDataProfTrunkingGroupgIDs();
				num = (short)1895301122;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0006C4B0 File Offset: 0x0006A6B0
		public static void PopulateAstroCpsTrunkingGroupIDs(ref global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles RefDataProfile, string trunkingGroupIDXml)
		{
			short num = (short)367001600;
			switch (num)
			{
			default:
			{
				num = (short)469434373;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1F3;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset trunkingGroupIDListInnerRecset = RefDataProfile.TrunkingGroupID.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset;
						global::SpecialFeatures.Utilities.AstroDataProfTrunkingGroupgIDs astroDataProfTrunkingGroupgIDs = new global::SpecialFeatures.Utilities.AstroDataProfTrunkingGroupgIDs(trunkingGroupIDXml);
						num = (short)520355848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::SpecialFeatures.Utilities.AstroDataProfTrunkingGroupgIDs astroDataProfTrunkingGroupgIDs;
						if (astroDataProfTrunkingGroupgIDs.Recset.Count > 0)
						{
							num = (short)1823211524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
					{
						num = (short)2079391744;
						short num3 = num;
						num = (short)1229520898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset._Min = 0;
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset trunkingGroupIDListInnerRecset;
						trunkingGroupIDListInnerRecset.SetMax(8);
						trunkingGroupIDListInnerRecset.Clear();
						int num4 = 0;
						num = (short)1578631168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 6:
						return;
					case 7:
						goto IL_D1;
					case 8:
					{
						num = (short)755630081;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset trunkingGroupIDListInnerRecset;
						if (trunkingGroupIDListInnerRecset == null)
						{
							return;
						}
						num = (short)881326650;
						short num5 = num;
						num = (short)740817466;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D1;
						default:
							num = (short)1295974400;
							if (num != 0)
							{
							}
							num = (short)601358339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
					{
						global::SpecialFeatures.Utilities.AstroDataProfTrunkingGroupgIDs astroDataProfTrunkingGroupgIDs;
						int num4;
						if (num4 >= astroDataProfTrunkingGroupgIDs.Recset.Count)
						{
							num = (short)1059258374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset trunkingGroupIDListInnerRecset;
						trunkingGroupIDListInnerRecset.AddRecord(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner(trunkingGroupIDListInnerRecset)
						{
							TrunkingGroupIDListInnerSection = 
							{
								DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204Value = astroDataProfTrunkingGroupgIDs.Recset[num4].DataGroupID
							}
						});
						num4++;
						num = (short)1204617223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_6D:
					if (RefDataProfile != null)
					{
						num = (short)1086783489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1F3:
					num = (short)1148911625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D1:
					goto IL_1F3;
				}
				return;
			}
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0006C73C File Offset: 0x0006A93C
		public static string PopulateAstroSysKeyLog()
		{
			short num = (short)607322112;
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
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset radioInformationRecset;
				global::SpecialFeatures.Utilities.AstroASKProgrammingHistory astroASKProgrammingHistory;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset askprogrammingHistoryInnerRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (askprogrammingHistoryInnerRecset != null)
						{
							num = (short)504496131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_394;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						if (radioInformation != null)
						{
							num = (short)1276706822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_394;
					}
					case 2:
						if (radioInformationRecset != null)
						{
							num = (short)2035548161;
							if (num != 0)
							{
							}
							num = (short)2110128132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_394;
					case 3:
						goto IL_2B5;
					case 4:
					{
						num = (short)22478848;
						short num3 = num;
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = radioInformationRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						num = (short)1778581505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						try
						{
							num = (short)2038300674;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem askprogrammingHistoryItem = new global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem();
									global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerSection askprogrammingHistoryInnerSection;
									askprogrammingHistoryItem.LastProgramDateTime = askprogrammingHistoryInnerSection.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410Value;
									askprogrammingHistoryItem.SerialNumber = askprogrammingHistoryInnerSection.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411Value;
									astroASKProgrammingHistory.Recset.Add(askprogrammingHistoryItem);
									num = (short)1474035713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_103;
									}
									continue;
								case 3:
									goto IL_244;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1661009925;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerSection askprogrammingHistoryInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10113] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerSection;
									num = (short)14155782;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)539492355;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerSection askprogrammingHistoryInnerSection;
									if (askprogrammingHistoryInnerSection != null)
									{
										num = (short)21673917;
										short num4 = num;
										num = (short)604551101;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)20316160;
											if (num != 0)
											{
											}
											num = (short)1095368704;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								}
								IL_105:
								num = (short)827719684;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_103:
								goto IL_105;
							}
							IL_244:
							goto IL_394;
						}
						finally
						{
							num = (short)347340801;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1444216834;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_27B;
									}
									continue;
								case 2:
									goto IL_2B2;
								}
								IL_27B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1615659008;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2B2:;
						}
						goto IL_2B5;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						askprogrammingHistoryInnerRecset = (radioInformation.AdvancedSystemKeyInfo.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset);
						num = (short)34340864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_4C;
					IL_2B5:
					enumerator = askprogrammingHistoryInnerRecset.GetEnumerator();
					num = (short)345899013;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_394:
				return astroASKProgrammingHistory.ToXML();
				IL_4C:
				astroASKProgrammingHistory = new global::SpecialFeatures.Utilities.AstroASKProgrammingHistory();
				radioInformationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset);
				num = (short)1893269506;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0006CB00 File Offset: 0x0006AD00
		public static void PopulateAstroCpsASKProgrammingHistoryRecset(string astroSysKeyLogXml)
		{
			short num = (short)342818816;
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
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset radioInformationRecset;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset askprogrammingHistoryInnerRecset;
					switch (num2)
					{
					case 0:
						if (radioInformation != null)
						{
							num = (short)898564103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						global::System.Collections.Generic.SortedList<long, global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> sortedList;
						int num3;
						global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem askprogrammingHistoryItem = sortedList.Values[num3];
						askprogrammingHistoryInnerRecset.AddRecord(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner(askprogrammingHistoryInnerRecset)
						{
							ASKProgrammingHistoryInnerSection = 
							{
								RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411Value = askprogrammingHistoryItem.SerialNumber.ToUpper(),
								RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410Value = askprogrammingHistoryItem.LastProgramDateTime
							}
						});
						int num4;
						num4++;
						num3--;
						num = (short)442761228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)192020486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)381943810;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1695285251;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_31B;
									}
									continue;
								case 3:
									goto IL_42C;
								case 4:
								{
									global::System.Collections.Generic.SortedList<long, global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> sortedList;
									global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem askprogrammingHistoryItem2;
									if (!sortedList.ContainsKey(askprogrammingHistoryItem2.LastProgramDateTime))
									{
										num = (short)1595277317;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::System.Collections.Generic.SortedList<long, global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> sortedList;
									global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem askprogrammingHistoryItem2;
									sortedList.Add(askprogrammingHistoryItem2.LastProgramDateTime, askprogrammingHistoryItem2);
									num = (short)1148190721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> enumerator;
									if (enumerator.MoveNext())
									{
										global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem askprogrammingHistoryItem2 = enumerator.Current;
										num = (short)932446212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)710154110;
									short num5 = num;
									num = (short)1561532286;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1375338496;
										if (num != 0)
										{
										}
										num = (short)298909696;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_38C:
								num = (short)2133786630;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_31B:
								goto IL_38C;
							}
							IL_42C:
							goto IL_12A;
						}
						finally
						{
							num = (short)1270087681;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1872691202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_463;
									}
									continue;
								case 2:
									goto IL_49A;
								}
								IL_463:
								if (enumerator == null)
								{
									break;
								}
								num = (short)200540160;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_49A:;
						}
						goto IL_49D;
						IL_12A:
						num = (short)1595277326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						int num3;
						if (num3 < 0)
						{
							num = (short)1622540298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1258356744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (radioInformationRecset != null)
						{
							num = (short)1916862477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
					{
						global::SpecialFeatures.Utilities.AstroASKProgrammingHistory astroASKProgrammingHistory;
						if (astroASKProgrammingHistory.Recset.Count > 0)
						{
							num = (short)1536360464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
					{
						askprogrammingHistoryInnerRecset = (radioInformation.AdvancedSystemKeyInfo.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset);
						global::SpecialFeatures.Utilities.AstroASKProgrammingHistory astroASKProgrammingHistory = new global::SpecialFeatures.Utilities.AstroASKProgrammingHistory(astroSysKeyLogXml);
						num = (short)1255604233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						int num4;
						if (num4 < 25)
						{
							num = (short)682360833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AE;
					}
					case 9:
						if (askprogrammingHistoryInnerRecset != null)
						{
							num = (short)2115960834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						num = (short)430899201;
						if (num != 0)
						{
						}
						goto IL_2AE;
					case 11:
						return;
					case 12:
						goto IL_1B3;
					case 13:
						goto IL_49D;
					case 14:
					{
						global::System.Collections.Generic.SortedList<long, global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> sortedList;
						if (sortedList.Count > 0)
						{
							num = (short)1049690127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AE;
					}
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._Min = 0;
						askprogrammingHistoryInnerRecset.SetMax(25);
						askprogrammingHistoryInnerRecset.Clear();
						int num4 = 0;
						global::System.Collections.Generic.SortedList<long, global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> sortedList;
						int num3 = sortedList.Count - 1;
						num = (short)891420689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::System.Collections.Generic.SortedList<long, global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> sortedList = new global::System.Collections.Generic.SortedList<long, global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem>();
						global::SpecialFeatures.Utilities.AstroASKProgrammingHistory astroASKProgrammingHistory;
						global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> enumerator = astroASKProgrammingHistory.Recset.GetEnumerator();
						num = (short)1200226307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_1B3;
					}
					goto IL_76;
					IL_1B3:
					num = (short)35258372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AE:
					askprogrammingHistoryInnerRecset.SetMax(askprogrammingHistoryInnerRecset.Count);
					num = (short)1025310731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49D:
					radioInformation = (radioInformationRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)280297472;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_76:
				radioInformationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset);
				num = (short)171442176;
				short num6 = num;
				num = (short)871563269;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
