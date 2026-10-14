using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200020C RID: 524
	[global::System.ComponentModel.DesignTimeVisible(true)]
	[global::System.Windows.Markup.ContentProperty("DataItems")]
	[global::System.Windows.TemplatePart(Name = "PART_ContentSiteGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDataCarousel")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamDataCarousel : global::Infragistics.Windows.DataPresenter.DataPresenterBase
	{
		// Token: 0x06001D62 RID: 7522 RVA: 0x000808A0 File Offset: 0x0007EAA0
		static XamDataCarousel()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataCarousel), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataCarousel)));
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.LoadCommands();
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x0008090C File Offset: 0x0007EB0C
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

		// Token: 0x06001D64 RID: 7524 RVA: 0x0008095C File Offset: 0x0007EB5C
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (!global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataCarousel.ViewSettingsProperty, this.ViewSettings);
			}
			base.CurrentViewInternal.SetBinding(global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.XamDataCarousel.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x0008099B File Offset: 0x0007EB9B
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.Property == global::Infragistics.Windows.DataPresenter.XamDataCarousel.ViewSettingsProperty)
			{
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.Controls.CarouselViewSettings);
			}
			base.OnPropertyChanged(e);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x000809C4 File Offset: 0x0007EBC4
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.Controls.CarouselViewSettings();
			}
			return value;
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x000809D8 File Offset: 0x0007EBD8
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x000809FB File Offset: 0x0007EBFB
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06001D69 RID: 7529 RVA: 0x00080A09 File Offset: 0x0007EC09
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.DataPresenter.XamDataCarousel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00080A2A File Offset: 0x0007EC2A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.DataPresenter.XamDataCarousel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x04000C3E RID: 3134
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000C3F RID: 3135
		private global::Infragistics.Windows.Controls.CarouselViewSettings _viewSettings;

		// Token: 0x04000C40 RID: 3136
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), typeof(global::Infragistics.Windows.DataPresenter.XamDataCarousel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.XamDataCarousel.OnCoerceViewSettings)));
	}
}
