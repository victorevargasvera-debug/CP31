using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000073 RID: 115
	[global::System.Windows.TemplatePart(Name = "PART_RibbonBarBorder", Type = typeof(global::System.Windows.Controls.Decorator))]
	public class RibbonBar : global::DevComponents.WpfRibbon.HeaderedPopupControl
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00096424 File Offset: 0x00094624
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x000964DC File Offset: 0x000946DC
		public global::DevComponents.WpfRibbon.eRibbonVisualStyle VisualStyle
		{
			get
			{
				short num = (short)1856903623;
				short num2 = num;
				num = (short)1082530247;
				switch (num2 == num)
				{
				}
				num = (short)1917059073;
				if (num != 0)
				{
				}
				num = (short)838205440;
				if (num != 0)
				{
				}
				num = (short)1813643264;
				short num3 = num;
				return (global::DevComponents.WpfRibbon.eRibbonVisualStyle)base.GetValue(global::DevComponents.WpfRibbon.RibbonBar.VisualStyleProperty);
			}
			set
			{
				short num = (short)1124825753;
				short num2 = num;
				num = (short)1754495641;
				switch (num2 == num)
				{
				}
				num = (short)9633793;
				if (num != 0)
				{
				}
				num = (short)115081216;
				if (num != 0)
				{
				}
				num = (short)962854912;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBar.VisualStyleProperty, value);
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00096598 File Offset: 0x00094798
		private static void OnVisualStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)456886672;
			short num2 = num;
			num = (short)1242663312;
			switch (num2 == num)
			{
			}
			num = (short)1592786945;
			if (num != 0)
			{
			}
			num = (short)376111104;
			if (num != 0)
			{
			}
			num = (short)1839988736;
			short num3 = num;
			((global::DevComponents.WpfRibbon.RibbonBar)o).OnVisualStyleChanged((global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.OldValue, (global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.NewValue);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00096664 File Offset: 0x00094864
		private void OnVisualStyleChanged(global::DevComponents.WpfRibbon.eRibbonVisualStyle oldValue, global::DevComponents.WpfRibbon.eRibbonVisualStyle newValue)
		{
			short num = (short)1643691651;
			short num2 = num;
			num = (short)733003395;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_89:
				switch (0)
				{
				case 0:
					goto IL_DA;
				}
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)1956904960;
				short num3 = num;
				goto IL_5F;
			}
			}
			int num4;
			for (;;)
			{
				IL_93:
				num = (short)1965555713;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_89;
				case 1:
					num = (short)231079941;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (newValue != global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Blue)
					{
						num = (short)1321598977;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F4;
				case 3:
					num = (short)1838219266;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_12C;
				case 5:
					if (newValue == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Black)
					{
						num = (short)1100283908;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_166;
				}
				goto IL_DA;
			}
			IL_12C:
			goto IL_F4;
			IL_166:
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007;
			return;
			IL_5F:
			num = (short)1643905024;
			if (num != 0)
			{
			}
			num = (short)529596416;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_93;
			IL_DA:
			if (newValue != global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Silver)
			{
				num = (short)1327235075;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_93;
			}
			IL_F4:
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x000967E0 File Offset: 0x000949E0
		private bool IsDesignMode
		{
			get
			{
				short num = (short)1205661561;
				short num2 = num;
				num = (short)973336441;
				switch (num2 == num)
				{
				}
				num = (short)1400242176;
				if (num != 0)
				{
				}
				num = (short)2066612225;
				if (num != 0)
				{
				}
				num = (short)619905024;
				short num3 = num;
				return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00096890 File Offset: 0x00094A90
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x0009694C File Offset: 0x00094B4C
		public global::DevComponents.WpfRibbon.eEffectiveStyle EffectiveStyle
		{
			get
			{
				short num = (short)1699542258;
				short num2 = num;
				num = (short)1965356274;
				switch (num2 == num)
				{
				}
				num = (short)474742785;
				if (num != 0)
				{
				}
				num = (short)409600000;
				if (num != 0)
				{
				}
				num = (short)917504;
				short num3 = num;
				return (global::DevComponents.WpfRibbon.eEffectiveStyle)base.GetValue(global::DevComponents.WpfRibbon.RibbonBar.EffectiveStyleProperty);
			}
			internal set
			{
				short num = (short)217367599;
				short num2 = num;
				num = (short)1540998191;
				switch (num2 == num)
				{
				}
				num = (short)888864769;
				if (num != 0)
				{
				}
				num = (short)348848128;
				if (num != 0)
				{
				}
				num = (short)821035008;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBar.EffectiveStylePropertyKey, value);
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00096A04 File Offset: 0x00094C04
		private static void OnEffectiveStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1661337600;
			short num2 = num;
			num = (short)849692821;
			short num3 = num;
			num = (short)854542485;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_10A:
				num = (short)315293697;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2004942848;
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
			global::DevComponents.WpfRibbon.RibbonBar ribbonBar;
			for (;;)
			{
				IL_7E:
				switch (num4)
				{
				case 0:
					if (ribbonBar != null)
					{
						num = (short)1013121025;
						if (num != 0)
						{
						}
						num = (short)268763138;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					goto IL_EA;
				}
				goto IL_90;
			}
			IL_EA:
			ribbonBar.OnEffectiveStyleChanged((global::DevComponents.WpfRibbon.eEffectiveStyle)e.OldValue, (global::DevComponents.WpfRibbon.eEffectiveStyle)e.NewValue);
			goto IL_10A;
			IL_90:
			ribbonBar = (o as global::DevComponents.WpfRibbon.RibbonBar);
			num = (short)1826619392;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7E;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00096B34 File Offset: 0x00094D34
		protected virtual void OnEffectiveStyleChanged(global::DevComponents.WpfRibbon.eEffectiveStyle oldValue, global::DevComponents.WpfRibbon.eEffectiveStyle newValue)
		{
			short num = (short)253225967;
			short num2 = num;
			num = (short)775285743;
			switch (num2 == num)
			{
			}
			num = (short)973602816;
			if (num != 0)
			{
			}
			num = (short)1817313281;
			if (num != 0)
			{
			}
			num = (short)352911360;
			short num3 = num;
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060006AD RID: 1709 RVA: 0x00096BE0 File Offset: 0x00094DE0
		// (remove) Token: 0x060006AE RID: 1710 RVA: 0x00096C94 File Offset: 0x00094E94
		public event global::System.Windows.RoutedEventHandler CollapsedStateChanged
		{
			add
			{
				short num = (short)85058459;
				short num2 = num;
				num = (short)618914715;
				switch (num2 == num)
				{
				}
				num = (short)1042677761;
				if (num != 0)
				{
				}
				num = (short)1332740096;
				if (num != 0)
				{
				}
				num = (short)1970405376;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfRibbon.RibbonBar.CollapsedStateChangedEvent, value);
			}
			remove
			{
				short num = (short)513373543;
				short num2 = num;
				num = (short)2031121767;
				switch (num2 == num)
				{
				}
				num = (short)963903489;
				if (num != 0)
				{
				}
				num = (short)1032912896;
				if (num != 0)
				{
				}
				num = (short)694550528;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfRibbon.RibbonBar.CollapsedStateChangedEvent, value);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00096D4C File Offset: 0x00094F4C
		protected virtual void OnCollapsedStateChanged()
		{
			short num = (short)76472479;
			short num2 = num;
			num = (short)1403904159;
			switch (num2 == num)
			{
			}
			num = (short)1751711745;
			if (num != 0)
			{
			}
			num = (short)2040922112;
			short num3 = num;
			num = (short)1326383104;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.RibbonBar.CollapsedStateChangedEvent);
			base.RaiseEvent(e);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00096E0C File Offset: 0x0009500C
		static RibbonBar()
		{
			int a_ = 8;
			short num = (short)1807201135;
			short num2 = num;
			num = (short)169390959;
			switch (num2 == num)
			{
			}
			num = (short)421462017;
			if (num != 0)
			{
			}
			num = (short)299892736;
			short num3 = num;
			num = (short)129433600;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonBar.VisualStyleProperty = global::DevComponents.WpfRibbon.Ribbon.VisualStyleProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Blue, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBar.OnVisualStyleChanged)));
			global::DevComponents.WpfRibbon.RibbonBar.EffectiveStylePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("╟ѡɣͥ୧ṩիᡭᕯⅱsཱུᑷό", a_), typeof(global::DevComponents.WpfRibbon.eEffectiveStyle), typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBar.OnEffectiveStyleChanged)));
			global::DevComponents.WpfRibbon.RibbonBar.EffectiveStyleProperty = global::DevComponents.WpfRibbon.RibbonBar.EffectiveStylePropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.RibbonBar.CollapsedStateChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍟ൡࡣ੥१ᩩὫ୭ᑯⅱs᝵౷ό㽻ᙽ", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.RibbonBar));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.RibbonBar)));
			global::DevComponents.WpfRibbon.RibbonBar.LaunchDialogEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ⱟ͡ᅣࡥ୧ɩ⡫ݭᅯṱ᭳ᅵ", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler), typeof(global::DevComponents.WpfRibbon.RibbonBar));
			global::DevComponents.WpfRibbon.RibbonBar.DialogLauncherVisibleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⑟ୡգ੥ݧ൩⁫཭կᱱᝳṵᵷࡹ⩻᝽", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible));
			global::DevComponents.WpfRibbon.RibbonBar.ResizeOrderIndexProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㉟ݡᝣཥቧཀྵ⍫ᱭᑯ᝱ٳ㽵ᙷṹ᥻ٽ", a_), typeof(int), typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.PropertyMetadata(0));
			global::DevComponents.WpfRibbon.RibbonBar.CollapsedImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍟ൡࡣ੥१ᩩὫ୭ᑯ㭱ᥳ᝵ίό", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.PropertyMetadata(null));
			global::DevComponents.WpfRibbon.RibbonBar.MinAutoSizeHintProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ⵟୡ੣❥ᵧṩͫ㵭᥯ࡱᅳ㹵ᅷᑹࡻ", a_), typeof(global::DevComponents.WpfRibbon.eAutoSizeHint), typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eAutoSizeHint.Small, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBar.OnMinAutoSizeHintChanged)), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.RibbonBar.IsMinAutoSizeHintValid));
			global::DevComponents.WpfRibbon.RibbonBar.CollapsedHeaderProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍟ൡࡣ੥१ᩩὫ୭ᑯ㩱ᅳ᝵ᱷό๻", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.PropertyMetadata(null));
			global::DevComponents.WpfRibbon.RibbonBar.IsAutoSizeEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⥟ᅡ╣፥ᱧթ㽫ݭ੯᝱ㅳᡵ᥷᡹ၻ᭽", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.PropertyMetadata(true));
			global::System.Windows.Controls.Control.IsTabStopProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.RibbonBar), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060006B2 RID: 1714 RVA: 0x0009718C File Offset: 0x0009538C
		// (remove) Token: 0x060006B3 RID: 1715 RVA: 0x00097244 File Offset: 0x00095444
		public event global::System.Windows.RoutedEventHandler LaunchDialog
		{
			add
			{
				short num = (short)1129292814;
				short num2 = num;
				num = (short)853582862;
				switch (num2 == num)
				{
				}
				num = (short)766115840;
				if (num != 0)
				{
				}
				num = (short)716832768;
				short num3 = num;
				num = (short)1341063169;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.RibbonBar.LaunchDialogEvent, value);
			}
			remove
			{
				short num = (short)1226938959;
				short num2 = num;
				num = (short)957389391;
				switch (num2 == num)
				{
				}
				num = (short)168820737;
				if (num != 0)
				{
				}
				num = (short)94896128;
				short num3 = num;
				num = (short)1384316928;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.RibbonBar.LaunchDialogEvent, value);
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x000972F8 File Offset: 0x000954F8
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x000973B0 File Offset: 0x000955B0
		[global::System.ComponentModel.DefaultValue(0)]
		public int ResizeOrderIndex
		{
			get
			{
				short num = (short)409123225;
				short num2 = num;
				num = (short)1170717081;
				switch (num2 == num)
				{
				}
				num = (short)1114177536;
				if (num != 0)
				{
				}
				num = (short)1957691392;
				short num3 = num;
				num = (short)262537217;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::DevComponents.WpfRibbon.RibbonBar.ResizeOrderIndexProperty);
			}
			set
			{
				short num = (short)113639425;
				if (num != 0)
				{
				}
				num = (short)768172856;
				short num2 = num;
				num = (short)612590392;
				switch (num2 == num)
				{
				}
				num = (short)1916338176;
				short num3 = num;
				num = (short)178192384;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBar.ResizeOrderIndexProperty, value);
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00097470 File Offset: 0x00095670
		protected virtual void OnLaunchDialog()
		{
			short num = (short)1889638759;
			short num2 = num;
			num = (short)150051175;
			switch (num2 == num)
			{
			}
			num = (short)876347393;
			if (num != 0)
			{
			}
			num = (short)1846738944;
			short num3 = num;
			num = (short)133103616;
			if (num != 0)
			{
			}
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs
			{
				RoutedEvent = global::DevComponents.WpfRibbon.RibbonBar.LaunchDialogEvent
			});
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00097534 File Offset: 0x00095734
		internal void InvokeLaunchDialog()
		{
			short num = (short)449981529;
			short num2 = num;
			num = (short)1278094425;
			switch (num2 == num)
			{
			}
			num = (short)1417936897;
			if (num != 0)
			{
			}
			num = (short)828833792;
			short num3 = num;
			num = (short)123731968;
			if (num != 0)
			{
			}
			this.OnLaunchDialog();
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x000975E4 File Offset: 0x000957E4
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0009769C File Offset: 0x0009589C
		[global::System.ComponentModel.DefaultValue(global::System.Windows.Visibility.Visible)]
		public global::System.Windows.Visibility DialogLauncherVisible
		{
			get
			{
				short num = (short)1577542730;
				short num2 = num;
				num = (short)1858626634;
				switch (num2 == num)
				{
				}
				num = (short)641466369;
				if (num != 0)
				{
				}
				num = (short)1536425984;
				short num3 = num;
				num = (short)1585905664;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfRibbon.RibbonBar.DialogLauncherVisibleProperty);
			}
			set
			{
				short num = (short)367474998;
				short num2 = num;
				num = (short)1664825654;
				switch (num2 == num)
				{
				}
				num = (short)2014511105;
				if (num != 0)
				{
				}
				num = (short)729284608;
				short num3 = num;
				num = (short)1316749312;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBar.DialogLauncherVisibleProperty, value);
			}
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00097758 File Offset: 0x00095958
		public override void OnApplyTemplate()
		{
			int a_ = 19;
			short num = (short)1559625732;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BD;
				case 1:
					goto IL_1E9;
				case 2:
					goto IL_C2;
				case 3:
				{
					num = (short)2002963982;
					short num3 = num;
					num = (short)670617102;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E9;
					default:
						num = (short)502136832;
						if (num != 0)
						{
						}
						if (this.m_DialogLauncherButton != null)
						{
							num = (short)810418177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_221;
					}
					break;
				}
				case 4:
					num = (short)1765015553;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					continue;
				case 5:
					this.m_DialogLauncherButton.Click -= this.LauncherClick;
					num = (short)434700290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6F:
				if (this.m_DialogLauncherButton != null)
				{
					num = (short)417726469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C2:
				num = (short)1679687680;
				short num4 = num;
				this.m_DialogLauncherButton = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㭪ⱬ㵮╰ⱲㅴṶᡸ᝺ቼ᡾춀ﶎ", a_)) as global::DevComponents.WpfRibbon.ButtonDropDown);
				this.m_Border = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㭪ⱬ㵮╰Ⱳ❴Ṷ᭸᥺ቼᅾ쎀얆力", a_)) as global::DevComponents.WpfRibbon.RibbonBorder);
				this.m_Title = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㭪ⱬ㵮╰Ⱳ❴Ṷ᭸᥺ቼᅾ쎀펆ﾊ", a_)) as global::DevComponents.WpfRibbon.RibbonBorder);
				this.m_ButtonPanel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㭪ⱬ㵮╰Ⱳ❴Ṷ᭸᥺ቼᅾ쎀힆", a_)) as global::DevComponents.WpfRibbon.ButtonPanel);
				num = (short)382992387;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E9:
				this.m_DialogLauncherButton.Click += this.LauncherClick;
				num = (short)490471424;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BD:
			IL_221:
			base.OnApplyTemplate();
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0009798C File Offset: 0x00095B8C
		protected override void OnInitialized(global::System.EventArgs e)
		{
			short num = (short)1632894977;
			if (num != 0)
			{
			}
			num = (short)1857949708;
			short num2 = num;
			num = (short)830476300;
			switch (num2 == num)
			{
			}
			num = (short)869597184;
			short num3 = num;
			num = (short)923402240;
			if (num != 0)
			{
			}
			base.OnInitialized(e);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00097A3C File Offset: 0x00095C3C
		private void LauncherClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)338558977;
			if (num != 0)
			{
			}
			num = (short)1956070568;
			short num2 = num;
			num = (short)705184936;
			switch (num2 == num)
			{
			}
			num = (short)1736769536;
			short num3 = num;
			num = (short)1707278336;
			if (num != 0)
			{
			}
			this.OnLaunchDialog();
			e.Handled = true;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00097AF0 File Offset: 0x00095CF0
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1695219716;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11D;
				case 1:
					goto IL_157;
				case 2:
					goto IL_11F;
				case 3:
					if (this.m_Title != null)
					{
						num = (short)319488001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_181;
				case 4:
				{
					num = (short)617600139;
					short num3 = num;
					num = (short)594662539;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_157;
					default:
						num = (short)271843328;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					}
					break;
				}
				case 5:
					this.m_Border.BorderState = global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Hover;
					num = (short)705888258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_88:
				num = (short)1613627393;
				if (num != 0)
				{
				}
				if (this.m_Border != null)
				{
					num = (short)433782789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_11F:
				num = (short)213123075;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_157:
				num = (short)2038693888;
				short num4 = num;
				this.m_Title.BorderState = global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Hover;
				num = (short)457703424;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11D:
			IL_181:
			base.OnMouseEnter(e);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00097C88 File Offset: 0x00095E88
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1860501508;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FA;
				case 1:
					goto IL_15C;
				case 2:
					goto IL_FF;
				case 3:
					num = (short)619249665;
					if (num != 0)
					{
					}
					if (this.m_Title != null)
					{
						num = (short)732823553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_189;
				case 4:
				{
					num = (short)574879812;
					short num3 = num;
					num = (short)1323759684;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15C;
					default:
						num = (short)503447552;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					}
					break;
				}
				case 5:
					this.m_Border.BorderState = global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Normal;
					num = (short)972750850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8C:
				if (this.m_Border != null)
				{
					num = (short)869007365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_FF:
				num = (short)611647491;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15C:
				this.m_Title.BorderState = global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Normal;
				num = (short)1108803584;
				short num4 = num;
				num = (short)1854144512;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FA:
			IL_189:
			base.OnMouseLeave(e);
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00097E28 File Offset: 0x00096028
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00097ED8 File Offset: 0x000960D8
		public bool IsCollapsed
		{
			get
			{
				short num = (short)1798504449;
				if (num != 0)
				{
				}
				num = (short)390509690;
				short num2 = num;
				num = (short)1035908218;
				switch (num2 == num)
				{
				}
				num = (short)1557594112;
				short num3 = num;
				num = (short)610402304;
				if (num != 0)
				{
				}
				return this.m_IsCollapsed;
			}
			internal set
			{
				short num;
				for (;;)
				{
					IL_00:
					num = (short)1584201730;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							this.m_IsCollapsed = value;
							this.OnCollapsedStateChanged();
							num = (short)1262487230;
							short num3 = num;
							num = (short)774047422;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)618070016;
								if (num != 0)
								{
								}
								num = (short)305659904;
								short num4 = num;
								num = (short)746651649;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
							goto IL_EA;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						}
						IL_30:
						if (this.m_IsCollapsed == value)
						{
							goto IL_EC;
						}
						num = (short)1205338112;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_EA:
				IL_EC:
				num = (short)721092609;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00097FFC File Offset: 0x000961FC
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x000980B0 File Offset: 0x000962B0
		[global::System.ComponentModel.DefaultValue(null)]
		public object CollapsedImage
		{
			get
			{
				short num = (short)2007001465;
				short num2 = num;
				num = (short)911960441;
				switch (num2 == num)
				{
				}
				num = (short)392560641;
				if (num != 0)
				{
				}
				num = (short)1873215488;
				short num3 = num;
				num = (short)33488896;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.RibbonBar.CollapsedImageProperty);
			}
			set
			{
				short num = (short)574991914;
				short num2 = num;
				num = (short)375107114;
				switch (num2 == num)
				{
				}
				num = (short)1543176193;
				if (num != 0)
				{
				}
				num = (short)142147584;
				short num3 = num;
				num = (short)1674838016;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBar.CollapsedImageProperty, value);
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00098168 File Offset: 0x00096368
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x0009821C File Offset: 0x0009641C
		[global::System.ComponentModel.DefaultValue(null)]
		public object CollapsedHeader
		{
			get
			{
				short num = (short)1519696199;
				short num2 = num;
				num = (short)982104391;
				switch (num2 == num)
				{
				}
				num = (short)1333854209;
				if (num != 0)
				{
				}
				num = (short)1557069824;
				short num3 = num;
				num = (short)72155136;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.RibbonBar.CollapsedHeaderProperty);
			}
			set
			{
				short num = (short)118725955;
				short num2 = num;
				num = (short)1040620867;
				switch (num2 == num)
				{
				}
				num = (short)405602304;
				if (num != 0)
				{
				}
				num = (short)1957429248;
				short num3 = num;
				num = (short)1277952001;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBar.CollapsedHeaderProperty, value);
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x000982D4 File Offset: 0x000964D4
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00098384 File Offset: 0x00096584
		internal bool MeasureNeedCollapse
		{
			get
			{
				short num = (short)1207896511;
				short num2 = num;
				num = (short)416221631;
				switch (num2 == num)
				{
				}
				num = (short)1630666752;
				if (num != 0)
				{
				}
				num = (short)2015690752;
				short num3 = num;
				num = (short)929497089;
				if (num != 0)
				{
				}
				return this.m_MeasureNeedCollapse;
			}
			set
			{
				short num = (short)139911511;
				short num2 = num;
				num = (short)334553431;
				switch (num2 == num)
				{
				}
				num = (short)182517760;
				if (num != 0)
				{
				}
				num = (short)31064064;
				short num3 = num;
				num = (short)1676083201;
				if (num != 0)
				{
				}
				this.m_MeasureNeedCollapse = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00098438 File Offset: 0x00096638
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x000984E8 File Offset: 0x000966E8
		internal bool IsSecondMeasurePass
		{
			get
			{
				short num = (short)1549776298;
				short num2 = num;
				num = (short)1755231658;
				switch (num2 == num)
				{
				}
				num = (short)281149440;
				if (num != 0)
				{
				}
				num = (short)1743847424;
				short num3 = num;
				num = (short)584056833;
				if (num != 0)
				{
				}
				return this.m_IsSecondMeasurePass;
			}
			set
			{
				short num = (short)398167132;
				short num2 = num;
				num = (short)2041613404;
				switch (num2 == num)
				{
				}
				num = (short)1085800449;
				if (num != 0)
				{
				}
				num = (short)547094528;
				short num3 = num;
				num = (short)1637351424;
				if (num != 0)
				{
				}
				this.m_IsSecondMeasurePass = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00098598 File Offset: 0x00096798
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00098648 File Offset: 0x00096848
		internal global::System.Windows.Size LastPanelMeasureSize
		{
			get
			{
				short num = (short)1304743635;
				short num2 = num;
				num = (short)1264111315;
				switch (num2 == num)
				{
				}
				num = (short)372768769;
				if (num != 0)
				{
				}
				num = (short)1238171648;
				short num3 = num;
				num = (short)1456144384;
				if (num != 0)
				{
				}
				return this.m_LastPanelMeasureSize;
			}
			set
			{
				short num = (short)191902233;
				short num2 = num;
				num = (short)1706832409;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1286602752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)289013760;
				if (num != 0)
				{
				}
				num = (short)1834549249;
				if (num != 0)
				{
				}
				this.m_LastPanelMeasureSize = value;
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x000986FC File Offset: 0x000968FC
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static global::DevComponents.WpfRibbon.eAutoSizeHint GetMinAutoSizeHint(global::System.Windows.UIElement element)
		{
			int a_ = 9;
			short num = (short)937917717;
			short num2 = num;
			num = (short)321158421;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BD;
			case 1:
				break;
			default:
			{
				num = (short)1533870080;
				short num3 = num;
				break;
			}
			}
			num = (short)1561067520;
			if (num != 0)
			{
			}
			num = (short)387383297;
			if (num != 0)
			{
			}
			if (element == null)
			{
				throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ѡརd੦", a_));
			}
			IL_BD:
			return (global::DevComponents.WpfRibbon.eAutoSizeHint)element.GetValue(global::DevComponents.WpfRibbon.RibbonBar.MinAutoSizeHintProperty);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x000987D8 File Offset: 0x000969D8
		public static void SetMinAutoSizeHint(global::System.Windows.UIElement element, global::DevComponents.WpfRibbon.eAutoSizeHint part)
		{
			int a_ = 8;
			short num = (short)331454104;
			short num2 = num;
			num = (short)1945540248;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BB;
			case 1:
				break;
			default:
			{
				num = (short)79822848;
				short num3 = num;
				break;
			}
			}
			num = (short)518520833;
			if (num != 0)
			{
			}
			num = (short)444071936;
			if (num != 0)
			{
			}
			if (element == null)
			{
				throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("՟๡ţ୥", a_));
			}
			IL_BB:
			element.SetValue(global::DevComponents.WpfRibbon.RibbonBar.MinAutoSizeHintProperty, part);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000988B4 File Offset: 0x00096AB4
		private static void OnMinAutoSizeHintChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.UIElement uielement;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::DevComponents.WpfRibbon.ButtonPanel buttonPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::DevComponents.WpfRibbon.ButtonPanel;
					num2 = (short)1738211332;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)1800208385;
					if (num2 != 0)
					{
					}
					if (uielement != null)
					{
						num2 = (short)1663172608;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)768858519;
					short num3 = num2;
					num2 = (short)1922357655;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)575537152;
						if (num2 != 0)
						{
						}
						num2 = (short)1592852480;
						short num4 = num2;
						global::DevComponents.WpfRibbon.ButtonPanel buttonPanel;
						buttonPanel.InvalidateMeasure();
						num2 = (short)1400569859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					return;
				case 4:
				{
					global::DevComponents.WpfRibbon.ButtonPanel buttonPanel;
					if (buttonPanel != null)
					{
						num2 = (short)692387842;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				goto IL_24;
			}
			return;
			IL_24:
			uielement = (d as global::System.Windows.UIElement);
			num2 = (short)797573121;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00098A1C File Offset: 0x00096C1C
		private static bool IsMinAutoSizeHintValid(object o)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.eAutoSizeHint eAutoSizeHint;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)457572352;
					short num3 = num2;
					if (eAutoSizeHint != global::DevComponents.WpfRibbon.eAutoSizeHint.Medium)
					{
						num2 = (short)767819779;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 1:
					num2 = (short)1635188736;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (eAutoSizeHint != global::DevComponents.WpfRibbon.eAutoSizeHint.NoAutoSize)
					{
						goto IL_4B;
					}
					return true;
				case 3:
				{
					num2 = (short)1674048863;
					short num4 = num2;
					num2 = (short)640611679;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4B;
					default:
						num2 = (short)1761738752;
						if (num2 != 0)
						{
						}
						num2 = (short)671416324;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (eAutoSizeHint != global::DevComponents.WpfRibbon.eAutoSizeHint.Small)
					{
						num2 = (short)1069613061;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					goto IL_109;
				}
				goto IL_28;
				IL_4B:
				num2 = (short)1385955329;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_109:
			num2 = (short)50462721;
			if (num2 != 0)
			{
			}
			return false;
			IL_28:
			eAutoSizeHint = (global::DevComponents.WpfRibbon.eAutoSizeHint)o;
			num2 = (short)1141768194;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00098B98 File Offset: 0x00096D98
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00098C50 File Offset: 0x00096E50
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IsAutoSizeEnabled
		{
			get
			{
				short num = (short)547281860;
				short num2 = num;
				num = (short)992140228;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1290338304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2029256704;
				if (num != 0)
				{
				}
				num = (short)663552001;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonBar.IsAutoSizeEnabledProperty);
			}
			set
			{
				short num = (short)1790574593;
				if (num != 0)
				{
				}
				num = (short)1798832128;
				short num2 = num;
				num = (short)552695131;
				short num3 = num;
				num = (short)1146058075;
				switch (num3 == num)
				{
				}
				num = (short)1875968000;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBar.IsAutoSizeEnabledProperty, value);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00098D08 File Offset: 0x00096F08
		internal global::DevComponents.WpfRibbon.ButtonPanel ButtonPanel
		{
			get
			{
				short num = (short)1289257074;
				short num2 = num;
				num = (short)1075740786;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101725696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)515637249;
				if (num != 0)
				{
				}
				num = (short)349372416;
				if (num != 0)
				{
				}
				return this.m_ButtonPanel;
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00098DBC File Offset: 0x00096FBC
		internal global::DevComponents.WpfRibbon.RibbonBar Copy(bool deepCopy)
		{
			short num = (short)1056071902;
			short num2 = num;
			num = (short)643391710;
			switch (num2 == num)
			{
			default:
			{
				num = (short)96862208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1671757824;
			if (num != 0)
			{
			}
			num = (short)1033961473;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.CloningMachine.Clone(this, deepCopy);
		}

		// Token: 0x0400031C RID: 796
		public static readonly global::System.Windows.DependencyProperty VisualStyleProperty;

		// Token: 0x0400031D RID: 797
		private static readonly global::System.Windows.DependencyPropertyKey EffectiveStylePropertyKey;

		// Token: 0x0400031E RID: 798
		public static readonly global::System.Windows.DependencyProperty EffectiveStyleProperty;

		// Token: 0x04000320 RID: 800
		public static global::System.Windows.DependencyProperty DialogLauncherVisibleProperty;

		// Token: 0x04000321 RID: 801
		public static global::System.Windows.DependencyProperty IsAutoSizeEnabledProperty;

		// Token: 0x04000322 RID: 802
		public static global::System.Windows.DependencyProperty ResizeOrderIndexProperty;

		// Token: 0x04000323 RID: 803
		public static global::System.Windows.DependencyProperty CollapsedImageProperty;

		// Token: 0x04000324 RID: 804
		public static readonly global::System.Windows.DependencyProperty MinAutoSizeHintProperty;

		// Token: 0x04000325 RID: 805
		public static readonly global::System.Windows.DependencyProperty CollapsedHeaderProperty;

		// Token: 0x04000327 RID: 807
		private const string RibbonBarBorderName = "PART_RibbonBarBorder";

		// Token: 0x04000328 RID: 808
		private const string RibbonBarTitleName = "PART_RibbonBarTitle";

		// Token: 0x04000329 RID: 809
		private const string DialogLauncherButtonName = "PART_DialogLauncher";

		// Token: 0x0400032A RID: 810
		private const string RibbonBarPanelName = "PART_RibbonBarPanel";

		// Token: 0x0400032B RID: 811
		private global::DevComponents.WpfRibbon.RibbonBorder m_Border;

		// Token: 0x0400032C RID: 812
		private global::DevComponents.WpfRibbon.RibbonBorder m_Title;

		// Token: 0x0400032D RID: 813
		private global::DevComponents.WpfRibbon.ButtonDropDown m_DialogLauncherButton;

		// Token: 0x0400032E RID: 814
		private global::DevComponents.WpfRibbon.ButtonPanel m_ButtonPanel;

		// Token: 0x0400032F RID: 815
		private bool m_IsCollapsed;

		// Token: 0x04000330 RID: 816
		private bool m_MeasureNeedCollapse;

		// Token: 0x04000331 RID: 817
		private bool m_IsSecondMeasurePass;

		// Token: 0x04000332 RID: 818
		private global::System.Windows.Size m_LastPanelMeasureSize;

		// Token: 0x04000333 RID: 819
		internal bool IsRibbonBarPanelMeasure;
	}
}
