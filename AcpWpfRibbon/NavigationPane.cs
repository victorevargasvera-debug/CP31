using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200005C RID: 92
	public class NavigationPane : global::System.Windows.Controls.Primitives.Selector
	{
		// Token: 0x06000429 RID: 1065 RVA: 0x0005BC4C File Offset: 0x00059E4C
		static NavigationPane()
		{
			int a_ = 6;
			short num = (short)790626304;
			short num2 = num;
			num = (short)1564147713;
			if (num != 0)
			{
			}
			num = (short)1806861290;
			short num3 = num;
			num = (short)742032362;
			switch (num3 == num)
			{
			}
			num = (short)1532100608;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.NavigationPane.Collapse = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵝཟ๡ࡣݥᡧᥩ५", a_), typeof(global::DevComponents.WpfRibbon.NavigationPane));
			global::DevComponents.WpfRibbon.NavigationPane.Expand = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᭝ᡟቡգࡥ౧", a_), typeof(global::DevComponents.WpfRibbon.NavigationPane));
			global::DevComponents.WpfRibbon.NavigationPane.LicenseKeyProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ቝय़šţࡥ᭧ཀྵ❫୭९", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.NavigationPane.OnLicenseKeyChanged)));
			global::DevComponents.WpfRibbon.NavigationPane.SelectedContentHeaderTemplateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝՟๡ţեᱧཀྵ࡫⵭Ὧᱱs፵ᙷ๹㑻᭽\udc87ﺍﲏ", a_), typeof(global::System.Windows.DataTemplate), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.NavigationPane.SystemShowMoreButtonsMenuItem = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝ᥟᅡၣͥէ㥩ѫŭݯ㽱᭳ѵᵷ㡹ॻ੽얇ﮍ\ud98fﮕ", a_);
			global::DevComponents.WpfRibbon.NavigationPane.SystemShowFewerButtonsMenuItem = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝ᥟᅡၣͥէ㥩ѫŭݯ㑱ᅳŵᵷࡹ㹻୽ﮇ잉\udb91", a_);
			global::DevComponents.WpfRibbon.NavigationPane.SystemNavPaneOptionMenuItem = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝ᥟᅡၣͥէ⑩൫ᡭ⁯፱ᩳ፵㝷੹ࡻ᝽즃ﾉ얋揄ﾑ", a_);
			global::DevComponents.WpfRibbon.NavigationPane.SystemAddRemoveMenuItem = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝ᥟᅡၣͥէ⭩࡫੭≯᝱ᥳ᥵๷όㅻ᭽춃", a_);
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.NavigationPane)));
			global::DevComponents.WpfRibbon.NavigationPane.SelectedContentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝՟๡ţեᱧཀྵ࡫⵭Ὧᱱs፵ᙷ๹", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.NavigationPane.SelectedContentProperty = global::DevComponents.WpfRibbon.NavigationPane.SelectedContentPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.NavigationPane.SelectedContentTemplatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝՟๡ţեᱧཀྵ࡫⵭Ὧᱱs፵ᙷ๹⡻᭽ﲇ", a_), typeof(global::System.Windows.DataTemplate), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.NavigationPane.SelectedContentTemplateProperty = global::DevComponents.WpfRibbon.NavigationPane.SelectedContentTemplatePropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.NavigationPane.SelectedContentTemplateSelectorPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝՟๡ţեᱧཀྵ࡫⵭Ὧᱱs፵ᙷ๹⡻᭽ﲇ\udf8bﲏ", a_), typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.NavigationPane.SelectedContentTemplateSelectorProperty = global::DevComponents.WpfRibbon.NavigationPane.SelectedContentTemplateSelectorPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.NavigationPane.SelectedContentHeaderPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝՟๡ţեᱧཀྵ࡫⵭Ὧᱱs፵ᙷ๹㑻᭽", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
			global::DevComponents.WpfRibbon.NavigationPane.SelectedContentHeaderProperty = global::DevComponents.WpfRibbon.NavigationPane.SelectedContentHeaderPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.NavigationPane.ContentTemplateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵝཟౡၣͥ٧ṩ㡫୭ᵯɱᡳ᝵౷ό", a_), typeof(global::System.Windows.DataTemplate), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.NavigationPane.ContentTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵝཟౡၣͥ٧ṩ㡫୭ᵯɱᡳ᝵౷ό⽻᭽", a_), typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.NavigationPane.SelectedPaneItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝՟๡ţեᱧཀྵ࡫㹭ᅯᱱᅳ㽵౷όᅻ", a_), typeof(global::DevComponents.WpfRibbon.PaneItem), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.NavigationPane.SelectedPaneItemProperty = global::DevComponents.WpfRibbon.NavigationPane.SelectedPaneItemPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.NavigationPane.IsExpandedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᝝፟❡ᱣᙥ१ѩ࡫୭ᑯ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.NavigationPane.IsExpandedChanged)));
			global::DevComponents.WpfRibbon.NavigationPane.LargeItemsCountProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ቝşၡͣͥⅧṩ५ͭͯㅱ᭳͵ᙷ๹", a_), typeof(int), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(3, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.NavigationPane.LargeItemsCountChanged)));
			global::DevComponents.WpfRibbon.NavigationPane.SystemTextPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝ᥟᅡၣͥէ㹩५᙭ѯ", a_), typeof(global::DevComponents.WpfRibbon.NavigationPaneLocalization), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.NavigationPane.SystemTextProperty = global::DevComponents.WpfRibbon.NavigationPane.SystemTextPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.NavigationPane.ExpandedWidthProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᭝ᡟቡգࡥ౧ཀྵ࡫㥭᥯ᙱsṵ", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));
			global::DevComponents.WpfRibbon.NavigationPane.CollapsedWidthProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵝཟ๡ࡣݥᡧᥩ५੭❯᭱ၳɵၷ", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.NavigationPane), new global::System.Windows.FrameworkPropertyMetadata(33.0));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.NavigationPane), global::System.Windows.Input.Mouse.LostMouseCaptureEvent, new global::System.Windows.Input.MouseEventHandler(global::DevComponents.WpfRibbon.NavigationPane.OnLostMouseCapture));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.NavigationPane), global::System.Windows.Input.Mouse.PreviewMouseDownOutsideCapturedElementEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::DevComponents.WpfRibbon.NavigationPane.MouseDownOutsideCapturedElement));
			global::DevComponents.WpfRibbon.NavigationPane.ExpandedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᭝ᡟቡգࡥ౧ཀྵ࡫", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.NavigationPane));
			global::DevComponents.WpfRibbon.NavigationPane.CollapsedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵝཟ๡ࡣݥᡧᥩ५੭", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.NavigationPane));
			global::DevComponents.WpfRibbon.NavigationPane.PopupOpenedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("๝ཟቡᅣᙥ❧ᩩ५mᕯᙱ", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.NavigationPane));
			global::DevComponents.WpfRibbon.NavigationPane.PopupClosedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("๝ཟቡᅣᙥ⭧٩ͫᵭᕯᙱ", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.NavigationPane));
			global::DevComponents.WpfRibbon.NavigationPane.BeforeCustomizeDialogEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᱝ՟ѡୣᑥ൧⥩ᥫᵭѯᵱᥳήɷό㡻᝽", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.NavigationPane));
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0005C238 File Offset: 0x0005A438
		public NavigationPane()
		{
			this.SystemText = new global::DevComponents.WpfRibbon.NavigationPaneLocalization();
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0005C268 File Offset: 0x0005A468
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0005C320 File Offset: 0x0005A520
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue("")]
		public string LicenseKey
		{
			get
			{
				short num = (short)1284374528;
				short num2 = num;
				num = (short)670782225;
				short num3 = num;
				num = (short)679891729;
				switch (num3 == num)
				{
				}
				num = (short)675414016;
				if (num != 0)
				{
				}
				num = (short)529596417;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.LicenseKeyProperty);
			}
			set
			{
				short num = (short)2074673152;
				short num2 = num;
				num = (short)1834576932;
				short num3 = num;
				num = (short)1495559204;
				switch (num3 == num)
				{
				}
				num = (short)2121203713;
				if (num != 0)
				{
				}
				num = (short)1636368384;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.LicenseKeyProperty, value);
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0005C3D4 File Offset: 0x0005A5D4
		private static void OnLicenseKeyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)346947584;
			short num2 = num;
			num = (short)1267400705;
			if (num != 0)
			{
			}
			num = (short)1799885383;
			short num3 = num;
			num = (short)168497735;
			switch (num3 == num)
			{
			}
			num = (short)1184038912;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.NavigationPane)d).OnLicenseKeyChanged();
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0005C488 File Offset: 0x0005A688
		private void OnLicenseKeyChanged()
		{
			short num = (short)1116012544;
			short num2 = num;
			num = (short)1757989847;
			short num3 = num;
			num = (short)913886167;
			switch (num3 == num)
			{
			}
			num = (short)431226880;
			if (num != 0)
			{
			}
			num = (short)978845697;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.WinApi.ValidateLicenseKey(this.LicenseKey);
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600042F RID: 1071 RVA: 0x0005C53C File Offset: 0x0005A73C
		// (remove) Token: 0x06000430 RID: 1072 RVA: 0x0005C5F4 File Offset: 0x0005A7F4
		public event global::System.Windows.RoutedEventHandler Expanded
		{
			add
			{
				short num = (short)1279000576;
				short num2 = num;
				num = (short)1145091729;
				short num3 = num;
				num = (short)1337964177;
				switch (num3 == num)
				{
				}
				num = (short)1520631809;
				if (num != 0)
				{
				}
				num = (short)1096286208;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.NavigationPane.ExpandedEvent, value);
			}
			remove
			{
				short num = (short)1963393024;
				short num2 = num;
				num = (short)2044898192;
				short num3 = num;
				num = (short)323136400;
				switch (num3 == num)
				{
				}
				num = (short)2124283905;
				if (num != 0)
				{
				}
				num = (short)2086076416;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.NavigationPane.ExpandedEvent, value);
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0005C6AC File Offset: 0x0005A8AC
		protected virtual void OnExpanded(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)482934784;
			short num2 = num;
			num = (short)1086524046;
			short num3 = num;
			num = (short)1468664462;
			switch (num3 == num)
			{
			}
			num = (short)1292763137;
			if (num != 0)
			{
			}
			num = (short)423297024;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000432 RID: 1074 RVA: 0x0005C760 File Offset: 0x0005A960
		// (remove) Token: 0x06000433 RID: 1075 RVA: 0x0005C818 File Offset: 0x0005AA18
		public event global::System.Windows.RoutedEventHandler Collapsed
		{
			add
			{
				short num = (short)601227264;
				short num2 = num;
				num = (short)1120138234;
				short num3 = num;
				num = (short)290255866;
				switch (num3 == num)
				{
				}
				num = (short)1814822913;
				if (num != 0)
				{
				}
				num = (short)33161216;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.NavigationPane.CollapsedEvent, value);
			}
			remove
			{
				short num = (short)443285504;
				short num2 = num;
				num = (short)1326373647;
				short num3 = num;
				num = (short)1864555279;
				switch (num3 == num)
				{
				}
				num = (short)503644161;
				if (num != 0)
				{
				}
				num = (short)1969356800;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.NavigationPane.CollapsedEvent, value);
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0005C8D0 File Offset: 0x0005AAD0
		protected virtual void OnCollapsed(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1985478656;
			short num2 = num;
			num = (short)1162084353;
			if (num != 0)
			{
			}
			num = (short)1382793601;
			short num3 = num;
			num = (short)448577921;
			switch (num3 == num)
			{
			}
			num = (short)509149184;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000435 RID: 1077 RVA: 0x0005C984 File Offset: 0x0005AB84
		// (remove) Token: 0x06000436 RID: 1078 RVA: 0x0005CA38 File Offset: 0x0005AC38
		public event global::System.Windows.RoutedEventHandler PopupOpened
		{
			add
			{
				short num = (short)1553203200;
				short num2 = num;
				num = (short)2067095842;
				short num3 = num;
				num = (short)1101488418;
				switch (num3 == num)
				{
				}
				num = (short)499515393;
				if (num != 0)
				{
				}
				num = (short)1200095232;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.NavigationPane.PopupOpenedEvent, value);
			}
			remove
			{
				short num = (short)1960706048;
				short num2 = num;
				num = (short)157236586;
				short num3 = num;
				num = (short)569523562;
				switch (num3 == num)
				{
				}
				num = (short)283705345;
				if (num != 0)
				{
				}
				num = (short)1140195328;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.NavigationPane.PopupOpenedEvent, value);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0005CAF0 File Offset: 0x0005ACF0
		protected virtual void OnPopupOpened(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)677773312;
			short num2 = num;
			num = (short)505608746;
			short num3 = num;
			num = (short)1578564138;
			switch (num3 == num)
			{
			}
			num = (short)368181248;
			if (num != 0)
			{
			}
			num = (short)1533870081;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000438 RID: 1080 RVA: 0x0005CBA4 File Offset: 0x0005ADA4
		// (remove) Token: 0x06000439 RID: 1081 RVA: 0x0005CC60 File Offset: 0x0005AE60
		public event global::System.Windows.RoutedEventHandler PopupClosed
		{
			add
			{
				short num = (short)1192886272;
				short num2 = num;
				num = (short)619137394;
				short num3 = num;
				num = (short)546982258;
				switch (num3 == num)
				{
				}
				num = (short)1563426816;
				if (num != 0)
				{
				}
				num = (short)1438973953;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.NavigationPane.PopupClosedEvent, value);
			}
			remove
			{
				short num = (short)717946880;
				short num2 = num;
				num = (short)510579018;
				short num3 = num;
				num = (short)696045898;
				switch (num3 == num)
				{
				}
				num = (short)50855937;
				if (num != 0)
				{
				}
				num = (short)110166016;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.NavigationPane.PopupClosedEvent, value);
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0005CD18 File Offset: 0x0005AF18
		protected virtual void OnPopupClosed(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1165164544;
			short num2 = num;
			num = (short)1713973517;
			short num3 = num;
			num = (short)1728325901;
			switch (num3 == num)
			{
			}
			num = (short)1044971521;
			if (num != 0)
			{
			}
			num = (short)412352512;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600043B RID: 1083 RVA: 0x0005CDC8 File Offset: 0x0005AFC8
		// (remove) Token: 0x0600043C RID: 1084 RVA: 0x0005CE80 File Offset: 0x0005B080
		public event global::System.Windows.RoutedEventHandler BeforeCustomizeDialog
		{
			add
			{
				short num = (short)1236729856;
				short num2 = num;
				num = (short)1370278411;
				short num3 = num;
				num = (short)1454295563;
				switch (num3 == num)
				{
				}
				num = (short)111411201;
				if (num != 0)
				{
				}
				num = (short)327680000;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.NavigationPane.BeforeCustomizeDialogEvent, value);
			}
			remove
			{
				short num = (short)537460736;
				short num2 = num;
				num = (short)421744683;
				short num3 = num;
				num = (short)1763921963;
				switch (num3 == num)
				{
				}
				num = (short)1711079425;
				if (num != 0)
				{
				}
				num = (short)1192034304;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.NavigationPane.BeforeCustomizeDialogEvent, value);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0005CF34 File Offset: 0x0005B134
		protected virtual void OnBeforeCustomizeDialogEvent(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1655701504;
			short num2 = num;
			num = (short)482310129;
			short num3 = num;
			num = (short)427390961;
			switch (num3 == num)
			{
			}
			num = (short)994115585;
			if (num != 0)
			{
			}
			num = (short)1350434816;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0005CFE8 File Offset: 0x0005B1E8
		public override void OnApplyTemplate()
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)640679936;
					short num3 = num2;
					this._Popup.Opened += this.InternalPopupOpened;
					num2 = (short)485097479;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (this._Popup != null)
					{
						num2 = (short)2069430274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10F;
				case 2:
				{
					this._Popup.Opened -= this.InternalPopupOpened;
					num2 = (short)1230391421;
					short num4 = num2;
					num2 = (short)1144866941;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_65;
					default:
						num2 = (short)1808072704;
						if (num2 != 0)
						{
						}
						num2 = (short)1436942340;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_65;
				case 4:
					goto IL_10F;
				case 5:
					this._PopupToggle.Click -= this.PopupToggleClick;
					num2 = (short)591331336;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_1FA;
				case 7:
					goto IL_232;
				case 8:
					goto IL_18B;
				case 9:
					if (this._PopupToggle != null)
					{
						num2 = (short)623050763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_310;
				case 10:
					if (this._Popup != null)
					{
						num2 = (short)652673024;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_232;
				case 11:
					this._PopupToggle.Click += this.PopupToggleClick;
					num2 = (short)1364721670;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_49;
				IL_65:
				if (this._PopupToggle != null)
				{
					num2 = (short)550043649;
					if (num2 != 0)
					{
					}
					num2 = (short)2016673797;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_18B;
				IL_10F:
				this._ItemsPanel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㭪ⱬ㵮╰Ⱳ㱴Ͷᱸᙺ⵼Ṿ", a_)) as global::DevComponents.WpfRibbon.NavigationPanePanel);
				this._Popup = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㭪ⱬ㵮╰Ⱳ╴ᡶॸ๺ർ", a_)) as global::System.Windows.Controls.Primitives.Popup);
				num2 = (short)8126474;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_18B:
				num2 = (short)2075262977;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_232:
				this._PopupToggle = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㭪ⱬ㵮╰Ⱳ╴ᡶॸ๺ർ⭾", a_)) as global::System.Windows.Controls.Primitives.ToggleButton);
				num2 = (short)1092616201;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1FA:
			IL_310:
			this.UpdateAllSelectedContent();
			return;
			IL_49:
			base.OnApplyTemplate();
			num2 = (short)632029187;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0005D30C File Offset: 0x0005B50C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::DevComponents.WpfRibbon.NavigationPanePanel InternalItemsPanel
		{
			get
			{
				short num = (short)1005060096;
				short num2 = num;
				num = (short)1582790011;
				short num3 = num;
				num = (short)1619424635;
				switch (num3 == num)
				{
				}
				num = (short)1264582657;
				if (num != 0)
				{
				}
				num = (short)1153761280;
				if (num != 0)
				{
				}
				return this._ItemsPanel;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0005D3C0 File Offset: 0x0005B5C0
		internal double MinimumContentHeight
		{
			get
			{
				short num = (short)1741029379;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.Size size;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (((global::System.Windows.FrameworkElement)this.SelectedContent).MinHeight > 0.0)
						{
							num = (short)1296957441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC;
					case 1:
						goto IL_219;
					case 2:
						if (size.Height > 0.0)
						{
							num = (short)1727725574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FC;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_54;
						}
						continue;
					case 4:
						num = (short)441843720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1794310144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_273;
					case 7:
						if (size.Height > 0.0)
						{
							num = (short)960495626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						size = this._ItemsPanel.FirstVisible.DesiredSize;
						num = (short)397148162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_28F;
					case 9:
						size = this._ItemsPanel.FirstVisible.RenderSize;
						num = (short)1727266823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_196;
					case 11:
						if (this._ItemsPanel != null)
						{
							num = (short)630980612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FC;
					}
					IL_54:
					num = (short)1810594459;
					short num3 = num;
					num = (short)601979547;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_28F:
						if (this._ItemsPanel.FirstVisible != null)
						{
							num = (short)479789065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FC;
					default:
					{
						num = (short)1931542528;
						short num4 = num;
						num = (short)898695169;
						if (num != 0)
						{
						}
						num = (short)1478295552;
						if (num != 0)
						{
						}
						if (this.SelectedContent is global::System.Windows.FrameworkElement)
						{
							num = (short)140574725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_2BC:
					num = (short)859242507;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_196:
				size = this._ItemsPanel.FirstVisible.RenderSize;
				return size.Height / 2.0;
				IL_219:
				return ((global::System.Windows.FrameworkElement)this.SelectedContent).MinHeight;
				IL_273:
				size = this._ItemsPanel.FirstVisible.DesiredSize;
				return size.Height / 2.0;
				IL_2FC:
				return double.NaN;
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0005D6D4 File Offset: 0x0005B8D4
		private void InternalPopupOpened(object sender, global::System.EventArgs e)
		{
			short num = (short)388235264;
			short num2 = num;
			num = (short)775214721;
			short num3 = num;
			num = (short)596235905;
			switch (num3 == num)
			{
			}
			num = (short)475922433;
			if (num != 0)
			{
			}
			num = (short)309592064;
			if (num != 0)
			{
			}
			this.OnPopupOpened(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.NavigationPane.PopupOpenedEvent, this));
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0005D790 File Offset: 0x0005B990
		private void PopupToggleClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2058027017;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool? isChecked;
				bool flag;
				switch (num2)
				{
				case 0:
					num = (short)737345537;
					if (num != 0)
					{
					}
					this._Popup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Right;
					this._Popup.PlacementTarget = this._PopupToggle;
					num = (short)2102329349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_78;
				case 2:
					goto IL_29B;
				case 3:
				{
					num = (short)1639497201;
					short num3 = num;
					num = (short)297516529;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_29B;
					default:
					{
						num = (short)320077824;
						if (num != 0)
						{
						}
						num = (short)390201344;
						short num4 = num;
						if (this._ActualExpandedWidth != double.NaN)
						{
							num = (short)372441094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_78;
					}
					}
					break;
				}
				case 4:
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						num = (short)1203830784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32E;
				case 5:
					if (this.ExpandedWidth != double.NaN)
					{
						num = (short)1339293698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1083703299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this._Popup.Width = this._ActualExpandedWidth;
					num = (short)210305025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return;
				case 8:
					goto IL_78;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 10:
					if (!global::System.Windows.Input.Mouse.Capture(this, global::System.Windows.Input.CaptureMode.SubTree))
					{
						num = (short)1297022987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_283;
				case 11:
					goto IL_106;
				}
				IL_54:
				if (this._Popup == null)
				{
					num = (short)497614855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				isChecked = this._PopupToggle.IsChecked;
				flag = true;
				num = (short)1979056132;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_78:
				this._Popup.Height = this._PopupToggle.RenderSize.Height + this._ItemsPanel.RenderSize.Height - this._ItemsPanel.SmallItemsHeight + 16.0;
				this._Popup.IsOpen = true;
				num = (short)903479306;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_29B:
				this._Popup.Width = this.ExpandedWidth;
				num = (short)691011592;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_106:
			this._Popup.IsOpen = false;
			return;
			IL_283:
			this._Popup.Closed += this.InternalPopupClosed;
			return;
			IL_32E:
			this._Popup.IsOpen = false;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0005DAD8 File Offset: 0x0005BCD8
		private void InternalPopupClosed(object sender, global::System.EventArgs e)
		{
			short num = (short)1599078406;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this._Popup.Closed -= this.InternalPopupClosed;
					num = (short)98893825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_BC;
				case 2:
					if (this._Popup != null)
					{
						goto IL_1E7;
					}
					goto IL_BC;
				case 3:
					global::System.Windows.Input.Mouse.Capture(null);
					num = (short)659685381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1C4;
				case 5:
					goto IL_1C2;
				case 6:
				{
					num = (short)1881145344;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					continue;
				}
				case 7:
				{
					num = (short)1718752538;
					short num4 = num;
					num = (short)1662588186;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E7;
					default:
						num = (short)1178468352;
						if (num != 0)
						{
						}
						this._PopupToggle.IsChecked = new bool?(false);
						num = (short)1205141508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					if (base.IsMouseCaptured)
					{
						num = (short)1361641475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				}
				IL_72:
				num = (short)1045626881;
				if (num != 0)
				{
				}
				if (this._PopupToggle != null)
				{
					num = (short)1008926727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1C4;
				IL_BC:
				num = (short)1777729544;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C4:
				num = (short)559808514;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E7:
				num = (short)869335040;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1C2:
			IL_203:
			this.OnPopupClosed(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.NavigationPane.PopupClosedEvent, this));
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0005DCFC File Offset: 0x0005BEFC
		private bool IsPopupOpen
		{
			get
			{
				if (this._Popup == null)
				{
					short num = (short)744636355;
					short num2 = num;
					num = (short)1606172611;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)705363969;
						if (num != 0)
						{
						}
						num = (short)664993792;
						short num3 = num;
						num = (short)861929472;
						if (num != 0)
						{
						}
						return false;
					}
					}
				}
				return this._Popup.IsOpen;
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0005DDC0 File Offset: 0x0005BFC0
		private static void OnLostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1619107997;
			short num2 = num;
			num = (short)1594794141;
			switch (num2 == num)
			{
			}
			num = (short)282984448;
			short num3 = num;
			num = (short)786628608;
			if (num != 0)
			{
			}
			num = (short)221446145;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.NavigationPane)sender).SystemLostMouseCapture(e);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0005DE78 File Offset: 0x0005C078
		private void SystemLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1642987520;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1628278714;
				short num3 = num;
				num = (short)145067962;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_131;
				default:
					num = (short)199622656;
					if (num != 0)
					{
					}
					num = (short)215613441;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_CA;
						}
						continue;
					case 1:
						return;
					case 2:
						if (global::System.Windows.Input.Mouse.Captured != this)
						{
							num = (short)602210313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (this._ReTakeMouseCapture)
						{
							num = (short)1644429323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_188;
					case 4:
					{
						num = (short)1391460352;
						short num4 = num;
						num = (short)104136707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (global::System.Windows.Input.Mouse.Captured == null)
						{
							num = (short)902561796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_188;
					case 6:
						goto IL_1E3;
					case 7:
						if (global::System.Windows.Input.Mouse.Captured != null)
						{
							num = (short)213843980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4;
					case 8:
						goto IL_12F;
					case 9:
						num = (short)452395013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (this.IgnoreMouseCapture(global::System.Windows.Input.Mouse.Captured))
						{
							num = (short)740491272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4;
					case 11:
						goto IL_21F;
					case 12:
						num = (short)945094666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CA:
					if (!this.IsPopupOpen)
					{
						num = (short)1783627777;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					num = (short)167182338;
					num2 = (int)((global::System.IntPtr)num);
					break;
					IL_188:
					num = (short)1535377415;
					num2 = (int)((global::System.IntPtr)num);
					break;
					IL_1C4:
					this.ClosePopup();
					num = (short)724631558;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return;
			IL_12F:
			this._ReTakeMouseCapture = true;
			return;
			IL_131:
			global::System.Windows.Input.Mouse.Capture(this, global::System.Windows.Input.CaptureMode.SubTree);
			this._ReTakeMouseCapture = false;
			return;
			IL_1E3:
			return;
			IL_21F:
			goto IL_131;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0005E114 File Offset: 0x0005C314
		private bool IgnoreMouseCapture(global::System.Windows.IInputElement p)
		{
			int a_ = 6;
			short num = (short)842792960;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.UIElement uielement;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 1:
					if (uielement != null)
					{
						num = (short)1882980355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					return true;
				case 3:
					num = (short)395640840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1516961792;
					short num3 = num;
					num = (short)253362181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					if (global::DevComponents.WpfRibbon.ParentPopupControlImpl.IsChildOf(uielement, p as global::System.Windows.UIElement))
					{
						num = (short)915603462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					return true;
				case 7:
					num = (short)811925513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					if (!(p is global::System.Windows.UIElement))
					{
						return false;
					}
					num = (short)1610064768;
					short num4 = num;
					num = (short)1071162240;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)502530049;
						if (num != 0)
						{
						}
						num = (short)1719533568;
						if (num != 0)
						{
						}
						num = (short)619249668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					if (base.Items.Contains(p))
					{
						num = (short)222429186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EA;
				}
				IL_57:
				if (p is global::DevComponents.WpfRibbon.PaneItem)
				{
					num = (short)1581514759;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_EA:
				uielement = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("๝ཟቡᅣᙥ⩧թṫ੭ᕯq", a_)) as global::System.Windows.UIElement);
				num = (short)2001272833;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0005E350 File Offset: 0x0005C550
		protected override void OnPreviewMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)384696322;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_112;
				case 1:
				{
					global::System.Windows.Point position = e.GetPosition(this);
					global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
					num = (short)785383428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					num = (short)621127011;
					short num3 = num;
					num = (short)243967331;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_164;
					default:
					{
						num = (short)2108489728;
						if (num != 0)
						{
						}
						num = (short)613351424;
						short num4 = num;
						num = (short)426508289;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D6;
						}
						continue;
					}
					}
					break;
				}
				case 3:
					this.ClosePopup();
					num = (short)1934819328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::System.Windows.Point position;
					global::System.Windows.Rect rect;
					if (rect.Contains(position))
					{
						num = (short)1312161795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_164;
				}
				}
				IL_D6:
				if (!this.IsPopupOpen)
				{
					break;
				}
				num = (short)697368577;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_112:
			IL_164:
			base.OnPreviewMouseDown(e);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0005E4C8 File Offset: 0x0005C6C8
		private static void MouseDownOutsideCapturedElement(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1390870529;
			if (num != 0)
			{
			}
			num = (short)468463280;
			short num2 = num;
			num = (short)995569328;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1912864768;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1076035584;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.NavigationPane)sender).MouseDownOutsideCapturedElement(e);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0005E57C File Offset: 0x0005C77C
		private void MouseDownOutsideCapturedElement(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)477822977;
			if (num != 0)
			{
			}
			num = (short)801792808;
			short num2 = num;
			num = (short)1842570024;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AA:
				num = (short)165937154;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)199229440;
				if (num != 0)
				{
				}
				num = (short)1106771968;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A2;
					}
					continue;
				case 1:
					goto IL_DB;
				case 2:
					this.ClosePopup();
					num = (short)1492844545;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			IL_A2:
			if (this.IsPopupOpen)
			{
				goto IL_AA;
			}
			return;
			IL_DB:
			num = (short)393216;
			short num4 = num;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0005E690 File Offset: 0x0005C890
		public void ClosePopup()
		{
			short num;
			for (;;)
			{
				num = (short)810614784;
				short num2 = num;
				if (this._Popup != null)
				{
					goto IL_A7;
				}
				num = (short)863564480;
				short num3 = num;
				num = (short)1712648896;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_66;
				}
			}
			IL_66:
			num = (short)1716387840;
			if (num != 0)
			{
			}
			num = (short)1739128833;
			if (num != 0)
			{
			}
			return;
			IL_A7:
			this._Popup.IsOpen = false;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0005E750 File Offset: 0x0005C950
		protected override void OnInitialized(global::System.EventArgs e)
		{
			int a_ = 15;
			short num = (short)2029929239;
			short num2 = num;
			num = (short)521880343;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DA:
				num = (short)997720066;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_68;
			default:
			{
				num = (short)464650240;
				short num4 = num;
				goto IL_68;
			}
			}
			global::System.Reflection.PropertyInfo property;
			for (;;)
			{
				IL_87:
				switch (num3)
				{
				case 0:
					goto IL_D1;
				case 1:
					goto IL_13C;
				case 2:
					num = (short)172228609;
					if (num != 0)
					{
					}
					property.SetValue(this, false, null);
					num = (short)275382273;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_99;
			}
			IL_D1:
			if (property != null)
			{
				goto IL_DA;
			}
			IL_13C:
			base.ItemContainerGenerator.StatusChanged += this.OnGeneratorStatusChanged;
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfRibbon.NavigationPane.Collapse, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteCollapseCommand)));
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfRibbon.NavigationPane.Expand, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteExpandCommand)));
			return;
			IL_68:
			num = (short)1983119360;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_99;
			}
			goto IL_87;
			IL_99:
			base.OnInitialized(e);
			property = base.GetType().GetProperty(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⑦ࡨժ㹬੮ᵰᙲᙴͶ㑸๺ᅼ୾", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
			num = (short)747110400;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_87;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0005E8F8 File Offset: 0x0005CAF8
		private void ExecuteCollapseCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			short num = (short)1323530535;
			short num2 = num;
			num = (short)363559207;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DB:
				num = (short)2092892162;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)1484521472;
				short num4 = num;
				goto IL_5F;
			}
			}
			int selectedIndex;
			for (;;)
			{
				IL_A4:
				switch (num3)
				{
				case 0:
					goto IL_D3;
				case 1:
					goto IL_115;
				case 2:
					this.IsExpanded = false;
					base.SelectedIndex = selectedIndex;
					num = (short)788070401;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_B6;
			}
			IL_D3:
			if (this.IsExpanded)
			{
				goto IL_DB;
			}
			IL_115:
			e.Handled = true;
			return;
			IL_5F:
			num = (short)1130758144;
			if (num != 0)
			{
			}
			num = (short)1579286529;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_B6;
			}
			goto IL_A4;
			IL_B6:
			selectedIndex = base.SelectedIndex;
			num = (short)1758396416;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_A4;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0005EA24 File Offset: 0x0005CC24
		private void ExecuteExpandCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			short num = (short)1871342000;
			short num2 = num;
			num = (short)1280469424;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D8:
				num = (short)1871839234;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)1136394240;
				short num4 = num;
				goto IL_5D;
			}
			}
			int selectedIndex;
			for (;;)
			{
				IL_7C:
				switch (num3)
				{
				case 0:
					goto IL_D0;
				case 1:
					goto IL_115;
				case 2:
					this.IsExpanded = true;
					base.SelectedIndex = selectedIndex;
					num = (short)1069416449;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_8E;
			}
			IL_D0:
			if (!this.IsExpanded)
			{
				goto IL_D8;
			}
			IL_115:
			e.Handled = true;
			return;
			IL_5D:
			num = (short)1760100352;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_8E;
			}
			goto IL_7C;
			IL_8E:
			selectedIndex = base.SelectedIndex;
			num = (short)1849622529;
			if (num != 0)
			{
			}
			num = (short)131399680;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7C;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0005EB50 File Offset: 0x0005CD50
		private void OnGeneratorStatusChanged(object sender, global::System.EventArgs e)
		{
			short num = (short)1112866816;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 1:
				{
					num = (short)2069364737;
					if (num != 0)
					{
					}
					if (base.SelectedIndex >= 0)
					{
						goto IL_1A4;
					}
					num = (short)880158386;
					short num3 = num;
					num = (short)1575823026;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1648754688;
						if (num != 0)
						{
						}
						num = (short)1191510023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				case 3:
					if (base.HasItems)
					{
						num = (short)828637184;
						short num4 = num;
						num = (short)1431109638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A4;
				case 4:
					goto IL_1A4;
				case 5:
					num = (short)869990403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1207304193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					base.SelectedIndex = 0;
					num = (short)1559625732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_44:
				if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
				{
					num = (short)2131623941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1A4:
				this.UpdateItemsState();
				this.UpdateAllSelectedContent();
				num = (short)570228738;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0005ED28 File Offset: 0x0005CF28
		protected override void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			short num = (short)985202689;
			if (num != 0)
			{
			}
			num = (short)1920809467;
			short num2 = num;
			num = (short)1240742395;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1974140928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2045181952;
			if (num != 0)
			{
			}
			base.OnSelectionChanged(e);
			this.UpdateAllSelectedContent();
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0005EDE4 File Offset: 0x0005CFE4
		private void UpdateAllSelectedContent()
		{
			short num = (short)292543639;
			short num2 = num;
			num = (short)1516428439;
			switch (num2 == num)
			{
			}
			num = (short)1695678464;
			short num3 = num;
			num = (short)1305149440;
			if (num != 0)
			{
			}
			num = (short)1941962753;
			if (num != 0)
			{
			}
			this.UpdateSelectedHeader();
			this.UpdateSelectedContent();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0005EE9C File Offset: 0x0005D09C
		internal void UpdateSelectedContent()
		{
			short num = (short)1986854912;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Controls.HeaderedContentControl selectedItem;
			for (;;)
			{
				num = (short)913839283;
				short num3 = num;
				num = (short)2082411699;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1524957184;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 1:
						goto IL_C5;
					case 2:
						if (selectedItem != null)
						{
							num = (short)788725771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_1E6;
					case 4:
					{
						global::System.Windows.Controls.ContentPresenter selectedContentPresenter;
						if (selectedContentPresenter != null)
						{
							num = (short)1343160325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					}
					case 5:
					{
						num = (short)578420736;
						short num4 = num;
						global::System.Windows.Controls.ContentPresenter selectedContentPresenter;
						selectedContentPresenter.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
						selectedContentPresenter.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
						num = (short)1779105802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1197211649;
						if (num != 0)
						{
						}
						num = (short)1431240713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_12E;
					case 8:
						if (selectedItem.ContentTemplate == null)
						{
							num = (short)123142150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FA;
					case 9:
						if (selectedItem.ContentTemplateSelector != null)
						{
							num = (short)1507000327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.SelectedContentTemplate = this.ContentTemplate;
						this.SelectedContentTemplateSelector = this.ContentTemplateSelector;
						num = (short)1626603523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_133;
					case 11:
					{
						this.SelectedPaneItem = (selectedItem as global::DevComponents.WpfRibbon.PaneItem);
						this.SelectedContent = selectedItem.Content;
						global::System.Windows.Controls.ContentPresenter selectedContentPresenter = this.GetSelectedContentPresenter();
						num = (short)821952516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A2:
					if (base.SelectedIndex < 0)
					{
						num = (short)1308229633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					selectedItem = this.GetSelectedItem();
					num = (short)465567746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_133:
				num = (short)1534197768;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C5:
			this.SelectedContent = null;
			this.SelectedPaneItem = null;
			return;
			IL_12E:
			goto IL_1FA;
			IL_1E6:
			return;
			IL_1FA:
			this.SelectedContentTemplate = selectedItem.ContentTemplate;
			this.SelectedContentTemplateSelector = selectedItem.ContentTemplateSelector;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0005F168 File Offset: 0x0005D368
		internal global::System.Windows.Controls.ContentPresenter GetSelectedContentPresenter()
		{
			int a_ = 8;
			short num = (short)1249705985;
			if (num != 0)
			{
			}
			num = (short)2027106966;
			short num2 = num;
			num = (short)756757142;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1988558848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)996147200;
			if (num != 0)
			{
			}
			return base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("た⍡㙣㉥㝧㩩൫mᕯㅱ᭳ᡵ౷όቻ੽졿", a_)) as global::System.Windows.Controls.ContentPresenter;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0005F234 File Offset: 0x0005D434
		internal void UpdateSelectedHeader()
		{
			int a_ = 0;
			short num = (short)633995265;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Controls.HeaderedContentControl selectedItem;
				global::DevComponents.WpfRibbon.PaneItem paneItem;
				switch (num2)
				{
				case 0:
					if (selectedItem != null)
					{
						num = (short)1442119681;
						if (num != 0)
						{
						}
						num = (short)1083768840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_76;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 2:
					goto IL_16A;
				case 3:
					this.SelectedContentHeader = paneItem.Title;
					num = (short)1324154882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)416415744;
					short num3 = num;
					if (selectedItem != null)
					{
						num = (short)1078657029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 5:
					num = (short)709427207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1083822540;
					short num4 = num;
					num = (short)1584583116;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1A5;
					}
					break;
				}
				case 7:
					if (paneItem.Title != null)
					{
						num = (short)222298115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					try
					{
						this.SelectedContentHeader = global::DevComponents.WpfRibbon.CloningMachine.GetObjectCopy(selectedItem.Header, false);
						goto IL_76;
					}
					catch
					{
						string str = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᭗㭙㉛そཟᙡ䑣եѧթɫ୭偯ٱᱳ፵塷ᕹṻᑽꚅ몓뚕킗ﾙﶛ瞧얟킡麣蚥", a_);
						object header = selectedItem.Header;
						global::System.Diagnostics.Trace.WriteLine(str + ((header != null) ? header.ToString() : null));
						goto IL_76;
					}
					return;
				}
				IL_51:
				if (base.SelectedIndex < 0)
				{
					num = (short)58785798;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				selectedItem = this.GetSelectedItem();
				num = (short)1256456192;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_76:
				paneItem = (selectedItem as global::DevComponents.WpfRibbon.PaneItem);
				num = (short)2011496452;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_16A:
			return;
			IL_1A5:
			num = (short)1018167296;
			if (num != 0)
			{
			}
			this.SelectedContentHeader = null;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0005F49C File Offset: 0x0005D69C
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x0005F554 File Offset: 0x0005D754
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::DevComponents.WpfRibbon.PaneItem SelectedPaneItem
		{
			get
			{
				short num = (short)1043477111;
				short num2 = num;
				num = (short)1393570423;
				switch (num2 == num)
				{
				}
				num = (short)1564409856;
				short num3 = num;
				num = (short)1152516097;
				if (num != 0)
				{
				}
				num = (short)779550720;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.PaneItem)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedPaneItemProperty);
			}
			internal set
			{
				short num = (short)696682039;
				short num2 = num;
				num = (short)1474004535;
				switch (num2 == num)
				{
				}
				num = (short)61341696;
				short num3 = num;
				num = (short)544407553;
				if (num != 0)
				{
				}
				num = (short)859111424;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedPaneItemPropertyKey, value);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0005F608 File Offset: 0x0005D808
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x0005F6BC File Offset: 0x0005D8BC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object SelectedContent
		{
			get
			{
				short num = (short)1217086097;
				short num2 = num;
				num = (short)128795281;
				switch (num2 == num)
				{
				}
				num = (short)1756889088;
				short num3 = num;
				num = (short)1338179585;
				if (num != 0)
				{
				}
				num = (short)141492224;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedContentProperty);
			}
			internal set
			{
				short num = (short)1629302011;
				short num2 = num;
				num = (short)2084908283;
				switch (num2 == num)
				{
				}
				num = (short)839647232;
				short num3 = num;
				num = (short)519372801;
				if (num != 0)
				{
				}
				num = (short)792592384;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedContentPropertyKey, value);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0005F774 File Offset: 0x0005D974
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x0005F82C File Offset: 0x0005DA2C
		public global::System.Windows.DataTemplate SelectedContentHeaderTemplate
		{
			get
			{
				short num = (short)1867732169;
				short num2 = num;
				num = (short)1856394441;
				switch (num2 == num)
				{
				}
				num = (short)910491648;
				short num3 = num;
				num = (short)1540620288;
				if (num != 0)
				{
				}
				num = (short)68222977;
				if (num != 0)
				{
				}
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedContentHeaderTemplateProperty);
			}
			set
			{
				short num = (short)1763481813;
				short num2 = num;
				num = (short)2067372245;
				switch (num2 == num)
				{
				}
				num = (short)774242304;
				short num3 = num;
				num = (short)701956097;
				if (num != 0)
				{
				}
				num = (short)548274176;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedContentHeaderTemplateProperty, value);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x0005F998 File Offset: 0x0005DB98
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.DataTemplate SelectedContentTemplate
		{
			get
			{
				short num = (short)902789172;
				short num2 = num;
				num = (short)1181251636;
				switch (num2 == num)
				{
				}
				num = (short)1652162560;
				short num3 = num;
				num = (short)1357316097;
				if (num != 0)
				{
				}
				num = (short)612237312;
				if (num != 0)
				{
				}
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedContentTemplateProperty);
			}
			internal set
			{
				short num = (short)1972917042;
				short num2 = num;
				num = (short)1985958706;
				switch (num2 == num)
				{
				}
				num = (short)525467648;
				short num3 = num;
				num = (short)1409679360;
				if (num != 0)
				{
				}
				num = (short)1119682561;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedContentTemplatePropertyKey, value);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0005FA4C File Offset: 0x0005DC4C
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x0005FB04 File Offset: 0x0005DD04
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Controls.DataTemplateSelector SelectedContentTemplateSelector
		{
			get
			{
				short num = (short)983309523;
				short num2 = num;
				num = (short)544283859;
				switch (num2 == num)
				{
				}
				num = (short)207093760;
				short num3 = num;
				num = (short)284229632;
				if (num != 0)
				{
				}
				num = (short)1224212481;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedContentTemplateSelectorProperty);
			}
			internal set
			{
				short num = (short)1572285302;
				short num2 = num;
				num = (short)1610165110;
				switch (num2 == num)
				{
				}
				num = (short)474349568;
				short num3 = num;
				num = (short)697040897;
				if (num != 0)
				{
				}
				num = (short)649789440;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedContentTemplateSelectorPropertyKey, value);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0005FBBC File Offset: 0x0005DDBC
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x0005FC70 File Offset: 0x0005DE70
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object SelectedContentHeader
		{
			get
			{
				short num = (short)1910374400;
				short num2 = num;
				num = (short)212246231;
				short num3 = num;
				num = (short)1380097751;
				switch (num3 == num)
				{
				}
				num = (short)2007105536;
				if (num != 0)
				{
				}
				num = (short)429916161;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedContentHeaderProperty);
			}
			internal set
			{
				short num = (short)1090519040;
				short num2 = num;
				num = (short)1375218850;
				short num3 = num;
				num = (short)1177496738;
				switch (num3 == num)
				{
				}
				num = (short)1293484032;
				if (num != 0)
				{
				}
				num = (short)97517569;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.SelectedContentHeaderPropertyKey, value);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0005FD24 File Offset: 0x0005DF24
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x0005FDDC File Offset: 0x0005DFDC
		public global::System.Windows.DataTemplate ContentTemplate
		{
			get
			{
				short num = (short)1137442816;
				short num2 = num;
				num = (short)299437678;
				short num3 = num;
				num = (short)1718423150;
				switch (num3 == num)
				{
				}
				num = (short)1933967361;
				if (num != 0)
				{
				}
				num = (short)542900224;
				if (num != 0)
				{
				}
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.ContentTemplateProperty);
			}
			set
			{
				short num = (short)1046216704;
				short num2 = num;
				num = (short)864934006;
				short num3 = num;
				num = (short)1129830518;
				switch (num3 == num)
				{
				}
				num = (short)1121386496;
				if (num != 0)
				{
				}
				num = (short)959119361;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.ContentTemplateProperty, value);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0005FE90 File Offset: 0x0005E090
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x0005FF4C File Offset: 0x0005E14C
		public global::System.Windows.Controls.DataTemplateSelector ContentTemplateSelector
		{
			get
			{
				short num = (short)1702100992;
				short num2 = num;
				num = (short)261854627;
				short num3 = num;
				num = (short)1310692771;
				switch (num3 == num)
				{
				}
				num = (short)695336960;
				if (num != 0)
				{
				}
				num = (short)358350849;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.ContentTemplateSelectorProperty);
			}
			set
			{
				short num = (short)517865472;
				short num2 = num;
				num = (short)997807189;
				short num3 = num;
				num = (short)1359172693;
				switch (num3 == num)
				{
				}
				num = (short)1244528641;
				if (num != 0)
				{
				}
				num = (short)1738801152;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.ContentTemplateSelectorProperty, value);
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00060000 File Offset: 0x0005E200
		private global::System.Windows.Controls.HeaderedContentControl GetSelectedItem()
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num3;
			global::System.Windows.Controls.HeaderedContentControl headeredContentControl;
			for (;;)
			{
				IL_0A:
				num = (short)466550784;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (headeredContentControl == null)
					{
						num = (short)1742995459;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return headeredContentControl;
				case 1:
					goto IL_14A;
				case 2:
				{
					num = (short)1763227325;
					short num4 = num;
					num = (short)1746581181;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14A;
					default:
						num = (short)1404895232;
						if (num != 0)
						{
						}
						headeredContentControl = (base.ItemContainerGenerator.ContainerFromItem(base.SelectedItem) as global::System.Windows.Controls.HeaderedContentControl);
						num = (short)1790443524;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					num = (short)555286529;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_107;
				}
				goto IL_4D;
				IL_14A:
				if (base.SelectedItem == null)
				{
					return headeredContentControl;
				}
				num = (short)656605186;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_107:
			num = (short)1053622273;
			if (num != 0)
			{
			}
			return headeredContentControl;
			IL_4D:
			headeredContentControl = (base.SelectedItem as global::System.Windows.Controls.HeaderedContentControl);
			num = (short)1992032256;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0006017C File Offset: 0x0005E37C
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)821952514;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					num = (short)519766017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
					{
						num = (short)282001412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38F;
				case 2:
				{
					num = (short)1389363200;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					continue;
				}
				case 3:
					try
					{
						num = (short)929497091;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1DB;
							case 1:
								num = (short)926154761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)198901766;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_DC;
								}
								continue;
							case 4:
							{
								object obj;
								if (obj is global::System.Windows.UIElement)
								{
									num = (short)1205534721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								base.SelectedItem = obj;
								num = (short)1071382533;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_FB;
							case 6:
								goto IL_1F8;
							case 7:
							{
								object obj;
								base.SelectedItem = obj;
								num = (short)970260480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1410203650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj = enumerator.Current;
								num = (short)136773636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
							{
								object obj;
								if ((obj as global::System.Windows.UIElement).Visibility == global::System.Windows.Visibility.Visible)
								{
									num = (short)1846280199;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_100:
							num = (short)1555824648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_DC:
							goto IL_100;
						}
						IL_FB:
						IL_1DB:
						IL_1F8:
						goto IL_38F;
					}
					finally
					{
						global::System.IDisposable disposable;
						switch (0)
						{
						case 0:
							break;
						default:
						{
							for (;;)
							{
								IL_207:
								switch (num2)
								{
								case 0:
									goto IL_26C;
								case 1:
									if (disposable != null)
									{
										num = (short)788463618;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BB;
								case 2:
									disposable.Dispose();
									num = (short)2021261312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_219;
							}
							IL_26C:
							num = (short)218396365;
							short num4 = num;
							num = (short)1677555405;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_220;
							default:
								num = (short)1460797440;
								if (num != 0)
								{
								}
								break;
							}
							IL_2BB:
							goto EndFinally_10;
						}
						}
						IL_219:
						disposable = (enumerator as global::System.IDisposable);
						IL_220:
						num = (short)587137025;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_207;
						EndFinally_10:;
					}
					goto IL_2BC;
				case 4:
					goto IL_2BC;
				case 5:
					num = (short)1522073601;
					if (num != 0)
					{
					}
					num = (short)435814406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (base.Items.Count > 0)
					{
						num = (short)383057920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38F;
				}
				IL_6A:
				if (base.SelectedIndex == -1)
				{
					num = (short)1529085957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2BC:
				enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
				num = (short)1955659779;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_38F:
			this.UpdateItemsState();
			base.OnItemsChanged(e);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00060544 File Offset: 0x0005E744
		internal void UpdateItemsState()
		{
			short num = (short)1175584768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				int num4;
				int num5;
				bool isExpanded;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)571867136;
						short num3 = num;
						num = (short)388890626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_139;
					case 2:
					{
						if (num4 > 0)
						{
							num = (short)1256521740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfRibbon.PaneItem paneItem;
						paneItem.SmallState = true;
						num = (short)1000472593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						if (num5 >= base.Items.Count)
						{
							num = (short)1231618062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfRibbon.PaneItem paneItem = base.Items[num5] as global::DevComponents.WpfRibbon.PaneItem;
						num = (short)278593541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::DevComponents.WpfRibbon.PaneItem paneItem;
						if (paneItem.PaneExpanded != isExpanded)
						{
							num = (short)601554950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C8;
					}
					case 5:
					{
						global::DevComponents.WpfRibbon.PaneItem paneItem;
						if (paneItem == null)
						{
							num = (short)2099576833;
							if (num != 0)
							{
							}
							num = (short)234291207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_261;
					}
					case 6:
					{
						global::DevComponents.WpfRibbon.PaneItem paneItem;
						paneItem.PaneExpanded = isExpanded;
						num = (short)675348495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::DevComponents.WpfRibbon.PaneItem paneItem = base.ItemContainerGenerator.ContainerFromIndex(num5) as global::DevComponents.WpfRibbon.PaneItem;
						num = (short)1626996752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::DevComponents.WpfRibbon.PaneItem paneItem;
						if (paneItem != null)
						{
							num = (short)1523908619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139;
					}
					case 9:
						goto IL_1F7;
					case 10:
						goto IL_1F7;
					case 11:
						goto IL_351;
					case 12:
					{
						num = (short)2026310386;
						short num6 = num;
						num = (short)1265830642;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_351;
						default:
						{
							num = (short)433848320;
							if (num != 0)
							{
							}
							global::DevComponents.WpfRibbon.PaneItem paneItem;
							paneItem.SmallState = false;
							num4--;
							num = (short)1000865793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 13:
					{
						global::DevComponents.WpfRibbon.PaneItem paneItem;
						if (paneItem.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)2024734720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139;
					}
					case 14:
						return;
					case 15:
						goto IL_C8;
					case 16:
						goto IL_261;
					case 17:
						goto IL_139;
					}
					goto IL_76;
					IL_C8:
					num = (short)1893597197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_139:
					num5++;
					num = (short)220332041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F7:
					num = (short)110690307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_261:
					num = (short)490274824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_351:
					num = (short)1327562756;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_76:
				num4 = this.LargeItemsCount;
				isExpanded = this.IsExpanded;
				num5 = 0;
				num = (short)2055733258;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000608E8 File Offset: 0x0005EAE8
		private static void IsExpandedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)433324032;
			short num2 = num;
			num = (short)1280998099;
			short num3 = num;
			num = (short)2011134675;
			switch (num3 == num)
			{
			}
			num = (short)698482689;
			if (num != 0)
			{
			}
			num = (short)746913792;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.NavigationPane)d).IsExpandedChanged(e);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0006099C File Offset: 0x0005EB9C
		private void IsExpandedChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1057816578;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F0;
				case 1:
					goto IL_139;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					num = (short)931921921;
					if (num != 0)
					{
					}
					base.Width = this.ExpandedWidth;
					this.ExpandedWidth = double.NaN;
					this.OnExpanded(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.NavigationPane.ExpandedEvent, this));
					num = (short)641466369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				if (this.IsExpanded)
				{
					num = (short)1065156611;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.ExpandedWidth = base.Width;
					this._ActualExpandedWidth = base.ActualWidth;
					base.Width = this.CollapsedWidth;
					this.OnCollapsed(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.NavigationPane.CollapsedEvent, this));
					num = (short)812908544;
					short num3 = num;
					num = (short)2024013824;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_F0:
			goto IL_187;
			IL_139:
			num = (short)1974947961;
			short num4 = num;
			num = (short)1061310585;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1466957824;
				if (num != 0)
				{
				}
				break;
			}
			IL_187:
			this.UpdateItemsState();
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00060B38 File Offset: 0x0005ED38
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00060BF0 File Offset: 0x0005EDF0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public double ExpandedWidth
		{
			get
			{
				short num = (short)1102708736;
				short num2 = num;
				num = (short)931345835;
				short num3 = num;
				num = (short)1109865899;
				switch (num3 == num)
				{
				}
				num = (short)1094123520;
				if (num != 0)
				{
				}
				num = (short)585039873;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.ExpandedWidthProperty);
			}
			set
			{
				short num = (short)1925971968;
				short num2 = num;
				num = (short)1250530001;
				short num3 = num;
				num = (short)1753453265;
				switch (num3 == num)
				{
				}
				num = (short)1950023680;
				if (num != 0)
				{
				}
				num = (short)1518338049;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.ExpandedWidthProperty, value);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00060CAC File Offset: 0x0005EEAC
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00060D64 File Offset: 0x0005EF64
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public double CollapsedWidth
		{
			get
			{
				short num = (short)2025783296;
				short num2 = num;
				num = (short)1455947258;
				short num3 = num;
				num = (short)134872570;
				switch (num3 == num)
				{
				}
				num = (short)312934401;
				if (num != 0)
				{
				}
				num = (short)1744961536;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.CollapsedWidthProperty);
			}
			set
			{
				short num = (short)604700672;
				short num2 = num;
				num = (short)1746422442;
				short num3 = num;
				num = (short)2023574186;
				switch (num3 == num)
				{
				}
				num = (short)2062680064;
				if (num != 0)
				{
				}
				num = (short)2019753985;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.CollapsedWidthProperty, value);
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00060E1C File Offset: 0x0005F01C
		private static void LargeItemsCountChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)59572224;
			short num2 = num;
			num = (short)1926477586;
			short num3 = num;
			num = (short)384415506;
			switch (num3 == num)
			{
			}
			num = (short)20447233;
			if (num != 0)
			{
			}
			num = (short)701169664;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.NavigationPane)d).LargeItemsCountChanged(e);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00060ED0 File Offset: 0x0005F0D0
		private void LargeItemsCountChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)514588672;
			short num2 = num;
			num = (short)1408487499;
			short num3 = num;
			num = (short)802738251;
			switch (num3 == num)
			{
			}
			num = (short)1036779521;
			if (num != 0)
			{
			}
			num = (short)308150272;
			if (num != 0)
			{
			}
			this.UpdateItemsState();
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00060F84 File Offset: 0x0005F184
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00061044 File Offset: 0x0005F244
		[global::System.ComponentModel.Bindable(true)]
		public int LargeItemsCount
		{
			get
			{
				short num = (short)587857920;
				short num2 = num;
				num = (short)2027841433;
				short num3 = num;
				num = (short)1811769241;
				switch (num3 == num)
				{
				}
				num = (short)1143209984;
				if (num != 0)
				{
				}
				num = (short)1086324737;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.LargeItemsCountProperty);
			}
			set
			{
				short num = (short)1894776832;
				short num2 = num;
				num = (short)2019230299;
				short num3 = num;
				num = (short)2104230491;
				switch (num3 == num)
				{
				}
				num = (short)198574080;
				if (num != 0)
				{
				}
				num = (short)1838284801;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.LargeItemsCountProperty, value);
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x000610FC File Offset: 0x0005F2FC
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			short num = (short)2014642176;
			short num2 = num;
			num = (short)859475984;
			short num3 = num;
			num = (short)910921744;
			switch (num3 == num)
			{
			}
			num = (short)310706177;
			if (num != 0)
			{
			}
			num = (short)89718784;
			if (num != 0)
			{
			}
			return item is global::DevComponents.WpfRibbon.PaneItem;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000611B4 File Offset: 0x0005F3B4
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			short num = (short)196149248;
			short num2 = num;
			num = (short)1207989139;
			short num3 = num;
			num = (short)1844409235;
			switch (num3 == num)
			{
			}
			num = (short)2106785793;
			if (num != 0)
			{
			}
			num = (short)1135673344;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfRibbon.PaneItem();
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00061264 File Offset: 0x0005F464
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x0006131C File Offset: 0x0005F51C
		[global::System.ComponentModel.Bindable(true)]
		public bool IsExpanded
		{
			get
			{
				short num = (short)1936392192;
				short num2 = num;
				num = (short)1379820350;
				short num3 = num;
				num = (short)471229246;
				switch (num3 == num)
				{
				}
				num = (short)1794506753;
				if (num != 0)
				{
				}
				num = (short)2002059264;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.IsExpandedProperty);
			}
			set
			{
				short num = (short)401801216;
				short num2 = num;
				num = (short)888406017;
				if (num != 0)
				{
				}
				num = (short)1711281639;
				short num3 = num;
				num = (short)1488852455;
				switch (num3 == num)
				{
				}
				num = (short)2010578944;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.IsExpandedProperty, value);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000613D8 File Offset: 0x0005F5D8
		public void ShowOptionsDialog()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::System.Windows.RoutedEventArgs routedEventArgs;
			global::DevComponents.WpfRibbon.NavigationPaneCustomizeDialog navigationPaneCustomizeDialog;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_A2;
				case 1:
					goto IL_150;
				case 2:
				{
					if (global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
					{
						num2 = (short)726728708;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
					num2 = (short)1243217926;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (!routedEventArgs.Handled)
					{
						navigationPaneCustomizeDialog = new global::DevComponents.WpfRibbon.NavigationPaneCustomizeDialog();
						navigationPaneCustomizeDialog.Initialize(this);
						num2 = (short)1455858607;
						short num3 = num2;
						num2 = (short)954770351;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)854392832;
							if (num2 != 0)
							{
							}
							num2 = (short)894697474;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
					}
					num2 = (short)256376832;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					navigationPaneCustomizeDialog.WindowStartupLocation = global::System.Windows.WindowStartupLocation.CenterScreen;
					num2 = (short)1891565573;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_12B;
				case 6:
				{
					global::System.Windows.Window window;
					if (window != null)
					{
						num2 = (short)1026621447;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1EB;
				}
				case 7:
				{
					global::System.Windows.Window window;
					navigationPaneCustomizeDialog.Owner = window;
					num2 = (short)418381825;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_30;
			}
			IL_A2:
			num2 = (short)1361641472;
			short num4 = num2;
			return;
			IL_12B:
			IL_150:
			IL_1EB:
			navigationPaneCustomizeDialog.ShowDialog();
			return;
			IL_30:
			num2 = (short)1826881537;
			if (num2 != 0)
			{
			}
			routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.NavigationPane.BeforeCustomizeDialogEvent, this);
			this.OnBeforeCustomizeDialogEvent(routedEventArgs);
			num2 = (short)925761539;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000615D8 File Offset: 0x0005F7D8
		internal void ItemVisibilityChanged(global::DevComponents.WpfRibbon.PaneItem paneItem)
		{
			short num = (short)1457651712;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
					if (paneItem.Visibility != global::System.Windows.Visibility.Visible)
					{
						num = (short)1377173506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B4;
				case 2:
					goto IL_200;
				case 3:
					goto IL_251;
				case 4:
					try
					{
						num = (short)1098645509;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)95158279;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_138;
							case 2:
							{
								global::DevComponents.WpfRibbon.PaneItem paneItem2;
								if (paneItem2 != null)
								{
									num = (short)1567948804;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1537015808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::DevComponents.WpfRibbon.PaneItem paneItem2 = enumerator.Current as global::DevComponents.WpfRibbon.PaneItem;
								num = (short)755302402;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1619197958;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_A6;
								}
								continue;
							case 6:
							{
								global::DevComponents.WpfRibbon.PaneItem paneItem2;
								if (paneItem2.Visibility == global::System.Windows.Visibility.Visible)
								{
									num = (short)1772617736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
								goto IL_18D;
							case 8:
							{
								global::DevComponents.WpfRibbon.PaneItem paneItem2;
								paneItem2.IsSelected = true;
								num = (short)154206209;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_E3:
							num = (short)645136387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A6:
							goto IL_E3;
						}
						IL_138:
						IL_18D:
						goto IL_2B4;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1AE;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_19C:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)443351041;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1FF;
							case 1:
								disposable.Dispose();
								num = (short)1396899842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1FD;
							}
							goto IL_1AE;
						}
						IL_1FD:
						IL_1FF:
						goto EndFinally_9;
						IL_1AE:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1371275264;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_19C;
						EndFinally_9:;
					}
					goto IL_200;
				}
				IL_39:
				if (paneItem.IsSelected)
				{
					num = (short)79822851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2B4;
				IL_200:
				enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
				num = (short)314114048;
				short num3 = num;
				num = (short)2115239940;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_251:
				num = (short)2125922305;
				if (num != 0)
				{
				}
				num = (short)995098625;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B4:
				num = (short)560941092;
				short num4 = num;
				num = (short)1876445220;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_251;
				default:
					goto IL_2E8;
				}
			}
			IL_2E8:
			num = (short)1878654976;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00061900 File Offset: 0x0005FB00
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x000619BC File Offset: 0x0005FBBC
		public global::DevComponents.WpfRibbon.NavigationPaneLocalization SystemText
		{
			get
			{
				short num = (short)2059882569;
				short num2 = num;
				num = (short)1631211593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1182400512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)217513984;
				if (num != 0)
				{
				}
				num = (short)534642689;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.NavigationPaneLocalization)base.GetValue(global::DevComponents.WpfRibbon.NavigationPane.SystemTextProperty);
			}
			internal set
			{
				short num = (short)889027423;
				short num2 = num;
				num = (short)1690598239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1696989184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)84606977;
				if (num != 0)
				{
				}
				num = (short)48103424;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPane.SystemTextPropertyKey, value);
			}
		}

		// Token: 0x040001FD RID: 509
		private const string PartPaneContentPresenter = "PART_PaneContentHost";

		// Token: 0x040001FE RID: 510
		private const string PartItemsPanel = "PART_ItemPanel";

		// Token: 0x040001FF RID: 511
		private const string PartPopup = "PART_Popup";

		// Token: 0x04000200 RID: 512
		private const string PartPopupToggle = "PART_PopupToggle";

		// Token: 0x04000201 RID: 513
		private global::DevComponents.WpfRibbon.NavigationPanePanel _ItemsPanel;

		// Token: 0x04000202 RID: 514
		private global::System.Windows.Controls.Primitives.Popup _Popup;

		// Token: 0x04000203 RID: 515
		private global::System.Windows.Controls.Primitives.ToggleButton _PopupToggle;

		// Token: 0x04000204 RID: 516
		public static global::System.Windows.Input.RoutedCommand Collapse;

		// Token: 0x04000205 RID: 517
		public static global::System.Windows.Input.RoutedCommand Expand;

		// Token: 0x04000206 RID: 518
		public static readonly global::System.Windows.DependencyProperty SelectedContentProperty;

		// Token: 0x04000207 RID: 519
		private static readonly global::System.Windows.DependencyPropertyKey SelectedContentPropertyKey;

		// Token: 0x04000208 RID: 520
		public static readonly global::System.Windows.DependencyProperty SelectedPaneItemProperty;

		// Token: 0x04000209 RID: 521
		private static readonly global::System.Windows.DependencyPropertyKey SelectedPaneItemPropertyKey;

		// Token: 0x0400020A RID: 522
		public static readonly global::System.Windows.DependencyProperty SelectedContentTemplateProperty;

		// Token: 0x0400020B RID: 523
		private static readonly global::System.Windows.DependencyPropertyKey SelectedContentTemplatePropertyKey;

		// Token: 0x0400020C RID: 524
		public static readonly global::System.Windows.DependencyProperty SelectedContentTemplateSelectorProperty;

		// Token: 0x0400020D RID: 525
		private static readonly global::System.Windows.DependencyPropertyKey SelectedContentTemplateSelectorPropertyKey;

		// Token: 0x0400020E RID: 526
		public static readonly global::System.Windows.DependencyProperty SelectedContentHeaderProperty;

		// Token: 0x0400020F RID: 527
		private static readonly global::System.Windows.DependencyPropertyKey SelectedContentHeaderPropertyKey;

		// Token: 0x04000210 RID: 528
		public static readonly global::System.Windows.DependencyProperty ContentTemplateSelectorProperty;

		// Token: 0x04000211 RID: 529
		public static readonly global::System.Windows.DependencyProperty ContentTemplateProperty;

		// Token: 0x04000212 RID: 530
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty;

		// Token: 0x04000213 RID: 531
		public static readonly global::System.Windows.DependencyProperty LargeItemsCountProperty;

		// Token: 0x04000214 RID: 532
		public static readonly global::System.Windows.DependencyProperty SystemTextProperty;

		// Token: 0x04000215 RID: 533
		private static readonly global::System.Windows.DependencyPropertyKey SystemTextPropertyKey;

		// Token: 0x04000216 RID: 534
		public static readonly global::System.Windows.DependencyProperty ExpandedWidthProperty;

		// Token: 0x04000217 RID: 535
		public static readonly global::System.Windows.DependencyProperty CollapsedWidthProperty;

		// Token: 0x0400021D RID: 541
		public static readonly global::System.Windows.DependencyProperty LicenseKeyProperty;

		// Token: 0x0400021E RID: 542
		private bool _ReTakeMouseCapture;

		// Token: 0x0400021F RID: 543
		public static readonly global::System.Windows.DependencyProperty SelectedContentHeaderTemplateProperty;

		// Token: 0x04000220 RID: 544
		private double _ActualExpandedWidth = double.NaN;

		// Token: 0x04000221 RID: 545
		public static readonly string SystemShowMoreButtonsMenuItem;

		// Token: 0x04000222 RID: 546
		public static readonly string SystemShowFewerButtonsMenuItem;

		// Token: 0x04000223 RID: 547
		public static readonly string SystemNavPaneOptionMenuItem;

		// Token: 0x04000224 RID: 548
		public static readonly string SystemAddRemoveMenuItem;
	}
}
