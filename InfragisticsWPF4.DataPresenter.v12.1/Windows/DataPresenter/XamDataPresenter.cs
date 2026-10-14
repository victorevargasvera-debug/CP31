using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200020D RID: 525
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.ComponentModel.DesignTimeVisible(true)]
	[global::System.Windows.Markup.ContentProperty("DataItems")]
	[global::System.Windows.TemplatePart(Name = "PART_ContentSiteGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDataPresenter")]
	public class XamDataPresenter : global::Infragistics.Windows.DataPresenter.DataPresenterBase
	{
		// Token: 0x06001D6B RID: 7531 RVA: 0x00080A48 File Offset: 0x0007EC48
		static XamDataPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataPresenter)));
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.LoadCommands();
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00080AB4 File Offset: 0x0007ECB4
		public XamDataPresenter()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.DataPresenter.XamDataPresenter), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00080AF8 File Offset: 0x0007ECF8
		protected override void OnInitialized(global::System.EventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.ViewBase view = this.View;
			if (!global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataPresenter.ViewProperty, view);
			}
			base.OnInitialized(e);
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00080B28 File Offset: 0x0007ED28
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::Infragistics.Windows.DataPresenter.XamDataPresenter.ViewProperty)
			{
				if (e.NewValue is global::Infragistics.Windows.DataPresenter.ViewBase && e.NewValue != base.CurrentViewInternal)
				{
					base.CurrentViewInternal = (e.NewValue as global::Infragistics.Windows.DataPresenter.ViewBase);
				}
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in base.FieldLayouts)
				{
					fieldLayout.ResetCachedChildRecordsDisplayOrderResolvedValue();
				}
			}
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x00080BBC File Offset: 0x0007EDBC
		private static object OnCoerceView(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.DataPresenter.GridView();
			}
			return value;
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x00080BD0 File Offset: 0x0007EDD0
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x00080C14 File Offset: 0x0007EE14
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::Infragistics.Windows.DataPresenter.ViewBase View
		{
			get
			{
				if (!(base.GetValue(global::Infragistics.Windows.DataPresenter.XamDataPresenter.ViewProperty) is global::Infragistics.Windows.DataPresenter.ViewBase))
				{
					if (base.CurrentViewInternal == null)
					{
						base.CurrentViewInternal = new global::Infragistics.Windows.DataPresenter.GridView();
					}
					if (global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
					{
						return null;
					}
				}
				return base.CurrentViewInternal;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataPresenter.ViewProperty, value);
			}
		}

		// Token: 0x04000C41 RID: 3137
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000C42 RID: 3138
		public static readonly global::System.Windows.DependencyProperty ViewProperty = global::System.Windows.DependencyProperty.Register("View", typeof(global::Infragistics.Windows.DataPresenter.ViewBase), typeof(global::Infragistics.Windows.DataPresenter.XamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.XamDataPresenter.OnCoerceView)));
	}
}
