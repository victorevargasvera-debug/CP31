using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Controls.Primitives;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000029 RID: 41
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarWeekNumberPanel : global::Infragistics.Controls.Primitives.UniformGrid
	{
		// Token: 0x06000251 RID: 593 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		public CalendarWeekNumberPanel()
		{
			base.Columns = 1;
			base.Rows = 6;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		internal global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber GetWeekNumber(int weekNumber)
		{
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			int count = children.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber calendarWeekNumber = children[i] as global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber;
				if (calendarWeekNumber != null && calendarWeekNumber.Week == weekNumber)
				{
					return calendarWeekNumber;
				}
			}
			return null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000C92C File Offset: 0x0000AB2C
		internal void InitializeItemsArea(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea itemsArea)
		{
			if (itemsArea == this._itemArea)
			{
				return;
			}
			if (this._itemArea != null)
			{
				((global::System.Collections.Specialized.INotifyCollectionChanged)this._itemArea.WeekNumbers).CollectionChanged -= this.OnWeekNumbersChanged;
			}
			this._itemArea = itemsArea;
			if (this._itemArea != null)
			{
				this.InitializeWeekNumbers();
				((global::System.Collections.Specialized.INotifyCollectionChanged)this._itemArea.WeekNumbers).CollectionChanged += this.OnWeekNumbersChanged;
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000C998 File Offset: 0x0000AB98
		private void InitializeWeekNumbers()
		{
			if (this._itemArea == null)
			{
				return;
			}
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(this);
			if (calendar == null)
			{
				return;
			}
			global::System.DateTime? firstDate = this._itemArea.FirstDate;
			if (firstDate == null)
			{
				return;
			}
			global::System.Windows.Visibility weekNumberVisibility = calendar.WeekNumberVisibility;
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			int count = children.Count;
			global::System.Collections.ObjectModel.ReadOnlyObservableCollection<int> weekNumbers = this._itemArea.WeekNumbers;
			int count2 = children.Count;
			int count3 = weekNumbers.Count;
			global::Infragistics.Controls.Editors.CalendarManager calendarManager = calendar.CalendarManager;
			int num;
			global::System.DateTime dateTime = calendarManager.GetFirstDayOfWeekForDate(firstDate.Value, calendar.FirstDayOfWeekInternal, out num);
			int num2 = 0;
			for (int i = 0; i < count3; i++)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber calendarWeekNumber = null;
				while (calendarWeekNumber == null && num2 < count)
				{
					calendarWeekNumber = (children[num2] as global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber);
					num2++;
				}
				if (calendarWeekNumber == null)
				{
					calendarWeekNumber = new global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber();
					children.Add(calendarWeekNumber);
				}
				global::System.DateTime dateTime2 = calendarManager.AddDays(dateTime, 6 + num);
				num = 0;
				calendarWeekNumber.Initialize(calendar, this._itemArea, weekNumbers[i], weekNumberVisibility, dateTime, dateTime2);
				dateTime = calendarManager.AddDays(dateTime2, 1);
			}
			for (int j = count - 1; j >= num2; j--)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber calendarWeekNumber2 = children[j] as global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber;
				if (calendarWeekNumber2 != null)
				{
					children.RemoveAt(j);
				}
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000CAD7 File Offset: 0x0000ACD7
		private void OnWeekNumbersChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.InitializeWeekNumbers();
		}

		// Token: 0x040000DF RID: 223
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemArea _itemArea;
	}
}
