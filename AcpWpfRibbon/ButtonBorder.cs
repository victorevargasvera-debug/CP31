using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Animation;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200000F RID: 15
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ButtonBorder : global::System.Windows.Controls.Decorator
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0002B63C File Offset: 0x0002983C
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0002B6F4 File Offset: 0x000298F4
		public global::System.Windows.Media.Brush InactiveOverlayBrush
		{
			get
			{
				short num = (short)183662782;
				short num2 = num;
				num = (short)322664638;
				switch (num2 == num)
				{
				}
				num = (short)1612316672;
				short num3 = num;
				num = (short)931987457;
				if (num != 0)
				{
				}
				num = (short)1091239936;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.InactiveOverlayBrushProperty);
			}
			set
			{
				short num = (short)1919692776;
				short num2 = num;
				num = (short)1742942184;
				switch (num2 == num)
				{
				}
				num = (short)401604608;
				short num3 = num;
				num = (short)529530881;
				if (num != 0)
				{
				}
				num = (short)2079784960;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.InactiveOverlayBrushProperty, value);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0002B7AC File Offset: 0x000299AC
		static ButtonBorder()
		{
			int a_ = 1;
			short num = (short)2009024421;
			short num2 = num;
			num = (short)581191589;
			switch (num2 == num)
			{
			}
			num = (short)178716672;
			short num3 = num;
			num = (short)535166976;
			if (num != 0)
			{
			}
			num = (short)1623719937;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ButtonBorder.InactiveOverlayBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ㕚㱜㱞ᕠ੢፤ɦ♨ᵪ࡬ᵮᵰቲ౴㕶୸๺๼᝾", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ButtonBorder.BorderThicknessProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᭘㑚⽜㭞Ѡᅢㅤསhࡪ٬Ůᑰrٴ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.ButtonBorder.IsThicknessValid));
			global::DevComponents.WpfRibbon.ButtonBorder.PaddingProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़㩚㥜㭞ࡠൢɤ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.ButtonBorder.IsThicknessValid));
			global::DevComponents.WpfRibbon.ButtonBorder.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᭘㑚⽜㭞Ѡᅢ❤ᕦᱨᡪլ", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.ButtonBorder.BackgroundProperty = global::System.Windows.Controls.Panel.BackgroundProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.ButtonBorder.LightBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᕘ㉚㩜㝞ᕠⅢ੤ᕦ൨๪Ὤ⵮Ͱٲٴὶ", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.ButtonBorder.TopHighlightProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൘㑚ⵜ᝞ࡠѢ൤୦h౪լ᭮", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.ButtonBorder.BottomHighlightProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᭘㑚⥜⭞๠๢ⵤ๦๨ͪŬٮᙰ᭲Ŵ", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.ButtonBorder.CornerRadiusProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩘ㑚⽜ㅞѠᅢ㝤٦൨ɪᡬᱮ", a_), typeof(global::System.Windows.CornerRadius), typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.CornerRadius(0.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.ButtonBorder.IsCornerRadiusValid));
			global::DevComponents.WpfRibbon.ButtonBorder.ButtonStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᭘⹚⥜⭞๠ൢ㙤፦ࡨὪ࡬", a_), typeof(global::DevComponents.WpfRibbon.eButtonRenderingState), typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eButtonRenderingState.Normal, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonBorder.OnButtonStateChanged)));
			global::DevComponents.WpfRibbon.ButtonBorder.ColorClassProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩘ㑚ㅜぞ፠⁢।٦ᩨᡪ", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.RibbonColors.ButtonClass, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonBorder.OnButtonClassChanged)));
			global::DevComponents.WpfRibbon.ButtonBorder.RenderBorderProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("୘㹚㍜㭞Ѡᅢ❤ࡦ᭨ཪ࡬ᵮ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonBorder), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0002BB40 File Offset: 0x00029D40
		public ButtonBorder()
		{
			base.SetResourceReference(global::DevComponents.WpfRibbon.ButtonBorder.InactiveOverlayBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.ButtonInactiveOverlay));
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0002BB9C File Offset: 0x00029D9C
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x0002BC58 File Offset: 0x00029E58
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Description("Indicates whether border is rendered.")]
		public bool RenderBorder
		{
			get
			{
				short num = (short)1519511770;
				short num2 = num;
				num = (short)22407386;
				switch (num2 == num)
				{
				}
				num = (short)612499456;
				short num3 = num;
				num = (short)256507905;
				if (num != 0)
				{
				}
				num = (short)1159462912;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.RenderBorderProperty);
			}
			set
			{
				short num = (short)1402497145;
				short num2 = num;
				num = (short)1037002873;
				switch (num2 == num)
				{
				}
				num = (short)1581711360;
				short num3 = num;
				num = (short)350748673;
				if (num != 0)
				{
				}
				num = (short)49283072;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.RenderBorderProperty, value);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0002BD10 File Offset: 0x00029F10
		// (set) Token: 0x060001CA RID: 458 RVA: 0x0002BDC8 File Offset: 0x00029FC8
		[global::System.ComponentModel.DefaultValue("Button")]
		public string ColorClass
		{
			get
			{
				short num = (short)1923211424;
				short num2 = num;
				num = (short)870244512;
				switch (num2 == num)
				{
				}
				num = (short)682688512;
				short num3 = num;
				num = (short)426049536;
				if (num != 0)
				{
				}
				num = (short)1934295041;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.ColorClassProperty);
			}
			set
			{
				short num = (short)114247457;
				short num2 = num;
				num = (short)483542817;
				switch (num2 == num)
				{
				}
				num = (short)936443904;
				short num3 = num;
				num = (short)1866596353;
				if (num != 0)
				{
				}
				num = (short)546504704;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.ColorClassProperty, value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0002BE7C File Offset: 0x0002A07C
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0002BF38 File Offset: 0x0002A138
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.CornerRadiusConverter))]
		public global::System.Windows.CornerRadius CornerRadius
		{
			get
			{
				short num = (short)754967057;
				short num2 = num;
				num = (short)1329324561;
				switch (num2 == num)
				{
				}
				num = (short)798818304;
				short num3 = num;
				num = (short)917176321;
				if (num != 0)
				{
				}
				num = (short)1221656576;
				if (num != 0)
				{
				}
				return (global::System.Windows.CornerRadius)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.CornerRadiusProperty);
			}
			set
			{
				short num = (short)135873238;
				short num2 = num;
				num = (short)262161110;
				switch (num2 == num)
				{
				}
				num = (short)1486815232;
				short num3 = num;
				num = (short)1131413505;
				if (num != 0)
				{
				}
				num = (short)1951072256;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.CornerRadiusProperty, value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0002BFF4 File Offset: 0x0002A1F4
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0002C0B0 File Offset: 0x0002A2B0
		[global::System.ComponentModel.DefaultValue(global::DevComponents.WpfRibbon.eButtonRenderingState.Normal)]
		public global::DevComponents.WpfRibbon.eButtonRenderingState ButtonState
		{
			get
			{
				short num = (short)627541898;
				short num2 = num;
				num = (short)1949534090;
				switch (num2 == num)
				{
				}
				num = (short)1951072256;
				short num3 = num;
				num = (short)1613234177;
				if (num != 0)
				{
				}
				num = (short)50987008;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eButtonRenderingState)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.ButtonStateProperty);
			}
			set
			{
				short num = (short)169404403;
				short num2 = num;
				num = (short)1553328115;
				switch (num2 == num)
				{
				}
				num = (short)1587871744;
				short num3 = num;
				num = (short)1595670529;
				if (num != 0)
				{
				}
				num = (short)2100822016;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.ButtonStateProperty, value);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0002C16C File Offset: 0x0002A36C
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0002C228 File Offset: 0x0002A428
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush Background
		{
			get
			{
				short num = (short)1449313751;
				short num2 = num;
				num = (short)1879885271;
				switch (num2 == num)
				{
				}
				num = (short)1405485056;
				short num3 = num;
				num = (short)1948844033;
				if (num != 0)
				{
				}
				num = (short)1576599552;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.BackgroundProperty);
			}
			set
			{
				short num = (short)264152162;
				short num2 = num;
				num = (short)774218850;
				switch (num2 == num)
				{
				}
				num = (short)1736245248;
				short num3 = num;
				num = (short)1686241281;
				if (num != 0)
				{
				}
				num = (short)165675008;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.BackgroundProperty, value);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0002C2DC File Offset: 0x0002A4DC
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0002C394 File Offset: 0x0002A594
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush TopHighlight
		{
			get
			{
				short num = (short)2140408357;
				short num2 = num;
				num = (short)377686565;
				switch (num2 == num)
				{
				}
				num = (short)2083586048;
				short num3 = num;
				num = (short)564920321;
				if (num != 0)
				{
				}
				num = (short)782499840;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.TopHighlightProperty);
			}
			set
			{
				short num = (short)631436692;
				short num2 = num;
				num = (short)938734996;
				switch (num2 == num)
				{
				}
				num = (short)466878464;
				short num3 = num;
				num = (short)1708392448;
				if (num != 0)
				{
				}
				num = (short)432537601;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.TopHighlightProperty, value);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0002C448 File Offset: 0x0002A648
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0002C504 File Offset: 0x0002A704
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BottomHighlight
		{
			get
			{
				short num = (short)1021271598;
				short num2 = num;
				num = (short)596401710;
				switch (num2 == num)
				{
				}
				num = (short)1366032384;
				short num3 = num;
				num = (short)1201209345;
				if (num != 0)
				{
				}
				num = (short)875429888;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.BottomHighlightProperty);
			}
			set
			{
				short num = (short)1844248577;
				if (num != 0)
				{
				}
				num = (short)1625571518;
				short num2 = num;
				num = (short)36913342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1763246080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)124911616;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.BottomHighlightProperty, value);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0002C5BC File Offset: 0x0002A7BC
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0002C674 File Offset: 0x0002A874
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)1338303704;
				short num2 = num;
				num = (short)1725883608;
				switch (num2 == num)
				{
				}
				num = (short)419495936;
				short num3 = num;
				num = (short)2058616832;
				if (num != 0)
				{
				}
				num = (short)79953921;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.BorderBrushProperty);
			}
			set
			{
				short num = (short)403445137;
				short num2 = num;
				num = (short)1166349713;
				switch (num2 == num)
				{
				}
				num = (short)28966912;
				short num3 = num;
				num = (short)1982398465;
				if (num != 0)
				{
				}
				num = (short)104660992;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.BorderBrushProperty, value);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0002C72C File Offset: 0x0002A92C
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0002C7E8 File Offset: 0x0002A9E8
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush LightBorderBrush
		{
			get
			{
				short num = (short)1015095097;
				short num2 = num;
				num = (short)75833145;
				switch (num2 == num)
				{
				}
				num = (short)50200576;
				short num3 = num;
				num = (short)1267597313;
				if (num != 0)
				{
				}
				num = (short)1287847936;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.LightBorderBrushProperty);
			}
			set
			{
				short num = (short)756276565;
				short num2 = num;
				num = (short)1591008597;
				switch (num2 == num)
				{
				}
				num = (short)544669696;
				short num3 = num;
				num = (short)890830849;
				if (num != 0)
				{
				}
				num = (short)1085800448;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.LightBorderBrushProperty, value);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0002C89C File Offset: 0x0002AA9C
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0002C958 File Offset: 0x0002AB58
		public global::System.Windows.Thickness BorderThickness
		{
			get
			{
				short num = (short)375424739;
				short num2 = num;
				num = (short)379356899;
				switch (num2 == num)
				{
				}
				num = (short)656277504;
				short num3 = num;
				num = (short)2123825153;
				if (num != 0)
				{
				}
				num = (short)778240000;
				if (num != 0)
				{
				}
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.BorderThicknessProperty);
			}
			set
			{
				short num = (short)2101341788;
				short num2 = num;
				num = (short)594407004;
				switch (num2 == num)
				{
				}
				num = (short)364511232;
				short num3 = num;
				num = (short)316211201;
				if (num != 0)
				{
				}
				num = (short)2138963968;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.BorderThicknessProperty, value);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0002CA10 File Offset: 0x0002AC10
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0002CACC File Offset: 0x0002ACCC
		public global::System.Windows.Thickness Padding
		{
			get
			{
				short num = (short)1582788437;
				short num2 = num;
				num = (short)1392734037;
				switch (num2 == num)
				{
				}
				num = (short)999358464;
				short num3 = num;
				num = (short)669253633;
				if (num != 0)
				{
				}
				num = (short)2085027840;
				if (num != 0)
				{
				}
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.ButtonBorder.PaddingProperty);
			}
			set
			{
				short num = (short)1503199232;
				short num2 = num;
				num = (short)1005192207;
				short num3 = num;
				num = (short)1293812751;
				switch (num3 == num)
				{
				}
				num = (short)1585774592;
				if (num != 0)
				{
				}
				num = (short)1505558529;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonBorder.PaddingProperty, value);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0002CB88 File Offset: 0x0002AD88
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0002CC38 File Offset: 0x0002AE38
		internal global::System.Windows.Rect ExpandBounds
		{
			get
			{
				short num = (short)1189609472;
				short num2 = num;
				num = (short)22058176;
				short num3 = num;
				num = (short)1191351488;
				switch (num3 == num)
				{
				}
				num = (short)1350828033;
				if (num != 0)
				{
				}
				num = (short)2143682560;
				if (num != 0)
				{
				}
				return this.m_ExpandBounds;
			}
			set
			{
				short num = (short)1590099968;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_A2;
					}
					global::System.Windows.Rect layoutSlot;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
						{
							this.m_ExpandGeometry = new global::System.Windows.Media.StreamGeometry();
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext = this.m_ExpandGeometry.Open();
							num = (short)467533839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(this.m_ExpandBounds.Y, layoutSlot.Y))
							{
								num = (short)1087635483;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_484;
						case 2:
							num = (short)1066729475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (this.m_ExpandBounds.Right >= layoutSlot.Right)
							{
								num = (short)1483538432;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 4:
						{
							num = (short)1393164288;
							short num3 = num;
							if (this.m_ExpandBounds.Bottom >= layoutSlot.Bottom)
							{
								num = (short)1612382216;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D9;
						}
						case 5:
							if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(this.m_ExpandBounds.Y, layoutSlot.Y))
							{
								num = (short)1347485722;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4D7;
						case 6:
							if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(this.m_ExpandBounds.X, layoutSlot.X))
							{
								num = (short)560201735;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D9;
						case 7:
							num = (short)1461583876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							num = (short)1962083669;
							short num4 = num;
							num = (short)459670869;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_55E;
							default:
								num = (short)816316416;
								if (num != 0)
								{
								}
								num = (short)1021247512;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_581;
						case 10:
							if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(this.m_ExpandBounds.X, layoutSlot.X))
							{
								num = (short)1987969042;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_484;
						case 11:
							goto IL_89D;
						case 12:
							if (this.m_ExpandBounds.Bottom >= layoutSlot.Bottom)
							{
								num = (short)1710096404;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_484;
						case 13:
							if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(this.m_ExpandBounds.Y, layoutSlot.Y))
							{
								num = (short)339804162;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 14:
							try
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext2;
								streamGeometryContext2.BeginFigure(new global::System.Windows.Point(this.m_ExpandBounds.Right - 1.0, this.m_ExpandBounds.Y), true, true);
								streamGeometryContext2.LineTo(new global::System.Windows.Point(this.m_ExpandBounds.Right - 1.0, this.m_ExpandBounds.Bottom), false, false);
								streamGeometryContext2.LineTo(new global::System.Windows.Point(this.m_ExpandBounds.Right, this.m_ExpandBounds.Bottom), false, false);
								streamGeometryContext2.LineTo(new global::System.Windows.Point(this.m_ExpandBounds.Right, this.m_ExpandBounds.Y), false, false);
								goto IL_82C;
							}
							finally
							{
								num = (short)1815150592;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Windows.Media.StreamGeometryContext streamGeometryContext2;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_65E;
										}
										continue;
									case 1:
										((global::System.IDisposable)streamGeometryContext2).Dispose();
										num = (short)1399980034;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_693;
									}
									IL_65E:
									if (streamGeometryContext2 == null)
									{
										break;
									}
									num = (short)1938030593;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_693:;
							}
							goto IL_696;
						case 15:
							try
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
								streamGeometryContext.BeginFigure(new global::System.Windows.Point(this.m_ExpandBounds.X, this.m_ExpandBounds.Bottom - 1.0), true, true);
								streamGeometryContext.LineTo(new global::System.Windows.Point(this.m_ExpandBounds.Right, this.m_ExpandBounds.Bottom - 1.0), false, false);
								streamGeometryContext.LineTo(new global::System.Windows.Point(this.m_ExpandBounds.Right, this.m_ExpandBounds.Bottom), false, false);
								streamGeometryContext.LineTo(new global::System.Windows.Point(this.m_ExpandBounds.X, this.m_ExpandBounds.Bottom), false, false);
								goto IL_55E;
							}
							finally
							{
								num = (short)770637824;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_44A;
										}
										continue;
									case 1:
										((global::System.IDisposable)streamGeometryContext).Dispose();
										num = (short)481361922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_481;
									}
									IL_44A:
									if (streamGeometryContext == null)
									{
										break;
									}
									num = (short)930152449;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_481:;
							}
							goto IL_484;
						case 16:
							goto IL_696;
						case 17:
							if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(this.m_ExpandBounds.X, layoutSlot.X))
							{
								num = (short)1139933207;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 18:
							num = (short)942473217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
						{
							this.m_ExpandGeometry = new global::System.Windows.Media.StreamGeometry();
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext3 = this.m_ExpandGeometry.Open();
							num = (short)1468792857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
						{
							this.m_ExpandGeometry = new global::System.Windows.Media.StreamGeometry();
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext2 = this.m_ExpandGeometry.Open();
							num = (short)1334509582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							if (this.m_ExpandBounds.Right >= layoutSlot.Right)
							{
								num = (short)1324613648;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4D7;
						case 22:
							if (this.m_ExpandBounds.Bottom >= layoutSlot.Bottom)
							{
								num = (short)827064348;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4D7;
						case 23:
							num = (short)1829634061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							if (this.m_ExpandBounds.Right >= layoutSlot.Right)
							{
								num = (short)916127763;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D9;
						case 25:
							goto IL_868;
						case 26:
							num = (short)2062614550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							num = (short)1649475596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
						{
							this.m_ExpandGeometry = new global::System.Windows.Media.StreamGeometry();
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext4 = this.m_ExpandGeometry.Open();
							num = (short)1571029003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_A2;
						IL_484:
						num = (short)1774780422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4D7:
						num = (short)709754890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_55E:
						this.m_ExpandGeometry.Freeze();
						num = (short)1580072969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_696:
						num = (short)224264197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7D9:
						num = (short)1546846225;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_362:
					this.m_ExpandGeometry.Freeze();
					return;
					IL_581:
					return;
					IL_82C:
					this.m_ExpandGeometry.Freeze();
					return;
					IL_868:
					try
					{
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext3;
						streamGeometryContext3.BeginFigure(new global::System.Windows.Point(layoutSlot.X, this.m_ExpandBounds.Y - 1.0), true, true);
						streamGeometryContext3.LineTo(new global::System.Windows.Point(layoutSlot.Right, this.m_ExpandBounds.Y - 1.0), false, false);
						streamGeometryContext3.LineTo(new global::System.Windows.Point(layoutSlot.Right, this.m_ExpandBounds.Y), false, false);
						streamGeometryContext3.LineTo(new global::System.Windows.Point(layoutSlot.X, this.m_ExpandBounds.Y), false, false);
						goto IL_362;
					}
					finally
					{
						num = (short)1081409536;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext3;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_A37;
								}
								continue;
							case 1:
								((global::System.IDisposable)streamGeometryContext3).Dispose();
								num = (short)2100166658;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_A6E;
							}
							IL_A37:
							if (streamGeometryContext3 == null)
							{
								break;
							}
							num = (short)119013377;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_A6E:;
					}
					return;
					IL_89D:
					try
					{
						num = (short)983171073;
						if (num != 0)
						{
						}
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext4;
						streamGeometryContext4.BeginFigure(new global::System.Windows.Point(this.m_ExpandBounds.X - 1.0, this.m_ExpandBounds.Y), true, true);
						streamGeometryContext4.LineTo(new global::System.Windows.Point(this.m_ExpandBounds.X - 1.0, this.m_ExpandBounds.Bottom), false, false);
						streamGeometryContext4.LineTo(new global::System.Windows.Point(this.m_ExpandBounds.X, this.m_ExpandBounds.Bottom), false, false);
						streamGeometryContext4.LineTo(new global::System.Windows.Point(this.m_ExpandBounds.X, this.m_ExpandBounds.Y), false, false);
						goto IL_1D0;
					}
					finally
					{
						num = (short)1058340864;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext4;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_32A;
								}
								continue;
							case 1:
								((global::System.IDisposable)streamGeometryContext4).Dispose();
								num = (short)356974594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_35F;
							}
							IL_32A:
							if (streamGeometryContext4 == null)
							{
								break;
							}
							num = (short)6422529;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_35F:;
					}
					goto IL_362;
					IL_1D0:
					this.m_ExpandGeometry.Freeze();
					return;
					IL_A2:
					this.m_ExpandBounds = value;
					layoutSlot = new global::System.Windows.Rect(base.RenderSize);
					layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this);
					this.m_ExpandGeometry = null;
					num = (short)158597141;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0002D6EC File Offset: 0x0002B8EC
		private static void OnButtonClassChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1970601984;
			short num2 = num;
			num = (short)1388847477;
			short num3 = num;
			num = (short)1636114805;
			switch (num3 == num)
			{
			}
			num = (short)1935867905;
			if (num != 0)
			{
			}
			num = (short)1043791872;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.ButtonBorder)d).UpdateVisualState();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0002D7A0 File Offset: 0x0002B9A0
		private static void OnButtonStateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)604372992;
			short num2 = num;
			num = (short)867162391;
			short num3 = num;
			num = (short)618453271;
			switch (num3 == num)
			{
			}
			num = (short)1504575489;
			if (num != 0)
			{
			}
			num = (short)1417543680;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ButtonBorder buttonBorder = (global::DevComponents.WpfRibbon.ButtonBorder)d;
			global::DevComponents.WpfRibbon.eButtonRenderingState oldState = (global::DevComponents.WpfRibbon.eButtonRenderingState)e.OldValue;
			global::DevComponents.WpfRibbon.eButtonRenderingState newState = (global::DevComponents.WpfRibbon.eButtonRenderingState)e.NewValue;
			buttonBorder.UpdateOverlay(oldState, newState);
			buttonBorder.UpdateVisualState();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0002D874 File Offset: 0x0002BA74
		private void UpdateOverlay(global::DevComponents.WpfRibbon.eButtonRenderingState oldState, global::DevComponents.WpfRibbon.eButtonRenderingState newState)
		{
			short num = (short)416219140;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_180;
				case 1:
				{
					num = (short)331440833;
					short num3 = num;
					num = (short)1394565825;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_180;
					default:
						num = (short)1696727040;
						if (num != 0)
						{
						}
						num = (short)353107973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					if (oldState == global::DevComponents.WpfRibbon.eButtonRenderingState.CheckedHover)
					{
						num = (short)1404960771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_232;
				case 3:
					num = (short)1817772038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 5:
					if (oldState == global::DevComponents.WpfRibbon.eButtonRenderingState.Hover)
					{
						num = (short)181141504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_122;
				case 6:
					if (newState == global::DevComponents.WpfRibbon.eButtonRenderingState.Checked)
					{
						num = (short)21889035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_232;
				case 7:
					num = (short)396296193;
					if (num != 0)
					{
					}
					num = (short)1052966914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1B3;
				case 9:
					if (newState != global::DevComponents.WpfRibbon.eButtonRenderingState.CheckedHover)
					{
						num = (short)94175239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B5;
				case 10:
					if (newState == global::DevComponents.WpfRibbon.eButtonRenderingState.Normal)
					{
						num = (short)645398536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_122;
				case 11:
					goto IL_228;
				}
				IL_54:
				num = (short)2067988480;
				short num4 = num;
				if (newState != global::DevComponents.WpfRibbon.eButtonRenderingState.Hover)
				{
					num = (short)101449729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_122:
				num = (short)949288969;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_180:
				num = (short)150667274;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1B3:
			goto IL_22A;
			IL_1B5:
			this.CreateRendererOverlayBrushes(global::DevComponents.WpfRibbon.eButtonRenderingState.CheckedHover);
			return;
			IL_228:
			goto IL_1B5;
			IL_22A:
			this.CreateRendererOverlayBrushes(global::DevComponents.WpfRibbon.eButtonRenderingState.Hover);
			return;
			IL_232:
			this.DestroyRendererOverlayBrushes();
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0002DABC File Offset: 0x0002BCBC
		private void UpdateVisualState()
		{
			int a_ = 3;
			short num = (short)1241513985;
			if (num != 0)
			{
			}
			num = (short)1436680192;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_EC;
				}
				global::DevComponents.WpfRibbon.ButtonBorder.RenderOverlayBrushes renderOverlayBrushes;
				string colorClass;
				global::DevComponents.WpfRibbon.ButtonBorder.RenderOverlayBrushes renderOverlayBrushes2;
				for (;;)
				{
					IL_59:
					global::DevComponents.WpfRibbon.eButtonRenderingState eButtonRenderingState;
					string str;
					switch (num2)
					{
					case 0:
						eButtonRenderingState = global::DevComponents.WpfRibbon.eButtonRenderingState.Normal;
						num = (short)1945567262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (eButtonRenderingState == global::DevComponents.WpfRibbon.eButtonRenderingState.CheckedHover)
						{
							num = (short)2070478857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46E;
					case 2:
						goto IL_381;
					case 3:
						goto IL_2B1;
					case 4:
						if (renderOverlayBrushes != null)
						{
							num = (short)555614211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						num = (short)566231055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (eButtonRenderingState == global::DevComponents.WpfRibbon.eButtonRenderingState.Hover)
						{
							num = (short)287309824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)723320833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1925185550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)2067071002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						eButtonRenderingState = global::DevComponents.WpfRibbon.eButtonRenderingState.Checked;
						num = (short)682819603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (colorClass.EndsWith(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ౚ㑜⭞ॠⅢѤѦɨ౪ὬnѰᵲᅴ", a_)))
						{
							num = (short)317980680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30B;
					case 11:
						if (this.AnimationEnabled)
						{
							num = (short)2131034124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46E;
					case 12:
						num = (short)149815302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (this.ButtonState != global::DevComponents.WpfRibbon.eButtonRenderingState.Normal)
						{
							num = (short)2018312199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_381;
					case 14:
						goto IL_20B;
					case 15:
						if (this.ButtonState == global::DevComponents.WpfRibbon.eButtonRenderingState.CheckedHover)
						{
							num = (short)487194658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53E;
					case 16:
						num = (short)619053074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)1986986009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (this.ButtonState != global::DevComponents.WpfRibbon.eButtonRenderingState.Hover)
						{
							num = (short)1480720389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_272;
					case 19:
						goto IL_46E;
					case 20:
						if (renderOverlayBrushes2 != null)
						{
							num = (short)1819017237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
						goto IL_3C2;
					case 22:
						goto IL_133;
					case 23:
						if (this.AnimationEnabled)
						{
							num = (short)2076639248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53E;
					case 24:
					{
						num = (short)579469312;
						short num3 = num;
						goto IL_600;
					}
					case 25:
						if (eButtonRenderingState != global::DevComponents.WpfRibbon.eButtonRenderingState.Disabled)
						{
							num = (short)164036641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30B;
					case 26:
						if (eButtonRenderingState != global::DevComponents.WpfRibbon.eButtonRenderingState.Normal)
						{
							num = (short)1760755729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30B;
					case 27:
						if (colorClass == "")
						{
							num = (short)696188950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						eButtonRenderingState = this.ButtonState;
						num = (short)2039414795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_600;
					case 29:
					{
						if (!this.AnimationEnabled)
						{
							goto IL_3C7;
						}
						num = (short)1420775505;
						short num4 = num;
						num = (short)1649430609;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_20B;
						default:
							num = (short)386990080;
							if (num != 0)
							{
							}
							num = (short)1220345887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 30:
						goto IL_46E;
					case 31:
						num = (short)429654029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						return;
					case 33:
						str = colorClass.Substring(0, colorClass.Length - 14) + this.GetStateKey(eButtonRenderingState);
						num = (short)272498716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_272;
					}
					goto IL_EC;
					IL_20B:
					if (this.ButtonState == global::DevComponents.WpfRibbon.eButtonRenderingState.Checked)
					{
						num = (short)1124270082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C7;
					IL_272:
					renderOverlayBrushes = this.GetRenderOverlayBrushes();
					num = (short)1954283524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30B:
					str = colorClass + this.GetStateKey(eButtonRenderingState);
					num = (short)1607008280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_381:
					renderOverlayBrushes2 = this.GetRenderOverlayBrushes();
					num = (short)1424752660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C7:
					base.InvalidateVisual();
					num = (short)1253834784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46E:
					str = "";
					num = (short)1471414282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53E:
					num = (short)2106720285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_600:
					global::System.Type targetType = this.GetTargetType();
					base.SetResourceReference(global::DevComponents.WpfRibbon.ButtonBorder.BackgroundProperty, new global::System.Windows.ComponentResourceKey(targetType, str + global::DevComponents.WpfRibbon.ButtonPartColorKeys.Background));
					base.SetResourceReference(global::DevComponents.WpfRibbon.ButtonBorder.TopHighlightProperty, new global::System.Windows.ComponentResourceKey(targetType, str + global::DevComponents.WpfRibbon.ButtonPartColorKeys.TopHighlight));
					base.SetResourceReference(global::DevComponents.WpfRibbon.ButtonBorder.BottomHighlightProperty, new global::System.Windows.ComponentResourceKey(targetType, str + global::DevComponents.WpfRibbon.ButtonPartColorKeys.BottomHighlight));
					base.SetResourceReference(global::DevComponents.WpfRibbon.ButtonBorder.BorderBrushProperty, new global::System.Windows.ComponentResourceKey(targetType, str + global::DevComponents.WpfRibbon.ButtonPartColorKeys.Border));
					base.SetResourceReference(global::DevComponents.WpfRibbon.ButtonBorder.LightBorderBrushProperty, new global::System.Windows.ComponentResourceKey(targetType, str + global::DevComponents.WpfRibbon.ButtonPartColorKeys.BorderLight));
					num = (short)461504535;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_133:
				this.Background = null;
				this.TopHighlight = null;
				this.BorderBrush = null;
				this.LightBorderBrush = null;
				this.BottomHighlight = null;
				base.InvalidateVisual();
				return;
				IL_2B1:
				global::System.Windows.Duration duration = new global::System.Windows.Duration(global::System.TimeSpan.FromSeconds(0.08));
				global::System.Windows.Media.Animation.DoubleAnimation animation = new global::System.Windows.Media.Animation.DoubleAnimation(0.3, 1.0, duration);
				renderOverlayBrushes.BeginAnimation(animation);
				return;
				IL_3C2:
				global::System.Windows.Duration duration2 = new global::System.Windows.Duration(global::System.TimeSpan.FromSeconds(0.08));
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(1.0, 0.0, duration2);
				doubleAnimation.Completed += this.OverlayAnimationCompleted;
				renderOverlayBrushes2.LightBorderPen = null;
				renderOverlayBrushes2.BeginAnimation(doubleAnimation);
				return;
				IL_EC:
				colorClass = this.ColorClass;
				num = (short)630784027;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_59;
			}
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0002E228 File Offset: 0x0002C428
		private global::System.Type GetTargetType()
		{
			short num = (short)642252801;
			if (num != 0)
			{
			}
			num = (short)526702499;
			short num2 = num;
			num = (short)1310840739;
			switch (num2 == num)
			{
			}
			num = (short)1909915648;
			if (num != 0)
			{
			}
			num = (short)1617166336;
			short num3 = num;
			return typeof(global::DevComponents.WpfRibbon.Ribbon);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0002E2DC File Offset: 0x0002C4DC
		private void OverlayAnimationCompleted(object sender, global::System.EventArgs e)
		{
			short num = (short)1355677699;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A2;
				case 1:
					if (this.ButtonState == global::DevComponents.WpfRibbon.eButtonRenderingState.Checked)
					{
						num = (short)634847232;
						short num3 = num;
						num = (short)299761665;
						if (num != 0)
						{
						}
						num = (short)837025792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
				{
					num = (short)805540045;
					short num4 = num;
					num = (short)1105825997;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A2;
					default:
						num = (short)1604780032;
						if (num != 0)
						{
						}
						num = (short)1639710721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_39:
				if (this.ButtonState != global::DevComponents.WpfRibbon.eButtonRenderingState.Normal)
				{
					num = (short)1465778180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A2:
				this.DestroyRendererOverlayBrushes();
				num = (short)1945501698;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0002E43C File Offset: 0x0002C63C
		private string GetStateKey(global::DevComponents.WpfRibbon.eButtonRenderingState renderingState)
		{
			short num = (short)353828865;
			if (num != 0)
			{
			}
			num = (short)422969346;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_8D;
				case 1:
					goto IL_135;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				}
				IL_57:
				switch (renderingState)
				{
				case global::DevComponents.WpfRibbon.eButtonRenderingState.Normal:
					goto IL_E6;
				case global::DevComponents.WpfRibbon.eButtonRenderingState.Hover:
					goto IL_143;
				case global::DevComponents.WpfRibbon.eButtonRenderingState.Pressed:
					goto IL_13D;
				case global::DevComponents.WpfRibbon.eButtonRenderingState.Checked:
				{
					num = (short)90760978;
					short num3 = num;
					num = (short)532473618;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_C9;
					}
					break;
				}
				case global::DevComponents.WpfRibbon.eButtonRenderingState.CheckedHover:
					goto IL_8F;
				case global::DevComponents.WpfRibbon.eButtonRenderingState.Disabled:
					goto IL_137;
				case global::DevComponents.WpfRibbon.eButtonRenderingState.Expanded:
					goto IL_EC;
				default:
					num = (short)1592197120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8D:
				num = (short)1906769920;
				short num4 = num;
				num = (short)1267400705;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8F:
			return global::DevComponents.WpfRibbon.ButtonStateColorKeys.CheckedHover;
			IL_C9:
			num = (short)907149312;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.ButtonStateColorKeys.Checked;
			IL_E6:
			return global::DevComponents.WpfRibbon.ButtonStateColorKeys.Normal;
			IL_EC:
			return global::DevComponents.WpfRibbon.ButtonStateColorKeys.Expanded;
			IL_135:
			return global::DevComponents.WpfRibbon.ButtonStateColorKeys.Normal;
			IL_137:
			return global::DevComponents.WpfRibbon.ButtonStateColorKeys.Disabled;
			IL_13D:
			return global::DevComponents.WpfRibbon.ButtonStateColorKeys.Pressed;
			IL_143:
			return global::DevComponents.WpfRibbon.ButtonStateColorKeys.Hover;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0002E598 File Offset: 0x0002C798
		private static bool IsThicknessValid(object value)
		{
			short num = (short)1596628800;
			short num2 = num;
			num = (short)1433706304;
			switch (num2 == num)
			{
			}
			num = (short)1432289281;
			if (num != 0)
			{
			}
			num = (short)382664704;
			if (num != 0)
			{
			}
			num = (short)249757696;
			short num3 = num;
			return global::DevComponents.WpfRibbon.LayoutHelpers.IsThicknessValid(value);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0002E648 File Offset: 0x0002C848
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)1582301184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::System.Windows.UIElement child;
				global::System.Windows.Size thicknessSize;
				global::System.Windows.Size thicknessSize2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_14A;
					case 1:
						goto IL_18C;
					case 2:
						if (child != null)
						{
							goto IL_174;
						}
						goto IL_25E;
					case 3:
						num = (short)1171718145;
						if (num != 0)
						{
						}
						if (this.RenderBorder)
						{
							num = (short)1238695940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14A;
					case 4:
					{
						num = (short)986901213;
						short num3 = num;
						num = (short)1225845469;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_174;
						default:
						{
							num = (short)1653866496;
							short num4 = num;
							num = (short)1744699392;
							if (num != 0)
							{
							}
							thicknessSize = global::DevComponents.WpfRibbon.LayoutHelpers.GetThicknessSize(this.BorderThickness);
							thicknessSize.Height += 2.0;
							thicknessSize.Width += 2.0;
							num = (short)774504448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					goto IL_42;
					IL_14A:
					thicknessSize2 = global::DevComponents.WpfRibbon.LayoutHelpers.GetThicknessSize(this.Padding);
					num = (short)2095120386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_174:
					num = (short)783548417;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_18C:
				global::System.Windows.Size result = new global::System.Windows.Size(thicknessSize.Width + thicknessSize2.Width, thicknessSize.Height + thicknessSize2.Height);
				child.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				global::System.Windows.Size desiredSize = child.DesiredSize;
				result.Width = global::System.Math.Ceiling(desiredSize.Width + result.Width);
				result.Height = global::System.Math.Ceiling(desiredSize.Height + result.Height);
				return result;
				IL_25E:
				return new global::System.Windows.Size(thicknessSize.Width + thicknessSize2.Width, thicknessSize.Height + thicknessSize2.Height);
				IL_42:
				child = this.Child;
				thicknessSize = new global::System.Windows.Size(2.0, 2.0);
				num = (short)1625948163;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0002E8D8 File Offset: 0x0002CAD8
		protected override global::System.Windows.Media.HitTestResult HitTestCore(global::System.Windows.Media.PointHitTestParameters hitTestParameters)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::System.Windows.Media.HitTestResult hitTestResult;
			for (;;)
			{
				IL_0A:
				global::System.Windows.Point hitPoint;
				switch (num)
				{
				case 0:
					num2 = (short)1549664263;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)41549825;
					if (num2 != 0)
					{
					}
					hitPoint = hitTestParameters.HitPoint;
					num2 = (short)306839563;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					hitPoint = hitTestParameters.HitPoint;
					num2 = (short)389087241;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (hitPoint.X >= 0.0)
					{
						num2 = (short)15335432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return hitTestResult;
				case 4:
					if (hitPoint.Y >= 0.0)
					{
						num2 = (short)312541186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return hitTestResult;
				case 5:
					goto IL_1D4;
				case 6:
				{
					num2 = (short)1412269907;
					short num3 = num2;
					num2 = (short)1757775699;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D4;
					default:
						num2 = (short)439156736;
						if (num2 != 0)
						{
						}
						if (hitTestResult != null)
						{
							num2 = (short)1938030592;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_203;
					}
					break;
				}
				case 7:
					if (hitTestResult.VisualHit == null)
					{
						num2 = (short)1257832458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return hitTestResult;
				case 8:
					hitPoint = hitTestParameters.HitPoint;
					num2 = (short)99549188;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (hitPoint.X <= base.RenderSize.Width)
					{
						num2 = (short)67436545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return hitTestResult;
				case 10:
					goto IL_203;
				case 11:
					if (hitPoint.Y < base.RenderSize.Height)
					{
						num2 = (short)1635844108;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return hitTestResult;
				case 12:
					hitTestResult = new global::System.Windows.Media.PointHitTestResult(this, hitTestParameters.HitPoint);
					num2 = (short)487260165;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_44;
				IL_203:
				hitPoint = hitTestParameters.HitPoint;
				num2 = (short)410910723;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1D4:
			num2 = (short)994639872;
			short num4 = num2;
			return hitTestResult;
			IL_44:
			hitTestResult = base.HitTestCore(hitTestParameters);
			num2 = (short)72417286;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0002EBB4 File Offset: 0x0002CDB4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1377697792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				global::System.Windows.Rect rect;
				global::System.Windows.CornerRadius cornerRadius;
				global::System.Windows.Thickness borderThickness;
				global::System.Windows.Rect rect2;
				global::System.Windows.Media.StreamGeometryContext streamGeometryContext3;
				for (;;)
				{
					IL_28:
					global::System.Windows.UIElement child;
					switch (num2)
					{
					case 0:
						num = (short)1140981781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)432144396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_20A;
					case 3:
					{
						this.m_BackgroundGeometry = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext = this.m_BackgroundGeometry.Open();
						num = (short)1738932232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						rect.Inflate(-1.0, -1.0);
						num = (short)1237188623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_614;
					case 6:
						num = (short)1441202199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_65A;
					case 8:
						try
						{
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext, rect, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, borderThickness, false));
							goto IL_284;
						}
						finally
						{
							num = (short)164560898;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5A8;
								case 1:
								{
									num = (short)869727463;
									short num3 = num;
									num = (short)2125855975;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_5A8;
									default:
										goto IL_5FC;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_589;
									}
									continue;
								}
								IL_589:
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
								if (streamGeometryContext != null)
								{
									num = (short)296615936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_613;
								IL_5A8:
								((global::System.IDisposable)streamGeometryContext).Dispose();
								num = (short)991756289;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5FC:
							num = (short)1241972736;
							if (num != 0)
							{
							}
							IL_613:;
						}
						goto IL_614;
						IL_284:
						this.m_BackgroundGeometry.Freeze();
						num = (short)1800536080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						this.m_BorderGeometry = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext2 = this.m_BorderGeometry.Open();
						num = (short)1797586963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::System.Windows.Rect finalRect = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(rect, this.Padding);
						child.Arrange(finalRect);
						num = (short)1211826200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect.Width))
						{
							num = (short)401670150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_149;
					case 12:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect2.Height))
						{
							num = (short)434372628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_742;
					case 13:
						rect.Inflate(-1.0, -1.0);
						num = (short)1291714567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect2.Width))
						{
							num = (short)368771073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_742;
					case 15:
						goto IL_2AC;
					case 16:
						goto IL_614;
					case 17:
						if (this.RenderBorder)
						{
							num = (short)1121255428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AC;
					case 18:
						if (this.RenderBorder)
						{
							num = (short)2086207501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65A;
					case 19:
						num = (short)1759772673;
						if (num != 0)
						{
						}
						try
						{
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext2;
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext2, rect2, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, borderThickness, true));
							rect2 = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(rect2, borderThickness);
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext2, rect2, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, borderThickness, true));
							goto IL_1CF;
						}
						finally
						{
							num = (short)1314914306;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext2;
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)streamGeometryContext2).Dispose();
									num = (short)800784385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_73F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_707;
									}
									continue;
								}
								IL_707:
								if (streamGeometryContext2 == null)
								{
									break;
								}
								num = (short)893321216;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_73F:;
						}
						goto IL_742;
						IL_1CF:
						this.m_BorderGeometry.Freeze();
						this.m_LightBorderGeometry = new global::System.Windows.Media.StreamGeometry();
						streamGeometryContext3 = this.m_LightBorderGeometry.Open();
						num = (short)619249666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1093074969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (!rect.IsEmpty)
						{
							num = (short)1875247107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_149;
					case 22:
						if (child != null)
						{
							num = (short)1951334410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42F;
					case 23:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect.Height))
						{
							num = (short)6553600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_149;
					case 24:
						goto IL_42F;
					case 25:
						if (!rect2.IsEmpty)
						{
							num = (short)259260425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_742;
					}
					goto IL_97;
					IL_149:
					num = (short)390135808;
					short num4 = num;
					this.m_BackgroundGeometry = null;
					num = (short)593362949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AC:
					cornerRadius = this.CornerRadius;
					global::System.Windows.Media.Brush borderBrush = this.BorderBrush;
					global::System.Windows.Media.Brush lightBorderBrush = this.LightBorderBrush;
					num = (short)1585643531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42F:
					rect = rect2;
					num = (short)1862533137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_614:
					num = (short)535691278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65A:
					this.m_BackgroundGeometry = null;
					child = this.Child;
					num = (short)1656160278;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_20A:
				try
				{
					global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext3, rect2, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, borderThickness, false));
					rect2.Inflate(-1.0, -1.0);
					global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext3, rect2, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, borderThickness, true));
				}
				finally
				{
					num = (short)151715842;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)streamGeometryContext3).Dispose();
							num = (short)697761793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3B3;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_379;
							}
							continue;
						}
						IL_379:
						if (streamGeometryContext3 == null)
						{
							break;
						}
						num = (short)1532231680;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3B3:;
				}
				this.m_LightBorderGeometry.Freeze();
				return finalSize;
				IL_742:
				this.m_BackgroundGeometry = null;
				this.m_BorderGeometry = null;
				this.m_LightBorderGeometry = null;
				return finalSize;
				IL_97:
				borderThickness = this.BorderThickness;
				rect2 = new global::System.Windows.Rect(finalSize);
				rect = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(rect2, borderThickness);
				num = (short)819855378;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0002F344 File Offset: 0x0002D544
		// (set) Token: 0x060001EB RID: 491 RVA: 0x0002F3F4 File Offset: 0x0002D5F4
		internal global::System.Windows.Rect MouseOverInactiveRect
		{
			get
			{
				short num = (short)1948378855;
				short num2 = num;
				num = (short)1467213543;
				switch (num2 == num)
				{
				}
				num = (short)1252261889;
				if (num != 0)
				{
				}
				num = (short)1085997056;
				if (num != 0)
				{
				}
				num = (short)404750336;
				short num3 = num;
				return this.m_MouseOverInactiveRect;
			}
			set
			{
				short num = (short)494534657;
				if (num != 0)
				{
				}
				num = (short)1497497602;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_A6;
					case 1:
					{
						num = (short)2095591232;
						short num3 = num;
						num = (short)1532505920;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A6;
						default:
							goto IL_FF;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					}
					IL_57:
					if (this.m_MouseOverInactiveRect != value)
					{
						num = (short)1485832192;
						short num4 = num;
						num = (short)244645888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_A6:
					this.m_MouseOverInactiveRect = value;
					base.InvalidateVisual();
					num = (short)154861569;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FF:
				num = (short)601161728;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0002F518 File Offset: 0x0002D718
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			short num = (short)384892928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_18E;
				}
				global::DevComponents.WpfRibbon.ButtonBorder.RenderOverlayBrushes renderOverlayBrushes;
				global::System.Windows.Media.Brush brush;
				float num5;
				for (;;)
				{
					IL_27:
					bool renderBorder;
					switch (num2)
					{
					case 0:
						goto IL_5EE;
					case 1:
						if (this.m_ExpandGeometry != null)
						{
							num = (short)605618193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B2;
					case 2:
						if (renderOverlayBrushes != null)
						{
							num = (short)1446379530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EE;
					case 3:
						brush = renderOverlayBrushes.TopHighlight;
						dc.DrawGeometry(brush, null, this.m_BackgroundGeometry);
						num = (short)1097269257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						brush = renderOverlayBrushes.Background;
						dc.DrawGeometry(brush, null, this.m_BackgroundGeometry);
						num = (short)1387593746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						dc.PushClip(this.m_BackgroundGeometry);
						dc.DrawRectangle(null, renderOverlayBrushes.LightBorderPen, this.m_ExpandBounds);
						dc.Pop();
						num = (short)257818624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1925185605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						brush = renderOverlayBrushes.BottomHighlight;
						dc.DrawGeometry(brush, null, this.m_BackgroundGeometry);
						num = (short)294125654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_262;
					case 9:
						goto IL_58F;
					case 10:
						num = (short)1169817623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.m_BackgroundGeometry != null)
						{
							num = (short)1701642245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EE;
					case 12:
						num = (short)1523646475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						dc.DrawGeometry(brush, null, this.m_ExpandGeometry);
						num = (short)1193017406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (renderOverlayBrushes != null)
						{
							num = (short)1415577641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D91;
					case 15:
						if (this.InactiveOverlayBrush != null)
						{
							num = (short)1300561921;
							if (num != 0)
							{
							}
							num = (short)884473939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E7;
					case 16:
						if (renderOverlayBrushes.BottomHighlight != null)
						{
							num = (short)1609826311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92C;
					case 17:
						dc.DrawGeometry(brush, null, this.m_ExpandGeometry);
						num = (short)1515454502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_DCD;
					case 19:
						if (renderOverlayBrushes.LightBorderPen != null)
						{
							num = (short)805437520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EE;
					case 20:
						num = (short)1980039214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						dc.DrawGeometry(brush, null, this.m_BackgroundGeometry);
						num = (short)1802305544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						dc.DrawGeometry(brush, null, this.m_BorderGeometry);
						num = (short)900005953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (renderOverlayBrushes.BorderBrush != null)
						{
							num = (short)1929117732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EE;
					case 24:
						goto IL_670;
					case 25:
						if (renderOverlayBrushes.BottomHighlight != null)
						{
							num = (short)1517355075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_98F;
					case 26:
						num = (short)1201209360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						brush = this.Background;
						num = (short)438566996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (this.m_BorderGeometry != null)
						{
							num = (short)1476132923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 29:
						if (renderBorder)
						{
							num = (short)464584789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_469;
					case 30:
						brush = renderOverlayBrushes.LightBorderBrush;
						dc.DrawGeometry(brush, null, this.m_LightBorderGeometry);
						num = (short)295501867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (brush == null)
						{
							num = (short)1419903030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_806;
					case 32:
						if (renderOverlayBrushes.Background != null)
						{
							num = (short)1925906436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DCD;
					case 33:
						if (renderOverlayBrushes != null)
						{
							num = (short)48693329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CA;
					case 34:
						if (renderOverlayBrushes.LightBorderBrush != null)
						{
							num = (short)1466171422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D91;
					case 35:
						goto IL_7CA;
					case 36:
						num = (short)1730084883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)675086361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_5B2;
					case 39:
						num = (short)1586167823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)1480851489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)1554251810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
					{
						dc.DrawGeometry(brush, null, this.m_LightBorderGeometry);
						num = (short)971815630;
						short num3 = num;
						num = (short)825211598;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_71C;
						default:
							num = (short)1912668160;
							if (num != 0)
							{
							}
							num = (short)1367605296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 43:
						goto IL_D91;
					case 44:
						if (this.m_ExpandGeometry != null)
						{
							num = (short)135397389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 45:
						goto IL_ADA;
					case 46:
						if (this.m_LightBorderGeometry != null)
						{
							num = (short)2138767424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D91;
					case 47:
						if (renderOverlayBrushes.TopHighlight != null)
						{
							num = (short)1155661827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58F;
					case 48:
						goto IL_E52;
					case 49:
						goto IL_98F;
					case 50:
						if (brush != null)
						{
							num = (short)574554112;
							short num4 = num;
							num = (short)1554710549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_262;
					case 51:
						num = (short)347144239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (renderOverlayBrushes != null)
						{
							num = (short)883818533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_98F;
					case 53:
						goto IL_469;
					case 54:
						num = (short)958332980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						dc.DrawGeometry(brush, null, this.m_BackgroundGeometry);
						num = (short)1068826648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (brush == null)
						{
							num = (short)334757928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ADA;
					case 57:
						if (renderOverlayBrushes != null)
						{
							num = (short)2078605383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DCD;
					case 58:
						if (renderOverlayBrushes != null)
						{
							num = (short)1829437446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 59:
						brush = this.BorderBrush;
						num = (short)258080847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						if (brush != null)
						{
							num = (short)304939050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E52;
					case 61:
						if (renderBorder)
						{
							num = (short)577962004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D91;
					case 62:
						return;
					case 63:
						if (renderBorder)
						{
							num = (short)1762394134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE1;
					case 64:
						brush = this.LightBorderBrush;
						num = (short)281935932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_CE1;
					case 66:
						if (!this.m_MouseOverInactiveRect.IsEmpty)
						{
							num = (short)815071271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E7;
					case 67:
						goto IL_71C;
					case 68:
						brush = renderOverlayBrushes.BorderBrush;
						num = (short)1903689757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (renderOverlayBrushes.BorderBrush != null)
						{
							num = (short)1239875652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 70:
						goto IL_8E7;
					case 71:
						num = (short)882769952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						goto IL_A48;
					case 73:
						num = (short)1721958463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (this.m_BackgroundGeometry != null)
						{
							num = (short)1071054875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E7;
					case 75:
						if (renderOverlayBrushes != null)
						{
							num = (short)947519539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58F;
					case 76:
						if (renderOverlayBrushes != null)
						{
							num = (short)2030239770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92C;
					case 77:
						dc.DrawGeometry(brush, null, this.m_BackgroundGeometry);
						num = (short)327286856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						if (brush != null)
						{
							num = (short)1255735351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_670;
					case 79:
						if (brush != null)
						{
							num = (short)1565392969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B2;
					case 80:
						num = (short)25362514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						num = (short)1137770583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(this.m_ExpandBounds))
						{
							num = (short)491388940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EE;
					case 83:
						dc.PushClip(this.m_BackgroundGeometry);
						dc.DrawRectangle(this.InactiveOverlayBrush, null, this.m_MouseOverInactiveRect);
						dc.Pop();
						num = (short)2020278342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						if (brush != null)
						{
							num = (short)663158861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A48;
					case 85:
						dc.DrawGeometry(brush, null, this.m_BorderGeometry);
						num = (short)2142699573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						goto IL_92C;
					case 87:
						if (renderOverlayBrushes.TopHighlight != null)
						{
							num = (short)2014838829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CA;
					}
					goto IL_18E;
					IL_262:
					num = (short)523436107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_469:
					num = (short)333381676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58F:
					dc.Pop();
					num = (short)1343356963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B2:
					num = (short)163250234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5EE:
					num = (short)620298268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_670:
					num = (short)715522124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7CA:
					brush = this.BottomHighlight;
					num = (short)2109079583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_806:
					dc.PushClip(new global::System.Windows.Media.RectangleGeometry(new global::System.Windows.Rect(0.0, base.ActualHeight * (double)num5, base.ActualWidth, base.ActualHeight * (double)(1f - num5))));
					num = (short)1360855118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_71C:
					goto IL_806;
					IL_8E7:
					renderBorder = this.RenderBorder;
					num = (short)872087613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_92C:
					dc.Pop();
					num = (short)1170276401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_98F:
					num = (short)1411514434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A48:
					num = (short)1200881721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ADA:
					dc.PushClip(new global::System.Windows.Media.RectangleGeometry(new global::System.Windows.Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight * (double)num5)));
					num = (short)1176698930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CE1:
					num = (short)413466625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D91:
					num = (short)1477771266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DCD:
					brush = this.TopHighlight;
					num = (short)116719672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E52:
					num = (short)833028110;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_18E:
				renderOverlayBrushes = this.GetRenderOverlayBrushes();
				brush = null;
				num5 = 0.4f;
				num = (short)2030108746;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000303B0 File Offset: 0x0002E5B0
		private static bool IsCornerRadiusValid(object value)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::System.Windows.CornerRadius cornerRadius;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2034434053;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (cornerRadius.BottomLeft >= 0.0)
					{
						num2 = (short)1758330880;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)760836847;
					short num3 = num2;
					num2 = (short)756708079;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)924975104;
						if (num2 != 0)
						{
						}
						num2 = (short)832503814;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					num2 = (short)259325956;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1318322177;
					if (num2 != 0)
					{
					}
					if (cornerRadius.TopLeft >= 0.0)
					{
						num2 = (short)2071527426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
				{
					num2 = (short)785121280;
					short num4 = num2;
					if (cornerRadius.BottomRight >= 0.0)
					{
						num2 = (short)1185742851;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 6:
					if (cornerRadius.TopRight >= 0.0)
					{
						num2 = (short)403505159;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					return true;
				}
				goto IL_30;
			}
			return true;
			IL_30:
			cornerRadius = (global::System.Windows.CornerRadius)value;
			num2 = (short)1000210433;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000305B0 File Offset: 0x0002E7B0
		private bool AnimationEnabled
		{
			get
			{
				short num = (short)274202625;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1469186049;
						if (num != 0)
						{
						}
						num = (short)1196425220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 2:
					{
						num = (short)1477640192;
						short num3 = num;
						num = (short)2143617029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)1948527135;
						short num4 = num;
						num = (short)1806117407;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)2084241408;
							if (num != 0)
							{
							}
							num = (short)632291334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						if (global::System.Windows.SystemParameters.ClientAreaAnimation)
						{
							num = (short)769130498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						if (global::System.Windows.Media.RenderCapability.Tier > 0)
						{
							num = (short)1522335747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						if (base.IsEnabled)
						{
							num = (short)955777031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						goto IL_11B;
					}
					IL_45:
					if (global::System.Windows.SystemParameters.PowerLineStatus != global::System.Windows.PowerLineStatus.Online)
					{
						return false;
					}
					num = (short)1919746048;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				return this.m_Animation;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00030780 File Offset: 0x0002E980
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00030830 File Offset: 0x0002EA30
		internal bool Animation
		{
			get
			{
				short num = (short)393281536;
				short num2 = num;
				num = (short)538371712;
				short num3 = num;
				num = (short)1874716288;
				switch (num3 == num)
				{
				}
				num = (short)305135617;
				if (num != 0)
				{
				}
				num = (short)1143668736;
				if (num != 0)
				{
				}
				return this.m_Animation;
			}
			set
			{
				short num = (short)1005912064;
				short num2 = num;
				num = (short)461496455;
				short num3 = num;
				num = (short)1566761095;
				switch (num3 == num)
				{
				}
				num = (short)2075852801;
				if (num != 0)
				{
				}
				num = (short)234422272;
				if (num != 0)
				{
				}
				this.m_Animation = value;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000308E4 File Offset: 0x0002EAE4
		private global::DevComponents.WpfRibbon.ButtonBorder.RenderOverlayBrushes GetRenderOverlayBrushes()
		{
			short num = (short)343015425;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.AnimationEnabled)
					{
						goto IL_EA;
					}
					goto IL_12C;
				case 1:
				{
					num = (short)2010850190;
					short num3 = num;
					num = (short)1512579982;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EA;
					case 1:
						break;
					default:
					{
						num = (short)1854144512;
						short num4 = num;
						break;
					}
					}
					num = (short)1255669760;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_AE;
					}
					continue;
				}
				case 2:
					goto IL_12A;
				case 3:
					num = (short)219807744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AE:
				if (base.IsEnabled)
				{
					num = (short)1099825155;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_EA:
				num = (short)987693057;
				if (num != 0)
				{
				}
				num = (short)2059141122;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CC:
			return null;
			IL_12A:
			goto IL_CC;
			IL_12C:
			return this.m_RenderBrushes;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00030A24 File Offset: 0x0002EC24
		private void DestroyRendererOverlayBrushes()
		{
			object resourceAccessLock = this.m_ResourceAccessLock;
			bool flag = false;
			short num;
			try
			{
				global::System.Threading.Monitor.Enter(resourceAccessLock, ref flag);
				this.m_RenderBrushes = null;
			}
			finally
			{
				num = (short)528351233;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)781012776;
						short num3 = num;
						num = (short)895045416;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_73;
						default:
							goto IL_BD;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_51;
						}
						continue;
					case 2:
						global::System.Threading.Monitor.Exit(resourceAccessLock);
						goto IL_73;
					}
					IL_51:
					if (flag)
					{
						num = (short)1745551362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D5;
					IL_73:
					num = (short)1621164032;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BD:
				num = (short)1794834432;
				if (num != 0)
				{
				}
				IL_D5:;
			}
			num = (short)1810366465;
			if (num != 0)
			{
			}
			num = (short)71958528;
			short num4 = num;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00030B6C File Offset: 0x0002ED6C
		private void CreateRendererOverlayBrushes(global::DevComponents.WpfRibbon.eButtonRenderingState renderingState)
		{
			int a_ = 18;
			short num = (short)425852928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1477115905;
				if (num != 0)
				{
				}
				num = (short)496238592;
				short num3 = num;
				object resourceAccessLock = this.m_ResourceAccessLock;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_E6;
					}
					string colorClass;
					for (;;)
					{
						IL_8B:
						global::System.Windows.Media.Brush brush;
						string str;
						global::System.Type targetType;
						switch (num2)
						{
						case 0:
							this.m_RenderBrushes.BorderBrush = brush.Clone();
							num = (short)1673527302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (brush != null)
							{
								num = (short)498466824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C9;
						case 2:
							if (brush != null)
							{
								num = (short)1679753228;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_501;
						case 3:
							goto IL_146;
						case 4:
							if (brush != null)
							{
								num = (short)406388756;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20E;
						case 5:
							goto IL_3C9;
						case 6:
							goto IL_33E;
						case 7:
							goto IL_51A;
						case 8:
							this.m_RenderBrushes.Background = brush.Clone();
							num = (short)21823493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							str = colorClass.Substring(0, colorClass.Length - 14) + this.GetStateKey(renderingState);
							num = (short)1305673731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							targetType = this.GetTargetType();
							str = colorClass + this.GetStateKey(renderingState);
							num = (short)1792081935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							this.m_RenderBrushes.TopHighlight = brush.Clone();
							num = (short)525008914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							this.m_RenderBrushes.LightBorderBrush = brush.Clone();
							this.m_RenderBrushes.LightBorderPen = new global::System.Windows.Media.Pen(brush, 1.0);
							num = (short)1500643341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_501;
						case 14:
							if (colorClass != "")
							{
								num = (short)1229193226;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_501;
						case 15:
							if (colorClass.EndsWith(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㵩իᩭᡯぱᕳᕵ፷ᵹ๻ᅽ", a_)))
							{
								num = (short)639303689;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_146;
						case 16:
							goto IL_20E;
						case 17:
							if (brush != null)
							{
								num = (short)1746337803;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B4;
						case 18:
							goto IL_2B4;
						case 19:
							if (brush != null)
							{
								num = (short)1456144384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_33E;
						case 20:
							this.m_RenderBrushes.BottomHighlight = brush.Clone();
							num = (short)1288568848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E6;
						IL_146:
						brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(targetType, str + global::DevComponents.WpfRibbon.ButtonPartColorKeys.Background)) as global::System.Windows.Media.Brush);
						num = (short)1046282241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_20E:
						brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(targetType, str + global::DevComponents.WpfRibbon.ButtonPartColorKeys.Border)) as global::System.Windows.Media.Brush);
						num = (short)1882062867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B4:
						brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(targetType, str + global::DevComponents.WpfRibbon.ButtonPartColorKeys.BottomHighlight)) as global::System.Windows.Media.Brush);
						num = (short)1929379844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_35D:
						num = (short)1630666754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3C9:
						num = (short)2103362996;
						short num4 = num;
						num = (short)2031142324;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_35D;
						default:
							num = (short)25362432;
							if (num != 0)
							{
							}
							brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(targetType, str + global::DevComponents.WpfRibbon.ButtonPartColorKeys.TopHighlight)) as global::System.Windows.Media.Brush);
							num = (short)968687633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_33E:
						brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(targetType, str + global::DevComponents.WpfRibbon.ButtonPartColorKeys.BorderLight)) as global::System.Windows.Media.Brush);
						goto IL_35D;
						IL_501:
						num = (short)871497735;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_51A:
					return;
					IL_E6:
					global::System.Threading.Monitor.Enter(resourceAccessLock, ref flag);
					this.m_RenderBrushes = new global::DevComponents.WpfRibbon.ButtonBorder.RenderOverlayBrushes();
					colorClass = this.ColorClass;
					num = (short)650051598;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_8B;
				}
				finally
				{
					num = (short)1664221185;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_584;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_54E;
							}
							continue;
						case 2:
							global::System.Threading.Monitor.Exit(resourceAccessLock);
							num = (short)1444741120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_54E:
						if (!flag)
						{
							break;
						}
						num = (short)439418882;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_584:;
				}
				return;
			}
			}
		}

		// Token: 0x04000099 RID: 153
		public static readonly global::System.Windows.DependencyProperty InactiveOverlayBrushProperty;

		// Token: 0x0400009A RID: 154
		public static readonly global::System.Windows.DependencyProperty BackgroundProperty;

		// Token: 0x0400009B RID: 155
		public static readonly global::System.Windows.DependencyProperty TopHighlightProperty;

		// Token: 0x0400009C RID: 156
		public static readonly global::System.Windows.DependencyProperty BottomHighlightProperty;

		// Token: 0x0400009D RID: 157
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x0400009E RID: 158
		public static readonly global::System.Windows.DependencyProperty BorderThicknessProperty;

		// Token: 0x0400009F RID: 159
		public static readonly global::System.Windows.DependencyProperty LightBorderBrushProperty;

		// Token: 0x040000A0 RID: 160
		public static readonly global::System.Windows.DependencyProperty PaddingProperty;

		// Token: 0x040000A1 RID: 161
		public static readonly global::System.Windows.DependencyProperty CornerRadiusProperty;

		// Token: 0x040000A2 RID: 162
		public static readonly global::System.Windows.DependencyProperty ButtonStateProperty;

		// Token: 0x040000A3 RID: 163
		public static readonly global::System.Windows.DependencyProperty ColorClassProperty;

		// Token: 0x040000A4 RID: 164
		public static readonly global::System.Windows.DependencyProperty RenderBorderProperty;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Media.StreamGeometry m_BackgroundGeometry;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Media.StreamGeometry m_BorderGeometry;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Media.StreamGeometry m_LightBorderGeometry;

		// Token: 0x040000A8 RID: 168
		private global::DevComponents.WpfRibbon.ButtonBorder.RenderOverlayBrushes m_RenderBrushes;

		// Token: 0x040000A9 RID: 169
		private const double FadeDuration = 0.08;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Rect m_ExpandBounds = global::System.Windows.Rect.Empty;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Media.StreamGeometry m_ExpandGeometry;

		// Token: 0x040000AC RID: 172
		private bool m_Animation = true;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Rect m_MouseOverInactiveRect = global::System.Windows.Rect.Empty;

		// Token: 0x040000AE RID: 174
		private object m_ResourceAccessLock = new object();

		// Token: 0x02000010 RID: 16
		private class RenderOverlayBrushes
		{
			// Token: 0x060001F4 RID: 500 RVA: 0x0003111C File Offset: 0x0002F31C
			internal void BeginAnimation(global::System.Windows.Media.Animation.DoubleAnimation animation1)
			{
				short num = (short)271843341;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_18B;
					case 1:
						return;
					case 2:
						goto IL_14D;
					case 3:
					{
						this.BorderBrush.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)1221956468;
						short num3 = num;
						num = (short)846435188;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_186;
						default:
							num = (short)95682560;
							if (num != 0)
							{
							}
							num = (short)674234369;
							if (num != 0)
							{
							}
							num = (short)1350238208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_289;
					case 5:
						goto IL_186;
					case 6:
						this.LightBorderBrush.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)1384185857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.TopHighlight != null)
						{
							num = (short)716636165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_289;
					case 8:
						this.Background.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)1850867714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.BorderBrush != null)
						{
							num = (short)58851331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18B;
					case 10:
						this.BottomHighlight.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)1951531019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_1F7;
					case 12:
						if (this.LightBorderBrush != null)
						{
							num = (short)742916102;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 14:
						if (this.BottomHighlight != null)
						{
							num = (short)574881802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F7;
					}
					IL_60:
					if (this.Background != null)
					{
						num = (short)1333067784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_14D:
					num = (short)1743847431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_186:
					this.TopHighlight.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
					num = (short)515309572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18B:
					num = (short)829227020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F7:
					num = (short)1965359104;
					short num4 = num;
					num = (short)880410633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_289:
					num = (short)2018836494;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x040000AF RID: 175
			public global::System.Windows.Media.Brush Background;

			// Token: 0x040000B0 RID: 176
			public global::System.Windows.Media.Brush TopHighlight;

			// Token: 0x040000B1 RID: 177
			public global::System.Windows.Media.Brush BottomHighlight;

			// Token: 0x040000B2 RID: 178
			public global::System.Windows.Media.Brush BorderBrush;

			// Token: 0x040000B3 RID: 179
			public global::System.Windows.Media.Brush LightBorderBrush;

			// Token: 0x040000B4 RID: 180
			public global::System.Windows.Media.Pen LightBorderPen;
		}
	}
}
