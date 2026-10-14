using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using DevComponents.WpfDock.Converters;
using DevComponents.WpfDock.Primitives;
using DevComponents.WpfDock.themes;

namespace DevComponents.WpfDock
{
	// Token: 0x02000019 RID: 25
	public class DockSite : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000057C0 File Offset: 0x000039C0
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00005878 File Offset: 0x00003A78
		public global::System.Windows.Size MinimumDocumentAreaSize
		{
			get
			{
				short num = (short)79618353;
				short num2 = num;
				num = (short)509337905;
				switch (num2 == num)
				{
				}
				num = (short)364707841;
				if (num != 0)
				{
				}
				num = (short)2042429440;
				short num3 = num;
				num = (short)1805320192;
				if (num != 0)
				{
				}
				return (global::System.Windows.Size)base.GetValue(global::DevComponents.WpfDock.DockSite.MinimumDocumentAreaSizeProperty);
			}
			set
			{
				short num = (short)1124956503;
				short num2 = num;
				num = (short)1399093591;
				switch (num2 == num)
				{
				}
				num = (short)511508481;
				if (num != 0)
				{
				}
				num = (short)119603200;
				short num3 = num;
				num = (short)2032467968;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockSite.MinimumDocumentAreaSizeProperty, value);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005930 File Offset: 0x00003B30
		public static global::DevComponents.WpfDock.eDockVisualStyle GetVisualStyle(global::System.Windows.DependencyObject target)
		{
			short num = (short)2041206704;
			short num2 = num;
			num = (short)2060015536;
			switch (num2 == num)
			{
			}
			num = (short)371064833;
			if (num != 0)
			{
			}
			num = (short)129630208;
			short num3 = num;
			num = (short)1637089280;
			if (num != 0)
			{
			}
			return (global::DevComponents.WpfDock.eDockVisualStyle)target.GetValue(global::DevComponents.WpfDock.DockSite.VisualStyleProperty);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000059EC File Offset: 0x00003BEC
		public static void SetVisualStyle(global::System.Windows.DependencyObject target, global::DevComponents.WpfDock.eDockVisualStyle value)
		{
			short num = (short)1679877855;
			short num2 = num;
			num = (short)928900831;
			switch (num2 == num)
			{
			}
			num = (short)1937309697;
			if (num != 0)
			{
			}
			num = (short)820969472;
			short num3 = num;
			num = (short)448921600;
			if (num != 0)
			{
			}
			target.SetValue(global::DevComponents.WpfDock.DockSite.VisualStyleProperty, value);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005AA8 File Offset: 0x00003CA8
		private static void h(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1797718016;
			short num2 = num;
			num = (short)1866261178;
			short num3 = num;
			num = (short)1166533306;
			switch (num3 == num)
			{
			}
			num = (short)1141178369;
			if (num != 0)
			{
			}
			num = (short)1543176192;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.DockSite.a(A_0, (global::DevComponents.WpfDock.eDockVisualStyle)A_1.OldValue, (global::DevComponents.WpfDock.eDockVisualStyle)A_1.NewValue);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005B70 File Offset: 0x00003D70
		private static void a(global::System.Windows.DependencyObject A_0, global::DevComponents.WpfDock.eDockVisualStyle A_1, global::DevComponents.WpfDock.eDockVisualStyle A_2)
		{
			short num = (short)1591148544;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfDock.DockSite dockSite;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 1:
					dockSite = (global::DevComponents.WpfDock.DockSite)A_0;
					dockSite.ChangeColorScheme(A_2);
					num = (short)656539651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (A_2 == global::DevComponents.WpfDock.eDockVisualStyle.Office2010Black)
					{
						num = (short)137756676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					dockSite.EffectiveStyle = global::DevComponents.WpfDock.eEffectiveDockVisualStyle.Office2007;
					num = (short)767623173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					if (A_2 == global::DevComponents.WpfDock.eDockVisualStyle.Office2010Silver)
					{
						goto IL_92;
					}
					num = (short)1796084174;
					short num3 = num;
					num = (short)1423708622;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9A;
					default:
						num = (short)1251475456;
						if (num != 0)
						{
						}
						num = (short)401473542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_D0;
				case 5:
					return;
				case 6:
					num = (short)1041104903;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (A_2 != global::DevComponents.WpfDock.eDockVisualStyle.Office2010Blue)
					{
						num = (short)2039545864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_92;
				case 8:
					goto IL_9A;
				}
				IL_48:
				if (A_0 is global::DevComponents.WpfDock.DockSite)
				{
					num = (short)223019008;
					short num4 = num;
					num = (short)1656750081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_9A:
				num = (short)491651074;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_92:
			dockSite.EffectiveStyle = global::DevComponents.WpfDock.eEffectiveDockVisualStyle.Office2010;
			return;
			IL_D0:
			num = (short)2014052353;
			if (num != 0)
			{
			}
			goto IL_92;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00005D64 File Offset: 0x00003F64
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00005E14 File Offset: 0x00004014
		public global::DevComponents.WpfDock.eDockVisualStyle VisualStyle
		{
			get
			{
				short num = (short)467075072;
				short num2 = num;
				num = (short)1633817522;
				short num3 = num;
				num = (short)256054194;
				switch (num3 == num)
				{
				}
				num = (short)1953759233;
				if (num != 0)
				{
				}
				num = (short)2147352576;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfDock.DockSite.GetVisualStyle(this);
			}
			set
			{
				short num = (short)1347092480;
				short num2 = num;
				num = (short)1956856842;
				short num3 = num;
				num = (short)1855538186;
				switch (num3 == num)
				{
				}
				num = (short)499318785;
				if (num != 0)
				{
				}
				num = (short)1946288128;
				if (num != 0)
				{
				}
				global::DevComponents.WpfDock.DockSite.SetVisualStyle(this, value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00005EC4 File Offset: 0x000040C4
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00005F80 File Offset: 0x00004180
		public global::DevComponents.WpfDock.eEffectiveDockVisualStyle EffectiveStyle
		{
			get
			{
				short num = (short)835715072;
				short num2 = num;
				num = (short)329781373;
				short num3 = num;
				num = (short)1381699709;
				switch (num3 == num)
				{
				}
				num = (short)2015821824;
				if (num != 0)
				{
				}
				num = (short)165281793;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfDock.eEffectiveDockVisualStyle)base.GetValue(global::DevComponents.WpfDock.DockSite.EffectiveStyleProperty);
			}
			internal set
			{
				short num = (short)1929248768;
				short num2 = num;
				num = (short)1060370859;
				short num3 = num;
				num = (short)2073688491;
				switch (num3 == num)
				{
				}
				num = (short)943325185;
				if (num != 0)
				{
				}
				num = (short)229769216;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockSite.a, value);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000603C File Offset: 0x0000423C
		private static void g(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				short num;
				int num4;
				global::DevComponents.WpfDock.DockSite dockSite;
				for (;;)
				{
					IL_0A:
					num = (short)103922637;
					short num2 = num;
					num = (short)87800781;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					case 1:
						break;
					default:
					{
						num = (short)1980760064;
						short num3 = num;
						break;
					}
					}
					num = (short)165871616;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (dockSite != null)
						{
							num = (short)1745747969;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						dockSite.OnEffectiveStyleChanged((global::DevComponents.WpfDock.eEffectiveDockVisualStyle)A_1.OldValue, (global::DevComponents.WpfDock.eEffectiveDockVisualStyle)A_1.NewValue);
						num = (short)1210318850;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					break;
				}
				IL_8F:
				dockSite = (A_0 as global::DevComponents.WpfDock.DockSite);
				num = (short)1412956161;
				if (num != 0)
				{
				}
				num = (short)451543040;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006178 File Offset: 0x00004378
		protected virtual void OnEffectiveStyleChanged(global::DevComponents.WpfDock.eEffectiveDockVisualStyle oldValue, global::DevComponents.WpfDock.eEffectiveDockVisualStyle newValue)
		{
			short num = (short)999489536;
			short num2 = num;
			num = (short)2079640483;
			short num3 = num;
			num = (short)733268899;
			switch (num3 == num)
			{
			}
			num = (short)924319745;
			if (num != 0)
			{
			}
			num = (short)734920704;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006224 File Offset: 0x00004424
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000062E0 File Offset: 0x000044E0
		public bool KeyboardNavigationEnabled
		{
			get
			{
				short num = (short)1295187968;
				short num2 = num;
				num = (short)1282103274;
				short num3 = num;
				num = (short)936466410;
				switch (num3 == num)
				{
				}
				num = (short)1952514048;
				if (num != 0)
				{
				}
				num = (short)1721040897;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockSite.KeyboardNavigationEnabledProperty);
			}
			set
			{
				short num = (short)1006567424;
				short num2 = num;
				num = (short)1120495314;
				short num3 = num;
				num = (short)681797330;
				switch (num3 == num)
				{
				}
				num = (short)1820655617;
				if (num != 0)
				{
				}
				num = (short)561577984;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockSite.KeyboardNavigationEnabledProperty, value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000639C File Offset: 0x0000459C
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00006454 File Offset: 0x00004654
		public bool AutoHidePopupOverlay
		{
			get
			{
				short num = (short)1149239296;
				short num2 = num;
				num = (short)770071155;
				short num3 = num;
				num = (short)1294162547;
				switch (num3 == num)
				{
				}
				num = (short)1512833025;
				if (num != 0)
				{
				}
				num = (short)1862402048;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockSite.AutoHidePopupOverlayProperty);
			}
			set
			{
				short num = (short)1293156352;
				short num2 = num;
				num = (short)587771072;
				short num3 = num;
				num = (short)1808051392;
				switch (num3 == num)
				{
				}
				num = (short)520749057;
				if (num != 0)
				{
				}
				num = (short)25755648;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockSite.AutoHidePopupOverlayProperty, value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00006510 File Offset: 0x00004710
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000065CC File Offset: 0x000047CC
		[global::System.ComponentModel.DefaultValue(false)]
		public bool SelectorCycleAllWindows
		{
			get
			{
				short num = (short)1759051776;
				short num2 = num;
				num = (short)1831562937;
				short num3 = num;
				num = (short)1776643769;
				switch (num3 == num)
				{
				}
				num = (short)169869313;
				if (num != 0)
				{
				}
				num = (short)1138556928;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockSite.SelectorCycleAllWindowsProperty);
			}
			set
			{
				short num = (short)590282752;
				short num2 = num;
				num = (short)2055230454;
				short num3 = num;
				num = (short)1911772150;
				switch (num3 == num)
				{
				}
				num = (short)908328960;
				if (num != 0)
				{
				}
				num = (short)1135280129;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockSite.SelectorCycleAllWindowsProperty, value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000668C File Offset: 0x0000488C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00006744 File Offset: 0x00004944
		[global::System.ComponentModel.Description("Indicates whether animation between states of the control is enabled")]
		[global::System.ComponentModel.Category("Behavior")]
		public bool IsAnimationEnabled
		{
			get
			{
				short num = (short)771489792;
				short num2 = num;
				num = (short)1079386518;
				short num3 = num;
				num = (short)1378951574;
				switch (num3 == num)
				{
				}
				num = (short)1598816256;
				if (num != 0)
				{
				}
				num = (short)54919169;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockSite.IsAnimationEnabledProperty);
			}
			set
			{
				short num = (short)215744512;
				short num2 = num;
				num = (short)1173059788;
				short num3 = num;
				num = (short)1480489164;
				switch (num3 == num)
				{
				}
				num = (short)1885863937;
				if (num != 0)
				{
				}
				num = (short)2047737856;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockSite.IsAnimationEnabledProperty, value);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006800 File Offset: 0x00004A00
		static DockSite()
		{
			int a_ = 11;
			short num = (short)2047279105;
			if (num != 0)
			{
			}
			num = (short)1432485276;
			short num2 = num;
			num = (short)74907036;
			switch (num2 == num)
			{
			}
			num = (short)1590689792;
			if (num != 0)
			{
			}
			num = (short)1917583360;
			short num3 = num;
			global::DevComponents.WpfDock.DockSite.MinimumDocumentAreaSizeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蟉ꗋꃍ맏뿑ꇓ믕鳗뗙뿛ꯝ跟蟡諣鋥ꧧ飩觫迭ꏯ鯱軳鏵", a_), typeof(global::System.Windows.Size), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.UIPropertyMetadata(new global::System.Windows.Size(32.0, 32.0)));
			global::DevComponents.WpfDock.DockSite.VisualStyleProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鳉ꗋ뷍ꗏ돑룓藕곗ꏙ냛믝", a_), typeof(global::DevComponents.WpfDock.eDockVisualStyle), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfDock.eDockVisualStyle.Office2007Blue, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockSite.h)));
			global::DevComponents.WpfDock.DockSite.a = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("迉꫋꣍뗏뇑ꃓ뿕껗뿙进ꫝ駟軡臣", a_), typeof(global::DevComponents.WpfDock.eEffectiveDockVisualStyle), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfDock.eEffectiveDockVisualStyle.Office2007, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockSite.g)));
			global::DevComponents.WpfDock.DockSite.EffectiveStyleProperty = global::DevComponents.WpfDock.DockSite.a.DependencyProperty;
			global::DevComponents.WpfDock.DockSite.KeyboardNavigationEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("臉꧋럍닏뷑뗓ꓕ볗铙뷛꣝觟藡藣鋥臧藩苫꯭黯鏱雳髵鷷黹", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfDock.DockSite.AutoHidePopupOverlayProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("诉맋뫍뿏髑뷓닕뷗諙돛껝闟鋡ꯣ郥跧飩胫迭觯", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfDock.DockSite.SelectorCycleAllWindowsProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("駉꧋ꋍ뗏뇑ꃓ맕꫗駙ꗛ뷝賟蟡ꗣ諥蓧뷩藫胭铯鷱菳藵", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfDock.DockSite.IsAnimationEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("菉뿋迍뻏믑맓럕곗동돛냝ꗟ賡藣蓥蓧迩裫", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfDock.DockSite.DockProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("軉ꏋ귍믏", a_), typeof(global::System.Windows.Controls.Dock), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.Dock.Left, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockSite.d)));
			global::DevComponents.WpfDock.DockSite.DockSizeProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("軉ꏋ귍믏臑뷓곕뷗", a_), typeof(double), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.PropertyMetadata(100.0, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockSite.c)));
			global::DevComponents.WpfDock.DockSite.b = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("駉볋ꋍ맏ꛑ蓓럕뛗뿙냛귝", a_), typeof(global::DevComponents.WpfDock.SplitPanelCollection), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.FrameworkPropertyMetadata(new global::DevComponents.WpfDock.SplitPanelCollection()));
			global::DevComponents.WpfDock.DockSite.SplitPanelsProperty = global::DevComponents.WpfDock.DockSite.b.DependencyProperty;
			global::DevComponents.WpfDock.DockSite.IsDocumentProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("菉뿋諍뿏뇑ꇓ믕뷗듙꣛", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockSite.b)));
			global::DevComponents.WpfDock.DockSite.SaveLayoutProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("駉귋룍뗏黑뗓꿕럗꿙꣛", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.PropertyMetadata(true));
			global::DevComponents.WpfDock.DockSite.c = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("诉꿋뫍맏ꓑ뇓鋕럗맙럛觝觟賡胣觥鿧", a_), typeof(global::DevComponents.WpfDock.DockWindow), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockSite.ActiveDockWindowProperty = global::DevComponents.WpfDock.DockSite.c.DependencyProperty;
			global::DevComponents.WpfDock.DockSite.DockChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("軉ꏋ귍믏金볓럕뛗뷙맛뫝", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfDock.DockSite));
			global::DevComponents.WpfDock.DockSite.BeforeDockingStartsEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("裉꧋꣍뿏ꃑ뇓鋕럗맙럛럝軟藡럣鋥觧飩飫鷭", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::DevComponents.WpfDock.DockRoutedEventHandler), typeof(global::DevComponents.WpfDock.DockSite));
			global::DevComponents.WpfDock.DockSite.BeforeDockedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("裉꧋꣍뿏ꃑ뇓鋕럗맙럛믝蓟", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::DevComponents.WpfDock.BeforeDockedRoutedEventHandler), typeof(global::DevComponents.WpfDock.DockSite));
			global::DevComponents.WpfDock.DockSite.AfterDockedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("诉꫋뫍뗏ꃑ郓맕믗뇙맛뫝", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::DevComponents.WpfDock.DockRoutedEventHandler), typeof(global::DevComponents.WpfDock.DockSite));
			global::DevComponents.WpfDock.DockSite.IsDocumentChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("菉뿋諍뿏뇑ꇓ믕뷗듙꣛鷝裟菡諣臥跧軩", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfDock.DockSite));
			global::DevComponents.WpfDock.DockSite.LicenseKeyProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蛉ꗋ귍뗏병ꟓ돕鏗뿙ꗛ", a_), typeof(string), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.FrameworkPropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockSite.a)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfDock.DockSite), global::DevComponents.WpfDock.DockWindow.ActivatedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfDock.DockSite.b));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfDock.DockSite), global::DevComponents.WpfDock.DockWindow.DeactivatedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfDock.DockSite.a));
			global::DevComponents.WpfDock.DockSite.DockHintOverlayProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("軉ꏋ귍믏髑뷓룕곗闙ꫛ믝鋟軡藣鿥", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockSite.f)));
			global::DevComponents.WpfDock.DockSite.DockSelectorOverlayProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("軉ꏋ귍믏臑뇓뫕뷗맙꣛뇝鋟귡鋣菥髧蛩跫韭", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockSite), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockSite.e)));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006DE8 File Offset: 0x00004FE8
		public DockSite()
		{
			base.SetValue(global::DevComponents.WpfDock.DockSite.b, new global::DevComponents.WpfDock.SplitPanelCollection(this));
			this.d = new global::System.Windows.Controls.UIElementCollection(this, this);
			base.Unloaded += this.c;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006E4C File Offset: 0x0000504C
		private static void f(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_B6;
			}
			short num;
			int num4;
			global::DevComponents.WpfDock.DockSite dockSite;
			for (;;)
			{
				IL_0A:
				num = (short)880997337;
				short num2 = num;
				num = (short)730461145;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)1751646208;
					short num3 = num;
					break;
				}
				}
				num = (short)1847066625;
				if (num != 0)
				{
				}
				num = (short)412286976;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					return;
				case 1:
					dockSite.OnDockHintOverlayChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num = (short)1083310080;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (dockSite != null)
					{
						num = (short)235339777;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_B6;
			}
			return;
			IL_B6:
			dockSite = (A_0 as global::DevComponents.WpfDock.DockSite);
			num = (short)382140418;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006F84 File Offset: 0x00005184
		private static void e(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_8F;
			}
			short num;
			int num4;
			global::DevComponents.WpfDock.DockSite dockSite;
			for (;;)
			{
				IL_0A:
				num = (short)456552343;
				short num2 = num;
				num = (short)393965463;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)1616248832;
					short num3 = num;
					break;
				}
				}
				num = (short)1008402432;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					return;
				case 1:
					num = (short)932642817;
					if (num != 0)
					{
					}
					dockSite.OnDockSelectorOverlayChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num = (short)1857355776;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (dockSite != null)
					{
						num = (short)1414791169;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_8F;
			}
			return;
			IL_8F:
			dockSite = (A_0 as global::DevComponents.WpfDock.DockSite);
			num = (short)674758658;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000070BC File Offset: 0x000052BC
		protected virtual void OnDockHintOverlayChanged(bool oldValue, bool newValue)
		{
			short num = (short)818348033;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)894793598;
				short num3 = num;
				num = (short)747403134;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F1;
				case 1:
					break;
				default:
				{
					num = (short)2081095680;
					short num4 = num;
					break;
				}
				}
				num = (short)406061056;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_160;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_AE;
					}
					continue;
				case 2:
					if (this.x != null)
					{
						num = (short)1175257088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_113;
				case 4:
					num = (short)1655832577;
					if (num != 0)
					{
					}
					num = (short)1665269762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AE:
				if (!newValue)
				{
					num = (short)1395261444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F1:
				this.x = new global::DevComponents.WpfDock.f();
				num = (short)350879747;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_113:
			return;
			IL_160:
			this.x.Close();
			this.x = null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000722C File Offset: 0x0000542C
		protected virtual void OnDockSelectorOverlayChanged(bool oldValue, bool newValue)
		{
			short num = (short)180551681;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					this.y.Close();
					this.y = null;
					num = (short)186712064;
					short num3 = num;
					num = (short)682622979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
					if (this.y != null)
					{
						num = (short)1364787200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
				{
					num = (short)583035161;
					short num4 = num;
					num = (short)905668889;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)999227393;
						if (num != 0)
						{
						}
						num = (short)242286592;
						if (num != 0)
						{
						}
						num = (short)865206274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_38:
				if (newValue)
				{
					break;
				}
				num = (short)115867652;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00007394 File Offset: 0x00005594
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00007450 File Offset: 0x00005650
		[global::System.ComponentModel.Description("Indicates whether docking hint overlay is used to display the docking hints. Set to true so dock hints overlay windows forms controls")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool DockHintOverlay
		{
			get
			{
				short num = (short)570827271;
				short num2 = num;
				num = (short)1870406151;
				switch (num2 == num)
				{
				}
				num = (short)2079588352;
				if (num != 0)
				{
				}
				num = (short)2092105729;
				if (num != 0)
				{
				}
				num = (short)1590689792;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockSite.DockHintOverlayProperty);
			}
			set
			{
				short num = (short)2073655615;
				short num2 = num;
				num = (short)1635285311;
				switch (num2 == num)
				{
				}
				num = (short)1720385536;
				if (num != 0)
				{
				}
				num = (short)373817345;
				if (num != 0)
				{
				}
				num = (short)903544832;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockSite.DockHintOverlayProperty, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00007508 File Offset: 0x00005708
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000075C0 File Offset: 0x000057C0
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("Indicates whether a translucent overlay window is used to display the dock selector. Set to true so dock hints overlay windows forms controls")]
		public bool DockSelectorOverlay
		{
			get
			{
				short num = (short)2019620864;
				short num2 = num;
				num = (short)797636608;
				switch (num2 == num)
				{
				}
				num = (short)1151008769;
				if (num != 0)
				{
				}
				num = (short)899612672;
				if (num != 0)
				{
				}
				num = (short)1758658560;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockSite.DockSelectorOverlayProperty);
			}
			set
			{
				short num = (short)1409438116;
				short num2 = num;
				num = (short)1184715172;
				switch (num2 == num)
				{
				}
				num = (short)1793392640;
				if (num != 0)
				{
				}
				num = (short)426639361;
				if (num != 0)
				{
				}
				num = (short)513998848;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockSite.DockSelectorOverlayProperty, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000767C File Offset: 0x0000587C
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00007728 File Offset: 0x00005928
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IgnoreLoadLayoutElementNotFoundErrors
		{
			get
			{
				short num = (short)407880396;
				short num2 = num;
				num = (short)474596044;
				switch (num2 == num)
				{
				}
				num = (short)1795031041;
				if (num != 0)
				{
				}
				num = (short)948961280;
				if (num != 0)
				{
				}
				num = (short)1645608960;
				short num3 = num;
				return this.z;
			}
			set
			{
				short num = (short)991933425;
				short num2 = num;
				num = (short)1125102577;
				switch (num2 == num)
				{
				}
				num = (short)994574337;
				if (num != 0)
				{
				}
				num = (short)1133182976;
				if (num != 0)
				{
				}
				num = (short)748814336;
				short num3 = num;
				this.z = value;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000077D4 File Offset: 0x000059D4
		private void c(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)735969282;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.y.Close();
					this.y = null;
					num = (short)1488125956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.y != null)
					{
						num = (short)749273088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B9;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 3:
					this.g.Close();
					this.g.KeyDown -= this.c;
					this.g = null;
					num = (short)1117454342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)712835072;
					short num3 = num;
					goto IL_B9;
				}
				case 5:
				{
					num = (short)2096292743;
					short num4 = num;
					num = (short)1875960711;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1BC;
					default:
						num = (short)827260928;
						if (num != 0)
						{
						}
						this.x.Close();
						this.x = null;
						num = (short)1698496519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_1BC;
				case 7:
					goto IL_1E4;
				case 8:
					if (this.g != null)
					{
						num = (short)1335689219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_48:
				if (this.x != null)
				{
					num = (short)1486094341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1E4;
				IL_B9:
				num = (short)1839857672;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E4:
				num = (short)1684537345;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1BC:
			num = (short)561119233;
			if (num != 0)
			{
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600005F RID: 95 RVA: 0x00007A04 File Offset: 0x00005C04
		// (remove) Token: 0x06000060 RID: 96 RVA: 0x00007AB8 File Offset: 0x00005CB8
		public event global::System.Windows.RoutedEventHandler DockChanged
		{
			add
			{
				short num = (short)571536878;
				short num2 = num;
				num = (short)1009186286;
				switch (num2 == num)
				{
				}
				num = (short)2111766528;
				short num3 = num;
				num = (short)2100297729;
				if (num != 0)
				{
				}
				num = (short)759758848;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockSite.DockChangedEvent, value);
			}
			remove
			{
				short num = (short)1062722595;
				short num2 = num;
				num = (short)125688867;
				switch (num2 == num)
				{
				}
				num = (short)1215692800;
				short num3 = num;
				num = (short)1630404609;
				if (num != 0)
				{
				}
				num = (short)1670905856;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockSite.DockChangedEvent, value);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000061 RID: 97 RVA: 0x00007B6C File Offset: 0x00005D6C
		// (remove) Token: 0x06000062 RID: 98 RVA: 0x00007C24 File Offset: 0x00005E24
		public event global::System.Windows.RoutedEventHandler IsDocumentChanged
		{
			add
			{
				short num = (short)1057482563;
				short num2 = num;
				num = (short)1000662851;
				switch (num2 == num)
				{
				}
				num = (short)113442816;
				short num3 = num;
				num = (short)78643201;
				if (num != 0)
				{
				}
				num = (short)2080309248;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockSite.IsDocumentChangedEvent, value);
			}
			remove
			{
				short num = (short)489340770;
				short num2 = num;
				num = (short)1989132130;
				switch (num2 == num)
				{
				}
				num = (short)1761542144;
				short num3 = num;
				num = (short)2011627521;
				if (num != 0)
				{
				}
				num = (short)414515200;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockSite.IsDocumentChangedEvent, value);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000063 RID: 99 RVA: 0x00007CDC File Offset: 0x00005EDC
		// (remove) Token: 0x06000064 RID: 100 RVA: 0x00007D94 File Offset: 0x00005F94
		public event global::DevComponents.WpfDock.DockRoutedEventHandler BeforeDockingStarts
		{
			add
			{
				short num = (short)616804398;
				short num2 = num;
				num = (short)1131720750;
				switch (num2 == num)
				{
				}
				num = (short)492109824;
				short num3 = num;
				num = (short)2045509633;
				if (num != 0)
				{
				}
				num = (short)727842816;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockSite.BeforeDockingStartsEvent, value);
			}
			remove
			{
				short num = (short)1854832430;
				short num2 = num;
				num = (short)1574076206;
				switch (num2 == num)
				{
				}
				num = (short)1815085056;
				short num3 = num;
				num = (short)2136014849;
				if (num != 0)
				{
				}
				num = (short)343212032;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockSite.BeforeDockingStartsEvent, value);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000065 RID: 101 RVA: 0x00007E4C File Offset: 0x0000604C
		// (remove) Token: 0x06000066 RID: 102 RVA: 0x00007F00 File Offset: 0x00006100
		public event global::DevComponents.WpfDock.BeforeDockedRoutedEventHandler BeforeDocked
		{
			add
			{
				short num = (short)269497284;
				short num2 = num;
				num = (short)1316303812;
				switch (num2 == num)
				{
				}
				num = (short)383188992;
				short num3 = num;
				num = (short)1302331393;
				if (num != 0)
				{
				}
				num = (short)728629248;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockSite.BeforeDockedEvent, value);
			}
			remove
			{
				short num = (short)1691188926;
				short num2 = num;
				num = (short)1382448830;
				switch (num2 == num)
				{
				}
				num = (short)1519517696;
				short num3 = num;
				num = (short)1097400321;
				if (num != 0)
				{
				}
				num = (short)1758658560;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockSite.BeforeDockedEvent, value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000067 RID: 103 RVA: 0x00007FB4 File Offset: 0x000061B4
		// (remove) Token: 0x06000068 RID: 104 RVA: 0x00008068 File Offset: 0x00006268
		public event global::DevComponents.WpfDock.DockRoutedEventHandler AfterDocked
		{
			add
			{
				short num = (short)2088761613;
				short num2 = num;
				num = (short)1003354381;
				switch (num2 == num)
				{
				}
				num = (short)139853824;
				short num3 = num;
				num = (short)269418497;
				if (num != 0)
				{
				}
				num = (short)57016320;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockSite.AfterDockedEvent, value);
			}
			remove
			{
				short num = (short)1634380526;
				short num2 = num;
				num = (short)469936878;
				switch (num2 == num)
				{
				}
				num = (short)550961152;
				short num3 = num;
				num = (short)586153985;
				if (num != 0)
				{
				}
				num = (short)119078912;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockSite.AfterDockedEvent, value);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00008120 File Offset: 0x00006320
		protected override void OnInitialized(global::System.EventArgs e)
		{
			short num = (short)747376782;
			short num2 = num;
			num = (short)1627984014;
			switch (num2 == num)
			{
			}
			num = (short)1969487872;
			short num3 = num;
			num = (short)1256194049;
			if (num != 0)
			{
			}
			num = (short)1127677952;
			if (num != 0)
			{
			}
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfDock.DockWindow.ToggleAutoHide, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.h), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.h)));
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfDock.DockWindow.OpenAutoHide, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.g), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.g)));
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfDock.DockWindow.CloseAutoHide, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.f), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.f)));
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfDock.DockWindow.CloseWindow, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.e), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.e)));
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfDock.DockWindow.ReDockWindow, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.d), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.d)));
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfDock.DockWindow.FloatWindow, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.c), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.c)));
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfDock.DockWindow.DockAsDocumentWindow, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.b), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.b)));
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfDock.DockWindow.SelectWindow, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.a), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.a)));
			base.OnInitialized(e);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008340 File Offset: 0x00006540
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)323051101;
			short num2 = num;
			num = (short)112090717;
			switch (num2 == num)
			{
			}
			num = (short)403832832;
			short num3 = num;
			num = (short)18546688;
			if (num != 0)
			{
			}
			num = (short)1411579905;
			if (num != 0)
			{
			}
			return this.a(constraint, false);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000083F0 File Offset: 0x000065F0
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeBounds)
		{
			if (!global::DevComponents.WpfDock.j.c)
			{
				short num = (short)542769152;
				short num2 = num;
				num = (short)69254540;
				short num3 = num;
				num = (short)1592638860;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1023410177;
					if (num != 0)
					{
					}
					num = (short)815071232;
					if (num != 0)
					{
					}
					return arrangeBounds;
				}
			}
			return this.a(arrangeBounds, true);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000084B0 File Offset: 0x000066B0
		private global::System.Windows.Size a(global::System.Windows.Size A_0, bool A_1)
		{
			short num = (short)433717248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CE;
				}
				global::System.Windows.Rect finalRect;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfDock.SplitPanel> enumerator;
					switch (num2)
					{
					case 0:
						if (A_1)
						{
							num = (short)857145360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.n.Measure(finalRect.Size);
						num = (short)1505951752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1884356609;
						if (num != 0)
						{
						}
						num = (short)1007157269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_C53;
					case 3:
						if (A_1)
						{
							num = (short)1617166355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.q.Measure(finalRect.Size);
						num = (short)297533467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_8C1;
					case 5:
						num = (short)597164038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (base.Content is global::System.Windows.UIElement)
						{
							num = (short)434176001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA8;
					case 7:
						try
						{
							num = (short)1180696579;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::DevComponents.WpfDock.SplitPanel splitPanel;
								global::System.Windows.Size desiredSize;
								switch (num2)
								{
								case 0:
									if (finalRect.Height > 0.0)
									{
										num = (short)1582956567;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DB;
								case 1:
									goto IL_1DB;
								case 2:
								{
									global::System.Windows.Controls.Dock dock = global::DevComponents.WpfDock.DockSite.GetDock(splitPanel);
									global::System.Windows.Rect empty = global::System.Windows.Rect.Empty;
									desiredSize = splitPanel.DesiredSize;
									num = (short)1613234192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1D6;
									}
									continue;
								case 4:
								{
									global::System.Windows.Controls.Dock dock;
									if (dock == global::System.Windows.Controls.Dock.Left)
									{
										num = (short)684589089;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)386924571;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1453654040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Windows.Rect empty = new global::System.Windows.Rect(finalRect.X, finalRect.Bottom - desiredSize.Height, finalRect.Width, desiredSize.Height);
									finalRect.Height = global::System.Math.Max(0.0, finalRect.Height - desiredSize.Height);
									num = (short)190840840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1771503616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_5DA;
								case 9:
								{
									global::System.Windows.Rect empty = new global::System.Windows.Rect(finalRect.X, finalRect.Y, finalRect.Width, desiredSize.Height);
									finalRect.Height = global::System.Math.Max(0.0, finalRect.Height - desiredSize.Height);
									finalRect.Y += desiredSize.Height;
									num = (short)2042691602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (desiredSize.Width > finalRect.Width)
									{
										num = (short)865730590;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DB;
								case 11:
									goto IL_404;
								case 12:
									goto IL_1DB;
								case 13:
									num = (short)655425573;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::System.Windows.Controls.Dock dock;
									if (dock == global::System.Windows.Controls.Dock.Bottom)
									{
										num = (short)51183622;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5DA;
								}
								case 15:
								{
									global::System.Windows.Controls.Dock dock;
									if (dock == global::System.Windows.Controls.Dock.Top)
									{
										num = (short)951320585;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2127364110;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									if (!A_1)
									{
										num = (short)19857413;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DB;
								case 17:
									goto IL_5DA;
								case 18:
									goto IL_5DA;
								case 20:
									num = (short)346488860;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									if (finalRect.Width > 0.0)
									{
										num = (short)1402011684;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DB;
								case 23:
									desiredSize.Height = finalRect.Height;
									num = (short)1718550529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
								{
									global::System.Windows.Controls.Dock dock;
									if (dock != global::System.Windows.Controls.Dock.Left)
									{
										num = (short)1241120781;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_404;
								}
								case 25:
								{
									global::System.Windows.Rect empty = new global::System.Windows.Rect(finalRect.Right - desiredSize.Width, finalRect.Y, desiredSize.Width, finalRect.Height);
									finalRect.Width = global::System.Math.Max(0.0, finalRect.Width - desiredSize.Width);
									num = (short)1702559761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
								{
									if (A_1)
									{
										num = (short)1557921827;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Rect empty;
									splitPanel.Measure(empty.Size);
									num = (short)544407571;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 27:
								{
									global::System.Windows.Controls.Dock dock;
									if (dock == global::System.Windows.Controls.Dock.Right)
									{
										num = (short)594018329;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)295370767;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 28:
									goto IL_84F;
								case 29:
									goto IL_5DA;
								case 30:
									num = (short)1062338581;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									if (desiredSize.Height > finalRect.Height)
									{
										num = (short)246677511;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DB;
								case 32:
									if (!enumerator.MoveNext())
									{
										num = (short)985137172;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									splitPanel = enumerator.Current;
									num = (short)1831600162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
								{
									global::System.Windows.Rect empty = new global::System.Windows.Rect(finalRect.X, finalRect.Y, desiredSize.Width, finalRect.Height);
									finalRect.Width = global::System.Math.Max(0.0, finalRect.Width - desiredSize.Width);
									finalRect.X += desiredSize.Width;
									num = (short)1307705373;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 34:
									if (splitPanel.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)50200578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 35:
								{
									global::System.Windows.Rect empty;
									splitPanel.Arrange(empty);
									num = (short)1846018070;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 36:
									desiredSize.Width = finalRect.Width;
									num = (short)1548877836;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
								{
									global::System.Windows.Controls.Dock dock;
									if (dock == global::System.Windows.Controls.Dock.Right)
									{
										num = (short)1719992331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									desiredSize.Height = global::DevComponents.WpfDock.DockSite.GetDockSize(splitPanel);
									desiredSize.Width = finalRect.Width;
									num = (short)1308164127;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_1D6;
								IL_1DB:
								num = (short)2066874372;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_404:
								desiredSize.Width = global::DevComponents.WpfDock.DockSite.GetDockSize(splitPanel);
								desiredSize.Height = finalRect.Height;
								num = (short)538902538;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5DA:
								num = (short)937295898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_690:
								num = (short)1620377632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D6:
								goto IL_690;
							}
							IL_84F:
							goto IL_E5C;
						}
						finally
						{
							num = (short)1608187904;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_888;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1058340866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_8BE;
								}
								IL_888:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1097859073;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8BE:;
						}
						goto IL_8C1;
						IL_E5C:
						this.e = finalRect;
						num = (short)1411121186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_EA3;
					case 9:
					{
						num = (short)1439825920;
						short num3 = num;
						if (A_1)
						{
							num = (short)775815172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.o.Measure(finalRect.Size);
						num = (short)1428488230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_C95;
					case 11:
						if (this.n != null)
						{
							num = (short)642842661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0E;
					case 12:
						if (this.p != null)
						{
							num = (short)704315425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C53;
					case 13:
						((global::System.Windows.UIElement)base.Content).Arrange(finalRect);
						num = (short)1534197780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						global::DevComponents.WpfDock.i.a(ref A_0);
						num = (short)139067420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_FE5;
					case 16:
						this.n.Arrange(new global::System.Windows.Rect(finalRect.X, finalRect.Y, this.n.DesiredSize.Width, finalRect.Height));
						num = (short)677969937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_EA3;
					case 18:
						goto IL_9A4;
					case 19:
						this.q.Arrange(new global::System.Windows.Rect(finalRect.X, finalRect.Bottom - this.q.DesiredSize.Height, finalRect.Width, this.q.DesiredSize.Height));
						num = (short)982712349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_FA8;
					case 21:
						if (A_1)
						{
							num = (short)1393819661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::System.Windows.UIElement)base.Content).Measure(finalRect.Size);
						num = (short)1048600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						num = (short)1089825290;
						short num4 = num;
						num = (short)75655690;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A13;
						default:
							num = (short)454230016;
							if (num != 0)
							{
							}
							goto IL_A13;
						}
						break;
					}
					case 23:
						if (!A_1)
						{
							num = (short)1280573454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return A_0;
					case 24:
						goto IL_FA8;
					case 25:
						num = (short)1791295497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_F0E;
					case 27:
						goto IL_DDD;
					case 28:
						return A_0;
					case 29:
						goto IL_DDD;
					case 30:
						if (this.q != null)
						{
							num = (short)585760807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C95;
					case 31:
						if (A_1)
						{
							num = (short)232194080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.p.Measure(finalRect.Size);
						num = (short)253362211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						this.p.Arrange(new global::System.Windows.Rect(finalRect.X, finalRect.Y, finalRect.Width, this.p.DesiredSize.Height));
						num = (short)615383058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)509542431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (base.HasContent)
						{
							num = (short)775684101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA8;
					case 35:
						goto IL_9A4;
					case 36:
						if (this.o != null)
						{
							num = (short)1916469273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A13;
					case 37:
						num = (short)619511808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_FE5;
					case 39:
						num = (short)1945042947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CE;
					IL_8C1:
					this.o.Arrange(new global::System.Windows.Rect(finalRect.Right - this.o.DesiredSize.Width, finalRect.Y, this.o.DesiredSize.Width, finalRect.Height));
					num = (short)1972502543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A4:
					finalRect.Height = global::System.Math.Max(0.0, finalRect.Height - this.p.DesiredSize.Height);
					finalRect.Y += this.p.DesiredSize.Height;
					num = (short)1792081922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A13:
					enumerator = this.SplitPanels.GetEnumerator();
					num = (short)1945960455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C53:
					num = (short)274530334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C95:
					num = (short)364904459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DDD:
					finalRect.Height = global::System.Math.Max(0.0, finalRect.Height - this.q.DesiredSize.Height);
					num = (short)358023178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EA3:
					finalRect.X += this.n.DesiredSize.Width;
					finalRect.Width = global::System.Math.Max(0.0, finalRect.Width - this.n.DesiredSize.Width);
					num = (short)131098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F0E:
					num = (short)91750436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FA8:
					num = (short)1751253015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FE5:
					finalRect.Width = global::System.Math.Max(0.0, finalRect.Width - this.o.DesiredSize.Width);
					num = (short)297730070;
					num2 = (int)((global::System.IntPtr)num);
				}
				return A_0;
				IL_CE:
				finalRect = new global::System.Windows.Rect(A_0);
				num = (short)2051604492;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00009558 File Offset: 0x00007758
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		[global::System.ComponentModel.Description("Gets system text used by the component..")]
		[global::System.ComponentModel.Category("Localization")]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.NotifyParentProperty(true)]
		public global::DevComponents.WpfDock.DockLocalization SystemText
		{
			get
			{
				short num = (short)1539293115;
				short num2 = num;
				num = (short)89309115;
				switch (num2 == num)
				{
				}
				num = (short)1747714048;
				short num3 = num;
				num = (short)870842368;
				if (num != 0)
				{
				}
				num = (short)1705181185;
				if (num != 0)
				{
				}
				return this.u;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00009608 File Offset: 0x00007808
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static global::System.Windows.Controls.Dock GetDock(global::System.Windows.UIElement element)
		{
			int a_ = 19;
			short num = (short)1615593473;
			if (num != 0)
			{
			}
			if (element == null)
			{
				num = (short)274870669;
				short num2 = num;
				num = (short)629223821;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2067005440;
					short num3 = num;
					num = (short)1800011776;
					if (num != 0)
					{
					}
					break;
				}
				}
				throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("럑룓돕뗗뿙닛ꫝ", a_));
			}
			return (global::System.Windows.Controls.Dock)element.GetValue(global::DevComponents.WpfDock.DockSite.DockProperty);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000096E4 File Offset: 0x000078E4
		public static void SetDock(global::System.Windows.UIElement element, global::System.Windows.Controls.Dock d)
		{
			int a_ = 2;
			short num = (short)1862598657;
			if (num != 0)
			{
			}
			if (element == null)
			{
				num = (short)470563506;
				short num2 = num;
				num = (short)1416182450;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1241317376;
					short num3 = num;
					num = (short)1174470656;
					if (num != 0)
					{
					}
					break;
				}
				}
				throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("꓀꿂ꃄ꫆곈ꗊ만", a_));
			}
			element.SetValue(global::DevComponents.WpfDock.DockSite.DockProperty, d);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000097C0 File Offset: 0x000079C0
		private static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1905658391;
			short num2 = num;
			num = (short)1751976471;
			global::System.Windows.Controls.Dock dock;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D0:
				dock = (global::System.Windows.Controls.Dock)A_1.NewValue;
				num = (short)753926148;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1253179392;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				break;
			}
			global::DevComponents.WpfDock.SplitPanel splitPanel;
			for (;;)
			{
				IL_55:
				global::System.Windows.UIElement uielement;
				switch (num3)
				{
				case 0:
					goto IL_126;
				case 1:
					if (uielement != null)
					{
						num = (short)129302530;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)1393688576;
					short num4 = num;
					uielement.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfDock.DockSite.DockChangedEvent));
					num = (short)1907556357;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_D0;
				case 4:
					splitPanel.Orientation = ((dock == global::System.Windows.Controls.Dock.Left || dock == global::System.Windows.Controls.Dock.Right) ? global::System.Windows.Controls.Orientation.Vertical : global::System.Windows.Controls.Orientation.Horizontal);
					num = (short)354287616;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					if (splitPanel != null)
					{
						num = (short)1020067843;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_126;
				}
				goto IL_77;
				IL_126:
				uielement = (A_0 as global::System.Windows.UIElement);
				num = (short)1681457153;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_77:
			splitPanel = (A_0 as global::DevComponents.WpfDock.SplitPanel);
			num = (short)297992193;
			if (num != 0)
			{
			}
			num = (short)1117716486;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00009984 File Offset: 0x00007B84
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static double GetDockSize(global::System.Windows.UIElement element)
		{
			int a_ = 6;
			short num = (short)2111265373;
			short num2 = num;
			num = (short)356080221;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BD;
			case 1:
				break;
			default:
			{
				num = (short)149159936;
				short num3 = num;
				break;
			}
			}
			num = (short)1967849473;
			if (num != 0)
			{
			}
			num = (short)1728184320;
			if (num != 0)
			{
			}
			if (element == null)
			{
				throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꃄꯆ곈ꛊ꣌ꇎꗐ", a_));
			}
			IL_BD:
			return (double)element.GetValue(global::DevComponents.WpfDock.DockSite.DockSizeProperty);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00009A60 File Offset: 0x00007C60
		public static void SetDockSize(global::System.Windows.UIElement element, double d)
		{
			int a_ = 4;
			short num = (short)1731843189;
			short num2 = num;
			num = (short)1571017845;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BA;
			case 1:
				break;
			default:
			{
				num = (short)1986854912;
				short num3 = num;
				break;
			}
			}
			num = (short)2142240769;
			if (num != 0)
			{
			}
			num = (short)1858600960;
			if (num != 0)
			{
			}
			if (element == null)
			{
				throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꛂ꧄ꋆ꓈껊ꏌ믎", a_));
			}
			IL_BA:
			element.SetValue(global::DevComponents.WpfDock.DockSite.DockSizeProperty, d);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00009B38 File Offset: 0x00007D38
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
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (uielement != null)
						{
							num2 = (short)632094720;
							short num3 = num2;
							num2 = (short)1024131076;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						goto IL_A4;
					case 2:
					{
						num2 = (short)1087271517;
						short num4 = num2;
						num2 = (short)673346141;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B;
						default:
						{
							num2 = (short)267255808;
							if (num2 != 0)
							{
							}
							global::System.Windows.UIElement uielement2;
							uielement2.InvalidateMeasure();
							num2 = (short)333053953;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						global::System.Windows.UIElement uielement2;
						if (uielement2 != null)
						{
							num2 = (short)1439105026;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 4:
					{
						uielement.InvalidateMeasure();
						global::System.Windows.UIElement uielement2 = global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::System.Windows.UIElement;
						num2 = (short)986972163;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_24;
				}
				IL_A4:
				num2 = (short)1365508097;
				if (num2 != 0)
				{
				}
				return;
			}
			IL_24:
			uielement = (global::System.Windows.UIElement)A_0;
			IL_2B:
			num2 = (short)1613299712;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00009CAC File Offset: 0x00007EAC
		public static bool GetIsDocument(global::System.Windows.UIElement element)
		{
			int a_ = 6;
			short num = (short)1331461395;
			short num2 = num;
			num = (short)1465810195;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BD;
			case 1:
				break;
			default:
			{
				num = (short)497614848;
				short num3 = num;
				break;
			}
			}
			num = (short)73728001;
			if (num != 0)
			{
			}
			num = (short)655360000;
			if (num != 0)
			{
			}
			if (element == null)
			{
				throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꃄꯆ곈ꛊ꣌ꇎꗐ", a_));
			}
			IL_BD:
			return (bool)element.GetValue(global::DevComponents.WpfDock.DockSite.IsDocumentProperty);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00009D88 File Offset: 0x00007F88
		public static void SetIsDocument(global::System.Windows.UIElement element, bool doc)
		{
			int a_ = 14;
			short num = (short)434377749;
			short num2 = num;
			num = (short)904205333;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BE;
			case 1:
				break;
			default:
			{
				num = (short)319094784;
				short num3 = num;
				break;
			}
			}
			num = (short)1765605377;
			if (num != 0)
			{
			}
			num = (short)1828257792;
			if (num != 0)
			{
			}
			if (element == null)
			{
				throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("꣌ꏎ듐뻒냔맖귘", a_));
			}
			IL_BE:
			element.SetValue(global::DevComponents.WpfDock.DockSite.IsDocumentProperty, doc);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00009E64 File Offset: 0x00008064
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::System.Windows.UIElement uielement;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (uielement != null)
					{
						num2 = (short)777781250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_F3;
				case 2:
					uielement.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfDock.DockSite.IsDocumentChangedEvent));
					num2 = (short)1269825537;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_F3:
			num2 = (short)908787712;
			short num3 = num2;
			return;
			IL_1C:
			uielement = (A_0 as global::System.Windows.UIElement);
			num2 = (short)448327000;
			short num4 = num2;
			num2 = (short)1967189336;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)648085505;
				if (num2 != 0)
				{
				}
				num2 = (short)1168965632;
				if (num2 != 0)
				{
				}
				num2 = (short)1726742528;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00009F90 File Offset: 0x00008190
		public static bool GetSaveLayout(global::System.Windows.UIElement element)
		{
			int a_ = 5;
			short num = (short)671746496;
			short num2 = num;
			num = (short)1934494144;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BE;
			case 1:
				break;
			default:
			{
				num = (short)1230241792;
				short num3 = num;
				break;
			}
			}
			num = (short)1413021696;
			if (num != 0)
			{
			}
			num = (short)2111045633;
			if (num != 0)
			{
			}
			if (element == null)
			{
				throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꇃ꫅귇Ꟊ꧋ꃍ꓏", a_));
			}
			IL_BE:
			return (bool)element.GetValue(global::DevComponents.WpfDock.DockSite.SaveLayoutProperty);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000A06C File Offset: 0x0000826C
		public static void SetSaveLayout(global::System.Windows.UIElement element, bool saveLayout)
		{
			int a_ = 9;
			short num = (short)1265426481;
			short num2 = num;
			num = (short)2122702897;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BB;
			case 1:
				break;
			default:
			{
				num = (short)1225195520;
				short num3 = num;
				break;
			}
			}
			num = (short)463011840;
			if (num != 0)
			{
			}
			num = (short)1083899905;
			if (num != 0)
			{
			}
			if (element == null)
			{
				throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("귇ꛉ꧋ꏍ뗏병ꃓ", a_));
			}
			IL_BB:
			element.SetValue(global::DevComponents.WpfDock.DockSite.SaveLayoutProperty, saveLayout);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000A148 File Offset: 0x00008348
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::DevComponents.WpfDock.SplitPanelCollection SplitPanels
		{
			get
			{
				short num = (short)1320026112;
				short num2 = num;
				num = (short)1711111622;
				short num3 = num;
				num = (short)1690795462;
				switch (num3 == num)
				{
				}
				num = (short)1647575040;
				if (num != 0)
				{
				}
				num = (short)268238849;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfDock.SplitPanelCollection)base.GetValue(global::DevComponents.WpfDock.DockSite.SplitPanelsProperty);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000A200 File Offset: 0x00008400
		internal void c(global::DevComponents.WpfDock.SplitPanel A_0)
		{
			short num = (short)152829952;
			short num2 = num;
			num = (short)1856422067;
			short num3 = num;
			num = (short)1731969203;
			switch (num3 == num)
			{
			}
			num = (short)1980170241;
			if (num != 0)
			{
			}
			num = (short)1750138880;
			if (num != 0)
			{
			}
			this.d.Add(A_0);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000A2B8 File Offset: 0x000084B8
		internal void d(global::DevComponents.WpfDock.SplitPanel A_0)
		{
			short num = (short)291176448;
			short num2 = num;
			num = (short)94804111;
			short num3 = num;
			num = (short)874748047;
			switch (num3 == num)
			{
			}
			num = (short)1846280193;
			if (num != 0)
			{
			}
			num = (short)1007681536;
			if (num != 0)
			{
			}
			this.d.Remove(A_0);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000A36C File Offset: 0x0000856C
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			short num = (short)1774452736;
			short num2 = num;
			num = (short)782900146;
			short num3 = num;
			num = (short)1921915826;
			switch (num3 == num)
			{
			}
			num = (short)1878327296;
			if (num != 0)
			{
			}
			num = (short)89784321;
			if (num != 0)
			{
			}
			return this.d[index];
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000A424 File Offset: 0x00008624
		protected override int VisualChildrenCount
		{
			get
			{
				short num = (short)1485242368;
				short num2 = num;
				num = (short)1812656741;
				short num3 = num;
				num = (short)796717669;
				switch (num3 == num)
				{
				}
				num = (short)1787101184;
				if (num != 0)
				{
				}
				num = (short)2122055681;
				if (num != 0)
				{
				}
				return this.d.Count;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000A4D8 File Offset: 0x000086D8
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			short num = (short)91357189;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BB;
				case 1:
					goto IL_C0;
				case 2:
					if (newContent is global::DevComponents.WpfDock.SplitPanel)
					{
						num = (short)61472768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::DevComponents.WpfDock.DockSite.SetIsDocument((global::System.Windows.UIElement)newContent, true);
					num = (short)982908931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					goto IL_C0;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 6:
					this.d.Remove((global::System.Windows.UIElement)oldContent);
					num = (short)1046478857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.a(oldContent as global::DevComponents.WpfDock.SplitPanel, false);
					num = (short)735313924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_19F;
				case 9:
					if (oldContent is global::DevComponents.WpfDock.SplitPanel)
					{
						num = (short)459210759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::DevComponents.WpfDock.DockSite.SetIsDocument((global::System.Windows.UIElement)oldContent, false);
					num = (short)26017793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1909476785;
					short num3 = num;
					num = (short)1604406705;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19F;
					default:
					{
						num = (short)1354498048;
						short num4 = num;
						num = (short)1826357249;
						if (num != 0)
						{
						}
						num = (short)1316814848;
						if (num != 0)
						{
						}
						if (newContent is global::System.Windows.UIElement)
						{
							num = (short)307691528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					break;
				}
				}
				IL_51:
				if (oldContent is global::System.Windows.UIElement)
				{
					num = (short)1942945798;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C0:
				base.OnContentChanged(oldContent, newContent);
				num = (short)1247150090;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19F:
				this.d.Add((global::System.Windows.UIElement)newContent);
				num = (short)641335298;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BB:
			this.a(newContent as global::DevComponents.WpfDock.SplitPanel, true);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000A764 File Offset: 0x00008964
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::System.Windows.Rect DocumentRect
		{
			get
			{
				short num = (short)2113029562;
				short num2 = num;
				num = (short)1434273210;
				switch (num2 == num)
				{
				}
				num = (short)39649280;
				short num3 = num;
				num = (short)1080557568;
				if (num != 0)
				{
				}
				num = (short)74776577;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000A814 File Offset: 0x00008A14
		internal global::System.Windows.Size l()
		{
			short num = (short)1389090886;
			short num2 = num;
			num = (short)1301862470;
			switch (num2 == num)
			{
			}
			num = (short)429064192;
			short num3 = num;
			num = (short)1951072257;
			if (num != 0)
			{
			}
			num = (short)1428684800;
			if (num != 0)
			{
			}
			return this.MinimumDocumentAreaSize;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000A8C4 File Offset: 0x00008AC4
		protected virtual void OnBeforeDockingStarts(global::DevComponents.WpfDock.DockRoutedEventArgs e)
		{
			short num = (short)1834931636;
			short num2 = num;
			num = (short)147445172;
			switch (num2 == num)
			{
			}
			num = (short)265682944;
			short num3 = num;
			num = (short)48496640;
			if (num != 0)
			{
			}
			num = (short)1281294337;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000A978 File Offset: 0x00008B78
		private void a(global::System.Windows.Documents.AdornerLayer A_0, global::System.Windows.UIElement A_1, global::DevComponents.WpfDock.DockWindowGroup A_2)
		{
			short num = (short)2087976975;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_39D;
				case 1:
					if (A_2.CanDockTop)
					{
						num = (short)1320157196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_221;
				case 2:
					this.a(this.j);
					this.j = null;
					num = (short)499056657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1BD;
				case 4:
					goto IL_33A;
				case 5:
					this.j.l(this.a(global::DevComponents.WpfDock.eDockHintSide.Left));
					num = (short)362414091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					this.j.m(this.a(global::DevComponents.WpfDock.eDockHintSide.Right));
					num = (short)638483398;
					short num3 = num;
					num = (short)1828158406;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_352;
					default:
						num = (short)190906368;
						if (num != 0)
						{
						}
						num = (short)1598750724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
				{
					num = (short)1692598272;
					short num4 = num;
					this.j = new global::DevComponents.WpfDock.Primitives.d((this.x == null) ? A_1 : this.x.b());
					this.j.i(A_1);
					num = (short)852819987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					if (A_2.CanDockLeft)
					{
						num = (short)469237765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_286;
				case 9:
					goto IL_221;
				case 10:
					num = (short)892928001;
					if (num != 0)
					{
					}
					this.j.j(this.a(global::DevComponents.WpfDock.eDockHintSide.Bottom));
					num = (short)915472387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_286;
				case 12:
					this.j.k(this.a(global::DevComponents.WpfDock.eDockHintSide.Top));
					num = (short)869007369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (A_2.CanDockRight)
					{
						num = (short)575078406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_33A;
				case 14:
					this.j.n(this.a(global::DevComponents.WpfDock.eDockHintSide.AllSidesAndCenter));
					num = (short)1881538560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_74;
					}
					continue;
				case 16:
					goto IL_352;
				case 17:
					goto IL_C0;
				case 18:
					goto IL_3C8;
				case 19:
					if (A_2.CanDockBottom)
					{
						num = (short)1997602826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BD;
				}
				IL_74:
				if (this.j != null)
				{
					num = (short)37552130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C0:
				num = (short)21299207;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BD:
				num = (short)1044643841;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_221:
				num = (short)18677768;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_286:
				num = (short)1914306573;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_33A:
				num = (short)1223032848;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_352:
				if (A_2.CanDockAsDocument)
				{
					num = (short)335675406;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.j.n(this.a(global::DevComponents.WpfDock.eDockHintSide.AllSides));
					num = (short)1759772690;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_39D:
			IL_3C8:
			A_0.Add(this.j);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000AD5C File Offset: 0x00008F5C
		private global::System.Windows.Documents.AdornerLayer k()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::System.Windows.Documents.AdornerLayer result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!this.x.IsVisible)
					{
						num2 = (short)1636368387;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A0;
				case 1:
					goto IL_A0;
				case 2:
				{
					global::DevComponents.WpfDock.f f = new global::DevComponents.WpfDock.f();
					this.x = f;
					num2 = (short)699072520;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					this.x.Show();
					num2 = (short)465436673;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					if (this.DockHintOverlay)
					{
						num2 = (short)1712128000;
						short num3 = num2;
						num2 = (short)1281425413;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
					num2 = (short)552566670;
					short num4 = num2;
					num2 = (short)874872718;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1217069056;
						if (num2 != 0)
						{
						}
						num2 = (short)169017350;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					num2 = (short)1664745481;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					goto IL_EF;
				case 9:
					if (this.x == null)
					{
						num2 = (short)863633410;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EF;
				}
				goto IL_38;
				IL_A0:
				result = this.x.a();
				num2 = (short)1297743873;
				if (num2 != 0)
				{
				}
				num2 = (short)285016071;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_EF:
				global::System.Windows.Point point = base.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
				this.x.Left = point.X;
				this.x.Top = point.Y;
				this.x.Width = base.ActualWidth;
				this.x.Height = base.ActualHeight;
				num2 = (short)409010176;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_38:
			result = null;
			num2 = (short)1132527620;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000AFF8 File Offset: 0x000091F8
		internal bool a(global::DevComponents.WpfDock.DockWindowGroup A_0, bool A_1, global::DevComponents.WpfDock.eEventActionSource A_2)
		{
			short num = (short)1231618048;
			switch (num)
			{
			default:
			{
				num = (short)2115436550;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						num = (short)1589837831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!A_0.CanDockLeft)
						{
							num = (short)1538850831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B3;
					case 3:
						num = (short)310837250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!A_0.CanDockBottom)
						{
							num = (short)337772547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B3;
					case 5:
						if (!A_0.CanDockAsDocument)
						{
							num = (short)2029846536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B3;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 7:
						if (A_0.CanDockTop)
						{
							num = (short)900726800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_181;
					case 8:
						num = (short)630915076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::DevComponents.WpfDock.DockRoutedEventArgs dockRoutedEventArgs = new global::DevComponents.WpfDock.DockRoutedEventArgs(global::DevComponents.WpfDock.DockSite.BeforeDockingStartsEvent, this, A_1 ? A_0.SelectedDockWindow : A_0, A_2);
						this.OnBeforeDockingStarts(dockRoutedEventArgs);
						num = (short)2038235153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_216;
					case 11:
						num = (short)1554710533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (A_0 == null)
						{
							num = (short)869728269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1253376009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)676921345;
						if (num != 0)
						{
						}
						goto IL_181;
					case 14:
						if (!A_0.CanDockRight)
						{
							num = (short)1603010561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B3;
					case 15:
						num = (short)1719009294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_B3;
					case 17:
					{
						global::DevComponents.WpfDock.DockRoutedEventArgs dockRoutedEventArgs;
						if (dockRoutedEventArgs.Cancel)
						{
							num = (short)696713216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.aa = true;
						num = (short)135200778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_8C:
					if (!this.f)
					{
						num = (short)539099147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_181:
					num = (short)352426768;
					short num3 = num;
					num = (short)72260368;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8C;
					default:
						goto IL_1B5;
					}
					IL_B3:
					num = (short)733741068;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B5:
				num = (short)768475136;
				short num4 = num;
				num = (short)908525568;
				if (num != 0)
				{
				}
				return false;
				IL_216:
				bool result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_448;
					}
					for (;;)
					{
						IL_37D:
						global::System.Windows.Rect rect;
						global::System.Windows.Point point;
						global::System.Windows.Point point2;
						object obj;
						bool flag;
						switch (num2)
						{
						case 0:
							goto IL_C01;
						case 1:
						{
							global::System.Windows.Rect floatingRect;
							rect = floatingRect;
							num = (short)1783300119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_8F4;
						case 3:
							num = (short)383713324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::System.Windows.Size renderSize = A_0.RenderSize;
							num = (short)872742919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.Windows.Rect floatingRect = ((global::DevComponents.WpfDock.DockWindow)A_0.SelectedItem).FloatingRect;
							num = (short)710475822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_A11;
						case 7:
						{
							global::System.Windows.Size renderSize;
							if (renderSize.Height > 0.0)
							{
								num = (short)469827618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9BD;
						}
						case 8:
							if (A_0.IsFloating)
							{
								num = (short)819658755;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B68;
						case 9:
							point.Y = 8.0;
							num = (short)286195712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::DevComponents.WpfDock.FloatingWindow floatingWindow;
							if (point.X > floatingWindow.Width - 8.0)
							{
								num = (short)765657136;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A11;
						}
						case 11:
							goto IL_D36;
						case 12:
						{
							point.Y = -8.0;
							global::DevComponents.WpfDock.FloatingWindow floatingWindow;
							point.X = global::System.Math.Round(floatingWindow.Width / 2.0);
							num = (short)975962136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							num = (short)167116840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_C01;
						case 15:
							goto IL_C48;
						case 16:
							if (A_1)
							{
								num = (short)2089877516;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_ABB;
						case 17:
							if (!base.CaptureMouse())
							{
								num = (short)1734017045;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							rect = new global::System.Windows.Rect(0.0, 0.0, 150.0, 200.0);
							num = (short)1789788168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							point2.Offset(-point.X, point.Y);
							this.g.a = new global::System.Windows.Point(point.X, -point.Y);
							num = (short)1947533323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
						{
							global::System.Windows.Media.Animation.DoubleAnimation animation = new global::System.Windows.Media.Animation.DoubleAnimation(1.0, new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(200.0)));
							this.j.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, animation);
							num = (short)2094399519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
						{
							if (A_0.SelectedItem is global::DevComponents.WpfDock.DockWindow)
							{
								num = (short)851771397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.Size renderSize = A_0.RenderSize;
							num = (short)1463091232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							this.f = false;
							this.g.Hide();
							result = false;
							num = (short)193855490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
						{
							global::DevComponents.WpfDock.FloatingWindow floatingWindow2 = this.a(A_0);
							rect = new global::System.Windows.Rect(floatingWindow2.Left, floatingWindow2.Top, floatingWindow2.Width, floatingWindow2.Height);
							floatingWindow2.Hide();
							num = (short)1172111388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							goto IL_9BD;
						case 24:
							goto IL_ABB;
						case 25:
							if (point.X > this.g.b.Width)
							{
								num = (short)1087766554;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CFB;
						case 26:
							point.X = global::System.Math.Round(this.g.b.Width / 2.0);
							num = (short)1771569188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							obj = 0;
							goto IL_75D;
						case 28:
							goto IL_9BD;
						case 29:
							if (this.g == null)
							{
								num = (short)965017633;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C48;
						case 30:
							if (flag)
							{
								num = (short)42795026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							point2.Offset(-point.X, -point.Y);
							this.g.a = point;
							num = (short)60817446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							goto IL_646;
						case 32:
						{
							global::System.Windows.Size renderSize;
							if (renderSize.Width > 0.0)
							{
								num = (short)2087190532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9BD;
						}
						case 33:
							this.g = new global::DevComponents.WpfDock.g();
							this.g.ShowActivated = false;
							this.g.KeyDown += this.c;
							this.g.Width = 0.0;
							this.g.Height = 0.0;
							num = (short)1864040463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
							rect.Size = A_0.RenderSize;
							num = (short)1259012141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							goto IL_D82;
						case 36:
							goto IL_CFB;
						case 37:
							if (A_1)
							{
								num = (short)291831817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C01;
						case 38:
							goto IL_D36;
						case 39:
							if (A_0.IsFloating)
							{
								num = (short)1970864170;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							point = global::System.Windows.Input.Mouse.GetPosition(A_0);
							num = (short)1542914073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 40:
						{
							global::System.Windows.Rect floatingRect;
							if (floatingRect.Height > 0.0)
							{
								num = (short)287965185;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9BD;
						}
						case 41:
							num = (short)508100651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
						{
							global::DevComponents.WpfDock.FloatingWindow floatingWindow = this.a(A_0);
							point = global::System.Windows.Input.Mouse.GetPosition(floatingWindow);
							num = (short)485490698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 43:
							obj = !this.DockHintOverlay;
							goto IL_75D;
						case 44:
							if (!A_1)
							{
								num = (short)75431958;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B68;
						case 45:
							goto IL_9BD;
						case 46:
						{
							global::System.Windows.Rect floatingRect;
							if (floatingRect.Width > 0.0)
							{
								num = (short)141033485;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9BD;
						}
						case 47:
							if (this.AnimationEnabled)
							{
								num = (short)450297897;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2145583131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 48:
						{
							global::DevComponents.WpfDock.FloatingWindow floatingWindow;
							point.X = global::System.Math.Round(floatingWindow.Width / 2.0);
							num = (short)1830486022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_448;
						IL_646:
						this.g.b = rect.Size;
						this.g.Width = rect.Width;
						this.g.Height = rect.Height;
						point = default(global::System.Windows.Point);
						flag = false;
						num = (short)625999911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_75D:
						object obj2 = obj;
						if (obj2 != null)
						{
							this.j.Opacity = 0.0;
						}
						if (obj2 != null)
						{
							num = (short)1772748819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_646;
						IL_9BD:
						global::System.Windows.Documents.AdornerLayer a_ = this.k();
						this.a(a_, this, A_0);
						num = (short)1744175151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A11:
						num = (short)709361680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_ABB:
						flag = true;
						num = (short)2045050894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B68:
						num = (short)173998100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C01:
						point2 = A_0.PointToScreen(point);
						num = (short)475267102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C48:
						this.g.Show();
						num = (short)1572274193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_CFB:
						num = (short)1220411429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D36:
						this.g.Left = point2.X;
						this.g.Top = point2.Y;
						this.h = A_0;
						this.i = A_1;
						num = (short)51249187;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_8F4:
					return result;
					IL_D82:
					return true;
					IL_448:
					this.f = true;
					this.g();
					num = (short)670826525;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_37D;
				}
				finally
				{
					this.aa = false;
				}
				return result;
			}
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000BDB4 File Offset: 0x00009FB4
		private void c(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)442499073;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1170996369;
				short num3 = num;
				num = (short)722861201;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)14942208;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						this.CancelWindowDocking();
						num = (short)1647706114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 2:
						goto IL_E5;
					}
					IL_7A:
					if (A_1.Key != global::System.Windows.Input.Key.Escape)
					{
						return;
					}
					break;
				}
				num = (short)1046347776;
				short num4 = num;
				num = (short)398393344;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E5:
			num = (short)399769601;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000BED0 File Offset: 0x0000A0D0
		private global::System.Windows.UIElement a(global::DevComponents.WpfDock.eDockHintSide A_0)
		{
			short num = (short)2041769867;
			short num2 = num;
			num = (short)405598091;
			switch (num2 == num)
			{
			}
			num = (short)2098135040;
			if (num != 0)
			{
			}
			num = (short)1714356225;
			if (num != 0)
			{
			}
			num = (short)366804992;
			short num3 = num;
			return new global::DevComponents.WpfDock.DockHint(A_0);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000BF80 File Offset: 0x0000A180
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1895759872;
			switch (num)
			{
			default:
			{
				num = (short)1917321238;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)240517120;
					short num3 = num;
					global::System.Windows.Point a_;
					global::System.Windows.Point point2;
					global::DevComponents.WpfDock.DockSite.a a;
					switch (num2)
					{
					case 0:
						goto IL_290;
					case 1:
						num = (short)1528823842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)13238287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_62B;
					case 4:
						goto IL_439;
					case 5:
					{
						global::System.Windows.Point position = e.GetPosition(this);
						this.b(position);
						a_ = position;
						global::DevComponents.WpfDock.FloatingWindow floatingWindow = null;
						num = (short)707854353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (this.g.Height != this.g.b.Height)
						{
							num = (short)1599602707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_290;
					case 7:
						goto IL_5E1;
					case 8:
						goto IL_459;
					case 9:
						goto IL_439;
					case 10:
						goto IL_333;
					case 11:
					{
						global::System.Windows.Point point;
						global::DevComponents.WpfDock.j.SetWindowPos(new global::System.Windows.Interop.WindowInteropHelper(this.g).Handle, global::System.IntPtr.Zero, (int)point.X, (int)point.Y, 0, 0, 5);
						num = (short)1008926751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)154337306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_2E8;
					case 14:
						if (this.f)
						{
							num = (short)1824849932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_801;
					case 15:
						if (this.g.IsVisible)
						{
							num = (short)1653932059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_801;
					case 16:
						if (this.g.Width != this.g.b.Width)
						{
							num = (short)1718091809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73B;
					case 17:
						if (this.l is global::DevComponents.WpfDock.DockWindowGroup)
						{
							num = (short)252051457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E1;
					case 18:
						global::DevComponents.WpfDock.j.SetWindowPos(new global::System.Windows.Interop.WindowInteropHelper(this.g).Handle, global::System.IntPtr.Zero, (int)point2.X, (int)point2.Y, 0, 0, 5);
						num = (short)1339228170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						this.g.Height = this.g.b.Height;
						num = (short)11796480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::DevComponents.WpfDock.FloatingWindow floatingWindow;
						global::System.Windows.Point point = floatingWindow.PointToScreen(a.c.Location);
						num = (short)107937795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::System.Windows.Point position;
						point2 = base.PointToScreen(position);
						point2.Offset(-this.g.a.X, -this.g.a.Y);
						num = (short)82976817;
						short num4 = num;
						num = (short)1835999281;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32;
						default:
							num = (short)125108224;
							if (num != 0)
							{
							}
							num = (short)2091712536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 22:
						goto IL_32;
					case 23:
					{
						global::DevComponents.WpfDock.FloatingWindow floatingWindow;
						if (floatingWindow != null)
						{
							num = (short)48103444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62B;
					}
					case 24:
						if (this.DpiMultiplier > 1.0)
						{
							num = (short)355401746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.g.Left = point2.X;
						this.g.Top = point2.Y;
						num = (short)592314397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						if (this.DpiMultiplier > 1.0)
						{
							num = (short)582549515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Point point;
						this.g.Left = point.X;
						this.g.Top = point.Y;
						num = (short)1778122765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (!this.aa)
						{
							num = (short)2009268229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_801;
					case 27:
						num = (short)1858142222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						global::DevComponents.WpfDock.FloatingWindow floatingWindow;
						if (floatingWindow != null)
						{
							num = (short)619446304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E1;
					}
					case 29:
						goto IL_333;
					case 30:
					{
						num = (short)1482096641;
						if (num != 0)
						{
						}
						global::DevComponents.WpfDock.FloatingWindow floatingWindow = this.a(this.l);
						num = (short)465567772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_2E8;
					case 32:
					{
						global::DevComponents.WpfDock.FloatingWindow floatingWindow;
						a_ = e.GetPosition(floatingWindow);
						num = (short)129957895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						this.g.Width = this.g.b.Width;
						num = (short)934215716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (((global::DevComponents.WpfDock.DockWindowGroup)this.l).IsFloating)
						{
							num = (short)1451098142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E1;
					case 35:
					{
						if (a.a == global::DevComponents.WpfDock.h.a)
						{
							num = (short)2103312405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Point point = a.c.Location;
						point = base.PointToScreen(point);
						num = (short)1021313047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						goto IL_73B;
					}
					goto IL_100;
					IL_32:
					switch (0)
					{
					case 0:
						IL_100:
						if (this.g == null)
						{
							goto IL_801;
						}
						num = (short)242679810;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_290:
					a.c = new global::System.Windows.Rect(point2.X, point2.Y, this.g.b.Width, this.g.b.Height);
					num = (short)1403846660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E8:
					this.g.Width = a.c.Width;
					this.g.Height = a.c.Height;
					num = (short)1498611721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_333:
					num = (short)659816464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_439:
					this.m = a;
					num = (short)1605632008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E1:
					a = this.a(a_);
					num = (short)977862691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62B:
					num = (short)461897753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_73B:
					num = (short)97124358;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_459:
				IL_801:
				base.OnMouseMove(e);
				return;
			}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000C798 File Offset: 0x0000A998
		private double DpiMultiplier
		{
			get
			{
				short num = (short)1344185048;
				short num2 = num;
				num = (short)960733912;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_90;
				default:
					num = (short)1736572928;
					if (num != 0)
					{
					}
					num = (short)1863581697;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_90;
					}
					break;
				}
				int num3;
				global::System.Windows.Point point;
				double num4;
				for (;;)
				{
					IL_7E:
					switch (num3)
					{
					case 0:
						goto IL_115;
					case 1:
						if (point.Y != 96.0)
						{
							num = (short)1987641346;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num4;
					case 2:
						num4 += (point.Y - 96.0) / 96.0;
						num = (short)1560346624;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_90;
				}
				IL_115:
				num = (short)541196288;
				short num5 = num;
				return num4;
				IL_90:
				num4 = 1.0;
				point = global::DevComponents.WpfDock.i.b(this);
				num = (short)1978859521;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7E;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		private void b(global::System.Windows.Point A_0)
		{
			short num = (short)62455808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_136;
				}
				global::System.Windows.UIElement uielement;
				global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
				for (;;)
				{
					IL_27:
					global::System.Windows.UIElement uielement2;
					global::DevComponents.WpfDock.FloatingWindow floatingWindow;
					global::System.Windows.Point location;
					global::System.Windows.Rect a_;
					switch (num2)
					{
					case 0:
						goto IL_888;
					case 1:
						if (this.i)
						{
							num = (short)12910601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_568;
					case 2:
						goto IL_B80;
					case 3:
						num = (short)1371406342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						this.j.m().Visibility = global::System.Windows.Visibility.Collapsed;
						num = (short)1863352255;
						short num3 = num;
						num = (short)1532067775;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_888;
						default:
							num = (short)1386938368;
							if (num != 0)
							{
							}
							num = (short)619380759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_3F4;
					case 6:
						if (uielement == this.h)
						{
							num = (short)540803098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_70D;
					case 7:
						if (uielement == this.h)
						{
							num = (short)1006829586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B0;
					case 8:
						goto IL_7C1;
					case 9:
						num = (short)1683816508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_735;
					case 11:
					{
						global::System.Windows.Documents.AdornerLayer adornerLayer = this.k();
						num = (short)211222587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (uielement is global::DevComponents.WpfDock.DockWindowGroup)
						{
							num = (short)686424125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_426;
					case 13:
						goto IL_378;
					case 14:
					{
						uielement = this.a(A_0, global::DevComponents.WpfDock.DockSite.GetIsDocument(dockWindowGroup) || this.e(dockWindowGroup), false, this.e(dockWindowGroup));
						bool flag = false;
						num = (short)767229999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						this.j.j().Visibility = global::System.Windows.Visibility.Collapsed;
						num = (short)1498677261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_888;
					case 17:
						if (this.j.n() != uielement2)
						{
							num = (short)658178110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE3;
					case 18:
						num = (short)1814167553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						bool flag = this.GetIsDocumentElement(uielement);
						num = (short)502595592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)20185095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (uielement != null)
						{
							num = (short)1465843732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_568;
					case 22:
						goto IL_421;
					case 23:
						goto IL_601;
					case 24:
						location = floatingWindow.PointFromScreen(uielement.PointToScreen(new global::System.Windows.Point(0.0, 0.0)));
						num = (short)1156710429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (this.j.k() != null)
						{
							num = (short)1309278266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_77D;
					case 26:
						num = (short)1514864688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)1312161843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (uielement is global::DevComponents.WpfDock.DockWindowGroup)
						{
							num = (short)1900806147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23D;
					case 29:
						goto IL_2AA;
					case 30:
						num = (short)464257076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						bool flag;
						if (flag)
						{
							num = (short)1440153643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_652;
					}
					case 32:
						this.j.n(this.a(global::DevComponents.WpfDock.eDockHintSide.AllSidesAndCenter));
						num = (short)1159725091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (this.j.j() != null)
						{
							num = (short)998768655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_378;
					case 34:
					{
						bool flag;
						if (flag)
						{
							num = (short)2026111025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_568;
					}
					case 35:
						goto IL_3F4;
					case 36:
						goto IL_8C0;
					case 37:
						if (this.j.Parent != this.k())
						{
							num = (short)722141184;
							short num4 = num;
							num = (short)1849098290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_888;
					case 38:
						if (dockWindowGroup.CanDockAsDocument)
						{
							num = (short)318570497;
							if (num != 0)
							{
							}
							num = (short)1453064234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_568;
					case 39:
						goto IL_1B0;
					case 40:
						goto IL_70D;
					case 41:
						if (this.x != null)
						{
							num = (short)3014702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B80;
					case 42:
						goto IL_652;
					case 43:
						num = (short)1505099810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (((global::DevComponents.WpfDock.DockWindowGroup)uielement).IsFloating)
						{
							num = (short)889061406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_426;
					case 45:
						this.j.l().Visibility = global::System.Windows.Visibility.Collapsed;
						num = (short)649396234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						location = this.x.PointFromScreen(uielement.PointToScreen(new global::System.Windows.Point(0.0, 0.0)));
						num = (short)1795358722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (uielement != null)
						{
							num = (short)438501395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C1;
					case 48:
						if (!this.i)
						{
							num = (short)315424808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23D;
					case 49:
						num = (short)317980710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						this.a(this.k(), this, dockWindowGroup);
						num = (short)265486336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						if (dockWindowGroup.CanDockAsDocument)
						{
							num = (short)808321056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.j.n(this.a(global::DevComponents.WpfDock.eDockHintSide.AllSides));
						num = (short)835059717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (uielement != this.h)
						{
							num = (short)374931467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_426;
					case 53:
						if (this.j.l() != null)
						{
							num = (short)773783597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_735;
					case 54:
						goto IL_3EF;
					case 55:
						goto IL_8C0;
					case 56:
						if (this.j.m() != null)
						{
							num = (short)456065028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_601;
					case 57:
						if (a_.Width > 0.0)
						{
							num = (short)135200795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE3;
					case 58:
						this.j.k().Visibility = global::System.Windows.Visibility.Collapsed;
						num = (short)1377828928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
					{
						global::System.Windows.Documents.AdornerLayer adornerLayer;
						if (this.j.Parent != adornerLayer)
						{
							num = (short)958595135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_601;
					}
					case 60:
						if (this.h.Items.Count > 1)
						{
							num = (short)695271463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_568;
					case 61:
						num = (short)2145714220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						this.j.n(uielement2);
						this.j.UpdateLayout();
						num = (short)1419640886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
					{
						global::System.Windows.Documents.AdornerLayer adornerLayer;
						this.a(adornerLayer, uielement, dockWindowGroup);
						num = (short)1353842721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						goto IL_77D;
					case 65:
						if (floatingWindow != null)
						{
							num = (short)909508632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AA;
					}
					goto IL_136;
					IL_1B0:
					num = (short)1616838687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23D:
					uielement2 = this.a(global::DevComponents.WpfDock.eDockHintSide.AllSides);
					num = (short)579731511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AA:
					num = (short)2088108073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_378:
					num = (short)673447961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F4:
					global::DevComponents.WpfDock.Primitives.d d = this.j;
					a_ = default(global::System.Windows.Rect);
					d.j(a_);
					num = (short)1501364246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_426:
					num = (short)2112094245;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_568:
					a_ = this.j.o();
					num = (short)1093271609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_601:
					floatingWindow = this.a(uielement);
					num = (short)229703696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_652:
					location = base.PointFromScreen(uielement.PointToScreen(new global::System.Windows.Point(0.0, 0.0)));
					num = (short)1730150465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_70D:
					uielement2 = this.a(global::DevComponents.WpfDock.eDockHintSide.AllSidesAndCenter);
					num = (short)1101070372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_735:
					num = (short)134676536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_77D:
					num = (short)2146959413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7C1:
					floatingWindow = null;
					num = (short)1691615244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_888:
					num = (short)715194389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C0:
					num = (short)1713831953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B80:
					global::System.Windows.Rect a_2 = new global::System.Windows.Rect(location, uielement.RenderSize);
					this.j.j(a_2);
					uielement2 = null;
					num = (short)893779996;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3EF:
				IL_421:
				IL_BE3:
				this.l = uielement;
				return;
				IL_136:
				dockWindowGroup = this.h;
				num = (short)591331342;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000D4E0 File Offset: 0x0000B6E0
		private bool e(global::DevComponents.WpfDock.DockWindowGroup A_0)
		{
			short num = (short)2133590021;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1362558977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1450115072;
					short num3 = num;
					if (A_0.CanDockLeft)
					{
						return false;
					}
					num = (short)978583553;
					if (num != 0)
					{
					}
					num = (short)2068337325;
					short num4 = num;
					num = (short)218518189;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)1269432320;
						if (num != 0)
						{
						}
						num = (short)570228738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)1518665731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!A_0.CanDockRight)
					{
						num = (short)1581383687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					if (!A_0.CanDockTop)
					{
						num = (short)446758918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					goto IL_15;
				case 6:
					goto IL_9D;
				case 7:
					num = (short)476250116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_45;
				IL_15:
				switch (0)
				{
				case 0:
					IL_45:
					if (!A_0.CanDockAsDocument)
					{
						return false;
					}
					num = (short)1037434880;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_9D:
			return !A_0.CanDockBottom;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		internal global::DevComponents.WpfDock.FloatingWindow a(global::System.Windows.UIElement A_0)
		{
			short num = (short)1168834564;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (A_0 == null)
					{
						num = (short)1883832326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)942407680;
					short num3 = num;
					num = (short)1911160834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_169;
				case 2:
				{
					num = (short)1109058379;
					short num4 = num;
					num = (short)789701451;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)592248832;
						if (num != 0)
						{
						}
						if (A_0 is global::DevComponents.WpfDock.FloatingWindow)
						{
							num = (short)1085603841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_0 = (global::System.Windows.LogicalTreeHelper.GetParent(A_0) as global::System.Windows.UIElement);
						num = (short)1106444293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_58;
				case 4:
					goto IL_15;
				case 5:
					goto IL_86;
				case 6:
					goto IL_B4;
				}
				goto IL_41;
				IL_15:
				switch (0)
				{
				case 0:
					IL_41:
					if (A_0 != null)
					{
						goto IL_86;
					}
					num = (short)841678851;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_86:
				num = (short)1523580928;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_58:
			return null;
			IL_B4:
			num = (short)717815809;
			if (num != 0)
			{
			}
			return null;
			IL_169:
			return A_0 as global::DevComponents.WpfDock.FloatingWindow;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000D854 File Offset: 0x0000BA54
		public bool GetIsDocumentElement(global::System.Windows.UIElement elem)
		{
			short num = (short)1820786696;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.UIElement uielement;
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					if (global::DevComponents.WpfDock.DockSite.GetIsDocument(uielement))
					{
						num = (short)344653831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 2:
					num = (short)1609367556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)857997313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (uielement is global::DevComponents.WpfDock.DockSite)
					{
						num = (short)766771200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E4;
				case 5:
					return true;
				case 6:
					if (uielement != null)
					{
						num = (short)639303683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 7:
					return true;
				case 8:
				{
					num = (short)1655701504;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_78;
					}
					continue;
				}
				case 9:
					goto IL_1E4;
				case 10:
					num = (short)419495937;
					if (num != 0)
					{
					}
					if (uielement != null)
					{
						num = (short)736100354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_78:
				num = (short)1586303290;
				short num4 = num;
				num = (short)1342181690;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)414056448;
					if (num != 0)
					{
					}
					if (!global::DevComponents.WpfDock.DockSite.GetIsDocument(elem))
					{
						uielement = elem;
						num = (short)2103705609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				num = (short)1591279621;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_183:
				num = (short)1761280010;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E4:
				uielement = (global::System.Windows.LogicalTreeHelper.GetParent(uielement) as global::System.Windows.UIElement);
				num = (short)999096326;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000DA8C File Offset: 0x0000BC8C
		private global::System.Windows.UIElement a(global::System.Windows.Point A_0, bool A_1, bool A_2, bool A_3)
		{
			short num = (short)1211039744;
			switch (num)
			{
			default:
			{
				num = (short)1497694217;
				int num2 = (int)((global::System.IntPtr)num);
				global::DevComponents.WpfDock.SplitPanel splitPanel3;
				for (;;)
				{
					global::System.Windows.Rect layoutSlot2;
					switch (num2)
					{
					case 0:
						goto IL_593;
					case 1:
						goto IL_2FB;
					case 2:
						goto IL_5E8;
					case 3:
						try
						{
							num = (short)671940609;
							num2 = (int)((global::System.IntPtr)num);
							global::System.Windows.UIElement result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_24C;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_179;
									}
									continue;
								case 2:
								{
									global::System.Windows.Rect layoutSlot;
									if (layoutSlot.Contains(A_0))
									{
										num = (short)1664811012;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfDock.SplitPanel> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1072300037;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.SplitPanel splitPanel = enumerator.Current;
									global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(splitPanel);
									num = (short)333905922;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::DevComponents.WpfDock.SplitPanel splitPanel;
									global::System.Windows.Point point = splitPanel.PointFromScreen(base.PointToScreen(A_0));
									result = splitPanel.GetDockedElementAt(point);
									num = (short)1079377926;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1722548224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_1F1;
								}
								IL_1F6:
								num = (short)1585053699;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_179:
								goto IL_1F6;
							}
							IL_1F1:
							return result;
							IL_24C:
							goto IL_5ED;
						}
						finally
						{
							num = (short)1988362240;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfDock.SplitPanel> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_284;
									}
									continue;
								case 1:
									goto IL_2BA;
								case 2:
									enumerator.Dispose();
									num = (short)299630593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_284:
								if (enumerator == null)
								{
									break;
								}
								num = (short)218824706;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2BA:;
						}
						goto IL_2BD;
					case 4:
					{
						global::System.Windows.Point point2 = base.PointToScreen(A_0);
						global::System.Collections.Generic.List<global::DevComponents.WpfDock.FloatingWindow>.Enumerator enumerator2 = this.t.GetEnumerator();
						num = (short)763559942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)2079981569;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfDock.SplitPanel> enumerator = this.SplitPanels.GetEnumerator();
						num = (short)2014248963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						try
						{
							num = (short)94699523;
							num2 = (int)((global::System.IntPtr)num);
							global::System.Windows.UIElement result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_580;
								case 1:
								{
									global::System.Windows.Point point2;
									global::System.Windows.Rect rect;
									if (rect.Contains(point2))
									{
										num = (short)1329987589;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1751842816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3BC;
									}
									continue;
								case 4:
								{
									global::DevComponents.WpfDock.FloatingWindow floatingWindow;
									if (floatingWindow.Content is global::DevComponents.WpfDock.DockWindowGroup)
									{
										num = (short)1804926982;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)674103306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1234894852;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::DevComponents.WpfDock.FloatingWindow floatingWindow;
									result = (floatingWindow.Content as global::DevComponents.WpfDock.DockWindowGroup);
									num = (short)768868363;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::System.Collections.Generic.List<global::DevComponents.WpfDock.FloatingWindow>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1491468290;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.FloatingWindow floatingWindow = enumerator2.Current;
									global::System.Windows.Rect rect = new global::System.Windows.Rect(floatingWindow.Left, floatingWindow.Top, floatingWindow.Width, floatingWindow.Height);
									num = (short)635633665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::DevComponents.WpfDock.FloatingWindow floatingWindow;
									global::DevComponents.WpfDock.SplitPanel splitPanel2 = floatingWindow.Content as global::DevComponents.WpfDock.SplitPanel;
									global::System.Windows.Point point2;
									global::System.Windows.Point point3 = splitPanel2.PointFromScreen(point2);
									result = splitPanel2.GetDockedElementAt(point3);
									num = (short)1542848521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_47D;
								case 10:
								{
									global::DevComponents.WpfDock.FloatingWindow floatingWindow;
									if (floatingWindow.Content is global::DevComponents.WpfDock.SplitPanel)
									{
										num = (short)959512584;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
									goto IL_4A8;
								}
								IL_401:
								num = (short)717029383;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3BC:
								goto IL_401;
							}
							IL_47D:
							IL_4A8:
							return result;
							IL_580:
							goto IL_2F9;
						}
						finally
						{
							global::System.Collections.Generic.List<global::DevComponents.WpfDock.FloatingWindow>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_593;
					case 7:
					{
						num = (short)1445313010;
						short num3 = num;
						num = (short)1078901234;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2FB;
						default:
							num = (short)714997760;
							if (num != 0)
							{
							}
							if (A_1)
							{
								num = (short)732889089;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2BD;
						}
						break;
					}
					case 8:
						if (A_2)
						{
							num = (short)1937768452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F9;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_74;
						}
						continue;
					case 10:
						if (base.Content is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1667039232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BD;
					case 11:
						if (layoutSlot2.Contains(A_0))
						{
							num = (short)1466892290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BD;
					}
					IL_74:
					if (!A_3)
					{
						num = (short)2109734912;
						short num4 = num;
						num = (short)1721696261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5ED;
					IL_2BD:
					num = (short)832962568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FB:
					num = (short)1860042762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_593:
					splitPanel3 = (base.Content as global::DevComponents.WpfDock.SplitPanel);
					layoutSlot2 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(splitPanel3);
					num = (short)1321861131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5ED:
					num = (short)2037841927;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2F9:
				return null;
				IL_5E8:
				global::System.Windows.Point point4 = splitPanel3.PointFromScreen(base.PointToScreen(A_0));
				return splitPanel3.GetDockedElementAt(point4);
			}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000E144 File Offset: 0x0000C344
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)261881857;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					IL_59:
					num = (short)2107441154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Released)
					{
						num = (short)817299460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DA;
				case 3:
				{
					num = (short)1585184768;
					short num3 = num;
					goto IL_DA;
				}
				case 4:
					base.ReleaseMouseCapture();
					num = (short)265289731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_39:
				if (this.f)
				{
					num = (short)40697856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_DA:
				num = (short)2015690510;
				short num4 = num;
				num = (short)1742601998;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_59;
				default:
					goto IL_112;
				}
			}
			IL_112:
			num = (short)564920320;
			if (num != 0)
			{
			}
			num = (short)1098645505;
			if (num != 0)
			{
			}
			base.OnMouseUp(e);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000E2AC File Offset: 0x0000C4AC
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)1960247311;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfDock.DockWindow activeDockWindow;
				global::DevComponents.WpfDock.DockWindowGroup parentGroup;
				switch (num2)
				{
				case 0:
					if (e.Key == global::System.Windows.Input.Key.Tab)
					{
						num = (short)415957017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_450;
				case 1:
					goto IL_2F7;
				case 2:
					num = (short)615841792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (activeDockWindow.ParentGroup != null)
					{
						num = (short)609878040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_332;
				case 4:
				{
					num = (short)5399116;
					short num3 = num;
					num = (short)2132435532;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E8;
					default:
						num = (short)808583168;
						if (num != 0)
						{
						}
						num = (short)725417993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					goto IL_51C;
				case 6:
					goto IL_376;
				case 7:
					num = (short)1644691466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (parentGroup.SelectedDockWindow != null)
					{
						num = (short)2136670239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_332;
				case 9:
					if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
					{
						num = (short)784269333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51C;
				case 10:
					if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
					{
						num = (short)1683619860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_450;
				case 11:
					if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
					{
						num = (short)1529282565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_586;
				case 12:
					num = (short)969474049;
					if (num != 0)
					{
					}
					num = (short)1779171331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_2F7;
				case 14:
					goto IL_3E6;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_AA;
					}
					continue;
				case 16:
					goto IL_2E8;
				case 17:
					if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftShift))
					{
						num = (short)887881754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EB;
				case 18:
					if (e.Key == global::System.Windows.Input.Key.F6)
					{
						num = (short)2029715460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_586;
				case 19:
					goto IL_332;
				case 20:
					goto IL_2D1;
				case 21:
					num = (short)934150155;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (activeDockWindow != null)
					{
						num = (short)86966284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_332;
				case 23:
					goto IL_3EB;
				case 24:
					parentGroup = activeDockWindow.ParentGroup;
					num = (short)694878225;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					num = (short)1638727710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					num = (short)1447362587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightShift))
					{
						num = (short)319422487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					parentGroup.h(true);
					num = (short)1949368321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_351;
				case 29:
					this.CancelWindowDocking();
					num = (short)1486880774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
					{
						num = (short)1122304007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D1;
				case 31:
					parentGroup.SelectedDockWindow.FocusContent();
					num = (short)788135955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					if (this.KeyboardNavigationEnabled)
					{
						num = (short)1735917570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_450;
				}
				IL_AA:
				if (e.Key == global::System.Windows.Input.Key.Escape)
				{
					num = (short)1203568640;
					short num4 = num;
					num = (short)1940586525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1216086048;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D1:
				num = (short)979632144;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E8:
				this.c(global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftShift) || global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightShift));
				e.Handled = true;
				num = (short)506724366;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F7:
				num = (short)118685704;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_332:
				e.Handled = true;
				num = (short)333840412;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3EB:
				parentGroup.g(true);
				num = (short)1274281997;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_450:
				num = (short)722731026;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_51C:
				activeDockWindow = this.ActiveDockWindow;
				num = (short)1737424918;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_351:
			IL_376:
			IL_3E6:
			IL_586:
			base.OnKeyDown(e);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000E848 File Offset: 0x0000CA48
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)260374529;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1139558321;
					short num3 = num;
					num = (short)1412253617;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A2;
					default:
						goto IL_F9;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 2:
					goto IL_A7;
				case 3:
					goto IL_A2;
				case 4:
					if (e.Key == global::System.Windows.Input.Key.Escape)
					{
						num = (short)896598019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C5;
				case 5:
					if (e.Key == global::System.Windows.Input.Key.RightCtrl)
					{
						num = (short)1122304001;
						if (num != 0)
						{
						}
						num = (short)1170276354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1036976132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1C3;
				case 7:
					num = (short)1086783493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_44:
				if (e.Key != global::System.Windows.Input.Key.LeftCtrl)
				{
					num = (short)1231159303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_A7;
				IL_A2:
				this.ReleaseDockSelectorAdorner(false);
				num = (short)1781334016;
				short num4 = num;
				num = (short)1775501318;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A7:
				this.ReleaseDockSelectorAdorner(true);
				num = (short)525926400;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F9:
			num = (short)1863843840;
			if (num != 0)
			{
			}
			IL_1C3:
			IL_1C5:
			base.OnKeyUp(e);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000EA24 File Offset: 0x0000CC24
		public void ReleaseDockSelectorAdorner(bool applySelection)
		{
			short num = (short)2142371845;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfDock.DockWindow dockWindow;
				global::DevComponents.WpfDock.DockWindowSelector dockWindowSelector;
				switch (num2)
				{
				case 0:
					if (dockWindow != null)
					{
						num = (short)1073020946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_158;
				case 1:
					dockWindow = dockWindowSelector.SelectedToolWindow.DockWindow;
					num = (short)816775181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					dockWindow = ((global::DevComponents.WpfDock.DockWindowInfo)dockWindowSelector.SelectedItem).DockWindow;
					num = (short)1704919052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.y.Close();
					this.y = null;
					goto IL_2D4;
				case 4:
				{
					num = (short)2063252813;
					short num3 = num;
					num = (short)1121631565;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2D4;
					case 1:
						break;
					default:
					{
						num = (short)1403518976;
						short num4 = num;
						break;
					}
					}
					num = (short)715718656;
					if (num != 0)
					{
					}
					if (applySelection)
					{
						num = (short)1557790727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_158;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				case 6:
					goto IL_32E;
				case 7:
					dockWindow = null;
					num = (short)168558609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_158;
				case 9:
					if (dockWindow.IsAutoHide)
					{
						num = (short)282460171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32E;
				case 10:
					return;
				case 11:
					dockWindow.AutoHideOpen = true;
					num = (short)449642502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_B8;
				case 13:
					goto IL_B8;
				case 14:
					return;
				case 15:
					if (this.y != null)
					{
						num = (short)1182597123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 16:
					if (dockWindowSelector.SelectedToolWindow != null)
					{
						num = (short)179240961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8;
				case 17:
					if (dockWindowSelector.SelectedItem != null)
					{
						num = (short)1936523265;
						if (num != 0)
						{
						}
						num = (short)1478623234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2143551504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					num = (short)213581833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_70:
				if (this.v == null)
				{
					num = (short)466812938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				dockWindowSelector = this.v.c();
				dockWindowSelector.LostMouseCapture -= this.a;
				num = (short)529006596;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B8:
				num = (short)478281728;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_158:
				this.i().Remove(this.v);
				this.v.ReleaseMouseCapture();
				this.v = null;
				num = (short)1793196047;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D4:
				num = (short)1665794062;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_32E:
				dockWindow.IsSelected = true;
				dockWindow.FocusContent();
				num = (short)234487816;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		private void c(bool A_0)
		{
			short num = (short)1075838979;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0)
					{
						num = (short)1004011522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14C;
				case 1:
					goto IL_54;
				case 2:
					goto IL_10A;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (this.v == null)
				{
					num = (short)581632001;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)31522816;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_54:
			num = (short)795690893;
			short num3 = num;
			num = (short)1312966541;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_10A:
				num = (short)1704198144;
				short num4 = num;
				this.v.c().c();
				return;
			}
			default:
				num = (short)680132609;
				if (num != 0)
				{
				}
				num = (short)2089287680;
				if (num != 0)
				{
				}
				this.h();
				this.v.c().d();
				return;
			}
			IL_14C:
			this.v.c().d();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000EF4C File Offset: 0x0000D14C
		private global::System.Windows.Documents.AdornerLayer i()
		{
			short num = (short)859504641;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_5E;
			}
			int num2;
			global::System.Windows.Documents.AdornerLayer result;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					goto IL_29F;
				case 1:
					if (this.DockSelectorOverlay)
					{
						num = (short)1041891328;
						short num3 = num;
						num = (short)1121583108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
					num = (short)351076354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return result;
				case 3:
					this.y.Show();
					num = (short)1957822472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)875718766;
					short num4 = num;
					num = (short)1722181742;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_29F;
					default:
						num = (short)530448384;
						if (num != 0)
						{
						}
						num = (short)1944059909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (this.y == null)
					{
						num = (short)795344903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F1;
				case 6:
					if (!this.y.IsVisible)
					{
						num = (short)1845821443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C7;
				case 7:
					this.y = new global::DevComponents.WpfDock.f
					{
						Owner = global::System.Windows.Window.GetWindow(this)
					};
					this.y.PreviewKeyDown += this.b;
					this.y.KeyUp += this.a;
					num = (short)1655373824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_C7;
				case 9:
					return result;
				}
				goto IL_5E;
				IL_C7:
				result = this.y.a();
				num = (short)354746377;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F1:
				global::System.Windows.Point point = base.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
				this.y.Left = point.X;
				this.y.Top = point.Y;
				this.y.Width = base.ActualWidth;
				this.y.Height = base.ActualHeight;
				num = (short)957153286;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_29F:
				goto IL_F1;
			}
			return result;
			IL_5E:
			result = null;
			num = (short)1182203905;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000F228 File Offset: 0x0000D428
		private void h()
		{
			short num = (short)1198915584;
			switch (num)
			{
			default:
			{
				num = (short)316145665;
				int num2 = (int)((global::System.IntPtr)num);
				global::DevComponents.WpfDock.Primitives.c c;
				global::System.Windows.Documents.AdornerLayer adornerLayer;
				for (;;)
				{
					global::System.Windows.UIElement a_;
					global::DevComponents.WpfDock.DockWindow activeDockWindow;
					global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						a_ = this.y.b();
						goto IL_441;
					case 1:
						num = (short)1540096001;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 2:
						goto IL_AE;
					case 3:
						num = (short)1825701888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.y != null)
						{
							num = (short)364380163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CC;
					case 5:
					{
						num = (short)1997864960;
						short num3 = num;
						a_ = this;
						goto IL_441;
					}
					case 6:
						try
						{
							num = (short)1786642437;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									if (dockWindow == activeDockWindow)
									{
										num = (short)800653319;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)440401933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::DevComponents.WpfDock.DockWindowInfo dockWindowInfo;
									c.c().SelectedToolWindow = dockWindowInfo;
									num = (short)148111368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									global::DevComponents.WpfDock.DockWindowInfo dockWindowInfo2 = global::DevComponents.WpfDock.DockWindowInfo.FromDockWindow(dockWindow);
									c.c().Items.Add(dockWindowInfo2);
									num = (short)48365568;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)512032780;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_181;
									}
									continue;
								case 7:
								{
									global::DevComponents.WpfDock.DockWindowInfo dockWindowInfo2;
									c.c().SelectedItem = dockWindowInfo2;
									goto IL_269;
								}
								case 8:
								{
									num = (short)1389223803;
									short num4 = num;
									num = (short)92266363;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_269;
									default:
										num = (short)1951924224;
										if (num != 0)
										{
										}
										break;
									}
									break;
								}
								case 9:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									if (dockWindow.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)1836449793;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)366149636;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.DockWindow dockWindow = enumerator.Current;
									num = (short)65667081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									if (dockWindow == activeDockWindow)
									{
										num = (short)1448148994;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									goto IL_3B9;
								case 13:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									if (global::DevComponents.WpfDock.DockSite.GetIsDocument(dockWindow))
									{
										num = (short)442302467;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.DockWindowInfo dockWindowInfo = global::DevComponents.WpfDock.DockWindowInfo.FromDockWindow(dockWindow);
									c.c().ToolWindows.Add(dockWindowInfo);
									num = (short)195887115;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_21A:
								num = (short)1391525898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_181:
								goto IL_21A;
								IL_269:
								num = (short)866582534;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3B9:
							goto IL_4B5;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_3CC;
					case 7:
						this.a(this.v);
						this.v = null;
						num = (short)900333570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8C:
					if (this.v != null)
					{
						num = (short)139460615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AE:
					activeDockWindow = this.ActiveDockWindow;
					adornerLayer = this.i();
					num = (short)922353668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CC:
					num = (short)1684209669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_441:
					c = new global::DevComponents.WpfDock.Primitives.c(a_);
					c.c().ActiveFilesLabel = this.SystemText.DockSelectorActiveFilesText;
					c.c().ActiveToolWindowsLabel = this.SystemText.DockSelectorActiveToolWindowsText;
					c.c().CycleAllWindows = this.SelectorCycleAllWindows;
					c.b(this);
					enumerator = this.GetDockWindows().GetEnumerator();
					num = (short)1374486534;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4B5:
				adornerLayer.Add(c);
				this.v = c;
				c.c().LostMouseCapture += this.a;
				global::System.Windows.Input.Mouse.Capture(c.c(), global::System.Windows.Input.CaptureMode.SubTree);
				c.UpdateLayout();
				return;
			}
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000F740 File Offset: 0x0000D940
		private void a(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num = (short)1195667753;
			short num2 = num;
			num = (short)1319072041;
			switch (num2 == num)
			{
			}
			num = (short)723124224;
			short num3 = num;
			num = (short)696582145;
			if (num != 0)
			{
			}
			num = (short)1797259264;
			if (num != 0)
			{
			}
			this.ReleaseDockSelectorAdorner(false);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000F7F0 File Offset: 0x0000D9F0
		public void CancelWindowDocking()
		{
			short num = (short)159842305;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C5;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
				{
					IL_74:
					num = (short)1942028288;
					short num3 = num;
					this.b(true);
					base.ReleaseMouseCapture();
					num = (short)1099235328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_31:
				num = (short)482607105;
				if (num != 0)
				{
				}
				if (this.f)
				{
					num = (short)438042626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C5:
				num = (short)213022939;
				short num4 = num;
				num = (short)1596160219;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_74;
				default:
					goto IL_FA;
				}
			}
			IL_FA:
			num = (short)1626472448;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000F910 File Offset: 0x0000DB10
		[global::System.ComponentModel.Browsable(false)]
		public bool IsDockingInProgress
		{
			get
			{
				short num = (short)456392705;
				if (num != 0)
				{
				}
				num = (short)1337378830;
				short num2 = num;
				num = (short)1182320654;
				switch (num2 == num)
				{
				}
				num = (short)1664090112;
				if (num != 0)
				{
				}
				num = (short)814022656;
				short num3 = num;
				return this.f;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000F9C4 File Offset: 0x0000DBC4
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)921305089;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					IL_4D:
					this.b(false);
					num = (short)1429733376;
					short num3 = num;
					num = (short)92536834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_97;
				}
				IL_30:
				if (this.f)
				{
					num = (short)1457061888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_97:
				num = (short)322828779;
				short num4 = num;
				num = (short)816183787;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4D;
				default:
					goto IL_CC;
				}
			}
			IL_CC:
			num = (short)961216512;
			if (num != 0)
			{
			}
			num = (short)740229121;
			if (num != 0)
			{
			}
			base.OnLostMouseCapture(e);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000FAE4 File Offset: 0x0000DCE4
		private void d(global::DevComponents.WpfDock.DockWindowGroup A_0)
		{
			short num = (short)1426175394;
			short num2 = num;
			num = (short)944551330;
			switch (num2 == num)
			{
			}
			num = (short)1748369409;
			if (num != 0)
			{
			}
			num = (short)1485504512;
			if (num != 0)
			{
			}
			num = (short)837615616;
			short num3 = num;
			this.a(A_0, A_0, false);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000FB98 File Offset: 0x0000DD98
		private void a(global::DevComponents.WpfDock.DockWindowGroup A_0, global::DevComponents.WpfDock.DockWindowGroup A_1, bool A_2)
		{
			short num = (short)1406337024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B6;
				}
				global::DevComponents.WpfDock.SplitPanel splitPanel2;
				for (;;)
				{
					IL_27:
					global::DevComponents.WpfDock.SplitPanel splitPanel;
					switch (num2)
					{
					case 0:
						goto IL_509;
					case 1:
						goto IL_509;
					case 2:
						if (splitPanel != null)
						{
							num = (short)1399324691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_2D5;
					case 4:
						goto IL_5B1;
					case 5:
					{
						A_1.LastDockReference = ((splitPanel2.Orientation == global::System.Windows.Controls.Orientation.Horizontal) ? global::DevComponents.WpfDock.eDockSide.Right : global::DevComponents.WpfDock.eDockSide.Bottom);
						string a_;
						A_1.LastDockReferenceId = a_;
						num = (short)299565056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)676462617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (global::DevComponents.WpfDock.DockSite.GetIsDocument(A_0))
						{
							num = (short)1970536470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_1.LastDockSide = global::DevComponents.WpfDock.DockSite.b(global::DevComponents.WpfDock.DockSite.GetDock(splitPanel2));
						num = (short)1327890462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1213202459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (splitPanel2 != null)
						{
							num = (short)2069364768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_1.LastDockSide = A_0.LastDockSide;
						num = (short)507838492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						string a_;
						if (a_ != "")
						{
							num = (short)996737038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int a_2;
						a_ = this.a(a_2, splitPanel2);
						num = (short)1968832528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (splitPanel2 != null)
						{
							num = (short)106954758;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
					{
						string a_;
						A_1.LastDockReferenceId = a_;
						num = (short)93519905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_19A;
					case 14:
						num = (short)2031616005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1799487509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						string a_;
						if (!(a_ != ""))
						{
							goto IL_509;
						}
						num = (short)500027388;
						short num3 = num;
						num = (short)1720569852;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_544;
						default:
							num = (short)935002112;
							if (num != 0)
							{
							}
							num = (short)724303884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
					{
						num = (short)238223360;
						short num4 = num;
						A_1.LastDockReferenceId = A_0.Id;
						num = (short)302710793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (splitPanel.Parent != null)
						{
							num = (short)1513357327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_631;
					case 19:
						goto IL_544;
					case 20:
						return;
					case 21:
						if (!(splitPanel.Parent is global::DevComponents.WpfDock.SplitPanel))
						{
							num = (short)432734234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2114781185;
						if (num != 0)
						{
						}
						splitPanel = (splitPanel.Parent as global::DevComponents.WpfDock.SplitPanel);
						num = (short)943325188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_30F;
					case 23:
						goto IL_292;
					case 24:
						if (A_2)
						{
							num = (short)1653997585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)43778059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (splitPanel2.Parent is global::DevComponents.WpfDock.DockSite)
						{
							num = (short)1389101064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_292;
					case 26:
						goto IL_631;
					case 27:
						if (splitPanel2.Children.Count != 1)
						{
							num = (short)941752343;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D5;
					case 28:
						goto IL_1C0;
					case 29:
					{
						if (splitPanel2.Children.Count == 1)
						{
							num = (short)2136342531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int a_2 = splitPanel2.Children.IndexOf(A_0);
						string a_ = this.b(a_2, splitPanel2);
						num = (short)1478688778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						goto IL_342;
					case 31:
						goto IL_5B1;
					case 32:
						A_1.LastDockSide = global::DevComponents.WpfDock.DockSite.b(global::DevComponents.WpfDock.DockSite.GetDock(splitPanel2));
						num = (short)308805645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						A_1.LastDockReference = ((splitPanel2.Orientation == global::System.Windows.Controls.Orientation.Horizontal) ? global::DevComponents.WpfDock.eDockSide.Left : global::DevComponents.WpfDock.eDockSide.Top);
						num = (short)1003225089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B6;
					IL_292:
					num = (short)1094582301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D5:
					num = (short)1942290439;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_509:
					splitPanel = splitPanel2;
					num = (short)1036320770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_544:
					num = (short)2126643231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B1:
					num = (short)1803878418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_631:
					A_1.LastDockSide = global::DevComponents.WpfDock.DockSite.b(global::DevComponents.WpfDock.DockSite.GetDock(splitPanel));
					num = (short)987693076;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19A:
				IL_1C0:
				A_1.LastDockReference = global::DevComponents.WpfDock.eDockSide.Tab;
				A_1.LastIsDocument = global::DevComponents.WpfDock.DockSite.GetIsDocument(A_0);
				return;
				IL_30F:
				A_1.LastDockSide = global::DevComponents.WpfDock.eDockSide.Tab;
				return;
				IL_342:
				A_1.LastDockIsFullSizeDock = (splitPanel2.ActualWidth == base.ActualWidth || splitPanel2.ActualHeight == base.ActualHeight);
				global::DevComponents.WpfDock.DockSite.SetDockSize(A_1, global::DevComponents.WpfDock.DockSite.GetDockSize(splitPanel2));
				return;
				IL_B6:
				splitPanel2 = (A_0.Parent as global::DevComponents.WpfDock.SplitPanel);
				A_1.LastDockReferenceId = "";
				num = (short)1770979352;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00010204 File Offset: 0x0000E404
		private void d(global::DevComponents.WpfDock.DockWindow A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			global::DevComponents.WpfDock.SplitPanel splitPanel;
			short num2;
			global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (!(splitPanel.Parent is global::DevComponents.WpfDock.DockSite))
					{
						num2 = (short)1615003658;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_88;
				case 2:
					goto IL_BD;
				case 3:
					if (dockWindowGroup != null)
					{
						num2 = (short)1148321801;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					goto IL_88;
				case 5:
					goto IL_C2;
				case 6:
				{
					if (splitPanel != null)
					{
						num2 = (short)426115074;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_0.LastDock = global::System.Windows.Controls.Dock.Right;
					num2 = (short)1498939392;
					short num3 = num2;
					num2 = (short)352190464;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					if (splitPanel == null)
					{
						num2 = (short)581828612;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)196870145;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_C2;
				case 9:
					A_0.LastDockWindowGroupId = dockWindowGroup.Id;
					A_0.LastDockedSize = global::DevComponents.WpfDock.SplitPanel.GetRelativeSize(dockWindowGroup);
					splitPanel = (dockWindowGroup.Parent as global::DevComponents.WpfDock.SplitPanel);
					num2 = (short)1454112773;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					for (;;)
					{
						splitPanel = (splitPanel.Parent as global::DevComponents.WpfDock.SplitPanel);
						num2 = (short)1308885351;
						short num4 = num2;
						num2 = (short)946471271;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_215;
						}
					}
					IL_215:
					num2 = (short)831848449;
					if (num2 != 0)
					{
					}
					num2 = (short)1427111936;
					if (num2 != 0)
					{
					}
					num2 = (short)11468808;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3C;
				IL_88:
				num2 = (short)1785528326;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_C2:
				num2 = (short)187039751;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BD:
			A_0.LastDock = global::DevComponents.WpfDock.DockSite.GetDock(splitPanel);
			return;
			IL_3C:
			dockWindowGroup = (A_0.Parent as global::DevComponents.WpfDock.DockWindowGroup);
			A_0.LastDockWindowGroupId = "";
			num2 = (short)390135811;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00010480 File Offset: 0x0000E680
		private string b(int A_0, global::DevComponents.WpfDock.SplitPanel A_1)
		{
			short num;
			while (A_0 != 0)
			{
				num = (short)1350726417;
				short num2 = num;
				num = (short)1334735633;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1626669056;
					short num3 = num;
					break;
				}
				}
				num = (short)483655680;
				if (num != 0)
				{
				}
				return this.a(A_0, A_1, -1);
			}
			num = (short)900268033;
			if (num != 0)
			{
			}
			return "";
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00010540 File Offset: 0x0000E740
		private string a(int A_0, global::DevComponents.WpfDock.SplitPanel A_1)
		{
			short num;
			while (A_0 != A_1.Children.Count - 1)
			{
				num = (short)736749102;
				short num2 = num;
				num = (short)1511384622;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1147338752;
					short num3 = num;
					break;
				}
				}
				num = (short)1205141504;
				if (num != 0)
				{
				}
				return this.a(A_0, A_1, 1);
			}
			num = (short)1080033281;
			if (num != 0)
			{
			}
			return "";
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0001060C File Offset: 0x0000E80C
		private string a(int A_0, global::DevComponents.WpfDock.SplitPanel A_1, int A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			short num2;
			global::System.Windows.UIElement uielement;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_15A;
				case 1:
					goto IL_149;
				case 2:
					if (A_2 > 0)
					{
						num2 = (short)2052521993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15A;
				case 3:
				{
					int num3;
					if (A_0 == num3)
					{
						num2 = (short)1560608773;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15A;
				}
				case 4:
					num2 = (short)1856634890;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_1D8;
				case 6:
					if (uielement is global::DevComponents.WpfDock.DockWindowGroup)
					{
						num2 = (short)937099265;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A6;
				case 7:
					goto IL_24C;
				case 8:
					if (uielement.Visibility == global::System.Windows.Visibility.Visible)
					{
						num2 = (short)1776091140;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A6;
				case 9:
				{
					num2 = (short)982253569;
					if (num2 != 0)
					{
					}
					num2 = (short)208142336;
					short num4 = num2;
					int num3 = A_1.Children.Count - 1;
					num2 = (short)936837120;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (uielement is global::DevComponents.WpfDock.SplitPanel)
					{
						num2 = (short)1415708679;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_110;
				}
				goto IL_3C;
				IL_15A:
				A_0 += A_2;
				uielement = A_1.Children[A_0];
				num2 = (short)631701512;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1A6:
				num2 = (short)1374617603;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_149:
			return ((global::DevComponents.WpfDock.DockWindowGroup)uielement).Id;
			IL_1D8:
			return "";
			IL_24C:
			return ((global::DevComponents.WpfDock.SplitPanel)uielement).Id;
			IL_3C:
			num2 = (short)306568539;
			short num5 = num2;
			num2 = (short)728358235;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_110:
				num2 = (short)190709766;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)474611712;
				if (num2 != 0)
				{
				}
				int num3 = 0;
				num2 = (short)1325072386;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00010870 File Offset: 0x0000EA70
		private void b(bool A_0)
		{
			short num;
			try
			{
				num = (short)1505755136;
				switch (num)
				{
				default:
				{
					num = (short)1776484407;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::DevComponents.WpfDock.DockSite.a a;
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
						object selectedItem;
						switch (num2)
						{
						case 0:
							num = (short)1506541604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_C94;
						case 2:
							if (this.w != null)
							{
								num = (short)491520010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.DockWindow(this.h, a.d, this.a(a.a), global::DevComponents.WpfDock.eEventActionSource.Mouse, false);
							num = (short)1069023286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_4FC;
						case 4:
							a = null;
							num = (short)811991073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1564934160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							base.Focus();
							num = (short)1315110920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_272;
						case 8:
							goto IL_A4E;
						case 9:
							if (a == null)
							{
								num = (short)244252698;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4FC;
						case 10:
							this.w.DockWindow(this.h, a.d, this.a(a.a));
							num = (short)253100091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							global::DevComponents.WpfDock.eDockSide dockSide;
							global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs beforeDockedRoutedEventArgs = new global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs(global::DevComponents.WpfDock.DockSite.BeforeDockedEvent, this, this.i ? this.h.SelectedItem : this.h, global::DevComponents.WpfDock.eEventActionSource.Mouse, (a.a & global::DevComponents.WpfDock.h.a) == global::DevComponents.WpfDock.h.a, dockSide, a.d);
							this.OnBeforeDocked(beforeDockedRoutedEventArgs);
							A_0 = beforeDockedRoutedEventArgs.Cancel;
							num = (short)759496707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							goto IL_272;
						case 13:
							if (a != null)
							{
								num = (short)1911947322;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_84C;
						case 14:
							goto IL_343;
						case 15:
							this.h.SelectedDockWindow.FocusContent();
							num = (short)566624304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							if (a.d == this.h)
							{
								num = (short)709885972;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)224329730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							goto IL_C99;
						case 18:
							if (this.h.SelectedDockWindow != null)
							{
								num = (short)1705050127;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_56A;
						case 19:
						{
							global::DevComponents.WpfDock.eDockSide dockSide = global::DevComponents.WpfDock.eDockSide.Left;
							num = (short)102170689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
							goto IL_43E;
						case 21:
							goto IL_C99;
						case 22:
							goto IL_272;
						case 23:
						{
							global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(0.0, new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(300.0)));
							doubleAnimation.Completed += this.j.i;
							global::System.Windows.UIElement uielement = this.j;
							this.j = null;
							uielement.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, doubleAnimation);
							num = (short)2101018681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
							if (a.d != null)
							{
								num = (short)936771589;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_43E;
						case 25:
							if (this.h.IsFloating)
							{
								num = (short)1184038982;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C99;
						case 26:
							A_0 = true;
							num = (short)361824288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							goto IL_343;
						case 28:
						{
							if (this.w != null)
							{
								num = (short)1818099713;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)931182728;
							short num3 = num;
							num = (short)1304737928;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_C94;
							default:
								num = (short)1146683392;
								if (num != 0)
								{
								}
								dockWindowGroup = new global::DevComponents.WpfDock.DockWindowGroup();
								selectedItem = this.h.SelectedItem;
								this.c(this.h);
								num = (short)2138112018;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 29:
							if ((a.a & global::DevComponents.WpfDock.h.a) == global::DevComponents.WpfDock.h.a)
							{
								num = (short)1446248482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1803681859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							num = (short)1770324018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							this.w.EndDockOperation();
							num = (short)2022440977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							goto IL_4FC;
						case 33:
							goto IL_84C;
						case 34:
							num = (short)1290272813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							this.w.DockWindow(this.h, this.a(a.a), (a.a & global::DevComponents.WpfDock.h.b) == global::DevComponents.WpfDock.h.b);
							num = (short)1691090951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							if (a != null)
							{
								num = (short)446365736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B97;
						case 37:
							if (!A_0)
							{
								num = (short)1474166835;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_600;
						case 38:
							if (!A_0)
							{
								num = (short)1704263732;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_98B;
						case 39:
							if (a != null)
							{
								num = (short)452132883;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_600;
						case 40:
							num = (short)1174798360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
							if (this.i)
							{
								num = (short)1714356267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_343;
						case 42:
							if (this.w != null)
							{
								num = (short)344457247;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C99;
						case 43:
							num = (short)1454440476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
							goto IL_188;
						case 45:
							if (this.w != null)
							{
								num = (short)1296171054;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.FloatWindow(this.h, a.c, global::DevComponents.WpfDock.eEventActionSource.Mouse, false);
							num = (short)1593704511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
							this.w.FloatWindow(this.h, a.c);
							num = (short)452919308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 47:
							if ((a.a & global::DevComponents.WpfDock.h.a) == global::DevComponents.WpfDock.h.a)
							{
								num = (short)35848222;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_84C;
						case 48:
							goto IL_56A;
						case 49:
							if (!A_0)
							{
								num = (short)1238237240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_343;
						case 50:
							if (!this.h.CanFloat)
							{
								num = (short)1767768068;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_84C;
						case 51:
							num = (short)242352167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 52:
							num = (short)813367357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 53:
							goto IL_CD1;
						case 54:
							goto IL_272;
						case 55:
							switch (0)
							{
							case 0:
								goto IL_160;
							}
							continue;
						case 56:
							num = (short)834666537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 57:
							goto IL_8BA;
						case 58:
							num = (short)749142063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 59:
							goto IL_272;
						case 60:
							goto IL_98B;
						case 61:
							if (this.w != null)
							{
								num = (short)1840185406;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_98B;
						case 62:
							this.w.BeginDockOperation((a.a & global::DevComponents.WpfDock.h.a) == global::DevComponents.WpfDock.h.a);
							num = (short)1569587260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 63:
							goto IL_272;
						case 64:
						{
							global::DevComponents.WpfDock.eDockSide dockSide = this.a(a.a);
							num = (short)1773404204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 65:
							if (this.b(a.a))
							{
								num = (short)729481280;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_188;
						case 66:
							if (this.h.IsFloating)
							{
								num = (short)1242103814;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A4E;
						case 67:
							if (this.w != null)
							{
								num = (short)1431306275;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.DockWindow(this.h, this.a(a.a), (a.a & global::DevComponents.WpfDock.h.b) == global::DevComponents.WpfDock.h.b, global::DevComponents.WpfDock.eEventActionSource.Mouse, false);
							num = (short)372310038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 68:
							goto IL_8BA;
						case 69:
							if (!A_0)
							{
								num = (short)80150528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B97;
						case 70:
							this.a(this.h).Show();
							num = (short)173015061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_160:
						if (this.x == null)
						{
							num = (short)471400471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(this.j);
						this.j = null;
						this.x.Hide();
						num = (short)578551876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_188:
						num = (short)1237516299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_272:
						num = (short)1105854506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_343:
						num = (short)1641218117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_43E:
						num = (short)831389725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4FC:
						num = (short)765263910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_56A:
						this.a(this.h, dockWindowGroup, true);
						this.h.Items.Remove(selectedItem);
						num = (short)330825794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_600:
						num = (short)790036489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_84C:
						num = (short)766836773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8BA:
						this.g.Hide();
						a = this.m;
						num = (short)523763725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_98B:
						num = (short)1946681393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A4E:
						global::DevComponents.WpfDock.DockSite.SetIsDocument((global::System.Windows.UIElement)selectedItem, false);
						dockWindowGroup.Items.Add(selectedItem);
						this.h = dockWindowGroup;
						num = (short)764542990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B97:
						num = (short)1840709657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C94:
						this.h = this.w.TearOffSelectedDockWindow(this.h);
						num = (short)907411483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C99:
						this.OnAfterDocked(new global::DevComponents.WpfDock.DockRoutedEventArgs(global::DevComponents.WpfDock.DockSite.AfterDockedEvent, this, this.h, global::DevComponents.WpfDock.eEventActionSource.Mouse));
						this.m = null;
						num = (short)1237844021;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_CD1:
					break;
				}
				}
			}
			finally
			{
				num = (short)582352897;
				if (num != 0)
				{
				}
				this.f = false;
				this.h = null;
			}
			num = (short)195952640;
			short num4 = num;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000115D0 File Offset: 0x0000F7D0
		protected virtual void OnAfterDocked(global::DevComponents.WpfDock.DockRoutedEventArgs dockRoutedEventArgs)
		{
			short num = (short)1002160861;
			short num2 = num;
			num = (short)933085917;
			switch (num2 == num)
			{
			}
			num = (short)521666560;
			short num3 = num;
			num = (short)87752704;
			if (num != 0)
			{
			}
			num = (short)1802567681;
			if (num != 0)
			{
			}
			base.RaiseEvent(dockRoutedEventArgs);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00011680 File Offset: 0x0000F880
		protected virtual void OnBeforeDocked(global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs dockEndsArgs)
		{
			short num = (short)1283528867;
			short num2 = num;
			num = (short)2037520547;
			switch (num2 == num)
			{
			}
			num = (short)1508769792;
			short num3 = num;
			num = (short)875626497;
			if (num != 0)
			{
			}
			num = (short)231997440;
			if (num != 0)
			{
			}
			base.RaiseEvent(dockEndsArgs);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00011730 File Offset: 0x0000F930
		private void c(global::DevComponents.WpfDock.DockWindowGroup A_0)
		{
			short num = (short)568190277;
			short num2 = num;
			num = (short)826074437;
			switch (num2 == num)
			{
			}
			num = (short)1048838144;
			short num3 = num;
			num = (short)1162674177;
			if (num != 0)
			{
			}
			num = (short)1159725056;
			if (num != 0)
			{
			}
			A_0.SelectDifferentTab();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000117E0 File Offset: 0x0000F9E0
		public bool FloatWindow(global::DevComponents.WpfDock.DockWindow dw)
		{
			short num = (short)976458837;
			short num2 = num;
			num = (short)2034406485;
			switch (num2 == num)
			{
			}
			num = (short)1852899328;
			short num3 = num;
			num = (short)720109569;
			if (num != 0)
			{
			}
			num = (short)2037907456;
			if (num != 0)
			{
			}
			return this.FloatWindow(dw, global::DevComponents.WpfDock.eEventActionSource.Code, true, true);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00011894 File Offset: 0x0000FA94
		public bool FloatWindow(global::DevComponents.WpfDock.DockWindow dw, bool focusContent)
		{
			short num = (short)18695157;
			short num2 = num;
			num = (short)583943157;
			switch (num2 == num)
			{
			}
			num = (short)432406528;
			if (num != 0)
			{
			}
			num = (short)538247169;
			if (num != 0)
			{
			}
			num = (short)811728896;
			short num3 = num;
			return this.FloatWindow(dw, global::DevComponents.WpfDock.eEventActionSource.Code, true, focusContent);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00011948 File Offset: 0x0000FB48
		public bool FloatWindow(global::DevComponents.WpfDock.DockWindow dw, global::DevComponents.WpfDock.eEventActionSource eventSource, bool raiseDockEvents)
		{
			short num = (short)1227796991;
			short num2 = num;
			num = (short)103723519;
			switch (num2 == num)
			{
			}
			num = (short)1670840320;
			if (num != 0)
			{
			}
			num = (short)1974599681;
			if (num != 0)
			{
			}
			num = (short)799342592;
			short num3 = num;
			return this.FloatWindow(dw, eventSource, raiseDockEvents, true);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000119FC File Offset: 0x0000FBFC
		public bool FloatWindow(global::DevComponents.WpfDock.DockWindow dw, global::DevComponents.WpfDock.eEventActionSource eventSource, bool raiseDockEvents, bool focusContent)
		{
			short num = (short)353173504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B1;
				}
				global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
				for (;;)
				{
					IL_28:
					num = (short)1672151040;
					short num3 = num;
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2;
					switch (num2)
					{
					case 0:
						goto IL_431;
					case 1:
						if (dockWindowGroup != null)
						{
							num = (short)407306261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_367;
					case 2:
						num = (short)1889271825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return false;
					case 4:
						dockWindowGroup.SelectedDockWindow.FocusContent();
						num = (short)215744523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (raiseDockEvents)
						{
							num = (short)1707343887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
						goto IL_1E5;
					case 7:
						this.c(dockWindowGroup);
						num = (short)803274770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1541603342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (dockWindowGroup != null)
						{
							num = (short)238419976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_169;
					case 10:
					{
						global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs beforeDockedRoutedEventArgs = new global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs(global::DevComponents.WpfDock.DockSite.BeforeDockedEvent, this, dw, eventSource, true, global::DevComponents.WpfDock.eDockSide.Left, null);
						this.OnBeforeDocked(beforeDockedRoutedEventArgs);
						num = (short)860749837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_FA;
					case 12:
						goto IL_27B;
					case 13:
					{
						global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs beforeDockedRoutedEventArgs;
						if (beforeDockedRoutedEventArgs.Cancel)
						{
							num = (short)76808195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_436;
					}
					case 14:
						if (dockWindowGroup.VisibleItemsCount == 1)
						{
							num = (short)1253572608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_169;
					case 15:
					{
						global::DevComponents.WpfDock.DockRoutedEventArgs dockRoutedEventArgs = new global::DevComponents.WpfDock.DockRoutedEventArgs(global::DevComponents.WpfDock.DockSite.AfterDockedEvent, this, dw, eventSource);
						this.OnAfterDocked(dockRoutedEventArgs);
						num = (short)1399980044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (raiseDockEvents)
						{
							num = (short)1774518282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_436;
					case 17:
						while (dockWindowGroup.SelectedItem == dw)
						{
							num = (short)1188863906;
							short num4 = num;
							num = (short)580362146;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1317863424;
								if (num != 0)
								{
								}
								num = (short)795738119;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_28;
							}
						}
						goto IL_FA;
					case 18:
						if (dockWindowGroup.SelectedDockWindow != null)
						{
							num = (short)2108948484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA;
					case 19:
						goto IL_367;
					case 20:
						if (dockWindowGroup != null)
						{
							num = (short)1700724738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					case 21:
						this.a(dockWindowGroup, dockWindowGroup2, true);
						num = (short)565968915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B1;
					IL_FA:
					dockWindowGroup.Items.Remove(dw);
					num = (short)1593638918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_169:
					num = (short)985464848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E5:
					dockWindowGroup2 = new global::DevComponents.WpfDock.DockWindowGroup();
					num = (short)648937473;
					if (num != 0)
					{
					}
					num = (short)1943928833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_367:
					dockWindowGroup2.Items.Add(dw);
					dockWindowGroup2.SelectedItem = dw;
					this.FloatWindow(dockWindowGroup2, global::System.Windows.Rect.Empty, eventSource, false, focusContent);
					num = (short)314245125;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_436:
					num = (short)1142292500;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_27B:
				return true;
				IL_431:
				return this.FloatWindow(dw.Parent as global::DevComponents.WpfDock.DockWindowGroup, global::System.Windows.Rect.Empty, eventSource, raiseDockEvents);
				IL_B1:
				dockWindowGroup = (dw.Parent as global::DevComponents.WpfDock.DockWindowGroup);
				num = (short)2033451017;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00011E7C File Offset: 0x0001007C
		public bool FloatWindow(global::DevComponents.WpfDock.DockWindowGroup dg)
		{
			short num = (short)494407045;
			short num2 = num;
			num = (short)768740741;
			switch (num2 == num)
			{
			}
			num = (short)1428094977;
			if (num != 0)
			{
			}
			num = (short)1639579648;
			if (num != 0)
			{
			}
			num = (short)749600768;
			short num3 = num;
			return this.FloatWindow(dg, global::System.Windows.Rect.Empty, global::DevComponents.WpfDock.eEventActionSource.Code, true, true);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00011F38 File Offset: 0x00010138
		public bool FloatWindow(global::DevComponents.WpfDock.DockWindowGroup dg, global::System.Windows.Rect floatingRect, global::DevComponents.WpfDock.eEventActionSource eventSource, bool raiseDockEvents)
		{
			short num = (short)1594387154;
			short num2 = num;
			num = (short)868379346;
			switch (num2 == num)
			{
			}
			num = (short)690618368;
			if (num != 0)
			{
			}
			num = (short)643366913;
			if (num != 0)
			{
			}
			num = (short)808517632;
			short num3 = num;
			return this.FloatWindow(dg, floatingRect, eventSource, raiseDockEvents, true);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00011FEC File Offset: 0x000101EC
		public bool FloatWindow(global::DevComponents.WpfDock.DockWindowGroup dg, global::System.Windows.Rect floatingRect, global::DevComponents.WpfDock.eEventActionSource eventSource, bool raiseDockEvents, bool focusWindowContent)
		{
			int a_ = 0;
			short num = (short)786890752;
			switch (num)
			{
			default:
			{
				num = (short)631570446;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfDock.FloatingWindow floatingWindow;
					global::System.Windows.Window window;
					switch (num2)
					{
					case 0:
						floatingWindow.Owner = window;
						num = (short)1780154378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_FF;
					case 2:
						goto IL_45E;
					case 3:
						goto IL_49F;
					case 4:
						if (raiseDockEvents)
						{
							num = (short)1277296669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D2;
					case 5:
						goto IL_32C;
					case 6:
						if (!dg.IsFloating)
						{
							num = (short)1476853762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						floatingWindow = this.a(dg);
						num = (short)807862300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (floatingRect.IsEmpty)
						{
							num = (short)1475805204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_49F;
					case 8:
						if (raiseDockEvents)
						{
							num = (short)516423711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 9:
						dg.SelectedDockWindow.FocusContent();
						num = (short)1653473302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_5F2;
					case 11:
						this.d(dg);
						num = (short)960167969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_64D;
					case 13:
						if (dg.SelectedIndex == -1)
						{
							num = (short)363462683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_594;
					case 14:
						switch (0)
						{
						case 0:
							goto IL_D6;
						}
						continue;
					case 15:
						goto IL_594;
					case 16:
						if (dg.IsFloating)
						{
							num = (short)550043660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						if (focusWindowContent)
						{
							num = (short)1560150041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_273;
					case 18:
					{
						num = (short)296812544;
						short num3 = num;
						if (dg.SelectedDockWindow != null)
						{
							num = (short)378994697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_273;
					}
					case 19:
						goto IL_68B;
					case 20:
						floatingRect = dg.FloatingRect;
						num = (short)76742659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1108279312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_273;
					case 23:
						if (dg.Parent != null)
						{
							num = (short)318963723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_546;
					case 24:
						if (window != null)
						{
							num = (short)2080440320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F2;
					case 25:
						num = (short)899743762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_1B8;
					case 27:
						dg.s();
						num = (short)2133458959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_FF;
					case 29:
					{
						global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs beforeDockedRoutedEventArgs = new global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs(global::DevComponents.WpfDock.DockSite.BeforeDockedEvent, this, dg, eventSource, true, global::DevComponents.WpfDock.eDockSide.Left, null);
						this.OnBeforeDocked(beforeDockedRoutedEventArgs);
						num = (short)1082654750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs beforeDockedRoutedEventArgs;
						if (beforeDockedRoutedEventArgs.Cancel)
						{
							num = (short)975699994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D2;
					}
					case 31:
					{
						global::DevComponents.WpfDock.DockRoutedEventArgs dockRoutedEventArgs = new global::DevComponents.WpfDock.DockRoutedEventArgs(global::DevComponents.WpfDock.DockSite.AfterDockedEvent, this, dg, eventSource);
						this.OnAfterDocked(dockRoutedEventArgs);
						num = (short)380043269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						if (this.IsDesignMode)
						{
							num = (short)1568473107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2066022404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_546;
					}
					IL_D6:
					if (!dg.CanFloat)
					{
						num = (short)596574229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64D;
					IL_FF:
					num = (short)67960839;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_273:
					num = (short)1041563656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D2:
					num = (short)989836355;
					short num4 = num;
					num = (short)1098232899;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_45E:
						num = (short)236650519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)163119104;
						if (num != 0)
						{
						}
						floatingWindow = null;
						num = (short)1669857286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_49F:
					floatingWindow.Width = floatingRect.Width;
					floatingWindow.Height = floatingRect.Height;
					floatingWindow.Left = floatingRect.Left;
					floatingWindow.Top = floatingRect.Top;
					floatingWindow.Show();
					floatingWindow.CanClose = dg.CanClose;
					num = (short)494993425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_546:
					base.Focus();
					this.Detach(dg);
					num = (short)169279501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_594:
					floatingWindow = new global::DevComponents.WpfDock.FloatingWindow();
					floatingWindow.DataContext = base.DataContext;
					this.t.Add(floatingWindow);
					window = global::System.Windows.Window.GetWindow(this);
					num = (short)1769013272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F2:
					floatingWindow.DockSite = this;
					floatingWindow.Content = dg;
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("꓀꿂ꃄ꓆뷈껊꧌賎뻐뷒ꇔ닖럘꿚關뫞胠蟢胤闦", a_));
					binding.Source = dg;
					global::System.Windows.Data.BindingOperations.SetBinding(floatingWindow, global::System.Windows.Window.TitleProperty, binding);
					dg.IsFloating = true;
					num = (short)303300609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64D:
					num = (short)1199112224;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B8:
				num = (short)1797128193;
				if (num != 0)
				{
				}
				return false;
				IL_32C:
				return true;
				IL_68B:
				return false;
			}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0001268C File Offset: 0x0001088C
		internal void a(global::DevComponents.WpfDock.FloatingWindow A_0)
		{
			short num = (short)462737285;
			short num2 = num;
			num = (short)792776581;
			switch (num2 == num)
			{
			}
			num = (short)1039532033;
			if (num != 0)
			{
			}
			num = (short)1942814720;
			short num3 = num;
			num = (short)503447552;
			if (num != 0)
			{
			}
			this.t.Remove(A_0);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00012744 File Offset: 0x00010944
		private bool b(global::DevComponents.WpfDock.h A_0)
		{
			short num = (short)68222979;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if ((A_0 & global::DevComponents.WpfDock.h.d) != (global::DevComponents.WpfDock.h)0)
					{
						num = (short)951648262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)242089991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return true;
				case 2:
					if ((A_0 & global::DevComponents.WpfDock.h.e) != (global::DevComponents.WpfDock.h)0)
					{
						num = (short)1696989188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 4:
					goto IL_E4;
				case 5:
					return true;
				case 6:
					return true;
				case 7:
					if ((A_0 & global::DevComponents.WpfDock.h.g) != (global::DevComponents.WpfDock.h)0)
					{
						num = (short)354680837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1777991682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					return true;
				case 9:
					if ((A_0 & global::DevComponents.WpfDock.h.c) != (global::DevComponents.WpfDock.h)0)
					{
						num = (short)456065032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)455868416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4C:
				if ((A_0 & global::DevComponents.WpfDock.h.f) != (global::DevComponents.WpfDock.h)0)
				{
					num = (short)1123745793;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)876937225;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
			IL_E4:
			num = (short)484638035;
			short num3 = num;
			num = (short)355925331;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			case 1:
				break;
			default:
			{
				num = (short)39976960;
				short num4 = num;
				break;
			}
			}
			num = (short)367591424;
			if (num != 0)
			{
			}
			num = (short)1730871297;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00012950 File Offset: 0x00010B50
		private global::DevComponents.WpfDock.eDockSide a(global::DevComponents.WpfDock.h A_0)
		{
			int a_ = 11;
			short num = (short)232128515;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if ((A_0 & global::DevComponents.WpfDock.h.d) != (global::DevComponents.WpfDock.h)0)
					{
						num = (short)502857734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)204668935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return global::DevComponents.WpfDock.eDockSide.Bottom;
				case 2:
					if ((A_0 & global::DevComponents.WpfDock.h.e) != (global::DevComponents.WpfDock.h)0)
					{
						num = (short)1281425412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_205;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 4:
					goto IL_113;
				case 5:
					return global::DevComponents.WpfDock.eDockSide.Tab;
				case 6:
					return global::DevComponents.WpfDock.eDockSide.Right;
				case 7:
					if ((A_0 & global::DevComponents.WpfDock.h.g) != (global::DevComponents.WpfDock.h)0)
					{
						num = (short)1989738501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)289079298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_AD;
				case 9:
					if ((A_0 & global::DevComponents.WpfDock.h.c) != (global::DevComponents.WpfDock.h)0)
					{
						num = (short)933167112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2143223808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				if ((A_0 & global::DevComponents.WpfDock.h.f) != (global::DevComponents.WpfDock.h)0)
				{
					num = (short)1919090689;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)826146825;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return global::DevComponents.WpfDock.eDockSide.Bottom;
			IL_AD:
			num = (short)1020002305;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfDock.eDockSide.Left;
			IL_113:
			num = (short)1344602112;
			short num3 = num;
			num = (short)45924712;
			short num4 = num;
			num = (short)385270120;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return global::DevComponents.WpfDock.eDockSide.Right;
			default:
				num = (short)764739584;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfDock.eDockSide.Top;
			}
			return global::DevComponents.WpfDock.eDockSide.Tab;
			IL_205:
			throw new global::System.InvalidCastException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("觉귋ꃍ뻏뷑ꃓ믗뗙닛꣝藟郡郣웥跧껩菫跭鯯믱髳郵韷\udaf9飻韽⃿瘁欃★洇三挋洍笏䄑紓爕紗㨙漛眝丟䄡䄣إ䄧帩ఫ䴭弯就䀳圵儷吹伻ḽ⤿ⱁ㉃❅⑇⍉⡋湍♏㍑㡓⍕㵗瑙", a_));
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00012B78 File Offset: 0x00010D78
		private void a(global::DevComponents.WpfDock.Primitives.d A_0)
		{
			short num = (short)1727397898;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Documents.AdornerLayer adornerLayer;
				switch (num2)
				{
				case 0:
				{
					num = (short)924516352;
					short num3 = num;
					goto IL_1B8;
				}
				case 1:
					goto IL_1CF;
				case 2:
					adornerLayer.Remove(A_0);
					num = (short)1885667335;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.x != null)
					{
						num = (short)1728315403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2117402633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1B8;
				case 5:
					num = (short)712179715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1B8;
				case 7:
					return;
				case 8:
					adornerLayer = (A_0.Parent as global::System.Windows.Documents.AdornerLayer);
					num = (short)495058950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (A_0.Parent is global::System.Windows.Documents.AdornerLayer)
					{
						num = (short)849281032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
					num = (short)907345920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)24316429;
					short num4 = num;
					num = (short)1329531405;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1CF;
					default:
						num = (short)908591104;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						continue;
					}
					break;
				}
				case 11:
					adornerLayer = this.x.a();
					num = (short)1395261444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A0:
				if (A_0 != null)
				{
					num = (short)17301509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1B8:
				num = (short)515178497;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CF:
				if (adornerLayer == null)
				{
					break;
				}
				num = (short)903741441;
				if (num != 0)
				{
				}
				num = (short)206569474;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00012DE0 File Offset: 0x00010FE0
		private void a(global::DevComponents.WpfDock.Primitives.c A_0)
		{
			short num = (short)1703411722;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Documents.AdornerLayer adornerLayer;
				switch (num2)
				{
				case 0:
				{
					num = (short)1068892160;
					short num3 = num;
					goto IL_1E4;
				}
				case 1:
					goto IL_1FC;
				case 2:
					adornerLayer.Remove(A_0);
					num = (short)797179911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.y != null)
					{
						num = (short)974848011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)8847369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1E4;
				case 5:
					num = (short)387317763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1E4;
				case 7:
					return;
				case 8:
					adornerLayer = (A_0.Parent as global::System.Windows.Documents.AdornerLayer);
					num = (short)450953222;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (A_0.Parent is global::System.Windows.Documents.AdornerLayer)
					{
						num = (short)627769352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
					num = (short)1610285056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1451030661;
					short num4 = num;
					num = (short)432666757;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1FC;
					default:
						num = (short)401997824;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					}
					break;
				}
				case 11:
					adornerLayer = this.y.a();
					num = (short)284164097;
					if (num != 0)
					{
					}
					num = (short)1434189828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A1:
				if (A_0 != null)
				{
					num = (short)2117992453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1E4:
				num = (short)1900937217;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1FC:
				if (adornerLayer == null)
				{
					break;
				}
				num = (short)808517634;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00013050 File Offset: 0x00011250
		private global::DevComponents.WpfDock.DockSite.a a(global::System.Windows.Point A_0)
		{
			short num = (short)1520697344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_17A;
				}
				global::DevComponents.WpfDock.DockSite.a a;
				double num4;
				global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
				for (;;)
				{
					IL_27:
					global::DevComponents.WpfDock.eDockHintHitTest eDockHintHitTest;
					global::DevComponents.WpfDock.DockHint dockHint;
					global::System.Windows.Point point;
					switch (num2)
					{
					case 0:
						goto IL_441;
					case 1:
						num = (short)313524265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Windows.Rect layoutSlot;
						if (layoutSlot.Contains(A_0))
						{
							num = (short)1538523136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE1;
					}
					case 3:
						goto IL_CD8;
					case 4:
						goto IL_CB7;
					case 5:
						goto IL_56E;
					case 6:
					{
						global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this.j.l() as global::System.Windows.FrameworkElement);
						num = (short)1376124930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num = (short)1636368384;
						short num3 = num;
						global::System.Windows.Rect rect;
						a.c = rect;
						num = (short)1578238001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (this.j.n() != null)
						{
							num = (short)505937955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D8;
					case 9:
						num = (short)479920180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_F77;
					case 11:
						if (this.j.l() != null)
						{
							num = (short)928710662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE1;
					case 12:
						goto IL_5C1;
					case 13:
						goto IL_C28;
					case 14:
						num = (short)1166803007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						return a;
					case 16:
						return a;
					case 17:
						if (eDockHintHitTest != global::DevComponents.WpfDock.eDockHintHitTest.None)
						{
							num = (short)323420210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D8;
					case 18:
						goto IL_68D;
					case 19:
					{
						bool flag;
						if (flag)
						{
							num = (short)959381542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a.c = new global::System.Windows.Rect(this.e.X, this.e.Y, this.e.Width, num4);
						num = (short)1470824495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)1525022795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						global::System.Windows.Rect layoutSlot2 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this.j.j() as global::System.Windows.FrameworkElement);
						num = (short)308019231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						num = (short)1579548745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)1348337719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)106364976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::System.Windows.Rect layoutSlot3 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this.j.m() as global::System.Windows.FrameworkElement);
						num = (short)99942460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (a.d != null)
						{
							num = (short)924844066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 27:
						point = dockHint.PointFromScreen(base.PointToScreen(A_0));
						num = (short)585695291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (!dockWindowGroup.CanDockRight)
						{
							num = (short)806682691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DB3;
					case 29:
						goto IL_B9B;
					case 30:
						if (this.j.k() != null)
						{
							num = (short)1881931827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1088;
					case 31:
					{
						global::System.Windows.Rect layoutSlot2;
						if (layoutSlot2.Contains(A_0))
						{
							num = (short)1754529837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E7D;
					}
					case 32:
					{
						global::System.Windows.Rect layoutSlot4;
						if (layoutSlot4.Contains(A_0))
						{
							num = (short)744030251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D8;
					}
					case 33:
					{
						global::System.Windows.Rect rect;
						a.c = new global::System.Windows.Rect(rect.X, rect.Y, rect.Width / 2.0, rect.Height);
						num = (short)366215173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						goto IL_DB3;
					case 35:
					{
						global::System.Windows.Rect layoutSlot4 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot((global::System.Windows.FrameworkElement)this.j.n());
						num = (short)989855776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						if (eDockHintHitTest == global::DevComponents.WpfDock.eDockHintHitTest.Right)
						{
							num = (short)747307076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 37:
						if (a.d != null)
						{
							num = (short)1753022520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A86;
					case 38:
					{
						global::System.Windows.Rect rect;
						a.c = new global::System.Windows.Rect(rect.X, rect.Y, rect.Width, rect.Height / 2.0);
						num = (short)212074557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						goto IL_B9B;
					case 40:
						if (eDockHintHitTest == global::DevComponents.WpfDock.eDockHintHitTest.Tab)
						{
							num = (short)70123542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return a;
					case 41:
						if (!dockWindowGroup.CanDockBottom)
						{
							num = (short)210960408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_970;
					case 42:
					{
						global::System.Windows.Rect rect;
						a.c = new global::System.Windows.Rect(rect.Right - rect.Width / 2.0, rect.Y, rect.Width / 2.0, rect.Height);
						num = (short)1952972815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						dockHint = (this.j.n() as global::DevComponents.WpfDock.DockHint);
						num = (short)291176510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num4 = global::DevComponents.WpfDock.DockSite.GetDockSize(dockWindowGroup.Parent as global::System.Windows.UIElement);
						num = (short)845611047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_8DD;
					case 46:
					{
						global::DevComponents.WpfDock.FloatingWindow floatingWindow;
						point = dockHint.PointFromScreen(floatingWindow.PointToScreen(A_0));
						num = (short)1661403148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						goto IL_1042;
					case 48:
						if (a.d != null)
						{
							num = (short)357367887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_809;
					case 49:
						goto IL_CB7;
					case 50:
					{
						a = new global::DevComponents.WpfDock.DockSite.a();
						a.d = (this.l as global::DevComponents.WpfDock.DockWindowGroup);
						global::System.Windows.Rect rect = this.j.o();
						bool flag = this.l != null;
						num = (short)398917697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
					{
						global::System.Windows.Rect layoutSlot5 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this.j.k() as global::System.Windows.FrameworkElement);
						num = (short)790888528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						if (((global::DevComponents.WpfDock.DockWindowGroup)this.l).IsFloating)
						{
							num = (short)68878390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C1;
					case 53:
						goto IL_569;
					case 54:
					{
						global::DevComponents.WpfDock.FloatingWindow floatingWindow = this.a(this.l);
						num = (short)1155006538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						if (!dockWindowGroup.CanDockLeft)
						{
							num = (short)1867710477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D38;
					case 56:
						goto IL_D38;
					case 57:
						return a;
					case 58:
						goto IL_E4D;
					case 59:
						if (this.l is global::DevComponents.WpfDock.DockWindowGroup)
						{
							num = (short)975306761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C1;
					case 60:
					{
						global::System.Windows.Rect layoutSlot3;
						if (layoutSlot3.Contains(A_0))
						{
							num = (short)501219386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_692;
					}
					case 61:
						goto IL_804;
					case 62:
						if (dockHint != null)
						{
							num = (short)1641742363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D8;
					case 63:
						if (!dockWindowGroup.CanDockTop)
						{
							num = (short)2071265300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F77;
					case 64:
						if (eDockHintHitTest == global::DevComponents.WpfDock.eDockHintHitTest.Top)
						{
							num = (short)1757216782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D75;
					case 65:
						if (eDockHintHitTest == global::DevComponents.WpfDock.eDockHintHitTest.Bottom)
						{
							num = (short)1974927361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_809;
					case 66:
						num = (short)680787969;
						if (num != 0)
						{
						}
						if (this.j.m() != null)
						{
							num = (short)36044825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_692;
					case 67:
						num = (short)910360602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)337838108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
					{
						global::System.Windows.Rect rect;
						a.c = new global::System.Windows.Rect(rect.X, rect.Bottom - rect.Height / 2.0, rect.Width, rect.Height / 2.0);
						num = (short)768606226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 70:
						if (this.j.j() != null)
						{
							num = (short)357171221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E7D;
					case 71:
						goto IL_58E;
					case 72:
					{
						bool flag;
						if (flag)
						{
							num = (short)1133183045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a.c = new global::System.Windows.Rect(this.e.X, this.e.Bottom - num4, this.e.Width, num4);
						num = (short)1596129337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 73:
						if (this.l != null)
						{
							num = (short)761462791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a.c = this.e;
						num = (short)1501167620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
					{
						global::DevComponents.WpfDock.FloatingWindow floatingWindow;
						if (floatingWindow != null)
						{
							num = (short)1587085358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C1;
					}
					case 75:
						if (a.d != null)
						{
							num = (short)1942093834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D75;
					case 76:
						goto IL_56E;
					case 77:
						if (eDockHintHitTest == global::DevComponents.WpfDock.eDockHintHitTest.Left)
						{
							num = (short)2068316183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A86;
					case 78:
					{
						bool flag;
						if (flag)
						{
							num = (short)1549598762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a.c = new global::System.Windows.Rect(this.e.Right - num4, this.e.Y, num4, this.e.Height);
						num = (short)30670864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 79:
						goto IL_970;
					case 80:
					{
						global::System.Windows.Rect layoutSlot5;
						if (layoutSlot5.Contains(A_0))
						{
							num = (short)923598901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1088;
					}
					case 81:
					{
						bool flag;
						if (flag)
						{
							num = (short)269484065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a.c = new global::System.Windows.Rect(this.e.X, this.e.Y, num4, this.e.Height);
						num = (short)1134231628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 82:
						if (dockWindowGroup.Parent is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1608450092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = global::DevComponents.WpfDock.DockSite.GetDockSize(dockWindowGroup);
						num = (short)1435697181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17A;
					IL_21E:
					num = (short)152512063;
					short num5 = num;
					num = (short)644425279;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_C28:
						num = (short)2072903717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)800784384;
						if (num != 0)
						{
						}
						num = (short)1662910528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_56E:
					a.a = global::DevComponents.WpfDock.h.c;
					num = (short)366608455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C1:
					eDockHintHitTest = dockHint.HitTest(point);
					num = (short)1029505041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_692:
					num = (short)1470889995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D8:
					num = (short)850067526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_809:
					num = (short)419168333;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_970:
					a.a = global::DevComponents.WpfDock.h.f;
					num = (short)1468858440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A86:
					num = (short)1398145060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B9B:
					num = (short)1700724744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE1:
					num = (short)902496286;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CB7:
					a.a = global::DevComponents.WpfDock.h.g;
					num = (short)365756419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D38:
					num = (short)42008657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D75:
					num = (short)784859176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DB3:
					a.a = global::DevComponents.WpfDock.h.d;
					num = (short)1127678030;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E7D:
					num = (short)27328578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F77:
					a.a = global::DevComponents.WpfDock.h.e;
					num = (short)437911571;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_441:
				return new global::DevComponents.WpfDock.DockSite.a
				{
					a = (global::DevComponents.WpfDock.h.b | global::DevComponents.WpfDock.h.c),
					b = null,
					c = new global::System.Windows.Rect(0.0, 0.0, num4, base.RenderSize.Height)
				};
				IL_569:
				return new global::DevComponents.WpfDock.DockSite.a
				{
					a = (global::DevComponents.WpfDock.h.b | global::DevComponents.WpfDock.h.e),
					b = null,
					c = new global::System.Windows.Rect(0.0, 0.0, base.RenderSize.Width, num4)
				};
				IL_58E:
				IL_68D:
				IL_804:
				return a;
				IL_8DD:
				return new global::DevComponents.WpfDock.DockSite.a
				{
					a = (global::DevComponents.WpfDock.h.b | global::DevComponents.WpfDock.h.f),
					b = null,
					c = new global::System.Windows.Rect(0.0, base.RenderSize.Height - num4, base.RenderSize.Width, num4)
				};
				IL_CD8:
				return a;
				IL_E4D:
				return new global::DevComponents.WpfDock.DockSite.a
				{
					a = (global::DevComponents.WpfDock.h.b | global::DevComponents.WpfDock.h.d),
					b = null,
					c = new global::System.Windows.Rect(base.RenderSize.Width - num4, 0.0, num4, base.RenderSize.Height)
				};
				IL_1042:
				return a;
				IL_1088:
				return new global::DevComponents.WpfDock.DockSite.a();
				IL_17A:
				num4 = 0.0;
				dockWindowGroup = this.h;
				num = (short)279707730;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000140EC File Offset: 0x000122EC
		public global::DevComponents.WpfDock.SplitPanel CreateSplitPanel(global::DevComponents.WpfDock.DockWindowGroup group)
		{
			short num = (short)1013481143;
			short num2 = num;
			num = (short)1904574135;
			switch (num2 == num)
			{
			}
			num = (short)1726480385;
			if (num != 0)
			{
			}
			num = (short)552402944;
			if (num != 0)
			{
			}
			num = (short)1116143616;
			short num3 = num;
			return this.CreateSplitPanel(group, global::DevComponents.WpfDock.DockSite.GetDockSize(group));
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000141A4 File Offset: 0x000123A4
		public global::DevComponents.WpfDock.SplitPanel CreateSplitPanel(global::DevComponents.WpfDock.DockWindowGroup group, double size)
		{
			short num = (short)706543616;
			short num2 = num;
			num = (short)1637047911;
			short num3 = num;
			num = (short)1902861927;
			global::DevComponents.WpfDock.SplitPanel splitPanel;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1642856448;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				int num4;
				for (;;)
				{
					IL_80:
					switch (num4)
					{
					case 0:
						goto IL_11F;
					case 1:
						num = (short)1247805441;
						if (num != 0)
						{
						}
						global::DevComponents.WpfDock.DockSite.SetDockSize(splitPanel, size);
						num = (short)147652608;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!double.IsNaN(size))
						{
							num = (short)1396441089;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return splitPanel;
					}
					goto IL_92;
				}
				IL_11F:
				break;
				IL_92:
				splitPanel = new global::DevComponents.WpfDock.SplitPanel();
				splitPanel.Children.Add(group);
				num = (short)264175618;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_80;
			}
			}
			return splitPanel;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000142D4 File Offset: 0x000124D4
		private global::DevComponents.WpfDock.SplitPanel b(global::DevComponents.WpfDock.SplitPanel A_0)
		{
			short num = (short)214716638;
			short num2 = num;
			num = (short)329470174;
			switch (num2 == num)
			{
			}
			num = (short)834011137;
			if (num != 0)
			{
			}
			num = (short)993525760;
			if (num != 0)
			{
			}
			num = (short)1811021824;
			short num3 = num;
			return this.a(A_0, double.NaN);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0001438C File Offset: 0x0001258C
		private global::DevComponents.WpfDock.SplitPanel a(global::DevComponents.WpfDock.SplitPanel A_0, double A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfDock.SplitPanel splitPanel;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_87;
				case 1:
				{
					num2 = (short)1022123620;
					short num3 = num2;
					num2 = (short)888888932;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_87;
					default:
						goto IL_DD;
					}
					break;
				}
				case 2:
					if (!double.IsNaN(A_1))
					{
						num2 = (short)1411842049;
						if (num2 != 0)
						{
						}
						num2 = (short)1070989312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return splitPanel;
				}
				goto IL_1C;
				IL_87:
				global::DevComponents.WpfDock.DockSite.SetDockSize(splitPanel, A_1);
				num2 = (short)1708982273;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_DD:
			num2 = (short)558628864;
			short num4 = num2;
			num2 = (short)126287872;
			if (num2 != 0)
			{
			}
			return splitPanel;
			IL_1C:
			splitPanel = new global::DevComponents.WpfDock.SplitPanel();
			splitPanel.Children.Add(A_0);
			num2 = (short)1278214146;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000144B8 File Offset: 0x000126B8
		public void RestoreLastDockPosition(global::DevComponents.WpfDock.DockWindowGroup dg)
		{
			short num = (short)691907288;
			short num2 = num;
			num = (short)1164946136;
			switch (num2 == num)
			{
			}
			num = (short)1699086336;
			short num3 = num;
			num = (short)345178113;
			if (num != 0)
			{
			}
			num = (short)997064704;
			if (num != 0)
			{
			}
			this.RestoreLastDockPosition(dg, false);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0001456C File Offset: 0x0001276C
		public void RestoreLastDockPosition(global::DevComponents.WpfDock.DockWindowGroup dg, bool focusSelectedDockWindow)
		{
			short num = (short)1064166722;
			short num2 = num;
			num = (short)831972674;
			switch (num2 == num)
			{
			}
			num = (short)1927282688;
			short num3 = num;
			num = (short)2059010048;
			if (num != 0)
			{
			}
			num = (short)2054488065;
			if (num != 0)
			{
			}
			this.RestoreLastDockPosition(dg, focusSelectedDockWindow, global::DevComponents.WpfDock.eEventActionSource.Code);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00014620 File Offset: 0x00012820
		public void RestoreLastDockPosition(global::DevComponents.WpfDock.DockWindowGroup dg, bool focusSelectedDockWindow, global::DevComponents.WpfDock.eEventActionSource actionSource)
		{
			switch (0)
			{
			case 0:
				goto IL_94;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				global::System.Windows.UIElement uielement;
				switch (num)
				{
				case 0:
					if (uielement is global::DevComponents.WpfDock.SplitPanel)
					{
						num2 = (short)1328545823;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_490;
				case 1:
					return;
				case 2:
					goto IL_50F;
				case 3:
				{
					global::DevComponents.WpfDock.FloatingWindow floatingWindow;
					if (floatingWindow.IsActive)
					{
						num2 = (short)1661927437;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3D6;
				}
				case 4:
					if (uielement is global::DevComponents.WpfDock.DockWindowGroup)
					{
						num2 = (short)1785724939;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1179713536;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)455737358;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1647378441;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_2A4;
				case 8:
					if (flag && focusSelectedDockWindow)
					{
						num2 = (short)1298726928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_50F;
				case 9:
					if (((global::DevComponents.WpfDock.DockWindowGroup)uielement).SelectedDockWindow != null)
					{
						num2 = (short)1844510727;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10A;
				case 10:
					if (uielement == null)
					{
						num2 = (short)1108934661;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)335675396;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					flag = this.DockWindow(dg, uielement as global::DevComponents.WpfDock.DockWindowGroup, dg.LastDockReference, actionSource, true);
					num2 = (short)1899626526;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_10A;
				case 13:
					this.g();
					num2 = (short)1434583068;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					flag = this.DockWindow(dg, dg.LastIsDocument ? global::DevComponents.WpfDock.eDockSide.Tab : dg.LastDockSide, actionSource, true);
					num2 = (short)1634009090;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
				{
					global::DevComponents.WpfDock.FloatingWindow floatingWindow;
					if (floatingWindow != null)
					{
						num2 = (short)1694892054;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3D6;
				}
				case 16:
					num2 = (short)818413585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (uielement is global::DevComponents.WpfDock.DockWindowGroup)
					{
						num2 = (short)174981126;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_50F;
				case 18:
					if (dg.SelectedDockWindow != null)
					{
						num2 = (short)1142554651;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 19:
					if (dg.LastDockReferenceId == "")
					{
						num2 = (short)1266155545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					uielement = this.a(dg.LastDockReferenceId);
					num2 = (short)1922170890;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					goto IL_490;
				case 21:
					goto IL_50F;
				case 22:
					num2 = (short)1766653955;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					goto IL_50F;
				case 24:
				{
					num2 = (short)902430720;
					short num3 = num2;
					num2 = (short)289800210;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 25:
					flag = this.DockWindow(dg, dg.LastDockSide, dg.LastDockIsFullSizeDock, actionSource, true);
					num2 = (short)346226711;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					if (focusSelectedDockWindow && flag)
					{
						num2 = (short)1209270296;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 27:
					dg.SelectedDockWindow.FocusContent();
					num2 = (short)1640235009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					goto IL_3D6;
				case 29:
					if (dg.IsFloating)
					{
						num2 = (short)1383858208;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3D6;
				case 30:
					num2 = (short)421396481;
					if (num2 != 0)
					{
					}
					goto IL_490;
				case 31:
					flag = this.DockWindow(dg, uielement as global::DevComponents.WpfDock.SplitPanel, dg.LastDockReference, actionSource, true);
					num2 = (short)662765588;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
				{
					global::DevComponents.WpfDock.FloatingWindow floatingWindow = this.a(dg);
					num2 = (short)1190789135;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_94;
				IL_10A:
				focusSelectedDockWindow = false;
				num2 = (short)1460928533;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2A4:
				((global::DevComponents.WpfDock.DockWindowGroup)uielement).SelectedDockWindow.Focus();
				num2 = (short)1040384012;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_490:
				num2 = (short)65562174;
				short num4 = num2;
				num2 = (short)2050582078;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2A4;
				default:
					num2 = (short)708575232;
					if (num2 != 0)
					{
					}
					num2 = (short)1736179720;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_3D6:
				num2 = (short)102957075;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_50F:
				num2 = (short)1322385434;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_94:
			flag = false;
			num2 = (short)1348927517;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00014BE0 File Offset: 0x00012DE0
		private void g()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.Window window;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					window.Activate();
					num2 = (short)1880752128;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					if (window.IsActive)
					{
						return;
					}
					num2 = (short)1789552413;
					short num3 = num2;
					num2 = (short)1565550365;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)1251278849;
						if (num2 != 0)
						{
						}
						num2 = (short)988282880;
						if (num2 != 0)
						{
						}
						num2 = (short)574029824;
						short num4 = num2;
						num2 = (short)1124925441;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					num2 = (short)1261174786;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (window != null)
					{
						num2 = (short)1058668547;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_24;
			}
			return;
			IL_24:
			window = global::System.Windows.Window.GetWindow(this);
			num2 = (short)205586436;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00014D44 File Offset: 0x00012F44
		private void c(global::DevComponents.WpfDock.DockWindow A_0)
		{
			short num = (short)1505165312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
				global::DevComponents.WpfDock.DockWindowGroup parentGroup;
				global::DevComponents.WpfDock.DockWindowGroup parentGroup2;
				for (;;)
				{
					IL_28:
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2;
					switch (num2)
					{
					case 0:
						num = (short)1246494724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (dockWindowGroup != null)
						{
							num = (short)206962695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FC;
					case 2:
						num = (short)846659594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)239492313;
						short num3 = num;
						num = (short)1666079961;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2FC;
						default:
							goto IL_20A;
						}
						break;
					}
					case 4:
					{
						num = (short)619905024;
						short num4 = num;
						if (dockWindowGroup.VisibleItemsCount == 1)
						{
							num = (short)322568198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_173;
					}
					case 5:
						if (dockWindowGroup == A_0.ParentGroup)
						{
							num = (short)1234698240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_173;
					case 6:
						goto IL_2CD;
					case 7:
						num = (short)821100553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_362;
					case 9:
						if (dockWindowGroup == A_0.ParentGroup)
						{
							num = (short)1809186818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9;
					case 10:
						if (dockWindowGroup.VisibleItemsCount > 1)
						{
							num = (short)1995374605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9;
					case 11:
						if (!this.DockWindow(dockWindowGroup2, dockWindowGroup, global::DevComponents.WpfDock.eDockSide.Tab))
						{
							num = (short)1047789571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 12:
						if (!this.DockWindow(dockWindowGroup, global::DevComponents.WpfDock.DockSite.b(A_0.LastDock)))
						{
							num = (short)1361575944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_364;
					case 13:
						goto IL_2FC;
					}
					goto IL_67;
					IL_C9:
					num = (short)98041857;
					if (num != 0)
					{
					}
					num = (short)1352859653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_173:
					parentGroup = A_0.ParentGroup;
					dockWindowGroup2 = new global::DevComponents.WpfDock.DockWindowGroup();
					this.Detach(A_0);
					dockWindowGroup2.Items.Add(A_0);
					num = (short)1095368715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FC:
					parentGroup2 = A_0.ParentGroup;
					dockWindowGroup = new global::DevComponents.WpfDock.DockWindowGroup();
					this.Detach(A_0);
					dockWindowGroup.Items.Add(A_0);
					num = (short)280690700;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_20A:
				num = (short)1954217984;
				if (num != 0)
				{
				}
				this.Detach(A_0);
				parentGroup.Items.Add(A_0);
				return;
				IL_2CD:
				this.DockWindow(dockWindowGroup, global::DevComponents.WpfDock.DockSite.b(A_0.LastDock));
				return;
				IL_362:
				this.Detach(A_0);
				parentGroup2.Items.Add(A_0);
				return;
				IL_364:
				this.b(parentGroup2);
				return;
				IL_36C:
				this.b(parentGroup);
				dockWindowGroup.UpdateVisibility();
				return;
				IL_67:
				dockWindowGroup = (this.a(A_0.LastDockWindowGroupId) as global::DevComponents.WpfDock.DockWindowGroup);
				num = (short)544407553;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000150CC File Offset: 0x000132CC
		private void b(global::DevComponents.WpfDock.DockWindowGroup A_0)
		{
			short num;
			if (A_0.Items.Count <= 0)
			{
				num = (short)1740747704;
				short num2 = num;
				num = (short)867939256;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1680277504;
					if (num != 0)
					{
					}
					num = (short)1068957696;
					short num3 = num;
					this.Detach(A_0);
					return;
				}
				}
			}
			num = (short)1006829569;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00015190 File Offset: 0x00013390
		private global::System.Windows.UIElement a(string A_0)
		{
			short num = (short)150011904;
			switch (num)
			{
			default:
			{
				num = (short)2054684681;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfDock.SplitPanel splitPanel;
					int num5;
					global::DevComponents.WpfDock.SplitPanel[] array;
					global::DevComponents.WpfDock.SplitPanel[] array2;
					switch (num2)
					{
					case 0:
						if (splitPanel != null)
						{
							num = (short)886702086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F2;
					case 1:
					{
						global::DevComponents.WpfDock.SplitPanel splitPanel2;
						return splitPanel2;
					}
					case 2:
					{
						num = (short)1473152418;
						short num3 = num;
						num = (short)1166706082;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17C;
						default:
							goto IL_D3;
						}
						break;
					}
					case 3:
					{
						global::System.Windows.UIElement uielement;
						return uielement;
					}
					case 4:
					{
						global::System.Windows.UIElement uielement;
						if (uielement != null)
						{
							num = (short)20119552;
							short num4 = num;
							num = (short)2049048579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5++;
						num = (short)1687748616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_2F2;
					case 6:
						goto IL_17C;
					case 7:
						goto IL_23D;
					case 8:
						num = (short)1952841729;
						if (num != 0)
						{
						}
						goto IL_23D;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 10:
						array = new global::DevComponents.WpfDock.SplitPanel[this.SplitPanels.Count + ((splitPanel != null) ? 1 : 0)];
						this.SplitPanels.CopyTo(array, 0);
						num = (short)179634176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						if (num5 >= array2.Length)
						{
							num = (short)264241165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfDock.SplitPanel splitPanel2 = array2[num5];
						num = (short)760021004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::DevComponents.WpfDock.SplitPanel splitPanel2;
						if (splitPanel2.Id == A_0)
						{
							num = (short)1914699777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = this.a(splitPanel2, A_0);
						num = (short)138280964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_276;
					}
					IL_7C:
					if (A_0 == "")
					{
						num = (short)435683330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					splitPanel = (base.Content as global::DevComponents.WpfDock.SplitPanel);
					num = (short)506331146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17C:
					array[array.Length - 1] = splitPanel;
					num = (short)1286668293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23D:
					num = (short)1573978123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F2:
					array2 = array;
					num5 = 0;
					num = (short)73662471;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D3:
				num = (short)2045313024;
				if (num != 0)
				{
				}
				return null;
				IL_276:
				return null;
			}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000154B4 File Offset: 0x000136B4
		private global::System.Windows.UIElement a(global::DevComponents.WpfDock.SplitPanel A_0, string A_1)
		{
			short num;
			global::System.Windows.UIElement result;
			for (;;)
			{
				num = (short)452853761;
				if (num != 0)
				{
				}
				num = (short)683016192;
				switch (num)
				{
				default:
				{
					global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator = A_0.Children.GetEnumerator();
					try
					{
						num = (short)215613450;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Windows.UIElement uielement;
							global::DevComponents.WpfDock.SplitPanel splitPanel;
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)683606029;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								uielement = enumerator.Current;
								global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup = uielement as global::DevComponents.WpfDock.DockWindowGroup;
								num = (short)587399184;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)1609564166;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_DD;
							case 3:
							{
								global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
								if (dockWindowGroup.Id == A_1)
								{
									num = (short)1905197070;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_185;
							}
							case 4:
								result = splitPanel;
								num = (short)341180425;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::System.Windows.UIElement uielement2;
								result = uielement2;
								num = (short)905183234;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								if (splitPanel.Id == A_1)
								{
									num = (short)1948909572;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.UIElement uielement2 = this.a(splitPanel, A_1);
								num = (short)366673927;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								global::System.Windows.UIElement uielement2;
								if (uielement2 != null)
								{
									num = (short)533004293;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
								if (splitPanel != null)
								{
									num = (short)1509294081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 9:
								goto IL_141;
							case 10:
								switch (0)
								{
								case 0:
									goto IL_BE;
								}
								continue;
							case 11:
								goto IL_2D2;
							case 12:
								goto IL_2B3;
							case 13:
								num = (short)1634992139;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
							{
								global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
								result = dockWindowGroup;
								num = (short)579797004;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 15:
								num = (short)1052049411;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 16:
							{
								global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
								if (dockWindowGroup != null)
								{
									num = (short)1304756239;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_185;
							}
							}
							IL_146:
							num = (short)912523264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BE:
							goto IL_146;
							IL_185:
							splitPanel = (uielement as global::DevComponents.WpfDock.SplitPanel);
							num = (short)1591017480;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_DD:
						IL_141:
						IL_2B3:
						goto IL_344;
						IL_2D2:
						goto IL_52;
					}
					finally
					{
						num = (short)779681792;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_30A;
								}
								continue;
							case 1:
								goto IL_341;
							case 2:
								enumerator.Dispose();
								num = (short)936443905;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_30A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1124270082;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_341:;
					}
					IL_344:
					num = (short)1355146606;
					short num3 = num;
					num = (short)348972398;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_3A1;
					}
					goto Block_1;
				}
				}
			}
			IL_52:
			return null;
			Block_1:
			num = (short)916455424;
			short num4 = num;
			IL_3A1:
			num = (short)1099169792;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00015898 File Offset: 0x00013A98
		public bool DockWindow(global::DevComponents.WpfDock.DockWindowGroup group, global::DevComponents.WpfDock.eDockSide dockSide, bool fullSize)
		{
			short num = (short)1036070036;
			short num2 = num;
			num = (short)670641300;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2053701632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1064304641;
			if (num != 0)
			{
			}
			num = (short)75104256;
			if (num != 0)
			{
			}
			return this.DockWindow(group, dockSide, fullSize, global::DevComponents.WpfDock.eEventActionSource.Code, true);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00015950 File Offset: 0x00013B50
		public bool DockWindow(global::DevComponents.WpfDock.DockWindowGroup group, global::DevComponents.WpfDock.eDockSide dockSide, bool fullSize, global::DevComponents.WpfDock.eEventActionSource actionSource, bool raiseEvents)
		{
			short num = (short)1539047424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_10F;
				}
				global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs beforeDockedRoutedEventArgs;
				for (;;)
				{
					IL_28:
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
					global::DevComponents.WpfDock.SplitPanel splitPanel;
					global::System.Windows.Controls.Dock dock;
					switch (num2)
					{
					case 0:
						if (group.CanDockRight)
						{
							num = (short)760807457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
					{
						num = (short)1173876259;
						short num3 = num;
						num = (short)354938403;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return false;
						default:
							num = (short)1368653824;
							if (num != 0)
							{
							}
							this.OnBeforeDocked(beforeDockedRoutedEventArgs);
							num = (short)1456406533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						int num4;
						object[] array;
						if (num4 >= array.Length)
						{
							num = (short)163053579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = array[num4];
						group.Items.Remove(obj);
						dockWindowGroup.Items.Add(obj);
						num4++;
						num = (short)574554115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_8B4;
					case 4:
						goto IL_2E4;
					case 5:
						if (beforeDockedRoutedEventArgs.Cancel)
						{
							num = (short)94633990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_315;
					case 6:
						return false;
					case 7:
						goto IL_8B4;
					case 8:
						if (((global::DevComponents.WpfDock.SplitPanel)group.Parent).Children.Count == 1)
						{
							num = (short)1601699869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21A;
					case 9:
						if (!group.CanDockAsDocument)
						{
							num = (short)1441136686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1446182960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_7CD;
					case 11:
						num = (short)1579089972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (fullSize)
						{
							num = (short)1329725474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.SplitPanels.Add(splitPanel);
						num = (short)259457049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (dockSide == global::DevComponents.WpfDock.eDockSide.Tab)
						{
							num = (short)56492068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dock = global::DevComponents.WpfDock.DockSite.a(dockSide);
						num = (short)871301163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_783;
					case 15:
						num = (short)2070741039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_3A5;
					case 17:
						num = (short)1085997082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (dock == global::System.Windows.Controls.Dock.Top)
						{
							num = (short)538968079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_809;
					case 19:
						if (raiseEvents)
						{
							num = (short)1889599489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_315;
					case 20:
						if (group.CanDockLeft)
						{
							num = (short)61472784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 21:
						goto IL_77E;
					case 22:
						goto IL_5BC;
					case 23:
						return false;
					case 24:
						num = (short)718733312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_783;
					case 26:
						if (group.CanDockBottom)
						{
							num = (short)1593049110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 27:
						num = (short)1459224584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						this.OnBeforeDocked(beforeDockedRoutedEventArgs);
						num = (short)1057226796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						splitPanel = (group.Parent as global::DevComponents.WpfDock.SplitPanel);
						this.Detach(splitPanel);
						num = (short)96927781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)1458044977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_847;
					case 32:
						goto IL_73D;
					case 33:
						goto IL_9A2;
					case 34:
						this.SplitPanels.Insert(0, splitPanel);
						num = (short)418250766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (dockWindowGroup != null)
						{
							num = (short)2072182822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.Content = this.CreateSplitPanel(group);
						num = (short)943783990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1121976329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_847;
					case 38:
					{
						object[] array2 = new object[group.Items.Count];
						group.Items.CopyTo(array2, 0);
						object[] array = array2;
						int num4 = 0;
						num = (short)1393164295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						if (dock == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)949420056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A2;
					case 40:
						if (raiseEvents)
						{
							num = (short)1665663006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 41:
						if (dock == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)331284497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5BC;
					case 42:
						this.OnAfterDocked(new global::DevComponents.WpfDock.DockRoutedEventArgs(global::DevComponents.WpfDock.DockSite.AfterDockedEvent, this, group, actionSource));
						num = (short)1138098180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (dock == global::System.Windows.Controls.Dock.Left)
						{
							num = (short)2050687031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A5;
					case 44:
						if (beforeDockedRoutedEventArgs.Cancel)
						{
							num = (short)1539964951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_189;
					case 45:
						if (raiseEvents)
						{
							num = (short)1177550890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 46:
						return false;
					case 47:
						if (!group.CanDockTop)
						{
							num = (short)704315413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_809;
					case 48:
					{
						num = (short)929824768;
						short num5 = num;
						if (raiseEvents)
						{
							num = (short)1875378204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_189;
					}
					case 49:
						this.OnAfterDocked(new global::DevComponents.WpfDock.DockRoutedEventArgs(global::DevComponents.WpfDock.DockSite.AfterDockedEvent, this, (dockWindowGroup != null) ? dockWindowGroup : group, actionSource));
						num = (short)491585568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (this.AnimationEnabled)
						{
							num = (short)1236664371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CD;
					case 51:
					{
						global::System.Windows.Media.Animation.DoubleAnimation animation = new global::System.Windows.Media.Animation.DoubleAnimation(0.0, 1.0, new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(350.0)), global::System.Windows.Media.Animation.FillBehavior.Stop);
						group.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, animation);
						num = (short)1979645962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						goto IL_63C;
					case 53:
						if (group.Parent is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)2063007771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21A;
					case 54:
						goto IL_63C;
					case 55:
						num = (short)504102932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10F;
					IL_189:
					this.Detach(group);
					dockWindowGroup = this.FindTargetDockDocumentGroup();
					num = (short)189792291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21A:
					this.Detach(group);
					splitPanel = this.CreateSplitPanel(group);
					num = (short)1599275039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_315:
					splitPanel = null;
					num = (short)537854005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A5:
					num = (short)329973801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5BC:
					num = (short)555745319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_63C:
					this.UpdateIsDocument();
					num = (short)1263206440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_783:
					global::DevComponents.WpfDock.DockSite.SetDock(splitPanel, dock);
					group.InvalidateMeasure();
					num = (short)2009530418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7CD:
					num = (short)636026925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_809:
					num = (short)1600716819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_847:
					group.IsFloating = false;
					num = (short)1666187276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8B4:
					num = (short)857407490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A2:
					num = (short)1273626642;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_2E4:
				num = (short)462684161;
				if (num != 0)
				{
				}
				return true;
				IL_73D:
				return true;
				IL_77E:
				return false;
				IL_10F:
				beforeDockedRoutedEventArgs = new global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs(global::DevComponents.WpfDock.DockSite.BeforeDockedEvent, this, group, actionSource, false, dockSide, null);
				num = (short)1524760589;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0001633C File Offset: 0x0001453C
		public bool DockWindow(global::DevComponents.WpfDock.DockWindow dw, global::DevComponents.WpfDock.eDockSide dockSide)
		{
			short num = (short)674758657;
			if (num != 0)
			{
			}
			num = (short)391097632;
			short num2 = num;
			num = (short)1160817952;
			switch (num2 == num)
			{
			default:
			{
				num = (short)533921792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)219480064;
			if (num != 0)
			{
			}
			return this.DockWindow(dw, dockSide, global::DevComponents.WpfDock.eEventActionSource.Code, true);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000163F0 File Offset: 0x000145F0
		public bool DockWindow(global::DevComponents.WpfDock.DockWindow dw, global::DevComponents.WpfDock.eDockSide dockSide, global::DevComponents.WpfDock.eEventActionSource actionSource, bool raiseEvents)
		{
			short num = (short)1092861097;
			short num2 = num;
			num = (short)2134555817;
			switch (num2 == num)
			{
			}
			num = (short)327090176;
			short num3 = num;
			num = (short)838664193;
			if (num != 0)
			{
			}
			num = (short)1260650496;
			if (num != 0)
			{
			}
			return this.DockWindow(dw, dockSide, false, actionSource, raiseEvents);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000164A4 File Offset: 0x000146A4
		public bool DockWindow(global::DevComponents.WpfDock.DockWindow dw, global::DevComponents.WpfDock.DockWindowGroup referenceGroup, global::DevComponents.WpfDock.eDockSide dockSide)
		{
			short num = (short)430678628;
			short num2 = num;
			num = (short)456630884;
			switch (num2 == num)
			{
			}
			num = (short)1599012864;
			short num3 = num;
			num = (short)1548091393;
			if (num != 0)
			{
			}
			num = (short)743768064;
			if (num != 0)
			{
			}
			return this.DockWindow(dw, referenceGroup, dockSide, global::DevComponents.WpfDock.eEventActionSource.Code, true);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00016558 File Offset: 0x00014758
		public bool DockWindow(global::DevComponents.WpfDock.DockWindow dw, global::DevComponents.WpfDock.DockWindowGroup referenceGroup, global::DevComponents.WpfDock.eDockSide dockSide, global::DevComponents.WpfDock.eEventActionSource actionSource, bool raiseEvents)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
			short num2;
			global::DevComponents.WpfDock.DockWindowGroup parentGroup;
			int insertIndex;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_123;
				case 1:
					if (!this.a(dockWindowGroup, referenceGroup, dockSide, actionSource, raiseEvents))
					{
						num2 = (short)369885186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					this.Detach(dw);
					num2 = (short)1691549701;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					parentGroup.Items.Insert(insertIndex, dw);
					num2 = (short)1644691463;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					insertIndex = parentGroup.Items.IndexOf(dockWindowGroup);
					num2 = (short)295174144;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (parentGroup != null)
					{
						num2 = (short)2128674819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					num2 = (short)799342593;
					if (num2 != 0)
					{
					}
					if (parentGroup != null)
					{
						num2 = (short)1396703236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_123;
				case 7:
					return false;
				}
				goto IL_30;
				IL_123:
				num2 = (short)1167497764;
				short num3 = num2;
				num2 = (short)1474599460;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
				{
					num2 = (short)1836711936;
					if (num2 != 0)
					{
					}
					num2 = (short)1261895680;
					short num4 = num2;
					this.Detach(dw);
					dockWindowGroup.Items.Add(dw);
					num2 = (short)1258356737;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
				}
			}
			return false;
			IL_30:
			parentGroup = dw.ParentGroup;
			dockWindowGroup = new global::DevComponents.WpfDock.DockWindowGroup();
			insertIndex = -1;
			num2 = (short)946733062;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00016754 File Offset: 0x00014954
		public bool DockWindow(global::DevComponents.WpfDock.DockWindow dw, global::DevComponents.WpfDock.eDockSide dockSide, bool fullSize, global::DevComponents.WpfDock.eEventActionSource actionSource, bool raiseEvents)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
			short num2;
			global::DevComponents.WpfDock.DockWindowGroup parentGroup;
			int insertIndex;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FC;
				case 1:
					if (!this.DockWindow(dockWindowGroup, dockSide, fullSize, actionSource, raiseEvents))
					{
						num2 = (short)1081278466;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					this.Detach(dw);
					num2 = (short)1653014533;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					parentGroup.Items.Insert(insertIndex, dw);
					num2 = (short)1477246983;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					insertIndex = parentGroup.Items.IndexOf(dockWindowGroup);
					num2 = (short)1177812992;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (parentGroup != null)
					{
						num2 = (short)920453123;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					if (parentGroup != null)
					{
						num2 = (short)1004208132;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FC;
				case 7:
					return false;
				}
				goto IL_30;
				IL_FC:
				num2 = (short)1644044397;
				short num3 = num2;
				num2 = (short)529473645;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
				{
					num2 = (short)927596545;
					if (num2 != 0)
					{
					}
					num2 = (short)1672151040;
					if (num2 != 0)
					{
					}
					num2 = (short)918749184;
					short num4 = num2;
					this.Detach(dw);
					dockWindowGroup.Items.Add(dw);
					num2 = (short)1468465153;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
				}
			}
			return false;
			IL_30:
			parentGroup = dw.ParentGroup;
			dockWindowGroup = new global::DevComponents.WpfDock.DockWindowGroup();
			insertIndex = -1;
			num2 = (short)1906966534;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00016954 File Offset: 0x00014B54
		public bool DockWindow(global::DevComponents.WpfDock.DockWindowGroup group, global::DevComponents.WpfDock.eDockSide dockSide)
		{
			short num = (short)463403159;
			short num2 = num;
			num = (short)1482750103;
			switch (num2 == num)
			{
			}
			num = (short)687669249;
			if (num != 0)
			{
			}
			num = (short)677314560;
			short num3 = num;
			num = (short)35520512;
			if (num != 0)
			{
			}
			return this.DockWindow(group, dockSide, global::DevComponents.WpfDock.eEventActionSource.Code, true);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00016A08 File Offset: 0x00014C08
		public bool DockWindow(global::DevComponents.WpfDock.DockWindowGroup group, global::DevComponents.WpfDock.eDockSide dockSide, global::DevComponents.WpfDock.eEventActionSource actionSource, bool raiseEvents)
		{
			short num = (short)1113445549;
			short num2 = num;
			num = (short)1639437485;
			switch (num2 == num)
			{
			}
			num = (short)1583349761;
			if (num != 0)
			{
			}
			num = (short)1504509952;
			short num3 = num;
			num = (short)1681195008;
			if (num != 0)
			{
			}
			return this.DockWindow(group, dockSide, false, actionSource, raiseEvents);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00016AC0 File Offset: 0x00014CC0
		public bool DockWindow(global::DevComponents.WpfDock.DockWindowGroup group, global::DevComponents.WpfDock.DockWindowGroup referenceGroup, global::DevComponents.WpfDock.eDockSide dockSide)
		{
			short num = (short)1853188793;
			short num2 = num;
			num = (short)930114233;
			switch (num2 == num)
			{
			}
			num = (short)1737097217;
			if (num != 0)
			{
			}
			num = (short)2045313024;
			short num3 = num;
			num = (short)1430650880;
			if (num != 0)
			{
			}
			return this.DockWindow(group, referenceGroup, dockSide, global::DevComponents.WpfDock.eEventActionSource.Code, true);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00016B78 File Offset: 0x00014D78
		public bool DockWindow(global::DevComponents.WpfDock.DockWindowGroup group, global::DevComponents.WpfDock.DockWindowGroup referenceGroup, global::DevComponents.WpfDock.eDockSide dockSide, global::DevComponents.WpfDock.eEventActionSource actionSource, bool raiseEvents)
		{
			short num = (short)1706368598;
			short num2 = num;
			num = (short)400498262;
			switch (num2 == num)
			{
			}
			num = (short)1482948608;
			if (num != 0)
			{
			}
			num = (short)706740224;
			short num3 = num;
			num = (short)638386177;
			if (num != 0)
			{
			}
			return this.a(group, referenceGroup, dockSide, actionSource, raiseEvents);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00016C30 File Offset: 0x00014E30
		public bool DockWindow(global::DevComponents.WpfDock.DockWindowGroup group, global::DevComponents.WpfDock.SplitPanel sp, global::DevComponents.WpfDock.eDockSide dockSide)
		{
			short num = (short)350983601;
			short num2 = num;
			num = (short)638883249;
			switch (num2 == num)
			{
			}
			num = (short)1719599105;
			if (num != 0)
			{
			}
			num = (short)1583022080;
			short num3 = num;
			num = (short)1654980608;
			if (num != 0)
			{
			}
			return this.DockWindow(group, sp, dockSide, global::DevComponents.WpfDock.eEventActionSource.Code, true);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00016CE4 File Offset: 0x00014EE4
		public bool DockWindow(global::DevComponents.WpfDock.DockWindowGroup group, global::DevComponents.WpfDock.SplitPanel sp, global::DevComponents.WpfDock.eDockSide dockSide, global::DevComponents.WpfDock.eEventActionSource actionSource, bool raiseEvents)
		{
			short num = (short)1982857217;
			if (num != 0)
			{
			}
			num = (short)1470111147;
			short num2 = num;
			num = (short)1286872491;
			switch (num2 == num)
			{
			}
			num = (short)916258816;
			short num3 = num;
			num = (short)627507200;
			if (num != 0)
			{
			}
			return this.a(group, sp, dockSide, actionSource, raiseEvents);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00016D9C File Offset: 0x00014F9C
		private bool a(global::DevComponents.WpfDock.DockWindowGroup A_0, global::System.Windows.UIElement A_1, global::DevComponents.WpfDock.eDockSide A_2, global::DevComponents.WpfDock.eEventActionSource A_3, bool A_4)
		{
			int a_ = 11;
			short num = (short)72024064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1AC;
				}
				global::DevComponents.WpfDock.SplitPanel splitPanel;
				for (;;)
				{
					IL_31:
					global::DevComponents.WpfDock.SplitPanel splitPanel2;
					bool isFloating;
					int num4;
					int index;
					switch (num2)
					{
					case 0:
						return true;
					case 1:
						goto IL_449;
					case 2:
						goto IL_361;
					case 3:
					{
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
						this.OnAfterDocked(new global::DevComponents.WpfDock.DockRoutedEventArgs(global::DevComponents.WpfDock.DockSite.AfterDockedEvent, this, dockWindowGroup, A_3));
						num = (short)1783300125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_26A;
					case 5:
					{
						int selectedIndex;
						A_0.SelectedIndex = selectedIndex;
						num = (short)1615200338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (A_2 != global::DevComponents.WpfDock.eDockSide.Right)
						{
							num = (short)1991901252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					case 7:
						goto IL_26A;
					case 8:
					{
						if (!(A_1 is global::DevComponents.WpfDock.DockWindowGroup))
						{
							num = (short)1016856600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup = A_1 as global::DevComponents.WpfDock.DockWindowGroup;
						object[] array = new global::System.Windows.UIElement[A_0.Items.Count];
						object[] array2 = array;
						A_0.Items.CopyTo(array2, 0);
						A_0.Items.Clear();
						array = array2;
						int num3 = 0;
						num = (short)1382416391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						this.UpdateIsDocument();
						num = (short)1486159897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_73C;
					case 11:
					{
						global::System.Windows.Media.Animation.DoubleAnimation animation = new global::System.Windows.Media.Animation.DoubleAnimation(0.0, 1.0, new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(350.0)), global::System.Windows.Media.Animation.FillBehavior.Stop);
						A_0.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, animation);
						num = (short)259915856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::System.Windows.Media.Animation.DoubleAnimation animation2 = new global::System.Windows.Media.Animation.DoubleAnimation(0.0, 1.0, new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(350.0)), global::System.Windows.Media.Animation.FillBehavior.Stop);
						A_0.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, animation2);
						num = (short)732233729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_963;
					case 14:
						goto IL_E76;
					case 15:
						if (A_4)
						{
							num = (short)1237450772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 16:
						if (splitPanel.Orientation == global::System.Windows.Controls.Orientation.Vertical)
						{
							num = (short)69599251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						splitPanel2.Orientation = global::System.Windows.Controls.Orientation.Vertical;
						num = (short)1318191173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (A_2 != global::DevComponents.WpfDock.eDockSide.Right)
						{
							num = (short)54394944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_488;
					case 18:
						num = (short)776273921;
						if (num != 0)
						{
						}
						if (isFloating)
						{
							num = (short)1575944214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						splitPanel.Children.Insert(num4, A_0);
						num = (short)795934752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						splitPanel2.Orientation = global::System.Windows.Controls.Orientation.Horizontal;
						num = (short)1629093978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						this.OnAfterDocked(new global::DevComponents.WpfDock.DockRoutedEventArgs(global::DevComponents.WpfDock.DockSite.AfterDockedEvent, this, A_0, A_3));
						num = (short)1253572659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						object[] array;
						int num3;
						if (num3 >= array.Length)
						{
							num = (short)1934622775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object newItem = array[num3];
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
						dockWindowGroup.Items.Add(newItem);
						num3++;
						num = (short)621740036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						object[] array3 = new object[A_0.Items.Count];
						int selectedIndex = A_0.SelectedIndex;
						A_0.Items.CopyTo(array3, 0);
						A_0.Items.Clear();
						splitPanel.Children.Insert(num4, A_0);
						object[] array = array3;
						int num3 = 0;
						num = (short)830603278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_92D;
					case 24:
						goto IL_A5C;
					case 25:
						goto IL_99F;
					case 26:
						goto IL_316;
					case 27:
						num = (short)336461897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_73C;
					case 29:
						return true;
					case 30:
						if (A_2 == global::DevComponents.WpfDock.eDockSide.Bottom)
						{
							num = (short)916389940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6D;
					case 31:
						if (splitPanel.Orientation == global::System.Windows.Controls.Orientation.Vertical)
						{
							num = (short)941162555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6D;
					case 32:
						goto IL_F1A;
					case 33:
						if (splitPanel == null)
						{
							num = (short)647823443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_0.IsFloating = false;
						num = (short)230424668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_361;
					case 35:
						if (this.AnimationEnabled)
						{
							num = (short)1067778059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22B;
					case 36:
						goto IL_566;
					case 37:
						num = (short)1328480301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						object[] array;
						int num3;
						if (num3 >= array.Length)
						{
							num = (short)403243013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object newItem2 = array[num3];
						A_0.Items.Add(newItem2);
						num3++;
						num = (short)511049788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						if (A_2 != global::DevComponents.WpfDock.eDockSide.Top)
						{
							num = (short)1782579271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					case 40:
						goto IL_890;
					case 41:
						return false;
					case 42:
					{
						num = (short)1337014791;
						short num5 = num;
						num = (short)1496398343;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_890;
						default:
						{
							num = (short)1841823744;
							if (num != 0)
							{
							}
							global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs beforeDockedRoutedEventArgs;
							if (beforeDockedRoutedEventArgs.Cancel)
							{
								num = (short)1536557097;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D0F;
						}
						}
						break;
					}
					case 43:
						if (A_1 is global::System.Windows.FrameworkElement)
						{
							num = (short)865140802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_963;
					case 44:
						if (A_1 is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)241827897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73C;
					case 45:
						if (A_2 != global::DevComponents.WpfDock.eDockSide.Left)
						{
							num = (short)155648074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					case 46:
						goto IL_316;
					case 47:
						this.OnAfterDocked(new global::DevComponents.WpfDock.DockRoutedEventArgs(global::DevComponents.WpfDock.DockSite.AfterDockedEvent, this, A_0, A_3));
						num = (short)622592000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (splitPanel.Children.Count == 1)
						{
							num = (short)1546649687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						index = splitPanel.Children.IndexOf(A_1);
						splitPanel2 = null;
						num = (short)895549490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
						dockWindowGroup.Visibility = global::System.Windows.Visibility.Visible;
						dockWindowGroup.h(true);
						num = (short)799277109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
						if (A_1 is global::DevComponents.WpfDock.DockWindowGroup)
						{
							num = (short)529989672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2022506540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						goto IL_3D8;
					case 52:
						goto IL_5E5;
					case 53:
						goto IL_527;
					case 54:
						if (this.AnimationEnabled)
						{
							num = (short)1282867212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_449;
					case 55:
					{
						this.UpdateIsDocument(A_0);
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
						this.UpdateIsDocument(dockWindowGroup);
						num = (short)2053177409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						if (global::DevComponents.WpfDock.DockSite.GetIsDocument(A_0))
						{
							num = (short)783613961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99F;
					case 57:
					{
						num = (short)1541275648;
						short num6 = num;
						this.Detach(A_1 as global::DevComponents.WpfDock.SplitPanel);
						splitPanel2 = this.b(A_1 as global::DevComponents.WpfDock.SplitPanel);
						num = (short)1803550730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 58:
						goto IL_488;
					case 59:
						num = (short)311033895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						goto IL_E76;
					case 61:
						goto IL_99A;
					case 62:
						num = (short)1843069016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (A_2 == global::DevComponents.WpfDock.eDockSide.Bottom)
						{
							num = (short)1936719930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C8;
					case 64:
						num = (short)1442578495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
					{
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
						if (dockWindowGroup.Visibility != global::System.Windows.Visibility.Visible)
						{
							num = (short)1786904625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_527;
					}
					case 66:
						splitPanel = (((global::System.Windows.FrameworkElement)A_1).Parent as global::DevComponents.WpfDock.SplitPanel);
						num = (short)116523021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						splitPanel.Orientation = global::System.Windows.Controls.Orientation.Horizontal;
						num = (short)316145710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_FB7;
					case 69:
						goto IL_C28;
					case 70:
						goto IL_DF3;
					case 71:
						num = (short)1281949726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (A_4)
						{
							num = (short)1889599491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 73:
						if (A_2 == global::DevComponents.WpfDock.eDockSide.Right)
						{
							num = (short)1721630743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_566;
					case 74:
						num = (short)1133051910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						if (A_4)
						{
							num = (short)1906638895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 76:
						if (splitPanel.Orientation == global::System.Windows.Controls.Orientation.Vertical)
						{
							num = (short)1147863107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						splitPanel.Orientation = global::System.Windows.Controls.Orientation.Vertical;
						num = (short)918355994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						num = (short)1174994952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						goto IL_8C8;
					case 79:
						if (A_2 != global::DevComponents.WpfDock.eDockSide.Bottom)
						{
							num = (short)624558142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					case 80:
						goto IL_22B;
					case 81:
						if (A_2 != global::DevComponents.WpfDock.eDockSide.Bottom)
						{
							num = (short)182190107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92D;
					case 82:
						goto IL_F1A;
					case 83:
						goto IL_D68;
					case 84:
						if (splitPanel == null)
						{
							num = (short)1198587965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)134938713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						goto IL_F63;
					case 86:
					{
						global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs beforeDockedRoutedEventArgs = new global::DevComponents.WpfDock.BeforeDockedRoutedEventArgs(global::DevComponents.WpfDock.DockSite.BeforeDockedEvent, this, A_0, A_3, false, A_2, A_1 as global::DevComponents.WpfDock.DockWindowGroup);
						this.OnBeforeDocked(beforeDockedRoutedEventArgs);
						num = (short)51314730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 87:
						num = (short)1275265100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						if (A_2 == global::DevComponents.WpfDock.eDockSide.Right)
						{
							num = (short)1159331925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF3;
					case 89:
						if (A_4)
						{
							num = (short)14286934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D0F;
					case 90:
						goto IL_C28;
					case 91:
						if (splitPanel.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
						{
							num = (short)442040357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FB7;
					case 92:
						if (A_2 == global::DevComponents.WpfDock.eDockSide.Tab)
						{
							num = (short)1420951629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1481048155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AC;
					IL_22B:
					num = (short)625672207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26A:
					num = (short)1564344341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_316:
					num4 = splitPanel.Children.IndexOf(A_1);
					num = (short)1487142991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_361:
					this.UpdateIsDocument(A_0);
					num = (short)1270677560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_449:
					num = (short)182779979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_488:
					num4++;
					num = (short)1891106894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_527:
					num = (short)1762066504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_566:
					splitPanel2.Children.Insert(num4, A_0);
					splitPanel.Children.Insert(index, splitPanel2);
					num = (short)718602242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E5:
					num4 = splitPanel.Children.IndexOf(A_1);
					num = (short)1712128017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_73C:
					num = (short)279904272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_890:
					this.a(A_1 as global::DevComponents.WpfDock.DockWindowGroup, false);
					splitPanel2 = this.CreateSplitPanel(A_1 as global::DevComponents.WpfDock.DockWindowGroup);
					num = (short)1888813084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C8:
					num = (short)2021720082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_92D:
					num4++;
					num = (short)560463908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_963:
					num = (short)1843462228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_99F:
					num = (short)1065484342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C28:
					num4 = splitPanel2.Children.IndexOf(A_1);
					num = (short)248709201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D0F:
					num4 = -1;
					isFloating = A_0.IsFloating;
					this.Detach(A_0);
					splitPanel = (((global::System.Windows.FrameworkElement)A_1).Parent as global::DevComponents.WpfDock.SplitPanel);
					num = (short)861470753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6D:
					num = (short)1408696368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DF3:
					splitPanel.Children.Insert(num4, A_0);
					num = (short)1742798882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E76:
					num = (short)1577451558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F1A:
					this.UpdateIsDocument(A_0);
					num = (short)46530595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F63:
					num4++;
					num = (short)1134821446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FB7:
					num = (short)1876688927;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3D8:
				return true;
				IL_99A:
				throw new global::System.NullReferenceException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("黉꓋ꯍꃑ뇓냕뷗꣙맛냝菟蟡ꇣ諥跧蟩싫뻭釯胱釳飵賷\udaf9闻跽⃿氁欃爅⠇変簋戍礏昑䐓眕瘗缙瀛〝\u001f瘡䰣䌥ࠧ堩䤫䠭唯䀱儳堵嬷弹礻刽┿⽁摃⭅㵇㥉㡋湍㉏㝑瑓㝕㑗⡙㥛㽝џ᭡䑣ɥݧ३ݫ୭ᑯ剱s᥵塷᡹᥻幽ꢇﾋ꺍ﾙﶝ얟", a_));
				IL_A5C:
				throw new global::System.InvalidOperationException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("룉꧋꣍뗏ꃑ뇓룕믗뿙駛닝藟迡쓣迥鯧쫩苫臭蓯틱냳駵鯷釹꯻韽滿昁欃焅伇砉挋笍怏㈑怓漕栗缙㈛㸝漟䰡䠣弥ࠧ温䌫䴭嬯攱崳堵尷唹䬻礽㈿ⵁㅃ㙅桇㹉㕋㹍㕏牑㝓㝕㙗穙㹛㭝䁟ၡţe൧ᡩ५m፯᝱味ၵ᝷ࡹ屻⩽ꒃﺏ", a_));
				IL_D68:
				throw new global::System.NullReferenceException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("黉꓋ꯍꃑ뇓냕뷗꣙맛냝菟蟡ꇣ諥跧蟩싫뻭釯胱釳飵賷\udaf9꿻軽泿欁瀃嘅椇搉椋戍』我甓搕紗琙栛㸝䰟䴡圣別ࠧ丩夫䬭ု䘱嬳ᘵ嬷嘹夻弽⸿㝁㑃", a_));
				IL_1AC:
				splitPanel = null;
				num = (short)1473118251;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00017E60 File Offset: 0x00016060
		internal bool AnimationEnabled
		{
			get
			{
				short num = (short)537067531;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1991770113;
						if (num != 0)
						{
						}
						if (this.IsAnimationEnabled)
						{
							num = (short)852230151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						if (base.IsEnabled)
						{
							num = (short)72351747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
					{
						num = (short)596835740;
						short num3 = num;
						num = (short)1111424412;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
						{
							num = (short)1738997760;
							if (num != 0)
							{
							}
							num = (short)291438592;
							short num4 = num;
							num = (short)920190977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						num = (short)1084620800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1792409610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1002438662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (global::System.Windows.Media.RenderCapability.Tier > 0)
						{
							num = (short)1821179908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						goto IL_D6;
					case 8:
						if (global::System.Windows.SystemParameters.ClientAreaAnimation)
						{
							num = (short)1664286725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						num = (short)2144993288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (!this.IsDesignMode)
						{
							num = (short)1969881090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
						goto IL_14;
					}
					goto IL_54;
					IL_14:
					switch (0)
					{
					case 0:
						IL_54:
						if (global::System.Windows.SystemParameters.PowerLineStatus != global::System.Windows.PowerLineStatus.Online)
						{
							return false;
						}
						num = (short)180551689;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_D6:
				return !this.ab;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000180B8 File Offset: 0x000162B8
		private bool IsDesignMode
		{
			get
			{
				short num = (short)1146355713;
				if (num != 0)
				{
				}
				num = (short)752167735;
				short num2 = num;
				num = (short)1267870519;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1473118208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)742391808;
				if (num != 0)
				{
				}
				return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00018168 File Offset: 0x00016368
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void UpdateIsDocument()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfDock.SplitPanel splitPanel;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)188350464;
					short num3 = num2;
					num2 = (short)628793763;
					short num4 = num2;
					num2 = (short)1030988195;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)261292032;
						if (num2 != 0)
						{
						}
						num2 = (short)1045299201;
						if (num2 != 0)
						{
						}
						this.a(splitPanel, true);
						num2 = (short)421789696;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (splitPanel != null)
					{
						num2 = (short)1662582785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			splitPanel = (base.Content as global::DevComponents.WpfDock.SplitPanel);
			num2 = (short)1592721410;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0001828C File Offset: 0x0001648C
		internal void a(global::DevComponents.WpfDock.SplitPanel A_0, bool A_1)
		{
			global::DevComponents.WpfDock.DockSite.SetIsDocument(A_0, A_1);
			global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator = A_0.Children.GetEnumerator();
			short num;
			try
			{
				num = (short)1259470857;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1982791681;
						if (num != 0)
						{
						}
						global::System.Windows.UIElement uielement;
						this.b(uielement as global::DevComponents.WpfDock.DockWindowGroup, A_1);
						num = (short)1683750919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_1B0;
					case 2:
						num = (short)1577713665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Windows.UIElement uielement;
						if (uielement is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1024000008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						global::System.Windows.UIElement uielement;
						if (uielement is global::DevComponents.WpfDock.DockWindowGroup)
						{
							num = (short)1105723392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1498349571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)69599234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = enumerator.Current;
						global::DevComponents.WpfDock.DockSite.SetIsDocument(uielement, A_1);
						num = (short)1844510724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Windows.UIElement uielement;
						this.a(uielement as global::DevComponents.WpfDock.SplitPanel, A_1);
						num = (short)781910022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					}
					IL_87:
					num = (short)2116419589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62:
					goto IL_87;
				}
				IL_1B0:;
			}
			finally
			{
				num = (short)2028077058;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_268;
					case 1:
					{
						num = (short)1444379527;
						short num3 = num;
						num = (short)1333033863;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26A;
						default:
							num = (short)1943142400;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)163840000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1E5;
						}
						continue;
					}
					IL_1E5:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1021706241;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_268:
				IL_26A:;
			}
			num = (short)1767440384;
			short num4 = num;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0001854C File Offset: 0x0001674C
		private void b(global::DevComponents.WpfDock.DockWindowGroup A_0, bool A_1)
		{
			short num = (short)1031602176;
			short num2 = num;
			num = (short)1377435648;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				global::DevComponents.WpfDock.DockSite.SetIsDocument(A_0, A_1);
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)A_0.Items).GetEnumerator();
				try
				{
					num = (short)924450825;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							object obj;
							global::System.Windows.UIElement uielement = A_0.ItemContainerGenerator.ContainerFromItem(obj) as global::System.Windows.UIElement;
							num = (short)1635713031;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_1D8;
						case 2:
							num = (short)1925447681;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::System.Windows.UIElement uielement;
							if (uielement != null)
							{
								num = (short)1264320520;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							object obj;
							if (!(obj is global::DevComponents.WpfDock.DockWindow))
							{
								num = (short)1993867264;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_186;
						}
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1048641538;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							object obj = enumerator.Current;
							global::System.Windows.UIElement uielement = obj as global::System.Windows.UIElement;
							num = (short)1335951364;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_186;
						case 8:
						{
							global::System.Windows.UIElement uielement;
							global::DevComponents.WpfDock.DockSite.SetIsDocument(uielement, A_1);
							num = (short)91160582;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							switch (0)
							{
							case 0:
								goto IL_AB;
							}
							continue;
						}
						IL_DB:
						num = (short)1937571845;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_AB:
						goto IL_DB;
						IL_186:
						num = (short)1003552771;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1D8:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1FA;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_1E7:
						switch (num3)
						{
						case 0:
							goto IL_29F;
						case 1:
						{
							num = (short)1549600422;
							short num4 = num;
							num = (short)2111506086;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2A1;
							default:
								num = (short)792199168;
								if (num != 0)
								{
								}
								disposable.Dispose();
								num = (short)403636224;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							if (disposable != null)
							{
								num = (short)109117441;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A1;
						}
						goto IL_1FA;
					}
					IL_29F:
					IL_2A1:
					goto EndFinally_7;
					IL_1FA:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)742981634;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_1E7;
					EndFinally_7:;
				}
				num = (short)764739585;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00018840 File Offset: 0x00016A40
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void UpdateIsDocument(global::DevComponents.WpfDock.DockWindowGroup group)
		{
			short num = (short)110882782;
			short num2 = num;
			num = (short)487321566;
			switch (num2 == num)
			{
			}
			num = (short)1163591680;
			short num3 = num;
			num = (short)484507649;
			if (num != 0)
			{
			}
			num = (short)1595932672;
			if (num != 0)
			{
			}
			this.b(group, this.a(group));
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000188F4 File Offset: 0x00016AF4
		private bool a(global::DevComponents.WpfDock.DockWindowGroup A_0)
		{
			short num = (short)431816708;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfDock.SplitPanel splitPanel;
				switch (num2)
				{
				case 0:
					return false;
				case 1:
				{
					num = (short)242990364;
					short num3 = num;
					num = (short)2016853276;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)484311040;
						if (num != 0)
						{
						}
						num = (short)1162215425;
						if (num != 0)
						{
						}
						goto IL_C1;
					}
					break;
				}
				case 2:
					if (splitPanel == null)
					{
						num = (short)278396928;
						short num4 = num;
						num = (short)1365508103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)122880005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return true;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 5:
					if (base.Content == splitPanel)
					{
						num = (short)187957251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					splitPanel = (splitPanel.Parent as global::DevComponents.WpfDock.SplitPanel);
					num = (short)1409155078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_C1;
				case 7:
					return false;
				}
				IL_45:
				if (A_0 == null)
				{
					num = (short)2138832896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				splitPanel = (A_0.Parent as global::DevComponents.WpfDock.SplitPanel);
				num = (short)1238630401;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C1:
				num = (short)2143551490;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00018AC4 File Offset: 0x00016CC4
		public void Detach(global::DevComponents.WpfDock.DockWindowGroup group)
		{
			short num = (short)1655024061;
			short num2 = num;
			num = (short)273131965;
			switch (num2 == num)
			{
			}
			num = (short)1017643008;
			short num3 = num;
			num = (short)634388480;
			if (num != 0)
			{
			}
			num = (short)1141374977;
			if (num != 0)
			{
			}
			this.a(group, true);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00018B78 File Offset: 0x00016D78
		private void a(global::DevComponents.WpfDock.DockWindowGroup A_0, bool A_1)
		{
			short num = (short)1297940480;
			switch (num)
			{
			default:
			{
				num = (short)652214307;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					global::System.Windows.UIElement[] array;
					global::DevComponents.WpfDock.SplitPanel splitPanel;
					int num4;
					global::System.Windows.UIElement[] array2;
					global::DevComponents.WpfDock.SplitPanel splitPanel2;
					int num5;
					int selectedIndex;
					global::DevComponents.WpfDock.SplitPanel splitPanel3;
					switch (num2)
					{
					case 0:
						goto IL_531;
					case 1:
						if (num3 >= array.Length)
						{
							num = (short)1870528538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						splitPanel.Children.Add(array[num3]);
						num3++;
						num = (short)1640431616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (A_0.Parent is global::DevComponents.WpfDock.DockSite)
						{
							num = (short)1948712973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_83A;
					case 3:
						num = (short)1375207438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::DevComponents.WpfDock.FloatingWindow floatingWindow = A_0.Parent as global::DevComponents.WpfDock.FloatingWindow;
						A_0.FloatingRect = new global::System.Windows.Rect(floatingWindow.Left, floatingWindow.Top, floatingWindow.Width, floatingWindow.Height);
						global::System.Windows.Data.BindingOperations.ClearAllBindings(floatingWindow);
						floatingWindow.Content = null;
						floatingWindow.Width = 0.0;
						floatingWindow.Close();
						A_0.IsFloating = false;
						num = (short)834600991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (A_0.Parent is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)22151190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)595460111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (num4 >= array2.Length)
						{
							num = (short)409600028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						splitPanel2.Children.Insert(num5 + num4, array2[num4]);
						num4++;
						num = (short)806682644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)1398538240;
						short num6 = num;
						goto IL_1A4;
					}
					case 8:
						if (splitPanel.Parent is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1021116445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144;
					case 9:
						goto IL_7AC;
					case 10:
						if (splitPanel.Children.Count == 1)
						{
							num = (short)216989733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144;
					case 11:
						if (A_1)
						{
							num = (short)139984899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4;
					case 12:
						goto IL_1A4;
					case 13:
						((global::DevComponents.WpfDock.DockSite)A_0.Parent).Content = null;
						num = (short)725418020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (splitPanel.Children.Count == 1)
						{
							num = (short)379387942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4;
					case 15:
						if (A_0.Parent is global::DevComponents.WpfDock.FloatingWindow)
						{
							num = (short)1291059204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1855586306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_1A4;
					case 17:
						goto IL_531;
					case 18:
						if (splitPanel.VisibleItemsCount == 0)
						{
							num = (short)680525849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)190119957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						num = (short)59605679;
						short num7 = num;
						num = (short)1994031791;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_234;
						default:
							num = (short)1012465664;
							if (num != 0)
							{
							}
							num = (short)478871560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 20:
						goto IL_7AC;
					case 21:
						if (A_1)
						{
							num = (short)1256259603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144;
					case 22:
						selectedIndex = A_0.SelectedIndex;
						A_0.SelectedIndex = -1;
						splitPanel = (A_0.Parent as global::DevComponents.WpfDock.SplitPanel);
						splitPanel.Children.Remove(A_0);
						num = (short)1669726242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_1A4;
					case 24:
						if (((global::DevComponents.WpfDock.SplitPanel)splitPanel.Parent).Orientation != splitPanel.Orientation)
						{
							num = (short)701366302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AA;
					case 25:
						splitPanel.UpdateAutoVisibility();
						num = (short)1748172812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						this.Detach(splitPanel3);
						num = (short)903217159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (splitPanel.Children[0] is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)490274848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4;
					case 28:
						this.Detach(splitPanel);
						num = (short)1112211479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)1693057048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)333840394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_7A7;
					case 32:
						goto IL_234;
					case 33:
						goto IL_1C3;
					case 34:
						if (splitPanel.Children.Count == 0)
						{
							num = (short)936771624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)158531602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						switch (0)
						{
						case 0:
							goto IL_E8;
						}
						continue;
					case 36:
						goto IL_3B9;
					case 37:
						goto IL_5AA;
					case 38:
						num = (short)2123563035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						return;
					case 40:
						this.Detach(splitPanel);
						num = (short)1727987728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E8:
					if (A_0.Parent == null)
					{
						num = (short)536412199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)356974597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_144:
					num = (short)1173946379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A4:
					A_0.SelectedIndex = selectedIndex;
					num = (short)1604517921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_234:
					splitPanel3 = (global::DevComponents.WpfDock.SplitPanel)splitPanel.Children[0];
					array = new global::System.Windows.UIElement[splitPanel3.Children.Count];
					splitPanel3.Children.CopyTo(array, 0);
					splitPanel3.Children.Clear();
					splitPanel.Orientation = splitPanel3.Orientation;
					num3 = 0;
					num = (short)1001586705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_531:
					num = (short)2032599041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5AA:
					splitPanel2 = (splitPanel.Parent as global::DevComponents.WpfDock.SplitPanel);
					num5 = splitPanel2.Children.IndexOf(splitPanel);
					array2 = new global::System.Windows.UIElement[splitPanel.Children.Count];
					splitPanel.Children.CopyTo(array2, 0);
					splitPanel.Children.Clear();
					num4 = 0;
					num = (short)765657097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7AC:
					num = (short)1783562246;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1C3:
				goto IL_83A;
				IL_3B9:
				num = (short)750649345;
				if (num != 0)
				{
				}
				IL_7A7:
				IL_83A:
				this.UpdateIsDocument(A_0);
				return;
			}
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000193C8 File Offset: 0x000175C8
		public void Detach(global::DevComponents.WpfDock.SplitPanel sp)
		{
			short num = (short)2003894279;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfDock.DockSite dockSite;
			global::DevComponents.WpfDock.SplitPanel splitPanel;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					dockSite = (sp.Parent as global::DevComponents.WpfDock.DockSite);
					num = (short)1478885382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (sp.Parent is global::DevComponents.WpfDock.DockSite)
					{
						num = (short)1452998656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1856241672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_146;
				case 3:
					if (sp.Parent is global::DevComponents.WpfDock.SplitPanel)
					{
						num = (short)2076377092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)909312001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					splitPanel = (sp.Parent as global::DevComponents.WpfDock.SplitPanel);
					splitPanel.Children.Remove(sp);
					num = (short)954073097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_EF;
				case 6:
					if (dockSite.Content == sp)
					{
						num = (short)1097400322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F4;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 8:
					if (sp.Parent is global::DevComponents.WpfDock.FloatingWindow)
					{
						num = (short)1110179852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					if (splitPanel.Children.Count == 0)
					{
						num = (short)575733770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					goto IL_293;
				case 11:
					goto IL_232;
				case 12:
				{
					global::DevComponents.WpfDock.FloatingWindow floatingWindow = sp.Parent as global::DevComponents.WpfDock.FloatingWindow;
					floatingWindow.Content = null;
					floatingWindow.Close();
					num = (short)2144600075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_5A:
				num = (short)954995882;
				short num3 = num;
				num = (short)1526928554;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_293;
				default:
				{
					num = (short)1383202816;
					if (num != 0)
					{
					}
					num = (short)512557056;
					short num4 = num;
					if (sp.Parent == null)
					{
						num = (short)10616837;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)882311171;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_EF:
			num = (short)359333889;
			if (num != 0)
			{
			}
			return;
			IL_F4:
			dockSite.SplitPanels.Remove(sp);
			return;
			IL_146:
			dockSite.Content = null;
			return;
			IL_232:
			return;
			IL_293:
			this.Detach(splitPanel);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000196B0 File Offset: 0x000178B0
		public void Detach(global::DevComponents.WpfDock.DockWindow dw)
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			short num;
			int num2;
			global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
			for (;;)
			{
				IL_0A:
				num = (short)1918566401;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return;
				case 1:
					this.Detach(dockWindowGroup);
					num = (short)1418657798;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (dockWindowGroup == null)
					{
						num = (short)364249088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)366804997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (dockWindowGroup.Items.Count == 0)
					{
						num = (short)1638465537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E4;
				case 4:
				{
					this.c(dockWindowGroup);
					num = (short)1051918336;
					short num3 = num;
					num = (short)1829568519;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_1BC;
				case 6:
				{
					num = (short)1420137808;
					short num4 = num;
					num = (short)2081396048;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1BC;
					default:
						goto IL_18D;
					}
					break;
				}
				case 7:
					goto IL_9B;
				}
				goto IL_58;
				IL_9B:
				dockWindowGroup.Items.Remove(dw);
				num = (short)678232067;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BC:
				if (dockWindowGroup.SelectedItem != dw)
				{
					goto IL_9B;
				}
				num = (short)614465540;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_18D:
			num = (short)1318256640;
			if (num != 0)
			{
			}
			IL_1E4:
			global::DevComponents.WpfDock.DockSite.SetIsDocument(dw, false);
			return;
			IL_58:
			dockWindowGroup = (dw.Parent as global::DevComponents.WpfDock.DockWindowGroup);
			num = (short)1070727170;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000198A8 File Offset: 0x00017AA8
		internal static global::DevComponents.WpfDock.eDockSide b(global::System.Windows.Controls.Dock A_0)
		{
			short num = (short)354615296;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 1:
					return global::DevComponents.WpfDock.eDockSide.Bottom;
				case 2:
					if (A_0 == global::System.Windows.Controls.Dock.Right)
					{
						num = (short)332595201;
						if (num != 0)
						{
						}
						num = (short)1831534597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::DevComponents.WpfDock.eDockSide.Top;
				case 3:
					if (A_0 == global::System.Windows.Controls.Dock.Left)
					{
						num = (short)843186176;
						short num3 = num;
						num = (short)206045188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1338376194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_116;
				case 5:
					return global::DevComponents.WpfDock.eDockSide.Right;
				}
				IL_3D:
				if (A_0 == global::System.Windows.Controls.Dock.Bottom)
				{
					num = (short)1259274241;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1595998211;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return global::DevComponents.WpfDock.eDockSide.Bottom;
			IL_116:
			num = (short)1982103286;
			short num4 = num;
			num = (short)129531638;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return global::DevComponents.WpfDock.eDockSide.Bottom;
			default:
				num = (short)526778368;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfDock.eDockSide.Left;
			}
			return global::DevComponents.WpfDock.eDockSide.Top;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00019A1C File Offset: 0x00017C1C
		private static global::System.Windows.Controls.Dock a(global::DevComponents.WpfDock.eDockSide A_0)
		{
			int a_ = 1;
			short num = (short)274006018;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return global::System.Windows.Controls.Dock.Bottom;
				case 1:
					return global::System.Windows.Controls.Dock.Right;
				case 2:
					goto IL_1D;
				case 3:
				{
					if (A_0 == global::DevComponents.WpfDock.eDockSide.Right)
					{
						num = (short)1396637697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)941034928;
					short num3 = num;
					num = (short)1823083952;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)2096431104;
						if (num != 0)
						{
						}
						num = (short)348389381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					return global::System.Windows.Controls.Dock.Top;
				case 5:
					if (A_0 == global::DevComponents.WpfDock.eDockSide.Top)
					{
						num = (short)561381380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AB;
				case 6:
					return global::System.Windows.Controls.Dock.Left;
				case 7:
					if (A_0 == global::DevComponents.WpfDock.eDockSide.Left)
					{
						num = (short)626327558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)832176131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_9F;
				IL_1D:
				num = (short)1402929153;
				if (num != 0)
				{
				}
				num = (short)477495296;
				short num4 = num;
				switch (0)
				{
				case 0:
					IL_9F:
					if (A_0 == global::DevComponents.WpfDock.eDockSide.Bottom)
					{
						num = (short)76546048;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)956235783;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			return global::System.Windows.Controls.Dock.Bottom;
			IL_1AB:
			throw new global::System.InvalidCastException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("莿ꏁ꫃ꣅꟇ뻉귍뿏병ꋓ돕꫗껙ﳛ뫝迟臡迣뗥臧軩觫컭蓯鷱퓳답韷駹韻탽⃿䘁欃攅指変攋樍甏㈑簓眕欗㨙紛瀝\u001f䬡䨣倥䤧䘩䔫䨭ု䐱唳娵䴷弹", a_));
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00019BE8 File Offset: 0x00017DE8
		public global::DevComponents.WpfDock.AutoHidePanel GetAutoHidePanel(global::System.Windows.Controls.Dock d)
		{
			short num = (short)2022703118;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.n = this.a(d);
					num = (short)782696452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.q = this.a(d);
					num = (short)1892810769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)2111495579;
					short num3 = num;
					num = (short)919002523;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)1084751872;
						if (num != 0)
						{
						}
						num = (short)48037906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (d == global::System.Windows.Controls.Dock.Bottom)
					{
						num = (short)1221591042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)358219785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1C0;
				case 5:
					num = (short)2046754832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.p = this.a(d);
					num = (short)1002569736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_279;
				case 8:
					goto IL_197;
				case 9:
					if (d == global::System.Windows.Controls.Dock.Left)
					{
						num = (short)1816789007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1745223699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1565786112;
					short num4 = num;
					if (this.o == null)
					{
						num = (short)1283325965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C5;
				}
				case 11:
					num = (short)1388380170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (this.n == null)
					{
						num = (short)124125184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96;
				case 13:
					num = (short)1263140865;
					if (num != 0)
					{
					}
					this.o = this.a(d);
					num = (short)907935751;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_15;
				case 15:
					num = (short)1750728716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (this.p == null)
					{
						num = (short)1574699014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DA;
				case 17:
					goto IL_359;
				case 18:
					if (this.q == null)
					{
						num = (short)2083651585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CC;
				case 19:
					if (d == global::System.Windows.Controls.Dock.Right)
					{
						num = (short)237764619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_399;
				}
				goto IL_75;
				IL_15:
				switch (0)
				{
				case 0:
					IL_75:
					if (d == global::System.Windows.Controls.Dock.Top)
					{
						num = (short)945225733;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1656684547;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_96:
			return this.n;
			IL_DA:
			return this.p;
			IL_197:
			goto IL_DA;
			IL_1C0:
			goto IL_96;
			IL_1C5:
			return this.o;
			IL_1CC:
			return this.q;
			IL_279:
			goto IL_1C5;
			IL_359:
			goto IL_1CC;
			IL_399:
			return null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00019F90 File Offset: 0x00018190
		private global::DevComponents.WpfDock.AutoHidePanel a(global::System.Windows.Controls.Dock A_0)
		{
			short num = (short)1882980352;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num3;
			global::DevComponents.WpfDock.AutoHidePanel autoHidePanel;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					goto IL_C9;
				case 1:
					goto IL_AB;
				case 2:
					num = (short)2105016321;
					if (num != 0)
					{
					}
					if (A_0 == global::System.Windows.Controls.Dock.Right)
					{
						num = (short)381681665;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					autoHidePanel.TabOrientation = global::System.Windows.Controls.Orientation.Horizontal;
					num = (short)1006174213;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1815655012;
					short num4 = num;
					num = (short)1959768676;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B2;
					default:
						num = (short)923926528;
						if (num != 0)
						{
						}
						num = (short)1126694914;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (A_0 != global::System.Windows.Controls.Dock.Left)
					{
						num = (short)1909653507;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB;
				case 5:
					goto IL_A6;
				}
				goto IL_50;
				IL_B2:
				num = (short)1832321024;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_AB:
				autoHidePanel.TabOrientation = global::System.Windows.Controls.Orientation.Vertical;
				goto IL_B2;
			}
			IL_A6:
			IL_C9:
			this.d.Add(autoHidePanel);
			base.InvalidateMeasure();
			return autoHidePanel;
			IL_50:
			autoHidePanel = new global::DevComponents.WpfDock.AutoHidePanel();
			global::DevComponents.WpfDock.DockSite.SetDock(autoHidePanel, A_0);
			num = (short)825425924;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0001A12C File Offset: 0x0001832C
		internal void a(global::DevComponents.WpfDock.DockWindow A_0, bool A_1, global::DevComponents.WpfDock.eEventActionSource A_2)
		{
			short num = (short)44858919;
			short num2 = num;
			num = (short)1885634087;
			switch (num2 == num)
			{
			}
			num = (short)2120941569;
			if (num != 0)
			{
			}
			num = (short)1262551040;
			if (num != 0)
			{
			}
			num = (short)2017591296;
			short num3 = num;
			this.a(A_0, A_1, A_2, true);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0001A1E0 File Offset: 0x000183E0
		internal void a(global::DevComponents.WpfDock.DockWindow A_0, bool A_1, global::DevComponents.WpfDock.eEventActionSource A_2, bool A_3)
		{
			short num = (short)393623420;
			short num2 = num;
			num = (short)8468348;
			switch (num2 == num)
			{
			}
			num = (short)2032467969;
			if (num != 0)
			{
			}
			num = (short)1180106752;
			if (num != 0)
			{
			}
			num = (short)182845440;
			short num3 = num;
			this.a(A_0, A_1, A_2, A_3, this.GetDockFromDockWindow(A_0));
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0001A29C File Offset: 0x0001849C
		internal void a(global::DevComponents.WpfDock.DockWindow A_0, bool A_1, global::DevComponents.WpfDock.eEventActionSource A_2, bool A_3, global::System.Windows.Controls.Dock A_4)
		{
			short num = (short)502071296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_153;
				}
				double value;
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation;
				global::System.Windows.Media.Animation.Storyboard storyboard;
				global::DevComponents.WpfDock.AutoHidePanel autoHidePanel;
				global::DevComponents.WpfDock.Primitives.g g;
				bool flag;
				for (;;)
				{
					IL_28:
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
					global::System.Windows.Rect rect2;
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2;
					int num5;
					int num4;
					bool doc;
					bool flag2;
					switch (num2)
					{
					case 0:
						if (dockWindowGroup != null)
						{
							num = (short)1362559011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DD;
					case 1:
						goto IL_EF6;
					case 2:
						try
						{
							num = (short)261947396;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)464977923;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.DockWindow dockWindow = enumerator.Current as global::DevComponents.WpfDock.DockWindow;
									num = (short)711786497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									if (dockWindow != null)
									{
										num = (short)493158406;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_AC7;
								}
								case 2:
									num = (short)1559494663;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)225640458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_974;
									}
									continue;
								case 5:
									goto IL_9F2;
								case 6:
									num = (short)867106824;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									if (dockWindow.LastDockWindowGroup != null)
									{
										goto IL_A62;
									}
									goto IL_AC7;
								}
								case 8:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									if (dockWindow.LastDockWindowGroupId == A_0.LastDockWindowGroupId)
									{
										num = (short)276561922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_AC7;
								}
								case 9:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									A_0.LastDockWindowGroup = dockWindow.LastDockWindowGroup;
									dockWindow.LastDockWindowGroup = null;
									num = (short)398655493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_B1C;
								}
								goto IL_974;
								IL_A62:
								num = (short)547880969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_974:
								num = (short)717983804;
								short num3 = num;
								num = (short)288133180;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_A62;
								default:
									num = (short)377880576;
									if (num != 0)
									{
									}
									break;
								}
								IL_AC7:
								num = (short)1013252096;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_9F2:
							IL_B1C:
							goto IL_25F;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_B3E;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_B2B:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)139067393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_B96;
								case 2:
									if (disposable != null)
									{
										num = (short)926941184;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B98;
								}
								goto IL_B3E;
							}
							IL_B96:
							IL_B98:
							goto EndFinally_33;
							IL_B3E:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)200540162;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_B2B;
							EndFinally_33:;
						}
						goto IL_B99;
					case 3:
					{
						global::DevComponents.WpfDock.DockWindow dockWindow2;
						if (dockWindow2.LastDockWindowGroupId == A_0.LastDockWindowGroupId)
						{
							num = (short)367919115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A4;
					}
					case 4:
					{
						global::System.Windows.Rect rect;
						if (!global::DevComponents.WpfDock.i.b(rect.Top, rect2.Top))
						{
							num = (short)467337268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F4;
					}
					case 5:
					{
						global::System.Windows.Rect rect;
						doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(rect.Left, new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(value)));
						global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(global::DevComponents.WpfDock.Primitives.a.c));
						storyboard.Children.Add(doubleAnimation);
						num = (short)328400945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						base.Focus();
						num = (short)1967915032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_2A0;
					case 8:
						if (A_0.LastDockWindowGroup != null)
						{
							num = (short)1550843971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dockWindowGroup2 = (this.a(A_0.LastDockWindowGroupId) as global::DevComponents.WpfDock.DockWindowGroup);
						num = (short)1522401334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)autoHidePanel.Items).GetEnumerator();
						num = (short)613613570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						g.a(dockWindowGroup.InnerContent);
						num = (short)143785991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num4 = num5;
						doc = false;
						num = (short)242942000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_B99;
					case 13:
					{
						global::System.Windows.Rect rect;
						doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(rect.Bottom, new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(value)));
						global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(global::DevComponents.WpfDock.Primitives.a.d));
						storyboard.Children.Add(doubleAnimation);
						num = (short)362938432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (A_0.LastDockWindowGroup == null)
						{
							num = (short)1565720620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25F;
					case 15:
						goto IL_8DA;
					case 16:
						if (num4 != 0)
						{
							num = (short)11862048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)432078903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						this.d(dockWindowGroup);
						this.Detach(dockWindowGroup);
						A_0.LastDockWindowGroup = dockWindowGroup;
						num = (short)721289250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_42B;
					case 19:
						goto IL_5DD;
					case 20:
						num = (short)1767637042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						dockWindowGroup2.Items.Add(A_0);
						num = (short)1882914858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)2132213819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						dockWindowGroup.UpdateVisibility();
						num = (short)591659027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_FC9;
					case 25:
						if (dockWindowGroup.SelectedItem == A_0)
						{
							num = (short)1511784510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52F;
					case 26:
						goto IL_8DA;
					case 27:
					{
						num = (short)196542464;
						short num6 = num;
						goto IL_DC4;
					}
					case 28:
						if (g != null)
						{
							num = (short)924254271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 29:
						if (dockWindowGroup != null && flag)
						{
							num = (short)2061107237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A0;
					case 30:
						num = (short)931528732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (dockWindowGroup.VisibleItemsCount == 0)
						{
							num = (short)1573519383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DD;
					case 32:
						num = (short)1216282680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (flag)
						{
							num = (short)456654878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 34:
						goto IL_5DD;
					case 35:
						A_0.LastDockWindowGroupId = dockWindowGroup.Id;
						A_0.LastDockedSize = dockWindowGroup.RenderSize;
						num = (short)281346073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						global::DevComponents.WpfDock.DockSite.SetDock(A_0, A_4);
						dockWindowGroup = (A_0.Parent as global::DevComponents.WpfDock.DockWindowGroup);
						A_0.LastDock = A_4;
						rect2 = default(global::System.Windows.Rect);
						g = null;
						num = (short)564854813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)902430773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_2A0;
					case 39:
						if (dockWindowGroup.Items.Count == 0)
						{
							num = (short)1851588625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2042888223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						global::System.Windows.Rect rect;
						if (!global::DevComponents.WpfDock.i.b(rect.Right, rect2.Right))
						{
							num = (short)1625948165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FCE;
					}
					case 41:
						if (A_1)
						{
							num = (short)460455972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)761069615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_CCA;
					case 43:
						goto IL_704;
					case 44:
						num = (short)656146503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						global::System.Windows.Rect rect;
						if (!global::DevComponents.WpfDock.i.b(rect.Bottom, rect2.Bottom))
						{
							num = (short)698155021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34B;
					}
					case 46:
					{
						global::System.Windows.Rect rect;
						if (!global::DevComponents.WpfDock.i.b(rect.Left, rect2.Left))
						{
							num = (short)1094910003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_704;
					}
					case 47:
						if (A_0.AutoHideOpen)
						{
							num = (short)639828025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF6;
					case 48:
						goto IL_B99;
					case 49:
						goto IL_10CB;
					case 50:
						if (dockWindowGroup.SelectedContent is global::System.Windows.UIElement)
						{
							num = (short)973209627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A0;
					case 51:
					{
						global::System.Windows.Rect rect;
						doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(rect.Left, new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(value)));
						global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(global::DevComponents.WpfDock.Primitives.a.a));
						storyboard.Children.Add(doubleAnimation);
						num = (short)1920335915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
					{
						global::System.Windows.Rect rect;
						doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(rect.Top, new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(value)));
						global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(global::DevComponents.WpfDock.Primitives.a.b));
						storyboard.Children.Add(doubleAnimation);
						num = (short)1812529222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						if (dockWindowGroup.InnerContent == null)
						{
							num = (short)875823124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC4;
					case 54:
						if (dockWindowGroup2 != null)
						{
							num = (short)581566486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BEB;
					case 55:
						flag2 = false;
						goto IL_793;
					case 56:
						flag2 = true;
						goto IL_793;
					case 57:
						this.ab = true;
						A_0.AutoHideOpen = false;
						this.ab = false;
						num = (short)819003393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						num = (short)666763267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						if (this.f(dockWindowGroup2) == A_4)
						{
							num = (short)430243861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BEB;
					case 60:
						if (dockWindowGroup.InnerContent != null)
						{
							num = (short)2003828746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						g.a(dockWindowGroup.SelectedContent as global::System.Windows.UIElement);
						num = (short)143196198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						goto IL_42B;
					case 62:
						this.c(dockWindowGroup);
						num = (short)1774125125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
					{
						base.UpdateLayout();
						new global::System.Windows.Media.VisualBrush(A_0.Content as global::System.Windows.Media.Visual);
						this.d().b().Add(g);
						global::DevComponents.WpfDock.Primitives.a.d(g, rect2.Left);
						global::DevComponents.WpfDock.Primitives.a.e(g, rect2.Top);
						global::DevComponents.WpfDock.Primitives.a.c(g, rect2.Right);
						global::DevComponents.WpfDock.Primitives.a.b(g, rect2.Bottom);
						global::System.Windows.Rect rect = global::DevComponents.WpfDock.i.a(A_0, this);
						double accelerationRatio = 0.3;
						value = 300.0;
						storyboard = new global::System.Windows.Media.Animation.Storyboard();
						storyboard.AccelerationRatio = accelerationRatio;
						num = (short)647102468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						goto IL_34B;
					case 65:
						goto IL_CCA;
					case 66:
						if (!A_0.FocusContent())
						{
							num = (short)1663303681;
							if (num != 0)
							{
							}
							num = (short)1854996486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 67:
					{
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup3 = A_0.LastDockWindowGroup;
						dockWindowGroup3.Items.Add(A_0);
						dockWindowGroup3.UpdateVisibility();
						this.RestoreLastDockPosition(dockWindowGroup3);
						dockWindowGroup3.SelectedItem = A_0;
						A_0.PreviousGroup = dockWindowGroup3;
						num = (short)1550385170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 68:
					{
						if (num5 >= autoHidePanel.Items.Count)
						{
							num = (short)395247628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfDock.DockWindow dockWindow2 = autoHidePanel.Items[num5] as global::DevComponents.WpfDock.DockWindow;
						num = (short)730660936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 69:
						goto IL_52F;
					case 70:
						goto IL_7F4;
					case 71:
						if (this.a(A_0.LastDockWindowGroupId) == null)
						{
							num = (short)876347401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25F;
					case 72:
					{
						global::DevComponents.WpfDock.DockWindow dockWindow2;
						if (dockWindow2 != null)
						{
							num = (short)1775501370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A4;
					}
					}
					goto IL_153;
					IL_25F:
					num = (short)1735000072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A0:
					num = (short)795082752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34B:
					num = (short)749797422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42B:
					A_0.LastDockWindowGroup = null;
					A_0.LastDockWindowGroupId = "";
					num = (short)1333395522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A4:
					num5++;
					num = (short)1205796879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_52F:
					dockWindowGroup.Items.Remove(A_0);
					num = (short)1167458343;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5DD:
					num4 = autoHidePanel.Items.Count;
					num = (short)827981840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_704:
					num = (short)586678312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_793:
					doc = flag2;
					num5 = 0;
					num = (short)1054670874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F4:
					num = (short)1111818285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8DA:
					num = (short)2119237700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B99:
					global::DevComponents.WpfDock.AutoHidePanel.SetIsBeginGroup(A_0, doc);
					autoHidePanel.Items.Insert(num4, A_0);
					num = (short)650182689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BEB:
					dockWindowGroup2 = new global::DevComponents.WpfDock.DockWindowGroup();
					dockWindowGroup2.Items.Add(A_0);
					this.DockWindow(dockWindowGroup2, global::DevComponents.WpfDock.DockSite.b(A_4), false, A_2, true);
					num = (short)334757953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CCA:
					dockWindowGroup2.SelectedItem = A_0;
					dockWindowGroup2.UpdateVisibility();
					A_0.PreviousGroup = dockWindowGroup2;
					num = (short)740229181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DC4:
					rect2 = global::DevComponents.WpfDock.i.a(dockWindowGroup, this);
					g = new global::DevComponents.WpfDock.Primitives.g();
					num = (short)834928700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EF6:
					autoHidePanel.Items.Remove(A_0);
					A_0.LastAutoHideSize = default(global::System.Windows.Size);
					num = (short)508035086;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FC9:
				return;
				IL_FCE:
				doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(0.0, new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(value)));
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(global::System.Windows.UIElement.OpacityProperty));
				storyboard.Children.Add(doubleAnimation);
				storyboard.Completed += g.a;
				storyboard.Begin(g);
				return;
				IL_10CB:
				goto IL_FCE;
				IL_153:
				autoHidePanel = this.GetAutoHidePanel(A_4);
				flag = (this.AnimationEnabled && A_3);
				num = (short)1627848745;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0001B3D4 File Offset: 0x000195D4
		public global::System.Windows.Controls.Dock GetDockFromDockWindow(global::DevComponents.WpfDock.DockWindow dw)
		{
			short num = (short)1539112963;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.FrameworkElement frameworkElement;
			for (;;)
			{
				num = (short)1256074333;
				short num3 = num;
				num = (short)1780165725;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1893138432;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_159;
					case 1:
						goto IL_159;
					case 2:
						goto IL_11A;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_8E;
						}
						continue;
					case 4:
						goto IL_B0;
					case 5:
						goto IL_13E;
					case 6:
						return global::System.Windows.Controls.Dock.Left;
					case 7:
						if (frameworkElement == null)
						{
							num = (short)1861156870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1116733442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8E:
					if (dw.IsFloating)
					{
						num = (short)776929284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2024275968;
					short num4 = num;
					frameworkElement = dw;
					num = (short)704512000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_159:
					num = (short)28508167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_11A:
				if (frameworkElement.Parent is global::DevComponents.WpfDock.DockSite)
				{
					num = (short)925106181;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					frameworkElement = (frameworkElement.Parent as global::System.Windows.FrameworkElement);
					num = (short)2057306113;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_B0:
			num = (short)132644865;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfDock.DockSite.a(((global::DevComponents.WpfDock.DockWindowGroup)dw.Parent).LastDockSide);
			IL_13E:
			return global::DevComponents.WpfDock.DockSite.GetDock(frameworkElement);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0001B5BC File Offset: 0x000197BC
		internal global::System.Windows.Controls.Dock f(global::DevComponents.WpfDock.DockWindowGroup A_0)
		{
			global::System.Windows.FrameworkElement frameworkElement;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return global::System.Windows.Controls.Dock.Left;
					case 1:
						goto IL_121;
					case 2:
					{
						num2 = (short)1525743617;
						if (num2 != 0)
						{
						}
						num2 = (short)1950202420;
						short num3 = num2;
						num2 = (short)1815132724;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1527971840;
							if (num2 != 0)
							{
							}
							goto IL_121;
						}
						break;
					}
					case 3:
						if (frameworkElement.Parent is global::DevComponents.WpfDock.DockSite)
						{
							num2 = (short)1073283077;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						frameworkElement = (frameworkElement.Parent as global::System.Windows.FrameworkElement);
						num2 = (short)1937637378;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (frameworkElement == null)
						{
							num2 = (short)620101632;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)54132739;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_11F;
					}
					break;
					IL_121:
					num2 = (short)1669595136;
					short num4 = num2;
					num2 = (short)1211432964;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_28:
				frameworkElement = A_0;
				num2 = (short)241172481;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_11F:
			return global::DevComponents.WpfDock.DockSite.GetDock(frameworkElement);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001B74C File Offset: 0x0001994C
		private void h(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)88014848;
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
					num = (short)1176829953;
					if (num != 0)
					{
					}
					num = (short)1229783040;
					short num3 = num;
					goto IL_D9;
				}
				case 2:
				{
					global::DevComponents.WpfDock.DockWindow dockWindow = A_1.Source as global::DevComponents.WpfDock.DockWindow;
					dockWindow.IsAutoHide = !dockWindow.IsAutoHide;
					goto IL_71;
				}
				}
				IL_30:
				if (A_1.Source is global::DevComponents.WpfDock.DockWindow)
				{
					num = (short)185335810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_D9;
				IL_71:
				num = (short)136511489;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D9:
				num = (short)777380081;
				short num4 = num;
				num = (short)1083498737;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_71;
				default:
					goto IL_10E;
				}
			}
			IL_10E:
			num = (short)225640448;
			if (num != 0)
			{
			}
			A_1.Handled = true;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0001B884 File Offset: 0x00019A84
		private void h(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_86;
				case 1:
					if (dockWindow != null)
					{
						num2 = (short)1202585600;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_1.CanExecute = false;
					num2 = (short)189661187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					A_1.CanExecute = (!dockWindow.IsFloating && (!this.GetIsDocumentElement(dockWindow) || dockWindow.IsAutoHide));
					num2 = (short)461373444;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_175;
				case 4:
				{
					num2 = (short)1706851502;
					short num3 = num2;
					num2 = (short)1643478190;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					default:
						goto IL_115;
					}
					break;
				}
				}
				goto IL_24;
				IL_86:
				num2 = (short)1794048002;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_115:
			num2 = (short)1651507200;
			if (num2 != 0)
			{
			}
			num2 = (short)1604845568;
			short num4 = num2;
			IL_175:
			A_1.Handled = true;
			A_1.ContinueRouting = false;
			return;
			IL_24:
			num2 = (short)1758068737;
			if (num2 != 0)
			{
			}
			dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
			num2 = (short)1336672257;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0001BA18 File Offset: 0x00019C18
		private void g(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)773914626;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfDock.DockWindow dockWindow;
				switch (num2)
				{
				case 0:
					num = (short)1721696257;
					if (num != 0)
					{
					}
					dockWindow.AutoHideOpen = true;
					num = (short)1366294532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_114;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
				{
					num = (short)608503587;
					short num3 = num;
					num = (short)769787683;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_114;
					default:
						num = (short)1817903104;
						if (num != 0)
						{
						}
						dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
						num = (short)1746010113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_C7;
				}
				IL_38:
				if (A_1.Source is global::DevComponents.WpfDock.DockWindow)
				{
					num = (short)356974595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_15F;
				IL_114:
				if (dockWindow.AutoHideOpen)
				{
					goto IL_15F;
				}
				num = (short)1080492032;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C7:
			num = (short)1281884160;
			short num4 = num;
			IL_15F:
			A_1.Handled = true;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0001BB8C File Offset: 0x00019D8C
		private void g(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_185;
				case 1:
					goto IL_163;
				case 2:
					if (dockWindow != null)
					{
						num2 = (short)705630939;
						short num3 = num2;
						num2 = (short)722932443;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)833486848;
							if (num2 != 0)
							{
							}
							num2 = (short)1968766977;
							if (num2 != 0)
							{
							}
							num2 = (short)1059061763;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
					}
					A_1.CanExecute = false;
					num2 = (short)787283968;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)1780023296;
					short num4 = num2;
					num2 = (short)1517355012;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					A_1.CanExecute = (!dockWindow.IsFloating && (!this.GetIsDocumentElement(dockWindow) || dockWindow.IsAutoHide) && !dockWindow.AutoHideOpen);
					num2 = (short)104595457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_163:
			IL_185:
			A_1.Handled = true;
			A_1.ContinueRouting = false;
			return;
			IL_24:
			dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
			num2 = (short)738197506;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0001BD30 File Offset: 0x00019F30
		private void f(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)495321090;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfDock.DockWindow dockWindow;
				switch (num2)
				{
				case 0:
				{
					dockWindow.AutoHideOpen = false;
					num = (short)2055405568;
					short num3 = num;
					num = (short)602734596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_140;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
				{
					num = (short)1063607023;
					short num4 = num;
					num = (short)1552964335;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_140;
					default:
						num = (short)1105002496;
						if (num != 0)
						{
						}
						dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
						num = (short)1127546881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_11A;
				}
				IL_38:
				if (A_1.Source is global::DevComponents.WpfDock.DockWindow)
				{
					num = (short)1879244801;
					if (num != 0)
					{
					}
					num = (short)1034878979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_140:
				if (!dockWindow.AutoHideOpen)
				{
					break;
				}
				num = (short)390201344;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11A:
			A_1.Handled = true;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0001BEAC File Offset: 0x0001A0AC
		private void f(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num2;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			for (;;)
			{
				IL_0A:
				num = (short)2119172097;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_17E;
				case 1:
					goto IL_15E;
				case 2:
					if (dockWindow != null)
					{
						num = (short)1923426115;
						short num3 = num;
						num = (short)831465283;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)419758080;
							if (num != 0)
							{
							}
							num = (short)684720131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
					}
					A_1.CanExecute = false;
					num = (short)1643249664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)482476032;
					short num4 = num;
					num = (short)1308229636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					A_1.CanExecute = (!dockWindow.IsFloating && (!this.GetIsDocumentElement(dockWindow) || dockWindow.IsAutoHide) && dockWindow.AutoHideOpen);
					num = (short)1974665217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
			}
			IL_15E:
			IL_17E:
			A_1.Handled = true;
			A_1.ContinueRouting = false;
			return;
			IL_4D:
			dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
			num = (short)1743519746;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0001C048 File Offset: 0x0001A248
		private void e(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)87162883;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
					if (dockWindowGroup.SelectedDockWindow != null)
					{
						num = (short)1984036872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_274;
				}
				case 1:
					goto IL_1E1;
				case 2:
				{
					global::DevComponents.WpfDock.DockWindow dockWindow;
					dockWindow.Close();
					num = (short)948895749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 4:
				{
					num = (short)1539172767;
					short num3 = num;
					num = (short)1610475935;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C9;
					case 1:
						break;
					default:
					{
						num = (short)1039400960;
						short num4 = num;
						break;
					}
					}
					num = (short)1559887872;
					if (num != 0)
					{
					}
					if (A_1.Source is global::DevComponents.WpfDock.DockWindowGroup)
					{
						num = (short)1223884811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_274;
				}
				case 5:
					goto IL_204;
				case 6:
				{
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
					if (dockWindowGroup.SelectedDockWindow.CanClose)
					{
						num = (short)724697098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_274;
				}
				case 7:
				{
					global::DevComponents.WpfDock.DockWindow dockWindow;
					if (dockWindow.CanClose)
					{
						num = (short)87687170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_274;
				}
				case 8:
					num = (short)1425735681;
					if (num != 0)
					{
					}
					num = (short)693764102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					global::DevComponents.WpfDock.DockWindow dockWindow = A_1.Source as global::DevComponents.WpfDock.DockWindow;
					num = (short)390856711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
				{
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
					dockWindowGroup.SelectedDockWindow.Close();
					goto IL_1C9;
				}
				case 11:
				{
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup = (global::DevComponents.WpfDock.DockWindowGroup)A_1.Source;
					num = (short)29556736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_54:
				if (A_1.Source is global::DevComponents.WpfDock.DockWindow)
				{
					num = (short)387645449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1360920580;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C9:
				num = (short)1776943105;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1E1:
			IL_204:
			IL_274:
			A_1.Handled = true;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
		private void e(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_197;
				case 1:
				{
					num2 = (short)1638137856;
					short num3 = num2;
					A_1.CanExecute = dockWindowGroup.CanClose;
					num2 = (short)1105526785;
					if (num2 != 0)
					{
					}
					num2 = (short)1213661187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_1B8;
				case 3:
					goto IL_10E;
				case 4:
				{
					num2 = (short)1916141550;
					short num4 = num2;
					num2 = (short)903151598;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_197;
					default:
						num2 = (short)1520566272;
						if (num2 != 0)
						{
						}
						if (dockWindow != null)
						{
							num2 = (short)1760493573;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)402259974;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					A_1.CanExecute = dockWindow.CanClose;
					num2 = (short)457834496;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (dockWindowGroup != null)
					{
						num2 = (short)1863516161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_1.CanExecute = false;
					num2 = (short)2034171906;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
			}
			IL_10E:
			IL_197:
			IL_1B8:
			A_1.Handled = true;
			A_1.ContinueRouting = false;
			return;
			IL_2C:
			dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
			dockWindowGroup = (A_1.Source as global::DevComponents.WpfDock.DockWindowGroup);
			num2 = (short)1298202628;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0001C4A8 File Offset: 0x0001A6A8
		private void d(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)2010251276;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfDock.DockWindow dockWindow;
				switch (num2)
				{
				case 0:
					num = (short)1122107394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					global::DevComponents.WpfDock.DockWindowGroup parentGroup;
					this.RestoreLastDockPosition(parentGroup);
					num = (short)1562181643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (dockWindow.IsFloating)
					{
						num = (short)861339654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B0;
				case 3:
					goto IL_1B8;
				case 4:
					if (!dockWindow.IsAutoHide)
					{
						num = (short)1987379200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B0;
				case 5:
					dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
					num = (short)232325124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					global::DevComponents.WpfDock.DockWindowGroup parentGroup = dockWindow.ParentGroup;
					num = (short)248119305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					if (!dockWindow.IsAutoHide)
					{
						num = (short)969867272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AD;
				case 8:
				{
					num = (short)355946898;
					short num3 = num;
					num = (short)1984647570;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_244;
					default:
						num = (short)534904832;
						if (num != 0)
						{
						}
						num = (short)1376911370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
				{
					num = (short)210173953;
					if (num != 0)
					{
					}
					global::DevComponents.WpfDock.DockWindowGroup parentGroup;
					if (parentGroup != null)
					{
						num = (short)1602093057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AD;
				}
				case 10:
					if (global::DevComponents.WpfDock.DockSite.GetIsDocument(dockWindow))
					{
						num = (short)605159437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AD;
				case 11:
					goto IL_154;
				case 12:
				{
					num = (short)1898905600;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				}
				case 13:
					goto IL_244;
				}
				IL_86:
				if (A_1.Source is global::DevComponents.WpfDock.DockWindow)
				{
					num = (short)1314062341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_B0:
				num = (short)1133051911;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_244:
				this.c(dockWindow);
				num = (short)1773273091;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_154:
			IL_1B8:
			IL_2AD:
			A_1.Handled = true;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0001C76C File Offset: 0x0001A96C
		private void d(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			short num2;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_186;
				case 1:
					num2 = (short)1854013444;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)556924933;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_1F7;
				case 4:
				{
					A_1.CanExecute = (dockWindow.CanDockLeft && dockWindow.CanDockRight && dockWindow.CanDockTop && dockWindow.CanDockBottom);
					num2 = (short)1612251136;
					short num3 = num2;
					num2 = (short)1368129536;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (global::DevComponents.WpfDock.DockSite.GetIsDocument(dockWindow))
					{
						num2 = (short)939393025;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_1.CanExecute = !dockWindow.IsAutoHide;
					num2 = (short)1305870343;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (dockWindow != null)
					{
						num2 = (short)1274150914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D8;
				case 7:
					goto IL_1D6;
				}
				goto IL_30;
			}
			IL_186:
			num2 = (short)677707777;
			if (num2 != 0)
			{
			}
			IL_1D6:
			goto IL_1F9;
			IL_1D8:
			A_1.CanExecute = false;
			goto IL_1DF;
			IL_1F7:
			IL_1F9:
			A_1.Handled = true;
			A_1.ContinueRouting = false;
			return;
			IL_30:
			dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
			num2 = (short)1668486142;
			short num4 = num2;
			num2 = (short)623514622;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1DF:
				num2 = (short)1508376579;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1903558656;
				if (num2 != 0)
				{
				}
				num2 = (short)1186856966;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0001C980 File Offset: 0x0001AB80
		private void c(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)515112967;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::DevComponents.WpfDock.DockWindow dockWindow;
					if (!dockWindow.IsFloating)
					{
						num = (short)1379991557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F7;
				}
				case 1:
				{
					global::DevComponents.WpfDock.DockWindow dockWindow;
					if (!dockWindow.IsAutoHide)
					{
						num = (short)478281736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F7;
				}
				case 2:
				{
					global::DevComponents.WpfDock.DockWindow dockWindow;
					this.FloatWindow(dockWindow);
					num = (short)443219968;
					short num3 = num;
					num = (short)1796866052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					global::DevComponents.WpfDock.DockWindow dockWindow = A_1.Source as global::DevComponents.WpfDock.DockWindow;
					num = (short)1336541185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_1F5;
				case 5:
					num = (short)1156186118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					global::DevComponents.WpfDock.DockWindow dockWindow;
					if (dockWindow.CanFloat)
					{
						goto IL_107;
					}
					goto IL_1F7;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 8:
					num = (short)780206080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (!(A_1.Source is global::DevComponents.WpfDock.DockWindow))
				{
					break;
				}
				num = (short)1355169808;
				short num4 = num;
				num = (short)1874346000;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1621032961;
					if (num != 0)
					{
					}
					num = (short)1237516288;
					if (num != 0)
					{
					}
					num = (short)1898250243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_107:
				num = (short)255197186;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F5:
			IL_1F7:
			A_1.Handled = true;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0001CB8C File Offset: 0x0001AD8C
		private void c(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_151;
				case 1:
					A_1.CanExecute = (!dockWindow.IsAutoHide && !dockWindow.IsFloating && dockWindow.CanFloat);
					num2 = (short)1158348804;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)48627713;
					if (num2 != 0)
					{
					}
					num2 = (short)449970176;
					short num3 = num2;
					num2 = (short)116439852;
					short num4 = num2;
					num2 = (short)1414642476;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13A;
					default:
						num2 = (short)2036269056;
						if (num2 != 0)
						{
						}
						num2 = (short)1536229377;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (dockWindow != null)
					{
						num2 = (short)1131282434;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_1.CanExecute = false;
					goto IL_13A;
				case 4:
					goto IL_16F;
				}
				goto IL_24;
				IL_13A:
				num2 = (short)856948736;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_151:
			IL_16F:
			A_1.Handled = true;
			A_1.ContinueRouting = false;
			return;
			IL_24:
			dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
			num2 = (short)1724579843;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0001CD18 File Offset: 0x0001AF18
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::DevComponents.WpfDock.DockWindowGroup FindTargetDockDocumentGroup()
		{
			short num = (short)539361282;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)487587840;
					short num3 = num;
					num = (short)336199681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					if (((global::DevComponents.WpfDock.SplitPanel)base.Content).VisibleItemsCount <= 0)
					{
						goto IL_157;
					}
					num = (short)1479622840;
					short num4 = num;
					num = (short)1464025272;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)40960000;
						if (num != 0)
						{
						}
						num = (short)817692675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_14;
				case 3:
					goto IL_12A;
				}
				goto IL_34;
				IL_14:
				switch (0)
				{
				case 0:
					IL_34:
					if (!(base.Content is global::DevComponents.WpfDock.SplitPanel))
					{
						goto IL_157;
					}
					num = (short)1170931712;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_12A:
			num = (short)1454112769;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.SplitPanel a_ = base.Content as global::DevComponents.WpfDock.SplitPanel;
			return this.a(a_);
			IL_157:
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0001CE80 File Offset: 0x0001B080
		private global::DevComponents.WpfDock.DockWindowGroup a(global::DevComponents.WpfDock.SplitPanel A_0)
		{
			short num = (short)1002831872;
			short num2 = num;
			num = (short)1830354944;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator = A_0.Children.GetEnumerator();
				global::DevComponents.WpfDock.DockWindowGroup result;
				try
				{
					num = (short)1330380807;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							num = (short)536506576;
							short num4 = num;
							num = (short)1225748688;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1C6;
							default:
								goto IL_2BB;
							}
							break;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1113784325;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = enumerator.Current;
							num = (short)988741642;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::System.Windows.UIElement uielement;
							global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup = this.a((global::DevComponents.WpfDock.SplitPanel)uielement);
							num = (short)1728380936;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::DevComponents.WpfDock.SplitPanel)
							{
								num = (short)1443692546;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_D4;
						case 5:
							goto IL_1C6;
						case 6:
							num = (short)781582349;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_B8;
							}
							continue;
						case 8:
						{
							global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
							if (dockWindowGroup != null)
							{
								num = (short)1745289228;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_1EA;
						case 10:
						{
							num = (short)446955521;
							if (num != 0)
							{
							}
							global::System.Windows.UIElement uielement;
							if (uielement is global::DevComponents.WpfDock.DockWindowGroup)
							{
								num = (short)535429126;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22A;
						}
						case 11:
						{
							global::System.Windows.UIElement uielement;
							result = (uielement as global::DevComponents.WpfDock.DockWindowGroup);
							num = (short)982188041;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
							result = dockWindowGroup;
							num = (short)859373572;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)1297547275;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22A;
						}
						}
						IL_18A:
						num = (short)1391722497;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B8:
						goto IL_18A;
						IL_1C6:
						num = (short)49872896;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_22A:
						num = (short)1927413763;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_D4:
					IL_1EA:
					return result;
					IL_2BB:
					num = (short)2144206848;
					if (num != 0)
					{
					}
					goto IL_56;
				}
				finally
				{
					num = (short)671612929;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1182728194;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_308;
							}
							continue;
						case 2:
							goto IL_340;
						}
						IL_308:
						if (enumerator == null)
						{
							break;
						}
						num = (short)734986240;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_340:;
				}
				return result;
				IL_56:
				return null;
			}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
		private void b(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)368902144;
			switch (num)
			{
			default:
			{
				num = (short)1793261586;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfDock.DockWindow dockWindow;
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup3;
					bool flag;
					switch (num2)
					{
					case 0:
						dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
						num = (short)133693448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_106;
					case 2:
						dockWindowGroup = dockWindow.ParentGroup;
						num = (short)1826684932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2;
						dockWindowGroup2.UpdateVisibility();
						num = (short)2116419597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_146;
					case 5:
					{
						this.d(dockWindow);
						dockWindowGroup = null;
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2 = null;
						int insertIndex = -1;
						num = (short)1698496521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_146;
					case 7:
					{
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2;
						if (dockWindowGroup2 != null)
						{
							num = (short)1628569603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_512;
					}
					case 8:
						if (!dockWindow.IsAutoHide)
						{
							num = (short)870776847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_512;
					case 9:
					{
						if (dockWindow.ParentGroup.Items.Count == 1)
						{
							num = (short)1725366274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2 = dockWindow.ParentGroup;
						num = (short)1823014926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						flag = this.DockWindow(dockWindowGroup, dockWindowGroup3, global::DevComponents.WpfDock.eDockSide.Tab);
						num = (short)1676148737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (!global::DevComponents.WpfDock.DockSite.GetIsDocument(dockWindow))
						{
							num = (short)827654149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_512;
					case 12:
						goto IL_106;
					case 13:
						goto IL_2C9;
					case 14:
					{
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2;
						if (dockWindowGroup2 != null)
						{
							num = (short)722337816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CE;
					}
					case 15:
						num = (short)172163088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (dockWindow.CanDockAsDocument)
						{
							num = (short)480313369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_512;
					case 17:
						num = (short)334168090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						switch (0)
						{
						case 0:
							goto IL_B1;
						}
						continue;
					case 19:
						goto IL_215;
					case 20:
						if (!flag)
						{
							num = (short)2059403281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_348;
					case 21:
						goto IL_2CE;
					case 22:
					{
						num = (short)978184101;
						short num3 = num;
						num = (short)755492773;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1080360960;
							if (num != 0)
							{
							}
							this.Detach(dockWindow);
							global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2;
							int insertIndex;
							dockWindowGroup2.Items.Insert(insertIndex, dockWindow);
							break;
						}
						}
						num = (short)1013973011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (dockWindowGroup3 != null)
						{
							num = (short)1602879498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = this.DockWindow(dockWindowGroup, global::DevComponents.WpfDock.eDockSide.Tab);
						num = (short)1205338124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2;
						int insertIndex = dockWindowGroup2.Items.IndexOf(dockWindow);
						num = (short)639696917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						num = (short)1966473227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2;
						if (dockWindowGroup2 != null)
						{
							num = (short)796065814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_348;
					}
					}
					IL_B1:
					if (A_1.Source is global::DevComponents.WpfDock.DockWindow)
					{
						num = (short)745340929;
						if (num != 0)
						{
						}
						num = (short)1736245248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_512;
					IL_106:
					num = (short)514392084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_146:
					dockWindowGroup3 = this.FindTargetDockDocumentGroup();
					flag = false;
					num = (short)989986839;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CE:
					dockWindowGroup = new global::DevComponents.WpfDock.DockWindowGroup();
					this.Detach(dockWindow);
					dockWindowGroup.Items.Add(dockWindow);
					num = (short)1465974790;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_348:
					num = (short)1528233991;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_215:
				num = (short)93913088;
				short num4 = num;
				IL_2C9:
				IL_512:
				A_1.Handled = true;
				return;
			}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0001D718 File Offset: 0x0001B918
		private void b(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					A_1.CanExecute = (!dockWindow.IsAutoHide && dockWindow.CanDockAsDocument);
					num2 = (short)638139142;
					short num3 = num2;
					num2 = (short)50543366;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_146;
					default:
						num2 = (short)1003290624;
						if (num2 != 0)
						{
						}
						num2 = (short)80674817;
						if (num2 != 0)
						{
						}
						num2 = (short)468123650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)1160052736;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_144;
				case 3:
					goto IL_164;
				case 4:
					if (dockWindow != null)
					{
						num2 = (short)335020033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_146;
				}
				goto IL_24;
				IL_146:
				A_1.CanExecute = false;
				num2 = (short)721813507;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_144:
			IL_164:
			A_1.Handled = true;
			A_1.ContinueRouting = false;
			return;
			IL_24:
			num2 = (short)1519058944;
			short num4 = num2;
			dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
			num2 = (short)1674575876;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0001D89C File Offset: 0x0001BA9C
		private void a(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)1534525444;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2117664768;
				short num3 = num;
				global::DevComponents.WpfDock.DockWindow dockWindow;
				switch (num2)
				{
				case 0:
					goto IL_A6;
				case 1:
				{
					num = (short)1995818361;
					short num4 = num;
					num = (short)1331938681;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13E;
					default:
						num = (short)631701505;
						if (num != 0)
						{
						}
						num = (short)693829632;
						if (num != 0)
						{
						}
						dockWindow = (A_1.Source as global::DevComponents.WpfDock.DockWindow);
						num = (short)625803266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_13E;
				case 3:
					dockWindow.IsSelected = true;
					num = (short)450953216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				IL_62:
				if (A_1.Source is global::DevComponents.WpfDock.DockWindow)
				{
					num = (short)1824980993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13E:
				if (dockWindow.IsSelected)
				{
					break;
				}
				num = (short)1429929987;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A6:
			A_1.Handled = true;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0001DA14 File Offset: 0x0001BC14
		private void a(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1979777027;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_57;
				case 1:
					goto IL_C6;
				case 2:
					goto IL_138;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				}
				IL_36:
				if (A_1.Source is global::DevComponents.WpfDock.DockWindow)
				{
					num = (short)1540358144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				A_1.CanExecute = false;
				num = (short)940433746;
				short num3 = num;
				num = (short)1902174546;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1485504512;
					if (num != 0)
					{
					}
					num = (short)2060320769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_57:
				A_1.CanExecute = true;
				num = (short)2140864514;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C6:
			num = (short)970522625;
			if (num != 0)
			{
			}
			num = (short)1891631104;
			short num4 = num;
			IL_138:
			A_1.Handled = true;
			A_1.ContinueRouting = false;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0001DB6C File Offset: 0x0001BD6C
		public global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow> GetDocuments()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow> list;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					this.a(list, base.Content as global::DevComponents.WpfDock.SplitPanel);
					num2 = (short)746127361;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return list;
				case 2:
					goto IL_81;
				}
				goto IL_1C;
			}
			IL_81:
			if (base.Content is global::DevComponents.WpfDock.SplitPanel)
			{
				goto IL_91;
			}
			return list;
			IL_1C:
			list = new global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow>();
			num2 = (short)441888018;
			short num3 = num2;
			num2 = (short)689220882;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_91:
				num2 = (short)164364289;
				if (num2 != 0)
				{
				}
				num2 = (short)1902182400;
				short num4 = num2;
				num2 = (short)676528128;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)148111360;
				if (num2 != 0)
				{
				}
				num2 = (short)1260781570;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0001DCA4 File Offset: 0x0001BEA4
		public global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow> GetDockWindows()
		{
			short num = (short)1353684420;
			short num2 = num;
			num = (short)301831620;
			switch (num2 == num)
			{
			}
			num = (short)1107755008;
			short num3 = num;
			num = (short)489488385;
			if (num != 0)
			{
			}
			num = (short)1880948736;
			if (num != 0)
			{
			}
			return this.GetDockWindows(global::DevComponents.WpfDock.eDockList.All);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0001DD58 File Offset: 0x0001BF58
		public global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow> GetDockWindows(global::DevComponents.WpfDock.eDockList dockWindowsToReturn)
		{
			short num = (short)1206059008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow> list;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1644363779;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1159135233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_496;
								case 2:
								{
									global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
									global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)dockWindowGroup.Items).GetEnumerator();
									num = (short)1281949700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_25B;
									}
									continue;
								case 4:
									try
									{
										num = (short)293339139;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)219414529;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_3C4;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_312;
												}
												continue;
											case 4:
											{
												global::DevComponents.WpfDock.DockWindow dockWindow;
												if (dockWindow != null)
												{
													num = (short)158793734;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
											{
												global::System.Collections.IEnumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1251540992;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::DevComponents.WpfDock.DockWindow dockWindow = enumerator.Current as global::DevComponents.WpfDock.DockWindow;
												num = (short)1189019652;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
											{
												global::DevComponents.WpfDock.DockWindow dockWindow;
												list.Add(dockWindow);
												num = (short)1559953410;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_371:
											num = (short)1265303557;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_312:
											goto IL_371;
										}
										IL_3C4:;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_3E3;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_3D0:
											switch (num2)
											{
											case 0:
												if (disposable != null)
												{
													num = (short)1366753282;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_43E;
											case 1:
												goto IL_43C;
											case 2:
												disposable.Dispose();
												num = (short)693829633;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_3E3;
										}
										IL_43C:
										IL_43E:
										break;
										IL_3E3:
										global::System.Collections.IEnumerator enumerator;
										disposable = (enumerator as global::System.IDisposable);
										num = (short)1269563392;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_3D0;
									}
									break;
								case 5:
								{
									global::System.Collections.Generic.List<global::DevComponents.WpfDock.FloatingWindow>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)2121465856;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup = enumerator2.Current.Content as global::DevComponents.WpfDock.DockWindowGroup;
									num = (short)873332742;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
									if (dockWindowGroup != null)
									{
										num = (short)233439234;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_43F:
								num = (short)732954629;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_25B:
								goto IL_43F;
							}
							IL_496:
							return list;
						}
						finally
						{
							global::System.Collections.Generic.List<global::DevComponents.WpfDock.FloatingWindow>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_4A9;
					case 1:
						try
						{
							num = (short)220856322;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_6C5;
								case 1:
									num = (short)1956184064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_64F;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfDock.SplitPanel> enumerator3;
									if (!enumerator3.MoveNext())
									{
										num = (short)745865217;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.SplitPanel a_ = enumerator3.Current;
									this.a(list, a_);
									num = (short)1723465731;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_651:
								num = (short)1894383620;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_64F:
								goto IL_651;
							}
							IL_6C5:
							goto IL_16C;
						}
						finally
						{
							num = (short)2111635456;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_6FD;
									}
									continue;
								case 1:
									goto IL_784;
								case 2:
									goto IL_765;
								}
								IL_6FD:
								global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfDock.SplitPanel> enumerator3;
								if (enumerator3 == null)
								{
									break;
								}
								num = (short)1867982929;
								short num3 = num;
								num = (short)226895953;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1715011584;
									if (num != 0)
									{
									}
									num = (short)1153433602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_765:
								enumerator3.Dispose();
								num = (short)292356097;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_784:;
						}
						goto IL_787;
					case 2:
						this.a(list, this.o);
						num = (short)697106437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if ((dockWindowsToReturn & global::DevComponents.WpfDock.eDockList.Floating) == global::DevComponents.WpfDock.eDockList.Floating)
						{
							num = (short)1616248851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 4:
						num = (short)169148417;
						if (num != 0)
						{
						}
						num = (short)1599930379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1AB;
					case 6:
						goto IL_101;
					case 7:
						goto IL_7EF;
					case 8:
						if ((dockWindowsToReturn & global::DevComponents.WpfDock.eDockList.AutoHide) == global::DevComponents.WpfDock.eDockList.AutoHide)
						{
							num = (short)648871946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB;
					case 9:
						this.a(list, this.q);
						num = (short)411107335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_787;
					case 11:
						if (base.Content is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1509359637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57E;
					case 12:
						this.a(list, this.n);
						num = (short)1698365446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (this.q != null)
						{
							num = (short)76021769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7EF;
					case 14:
						goto IL_57E;
					case 15:
						this.a(list, this.p);
						num = (short)172359702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (this.n != null)
						{
							num = (short)2144731148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101;
					case 17:
						if (this.p != null)
						{
							num = (short)751108111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A9;
					case 18:
						if ((dockWindowsToReturn & global::DevComponents.WpfDock.eDockList.Documents) == global::DevComponents.WpfDock.eDockList.Documents)
						{
							num = (short)1881210884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57E;
					case 19:
					{
						global::System.Collections.Generic.List<global::DevComponents.WpfDock.FloatingWindow>.Enumerator enumerator2 = this.t.GetEnumerator();
						num = (short)398786560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfDock.SplitPanel> enumerator3 = this.SplitPanels.GetEnumerator();
						num = (short)484835329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						this.a(list, base.Content as global::DevComponents.WpfDock.SplitPanel);
						num = (short)671154190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_4A9;
					case 23:
						if (this.o != null)
						{
							num = (short)950665218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB;
					case 24:
						if ((dockWindowsToReturn & global::DevComponents.WpfDock.eDockList.Docked) == global::DevComponents.WpfDock.eDockList.Docked)
						{
							num = (short)1635975168;
							short num4 = num;
							num = (short)1352400916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16C;
					}
					goto IL_92;
					IL_101:
					num = (short)1107034135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16C:
					num = (short)529203218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AB:
					num = (short)1391591427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A9:
					num = (short)1298792461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_57E:
					num = (short)477233160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_787:
					num = (short)884146193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7EF:
					num = (short)576454672;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_92:
				list = new global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow>();
				num = (short)2062286872;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0001E610 File Offset: 0x0001C810
		public global::System.Collections.Generic.List<global::DevComponents.WpfDock.FloatingWindow> GetFloatingWindows()
		{
			short num = (short)1373209303;
			short num2 = num;
			num = (short)1391297239;
			switch (num2 == num)
			{
			}
			num = (short)2010447873;
			if (num != 0)
			{
			}
			num = (short)1370030080;
			if (num != 0)
			{
			}
			num = (short)1283588096;
			short num3 = num;
			return this.t;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0001E6C0 File Offset: 0x0001C8C0
		private void a(global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow> A_0, global::DevComponents.WpfDock.AutoHidePanel A_1)
		{
			global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)A_1.Items).GetEnumerator();
			short num;
			try
			{
				num = (short)615972867;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					switch (num2)
					{
					case 0:
					{
						A_0.Add((global::DevComponents.WpfDock.DockWindow)obj);
						num = (short)1948609396;
						short num3 = num;
						num = (short)1707830132;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9F;
						default:
							num = (short)994115584;
							if (num != 0)
							{
							}
							num = (short)1870856193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)1047068677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_4F;
						}
						continue;
					case 4:
						goto IL_9F;
					case 5:
						goto IL_14D;
					case 6:
						if (obj is global::DevComponents.WpfDock.DockWindow)
						{
							num = (short)1674641408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					goto IL_4F;
					IL_9F:
					if (!enumerator.MoveNext())
					{
						num = (short)844038146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					obj = enumerator.Current;
					num = (short)623312902;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8B:
					num = (short)2101149700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F:
					goto IL_8B;
				}
				IL_14D:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_16B;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_159:
					switch (num2)
					{
					case 0:
						disposable.Dispose();
						num = (short)1966735361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1BA;
					case 2:
						if (disposable != null)
						{
							num = (short)779616256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BC;
					}
					goto IL_16B;
				}
				IL_1BA:
				IL_1BC:
				goto EndFinally_6;
				IL_16B:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1411710978;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_159;
				EndFinally_6:;
			}
			num = (short)1163067392;
			short num4 = num;
			num = (short)1376911361;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0001E8FC File Offset: 0x0001CAFC
		private void a(global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow> A_0, global::DevComponents.WpfDock.SplitPanel A_1)
		{
			short num = (short)991297536;
			short num2 = num;
			num = (short)1982791681;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator = A_1.Children.GetEnumerator();
			try
			{
				num = (short)1813381128;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.UIElement uielement;
					switch (num3)
					{
					case 0:
						if (uielement is global::DevComponents.WpfDock.DockWindow)
						{
							num = (short)1369767943;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)24444932;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1D7;
					case 2:
						if (uielement is global::DevComponents.WpfDock.DockWindowGroup)
						{
							num = (short)80805889;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 4:
						if (uielement is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1345126409;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)594411522;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)2081357835;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						A_0.Add(uielement as global::DevComponents.WpfDock.DockWindow);
						num = (short)743282806;
						short num4 = num;
						num = (short)1097832566;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D7;
						default:
							num = (short)1322057728;
							if (num != 0)
							{
							}
							num = (short)389414918;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_B8;
						}
						continue;
					case 9:
						this.a(A_0, uielement as global::DevComponents.WpfDock.SplitPanel);
						num = (short)1925447683;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (!enumerator.MoveNext())
						{
							num = (short)600834053;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement = enumerator.Current;
						num = (short)7536640;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_294;
					}
					goto IL_B8;
					IL_1D7:
					this.a(A_0, (global::DevComponents.WpfDock.DockWindowGroup)uielement);
					num = (short)689504268;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DC:
					num = (short)1136853002;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_B8:
					goto IL_1DC;
				}
				IL_294:;
			}
			finally
			{
				num = (short)899219458;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)507576321;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_2FA;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_2C6;
						}
						continue;
					}
					IL_2C6:
					if (enumerator == null)
					{
						break;
					}
					num = (short)166658048;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_2FA:;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0001EC24 File Offset: 0x0001CE24
		private void a(global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow> A_0, global::DevComponents.WpfDock.DockWindowGroup A_1)
		{
			short num = (short)1993080832;
			short num2 = num;
			num = (short)1592665945;
			short num3 = num;
			num = (short)1160652633;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1930166272;
				if (num != 0)
				{
				}
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)A_1.Items).GetEnumerator();
				try
				{
					num = (short)1540882434;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)769392646;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							object obj = enumerator.Current;
							num = (short)1787035649;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							object obj;
							if (obj is global::DevComponents.WpfDock.DockWindow)
							{
								num = (short)2022375427;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C2;
							}
							continue;
						case 3:
						{
							object obj;
							A_0.Add((global::DevComponents.WpfDock.DockWindow)obj);
							num = (short)286851077;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_19B;
						case 6:
							num = (short)1096155137;
							if (num != 0)
							{
							}
							num = (short)1216806916;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_FD:
						num = (short)1546518528;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_C2:
						goto IL_FD;
					}
					IL_19B:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1B9;
					}
					int num4;
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_1A7:
						switch (num4)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)680394754;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20B;
						case 1:
							goto IL_209;
						case 2:
							disposable.Dispose();
							num = (short)1607663617;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B9;
					}
					IL_209:
					IL_20B:
					break;
					IL_1B9:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)203227136;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_1A7;
				}
				break;
			}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0001EE5C File Offset: 0x0001D05C
		internal global::DevComponents.WpfDock.Primitives.b e(global::DevComponents.WpfDock.DockWindow A_0)
		{
			short num = (short)416088064;
			short num2 = num;
			num = (short)1302340461;
			short num3 = num;
			num = (short)417014637;
			switch (num3 == num)
			{
			}
			num = (short)414908417;
			if (num != 0)
			{
			}
			num = (short)1811939328;
			if (num != 0)
			{
			}
			return this.a(A_0, false);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0001EF0C File Offset: 0x0001D10C
		private void e()
		{
			short num = (short)297336832;
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
				global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow> list;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
						if (this.ad.Count > 0)
						{
							num = (short)981729288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3;
					case 1:
					{
						global::System.Collections.IEnumerator enumerator = this.k.b().GetEnumerator();
						num = (short)1502674946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)1920008198;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)2123956232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::DevComponents.WpfDock.Primitives.b b;
									if (b.c() != null)
									{
										num = (short)733544455;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::DevComponents.WpfDock.Primitives.b b;
									if (b != null)
									{
										num = (short)247791620;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)1303445506;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1668808704;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.Primitives.b b = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfDock.Primitives.b;
									num = (short)1678114819;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_357;
									}
									continue;
								case 7:
								{
									global::DevComponents.WpfDock.Primitives.b b;
									list.Add(b.c());
									num = (short)103022593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_454;
								}
								IL_3FF:
								num = (short)1445789701;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_357:
								goto IL_3FF;
							}
							IL_454:
							goto IL_2A3;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_476;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_463:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1245249537;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4CB;
								case 1:
									disposable.Dispose();
									num = (short)1086717954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4C9;
								}
								goto IL_476;
							}
							IL_4C9:
							IL_4CB:
							goto EndFinally_20;
							IL_476:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)126222336;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_463;
							EndFinally_20:;
						}
						goto Block_6;
					case 3:
						goto IL_233;
					case 4:
						goto IL_4CC;
					case 5:
						try
						{
							num = (short)1301872642;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)849674244;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_150;
									}
									continue;
								case 3:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)722665473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator2.Current.AutoHideOpen = false;
									num = (short)455511155;
									short num3 = num;
									num = (short)2053082227;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)950992896;
										if (num != 0)
										{
										}
										num = (short)886177792;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_220;
								}
								IL_1C7:
								num = (short)215941123;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_150:
								goto IL_1C7;
							}
							IL_220:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_233;
					case 6:
						if (this.k != null)
						{
							num = (short)1405812739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C9;
					case 7:
						num = (short)1715798017;
						if (num != 0)
						{
						}
						if (this.k.b().Count > 0)
						{
							num = (short)1898184705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C9;
					case 8:
					{
						num = (short)1010499584;
						short num4 = num;
						global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.Popup>.Enumerator enumerator3 = this.ad.GetEnumerator();
						num = (short)1150877700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_52;
					IL_233:
					num = (short)418185223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A3:
					enumerator2 = list.GetEnumerator();
					num = (short)663879685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					try
					{
						IL_4CC:
						num = (short)2147090438;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
							{
								global::DevComponents.WpfDock.Primitives.b b2;
								if (b2 != null)
								{
									num = (short)822411269;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								global::DevComponents.WpfDock.Primitives.b b2;
								if (b2.c() != null)
								{
									num = (short)1443627015;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.Popup>.Enumerator enumerator3;
								if (!enumerator3.MoveNext())
								{
									num = (short)607584260;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::DevComponents.WpfDock.Primitives.b b2 = enumerator3.Current.Child as global::DevComponents.WpfDock.Primitives.b;
								num = (short)1029177345;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)2128150536;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								num = (short)667025410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_516;
								}
								continue;
							case 7:
							{
								global::DevComponents.WpfDock.Primitives.b b2;
								list.Add(b2.c());
								num = (short)583270400;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								goto IL_61E;
							}
							IL_518:
							num = (short)1159004163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_516:
							goto IL_518;
						}
						IL_61E:
						goto IL_2A3;
					}
					finally
					{
						global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.Popup>.Enumerator enumerator3;
						((global::System.IDisposable)enumerator3).Dispose();
					}
					break;
					IL_2C9:
					num = (short)1915617280;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_52:
				list = new global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow>();
				num = (short)1409155078;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0001F598 File Offset: 0x0001D798
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			short num = (short)537739986;
			short num2 = num;
			num = (short)652231378;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1209401344;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1096024065;
			if (num != 0)
			{
			}
			num = (short)1985282048;
			if (num != 0)
			{
			}
			this.e();
			this.k = null;
			base.OnVisualParentChanged(oldParent);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0001F654 File Offset: 0x0001D854
		private global::DevComponents.WpfDock.Primitives.a d()
		{
			short num = (short)1967980550;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Documents.AdornerLayer adornerLayer;
				switch (num2)
				{
				case 0:
					if (this.k.Parent != adornerLayer)
					{
						num = (short)125763592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22E;
				case 1:
					goto IL_149;
				case 2:
					goto IL_BD;
				case 3:
					this.k = new global::DevComponents.WpfDock.Primitives.a(this);
					global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this).Add(this.k);
					num = (short)433586177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_14E;
				case 5:
				{
					num = (short)1580222002;
					short num3 = num;
					num = (short)469911090;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BD;
					default:
						goto IL_1CE;
					}
					break;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 7:
					((global::System.Windows.Documents.AdornerLayer)this.k.Parent).Remove(this.k);
					num = (short)1611005956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)536608770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4A:
				if (this.k == null)
				{
					num = (short)1675886595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
				num = (short)1015087104;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BD:
				num = (short)1388576769;
				if (num != 0)
				{
				}
				if (this.k.Parent is global::System.Windows.Documents.AdornerLayer)
				{
					num = (short)1166540807;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_14E:
				num = (short)387907584;
				short num4 = num;
				adornerLayer.Add(this.k);
				num = (short)1595539461;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_149:
			goto IL_22E;
			IL_1CE:
			num = (short)1632174080;
			if (num != 0)
			{
			}
			IL_22E:
			return this.k;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0001F898 File Offset: 0x0001DA98
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			short num = (short)1808269312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					global::DevComponents.WpfDock.Primitives.a a;
					for (;;)
					{
						IL_27:
						num = (short)1415118848;
						short num3 = num;
						switch (num2)
						{
						case 0:
							if (a != null)
							{
								num = (short)965083139;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5A9;
						case 1:
							return;
						case 2:
						{
							global::System.Collections.IEnumerator enumerator = a.b().GetEnumerator();
							num = (short)1283063813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_566;
						case 4:
							if (a.b().Count > 0)
							{
								num = (short)1737359362;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5A9;
						case 5:
							try
							{
								num = (short)594214927;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::DevComponents.WpfDock.Primitives.b b;
										if (b.c() != null)
										{
											num = (short)252051472;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
									{
										global::DevComponents.WpfDock.Primitives.b b;
										if (b == null)
										{
											num = (short)740950019;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2096103424;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_284;
									case 3:
										num = (short)759955458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::DevComponents.WpfDock.AutoHidePanel autoHidePanel;
										if (autoHidePanel != null)
										{
											num = (short)168558609;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										num = (short)1979580436;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										global::DevComponents.WpfDock.AutoHidePanel autoHidePanel2;
										if (autoHidePanel2 != null)
										{
											num = (short)958398477;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1300955146;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::DevComponents.WpfDock.Primitives.b b = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfDock.Primitives.b;
										num = (short)697696257;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										global::DevComponents.WpfDock.Primitives.b b;
										if (b.c().LastDock == global::System.Windows.Controls.Dock.Right)
										{
											num = (short)303038478;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
										num = (short)2100887564;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
									{
										global::DevComponents.WpfDock.AutoHidePanel autoHidePanel2 = this.GetAutoHidePanel(global::System.Windows.Controls.Dock.Bottom);
										num = (short)843776006;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										goto IL_4EA;
									case 13:
									{
										global::DevComponents.WpfDock.Primitives.b b;
										b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.b, null);
										b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.d, null);
										global::DevComponents.WpfDock.AutoHidePanel autoHidePanel2;
										global::DevComponents.WpfDock.Primitives.a.e(b, sizeInfo.NewSize.Height - b.ActualHeight - autoHidePanel2.ActualHeight);
										global::DevComponents.WpfDock.Primitives.a.b(b, sizeInfo.NewSize.Height - autoHidePanel2.ActualHeight);
										num = (short)2033516551;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 14:
									{
										global::DevComponents.WpfDock.AutoHidePanel autoHidePanel = this.GetAutoHidePanel(global::System.Windows.Controls.Dock.Right);
										num = (short)1729429508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 15:
										switch (0)
										{
										case 0:
											goto IL_19C;
										}
										continue;
									case 16:
										num = (short)868745235;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 17:
									{
										global::DevComponents.WpfDock.Primitives.b b;
										b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.a, null);
										b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.c, null);
										global::DevComponents.WpfDock.AutoHidePanel autoHidePanel;
										global::DevComponents.WpfDock.Primitives.a.d(b, sizeInfo.NewSize.Width - b.ActualWidth - autoHidePanel.ActualHeight);
										global::DevComponents.WpfDock.Primitives.a.c(b, sizeInfo.NewSize.Width - autoHidePanel.ActualHeight);
										num = (short)1870331922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 19:
									{
										global::DevComponents.WpfDock.Primitives.b b;
										if (b.c().AutoHideOpen)
										{
											num = (short)635568133;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 20:
									{
										global::DevComponents.WpfDock.Primitives.b b;
										if (b.c().LastDock == global::System.Windows.Controls.Dock.Bottom)
										{
											num = (short)549584907;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)790626313;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1E4:
									num = (short)1767833608;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_19C:
									goto IL_1E4;
								}
								IL_284:
								return;
								IL_4EA:
								goto IL_5A9;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_50C;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_4F9:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1538785282;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_565;
									case 1:
										goto IL_563;
									case 2:
										disposable.Dispose();
										num = (short)2013986817;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_50C;
								}
								IL_563:
								IL_565:
								goto EndFinally_14;
								IL_50C:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)310771712;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_4F9;
								EndFinally_14:;
							}
							goto IL_566;
						}
						break;
						IL_566:
						num = (short)928710660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5A9:
						base.OnRenderSizeChanged(sizeInfo);
						num = (short)1807482881;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_6F:
					a = this.k;
					num = (short)119166597;
					short num4 = num;
					num = (short)357062277;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1931739137;
						if (num != 0)
						{
						}
						num = (short)536412160;
						if (num != 0)
						{
						}
						num = (short)1290534912;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27;
					}
				}
				return;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0001FEB8 File Offset: 0x0001E0B8
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)670433281;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_ED;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
					for (;;)
					{
						base.InvalidateVisual();
						num = (short)594752317;
						short num3 = num;
						num = (short)711209789;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_96;
						}
					}
					IL_96:
					num = (short)1742667777;
					if (num != 0)
					{
					}
					num = (short)2038300672;
					if (num != 0)
					{
					}
					num = (short)961871872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_32:
				if (e.Property != global::System.Windows.Controls.Control.BackgroundProperty)
				{
					goto IL_117;
				}
				num = (short)1401880578;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_ED:
			num = (short)1313865728;
			short num4 = num;
			IL_117:
			base.OnPropertyChanged(e);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0001FFE4 File Offset: 0x0001E1E4
		private bool c()
		{
			short num = (short)970427929;
			short num2 = num;
			num = (short)848924185;
			switch (num2 == num)
			{
			}
			num = (short)953614336;
			short num3 = num;
			num = (short)1540030465;
			if (num != 0)
			{
			}
			num = (short)774963200;
			if (num != 0)
			{
			}
			return this.AutoHidePopupOverlay;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00020098 File Offset: 0x0001E298
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)933914964;
			short num2 = num;
			num = (short)1684171092;
			switch (num2 == num)
			{
			}
			num = (short)1795555328;
			short num3 = num;
			num = (short)1423245313;
			if (num != 0)
			{
			}
			num = (short)1995702272;
			if (num != 0)
			{
			}
			this.e();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00020144 File Offset: 0x0001E344
		private void a(bool A_0)
		{
			short num = (short)1753546758;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Window window;
			for (;;)
			{
				num = (short)516554753;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_1CB;
				case 1:
					if (A_0)
					{
						num = (short)2000355328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_257;
				case 2:
					goto IL_255;
				case 3:
					if (window == null)
					{
						num = (short)571015178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1680080897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!this.ac)
					{
						num = (short)1380450309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					goto IL_103;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				case 7:
					num = (short)1185546244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)480116745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (!this.ac)
					{
						num = (short)2094268418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C;
				case 10:
					goto IL_101;
				case 11:
					if (A_0)
					{
						num = (short)765329416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C;
				}
				IL_7B:
				if (!A_0)
				{
					num = (short)1656684551;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_103;
				IL_9C:
				window = global::System.Windows.Window.GetWindow(this);
				num = (short)775684096;
				short num3 = num;
				num = (short)1690828803;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_103:
				num = (short)1285554187;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_101:
			return;
			IL_1CB:
			num = (short)1847812983;
			short num4 = num;
			num = (short)2020369271;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
				num = (short)186056704;
				if (num != 0)
				{
				}
				window.LocationChanged -= this.a;
				this.ac = false;
				return;
			}
			return;
			IL_255:
			return;
			IL_257:
			window.LocationChanged += this.a;
			this.ac = true;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000203C4 File Offset: 0x0001E5C4
		internal global::DevComponents.WpfDock.Primitives.b a(global::DevComponents.WpfDock.DockWindow A_0, bool A_1)
		{
			int a_ = 8;
			short num = (short)2067922944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_16B;
				}
				global::DevComponents.WpfDock.Primitives.b b;
				bool flag;
				for (;;)
				{
					IL_30:
					global::System.Windows.Controls.Dock dockFromDockWindow;
					global::System.Windows.Controls.Primitives.Popup popup;
					global::DevComponents.WpfDock.AutoHidePanel autoHidePanel;
					global::DevComponents.WpfDock.SplitPanel splitPanel;
					bool flag2;
					global::DevComponents.WpfDock.AutoHidePanel autoHidePanel2;
					global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation;
					bool flag3;
					bool flag4;
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
					switch (num2)
					{
					case 0:
						goto IL_ED9;
					case 1:
						goto IL_ED9;
					case 2:
						if (dockFromDockWindow == global::System.Windows.Controls.Dock.Left)
						{
							num = (short)1132855308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1320222779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						popup = new global::System.Windows.Controls.Primitives.Popup();
						popup.DataContext = base.DataContext;
						popup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Absolute;
						popup.Child = b;
						this.ad.Add(popup);
						goto IL_3C0;
					case 4:
						b.Opacity = 0.0;
						num = (short)112328779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_ED9;
					case 6:
						num = (short)807206967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_547;
					case 8:
						goto IL_FE3;
					case 9:
					{
						double num3;
						double actualHeight;
						b.Width = num3 - actualHeight;
						global::System.Windows.Point point = base.PointToScreen(new global::System.Windows.Point(actualHeight, 0.0));
						popup.HorizontalOffset = point.X;
						popup.VerticalOffset = point.Y;
						num = (short)2146238528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						if (flag)
						{
							num = (short)1754464322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double actualHeight2;
						global::DevComponents.WpfDock.Primitives.a.e(b, actualHeight2);
						num = (short)97976363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::System.Windows.Forms.Integration.WindowsFormsHost windowsFormsHost = A_0.Content as global::System.Windows.Forms.Integration.WindowsFormsHost;
						num = (short)508755988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::DevComponents.WpfDock.Primitives.a.e(b, global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(autoHidePanel).Y);
						b.Height = autoHidePanel.ActualWidth;
						splitPanel.Height = autoHidePanel.ActualWidth;
						global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蛆꫈뿊료껎뷐蓒볔돖귘돚", a_));
						binding.Source = autoHidePanel;
						global::System.Windows.Data.BindingOperations.SetBinding(b, global::System.Windows.FrameworkElement.HeightProperty, binding);
						global::System.Windows.Data.BindingOperations.SetBinding(splitPanel, global::System.Windows.FrameworkElement.HeightProperty, binding);
						num = (short)774045764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						if (flag2)
						{
							num = (short)334561304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double num4;
						global::DevComponents.WpfDock.Primitives.a.d(b, num4);
						num = (short)794099770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::DevComponents.WpfDock.Primitives.a.b(b, autoHidePanel2.ActualHeight);
						double num5;
						doubleAnimation.To = new double?(num5);
						b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.d, doubleAnimation);
						num = (short)24313882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						popup.IsOpen = true;
						num = (short)252117000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_ED9;
					case 17:
					{
						global::DevComponents.WpfDock.Primitives.a.e(b, base.ActualHeight - autoHidePanel2.ActualHeight);
						double num6;
						doubleAnimation.To = new double?(num6);
						b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.b, doubleAnimation);
						num = (short)1989738512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(1.0, global::System.TimeSpan.FromMilliseconds(120.0));
						b.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, doubleAnimation);
						num = (short)1308295225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (!flag)
						{
							num = (short)756744239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_547;
					case 20:
					{
						global::System.Windows.Forms.Integration.WindowsFormsHost windowsFormsHost;
						if (windowsFormsHost != null)
						{
							num = (short)1421738054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112B;
					}
					case 21:
						return b;
					case 22:
						if (flag2)
						{
							num = (short)1145765906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b.Opacity = 1.0;
						num = (short)122683434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (flag)
						{
							num = (short)1790181379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.d().b().Add(b);
						num = (short)27066408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::DevComponents.WpfDock.Primitives.a.d(b, base.ActualWidth - autoHidePanel2.ActualHeight);
						double num4;
						doubleAnimation.To = new double?(num4);
						b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.a, doubleAnimation);
						num = (short)1584332874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (dockFromDockWindow == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)1267204124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)81395784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_ED9;
					case 27:
						if (!flag)
						{
							num = (short)379387908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DE;
					case 28:
					{
						b.Width = base.ActualWidth;
						global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蛆꫈뿊료껎뷐蓒볔돖귘돚", a_));
						binding2.Source = this;
						global::System.Windows.Data.BindingOperations.SetBinding(b, global::System.Windows.FrameworkElement.WidthProperty, binding2);
						global::System.Windows.Data.BindingOperations.SetBinding(splitPanel, global::System.Windows.FrameworkElement.WidthProperty, binding2);
						num = (short)272302145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						num = (short)1055676694;
						short num7 = num;
						num = (short)687888662;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C0;
						default:
							num = (short)171704320;
							if (num != 0)
							{
							}
							goto IL_487;
						}
						break;
					}
					case 30:
						goto IL_112B;
					case 31:
						if (!flag3)
						{
							num = (short)414318636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112B;
					case 32:
					{
						if (flag2)
						{
							num = (short)1806237713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double num6;
						global::DevComponents.WpfDock.Primitives.a.e(b, num6);
						num = (short)1567096837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						flag4 = false;
						goto IL_351;
					case 34:
					{
						double num6;
						double num8;
						b.Height = num8 - num6;
						global::System.Windows.Point point2 = base.PointToScreen(new global::System.Windows.Point(0.0, num6));
						popup.HorizontalOffset = point2.X;
						popup.VerticalOffset = point2.Y;
						num = (short)1434779684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
					{
						if (flag)
						{
							num = (short)1158742025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double actualHeight;
						global::DevComponents.WpfDock.Primitives.a.d(b, actualHeight);
						num = (short)1037631529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						goto IL_ED9;
					case 37:
					{
						b.Width = base.ActualWidth;
						splitPanel.Width = base.ActualWidth;
						global::System.Windows.Data.Binding binding3 = new global::System.Windows.Data.Binding(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蛆꫈뿊료껎뷐蓒볔돖귘돚", a_));
						binding3.Source = this;
						global::System.Windows.Data.BindingOperations.SetBinding(b, global::System.Windows.FrameworkElement.WidthProperty, binding3);
						global::System.Windows.Data.BindingOperations.SetBinding(splitPanel, global::System.Windows.FrameworkElement.WidthProperty, binding3);
						num = (short)400293948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						goto IL_ED9;
					case 39:
					{
						splitPanel.Width = ((A_0.LastAutoHideSize.Width > 0.0) ? A_0.LastAutoHideSize.Width : A_0.LastDockedSize.Width);
						double num9 = base.ActualWidth - autoHidePanel2.ActualHeight;
						double num4 = base.ActualWidth - autoHidePanel2.ActualHeight - splitPanel.Width;
						num = (short)577372211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						goto IL_487;
					case 41:
					{
						if (flag2)
						{
							num = (short)599588918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double num3;
						global::DevComponents.WpfDock.Primitives.a.c(b, num3);
						num = (short)1894711334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						goto IL_FE3;
					case 43:
					{
						if (flag2)
						{
							num = (short)1373372417;
							if (num != 0)
							{
							}
							num = (short)1161166862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double num5;
						global::DevComponents.WpfDock.Primitives.a.b(b, num5);
						num = (short)133824588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						num = (short)1137246269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (!flag3)
						{
							num = (short)305266761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return b;
					case 46:
					{
						num = (short)35717120;
						short num10 = num;
						goto IL_ED9;
					}
					case 47:
						doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
						doubleAnimation.Duration = global::System.TimeSpan.FromMilliseconds(200.0);
						doubleAnimation.DecelerationRatio = 0.2;
						num = (short)1185808391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
					{
						b.Height = autoHidePanel.ActualWidth;
						splitPanel.Height = autoHidePanel.ActualWidth;
						global::System.Windows.Data.Binding binding4 = new global::System.Windows.Data.Binding(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蛆꫈뿊료껎뷐蓒볔돖귘돚", a_));
						binding4.Source = autoHidePanel;
						global::System.Windows.Data.BindingOperations.SetBinding(b, global::System.Windows.FrameworkElement.HeightProperty, binding4);
						global::System.Windows.Data.BindingOperations.SetBinding(splitPanel, global::System.Windows.FrameworkElement.HeightProperty, binding4);
						num = (short)1847263271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
					{
						double num4;
						double num9;
						b.Width = num9 - num4;
						global::System.Windows.Point point3 = base.PointToScreen(new global::System.Windows.Point(num4, 0.0));
						popup.HorizontalOffset = point3.X;
						popup.VerticalOffset = point3.Y;
						num = (short)1710751744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
					{
						if (flag)
						{
							num = (short)1482293282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double num8;
						global::DevComponents.WpfDock.Primitives.a.b(b, num8);
						num = (short)289407008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
					{
						if (flag)
						{
							num = (short)804061233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double num9;
						global::DevComponents.WpfDock.Primitives.a.c(b, num9);
						num = (short)111738893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						num = (short)131596307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						if (flag)
						{
							num = (short)1348075535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1221001238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
					{
						global::DevComponents.WpfDock.Primitives.a.c(b, autoHidePanel2.ActualHeight);
						double num3;
						doubleAnimation.To = new double?(num3);
						b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.c, doubleAnimation);
						num = (short)1759772673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						flag4 = !A_1;
						goto IL_351;
					case 56:
						popup.PopupAnimation = (flag2 ? global::System.Windows.Controls.Primitives.PopupAnimation.Fade : global::System.Windows.Controls.Primitives.PopupAnimation.None);
						this.a(false);
						num = (short)2064646173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_FE3;
					case 58:
						goto IL_ED9;
					case 59:
						if (dockFromDockWindow == global::System.Windows.Controls.Dock.Top)
						{
							num = (short)310509605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED9;
					case 60:
					{
						splitPanel.Height = ((A_0.LastAutoHideSize.Height > 0.0) ? A_0.LastAutoHideSize.Height : A_0.LastDockedSize.Height);
						double num5 = autoHidePanel2.ActualHeight + splitPanel.Height;
						double actualHeight2 = autoHidePanel2.ActualHeight;
						num = (short)869662730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
						if (A_0.Content is global::System.Windows.Forms.Integration.WindowsFormsHost)
						{
							num = (short)1590755339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112B;
					case 62:
						flag3 = ((global::System.Windows.IInputElement)A_0.Content).Focus();
						num = (short)106430495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (flag2)
						{
							num = (short)1400963124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_547;
					case 64:
						goto IL_ED9;
					case 65:
					{
						splitPanel.Height = ((A_0.LastAutoHideSize.Height > 0.0) ? A_0.LastAutoHideSize.Height : A_0.LastDockedSize.Height);
						double num8 = base.ActualHeight - autoHidePanel2.ActualHeight;
						double num6 = base.ActualHeight - autoHidePanel2.ActualHeight - splitPanel.Height;
						num = (short)1754660914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 66:
					{
						double actualHeight2;
						double num5;
						b.Height = num5 - actualHeight2;
						global::System.Windows.Point point4 = base.PointToScreen(new global::System.Windows.Point(0.0, actualHeight2));
						popup.HorizontalOffset = point4.X;
						popup.VerticalOffset = point4.Y;
						num = (short)88801326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
						if (A_0.Content is global::System.Windows.IInputElement)
						{
							num = (short)1988165694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112B;
					case 68:
					{
						splitPanel.Width = ((A_0.LastAutoHideSize.Width > 0.0) ? A_0.LastAutoHideSize.Width : A_0.LastDockedSize.Width);
						double actualHeight = autoHidePanel2.ActualHeight;
						double num3 = autoHidePanel2.ActualHeight + splitPanel.Width;
						num = (short)1371930659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 69:
						dockWindowGroup.OptionsMenu = (A_0.OptionsMenu ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
						splitPanel.Children.Add(dockWindowGroup);
						global::DevComponents.WpfDock.DockSite.SetDock(splitPanel, dockFromDockWindow);
						b.Children.Add(splitPanel);
						global::System.Windows.Controls.Canvas.SetLeft(splitPanel, 0.0);
						global::System.Windows.Controls.Canvas.SetTop(splitPanel, 0.0);
						num = (short)1685323847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
					{
						global::System.Windows.Forms.Integration.WindowsFormsHost windowsFormsHost;
						flag3 = windowsFormsHost.TabInto(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
						num = (short)1899298846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						if (this.AnimationEnabled)
						{
							num = (short)1161035782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)880345121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (dockFromDockWindow == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)662765616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)427753474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						flag3 = b.Focus();
						num = (short)2019229717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						goto IL_ED9;
					case 75:
						goto IL_1DE;
					case 76:
						goto IL_ED9;
					}
					goto IL_16B;
					IL_1DE:
					splitPanel = new global::DevComponents.WpfDock.SplitPanel();
					dockWindowGroup = new global::DevComponents.WpfDock.DockWindowGroup();
					dockWindowGroup.x = true;
					dockWindowGroup.OwnerSite = this;
					dockFromDockWindow = this.GetDockFromDockWindow(A_0);
					autoHidePanel = this.GetAutoHidePanel(dockFromDockWindow);
					dockWindowGroup.TabVisibility = global::System.Windows.Visibility.Collapsed;
					dockWindowGroup.SelectedContent = A_0.Content;
					global::System.Windows.Data.Binding binding5 = new global::System.Windows.Data.Binding(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("迆곈꫊꧌꫎ꏐ", a_));
					binding5.Source = A_0;
					global::System.Windows.Data.BindingOperations.SetBinding(dockWindowGroup, global::DevComponents.WpfDock.DockWindowGroup.SelectedContentHeaderProperty, binding5);
					dockWindowGroup.SelectedDockWindow = A_0;
					dockWindowGroup.CanAutoHide = A_0.CanAutoHide;
					dockWindowGroup.CanClose = A_0.CanClose;
					dockWindowGroup.IsAutoHide = true;
					num = (short)1217003589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_351:
					flag2 = flag4;
					popup = null;
					num = (short)1833762839;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C0:
					num = (short)50790456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_487:
					doubleAnimation = null;
					num = (short)1753022527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_547:
					autoHidePanel2 = this.GetAutoHidePanel(dockFromDockWindow);
					num = (short)559022105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ED9:
					num = (short)1571422261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FE3:
					flag3 = false;
					num = (short)1188495427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_112B:
					num = (short)1083506733;
					num2 = (int)((global::System.IntPtr)num);
				}
				return b;
				IL_16B:
				flag = this.c();
				b = new global::DevComponents.WpfDock.Primitives.b();
				b.b(A_0);
				num = (short)763494427;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00021558 File Offset: 0x0001F758
		internal void b(global::DevComponents.WpfDock.DockWindow A_0, bool A_1)
		{
			short num = (short)1448476672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				global::DevComponents.WpfDock.Primitives.b b;
				global::System.Windows.Controls.Primitives.Popup popup;
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation;
				bool flag;
				for (;;)
				{
					IL_28:
					global::DevComponents.WpfDock.AutoHidePanel autoHidePanel;
					global::System.Windows.Controls.Dock dock;
					switch (num2)
					{
					case 0:
						b.d();
						popup.IsOpen = false;
						this.ad.Remove(popup);
						num = (short)258998281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_796;
					case 2:
						try
						{
							num = (short)1261502469;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::DevComponents.WpfDock.Primitives.b b2;
								switch (num2)
								{
								case 0:
									num = (short)661323778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)690913517;
									short num3 = num;
									num = (short)38895853;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_657;
									default:
										num = (short)1181941760;
										if (num != 0)
										{
										}
										num = (short)697892870;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									if (b2.c() == A_0)
									{
										num = (short)144113672;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									goto IL_699;
								case 4:
									goto IL_657;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_5E8;
									}
									continue;
								case 6:
									goto IL_742;
								case 7:
								{
									global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.Popup>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2055929857;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Controls.Primitives.Popup popup2 = enumerator.Current;
									b2 = (popup2.Child as global::DevComponents.WpfDock.Primitives.b);
									num = (short)630718468;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									b = b2;
									global::System.Windows.Controls.Primitives.Popup popup2;
									popup = popup2;
									num = (short)663224323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_5E8;
								IL_657:
								if (b2 != null)
								{
									num = (short)1938423808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_69E:
								num = (short)1083703303;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5E8:
								goto IL_69E;
							}
							IL_699:
							IL_742:
							goto IL_7D8;
						}
						finally
						{
							global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.Popup>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_755;
					case 3:
						doubleAnimation.To = new double?(base.ActualWidth - autoHidePanel.ActualHeight);
						b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.a, doubleAnimation);
						num = (short)1223819279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_4B1;
					case 5:
						goto IL_4E9;
					case 6:
						goto IL_50D;
					case 7:
						doubleAnimation.To = new double?(autoHidePanel.ActualHeight);
						b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.c, doubleAnimation);
						num = (short)562823169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_570;
					case 9:
						if (this.ad.Count == 0)
						{
							num = (short)2051211272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						if (A_1)
						{
							num = (short)112263186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b.d();
						num = (short)66387974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)1555103745;
						if (num != 0)
						{
						}
						if (flag)
						{
							num = (short)1231486995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator2 = this.k.b().GetEnumerator();
						num = (short)2010710038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						doubleAnimation.To = new double?(base.ActualHeight - autoHidePanel.ActualHeight);
						b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.b, doubleAnimation);
						num = (short)152174606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)783155200;
						short num4 = num;
						if (dock == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)606273548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1092419605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_898;
					case 15:
						goto IL_27C;
					case 16:
						if (flag)
						{
							num = (short)1801191424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)15007754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (dock == global::System.Windows.Controls.Dock.Left)
						{
							num = (short)1685389319;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2033319956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
						doubleAnimation.Duration = global::System.TimeSpan.FromMilliseconds(250.0);
						doubleAnimation.Completed += b.b;
						num = (short)1335623693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.Popup>.Enumerator enumerator = this.ad.GetEnumerator();
						num = (short)1399062530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (dock == global::System.Windows.Controls.Dock.Top)
						{
							num = (short)994246660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27E;
					case 21:
						if (dock == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)194838531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)861929489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						try
						{
							num = (short)219283461;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::DevComponents.WpfDock.Primitives.b b3;
									if (b3.c() == A_0)
									{
										num = (short)198639619;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)285736966;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_354;
								case 3:
								{
									global::DevComponents.WpfDock.Primitives.b b3;
									b = b3;
									num = (short)585891842;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1941635072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_335;
									}
									continue;
								case 6:
									goto IL_437;
								case 7:
								{
									global::System.Collections.IEnumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)489422849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.Primitives.b b3 = ((global::System.Windows.UIElement)enumerator2.Current) as global::DevComponents.WpfDock.Primitives.b;
									num = (short)464650248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::DevComponents.WpfDock.Primitives.b b3;
									if (b3 != null)
									{
										num = (short)1894711300;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_3E1:
								num = (short)1093861383;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_335:
								goto IL_3E1;
							}
							IL_354:
							IL_437:
							goto IL_7D8;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_459;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_446:
								switch (num2)
								{
								case 0:
									goto IL_4AE;
								case 1:
									disposable.Dispose();
									num = (short)144375808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)616366081;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4B0;
								}
								goto IL_459;
							}
							IL_4AE:
							IL_4B0:
							goto EndFinally_20;
							IL_459:
							global::System.Collections.IEnumerator enumerator2;
							disposable = (enumerator2 as global::System.IDisposable);
							num = (short)436076546;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_446;
							EndFinally_20:;
						}
						goto IL_4B1;
					}
					goto IL_8B;
					IL_4B1:
					doubleAnimation.To = new double?(autoHidePanel.ActualHeight);
					b.BeginAnimation(global::DevComponents.WpfDock.Primitives.a.d, doubleAnimation);
					num = (short)1680736261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7D8:
					global::DevComponents.WpfDock.SplitPanel splitPanel = b.Children[0] as global::DevComponents.WpfDock.SplitPanel;
					A_0.LastAutoHideSize = new global::System.Windows.Size(splitPanel.ActualWidth, splitPanel.ActualHeight);
					b.b(null);
					autoHidePanel = (A_0.Parent as global::DevComponents.WpfDock.AutoHidePanel);
					dock = global::DevComponents.WpfDock.DockSite.GetDock(autoHidePanel);
					num = (short)29818896;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_27C:
				IL_27E:
				doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(0.0, global::System.TimeSpan.FromMilliseconds(250.0));
				b.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, doubleAnimation);
				return;
				IL_4E9:
				goto IL_27E;
				IL_50D:
				return;
				IL_570:
				IL_755:
				this.a(true);
				return;
				IL_796:
				IL_898:
				goto IL_27E;
				IL_8B:
				flag = this.c();
				b = null;
				popup = null;
				num = (short)971374603;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00021E38 File Offset: 0x00020038
		internal static global::DevComponents.WpfDock.DockSite a(global::System.Windows.DependencyObject A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::System.Windows.DependencyObject dependencyObject;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_88;
				case 1:
					goto IL_1A0;
				case 2:
					if (dependencyObject is global::DevComponents.WpfDock.DockSite)
					{
						num2 = (short)269877252;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1905459205;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)1251419156;
					short num3 = num2;
					num2 = (short)1959928852;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_74;
					default:
					{
						num2 = (short)872415232;
						if (num2 != 0)
						{
						}
						if (dependencyObject == null)
						{
							num2 = (short)377421825;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
						num2 = (short)1517355008;
						short num4 = num2;
						num2 = (short)1023475714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 4:
					goto IL_11B;
				case 5:
					if (dependencyObject is global::DevComponents.WpfDock.FloatingWindow)
					{
						goto IL_74;
					}
					goto IL_120;
				case 6:
					goto IL_120;
				}
				goto IL_2C;
				IL_74:
				num2 = (short)1788018688;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_120:
				num2 = (short)1403846659;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_88:
			num2 = (short)2053373953;
			if (num2 != 0)
			{
			}
			return ((global::DevComponents.WpfDock.FloatingWindow)dependencyObject).DockSite;
			IL_11B:
			return dependencyObject as global::DevComponents.WpfDock.DockSite;
			IL_1A0:
			return null;
			IL_2C:
			dependencyObject = A_0;
			num2 = (short)1647968262;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00021FF0 File Offset: 0x000201F0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x000220A8 File Offset: 0x000202A8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public string Layout
		{
			get
			{
				short num = (short)304254664;
				short num2 = num;
				num = (short)1810271944;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1224998912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1888157696;
				if (num != 0)
				{
				}
				num = (short)1471610881;
				if (num != 0)
				{
				}
				return this.b().SaveLayout(this);
			}
			set
			{
				short num = (short)1670652055;
				short num2 = num;
				num = (short)1128013975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1181286400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1760231425;
				if (num != 0)
				{
				}
				num = (short)2108489728;
				if (num != 0)
				{
				}
				this.b().LoadLayout(this, value);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0002215C File Offset: 0x0002035C
		private global::DevComponents.WpfDock.IDockSiteLayoutSerializer b()
		{
			short num = (short)1071120386;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C3;
				case 1:
					goto IL_113;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (this.r != null)
				{
					break;
				}
				num = (short)1689575266;
				short num3 = num;
				num = (short)1214898018;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)703987713;
					if (num != 0)
					{
					}
					num = (short)676200448;
					if (num != 0)
					{
					}
					num = (short)460980224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C3:
				this.r = new global::DevComponents.WpfDock.d();
				num = (short)2119761920;
				short num4 = num;
				num = (short)1851260929;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_113:
			return this.r;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00022284 File Offset: 0x00020484
		private static void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)915867198;
			short num2 = num;
			num = (short)1085867582;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1757020160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)3407872;
			if (num != 0)
			{
			}
			num = (short)1752498177;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfDock.DockSite)A_0).b(A_1.OriginalSource as global::DevComponents.WpfDock.DockWindow);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00022340 File Offset: 0x00020540
		private void b(global::DevComponents.WpfDock.DockWindow A_0)
		{
			short num = (short)2103950638;
			short num2 = num;
			num = (short)1423490350;
			switch (num2 == num)
			{
			default:
			{
				num = (short)692453376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1158414337;
			if (num != 0)
			{
			}
			num = (short)1394212864;
			if (num != 0)
			{
			}
			this.ActiveDockWindow = A_0;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000223F0 File Offset: 0x000205F0
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)430266411;
			short num2 = num;
			num = (short)1546737707;
			switch (num2 == num)
			{
			default:
			{
				num = (short)783810560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1533542401;
			if (num != 0)
			{
			}
			num = (short)347209728;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfDock.DockSite)A_0).a(A_1.OriginalSource as global::DevComponents.WpfDock.DockWindow);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000224B0 File Offset: 0x000206B0
		private void a(global::DevComponents.WpfDock.DockWindow A_0)
		{
			short num = (short)591396866;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9C;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (this.ActiveDockWindow != A_0)
				{
					break;
				}
				num = (short)501640881;
				short num3 = num;
				num = (short)377908913;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)745865216;
					if (num != 0)
					{
					}
					num = (short)9437184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9C:
				num = (short)1717633025;
				if (num != 0)
				{
				}
				this.ActiveDockWindow = null;
				num = (short)1633419264;
				short num4 = num;
				num = (short)814612481;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000225D0 File Offset: 0x000207D0
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0002268C File Offset: 0x0002088C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::DevComponents.WpfDock.DockWindow ActiveDockWindow
		{
			get
			{
				short num = (short)1174131865;
				short num2 = num;
				num = (short)849400985;
				switch (num2 == num)
				{
				default:
				{
					num = (short)991494144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)817168385;
				if (num != 0)
				{
				}
				num = (short)582746112;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfDock.DockWindow)base.GetValue(global::DevComponents.WpfDock.DockSite.ActiveDockWindowProperty);
			}
			internal set
			{
				short num = (short)1460066851;
				short num2 = num;
				num = (short)262724131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2058944512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1542717441;
				if (num != 0)
				{
				}
				num = (short)671612928;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockSite.c, value);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00022740 File Offset: 0x00020940
		public void ChangeColorScheme(global::DevComponents.WpfDock.eDockVisualStyle colorTable)
		{
			short num = (short)1596588033;
			if (num != 0)
			{
			}
			if (global::System.Windows.Application.Current == null)
			{
				for (;;)
				{
					num = (short)1060241408;
					short num2 = num;
					num = (short)1275936318;
					short num3 = num;
					num = (short)1265909310;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_8C;
					}
				}
				IL_8C:
				num = (short)1668284416;
				if (num != 0)
				{
				}
				return;
			}
			global::System.Windows.ResourceDictionary a_ = this.a(colorTable);
			this.a(a_);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00022800 File Offset: 0x00020A00
		private void a(global::System.Windows.ResourceDictionary A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			short num;
			int num3;
			global::System.Windows.ResourceDictionary resourceDictionary;
			for (;;)
			{
				IL_0A:
				num = (short)539820032;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::System.Windows.ResourceDictionary> enumerator;
				switch (num3)
				{
				case 0:
				{
					num = (short)1153957889;
					if (num != 0)
					{
					}
					num = (short)345808096;
					short num4 = num;
					num = (short)1785240800;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E4;
					default:
						num = (short)399179776;
						if (num != 0)
						{
						}
						goto IL_2FF;
					}
					break;
				}
				case 1:
					resourceDictionary = base.Resources;
					num = (short)511049731;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (global::System.Windows.Application.Current == null)
					{
						num = (short)1201405953;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					resourceDictionary = global::System.Windows.Application.Current.Resources;
					num = (short)1340342272;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_2FF;
				case 4:
					try
					{
						num = (short)1945042956;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Windows.ResourceDictionary resourceDictionary2;
							switch (num3)
							{
							case 0:
								goto IL_1FB;
							case 1:
								if (!(resourceDictionary2 is global::DevComponents.WpfDock.themes.Office2007SilverSkin))
								{
									num = (short)138805258;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1D6;
							case 2:
								num = (short)1135542279;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)1077936129;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (!(resourceDictionary2 is global::DevComponents.WpfDock.themes.Office2010SilverSkin))
								{
									num = (short)954335234;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1D6;
							case 5:
								num = (short)714473478;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_294;
							case 7:
								if (resourceDictionary2 is global::DevComponents.WpfDock.themes.Office2010BlackSkin)
								{
									num = (short)1579089929;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 8:
								if (!enumerator.MoveNext())
								{
									num = (short)108199941;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								resourceDictionary2 = enumerator.Current;
								num = (short)1979252750;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								goto IL_1D6;
							case 10:
								num = (short)498204676;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								num = (short)438632461;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								switch (0)
								{
								case 0:
									goto IL_E7;
								}
								continue;
							case 13:
								if (!(resourceDictionary2 is global::DevComponents.WpfDock.themes.Office2007BlueSkin))
								{
									num = (short)1964834819;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1D6;
							case 14:
								if (!(resourceDictionary2 is global::DevComponents.WpfDock.themes.Office2007BlackSkin))
								{
									num = (short)745537547;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1D6;
							}
							IL_120:
							num = (short)517472264;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_E7:
							goto IL_120;
							IL_1D6:
							resourceDictionary.MergedDictionaries.Remove(resourceDictionary2);
							num = (short)717422592;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1FB:
						IL_294:
						goto IL_3E4;
					}
					finally
					{
						num = (short)127401984;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2C9;
								}
								continue;
							case 1:
								goto IL_2FC;
							case 2:
								enumerator.Dispose();
								num = (short)499318785;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2C9:
							if (enumerator == null)
							{
								break;
							}
							num = (short)46596098;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2FC:;
					}
					goto IL_2FF;
				}
				goto IL_4E;
				IL_2FF:
				enumerator = resourceDictionary.MergedDictionaries.GetEnumerator();
				num = (short)1956184068;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_3E4:
			resourceDictionary.MergedDictionaries.Add(A_0);
			return;
			IL_4E:
			resourceDictionary = null;
			num = (short)55246850;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00022C1C File Offset: 0x00020E1C
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				short num = (short)387118581;
				short num2 = num;
				num = (short)1599534581;
				switch (num2 == num)
				{
				}
				num = (short)1233911809;
				if (num != 0)
				{
				}
				num = (short)1224933376;
				if (num != 0)
				{
				}
				num = (short)1271922688;
				short num3 = num;
				return this.d.GetEnumerator();
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00022CD0 File Offset: 0x00020ED0
		public void ChangeColorScheme(global::DevComponents.WpfDock.eDockVisualStyle baseColorTable, global::System.Windows.Media.Color baseColor)
		{
			short num;
			while (global::System.Windows.Application.Current != null)
			{
				num = (short)50034526;
				short num2 = num;
				num = (short)1950971742;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1868234752;
					if (num != 0)
					{
					}
					num = (short)1370226689;
					if (num != 0)
					{
					}
					global::System.Windows.ResourceDictionary a_ = this.CreateColorScheme(baseColorTable, baseColor);
					this.a(a_);
					return;
				}
				}
			}
			num = (short)811270144;
			short num3 = num;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00022D94 File Offset: 0x00020F94
		public global::System.Windows.ResourceDictionary CreateColorScheme(global::DevComponents.WpfDock.eDockVisualStyle baseColorTable, global::System.Windows.Media.Color baseColor)
		{
			short num = (short)623425709;
			short num2 = num;
			num = (short)823310509;
			switch (num2 == num)
			{
			}
			num = (short)1605304321;
			if (num != 0)
			{
			}
			num = (short)1980170240;
			if (num != 0)
			{
			}
			num = (short)1368981504;
			short num3 = num;
			global::System.Windows.ResourceDictionary a_ = this.a(baseColorTable);
			return this.a(a_, baseColor);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00022E50 File Offset: 0x00021050
		private global::System.Windows.ResourceDictionary a(global::DevComponents.WpfDock.eDockVisualStyle A_0)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_9D;
			}
			int num;
			global::System.Windows.ResourceDictionary result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = new global::DevComponents.WpfDock.themes.Office2007BlackSkin();
					num2 = (short)1913520128;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					result = new global::DevComponents.WpfDock.themes.Office2010SilverSkin();
					num2 = (short)1318322208;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					result = new global::DevComponents.WpfDock.themes.Office2007BlueSkin();
					num2 = (short)1969553427;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					result = new global::DevComponents.WpfDock.themes.Office2010BlackSkin();
					num2 = (short)2025455628;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (A_0 == global::DevComponents.WpfDock.eDockVisualStyle.Office2007Fireman)
					{
						num2 = (short)657195009;
						if (num2 != 0)
						{
						}
						num2 = (short)952107015;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1257177105;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					result = new global::DevComponents.WpfDock.themes.Office2007FullColorSkin();
					num2 = (short)1826619418;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					result = new global::DevComponents.WpfDock.themes.Office2007FiremanSkin();
					num2 = (short)2107113499;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					result = new global::DevComponents.WpfDock.themes.Office2010BlueSkin();
					num2 = (short)1941831704;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					result = new global::DevComponents.WpfDock.themes.Office2007SilverSkin();
					num2 = (short)536215568;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					result = new global::DevComponents.WpfDock.themes.Office2007PoliceSkin();
					num2 = (short)1617362962;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					result = new global::DevComponents.WpfDock.themes.Office2007MilitarySkin();
					num2 = (short)691273750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_197;
				case 13:
					if (A_0 == global::DevComponents.WpfDock.eDockVisualStyle.Office2010Black)
					{
						num2 = (short)1120665604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)487194652;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (A_0 == global::DevComponents.WpfDock.eDockVisualStyle.Office2007Black)
					{
						num2 = (short)629080065;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2123497501;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (A_0 == global::DevComponents.WpfDock.eDockVisualStyle.Office2007Military)
					{
						num2 = (short)1385234443;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)86835205;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_200;
				case 17:
				{
					num2 = (short)386291241;
					short num3 = num2;
					num2 = (short)1402295849;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_462;
					default:
						num2 = (short)876609536;
						if (num2 != 0)
						{
						}
						if (A_0 == global::DevComponents.WpfDock.eDockVisualStyle.Office2007FullColor)
						{
							num2 = (short)452657158;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2C4;
					}
					break;
				}
				case 18:
					goto IL_1BB;
				case 19:
					return result;
				case 20:
					if (A_0 == global::DevComponents.WpfDock.eDockVisualStyle.Office2007Classic)
					{
						num2 = (short)152633367;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1616248863;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					if (A_0 == global::DevComponents.WpfDock.eDockVisualStyle.Office2007Silver)
					{
						num2 = (short)487260169;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1230831636;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					return result;
				case 23:
					result = new global::DevComponents.WpfDock.themes.Office2007ClassicSkin();
					num2 = (short)1193148441;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					goto IL_153;
				case 25:
					goto IL_131;
				case 26:
					goto IL_1DE;
				case 27:
					goto IL_175;
				case 28:
				{
					num2 = (short)466354176;
					short num4 = num2;
					if (A_0 == global::DevComponents.WpfDock.eDockVisualStyle.Office2010Blue)
					{
						num2 = (short)479723528;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1646395406;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 29:
					if (A_0 == global::DevComponents.WpfDock.eDockVisualStyle.Office2007Blue)
					{
						num2 = (short)1425801219;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_462;
				case 30:
					if (A_0 == global::DevComponents.WpfDock.eDockVisualStyle.Office2010Silver)
					{
						num2 = (short)1147600898;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1889861645;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (A_0 == global::DevComponents.WpfDock.eDockVisualStyle.Office2007Police)
					{
						num2 = (short)424869898;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)954793999;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					return result;
				}
				goto IL_9D;
				IL_462:
				num2 = (short)1442381845;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_131:
			IL_153:
			IL_175:
			IL_197:
			IL_1BB:
			IL_1DE:
			IL_200:
			return result;
			IL_2C4:
			throw new global::System.ComponentModel.InvalidEnumArgumentException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("諈꓊ꇌꃎꏐꇔ뛖믘럚룜￞迠賢釤쟦蟨蓪駬쿮菰雲雴飶黸闺铼藾搀朂", a_));
			IL_9D:
			result = null;
			num2 = (short)34799646;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000233A8 File Offset: 0x000215A8
		private global::System.Windows.ResourceDictionary a(global::System.Windows.ResourceDictionary A_0, global::System.Windows.Media.Color A_1)
		{
			short num = (short)900268033;
			if (num != 0)
			{
			}
			num = (short)1366228992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)587071488;
				short num3 = num;
				global::DevComponents.WpfDock.a a = this.a(A_1);
				global::System.Collections.IEnumerator enumerator = A_0.Keys.GetEnumerator();
				try
				{
					num = (short)1748631558;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						object obj;
						global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
						object obj2;
						switch (num2)
						{
						case 0:
							if (!(obj as global::System.Windows.ComponentResourceKey).ResourceId.ToString().StartsWith(global::DevComponents.WpfDock.DockColors.DockButtonClass))
							{
								num = (short)993787909;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
							try
							{
								num = (short)435683330;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)3866627;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.Media.GradientStop gradientStop = enumerator2.Current;
										gradientStop.Color = a.b(gradientStop.Color);
										num = (short)2014511105;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_324;
										}
										continue;
									case 3:
										num = (short)556204036;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_3AD;
									}
									IL_326:
									num = (short)1588264960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_324:
									goto IL_326;
								}
								IL_3AD:
								break;
							}
							finally
							{
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_3C0;
						case 2:
							if (!enumerator.MoveNext())
							{
								num = (short)1093206020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							obj = enumerator.Current;
							obj2 = null;
							num = (short)549781512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_2A2;
						case 4:
							num = (short)1480654859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_F4;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_EF;
							}
							continue;
						case 7:
							enumerator2 = (obj2 as global::System.Windows.Media.LinearGradientBrush).GradientStops.GetEnumerator();
							num = (short)486604801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (obj is global::System.Windows.ComponentResourceKey)
							{
								num = (short)241827856;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F4;
						case 9:
							if (obj2 is global::System.Windows.Media.LinearGradientBrush)
							{
								num = (short)2039742471;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2073165834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (obj2 is global::System.Windows.Media.RadialGradientBrush)
							{
								num = (short)1225654275;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 11:
							goto IL_544;
						case 12:
							try
							{
								num = (short)1263468546;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
										num = (short)54067204;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_175;
										}
										continue;
									case 3:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)1986789377;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.Media.GradientStop gradientStop2 = enumerator2.Current;
										gradientStop2.Color = a.b(gradientStop2.Color);
										num = (short)1393360896;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_1FF;
									}
									IL_1AB:
									num = (short)1533935619;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_175:
									goto IL_1AB;
								}
								IL_1FF:
								break;
							}
							finally
							{
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_212;
						case 13:
							if (obj2 is global::System.Windows.Media.SolidColorBrush)
							{
								num = (short)1764950030;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1388052489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_3C0;
						case 15:
						{
							num = (short)806085418;
							short num4 = num;
							num = (short)2108875562;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2A2;
							default:
								num = (short)473563136;
								if (num != 0)
								{
								}
								break;
							}
							break;
						}
						case 16:
							goto IL_212;
						}
						goto IL_EF;
						IL_F4:
						obj2 = A_0[obj];
						num = (short)117702669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_212:
						num = (short)936640512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2A2:
						enumerator2 = (obj2 as global::System.Windows.Media.RadialGradientBrush).GradientStops.GetEnumerator();
						num = (short)639500300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2A7:
						num = (short)2046951426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_EF:
						goto IL_2A7;
						IL_3C0:
						global::System.Windows.Media.SolidColorBrush solidColorBrush = obj2 as global::System.Windows.Media.SolidColorBrush;
						solidColorBrush.Color = a.b(solidColorBrush.Color);
						num = (short)494665743;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_544:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_563;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_550:
						switch (num2)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)322830337;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5BA;
						case 1:
							disposable.Dispose();
							num = (short)503644162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_5B8;
						}
						goto IL_563;
					}
					IL_5B8:
					IL_5BA:
					goto EndFinally_18;
					IL_563:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1467809792;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_550;
					EndFinally_18:;
				}
				return A_0;
			}
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000239C0 File Offset: 0x00021BC0
		private global::DevComponents.WpfDock.a a(global::System.Windows.Media.Color A_0)
		{
			short num = (short)977928193;
			if (num != 0)
			{
			}
			num = (short)786694144;
			short num2 = num;
			num = (short)1716754073;
			short num3 = num;
			num = (short)1369151129;
			switch (num3 == num)
			{
			}
			num = (short)1247936512;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfDock.b(A_0);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00023A70 File Offset: 0x00021C70
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00023B28 File Offset: 0x00021D28
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Browsable(false)]
		public string LicenseKey
		{
			get
			{
				short num = (short)89887202;
				short num2 = num;
				num = (short)133599714;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1233059840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1970274305;
				if (num != 0)
				{
				}
				num = (short)157810688;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfDock.DockSite.LicenseKeyProperty);
			}
			set
			{
				short num = (short)1409613825;
				if (num != 0)
				{
				}
				num = (short)687669248;
				short num2 = num;
				num = (short)356671002;
				short num3 = num;
				num = (short)2055101978;
				switch (num3 == num)
				{
				}
				num = (short)748879872;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockSite.LicenseKeyProperty, value);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00023BDC File Offset: 0x00021DDC
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1819279361;
			if (num != 0)
			{
			}
			num = (short)1045561344;
			short num2 = num;
			num = (short)1499009338;
			short num3 = num;
			num = (short)2126385466;
			switch (num3 == num)
			{
			}
			num = (short)1838546944;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfDock.DockSite)A_0).a();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00023C94 File Offset: 0x00021E94
		private void a()
		{
			short num = (short)1068199597;
			short num2 = num;
			num = (short)1017671341;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1203109888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2026242049;
			if (num != 0)
			{
			}
			num = (short)1837629440;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.j.a(this.LicenseKey);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00023D4C File Offset: 0x00021F4C
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			global::System.Windows.Media.Brush background;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!global::DevComponents.WpfDock.j.c)
					{
						num2 = (short)853803013;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1415768962;
					short num3 = num2;
					num2 = (short)639298434;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1054277633;
						if (num2 != 0)
						{
						}
						num2 = (short)222625792;
						short num4 = num2;
						num2 = (short)277807104;
						if (num2 != 0)
						{
						}
						dc.DrawRectangle(background, null, new global::System.Windows.Rect(0.0, 0.0, base.RenderSize.Width, base.RenderSize.Height));
						break;
					}
					}
					num2 = (short)749469698;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_1A7;
				case 3:
					return;
				case 4:
					if (background != null)
					{
						num2 = (short)2066874369;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A7;
				case 5:
				{
					global::System.Windows.Media.FormattedText formattedText = new global::System.Windows.Media.FormattedText(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("胋ꟍ돏럑뫓ꗕ뷗龎닛뇝铟싡苣觥鷧蓩裫샭탯ꇱ釳鏵\ud8f7뻹鏻諽仿朁瀃䐅椇砉Ⰻ栍缏怑㐓䄕䠗尙㰛氝䔟䔡䴣唥尧堩䴫娭夯崱娳ᘵ唷弹伻䴽ℿ╁⅃晅⹇╉㹋湍ㅏㅑ⁓㽕⹗㭙⡛㝝ཟౡ䑣ɥ൧ṩ൫ݭᱯű婳", a_), global::System.Globalization.CultureInfo.CurrentCulture, global::System.Windows.FlowDirection.LeftToRight, new global::System.Windows.Media.Typeface(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("跋볍맏돑룓", a_)), 9.0, global::System.Windows.Media.Brushes.Maroon);
					dc.DrawText(formattedText, new global::System.Windows.Point((base.RenderSize.Width - formattedText.Width) / 2.0, (base.RenderSize.Height - formattedText.Height) / 2.0));
					num2 = (short)1342373891;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_31;
				IL_1A7:
				num2 = (short)7798784;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_31:
			background = base.Background;
			num2 = (short)1286930436;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00023F94 File Offset: 0x00022194
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00024044 File Offset: 0x00022244
		internal global::DevComponents.WpfDock.IDockOperations DockOperations
		{
			get
			{
				short num = (short)644560769;
				short num2 = num;
				num = (short)777402241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)68681728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1405353984;
				if (num != 0)
				{
				}
				num = (short)118816769;
				if (num != 0)
				{
				}
				return this.w;
			}
			set
			{
				short num = (short)1213399041;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.w = value;
						goto IL_A4;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						goto IL_E6;
					}
					IL_31:
					if (this.w == value)
					{
						return;
					}
					num = (short)2074254031;
					short num3 = num;
					num = (short)495033039;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1316749312;
						if (num != 0)
						{
						}
						num = (short)97386496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A4:
					num = (short)934871040;
					short num4 = num;
					num = (short)1563164674;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E6:
				num = (short)460062721;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00024164 File Offset: 0x00022364
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)105447430;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)84780749;
				short num3 = num;
				num = (short)1362011853;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)419954688;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_1A3;
					case 1:
						num = (short)1073283077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						this.c(global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftShift) || global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightShift));
						A_1.Handled = true;
						num = (short)1457324032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_CE;
					case 4:
						num = (short)1840054275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
						{
							num = (short)581959681;
							if (num != 0)
							{
							}
							num = (short)583991303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 7:
						goto IL_153;
					}
					IL_8F:
					if (A_1.Key == global::System.Windows.Input.Key.Tab)
					{
						num = (short)730398724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_CE:
				if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
				{
					num = (short)325386241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_153:
				num = (short)1632305154;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1A3:
			num = (short)52625408;
			short num4 = num;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00024344 File Offset: 0x00022544
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)141754373;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1550301628;
				short num3 = num;
				num = (short)314096060;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1215299584;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_F0;
					case 1:
						goto IL_158;
					case 2:
						goto IL_178;
					case 3:
						num = (short)836501505;
						if (num != 0)
						{
						}
						num = (short)2083389446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						this.ReleaseDockSelectorAdorner(false);
						num = (short)625278978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_8A;
						}
						continue;
					case 6:
						if (A_1.Key == global::System.Windows.Input.Key.RightCtrl)
						{
							num = (short)1261830145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1973223424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8A:
					if (A_1.Key != global::System.Windows.Input.Key.LeftCtrl)
					{
						num = (short)51052547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_117;
				}
				IL_F0:
				if (A_1.Key != global::System.Windows.Input.Key.Escape)
				{
					return;
				}
				num = (short)298450948;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_117:
			this.ReleaseDockSelectorAdorner(true);
			return;
			IL_158:
			goto IL_117;
			IL_178:
			num = (short)53411840;
			short num4 = num;
		}

		// Token: 0x04000086 RID: 134
		public static readonly global::System.Windows.DependencyProperty MinimumDocumentAreaSizeProperty;

		// Token: 0x04000087 RID: 135
		public static readonly global::System.Windows.DependencyProperty VisualStyleProperty;

		// Token: 0x04000088 RID: 136
		private static readonly global::System.Windows.DependencyPropertyKey a;

		// Token: 0x04000089 RID: 137
		public static readonly global::System.Windows.DependencyProperty EffectiveStyleProperty;

		// Token: 0x0400008A RID: 138
		public static readonly global::System.Windows.DependencyProperty KeyboardNavigationEnabledProperty;

		// Token: 0x0400008B RID: 139
		public static readonly global::System.Windows.DependencyProperty DockProperty;

		// Token: 0x0400008C RID: 140
		public static readonly global::System.Windows.DependencyProperty IsDocumentProperty;

		// Token: 0x0400008D RID: 141
		public static readonly global::System.Windows.DependencyProperty SaveLayoutProperty;

		// Token: 0x0400008E RID: 142
		public static readonly global::System.Windows.DependencyProperty DockSizeProperty;

		// Token: 0x0400008F RID: 143
		private static readonly global::System.Windows.DependencyPropertyKey b;

		// Token: 0x04000090 RID: 144
		public static readonly global::System.Windows.DependencyProperty SplitPanelsProperty;

		// Token: 0x04000091 RID: 145
		private static readonly global::System.Windows.DependencyPropertyKey c;

		// Token: 0x04000092 RID: 146
		public static readonly global::System.Windows.DependencyProperty ActiveDockWindowProperty;

		// Token: 0x04000097 RID: 151
		public static readonly global::System.Windows.DependencyProperty LicenseKeyProperty;

		// Token: 0x04000098 RID: 152
		public static readonly global::System.Windows.DependencyProperty DockHintOverlayProperty;

		// Token: 0x04000099 RID: 153
		public static readonly global::System.Windows.DependencyProperty DockSelectorOverlayProperty;

		// Token: 0x0400009B RID: 155
		public static readonly global::System.Windows.DependencyProperty AutoHidePopupOverlayProperty;

		// Token: 0x0400009C RID: 156
		public static readonly global::System.Windows.DependencyProperty SelectorCycleAllWindowsProperty;

		// Token: 0x0400009D RID: 157
		public static readonly global::System.Windows.DependencyProperty IsAnimationEnabledProperty;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Controls.UIElementCollection d;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Rect e;

		// Token: 0x040000A0 RID: 160
		private bool f;

		// Token: 0x040000A1 RID: 161
		private global::DevComponents.WpfDock.g g;

		// Token: 0x040000A2 RID: 162
		private global::DevComponents.WpfDock.DockWindowGroup h;

		// Token: 0x040000A3 RID: 163
		private bool i;

		// Token: 0x040000A4 RID: 164
		private global::DevComponents.WpfDock.Primitives.d j;

		// Token: 0x040000A5 RID: 165
		private global::DevComponents.WpfDock.Primitives.a k;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.UIElement l;

		// Token: 0x040000A7 RID: 167
		private global::DevComponents.WpfDock.DockSite.a m;

		// Token: 0x040000A8 RID: 168
		private global::DevComponents.WpfDock.AutoHidePanel n;

		// Token: 0x040000A9 RID: 169
		private global::DevComponents.WpfDock.AutoHidePanel o;

		// Token: 0x040000AA RID: 170
		private global::DevComponents.WpfDock.AutoHidePanel p;

		// Token: 0x040000AB RID: 171
		private global::DevComponents.WpfDock.AutoHidePanel q;

		// Token: 0x040000AC RID: 172
		private global::DevComponents.WpfDock.IDockSiteLayoutSerializer r;

		// Token: 0x040000AD RID: 173
		private const int s = 350;

		// Token: 0x040000AE RID: 174
		private global::System.Collections.Generic.List<global::DevComponents.WpfDock.FloatingWindow> t = new global::System.Collections.Generic.List<global::DevComponents.WpfDock.FloatingWindow>();

		// Token: 0x040000AF RID: 175
		private global::DevComponents.WpfDock.DockLocalization u = new global::DevComponents.WpfDock.DockLocalization();

		// Token: 0x040000B0 RID: 176
		private global::DevComponents.WpfDock.Primitives.c v;

		// Token: 0x040000B1 RID: 177
		private global::DevComponents.WpfDock.IDockOperations w;

		// Token: 0x040000B2 RID: 178
		private global::DevComponents.WpfDock.f x;

		// Token: 0x040000B3 RID: 179
		private global::DevComponents.WpfDock.f y;

		// Token: 0x040000B4 RID: 180
		private bool z;

		// Token: 0x040000B5 RID: 181
		private bool aa;

		// Token: 0x040000B6 RID: 182
		private bool ab;

		// Token: 0x040000B7 RID: 183
		private bool ac;

		// Token: 0x040000B8 RID: 184
		private global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.Popup> ad = new global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.Popup>();

		// Token: 0x0200001A RID: 26
		private class a
		{
			// Token: 0x040000B9 RID: 185
			public global::DevComponents.WpfDock.h a = global::DevComponents.WpfDock.h.a;

			// Token: 0x040000BA RID: 186
			public global::DevComponents.WpfDock.SplitPanel b;

			// Token: 0x040000BB RID: 187
			public global::System.Windows.Rect c;

			// Token: 0x040000BC RID: 188
			public global::DevComponents.WpfDock.DockWindowGroup d;
		}
	}
}
