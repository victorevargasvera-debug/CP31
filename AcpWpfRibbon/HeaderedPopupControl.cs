using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000020 RID: 32
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class HeaderedPopupControl : global::DevComponents.WpfRibbon.BasePopupControl
	{
		// Token: 0x06000292 RID: 658 RVA: 0x0003C140 File Offset: 0x0003A340
		static HeaderedPopupControl()
		{
			int a_ = 16;
			short num = (short)1633118034;
			short num2 = num;
			num = (short)792487762;
			switch (num2 == num)
			{
			}
			num = (short)1731395584;
			if (num != 0)
			{
			}
			num = (short)1206190080;
			short num3 = num;
			num = (short)1253769217;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.HeaderedPopupControl.HeaderProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.HeaderedPopupControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.HeaderedPopupControl.OnHeaderChanged)));
			global::DevComponents.WpfRibbon.HeaderedPopupControl.HeaderTemplateProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.HeaderedPopupControl));
			global::DevComponents.WpfRibbon.HeaderedPopupControl.HasHeaderPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⁧୩Ὣ♭ᕯ፱ၳ፵੷", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.HeaderedPopupControl), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.HeaderedPopupControl.HasHeaderProperty = global::DevComponents.WpfRibbon.HeaderedPopupControl.HasHeaderPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.HeaderedPopupControl.HeaderTemplateSelectorProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.HeaderedPopupControl), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0003C29C File Offset: 0x0003A49C
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0003C350 File Offset: 0x0003A550
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.Bindable(true)]
		public object Header
		{
			get
			{
				short num = (short)718929921;
				if (num != 0)
				{
				}
				num = (short)594373587;
				short num2 = num;
				num = (short)28470227;
				switch (num2 == num)
				{
				}
				num = (short)603914240;
				short num3 = num;
				num = (short)1513291776;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.HeaderedPopupControl.HeaderProperty);
			}
			set
			{
				short num = (short)574357505;
				if (num != 0)
				{
				}
				num = (short)251452180;
				short num2 = num;
				num = (short)973588;
				switch (num2 == num)
				{
				}
				num = (short)422248448;
				short num3 = num;
				num = (short)1067581440;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.HeaderedPopupControl.HeaderProperty, value);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0003C408 File Offset: 0x0003A608
		private static void OnHeaderChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)2043258187;
			short num2 = num;
			num = (short)1028695371;
			switch (num2 == num)
			{
			}
			num = (short)1838284801;
			if (num != 0)
			{
			}
			num = (short)1577582592;
			short num3 = num;
			num = (short)266141696;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.HeaderedPopupControl headeredPopupControl = (global::DevComponents.WpfRibbon.HeaderedPopupControl)d;
			headeredPopupControl.SetValue(global::DevComponents.WpfRibbon.HeaderedPopupControl.HasHeaderPropertyKey, e.NewValue != null);
			headeredPopupControl.OnHeaderChanged(e.OldValue, e.NewValue);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0003C4E8 File Offset: 0x0003A6E8
		protected virtual void OnHeaderChanged(object oldHeader, object newHeader)
		{
			short num = (short)1765605379;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_CD;
				case 1:
					if (newHeader != null)
					{
						num = (short)555089922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)1400504321;
					if (num != 0)
					{
					}
					base.AddLogicalChild(newHeader);
					num = (short)2048327684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
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
				{
					base.RemoveLogicalChild(oldHeader);
					num = (short)1669660672;
					short num3 = num;
					num = (short)85983232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_3C:
				num = (short)1942012204;
				short num4 = num;
				num = (short)791527724;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)59441152;
					if (num != 0)
					{
					}
					if (oldHeader != null)
					{
						num = (short)307757061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_CD:
				num = (short)1879638017;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0003C674 File Offset: 0x0003A874
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0003C730 File Offset: 0x0003A930
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.DataTemplate HeaderTemplate
		{
			get
			{
				short num = (short)117839275;
				short num2 = num;
				num = (short)241833387;
				switch (num2 == num)
				{
				}
				num = (short)1002504192;
				if (num != 0)
				{
				}
				num = (short)716701696;
				short num3 = num;
				num = (short)1547239425;
				if (num != 0)
				{
				}
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfRibbon.HeaderedPopupControl.HeaderTemplateProperty);
			}
			set
			{
				short num = (short)37332767;
				short num2 = num;
				num = (short)1415751455;
				switch (num2 == num)
				{
				}
				num = (short)1373241345;
				if (num != 0)
				{
				}
				num = (short)1621688320;
				short num3 = num;
				num = (short)1567358976;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.HeaderedPopupControl.HeaderTemplateProperty, value);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0003C7E8 File Offset: 0x0003A9E8
		// (set) Token: 0x0600029A RID: 666 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector HeaderTemplateSelector
		{
			get
			{
				short num = (short)1316184582;
				short num2 = num;
				num = (short)1046045190;
				switch (num2 == num)
				{
				}
				num = (short)926220288;
				if (num != 0)
				{
				}
				num = (short)535494656;
				short num3 = num;
				num = (short)1978466305;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfRibbon.HeaderedPopupControl.HeaderTemplateSelectorProperty);
			}
			set
			{
				short num = (short)725143518;
				short num2 = num;
				num = (short)1867239390;
				switch (num2 == num)
				{
				}
				num = (short)99024897;
				if (num != 0)
				{
				}
				num = (short)1804664832;
				short num3 = num;
				num = (short)2047606784;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.HeaderedPopupControl.HeaderTemplateSelectorProperty, value);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0003C95C File Offset: 0x0003AB5C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(false)]
		public bool HasHeader
		{
			get
			{
				short num = (short)157475667;
				short num2 = num;
				num = (short)496493395;
				switch (num2 == num)
				{
				}
				num = (short)1594818561;
				if (num != 0)
				{
				}
				num = (short)466092032;
				short num3 = num;
				num = (short)1891565568;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.HeaderedPopupControl.HasHeaderProperty);
			}
		}

		// Token: 0x040000DE RID: 222
		public static readonly global::System.Windows.DependencyProperty HeaderProperty;

		// Token: 0x040000DF RID: 223
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateProperty;

		// Token: 0x040000E0 RID: 224
		internal static readonly global::System.Windows.DependencyPropertyKey HasHeaderPropertyKey;

		// Token: 0x040000E1 RID: 225
		public static readonly global::System.Windows.DependencyProperty HasHeaderProperty;

		// Token: 0x040000E2 RID: 226
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateSelectorProperty;
	}
}
