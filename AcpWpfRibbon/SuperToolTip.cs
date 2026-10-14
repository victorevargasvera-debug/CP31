using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x020000A3 RID: 163
	[global::System.Windows.TemplatePart(Name = "PART_TooltipBorder", Type = typeof(global::System.Windows.Controls.Decorator))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SuperToolTip : global::System.Windows.Controls.ToolTip
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x000BC7CC File Offset: 0x000BA9CC
		static SuperToolTip()
		{
			int a_ = 11;
			short num = (short)1579435740;
			short num2 = num;
			num = (short)598558428;
			switch (num2 == num)
			{
			}
			num = (short)544276480;
			if (num != 0)
			{
			}
			num = (short)681771008;
			short num3 = num;
			num = (short)1529151489;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.SuperToolTip), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.SuperToolTip)));
			global::DevComponents.WpfRibbon.SuperToolTip.HeaderProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.SuperToolTip), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.SuperToolTip.OnHeaderChanged)));
			global::DevComponents.WpfRibbon.SuperToolTip.HeaderTemplateProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.SuperToolTip));
			global::DevComponents.WpfRibbon.SuperToolTip.HasHeaderPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭢ѤᑦⅨ๪౬୮ᑰŲ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.SuperToolTip), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.SuperToolTip.HasHeaderProperty = global::DevComponents.WpfRibbon.SuperToolTip.HasHeaderPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.SuperToolTip.HeaderTemplateSelectorProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.SuperToolTip), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.SuperToolTip.FooterProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("╢੤ࡦᵨ๪Ὤ", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.SuperToolTip), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.SuperToolTip.OnFooterChanged)));
			global::DevComponents.WpfRibbon.SuperToolTip.FooterTemplateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("╢੤ࡦᵨ๪Ὤ㭮ᑰṲմ᭶ᡸེ᡼", a_), typeof(global::System.Windows.DataTemplate), typeof(global::DevComponents.WpfRibbon.SuperToolTip), new global::System.Windows.PropertyMetadata(null));
			global::DevComponents.WpfRibbon.SuperToolTip.HasFooterPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭢Ѥᑦ⽨Ѫɬ᭮ᑰŲ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.SuperToolTip), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.SuperToolTip.HasFooterProperty = global::DevComponents.WpfRibbon.SuperToolTip.HasFooterPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.SuperToolTip.FooterTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("╢੤ࡦᵨ๪Ὤ㭮ᑰṲմ᭶ᡸེ᡼Ȿﶈﾌ", a_), typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::DevComponents.WpfRibbon.SuperToolTip), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.SuperToolTip.FooterImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("╢੤ࡦᵨ๪Ὤ♮ᱰቲቴቶ", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.SuperToolTip), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000BCA64 File Offset: 0x000BAC64
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x000BCB18 File Offset: 0x000BAD18
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.Bindable(true)]
		public object Header
		{
			get
			{
				short num = (short)709884340;
				short num2 = num;
				num = (short)1110374836;
				switch (num2 == num)
				{
				}
				num = (short)1686372352;
				if (num != 0)
				{
				}
				num = (short)22478848;
				short num3 = num;
				num = (short)29097985;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.SuperToolTip.HeaderProperty);
			}
			set
			{
				short num = (short)1114329974;
				short num2 = num;
				num = (short)926176118;
				switch (num2 == num)
				{
				}
				num = (short)721354753;
				if (num != 0)
				{
				}
				num = (short)1702166528;
				short num3 = num;
				num = (short)530776064;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.SuperToolTip.HeaderProperty, value);
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x000BCBD0 File Offset: 0x000BADD0
		private static void OnHeaderChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)354344805;
			short num2 = num;
			num = (short)1458364261;
			switch (num2 == num)
			{
			}
			num = (short)8781824;
			if (num != 0)
			{
			}
			num = (short)1983250432;
			short num3 = num;
			num = (short)1956708353;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.SuperToolTip superToolTip = (global::DevComponents.WpfRibbon.SuperToolTip)d;
			superToolTip.SetValue(global::DevComponents.WpfRibbon.SuperToolTip.HasHeaderPropertyKey, e.NewValue != null);
			superToolTip.OnHeaderChanged(e.OldValue, e.NewValue);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000BCCB4 File Offset: 0x000BAEB4
		protected virtual void OnHeaderChanged(object oldHeader, object newHeader)
		{
			short num = (short)1909915651;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.RemoveLogicalChild(oldHeader);
					num = (short)2099576833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_79;
				case 2:
				{
					num = (short)1428408012;
					short num3 = num;
					num = (short)818661068;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3F;
					default:
						num = (short)287309824;
						if (num != 0)
						{
						}
						if (newHeader != null)
						{
							num = (short)1111293953;
							if (num != 0)
							{
							}
							num = (short)2013659136;
							short num4 = num;
							num = (short)1182466053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					return;
				case 5:
					base.AddLogicalChild(newHeader);
					num = (short)1456275460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_3C;
				IL_3F:
				num = (short)787939328;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C:
				if (oldHeader != null)
				{
					goto IL_3F;
				}
				IL_79:
				num = (short)250937346;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x000BCE34 File Offset: 0x000BB034
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x000BCEF0 File Offset: 0x000BB0F0
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate HeaderTemplate
		{
			get
			{
				short num = (short)713949185;
				if (num != 0)
				{
				}
				num = (short)1398144067;
				short num2 = num;
				num = (short)1144585283;
				switch (num2 == num)
				{
				}
				num = (short)2123038720;
				short num3 = num;
				num = (short)2091581440;
				if (num != 0)
				{
				}
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfRibbon.SuperToolTip.HeaderTemplateProperty);
			}
			set
			{
				short num = (short)1024357435;
				short num2 = num;
				num = (short)499348539;
				switch (num2 == num)
				{
				}
				num = (short)542048257;
				if (num != 0)
				{
				}
				num = (short)1272512512;
				short num3 = num;
				num = (short)1732771840;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.SuperToolTip.HeaderTemplateProperty, value);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x000BCFA8 File Offset: 0x000BB1A8
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x000BD064 File Offset: 0x000BB264
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector HeaderTemplateSelector
		{
			get
			{
				short num = (short)456509871;
				short num2 = num;
				num = (short)2061945263;
				switch (num2 == num)
				{
				}
				num = (short)830078977;
				if (num != 0)
				{
				}
				num = (short)643235840;
				short num3 = num;
				num = (short)997982208;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfRibbon.SuperToolTip.HeaderTemplateSelectorProperty);
			}
			set
			{
				short num = (short)917936982;
				short num2 = num;
				num = (short)1842846550;
				switch (num2 == num)
				{
				}
				num = (short)358940673;
				if (num != 0)
				{
				}
				num = (short)295305216;
				short num3 = num;
				num = (short)382205952;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.SuperToolTip.HeaderTemplateSelectorProperty, value);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x000BD11C File Offset: 0x000BB31C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(false)]
		public bool HasHeader
		{
			get
			{
				short num = (short)698998773;
				short num2 = num;
				num = (short)200859637;
				switch (num2 == num)
				{
				}
				num = (short)802357249;
				if (num != 0)
				{
				}
				num = (short)1829634048;
				short num3 = num;
				num = (short)837025792;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.SuperToolTip.HasHeaderProperty);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x000BD1D4 File Offset: 0x000BB3D4
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x000BD288 File Offset: 0x000BB488
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Category("Content")]
		public object FooterImage
		{
			get
			{
				short num = (short)1071542319;
				short num2 = num;
				num = (short)854552623;
				switch (num2 == num)
				{
				}
				num = (short)520290305;
				if (num != 0)
				{
				}
				num = (short)1620246528;
				short num3 = num;
				num = (short)297598976;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.SuperToolTip.FooterImageProperty);
			}
			set
			{
				short num = (short)1595788856;
				short num2 = num;
				num = (short)177196600;
				switch (num2 == num)
				{
				}
				num = (short)252379137;
				if (num != 0)
				{
				}
				num = (short)614465536;
				short num3 = num;
				num = (short)449642496;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.SuperToolTip.FooterImageProperty, value);
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x000BD340 File Offset: 0x000BB540
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x000BD3F4 File Offset: 0x000BB5F4
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.Bindable(true)]
		public object Footer
		{
			get
			{
				short num = (short)1130372043;
				short num2 = num;
				num = (short)1105927115;
				switch (num2 == num)
				{
				}
				num = (short)391577601;
				if (num != 0)
				{
				}
				num = (short)244187136;
				short num3 = num;
				num = (short)2134704128;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.SuperToolTip.FooterProperty);
			}
			set
			{
				short num = (short)1323012098;
				short num2 = num;
				num = (short)1491832834;
				switch (num2 == num)
				{
				}
				num = (short)518782976;
				if (num != 0)
				{
				}
				num = (short)1604321280;
				short num3 = num;
				num = (short)258342913;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.SuperToolTip.FooterProperty, value);
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000BD4A8 File Offset: 0x000BB6A8
		private static void OnFooterChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1810114641;
			short num2 = num;
			num = (short)60958801;
			switch (num2 == num)
			{
			}
			num = (short)165085184;
			if (num != 0)
			{
			}
			num = (short)1471873024;
			short num3 = num;
			num = (short)968491009;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.SuperToolTip superToolTip = (global::DevComponents.WpfRibbon.SuperToolTip)d;
			superToolTip.SetValue(global::DevComponents.WpfRibbon.SuperToolTip.HasFooterPropertyKey, e.NewValue != null);
			superToolTip.OnFooterChanged(e.OldValue, e.NewValue);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x000BD590 File Offset: 0x000BB790
		protected virtual void OnFooterChanged(object oldFooter, object newFooter)
		{
			short num = (short)895680515;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.RemoveLogicalChild(oldFooter);
					num = (short)1479868417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)458817537;
					if (num != 0)
					{
					}
					goto IL_7A;
				case 2:
				{
					num = (short)1519666121;
					short num3 = num;
					num = (short)2027176905;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_40;
					default:
						num = (short)606797824;
						if (num != 0)
						{
						}
						if (newFooter != null)
						{
							num = (short)1609105413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
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
					return;
				case 5:
				{
					num = (short)1066926080;
					short num4 = num;
					base.AddLogicalChild(newFooter);
					num = (short)1641676804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_3D;
				IL_40:
				num = (short)1905917952;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D:
				if (oldFooter != null)
				{
					goto IL_40;
				}
				IL_7A:
				num = (short)1674641410;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x000BD70C File Offset: 0x000BB90C
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x000BD7C4 File Offset: 0x000BB9C4
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate FooterTemplate
		{
			get
			{
				short num = (short)1078067201;
				if (num != 0)
				{
				}
				num = (short)1877651777;
				short num2 = num;
				num = (short)569684289;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1785135104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1814102016;
				if (num != 0)
				{
				}
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfRibbon.SuperToolTip.FooterTemplateProperty);
			}
			set
			{
				short num = (short)2145290039;
				short num2 = num;
				num = (short)1669302071;
				switch (num2 == num)
				{
				}
				num = (short)132972544;
				short num3 = num;
				num = (short)1628569601;
				if (num != 0)
				{
				}
				num = (short)1999699968;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.SuperToolTip.FooterTemplateProperty, value);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x000BD87C File Offset: 0x000BBA7C
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x000BD938 File Offset: 0x000BBB38
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector FooterTemplateSelector
		{
			get
			{
				short num = (short)714739169;
				short num2 = num;
				num = (short)312151521;
				switch (num2 == num)
				{
				}
				num = (short)2022965248;
				short num3 = num;
				num = (short)1620246528;
				if (num != 0)
				{
				}
				num = (short)647757825;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfRibbon.SuperToolTip.HeaderTemplateSelectorProperty);
			}
			set
			{
				short num = (short)1866272849;
				short num2 = num;
				num = (short)1544818769;
				switch (num2 == num)
				{
				}
				num = (short)1857159168;
				short num3 = num;
				num = (short)14352385;
				if (num != 0)
				{
				}
				num = (short)701431808;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.SuperToolTip.HeaderTemplateSelectorProperty, value);
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x000BD9EC File Offset: 0x000BBBEC
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasFooter
		{
			get
			{
				short num = (short)1011520631;
				short num2 = num;
				num = (short)153457783;
				switch (num2 == num)
				{
				}
				num = (short)679936000;
				short num3 = num;
				num = (short)806944768;
				if (num != 0)
				{
				}
				num = (short)328073217;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.SuperToolTip.HasFooterProperty);
			}
		}

		// Token: 0x040006B8 RID: 1720
		public static readonly global::System.Windows.DependencyProperty HeaderProperty;

		// Token: 0x040006B9 RID: 1721
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateProperty;

		// Token: 0x040006BA RID: 1722
		internal static readonly global::System.Windows.DependencyPropertyKey HasHeaderPropertyKey;

		// Token: 0x040006BB RID: 1723
		public static readonly global::System.Windows.DependencyProperty HasHeaderProperty;

		// Token: 0x040006BC RID: 1724
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateSelectorProperty;

		// Token: 0x040006BD RID: 1725
		public static readonly global::System.Windows.DependencyProperty FooterProperty;

		// Token: 0x040006BE RID: 1726
		public static readonly global::System.Windows.DependencyProperty FooterTemplateProperty;

		// Token: 0x040006BF RID: 1727
		internal static readonly global::System.Windows.DependencyPropertyKey HasFooterPropertyKey;

		// Token: 0x040006C0 RID: 1728
		public static readonly global::System.Windows.DependencyProperty FooterImageProperty;

		// Token: 0x040006C1 RID: 1729
		public static readonly global::System.Windows.DependencyProperty HasFooterProperty;

		// Token: 0x040006C2 RID: 1730
		public static readonly global::System.Windows.DependencyProperty FooterTemplateSelectorProperty;
	}
}
