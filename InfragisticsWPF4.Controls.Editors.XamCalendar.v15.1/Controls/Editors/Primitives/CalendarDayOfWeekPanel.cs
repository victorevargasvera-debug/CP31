using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Controls;
using Infragistics.Controls.Primitives;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000018 RID: 24
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarDayOfWeekPanel : global::Infragistics.Controls.Primitives.UniformGrid, global::Infragistics.Controls.Editors.Primitives.ICalendarElement
	{
		// Token: 0x060000DF RID: 223 RVA: 0x00005276 File Offset: 0x00003476
		public CalendarDayOfWeekPanel()
		{
			base.Rows = 1;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005288 File Offset: 0x00003488
		internal void InitializeDaysOfWeek()
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
			if (calendar == null)
			{
				return;
			}
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			int count = children.Count;
			global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::System.DayOfWeek> daysOfWeek = calendar.DaysOfWeek;
			int count2 = daysOfWeek.Count;
			base.Columns = count2;
			int num = 0;
			for (int i = 0; i < count2; i++)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek calendarDayOfWeek = null;
				while (calendarDayOfWeek == null && num < count)
				{
					calendarDayOfWeek = (children[num] as global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek);
					num++;
				}
				if (calendarDayOfWeek == null)
				{
					calendarDayOfWeek = new global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek();
					children.Add(calendarDayOfWeek);
				}
				calendarDayOfWeek.Initialize(daysOfWeek[i], calendar);
			}
			for (int j = count - 1; j >= num; j--)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek calendarDayOfWeek2 = children[j] as global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek;
				if (calendarDayOfWeek2 != null)
				{
					children.RemoveAt(j);
				}
			}
			this._lastColumnCount = base.Columns;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000535A File Offset: 0x0000355A
		private void OnDaysOfWeekChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.InitializeDaysOfWeek();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005362 File Offset: 0x00003562
		void global::Infragistics.Controls.Editors.Primitives.ICalendarElement.OnCalendarChanged(global::Infragistics.Controls.Editors.CalendarBase newValue, global::Infragistics.Controls.Editors.CalendarBase oldValue)
		{
			if (oldValue != null)
			{
				((global::System.Collections.Specialized.INotifyCollectionChanged)oldValue.DaysOfWeek).CollectionChanged -= this.OnDaysOfWeekChanged;
			}
			if (newValue != null)
			{
				((global::System.Collections.Specialized.INotifyCollectionChanged)newValue.DaysOfWeek).CollectionChanged += this.OnDaysOfWeekChanged;
				this.InitializeDaysOfWeek();
			}
		}

		// Token: 0x04000057 RID: 87
		private int _lastColumnCount;
	}
}
