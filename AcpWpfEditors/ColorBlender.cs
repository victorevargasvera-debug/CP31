using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000003 RID: 3
	[global::System.ComponentModel.DesignTimeVisible(true)]
	public class ColorBlender : global::System.Windows.Controls.Control
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000214C File Offset: 0x0000034C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_8D;
			}
			short num;
			int num3;
			global::DevComponents.WpfEditors.ColorBlender colorBlender;
			for (;;)
			{
				IL_0A:
				num = (short)2062443809;
				short num2 = num;
				num = (short)2102224161;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)391053312;
					if (num != 0)
					{
					}
					num = (short)62717953;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)1379270656;
						short num4 = num;
						if (colorBlender != null)
						{
							num = (short)1283260417;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
						goto IL_F2;
					case 2:
						return;
					}
					goto IL_8D;
				}
				IL_F2:
				colorBlender.OnSelectedColorChanged((global::System.Windows.Media.Color?)A_1.OldValue, (global::System.Windows.Media.Color?)A_1.NewValue);
				num = (short)46006274;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_8D:
			colorBlender = (A_0 as global::DevComponents.WpfEditors.ColorBlender);
			num = (short)826474496;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002284 File Offset: 0x00000484
		protected virtual void OnSelectedColorChanged(global::System.Windows.Media.Color? oldValue, global::System.Windows.Media.Color? newValue)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1504575488;
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
						num = (short)1269170177;
						if (num != 0)
						{
						}
						num = (short)234618880;
						short num3 = num;
						num = (short)1556311933;
						short num4 = num;
						num = (short)866742141;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)2094923776;
							if (num != 0)
							{
							}
							this.b(new global::System.Windows.Point(-1.0, -1.0));
							num = (short)1909063682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_125;
					}
					IL_30:
					if (newValue != null)
					{
						goto IL_127;
					}
					num = (short)440664065;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_125:
			IL_127:
			this.OnSelectedColorChanged();
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000023C0 File Offset: 0x000005C0
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000247C File Offset: 0x0000067C
		[global::System.ComponentModel.Category("Appearance")]
		public global::System.Windows.Media.Color? SelectedColor
		{
			get
			{
				short num = (short)1104740352;
				short num2 = num;
				num = (short)1946558505;
				short num3 = num;
				num = (short)382279721;
				switch (num3 == num)
				{
				}
				num = (short)1915027457;
				if (num != 0)
				{
				}
				num = (short)1426718720;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Color?)base.GetValue(global::DevComponents.WpfEditors.ColorBlender.SelectedColorProperty);
			}
			set
			{
				short num = (short)1066139648;
				short num2 = num;
				num = (short)1120626025;
				short num3 = num;
				num = (short)1418225001;
				switch (num3 == num)
				{
				}
				num = (short)2082013185;
				if (num != 0)
				{
				}
				num = (short)1728446464;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorBlender.SelectedColorProperty, value);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000008 RID: 8 RVA: 0x0000253C File Offset: 0x0000073C
		// (remove) Token: 0x06000009 RID: 9 RVA: 0x000025F0 File Offset: 0x000007F0
		public event global::System.Windows.RoutedEventHandler SelectedColorChanged
		{
			add
			{
				short num = (short)237436929;
				if (num != 0)
				{
				}
				num = (short)1223870528;
				short num2 = num;
				num = (short)71878720;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1586429952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)979632128;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.ColorBlender.SelectedColorChangedEvent, value);
			}
			remove
			{
				short num = (short)1384346701;
				short num2 = num;
				num = (short)590771277;
				switch (num2 == num)
				{
				}
				num = (short)1487142912;
				short num3 = num;
				num = (short)1097138177;
				if (num != 0)
				{
				}
				num = (short)5439488;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.ColorBlender.SelectedColorChangedEvent, value);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000026A4 File Offset: 0x000008A4
		protected virtual void OnSelectedColorChanged()
		{
			short num = (short)937903066;
			short num2 = num;
			num = (short)146555866;
			switch (num2 == num)
			{
			}
			num = (short)1535377408;
			short num3 = num;
			num = (short)52101121;
			if (num != 0)
			{
			}
			num = (short)876281856;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.ColorBlender.SelectedColorChangedEvent);
			base.RaiseEvent(e);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002760 File Offset: 0x00000960
		static ColorBlender()
		{
			int a_ = 14;
			short num = (short)1199015083;
			short num2 = num;
			num = (short)140936363;
			switch (num2 == num)
			{
			}
			num = (short)241369088;
			short num3 = num;
			num = (short)1873936385;
			if (num != 0)
			{
			}
			num = (short)1922039808;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.ColorBlender.SelectedColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("裚룜돞蓠胢釤苦跨꣪苬菮黰臲", a_), typeof(global::System.Windows.Media.Color?), typeof(global::DevComponents.WpfEditors.ColorBlender), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.ColorBlender.a)));
			global::DevComponents.WpfEditors.ColorBlender.SelectedColorChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("裚룜돞蓠胢釤苦跨꣪苬菮黰臲뛴鿶飸闺髼髾攀", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.ColorBlender));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.ColorBlender), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.ColorBlender)));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000028A0 File Offset: 0x00000AA0
		public override void OnApplyTemplate()
		{
			int a_ = 14;
			short num = (short)1640716756;
			short num2 = num;
			num = (short)1791842772;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B5:
				if (this.a == null)
				{
					goto IL_124;
				}
				num = (short)1362100225;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1818558464;
				if (num != 0)
				{
				}
				num = (short)1667432448;
				short num4 = num;
				switch (0)
				{
				case 0:
					goto IL_99;
				}
				break;
			}
			}
			for (;;)
			{
				IL_87:
				switch (num3)
				{
				case 0:
					goto IL_B5;
				case 1:
					num = (short)1475674113;
					if (num != 0)
					{
					}
					this.a.Source = null;
					num = (short)893452290;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_122;
				}
				goto IL_99;
			}
			IL_122:
			goto IL_124;
			IL_99:
			base.OnApplyTemplate();
			num = (short)63766528;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_87;
			IL_124:
			this.a = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("诚鳜跞뗠볢곤諦裨質裬", a_)) as global::System.Windows.Controls.Image);
			this.b = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("诚鳜跞뗠볢꣤蛦鯨胪裬鷮", a_)) as global::System.Windows.Controls.Border);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002A10 File Offset: 0x00000C10
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)951109887;
			short num2 = num;
			num = (short)1090242815;
			switch (num2 == num)
			{
			}
			num = (short)1085079552;
			short num3 = num;
			num = (short)1053097985;
			if (num != 0)
			{
			}
			num = (short)1252786176;
			if (num != 0)
			{
			}
			global::System.Windows.Point position = e.GetPosition(this);
			this.b(position);
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002ACC File Offset: 0x00000CCC
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)194772992;
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
					global::System.Windows.Point position = e.GetPosition(this);
					this.b(position);
					num = (short)2023489538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_116;
				}
				IL_31:
				num = (short)487961800;
				short num3 = num;
				num = (short)1054061768;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)100139009;
					if (num != 0)
					{
					}
					num = (short)737542144;
					if (num != 0)
					{
					}
					num = (short)524156928;
					short num4 = num;
					if (e.LeftButton != global::System.Windows.Input.MouseButtonState.Pressed)
					{
						goto IL_118;
					}
					break;
				}
				}
				num = (short)1036517377;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_116:
			IL_118:
			base.OnMouseMove(e);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002BF8 File Offset: 0x00000DF8
		private void b(global::System.Windows.Point A_0)
		{
			short num = (short)1633943552;
			switch (num)
			{
			default:
			{
				num = (short)1061814274;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					switch (num2)
					{
					case 0:
						IL_1C3:
						if (A_0.X == -1.0)
						{
							num = (short)756350985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2019098629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						obj = (A_0.Y == -1.0);
						goto IL_23A;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_79;
						}
						continue;
					case 3:
						return;
					case 4:
					{
						global::System.Windows.Media.Imaging.BitmapSource bitmapSource;
						if (bitmapSource == null)
						{
							num = (short)2053046275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)816644096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						obj = 0;
						goto IL_23A;
					case 6:
					{
						num = (short)227278848;
						short num3 = num;
						num = (short)1426128906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_108;
					case 8:
						goto IL_3E5;
					case 9:
						num = (short)264568833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						if (this.c == A_0)
						{
							num = (short)1323237383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
						global::System.Windows.Media.Imaging.BitmapSource bitmapSource = this.a.Source as global::System.Windows.Media.Imaging.BitmapSource;
						num = (short)1681457156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_36A;
					case 12:
						this.SelectedColor = null;
						num = (short)345767947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_79:
					if (this.a != null)
					{
						num = (short)442171398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_108:
					num = (short)447125348;
					short num4 = num;
					num = (short)1329305444;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C3;
					default:
						goto IL_13F;
					}
					IL_23A:
					object obj2 = obj;
					if (obj2 == null)
					{
						global::System.Windows.Rect rect;
						if (global::System.Math.Ceiling(A_0.X) >= global::System.Math.Floor(rect.Width))
						{
							A_0.X = rect.Width - 1.0;
						}
						if (global::System.Math.Ceiling(A_0.Y) >= global::System.Math.Floor(rect.Height))
						{
							A_0.Y = rect.Height - 1.0;
						}
						if (A_0.X < 0.0)
						{
							A_0.X = 0.0;
						}
						if (A_0.Y < 0.0)
						{
							A_0.Y = 0.0;
						}
					}
					this.a(A_0);
					if (obj2 != null)
					{
						num = (short)750583809;
						if (num != 0)
						{
						}
						num = (short)1353449484;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						byte[] array = new byte[4];
						global::System.Windows.Media.Imaging.BitmapSource bitmapSource;
						int stride = (bitmapSource.PixelWidth * bitmapSource.Format.BitsPerPixel + 7) / 8;
						bitmapSource.CopyPixels(new global::System.Windows.Int32Rect((int)A_0.X, (int)A_0.Y, 1, 1), array, stride, 0);
						this.SelectedColor = new global::System.Windows.Media.Color?(global::System.Windows.Media.Color.FromArgb(array[3], array[2], array[1], array[0]));
						num = (short)336199688;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_13F:
				num = (short)864288768;
				if (num != 0)
				{
				}
				return;
				IL_36A:
				IL_3E5:
				this.c = A_0;
				return;
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002FF4 File Offset: 0x000011F4
		private void a(global::System.Windows.Point A_0)
		{
			short num = (short)273547264;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1374945281;
				if (num != 0)
				{
				}
				bool flag;
				bool flag2;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_78;
					}
					continue;
				case 1:
					flag = false;
					goto IL_24A;
				case 2:
					goto IL_160;
				case 3:
					return;
				case 4:
					if (this.b.Visibility != global::System.Windows.Visibility.Visible)
					{
						num = (short)606797830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (flag2)
					{
						num = (short)318177282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Controls.Canvas.SetLeft(this.b, A_0.X - 5.0);
					global::System.Windows.Controls.Canvas.SetTop(this.b, A_0.Y - 5.0);
					num = (short)1432289284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_245;
				case 7:
					flag = (A_0.Y == -1.0);
					goto IL_24A;
				case 8:
					num = (short)196870151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)417202181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (this.b != null)
					{
						num = (short)1992097801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_78:
				num = (short)2011627520;
				short num3 = num;
				num = (short)509145562;
				short num4 = num;
				num = (short)496497114;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_245:
					this.b.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)688979971;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)881786880;
					if (num != 0)
					{
					}
					if (A_0.X == -1.0)
					{
						num = (short)1379401736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)668205057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_24A:
				flag2 = flag;
				num = (short)1637548042;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_160:
			this.b.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003288 File Offset: 0x00001488
		private void a(global::System.Windows.Rect A_0)
		{
			short num = (short)784875950;
			short num2 = num;
			num = (short)1163411886;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C1;
			case 1:
				break;
			default:
			{
				num = (short)1512046592;
				short num3 = num;
				break;
			}
			}
			num = (short)1621032960;
			if (num != 0)
			{
			}
			num = (short)36634625;
			if (num != 0)
			{
			}
			global::System.Windows.Point point = global::DevComponents.WpfEditors.c.a(this);
			global::System.Windows.Media.DrawingVisual drawingVisual = new global::System.Windows.Media.DrawingVisual();
			global::System.Windows.Media.DrawingContext drawingContext = drawingVisual.RenderOpen();
			try
			{
				this.a(drawingContext, A_0);
			}
			finally
			{
				drawingContext.Close();
			}
			IL_C1:
			global::System.Windows.Media.Imaging.RenderTargetBitmap renderTargetBitmap = new global::System.Windows.Media.Imaging.RenderTargetBitmap((int)A_0.Width, (int)A_0.Height, point.X, point.Y, global::System.Windows.Media.PixelFormats.Pbgra32);
			renderTargetBitmap.Render(drawingVisual);
			this.a.Source = renderTargetBitmap;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000033A4 File Offset: 0x000015A4
		private void a()
		{
			short num = (short)649461763;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1933312000;
					short num3 = num;
					global::System.Windows.Size renderSize = base.RenderSize;
					num = (short)90570757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_145;
				case 2:
				{
					global::System.Windows.Size renderSize;
					if (renderSize.Height > 1.0)
					{
						goto IL_19A;
					}
					num = (short)664628468;
					short num4 = num;
					num = (short)1620995316;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_45;
					default:
						num = (short)158990337;
						if (num != 0)
						{
						}
						num = (short)1279066112;
						if (num != 0)
						{
						}
						num = (short)843055105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 4:
				{
					global::System.Windows.Size renderSize = base.RenderSize;
					num = (short)49414146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					global::System.Windows.Size renderSize;
					if (renderSize.Width > 1.0)
					{
						num = (short)1224933380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				goto IL_3D;
				IL_45:
				num = (short)1032126464;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D:
				if (this.a != null)
				{
					goto IL_45;
				}
				break;
			}
			return;
			IL_145:
			return;
			IL_19A:
			this.a(new global::System.Windows.Rect(base.RenderSize));
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000355C File Offset: 0x0000175C
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			short num = (short)1197060118;
			short num2 = num;
			num = (short)2045161494;
			switch (num2 == num)
			{
			}
			num = (short)811794432;
			short num3 = num;
			num = (short)334036993;
			if (num != 0)
			{
			}
			num = (short)1751187456;
			if (num != 0)
			{
			}
			this.a();
			base.OnRenderSizeChanged(sizeInfo);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003610 File Offset: 0x00001810
		private void a(global::System.Windows.Media.DrawingContext A_0, global::System.Windows.Rect A_1)
		{
			short num = (short)896139264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C6;
				}
				int num9;
				double num11;
				double num20;
				int num24;
				int num26;
				for (;;)
				{
					IL_27:
					int num3;
					int num4;
					int num5;
					int num6;
					int num8;
					double num10;
					int num15;
					int num16;
					int num17;
					int num19;
					double num21;
					double num23;
					double num25;
					switch (num2)
					{
					case 0:
					{
						num3 = 0;
						num4 = 255;
						num5 = 0;
						int num7;
						num6 = num7;
						num = (short)1836187665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_3D9;
					case 2:
						goto IL_417;
					case 3:
					{
						num3 = 0;
						num4 = 255;
						num5 = 255;
						int num7;
						num8 = -num7;
						num = (short)576978965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (num9 != 5)
						{
							num = (short)481755170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
					{
						int num7;
						if (num7 < 1)
						{
							num = (short)199753744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24B;
					}
					case 6:
					{
						if (num10 >= num11)
						{
							num = (short)1480720393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num12 = num3;
						int num13 = num4;
						int num14 = num5;
						num15 = 127 - num3;
						num16 = 127 - num4;
						num17 = 127 - num5;
						double num18 = A_1.Y;
						num = (short)1441005583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num3 = 255;
						num4 = 255;
						num5 = 0;
						int num7;
						num19 = -num7;
						num = (short)1472790558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_175;
					case 9:
						num20 = num21;
						num = (short)1025572868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_311;
					case 11:
						return;
					case 12:
						if (num9 == 4)
						{
							num = (short)820051992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)825229334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_75E;
					case 14:
					{
						num3 = 255;
						num4 = 0;
						num5 = 0;
						int num7;
						num8 = num7;
						num = (short)124846090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_75E;
					case 16:
					{
						double num22 = num11 / 255.0;
						int num7 = 1;
						num = (short)1391853587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_311;
					case 18:
						if (num9 == 1)
						{
							num = (short)261750791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1534984220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_24B;
					case 20:
						goto IL_311;
					case 21:
						goto IL_311;
					case 22:
						if (num9 == 5)
						{
							num = (short)793772055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311;
					case 23:
					{
						num3 = 255;
						num4 = 0;
						num5 = 255;
						int num7;
						num6 = -num7;
						num = (short)415432741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						num3 = 0;
						num4 = 0;
						num5 = 255;
						int num7;
						num19 = num7;
						num = (short)1493434388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_417;
					case 26:
					{
						double num22;
						num21 += num22;
						num23 = A_1.Y;
						num3 += num19;
						num4 += num8;
						num5 += num6;
						num10 += num22;
						num = (short)1051394049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						if (num9 == 0)
						{
							num = (short)1624702990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2059599890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (num9 == 2)
						{
							num = (short)1756823552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)768802845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (num9 == 3)
						{
							num = (short)562757635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1998848012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_311;
					case 31:
						if ((int)((double)num24 / (A_1.Height / num25)) < 1)
						{
							num = (short)852557859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_175;
					case 32:
					{
						if (num9 >= num26)
						{
							num = (short)2043215883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double num22 = 4.0;
						int num7 = (int)(255.0 / (num11 / num22));
						num = (short)1059389445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						goto IL_3D9;
					case 34:
						num9++;
						num = (short)1044119554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						num = (short)1712381850;
						short num27 = num;
						num = (short)740614042;
						switch ((num27 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_31C;
						default:
							num = (short)919928833;
							if (num != 0)
							{
							}
							num = (short)2100035584;
							if (num != 0)
							{
							}
							num25 = A_1.Height / (double)num24;
							num = (short)139001864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 36:
					{
						double num18;
						if (num18 >= A_1.Height)
						{
							num = (short)1158610970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num12;
						int num13;
						int num14;
						global::System.Windows.Media.SolidColorBrush brush = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, (byte)num12, (byte)num13, (byte)num14));
						double num22;
						global::System.Windows.Rect rectangle = new global::System.Windows.Rect(num21, num23, num22, num25);
						A_0.DrawRectangle(brush, null, rectangle);
						num23 += num25;
						num12 = num3 + (int)((float)num15 * ((float)num18 / (float)A_1.Height));
						num13 = num4 + (int)((float)num16 * ((float)num18 / (float)A_1.Height));
						num14 = num5 + (int)((float)num17 * ((float)num18 / (float)A_1.Height));
						num18 += num25;
						num = (short)2035941389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						goto IL_311;
					}
					goto IL_C6;
					IL_175:
					num21 = num20;
					num23 = A_1.Y;
					num3 = 0;
					num4 = 0;
					num5 = 0;
					num19 = 0;
					num8 = 0;
					num6 = 0;
					num15 = 0;
					num16 = 0;
					num17 = 0;
					num = (short)1802895360;
					short num28 = num;
					num = (short)1749221403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24B:
					num25 = 4.0;
					num = (short)1982070815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31C:
					num = (short)444661793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_311:
					num10 = 0.0;
					goto IL_31C;
					IL_3D9:
					num = (short)1130102790;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_417:
					num = (short)261685280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_75E:
					num = (short)1997602852;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_C6:
				num26 = 6;
				num11 = A_1.Width / (double)num26;
				num24 = 127;
				num20 = A_1.X;
				num9 = 0;
				num = (short)1979187225;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x04000003 RID: 3
		public static readonly global::System.Windows.DependencyProperty SelectedColorProperty;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Controls.Image a;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Controls.Border b;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Point c = new global::System.Windows.Point(-1.0, -1.0);
	}
}
