using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200002F RID: 47
	[global::System.Windows.TemplateVisualState(Name = "Decade", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Today", GroupName = "DayStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "SelectedUnfocused", GroupName = "SelectionStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "RegularDay", GroupName = "DayStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Century", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Day", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Month", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Year", GroupName = "CalendarStates")]
	public class CalendarItem : global::System.Windows.Controls.ContentControl, global::Infragistics.Windows.Selection.ISelectableElement, global::Infragistics.Windows.Selection.ISelectableItem
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0000C40C File Offset: 0x0000A60C
		static CalendarItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItem)));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Input.KeyboardNavigation.IsTabStopProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.FrameworkElement.VerticalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentCenterBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentCenterBox));
			global::Infragistics.Windows.Helpers.FocusWithinManager.RegisterType(typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnIsFocusWithinChanged));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.Editors.XamMonthCalendar.IsSelectionActiveProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)), global::Infragistics.Windows.Editors.XamMonthCalendar.IsSelectionActivePropertyKey);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000C7A7 File Offset: 0x0000A9A7
		public CalendarItem() : this(global::System.DateTime.Today, global::System.DateTime.Today, null)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000C7BA File Offset: 0x0000A9BA
		internal CalendarItem(global::System.DateTime startDate, global::System.DateTime endDate, global::Infragistics.Windows.Editors.CalendarItemGroup group)
		{
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItem.StartDatePropertyKey, startDate);
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItem.EndDatePropertyKey, endDate);
			this._group = group;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000C7EB File Offset: 0x0000A9EB
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool ContainsSelectedDates
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.ContainsSelectedDatesProperty);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0000C7FD File Offset: 0x0000A9FD
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool ContainsToday
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.ContainsTodayProperty);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000C80F File Offset: 0x0000AA0F
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime EndDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.EndDateProperty);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000C821 File Offset: 0x0000AA21
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.IsActiveProperty);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000C833 File Offset: 0x0000AA33
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000C845 File Offset: 0x0000AA45
		[global::System.ComponentModel.Bindable(true)]
		public bool IsLeadingOrTrailingItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.IsLeadingOrTrailingItemProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsLeadingOrTrailingItemProperty, value);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0000C858 File Offset: 0x0000AA58
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsSelected
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.IsSelectedProperty);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0000C86A File Offset: 0x0000AA6A
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsSelectionActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.IsSelectionActiveProperty);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000C87C File Offset: 0x0000AA7C
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsToday
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.IsTodayProperty);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000C88E File Offset: 0x0000AA8E
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.DateTime StartDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.StartDateProperty);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		internal global::Infragistics.Windows.Editors.CalendarItemGroup Group
		{
			get
			{
				return this._group;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
		internal global::Infragistics.Windows.Editors.CalendarManager CalendarManager
		{
			get
			{
				if (this.Group != null)
				{
					return this.Group.CalendarManager;
				}
				return global::Infragistics.Windows.Editors.CalendarManager.CurrentCulture;
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000C8C3 File Offset: 0x0000AAC3
		internal int CompareTo(global::System.DateTime date)
		{
			if (date < this.StartDate)
			{
				return 1;
			}
			if (date > this.EndDate)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000C8E6 File Offset: 0x0000AAE6
		internal bool ContainsDate(global::System.DateTime date)
		{
			return date >= this.StartDate && date <= this.EndDate;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000C904 File Offset: 0x0000AB04
		internal virtual void Recycle(global::System.DateTime start, global::System.DateTime end)
		{
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItem.StartDatePropertyKey, start);
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItem.EndDatePropertyKey, end);
			base.ClearValue(global::Infragistics.Windows.Editors.CalendarItem.IsTodayPropertyKey);
			base.ClearValue(global::Infragistics.Windows.Editors.CalendarItem.ContainsTodayPropertyKey);
			base.ClearValue(global::Infragistics.Windows.Editors.CalendarItem.IsSelectedPropertyKey);
			base.ClearValue(global::Infragistics.Windows.Editors.CalendarItem.ContainsSelectedDatesPropertyKey);
			base.ClearValue(global::System.Windows.UIElement.IsEnabledProperty);
			base.ClearValue(global::Infragistics.Windows.Editors.CalendarItem.IsLeadingOrTrailingItemPropertyKey);
			base.ClearValue(global::Infragistics.Windows.Editors.CalendarItem.IsActivePropertyKey);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000C980 File Offset: 0x0000AB80
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (!base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			else if (base.IsMouseOver)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"MouseOver",
					"Normal"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
			}
			bool isKeyboardFocusWithin = base.IsKeyboardFocusWithin;
			if (isKeyboardFocusWithin)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"Focused",
					"Unfocused"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Unfocused", useTransitions);
			}
			global::Infragistics.Windows.Editors.CalendarItemGroup.GoToCalendarState(this, useTransitions);
			if (this.IsSelected)
			{
				if (this.IsSelectionActive)
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
			if (this.IsActive)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Active", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Inactive", useTransitions);
			}
			if (this.IsToday)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Today", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "RegularDay", useTransitions);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000CA9C File Offset: 0x0000AC9C
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItem calendarItem = target as global::Infragistics.Windows.Editors.CalendarItem;
			if (calendarItem != null)
			{
				calendarItem.UpdateVisualStates();
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000CAB9 File Offset: 0x0000ACB9
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000CAC2 File Offset: 0x0000ACC2
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		private static void OnIsFocusWithinChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (global::Infragistics.KnownBoxes.TrueBox.Equals(e.NewValue))
			{
				global::Infragistics.Windows.Editors.CalendarItem calendarItem = (global::Infragistics.Windows.Editors.CalendarItem)d;
				global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(calendarItem);
				if (monthCalendar != null)
				{
					monthCalendar.SetActiveDate(new global::System.DateTime?(calendarItem.StartDate));
				}
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000CB22 File Offset: 0x0000AD22
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000CB3D File Offset: 0x0000AD3D
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.CalendarItemAutomationPeer(this);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000CB45 File Offset: 0x0000AD45
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000CB54 File Offset: 0x0000AD54
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000CB63 File Offset: 0x0000AD63
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000CB74 File Offset: 0x0000AD74
		public override string ToString()
		{
			return string.Format(this.CalendarManager.DateTimeFormat, "CalendarItem {0:d}-{1:d}", new object[]
			{
				this.StartDate,
				this.EndDate
			});
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000CBBA File Offset: 0x0000ADBA
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectableElement.SelectableItem
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000CBBD File Offset: 0x0000ADBD
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsDraggable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelectable
		{
			get
			{
				return base.IsEnabled;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsTabStop
		{
			get
			{
				return base.IsEnabled;
			}
		}

		// Token: 0x04000122 RID: 290
		private global::Infragistics.Windows.Editors.CalendarItemGroup _group;

		// Token: 0x04000123 RID: 291
		private bool _hasVisualStateGroups;

		// Token: 0x04000124 RID: 292
		public static readonly global::System.Windows.ResourceKey CornerRadiusKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Editors.CalendarItem), "CornerRadiusKey");

		// Token: 0x04000125 RID: 293
		internal static readonly global::System.Windows.DependencyPropertyKey ContainsSelectedDatesPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ContainsSelectedDates", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000126 RID: 294
		public static readonly global::System.Windows.DependencyProperty ContainsSelectedDatesProperty = global::Infragistics.Windows.Editors.CalendarItem.ContainsSelectedDatesPropertyKey.DependencyProperty;

		// Token: 0x04000127 RID: 295
		internal static readonly global::System.Windows.DependencyPropertyKey ContainsTodayPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ContainsToday", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000128 RID: 296
		public static readonly global::System.Windows.DependencyProperty ContainsTodayProperty = global::Infragistics.Windows.Editors.CalendarItem.ContainsTodayPropertyKey.DependencyProperty;

		// Token: 0x04000129 RID: 297
		private static readonly global::System.Windows.DependencyPropertyKey EndDatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("EndDate", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.MinValue));

		// Token: 0x0400012A RID: 298
		public static readonly global::System.Windows.DependencyProperty EndDateProperty = global::Infragistics.Windows.Editors.CalendarItem.EndDatePropertyKey.DependencyProperty;

		// Token: 0x0400012B RID: 299
		internal static readonly global::System.Windows.DependencyPropertyKey IsActivePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsActive", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)));

		// Token: 0x0400012C RID: 300
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::Infragistics.Windows.Editors.CalendarItem.IsActivePropertyKey.DependencyProperty;

		// Token: 0x0400012D RID: 301
		internal static readonly global::System.Windows.DependencyPropertyKey IsLeadingOrTrailingItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsLeadingOrTrailingItem", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)));

		// Token: 0x0400012E RID: 302
		public static readonly global::System.Windows.DependencyProperty IsLeadingOrTrailingItemProperty = global::Infragistics.Windows.Editors.CalendarItem.IsLeadingOrTrailingItemPropertyKey.DependencyProperty;

		// Token: 0x0400012F RID: 303
		internal static readonly global::System.Windows.DependencyPropertyKey IsSelectedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)));

		// Token: 0x04000130 RID: 304
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::Infragistics.Windows.Editors.CalendarItem.IsSelectedPropertyKey.DependencyProperty;

		// Token: 0x04000131 RID: 305
		public static readonly global::System.Windows.DependencyProperty IsSelectionActiveProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.IsSelectionActiveProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItem));

		// Token: 0x04000132 RID: 306
		internal static readonly global::System.Windows.DependencyPropertyKey IsTodayPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsToday", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)));

		// Token: 0x04000133 RID: 307
		public static readonly global::System.Windows.DependencyProperty IsTodayProperty = global::Infragistics.Windows.Editors.CalendarItem.IsTodayPropertyKey.DependencyProperty;

		// Token: 0x04000134 RID: 308
		private static readonly global::System.Windows.DependencyPropertyKey StartDatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("StartDate", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.MinValue));

		// Token: 0x04000135 RID: 309
		public static readonly global::System.Windows.DependencyProperty StartDateProperty = global::Infragistics.Windows.Editors.CalendarItem.StartDatePropertyKey.DependencyProperty;
	}
}
