using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x020000A0 RID: 160
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RibbonTabPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x060007CD RID: 1997 RVA: 0x000B3EE4 File Offset: 0x000B20E4
		static RibbonTabPanel()
		{
			int a_ = 0;
			short num = (short)620451836;
			short num2 = num;
			num = (short)1345476604;
			switch (num2 == num)
			{
			}
			num = (short)1923022849;
			if (num != 0)
			{
			}
			num = (short)1021444096;
			if (num != 0)
			{
			}
			num = (short)1948778496;
			short num3 = num;
			global::DevComponents.WpfRibbon.RibbonTabPanel.TabsScrolledEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("౗㭙㹛ⵝ㍟šᙣ॥ѧ٩५੭", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.RibbonTabPanel));
			global::DevComponents.WpfRibbon.RibbonTabPanel.PanelAlignmentProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ࡗ㭙㉛㭝౟⍡ࡣཥཧѩū୭ṯٱ", a_), typeof(global::DevComponents.WpfRibbon.eTabElementAlignment), typeof(global::DevComponents.WpfRibbon.RibbonTabPanel), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eTabElementAlignment.Left, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonTabPanel.OnPanelAlignmentChanged)), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.RibbonTabPanel.IsPanelAlignmentValid));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.RibbonTabPanel), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Cycle));
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000B4030 File Offset: 0x000B2230
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::System.Windows.Size result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_ED;
				case 1:
					num2 = (short)40828929;
					if (num2 != 0)
					{
					}
					if (this.m_TabsSize > 0.0)
					{
						num2 = (short)172097539;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11C;
				case 2:
					num2 = (short)166395905;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					double reduction = (this.m_TabsSize - (result.Width - availableSize.Width)) / this.m_TabsSize;
					result = this.MeasureInternal(availableSize, reduction);
					num2 = (short)1654128644;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_11C;
				case 5:
					if (result.Width - 1.0 > availableSize.Width)
					{
						goto IL_151;
					}
					this.DestroyScrollButtons();
					num2 = (short)1741291526;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_1F5;
				case 7:
					this.CreateScrollButtons();
					num2 = (short)429785088;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)230659020;
					short num3 = num2;
					num2 = (short)1953928140;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_151;
					default:
						num2 = (short)1385365504;
						if (num2 != 0)
						{
						}
						if (result.Width > availableSize.Width)
						{
							num2 = (short)565510146;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_11C;
					}
					break;
				}
				}
				goto IL_34;
				IL_11C:
				num2 = (short)1960640517;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_151:
				num2 = (short)1189609479;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_ED:
			num2 = (short)1034223616;
			short num4 = num2;
			IL_1F5:
			this.MeasureScrollButtons(availableSize);
			this.m_AvailableWidth = availableSize.Width;
			return result;
			IL_34:
			result = this.MeasureInternal(availableSize, 0.0);
			num2 = (short)366411784;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000B4290 File Offset: 0x000B2490
		private global::System.Windows.Size MeasureInternal(global::System.Windows.Size availableSize, double reduction)
		{
			short num = (short)1824325632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)2020540417;
				if (num != 0)
				{
				}
				this.m_TabsCount = 0;
				this.m_TabsSize = 0.0;
				global::System.Windows.Size result = default(global::System.Windows.Size);
				global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
				bool flag = !global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(reduction);
				global::System.Collections.IEnumerator enumerator = internalChildren.GetEnumerator();
				try
				{
					num = (short)1762394125;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Windows.Size desiredSize;
						global::System.Windows.UIElement uielement;
						global::System.Windows.Size availableSize2;
						switch (num2)
						{
						case 0:
							result.Height = desiredSize.Height;
							num = (short)344850440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1123876873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)848035858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_324;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)805109772;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)1309474833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							this.m_TabsCount++;
							this.m_TabsSize += desiredSize.Width;
							num = (short)473038854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_40A;
						case 8:
							goto IL_2D2;
						case 9:
							if (uielement != this.m_ScrollLeft)
							{
								num = (short)279642114;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 10:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)1776943109;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
							if (result.Height < desiredSize.Height)
							{
								num = (short)1498611712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2D2;
						case 12:
							num = (short)1689452551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							switch (0)
							{
							case 0:
								goto IL_ED;
							}
							continue;
						case 14:
						{
							availableSize2 = availableSize;
							bool flag2 = uielement is global::DevComponents.WpfRibbon.RibbonTab;
							num = (short)1241513999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
						{
							bool flag2;
							if (flag && flag2)
							{
								num = (short)559742992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_324;
						}
						case 16:
							availableSize2 = uielement.DesiredSize;
							availableSize2.Width = global::System.Math.Round(availableSize2.Width);
							availableSize2.Height = global::System.Math.Round(availableSize2.Height);
							availableSize2.Width = global::System.Math.Max((double)global::DevComponents.WpfRibbon.RibbonTab.MinimumTabWidth, availableSize2.Width * reduction);
							num = (short)252706819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
							{
								num = (short)952041473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 18:
							if (uielement != this.m_ScrollRight)
							{
								num = (short)1938685966;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						IL_1DA:
						num = (short)325517316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_ED:
						goto IL_1DA;
						IL_2D2:
						result.Width += desiredSize.Width;
						num = (short)434503690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_324:
						uielement.Measure(availableSize2);
						desiredSize = uielement.DesiredSize;
						desiredSize.Width = global::System.Math.Round(desiredSize.Width);
						desiredSize.Height = global::System.Math.Round(desiredSize.Height);
						num = (short)1616904203;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_40A:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_42C;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_419:
						switch (num2)
						{
						case 0:
						{
							num = (short)1697747976;
							short num3 = num;
							num = (short)2106364936;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_44A;
							default:
								goto IL_4BC;
							}
							break;
						}
						case 1:
							disposable.Dispose();
							num = (short)1756168192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_44A;
						}
						goto IL_42C;
						IL_44A:
						if (disposable == null)
						{
							goto IL_4D4;
						}
						num = (short)1910833153;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4BC:
					num = (short)1944649728;
					if (num != 0)
					{
					}
					IL_4D4:
					goto EndFinally_11;
					IL_42C:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1465384962;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_419;
					EndFinally_11:;
				}
				num = (short)650903552;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000B47B8 File Offset: 0x000B29B8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)588447744;
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
				double num4;
				global::System.Collections.IEnumerator enumerator;
				double num5;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)1284308992;
						short num3 = num;
						this.m_ScrollRight.Arrange(new global::System.Windows.Rect(this.m_AvailableWidth - this.m_ScrollRight.DesiredSize.Width, 0.0, this.m_ScrollRight.DesiredSize.Width, finalSize.Height));
						num = (short)677576709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (this.m_ScrollLeft != null)
						{
							num = (short)1670643716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					case 2:
						this.m_RaiseTabsScrolledEvent = false;
						base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.RibbonTabPanel.TabsScrolledEvent, this));
						num = (short)717619207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.m_ScrollRight != null)
						{
							num = (short)1562247168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C8;
					case 4:
						this.m_ScrollLeft.Arrange(new global::System.Windows.Rect(0.0, 0.0, this.m_ScrollLeft.DesiredSize.Width, finalSize.Height));
						num = (short)347996166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_4C8;
					case 6:
						goto IL_F8;
					case 7:
						goto IL_192;
					case 8:
						num = (short)1010565121;
						if (num != 0)
						{
						}
						if (this.m_RaiseTabsScrolledEvent)
						{
							num = (short)1211760642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CE;
					case 9:
						try
						{
							num = (short)370540552;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Windows.UIElement uielement;
									bool panelAlignment = global::DevComponents.WpfRibbon.RibbonTabPanel.GetPanelAlignment(uielement) != global::DevComponents.WpfRibbon.eTabElementAlignment.Left;
									global::System.Windows.Size desiredSize = uielement.DesiredSize;
									if (!panelAlignment)
									{
										num = (short)765394949;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num4 -= desiredSize.Width;
									uielement.Arrange(new global::System.Windows.Rect(num4 + (double)this.m_HorizontalOffset, 0.0, desiredSize.Width, finalSize.Height));
									num = (short)2108293123;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1703084039;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1824391170;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::System.Windows.UIElement uielement;
									if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)2095579142;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)218955786;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Windows.UIElement uielement;
									global::System.Windows.Size desiredSize;
									uielement.Arrange(new global::System.Windows.Rect(num5, 0.0, desiredSize.Width, finalSize.Height));
									num5 += desiredSize.Width;
									num = (short)1401290763;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1872494605;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)381026313;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_1F6;
									}
									continue;
								case 9:
									goto IL_400;
								case 10:
								{
									global::System.Windows.UIElement uielement;
									if (uielement != this.m_ScrollRight)
									{
										num = (short)148045836;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									num = (short)1786642432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									global::System.Windows.UIElement uielement;
									if (uielement != this.m_ScrollLeft)
									{
										num = (short)484638724;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_233:
								num = (short)275775489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F6:
								goto IL_233;
							}
							IL_400:
							goto IL_58B;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_422;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_40F:
								switch (num2)
								{
								case 0:
								{
									num = (short)2137531447;
									short num6 = num;
									num = (short)1680811063;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_440;
									default:
										goto IL_4B0;
									}
									break;
								}
								case 1:
									disposable.Dispose();
									num = (short)1461125120;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_440;
								}
								goto IL_422;
								IL_440:
								if (disposable == null)
								{
									goto IL_4C7;
								}
								num = (short)2026569729;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4B0:
							num = (short)1989607424;
							if (num != 0)
							{
							}
							IL_4C7:
							goto EndFinally_12;
							IL_422:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)507576322;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_40F;
							EndFinally_12:;
						}
						goto IL_4C8;
						IL_58B:
						num = (short)502136833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56;
					IL_F8:
					num = (short)352911363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C8:
					num = (short)1287913480;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_192:
				IL_5CE:
				this.InvalidateContextGroupParent();
				return finalSize;
				IL_56:
				num5 = (double)this.m_HorizontalOffset;
				num4 = finalSize.Width;
				enumerator = base.InternalChildren.GetEnumerator();
				num = (short)1290534921;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000B4DB8 File Offset: 0x000B2FB8
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)194737837;
					short num3 = num2;
					num2 = (short)145520301;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37;
					default:
						goto IL_D7;
					}
					break;
				}
				case 1:
				{
					num2 = (short)289603584;
					short num4 = num2;
					this.UpdateScrollButtonVisibility();
					num2 = (short)216989696;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_37;
				}
				goto IL_1C;
				IL_37:
				if (!this.IsScrollUsed)
				{
					goto IL_116;
				}
				num2 = (short)1360461825;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D7:
			num2 = (short)53936129;
			if (num2 != 0)
			{
			}
			num2 = (short)103219200;
			if (num2 != 0)
			{
			}
			IL_116:
			this.InvalidateContextGroupParent();
			return;
			IL_1C:
			base.OnRenderSizeChanged(sizeInfo);
			num2 = (short)1028718594;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x000B4EE4 File Offset: 0x000B30E4
		private void InvalidateContextGroupParent()
		{
			short num = (short)1814102016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = base.InternalChildren.GetEnumerator();
				try
				{
					num = (short)1173487626;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Windows.UIElement uielement;
							uielement.InvalidateMeasure();
							num = (short)231342083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_1AB;
						case 2:
						{
							global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
							global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetParent(ribbonTab.ContextGroup) as global::System.Windows.UIElement;
							num = (short)1513488391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_15F;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)150667265;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::DevComponents.WpfRibbon.RibbonTab ribbonTab = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfRibbon.RibbonTab;
							num = (short)1316749320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_1C4;
						case 6:
						{
							global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
							if (ribbonTab.ContextGroup != null)
							{
								num = (short)444661762;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							global::System.Windows.UIElement uielement;
							if (uielement != null)
							{
								num = (short)747896832;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1AB;
						}
						case 8:
						{
							global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
							if (ribbonTab != null)
							{
								num = (short)1007353865;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							num = (short)1971847174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							switch (0)
							{
							case 0:
								goto IL_7E;
							}
							continue;
						}
						IL_B9:
						num = (short)1668808708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7E:
						goto IL_B9;
						IL_1AB:
						num = (short)33095685;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_15F:
					IL_1C4:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1E6;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_1D3:
						switch (num2)
						{
						case 0:
						{
							num = (short)1849360385;
							if (num != 0)
							{
							}
							num = (short)466799346;
							short num3 = num;
							num = (short)821938930;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_203;
							default:
								goto IL_29B;
							}
							break;
						}
						case 1:
							disposable.Dispose();
							num = (short)1916665856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_203;
						}
						goto IL_1E6;
						IL_203:
						if (disposable == null)
						{
							goto IL_2B4;
						}
						num = (short)382533633;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_29B:
					num = (short)192937984;
					if (num != 0)
					{
					}
					IL_2B4:
					goto EndFinally_8;
					IL_1E6:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)554827778;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_1D3;
					EndFinally_8:;
				}
				num = (short)2011430912;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x000B51F0 File Offset: 0x000B33F0
		private void MeasureScrollButtons(global::System.Windows.Size availableSize)
		{
			short num = (short)560857093;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.m_ScrollRight.Measure(availableSize);
					num = (short)1195966467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)2090716549;
					short num3 = num;
					num = (short)264031621;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C5;
					default:
						num = (short)692649984;
						if (num != 0)
						{
						}
						goto IL_AD;
					}
					break;
				}
				case 2:
					this.m_ScrollLeft.Measure(availableSize);
					num = (short)1934098433;
					if (num != 0)
					{
					}
					num = (short)130023425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_7F;
				case 4:
					goto IL_C5;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				IL_3D:
				if (this.m_ScrollLeft != null)
				{
					num = (short)1196425218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AD:
				num = (short)65929220;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C5:
				if (this.m_ScrollRight == null)
				{
					return;
				}
				num = (short)1081868288;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7F:
			num = (short)1700790272;
			short num4 = num;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000B5384 File Offset: 0x000B3584
		private void CreateScrollButtons()
		{
			int a_ = 5;
			short num = (short)565444609;
			if (num != 0)
			{
			}
			if (this.m_ScrollLeft != null)
			{
				num = (short)121372061;
				short num2 = num;
				num = (short)1825635741;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1670119424;
					if (num != 0)
					{
					}
					num = (short)1757347840;
					short num3 = num;
					return;
				}
				}
			}
			this.m_ScrollLeft = new global::System.Windows.Controls.Primitives.RepeatButton();
			this.m_ScrollLeft.Style = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ཛྷ㙞͠Ţ੤०㩨ࡪὬnᵰὲ㝴ɶ൸ེቼᅾ", a_))) as global::System.Windows.Style);
			this.m_ScrollLeft.Tag = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᅜ㩞ݠᝢ㙤Ѧ᭨ѪŬͮ", a_);
			this.m_ScrollLeft.Click += this.ScrollLeft_Click;
			this.m_ScrollLeft.Visibility = global::System.Windows.Visibility.Collapsed;
			base.AddLogicalChild(this.m_ScrollLeft);
			base.AddVisualChild(this.m_ScrollLeft);
			this.m_ScrollRight = new global::System.Windows.Controls.Primitives.RepeatButton();
			this.m_ScrollRight.Style = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ཛྷ㙞͠Ţ੤०㩨ࡪὬnᵰὲ㝴ɶ൸ེቼᅾ", a_))) as global::System.Windows.Style);
			this.m_ScrollRight.Click += this.ScrollRight_Click;
			base.AddLogicalChild(this.m_ScrollRight);
			base.AddVisualChild(this.m_ScrollRight);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000B5544 File Offset: 0x000B3744
		private void ScrollRight_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1862913112;
			short num2 = num;
			num = (short)573951064;
			switch (num2 == num)
			{
			}
			num = (short)260243456;
			if (num != 0)
			{
			}
			num = (short)718471168;
			short num3 = num;
			num = (short)599785473;
			if (num != 0)
			{
			}
			this.SetScrollOffset(-(int)global::System.Math.Ceiling(global::System.Math.Min(base.DesiredSize.Width, base.RenderSize.Width - (base.DesiredSize.Width + (double)this.m_HorizontalOffset))));
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000B5634 File Offset: 0x000B3834
		private void ScrollLeft_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1639006548;
			short num2 = num;
			num = (short)638796116;
			switch (num2 == num)
			{
			}
			num = (short)2082799617;
			if (num != 0)
			{
			}
			num = (short)1095565312;
			short num3 = num;
			num = (short)1395326976;
			if (num != 0)
			{
			}
			this.SetScrollOffset((int)global::System.Math.Min((double)global::System.Math.Abs(this.m_HorizontalOffset), base.RenderSize.Width));
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000B5704 File Offset: 0x000B3904
		private void SetScrollOffset(int offset)
		{
			short num = (short)1008824478;
			short num2 = num;
			num = (short)948072606;
			switch (num2 == num)
			{
			}
			num = (short)1530986497;
			if (num != 0)
			{
			}
			num = (short)358612992;
			short num3 = num;
			num = (short)369623040;
			if (num != 0)
			{
			}
			this.m_HorizontalOffset += offset;
			base.InvalidateArrange();
			this.UpdateScrollButtonVisibility();
			this.m_RaiseTabsScrolledEvent = true;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000B57D0 File Offset: 0x000B39D0
		private void UpdateScrollButtonVisibility()
		{
			short num = (short)1427505156;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Size size;
				switch (num2)
				{
				case 0:
					this.m_ScrollLeft.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)1966604289;
					if (num != 0)
					{
					}
					num = (short)1810432001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_66;
				case 2:
					if (this.m_HorizontalOffset != 0)
					{
						num = (short)1022558208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C1;
				case 3:
				{
					num = (short)2099794106;
					short num3 = num;
					num = (short)958156986;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CD;
					default:
						num = (short)742719488;
						if (num != 0)
						{
						}
						num = (short)1767505922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 5:
					goto IL_66;
				case 6:
				{
					double num4 = size.Width + (double)this.m_HorizontalOffset;
					size = base.DesiredSize;
					if (num4 <= size.Width)
					{
						num = (short)1131347975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CE;
				}
				case 7:
					goto IL_BC;
				}
				IL_45:
				if (this.m_ScrollLeft != null)
				{
					num = (short)1407778819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_C1;
				IL_66:
				size = base.RenderSize;
				num = (short)1514536966;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CD:
				num = (short)1874460677;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C1:
				this.m_ScrollLeft.Visibility = global::System.Windows.Visibility.Collapsed;
				goto IL_CD;
			}
			IL_BC:
			this.m_ScrollRight.Visibility = global::System.Windows.Visibility.Collapsed;
			return;
			IL_1CE:
			num = (short)1168637952;
			short num5 = num;
			this.m_ScrollRight.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000B59E4 File Offset: 0x000B3BE4
		private bool IsScrollUsed
		{
			get
			{
				short num = (short)1745139217;
				short num2 = num;
				num = (short)1165276689;
				switch (num2 == num)
				{
				}
				num = (short)652804097;
				if (num != 0)
				{
				}
				num = (short)1753743360;
				short num3 = num;
				num = (short)1093337088;
				if (num != 0)
				{
				}
				return this.m_ScrollLeft != null;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x000B5A98 File Offset: 0x000B3C98
		protected override int VisualChildrenCount
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_B9;
				}
				short num;
				int num3;
				int num5;
				for (;;)
				{
					IL_0A:
					num = (short)1679607356;
					short num2 = num;
					num = (short)1113638460;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return num3;
					default:
					{
						num = (short)973012992;
						short num4 = num;
						num = (short)428408833;
						if (num != 0)
						{
						}
						num = (short)173342720;
						if (num != 0)
						{
						}
						switch (num5)
						{
						case 0:
							return num3;
						case 1:
							if (this.IsScrollUsed)
							{
								num = (short)1640562690;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							return num3;
						case 2:
							num3 += 2;
							num = (short)784990208;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B9;
					}
					}
				}
				return num3;
				IL_B9:
				num3 = base.VisualChildrenCount;
				num = (short)324993025;
				num5 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000B5BC0 File Offset: 0x000B3DC0
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			short num = (short)1552220162;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (index >= this.VisualChildrenCount - 2)
					{
						num = (short)1232928769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_182;
				case 1:
					goto IL_104;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					goto IL_C5;
				case 4:
					num = (short)263389184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1877278720;
					short num3 = num;
					if (index == this.VisualChildrenCount - 1)
					{
						num = (short)781975555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)411360992;
					short num4 = num;
					num = (short)1141038816;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_104;
					default:
						goto IL_13D;
					}
					break;
				}
				}
				IL_3D:
				if (this.IsScrollUsed)
				{
					num = (short)893124612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_182;
				IL_104:
				num = (short)1997668357;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C5:
			return this.m_ScrollRight;
			IL_13D:
			num = (short)586153984;
			if (num != 0)
			{
			}
			num = (short)585564161;
			if (num != 0)
			{
			}
			return this.m_ScrollLeft;
			IL_182:
			return base.GetVisualChild(index);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000B5D58 File Offset: 0x000B3F58
		private void DestroyScrollButtons()
		{
			short num = (short)1851787184;
			short num2 = num;
			num = (short)1414006704;
			switch (num2 == num)
			{
			}
			num = (short)957153281;
			if (num != 0)
			{
			}
			num = (short)856227840;
			short num3 = num;
			num = (short)1397030912;
			if (num != 0)
			{
			}
			this.m_HorizontalOffset = 0;
			this.RemoveButton(this.m_ScrollLeft);
			this.RemoveButton(this.m_ScrollRight);
			this.m_ScrollRight = null;
			this.m_ScrollLeft = null;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000B5E30 File Offset: 0x000B4030
		private void RemoveButton(global::System.Windows.Controls.Primitives.RepeatButton b)
		{
			short num = (short)2051932161;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)524550144;
				short num3 = num;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_14;
				case 2:
				{
					num = (short)2093088769;
					if (num != 0)
					{
					}
					num = (short)2141848974;
					short num4 = num;
					num = (short)391775630;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)2042036224;
						if (num != 0)
						{
						}
						base.RemoveLogicalChild(b);
						base.RemoveVisualChild(b);
						num = (short)1168769024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_59;
				IL_14:
				switch (0)
				{
				case 0:
					IL_59:
					if (b == null)
					{
						return;
					}
					num = (short)1013841922;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000B5F4C File Offset: 0x000B414C
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static global::DevComponents.WpfRibbon.eTabElementAlignment GetPanelAlignment(global::System.Windows.UIElement element)
		{
			int a_ = 8;
			if (element == null)
			{
				short num = (short)227737601;
				if (num != 0)
				{
				}
				num = (short)2099217141;
				short num2 = num;
				num = (short)112296693;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)733806592;
					if (num != 0)
					{
					}
					num = (short)2137784320;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("՟๡ţ୥", a_));
				}
				}
			}
			return (global::DevComponents.WpfRibbon.eTabElementAlignment)element.GetValue(global::DevComponents.WpfRibbon.RibbonTabPanel.PanelAlignmentProperty);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000B6028 File Offset: 0x000B4228
		public static void SetPanelAlignment(global::System.Windows.UIElement element, global::DevComponents.WpfRibbon.eTabElementAlignment part)
		{
			int a_ = 8;
			short num = (short)1393164289;
			if (num != 0)
			{
			}
			if (element == null)
			{
				num = (short)2087202688;
				short num2 = num;
				num = (short)894381952;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)214761472;
					if (num != 0)
					{
					}
					num = (short)1912799232;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("՟๡ţ୥", a_));
				}
				}
			}
			element.SetValue(global::DevComponents.WpfRibbon.RibbonTabPanel.PanelAlignmentProperty, part);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000B6108 File Offset: 0x000B4308
		private static void OnPanelAlignmentChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.UIElement uielement;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::DevComponents.WpfRibbon.RibbonTabPanel ribbonTabPanel;
					if (ribbonTabPanel != null)
					{
						goto IL_F2;
					}
					goto IL_10B;
				}
				case 1:
				{
					if (uielement == null)
					{
						goto IL_10B;
					}
					num2 = (short)219234294;
					short num3 = num2;
					num2 = (short)457916406;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F2;
					default:
						num2 = (short)12255232;
						if (num2 != 0)
						{
						}
						num2 = (short)694157315;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
				{
					global::DevComponents.WpfRibbon.RibbonTabPanel ribbonTabPanel;
					ribbonTabPanel.InvalidateArrange();
					num2 = (short)1570832388;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					global::DevComponents.WpfRibbon.RibbonTabPanel ribbonTabPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::DevComponents.WpfRibbon.RibbonTabPanel;
					num2 = (short)1004011520;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_C9;
				}
				goto IL_24;
				IL_F2:
				num2 = (short)1104543746;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_C9:
			IL_10B:
			num2 = (short)771031041;
			if (num2 != 0)
			{
			}
			num2 = (short)870121472;
			short num4 = num2;
			return;
			IL_24:
			uielement = (d as global::System.Windows.UIElement);
			num2 = (short)583532545;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000B6270 File Offset: 0x000B4470
		private static bool IsPanelAlignmentValid(object o)
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
				{
					global::DevComponents.WpfRibbon.eTabElementAlignment eTabElementAlignment;
					if (eTabElementAlignment != global::DevComponents.WpfRibbon.eTabElementAlignment.Right)
					{
						num2 = (short)431030273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 1:
					goto IL_102;
				case 2:
				{
					global::DevComponents.WpfRibbon.eTabElementAlignment eTabElementAlignment;
					if (eTabElementAlignment != global::DevComponents.WpfRibbon.eTabElementAlignment.Left)
					{
						num2 = (short)479330307;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 3:
					num2 = (short)268369920;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_102:
			num2 = (short)183500800;
			short num3 = num2;
			num2 = (short)15525490;
			short num4 = num2;
			num2 = (short)1975707250;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_20:
				num2 = (short)958332929;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfRibbon.eTabElementAlignment eTabElementAlignment = (global::DevComponents.WpfRibbon.eTabElementAlignment)o;
				num2 = (short)270401538;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)1311571968;
				if (num2 != 0)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000B63B0 File Offset: 0x000B45B0
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_9B;
			}
			short num;
			int num4;
			for (;;)
			{
				IL_13:
				num = (short)2063048502;
				short num2 = num;
				num = (short)1557307190;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)929759232;
					short num3 = num;
					num = (short)1373110272;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						return;
					case 1:
						if (!global::DevComponents.WpfRibbon.WinApi.KeyValidated)
						{
							num = (short)1160839170;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						global::System.Windows.Media.FormattedText formattedText = new global::System.Windows.Media.FormattedText(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⡣ཥ୧ཀྵɫᵭᕯ剱ᩳ᥵౷婹᩻ᅽꢅꢇ\ud989낏솟횡춣즥욧誩솫쮭쎯솱햳통\uddb7骹\udabb톽늿ꗃꗅ볇ꏉ뫋꿍꓏믑믓룕뻙맛ꫝ臟诡裣闥웧", a_), global::System.Globalization.CultureInfo.CurrentCulture, global::System.Windows.FlowDirection.LeftToRight, new global::System.Windows.Media.Typeface(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("╣ᑥŧ୩k", a_)), 9.0, global::System.Windows.Media.Brushes.Maroon);
						dc.DrawText(formattedText, new global::System.Windows.Point((base.RenderSize.Width - formattedText.Width) / 2.0, (base.RenderSize.Height - formattedText.Height) / 2.0));
						num = (short)2115829760;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_9B;
				}
				}
			}
			return;
			IL_9B:
			num = (short)1853161473;
			if (num != 0)
			{
			}
			base.OnRender(dc);
			num = (short)1479016449;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x0400069D RID: 1693
		public static readonly global::System.Windows.DependencyProperty PanelAlignmentProperty;

		// Token: 0x0400069E RID: 1694
		internal static readonly global::System.Windows.RoutedEvent TabsScrolledEvent;

		// Token: 0x0400069F RID: 1695
		private int m_TabsCount;

		// Token: 0x040006A0 RID: 1696
		private double m_TabsSize;

		// Token: 0x040006A1 RID: 1697
		private global::System.Windows.Controls.Primitives.RepeatButton m_ScrollLeft;

		// Token: 0x040006A2 RID: 1698
		private global::System.Windows.Controls.Primitives.RepeatButton m_ScrollRight;

		// Token: 0x040006A3 RID: 1699
		private double m_AvailableWidth;

		// Token: 0x040006A4 RID: 1700
		private int m_HorizontalOffset;

		// Token: 0x040006A5 RID: 1701
		private bool m_RaiseTabsScrolledEvent;
	}
}
