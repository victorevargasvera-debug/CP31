using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Zone_Channel_Assignment;
using Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ScanList;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.Tts;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x0200003B RID: 59
	public static class ZoneChannelAssignmentConstraints
	{
		// Token: 0x0600019E RID: 414 RVA: 0x0001D130 File Offset: 0x0001B330
		internal static bool ConZnTextSizeNotNone(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1325676168;
			short num2 = num;
			num = (short)681588360;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2010185728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1737162752;
			if (num != 0)
			{
			}
			num = (short)2068971521;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).RefDisplayAndMenu.General.DispMenuGeneralZoneTextSize_A8167.Value != 0;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001D1F4 File Offset: 0x0001B3F4
		public static bool ConIsZnChanAssignChanPersTypeTrk(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)211222528;
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
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					switch (num2)
					{
					case 0:
						enumerator = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ReferencingNodes.GetEnumerator();
						num = (short)1719140356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)308215816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C0;
					case 2:
						try
						{
							num = (short)1169293313;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2EA;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_18B;
									}
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality != null)
									{
										num = (short)1340538884;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1688403973;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									num = (short)1678770185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner == self.Parent)
									{
										num = (short)1642987528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1673265162;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)2109276162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.CallConstraints();
									num = (short)73531398;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner != null)
									{
										num = (short)302710787;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									num = (short)1339293696;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_295:
								num = (short)987627527;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18B:
								goto IL_295;
							}
							IL_2EA:
							goto IL_C0;
						}
						finally
						{
							num = (short)332089236;
							short num3 = num;
							num = (short)1939294100;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_386:
								enumerator.Dispose();
								num = (short)830406658;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)159776768;
								if (num != 0)
								{
								}
								num = (short)298647552;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_36D;
									}
									continue;
								case 1:
									goto IL_386;
								case 2:
									goto IL_3A3;
								}
								IL_36D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1339097089;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A3:;
						}
						goto Block_4;
					case 3:
						if (trunkingPersonalityRecset != null)
						{
							num = (short)1639055365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C1;
					case 4:
						goto IL_5CB;
					case 5:
						goto IL_745;
					case 6:
						if (channelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 1)
						{
							num = (short)156958720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80A;
					case 7:
						goto IL_3A6;
					case 8:
						enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)1556611074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_52;
					IL_C0:
					channelAssignmentListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
					num = (short)331087872;
					short num4 = num;
					num = (short)82051078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_745:
					enumerator = trunkingPersonalityRecset.GetEnumerator();
					num = (short)633733127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_5:
					try
					{
						IL_5CB:
						num = (short)2119368705;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpBusinessLayer.FeatureNode featureNode;
								(featureNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner).ScanListInnerSection.ScanLstScanListChannel_A7620.CalculateValidity();
								num = (short)1634140165;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_60E;
								}
								continue;
							case 2:
								num = (short)800391174;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1411317762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
								num = (short)2095120388;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								global::AcpBusinessLayer.FeatureNode featureNode;
								if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)
								{
									num = (short)519831552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								goto IL_6D6;
							}
							IL_680:
							num = (short)1942093827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_60E:
							goto IL_680;
						}
						IL_6D6:
						break;
					}
					finally
					{
						num = (short)736821248;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_70D;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)789708802;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_742;
							}
							IL_70D:
							if (enumerator == null)
							{
								break;
							}
							num = (short)616759297;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_742:;
					}
					goto IL_745;
					Block_4:
					try
					{
						IL_3A6:
						num = (short)1877409793;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_55B;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_3F8;
								}
								continue;
							case 3:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
								if (trunkingPersonality != null)
								{
									num = (short)2015166470;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
								if (channelAssignmentListInner2 != null)
								{
									num = (short)125566985;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)952893448;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
								num = (short)2075787267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2 = trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
								num = (short)194772996;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
								if (channelAssignmentListInner2 == self.Parent)
								{
									num = (short)2008285194;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
								num = (short)1902903296;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								num = (short)479920135;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
								trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.CallConstraints();
								num = (short)224919554;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_3FA:
							num = (short)619905029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3F8:
							goto IL_3FA;
						}
						IL_55B:
						goto IL_7C1;
					}
					finally
					{
						num = (short)1777729536;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_592;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)612827138;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_5C8;
							}
							IL_592:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1994260481;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_5C8:;
					}
					goto Block_5;
					IL_7C1:
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)1731395585;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_80A:
				return channelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 1;
				IL_52:
				trunkingPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
				num = (short)1539964929;
				if (num != 0)
				{
				}
				num = (short)1184432131;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001DA68 File Offset: 0x0001BC68
		internal static bool ConChannelTypeIsTrkAndFppEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)658243584;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				bool result;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					goto IL_288;
				case 2:
					try
					{
						num = (short)96600066;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10115] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection).ZnChanCfgChannelsChannelType_A22241.Value == 1)
								{
									num = (short)461242371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								num = (short)1240793093;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_15A;
								}
								continue;
							case 3:
								result = false;
								num = (short)949551110;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num = (short)1445527553;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)175636480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_21B;
							case 6:
								goto IL_1FE;
							}
							IL_1AC:
							num = (short)1533673476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_15A:
							goto IL_1AC;
						}
						IL_1FE:
						return result;
						IL_21B:
						return true;
					}
					finally
					{
						num = (short)1409417216;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_250;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1244659714;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_285;
							}
							IL_250:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1795162113;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_285:;
					}
					goto IL_288;
				}
				IL_30:
				num = (short)1742340097;
				if (num != 0)
				{
				}
				num = (short)2140251731;
				short num3 = num;
				num = (short)1846388307;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				case 1:
					break;
				default:
				{
					num = (short)501088256;
					short num4 = num;
					break;
				}
				}
				num = (short)314048512;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.FPPProtection fppprotection = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.FPPProtection;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset = self.Parent[10114].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset;
				if (fppprotection.ZnChanCfgFPPProtectionFPPEnable_A19562.Value)
				{
					num = (short)381550593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_288:
				enumerator = channelAssignmentListInnerRecset.GetEnumerator();
				num = (short)328925186;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001DD40 File Offset: 0x0001BF40
		internal static bool conValidateChanTextLength(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1499196072;
			short num2 = num;
			num = (short)1269754536;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
			global::AcpBusinessLayer.AcpKeyField znChanCfgChannelsChannelName_A;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)432275456;
				if (num != 0)
				{
				}
				channelAssignmentListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
				znChanCfgChannelsChannelName_A = channelAssignmentListInnerSection.ZnChanCfgChannelsChannelName_A7659;
				if (znChanCfgChannelsChannelName_A.Value == null)
				{
					num = (short)1994194945;
					if (num != 0)
					{
					}
					num = (short)1296695296;
					short num3 = num;
					return false;
				}
				break;
			}
			return znChanCfgChannelsChannelName_A.Value.Length <= channelAssignmentListInnerSection.RefDisplayAndMenu.General.DispMenuGeneralChannelTextSize_A7663.Value;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001DE28 File Offset: 0x0001C028
		public static bool ConTalkgroupSelectionIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1869742080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_10A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::AcpBusinessLayer.AcpListField znChanCfgChannelsChannelType_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
				global::AcpBusinessLayer.AcpRecRefField znChanCfgChannelsTalkgroup_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (trunkingSystem != null)
						{
							num = (short)1200226333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						if (index == 65535)
						{
							num = (short)1294467079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F9;
					case 2:
						goto IL_862;
					case 3:
						num = (short)1476526092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::AcpCommonLib.IAcpFeatureNode parent = znChanCfgChannelsChannelType_A.Parent.Parent.Parent.ParentSection.Parent;
						num = (short)1811939376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)22741010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAnnouncementGroup_A7444.Value != 0)
						{
							num = (short)280494094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						return false;
					case 8:
						num = (short)2089418797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1799094325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (index == 65535)
						{
							num = (short)1834418189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
						num = (short)2071396373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (trunkingSystem.Features.TrkSysFeaturesChannel_A7647.ReferencedNode == self.Parent)
						{
							num = (short)868876290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 13:
						num = (short)447873074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return true;
					case 15:
						num = (short)1219362846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (trunkingPersonality != null)
						{
							num = (short)211288107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						num = (short)1425997825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (1 == trunkingPersonality.General.TrkPerGeneralDisableTransmitMode_A41742.Value)
						{
							num = (short)1998848017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F9;
					case 19:
						num = (short)1408565283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						return true;
					case 21:
						if (trunkingSystem.Features.TrkSysFeaturesDynamicRegroupingEnable_A7969.Value)
						{
							num = (short)2087321619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 22:
						trunkingSystem.Features.TrkSysFeaturesChannel_A7647.CalculateApplicability();
						trunkingSystem.Features.TrkSysFeaturesChannel_A7647.CalculateValidity();
						num = (short)2099970099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_154;
					case 24:
						if (trunkingSystem.Features.TrkSysFeaturesChannel_A7647_Valid)
						{
							num = (short)55771158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 25:
						goto IL_1BD;
					case 26:
						if (index == 0)
						{
							num = (short)781975567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1816395786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (znChanCfgChannelsChannelType_A.Value == 1)
						{
							num = (short)124911657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_349;
					case 28:
						if (trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.Value == 2)
						{
							num = (short)357892128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1944715297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)189202456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (trunkingSystem != null)
						{
							num = (short)800391177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BD;
					case 31:
						if (znChanCfgChannelsChannelType_A.Value == 0)
						{
							num = (short)1913847850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)218431515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1503854644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAnnouncementGroup_A7444_Valid)
						{
							num = (short)468844578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 34:
						num = (short)1970077702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (trunkingSystem.Features.TrkSysFeaturesChannel_A7647.ReferencedNode != null)
						{
							num = (short)1905655811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 36:
						num = (short)5832744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						num = (short)1992672714;
						short num3 = num;
						num = (short)1917961674;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_154;
						default:
							num = (short)1743060992;
							if (num != 0)
							{
							}
							trunkingSystem.Features.TrkSysFeaturesChannel_A7647.CalculateApplicability();
							trunkingSystem.Features.TrkSysFeaturesChannel_A7647.CalculateValidity();
							num = (short)1995309081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 38:
						num = (short)1159200812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (trunkingPersonality == null)
						{
							num = (short)2105278511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_349;
					case 40:
						if (znChanCfgChannelsTalkgroup_A != null)
						{
							num = (short)1198981166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53C;
					case 41:
						num = (short)451477543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						return true;
					case 43:
						num = (short)1864040474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (index != 65535)
						{
							num = (short)14024740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53C;
					case 45:
					{
						num = (short)1132855296;
						short num4 = num;
						if (trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAnnouncementGroup_A7444.Value != 4095)
						{
							num = (short)1143799828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 46:
						num = (short)1669988352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						return true;
					case 48:
						if (znChanCfgChannelsChannelType_A.Parent is global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection)
						{
							num = (short)1897398283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 49:
						if (index != 0)
						{
							num = (short)1015480358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53C;
					case 50:
						if (trunkingSystem != null)
						{
							num = (short)1061027844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 51:
						goto IL_537;
					case 52:
						if (trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAnnouncementGroup_A7444_Valid)
						{
							num = (short)337707016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 53:
						if (trunkingSystem.Features.TrkSysFeaturesChannel_A7647_Valid)
						{
							num = (short)2069561381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BD;
					case 54:
						goto IL_27E;
					}
					goto IL_10A;
					IL_154:
					if (trunkingPersonality != null)
					{
						num = (short)274792453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27E;
					IL_1BD:
					num = (short)1178861596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27E:
					num = (short)28573727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_349:
					num = (short)308150321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53C:
					num = (short)604241936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F9:
					trunkingSystem = (trunkingPersonality.General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
					num = (short)1531838465;
					if (num != 0)
					{
					}
					num = (short)2053505078;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_537:
				return true;
				IL_862:
				trunkingSystem.Features.TrkSysFeaturesChannel_A7647.CalculateApplicability();
				trunkingSystem.Features.TrkSysFeaturesChannel_A7647.CalculateValidity();
				return true;
				IL_10A:
				global::AcpCommonLib.FeatureManager.GetFeature(2057);
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection;
				znChanCfgChannelsChannelType_A = channelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241;
				znChanCfgChannelsTalkgroup_A = channelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276;
				trunkingPersonality = (channelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality);
				trunkingSystem = null;
				num = (short)1414070295;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001E7D8 File Offset: 0x0001C9D8
		internal static bool ConIsVoiceAnnouncementVoiceControlNotConfusable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 2;
			short num = (short)2095972352;
			switch (num)
			{
			default:
			{
				num = (short)1302200328;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				global::System.Collections.Generic.List<string> list2;
				for (;;)
				{
					global::System.Collections.Generic.List<string> list;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
					string text;
					global::System.Func<global::AcpCommonLib.IAcpFeatureSection, bool> func;
					string text2;
					string text3;
					global::System.Func<global::AcpCommonLib.IAcpFeatureSection, bool> func2;
					string value;
					global::AcpCommonLib.IAcpRecordset a_2;
					switch (num2)
					{
					case 0:
						if (list != null)
						{
							num = (short)1736769574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B6;
					case 1:
						num3 = channelAssignmentListInnerSection.ChannelAnnouncementID_A20175.Value;
						num = (short)2113798167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::AcpBusinessLayer.AcpField<string> acpField;
						if (acpField == null)
						{
							num = (short)775094297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)290390034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return false;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone;
						if (zone == null)
						{
							num = (short)1702035488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpField<string> acpField = zone.VCZoneAnnouncement_A21515;
						num = (short)1956118543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						return true;
					case 6:
						text = null;
						goto IL_3E0;
					case 7:
						func = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.<>c.<>9__8_0 = delegate(global::AcpCommonLib.IAcpFeatureSection k)
						{
							short num6 = (short)1968898049;
							if (num6 != 0)
							{
							}
							num6 = (short)1619056557;
							short num7 = num6;
							num6 = (short)1280890797;
							switch (num7 == num6)
							{
							}
							num6 = (short)676069376;
							if (num6 != 0)
							{
							}
							num6 = (short)1727201280;
							short num8 = num6;
							return true;
						});
						goto IL_35E;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_EC;
						}
						continue;
					case 9:
					{
						num = (short)1627078308;
						short num4 = num;
						num = (short)671366820;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_676;
						default:
						{
							num = (short)1827012608;
							if (num != 0)
							{
							}
							global::AcpCommonLib.IAcpField currentField = channelAssignmentListInnerSection.CurrentField;
							if (currentField == null)
							{
								num = (short)1125974050;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text2 = currentField.ToString().Trim();
							goto IL_2DF;
						}
						}
						break;
					}
					case 10:
						if (list2 != null)
						{
							num = (short)1777664017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
						num = (short)1039073281;
						if (num != 0)
						{
						}
						if ((func = global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.<>c.<>9__8_0) == null)
						{
							num = (short)343277575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35E;
					case 12:
						if (string.Equals(text3, global::AllFeatures.CodeplugGuid.b("ꯂ꫄꫆곈", a_), global::System.StringComparison.CurrentCultureIgnoreCase))
						{
							num = (short)2048655389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)610729986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						if (channelAssignmentListInnerSection == null)
						{
							num = (short)1582563352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpField<string> acpField = channelAssignmentListInnerSection.VCChannelAnnouncement_A20176;
						num = (short)1084948507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone;
						num3 = zone.ZoneVoiceAnnouncementID_A21514.Value;
						num = (short)450428964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone;
						global::AcpCommonLib.IAcpField currentField2 = zone.CurrentField;
						if (currentField2 == null)
						{
							num = (short)542965766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = currentField2.ToString().Trim();
						goto IL_3E0;
					}
					case 16:
						func2 = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.<>c.<>9__8_1 = delegate(global::AcpCommonLib.IAcpFeatureSection k)
						{
							int a_5 = 16;
							short num6 = (short)366018563;
							int num7 = (int)((global::System.IntPtr)num6);
							for (;;)
							{
								switch (num7)
								{
								case 0:
								{
									num6 = (short)1610028608;
									short num8 = num6;
									num6 = (short)1001330240;
									switch ((num8 == num6) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									case 1:
										goto IL_BA;
									}
									goto Block_2;
								}
								case 1:
									num6 = (short)1712324610;
									num7 = (int)((global::System.IntPtr)num6);
									continue;
								case 2:
									if (k.FeatureSectionName != null)
									{
										num6 = (short)724303872;
										num7 = (int)((global::System.IntPtr)num6);
										continue;
									}
									goto IL_127;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3D;
									}
									continue;
								}
								IL_3D:
								if (k == null)
								{
									goto IL_127;
								}
								num6 = (short)1613365249;
								num7 = (int)((global::System.IntPtr)num6);
							}
							Block_2:
							num6 = (short)562167808;
							short num9 = num6;
							IL_BA:
							num6 = (short)81199104;
							if (num6 != 0)
							{
							}
							return k.FeatureSectionName.Contains(global::AllFeatures.CodeplugGuid.b("诐볒믔닖", a_5));
							IL_127:
							num6 = (short)1700003841;
							if (num6 != 0)
							{
							}
							return false;
						});
						goto IL_499;
					case 17:
						goto IL_6FA;
					case 18:
					{
						global::AcpBusinessLayer.AcpField<string> acpField;
						value = acpField.Value;
						goto IL_584;
					}
					case 19:
						return true;
					case 20:
						value = null;
						goto IL_584;
					case 21:
						goto IL_4C6;
					case 22:
					{
						global::AcpCommonLib.IAcpFeatureNode parent = self.Parent;
						if (parent == null)
						{
							num = (short)1429930015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_2 = parent.Parent;
						goto IL_635;
					}
					case 23:
						goto IL_244;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone;
						num = (short)313262084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						num = (short)2038104084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_4C6;
					case 27:
						if (channelAssignmentListInnerSection.ChannelAnnouncementID_A20175 != null)
						{
							num = (short)548470784;
							short num5 = num;
							num = (short)1223491585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_244;
					case 28:
						if (list.Count <= 1)
						{
							num = (short)1986265093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B6;
					case 29:
						return false;
					case 30:
						if ((func2 = global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.<>c.<>9__8_1) == null)
						{
							num = (short)1667563536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_499;
					case 31:
						a_2 = null;
						goto IL_635;
					case 32:
						num = (short)1479344163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone;
						if (zone.ZoneVoiceAnnouncementID_A21514 != null)
						{
							num = (short)1939931150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_445;
					}
					case 34:
						text2 = null;
						goto IL_2DF;
					case 35:
						return true;
					case 36:
						goto IL_445;
					case 37:
						if (!global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSUtils.CheckTTSVoiceDuration(text3))
						{
							num = (short)1573126147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1859321878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_676;
					case 39:
						goto IL_5A4;
					}
					IL_EC:
					if (self == null)
					{
						num = (short)1274282003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = 0;
					channelAssignmentListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
					num = (short)1050214413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_244:
					num = (short)371916809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DF:
					text3 = text2;
					num = (short)1855455243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35E:
					global::System.Func<global::AcpCommonLib.IAcpFeatureSection, bool> a_3 = func;
					string a_4 = global::AllFeatures.CodeplugGuid.b("闂蛄蓆ꇈ꫊ꏌꇎ듐뿒铔맖럘듚꣜뇞苠蛢裤苦蟨鿪달껮쏰쏲쓴샶쿸", a_);
					num = (short)736100378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E0:
					text3 = text;
					num = (short)1431502881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_445:
					num = (short)354353182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_499:
					a_3 = func2;
					a_4 = global::AllFeatures.CodeplugGuid.b("闂蛄鷆ꛈꗊ꣌軎뿐뷒뫔ꋖ럘룚룜닞蓠跢釤룦꣨\ud9ea\udcec\udaee샰웲", a_);
					num = (short)573308949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C6:
					num = (short)551616524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_584:
					if (string.IsNullOrWhiteSpace(value))
					{
						num = (short)1839857703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1845821477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_635:
					list = global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.a(a_2, a_3, a_4);
					num = (short)661651456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_676:
					num = (short)770179100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B6:
					list2 = global::Features.Zone_Channel_Assignment.VoiceAnnouncementCollisionChecker.CalculateConfusability(text3, list, global::Features.Zone_Channel_Assignment.VoiceAnnouncementCollisionChecker.GetLanguageCode());
					num = (short)1720516618;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_5A4:
				return num3 != 65535;
				IL_6FA:
				return list2.Count <= 0;
			}
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001EEF0 File Offset: 0x0001D0F0
		private static global::System.Collections.Generic.List<string> a(global::AcpCommonLib.IAcpRecordset A_0, global::System.Func<global::AcpCommonLib.IAcpFeatureSection, bool> A_1, string A_2)
		{
			short num = (short)1448542209;
			if (num != 0)
			{
			}
			num = (short)936771584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A2;
				}
				global::System.Collections.Generic.List<string> list;
				global::System.Func<global::AcpCommonLib.IAcpField, bool> <>9__1;
				for (;;)
				{
					IL_4F:
					global::AcpCommonLib.IAcpField acpField;
					int num3;
					object obj;
					object obj2;
					global::AcpCommonLib.IAcpField acpField2;
					switch (num2)
					{
					case 0:
						goto IL_363;
					case 1:
						goto IL_3A3;
					case 2:
						list.Add(acpField.ToString());
						num = (short)102170634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (A_0 != null)
						{
							num = (short)1360920594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A3;
					case 4:
						num = (short)583073805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (acpField != null)
						{
							num = (short)1620836354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F9;
					case 6:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = A_0[num3];
						if (acpFeatureNode == null)
						{
							num = (short)721223692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						obj = acpFeatureNode.FeatureSectionsCollection;
						goto IL_1FB;
					}
					case 7:
						goto IL_3BC;
					case 8:
						obj2 = null;
						goto IL_24D;
					case 9:
						obj2 = null;
						goto IL_24D;
					case 10:
						goto IL_2F9;
					case 11:
						if (A_1 != null)
						{
							num = (short)516751364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A3;
					case 12:
						obj = null;
						goto IL_1FB;
					case 13:
						goto IL_13E;
					case 14:
					{
						num3 = 0;
						num = (short)1612054528;
						short num4 = num;
						num = (short)705953792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						num = (short)805871086;
						short num5 = num;
						num = (short)62823918;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13E;
						default:
							num = (short)2127167488;
							if (num != 0)
							{
							}
							goto IL_363;
						}
						break;
					}
					case 16:
						if (num3 >= A_0.Count)
						{
							num = (short)1312489473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1624768518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						acpField2 = null;
						goto IL_29A;
					case 18:
						num = (short)1015349259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A2;
					IL_13E:
					if (!string.IsNullOrEmpty(A_2))
					{
						num = (short)915865614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A3;
					IL_1FB:
					object obj3 = obj;
					if (obj3 == null)
					{
						num = (short)1333723144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = obj3.FirstOrDefault(A_1);
					if (acpFeatureSection == null)
					{
						num = (short)395575305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					obj2 = acpFeatureSection.FieldsCollection;
					IL_24D:
					object obj4 = obj2;
					if (obj4 == null)
					{
						num = (short)2097414161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Func<global::AcpCommonLib.IAcpField, bool> predicate;
					if ((predicate = <>9__1) == null)
					{
						predicate = (<>9__1 = delegate(global::AcpCommonLib.IAcpField k)
						{
							short num6 = (short)200343555;
							int num7 = (int)((global::System.IntPtr)num6);
							for (;;)
							{
								switch (num7)
								{
								case 0:
								{
									num6 = (short)786631249;
									short num8 = num6;
									num6 = (short)2021198417;
									switch ((num8 == num6) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									case 1:
										goto IL_B2;
									}
									goto Block_2;
								}
								case 1:
									num6 = (short)1524891650;
									num7 = (int)((global::System.IntPtr)num6);
									continue;
								case 2:
									if (k.Name != null)
									{
										num6 = (short)2032861184;
										num7 = (int)((global::System.IntPtr)num6);
										continue;
									}
									goto IL_115;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_35;
									}
									continue;
								}
								IL_35:
								if (k == null)
								{
									goto IL_115;
								}
								num6 = (short)950140929;
								num7 = (int)((global::System.IntPtr)num6);
							}
							Block_2:
							num6 = (short)618659840;
							short num9 = num6;
							IL_B2:
							num6 = (short)90767360;
							if (num6 != 0)
							{
							}
							return k.Name.Contains(A_2);
							IL_115:
							num6 = (short)2123235329;
							if (num6 != 0)
							{
							}
							return false;
						});
					}
					acpField2 = obj4.FirstOrDefault(predicate);
					IL_29A:
					acpField = acpField2;
					num = (short)1489043461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F9:
					num3++;
					num = (short)937558031;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_363:
					num = (short)181010448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A3:
					num = (short)611975175;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3BC:
				return list.Where(delegate(string s)
				{
					short num6 = (short)1190251501;
					short num7 = num6;
					num6 = (short)1492765677;
					switch (num7 == num6)
					{
					}
					num6 = (short)1970667521;
					if (num6 != 0)
					{
					}
					num6 = (short)450232320;
					if (num6 != 0)
					{
					}
					num6 = (short)680919040;
					short num8 = num6;
					return !string.IsNullOrWhiteSpace(s);
				}).ToList<string>();
				IL_A2:
				list = new global::System.Collections.Generic.List<string>();
				num = (short)623837187;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001F2E8 File Offset: 0x0001D4E8
		internal static bool ConTopChannelTextSize(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection;
			global::AcpBusinessLayer.AcpField<string> znChanCfgChannelsTopDisplayChannel_A = channelAssignmentListInnerSection.ZnChanCfgChannelsTopDisplayChannel_A19774;
			if (znChanCfgChannelsTopDisplayChannel_A.Value == null)
			{
				short num = (short)1702756353;
				if (num != 0)
				{
				}
				num = (short)564592640;
				short num2 = num;
			}
			else
			{
				short num = (short)1845334749;
				short num3 = num;
				num = (short)2138280669;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1408696320;
					if (num != 0)
					{
					}
					return znChanCfgChannelsTopDisplayChannel_A.Value.Length <= channelAssignmentListInnerSection.RefDisplayAndMenu.General.DispMenuTopChannelTextSize_A19504.Value;
				}
			}
			return true;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001F3D4 File Offset: 0x0001D5D4
		internal static bool ConTopDisplayZoneTextSize(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone;
			global::AcpBusinessLayer.AcpField<string> znChanCfgZoneTopDisplayZone_A = zone.ZnChanCfgZoneTopDisplayZone_A19772;
			if (znChanCfgZoneTopDisplayZone_A.Value == null)
			{
				short num = (short)387186689;
				if (num != 0)
				{
				}
				num = (short)636813312;
				short num2 = num;
			}
			else
			{
				short num = (short)1115548258;
				short num3 = num;
				num = (short)2132994658;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1624834048;
					if (num != 0)
					{
					}
					return znChanCfgZoneTopDisplayZone_A.Value.Length <= zone.RefDisplayAndMenu.General.DispMenuGeneralTopZoneTextSize_A19769.Value;
				}
			}
			return true;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001F4C0 File Offset: 0x0001D6C0
		internal static bool ConZoneTextSizeLimited(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone;
			global::AcpBusinessLayer.AcpKeyField znChanCfgZoneZoneName_A = zone.ZnChanCfgZoneZoneName_A9724;
			znChanCfgZoneZoneName_A.CalculateApplicability();
			short num;
			if (znChanCfgZoneZoneName_A.Value != null)
			{
				num = (short)99418113;
				if (num != 0)
				{
				}
				num = (short)2073848825;
				short num2 = num;
				num = (short)442592249;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)830996480;
					if (num != 0)
					{
					}
					return znChanCfgZoneZoneName_A.Value.Length <= zone.RefDisplayAndMenu.General.DispMenuGeneralZoneTextSize_A8167.Value;
				}
			}
			num = (short)856817664;
			short num3 = num;
			return true;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001F5B0 File Offset: 0x0001D7B0
		public static bool conCnvTypeIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1055784960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)845414400;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_83;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
				for (;;)
				{
					IL_50:
					switch (num2)
					{
					case 0:
						if (!zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562.Value)
						{
							num = (short)1259208706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E;
					case 1:
						if (index == 0)
						{
							num = (short)1229848581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						num = (short)1515520006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (channelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode != null)
						{
							num = (short)1094385674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A;
					case 4:
						goto IL_22E;
					case 5:
						goto IL_266;
					case 6:
						if (zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionProtectedZone_A8765.Value)
						{
							num = (short)29884420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality != null)
						{
							num = (short)2052521992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (conventionalPersonality.FrequencyOptions.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset).GetEnumerator();
						num = (short)734920705;
						if (num != 0)
						{
						}
						num = (short)1194524681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						try
						{
							num = (short)1745420292;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_32A;
								case 2:
									num = (short)1873018880;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1418067970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner)enumerator.Current).FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.CalculateValidity();
									num = (short)1538785281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_2A6;
									}
									continue;
								}
								IL_2DA:
								num = (short)1003945987;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A6:
								goto IL_2DA;
							}
							IL_32A:
							goto IL_12A;
						}
						finally
						{
							num = (short)1221853186;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_3E8;
								case 1:
									enumerator.Dispose();
									num = (short)442892288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_361;
									}
									continue;
								}
								IL_361:
								num = (short)1647100550;
								short num4 = num;
								num = (short)878887558;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1605042176;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_3EA;
									}
									break;
								}
								num = (short)2071330817;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3E8:
							IL_3EA:;
						}
						return false;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = channelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						num = (short)1038745607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_83;
					IL_12A:
					num = (short)783220736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22E:
					num = (short)1249705985;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_266:
				return true;
				IL_83:
				channelAssignmentListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
				zoneChannelAssignment = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				num = (short)1717108739;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001F9BC File Offset: 0x0001DBBC
		internal static bool conChannelTypeIsCnvORProtectedZoneIsDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)373293058;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)1275330566;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								result = false;
								num = (short)863109123;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1A3;
							case 2:
								if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10115] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection).ZnChanCfgChannelsChannelType_A22241.Value == 1)
								{
									num = (short)267386880;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 3:
								goto IL_186;
							case 4:
								num = (short)1173749761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								if (!enumerator.MoveNext())
								{
									num = (short)1832583172;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1889992706;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_E5;
								}
								continue;
							}
							IL_134:
							num = (short)2052325381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_E5:
							goto IL_134;
						}
						IL_186:
						return result;
						IL_1A3:
						return true;
					}
					finally
					{
						num = (short)1330708482;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_25B;
							case 1:
								enumerator.Dispose();
								num = (short)428212224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1D9;
								}
								continue;
							}
							IL_1D9:
							num = (short)399302063;
							short num3 = num;
							num = (short)1397677487;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)56164352;
								if (num != 0)
								{
								}
								if (enumerator == null)
								{
									goto IL_25D;
								}
								break;
							}
							num = (short)1390608385;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_25B:
						IL_25D:;
					}
					goto IL_25E;
				case 1:
				{
					num = (short)1096876032;
					short num4 = num;
					goto IL_25E;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.FPPProtection fppprotection = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.FPPProtection;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset = self.Parent[10114].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset;
				if (fppprotection.ZnChanCfgFPPProtectionProtectedZone_A8765.Value)
				{
					num = (short)819068929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_25E:
				enumerator = channelAssignmentListInnerRecset.GetEnumerator();
				num = (short)113377281;
				if (num != 0)
				{
				}
				num = (short)1623261184;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001FC90 File Offset: 0x0001DE90
		public static bool ConIsZnChanChannelVARecRefSelectionValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1153630212;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpBusinessLayer.Recordset refRecset;
				switch (num2)
				{
				case 0:
					return true;
				case 1:
					return true;
				case 2:
				{
					if (index > refRecset.Count)
					{
						goto IL_A3;
					}
					num = (short)257490944;
					short num3 = num;
					global::AcpBusinessLayer.FeatureNode featureNode = refRecset[index - 1] as global::AcpBusinessLayer.FeatureNode;
					num = (short)12517385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)1674640796;
					short num4 = num;
					num = (short)1500249500;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A3;
					default:
						num = (short)1541013504;
						if (num != 0)
						{
						}
						if (refRecset != null)
						{
							num = (short)96403470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 5:
					if (global::ConstraintHelper.UtilityMack.IsNFPARadio)
					{
						num = (short)609812488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					if (!global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.VerifyTtsValueSupport(index))
					{
						num = (short)1620967431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)245825539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
				{
					global::AcpBusinessLayer.FeatureNode featureNode;
					if (featureNode == null)
					{
						num = (short)850984960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1699414028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					return true;
				case 11:
				{
					global::AcpBusinessLayer.FeatureNode featureNode;
					if (featureNode.KeyField.Valid)
					{
						num = (short)1556873217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 12:
				{
					global::AcpBusinessLayer.FeatureNode featureNode;
					if (featureNode != null)
					{
						num = (short)1112735745;
						if (num != 0)
						{
						}
						num = (short)1014890509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 13:
					num = (short)1414397963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)1099694082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)231800837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_64:
				if (index == 0)
				{
					num = (short)1691877391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				refRecset = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection).ChannelAnnouncementID_A20175.RefRecset;
				num = (short)1031471110;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A3:
				num = (short)2102067210;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001FF98 File Offset: 0x0001E198
		public static bool ConFallbackZoneSelectionValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1489436673;
			int num2 = (int)((global::System.IntPtr)num);
			bool? flag3;
			for (;;)
			{
				bool? flag;
				object obj;
				switch (num2)
				{
				case 0:
				{
					bool? flag2;
					flag = flag2;
					goto IL_165;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 2:
					if (flag3 == null)
					{
						goto IL_18A;
					}
					goto IL_22E;
				case 3:
					return true;
				case 4:
					num = (short)908394497;
					if (num != 0)
					{
					}
					obj = null;
					goto IL_13D;
				case 5:
				{
					num = (short)559546368;
					short num3 = num;
					bool? flag2;
					flag = flag2;
					goto IL_165;
				}
				case 6:
					num = (short)2079064072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset = global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset;
					if (zoneChannelAssignmentRecset != null)
					{
						obj = zoneChannelAssignmentRecset[index - 1];
						goto IL_13D;
					}
					num = (short)1475989112;
					short num4 = num;
					num = (short)1111871096;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18A;
					default:
						num = (short)1876688896;
						if (num != 0)
						{
						}
						num = (short)1445593092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					return true;
				}
				IL_48:
				if (index <= 0)
				{
					num = (short)476839942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)77987847;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13D:
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = obj as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
				if (zoneChannelAssignment == null)
				{
					bool? flag2 = null;
					num = (short)1644888064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone = zoneChannelAssignment.Zone;
				if (zone == null)
				{
					bool? flag2 = null;
					num = (short)2049966085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag = new bool?(zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value);
				IL_165:
				flag3 = flag;
				num = (short)1093730306;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_18A:
				num = (short)350486531;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_22E:
			return !flag3.Value;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000201E0 File Offset: 0x0001E3E0
		public static bool ConIsZnChanVARecRefSelectionValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)638386176;
			short num2 = num;
			num = (short)1680998401;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_47:
				switch (num3)
				{
				case 0:
				{
					global::AcpBusinessLayer.FeatureNode featureNode;
					if (featureNode == null)
					{
						num = (short)916258822;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)790822925;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 2:
					return false;
				case 3:
					num = (short)2041053196;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return true;
				case 5:
				{
					global::AcpBusinessLayer.Recordset refRecset;
					while (index <= refRecset.Count)
					{
						num = (short)984197938;
						short num4 = num;
						num = (short)65645362;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1039007744;
							if (num != 0)
							{
							}
							global::AcpBusinessLayer.FeatureNode featureNode = refRecset[index - 1] as global::AcpBusinessLayer.FeatureNode;
							num = (short)473497600;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_47;
						}
						}
					}
					num = (short)826212359;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					return true;
				case 7:
					return true;
				case 8:
					if (!global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.VerifyTtsValueSupport(index))
					{
						num = (short)1293811714;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)745603082;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1772617733;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					global::AcpBusinessLayer.Recordset refRecset;
					if (refRecset != null)
					{
						num = (short)1958215689;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 11:
					return true;
				case 12:
				{
					global::AcpBusinessLayer.FeatureNode featureNode;
					if (featureNode.KeyField.Valid)
					{
						num = (short)551747588;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 13:
				{
					num = (short)1325203457;
					if (num != 0)
					{
					}
					global::AcpBusinessLayer.FeatureNode featureNode;
					if (featureNode != null)
					{
						num = (short)1431633923;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				}
				IL_85:
				if (index == 0)
				{
					num = (short)219480075;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::AcpBusinessLayer.Recordset refRecset = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).ZoneVoiceAnnouncementID_A21514.RefRecset;
					num = (short)1256456200;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00020494 File Offset: 0x0001E694
		public static bool ConIsZnChanAssignChTypeCnv(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)824770560;
			short num2 = num;
			num = (short)544866304;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
				for (;;)
				{
					IL_53:
					global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection2;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num3)
					{
					case 0:
						collection = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
						conventionalPersonality = ((self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection).ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality);
						if (conventionalPersonality != null && conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.ReferencedNode == self.Parent)
						{
							goto IL_B02;
						}
						goto IL_BFF;
					case 1:
						if (channelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode != null)
						{
							num = (short)2031943685;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4D;
					case 2:
						if ((self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection).ZnChanCfgChannelsChannelType_A22241Value == 0)
						{
							num = (short)1610940424;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_541;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						conventionalSystem.DVRS.CnvSysFeatureDynRegroupChannel_A40144.CalculateValidity();
						num = (short)590675979;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (channelAssignmentListInnerSection2 != null)
						{
							num = (short)354811919;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB5;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = (channelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality).Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
						num = (short)1907490826;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)616955913;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.DVRS != null)
						{
							num = (short)1117519878;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4D;
					}
					case 8:
						num = (short)323747841;
						if (num != 0)
						{
						}
						num = (short)1469120512;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.DVRS.CnvSysFeatureDynRegroupEn_A40146.Value)
						{
							num = (short)297730051;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4D;
					}
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem != null)
						{
							num = (short)922222606;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4D;
					}
					case 11:
						goto IL_C4B;
					case 12:
						try
						{
							num = (short)2062876675;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)743505921;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2 = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2 = conventionalPersonality2.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									num = (short)96534530;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)508887045;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
									if (conventionalSystem2 != null)
									{
										num = (short)692453392;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_5F0;
									}
									continue;
								case 4:
									try
									{
										num = (short)673120257;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
											switch (num3)
											{
											case 0:
												goto IL_7F4;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_6B8;
												}
												continue;
											case 2:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)278331395;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												frequencyOptionsInner = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner)enumerator2.Current;
												num = (short)30801924;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												num = (short)1996488704;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value != 65535)
												{
													num = (short)1972895752;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_79F;
											case 6:
												if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value == 65534)
												{
													num = (short)404226055;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 7:
												goto IL_79F;
											case 8:
												num = (short)1540161542;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_762:
											num = (short)1773862914;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_6B8:
											goto IL_762;
											IL_79F:
											frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.CalculateApplicability();
											frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.CalculateValidity();
											num = (short)239599621;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_7F4:
										break;
									}
									finally
									{
										num = (short)1269891073;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num3)
											{
											case 0:
												goto IL_866;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_82B;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num = (short)555286528;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_82B:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1924071426;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_866:;
									}
									goto IL_869;
								case 5:
									goto IL_A48;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
									if (conventionalSystem2.DVRS.CnvSysFeatureDynRegroupEn_A40146.Value)
									{
										num = (short)317325319;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_869;
								case 8:
									num = (short)738066444;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
									if (conventionalSystem2.General.CnvSysGeneralSystemType_A13262.Value == 2)
									{
										num = (short)1577713672;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									num = (short)773521414;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (conventionalPersonality2.FrequencyOptions.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset).GetEnumerator();
									num = (short)1189937156;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
									if (conventionalSystem2.DVRS != null)
									{
										num = (short)1731723274;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									num = (short)213516302;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
									if (conventionalPersonality2.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value)
									{
										num = (short)1894842379;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 15:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
									if (conventionalPersonality2.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
									{
										num = (short)612302861;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 16:
									num = (short)1858535433;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5F0;
								IL_869:
								num = (short)470941711;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_9A3:
								num = (short)866385920;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_5F0:
								goto IL_9A3;
							}
							IL_A48:
							goto IL_541;
						}
						finally
						{
							num = (short)1857617921;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_AB7;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A7F;
									}
									continue;
								case 2:
									goto IL_A9A;
								}
								IL_A7F:
								if (enumerator != null)
								{
									num = (short)559480834;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_AB7;
								IL_A9A:
								enumerator.Dispose();
								num = (short)1206124544;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_AB7:
								num = (short)1995950882;
								short num4 = num;
								num = (short)1425066786;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_A9A;
								default:
									goto IL_AEC;
								}
							}
							IL_AEC:
							num = (short)152305664;
							if (num != 0)
							{
							}
						}
						goto IL_B02;
					case 13:
						try
						{
							num = (short)1103364101;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_4CE;
								case 1:
								{
									try
									{
										num = (short)1644101634;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 1:
												goto IL_322;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_29B;
												}
												continue;
											case 3:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1211695108;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												(enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner).ScanListInnerSection.ScanLstScanListChannel_A7620.CalculateValidity();
												num = (short)1466302464;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												num = (short)423624705;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_29D:
											num = (short)437256195;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_29B:
											goto IL_29D;
										}
										IL_322:;
									}
									finally
									{
										num = (short)334954497;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num3)
											{
											case 0:
												goto IL_38D;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_356;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num = (short)1727397888;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_356:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)807010306;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_38D:;
									}
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = featureNode.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
									scanList.General.ScanLstGeneralPriorityMember1_A8747.CalculateApplicability();
									scanList.General.ScanLstGeneralPriorityMember1_A8747.CalculateValidity();
									scanList.General.ScanLstGeneralDesignatedDataMember_A7829.CalculateApplicability();
									scanList.General.ScanLstGeneralDesignatedDataMember_A7829.CalculateValidity();
									num = (short)214695940;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)516423683;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)246415366;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)338296832;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_25C;
									}
									continue;
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)
									{
										num = (short)660996103;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (featureNode.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset).GetEnumerator();
									num = (short)1763442689;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_477:
								num = (short)247529474;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_25C:
								goto IL_477;
							}
							IL_4CE:
							goto IL_BB5;
						}
						finally
						{
							num = (short)1729626113;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_53E;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_506;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1265827840;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_506:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1275002882;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_53E:;
						}
						goto IL_541;
					case 14:
						num = (short)1299775495;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						enumerator = channelAssignmentListInnerSection2.ZnChanCfgChannelsChannelName_A7659.ReferencingNodes.GetEnumerator();
						num = (short)507248653;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9A;
					IL_541:
					channelAssignmentListInnerSection2 = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
					num = (short)689766404;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_BB5:
					channelAssignmentListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
					num = (short)903479297;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_BFF:
					enumerator = collection.GetEnumerator();
					num = (short)265879564;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_B02:
					conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.CalculateApplicability();
					conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.CalculateValidity();
					goto IL_BFF;
				}
				IL_C4B:
				IL_C4D:
				return channelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0;
				IL_9A:
				global::AcpCommonLib.FeatureManager.GetFeature(2057);
				num = (short)1441794;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_53;
			}
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00021160 File Offset: 0x0001F360
		public static bool ConIsCnvFreqOptValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1216413696;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A2;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1088946198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
						if (frequencyOptionsInner != null)
						{
							num = (short)1384775685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 2:
						return false;
					case 3:
						return true;
					case 4:
						num = (short)274792460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1206714381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (channelAssignmentListInnerSection.ChannelsActiveChannel.Value)
						{
							num = (short)791019523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1405288472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 2)
						{
							num = (short)258080772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 8:
						num = (short)2064515099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = channelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = null;
						num = (short)1943273487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
						num = (short)686555155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
						if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value == 65535)
						{
							num = (short)632815626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.DVRS != null)
						{
							num = (short)1312227336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
						{
							num = (short)2056585216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 14:
						goto IL_46D;
					case 15:
						if (channelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.RefRecset != null)
						{
							num = (short)717815829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AD;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality != null)
						{
							num = (short)958922775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 17:
						goto IL_4AD;
					case 18:
						num = (short)255524871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem != null)
						{
							num = (short)1965162514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.DVRS.CnvSysFeatureDynRegroupChannel_A40144.ReferencedNode != self.Parent)
						{
							num = (short)856358940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 21:
					{
						num = (short)2059337729;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = channelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.RefRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner;
						num = (short)398852113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value)
						{
							num = (short)1119682585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 23:
						num = (short)1706229761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (channelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
						{
							num = (short)2044264457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 25:
						num = (short)1924333579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value)
						{
							num = (short)1667694594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 27:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.DVRS.CnvSysFeatureDynRegroupEn_A40146.Value)
						{
							num = (short)1459683342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 28:
					{
						num = (short)1154981721;
						short num3 = num;
						num = (short)1424662361;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_46D;
						default:
							num = (short)1560215552;
							if (num != 0)
							{
							}
							num = (short)155320346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_A2;
					IL_46D:
					num = (short)99483648;
					short num4 = num;
					num = (short)2065956884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AD:
					num = (short)1040056336;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_A2:
				channelAssignmentListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
				num = (short)686030854;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000216F0 File Offset: 0x0001F8F0
		public static void ConDynamicZoneEnableValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1962999808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				bool suspended;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				int num6;
				bool newValue;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (!suspended)
						{
							num = (short)1865940996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_116C;
					case 1:
						return;
					case 2:
						try
						{
							num = (short)397213718;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int num3;
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
								global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset scanListRecset;
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality != null)
									{
										num = (short)1304297486;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_CD4;
								}
								case 1:
									if (num3 >= 16)
									{
										num = (short)2058616835;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									channelAssignmentListInner = (channelAssignmentListInnerRecset.CreateDefaultRecord() as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(channelAssignmentListInner));
									num = (short)650575889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (scanListRecset != null)
									{
										num = (short)944898059;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_62F;
								case 3:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(channelAssignmentListInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner));
									num = (short)191299615;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1650982964;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.UIValue = conventionalPersonality.ReferenceKey;
									num = (short)516816944;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									try
									{
										num = (short)234160129;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
											switch (num2)
											{
											case 0:
												try
												{
													num = (short)1206124545;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
															num = (short)182714372;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 1:
															switch (0)
															{
															case 0:
																goto IL_D94;
															}
															continue;
														case 3:
														{
															global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
															acpRecRefField.UpdateComparison();
															num = (short)746455042;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 4:
															goto IL_E4F;
														case 5:
														{
															global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
															if (acpRecRefField != null)
															{
																num = (short)1717501955;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 6:
														{
															global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
															if (!enumerator.MoveNext())
															{
																num = (short)41353216;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::AcpBusinessLayer.AcpRecRefField acpRecRefField = enumerator.Current as global::AcpBusinessLayer.AcpRecRefField;
															num = (short)1456930821;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														}
														IL_DFA:
														num = (short)1831600134;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_D94:
														goto IL_DFA;
													}
													IL_E4F:
													break;
												}
												finally
												{
													num = (short)651886593;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
														switch (num2)
														{
														case 0:
															goto IL_EC0;
														case 1:
															switch (0)
															{
															case 0:
																goto IL_E87;
															}
															continue;
														case 2:
															enumerator.Dispose();
															num = (short)623378432;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														IL_E87:
														if (enumerator == null)
														{
															break;
														}
														num = (short)896532482;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_EC0:;
												}
												goto IL_EC3;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_D4C;
												}
												continue;
											case 2:
												if (scanList != null)
												{
													num = (short)598343685;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 3:
												if (!enumerator2.MoveNext())
												{
													num = (short)1473576966;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_EC3;
											case 4:
												goto IL_F90;
											case 5:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = scanList.General.FieldsCollection.GetEnumerator();
												num = (short)1633681408;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												num = (short)1277231108;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_D4C;
											IL_EC3:
											scanList = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator2.Current;
											num = (short)2102263810;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_F0A:
											num = (short)734003203;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_D4C:
											goto IL_F0A;
										}
										IL_F90:
										goto IL_62F;
									}
									finally
									{
										num = (short)1628766209;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_1001;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_FC7;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num = (short)1480130560;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_FC7:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1927938050;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_1001:;
									}
									goto IL_1004;
								case 7:
									goto IL_2D3;
								case 8:
									num3 = 0;
									num = (short)2031681560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (!global::AcpCommonLib.AppInfoManager.DndOrImportOperation)
									{
										num = (short)1673396259;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6F1;
								case 10:
									goto IL_732;
								case 11:
									enumerator2 = scanListRecset.GetEnumerator();
									num = (short)139001862;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									int num4;
									if (num4 <= 0)
									{
										num = (short)189923379;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(channelAssignmentListInnerRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner));
									num4--;
									num = (short)1491664938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									num = (short)1062469655;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
									channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.UIValue = conventionalPersonality.ReferenceKey;
									num = (short)1691680813;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									if (!(self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
									{
										num = (short)311689242;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1077;
								case 16:
								{
									if ((self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
									{
										num = (short)1236009006;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num4 = channelAssignmentListInnerRecset.Count - 1;
									num = (short)912064551;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality != null)
									{
										num = (short)393019397;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_34B;
								}
								case 18:
									if (zoneChannelAssignment == null)
									{
										num = (short)1095565359;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									channelAssignmentListInnerRecset = (zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset);
									num = (short)1690828849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
								{
									int num5;
									if (num5 <= 0)
									{
										num = (short)1686962184;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(channelAssignmentListInnerRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner));
									num5--;
									num = (short)747503636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
									goto IL_732;
								case 21:
									goto IL_6B1;
								case 22:
									switch (0)
									{
									case 0:
										goto IL_1F3;
									}
									continue;
								case 23:
									if ((self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).ZnChanCfgZoneZoneCloningEnable_43119.Value)
									{
										num = (short)1511850016;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BD0;
								case 24:
									goto IL_6B1;
								case 25:
									channelAssignmentListInnerRecset.RefreshRecordsetToolBarNonACPMethod();
									num = (short)2070085639;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									num = (short)918159403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
									goto IL_1077;
								case 28:
									(zoneChannelAssignment.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset).RefreshRecordsetToolBarNonACPMethod();
									num = (short)357892126;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
									{
										num = (short)1158021160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_62F;
								case 30:
									goto IL_9B8;
								case 31:
									goto IL_6F1;
								case 32:
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConZoneChannelAssignmentCloningEnableValueSetter(self, task);
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMaxTask(conventionalPersonalityRecset, conventionalPersonalityRecset.Max - num6));
									num = (short)1295646753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									goto IL_BD0;
								case 34:
									goto IL_98A;
								case 35:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = null;
									enumerator2 = conventionalPersonalityRecset.GetEnumerator();
									num = (short)1810235442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 36:
									if (zoneChannelAssignment != null)
									{
										num = (short)186253316;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9B8;
								case 37:
									goto IL_6F1;
								case 38:
									try
									{
										num = (short)83623937;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_AEF;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_A4C;
												}
												continue;
											case 2:
												if (((global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator2.Current).Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
												{
													num = (short)1878851589;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 3:
												if (!enumerator2.MoveNext())
												{
													num = (short)2045050886;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1498218498;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												goto IL_B0D;
											case 5:
												newValue = true;
												num = (short)2140995584;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												num = (short)1000734724;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_A98:
											num = (short)1383071747;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_A4C:
											goto IL_A98;
										}
										IL_AEF:
										IL_B0D:
										goto IL_550;
									}
									finally
									{
										for (;;)
										{
											IL_B12:
											num = (short)1564672001;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_BCD;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_B45;
													}
													continue;
												case 2:
													enumerator2.Dispose();
													num = (short)504365056;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_B45:
												if (enumerator2 == null)
												{
													goto IL_BCF;
												}
												num = (short)1865361297;
												short num7 = num;
												num = (short)76425105;
												switch ((num7 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_B12;
												default:
													num = (short)817823744;
													if (num != 0)
													{
													}
													num = (short)1185808386;
													num2 = (int)((global::System.IntPtr)num);
													break;
												}
											}
										}
										IL_BCD:
										IL_BCF:;
									}
									goto IL_BD0;
								case 39:
									goto IL_8FD;
								case 40:
									goto IL_1004;
								case 41:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMaxTask(conventionalPersonalityRecset, conventionalPersonalityRecset.Max + num6));
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConZoneChannelAssignmentCloningEnableValueSetter(self, task);
									num = (short)1063518235;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									goto IL_8FD;
								case 43:
									if ((self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).ZnChanCfgZoneZoneCloningEnable_43119.Value)
									{
										num = (short)1277493289;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1077;
								case 44:
									goto IL_108F;
								case 45:
									goto IL_CD4;
								case 46:
								{
									int num5 = channelAssignmentListInnerRecset.Count - 1;
									num = (short)301137930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 47:
									num = (short)318898210;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 48:
									goto IL_34B;
								case 49:
									if (channelAssignmentListInnerRecset != null)
									{
										num = (short)185401369;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D3;
								case 50:
									try
									{
										num = (short)1463877633;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = conventionalPersonality2;
												num = (short)1899823107;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												switch (0)
												{
												case 0:
													goto IL_41D;
												}
												continue;
											case 2:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)992870405;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2 = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator2.Current;
												num = (short)881459206;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												goto IL_46E;
											case 4:
												goto IL_4DF;
											case 5:
												num = (short)1801781252;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
												if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, conventionalPersonality2.Permissions))
												{
													num = (short)1137377280;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_41F:
											num = (short)1539178498;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_41D:
											goto IL_41F;
										}
										IL_46E:
										IL_4DF:
										goto IL_770;
									}
									finally
									{
										num = (short)2076246017;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_54D;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_516;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num = (short)233046016;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_516:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1329397762;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_54D:;
									}
									goto IL_550;
									IL_770:
									num = (short)909115408;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 51:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2 = channelAssignmentListInnerRecset.CreateDefaultRecord() as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(channelAssignmentListInner2));
									num = (short)1600258048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 52:
									if (zoneChannelAssignment.Parent != null)
									{
										num = (short)729743388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9B8;
								}
								IL_1F3:
								if ((self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
								{
									num = (short)1423114253;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BD0;
								IL_2D3:
								num = (short)529334308;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_34B:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>((channelAssignmentListInner[10115] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection).ChannelsActiveChannel, true));
								num3++;
								num = (short)799866901;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_550:
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioWide.Labtool.RadWideLabtoolDynamicZoneCable_A41258, newValue));
								num = (short)1169489929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_62F:
								zoneChannelAssignment = ((self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
								num = (short)387186706;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6B1:
								num = (short)1315766273;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6F1:
								num = (short)2058682397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_732:
								num = (short)1638662163;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8FD:
								num = (short)1588592652;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9B8:
								global::ConstraintHelper.AppMultiInstanceManager.IsDynamicZoneChanged = true;
								num = (short)34734095;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BD0:
								enumerator2 = zoneChannelAssignmentRecset.GetEnumerator();
								num = (short)425656358;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CD4:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(channelAssignmentListInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner));
								num = (short)2020802597;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1004:
								scanListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset);
								num = (short)1600585730;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1077:
								num = (short)797442092;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_98A:
							return;
							IL_108F:
							goto IL_114C;
						}
						finally
						{
							num = (short)1409417217;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_10FC;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_10C6;
									}
									continue;
								case 2:
									global::AcpCommonLib.ConstraintManager.Resume();
									num = (short)247070720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_10C6:
								if (suspended)
								{
									break;
								}
								num = (short)1047134210;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_10FC:
							self.CallConstraints();
						}
						goto IL_1105;
						IL_114C:
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.a(zoneChannelAssignmentRecset);
						num = (short)341639169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1261568001;
						if (num != 0)
						{
						}
						goto IL_116C;
					case 4:
						goto IL_1105;
					}
					goto IL_43;
					IL_1105:
					global::AcpCommonLib.ConstraintManager.Suspend();
					num = (short)24903683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_116C:
					num = (short)180617218;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_43:
				num6 = 16;
				newValue = false;
				zoneChannelAssignmentRecset = ((self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
				zoneChannelAssignment = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				channelAssignmentListInnerRecset = (zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset);
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				suspended = global::AcpCommonLib.ConstraintManager.Suspended;
				num = (short)279248896;
				short num8 = num;
				num = (short)1050411008;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00022904 File Offset: 0x00020B04
		private static void a(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset A_0)
		{
			short num;
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)927006722;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							goto IL_E2;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_41;
							}
							continue;
						case 3:
							num = (short)1958739969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1013579779;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current;
							zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.CalculateEditability();
							zoneChannelAssignment.Zone.ZnChanCfgZoneZoneCloningEnable_43119.CalculateEditability();
							zoneChannelAssignment.Zone.ZnChanCfgZoneZoneCloningEnable_43119.CalculateApplicability();
							num = (short)1360003072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_93:
						num = (short)1564803076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_41:
						goto IL_93;
					}
					IL_E2:;
				}
				finally
				{
					num = (short)977600512;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_115;
							}
							continue;
						case 1:
							goto IL_14A;
						case 2:
							enumerator.Dispose();
							num = (short)362479617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_115:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1474297858;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_14A:;
				}
				num = (short)361761576;
				short num3 = num;
				num = (short)483527464;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_184;
				}
			}
			IL_184:
			num = (short)1072300032;
			short num4 = num;
			num = (short)1875116033;
			if (num != 0)
			{
			}
			num = (short)30081024;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00022B0C File Offset: 0x00020D0C
		public static bool ConIsDynamicZoneEnableUnChecked(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1590820865;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					zoneChannelAssignment = (self.Parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					num = (short)1641545729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_9C;
				case 2:
					if (zoneChannelAssignment == null)
					{
						num = (short)2132344832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C;
				case 3:
					goto IL_119;
				case 4:
					while (zoneChannelAssignment != null)
					{
						num = (short)2131916546;
						short num3 = num;
						num = (short)566327042;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2113601536;
							if (num != 0)
							{
							}
							num = (short)1234698243;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_30;
						}
					}
					goto IL_156;
				}
				goto IL_4A;
				IL_9C:
				num = (short)342818820;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_119:
			return !zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value;
			IL_156:
			num = (short)1910964224;
			short num4 = num;
			return true;
			IL_4A:
			zoneChannelAssignment = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num = (short)1946877954;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00022C9C File Offset: 0x00020E9C
		public static bool ConDynamicZoneEnableApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1913782272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone;
					global::AcpBusinessLayer.Recordset recordset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset radioInformationRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
					int count;
					int num6;
					switch (num2)
					{
					case 0:
						if (trunkingPersonalityRecset != null)
						{
							num = (short)1994457100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_66A;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)66060290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)709820417;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1110507523;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_49C;
									}
									continue;
								case 2:
									num = (short)821297160;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_5CB;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									conventionalPersonality.Signaling.CnvPerSignalingRevertZone_A13269.CallConstraints();
									conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.CallConstraints();
									num = (short)2119565317;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality != null)
									{
										num = (short)462553090;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)674562048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)982646790;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.Signaling.CnvPerSignalingRevertZone_A13269.ReferencedNode == self.Parent)
									{
										num = (short)1913389060;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_571:
								num = (short)183107591;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_49C:
								goto IL_571;
							}
							IL_5CB:
							goto IL_6D9;
						}
						finally
						{
							num = (short)696844288;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_604;
									}
									continue;
								case 1:
									goto IL_63E;
								case 2:
									enumerator.Dispose();
									num = (short)865730561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_604:
								if (enumerator == null)
								{
									break;
								}
								num = (short)921960450;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_63E:;
						}
						return false;
					case 3:
					{
						num = (short)1969618944;
						short num3 = num;
						if (zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num = (short)1678835717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1956184079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1393950721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D9;
					case 5:
						return true;
					case 6:
						try
						{
							num = (short)1748762627;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									int num4;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									num4 += zoneChannelAssignment.Channels.EmbeddedRecset.Count;
									num = (short)191692806;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_2B5;
								case 2:
									num = (short)586809345;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1E9;
									}
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment != null)
									{
										num = (short)1492647936;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)977993730;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
									num = (short)573440004;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_25B:
								num = (short)1196949509;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E9:
								goto IL_25B;
							}
							IL_2B5:
							goto IL_3B6;
						}
						finally
						{
							num = (short)928251904;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2EC;
									}
									continue;
								case 1:
									goto IL_373;
								case 2:
									enumerator.Dispose();
									num = (short)1465253889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2EC:
								num = (short)936719929;
								short num5 = num;
								num = (short)1566520889;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_375;
								default:
									num = (short)1506476032;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_375;
									}
									num = (short)1802043394;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_373:
							IL_375:;
						}
						goto IL_376;
						IL_3B6:
						num = (short)354418709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (recordset.Count > 0)
						{
							num = (short)1751253005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						if (radioInformationRecset != null)
						{
							num = (short)1541668874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A57;
					case 9:
						num = (short)1322516502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)777781259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (radioInformationRecset[0][10108] is global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General)
						{
							num = (short)1134297105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A57;
					case 12:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingPersonalityRecset.GetEnumerator();
						num = (short)990969881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						int num4 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = recordset.GetEnumerator();
						num = (short)1697579014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_80B;
					case 15:
						if ((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
						{
							num = (short)1516371984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FB;
					case 16:
						num = (short)733347864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_376;
					case 18:
						goto IL_17C;
					case 19:
						return false;
					case 20:
						if (!zoneChannelAssignment2.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562.Value)
						{
							num = (short)70189065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 21:
					{
						int num4;
						if (num4 + 16 - count > num6)
						{
							num = (short)406519827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 22:
						if (zoneChannelAssignment2.FPPProtection.ZnChanCfgFPPProtectionProtectedZone_A8765.Value)
						{
							num = (short)387973138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = 0;
						radioInformationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset);
						num = (short)1723596808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_A57;
					case 24:
						if (!zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num = (short)2049441806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FB;
					case 25:
						try
						{
							num = (short)578093057;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)540213254;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_8BB;
									}
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									trunkingPersonality.General.TrkPerGeneralRevertZone_A41916.CallConstraints();
									trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.CallConstraints();
									num = (short)1769603077;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_9E2;
								case 4:
									num = (short)2004418563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality.General.TrkPerGeneralRevertZone_A41916.ReferencedNode == self.Parent)
									{
										num = (short)698220546;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality != null)
									{
										num = (short)940572672;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1201405956;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									num = (short)126681095;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_947:
								num = (short)1633550344;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8BB:
								goto IL_947;
							}
							IL_9E2:
							goto IL_66A;
						}
						finally
						{
							num = (short)2045771776;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_A19;
									}
									continue;
								case 1:
									goto IL_A52;
								case 2:
									enumerator.Dispose();
									num = (short)1332477953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_A19:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1415905282;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A52:;
						}
						return false;
					}
					goto IL_97;
					IL_376:
					num6 = (radioInformationRecset[0][10108] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General).RadInfoGeneralMaximumChannels_A11479.Value;
					num = (short)429391895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FB:
					zoneChannelAssignment2 = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					num = (short)1238368276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66A:
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)1723465729;
					if (num != 0)
					{
					}
					num = (short)11927556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D9:
					zone = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone);
					num = (short)969539587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A57:
					recordset = (zoneChannelAssignment2.Parent as global::AcpBusinessLayer.Recordset);
					count = zoneChannelAssignment2.Channels.EmbeddedRecset.Count;
					num = (short)679215111;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17C:
				return false;
				IL_80B:
				return false;
				IL_97:
				trunkingPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
				num = (short)1182269440;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000237AC File Offset: 0x000219AC
		public static bool ConNonDynamicZoneExistFPPDisableProtectedZoneDisable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)44105728;
			short num2 = num;
			num = (short)1639317504;
			switch (num)
			{
			default:
			{
				num = (short)640221185;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = zone.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset = zone.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset = null;
				zone.CalculateApplicability();
				bool flag = true;
				bool result;
				try
				{
					num = (short)1519321106;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						int num4;
						int num6;
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset radioInformationRecset;
						string id_MAXPCHANNELSEXCEEDEDDYNAMICZONEREQUIRES16FREECHANNELSINTHECODEPLUG;
						switch (num3)
						{
						case 0:
							if (zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
							{
								num = (short)1852571653;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_64F;
						case 1:
							num = (short)1876295706;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)1227423760;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							try
							{
								num = (short)97714179;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									bool flag2;
									switch (num3)
									{
									case 0:
										flag2 = (acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value;
										goto IL_891;
									case 1:
										flag2 = false;
										goto IL_891;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_718;
										}
										continue;
									case 5:
										num = (short)81526784;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										if (!enumerator.MoveNext())
										{
											num = (short)1746075657;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureNode = enumerator.Current;
										num = (short)362151946;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
										{
											num = (short)1740832779;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_71A;
									case 8:
										goto IL_8F9;
									case 9:
										num = (short)1316028424;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										if (flag)
										{
											num = (short)506855429;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1717895169;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
										num4 += 16;
										num = (short)1389232130;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_718;
									IL_71A:
									num4 += (acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Channels.EmbeddedRecset.Count;
									num = (short)69009412;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_76C:
									num = (short)442155900;
									short num5 = num;
									num = (short)1112523644;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_71A;
									default:
										num = (short)1299251200;
										if (num != 0)
										{
										}
										num = (short)307822598;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_718:
									goto IL_76C;
									IL_891:
									flag = flag2;
									num = (short)1340932103;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_8F9:
								goto IL_9D2;
							}
							finally
							{
								num = (short)2110783488;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_930;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)887947266;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_968;
									}
									IL_930:
									if (enumerator == null)
									{
										break;
									}
									num = (short)864485377;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_968:;
							}
							goto IL_96B;
							IL_9D2:
							num = (short)437977127;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1623851045;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							result = false;
							num = (short)783613961;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::AcpBusinessLayer.AcpField<bool> znChanCfgFPPProtectionProtectedZone_A;
							if (znChanCfgFPPProtectionProtectedZone_A != null)
							{
								num = (short)374341636;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A58;
						}
						case 7:
							if (num4 > num6)
							{
								num = (short)1100873761;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_613;
						case 8:
							if (zoneChannelAssignmentRecset != null)
							{
								num = (short)1208156179;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A58;
						case 9:
							goto IL_288;
						case 10:
							if ((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
							{
								num = (short)866910248;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_64F;
						case 11:
						{
							if (flag)
							{
								num = (short)2000289804;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.AcpField<bool> znChanCfgFPPProtectionFPPEnable_A = zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562;
							global::AcpBusinessLayer.AcpField<bool> znChanCfgFPPProtectionProtectedZone_A = zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionProtectedZone_A8765;
							num = (short)682491948;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							result = false;
							num = (short)1458176035;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							num = (short)734396422;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_5C9;
						case 15:
							goto IL_96B;
						case 16:
						{
							global::AcpBusinessLayer.AcpField<bool> znChanCfgFPPProtectionProtectedZone_A;
							if (znChanCfgFPPProtectionProtectedZone_A)
							{
								num = (short)1151926299;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A58;
						}
						case 17:
							num6 = (radioInformationRecset[0][10108] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General).RadInfoGeneralMaximumChannels_A11479.Value;
							num = (short)1219297322;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							switch (0)
							{
							case 0:
								goto IL_17A;
							}
							continue;
						case 19:
							num = (short)2118844436;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							if (!zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
							{
								num = (short)2066481180;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1845755914;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							if (!global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_MAXPCHANNELSEXCEEDEDDYNAMICZONEREQUIRES16FREECHANNELSINTHECODEPLUG))
							{
								num = (short)2051407887;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4B4;
						case 22:
							goto IL_4D1;
						case 23:
							num = (short)604373024;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							goto IL_1DB;
						case 25:
							num = (short)992149512;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							if (channelAssignmentListInnerRecset.Count != 16)
							{
								num = (short)203948075;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_517;
						case 27:
							goto IL_2C9;
						case 28:
							result = true;
							num = (short)410845208;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							num = (short)103481382;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							if (radioInformationRecset != null)
							{
								num = (short)1877082141;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_69F;
						case 31:
							goto IL_2E4;
						case 32:
							if (zoneChannelAssignment != null)
							{
								num = (short)1437597721;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A58;
						case 33:
							id_MAXPCHANNELSEXCEEDEDDYNAMICZONEREQUIRES16FREECHANNELSINTHECODEPLUG = global::CommonResources.AcgResources.ID_MAXPCHANNELSEXCEEDEDDYNAMICZONEREQUIRES16FREECHANNELSINTHECODEPLUG;
							num = (short)1450967061;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
							if (channelAssignmentListInnerRecset != null)
							{
								num = (short)1084620801;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_517;
						case 35:
							goto IL_1BA;
						case 36:
							goto IL_A71;
						case 37:
						{
							global::AcpBusinessLayer.AcpField<bool> znChanCfgFPPProtectionFPPEnable_A;
							if (!znChanCfgFPPProtectionFPPEnable_A.Value)
							{
								num = (short)1107165186;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C9;
						}
						case 38:
							if (radioInformationRecset[0][10108] is global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General)
							{
								num = (short)1165164561;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_69F;
						case 39:
							if (zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
							{
								num = (short)904658985;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_613;
						case 40:
							num = (short)1380646912;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
							num = (short)1636499463;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
							goto IL_69F;
						case 43:
							result = false;
							num = (short)1676607502;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
						{
							global::AcpBusinessLayer.AcpField<bool> znChanCfgFPPProtectionFPPEnable_A;
							if (znChanCfgFPPProtectionFPPEnable_A != null)
							{
								num = (short)1230241805;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A58;
						}
						case 45:
							goto IL_4B4;
						}
						IL_17A:
						if (zone != null)
						{
							num = (short)1738211351;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A58;
						IL_2C9:
						result = false;
						num = (short)770375711;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_4B4:
						result = false;
						num = (short)1712652310;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_517:
						num4 = 0;
						num6 = 0;
						radioInformationRecset = null;
						radioInformationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset);
						num = (short)1096286238;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_613:
						num = (short)289538059;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_64F:
						channelAssignmentListInnerRecset = (zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset);
						num = (short)1929642018;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_69F:
						enumerator = zoneChannelAssignmentRecset.GetEnumerator();
						num = (short)1120862211;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_96B:
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, id_MAXPCHANNELSEXCEEDEDDYNAMICZONEREQUIRES16FREECHANNELSINTHECODEPLUG);
						num = (short)2041315373;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A58:
						num = (short)659488804;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1BA:
					IL_1DB:
					IL_288:
					IL_2E4:
					IL_4D1:
					IL_5C9:
					return result;
					IL_A71:
					return true;
				}
				catch (global::System.Exception)
				{
					result = false;
				}
				return result;
			}
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0002426C File Offset: 0x0002246C
		public static bool ConIsDynamicZoneEnableUnCheckedANDInLabtoolView(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			for (;;)
			{
				num = (short)1536491520;
				short num2 = num;
				if ((self.Parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
				{
					goto IL_AC;
				}
				num = (short)725267942;
				short num3 = num;
				num = (short)649836006;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8C;
				}
			}
			IL_8C:
			num = (short)697630720;
			if (num != 0)
			{
			}
			return global::AcpCommonLib.AppInfoManager.AppView == global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			IL_AC:
			num = (short)1915813889;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00024350 File Offset: 0x00022550
		public static bool ConFiregroundSectorIDIsEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)640483328;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_15;
				case 1:
					num = (short)585498627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)752550003;
					short num3 = num;
					num = (short)286523507;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
					{
						num = (short)683016193;
						if (num != 0)
						{
						}
						num = (short)1636892672;
						if (num != 0)
						{
						}
						global::AcpBusinessLayer.AcpRecRefField znChanCfgChannelsPersonality_A;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = znChanCfgChannelsPersonality_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						num = (short)1120010247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
					if (conventionalPersonality.Features.ConPerFeatureIncidentSignalingType_A41507.Value != 2)
					{
						num = (short)850919428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 4:
					num = (short)1033764869;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
					if (conventionalPersonality.Features.ConPerFeatureIncidentSignalingType_A41507.Value == 3)
					{
						num = (short)716898310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 6:
					return true;
				case 7:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
					if (conventionalPersonality != null)
					{
						num = (short)1813315585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				}
				goto IL_6F;
				IL_15:
				num = (short)1484259328;
				short num4 = num;
				switch (0)
				{
				case 0:
				{
					IL_6F:
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection;
					global::AcpBusinessLayer.AcpRecRefField znChanCfgChannelsPersonality_A = channelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698;
					if (channelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value != 0)
					{
						return false;
					}
					num = (short)1604583426;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return true;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00024550 File Offset: 0x00022750
		public static bool ConFiregroundSectorIDIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1383268352;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A6;
				}
				global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					int num5;
					int num6;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner != self.Parent)
						{
							num = (short)1883766799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38B;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
						zoneChannelAssignmentRecset = (channelAssignmentListInnerRecset.ParentSection.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
						num = (short)1196228628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1374696392;
						short num3 = num;
						num = (short)280769480;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_486;
						default:
						{
							num = (short)1206517760;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset2 = zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset;
							num = (short)1175519235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset2;
						if (channelAssignmentListInnerRecset2 != null)
						{
							num = (short)880541712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FE;
					}
					case 4:
					{
						global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A2;
						if (znChanCfgChannelsFiregroundSectorID_A.Value == znChanCfgChannelsFiregroundSectorID_A2.Value)
						{
							num = (short)17301505;
							if (num != 0)
							{
							}
							num = (short)1973747733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38B;
					}
					case 5:
						goto IL_202;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
						if (channelAssignmentListInnerRecset != null)
						{
							num = (short)567476224;
							short num4 = num;
							num = (short)213975064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 7:
					{
						if (znChanCfgChannelsFiregroundSectorID_A.Value == 0)
						{
							num = (short)352059411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset = self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset;
						num = (short)1693384710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_202;
					case 9:
						goto IL_3AF;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset2;
						if (num5 >= channelAssignmentListInnerRecset2.Count)
						{
							num = (short)938147851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = channelAssignmentListInnerRecset2[num5] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
						num = (short)160170009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_2FE;
					case 12:
						return true;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection != null)
						{
							num = (short)1276706839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38B;
					}
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630 != null)
						{
							num = (short)1779105819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38B;
					}
					case 15:
						num = (short)637337613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num5 = 0;
						num = (short)229048325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
						if (channelAssignmentListInnerRecset.ParentSection != null)
						{
							num = (short)1137311745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 18:
						if (num6 >= zoneChannelAssignmentRecset.Count)
						{
							num = (short)1376714764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_486;
					case 19:
						return true;
					case 20:
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)1172242454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 21:
						return false;
					case 22:
						num6 = 0;
						num = (short)1441398793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)662765582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)657260561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner != null)
						{
							num = (short)217055258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38B;
					}
					case 26:
						num = (short)899416064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A2 = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630;
						num = (short)1126039556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						goto IL_3AF;
					case 29:
						if (zoneChannelAssignment != null)
						{
							num = (short)2146238466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FE;
					}
					goto IL_A6;
					IL_202:
					num = (short)1069744138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FE:
					num6++;
					num = (short)556466204;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38B:
					num5++;
					num = (short)1320747016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AF:
					num = (short)1486422034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_486:
					zoneChannelAssignment = (zoneChannelAssignmentRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					num = (short)893779997;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_A6:
				znChanCfgChannelsFiregroundSectorID_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection).ZnChanCfgChannelsFiregroundSectorID_A33630;
				num = (short)1350959111;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00024AE0 File Offset: 0x00022CE0
		public static void ConFiregroundSectorIDValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
			global::AcpBusinessLayer.AcpRecRefField znChanCfgChannelsPersonality_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1097072641;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
					if (conventionalPersonality.Features.ConPerFeatureIncidentSignalingType_A41507.Value != 3)
					{
						goto IL_1C4;
					}
					num2 = (short)1143606355;
					short num3 = num2;
					num2 = (short)1643777107;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1BE;
					default:
						num2 = (short)1626996736;
						if (num2 != 0)
						{
						}
						num2 = (short)2121531395;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
					if (conventionalPersonality != null)
					{
						num2 = (short)203685894;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C4;
				}
				case 3:
					return;
				case 4:
					num2 = (short)709558273;
					if (num2 != 0)
					{
					}
					if (channelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
					{
						num2 = (short)1885208583;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C4;
				case 5:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
					if (conventionalPersonality.Features.ConPerFeatureIncidentSignalingType_A41507.Value != 2)
					{
						num2 = (short)1940193280;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 6:
					goto IL_1BE;
				case 7:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = znChanCfgChannelsPersonality_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
					num2 = (short)1291059202;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_30;
				IL_1BE:
				num2 = (short)616431621;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C4:
			num2 = (short)1016594432;
			short num4 = num2;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(channelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630, 0));
			return;
			IL_30:
			channelAssignmentListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
			znChanCfgChannelsPersonality_A = channelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698;
			num2 = (short)272826372;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00024CF0 File Offset: 0x00022EF0
		public static bool ConFiregroundSectorIDApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)314900480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AB;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					int num5;
					int num6;
					switch (num2)
					{
					case 0:
						num = (short)1108803610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_3EB;
					case 2:
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection != null)
						{
							num = (short)1828126728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset = channelAssignmentListInnerRecset.ParentSection.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset;
						num = (short)699334662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1397686274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1E0;
					case 6:
					{
						num = (short)883016724;
						short num3 = num;
						num = (short)833012756;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D6;
						default:
						{
							num = (short)1355350016;
							short num4 = num;
							num = (short)1880752128;
							if (num != 0)
							{
							}
							num = (short)692715521;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
							if (zoneChannelAssignmentRecset != null)
							{
								num = (short)1490419737;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						}
						break;
					}
					case 7:
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value != channelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value)
						{
							num = (short)838270989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30F;
					case 8:
						num = (short)1549271049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630 != null)
						{
							num = (short)1119682571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset2 = zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset;
						num = (short)588709906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1739653141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (!channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Valid)
						{
							num = (short)12058646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB;
					case 13:
						num = (short)1521221644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_1E0;
					case 15:
						goto IL_40F;
					case 16:
						goto IL_33D;
					case 17:
						goto IL_40F;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset2;
						if (channelAssignmentListInnerRecset2 != null)
						{
							num = (short)1457586196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33D;
					}
					case 19:
						if (channelAssignmentListInner != null)
						{
							num = (short)1998651396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB;
					case 20:
						num5 = 0;
						num = (short)515506181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value != 0)
						{
							num = (short)767492125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB;
					case 22:
						goto IL_30F;
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset2;
						if (num5 >= channelAssignmentListInnerRecset2.Count)
						{
							num = (short)1273823248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						channelAssignmentListInner = (channelAssignmentListInnerRecset2[num5] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
						num = (short)1124204563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						return true;
					case 25:
						num6 = 0;
						num = (short)1726545935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (channelAssignmentListInnerRecset.ParentSection != null)
						{
							num = (short)1669136387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 27:
						goto IL_D6;
					case 28:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
						if (num6 >= zoneChannelAssignmentRecset.Count)
						{
							num = (short)1436942360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = zoneChannelAssignmentRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						num = (short)1390477342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						num = (short)388825095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (zoneChannelAssignment != null)
						{
							num = (short)2039808010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33D;
					}
					}
					goto IL_AB;
					IL_D6:
					if (channelAssignmentListInnerRecset != null)
					{
						num = (short)158990336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1E0:
					num = (short)82706455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30F:
					channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.CalculateValidity();
					num = (short)1919549441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33D:
					num6++;
					num = (short)961806353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EB:
					num5++;
					num = (short)2555918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40F:
					num = (short)1861353500;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_AB:
				channelAssignmentListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
				channelAssignmentListInnerRecset = (self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset);
				num = (short)133890075;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000252BC File Offset: 0x000234BC
		internal static bool ConRemoteSiteInterfaceModeIsNotDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1989133888;
			short num2 = num;
			num = (short)2001126976;
			switch (num2 == num)
			{
			}
			num = (short)1519976448;
			if (num != 0)
			{
			}
			num = (short)1793654785;
			if (num != 0)
			{
			}
			num = (short)1317011456;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI).ZoneChannelAssignmentRSIMode_A41831 != 0;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00025378 File Offset: 0x00023578
		internal static bool ConRemoteSiteInterfaceModeIsNotDisabledAndNotIPMode(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI rsi = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI;
			if (rsi.ZoneChannelAssignmentRSIMode_A41831 != 0)
			{
				short num;
				for (;;)
				{
					num = (short)477626369;
					if (num != 0)
					{
					}
					num = (short)647920797;
					short num2 = num;
					num = (short)1496415389;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_74;
					}
				}
				IL_74:
				num = (short)514260992;
				short num3 = num;
				num = (short)2127953920;
				if (num != 0)
				{
				}
				return rsi.ZoneChannelAssignmentRSIMode_A41831 != 2;
			}
			return false;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0002544C File Offset: 0x0002364C
		internal static bool ConRemoteSiteInterfaceModeIsIPMode(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)901979765;
			short num2 = num;
			num = (short)1153244789;
			switch (num2 == num)
			{
			}
			num = (short)55312385;
			if (num != 0)
			{
			}
			num = (short)928120832;
			if (num != 0)
			{
			}
			num = (short)1617297408;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI).ZoneChannelAssignmentRSIMode_A41831 == 2;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00025508 File Offset: 0x00023708
		internal static bool ConRSIModeIsNotDisabledAndAutoDialIsEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI rsi = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI;
			if (rsi.ZoneChannelAssignmentRSIMode_A41831 != 0)
			{
				short num;
				for (;;)
				{
					num = (short)422732199;
					short num2 = num;
					num = (short)601842087;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4F;
					}
				}
				IL_4F:
				num = (short)1820590081;
				if (num != 0)
				{
				}
				num = (short)2072248320;
				short num3 = num;
				num = (short)1021116416;
				if (num != 0)
				{
				}
				return rsi.ZoneChannelAssignmentRSIAutoDial_A41832.Value;
			}
			return false;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000255D8 File Offset: 0x000237D8
		internal static bool ConRSIModeIsNotDisabledOrIPAndAutoDialIsEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI rsi;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2132672512;
					short num3 = num2;
					if (rsi.ZoneChannelAssignmentRSIMode_A41831 != 2)
					{
						num2 = (short)1300889602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 1:
				{
					num2 = (short)1155792897;
					if (num2 != 0)
					{
					}
					num2 = (short)2055775567;
					short num4 = num2;
					num2 = (short)535012687;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1548681216;
						if (num2 != 0)
						{
						}
						num2 = (short)1298792448;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_147;
				case 3:
					if (rsi.ZoneChannelAssignmentRSIMode_A41831 != 0)
					{
						num2 = (short)1515847681;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_20;
			}
			IL_147:
			return rsi.ZoneChannelAssignmentRSIAutoDial_A41832.Value;
			IL_20:
			rsi = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI);
			num2 = (short)70189059;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00025734 File Offset: 0x00023934
		public static bool ConRSIModeIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_110;
				case 1:
					num2 = (short)788463619;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1434032813;
					short num3 = num2;
					num2 = (short)1613601453;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)809304064;
						if (num2 != 0)
						{
						}
						if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num2 = (short)1519058945;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 3:
					if (zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562.Value)
					{
						num2 = (short)1269235712;
						short num4 = num2;
						num2 = (short)775880704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					if (index != 0)
					{
						num2 = (short)1689976837;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					num2 = (short)824639489;
					if (num2 != 0)
					{
					}
					num2 = (short)1077018626;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
			}
			return false;
			IL_110:
			return false;
			IL_28:
			zoneChannelAssignment = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			global::AcpCommonLib.IAcpRecordset embeddedRecset = self.Parent[10114].EmbeddedRecset;
			num2 = (short)1235681284;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000258EC File Offset: 0x00023AEC
		public static bool ConTriggerScanListZoneValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)644612096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset scanListRecset;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num2)
					{
					case 0:
						goto IL_3ED;
					case 1:
					{
						num = (short)67633152;
						short num3 = num;
						if (scanListRecset.Count != 0)
						{
							num = (short)472317952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 2:
						try
						{
							num = (short)645857283;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)1206255619;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
												scanListInner.ScanListInnerSection.ScanLstScanListZone_A9718.CalculateValidity();
												num = (short)1870331908;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
												if (scanListInner.ScanListInnerSection.ScanLstScanListZone_A9718.ReferencedNode == self.Parent)
												{
													num = (short)1545142272;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 2:
												num = (short)698089477;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_19C;
												}
												continue;
											case 5:
												goto IL_279;
											case 6:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)365494274;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)enumerator.Current;
												num = (short)288030721;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_19E:
											num = (short)187432966;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_19C:
											goto IL_19E;
										}
										IL_279:
										break;
									}
									finally
									{
										num = (short)1253244930;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)818348033;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_2EA;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_2B2;
												}
												continue;
											}
											IL_2B2:
											if (enumerator == null)
											{
												break;
											}
											num = (short)881524736;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2EA:;
									}
									goto IL_2ED;
								case 1:
									num = (short)1311637509;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2ED;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_CC;
									}
									continue;
								case 4:
									if (!enumerator2.MoveNext())
									{
										num = (short)1867186177;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									scanListInnerRecset = (((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator2.Current).ScanListMembers.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset);
									num = (short)1361117190;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_32B;
								case 6:
									if (scanListInnerRecset != null)
									{
										num = (short)873201666;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_11C:
								num = (short)473235460;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CC:
								goto IL_11C;
								IL_2ED:
								enumerator = scanListInnerRecset.GetEnumerator();
								num = (short)1846083584;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_32B:
							return true;
						}
						finally
						{
							num = (short)1746534402;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3CC;
								case 1:
									goto IL_3EA;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_363;
									}
									continue;
								}
								IL_363:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1418524178;
								short num4 = num;
								num = (short)214496786;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)791674880;
									if (num != 0)
									{
									}
									num = (short)1161101312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3CC:
								enumerator2.Dispose();
								num = (short)1171062785;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3EA:;
						}
						goto IL_3ED;
					case 3:
						if (scanListRecset != null)
						{
							num = (short)776732676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						num = (short)1602551809;
						if (num != 0)
						{
						}
						num = (short)755105793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43;
					IL_3ED:
					enumerator2 = scanListRecset.GetEnumerator();
					num = (short)950009858;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_43:
				scanListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset);
				num = (short)1526071299;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00025DD0 File Offset: 0x00023FD0
		public static bool ConRSIAndNonRSIMutual(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1385758720;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E6;
				}
				global::AcpBusinessLayer.AcpRecRefField znChanCfgChannelsPersonality_A;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1097269279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem != null)
						{
							num = (short)1623982081;
							if (num != 0)
							{
							}
							num = (short)1389953030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, conventionalPersonality.Permissions))
						{
							num = (short)663552027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D5;
					}
					case 3:
						if (znChanCfgChannelsPersonality_A.RefRecset == null)
						{
							num = (short)1318518829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)306053142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (channelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 1)
						{
							num = (short)1905721355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						if (index <= znChanCfgChannelsPersonality_A.RefRecset.Count)
						{
							num = (short)1254162474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A8;
					case 6:
						num = (short)2072772638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (index > 0)
						{
							num = (short)608174105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A8;
					case 8:
						num = (short)1232207901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1418723361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_194;
					case 11:
						num = (short)1888813100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						return false;
					case 13:
						num = (short)1382023186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num = (short)1265041420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 15:
						num = (short)146866195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality != null)
						{
							num = (short)1766981673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 17:
						num = (short)892862465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (!zoneChannelAssignment.Zone.ZnChanCfgZoneZoneCloningEnable_43119)
						{
							num = (short)1273430037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D5;
					case 19:
						if (zoneChannelAssignment.RSI != null)
						{
							num = (short)1662910472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value)
						{
							num = (short)1129578496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 21:
						num = (short)893321218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (channelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
						{
							num = (short)1327693848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A8;
					case 23:
						return false;
					case 24:
						num = (short)1133510663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)1232797701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (zoneChannelAssignment.RSI != null)
						{
							num = (short)95617063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 27:
						return false;
					case 28:
						num = (short)1727397902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.Value != 0)
						{
							num = (short)523632677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 30:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value)
						{
							num = (short)738197532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 31:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 2)
						{
							num = (short)390004746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 32:
					{
						num = (short)1346568192;
						short num3 = num;
						num = (short)1665736795;
						short num4 = num;
						num = (short)1120215131;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return false;
						default:
							num = (short)234225664;
							if (num != 0)
							{
							}
							if (zoneChannelAssignment != null)
							{
								num = (short)1888747535;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						break;
					}
					case 33:
						if (index <= znChanCfgChannelsPersonality_A.RefRecset.Count)
						{
							num = (short)1677393963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 34:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem == null)
						{
							num = (short)1247936535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)100073492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						if (zoneChannelAssignment != null)
						{
							num = (short)57671718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 36:
						if (zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.Value == 0)
						{
							num = (short)1883439121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)918093858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						return false;
					case 38:
						num = (short)527958042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
						num = (short)1689845796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality != null)
						{
							num = (short)1943797773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D5;
					}
					case 41:
						num = (short)1888419875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = znChanCfgChannelsPersonality_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						num = (short)295960616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						num = (short)1620770848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (index > 0)
						{
							num = (short)392626185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 45:
						return true;
					}
					goto IL_E6;
					IL_4D5:
					num = (short)1537802256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A8:
					num = (short)786169860;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_194:
				return false;
				IL_E6:
				zoneChannelAssignment = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				channelAssignmentListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
				znChanCfgChannelsPersonality_A = channelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698;
				num = (short)1605959683;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000265CC File Offset: 0x000247CC
		internal static bool ConRSIModeIsDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1929082398;
			short num2 = num;
			num = (short)1531278878;
			switch (num2 == num)
			{
			default:
			{
				num = (short)896008192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1585840129;
			if (num != 0)
			{
			}
			num = (short)377815040;
			if (num != 0)
			{
			}
			return (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).RSI.ZoneChannelAssignmentRSIMode_A41831 == 0;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0002669C File Offset: 0x0002489C
		internal static bool ConZoneCheckRSIModeIsDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)845873153;
			if (num != 0)
			{
			}
			num = (short)852557824;
			short num2 = num;
			num = (short)2071212620;
			short num3 = num;
			num = (short)920269388;
			switch (num3 == num)
			{
			}
			num = (short)547946496;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).RSI.ZoneChannelAssignmentRSIMode_A41831 == 0;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00026760 File Offset: 0x00024960
		public static bool ConIsNotDZPAndFPPAndIRSI(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_217;
				case 1:
					if (zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562.Value)
					{
						num2 = (short)1869545472;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					if (zoneChannelAssignment != null)
					{
						num2 = (short)2094661637;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)276299780;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9D;
				case 4:
					num2 = (short)1010565121;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1613234179;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1352597505;
					if (num2 != 0)
					{
					}
					zoneChannelAssignment = (self.Parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					num2 = (short)978911239;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1A0;
				case 8:
					if (zoneChannelAssignment == null)
					{
						num2 = (short)644415494;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A0;
				}
				goto IL_34;
				IL_1A0:
				num2 = (short)1367080962;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_9D:
			num2 = (short)1942370044;
			short num3 = num2;
			num2 = (short)632239868;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
			{
				num2 = (short)1582366720;
				if (num2 != 0)
				{
				}
				num2 = (short)239534080;
				short num4 = num2;
				return zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.Value != 0;
			}
			}
			return true;
			IL_217:
			goto IL_9D;
			IL_34:
			zoneChannelAssignment = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num2 = (short)666632200;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0002698C File Offset: 0x00024B8C
		public static bool ConIsNotDZPAndFPPEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_183;
				case 1:
					if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)995164165;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)1709928578;
					short num3 = num2;
					num2 = (short)529625218;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_183;
					case 1:
						break;
					default:
					{
						num2 = (short)1568735232;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1647771648;
					if (num2 != 0)
					{
					}
					zoneChannelAssignment = (self.Parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					num2 = (short)1238695939;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_16B;
				case 4:
					num2 = (short)137691137;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_131;
				case 6:
					if (zoneChannelAssignment == null)
					{
						num2 = (short)714932226;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16B;
				}
				goto IL_2C;
				IL_16B:
				num2 = (short)1127088128;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_183:
				num2 = (short)1322057729;
				if (num2 != 0)
				{
				}
				if (zoneChannelAssignment == null)
				{
					return true;
				}
				num2 = (short)1907228676;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_131:
			return !zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562.Value;
			IL_2C:
			zoneChannelAssignment = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num2 = (short)131006470;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00026B64 File Offset: 0x00024D64
		public static bool ConIsMainComparatorHostnameValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI rsi;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1337982979;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return false;
				case 2:
					if (rsi.ZoneChannelAssignmentRSIMode_A41831Value == 2)
					{
						goto IL_1B3;
					}
					return true;
				case 3:
					if (rsi.MainComparatorHostname_43796Value.Length > 63)
					{
						num2 = (short)1131806721;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
				{
					num2 = (short)982948631;
					short num3 = num2;
					num2 = (short)505977623;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B3;
					case 1:
						break;
					default:
					{
						num2 = (short)677249024;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)869335040;
					if (num2 != 0)
					{
					}
					num2 = (short)72810497;
					if (num2 != 0)
					{
					}
					num2 = (short)1657012226;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					num2 = (short)308477958;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (rsi.MainComparatorHostname_43796Value.Length >= 1)
					{
						num2 = (short)594673664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					if (rsi != null)
					{
						num2 = (short)158793732;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_30;
				IL_1B3:
				num2 = (short)276758533;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_30:
			rsi = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI);
			num2 = (short)1930428423;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00026D40 File Offset: 0x00024F40
		public static void ConZoneChannelAssignmentCloningEnableValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 11;
			short num = (short)1383661568;
			switch (num)
			{
			default:
			{
				num = (short)67502086;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					global::AcpBusinessLayer.AcpField<bool> znChanCfgZoneZoneCloningEnable_;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
					global::AcpBusinessLayer.AcpField<bool> znChanCfgZoneDynamicZoneEnable_A;
					bool suspended;
					switch (num2)
					{
					case 0:
						goto IL_1AF0;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_273;
							}
							int num6;
							int num12;
							for (;;)
							{
								IL_98:
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
								global::AcpBusinessLayer.FeatureNode featureNode2;
								int num5;
								int newValue;
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
								global::AcpBusinessLayer.FeatureNode[] array2;
								global::System.Collections.Generic.List<int> list;
								int num10;
								int num11;
								int num13;
								global::AcpBusinessLayer.FeatureNode[] array4;
								int num14;
								global::AcpBusinessLayer.FeatureNode featureNode5;
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
								switch (num2)
								{
								case 0:
									num = (short)53018713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)498794582;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1474428981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode = channelAssignmentListInnerRecset.CreateDefaultRecord();
									featureNode.KeyField.Editable = false;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode));
									featureNode.KeyField.Editable = true;
									channelAssignmentListInnerSection = (featureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ChannelAssignmentListInnerSection;
									global::AcpBusinessLayer.FeatureNode referencedNode = channelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode;
									featureNode2 = null;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalPersonalityRecset.GetEnumerator();
									num = (short)2056454194;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									int num3;
									if (num3 >= 16)
									{
										num = (short)307560494;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num4;
									conventionalPersonalityRecset.MoveRecord(conventionalPersonalityRecset.Count - 1, num4, task);
									num3++;
									num = (short)1270087764;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_142B;
								case 6:
									goto IL_C1D;
								case 7:
									goto IL_152F;
								case 8:
									goto IL_979;
								case 9:
									if (znChanCfgZoneZoneCloningEnable_.Value)
									{
										num = (short)1362100304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(zoneChannelAssignment, global::AcpCommonLib.Permissions.None));
									num = (short)591396913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_1126;
								case 11:
									if (channelAssignmentListInnerRecset.Count == 16)
									{
										num = (short)32833539;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18C1;
								case 12:
									num = (short)967508063;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									num = (short)205520972;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (num5 >= 15)
									{
										num = (short)1587478642;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1952317485;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									goto IL_1075;
								case 16:
									if (radioInformation.Labtool.RadInfoLabtoolQ806IMBE_A8191.Value)
									{
										num = (short)464519206;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C5E;
								case 17:
									num = (short)1209335867;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_1670;
								case 19:
									num = (short)99156036;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									goto IL_1126;
								case 21:
								{
									global::AcpBusinessLayer.FeatureNode referencedNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(referencedNode2, global::AcpCommonLib.Permissions.None));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(referencedNode2));
									num = (short)1763770403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
								{
									if (channelAssignmentListInnerRecset.Count <= 1)
									{
										num = (short)1954676753;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode3 = zoneChannelAssignment.Channels.EmbeddedRecset[zoneChannelAssignment.Channels.EmbeddedRecset.Count - 2] as global::AcpBusinessLayer.FeatureNode;
									global::AcpBusinessLayer.FeatureNode referencedNode2 = (featureNode3 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode;
									num = (short)1358364782;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMinTask(conventionalPersonalityRecset, newValue));
									num = (short)521076815;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									if (featureNode2 == null)
									{
										num = (short)909836399;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1818;
								case 25:
									goto IL_15CF;
								case 26:
									if (global::AcpCommonLib.AppInfoManager.ImportCopyOperation)
									{
										num = (short)1395982343;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_177D;
								case 27:
									goto IL_18C1;
								case 28:
									if (znChanCfgZoneZoneCloningEnable_.Value)
									{
										num = (short)408748113;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F55;
								case 29:
									goto IL_A6E;
								case 30:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283.UIValue.Equals(astrotalkgroupList.ReferenceKey))
									{
										num = (short)159055984;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6B3;
								}
								case 31:
								{
									if (num6 >= zoneChannelAssignmentRecset.Count)
									{
										num = (short)129630227;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2 = zoneChannelAssignmentRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
									num = (short)1173159990;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 32:
									goto IL_16E6;
								case 33:
									goto IL_142B;
								case 34:
									num = (short)1098121286;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
									goto IL_47D;
								case 36:
									goto IL_6D5;
								case 37:
									goto IL_635;
								case 38:
									conventionalPersonality2.Signaling.CnvPerSignalingASTROSystem_A7498.UIValue = conventionalSystemRecset[0].ReferenceKey;
									num = (short)595591223;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
									if (channelAssignmentListInnerRecset.Count > 1)
									{
										num = (short)2050097200;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_979;
								case 40:
								{
									global::AcpBusinessLayer.FeatureNode[] array = array2;
									int num7 = 0;
									num = (short)133758996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 41:
									if (!global::AcpCommonLib.AppInfoManager.DndOperation)
									{
										num = (short)1993146473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_152F;
								case 42:
									goto IL_15CF;
								case 43:
									goto IL_E5F;
								case 44:
									goto IL_635;
								case 45:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
									global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset talkgroupTableInnerRecset;
									if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.UIValue.Equals(talkgroupTableInnerRecset[num5 * 16].ReferenceKey))
									{
										num = (short)1256915037;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_164C;
								}
								case 46:
								{
									int num4;
									int num8 = num4;
									num = (short)864747628;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 47:
									goto IL_588;
								case 48:
								{
									global::AcpBusinessLayer.FeatureNode[] array3 = new global::AcpBusinessLayer.FeatureNode[channelAssignmentListInnerRecset.Count - 1];
									int num9 = 1;
									num = (short)874512476;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 49:
									goto IL_C1D;
								case 50:
									try
									{
										num = (short)1288896516;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::AcpBusinessLayer.FeatureNode featureNode4;
												if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, featureNode4.Permissions))
												{
													num = (short)218759173;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 1:
												goto IL_368;
											case 2:
												goto IL_40C;
											case 3:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1681653766;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpBusinessLayer.FeatureNode featureNode4 = enumerator.Current;
												num = (short)1860698112;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_34D;
												}
												continue;
											case 5:
											{
												global::AcpBusinessLayer.FeatureNode featureNode4;
												featureNode2 = featureNode4;
												num = (short)701759489;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												num = (short)741343234;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_36D:
											num = (short)2121531395;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_34D:
											goto IL_36D;
										}
										IL_368:
										IL_40C:
										goto IL_FB5;
									}
									finally
									{
										num = (short)460783616;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_443;
												}
												continue;
											case 1:
												goto IL_47A;
											case 2:
												enumerator.Dispose();
												num = (short)514457601;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_443:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1219559426;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_47A:;
									}
									goto IL_47D;
									IL_FB5:
									num = (short)874709016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 51:
									goto IL_7FA;
								case 52:
									num = (short)388956247;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
									if (list.Count <= 0)
									{
										num = (short)590479372;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num10 = list[0] * 16;
									num = (short)329056295;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 54:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
									if (zoneChannelAssignment2 != null)
									{
										num = (short)145227832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_16E6;
								}
								case 55:
									goto IL_C5E;
								case 56:
									num = (short)19333198;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 57:
									goto IL_1167;
								case 58:
								{
									int num4;
									int num8;
									if (num8 >= num4 + 16)
									{
										num = (short)565248100;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(conventionalPersonalityRecset[num4], (global::AcpCommonLib.Permissions)79));
									num8++;
									num = (short)455344237;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 59:
									goto IL_191B;
								case 60:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMaxTask(conventionalPersonalityRecset, conventionalPersonalityRecset.Max - 16));
									num = (short)613351467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 61:
								{
									int num9;
									if (num9 >= channelAssignmentListInnerRecset.Count)
									{
										num = (short)522059882;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(channelAssignmentListInnerRecset[num9], global::AcpCommonLib.Permissions.None));
									global::AcpBusinessLayer.FeatureNode[] array3;
									array3[channelAssignmentListInnerRecset.Count - 1 - num9] = (channelAssignmentListInnerRecset[num9] as global::AcpBusinessLayer.FeatureNode);
									num9++;
									num = (short)1212874809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 62:
								{
									if (num11 >= num12 - 1)
									{
										num = (short)2093678594;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = conventionalPersonalityRecset[num11 * 16] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)2143813701;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 63:
									if (task.ToString() == global::AllFeatures.CodeplugGuid.b("迋ꛍ뇏병돓돕龎ﻛ髝駟賡藣该臧觩쳫듭鿯鳱釳훵뷷铹鷻鳽泿朁☃", a_))
									{
										num = (short)1918042146;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F55;
								case 64:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
									if (!zoneChannelAssignment2.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
									{
										num = (short)943980659;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_16E6;
								}
								case 65:
									if (znChanCfgZoneZoneCloningEnable_.Value)
									{
										num = (short)1624637453;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2C9;
								case 66:
									num = (short)1308491818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 67:
									goto IL_6D5;
								case 68:
									if (num12 > 15)
									{
										num = (short)1971257396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									newValue = num12 * 16 + 1;
									num = (short)1728512009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 69:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality == null)
									{
										num = (short)166789192;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1706623006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 70:
									if (!znChanCfgZoneDynamicZoneEnable_A.Value)
									{
										num = (short)1808334931;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F55;
								case 71:
									goto IL_1818;
								case 72:
									num = (short)680591411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 73:
									if (channelAssignmentListInnerRecset.Count <= 16)
									{
										num = (short)1220804631;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(channelAssignmentListInnerRecset[0] as global::AcpBusinessLayer.FeatureNode));
									num = (short)1523908633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 74:
								{
									global::AcpBusinessLayer.FeatureNode[] array;
									int num7;
									if (num7 >= array.Length)
									{
										num = (short)1007812709;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									array[num7].KeyField.Editable = false;
									num7++;
									num = (short)447676483;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 75:
								{
									global::AcpBusinessLayer.FeatureNode featureNode3;
									if (featureNode3 != null)
									{
										num = (short)1079509090;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18C1;
								}
								case 76:
									if (!(task.ToString() != global::AllFeatures.CodeplugGuid.b("迋ꛍ뇏병돓돕龎ﻛ髝駟賡藣该臧觩쳫듭鿯鳱釳훵뷷铹鷻鳽泿朁☃", a_)))
									{
										num = (short)1285488736;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7FF;
								case 77:
									goto IL_6B3;
								case 78:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
									if (zoneChannelAssignment2.Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
									{
										num = (short)1260519527;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_16E6;
								}
								case 79:
									goto IL_F30;
								case 80:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(zoneChannelAssignment, (global::AcpCommonLib.Permissions)705));
									num = (short)705298438;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 81:
									num = (short)1323827263;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 82:
									goto IL_18C1;
								case 83:
									goto IL_7FF;
								case 84:
									goto IL_1670;
								case 85:
									if (num13 >= 16)
									{
										num = (short)1658585154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									array2[num13].KeyField.Editable = true;
									array4[num13].KeyField.Editable = true;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(array2[num13], (global::AcpCommonLib.Permissions)79));
									conventionalPersonality2 = (array2[num13] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality);
									conventionalPersonality2.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.Value = false;
									num = (short)1512505360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 86:
									if (znChanCfgZoneZoneCloningEnable_.Value)
									{
										num = (short)1277952060;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMaxTask(conventionalPersonalityRecset, conventionalPersonalityRecset.Max + 16));
									num = (short)203882543;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 87:
									goto IL_1487;
								case 88:
									goto IL_A6E;
								case 89:
									if (task.ToString() != global::AllFeatures.CodeplugGuid.b("迋ꛍ뇏병돓돕龎ﻛ髝駟賡藣该臧觩쳫듭鿯鳱釳훵뷷铹鷻鳽泿朁☃", a_))
									{
										num = (short)2026766337;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_769;
								case 90:
									goto IL_1075;
								case 91:
								{
									global::AcpBusinessLayer.FeatureNode[] array;
									int num7;
									if (num7 >= array.Length)
									{
										num = (short)748486769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									array[num7].KeyField.Editable = false;
									num7++;
									num = (short)624295946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 92:
									goto IL_1167;
								case 93:
									num = (short)908787809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 94:
									goto IL_177D;
								case 95:
									goto IL_1070;
								case 96:
									goto IL_2C9;
								case 97:
									if (list.Contains(num5))
									{
										num = (short)793837675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_164C;
								case 98:
								{
									global::AcpBusinessLayer.FeatureNode featureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(featureNode3, global::AcpCommonLib.Permissions.None));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(featureNode3));
									num = (short)341901394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 99:
									if (num14 >= 16)
									{
										num = (short)847708200;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									featureNode5 = conventionalPersonalityRecset.CreateDefaultRecord();
									frequencyOptionsInnerRecset = ((featureNode5 as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality).FrequencyOptions.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset);
									num = (short)939196457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 100:
									num13 = 0;
									num = (short)1162281004;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 101:
								{
									task.AddTask(new global::AcpBusinessLayer.AddMultipleRecordsTask(array2));
									task.AddTask(new global::AcpBusinessLayer.AddMultipleRecordsTask(array4));
									int num4 = (num12 - 1) * 16;
									int num3 = 0;
									num = (short)1201864722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 102:
									goto IL_673;
								case 103:
									num = (short)836304960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 104:
									goto IL_673;
								case 105:
									num = (short)307167258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 106:
								{
									global::AcpBusinessLayer.FeatureNode[] array3;
									task.AddTask(new global::AcpBusinessLayer.DeleteMultipleRecordsTask(array3));
									num = (short)1571553288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 107:
									list.Remove(num5);
									num = (short)190382157;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 108:
									goto IL_10E4;
								case 109:
									goto IL_10E4;
								case 110:
								{
									global::AcpBusinessLayer.FeatureNode referencedNode2;
									if (referencedNode2 != null)
									{
										num = (short)338821141;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_47D;
								}
								case 111:
									featureNode2 = conventionalPersonalityRecset.CreateDefaultRecord();
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(featureNode2, global::AcpCommonLib.Permissions.None));
									featureNode2.KeyField.Editable = false;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode2));
									featureNode2.KeyField.Editable = true;
									num = (short)222625863;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 112:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = (conventionalPersonality.FrequencyOptions.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner;
									global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset talkgroupTableInnerRecset = astrotalkgroupList.TalkgroupList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset;
									num5 = 0;
									num = (short)2042036253;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 113:
								{
									global::AcpBusinessLayer.FeatureNode[] array = array4;
									int num7 = 0;
									num = (short)1702297636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 114:
									goto IL_6B3;
								case 115:
									num12++;
									num = (short)242155552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 116:
									if (znChanCfgZoneDynamicZoneEnable_A.Value)
									{
										num = (short)524025856;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_769;
								}
								goto IL_273;
								IL_2C9:
								num = (short)2045771804;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_47D:
								num = (short)1093533771;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_635:
								num = (short)1006108757;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_673:
								num = (short)2026111038;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6B3:
								num11++;
								num = (short)2021916776;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6D5:
								num = (short)1996947530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_769:
								num = (short)884867137;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7FF:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(channelAssignmentListInnerRecset, (global::AcpCommonLib.Permissions)768));
								list = new global::System.Collections.Generic.List<int>
								{
									0,
									1,
									2,
									3,
									4,
									5,
									6,
									7,
									8,
									9,
									10,
									11,
									12,
									13,
									14
								};
								num10 = 0;
								num11 = 0;
								num = (short)1924923494;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_979:
								array4 = new global::AcpBusinessLayer.FeatureNode[16];
								array2 = new global::AcpBusinessLayer.FeatureNode[16];
								num14 = 0;
								num = (short)833486938;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A6E:
								num = (short)348323854;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C1D:
								num = (short)2096889972;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C5E:
								conventionalPersonality2.Signaling.CnvPerSignalingSignalingType_A9129.Value = 0;
								conventionalPersonality2.ASTROCall.CnvPerASTROCallSelectiveCallRxTx_A9114.Value = 0;
								conventionalPersonality2.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283.UIValue = astrotalkgroupList.ReferenceKey;
								conventionalPersonality2.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsSelectionType_A9112.Value = 0;
								conventionalPersonality2.Features.CnvPerFeaturesMixedVoteScanEnable_A38723.Value = false;
								conventionalPersonality2.Secure.CnvPerSecureSecureClearStrapping1_A9090.Value = 0;
								conventionalPersonality2.Secure.CnvPerSecureSecureClearStrapping2_A9091.Value = 0;
								conventionalPersonality2.Secure.CnvPerSecureASTROOTAR_A7493.Value = false;
								conventionalPersonality2.Features.CnvPerFeatureRFModem_42485.Value = 0;
								conventionalPersonality2.Features.ConPerFeatureIncidentSignalingType_A41507.Value = 0;
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset2 = conventionalPersonality2.FrequencyOptions.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset;
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner2 = frequencyOptionsInnerRecset2[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner;
								global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset talkgroupTableInnerRecset2 = astrotalkgroupList.TalkgroupList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset;
								int index = num10 + num13;
								frequencyOptionsInner2.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.UIValue = talkgroupTableInnerRecset2[index].ReferenceKey;
								frequencyOptionsInner2.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Value = 0;
								(array4[num13] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value = 0;
								(array4[num13] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.UIValue = conventionalPersonality2.ReferenceKey;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(frequencyOptionsInnerRecset2, (global::AcpCommonLib.Permissions)768));
								num13++;
								num = (short)876019749;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F55:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(channelAssignmentListInnerRecset, global::AcpCommonLib.Permissions.None));
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMinTask(conventionalPersonalityRecset, newValue));
								num = (short)1102315531;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1075:
								num = (short)2108096611;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10E4:
								num = (short)1607663674;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1126:
								num = (short)2100953179;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1167:
								num = (short)1523712061;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_142B:
								num = (short)2113667103;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_152F:
								global::AcpBusinessLayer.FeatureNode featureNode6 = frequencyOptionsInnerRecset.CreateDefaultRecord();
								featureNode6.KeyField.Editable = false;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode6));
								featureNode6.KeyField.Editable = true;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(frequencyOptionsInnerRecset[0] as global::AcpBusinessLayer.FeatureNode));
								num = (short)1590886494;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_15CF:
								num = (short)1953890377;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_164C:
								num5++;
								num = (short)72417368;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1670:
								num = (short)704708612;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16E6:
								num6++;
								num = (short)95813665;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_177D:
								array2[num14] = featureNode5;
								global::AcpBusinessLayer.FeatureNode featureNode7 = channelAssignmentListInnerRecset.CreateDefaultRecord();
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(featureNode7, (global::AcpCommonLib.Permissions)15));
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection2 = (featureNode7 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ChannelAssignmentListInnerSection;
								array4[num14] = featureNode7;
								num14++;
								num = (short)1081671695;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1818:
								channelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.UIValue = featureNode2.ReferenceKey;
								num = (short)1852571675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18C1:
								num = (short)2004615190;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_588:
							IL_7FA:
							IL_E5F:
							return;
							IL_F30:
							goto IL_1AD1;
							IL_1070:
							IL_1487:
							return;
							IL_191B:
							goto IL_1AD1;
							IL_273:
							num12 = 0;
							num6 = 0;
							num = (short)1709834245;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_98;
						}
						finally
						{
							num = (short)1812398080;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1952;
									}
									continue;
								case 1:
									goto IL_198B;
								case 2:
									global::AcpCommonLib.ConstraintManager.Resume();
									goto IL_1974;
								}
								IL_1952:
								if (!suspended)
								{
									num = (short)614531074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_198B;
								IL_1974:
								num = (short)831979521;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_198B:
								num = (short)748957468;
								short num15 = num;
								num = (short)151727900;
								switch ((num15 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1974;
								default:
									goto IL_19C0;
								}
							}
							IL_19C0:
							num = (short)617086976;
							if (num != 0)
							{
							}
							self.CallConstraints();
						}
						goto IL_19DC;
						IL_1AD1:
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.a(zoneChannelAssignmentRecset);
						num = (short)533069824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_89;
					case 3:
						global::AcpCommonLib.ConstraintManager.Suspend();
						num = (short)1400897540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_19DC;
					case 5:
						if (!suspended)
						{
							num = (short)978452483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19DC;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					}
					IL_69:
					if (global::AcpCommonLib.AppInfoManager.SkipValueSetter)
					{
						num = (short)476053506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone;
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					znChanCfgZoneZoneCloningEnable_ = zone.ZnChanCfgZoneZoneCloningEnable_43119;
					znChanCfgZoneDynamicZoneEnable_A = zone.ZnChanCfgZoneDynamicZoneEnable_A41257;
					zoneChannelAssignment = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					channelAssignmentListInnerRecset = (zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset);
					global::AcpBusinessLayer.Recordset recordset = global::AcpCommonLib.FeatureManager.GetFeature(2062) as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset;
					conventionalSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset);
					zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
					astrotalkgroupList = (recordset[0] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList);
					suspended = global::AcpCommonLib.ConstraintManager.Suspended;
					num = (short)1723465733;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19DC:
					num = (short)1245052929;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_89:
				num = (short)1506410497;
				if (num != 0)
				{
				}
				return;
				IL_1AF0:
				num = (short)1440546816;
				short num16 = num;
				return;
			}
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000288E8 File Offset: 0x00026AE8
		internal static bool ConIsVoiceAnnouncementVoiceControlApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1638727680;
			switch (num)
			{
			default:
			{
				num = (short)1190526991;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				for (;;)
				{
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					global::AcpBusinessLayer.AcpListField radWideFeaturesVoiceControlPriority;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
					switch (num2)
					{
					case 0:
						goto IL_169;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone;
						num = (short)814874625;
						if (num != 0)
						{
						}
						num = (short)808910861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_B2;
					case 3:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
						if (feature == null)
						{
							num = (short)1007812614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpFeatureNode = feature[0];
						goto IL_345;
					}
					case 4:
						goto IL_2FA;
					case 5:
						if (radWideFeaturesVoiceControlPriority != null)
						{
							num = (short)2091778062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
						acpFeatureNode = null;
						goto IL_345;
					case 7:
						num = (short)2032205832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						return false;
					case 9:
						return false;
					case 10:
						if (radioWide != null)
						{
							num = (short)974389266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 11:
						if (channelAssignmentListInnerSection == null)
						{
							num = (short)1114636289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = channelAssignmentListInnerSection.ChannelAnnouncementID_A20175Value;
						num = (short)197132300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_B2;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone;
						if (zone == null)
						{
							num = (short)1913585671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = zone.ZoneVoiceAnnouncementID_A21514Value;
						num = (short)54460418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)671481873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_92;
						}
						continue;
					case 16:
					{
						num = (short)264209124;
						short num4 = num;
						num = (short)299991780;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_169;
						default:
							num = (short)986251264;
							if (num != 0)
							{
							}
							if (features != null)
							{
								num = (short)1106640896;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						break;
					}
					case 17:
						if (radWideFeaturesVoiceControlPriority.Value == 0)
						{
							num = (short)612237316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 18:
						features = radioWide.Features;
						num = (short)60555280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_92:
					if (self == null)
					{
						num = (short)1401159689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					channelAssignmentListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
					num = (short)103677963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B2:
					num = (short)1243545603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_169:
					num = (short)693239808;
					short num5 = num;
					radWideFeaturesVoiceControlPriority = features.RadWideFeaturesVoiceControlPriority;
					num = (short)1027997701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_345:
					radioWide = (acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)531234826;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_2FA:
				return num3 == 65535;
			}
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00028CA0 File Offset: 0x00026EA0
		public static bool ConZoneChannelsPersonalityEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			while (((self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection).Parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119)
			{
				short num = (short)1361116536;
				short num2 = num;
				num = (short)1873018232;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1706819584;
					short num3 = num;
					num = (short)1235091456;
					if (num != 0)
					{
					}
					num = (short)252772353;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			return true;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00028D84 File Offset: 0x00026F84
		public static bool ConCloneEnableValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)80084992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				global::AcpBusinessLayer.AcpField<bool> znChanCfgZoneZoneCloningEnable_;
				int num5;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)68550657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1449132033;
						if (num != 0)
						{
						}
						if (zoneChannelAssignment.Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
						{
							num = (short)169410570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						goto IL_419;
					case 3:
					{
						num = (short)1071107874;
						short num3 = num;
						num = (short)382521122;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_412;
						default:
							num = (short)988217344;
							if (num != 0)
							{
							}
							num = (short)846266375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_412;
					case 5:
						if (zoneChannelAssignment.Parent.Count > 0)
						{
							num = (short)2001928198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_419;
					case 6:
						znChanCfgZoneZoneCloningEnable_.CalculateApplicability();
						znChanCfgZoneZoneCloningEnable_.CalculateEditability();
						num = (short)1685127170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (zoneChannelAssignment.Parent != null)
						{
							num = (short)1058799620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_419;
					case 8:
					{
						num = (short)1932460032;
						short num4 = num;
						if (zoneChannelAssignment != null)
						{
							num = (short)1242562563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_419;
					}
					case 9:
						if (num5 > 15)
						{
							num = (short)538116096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 10:
						return false;
					case 11:
						try
						{
							num = (short)1443758085;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
									if (zoneChannelAssignment2.Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
									{
										num = (short)2045181956;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
									if (zoneChannelAssignment2 != null)
									{
										num = (short)1045889031;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1911095304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num5++;
									num = (short)643432450;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_162;
									}
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1355546627;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2 = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current;
									num = (short)665518081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)762511360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_262;
								}
								IL_164:
								num = (short)835518470;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_162:
								goto IL_164;
							}
							IL_262:
							goto IL_DA;
						}
						finally
						{
							num = (short)664010752;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_299;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)2043215874;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2D0;
								}
								IL_299:
								if (enumerator == null)
								{
									break;
								}
								num = (short)38797313;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2D0:;
						}
						goto IL_2D3;
						IL_DA:
						num = (short)2140209161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F;
					IL_2D3:
					num = (short)483786757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_412:
					goto IL_2D3;
					IL_419:
					enumerator = (zoneChannelAssignment.Parent as global::AcpBusinessLayer.Recordset).GetEnumerator();
					num = (short)1017184267;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_5F:
				znChanCfgZoneZoneCloningEnable_ = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).ZnChanCfgZoneZoneCloningEnable_43119;
				zoneChannelAssignment = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				num5 = 0;
				num = (short)1465450504;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0002921C File Offset: 0x0002741C
		public static bool ConZoneChannAssignCloneEnableApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)822476800;
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
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (!(self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).ZnChanCfgZoneZoneCloningEnable_43119.Value)
						{
							num = (short)978518016;
							short num3 = num;
							num = (short)1161625603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_416;
					case 1:
					{
						int num4;
						int count;
						int num5;
						if (num4 + 16 - count <= num5)
						{
							num = (short)1054933004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 2:
					{
						int num4 = 0;
						global::AcpBusinessLayer.Recordset recordset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = recordset.GetEnumerator();
						num = (short)2040201223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)1591869444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (global::AcpCommonLib.AppInfoManager.SkipValueSetter)
						{
							num = (short)117047310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1532428304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return true;
					case 6:
						num = (short)127139857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							num = (short)1136590850;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
								switch (num2)
								{
								case 0:
									goto IL_2C6;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_28A;
									}
									continue;
								case 3:
									if (zoneChannelAssignment != null)
									{
										num = (short)1414594560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_3A4;
								case 5:
									num = (short)1184890884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1269891077;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									zoneChannelAssignment = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
									num = (short)986382001;
									short num6 = num;
									num = (short)1655307953;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2C6;
									default:
										num = (short)868876288;
										if (num != 0)
										{
										}
										num = (short)251330563;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_28C:
								num = (short)760545286;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_28A:
								goto IL_28C;
								IL_2C6:
								int num4;
								num4 += zoneChannelAssignment.Channels.EmbeddedRecset.Count;
								num = (short)804782081;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A4:
							goto IL_C1;
						}
						finally
						{
							num = (short)1374158850;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)588120065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_413;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3DC;
									}
									continue;
								}
								IL_3DC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)256901120;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_413:;
						}
						goto IL_416;
						IL_C1:
						num = (short)1937965065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (radioWide != null)
						{
							num = (short)642187270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
					{
						int num7;
						int num8;
						if (num7 + 16 <= num8)
						{
							num = (short)820510733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 10:
						return false;
					case 11:
						return true;
					case 12:
						num = (short)218234885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1325531137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_416;
					case 15:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset.Count > 0)
						{
							num = (short)487915522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2 = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						global::AcpBusinessLayer.Recordset recordset = zoneChannelAssignment2.Parent as global::AcpBusinessLayer.Recordset;
						int num5 = 0;
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset radioInformationRecset = global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset;
						if (radioInformationRecset != null && radioInformationRecset[0][10108] is global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General)
						{
							num5 = (radioInformationRecset[0][10108] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General).RadInfoGeneralMaximumChannels_A11479.Value;
						}
						int num8 = 0;
						int num7 = 0;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset = global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset;
						if (conventionalPersonalityRecset != null)
						{
							num8 = conventionalPersonalityRecset.Max;
							num7 = conventionalPersonalityRecset.Count;
						}
						int count = zoneChannelAssignment2.Channels.EmbeddedRecset.Count;
						num = (short)1139212289;
						if (num != 0)
						{
						}
						num = (short)965148687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (!radioWide.Features.RadWideFeaturesZoneCloneEnable_43130)
						{
							num = (short)1558642698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)62259200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_76;
					IL_416:
					num = (short)520945675;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_76:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)1635516424;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000297F8 File Offset: 0x000279F8
		public static bool ConZoneChannAssignCloneEnableEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1810497536;
			switch (num)
			{
			default:
			{
				num = (short)461963266;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						int num3;
						if (num3 >= 15)
						{
							num = (short)1268645892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_368;
					}
					case 1:
						num = (short)1537998848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 3:
						num = (short)1702821889;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1753743361;
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
										num = (short)1021181955;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current;
									num = (short)1328480264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1B4;
									}
									continue;
								case 2:
									num = (short)619511813;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)801112071;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment.Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
									{
										num = (short)561053702;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									int num3;
									num3++;
									num = (short)486408196;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									num = (short)1136372951;
									short num4 = num;
									num = (short)749907159;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1F7;
									default:
										goto IL_2E3;
									}
									break;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment != null)
									{
										goto IL_1F7;
									}
									break;
								}
								}
								goto IL_1B4;
								IL_1F7:
								num = (short)2000748546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_211:
								num = (short)1578172416;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B4:
								goto IL_211;
							}
							IL_2E3:
							num = (short)990576640;
							if (num != 0)
							{
							}
							goto IL_84;
						}
						finally
						{
							num = (short)927399938;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1044578305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_365;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_330;
									}
									continue;
								}
								IL_330:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2027421696;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_365:;
						}
						goto IL_368;
						IL_84:
						num = (short)1590820869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return false;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
						if (!zoneChannelAssignment2.Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
						{
							num = (short)747569153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_368;
					}
					case 6:
						return false;
					}
					IL_61:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1650065414;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2 = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						int num3 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (zoneChannelAssignment2.Parent as global::AcpBusinessLayer.Recordset).GetEnumerator();
						num = (short)1697382403;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return false;
				IL_368:
				num = (short)719323136;
				short num5 = num;
				return true;
			}
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00029BB4 File Offset: 0x00027DB4
		internal static bool ConTopLightColorApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)324730883;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
				switch (num2)
				{
				case 0:
					return true;
				case 1:
					num = (short)130547714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (radioProfiles != null)
					{
						num = (short)421986308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 4:
					num = (short)1281687557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)872827566;
					short num3 = num;
					num = (short)1428900526;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1CB;
					default:
						num = (short)1146945536;
						if (num != 0)
						{
						}
						if (!radioProfiles.General.RadProfNVGEnable_A41615.Value)
						{
							num = (short)1713569798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CB;
					}
					break;
				}
				case 6:
					num = (short)1335427073;
					if (num != 0)
					{
					}
					num = (short)223936519;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!radioProfiles.General.RadProfGeneralDisableLights_A7866.Value)
					{
						num = (short)1489633280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CB;
				}
				IL_46:
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection;
				radioProfiles = ((self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection).ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles);
				if (!channelAssignmentListInnerSection.RefDisplayAndMenu.Advanced.DisplMenuAdvancedTopLightColorPerChannel_A43171)
				{
					goto IL_1CB;
				}
				num = (short)112721921;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_1CB:
			num = (short)1321336832;
			short num4 = num;
			return false;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00029DB8 File Offset: 0x00027FB8
		internal static bool ConChannelColorBacklightSelectionApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)913702913;
			if (num != 0)
			{
			}
			num = (short)706203861;
			short num2 = num;
			num = (short)327798997;
			switch (num2 == num)
			{
			default:
			{
				num = (short)698679296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1642135552;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection).RefDisplayAndMenu.Advanced.RadioErgDispAdvanceChannelColorBacklight_43747.Value != 0;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00029E80 File Offset: 0x00028080
		internal static bool ConChannelColorBacklightSelectionHasExtendedColorOptions(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)57409539;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					num = (short)573767685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (index != 5)
					{
						num = (short)949944324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 4:
					num = (short)1865351175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (index != 4)
					{
						num = (short)511705094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					num = (short)1670774786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)263520256;
					short num3 = num;
					if (index != 6)
					{
						return true;
					}
					num = (short)360973786;
					short num4 = num;
					num = (short)633406938;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
						num = (short)564133888;
						if (num != 0)
						{
						}
						num = (short)403046401;
						if (num != 0)
						{
						}
						num = (short)645857280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_44;
				IL_64:
				num = (short)1211564033;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_44:
				if ((self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection).RefDisplayAndMenu.Advanced.RadioErgDispAdvanceChannelColorBacklight_43747.Value != 2)
				{
					goto IL_64;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0002A050 File Offset: 0x00028250
		public static bool ConDynamicZoneEnableEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone = self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone;
				zone.ZnChanCfgZoneDynamicZoneEnable_A41257.CalculateApplicability();
				if (zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Applicable)
				{
					goto IL_BF;
				}
				num = (short)1788280833;
				if (num != 0)
				{
				}
				num = (short)903675904;
				short num2 = num;
				num = (short)1302873841;
				short num3 = num;
				num = (short)1474184945;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A8;
				}
			}
			IL_A8:
			num = (short)1344798720;
			if (num != 0)
			{
			}
			return false;
			IL_BF:
			return global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0002A128 File Offset: 0x00028328
		internal static void RSIModeValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)684206777;
			short num2 = num;
			num = (short)1459301049;
			switch (num2 == num)
			{
			}
			num = (short)478281728;
			short num3 = num;
			num = (short)1038090240;
			if (num != 0)
			{
			}
			num = (short)258342913;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.UpdateRSISiteNumberRange(self, task);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0002A1D8 File Offset: 0x000283D8
		public static void UpdateRSISiteNumberRange(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_60;
			}
			short num;
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI rsi;
			for (;;)
			{
				IL_0A:
				num = (short)1684996097;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_9D;
				case 1:
					if (rsi != null)
					{
						num = (short)2000551941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					if (rsi.ZoneChannelAssignmentRSIMode_A41831Value == 2)
					{
						num = (short)983760900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1222639624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					rsi.ZoneChannelAssignmentRSISiteNumber_A41833Value = 1;
					num = (short)880017408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1AF;
				case 5:
				{
					num = (short)131154623;
					short num3 = num;
					num = (short)978272959;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AF;
					default:
						num = (short)935854080;
						if (num != 0)
						{
						}
						num = (short)922681346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					return;
				case 7:
					goto IL_1B1;
				case 8:
					if (rsi.ZoneChannelAssignmentRSISiteNumber_A41833Value > 62)
					{
						num = (short)1346830336;
						short num4 = num;
						num = (short)704970755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9D;
				case 9:
					goto IL_1B1;
				}
				goto IL_60;
				IL_9D:
				rsi.ZoneChannelAssignmentRSISiteNumber_A41833Max = 62;
				num = (short)1898119177;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AF:
				rsi.ZoneChannelAssignmentRSISiteNumber_A41833Max = 96;
				num = (short)1763770375;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B1:
				rsi.ZoneChannelAssignmentRSISiteNumber_A41833.CalculateValidity();
				num = (short)1848311814;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_60:
			rsi = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI);
			num = (short)497352705;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0002A400 File Offset: 0x00028600
		internal static void RSISiteNumberValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)2129367641;
			short num2 = num;
			num = (short)288395865;
			switch (num2 == num)
			{
			}
			num = (short)1531969536;
			short num3 = num;
			num = (short)1441595392;
			if (num != 0)
			{
			}
			num = (short)920453121;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.a(self, task);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0002A4B0 File Offset: 0x000286B0
		private static void a(global::AcpCommonLib.IAcpFeatureSection A_0, global::AcpCommonLib.UndoRedo.ContainerTask A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI rsi;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1679762825;
					short num3 = num2;
					num2 = (short)1955341705;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					case 1:
						break;
					default:
					{
						num2 = (short)1696792576;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1506279425;
					if (num2 != 0)
					{
					}
					num2 = (short)1447493632;
					if (num2 != 0)
					{
					}
					if (rsi.ZoneChannelAssignmentRSIMode_A41831Value == 1)
					{
						num2 = (short)700579844;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 1:
					if (rsi.ZoneChannelAssignmentRSISiteNumber_A41833Value > 62)
					{
						num2 = (short)118030339;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (rsi != null)
					{
						num2 = (short)371785734;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					rsi.ZoneChannelAssignmentRSISiteNumber_A41833Value = 62;
					num2 = (short)301596677;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_84;
				case 5:
					return;
				case 6:
					num2 = (short)709099520;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_84:
				num2 = (short)654508033;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			rsi = (A_0 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI);
			num2 = (short)741146626;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0002A65C File Offset: 0x0002885C
		public static bool VerifyTtsValueSupport(int index)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (index == 65535)
					{
						num2 = (short)1838809090;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					if (!labtool.RadInfoLabtoolQA09028ViQi_VoiceControlValue)
					{
						num2 = (short)315949061;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
				{
					num2 = (short)1297522811;
					short num3 = num2;
					num2 = (short)2119278715;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_111;
					default:
						goto IL_BB;
					}
					break;
				}
				case 3:
				{
					num2 = (short)1490026496;
					short num4 = num2;
					if (!labtool.radInfoLabtoolQA08715VoiceControlBasicValue)
					{
						num2 = (short)609615876;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 4:
					num2 = (short)383778816;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_111;
				}
				goto IL_28;
				IL_111:
				num2 = (short)343932929;
				if (num2 != 0)
				{
				}
				num2 = (short)1544749059;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BB:
			num2 = (short)921305088;
			if (num2 != 0)
			{
			}
			return false;
			IL_28:
			labtool = (((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0][10107] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool);
			num2 = (short)901251073;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0002A808 File Offset: 0x00028A08
		public static bool ConFallbackZoneApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1512796940;
			short num2 = num;
			num = (short)1171747596;
			switch (num2 == num)
			{
			}
			num = (short)890765312;
			short num3 = num;
			num = (short)1797521409;
			if (num != 0)
			{
			}
			num = (short)1492582400;
			if (num != 0)
			{
			}
			return global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.a(self);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0002A8BC File Offset: 0x00028ABC
		public static bool ConFallbackChannelApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1061982637;
			short num2 = num;
			num = (short)1862832557;
			switch (num2 == num)
			{
			}
			num = (short)1559232512;
			short num3 = num;
			num = (short)1707081729;
			if (num != 0)
			{
			}
			num = (short)1202192384;
			if (num != 0)
			{
			}
			return global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.a(self);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0002A96C File Offset: 0x00028B6C
		public static bool ConIsFallbackChannelSelectionValid(global::AcpCommonLib.IAcpFeatureSection self, int value)
		{
			short num = (short)349765633;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
				switch (num2)
				{
				case 0:
					if (channelAssignmentListInnerSection.ZnChanCfgChannelsFallbackZoneValue == zoneChannelAssignment.Position)
					{
						goto IL_7D;
					}
					return true;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					return false;
				case 3:
				{
					num = (short)1603708383;
					short num3 = num;
					num = (short)1769252319;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7D;
					default:
						num = (short)1708654592;
						if (num != 0)
						{
						}
						if (value == channelAssignmentListInner.Position)
						{
							num = (short)711983108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 4:
					num = (short)518324224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_53;
				}
				IL_3C:
				if (value == 0)
				{
					num = (short)546832389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				channelAssignmentListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
				channelAssignmentListInner = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
				zoneChannelAssignment = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				num = (short)1996488705;
				if (num != 0)
				{
				}
				num = (short)1825046531;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7D:
				num = (short)44236802;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_53:
			num = (short)709951488;
			short num4 = num;
			return true;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0002AB14 File Offset: 0x00028D14
		private static bool a(global::AcpCommonLib.IAcpFeatureSection A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			bool flag;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_64;
				case 1:
					goto IL_78;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
					flag = false;
					if (channelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241Value == 1)
					{
						flag = (channelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276Value == 65535);
					}
					else if (channelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode != null)
					{
						flag = ((channelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner).FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value == 65535);
					}
					if (features.RadWideFeaturesChannelFallbackEnableValue)
					{
						num2 = (short)1209925632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)942669825;
					if (num2 != 0)
					{
					}
					num2 = (short)1480636127;
					short num3 = num2;
					num2 = (short)127514335;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
						goto IL_144;
					}
					break;
				}
				}
				goto IL_1C;
				IL_64:
				num2 = (short)2000224257;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_78:
			return !flag;
			IL_144:
			num2 = (short)1838481408;
			if (num2 != 0)
			{
			}
			num2 = (short)1947533312;
			short num4 = num2;
			return false;
			IL_1C:
			channelAssignmentListInnerSection = (A_0 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection);
			num2 = (short)1272971266;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0002ACA8 File Offset: 0x00028EA8
		internal static bool ConZoneChannelsWiFiApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)317831543;
			short num2 = num;
			num = (short)2127083895;
			switch (num2 == num)
			{
			}
			num = (short)1433010177;
			if (num != 0)
			{
			}
			num = (short)1209532416;
			if (num != 0)
			{
			}
			num = (short)1165623296;
			short num3 = num;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide).WIFI.DataWideWIFIEnable_42506.Value;
		}

		// Token: 0x0400008C RID: 140
		private const int a = 65535;

		// Token: 0x0400008D RID: 141
		private const int b = 65535;

		// Token: 0x0400008E RID: 142
		private const string c = "home";
	}
}
