using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000076 RID: 118
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RibbonBorder : global::System.Windows.Controls.Decorator
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x0009BE4C File Offset: 0x0009A04C
		static RibbonBorder()
		{
			int a_ = 17;
			short num = (short)1816199168;
			short num2 = num;
			num = (short)2107441153;
			if (num != 0)
			{
			}
			num = (short)298315364;
			short num3 = num;
			num = (short)2024926820;
			switch (num3 == num)
			{
			}
			num = (short)13303808;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonBorder.PaddingProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㥨੪६୮ᡰᵲቴ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.RibbonBorder.IsThicknessValid));
			global::DevComponents.WpfRibbon.RibbonBorder.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭨ѪὬ୮ᑰŲ㝴ն౸ࡺᕼ", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.RibbonBorder.BackgroundProperty = global::System.Windows.Controls.Panel.BackgroundProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.RibbonBorder.LightBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("╨ɪ੬ݮհㅲᩴնᵸṺོ㵾", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.RibbonBorder.CornerRadiusProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩨ѪὬŮᑰŲ❴ᙶᵸቺࡼ౾", a_), typeof(global::System.Windows.CornerRadius), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.CornerRadius(0.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.RibbonBorder.IsCornerRadiusValid));
			global::DevComponents.WpfRibbon.RibbonBorder.ColorClassProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩨ѪŬnͰひᥴᙶ੸ࡺ", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.RibbonColors.RibbonBarClass, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBorder.OnColorClassChanged)));
			global::DevComponents.WpfRibbon.RibbonBorder.BorderStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭨ѪὬ୮ᑰŲ♴Ͷᡸེ᡼", a_), typeof(global::DevComponents.WpfRibbon.eRibbonBarRenderingState), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Normal, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonBorder.OnRibbonBarStateChanged)));
			global::DevComponents.WpfRibbon.RibbonBorder.TopHighlightProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㵨Ѫᵬ❮ᡰᑲᵴ᭶ၸᱺᕼ୾", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.RibbonBorder.BorderThicknessProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭨ѪὬ୮ᑰŲⅴὶၸ᡺ᙼᅾ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Thickness(0.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.RibbonBorder.IsThicknessValid));
			global::DevComponents.WpfRibbon.RibbonBorder.LightBorderThicknessProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("╨ɪ੬ݮհㅲᩴնᵸṺོ⭾ﺌﲎ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Thickness(0.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.RibbonBorder.IsThicknessValid));
			global::DevComponents.WpfRibbon.RibbonBorder.InnerBorderProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⁨ժͬ੮ͰㅲᩴնᵸṺོ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfRibbon.RibbonBorder.AutoAnimationProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⡨Ṫᥬnばᵲᱴ᩶ᡸེᑼၾ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfRibbon.RibbonBorder.IsRibbonPanelProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⁨ᡪ㽬ٮ፰ᅲᩴ᥶⥸᩺፼᩾", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.RibbonBorder), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0009C244 File Offset: 0x0009A444
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x0009C2F0 File Offset: 0x0009A4F0
		internal global::System.Windows.Rect SelectedTabRect
		{
			get
			{
				short num = (short)2127167488;
				short num2 = num;
				num = (short)655756787;
				short num3 = num;
				num = (short)1203703283;
				switch (num3 == num)
				{
				}
				num = (short)1319305216;
				if (num != 0)
				{
				}
				num = (short)543293441;
				if (num != 0)
				{
				}
				return this.m_SelectedTabRect;
			}
			set
			{
				short num = (short)1124466688;
				short num2 = num;
				num = (short)1005185734;
				short num3 = num;
				num = (short)557181638;
				switch (num3 == num)
				{
				}
				num = (short)1175846912;
				if (num != 0)
				{
				}
				num = (short)1003421697;
				if (num != 0)
				{
				}
				this.m_SelectedTabRect = value;
				base.InvalidateVisual();
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0009C3A8 File Offset: 0x0009A5A8
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0009C460 File Offset: 0x0009A660
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IsRibbonPanel
		{
			get
			{
				short num = (short)1349124096;
				short num2 = num;
				num = (short)984285185;
				if (num != 0)
				{
				}
				num = (short)587215135;
				short num3 = num;
				num = (short)1182609695;
				switch (num3 == num)
				{
				}
				num = (short)808976384;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.IsRibbonPanelProperty);
			}
			set
			{
				short num = (short)1472994385;
				short num2 = num;
				num = (short)1019878481;
				switch (num2 == num)
				{
				}
				num = (short)701825024;
				short num3 = num;
				num = (short)2030108673;
				if (num != 0)
				{
				}
				num = (short)354680832;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.IsRibbonPanelProperty, value);
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0009C518 File Offset: 0x0009A718
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x0009C5D8 File Offset: 0x0009A7D8
		[global::System.ComponentModel.DefaultValue(true)]
		public bool InnerBorder
		{
			get
			{
				short num = (short)4822464;
				short num2 = num;
				num = (short)1959826880;
				switch (num2 == num)
				{
				}
				num = (short)1348993024;
				short num3 = num;
				num = (short)97779713;
				if (num != 0)
				{
				}
				num = (short)332398592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.InnerBorderProperty);
			}
			set
			{
				short num = (short)686983858;
				short num2 = num;
				num = (short)1735690930;
				switch (num2 == num)
				{
				}
				num = (short)671612928;
				short num3 = num;
				num = (short)709230593;
				if (num != 0)
				{
				}
				num = (short)1069088768;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.InnerBorderProperty, value);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0009C694 File Offset: 0x0009A894
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x0009C74C File Offset: 0x0009A94C
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AutoAnimation
		{
			get
			{
				short num = (short)1127367639;
				short num2 = num;
				num = (short)1978221527;
				switch (num2 == num)
				{
				}
				num = (short)839778304;
				short num3 = num;
				num = (short)795017216;
				if (num != 0)
				{
				}
				num = (short)2118320129;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.AutoAnimationProperty);
			}
			set
			{
				short num = (short)688914433;
				if (num != 0)
				{
				}
				num = (short)525660746;
				short num2 = num;
				num = (short)1508176458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1291190272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1237975040;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.AutoAnimationProperty, value);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0009C808 File Offset: 0x0009AA08
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x0009C8C4 File Offset: 0x0009AAC4
		public global::System.Windows.Thickness BorderThickness
		{
			get
			{
				short num = (short)837353473;
				if (num != 0)
				{
				}
				num = (short)2104138417;
				short num2 = num;
				num = (short)74619569;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1365311488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)71761920;
				if (num != 0)
				{
				}
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.BorderThicknessProperty);
			}
			set
			{
				short num = (short)1073333301;
				short num2 = num;
				num = (short)1663484981;
				switch (num2 == num)
				{
				}
				num = (short)561971200;
				short num3 = num;
				num = (short)2103115777;
				if (num != 0)
				{
				}
				num = (short)1187840000;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.BorderThicknessProperty, value);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0009C980 File Offset: 0x0009AB80
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0009CA38 File Offset: 0x0009AC38
		public global::System.Windows.Thickness LightBorderThickness
		{
			get
			{
				short num = (short)1289581485;
				short num2 = num;
				num = (short)1150972845;
				switch (num2 == num)
				{
				}
				num = (short)605945856;
				short num3 = num;
				num = (short)2041774081;
				if (num != 0)
				{
				}
				num = (short)209453056;
				if (num != 0)
				{
				}
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.LightBorderThicknessProperty);
			}
			set
			{
				short num = (short)1397829147;
				short num2 = num;
				num = (short)215821851;
				switch (num2 == num)
				{
				}
				num = (short)2006188032;
				short num3 = num;
				num = (short)2069889025;
				if (num != 0)
				{
				}
				num = (short)1171652608;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.LightBorderThicknessProperty, value);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0009CAF0 File Offset: 0x0009ACF0
		private static bool IsThicknessValid(object value)
		{
			short num = (short)444649958;
			short num2 = num;
			num = (short)1948570086;
			switch (num2 == num)
			{
			}
			num = (short)789905408;
			short num3 = num;
			num = (short)393150465;
			if (num != 0)
			{
			}
			num = (short)942211072;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.LayoutHelpers.IsThicknessValid(value);
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0009CBA0 File Offset: 0x0009ADA0
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x0009CC58 File Offset: 0x0009AE58
		[global::System.ComponentModel.DefaultValue(global::DevComponents.WpfRibbon.eButtonRenderingState.Normal)]
		public global::DevComponents.WpfRibbon.eRibbonBarRenderingState BorderState
		{
			get
			{
				short num = (short)424542209;
				if (num != 0)
				{
				}
				num = (short)1879364897;
				short num2 = num;
				num = (short)1460655393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)304676864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)784990208;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eRibbonBarRenderingState)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.BorderStateProperty);
			}
			set
			{
				short num = (short)688645490;
				short num2 = num;
				num = (short)128902514;
				switch (num2 == num)
				{
				}
				num = (short)845545472;
				short num3 = num;
				num = (short)324599809;
				if (num != 0)
				{
				}
				num = (short)1668218880;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.BorderStateProperty, value);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x0009CD14 File Offset: 0x0009AF14
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x0009CDCC File Offset: 0x0009AFCC
		public string ColorClass
		{
			get
			{
				short num = (short)1989617046;
				short num2 = num;
				num = (short)79766934;
				switch (num2 == num)
				{
				}
				num = (short)974454784;
				short num3 = num;
				num = (short)627507201;
				if (num != 0)
				{
				}
				num = (short)2065301504;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.ColorClassProperty);
			}
			set
			{
				short num = (short)589234177;
				if (num != 0)
				{
				}
				num = (short)25185318;
				short num2 = num;
				num = (short)58608678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)236847104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661061632;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.ColorClassProperty, value);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x0009CE84 File Offset: 0x0009B084
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x0009CF40 File Offset: 0x0009B140
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.CornerRadiusConverter))]
		public global::System.Windows.CornerRadius CornerRadius
		{
			get
			{
				short num = (short)16120917;
				short num2 = num;
				num = (short)119667797;
				switch (num2 == num)
				{
				}
				num = (short)835649536;
				short num3 = num;
				num = (short)2048851968;
				if (num != 0)
				{
				}
				num = (short)1019871233;
				if (num != 0)
				{
				}
				return (global::System.Windows.CornerRadius)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.CornerRadiusProperty);
			}
			set
			{
				short num = (short)644846585;
				short num2 = num;
				num = (short)652645369;
				switch (num2 == num)
				{
				}
				num = (short)1272381440;
				short num3 = num;
				num = (short)2018115584;
				if (num != 0)
				{
				}
				num = (short)454361089;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.CornerRadiusProperty, value);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0009CFF8 File Offset: 0x0009B1F8
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x0009D0B0 File Offset: 0x0009B2B0
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush Background
		{
			get
			{
				short num = (short)353943997;
				short num2 = num;
				num = (short)272351677;
				switch (num2 == num)
				{
				}
				num = (short)1484193792;
				short num3 = num;
				num = (short)1703149568;
				if (num != 0)
				{
				}
				num = (short)1777336321;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.BackgroundProperty);
			}
			set
			{
				short num = (short)702441970;
				short num2 = num;
				num = (short)381512178;
				switch (num2 == num)
				{
				}
				num = (short)302972928;
				short num3 = num;
				num = (short)427360257;
				if (num != 0)
				{
				}
				num = (short)1117978624;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.BackgroundProperty, value);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0009D164 File Offset: 0x0009B364
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x0009D21C File Offset: 0x0009B41C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)767238607;
				short num2 = num;
				num = (short)1498948047;
				switch (num2 == num)
				{
				}
				num = (short)1474494464;
				short num3 = num;
				num = (short)2145583104;
				if (num != 0)
				{
				}
				num = (short)762970113;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.BorderBrushProperty);
			}
			set
			{
				short num = (short)1632960513;
				if (num != 0)
				{
				}
				num = (short)106269162;
				short num2 = num;
				num = (short)388860394;
				switch (num2 == num)
				{
				default:
				{
					num = (short)452591616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1794375680;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.BorderBrushProperty, value);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x0009D2D4 File Offset: 0x0009B4D4
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x0009D38C File Offset: 0x0009B58C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush TopHighlight
		{
			get
			{
				short num = (short)2022918177;
				short num2 = num;
				num = (short)1598113825;
				switch (num2 == num)
				{
				}
				num = (short)392953856;
				short num3 = num;
				num = (short)315621376;
				if (num != 0)
				{
				}
				num = (short)1403453441;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.TopHighlightProperty);
			}
			set
			{
				short num = (short)740197856;
				short num2 = num;
				num = (short)693798368;
				switch (num2 == num)
				{
				}
				num = (short)911278080;
				short num3 = num;
				num = (short)62849025;
				if (num != 0)
				{
				}
				num = (short)671285248;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.TopHighlightProperty, value);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0009D43C File Offset: 0x0009B63C
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x0009D4F8 File Offset: 0x0009B6F8
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush LightBorderBrush
		{
			get
			{
				short num = (short)831870496;
				short num2 = num;
				num = (short)191256096;
				switch (num2 == num)
				{
				}
				num = (short)865599488;
				short num3 = num;
				num = (short)2118975488;
				if (num != 0)
				{
				}
				num = (short)2007302145;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.LightBorderBrushProperty);
			}
			set
			{
				short num = (short)1130372134;
				short num2 = num;
				num = (short)327556134;
				switch (num2 == num)
				{
				}
				num = (short)511967232;
				short num3 = num;
				num = (short)923664384;
				if (num != 0)
				{
				}
				num = (short)97320961;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.LightBorderBrushProperty, value);
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x0009D5AC File Offset: 0x0009B7AC
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x0009D668 File Offset: 0x0009B868
		public global::System.Windows.Thickness Padding
		{
			get
			{
				short num = (short)1191056963;
				short num2 = num;
				num = (short)2135823939;
				switch (num2 == num)
				{
				}
				num = (short)700973056;
				short num3 = num;
				num = (short)82706433;
				if (num != 0)
				{
				}
				num = (short)411303936;
				if (num != 0)
				{
				}
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.RibbonBorder.PaddingProperty);
			}
			set
			{
				short num = (short)983735806;
				short num2 = num;
				num = (short)1347329534;
				switch (num2 == num)
				{
				}
				num = (short)1763311616;
				short num3 = num;
				num = (short)225837057;
				if (num != 0)
				{
				}
				num = (short)804847616;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonBorder.PaddingProperty, value);
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0009D720 File Offset: 0x0009B920
		private static void OnColorClassChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)189530113;
			if (num != 0)
			{
			}
			num = (short)670976775;
			short num2 = num;
			num = (short)241126151;
			switch (num2 == num)
			{
			default:
			{
				num = (short)577568768;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1096024064;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.RibbonBorder)d).OnColorClassChanged(e);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0009D7D8 File Offset: 0x0009B9D8
		private void OnColorClassChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)196651087;
			short num2 = num;
			num = (short)238463055;
			switch (num2 == num)
			{
			}
			num = (short)1249771520;
			short num3 = num;
			num = (short)262471680;
			if (num != 0)
			{
			}
			num = (short)370016257;
			if (num != 0)
			{
			}
			this.UpdateVisualState();
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0009D888 File Offset: 0x0009BA88
		private static void OnRibbonBarStateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1381730813;
			short num2 = num;
			num = (short)662407677;
			switch (num2 == num)
			{
			}
			num = (short)767361024;
			short num3 = num;
			num = (short)1743781889;
			if (num != 0)
			{
			}
			num = (short)1374945280;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonBorder ribbonBorder = (global::DevComponents.WpfRibbon.RibbonBorder)d;
			global::DevComponents.WpfRibbon.eRibbonBarRenderingState oldState = (global::DevComponents.WpfRibbon.eRibbonBarRenderingState)e.OldValue;
			global::DevComponents.WpfRibbon.eRibbonBarRenderingState newState = (global::DevComponents.WpfRibbon.eRibbonBarRenderingState)e.NewValue;
			ribbonBorder.UpdateOverlay(oldState, newState);
			ribbonBorder.UpdateVisualState();
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0009D95C File Offset: 0x0009BB5C
		private void UpdateOverlay(global::DevComponents.WpfRibbon.eRibbonBarRenderingState oldState, global::DevComponents.WpfRibbon.eRibbonBarRenderingState newState)
		{
			short num = (short)1181351938;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1038942209;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_14C;
				case 1:
					goto IL_E4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 3:
				{
					num = (short)1147076608;
					short num3 = num;
					if (newState == global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Normal)
					{
						num = (short)1655832577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16C;
				}
				case 4:
					num = (short)1602289667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1396439056;
					short num4 = num;
					num = (short)278460432;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14C;
					default:
						num = (short)908066816;
						if (num != 0)
						{
						}
						num = (short)755367936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_65:
				if (newState != global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Hover)
				{
					num = (short)2036072453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_14C:
				if (oldState != global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Hover)
				{
					goto IL_16C;
				}
				num = (short)600506372;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7F:
			this.CreateRendererOverlayBrushes(global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Hover);
			return;
			IL_E4:
			goto IL_7F;
			IL_16C:
			this.DestroyRendererOverlayBrushes();
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0009DADC File Offset: 0x0009BCDC
		private void UpdateVisualState()
		{
			short num = (short)135856128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7F;
				}
				global::DevComponents.WpfRibbon.RibbonBorder.RenderOverlayBrushes renderOverlayBrushes;
				string colorClass;
				global::DevComponents.WpfRibbon.RibbonBorder.RenderOverlayBrushes renderOverlayBrushes2;
				for (;;)
				{
					IL_28:
					global::DevComponents.WpfRibbon.eRibbonBarRenderingState eRibbonBarRenderingState;
					switch (num2)
					{
					case 0:
					{
						num = (short)2029518848;
						short num3 = num;
						num = (short)1641611277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)17760260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_41F;
					case 3:
						if (renderOverlayBrushes != null)
						{
							num = (short)658767886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						if (this.BorderState == global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Hover)
						{
							num = (short)337051653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_274;
					case 5:
						renderOverlayBrushes = this.GetRenderOverlayBrushes();
						num = (short)477954051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_3C5;
					case 7:
						if (this.AnimationEnabled)
						{
							num = (short)1457127425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_274;
					case 8:
						if (this.AnimationEnabled)
						{
							num = (short)952369152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41F;
					case 9:
						if (colorClass == "")
						{
							num = (short)491716624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						eRibbonBarRenderingState = this.BorderState;
						num = (short)788070408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (renderOverlayBrushes2 != null)
						{
							num = (short)248774662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						goto IL_31B;
					case 12:
						if (this.AnimationEnabled)
						{
							num = (short)2031681553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					case 13:
						if (eRibbonBarRenderingState == global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Hover)
						{
							num = (short)1431502866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41F;
					case 14:
						goto IL_148;
					case 15:
						if (this.BorderState == global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Normal)
						{
							num = (short)1758855187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					case 16:
						goto IL_C3;
					case 17:
						num = (short)1520828431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1489633281;
						if (num != 0)
						{
						}
						eRibbonBarRenderingState = global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Normal;
						num = (short)1980891138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						renderOverlayBrushes2 = this.GetRenderOverlayBrushes();
						num = (short)1551564810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F;
					IL_274:
					num = (short)1013642287;
					short num4 = num;
					num = (short)484766767;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C3;
					default:
						num = (short)1685323776;
						if (num != 0)
						{
						}
						num = (short)516751372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2FD:
					base.InvalidateVisual();
					num = (short)283508747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41F:
					string str = colorClass + this.GetStateKey(eRibbonBarRenderingState);
					base.SetResourceReference(global::DevComponents.WpfRibbon.RibbonBorder.BackgroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonBarPartColorKeys.Background));
					base.SetResourceReference(global::DevComponents.WpfRibbon.RibbonBorder.BorderBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonBarPartColorKeys.Border));
					base.SetResourceReference(global::DevComponents.WpfRibbon.RibbonBorder.LightBorderBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonBarPartColorKeys.BorderLight));
					base.SetResourceReference(global::DevComponents.WpfRibbon.RibbonBorder.TopHighlightProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonBarPartColorKeys.TopHighlight));
					num = (short)467992583;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C3:
				this.Background = null;
				this.BorderBrush = null;
				this.LightBorderBrush = null;
				base.InvalidateVisual();
				return;
				IL_148:
				global::System.Windows.Duration duration = new global::System.Windows.Duration(global::System.TimeSpan.FromSeconds(0.4));
				global::System.Windows.Media.Animation.DoubleAnimation animation = new global::System.Windows.Media.Animation.DoubleAnimation(0.3, 1.0, duration);
				renderOverlayBrushes.BeginAnimation(animation);
				return;
				IL_31B:
				return;
				IL_3C5:
				global::System.Windows.Duration duration2 = new global::System.Windows.Duration(global::System.TimeSpan.FromSeconds(0.4));
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(1.0, 0.0, duration2);
				doubleAnimation.Completed += this.AnimationCompleted;
				renderOverlayBrushes2.BeginAnimation(doubleAnimation);
				return;
				IL_7F:
				colorClass = this.ColorClass;
				num = (short)1286668297;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0009DFEC File Offset: 0x0009C1EC
		private void AnimationCompleted(object sender, global::System.EventArgs e)
		{
			short num = (short)1392836610;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)439821225;
					short num3 = num;
					num = (short)1308500905;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)402456576;
						if (num != 0)
						{
						}
						this.DestroyRendererOverlayBrushes();
						num = (short)1782513664;
						short num4 = num;
						num = (short)1220280321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					return;
				case 2:
					num = (short)1280049153;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				}
				IL_57:
				if (this.BorderState != global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Normal)
				{
					break;
				}
				num = (short)930676736;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0009E108 File Offset: 0x0009C308
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			global::System.Windows.UIElement child = this.Child;
			global::System.Windows.Size thicknessSize = global::DevComponents.WpfRibbon.LayoutHelpers.GetThicknessSize(this.BorderThickness);
			global::System.Windows.Size thicknessSize2 = global::DevComponents.WpfRibbon.LayoutHelpers.GetThicknessSize(this.LightBorderThickness);
			thicknessSize.Height += thicknessSize2.Height;
			thicknessSize.Width += thicknessSize2.Width;
			global::System.Windows.Size thicknessSize3 = global::DevComponents.WpfRibbon.LayoutHelpers.GetThicknessSize(this.Padding);
			if (child == null)
			{
				short num = (short)1930231809;
				if (num != 0)
				{
				}
				num = (short)124492095;
				short num2 = num;
				num = (short)785094975;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)536412160;
					short num3 = num;
					num = (short)100794368;
					if (num != 0)
					{
					}
					return new global::System.Windows.Size(thicknessSize.Width + thicknessSize3.Width, thicknessSize.Height + thicknessSize3.Height);
				}
				}
			}
			global::System.Windows.Size result = new global::System.Windows.Size(thicknessSize.Width + thicknessSize3.Width, thicknessSize.Height + thicknessSize3.Height);
			global::System.Windows.Size availableSize = new global::System.Windows.Size(global::System.Math.Max(0.0, constraint.Width - result.Width), global::System.Math.Max(0.0, constraint.Height - result.Height));
			child.Measure(availableSize);
			global::System.Windows.Size desiredSize = child.DesiredSize;
			result.Width = desiredSize.Width + result.Width;
			result.Height = desiredSize.Height + result.Height;
			return result;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0009E2D8 File Offset: 0x0009C4D8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1323827200;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E7;
				}
				global::System.Windows.Thickness lightBorderThickness;
				global::System.Windows.Rect rect2;
				global::System.Windows.Thickness borderThickness;
				global::System.Windows.Rect r;
				global::System.Windows.UIElement child;
				for (;;)
				{
					IL_28:
					global::System.Windows.Rect rect3;
					global::System.Windows.CornerRadius cornerRadius;
					double num4;
					global::System.Windows.Media.StreamGeometryContext streamGeometryContext3;
					global::System.Windows.Media.StreamGeometryContext streamGeometryContext4;
					switch (num2)
					{
					case 0:
						if (!finalSize.IsEmpty)
						{
							num = (short)1741881354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 1:
						goto IL_B2B;
					case 2:
						goto IL_2E8;
					case 3:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(lightBorderThickness))
						{
							num = (short)1220673579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 4:
					{
						global::System.Windows.Rect rect = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(rect2, borderThickness);
						num = (short)199294997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)1114374185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_417;
					case 7:
						if (!r.IsEmpty)
						{
							num = (short)1250361348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71F;
					case 8:
						goto IL_2E8;
					case 9:
					{
						this.m_BorderGeometryMouseOver = new global::System.Windows.Media.StreamGeometry();
						rect3 = rect2;
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext = this.m_BorderGeometryMouseOver.Open();
						num = (short)737214476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)1465122842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						try
						{
							global::System.Windows.Rect rect;
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext2;
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext2, rect, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, borderThickness, false));
							goto IL_7C5;
						}
						finally
						{
							num = (short)1330708481;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext2;
								switch (num2)
								{
								case 0:
								{
									num = (short)370759540;
									short num3 = num;
									num = (short)472340340;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_57D;
									default:
										goto IL_5E4;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_576;
									}
									continue;
								case 2:
									((global::System.IDisposable)streamGeometryContext2).Dispose();
									num = (short)597557248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_576;
								IL_57D:
								num = (short)1397620738;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_576:
								if (streamGeometryContext2 != null)
								{
									goto IL_57D;
								}
								goto IL_5FD;
							}
							IL_5E4:
							num = (short)232521728;
							if (num != 0)
							{
							}
							IL_5FD:;
						}
						goto IL_5FE;
						IL_7C5:
						this.m_BackgroundGeometry.Freeze();
						num = (short)1192296479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						try
						{
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext, rect3, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, borderThickness, true));
							rect3 = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(rect3, borderThickness);
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext, rect3, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, borderThickness, true));
							goto IL_86A;
						}
						finally
						{
							num = (short)1677656065;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
								switch (num2)
								{
								case 0:
									goto IL_219;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1E1;
									}
									continue;
								case 2:
									((global::System.IDisposable)streamGeometryContext).Dispose();
									num = (short)248250368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1E1:
								if (streamGeometryContext == null)
								{
									break;
								}
								num = (short)336658434;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_219:;
						}
						goto IL_21C;
						IL_86A:
						this.m_BorderGeometryMouseOver.Freeze();
						num = (short)1427374117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1406861336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(r.Height))
						{
							num = (short)2007171114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71F;
					case 15:
						goto IL_41C;
					case 16:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect2.Width))
						{
							num = (short)1969422358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 17:
						if (this.InnerBorder)
						{
							num = (short)202833952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = rect3.X;
						rect3.X = num4 + 1.0;
						num4 = rect3.Y;
						rect3.Y = num4 + 1.0;
						num = (short)2045837314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						this.m_BackgroundGeometry = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext2 = this.m_BackgroundGeometry.Open();
						num = (short)1998913547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						child.Arrange(global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(r, this.Padding));
						num = (short)1682440236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(cornerRadius))
						{
							num = (short)1014562856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 21:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(cornerRadius))
						{
							num = (short)1264910354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41C;
					case 22:
						num = (short)485031974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (child != null)
						{
							num = (short)262799379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8DD;
					case 24:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(borderThickness))
						{
							num = (short)997523465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 25:
						if (!rect2.IsEmpty)
						{
							num = (short)909508621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 26:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(r.Width))
						{
							num = (short)333119524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 27:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(r.Height))
						{
							num = (short)733544453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 28:
						goto IL_21C;
					case 29:
						try
						{
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext3, rect3, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, lightBorderThickness, false));
							rect3 = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(rect3, lightBorderThickness);
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext3, rect3, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, lightBorderThickness, true));
							goto IL_3F4;
						}
						finally
						{
							num = (short)1850408961;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_B28;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_AEF;
									}
									continue;
								case 2:
									((global::System.IDisposable)streamGeometryContext3).Dispose();
									num = (short)2047803392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_AEF:
								if (streamGeometryContext3 == null)
								{
									break;
								}
								num = (short)2949122;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B28:;
						}
						goto Block_22;
						IL_3F4:
						this.m_LightBorderGeometry.Freeze();
						num = (short)1926234118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						try
						{
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext4, rect3, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, borderThickness, true));
							rect3 = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(rect3, borderThickness);
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext4, rect3, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, borderThickness, true));
							goto IL_77A;
						}
						finally
						{
							num = (short)589037569;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_6D4;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_69A;
									}
									continue;
								case 2:
									((global::System.IDisposable)streamGeometryContext4).Dispose();
									num = (short)1897201664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_69A:
								if (streamGeometryContext4 == null)
								{
									break;
								}
								num = (short)852688898;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6D4:;
						}
						goto IL_6D7;
						IL_77A:
						this.m_BorderGeometry.Freeze();
						num = (short)1697710083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_41C;
					case 32:
						goto IL_5FE;
					case 33:
						num = (short)1254883353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						this.m_LightBorderGeometryMouseOver = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext5 = this.m_LightBorderGeometryMouseOver.Open();
						num = (short)612827137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						goto IL_BCD;
					case 36:
						num = (short)1095106587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(lightBorderThickness))
						{
							num = (short)1422524417;
							if (num != 0)
							{
							}
							num = (short)250609698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BCD;
					case 38:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect2.Height))
						{
							num = (short)1962475553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 39:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(r.Width))
						{
							num = (short)1808990236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71F;
					case 40:
						goto IL_6D7;
					case 41:
					{
						if (r.IsEmpty)
						{
							num = (short)122880045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						cornerRadius = this.CornerRadius;
						global::System.Windows.Media.Brush borderBrush = this.BorderBrush;
						global::System.Windows.Media.Brush lightBorderBrush = this.LightBorderBrush;
						num = (short)1929445415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						num = (short)1352335367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						rect3 = rect2;
						num = (short)329318417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						goto IL_8DD;
					case 45:
						goto IL_2E3;
					}
					goto IL_E7;
					Block_22:
					try
					{
						IL_B2B:
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext5;
						global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext5, rect3, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, lightBorderThickness, false));
						rect3 = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(rect3, lightBorderThickness);
						global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext5, rect3, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, lightBorderThickness, true));
						goto IL_153;
					}
					finally
					{
						num = (short)1647640577;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext5;
							switch (num2)
							{
							case 0:
								goto IL_BCA;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_B91;
								}
								continue;
							case 2:
								((global::System.IDisposable)streamGeometryContext5).Dispose();
								num = (short)1084096512;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_B91:
							if (streamGeometryContext5 == null)
							{
								break;
							}
							num = (short)377094146;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_BCA:;
					}
					goto IL_BCD;
					IL_153:
					this.m_LightBorderGeometryMouseOver.Freeze();
					num = (short)291569699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21C:
					num = (short)1371013134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E8:
					this.m_LightBorderGeometry = new global::System.Windows.Media.StreamGeometry();
					cornerRadius = new global::System.Windows.CornerRadius(cornerRadius.TopLeft, cornerRadius.TopRight + 1.0, cornerRadius.BottomRight, cornerRadius.BottomLeft + 2.0);
					streamGeometryContext3 = this.m_LightBorderGeometry.Open();
					num = (short)486932509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41C:
					num = (short)1773535252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FE:
					rect3.Inflate(-1.0, -1.0);
					num = (short)548274184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D7:
					num = (short)1505820688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_71F:
					this.m_BackgroundGeometry = null;
					num = (short)1249837071;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8DD:
					this.m_BackgroundGeometry = null;
					this.m_BorderGeometry = null;
					this.m_BorderGeometryMouseOver = null;
					this.m_LightBorderGeometry = null;
					this.m_LightBorderGeometryMouseOver = null;
					num = (short)180813824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BCD:
					num4 = rect2.Width;
					rect2.Width = num4 - 1.0;
					num4 = rect2.Height;
					rect2.Height = num4 - 1.0;
					rect3 = rect2;
					this.m_BorderGeometry = new global::System.Windows.Media.StreamGeometry();
					streamGeometryContext4 = this.m_BorderGeometry.Open();
					num = (short)495190016;
					short num5 = num;
					num = (short)1179058206;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2E3:
				return finalSize;
				IL_417:
				return finalSize;
				IL_E7:
				rect2 = new global::System.Windows.Rect(finalSize);
				borderThickness = this.BorderThickness;
				lightBorderThickness = this.LightBorderThickness;
				r = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(rect2, borderThickness);
				r = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(r, lightBorderThickness);
				child = this.Child;
				num = (short)1127415831;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0009EF8C File Offset: 0x0009D18C
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			short num = (short)298647552;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_16F;
				}
				global::System.Windows.Media.Brush brush;
				global::DevComponents.WpfRibbon.RibbonBorder.RenderOverlayBrushes renderOverlayBrushes;
				for (;;)
				{
					IL_28:
					double num3;
					bool flag;
					double num5;
					switch (num2)
					{
					case 0:
						num = (short)551354401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num3 += this.Padding.Top + 2.0;
						num = (short)1274347554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)760107215;
						short num4 = num;
						num = (short)1848791247;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_850;
						default:
							num = (short)1943273472;
							if (num != 0)
							{
							}
							if (brush != null)
							{
								num = (short)420675605;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6F3;
						}
						break;
					}
					case 3:
						num = (short)1188233279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						brush = renderOverlayBrushes.LightBorderBrush;
						dc.DrawGeometry(brush, null, this.m_LightBorderGeometryMouseOver);
						num = (short)1516109893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						brush = new global::System.Windows.Media.SolidColorBrush(((global::System.Windows.Media.LinearGradientBrush)brush).GradientStops[0].Color);
						num = (short)1723858951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::System.Windows.Media.RectangleGeometry geometry = new global::System.Windows.Media.RectangleGeometry(new global::System.Windows.Rect(base.RenderSize));
						global::System.Windows.Media.RectangleGeometry geometry2 = new global::System.Windows.Media.RectangleGeometry(new global::System.Windows.Rect(this.m_SelectedTabRect.X, 0.0, this.m_SelectedTabRect.Width - 1.0, 1.0));
						global::System.Windows.Media.CombinedGeometry clipGeometry = new global::System.Windows.Media.CombinedGeometry(global::System.Windows.Media.GeometryCombineMode.Exclude, geometry, geometry2);
						dc.PushClip(clipGeometry);
						flag = true;
						num = (short)582877225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_DB7;
					case 8:
						num = (short)868614220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)839057445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (renderOverlayBrushes.BorderBrush != null)
						{
							num = (short)1169686603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9D;
					case 11:
						goto IL_BE7;
					case 12:
						goto IL_2E0;
					case 13:
						if (renderOverlayBrushes.BorderBrush.Opacity > 0.0)
						{
							num = (short)1340211208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9D;
					case 14:
						brush = renderOverlayBrushes.TopHighlight;
						dc.DrawRectangle(brush, null, new global::System.Windows.Rect(0.0, 0.0, base.RenderSize.Width, num5));
						num = (short)125829144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_3FE;
					case 16:
						brush = this.BorderBrush;
						num = (short)1798635542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (brush is global::System.Windows.Media.LinearGradientBrush)
						{
							num = (short)1714094108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DB7;
					case 18:
						dc.Pop();
						num = (short)152567851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						return;
					case 20:
						goto IL_C9D;
					case 21:
						num3 = 15.0;
						num = (short)1387986989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (brush != null)
						{
							num = (short)2006974542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73A;
					case 23:
						num = (short)567935038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_6F3;
					case 25:
					{
						if (this.m_BorderGeometry != null)
						{
							num = (short)528810000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Rect borderBounds = new global::System.Windows.Rect(base.RenderSize);
						global::DevComponents.WpfRibbon.DrawingHelpers.DrawBorder(dc, this.BorderThickness, this.BorderBrush, borderBounds);
						num = (short)652935212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (this.Background != null)
						{
							num = (short)676855843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 27:
						if (renderOverlayBrushes != null)
						{
							num = (short)506003465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43E;
					case 28:
						num = (short)1628700743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (renderOverlayBrushes.TopHighlight != null)
						{
							num = (short)1787232270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F3;
					case 30:
						goto IL_43E;
					case 31:
						if (renderOverlayBrushes.LightBorderBrush.Opacity > 0.0)
						{
							num = (short)459931651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0A;
					case 32:
						if (this.IsRibbonPanel)
						{
							num = (short)1988165683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE7;
					case 33:
						if (renderOverlayBrushes.Background != null)
						{
							num = (short)794558502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E0;
					case 34:
						goto IL_555;
					case 35:
						brush = this.Background;
						num = (short)904134673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						brush = this.LightBorderBrush;
						num = (short)709427265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (renderOverlayBrushes.TopHighlight != null)
						{
							num = (short)537985066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43E;
					case 38:
						brush = renderOverlayBrushes.Background;
						dc.DrawGeometry(brush, null, this.m_BackgroundGeometry);
						num = (short)1908146188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (renderOverlayBrushes != null)
						{
							num = (short)1026424909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F3;
					case 40:
						goto IL_850;
					case 41:
						goto IL_AA3;
					case 42:
						brush = renderOverlayBrushes.TopHighlight;
						dc.DrawRectangle(brush, null, new global::System.Windows.Rect(0.0, 0.0, base.RenderSize.Width, num3));
						num = (short)1443758110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_62D;
					case 44:
						goto IL_73A;
					case 45:
						if (this.IsRibbonPanel)
						{
							num = (short)1092157441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_555;
					case 46:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(this.m_SelectedTabRect))
						{
							num = (short)1551761414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA3;
					case 47:
					{
						if (this.m_BackgroundGeometry != null)
						{
							num = (short)1907818566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Rect rectangle = new global::System.Windows.Rect(base.RenderSize);
						brush = this.Background;
						num = (short)406192181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						if (brush != null)
						{
							num = (short)1441071163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5E;
					case 49:
						goto IL_3FE;
					case 50:
					{
						global::System.Windows.Rect rectangle;
						dc.DrawRectangle(brush, null, rectangle);
						num = (short)1162281021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
						num5 += this.Padding.Top + 2.0;
						num = (short)1663565835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (renderOverlayBrushes != null)
						{
							num = (short)852688964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9D;
					case 53:
						if (brush != null)
						{
							num = (short)99614770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_855;
					case 54:
					{
						if (this.m_LightBorderGeometry != null)
						{
							num = (short)2129592356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Rect borderBounds2 = new global::System.Windows.Rect(base.RenderSize);
						borderBounds2.Offset(0.5, 0.0);
						global::DevComponents.WpfRibbon.DrawingHelpers.DrawBorder(dc, this.LightBorderThickness, this.LightBorderBrush, borderBounds2);
						num = (short)1880293391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						goto IL_73A;
					case 56:
						if (flag)
						{
							num = (short)502398994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62D;
					case 57:
						dc.DrawGeometry(brush, null, this.m_LightBorderGeometry);
						num = (short)43909169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (brush != null)
						{
							num = (short)1410662479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F3;
					case 59:
						dc.DrawGeometry(brush, null, this.m_BackgroundGeometry);
						num = (short)192741449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						num = (short)554434586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						goto IL_855;
					case 62:
						if (renderOverlayBrushes.LightBorderBrush != null)
						{
							num = (short)765263939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0A;
					case 63:
						if (this.m_LightBorderGeometryMouseOver != null)
						{
							num = (short)1621491716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0A;
					case 64:
						goto IL_6F3;
					case 65:
						if (brush != null)
						{
							num = (short)616562745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FE;
					case 66:
						if (renderOverlayBrushes != null)
						{
							num = (short)340000791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0A;
					case 67:
						num = (short)197656607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)1437401098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						goto IL_E0A;
					case 70:
						brush = this.Background;
						num = (short)2083127344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						if (((global::System.Windows.Media.LinearGradientBrush)brush).GradientStops.Count > 0)
						{
							num = (short)1608712197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DB7;
					case 72:
						if (renderOverlayBrushes != null)
						{
							num = (short)1318584320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E0;
					case 73:
						goto IL_B5E;
					case 74:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(this.m_SelectedTabRect))
						{
							num = (short)856031292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 75:
						num = (short)462880781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (this.m_BorderGeometryMouseOver != null)
						{
							num = (short)2084569128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9D;
					case 77:
						num = (short)1174077469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						dc.DrawGeometry(brush, null, this.m_BorderGeometry);
						num = (short)1989738551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						num5 = 15.0;
						num = (short)1651769376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16F;
					IL_2E0:
					brush = this.TopHighlight;
					num = (short)617480194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FE:
					num = (short)2043740185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43E:
					dc.Pop();
					num = (short)1425801280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_555:
					dc.PushClip(this.m_BackgroundGeometry);
					dc.DrawRectangle(brush, null, new global::System.Windows.Rect(0.0, 0.0, base.RenderSize.Width, num3));
					num = (short)2109866011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62D:
					num = (short)1463025738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F3:
					flag = false;
					num = (short)1509752878;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_73A:
					num = (short)766902338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_850:
					brush = renderOverlayBrushes.BorderBrush;
					dc.DrawGeometry(brush, null, this.m_BorderGeometryMouseOver);
					num = (short)1061355540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_855:
					brush = this.TopHighlight;
					num = (short)747503674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA3:
					num = (short)1249574966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B5E:
					num = (short)2012741704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE7:
					dc.DrawRectangle(brush, null, new global::System.Windows.Rect(0.0, 0.0, base.RenderSize.Width, num5));
					num = (short)737804327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C9D:
					num = (short)818479160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DB7:
					dc.DrawRectangle(brush, null, new global::System.Windows.Rect(this.m_SelectedTabRect.X, 0.0, this.m_SelectedTabRect.Width, 1.0));
					num = (short)1197998099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E0A:
					num = (short)714735617;
					if (num != 0)
					{
					}
					num = (short)1305608244;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_16F:
				num = (short)1403191296;
				short num6 = num;
				renderOverlayBrushes = this.GetRenderOverlayBrushes();
				brush = null;
				num = (short)1388838959;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0009FE8C File Offset: 0x0009E08C
		private static bool IsCornerRadiusValid(object value)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				global::System.Windows.CornerRadius cornerRadius;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (cornerRadius.TopRight >= 0.0)
						{
							num2 = (short)1319370759;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 1:
						if (cornerRadius.TopLeft >= 0.0)
						{
							num2 = (short)1687814146;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 2:
						num2 = (short)1631453184;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (cornerRadius.BottomLeft >= 0.0)
						{
							num2 = (short)771817477;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 4:
						if (cornerRadius.BottomRight >= 0.0)
						{
							num2 = (short)1091829766;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 5:
						num2 = (short)1304231940;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
					{
						num2 = (short)1559497517;
						short num3 = num2;
						num2 = (short)1740180269;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)1035403265;
							if (num2 != 0)
							{
							}
							num2 = (short)1586102272;
							short num4 = num2;
							num2 = (short)122486784;
							if (num2 != 0)
							{
							}
							num2 = (short)1685127169;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 7:
						return true;
					}
					break;
				}
				IL_30:
				cornerRadius = (global::System.Windows.CornerRadius)value;
				num2 = (short)775028739;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return true;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x000A0088 File Offset: 0x0009E288
		private bool AnimationEnabled
		{
			get
			{
				for (;;)
				{
					IL_00:
					short num = (short)9175043;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (base.IsEnabled)
							{
								num = (short)1107361799;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 1:
							if (global::System.Windows.SystemParameters.ClientAreaAnimation)
							{
								num = (short)2111635458;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 2:
							num = (short)121176068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_45;
							}
							continue;
						case 4:
							num = (short)889651201;
							if (num != 0)
							{
							}
							if (global::System.Windows.Media.RenderCapability.Tier > 0)
							{
								num = (short)1917255686;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 5:
						{
							num = (short)1591733011;
							short num3 = num;
							num = (short)2068638483;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)497418240;
								if (num != 0)
								{
								}
								num = (short)1782513664;
								short num4 = num;
								num = (short)1826488321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 6:
							num = (short)557514752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_A8;
						}
						IL_45:
						if (global::System.Windows.SystemParameters.PowerLineStatus != global::System.Windows.PowerLineStatus.Online)
						{
							return false;
						}
						num = (short)1031864325;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_A8:
				return this.AutoAnimation;
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000A025C File Offset: 0x0009E45C
		private global::DevComponents.WpfRibbon.RibbonBorder.RenderOverlayBrushes GetRenderOverlayBrushes()
		{
			short num = (short)750714881;
			if (num != 0)
			{
			}
			num = (short)1548606402;
			short num2 = num;
			num = (short)15326146;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D9:
				if (this.AnimationEnabled)
				{
					return this.m_RenderBrushes;
				}
				num = (short)1734541314;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2134245376;
				if (num != 0)
				{
				}
				num = (short)134610945;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_D9;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				case 2:
					goto IL_F5;
				case 3:
					num = (short)340262912;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A4:
				if (!base.IsEnabled)
				{
					break;
				}
				num = (short)1223688195;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_C2:
			return null;
			IL_F5:
			num = (short)1362100224;
			short num4 = num;
			goto IL_C2;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000A0390 File Offset: 0x0009E590
		private void DestroyRendererOverlayBrushes()
		{
			short num = (short)1796210689;
			if (num != 0)
			{
			}
			num = (short)514392064;
			short num2 = num;
			object resourceAccessLock = this.m_ResourceAccessLock;
			bool flag = false;
			try
			{
				global::System.Threading.Monitor.Enter(resourceAccessLock, ref flag);
				this.m_RenderBrushes = null;
			}
			finally
			{
				num = (short)532414465;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_D4;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					case 2:
						global::System.Threading.Monitor.Exit(resourceAccessLock);
						num = (short)1193672704;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_9D:
					if (!flag)
					{
						goto IL_121;
					}
					num = (short)2072444930;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_D4:
				num = (short)1241733485;
				short num4 = num;
				num = (short)832133485;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1386414080;
					if (num != 0)
					{
					}
					break;
				}
				IL_121:;
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000A04D0 File Offset: 0x0009E6D0
		private void CreateRendererOverlayBrushes(global::DevComponents.WpfRibbon.eRibbonBarRenderingState renderingState)
		{
			short num = (short)1256325120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1977352192;
				short num3 = num;
				num = (short)1709637633;
				if (num != 0)
				{
				}
				object resourceAccessLock = this.m_ResourceAccessLock;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_C5;
					}
					string colorClass;
					for (;;)
					{
						IL_82:
						global::System.Windows.Media.Brush brush;
						string str;
						switch (num2)
						{
						case 0:
							if (brush != null)
							{
								num = (short)959053831;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_156;
						case 1:
							goto IL_3E0;
						case 2:
							if (colorClass != "")
							{
								num = (short)1382744075;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C7;
						case 3:
							goto IL_251;
						case 4:
							if (brush != null)
							{
								num = (short)445054986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C7;
						case 5:
							goto IL_156;
						case 6:
							goto IL_3C7;
						case 7:
							this.m_RenderBrushes.LightBorderBrush = brush.Clone();
							num = (short)1455751173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_363;
						case 9:
							if (brush != null)
							{
								num = (short)1309802510;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_363;
						case 10:
							this.m_RenderBrushes.TopHighlight = brush.Clone();
							num = (short)1593507846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							num = (short)1713557466;
							short num4 = num;
							num = (short)391565274;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_251;
							default:
								num = (short)1435435008;
								if (num != 0)
								{
								}
								str = colorClass + this.GetStateKey(renderingState);
								brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonBarPartColorKeys.Background)) as global::System.Windows.Media.Brush);
								num = (short)1835991043;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
							this.m_RenderBrushes.Background = brush.Clone();
							num = (short)2086469645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_303;
						case 14:
							this.m_RenderBrushes.BorderBrush = brush.Clone();
							num = (short)1946877960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5;
						IL_156:
						brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonBarPartColorKeys.TopHighlight)) as global::System.Windows.Media.Brush);
						num = (short)486670340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_251:
						if (brush != null)
						{
							num = (short)135069708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_303:
						brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonBarPartColorKeys.Border)) as global::System.Windows.Media.Brush);
						num = (short)47185929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_363:
						brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonBarPartColorKeys.BorderLight)) as global::System.Windows.Media.Brush);
						num = (short)1617494016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3C7:
						num = (short)142737409;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3E0:
					return;
					IL_C5:
					global::System.Threading.Monitor.Enter(resourceAccessLock, ref flag);
					this.m_RenderBrushes = new global::DevComponents.WpfRibbon.RibbonBorder.RenderOverlayBrushes();
					colorClass = this.ColorClass;
					num = (short)1521221634;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_82;
				}
				finally
				{
					num = (short)218300417;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							global::System.Threading.Monitor.Exit(resourceAccessLock);
							num = (short)526450690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_414;
							}
							continue;
						case 2:
							goto IL_44A;
						}
						IL_414:
						if (!flag)
						{
							break;
						}
						num = (short)2034434048;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_44A:;
				}
				return;
			}
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000A0948 File Offset: 0x0009EB48
		private string GetStateKey(global::DevComponents.WpfRibbon.eRibbonBarRenderingState renderingState)
		{
			short num = (short)856424451;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_6D;
				case 1:
				{
					num = (short)430670003;
					short num3 = num;
					num = (short)394821811;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_151;
					default:
						num = (short)1979973632;
						if (num != 0)
						{
						}
						num = (short)796852224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
				{
					num = (short)1747189760;
					short num4 = num;
					num = (short)2085224452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					if (renderingState != global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Hover)
					{
						num = (short)175898625;
						if (num != 0)
						{
						}
						num = (short)1257701377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14B;
				}
				IL_38:
				if (renderingState == global::DevComponents.WpfRibbon.eRibbonBarRenderingState.Normal)
				{
					break;
				}
				num = (short)6946818;
				num2 = (int)((global::System.IntPtr)num);
			}
			return global::DevComponents.WpfRibbon.RibbonBarStateColorKeys.Normal;
			IL_6D:
			goto IL_151;
			IL_14B:
			return global::DevComponents.WpfRibbon.RibbonBarStateColorKeys.Hover;
			IL_151:
			return global::DevComponents.WpfRibbon.RibbonBarStateColorKeys.Normal;
		}

		// Token: 0x0400033A RID: 826
		public static readonly global::System.Windows.DependencyProperty BackgroundProperty;

		// Token: 0x0400033B RID: 827
		public static readonly global::System.Windows.DependencyProperty TopHighlightProperty;

		// Token: 0x0400033C RID: 828
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x0400033D RID: 829
		public static readonly global::System.Windows.DependencyProperty LightBorderBrushProperty;

		// Token: 0x0400033E RID: 830
		public static readonly global::System.Windows.DependencyProperty PaddingProperty;

		// Token: 0x0400033F RID: 831
		public static readonly global::System.Windows.DependencyProperty CornerRadiusProperty;

		// Token: 0x04000340 RID: 832
		public static readonly global::System.Windows.DependencyProperty ColorClassProperty;

		// Token: 0x04000341 RID: 833
		public static readonly global::System.Windows.DependencyProperty BorderStateProperty;

		// Token: 0x04000342 RID: 834
		public static readonly global::System.Windows.DependencyProperty BorderThicknessProperty;

		// Token: 0x04000343 RID: 835
		public static readonly global::System.Windows.DependencyProperty LightBorderThicknessProperty;

		// Token: 0x04000344 RID: 836
		public static readonly global::System.Windows.DependencyProperty AutoAnimationProperty;

		// Token: 0x04000345 RID: 837
		public static readonly global::System.Windows.DependencyProperty InnerBorderProperty;

		// Token: 0x04000346 RID: 838
		public static readonly global::System.Windows.DependencyProperty IsRibbonPanelProperty;

		// Token: 0x04000347 RID: 839
		private global::System.Windows.Media.StreamGeometry m_BackgroundGeometry;

		// Token: 0x04000348 RID: 840
		private global::System.Windows.Media.StreamGeometry m_BorderGeometry;

		// Token: 0x04000349 RID: 841
		private global::System.Windows.Media.StreamGeometry m_BorderGeometryMouseOver;

		// Token: 0x0400034A RID: 842
		private global::System.Windows.Media.StreamGeometry m_LightBorderGeometry;

		// Token: 0x0400034B RID: 843
		private global::System.Windows.Media.StreamGeometry m_LightBorderGeometryMouseOver;

		// Token: 0x0400034C RID: 844
		private const double FadeDuration = 0.4;

		// Token: 0x0400034D RID: 845
		private global::DevComponents.WpfRibbon.RibbonBorder.RenderOverlayBrushes m_RenderBrushes;

		// Token: 0x0400034E RID: 846
		private global::System.Windows.Rect m_SelectedTabRect;

		// Token: 0x0400034F RID: 847
		private object m_ResourceAccessLock = new object();

		// Token: 0x02000077 RID: 119
		private class RenderOverlayBrushes
		{
			// Token: 0x06000719 RID: 1817 RVA: 0x000A0ACC File Offset: 0x0009ECCC
			internal void BeginAnimation(global::System.Windows.Media.Animation.DoubleAnimation animation1)
			{
				short num = (short)2142568448;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_14;
					case 1:
						if (this.BorderBrush != null)
						{
							num = (short)212860933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_119;
					case 2:
						if (this.TopHighlight != null)
						{
							num = (short)329711624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_21E;
					case 4:
						goto IL_119;
					case 5:
						this.BorderBrush.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)1630863364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					case 7:
						if (this.LightBorderBrush != null)
						{
							num = (short)84606977;
							if (num != 0)
							{
							}
							num = (short)772866057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 8:
						this.TopHighlight.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)2087124998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						this.LightBorderBrush.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)2036168266;
						short num3 = num;
						num = (short)2073327178;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							num = (short)842727424;
							if (num != 0)
							{
							}
							num = (short)1080492035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						this.Background.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)1978531851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_182;
					}
					goto IL_54;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_54:
						num = (short)1167851520;
						short num4 = num;
						if (this.Background == null)
						{
							goto IL_182;
						}
						num = (short)252903434;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
					continue;
					IL_119:
					num = (short)1783300103;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_182:
					num = (short)1076953089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21E:
					num = (short)1752236034;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x04000350 RID: 848
			public global::System.Windows.Media.Brush Background;

			// Token: 0x04000351 RID: 849
			public global::System.Windows.Media.Brush TopHighlight;

			// Token: 0x04000352 RID: 850
			public global::System.Windows.Media.Brush BorderBrush;

			// Token: 0x04000353 RID: 851
			public global::System.Windows.Media.Brush LightBorderBrush;
		}
	}
}
