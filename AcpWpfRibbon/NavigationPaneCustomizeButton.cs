using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using AcpCommonResources;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000062 RID: 98
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class NavigationPaneCustomizeButton : global::System.Windows.Controls.Button
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x000623B0 File Offset: 0x000605B0
		static NavigationPaneCustomizeButton()
		{
			int a_ = 5;
			short num = (short)1064929424;
			short num2 = num;
			num = (short)1591904400;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1757675520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)707395585;
			if (num != 0)
			{
			}
			num = (short)678756352;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton)));
			global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton.IsCustomizeMenuOpenPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᑜⱞ≠ᙢᙤ፦٨٪Ѭᕮᑰ㹲ၴ᥶౸㑺ർ᩾", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton), new global::System.Windows.PropertyMetadata(false));
			global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton.IsCustomizeMenuOpenProperty = global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton.IsCustomizeMenuOpenPropertyKey.DependencyProperty;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000624C8 File Offset: 0x000606C8
		protected override void OnPreviewMouseRightButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1286603577;
			short num2 = num;
			num = (short)1104741177;
			switch (num2 == num)
			{
			default:
			{
				num = (short)966262784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)415301633;
			if (num != 0)
			{
			}
			num = (short)1138819072;
			if (num != 0)
			{
			}
			e.Handled = true;
			base.OnPreviewMouseRightButtonUp(e);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0006257C File Offset: 0x0006077C
		protected override void OnClick()
		{
			int a_ = 17;
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)7390288;
						short num3 = num2;
						num2 = (short)300991568;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A9;
						default:
							num2 = (short)721682432;
							if (num2 != 0)
							{
							}
							if (base.ContextMenu != null)
							{
								num2 = (short)962134017;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_151;
						}
						break;
					}
					case 1:
						base.ContextMenu.IsOpen = true;
						num2 = (short)96862210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_14F;
					}
					goto IL_25;
				}
				IL_14F:
				IL_151:
				base.OnClick();
				return;
			}
			IL_25:
			num2 = (short)1813446656;
			short num4 = num2;
			num2 = (short)938999809;
			if (num2 != 0)
			{
			}
			base.ContextMenu = (base.FindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.NavigationPane), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❨੪᭬㽮ၰᵲၴ㑶౸ࡺॼၾﾄ쪈ﮎ\uda96ﲘ", a_))) as global::System.Windows.Controls.ContextMenu);
			this.SetupContextMenu();
			IL_A9:
			num2 = (short)765263872;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000626E0 File Offset: 0x000608E0
		private void SetupContextMenu()
		{
			int a_ = 0;
			short num = (short)1292173312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				global::System.Windows.Controls.ContextMenu contextMenu;
				for (;;)
				{
					IL_30:
					global::DevComponents.WpfRibbon.NavigationPane navigationPane;
					global::System.Collections.Generic.List<object> list;
					global::System.Collections.Generic.List<object>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
					{
						if (navigationPane == null)
						{
							num = (short)848560132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1790246913;
						if (num != 0)
						{
						}
						contextMenu.Closed += this.CustomizeMenuClosed;
						contextMenu.Opened += this.CustomizeMenuOpened;
						contextMenu.PlacementTarget = this;
						contextMenu.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Right;
						contextMenu.VerticalOffset = base.ActualHeight / 2.0;
						list = new global::System.Collections.Generic.List<object>();
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)contextMenu.Items).GetEnumerator();
						num = (short)1908932613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						try
						{
							num = (short)1579810817;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_49C;
									}
									continue;
								case 2:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)944504835;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object removeItem = enumerator2.Current;
									contextMenu.Items.Remove(removeItem);
									num = (short)668925952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1899102212;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_51B;
								}
								IL_4CB:
								num = (short)1268711426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_49C:
								goto IL_4CB;
							}
							IL_51B:
							goto IL_D00;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto Block_5;
						IL_D00:
						bool flag = false;
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)navigationPane.Items).GetEnumerator();
						num = (short)1832517638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_8D;
					case 3:
						if (contextMenu == null)
						{
							num = (short)144375810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41F;
					case 4:
						return;
					case 5:
					{
						num = (short)1155792896;
						short num3 = num;
						goto IL_52E;
					}
					case 6:
						try
						{
							num = (short)854654982;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Controls.MenuItem menuItem;
								switch (num2)
								{
								case 0:
									goto IL_3A4;
								case 1:
								{
									bool flag;
									if (!flag)
									{
										num = (short)1109983243;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_272;
								}
								case 2:
								{
									global::DevComponents.WpfRibbon.PaneItem paneItem;
									menuItem.Icon = global::DevComponents.WpfRibbon.CloningMachine.GetObjectCopy((paneItem.ImageSmall != null) ? paneItem.ImageSmall : paneItem.Image, false);
									menuItem.IsChecked = paneItem.IsSelected;
									menuItem.Click += this.MenuItemSelectPaneClick;
									num = (short)152502273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1456472072;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfRibbon.PaneItem paneItem = enumerator.Current as global::DevComponents.WpfRibbon.PaneItem;
									num = (short)810680330;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)510394380;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_113;
									}
									continue;
								case 7:
								{
									global::System.Windows.Rect layoutSlot;
									if (layoutSlot.X < -100.0)
									{
										num = (short)700579849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)124059648;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									menuItem = new global::System.Windows.Controls.MenuItem();
									menuItem.Style = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ṗ㙙㵛⩝ⵟݡ੣፥Ⅷṩ५ͭ", a_))) as global::System.Windows.Style);
									global::DevComponents.WpfRibbon.PaneItem paneItem;
									menuItem.Tag = paneItem;
									menuItem.Header = global::DevComponents.WpfRibbon.CloningMachine.GetObjectCopy(paneItem.Header, false);
									num = (short)794230786;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::DevComponents.WpfRibbon.PaneItem paneItem;
									if (paneItem == null)
									{
										num = (short)218300421;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(paneItem);
									num = (short)1786380295;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::System.Windows.Controls.Separator separator = new global::System.Windows.Controls.Separator();
									separator.Style = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ṗ㙙㵛⩝㍟ݡᑣݥᩧ୩ᡫŭɯ", a_))) as global::System.Windows.Style);
									contextMenu.Items.Add(separator);
									bool flag = true;
									num = (short)1576402957;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									goto IL_385;
								case 13:
									goto IL_272;
								}
								IL_231:
								num = (short)350552068;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_113:
								goto IL_231;
								IL_272:
								contextMenu.Items.Add(menuItem);
								num = (short)2002976771;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_385:
							IL_3A4:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_3C6;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_3B3:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)37093377;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_41E;
								case 1:
									disposable.Dispose();
									num = (short)1027407874;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_41C;
								}
								goto IL_3C6;
							}
							IL_41C:
							IL_41E:
							goto EndFinally_33;
							IL_3C6:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1918763008;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3B3;
							EndFinally_33:;
						}
						goto IL_41F;
					}
					goto IL_53;
					Block_5:
					try
					{
						IL_52E:
						num = (short)1035993104;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Windows.Controls.MenuItem menuItem2;
								menuItem2.Name = global::DevComponents.WpfRibbon.NavigationPane.SystemNavPaneOptionMenuItem;
								menuItem2.Header = navigationPane.SystemText.NavigationPaneOptions;
								menuItem2.Click += this.ShowNavPaneOptions;
								num = (short)1871446038;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::System.Windows.Controls.MenuItem menuItem2;
								menuItem2.Name = global::DevComponents.WpfRibbon.NavigationPane.SystemAddRemoveMenuItem;
								menuItem2.Header = navigationPane.SystemText.AddRemoveButtons;
								menuItem2.Items.Clear();
								global::System.Collections.IEnumerator enumerator3 = ((global::System.Collections.IEnumerable)navigationPane.Items).GetEnumerator();
								num = (short)1135345672;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								num = (short)2051407893;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								global::System.Windows.Controls.MenuItem menuItem2;
								if (menuItem2.Tag is global::DevComponents.WpfRibbon.PaneItem)
								{
									num = (short)293076996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
							{
								object obj;
								list.Add(obj);
								num = (short)435617804;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								global::System.Windows.Controls.MenuItem menuItem2;
								if ((string)menuItem2.Header == global::DevComponents.WpfRibbon.NavigationPane.SystemShowMoreButtonsMenuItem)
								{
									num = (short)1044447245;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_89C;
							}
							case 6:
							{
								global::System.Windows.Controls.MenuItem menuItem2;
								if (menuItem2 == null)
								{
									num = (short)1046872081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1949040650;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								global::System.Windows.Controls.MenuItem menuItem2;
								if ((string)menuItem2.Header == global::DevComponents.WpfRibbon.NavigationPane.SystemShowFewerButtonsMenuItem)
								{
									num = (short)114163723;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1909129230;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								try
								{
									num = (short)1350893571;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 1:
										{
											global::System.Windows.Controls.MenuItem menuItem3;
											global::DevComponents.WpfRibbon.PaneItem paneItem2;
											menuItem3.Icon = global::DevComponents.WpfRibbon.CloningMachine.GetObjectCopy((paneItem2.ImageSmall != null) ? paneItem2.ImageSmall : paneItem2.Image, false);
											menuItem3.IsChecked = (paneItem2.Visibility == global::System.Windows.Visibility.Visible);
											menuItem3.Tag = paneItem2;
											menuItem3.Click += this.ShowHidePaneItemClick;
											global::System.Windows.Controls.MenuItem menuItem2;
											menuItem2.Items.Add(menuItem3);
											num = (short)517931008;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											goto IL_822;
										case 3:
											switch (0)
											{
											case 0:
												goto IL_6A2;
											}
											continue;
										case 4:
										{
											global::DevComponents.WpfRibbon.PaneItem paneItem2;
											if (paneItem2 != null)
											{
												num = (short)1542782982;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 5:
											num = (short)647430146;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
										{
											global::System.Windows.Controls.MenuItem menuItem3 = new global::System.Windows.Controls.MenuItem();
											menuItem3.Style = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ṗ㙙㵛⩝ⵟݡ੣፥Ⅷṩ५ͭ", a_))) as global::System.Windows.Style);
											global::DevComponents.WpfRibbon.PaneItem paneItem2;
											menuItem3.Header = global::DevComponents.WpfRibbon.CloningMachine.GetObjectCopy(paneItem2.Header, false);
											num = (short)215023617;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 7:
										{
											global::System.Collections.IEnumerator enumerator3;
											if (!enumerator3.MoveNext())
											{
												num = (short)1531576325;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::DevComponents.WpfRibbon.PaneItem paneItem2 = enumerator3.Current as global::DevComponents.WpfRibbon.PaneItem;
											num = (short)259719172;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_7CC:
										num = (short)1782644743;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_6A2:
										goto IL_7CC;
									}
									IL_822:
									break;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_844;
									}
									global::System.IDisposable disposable;
									for (;;)
									{
										IL_831:
										switch (num2)
										{
										case 0:
											goto IL_899;
										case 1:
											if (disposable != null)
											{
												num = (short)1826553858;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_89B;
										case 2:
											disposable.Dispose();
											num = (short)1495334912;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_844;
									}
									IL_899:
									IL_89B:
									goto EndFinally_31;
									IL_844:
									global::System.Collections.IEnumerator enumerator3;
									disposable = (enumerator3 as global::System.IDisposable);
									num = (short)1664155649;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_831;
									EndFinally_31:;
								}
								goto IL_89C;
							case 9:
								num = (short)1625817108;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
							{
								global::System.Windows.Controls.MenuItem menuItem2;
								if (menuItem2.Header != null)
								{
									num = (short)1550516233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 11:
							{
								global::System.Windows.Controls.MenuItem menuItem2;
								menuItem2.Name = global::DevComponents.WpfRibbon.NavigationPane.SystemShowFewerButtonsMenuItem;
								navigationPane.SystemText.ShowFewerButtons = global::AcpCommonResources.AcpResources.Show_Fewer_Buttons;
								menuItem2.Header = navigationPane.SystemText.ShowFewerButtons;
								menuItem2.Click += this.ShowFewerButtonsClick;
								menuItem2.IsEnabled = (navigationPane.LargeItemsCount > 0);
								num = (short)863109139;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 13:
							{
								global::System.Windows.Controls.MenuItem menuItem2;
								menuItem2.Name = global::DevComponents.WpfRibbon.NavigationPane.SystemShowMoreButtonsMenuItem;
								navigationPane.SystemText.ShowMoreButtons = global::AcpCommonResources.AcpResources.Show_More_Buttons;
								menuItem2.Header = navigationPane.SystemText.ShowMoreButtons;
								menuItem2.Click += this.ShowMoreButtonsClick;
								menuItem2.IsEnabled = (navigationPane.Items.Count > navigationPane.LargeItemsCount);
								num = (short)552009751;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 14:
							{
								global::System.Windows.Controls.MenuItem menuItem2;
								if ((string)menuItem2.Header == global::DevComponents.WpfRibbon.NavigationPane.SystemNavPaneOptionMenuItem)
								{
									num = (short)936378368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)2026242051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 15:
							{
								global::System.Collections.IEnumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1757675522;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj = enumerator.Current;
								global::System.Windows.Controls.MenuItem menuItem2 = obj as global::System.Windows.Controls.MenuItem;
								num = (short)1161756678;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 16:
								switch (0)
								{
								case 0:
									goto IL_5B5;
								}
								continue;
							case 17:
							{
								object obj;
								list.Add(obj);
								num = (short)1475149842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 20:
							{
								global::System.Windows.Controls.MenuItem menuItem2;
								if ((string)menuItem2.Header == global::DevComponents.WpfRibbon.NavigationPane.SystemAddRemoveMenuItem)
								{
									num = (short)1817640961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_9AA;
							}
							case 21:
							{
								num = (short)1297466909;
								short num4 = num;
								num = (short)556058141;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_9AA;
								default:
									goto IL_C6D;
								}
								break;
							}
							}
							goto IL_5B5;
							IL_89C:
							num = (short)626917383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_9AA:
							num = (short)1637089285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_AC8:
							num = (short)242221071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5B5:
							goto IL_AC8;
						}
						IL_C6D:
						num = (short)1759182848;
						if (num != 0)
						{
						}
						goto IL_92;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_CA4;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_C91:
							switch (num2)
							{
							case 0:
								goto IL_CFC;
							case 1:
								if (disposable != null)
								{
									num = (short)747438082;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_CFE;
							case 2:
								disposable.Dispose();
								num = (short)772603904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CA4;
						}
						IL_CFC:
						IL_CFE:
						break;
						IL_CA4:
						global::System.Collections.IEnumerator enumerator;
						disposable = (enumerator as global::System.IDisposable);
						num = (short)373293057;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_C91;
					}
					break;
					IL_92:
					enumerator2 = list.GetEnumerator();
					num = (short)1648033793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41F:
					navigationPane = this.GetNavigationPane();
					num = (short)1506934784;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_8D:
				return;
				IL_53:
				contextMenu = base.ContextMenu;
				num = (short)1477640195;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00063548 File Offset: 0x00061748
		private void MenuItemSelectPaneClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1745354753;
			if (num != 0)
			{
			}
			num = (short)702362792;
			short num2 = num;
			num = (short)1355691176;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1489436672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2097938432;
			if (num != 0)
			{
			}
			((sender as global::System.Windows.Controls.MenuItem).Tag as global::DevComponents.WpfRibbon.PaneItem).IsSelected = true;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00063608 File Offset: 0x00061808
		private void CustomizeMenuOpened(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)935174320;
			short num2 = num;
			num = (short)162242736;
			switch (num2 == num)
			{
			}
			num = (short)1450573824;
			short num3 = num;
			num = (short)332791809;
			if (num != 0)
			{
			}
			num = (short)164233216;
			if (num != 0)
			{
			}
			this.IsCustomizeMenuOpen = true;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000636B8 File Offset: 0x000618B8
		private void ShowNavPaneOptions(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1454363660;
			short num2 = num;
			num = (short)35640332;
			switch (num2 == num)
			{
			}
			num = (short)233308160;
			short num3 = num;
			num = (short)2046951425;
			if (num != 0)
			{
			}
			num = (short)88997888;
			if (num != 0)
			{
			}
			this.GetNavigationPane().ShowOptionsDialog();
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0006376C File Offset: 0x0006196C
		private void ShowMoreButtonsClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1616958044;
			short num2 = num;
			num = (short)1817825884;
			switch (num2 == num)
			{
			}
			num = (short)851968;
			short num3 = num;
			num = (short)1753481216;
			if (num != 0)
			{
			}
			num = (short)875429889;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.NavigationPane navigationPane = this.GetNavigationPane();
			int largeItemsCount = navigationPane.LargeItemsCount;
			navigationPane.LargeItemsCount = largeItemsCount + 1;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0006382C File Offset: 0x00061A2C
		private void ShowFewerButtonsClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)541688637;
			short num2 = num;
			num = (short)495354685;
			switch (num2 == num)
			{
			}
			num = (short)1436614656;
			short num3 = num;
			num = (short)1843658753;
			if (num != 0)
			{
			}
			num = (short)937754624;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.NavigationPane navigationPane = this.GetNavigationPane();
			int largeItemsCount = navigationPane.LargeItemsCount;
			navigationPane.LargeItemsCount = largeItemsCount - 1;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000638EC File Offset: 0x00061AEC
		private global::DevComponents.WpfRibbon.NavigationPane GetNavigationPane()
		{
			while (!(base.Parent is global::DevComponents.WpfRibbon.NavigationPanePanel))
			{
				short num = (short)1048838145;
				if (num != 0)
				{
				}
				num = (short)180092928;
				short num2 = num;
				num = (short)176055753;
				short num3 = num;
				num = (short)1505256905;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)458752;
					if (num != 0)
					{
					}
					return null;
				}
			}
			return ((global::DevComponents.WpfRibbon.NavigationPanePanel)base.Parent).TemplatedParent as global::DevComponents.WpfRibbon.NavigationPane;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000639BC File Offset: 0x00061BBC
		private void CustomizeMenuClosed(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2054750208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				this.IsCustomizeMenuOpen = false;
				global::System.Windows.Controls.ContextMenu contextMenu = sender as global::System.Windows.Controls.ContextMenu;
				contextMenu.Closed -= this.CustomizeMenuClosed;
				contextMenu.Opened -= this.CustomizeMenuOpened;
				global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)contextMenu.Items).GetEnumerator();
				try
				{
					num = (short)225902602;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						object obj;
						switch (num2)
						{
						case 0:
							if (obj is global::System.Windows.Controls.Separator)
							{
								num = (short)2073886743;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							list.Add(menuItem);
							num = (short)400949259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.NavigationPane.SystemAddRemoveMenuItem)
							{
								num = (short)645136391;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)353566737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_5CD;
						case 7:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Header = global::DevComponents.WpfRibbon.NavigationPane.SystemAddRemoveMenuItem;
							menuItem.Items.Clear();
							num = (short)2064711693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.NavigationPane.SystemNavPaneOptionMenuItem)
							{
								num = (short)1767112722;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2030501900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							switch (0)
							{
							case 0:
								goto IL_1EF;
							}
							continue;
						case 12:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Tag is global::DevComponents.WpfRibbon.PaneItem)
							{
								num = (short)482344961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 14:
							num = (short)2031550466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1778450452;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							obj = enumerator.Current;
							global::System.Windows.Controls.MenuItem menuItem = obj as global::System.Windows.Controls.MenuItem;
							num = (short)1100939280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem != null)
							{
								num = (short)245628942;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1647050752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.NavigationPane.SystemShowMoreButtonsMenuItem)
							{
								num = (short)430637075;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1071906837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							num = (short)1608845760;
							short num3 = num;
							num = (short)242682304;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_45F;
							default:
							{
								num = (short)1536032768;
								if (num != 0)
								{
								}
								global::System.Windows.Controls.MenuItem menuItem;
								menuItem.Header = global::DevComponents.WpfRibbon.NavigationPane.SystemNavPaneOptionMenuItem;
								menuItem.Click -= this.ShowNavPaneOptions;
								num = (short)657784837;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 19:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Header = global::DevComponents.WpfRibbon.NavigationPane.SystemShowMoreButtonsMenuItem;
							menuItem.Click -= this.ShowMoreButtonsClick;
							num = (short)1965883395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
							num = (short)326500356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.NavigationPane.SystemShowFewerButtonsMenuItem)
							{
								num = (short)1104347158;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1448607753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Header = global::DevComponents.WpfRibbon.NavigationPane.SystemShowFewerButtonsMenuItem;
							menuItem.Click -= this.ShowFewerButtonsClick;
							num = (short)350158854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							goto IL_45F;
						}
						IL_29C:
						num = (short)82444303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1EF:
						goto IL_29C;
						IL_45F:
						list.Add(obj);
						num = (short)1796603912;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5CD:
					goto IL_132;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_5EF;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_5DC:
						switch (num2)
						{
						case 0:
							goto IL_643;
						case 1:
							if (disposable != null)
							{
								num = (short)1005977602;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_66C;
						case 2:
							disposable.Dispose();
							num = (short)674627584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EF;
					}
					IL_643:
					num = (short)1441726465;
					if (num != 0)
					{
					}
					IL_66C:
					goto EndFinally_16;
					IL_5EF:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)717553665;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_5DC;
					EndFinally_16:;
				}
				return;
				for (;;)
				{
					IL_132:
					num = (short)963117056;
					short num4 = num;
					using (global::System.Collections.Generic.List<object>.Enumerator enumerator2 = list.GetEnumerator())
					{
						num = (short)1543372801;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1939734530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_A1;
								}
								continue;
							case 2:
								goto IL_11F;
							case 3:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1326317568;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object removeItem = enumerator2.Current;
								contextMenu.Items.Remove(removeItem);
								num = (short)718733316;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_A3:
							num = (short)245366787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A1:
							goto IL_A3;
						}
						IL_11F:
						break;
					}
				}
				return;
			}
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0006406C File Offset: 0x0006226C
		private void ShowHidePaneItemClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Controls.MenuItem menuItem = sender as global::System.Windows.Controls.MenuItem;
			global::DevComponents.WpfRibbon.PaneItem paneItem = menuItem.Tag as global::DevComponents.WpfRibbon.PaneItem;
			if (menuItem.IsChecked)
			{
				short num;
				for (;;)
				{
					num = (short)1071185921;
					if (num != 0)
					{
					}
					num = (short)177649602;
					short num2 = num;
					num = (short)1372960706;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_A4;
					}
					break;
				}
				num = (short)1129578496;
				short num3 = num;
				IL_A4:
				num = (short)156893184;
				if (num != 0)
				{
				}
				paneItem.Visibility = global::System.Windows.Visibility.Collapsed;
				return;
			}
			paneItem.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00064144 File Offset: 0x00062344
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00064200 File Offset: 0x00062400
		public bool IsCustomizeMenuOpen
		{
			get
			{
				short num = (short)1821802834;
				short num2 = num;
				num = (short)306151762;
				switch (num2 == num)
				{
				}
				num = (short)349831168;
				if (num != 0)
				{
				}
				num = (short)1985216512;
				short num3 = num;
				num = (short)1317470209;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton.IsCustomizeMenuOpenProperty);
			}
			internal set
			{
				short num = (short)407960779;
				short num2 = num;
				num = (short)1062665419;
				switch (num2 == num)
				{
				}
				num = (short)419037185;
				if (num != 0)
				{
				}
				num = (short)994770944;
				short num3 = num;
				num = (short)638910464;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPaneCustomizeButton.IsCustomizeMenuOpenPropertyKey, value);
			}
		}

		// Token: 0x04000262 RID: 610
		private static readonly global::System.Windows.DependencyPropertyKey IsCustomizeMenuOpenPropertyKey;

		// Token: 0x04000263 RID: 611
		public static readonly global::System.Windows.DependencyProperty IsCustomizeMenuOpenProperty;
	}
}
