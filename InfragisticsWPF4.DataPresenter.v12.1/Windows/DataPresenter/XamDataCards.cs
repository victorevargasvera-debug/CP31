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
	// Token: 0x0200020B RID: 523
	[global::System.ComponentModel.DesignTimeVisible(true)]
	[global::System.Windows.Markup.ContentProperty("DataItems")]
	[global::System.Windows.TemplatePart(Name = "PART_ContentSiteGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDataCards")]
	public class XamDataCards : global::Infragistics.Windows.DataPresenter.DataPresenterBase
	{
		// Token: 0x06001D59 RID: 7513 RVA: 0x000806CC File Offset: 0x0007E8CC
		static XamDataCards()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataCards), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataCards)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordContainerRetentionModeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataCards), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordContainerRetentionMode.DiscardDeactivatedContainers));
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.LoadCommands();
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00080758 File Offset: 0x0007E958
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

		// Token: 0x06001D5B RID: 7515 RVA: 0x000807B4 File Offset: 0x0007E9B4
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (!global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataCards.ViewSettingsProperty, this.ViewSettings);
			}
			base.CurrentViewInternal.SetBinding(global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.XamDataCards.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x000807F3 File Offset: 0x0007E9F3
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.XamDataCards.ViewSettingsProperty)
			{
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.CardViewSettings);
			}
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x0008081C File Offset: 0x0007EA1C
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.DataPresenter.CardViewSettings();
			}
			return value;
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x00080830 File Offset: 0x0007EA30
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x00080853 File Offset: 0x0007EA53
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

		// Token: 0x06001D60 RID: 7520 RVA: 0x00080861 File Offset: 0x0007EA61
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.CardViewSettings)global::Infragistics.Windows.DataPresenter.XamDataCards.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00080882 File Offset: 0x0007EA82
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.DataPresenter.CardViewSettings)global::Infragistics.Windows.DataPresenter.XamDataCards.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x04000C3B RID: 3131
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000C3C RID: 3132
		private global::Infragistics.Windows.DataPresenter.CardViewSettings _viewSettings = new global::Infragistics.Windows.DataPresenter.CardViewSettings();

		// Token: 0x04000C3D RID: 3133
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), typeof(global::Infragistics.Windows.DataPresenter.XamDataCards), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.XamDataCards.OnCoerceViewSettings)));
	}
}
