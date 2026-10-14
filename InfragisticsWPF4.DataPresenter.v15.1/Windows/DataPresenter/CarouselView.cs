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
		// Token: 0x06000391 RID: 913 RVA: 0x0000D938 File Offset: 0x0000BB38
		public CarouselView()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty, this.ViewSettings);
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0000D951 File Offset: 0x0000BB51
		protected internal override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.CardView;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0000D954 File Offset: 0x0000BB54
		protected internal override global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0000D957 File Offset: 0x0000BB57
		protected internal override int DefaultAutoArrangeMaxColumns
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0000D95A File Offset: 0x0000BB5A
		protected internal override int DefaultAutoArrangeMaxRows
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000D95D File Offset: 0x0000BB5D
		protected internal override bool DefaultAutoFit
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0000D960 File Offset: 0x0000BB60
		protected internal override global::Infragistics.Windows.DataPresenter.CellClickAction DefaultCellClickAction
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellClickAction.SelectCell;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000D963 File Offset: 0x0000BB63
		protected internal override global::Infragistics.Windows.DataPresenter.LabelClickAction DefaultLabelClickAction
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0000D966 File Offset: 0x0000BB66
		protected internal override global::Infragistics.Windows.DataPresenter.LabelLocation DefaultLabelLocation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelLocation.Hidden;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000D969 File Offset: 0x0000BB69
		protected internal override bool HasLogicalOrientation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000D96C File Offset: 0x0000BB6C
		protected internal override global::System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Hidden;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000D96F File Offset: 0x0000BB6F
		protected internal override bool IsAddNewRecordSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0000D972 File Offset: 0x0000BB72
		protected internal override bool IsAutoFitHeightSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0000D975 File Offset: 0x0000BB75
		protected internal override bool IsAutoFitWidthSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000D978 File Offset: 0x0000BB78
		protected internal sealed override bool IsCrossLevelSelectionSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000D97B File Offset: 0x0000BB7B
		protected internal override bool IsLogicalFieldHeightResizingAllowed
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000D97E File Offset: 0x0000BB7E
		protected internal override bool IsLogicalFieldWidthResizingAllowed
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000D981 File Offset: 0x0000BB81
		protected internal override bool IsNestedPanelsSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000D984 File Offset: 0x0000BB84
		protected internal override bool IsSummaryRecordSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000D987 File Offset: 0x0000BB87
		protected internal override global::System.Type ItemsPanelType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.CarouselViewPanel);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0000D993 File Offset: 0x0000BB93
		protected internal override global::System.Type RecordPresenterContainerType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.CarouselItem);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000D99F File Offset: 0x0000BB9F
		protected internal override bool ShouldDisplayRecordSelectors
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0000D9A2 File Offset: 0x0000BBA2
		protected internal override global::Infragistics.Windows.DataPresenter.DataDisplayMode SupportedDataDisplayMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataDisplayMode.Hierarchical;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000D9A5 File Offset: 0x0000BBA5
		protected internal override global::System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Hidden;
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
		protected internal override global::System.Windows.DependencyObject GetContainerForRecordPresenter(global::System.Windows.Controls.Panel panel, global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (panel is global::Infragistics.Windows.Controls.XamCarouselPanel)
			{
				return new global::Infragistics.Windows.DataPresenter.CarouselItem(panel as global::Infragistics.Windows.Controls.XamCarouselPanel);
			}
			return null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000D9CC File Offset: 0x0000BBCC
		protected internal override global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return new global::Infragistics.Windows.DataPresenter.CardViewFieldLayoutTemplateGenerator(fieldLayout);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000D9D4 File Offset: 0x0000BBD4
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

		// Token: 0x060003AC RID: 940 RVA: 0x0000DA54 File Offset: 0x0000BC54
		protected internal override void PrepareContainerForRecordPresenter(global::System.Windows.Controls.Panel panel, global::System.Windows.DependencyObject wrapper, global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			global::Infragistics.Windows.DataPresenter.CarouselItem carouselItem = wrapper as global::Infragistics.Windows.DataPresenter.CarouselItem;
			if (carouselItem != null)
			{
				carouselItem.Content = recordPresenter;
				carouselItem.Initialize(recordPresenter);
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000DA79 File Offset: 0x0000BC79
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null)
			{
				return new global::Infragistics.Windows.Controls.CarouselViewSettings();
			}
			return value;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000DA85 File Offset: 0x0000BC85
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
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

		// Token: 0x060003B0 RID: 944 RVA: 0x0000DAAE File Offset: 0x0000BCAE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000DACF File Offset: 0x0000BCCF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000DADC File Offset: 0x0000BCDC
		private void OnViewSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateMeasure));
		}

		// Token: 0x040000F7 RID: 247
		private global::Infragistics.Windows.Controls.CarouselViewSettings _viewSettings;

		// Token: 0x040000F8 RID: 248
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), typeof(global::Infragistics.Windows.DataPresenter.CarouselView), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CarouselView.OnCoerceViewSettings)));
	}
}
