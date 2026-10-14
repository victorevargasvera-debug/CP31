using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpCommonLib;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList
{
	// Token: 0x020005DF RID: 1503
	public static class ASTROTalkgroupListConstraints
	{
		// Token: 0x0600CF45 RID: 53061 RVA: 0x00C0E490 File Offset: 0x00C0C690
		internal static bool ConSecKmfProfileEnAstroOtarOtarEmcEqpdExtIsEnableAndCfgSecTypeIsHW(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)884342784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_86;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.General general;
				global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
				bool flag2;
				for (;;)
				{
					IL_27:
					bool flag;
					global::AcpBusinessLayer.AcpRecRefField astTlkgrpLstGeneralKMFProfileIndex_A;
					global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupList talkgroupList;
					switch (num2)
					{
					case 0:
						num = (short)726990851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_38D;
					case 2:
						flag = general.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value;
						goto IL_392;
					case 3:
						if (general.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
						{
							num = (short)998572042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_172;
					case 4:
						if (astTlkgrpLstGeneralKMFProfileIndex_A.ReferencedNode != null)
						{
							num = (short)1441267729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_357;
					case 5:
					{
						num = (short)770637824;
						short num3 = num;
						if (secWideGeneralSecureOperation_A.Value != 1)
						{
							num = (short)1213988884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)868548627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						if (!general.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
						{
							goto IL_172;
						}
						num = (short)486916044;
						short num4 = num;
						num = (short)151699404;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38D;
						default:
							num = (short)33423360;
							if (num != 0)
							{
							}
							num = (short)913506304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						num = (short)789053444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						return flag2;
					case 9:
						return flag2;
					case 10:
						num = (short)1589968901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (secWideGeneralSecureOperation_A.Value == 3)
						{
							num = (short)933560335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1560412172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						flag = false;
						goto IL_392;
					case 13:
						if (astTlkgrpLstGeneralKMFProfileIndex_A != null)
						{
							num = (short)576192519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_357;
					case 14:
						num = (short)89522177;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListConstraints.a(talkgroupList, null, flag2);
						num = (short)1616183305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1279655938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (astTlkgrpLstGeneralKMFProfileIndex_A.Value == 0)
						{
							num = (short)1785266190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile a_ = general.AstTlkgrpLstGeneralKMFProfileIndex_A8380.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListConstraints.a(talkgroupList, a_, flag2);
						num = (short)595787784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						flag = false;
						goto IL_392;
					case 19:
						flag = true;
						goto IL_392;
					case 20:
						num = (short)2069233675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (astTlkgrpLstGeneralKMFProfileIndex_A != null)
						{
							num = (short)227475457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					goto IL_86;
					IL_172:
					num = (short)114950162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_357:
					num = (short)1460011029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38D:
					num = (short)969146384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_392:
					flag2 = flag;
					astTlkgrpLstGeneralKMFProfileIndex_A = general.AstTlkgrpLstGeneralKMFProfileIndex_A8380;
					talkgroupList = (general.Parent as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList).TalkgroupList;
					num = (short)1498808333;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag2;
				IL_86:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.General);
				secWideGeneralSecureOperation_A = general.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
				num = (short)1885667334;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600CF46 RID: 53062 RVA: 0x00C0E8F4 File Offset: 0x00C0CAF4
		private static void a(global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupList A_0, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile A_1, bool A_2)
		{
			short num = (short)1252851712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				global::AcpCommonLib.IAcpRecordset recset;
				for (;;)
				{
					IL_28:
					global::AcpCommonLib.IAcpRecordset embeddedRecset;
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide refSecureWide;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general;
					switch (num2)
					{
					case 0:
						num = (short)1406009345;
						if (num != 0)
						{
						}
						embeddedRecset = A_1.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset;
						goto IL_321;
					case 1:
						if (A_1 != null)
						{
							num = (short)2037579783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1;
					case 2:
						num = (short)845479940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)599982089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						embeddedRecset = refSecureWide.EncryptionKeyList.EmbeddedRecset;
						goto IL_321;
					case 5:
						try
						{
							num = (short)1434420226;
							short num3 = num;
							num = (short)1162380290;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_212:
								((global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner)enumerator.Current).TalkgroupTableInnerSection.AstTlkgrpLstTalkgroupListKeySelectReference_A8366.SetRecset(recset);
								num = (short)186777604;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)76611584;
								if (num != 0)
								{
								}
								num = (short)742653953;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)221708290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1DB;
									}
									continue;
								case 2:
									goto IL_260;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)438501376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_212;
								}
								IL_1DD:
								num = (short)848953347;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DB:
								goto IL_1DD;
							}
							IL_260:
							goto IL_3A1;
						}
						finally
						{
							num = (short)379256833;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1895235586;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_297;
									}
									continue;
								case 2:
									goto IL_2CD;
								}
								IL_297:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1664483328;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2CD:;
						}
						goto IL_2D0;
					case 6:
						flag = false;
						goto IL_33F;
					case 7:
						goto IL_2D0;
					case 8:
						if (general.SecKmfProfGenIndependentKeyList_43597.Applicable)
						{
							num = (short)1818427395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)426573830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						flag = general.SecKmfProfGenIndependentKeyList_43597.Value;
						goto IL_33F;
					case 10:
						goto IL_B1;
					}
					goto IL_5B;
					IL_B1:
					enumerator = (A_0.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset).GetEnumerator();
					num = (short)985268229;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33F:
					if (!flag || !A_2)
					{
						num = (short)1362886658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)433979392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D0:
					general = A_1.General;
					refSecureWide = general.RefSecureWide;
					num = (short)604045320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_321:
					recset = embeddedRecset;
					num = (short)653852682;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3A1:
				num = (short)2129199104;
				short num4 = num;
				return;
				IL_5B:
				recset = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0][10040].EmbeddedRecset;
				num = (short)1314521089;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600CF47 RID: 53063 RVA: 0x00C0ECE8 File Offset: 0x00C0CEE8
		internal static bool ConHwCryptoCapable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)555095995;
			short num2 = num;
			num = (short)62134203;
			switch (num2 == num)
			{
			}
			num = (short)1315831808;
			short num3 = num;
			num = (short)1336868865;
			if (num != 0)
			{
			}
			num = (short)293142528;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerSection).RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value != 0;
		}

		// Token: 0x0600CF48 RID: 53064 RVA: 0x00C0EDB4 File Offset: 0x00C0CFB4
		internal static bool ConTalkGroupListAliasIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1119768314;
			short num2 = num;
			num = (short)391859962;
			switch (num2 == num)
			{
			}
			num = (short)2084438016;
			short num3 = num;
			num = (short)1647509505;
			if (num != 0)
			{
			}
			num = (short)1476067328;
			if (num != 0)
			{
			}
			return (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList).General.AstTlkgrpLstGeneralTalkgroupAlias_A9277.Value;
		}

		// Token: 0x0600CF49 RID: 53065 RVA: 0x00C0EE80 File Offset: 0x00C0D080
		internal static bool ConSecureOperationIsNotDisabledAndCnvTlkGrpSecureTypeIsNotClear(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1736108885;
			short num2 = num;
			num = (short)2094656341;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2065104896;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerSection talkgroupTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerSection;
				talkgroupTableInnerSection.AstTlkgrpLstTalkgroupListKeySelectReference_A8366.CalculateValidity();
				if (talkgroupTableInnerSection.AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.Value != 0)
				{
					return talkgroupTableInnerSection.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value != 0;
				}
				break;
			}
			}
			num = (short)1056112641;
			if (num != 0)
			{
			}
			num = (short)1582170112;
			short num3 = num;
			return false;
		}

		// Token: 0x0600CF4A RID: 53066 RVA: 0x00C0EF64 File Offset: 0x00C0D164
		public static bool ConCallConIsAstroRxUnmuteRuleValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)37879808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				int num5;
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_96;
					case 1:
						goto IL_177;
					case 2:
						goto IL_96;
					case 3:
					{
						int num3;
						global::AcpCommonLib.IAcpRecordset embeddedRecset;
						if (num3 >= embeddedRecset.Count)
						{
							num = (short)1492451334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(embeddedRecset[num3][10149] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection).CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.CalculateValidity();
						num3++;
						num = (short)500236288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_177;
					case 5:
						return true;
					case 6:
					{
						num = (short)1909260288;
						short num4 = num;
						num5++;
						num = (short)205914116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						if (num5 >= feature.Count)
						{
							num = (short)387448837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(feature[num5][10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling).CnvPerSignalingASTRORxUnmuteRule_A9042.CalculateApplicability();
						(feature[num5][10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling).CnvPerSignalingASTRORxUnmuteRule_A9042.CalculateValidity();
						global::AcpCommonLib.IAcpRecordset embeddedRecset = feature[num5][10148].EmbeddedRecset;
						int num3 = 0;
						num = (short)1899429890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_50;
					IL_96:
					num = (short)1202520067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_177:
					num = (short)232062977;
					if (num != 0)
					{
					}
					num = (short)1623529080;
					short num6 = num;
					num = (short)1611404920;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)76152832;
						if (num != 0)
						{
						}
						num = (short)50069511;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return true;
				IL_50:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2059);
				num5 = 0;
				num = (short)1998127105;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600CF4B RID: 53067 RVA: 0x00C0F1DC File Offset: 0x00C0D3DC
		public static bool ConKeySelect8366IsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1171193856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CF;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.General general;
				for (;;)
				{
					IL_28:
					global::AcpBusinessLayer.AcpRecRefField astTlkgrpLstGeneralKMFProfileIndex_A;
					global::AcpCommonLib.IAcpRecordset acpRecordset;
					int num5;
					global::AcpCommonLib.IAcpRecordset acpRecordset2;
					switch (num2)
					{
					case 0:
						num = (short)120651789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = astTlkgrpLstGeneralKMFProfileIndex_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)1894776871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_;
						if (secKmfProfGenIndependentKeyList_.Applicable)
						{
							num = (short)1572536330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CB;
					}
					case 3:
					{
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_;
						if (secKmfProfGenIndependentKeyList_.Value)
						{
							num = (short)649723931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CB;
					}
					case 4:
						goto IL_2BD;
					case 5:
						num = (short)1568800804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)168624145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						acpRecordset = general.AstTlkgrpLstGeneralKMFProfileIndex_A8380.ReferencedNode[10126].EmbeddedRecset;
						goto IL_526;
					case 8:
						if (astTlkgrpLstGeneralKMFProfileIndex_A.Value > 0)
						{
							num = (short)712376321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CB;
					case 9:
						if (general.AstTlkgrpLstGeneralKMFProfileIndex_A8380.ReferencedNode == null)
						{
							num = (short)636878877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1434386439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return true;
					case 11:
						num = (short)59506713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						return true;
					case 13:
						if (general.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value != 1)
						{
							num = (short)1864564771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_610;
					case 14:
					{
						num = (short)1169752064;
						short num3 = num;
						goto IL_2BD;
					}
					case 15:
						if (general.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
						{
							num = (short)1448869894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_346;
					case 16:
						return true;
					case 17:
						if (!general.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value)
						{
							num = (short)284164114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_610;
					case 18:
						goto IL_442;
					case 19:
						num = (short)1071185957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection secureHardwareEncryptionKeyReferencesListInnerSection;
						if (secureHardwareEncryptionKeyReferencesListInnerSection != null)
						{
							num = (short)2047803397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DA;
					}
					case 21:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_ = secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597;
						num = (short)2001600515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						num = (short)1912799264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (general.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
						{
							num = (short)31326208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_346;
					case 24:
						if (general.AstTlkgrpLstGeneralKMFProfileIndex_A8380.Value == 0)
						{
							num = (short)1619197964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2082078746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile.General != null)
						{
							num = (short)654311445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CB;
					}
					case 26:
						if (general.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
						{
							num = (short)459210780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_346;
					case 27:
						num = (short)848232450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)233898007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)1411186721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						num = (short)305196170;
						short num4 = num;
						num = (short)624684170;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5CB;
						default:
							num = (short)1225654272;
							if (num != 0)
							{
							}
							if (astTlkgrpLstGeneralKMFProfileIndex_A.RefRecset != null)
							{
								num = (short)2021457939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5CB;
						}
						break;
					}
					case 31:
						num = (short)1343619080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						if (num5 >= acpRecordset2.Count)
						{
							num = (short)1683685414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection secureHardwareEncryptionKeyReferencesListInnerSection = acpRecordset2[num5][10127] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection;
						num = (short)395968532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						acpRecordset = null;
						goto IL_526;
					case 34:
						if (acpRecordset2 != null)
						{
							num = (short)355926038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 35:
						num = (short)1150025743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection secureHardwareEncryptionKeyReferencesListInnerSection;
						if (secureHardwareEncryptionKeyReferencesListInnerSection.SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Value == index)
						{
							num = (short)240254992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DA;
					}
					case 37:
						if (astTlkgrpLstGeneralKMFProfileIndex_A.ReferencedNode != null)
						{
							num = (short)1805451295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CB;
					case 38:
						goto IL_3B0;
					case 39:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)287440907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CB;
					}
					}
					goto IL_CF;
					IL_2BD:
					num = (short)1885601826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DA:
					num5++;
					num = (short)1261764622;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_526:
					acpRecordset2 = acpRecordset;
					num5 = 0;
					num = (short)2108882948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CB:
					num = (short)1701642249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_610:
					astTlkgrpLstGeneralKMFProfileIndex_A = general.AstTlkgrpLstGeneralKMFProfileIndex_A8380;
					num = (short)127402014;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_346:
				num = (short)1182203905;
				if (num != 0)
				{
				}
				return true;
				IL_3B0:
				return false;
				IL_442:
				goto IL_346;
				IL_CF:
				general = (self.Parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList).General;
				num = (short)1868300312;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
