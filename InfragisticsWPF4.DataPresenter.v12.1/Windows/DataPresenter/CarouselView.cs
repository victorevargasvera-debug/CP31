using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200004C RID: 76
	public class CarouselView : global::Infragistics.Windows.DataPresenter.ViewBase
	{
		// Token: 0x06000374 RID: 884 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		public CarouselView()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty, this.ViewSettings);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0000CF15 File Offset: 0x0000B115
		protected internal override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.CardView;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000CF18 File Offset: 0x0000B118
		protected internal override global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000CF1B File Offset: 0x0000B11B
		protected internal override int DefaultAutoArrangeMaxColumns
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0000CF1E File Offset: 0x0000B11E
		protected internal override int DefaultAutoArrangeMaxRows
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000CF21 File Offset: 0x0000B121
		protected internal override bool DefaultAutoFit
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000CF24 File Offset: 0x0000B124
		protected internal override global::Infragistics.Windows.DataPresenter.CellClickAction DefaultCellClickAction
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellClickAction.SelectCell;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000CF27 File Offset: 0x0000B127
		protected internal override global::Infragistics.Windows.DataPresenter.LabelClickAction DefaultLabelClickAction
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0000CF2A File Offset: 0x0000B12A
		protected internal override global::Infragistics.Windows.DataPresenter.LabelLocation DefaultLabelLocation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelLocation.Hidden;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0000CF2D File Offset: 0x0000B12D
		protected internal override bool HasLogicalOrientation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000CF30 File Offset: 0x0000B130
		protected internal override global::System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Hidden;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000CF33 File Offset: 0x0000B133
		protected internal override bool IsAddNewRecordSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000CF36 File Offset: 0x0000B136
		protected internal override bool IsAutoFitHeightSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000CF39 File Offset: 0x0000B139
		protected internal override bool IsAutoFitWidthSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000CF3C File Offset: 0x0000B13C
		protected internal override bool IsLogicalFieldHeightResizingAllowed
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0000CF3F File Offset: 0x0000B13F
		protected internal override bool IsLogicalFieldWidthResizingAllowed
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000CF42 File Offset: 0x0000B142
		protected internal override bool IsNestedPanelsSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000CF45 File Offset: 0x0000B145
		protected internal override bool IsSummaryRecordSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000CF48 File Offset: 0x0000B148
		protected internal override global::System.Type ItemsPanelType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.CarouselViewPanel);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000CF54 File Offset: 0x0000B154
		protected internal override global::System.Type RecordPresenterContainerType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.CarouselItem);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0000CF60 File Offset: 0x0000B160
		protected internal override bool ShouldDisplayRecordSelectors
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0000CF63 File Offset: 0x0000B163
		protected internal override global::Infragistics.Windows.DataPresenter.DataDisplayMode SupportedDataDisplayMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataDisplayMode.Hierarchical;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0000CF66 File Offset: 0x0000B166
		protected internal override global::System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Hidden;
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000CF6C File Offset: 0x0000B16C
		protected internal override global::System.Windows.DependencyObject GetContainerForRecordPresenter(global::System.Windows.Controls.Panel panel)
		{
			if (panel is global::Infragistics.Windows.Controls.XamCarouselPanel)
			{
				return new global::Infragistics.Windows.DataPresenter.CarouselItem(panel as global::Infragistics.Windows.Controls.XamCarouselPanel);
			}
			return null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000CF90 File Offset: 0x0000B190
		protected internal override global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return new global::Infragistics.Windows.DataPresenter.CardViewFieldLayoutTemplateGenerator(fieldLayout);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000CF98 File Offset: 0x0000B198
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty)
			{
				if (this._viewSettings != null)
				{
					this._viewSettings.PropertyChanged -= this.OnViewSettingsPropertyChanged;
				}
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.Controls.CarouselViewSettings);
				if (this._viewSettings != null)
				{
					this._viewSettings.PropertyChanged += this.OnViewSettingsPropertyChanged;
				}
				base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateMeasure));
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000D018 File Offset: 0x0000B218
		protected internal override void PrepareContainerForRecordPresenter(global::System.Windows.Controls.Panel panel, global::System.Windows.DependencyObject wrapper, global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			global::Infragistics.Windows.DataPresenter.CarouselItem carouselItem = wrapper as global::Infragistics.Windows.DataPresenter.CarouselItem;
			if (carouselItem != null)
			{
				carouselItem.Content = recordPresenter;
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000D036 File Offset: 0x0000B236
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null)
			{
				return new global::Infragistics.Windows.Controls.CarouselViewSettings();
			}
			return value;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000D042 File Offset: 0x0000B242
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0000D05D File Offset: 0x0000B25D
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.CarouselViewSettings ViewSettings
		{
			get
			{
				if (this._viewSettings == null)
				{
					this._viewSettings = new global::Infragistics.Windows.Controls.CarouselViewSettings();
				}
				return this._viewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty, value);
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000D06B File Offset: 0x0000B26B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000D08C File Offset: 0x0000B28C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000D099 File Offset: 0x0000B299
		private void OnViewSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateMeasure));
		}

		// Token: 0x040000E4 RID: 228
		private global::Infragistics.Windows.Controls.CarouselViewSettings _viewSettings;

		// Token: 0x040000E5 RID: 229
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), typeof(global::Infragistics.Windows.DataPresenter.CarouselView), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CarouselView.OnCoerceViewSettings)));
	}
}
