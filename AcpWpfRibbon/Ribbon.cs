using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using DevComponents.WpfRibbon.Converters;
using DevComponents.WpfRibbon.themes;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000071 RID: 113
	[global::System.ComponentModel.ToolboxItem(true)]
	[global::System.Windows.TemplatePart(Name = "PART_RibbonPanelBorder", Type = typeof(global::System.Windows.Controls.Decorator))]
	public class Ribbon : global::System.Windows.Controls.Primitives.Selector, global::DevComponents.WpfRibbon.IPopupParentControl
	{
		// Token: 0x0600056B RID: 1387 RVA: 0x000775E8 File Offset: 0x000757E8
		public static global::DevComponents.WpfRibbon.eRibbonVisualStyle GetVisualStyle(global::System.Windows.DependencyObject target)
		{
			short num = (short)2131099648;
			short num2 = num;
			num = (short)1906704385;
			if (num != 0)
			{
			}
			num = (short)18107686;
			short num3 = num;
			num = (short)1289833766;
			switch (num3 == num)
			{
			}
			num = (short)35913728;
			if (num != 0)
			{
			}
			return (global::DevComponents.WpfRibbon.eRibbonVisualStyle)target.GetValue(global::DevComponents.WpfRibbon.Ribbon.VisualStyleProperty);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000776A4 File Offset: 0x000758A4
		public static void SetVisualStyle(global::System.Windows.DependencyObject target, global::DevComponents.WpfRibbon.eRibbonVisualStyle value)
		{
			short num = (short)824967168;
			short num2 = num;
			num = (short)1705351287;
			short num3 = num;
			num = (short)1676777591;
			switch (num3 == num)
			{
			}
			num = (short)581369856;
			if (num != 0)
			{
			}
			num = (short)531759105;
			if (num != 0)
			{
			}
			target.SetValue(global::DevComponents.WpfRibbon.Ribbon.VisualStyleProperty, value);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00077760 File Offset: 0x00075960
		private static void OnVisualStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1605763072;
			short num2 = num;
			num = (short)1084664470;
			short num3 = num;
			num = (short)1863035542;
			switch (num3 == num)
			{
			}
			num = (short)42467328;
			if (num != 0)
			{
			}
			num = (short)1558118401;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.Ribbon.OnVisualStyleChanged(o, (global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.OldValue, (global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.NewValue);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00077828 File Offset: 0x00075A28
		private static void OnVisualStyleChanged(global::System.Windows.DependencyObject o, global::DevComponents.WpfRibbon.eRibbonVisualStyle oldValue, global::DevComponents.WpfRibbon.eRibbonVisualStyle newValue)
		{
			short num = (short)1546846211;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfRibbon.Ribbon ribbon;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_CD;
				case 1:
					if (newValue != global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Silver)
					{
						num = (short)399966214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_91;
				case 2:
					num = (short)321716225;
					if (num != 0)
					{
					}
					ribbon = (global::DevComponents.WpfRibbon.Ribbon)o;
					ribbon.ChangeColorScheme(newValue);
					num = (short)1903755265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 4:
					num = (short)1531379720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					num = (short)889585671;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)1446728702;
					short num3 = num;
					num = (short)1147163646;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2100756480;
						if (num != 0)
						{
						}
						if (newValue == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Blue)
						{
							goto IL_91;
						}
						break;
					}
					num = (short)2113470468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
				{
					if (newValue == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Black)
					{
						num = (short)755105792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					ribbon.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007;
					num = (short)1032781824;
					short num4 = num;
					num = (short)1941438469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_49:
				if (!(o is global::DevComponents.WpfRibbon.Ribbon))
				{
					return;
				}
				num = (short)1307181058;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_91:
			ribbon.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010;
			return;
			IL_CD:
			goto IL_91;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00077A18 File Offset: 0x00075C18
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00077AC8 File Offset: 0x00075CC8
		public global::DevComponents.WpfRibbon.eRibbonVisualStyle VisualStyle
		{
			get
			{
				short num = (short)950140928;
				short num2 = num;
				num = (short)2042494977;
				if (num != 0)
				{
				}
				num = (short)85890569;
				short num3 = num;
				num = (short)667457033;
				switch (num3 == num)
				{
				}
				num = (short)295698432;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfRibbon.Ribbon.GetVisualStyle(this);
			}
			set
			{
				short num = (short)242221056;
				short num2 = num;
				num = (short)757858305;
				if (num != 0)
				{
				}
				num = (short)61055234;
				short num3 = num;
				num = (short)867606786;
				switch (num3 == num)
				{
				}
				num = (short)967442432;
				if (num != 0)
				{
				}
				global::DevComponents.WpfRibbon.Ribbon.SetVisualStyle(this, value);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00077B7C File Offset: 0x00075D7C
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00077C38 File Offset: 0x00075E38
		public global::DevComponents.WpfRibbon.eEffectiveStyle EffectiveStyle
		{
			get
			{
				short num = (short)1940652032;
				short num2 = num;
				num = (short)1283931251;
				short num3 = num;
				num = (short)1100954739;
				switch (num3 == num)
				{
				}
				num = (short)870449152;
				if (num != 0)
				{
				}
				num = (short)13303809;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eEffectiveStyle)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.EffectiveStyleProperty);
			}
			internal set
			{
				short num = (short)1386676224;
				short num2 = num;
				num = (short)1148766639;
				short num3 = num;
				num = (short)1467271599;
				switch (num3 == num)
				{
				}
				num = (short)1885208576;
				if (num != 0)
				{
				}
				num = (short)1989017601;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.EffectiveStylePropertyKey, value);
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00077CF4 File Offset: 0x00075EF4
		private static void OnEffectiveStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfRibbon.Ribbon ribbon;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					ribbon.OnEffectiveStyleChanged((global::DevComponents.WpfRibbon.eEffectiveStyle)e.OldValue, (global::DevComponents.WpfRibbon.eEffectiveStyle)e.NewValue);
					num2 = (short)968118624;
					short num3 = num2;
					num2 = (short)700993888;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
					{
						num2 = (short)1525284864;
						short num4 = num2;
						num2 = (short)715849728;
						if (num2 != 0)
						{
						}
						num2 = (short)1495465984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (ribbon != null)
					{
						goto IL_3D;
					}
					return;
				}
				goto IL_1C;
				IL_3D:
				num2 = (short)1231618049;
				if (num2 != 0)
				{
				}
				num2 = (short)1697185793;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			ribbon = (o as global::DevComponents.WpfRibbon.Ribbon);
			num2 = (short)244973570;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00077E2C File Offset: 0x0007602C
		protected virtual void OnEffectiveStyleChanged(global::DevComponents.WpfRibbon.eEffectiveStyle oldValue, global::DevComponents.WpfRibbon.eEffectiveStyle newValue)
		{
			short num = (short)486408192;
			short num2 = num;
			num = (short)456392705;
			if (num != 0)
			{
			}
			num = (short)1739535371;
			short num3 = num;
			num = (short)1306735627;
			switch (num3 == num)
			{
			}
			num = (short)799997952;
			if (num != 0)
			{
			}
			this.UpdateRibbonWindowGlass();
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00077ED8 File Offset: 0x000760D8
		private void UpdateRibbonWindowGlass()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfRibbon.RibbonWindow ribbonWindow;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					ribbonWindow.UpdateGlass();
					num2 = (short)515309569;
					if (num2 != 0)
					{
					}
					num2 = (short)1401316545;
					short num3 = num2;
					num2 = (short)479356097;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_42;
					default:
					{
						num2 = (short)950140928;
						short num4 = num2;
						num2 = (short)1821048832;
						if (num2 != 0)
						{
						}
						num2 = (short)771424256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (ribbonWindow != null)
					{
						goto IL_42;
					}
					return;
				}
				goto IL_1C;
				IL_42:
				num2 = (short)541196289;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			ribbonWindow = (global::System.Windows.Window.GetWindow(this) as global::DevComponents.WpfRibbon.RibbonWindow);
			num2 = (short)338100226;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00078000 File Offset: 0x00076200
		static Ribbon()
		{
			int a_ = 10;
			short num = (short)282800278;
			short num2 = num;
			num = (short)493105302;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2069430272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1857486848;
			if (num != 0)
			{
			}
			num = (short)1539375105;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.Ribbon.VisualStyleProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㑡ൣᕥᵧ୩k㵭ѯୱᡳ፵", a_), typeof(global::DevComponents.WpfRibbon.eRibbonVisualStyle), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Blue, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Ribbon.OnVisualStyleChanged)));
			global::DevComponents.WpfRibbon.Ribbon.EffectiveStylePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❡ɣe൧३ᡫݭٯ᝱❳ɵŷᙹ᥻", a_), typeof(global::DevComponents.WpfRibbon.eEffectiveStyle), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Ribbon.OnEffectiveStyleChanged)));
			global::DevComponents.WpfRibbon.Ribbon.EffectiveStyleProperty = global::DevComponents.WpfRibbon.Ribbon.EffectiveStylePropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Ribbon.ToggleRibbonMinimize = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㙡ୣťཧ٩५㱭᥯ၱᙳ᥵ᙷ㝹ᕻၽﲅ", a_), typeof(global::DevComponents.WpfRibbon.Ribbon));
			global::DevComponents.WpfRibbon.Ribbon._IsLivePreviewActive = false;
			global::DevComponents.WpfRibbon.Ribbon._PopupAllowsTransparency = true;
			global::DevComponents.WpfRibbon.Ribbon.s_ShowKeyboardCues = null;
			global::DevComponents.WpfRibbon.Ribbon.SystemAddToQatMenuItem = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅡᵣᕥᱧཀྵū⽭ᑯᙱ⁳᥵⥷᭹ࡻ㍽쾅ﲇ", a_);
			global::DevComponents.WpfRibbon.Ribbon.SystemRemoveFromQatMenuItem = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅡᵣᕥᱧཀྵū㱭ᕯά᭳uᵷ㱹๻ᅽ펁얇ﮍ\ud98fﮕ", a_);
			global::DevComponents.WpfRibbon.Ribbon.SystemCustomizeQatMenuItem = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅡᵣᕥᱧཀྵū⵭կűs᥵ᕷ፹ٻ᭽텿쮅曆잍煉", a_);
			global::DevComponents.WpfRibbon.Ribbon.SystemQatChangePlacementMenuItem = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅡᵣᕥᱧཀྵū㽭ᅯٱ㝳ṵ᥷ᑹ᭻᭽큿\udc91ﮕﶗ", a_);
			global::DevComponents.WpfRibbon.Ribbon.SystemQatMinMaxRibbonMenuItem = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅡᵣᕥᱧཀྵū㽭ᅯٱ㥳ήᙷ㝹ᵻٽ퉿솋ﺏ\udd93ﶗ", a_);
			global::DevComponents.WpfRibbon.Ribbon.SysQatCustomizeContextMenu = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅡᵣᕥᱧཀྵū㽭ᅯٱ㝳͵୷๹፻፽얅\ud993", a_);
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.Ribbon)));
			global::DevComponents.WpfRibbon.Ribbon.WindowBorderThicknessProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㕡ൣࡥ౧թ᭫ⱭὯqၳ፵੷⹹ᑻ᝽ﮇ黎", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Thickness(3.0, 0.0, 3.0, 0.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Ribbon.WindowBorderThicknessChanged)));
			global::DevComponents.WpfRibbon.Ribbon.HorizontalWindowBorderThicknessPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩡ୣᑥŧၩͫmѯ፱ᡳⅵᅷᑹ᡻ᅽ삁ﺋ\uda8dﮑﶕﾙ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness)));
			global::DevComponents.WpfRibbon.Ribbon.HorizontalWindowBorderThicknessProperty = global::DevComponents.WpfRibbon.Ribbon.HorizontalWindowBorderThicknessPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Ribbon.ApplicationMenuProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍡ᑣᙥѧͩཫ཭ѯ᭱᭳ᡵ㕷όቻ୽", a_), typeof(global::System.Windows.UIElement), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Ribbon.OnApplicationMenuChanged)));
			global::DevComponents.WpfRibbon.Ribbon.QuickAccessToolbarProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㍡ᅣཥ୧ũ⵫൭፯᝱ݳյⱷᕹ፻ች", a_), typeof(global::System.Windows.UIElement), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Ribbon.OnQuickAccessToolbarChanged)));
			global::DevComponents.WpfRibbon.Ribbon.IsQuickAccessToolbarBelowProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭡ᝣ㝥ᵧͩཫխㅯᅱᝳ፵୷ॹ⡻ᅽ慎좉ﾏ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Ribbon.OnIsQuickAccessToolbarBelowChanged)));
			global::DevComponents.WpfRibbon.Ribbon.SelectedContentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅡţ੥൧३ᡫ୭ᑯㅱ᭳ᡵ౷όቻ੽", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.Ribbon.SelectedContentProperty = global::DevComponents.WpfRibbon.Ribbon.SelectedContentPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Ribbon.IsRibbonMenuOpenProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭡ᝣ㑥ŧࡩ๫ŭṯ㽱ᅳᡵ൷㕹౻᭽", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Ribbon.IsRibbonMenuOpenChanged)));
			global::DevComponents.WpfRibbon.Ribbon.IsMinimizedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭡ᝣ⭥ŧѩիͭ᥯ࡱᅳት", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Ribbon.IsMinimizedChanged)));
			global::DevComponents.WpfRibbon.Ribbon.AutoExpandProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍡ᅣብݧ⽩ᑫṭᅯᱱၳ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfRibbon.Ribbon.CanDialogCustomizeQatProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ⅡգࡥⱧͩ൫ɭὯᕱ㝳͵୷๹፻፽힅ﺉ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfRibbon.Ribbon.CanChangeQatPlacementProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅱգࡥ⭧ɩ൫mᝯ᝱╳᝵౷⩹ၻώﺉ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfRibbon.Ribbon.UseSpecKeyTipPositioningProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝡ᝣͥ㭧ᩩ५൭㭯᝱൳≵ᅷ੹ⱻᅽ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfRibbon.Ribbon.AutoHideRibbonContentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍡ᅣብݧ≩ի੭ᕯⁱᵳᑵ᩷ᕹቻ㵽ﺉ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfRibbon.Ribbon.AutoHideTriggerSizeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍡ᅣብݧ≩ի੭ᕯ♱ٳήίᵹ᥻౽퍿ﺃ", a_), typeof(global::System.Windows.Size), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Size(300.0, 250.0)));
			global::DevComponents.WpfRibbon.Ribbon.IsActiveProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭡ᝣ❥୧ṩիᡭᕯ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfRibbon.Ribbon.SystemButtonsProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅡᵣᕥᱧཀྵūⱭկٱs᥵ᙷॹ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfRibbon.Ribbon.LicenseKeyProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⹡ൣե൧ѩὫ୭㭯᝱൳", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Ribbon.OnLicenseKeyChanged)));
			global::DevComponents.WpfRibbon.Ribbon.SelectedContentTemplatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅡţ੥൧३ᡫ୭ᑯㅱ᭳ᡵ౷όቻ੽푿", a_), typeof(global::System.Windows.DataTemplate), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.Ribbon.SelectedContentTemplateProperty = global::DevComponents.WpfRibbon.Ribbon.SelectedContentTemplatePropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Ribbon.SelectedContentTemplateSelectorPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅡţ੥൧३ᡫ୭ᑯㅱ᭳ᡵ౷όቻ੽푿쎏ﮗ", a_), typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.Ribbon.SelectedContentTemplateSelectorProperty = global::DevComponents.WpfRibbon.Ribbon.SelectedContentTemplateSelectorPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Ribbon.ContentTemplateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅱୣࡥᱧཀྵɫᩭ⑯᝱ᥳٵᑷ᭹ࡻ᭽", a_), typeof(global::System.Windows.DataTemplate), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.Ribbon.ContentTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅱୣࡥᱧཀྵɫᩭ⑯᝱ᥳٵᑷ᭹ࡻ᭽퍿ﺉﲍ", a_), typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.Ribbon.ContextGroupsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅱୣࡥᱧཀྵᑫᩭ㝯q᭳͵ࡷॹ", a_), typeof(global::DevComponents.WpfRibbon.ContextGroupCollection), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(new global::DevComponents.WpfRibbon.ContextGroupCollection()));
			global::DevComponents.WpfRibbon.Ribbon.ContextGroupsProperty = global::DevComponents.WpfRibbon.Ribbon.ContextGroupsPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Ribbon.IsUsingGlassPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭡ᝣ㍥᭧ͩɫ७㝯ṱᕳյ୷", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.Ribbon.IsUsingGlassProperty = global::DevComponents.WpfRibbon.Ribbon.IsUsingGlassPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Ribbon.KeyTipProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⥡ţὥ㱧ͩᱫ", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.PropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Ribbon.KeyTipChanged)));
			global::DevComponents.WpfRibbon.Ribbon.IsCustomizableProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭡ᝣ╥ᵧᥩᡫŭᵯ᭱๳᝵᩷ᙹ᥻", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Ribbon.IsCustomizableChanged)));
			global::DevComponents.WpfRibbon.Ribbon.IsCustomizableContextSetProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭡ᝣ╥ᵧᥩᡫŭᵯ᭱๳᝵᩷ᙹ᥻㵽ﺉ\udf8b", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.PropertyMetadata(false));
			global::DevComponents.WpfRibbon.Ribbon.ElementRoleProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❡ࡣͥէཀྵɫᩭ≯ᵱᡳ፵", a_), typeof(global::DevComponents.WpfRibbon.eElementRole), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.PropertyMetadata(global::DevComponents.WpfRibbon.eElementRole.Default));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonTabPanel.TabsScrolledEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfRibbon.Ribbon.OnTabsScrolled));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.Ribbon), global::System.Windows.Input.Mouse.MouseWheelEvent, new global::System.Windows.Input.MouseWheelEventHandler(global::DevComponents.WpfRibbon.Ribbon.OnMouseWheel));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.ButtonDropDown.PreviewClickEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfRibbon.Ribbon.OnButtonDropDownPreviewClick));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.Ribbon), global::System.Windows.Input.Mouse.MouseDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::DevComponents.WpfRibbon.Ribbon.OnMouseButtonDown));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.Ribbon), global::System.Windows.Input.Mouse.PreviewMouseDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::DevComponents.WpfRibbon.Ribbon.OnPreviewMouseButtonDown));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.Ribbon), global::System.Windows.Input.Mouse.MouseUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::DevComponents.WpfRibbon.Ribbon.OnMouseButtonUp));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.Ribbon), global::System.Windows.Input.Mouse.LostMouseCaptureEvent, new global::System.Windows.Input.MouseEventHandler(global::DevComponents.WpfRibbon.Ribbon.OnLostMouseCapture));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.BasePopupControl.IsSelectedChangedEvent, new global::System.Windows.RoutedPropertyChangedEventHandler<bool>(global::DevComponents.WpfRibbon.Ribbon.OnPopupIsSelectedChanged));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.ButtonDropDown.CheckedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfRibbon.Ribbon.OnButtonDropDownCheckedClick));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.ButtonDropDown.UncheckedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfRibbon.Ribbon.OnButtonDropDownUnCheckedClick));
			global::System.Windows.Input.FocusManager.IsFocusScopeProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::System.Windows.Input.InputMethod.IsInputMethodSuspendedProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));
			global::System.Windows.Input.CommandManager.RegisterClassInputBinding(typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.Input.KeyBinding(global::DevComponents.WpfRibbon.Ribbon.ToggleRibbonMinimize, global::System.Windows.Input.Key.F1, global::System.Windows.Input.ModifierKeys.Control));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.Ribbon), global::System.Windows.Input.AccessKeyManager.AccessKeyPressedEvent, new global::System.Windows.Input.AccessKeyPressedEventHandler(global::DevComponents.WpfRibbon.Ribbon.OnAccessKeyPressed));
			global::DevComponents.WpfRibbon.Ribbon.BeforeRemoveFromQatEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⁡ţeݧᡩ५㱭ᕯά᭳uᵷ㱹๻ᅽ펁", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::DevComponents.WpfRibbon.QatOperationEventHandler), typeof(global::DevComponents.WpfRibbon.Ribbon));
			global::DevComponents.WpfRibbon.Ribbon.AfterRemoveFromQatEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍡ɣብ൧ᡩ㹫୭ᵯᵱɳ፵㹷ࡹ፻፽텿", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::DevComponents.WpfRibbon.QatOperationEventHandler), typeof(global::DevComponents.WpfRibbon.Ribbon));
			global::DevComponents.WpfRibbon.Ribbon.BeforeAddToQatEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⁡ţeݧᡩ५⽭ᑯᙱ⁳᥵⥷᭹ࡻ", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::DevComponents.WpfRibbon.QatOperationAddEventHandler), typeof(global::DevComponents.WpfRibbon.Ribbon));
			global::DevComponents.WpfRibbon.Ribbon.AfterAddToQatEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍡ɣብ൧ᡩ⵫੭ᑯ♱᭳❵᥷๹", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::DevComponents.WpfRibbon.QatOperationAddEventHandler), typeof(global::DevComponents.WpfRibbon.Ribbon));
			global::DevComponents.WpfRibbon.Ribbon.BeforeCustomizeQatDialogEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⁡ţeݧᡩ५⵭կűs᥵ᕷ፹ٻ᭽텿슅", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::DevComponents.WpfRibbon.QatDialogEventHandler), typeof(global::DevComponents.WpfRibbon.Ribbon));
			global::DevComponents.WpfRibbon.Ribbon.AfterCustomizeQatDialogEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍡ɣብ൧ᡩ⽫᭭ͯٱ᭳᭵ᅷy᥻⽽삃", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::DevComponents.WpfRibbon.QatDialogEventHandler), typeof(global::DevComponents.WpfRibbon.Ribbon));
			global::DevComponents.WpfRibbon.Ribbon.LivePreviewEnabledProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⹡ൣၥ൧㩩ṫ୭ٯ᭱ᅳŵ㵷ᑹᵻᱽ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Ribbon), new global::System.Windows.PropertyMetadata(false));
			global::DevComponents.WpfRibbon.Ribbon.LivePreviewEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⹡ൣၥ൧㩩ṫ୭ٯ᭱ᅳŵ", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.Ribbon));
			global::DevComponents.WpfRibbon.Ribbon.UndoLivePreviewEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝡੣ɥݧ♩իᡭᕯ≱ٳ፵๷፹᥻ॽ", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.Ribbon));
			global::DevComponents.WpfRibbon.Ribbon.EnterLivePreviewEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❡੣ብ൧ᡩ⁫ݭٯ᝱⑳ѵᵷ౹ᕻ᭽", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.Ribbon));
			global::DevComponents.WpfRibbon.Ribbon.ExitLivePreviewEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❡ᱣཥᱧ♩իᡭᕯ≱ٳ፵๷፹᥻ॽ", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.Ribbon));
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00078C88 File Offset: 0x00076E88
		public Ribbon()
		{
			this.m_PopupHandler = new global::DevComponents.WpfRibbon.ParentPopupControlImpl(this);
			this.m_PopupHandler.InternalMenuModeChanged += this.PopupHandlerInternalMenuModeChanged;
			global::DevComponents.WpfRibbon.ContextGroupCollection value = new global::DevComponents.WpfRibbon.ContextGroupCollection();
			base.SetValue(global::DevComponents.WpfRibbon.Ribbon.ContextGroupsPropertyKey, value);
			this.HorizontalWindowBorderThickness = new global::System.Windows.Thickness(this.WindowBorderThickness.Left, 0.0, this.WindowBorderThickness.Right, 0.0);
			base.Loaded += this.Ribbon_Loaded;
			base.Unloaded += this.Ribbon_Unloaded;
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000578 RID: 1400 RVA: 0x00078D38 File Offset: 0x00076F38
		// (remove) Token: 0x06000579 RID: 1401 RVA: 0x00078DEC File Offset: 0x00076FEC
		public event global::DevComponents.WpfRibbon.QatDialogEventHandler BeforeCustomizeQatDialog
		{
			add
			{
				short num = (short)334399397;
				short num2 = num;
				num = (short)1148356517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1531969536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)98435073;
				if (num != 0)
				{
				}
				num = (short)1858994176;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.Ribbon.BeforeCustomizeQatDialogEvent, value);
			}
			remove
			{
				short num = (short)1034355840;
				short num2 = num;
				num = (short)1602618496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1483538432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1085472768;
				if (num != 0)
				{
				}
				num = (short)657719297;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.Ribbon.BeforeCustomizeQatDialogEvent, value);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600057A RID: 1402 RVA: 0x00078EA0 File Offset: 0x000770A0
		// (remove) Token: 0x0600057B RID: 1403 RVA: 0x00078F58 File Offset: 0x00077158
		public event global::DevComponents.WpfRibbon.QatDialogEventHandler AfterCustomizeQatDialog
		{
			add
			{
				short num = (short)1847811260;
				short num2 = num;
				num = (short)402611388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164691968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1763115008;
				if (num != 0)
				{
				}
				num = (short)879755265;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.Ribbon.AfterCustomizeQatDialogEvent, value);
			}
			remove
			{
				short num = (short)13177790;
				short num2 = num;
				num = (short)242815934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)906428416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)876216320;
				if (num != 0)
				{
				}
				num = (short)1673265153;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.Ribbon.AfterCustomizeQatDialogEvent, value);
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600057C RID: 1404 RVA: 0x00079010 File Offset: 0x00077210
		// (remove) Token: 0x0600057D RID: 1405 RVA: 0x000790C4 File Offset: 0x000772C4
		public event global::DevComponents.WpfRibbon.QatOperationEventHandler BeforeRemoveFromQat
		{
			add
			{
				short num = (short)141545273;
				short num2 = num;
				num = (short)1347800889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)929824768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)683737089;
				if (num != 0)
				{
				}
				num = (short)980418560;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.Ribbon.BeforeRemoveFromQatEvent, value);
			}
			remove
			{
				short num = (short)570840090;
				short num2 = num;
				num = (short)214455322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)359071744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1776615425;
				if (num != 0)
				{
				}
				num = (short)418578432;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.Ribbon.BeforeRemoveFromQatEvent, value);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600057E RID: 1406 RVA: 0x0007917C File Offset: 0x0007737C
		// (remove) Token: 0x0600057F RID: 1407 RVA: 0x00079234 File Offset: 0x00077434
		public event global::DevComponents.WpfRibbon.QatOperationEventHandler AfterRemoveFromQat
		{
			add
			{
				short num = (short)54161876;
				short num2 = num;
				num = (short)593064404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)957022208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)975699969;
				if (num != 0)
				{
				}
				num = (short)1702297600;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.Ribbon.AfterRemoveFromQatEvent, value);
			}
			remove
			{
				short num = (short)621218918;
				short num2 = num;
				num = (short)1467616358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)776404992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1110310913;
				if (num != 0)
				{
				}
				num = (short)908853248;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.Ribbon.AfterRemoveFromQatEvent, value);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000580 RID: 1408 RVA: 0x000792EC File Offset: 0x000774EC
		// (remove) Token: 0x06000581 RID: 1409 RVA: 0x000793A0 File Offset: 0x000775A0
		public event global::DevComponents.WpfRibbon.QatOperationAddEventHandler BeforeAddToQat
		{
			add
			{
				short num = (short)1982929397;
				short num2 = num;
				num = (short)648616437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1296498688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)319488000;
				if (num != 0)
				{
				}
				num = (short)1715077121;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.Ribbon.BeforeAddToQatEvent, value);
			}
			remove
			{
				short num = (short)1386086401;
				if (num != 0)
				{
				}
				num = (short)1000734720;
				short num2 = num;
				num = (short)1235735601;
				short num3 = num;
				num = (short)1991431217;
				switch (num3 == num)
				{
				}
				num = (short)791478272;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.Ribbon.BeforeAddToQatEvent, value);
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000582 RID: 1410 RVA: 0x00079454 File Offset: 0x00077654
		// (remove) Token: 0x06000583 RID: 1411 RVA: 0x0007950C File Offset: 0x0007770C
		public event global::DevComponents.WpfRibbon.QatOperationAddEventHandler AfterAddToQat
		{
			add
			{
				short num = (short)2099614657;
				short num2 = num;
				num = (short)542479297;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1804468224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)312999937;
				if (num != 0)
				{
				}
				num = (short)1945632768;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.Ribbon.AfterAddToQatEvent, value);
			}
			remove
			{
				short num = (short)2060824907;
				short num2 = num;
				num = (short)1416933707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1681850368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1306394625;
				if (num != 0)
				{
				}
				num = (short)918290432;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.Ribbon.AfterAddToQatEvent, value);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000584 RID: 1412 RVA: 0x000795C0 File Offset: 0x000777C0
		// (remove) Token: 0x06000585 RID: 1413 RVA: 0x00079674 File Offset: 0x00077874
		public event global::System.Windows.RoutedEventHandler LivePreview
		{
			add
			{
				short num = (short)1069073388;
				short num2 = num;
				num = (short)91538412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)545849344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146697216;
				if (num != 0)
				{
				}
				num = (short)2054553601;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.Ribbon.LivePreviewEvent, value);
			}
			remove
			{
				short num = (short)714407937;
				if (num != 0)
				{
				}
				num = (short)806420480;
				short num2 = num;
				num = (short)1703475128;
				short num3 = num;
				num = (short)1143011256;
				switch (num3 == num)
				{
				}
				num = (short)1075970048;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.Ribbon.LivePreviewEvent, value);
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000586 RID: 1414 RVA: 0x00079728 File Offset: 0x00077928
		// (remove) Token: 0x06000587 RID: 1415 RVA: 0x000797DC File Offset: 0x000779DC
		public event global::System.Windows.RoutedEventHandler UndoLivePreview
		{
			add
			{
				short num = (short)1559935195;
				short num2 = num;
				num = (short)2079570139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1915486208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)914489345;
				if (num != 0)
				{
				}
				num = (short)1429667840;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.Ribbon.UndoLivePreviewEvent, value);
			}
			remove
			{
				short num = (short)1186463745;
				if (num != 0)
				{
				}
				num = (short)578748416;
				short num2 = num;
				num = (short)1787044409;
				short num3 = num;
				num = (short)1899438649;
				switch (num3 == num)
				{
				}
				num = (short)1866268672;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.Ribbon.UndoLivePreviewEvent, value);
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000588 RID: 1416 RVA: 0x00079894 File Offset: 0x00077A94
		// (remove) Token: 0x06000589 RID: 1417 RVA: 0x0007994C File Offset: 0x00077B4C
		public event global::System.Windows.RoutedEventHandler EnterLivePreview
		{
			add
			{
				short num = (short)546212895;
				short num2 = num;
				num = (short)1187351583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)509149184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)648544256;
				if (num != 0)
				{
				}
				num = (short)519372801;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.Ribbon.EnterLivePreviewEvent, value);
			}
			remove
			{
				short num = (short)1505165313;
				if (num != 0)
				{
				}
				num = (short)1573388288;
				short num2 = num;
				num = (short)1576573459;
				short num3 = num;
				num = (short)2126551571;
				switch (num3 == num)
				{
				}
				num = (short)648937472;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.Ribbon.EnterLivePreviewEvent, value);
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600058A RID: 1418 RVA: 0x00079A04 File Offset: 0x00077C04
		// (remove) Token: 0x0600058B RID: 1419 RVA: 0x00079ABC File Offset: 0x00077CBC
		public event global::System.Windows.RoutedEventHandler ExitLivePreview
		{
			add
			{
				short num = (short)379120195;
				short num2 = num;
				num = (short)1098574403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)806879232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)478740480;
				if (num != 0)
				{
				}
				num = (short)512557057;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.Ribbon.ExitLivePreviewEvent, value);
			}
			remove
			{
				short num = (short)1064028349;
				short num2 = num;
				num = (short)2124990653;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1807810560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)451936257;
				if (num != 0)
				{
				}
				num = (short)1681326080;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.Ribbon.ExitLivePreviewEvent, value);
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00079B74 File Offset: 0x00077D74
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			short num = (short)777733186;
			short num2 = num;
			num = (short)1373520962;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)980877312;
				short num3 = num;
				num = (short)711786496;
				if (num != 0)
				{
				}
				num = (short)1659961345;
				if (num != 0)
				{
				}
				if (base.ItemsSource != null)
				{
					return item is global::DevComponents.WpfRibbon.RibbonTab;
				}
				break;
			}
			}
			return base.IsItemItsOwnContainerOverride(item);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00079C38 File Offset: 0x00077E38
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			short num = (short)2062764160;
			short num2 = num;
			num = (short)914114688;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)313786368;
				short num3 = num;
				num = (short)1353973760;
				if (num != 0)
				{
				}
				if (base.ItemsSource != null)
				{
					return new global::DevComponents.WpfRibbon.RibbonTab();
				}
				break;
			}
			}
			num = (short)1323761665;
			if (num != 0)
			{
			}
			return base.GetContainerForItemOverride();
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00079CF8 File Offset: 0x00077EF8
		private void Ribbon_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1754671842;
			short num2 = num;
			num = (short)1049242338;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1129840640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1332740097;
			if (num != 0)
			{
			}
			num = (short)960757760;
			if (num != 0)
			{
			}
			global::System.Windows.Input.InputManager.Current.PostProcessInput -= this.InternalPostProcessInput;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00079DBC File Offset: 0x00077FBC
		private void Ribbon_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)143809138;
			short num2 = num;
			num = (short)1952078450;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1081016320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1580728321;
			if (num != 0)
			{
			}
			num = (short)388694016;
			if (num != 0)
			{
			}
			global::System.Windows.Input.InputManager.Current.PostProcessInput += this.InternalPostProcessInput;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00079E7C File Offset: 0x0007807C
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				short num;
				int num2;
				global::System.Collections.ArrayList arrayList;
				global::System.Collections.IEnumerator logicalChildren;
				for (;;)
				{
					IL_0A:
					num = (short)1610416129;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (this.ApplicationMenu != null)
						{
							num = (short)1535705093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_85;
					case 1:
					{
						num = (short)819522533;
						short num3 = num;
						num = (short)1417997285;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9E;
						default:
						{
							num = (short)1989214208;
							short num4 = num;
							num = (short)833748992;
							if (num != 0)
							{
							}
							num = (short)1332871168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_9E;
					case 3:
						goto IL_85;
					case 4:
						goto IL_14F;
					case 5:
						arrayList.Add(this.ApplicationMenu);
						num = (short)562036739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						arrayList.Add(this.QuickAccessToolbar);
						num = (short)905707529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!logicalChildren.MoveNext())
						{
							num = (short)1547567105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						arrayList.Add(logicalChildren.Current);
						num = (short)167510024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_14F;
					case 9:
						goto IL_14A;
					}
					goto IL_5F;
					IL_85:
					num = (short)784596994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9E:
					if (this.QuickAccessToolbar != null)
					{
						num = (short)1051262982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_14F:
					num = (short)1522925575;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14A:
				arrayList.AddRange(this.ContextGroups);
				return arrayList.GetEnumerator();
				IL_5F:
				arrayList = new global::System.Collections.ArrayList();
				logicalChildren = base.LogicalChildren;
				num = (short)367591428;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0007A0C8 File Offset: 0x000782C8
		public override void OnApplyTemplate()
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				global::System.Windows.Window window;
				switch (num)
				{
				case 0:
					this.UpdateMinimizedContentState();
					num2 = (short)1319567366;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.m_Popup != null)
					{
						num2 = (short)1518927881;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_100;
				case 2:
					this.m_Popup.Opened += this.Popup_Opened;
					this.m_Popup.Closed += this.Popup_Closed;
					num2 = (short)2032861195;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (window is global::DevComponents.WpfRibbon.RibbonWindow)
					{
						num2 = (short)555614212;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					((global::DevComponents.WpfRibbon.RibbonWindow)window).UpdateGlass();
					num2 = (short)1068105733;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return;
				case 6:
					goto IL_254;
				case 7:
					if (window != null)
					{
						num2 = (short)1989279752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_36A;
				case 8:
					this.SetupWindowBinding(window);
					num2 = (short)1933901837;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					this.m_Popup.Opened -= this.Popup_Opened;
					this.m_Popup.Closed -= this.Popup_Closed;
					num2 = (short)2032402442;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_100;
				case 11:
					goto IL_2DE;
				case 12:
					if (this.m_Popup != null)
					{
						goto IL_401;
					}
					goto IL_2DE;
				case 13:
					goto IL_36A;
				case 14:
					num2 = (short)1509687297;
					if (num2 != 0)
					{
					}
					if (this.IsMinimized)
					{
						num2 = (short)2080374784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_254;
				}
				goto IL_55;
				IL_100:
				this.m_PanelBorder = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൜Ṟ㍠㝢㩤㕦h४ཬnὰ⍲ᑴ᥶ᱸ᝺㽼ၾ", a_)) as global::DevComponents.WpfRibbon.RibbonBorder);
				this.m_QatPresenter = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൜Ṟ㍠㝢㩤㙦⡨㽪", a_)) as global::System.Windows.Controls.ContentPresenter);
				this.m_AppMenuPresenter = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൜Ṟ㍠㝢㩤♦ᥨ᭪ŬٮተቲŴṶᙸᕺぼ᩾", a_)) as global::System.Windows.Controls.ContentPresenter);
				this.m_QatBelowContainer = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൜Ṟ㍠㝢㩤㕦h४ཬnὰ≲ᑴͶ㭸Ṻᅼၾ솂ﾌ", a_)) as global::System.Windows.Controls.Decorator);
				this.m_RibbonContentPanel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൜Ṟ㍠㝢㩤㕦⩨㭪", a_)) as global::DevComponents.WpfRibbon.RibbonContentPanel);
				this.m_Popup = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൜Ṟ㍠㝢㩤㝦٨᭪ᡬὮ", a_)) as global::System.Windows.Controls.Primitives.Popup);
				this.m_ContentBorder = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൜Ṟ㍠㝢㩤㕦h४ཬnὰ⍲ᑴ᥶ᱸ᝺㽼ၾ", a_)) as global::DevComponents.WpfRibbon.RibbonBorder);
				this.m_PopupBorder = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൜Ṟ㍠㝢㩤㕦h४ཬnὰ⍲ᩴݶ౸୺㽼ၾ", a_)) as global::DevComponents.WpfRibbon.RibbonBorder);
				this.OnIsQuickAccessToolbarBelowChanged(!this.IsQuickAccessToolbarBelow, this.IsQuickAccessToolbarBelow);
				this.UpdateSelectedContent();
				window = global::System.Windows.Window.GetWindow(this);
				num2 = (short)1416101895;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_254:
				num2 = (short)1792016387;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DE:
				num2 = (short)1822949390;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_36A:
				num2 = (short)319228058;
				short num3 = num2;
				num2 = (short)319162522;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_401:
					num2 = (short)1803026434;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					break;
				default:
				{
					num2 = (short)354222080;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)285802496;
				if (num2 != 0)
				{
				}
				num2 = (short)1415512076;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_55:
			base.OnApplyTemplate();
			num2 = (short)12517377;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0007A518 File Offset: 0x00078718
		private void Popup_Closed(object sender, global::System.EventArgs e)
		{
			short num = (short)1215954946;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1BB;
				case 1:
				{
					num = (short)433979393;
					if (num != 0)
					{
					}
					global::System.Windows.Documents.AdornerLayer adornerLayer = this.m_KeyTipsAdorner.Parent as global::System.Windows.Documents.AdornerLayer;
					num = (short)655097859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 3:
				{
					global::System.Windows.Documents.AdornerLayer adornerLayer;
					if (adornerLayer != null)
					{
						num = (short)1951662086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BB;
				}
				case 4:
					num = (short)1463418887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
				{
					global::System.Windows.Documents.AdornerLayer adornerLayer;
					adornerLayer.Remove(this.m_KeyTipsAdorner);
					num = (short)2009938873;
					short num3 = num;
					num = (short)266812345;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19F;
					default:
					{
						num = (short)825163776;
						if (num != 0)
						{
						}
						num = (short)525074432;
						short num4 = num;
						num = (short)696909824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 7:
					if (this.m_KeyTipsAdorner.ContextObject is global::DevComponents.WpfRibbon.RibbonTab)
					{
						goto IL_19F;
					}
					return;
				}
				IL_45:
				if (this.m_KeyTipsAdorner != null)
				{
					num = (short)1296039940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_19F:
				num = (short)431292417;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BB:
				this.m_KeyTipsAdorner = null;
				num = (short)1760624645;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0007A700 File Offset: 0x00078900
		private void Popup_Opened(object sender, global::System.EventArgs e)
		{
			short num = (short)252510209;
			if (num != 0)
			{
			}
			num = (short)1239154688;
			short num2 = num;
			num = (short)1991706302;
			short num3 = num;
			num = (short)715851454;
			switch (num3 == num)
			{
			}
			num = (short)1147469824;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0007A7A8 File Offset: 0x000789A8
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			short num = (short)1612316673;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
					if (applicationMenu.IsPopupOpen)
					{
						num = (short)310378500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B6;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 2:
				{
					num = (short)1096008198;
					short num3 = num;
					num = (short)18137606;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_105;
					default:
						goto IL_EA;
					}
					break;
				}
				case 3:
				{
					num = (short)459669504;
					short num4 = num;
					global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu = this.ApplicationMenu as global::DevComponents.WpfRibbon.ApplicationMenu;
					num = (short)1025048576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_105;
				case 5:
				{
					global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
					if (!applicationMenu.IsBackstageActive)
					{
						num = (short)532873222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B6;
				}
				case 6:
				{
					global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
					applicationMenu.IsPopupOpen = false;
					num = (short)2138701826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_41:
				num = (short)1778319361;
				if (num != 0)
				{
				}
				if (this.ApplicationMenu is global::DevComponents.WpfRibbon.ApplicationMenu)
				{
					num = (short)1302200323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1B6;
				IL_105:
				num = (short)1455554565;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EA:
			num = (short)681574400;
			if (num != 0)
			{
			}
			IL_1B6:
			base.OnRenderSizeChanged(sizeInfo);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0007A974 File Offset: 0x00078B74
		private static void OnTabsScrolled(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::DevComponents.WpfRibbon.Ribbon ribbon;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (ribbon != null)
					{
						num2 = (short)1681195010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					num2 = (short)979763200;
					short num3 = num2;
					ribbon.UpdatePanelBorderSelectedTabRect();
					num2 = (short)2027290625;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			ribbon = (sender as global::DevComponents.WpfRibbon.Ribbon);
			num2 = (short)1136121776;
			short num4 = num2;
			num2 = (short)1799673776;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)2055536640;
				if (num2 != 0)
				{
				}
				num2 = (short)748879873;
				if (num2 != 0)
				{
				}
				num2 = (short)988676096;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0007AA94 File Offset: 0x00078C94
		private void UpdatePanelBorderSelectedTabRect()
		{
			short num = (short)1374795842;
			short num2 = num;
			num = (short)2035923010;
			switch (num2 == num)
			{
			}
			num = (short)945422337;
			if (num != 0)
			{
			}
			num = (short)942145536;
			short num3 = num;
			num = (short)1207894016;
			if (num != 0)
			{
			}
			this.UpdatePanelBorderSelectedTabRect(true);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0007AB44 File Offset: 0x00078D44
		private void UpdatePanelBorderSelectedTabRect(bool invokeAfterRenderIfNeeded)
		{
			short num = (short)1648427017;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfRibbon.RibbonTab selectedTabItem;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (invokeAfterRenderIfNeeded)
					{
						num = (short)1484390406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					if (selectedTabItem.Parent == this)
					{
						num = (short)330235912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21E;
				case 2:
					goto IL_219;
				case 3:
					if (selectedTabItem.IsArrangeValid)
					{
						num = (short)393805828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21E;
				case 4:
					num = (short)398983169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					selectedTabItem = this.GetSelectedTabItem();
					num = (short)41727781;
					short num3 = num;
					num = (short)322615077;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15C;
					default:
						num = (short)473956352;
						if (num != 0)
						{
						}
						num = (short)2135949322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
				{
					num = (short)174391296;
					short num4 = num;
					goto IL_15C;
				}
				case 7:
					goto IL_18D;
				case 8:
					goto IL_142;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 10:
					if (selectedTabItem == null)
					{
						num = (short)714211330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)416612355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_50:
				num = (short)2124873729;
				if (num != 0)
				{
				}
				if (this.m_PanelBorder != null)
				{
					num = (short)674562053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_15C:
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::System.Windows.Threading.DispatcherOperationCallback(this.InvokeUpdateBorderAfterRender), null);
				num = (short)992673799;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21E:
				num = (short)384827392;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_142:
			global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(selectedTabItem);
			layoutSlot.Location = selectedTabItem.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
			layoutSlot.Location = this.m_PanelBorder.PointFromScreen(layoutSlot.Location);
			layoutSlot.Inflate(-3.0, 0.0);
			this.m_PanelBorder.SelectedTabRect = layoutSlot;
			return;
			IL_18D:
			return;
			IL_219:
			this.m_PanelBorder.SelectedTabRect = default(global::System.Windows.Rect);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0007AE14 File Offset: 0x00079014
		private object InvokeUpdateBorderAfterRender(object args)
		{
			short num = (short)1942652737;
			short num2 = num;
			num = (short)1234601793;
			switch (num2 == num)
			{
			}
			num = (short)430047232;
			if (num != 0)
			{
			}
			num = (short)402849792;
			short num3 = num;
			num = (short)305397761;
			if (num != 0)
			{
			}
			this.UpdatePanelBorderSelectedTabRect(false);
			return null;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0007AEC8 File Offset: 0x000790C8
		internal bool IsBelowMinimumSize
		{
			get
			{
				short num = (short)1454505996;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1927479297;
						if (num != 0)
						{
						}
						num = (short)364838918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)2063925255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Windows.Window window;
						if (window.ActualWidth > 0.0)
						{
							num = (short)615251979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 3:
						goto IL_C7;
					case 4:
					{
						global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
						num = (short)496173069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)248643584;
						short num3 = num;
						num = (short)555483138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (!this.IsDesignMode)
						{
							num = (short)981008389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						if (this.AutoHideRibbonContent)
						{
							num = (short)1835859972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
					{
						global::System.Windows.Window window;
						if (window.ActualWidth > this.AutoHideTriggerSize.Width)
						{
							num = (short)880934915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 9:
					{
						global::System.Windows.Window window;
						if (window.ActualHeight <= this.AutoHideTriggerSize.Height)
						{
							num = (short)1057619978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 10:
					{
						num = (short)1625854430;
						short num4 = num;
						num = (short)1878823390;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C7;
						default:
							goto IL_211;
						}
						break;
					}
					case 11:
						num = (short)912261128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					case 13:
					{
						global::System.Windows.Window window;
						if (window != null)
						{
							num = (short)1050476544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					}
					IL_5D:
					if (base.HasItems)
					{
						num = (short)1145700353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_C7:
					num = (short)1047920649;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_211:
				num = (short)398262272;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0007B18C File Offset: 0x0007938C
		private bool IsDesignMode
		{
			get
			{
				short num = (short)1621650605;
				short num2 = num;
				num = (short)153513133;
				switch (num2 == num)
				{
				}
				num = (short)1535705089;
				if (num != 0)
				{
				}
				num = (short)1076887552;
				short num3 = num;
				num = (short)836435968;
				if (num != 0)
				{
				}
				return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0007B23C File Offset: 0x0007943C
		internal global::System.Windows.UIElement PopupBorderContent
		{
			get
			{
				if (this.m_PopupBorder != null)
				{
					short num = (short)978190336;
					short num2 = num;
				}
				else
				{
					short num = (short)1082349692;
					short num3 = num;
					num = (short)2092587132;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2034302977;
						if (num != 0)
						{
						}
						num = (short)428015616;
						if (num != 0)
						{
						}
						return this.m_PopupBorder;
					}
				}
				return this.m_PopupBorder.Child;
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0007B300 File Offset: 0x00079500
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)1662976003;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)89784330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_B1;
				case 2:
					num = (short)553254913;
					if (num != 0)
					{
					}
					if (this.m_PanelBorder.Visibility == global::System.Windows.Visibility.Visible)
					{
						num = (short)613810190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_325;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					continue;
				case 4:
					num = (short)320864258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.m_PanelBorder.Visibility = global::System.Windows.Visibility.Collapsed;
					goto IL_9A;
				case 6:
					if (base.HasItems)
					{
						num = (short)1719402505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_325;
				case 7:
					goto IL_323;
				case 8:
				{
					if (!this.IsBelowMinimumSize)
					{
						num = (short)1419902982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1058219388;
					short num3 = num;
					num = (short)834348412;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9A;
					default:
					{
						num = (short)1589575680;
						if (num != 0)
						{
						}
						num = (short)1571028992;
						short num4 = num;
						num = (short)1745289220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 9:
					num = (short)1532428299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (this.m_PanelBorder.Visibility == global::System.Windows.Visibility.Visible)
					{
						num = (short)395116549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_325;
				case 11:
					if (this.IsMinimized)
					{
						num = (short)1815347200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)714801165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_2C1;
				case 13:
					if (this.m_PanelBorder.Visibility != global::System.Windows.Visibility.Visible)
					{
						num = (short)1408499728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_325;
				case 14:
					this.m_PanelBorder.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)278462471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)815595528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.m_PanelBorder.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)220528652;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_69:
				if (this.m_PanelBorder != null)
				{
					num = (short)274726927;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9A:
				num = (short)2122514433;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B1:
			IL_2C1:
			IL_323:
			IL_325:
			return base.MeasureOverride(constraint);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0007B63C File Offset: 0x0007983C
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeBounds)
		{
			short num = (short)1104372089;
			short num2 = num;
			num = (short)236216697;
			switch (num2 == num)
			{
			}
			num = (short)1197277185;
			if (num != 0)
			{
			}
			num = (short)672333824;
			short num3 = num;
			num = (short)218824704;
			if (num != 0)
			{
			}
			global::System.Windows.Size result = base.ArrangeOverride(arrangeBounds);
			this.UpdatePanelBorderSelectedTabRect();
			return result;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0007B6F4 File Offset: 0x000798F4
		private void UpdateSelectedContent()
		{
			short num = (short)1262682112;
			short num2 = num;
			num = (short)527695879;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfRibbon.RibbonTab selectedTabItem;
				switch (num3)
				{
				case 0:
					goto IL_126;
				case 1:
				{
					global::System.Windows.Controls.ContentPresenter selectedContentPresenter;
					selectedContentPresenter.HorizontalAlignment = selectedTabItem.HorizontalContentAlignment;
					selectedContentPresenter.VerticalAlignment = selectedTabItem.VerticalContentAlignment;
					num = (short)578158605;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (selectedTabItem.ContentTemplateSelector != null)
					{
						num = (short)1470758918;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.SelectedContentTemplate = this.ContentTemplate;
					this.SelectedContentTemplateSelector = this.ContentTemplateSelector;
					num = (short)1730412544;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.ShowKeyTips)
					{
						num = (short)1146814483;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_30E;
				case 4:
					goto IL_126;
				case 5:
				{
					global::System.Windows.Controls.ContentPresenter selectedContentPresenter;
					if (selectedContentPresenter != null)
					{
						num = (short)1230438401;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37A;
				}
				case 6:
					goto IL_2A8;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_B4;
					}
					continue;
				case 8:
				{
					num = (short)1195758623;
					short num4 = num;
					num = (short)545379359;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_30E;
					default:
						num = (short)493092864;
						if (num != 0)
						{
						}
						num = (short)143917058;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					goto IL_30E;
				case 10:
					this.ShowKeyTips = false;
					num = (short)1431765001;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_332;
				case 12:
				{
					num = (short)665583617;
					if (num != 0)
					{
					}
					this.SelectedContent = selectedTabItem.Content;
					global::System.Windows.Controls.ContentPresenter selectedContentPresenter = this.GetSelectedContentPresenter();
					num = (short)290062341;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					goto IL_37A;
				case 14:
					goto IL_2A3;
				case 15:
					num = (short)2019033104;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (this.m_KeyTipsAdorner.ContextObject != selectedTabItem)
					{
						num = (short)1971191818;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_30E;
				case 17:
					if (this.m_KeyTipsAdorner.ContextObject is global::DevComponents.WpfRibbon.RibbonTab)
					{
						num = (short)2001076239;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_30E;
				case 18:
					if (selectedTabItem.ContentTemplate == null)
					{
						num = (short)875823112;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A8;
				case 19:
					num = (short)1988165653;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_429;
				case 21:
					if (this.m_KeyTipsAdorner != null)
					{
						num = (short)1613824024;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_30E;
				case 22:
					if (selectedTabItem != null)
					{
						num = (short)588185612;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.ClearValue(global::DevComponents.WpfRibbon.RibbonTab.TabColorProperty);
					num = (short)1865744398;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					this.SelectedContent = null;
					base.ClearValue(global::DevComponents.WpfRibbon.RibbonTab.TabColorProperty);
					num = (short)366411796;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)899743761;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B4:
				if (base.SelectedIndex < 0)
				{
					num = (short)28835863;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				selectedTabItem = this.GetSelectedTabItem();
				num = (short)278331414;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_126:
				num = (short)1318322179;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A8:
				this.SelectedContentTemplate = selectedTabItem.ContentTemplate;
				this.SelectedContentTemplateSelector = selectedTabItem.ContentTemplateSelector;
				num = (short)1807024132;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_30E:
				global::DevComponents.WpfRibbon.RibbonTab.SetTabColor(this, selectedTabItem.Color);
				num = (short)572915723;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_37A:
				num = (short)1419247634;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_2A3:
			IL_332:
			IL_429:
			this.UpdatePanelBorderSelectedTabRect();
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0007BBA8 File Offset: 0x00079DA8
		internal global::System.Windows.Controls.ContentPresenter GetSelectedContentPresenter()
		{
			int a_ = 0;
			short num = (short)451084289;
			if (num != 0)
			{
			}
			num = (short)1149350563;
			short num2 = num;
			num = (short)1892725411;
			switch (num2 == num)
			{
			}
			num = (short)59965440;
			short num3 = num;
			num = (short)347668480;
			if (num != 0)
			{
			}
			return base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ࡗ᭙๛੝㽟㙡գѥ⭧թɫᩭᕯᱱs㹵᝷ॹࡻ", a_)) as global::System.Windows.Controls.ContentPresenter;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0007BC74 File Offset: 0x00079E74
		protected override void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
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
					global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
					if (applicationMenu.IsPopupOpen)
					{
						num2 = (short)1356988417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16C;
				}
				case 1:
				{
					global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
					applicationMenu.IsPopupOpen = false;
					num2 = (short)1285095428;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)1716387841;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu = this.ApplicationMenu as global::DevComponents.WpfRibbon.ApplicationMenu;
					num2 = (short)1710096384;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_B5;
				case 4:
					goto IL_125;
				}
				goto IL_24;
			}
			IL_125:
			goto IL_16C;
			IL_24:
			num2 = (short)359695937;
			short num3 = num2;
			num2 = (short)666666561;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B5:
				if (this.ApplicationMenu is global::DevComponents.WpfRibbon.ApplicationMenu)
				{
					num2 = (short)450363394;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)893976576;
				if (num2 != 0)
				{
				}
				num2 = (short)964427776;
				short num4 = num2;
				base.OnSelectionChanged(e);
				num2 = (short)761790467;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			IL_16C:
			this.UpdateSelectedContent();
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0007BDF8 File Offset: 0x00079FF8
		protected override void OnInitialized(global::System.EventArgs e)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			global::System.Reflection.PropertyInfo property;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_148;
				case 1:
					if (property != null)
					{
						num2 = (short)61931522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14A;
				case 2:
				{
					num2 = (short)75816212;
					short num3 = num2;
					num2 = (short)1717034260;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)759103488;
						if (num2 != 0)
						{
						}
						num2 = (short)1318649857;
						if (num2 != 0)
						{
						}
						property.SetValue(this, false, null);
						num2 = (short)154271744;
						short num4 = num2;
						num2 = (short)1578172416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_25;
			}
			IL_148:
			IL_14A:
			base.ItemContainerGenerator.StatusChanged += this.OnGeneratorStatusChanged;
			this.SetupRibbonWindow();
			this.SetupEnterMenuMode();
			return;
			IL_25:
			global::DevComponents.WpfRibbon.Ribbon.LoadCommonStyles();
			base.OnInitialized(e);
			property = base.GetType().GetProperty(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᥙ㵛そ㍟ݡࡣͥ୧ṩⅫ᭭ᱯٱᵳٵᑷό", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
			num2 = (short)1868103681;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0007BF74 File Offset: 0x0007A174
		private void SetupRibbonWindow()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::System.Windows.Window window;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2015887366;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (window is global::DevComponents.WpfRibbon.RibbonWindow)
					{
						num2 = (short)1208942592;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)863895553;
					if (num2 != 0)
					{
					}
					num2 = (short)936607446;
					short num3 = num2;
					num2 = (short)1874689750;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_126;
					default:
					{
						num2 = (short)990904320;
						if (num2 != 0)
						{
						}
						num2 = (short)39649280;
						short num4 = num2;
						num2 = (short)1161166849;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					((global::DevComponents.WpfRibbon.RibbonWindow)window).RibbonControl = this;
					num2 = (short)1053622276;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return;
				case 5:
					if (window != null)
					{
						num2 = (short)1608974338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					if (((global::DevComponents.WpfRibbon.RibbonWindow)window).RibbonControl != this)
					{
						goto IL_126;
					}
					return;
				}
				goto IL_2C;
				IL_126:
				num2 = (short)1768161283;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			window = global::System.Windows.Window.GetWindow(this);
			num2 = (short)572719109;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0007C128 File Offset: 0x0007A328
		public void SetupBindings()
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::System.Windows.Window window;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this._RibbonMinimizeCommandBinding == null)
					{
						num2 = (short)276430852;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CA;
				case 1:
					num2 = (short)1051262977;
					if (num2 != 0)
					{
					}
					goto IL_CA;
				case 2:
					return;
				case 3:
					num2 = (short)648937472;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					this._RibbonMinimizeCommandBinding = new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfRibbon.Ribbon.ToggleRibbonMinimize, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.ToggleRibbonMinimizeExecuted), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.ToggleRibbonMinimizeCanExecute));
					num2 = (short)210073845;
					short num3 = num2;
					num2 = (short)1401256181;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FD;
					default:
						num2 = (short)1433337856;
						if (num2 != 0)
						{
						}
						num2 = (short)1984561153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (this._RibbonMinimizeKeyBinding == null)
					{
						goto IL_FD;
					}
					goto IL_155;
				case 6:
				{
					num2 = (short)1529413632;
					short num4 = num2;
					goto IL_155;
				}
				case 7:
					if (window != null)
					{
						num2 = (short)1187053571;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					this._RibbonMinimizeKeyBinding = new global::System.Windows.Input.KeyBinding(global::DevComponents.WpfRibbon.Ribbon.ToggleRibbonMinimize, global::System.Windows.Input.Key.F1, global::System.Windows.Input.ModifierKeys.Control);
					num2 = (short)1845886982;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_CA:
				window.CommandBindings.Add(this._RibbonMinimizeCommandBinding);
				num2 = (short)2080636933;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_FD:
				num2 = (short)1018888200;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_155:
				window.InputBindings.Add(this._RibbonMinimizeKeyBinding);
				num2 = (short)1795162114;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_34:
			window = global::System.Windows.Window.GetWindow(this);
			num2 = (short)1760362503;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0007C370 File Offset: 0x0007A570
		public void ReleaseBindings()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::System.Windows.Window window;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)419430401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (window != null)
					{
						num2 = (short)400883712;
						short num3 = num2;
						num2 = (short)711393287;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				case 3:
					goto IL_FF;
				case 4:
					num2 = (short)1372192773;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (window != null)
					{
						num2 = (short)625606662;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FF;
				case 6:
				{
					window.CommandBindings.Remove(this._RibbonMinimizeCommandBinding);
					this._RibbonMinimizeCommandBinding = null;
					num2 = (short)1525941429;
					short num4 = num2;
					num2 = (short)1291453621;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_121;
					default:
						num2 = (short)929431552;
						if (num2 != 0)
						{
						}
						num2 = (short)736624643;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					num2 = (short)2028732417;
					if (num2 != 0)
					{
					}
					window.InputBindings.Remove(this._RibbonMinimizeKeyBinding);
					this._RibbonMinimizeKeyBinding = null;
					num2 = (short)1029898242;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (this._RibbonMinimizeCommandBinding != null)
					{
						num2 = (short)886439940;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FF;
				case 9:
					if (this._RibbonMinimizeKeyBinding != null)
					{
						goto IL_121;
					}
					return;
				}
				goto IL_38;
				IL_FF:
				num2 = (short)1501298697;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_121:
				num2 = (short)225312768;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			window = global::System.Windows.Window.GetWindow(this);
			num2 = (short)685768712;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0007C5A8 File Offset: 0x0007A7A8
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			short num = (short)736624640;
			short num2 = num;
			num = (short)744421706;
			short num3 = num;
			num = (short)278853962;
			switch (num3 == num)
			{
			}
			num = (short)2136211457;
			if (num != 0)
			{
			}
			num = (short)1633484800;
			if (num != 0)
			{
			}
			this.SetupRibbonWindow();
			base.OnVisualParentChanged(oldParent);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0007C660 File Offset: 0x0007A860
		private void OnGeneratorStatusChanged(object sender, global::System.EventArgs e)
		{
			short num = (short)56033282;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1326710785;
					if (num != 0)
					{
					}
					num = (short)121241606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_12D;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 3:
					goto IL_14C;
				case 4:
					goto IL_92;
				case 5:
					if (base.SelectedIndex < 0)
					{
						num = (short)1021640708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12D;
				case 6:
					if (base.HasItems)
					{
						num = (short)1913716743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12D;
				case 7:
					num = (short)638910469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_44:
				if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
				{
					num = (short)772734976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_14C;
				IL_92:
				base.SelectedItem = this.FindNextTabItem(-1, 1);
				num = (short)1087176705;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14C:
				num = (short)1868664850;
				short num3 = num;
				num = (short)1826394130;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_92;
				default:
					goto IL_181;
				}
				IL_12D:
				this.UpdateSelectedContent();
				num = (short)1704067075;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_181:
			num = (short)144965632;
			short num4 = num;
			num = (short)676986880;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0007C82C File Offset: 0x0007AA2C
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
				int num3;
				switch (num)
				{
				case 0:
					ribbonTab.IsSelected = true;
					num2 = (short)1219624965;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (ribbonTab != null)
					{
						num2 = (short)920322048;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
					{
						num2 = (short)336396292;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (base.SelectedIndex == -1)
					{
						num2 = (short)509083656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					num2 = (short)173080579;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return;
				case 6:
					num3 = 0;
					num2 = (short)299630599;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_A1;
				case 8:
					num3 = e.OldStartingIndex + 1;
					num2 = (short)541523977;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)15007744;
					short num4 = num2;
					num2 = (short)1773641296;
					short num5 = num2;
					num2 = (short)1278123600;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A1;
					default:
						num2 = (short)1334640640;
						if (num2 != 0)
						{
						}
						if (num3 > base.Items.Count)
						{
							num2 = (short)887160838;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_A1;
					}
					break;
				}
				}
				goto IL_38;
				IL_A1:
				ribbonTab = this.FindNextTabItem(num3, -1);
				num2 = (short)1433731073;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			num2 = (short)1137967105;
			if (num2 != 0)
			{
			}
			base.OnItemsChanged(e);
			num2 = (short)1435107330;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0007CA5C File Offset: 0x0007AC5C
		private global::DevComponents.WpfRibbon.RibbonTab FindNextTabItem(int startIndex, int direction)
		{
			short num = (short)459079688;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
			for (;;)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 0:
					num3 = base.Items.Count - 1;
					num = (short)2000027664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1530134529;
					if (num != 0)
					{
					}
					goto IL_1C3;
				case 2:
					if (num3 < 0)
					{
						num = (short)1083572224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC;
				case 3:
					if (num3 >= base.Items.Count)
					{
						num = (short)1239941126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)95944706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (ribbonTab.Visibility == global::System.Windows.Visibility.Visible)
					{
						num = (short)840892428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15F;
				case 5:
					if (ribbonTab != null)
					{
						num = (short)446693387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15F;
				case 6:
					num3 = 0;
					num = (short)1869742094;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_203;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 9:
					if (ribbonTab.IsEnabled)
					{
						num = (short)549519377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15F;
				case 10:
					num3 = startIndex;
					num4 = 0;
					num = (short)434110479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)287047689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					return ribbonTab;
				case 13:
					if (num4 >= base.Items.Count)
					{
						goto IL_1EB;
					}
					num3 += direction;
					num = (short)1493696515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_CC;
				case 15:
					goto IL_1C3;
				case 16:
					goto IL_CC;
				case 17:
				{
					num = (short)527034407;
					short num5 = num;
					num = (short)1506469927;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1EB;
					default:
					{
						num = (short)1782448128;
						if (num != 0)
						{
						}
						num = (short)747700224;
						short num6 = num;
						num = (short)1045364740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_6C:
				if (direction != 0)
				{
					num = (short)337510410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_341;
				IL_CC:
				ribbonTab = (base.Items[num3] as global::DevComponents.WpfRibbon.RibbonTab);
				num = (short)1306722309;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15F:
				num4++;
				num = (short)1527316481;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C3:
				num = (short)2011168781;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EB:
				num = (short)271974407;
				num2 = (int)((global::System.IntPtr)num);
			}
			return ribbonTab;
			IL_203:
			IL_341:
			return null;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0007CDAC File Offset: 0x0007AFAC
		private global::DevComponents.WpfRibbon.RibbonTab GetSelectedTabItem()
		{
			short num = (short)1950744576;
			short num2 = num;
			num = (short)1211111993;
			short num3 = num;
			num = (short)537926201;
			switch (num3 == num)
			{
			}
			num = (short)235339777;
			if (num != 0)
			{
			}
			num = (short)33816576;
			if (num != 0)
			{
			}
			return base.SelectedItem as global::DevComponents.WpfRibbon.RibbonTab;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0007CE60 File Offset: 0x0007B060
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x0007CF1C File Offset: 0x0007B11C
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(true)]
		public bool SystemButtons
		{
			get
			{
				short num = (short)404029440;
				short num2 = num;
				num = (short)1808072705;
				if (num != 0)
				{
				}
				num = (short)450837903;
				short num3 = num;
				num = (short)649411983;
				switch (num3 == num)
				{
				}
				num = (short)1984430080;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.SystemButtonsProperty);
			}
			set
			{
				short num = (short)1322778624;
				short num2 = num;
				num = (short)1322825548;
				short num3 = num;
				num = (short)200652620;
				switch (num3 == num)
				{
				}
				num = (short)1634598913;
				if (num != 0)
				{
				}
				num = (short)464257024;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.SystemButtonsProperty, value);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0007CFD8 File Offset: 0x0007B1D8
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x0007D090 File Offset: 0x0007B290
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Browsable(false)]
		public string LicenseKey
		{
			get
			{
				short num = (short)1997406208;
				short num2 = num;
				num = (short)143065089;
				if (num != 0)
				{
				}
				num = (short)97339848;
				short num3 = num;
				num = (short)409029064;
				switch (num3 == num)
				{
				}
				num = (short)441778176;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.LicenseKeyProperty);
			}
			set
			{
				short num = (short)1171456000;
				short num2 = num;
				num = (short)1304206339;
				short num3 = num;
				num = (short)1222548483;
				switch (num3 == num)
				{
				}
				num = (short)2047410177;
				if (num != 0)
				{
				}
				num = (short)777781248;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.LicenseKeyProperty, value);
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0007D144 File Offset: 0x0007B344
		private static void OnLicenseKeyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1540423680;
			short num2 = num;
			num = (short)1766124627;
			short num3 = num;
			num = (short)365620307;
			switch (num3 == num)
			{
			}
			num = (short)702414849;
			if (num != 0)
			{
			}
			num = (short)530448384;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.Ribbon)d).OnLicenseKeyChanged();
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0007D1FC File Offset: 0x0007B3FC
		private void OnLicenseKeyChanged()
		{
			short num = (short)1692270592;
			short num2 = num;
			num = (short)170999589;
			short num3 = num;
			num = (short)1717518117;
			switch (num3 == num)
			{
			}
			num = (short)35913729;
			if (num != 0)
			{
			}
			num = (short)1458831360;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.WinApi.ValidateLicenseKey(this.LicenseKey);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0007D2AC File Offset: 0x0007B4AC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static void InitLK(string lk)
		{
			short num = (short)952434688;
			short num2 = num;
			num = (short)1435294110;
			short num3 = num;
			num = (short)756406686;
			switch (num3 == num)
			{
			}
			num = (short)45154305;
			if (num != 0)
			{
			}
			num = (short)1435697152;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.WinApi.ValidateLicenseKey(lk);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0007D35C File Offset: 0x0007B55C
		private static void OnApplicationMenuChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)819855360;
			short num2 = num;
			num = (short)88801866;
			short num3 = num;
			num = (short)1363804746;
			switch (num3 == num)
			{
			}
			num = (short)941424641;
			if (num != 0)
			{
			}
			num = (short)1537081344;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.Ribbon)d).OnApplicationMenuChanged(e.OldValue as global::System.Windows.UIElement, e.NewValue as global::System.Windows.UIElement);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0007D428 File Offset: 0x0007B628
		private void OnApplicationMenuChanged(global::System.Windows.UIElement oldValue, global::System.Windows.UIElement newValue)
		{
			short num = (short)402325506;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					((global::System.Windows.FrameworkElement)newValue).SizeChanged += this.AppMenuSizeChanged;
					num = (short)1781858305;
					if (num != 0)
					{
					}
					num = (short)1374421001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (newValue is global::System.Windows.FrameworkElement)
					{
						num = (short)91160576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 3:
					base.AddLogicalChild(newValue);
					num = (short)188481537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					base.RemoveLogicalChild(oldValue);
					num = (short)1509556232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1EB;
				case 6:
					goto IL_A8;
				case 7:
					if (newValue != null)
					{
						num = (short)1471217667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
				{
					if (!(oldValue is global::System.Windows.FrameworkElement))
					{
						goto IL_A8;
					}
					num = (short)1318912000;
					short num3 = num;
					num = (short)645277656;
					short num4 = num;
					num = (short)839460824;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1EB;
					default:
						num = (short)943915008;
						if (num != 0)
						{
						}
						num = (short)760020997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					return;
				}
				IL_4D:
				if (oldValue != null)
				{
					num = (short)2096824324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A8:
				num = (short)897122311;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EB:
				((global::System.Windows.FrameworkElement)oldValue).SizeChanged -= this.AppMenuSizeChanged;
				num = (short)924450822;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0007D654 File Offset: 0x0007B854
		private void AppMenuSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			short num = (short)825425920;
			short num2 = num;
			num = (short)1427293854;
			short num3 = num;
			num = (short)954451614;
			switch (num3 == num)
			{
			}
			num = (short)981073920;
			if (num != 0)
			{
			}
			num = (short)856031233;
			if (num != 0)
			{
			}
			this.UpdateRibbonWindowGlass();
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0007D704 File Offset: 0x0007B904
		private static void OnQuickAccessToolbarChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)16842752;
			short num2 = num;
			num = (short)1565988961;
			short num3 = num;
			num = (short)1956845665;
			switch (num3 == num)
			{
			}
			num = (short)61341696;
			if (num != 0)
			{
			}
			num = (short)718995457;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.Ribbon)d).OnQuickAccessToolbarChanged(e.OldValue as global::System.Windows.UIElement, e.NewValue as global::System.Windows.UIElement);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0007D7D0 File Offset: 0x0007B9D0
		private void OnQuickAccessToolbarChanged(global::System.Windows.UIElement oldValue, global::System.Windows.UIElement newValue)
		{
			int a_ = 17;
			short num = (short)154468354;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfRibbon.Qat qat2;
				switch (num2)
				{
				case 0:
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⁨ᡪⱬ౮հᩲʹቶ", a_));
					binding.Source = this;
					global::DevComponents.WpfRibbon.Qat qat;
					global::System.Windows.Data.BindingOperations.SetBinding(qat, global::DevComponents.WpfRibbon.Qat.IsActiveProperty, binding);
					num = (short)473563145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::DevComponents.WpfRibbon.Qat qat;
					if (qat != null)
					{
						num = (short)44695552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 3:
				{
					base.AddLogicalChild(newValue);
					global::DevComponents.WpfRibbon.Qat qat = newValue as global::DevComponents.WpfRibbon.Qat;
					num = (short)1999372289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					base.RemoveLogicalChild(oldValue);
					qat2 = (oldValue as global::DevComponents.WpfRibbon.Qat);
					num = (short)727842824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_211;
				case 6:
					goto IL_E3;
				case 7:
					if (newValue != null)
					{
						num = (short)26017795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
				{
					num = (short)141164544;
					short num3 = num;
					if (qat2 == null)
					{
						goto IL_E3;
					}
					num = (short)630090517;
					short num4 = num;
					num = (short)1610050325;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_211;
					default:
						num = (short)890306560;
						if (num != 0)
						{
						}
						num = (short)506462213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					return;
				}
				IL_55:
				if (oldValue != null)
				{
					num = (short)1241776129;
					if (num != 0)
					{
					}
					num = (short)158466052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E3:
				num = (short)1770717191;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_211:
				global::System.Windows.Data.BindingOperations.ClearBinding(qat2, global::DevComponents.WpfRibbon.Qat.IsActiveProperty);
				num = (short)1670119430;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0007DA18 File Offset: 0x0007BC18
		private static void OnIsQuickAccessToolbarBelowChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1633615872;
			short num2 = num;
			num = (short)123554400;
			short num3 = num;
			num = (short)1702972000;
			switch (num3 == num)
			{
			}
			num = (short)553385985;
			if (num != 0)
			{
			}
			num = (short)379387904;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.Ribbon)d).OnIsQuickAccessToolbarBelowChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0007DAE8 File Offset: 0x0007BCE8
		public void SetupWindowBinding(global::System.Windows.Window w)
		{
			int a_ = 17;
			short num = (short)1303838720;
			short num2 = num;
			num = (short)1817526853;
			short num3 = num;
			num = (short)951861829;
			switch (num3 == num)
			{
			}
			num = (short)1355284481;
			if (num != 0)
			{
			}
			num = (short)371523584;
			if (num != 0)
			{
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⁨ᡪⱬ౮հᩲʹቶ", a_));
			binding.Source = w;
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::DevComponents.WpfRibbon.Ribbon.IsActiveProperty, binding);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0007DBC0 File Offset: 0x0007BDC0
		private void OnIsQuickAccessToolbarBelowChanged(bool oldValue, bool newValue)
		{
			short num = (short)1307377670;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1B8;
				case 1:
				{
					for (;;)
					{
						this.m_RibbonContentPanel.Children.Remove(this.m_QatPresenter);
						this.m_QatBelowContainer.Child = this.m_QatPresenter;
						this.m_QatBelowContainer.Visibility = global::System.Windows.Visibility.Visible;
						num = (short)1319771118;
						short num3 = num;
						num = (short)46144494;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_15D;
						}
						goto Block_3;
					}
					IL_15D:
					num = (short)23330816;
					if (num != 0)
					{
					}
					num = (short)2126118920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					num = (short)1107492864;
					short num4 = num;
					goto IL_15D;
				}
				case 2:
					if (newValue)
					{
						num = (short)1801322497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)134479881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					((global::DevComponents.WpfRibbon.Qat)this.m_QatPresenter.Content).IsAboveRibbon = true;
					num = (short)944766990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.m_QatBelowContainer.Child = null;
					this.m_QatBelowContainer.Visibility = global::System.Windows.Visibility.Collapsed;
					this.m_RibbonContentPanel.Children.Add(this.m_QatPresenter);
					num = (short)1265631242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.m_RibbonContentPanel == null)
					{
						num = (short)609746956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1271922690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 7:
					num = (short)25034765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (this.m_QatPresenter.Content is global::DevComponents.WpfRibbon.Qat)
					{
						num = (short)1517092864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					if (this.m_QatBelowContainer.Child == this.m_QatPresenter)
					{
						num = (short)31064068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					if (this.m_QatPresenter.Content is global::DevComponents.WpfRibbon.Qat)
					{
						num = (short)891158531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					num = (short)1369178117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_1F8;
				case 13:
					if (this.m_QatBelowContainer != null)
					{
						num = (short)1891893259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 14:
					goto IL_2F5;
				}
				IL_60:
				if (this.m_QatPresenter == null)
				{
					return;
				}
				num = (short)309854215;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1B8:
			((global::DevComponents.WpfRibbon.Qat)this.m_QatPresenter.Content).IsAboveRibbon = false;
			return;
			IL_1F8:
			return;
			IL_2F5:
			num = (short)1966407681;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0007DF28 File Offset: 0x0007C128
		private static void OnMouseWheel(object sender, global::System.Windows.Input.MouseWheelEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)750714886;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)673316864;
					short num3 = num2;
					global::DevComponents.WpfRibbon.Ribbon ribbon;
					if (ribbon != null)
					{
						num2 = (short)243335168;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					goto IL_12C;
				case 3:
					num2 = (short)2059534340;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::DevComponents.WpfRibbon.Ribbon ribbon;
					if (!ribbon.IsKeyboardFocusWithin)
					{
						num2 = (short)1214578693;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 5:
				{
					global::DevComponents.WpfRibbon.Ribbon ribbon;
					ribbon.SelectTabMouseWheel(e);
					num2 = (short)1730936833;
					if (num2 != 0)
					{
					}
					num2 = (short)1038024706;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_180;
				}
				goto IL_2C;
			}
			IL_12C:
			return;
			IL_180:
			if (!e.Handled)
			{
				goto IL_188;
			}
			return;
			IL_2C:
			num2 = (short)526507164;
			short num4 = num2;
			num2 = (short)852155548;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_188:
				num2 = (short)935460867;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)2115895296;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfRibbon.Ribbon ribbon = sender as global::DevComponents.WpfRibbon.Ribbon;
				num2 = (short)1708654593;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0007E0D8 File Offset: 0x0007C2D8
		private void SelectTabMouseWheel(global::System.Windows.Input.MouseWheelEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.Rect rect;
			global::System.Windows.Point position;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (rect.Contains(position))
					{
						num2 = (short)259260418;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_10A;
				case 2:
				{
					num2 = (short)707734026;
					short num3 = num2;
					num2 = (short)512895498;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10C;
					case 1:
						break;
					default:
					{
						num2 = (short)40239104;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)977010688;
					if (num2 != 0)
					{
					}
					num2 = (short)1802108929;
					if (num2 != 0)
					{
					}
					num2 = (short)620691459;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (e.Delta < 0)
					{
						num2 = (short)2126708740;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					e.Handled = this.SelectPreviousTab();
					num2 = (short)304545793;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_17B;
				}
				goto IL_24;
			}
			IL_10A:
			return;
			IL_10C:
			e.Handled = this.SelectNextTab();
			return;
			IL_17B:
			goto IL_10C;
			IL_24:
			position = global::System.Windows.Input.Mouse.GetPosition(this);
			rect = new global::System.Windows.Rect(base.RenderSize);
			num2 = (short)1089929216;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0007E264 File Offset: 0x0007C464
		private bool SelectPreviousTab()
		{
			short num;
			int ribbonTabIndex;
			for (;;)
			{
				num = (short)1047396354;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						goto IL_10D;
					case 2:
						num = (short)879755265;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					case 3:
						if (ribbonTabIndex < 0)
						{
							num = (short)846331905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114;
					}
					IL_5C:
					if (base.SelectedIndex <= 0)
					{
						num = (short)517865472;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						ribbonTabIndex = this.GetRibbonTabIndex(base.SelectedIndex, -1);
						num = (short)1028784131;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_10D:
				num = (short)1401106957;
				short num3 = num;
				num = (short)2047554061;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_B3;
				}
			}
			return false;
			IL_B3:
			num = (short)1204682752;
			if (num != 0)
			{
			}
			return false;
			IL_114:
			num = (short)295174144;
			short num4 = num;
			base.SelectedIndex = ribbonTabIndex;
			return true;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0007E3B8 File Offset: 0x0007C5B8
		private bool SelectNextTab()
		{
			short num;
			int ribbonTabIndex;
			for (;;)
			{
				num = (short)2102525954;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						goto IL_11D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_35;
						}
						continue;
					case 3:
						if (ribbonTabIndex < 0)
						{
							num = (short)1406140417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124;
					}
					IL_35:
					if (base.SelectedIndex >= base.Items.Count - 1)
					{
						num = (short)1876295680;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						ribbonTabIndex = this.GetRibbonTabIndex(base.SelectedIndex, 1);
						num = (short)713293827;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_11D:
				num = (short)149261066;
				short num3 = num;
				num = (short)654609162;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_9B;
				}
			}
			return false;
			IL_9B:
			num = (short)592248833;
			if (num != 0)
			{
			}
			num = (short)226885632;
			if (num != 0)
			{
			}
			return false;
			IL_124:
			num = (short)513409024;
			short num4 = num;
			base.SelectedIndex = ribbonTabIndex;
			return true;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0007E51C File Offset: 0x0007C71C
		private int GetRibbonTabIndex(int start, int direction)
		{
			short num = (short)776339456;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				int num5;
				for (;;)
				{
					IL_1E:
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					int num4;
					int num6;
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							return -1;
						case 1:
						{
							num = (short)1704067072;
							short num3 = num;
							if (num4 == num5)
							{
								num = (short)710606851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5 += num6;
							global::DevComponents.WpfRibbon.RibbonTab ribbonTab = base.Items[num5] as global::DevComponents.WpfRibbon.RibbonTab;
							num = (short)1395064839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)135069702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							return -1;
						case 4:
							return num5;
						case 5:
							goto IL_267;
						case 6:
						{
							global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
							if (ribbonTab.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)453115908;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_184;
						}
						case 7:
						{
							num = (short)927883358;
							short num7 = num;
							num = (short)715087966;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E;
							default:
							{
								num = (short)1106182144;
								if (num != 0)
								{
								}
								global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
								if (ribbonTab != null)
								{
									num = (short)1458700290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_184;
							}
							}
							break;
						}
						case 8:
							if (start >= num4)
							{
								num = (short)979304453;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_184;
						case 9:
							if (direction < 0)
							{
								num = (short)1984823306;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2059927560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num4 = 0;
							num6 = -1;
							num = (short)1722875915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (start <= 0)
							{
								num = (short)814940160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_184;
						}
						break;
						IL_184:
						num = (short)1604976641;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5F:
					num5 = start;
					num4 = base.Items.Count - 1;
					num6 = 1;
					num = (short)1376190473;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				return num5;
				IL_267:
				num = (short)1846738945;
				if (num != 0)
				{
				}
				return -1;
			}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0007E7BC File Offset: 0x0007C9BC
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x0007E878 File Offset: 0x0007CA78
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsActive
		{
			get
			{
				short num = (short)205388989;
				short num2 = num;
				num = (short)1237843133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1417019392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1106706433;
				if (num != 0)
				{
				}
				num = (short)801701888;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.IsActiveProperty);
			}
			set
			{
				short num = (short)217787045;
				short num2 = num;
				num = (short)914893477;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1377304576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)119996417;
				if (num != 0)
				{
				}
				num = (short)383123456;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.IsActiveProperty, value);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0007E934 File Offset: 0x0007CB34
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x0007E9F0 File Offset: 0x0007CBF0
		public global::System.Windows.UIElement ApplicationMenu
		{
			get
			{
				short num = (short)122668531;
				short num2 = num;
				num = (short)1133889011;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1145569280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1123352577;
				if (num != 0)
				{
				}
				num = (short)1865875456;
				if (num != 0)
				{
				}
				return (global::System.Windows.UIElement)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.ApplicationMenuProperty);
			}
			set
			{
				short num = (short)1995388831;
				short num2 = num;
				num = (short)800733087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1723662336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467402752;
				if (num != 0)
				{
				}
				num = (short)676855809;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.ApplicationMenuProperty, value);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0007EAA4 File Offset: 0x0007CCA4
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x0007EB5C File Offset: 0x0007CD5C
		public global::System.Windows.UIElement QuickAccessToolbar
		{
			get
			{
				short num = (short)1769095803;
				short num2 = num;
				num = (short)1672954491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1506476032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)421789696;
				if (num != 0)
				{
				}
				num = (short)1362231297;
				if (num != 0)
				{
				}
				return (global::System.Windows.UIElement)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.QuickAccessToolbarProperty);
			}
			set
			{
				short num = (short)2115528494;
				short num2 = num;
				num = (short)101541678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1831731200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1986592768;
				if (num != 0)
				{
				}
				num = (short)670629889;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.QuickAccessToolbarProperty, value);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0007EC10 File Offset: 0x0007CE10
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x0007ECC8 File Offset: 0x0007CEC8
		public bool IsQuickAccessToolbarBelow
		{
			get
			{
				short num = (short)1860290985;
				short num2 = num;
				num = (short)1996147113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447152128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)196542465;
				if (num != 0)
				{
				}
				num = (short)1043857408;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.IsQuickAccessToolbarBelowProperty);
			}
			set
			{
				short num = (short)574927341;
				short num2 = num;
				num = (short)1972285933;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1459159040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)25231361;
				if (num != 0)
				{
				}
				num = (short)1348009984;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.IsQuickAccessToolbarBelowProperty, value);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0007ED84 File Offset: 0x0007CF84
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x0007EE40 File Offset: 0x0007D040
		public global::System.Windows.Thickness WindowBorderThickness
		{
			get
			{
				short num = (short)2127779260;
				short num2 = num;
				num = (short)1787712956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)755236864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)224395265;
				if (num != 0)
				{
				}
				num = (short)890306560;
				if (num != 0)
				{
				}
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.WindowBorderThicknessProperty);
			}
			set
			{
				short num = (short)2130506394;
				short num2 = num;
				num = (short)1672344218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)201457664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1550057472;
				if (num != 0)
				{
				}
				num = (short)4980737;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.WindowBorderThicknessProperty, value);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0007EEFC File Offset: 0x0007D0FC
		private static void WindowBorderThicknessChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)787904648;
			short num2 = num;
			num = (short)1714780296;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1040777216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2144731137;
			if (num != 0)
			{
			}
			num = (short)817561600;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.Ribbon)d).OnWindowBorderThicknessChanged((global::System.Windows.Thickness)e.NewValue);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0007EFBC File Offset: 0x0007D1BC
		private void OnWindowBorderThicknessChanged(global::System.Windows.Thickness t)
		{
			short num = (short)1165729128;
			short num2 = num;
			num = (short)1710136680;
			switch (num2 == num)
			{
			default:
			{
				num = (short)808452096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1939144705;
			if (num != 0)
			{
			}
			num = (short)448200704;
			if (num != 0)
			{
			}
			this.HorizontalWindowBorderThickness = new global::System.Windows.Thickness(t.Left, 0.0, t.Right, 0.0);
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0007F090 File Offset: 0x0007D290
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x0007F14C File Offset: 0x0007D34C
		public global::System.Windows.Thickness HorizontalWindowBorderThickness
		{
			get
			{
				short num = (short)1811160727;
				short num2 = num;
				num = (short)1663966871;
				switch (num2 == num)
				{
				default:
				{
					num = (short)861274112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)839254017;
				if (num != 0)
				{
				}
				num = (short)292880384;
				if (num != 0)
				{
				}
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.HorizontalWindowBorderThicknessProperty);
			}
			internal set
			{
				short num = (short)2126882764;
				short num2 = num;
				num = (short)1893509068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1331560448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)283574273;
				if (num != 0)
				{
				}
				num = (short)1819148288;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.HorizontalWindowBorderThicknessPropertyKey, value);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0007F204 File Offset: 0x0007D404
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x0007F2BC File Offset: 0x0007D4BC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object SelectedContent
		{
			get
			{
				short num = (short)1265277472;
				short num2 = num;
				num = (short)1392482848;
				switch (num2 == num)
				{
				default:
				{
					num = (short)274989056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)363986945;
				if (num != 0)
				{
				}
				num = (short)1561133056;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.Ribbon.SelectedContentProperty);
			}
			internal set
			{
				short num = (short)1196687361;
				if (num != 0)
				{
				}
				num = (short)91750400;
				short num2 = num;
				num = (short)1181286646;
				short num3 = num;
				num = (short)1239679222;
				switch (num3 == num)
				{
				}
				num = (short)1333788672;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.SelectedContentPropertyKey, value);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0007F370 File Offset: 0x0007D570
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x0007F42C File Offset: 0x0007D62C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.DataTemplate SelectedContentTemplate
		{
			get
			{
				short num = (short)1453195265;
				if (num != 0)
				{
				}
				num = (short)1679753216;
				short num2 = num;
				num = (short)666594652;
				short num3 = num;
				num = (short)1772514652;
				switch (num3 == num)
				{
				}
				num = (short)549912576;
				if (num != 0)
				{
				}
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.SelectedContentTemplateProperty);
			}
			internal set
			{
				short num = (short)845212477;
				short num2 = num;
				num = (short)1551887165;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1922170880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)128385025;
				if (num != 0)
				{
				}
				num = (short)1649475584;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.SelectedContentTemplatePropertyKey, value);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0007F4E4 File Offset: 0x0007D6E4
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0007F59C File Offset: 0x0007D79C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Controls.DataTemplateSelector SelectedContentTemplateSelector
		{
			get
			{
				short num = (short)665888138;
				short num2 = num;
				num = (short)805807498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1556873216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1873739777;
				if (num != 0)
				{
				}
				num = (short)912523264;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.SelectedContentTemplateSelectorProperty);
			}
			internal set
			{
				short num = (short)1833959425;
				if (num != 0)
				{
				}
				num = (short)839516160;
				short num2 = num;
				num = (short)1534471560;
				short num3 = num;
				num = (short)1293233544;
				switch (num3 == num)
				{
				}
				num = (short)1512046592;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.SelectedContentTemplateSelectorPropertyKey, value);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0007F650 File Offset: 0x0007D850
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x0007F708 File Offset: 0x0007D908
		public global::System.Windows.DataTemplate ContentTemplate
		{
			get
			{
				short num = (short)85065729;
				if (num != 0)
				{
				}
				num = (short)1756692480;
				short num2 = num;
				num = (short)745111262;
				short num3 = num;
				num = (short)2067365598;
				switch (num3 == num)
				{
				}
				num = (short)675676160;
				if (num != 0)
				{
				}
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.ContentTemplateProperty);
			}
			set
			{
				short num = (short)1447830322;
				short num2 = num;
				num = (short)538846002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2037710848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1296171008;
				if (num != 0)
				{
				}
				num = (short)2121007105;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.ContentTemplateProperty, value);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0007F7BC File Offset: 0x0007D9BC
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x0007F878 File Offset: 0x0007DA78
		public global::System.Windows.Controls.DataTemplateSelector ContentTemplateSelector
		{
			get
			{
				short num = (short)1445804448;
				short num2 = num;
				num = (short)797325728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50397184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1900544;
				if (num != 0)
				{
				}
				num = (short)1585512449;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.ContentTemplateSelectorProperty);
			}
			set
			{
				short num = (short)1414794624;
				short num2 = num;
				num = (short)818351488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1649475584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)543424513;
				if (num != 0)
				{
				}
				num = (short)1760231424;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.ContentTemplateSelectorProperty, value);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0007F92C File Offset: 0x0007DB2C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::DevComponents.WpfRibbon.ContextGroupCollection ContextGroups
		{
			get
			{
				short num = (short)1321336833;
				if (num != 0)
				{
				}
				num = (short)1180237824;
				short num2 = num;
				num = (short)1356896834;
				short num3 = num;
				num = (short)2142673474;
				switch (num3 == num)
				{
				}
				num = (short)668991488;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.ContextGroupCollection)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.ContextGroupsProperty);
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0007F9E4 File Offset: 0x0007DBE4
		internal static void LoadCommonStyles()
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)797179907;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1535311876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_FE;
					case 2:
					{
						num = (short)41091073;
						if (num != 0)
						{
						}
						num = (short)1378229036;
						short num3 = num;
						num = (short)625417004;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1669332992;
							if (num != 0)
							{
							}
							global::System.Windows.Application.Current.Resources.MergedDictionaries.Add(new global::DevComponents.WpfRibbon.themes.CommonStyles());
							num = (short)307560449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 4:
						if (!global::System.Windows.Application.Current.Resources.Contains(global::DevComponents.WpfRibbon.RibbonColors.CaptionBackground))
						{
							num = (short)464519170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14A;
					}
					IL_38:
					if (global::System.Windows.Application.Current == null)
					{
						goto IL_14A;
					}
					num = (short)927006720;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_FE:
			IL_14A:
			num = (short)1811349504;
			short num4 = num;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0007FB68 File Offset: 0x0007DD68
		[global::System.ComponentModel.Category("Localization")]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.NotifyParentProperty(true)]
		[global::System.ComponentModel.Description("Gets system text used by the component..")]
		public global::DevComponents.WpfRibbon.RibbonLocalization SystemText
		{
			get
			{
				short num = (short)1678676659;
				short num2 = num;
				num = (short)1425117875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1691353088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623443969;
				if (num != 0)
				{
				}
				num = (short)1242497024;
				if (num != 0)
				{
				}
				return this.m_SystemText;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0007FC18 File Offset: 0x0007DE18
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x0007FCD4 File Offset: 0x0007DED4
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AutoExpand
		{
			get
			{
				short num = (short)706231441;
				short num2 = num;
				num = (short)591084689;
				switch (num2 == num)
				{
				default:
				{
					num = (short)625737728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1970339840;
				if (num != 0)
				{
				}
				num = (short)307560449;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.AutoExpandProperty);
			}
			set
			{
				short num = (short)704315393;
				if (num != 0)
				{
				}
				num = (short)1355612160;
				short num2 = num;
				num = (short)73030919;
				short num3 = num;
				num = (short)926964999;
				switch (num3 == num)
				{
				}
				num = (short)1862991872;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.AutoExpandProperty, value);
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x0007FD8C File Offset: 0x0007DF8C
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x0007FE48 File Offset: 0x0007E048
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(true)]
		public bool CanDialogCustomizeQat
		{
			get
			{
				short num = (short)1228351513;
				short num2 = num;
				num = (short)89270297;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1499987968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1298857984;
				if (num != 0)
				{
				}
				num = (short)1536491521;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.CanDialogCustomizeQatProperty);
			}
			set
			{
				short num = (short)1206112064;
				short num2 = num;
				num = (short)2100416320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)996737024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)774832129;
				if (num != 0)
				{
				}
				num = (short)1674510336;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.CanDialogCustomizeQatProperty, value);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0007FF00 File Offset: 0x0007E100
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x0007FFBC File Offset: 0x0007E1BC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool CanChangeQatPlacement
		{
			get
			{
				short num = (short)883490817;
				if (num != 0)
				{
				}
				num = (short)45678592;
				short num2 = num;
				num = (short)316366340;
				short num3 = num;
				num = (short)1961909764;
				switch (num3 == num)
				{
				}
				num = (short)677183488;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.CanChangeQatPlacementProperty);
			}
			set
			{
				short num = (short)1746015045;
				short num2 = num;
				num = (short)2027033413;
				switch (num2 == num)
				{
				default:
				{
					num = (short)3407872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1771175937;
				if (num != 0)
				{
				}
				num = (short)635633664;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.CanChangeQatPlacementProperty, value);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00080078 File Offset: 0x0007E278
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00080134 File Offset: 0x0007E334
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(true)]
		public bool AutoHideRibbonContent
		{
			get
			{
				short num = (short)1277396937;
				short num2 = num;
				num = (short)308053961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)124518400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1145176065;
				if (num != 0)
				{
				}
				num = (short)1917255680;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.AutoHideRibbonContentProperty);
			}
			set
			{
				short num = (short)1741167996;
				short num2 = num;
				num = (short)1793990012;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988689920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)968687616;
				if (num != 0)
				{
				}
				num = (short)1270874113;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.AutoHideRibbonContentProperty, value);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x000801EC File Offset: 0x0007E3EC
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x000802A8 File Offset: 0x0007E4A8
		[global::System.ComponentModel.Browsable(true)]
		public global::System.Windows.Size AutoHideTriggerSize
		{
			get
			{
				short num = (short)748032745;
				short num2 = num;
				num = (short)214897385;
				switch (num2 == num)
				{
				default:
				{
					num = (short)458948608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1874788352;
				if (num != 0)
				{
				}
				num = (short)2071920641;
				if (num != 0)
				{
				}
				return (global::System.Windows.Size)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.AutoHideTriggerSizeProperty);
			}
			set
			{
				short num = (short)1896739160;
				short num2 = num;
				num = (short)2107109720;
				switch (num2 == num)
				{
				}
				num = (short)1380909056;
				short num3 = num;
				num = (short)454492161;
				if (num != 0)
				{
				}
				num = (short)811925504;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.AutoHideTriggerSizeProperty, value);
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00080368 File Offset: 0x0007E568
		private bool ShouldSerializeAutoHideTriggerSize()
		{
			if (this.AutoHideTriggerSize.Width == 300.0)
			{
				short num = (short)933298177;
				if (num != 0)
				{
				}
				num = (short)1458573864;
				short num2 = num;
				num = (short)1420694056;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1027276800;
					short num3 = num;
					num = (short)2076704768;
					if (num != 0)
					{
					}
					return this.AutoHideTriggerSize.Height != 250.0;
				}
				}
			}
			return true;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0008044C File Offset: 0x0007E64C
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00080504 File Offset: 0x0007E704
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(true)]
		public bool UseSpecKeyTipPositioning
		{
			get
			{
				short num = (short)1738365319;
				short num2 = num;
				num = (short)277961095;
				switch (num2 == num)
				{
				}
				num = (short)1552613376;
				short num3 = num;
				num = (short)74645505;
				if (num != 0)
				{
				}
				num = (short)1462566912;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.UseSpecKeyTipPositioningProperty);
			}
			set
			{
				short num = (short)1575781669;
				short num2 = num;
				num = (short)1696302373;
				switch (num2 == num)
				{
				}
				num = (short)265617408;
				short num3 = num;
				num = (short)166658049;
				if (num != 0)
				{
				}
				num = (short)1640693760;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.UseSpecKeyTipPositioningProperty, value);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x000805C0 File Offset: 0x0007E7C0
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00080678 File Offset: 0x0007E878
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsRibbonMenuOpen
		{
			get
			{
				short num = (short)1025668475;
				short num2 = num;
				num = (short)1147499899;
				switch (num2 == num)
				{
				}
				num = (short)1153368064;
				short num3 = num;
				num = (short)894238720;
				if (num != 0)
				{
				}
				num = (short)1199898625;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.IsRibbonMenuOpenProperty);
			}
			set
			{
				short num = (short)262733825;
				if (num != 0)
				{
				}
				num = (short)681387952;
				short num2 = num;
				num = (short)898705328;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2037645312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1809711104;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.IsRibbonMenuOpenProperty, value);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00080730 File Offset: 0x0007E930
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x000807E8 File Offset: 0x0007E9E8
		[global::System.ComponentModel.Browsable(false)]
		public bool IsMinimized
		{
			get
			{
				short num = (short)1613037569;
				if (num != 0)
				{
				}
				num = (short)124103822;
				short num2 = num;
				num = (short)340372622;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1388707840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1628241920;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.IsMinimizedProperty);
			}
			set
			{
				short num = (short)1923874817;
				if (num != 0)
				{
				}
				num = (short)951465278;
				short num2 = num;
				num = (short)706032958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1117257728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1044774912;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.IsMinimizedProperty, value);
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000808A4 File Offset: 0x0007EAA4
		private static void IsMinimizedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1320898070;
			short num2 = num;
			num = (short)30297622;
			switch (num2 == num)
			{
			}
			num = (short)1977548800;
			short num3 = num;
			num = (short)1664548865;
			if (num != 0)
			{
			}
			num = (short)1872560128;
			if (num != 0)
			{
			}
			(d as global::DevComponents.WpfRibbon.Ribbon).OnIsMinimizedChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00080970 File Offset: 0x0007EB70
		private void OnIsMinimizedChanged(bool oldValue, bool newValue)
		{
			short num = (short)844069624;
			short num2 = num;
			num = (short)1822194424;
			switch (num2 == num)
			{
			}
			num = (short)1147207680;
			short num3 = num;
			num = (short)1495728129;
			if (num != 0)
			{
			}
			num = (short)68157440;
			if (num != 0)
			{
			}
			this.UpdateMinimizedContentState();
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00080A24 File Offset: 0x0007EC24
		private void UpdateMinimizedContentState()
		{
			short num = (short)58523648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)23330829;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_355;
					case 1:
					{
						global::System.Windows.UIElement child = this.m_ContentBorder.Child;
						this.m_ContentBorder.Child = null;
						this.m_PopupBorder.Child = child;
						num = (short)1902968837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)216858634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						try
						{
							num = (short)1051328518;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)886964229;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = enumerator.Current;
									num = (short)1595277315;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_290;
								case 2:
								{
									object obj;
									((global::DevComponents.WpfRibbon.RibbonTab)obj).IsMinimizedState = this.IsMinimized;
									num = (short)452526084;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									object obj;
									if (obj is global::DevComponents.WpfRibbon.RibbonTab)
									{
										num = (short)893779970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)949420033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1D2;
									}
									continue;
								}
								IL_23D:
								num = (short)1274609664;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D2:
								goto IL_23D;
							}
							IL_290:
							goto IL_48B;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2B2;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_29F:
								switch (num2)
								{
								case 0:
									goto IL_309;
								case 1:
									goto IL_2EB;
								case 2:
									if (disposable != null)
									{
										num = (short)606863361;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_309;
								}
								goto IL_2B2;
								IL_2EB:
								disposable.Dispose();
								num = (short)1078525952;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_309:
								num = (short)2117225597;
								short num3 = num;
								num = (short)1106857085;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2EB;
								default:
									goto IL_33F;
								}
							}
							IL_33F:
							num = (short)802226176;
							if (num != 0)
							{
							}
							goto EndFinally_11;
							IL_2B2:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)862846978;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_29F;
							EndFinally_11:;
						}
						goto IL_355;
					case 5:
						goto IL_3BB;
					case 6:
					{
						num = (short)2046558208;
						short num4 = num;
						this.IsRibbonMenuOpen = false;
						num = (short)41222156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_3BB;
					case 8:
						if (this.IsMinimized)
						{
							num = (short)1893072897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1683685387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.m_ContentBorder != null)
						{
							num = (short)417464321;
							if (num != 0)
							{
							}
							num = (short)598999042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						if (this.m_PopupBorder == null)
						{
							num = (short)442761219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)45219848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.IsRibbonMenuOpen)
						{
							num = (short)1192951814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A2;
					case 12:
						goto IL_A2;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					IL_7D:
					if (this.m_Popup != null)
					{
						num = (short)307560448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_A2:
					global::System.Windows.UIElement child2 = this.m_PopupBorder.Child;
					this.m_PopupBorder.Child = null;
					this.m_ContentBorder.Child = child2;
					num = (short)1344864263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_355:
					num = (short)1147142153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BB:
					enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
					num = (short)192282628;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_48B:
				base.InvalidateMeasure();
				return;
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00080EE0 File Offset: 0x0007F0E0
		private static void IsRibbonMenuOpenChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1202430612;
			short num2 = num;
			num = (short)2137367188;
			switch (num2 == num)
			{
			}
			num = (short)1266155520;
			short num3 = num;
			num = (short)464781312;
			if (num != 0)
			{
			}
			num = (short)1571291137;
			if (num != 0)
			{
			}
			(d as global::DevComponents.WpfRibbon.Ribbon).OnIsRibbonMenuOpenChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00080FB0 File Offset: 0x0007F1B0
		private void OnIsRibbonMenuOpenChanged(bool oldValue, bool newValue)
		{
			short num = (short)98107392;
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
				global::System.Collections.IEnumerator enumerator;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						((global::DevComponents.WpfRibbon.IPopupParentControl)this).IsPopupMode = true;
						num = (short)880869377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Windows.Window window;
						if (window != null)
						{
							num = (short)723714053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A1;
					}
					case 2:
						goto IL_163;
					case 3:
						if (newValue)
						{
							num = (short)22675456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_328;
					case 4:
					{
						global::System.Windows.Window window;
						if (window != null)
						{
							num = (short)183369735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A1;
					}
					case 5:
					{
						global::System.Windows.Window window;
						window.Deactivated += this.ParentWindowDeactivated;
						num = (short)1853554694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_C9;
					case 7:
					{
						global::System.Windows.Window window;
						window.Deactivated -= this.ParentWindowDeactivated;
						num = (short)1363083264;
						short num3 = num;
						num = (short)1070792706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						try
						{
							num = (short)1045495814;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1458438149;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = enumerator.Current;
									num = (short)1327104003;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_262;
								case 2:
								{
									object obj;
									((global::DevComponents.WpfRibbon.RibbonTab)obj).IsRibbonMenuOpen = newValue;
									num = (short)1235353604;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									object obj;
									if (obj is global::DevComponents.WpfRibbon.RibbonTab)
									{
										num = (short)498008066;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1036910593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1AA;
									}
									continue;
								}
								IL_20D:
								num = (short)1350107136;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1AA:
								goto IL_20D;
							}
							IL_262:
							goto IL_361;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_284;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_271:
								switch (num2)
								{
								case 0:
									goto IL_2DC;
								case 1:
									goto IL_2BE;
								case 2:
									if (disposable != null)
									{
										num = (short)1421017089;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DC;
								}
								goto IL_284;
								IL_2BE:
								disposable.Dispose();
								num = (short)360710144;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2DC:
								num = (short)2108336164;
								short num4 = num;
								num = (short)2122950692;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2BE;
								default:
									goto IL_311;
								}
							}
							IL_311:
							num = (short)1958805504;
							if (num != 0)
							{
							}
							goto EndFinally_9;
							IL_284:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1478361090;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_271;
							EndFinally_9:;
						}
						goto IL_328;
						IL_361:
						global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
						num = (short)1594949635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_52;
					IL_328:
					num = (short)1854210052;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C9:
				IL_163:
				IL_3A1:
				base.InvalidateMeasure();
				return;
				IL_52:
				num = (short)207159297;
				if (num != 0)
				{
				}
				enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
				num = (short)296353800;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00081374 File Offset: 0x0007F574
		private void ParentWindowDeactivated(object sender, global::System.EventArgs e)
		{
			short num = (short)1697644546;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_95;
				case 1:
					goto IL_77;
				case 2:
				{
					num = (short)85983232;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				}
				IL_59:
				if (this.IsRibbonMenuOpen)
				{
					num = (short)1450508289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_95;
				IL_77:
				this.IsRibbonMenuOpen = false;
				num = (short)990707712;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_95:
				num = (short)66657015;
				short num4 = num;
				num = (short)1017715447;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_77;
				default:
					goto IL_CC;
				}
			}
			IL_CC:
			num = (short)1387593729;
			if (num != 0)
			{
			}
			num = (short)688062464;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x0008148C File Offset: 0x0007F68C
		internal bool HasCaption
		{
			get
			{
				short num = (short)1939341315;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						IL_7B:
						num = (short)1971585026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return false;
					case 2:
						num = (short)176553985;
						if (num != 0)
						{
						}
						if (this.m_QatPresenter == null)
						{
							num = (short)862715905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC;
					case 3:
					{
						num = (short)1099956224;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					}
					}
					IL_5D:
					if (this.m_AppMenuPresenter == null)
					{
						num = (short)176750592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DC:
					num = (short)1207201599;
					short num4 = num;
					num = (short)1343254335;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7B;
					default:
						goto IL_111;
					}
				}
				return false;
				IL_111:
				num = (short)1444806656;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000815C4 File Offset: 0x0007F7C4
		internal double GetTitleChromeHeight()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			double num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 += this.ApplicationMenu.RenderSize.Height + 5.0;
					num3 = (short)874004172;
					short num4 = num3;
					num3 = (short)545275596;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						return num2;
					default:
						num3 = (short)1532231680;
						if (num3 != 0)
						{
						}
						num3 = (short)306708484;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 1:
					return num2;
				case 2:
					num3 = (short)62390275;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					if (this.ApplicationMenu != null)
					{
						num3 = (short)765853696;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2 += 28.0;
					num3 = (short)1821376513;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 4:
					return num2;
				case 5:
					num2 = this.m_RibbonContentPanel.BackgroundChrome.TotalTitleChromeHeight;
					num3 = (short)40042502;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
				{
					num3 = (short)997523456;
					short num5 = num3;
					if (this.EffectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
					{
						num3 = (short)1340276738;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num2;
				}
				case 7:
					if (this.m_RibbonContentPanel != null)
					{
						num3 = (short)1138098181;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num2;
				}
				goto IL_30;
			}
			return num2;
			IL_30:
			num3 = (short)811991041;
			if (num3 != 0)
			{
			}
			num2 = 0.0;
			num3 = (short)1379991559;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x000817D4 File Offset: 0x0007F9D4
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00081890 File Offset: 0x0007FA90
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsUsingGlass
		{
			get
			{
				short num = (short)770703360;
				short num2 = num;
				num = (short)1995869314;
				short num3 = num;
				num = (short)1975946370;
				switch (num3 == num)
				{
				}
				num = (short)1038417921;
				if (num != 0)
				{
				}
				num = (short)1202388992;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Ribbon.IsUsingGlassProperty);
			}
			internal set
			{
				short num = (short)1088356352;
				short num2 = num;
				num = (short)1489591682;
				short num3 = num;
				num = (short)81812866;
				switch (num3 == num)
				{
				}
				num = (short)547684353;
				if (num != 0)
				{
				}
				num = (short)826933248;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Ribbon.IsUsingGlassPropertyKey, value);
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00081948 File Offset: 0x0007FB48
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static string GetKeyTip(global::System.Windows.UIElement element)
		{
			int a_ = 11;
			while (element == null)
			{
				short num = (short)102752639;
				short num2 = num;
				num = (short)1806885247;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2030895104;
					if (num != 0)
					{
					}
					num = (short)1600978944;
					short num3 = num;
					num = (short)357892097;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("٢।ɦѨ", a_));
				}
				}
			}
			return (string)element.GetValue(global::DevComponents.WpfRibbon.Ribbon.KeyTipProperty);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00081A28 File Offset: 0x0007FC28
		public static void SetKeyTip(global::System.Windows.UIElement element, string keytip)
		{
			int a_ = 12;
			short num = (short)834207744;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1951727616;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					continue;
				}
				case 1:
					if (keytip != null)
					{
						num = (short)1186136066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161;
				case 2:
					keytip = keytip.ToUpper();
					num = (short)132055043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_A1;
				case 4:
				{
					num = (short)2063260043;
					short num4 = num;
					num = (short)106617227;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A6;
					default:
						goto IL_111;
					}
					break;
				}
				}
				IL_6B:
				if (element == null)
				{
					num = (short)284295172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A6:
				num = (short)872022017;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A1:
			goto IL_161;
			IL_111:
			num = (short)191561729;
			if (num != 0)
			{
			}
			num = (short)649134080;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ţ੥൧ݩ", a_));
			IL_161:
			element.SetValue(global::DevComponents.WpfRibbon.Ribbon.KeyTipProperty, keytip);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00081BA4 File Offset: 0x0007FDA4
		private static void KeyTipChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)2129526784;
			short num2 = num;
			num = (short)1878651141;
			short num3 = num;
			num = (short)796586245;
			switch (num3 == num)
			{
			}
			num = (short)1166999553;
			if (num != 0)
			{
			}
			num = (short)956432384;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00081C50 File Offset: 0x0007FE50
		public static bool GetIsCustomizable(global::System.Windows.FrameworkElement element)
		{
			int a_ = 17;
			while (element == null)
			{
				short num = (short)1698365441;
				if (num != 0)
				{
				}
				num = (short)1728886899;
				short num2 = num;
				num = (short)1468643443;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)5505024;
					short num3 = num;
					num = (short)891486208;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("౨ݪ࡬ɮ", a_));
				}
				}
			}
			return (bool)element.GetValue(global::DevComponents.WpfRibbon.Ribbon.IsCustomizableProperty);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00081D30 File Offset: 0x0007FF30
		public static void SetIsCustomizable(global::System.Windows.FrameworkElement element, bool value)
		{
			int a_ = 14;
			while (element == null)
			{
				short num = (short)11246941;
				short num2 = num;
				num = (short)1984732509;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)435748864;
					if (num != 0)
					{
					}
					num = (short)462356480;
					short num3 = num;
					num = (short)700252161;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ͥѧཀྵū", a_));
				}
				}
			}
			element.SetValue(global::DevComponents.WpfRibbon.Ribbon.IsCustomizableProperty, value);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00081E10 File Offset: 0x00080010
		public static global::DevComponents.WpfRibbon.eElementRole GetElementRole(global::System.Windows.FrameworkElement element)
		{
			int a_ = 18;
			while (element == null)
			{
				short num = (short)1856317263;
				short num2 = num;
				num = (short)1967728463;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)137101313;
					if (num != 0)
					{
					}
					num = (short)1660682240;
					short num3 = num;
					num = (short)1106509824;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ཀྵk୭ᵯ", a_));
				}
				}
			}
			return (global::DevComponents.WpfRibbon.eElementRole)element.GetValue(global::DevComponents.WpfRibbon.Ribbon.ElementRoleProperty);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00081EF4 File Offset: 0x000800F4
		public static void SetElementRole(global::System.Windows.FrameworkElement element, global::DevComponents.WpfRibbon.eElementRole value)
		{
			int a_ = 5;
			while (element == null)
			{
				short num = (short)964088954;
				short num2 = num;
				num = (short)1394922618;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)354025473;
					if (num != 0)
					{
					}
					num = (short)917372928;
					short num3 = num;
					num = (short)1621950464;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㡜㍞Ѡ๢", a_));
				}
				}
			}
			element.SetValue(global::DevComponents.WpfRibbon.Ribbon.ElementRoleProperty, value);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00081FD0 File Offset: 0x000801D0
		public static bool GetLivePreviewEnabled(global::System.Windows.FrameworkElement element)
		{
			int a_ = 5;
			short num;
			while (element == null)
			{
				num = (short)1450872088;
				short num2 = num;
				num = (short)1770818840;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)525598720;
					if (num != 0)
					{
					}
					num = (short)2115895296;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㡜㍞Ѡ๢", a_));
				}
				}
			}
			num = (short)1652097025;
			if (num != 0)
			{
			}
			return (bool)element.GetValue(global::DevComponents.WpfRibbon.Ribbon.LivePreviewEnabledProperty);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000820B0 File Offset: 0x000802B0
		public static void SetLivePreviewEnabled(global::System.Windows.FrameworkElement element, bool value)
		{
			int a_ = 10;
			while (element == null)
			{
				short num = (short)914838758;
				short num2 = num;
				num = (short)812733670;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2050752513;
					if (num != 0)
					{
					}
					num = (short)176422912;
					short num3 = num;
					num = (short)914948096;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ݡࡣͥէ", a_));
				}
				}
			}
			element.SetValue(global::DevComponents.WpfRibbon.Ribbon.LivePreviewEnabledProperty, value);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00082190 File Offset: 0x00080390
		private static void IsCustomizableChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)227147776;
			short num2 = num;
			num = (short)743779746;
			short num3 = num;
			num = (short)2118856098;
			switch (num3 == num)
			{
			}
			num = (short)2090532865;
			if (num != 0)
			{
			}
			num = (short)1976565760;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00082238 File Offset: 0x00080438
		internal static bool GetIsCustomizableContextSet(global::System.Windows.FrameworkElement element)
		{
			int a_ = 13;
			while (element == null)
			{
				short num = (short)839394138;
				short num2 = num;
				num = (short)239870810;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1608384513;
					if (num != 0)
					{
					}
					num = (short)32047104;
					short num3 = num;
					num = (short)1685651456;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("d୦౨٪", a_));
				}
				}
			}
			return (bool)element.GetValue(global::DevComponents.WpfRibbon.Ribbon.IsCustomizableContextSetProperty);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00082314 File Offset: 0x00080514
		internal static void SetIsCustomizableContextSet(global::System.Windows.FrameworkElement element, bool value)
		{
			int a_ = 18;
			while (element == null)
			{
				short num = (short)1912340481;
				if (num != 0)
				{
				}
				num = (short)501488259;
				short num2 = num;
				num = (short)1004214915;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)987365376;
					short num3 = num;
					num = (short)412024832;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ཀྵk୭ᵯ", a_));
				}
				}
			}
			element.SetValue(global::DevComponents.WpfRibbon.Ribbon.IsCustomizableContextSetProperty, value);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x000823F4 File Offset: 0x000805F4
		protected override void OnPreviewMouseRightButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)2013462548;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.FrameworkElement frameworkElement;
				global::System.Windows.FrameworkElement elementAt;
				switch (num2)
				{
				case 0:
					if (e.Source != null)
					{
						num = (short)1990262784;
						short num3 = num;
						num = (short)1173684254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69D;
				case 1:
					num = (short)1776680967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)401866756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (((global::DevComponents.WpfRibbon.ButtonDropDown)frameworkElement).IsPopupOpen)
					{
						num = (short)1072955424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_358;
				case 4:
					if (e.Source != this)
					{
						num = (short)766312463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69D;
				case 5:
					if (!e.Handled)
					{
						num = (short)605487114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69D;
				case 6:
					if (((global::DevComponents.WpfRibbon.ApplicationMenu)frameworkElement).IsPopupOpen)
					{
						num = (short)333316110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D8;
				case 7:
					if (!(frameworkElement is global::DevComponents.WpfRibbon.Qat))
					{
						num = (short)1024983080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3CD;
				case 8:
					if (frameworkElement is global::DevComponents.WpfRibbon.ApplicationMenu)
					{
						num = (short)265682971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D8;
				case 9:
					num = (short)1951072257;
					if (num != 0)
					{
					}
					num = (short)1055391747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)1333657600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (!(frameworkElement is global::DevComponents.WpfRibbon.RibbonBar))
					{
						num = (short)1976762369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3CD;
				case 12:
					if (frameworkElement.ContextMenu == null)
					{
						num = (short)782499875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69D;
				case 13:
					goto IL_626;
				case 14:
					goto IL_3CD;
				case 15:
					num = (short)439746565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (frameworkElement is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num = (short)1341653001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_358;
				case 17:
					frameworkElement = (e.Source as global::System.Windows.FrameworkElement);
					num = (short)1344733195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (!((global::DevComponents.WpfRibbon.ApplicationMenu)frameworkElement).IsPopupOpen)
					{
						num = (short)1449787429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_626;
				case 19:
					goto IL_358;
				case 20:
					switch (0)
					{
					case 0:
						goto IL_C8;
					}
					continue;
				case 21:
					num = (short)1221263378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (elementAt != null)
					{
						num = (short)587333671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_626;
				case 23:
					num = (short)352518160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					goto IL_3C8;
				case 25:
					goto IL_626;
				case 26:
					if (!frameworkElement.IsEnabled)
					{
						num = (short)809500710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_393;
				case 27:
					num = (short)1412300806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
				{
					if (!global::DevComponents.WpfRibbon.Ribbon.GetIsCustomizable(frameworkElement))
					{
						goto IL_69D;
					}
					num = (short)731679266;
					short num4 = num;
					num = (short)1968015906;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)788660224;
						if (num != 0)
						{
						}
						num = (short)1908801559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 29:
					goto IL_393;
				case 30:
					num = (short)663093281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (frameworkElement is global::DevComponents.WpfRibbon.ApplicationMenu)
					{
						num = (short)1425866773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_626;
				case 32:
					((global::DevComponents.WpfRibbon.ButtonDropDown)frameworkElement).IsPopupOpen = false;
					num = (short)1718550547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					if (e.Source is global::System.Windows.FrameworkElement)
					{
						num = (short)130482193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69D;
				case 34:
					num = (short)1051721740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					num = (short)222363676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (frameworkElement != null)
					{
						num = (short)68288546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69D;
				case 37:
					frameworkElement = null;
					num = (short)683933721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					global::System.Windows.Controls.ContextMenuService.SetShowOnDisabled(frameworkElement, true);
					num = (short)600440861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					frameworkElement = elementAt;
					num = (short)1452343309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					num = (short)432603144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C8:
				if (global::DevComponents.WpfRibbon.Ribbon.GetIsCustomizable(this))
				{
					num = (short)1008730114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2D8:
				num = (short)1672282143;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_358:
				num = (short)1628307482;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_393:
				global::System.Windows.Controls.ContextMenu customizeContextMenu = this.GetCustomizeContextMenu();
				this.SetupCustomizeContextMenu(customizeContextMenu, frameworkElement);
				frameworkElement.ContextMenu = customizeContextMenu;
				global::DevComponents.WpfRibbon.Ribbon.SetIsCustomizableContextSet(frameworkElement, true);
				num = (short)1714028568;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3CD:
				elementAt = global::DevComponents.WpfRibbon.LayoutHelpers.GetElementAt(frameworkElement, frameworkElement.PointToScreen(e.GetPosition(frameworkElement)));
				num = (short)656801814;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_626:
				num = (short)1217527844;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3C8:
			IL_69D:
			base.OnPreviewMouseRightButtonUp(e);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00082AA8 File Offset: 0x00080CA8
		private void SetupCustomizeContextMenu(global::System.Windows.Controls.ContextMenu cm, global::System.Windows.FrameworkElement elem)
		{
			short num = (short)2144272384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_142;
				}
				global::System.Windows.Visibility visibility;
				global::System.Windows.Visibility visibility3;
				global::System.Windows.Visibility visibility4;
				bool isEnabled;
				global::System.Windows.DependencyObject parent;
				global::System.Windows.Visibility visibility5;
				global::System.Windows.Visibility visibility6;
				for (;;)
				{
					IL_27:
					global::System.Windows.Controls.MenuItem menuItem;
					global::System.Windows.Visibility visibility2;
					int num3;
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_553;
					case 1:
						goto IL_74F;
					case 2:
						menuItem.Visibility = visibility;
						num = (short)1610350610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_6CA;
					case 4:
						visibility2 = global::System.Windows.Visibility.Collapsed;
						goto IL_6A4;
					case 5:
						menuItem.CommandTarget = this;
						menuItem.CommandParameter = elem;
						num = (short)324927498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						visibility3 = global::System.Windows.Visibility.Visible;
						num = (short)869269505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_9F0;
					case 8:
						goto IL_3CC;
					case 9:
					{
						if (num3 >= cm.Items.Count)
						{
							num = (short)1617887279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = cm.Items[num3];
						num = (short)1844838452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_553;
					case 11:
						if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemQatMinMaxRibbonMenuItem)
						{
							num = (short)1111556112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1584857105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1938227255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						visibility4 = global::System.Windows.Visibility.Visible;
						isEnabled = false;
						num = (short)1801322549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemCustomizeQatMenuItem)
						{
							num = (short)1093074984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_553;
					case 15:
						goto IL_553;
					case 16:
						num = (short)226492477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemAddToQatMenuItem)
						{
							num = (short)2050490433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)279773212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)95158277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						menuItem.CommandTarget = null;
						menuItem.CommandParameter = null;
						num = (short)1324285989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_553;
					case 20:
					{
						object obj;
						((global::System.Windows.Controls.Separator)obj).Visibility = global::System.Windows.Visibility.Collapsed;
						num = (short)1054933027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						num = (short)1232470042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (flag)
						{
							num = (short)1240465428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_553;
					case 23:
						num = (short)1613299734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (!(elem is global::DevComponents.WpfRibbon.RibbonTab))
						{
							num = (short)1946943536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CA;
					case 25:
						if (!this.AutoExpand)
						{
							num = (short)1146880038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)77332547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (!(parent is global::DevComponents.WpfRibbon.QatPanel))
						{
							num = (short)2122055692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CA;
					case 27:
						goto IL_553;
					case 28:
						if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemRemoveFromQatMenuItem)
						{
							num = (short)52297730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)182255630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (elem.Parent != this.QuickAccessToolbar)
						{
							num = (short)165543949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CA;
					case 30:
					{
						object obj;
						menuItem = (obj as global::System.Windows.Controls.MenuItem);
						num = (short)168165409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						if (visibility4 == global::System.Windows.Visibility.Visible)
						{
							num = (short)1408827441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1541275648;
						short num4 = num;
						menuItem.CommandTarget = null;
						menuItem.CommandParameter = null;
						num = (short)1729691675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						num = (short)1709965355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemQatChangePlacementMenuItem)
						{
							num = (short)2139684930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)313524235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						flag = false;
						num = (short)1094713351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_553;
					case 36:
						goto IL_890;
					case 37:
						goto IL_553;
					case 38:
						num = (short)1962409988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (!(parent is global::DevComponents.WpfRibbon.Qat))
						{
							num = (short)823197717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CA;
					case 40:
						menuItem.Visibility = visibility5;
						num = (short)271515663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_3CC;
					case 42:
						num = (short)1185284125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (this.IsElementOnQat(elem))
						{
							num = (short)851443754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						visibility4 = global::System.Windows.Visibility.Visible;
						num = (short)1000538115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (this.CanDialogCustomizeQat)
						{
							num = (short)1251672118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_214;
					case 45:
					{
						object obj;
						if (((global::System.Windows.FrameworkElement)obj).Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1125187618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F0;
					}
					case 46:
						menuItem.Header = this.SystemText.QatPlaceAboveRibbonText;
						num = (short)979828794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						return;
					case 48:
						num = (short)202178599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						menuItem.CommandTarget = this;
						menuItem.CommandParameter = elem;
						num = (short)851378240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						menuItem.Header = this.SystemText.MaximizeRibbonText;
						num = (short)462553129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						object obj;
						if (obj is global::System.Windows.Controls.Separator)
						{
							num = (short)486604823;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_553;
					}
					case 52:
					{
						object obj;
						if (obj is global::System.Windows.Controls.MenuItem)
						{
							num = (short)1006305310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1530331187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						goto IL_6CA;
					case 54:
						visibility5 = global::System.Windows.Visibility.Visible;
						num = (short)440467519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						if (!(parent is global::DevComponents.WpfRibbon.QatOverflowPanel))
						{
							num = (short)1261043744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CA;
					case 56:
						if (this.CanChangeQatPlacement)
						{
							num = (short)1283260422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74F;
					case 57:
					{
						object obj;
						if (obj is global::System.Windows.FrameworkElement)
						{
							goto IL_577;
						}
						goto IL_9F0;
					}
					case 58:
						goto IL_890;
					case 59:
						num = (short)2091188269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						goto IL_43D;
					case 61:
						if (this.IsMinimized)
						{
							num = (short)1431633970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						menuItem.Header = this.SystemText.MinimizeRibbonText;
						num = (short)882835464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_43D;
					case 63:
						goto IL_214;
					case 64:
						goto IL_553;
					case 65:
						menuItem.Visibility = visibility4;
						menuItem.IsEnabled = isEnabled;
						num = (short)1721761823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						num = (short)1351680068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						visibility2 = global::System.Windows.Visibility.Visible;
						goto IL_6A4;
					case 68:
						if (this.IsQuickAccessToolbarBelow)
						{
							num = (short)1683423278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						menuItem.Header = this.SystemText.QatPlaceBelowRibbonText;
						num = (short)1670643748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_142;
					IL_214:
					num = (short)1997641422;
					short num5 = num;
					num = (short)218273486;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_577:
						num = (short)823590971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)539426817;
						if (num != 0)
						{
						}
						num = (short)1926692864;
						if (num != 0)
						{
						}
						num = (short)1140588600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3CC:
					menuItem.Visibility = visibility6;
					num = (short)246349843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43D:
					num = (short)1888485385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_553:
					num = (short)606535737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6A4:
					visibility6 = visibility2;
					flag = true;
					num3 = 0;
					num = (short)67305534;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CA:
					num = (short)1052835884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74F:
					num = (short)895025177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_890:
					menuItem.Visibility = visibility3;
					num = (short)1453064192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F0:
					num3++;
					num = (short)690356284;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_142:
				parent = global::System.Windows.LogicalTreeHelper.GetParent(elem);
				visibility4 = global::System.Windows.Visibility.Collapsed;
				visibility = global::System.Windows.Visibility.Collapsed;
				visibility5 = global::System.Windows.Visibility.Collapsed;
				visibility3 = global::System.Windows.Visibility.Collapsed;
				visibility6 = global::System.Windows.Visibility.Collapsed;
				isEnabled = true;
				num = (short)934936600;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0008366C File Offset: 0x0008186C
		public bool IsElementOnQat(global::System.Windows.FrameworkElement elem)
		{
			int a_ = 1;
			short num = (short)1873412096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				global::System.Windows.Controls.ItemsControl itemsControl;
				for (;;)
				{
					IL_30:
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						if (buttonDropDown != null)
						{
							num = (short)775815169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_630;
					case 1:
						num = (short)1542127620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (itemsControl.Items.Contains(elem))
						{
							num = (short)901775377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124;
					case 3:
						goto IL_5EA;
					case 4:
					{
						num = (short)184221696;
						short num3 = num;
						if (buttonDropDown.Command == null)
						{
							num = (short)931594241;
							if (num != 0)
							{
							}
							num = (short)175898627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_630;
					}
					case 5:
						if (elem.Name == "")
						{
							num = (short)1237385235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_630;
					case 6:
						if (elem != null)
						{
							num = (short)563347467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124;
					case 7:
						if (buttonDropDown != null)
						{
							num = (short)2047606798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						num = (short)281214989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.QuickAccessToolbar != null)
						{
							num = (short)838795272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 10:
						try
						{
							num = (short)1555693572;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Windows.FrameworkElement frameworkElement;
									if (!(frameworkElement.Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("੘≚⹜๞`ᝢ❤ቦᵨὪɬŮ⹰", a_) + elem.Name))
									{
										num = (short)2062286858;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D6;
								}
								case 1:
									num = (short)502792204;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Windows.FrameworkElement frameworkElement;
									if (!(frameworkElement.Name == elem.Name))
									{
										num = (short)697368589;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D6;
								}
								case 3:
								{
									global::System.Windows.FrameworkElement frameworkElement;
									if (frameworkElement != null)
									{
										num = (short)263651336;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1D7;
									}
									continue;
								case 5:
									goto IL_450;
								case 6:
									goto IL_3F2;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1435238415;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.FrameworkElement frameworkElement = enumerator.Current as global::System.Windows.FrameworkElement;
									num = (short)666042371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1552613390;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (buttonDropDown != null)
									{
										num = (short)1266745345;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
									goto IL_3F7;
								case 11:
									num = (short)1974730754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::System.Windows.FrameworkElement frameworkElement;
									if (((global::DevComponents.WpfRibbon.ButtonDropDown)frameworkElement).Command == buttonDropDown.Command)
									{
										num = (short)779354130;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									num = (short)640286720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::System.Windows.FrameworkElement frameworkElement;
									if (frameworkElement.Name != "")
									{
										num = (short)90308619;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3F7;
								}
								case 15:
									num = (short)205062149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									global::System.Windows.FrameworkElement frameworkElement;
									if (frameworkElement is global::DevComponents.WpfRibbon.ButtonDropDown)
									{
										num = (short)648151057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 17:
									num = (short)738983945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_3D6;
								}
								IL_1D9:
								num = (short)994639879;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D7:
								goto IL_1D9;
								IL_3D6:
								result = true;
								num = (short)462159878;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3F7:
								num = (short)485425168;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3F2:
							return result;
							IL_450:
							return false;
						}
						finally
						{
							num = (short)2075298384;
							short num4 = num;
							num = (short)1598982736;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_4C6:
								num = (short)267517954;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)2105671680;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_4BE;
								}
								break;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_516;
								case 1:
									disposable.Dispose();
									num = (short)67960832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)2102657025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_518;
								}
								goto IL_4BE;
							}
							IL_516:
							IL_518:
							goto EndFinally_23;
							IL_4BE:
							disposable = (enumerator as global::System.IDisposable);
							goto IL_4C6;
							EndFinally_23:;
						}
						goto IL_519;
					case 11:
						num = (short)129761292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (itemsControl != null)
						{
							num = (short)1786970127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124;
					case 13:
						if (this.QuickAccessToolbar is global::System.Windows.Controls.ItemsControl)
						{
							num = (short)1271201810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 14:
						goto IL_D9;
					case 15:
						goto IL_519;
					case 16:
						if (elem != null)
						{
							num = (short)130023446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						return true;
					case 18:
						num = (short)2004156436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1580990464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (elem.Name == "")
						{
							num = (short)1526005781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
					case 21:
						num = (short)710213639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)586350601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93;
					IL_D9:
					num = (short)1444806661;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_124:
					buttonDropDown = (elem as global::DevComponents.WpfRibbon.ButtonDropDown);
					num = (short)979566608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_519:
					num = (short)728104962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_630:
					enumerator = ((global::System.Collections.IEnumerable)itemsControl.Items).GetEnumerator();
					num = (short)1628307466;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_5EA:
				return false;
				IL_93:
				itemsControl = (this.QuickAccessToolbar as global::System.Windows.Controls.ItemsControl);
				num = (short)973471750;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00083E38 File Offset: 0x00082038
		protected override void OnContextMenuClosing(global::System.Windows.Controls.ContextMenuEventArgs e)
		{
			short num = (short)626296630;
			short num2 = num;
			num = (short)1852278582;
			switch (num2 == num)
			{
			}
			num = (short)42139649;
			if (num != 0)
			{
			}
			num = (short)123142144;
			if (num != 0)
			{
			}
			num = (short)1436811264;
			short num3 = num;
			this.HandleContextMenuClosing(e);
			base.OnContextMenuClosing(e);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00083EF0 File Offset: 0x000820F0
		private void HandleContextMenuClosing(global::System.Windows.Controls.ContextMenuEventArgs e)
		{
			short num = (short)451674115;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1101791232;
					short num3 = num;
					global::System.Windows.FrameworkElement frameworkElement = e.Source as global::System.Windows.FrameworkElement;
					goto IL_10E;
				}
				case 1:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					if (global::DevComponents.WpfRibbon.Ribbon.GetIsCustomizableContextSet(frameworkElement))
					{
						num = (short)1969291268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 4:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					global::System.Windows.Controls.ContextMenu contextMenu = frameworkElement.ContextMenu;
					frameworkElement.ContextMenu = null;
					num = (short)1512116125;
					short num4 = num;
					num = (short)1902514077;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10E;
					default:
						num = (short)106299392;
						if (num != 0)
						{
						}
						num = (short)1980760065;
						if (num != 0)
						{
						}
						num = (short)1587740674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (e.Source is global::System.Windows.FrameworkElement)
					{
						num = (short)2064384000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					num = (short)1579745285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_42:
				if (e.Source != null)
				{
					num = (short)2003632134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_10E:
				num = (short)643432449;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000840B4 File Offset: 0x000822B4
		private global::System.Windows.Controls.ContextMenu GetCustomizeContextMenu()
		{
			int a_ = 6;
			short num = (short)504299520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_57;
				}
				global::System.Windows.Controls.ContextMenu contextMenu;
				for (;;)
				{
					IL_30:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)346357760;
						short num3 = num;
						try
						{
							num = (short)2045247495;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1346174995;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Windows.Controls.MenuItem menuItem;
									menuItem.Name = global::DevComponents.WpfRibbon.Ribbon.SystemRemoveFromQatMenuItem;
									menuItem.Header = this.SystemText.QatRemoveItemText;
									num = (short)1940062218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::System.Windows.Controls.MenuItem menuItem;
									if (menuItem != null)
									{
										num = (short)529334289;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Windows.Controls.MenuItem menuItem;
									if ((string)menuItem.Header == global::DevComponents.WpfRibbon.Ribbon.SystemAddToQatMenuItem)
									{
										num = (short)2045378580;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1697185800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Windows.Controls.MenuItem menuItem;
									if ((string)menuItem.Header == global::DevComponents.WpfRibbon.Ribbon.SystemRemoveFromQatMenuItem)
									{
										num = (short)1179516929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::System.Windows.Controls.MenuItem menuItem;
									if ((string)menuItem.Header == global::DevComponents.WpfRibbon.Ribbon.SystemQatMinMaxRibbonMenuItem)
									{
										num = (short)882311179;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2030501892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_24F;
									}
									continue;
								case 8:
								{
									global::System.Windows.Controls.MenuItem menuItem;
									if ((string)menuItem.Header == global::DevComponents.WpfRibbon.Ribbon.SystemCustomizeQatMenuItem)
									{
										num = (short)1510146057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)724500494;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::System.Windows.Controls.MenuItem menuItem;
									menuItem.Name = global::DevComponents.WpfRibbon.Ribbon.SystemCustomizeQatMenuItem;
									menuItem.Header = this.SystemText.QatCustomizeText;
									num = (short)1181155333;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::System.Windows.Controls.MenuItem menuItem;
									menuItem.Name = global::DevComponents.WpfRibbon.Ribbon.SystemQatMinMaxRibbonMenuItem;
									menuItem.Header = this.SystemText.MinimizeRibbonText;
									num = (short)1002897420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::System.Windows.Controls.MenuItem menuItem;
									if ((string)menuItem.Header == global::DevComponents.WpfRibbon.Ribbon.SystemQatChangePlacementMenuItem)
									{
										num = (short)1985282064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1713700870;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)750518272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Controls.MenuItem menuItem = enumerator.Current as global::System.Windows.Controls.MenuItem;
									num = (short)329973762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									global::System.Windows.Controls.MenuItem menuItem;
									menuItem.Name = global::DevComponents.WpfRibbon.Ribbon.SystemQatChangePlacementMenuItem;
									menuItem.Header = this.SystemText.QatPlaceBelowRibbonText;
									num = (short)793772050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
									num = (short)1960574979;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									goto IL_59C;
								case 20:
								{
									global::System.Windows.Controls.MenuItem menuItem;
									menuItem.Name = global::DevComponents.WpfRibbon.Ribbon.SystemAddToQatMenuItem;
									menuItem.Header = this.SystemText.QatAddItemText;
									num = (short)1327824909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_350:
								num = (short)802619407;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_24F:
								goto IL_350;
							}
							IL_59C:
							goto IL_15D;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_5BE;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_5AB:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)910295042;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_611;
								case 1:
									goto IL_60F;
								case 2:
									disposable.Dispose();
									num = (short)145162241;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5BE;
							}
							IL_60F:
							IL_611:
							goto EndFinally_14;
							IL_5BE:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)11862016;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_5AB;
							EndFinally_14:;
						}
						goto IL_612;
					}
					case 1:
						num = (short)1880162310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_B6;
					case 3:
						if (!(contextMenu.Name == ""))
						{
							num = (short)1325596673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B6;
					case 4:
						if (contextMenu != null)
						{
							num = (short)1954152455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_612;
					case 5:
						goto IL_612;
					case 6:
						if (contextMenu.Name == null)
						{
							num = (short)1738932226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15D;
					case 7:
						num = (short)1186136067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_57;
					IL_CD:
					num = (short)440074240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_612:
					num = (short)142826291;
					short num4 = num;
					num = (short)481909555;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CD;
					default:
						goto IL_649;
					}
					IL_B6:
					contextMenu.Name = global::DevComponents.WpfRibbon.Ribbon.SysQatCustomizeContextMenu;
					enumerator = ((global::System.Collections.IEnumerable)contextMenu.Items).GetEnumerator();
					goto IL_CD;
					IL_15D:
					contextMenu.Closed += this.CustomizeContextMenuClosed;
					this.AddMenuItemEventHandlers(contextMenu);
					num = (short)600440837;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_649:
				num = (short)535756801;
				if (num != 0)
				{
				}
				num = (short)2147024896;
				if (num != 0)
				{
				}
				return contextMenu;
				IL_57:
				contextMenu = (base.FindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ཝşᙡ❣፥᭧ṩͫͭ᥯ࡱᅳ㕵᝷ᑹࡻ᭽즃ﾉ", a_))) as global::System.Windows.Controls.ContextMenu);
				num = (short)1387790340;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00084768 File Offset: 0x00082968
		private void AddMenuItemEventHandlers(global::System.Windows.Controls.ContextMenu cm)
		{
			short num = (short)867668405;
			short num2 = num;
			num = (short)1397920181;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1252917249;
				if (num != 0)
				{
				}
				num = (short)1747255296;
				if (num != 0)
				{
				}
				num = (short)1052246016;
				short num3 = num;
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)cm.Items).GetEnumerator();
				try
				{
					num = (short)1860042759;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1528758277;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.Controls.MenuItem menuItem = enumerator.Current as global::System.Windows.Controls.MenuItem;
							num = (short)1576927248;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Click += this.ContextMenuAddToQatClick;
							num = (short)429522954;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Click += this.ContextMenuCustomizeQatClick;
							num = (short)636551182;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemAddToQatMenuItem)
							{
								num = (short)1678901249;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1877999633;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1689059347;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemQatChangePlacementMenuItem)
							{
								num = (short)1842937867;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2086600712;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							switch (0)
							{
							case 0:
								goto IL_123;
							}
							continue;
						case 8:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemQatMinMaxRibbonMenuItem)
							{
								num = (short)435879945;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1808007186;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Click += this.ContextMenuMinMaxRibbonClick;
							num = (short)535953423;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Click += this.ContextMenuQatChangePlacementClick;
							num = (short)2020605954;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)1959460868;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Click += this.ContextMenuRemoveFromQatClick;
							num = (short)1697906708;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem != null)
							{
								num = (short)980418572;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 17:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemCustomizeQatMenuItem)
							{
								num = (short)621346819;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)400490502;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemRemoveFromQatMenuItem)
							{
								num = (short)1808859149;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 19:
							goto IL_414;
						}
						IL_217:
						num = (short)2052915200;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_123:
						goto IL_217;
					}
					IL_414:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_432;
					}
					int num4;
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_420:
						switch (num4)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)449576962;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_483;
						case 1:
							goto IL_481;
						case 2:
							disposable.Dispose();
							num = (short)1938620417;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_432;
					}
					IL_481:
					IL_483:
					break;
					IL_432:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)188088320;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_420;
				}
				break;
			}
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00084C18 File Offset: 0x00082E18
		private void CustomizeContextMenuClosed(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)939860069;
			short num2 = num;
			num = (short)83370085;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_4BF;
			case 1:
				break;
			default:
			{
				num = (short)1534328832;
				short num3 = num;
				break;
			}
			}
			num = (short)1817378817;
			if (num != 0)
			{
			}
			num = (short)433848320;
			if (num != 0)
			{
			}
			num = (short)1003945984;
			int num4 = (int)num;
			global::System.Windows.Controls.ContextMenu contextMenu;
			switch (num4)
			{
			default:
			{
				contextMenu = (global::System.Windows.Controls.ContextMenu)sender;
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)contextMenu.Items).GetEnumerator();
				try
				{
					num = (short)1873936391;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)915865605;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.Controls.MenuItem menuItem = enumerator.Current as global::System.Windows.Controls.MenuItem;
							num = (short)2017591312;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Click -= this.ContextMenuAddToQatClick;
							num = (short)996278282;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Click -= this.ContextMenuCustomizeQatClick;
							num = (short)1294598158;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemAddToQatMenuItem)
							{
								num = (short)109903873;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1819738129;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)95748115;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemQatChangePlacementMenuItem)
							{
								num = (short)453443595;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1848246280;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							switch (0)
							{
							case 0:
								goto IL_14B;
							}
							continue;
						case 8:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemQatMinMaxRibbonMenuItem)
							{
								num = (short)1779761161;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1519910930;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Click -= this.ContextMenuMinMaxRibbonClick;
							num = (short)124256271;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Click -= this.ContextMenuQatChangePlacementClick;
							num = (short)1035993090;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)1554513924;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							menuItem.Click -= this.ContextMenuRemoveFromQatClick;
							num = (short)1199636500;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem != null)
							{
								num = (short)1958608908;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 17:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemCustomizeQatMenuItem)
							{
								num = (short)1269170179;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1078067206;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							global::System.Windows.Controls.MenuItem menuItem;
							if (menuItem.Name == global::DevComponents.WpfRibbon.Ribbon.SystemRemoveFromQatMenuItem)
							{
								num = (short)183959565;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 19:
							goto IL_44B;
						}
						IL_241:
						num = (short)970129408;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_14B:
						goto IL_241;
					}
					IL_44B:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_46A;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_457:
						switch (num4)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)14614530;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4BE;
						case 1:
							goto IL_4BC;
						case 2:
							disposable.Dispose();
							num = (short)1549271041;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46A;
					}
					IL_4BC:
					IL_4BE:
					break;
					IL_46A:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1289682944;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_457;
				}
				break;
			}
			}
			IL_4BF:
			contextMenu.Closed -= this.CustomizeContextMenuClosed;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00085114 File Offset: 0x00083314
		private void ContextMenuRemoveFromQatClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)661960716;
			short num2 = num;
			num = (short)388872204;
			switch (num2 == num)
			{
			}
			num = (short)563937281;
			if (num != 0)
			{
			}
			num = (short)1812267008;
			short num3 = num;
			num = (short)1421213696;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.ContextMenu contextMenu = ((global::System.Windows.Controls.MenuItem)sender).Parent as global::System.Windows.Controls.ContextMenu;
			this.RemoveFromQat(contextMenu.PlacementTarget);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000851E0 File Offset: 0x000833E0
		private void ContextMenuMinMaxRibbonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1822031873;
			if (num != 0)
			{
			}
			num = (short)1936611117;
			short num2 = num;
			num = (short)752113453;
			switch (num2 == num)
			{
			}
			num = (short)544997376;
			short num3 = num;
			num = (short)495714304;
			if (num != 0)
			{
			}
			this.ToggleRibbonMinimized();
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0008528C File Offset: 0x0008348C
		private void ContextMenuQatChangePlacementClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)745371300;
			short num2 = num;
			num = (short)1330673316;
			switch (num2 == num)
			{
			}
			num = (short)1249312768;
			if (num != 0)
			{
			}
			num = (short)347799552;
			short num3 = num;
			num = (short)1861615617;
			if (num != 0)
			{
			}
			this.ChangeQatPlacement();
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0008533C File Offset: 0x0008353C
		private void ContextMenuCustomizeQatClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1123943522;
			short num2 = num;
			num = (short)918881378;
			switch (num2 == num)
			{
			}
			num = (short)774307840;
			if (num != 0)
			{
			}
			num = (short)2052784128;
			short num3 = num;
			num = (short)1929969665;
			if (num != 0)
			{
			}
			this.OnQatDialogCustomize();
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000853EC File Offset: 0x000835EC
		private void ContextMenuAddToQatClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1303494506;
			short num2 = num;
			num = (short)269336426;
			switch (num2 == num)
			{
			}
			num = (short)813039616;
			if (num != 0)
			{
			}
			num = (short)2051342336;
			short num3 = num;
			num = (short)1375535105;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.ContextMenu contextMenu = ((global::System.Windows.Controls.MenuItem)sender).Parent as global::System.Windows.Controls.ContextMenu;
			this.AddToQat(contextMenu.PlacementTarget);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000854B0 File Offset: 0x000836B0
		internal void ToggleRibbonMinimized()
		{
			short num = (short)1122115402;
			short num2 = num;
			num = (short)1818894154;
			switch (num2 == num)
			{
			}
			num = (short)432013313;
			if (num != 0)
			{
			}
			num = (short)2035679232;
			short num3 = num;
			num = (short)2018050048;
			if (num != 0)
			{
			}
			this.IsMinimized = !this.IsMinimized;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00085568 File Offset: 0x00083768
		private void ToggleRibbonMinimizeExecuted(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			short num = (short)1859899054;
			short num2 = num;
			num = (short)256036526;
			switch (num2 == num)
			{
			}
			num = (short)564658176;
			if (num != 0)
			{
			}
			num = (short)471072768;
			short num3 = num;
			num = (short)1003683841;
			if (num != 0)
			{
			}
			this.ToggleRibbonMinimized();
			e.Handled = true;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00085620 File Offset: 0x00083820
		private void ToggleRibbonMinimizeCanExecute(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			short num = (short)921235487;
			short num2 = num;
			num = (short)448327711;
			switch (num2 == num)
			{
			}
			num = (short)883228672;
			if (num != 0)
			{
			}
			num = (short)1878261760;
			short num3 = num;
			num = (short)2145976321;
			if (num != 0)
			{
			}
			e.CanExecute = this.AutoExpand;
			e.Handled = true;
			e.ContinueRouting = false;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000856E4 File Offset: 0x000838E4
		internal void OnQatDialogCustomize()
		{
			short num = (short)573740141;
			short num2 = num;
			num = (short)1304204397;
			switch (num2 == num)
			{
			}
			num = (short)1658454017;
			if (num != 0)
			{
			}
			num = (short)927727616;
			short num3 = num;
			num = (short)1177288704;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.QatDialogEventArgs e = new global::DevComponents.WpfRibbon.QatDialogEventArgs(global::DevComponents.WpfRibbon.Ribbon.BeforeCustomizeQatDialogEvent, this);
			this.OnBeforeCustomizeQatDialog(e);
			e = new global::DevComponents.WpfRibbon.QatDialogEventArgs(global::DevComponents.WpfRibbon.Ribbon.AfterCustomizeQatDialogEvent, this);
			this.OnAfterCustomizeQatDialog(e);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000857B4 File Offset: 0x000839B4
		protected virtual void OnAfterCustomizeQatDialog(global::DevComponents.WpfRibbon.QatDialogEventArgs e)
		{
			short num = (short)1186284047;
			short num2 = num;
			num = (short)17711631;
			switch (num2 == num)
			{
			}
			num = (short)806813697;
			if (num != 0)
			{
			}
			num = (short)1866727424;
			short num3 = num;
			num = (short)311296000;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00085868 File Offset: 0x00083A68
		private void OnBeforeCustomizeQatDialog(global::DevComponents.WpfRibbon.QatDialogEventArgs e)
		{
			short num = (short)190560473;
			short num2 = num;
			num = (short)1755756761;
			switch (num2 == num)
			{
			}
			num = (short)41025537;
			if (num != 0)
			{
			}
			num = (short)863961088;
			short num3 = num;
			num = (short)57671680;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0008591C File Offset: 0x00083B1C
		internal void ChangeQatPlacement()
		{
			short num = (short)1572966515;
			short num2 = num;
			num = (short)581734515;
			switch (num2 == num)
			{
			}
			num = (short)539164673;
			if (num != 0)
			{
			}
			num = (short)1634467840;
			short num3 = num;
			num = (short)1757544448;
			if (num != 0)
			{
			}
			this.IsQuickAccessToolbarBelow = !this.IsQuickAccessToolbarBelow;
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x000859D4 File Offset: 0x00083BD4
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00085A84 File Offset: 0x00083C84
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public string QuickAccessToolbarLayout
		{
			get
			{
				short num = (short)749457793;
				short num2 = num;
				num = (short)844943745;
				switch (num2 == num)
				{
				}
				num = (short)1022492673;
				if (num != 0)
				{
				}
				num = (short)1635975168;
				short num3 = num;
				num = (short)1169555456;
				if (num != 0)
				{
				}
				return this.GetQatLayoutDescription();
			}
			set
			{
				short num = (short)1755297219;
				short num2 = num;
				num = (short)635549123;
				switch (num2 == num)
				{
				}
				num = (short)1599930369;
				if (num != 0)
				{
				}
				num = (short)1159987200;
				short num3 = num;
				num = (short)1726611456;
				if (num != 0)
				{
				}
				this.SetQatLayoutDescription(value);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00085B38 File Offset: 0x00083D38
		private string GetQatLayoutDescription()
		{
			int a_ = 6;
			short num = (short)846397440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1246363648;
				short num3 = num;
				global::System.Windows.Controls.ItemsControl itemsControl = this.QuickAccessToolbar as global::System.Windows.Controls.ItemsControl;
				if (itemsControl == null)
				{
					throw new global::System.InvalidOperationException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ౝय़a٣॥٧䑩㵫᭭᥯ᅱέ㝵᭷᥹᥻ൽ횁ﲍ낏秊ﾙ\ud99f芡즣펥\udba7\udea9貫청햯銱잳펵첷骹좻톽ꏁ꫃臇뻉꧋ꏍꏏ金믓룕곗꣙돛닝샟釡诣웥蓧诩闫臭藯蛱퓳闵駷铹\udcfb鳽旿∁眃朅縇漉栋‍", a_));
				}
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				if (this.IsQuickAccessToolbarBelow)
				{
					stringBuilder.Append(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("潝", a_));
					goto IL_3BD;
				}
				IL_392:
				stringBuilder.Append(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("湝", a_));
				IL_3BD:
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)itemsControl.Items).GetEnumerator();
				goto IL_8F;
				try
				{
					object obj;
					for (;;)
					{
						IL_8F:
						num = (short)1054867456;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_E1;
								}
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1934557191;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								obj = enumerator.Current;
								global::System.Windows.FrameworkElement frameworkElement = obj as global::System.Windows.FrameworkElement;
								num = (short)1247477762;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								if (frameworkElement.Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝ᥟᅡ㕣ݥᱧ⡩ᥫᩭѯᵱᩳ⥵", a_))
								{
									num = (short)83427331;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1608646664;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_241;
							case 4:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								if (frameworkElement.Name != null)
								{
									num = (short)1197735946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_284;
							}
							case 5:
								num = (short)649396225;
								if (num != 0)
								{
								}
								num = (short)10878980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								num = (short)501153801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								if (frameworkElement.Name != "")
								{
									num = (short)1759903749;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_284;
							}
							case 9:
								goto IL_317;
							case 10:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								stringBuilder.Append(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("牝", a_) + frameworkElement.Name);
								num = (short)17563654;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_165:
							num = (short)764018689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_E1:
							goto IL_165;
						}
						IL_284:
						num = (short)519415369;
						short num4 = num;
						num = (short)1111991881;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_2B8;
						}
					}
					IL_241:
					throw new global::System.InvalidOperationException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ౝय़a٣॥٧⡩൫ᱭ偯ᅱ᭳ᡵ౷ࡹ፻ችꁿꢇ뒓몙춛즟송쾣蚥즩쾫쮭쎯솱钳ힷ햹킻\udcbdꆿ냁꓅뷇뻉ꟍ꓏냓뿕볗龎닛뇝铟싡賣蟥黧迩쳫鯭黯鯱藳菵鷷\udaf9鋻鿽淿朁␃甅洇縉∋", a_));
					IL_2B8:
					num = (short)1637154816;
					if (num != 0)
					{
					}
					throw new global::System.InvalidOperationException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵝşౡ੣॥ᱧ䩩Ὣ୭ɯ᭱ᕳ᩵ᅷy᥻幽ﶃﶇﺉ겋ﾏ뒓ﾙﮝ캟횡蒣즥캧誩\ud8ab힭삯ힱ钳", a_) + obj.GetType().ToString() + global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("繝ɟݡݣ॥ᵧᥩ५乭㹯፱ᥳ፵塷፹ཻ幽ꚅ黎ﾋﲑ", a_));
					IL_317:
					goto IL_3CD;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_339;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_326:
						switch (num2)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)167837698;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_391;
						case 1:
							goto IL_38F;
						case 2:
							disposable.Dispose();
							num = (short)1991901185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_339;
					}
					IL_38F:
					IL_391:
					goto EndFinally_10;
					IL_339:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1421148160;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_326;
					EndFinally_10:;
				}
				goto IL_392;
				IL_3CD:
				return stringBuilder.ToString();
			}
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00085F34 File Offset: 0x00084134
		private void SetQatLayoutDescription(string layoutDesc)
		{
			int a_ = 14;
			short num = (short)1401356288;
			switch (num)
			{
			default:
			{
				num = (short)1735655431;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Controls.ItemsControl itemsControl;
					bool flag;
					global::System.Collections.Generic.List<object> list;
					int num3;
					global::System.Collections.Generic.List<object>.Enumerator enumerator;
					object obj2;
					switch (num2)
					{
					case 0:
						goto IL_6AA;
					case 1:
					{
						global::System.Windows.FrameworkElement frameworkElement;
						if (frameworkElement != null)
						{
							num = (short)1797062684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AA;
					}
					case 2:
						goto IL_6AA;
					case 3:
					{
						global::System.Windows.FrameworkElement frameworkElement;
						if (global::DevComponents.WpfRibbon.Ribbon.GetIsCustomizable(frameworkElement))
						{
							num = (short)1845231652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AA;
					}
					case 4:
						if (itemsControl.Items[itemsControl.Items.Count - 1] is global::DevComponents.WpfRibbon.QatCustomizeButton)
						{
							num = (short)142671904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D3;
					case 5:
						goto IL_73F;
					case 6:
						num = (short)1289355268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_FD;
						}
						continue;
					case 8:
						goto IL_508;
					case 9:
					{
						string[] array;
						if (array.Length == 0)
						{
							num = (short)1753808918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = (array[0] == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("坥", a_));
						list = new global::System.Collections.Generic.List<object>();
						num3 = 1;
						num = (short)2133917719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						try
						{
							num = (short)1452867586;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1998651393;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object newItem = enumerator.Current;
									itemsControl.Items.Add(newItem);
									num = (short)293732355;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)729481220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3DB;
									}
									continue;
								case 4:
									goto IL_459;
								}
								IL_40B:
								num = (short)1000865792;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3DB:
								goto IL_40B;
							}
							IL_459:
							goto IL_8A7;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_46C;
						IL_8A7:
						num = (short)600244251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (layoutDesc == null)
						{
							num = (short)529137672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						itemsControl = (this.QuickAccessToolbar as global::System.Windows.Controls.ItemsControl);
						num = (short)471662625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1210384395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1927675942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						object obj;
						list.Add(obj);
						num = (short)1247150123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (list.Count != 0)
						{
							num = (short)935264273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					case 16:
						goto IL_841;
					case 17:
						num = (short)382795806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						string[] array;
						if (num3 >= array.Length)
						{
							num = (short)1479082024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = global::DevComponents.WpfRibbon.Utility.IndexOfName(itemsControl.Items, array[num3]);
						num = (short)1951072277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_279;
					case 20:
					{
						global::DevComponents.WpfRibbon.RibbonBar ribbonBar;
						if (ribbonBar != null)
						{
							num = (short)771489805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AA;
					}
					case 21:
					{
						int num4;
						if (num4 >= 0)
						{
							num = (short)1689387049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)682295320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						return;
					case 23:
					{
						num = (short)640173041;
						short num5 = num;
						num = (short)648365041;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_668;
						default:
							num = (short)332857344;
							if (num != 0)
							{
							}
							goto IL_841;
						}
						break;
					}
					case 24:
					{
						string[] array;
						if (array[num3].StartsWith(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㕥ᅧᥩ㵫཭ѯぱųɵ౷ᕹቻⅽ", a_)))
						{
							num = (short)590872613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.FrameworkElement frameworkElement = this.FindControlByName(array[num3]);
						num = (short)734265345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1082982414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AA;
					}
					case 26:
						goto IL_5D3;
					case 27:
						if (this.IsQuickAccessToolbarBelow != flag)
						{
							num = (short)138018847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 28:
						num = (short)1728315395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						global::DevComponents.WpfRibbon.RibbonBar ribbonBar;
						obj2 = this.CreateQatItemCopy(ribbonBar);
						num = (short)1802764322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						if (!(list[list.Count - 1] is global::DevComponents.WpfRibbon.QatCustomizeButton))
						{
							num = (short)1587478547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D3;
					case 31:
						goto IL_46C;
					case 32:
						num = (short)1204682767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						if (itemsControl == null)
						{
							num = (short)2034434053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = layoutDesc.Split(new char[]
						{
							','
						});
						num = (short)594214921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						goto IL_668;
					case 35:
						list.Add(obj2);
						num = (short)611254274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						global::System.Windows.FrameworkElement frameworkElement;
						object obj = this.CreateQatItemCopy(frameworkElement);
						num = (short)1136656409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
					{
						string[] array;
						global::DevComponents.WpfRibbon.RibbonBar ribbonBar = this.GetRibbonBar(array[num3].Substring(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㕥ᅧᥩ㵫཭ѯぱųɵ౷ᕹቻⅽ", a_).Length));
						num = (short)475267092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
					{
						global::DevComponents.WpfRibbon.RibbonBar ribbonBar;
						if (global::DevComponents.WpfRibbon.Ribbon.GetIsCustomizable(ribbonBar))
						{
							num = (short)1671102493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AA;
					}
					case 39:
						if (itemsControl.Items.Count > 0)
						{
							num = (short)1713242118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D3;
					case 40:
						num = (short)1019609127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						int num4;
						list.Add(itemsControl.Items[num4]);
						num = (short)1811021824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						goto IL_48C;
					case 43:
						goto IL_6AA;
					}
					IL_FD:
					if (!(layoutDesc == ""))
					{
						num = (short)1266024448;
						short num6 = num;
						num = (short)1893138444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_279:
					list.Add(itemsControl.Items[itemsControl.Items.Count - 1]);
					num = (short)572063770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46C:
					this.IsQuickAccessToolbarBelow = flag;
					num = (short)1834418218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D3:
					itemsControl.Items.Clear();
					enumerator = list.GetEnumerator();
					num = (short)1651572746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_668:
					if (obj2 != null)
					{
						num = (short)1611005987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6AA:
					num3++;
					num = (short)1903034384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_841:
					num = (short)894238738;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_48C:
				return;
				IL_508:
				num = (short)1338179585;
				if (num != 0)
				{
				}
				return;
				IL_73F:
				throw new global::System.InvalidOperationException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㑥ŧࡩ๫ŭṯ山╳͵ᅷ᥹᝻㽽ﮇ\ude89ﲏ뢗킟잡횣튥톧誩솫\udbad쎯욱钳풵\uddb7骹쾻\udbbd뒿냃꧅ꯉꋋ駏ꛑ뇓믕ꯗ駙돛냝铟郡诣諥죧駩菫컭鳯鏱跳駵跷軹\udcfb鷽懿氁␃搅洇⨉怋愍焏瘑焓爕㘗", a_));
			}
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00086838 File Offset: 0x00084A38
		private global::System.Windows.FrameworkElement FindControlByName(string name)
		{
			global::System.Windows.FrameworkElement frameworkElement;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return frameworkElement;
					case 1:
						if (frameworkElement != null)
						{
							num2 = (short)52822023;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						frameworkElement = global::DevComponents.WpfRibbon.Utility.FindByName(((global::DevComponents.WpfRibbon.ApplicationMenu)this.ApplicationMenu).AppItems, name);
						num2 = (short)715390980;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return frameworkElement;
					case 3:
						if (this.ApplicationMenu is global::DevComponents.WpfRibbon.ApplicationMenu)
						{
							num2 = (short)1647575045;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F9;
					case 4:
						if (frameworkElement != null)
						{
							num2 = (short)1727922178;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						frameworkElement = global::DevComponents.WpfRibbon.Utility.FindByName(((global::DevComponents.WpfRibbon.ApplicationMenu)this.ApplicationMenu).MruItems, name);
						num2 = (short)1510014982;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						frameworkElement = global::DevComponents.WpfRibbon.Utility.FindByName(((global::System.Windows.Controls.ItemsControl)this.ApplicationMenu).Items, name);
						num2 = (short)1704198145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
					{
						num2 = (short)1842085889;
						if (num2 != 0)
						{
						}
						num2 = (short)583016932;
						short num3 = num2;
						num2 = (short)191898084;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)209584128;
							short num4 = num2;
							num2 = (short)2228224;
							if (num2 != 0)
							{
							}
							if (frameworkElement != null)
							{
								num2 = (short)73269248;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_1F9;
						}
						}
						break;
					}
					case 7:
						return frameworkElement;
					}
					break;
				}
				IL_30:
				frameworkElement = null;
				num2 = (short)1227423747;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return frameworkElement;
			IL_1F9:
			frameworkElement = global::DevComponents.WpfRibbon.Utility.FindByName(base.Items, name);
			return frameworkElement;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00086A4C File Offset: 0x00084C4C
		private global::DevComponents.WpfRibbon.RibbonBar GetRibbonBar(string name)
		{
			short num = (short)1996619776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)699334656;
				short num3 = num;
				num = (short)804061185;
				if (num != 0)
				{
				}
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
				global::DevComponents.WpfRibbon.RibbonBar result;
				try
				{
					num = (short)43057153;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Windows.Controls.Panel panel;
							if (panel != null)
							{
								num = (short)1668349958;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_C6;
							}
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)263061507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::DevComponents.WpfRibbon.RibbonTab ribbonTab = enumerator.Current as global::DevComponents.WpfRibbon.RibbonTab;
							num = (short)1950875652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)847708168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
							if (ribbonTab != null)
							{
								num = (short)1284898823;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							try
							{
								num = (short)1667563521;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Windows.UIElement uielement;
										if (((global::DevComponents.WpfRibbon.RibbonBar)uielement).Name == name)
										{
											num = (short)892076038;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_15A;
										}
										continue;
									case 2:
										goto IL_1B6;
									case 3:
									{
										global::System.Windows.UIElement uielement;
										if (uielement is global::DevComponents.WpfRibbon.RibbonBar)
										{
											num = (short)188612613;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
										goto IL_171;
									case 5:
										num = (short)978976768;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										global::System.Windows.UIElement uielement;
										result = (global::DevComponents.WpfRibbon.RibbonBar)uielement;
										num = (short)1751777282;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										num = (short)1862467592;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
									{
										num = (short)1305557221;
										short num4 = num;
										num = (short)856701157;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_171;
										default:
											goto IL_2A3;
										}
										break;
									}
									}
									IL_15C:
									num = (short)2107899908;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_15A:
									goto IL_15C;
									IL_171:
									global::System.Collections.IEnumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1183383559;
										num2 = (int)((global::System.IntPtr)num);
									}
									else
									{
										global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator2.Current;
										num = (short)264699907;
										num2 = (int)((global::System.IntPtr)num);
									}
								}
								IL_1B6:
								return result;
								IL_2A3:
								num = (short)2007760896;
								if (num != 0)
								{
								}
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_2D8;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_2C5:
									switch (num2)
									{
									case 0:
										disposable.Dispose();
										num = (short)790757378;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										if (disposable != null)
										{
											num = (short)484966400;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_331;
									case 2:
										goto IL_32F;
									}
									goto IL_2D8;
								}
								IL_32F:
								IL_331:
								break;
								IL_2D8:
								global::System.Collections.IEnumerator enumerator2;
								disposable = (enumerator2 as global::System.IDisposable);
								num = (short)1694171137;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_2C5;
							}
							break;
						case 6:
						{
							global::System.Windows.Controls.Panel panel;
							global::System.Collections.IEnumerator enumerator2 = panel.Children.GetEnumerator();
							num = (short)498794501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
							global::System.Windows.Controls.Panel panel = ribbonTab.Content as global::System.Windows.Controls.Panel;
							num = (short)1388904448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_3F9;
						}
						IL_332:
						num = (short)1133903874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C6:
						goto IL_332;
					}
					IL_3F9:
					goto IL_7A;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_41B;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_408:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)1483407362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (disposable != null)
							{
								num = (short)1660747776;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_472;
						case 2:
							goto IL_470;
						}
						goto IL_41B;
					}
					IL_470:
					IL_472:
					goto EndFinally_14;
					IL_41B:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)415170561;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_408;
					EndFinally_14:;
				}
				return result;
				IL_7A:
				return null;
			}
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00086F04 File Offset: 0x00085104
		public object CreateQatItemCopy(object element)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			global::DevComponents.WpfRibbon.QatOperationAddEventArgs qatOperationAddEventArgs;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_1FA;
				case 1:
					goto IL_171;
				case 2:
					if (qatOperationAddEventArgs.OriginalSource is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num2 = (short)10485768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)421199875;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (qatOperationAddEventArgs.OriginalSource is global::DevComponents.WpfRibbon.RibbonBar)
					{
						num2 = (short)642449414;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1FA;
				case 4:
				{
					num2 = (short)1819833547;
					short num3 = num2;
					num2 = (short)1882682571;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AC;
					default:
					{
						num2 = (short)312934400;
						if (num2 != 0)
						{
						}
						object itemCopy;
						if (itemCopy == qatOperationAddEventArgs.Item)
						{
							num2 = (short)1203634177;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return itemCopy;
					}
					}
					break;
				}
				case 5:
					goto IL_25F;
				case 6:
				{
					qatOperationAddEventArgs.ItemCopy = this.GetRibbonBarQatCopy((global::DevComponents.WpfRibbon.RibbonBar)qatOperationAddEventArgs.OriginalSource);
					num2 = (short)471465984;
					short num4 = num2;
					num2 = (short)545456135;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_1FA;
				case 8:
					qatOperationAddEventArgs.ItemCopy = this.GetButtonDropDownQatCopy((global::DevComponents.WpfRibbon.ButtonDropDown)qatOperationAddEventArgs.OriginalSource);
					num2 = (short)992477184;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					object itemCopy;
					if (itemCopy == null)
					{
						num2 = (short)1112604682;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)184352772;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					goto IL_1E1;
				case 11:
				{
					if (qatOperationAddEventArgs.Cancel)
					{
						num2 = (short)1179582465;
						if (num2 != 0)
						{
						}
						num2 = (short)1669595141;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					object itemCopy = qatOperationAddEventArgs.ItemCopy;
					goto IL_1AC;
				}
				}
				goto IL_49;
				IL_1AC:
				num2 = (short)269942793;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1FA:
				this.OnBeforeAddToQat(qatOperationAddEventArgs);
				num2 = (short)1116864523;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_171:
			throw new global::System.InvalidOperationException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㡨੪ᥬ⁮Űᙲݴᙶ൸ቺቼᅾ삀슆ﾈﮎ킐래튚爵철쪤힦킨讪캬캮\udfb0\uddb2\udab4쎶馸\ud9ba\ud8bc龾닀ꋂ꣄ꋆ꫊뻌胐닒ꇔ飖꧘뻚꿜뻞闠諢諤触꣨迪觬ꫮ蟰雲鯴菶룸觺髼賾⼀䨂焄戆搈┊ⴌ䘎攐㌒研或樘漚㴜紞䐠̢嘤䈦崨ପ夬䀮ᄰ䜲崴制ᤸ堺刼伾㡀捂⩄ⅆ楈㽊╌⩎煐ɒ㑔⍖ᙘ⭚㡜ⵞ`ᝢ౤ࡦݨ⩪६୮㑰ղၴ᥶൸㩺ོ᡾궂첄권ﲎﺐ뎒ﾖﲘ뮚ﺜ토\udaa2薤쒦좨얪趬춮풰鎲풴펶\uddb8\udeba\ud9bc龾뗀곂集裈鿊", a_));
			IL_1E1:
			throw new global::System.InvalidOperationException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㡨੪ᥬ⁮Űᙲݴᙶ൸ቺቼᅾ삀슆ﾈﮎ킐래튚爵철쪤힦킨讪사\udaae슰잲閴햶\udcb8鮺캼\udabe뗀뇄꣆뿊ꗌ꫎냒뫔Ꟗꃘﯚ닜맞쇠韢跤苦짨뫪賬鯮뻰菲郴藶飸迺铼郾漀䈂愄挆䰈紊栌愎攐划朔瀖樘㔚吜欞䐠丢Ԥ否䘨ପ夬䜮吰ጲ嘴堶䤸䈺ᴼ尾⁀ⵂ敄╆ⱈ歊ⱌ⭎㕐㙒ㅔ睖ⵘ㑚絜๞⁠㝢", a_));
			IL_25F:
			return null;
			IL_49:
			qatOperationAddEventArgs = new global::DevComponents.WpfRibbon.QatOperationAddEventArgs(element, global::DevComponents.WpfRibbon.Ribbon.BeforeAddToQatEvent, element);
			num2 = (short)64290818;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000871D4 File Offset: 0x000853D4
		public void AddToQat(object element)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			global::System.Windows.Controls.ItemsControl itemsControl;
			short num2;
			object obj;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_1F2;
				case 1:
					return;
				case 2:
					goto IL_6A;
				case 3:
					if (itemsControl.Items[itemsControl.Items.Count - 1] is global::DevComponents.WpfRibbon.QatCustomizeButton)
					{
						num2 = (short)1618149382;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24D;
				case 4:
				{
					num2 = (short)236859960;
					short num3 = num2;
					num2 = (short)369439288;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
						num2 = (short)1697185792;
						if (num2 != 0)
						{
						}
						if (this.IsElementOnQat(element as global::System.Windows.FrameworkElement))
						{
							num2 = (short)317063169;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						obj = this.CreateQatItemCopy(element);
						num2 = (short)1850343429;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (obj == null)
					{
						num2 = (short)1440284679;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)331415561;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					itemsControl.Items.Insert(itemsControl.Items.Count - 1, obj);
					num2 = (short)834600960;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return;
				case 8:
					goto IL_84;
				case 9:
					if (itemsControl.Items.Count > 0)
					{
						num2 = (short)225443850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24D;
				case 10:
					num2 = (short)818151427;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_272;
				}
				goto IL_49;
				IL_6A:
				if (itemsControl == null)
				{
					num2 = (short)1231683592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				num2 = (short)678559748;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_24D:
				itemsControl.Items.Add(obj);
				num2 = (short)819396619;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_84:
			num2 = (short)340197377;
			if (num2 != 0)
			{
			}
			num2 = (short)2029191168;
			short num4 = num2;
			throw new global::System.InvalidOperationException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㡩ի౭ቯᵱᩳ塵⥷ཹᕻᵽ쎁黎ﾋ\uda8dﾏ﶑聯벛튟춡풣쎥\udaa7\udea9햫躭\uddaf잱잳습颷\ud8b9\ud9bb麽뎿ꟁ냃볇ꗉ꿍뻏鷓ꋕ뷗럙꿛鷝迟賡郣铥蟧蛩쳫鷭鿯틱鷳苵鷷韹迻\udefd揿持樃★樇漉Ⰻ漍琏瘑焓爕㘗", a_));
			IL_1F2:
			IL_272:
			this.OnAfterAddToQat(new global::DevComponents.WpfRibbon.QatOperationAddEventArgs(element, global::DevComponents.WpfRibbon.Ribbon.AfterAddToQatEvent, element)
			{
				ItemCopy = obj
			});
			return;
			IL_49:
			itemsControl = (this.QuickAccessToolbar as global::System.Windows.Controls.ItemsControl);
			num2 = (short)1081147394;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000874B4 File Offset: 0x000856B4
		private global::DevComponents.WpfRibbon.ButtonDropDown GetRibbonBarQatCopy(global::DevComponents.WpfRibbon.RibbonBar ribbonBar)
		{
			int a_ = 15;
			short num = (short)1256456192;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
						goto IL_13F;
					case 1:
						buttonDropDown.Image = global::DevComponents.WpfRibbon.CloningMachine.GetObjectCopy(ribbonBar.CollapsedImage, false);
						buttonDropDown.UseSmallImage = true;
						buttonDropDown.PartVisibility = global::DevComponents.WpfRibbon.eButtonPartVisibility.ImageOnly;
						num = (short)465174528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						IL_E2:
						if (ribbonBar.CollapsedImage != null)
						{
							num = (short)1612513281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					}
					goto IL_45;
					IL_13F:
					num = (short)629211136;
					short num3 = num;
					num = (short)202617002;
					short num4 = num;
					num = (short)1219473578;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E2;
					default:
						goto IL_19D;
					}
				}
				IL_19D:
				num = (short)1028587521;
				if (num != 0)
				{
				}
				num = (short)822083584;
				if (num != 0)
				{
				}
				return buttonDropDown;
				IL_45:
				global::System.Windows.Controls.ContextMenu contextMenu = ribbonBar.ContextMenu;
				ribbonBar.ContextMenu = null;
				global::DevComponents.WpfRibbon.RibbonBar ribbonBar2 = ribbonBar.Copy(true);
				ribbonBar.ContextMenu = contextMenu;
				ribbonBar2.Height = ribbonBar.RenderSize.Height;
				buttonDropDown = new global::DevComponents.WpfRibbon.ButtonDropDown();
				buttonDropDown.Name = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㑦ၨᡪ㱬๮հㅲtͶ൸ᑺ፼⁾", a_) + ribbonBar2.Name;
				buttonDropDown.ExpandVisibility = global::DevComponents.WpfRibbon.eExpandVisibility.Hidden;
				buttonDropDown.Items.Add(ribbonBar2);
				buttonDropDown.PopupType = global::DevComponents.WpfRibbon.eDropDownType.Popup;
				buttonDropDown.Role = global::DevComponents.WpfRibbon.eButtonRole.DropDown;
				buttonDropDown.Header = ribbonBar.Header;
				num = (short)1839464450;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000876A0 File Offset: 0x000858A0
		private global::DevComponents.WpfRibbon.ButtonDropDown GetButtonDropDownQatCopy(global::DevComponents.WpfRibbon.ButtonDropDown b)
		{
			short num = (short)2012872704;
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
				global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
				for (;;)
				{
					IL_28:
					bool flag;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						num = (short)1709113355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Windows.Size renderSize;
						if (renderSize.Height > 16.0)
						{
							num = (short)1218314254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					}
					case 2:
						num = (short)1964900386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Windows.Size renderSize = ((global::System.Windows.Controls.Image)b.Image).RenderSize;
						num = (short)1268842497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (b.Command != null)
						{
							num = (short)807403551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55C;
					case 5:
						buttonDropDown.ExpandPosition = global::DevComponents.WpfRibbon.eExpandPosition.Right;
						num = (short)1067122715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)2102919190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!flag)
						{
							num = (short)419495953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55C;
					case 8:
					{
						global::System.Windows.Size renderSize = ((global::System.Windows.Controls.Image)b.Image).RenderSize;
						num = (short)1024524300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_318;
					case 10:
						num = (short)138280988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						flag2 = (((global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender)b.Command).ImageSmallSource != null);
						goto IL_3F1;
					case 12:
					{
						global::System.Windows.Size renderSize;
						if (renderSize.Width <= 16.0)
						{
							num = (short)1390673923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BD;
					}
					case 13:
						flag2 = true;
						goto IL_3F1;
					case 14:
						goto IL_1BD;
					case 15:
					{
						global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender exender;
						if (exender != null)
						{
							goto IL_4E3;
						}
						goto IL_55C;
					}
					case 16:
						if (b.Image is global::System.Windows.Controls.Image)
						{
							num = (short)887554056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					case 17:
						num = (short)1222246404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (buttonDropDown.IsExpandVisible == global::System.Windows.Visibility.Visible)
						{
							num = (short)552206346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_642;
					case 19:
						if (flag)
						{
							num = (short)463208480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					case 20:
					{
						if (b.Command is global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender)
						{
							num = (short)1765736450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender exender = global::DevComponents.WpfRibbon.RibbonCommandManager.GetExender(b.Command);
						num = (short)1284964367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_55C;
					case 22:
					{
						global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender exender;
						flag3 = (exender.ImageSmallSource != null);
						goto IL_622;
					}
					case 23:
						buttonDropDown.Role = global::DevComponents.WpfRibbon.eButtonRole.SplitButton;
						num = (short)1083572257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender exender;
						if (exender.ImageSource == null)
						{
							num = (short)1798045702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1056702489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						flag3 = true;
						goto IL_622;
					case 26:
						goto IL_55C;
					case 27:
						goto IL_3C2;
					case 28:
						if (buttonDropDown.ExpandPosition != global::DevComponents.WpfRibbon.eExpandPosition.Right)
						{
							num = (short)407240709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_642;
					case 29:
						if (buttonDropDown.Role == global::DevComponents.WpfRibbon.eButtonRole.MenuItem)
						{
							num = (short)1307312151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DB;
					case 30:
						num = (short)1868693528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)1246298132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						buttonDropDown.PartVisibility = global::DevComponents.WpfRibbon.eButtonPartVisibility.ImageOnly;
						num = (short)1232142352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)2080374785;
						if (num != 0)
						{
						}
						goto IL_5DB;
					case 34:
						if (((global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender)b.Command).ImageSource == null)
						{
							num = (short)1474822144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)804847629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BB;
					IL_1BD:
					buttonDropDown.UseSmallImage = true;
					num = (short)2105999369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_318:
					num = (short)346482786;
					short num3 = num;
					num = (short)558164066;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_4E3:
						num = (short)1848246302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)1419444224;
						if (num != 0)
						{
						}
						num = (short)1712783378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3F1:
					flag = flag2;
					num = (short)372768789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_55C:
					num = (short)1448738835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5DB:
					flag = (b.Image != null);
					num = (short)194772999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_622:
					flag = flag3;
					num = (short)1117126682;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3C2:
				num = (short)218628096;
				short num4 = num;
				IL_642:
				buttonDropDown.ImagePosition = global::DevComponents.WpfRibbon.eButtonImagePosition.Left;
				return buttonDropDown;
				IL_BB:
				buttonDropDown = b.Copy(true);
				num = (short)1094713373;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00087CF8 File Offset: 0x00085EF8
		internal bool CanAddToQat(object element)
		{
			short num = (short)1378156544;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)293339136;
				short num3 = num;
				global::System.Windows.Controls.ItemsControl itemsControl;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 1:
				{
					num = (short)1936184010;
					short num4 = num;
					num = (short)1178522314;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15E;
					default:
						num = (short)1546321920;
						if (num != 0)
						{
						}
						itemsControl = (this.QuickAccessToolbar as global::System.Windows.Controls.ItemsControl);
						num = (short)345571330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_15E;
				case 3:
					return false;
				case 4:
					goto IL_111;
				case 5:
					if (itemsControl.Items.Contains(element))
					{
						num = (short)1606418436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17D;
				}
				IL_66:
				if (element is global::System.Windows.FrameworkElement)
				{
					num = (short)644481025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_15E:
				if (itemsControl == null)
				{
					num = (short)795475971;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)795803653;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_111:
			num = (short)1637941249;
			if (num != 0)
			{
			}
			return false;
			IL_17D:
			return global::DevComponents.WpfRibbon.Ribbon.GetIsCustomizable(element as global::System.Windows.FrameworkElement);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00087E94 File Offset: 0x00086094
		protected virtual void OnAfterAddToQat(global::DevComponents.WpfRibbon.QatOperationAddEventArgs qe)
		{
			short num = (short)573833216;
			short num2 = num;
			num = (short)488865515;
			short num3 = num;
			num = (short)92438251;
			switch (num3 == num)
			{
			}
			num = (short)1815674881;
			if (num != 0)
			{
			}
			num = (short)87621632;
			if (num != 0)
			{
			}
			base.RaiseEvent(qe);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00087F44 File Offset: 0x00086144
		protected virtual void OnBeforeAddToQat(global::DevComponents.WpfRibbon.QatOperationAddEventArgs qe)
		{
			short num = (short)294387712;
			short num2 = num;
			num = (short)1410011619;
			short num3 = num;
			num = (short)769987043;
			switch (num3 == num)
			{
			}
			num = (short)2020016129;
			if (num != 0)
			{
			}
			num = (short)1252261888;
			if (num != 0)
			{
			}
			base.RaiseEvent(qe);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00087FF8 File Offset: 0x000861F8
		public void RemoveFromQat(object element)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			global::DevComponents.WpfRibbon.QatOperationEventArgs qatOperationEventArgs;
			short num2;
			global::System.Windows.Controls.ItemsControl itemsControl;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_4A;
				case 1:
					goto IL_DF;
				case 2:
				{
					if (qatOperationEventArgs.Cancel)
					{
						num2 = (short)1392574465;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1835283347;
					short num3 = num2;
					num2 = (short)422065043;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4A;
					default:
						goto IL_151;
					}
					break;
				}
				case 3:
					goto IL_8B;
				}
				goto IL_29;
				IL_4A:
				if (itemsControl == null)
				{
					num2 = (short)503119872;
					short num4 = num2;
					num2 = (short)524746755;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					qatOperationEventArgs = new global::DevComponents.WpfRibbon.QatOperationEventArgs(element, global::DevComponents.WpfRibbon.Ribbon.BeforeRemoveFromQatEvent, element);
					qatOperationEventArgs.Source = this;
					this.OnBeforeRemoveFromQat(qatOperationEventArgs);
					num2 = (short)347996162;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_8B:
			throw new global::System.InvalidOperationException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㍠੢ݤզ٨ժ䍬㹮Ѱᩲᙴᱶ㡸᡺Ṽ᩾톄뎒햠\udaa2薤쪦\udca8\ud8aa\ud9ac辮펰횲閴쒶\udcb8쾺鶼쮾껀꓄꧆苊만꫎볐ꃒ雔룖럘꿚꿜냞跠쏢雤裦짨苪駬諮鳰胲헴银飸闺\uddfc鷾搀⌂眄戆搈搊笌樎甐㴒", a_));
			IL_DF:
			num2 = (short)1976631297;
			if (num2 != 0)
			{
			}
			return;
			IL_151:
			num2 = (short)1535115264;
			if (num2 != 0)
			{
			}
			itemsControl.Items.Remove(element);
			qatOperationEventArgs = new global::DevComponents.WpfRibbon.QatOperationEventArgs(element, global::DevComponents.WpfRibbon.Ribbon.AfterRemoveFromQatEvent, element);
			this.OnAfterRemoveFromQat(qatOperationEventArgs);
			return;
			IL_29:
			itemsControl = (this.QuickAccessToolbar as global::System.Windows.Controls.ItemsControl);
			num2 = (short)2108555264;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0008818C File Offset: 0x0008638C
		protected virtual void OnAfterRemoveFromQat(global::DevComponents.WpfRibbon.QatOperationEventArgs oe)
		{
			short num = (short)1495990272;
			short num2 = num;
			num = (short)1815736533;
			short num3 = num;
			num = (short)1741091029;
			switch (num3 == num)
			{
			}
			num = (short)1311571969;
			if (num != 0)
			{
			}
			num = (short)111083520;
			if (num != 0)
			{
			}
			base.RaiseEvent(oe);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0008823C File Offset: 0x0008643C
		protected virtual void OnBeforeRemoveFromQat(global::DevComponents.WpfRibbon.QatOperationEventArgs oe)
		{
			short num = (short)374538240;
			short num2 = num;
			num = (short)1521399215;
			short num3 = num;
			num = (short)1487189423;
			switch (num3 == num)
			{
			}
			num = (short)603652097;
			if (num != 0)
			{
			}
			num = (short)65273856;
			if (num != 0)
			{
			}
			base.RaiseEvent(oe);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x000882EC File Offset: 0x000864EC
		private bool CanRemoveFromQat(object element)
		{
			short num = (short)1287454720;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 1:
					num = (short)52625410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.QuickAccessToolbar != null)
					{
						num = (short)2115633152;
						short num3 = num;
						num = (short)1944059907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					num = (short)1910112261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_121;
				case 5:
				{
					num = (short)1488853059;
					short num4 = num;
					num = (short)353966147;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B;
					default:
						num = (short)758841344;
						if (num != 0)
						{
						}
						num = (short)352911361;
						if (num != 0)
						{
						}
						if (this.QuickAccessToolbar is global::System.Windows.Controls.ItemsControl)
						{
							num = (short)1529085956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				}
				IL_3C:
				if (element == null)
				{
					return false;
				}
				num = (short)1691877377;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5B:
			return ((global::System.Windows.Controls.ItemsControl)this.QuickAccessToolbar).Items.Contains(element);
			IL_121:
			goto IL_5B;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00088488 File Offset: 0x00086688
		private static void OnAccessKeyPressed(object sender, global::System.Windows.Input.AccessKeyPressedEventArgs e)
		{
			short num = (short)1421082624;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
					if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightAlt))
					{
						goto IL_13B;
					}
					return;
				case 2:
				{
					e.Scope = sender;
					e.Handled = true;
					num = (short)554115309;
					short num3 = num;
					num = (short)593109229;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13B;
					default:
						num = (short)1569325056;
						if (num != 0)
						{
						}
						num = (short)1867841539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					return;
				case 4:
					num = (short)1392443393;
					if (num != 0)
					{
					}
					num = (short)582221825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_38:
				if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftAlt))
				{
					num = (short)1874526208;
					short num4 = num;
					num = (short)1152385028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13B:
				num = (short)320536578;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000885F0 File Offset: 0x000867F0
		private void SetupEnterMenuMode()
		{
			int a_ = 14;
			short num = (short)545587200;
			switch (num)
			{
			default:
			{
				num = (short)332005376;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Input.KeyboardNavigation keyboardNavigation;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 1:
					{
						num = (short)789318490;
						short num3 = num;
						num = (short)564923226;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_120;
						case 1:
							break;
						default:
						{
							num = (short)698417152;
							short num4 = num;
							break;
						}
						}
						num = (short)6750208;
						if (num != 0)
						{
						}
						if (keyboardNavigation != null)
						{
							num = (short)1345847298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
						goto IL_FD;
					case 3:
						goto IL_120;
					case 4:
						goto IL_82;
					}
					IL_62:
					if (this.m_EnterMenuModeDelegate != null)
					{
						num = (short)521994244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Type typeFromHandle = typeof(global::System.Windows.Input.KeyboardNavigation);
					keyboardNavigation = (typeFromHandle.GetProperty(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("╥ᵧᡩṫ୭ṯٱ", a_), global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.NonPublic).GetValue(null, null) as global::System.Windows.Input.KeyboardNavigation);
					num = (short)299499521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FD:
					new global::System.Security.Permissions.UIPermission(global::System.Security.Permissions.UIPermissionWindow.AllWindows).Assert();
					num = (short)1264648195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_120:
					try
					{
						global::System.Reflection.EventInfo @event = typeFromHandle.GetEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍥٧ṩ५ᱭ㵯᝱ᩳ͵㕷ᕹ᡻᭽", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
						global::System.Type eventHandlerType = @event.EventHandlerType;
						global::System.Reflection.MethodInfo method = typeof(global::DevComponents.WpfRibbon.Ribbon).GetMethod(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ṥ൧թū", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
						global::System.Delegate @delegate = global::System.Delegate.CreateDelegate(eventHandlerType, this, method);
						object[] parameters = new object[]
						{
							@delegate
						};
						this.m_EnterMenuModeDelegate = @delegate;
						@event.GetAddMethod(true).Invoke(keyboardNavigation, parameters);
						return;
					}
					finally
					{
						global::System.Security.CodeAccessPermission.RevertAssert();
					}
					goto IL_FD;
				}
				IL_82:
				num = (short)77529089;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00088834 File Offset: 0x00086A34
		internal bool EnterKeyTipsMode()
		{
			short num = (short)714544139;
			short num2 = num;
			num = (short)838341643;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			case 1:
				break;
			default:
			{
				num = (short)1463877632;
				short num3 = num;
				break;
			}
			}
			num = (short)153092096;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonTab ribbonTab = base.SelectedItem as global::DevComponents.WpfRibbon.RibbonTab;
			if (ribbonTab != null)
			{
				num = (short)1865023489;
				if (num != 0)
				{
				}
				ribbonTab.Focus();
				this.ShowKeyTips = true;
				return true;
			}
			return false;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00088900 File Offset: 0x00086B00
		private bool xeom(object sender, global::System.EventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_68;
			}
			int num;
			short num2;
			global::System.Windows.Window window;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.ShowKeyTips)
					{
						num2 = (short)1800011794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1099104266;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.EnterKeyTipsMode())
					{
						num2 = (short)1109917715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					goto IL_22C;
				case 3:
					if (window.IsActive)
					{
						num2 = (short)728629256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					if (global::System.Windows.Input.Mouse.Captured == null)
					{
						num2 = (short)71041035;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_314;
				case 5:
					goto IL_231;
				case 6:
					if (!base.IsEnabled)
					{
						num2 = (short)1247019029;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)906821636;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu = this.ApplicationMenu as global::DevComponents.WpfRibbon.ApplicationMenu;
					num2 = (short)584450063;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					goto IL_134;
				case 9:
					goto IL_24F;
				case 10:
					if (this.ApplicationMenu != null)
					{
						num2 = (short)1689518094;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 11:
					num2 = (short)525074449;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)252116993;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (window != null)
					{
						num2 = (short)1742798864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_134;
				case 14:
					num2 = (short)1916141588;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
				{
					global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
					if (applicationMenu.IsPopupOpen)
					{
						num2 = (short)176685061;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 16:
					num2 = (short)497418243;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (!this.ShowKeyTips)
					{
						num2 = (short)824639500;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_314;
				case 18:
					this.RestorePreviousFocus();
					num2 = (short)1033175042;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					return true;
				case 20:
					if (this.ApplicationMenu is global::DevComponents.WpfRibbon.ApplicationMenu)
					{
						num2 = (short)898433031;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 21:
					goto IL_20A;
				}
				goto IL_68;
				IL_134:
				num2 = (short)1452322071;
				short num3 = num2;
				num2 = (short)26651927;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_231:
					global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
					applicationMenu.IsPopupOpen = false;
					num2 = (short)132841481;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					break;
				default:
				{
					num2 = (short)1358888960;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)1801650177;
				if (num2 != 0)
				{
				}
				num2 = (short)1864433664;
				if (num2 != 0)
				{
				}
				num2 = (short)471400454;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_314:
				num2 = (short)243204096;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_20A:
			return false;
			IL_22C:
			IL_24F:
			return false;
			IL_68:
			window = global::System.Windows.Window.GetWindow(this);
			num2 = (short)687538189;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00088CE4 File Offset: 0x00086EE4
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)670433280;
			short num2 = num;
			num = (short)1862364189;
			short num3 = num;
			num = (short)921005085;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_52A:
				e.Handled = global::DevComponents.WpfRibbon.FocusHelpers.FocusFirstChild(this.QuickAccessToolbar as global::System.Windows.Controls.ItemsControl);
				this.ShowKeyTips = false;
				num = (short)277938217;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)655294465;
				if (num != 0)
				{
				}
				num = (short)1079705600;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_156;
				}
				break;
			}
			for (;;)
			{
				IL_A8:
				switch (num4)
				{
				case 0:
					goto IL_3C1;
				case 1:
					goto IL_52A;
				case 2:
					goto IL_423;
				case 3:
					if (e.Key == global::System.Windows.Input.Key.Back)
					{
						num = (short)513277959;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B5;
				case 4:
					if (e.Key == global::System.Windows.Input.Key.Escape)
					{
						num = (short)1839005721;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (e.Key != global::System.Windows.Input.Key.Up)
					{
						num = (short)765526028;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_673;
				case 6:
					return;
				case 7:
					goto IL_673;
				case 8:
					goto IL_5B5;
				case 9:
					num = (short)405143572;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (this.IsMinimized)
					{
						num = (short)1621032978;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					num = (short)1706491940;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)1925971987;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (e.Key != global::System.Windows.Input.Key.Right)
					{
						num = (short)918945813;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_673;
				case 14:
					num = (short)455475216;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (this.IsRibbonMenuOpen)
					{
						num = (short)661913638;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 16:
					if (base.SelectedItem is global::DevComponents.WpfRibbon.RibbonTab)
					{
						num = (short)754122791;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25B;
				case 17:
					num = (short)1488191522;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					num = (short)1859649551;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (e.Key != global::System.Windows.Input.Key.Tab)
					{
						num = (short)2004877352;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_673;
				case 20:
					if (e.Key == global::System.Windows.Input.Key.Down)
					{
						num = (short)1496317969;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1602158624;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)474480645;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_3C1;
				case 23:
					if (this.m_KeyTipsAdorner != null)
					{
						num = (short)794886155;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25B;
				case 24:
					if (e.Key != global::System.Windows.Input.Key.Left)
					{
						num = (short)98107419;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_673;
				case 25:
					num = (short)1894383639;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
				{
					global::DevComponents.WpfRibbon.RibbonBarPanel ribbonBarPanel = (global::DevComponents.WpfRibbon.RibbonBarPanel)this.SelectedContent;
					e.Handled = ribbonBarPanel.FocusFirstRibbonBar();
					this.ShowKeyTips = false;
					num = (short)2026045442;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 27:
					num = (short)1553727501;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					num = (short)912130079;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (this.QuickAccessToolbar is global::System.Windows.Controls.ItemsControl)
					{
						num = (short)2020933633;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_423;
				case 30:
					if (global::System.Windows.Input.Keyboard.FocusedElement is global::DevComponents.WpfRibbon.RibbonTab)
					{
						num = (short)866385929;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_423;
				case 31:
					if (this.SelectedContent is global::DevComponents.WpfRibbon.RibbonBarPanel)
					{
						num = (short)584122394;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_423;
				case 32:
					if (e.Key == global::System.Windows.Input.Key.Up)
					{
						num = (short)213123107;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_423;
				case 33:
					if (!e.Handled)
					{
						num = (short)1010171941;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 34:
					if (this.SelectedContent != null)
					{
						num = (short)1902968860;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_423;
				case 35:
					num = (short)796721181;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (this.m_KeyTipsAdorner.ContextObject != null)
					{
						num = (short)1691484174;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25B;
				case 37:
					num = (short)2105868318;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					this.IsRibbonMenuOpen = false;
					num = (short)2119041030;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					this.m_KeyTipsAdorner.ContextObject = null;
					this.m_KeyTipsAdorner.KeyTipsStack = "";
					((global::DevComponents.WpfRibbon.RibbonTab)base.SelectedItem).Focus();
					e.Handled = true;
					num = (short)2098528278;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					num = (short)377094147;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					goto IL_423;
				}
				goto IL_156;
				IL_25B:
				this.RestorePreviousFocus();
				e.Handled = true;
				num = (short)1378287616;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C1:
				num = (short)1260322826;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_423:
				num = (short)1052377112;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_5B5:
				num = (short)338558980;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_673:
				this.ShowKeyTips = false;
				num = (short)1524629512;
				num4 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_156:
			base.OnKeyDown(e);
			num = (short)364511265;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A8;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00089410 File Offset: 0x00087610
		protected override void OnTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1957340533;
					short num3 = num2;
					num2 = (short)465479029;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_72;
					default:
						num2 = (short)76218368;
						if (num2 != 0)
						{
						}
						num2 = (short)1620770820;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (this.m_KeyTipsAdorner != null)
					{
						num2 = (short)1598488576;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (!e.Handled)
					{
						num2 = (short)762707971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					num2 = (short)1814298625;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1879113728;
					short num4 = num2;
					if (this.m_KeyTipsAdorner.ProcessTextInput(e))
					{
						num2 = (short)521601030;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 5:
					return;
				case 6:
					num2 = (short)1088815105;
					if (num2 != 0)
					{
					}
					this.RestorePreviousFocus();
					goto IL_72;
				}
				goto IL_2C;
				IL_72:
				num2 = (short)784596997;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			base.OnTextInput(e);
			num2 = (short)137822210;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000895C4 File Offset: 0x000877C4
		private global::System.Windows.UIElement GetElementWithKeyTip(string s)
		{
			short num = (short)2021851136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)366411796;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.UIElement uielement;
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_5A8;
					case 1:
					{
						int num4;
						if (num3 + 1 == num4)
						{
							num = (short)471269392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FA;
					}
					case 2:
						if (uielement != null)
						{
							num = (short)351666187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FA;
					case 3:
						goto IL_566;
					case 4:
						if (global::DevComponents.WpfRibbon.Ribbon.GetKeyTip(this.ApplicationMenu) == s)
						{
							num = (short)408289283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B0;
					case 5:
						if (!(uielement is global::DevComponents.WpfRibbon.QatCustomizeButton))
						{
							num = (short)1545535494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FA;
					case 6:
						num = (short)1189150721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (uielement.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1357447189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FA;
					case 8:
						try
						{
							num = (short)660865032;
							num2 = (int)((global::System.IntPtr)num);
							global::System.Windows.UIElement result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Windows.UIElement uielement2;
									result = uielement2;
									num = (short)1422327817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1319698437;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Windows.UIElement uielement2;
									if (uielement2 != null)
									{
										num = (short)515112964;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									num = (short)2060749393;
									short num5 = num;
									num = (short)1670875729;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)1161887744;
										if (num != 0)
										{
										}
										num = (short)621477895;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)794296331;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Windows.UIElement uielement2;
									if (uielement2.IsVisible)
									{
										num = (short)2005270531;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_34B;
								case 7:
								{
									global::System.Windows.UIElement uielement2;
									if (global::DevComponents.WpfRibbon.Ribbon.GetKeyTip(uielement2) == s)
									{
										num = (short)1147863040;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_188;
									}
									continue;
								case 9:
									goto IL_1E2;
								case 10:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)517865484;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement2 = enumerator.Current as global::System.Windows.UIElement;
									num = (short)894042114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::System.Windows.UIElement uielement2;
									if (uielement2.IsEnabled)
									{
										num = (short)1765801985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									num = (short)1738080262;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_266:
								num = (short)36569098;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_188:
								goto IL_266;
							}
							IL_1E2:
							return result;
							IL_34B:
							goto IL_5AA;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_36D;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_35A:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)304414722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)1733165056;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3C3;
								case 2:
									goto IL_3C1;
								}
								goto IL_36D;
							}
							IL_3C1:
							IL_3C3:
							goto EndFinally_20;
							IL_36D:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)2101870593;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_35A;
							EndFinally_20:;
						}
						return uielement;
						IL_5AA:
						num = (short)756023320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)380960772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						if (s.Length == 0)
						{
							num = (short)35323904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						s = s.ToUpper();
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
						num = (short)161939464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1451819009;
						if (num != 0)
						{
						}
						num = (short)1736704007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_43B;
					case 13:
					{
						int num4;
						if (int.TryParse(s, out num4))
						{
							num = (short)1553203214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51E;
					}
					case 14:
						num3 = 0;
						num = (short)2035613713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::System.Windows.Controls.ItemsControl itemsControl;
						if (num3 >= itemsControl.Items.Count)
						{
							num = (short)278069271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement = (itemsControl.Items[num3] as global::System.Windows.UIElement);
						num = (short)649527298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_630;
					case 17:
						goto IL_43B;
					case 18:
						if (this.QuickAccessToolbar is global::System.Windows.Controls.ItemsControl)
						{
							num = (short)618463254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51E;
					case 19:
						num = (short)740950026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					case 21:
						num = (short)374800389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::System.Windows.Controls.ItemsControl itemsControl = this.QuickAccessToolbar as global::System.Windows.Controls.ItemsControl;
						int num4 = 0;
						num = (short)1804337165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_47F;
					case 24:
						if (this.ApplicationMenu != null)
						{
							num = (short)1493762057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B0;
					}
					IL_A7:
					if (s != null)
					{
						num = (short)1326514195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5EA;
					IL_43B:
					num = (short)2045444111;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4FA:
					num3++;
					num = (short)1557856268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B0:
					num = (short)1763246098;
					num2 = (int)((global::System.IntPtr)num);
				}
				return uielement;
				IL_47F:
				num = (short)1943535616;
				short num6 = num;
				IL_51E:
				return null;
				IL_566:
				return this.ApplicationMenu;
				IL_5A8:
				IL_5EA:
				return null;
				IL_630:
				return uielement;
			}
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00089CE4 File Offset: 0x00087EE4
		private void RestorePreviousFocus()
		{
			short num = (short)1937702917;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.DependencyObject parent;
				switch (num2)
				{
				case 0:
					if (parent != null)
					{
						num = (short)1827995652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_1AA;
				case 2:
				{
					global::System.Windows.DependencyObject focusScope;
					if (focusScope != null)
					{
						num = (short)1161232391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
					global::System.Windows.Input.Keyboard.Focus(null);
					num = (short)1156055041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)829423616;
					short num3 = num;
					global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(parent);
					num = (short)158072834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 6:
				{
					global::System.Windows.IInputElement focusedElement;
					if (!this.ContainsElement(focusedElement))
					{
						return;
					}
					num = (short)94855911;
					short num4 = num;
					num = (short)1073963751;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B1;
					default:
						num = (short)531038208;
						if (num != 0)
						{
						}
						num = (short)1992687624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
				{
					num = (short)2013986817;
					if (num != 0)
					{
					}
					global::System.Windows.DependencyObject focusScope;
					global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope);
					num = (short)1132986374;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
				{
					global::System.Windows.DependencyObject focusScope;
					global::System.Windows.Input.FocusManager.SetFocusedElement(focusScope, null);
					num = (short)1221918729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					return;
				}
				IL_4C:
				if (base.IsKeyboardFocusWithin)
				{
					num = (short)389742595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1AA;
				IL_1B1:
				num = (short)1035272192;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AA:
				parent = base.Parent;
				goto IL_1B1;
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00089F04 File Offset: 0x00088104
		private bool ContainsElement(global::System.Windows.IInputElement elem)
		{
			short num = (short)415891466;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1F:
				global::System.Windows.Controls.MenuItem menuItem;
				switch (num2)
				{
				case 0:
					goto IL_ED;
				case 1:
				{
					global::System.Windows.DependencyObject dependencyObject;
					while (dependencyObject != this)
					{
						num = (short)1597566114;
						short num3 = num;
						num = (short)524676258;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)943194112;
							if (num != 0)
							{
							}
							menuItem = (dependencyObject as global::System.Windows.Controls.MenuItem);
							num = (short)1799880707;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1F;
						}
					}
					num = (short)1994981377;
					if (num != 0)
					{
					}
					num = (short)1365245956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					if (menuItem == null)
					{
						num = (short)2059599879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.DependencyObject dependencyObject = menuItem.Parent;
					num = (short)1534918661;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_ED;
				case 4:
					return true;
				case 5:
				{
					global::System.Windows.DependencyObject dependencyObject;
					if (dependencyObject == null)
					{
						num = (short)970522633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_70;
				}
				case 6:
					return true;
				case 7:
					return false;
				case 8:
				{
					num = (short)656211968;
					short num4 = num;
					goto IL_70;
				}
				case 9:
				{
					global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(menuItem);
					num = (short)221970440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				}
				IL_51:
				if (elem == this)
				{
					num = (short)1538719750;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				menuItem = (elem as global::System.Windows.Controls.MenuItem);
				num = (short)816644096;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_70:
				num = (short)551616513;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_ED:
				num = (short)359399426;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0008A13C File Offset: 0x0008833C
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)323682306;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)941621248;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					num = (short)891681032;
					short num4 = num;
					num = (short)234092808;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)349437952;
						if (num != 0)
						{
						}
						this.ShowKeyTips = false;
						num = (short)2034171905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_112;
				case 2:
					num = (short)1685913601;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					continue;
				}
				IL_80:
				if ((bool)e.NewValue)
				{
					break;
				}
				num = (short)1277689856;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_112:
			base.OnIsKeyboardFocusWithinChanged(e);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0008A264 File Offset: 0x00088464
		internal void ShowKeyTipsForContext(global::DevComponents.WpfRibbon.RibbonTab contextObject)
		{
			short num = (short)2004418573;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.IsRibbonMenuOpen)
					{
						num = (short)273940487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_213;
				case 1:
					if (!contextObject.IsSelected)
					{
						num = (short)2057437198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13E;
				case 2:
					if (this.m_KeyTipsAdorner != null)
					{
						num = (short)299433996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					if (this.IsMinimized)
					{
						num = (short)944898063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_213;
				case 4:
					return;
				case 5:
					goto IL_FE;
				case 6:
					contextObject.Focus();
					num = (short)794492945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.IsRibbonMenuOpen = true;
					num = (short)731971593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (!contextObject.IsFocused)
					{
						num = (short)1525088262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_284;
				case 9:
					goto IL_F9;
				case 10:
					if (!contextObject.IsSelected)
					{
						num = (short)1479409675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FE;
				case 11:
				{
					num = (short)1062338560;
					short num3 = num;
					contextObject.IsSelected = true;
					num = (short)451215365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
				{
					num = (short)1969585683;
					short num4 = num;
					num = (short)1066237459;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9D;
					default:
						num = (short)895352832;
						if (num != 0)
						{
						}
						this.m_KeyTipsAdorner.ContextObject = contextObject;
						num = (short)443875332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				case 14:
					contextObject.IsSelected = true;
					contextObject.Focus();
					base.UpdateLayout();
					num = (short)1712324624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)1482817536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_13E;
				case 17:
					goto IL_284;
				case 18:
					num = (short)1343225857;
					if (num != 0)
					{
					}
					this.ShowKeyTips = false;
					num = (short)15532042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_71:
				if (this.IsMinimized)
				{
					num = (short)691142674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.ShowKeyTips = true;
				IL_9D:
				num = (short)443482113;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FE:
				num = (short)392036360;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13E:
				num = (short)1893203970;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_284:
				num = (short)385286147;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F9:
			IL_213:
			global::DevComponents.WpfRibbon.RibbonTab contextObject2 = base.SelectedItem as global::DevComponents.WpfRibbon.RibbonTab;
			global::DevComponents.WpfRibbon.KeyTipsAdorner keyTipsAdorner = new global::DevComponents.WpfRibbon.KeyTipsAdorner(this.m_PopupBorder.Child);
			keyTipsAdorner.RootControl = this;
			global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this.m_PopupBorder.Child).Add(keyTipsAdorner);
			keyTipsAdorner.ContextObject = contextObject2;
			this.m_KeyTipsAdorner = keyTipsAdorner;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0008A638 File Offset: 0x00088838
		internal bool KeyTipsVisible
		{
			get
			{
				if (this.m_ShowKeyTips)
				{
					short num;
					for (;;)
					{
						num = (short)88735744;
						short num2 = num;
						num = (short)1153652896;
						short num3 = num;
						num = (short)408967328;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6A;
						}
					}
					IL_6A:
					num = (short)1336999937;
					if (num != 0)
					{
					}
					num = (short)1981415424;
					if (num != 0)
					{
					}
					return true;
				}
				return this.m_KeyTipsAdorner != null;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0008A6F8 File Offset: 0x000888F8
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x0008A7A8 File Offset: 0x000889A8
		internal bool ShowKeyTips
		{
			get
			{
				short num = (short)1545987162;
				short num2 = num;
				num = (short)765322330;
				switch (num2 == num)
				{
				}
				num = (short)1379926017;
				if (num != 0)
				{
				}
				num = (short)1218838528;
				short num3 = num;
				num = (short)1689059328;
				if (num != 0)
				{
				}
				return this.m_ShowKeyTips;
			}
			set
			{
				short num = (short)645136401;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Documents.AdornerLayer adornerLayer;
					switch (num2)
					{
					case 0:
						goto IL_2DB;
					case 1:
						goto IL_B4;
					case 2:
					{
						global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
						ribbonTab.Focus();
						num = (short)789905419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)631242767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.m_KeyTipsAdorner.ContextObject != base.SelectedItem)
						{
							num = (short)1607008276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B4;
					case 5:
						((global::DevComponents.WpfRibbon.RibbonTab)base.SelectedItem).UpdateBorderRenderState();
						num = (short)1603665939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.m_KeyTipsAdorner.ContextObject is global::DevComponents.WpfRibbon.RibbonTab)
						{
							num = (short)942014485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B4;
					case 7:
						if (this.m_ShowKeyTips)
						{
							num = (short)1567686672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)51707910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_1B1;
					case 9:
						if (base.SelectedItem is global::DevComponents.WpfRibbon.RibbonTab)
						{
							num = (short)832962565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						goto IL_20E;
					case 11:
						goto IL_2A2;
					case 12:
						goto IL_2DB;
					case 13:
						if (!value)
						{
							num = (short)1179189251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						adornerLayer.Remove(this.m_KeyTipsAdorner);
						num = (short)1341849608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (this.m_KeyTipsAdorner == null)
						{
							num = (short)2088894474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16F;
					case 16:
						num = (short)1323434002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 18:
						if (!base.IsKeyboardFocusWithin)
						{
							num = (short)1817378839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A2;
					case 19:
						goto IL_29D;
					case 20:
					{
						num = (short)1165950976;
						short num3 = num;
						(this.m_KeyTipsAdorner.ContextObject as global::DevComponents.WpfRibbon.RibbonTab).UpdateBorderRenderState();
						this.UpdatePanelBorderSelectedTabRect();
						num = (short)2087976961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						num = (short)1607661739;
						short num4 = num;
						num = (short)1962342571;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B8;
						default:
							num = (short)316276736;
							if (num != 0)
							{
							}
							num = (short)2037645316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 22:
					{
						global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
						if (ribbonTab != null)
						{
							num = (short)1515323394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A2;
					}
					case 23:
					{
						global::DevComponents.WpfRibbon.RibbonTab ribbonTab = base.SelectedItem as global::DevComponents.WpfRibbon.RibbonTab;
						num = (short)1786118166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (adornerLayer != null)
						{
							num = (short)1055522817;
							if (num != 0)
							{
							}
							num = (short)36438030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B1;
					case 25:
						num = (short)646512653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8C:
					if (this.m_ShowKeyTips == value)
					{
						num = (short)866975769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16F;
					IL_B4:
					adornerLayer = (this.m_KeyTipsAdorner.Parent as global::System.Windows.Documents.AdornerLayer);
					num = (short)52690968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16F:
					this.m_ShowKeyTips = value;
					num = (short)921436167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B8:
					num = (short)1288175628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B1:
					this.m_KeyTipsAdorner = null;
					goto IL_1B8;
					IL_2A2:
					this.m_KeyTipsAdorner = new global::DevComponents.WpfRibbon.KeyTipsAdorner(this);
					global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this).Add(this.m_KeyTipsAdorner);
					num = (short)194052096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DB:
					num = (short)38731785;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_20E:
				return;
				IL_29D:;
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0008AC78 File Offset: 0x00088E78
		private void InternalPostProcessInput(object sender, global::System.Windows.Input.ProcessInputEventArgs e)
		{
			short num = (short)1251541012;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Input.TextCompositionEventArgs textCompositionEventArgs;
			for (;;)
			{
				num = (short)2069238487;
				short num3 = num;
				num = (short)403378903;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1907621888;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						this.EnterKeyTipsMode();
						num = (short)429391877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Windows.Window window;
						if (!window.IsActive)
						{
							num = (short)726335500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_463;
					}
					case 2:
						if ((global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Alt) != global::System.Windows.Input.ModifierKeys.None)
						{
							goto IL_447;
						}
						return;
					case 3:
						num = (short)106168321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)667877391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this.m_KeyTipsAdorner != null)
						{
							num = (short)1958739995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BE;
					case 6:
					{
						num = (short)1310326784;
						short num4 = num;
						global::System.Windows.UIElement elementWithKeyTip;
						this.ShowKeyTipsForContext(elementWithKeyTip as global::DevComponents.WpfRibbon.RibbonTab);
						num = (short)1300430856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)138215446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_3BE;
					case 9:
						if (base.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1468399620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
					{
						global::System.Windows.UIElement elementWithKeyTip;
						if (this.m_KeyTipsAdorner.ExecuteAction(elementWithKeyTip))
						{
							num = (short)877658137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BE;
					}
					case 11:
						this.ShowKeyTips = false;
						num = (short)1835859981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						return;
					case 13:
						goto IL_3BE;
					case 14:
						return;
					case 15:
						if (e.StagingItem.Input.RoutedEvent == global::System.Windows.Input.TextCompositionManager.TextInputEvent)
						{
							num = (short)569442322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						goto IL_339;
					case 17:
					{
						global::System.Windows.UIElement elementWithKeyTip;
						if (elementWithKeyTip != null)
						{
							num = (short)1050804224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 18:
						num = (short)1044578306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (this.ShowKeyTips)
						{
							num = (short)2100101131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BE;
					case 20:
						switch (0)
						{
						case 0:
							goto IL_E5;
						}
						continue;
					case 21:
					{
						global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
						num = (short)1803681816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						if (this.m_KeyTipsAdorner != null)
						{
							num = (short)2027225104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement elementWithKeyTip = this.GetElementWithKeyTip(textCompositionEventArgs.SystemText);
						num = (short)2077163537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)594149385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::System.Windows.Window window;
						if (window != null)
						{
							num = (short)1811152899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_463;
					}
					case 25:
						num = (short)1326317587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (textCompositionEventArgs.SystemText != "")
						{
							num = (short)789512199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 27:
						num = (short)969080860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						global::System.Windows.UIElement elementWithKeyTip;
						if (elementWithKeyTip is global::DevComponents.WpfRibbon.RibbonTab)
						{
							num = (short)181993478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1472135178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_E5:
					num = (short)268042241;
					if (num != 0)
					{
					}
					if (base.IsEnabled)
					{
						num = (short)679936023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_3BE:
					textCompositionEventArgs.Handled = true;
					num = (short)465240078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_463:
					textCompositionEventArgs = (e.StagingItem.Input as global::System.Windows.Input.TextCompositionEventArgs);
					num = (short)1531707418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_447:
				num = (short)1549533205;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_339:
			this.m_KeyTipsAdorner.ProcessTextInput(textCompositionEventArgs);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0008B194 File Offset: 0x00089394
		private global::System.Windows.Input.Key GetKey(global::System.Windows.Input.KeyEventArgs e)
		{
			short num;
			for (;;)
			{
				num = (short)1837105153;
				if (num != 0)
				{
				}
				num = (short)1333723136;
				short num2 = num;
				if (e.Key == global::System.Windows.Input.Key.System)
				{
					goto IL_AF;
				}
				num = (short)1735947465;
				short num3 = num;
				num = (short)898462921;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_93;
				}
			}
			IL_93:
			num = (short)1167261696;
			if (num != 0)
			{
			}
			return e.Key;
			IL_AF:
			return e.SystemKey;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0008B258 File Offset: 0x00089458
		public void ChangeColorScheme(global::DevComponents.WpfRibbon.eRibbonVisualStyle colorTable)
		{
			short num = (short)929300480;
			short num2 = num;
			num = (short)253137638;
			short num3 = num;
			num = (short)1176998630;
			switch (num3 == num)
			{
			}
			num = (short)1871052801;
			if (num != 0)
			{
			}
			num = (short)1426063360;
			if (num != 0)
			{
			}
			global::System.Windows.ResourceDictionary colorTable2 = global::DevComponents.WpfRibbon.Ribbon.GetColorTable(colorTable);
			this.MergeDictionary(colorTable2);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0008B30C File Offset: 0x0008950C
		public void ChangeColorScheme(global::DevComponents.WpfRibbon.eRibbonVisualStyle baseColorTable, global::System.Windows.Media.Color baseColor)
		{
			while (global::System.Windows.Application.Current == null)
			{
				short num = (short)783286272;
				short num2 = num;
				num = (short)2085636353;
				short num3 = num;
				num = (short)729630977;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1360789505;
					if (num != 0)
					{
					}
					num = (short)328335360;
					if (num != 0)
					{
					}
					return;
				}
			}
			global::System.Windows.ResourceDictionary rd = this.CreateColorScheme(baseColorTable, baseColor);
			this.MergeDictionary(rd);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0008B3D4 File Offset: 0x000895D4
		public global::System.Windows.ResourceDictionary CreateColorScheme(global::DevComponents.WpfRibbon.eRibbonVisualStyle baseColorTable, global::System.Windows.Media.Color baseColor)
		{
			short num = (short)1580531712;
			short num2 = num;
			num = (short)306566239;
			short num3 = num;
			num = (short)567399519;
			switch (num3 == num)
			{
			}
			num = (short)779026433;
			if (num != 0)
			{
			}
			num = (short)538247168;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.Ribbon.CreateColorScheme(global::DevComponents.WpfRibbon.Ribbon.GetColorTable(baseColorTable), baseColor);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0008B488 File Offset: 0x00089688
		public static global::System.Windows.ResourceDictionary CreateColorSchemeResourceDictionary(global::DevComponents.WpfRibbon.eRibbonVisualStyle baseColorTable, global::System.Windows.Media.Color baseColor)
		{
			short num = (short)1397227520;
			short num2 = num;
			num = (short)663154821;
			short num3 = num;
			num = (short)1834086533;
			switch (num3 == num)
			{
			}
			num = (short)1954217985;
			if (num != 0)
			{
			}
			num = (short)2077097984;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.Ribbon.CreateColorScheme(global::DevComponents.WpfRibbon.Ribbon.GetColorTable(baseColorTable), baseColor);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0008B540 File Offset: 0x00089740
		private void MergeDictionary(global::System.Windows.ResourceDictionary rd)
		{
			switch (0)
			{
			case 0:
				goto IL_53;
			}
			short num;
			int num2;
			global::System.Windows.ResourceDictionary resourceDictionary2;
			for (;;)
			{
				IL_0A:
				num = (short)21954561;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::System.Windows.ResourceDictionary> enumerator;
				switch (num2)
				{
				case 0:
				{
					num = (short)2046164992;
					short num3 = num;
					num = (short)642449411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_4BE;
				case 2:
					if (global::System.Windows.Application.Current != null)
					{
						num = (short)1196359680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4BE;
				case 3:
					if (this.IsDesignMode)
					{
						num = (short)2058813441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_434;
				case 4:
					goto IL_4DE;
				case 5:
					goto IL_4DE;
				case 6:
					goto IL_8C;
					try
					{
						for (;;)
						{
							IL_8C:
							num = (short)1517682704;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.ResourceDictionary resourceDictionary;
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1048510479;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									resourceDictionary = enumerator.Current;
									num = (short)60489739;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.GraySkin))
									{
										num = (short)292487176;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B9;
								case 2:
									num = (short)2125398022;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.PoliceSkin))
									{
										num = (short)1926823953;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B9;
								case 4:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.Office2010SilverColorScheme))
									{
										num = (short)1560477709;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B9;
								case 5:
									if (resourceDictionary is global::DevComponents.WpfRibbon.themes.FullColorSkin)
									{
										num = (short)2110521363;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.FiremanSkin))
									{
										num = (short)1218183188;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B9;
								case 7:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.MilitarySkin))
									{
										num = (short)1754267650;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B9;
								case 8:
									num = (short)385220612;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_3C5;
								case 10:
									num = (short)1045889025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									num = (short)844449375;
									short num4 = num;
									num = (short)2029405791;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_8C;
									default:
										num = (short)1347944448;
										if (num != 0)
										{
										}
										if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.BlackSkin))
										{
											num = (short)498597900;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1B9;
									}
									break;
								}
								case 12:
									num = (short)1192099854;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									num = (short)1421475843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.BlueSkin))
									{
										num = (short)1253703690;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B9;
								case 15:
									num = (short)930611209;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									switch (0)
									{
									case 0:
										goto IL_104;
									}
									continue;
								case 17:
									num = (short)273874951;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_1DD;
								case 19:
									goto IL_1B9;
								case 20:
									num = (short)1938685957;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_106:
								num = (short)1185677312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_104:
								goto IL_106;
								IL_1B9:
								resourceDictionary2.MergedDictionaries.Remove(resourceDictionary);
								num = (short)838926354;
								num2 = (int)((global::System.IntPtr)num);
							}
						}
						IL_1DD:
						IL_3C5:
						goto IL_506;
					}
					finally
					{
						num = (short)573702145;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1126170626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_3FA;
								}
								continue;
							case 2:
								goto IL_431;
							}
							IL_3FA:
							if (enumerator == null)
							{
								break;
							}
							num = (short)233504768;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_431:;
					}
					goto IL_434;
				}
				goto IL_53;
				IL_434:
				resourceDictionary2 = global::System.Windows.Application.Current.Resources;
				num = (short)1896611845;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4BE:
				resourceDictionary2 = this.Resources;
				num = (short)923467780;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4DE:
				enumerator = resourceDictionary2.MergedDictionaries.GetEnumerator();
				num = (short)1364590598;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_506:
			resourceDictionary2.MergedDictionaries.Add(rd);
			return;
			IL_53:
			resourceDictionary2 = null;
			num = (short)999948290;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0008BA7C File Offset: 0x00089C7C
		public static void SetColorScheme(global::DevComponents.WpfRibbon.eRibbonVisualStyle colorTable)
		{
			while (global::System.Windows.Application.Current == null)
			{
				short num = (short)1905197056;
				short num2 = num;
				num = (short)1830223873;
				if (num != 0)
				{
				}
				num = (short)1189045586;
				short num3 = num;
				num = (short)603415890;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)907542528;
					if (num != 0)
					{
					}
					return;
				}
			}
			global::DevComponents.WpfRibbon.Ribbon.MergeStaticDictionary(global::DevComponents.WpfRibbon.Ribbon.GetColorTable(colorTable));
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0008BB3C File Offset: 0x00089D3C
		public static void SetColorScheme(global::DevComponents.WpfRibbon.eRibbonVisualStyle baseColorTable, global::System.Windows.Media.Color baseColor)
		{
			while (global::System.Windows.Application.Current == null)
			{
				short num = (short)1721761792;
				short num2 = num;
				num = (short)868275895;
				short num3 = num;
				num = (short)805557943;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)765526017;
					if (num != 0)
					{
					}
					num = (short)166330368;
					if (num != 0)
					{
					}
					return;
				}
			}
			global::DevComponents.WpfRibbon.Ribbon.MergeStaticDictionary(global::DevComponents.WpfRibbon.Ribbon.CreateColorScheme(global::DevComponents.WpfRibbon.Ribbon.GetColorTable(baseColorTable), baseColor));
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0008BC00 File Offset: 0x00089E00
		private static void MergeStaticDictionary(global::System.Windows.ResourceDictionary rd)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Windows.ResourceDictionary resourceDictionary2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::System.Windows.ResourceDictionary> enumerator;
				switch (num)
				{
				case 0:
					goto IL_52;
				case 1:
					if (global::System.Windows.Application.Current == null)
					{
						num2 = (short)1960312832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_418;
				case 2:
					goto IL_7E;
					try
					{
						for (;;)
						{
							IL_7E:
							num2 = (short)1236467728;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								global::System.Windows.ResourceDictionary resourceDictionary;
								switch (num)
								{
								case 0:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.BlueSkin))
									{
										num2 = (short)32636943;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_225;
								case 1:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.Office2010SilverColorScheme))
									{
										num2 = (short)1505361928;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_225;
								case 2:
									goto IL_225;
								case 3:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.BlackSkin))
									{
										num2 = (short)1500577809;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_225;
								case 4:
									num2 = (short)269877249;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 5:
									num2 = (short)932904971;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 6:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.PoliceSkin))
									{
										num2 = (short)122421268;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_225;
								case 7:
									if (resourceDictionary is global::DevComponents.WpfRibbon.themes.FullColorSkin)
									{
										num2 = (short)823721986;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								case 8:
									num2 = (short)601030662;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 9:
									goto IL_3AD;
								case 10:
									num2 = (short)26738697;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 11:
								{
									if (resourceDictionary is global::DevComponents.WpfRibbon.themes.FiremanSkin)
									{
										goto IL_225;
									}
									num2 = (short)798221928;
									short num3 = num2;
									num2 = (short)1865541224;
									switch ((num3 == num2) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_7E;
									default:
										num2 = (short)671678464;
										if (num2 != 0)
										{
										}
										num2 = (short)558956556;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								}
								case 12:
									num2 = (short)688979975;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 13:
									goto IL_249;
								case 14:
									if (!enumerator.MoveNext())
									{
										num2 = (short)1960509450;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									resourceDictionary = enumerator.Current;
									num2 = (short)329187331;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 15:
									num2 = (short)777322515;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 16:
									switch (0)
									{
									case 0:
										goto IL_F7;
									}
									continue;
								case 17:
									num2 = (short)387710976;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 18:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.MilitarySkin))
									{
										num2 = (short)1487470597;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_225;
								case 19:
									if (!(resourceDictionary is global::DevComponents.WpfRibbon.themes.GraySkin))
									{
										num2 = (short)527368196;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_225;
								case 20:
									num2 = (short)401670162;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								IL_170:
								num2 = (short)1305149454;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_F7:
								goto IL_170;
								IL_225:
								resourceDictionary2.MergedDictionaries.Remove(resourceDictionary);
								num2 = (short)1724055565;
								num = (int)((global::System.IntPtr)num2);
							}
						}
						IL_249:
						IL_3AD:
						goto IL_475;
					}
					finally
					{
						num2 = (short)587923457;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)671547394;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_3E2;
								}
								continue;
							case 2:
								goto IL_415;
							}
							IL_3E2:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)728236032;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_415:;
					}
					goto IL_418;
				}
				goto IL_1C;
				IL_418:
				num2 = (short)1573453824;
				short num4 = num2;
				resourceDictionary2 = global::System.Windows.Application.Current.Resources;
				enumerator = resourceDictionary2.MergedDictionaries.GetEnumerator();
				num2 = (short)1539571714;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_52:
			num2 = (short)1151139841;
			if (num2 != 0)
			{
			}
			return;
			IL_475:
			resourceDictionary2.MergedDictionaries.Add(rd);
			return;
			IL_1C:
			resourceDictionary2 = null;
			num2 = (short)1978859521;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0008C0AC File Offset: 0x0008A2AC
		private static global::System.Windows.ResourceDictionary GetColorTable(global::DevComponents.WpfRibbon.eRibbonVisualStyle colorTable)
		{
			int a_ = 1;
			short num = (short)1543897089;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_C4;
			}
			int num2;
			global::System.Windows.ResourceDictionary result;
			for (;;)
			{
				IL_3A:
				switch (num2)
				{
				case 0:
					result = new global::DevComponents.WpfRibbon.themes.FiremanSkin();
					num = (short)1860698129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1E4;
				case 2:
				{
					if (colorTable == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Blue)
					{
						num = (short)1162084355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)449273725;
					short num3 = num;
					num = (short)1580162941;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3EA;
					default:
						num = (short)1907687424;
						if (num != 0)
						{
						}
						num = (short)520224781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					result = new global::DevComponents.WpfRibbon.themes.Office2010BlueColorScheme();
					num = (short)1162215429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return result;
				case 5:
					goto IL_1C1;
				case 6:
					if (colorTable == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Military)
					{
						num = (short)2004680715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1574895639;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					result = new global::DevComponents.WpfRibbon.themes.PoliceSkin();
					num = (short)1818361857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					result = new global::DevComponents.WpfRibbon.themes.Office2010BlackColorScheme();
					num = (short)267190292;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					return result;
				case 10:
					goto IL_229;
				case 11:
					result = new global::DevComponents.WpfRibbon.themes.MilitarySkin();
					num = (short)1687552009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (colorTable == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007FullColor)
					{
						num = (short)1818230806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A2;
				case 13:
					if (colorTable == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Black)
					{
						num = (short)1122500616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)4980752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (colorTable == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Classic)
					{
						num = (short)2005467165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1569128480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					result = new global::DevComponents.WpfRibbon.themes.Office2010SilverColorScheme();
					num = (short)462159876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (colorTable == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Black)
					{
						num = (short)1617756190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1437204505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_19F;
				case 18:
					return result;
				case 19:
					result = new global::DevComponents.WpfRibbon.themes.GraySkin();
					num = (short)1082523658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_17D;
				case 21:
					if (colorTable == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Silver)
					{
						num = (short)201326611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2056519694;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					result = new global::DevComponents.WpfRibbon.themes.FullColorSkin();
					num = (short)614268954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (colorTable == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Fireman)
					{
						num = (short)1244397568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1117650956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					result = new global::DevComponents.WpfRibbon.themes.BlueSkin();
					num = (short)2074673183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_3EA;
				case 26:
					goto IL_206;
				case 27:
					goto IL_15B;
				case 28:
					if (colorTable == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Silver)
					{
						num = (short)1349189647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)882245634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					result = new global::DevComponents.WpfRibbon.themes.ClassicSkin();
					num = (short)1491468315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					result = new global::DevComponents.WpfRibbon.themes.BlackSkin();
					num = (short)248709138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					goto IL_2D4;
				case 32:
					if (colorTable == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Police)
					{
						num = (short)970457095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)882245638;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_C4;
				IL_3EA:
				if (colorTable == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Blue)
				{
					num = (short)638386200;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1831731221;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_15B:
			IL_17D:
			IL_19F:
			IL_1C1:
			IL_1E4:
			IL_206:
			IL_229:
			return result;
			IL_2A2:
			throw new global::System.ComponentModel.InvalidEnumArgumentException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩘ㑚ㅜぞ፠䍢ᅤ٦୨ݪ࡬佮ὰᱲŴ坶᝸ᑺॼ彾", a_));
			IL_2D4:
			num = (short)5963776;
			short num4 = num;
			return result;
			IL_C4:
			result = null;
			num = (short)2132279324;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_3A;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0008C60C File Offset: 0x0008A80C
		private static global::System.Windows.ResourceDictionary CreateColorScheme(global::System.Windows.ResourceDictionary rd, global::System.Windows.Media.Color baseColor)
		{
			short num = (short)127139840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)156041217;
				if (num != 0)
				{
				}
				num = (short)663420928;
				short num3 = num;
				global::DevComponents.WpfRibbon.ColorFactory colorFactory = global::DevComponents.WpfRibbon.Ribbon.GetColorFactory(baseColor);
				global::System.Collections.IEnumerator enumerator = rd.Keys.GetEnumerator();
				try
				{
					num = (short)1655242752;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						object obj;
						object obj2;
						string text;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_F4;
							}
							continue;
						case 1:
						{
							global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2 = (obj as global::System.Windows.Media.LinearGradientBrush).GradientStops.GetEnumerator();
							num = (short)841416718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_268;
						case 3:
							if (obj is global::System.Windows.Media.LinearGradientBrush)
							{
								num = (short)1452998657;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)451411986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)1573650441;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							obj2 = enumerator.Current;
							obj = null;
							num = (short)567803912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_419;
						case 6:
							if (obj is global::System.Windows.Media.SolidColorBrush)
							{
								num = (short)2063269901;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)731250691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_13E;
							try
							{
								for (;;)
								{
									IL_13E:
									num = (short)1741357059;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = (short)1592066050;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_255;
										case 3:
											switch (0)
											{
											case 0:
												goto IL_17A;
											}
											continue;
										case 4:
										{
											global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)711262208;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1363767227;
											short num4 = num;
											num = (short)249458619;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_13E;
											default:
											{
												num = (short)1840381952;
												if (num != 0)
												{
												}
												global::System.Windows.Media.GradientStop gradientStop = enumerator2.Current;
												gradientStop.Color = colorFactory.GetColor(gradientStop.Color);
												num = (short)1604059137;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											break;
										}
										}
										IL_17C:
										num = (short)42860548;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_17A:
										goto IL_17C;
									}
								}
								IL_255:
								break;
							}
							finally
							{
								global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_268;
						case 8:
							if (obj2 is global::System.Windows.ComponentResourceKey)
							{
								num = (short)771883010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F9;
						case 9:
							num = (short)562364431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (text.StartsWith(global::DevComponents.WpfRibbon.RibbonColors.ButtonWithBackgroundClass))
							{
								num = (short)1090584592;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 12:
						{
							global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2 = (obj as global::System.Windows.Media.RadialGradientBrush).GradientStops.GetEnumerator();
							num = (short)1810366471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							global::System.Windows.Media.SolidColorBrush solidColorBrush = obj as global::System.Windows.Media.SolidColorBrush;
							solidColorBrush.Color = colorFactory.GetColor(solidColorBrush.Color);
							num = (short)1348665355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							try
							{
								num = (short)521994243;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)711131137;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.Media.GradientStop gradientStop2 = enumerator2.Current;
										gradientStop2.Color = colorFactory.GetColor(gradientStop2.Color);
										num = (short)1803091972;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)1406468098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_406;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_37A;
										}
										continue;
									}
									IL_3B2:
									num = (short)1603403776;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_37A:
									goto IL_3B2;
								}
								IL_406:
								break;
							}
							finally
							{
								global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_419;
						case 15:
							goto IL_59A;
						case 16:
							goto IL_F9;
						case 17:
							if (text.StartsWith(global::DevComponents.WpfRibbon.RibbonColors.ButtonClass))
							{
								num = (short)532742149;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F9;
						case 18:
							if (obj is global::System.Windows.Media.RadialGradientBrush)
							{
								num = (short)1439498252;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						goto IL_F4;
						IL_F9:
						obj = rd[obj2];
						num = (short)1298464774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_268:
						text = (obj2 as global::System.Windows.ComponentResourceKey).ResourceId.ToString();
						num = (short)1733099537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2FF:
						num = (short)1827602436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_F4:
						goto IL_2FF;
						IL_419:
						num = (short)1928855562;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_59A:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_5B9;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_5A6:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)1906245633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_60E;
						case 2:
							if (disposable != null)
							{
								num = (short)1230569472;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_610;
						}
						goto IL_5B9;
					}
					IL_60E:
					IL_610:
					goto EndFinally_19;
					IL_5B9:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)234356738;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_5A6;
					EndFinally_19:;
				}
				return rd;
			}
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0008CC78 File Offset: 0x0008AE78
		private static global::DevComponents.WpfRibbon.ColorFactory GetColorFactory(global::System.Windows.Media.Color baseColor)
		{
			short num = (short)1503580074;
			short num2 = num;
			num = (short)2027212714;
			switch (num2 == num)
			{
			}
			num = (short)1823145984;
			short num3 = num;
			num = (short)424935425;
			if (num != 0)
			{
			}
			num = (short)1446969344;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfRibbon.ColorBlendFactory(baseColor);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0008CD28 File Offset: 0x0008AF28
		private static void OnButtonDropDownCheckedClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)511508480;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			int num3;
			global::DevComponents.WpfRibbon.Ribbon ribbon;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)1279362147;
					short num4 = num;
					num = (short)88179811;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E6;
					default:
						num = (short)4784128;
						if (num != 0)
						{
						}
						if (e.OriginalSource is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)1608384514;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
					ribbon.SyncChecked(e.OriginalSource as global::DevComponents.WpfRibbon.ButtonDropDown);
					num = (short)70975488;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (e.Source is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num = (short)207486980;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E6;
				case 4:
					goto IL_B3;
				}
				goto IL_4E;
				IL_E6:
				num = (short)760741889;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_B3:
			ribbon.SyncChecked(e.Source as global::DevComponents.WpfRibbon.ButtonDropDown);
			return;
			IL_4E:
			ribbon = (global::DevComponents.WpfRibbon.Ribbon)sender;
			num = (short)1200685057;
			if (num != 0)
			{
			}
			num = (short)178651139;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0008CEBC File Offset: 0x0008B0BC
		private static void OnButtonDropDownUnCheckedClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1691350968;
			short num2 = num;
			num = (short)4454328;
			switch (num2 == num)
			{
			}
			num = (short)440860672;
			short num3 = num;
			num = (short)279576577;
			if (num != 0)
			{
			}
			num = (short)2072838144;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.Ribbon)sender).SyncChecked(e.Source as global::DevComponents.WpfRibbon.ButtonDropDown);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0008CF78 File Offset: 0x0008B178
		private void SyncChecked(global::DevComponents.WpfRibbon.ButtonDropDown button)
		{
			short num = (short)399704067;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.IsElementOnQat(button))
					{
						num = (short)1518927878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					if (!(button.Name == ""))
					{
						num = (short)1784020992;
						short num3 = num;
						num = (short)1720188930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)852754433;
					if (num != 0)
					{
					}
					num = (short)1108213760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 4:
				{
					if (button.Command is global::DevComponents.WpfRibbon.ButtonDropDownCommand)
					{
						num = (short)1697644549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown>.Enumerator enumerator = this.GetAllInstances(button.Name).GetEnumerator();
					num = (short)1010040840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_2E6;
				case 6:
					goto IL_2A7;
				case 7:
					num = (short)1642987521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_161;
					try
					{
						for (;;)
						{
							IL_161:
							num = (short)1806172162;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
									buttonDropDown.IsChecked = button.IsChecked;
									num = (short)502071302;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1698627587;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = enumerator.Current;
									num = (short)734855172;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1A2;
									}
									continue;
								case 3:
									num = (short)986120197;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
									if (buttonDropDown != button)
									{
										num = (short)93585408;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_24C;
								}
								IL_1FC:
								num = (short)1808269313;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A2:
								goto IL_1FC;
							}
							IL_24C:
							num = (short)1939862142;
							short num4 = num;
							num = (short)2126901886;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_281;
							}
						}
						IL_281:
						num = (short)1294991360;
						if (num != 0)
						{
						}
						return;
					}
					finally
					{
						global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_2A7;
				}
				IL_48:
				if (button != null)
				{
					num = (short)1541472263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2A7:
				num = (short)1732378628;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_2E6:;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0008D28C File Offset: 0x0008B48C
		public global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown> GetAllInstances(string name)
		{
			short num;
			global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown> list;
			for (;;)
			{
				num = (short)274006016;
				short num2 = num;
				num = (short)674627585;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				int num3;
				for (;;)
				{
					IL_58:
					switch (num3)
					{
					case 0:
						goto IL_CA;
					case 1:
					{
						global::System.Windows.Controls.ItemsControl itemsControl;
						if (itemsControl != null)
						{
							num = (short)5505026;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10E;
					}
					case 2:
					{
						global::System.Windows.Controls.ItemsControl itemsControl;
						this.FindAllInstances(itemsControl, name, list);
						num = (short)1733689344;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						if (name.Length == 0)
						{
							num = (short)1560608772;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Controls.ItemsControl itemsControl = this.QuickAccessToolbar as global::System.Windows.Controls.ItemsControl;
						num = (short)1692336129;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return list;
					}
					goto IL_72;
				}
				IL_10E:
				num = (short)77761495;
				short num4 = num;
				num = (short)357141463;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_143;
				}
				IL_CA:
				goto IL_10E;
				IL_72:
				list = new global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown>();
				num = (short)344064003;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			return list;
			IL_143:
			num = (short)1051852800;
			if (num != 0)
			{
			}
			this.FindAllInstances(this, name, list);
			return list;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0008D3FC File Offset: 0x0008B5FC
		private void FindAllInstances(global::System.Windows.Controls.ItemsControl ic, string name, global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown> list)
		{
			int a_ = 3;
			short num = (short)630259712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)926023681;
				if (num != 0)
				{
				}
				num = (short)381288448;
				short num3 = num;
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)ic.Items).GetEnumerator();
				try
				{
					num = (short)1006567424;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_104;
							}
							continue;
						case 1:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							this.FindAllInstances(buttonDropDown.Items[0] as global::DevComponents.WpfRibbon.RibbonBar, name, list);
							num = (short)626589702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							if (buttonDropDown.Items.Count > 0)
							{
								num = (short)620625929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							object obj;
							this.FindAllInstances(obj as global::System.Windows.Controls.ItemsControl, name, list);
							num = (short)1668612101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							object obj;
							if (obj is global::System.Windows.Controls.ItemsControl)
							{
								num = (short)450166788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)987103248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							num = (short)296157201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)1702232077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							if (buttonDropDown != null)
							{
								num = (short)875626504;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1603010567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_449;
						case 12:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							if (buttonDropDown.Name.StartsWith(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("࡚⑜ⱞだɢᅤ╦ᱨὪᥬnὰⱲ", a_)))
							{
								num = (short)1431633939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 13:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							if (buttonDropDown.Items[0] is global::DevComponents.WpfRibbon.RibbonBar)
							{
								num = (short)2065694721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 15:
							num = (short)2034696203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
						{
							object obj;
							if (obj is global::System.Windows.Controls.Panel)
							{
								num = (short)297992212;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 17:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							if (buttonDropDown.Name == name)
							{
								num = (short)305790997;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1097793548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)43909135;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							object obj = enumerator.Current;
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = obj as global::DevComponents.WpfRibbon.ButtonDropDown;
							goto IL_3A9;
						}
						case 19:
							num = (short)489816067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
						{
							num = (short)1177562740;
							short num4 = num;
							num = (short)313142900;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3A9;
							default:
							{
								num = (short)627376128;
								if (num != 0)
								{
								}
								object obj;
								this.FindAllInstances(obj as global::System.Windows.Controls.Panel, name, list);
								num = (short)1253179406;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 21:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							list.Add(buttonDropDown);
							num = (short)457834498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_225:
						num = (short)252510226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_104:
						goto IL_225;
						IL_3A9:
						num = (short)1186660362;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_449:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_468;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_455:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)1414004737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_4BC;
						case 2:
							if (disposable != null)
							{
								num = (short)1218772992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4BE;
						}
						goto IL_468;
					}
					IL_4BC:
					IL_4BE:
					goto EndFinally_12;
					IL_468:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)145358850;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_455;
					EndFinally_12:;
				}
				return;
			}
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0008D8E4 File Offset: 0x0008BAE4
		private void FindAllInstances(global::System.Windows.Controls.Panel p, string name, global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown> list)
		{
			short num = (short)956039168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)666173441;
				if (num != 0)
				{
				}
				num = (short)2022309888;
				short num3 = num;
				global::System.Collections.IEnumerator enumerator = p.Children.GetEnumerator();
				try
				{
					num = (short)2140209154;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)318963715;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = uielement as global::DevComponents.WpfRibbon.ButtonDropDown;
							num = (short)1924071435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_2C9;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_DF;
							}
							continue;
						case 3:
							num = (short)1450377217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::System.Windows.Controls.ItemsControl)
							{
								num = (short)1129054216;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1587544071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)1809776649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::System.Windows.Controls.Panel)
							{
								num = (short)1037631500;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::System.Windows.UIElement uielement;
							this.FindAllInstances(uielement as global::System.Windows.Controls.ItemsControl, name, list);
							num = (short)1350893578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							if (buttonDropDown.Name == name)
							{
								num = (short)646447117;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_223;
						}
						case 11:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							if (buttonDropDown != null)
							{
								num = (short)1809645574;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_223;
						}
						case 12:
						{
							global::System.Windows.UIElement uielement;
							this.FindAllInstances(uielement as global::System.Windows.Controls.Panel, name, list);
							num = (short)85655566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							list.Add(buttonDropDown);
							num = (short)1772355589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1E2:
						num = (short)1644363776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DF:
						goto IL_1E2;
						IL_223:
						num = (short)412286980;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2C9:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_2EB;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_2D8:
						switch (num2)
						{
						case 0:
							goto IL_392;
						case 1:
							goto IL_370;
						case 2:
							if (disposable != null)
							{
								num = (short)709230593;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_394;
						}
						goto IL_2EB;
					}
					IL_392:
					IL_394:
					goto EndFinally_9;
					IL_2EB:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1350703359;
					short num4 = num;
					num = (short)1022892287;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_370:
						disposable.Dispose();
						num = (short)690290688;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_2D8;
					default:
						num = (short)1937833984;
						if (num != 0)
						{
						}
						num = (short)488243202;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_2D8;
					}
					EndFinally_9:;
				}
				return;
			}
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0008DCA4 File Offset: 0x0008BEA4
		internal static bool IsLivePreviewActive
		{
			get
			{
				short num = (short)488046593;
				if (num != 0)
				{
				}
				num = (short)2078267355;
				short num2 = num;
				num = (short)463919067;
				switch (num2 == num)
				{
				}
				num = (short)29360128;
				short num3 = num;
				num = (short)1640562688;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfRibbon.Ribbon._IsLivePreviewActive;
			}
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0008DD54 File Offset: 0x0008BF54
		internal static void SetIsLivePreviewActive(global::System.Windows.FrameworkElement elem, bool active)
		{
			short num = (short)727777286;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1194685311;
					short num3 = num;
					num = (short)1188328319;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AC;
					default:
						num = (short)269746176;
						if (num != 0)
						{
						}
						global::DevComponents.WpfRibbon.Ribbon._IsLivePreviewActive = active;
						num = (short)638451714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)1678901251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (elem != null)
					{
						num = (short)800456705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					if (global::DevComponents.WpfRibbon.Ribbon._IsLivePreviewActive)
					{
						num = (short)184352773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					elem.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.Ribbon.ExitLivePreviewEvent, elem));
					num = (short)263782404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_15E;
				case 5:
					goto IL_F4;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				}
				IL_41:
				if (global::DevComponents.WpfRibbon.Ribbon._IsLivePreviewActive == active)
				{
					return;
				}
				num = (short)1371078656;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AC:
			elem.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.Ribbon.EnterLivePreviewEvent, elem));
			return;
			IL_F4:
			goto IL_AC;
			IL_15E:
			num = (short)1122435072;
			short num4 = num;
			num = (short)597164033;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0008DF10 File Offset: 0x0008C110
		public static bool PopupAllowsTransparency
		{
			get
			{
				short num = (short)856962740;
				short num2 = num;
				num = (short)171914932;
				switch (num2 == num)
				{
				}
				num = (short)1390477312;
				if (num != 0)
				{
				}
				num = (short)1035075584;
				short num3 = num;
				num = (short)170131457;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfRibbon.Ribbon._PopupAllowsTransparency;
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0008DFC0 File Offset: 0x0008C1C0
		private static void OnPopupIsSelectedChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<bool> e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			global::DevComponents.WpfRibbon.Ribbon ribbon;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_EE;
				case 2:
					num2 = (short)1200291841;
					if (num2 != 0)
					{
					}
					if (ribbon != null)
					{
						num2 = (short)1114570753;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			ribbon = (global::DevComponents.WpfRibbon.Ribbon)sender;
			num2 = (short)1030160384;
			short num3 = num2;
			num2 = (short)2093524174;
			short num4 = num2;
			num2 = (short)1182442702;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_EE:
				ribbon.OnSelectedChanged(sender, e);
				num2 = (short)356777984;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)864288768;
				if (num2 != 0)
				{
				}
				num2 = (short)295632898;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0008E0E0 File Offset: 0x0008C2E0
		private void OnSelectedChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<bool> e)
		{
			short num = (short)1266082652;
			short num2 = num;
			num = (short)274457436;
			switch (num2 == num)
			{
			}
			num = (short)2135097345;
			if (num != 0)
			{
			}
			num = (short)26869760;
			short num3 = num;
			num = (short)420741120;
			if (num != 0)
			{
			}
			this.m_PopupHandler.OnIsSelectedChanged(sender, e);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0008E194 File Offset: 0x0008C394
		private static void OnButtonDropDownPreviewClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)752575844;
			short num2 = num;
			num = (short)112158052;
			switch (num2 == num)
			{
			}
			num = (short)1458241537;
			if (num != 0)
			{
			}
			num = (short)2011234304;
			short num3 = num;
			num = (short)1911619584;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ParentPopupControlImpl.OnButtonDropDownPreviewClick(sender, e);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0008E244 File Offset: 0x0008C444
		private static void OnMouseButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1167200333;
			short num2 = num;
			num = (short)681578573;
			switch (num2 == num)
			{
			}
			num = (short)663814144;
			if (num != 0)
			{
			}
			num = (short)1753022464;
			short num3 = num;
			num = (short)151519233;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.Ribbon)sender).InternalMouseButtonDown(e);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0008E2FC File Offset: 0x0008C4FC
		protected virtual void InternalMouseButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1937702914;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)145824759;
					short num3 = num;
					num = (short)64625655;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_F3;
					}
					goto Block_2;
				}
				case 1:
					this.ShowKeyTips = false;
					num = (short)307101696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (!this.ShowKeyTips)
				{
					goto IL_10C;
				}
				num = (short)190840833;
				if (num != 0)
				{
				}
				num = (short)1377501185;
				num2 = (int)((global::System.IntPtr)num);
			}
			Block_2:
			num = (short)967376896;
			short num4 = num;
			IL_F3:
			num = (short)591462400;
			if (num != 0)
			{
			}
			IL_10C:
			this.m_PopupHandler.ClosePopupOnMouseEvent(e);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0008E424 File Offset: 0x0008C624
		private static void OnPreviewMouseButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1372446985;
			short num2 = num;
			num = (short)20635913;
			switch (num2 == num)
			{
			}
			num = (short)1474887680;
			if (num != 0)
			{
			}
			num = (short)1395523584;
			short num3 = num;
			num = (short)126222337;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.Ribbon)sender).InternalPreviewMouseButtonDown(e);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0008E4DC File Offset: 0x0008C6DC
		private void InternalPreviewMouseButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			int a_ = 3;
			short num = (short)1639710720;
			switch (num)
			{
			default:
			{
				num = (short)428736529;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
					{
						global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
						if (applicationMenu.IsBackstageActive)
						{
							num = (short)722272269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7AB;
					}
					case 1:
						this.ShowKeyTips = false;
						num = (short)2041446443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (flag)
						{
							num = (short)1892417581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7AB;
					case 3:
					{
						global::System.Windows.DependencyObject dependencyObject;
						if (dependencyObject == null)
						{
							num = (short)1500315677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)628752396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
						global::System.Windows.Rect rect;
						if (!rect.Contains(e.GetPosition(applicationMenu)))
						{
							num = (short)917962761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7AB;
					}
					case 5:
					{
						global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
						if (!applicationMenu.BackstageUsesPopup)
						{
							num = (short)1076166670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7AB;
					}
					case 6:
						flag = false;
						num = (short)744357911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (((global::DevComponents.WpfRibbon.ButtonDropDown)e.Source).Parent is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)1846018074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CE;
					case 8:
						if (this.IsRibbonMenuOpen)
						{
							num = (short)624558124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8EE;
					case 9:
						flag = true;
						num = (short)1726414869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Windows.DependencyObject dependencyObject;
						if (dependencyObject.GetType().ToString().Contains(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("୚㉜⽞ᑠ።㝤ࡦ٨Ὢ", a_)))
						{
							num = (short)244121647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1866661916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (this.ShowKeyTips)
						{
							num = (short)1384316929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
					{
						global::System.Windows.DependencyObject dependencyObject;
						if (dependencyObject != this.m_PopupBorder.Child)
						{
							num = (short)1632174096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 13:
					{
						global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
						global::System.Windows.Rect rect = new global::System.Windows.Rect(applicationMenu.RenderSize);
						num = (short)1334444036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						num = (short)165819714;
						short num3 = num;
						num = (short)1753363778;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_483;
						default:
							num = (short)1612513280;
							if (num != 0)
							{
							}
							num = (short)1504641024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
						if (e.Source is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)425590808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CE;
					case 16:
						num = (short)994902052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						switch (0)
						{
						case 0:
							goto IL_125;
						}
						continue;
					case 18:
					{
						global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
						if (applicationMenu.IsPopupOpen)
						{
							num = (short)1437335593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7AB;
					}
					case 19:
					{
						global::System.Windows.Rect rect2 = new global::System.Windows.Rect(0.0, 0.0, base.RenderSize.Width, this.m_RibbonContentPanel.BackgroundChrome.TotalTitleChromeHeight);
						num = (short)1000210478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						num = (short)894959616;
						short num4 = num;
						if (this.m_PopupBorder != null)
						{
							num = (short)568197142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8EE;
					}
					case 21:
						if (this.HasCaption)
						{
							num = (short)1248329766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56D;
					case 22:
					{
						global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
						num = (short)810156083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_56D;
					case 24:
						num = (short)1404698631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_423;
					case 26:
						goto IL_483;
					case 27:
					{
						global::System.Windows.DependencyObject dependencyObject;
						if (dependencyObject != this.m_PopupHandler.CurrentSelection)
						{
							num = (short)165806115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 28:
					{
						global::System.Windows.DependencyObject dependencyObject;
						if (dependencyObject is global::System.Windows.Media.Visual)
						{
							num = (short)2096889887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
						num = (short)914554932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						this.IsRibbonMenuOpen = false;
						num = (short)1099497502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_8EE;
					case 31:
					{
						global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
						num = (short)80150567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						if (flag)
						{
							num = (short)1512505394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CE;
					case 33:
						goto IL_5CE;
					case 34:
						goto IL_7AB;
					case 35:
						num = (short)609484810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						global::System.Windows.DependencyObject dependencyObject;
						if (!(dependencyObject is global::System.Windows.Controls.Primitives.Popup))
						{
							num = (short)1974992944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 37:
						num = (short)1420558378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)726204456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_423;
					case 40:
						if (this.m_RibbonContentPanel != null)
						{
							num = (short)1411383333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56D;
					case 41:
						num = (short)1149304837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (this.m_RibbonContentPanel.BackgroundChrome != null)
						{
							num = (short)2137784339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56D;
					case 43:
						goto IL_47E;
					case 44:
						num = (short)342622228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
						applicationMenu.IsPopupOpen = false;
						num = (short)26869794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
					{
						global::System.Windows.Rect rect2;
						if (rect2.Contains(e.GetPosition(this)))
						{
							num = (short)1657143302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56D;
					}
					case 47:
						goto IL_841;
					case 48:
						num = (short)1334575131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu = this.ApplicationMenu as global::DevComponents.WpfRibbon.ApplicationMenu;
						num = (short)1095827474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
						num = (short)272105487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						global::System.Windows.DependencyObject dependencyObject;
						if (dependencyObject != null)
						{
							num = (short)690421813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8EE;
					}
					case 52:
						goto IL_423;
					case 53:
						num = (short)169148441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_125:
					num = (short)2107899905;
					if (num != 0)
					{
					}
					if (this.ApplicationMenu is global::DevComponents.WpfRibbon.ApplicationMenu)
					{
						num = (short)1782972465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7AB;
					IL_423:
					num = (short)1931673603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_483:
					flag = false;
					num = (short)1913651233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56D:
					num = (short)314441760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CE:
					num = (short)1367998466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7AB:
					num = (short)943325192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8EE:
					num = (short)1086849035;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_47E:
				return;
				IL_841:
				return;
			}
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0008EE14 File Offset: 0x0008D014
		private static void OnMouseButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)233521116;
			short num2 = num;
			num = (short)399917020;
			switch (num2 == num)
			{
			}
			num = (short)755957761;
			if (num != 0)
			{
			}
			num = (short)1429471232;
			if (num != 0)
			{
			}
			num = (short)1057947648;
			short num3 = num;
			((global::DevComponents.WpfRibbon.Ribbon)sender).InternalMouseButtonUp(e);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0008EECC File Offset: 0x0008D0CC
		protected virtual void InternalMouseButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)652932792;
			short num2 = num;
			num = (short)1605826232;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)522387457;
				if (num != 0)
				{
				}
				num = (short)439222272;
				if (num != 0)
				{
				}
				num = (short)550567937;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_AE;
						}
						continue;
					case 2:
					{
						num = (short)1186004992;
						short num4 = num;
						num = (short)1790574597;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Windows.Rect rect;
						global::System.Windows.Point position;
						if (rect.Contains(position))
						{
							num = (short)689438722;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_196;
					}
					case 4:
					{
						global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu = this.ApplicationMenu as global::DevComponents.WpfRibbon.ApplicationMenu;
						global::System.Windows.Point position = e.GetPosition(applicationMenu);
						global::System.Windows.Rect rect = new global::System.Windows.Rect(applicationMenu.RenderSize);
						num = (short)1974665219;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
						if (applicationMenu.IsPopupOpen)
						{
							num = (short)1527185408;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_196;
					}
					}
					IL_AE:
					if (!(this.ApplicationMenu is global::DevComponents.WpfRibbon.ApplicationMenu))
					{
						break;
					}
					num = (short)1024262148;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_196:
				this.m_PopupHandler.ClosePopupOnMouseEvent(e);
				return;
			}
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0008F07C File Offset: 0x0008D27C
		private static void OnLostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1165416855;
			short num2 = num;
			num = (short)1135335831;
			switch (num2 == num)
			{
			}
			num = (short)1715339265;
			if (num != 0)
			{
			}
			num = (short)267059200;
			if (num != 0)
			{
			}
			num = (short)141819904;
			short num3 = num;
			global::DevComponents.WpfRibbon.ParentPopupControlImpl.OnLostMouseCapture(sender, e);
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0008F130 File Offset: 0x0008D330
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x0008F1E8 File Offset: 0x0008D3E8
		bool global::DevComponents.WpfRibbon.IPopupParentControl.IsPopupMode
		{
			get
			{
				short num = (short)1048562767;
				short num2 = num;
				num = (short)344247375;
				switch (num2 == num)
				{
				}
				num = (short)38207489;
				if (num != 0)
				{
				}
				num = (short)152698880;
				if (num != 0)
				{
				}
				num = (short)1055784960;
				short num3 = num;
				return this.m_PopupHandler.IsPopupMode;
			}
			set
			{
				short num = (short)863039415;
				short num2 = num;
				num = (short)707850167;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_104:
					this.IsRibbonMenuOpen = false;
					num = (short)652083204;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1936523264;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					break;
				}
				for (;;)
				{
					IL_57:
					switch (num3)
					{
					case 0:
						goto IL_15D;
					case 1:
						if (this.IsRibbonMenuOpen)
						{
							num = (short)1907097600;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						if (!value)
						{
							num = (short)558891009;
							if (num != 0)
							{
							}
							num = (short)599785475;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						num = (short)971440129;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_124;
					}
					goto IL_71;
				}
				IL_124:
				return;
				IL_15D:
				goto IL_104;
				IL_71:
				this.m_PopupHandler.IsPopupMode = value;
				num = (short)2115698688;
				short num4 = num;
				num = (short)2049769474;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_57;
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0008F354 File Offset: 0x0008D554
		private void PopupHandlerInternalMenuModeChanged(object sender, global::System.EventArgs e)
		{
			short num = (short)446087155;
			short num2 = num;
			num = (short)1264107507;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)458620928;
				if (num != 0)
				{
				}
				num = (short)391905282;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)309723137;
						if (num != 0)
						{
						}
						this.IsRibbonMenuOpen = false;
						num = (short)883294208;
						short num4 = num;
						num = (short)1073217540;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (this.IsRibbonMenuOpen)
						{
							num = (short)2043412480;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					case 3:
						num = (short)1260912641;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_11B;
					}
					IL_84:
					if (this.m_PopupHandler.IsPopupMode)
					{
						break;
					}
					num = (short)1863188483;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				break;
			}
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0008F4BC File Offset: 0x0008D6BC
		internal static void ShowKeyboardCues(global::System.Windows.DependencyObject obj, bool value)
		{
			int a_ = 2;
			short num = (short)1197211650;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (obj != null)
					{
						num = (short)871759879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 3:
					goto IL_181;
				case 4:
				{
					num = (short)869796386;
					short num3 = num;
					num = (short)2072054306;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_181;
					case 1:
						break;
					default:
					{
						num = (short)1216086016;
						short num4 = num;
						break;
					}
					}
					num = (short)1086717953;
					if (num != 0)
					{
					}
					num = (short)1905721344;
					if (num != 0)
					{
					}
					if (global::DevComponents.WpfRibbon.Ribbon.s_ShowKeyboardCues != null)
					{
						num = (short)1090387971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 5:
					goto IL_A8;
				case 6:
					global::DevComponents.WpfRibbon.Ribbon.s_ShowKeyboardCues = typeof(global::System.Windows.Input.KeyboardNavigation).GetField(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ख़㑛ㅝ᝟⥡ţὥ੧թ൫ᱭᑯㅱų፵୷⩹๻ᅽ", a_), global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.NonPublic);
					num = (short)290455557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					global::System.Windows.DependencyProperty dp = global::DevComponents.WpfRibbon.Ribbon.s_ShowKeyboardCues.GetValue(null) as global::System.Windows.DependencyProperty;
					obj.SetValue(dp, true);
					num = (short)1079377920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4E:
				if (global::DevComponents.WpfRibbon.Ribbon.s_ShowKeyboardCues == null)
				{
					num = (short)1796079622;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A8:
				num = (short)552206340;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_181:
				num = (short)1007353857;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0008F6C8 File Offset: 0x0008D8C8
		bool global::DevComponents.WpfRibbon.IPopupParentControl.QueryMouseCapturePopupClose(global::System.Windows.DependencyObject sourceObject)
		{
			short num = (short)1487044348;
			short num2 = num;
			num = (short)1783660284;
			switch (num2 == num)
			{
			}
			num = (short)1906966529;
			if (num != 0)
			{
			}
			num = (short)82771968;
			if (num != 0)
			{
			}
			num = (short)4456448;
			short num3 = num;
			return true;
		}

		// Token: 0x040002AE RID: 686
		public static readonly global::System.Windows.DependencyProperty VisualStyleProperty;

		// Token: 0x040002AF RID: 687
		private static readonly global::System.Windows.DependencyPropertyKey EffectiveStylePropertyKey;

		// Token: 0x040002B0 RID: 688
		public static readonly global::System.Windows.DependencyProperty EffectiveStyleProperty;

		// Token: 0x040002B1 RID: 689
		public static readonly global::System.Windows.DependencyProperty AutoExpandProperty;

		// Token: 0x040002B2 RID: 690
		public static readonly global::System.Windows.DependencyProperty CanDialogCustomizeQatProperty;

		// Token: 0x040002B3 RID: 691
		public static readonly global::System.Windows.DependencyProperty CanChangeQatPlacementProperty;

		// Token: 0x040002B4 RID: 692
		public static readonly global::System.Windows.DependencyProperty IsRibbonMenuOpenProperty;

		// Token: 0x040002B5 RID: 693
		public static readonly global::System.Windows.DependencyProperty IsMinimizedProperty;

		// Token: 0x040002B6 RID: 694
		public static readonly global::System.Windows.DependencyProperty ApplicationMenuProperty;

		// Token: 0x040002B7 RID: 695
		public static readonly global::System.Windows.DependencyProperty QuickAccessToolbarProperty;

		// Token: 0x040002B8 RID: 696
		public static readonly global::System.Windows.DependencyProperty IsQuickAccessToolbarBelowProperty;

		// Token: 0x040002B9 RID: 697
		public static readonly global::System.Windows.DependencyProperty WindowBorderThicknessProperty;

		// Token: 0x040002BA RID: 698
		public static readonly global::System.Windows.DependencyProperty HorizontalWindowBorderThicknessProperty;

		// Token: 0x040002BB RID: 699
		private static readonly global::System.Windows.DependencyPropertyKey HorizontalWindowBorderThicknessPropertyKey;

		// Token: 0x040002BC RID: 700
		public static readonly global::System.Windows.DependencyProperty SelectedContentProperty;

		// Token: 0x040002BD RID: 701
		private static readonly global::System.Windows.DependencyPropertyKey SelectedContentPropertyKey;

		// Token: 0x040002BE RID: 702
		public static readonly global::System.Windows.DependencyProperty SelectedContentTemplateProperty;

		// Token: 0x040002BF RID: 703
		private static readonly global::System.Windows.DependencyPropertyKey SelectedContentTemplatePropertyKey;

		// Token: 0x040002C0 RID: 704
		public static readonly global::System.Windows.DependencyProperty SelectedContentTemplateSelectorProperty;

		// Token: 0x040002C1 RID: 705
		private static readonly global::System.Windows.DependencyPropertyKey SelectedContentTemplateSelectorPropertyKey;

		// Token: 0x040002C2 RID: 706
		public static readonly global::System.Windows.DependencyProperty ContentTemplateSelectorProperty;

		// Token: 0x040002C3 RID: 707
		public static readonly global::System.Windows.DependencyProperty ContentTemplateProperty;

		// Token: 0x040002C4 RID: 708
		private static readonly global::System.Windows.DependencyPropertyKey ContextGroupsPropertyKey;

		// Token: 0x040002C5 RID: 709
		public static readonly global::System.Windows.DependencyProperty ContextGroupsProperty;

		// Token: 0x040002C6 RID: 710
		public static readonly global::System.Windows.DependencyProperty IsUsingGlassProperty;

		// Token: 0x040002C7 RID: 711
		private static readonly global::System.Windows.DependencyPropertyKey IsUsingGlassPropertyKey;

		// Token: 0x040002C8 RID: 712
		public static readonly global::System.Windows.DependencyProperty KeyTipProperty;

		// Token: 0x040002C9 RID: 713
		public static readonly global::System.Windows.DependencyProperty IsCustomizableProperty;

		// Token: 0x040002CA RID: 714
		public static readonly global::System.Windows.DependencyProperty ElementRoleProperty;

		// Token: 0x040002CB RID: 715
		public static readonly global::System.Windows.DependencyProperty IsCustomizableContextSetProperty;

		// Token: 0x040002CC RID: 716
		public static readonly global::System.Windows.DependencyProperty UseSpecKeyTipPositioningProperty;

		// Token: 0x040002CD RID: 717
		public static readonly global::System.Windows.DependencyProperty AutoHideRibbonContentProperty;

		// Token: 0x040002CE RID: 718
		public static readonly global::System.Windows.DependencyProperty AutoHideTriggerSizeProperty;

		// Token: 0x040002CF RID: 719
		public static readonly global::System.Windows.DependencyProperty SystemButtonsProperty;

		// Token: 0x040002D0 RID: 720
		public static global::System.Windows.Input.RoutedCommand ToggleRibbonMinimize;

		// Token: 0x040002D1 RID: 721
		public static readonly global::System.Windows.DependencyProperty LicenseKeyProperty;

		// Token: 0x040002D8 RID: 728
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty;

		// Token: 0x040002D9 RID: 729
		public static readonly global::System.Windows.DependencyProperty LivePreviewEnabledProperty;

		// Token: 0x040002DE RID: 734
		private const string PartTabContentPresenter = "PART_TabContentHost";

		// Token: 0x040002DF RID: 735
		private const string PartRibbonPanelBorderName = "PART_RibbonPanelBorder";

		// Token: 0x040002E0 RID: 736
		private const string PartQatPresenter = "PART_QAT";

		// Token: 0x040002E1 RID: 737
		private const string PartAppMenuPresenter = "PART_ApplicationMenu";

		// Token: 0x040002E2 RID: 738
		private const string PartQatBelowContainer = "PART_RibbonQatBelowBorder";

		// Token: 0x040002E3 RID: 739
		private const string PartRibbonContentPanel = "PART_RCP";

		// Token: 0x040002E4 RID: 740
		private const string PartPopup = "PART_Popup";

		// Token: 0x040002E5 RID: 741
		private const string PartRibbonContentBorder = "PART_RibbonPanelBorder";

		// Token: 0x040002E6 RID: 742
		private const string PartRibbonPopupBorder = "PART_RibbonPopupBorder";

		// Token: 0x040002E7 RID: 743
		private const string QatRibbonBarNamePart = "SysQatButton_";

		// Token: 0x040002E8 RID: 744
		private global::DevComponents.WpfRibbon.RibbonBorder m_PanelBorder;

		// Token: 0x040002E9 RID: 745
		internal global::DevComponents.WpfRibbon.ParentPopupControlImpl m_PopupHandler;

		// Token: 0x040002EA RID: 746
		private global::System.Windows.Controls.ContentPresenter m_QatPresenter;

		// Token: 0x040002EB RID: 747
		private global::System.Windows.Controls.ContentPresenter m_AppMenuPresenter;

		// Token: 0x040002EC RID: 748
		private global::System.Windows.Controls.Decorator m_QatBelowContainer;

		// Token: 0x040002ED RID: 749
		private global::DevComponents.WpfRibbon.RibbonContentPanel m_RibbonContentPanel;

		// Token: 0x040002EE RID: 750
		private global::System.Windows.Controls.Primitives.Popup m_Popup;

		// Token: 0x040002EF RID: 751
		private global::DevComponents.WpfRibbon.RibbonBorder m_ContentBorder;

		// Token: 0x040002F0 RID: 752
		private global::DevComponents.WpfRibbon.RibbonBorder m_PopupBorder;

		// Token: 0x040002F1 RID: 753
		private global::DevComponents.WpfRibbon.RibbonLocalization m_SystemText = new global::DevComponents.WpfRibbon.RibbonLocalization();

		// Token: 0x040002F2 RID: 754
		private bool m_ShowKeyTips;

		// Token: 0x040002F3 RID: 755
		private global::DevComponents.WpfRibbon.KeyTipsAdorner m_KeyTipsAdorner;

		// Token: 0x040002F4 RID: 756
		private global::System.Windows.Input.CommandBinding _RibbonMinimizeCommandBinding;

		// Token: 0x040002F5 RID: 757
		private global::System.Windows.Input.KeyBinding _RibbonMinimizeKeyBinding;

		// Token: 0x040002F6 RID: 758
		private global::System.Delegate m_EnterMenuModeDelegate;

		// Token: 0x040002F7 RID: 759
		private static bool _IsLivePreviewActive;

		// Token: 0x040002F8 RID: 760
		private static bool _PopupAllowsTransparency;

		// Token: 0x040002F9 RID: 761
		private static global::System.Reflection.FieldInfo s_ShowKeyboardCues;

		// Token: 0x040002FA RID: 762
		public static readonly string SystemAddToQatMenuItem;

		// Token: 0x040002FB RID: 763
		public static readonly string SystemRemoveFromQatMenuItem;

		// Token: 0x040002FC RID: 764
		public static readonly string SystemCustomizeQatMenuItem;

		// Token: 0x040002FD RID: 765
		public static readonly string SystemQatChangePlacementMenuItem;

		// Token: 0x040002FE RID: 766
		public static readonly string SystemQatMinMaxRibbonMenuItem;

		// Token: 0x040002FF RID: 767
		public static readonly string SysQatCustomizeContextMenu;
	}
}
