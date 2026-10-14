using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using Infragistics.Windows.Editors.Events;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000044 RID: 68
	public class SelectedDateCollection : global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x00012EE7 File Offset: 0x000110E7
		internal SelectedDateCollection(global::Infragistics.Windows.Editors.XamMonthCalendar owner)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("owner", owner);
			this._owner = owner;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00012F04 File Offset: 0x00011104
		protected override void ClearItems()
		{
			global::System.DateTime[] array = new global::System.DateTime[base.Count];
			base.CopyTo(array, 0);
			this.InvalidateSortedDates();
			base.ClearItems();
			if (array.Length > 0)
			{
				this.RaiseSelectionChanged(new global::System.DateTime[0], array);
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00012F44 File Offset: 0x00011144
		protected override void InsertItem(int index, global::System.DateTime item)
		{
			item = item.Date;
			this.VerifyCanAdd(item);
			if (base.Count + 1 > this._owner.MaxSelectedDatesResolved)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.Utils.GetString("LE_MaxSelectedDatesExceeded", new object[]
				{
					base.Count + 1,
					this._owner.MaxSelectedDatesResolved
				}));
			}
			this.InvalidateSortedDates();
			base.InsertItem(index, item);
			this.RaiseSelectionChanged(new global::System.DateTime[]
			{
				item
			}, new global::System.DateTime[0]);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00012FE0 File Offset: 0x000111E0
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.InvalidateSortedDates();
			this._owner.SelectedDate = ((base.Items.Count == 0) ? null : new global::System.DateTime?(base.Items[0]));
			base.OnCollectionChanged(e);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00013030 File Offset: 0x00011230
		protected override void RemoveItem(int index)
		{
			global::System.DateTime dateTime = base[index];
			this.InvalidateSortedDates();
			base.RemoveItem(index);
			this.RaiseSelectionChanged(new global::System.DateTime[0], new global::System.DateTime[]
			{
				dateTime
			});
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00013074 File Offset: 0x00011274
		protected override void SetItem(int index, global::System.DateTime item)
		{
			item = item.Date;
			this.VerifyCanAdd(item);
			this.InvalidateSortedDates();
			global::System.DateTime dateTime = base[index];
			base.SetItem(index, item);
			this.RaiseSelectionChanged(new global::System.DateTime[]
			{
				item
			}, new global::System.DateTime[]
			{
				dateTime
			});
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000130D8 File Offset: 0x000112D8
		internal bool ContainsSelection(global::System.DateTime start, global::System.DateTime end)
		{
			if (start == end)
			{
				return this.IsSelected(start);
			}
			this.VerifySortedDates();
			int num = global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, start);
			if (num >= 0)
			{
				return true;
			}
			num = ~num;
			int num2 = global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, end);
			if (num2 >= 0)
			{
				return true;
			}
			num2 = ~num2;
			int i = num;
			int num3 = global::System.Math.Min(num2, this._sortedDates.Length - 1);
			while (i <= num3)
			{
				global::System.DateTime t = this._sortedDates[i];
				if (t >= start && t <= end)
				{
					return true;
				}
				i++;
			}
			return false;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00013170 File Offset: 0x00011370
		internal void EnsureWithinMinMax()
		{
			if (base.Count > 0)
			{
				this.VerifySortedDates();
				global::System.DateTime minDate = this._owner.MinDate;
				global::System.DateTime maxDate = this._owner.MaxDate;
				int num = global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, minDate);
				int num2 = global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, maxDate);
				if (num < 0)
				{
					num = ~num;
				}
				if (num2 < 0)
				{
					num2 = ~num2;
					num2--;
				}
				int num3 = num2 - num + 1;
				if (num3 < base.Count)
				{
					global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>(global::System.Math.Max(num3, 0));
					if (num3 > 0)
					{
						global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = new global::Infragistics.Windows.Editors.CalendarDateRange(minDate, maxDate);
						int i = 0;
						int count = base.Items.Count;
						while (i < count)
						{
							global::System.DateTime dateTime = base.Items[i];
							if (calendarDateRange.Contains(dateTime))
							{
								list.Add(dateTime);
							}
							i++;
						}
					}
					this.Reinitialize(list.ToArray());
				}
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0001324F File Offset: 0x0001144F
		internal bool IsSelected(global::System.DateTime date)
		{
			this.VerifySortedDates();
			return global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, date) >= 0;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00013269 File Offset: 0x00011469
		private void RaiseSelectionChanged(global::System.Collections.Generic.IList<global::System.DateTime> selected, global::System.Collections.Generic.IList<global::System.DateTime> unselected)
		{
			this._owner.OnSelectedStateChanged(selected, unselected);
			this._owner.RaiseSelectedDatesChanged(new global::Infragistics.Windows.Editors.Events.SelectedDatesChangedEventArgs(unselected, selected));
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0001328C File Offset: 0x0001148C
		internal void Reinitialize(global::System.Collections.Generic.IList<global::System.DateTime> newSelection)
		{
			global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>();
			global::System.Collections.Generic.List<global::System.DateTime> list2 = new global::System.Collections.Generic.List<global::System.DateTime>();
			this.CalculateDelta(newSelection, list, list2);
			this.InvalidateSortedDates();
			base.Items.Clear();
			foreach (global::System.DateTime item in newSelection)
			{
				base.Items.Add(item);
			}
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Count"));
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Item[]"));
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			if (list.Count > 0 || list2.Count > 0)
			{
				this.RaiseSelectionChanged(list, list2);
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00013348 File Offset: 0x00011548
		private void CalculateDelta(global::System.Collections.Generic.IList<global::System.DateTime> newSelection, global::System.Collections.Generic.List<global::System.DateTime> datesSelected, global::System.Collections.Generic.List<global::System.DateTime> datesUnselected)
		{
			if (newSelection.Count == 0)
			{
				datesUnselected.AddRange(this);
				return;
			}
			if (base.Count == 0)
			{
				datesSelected.AddRange(newSelection);
				return;
			}
			datesUnselected.AddRange(this);
			int i = 0;
			int count = newSelection.Count;
			while (i < count)
			{
				global::System.DateTime date = newSelection[i].Date;
				if (this.IsSelected(date))
				{
					datesUnselected.Remove(date);
				}
				else
				{
					datesSelected.Add(date);
				}
				i++;
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000133B9 File Offset: 0x000115B9
		private void InvalidateSortedDates()
		{
			this._sortedDates = null;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000133C4 File Offset: 0x000115C4
		private void SyncSortedDates()
		{
			global::System.DateTime[] array = new global::System.DateTime[base.Count];
			base.CopyTo(array, 0);
			global::System.Array.Sort<global::System.DateTime>(array, global::System.Collections.Generic.Comparer<global::System.DateTime>.Default);
			this._sortedDates = array;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000133F8 File Offset: 0x000115F8
		private void VerifyCanAdd(global::System.DateTime date)
		{
			this.VerifySortedDates();
			if (global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, date) > 0)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.Utils.GetString("LE_DateAlreadySelected", new object[]
				{
					date
				}));
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0001343B File Offset: 0x0001163B
		private void VerifySortedDates()
		{
			if (this._sortedDates == null)
			{
				this.SyncSortedDates();
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0001344C File Offset: 0x0001164C
		public void AddRange(global::System.DateTime start, global::System.DateTime end, bool allowPartialSelection)
		{
			global::System.DateTime[] selectableDates = this._owner.GetSelectableDates(new global::Infragistics.Windows.Editors.CalendarDateRange(start.Date, end.Date));
			if (selectableDates != null && selectableDates.Length > 0)
			{
				int num = selectableDates.Length;
				for (int i = 0; i < selectableDates.Length; i++)
				{
					this.VerifyCanAdd(selectableDates[i]);
				}
				int maxSelectedDatesResolved = this._owner.MaxSelectedDatesResolved;
				if (base.Count + num > maxSelectedDatesResolved)
				{
					if (!allowPartialSelection)
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.Utils.GetString("LE_MaxSelectedDatesExceeded", new object[]
						{
							base.Count + num,
							maxSelectedDatesResolved
						}));
					}
					num = maxSelectedDatesResolved - base.Count;
				}
				for (int j = 0; j < num; j++)
				{
					base.Items.Add(selectableDates[j]);
				}
				this.InvalidateSortedDates();
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Count"));
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Item[]"));
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				this.RaiseSelectionChanged(selectableDates, new global::System.DateTime[0]);
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0001356A File Offset: 0x0001176A
		public void Sort()
		{
			if (base.Count > 0)
			{
				this.VerifySortedDates();
				this.Reinitialize(this._sortedDates);
			}
		}

		// Token: 0x040001AF RID: 431
		private global::Infragistics.Windows.Editors.XamMonthCalendar _owner;

		// Token: 0x040001B0 RID: 432
		private global::System.DateTime[] _sortedDates;
	}
}
