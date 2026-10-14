using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000074 RID: 116
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RibbonBarPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x00098E6C File Offset: 0x0009706C
		static RibbonBarPanel()
		{
			short num = (short)614137857;
			if (num != 0)
			{
			}
			num = (short)2072641536;
			short num2 = num;
			num = (short)408209960;
			short num3 = num;
			num = (short)1745406504;
			switch (num3 == num)
			{
			}
			num = (short)500563968;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00098F18 File Offset: 0x00097118
		protected override void OnInitialized(global::System.EventArgs e)
		{
			short num = (short)1803739795;
			short num2 = num;
			num = (short)320594579;
			switch (num2 == num)
			{
			default:
			{
				num = (short)111149056;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1428422657;
			if (num != 0)
			{
			}
			num = (short)294191104;
			if (num != 0)
			{
			}
			global::System.Windows.Input.KeyboardNavigation.SetTabNavigation(this, global::System.Windows.Input.KeyboardNavigationMode.Cycle);
			global::System.Windows.Input.KeyboardNavigation.SetDirectionalNavigation(this, global::System.Windows.Input.KeyboardNavigationMode.Cycle);
			base.OnInitialized(e);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00098FD4 File Offset: 0x000971D4
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)678494208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CB;
				}
				global::System.Windows.Size result;
				bool flag;
				double num5;
				global::System.Windows.Controls.UIElementCollection internalChildren;
				global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.RibbonBar> list;
				global::System.Collections.IEnumerator enumerator;
				global::System.Windows.Size availableSize2;
				for (;;)
				{
					IL_28:
					global::System.Windows.Size desiredSize;
					global::DevComponents.WpfRibbon.RibbonBar ribbonBar;
					int num8;
					switch (num2)
					{
					case 0:
					{
						num = (short)1044840448;
						short num3 = num;
						double num4;
						if (num4 >= 0.0)
						{
							num = (short)423624740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A79;
					}
					case 1:
						this.CreateScrollButtons();
						num = (short)2002583555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (result.Width > availableSize.Width)
						{
							num = (short)1852899329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.DestroyScrollButtons();
						num = (short)945618970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_326;
					case 4:
						if (flag)
						{
							num = (short)1030750245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_197;
					case 5:
					{
						double num4;
						num4 -= desiredSize.Width - ribbonBar.DesiredSize.Width;
						num = (short)68616213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(desiredSize.Width, ribbonBar.DesiredSize.Width))
						{
							num = (short)1897660421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9AE;
					case 7:
						if (ribbonBar.MeasureNeedCollapse)
						{
							num = (short)1290928162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EC;
					case 8:
					{
						double num4;
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(0.0, num4))
						{
							num = (short)589838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A79;
					}
					case 9:
						goto IL_92A;
					case 10:
						goto IL_A79;
					case 11:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(availableSize.Height))
						{
							num = (short)1944649759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B58;
					case 12:
					{
						double num4 = global::System.Math.Ceiling(num5 - availableSize.Width);
						num = (short)527761412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						this.m_CollapsedControls = new global::DevComponents.WpfRibbon.CollapsedRibbonBarControl[internalChildren.Count];
						int num6 = list.Count - 1;
						num = (short)1200750593;
						if (num != 0)
						{
						}
						num = (short)880803864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_32B;
					case 15:
					{
						double num4;
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(0.0, num4))
						{
							num = (short)314114081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92A;
					}
					case 16:
					{
						int num6;
						if (num6 < 0)
						{
							num = (short)1524236297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfRibbon.RibbonBar ribbonBar2 = list[num6];
						global::System.Windows.Size desiredSize2 = ribbonBar2.DesiredSize;
						global::DevComponents.WpfRibbon.CollapsedRibbonBarControl collapsedRibbonBarControl = this.CollapseRibbonBar(ribbonBar2);
						collapsedRibbonBarControl.Measure(availableSize);
						double num4;
						num4 -= desiredSize2.Width - collapsedRibbonBarControl.DesiredSize.Width;
						result.Width += collapsedRibbonBarControl.DesiredSize.Width - desiredSize2.Width;
						num = (short)672595983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_15A;
					case 18:
						try
						{
							num = (short)1494220811;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.UIElement uielement;
								global::System.Windows.Size desiredSize3;
								switch (num2)
								{
								case 0:
								{
									global::DevComponents.WpfRibbon.RibbonBar ribbonBar3;
									if (ribbonBar3 != null)
									{
										num = (short)1963393028;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_56F;
								}
								case 1:
								{
									global::DevComponents.WpfRibbon.RibbonBar ribbonBar3;
									if (ribbonBar3 != null)
									{
										num = (short)1459290119;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_650;
								}
								case 2:
									if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)1645477902;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									goto IL_633;
								case 4:
								{
									global::DevComponents.WpfRibbon.RibbonBar ribbonBar3;
									ribbonBar3.IsRibbonBarPanelMeasure = false;
									num = (short)529203210;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_650;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)268501001;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1295384578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::DevComponents.WpfRibbon.RibbonBar ribbonBar3;
									ribbonBar3.IsRibbonBarPanelMeasure = true;
									num = (short)536936453;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									result.Height = desiredSize3.Height;
									num = (short)2076901391;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)298254355;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									num = (short)1056190876;
									short num7 = num;
									num = (short)635449756;
									switch ((num7 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_633;
									default:
										num = (short)1644101632;
										if (num != 0)
										{
										}
										goto IL_56F;
									}
									break;
								}
								case 11:
									switch (0)
									{
									case 0:
										goto IL_4CB;
									}
									continue;
								case 12:
								{
									global::DevComponents.WpfRibbon.RibbonBar ribbonBar3;
									if (ribbonBar3 != null)
									{
										num = (short)2123563021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
								{
									global::DevComponents.WpfRibbon.RibbonBar ribbonBar3;
									list.Add(ribbonBar3);
									num = (short)2002911249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::DevComponents.WpfRibbon.RibbonBar ribbonBar3 = uielement as global::DevComponents.WpfRibbon.RibbonBar;
									num = (short)1335885825;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									goto IL_723;
								case 17:
								{
									global::DevComponents.WpfRibbon.RibbonBar ribbonBar3;
									if (ribbonBar3.ResizeOrderIndex != 0)
									{
										num = (short)1509097475;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 18:
									if (desiredSize3.Height > result.Height)
									{
										num = (short)1943273480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_723;
								case 19:
									goto IL_7DD;
								}
								goto IL_4CB;
								IL_56F:
								desiredSize3 = uielement.DesiredSize;
								num = (short)1778909202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_633:
								flag = true;
								num = (short)959643664;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_650:
								uielement.Measure(availableSize2);
								num = (short)1591738368;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_697:
								num = (short)1275854854;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4CB:
								goto IL_697;
								IL_723:
								result.Width += desiredSize3.Width + this.m_Spacing;
								num = (short)427687948;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7DD:
							goto IL_208;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_7FF;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_7EC:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1975320578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)1980497920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_859;
								case 2:
									goto IL_857;
								}
								goto IL_7FF;
							}
							IL_857:
							IL_859:
							goto EndFinally_25;
							IL_7FF:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1355546625;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_7EC;
							EndFinally_25:;
						}
						goto IL_85A;
						IL_208:
						num5 = result.Width;
						num = (short)100466715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						double num4;
						if (global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(num4, 0.0))
						{
							num = (short)1409482765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92A;
					}
					case 20:
						goto IL_B58;
					case 21:
						goto IL_9AE;
					case 22:
						goto IL_15A;
					case 23:
						goto IL_3EC;
					case 24:
						goto IL_971;
					case 25:
						goto IL_197;
					case 26:
						goto IL_3E7;
					case 27:
						if (num5 > availableSize.Width)
						{
							num = (short)819134476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92A;
					case 28:
						if (ribbonBar.IsAutoSizeEnabled)
						{
							num = (short)38535200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32B;
					case 29:
						if (!double.IsInfinity(availableSize.Height))
						{
							num = (short)84934694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B58;
					case 30:
						goto IL_971;
					case 31:
						result.Height = availableSize.Height;
						num = (short)1484455956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						ribbonBar.IsSecondMeasurePass = true;
						ribbonBar.IsRibbonBarPanelMeasure = true;
						desiredSize = ribbonBar.DesiredSize;
						global::System.Windows.Size lastPanelMeasureSize = ribbonBar.LastPanelMeasureSize;
						double num4;
						global::System.Windows.Size availableSize3 = new global::System.Windows.Size(global::System.Math.Max(24.0, desiredSize.Width - num4), desiredSize.Height);
						ribbonBar.Measure(availableSize3);
						num = (short)1873412103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						int num6;
						num6--;
						num = (short)623771678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
					{
						ribbonBar.MeasureNeedCollapse = false;
						global::System.Windows.Size lastPanelMeasureSize;
						ribbonBar.Measure(new global::System.Windows.Size(global::System.Math.Ceiling(ribbonBar.LastPanelMeasureSize.Width) + (desiredSize.Width - lastPanelMeasureSize.Width), availableSize2.Height));
						num = (short)2021261335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						if (num8 < 0)
						{
							num = (short)291176458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ribbonBar = list[num8];
						num = (short)2111569948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1607270408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_85A;
					case 38:
						num = (short)528678923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CB;
					IL_15A:
					num = (short)1946222627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_197:
					num8 = list.Count - 1;
					num = (short)892076049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32B:
					num8--;
					num = (short)1390411798;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EC:
					ribbonBar.IsSecondMeasurePass = false;
					ribbonBar.IsRibbonBarPanelMeasure = false;
					num = (short)692256774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_85A:
					list.Sort(new global::DevComponents.WpfRibbon.RibbonBarPanel.ResizeOrderComparer());
					num = (short)2069954585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_92A:
					num = (short)920387613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_971:
					num = (short)1573191696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9AE:
					result.Width += ribbonBar.DesiredSize.Width - desiredSize.Width;
					num = (short)1060175872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A79:
					num = (short)1124139027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B58:
					num = (short)1402929154;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_326:
				IL_3E7:
				this.MeasureScrollButtons(availableSize);
				this.m_AvailableWidth = availableSize.Width;
				return result;
				IL_CB:
				this.RestoreAllCollapsed();
				internalChildren = base.InternalChildren;
				result = default(global::System.Windows.Size);
				num5 = 0.0;
				list = new global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.RibbonBar>(internalChildren.Count);
				flag = false;
				availableSize2 = new global::System.Windows.Size(double.PositiveInfinity, availableSize.Height);
				enumerator = internalChildren.GetEnumerator();
				num = (short)726532114;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00099C60 File Offset: 0x00097E60
		private global::DevComponents.WpfRibbon.CollapsedRibbonBarControl CollapseRibbonBar(global::DevComponents.WpfRibbon.RibbonBar bar)
		{
			short num = (short)523600902;
			short num2 = num;
			num = (short)1206158342;
			switch (num2 == num)
			{
			}
			num = (short)1164836865;
			if (num != 0)
			{
			}
			num = (short)1471610880;
			short num3 = num;
			num = (short)1031798784;
			if (num != 0)
			{
			}
			bar.IsCollapsed = true;
			global::DevComponents.WpfRibbon.CollapsedRibbonBarControl collapsedRibbonBarControl = new global::DevComponents.WpfRibbon.CollapsedRibbonBarControl();
			global::DevComponents.WpfRibbon.CollapsedRibbonBarButton collapsedRibbonBarButton = collapsedRibbonBarControl.CreateButton();
			collapsedRibbonBarButton.Header = this.CreateCollapsedHeader(bar);
			collapsedRibbonBarButton.Image = bar.CollapsedImage;
			int num4 = base.InternalChildren.IndexOf(bar);
			this.m_CollapsedControls[num4] = collapsedRibbonBarControl;
			base.Children.Remove(bar);
			base.Children.Insert(num4, collapsedRibbonBarControl);
			collapsedRibbonBarButton.AttachedRibbonBar = bar;
			return collapsedRibbonBarControl;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00099D6C File Offset: 0x00097F6C
		public void RestoreAllCollapsed()
		{
			short num = (short)884539392;
			switch (num)
			{
			default:
			{
				num = (short)505348102;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfRibbon.CollapsedRibbonBarControl collapsedRibbonBarControl;
					global::DevComponents.WpfRibbon.CollapsedRibbonBarButton collapsedRibbonBarButton;
					global::DevComponents.WpfRibbon.RibbonBar attachedRibbonBar;
					int num3;
					int num4;
					global::DevComponents.WpfRibbon.CollapsedRibbonBarControl[] collapsedControls;
					global::DevComponents.WpfRibbon.CollapsedRibbonBarPanel collapsedRibbonBarPanel;
					switch (num2)
					{
					case 0:
						collapsedRibbonBarButton = (collapsedRibbonBarControl.Header as global::DevComponents.WpfRibbon.CollapsedRibbonBarButton);
						attachedRibbonBar = collapsedRibbonBarButton.AttachedRibbonBar;
						collapsedRibbonBarButton.AttachedRibbonBar = null;
						num = (short)518914055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_22E;
					case 2:
						if (num3 >= num4)
						{
							num = (short)575078403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collapsedRibbonBarControl = collapsedControls[num3];
						num = (short)737607681;
						if (num != 0)
						{
						}
						num = (short)107610124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						goto IL_D0;
					case 5:
						collapsedRibbonBarPanel.Children.Clear();
						num = (short)1611792388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 7:
						if (collapsedRibbonBarButton.IsPopupOpen)
						{
							num = (short)1865875464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_171;
					case 8:
						collapsedRibbonBarButton.IsPopupOpen = false;
						num = (short)818413582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)374179987;
						short num5 = num;
						num = (short)1545504915;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B3;
						default:
							num = (short)972685312;
							if (num != 0)
							{
							}
							goto IL_1E5;
						}
						break;
					}
					case 10:
						goto IL_A2;
					case 11:
						goto IL_22E;
					case 12:
						if (collapsedRibbonBarControl != null)
						{
							num = (short)1251278848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					case 13:
						if (collapsedRibbonBarPanel != null)
						{
							num = (short)1577713669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D0;
					case 14:
						goto IL_171;
					}
					IL_80:
					if (this.m_CollapsedControls == null)
					{
						num = (short)2024275978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B3;
					IL_D0:
					base.Children.Remove(collapsedRibbonBarControl);
					base.Children.Insert(num3, attachedRibbonBar);
					collapsedRibbonBarButton.Header = null;
					collapsedRibbonBarButton.Image = null;
					collapsedRibbonBarControl.Header = null;
					attachedRibbonBar.IsCollapsed = false;
					num = (short)228458505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_171:
					collapsedRibbonBarPanel = collapsedRibbonBarButton.CollapsedRibbonBarPanel;
					num = (short)407371789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B3:
					collapsedControls = this.m_CollapsedControls;
					num4 = collapsedControls.Length;
					this.m_CollapsedControls = null;
					num3 = 0;
					num = (short)744882187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E5:
					num3++;
					num = (short)1545928705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22E:
					num = (short)1697841154;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A2:
				num = (short)2118320128;
				short num6 = num;
				return;
			}
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0009A0D0 File Offset: 0x000982D0
		private object CreateCollapsedHeader(global::DevComponents.WpfRibbon.RibbonBar bar)
		{
			switch (0)
			{
			case 0:
				goto IL_5C;
			}
			int num;
			object obj;
			global::System.Windows.Controls.TextBlock textBlock;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return obj;
				case 1:
					goto IL_1F8;
				case 2:
					goto IL_24E;
				case 3:
					textBlock.Inlines.Add((global::System.Windows.UIElement)obj);
					num2 = (short)399573003;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!(obj is string))
					{
						num2 = (short)1811283974;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2F7;
				case 5:
					if (!(obj is global::System.Windows.Documents.Inline))
					{
						num2 = (short)443744264;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2F7;
				case 6:
					num2 = (short)1512701965;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)162201600;
					short num3 = num2;
					num2 = (short)2137522177;
					if (num2 != 0)
					{
					}
					textBlock.Inlines.Add((global::System.Windows.Documents.Inline)obj);
					num2 = (short)52297730;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					return obj;
				case 9:
				{
					if (obj != null)
					{
						num2 = (short)775421956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1147432225;
					short num4 = num2;
					num2 = (short)770600225;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9A;
					default:
						num2 = (short)1853358080;
						if (num2 != 0)
						{
						}
						num2 = (short)922091535;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					if (obj != null)
					{
						num2 = (short)691535872;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					obj = bar.Header;
					num2 = (short)473366537;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					return textBlock;
				case 12:
					if (obj is string)
					{
						num2 = (short)186253328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9A;
				case 13:
					if (!(obj is global::System.Windows.UIElement))
					{
						num2 = (short)1079967762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2F7;
				case 14:
					if (obj is global::System.Windows.UIElement)
					{
						num2 = (short)1789067267;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1551302673;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_1CA;
				case 16:
					textBlock.Inlines.Add((string)obj);
					num2 = (short)205717505;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (obj is global::System.Windows.Documents.Inline)
					{
						num2 = (short)1243611143;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return textBlock;
				case 18:
					num2 = (short)1893269509;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_5C;
				IL_9A:
				num2 = (short)1951465486;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2F7:
				textBlock = new global::System.Windows.Controls.TextBlock();
				textBlock.TextWrapping = global::System.Windows.TextWrapping.Wrap;
				num2 = (short)586743820;
				num = (int)((global::System.IntPtr)num2);
			}
			return obj;
			IL_1CA:
			return null;
			IL_1F8:
			IL_24E:
			return textBlock;
			IL_5C:
			obj = bar.CollapsedHeader;
			num2 = (short)1096155146;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0009A460 File Offset: 0x00098660
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)683802624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1900544000;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_A0;
				}
				int num4;
				int count;
				global::System.Windows.Controls.UIElementCollection internalChildren;
				double num6;
				for (;;)
				{
					IL_51:
					switch (num2)
					{
					case 0:
						return finalSize;
					case 1:
						if (this.m_CollapsedControls != null)
						{
							num = (short)1261109252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FB;
					case 2:
						goto IL_1C5;
					case 3:
					{
						global::System.Windows.UIElement uielement;
						if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)1016791057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_160;
					}
					case 4:
						num = (short)1101987856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_160;
					case 6:
					{
						global::System.Windows.UIElement uielement = this.m_CollapsedControls[num4];
						num = (short)1088028682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (this.m_ScrollLeft != null)
						{
							num = (short)39256077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C5;
					case 8:
						if (this.m_ScrollRight != null)
						{
							num = (short)164691982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 9:
						goto IL_3BD;
					case 10:
						num = (short)902496257;
						if (num != 0)
						{
						}
						goto IL_3FB;
					case 11:
					{
						if (num4 >= count)
						{
							num = (short)291307535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = internalChildren[num4];
						num = (short)1723662337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_3BD;
					case 13:
						this.m_ScrollLeft.Arrange(new global::System.Windows.Rect(0.0, 0.0, this.m_ScrollLeft.DesiredSize.Width, finalSize.Height));
						num = (short)1174929410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						this.m_ScrollRight.Arrange(new global::System.Windows.Rect(this.m_AvailableWidth - this.m_ScrollRight.DesiredSize.Width, 0.0, this.m_ScrollRight.DesiredSize.Width, finalSize.Height));
						num = (short)1786183680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						num = (short)464101614;
						short num5 = num;
						num = (short)1414439150;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C5;
						default:
							num = (short)295698432;
							if (num != 0)
							{
							}
							num = (short)1371996167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
						if (this.m_CollapsedControls[num4] != null)
						{
							num = (short)455081990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FB;
					case 17:
					{
						global::System.Windows.UIElement uielement;
						global::System.Windows.Size desiredSize = uielement.DesiredSize;
						uielement.Arrange(new global::System.Windows.Rect(num6, 0.0, desiredSize.Width, finalSize.Height));
						num6 += desiredSize.Width + this.m_Spacing;
						num = (short)1339686917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_A0;
					IL_160:
					num4++;
					num = (short)1079902220;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C5:
					num = (short)1053949960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BD:
					num = (short)506855435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FB:
					num = (short)1710096387;
					num2 = (int)((global::System.IntPtr)num);
				}
				return finalSize;
				IL_A0:
				internalChildren = base.InternalChildren;
				num6 = (double)this.m_HorizontalOffset;
				count = internalChildren.Count;
				num4 = 0;
				num = (short)498335753;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0009A8AC File Offset: 0x00098AAC
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			short num = (short)1462829056;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1163198465;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_74;
					}
					continue;
				case 1:
					num = (short)118751238;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.m_CollapsedControls != null)
					{
						num = (short)688324615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_162;
				case 3:
					goto IL_1E5;
				case 4:
					num = (short)1560674312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_15D;
				case 6:
					if (index == this.VisualChildrenCount - 1)
					{
						num = (short)1025703941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11C;
				case 7:
				{
					num = (short)294417862;
					short num3 = num;
					num = (short)1109947846;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1546059776;
						if (num != 0)
						{
						}
						num = (short)806486025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					if (index >= this.VisualChildrenCount - 2)
					{
						num = (short)955449345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_95;
				case 9:
					if (this.m_CollapsedControls[index] == null)
					{
						num = (short)703135747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_219;
				}
				IL_74:
				if (this.IsScrollUsed)
				{
					num = (short)1506607108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_95:
				num = (short)188874754;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11C:
			return this.m_ScrollLeft;
			IL_15D:
			return this.m_ScrollRight;
			IL_162:
			return base.GetVisualChild(index);
			IL_1E5:
			num = (short)292028416;
			short num4 = num;
			goto IL_162;
			IL_219:
			return this.m_CollapsedControls[index];
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0009AADC File Offset: 0x00098CDC
		internal bool FocusFirstRibbonBar()
		{
			short num;
			for (;;)
			{
				num = (short)901578752;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)834215833;
					short num3 = num;
					num = (short)1875386265;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_54;
					}
					break;
				}
				}
			}
			IL_54:
			num = (short)1987182592;
			if (num != 0)
			{
			}
			global::System.Collections.IEnumerator enumerator = base.Children.GetEnumerator();
			bool result;
			try
			{
				num = (short)211156994;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)929300488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
						num = (short)559742982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Windows.UIElement uielement;
						result = global::DevComponents.WpfRibbon.FocusHelpers.FocusFirstChild(uielement as global::DevComponents.WpfRibbon.RibbonBar);
						num = (short)1348206601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_FA;
						}
						continue;
					case 3:
						goto IL_26D;
					case 4:
						num = (short)379650059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_11B;
					case 6:
					{
						global::System.Windows.UIElement uielement;
						if (uielement.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)2026373124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						num = (short)497090570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1820393475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_18C;
					case 10:
					{
						global::System.Windows.UIElement uielement;
						if (uielement is global::DevComponents.WpfRibbon.RibbonBar)
						{
							num = (short)1823866881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = uielement.Focus();
						num = (short)861667333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::System.Windows.UIElement uielement;
						if (uielement.Focusable)
						{
							num = (short)1469120519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_191:
					num = (short)1037959168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FA:
					goto IL_191;
				}
				IL_11B:
				IL_18C:
				goto IL_2E5;
				IL_26D:
				goto IL_77;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_28F;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_27C:
					switch (num2)
					{
					case 0:
						if (disposable != null)
						{
							num = (short)1784610817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E4;
					case 1:
						disposable.Dispose();
						num = (short)2009268226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2E2;
					}
					goto IL_28F;
				}
				IL_2E2:
				IL_2E4:
				goto EndFinally_7;
				IL_28F:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)578617344;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27C;
				EndFinally_7:;
			}
			goto IL_2E5;
			IL_77:
			num = (short)1120534528;
			short num4 = num;
			return false;
			IL_2E5:
			num = (short)48955393;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0009AE14 File Offset: 0x00099014
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1812463616;
			short num2 = num;
			num = (short)120998840;
			short num3 = num;
			num = (short)759909304;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_22B:
				num = (short)2009464834;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)49086464;
				if (num != 0)
				{
				}
				num = (short)1923350528;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					num = (short)1713766401;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_CA;
					}
					continue;
				case 1:
					goto IL_EF;
				case 2:
					goto IL_243;
				}
				IL_CA:
				if (e.Property != global::DevComponents.WpfRibbon.RibbonTab.TabColorProperty)
				{
					goto IL_248;
				}
				num = (short)1374420993;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_EF:
			IL_21F:
			global::System.Collections.IEnumerator enumerator = base.Children.GetEnumerator();
			goto IL_22B;
			IL_243:
			try
			{
				num = (short)1448738816;
				num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_12C;
						}
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1597898755;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfRibbon.RibbonTab.SetTabColor((global::System.Windows.UIElement)enumerator.Current, (global::DevComponents.WpfRibbon.eRibbonTabColor)e.NewValue);
						num = (short)1190723585;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)797376516;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1AA;
					}
					IL_12E:
					num = (short)1820196866;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_12C:
					goto IL_12E;
				}
				IL_1AA:
				goto IL_248;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_1CB;
				}
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_1B9:
					switch (num4)
					{
					case 0:
						if (disposable != null)
						{
							num = (short)375324673;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 1:
						disposable.Dispose();
						num = (short)229834754;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_21C;
					}
					goto IL_1CB;
				}
				IL_21C:
				IL_21E:
				goto EndFinally_6;
				IL_1CB:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1695809536;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_1B9;
				EndFinally_6:;
			}
			goto IL_21F;
			IL_248:
			base.OnPropertyChanged(e);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0009B080 File Offset: 0x00099280
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1724186624;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						if (this.IsScrollUsed)
						{
							num = (short)209911809;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						num = (short)1245380609;
						if (num != 0)
						{
						}
						this.UpdateScrollButtonVisibility();
						num = (short)433351308;
						short num4 = num;
						num = (short)703556236;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)41811968;
							if (num != 0)
							{
							}
							num = (short)993198082;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						return;
					}
					break;
				}
				IL_45:
				base.OnRenderSizeChanged(sizeInfo);
				num = (short)683409408;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0009B1A0 File Offset: 0x000993A0
		private void MeasureScrollButtons(global::System.Windows.Size availableSize)
		{
			short num;
			for (;;)
			{
				num = (short)218300416;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)196411393;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 1:
						goto IL_F7;
					case 2:
						goto IL_A6;
					case 3:
						this.m_ScrollLeft.Measure(availableSize);
						num = (short)1387986945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.m_ScrollRight != null)
						{
							num = (short)1094254592;
							short num3 = num;
							num = (short)867958789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						this.m_ScrollRight.Measure(availableSize);
						num = (short)1474035714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_62:
					if (this.m_ScrollLeft != null)
					{
						num = (short)2043281411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_F7:
					num = (short)597295108;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A6:
				num = (short)1346782440;
				short num4 = num;
				num = (short)1625507048;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_DC;
				}
			}
			IL_DC:
			num = (short)1332871168;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0009B334 File Offset: 0x00099534
		private void CreateScrollButtons()
		{
			int a_ = 0;
			short num;
			while (this.m_ScrollLeft != null)
			{
				num = (short)55634423;
				short num2 = num;
				num = (short)1870850551;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1635057664;
					if (num != 0)
					{
					}
					num = (short)1169162240;
					short num3 = num;
					return;
				}
				}
			}
			num = (short)1308753921;
			if (num != 0)
			{
			}
			this.m_ScrollLeft = new global::System.Windows.Controls.Primitives.RepeatButton();
			this.m_ScrollLeft.Style = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("੗㍙㹛㱝ཟౡ㝣եᩧթkɭ㉯ݱsɵ᝷ᑹ", a_))) as global::System.Windows.Style);
			this.m_ScrollLeft.Tag = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᑗ㽙㩛⩝㍟šᙣ॥ѧ٩", a_);
			this.m_ScrollLeft.Click += this.ScrollLeft_Click;
			this.m_ScrollLeft.Visibility = global::System.Windows.Visibility.Collapsed;
			base.AddLogicalChild(this.m_ScrollLeft);
			base.AddVisualChild(this.m_ScrollLeft);
			this.m_ScrollRight = new global::System.Windows.Controls.Primitives.RepeatButton();
			this.m_ScrollRight.Style = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("੗㍙㹛㱝ཟౡ㝣եᩧթkɭ㉯ݱsɵ᝷ᑹ", a_))) as global::System.Windows.Style);
			this.m_ScrollRight.Click += this.ScrollRight_Click;
			base.AddLogicalChild(this.m_ScrollRight);
			base.AddVisualChild(this.m_ScrollRight);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0009B4F0 File Offset: 0x000996F0
		private void ScrollRight_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2081095680;
			short num2 = num;
			num = (short)1136328705;
			if (num != 0)
			{
			}
			num = (short)167245621;
			short num3 = num;
			num = (short)1851389749;
			switch (num3 == num)
			{
			}
			num = (short)1814626304;
			if (num != 0)
			{
			}
			this.SetScrollOffset(-(int)global::System.Math.Ceiling(global::System.Math.Min(base.DesiredSize.Width, base.RenderSize.Width - (base.DesiredSize.Width + (double)this.m_HorizontalOffset))));
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0009B5E4 File Offset: 0x000997E4
		private void ScrollLeft_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)748093440;
			short num2 = num;
			num = (short)77348983;
			short num3 = num;
			num = (short)104743031;
			switch (num3 == num)
			{
			}
			num = (short)1795162113;
			if (num != 0)
			{
			}
			num = (short)275251200;
			if (num != 0)
			{
			}
			this.SetScrollOffset((int)global::System.Math.Min((double)global::System.Math.Abs(this.m_HorizontalOffset), base.RenderSize.Width));
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0009B6B8 File Offset: 0x000998B8
		private void SetScrollOffset(int offset)
		{
			short num = (short)733085696;
			short num2 = num;
			num = (short)725597553;
			short num3 = num;
			num = (short)1769717105;
			switch (num3 == num)
			{
			}
			num = (short)1558839297;
			if (num != 0)
			{
			}
			num = (short)366280704;
			if (num != 0)
			{
			}
			this.m_HorizontalOffset += offset;
			base.InvalidateArrange();
			this.UpdateScrollButtonVisibility();
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0009B77C File Offset: 0x0009997C
		private void UpdateScrollButtonVisibility()
		{
			short num = (short)28442625;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Size size;
				switch (num2)
				{
				case 0:
					if (this.m_HorizontalOffset != 0)
					{
						num = (short)696320007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E5;
				case 1:
					IL_14:
					num = (short)1002897409;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					continue;
				case 2:
					num = (short)864092160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_8B;
				case 4:
					goto IL_E0;
				case 5:
				{
					double num3 = size.Width + (double)this.m_HorizontalOffset;
					size = base.DesiredSize;
					if (num3 <= size.Width)
					{
						num = (short)551288836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F5;
				}
				case 6:
					goto IL_8B;
				case 7:
				{
					this.m_ScrollLeft.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)1235156992;
					short num4 = num;
					num = (short)143196163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_6A:
				if (this.m_ScrollLeft != null)
				{
					num = (short)1106771970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_E5;
				IL_8B:
				size = base.RenderSize;
				num = (short)811925509;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E5:
				num = (short)684711707;
				short num5 = num;
				num = (short)1335484187;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14;
				default:
					num = (short)1999831040;
					if (num != 0)
					{
					}
					this.m_ScrollLeft.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)2009202694;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E0:
			this.m_ScrollRight.Visibility = global::System.Windows.Visibility.Collapsed;
			return;
			IL_1F5:
			this.m_ScrollRight.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0009B98C File Offset: 0x00099B8C
		private bool IsScrollUsed
		{
			get
			{
				short num = (short)741015552;
				short num2 = num;
				num = (short)337460677;
				short num3 = num;
				num = (short)840515013;
				switch (num3 == num)
				{
				}
				num = (short)761593857;
				if (num != 0)
				{
				}
				num = (short)1904869376;
				if (num != 0)
				{
				}
				return this.m_ScrollLeft != null;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0009BA40 File Offset: 0x00099C40
		protected override int VisualChildrenCount
		{
			get
			{
				short num;
				int num4;
				for (;;)
				{
					IL_00:
					num = (short)2126381056;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					int num3;
					for (;;)
					{
						IL_34:
						switch (num3)
						{
						case 0:
							if (this.IsScrollUsed)
							{
								num = (short)2000617473;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return num4;
						case 1:
						{
							num4 += 2;
							num = (short)341125715;
							short num5 = num;
							num = (short)732179027;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1799094272;
								if (num != 0)
								{
								}
								num = (short)2118057986;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_EC;
						}
						break;
					}
					IL_46:
					num4 = base.VisualChildrenCount;
					num = (short)224460800;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_34;
				}
				IL_EC:
				num = (short)1261764609;
				if (num != 0)
				{
				}
				return num4;
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0009BB68 File Offset: 0x00099D68
		private void DestroyScrollButtons()
		{
			short num = (short)1848573952;
			short num2 = num;
			num = (short)49731619;
			short num3 = num;
			num = (short)2059065379;
			switch (num3 == num)
			{
			}
			num = (short)246415360;
			if (num != 0)
			{
			}
			num = (short)413728769;
			if (num != 0)
			{
			}
			this.m_HorizontalOffset = 0;
			this.RemoveButton(this.m_ScrollLeft);
			this.RemoveButton(this.m_ScrollRight);
			this.m_ScrollRight = null;
			this.m_ScrollLeft = null;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0009BC40 File Offset: 0x00099E40
		private void RemoveButton(global::System.Windows.Controls.Primitives.RepeatButton b)
		{
			short num = (short)1136066560;
			short num2 = num;
			num = (short)655021792;
			short num3 = num;
			num = (short)1913640672;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F6:
				num = (short)369360898;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)654508032;
				if (num != 0)
				{
				}
				num = (short)853671936;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					num = (short)1581580289;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					continue;
				case 1:
					goto IL_E6;
				case 2:
					return;
				}
				IL_CD:
				if (b == null)
				{
					return;
				}
				num = (short)1867776001;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_E6:
			base.RemoveLogicalChild(b);
			base.RemoveVisualChild(b);
			goto IL_F6;
		}

		// Token: 0x04000334 RID: 820
		private global::DevComponents.WpfRibbon.CollapsedRibbonBarControl[] m_CollapsedControls;

		// Token: 0x04000335 RID: 821
		private global::System.Windows.Controls.Primitives.RepeatButton m_ScrollLeft;

		// Token: 0x04000336 RID: 822
		private global::System.Windows.Controls.Primitives.RepeatButton m_ScrollRight;

		// Token: 0x04000337 RID: 823
		private double m_AvailableWidth;

		// Token: 0x04000338 RID: 824
		private int m_HorizontalOffset;

		// Token: 0x04000339 RID: 825
		private double m_Spacing = 2.0;

		// Token: 0x02000075 RID: 117
		private class ResizeOrderComparer : global::System.Collections.Generic.IComparer<global::DevComponents.WpfRibbon.RibbonBar>
		{
			// Token: 0x060006E9 RID: 1769 RVA: 0x0009BD80 File Offset: 0x00099F80
			public int Compare(global::DevComponents.WpfRibbon.RibbonBar x, global::DevComponents.WpfRibbon.RibbonBar y)
			{
				short num = (short)1588789248;
				short num2 = num;
				num = (short)313446936;
				short num3 = num;
				num = (short)850579992;
				switch (num3 == num)
				{
				}
				num = (short)944373760;
				if (num != 0)
				{
				}
				num = (short)476250113;
				if (num != 0)
				{
				}
				return x.ResizeOrderIndex - y.ResizeOrderIndex;
			}
		}
	}
}
