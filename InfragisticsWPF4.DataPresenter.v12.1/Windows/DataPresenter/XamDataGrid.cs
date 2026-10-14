using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200035B RID: 859
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDataGrid")]
	[global::System.Windows.TemplatePart(Name = "PART_ContentSiteGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.ComponentModel.DesignTimeVisible(true)]
	[global::System.Windows.Markup.ContentProperty("DataItems")]
	public class XamDataGrid : global::Infragistics.Windows.DataPresenter.DataPresenterBase
	{
		// Token: 0x060028E3 RID: 10467 RVA: 0x000B11C0 File Offset: 0x000AF3C0
		static XamDataGrid()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid)));
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.LoadCommands();
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000B122C File Offset: 0x000AF42C
		public XamDataGrid()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			base.CurrentViewInternal = new global::Infragistics.Windows.DataPresenter.GridView();
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000B1288 File Offset: 0x000AF488
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (!global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataGrid.ViewSettingsProperty, this.ViewSettings);
			}
			base.CurrentViewInternal.SetBinding(global::Infragistics.Windows.DataPresenter.GridView.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.XamDataGrid.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x000B12C7 File Offset: 0x000AF4C7
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.XamDataGrid.ViewSettingsProperty)
			{
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.GridViewSettings);
			}
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x000B12F0 File Offset: 0x000AF4F0
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.DataPresenter.GridViewSettings();
			}
			return value;
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x000B1304 File Offset: 0x000AF504
		// (set) Token: 0x060028E9 RID: 10473 RVA: 0x000B1327 File Offset: 0x000AF527
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.GridViewSettings ViewSettings
		{
			get
			{
				if (this._viewSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					this._viewSettings = new global::Infragistics.Windows.DataPresenter.GridViewSettings();
				}
				return this._viewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataGrid.ViewSettingsProperty, value);
			}
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000B1335 File Offset: 0x000AF535
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.GridViewSettings)global::Infragistics.Windows.DataPresenter.XamDataGrid.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x000B1356 File Offset: 0x000AF556
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.DataPresenter.GridViewSettings)global::Infragistics.Windows.DataPresenter.XamDataGrid.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x04001328 RID: 4904
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04001329 RID: 4905
		private global::Infragistics.Windows.DataPresenter.GridViewSettings _viewSettings = new global::Infragistics.Windows.DataPresenter.GridViewSettings();

		// Token: 0x0400132A RID: 4906
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.XamDataGrid.OnCoerceViewSettings)));
	}
}
