using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using Infragistics.Windows.Editors.Events;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000041 RID: 65
	public class SelectedDateCollection : global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>
	{
		// Token: 0x06000434 RID: 1076 RVA: 0x00012227 File Offset: 0x00010427
		internal SelectedDateCollection(global::Infragistics.Windows.Editors.XamMonthCalendar owner)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("owner", owner);
			this._owner = owner;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00012244 File Offset: 0x00010444
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

		// Token: 0x06000436 RID: 1078 RVA: 0x00012284 File Offset: 0x00010484
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

		// Token: 0x06000437 RID: 1079 RVA: 0x00012320 File Offset: 0x00010520
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.InvalidateSortedDates();
			this._owner.SelectedDate = ((base.Items.Count == 0) ? null : new global::System.DateTime?(base.Items[0]));
			base.OnCollectionChanged(e);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00012370 File Offset: 0x00010570
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

		// Token: 0x06000439 RID: 1081 RVA: 0x000123B4 File Offset: 0x000105B4
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

		// Token: 0x0600043A RID: 1082 RVA: 0x00012418 File Offset: 0x00010618
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

		// Token: 0x0600043B RID: 1083 RVA: 0x000124B0 File Offset: 0x000106B0
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

		// Token: 0x0600043C RID: 1084 RVA: 0x0001258F File Offset: 0x0001078F
		internal bool IsSelected(global::System.DateTime date)
		{
			this.VerifySortedDates();
			return global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, date) >= 0;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000125A9 File Offset: 0x000107A9
		private void RaiseSelectionChanged(global::System.Collections.Generic.IList<global::System.DateTime> selected, global::System.Collections.Generic.IList<global::System.DateTime> unselected)
		{
			this._owner.OnSelectedStateChanged(selected, unselected);
			this._owner.RaiseSelectedDatesChanged(new global::Infragistics.Windows.Editors.Events.SelectedDatesChangedEventArgs(unselected, selected));
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000125CC File Offset: 0x000107CC
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

		// Token: 0x0600043F RID: 1087 RVA: 0x00012688 File Offset: 0x00010888
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

		// Token: 0x06000440 RID: 1088 RVA: 0x000126F9 File Offset: 0x000108F9
		private void InvalidateSortedDates()
		{
			this._sortedDates = null;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00012704 File Offset: 0x00010904
		private void SyncSortedDates()
		{
			global::System.DateTime[] array = new global::System.DateTime[base.Count];
			base.CopyTo(array, 0);
			global::System.Array.Sort<global::System.DateTime>(array, global::System.Collections.Generic.Comparer<global::System.DateTime>.Default);
			this._sortedDates = array;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00012738 File Offset: 0x00010938
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

		// Token: 0x06000443 RID: 1091 RVA: 0x0001277B File Offset: 0x0001097B
		private void VerifySortedDates()
		{
			if (this._sortedDates == null)
			{
				this.SyncSortedDates();
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0001278C File Offset: 0x0001098C
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

		// Token: 0x06000445 RID: 1093 RVA: 0x000128AA File Offset: 0x00010AAA
		public void Sort()
		{
			if (base.Count > 0)
			{
				this.VerifySortedDates();
				this.Reinitialize(this._sortedDates);
			}
		}

		// Token: 0x04000194 RID: 404
		private global::Infragistics.Windows.Editors.XamMonthCalendar _owner;

		// Token: 0x04000195 RID: 405
		private global::System.DateTime[] _sortedDates;
	}
}
