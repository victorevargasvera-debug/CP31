using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpCommonLib;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;

namespace Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList
{
	// Token: 0x020004B9 RID: 1209
	public static class EnhancedDataPortListConstraints
	{
		// Token: 0x06009F9E RID: 40862 RVA: 0x0094DB94 File Offset: 0x0094BD94
		internal static bool ConPortNumberIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1683095552;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_EB;
				}
				global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerSection enhancedDataPortTableInnerSection;
				global::AcpBusinessLayer.AcpRangeField<int, string> dataWideEnhDataPortListPortNum_A;
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
				for (;;)
				{
					IL_28:
					int num5;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
					global::AcpBusinessLayer.AcpRangeField<int, string> dataConfDataWidePortConAuthenticationUDPPort_A;
					switch (num2)
					{
					case 0:
						goto IL_9C6;
					case 1:
					{
						num = (short)1667432448;
						short num3 = num;
						goto IL_21C;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
						if (enhancedDataPortTableInner != null)
						{
							num = (short)1718485026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_304;
					}
					case 3:
						return false;
					case 4:
						goto IL_986;
					case 5:
						goto IL_644;
					case 6:
						if (enhancedDataPortTableInnerSection.ParentRecset.ParentSection.Parent.ReferenceKey != null)
						{
							num = (short)2132672515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_304;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
						if (enhancedDataPortTableInner.EnhancedDataPortTableInnerSection != null)
						{
							num = (short)2293770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_304;
					}
					case 8:
						if (dataWideEnhDataPortListPortNum_A.Value != 49223)
						{
							num = (short)349569069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
					{
						int num4 = 0;
						num = (short)935985181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)1274806308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						int num4;
						if (num4 >= secureKMFProfileRecset.Count)
						{
							num = (short)1254817793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = secureKMFProfileRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)345636907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)993722375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
						if (enhancedDataPortTableInner.EnhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008.Value == dataWideEnhDataPortListPortNum_A.Value)
						{
							num = (short)475463713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_304;
					}
					case 14:
						try
						{
							num = (short)1837432833;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = false;
									num = (short)1478819846;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_6D2;
									}
									continue;
								case 2:
									num = (short)131792899;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_795;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1791688706;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1723858949;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current).LTE.DataProfLTEBackupPTTGatewayPort_A43618.Value == dataWideEnhDataPortListPortNum_A)
									{
										num = (short)1104543744;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_778;
								}
								IL_6D4:
								num = (short)744292356;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6D2:
								goto IL_6D4;
							}
							IL_778:
							return result;
							IL_795:
							goto IL_585;
						}
						finally
						{
							num = (short)1169883136;
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
										goto IL_7CC;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1659568130;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_804;
								}
								IL_7CC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)276103169;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_804:;
						}
						goto IL_807;
					case 15:
						goto IL_986;
					case 16:
						if (dataWideEnhDataPortListPortNum_A.Value != 4000)
						{
							num = (short)2293781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
						if (num5 >= enhancedDataPortTableInnerRecset.Count)
						{
							num = (short)1494679552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner = enhancedDataPortTableInnerRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner;
						num = (short)404029442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)2126708771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1440284685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num5 = 0;
						num = (short)1954349071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1085997102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
						if (enhancedDataPortTableInner == self.Parent)
						{
							goto IL_304;
						}
						num = (short)1890323043;
						short num6 = num;
						num = (short)881068643;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D6;
						default:
							num = (short)1628569600;
							if (num != 0)
							{
							}
							num = (short)17891367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 23:
						if (dataProfilesRecset != null)
						{
							num = (short)565182504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_585;
					case 24:
						goto IL_88D;
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
						if (enhancedDataPortTableInnerRecset != null)
						{
							num = (short)1588199452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 26:
						goto IL_3B4;
					case 27:
						goto IL_4D6;
					case 28:
						num = (short)131923998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_3B4;
					case 30:
						if (enhancedDataPortTableInnerSection.ParentRecset.ParentSection != null)
						{
							num = (short)139001876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 31:
						if (enhancedDataPortTableInnerSection.ParentRecset.ParentSection.Parent != null)
						{
							num = (short)2043609100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_304;
					case 32:
						num = (short)317194284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1247674374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)1222180886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFUDPPort_A8384.Value == dataWideEnhDataPortListPortNum_A)
						{
							num = (short)653983749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						num4++;
						num = (short)203358234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
					{
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
						if (enhancedDataPortTableInner.EnhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008 != null)
						{
							num = (short)1438973971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_304;
					}
					case 37:
						if (dataWideEnhDataPortListPortNum_A.Value != 4005)
						{
							num = (short)396034090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 38:
						if (dataWideEnhDataPortListPortNum_A.Value != 4007)
						{
							num = (short)1311244320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 39:
						num = (short)40435743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)1870462990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						if (secureKMFProfileRecset != null)
						{
							num = (short)1648492553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21C;
					case 42:
						num = (short)1196097574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile.DataTransport.SecKmfProfDataTransportSubscriberOTARPort_A9226.Value != dataWideEnhDataPortListPortNum_A)
						{
							num = (short)1597702162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 44:
						if (dataWideEnhDataPortListPortNum_A.Value != 162)
						{
							num = (short)922877979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 45:
						goto IL_807;
					case 46:
					{
						if (dataWideEnhDataPortListPortNum_A.Value == dataConfDataWidePortConAuthenticationUDPPort_A.Value)
						{
							num = (short)415170584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset = self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset;
						num = (short)772014105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_EB;
					IL_21C:
					dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
					num = (short)1989345303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_304:
					num5++;
					num = (short)228917252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B4:
					num = (short)388497419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D6:
					num = (short)471334920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_585:
					dataConfDataWidePortConAuthenticationUDPPort_A = ((global::AcpCommonLib.FeatureManager.GetFeature(2028) as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataConfDataWidePortConAuthenticationUDPPort_A37608;
					num = (short)1395130405;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_807:
					num = (short)1247477776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_986:
					num = (short)1080819729;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_644:
				return false;
				IL_88D:
				return false;
				IL_9C6:
				num = (short)18415617;
				if (num != 0)
				{
				}
				return true;
				IL_EB:
				enhancedDataPortTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerSection);
				dataWideEnhDataPortListPortNum_A = enhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008;
				secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
				num = (short)383451177;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x0094E5B0 File Offset: 0x0094C7B0
		public static bool ConPortNumberApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
			for (;;)
			{
				IL_0A:
				int num3;
				switch (num)
				{
				case 0:
					num2 = (short)1791098881;
					if (num2 != 0)
					{
					}
					num2 = (short)127270918;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
					if (enhancedDataPortTableInner != null)
					{
						num2 = (short)452395020;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_220;
				}
				case 2:
				{
					if (num3 >= enhancedDataPortTableInnerRecset.Count)
					{
						num2 = (short)1289355268;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner = enhancedDataPortTableInnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner;
					num2 = (short)2132672513;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num3 = 0;
					num2 = (short)1602945033;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return true;
				case 5:
				{
					num2 = (short)890612495;
					short num4 = num2;
					num2 = (short)1035315983;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_21E;
					default:
						num2 = (short)968884224;
						if (num2 != 0)
						{
						}
						num2 = (short)124911629;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
				{
					global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
					if (enhancedDataPortTableInner.EnhancedDataPortTableInnerSection != null)
					{
						num2 = (short)1058013189;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_220;
				}
				case 7:
					if (enhancedDataPortTableInnerRecset != null)
					{
						num2 = (short)368050176;
						short num5 = num2;
						num2 = (short)260046851;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
					if (enhancedDataPortTableInner != self.Parent)
					{
						num2 = (short)2040004608;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_220;
				}
				case 9:
					goto IL_21E;
				case 10:
					goto IL_1C7;
				case 11:
				{
					global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
					enhancedDataPortTableInner.EnhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008.CalculateValidity();
					num2 = (short)1560215566;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					num2 = (short)1465647112;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
				{
					global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
					if (enhancedDataPortTableInner.EnhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008 != null)
					{
						num2 = (short)1255079947;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_220;
				}
				case 14:
					goto IL_220;
				}
				goto IL_4C;
				IL_1C7:
				num2 = (short)1669922818;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_21E:
				goto IL_1C7;
				IL_220:
				num3++;
				num2 = (short)1317273610;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_4C:
			global::AcpBusinessLayer.AcpSimpleRangeField dataWideEnhDataPortListPortNum_A = (self as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerSection).DataWideEnhDataPortListPortNum_A42008;
			enhancedDataPortTableInnerRecset = (self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset);
			num2 = (short)1779761159;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
