using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000032 RID: 50
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CrumbBarViewPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x0600037D RID: 893 RVA: 0x0004C414 File Offset: 0x0004A614
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)241369088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BC;
				}
				global::DevComponents.WpfRibbon.CrumbBarViewOverflowPanel overflowPanel;
				global::System.Windows.Size result;
				global::System.Windows.Size availableSize2;
				for (;;)
				{
					IL_29:
					global::DevComponents.WpfRibbon.CrumbBar crumbBar;
					bool flag;
					global::System.Windows.Size desiredSize;
					global::System.Windows.UIElement uielement;
					global::System.Collections.Generic.List<global::System.Windows.UIElement>.Enumerator enumerator;
					int num5;
					global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView2;
					global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView3;
					global::System.Windows.UIElement uielement3;
					int num6;
					switch (num2)
					{
					case 0:
						crumbBar.HasOverflowItems = flag;
						num = (short)1231683600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_723;
					case 2:
						goto IL_6B1;
					case 3:
						overflowPanel.Children.Clear();
						num = (short)642842645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (overflowPanel != null)
						{
							num = (short)1365704707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_761;
					case 5:
						goto IL_164;
					case 6:
						if (global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(desiredSize.Width + result.Width, availableSize.Width))
						{
							num = (short)1969487884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F3;
					case 7:
						num = (short)622067731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)242614278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (crumbBar != null)
						{
							num = (short)842792960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
						base.Children.Remove(uielement);
						overflowPanel.Children.Insert(0, uielement);
						num = (short)917110797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (!flag)
						{
							num = (short)94502920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B1;
					case 12:
						num = (short)1171587087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_1BF;
					case 14:
						goto IL_164;
					case 15:
						if (overflowPanel != null)
						{
							num = (short)770768923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F3;
					case 16:
						return result;
					case 17:
						goto IL_3AE;
					case 18:
						goto IL_723;
					case 19:
						if (flag)
						{
							num = (short)1748631578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AE;
					case 20:
					{
						try
						{
							num = (short)1124401158;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)772276229;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement2 = enumerator.Current;
									base.Children.Add(uielement2);
									global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView = uielement2 as global::DevComponents.WpfRibbon.CrumbBarItemView;
									goto IL_24C;
								}
								case 1:
									goto IL_345;
								case 2:
								{
									global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView;
									crumbBarItemView.IsOverflowItem = false;
									num = (short)667615236;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									num = (short)1305677870;
									short num3 = num;
									num = (short)198905902;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_24C;
									default:
									{
										num = (short)74055680;
										if (num != 0)
										{
										}
										global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView;
										if (crumbBarItemView != null)
										{
											num = (short)1359347714;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								case 5:
									num = (short)1370030081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_227;
									}
									continue;
								}
								goto IL_227;
								IL_24C:
								num = (short)1183383555;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2EE:
								num = (short)726794240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_227:
								goto IL_2EE;
							}
							IL_345:
							goto IL_187;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_358;
						IL_187:
						int num4 = this.m_GeneratedChildren.Count - 1;
						flag = false;
						result = default(global::System.Windows.Size);
						num5 = num4;
						num = (short)1773862913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_761;
					case 22:
						if (crumbBarItemView2.IsOverflowItem)
						{
							num = (short)823459850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BF;
					case 23:
						if (crumbBarItemView3 != null)
						{
							num = (short)1875574814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_796;
					case 24:
						goto IL_4C0;
					case 25:
						if (num5 < 0)
						{
							num = (short)1567490055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement3 = this.m_GeneratedChildren[num5];
						uielement3.Measure(availableSize2);
						desiredSize = uielement3.DesiredSize;
						desiredSize.Width = global::System.Math.Round(desiredSize.Width);
						desiredSize.Height = global::System.Math.Round(desiredSize.Height);
						num = (short)548864011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num6 = 0;
						num = (short)1694040095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)1918304289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						int num4;
						if (num6 > num4)
						{
							num = (short)1825505297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_358;
					}
					case 29:
						goto IL_796;
					case 30:
						crumbBarItemView3.IsOverflowItem = true;
						num = (short)1148846109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_4C0;
					case 32:
						num = (short)1164509206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						int num4;
						if (num5 < num4)
						{
							num = (short)1444937730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F3;
					}
					case 34:
						if (crumbBarItemView2 != null)
						{
							num = (short)1052966944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BF;
					}
					goto IL_BC;
					IL_164:
					num5--;
					num = (short)1449984018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BF:
					num6++;
					num = (short)1782513688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_358:
					uielement = this.m_GeneratedChildren[num6];
					crumbBarItemView2 = (uielement as global::DevComponents.WpfRibbon.CrumbBarItemView);
					num = (short)264699938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AE:
					crumbBar = this.CrumbBar;
					num = (short)1108410377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F3:
					result.Width += desiredSize.Width;
					result.Height = global::System.Math.Max(desiredSize.Height, result.Height);
					num = (short)310050830;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C0:
					num = (short)87883804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B1:
					num = (short)619511808;
					short num7 = num;
					crumbBarItemView3 = (uielement3 as global::DevComponents.WpfRibbon.CrumbBarItemView);
					num = (short)312934423;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_723:
					num = (short)1224212505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_761:
					base.Children.Clear();
					enumerator = this.GeneratedChildren.GetEnumerator();
					num = (short)546832404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_796:
					flag = true;
					num = (short)283115525;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_BC:
				num = (short)1688207361;
				if (num != 0)
				{
				}
				availableSize2 = new global::System.Windows.Size(double.PositiveInfinity, availableSize.Height);
				bool isItemsHost = base.IsItemsHost;
				overflowPanel = this.OverflowPanel;
				num = (short)968491012;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0004CC38 File Offset: 0x0004AE38
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)776142848;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				int num3;
				int num4;
				double num5;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_1C9;
					case 1:
					{
						if (num3 > num4)
						{
							num = (short)613810178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = base.Children[num3];
						uielement.Arrange(new global::System.Windows.Rect(num5, 0.0, uielement.DesiredSize.Width, global::System.Math.Max(uielement.DesiredSize.Height, finalSize.Height)));
						num5 += global::System.Math.Round(uielement.DesiredSize.Width);
						num3++;
						num = (short)1583022080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return finalSize;
					case 3:
					{
						num = (short)1414922240;
						short num6 = num;
						num = (short)78335165;
						short num7 = num;
						num = (short)1904692413;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C9;
						default:
							num = (short)105119744;
							if (num != 0)
							{
							}
							goto IL_10E;
						}
						break;
					}
					}
					goto IL_3E;
					IL_10E:
					num = (short)929759233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C9:
					goto IL_10E;
				}
				return finalSize;
				IL_3E:
				num = (short)1468858369;
				if (num != 0)
				{
				}
				num4 = base.Children.Count - 1;
				num5 = 0.0;
				num3 = 0;
				num = (short)1072693251;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0004CE14 File Offset: 0x0004B014
		private global::DevComponents.WpfRibbon.CrumbBar CrumbBar
		{
			get
			{
				short num = (short)1075411026;
				short num2 = num;
				num = (short)1386248274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447283200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1042219009;
				if (num != 0)
				{
				}
				num = (short)1408434176;
				if (num != 0)
				{
				}
				return base.TemplatedParent as global::DevComponents.WpfRibbon.CrumbBar;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0004CEC4 File Offset: 0x0004B0C4
		internal global::System.Collections.Generic.List<global::System.Windows.UIElement> GeneratedChildren
		{
			get
			{
				short num = (short)664862722;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1760804603;
					short num3 = num;
					num = (short)1301593851;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1836908545;
						if (num != 0)
						{
						}
						num = (short)1978204160;
						short num4 = num;
						num = (short)1768685568;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_10F;
						case 1:
							goto IL_EA;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C9;
							}
							continue;
						}
						IL_C9:
						if (this.m_GeneratedChildren == null)
						{
							num = (short)887947265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111;
					}
					}
					IL_EA:
					this.m_GeneratedChildren = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(10);
					num = (short)1727201280;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10F:
				IL_111:
				return this.m_GeneratedChildren;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0004CFE8 File Offset: 0x0004B1E8
		private global::DevComponents.WpfRibbon.CrumbBarViewOverflowPanel OverflowPanel
		{
			get
			{
				global::DevComponents.WpfRibbon.CrumbBar crumbBar = this.CrumbBar;
				if (crumbBar == null)
				{
					short num = (short)783971609;
					short num2 = num;
					num = (short)1512731929;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1509621760;
						short num3 = num;
						num = (short)1437859841;
						if (num != 0)
						{
						}
						num = (short)857997312;
						if (num != 0)
						{
						}
						return null;
					}
					}
				}
				return crumbBar.OverflowPanel;
			}
		}

		// Token: 0x0400013E RID: 318
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> m_GeneratedChildren;
	}
}
