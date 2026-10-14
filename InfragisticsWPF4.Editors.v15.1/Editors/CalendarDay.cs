using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000030 RID: 48
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "NonWorkDay", GroupName = "WorkDayStates")]
	[global::System.Windows.TemplateVisualState(Name = "WorkDay", GroupName = "WorkDayStates")]
	public class CalendarDay : global::Infragistics.Windows.Editors.CalendarItem
	{
		// Token: 0x06000328 RID: 808 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
		static CalendarDay()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarDay), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.CalendarDay)));
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000CC50 File Offset: 0x0000AE50
		public CalendarDay()
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000CC58 File Offset: 0x0000AE58
		internal CalendarDay(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarItemGroup month) : base(date, date, month)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000CC63 File Offset: 0x0000AE63
		// (set) Token: 0x0600032C RID: 812 RVA: 0x0000CC75 File Offset: 0x0000AE75
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

		// Token: 0x0600032D RID: 813 RVA: 0x0000CC88 File Offset: 0x0000AE88
		internal override void Recycle(global::System.DateTime start, global::System.DateTime end)
		{
			base.Recycle(start, end);
			base.ClearValue(global::Infragistics.Windows.Editors.CalendarDay.IsWorkdayPropertyKey);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		public override string ToString()
		{
			return string.Format(base.CalendarManager.DateTimeFormat, "CalendarDay {0:d}", new object[]
			{
				base.StartDate
			});
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000CCD8 File Offset: 0x0000AED8
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

		// Token: 0x04000136 RID: 310
		internal static readonly global::System.Windows.DependencyPropertyKey IsWorkdayPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsWorkday", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarDay), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItem.OnVisualStatePropertyChanged)));

		// Token: 0x04000137 RID: 311
		public static readonly global::System.Windows.DependencyProperty IsWorkdayProperty = global::Infragistics.Windows.Editors.CalendarDay.IsWorkdayPropertyKey.DependencyProperty;
	}
}
