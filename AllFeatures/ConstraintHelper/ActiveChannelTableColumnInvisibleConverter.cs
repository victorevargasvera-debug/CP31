using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace ConstraintHelper
{
	// Token: 0x020005F7 RID: 1527
	public class ActiveChannelTableColumnInvisibleConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600D0EC RID: 53484 RVA: 0x00C3B2BC File Offset: 0x00C394BC
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
			short num = (short)1468596224;
			switch (num)
			{
			default:
			{
				num = (short)869072913;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)815595522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_528;
					}
					case 1:
						num = (short)124977158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_47E;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset = global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset;
						num = (short)1596325888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						int num3 = (int)values[0];
						num = (short)623509509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if ((global::AcpCommonLib.DifferentiatedUserViewType)values[1] == global::AcpCommonLib.DifferentiatedUserViewType.Labtool)
						{
							num = (short)57016335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_528;
					case 6:
						if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)639172612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_528;
					case 7:
						if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1280770049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_528;
					case 8:
						goto IL_589;
					case 9:
					{
						int num3;
						if (num3 >= 0)
						{
							num = (short)2036465667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_528;
					}
					case 10:
						goto IL_D3;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
						int num3;
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = zoneChannelAssignmentRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						num = (short)945094668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (zoneChannelAssignment != null)
						{
							num = (short)223936528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_528;
					}
					case 13:
					{
						num = (short)1300037632;
						short num4 = num;
						if (!flag)
						{
							num = (short)1509687304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72A;
					}
					case 14:
					{
						num = (short)1950875649;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
						int num3;
						if (zoneChannelAssignmentRecset.Count > num3)
						{
							num = (short)1831796747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_528;
					}
					case 15:
						num = (short)1798504457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = zoneChannelAssignment.EmbeddedRecordsets.GetEnumerator();
						num = (short)535560210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						switch (0)
						{
						case 0:
							goto IL_98;
						}
						continue;
					case 18:
						try
						{
							num = (short)1787559941;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									if (acpRecordset.RecordsetName == global::AllFeatures.CodeplugGuid.b("臁곃Ʂꛇ꓉꧋ꋍ鏑ꟓꗕ뇗뷙닛돝藟賡郣웥ꓧ菩鿫髭", a_))
									{
										num = (short)640155649;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
									num = (short)1894645766;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1389887491;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_409;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)551223298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
									num = (short)893583360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_11A;
									}
									continue;
								case 6:
									try
									{
										num = (short)1734148103;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_251;
											case 1:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
												zoneChannelAssignment.CalculateVisibility();
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
												flag = channelAssignmentListInnerSection.ChannelsActiveChannel_Visible;
												num = (short)168820736;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_2F4;
											case 3:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
												if (channelAssignmentListInnerSection != null)
												{
													num = (short)1860239361;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_2DA;
											}
											case 4:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection = (acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ChannelAssignmentListInnerSection;
												num = (short)1152843779;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												goto IL_2DA;
											case 6:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												if (acpFeatureNode is global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)
												{
													num = (short)883032068;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_2DA;
											}
											case 7:
												switch (0)
												{
												case 0:
													goto IL_1E6;
												}
												continue;
											case 8:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1922039813;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator2.Current;
												num = (short)775159814;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_1E6:
											num = (short)1643577352;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2DA:
											num = (short)853868546;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_251:
										IL_2F4:
										goto IL_528;
									}
									finally
									{
										num = (short)1365311489;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												goto IL_3AF;
											case 1:
											{
												num = (short)462532451;
												short num5 = num;
												num = (short)743681891;
												switch ((num5 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_37B;
												default:
													num = (short)1626472448;
													if (num != 0)
													{
													}
													switch (0)
													{
													case 0:
														goto IL_377;
													}
													continue;
												}
												break;
											}
											case 2:
												enumerator2.Dispose();
												num = (short)385089536;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_377;
											IL_37B:
											num = (short)124125186;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_377:
											if (enumerator2 != null)
											{
												goto IL_37B;
											}
											break;
										}
										IL_3AF:;
									}
									break;
								}
								IL_3B2:
								num = (short)49152004;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11A:
								goto IL_3B2;
							}
							IL_409:
							goto IL_528;
						}
						finally
						{
							num = (short)496304129;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_47B;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_441;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)2098724864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_441:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2022506498;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_47B:;
						}
						goto IL_47E;
					}
					IL_98:
					if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
					{
						num = (short)1937244170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = false;
					num = (short)1055653895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47E:
					num = (short)676462606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_528:
					num = (short)287571981;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D3:
				return global::System.Windows.Visibility.Collapsed;
				IL_589:
				return global::System.Windows.Visibility.Collapsed;
				IL_72A:
				return global::System.Windows.Visibility.Visible;
			}
			}
		}

		// Token: 0x0600D0ED RID: 53485 RVA: 0x00C3BA30 File Offset: 0x00C39C30
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)98566145;
			if (num != 0)
			{
			}
			num = (short)1994206357;
			short num2 = num;
			num = (short)1623600277;
			switch (num2 == num)
			{
			}
			num = (short)1668153344;
			short num3 = num;
			num = (short)1214971904;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
