using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000FB RID: 251
	public class GridView : global::Infragistics.Windows.DataPresenter.ViewBase
	{
		// Token: 0x06000D68 RID: 3432 RVA: 0x0003AB27 File Offset: 0x00038D27
		public GridView()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.GridView.ViewSettingsProperty, this.ViewSettings);
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0003AB40 File Offset: 0x00038D40
		protected internal override bool AutoFitToRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0003AB43 File Offset: 0x00038D43
		protected internal override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.GridView;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x0003AB46 File Offset: 0x00038D46
		protected internal override global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				if (this.LogicalOrientation != global::System.Windows.Controls.Orientation.Vertical)
				{
					return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
				}
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0003AB54 File Offset: 0x00038D54
		protected internal override bool HasLogicalOrientation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0003AB57 File Offset: 0x00038D57
		protected internal override bool IsAutoFitHeightSupported
		{
			get
			{
				return this.ViewSettings.Orientation == global::System.Windows.Controls.Orientation.Horizontal;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x0003AB67 File Offset: 0x00038D67
		protected internal override bool IsAutoFitWidthSupported
		{
			get
			{
				return this.ViewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0003AB77 File Offset: 0x00038D77
		protected internal override bool IsChildRecordsDisplayOrderSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0003AB7A File Offset: 0x00038D7A
		protected internal override bool IsFilterRecordSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0003AB7D File Offset: 0x00038D7D
		protected internal override bool IsFixedFieldsSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0003AB80 File Offset: 0x00038D80
		protected internal override bool IsFixedRecordsSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x0003AB83 File Offset: 0x00038D83
		protected internal override bool IsFixingSupportedForNestedRecords
		{
			get
			{
				return !this.ViewSettings.UseNestedPanels;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x0003AB93 File Offset: 0x00038D93
		protected internal override bool IsPanningModeSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0003AB96 File Offset: 0x00038D96
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

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x0003ABBA File Offset: 0x00038DBA
		protected internal override global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				return this.ViewSettings.Orientation;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x0003ABC7 File Offset: 0x00038DC7
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

		// Token: 0x06000D78 RID: 3448 RVA: 0x0003ABD9 File Offset: 0x00038DD9
		protected internal override global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return new global::Infragistics.Windows.DataPresenter.HeaderedGridViewFieldLayoutTemplateGenerator(fieldLayout, this.ViewSettings.Orientation);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0003ABEC File Offset: 0x00038DEC
		internal override global::Infragistics.Windows.DataPresenter.FixedFieldInfo GetFixedFieldInfo(global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = recordPresenter.DataPresenter;
			global::Infragistics.Windows.DataPresenter.GridViewPanel gridViewPanel = (dataPresenter != null) ? (dataPresenter.CurrentPanel as global::Infragistics.Windows.DataPresenter.GridViewPanel) : null;
			if (gridViewPanel == null)
			{
				return null;
			}
			return gridViewPanel.FixedFieldInfo;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0003AC20 File Offset: 0x00038E20
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

		// Token: 0x06000D7B RID: 3451 RVA: 0x0003ACC1 File Offset: 0x00038EC1
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null)
			{
				return new global::Infragistics.Windows.DataPresenter.GridViewSettings();
			}
			return value;
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0003ACCD File Offset: 0x00038ECD
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x0003ACE8 File Offset: 0x00038EE8
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

		// Token: 0x06000D7E RID: 3454 RVA: 0x0003ACF6 File Offset: 0x00038EF6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.GridViewSettings)global::Infragistics.Windows.DataPresenter.GridView.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0003AD17 File Offset: 0x00038F17
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.GridView.ViewSettingsProperty);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0003AD24 File Offset: 0x00038F24
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
				if (!(propertyName == "HeightInInfiniteContainers") && !(propertyName == "WidthInInfiniteContainers"))
				{
					return;
				}
				base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateMeasure));
			}
		}

		// Token: 0x0400053A RID: 1338
		private global::Infragistics.Windows.DataPresenter.GridViewSettings _viewSettings;

		// Token: 0x0400053B RID: 1339
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), typeof(global::Infragistics.Windows.DataPresenter.GridView), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridView.OnCoerceViewSettings)));
	}
}
