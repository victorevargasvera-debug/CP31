using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Infragistics.Themes;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000241 RID: 577
	[global::System.ComponentModel.DesignTimeVisible(true)]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDataPresenter")]
	[global::System.Windows.Markup.ContentProperty("DataItems")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Windows.TemplatePart(Name = "PART_ContentSiteGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	public class XamDataPresenter : global::Infragistics.Windows.DataPresenter.DataPresenterBase
	{
		// Token: 0x060021EC RID: 8684 RVA: 0x000970BC File Offset: 0x000952BC
		static XamDataPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.XamDataPresenter)));
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.LoadCommands();
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.DataPresenter.XamDataPresenter));
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00097138 File Offset: 0x00095338
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

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x0009717C File Offset: 0x0009537C
		internal override bool IsTreeView
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = base.CurrentViewInternal;
				return currentViewInternal != null && currentViewInternal.IsTreeView;
			}
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0009719C File Offset: 0x0009539C
		protected override void OnInitialized(global::System.EventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.ViewBase view = this.View;
			if (!global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.XamDataPresenter.ViewProperty, view);
			}
			base.OnInitialized(e);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x000971CC File Offset: 0x000953CC
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

		// Token: 0x060021F1 RID: 8689 RVA: 0x00097260 File Offset: 0x00095460
		private static object OnCoerceView(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.DataPresenter.GridView();
			}
			return value;
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x00097274 File Offset: 0x00095474
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x000972B8 File Offset: 0x000954B8
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x04000E61 RID: 3681
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000E62 RID: 3682
		public static readonly global::System.Windows.DependencyProperty ViewProperty = global::System.Windows.DependencyProperty.Register("View", typeof(global::Infragistics.Windows.DataPresenter.ViewBase), typeof(global::Infragistics.Windows.DataPresenter.XamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.XamDataPresenter.OnCoerceView)));
	}
}
