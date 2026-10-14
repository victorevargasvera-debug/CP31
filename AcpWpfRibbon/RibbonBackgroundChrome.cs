using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Threading;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000072 RID: 114
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RibbonBackgroundChrome : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0008F774 File Offset: 0x0008D974
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x0008F830 File Offset: 0x0008DA30
		public global::DevComponents.WpfRibbon.eRibbonVisualStyle VisualStyle
		{
			get
			{
				short num = (short)1619066881;
				if (num != 0)
				{
				}
				num = (short)1100475025;
				short num2 = num;
				num = (short)452323985;
				switch (num2 == num)
				{
				}
				num = (short)668532736;
				if (num != 0)
				{
				}
				num = (short)39714816;
				short num3 = num;
				return (global::DevComponents.WpfRibbon.eRibbonVisualStyle)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.VisualStyleProperty);
			}
			set
			{
				short num = (short)2020744310;
				short num2 = num;
				num = (short)1886329974;
				switch (num2 == num)
				{
				}
				num = (short)404226048;
				if (num != 0)
				{
				}
				num = (short)1214513153;
				if (num != 0)
				{
				}
				num = (short)2072903680;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.VisualStyleProperty, value);
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0008F8EC File Offset: 0x0008DAEC
		private static void OnVisualStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)255197185;
			if (num != 0)
			{
			}
			num = (short)1625146666;
			short num2 = num;
			num = (short)1448068394;
			switch (num2 == num)
			{
			}
			num = (short)899088384;
			if (num != 0)
			{
			}
			num = (short)1594425344;
			short num3 = num;
			((global::DevComponents.WpfRibbon.RibbonBackgroundChrome)o).OnVisualStyleChanged((global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.OldValue, (global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.NewValue);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0008F9BC File Offset: 0x0008DBBC
		private void OnVisualStyleChanged(global::DevComponents.WpfRibbon.eRibbonVisualStyle oldValue, global::DevComponents.WpfRibbon.eRibbonVisualStyle newValue)
		{
			short num;
			for (;;)
			{
				num = (short)661979137;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_94;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 2:
						num = (short)1113980933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (newValue != global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Blue)
						{
							num = (short)1833435138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B;
					case 4:
						num = (short)161218563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (newValue == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Black)
						{
							num = (short)1943207936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					}
					IL_3D:
					if (newValue == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Silver)
					{
						goto IL_5B;
					}
					num = (short)1695285252;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_125:
				num = (short)549442020;
				short num3 = num;
				num = (short)1505939940;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_15A;
				}
			}
			IL_5B:
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010;
			return;
			IL_94:
			num = (short)1499463681;
			if (num != 0)
			{
			}
			num = (short)1056243712;
			short num4 = num;
			goto IL_5B;
			IL_15A:
			num = (short)1041825792;
			if (num != 0)
			{
			}
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007;
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0008FB40 File Offset: 0x0008DD40
		private bool IsDesignMode
		{
			get
			{
				short num = (short)1581431707;
				short num2 = num;
				num = (short)1701297051;
				switch (num2 == num)
				{
				}
				num = (short)312410113;
				if (num != 0)
				{
				}
				num = (short)676921344;
				if (num != 0)
				{
				}
				num = (short)23199744;
				short num3 = num;
				return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0008FBF4 File Offset: 0x0008DDF4
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x0008FCAC File Offset: 0x0008DEAC
		public global::DevComponents.WpfRibbon.eEffectiveStyle EffectiveStyle
		{
			get
			{
				short num = (short)336409762;
				short num2 = num;
				num = (short)1269970082;
				switch (num2 == num)
				{
				}
				num = (short)2088501248;
				if (num != 0)
				{
				}
				num = (short)2015559681;
				if (num != 0)
				{
				}
				num = (short)1783103488;
				short num3 = num;
				return (global::DevComponents.WpfRibbon.eEffectiveStyle)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.EffectiveStyleProperty);
			}
			internal set
			{
				short num = (short)1765158307;
				short num2 = num;
				num = (short)2108239267;
				switch (num2 == num)
				{
				}
				num = (short)1169620993;
				if (num != 0)
				{
				}
				num = (short)1237647360;
				if (num != 0)
				{
				}
				num = (short)1380909056;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.EffectiveStylePropertyKey, value);
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0008FD68 File Offset: 0x0008DF68
		private static void OnEffectiveStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			for (;;)
			{
				short num = (short)741933056;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				global::DevComponents.WpfRibbon.RibbonBackgroundChrome ribbonBackgroundChrome;
				for (;;)
				{
					IL_35:
					int num3;
					switch (num3)
					{
					case 0:
						return;
					case 1:
						if (ribbonBackgroundChrome != null)
						{
							num = (short)1845624834;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						ribbonBackgroundChrome.OnEffectiveStyleChanged((global::DevComponents.WpfRibbon.eEffectiveStyle)e.OldValue, (global::DevComponents.WpfRibbon.eEffectiveStyle)e.NewValue);
						num = (short)273547264;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_47:
				ribbonBackgroundChrome = (o as global::DevComponents.WpfRibbon.RibbonBackgroundChrome);
				num = (short)1630227865;
				short num4 = num;
				num = (short)1608928665;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1035010049;
					if (num != 0)
					{
					}
					num = (short)516227072;
					if (num != 0)
					{
					}
					num = (short)1240596481;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_35;
				}
				}
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0008FEA4 File Offset: 0x0008E0A4
		protected virtual void OnEffectiveStyleChanged(global::DevComponents.WpfRibbon.eEffectiveStyle oldValue, global::DevComponents.WpfRibbon.eEffectiveStyle newValue)
		{
			short num = (short)378535009;
			short num2 = num;
			num = (short)1328872545;
			switch (num2 == num)
			{
			}
			num = (short)2028601345;
			if (num != 0)
			{
			}
			num = (short)784138240;
			if (num != 0)
			{
			}
			num = (short)838008832;
			short num3 = num;
			this.UpdateWindowIconVisibility();
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0008FF54 File Offset: 0x0008E154
		private void UpdateWindowIconVisibility()
		{
			short num = (short)248905728;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_57;
			}
			int num3;
			global::DevComponents.WpfRibbon.eEffectiveStyle effectiveStyle;
			for (;;)
			{
				IL_35:
				switch (num3)
				{
				case 0:
					if (effectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007)
					{
						num = (short)1650720772;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97;
				case 1:
					num = (short)1034354689;
					if (num != 0)
					{
					}
					if (effectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
					{
						num = (short)1102774278;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					if (this.m_WindowIcon != null)
					{
						num = (short)407568389;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
				{
					num = (short)2065421771;
					short num4 = num;
					num = (short)6346187;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_97;
					default:
						goto IL_129;
					}
					break;
				}
				case 5:
					num = (short)394985472;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.m_WindowIcon.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)1747124227;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_57;
				IL_97:
				num = (short)1025835009;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_129:
			num = (short)964624384;
			if (num != 0)
			{
			}
			this.m_WindowIcon.Visibility = global::System.Windows.Visibility.Collapsed;
			return;
			IL_57:
			effectiveStyle = this.EffectiveStyle;
			num = (short)167182338;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_35;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0009010C File Offset: 0x0008E30C
		static RibbonBackgroundChrome()
		{
			int a_ = 8;
			short num = (short)1533609454;
			short num2 = num;
			num = (short)1710949870;
			switch (num2 == num)
			{
			}
			num = (short)111411200;
			if (num != 0)
			{
			}
			num = (short)507248641;
			if (num != 0)
			{
			}
			num = (short)1508835328;
			short num3 = num;
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.VisualStyleProperty = global::DevComponents.WpfRibbon.Ribbon.VisualStyleProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Blue, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.OnVisualStyleChanged)));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.EffectiveStylePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("╟ѡɣͥ୧ṩիᡭᕯⅱsཱུᑷό", a_), typeof(global::DevComponents.WpfRibbon.eEffectiveStyle), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.OnEffectiveStyleChanged)));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.EffectiveStyleProperty = global::DevComponents.WpfRibbon.RibbonBackgroundChrome.EffectiveStylePropertyKey.DependencyProperty;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome)));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.QatRightPositionProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅟ͡ၣ㑥ŧ൩ѫᩭ⁯ᵱݳή౷፹፻ၽ", a_), typeof(global::System.Windows.GridLength), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.GridLength(0.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.OnQatRightPositionChanged)));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.TitleChromeHeightProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㑟ୡၣ੥൧⥩ѫᱭὯάᅳ㹵ᵷ፹᭻ᙽ", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(28.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.OnTitleChromeHeightChanged)));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.IsGlassEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⥟ᅡ⍣੥१ᥩὫ⭭ṯ፱ᙳ᩵ᵷṹ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.IsGlassEnabledChanged)));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.SystemButtonsProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㍟᭡ᝣብ൧ݩ⹫᭭ѯٱ᭳ᡵ୷", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.OnSystemButtonsChanged)));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.CloseButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍟๡ୣᕥ൧⡩ᥫᩭѯᵱᩳ⁵ᅷॹᕻᱽ", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.RestoreButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㉟ݡᝣብݧᡩ५Ɑկٱs᥵ᙷⱹᕻൽﺉ", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.MinimizeButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ⵟୡ੣ཥէͩᙫ୭㉯ݱsɵ᝷ᑹ⩻᝽", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.MaximizeButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ⵟ͡ᱣཥէͩᙫ୭㉯ݱsɵ᝷ᑹ⩻᝽", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.IsActiveProperty = global::DevComponents.WpfRibbon.Ribbon.IsActiveProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.WindowStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝟ୡ੣ɥݧᵩ㽫ᩭᅯٱᅳ", a_), typeof(global::System.Windows.WindowState), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.WindowState.Normal, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.WindowStateChanged)));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.WindowBorderThicknessProperty = global::DevComponents.WpfRibbon.Ribbon.WindowBorderThicknessProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Thickness(3.0, 0.0, 3.0, 0.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.WindowBorderThicknessChanged)));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.HorizontalWindowBorderThicknessPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⡟ൡᙣཥቧթɫᩭᅯṱ⍳ήᙷṹ፻ॽ쉿\ud88b憐ﾓﶗ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness)));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.HorizontalWindowBorderThicknessProperty = global::DevComponents.WpfRibbon.RibbonBackgroundChrome.HorizontalWindowBorderThicknessPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.TotalTitleChromeHeightPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㑟ൡၣݥѧ㹩իᩭᱯ᝱㝳ṵ੷ᕹᅻ᭽졿ﺉ", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.RibbonBackgroundChrome), new global::System.Windows.FrameworkPropertyMetadata(28.0));
			global::DevComponents.WpfRibbon.RibbonBackgroundChrome.TotalTitleChromeHeightProperty = global::DevComponents.WpfRibbon.RibbonBackgroundChrome.TotalTitleChromeHeightPropertyKey.DependencyProperty;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000905C8 File Offset: 0x0008E7C8
		public RibbonBackgroundChrome()
		{
			this.HorizontalWindowBorderThickness = new global::System.Windows.Thickness(this.WindowBorderThickness.Left, 0.0, this.WindowBorderThickness.Right, 0.0);
			this.TitleChromeHeight = (double)this.GetSystemCaptionHeight();
			this.UpdateTotalChromeHeight();
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00090628 File Offset: 0x0008E828
		public override void OnApplyTemplate()
		{
			int a_ = 14;
			short num = (short)886374400;
			switch (num)
			{
			default:
			{
				num = (short)2084962330;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Window window;
					switch (num2)
					{
					case 0:
						if (this.m_MinButton != null)
						{
							num = (short)13434885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51B;
					case 1:
					{
						this.m_TitlePanel.TabXPosition = this.m_TabXPosition;
						this.m_TitlePanel.QatRightPosition = this.QatRightPosition.Value;
						this.UpdateTitlePanelChromeHeight();
						global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(this);
						global::DevComponents.WpfRibbon.Ribbon ribbon = null;
						num = (short)1200291842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1E3;
					case 3:
						if (this.m_RestoreButton != null)
						{
							num = (short)824770588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_362;
					case 4:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						this.m_ConnectedCollection = ribbon.ContextGroups;
						this.LoadPanel(this.m_ConnectedCollection);
						this.m_ConnectedCollection.CollectionChanged += this.ContextGroupsChanged;
						this.UpdateContextGroupGlassEffect();
						global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㕥ᅧᥩᡫ୭ᵯぱųɵ౷ᕹቻൽ", a_));
						binding.Source = ribbon;
						global::System.Windows.Data.BindingOperations.SetBinding(this, global::DevComponents.WpfRibbon.RibbonBackgroundChrome.SystemButtonsProperty, binding);
						num = (short)177209375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						this.m_MinButton.Click -= this.SysButtonClick;
						this.m_MinButton = null;
						num = (short)2044264497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.m_RestoreButton != null)
						{
							num = (short)2119041045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_166;
					case 7:
						goto IL_1E3;
					case 8:
						goto IL_21B;
					case 9:
						this.m_CloseButton.Click += this.SysButtonClick;
						num = (short)2053701654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Windows.DependencyObject parent;
						if (parent == null)
						{
							num = (short)1905459232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)595525676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						if (ribbon != null)
						{
							num = (short)316407812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29F;
					}
					case 12:
						goto IL_594;
					case 13:
						if (this.m_MaxButton != null)
						{
							num = (short)301989927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B;
					case 14:
						if (this.m_TitlePanel != null)
						{
							num = (short)912982017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29F;
					case 15:
						goto IL_4DB;
					case 16:
						this.m_ConnectedCollection.CollectionChanged -= this.ContextGroupsChanged;
						this.m_ConnectedCollection = null;
						num = (short)334430245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (this.m_CloseButton != null)
						{
							num = (short)1379008521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A9;
					case 18:
						goto IL_8B2;
					case 19:
						if (this.m_CloseButton != null)
						{
							num = (short)140902442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_594;
					case 20:
						if (this.m_MinButton != null)
						{
							num = (short)565182487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8B2;
					case 21:
						this.m_RestoreButton.Click += this.SysButtonClick;
						num = (short)450297891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_6A9;
					case 23:
						this.m_MinButton.Click += this.SysButtonClick;
						num = (short)2112749586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_5D6;
					case 25:
						goto IL_362;
					case 26:
						switch (0)
						{
						case 0:
							goto IL_117;
						}
						continue;
					case 27:
						this.m_MaxButton.Click += this.SysButtonClick;
						num = (short)1772093455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						this.m_RestoreButton.Click -= this.SysButtonClick;
						this.m_RestoreButton = null;
						num = (short)1417674777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⽥୧թɫ", a_));
						binding2.Source = window;
						global::System.Windows.Data.BindingOperations.SetBinding(this.m_WindowIcon, global::System.Windows.Controls.Image.SourceProperty, binding2);
						this.m_WindowIcon.MouseDown += this.WindowIconMouseDown;
						num = (short)1581318187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						if (this.m_MaxButton != null)
						{
							num = (short)141361179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_637;
					case 31:
						goto IL_29F;
					case 32:
						goto IL_5D6;
					case 33:
						if (this.m_WindowIcon != null)
						{
							num = (short)1612316701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB3;
					case 34:
						if (this.m_TitlePanel != null)
						{
							num = (short)771162150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B9;
					case 35:
						goto IL_166;
					case 36:
						goto IL_7B9;
					case 37:
						goto IL_94A;
					case 38:
					{
						num = (short)2092957696;
						short num3 = num;
						this.m_TitlePanel.Children.Clear();
						num = (short)389021732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						this.m_MaxButton.Click -= this.SysButtonClick;
						this.m_MaxButton = null;
						num = (short)1520369672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						global::System.Windows.DependencyObject parent;
						if (parent is global::System.Windows.Media.Visual)
						{
							num = (short)1480654894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						parent = global::System.Windows.LogicalTreeHelper.GetParent(parent);
						num = (short)1617231879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						goto IL_1E3;
					case 42:
						this.m_CloseButton.Click -= this.SysButtonClick;
						this.m_CloseButton = null;
						num = (short)315883532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_480;
					case 44:
					{
						global::System.Windows.DependencyObject parent;
						if (parent is global::DevComponents.WpfRibbon.Ribbon)
						{
							num = (short)692256813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1746010152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
					{
						global::System.Windows.DependencyObject parent;
						global::DevComponents.WpfRibbon.Ribbon ribbon = parent as global::DevComponents.WpfRibbon.Ribbon;
						num = (short)436797464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
					{
						global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(parent);
						num = (short)1267925033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
					{
						if (window == null)
						{
							goto IL_AB3;
						}
						num = (short)1601071918;
						short num4 = num;
						num = (short)1584556846;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4DB;
						default:
							num = (short)1406140416;
							if (num != 0)
							{
							}
							num = (short)1051656240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 48:
					{
						global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⽥᭧⭩ཫᩭ᥯ѱᅳ", a_));
						binding2.Source = window;
						global::System.Windows.Data.BindingOperations.SetBinding(this, global::DevComponents.WpfRibbon.RibbonBackgroundChrome.IsActiveProperty, binding2);
						binding2 = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅥŧѩ࡫ŭݯⅱs᝵౷ό", a_));
						binding2.Source = window;
						global::System.Windows.Data.BindingOperations.SetBinding(this, global::DevComponents.WpfRibbon.RibbonBackgroundChrome.WindowStateProperty, binding2);
						this.m_WindowIcon = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅥŧѩ╫൭Ὧᱱ", a_)) as global::System.Windows.Controls.Image);
						num = (short)2028142625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						goto IL_51B;
					}
					IL_117:
					if (this.m_ConnectedCollection != null)
					{
						num = (short)695402512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94A;
					IL_166:
					num = (short)1299382289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E3:
					num = (short)1082327050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21B:
					num = (short)598933504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29F:
					window = global::System.Windows.Window.GetWindow(this);
					num = (short)435683375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_362:
					num = (short)835321875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51B:
					num = (short)2123563011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_594:
					num = (short)1519714338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D6:
					num = (short)1101332491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_637:
					num = (short)34078740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DB:
					goto IL_637;
					IL_6A9:
					this.m_TitlePanel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㙥⥧㡩㡫ㅭ⑯᭱s᩵ᵷ㥹፻ၽ", a_)) as global::DevComponents.WpfRibbon.TitlePanel);
					num = (short)1720123406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7B9:
					this.m_MaxButton = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㙥⥧㡩㡫ㅭ⍯ୱݳ㭵᥷ɹᕻ፽쒅ﶇﺉﺏ", a_)) as global::System.Windows.Controls.Button);
					this.m_MinButton = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㙥⥧㡩㡫ㅭ⍯ୱݳ㭵ᅷᑹᕻ፽쒅ﶇﺉﺏ", a_)) as global::System.Windows.Controls.Button);
					this.m_RestoreButton = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㙥⥧㡩㡫ㅭ⍯ୱݳ⑵ᵷॹࡻᅽ욃ﲇﺉ", a_)) as global::System.Windows.Controls.Button);
					this.m_CloseButton = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㙥⥧㡩㡫ㅭ⍯ୱݳ㕵ᑷᕹཻ᭽쉿", a_)) as global::System.Windows.Controls.Button);
					num = (short)1972437022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8B2:
					num = (short)1368784902;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_94A:
					num = (short)1500053517;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_480:
				num = (short)134873089;
				if (num != 0)
				{
				}
				IL_AB3:
				this.UpdateSystemButtonVisibility();
				this.UpdateWindowIconVisibility();
				base.OnApplyTemplate();
				return;
			}
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000910FC File Offset: 0x0008F2FC
		private void WindowIconMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1214644225;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_14;
				case 2:
					num = (short)1042677763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (global::System.Windows.Window.GetWindow(this) != null)
					{
						num = (short)279314436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
				{
					num = (short)156498468;
					short num3 = num;
					num = (short)1273559588;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
					{
						num = (short)854065152;
						if (num != 0)
						{
						}
						num = (short)1836908545;
						if (num != 0)
						{
						}
						num = (short)621150208;
						short num4 = num;
						global::System.Windows.Point screenPos = this.m_WindowIcon.PointToScreen(new global::System.Windows.Point(0.0, this.m_WindowIcon.RenderSize.Height + 1.0));
						this.ShowTitleContextMenu(screenPos);
						e.Handled = true;
						num = (short)302579712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_38;
				IL_14:
				switch (0)
				{
				case 0:
					IL_38:
					if (e.LeftButton != global::System.Windows.Input.MouseButtonState.Pressed)
					{
						return;
					}
					num = (short)1491402754;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0009129C File Offset: 0x0008F49C
		private bool SystemTitleElementsVisible
		{
			get
			{
				short num = (short)1273823233;
				if (num != 0)
				{
				}
				num = (short)263875889;
				short num2 = num;
				num = (short)976776497;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1718222848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)923533312;
				if (num != 0)
				{
				}
				return this.SystemButtons;
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0009134C File Offset: 0x0008F54C
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			int a_ = 19;
			short num = (short)1317208069;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_209;
				case 1:
					goto IL_29A;
				case 2:
				{
					global::System.Windows.Window window;
					if (window != null)
					{
						num = (short)1061224460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EA;
				}
				case 3:
					num = (short)984154125;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1216675854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 6:
					num = (short)1664548871;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)1749811200;
					short num3 = num;
					if (!(e.OriginalSource is global::System.Windows.Controls.TextBlock))
					{
						num = (short)15073283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29A;
				}
				case 8:
					this.StartWindowDragMove();
					goto IL_27D;
				case 9:
					goto IL_1EA;
				case 10:
				{
					global::System.Windows.Window window;
					if (window.WindowState == global::System.Windows.WindowState.Maximized)
					{
						goto IL_1EA;
					}
					num = (short)1063276446;
					short num4 = num;
					num = (short)809389982;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_27D;
					default:
						num = (short)974585856;
						if (num != 0)
						{
						}
						num = (short)494206984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					if (this.SystemTitleElementsVisible)
					{
						num = (short)1198915599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_333;
				case 12:
					num = (short)157810689;
					if (num != 0)
					{
					}
					num = (short)1065091082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (!(((global::System.Windows.FrameworkElement)e.OriginalSource).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㽪Ѭ᭮ᵰᙲ㝴ᙶ୸", a_)))
					{
						num = (short)1427177476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29A;
				case 14:
					if (((global::System.Windows.FrameworkElement)e.OriginalSource).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㡪ᑬᱮ╰ᩲŴ᭶ᱸ㝺ᱼᵾ", a_))
					{
						num = (short)1491206145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_333;
				case 15:
				{
					global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
					num = (short)420020226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_6D:
				if (e.OriginalSource is global::System.Windows.FrameworkElement)
				{
					num = (short)711458822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1EA:
				e.Handled = true;
				num = (short)530841600;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27D:
				num = (short)584187913;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_29A:
				num = (short)1803419659;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_209:
			IL_333:
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00091694 File Offset: 0x0008F894
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			int a_ = 11;
			short num = (short)519307271;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1954217998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (e.OriginalSource is global::System.Windows.FrameworkElement)
					{
						num = (short)1626144768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A1;
				case 2:
				{
					global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
					num = (short)1744437254;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					num = (short)2120220684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_2C8;
				case 5:
				{
					global::System.Windows.Window window;
					global::System.Windows.Point point = window.PointToScreen(e.GetPosition(window));
					double y = point.Y;
					window.WindowState = global::System.Windows.WindowState.Normal;
					window.Top = point.Y;
					this.StartWindowDragMove();
					num = (short)194772996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					num = (short)2051473408;
					short num3 = num;
					num = (short)1601847201;
					short num4 = num;
					num = (short)1407664033;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_329;
					default:
					{
						num = (short)1996226560;
						if (num != 0)
						{
						}
						global::System.Windows.Window window;
						if (window != null)
						{
							num = (short)2044919811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C8;
					}
					}
					break;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_75;
					}
					continue;
				case 8:
					num = (short)2041970689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_2E6;
				case 10:
					if (this.SystemTitleElementsVisible)
					{
						num = (short)663420930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A1;
				case 11:
					goto IL_105;
				case 12:
				{
					num = (short)1331822593;
					if (num != 0)
					{
					}
					global::System.Windows.Window window;
					if (window.WindowState == global::System.Windows.WindowState.Maximized)
					{
						num = (short)1031733253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C8;
				}
				case 13:
					num = (short)1406271505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (!(e.OriginalSource is global::System.Windows.Controls.TextBlock))
					{
						num = (short)326107151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_105;
				case 15:
					num = (short)1017249808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (!(((global::System.Windows.FrameworkElement)e.OriginalSource).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝢౤፦ը๪⽬๮Ͱ", a_)))
					{
						num = (short)222101517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_105;
				case 17:
					if (((global::System.Windows.FrameworkElement)e.OriginalSource).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ぢᱤᑦ㵨ɪᥬͮᑰ㽲ᑴᕶᱸ᝺", a_))
					{
						goto IL_329;
					}
					goto IL_3A1;
				}
				IL_75:
				if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
				{
					num = (short)2102198280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_105:
				num = (short)621412362;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C8:
				e.Handled = true;
				num = (short)1421475849;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_329:
				num = (short)1319043083;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2E6:
			IL_3A1:
			base.OnMouseMove(e);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00091A4C File Offset: 0x0008FC4C
		private void StartWindowDragMove()
		{
			short num = (short)454167679;
			short num2 = num;
			num = (short)1350765695;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_10A:
				num = (short)531038210;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1589510145;
				if (num != 0)
				{
				}
				num = (short)1654390784;
				if (num != 0)
				{
				}
				num = (short)1154023424;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				num = (short)2017132544;
				short num4 = num;
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_D0;
					}
					continue;
				case 1:
					goto IL_EE;
				case 2:
					return;
				}
				IL_D0:
				if (global::System.Windows.Window.GetWindow(this) == null)
				{
					return;
				}
				num = (short)831389697;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EE:
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Windows.Threading.DispatcherOperationCallback(this.DispatcherStartWindowDragMove), null);
			goto IL_10A;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00091B7C File Offset: 0x0008FD7C
		private object DispatcherStartWindowDragMove(object arg)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
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
				{
					num2 = (short)2034926891;
					short num3 = num2;
					num2 = (short)457737515;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					case 1:
						break;
					default:
					{
						num2 = (short)1329790976;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)40632320;
					if (num2 != 0)
					{
					}
					goto IL_FE;
				}
				case 1:
					num2 = (short)735313921;
					if (num2 != 0)
					{
					}
					if (window != null)
					{
						goto IL_68;
					}
					goto IL_137;
				case 2:
					if (global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
					{
						num2 = (short)526647299;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_137;
				case 3:
					try
					{
						window.DragMove();
						goto IL_137;
					}
					catch (global::System.InvalidOperationException)
					{
						goto IL_137;
					}
					goto IL_FE;
				}
				goto IL_20;
				IL_68:
				num2 = (short)619642880;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_FE:
				num2 = (short)1539047426;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_137:
			return null;
			IL_20:
			window = global::System.Windows.Window.GetWindow(this);
			num2 = (short)1369178113;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00091CD4 File Offset: 0x0008FED4
		protected override void OnMouseRightButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			int a_ = 17;
			short num = (short)1156775937;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)852033537;
					if (num != 0)
					{
					}
					global::System.Windows.Point point = e.GetPosition(this);
					point = base.PointToScreen(point);
					this.ShowTitleContextMenu(point);
					e.Handled = true;
					num = (short)1024786436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 2:
				{
					num = (short)2045238306;
					short num3 = num;
					num = (short)719117346;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D7;
					default:
					{
						num = (short)11730944;
						if (num != 0)
						{
						}
						num = (short)1978990592;
						short num4 = num;
						if (this.SystemTitleElementsVisible)
						{
							num = (short)1459748864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DD;
					}
					}
					break;
				}
				case 3:
					num = (short)1769478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_D2;
				case 5:
					goto IL_D7;
				case 6:
					if (((global::System.Windows.FrameworkElement)e.OriginalSource).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㵨ɪᥬͮᑰㅲᑴն", a_))
					{
						num = (short)1481310213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DD;
				}
				IL_49:
				if (e.OriginalSource is global::System.Windows.FrameworkElement)
				{
					num = (short)903675907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D7:
				num = (short)249495554;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D2:
			IL_1DD:
			base.OnMouseRightButtonUp(e);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00091EC8 File Offset: 0x000900C8
		private void ShowTitleContextMenu(global::System.Windows.Point screenPos)
		{
			short num = (short)1546584064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::System.Windows.Window window;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						while (window != null)
						{
							num = (short)263901178;
							short num3 = num;
							num = (short)569888762;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)1420951552;
								short num4 = num;
								num = (short)885260289;
								if (num != 0)
								{
								}
								num = (short)149094400;
								if (num != 0)
								{
								}
								num = (short)2110128129;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_27;
							}
							}
						}
						return;
					case 1:
					{
						global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(window).Handle;
						byte[] bytes = global::System.BitConverter.GetBytes((int)screenPos.X);
						byte[] bytes2 = global::System.BitConverter.GetBytes((int)screenPos.Y);
						int lParam = global::System.BitConverter.ToInt32(new byte[]
						{
							bytes[0],
							bytes[1],
							bytes2[0],
							bytes2[1]
						}, 0);
						global::DevComponents.WpfRibbon.WinApi.SendMessage(handle, 274, global::DevComponents.WpfRibbon.WinApi.TrackPopupMenu(global::DevComponents.WpfRibbon.WinApi.GetSystemMenu(handle, false), 256U, (int)screenPos.X, (int)screenPos.Y, 0, handle, global::System.IntPtr.Zero), lParam);
						num = (short)1546387458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					}
					goto IL_3A;
				}
				return;
				IL_3A:
				window = global::System.Windows.Window.GetWindow(this);
				num = (short)519045120;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00092084 File Offset: 0x00090284
		protected override void OnMouseDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			int a_ = 11;
			short num = (short)1556938754;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_20B;
				case 1:
					if (!(((global::System.Windows.FrameworkElement)e.OriginalSource).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝢౤፦ը๪⽬๮Ͱ", a_)))
					{
						num = (short)585367552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 3:
				{
					global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
					num = (short)733151236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					global::System.Windows.Window window;
					if (window != null)
					{
						num = (short)1797062664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_289;
				}
				case 5:
				{
					num = (short)1663741834;
					short num3 = num;
					num = (short)1098493834;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A2;
					default:
						goto IL_1EF;
					}
					break;
				}
				case 6:
					num = (short)1868431361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (this.IsMouseInContextGroup())
					{
						num = (short)2024472587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1325596682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)1856045056;
					short num4 = num;
					e.Handled = true;
					global::System.Windows.Window window;
					window.Close();
					goto IL_1A2;
				}
				case 9:
					goto IL_137;
				case 10:
					if (e.OriginalSource == this.m_WindowIcon)
					{
						num = (short)1743519747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_289;
				case 11:
					goto IL_EE;
				}
				IL_5D:
				if (e.OriginalSource is global::System.Windows.FrameworkElement)
				{
					num = (short)330432518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_20B;
				IL_EE:
				e.Handled = this.ToggleWindowState();
				num = (short)1132920833;
				if (num != 0)
				{
				}
				num = (short)351010825;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A2:
				num = (short)575864837;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20B:
				num = (short)1913520135;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_137:
			goto IL_289;
			IL_1EF:
			num = (short)99483648;
			if (num != 0)
			{
			}
			IL_289:
			base.OnMouseDoubleClick(e);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00092324 File Offset: 0x00090524
		private bool IsMouseInContextGroup()
		{
			short num = (short)407502848;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)137822209;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)41287681;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_31C;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_75;
						}
						continue;
					case 2:
						return false;
					}
					IL_75:
					if (this.m_TitlePanel == null)
					{
						num = (short)1506803714;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::System.Collections.IEnumerator enumerator = this.m_TitlePanel.Children.GetEnumerator();
						num = (short)4784128;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return false;
				IL_31C:
				num = (short)495648768;
				short num3 = num;
				try
				{
					num = (short)340918272;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_ED;
							}
							continue;
						case 1:
							num = (short)491913224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_22C;
						case 3:
							result = true;
							num = (short)1122959366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::DevComponents.WpfRibbon.ContextGroup contextGroup;
							if (contextGroup != null)
							{
								num = (short)373096458;
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
								num = (short)62259209;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::DevComponents.WpfRibbon.ContextGroup contextGroup = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfRibbon.ContextGroup;
							num = (short)39845892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_106;
						case 7:
						{
							global::DevComponents.WpfRibbon.ContextGroup contextGroup;
							if (contextGroup.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)1226113025;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::DevComponents.WpfRibbon.ContextGroup contextGroup;
							if (contextGroup.IsMouseOver)
							{
								num = (short)11993091;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							num = (short)700973058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num = (short)1305083911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_10B:
						num = (short)463994885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_ED:
						goto IL_10B;
					}
					IL_106:
					return result;
					IL_22C:
					return false;
				}
				finally
				{
					num = (short)1693180828;
					short num4 = num;
					num = (short)1066591132;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_2B9:
						num = (short)1935867906;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1733230592;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_29A;
						}
						break;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_287:
						switch (num2)
						{
						case 0:
							goto IL_2EC;
						case 1:
							goto IL_2B6;
						case 2:
							disposable.Dispose();
							num = (short)631242752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29A;
					}
					IL_2B6:
					if (disposable != null)
					{
						goto IL_2B9;
					}
					IL_2EC:
					goto EndFinally_8;
					IL_29A:
					global::System.Collections.IEnumerator enumerator;
					disposable = (enumerator as global::System.IDisposable);
					num = (short)776732673;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_287;
					EndFinally_8:;
				}
				return false;
			}
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00092698 File Offset: 0x00090898
		private bool ToggleWindowState()
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::System.Windows.Window window;
					if (window.ResizeMode != global::System.Windows.ResizeMode.NoResize)
					{
						num2 = (short)536084487;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 1:
					return false;
				case 2:
					return result;
				case 3:
				{
					if (!this.SystemTitleElementsVisible)
					{
						num2 = (short)927334401;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
					goto IL_EE;
				}
				case 4:
				{
					global::System.Windows.Window window;
					if (window != null)
					{
						num2 = (short)1539964938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 5:
				{
					global::System.Windows.Window window;
					if (window.WindowState == global::System.Windows.WindowState.Maximized)
					{
						num2 = (short)828243981;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 6:
				{
					global::System.Windows.Window window;
					if (this.IsBrowserWindow(window))
					{
						return result;
					}
					num2 = (short)1243857938;
					short num3 = num2;
					num2 = (short)839042066;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EE;
					default:
						num2 = (short)870645760;
						if (num2 != 0)
						{
						}
						num2 = (short)1192689675;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					num2 = (short)1192951814;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					global::System.Windows.Window window;
					if (window.WindowState == global::System.Windows.WindowState.Normal)
					{
						num2 = (short)147849228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)83689477;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					return result;
				case 10:
					num2 = (short)1522925568;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					num2 = (short)1361379328;
					short num4 = num2;
					num2 = (short)1282211848;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
				{
					global::System.Windows.Window window;
					window.WindowState = global::System.Windows.WindowState.Maximized;
					result = true;
					num2 = (short)1338245129;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
				{
					num2 = (short)716636161;
					if (num2 != 0)
					{
					}
					global::System.Windows.Window window;
					window.WindowState = global::System.Windows.WindowState.Normal;
					result = true;
					num2 = (short)1485176834;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_48;
				IL_EE:
				num2 = (short)76021764;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_48:
			result = false;
			num2 = (short)1923350531;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00092950 File Offset: 0x00090B50
		private void SysButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			global::System.Windows.Window window;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					window.Close();
					num2 = (short)603652108;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1851326464;
					short num3 = num2;
					num2 = (short)1582170123;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (window != null)
					{
						num2 = (short)1998520321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (sender == this.m_MaxButton)
					{
						num2 = (short)1354366983;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1648230409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (sender == this.m_MinButton)
					{
						num2 = (short)278396938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1424687105;
					if (num2 != 0)
					{
					}
					num2 = (short)2049114115;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_182;
				case 6:
					goto IL_1C2;
				case 7:
					goto IL_28A;
				case 8:
					goto IL_F3;
				case 9:
					if (sender == this.m_RestoreButton)
					{
						num2 = (short)2053636102;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)87949320;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_228;
				case 11:
					if (this.IsBrowserWindow(window))
					{
						num2 = (short)295043077;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)350355460;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_1E4;
				}
				goto IL_44;
			}
			return;
			IL_182:
			return;
			IL_1C2:
			window.WindowState = global::System.Windows.WindowState.Normal;
			return;
			IL_1E4:
			return;
			IL_228:
			window.WindowState = global::System.Windows.WindowState.Minimized;
			return;
			IL_28A:
			window.WindowState = global::System.Windows.WindowState.Maximized;
			return;
			IL_44:
			window = global::System.Windows.Window.GetWindow(this);
			num2 = (short)1828246669;
			short num4 = num2;
			num2 = (short)614847629;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F3:
				if (sender == this.m_CloseButton)
				{
					num2 = (short)489881600;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)2089811968;
				if (num2 != 0)
				{
				}
				num2 = (short)1021771778;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00092BEC File Offset: 0x00090DEC
		private static global::System.Windows.Media.Effects.DropShadowEffect CreateTitleEffect()
		{
			short num = (short)252379136;
			short num2 = num;
			num = (short)1571841365;
			short num3 = num;
			num = (short)1151165781;
			switch (num3 == num)
			{
			}
			num = (short)216924161;
			if (num != 0)
			{
			}
			num = (short)1775173632;
			if (num != 0)
			{
			}
			return new global::System.Windows.Media.Effects.DropShadowEffect
			{
				ShadowDepth = 0.0,
				Color = global::System.Windows.Media.Colors.White,
				BlurRadius = 9.0,
				Opacity = 1.0
			};
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00092CD0 File Offset: 0x00090ED0
		private void LoadPanel(global::DevComponents.WpfRibbon.ContextGroupCollection contextGroupCollection)
		{
			int a_ = 15;
			short num = (short)465240064;
			switch (num)
			{
			default:
			{
				num = (short)1144389637;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Controls.Label label;
					global::System.Windows.Window window;
					global::System.Windows.UIElement uielement;
					global::System.Windows.Visibility visibility;
					switch (num2)
					{
					case 0:
					{
						num = (short)427163648;
						short num3 = num;
						num = (short)1389166594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						label.Effect = global::DevComponents.WpfRibbon.RibbonBackgroundChrome.CreateTitleEffect();
						num = (short)470482958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (contextGroupCollection == null)
						{
							num = (short)58916873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.m_TitlePanel.Children.Clear();
						global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.ContextGroup> enumerator = contextGroupCollection.GetEnumerator();
						num = (short)630587398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						label = new global::System.Windows.Controls.Label();
						label.IsHitTestVisible = false;
						label.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
						label.HorizontalContentAlignment = global::System.Windows.HorizontalAlignment.Center;
						num = (short)1412300804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.IsGlassEnabled)
						{
							num = (short)1584791564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						label.SetResourceReference(global::System.Windows.Controls.Control.ForegroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.WindowActiveTitleText));
						num = (short)494075911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 6:
						try
						{
							num = (short)1208745987;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::DevComponents.WpfRibbon.ContextGroup contextGroup;
								switch (num2)
								{
								case 0:
									((global::System.Windows.Controls.Panel)contextGroup.Parent).Children.Remove(contextGroup);
									num = (short)1739063297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1DB;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1D9;
									}
									continue;
								case 4:
									num = (short)1038942213;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_2D8;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.ContextGroup> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)510263300;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									contextGroup = enumerator.Current;
									num = (short)395116551;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									if (contextGroup.Parent is global::System.Windows.Controls.Panel)
									{
										num = (short)1219428352;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DB;
								}
								goto IL_1D9;
								IL_1DB:
								this.m_TitlePanel.Children.Add(contextGroup);
								num = (short)1764884482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_204:
								num = (short)167313414;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D9:
								goto IL_204;
							}
							IL_2D8:
							goto IL_456;
						}
						finally
						{
							num = (short)699871248;
							short num4 = num;
							num = (short)1400516624;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1132920832;
								if (num != 0)
								{
								}
								num = (short)1550778369;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.ContextGroup> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_38E;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_359;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)65863680;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_359:
									if (enumerator == null)
									{
										break;
									}
									num = (short)985333762;
									num2 = (int)((global::System.IntPtr)num);
								}
								break;
							}
							IL_38E:;
						}
						goto IL_391;
						IL_456:
						window = global::System.Windows.Window.GetWindow(this);
						num = (short)1053491208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_106;
					case 8:
						if (window != null)
						{
							num = (short)1772158979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						return;
					case 10:
						goto IL_106;
					case 11:
						uielement = label;
						if (!this.SystemTitleElementsVisible)
						{
							goto IL_391;
						}
						visibility = global::System.Windows.Visibility.Visible;
						goto IL_498;
					case 12:
						label.SetResourceReference(global::System.Windows.Controls.Control.ForegroundProperty, global::System.Windows.SystemColors.ActiveCaptionTextBrushKey);
						num = (short)1465843722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_56C;
					case 14:
						goto IL_53C;
					case 15:
						if (this.IsGlassEnabled)
						{
							num = (short)78905345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53C;
					}
					IL_8F:
					if (this.m_TitlePanel != null)
					{
						num = (short)1096941569;
						if (num != 0)
						{
						}
						num = (short)414711808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_106:
					label.SnapsToDevicePixels = true;
					label.Name = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㑦ၨᡪ㥬ٮհὲၴ㭶ᡸ᥺᡼፾", a_);
					label.FontSize = base.FontSize + 1.0;
					num = (short)88342539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_498:
					uielement.Visibility = visibility;
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㍦hὪŬ੮", a_));
					binding.Source = window;
					global::System.Windows.Data.BindingOperations.SetBinding(label, global::System.Windows.Controls.ContentControl.ContentProperty, binding);
					num = (short)1766785039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_391:
					visibility = global::System.Windows.Visibility.Collapsed;
					goto IL_498;
					IL_53C:
					this.m_TitlePanel.Children.Add(label);
					this.UpdateContextGroupGlassEffect();
					num = (short)319029261;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_56C:
				return;
			}
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000932A0 File Offset: 0x000914A0
		private void UpdateTitleLabelAppearance()
		{
			int a_ = 19;
			short num = (short)1798701056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)580845570;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.Controls.Label label;
				bool flag;
				for (;;)
				{
					global::System.Windows.Window window;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_105;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 3:
						label.SetResourceReference(global::System.Windows.Controls.Control.ForegroundProperty, global::System.Windows.SystemColors.ActiveCaptionTextBrushKey);
						window = global::System.Windows.Window.GetWindow(this);
						num = (short)1556152325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					case 5:
						if (window != null)
						{
							num = (short)970194953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						if (label == null)
						{
							num = (short)1297154060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2025193480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							num = (short)203096066;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)35782660;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_26F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_15C;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)269615112;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)286392326;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Windows.UIElement uielement;
									if (((global::System.Windows.Controls.Label)uielement).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㡪ᑬᱮ╰ᩲŴ᭶ᱸ㝺ᱼᵾ", a_))
									{
										num = (short)346947591;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_1CA;
								case 6:
								{
									global::System.Windows.UIElement uielement;
									if (uielement is global::System.Windows.Controls.Label)
									{
										num = (short)1250754560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.Windows.UIElement uielement;
									label = (global::System.Windows.Controls.Label)uielement;
									num = (short)1585446917;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1795751937;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1CF:
								num = (short)854654979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_15C:
								goto IL_1CF;
							}
							IL_1CA:
							IL_26F:
							goto IL_419;
						}
						finally
						{
							num = (short)197433050;
							short num3 = num;
							num = (short)1742313178;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_2FB:
								num = (short)709230594;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)362545152;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_2DB;
								}
								break;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2C8:
								switch (num2)
								{
								case 0:
									goto IL_32E;
								case 1:
									goto IL_2F8;
								case 2:
									disposable.Dispose();
									num = (short)2097807360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2DB;
							}
							IL_2F8:
							if (disposable != null)
							{
								goto IL_2FB;
							}
							IL_32E:
							goto EndFinally_12;
							IL_2DB:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1255604225;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2C8;
							EndFinally_12:;
						}
						goto IL_331;
						IL_419:
						num = (short)1182990342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						label.Visibility = (this.SystemTitleElementsVisible ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
						num = (short)797310986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_331;
					case 10:
					{
						num = (short)59637760;
						short num4 = num;
						if (this.IsGlassEnabled)
						{
							num = (short)1829437443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						label.Effect = null;
						label.SetResourceReference(global::System.Windows.Controls.Control.ForegroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.WindowActiveTitleText));
						num = (short)1648230400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_387;
					case 12:
						num = (short)125894660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_81:
					if (this.m_TitlePanel == null)
					{
						num = (short)1604780033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					label = null;
					enumerator = this.m_TitlePanel.Children.GetEnumerator();
					num = (short)140443655;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_331:
					flag = (window.WindowState == global::System.Windows.WindowState.Maximized);
					label.Effect = global::DevComponents.WpfRibbon.RibbonBackgroundChrome.CreateTitleEffect();
					num = (short)868286465;
					if (num != 0)
					{
					}
					num = (short)1285292043;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_105:
				return;
				IL_387:
				label.Margin = (flag ? new global::System.Windows.Thickness(0.0, 4.0, 0.0, 0.0) : default(global::System.Windows.Thickness));
				return;
			}
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000937E4 File Offset: 0x000919E4
		private void UpdateContextGroupGlassEffect()
		{
			short num = (short)1624047618;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.ContextGroup> enumerator;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					try
					{
						num = (short)1335033860;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								if (!enumerator.MoveNext())
								{
									goto IL_FB;
								}
								enumerator.Current.IsGlassEnabled = this.IsGlassEnabled;
								num = (short)1060503552;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								num = (short)1094512559;
								short num3 = num;
								num = (short)1404563375;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_FB;
								default:
									num = (short)382795776;
									if (num != 0)
									{
									}
									num = (short)825098243;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_175;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_B5;
								}
								continue;
							}
							IL_DF:
							num = (short)626458625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B5:
							goto IL_DF;
							IL_FB:
							num = (short)2002190338;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_175:
						return;
					}
					finally
					{
						num = (short)1405353986;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1302200321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1DE;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1AB;
								}
								continue;
							}
							IL_1AB:
							if (enumerator == null)
							{
								break;
							}
							num = (short)387121152;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1DE:;
					}
					goto IL_1E1;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)1494220801;
				if (num != 0)
				{
				}
				if (this.m_ConnectedCollection == null)
				{
					num = (short)668270592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1E1:
				enumerator = this.m_ConnectedCollection.GetEnumerator();
				num = (short)873988096;
				short num4 = num;
				num = (short)130023425;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00093A34 File Offset: 0x00091C34
		private bool IsBrowserWindow(global::System.Windows.Window w)
		{
			int a_ = 16;
			short num = (short)508855781;
			short num2 = num;
			num = (short)1161528805;
			switch (num2 == num)
			{
			default:
			{
				num = (short)916717568;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1433600001;
			if (num != 0)
			{
			}
			num = (short)1382350848;
			if (num != 0)
			{
			}
			return w.ToString().Contains(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㩧թͫᩭ㉯q᭳ŵ୷ό๻⥽ﾇ", a_));
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00093B00 File Offset: 0x00091D00
		internal void UpdateMinimalAppearance(bool newMin)
		{
			short num = (short)1387003916;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1332477954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)893821803;
					short num3 = num;
					num = (short)119055211;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20B;
					default:
						num = (short)2088108032;
						if (num != 0)
						{
						}
						if (this.m_WindowIcon != null)
						{
							num = (short)2092826624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
					if (this.m_WindowIcon.Visibility != global::System.Windows.Visibility.Visible)
					{
						num = (short)1797128196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					goto IL_12C;
				case 5:
					num = (short)1362821127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_20B;
				case 7:
					if (this.m_WindowIcon != null)
					{
						num = (short)945160198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					if (this.EffectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007)
					{
						num = (short)1395195909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					if (this.m_WindowIcon.Visibility != global::System.Windows.Visibility.Collapsed)
					{
						num = (short)1365508097;
						if (num != 0)
						{
						}
						num = (short)1968963595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					num = (short)203816961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					this.m_WindowIcon.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)877068291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				IL_58:
				if (newMin)
				{
					num = (short)1899757578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)485228552;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20B:
				num = (short)275120137;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12C:
			num = (short)1808728064;
			short num4 = num;
			this.m_WindowIcon.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00093D90 File Offset: 0x00091F90
		private void UpdateSystemButtonVisibility()
		{
			short num = (short)699138048;
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
				global::System.Windows.Window window;
				global::System.Windows.Visibility maximizeButtonVisibility;
				global::System.Windows.Visibility restoreButtonVisibility;
				global::System.Windows.Visibility minimizeButtonVisibility;
				global::System.Windows.Visibility closeButtonVisibility;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (window.WindowState == global::System.Windows.WindowState.Maximized)
						{
							num = (short)296288268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						maximizeButtonVisibility = global::System.Windows.Visibility.Visible;
						restoreButtonVisibility = global::System.Windows.Visibility.Collapsed;
						num = (short)5505030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						minimizeButtonVisibility = global::System.Windows.Visibility.Collapsed;
						maximizeButtonVisibility = global::System.Windows.Visibility.Collapsed;
						restoreButtonVisibility = global::System.Windows.Visibility.Collapsed;
						closeButtonVisibility = global::System.Windows.Visibility.Collapsed;
						num = (short)1189806085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (window.ResizeMode == global::System.Windows.ResizeMode.NoResize)
						{
							num = (short)1728315396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_234;
					case 3:
						goto IL_2DE;
					case 4:
						maximizeButtonVisibility = global::System.Windows.Visibility.Collapsed;
						minimizeButtonVisibility = global::System.Windows.Visibility.Collapsed;
						restoreButtonVisibility = global::System.Windows.Visibility.Collapsed;
						num = (short)271908871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_211;
					case 6:
						goto IL_2DE;
					case 7:
						goto IL_1C3;
					case 8:
						restoreButtonVisibility = global::System.Windows.Visibility.Collapsed;
						num = (short)1233059855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						if (!this.SystemTitleElementsVisible)
						{
							num = (short)1572143105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)349954034;
						short num3 = num;
						num = (short)401465330;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2DE;
						default:
							num = (short)1902182400;
							if (num != 0)
							{
							}
							num = (short)1338245131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						if (this.IsBrowserWindow(window))
						{
							num = (short)1953169416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1001062400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.IsGlassEnabled)
						{
							num = (short)956563469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)670826506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						maximizeButtonVisibility = global::System.Windows.Visibility.Collapsed;
						restoreButtonVisibility = global::System.Windows.Visibility.Visible;
						num = (short)1417543683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						minimizeButtonVisibility = global::System.Windows.Visibility.Hidden;
						maximizeButtonVisibility = global::System.Windows.Visibility.Hidden;
						restoreButtonVisibility = global::System.Windows.Visibility.Collapsed;
						closeButtonVisibility = global::System.Windows.Visibility.Hidden;
						num = (short)1665662977;
						if (num != 0)
						{
						}
						num = (short)1145503758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_385;
					case 15:
						goto IL_338;
					case 16:
						minimizeButtonVisibility = global::System.Windows.Visibility.Visible;
						maximizeButtonVisibility = global::System.Windows.Visibility.Visible;
						restoreButtonVisibility = global::System.Windows.Visibility.Visible;
						closeButtonVisibility = global::System.Windows.Visibility.Visible;
						num = (short)1563033609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (window != null)
						{
							num = (short)1180958736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38A;
					}
					goto IL_76;
					IL_2DE:
					num = (short)1975648258;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C3:
				num = (short)2045313024;
				short num4 = num;
				IL_211:
				IL_234:
				this.MaximizeButtonVisibility = maximizeButtonVisibility;
				this.RestoreButtonVisibility = restoreButtonVisibility;
				this.MinimizeButtonVisibility = minimizeButtonVisibility;
				this.CloseButtonVisibility = closeButtonVisibility;
				return;
				IL_338:
				IL_385:
				goto IL_234;
				IL_38A:
				this.MaximizeButtonVisibility = global::System.Windows.Visibility.Collapsed;
				this.RestoreButtonVisibility = global::System.Windows.Visibility.Collapsed;
				this.MinimizeButtonVisibility = global::System.Windows.Visibility.Collapsed;
				this.CloseButtonVisibility = global::System.Windows.Visibility.Collapsed;
				return;
				IL_76:
				window = global::System.Windows.Window.GetWindow(this);
				num = (short)1644691473;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00094144 File Offset: 0x00092344
		private void ContextGroupsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1190773872;
			short num2 = num;
			num = (short)2035467376;
			switch (num2 == num)
			{
			default:
			{
				num = (short)764280832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)385417217;
			if (num != 0)
			{
			}
			num = (short)1813053440;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ContextGroupCollection contextGroupCollection = sender as global::DevComponents.WpfRibbon.ContextGroupCollection;
			this.LoadPanel(contextGroupCollection);
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x000941FC File Offset: 0x000923FC
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x000942B8 File Offset: 0x000924B8
		public global::System.Windows.GridLength QatRightPosition
		{
			get
			{
				short num = (short)1237773718;
				short num2 = num;
				num = (short)1296428438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)415891456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1365901313;
				if (num != 0)
				{
				}
				num = (short)1126170624;
				if (num != 0)
				{
				}
				return (global::System.Windows.GridLength)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.QatRightPositionProperty);
			}
			set
			{
				short num = (short)216072193;
				if (num != 0)
				{
				}
				num = (short)1907490816;
				short num2 = num;
				num = (short)990409601;
				short num3 = num;
				num = (short)898134913;
				switch (num3 == num)
				{
				}
				num = (short)1330642944;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.QatRightPositionProperty, value);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00094374 File Offset: 0x00092574
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x0009442C File Offset: 0x0009262C
		public bool IsActive
		{
			get
			{
				short num = (short)131637573;
				short num2 = num;
				num = (short)502047045;
				switch (num2 == num)
				{
				default:
				{
					num = (short)574947328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)883163136;
				if (num != 0)
				{
				}
				num = (short)947978241;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.IsActiveProperty);
			}
			set
			{
				short num = (short)353702398;
				short num2 = num;
				num = (short)684331518;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1199570944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1680343041;
				if (num != 0)
				{
				}
				num = (short)1279590400;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.IsActiveProperty, value);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x000944E8 File Offset: 0x000926E8
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x000945A4 File Offset: 0x000927A4
		public global::System.Windows.WindowState WindowState
		{
			get
			{
				short num = (short)840455125;
				short num2 = num;
				num = (short)303322069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1371340800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1710424065;
				if (num != 0)
				{
				}
				num = (short)1535574016;
				if (num != 0)
				{
				}
				return (global::System.Windows.WindowState)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.WindowStateProperty);
			}
			set
			{
				short num = (short)2102789622;
				short num2 = num;
				num = (short)1153828342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1044447232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)806813697;
				if (num != 0)
				{
				}
				num = (short)126025728;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.WindowStateProperty, value);
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00094660 File Offset: 0x00092860
		private static void WindowStateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)989312996;
			short num2 = num;
			num = (short)1011202020;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2001403904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)256245760;
			if (num != 0)
			{
			}
			num = (short)1605435393;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.RibbonBackgroundChrome)d).OnWindowStateChanged();
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00094710 File Offset: 0x00092910
		private void OnWindowStateChanged()
		{
			short num = (short)820511250;
			short num2 = num;
			num = (short)2045575698;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1063387136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)171835392;
			if (num != 0)
			{
			}
			num = (short)449970177;
			if (num != 0)
			{
			}
			this.UpdateSystemButtonVisibility();
			this.UpdateTitleLabelAppearance();
			this.UpdateTotalChromeHeight();
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000947D0 File Offset: 0x000929D0
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00094888 File Offset: 0x00092A88
		public bool IsGlassEnabled
		{
			get
			{
				short num = (short)1163360042;
				short num2 = num;
				num = (short)1438545706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1000538112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1525481473;
				if (num != 0)
				{
				}
				num = (short)1184628736;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.IsGlassEnabledProperty);
			}
			set
			{
				short num = (short)99784130;
				short num2 = num;
				num = (short)1592759746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2085879808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1294991360;
				if (num != 0)
				{
				}
				num = (short)787087361;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.IsGlassEnabledProperty, value);
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00094944 File Offset: 0x00092B44
		private static void IsGlassEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1779394819;
			short num2 = num;
			num = (short)1293248771;
			switch (num2 == num)
			{
			default:
			{
				num = (short)696385536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1947271168;
			if (num != 0)
			{
			}
			num = (short)999424001;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.RibbonBackgroundChrome)d).OnIsGlassEnabledChanged();
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000949F8 File Offset: 0x00092BF8
		private void OnIsGlassEnabledChanged()
		{
			short num = (short)1860385409;
			short num2 = num;
			num = (short)1104296577;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2011955200;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1818755073;
			if (num != 0)
			{
			}
			num = (short)178454528;
			if (num != 0)
			{
			}
			this.UpdateSystemButtonVisibility();
			this.UpdateTitleLabelAppearance();
			this.UpdateContextGroupGlassEffect();
			this.TitleChromeHeight = (double)this.GetSystemCaptionHeight();
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00094AC0 File Offset: 0x00092CC0
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00094B7C File Offset: 0x00092D7C
		public double TitleChromeHeight
		{
			get
			{
				short num = (short)453318153;
				short num2 = num;
				num = (short)89069065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)75563008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)224002049;
				if (num != 0)
				{
				}
				num = (short)1544617984;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.TitleChromeHeightProperty);
			}
			set
			{
				short num = (short)2134799835;
				short num2 = num;
				num = (short)1715172827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)745209856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)446169089;
				if (num != 0)
				{
				}
				num = (short)1362296832;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.TitleChromeHeightProperty, value);
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00094C3C File Offset: 0x00092E3C
		private static void OnTitleChromeHeightChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1069628189;
			short num2 = num;
			num = (short)2103524125;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1916403712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1367277569;
			if (num != 0)
			{
			}
			num = (short)618528768;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.RibbonBackgroundChrome)d).OnTitleChromeHeightChanged((double)e.NewValue);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00094CF8 File Offset: 0x00092EF8
		private void OnTitleChromeHeightChanged(double d)
		{
			short num = (short)323223553;
			if (num != 0)
			{
			}
			num = (short)372637696;
			short num2 = num;
			num = (short)1708708523;
			short num3 = num;
			num = (short)56808107;
			switch (num3 == num)
			{
			}
			num = (short)871038976;
			if (num != 0)
			{
			}
			this.UpdateTotalChromeHeight();
			this.UpdateTitlePanelChromeHeight();
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00094DB0 File Offset: 0x00092FB0
		private void UpdateTitlePanelChromeHeight()
		{
			short num = (short)1781268483;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1116405761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1475061530;
					short num3 = num;
					num = (short)1803200282;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_40;
					default:
					{
						num = (short)1739980800;
						if (num != 0)
						{
						}
						num = (short)910622720;
						short num4 = num;
						this.m_TitlePanel.TitleChromeHeight = this.TotalTitleChromeHeight - (double)(this.IsGlassEnabled ? 1 : 0);
						this.m_TitlePanel.Margin = new global::System.Windows.Thickness(0.0, this.WindowBorderThickness.Top, 0.0, 0.0);
						num = (short)1404567553;
						if (num != 0)
						{
						}
						num = (short)1074724866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				goto IL_35;
				IL_40:
				num = (short)1614675968;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35:
				if (this.m_TitlePanel != null)
				{
					goto IL_40;
				}
				break;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00094F38 File Offset: 0x00093138
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00094FF0 File Offset: 0x000931F0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public double TotalTitleChromeHeight
		{
			get
			{
				short num = (short)41196022;
				short num2 = num;
				num = (short)184064502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)157155328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1808400385;
				if (num != 0)
				{
				}
				num = (short)1718222848;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.TotalTitleChromeHeightProperty);
			}
			internal set
			{
				short num = (short)385794000;
				short num2 = num;
				num = (short)410370000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1334575104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1117323265;
				if (num != 0)
				{
				}
				num = (short)2134048768;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.TotalTitleChromeHeightPropertyKey, value);
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000950AC File Offset: 0x000932AC
		private void UpdateTotalChromeHeight()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			double num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)531786379;
					short num3 = num2;
					num2 = (short)692284043;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_178;
					default:
						goto IL_EC;
					}
					break;
				}
				case 1:
				{
					global::System.Windows.Window window;
					if (window.WindowState == global::System.Windows.WindowState.Maximized)
					{
						num2 = (short)1038680067;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B0;
				}
				case 2:
				{
					num2 = (short)2027028481;
					if (num2 != 0)
					{
					}
					num2 = (short)641073152;
					short num4 = num2;
					global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
					goto IL_178;
				}
				case 3:
					num5 = global::DevComponents.WpfRibbon.RibbonWindow.MaximizedGlassTopAdjustment;
					num2 = (short)110034944;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::System.Windows.Window window;
					if (window != null)
					{
						num2 = (short)962396165;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B0;
				}
				case 5:
					num2 = (short)866451457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (this.IsGlassEnabled)
					{
						num2 = (short)1439694850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B0;
				}
				goto IL_2C;
				IL_178:
				num2 = (short)648871940;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_EC:
			num2 = (short)1051590656;
			if (num2 != 0)
			{
			}
			IL_1B0:
			this.TotalTitleChromeHeight = this.TitleChromeHeight + this.WindowBorderThickness.Top + num5;
			return;
			IL_2C:
			num5 = 0.0;
			num2 = (short)294977542;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00095288 File Offset: 0x00093488
		private static void OnQatRightPositionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)139060176;
			short num2 = num;
			num = (short)1318708176;
			switch (num2 == num)
			{
			default:
			{
				num = (short)589824000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)10878977;
			if (num != 0)
			{
			}
			num = (short)1563361280;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.RibbonBackgroundChrome)d).OnQatRightPositionChanged((global::System.Windows.GridLength)e.NewValue);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00095348 File Offset: 0x00093548
		private void OnQatRightPositionChanged(global::System.Windows.GridLength p)
		{
			short num = (short)1414332417;
			if (num != 0)
			{
			}
			num = (short)1901330434;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BF;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				IL_58:
				num = (short)1236351527;
				short num3 = num;
				num = (short)584137255;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_BF:
					num = (short)137822208;
					short num4 = num;
					this.m_TitlePanel.QatRightPosition = p.Value;
					num = (short)1958019073;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)161873920;
					if (num != 0)
					{
					}
					if (this.m_TitlePanel == null)
					{
						return;
					}
					num = (short)1547304960;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00095468 File Offset: 0x00093668
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00095518 File Offset: 0x00093718
		internal double TabXPosition
		{
			get
			{
				short num = (short)412667762;
				short num2 = num;
				num = (short)1578225522;
				switch (num2 == num)
				{
				}
				num = (short)2138374145;
				if (num != 0)
				{
				}
				num = (short)1579876352;
				if (num != 0)
				{
				}
				num = (short)227016704;
				short num3 = num;
				return this.m_TabXPosition;
			}
			set
			{
				short num = (short)1866268672;
				short num2 = num;
				num = (short)279906037;
				short num3 = num;
				num = (short)1627522805;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_FC:
					num = (short)690814977;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1010761728;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8F;
					}
					break;
				}
				for (;;)
				{
					IL_7D:
					switch (num4)
					{
					case 0:
						if (this.m_TitlePanel != null)
						{
							num = (short)1822752770;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						goto IL_C7;
					}
					goto IL_8F;
				}
				IL_C7:
				num = (short)1988231169;
				if (num != 0)
				{
				}
				this.m_TitlePanel.TabXPosition = value;
				goto IL_FC;
				IL_8F:
				this.m_TabXPosition = value;
				num = (short)629211136;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x0009563C File Offset: 0x0009383C
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x000956F8 File Offset: 0x000938F8
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Visibility CloseButtonVisibility
		{
			get
			{
				short num = (short)760502372;
				short num2 = num;
				num = (short)1831229540;
				switch (num2 == num)
				{
				}
				num = (short)108134401;
				if (num != 0)
				{
				}
				num = (short)1026752512;
				if (num != 0)
				{
				}
				num = (short)359792640;
				short num3 = num;
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.CloseButtonVisibilityProperty);
			}
			set
			{
				short num = (short)164950172;
				short num2 = num;
				num = (short)77918364;
				switch (num2 == num)
				{
				}
				num = (short)1119617025;
				if (num != 0)
				{
				}
				num = (short)1289486336;
				if (num != 0)
				{
				}
				num = (short)520552448;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.CloseButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x000957B4 File Offset: 0x000939B4
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x0009586C File Offset: 0x00093A6C
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Visibility RestoreButtonVisibility
		{
			get
			{
				short num = (short)1665232015;
				short num2 = num;
				num = (short)1039756431;
				switch (num2 == num)
				{
				}
				num = (short)699072513;
				if (num != 0)
				{
				}
				num = (short)284360704;
				if (num != 0)
				{
				}
				num = (short)995557376;
				short num3 = num;
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.RestoreButtonVisibilityProperty);
			}
			set
			{
				short num = (short)959512577;
				if (num != 0)
				{
				}
				num = (short)1080593291;
				short num2 = num;
				num = (short)127765387;
				switch (num2 == num)
				{
				}
				num = (short)805371904;
				if (num != 0)
				{
				}
				num = (short)1933312000;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.RestoreButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00095928 File Offset: 0x00093B28
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x000959E4 File Offset: 0x00093BE4
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Visibility MinimizeButtonVisibility
		{
			get
			{
				short num = (short)1236770247;
				short num2 = num;
				num = (short)2023005639;
				switch (num2 == num)
				{
				}
				num = (short)966787073;
				if (num != 0)
				{
				}
				num = (short)886308864;
				if (num != 0)
				{
				}
				num = (short)634978304;
				short num3 = num;
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.MinimizeButtonVisibilityProperty);
			}
			set
			{
				short num = (short)1875000820;
				short num2 = num;
				num = (short)1320697332;
				switch (num2 == num)
				{
				}
				num = (short)1138163712;
				if (num != 0)
				{
				}
				num = (short)48496641;
				if (num != 0)
				{
				}
				num = (short)528154624;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.MinimizeButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00095AA0 File Offset: 0x00093CA0
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00095B58 File Offset: 0x00093D58
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Visibility MaximizeButtonVisibility
		{
			get
			{
				short num = (short)623626163;
				short num2 = num;
				num = (short)487573427;
				switch (num2 == num)
				{
				}
				num = (short)514719744;
				if (num != 0)
				{
				}
				num = (short)82837505;
				if (num != 0)
				{
				}
				num = (short)452132864;
				short num3 = num;
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.MaximizeButtonVisibilityProperty);
			}
			set
			{
				short num = (short)1176393974;
				short num2 = num;
				num = (short)1782143222;
				switch (num2 == num)
				{
				}
				num = (short)1691942913;
				if (num != 0)
				{
				}
				num = (short)547553280;
				if (num != 0)
				{
				}
				num = (short)2026569728;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.MaximizeButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00095C14 File Offset: 0x00093E14
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00095CC8 File Offset: 0x00093EC8
		public global::System.Windows.Thickness WindowBorderThickness
		{
			get
			{
				short num = (short)988739033;
				short num2 = num;
				num = (short)1328674265;
				switch (num2 == num)
				{
				}
				num = (short)898498561;
				if (num != 0)
				{
				}
				num = (short)1841037312;
				if (num != 0)
				{
				}
				num = (short)37748736;
				short num3 = num;
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.WindowBorderThicknessProperty);
			}
			set
			{
				short num = (short)1527333245;
				short num2 = num;
				num = (short)1531658621;
				switch (num2 == num)
				{
				}
				num = (short)702349313;
				if (num != 0)
				{
				}
				num = (short)1554513920;
				if (num != 0)
				{
				}
				num = (short)625082368;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.WindowBorderThicknessProperty, value);
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00095D84 File Offset: 0x00093F84
		private static void WindowBorderThicknessChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1923513751;
			short num2 = num;
			num = (short)565345687;
			switch (num2 == num)
			{
			}
			num = (short)1568276480;
			if (num != 0)
			{
			}
			num = (short)1636499457;
			if (num != 0)
			{
			}
			num = (short)2131165184;
			short num3 = num;
			((global::DevComponents.WpfRibbon.RibbonBackgroundChrome)d).OnWindowBorderThicknessChanged((global::System.Windows.Thickness)e.NewValue);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00095E44 File Offset: 0x00094044
		private void OnWindowBorderThicknessChanged(global::System.Windows.Thickness t)
		{
			short num = (short)397969058;
			short num2 = num;
			num = (short)131368610;
			switch (num2 == num)
			{
			}
			num = (short)601817089;
			if (num != 0)
			{
			}
			num = (short)1149042688;
			if (num != 0)
			{
			}
			num = (short)50724864;
			short num3 = num;
			this.UpdateTotalChromeHeight();
			this.UpdateTitlePanelChromeHeight();
			this.HorizontalWindowBorderThickness = new global::System.Windows.Thickness(t.Left, 0.0, t.Right, 0.0);
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00095F24 File Offset: 0x00094124
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00095FDC File Offset: 0x000941DC
		public global::System.Windows.Thickness HorizontalWindowBorderThickness
		{
			get
			{
				short num = (short)619773953;
				if (num != 0)
				{
				}
				num = (short)894225388;
				short num2 = num;
				num = (short)1942997996;
				switch (num2 == num)
				{
				}
				num = (short)1986199552;
				if (num != 0)
				{
				}
				num = (short)1352794112;
				short num3 = num;
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.HorizontalWindowBorderThicknessProperty);
			}
			internal set
			{
				short num = (short)994459040;
				short num2 = num;
				num = (short)1307524512;
				switch (num2 == num)
				{
				}
				num = (short)1146224641;
				if (num != 0)
				{
				}
				num = (short)245039104;
				if (num != 0)
				{
				}
				num = (short)2071199744;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.HorizontalWindowBorderThicknessPropertyKey, value);
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00096098 File Offset: 0x00094298
		private int GetSystemCaptionHeight()
		{
			short num = (short)2015882187;
			short num2 = num;
			num = (short)156167115;
			switch (num2 == num)
			{
			}
			num = (short)1945108480;
			if (num != 0)
			{
			}
			num = (short)1015939073;
			if (num != 0)
			{
			}
			num = (short)757137408;
			short num3 = num;
			return 28;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00096144 File Offset: 0x00094344
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00096200 File Offset: 0x00094400
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool SystemButtons
		{
			get
			{
				short num = (short)1271596680;
				short num2 = num;
				num = (short)1565787784;
				switch (num2 == num)
				{
				}
				num = (short)499712000;
				if (num != 0)
				{
				}
				num = (short)2123169793;
				if (num != 0)
				{
				}
				num = (short)1689387008;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.SystemButtonsProperty);
			}
			set
			{
				short num = (short)1988873543;
				short num2 = num;
				num = (short)1784728903;
				switch (num2 == num)
				{
				}
				num = (short)339017729;
				if (num != 0)
				{
				}
				num = (short)1766064128;
				if (num != 0)
				{
				}
				num = (short)938475520;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBackgroundChrome.SystemButtonsProperty, value);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000962BC File Offset: 0x000944BC
		private static void OnSystemButtonsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1304680976;
			short num2 = num;
			num = (short)184343056;
			switch (num2 == num)
			{
			}
			num = (short)2067529729;
			if (num != 0)
			{
			}
			num = (short)266862592;
			if (num != 0)
			{
			}
			num = (short)1793392640;
			short num3 = num;
			((global::DevComponents.WpfRibbon.RibbonBackgroundChrome)d).OnSystemButtonsChanged();
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00096370 File Offset: 0x00094570
		private void OnSystemButtonsChanged()
		{
			short num = (short)1822709968;
			short num2 = num;
			num = (short)334256336;
			switch (num2 == num)
			{
			}
			num = (short)746389505;
			if (num != 0)
			{
			}
			num = (short)786432000;
			if (num != 0)
			{
			}
			num = (short)132841472;
			short num3 = num;
			this.UpdateSystemButtonVisibility();
			this.UpdateTitleLabelAppearance();
		}

		// Token: 0x04000300 RID: 768
		public static readonly global::System.Windows.DependencyProperty VisualStyleProperty;

		// Token: 0x04000301 RID: 769
		private static readonly global::System.Windows.DependencyPropertyKey EffectiveStylePropertyKey;

		// Token: 0x04000302 RID: 770
		public static readonly global::System.Windows.DependencyProperty EffectiveStyleProperty;

		// Token: 0x04000303 RID: 771
		public static readonly global::System.Windows.DependencyProperty QatRightPositionProperty;

		// Token: 0x04000304 RID: 772
		public static readonly global::System.Windows.DependencyProperty TitleChromeHeightProperty;

		// Token: 0x04000305 RID: 773
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty;

		// Token: 0x04000306 RID: 774
		public static readonly global::System.Windows.DependencyProperty WindowStateProperty;

		// Token: 0x04000307 RID: 775
		public static readonly global::System.Windows.DependencyProperty CloseButtonVisibilityProperty;

		// Token: 0x04000308 RID: 776
		public static readonly global::System.Windows.DependencyProperty RestoreButtonVisibilityProperty;

		// Token: 0x04000309 RID: 777
		public static readonly global::System.Windows.DependencyProperty MinimizeButtonVisibilityProperty;

		// Token: 0x0400030A RID: 778
		public static readonly global::System.Windows.DependencyProperty MaximizeButtonVisibilityProperty;

		// Token: 0x0400030B RID: 779
		public static readonly global::System.Windows.DependencyProperty WindowBorderThicknessProperty;

		// Token: 0x0400030C RID: 780
		public static readonly global::System.Windows.DependencyProperty IsGlassEnabledProperty;

		// Token: 0x0400030D RID: 781
		public static readonly global::System.Windows.DependencyProperty SystemButtonsProperty;

		// Token: 0x0400030E RID: 782
		public static readonly global::System.Windows.DependencyProperty TotalTitleChromeHeightProperty;

		// Token: 0x0400030F RID: 783
		private static readonly global::System.Windows.DependencyPropertyKey TotalTitleChromeHeightPropertyKey;

		// Token: 0x04000310 RID: 784
		public static readonly global::System.Windows.DependencyProperty HorizontalWindowBorderThicknessProperty;

		// Token: 0x04000311 RID: 785
		private static readonly global::System.Windows.DependencyPropertyKey HorizontalWindowBorderThicknessPropertyKey;

		// Token: 0x04000312 RID: 786
		private global::DevComponents.WpfRibbon.TitlePanel m_TitlePanel;

		// Token: 0x04000313 RID: 787
		private global::DevComponents.WpfRibbon.ContextGroupCollection m_ConnectedCollection;

		// Token: 0x04000314 RID: 788
		private double m_TabXPosition;

		// Token: 0x04000315 RID: 789
		private global::System.Windows.Controls.Button m_MinButton;

		// Token: 0x04000316 RID: 790
		private global::System.Windows.Controls.Button m_MaxButton;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.Controls.Button m_CloseButton;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Controls.Button m_RestoreButton;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Controls.Image m_WindowIcon;

		// Token: 0x0400031A RID: 794
		private const string TitleBarElementName = "TitleBar";

		// Token: 0x0400031B RID: 795
		private const string TitleLabelName = "SysTitleLabel";
	}
}
