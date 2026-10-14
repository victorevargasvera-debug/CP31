using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfDock.Converters;
using DevComponents.WpfDock.Primitives;

namespace DevComponents.WpfDock
{
	// Token: 0x02000020 RID: 32
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_SplitterBorder", Type = typeof(global::System.Windows.Controls.Decorator))]
	public class DockSplitter : global::System.Windows.Controls.Control
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00029660 File Offset: 0x00027860
		static DockSplitter()
		{
			int a_ = 8;
			short num = (short)1288782994;
			short num2 = num;
			num = (short)478168210;
			switch (num2 == num)
			{
			}
			num = (short)417857537;
			if (num != 0)
			{
			}
			num = (short)372965376;
			if (num != 0)
			{
			}
			num = (short)655360;
			short num3 = num;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfDock.DockSplitter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfDock.DockSplitter)));
			global::DevComponents.WpfDock.DockSplitter.OrientationProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("裆믈ꋊ꣌ꇎꗐ닒ꇔ뻖뛘뗚", a_), typeof(global::System.Windows.Controls.Orientation), typeof(global::DevComponents.WpfDock.DockSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0002976C File Offset: 0x0002796C
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00029824 File Offset: 0x00027A24
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				short num = (short)1521966961;
				short num2 = num;
				num = (short)936927089;
				switch (num2 == num)
				{
				}
				num = (short)298319873;
				if (num != 0)
				{
				}
				num = (short)1369899008;
				if (num != 0)
				{
				}
				num = (short)1347092480;
				short num3 = num;
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::DevComponents.WpfDock.DockSplitter.OrientationProperty);
			}
			set
			{
				short num = (short)158598002;
				short num2 = num;
				num = (short)1190331250;
				switch (num2 == num)
				{
				}
				num = (short)1546256385;
				if (num != 0)
				{
				}
				num = (short)635371520;
				if (num != 0)
				{
				}
				num = (short)173211648;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockSplitter.OrientationProperty, value);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000298DC File Offset: 0x00027ADC
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1301282820;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.b();
					e.Handled = true;
					num = (short)1897201666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)460259329;
					if (num != 0)
					{
					}
					num = (short)2101346307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_AB;
				case 3:
				{
					if (e.ButtonState != global::System.Windows.Input.MouseButtonState.Pressed)
					{
						goto IL_163;
					}
					num = (short)2014052352;
					short num3 = num;
					num = (short)976575774;
					short num4 = num;
					num = (short)905665822;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AB;
					default:
						num = (short)1137967104;
						if (num != 0)
						{
						}
						num = (short)813760512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				if (e.ChangedButton != global::System.Windows.Input.MouseButton.Left)
				{
					break;
				}
				num = (short)1450508289;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AB:
			IL_163:
			base.OnMouseDown(e);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00029A54 File Offset: 0x00027C54
		private void b()
		{
			short num = (short)913178624;
			switch (num)
			{
			default:
			{
				num = (short)97386513;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.UIElement leftControl;
					double num3;
					global::System.Windows.Size size;
					global::System.Windows.Controls.Dock dock;
					switch (num2)
					{
					case 0:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						if (dockSite != null)
						{
							num = (short)1240334343;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					}
					case 1:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						if (dockSite != null)
						{
							num = (short)767164437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)350617616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Windows.UIElement uielement;
						if (uielement != null)
						{
							num = (short)530972704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FB;
					}
					case 3:
					{
						global::System.Windows.UIElement uielement;
						bool flag = uielement is global::DevComponents.WpfDock.Primitives.b;
						global::DevComponents.WpfDock.DockSite dockSite = uielement as global::DevComponents.WpfDock.DockSite;
						if (flag)
						{
							num = (short)779747333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17C;
					}
					case 4:
						return;
					case 5:
					{
						global::System.Windows.UIElement uielement;
						global::DevComponents.WpfDock.DockSite dockSite = ((global::DevComponents.WpfDock.Primitives.b)uielement).c().GetDockSite();
						num = (short)1740439580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (this.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
						{
							num = (short)861339681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e = -(int)(leftControl.RenderSize.Width - num3);
						num = (short)1626537994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						size = dockSite.l();
						num = (short)1164378126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_13F;
					case 9:
						goto IL_67C;
					case 10:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						if (dockSite != null)
						{
							num = (short)1113849874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1228472322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
						{
							num = (short)1995964440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement leftControl2;
						this.e = -(int)(leftControl2.RenderSize.Height - num3);
						global::System.Windows.UIElement rightControl;
						this.f = (int)(rightControl.RenderSize.Height - num3);
						num = (short)20774932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						this.f = global::System.Math.Max(0, (int)(dockSite.RenderSize.Height - leftControl.RenderSize.Height - size.Height));
						num = (short)1700986903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						leftControl = this.LeftControl;
						global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetParent(leftControl) as global::System.Windows.UIElement;
						num = (short)1705246723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_43A;
					case 15:
						goto IL_4FB;
					case 16:
					{
						global::System.Windows.UIElement uielement;
						if (uielement != null)
						{
							num = (short)408158242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					}
					case 17:
						switch (0)
						{
						case 0:
							goto IL_D9;
						}
						continue;
					case 18:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						this.f = (int)(dockSite.RenderSize.Width - num3 - size.Width);
						num = (short)1515978767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_2FC;
					case 20:
						goto IL_3F6;
					case 21:
						num = (short)1200619542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						if (dock == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)682557452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfDock.DockSite dockSite;
						this.f = (int)(dockSite.RenderSize.Height - num3 - size.Height);
						num = (short)1233649699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)377749505;
						if (num != 0)
						{
						}
						goto IL_13F;
					case 24:
					{
						global::System.Windows.UIElement leftControl2;
						this.e = -(int)(leftControl2.RenderSize.Width - num3);
						global::System.Windows.UIElement rightControl;
						this.f = (int)(rightControl.RenderSize.Width - num3);
						num = (short)1841233939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (dock == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)934150171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B4;
					case 26:
						goto IL_212;
					case 27:
					{
						int num4 = -this.f;
						this.f = -this.e;
						this.e = num4;
						num = (short)1305477146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						goto IL_17C;
					case 29:
					{
						num = (short)530550255;
						short num5 = num;
						num = (short)641502703;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17C;
						default:
							num = (short)1858338816;
							if (num != 0)
							{
							}
							goto IL_4FB;
						}
						break;
					}
					case 30:
					{
						int num6 = -this.f;
						this.f = -this.e;
						this.e = num6;
						num = (short)163840009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						if (this.RightControl == null)
						{
							num = (short)1466957837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement leftControl2 = this.LeftControl;
						global::System.Windows.UIElement rightControl = this.RightControl;
						num = (short)1777926155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
					{
						global::System.Windows.UIElement uielement;
						this.f = (int)(uielement.RenderSize.Width - num3);
						num = (short)2137718813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						this.e = -(int)(leftControl.RenderSize.Height - num3);
						num = (short)727056385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						global::System.Windows.UIElement uielement;
						this.f = (int)(uielement.RenderSize.Height - num3);
						num = (short)331677704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						goto IL_13F;
					case 36:
						if (dock == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)1935212574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B4;
					}
					IL_D9:
					if (!global::System.Windows.Input.Mouse.Capture(this))
					{
						num = (short)1020067844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)365428736;
					short num7 = num;
					num3 = 21.0;
					num = (short)892534815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13F:
					num = (short)2056519716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17C:
					dock = global::DevComponents.WpfDock.DockSite.GetDock(leftControl);
					size = new global::System.Windows.Size(32.0, 32.0);
					num = (short)139001856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43A:
					num = (short)609419270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4FB:
					num = (short)1767440409;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_212:
				IL_2FC:
				IL_3F6:
				IL_67C:
				IL_7B4:
				this.c = new global::DevComponents.WpfDock.Primitives.e(this);
				this.c.c(base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfDock.DockSite), global::DevComponents.WpfDock.DockColors.DockSplitterPreviewBrush)) as global::System.Windows.Media.Brush);
				global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this).Add(this.c);
				this.d = true;
				return;
			}
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0002A264 File Offset: 0x00028464
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1657536522;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				double num3;
				double num4;
				switch (num2)
				{
				case 0:
				{
					global::System.Windows.Point position = e.GetPosition(this);
					num = (short)1557266438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num3 = (double)this.e;
					num = (short)1014300675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1C0;
				case 3:
					goto IL_12D;
				case 4:
					num3 = (double)this.f;
					num = (short)2147287045;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_12D;
				case 6:
					if (this.Orientation != global::System.Windows.Controls.Orientation.Horizontal)
					{
						num = (short)887947266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)692977672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (num3 > (double)this.f)
					{
						num = (short)1026031620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12D;
				case 8:
				{
					global::System.Windows.Point position;
					num4 = position.Y;
					goto IL_1EA;
				}
				case 9:
				{
					if (num3 >= (double)this.e)
					{
						num = (short)352387079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2104566435;
					short num5 = num;
					num = (short)768090787;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C0;
					default:
						num = (short)973799424;
						if (num != 0)
						{
						}
						num = (short)1335492609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 11:
					goto IL_179;
				case 12:
				{
					num = (short)1632436224;
					short num6 = num;
					global::System.Windows.Point position;
					num4 = position.X;
					goto IL_1EA;
				}
				}
				IL_59:
				if (this.d)
				{
					num = (short)797179904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_12D:
				num = (short)1926037505;
				if (num != 0)
				{
				}
				this.c.c(num3);
				num = (short)726269963;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C0:
				num = (short)175374348;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EA:
				num3 = num4;
				num = (short)1511456777;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_179:
			base.OnMouseMove(e);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0002A518 File Offset: 0x00028718
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)545456130;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)373424128;
					short num3 = num;
					num = (short)2000224257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (e.Key == global::System.Windows.Input.Key.Escape)
					{
						num = (short)419561473;
						if (num != 0)
						{
						}
						num = (short)2049441795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14E;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
					base.ReleaseMouseCapture();
					goto IL_89;
				case 4:
				{
					num = (short)1360103498;
					short num4 = num;
					num = (short)1820493898;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_89;
					default:
						goto IL_D3;
					}
					break;
				}
				}
				IL_38:
				if (this.d)
				{
					num = (short)653721600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_14E;
				IL_89:
				num = (short)1484849156;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D3:
			num = (short)1097990144;
			if (num != 0)
			{
			}
			IL_14E:
			base.OnKeyUp(e);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0002A67C File Offset: 0x0002887C
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1892745218;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1581252608;
					short num3 = num;
					num = (short)1433010177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Released)
					{
						num = (short)1816002563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15B;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
					this.a();
					base.ReleaseMouseCapture();
					goto IL_91;
				case 4:
				{
					num = (short)180117757;
					short num4 = num;
					num = (short)1163026685;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						goto IL_105;
					}
					break;
				}
				}
				IL_38:
				if (this.d)
				{
					num = (short)1190133760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_15B;
				IL_91:
				num = (short)372768769;
				if (num != 0)
				{
				}
				num = (short)493682692;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_105:
			num = (short)1318977536;
			if (num != 0)
			{
			}
			IL_15B:
			base.OnMouseUp(e);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0002A7EC File Offset: 0x000289EC
		private void a()
		{
			int a_ = 1;
			short num = (short)1750401024;
			switch (num)
			{
			default:
			{
				num = (short)9371690;
				int num2 = (int)((global::System.IntPtr)num);
				global::DevComponents.WpfDock.Primitives.b b;
				global::DevComponents.WpfDock.SplitPanel splitPanel;
				double num3;
				global::System.Windows.Controls.Primitives.Popup popup;
				double num6;
				global::System.Windows.UIElement leftControl2;
				double dockSize;
				for (;;)
				{
					global::System.Windows.UIElement leftControl;
					global::System.Windows.UIElement rightControl;
					global::System.Windows.Size size;
					global::System.Windows.Size size2;
					double num4;
					double num9;
					switch (num2)
					{
					case 0:
						b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.b, null);
						num = (short)1009713181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (this.RightControl == null)
						{
							num = (short)1960116263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						leftControl = this.LeftControl;
						rightControl = this.RightControl;
						size = default(global::System.Windows.Size);
						size2 = default(global::System.Windows.Size);
						global::System.Windows.Size relativeSize = global::DevComponents.WpfDock.SplitPanel.GetRelativeSize(leftControl);
						global::System.Windows.Size relativeSize2 = global::DevComponents.WpfDock.SplitPanel.GetRelativeSize(rightControl);
						num = (short)1035337739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1304821761;
						if (num != 0)
						{
						}
						splitPanel.Height = num3;
						num = (short)2095251480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock != global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)172752909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_974;
					}
					case 4:
						goto IL_A77;
					case 5:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock != global::System.Windows.Controls.Dock.Top)
						{
							num = (short)1873281030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E4;
					}
					case 6:
						num = (short)351535148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num4 = splitPanel.Height;
						goto IL_6A2;
					case 8:
						goto IL_7EB;
					case 9:
						goto IL_974;
					case 10:
						if (popup != null)
						{
							num = (short)209190960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C7;
					case 11:
					{
						if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
						{
							num = (short)431161362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double num5 = (leftControl.RenderSize.Height + num6) / leftControl.RenderSize.Height;
						global::System.Windows.Size relativeSize;
						size = new global::System.Windows.Size(relativeSize.Width, global::System.Math.Round(relativeSize.Height * num5));
						num5 = (rightControl.RenderSize.Height - num6) / rightControl.RenderSize.Height;
						global::System.Windows.Size relativeSize2;
						size2 = new global::System.Windows.Size(relativeSize2.Width, global::System.Math.Round(relativeSize2.Height * num5));
						num = (short)1955201028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_248;
					case 13:
						num = (short)603717663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.c, null);
						num = (short)1885798408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)1286406169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 16:
						goto IL_6F0;
					case 17:
						if (((global::DevComponents.WpfDock.SplitPanel)leftControl2).Parent is global::DevComponents.WpfDock.Primitives.b)
						{
							num = (short)1183776811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_159;
					case 18:
					{
						double num5 = (leftControl.RenderSize.Width + num6) / leftControl.RenderSize.Width;
						global::System.Windows.Size relativeSize;
						size = new global::System.Windows.Size(global::System.Math.Round(relativeSize.Width * num5), relativeSize.Height);
						num5 = (rightControl.RenderSize.Width - num6) / rightControl.RenderSize.Width;
						global::System.Windows.Size relativeSize2;
						size2 = new global::System.Windows.Size(global::System.Math.Round(relativeSize2.Width * num5), relativeSize2.Height);
						num = (short)763232275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_A77;
					case 20:
						if (popup != null)
						{
							num = (short)1314914342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E3;
					case 21:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock == global::System.Windows.Controls.Dock.Top)
						{
							num = (short)254410789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)377159725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_248;
					case 23:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock == global::System.Windows.Controls.Dock.Left)
						{
							num = (short)2010382385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1305214991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (b.HasAnimatedProperties)
						{
							num = (short)321912832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F5;
					case 25:
					{
						splitPanel.Width = num3;
						num = (short)982581248;
						short num7 = num;
						num = (short)1335689252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_B7E;
					case 27:
						num = (short)71892997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						if (popup != null)
						{
							num = (short)822607919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)495158566;
						short num8 = num;
						num = (short)1001817382;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5A3;
						default:
							goto IL_7A0;
						}
						break;
					}
					case 29:
						goto IL_3F5;
					case 30:
						b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.a, null);
						num = (short)1844576272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)1280638985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = num9 + num6;
						num = (short)978321430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						goto IL_42D;
					case 33:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)1912602650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_829;
					}
					case 34:
						b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.d, null);
						num = (short)26673202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_AA1;
					case 36:
						if (b.HasAnimatedProperties)
						{
							num = (short)1247936542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F0;
					case 37:
						splitPanel.Height = num3;
						num = (short)1244463144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_3B6;
					case 39:
					{
						leftControl2 = this.LeftControl;
						global::System.Windows.Controls.Dock dock = global::DevComponents.WpfDock.DockSite.GetDock(leftControl2);
						num = (short)433979447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						if (b.HasAnimatedProperties)
						{
							num = (short)1294336034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37F;
					case 41:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock != global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)420741147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E4;
					}
					case 42:
						switch (0)
						{
						case 0:
							goto IL_131;
						}
						continue;
					case 43:
						splitPanel = (leftControl2 as global::DevComponents.WpfDock.SplitPanel);
						num3 = 0.0;
						num = (short)792985641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num4 = splitPanel.Width;
						goto IL_6A2;
					case 45:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)263061506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)995098647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						num = (short)1496580129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_824;
					case 48:
						goto IL_727;
					case 49:
						splitPanel.Width = num3;
						num = (short)1217921080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						goto IL_37F;
					case 51:
						if (popup != null)
						{
							num = (short)348127264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36D;
					case 52:
						num = (short)2104819729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock != global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)1881407534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D9;
					}
					case 54:
						goto IL_154;
					case 55:
						if (leftControl2 is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1438515252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_159;
					case 56:
						goto IL_5A3;
					}
					IL_131:
					if (this.c == null)
					{
						num = (short)572391478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num6 = this.c.e();
					num = (short)1742864385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_159:
					dockSize = global::DevComponents.WpfDock.DockSite.GetDockSize(leftControl2);
					num = (short)554827829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E4:
					num = (short)100859911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_248:
					b = (splitPanel.Parent as global::DevComponents.WpfDock.Primitives.b);
					popup = (b.Parent as global::System.Windows.Controls.Primitives.Popup);
					num = (short)1612185621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37F:
					num = (short)1940389908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F5:
					num = (short)2077950003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A3:
					if (b.HasAnimatedProperties)
					{
						num = (short)73334798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7EB;
					IL_6A2:
					num9 = num4;
					num = (short)622854147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F0:
					num = (short)822083594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7EB:
					num = (short)1247543324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_974:
					num3 = num9 - num6;
					num = (short)813105164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A77:
					global::DevComponents.WpfDock.SplitPanel.SetRelativeSize(leftControl, size);
					global::DevComponents.WpfDock.SplitPanel.SetRelativeSize(rightControl, size2);
					num = (short)721485859;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_154:
				throw new global::System.InvalidOperationException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鎿닁ꣃ꿅볇뻉꧋볍苑ꛓ돕껗동맛꧝샟ꏡ胣觥髧蓩觫鳭탯鳱至髵铷퓹\udcfb뷽懿氁樃椅簇⨉洋縍怏縑洓㘕樗缙漛眝娟䜡", a_));
				IL_1C7:
				global::DevComponents.WpfDock.Primitives.a.d(b, global::DevComponents.WpfDock.Primitives.a.c(b) - num3);
				return;
				IL_1D9:
				global::DevComponents.WpfDock.DockSite.SetDockSize(leftControl2, dockSize - num6);
				return;
				IL_36D:
				global::DevComponents.WpfDock.Primitives.a.e(b, global::DevComponents.WpfDock.Primitives.a.b(b) - num3);
				return;
				IL_3B6:
				b.Height = splitPanel.Height;
				return;
				IL_3E3:
				global::DevComponents.WpfDock.Primitives.a.b(b, global::DevComponents.WpfDock.Primitives.a.e(b) + num3);
				return;
				IL_42D:
				popup.VerticalOffset += num6;
				b.Height = splitPanel.Height;
				return;
				IL_727:
				popup.HorizontalOffset += num6;
				b.Width = splitPanel.Width;
				return;
				IL_7A0:
				num = (short)735510528;
				if (num != 0)
				{
				}
				global::DevComponents.WpfDock.Primitives.a.c(b, global::DevComponents.WpfDock.Primitives.a.d(b) + num3);
				return;
				IL_824:
				b.Width = splitPanel.Width;
				return;
				IL_829:
				global::DevComponents.WpfDock.DockSite.SetDockSize(leftControl2, dockSize + num6);
				return;
				IL_AA1:
				return;
				IL_B7E:
				goto IL_1D9;
			}
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0002B37C File Offset: 0x0002957C
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)2054619136;
			short num2 = num;
			num = (short)1863450625;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1641582396;
				short num4 = num;
				num = (short)537235260;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)196542464;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)1996226561;
						if (num != 0)
						{
						}
						goto IL_EB;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 2:
						goto IL_12D;
					}
					IL_A4:
					if (this.d)
					{
						num = (short)892534784;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12F;
				}
				IL_EB:
				this.d = false;
				global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this).Remove(this.c);
				this.c.c(null);
				this.c = null;
				num = (short)1249640450;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_12D:
			IL_12F:
			base.OnLostMouseCapture(e);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0002B4C0 File Offset: 0x000296C0
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0002B570 File Offset: 0x00029770
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.UIElement LeftControl
		{
			get
			{
				short num = (short)739401836;
				short num2 = num;
				num = (short)775905388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1546518528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1068302337;
				if (num != 0)
				{
				}
				num = (short)240779264;
				if (num != 0)
				{
				}
				return this.a;
			}
			internal set
			{
				short num = (short)913211900;
				short num2 = num;
				num = (short)1820819964;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1309933568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)853934081;
				if (num != 0)
				{
				}
				num = (short)497942528;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0002B61C File Offset: 0x0002981C
		// (set) Token: 0x0600014F RID: 335 RVA: 0x0002B6CC File Offset: 0x000298CC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::System.Windows.UIElement RightControl
		{
			get
			{
				short num = (short)2007733615;
				short num2 = num;
				num = (short)1286968687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)216203264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661061633;
				if (num != 0)
				{
				}
				num = (short)1958608896;
				if (num != 0)
				{
				}
				return this.b;
			}
			internal set
			{
				short num = (short)2046629243;
				short num2 = num;
				num = (short)1801590139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2024538112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)200081409;
				if (num != 0)
				{
				}
				num = (short)1107296256;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x040000D3 RID: 211
		public static readonly global::System.Windows.DependencyProperty OrientationProperty;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.UIElement a;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.UIElement b;

		// Token: 0x040000D6 RID: 214
		private global::DevComponents.WpfDock.Primitives.e c;

		// Token: 0x040000D7 RID: 215
		private bool d;

		// Token: 0x040000D8 RID: 216
		private int e;

		// Token: 0x040000D9 RID: 217
		private int f;
	}
}
