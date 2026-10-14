using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200006E RID: 110
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class QatCustomizeButton : global::DevComponents.WpfRibbon.ButtonDropDown
	{
		// Token: 0x06000554 RID: 1364 RVA: 0x00074840 File Offset: 0x00072A40
		static QatCustomizeButton()
		{
			short num = (short)686879465;
			short num2 = num;
			num = (short)1766121;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1606025216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)66387969;
			if (num != 0)
			{
			}
			num = (short)1454964736;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.QatCustomizeButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.QatCustomizeButton)));
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0007490C File Offset: 0x00072B0C
		public QatCustomizeButton()
		{
			global::DevComponents.WpfRibbon.Ribbon.SetIsCustomizable(this, false);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00074928 File Offset: 0x00072B28
		public override void OnApplyTemplate()
		{
			int a_ = 9;
			short num = (short)71565312;
			switch (num)
			{
			default:
			{
				num = (short)1949106187;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Controls.Separator separator;
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					global::System.Windows.Controls.ContentPresenter contentPresenter;
					global::System.Windows.Shapes.Path path;
					switch (num2)
					{
					case 0:
						goto IL_26E;
					case 1:
						goto IL_19A;
					case 2:
						goto IL_2A7;
					case 3:
						if (base.Items.Count == 0)
						{
							num = (short)70582288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B9;
					case 4:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						base.FontSize = ribbon.FontSize;
						global::System.Windows.Controls.TextBlock textBlock = new global::System.Windows.Controls.TextBlock();
						textBlock.MinWidth = 190.0;
						textBlock.Text = ribbon.SystemText.QatCustomizeMenuLabel;
						textBlock.FontWeight = global::System.Windows.FontWeights.Bold;
						textBlock.Background = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.QatCustomizeMenuLabelBackground)) as global::System.Windows.Media.Brush);
						textBlock.Padding = new global::System.Windows.Thickness(6.0, 2.0, 2.0, 2.0);
						base.Items.Add(textBlock);
						separator = new global::System.Windows.Controls.Separator();
						separator.Padding = new global::System.Windows.Thickness(0.0);
						separator.Margin = new global::System.Windows.Thickness(0.0);
						base.Items.Add(separator);
						buttonDropDown = null;
						buttonDropDown = new global::DevComponents.WpfRibbon.ButtonDropDown();
						global::DevComponents.WpfRibbon.Ribbon.SetIsCustomizable(buttonDropDown, false);
						num = (short)1636892673;
						if (num != 0)
						{
						}
						num = (short)2018639889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						if (ribbon == null)
						{
							goto IL_6B9;
						}
						num = (short)1541641851;
						short num3 = num;
						num = (short)1593087611;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_494;
						default:
							num = (short)701628416;
							if (num != 0)
							{
							}
							num = (short)1397489668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						contentPresenter.Margin = new global::System.Windows.Thickness(2.0, 1.0, 2.0, 1.0);
						num = (short)909574145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_494;
					case 8:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						if (ribbon.IsMinimized)
						{
							num = (short)423100425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						buttonDropDown.Header = ribbon.SystemText.MinimizeRibbonText;
						num = (short)1934688268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						buttonDropDown.Header = ribbon.SystemText.MaximizeRibbonText;
						num = (short)585170944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_674;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_99;
						}
						continue;
					case 12:
						goto IL_26E;
					case 13:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						buttonDropDown.Header = ribbon.SystemText.QatPlaceAboveRibbonText;
						num = (short)1727660047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_BF;
					case 15:
						goto IL_BF;
					case 16:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon = this.GetRibbon();
						num = (short)2067398661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						if (ribbon.IsQuickAccessToolbarBelow)
						{
							num = (short)1034485760;
							short num4 = num;
							num = (short)1019871245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						buttonDropDown.Header = ribbon.SystemText.QatPlaceBelowRibbonText;
						num = (short)904331278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						path = new global::System.Windows.Shapes.Path();
						path.SnapsToDevicePixels = true;
						global::System.Windows.Media.PathGeometry pathGeometry = new global::System.Windows.Media.PathGeometry();
						global::System.Windows.Media.PathSegment[] segments = new global::System.Windows.Media.PathSegment[]
						{
							new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(2.5, 6.0), false),
							new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(5.0, 3.0), false)
						};
						global::System.Windows.Media.PathFigure value = new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(0.0, 3.0), segments, true);
						pathGeometry.Figures.Add(value);
						segments = new global::System.Windows.Media.PathSegment[]
						{
							new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(5.0, 0.5), true)
						};
						value = new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(0.0, 0.5), segments, false);
						pathGeometry.Figures.Add(value);
						path.Data = pathGeometry;
						global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❠ౢᝤɦ๨ᥪɬᩮὰᝲ", a_));
						binding.Source = this;
						path.SetBinding(global::System.Windows.Shapes.Shape.FillProperty, binding);
						path.SetBinding(global::System.Windows.Shapes.Shape.StrokeProperty, binding);
						path.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
						path.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
						contentPresenter = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅠ≢㝤㍦㙨⥪ᡬ᭮հᱲ᭴㑶ᙸᕺॼ᩾", a_)) as global::System.Windows.Controls.ContentPresenter);
						num = (short)1804730375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_99:
					if (base.Header == null)
					{
						num = (short)1445920786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_674;
					IL_BF:
					buttonDropDown.Role = global::DevComponents.WpfRibbon.eButtonRole.MenuItem;
					buttonDropDown.Name = global::DevComponents.WpfRibbon.Ribbon.SystemQatChangePlacementMenuItem;
					buttonDropDown.Click += this.QatChangePlacement;
					base.Items.Add(buttonDropDown);
					separator = new global::System.Windows.Controls.Separator();
					base.Items.Add(separator);
					buttonDropDown = new global::DevComponents.WpfRibbon.ButtonDropDown();
					global::DevComponents.WpfRibbon.Ribbon.SetIsCustomizable(buttonDropDown, false);
					buttonDropDown.Role = global::DevComponents.WpfRibbon.eButtonRole.MenuItem;
					buttonDropDown.Name = global::DevComponents.WpfRibbon.Ribbon.SystemQatMinMaxRibbonMenuItem;
					num = (short)1480130568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19A:
					base.Header = path;
					num = (short)2061500426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_494:
					if (contentPresenter != null)
					{
						num = (short)821755910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19A;
					IL_26E:
					buttonDropDown.Click += this.QatMinMaxRibbon;
					base.Items.Add(buttonDropDown);
					num = (short)1106706434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_674:
					num = (short)2050162691;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2A7:
				IL_6B9:
				base.OnApplyTemplate();
				return;
			}
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00074FF4 File Offset: 0x000731F4
		private void QatChangePlacement(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.Ribbon ribbon;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_C4;
				case 2:
				{
					num2 = (short)1432640665;
					short num3 = num2;
					num2 = (short)299850905;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C4;
					default:
						num2 = (short)377159680;
						if (num2 != 0)
						{
						}
						if (ribbon != null)
						{
							num2 = (short)479199233;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_1C;
				IL_C4:
				num2 = (short)162463745;
				if (num2 != 0)
				{
				}
				ribbon.ChangeQatPlacement();
				num2 = (short)1977155584;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)2022703104;
			short num4 = num2;
			ribbon = this.GetRibbon();
			num2 = (short)1620115458;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00075110 File Offset: 0x00073310
		private void MoreCommandsClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.Ribbon ribbon;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_EF;
				case 2:
				{
					num2 = (short)2045366722;
					short num3 = num2;
					num2 = (short)1251856834;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EF;
					default:
						num2 = (short)228065280;
						if (num2 != 0)
						{
						}
						num2 = (short)745013249;
						if (num2 != 0)
						{
						}
						if (ribbon != null)
						{
							num2 = (short)1709834241;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_1C;
				IL_EF:
				ribbon.OnQatDialogCustomize();
				num2 = (short)469958656;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)931921920;
			short num4 = num2;
			ribbon = this.GetRibbon();
			num2 = (short)733151234;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00075230 File Offset: 0x00073430
		private void QatMinMaxRibbon(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)557318145;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_6E;
			}
			int num3;
			global::DevComponents.WpfRibbon.Ribbon ribbon;
			for (;;)
			{
				IL_32:
				num = (short)1949761536;
				short num2 = num;
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_ED;
				case 2:
				{
					num = (short)239380417;
					short num4 = num;
					num = (short)2020583361;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_ED;
					default:
						num = (short)682688512;
						if (num != 0)
						{
						}
						if (ribbon != null)
						{
							num = (short)1233125377;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_6E;
				IL_ED:
				ribbon.ToggleRibbonMinimized();
				num = (short)562233344;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_6E:
			ribbon = this.GetRibbon();
			num = (short)1391198210;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00075350 File Offset: 0x00073550
		protected override void OnPopupOpened(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)528744448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::DevComponents.WpfRibbon.Ribbon ribbon;
				for (;;)
				{
					IL_28:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1379926017;
						if (num != 0)
						{
						}
						try
						{
							num = (short)763101196;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (ribbon.IsMinimized)
									{
										num = (short)345505796;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
									buttonDropDown.Header = ribbon.SystemText.MinimizeRibbonText;
									num = (short)257425411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)257884168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
									buttonDropDown.Header = ribbon.SystemText.MaximizeRibbonText;
									num = (short)2068381698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)584908813;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = enumerator.Current;
									num = (short)1519452178;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									object obj;
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown2 = (global::DevComponents.WpfRibbon.ButtonDropDown)obj;
									num = (short)2120089616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									object obj;
									if (((global::DevComponents.WpfRibbon.ButtonDropDown)obj).Name == global::DevComponents.WpfRibbon.Ribbon.SystemQatChangePlacementMenuItem)
									{
										num = (short)1051525127;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									object obj;
									if (((global::DevComponents.WpfRibbon.ButtonDropDown)obj).Name == global::DevComponents.WpfRibbon.Ribbon.SystemQatMinMaxRibbonMenuItem)
									{
										num = (short)526450698;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_202;
								}
								case 10:
								{
									object obj;
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)obj;
									num = (short)1696989184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown2;
									buttonDropDown2.Header = ribbon.SystemText.QatPlaceAboveRibbonText;
									num = (short)1070071827;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									switch (0)
									{
									case 0:
										goto IL_F0;
									}
									continue;
								case 13:
									num = (short)490340369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)349503497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									object obj;
									if (obj is global::DevComponents.WpfRibbon.ButtonDropDown)
									{
										num = (short)867303425;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 16:
								{
									if (ribbon.IsQuickAccessToolbarBelow)
									{
										num = (short)2140078091;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown2;
									buttonDropDown2.Header = ribbon.SystemText.QatPlaceBelowRibbonText;
									num = (short)2042232837;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
									goto IL_3C8;
								case 18:
								{
									object obj;
									if (obj is global::DevComponents.WpfRibbon.ButtonDropDown)
									{
										num = (short)594673678;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_202;
								}
								}
								IL_1BF:
								num = (short)771162118;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F0:
								goto IL_1BF;
								IL_202:
								num = (short)438501391;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3C8:
							goto IL_50E;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_3EA;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_3D7:
								switch (num2)
								{
								case 0:
									goto IL_491;
								case 1:
									goto IL_46F;
								case 2:
								{
									num = (short)698613369;
									short num3 = num;
									num = (short)805174905;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_46F;
									default:
										num = (short)1505820672;
										if (num != 0)
										{
										}
										if (disposable != null)
										{
											num = (short)2138505217;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_493;
									}
									break;
								}
								}
								goto IL_3EA;
								IL_46F:
								disposable.Dispose();
								num = (short)1693319168;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_491:
							IL_493:
							goto EndFinally_12;
							IL_3EA:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1100742658;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3D7;
							EndFinally_12:;
						}
						goto IL_494;
					case 1:
						goto IL_494;
					case 2:
						if (ribbon != null)
						{
							num = (short)1540751361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50E;
					}
					goto IL_3B;
					IL_494:
					num = (short)281542656;
					short num4 = num;
					enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
					num = (short)1482752000;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_50E:
				base.OnPopupOpened(e);
				return;
				IL_3B:
				ribbon = this.GetRibbon();
				num = (short)173408258;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00075890 File Offset: 0x00073A90
		private global::DevComponents.WpfRibbon.Ribbon GetRibbon()
		{
			short num = (short)1992818690;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.DependencyObject dependencyObject;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1BF;
				case 1:
					goto IL_A3;
				case 2:
				{
					num = (short)545914880;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				}
				case 3:
				{
					num = (short)977445215;
					short num4 = num;
					num = (short)1836425567;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_129;
					default:
						num = (short)445644800;
						if (num != 0)
						{
						}
						if (dependencyObject == null)
						{
							num = (short)1817903104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2035220486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_A3;
				case 5:
					goto IL_9E;
				case 6:
					if (dependencyObject is global::System.Windows.Media.Visual)
					{
						num = (short)1698168842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
					num = (short)1094320129;
					if (num != 0)
					{
					}
					num = (short)596639745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_DA;
				case 8:
					goto IL_144;
				case 9:
					if (dependencyObject is global::DevComponents.WpfRibbon.Ribbon)
					{
						num = (short)697565191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_144;
				case 10:
					dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
					num = (short)1375666180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7A:
				if (base.Parent is global::DevComponents.WpfRibbon.Ribbon)
				{
					num = (short)977928197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_129;
				IL_A3:
				num = (short)1344798729;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_129:
				dependencyObject = this;
				num = (short)69271560;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_144:
				num = (short)295960579;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9E:
			return base.Parent as global::DevComponents.WpfRibbon.Ribbon;
			IL_DA:
			return dependencyObject as global::DevComponents.WpfRibbon.Ribbon;
			IL_1BF:
			return null;
		}
	}
}
