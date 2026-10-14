using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Animation;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200033E RID: 830
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public sealed class CarouselItem : global::Infragistics.Windows.Controls.CarouselListBoxItem, global::Infragistics.Windows.Selection.ISelectableElement, global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer
	{
		// Token: 0x06002774 RID: 10100 RVA: 0x000B009C File Offset: 0x000AE29C
		static CarouselItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselItem)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x000B0278 File Offset: 0x000AE478
		public CarouselItem()
		{
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000B0280 File Offset: 0x000AE480
		internal CarouselItem(global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel) : base(carouselPanel)
		{
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x000B028C File Offset: 0x000AE48C
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::System.Windows.Controls.ContentControl.ContentProperty)
			{
				if (e.OldValue is global::Infragistics.Windows.DataPresenter.RecordPresenter)
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.CarouselItem.RecordProperty);
				}
				this._recordPresenter = (e.NewValue as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				if (this.RecordPresenter != null)
				{
					base.SetBinding(global::Infragistics.Windows.DataPresenter.CarouselItem.RecordProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordProperty, global::System.Windows.Data.BindingMode.OneWay, this._recordPresenter));
				}
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000B0300 File Offset: 0x000AE500
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record record = this.Record;
				if (record != null)
				{
					return record.DataPresenter;
				}
				return null;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x000B031F File Offset: 0x000AE51F
		public global::System.Windows.Visibility ExpansionIndicatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.ExpansionIndicatorVisibilityProperty);
			}
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x000B0334 File Offset: 0x000AE534
		private static object CoerceIsExpanded(global::System.Windows.DependencyObject target, object value)
		{
			if ((bool)value)
			{
				global::Infragistics.Windows.DataPresenter.CarouselItem carouselItem = target as global::Infragistics.Windows.DataPresenter.CarouselItem;
				if (carouselItem != null && carouselItem.CarouselViewPanel != null && carouselItem.Record != null)
				{
					carouselItem.Record.IsExpanded = (bool)value;
				}
			}
			return value;
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x000B0375 File Offset: 0x000AE575
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x000B0387 File Offset: 0x000AE587
		public bool IsExpanded
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.IsExpandedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.IsExpandedProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x000B039A File Offset: 0x000AE59A
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsOpacityReduced
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.IsOpacityReducedProperty);
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x000B03AC File Offset: 0x000AE5AC
		// (set) Token: 0x0600277F RID: 10111 RVA: 0x000B03BE File Offset: 0x000AE5BE
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Animation.Storyboard ItemDisappearingStoryboard
		{
			get
			{
				return (global::System.Windows.Media.Animation.Storyboard)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.ItemDisappearingStoryboardProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.ItemDisappearingStoryboardProperty, value);
			}
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000B03CC File Offset: 0x000AE5CC
		private static void OnExpansionIndicatorVisibilityInternalChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CarouselItem carouselItem = d as global::Infragistics.Windows.DataPresenter.CarouselItem;
			if (carouselItem != null)
			{
				carouselItem.SetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.ExpansionIndicatorVisibilityPropertyKey, (global::System.Windows.Visibility)e.NewValue);
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x000B03FF File Offset: 0x000AE5FF
		// (set) Token: 0x06002782 RID: 10114 RVA: 0x000B0411 File Offset: 0x000AE611
		private global::System.Windows.Visibility ExpansionIndicatorVisibilityInternal
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.ExpansionIndicatorVisibilityInternalProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.ExpansionIndicatorVisibilityInternalProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x000B0424 File Offset: 0x000AE624
		internal global::Infragistics.Windows.DataPresenter.CarouselViewPanel CarouselViewPanel
		{
			get
			{
				return global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.CarouselViewPanel), true) as global::Infragistics.Windows.DataPresenter.CarouselViewPanel;
			}
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x000B043C File Offset: 0x000AE63C
		private static void OnIsRecordExpandedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CarouselItem carouselItem = d as global::Infragistics.Windows.DataPresenter.CarouselItem;
			if (carouselItem != null && (bool)e.NewValue && carouselItem.RecordPresenter != null && !carouselItem.RecordPresenter.IsPreparingItemForContainer)
			{
				carouselItem.OnExpanded();
			}
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x000B047C File Offset: 0x000AE67C
		private static void OnRecordPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CarouselItem carouselItem = d as global::Infragistics.Windows.DataPresenter.CarouselItem;
			if (carouselItem != null)
			{
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Path = new global::System.Windows.PropertyPath("ExpansionIndicatorVisibility", new object[0]);
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				binding.Source = (e.NewValue as global::Infragistics.Windows.DataPresenter.Record);
				carouselItem.SetBinding(global::Infragistics.Windows.DataPresenter.CarouselItem.ExpansionIndicatorVisibilityInternalProperty, binding);
				binding = new global::System.Windows.Data.Binding();
				binding.Path = new global::System.Windows.PropertyPath("IsExpanded", new object[0]);
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				binding.Source = (e.NewValue as global::Infragistics.Windows.DataPresenter.Record);
				carouselItem.SetBinding(global::Infragistics.Windows.DataPresenter.CarouselItem.IsRecordExpandedProperty, binding);
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x000B051A File Offset: 0x000AE71A
		// (set) Token: 0x06002787 RID: 10119 RVA: 0x000B052C File Offset: 0x000AE72C
		internal global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Record)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.RecordProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.RecordProperty, value);
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x000B053A File Offset: 0x000AE73A
		internal global::Infragistics.Windows.DataPresenter.RecordPresenter RecordPresenter
		{
			get
			{
				return this._recordPresenter;
			}
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x000B0542 File Offset: 0x000AE742
		private void OnExpanded()
		{
			if (this.CarouselViewPanel != null && this.Record != null)
			{
				this.CarouselViewPanel.OnRecordExpanded(this.Record);
			}
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000B0568 File Offset: 0x000AE768
		private void ResolveIsOpacityReduced()
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = base.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.IsOpacityReducedPropertyKey, recordPresenter.IsOpacityReduced);
			}
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x000B059A File Offset: 0x000AE79A
		internal void Initialize(global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			if (recordPresenter != null && recordPresenter.FieldLayout != null)
			{
				this._isOpacityReducedTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordPresenter, "IsOpacityReduced", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ResolveIsOpacityReduced));
			}
			this.ResolveIsOpacityReduced();
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x000B05CA File Offset: 0x000AE7CA
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectableElement.SelectableItem
		{
			get
			{
				if (base.Content is global::Infragistics.Windows.DataPresenter.RecordPresenter)
				{
					return ((global::Infragistics.Windows.Selection.ISelectableElement)base.Content).SelectableItem;
				}
				return null;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x000B05EB File Offset: 0x000AE7EB
		global::Infragistics.Windows.DataPresenter.RecordPresenter global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer.RecordPresenter
		{
			get
			{
				return base.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			}
		}

		// Token: 0x04001380 RID: 4992
		private global::Infragistics.Windows.DataPresenter.RecordPresenter _recordPresenter;

		// Token: 0x04001381 RID: 4993
		private global::Infragistics.Windows.Internal.PropertyValueTracker _isOpacityReducedTracker;

		// Token: 0x04001382 RID: 4994
		private static readonly global::System.Windows.DependencyPropertyKey ExpansionIndicatorVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ExpansionIndicatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityHiddenBox));

		// Token: 0x04001383 RID: 4995
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorVisibilityProperty = global::Infragistics.Windows.DataPresenter.CarouselItem.ExpansionIndicatorVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04001384 RID: 4996
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CarouselItem.CoerceIsExpanded)));

		// Token: 0x04001385 RID: 4997
		private static readonly global::System.Windows.DependencyPropertyKey IsOpacityReducedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsOpacityReduced", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04001386 RID: 4998
		public static readonly global::System.Windows.DependencyProperty IsOpacityReducedProperty = global::Infragistics.Windows.DataPresenter.CarouselItem.IsOpacityReducedPropertyKey.DependencyProperty;

		// Token: 0x04001387 RID: 4999
		public static readonly global::System.Windows.DependencyProperty ItemDisappearingStoryboardProperty = global::System.Windows.DependencyProperty.Register("ItemDisappearingStoryboard", typeof(global::System.Windows.Media.Animation.Storyboard), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04001388 RID: 5000
		private static readonly global::System.Windows.DependencyProperty ExpansionIndicatorVisibilityInternalProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorVisibilityInternal", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CarouselItem.ExpansionIndicatorVisibilityProperty.DefaultMetadata.DefaultValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CarouselItem.OnExpansionIndicatorVisibilityInternalChanged)));

		// Token: 0x04001389 RID: 5001
		private static readonly global::System.Windows.DependencyProperty IsRecordExpandedProperty = global::System.Windows.DependencyProperty.Register("IsRecordExpanded", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CarouselItem.OnIsRecordExpandedChanged)));

		// Token: 0x0400138A RID: 5002
		internal static readonly global::System.Windows.DependencyProperty RecordProperty = global::System.Windows.DependencyProperty.Register("Record", typeof(global::Infragistics.Windows.DataPresenter.Record), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CarouselItem.OnRecordPropertyChanged)));
	}
}
