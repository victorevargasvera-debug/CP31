using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200028A RID: 650
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamScreenTip", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class XamScreenTip : global::System.Windows.Controls.ToolTip
	{
		// Token: 0x06001A2C RID: 6700 RVA: 0x00065754 File Offset: 0x00063954
		public XamScreenTip()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Controls.XamScreenTip), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00065798 File Offset: 0x00063998
		static XamScreenTip()
		{
			global::Infragistics.Windows.Controls.XamScreenTip.ThemeChangedEvent = global::Infragistics.Windows.Themes.ThemeManager.ThemeChangedEvent.AddOwner(typeof(global::Infragistics.Windows.Controls.XamScreenTip));
			global::Infragistics.Windows.Themes.ThemeManager.RegisterGroupings(typeof(global::Infragistics.Windows.Controls.XamScreenTip), new string[]
			{
				global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location.Grouping
			});
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.XamScreenTip)));
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x00065981 File Offset: 0x00063B81
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x0006598E File Offset: 0x00063B8E
		[global::System.ComponentModel.Bindable(true)]
		public object Footer
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.XamScreenTip.FooterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamScreenTip.FooterProperty, value);
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x0006599C File Offset: 0x00063B9C
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x000659AE File Offset: 0x00063BAE
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility FooterSeparatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.XamScreenTip.FooterSeparatorVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamScreenTip.FooterSeparatorVisibilityProperty, value);
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x000659C1 File Offset: 0x00063BC1
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x000659D3 File Offset: 0x00063BD3
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate FooterTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.Controls.XamScreenTip.FooterTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamScreenTip.FooterTemplateProperty, value);
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x000659E1 File Offset: 0x00063BE1
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x000659F3 File Offset: 0x00063BF3
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector FooterTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Infragistics.Windows.Controls.XamScreenTip.FooterTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamScreenTip.FooterTemplateSelectorProperty, value);
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x00065A01 File Offset: 0x00063C01
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x00065A0E File Offset: 0x00063C0E
		[global::System.ComponentModel.Bindable(true)]
		public object Header
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.XamScreenTip.HeaderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamScreenTip.HeaderProperty, value);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x00065A1C File Offset: 0x00063C1C
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x00065A2E File Offset: 0x00063C2E
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility HeaderSeparatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.XamScreenTip.HeaderSeparatorVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamScreenTip.HeaderSeparatorVisibilityProperty, value);
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x00065A41 File Offset: 0x00063C41
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x00065A53 File Offset: 0x00063C53
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate HeaderTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.Controls.XamScreenTip.HeaderTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamScreenTip.HeaderTemplateProperty, value);
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x00065A61 File Offset: 0x00063C61
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x00065A73 File Offset: 0x00063C73
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector HeaderTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Infragistics.Windows.Controls.XamScreenTip.HeaderTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamScreenTip.HeaderTemplateSelectorProperty, value);
			}
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00065A84 File Offset: 0x00063C84
		private static void OnThemeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamScreenTip xamScreenTip = target as global::Infragistics.Windows.Controls.XamScreenTip;
			if (xamScreenTip.IsInitialized)
			{
				xamScreenTip.InvalidateMeasure();
				xamScreenTip.UpdateLayout();
			}
			xamScreenTip.OnThemeChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x00065ACA File Offset: 0x00063CCA
		// (set) Token: 0x06001A40 RID: 6720 RVA: 0x00065ADC File Offset: 0x00063CDC
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.ThemeTypeConverter))]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		public string Theme
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Controls.XamScreenTip.ThemeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamScreenTip.ThemeProperty, value);
			}
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00065AEC File Offset: 0x00063CEC
		protected virtual void OnThemeChanged(string previousValue, string currentValue)
		{
			base.RaiseEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Controls.XamScreenTip.ThemeChangedEvent,
				Source = this
			});
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06001A42 RID: 6722 RVA: 0x00065B1A File Offset: 0x00063D1A
		// (remove) Token: 0x06001A43 RID: 6723 RVA: 0x00065B28 File Offset: 0x00063D28
		public event global::System.Windows.RoutedPropertyChangedEventHandler<string> ThemeChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.XamScreenTip.ThemeChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.XamScreenTip.ThemeChangedEvent, value);
			}
		}

		// Token: 0x04000C54 RID: 3156
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000C55 RID: 3157
		public static readonly global::System.Windows.DependencyProperty FooterProperty = global::System.Windows.DependencyProperty.Register("Footer", typeof(object), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C56 RID: 3158
		public static readonly global::System.Windows.DependencyProperty FooterSeparatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("FooterSeparatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));

		// Token: 0x04000C57 RID: 3159
		public static readonly global::System.Windows.DependencyProperty FooterTemplateProperty = global::System.Windows.DependencyProperty.Register("FooterTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C58 RID: 3160
		public static readonly global::System.Windows.DependencyProperty FooterTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("FooterTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C59 RID: 3161
		public static readonly global::System.Windows.DependencyProperty HeaderProperty = global::System.Windows.DependencyProperty.Register("Header", typeof(object), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C5A RID: 3162
		public static readonly global::System.Windows.DependencyProperty HeaderSeparatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("HeaderSeparatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));

		// Token: 0x04000C5B RID: 3163
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateProperty = global::System.Windows.DependencyProperty.Register("HeaderTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C5C RID: 3164
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("HeaderTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C5D RID: 3165
		public static readonly global::System.Windows.DependencyProperty ThemeProperty = global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamScreenTip.OnThemeChanged)));
	}
}
