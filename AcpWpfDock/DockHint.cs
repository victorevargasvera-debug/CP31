using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock
{
	// Token: 0x02000015 RID: 21
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DockHint : global::System.Windows.Controls.Control
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00003E50 File Offset: 0x00002050
		static DockHint()
		{
			int a_ = 9;
			short num = (short)1893924865;
			if (num != 0)
			{
			}
			num = (short)1350434816;
			short num2 = num;
			num = (short)1597107150;
			short num3 = num;
			num = (short)1605168078;
			switch (num3 == num)
			{
			}
			num = (short)404226048;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfDock.DockHint), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfDock.DockHint)));
			global::DevComponents.WpfDock.DockHint.DockHintSideProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("資ꗉ꿋ꗍ飏믑뫓ꋕ诗동룛믝", a_), typeof(global::DevComponents.WpfDock.eDockHintSide), typeof(global::DevComponents.WpfDock.DockHint), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfDock.eDockHintSide.Top, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfDock.DockHint.PartHitTestSizeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("飇ꯉ뻋뫍飏믑ꃓ苕뷗꧙꣛距觟飡臣", a_), typeof(global::System.Windows.Size), typeof(global::DevComponents.WpfDock.DockHint), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Size(29.0, 31.0)));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003FAC File Offset: 0x000021AC
		public DockHint()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003FC0 File Offset: 0x000021C0
		internal DockHint(global::DevComponents.WpfDock.eDockHintSide A_0)
		{
			this.DockHintSide = A_0;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003FDC File Offset: 0x000021DC
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00004098 File Offset: 0x00002298
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Appearance")]
		public global::DevComponents.WpfDock.eDockHintSide DockHintSide
		{
			get
			{
				short num = (short)1966403029;
				short num2 = num;
				num = (short)1038216661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)745930752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)9306112;
				if (num != 0)
				{
				}
				num = (short)733609985;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfDock.eDockHintSide)base.GetValue(global::DevComponents.WpfDock.DockHint.DockHintSideProperty);
			}
			set
			{
				short num = (short)2009254005;
				short num2 = num;
				num = (short)2039466101;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1086193664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)382730240;
				if (num != 0)
				{
				}
				num = (short)1865875457;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockHint.DockHintSideProperty, value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00004154 File Offset: 0x00002354
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000420C File Offset: 0x0000240C
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Size PartHitTestSize
		{
			get
			{
				short num = (short)1234254010;
				short num2 = num;
				num = (short)140916922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1199767552;
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
				num = (short)1011089408;
				if (num != 0)
				{
				}
				return (global::System.Windows.Size)base.GetValue(global::DevComponents.WpfDock.DockHint.PartHitTestSizeProperty);
			}
			set
			{
				short num = (short)393283551;
				short num2 = num;
				num = (short)974850015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1656160256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)733282304;
				if (num != 0)
				{
				}
				num = (short)2077753345;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockHint.PartHitTestSizeProperty, value);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000042C8 File Offset: 0x000024C8
		public global::DevComponents.WpfDock.eDockHintHitTest HitTest(global::System.Windows.Point p)
		{
			short num = (short)634912768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BB;
				}
				global::DevComponents.WpfDock.eDockHintHitTest result;
				global::System.Windows.Rect rect;
				for (;;)
				{
					IL_28:
					global::System.Windows.Size partHitTestSize;
					global::System.Windows.Rect rect2;
					switch (num2)
					{
					case 0:
						result = global::DevComponents.WpfDock.eDockHintHitTest.Bottom;
						num = (short)713359389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						result = global::DevComponents.WpfDock.eDockHintHitTest.Tab;
						num = (short)1891500060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!rect.Contains(p))
						{
							num = (short)591134725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						partHitTestSize = this.PartHitTestSize;
						num = (short)549650452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)921501727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						result = global::DevComponents.WpfDock.eDockHintHitTest.Left;
						num = (short)1061093389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return result;
					case 6:
						if (rect2.Contains(p))
						{
							num = (short)1154220032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_503;
					case 7:
						result = global::DevComponents.WpfDock.eDockHintHitTest.Top;
						num = (short)92536843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						result = global::DevComponents.WpfDock.eDockHintHitTest.Left;
						num = (short)1173553182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.DockHintSide == global::DevComponents.WpfDock.eDockHintSide.Right)
						{
							num = (short)1287258131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
					{
						num = (short)1853842958;
						short num3 = num;
						num = (short)255223310;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2AC;
						default:
							num = (short)154337280;
							if (num != 0)
							{
							}
							result = global::DevComponents.WpfDock.eDockHintHitTest.Bottom;
							num = (short)614203406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
					{
						num = (short)227213312;
						short num4 = num;
						goto IL_36A;
					}
					case 12:
						rect2 = new global::System.Windows.Rect(rect.X + (rect.Width - this.PartHitTestSize.Width) / 2.0, rect.Y + (rect.Height - this.PartHitTestSize.Height) / 2.0, partHitTestSize.Width, partHitTestSize.Height);
						num = (short)778764312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						return result;
					case 14:
						return result;
					case 15:
						if (this.DockHintSide == global::DevComponents.WpfDock.eDockHintSide.Left)
						{
							num = (short)473235460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)635568137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return result;
					case 17:
						goto IL_45E;
					case 18:
						if (rect2.Contains(p))
						{
							num = (short)1459552263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36A;
					case 19:
						result = global::DevComponents.WpfDock.eDockHintHitTest.Right;
						num = (short)57081872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (this.DockHintSide != global::DevComponents.WpfDock.eDockHintSide.AllSides)
						{
							num = (short)861863939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45E;
					case 21:
						if (this.DockHintSide == global::DevComponents.WpfDock.eDockHintSide.Top)
						{
							num = (short)314834971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2040987682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (this.DockHintSide == global::DevComponents.WpfDock.eDockHintSide.AllSidesAndCenter)
						{
							num = (short)431554572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 23:
						goto IL_6C3;
					case 24:
						num = (short)506527745;
						if (num != 0)
						{
						}
						if (rect2.Contains(p))
						{
							num = (short)2072576001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 25:
						result = global::DevComponents.WpfDock.eDockHintHitTest.Right;
						num = (short)1582235671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (rect2.Contains(p))
						{
							num = (short)1184694280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_637;
					case 27:
						result = global::DevComponents.WpfDock.eDockHintHitTest.Top;
						num = (short)422051872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						return result;
					case 29:
						goto IL_503;
					case 30:
						goto IL_637;
					case 31:
						if (this.DockHintSide == global::DevComponents.WpfDock.eDockHintSide.AllSidesAndCenter)
						{
							goto IL_2AC;
						}
						num = (short)213188629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						return result;
					case 33:
						if (rect2.Contains(p))
						{
							num = (short)150011929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C3;
					case 34:
						if (this.DockHintSide == global::DevComponents.WpfDock.eDockHintSide.Bottom)
						{
							num = (short)1270677514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1274675215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BB;
					IL_2AC:
					num = (short)744292369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36A:
					rect2 = new global::System.Windows.Rect(rect.X + (rect.Width - this.PartHitTestSize.Width) / 2.0, rect.Bottom - partHitTestSize.Height, partHitTestSize.Width, partHitTestSize.Height);
					num = (short)830930950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45E:
					rect2 = new global::System.Windows.Rect(rect.X + (rect.Width - this.PartHitTestSize.Width) / 2.0, 0.0, partHitTestSize.Width, partHitTestSize.Height);
					num = (short)425263122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_503:
					rect2 = new global::System.Windows.Rect(0.0, rect.Y + (rect.Height - this.PartHitTestSize.Height) / 2.0, partHitTestSize.Width, partHitTestSize.Height);
					num = (short)1310785562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_637:
					rect2 = new global::System.Windows.Rect(rect.Right - partHitTestSize.Width, rect.Y + (rect.Height - this.PartHitTestSize.Height) / 2.0, partHitTestSize.Width, partHitTestSize.Height);
					num = (short)1104543777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C3:
					num = (short)2080505878;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_BB:
				result = global::DevComponents.WpfDock.eDockHintHitTest.None;
				rect = new global::System.Windows.Rect(base.RenderSize);
				num = (short)781254658;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0400007D RID: 125
		public static readonly global::System.Windows.DependencyProperty DockHintSideProperty;

		// Token: 0x0400007E RID: 126
		public static readonly global::System.Windows.DependencyProperty PartHitTestSizeProperty;
	}
}
