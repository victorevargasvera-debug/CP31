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
	// Token: 0x0200002C RID: 44
	[global::System.Windows.TemplateVisualState(Name = "Century", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Year", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Decade", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "RegularDay", GroupName = "DayStates")]
	[global::System.Windows.TemplateVisualState(Name = "Today", GroupName = "DayStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "SelectedUnfocused", GroupName = "SelectionStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Day", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Month", GroupName = "CalendarStates")]
	public class CalendarItem : global::System.Windows.Controls.ContentControl, global::Infragistics.Windows.Selection.ISelectableElement, global::Infragistics.Windows.Selection.ISelectableItem
	{
		// Token: 0x060002E6 RID: 742 RVA: 0x0000BB58 File Offset: 0x00009D58
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

		// Token: 0x060002E7 RID: 743 RVA: 0x0000BEF3 File Offset: 0x0000A0F3
		public CalendarItem() : this(global::System.DateTime.Today, global::System.DateTime.Today, null)
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000BF06 File Offset: 0x0000A106
		internal CalendarItem(global::System.DateTime startDate, global::System.DateTime endDate, global::Infragistics.Windows.Editors.CalendarItemGroup group)
		{
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItem.StartDatePropertyKey, startDate);
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItem.EndDatePropertyKey, endDate);
			this._group = group;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000BF37 File Offset: 0x0000A137
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool ContainsSelectedDates
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.ContainsSelectedDatesProperty);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000BF49 File Offset: 0x0000A149
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool ContainsToday
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.ContainsTodayProperty);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000BF5B File Offset: 0x0000A15B
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.DateTime EndDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.EndDateProperty);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000BF6D File Offset: 0x0000A16D
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.IsActiveProperty);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000BF7F File Offset: 0x0000A17F
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000BF91 File Offset: 0x0000A191
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsSelected
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.IsSelectedProperty);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000BFB6 File Offset: 0x0000A1B6
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsSelectionActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.IsSelectionActiveProperty);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsToday
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.IsTodayProperty);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000BFDA File Offset: 0x0000A1DA
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime StartDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.CalendarItem.StartDateProperty);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		internal global::Infragistics.Windows.Editors.CalendarItemGroup Group
		{
			get
			{
				return this._group;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
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

		// Token: 0x060002F5 RID: 757 RVA: 0x0000C00F File Offset: 0x0000A20F
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

		// Token: 0x060002F6 RID: 758 RVA: 0x0000C032 File Offset: 0x0000A232
		internal bool ContainsDate(global::System.DateTime date)
		{
			return date >= this.StartDate && date <= this.EndDate;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000C050 File Offset: 0x0000A250
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

		// Token: 0x060002F8 RID: 760 RVA: 0x0000C0CC File Offset: 0x0000A2CC
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

		// Token: 0x060002F9 RID: 761 RVA: 0x0000C1E8 File Offset: 0x0000A3E8
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItem calendarItem = target as global::Infragistics.Windows.Editors.CalendarItem;
			if (calendarItem != null)
			{
				calendarItem.UpdateVisualStates();
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000C205 File Offset: 0x0000A405
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000C20E File Offset: 0x0000A40E
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

		// Token: 0x060002FC RID: 764 RVA: 0x0000C22C File Offset: 0x0000A42C
		private static void OnIsFocusWithinChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (global::Infragistics.KnownBoxes.TrueBox.Equals(e.NewValue))
			{
				global::Infragistics.Windows.Editors.CalendarItem calendarItem = (global::Infragistics.Windows.Editors.CalendarItem)d;
				global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(calendarItem);
				if (monthCalendar != null)
				{
					monthCalendar.ActiveDate = new global::System.DateTime?(calendarItem.StartDate);
				}
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000C26E File Offset: 0x0000A46E
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000C289 File Offset: 0x0000A489
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.CalendarItemAutomationPeer(this);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000C291 File Offset: 0x0000A491
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000C2AF File Offset: 0x0000A4AF
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
		public override string ToString()
		{
			return string.Format(this.CalendarManager.DateTimeFormat, "CalendarItem {0:d}-{1:d}", new object[]
			{
				this.StartDate,
				this.EndDate
			});
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000C306 File Offset: 0x0000A506
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectableElement.SelectableItem
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0000C309 File Offset: 0x0000A509
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsDraggable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000C30C File Offset: 0x0000A50C
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelectable
		{
			get
			{
				return base.IsEnabled;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000C314 File Offset: 0x0000A514
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0000C31C File Offset: 0x0000A51C
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsTabStop
		{
			get
			{
				return base.IsEnabled;
			}
		}

		// Token: 0x0400010A RID: 266
		private global::Infragistics.Windows.Editors.CalendarItemGroup _group;

		// Token: 0x0400010B RID: 267
		private bool _hasVisualStateGroups;

		// Token: 0x0400010C RID: 268
		public static readonly global::System.Windows.ResourceKey CornerRadiusKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Editors.CalendarItem), "CornerRadiusKey");

		// Token: 0x0400010D RID: 269
		internal static readonly global::System.Windows.DependencyPropertyKey ContainsSelectedDatesPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ContainsSelectedDates", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400010E RID: 270
		public static readonly global::System.Windows.DependencyProperty ContainsSelectedDatesProperty = global::Infragistics.Windows.Editors.CalendarItem.ContainsSelectedDatesPropertyKey.DependencyProperty;

		// Token: 0x0400010F RID: 271
		internal static readonly global::System.Windows.DependencyPropertyKey ContainsTodayPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ContainsToday", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000110 RID: 272
		public static readonly global::System.Windows.DependencyProperty ContainsTodayProperty = global::Infragistics.Windows.Editors.CalendarItem.ContainsTodayPropertyKey.DependencyProperty;

		// Token: 0x04000111 RID: 273
		private static readonly global::System.Windows.DependencyPropertyKey EndDatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("EndDate", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.MinValue));

		// Token: 0x04000112 RID: 274
		public static readonly global::System.Windows.DependencyProperty EndDateProperty = global::Infragistics.Windows.Editors.CalendarItem.EndDatePropertyKey.DependencyProperty;

		// Token: 0x04000113 RID: 275
		internal static readonly global::System.Windows.DependencyPropertyKey IsActivePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsActive", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)));

		// Token: 0x04000114 RID: 276
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::Infragistics.Windows.Editors.CalendarItem.IsActivePropertyKey.DependencyProperty;

		// Token: 0x04000115 RID: 277
		internal static readonly global::System.Windows.DependencyPropertyKey IsLeadingOrTrailingItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsLeadingOrTrailingItem", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)));

		// Token: 0x04000116 RID: 278
		public static readonly global::System.Windows.DependencyProperty IsLeadingOrTrailingItemProperty = global::Infragistics.Windows.Editors.CalendarItem.IsLeadingOrTrailingItemPropertyKey.DependencyProperty;

		// Token: 0x04000117 RID: 279
		internal static readonly global::System.Windows.DependencyPropertyKey IsSelectedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)));

		// Token: 0x04000118 RID: 280
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::Infragistics.Windows.Editors.CalendarItem.IsSelectedPropertyKey.DependencyProperty;

		// Token: 0x04000119 RID: 281
		public static readonly global::System.Windows.DependencyProperty IsSelectionActiveProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.IsSelectionActiveProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItem));

		// Token: 0x0400011A RID: 282
		internal static readonly global::System.Windows.DependencyPropertyKey IsTodayPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsToday", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)));

		// Token: 0x0400011B RID: 283
		public static readonly global::System.Windows.DependencyProperty IsTodayProperty = global::Infragistics.Windows.Editors.CalendarItem.IsTodayPropertyKey.DependencyProperty;

		// Token: 0x0400011C RID: 284
		private static readonly global::System.Windows.DependencyPropertyKey StartDatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("StartDate", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.MinValue));

		// Token: 0x0400011D RID: 285
		public static readonly global::System.Windows.DependencyProperty StartDateProperty = global::Infragistics.Windows.Editors.CalendarItem.StartDatePropertyKey.DependencyProperty;
	}
}
