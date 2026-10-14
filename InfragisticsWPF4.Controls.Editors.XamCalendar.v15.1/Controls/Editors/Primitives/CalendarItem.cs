using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.AutomationPeers;
using Infragistics.Controls.Primitives;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000011 RID: 17
	[global::System.Windows.TemplateVisualState(Name = "Day", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Month", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Year", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Decade", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Century", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "IsNotLeadingOrTrailing", GroupName = "LeadingOrTrailingStates")]
	[global::System.Windows.TemplateVisualState(Name = "RegularDay", GroupName = "DayStates")]
	[global::System.Windows.TemplateVisualState(Name = "Today", GroupName = "DayStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "SelectedUnfocused", GroupName = "SelectionStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "IsHighlighted", GroupName = "HighlightStates")]
	[global::System.Windows.TemplateVisualState(Name = "IsNotHighlighted", GroupName = "HighlightStates")]
	[global::System.Windows.TemplateVisualState(Name = "IsLeadingOrTrailing", GroupName = "LeadingOrTrailingStates")]
	public class CalendarItem : global::System.Windows.Controls.ContentControl, global::Infragistics.Controls.Primitives.ISelectableElement, global::Infragistics.Controls.Primitives.ISelectableItem, global::Infragistics.Controls.Primitives.IResourceProviderClient
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00003CC0 File Offset: 0x00001EC0
		static CalendarItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem)));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItem.OnIsEnabledPropertyChanged)));
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000040D0 File Offset: 0x000022D0
		public CalendarItem() : this(global::System.DateTime.Today, global::System.DateTime.Today, null)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000040E3 File Offset: 0x000022E3
		internal CalendarItem(global::System.DateTime startDate, global::System.DateTime endDate, global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group)
		{
			base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.StartDatePropertyKey, startDate);
			base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.EndDatePropertyKey, endDate);
			this._group = group;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000411F File Offset: 0x0000231F
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00004131 File Offset: 0x00002331
		public global::System.Windows.Media.Brush ComputedBackground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedBackgroundProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedBackgroundPropertyKey, value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000413F File Offset: 0x0000233F
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00004151 File Offset: 0x00002351
		public global::System.Windows.Media.Brush ComputedBorderBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedBorderBrushProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedBorderBrushPropertyKey, value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000415F File Offset: 0x0000235F
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00004171 File Offset: 0x00002371
		public global::System.Windows.Media.Brush ComputedForeground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedForegroundProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedForegroundPropertyKey, value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000417F File Offset: 0x0000237F
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00004191 File Offset: 0x00002391
		public global::System.Windows.Media.Brush ComputedInnerBorderBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedInnerBorderBrushProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedInnerBorderBrushPropertyKey, value);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000041A0 File Offset: 0x000023A0
		private static void OnContainsSelectedDatesChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			calendarItem.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.ContainsSelectedDates, (bool)e.NewValue);
			calendarItem.UpdateVisualStates();
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000041CD File Offset: 0x000023CD
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000041D6 File Offset: 0x000023D6
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool ContainsSelectedDates
		{
			get
			{
				return this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.ContainsSelectedDates);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ContainsSelectedDatesPropertyKey, value);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000041EC File Offset: 0x000023EC
		private static void OnContainsTodayChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			calendarItem.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.ContainsToday, (bool)e.NewValue);
			calendarItem.UpdateVisualStates();
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00004219 File Offset: 0x00002419
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00004222 File Offset: 0x00002422
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool ContainsToday
		{
			get
			{
				return this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.ContainsToday);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ContainsTodayPropertyKey, value);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004238 File Offset: 0x00002438
		private static void OnEndDateChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			calendarItem.FormatContent();
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00004252 File Offset: 0x00002452
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00004264 File Offset: 0x00002464
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime EndDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.EndDateProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.EndDatePropertyKey, value);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004278 File Offset: 0x00002478
		internal static void OnIsActivePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			if (calendarItem != null)
			{
				calendarItem.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsActive, (bool)e.NewValue);
				calendarItem.UpdateVisualStates();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000042A8 File Offset: 0x000024A8
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000042B1 File Offset: 0x000024B1
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsActive
		{
			get
			{
				return this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsActive);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsActivePropertyKey, value);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000042C4 File Offset: 0x000024C4
		private static void OnIsHighlightedChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			calendarItem.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsHighlighted, (bool)e.NewValue);
			calendarItem.UpdateVisualStates();
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000042F1 File Offset: 0x000024F1
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000042FA File Offset: 0x000024FA
		public bool IsHighlighted
		{
			get
			{
				return this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsHighlighted);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsHighlightedPropertyKey, value);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004310 File Offset: 0x00002510
		private static void OnIsLeadingOrTrailingItemChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			calendarItem.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsLeadingOrTrailingItem, (bool)e.NewValue);
			calendarItem.UpdateVisualStates();
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000433E File Offset: 0x0000253E
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00004348 File Offset: 0x00002548
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsLeadingOrTrailingItem
		{
			get
			{
				return this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsLeadingOrTrailingItem);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsLeadingOrTrailingItemPropertyKey, value);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000435C File Offset: 0x0000255C
		private static void OnIsSelectedChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			calendarItem.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsSelected, (bool)e.NewValue);
			calendarItem.UpdateVisualStates();
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000438A File Offset: 0x0000258A
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00004394 File Offset: 0x00002594
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsSelected
		{
			get
			{
				return this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsSelected);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectedPropertyKey, value);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000043A8 File Offset: 0x000025A8
		private static void OnIsSelectionActiveChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			calendarItem.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsSelectionActive, (bool)e.NewValue);
			calendarItem.UpdateVisualStates();
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000043D6 File Offset: 0x000025D6
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000043E0 File Offset: 0x000025E0
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsSelectionActive
		{
			get
			{
				return this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsSelectionActive);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectionActivePropertyKey, value);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000043F4 File Offset: 0x000025F4
		private static void OnIsTodayChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			calendarItem.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsToday, (bool)e.NewValue);
			calendarItem.UpdateVisualStates();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00004425 File Offset: 0x00002625
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00004432 File Offset: 0x00002632
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsToday
		{
			get
			{
				return this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsToday);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsTodayPropertyKey, value);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004448 File Offset: 0x00002648
		private static void OnStartDateChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			calendarItem.FormatContent();
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00004462 File Offset: 0x00002662
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00004474 File Offset: 0x00002674
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime StartDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.StartDateProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.StartDatePropertyKey, value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00004487 File Offset: 0x00002687
		internal global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup Group
		{
			get
			{
				return this._group;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000448F File Offset: 0x0000268F
		internal global::Infragistics.Controls.Editors.CalendarManager CalendarManager
		{
			get
			{
				if (this.Group != null)
				{
					return this.Group.CalendarManager;
				}
				return global::Infragistics.Controls.Editors.CalendarManager.CurrentCulture;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000044AA File Offset: 0x000026AA
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

		// Token: 0x0600009B RID: 155 RVA: 0x000044CD File Offset: 0x000026CD
		internal bool ContainsDate(global::System.DateTime date)
		{
			return date >= this.StartDate && date <= this.EndDate;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000044EB File Offset: 0x000026EB
		internal bool InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags prop)
		{
			return (ushort)(this._propFlags & prop) != 0;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000044FC File Offset: 0x000026FC
		internal void InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags prop, bool value)
		{
			if (value)
			{
				this._propFlags |= prop;
				return;
			}
			this._propFlags &= ~prop;
			if (prop == global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsInitializing)
			{
				if (this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.FormattedContentDirty))
				{
					this.FormatContent();
				}
				if (this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.VisualStateDirty))
				{
					this.UpdateVisualStates();
				}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000455B File Offset: 0x0000275B
		internal void OnCurrentModeChanged(global::Infragistics.Controls.Editors.CalendarZoomMode newMode, global::Infragistics.Controls.Editors.CalendarZoomMode oldMode)
		{
			this.FormatContent();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004563 File Offset: 0x00002763
		internal void OnMouseEnter()
		{
			this.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsMouseOver, true);
			this.UpdateVisualStates();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004577 File Offset: 0x00002777
		internal void OnMouseLeave()
		{
			this.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsMouseOver, false);
			this.UpdateVisualStates();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000458B File Offset: 0x0000278B
		internal virtual void Recycle(global::System.DateTime start, global::System.DateTime end)
		{
			base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.StartDatePropertyKey, start);
			base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.EndDatePropertyKey, end);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000045B0 File Offset: 0x000027B0
		internal void SetIsEnabled(bool isEnabled, bool isRecycled)
		{
			if (!isEnabled)
			{
				base.SetValue(global::System.Windows.UIElement.IsEnabledProperty, global::Infragistics.KnownBoxes.FalseBox);
			}
			else if (isRecycled && !base.IsEnabled)
			{
				base.ClearValue(global::System.Windows.UIElement.IsEnabledProperty);
				base.CoerceValue(global::System.Windows.UIElement.IsEnabledProperty);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000045FC File Offset: 0x000027FC
		internal virtual void SetProviderBrushes()
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(this);
			if (calendar == null)
			{
				return;
			}
			global::Infragistics.Controls.Editors.CalendarResourceProvider resourceProviderResolved = calendar.ResourceProviderResolved;
			if (resourceProviderResolved == null)
			{
				return;
			}
			bool isToday = this.IsToday;
			bool isSelected = this.IsSelected;
			bool isSelectionActive = this.IsSelectionActive;
			bool isEnabled = base.IsEnabled;
			bool isLeadingOrTrailingItem = this.IsLeadingOrTrailingItem;
			global::Infragistics.Controls.Editors.CalendarResourceId key;
			global::Infragistics.Controls.Editors.CalendarResourceId key2;
			global::Infragistics.Controls.Editors.CalendarResourceId key3;
			global::Infragistics.Controls.Editors.CalendarResourceId key4;
			if (isSelected)
			{
				if (isSelectionActive)
				{
					key = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedFocusedItemBorderBrush;
					key2 = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedFocusedItemInnerBorderBrush;
					if (isLeadingOrTrailingItem)
					{
						key3 = (isToday ? global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedFocusedItemForegroundBrush : global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedFocusedItemForegroundBrush);
						key4 = (isToday ? global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedFocusedItemBackgroundBrush : global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedFocusedItemBackgroundBrush);
					}
					else if (isToday)
					{
						key3 = global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedFocusedItemForegroundBrush;
						key4 = global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedFocusedItemBackgroundBrush;
					}
					else
					{
						key3 = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedFocusedItemForegroundBrush;
						key4 = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedFocusedItemBackgroundBrush;
					}
				}
				else
				{
					key = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedItemBorderBrush;
					key2 = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedItemInnerBorderBrush;
					if (isLeadingOrTrailingItem)
					{
						key3 = (isToday ? global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedItemForegroundBrush : global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedItemForegroundBrush);
						key4 = (isToday ? global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedItemBackgroundBrush : global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedItemBackgroundBrush);
					}
					else if (isToday)
					{
						key3 = global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedItemForegroundBrush;
						key4 = global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedItemBackgroundBrush;
					}
					else
					{
						key3 = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedItemForegroundBrush;
						key4 = global::Infragistics.Controls.Editors.CalendarResourceId.SelectedItemBackgroundBrush;
					}
				}
			}
			else if (this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsMouseOver))
			{
				key4 = global::Infragistics.Controls.Editors.CalendarResourceId.MouseOverItemBackgroundBrush;
				key = global::Infragistics.Controls.Editors.CalendarResourceId.MouseOverItemBorderBrush;
				key3 = (isLeadingOrTrailingItem ? global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingMouseOverItemForegroundBrush : global::Infragistics.Controls.Editors.CalendarResourceId.MouseOverItemForegroundBrush);
				key2 = global::Infragistics.Controls.Editors.CalendarResourceId.MouseOverItemInnerBorderBrush;
			}
			else
			{
				key = global::Infragistics.Controls.Editors.CalendarResourceId.ItemBorderBrush;
				key2 = global::Infragistics.Controls.Editors.CalendarResourceId.ItemInnerBorderBrush;
				if (isToday)
				{
					key3 = (isLeadingOrTrailingItem ? global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodayForegroundBrush : global::Infragistics.Controls.Editors.CalendarResourceId.TodayForegroundBrush);
					key4 = (isLeadingOrTrailingItem ? global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodayBackgroundBrush : global::Infragistics.Controls.Editors.CalendarResourceId.TodayBackgroundBrush);
				}
				else if (isLeadingOrTrailingItem)
				{
					key3 = global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemForegroundBrush;
					key4 = global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemBackgroundBrush;
				}
				else
				{
					key3 = global::Infragistics.Controls.Editors.CalendarResourceId.ItemForegroundBrush;
					key4 = global::Infragistics.Controls.Editors.CalendarResourceId.ItemBackgroundBrush;
				}
			}
			if (isToday)
			{
				key = global::Infragistics.Controls.Editors.CalendarResourceId.TodayBorderBrush;
				key2 = global::Infragistics.Controls.Editors.CalendarResourceId.ItemInnerBorderBrush;
			}
			if (!isEnabled)
			{
				key4 = global::Infragistics.Controls.Editors.CalendarResourceId.DisabledItemBackgroundBrush;
				key3 = global::Infragistics.Controls.Editors.CalendarResourceId.DisabledItemForegroundBrush;
			}
			this.ComputedBackground = (resourceProviderResolved[key4] as global::System.Windows.Media.Brush);
			this.ComputedBorderBrush = (resourceProviderResolved[key] as global::System.Windows.Media.Brush);
			this.ComputedForeground = (resourceProviderResolved[key3] as global::System.Windows.Media.Brush);
			this.ComputedInnerBorderBrush = (resourceProviderResolved[key2] as global::System.Windows.Media.Brush);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004794 File Offset: 0x00002994
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (!base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			else if (this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsMouseOver))
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
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar((this._group != null) ? this._group : this);
			bool flag = calendar != null && this.IsActive && calendar.IsKeyboardFocusWithin;
			if (flag)
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
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GoToCalendarState(this, useTransitions);
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
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "RegularDay", useTransitions);
			}
			if (this.IsHighlighted)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "IsHighlighted", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "IsNotHighlighted", useTransitions);
			}
			if (this.IsLeadingOrTrailingItem)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "IsLeadingOrTrailing", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "IsNotLeadingOrTrailing", useTransitions);
			}
			this.SetProviderBrushes();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004928 File Offset: 0x00002B28
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			if (calendarItem != null)
			{
				calendarItem.UpdateVisualStates();
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004948 File Offset: 0x00002B48
		protected internal void UpdateVisualStates()
		{
			bool flag = this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsInitializing);
			this.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.VisualStateDirty, flag);
			if (!flag)
			{
				this.UpdateVisualStates(true);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004977 File Offset: 0x00002B77
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.HasVisualStateGroups))
			{
				this.SetProviderBrushes();
				return;
			}
			if (!this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsInitialized))
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000049A4 File Offset: 0x00002BA4
		private void FormatContent()
		{
			if (this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsInitializing) || !this.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsInitialized))
			{
				this.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.FormattedContentDirty, true);
				return;
			}
			this.FormatContentImpl();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000049D4 File Offset: 0x00002BD4
		private void FormatContentImpl()
		{
			this.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.FormattedContentDirty, false);
			bool flag = false;
			string format;
			switch (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(this))
			{
			default:
				format = "{0:%d}";
				break;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
				format = "{0:MMM}";
				break;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
				format = "{0:yyyy}";
				break;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
				format = "{0:yyyy}-\n{1:yyyy}";
				flag = true;
				break;
			}
			if (flag)
			{
				base.Content = string.Format(global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat, format, new object[]
				{
					this.StartDate,
					this.EndDate
				});
				return;
			}
			base.Content = string.Format(global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat, format, new object[]
			{
				this.StartDate
			});
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004AA0 File Offset: 0x00002CA0
		private static void OnIsEnabledPropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			calendarItem.UpdateVisualStates();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004ABC File Offset: 0x00002CBC
		private static void OnIsFocusWithinChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (global::Infragistics.KnownBoxes.TrueBox.Equals(e.NewValue))
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = (global::Infragistics.Controls.Editors.Primitives.CalendarItem)d;
				global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(calendarItem);
				if (calendar != null)
				{
					calendar.ActiveDate = new global::System.DateTime?(calendarItem.StartDate);
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004AFE File Offset: 0x00002CFE
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.HasVisualStateGroups, global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this));
			this.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsInitialized, true);
			this.FormatContent();
			this.UpdateVisualStates(false);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004B30 File Offset: 0x00002D30
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.CalendarItemAutomationPeer(this);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00004B38 File Offset: 0x00002D38
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004B47 File Offset: 0x00002D47
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004B50 File Offset: 0x00002D50
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.OnMouseEnter();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004B5F File Offset: 0x00002D5F
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.OnMouseLeave();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004B70 File Offset: 0x00002D70
		public override string ToString()
		{
			return string.Format(this.CalendarManager.DateTimeFormat, "CalendarItem {0:d}-{1:d}", new object[]
			{
				this.StartDate,
				this.EndDate
			});
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00004BB6 File Offset: 0x00002DB6
		global::Infragistics.Controls.Primitives.ISelectableItem global::Infragistics.Controls.Primitives.ISelectableElement.SelectableItem
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00004BB9 File Offset: 0x00002DB9
		bool global::Infragistics.Controls.Primitives.ISelectableItem.IsDraggable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004BBC File Offset: 0x00002DBC
		bool global::Infragistics.Controls.Primitives.ISelectableItem.IsSelectable
		{
			get
			{
				return base.IsEnabled;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00004BC4 File Offset: 0x00002DC4
		bool global::Infragistics.Controls.Primitives.ISelectableItem.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00004BCC File Offset: 0x00002DCC
		bool global::Infragistics.Controls.Primitives.ISelectableItem.IsTabStop
		{
			get
			{
				return base.IsEnabled;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004BD4 File Offset: 0x00002DD4
		void global::Infragistics.Controls.Primitives.IResourceProviderClient.OnResourcesChanged()
		{
			base.InvalidateMeasure();
		}

		// Token: 0x0400001D RID: 29
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup _group;

		// Token: 0x0400001E RID: 30
		private global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags _propFlags = global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.VisualStateDirty;

		// Token: 0x0400001F RID: 31
		private static readonly global::System.Windows.DependencyPropertyKey ComputedBackgroundPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedBackground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Transparent), null);

		// Token: 0x04000020 RID: 32
		public static readonly global::System.Windows.DependencyProperty ComputedBackgroundProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedBackgroundPropertyKey.DependencyProperty;

		// Token: 0x04000021 RID: 33
		private static readonly global::System.Windows.DependencyPropertyKey ComputedBorderBrushPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedBorderBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Transparent), null);

		// Token: 0x04000022 RID: 34
		public static readonly global::System.Windows.DependencyProperty ComputedBorderBrushProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedBorderBrushPropertyKey.DependencyProperty;

		// Token: 0x04000023 RID: 35
		private static readonly global::System.Windows.DependencyPropertyKey ComputedForegroundPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedForeground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Black), null);

		// Token: 0x04000024 RID: 36
		public static readonly global::System.Windows.DependencyProperty ComputedForegroundProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedForegroundPropertyKey.DependencyProperty;

		// Token: 0x04000025 RID: 37
		private static readonly global::System.Windows.DependencyPropertyKey ComputedInnerBorderBrushPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedInnerBorderBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Transparent), null);

		// Token: 0x04000026 RID: 38
		public static readonly global::System.Windows.DependencyProperty ComputedInnerBorderBrushProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.ComputedInnerBorderBrushPropertyKey.DependencyProperty;

		// Token: 0x04000027 RID: 39
		internal static readonly global::System.Windows.DependencyPropertyKey ContainsSelectedDatesPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ContainsSelectedDates", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItem.OnContainsSelectedDatesChanged));

		// Token: 0x04000028 RID: 40
		public static readonly global::System.Windows.DependencyProperty ContainsSelectedDatesProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.ContainsSelectedDatesPropertyKey.DependencyProperty;

		// Token: 0x04000029 RID: 41
		internal static readonly global::System.Windows.DependencyPropertyKey ContainsTodayPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ContainsToday", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItem.OnContainsTodayChanged));

		// Token: 0x0400002A RID: 42
		public static readonly global::System.Windows.DependencyProperty ContainsTodayProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.ContainsTodayPropertyKey.DependencyProperty;

		// Token: 0x0400002B RID: 43
		private static readonly global::System.Windows.DependencyPropertyKey EndDatePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("EndDate", typeof(global::System.DateTime), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), global::System.DateTime.MinValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItem.OnEndDateChanged));

		// Token: 0x0400002C RID: 44
		public static readonly global::System.Windows.DependencyProperty EndDateProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.EndDatePropertyKey.DependencyProperty;

		// Token: 0x0400002D RID: 45
		internal static readonly global::System.Windows.DependencyPropertyKey IsActivePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsActive", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItem.OnIsActivePropertyChanged));

		// Token: 0x0400002E RID: 46
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsActivePropertyKey.DependencyProperty;

		// Token: 0x0400002F RID: 47
		internal static readonly global::System.Windows.DependencyPropertyKey IsHighlightedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsHighlighted", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItem.OnIsHighlightedChanged));

		// Token: 0x04000030 RID: 48
		public static readonly global::System.Windows.DependencyProperty IsHighlightedProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsHighlightedPropertyKey.DependencyProperty;

		// Token: 0x04000031 RID: 49
		internal static readonly global::System.Windows.DependencyPropertyKey IsLeadingOrTrailingItemPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsLeadingOrTrailingItem", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItem.OnIsLeadingOrTrailingItemChanged));

		// Token: 0x04000032 RID: 50
		public static readonly global::System.Windows.DependencyProperty IsLeadingOrTrailingItemProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsLeadingOrTrailingItemPropertyKey.DependencyProperty;

		// Token: 0x04000033 RID: 51
		internal static readonly global::System.Windows.DependencyPropertyKey IsSelectedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsSelected", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItem.OnIsSelectedChanged));

		// Token: 0x04000034 RID: 52
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectedPropertyKey.DependencyProperty;

		// Token: 0x04000035 RID: 53
		internal static readonly global::System.Windows.DependencyPropertyKey IsSelectionActivePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsSelectionActive", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItem.OnIsSelectionActiveChanged));

		// Token: 0x04000036 RID: 54
		public static readonly global::System.Windows.DependencyProperty IsSelectionActiveProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectionActivePropertyKey.DependencyProperty;

		// Token: 0x04000037 RID: 55
		internal static readonly global::System.Windows.DependencyPropertyKey IsTodayPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsToday", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItem.OnIsTodayChanged));

		// Token: 0x04000038 RID: 56
		public static readonly global::System.Windows.DependencyProperty IsTodayProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsTodayPropertyKey.DependencyProperty;

		// Token: 0x04000039 RID: 57
		private static readonly global::System.Windows.DependencyPropertyKey StartDatePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("StartDate", typeof(global::System.DateTime), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem), global::System.DateTime.MinValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItem.OnStartDateChanged));

		// Token: 0x0400003A RID: 58
		public static readonly global::System.Windows.DependencyProperty StartDateProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItem.StartDatePropertyKey.DependencyProperty;

		// Token: 0x02000012 RID: 18
		[global::System.Flags]
		internal enum PropFlags : ushort
		{
			// Token: 0x0400003C RID: 60
			ContainsSelectedDates = 1,
			// Token: 0x0400003D RID: 61
			ContainsToday = 2,
			// Token: 0x0400003E RID: 62
			IsActive = 4,
			// Token: 0x0400003F RID: 63
			IsHighlighted = 8,
			// Token: 0x04000040 RID: 64
			IsLeadingOrTrailingItem = 16,
			// Token: 0x04000041 RID: 65
			IsSelected = 32,
			// Token: 0x04000042 RID: 66
			IsSelectionActive = 64,
			// Token: 0x04000043 RID: 67
			IsToday = 128,
			// Token: 0x04000044 RID: 68
			IsWorkday = 256,
			// Token: 0x04000045 RID: 69
			IsMouseOver = 512,
			// Token: 0x04000046 RID: 70
			IsInitialized = 1024,
			// Token: 0x04000047 RID: 71
			HasVisualStateGroups = 2048,
			// Token: 0x04000048 RID: 72
			FormattedContentDirty = 8192,
			// Token: 0x04000049 RID: 73
			IsInitializing = 16384,
			// Token: 0x0400004A RID: 74
			VisualStateDirty = 32768
		}
	}
}
