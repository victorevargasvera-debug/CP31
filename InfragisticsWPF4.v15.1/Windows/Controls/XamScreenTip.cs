using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020002C7 RID: 711
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamScreenTip", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	public class XamScreenTip : global::System.Windows.Controls.ToolTip
	{
		// Token: 0x06001C5D RID: 7261 RVA: 0x0006C9B0 File Offset: 0x0006ABB0
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

		// Token: 0x06001C5E RID: 7262 RVA: 0x0006C9F4 File Offset: 0x0006ABF4
		static XamScreenTip()
		{
			global::Infragistics.Windows.Controls.XamScreenTip.ThemeChangedEvent = global::Infragistics.Windows.Themes.ThemeManager.ThemeChangedEvent.AddOwner(typeof(global::Infragistics.Windows.Controls.XamScreenTip));
			global::Infragistics.Windows.Themes.ThemeManager.RegisterGroupings(typeof(global::Infragistics.Windows.Controls.XamScreenTip), new string[]
			{
				global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location.Grouping
			});
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.XamScreenTip)));
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0006CBDD File Offset: 0x0006ADDD
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x0006CBEA File Offset: 0x0006ADEA
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

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0006CBF8 File Offset: 0x0006ADF8
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x0006CC0A File Offset: 0x0006AE0A
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

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x0006CC1D File Offset: 0x0006AE1D
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x0006CC2F File Offset: 0x0006AE2F
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

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x0006CC3D File Offset: 0x0006AE3D
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x0006CC4F File Offset: 0x0006AE4F
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

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x0006CC5D File Offset: 0x0006AE5D
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x0006CC6A File Offset: 0x0006AE6A
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

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x0006CC78 File Offset: 0x0006AE78
		// (set) Token: 0x06001C6A RID: 7274 RVA: 0x0006CC8A File Offset: 0x0006AE8A
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

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x0006CC9D File Offset: 0x0006AE9D
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x0006CCAF File Offset: 0x0006AEAF
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

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x0006CCBD File Offset: 0x0006AEBD
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x0006CCCF File Offset: 0x0006AECF
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

		// Token: 0x06001C6F RID: 7279 RVA: 0x0006CCE0 File Offset: 0x0006AEE0
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

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x0006CD26 File Offset: 0x0006AF26
		// (set) Token: 0x06001C71 RID: 7281 RVA: 0x0006CD38 File Offset: 0x0006AF38
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.ThemeTypeConverter))]
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

		// Token: 0x06001C72 RID: 7282 RVA: 0x0006CD48 File Offset: 0x0006AF48
		protected virtual void OnThemeChanged(string previousValue, string currentValue)
		{
			base.RaiseEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Controls.XamScreenTip.ThemeChangedEvent,
				Source = this
			});
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06001C73 RID: 7283 RVA: 0x0006CD76 File Offset: 0x0006AF76
		// (remove) Token: 0x06001C74 RID: 7284 RVA: 0x0006CD84 File Offset: 0x0006AF84
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

		// Token: 0x04000DC7 RID: 3527
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000DC8 RID: 3528
		public static readonly global::System.Windows.DependencyProperty FooterProperty = global::System.Windows.DependencyProperty.Register("Footer", typeof(object), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DC9 RID: 3529
		public static readonly global::System.Windows.DependencyProperty FooterSeparatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("FooterSeparatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));

		// Token: 0x04000DCA RID: 3530
		public static readonly global::System.Windows.DependencyProperty FooterTemplateProperty = global::System.Windows.DependencyProperty.Register("FooterTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DCB RID: 3531
		public static readonly global::System.Windows.DependencyProperty FooterTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("FooterTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DCC RID: 3532
		public static readonly global::System.Windows.DependencyProperty HeaderProperty = global::System.Windows.DependencyProperty.Register("Header", typeof(object), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DCD RID: 3533
		public static readonly global::System.Windows.DependencyProperty HeaderSeparatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("HeaderSeparatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));

		// Token: 0x04000DCE RID: 3534
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateProperty = global::System.Windows.DependencyProperty.Register("HeaderTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DCF RID: 3535
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("HeaderTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DD0 RID: 3536
		public static readonly global::System.Windows.DependencyProperty ThemeProperty = global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.XamScreenTip), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamScreenTip.OnThemeChanged)));
	}
}
