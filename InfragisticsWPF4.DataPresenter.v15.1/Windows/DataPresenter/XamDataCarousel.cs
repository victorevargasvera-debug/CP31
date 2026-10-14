using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using Infragistics.Themes;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000240 RID: 576
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDataCarousel")]
	[global::System.Windows.Markup.ContentProperty("DataItems")]
	[global::System.Windows.TemplatePart(Name = "PART_ContentSiteGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.ComponentModel.DesignTimeVisible(true)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamDataCarousel : global::Infragistics.Windows.DataPresenter.DataPresenterBase
	{
		// Token: 0x060021E3 RID: 8675 RVA: 0x00096F04 File Offset: 0x00095104
		static XamDataCarousel()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataCarousel), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataCarousel)));
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.LoadCommands();
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.DataPresenter.XamDataCarousel));
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x00096F80 File Offset: 0x00095180
		public XamDataCarousel()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.DataPresenter.XamDataCarousel), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			base.CurrentViewInternal = new global::Infragistics.Windows.DataPresenter.CarouselView();
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x00096FD0 File Offset: 0x000951D0
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (!global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataCarousel.ViewSettingsProperty, this.ViewSettings);
			}
			base.CurrentViewInternal.SetBinding(global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.XamDataCarousel.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x0009700F File Offset: 0x0009520F
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.Property == global::Infragistics.Windows.DataPresenter.XamDataCarousel.ViewSettingsProperty)
			{
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.Controls.CarouselViewSettings);
			}
			base.OnPropertyChanged(e);
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00097038 File Offset: 0x00095238
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.Controls.CarouselViewSettings();
			}
			return value;
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0009704C File Offset: 0x0009524C
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x0009706F File Offset: 0x0009526F
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
		public global::Infragistics.Windows.Controls.CarouselViewSettings ViewSettings
		{
			get
			{
				if (this._viewSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					this._viewSettings = new global::Infragistics.Windows.Controls.CarouselViewSettings();
				}
				return this._viewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataCarousel.ViewSettingsProperty, value);
			}
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x0009707D File Offset: 0x0009527D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.DataPresenter.XamDataCarousel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x0009709E File Offset: 0x0009529E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.DataPresenter.XamDataCarousel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x04000E5E RID: 3678
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000E5F RID: 3679
		private global::Infragistics.Windows.Controls.CarouselViewSettings _viewSettings;

		// Token: 0x04000E60 RID: 3680
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), typeof(global::Infragistics.Windows.DataPresenter.XamDataCarousel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.XamDataCarousel.OnCoerceViewSettings)));
	}
}
