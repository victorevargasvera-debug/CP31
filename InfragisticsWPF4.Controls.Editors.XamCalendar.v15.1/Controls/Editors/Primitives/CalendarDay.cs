using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000015 RID: 21
	[global::System.Windows.TemplateVisualState(Name = "NonWorkDay", GroupName = "WorkDayStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "WorkDay", GroupName = "WorkDayStates")]
	public sealed class CalendarDay : global::Infragistics.Controls.Editors.Primitives.CalendarItem, global::Infragistics.Controls.Editors.ITimeRangePresenter, global::Infragistics.Controls.Editors.ITimeRange
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00004BDC File Offset: 0x00002DDC
		static CalendarDay()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDay), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDay)));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004C4F File Offset: 0x00002E4F
		public CalendarDay()
		{
			base.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsWorkday, true);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004C63 File Offset: 0x00002E63
		internal CalendarDay(global::System.DateTime date, global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup month) : base(date, date, month)
		{
			base.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsWorkday, true);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004C7C File Offset: 0x00002E7C
		private static void OnIsWorkdayChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarDay calendarDay = target as global::Infragistics.Controls.Editors.Primitives.CalendarDay;
			calendarDay.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsWorkday, (bool)e.NewValue);
			calendarDay.InitializeIsHighlighted();
			calendarDay.UpdateVisualStates();
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004CB3 File Offset: 0x00002EB3
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00004CC0 File Offset: 0x00002EC0
		[global::System.ComponentModel.Bindable(true)]
		public bool IsWorkday
		{
			get
			{
				return base.InternalGetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsWorkday);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarDay.IsWorkdayPropertyKey, value);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004CD3 File Offset: 0x00002ED3
		internal override void Recycle(global::System.DateTime start, global::System.DateTime end)
		{
			base.Recycle(start, end);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public override string ToString()
		{
			return string.Format(base.CalendarManager.DateTimeFormat, "CalendarDay {0:d}", new object[]
			{
				base.StartDate
			});
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004D18 File Offset: 0x00002F18
		protected override void SetVisualState(bool useTransitions)
		{
			base.SetVisualState(useTransitions);
			if (this.IsWorkday)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "WorkDay", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "NonWorkDay", useTransitions);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004D44 File Offset: 0x00002F44
		internal void InitializeIsHighlighted()
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group = base.Group;
			if (group == null || group.IsGroupForSizing)
			{
				return;
			}
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(group);
			if (calendar == null)
			{
				return;
			}
			global::Infragistics.Controls.Editors.CalendarUtilities.SetBoolProperty(this, global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsHighlightedPropertyKey, calendar.ShouldHighlightDay(this), base.IsHighlighted, false);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00004D88 File Offset: 0x00002F88
		global::Infragistics.Controls.Editors.TimeRangeKind global::Infragistics.Controls.Editors.ITimeRangePresenter.Kind
		{
			get
			{
				return global::Infragistics.Controls.Editors.TimeRangeKind.Day;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00004D8C File Offset: 0x00002F8C
		global::System.DateTime global::Infragistics.Controls.Editors.ITimeRange.Start
		{
			get
			{
				global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
				global::System.DateTime dateTime = base.StartDate;
				if (calendar != null)
				{
					dateTime = calendar.ApplyLogicalDayOffset(dateTime);
				}
				return dateTime;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00004DB4 File Offset: 0x00002FB4
		global::System.DateTime global::Infragistics.Controls.Editors.ITimeRange.End
		{
			get
			{
				global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
				global::System.DateTime dateTime = ((global::Infragistics.Controls.Editors.ITimeRange)this).Start;
				if (calendar != null)
				{
					dateTime = calendar.AddLogicalDayDuration(dateTime);
				}
				return dateTime;
			}
		}

		// Token: 0x0400004B RID: 75
		internal static readonly global::System.Windows.DependencyPropertyKey IsWorkdayPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsWorkday", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDay), global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarDay.OnIsWorkdayChanged));

		// Token: 0x0400004C RID: 76
		public static readonly global::System.Windows.DependencyProperty IsWorkdayProperty = global::Infragistics.Controls.Editors.Primitives.CalendarDay.IsWorkdayPropertyKey.DependencyProperty;
	}
}
