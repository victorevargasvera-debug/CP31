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
	// Token: 0x0200023F RID: 575
	[global::System.ComponentModel.DesignTimeVisible(true)]
	[global::System.Windows.Markup.ContentProperty("DataItems")]
	[global::System.Windows.TemplatePart(Name = "PART_ContentSiteGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDataCards")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamDataCards : global::Infragistics.Windows.DataPresenter.DataPresenterBase
	{
		// Token: 0x060021DA RID: 8666 RVA: 0x00096D24 File Offset: 0x00094F24
		static XamDataCards()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataCards), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataCards)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordContainerRetentionModeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataCards), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordContainerRetentionMode.DiscardDeactivatedContainers));
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.LoadCommands();
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.DataPresenter.XamDataCards));
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x00096DBC File Offset: 0x00094FBC
		public XamDataCards()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.DataPresenter.XamDataCards), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			base.CurrentViewInternal = new global::Infragistics.Windows.DataPresenter.CardView();
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x00096E18 File Offset: 0x00095018
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (!global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataCards.ViewSettingsProperty, this.ViewSettings);
			}
			base.CurrentViewInternal.SetBinding(global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.XamDataCards.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x00096E57 File Offset: 0x00095057
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.XamDataCards.ViewSettingsProperty)
			{
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.CardViewSettings);
			}
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00096E80 File Offset: 0x00095080
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.DataPresenter.CardViewSettings();
			}
			return value;
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x00096E94 File Offset: 0x00095094
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x00096EB7 File Offset: 0x000950B7
		[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.CardViewSettings ViewSettings
		{
			get
			{
				if (this._viewSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					this._viewSettings = new global::Infragistics.Windows.DataPresenter.CardViewSettings();
				}
				return this._viewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataCards.ViewSettingsProperty, value);
			}
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00096EC5 File Offset: 0x000950C5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.CardViewSettings)global::Infragistics.Windows.DataPresenter.XamDataCards.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00096EE6 File Offset: 0x000950E6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.DataPresenter.CardViewSettings)global::Infragistics.Windows.DataPresenter.XamDataCards.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x04000E5B RID: 3675
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000E5C RID: 3676
		private global::Infragistics.Windows.DataPresenter.CardViewSettings _viewSettings = new global::Infragistics.Windows.DataPresenter.CardViewSettings();

		// Token: 0x04000E5D RID: 3677
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), typeof(global::Infragistics.Windows.DataPresenter.XamDataCards), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.XamDataCards.OnCoerceViewSettings)));
	}
}
