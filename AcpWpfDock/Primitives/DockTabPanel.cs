using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock.Primitives
{
	// Token: 0x02000059 RID: 89
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DockTabPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x06000348 RID: 840 RVA: 0x0004FDDC File Offset: 0x0004DFDC
		static DockTabPanel()
		{
			int a_ = 4;
			short num = (short)762084161;
			short num2 = num;
			num = (short)1711700801;
			switch (num2 == num)
			{
			}
			num = (short)1688076288;
			short num3 = num;
			num = (short)911605761;
			if (num != 0)
			{
			}
			num = (short)826212352;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.Primitives.DockTabPanel.PanelAlignmentProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鏂꓄꧆곈ꟊ賌ꏎ룐듒믔뫖볘뗚꧜", a_), typeof(global::DevComponents.WpfDock.eDockTabElementAlignment), typeof(global::DevComponents.WpfDock.Primitives.DockTabPanel), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfDock.eDockTabElementAlignment.Left, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.Primitives.DockTabPanel.c)), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfDock.Primitives.DockTabPanel.a));
			global::DevComponents.WpfDock.Primitives.DockTabPanel.BorderInnerBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("臂꫄뗆귈껊뿌蛎뿐뷒냔ꗖ鯘꧚꣜곞觠", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfDock.Primitives.DockTabPanel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.Primitives.DockTabPanel.a)));
			global::DevComponents.WpfDock.Primitives.DockTabPanel.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("臂꫄뗆귈껊뿌跎ꏐꛒꛔ뿖", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfDock.Primitives.DockTabPanel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.Primitives.DockTabPanel.b)));
			global::DevComponents.WpfDock.Primitives.DockTabPanel.BackgroundInnerProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("臂꓄꓆ꋈ곊뿌ꃎꓐ뷒뇔黖럘뗚룜귞", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfDock.Primitives.DockTabPanel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::DevComponents.WpfDock.Primitives.DockTabPanel), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Cycle));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfDock.Primitives.DockTabPanel), global::System.Windows.Controls.Primitives.Selector.SelectedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfDock.Primitives.DockTabPanel.a));
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0004FFDC File Offset: 0x0004E1DC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			int num;
			global::System.Windows.Size result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_DA;
					case 1:
						if (result.Width > availableSize.Width)
						{
							num2 = (short)585433090;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_14B;
					case 2:
						num2 = (short)323223556;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						num2 = (short)1100414976;
						short num3 = num2;
						double a_ = (this.a - (result.Width - availableSize.Width)) / this.a;
						result = this.a(availableSize, a_);
						num2 = (short)1856897024;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						num2 = (short)734855169;
						if (num2 != 0)
						{
						}
						if (this.a > 0.0)
						{
							num2 = (short)1611333635;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_14B;
					}
					goto IL_24;
				}
				IL_DA:
				IL_14B:
				num2 = (short)1097536376;
				short num4 = num2;
				num2 = (short)618664824;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_35;
				default:
					num2 = (short)534446080;
					if (num2 != 0)
					{
					}
					this.b = availableSize.Width;
					global::DevComponents.WpfDock.i.a(ref result);
					return result;
				}
				break;
			}
			}
			IL_24:
			result = this.a(availableSize, 0.0);
			IL_35:
			num2 = (short)150732801;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00050198 File Offset: 0x0004E398
		private global::System.Windows.Size a(global::System.Windows.Size A_0, double A_1)
		{
			short num = (short)1543948681;
			short num2 = num;
			num = (short)317114761;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_400;
			case 1:
				break;
			default:
			{
				num = (short)413204480;
				short num3 = num;
				break;
			}
			}
			num = (short)748093441;
			if (num != 0)
			{
			}
			num = (short)1366622208;
			if (num != 0)
			{
			}
			num = (short)750649344;
			int num4 = (int)num;
			global::System.Windows.Size result;
			switch (num4)
			{
			default:
			{
				this.a = 0.0;
				result = default(global::System.Windows.Size);
				global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
				bool flag = !global::DevComponents.WpfDock.i.a(A_1);
				global::System.Collections.IEnumerator enumerator = internalChildren.GetEnumerator();
				try
				{
					num = (short)1864433668;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Windows.UIElement uielement;
						global::System.Windows.Size desiredSize;
						global::System.Windows.Size availableSize;
						switch (num4)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)851902476;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)93913090;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_183;
						case 2:
							if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
							{
								num = (short)1182728202;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
							goto IL_281;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_145;
							}
							continue;
						case 5:
							result.Height = desiredSize.Height;
							num = (short)21430273;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_389;
						case 8:
							availableSize = uielement.DesiredSize;
							availableSize.Width = global::System.Math.Round(availableSize.Width);
							availableSize.Height = global::System.Math.Round(availableSize.Height);
							availableSize.Width = global::System.Math.Max(22.0, global::System.Math.Floor(availableSize.Width * A_1));
							num = (short)1361379331;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (flag)
							{
								num = (short)540475400;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_281;
						case 10:
							availableSize = A_0;
							num = (short)1944649737;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (result.Height < desiredSize.Height)
							{
								num = (short)641794053;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_183;
						case 12:
							num = (short)178978822;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_145;
						IL_183:
						result.Width += desiredSize.Width;
						this.a += desiredSize.Width;
						num = (short)1780678663;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_240:
						num = (short)1734475776;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_145:
						goto IL_240;
						IL_281:
						uielement.Measure(availableSize);
						desiredSize = uielement.DesiredSize;
						desiredSize.Width = global::System.Math.Round(desiredSize.Width);
						desiredSize.Height = global::System.Math.Round(desiredSize.Height);
						num = (short)986710027;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_389:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_3A8;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_395:
						switch (num4)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)888864770;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3FF;
						case 1:
							goto IL_3FD;
						case 2:
							disposable.Dispose();
							num = (short)441974785;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A8;
					}
					IL_3FD:
					IL_3FF:
					break;
					IL_3A8:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1668415488;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_395;
				}
				break;
			}
			}
			IL_400:
			result.Width += this.c.Left + this.c.Right;
			result.Height += this.c.Top + this.c.Bottom;
			return result;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0005060C File Offset: 0x0004E80C
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1638925132;
			short num2 = num;
			num = (short)769590092;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return finalSize;
			case 1:
				break;
			default:
			{
				num = (short)1835008000;
				short num3 = num;
				break;
			}
			}
			num = (short)1757413376;
			if (num != 0)
			{
			}
			num = (short)1760690176;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				num = (short)1084620801;
				if (num != 0)
				{
				}
				double num5 = this.c.Left;
				double num6 = finalSize.Width - (this.c.Left + this.c.Right);
				double top = this.c.Top;
				double height = finalSize.Height - (this.c.Top + this.c.Bottom);
				global::System.Collections.IEnumerator enumerator = base.InternalChildren.GetEnumerator();
				try
				{
					num = (short)1990787078;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1849688071;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)367067139;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_2D9;
						case 3:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
							{
								num = (short)1129709577;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::System.Windows.UIElement uielement;
							global::System.Windows.Size desiredSize;
							uielement.Arrange(new global::System.Windows.Rect(num5, top, desiredSize.Width, height));
							num5 += desiredSize.Width;
							num = (short)1178796034;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::DevComponents.WpfDock.eDockTabElementAlignment panelAlignment;
							if (panelAlignment == global::DevComponents.WpfDock.eDockTabElementAlignment.Left)
							{
								num = (short)1920925700;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.Size desiredSize;
							num6 -= desiredSize.Width;
							global::System.Windows.UIElement uielement;
							uielement.Arrange(new global::System.Windows.Rect(num6, top, desiredSize.Width, height));
							num = (short)935395336;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_170;
							}
							continue;
						case 7:
							num = (short)786235393;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							global::System.Windows.UIElement uielement;
							global::DevComponents.WpfDock.eDockTabElementAlignment panelAlignment = global::DevComponents.WpfDock.Primitives.DockTabPanel.GetPanelAlignment(uielement);
							global::System.Windows.Size desiredSize = uielement.DesiredSize;
							num = (short)1638531077;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1BA:
						num = (short)1908932608;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_170:
						goto IL_1BA;
					}
					IL_2D9:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_2F8;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_2E5:
						switch (num4)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)758185986;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_350;
						case 1:
							goto IL_34E;
						case 2:
							disposable.Dispose();
							num = (short)1277231105;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F8;
					}
					IL_34E:
					IL_350:
					break;
					IL_2F8:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1954021376;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_2E5;
				}
				break;
			}
			}
			return finalSize;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00050988 File Offset: 0x0004EB88
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			short num = (short)457506816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				global::System.Windows.Rect rect;
				global::System.Windows.Thickness thickness;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (this.e != null)
						{
							num = (short)1690632198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						if (this.d != null)
						{
							num = (short)836894722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8;
					case 2:
					{
						global::System.Windows.Media.Pen pen = this.d;
						rect.Offset(0.5, 0.5);
						double num3 = rect.Width;
						rect.Width = num3 - 1.0;
						dc.DrawLine(pen, new global::System.Windows.Point(rect.X, rect.Y), new global::System.Windows.Point(rect.Right, rect.Y));
						dc.DrawLine(pen, new global::System.Windows.Point(rect.X, rect.Y + thickness.Top), new global::System.Windows.Point(rect.Right, rect.Y + thickness.Top));
						num = (short)947126275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1A7;
					case 4:
					{
						global::System.Windows.Rect rectangle = new global::System.Windows.Rect(rect.X, rect.Y, rect.Width, thickness.Top);
						dc.DrawRectangle(this.BackgroundInner, null, rectangle);
						num = (short)1572470792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (this.BackgroundInner != null)
						{
							num = (short)1369112580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_369;
					case 6:
					{
						num = (short)1240547672;
						short num4 = num;
						num = (short)963920216;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A7;
						default:
						{
							num = (short)1384775680;
							if (num != 0)
							{
							}
							num = (short)336920576;
							short num5 = num;
							num = (short)467730433;
							if (num != 0)
							{
							}
							global::System.Windows.Media.Pen pen = this.e;
							global::System.Windows.Rect rect2 = this.c();
							double num3 = rect.Y;
							rect.Y = num3 - 1.0;
							dc.DrawLine(pen, new global::System.Windows.Point(rect.X, rect.Y + thickness.Top), new global::System.Windows.Point(rect2.X + 1.0, rect.Y + thickness.Top));
							dc.DrawLine(pen, new global::System.Windows.Point(rect2.Right - 1.0, rect.Y + thickness.Top), new global::System.Windows.Point(rect.Right, rect.Y + thickness.Top));
							num = (short)1731526663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 7:
						return;
					case 8:
						goto IL_369;
					}
					goto IL_52;
					IL_A8:
					num = (short)2104295424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A7:
					goto IL_A8;
					IL_369:
					num = (short)1452933121;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_52:
				base.OnRender(dc);
				rect = new global::System.Windows.Rect(base.RenderSize);
				thickness = this.c;
				num = (short)275185669;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00050D44 File Offset: 0x0004EF44
		private global::System.Windows.Rect c()
		{
			short num = (short)1815190833;
			short num2 = num;
			num = (short)433167665;
			global::System.Windows.Rect result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)1286406144;
				short num3 = num;
				break;
			}
			}
			num = (short)1014562816;
			if (num != 0)
			{
			}
			num = (short)117768192;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				num = (short)1972699137;
				if (num != 0)
				{
				}
				result = default(global::System.Windows.Rect);
				global::System.Collections.IEnumerator enumerator = base.Children.GetEnumerator();
				try
				{
					num = (short)1463418885;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)1901789192;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1FB;
						case 2:
							goto IL_218;
						case 3:
							num = (short)386007042;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::DevComponents.WpfDock.DockWindow dockWindow;
							if (dockWindow != null)
							{
								num = (short)1500577792;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_119;
							}
							continue;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1115357187;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
							global::DevComponents.WpfDock.DockWindow dockWindow = uielement as global::DevComponents.WpfDock.DockWindow;
							num = (short)1268449284;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::System.Windows.UIElement uielement;
							result = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(uielement as global::System.Windows.FrameworkElement);
							num = (short)339410945;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::DevComponents.WpfDock.DockWindow dockWindow;
							if (dockWindow.IsSelected)
							{
								num = (short)256311303;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_160:
						num = (short)1501495302;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_119:
						goto IL_160;
					}
					IL_1FB:
					IL_218:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_237;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_224:
						switch (num4)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)874905602;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_28E;
						case 1:
							goto IL_28C;
						case 2:
							disposable.Dispose();
							num = (short)1500708865;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_237;
					}
					IL_28C:
					IL_28E:
					break;
					IL_237:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1238302720;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_224;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00051000 File Offset: 0x0004F200
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static global::DevComponents.WpfDock.eDockTabElementAlignment GetPanelAlignment(global::System.Windows.UIElement element)
		{
			int a_ = 19;
			short num = (short)133834322;
			short num2 = num;
			num = (short)1888560722;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)517472256;
				short num3 = num;
				num = (short)501678080;
				if (num != 0)
				{
				}
				if (element != null)
				{
					return (global::DevComponents.WpfDock.eDockTabElementAlignment)element.GetValue(global::DevComponents.WpfDock.Primitives.DockTabPanel.PanelAlignmentProperty);
				}
				break;
			}
			}
			num = (short)2121531393;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("럑룓돕뗗", a_));
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000510DC File Offset: 0x0004F2DC
		public static void SetPanelAlignment(global::System.Windows.UIElement element, global::DevComponents.WpfDock.eDockTabElementAlignment part)
		{
			int a_ = 2;
			short num = (short)1719879175;
			short num2 = num;
			num = (short)232867335;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1088946176;
				if (num != 0)
				{
				}
				if (element != null)
				{
					num = (short)1067515905;
					if (num != 0)
					{
					}
					element.SetValue(global::DevComponents.WpfDock.Primitives.DockTabPanel.PanelAlignmentProperty, part);
					return;
				}
				break;
			}
			num = (short)221446144;
			short num3 = num;
			throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("꓀꿂ꃄ꫆", a_));
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000511B8 File Offset: 0x0004F3B8
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			int num;
			global::System.Windows.UIElement uielement;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (uielement != null)
						{
							num2 = (short)693108737;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						num2 = (short)1301151745;
						if (num2 != 0)
						{
						}
						global::DevComponents.WpfDock.Primitives.DockTabPanel dockTabPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::DevComponents.WpfDock.Primitives.DockTabPanel;
						num2 = (short)826076095;
						short num3 = num2;
						num2 = (short)651881407;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B;
						default:
							num2 = (short)339214336;
							if (num2 != 0)
							{
							}
							num2 = (short)2068578306;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
					{
						global::DevComponents.WpfDock.Primitives.DockTabPanel dockTabPanel;
						if (dockTabPanel != null)
						{
							num2 = (short)921436164;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 3:
						goto IL_A1;
					case 4:
					{
						global::DevComponents.WpfDock.Primitives.DockTabPanel dockTabPanel;
						dockTabPanel.InvalidateArrange();
						num2 = (short)1776943107;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_24;
				}
				IL_A1:
				num2 = (short)663814144;
				short num4 = num2;
				return;
			}
			}
			IL_24:
			uielement = (A_0 as global::System.Windows.UIElement);
			IL_2B:
			num2 = (short)1721892864;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00051320 File Offset: 0x0004F520
		private static bool a(object A_0)
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
					global::DevComponents.WpfDock.eDockTabElementAlignment eDockTabElementAlignment;
					if (eDockTabElementAlignment != global::DevComponents.WpfDock.eDockTabElementAlignment.Left)
					{
						num2 = (short)285933570;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 1:
				{
					global::DevComponents.WpfDock.eDockTabElementAlignment eDockTabElementAlignment;
					if (eDockTabElementAlignment != global::DevComponents.WpfDock.eDockTabElementAlignment.Right)
					{
						num2 = (short)238026755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 2:
				{
					num2 = (short)954466304;
					short num3 = num2;
					num2 = (short)1572601857;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return false;
				}
				goto IL_20;
			}
			return true;
			IL_20:
			num2 = (short)1323958273;
			if (num2 != 0)
			{
			}
			num2 = (short)269367519;
			short num4 = num2;
			num2 = (short)1256995039;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			default:
			{
				num2 = (short)2109341696;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfDock.eDockTabElementAlignment eDockTabElementAlignment = (global::DevComponents.WpfDock.eDockTabElementAlignment)A_0;
				num2 = (short)1924333568;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00051460 File Offset: 0x0004F660
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0005151C File Offset: 0x0004F71C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderInnerBrush
		{
			get
			{
				short num = (short)2076901376;
				short num2 = num;
				num = (short)603591910;
				short num3 = num;
				num = (short)257103078;
				switch (num3 == num)
				{
				}
				num = (short)918945793;
				if (num != 0)
				{
				}
				num = (short)1128136704;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfDock.Primitives.DockTabPanel.BorderInnerBrushProperty);
			}
			set
			{
				short num = (short)1148321792;
				short num2 = num;
				num = (short)535298049;
				if (num != 0)
				{
				}
				num = (short)237061670;
				short num3 = num;
				num = (short)2036680230;
				switch (num3 == num)
				{
				}
				num = (short)1895628800;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.Primitives.DockTabPanel.BorderInnerBrushProperty, value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000515D0 File Offset: 0x0004F7D0
		// (set) Token: 0x06000355 RID: 853 RVA: 0x0005168C File Offset: 0x0004F88C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)1936064512;
				short num2 = num;
				num = (short)303366145;
				if (num != 0)
				{
				}
				num = (short)1284749429;
				short num3 = num;
				num = (short)1345042549;
				switch (num3 == num)
				{
				}
				num = (short)1679032320;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfDock.Primitives.DockTabPanel.BorderBrushProperty);
			}
			set
			{
				short num = (short)746389504;
				short num2 = num;
				num = (short)430449393;
				short num3 = num;
				num = (short)1241981681;
				switch (num3 == num)
				{
				}
				num = (short)1659568128;
				if (num != 0)
				{
				}
				num = (short)1058340865;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.Primitives.DockTabPanel.BorderBrushProperty, value);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00051744 File Offset: 0x0004F944
		// (set) Token: 0x06000357 RID: 855 RVA: 0x000517FC File Offset: 0x0004F9FC
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BackgroundInner
		{
			get
			{
				short num = (short)1803747328;
				short num2 = num;
				num = (short)1791107137;
				short num3 = num;
				num = (short)786440257;
				switch (num3 == num)
				{
				}
				num = (short)1866792960;
				if (num != 0)
				{
				}
				num = (short)2086141953;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfDock.Primitives.DockTabPanel.BackgroundInnerProperty);
			}
			set
			{
				short num = (short)1654784000;
				short num2 = num;
				num = (short)300526887;
				short num3 = num;
				num = (short)2145365287;
				switch (num3 == num)
				{
				}
				num = (short)1527054337;
				if (num != 0)
				{
				}
				num = (short)603389952;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.Primitives.DockTabPanel.BackgroundInnerProperty, value);
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000518B4 File Offset: 0x0004FAB4
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1602093056;
			short num2 = num;
			num = (short)624412221;
			short num3 = num;
			num = (short)1400489533;
			switch (num3 == num)
			{
			}
			num = (short)1474428929;
			if (num != 0)
			{
			}
			num = (short)1177157632;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfDock.Primitives.DockTabPanel)A_0).b();
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00051968 File Offset: 0x0004FB68
		private void b()
		{
			switch (0)
			{
			case 0:
				goto IL_67;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)2032255063;
				short num2 = num;
				num = (short)1297662039;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1470234624;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (this.BorderBrush != null)
						{
							num = (short)349569024;
							short num4 = num;
							num = (short)1069940737;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_CF;
					case 2:
						return;
					}
					goto IL_67;
				}
				IL_CF:
				this.d = new global::System.Windows.Media.Pen(this.BorderBrush, 1.0);
				num = (short)136183809;
				if (num != 0)
				{
				}
				num = (short)1394933762;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_67:
			this.d = null;
			num = (short)932904960;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00051AA0 File Offset: 0x0004FCA0
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)654901248;
			short num2 = num;
			num = (short)863503939;
			short num3 = num;
			num = (short)352978499;
			switch (num3 == num)
			{
			}
			num = (short)676003841;
			if (num != 0)
			{
			}
			num = (short)1708261376;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfDock.Primitives.DockTabPanel)A_0).a();
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00051B54 File Offset: 0x0004FD54
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_8D;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)2080559605;
				short num2 = num;
				num = (short)1022284277;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1204224001;
					if (num != 0)
					{
					}
					num = (short)666370048;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)1515061248;
						short num4 = num;
						if (this.BorderInnerBrush != null)
						{
							num = (short)1494614017;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
						goto IL_F9;
					case 2:
						return;
					}
					goto IL_8D;
				}
				IL_F9:
				this.e = new global::System.Windows.Media.Pen(this.BorderInnerBrush, 1.0);
				num = (short)1642659842;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_8D:
			this.e = null;
			num = (short)573505536;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00051C90 File Offset: 0x0004FE90
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)532873216;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
					{
						num = (short)1776040755;
						short num3 = num;
						num = (short)1038236467;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						case 1:
							break;
						default:
						{
							num = (short)25493504;
							short num4 = num;
							break;
						}
						}
						num = (short)991494145;
						if (num != 0)
						{
						}
						num = (short)410779648;
						if (num != 0)
						{
						}
						((global::DevComponents.WpfDock.Primitives.DockTabPanel)A_0).a(A_1.OriginalSource as global::DevComponents.WpfDock.DockWindow);
						num = (short)1401290754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					}
					IL_31:
					if (!(A_0 is global::DevComponents.WpfDock.Primitives.DockTabPanel))
					{
						return;
					}
					num = (short)370540545;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00051DB8 File Offset: 0x0004FFB8
		private void a(global::DevComponents.WpfDock.DockWindow A_0)
		{
			for (;;)
			{
				IL_00:
				short num = (short)2082603008;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
					{
						num = (short)1111228416;
						short num3 = num;
						num = (short)1032690598;
						short num4 = num;
						num = (short)1974115238;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1275199488;
							if (num != 0)
							{
							}
							base.InvalidateVisual();
							num = (short)2138767362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						return;
					}
					IL_30:
					num = (short)617021441;
					if (num != 0)
					{
					}
					if (this.BackgroundInner == null)
					{
						return;
					}
					num = (short)121634817;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x04000205 RID: 517
		public static readonly global::System.Windows.DependencyProperty PanelAlignmentProperty;

		// Token: 0x04000206 RID: 518
		public static readonly global::System.Windows.DependencyProperty BorderInnerBrushProperty;

		// Token: 0x04000207 RID: 519
		public static readonly global::System.Windows.DependencyProperty BackgroundInnerProperty;

		// Token: 0x04000208 RID: 520
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x04000209 RID: 521
		private double a;

		// Token: 0x0400020A RID: 522
		private double b;

		// Token: 0x0400020B RID: 523
		private global::System.Windows.Thickness c = new global::System.Windows.Thickness(3.0, 4.0, 3.0, 0.0);

		// Token: 0x0400020C RID: 524
		private global::System.Windows.Media.Pen d;

		// Token: 0x0400020D RID: 525
		private global::System.Windows.Media.Pen e;
	}
}
