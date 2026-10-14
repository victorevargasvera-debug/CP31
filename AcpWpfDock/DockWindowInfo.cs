using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevComponents.WpfDock.Converters;
using DevComponents.WpfDock.Primitives;

namespace DevComponents.WpfDock
{
	// Token: 0x02000025 RID: 37
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DockWindowInfo : global::System.Windows.Controls.Control
	{
		// Token: 0x0600022F RID: 559 RVA: 0x0003D244 File Offset: 0x0003B444
		static DockWindowInfo()
		{
			int a_ = 1;
			short num = (short)895549441;
			if (num != 0)
			{
			}
			num = (short)1112014848;
			short num2 = num;
			num = (short)1719973339;
			short num3 = num;
			num = (short)821343707;
			switch (num3 == num)
			{
			}
			num = (short)831979520;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfDock.DockWindowInfo), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfDock.DockWindowInfo)));
			global::DevComponents.WpfDock.DockWindowInfo.IsSelectedProperty = global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty.AddOwner(typeof(global::DevComponents.WpfDock.DockWindowInfo), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal));
			global::DevComponents.WpfDock.DockWindowInfo.ImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("覿꿁ꗃꇅ귇", a_), typeof(object), typeof(global::DevComponents.WpfDock.DockWindowInfo), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfDock.DockWindowInfo.HeaderProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("袿ꟁꗃꋅ귇룉", a_), typeof(object), typeof(global::DevComponents.WpfDock.DockWindowInfo), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfDock.DockWindowInfo.DescriptionProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蒿ꟁ럃ꗅ뫇ꏉ볋뫍맏뷑뫓", a_), typeof(string), typeof(global::DevComponents.WpfDock.DockWindowInfo), new global::System.Windows.FrameworkPropertyMetadata(""));
			global::DevComponents.WpfDock.DockWindowInfo.DockWindowProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蒿귁ꟃ귅鿇ꏉꋋ꫍뿏ꗑ", a_), typeof(global::DevComponents.WpfDock.DockWindow), typeof(global::DevComponents.WpfDock.DockWindowInfo), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0003D40C File Offset: 0x0003B60C
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0003D4C0 File Offset: 0x0003B6C0
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Content")]
		public object Image
		{
			get
			{
				short num = (short)1797359582;
				short num2 = num;
				num = (short)215975902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)748814336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)81330176;
				if (num != 0)
				{
				}
				num = (short)89456641;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfDock.DockWindowInfo.ImageProperty);
			}
			set
			{
				short num = (short)655105008;
				short num2 = num;
				num = (short)2095389680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)747503616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)477036545;
				if (num != 0)
				{
				}
				num = (short)415694848;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindowInfo.ImageProperty, value);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0003D574 File Offset: 0x0003B774
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0003D62C File Offset: 0x0003B82C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Category("Content")]
		public string Description
		{
			get
			{
				short num = (short)284465334;
				short num2 = num;
				num = (short)731158710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)782499840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1519976449;
				if (num != 0)
				{
				}
				num = (short)1397882880;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfDock.DockWindowInfo.DescriptionProperty);
			}
			set
			{
				short num = (short)1094853774;
				short num2 = num;
				num = (short)1980114062;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1048510464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2142830592;
				if (num != 0)
				{
				}
				num = (short)1399652353;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindowInfo.DescriptionProperty, value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0003D6E0 File Offset: 0x0003B8E0
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0003D794 File Offset: 0x0003B994
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Content")]
		public object Header
		{
			get
			{
				short num = (short)1545089129;
				short num2 = num;
				num = (short)609103977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)297402368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)26869761;
				if (num != 0)
				{
				}
				num = (short)1601896448;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfDock.DockWindowInfo.HeaderProperty);
			}
			set
			{
				short num = (short)1668025948;
				short num2 = num;
				num = (short)182980188;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1495531520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)498204673;
				if (num != 0)
				{
				}
				num = (short)2007760896;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindowInfo.HeaderProperty, value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0003D848 File Offset: 0x0003BA48
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0003D900 File Offset: 0x0003BB00
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::DevComponents.WpfDock.DockWindow DockWindow
		{
			get
			{
				short num = (short)1640622195;
				short num2 = num;
				num = (short)146925683;
				switch (num2 == num)
				{
				}
				num = (short)563281921;
				if (num != 0)
				{
				}
				num = (short)456261632;
				if (num != 0)
				{
				}
				num = (short)1593311232;
				short num3 = num;
				return (global::DevComponents.WpfDock.DockWindow)base.GetValue(global::DevComponents.WpfDock.DockWindowInfo.DockWindowProperty);
			}
			set
			{
				short num = (short)194445313;
				if (num != 0)
				{
				}
				num = (short)90155482;
				short num2 = num;
				num = (short)1040361946;
				switch (num2 == num)
				{
				}
				num = (short)1340407808;
				if (num != 0)
				{
				}
				num = (short)510197760;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowInfo.DockWindowProperty, value);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0003D9B4 File Offset: 0x0003BBB4
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0003DA6C File Offset: 0x0003BC6C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Appearance")]
		public bool IsSelected
		{
			get
			{
				short num = (short)1823703278;
				short num2 = num;
				num = (short)1277919470;
				switch (num2 == num)
				{
				}
				num = (short)202506240;
				if (num != 0)
				{
				}
				num = (short)2065301505;
				if (num != 0)
				{
				}
				num = (short)699990016;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindowInfo.IsSelectedProperty);
			}
			set
			{
				short num = (short)1036925734;
				short num2 = num;
				num = (short)333724454;
				switch (num2 == num)
				{
				}
				num = (short)967376897;
				if (num != 0)
				{
				}
				num = (short)1200291840;
				if (num != 0)
				{
				}
				num = (short)2106064896;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowInfo.IsSelectedProperty, value);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0003DB28 File Offset: 0x0003BD28
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			global::DevComponents.WpfDock.DockWindowSelector dockWindowSelector;
			for (;;)
			{
				IL_0A:
				global::DevComponents.WpfDock.Primitives.c c;
				switch (num)
				{
				case 0:
					if (global::DevComponents.WpfDock.DockSite.GetIsDocument(this.DockWindow))
					{
						num2 = (short)1548812289;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					dockWindowSelector.SelectedToolWindow = this;
					num2 = (short)1031340038;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					this.IsSelected = true;
					num2 = (short)1336803338;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_1DA;
				case 3:
				{
					num2 = (short)1861091329;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfDock.DockSite dockSite = c.b() as global::DevComponents.WpfDock.DockSite;
					num2 = (short)581763080;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					num2 = (short)64356352;
					short num3 = num2;
					num2 = (short)687144960;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (dockWindowSelector != null)
					{
						num2 = (short)1295581188;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_240;
				case 6:
					goto IL_150;
				case 7:
					if (c != null)
					{
						num2 = (short)560922627;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_240;
				case 8:
				{
					num2 = (short)1427230656;
					short num4 = num2;
					num2 = (short)808374208;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_150;
					default:
					{
						num2 = (short)873463808;
						if (num2 != 0)
						{
						}
						global::DevComponents.WpfDock.DockSite dockSite;
						if (dockSite != null)
						{
							num2 = (short)1648558089;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_240;
					}
					}
					break;
				}
				case 9:
				{
					global::DevComponents.WpfDock.DockSite dockSite;
					dockSite.ReleaseDockSelectorAdorner(true);
					num2 = (short)1310195714;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					goto IL_1FC;
				}
				goto IL_3C;
				IL_1FC:
				c = (dockWindowSelector.Parent as global::DevComponents.WpfDock.Primitives.c);
				num2 = (short)17170439;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_150:
				goto IL_1FC;
			}
			IL_1DA:
			IL_240:
			base.OnMouseLeftButtonUp(e);
			return;
			IL_3C:
			dockWindowSelector = (base.Parent as global::DevComponents.WpfDock.DockWindowSelector);
			num2 = (short)1287716869;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0003DD7C File Offset: 0x0003BF7C
		public static global::DevComponents.WpfDock.DockWindowInfo FromDockWindow(global::DevComponents.WpfDock.DockWindow dw)
		{
			int a_ = 2;
			short num = (short)475070464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				global::DevComponents.WpfDock.DockWindowInfo dockWindowInfo;
				for (;;)
				{
					IL_31:
					string str;
					switch (num2)
					{
					case 0:
						goto IL_234;
					case 1:
						if (dw.Image == null)
						{
							num = (short)1380515844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dockWindowInfo.Image = global::DevComponents.WpfDock.DockWindowGroup.a(dw.Image);
						num = (short)1424031744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_95;
					case 3:
					{
						num = (short)1971716096;
						short num3 = num;
						if (global::DevComponents.WpfDock.DockSite.GetIsDocument(dw))
						{
							num = (short)1573978118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_95;
					}
					case 4:
					{
						str = global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꣀ껂꓄ꃆ곈룊鯎뻐볒맔胖냘뗚맜냞雠ꫢ裤蛦軨軪\udcec\ud9ee\udff0菲鯴郶", a_);
						num = (short)54949632;
						short num4 = num;
						num = (short)951482112;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2014969856;
							if (num != 0)
							{
							}
							num = (short)1602813955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_E9;
					case 6:
						num = (short)1019871233;
						if (num != 0)
						{
						}
						str = global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꣀ껂꓄ꃆ곈룊诎뻐냒ꃔ뫖볘뗚꧜雞賠苢苤苦\ud8e8\uddea쏬鿮鿰铲", a_);
						num = (short)483917826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54;
					IL_95:
					global::System.Windows.Media.Imaging.BitmapImage source = new global::System.Windows.Media.Imaging.BitmapImage(new global::System.Uri(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("뇀ꋂꛄ곆껎ꇐꏒ맔뻖뫘뫚꧜뛞軠跢\udfe4쯦엨쟪심껮鋰菲ꋴ蟶鿸뿺鋼鳾樀㠂昄栆搈笊戌愎琐紒愔㠖", a_) + str, global::System.UriKind.RelativeOrAbsolute));
					dockWindowInfo.Image = new global::System.Windows.Controls.Image
					{
						Source = source,
						Stretch = global::System.Windows.Media.Stretch.None
					};
					num = (short)1825898501;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E9:
				IL_234:
				dockWindowInfo.Header = global::DevComponents.WpfDock.DockWindowGroup.a(dw.Header);
				dockWindowInfo.Description = dw.Description;
				dockWindowInfo.DockWindow = dw;
				return dockWindowInfo;
				IL_54:
				dockWindowInfo = new global::DevComponents.WpfDock.DockWindowInfo();
				num = (short)1897660417;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x04000141 RID: 321
		public static readonly global::System.Windows.DependencyProperty ImageProperty;

		// Token: 0x04000142 RID: 322
		public static readonly global::System.Windows.DependencyProperty HeaderProperty;

		// Token: 0x04000143 RID: 323
		public static readonly global::System.Windows.DependencyProperty DescriptionProperty;

		// Token: 0x04000144 RID: 324
		public static readonly global::System.Windows.DependencyProperty DockWindowProperty;

		// Token: 0x04000145 RID: 325
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty;
	}
}
