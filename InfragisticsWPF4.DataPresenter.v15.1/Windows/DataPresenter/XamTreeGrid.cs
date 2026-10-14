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
	// Token: 0x02000340 RID: 832
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.ComponentModel.DesignTimeVisible(true)]
	[global::System.Windows.Markup.ContentProperty("DataItems")]
	[global::System.Windows.TemplatePart(Name = "PART_ContentSiteGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamTreeGrid")]
	public class XamTreeGrid : global::Infragistics.Windows.DataPresenter.DataPresenterBase
	{
		// Token: 0x0600278F RID: 10127 RVA: 0x000B0600 File Offset: 0x000AE800
		static XamTreeGrid()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamTreeGrid), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamTreeGrid)));
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.LoadCommands();
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.DataPresenter.XamTreeGrid));
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x000B067C File Offset: 0x000AE87C
		public XamTreeGrid()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.DataPresenter.XamTreeGrid), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			base.CurrentViewInternal = new global::Infragistics.Windows.DataPresenter.TreeView();
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x000B06D8 File Offset: 0x000AE8D8
		internal override bool IsTreeView
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x000B06DB File Offset: 0x000AE8DB
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (!global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamTreeGrid.ViewSettingsProperty, this.ViewSettings);
			}
			base.CurrentViewInternal.SetBinding(global::Infragistics.Windows.DataPresenter.TreeView.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.XamTreeGrid.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x000B071A File Offset: 0x000AE91A
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.XamTreeGrid.ViewSettingsProperty)
			{
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.TreeViewSettings);
			}
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x000B0743 File Offset: 0x000AE943
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.DataPresenter.TreeViewSettings();
			}
			return value;
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x000B0757 File Offset: 0x000AE957
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x000B077A File Offset: 0x000AE97A
		[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.TreeViewSettings ViewSettings
		{
			get
			{
				if (this._viewSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					this._viewSettings = new global::Infragistics.Windows.DataPresenter.TreeViewSettings();
				}
				return this._viewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamTreeGrid.ViewSettingsProperty, value);
			}
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x000B0788 File Offset: 0x000AE988
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.TreeViewSettings)global::Infragistics.Windows.DataPresenter.XamTreeGrid.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000B07A9 File Offset: 0x000AE9A9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.DataPresenter.TreeViewSettings)global::Infragistics.Windows.DataPresenter.XamTreeGrid.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x04001392 RID: 5010
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04001393 RID: 5011
		private global::Infragistics.Windows.DataPresenter.TreeViewSettings _viewSettings = new global::Infragistics.Windows.DataPresenter.TreeViewSettings();

		// Token: 0x04001394 RID: 5012
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.TreeViewSettings), typeof(global::Infragistics.Windows.DataPresenter.XamTreeGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.XamTreeGrid.OnCoerceViewSettings)));
	}
}
