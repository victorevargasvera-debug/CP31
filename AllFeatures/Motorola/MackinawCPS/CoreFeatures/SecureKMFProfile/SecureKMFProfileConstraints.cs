using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000EE RID: 238
	public static class SecureKMFProfileConstraints
	{
		// Token: 0x06002407 RID: 9223 RVA: 0x00231A74 File Offset: 0x0022FC74
		internal static bool ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			short num2;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)1012465668;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1708195841;
					if (num2 != 0)
					{
					}
					num2 = (short)828243970;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (secWideGeneralSecureOperation_A.Value != 1)
					{
						num2 = (short)680460288;
						short num3 = num2;
						num2 = (short)497614848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					goto IL_127;
				case 4:
					goto IL_107;
				case 5:
					if (secureKMFProfile.General.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
					{
						num2 = (short)84213761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					num2 = (short)1202716677;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (secureKMFProfile.General.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
					{
						num2 = (short)259981318;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_30;
			}
			IL_107:
			if (secWideGeneralSecureOperation_A.Value == 3)
			{
				goto IL_110;
			}
			return false;
			IL_127:
			return secureKMFProfile.General.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value;
			IL_30:
			secureKMFProfile = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
			secWideGeneralSecureOperation_A = secureKMFProfile.General.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			num2 = (short)1210390191;
			short num4 = num2;
			num2 = (short)1109137071;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_110:
				num2 = (short)1891631107;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1603469312;
				if (num2 != 0)
				{
				}
				num2 = (short)969539591;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00231CAC File Offset: 0x0022FEAC
		internal static bool ConAstroOtarEnAndOtarEnAndSecOperIsHwareAndRespKindIsConfirmed(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation astrootarinformation;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)846135299;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)887488512;
					short num3 = num2;
					num2 = (short)1813839879;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (secWideGeneralSecureOperation_A.Value != 1)
					{
						num2 = (short)1555431424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20C;
				case 3:
					if (secWideGeneralSecureOperation_A.Value == 3)
					{
						num2 = (short)845742085;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					num2 = (short)1955201026;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)2061959176;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_158;
				case 7:
					num2 = (short)251133953;
					if (num2 != 0)
					{
					}
					if (astrootarinformation.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
					{
						goto IL_1F3;
					}
					return false;
				case 8:
					if (astrootarinformation.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value)
					{
						num2 = (short)758841350;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
				{
					num2 = (short)1808054560;
					short num4 = num2;
					num2 = (short)1475918112;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F3;
					default:
						num2 = (short)1485963264;
						if (num2 != 0)
						{
						}
						if (astrootarinformation.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
						{
							num2 = (short)969146369;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				}
				goto IL_38;
				IL_1F3:
				num2 = (short)246939652;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_158:
			IL_20C:
			return astrootarinformation.SecKmfProfASTROOTARInformationResponseKind_A8947.Value == 1;
			IL_38:
			astrootarinformation = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation);
			secWideGeneralSecureOperation_A = astrootarinformation.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			num2 = (short)816250889;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00231F14 File Offset: 0x00230114
		[global::ConstraintHelper.TriggerValidOnLoading]
		public static bool conHwKeyReferencedNotDuplicated(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1060110336;
			switch (num)
			{
			default:
			{
				num = (short)1459748908;
				int num2 = (int)((global::System.IntPtr)num);
				bool result;
				for (;;)
				{
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset secureHardwareEncryptionKeyReferencesListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner encryptionKeyListInner;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection secureHardwareEncryptionKeyReferencesListInnerSection;
					global::AcpBusinessLayer.AcpRecRefField secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A;
					int num9;
					switch (num2)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2053);
						num3 = 0;
						num = (short)2031812650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_40F;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureHardwareEncryptionKeyReferencesListInnerRecset.GetEnumerator();
						num = (short)1601568790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_7F8;
					case 4:
						if (encryptionKeyListInner != null)
						{
							num = (short)1102970906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
						goto IL_B63;
					case 6:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if ((feature[num3][10118] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General).CnvSysGeneralSystemType_A13262.Value == 2)
						{
							num = (short)1569849351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ACB;
					}
					case 7:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						(feature[num3][10644] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure).CnvSysSecureDynTGKeySel_A40133.CalculateApplicability();
						(feature[num3][10644] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure).CnvSysSecureDynTGKeySel_A40133.CalculateValidity();
						(feature[num3][10644] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure).CnvSysSecureFSKeySel_A40134.CalculateApplicability();
						(feature[num3][10644] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure).CnvSysSecureFSKeySel_A40134.CalculateValidity();
						(feature[num3][10644] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure).CnvSysSecureInterConnectKeySel_A40135.CalculateApplicability();
						(feature[num3][10644] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure).CnvSysSecureInterConnectKeySel_A40135.CalculateValidity();
						(feature[num3][10644] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure).CnvSysSecurePatchKeySel_A40136.CalculateApplicability();
						(feature[num3][10644] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure).CnvSysSecurePatchKeySel_A40136.CalculateValidity();
						(feature[num3][10644] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure).CnvSysSecurePrivateCallKeySel_A40137.CalculateApplicability();
						(feature[num3][10644] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure).CnvSysSecurePrivateCallKeySel_A40137.CalculateValidity();
						num = (short)1283522576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (secureHardwareEncryptionKeyReferencesListInnerSection.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
						{
							num = (short)1246560258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31E;
					case 9:
						if (secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A.RefRecset == null)
						{
							num = (short)1158021149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)350289961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_147;
					case 11:
					{
						int num4;
						global::AcpCommonLib.IAcpRecordset feature2;
						if (num4 >= feature2.Count)
						{
							num = (short)196542497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(feature2[num4][10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General).TrkEmerProfGeneralKeySelect_A8970.CalculateApplicability();
						(feature2[num4][10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General).TrkEmerProfGeneralKeySelect_A8970.CalculateValidity();
						(feature2[num4][10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup).TrkPerAnnouncementGroupAGKeySelect_A7414.CalculateApplicability();
						(feature2[num4][10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup).TrkPerAnnouncementGroupAGKeySelect_A7414.CalculateValidity();
						int num5 = 0;
						num = (short)890634261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_E57;
					case 13:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
						num = (short)638058515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)1248002056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (num3 >= feature.Count)
						{
							num = (short)1357709344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1576271878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_ACB;
					case 17:
						num = (short)1903427607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						int num6;
						global::AcpCommonLib.IAcpRecordset feature3;
						if (num6 >= feature3.Count)
						{
							num = (short)293142528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(feature3[num6][10142] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure).CnvPerSecureKeySelection1_A8368.CalculateApplicability();
						(feature3[num6][10142] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure).CnvPerSecureKeySelection1_A8368.CalculateValidity();
						(feature3[num6][10142] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure).CnvPerSecureKeySelection2_A8369.CalculateApplicability();
						(feature3[num6][10142] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure).CnvPerSecureKeySelection2_A8369.CalculateValidity();
						(feature3[num6][10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling).CnvPerSignalingRevertTGKeySel_A40154.CalculateApplicability();
						(feature3[num6][10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling).CnvPerSignalingRevertTGKeySel_A40154.CalculateValidity();
						(feature3[num6][10642] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.DVRS).CnvPerAGAGKeySel_A40159.CalculateApplicability();
						(feature3[num6][10642] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.DVRS).CnvPerAGAGKeySel_A40159.CalculateValidity();
						num6++;
						num = (short)586416128;
						short num7 = num;
						num = (short)1429209093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						try
						{
							num = (short)483786756;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)922222595;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2048458752;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current).NetworkLayerSecurity.DataProfNLSKeySele_A36410.CalculateValidity();
									num = (short)1046216705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_DE3;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_D5D;
									}
									continue;
								}
								IL_D91:
								num = (short)633208834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D5D:
								goto IL_D91;
							}
							IL_DE3:
							goto IL_CB3;
						}
						finally
						{
							num = (short)1794965506;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)915341313;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_E54;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E1A;
									}
									continue;
								}
								IL_E1A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1435238400;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E54:;
						}
						goto IL_E57;
						IL_CB3:
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2072);
						int num4 = 0;
						num = (short)234815526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						int num8;
						global::AcpCommonLib.IAcpRecordset feature4;
						if (num8 >= (feature4[num9][10152] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupList).EmbeddedRecset.Count)
						{
							num = (short)513277964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((feature4[num9][10152] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupList).EmbeddedRecset[num8][10153] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerSection).AstTlkgrpLstTalkgroupListKeySelectReference_A8366.CalculateApplicability();
						((feature4[num9][10152] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupList).EmbeddedRecset[num8][10153] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerSection).AstTlkgrpLstTalkgroupListKeySelectReference_A8366.CalculateValidity();
						num8++;
						num = (short)1201405987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_7F8;
					case 22:
						try
						{
							num = (short)766640136;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5AA;
								case 1:
									goto IL_58C;
								case 2:
									num = (short)805306368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)316473349;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									result = false;
									num = (short)74252289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (index == (acpFeatureNode[10127] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection).SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Value)
									{
										num = (short)1445462020;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1501888514;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)594673671;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (secureHardwareEncryptionKeyReferencesListInnerSection.Parent != acpFeatureNode)
									{
										num = (short)764411907;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_49C;
									}
									continue;
								}
								IL_531:
								num = (short)425918470;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_49C:
								goto IL_531;
							}
							IL_58C:
							IL_5AA:
							goto IL_31E;
						}
						finally
						{
							num = (short)1933705218;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1614675969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_619;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5E2;
									}
									continue;
								}
								IL_5E2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2121859072;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_619:;
						}
						goto IL_61C;
					case 23:
						if (secureHardwareEncryptionKeyReferencesListInnerSection.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
						{
							num = (short)69730318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31E;
					case 24:
					{
						int num4;
						global::AcpCommonLib.IAcpRecordset feature2;
						int num5;
						if (num5 >= (feature2[num4][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset.Count)
						{
							num = (short)1526202402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((feature2[num4][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset[num5][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection).TrkPerTalkgroupKeySelect_A8365.CalculateApplicability();
						((feature2[num4][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset[num5][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection).TrkPerTalkgroupKeySelect_A8365.CalculateValidity();
						num5++;
						num = (short)484114435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_B63;
					case 26:
						goto IL_61C;
					case 27:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
						num = (short)2143158309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						num = (short)262930436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_319;
					case 30:
						goto IL_64D;
					case 31:
					{
						global::AcpCommonLib.IAcpRecordset feature4;
						if (num9 >= feature4.Count)
						{
							num = (short)367591451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num8 = 0;
						num = (short)1484455946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
					{
						global::AcpCommonLib.IAcpRecordset feature4 = global::AcpCommonLib.FeatureManager.GetFeature(2062);
						num9 = 0;
						num = (short)1760690212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						global::AcpCommonLib.IAcpRecordset feature3 = global::AcpCommonLib.FeatureManager.GetFeature(2059);
						int num6 = 0;
						num = (short)374210585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
					{
						int num4;
						num4++;
						num = (short)1316552705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						goto IL_147;
					case 36:
						goto IL_CDF;
					case 37:
						try
						{
							num = (short)1418788868;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1024524291;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2136342528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyPatchKeySelect_A8694.CalculateApplicability();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyPatchKeySelect_A8694.CalculateValidity();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyDynamicAGKeySelect_A7914.CalculateApplicability();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyDynamicAGKeySelect_A7914.CalculateValidity();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.CalculateApplicability();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.CalculateValidity();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyFailsoftKeySelect_A8012.CalculateApplicability();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyFailsoftKeySelect_A8012.CalculateValidity();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyInterconnectKeySelect_A8298.CalculateApplicability();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyInterconnectKeySelect_A8298.CalculateValidity();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyPrivateCallKeySelect_A8757.CalculateApplicability();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyPrivateCallKeySelect_A8757.CalculateValidity();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669.CalculateApplicability();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669.CalculateValidity();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeySystemWideKeySelect_A9253.CalculateApplicability();
									(trunkingSystem[10158] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).TrkSysSecureMultikeySystemWideKeySelect_A9253.CalculateValidity();
									num = (short)30081025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_1162;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_F40;
									}
									continue;
								}
								IL_110A:
								num = (short)938409986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F40:
								goto IL_110A;
							}
							IL_1162:
							goto IL_2C2;
						}
						finally
						{
							num = (short)996671490;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)725680129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_11D3;
								case 2:
									IL_117D:
									switch (0)
									{
									case 0:
										goto IL_119A;
									}
									continue;
								}
								IL_119A:
								if (enumerator != null)
								{
									num = (short)104857600;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11D3:
								num = (short)661584181;
								short num10 = num;
								num = (short)1048574261;
								switch ((num10 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_117D;
								default:
									goto IL_1208;
								}
							}
							IL_1208:
							num = (short)473694208;
							if (num != 0)
							{
							}
						}
						return true;
					case 38:
						goto IL_40F;
					case 39:
						goto IL_AEC;
					case 40:
						goto IL_CDF;
					case 41:
						if (secureHardwareEncryptionKeyReferencesListInnerSection.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value != 0)
						{
							num = (short)750190609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31E;
					case 42:
						goto IL_AEC;
					case 43:
						if (secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A.Value == index)
						{
							num = (short)1628241948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 44:
						switch (0)
						{
						case 0:
							goto IL_FA;
						}
						continue;
					}
					IL_FA:
					num = (short)324403201;
					if (num != 0)
					{
					}
					if (!global::AcpCommonLib.AppInfoManager.AddCopyOperation)
					{
						num = (short)687734797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C2;
					IL_147:
					num = (short)385417236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C2:
					secureHardwareEncryptionKeyReferencesListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection);
					secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A = secureHardwareEncryptionKeyReferencesListInnerSection.SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194;
					secureHardwareEncryptionKeyReferencesListInnerRecset = (self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset);
					num = (short)1494089737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31E:
					encryptionKeyListInner = (secureHardwareEncryptionKeyReferencesListInnerSection.SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner);
					num = (short)1720320043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40F:
					num = (short)435879947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_61C:
					secureHardwareEncryptionKeyReferencesListInnerSection.SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.PointedField = encryptionKeyListInner.EncryptionKeyListInnerSection.SecWideMultikeyListCKR_A7665;
					num = (short)484704286;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F8:
					num = (short)174325784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ACB:
					num3++;
					num = (short)806551591;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AEC:
					num = (short)2142437391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B63:
					num = (short)129761298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CDF:
					num = (short)539688991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E57:
					num9++;
					num = (short)986578984;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_319:
				return true;
				IL_64D:
				return result;
			}
			}
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x00233190 File Offset: 0x00231390
		public static bool conIPAddressValidate(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)181665792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FF;
				}
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						num = (short)620691460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_6BC;
					case 2:
					{
						byte[] array;
						if (array[2] == 255)
						{
							num = (short)660078643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14A;
					}
					case 3:
					{
						byte[] array;
						if (array[1] != 0)
						{
							num = (short)576782381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
					{
						byte[] array;
						if (array[3] == 255)
						{
							num = (short)1516437509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 5:
						goto IL_898;
					case 6:
						return false;
					case 7:
						num = (short)1490223113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)974061583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						byte[] array;
						if (array[2] == 255)
						{
							num = (short)2116943872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 10:
						num = (short)354025488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFIPAddress_A8375.Value)))
						{
							num = (short)1244594182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						long value = secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFIPAddress_A8375.Value;
						byte[] array = new byte[]
						{
							(byte)value,
							(byte)(value >> 8),
							(byte)(value >> 16),
							(byte)(value >> 24)
						};
						byte b = array[0];
						num = (short)60751912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)2062286889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						secureKMFProfile = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
						num = (short)1094909976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_549;
					case 15:
					{
						byte[] array;
						if (array[3] == 0)
						{
							num = (short)1598160917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 16:
					{
						byte[] array;
						if (array[1] == 0)
						{
							num = (short)944701452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_549;
					}
					case 17:
						return true;
					case 18:
						num = (short)1713766431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFIPAddress_A8375.Value == 0L)
						{
							num = (short)565706769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1901461515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_745;
					case 21:
						goto IL_7F0;
					case 22:
					{
						byte b;
						if (b >= 192)
						{
							num = (short)1247215666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)848429086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						byte[] array;
						if (array[2] == 0)
						{
							num = (short)985595912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 24:
						goto IL_6BC;
					case 25:
					{
						byte[] array;
						if (array[3] != 255)
						{
							num = (short)45088812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 26:
					{
						byte b;
						if (b == 0)
						{
							num = (short)1973289003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)772276246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						num = (short)1517289508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						num = (short)1179366955;
						short num3 = num;
						num = (short)1639101995;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12B;
						default:
						{
							num = (short)416546816;
							if (num != 0)
							{
							}
							byte[] array;
							if (array[1] == 255)
							{
								num = (short)1442250759;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						}
						break;
					}
					case 29:
						num = (short)1759445018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						byte b;
						if (b >= 128)
						{
							num = (short)1374748711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1039794222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						byte[] array;
						if (array[3] != 0)
						{
							num = (short)198180899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 32:
					{
						byte[] array;
						if (array[2] == 0)
						{
							num = (short)672006162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_372;
					}
					case 33:
						num = (short)1807941635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)1589444657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_372;
					case 36:
					{
						byte[] array;
						if (array[3] == 255)
						{
							num = (short)648478740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 37:
						if (self.ParentRecset.IsEmbeddedRecset)
						{
							goto IL_12B;
						}
						secureKMFProfile = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
						num = (short)1431371777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						byte[] array;
						if (array[3] != 0)
						{
							num = (short)303300635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 39:
					{
						num = (short)1199767552;
						short num4 = num;
						num = (short)950075439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
					{
						byte b;
						if (b <= 223)
						{
							num = (short)1325137954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 41:
					{
						byte[] array;
						if (array[2] != 0)
						{
							num = (short)1716912142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 42:
					{
						byte b;
						if (b == 192)
						{
							num = (short)1018757130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_549;
					}
					case 43:
						goto IL_637;
					case 44:
						goto IL_14A;
					case 45:
						goto IL_74A;
					case 46:
					{
						byte[] array;
						if (array[1] == 0)
						{
							num = (short)740687920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_372;
					}
					case 47:
					{
						byte b;
						if (b == 128)
						{
							num = (short)1850212385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74A;
					}
					case 48:
						num = (short)2043740192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						byte b;
						if (b != 127)
						{
							num = (short)384106525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 50:
						num = (short)1316945962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						num = (short)814546945;
						if (num != 0)
						{
						}
						num = (short)980811801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FF;
					IL_12B:
					num = (short)643104781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14A:
					num = (short)1879048215;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_372:
					num = (short)635568156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_549:
					num = (short)1660420134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6BC:
					num = (short)1392574483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74A:
					num = (short)677511170;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_637:
				return false;
				IL_745:
				return false;
				IL_7F0:
				return false;
				IL_898:
				return false;
				IL_FF:
				secureKMFProfile = null;
				num = (short)1120993317;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00233A3C File Offset: 0x00231C3C
		internal static bool ConIsHardwareKeyRefApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)673251328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1170997248;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_B7;
				}
				global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner encryptionKeyListInner;
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection secureHardwareEncryptionKeyReferencesListInnerSection;
				bool flag2;
				for (;;)
				{
					IL_50:
					bool flag;
					switch (num2)
					{
					case 0:
						flag = true;
						goto IL_1AF;
					case 1:
						goto IL_382;
					case 2:
						num = (short)290258960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						flag = false;
						goto IL_1AF;
					case 4:
						if (secWideGeneralSecureOperation_A.Value != 1)
						{
							num = (short)1718550539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1397293061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						flag = true;
						goto IL_1AF;
					case 6:
						goto IL_29E;
					case 7:
						num = (short)345309206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (secWideGeneralSecureOperation_A.Value == 3)
						{
							num = (short)1519452178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1467678723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (encryptionKeyListInner != null)
						{
							num = (short)111476748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213;
					case 10:
						num = (short)1402929153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1052770312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						secureHardwareEncryptionKeyReferencesListInnerSection.SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.PointedField = encryptionKeyListInner.EncryptionKeyListInnerSection.SecWideMultikeyListCKR_A7665;
						num = (short)973668375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (secureHardwareEncryptionKeyReferencesListInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolQ806IMBE_A8191)
						{
							num = (short)1364459522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					case 14:
						num = (short)774111233;
						if (num != 0)
						{
						}
						num = (short)1796014099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						flag = false;
						goto IL_1AF;
					case 16:
						if (secureHardwareEncryptionKeyReferencesListInnerSection.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
						{
							goto IL_192;
						}
						goto IL_390;
					case 17:
						if (!secureHardwareEncryptionKeyReferencesListInnerSection.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value)
						{
							num = (short)1218445326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1471348736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)2082078737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						flag = secureHardwareEncryptionKeyReferencesListInnerSection.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.Value;
						goto IL_1AF;
					case 20:
						num = (short)2146893828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if ((self.Parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile).General.SecKmfProfGenIndependentKeyList_43597)
						{
							num = (short)809631754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1790312454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (secureHardwareEncryptionKeyReferencesListInnerSection.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
						{
							num = (short)548339732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					case 23:
					{
						num = (short)230733958;
						short num4 = num;
						num = (short)537507974;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_192;
						default:
							num = (short)1990590464;
							if (num != 0)
							{
							}
							goto IL_213;
						}
						break;
					}
					}
					goto IL_B7;
					IL_192:
					num = (short)1175912455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AF:
					flag2 = flag;
					num = (short)648609813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_213:
					num = (short)737148941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_390:
					num = (short)878903311;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_29E:
				int num5 = 0;
				goto IL_4E4;
				IL_382:
				num5 = ((secWideGeneralSecureOperation_A.Value == 1) ? 1 : 0);
				IL_4E4:
				return num5 == 0 && flag2;
				IL_B7:
				secureHardwareEncryptionKeyReferencesListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection);
				secWideGeneralSecureOperation_A = secureHardwareEncryptionKeyReferencesListInnerSection.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
				global::AcpCommonLib.FeatureManager.GetFeature(2055);
				encryptionKeyListInner = (secureHardwareEncryptionKeyReferencesListInnerSection.SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner);
				num = (short)923402249;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00233F34 File Offset: 0x00232134
		internal static bool ConTriggerPortNumValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1422393344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5C;
				}
				global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset enhancedDataPortListRecset;
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						num = (short)733937665;
						if (num != 0)
						{
						}
						if (enhancedDataPortListRecset != null)
						{
							num = (short)2057437191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59A;
					case 1:
						if (secureKMFProfile.ASTROOTARInformation.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
						{
							num = (short)1368457218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						num = (short)1787297802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1901330432;
						short num3 = num;
						if (secureKMFProfile.ASTROOTARInformation.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
						{
							num = (short)1776418821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
						if (secureKMFProfile.ASTROOTARInformation.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
						{
							num = (short)2107834374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						num = (short)868614145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_593;
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = enhancedDataPortListRecset.GetEnumerator();
						num = (short)735772680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						try
						{
							num = (short)483524608;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1A2;
									}
									continue;
								case 1:
									goto IL_4AD;
								case 2:
									num = (short)2145255430;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									try
									{
										num = (short)1640658793;
										short num4 = num;
										num = (short)341276521;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)1782513664;
											if (num != 0)
											{
											}
											num = (short)1415184385;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
												{
													global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)1392508930;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													(enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner).EnhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008.CalculateValidity();
													num = (short)1281163268;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 1:
													switch (0)
													{
													case 0:
														goto IL_399;
													}
													continue;
												case 2:
													num = (short)1595801603;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													goto IL_420;
												}
												IL_3CD:
												num = (short)831520768;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_399:
												goto IL_3CD;
											}
											break;
										}
										IL_420:
										break;
									}
									finally
									{
										num = (short)574095362;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)1607532545;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_491;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_458;
												}
												continue;
											}
											IL_458:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)2123628544;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_491:;
									}
									goto IL_494;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
									if (enhancedDataPortTableInnerRecset != null)
									{
										num = (short)273809419;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList.EnhancedDataPortList42005.EmbeddedRecset != null)
									{
										num = (short)1284440071;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList.EnhancedDataPortList42005 != null)
									{
										num = (short)101187592;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset = enhancedDataPortList.EnhancedDataPortList42005.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset;
									num = (short)499515396;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1856897029;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1835020;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList;
									num = (short)1317208074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList != null)
									{
										num = (short)1677983746;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = enhancedDataPortTableInnerRecset.GetEnumerator();
									num = (short)875167747;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									goto IL_494;
								}
								IL_1A4:
								num = (short)821166089;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A2:
								goto IL_1A4;
								IL_494:
								num = (short)549847041;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4AD:
							goto IL_59A;
						}
						finally
						{
							num = (short)867958786;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)516882433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_51C;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4E6;
									}
									continue;
								}
								IL_4E6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)229834752;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_51C:;
						}
						return false;
					case 9:
						num = (short)551747588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (secureKMFProfile.ASTROOTARInformation.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value != 1)
						{
							num = (short)2063466505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_5C;
					IL_59A:
					num = (short)1192427523;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_593:
				return secureKMFProfile.ASTROOTARInformation.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value;
				IL_5C:
				secureKMFProfile = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
				enhancedDataPortListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4148) as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset);
				num = (short)19464192;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x002345DC File Offset: 0x002327DC
		internal static bool ConErasePrevKeysetOnOTARChangeoverApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)276323118;
			short num2 = num;
			num = (short)451762990;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1961623553;
				if (num != 0)
				{
				}
				num = (short)227999744;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_91;
				}
				int num3;
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation astrootarinformation;
				for (;;)
				{
					IL_7B:
					switch (num3)
					{
					case 0:
						if (astrootarinformation.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
						{
							num = (short)1784676352;
							short num4 = num;
							num = (short)1257177089;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						goto IL_167;
					case 2:
						num = (short)1629749248;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (astrootarinformation.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
						{
							num = (short)612499458;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_91;
				}
				IL_167:
				return astrootarinformation.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1;
				IL_91:
				astrootarinformation = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation);
				num = (short)1816723459;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7B;
			}
			}
			return false;
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x00234758 File Offset: 0x00232958
		internal static bool ConOTARRxSecurityLevelValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			if ((self as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation).RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
			{
				short num = (short)228917249;
				if (num != 0)
				{
				}
				num = (short)189442036;
				short num2 = num;
				num = (short)1862379508;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				case 1:
					break;
				default:
				{
					num = (short)317325312;
					short num3 = num;
					break;
				}
				}
				num = (short)925368320;
				if (num != 0)
				{
				}
				return index != 1;
			}
			return true;
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x00234830 File Offset: 0x00232A30
		internal static bool ConOTARTxSecurityLevelValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			if ((self as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation).RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
			{
				short num = (short)1660316013;
				short num2 = num;
				num = (short)726034797;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1659830272;
					short num3 = num;
					num = (short)178585601;
					if (num != 0)
					{
					}
					num = (short)156958720;
					if (num != 0)
					{
					}
					return index != 1;
				}
				}
			}
			return true;
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x00234904 File Offset: 0x00232B04
		public static bool ConHwSecItemIsVisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = self.Parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = secureKMFProfile.General;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A = secureKMFProfile.ASTROOTARInformation.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			if (general.SecKmfProfGenIndependentKeyList_43597)
			{
				short num = (short)918329046;
				short num2 = num;
				num = (short)2100401878;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2100297728;
					short num3 = num;
					num = (short)1103888384;
					if (num != 0)
					{
					}
					num = (short)499646465;
					if (num != 0)
					{
					}
					return secWideGeneralSecureOperation_A.Value != 1;
				}
				}
			}
			return true;
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00234A04 File Offset: 0x00232C04
		public static bool ConHwSecIndependItemIsVisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)310116353;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
			global::AcpCommonLib.IAcpFeatureNode parent;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					if (secureKMFProfile == null)
					{
						num = (short)969801728;
						short num3 = num;
						num = (short)1674575881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D9;
				case 1:
					secureKMFProfile = (parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
					num = (short)448135175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (parent != null)
					{
						num = (short)1170669574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D9;
				case 3:
				{
					if (parent.Parent.ParentSection == null)
					{
						goto IL_D9;
					}
					num = (short)485714036;
					short num4 = num;
					num = (short)1948412020;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A4;
					default:
						num = (short)1811087360;
						if (num != 0)
						{
						}
						num = (short)1311309825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					return false;
				case 5:
					goto IL_1E9;
				case 6:
					num = (short)2086666251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_D9;
				case 8:
					if (secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597)
					{
						num = (short)1325793285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 9:
					num = (short)1727528962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)902103043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (parent.Parent != null)
					{
						num = (short)2018312202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D9;
				case 12:
					if (secureKMFProfile == null)
					{
						num = (short)1594228740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					secWideGeneralSecureOperation_A = secureKMFProfile.ASTROOTARInformation.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
					goto IL_1A4;
				}
				goto IL_6A;
				IL_D9:
				num = (short)744685580;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A4:
				num = (short)1390936072;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_1E9:
			return secWideGeneralSecureOperation_A.Value == 1;
			IL_6A:
			parent = self.Parent;
			secureKMFProfile = (parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
			num = (short)2095841280;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00234CC4 File Offset: 0x00232EC4
		public static bool ConHwSecIndependentKeyListAstroOtarEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)473956352;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::AcpBusinessLayer.AcpField<bool> secWideASTROOTARASTROOTAREnable_A;
				for (;;)
				{
					IL_27:
					global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general;
					global::AcpBusinessLayer.AcpField<bool> secWideGeneralOTAREnable_A;
					object obj;
					switch (num2)
					{
					case 0:
					{
						num = (short)322785812;
						short num3 = num;
						num = (short)1871532564;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_206;
						default:
							goto IL_254;
						}
						break;
					}
					case 1:
						if (secWideGeneralSecureOperation_A.Value == 1)
						{
							num = (short)1461125124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						if (!(parent is global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile))
						{
							num = (short)1101201414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)180158472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (general.SecKmfProfGenIndependentKeyList_43597)
						{
							num = (short)1958543365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						num = (short)508428295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)815661056;
						short num4 = num;
						num = (short)1654521857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1234829321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (secWideGeneralOTAREnable_A.Value)
						{
							goto IL_206;
						}
						return false;
					case 8:
						obj = (parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
						goto IL_E4;
					case 9:
						obj = (parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
						goto IL_E4;
					}
					goto IL_56;
					IL_E4:
					object obj2 = obj;
					secWideGeneralSecureOperation_A = obj2.ASTROOTARInformation.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
					general = obj2.General;
					secWideASTROOTARASTROOTAREnable_A = obj2.ASTROOTARInformation.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496;
					secWideGeneralOTAREnable_A = obj2.ASTROOTARInformation.RefSecureWide.General.SecWideGeneralOTAREnable_A7966;
					num = (short)888340483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_206:
					num = (short)1219690496;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_254:
				num = (short)1677459457;
				if (num != 0)
				{
				}
				num = (short)1615265792;
				if (num != 0)
				{
				}
				return secWideASTROOTARASTROOTAREnable_A.Value;
				IL_56:
				parent = self.Parent;
				num = (short)2049507330;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00234F68 File Offset: 0x00233168
		public static bool ConIndependentKeyListCkrValueNotBlankNorDuplicated(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)181862400;
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
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerSection secureHardwareEncryptionIndependentKeyListInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset secureHardwareEncryptionIndependentKeyListInnerRecset;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_83;
					case 1:
						goto IL_31E;
					case 2:
					{
						if (secureHardwareEncryptionIndependentKeyListInnerSection.SecProfIndependMultikeyListCKR_43594Value == 0)
						{
							num = (short)1435435008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureHardwareEncryptionIndependentKeyListInnerRecset.GetEnumerator();
						num = (short)754057216;
						short num3 = num;
						num = (short)2096365569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_3A;
				}
				IL_83:
				num = (short)492765185;
				if (num != 0)
				{
				}
				return false;
				IL_31E:
				try
				{
					num = (short)716767233;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							result = false;
							goto IL_101;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_FC;
							}
							continue;
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerSection secureHardwareEncryptionIndependentKeyListInnerSection2;
							if (!secureHardwareEncryptionIndependentKeyListInnerSection2.SecProfIndependMultikeyListKeyName_43595Value.Equals(secureHardwareEncryptionIndependentKeyListInnerSection.SecProfIndependMultikeyListKeyName_43595Value))
							{
								num = (short)55377923;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							num = (short)229244932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerSection secureHardwareEncryptionIndependentKeyListInnerSection2;
							if (secureHardwareEncryptionIndependentKeyListInnerSection2.SecProfIndependMultikeyListCKR_43594Value == secureHardwareEncryptionIndependentKeyListInnerSection.SecProfIndependMultikeyListCKR_43594Value)
							{
								num = (short)978452480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_262;
						case 6:
							num = (short)815333381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)217579526;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerSection secureHardwareEncryptionIndependentKeyListInnerSection2 = ((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInner)enumerator.Current).SecureHardwareEncryptionIndependentKeyListInnerSection;
							num = (short)1039597570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							num = (short)281400119;
							short num4 = num;
							num = (short)1580323639;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_101;
							default:
								goto IL_14D;
							}
							break;
						}
						}
						goto IL_FC;
						IL_101:
						num = (short)2089353224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_168:
						num = (short)931528711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_FC:
						goto IL_168;
					}
					IL_14D:
					num = (short)723124224;
					if (num != 0)
					{
					}
					return result;
					IL_262:
					return true;
				}
				finally
				{
					num = (short)1583087618;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)261947393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_2CD;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_297;
							}
							continue;
						}
						IL_297:
						if (enumerator == null)
						{
							break;
						}
						num = (short)525467648;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2CD:;
				}
				return false;
				IL_3A:
				secureHardwareEncryptionIndependentKeyListInnerRecset = (self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset);
				secureHardwareEncryptionIndependentKeyListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerSection);
				num = (short)988479490;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x002352B8 File Offset: 0x002334B8
		internal static bool ConSecOperationIsHardware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1528444118;
			short num2 = num;
			num = (short)616445142;
			switch (num2 == num)
			{
			}
			num = (short)1036582912;
			short num3 = num;
			num = (short)915079169;
			if (num != 0)
			{
			}
			num = (short)1900478464;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General).RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1;
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00235380 File Offset: 0x00233580
		internal static void ConIndependentKeyListValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1768620032;
			switch (num)
			{
			default:
			{
				num = (short)435748864;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.IAcpRecordset feature;
					int num3;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_6F;
						}
						continue;
					case 1:
						return;
					case 2:
						goto IL_321;
					case 3:
						feature = global::AcpCommonLib.FeatureManager.GetFeature(2059);
						num3 = 0;
						num = (short)1022689290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						try
						{
							num = (short)1754011961;
							short num4 = num;
							num = (short)1946097977;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1884815360;
								if (num != 0)
								{
								}
								num = (short)427819009;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)2143420419;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_18D;
										}
										continue;
									case 3:
										goto IL_216;
									case 4:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)453705728;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current).NetworkLayerSecurity.DataProfNLSKeySele_A36410.CalculateValidity();
										num = (short)1796538370;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_18F:
									num = (short)68747268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_18D:
									goto IL_18F;
								}
								break;
							}
							IL_216:
							goto IL_3F5;
						}
						finally
						{
							num = (short)972292098;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1315635201;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_284;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_24E;
									}
									continue;
								}
								IL_24E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1203699712;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_284:;
						}
						goto IL_287;
						IL_3F5:
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2062);
						int num5 = 0;
						num = (short)563412994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (num3 >= feature.Count)
						{
							num = (short)1093599233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_287;
					case 6:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						int num5;
						if (num5 >= feature2.Count)
						{
							num = (short)11272193;
							if (num != 0)
							{
							}
							num = (short)1228865539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(feature2[num5] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList).TalkgroupList.EmbeddedRecset.CalculateValidity();
						num5++;
						num = (short)751370249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
						num = (short)1288241156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_38B;
					case 9:
						goto IL_321;
					case 10:
						goto IL_38B;
					}
					IL_6F:
					if ((self as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General).SecKmfProfGenIndependentKeyList_43597.Value)
					{
						num = (short)1877016583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_287:
					(feature[num3][10142] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure).CnvPerSecureKeySelection1_A8368.CalculateValidity();
					(feature[num3][10142] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure).CnvPerSecureKeySelection2_A8369.CalculateValidity();
					num3++;
					num = (short)605290504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_321:
					num = (short)1667170310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38B:
					num = (short)2129002496;
					short num6 = num;
					num = (short)939655173;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x002357C8 File Offset: 0x002339C8
		internal static void ConIndividualAstroOtarIdValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)624558080;
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
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					int value;
					switch (num2)
					{
					case 0:
						if (secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Value)
						{
							num = (short)400621569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25B;
					case 1:
						goto IL_2E7;
					case 2:
						num = (short)704643072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (secureKMFProfile != null)
						{
							num = (short)262146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E9;
					case 4:
						try
						{
							num = (short)577634309;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2;
									if (!secureKMFProfile2.General.SecKmfProfGenIndependentKeyList_43597.Value)
									{
										num = (short)1011023874;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1930887171;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2 = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)650772480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2;
									secureKMFProfile2.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.SetValue(value);
									num = (short)612106246;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1172701188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_19D;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_C7;
									}
									continue;
								}
								IL_C9:
								num = (short)1267007489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C7:
								goto IL_C9;
							}
							IL_19D:
							goto IL_313;
						}
						finally
						{
							num = (short)1973878785;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1016377871;
								short num3 = num;
								num = (short)605336079;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1278803968;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_258;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_21F;
										}
										continue;
									case 2:
										enumerator.Dispose();
										goto IL_23F;
									}
									IL_21F:
									if (enumerator != null)
									{
										num = (short)862978050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_25A;
								}
								IL_23F:
								num = (short)1644953600;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_258:
							IL_25A:;
						}
						goto IL_25B;
					}
					goto IL_42;
					IL_25B:
					value = secureKMFProfile.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value;
					global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset;
					global::AcpCommonLib.ConstraintManager.Suspend();
					enumerator = collection.GetEnumerator();
					num = (short)268435460;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2E7:
				IL_2E9:
				num = (short)1105330176;
				short num4 = num;
				return;
				IL_313:
				num = (short)1587544065;
				if (num != 0)
				{
				}
				global::AcpCommonLib.ConstraintManager.Resume();
				return;
				IL_42:
				secureKMFProfile = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
				num = (short)1251737603;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00235B30 File Offset: 0x00233D30
		internal static bool ConNonVisibleWhenOpenFromRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2106851329;
			if (num != 0)
			{
			}
			num = (short)1099164527;
			short num2 = num;
			num = (short)1346431855;
			switch (num2 == num)
			{
			}
			num = (short)1924726784;
			short num3 = num;
			num = (short)988545024;
			if (num != 0)
			{
			}
			return !global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode;
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x00235BE0 File Offset: 0x00233DE0
		internal static bool ConSecureProfileGUIDIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)610664448;
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
				string value;
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
				bool value2;
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (string.IsNullOrEmpty(value))
						{
							num = (short)2010513408;
							short num3 = num;
							num = (short)1970274305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E5;
					case 1:
						return false;
					case 2:
						return true;
					case 3:
						if (!secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Applicable)
						{
							num = (short)1166540801;
							if (num != 0)
							{
							}
							num = (short)1480589314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1010171904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)1514012684;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_17C;
								case 1:
									num = (short)1468923907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)866058251;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (value2)
									{
										num = (short)1416364039;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2;
									secureKMFProfile2.General.SecKmfProfileSecureProfileGUID_43662.CalculateValidity();
									num = (short)618070026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)399114253;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1483997186;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2 = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)875102214;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2;
									if (secureKMFProfile2 != secureKMFProfile)
									{
										num = (short)1212940296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2;
									secureKMFProfile2.General.SecKmfProfileSecureProfileGUID_43662.Valid = false;
									result = false;
									num = (short)1960050688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1031798793;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2;
									if (secureKMFProfile2.General.SecKmfProfGenIndependentKeyList_43597.Value)
									{
										num = (short)1301413892;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
									goto IL_326;
								case 12:
									switch (0)
									{
									case 0:
										goto IL_150;
									}
									continue;
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2;
									if (secureKMFProfile2.General.SecKmfProfileSecureProfileGUID_43662.Value == value)
									{
										num = (short)961544193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1C9:
								num = (short)285343749;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_150:
								goto IL_1C9;
							}
							IL_17C:
							return result;
							IL_326:
							return true;
						}
						finally
						{
							num = (short)2883585;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1073247107;
								short num4 = num;
								num = (short)335836035;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1229127680;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_3E2;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_3A6;
										}
										continue;
									case 2:
										enumerator.Dispose();
										goto IL_3C8;
									}
									IL_3A6:
									if (enumerator != null)
									{
										num = (short)1749876738;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3E4;
								}
								IL_3C8:
								num = (short)682033152;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3E2:
							IL_3E4:;
						}
						goto IL_3E5;
					}
					goto IL_42;
					IL_3E5:
					enumerator = secureKMFProfileRecset.GetEnumerator();
					num = (short)273743876;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_42:
				secureKMFProfile = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
				secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
				value = secureKMFProfile.General.SecKmfProfileSecureProfileGUID_43662.Value;
				value2 = secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Value;
				num = (short)1293287427;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00236084 File Offset: 0x00234284
		internal static bool ConSecureProfileGUIDIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1180237826;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_105;
				case 1:
					num = (short)511377411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
				{
					if (global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						return true;
					}
					num = (short)421925397;
					short num3 = num;
					num = (short)296358421;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3F;
					default:
						num = (short)749535232;
						if (num != 0)
						{
						}
						num = (short)2026242048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_34;
				IL_3F:
				num = (short)714342400;
				short num4 = num;
				num = (short)680198145;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34:
				if (self is global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General)
				{
					goto IL_3F;
				}
				return false;
			}
			return true;
			IL_105:
			num = (short)1065943041;
			if (num != 0)
			{
			}
			return global::AcpCommonLib.AppInfoManager.ImportCopyOperation;
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x002361C4 File Offset: 0x002343C4
		internal static bool ConASTROOTARInfiniteUKEKRetentionIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = self as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General;
			short num;
			if (!general.RefSecureWide.Features.SecWideFeaturesInfiniteKeyRetention_A8292.Value)
			{
				num = (short)95813633;
				if (num != 0)
				{
				}
				num = (short)953236457;
				short num2 = num;
				num = (short)2043231209;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)669188096;
					if (num != 0)
					{
					}
					return true;
				}
			}
			num = (short)444268544;
			short num3 = num;
			return !general.SecKmfProfileInfiniteUKEKRetention_43651.Value;
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0023629C File Offset: 0x0023449C
		internal static bool ConHwSecIndependentKeyListOtarEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1987051520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::AcpBusinessLayer.AcpField<bool> secWideGeneralOTAREnable_A;
				for (;;)
				{
					IL_27:
					object obj;
					global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
					switch (num2)
					{
					case 0:
						num = (short)384368641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						obj = (parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
						goto IL_1C1;
					case 2:
						num = (short)1867710468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_20C;
					case 4:
						if (secWideGeneralSecureOperation_A.Value == 1)
						{
							num = (short)284884997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						goto IL_169;
					case 6:
					{
						if (parent is global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)
						{
							num = (short)1529217031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1278831481;
						short num3 = num;
						num = (short)421358457;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_20C;
						default:
						{
							num = (short)203751424;
							short num4 = num;
							num = (short)788594689;
							if (num != 0)
							{
							}
							num = (short)985530368;
							if (num != 0)
							{
							}
							num = (short)57212928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 7:
						obj = (parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
						goto IL_1C1;
					}
					goto IL_4E;
					IL_1C1:
					object obj2 = obj;
					secWideGeneralSecureOperation_A = obj2.ASTROOTARInformation.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = obj2.General;
					secWideGeneralOTAREnable_A = obj2.ASTROOTARInformation.RefSecureWide.General.SecWideGeneralOTAREnable_A7966;
					num = (short)1111752707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20C:
					if (!general.SecKmfProfGenIndependentKeyList_43597)
					{
						return false;
					}
					num = (short)1312686082;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_169:
				return secWideGeneralOTAREnable_A.Value;
				IL_4E:
				parent = self.Parent;
				num = (short)309592070;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x002364E4 File Offset: 0x002346E4
		internal static bool ConRadioInhibitViaAstroOtarIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_6C;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpListField secWideGeneralOTAROperation_;
			for (;;)
			{
				IL_0A:
				num = (short)440975343;
				short num2 = num;
				num = (short)277921775;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F0;
				default:
					num = (short)897974272;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_15C;
					case 1:
						num = (short)809369603;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1381236737;
						if (num != 0)
						{
						}
						if (secWideGeneralOTAROperation_.Applicable)
						{
							num = (short)267059201;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						if (secWideGeneralOTAROperation_.Value != 2)
						{
							num = (short)1120796672;
							short num4 = num;
							num = (short)489684992;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_6C;
				}
			}
			return true;
			IL_F0:
			return secWideGeneralOTAROperation_.Value == 3;
			IL_15C:
			goto IL_F0;
			IL_6C:
			secWideGeneralOTAROperation_ = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).General.SecWideGeneralOTAROperation_43700;
			num = (short)948240386;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00236650 File Offset: 0x00234850
		internal static bool ConIndividualAstroOtarRadioIdIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1514471424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				int value;
				int num3;
				for (;;)
				{
					IL_27:
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_A0;
					case 1:
						return false;
					case 2:
						goto IL_33C;
					case 3:
						goto IL_6F6;
					case 4:
						flag = false;
						goto IL_69B;
					case 5:
						if (value > 0)
						{
							num = (short)2000486402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.c();
						num = (short)1264123912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						flag = secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Value;
						goto IL_69B;
					}
					case 8:
						if (value > 0)
						{
							num = (short)2082537475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)967639041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						try
						{
							num = (short)467468299;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2;
								bool flag2;
								switch (num2)
								{
								case 0:
									num = (short)2063794179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)633929736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!secureKMFProfile2.General.SecKmfProfGenIndependentKeyList_43597.Value)
									{
										num = (short)1664811012;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
								{
									global::AcpBusinessLayer.AcpSimpleRangeField secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A = secureKMFProfile2.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285;
									num = (short)806420489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1097465866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									flag2 = false;
									goto IL_47F;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (secureKMFProfile2 != secureKMFProfile)
									{
										goto IL_56A;
									}
									break;
								}
								case 8:
								{
									global::AcpBusinessLayer.AcpSimpleRangeField secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A;
									flag2 = (secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A.Value < num3);
									goto IL_47F;
								}
								case 9:
								{
									global::AcpBusinessLayer.AcpSimpleRangeField secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A;
									if (secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A.Value > 0)
									{
										num = (short)543424514;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1711205454;
									short num4 = num;
									num = (short)826731598;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_56A;
									default:
										num = (short)2016149504;
										if (num != 0)
										{
										}
										num = (short)1711472646;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									goto IL_60A;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_413;
									}
									continue;
								case 12:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)494469125;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									secureKMFProfile2 = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)1333592071;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_413;
								IL_47F:
								bool valid = flag2;
								secureKMFProfile2.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Valid = valid;
								num = (short)652738561;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_500:
								num = (short)589037580;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_413:
								goto IL_500;
								IL_56A:
								num = (short)1956249600;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_60A:
							goto IL_304;
						}
						finally
						{
							num = (short)526778369;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_678;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_641;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)108658688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_641:
								if (enumerator == null)
								{
									break;
								}
								num = (short)622329858;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_678:;
						}
						goto IL_67B;
						IL_304:
						num = (short)1579679749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Applicable)
						{
							num = (short)1935540237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E6;
					}
					case 11:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						try
						{
							num = (short)1296564233;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3;
									if (secureKMFProfile3 != secureKMFProfile)
									{
										num = (short)1553989636;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3;
									if (!secureKMFProfile3.General.SecKmfProfGenIndependentKeyList_43597.Value)
									{
										num = (short)1981808647;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)661454851;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_273;
								case 4:
									num = (short)945422337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_209;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2037645314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3 = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)199163904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1474756616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3;
									if (secureKMFProfile3.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value != value)
									{
										num = (short)805371914;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_11D;
									}
									continue;
								case 10:
									result = false;
									num = (short)772866053;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11F:
								num = (short)592969734;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11D:
								goto IL_11F;
							}
							IL_209:
							return result;
							IL_273:
							goto IL_A5;
						}
						finally
						{
							num = (short)1971257345;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2E3;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2AB;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)539164672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2AB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1022689282;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E3:;
						}
						goto IL_2E6;
						IL_A5:
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
						enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)2087649289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
						{
							num = (short)761397248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset = global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset;
						value = secureKMFProfile.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value;
						num = (short)258867210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)1969618951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66;
					IL_2E6:
					num = (short)1727660036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69B:
					if (flag)
					{
						num = (short)176750598;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)559808523;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_A0:
				num = (short)655949825;
				if (num != 0)
				{
				}
				return true;
				IL_33C:
				IL_67B:
				return value < num3;
				IL_6F6:
				num = (short)360972288;
				short num5 = num;
				return value < num3;
				IL_66:
				num3 = 9999999;
				num = (short)391446540;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00236E38 File Offset: 0x00235038
		internal static bool ConSecKmfIndOtarRadioIdEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation astrootarinformation = self as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation;
			short num;
			if (astrootarinformation == null)
			{
				num = (short)1701564775;
				short num2 = num;
				num = (short)859951463;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)219348992;
					if (num != 0)
					{
					}
					num = (short)30408705;
					if (num != 0)
					{
					}
					return true;
				}
			}
			num = (short)2037645312;
			short num3 = num;
			return !astrootarinformation.RefSecureWide.ASTROOTAR.SecWideASTROOTARIndividualASTROOTARRadioID_A8284.Visible;
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00236F08 File Offset: 0x00235108
		private static void c()
		{
			short num = (short)181207041;
			if (num != 0)
			{
			}
			num = (short)1187708928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7D;
				}
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
				int num4;
				for (;;)
				{
					IL_4E:
					object obj;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2;
					switch (num2)
					{
					case 0:
						if (secureKMFProfileRecset.Any(delegate(global::AcpBusinessLayer.FeatureNode x)
						{
							short num6 = (short)116391937;
							int num7 = (int)((global::System.IntPtr)num6);
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general;
							bool? flag;
							for (;;)
							{
								switch (num7)
								{
								case 0:
									return false;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_31;
									}
									continue;
								case 2:
									goto IL_11A;
								}
								IL_31:
								num6 = (short)2123563009;
								if (num6 != 0)
								{
								}
								num6 = (short)1187899570;
								short num8 = num6;
								num6 = (short)349104306;
								switch ((num8 == num6) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num6 = (short)139853824;
									if (num6 != 0)
									{
									}
									num6 = (short)319619072;
									short num9 = num6;
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile4 = x as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
									if (secureKMFProfile4 != null)
									{
										general = secureKMFProfile4.General;
										if (general == null)
										{
											flag = null;
											num6 = (short)74776578;
											num7 = (int)((global::System.IntPtr)num6);
											continue;
										}
										goto IL_11D;
									}
									break;
								}
								}
								num6 = (short)524156928;
								num7 = (int)((global::System.IntPtr)num6);
							}
							return false;
							IL_11A:
							bool? flag2 = flag;
							goto IL_12E;
							IL_11D:
							flag2 = new bool?(general.SecKmfProfGenIndependentKeyList_43597.Value);
							IL_12E:
							bool? flag3 = flag2;
							bool flag4 = false;
							return flag3.GetValueOrDefault() == flag4 & flag3 != null;
						}))
						{
							num = (short)26214402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)321257476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_539;
					case 3:
					{
						num = (short)68616192;
						short num3 = num;
						obj = null;
						goto IL_58D;
					}
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						try
						{
							num = (short)290717696;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_171;
									}
									continue;
								case 1:
									num = (short)1383989251;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1799880711;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_271;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (secureKMFProfile.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value != secureKMFProfile2.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value)
									{
										num = (short)1627521025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)414711812;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)630390786;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)2122907656;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_28E;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (!secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597)
									{
										num = (short)882180101;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_173:
								num = (short)542310406;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_171:
								goto IL_173;
							}
							IL_271:
							return;
							IL_28E:;
						}
						finally
						{
							num = (short)590610433;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2F8;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2C3;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)2022178816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2C3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)739180546;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F8:;
						}
						enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)483721224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (secureKMFProfile2 != null)
						{
							num = (short)1926299649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num = (short)1992949763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						obj = secureKMFProfileRecset.First(delegate(global::AcpBusinessLayer.FeatureNode x)
						{
							short num6 = (short)653590529;
							int num7 = (int)((global::System.IntPtr)num6);
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general;
							for (;;)
							{
								switch (num7)
								{
								case 0:
									goto IL_EE;
								case 1:
									num6 = (short)1485897729;
									if (num6 != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_58;
									}
									continue;
								case 2:
									goto IL_115;
								}
								IL_58:
								num6 = (short)1596574388;
								short num8 = num6;
								num6 = (short)2146814644;
								switch ((num8 == num6) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num6 = (short)746323968;
									if (num6 != 0)
									{
									}
									num6 = (short)1679294464;
									short num9 = num6;
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile4 = x as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
									if (secureKMFProfile4 != null)
									{
										general = secureKMFProfile4.General;
										if (general == null)
										{
											num6 = (short)1859977218;
											num7 = (int)((global::System.IntPtr)num6);
											continue;
										}
										goto IL_118;
									}
									break;
								}
								}
								num6 = (short)855769088;
								num7 = (int)((global::System.IntPtr)num6);
							}
							IL_EE:
							global::AcpBusinessLayer.AcpField<bool> obj2 = null;
							goto IL_11F;
							IL_115:
							obj2 = null;
							goto IL_11F;
							IL_118:
							obj2 = general.SecKmfProfGenIndependentKeyList_43597;
							IL_11F:
							return !obj2;
						});
						goto IL_58D;
					case 8:
						try
						{
							num = (short)438763525;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)487391236;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3 = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)1588723713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3;
									if (!secureKMFProfile3.General.SecKmfProfGenIndependentKeyList_43597)
									{
										num = (short)9568258;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3;
									int value = secureKMFProfile3.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value;
									num = (short)1171652615;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)468385798;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_362;
									}
									continue;
								case 6:
									goto IL_47A;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3;
									int value;
									secureKMFProfile3.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Valid = (value > 0 && value < num4);
									num = (short)2091122691;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_421:
								num = (short)1497890816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_362:
								goto IL_421;
							}
							IL_47A:
							return;
						}
						finally
						{
							num = (short)1759631831;
							short num5 = num;
							num = (short)1078450647;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_51F:
								num = (short)1009188864;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1352597504;
								if (num != 0)
								{
								}
								num = (short)1082195969;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_536;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4FF;
									}
									continue;
								case 2:
									goto IL_517;
								}
								IL_4FF:
								if (enumerator == null)
								{
									goto IL_538;
								}
								num = (short)1879703554;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_517:
							enumerator.Dispose();
							goto IL_51F;
							IL_536:
							IL_538:;
						}
						goto IL_539;
					case 9:
						if (secureKMFProfileRecset == null)
						{
							num = (short)1190723590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1592655879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7D;
					IL_539:
					num = (short)729088009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58D:
					secureKMFProfile2 = (obj as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
					num = (short)2046427141;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7D:
				num4 = 9999999;
				secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
				num = (short)1350434816;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4E;
			}
			}
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00237584 File Offset: 0x00235784
		internal static bool ConRadioInhibitViaAstroOtarIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1615069184;
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
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2;
				bool value;
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
				global::AcpBusinessLayer.AcpField<bool> secWideASTROOTARRadioInhibitviaASTROOTAR_A;
				for (;;)
				{
					IL_27:
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)322502656;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_173;
									}
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (!secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Value)
									{
										num = (short)297467907;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1907490817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									secureKMFProfile.ASTROOTARInformation.SecKmfProfRadioInhibitViaASTROOTAR_43690.Valid = true;
									num = (short)2060124164;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1893072903;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (secureKMFProfile != secureKMFProfile2)
									{
										num = (short)2122776578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_280;
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1369309189;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)2136604678;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1B6:
								num = (short)1739980808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_173:
								goto IL_1B6;
							}
							IL_280:
							goto IL_5A3;
						}
						finally
						{
							num = (short)1056768001;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_2F0;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2B8;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1126170624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2B8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1848508418;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F0:;
						}
						goto IL_2F3;
					case 1:
						flag = secureKMFProfile2.General.SecKmfProfGenIndependentKeyList_43597.Value;
						goto IL_67C;
					case 2:
						if (!secureKMFProfile2.ASTROOTARInformation.SecKmfProfRadioInhibitViaASTROOTAR_43690.Visible)
						{
							num = (short)393478153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F3;
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						try
						{
							num = (short)703201281;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1203175431;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_390;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1725628421;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3 = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)471990282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1950810120;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_3F5;
								case 5:
									num = (short)1905131529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									result = false;
									num = (short)1458307076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3;
									if (secureKMFProfile3.ASTROOTARInformation.SecKmfProfRadioInhibitViaASTROOTAR_43690.Value != value)
									{
										num = (short)2009661446;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3;
									if (!secureKMFProfile3.General.SecKmfProfGenIndependentKeyList_43597.Value)
									{
										num = (short)676069376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									goto IL_4E5;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3;
									if (secureKMFProfile3 != secureKMFProfile2)
									{
										num = (short)1431830531;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_48D:
								num = (short)195559426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_390:
								goto IL_48D;
							}
							IL_3F5:
							return result;
							IL_4E5:
							goto IL_657;
						}
						finally
						{
							num = (short)928526610;
							short num3 = num;
							num = (short)1500918034;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_58B:
								num = (short)680984576;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)303562752;
								if (num != 0)
								{
								}
								num = (short)784728065;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5A0;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_569;
									}
									continue;
								case 2:
									goto IL_582;
								}
								IL_569:
								if (enumerator == null)
								{
									goto IL_5A2;
								}
								num = (short)269877250;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_582:
							enumerator.Dispose();
							goto IL_58B;
							IL_5A0:
							IL_5A2:;
						}
						goto IL_5A3;
						IL_657:
						enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)541392896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						if (flag2)
						{
							num = (short)348651528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)1455226883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.b())
						{
							num = (short)368443402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2049572868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1909587969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						flag = false;
						goto IL_67C;
					case 8:
						goto IL_5E4;
					case 9:
						return true;
					case 10:
						goto IL_6D8;
					case 11:
					{
						if (secureKMFProfile2.General.SecKmfProfGenIndependentKeyList_43597.Applicable)
						{
							num = (short)927399942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)61931520;
						short num4 = num;
						num = (short)2111242241;
						if (num != 0)
						{
						}
						num = (short)929693703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_5E;
					IL_2F3:
					num = (short)215416843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_67C:
					flag2 = flag;
					secWideASTROOTARRadioInhibitviaASTROOTAR_A = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).ASTROOTAR.SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834;
					num = (short)1749942277;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_5A3:
				secWideASTROOTARRadioInhibitviaASTROOTAR_A.Value = value;
				return true;
				IL_5E4:
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.a();
				return true;
				IL_6D8:
				secWideASTROOTARRadioInhibitviaASTROOTAR_A.Value = false;
				return true;
				IL_5E:
				secureKMFProfile2 = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
				secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
				value = secureKMFProfile2.ASTROOTARInformation.SecKmfProfRadioInhibitViaASTROOTAR_43690.Value;
				num = (short)186122242;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00237CB4 File Offset: 0x00235EB4
		private static bool b()
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1053949956;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						result = false;
						num = (short)753074178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!enumerator.MoveNext())
						{
							num = (short)1153433606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1347354627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_F4;
					case 3:
						if (!((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current).General.SecKmfProfGenIndependentKeyList_43597.Value)
						{
							num = (short)1387331584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 5:
						goto IL_111;
					case 6:
						num = (short)713162757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5B:
					num = (short)290455553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_59:
					goto IL_5B;
				}
				IL_F4:
				goto IL_1ED;
				IL_111:
				return true;
			}
			finally
			{
				num = (short)44634781;
				short num3 = num;
				num = (short)1129452189;
				int num2;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1D6:
					num = (short)683343872;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)322109441;
					if (num != 0)
					{
					}
					num = (short)1453981696;
					if (num != 0)
					{
					}
					num = (short)1058734081;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1EA;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1B7;
						}
						continue;
					case 2:
						goto IL_1CE;
					}
					IL_1B7:
					if (enumerator == null)
					{
						goto IL_1EC;
					}
					num = (short)1515257858;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1CE:
				enumerator.Dispose();
				goto IL_1D6;
				IL_1EA:
				IL_1EC:;
			}
			IL_1ED:
			num = (short)960430080;
			short num4 = num;
			return result;
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00237EE8 File Offset: 0x002360E8
		private static void a()
		{
			short num = (short)475594752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile2;
					global::System.Collections.Generic.IEnumerable<global::AcpBusinessLayer.FeatureNode> source;
					global::System.Func<global::AcpBusinessLayer.FeatureNode, bool> predicate;
					object obj;
					switch (num2)
					{
					case 0:
						if (secureKMFProfileRecset == null)
						{
							num = (short)422772742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)210894850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						try
						{
							num = (short)97583108;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (!secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597)
									{
										num = (short)485490690;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									secureKMFProfile.ASTROOTARInformation.SecKmfProfRadioInhibitViaASTROOTAR_43690.Valid = true;
									num = (short)217841665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)630521861;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_101;
									}
									continue;
								case 5:
									goto IL_1D4;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)630194179;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)1792999424;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_12C:
								num = (short)1687748614;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_101:
								goto IL_12C;
							}
							IL_1D4:
							goto IL_528;
						}
						finally
						{
							num = (short)538474106;
							short num3 = num;
							num = (short)417691258;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_26F:
								enumerator.Dispose();
								num = (short)1996750848;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1626537984;
								if (num != 0)
								{
								}
								num = (short)1544486913;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_28C;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_257;
									}
									continue;
								case 2:
									goto IL_26F;
								}
								IL_257:
								if (enumerator == null)
								{
									break;
								}
								num = (short)951975938;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_28C:;
						}
						goto Block_4;
						IL_528:
						num = (short)233504769;
						if (num != 0)
						{
						}
						(global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).ASTROOTAR.SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Value = secureKMFProfile2.ASTROOTARInformation.SecKmfProfRadioInhibitViaASTROOTAR_43690.Value;
						num = (short)178913280;
						short num4 = num;
						num = (short)1138884615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						source = secureKMFProfileRecset;
						if ((predicate = global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.<>c.<>9__27_0) == null)
						{
							predicate = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.<>c.<>9__27_0 = delegate(global::AcpBusinessLayer.FeatureNode x)
							{
								short num5 = (short)266272769;
								int num6 = (int)((global::System.IntPtr)num5);
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general;
								for (;;)
								{
									switch (num6)
									{
									case 0:
										goto IL_CB;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_31;
										}
										continue;
									case 2:
										goto IL_F0;
									}
									IL_31:
									num5 = (short)1652689910;
									short num7 = num5;
									num5 = (short)1264258038;
									switch ((num7 == num5) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num5 = (short)1440677888;
										if (num5 != 0)
										{
										}
										global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile4 = x as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
										if (secureKMFProfile4 != null)
										{
											general = secureKMFProfile4.General;
											if (general == null)
											{
												num5 = (short)94896130;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											goto IL_11B;
										}
										break;
									}
									}
									num5 = (short)1906507776;
									short num8 = num5;
									num5 = (short)1487732736;
									num6 = (int)((global::System.IntPtr)num5);
								}
								IL_CB:
								global::AcpBusinessLayer.AcpField<bool> obj2 = null;
								goto IL_122;
								IL_F0:
								num5 = (short)1642266625;
								if (num5 != 0)
								{
								}
								obj2 = null;
								goto IL_122;
								IL_11B:
								obj2 = general.SecKmfProfGenIndependentKeyList_43597;
								IL_122:
								return !obj2;
							});
							goto IL_461;
						}
						goto IL_461;
					case 3:
						obj = null;
						goto IL_48C;
					case 4:
						enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)1183776776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (secureKMFProfile2 != null)
						{
							num = (short)7274500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num = (short)1510277123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return;
					case 8:
						goto IL_28F;
					}
					goto IL_52;
					IL_48C:
					secureKMFProfile2 = (obj as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
					num = (short)1500577797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_461:
					obj = source.First(predicate);
					goto IL_48C;
					Block_4:
					try
					{
						IL_28F:
						num = (short)1993277440;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2DA;
								}
								continue;
							case 1:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3;
								if (!secureKMFProfile3.General.SecKmfProfGenIndependentKeyList_43597)
								{
									num = (short)1055522819;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3;
								if (secureKMFProfile3.ASTROOTARInformation.SecKmfProfRadioInhibitViaASTROOTAR_43690.Value != secureKMFProfile2.ASTROOTARInformation.SecKmfProfRadioInhibitViaASTROOTAR_43690.Value)
								{
									num = (short)1131806728;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								num = (short)1968701442;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)1956708359;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)974192644;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile3 = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
								num = (short)1969487873;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_2F1;
							case 7:
								goto IL_3EF;
							case 8:
								num = (short)747634694;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_348:
							num = (short)692584453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2DA:
							goto IL_348;
						}
						IL_2F1:
						break;
						IL_3EF:
						goto IL_4CC;
					}
					finally
					{
						num = (short)2045050881;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1265041410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_427;
								}
								continue;
							case 2:
								goto IL_45E;
							}
							IL_427:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1007550464;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_45E:;
					}
					goto IL_461;
					IL_4CC:
					enumerator = secureKMFProfileRecset.GetEnumerator();
					num = (short)1721106433;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_52:
				secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
				num = (short)2112618496;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x002384F4 File Offset: 0x002366F4
		internal static bool ConOTARTransportIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			short num2;
			global::AcpBusinessLayer.AcpListField secWideGeneralOTAROperation_;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E4;
				case 1:
					if (secWideGeneralSecureOperation_A.Value == 3)
					{
						num2 = (short)2033451010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					num2 = (short)2065039361;
					if (num2 != 0)
					{
					}
					num2 = (short)1499725831;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)2005602775;
					short num3 = num2;
					num2 = (short)2139361751;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CD;
					default:
						num2 = (short)128188416;
						if (num2 != 0)
						{
						}
						goto IL_A9;
					}
					break;
				}
				case 4:
				{
					num2 = (short)484900864;
					short num4 = num2;
					num2 = (short)101974017;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (secWideGeneralOTAROperation_.Value != 2)
					{
						goto IL_CD;
					}
					return true;
				case 6:
					if (secWideGeneralSecureOperation_A.Value != 1)
					{
						num2 = (short)425459716;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A9;
				case 7:
					if (secureKMFProfile.General.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value)
					{
						num2 = (short)1821769731;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_30;
				IL_A9:
				num2 = (short)611319813;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_CD:
				num2 = (short)1302003712;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E4:
			return secWideGeneralOTAROperation_.Value == 3;
			IL_30:
			secureKMFProfile = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
			secWideGeneralSecureOperation_A = secureKMFProfile.General.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			secWideGeneralOTAROperation_ = secureKMFProfile.General.RefSecureWide.General.SecWideGeneralOTAROperation_43700;
			num2 = (short)1483014150;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00238714 File Offset: 0x00236914
		internal static bool ConKMFBroadbandIdIsApplicableIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			short num2;
			global::AcpBusinessLayer.AcpListField secWideGeneralOTAROperation_;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (secWideGeneralSecureOperation_A.Value != 1)
					{
						num2 = (short)1712521224;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EA;
				case 1:
					num2 = (short)1817706503;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_EA;
				case 3:
					goto IL_E5;
				case 4:
					if (secWideGeneralOTAROperation_.Value != 2)
					{
						num2 = (short)1118044161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_200;
				case 5:
					if (secWideGeneralSecureOperation_A.Value == 3)
					{
						num2 = (short)1905786889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					if (secureKMFProfile.General.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value)
					{
						num2 = (short)1833762818;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					IL_C2:
					if (secWideGeneralOTAROperation_.Value == 3)
					{
						num2 = (short)155385859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 8:
					num2 = (short)1153761285;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1919090694;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_EA:
				num2 = (short)509040373;
				short num3 = num2;
				num2 = (short)135550709;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C2;
				default:
				{
					num2 = (short)292618241;
					if (num2 != 0)
					{
					}
					num2 = (short)1585381376;
					if (num2 != 0)
					{
					}
					num2 = (short)863895552;
					short num4 = num2;
					num2 = (short)662241284;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
				}
			}
			IL_E5:
			IL_200:
			return secureKMFProfile.DataTransport.SecKmfProfDataTransportOTARTransport.Value != 0;
			IL_38:
			secureKMFProfile = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
			secWideGeneralSecureOperation_A = secureKMFProfile.General.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			secWideGeneralOTAROperation_ = secureKMFProfile.General.RefSecureWide.General.SecWideGeneralOTAROperation_43700;
			num2 = (short)1427374080;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00238988 File Offset: 0x00236B88
		internal static bool ConKMFBroadbandIdIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)347304849;
					short num3 = num2;
					num2 = (short)2046522257;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
						num2 = (short)1006043137;
						if (num2 != 0)
						{
						}
						num2 = (short)629342208;
						if (num2 != 0)
						{
						}
						num2 = (short)977731585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (string.IsNullOrEmpty(secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFBroadbandId.Value))
					{
						num2 = (short)1486422019;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					goto IL_6A;
				case 3:
					return false;
				}
				goto IL_20;
				IL_6A:
				if (!secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFBroadbandId.Applicable)
				{
					return true;
				}
				num2 = (short)1868955648;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_20:
			secureKMFProfile = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
			num2 = (short)1479344128;
			short num4 = num2;
			num2 = (short)1565720578;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
