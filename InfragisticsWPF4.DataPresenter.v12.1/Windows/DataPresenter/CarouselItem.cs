using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Animation;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002FE RID: 766
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public sealed class CarouselItem : global::Infragistics.Windows.Controls.CarouselListBoxItem, global::Infragistics.Windows.Selection.ISelectableElement, global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer
	{
		// Token: 0x060023D1 RID: 9169 RVA: 0x0009C710 File Offset: 0x0009A910
		static CarouselItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselItem)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0009C8B0 File Offset: 0x0009AAB0
		public CarouselItem()
		{
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0009C8B8 File Offset: 0x0009AAB8
		internal CarouselItem(global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel) : base(carouselPanel)
		{
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0009C8C4 File Offset: 0x0009AAC4
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

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x0009C938 File Offset: 0x0009AB38
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

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x0009C957 File Offset: 0x0009AB57
		public global::System.Windows.Visibility ExpansionIndicatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.ExpansionIndicatorVisibilityProperty);
			}
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0009C96C File Offset: 0x0009AB6C
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

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x0009C9AD File Offset: 0x0009ABAD
		// (set) Token: 0x060023D9 RID: 9177 RVA: 0x0009C9BF File Offset: 0x0009ABBF
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

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x0009C9D2 File Offset: 0x0009ABD2
		// (set) Token: 0x060023DB RID: 9179 RVA: 0x0009C9E4 File Offset: 0x0009ABE4
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

		// Token: 0x060023DC RID: 9180 RVA: 0x0009C9F4 File Offset: 0x0009ABF4
		private static void OnExpansionIndicatorVisibilityInternalChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CarouselItem carouselItem = d as global::Infragistics.Windows.DataPresenter.CarouselItem;
			if (carouselItem != null)
			{
				carouselItem.SetValue(global::Infragistics.Windows.DataPresenter.CarouselItem.ExpansionIndicatorVisibilityPropertyKey, (global::System.Windows.Visibility)e.NewValue);
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x0009CA27 File Offset: 0x0009AC27
		// (set) Token: 0x060023DE RID: 9182 RVA: 0x0009CA39 File Offset: 0x0009AC39
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

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x060023DF RID: 9183 RVA: 0x0009CA4C File Offset: 0x0009AC4C
		internal global::Infragistics.Windows.DataPresenter.CarouselViewPanel CarouselViewPanel
		{
			get
			{
				return global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.CarouselViewPanel), true) as global::Infragistics.Windows.DataPresenter.CarouselViewPanel;
			}
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x0009CA64 File Offset: 0x0009AC64
		private static void OnIsRecordExpandedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CarouselItem carouselItem = d as global::Infragistics.Windows.DataPresenter.CarouselItem;
			if (carouselItem != null && (bool)e.NewValue && carouselItem.RecordPresenter != null && !carouselItem.RecordPresenter.IsPreparingItemForContainer)
			{
				carouselItem.OnExpanded();
			}
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x0009CAA4 File Offset: 0x0009ACA4
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

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x0009CB42 File Offset: 0x0009AD42
		// (set) Token: 0x060023E3 RID: 9187 RVA: 0x0009CB54 File Offset: 0x0009AD54
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

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x0009CB62 File Offset: 0x0009AD62
		internal global::Infragistics.Windows.DataPresenter.RecordPresenter RecordPresenter
		{
			get
			{
				return this._recordPresenter;
			}
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x0009CB6A File Offset: 0x0009AD6A
		private void OnExpanded()
		{
			if (this.CarouselViewPanel != null && this.Record != null)
			{
				this.CarouselViewPanel.OnRecordExpanded(this.Record);
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x0009CB8D File Offset: 0x0009AD8D
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

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x0009CBAE File Offset: 0x0009ADAE
		global::Infragistics.Windows.DataPresenter.RecordPresenter global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer.RecordPresenter
		{
			get
			{
				return base.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			}
		}

		// Token: 0x04001166 RID: 4454
		private global::Infragistics.Windows.DataPresenter.RecordPresenter _recordPresenter;

		// Token: 0x04001167 RID: 4455
		private static readonly global::System.Windows.DependencyPropertyKey ExpansionIndicatorVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ExpansionIndicatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityHiddenBox));

		// Token: 0x04001168 RID: 4456
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorVisibilityProperty = global::Infragistics.Windows.DataPresenter.CarouselItem.ExpansionIndicatorVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04001169 RID: 4457
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CarouselItem.CoerceIsExpanded)));

		// Token: 0x0400116A RID: 4458
		public static readonly global::System.Windows.DependencyProperty ItemDisappearingStoryboardProperty = global::System.Windows.DependencyProperty.Register("ItemDisappearingStoryboard", typeof(global::System.Windows.Media.Animation.Storyboard), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400116B RID: 4459
		private static readonly global::System.Windows.DependencyProperty ExpansionIndicatorVisibilityInternalProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorVisibilityInternal", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CarouselItem.ExpansionIndicatorVisibilityProperty.DefaultMetadata.DefaultValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CarouselItem.OnExpansionIndicatorVisibilityInternalChanged)));

		// Token: 0x0400116C RID: 4460
		private static readonly global::System.Windows.DependencyProperty IsRecordExpandedProperty = global::System.Windows.DependencyProperty.Register("IsRecordExpanded", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CarouselItem.OnIsRecordExpandedChanged)));

		// Token: 0x0400116D RID: 4461
		internal static readonly global::System.Windows.DependencyProperty RecordProperty = global::System.Windows.DependencyProperty.Register("Record", typeof(global::Infragistics.Windows.DataPresenter.Record), typeof(global::Infragistics.Windows.DataPresenter.CarouselItem), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CarouselItem.OnRecordPropertyChanged)));
	}
}
