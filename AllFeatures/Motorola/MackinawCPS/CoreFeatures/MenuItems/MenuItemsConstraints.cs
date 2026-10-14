using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.MenuItems
{
	// Token: 0x020002F1 RID: 753
	public static class MenuItemsConstraints
	{
		// Token: 0x06007A40 RID: 31296 RVA: 0x006F18B8 File Offset: 0x006EFAB8
		public static bool conMenuItemsTrkSel(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)41680896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
					switch (num2)
					{
					case 0:
						result = ((self as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuTrunkingSelectedMenuItems_A21735.Items.Count <= 3);
						num = (short)458489860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)176357377;
						if (num != 0)
						{
						}
						if (radioWide.Labtool.RadWideLabtoolKeypadType_A8372.Value == 1)
						{
							num = (short)616955906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35C;
					case 2:
						num = (short)220397571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if ((self as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuTrunkingSelectedMenuItems_A21735.Items != null)
						{
							num = (short)30212096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35C;
					case 4:
						goto IL_35C;
					case 5:
					{
						num = (short)2005991424;
						short num3 = num;
						try
						{
							num = (short)2088435717;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)303104003;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1636761608;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemName == global::CommonResources.AcgResources.ID_TMS)
									{
										num = (short)1223426057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemName == global::CommonResources.AcgResources.ID_TMS)
									{
										num = (short)1728774150;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F1;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1698365441;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
									num = (short)768737290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_125;
									}
									continue;
								case 6:
								{
									global::AcpBusinessLayer.ListItem listItem;
									listItem.ItemValidity = false;
									result = false;
									num = (short)61079563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_29E;
								case 9:
								{
									global::AcpBusinessLayer.ListItem listItem;
									listItem.ItemValidity = true;
									num = (short)1287520263;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (radioWide.Features.RadWideFeaturesSmartMessagingSmartMessageMode.Value == 1)
									{
										num = (short)1766653952;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F1;
								}
								IL_145:
								num = (short)1995505668;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_125:
								goto IL_145;
								IL_1F1:
								num = (short)698744834;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_29E:
							return result;
						}
						finally
						{
							num = (short)1205862401;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_359;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2D5;
									}
									continue;
								case 2:
								{
									enumerator.Dispose();
									num = (short)784350896;
									short num4 = num;
									num = (short)2037137072;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)859308032;
										if (num != 0)
										{
										}
										num = (short)736624640;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_2D5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1105461250;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_359:;
						}
						goto IL_35C;
					}
					}
					goto IL_48;
					IL_35C:
					enumerator = (self as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuTrunkingSelectedMenuItems_A21735.Items.GetEnumerator();
					num = (short)296615941;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_48:
				result = true;
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)1129316353;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x006F1D1C File Offset: 0x006EFF1C
		public static bool conMenuItemsCnvSel(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1839857664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
					switch (num2)
					{
					case 0:
						flag = ((self as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuConventionalSelectedMenuItems_A21736.Items.Count <= 3);
						num = (short)1745420292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1604780033;
						if (num != 0)
						{
						}
						if (radioWide.Labtool.RadWideLabtoolKeypadType_A8372.Value == 1)
						{
							num = (short)532086786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E3;
					case 2:
						num = (short)2071330819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if ((self as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuConventionalSelectedMenuItems_A21736.Items != null)
						{
							num = (short)1140523008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E3;
					case 4:
						goto IL_3E3;
					case 5:
					{
						num = (short)1811349504;
						short num3 = num;
						try
						{
							num = (short)2071724040;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemName == global::CommonResources.AcgResources.ID_SVCS)
									{
										num = (short)256245772;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BE;
								}
								case 1:
									goto IL_2BE;
								case 2:
									num = (short)27983886;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (radioWide.Features.RadWideFeaturesSmartMessagingSmartMessageMode.Value == 1)
									{
										num = (short)258539522;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_131;
								case 5:
								{
									global::AcpBusinessLayer.ListItem listItem;
									listItem.ItemValidity = true;
									num = (short)1650720777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2090598407;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
									num = (short)732299264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1176436747;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_12F;
									}
									continue;
								case 10:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemName == global::CommonResources.AcgResources.ID_TMS)
									{
										num = (short)1595932677;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
									goto IL_323;
								case 12:
								{
									global::AcpBusinessLayer.ListItem listItem;
									flag = global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItemsConstraints.a(flag, listItem);
									num = (short)360513537;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::AcpBusinessLayer.ListItem listItem;
									listItem.ItemValidity = false;
									flag = false;
									num = (short)912785411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemName == global::CommonResources.AcgResources.ID_TMS)
									{
										num = (short)999358477;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_131;
								}
								}
								goto IL_12F;
								IL_131:
								num = (short)140836874;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_175:
								num = (short)949551110;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12F:
								goto IL_175;
								IL_2BE:
								num = (short)7012356;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_323:
							return flag;
						}
						finally
						{
							num = (short)1187381249;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3E0;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_35B;
									}
									continue;
								case 2:
								{
									enumerator.Dispose();
									num = (short)1275104268;
									short num4 = num;
									num = (short)1285262348;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)231931904;
										if (num != 0)
										{
										}
										num = (short)205324288;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_35B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)205848578;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3E0:;
						}
						goto IL_3E3;
					}
					}
					goto IL_46;
					IL_3E3:
					enumerator = (self as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuConventionalSelectedMenuItems_A21736.Items.GetEnumerator();
					num = (short)643694597;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_46:
				flag = true;
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)1065222145;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x006F2208 File Offset: 0x006F0408
		private static bool a(bool A_0, global::AcpBusinessLayer.ListItem A_1)
		{
			short num = (short)996933632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1058603008;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				for (;;)
				{
					IL_54:
					switch (num2)
					{
					case 0:
						goto IL_C6;
					case 1:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1139408898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)411631616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_67;
				}
				return false;
				IL_C6:
				bool result;
				try
				{
					num = (short)776798213;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall astrocall;
							if (astrocall != null)
							{
								num = (short)106692610;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							num = (short)276693000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall astrocall;
							int value = astrocall.CnvPerASTROCallTacticalServicesOperation.Value;
							int value2 = astrocall.CnvPerASTROCallRadioUninhibitDecodeAction_A9045.Value;
							num = (short)412876803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							int value;
							if (value != 2)
							{
								num = (short)1967783942;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22F;
						}
						case 4:
						{
							num = (short)1166278657;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1047396353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall astrocall = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10141] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall;
							num = (short)316145664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_120;
							}
							continue;
						case 6:
							num = (short)667877387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_2C6;
						case 9:
							goto IL_255;
						case 10:
							goto IL_22F;
						case 11:
						{
							int value;
							if (value == 3)
							{
								num = (short)1315700746;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_1.ItemValidity = false;
							A_0 = false;
							num = (short)131203079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_143:
						num = (short)1175388164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_120:
						goto IL_143;
						IL_22F:
						A_1.ItemValidity = true;
						A_0 = true;
						result = A_0;
						num = (short)159252489;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_255:
					return result;
					IL_2C6:
					return A_0;
				}
				finally
				{
					num = (short)1436942338;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_333;
						case 1:
							enumerator.Dispose();
							num = (short)1376059392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2FD;
							}
							continue;
						}
						IL_2FD:
						if (enumerator == null)
						{
							break;
						}
						num = (short)684457985;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_333:
					num = (short)1117933614;
					short num4 = num;
					num = (short)1151291438;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_333;
					default:
						num = (short)340459520;
						if (num != 0)
						{
						}
						break;
					}
				}
				return result;
				IL_67:
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)1061617665;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			}
		}
	}
}
