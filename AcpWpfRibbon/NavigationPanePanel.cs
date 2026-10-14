using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000067 RID: 103
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class NavigationPanePanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x00066EAC File Offset: 0x000650AC
		static NavigationPanePanel()
		{
			int a_ = 7;
			short num = (short)317370209;
			short num2 = num;
			num = (short)1458417505;
			switch (num2 == num)
			{
			}
			num = (short)336986113;
			if (num != 0)
			{
			}
			num = (short)170590208;
			if (num != 0)
			{
			}
			num = (short)1722613760;
			short num3 = num;
			global::DevComponents.WpfRibbon.NavigationPanePanel.LargeItemsCountProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("፞`ᅢɤɦ⁨Ὢ࡬ɮɰひᩴɶ᝸ེ", a_), typeof(int), typeof(global::DevComponents.WpfRibbon.NavigationPanePanel), new global::System.Windows.FrameworkPropertyMetadata(3, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange));
			global::DevComponents.WpfRibbon.NavigationPanePanel.EnableCustomizationProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩞའɢݤ୦౨⡪ᡬᱮհᱲᡴṶ͸᩺ॼᙾ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.NavigationPanePanel), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
			global::DevComponents.WpfRibbon.NavigationPanePanel.SmallItemsHeightProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("౞ౠɢ।୦⁨Ὢ࡬ɮɰ㭲ၴṶṸ፺ॼ", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.NavigationPanePanel), new global::System.Windows.FrameworkPropertyMetadata(30.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange));
			global::DevComponents.WpfRibbon.NavigationPanePanel.SmallItemsBackgroundProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("౞ౠɢ।୦⁨Ὢ࡬ɮɰㅲᑴᑶቸᱺོၾ", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.NavigationPanePanel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.NavigationPanePanel.PaneExpandedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ཞ`ൢd≦ᅨ᭪౬Ůᕰᙲᅴ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.NavigationPanePanel), new global::System.Windows.FrameworkPropertyMetadata(true));
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0006707C File Offset: 0x0006527C
		public NavigationPanePanel()
		{
			base.ClipToBounds = true;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00067098 File Offset: 0x00065298
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)1626406912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1061093381;
				num2 = (int)((global::System.IntPtr)num);
				double num3;
				global::System.Windows.Size result;
				for (;;)
				{
					global::System.Windows.Size availableSize2;
					global::System.Collections.IEnumerator enumerator;
					global::System.Windows.Size availableSize3;
					int num5;
					bool paneExpanded;
					switch (num2)
					{
					case 0:
					{
						global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton navigationPaneCustomize = this.GetNavigationPaneCustomize();
						navigationPaneCustomize.Measure(new global::System.Windows.Size(availableSize2.Width, this.SmallItemsHeight));
						num3 += navigationPaneCustomize.DesiredSize.Width;
						num = (short)1223426050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (num3 > result.Width)
						{
							num = (short)1230831624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_580;
					case 2:
						goto IL_F2;
					case 3:
					{
						num = (short)1573505513;
						short num4 = num;
						num = (short)1317784041;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_580;
						default:
							num = (short)111411200;
							if (num != 0)
							{
							}
							goto IL_F2;
						}
						break;
					}
					case 4:
						try
						{
							num = (short)1480851457;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)177405955;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1159331844;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_28A;
									}
									continue;
								case 2:
									goto IL_443;
								case 3:
									num = (short)1582301186;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Windows.UIElement uielement;
									if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)301662219;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::System.Windows.UIElement uielement;
									num3 += global::System.Math.Ceiling(uielement.DesiredSize.Width);
									num = (short)873398281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::System.Windows.UIElement uielement;
									uielement.Measure(availableSize3);
									num = (short)1813250056;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									if (num5 == 0)
									{
										num = (short)2117730310;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement;
									uielement.Measure(availableSize2);
									global::System.Windows.Size desiredSize = uielement.DesiredSize;
									num5--;
									result.Height += desiredSize.Height;
									result.Width = global::System.Math.Max(result.Width, global::System.Math.Ceiling(desiredSize.Width));
									num = (short)81920010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									if (paneExpanded)
									{
										num = (short)1052180485;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 11:
									num = (short)159318023;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3EB:
								num = (short)1648164864;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_28A:
								goto IL_3EB;
							}
							IL_443:
							goto IL_4D5;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_465;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_452:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)343539714;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4BF;
								case 1:
									goto IL_4BD;
								case 2:
									disposable.Dispose();
									num = (short)860356609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_465;
							}
							IL_4BD:
							IL_4BF:
							goto EndFinally_12;
							IL_465:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1972502528;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_452;
							EndFinally_12:;
						}
						goto IL_4C0;
						IL_4D5:
						num = (short)297533447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					case 6:
						goto IL_22E;
					case 7:
						if (this.EnableCustomization)
						{
							num = (short)1428946944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.DestroyNavigationPaneCustomize();
						num = (short)801570819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)524288000;
						short num6 = num;
						num3 = result.Width;
						num = (short)1204420614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_69;
					IL_F2:
					num = (short)540803073;
					if (num != 0)
					{
					}
					num = (short)990380033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_518:
					availableSize3 = new global::System.Windows.Size(availableSize2.Width, this.SmallItemsHeight);
					result = new global::System.Windows.Size(0.0, this.SmallItemsHeight);
					num5 = this.LargeItemsCount;
					num3 = 0.0;
					paneExpanded = this.PaneExpanded;
					global::System.Windows.Controls.UIElementCollection internalChildren;
					enumerator = internalChildren.GetEnumerator();
					num = (short)1474428932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C0:
					availableSize2.Height = global::System.Math.Ceiling(availableSize2.Height);
					goto IL_518;
					IL_69:
					internalChildren = base.InternalChildren;
					availableSize2 = availableSize;
					if (availableSize2.Width != double.PositiveInfinity)
					{
						availableSize2.Width = global::System.Math.Ceiling(availableSize2.Width);
					}
					if (availableSize2.Height != double.PositiveInfinity)
					{
						goto IL_4C0;
					}
					goto IL_518;
				}
				IL_22E:
				IL_580:
				result.Width = global::System.Math.Max(result.Width, num3);
				return result;
			}
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00067658 File Offset: 0x00065858
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)861798400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B3;
				}
				bool paneExpanded;
				double smallItemsHeight;
				double num4;
				int num5;
				global::System.Windows.Point location;
				global::System.Windows.Controls.UIElementCollection internalChildren;
				global::System.Windows.Point location2;
				for (;;)
				{
					IL_28:
					global::System.Windows.UIElement uielement;
					double num3;
					int num7;
					double num8;
					bool flag;
					int num10;
					switch (num2)
					{
					case 0:
						if (paneExpanded)
						{
							num = (short)1251278871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement.Arrange(new global::System.Windows.Rect(-1000.0, 0.0, uielement.DesiredSize.Width, smallItemsHeight));
						num = (short)1284898827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_430;
					case 2:
					{
						global::System.Windows.UIElement uielement2;
						if (num3 + uielement2.DesiredSize.Width <= num4)
						{
							num = (short)7077912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D4;
					}
					case 3:
						num = (short)1413939201;
						if (num != 0)
						{
						}
						num = (short)63045637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_5E2;
					case 5:
					{
						if (num5 != 0)
						{
							num5--;
							num = (short)1893859349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)754782302;
						short num6 = num;
						num = (short)1489375326;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return finalSize;
						default:
							num = (short)657326080;
							if (num != 0)
							{
							}
							num = (short)401145886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						num = (short)1022033949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton navigationPaneCustomize = this.GetNavigationPaneCustomize();
						navigationPaneCustomize.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(finalSize.Width - navigationPaneCustomize.DesiredSize.Width, location.Y), new global::System.Windows.Size(navigationPaneCustomize.DesiredSize.Width, smallItemsHeight)));
						num4 -= navigationPaneCustomize.DesiredSize.Width;
						num = (short)2033778697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_473;
					case 9:
						goto IL_70B;
					case 10:
						goto IL_2C6;
					case 11:
						goto IL_324;
					case 12:
						num = (short)1429995535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (num7 >= internalChildren.Count)
						{
							num = (short)102236188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement = internalChildren[num7];
						num = (short)1024262163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (this.EnableCustomization)
						{
							num = (short)1615593479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_70B;
					case 15:
						if (num8 + uielement.DesiredSize.Width > num4)
						{
							num = (short)486146058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement.Arrange(new global::System.Windows.Rect(location, new global::System.Windows.Size(uielement.DesiredSize.Width, smallItemsHeight)));
						location.X += uielement.DesiredSize.Width;
						num8 += uielement.DesiredSize.Width;
						num = (short)1646329883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)71434240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_5E2;
					case 18:
						if (!flag)
						{
							num = (short)964231180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C6;
					case 19:
						if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)2134966278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					case 20:
						goto IL_6D4;
					case 21:
						goto IL_473;
					case 22:
					{
						global::System.Windows.UIElement uielement2;
						if (uielement2.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)162988035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_473;
					}
					case 23:
					{
						num = (short)1184825344;
						short num9 = num;
						num = (short)92995602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						global::System.Windows.UIElement uielement2;
						num3 += uielement2.DesiredSize.Width;
						num = (short)2072903688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_324;
					case 26:
						goto IL_430;
					case 27:
						goto IL_324;
					case 28:
						return finalSize;
					case 29:
						if (num5 == 0)
						{
							num = (short)1751515152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement.Arrange(new global::System.Windows.Rect(location2, new global::System.Windows.Size(finalSize.Width, uielement.DesiredSize.Height)));
						location2.Y += uielement.DesiredSize.Height;
						num5--;
						num = (short)1430519833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)117309442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						if (num10 >= internalChildren.Count)
						{
							num = (short)258015252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement2 = internalChildren[num10];
						num = (short)200802326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						goto IL_324;
					}
					goto IL_B3;
					IL_2C6:
					uielement.Arrange(new global::System.Windows.Rect(-1000.0, 0.0, uielement.DesiredSize.Width, uielement.DesiredSize.Height));
					flag = true;
					num = (short)974716960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_324:
					num7++;
					num = (short)1948647450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_430:
					num = (short)810418189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_473:
					num10++;
					num = (short)1859584004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E2:
					num = (short)262799391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D4:
					location.X = num4 - num3;
					flag = false;
					num5 = this.LargeItemsCount;
					num7 = 0;
					num = (short)1071513601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_70B:
					num8 = 0.0;
					num3 = num8;
					num10 = 0;
					num = (short)1288372241;
					num2 = (int)((global::System.IntPtr)num);
				}
				return finalSize;
				IL_B3:
				internalChildren = base.InternalChildren;
				num5 = this.LargeItemsCount;
				smallItemsHeight = this.SmallItemsHeight;
				location = new global::System.Windows.Point(finalSize.Width, finalSize.Height - smallItemsHeight);
				location2 = new global::System.Windows.Point(0.0, 0.0);
				paneExpanded = this.PaneExpanded;
				num4 = finalSize.Width;
				num = (short)993853454;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00067E08 File Offset: 0x00066008
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public int VisiblePaneItemCount
		{
			get
			{
				int num = 0;
				global::System.Collections.IEnumerator enumerator = base.Children.GetEnumerator();
				short num2;
				try
				{
					num2 = (short)919797761;
					int num3 = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num++;
							num2 = (short)234422276;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_51;
							}
							continue;
						case 2:
						{
							if (enumerator.MoveNext())
							{
								num2 = (short)773521414;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1484230323;
							short num4 = num2;
							num2 = (short)537104051;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7A;
							default:
								num2 = (short)801767424;
								if (num2 != 0)
								{
								}
								num2 = (short)782106627;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 3:
							num2 = (short)1626210309;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 5:
							goto IL_150;
						case 6:
							if (((global::System.Windows.UIElement)enumerator.Current).Visibility == global::System.Windows.Visibility.Visible)
							{
								goto IL_7A;
							}
							break;
						}
						goto IL_51;
						IL_7A:
						num2 = (short)1167065088;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_94:
						num2 = (short)2144993282;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_51:
						goto IL_94;
					}
					IL_150:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_16E;
					}
					int num3;
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_15C:
						switch (num3)
						{
						case 0:
							disposable.Dispose();
							num2 = (short)742719489;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_1BF;
						case 2:
							if (disposable != null)
							{
								num2 = (short)1543045120;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_1C1;
						}
						goto IL_16E;
					}
					IL_1BF:
					IL_1C1:
					goto EndFinally_5;
					IL_16E:
					disposable = (enumerator as global::System.IDisposable);
					num2 = (short)402784258;
					num3 = (int)((global::System.IntPtr)num2);
					goto IL_15C;
					EndFinally_5:;
				}
				num2 = (short)102301696;
				short num5 = num2;
				num2 = (short)574816257;
				if (num2 != 0)
				{
				}
				return num;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00068048 File Offset: 0x00066248
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::System.Windows.UIElement FirstVisible
		{
			get
			{
				short num = (short)1272774656;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)933494784;
					short num3 = num;
					num = (short)1844707329;
					if (num != 0)
					{
					}
					global::System.Collections.IEnumerator enumerator = base.Children.GetEnumerator();
					global::System.Windows.UIElement result;
					try
					{
						num = (short)1558183937;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)1426323814;
								short num4 = num;
								num = (short)1504311654;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_DF;
								default:
									num = (short)1971912704;
									if (num != 0)
									{
									}
									num = (short)2012807173;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_C0;
								}
								continue;
							case 2:
							{
								global::System.Windows.UIElement uielement;
								if (uielement.Visibility == global::System.Windows.Visibility.Visible)
								{
									num = (short)625410051;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								global::System.Windows.UIElement uielement;
								result = uielement;
								num = (short)629735428;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_1A8;
							case 5:
								goto IL_1C5;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									goto IL_DF;
								}
								global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
								num = (short)228392962;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_C2:
							num = (short)623050758;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C0:
							goto IL_C2;
							IL_DF:
							num = (short)1686568960;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1A8:
						return result;
						IL_1C5:
						goto IL_7C;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1E7;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1D4:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)190971905;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_239;
							case 2:
								if (disposable != null)
								{
									num = (short)1368522752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_23B;
							}
							goto IL_1E7;
						}
						IL_239:
						IL_23B:
						goto EndFinally_5;
						IL_1E7:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)2004090882;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1D4;
						EndFinally_5:;
					}
					return result;
					IL_7C:
					return null;
				}
				}
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000682B0 File Offset: 0x000664B0
		private global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton GetNavigationPaneCustomize()
		{
			int a_ = 7;
			short num = (short)188153858;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					for (;;)
					{
						global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton navigationPaneCustomizeButton = new global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton();
						navigationPaneCustomizeButton.Content = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᱞ", a_);
						base.AddLogicalChild(navigationPaneCustomizeButton);
						base.AddVisualChild(navigationPaneCustomizeButton);
						this._CustomizeButton = navigationPaneCustomizeButton;
						num = (short)1041806495;
						short num3 = num;
						num = (short)701543583;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_BF;
						}
					}
					IL_BF:
					num = (short)630128641;
					if (num != 0)
					{
					}
					num = (short)638779392;
					short num4 = num;
					num = (short)1483407360;
					if (num != 0)
					{
					}
					num = (short)286720001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_13D;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (this._CustomizeButton != null)
				{
					break;
				}
				num = (short)1498546176;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_13D:
			return this._CustomizeButton;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00068404 File Offset: 0x00066604
		private void DestroyNavigationPaneCustomize()
		{
			global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton customizeButton = this._CustomizeButton;
			short num;
			if (customizeButton == null)
			{
				num = (short)967105013;
				short num2 = num;
				num = (short)1539103221;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1326841856;
					short num3 = num;
					num = (short)2082209792;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			num = (short)3276801;
			if (num != 0)
			{
			}
			this._CustomizeButton = null;
			base.RemoveLogicalChild(customizeButton);
			base.RemoveVisualChild(customizeButton);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x000684D0 File Offset: 0x000666D0
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00068588 File Offset: 0x00066788
		[global::System.ComponentModel.Bindable(true)]
		public double SmallItemsHeight
		{
			get
			{
				short num = (short)311363221;
				short num2 = num;
				num = (short)2034108053;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1212022784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1707147265;
				if (num != 0)
				{
				}
				num = (short)1145176064;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.NavigationPanePanel.SmallItemsHeightProperty);
			}
			set
			{
				short num = (short)1582847094;
				short num2 = num;
				num = (short)1795183734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)71172096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)14417920;
				if (num != 0)
				{
				}
				num = (short)476708865;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPanePanel.SmallItemsHeightProperty, value);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00068644 File Offset: 0x00066844
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00068700 File Offset: 0x00066900
		[global::System.ComponentModel.Bindable(true)]
		public int LargeItemsCount
		{
			get
			{
				short num = (short)839287077;
				short num2 = num;
				num = (short)2002092325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)764674048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1575354369;
				if (num != 0)
				{
				}
				num = (short)1920991232;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::DevComponents.WpfRibbon.NavigationPanePanel.LargeItemsCountProperty);
			}
			set
			{
				short num = (short)15617968;
				short num2 = num;
				num = (short)664227760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1091960832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1214382081;
				if (num != 0)
				{
				}
				num = (short)1760231424;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPanePanel.LargeItemsCountProperty, value);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x000687BC File Offset: 0x000669BC
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00068874 File Offset: 0x00066A74
		[global::System.ComponentModel.Bindable(true)]
		public bool EnableCustomization
		{
			get
			{
				short num = (short)1371340801;
				if (num != 0)
				{
				}
				num = (short)1018691584;
				short num2 = num;
				num = (short)1284400078;
				short num3 = num;
				num = (short)570385358;
				switch (num3 == num)
				{
				}
				num = (short)1697644544;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.NavigationPanePanel.EnableCustomizationProperty);
			}
			set
			{
				short num = (short)496175853;
				short num2 = num;
				num = (short)1536166637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)451411968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1287782401;
				if (num != 0)
				{
				}
				num = (short)1208811520;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPanePanel.EnableCustomizationProperty, value);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00068930 File Offset: 0x00066B30
		protected override int VisualChildrenCount
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				int num4;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						for (;;)
						{
							num2 = (short)1046282240;
							short num3 = num2;
							num2 = (short)278462465;
							if (num2 != 0)
							{
							}
							num4++;
							num2 = (short)1932942788;
							short num5 = num2;
							num2 = (short)798973380;
							switch ((num5 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_E6;
							}
						}
						IL_E6:
						num2 = (short)29556736;
						if (num2 != 0)
						{
						}
						num2 = (short)511049729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return num4;
					case 2:
						if (this.EnableCustomization)
						{
							num2 = (short)1165819904;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return num4;
					}
					goto IL_1C;
				}
				return num4;
				IL_1C:
				num4 = base.VisualChildrenCount;
				num2 = (short)1598750722;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00068A54 File Offset: 0x00066C54
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			short num = (short)1356070913;
			if (num != 0)
			{
			}
			num = (short)851050499;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1124080460;
					short num3 = num;
					num = (short)373496652;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11F;
					default:
						num = (short)886046720;
						if (num != 0)
						{
						}
						num = (short)2013659137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (index == this.VisualChildrenCount - 1)
					{
						goto IL_11F;
					}
					goto IL_138;
				case 2:
					goto IL_136;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				IL_5D:
				if (this.EnableCustomization)
				{
					num = (short)2007040000;
					short num4 = num;
					num = (short)20185088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_138;
				IL_11F:
				num = (short)375390210;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_136:
			return this.GetNavigationPaneCustomize();
			IL_138:
			return base.GetVisualChild(index);
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00068BA0 File Offset: 0x00066DA0
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00068C58 File Offset: 0x00066E58
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush SmallItemsBackground
		{
			get
			{
				short num = (short)602118383;
				short num2 = num;
				num = (short)1828034799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1460076544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1065484289;
				if (num != 0)
				{
				}
				num = (short)1675558912;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.NavigationPanePanel.SmallItemsBackgroundProperty);
			}
			set
			{
				short num = (short)418413837;
				short num2 = num;
				num = (short)1625586957;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1607204864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)139722752;
				if (num != 0)
				{
				}
				num = (short)2026045441;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPanePanel.SmallItemsBackgroundProperty, value);
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00068D10 File Offset: 0x00066F10
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::System.Windows.Media.Brush smallItemsBackground;
			for (;;)
			{
				IL_0A:
				global::System.Windows.Rect rectangle;
				switch (num)
				{
				case 0:
					return;
				case 1:
					num2 = (short)827523073;
					if (num2 != 0)
					{
					}
					if (smallItemsBackground != null)
					{
						num2 = (short)255262726;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (rectangle.Height > 0.0)
					{
						num2 = (short)784990211;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
				{
					num2 = (short)1922433024;
					short num3 = num2;
					goto IL_98;
				}
				case 4:
					if (rectangle.Width > 0.0)
					{
						num2 = (short)968687621;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					num2 = (short)1251147778;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					rectangle = new global::System.Windows.Rect(0.0, base.RenderSize.Height - this.SmallItemsHeight, base.RenderSize.Width, this.SmallItemsHeight);
					num2 = (short)1664557273;
					short num4 = num2;
					num2 = (short)1385242841;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_98;
					default:
						num2 = (short)2029518848;
						if (num2 != 0)
						{
						}
						num2 = (short)729022468;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_2C;
				IL_98:
				dc.DrawRectangle(smallItemsBackground, null, rectangle);
				num2 = (short)2126839808;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			base.OnRender(dc);
			smallItemsBackground = this.SmallItemsBackground;
			num2 = (short)1619263489;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00068F18 File Offset: 0x00067118
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00068FD0 File Offset: 0x000671D0
		public bool PaneExpanded
		{
			get
			{
				short num = (short)1793294319;
				short num2 = num;
				num = (short)1629388783;
				switch (num2 == num)
				{
				default:
				{
					num = (short)628359168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1652162560;
				if (num != 0)
				{
				}
				num = (short)226164737;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.NavigationPanePanel.PaneExpandedProperty);
			}
			set
			{
				short num = (short)702523928;
				short num2 = num;
				num = (short)1599187480;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2098266112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1409875969;
				if (num != 0)
				{
				}
				num = (short)507707392;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPanePanel.PaneExpandedProperty, value);
			}
		}

		// Token: 0x0400027A RID: 634
		private global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton _CustomizeButton;

		// Token: 0x0400027B RID: 635
		public static readonly global::System.Windows.DependencyProperty LargeItemsCountProperty;

		// Token: 0x0400027C RID: 636
		public static readonly global::System.Windows.DependencyProperty EnableCustomizationProperty;

		// Token: 0x0400027D RID: 637
		public static readonly global::System.Windows.DependencyProperty SmallItemsHeightProperty;

		// Token: 0x0400027E RID: 638
		public static readonly global::System.Windows.DependencyProperty SmallItemsBackgroundProperty;

		// Token: 0x0400027F RID: 639
		public static readonly global::System.Windows.DependencyProperty PaneExpandedProperty;
	}
}
