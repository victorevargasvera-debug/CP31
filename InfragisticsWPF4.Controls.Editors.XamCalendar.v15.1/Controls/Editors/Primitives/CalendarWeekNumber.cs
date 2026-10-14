using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Infragistics.Controls.Primitives;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000028 RID: 40
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "SelectedUnfocused", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	public class CalendarWeekNumber : global::System.Windows.Controls.Control, global::Infragistics.Controls.Primitives.ISelectableElement, global::Infragistics.Controls.Primitives.ISelectableItem
	{
		// Token: 0x06000239 RID: 569 RVA: 0x0000C480 File Offset: 0x0000A680
		static CalendarWeekNumber()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.OnIsEnabledPropertyChanged)));
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000C59A File Offset: 0x0000A79A
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
			this._isInitialized = true;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0000C5CE File Offset: 0x0000A7CE
		public global::System.Windows.Media.Brush ComputedBackground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.ComputedBackgroundProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.ComputedBackgroundPropertyKey, value);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0000C5DC File Offset: 0x0000A7DC
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0000C5EE File Offset: 0x0000A7EE
		public global::System.Windows.Media.Brush ComputedForeground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.ComputedForegroundProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.ComputedForegroundPropertyKey, value);
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		private static void OnIsSelectedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber calendarWeekNumber = (global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber)d;
			calendarWeekNumber.UpdateVisualStates();
			if ((bool)e.NewValue)
			{
				calendarWeekNumber._calendar.SelectedDatesInternalChanged += calendarWeekNumber.OnCalendar_SelectedDatesChanged;
				return;
			}
			calendarWeekNumber._calendar.SelectedDatesInternalChanged -= calendarWeekNumber.OnCalendar_SelectedDatesChanged;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0000C653 File Offset: 0x0000A853
		// (set) Token: 0x06000242 RID: 578 RVA: 0x0000C665 File Offset: 0x0000A865
		public bool IsSelected
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.IsSelectedProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.IsSelectedPropertyKey, value);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000C678 File Offset: 0x0000A878
		internal global::Infragistics.DateRange Range
		{
			get
			{
				return this._dateRange;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000C680 File Offset: 0x0000A880
		internal int Week
		{
			get
			{
				return this._week;
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000C688 File Offset: 0x0000A888
		internal void Initialize(global::Infragistics.Controls.Editors.CalendarBase cal, global::Infragistics.Controls.Editors.Primitives.CalendarItemArea itemArea, int weekNumber, global::System.Windows.Visibility vis, global::System.DateTime startDay, global::System.DateTime endDay)
		{
			this._calendar = cal;
			this._itemArea = itemArea;
			this._week = weekNumber;
			this._dateRange = new global::Infragistics.DateRange(startDay, endDay);
			if (vis == global::System.Windows.Visibility.Visible)
			{
				base.DataContext = weekNumber;
			}
			else
			{
				base.DataContext = string.Empty;
			}
			this.VerifyIsSelected();
			global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(this, cal);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000C6E3 File Offset: 0x0000A8E3
		private void OnCalendar_SelectedDatesChanged(object sender, global::Infragistics.Controls.Editors.SelectedDatesChangedEventArgs e)
		{
			this.VerifyIsSelected();
			base.Dispatcher.BeginInvoke(new global::System.Action(this.VerifyIsSelected), new object[0]);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000C70C File Offset: 0x0000A90C
		internal void SetProviderBrushes()
		{
			if (this._calendar == null)
			{
				return;
			}
			global::Infragistics.Controls.Editors.CalendarResourceProvider resourceProviderResolved = this._calendar.ResourceProviderResolved;
			if (resourceProviderResolved == null)
			{
				return;
			}
			bool isSelected = this.IsSelected;
			bool isSelectionActive = this._calendar.IsSelectionActive;
			global::Infragistics.Controls.Editors.CalendarResourceId key;
			global::Infragistics.Controls.Editors.CalendarResourceId key2;
			if (!base.IsEnabled)
			{
				key = global::Infragistics.Controls.Editors.CalendarResourceId.DisabledWeekNumberBackgroundBrush;
				key2 = global::Infragistics.Controls.Editors.CalendarResourceId.DisabledWeekNumberForegroundBrush;
			}
			else if (isSelected)
			{
				if (isSelectionActive)
				{
					key = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedFocusedItemBackgroundBrush;
					key2 = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedFocusedItemForegroundBrush;
				}
				else
				{
					key = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedItemBackgroundBrush;
					key2 = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedItemForegroundBrush;
				}
			}
			else
			{
				key = global::Infragistics.Controls.Editors.CalendarResourceId.WeekNumberBackgroundBrush;
				key2 = global::Infragistics.Controls.Editors.CalendarResourceId.WeekNumberForegroundBrush;
			}
			this.ComputedBackground = (resourceProviderResolved[key] as global::System.Windows.Media.Brush);
			this.ComputedForeground = (resourceProviderResolved[key2] as global::System.Windows.Media.Brush);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000C79C File Offset: 0x0000A99C
		internal void VerifyIsSelected()
		{
			global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection selectedDateCollection = this._calendar.SelectedDatesInternal as global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection;
			if (this._calendar.SupportsWeekSelectionMode && selectedDateCollection.IsSelected(this._dateRange))
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.IsSelectedPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				return;
			}
			base.ClearValue(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.IsSelectedPropertyKey);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (this._calendar == null)
			{
				return;
			}
			if (!base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
			}
			if (this.IsSelected)
			{
				if (this._calendar.IsSelectionActive)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "Selected", useTransitions);
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(this, "SelectedUnfocused", useTransitions);
				}
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Unselected", useTransitions);
			}
			this.SetProviderBrushes();
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000C874 File Offset: 0x0000AA74
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000C87D File Offset: 0x0000AA7D
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				this.SetProviderBrushes();
				return;
			}
			if (!this._isInitialized)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		private static void OnIsEnabledPropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber calendarWeekNumber = target as global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber;
			calendarWeekNumber.UpdateVisualStates();
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000C8BA File Offset: 0x0000AABA
		global::Infragistics.Controls.Primitives.ISelectableItem global::Infragistics.Controls.Primitives.ISelectableElement.SelectableItem
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000C8BD File Offset: 0x0000AABD
		bool global::Infragistics.Controls.Primitives.ISelectableItem.IsSelectable
		{
			get
			{
				return this._calendar.SupportsWeekSelectionMode;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000C8CA File Offset: 0x0000AACA
		bool global::Infragistics.Controls.Primitives.ISelectableItem.IsDraggable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000C8CD File Offset: 0x0000AACD
		bool global::Infragistics.Controls.Primitives.ISelectableItem.IsTabStop
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040000D3 RID: 211
		private global::Infragistics.Controls.Editors.CalendarBase _calendar;

		// Token: 0x040000D4 RID: 212
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemArea _itemArea;

		// Token: 0x040000D5 RID: 213
		private int _week;

		// Token: 0x040000D6 RID: 214
		private global::Infragistics.DateRange _dateRange;

		// Token: 0x040000D7 RID: 215
		private bool _hasVisualStateGroups;

		// Token: 0x040000D8 RID: 216
		private bool _isInitialized;

		// Token: 0x040000D9 RID: 217
		private static readonly global::System.Windows.DependencyPropertyKey ComputedBackgroundPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedBackground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber), new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Transparent), null);

		// Token: 0x040000DA RID: 218
		public static readonly global::System.Windows.DependencyProperty ComputedBackgroundProperty = global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.ComputedBackgroundPropertyKey.DependencyProperty;

		// Token: 0x040000DB RID: 219
		private static readonly global::System.Windows.DependencyPropertyKey ComputedForegroundPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedForeground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber), new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Transparent), null);

		// Token: 0x040000DC RID: 220
		public static readonly global::System.Windows.DependencyProperty ComputedForegroundProperty = global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.ComputedForegroundPropertyKey.DependencyProperty;

		// Token: 0x040000DD RID: 221
		private static readonly global::System.Windows.DependencyPropertyKey IsSelectedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsSelected", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber), global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.OnIsSelectedChanged));

		// Token: 0x040000DE RID: 222
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber.IsSelectedPropertyKey.DependencyProperty;
	}
}
