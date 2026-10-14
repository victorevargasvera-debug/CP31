using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200002D RID: 45
	[global::System.Windows.TemplateVisualState(Name = "WorkDay", GroupName = "WorkDayStates")]
	[global::System.Windows.TemplateVisualState(Name = "NonWorkDay", GroupName = "WorkDayStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarDay : global::Infragistics.Windows.Editors.CalendarItem
	{
		// Token: 0x06000308 RID: 776 RVA: 0x0000C324 File Offset: 0x0000A524
		static CalendarDay()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarDay), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.CalendarDay)));
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000C39C File Offset: 0x0000A59C
		public CalendarDay()
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		internal CalendarDay(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarItemGroup month) : base(date, date, month)
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000C3AF File Offset: 0x0000A5AF
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000C3C1 File Offset: 0x0000A5C1
		[global::System.ComponentModel.Bindable(true)]
		public bool IsWorkday
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarDay.IsWorkdayProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarDay.IsWorkdayProperty, value);
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		internal override void Recycle(global::System.DateTime start, global::System.DateTime end)
		{
			base.Recycle(start, end);
			base.ClearValue(global::Infragistics.Windows.Editors.CalendarDay.IsWorkdayPropertyKey);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		public override string ToString()
		{
			return string.Format(base.CalendarManager.DateTimeFormat, "CalendarDay {0:d}", new object[]
			{
				base.StartDate
			});
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000C424 File Offset: 0x0000A624
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

		// Token: 0x0400011E RID: 286
		internal static readonly global::System.Windows.DependencyPropertyKey IsWorkdayPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsWorkday", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarDay), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)));

		// Token: 0x0400011F RID: 287
		public static readonly global::System.Windows.DependencyProperty IsWorkdayProperty = global::Infragistics.Windows.Editors.CalendarDay.IsWorkdayPropertyKey.DependencyProperty;
	}
}
