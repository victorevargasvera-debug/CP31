using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Collections
{
	// Token: 0x02000034 RID: 52
	public class DateCollection : global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>, global::System.Collections.Generic.ICollection<global::System.DateTime>, global::System.Collections.Generic.IEnumerable<global::System.DateTime>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600022D RID: 557 RVA: 0x000098E4 File Offset: 0x00007AE4
		protected override void ClearItems()
		{
			global::System.DateTime[] array = new global::System.DateTime[base.Count];
			base.CopyTo(array, 0);
			this.InvalidateSortedDates();
			base.ClearItems();
			if (array.Length > 0)
			{
				this.OnDatesChanged(new global::System.DateTime[0], array);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00009924 File Offset: 0x00007B24
		protected override void InsertItem(int index, global::System.DateTime item)
		{
			item = item.Date;
			this.VerifyCanAdd(item);
			int num = base.Count + 1;
			this.VerifyNewDateCount(ref num, true);
			this.InvalidateSortedDates();
			base.InsertItem(index, item);
			this.OnDatesChanged(new global::System.DateTime[]
			{
				item
			}, new global::System.DateTime[0]);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00009984 File Offset: 0x00007B84
		protected override void RemoveItem(int index)
		{
			global::System.DateTime dateTime = base[index];
			this.InvalidateSortedDates();
			base.RemoveItem(index);
			this.OnDatesChanged(new global::System.DateTime[0], new global::System.DateTime[]
			{
				dateTime
			});
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000099C8 File Offset: 0x00007BC8
		protected override void SetItem(int index, global::System.DateTime item)
		{
			item = item.Date;
			if (base[index] == item)
			{
				return;
			}
			this.VerifyCanAdd(item);
			this.InvalidateSortedDates();
			global::System.DateTime dateTime = base[index];
			base.SetItem(index, item);
			this.OnDatesChanged(new global::System.DateTime[]
			{
				item
			}, new global::System.DateTime[]
			{
				dateTime
			});
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00009A3B File Offset: 0x00007C3B
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00009A43 File Offset: 0x00007C43
		protected internal global::Infragistics.DateRange AllowedRange
		{
			get
			{
				return this._allowedRange;
			}
			set
			{
				value.Normalize();
				value.RemoveTime();
				if (value != this._allowedRange)
				{
					this._allowedRange = value;
					this.EnsureWithinMinMax();
				}
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00009A6E File Offset: 0x00007C6E
		internal int BinarySearch(global::System.DateTime date)
		{
			this.VerifySortedDates();
			return global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, date.Date);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00009A88 File Offset: 0x00007C88
		internal bool ContainsDate(global::System.DateTime date)
		{
			return this.BinarySearch(date) >= 0;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00009A98 File Offset: 0x00007C98
		internal void Reinitialize(global::System.Collections.Generic.IList<global::System.DateTime> newSelection)
		{
			global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>();
			global::System.Collections.Generic.List<global::System.DateTime> list2 = new global::System.Collections.Generic.List<global::System.DateTime>();
			if (newSelection != this._sortedDates)
			{
				this.CalculateDelta(newSelection, list, list2);
				this.InvalidateSortedDates();
			}
			base.Items.Clear();
			foreach (global::System.DateTime item in newSelection)
			{
				base.Items.Add(item);
			}
			if (list.Count > 0 || list2.Count > 0)
			{
				this.OnDatesChanged(list, list2);
			}
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Count"));
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Item[]"));
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00009B64 File Offset: 0x00007D64
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
				if (this.ContainsDate(date))
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

		// Token: 0x06000237 RID: 567 RVA: 0x00009BD8 File Offset: 0x00007DD8
		private void EnsureWithinMinMax()
		{
			if (base.Count > 0)
			{
				this.VerifySortedDates();
				global::Infragistics.DateRange allowedRange = this.AllowedRange;
				allowedRange.Normalize();
				allowedRange.RemoveTime();
				global::System.DateTime start = allowedRange.Start;
				global::System.DateTime end = allowedRange.End;
				int num = global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, start);
				int num2 = global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, end);
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
						global::Infragistics.DateRange dateRange = new global::Infragistics.DateRange(start, end);
						int i = 0;
						int count = base.Items.Count;
						while (i < count)
						{
							global::System.DateTime dateTime = base.Items[i];
							if (dateRange.Contains(dateTime))
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

		// Token: 0x06000238 RID: 568 RVA: 0x00009CCB File Offset: 0x00007ECB
		private void InvalidateSortedDates()
		{
			this._isSortDirty = true;
			this._sortedDates = null;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00009CDC File Offset: 0x00007EDC
		private void SyncSortedDates()
		{
			global::System.DateTime[] array = new global::System.DateTime[base.Count];
			base.CopyTo(array, 0);
			global::System.Array.Sort<global::System.DateTime>(array, global::System.Collections.Generic.Comparer<global::System.DateTime>.Default);
			this._sortedDates = array;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00009D10 File Offset: 0x00007F10
		private void VerifyCanAdd(global::System.DateTime date)
		{
			this.VerifySortedDates();
			if (global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, date) >= 0)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_DateAlreadySelected", new object[]
				{
					date
				}));
			}
			if (!this._allowedRange.Contains(date))
			{
				throw new global::System.ArgumentOutOfRangeException(string.Format(global::SR.GetString("LE_DateOutOfRange"), date, this._allowedRange.Start, this._allowedRange.End));
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00009D9C File Offset: 0x00007F9C
		private void VerifySortedDates()
		{
			if (this._sortedDates == null)
			{
				this.SyncSortedDates();
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00009DAC File Offset: 0x00007FAC
		public void AddRange(global::System.DateTime start, global::System.DateTime end, bool allowPartialSelection)
		{
			this.AddRange(new global::Infragistics.DateRange(start, end), allowPartialSelection);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00009DBC File Offset: 0x00007FBC
		public void AddRange(global::Infragistics.DateRange range, bool allowPartialSelection)
		{
			range.RemoveTime();
			range.Normalize();
			if (!allowPartialSelection && !this._allowedRange.Contains(range))
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			global::System.DateTime[] array = this.GetAllowedDates(range);
			if (array != null && array.Length > 0)
			{
				int num = array.Length;
				for (int i = 0; i < array.Length; i++)
				{
					this.VerifyCanAdd(array[i]);
				}
				int num2 = base.Count + num;
				int num3 = num2;
				this.VerifyNewDateCount(ref num3, !allowPartialSelection);
				if (num3 < num2)
				{
					num = num3 - base.Count;
					if (num <= 0)
					{
						return;
					}
					global::System.DateTime[] array2 = new global::System.DateTime[num];
					global::System.Array.Copy(array, array2, num);
					array = array2;
				}
				for (int j = 0; j < num; j++)
				{
					base.Items.Add(array[j]);
				}
				this.InvalidateSortedDates();
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Count"));
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Item[]"));
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				this.OnDatesChanged(array, new global::System.DateTime[0]);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00009ED0 File Offset: 0x000080D0
		public new bool Contains(global::System.DateTime date)
		{
			return this.ContainsDate(date);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00009EDC File Offset: 0x000080DC
		public bool IntersectsWith(global::Infragistics.DateRange range)
		{
			range.RemoveTime();
			range.Normalize();
			global::System.DateTime start = range.Start;
			global::System.DateTime end = range.End;
			if (start == end)
			{
				return this.ContainsDate(start);
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

		// Token: 0x06000240 RID: 576 RVA: 0x00009F98 File Offset: 0x00008198
		public void Sort()
		{
			if (base.Count > 0 && this._isSortDirty)
			{
				this.VerifySortedDates();
				this._isSortDirty = false;
				this.Reinitialize(this._sortedDates);
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00009FC4 File Offset: 0x000081C4
		protected virtual global::System.DateTime[] GetAllowedDates(global::Infragistics.DateRange dateRange)
		{
			global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>();
			dateRange.Normalize();
			dateRange.RemoveTime();
			if (!dateRange.Intersect(this._allowedRange))
			{
				return new global::System.DateTime[0];
			}
			global::System.DateTime dateTime = dateRange.Start.Date;
			global::System.DateTime date = dateRange.End.Date;
			while (dateTime <= date)
			{
				list.Add(dateTime);
				dateTime = dateTime.AddDays(1.0);
			}
			return list.ToArray();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000A045 File Offset: 0x00008245
		protected virtual void OnDatesChanged(global::System.Collections.Generic.IList<global::System.DateTime> added, global::System.Collections.Generic.IList<global::System.DateTime> removed)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000A047 File Offset: 0x00008247
		protected virtual void VerifyNewDateCount(ref int newItemCount, bool validate)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000A049 File Offset: 0x00008249
		bool global::System.Collections.Generic.ICollection<global::System.DateTime>.Contains(global::System.DateTime date)
		{
			return this.ContainsDate(date);
		}

		// Token: 0x040000B5 RID: 181
		private bool _isSortDirty;

		// Token: 0x040000B6 RID: 182
		private global::System.DateTime[] _sortedDates;

		// Token: 0x040000B7 RID: 183
		private global::Infragistics.DateRange _allowedRange = global::Infragistics.DateRange.Infinite;
	}
}
