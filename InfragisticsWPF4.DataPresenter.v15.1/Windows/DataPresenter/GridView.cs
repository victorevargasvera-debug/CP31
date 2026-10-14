using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E3 RID: 483
	public class GridView : global::Infragistics.Windows.DataPresenter.GridViewBase
	{
		// Token: 0x06001E2D RID: 7725 RVA: 0x000861BD File Offset: 0x000843BD
		public GridView()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.GridView.ViewSettingsProperty, this.ViewSettings);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000861D6 File Offset: 0x000843D6
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null)
			{
				return new global::Infragistics.Windows.DataPresenter.GridViewSettings();
			}
			return value;
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x000861E2 File Offset: 0x000843E2
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x000861FD File Offset: 0x000843FD
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.GridViewSettings ViewSettings
		{
			get
			{
				if (this._viewSettings == null)
				{
					this._viewSettings = new global::Infragistics.Windows.DataPresenter.GridViewSettings();
				}
				return this._viewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GridView.ViewSettingsProperty, value);
			}
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0008620B File Offset: 0x0008440B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.GridViewSettings)global::Infragistics.Windows.DataPresenter.GridView.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0008622C File Offset: 0x0008442C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.GridView.ViewSettingsProperty);
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x00086239 File Offset: 0x00084439
		protected internal override bool IsAutoFitHeightSupported
		{
			get
			{
				return this.ViewSettings.Orientation == global::System.Windows.Controls.Orientation.Horizontal;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x00086249 File Offset: 0x00084449
		protected internal override bool IsAutoFitWidthSupported
		{
			get
			{
				return this.ViewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x00086259 File Offset: 0x00084459
		protected internal override bool IsFixingSupportedForNestedRecords
		{
			get
			{
				return !this.ViewSettings.UseNestedPanels;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00086269 File Offset: 0x00084469
		protected internal override global::System.Type ItemsPanelType
		{
			get
			{
				if (this.ViewSettings.UseNestedPanels)
				{
					return typeof(global::Infragistics.Windows.DataPresenter.GridViewPanelNested);
				}
				return typeof(global::Infragistics.Windows.DataPresenter.GridViewPanelFlat);
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x0008628D File Offset: 0x0008448D
		protected internal override global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				return this.ViewSettings.Orientation;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x0008629A File Offset: 0x0008449A
		protected internal override global::Infragistics.Windows.DataPresenter.DataDisplayMode SupportedDataDisplayMode
		{
			get
			{
				if (this.ViewSettings.UseNestedPanels)
				{
					return global::Infragistics.Windows.DataPresenter.DataDisplayMode.Hierarchical;
				}
				return global::Infragistics.Windows.DataPresenter.DataDisplayMode.FlattenedHierarchical;
			}
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x000862AC File Offset: 0x000844AC
		protected internal override global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return new global::Infragistics.Windows.DataPresenter.HeaderedGridViewFieldLayoutTemplateGenerator(fieldLayout, this.ViewSettings.Orientation);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x000862C0 File Offset: 0x000844C0
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.GridView.ViewSettingsProperty)
			{
				global::System.Windows.Controls.Orientation orientation = global::System.Windows.Controls.Orientation.Vertical;
				if (this._viewSettings != null)
				{
					this._viewSettings.PropertyChanged -= this.OnViewSettingsPropertyChanged;
					orientation = this._viewSettings.Orientation;
				}
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.GridViewSettings);
				global::System.Windows.Controls.Orientation orientation2 = global::System.Windows.Controls.Orientation.Vertical;
				if (this._viewSettings != null)
				{
					this._viewSettings.PropertyChanged += this.OnViewSettingsPropertyChanged;
					orientation2 = this._viewSettings.Orientation;
				}
				base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs((orientation == orientation2) ? global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateMeasure : global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateFieldLayouts));
			}
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00086364 File Offset: 0x00084564
		private void OnViewSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (propertyName == "Orientation" || propertyName == "UseNestedPanels")
				{
					base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateFieldLayouts));
					return;
				}
				if (!(propertyName == "AllowLastRecordScrollToTop") && !(propertyName == "HeightInInfiniteContainers") && !(propertyName == "WidthInInfiniteContainers"))
				{
					return;
				}
				base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateMeasure));
			}
		}

		// Token: 0x04000CC6 RID: 3270
		private global::Infragistics.Windows.DataPresenter.GridViewSettings _viewSettings;

		// Token: 0x04000CC7 RID: 3271
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), typeof(global::Infragistics.Windows.DataPresenter.GridView), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridView.OnCoerceViewSettings)));
	}
}
