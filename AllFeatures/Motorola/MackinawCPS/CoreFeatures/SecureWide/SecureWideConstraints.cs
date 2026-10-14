using System;
using System.Collections.Generic;
using System.Globalization;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.Switches;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000D5 RID: 213
	public static class SecureWideConstraints
	{
		// Token: 0x06001E9B RID: 7835 RVA: 0x001E6C9C File Offset: 0x001E4E9C
		internal static bool ConDispListValidityForDispOnMc(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1C5;
				case 1:
					if (index != 0)
					{
						num2 = (short)611647494;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_84;
				case 2:
					if (index == 1)
					{
						goto IL_103;
					}
					num2 = (short)736690180;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)813105153;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (index == 2)
					{
						num2 = (short)1416495104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
				{
					num2 = (short)868291519;
					short num3 = num2;
					num2 = (short)1804211135;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_103;
					default:
						goto IL_14E;
					}
					break;
				}
				case 6:
					num2 = (short)2002518018;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value != 0)
					{
						num2 = (short)1361575939;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_30;
				IL_103:
				num2 = (short)462946309;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_84:
			num2 = (short)226951168;
			short num4 = num2;
			return true;
			IL_14E:
			num2 = (short)1952186369;
			if (num2 != 0)
			{
			}
			num2 = (short)1527906304;
			if (num2 != 0)
			{
			}
			goto IL_84;
			IL_1C5:
			return global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.a(secureWide);
			IL_30:
			secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			num2 = (short)136249351;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x001E6E74 File Offset: 0x001E5074
		internal static bool ConDispListValidityForDispOnPtt(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1C4;
				case 1:
					if (index != 0)
					{
						num2 = (short)278331398;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					if (index == 1)
					{
						goto IL_129;
					}
					num2 = (short)1302003716;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1906704385;
					if (num2 != 0)
					{
					}
					num2 = (short)533790721;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (index == 2)
					{
						num2 = (short)1127743488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
				{
					num2 = (short)344153850;
					short num3 = num2;
					num2 = (short)66346746;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_129;
					default:
						goto IL_175;
					}
					break;
				}
				case 6:
					num2 = (short)376635394;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value != 0)
					{
						num2 = (short)348651523;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_30;
				IL_129:
				num2 = (short)1348861957;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_175:
			num2 = (short)1331953664;
			if (num2 != 0)
			{
			}
			return true;
			IL_1C4:
			num2 = (short)1718747136;
			short num4 = num2;
			return global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.a(secureWide);
			IL_30:
			secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			num2 = (short)1127022599;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x001E704C File Offset: 0x001E524C
		internal static bool ConDispListValidityForSecSwitchSel(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1C9;
				case 1:
					if (index != 0)
					{
						num2 = (short)1015152646;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_84;
				case 2:
					if (index == 1)
					{
						goto IL_106;
					}
					num2 = (short)2020999172;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1100611585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (index == 2)
					{
						num2 = (short)910098432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
				{
					num2 = (short)329819297;
					short num3 = num2;
					num2 = (short)318416033;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_106;
					default:
						goto IL_179;
					}
					break;
				}
				case 6:
					num2 = (short)596967426;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value != 0)
					{
						num2 = (short)562561027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_30;
				IL_106:
				num2 = (short)2004025345;
				if (num2 != 0)
				{
				}
				num2 = (short)265879557;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_84:
			num2 = (short)789250048;
			short num4 = num2;
			return true;
			IL_179:
			num2 = (short)109314048;
			if (num2 != 0)
			{
			}
			goto IL_84;
			IL_1C9:
			return global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.a(secureWide);
			IL_30:
			secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			num2 = (short)2044854279;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x001E7228 File Offset: 0x001E5428
		internal static bool conSecOperationIsNotDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)606913172;
			short num2 = num;
			num = (short)747356820;
			switch (num2 == num)
			{
			}
			num = (short)2002583553;
			if (num != 0)
			{
			}
			num = (short)1758789632;
			if (num != 0)
			{
			}
			num = (short)763559936;
			short num3 = num;
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).General.SecWideGeneralSecureOperation_A9067.Value != 0;
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x001E72F0 File Offset: 0x001E54F0
		internal static bool ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR astrootar;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)288751617;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (secWideGeneralSecureOperation_A.Value == 3)
					{
						num2 = (short)795082758;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B9;
				case 2:
					if (astrootar.SecWideASTROOTARASTROOTAREnable_A7496.Value)
					{
						num2 = (short)763494405;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					num2 = (short)1762983938;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (secWideGeneralSecureOperation_A.Value != 1)
					{
						num2 = (short)458293248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
				{
					num2 = (short)359459604;
					short num3 = num2;
					num2 = (short)219933460;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num2 = (short)1976434688;
						if (num2 != 0)
						{
						}
						num2 = (short)1369571332;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					goto IL_11B;
				case 7:
					if (secureWide.General.SecWideGeneralOTAREnable_A7966.Value)
					{
						num2 = (short)884342787;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_30;
			}
			IL_B9:
			num2 = (short)916652032;
			short num4 = num2;
			return false;
			IL_11B:
			return secureWide.General.SecureWideAESAlgorithmEnable_43201.Value;
			IL_30:
			num2 = (short)1190002689;
			if (num2 != 0)
			{
			}
			astrootar = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR);
			secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			secWideGeneralSecureOperation_A = secureWide.General.SecWideGeneralSecureOperation_A9067;
			num2 = (short)350224391;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x001E7500 File Offset: 0x001E5700
		internal static bool conIgnoreTmssWhenStrapd(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)990969856;
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
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset trunkingSwitchTableInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset conventionalSwitchTableInnerRecset;
				for (;;)
				{
					IL_28:
					int num3;
					int num4;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					int num6;
					int num7;
					switch (num2)
					{
					case 0:
						goto IL_66B;
					case 1:
						goto IL_6FC;
					case 2:
						try
						{
							num = (short)338296841;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5AE;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									num3 = (acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition1Feature_A21004.Value;
									num = (short)2128412673;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									num4 = (acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition1Feature_A21004.Value;
									num = (short)260374536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1535836160;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1434058756;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)2065301511;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 3)
									{
										num = (short)1696202754;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 0)
									{
										num = (short)2074017795;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4B5;
								}
								case 8:
									goto IL_4B5;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_43F;
									}
									continue;
								}
								IL_441:
								num = (short)853213189;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_43F:
								goto IL_441;
								IL_4B5:
								num = (short)989003782;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5AE:
							goto IL_13A;
						}
						finally
						{
							num = (short)820510722;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_602;
								case 1:
									goto IL_621;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5E6;
									}
									continue;
								}
								IL_5E6:
								if (enumerator != null)
								{
									num = (short)33816576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_621;
								IL_602:
								enumerator.Dispose();
								num = (short)377225217;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_621:
								num = (short)2094017057;
								short num5 = num;
								num = (short)617753121;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_602;
								default:
									goto IL_655;
								}
							}
							IL_655:
							num = (short)456130560;
							if (num != 0)
							{
							}
						}
						goto IL_66B;
						IL_13A:
						num = (short)311361546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)1016135689;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_33D;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									num6 = (acpFeatureNode2[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition1Feature_A19655.Value;
									num = (short)1954742273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1422196736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									num7 = (acpFeatureNode2[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition1Feature_A19655.Value;
									num = (short)1792278536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode2) == 0)
									{
										num = (short)1049296900;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_263;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode2) == 3)
									{
										num = (short)1705443330;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1796800515;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)608632837;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_263;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_1D9;
									}
									continue;
								}
								goto IL_1D9;
								IL_263:
								num = (short)1232863238;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2E5:
								num = (short)894107655;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D9:
								goto IL_2E5;
							}
							IL_33D:
							goto IL_701;
						}
						finally
						{
							num = (short)1662320642;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)350748673;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3AC;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_374;
									}
									continue;
								}
								IL_374:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1933770752;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3AC:;
						}
						goto IL_3AF;
						IL_701:
						enumerator = trunkingSwitchTableInnerRecset.GetEnumerator();
						num = (short)774701058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1400373255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_3AF;
					case 6:
						num = (short)1527840777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (num4 != 81)
						{
							num = (short)1032060934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176;
					case 8:
						if (num6 != 81)
						{
							num = (short)951189508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176;
					case 9:
						if (num3 == 81)
						{
							num = (short)1045233665;
							if (num != 0)
							{
							}
							num = (short)523960321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 10:
						if (num7 != 81)
						{
							num = (short)2049769477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176;
					case 11:
						if (global::ConstraintHelper.UtilityMack.IsPortableOnly())
						{
							num = (short)659685376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_728;
					}
					goto IL_5F;
					IL_3AF:
					num = (short)1808597000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66B:
					num4 = (num7 = (num6 = (num3 = 0)));
					enumerator = conventionalSwitchTableInnerRecset.GetEnumerator();
					num = (short)1195507715;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_176:
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
				return secureWide.General.SecWideGeneralSecureOperation_A9067.Value != 0;
				IL_6FC:
				goto IL_176;
				IL_728:
				num = (short)1302134784;
				short num8 = num;
				return true;
				IL_5F:
				secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
				conventionalSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10085].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset);
				trunkingSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset);
				num = (short)1792802827;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x001E7C94 File Offset: 0x001E5E94
		internal static bool ConSecOperationIsHardware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1176961025;
			if (num != 0)
			{
			}
			num = (short)995392882;
			short num2 = num;
			num = (short)1520139634;
			switch (num2 == num)
			{
			}
			num = (short)1385431040;
			if (num != 0)
			{
			}
			num = (short)1998716928;
			short num3 = num;
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).General.SecWideGeneralSecureOperation_A9067.Value == 1;
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x001E7D5C File Offset: 0x001E5F5C
		internal static bool ConOtarIsEnabledAndSecOperationIsHardware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			if (!secureWide.General.SecWideGeneralOTAREnable_A7966.Value)
			{
				short num = (short)2051080193;
				if (num != 0)
				{
				}
				num = (short)1425403205;
				short num2 = num;
				num = (short)128707909;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)196476928;
					if (num != 0)
					{
					}
					num = (short)102825984;
					short num3 = num;
					return false;
				}
				}
			}
			return secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1;
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x001E7E3C File Offset: 0x001E603C
		internal static bool ConSecureOperationIsNotDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_14A;
				case 1:
					goto IL_F2;
				case 2:
					goto IL_F4;
				case 3:
				{
					num2 = (short)1860947063;
					short num3 = num2;
					num2 = (short)651807863;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F4;
					default:
					{
						num2 = (short)769589248;
						short num4 = num2;
						num2 = (short)815923200;
						if (num2 != 0)
						{
						}
						if (self.ParentRecset.IsEmbeddedRecset)
						{
							num2 = (short)2006515714;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
						num2 = (short)509411329;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_20;
				IL_F4:
				secureWide = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
				num2 = (short)1489633281;
				if (num2 != 0)
				{
				}
				num2 = (short)32374784;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F2:
			IL_14A:
			return secureWide.General.SecWideGeneralSecureOperation_A9067.Value != 0;
			IL_20:
			secureWide = null;
			num2 = (short)2022440963;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x001E7FA8 File Offset: 0x001E61A8
		internal static bool ConCheckForDuplicateADPKeyIDs(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1824522240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::AcpBusinessLayer.AcpField<string> secWideMultikeyListSelectableADPKeyID_A;
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_29:
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1927806982;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1269039109;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)688128004;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_256;
									case 3:
									{
										int num3;
										num3++;
										num = (short)2000420864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										string value;
										if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10041] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListSelectableADPKeyID_A9107.Value == value)
										{
											num = (short)1589182467;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										num = (short)2119565314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_18B;
										}
										continue;
									}
									IL_18D:
									num = (short)14745601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_18B:
									goto IL_18D;
								}
								IL_256:
								goto IL_BD;
							}
							finally
							{
								num = (short)743374848;
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
											goto IL_28D;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1573912578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_2C6;
									}
									IL_28D:
									if (enumerator == null)
									{
										break;
									}
									num = (short)2097938433;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2C6:;
							}
							goto IL_2C9;
							IL_BD:
							num = (short)2106392578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_11B;
						case 2:
						{
							num = (short)1680539649;
							if (num != 0)
							{
							}
							int num3;
							if (num3 > 1)
							{
								num = (short)648937473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						case 3:
							goto IL_B8;
						case 4:
						{
							if (secWideMultikeyListSelectableADPKeyID_A.Value.Length > 4)
							{
								num = (short)91488259;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num3 = 0;
							string value = secWideMultikeyListSelectableADPKeyID_A.Value;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = encryptionKeyListInnerRecset.GetEnumerator();
							num = (short)350814208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_44;
					}
					IL_B8:
					goto IL_2C9;
					IL_11B:
					num = (short)1625489408;
					short num4 = num;
					return false;
					IL_2C9:
					num = (short)126903789;
					short num5 = num;
					num = (short)1428055533;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7A;
					default:
						num = (short)32768000;
						if (num != 0)
						{
						}
						return false;
					}
					return true;
				}
				}
				IL_44:
				secWideMultikeyListSelectableADPKeyID_A = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListSelectableADPKeyID_A9107;
				encryptionKeyListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2021) as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset)[0][10040].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset);
				IL_7A:
				num = (short)2002386948;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x001E8318 File Offset: 0x001E6518
		internal static bool ConSecOperIsHwAndPidKeyMngmtIsEnAndRecordNumLt9(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1399702968;
					short num3 = num2;
					num2 = (short)919717304;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_125;
					default:
						num2 = (short)971243520;
						if (num2 != 0)
						{
						}
						num2 = (short)1498284034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)1662255104;
					short num4 = num2;
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1)
					{
						num2 = (short)1094123521;
						if (num2 != 0)
						{
						}
						num2 = (short)1185742848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 2:
					if (secureWide.Multikey.SecWideMultikeyPIDKeyManagementforASNMode_A8704.Value)
					{
						num2 = (short)508821507;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					goto IL_18E;
				}
				goto IL_20;
			}
			IL_125:
			global::AcpBusinessLayer.AcpField<bool> secWideMultikeyListIndexed_A;
			return (secWideMultikeyListIndexed_A.Parent.Parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(secWideMultikeyListIndexed_A.Parent.Parent) < 8;
			IL_18E:
			goto IL_125;
			IL_20:
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection;
			secureWide = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			secWideMultikeyListIndexed_A = encryptionKeyListInnerSection.SecWideMultikeyListIndexed_A8282;
			num2 = (short)1788608513;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x001E84B8 File Offset: 0x001E66B8
		public static bool ConSlotAIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1459945472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				global::AcpBusinessLayer.AcpField<bool> secWideMultikeyPIDKeyManagementforASNMode_A;
				global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_103;
					case 1:
						return false;
					case 2:
					{
						int num3;
						if (num3 > 7)
						{
							num = (short)806748175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 3:
						goto IL_4C6;
					case 4:
					{
						int num3;
						if (num3 > 8)
						{
							num = (short)500891656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 5:
						return false;
					case 6:
					{
						try
						{
							num = (short)943521794;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)421527558;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10041] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListIndexed_A8282.Value)
									{
										num = (short)1897463812;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_16E;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1866399744;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)212926465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									int num4;
									num4++;
									num = (short)195035141;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_234;
								}
								IL_1BF:
								num = (short)2015100931;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16E:
								goto IL_1BF;
							}
							IL_234:
							goto IL_3B3;
						}
						finally
						{
							num = (short)783745024;
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
										goto IL_26B;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1076559874;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2A4;
								}
								IL_26B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1528430593;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A4:;
						}
						goto IL_2A7;
						IL_3B3:
						num = (short)1958281216;
						short num5 = num;
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset;
						int num3 = encryptionKeyListInnerRecset.IndexOf(self.Parent);
						num = (short)1648230410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return false;
					case 8:
						return false;
					case 9:
						return false;
					case 10:
					{
						int num4;
						switch (num4)
						{
						case 0:
							num = (short)622133262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1963196427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)358744084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1544683537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1056112662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_2A7;
						case 6:
							num = (short)934281235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)1816133636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)1849884674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1697054743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
					{
						int num3;
						if (num3 > 14)
						{
							num = (short)543621129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 12:
					{
						int num3;
						if (num3 > 10)
						{
							num = (short)1080885253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 13:
					{
						if (!secWideMultikeyPIDKeyManagementforASNMode_A.Value)
						{
							num = (short)2012610576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0][10040].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset;
						int num4 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = encryptionKeyListInnerRecset.GetEnumerator();
						num = (short)692977670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						int num3;
						if (num3 > 15)
						{
							num = (short)1146028033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 15:
						return false;
					case 16:
						return false;
					case 17:
					{
						int num3;
						if (num3 > 12)
						{
							num = (short)1057751065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 18:
						if (secWideGeneralSecureOperation_A.Value != 1)
						{
							num = (short)95748096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)843776013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						int num3;
						if (num3 > 9)
						{
							num = (short)1787822087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 20:
					{
						int num3;
						if (num3 > 13)
						{
							num = (short)950009859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 21:
						return false;
					case 22:
					{
						int num3;
						if (num3 > 11)
						{
							num = (short)1818624024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 23:
						num = (short)1940258837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_5FA;
					case 25:
						return false;
					}
					goto IL_96;
					IL_2A7:
					num = (short)276889612;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_103:
				num = (short)1752387232;
				short num6 = num;
				num = (short)387796640;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num = (short)1558904832;
					if (num != 0)
					{
					}
					return false;
				}
				return true;
				IL_4C6:
				num = (short)1411710977;
				if (num != 0)
				{
				}
				return false;
				IL_5FA:
				return false;
				IL_96:
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = self.Parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
				secWideGeneralSecureOperation_A = secureWide.General.SecWideGeneralSecureOperation_A9067;
				secWideMultikeyPIDKeyManagementforASNMode_A = secureWide.Multikey.SecWideMultikeyPIDKeyManagementforASNMode_A8704;
				num = (short)427753490;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x001E8B68 File Offset: 0x001E6D68
		internal static bool conSecRadInhIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1623457792;
			switch (num)
			{
			default:
			{
				bool result;
				for (;;)
				{
					IL_1D:
					num = (short)107085824;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							num = (short)1393557505;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_77;
							}
							continue;
						case 1:
							goto IL_30D;
						case 2:
							try
							{
								num = (short)1526530052;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										result = false;
										num = (short)697630725;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										num = (short)949682183;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)184745987;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										num = (short)992346118;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)1636040712;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_182;
										}
										continue;
									case 5:
										goto IL_22E;
									case 6:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralSystemType_A9252.Value == 3)
										{
											num = (short)59899905;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if (!(acpFeatureNode[10154] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features).TrkSysFeaturesRadioInhibit_A8833.Value)
										{
											num = (short)2049376256;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										goto IL_29D;
									}
									IL_184:
									num = (short)1875640322;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_182:
									goto IL_184;
								}
								IL_22E:
								IL_29D:
								return result;
							}
							finally
							{
								num = (short)1772486656;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_2D4;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)759955458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_30A;
									}
									IL_2D4:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1657274369;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_30A:;
							}
							goto IL_30D;
						}
						IL_77:
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR astrootar = self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset;
						result = true;
						int count = trunkingSystemRecset.Count;
						if (!astrootar.SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Value)
						{
							return result;
						}
						num = (short)151399690;
						short num3 = num;
						num = (short)757869834;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
						{
							num = (short)1044185088;
							if (num != 0)
							{
							}
							num = (short)1997930496;
							short num4 = num;
							num = (short)1685389313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_30D:
						enumerator = trunkingSystemRecset.GetEnumerator();
						num = (short)806092802;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return result;
			}
			}
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x001E8EC4 File Offset: 0x001E70C4
		internal static void ConSecureOperationSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			bool value;
			short num2;
			global::AcpBusinessLayer.AcpField<bool> radWideUserInformationandPasswordsRadioLockForceChangePassword_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (secWideGeneralSecureOperation_A.Value != 1 || !value)
					{
						return;
					}
					num2 = (short)1659808085;
					short num3 = num2;
					num2 = (short)633173;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)736493568;
						if (num2 != 0)
						{
						}
						num2 = (short)682360833;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)1082064896;
					short num4 = num2;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideUserInformationandPasswordsRadioLockForceChangePassword_A, true));
					num2 = (short)1846476801;
					if (num2 != 0)
					{
					}
					num2 = (short)2100690946;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General;
			secWideGeneralSecureOperation_A = general.SecWideGeneralSecureOperation_A9067;
			value = general.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.Value;
			radWideUserInformationandPasswordsRadioLockForceChangePassword_A = general.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583;
			num2 = (short)1229914112;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x001E9020 File Offset: 0x001E7220
		internal static bool conOtarEnabledWhenSecOperationIsHardware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_B5;
				case 1:
				{
					global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
					if (secWideGeneralSecureOperation_A.Value != 1)
					{
						num2 = (short)578486272;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 2:
				{
					global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
					if (secWideGeneralSecureOperation_A.Value == 3)
					{
						num2 = (short)462946307;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 3:
					goto IL_14D;
				}
				goto IL_20;
			}
			return false;
			IL_14D:
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general;
			return general.SecureWideAESAlgorithmEnable_43201.Value;
			IL_20:
			num2 = (short)1753989252;
			short num3 = num2;
			num2 = (short)1133166724;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B5:
				num2 = (short)937426944;
				short num4 = num2;
				num2 = (short)1903034369;
				if (num2 != 0)
				{
				}
				num2 = (short)830472194;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1308426240;
				if (num2 != 0)
				{
				}
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General);
				global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A = general.SecWideGeneralSecureOperation_A9067;
				num2 = (short)683343873;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x001E9180 File Offset: 0x001E7380
		internal static bool conUserSelectableEnableWhenSecOperationIsHardwareOrSoftwareWithAESorDES(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1671888896;
			short num2 = num;
			num = (short)1339518801;
			short num3 = num;
			num = (short)1690857297;
			switch (num3 == num)
			{
			}
			num = (short)1345519616;
			if (num != 0)
			{
			}
			num = (short)125370369;
			if (num != 0)
			{
			}
			return global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.a(self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x001E9238 File Offset: 0x001E7438
		internal static bool ConValueNotBlankNorDuplicated(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2083520512;
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
				global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
				global::AcpBusinessLayer.AcpSimpleRangeField secWideMultikeyListCKR_A;
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset;
				for (;;)
				{
					IL_27:
					int num5;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					int value;
					switch (num2)
					{
					case 0:
						if (secWideGeneralSecureOperation_A.Value == 3)
						{
							num = (short)1401356290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114;
					case 1:
						num = (short)1415512070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1840170938;
						short num3 = num;
						num = (short)185190330;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_127;
						default:
						{
							num = (short)1376387072;
							if (num != 0)
							{
							}
							num = (short)1677262848;
							short num4 = num;
							goto IL_44C;
						}
						}
						break;
					}
					case 3:
						try
						{
							num = (short)1187381253;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num5++;
									num = (short)1392705540;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (num5 > 1)
									{
										num = (short)1305673731;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)1460404230;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)583008263;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									result = false;
									num = (short)1343619080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_2B5;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_2B0;
									}
									continue;
								case 6:
									num = (short)1229783049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10041] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListCKR_A7665.Value == value)
									{
										num = (short)902561792;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5;
								case 8:
									goto IL_398;
								case 9:
									goto IL_3D9;
								}
								goto IL_2B0;
								IL_2B5:
								num = (short)1827012609;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_340:
								num = (short)1539571714;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B0:
								goto IL_340;
							}
							IL_398:
							IL_3D9:
							return result;
						}
						finally
						{
							num = (short)1860304896;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_411;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1267073026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_449;
								}
								IL_411:
								if (enumerator == null)
								{
									break;
								}
								num = (short)51118081;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_449:;
						}
						goto IL_44C;
					case 4:
						if (secureWide.General.SecureWideKeyloadingSource_43204.Value == 1)
						{
							num = (short)1508507657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114;
					case 5:
						if (secWideMultikeyListCKR_A.Value == 0)
						{
							num = (short)1864105985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114;
					case 6:
						if (secWideGeneralSecureOperation_A.Value != 1)
						{
							num = (short)1106378760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_146;
					case 7:
						return result;
					case 8:
						num = (short)1968766976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_146;
					}
					goto IL_56;
					IL_127:
					num = (short)171311107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_114:
					value = secWideMultikeyListCKR_A.Value;
					num5 = 0;
					enumerator = encryptionKeyListInnerRecset.GetEnumerator();
					goto IL_127;
					IL_146:
					result = false;
					num = (short)1168048135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44C:
					num = (short)1139212292;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_56:
				num = (short)593756161;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection;
				secureWide = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
				secWideMultikeyListCKR_A = encryptionKeyListInnerSection.SecWideMultikeyListCKR_A7665;
				secWideGeneralSecureOperation_A = secureWide.General.SecWideGeneralSecureOperation_A9067;
				encryptionKeyListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2021) as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset)[0][10040].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset);
				result = true;
				num = (short)2126249989;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x001E9700 File Offset: 0x001E7900
		internal static void ConFormatADPKeystreamsAndKeyIDsForSelAdpKeyID(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::AcpBusinessLayer.AcpField<string> secWideMultikeyListSelectableADPKeyID_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (secWideMultikeyListSelectableADPKeyID_A.Value.Length >= 4)
					{
						return;
					}
					num2 = (short)1812355419;
					short num3 = num2;
					num2 = (short)810178907;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)707526656;
						if (num2 != 0)
						{
						}
						num2 = (short)1868300289;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)804913152;
					short num4 = num2;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(secWideMultikeyListSelectableADPKeyID_A, secWideMultikeyListSelectableADPKeyID_A.Value.PadLeft(4, '0')));
					num2 = (short)2004353026;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_10D;
				}
				goto IL_1C;
			}
			IL_10D:
			num2 = (short)966000641;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			secWideMultikeyListSelectableADPKeyID_A = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListSelectableADPKeyID_A9107;
			num2 = (short)889061376;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x001E9844 File Offset: 0x001E7A44
		internal static void ConFormatADPKeystreamsAndKeyIDsForSelAdpKeystream(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 15;
			short num = (short)564920320;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				global::AcpBusinessLayer.AcpField<string> secWideMultikeyListSelectableADPKeyData_A;
				for (;;)
				{
					IL_31:
					int num3;
					string value;
					switch (num2)
					{
					case 0:
						if (num3 < 10)
						{
							num = (short)27721730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						num = (short)1964376064;
						short num4 = num;
						num3 = secWideMultikeyListSelectableADPKeyData_A.Value.Length;
						num = (short)1164771336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1342832644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (secWideMultikeyListSelectableADPKeyData_A.Value.Equals(value))
						{
							goto IL_123;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(secWideMultikeyListSelectableADPKeyData_A, secWideMultikeyListSelectableADPKeyData_A.Value.PadLeft(10, '0')));
						num = (short)2120220678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (num3 == 0)
						{
							num = (short)470286345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2057306115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (secWideMultikeyListSelectableADPKeyData_A.Value != null)
						{
							num = (short)1177419777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 6:
						goto IL_209;
					case 7:
						goto IL_13D;
					case 8:
						goto IL_15E;
					case 9:
						goto IL_2DA;
					}
					goto IL_60;
					IL_15E:
					string id_SSSSSSSSSS = global::CommonResources.AcgResources.ID_SSSSSSSSSS;
					global::System.Globalization.CultureInfo culture = new global::System.Globalization.CultureInfo(global::AllFeatures.CodeplugGuid.b("뗏병", a_));
					value = global::CommonResources.AcgResources.ResourceManager.GetString(global::AllFeatures.CodeplugGuid.b("駏雑诓藕诗觙进距돟뇡럣뗥믧", a_), culture).Substring(0, num3);
					num = (short)55967744;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13D:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(secWideMultikeyListSelectableADPKeyData_A, secWideMultikeyListSelectableADPKeyData_A.Value.PadLeft(10, '*')));
				return;
				IL_209:
				num = (short)112001025;
				if (num != 0)
				{
				}
				return;
				IL_2DA:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(secWideMultikeyListSelectableADPKeyData_A, secWideMultikeyListSelectableADPKeyData_A.Value.PadLeft(10, '*')));
				return;
				IL_60:
				num = (short)1686857844;
				short num5 = num;
				num = (short)742025332;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_123:
					num = (short)2008612871;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				default:
				{
					num = (short)663945216;
					if (num != 0)
					{
					}
					secWideMultikeyListSelectableADPKeyData_A = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListSelectableADPKeyData_A9106;
					int num3 = 0;
					num = (short)1204355077;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x001E9B30 File Offset: 0x001E7D30
		internal static bool ConInvalidIfLeadingSpacesAndPeriodsExist(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 13;
			short num = (short)1536294912;
			short num2 = num;
			num = (short)1416930125;
			short num3 = num;
			num = (short)2033951565;
			global::AcpBusinessLayer.AcpKeyField secWideMultikeyListKeyName_A;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1599602689;
				if (num != 0)
				{
				}
				num = (short)2047934464;
				if (num != 0)
				{
				}
				secWideMultikeyListKeyName_A = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListKeyName_A8362;
				if (secWideMultikeyListKeyName_A.Value.StartsWith(global::AllFeatures.CodeplugGuid.b("", a_)))
				{
					return false;
				}
				break;
			}
			return !secWideMultikeyListKeyName_A.Value.StartsWith(global::AllFeatures.CodeplugGuid.b("", a_));
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x001E9C28 File Offset: 0x001E7E28
		internal static bool ConEPOUCinvalidWhenSecOpIsDisabledOrADP(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpField<bool> secWideMultikeyErasePreviousOnUserChange_A;
			for (;;)
			{
				IL_0A:
				num = (short)1156705824;
				short num2 = num;
				num = (short)728952352;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1788542976;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (secWideMultikeyErasePreviousOnUserChange_A.Value)
						{
							num = (short)233635843;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						if (secWideMultikeyErasePreviousOnUserChange_A.Value)
						{
							num = (short)1739390978;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						goto IL_12B;
					case 3:
						goto IL_F5;
					}
					goto IL_6A;
				}
				IL_F5:
				num = (short)1214316545;
				num3 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_12B:
			num = (short)635240448;
			short num4 = num;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide a_;
			return global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.a(a_);
			IL_6A:
			num = (short)481492993;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General;
			a_ = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			secWideMultikeyErasePreviousOnUserChange_A = general.SecWideMultikeyErasePreviousOnUserChange_A8373;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A = general.SecWideGeneralSecureOperation_A9067;
			num = (short)2021457920;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x001E9D8C File Offset: 0x001E7F8C
		public static void conSetSecPIDIndexMapAndSlotAAndSlotBValues(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1560805376;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset = self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = encryptionKeyListInnerRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
				int num2 = -1;
				ushort num3 = 0;
				ushort num4 = 1;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = encryptionKeyListInnerRecset.GetEnumerator();
				try
				{
					num = (short)374145027;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							num = (short)989528071;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection;
							if (encryptionKeyListInnerSection.SecWideMultikeyListIndexed_A8282.Value)
							{
								num = (short)1179975690;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							num2++;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(encryptionKeyListInnerSection.SecWideMultikeyListSlotA_A9155, num2));
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(encryptionKeyListInnerSection.SecWideMultikeyListSlotB_A9158, num2));
							num4 = (ushort)(num4 << 1);
							num = (short)124190724;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)1559691265;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_9D;
							}
							continue;
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)788594688;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10041] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection;
							num = (short)2083192841;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_2AF;
						case 8:
							num = (short)503316481;
							if (num != 0)
							{
							}
							break;
						case 9:
						{
							if (num2 < 15)
							{
								num = (short)1438318594;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(encryptionKeyListInnerSection.SecWideMultikeyListSlotA_A9155, 1));
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(encryptionKeyListInnerSection.SecWideMultikeyListSlotB_A9158, 1));
							num = (short)1882652678;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(encryptionKeyListInnerSection.SecWideMultikeyListSlotA_A9155, ++num2));
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(encryptionKeyListInnerSection.SecWideMultikeyListSlotB_A9158, ++num2));
							num3 |= num4;
							num4 = (ushort)(num4 << 1);
							num3 |= num4;
							num4 = (ushort)(num4 << 1);
							num = (short)2079391752;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_E3:
						num = (short)1135017989;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_9D:
						goto IL_E3;
					}
					IL_2AF:;
				}
				finally
				{
					num = (short)560988162;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
						{
							num = (short)1081937575;
							short num6 = num;
							num = (short)1738870439;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_30C;
							default:
								goto IL_357;
							}
							break;
						}
						case 1:
							enumerator.Dispose();
							goto IL_30C;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2E7;
							}
							continue;
						}
						IL_2E7:
						if (enumerator != null)
						{
							num = (short)162004993;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36E;
						IL_30C:
						num = (short)345833472;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_357:
					num = (short)828243968;
					if (num != 0)
					{
					}
					IL_36E:;
				}
				num = (short)421265408;
				short num7 = num;
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(secureWide.Labtool.SecWideLabtoolPIDIndexMapping_A8279, (int)num3));
				return;
			}
			}
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x001EA168 File Offset: 0x001E8368
		public static bool ConSecWideEncryKeyListIndexedIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)725084690;
			short num2 = num;
			num = (short)1344989714;
			switch (num2 == num)
			{
			}
			num = (short)748552193;
			if (num != 0)
			{
			}
			num = (short)1645674496;
			short num3 = num;
			num = (short)118554624;
			if (num != 0)
			{
			}
			(self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListSlotA_A9155.CalculateApplicability();
			return true;
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x001EA224 File Offset: 0x001E8424
		public static bool ConMDCOtarEnableInvalidIfOtarEnabledAndSecureIsHardware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1923874816;
			short num2 = num;
			num = (short)915759979;
			short num3 = num;
			num = (short)1558733675;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR mdcotar;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1675034625;
				if (num != 0)
				{
				}
				num = (short)1065549824;
				if (num != 0)
				{
				}
				mdcotar = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR);
				if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
				{
					return true;
				}
				break;
			}
			return mdcotar.SecWideMDCOTARMDCOTAREnable_A8488.Value;
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x001EA2FC File Offset: 0x001E84FC
		public static bool ConIsMDCOTARSystemSelectionValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_60;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR mdcotar;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)121831433;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (mdcotar.SecWideMDCOTARMDCOTAREnable_A8488.Value)
					{
						num2 = (short)1910112260;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					return false;
				case 3:
					num2 = (short)565379073;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1781392170;
					short num3 = num2;
					num2 = (short)80929578;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_199;
					default:
						num2 = (short)687210496;
						if (num2 != 0)
						{
						}
						num2 = (short)836239370;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					num2 = (short)375193606;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
					if (!conventionalSystem.General.CnvSysGeneralAdditionalMDCPID_A41761.Value)
					{
						num2 = (short)103481363;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 7:
				{
					num2 = (short)1693450240;
					short num4 = num2;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
					if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 1)
					{
						num2 = (short)1666056197;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 8:
					num2 = (short)93126674;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1188036609;
					if (num2 != 0)
					{
					}
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1)
					{
						num2 = (short)1293811714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 10:
					if (secureWide.General.SecWideGeneralOTAREnable_A7966.Value)
					{
						goto IL_199;
					}
					return true;
				case 11:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
					if (conventionalSystem == null)
					{
						num2 = (short)206700558;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1957822471;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					if (index == 0)
					{
						num2 = (short)866451459;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)360513551;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
				{
					if (index > mdcotar.SecWideMDCOTARMDCOTARSystem_A8490.RefRecset.Count)
					{
						num2 = (short)622395408;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = mdcotar.SecWideMDCOTARMDCOTARSystem_A8490.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
					num2 = (short)1406533643;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 14:
					return false;
				case 15:
					if (mdcotar.SecWideMDCOTARMDCOTARSystem_A8490.RefRecset != null)
					{
						num2 = (short)523894792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 16:
					goto IL_3D3;
				case 17:
					num2 = (short)753008653;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (index >= 0)
					{
						num2 = (short)311099409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 19:
					return true;
				}
				goto IL_60;
				IL_199:
				num2 = (short)944570368;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_3D3:
			return false;
			IL_60:
			mdcotar = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR);
			secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			num2 = (short)1078788108;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x001EA6E4 File Offset: 0x001E88E4
		public static bool ConAstroOtarEnableInvalidIfOtarEnabledAndSecureIsHardware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			global::AcpBusinessLayer.AcpField<bool> secWideGeneralOTAREnable_A;
			for (;;)
			{
				IL_0A:
				bool flag;
				bool flag2;
				switch (num)
				{
				case 0:
					num2 = (short)1305411595;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					flag = secureWide.General.SecureWideAESAlgorithmEnable_43201.Value;
					goto IL_114;
				case 2:
					if (!secureWide.MDCOTAR.SecWideMDCOTARMDCOTAREnable_A8488.Value)
					{
						num2 = (short)257753097;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E5;
				case 3:
					IL_252:
					flag = false;
					goto IL_114;
				case 4:
					num2 = (short)756416514;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1049559041;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (!secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
					{
						num2 = (short)1702690820;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E5;
				case 7:
					if (secWideGeneralOTAREnable_A)
					{
						num2 = (short)1867644928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 8:
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
					{
						num2 = (short)653918213;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)384237571;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_258;
				case 10:
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1)
					{
						num2 = (short)1234763790;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_258;
				case 11:
					if (secWideGeneralOTAREnable_A)
					{
						num2 = (short)1929445391;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 12:
					goto IL_2E0;
				case 13:
				{
					num2 = (short)1641152512;
					short num3 = num2;
					if (flag2)
					{
						num2 = (short)1089077249;
						if (num2 != 0)
						{
						}
						num2 = (short)197001228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 14:
					num2 = (short)965410822;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)937885706;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_50;
				IL_114:
				flag2 = flag;
				num2 = (short)1426194439;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2E5:
				num2 = (short)1994657674;
				short num4 = num2;
				num2 = (short)1552027530;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_252;
				default:
					goto IL_31A;
				}
				IL_258:
				num2 = (short)1223884813;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_2E0:
			return secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value;
			IL_31A:
			num2 = (short)1289158656;
			if (num2 != 0)
			{
			}
			return true;
			IL_50:
			secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			secWideGeneralOTAREnable_A = secureWide.General.SecWideGeneralOTAREnable_A7966;
			num2 = (short)106430472;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x001EAA24 File Offset: 0x001E8C24
		internal static bool conAstroOtarIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1546905238;
			short num2 = num;
			num = (short)626714262;
			switch (num2 == num)
			{
			}
			num = (short)1685258241;
			if (num != 0)
			{
			}
			num = (short)1736310784;
			short num3 = num;
			num = (short)830275584;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x001EAAD0 File Offset: 0x001E8CD0
		internal static bool ConMakeMDCOtarPageInvisibleInMackR1(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)82196500;
			short num2 = num;
			num = (short)1389574164;
			switch (num2 == num)
			{
			}
			num = (short)729939969;
			if (num != 0)
			{
			}
			num = (short)917176320;
			short num3 = num;
			num = (short)785973248;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x001EAB7C File Offset: 0x001E8D7C
		internal static bool conMdcOtarIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)691208193;
			if (num != 0)
			{
			}
			num = (short)493585638;
			short num2 = num;
			num = (short)689382;
			switch (num2 == num)
			{
			}
			num = (short)2063073280;
			short num3 = num;
			num = (short)350420992;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x001EAC24 File Offset: 0x001E8E24
		internal static bool ConSetToInVisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)402669546;
			short num2 = num;
			num = (short)1948073962;
			switch (num2 == num)
			{
			}
			num = (short)264568833;
			if (num != 0)
			{
			}
			num = (short)1655504896;
			short num3 = num;
			num = (short)1764491264;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x001EACCC File Offset: 0x001E8ECC
		internal static bool conOtarAcksEnIsEnAndMdcOtarIsEnAndOtarIsEnAndSecOperationIsHardware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR mdcotar;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2008481796;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1395586270;
					short num3 = num2;
					num2 = (short)2006643934;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10B;
					default:
						goto IL_159;
					}
					break;
				}
				case 2:
					if (mdcotar.SecWideMDCOTAREnable_A7967.Value)
					{
						num2 = (short)937623557;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					if (mdcotar.SecWideMDCOTARMDCOTAREnable_A8488.Value)
					{
						num2 = (short)1884225536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					num2 = (short)587792385;
					if (num2 != 0)
					{
					}
					if (secureWide.General.SecWideGeneralOTAREnable_A7966.Value)
					{
						goto IL_10B;
					}
					return false;
				case 5:
					num2 = (short)1488912387;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
				IL_10B:
				num2 = (short)534446081;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_159:
			num2 = (short)1220214784;
			if (num2 != 0)
			{
			}
			num2 = (short)1758658560;
			short num4 = num2;
			return secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1;
			IL_28:
			mdcotar = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR);
			secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			num2 = (short)1210056706;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x001EAE90 File Offset: 0x001E9090
		internal static bool conMdcOtarIsEnAndOtarIsEnAndSecOperationIsHardware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1347223552;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
					if (secureWide.General.SecWideGeneralOTAREnable_A7966.Value)
					{
						num = (short)583401474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F1;
				case 2:
					goto IL_EC;
				case 3:
					num = (short)1972830209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_35:
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR mdcotar = self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR;
				secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
				if (!mdcotar.SecWideMDCOTARMDCOTAREnable_A8488.Value)
				{
					goto IL_F1;
				}
				num = (short)1514668035;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EC:
			num = (short)1038548992;
			short num3 = num;
			return secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1;
			IL_F1:
			num = (short)1160199663;
			short num4 = num;
			num = (short)523779567;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_EC;
			default:
				num = (short)448462849;
				if (num != 0)
				{
				}
				num = (short)679542784;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x001EB004 File Offset: 0x001E9204
		internal static bool ConSecOperationIsADP(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)617676800;
			short num2 = num;
			num = (short)681854957;
			short num3 = num;
			num = (short)1575307245;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1007681537;
				if (num != 0)
				{
				}
				num = (short)305397760;
				if (num != 0)
				{
				}
				secureWide = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
				if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value != 3)
				{
					return false;
				}
				break;
			}
			return secureWide.General.SecureWideKeyloadingSource_43204.Value == 0;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x001EB0EC File Offset: 0x001E92EC
		public static bool ConSecOperationIsADPWithTrigger(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			short num2;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_10E;
				case 1:
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
					{
						num2 = (short)290521088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)565772288;
					short num3 = num2;
					num2 = (short)1681784833;
					if (num2 != 0)
					{
					}
					try
					{
						num2 = (short)1722810369;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)1987837954;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_14B;
								}
								continue;
							case 2:
								goto IL_1D1;
							case 3:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1880162304;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10041] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListSelectableADPKeyID_A9107.CalculateValidity();
								num2 = (short)1933115396;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_183:
							num2 = (short)147456003;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_14B:
							goto IL_183;
						}
						IL_1D1:
						goto IL_B2;
					}
					finally
					{
						num2 = (short)394854402;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								num2 = (short)643500906;
								short num4 = num2;
								num2 = (short)936512362;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_225;
								default:
									goto IL_26E;
								}
								break;
							}
							case 1:
								enumerator.Dispose();
								goto IL_225;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_206;
								}
								continue;
							}
							IL_206:
							if (enumerator != null)
							{
								num2 = (short)6946817;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_285;
							IL_225:
							num2 = (short)88080384;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_26E:
						num2 = (short)1021640704;
						if (num2 != 0)
						{
						}
						IL_285:;
					}
					goto IL_286;
					IL_B2:
					secureWide = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
					num2 = (short)1898905601;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_10E:
			IL_286:
			return secureWide.General.SecureWideKeyloadingSource_43204.Value == 0;
			IL_1C:
			enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2021) as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset)[0][10040].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset).GetEnumerator();
			num2 = (short)1549729794;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x001EB3A4 File Offset: 0x001E95A4
		public static bool ConIsADPKeyDataValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpField<string> secWideMultikeyListSelectableADPKeyData_A;
			long num4;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2072776946;
					short num3 = num2;
					num2 = (short)1554321650;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1132593152;
						if (num2 != 0)
						{
						}
						if (!long.TryParse(secWideMultikeyListSelectableADPKeyData_A.Value, global::System.Globalization.NumberStyles.HexNumber, null, out num4))
						{
							num2 = (short)1548025859;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_EC;
					}
					break;
				}
				case 1:
					if (secWideMultikeyListSelectableADPKeyData_A.Value.Contains(global::AllFeatures.CodeplugGuid.b("𢡊ﻓﳕ", a_)))
					{
						num2 = (short)530972674;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					goto IL_161;
				case 3:
					num2 = (short)1900150785;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_29;
			}
			IL_EC:
			num2 = (short)1860501504;
			short num5 = num2;
			return true;
			IL_161:
			goto IL_EC;
			IL_29:
			secWideMultikeyListSelectableADPKeyData_A = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListSelectableADPKeyData_A9106;
			num4 = 0L;
			num2 = (short)224591873;
			if (num2 != 0)
			{
			}
			num2 = (short)1920925696;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x001EB518 File Offset: 0x001E9718
		internal static bool ConInfiniteKeyRetentionDisable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1435172864;
			short num2 = num;
			num = (short)1925127673;
			short num3 = num;
			num = (short)424680953;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1206321152;
				if (num != 0)
				{
				}
				num = (short)776536065;
				if (num != 0)
				{
				}
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General);
				if (!(self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).Features.SecWideFeaturesInfiniteKeyRetention_A8292.Value)
				{
					return true;
				}
				break;
			}
			return !general.SecWideInfiniteUKEKRetention_A41551.Value;
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x001EB5F8 File Offset: 0x001E97F8
		internal static bool ConClearRxAlertToneBasedOnTacticalInhibit(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1441792002;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1E:
				num = (short)1736572929;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_141;
				case 1:
					num = (short)1662648323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 3:
					while (index != 2)
					{
						num = (short)1879411155;
						short num3 = num;
						num = (short)2130610643;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)294977536;
							if (num != 0)
							{
							}
							num = (short)699531264;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
					}
					return true;
				}
				IL_5A:
				num = (short)26345472;
				short num4 = num;
				if (!(self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Features).RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Value)
				{
					return true;
				}
				num = (short)1522991105;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_141:
			return index == 3;
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x001EB74C File Offset: 0x001E994C
		internal static bool ConSecureOperationBasedOnTacticalInhibit(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			int a_ = 0;
			short num = (short)1466892288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				string[] array;
				global::AcpBusinessLayer.AcpField<string> radInfoGeneralModelNumber_A;
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general;
				global::AcpBusinessLayer.AcpRangeField<int, int> radInfoLabtoolProductModelIdentifier_A;
				string[] array2;
				string[] array3;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (index != 0)
						{
							num = (short)355336198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						if (global::System.Array.IndexOf<string>(array, radInfoGeneralModelNumber_A.Value) > -1)
						{
							num = (short)1891106823;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AE;
					case 2:
						goto IL_352;
					case 3:
						num = (short)515637249;
						if (num != 0)
						{
						}
						goto IL_572;
					case 4:
					{
						num = (short)508428288;
						short num3 = num;
						if (!general.SecureWideAESAlgorithmEnable_43201.Value)
						{
							num = (short)1056899074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 5:
						return false;
					case 6:
						num = (short)1575616532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)1498821026;
						short num4 = num;
						num = (short)1354510754;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2CB;
						default:
							num = (short)1556086784;
							if (num != 0)
							{
							}
							num = (short)1853227026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						if (radInfoLabtoolProductModelIdentifier_A.Value != 19)
						{
							num = (short)1609236497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_572;
					case 9:
						if (global::System.Array.IndexOf<string>(array2, radInfoGeneralModelNumber_A.Value) <= -1)
						{
							goto IL_2CB;
						}
						goto IL_572;
					case 10:
						if (general.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Value)
						{
							num = (short)482344981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 11:
						num = (short)308740100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)966852624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)467730440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)967376911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (global::System.Array.IndexOf<string>(array3, radInfoGeneralModelNumber_A.Value) <= -1)
						{
							num = (short)1900675085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_572;
					case 16:
						if (index == 3)
						{
							num = (short)1012531211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						num = (short)1961492481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (radInfoLabtoolProductModelIdentifier_A.Value == 16)
						{
							num = (short)1669267459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AE;
					case 19:
						if (index == 1)
						{
							num = (short)1726480389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AE;
					case 20:
						if (index != 1)
						{
							num = (short)165543948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 21:
						num = (short)439746560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F;
					IL_2CB:
					num = (short)1956249614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AE:
					num = (short)1857093642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_572:
					num = (short)282001427;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_352:
				return general.SecureWideDESAlgorithmEnable_43744.Value;
				IL_8F:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General);
				radInfoGeneralModelNumber_A = general.RefRadioInformation.General.RadInfoGeneralModelNumber_A8539;
				radInfoLabtoolProductModelIdentifier_A = general.RefRadioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178;
				array2 = new string[]
				{
					global::AllFeatures.CodeplugGuid.b("觀鋆諈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀集跈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀铆跈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀賆跈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀鋆諈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀集跈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀铆跈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀賆跈迊鿎蛐铔駖", a_)
				};
				array = new string[]
				{
					global::AllFeatures.CodeplugGuid.b("觀鋆諈跊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀集跈跊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀铆跈跊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀賆跈跊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀郆諈跊鿎蛐铔駖", a_)
				};
				array3 = new string[]
				{
					global::AllFeatures.CodeplugGuid.b("觀﯂賆跈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂賆跈菊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂集跈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂集跈菊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂铆跈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂铆跈菊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂鋆諈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂鋆諈菊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂郆諈迊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂鋆諈跊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂集跈跊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂铆跈跊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂賆跈跊鿎蛐铔駖", a_),
					global::AllFeatures.CodeplugGuid.b("觀﯂郆諈跊鿎蛐铔駖", a_)
				};
				num = (short)1027342345;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x001EBD8C File Offset: 0x001E9F8C
		public static bool conInvisiableWhenOpenFromRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2057083943;
			short num2 = num;
			num = (short)1666554919;
			switch (num2 == num)
			{
			}
			num = (short)240058369;
			if (num != 0)
			{
			}
			num = (short)1908998144;
			if (num != 0)
			{
			}
			num = (short)1755971584;
			short num3 = num;
			return !global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x001EBE3C File Offset: 0x001EA03C
		internal static bool ConOtarOperationIndexValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					IL_4B:
					num2 = (short)1082327040;
					short num3 = num2;
					if (general == null)
					{
						num2 = (short)316866566;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A = general.SecWideGeneralSecureOperation_A9067;
					num2 = (short)31391746;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)1421017093;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)446758913;
					if (num2 != 0)
					{
					}
					global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
					if (secWideGeneralSecureOperation_A.Value != 0)
					{
						num2 = (short)1147797505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_177;
				}
				case 3:
					if (index != 0)
					{
						num2 = (short)375390212;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					goto IL_CA;
				case 5:
				{
					global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
					if (secWideGeneralSecureOperation_A.Value == 1)
					{
						num2 = (short)1496186887;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)36372483;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					return true;
				case 7:
					goto IL_177;
				}
				goto IL_30;
				IL_177:
				num2 = (short)1129876399;
				short num4 = num2;
				num2 = (short)1306889135;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4B;
				default:
					goto IL_1AB;
				}
			}
			return true;
			IL_CA:
			return index == 2;
			IL_1AB:
			num2 = (short)1973354496;
			if (num2 != 0)
			{
			}
			return true;
			IL_30:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General);
			num2 = (short)2003173376;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x001EC00C File Offset: 0x001EA20C
		internal static bool ConDisableHardKeyZeroizeIsApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			short num2;
			global::AcpBusinessLayer.AcpField<bool> radWideUserInformationAndPasswordsTacticalInhibitEnable_A;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Features features;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (secWideGeneralSecureOperation_A.Value == 1)
					{
						num2 = (short)1640169478;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CA;
				case 1:
				{
					num2 = (short)721266858;
					short num3 = num2;
					num2 = (short)1303029930;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_94;
					default:
						num2 = (short)1871314944;
						if (num2 != 0)
						{
						}
						goto IL_CA;
					}
					break;
				}
				case 2:
					if (radWideUserInformationAndPasswordsTacticalInhibitEnable_A.Value)
					{
						num2 = (short)1741946881;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					if (secWideGeneralSecureOperation_A.Value == 3)
					{
						num2 = (short)697106436;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					goto IL_101;
				case 5:
					if (features.SecWideFeaturesInfiniteKeyRetention_A8292.Value)
					{
						num2 = (short)2113208321;
						if (num2 != 0)
						{
						}
						num2 = (short)2041643015;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CA;
				case 6:
					goto IL_94;
				case 7:
					num2 = (short)1486356482;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_94:
				num2 = (short)664076288;
				short num4 = num2;
				num2 = (short)1996161029;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_CA:
				num2 = (short)1124990979;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_101:
			return !radWideUserInformationAndPasswordsTacticalInhibitEnable_A.Value;
			IL_30:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Features);
			secWideGeneralSecureOperation_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).General.SecWideGeneralSecureOperation_A9067;
			radWideUserInformationAndPasswordsTacticalInhibitEnable_A = features.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405;
			num2 = (short)950272000;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x001EC20C File Offset: 0x001EA40C
		internal static bool ConSecureAlgorithmsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (general.SecWideGeneralSecureOperation_A9067.Value == 3)
						{
							num2 = (short)1645543430;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 1:
						num2 = (short)1219362817;
						if (num2 != 0)
						{
						}
						num2 = (short)2129788933;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (!general.SecureWideADPAlgorithmEnable_43200.Value)
						{
							num2 = (short)1532952577;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 3:
						if (!general.SecureWideDESAlgorithmEnable_43744.Value)
						{
							num2 = (short)277479428;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 4:
						return false;
					case 5:
						if (!general.SecureWideAESAlgorithmEnable_43201.Value)
						{
							num2 = (short)1793982471;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 6:
						num2 = (short)871235586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
					{
						num2 = (short)60152009;
						short num3 = num2;
						num2 = (short)851695817;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37;
						default:
							num2 = (short)1090912256;
							if (num2 != 0)
							{
							}
							num2 = (short)1635450883;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_30;
				}
				return false;
			}
			IL_30:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General);
			IL_37:
			num2 = (short)267780096;
			short num4 = num2;
			num2 = (short)846856192;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x001EC400 File Offset: 0x001EA600
		internal static bool ConKeyLoadingSourceInvalid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (general.SecWideGeneralSecureOperation_A9067.Value == 3)
						{
							num2 = (short)1949761542;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 1:
						num2 = (short)1255800837;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (!general.SecureWideAESAlgorithmEnable_43201.Value)
						{
							num2 = (short)567803905;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_A2;
					case 3:
						if (index == 0)
						{
							num2 = (short)167641092;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 4:
						return false;
					case 5:
						if (general.SecureWideDESAlgorithmEnable_43744.Value)
						{
							num2 = (short)1800208391;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 6:
						num2 = (short)1989672962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
					{
						num2 = (short)821084414;
						short num3 = num2;
						num2 = (short)995082494;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37;
						default:
							num2 = (short)1414529025;
							if (num2 != 0)
							{
							}
							num2 = (short)1989672960;
							if (num2 != 0)
							{
							}
							goto IL_A2;
						}
						break;
					}
					}
					goto IL_30;
					IL_A2:
					num2 = (short)1642004483;
					num = (int)((global::System.IntPtr)num2);
				}
				return false;
			}
			IL_30:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General);
			IL_37:
			num2 = (short)1018167296;
			short num4 = num2;
			num2 = (short)1130561536;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x001EC5E8 File Offset: 0x001EA7E8
		internal static bool ConIsCKRApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			for (;;)
			{
				IL_0A:
				num = (short)1984233472;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_166;
				case 1:
					goto IL_A2;
				case 2:
					if (secWideGeneralSecureOperation_A.Value != 1)
					{
						num = (short)2055208961;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
				{
					num = (short)1795861734;
					short num4 = num;
					num = (short)1068084454;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A2;
					default:
						num = (short)712441857;
						if (num != 0)
						{
						}
						num = (short)818085888;
						if (num != 0)
						{
						}
						if (secWideGeneralSecureOperation_A.Value == 3)
						{
							num = (short)1814167552;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				}
				goto IL_49;
				IL_A2:
				num = (short)1995243523;
				num3 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_166:
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			return secureWide.General.SecureWideKeyloadingSource_43204.Value == 1;
			IL_49:
			secureWide = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			secWideGeneralSecureOperation_A = secureWide.General.SecWideGeneralSecureOperation_A9067;
			num = (short)548929538;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x001EC764 File Offset: 0x001EA964
		internal static bool ConSecOperationIsSoftware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2111963137;
			if (num != 0)
			{
			}
			num = (short)2008698843;
			short num2 = num;
			num = (short)970739675;
			switch (num2 == num)
			{
			}
			num = (short)221118464;
			if (num != 0)
			{
			}
			num = (short)154402816;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General).SecWideGeneralSecureOperation_A9067.Value == 3;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x001EC824 File Offset: 0x001EAA24
		internal static bool ConIsEnhancedKeyEraseOnRadioInhibitApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general;
			global::AcpBusinessLayer.AcpField<bool> secWideGeneralOTAREnable_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1D7;
				case 1:
					num2 = (short)514326537;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (general.SecWideGeneralSecureOperation_A9067.Value == 3)
					{
						num2 = (short)865009665;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					if (secWideGeneralOTAREnable_A.Applicable)
					{
						num2 = (short)707330054;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					num2 = (short)1340342275;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_D3;
				case 6:
				{
					num2 = (short)832241665;
					if (num2 != 0)
					{
					}
					num2 = (short)1751533701;
					short num3 = num2;
					num2 = (short)1239763077;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D7;
					default:
						num2 = (short)1471676416;
						if (num2 != 0)
						{
						}
						num2 = (short)207355904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					num2 = (short)1763835912;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (secWideGeneralOTAREnable_A.Applicable)
					{
						num2 = (short)1149763589;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
					if (secWideGeneralOTAREnable_A.Value)
					{
						num2 = (short)271908868;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_38;
				IL_1D7:
				if (!secWideGeneralOTAREnable_A.Value)
				{
					return false;
				}
				num2 = (short)1556414464;
				short num4 = num2;
				num2 = (short)1793458183;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D3:
			return general.SecWideGeneralEnhancedADPRadioInhibit_A41461.Value;
			IL_38:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General);
			secWideGeneralOTAREnable_A = general.SecWideGeneralOTAREnable_A7966;
			secWideGeneralOTAREnable_A.CalculateApplicability();
			num2 = (short)2075394050;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x001ECA58 File Offset: 0x001EAC58
		internal static bool ConIsEnhancedKeyEraseOnRadioInhibitValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)929038338;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpField<bool> secWideGeneralOTAREnable_A;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11F;
				case 1:
					num = (short)1474560003;
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
					if (!secWideGeneralOTAREnable_A.Value)
					{
						goto IL_124;
					}
					num = (short)351971107;
					short num3 = num;
					num = (short)1870636835;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1292304384;
						if (num != 0)
						{
						}
						num = (short)1594425345;
						if (num != 0)
						{
						}
						num = (short)1819803648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_34:
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General;
				secWideGeneralOTAREnable_A = general.SecWideGeneralOTAREnable_A7966;
				secWideGeneralOTAREnable_A.CalculateApplicability();
				if (!general.SecWideGeneralEnhancedADPRadioInhibit_A41461.Value)
				{
					goto IL_124;
				}
				num = (short)1586036737;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11F:
			return !secWideGeneralOTAREnable_A.Applicable;
			IL_124:
			num = (short)1525809152;
			short num4 = num;
			return true;
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x001ECBB4 File Offset: 0x001EADB4
		internal static bool ConIsSecureOperationApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (general.SecWideGeneralOTAREnable_A7966.Value)
					{
						num2 = (short)1399521280;
						short num3 = num2;
						num2 = (short)1136787463;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B7;
				case 1:
				{
					num2 = (short)627895213;
					short num4 = num2;
					num2 = (short)2073750445;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)637534208;
						if (num2 != 0)
						{
						}
						break;
					}
					num2 = (short)1173684230;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (general.SecWideGeneralSecureOperation_A9067.Value == 3)
					{
						num2 = (short)782499841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B7;
				case 3:
					num2 = (short)739573761;
					if (num2 != 0)
					{
					}
					secureKMFProfileRecset.SetMax(1);
					num2 = (short)2118778888;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return true;
				case 5:
					if (secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
					{
						num2 = (short)1608384515;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B7;
				case 6:
					if (general.SecureWideAESAlgorithmEnable_43201.Value)
					{
						num2 = (short)2110128137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B7;
				case 7:
					num2 = (short)2134441989;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return true;
				case 9:
					num2 = (short)1963720704;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_1B7:
				secureKMFProfileRecset.SetMax(19);
				num2 = (short)542244868;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_38:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General);
			secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
			num2 = (short)785383426;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x001ECE08 File Offset: 0x001EB008
		internal static bool ConAstroOtarIsApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (secureWide.General.SecWideGeneralOTAREnable_A7966.Value)
					{
						num2 = (short)1214316548;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
				{
					global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
					if (secWideGeneralSecureOperation_A.Value == 3)
					{
						num2 = (short)1530986499;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D4;
				}
				case 2:
				{
					global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
					if (secWideGeneralSecureOperation_A.Value != 1)
					{
						num2 = (short)966066181;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_148;
				}
				case 3:
					goto IL_1B1;
				case 4:
					num2 = (short)2058485762;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1982922753;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
			}
			IL_D4:
			num2 = (short)850853889;
			if (num2 != 0)
			{
			}
			return false;
			IL_148:
			num2 = (short)649986048;
			short num3 = num2;
			return true;
			IL_1B1:
			return secureWide.General.SecureWideAESAlgorithmEnable_43201.Value;
			IL_28:
			num2 = (short)1854408729;
			short num4 = num2;
			num2 = (short)1463683097;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1232076800;
				if (num2 != 0)
				{
				}
				secureWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
				global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A = secureWide.General.SecWideGeneralSecureOperation_A9067;
				num2 = (short)1340145664;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x001ECFCC File Offset: 0x001EB1CC
		internal static bool ConASTROOTARRadioIDVallid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR astrootar;
			global::AcpBusinessLayer.AcpSimpleRangeField secWideASTROOTARIndividualASTROOTARRadioID_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1986605902;
					short num3 = num2;
					num2 = (short)991179598;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B6;
					default:
						goto IL_12B;
					}
					break;
				}
				case 1:
					if (astrootar != null)
					{
						num2 = (short)368377859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					if (secWideASTROOTARIndividualASTROOTARRadioID_A.Value > 0)
					{
						goto IL_B6;
					}
					return false;
				case 3:
					secWideASTROOTARIndividualASTROOTARRadioID_A = astrootar.SecWideASTROOTARIndividualASTROOTARRadioID_A8284;
					num2 = (short)74842113;
					if (num2 != 0)
					{
					}
					num2 = (short)214302722;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
				IL_B6:
				num2 = (short)1198129152;
				short num4 = num2;
				num2 = (short)184680448;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_12B:
			num2 = (short)285736960;
			if (num2 != 0)
			{
			}
			return secWideASTROOTARIndividualASTROOTARRadioID_A.Value < 9999999;
			IL_20:
			astrootar = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR);
			num2 = (short)535101441;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x001ED120 File Offset: 0x001EB320
		internal static bool ConIsSecureOperationEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General general;
			short num;
			for (;;)
			{
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General);
				if (general.RefRadioWide.Labtool.RadWideLabtoolDisableEncryption_43371 != null)
				{
					break;
				}
				num = (short)1797402381;
				short num2 = num;
				num = (short)1752248077;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_94;
				}
			}
			num = (short)1399062528;
			short num3 = num;
			return !general.RefRadioWide.Labtool.RadWideLabtoolDisableEncryption_43371.Value;
			IL_94:
			num = (short)390922241;
			if (num != 0)
			{
			}
			num = (short)895483904;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x001ED200 File Offset: 0x001EB400
		private static bool a(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide A_0)
		{
			short num = (short)597164035;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)262406149;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (A_0.General.SecureWideAESAlgorithmEnable_43201.Value)
					{
						num = (short)802418364;
						short num3 = num;
						num = (short)1074130620;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_A3;
						}
					}
					num = (short)768933890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1A5;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
				{
					num = (short)1514536960;
					short num4 = num;
					num = (short)580714497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					if (A_0.General.SecWideGeneralSecureOperation_A9067.Value == 3)
					{
						num = (short)709558276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_3C:
				if (A_0.General.SecWideGeneralSecureOperation_A9067.Value == 1)
				{
					return true;
				}
				num = (short)517472256;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A3:
			num = (short)764739585;
			if (num != 0)
			{
			}
			num = (short)543358976;
			if (num != 0)
			{
			}
			return true;
			IL_1A5:
			return A_0.General.SecureWideDESAlgorithmEnable_43744.Value;
		}
	}
}
