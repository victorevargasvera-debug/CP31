using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using Infragistics.Themes;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020003A1 RID: 929
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Windows.TemplatePart(Name = "PART_ContentSiteGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.ComponentModel.DesignTimeVisible(true)]
	[global::System.Windows.Markup.ContentProperty("DataItems")]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDataGrid")]
	public class XamDataGrid : global::Infragistics.Windows.DataPresenter.DataPresenterBase
	{
		// Token: 0x06002CD0 RID: 11472 RVA: 0x000C6078 File Offset: 0x000C4278
		static XamDataGrid()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid)));
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.LoadCommands();
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid));
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x000C60F4 File Offset: 0x000C42F4
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

		// Token: 0x06002CD2 RID: 11474 RVA: 0x000C6150 File Offset: 0x000C4350
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (!global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataGrid.ViewSettingsProperty, this.ViewSettings);
			}
			base.CurrentViewInternal.SetBinding(global::Infragistics.Windows.DataPresenter.GridView.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.XamDataGrid.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x000C618F File Offset: 0x000C438F
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.XamDataGrid.ViewSettingsProperty)
			{
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.GridViewSettings);
			}
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x000C61B8 File Offset: 0x000C43B8
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.DataPresenter.GridViewSettings();
			}
			return value;
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x000C61CC File Offset: 0x000C43CC
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x000C61EF File Offset: 0x000C43EF
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
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

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000C61FD File Offset: 0x000C43FD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.GridViewSettings)global::Infragistics.Windows.DataPresenter.XamDataGrid.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x000C621E File Offset: 0x000C441E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.DataPresenter.GridViewSettings)global::Infragistics.Windows.DataPresenter.XamDataGrid.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x04001551 RID: 5457
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04001552 RID: 5458
		private global::Infragistics.Windows.DataPresenter.GridViewSettings _viewSettings = new global::Infragistics.Windows.DataPresenter.GridViewSettings();

		// Token: 0x04001553 RID: 5459
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.XamDataGrid.OnCoerceViewSettings)));
	}
}
