using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Collections
{
	// Token: 0x02000027 RID: 39
	public class DateCollection : global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>, global::System.Collections.Generic.ICollection<global::System.DateTime>, global::System.Collections.Generic.IEnumerable<global::System.DateTime>, global::System.Collections.IEnumerable
	{
		// Token: 0x060001BF RID: 447 RVA: 0x000085FC File Offset: 0x000067FC
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

		// Token: 0x060001C0 RID: 448 RVA: 0x0000863C File Offset: 0x0000683C
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

		// Token: 0x060001C1 RID: 449 RVA: 0x0000869C File Offset: 0x0000689C
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

		// Token: 0x060001C2 RID: 450 RVA: 0x000086E0 File Offset: 0x000068E0
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

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00008753 File Offset: 0x00006953
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000875B File Offset: 0x0000695B
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

		// Token: 0x060001C5 RID: 453 RVA: 0x00008786 File Offset: 0x00006986
		internal int BinarySearch(global::System.DateTime date)
		{
			this.VerifySortedDates();
			return global::System.Array.BinarySearch<global::System.DateTime>(this._sortedDates, date.Date);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000087A0 File Offset: 0x000069A0
		internal bool ContainsDate(global::System.DateTime date)
		{
			return this.BinarySearch(date) >= 0;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000087B0 File Offset: 0x000069B0
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

		// Token: 0x060001C8 RID: 456 RVA: 0x0000887C File Offset: 0x00006A7C
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

		// Token: 0x060001C9 RID: 457 RVA: 0x000088F0 File Offset: 0x00006AF0
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

		// Token: 0x060001CA RID: 458 RVA: 0x000089E3 File Offset: 0x00006BE3
		private void InvalidateSortedDates()
		{
			this._isSortDirty = true;
			this._sortedDates = null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000089F4 File Offset: 0x00006BF4
		private void SyncSortedDates()
		{
			global::System.DateTime[] array = new global::System.DateTime[base.Count];
			base.CopyTo(array, 0);
			global::System.Array.Sort<global::System.DateTime>(array, global::System.Collections.Generic.Comparer<global::System.DateTime>.Default);
			this._sortedDates = array;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00008A28 File Offset: 0x00006C28
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

		// Token: 0x060001CD RID: 461 RVA: 0x00008AB4 File Offset: 0x00006CB4
		private void VerifySortedDates()
		{
			if (this._sortedDates == null)
			{
				this.SyncSortedDates();
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00008AC4 File Offset: 0x00006CC4
		public void AddRange(global::System.DateTime start, global::System.DateTime end, bool allowPartialSelection)
		{
			this.AddRange(new global::Infragistics.DateRange(start, end), allowPartialSelection);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00008AD4 File Offset: 0x00006CD4
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

		// Token: 0x060001D0 RID: 464 RVA: 0x00008BE8 File Offset: 0x00006DE8
		public new bool Contains(global::System.DateTime date)
		{
			return this.ContainsDate(date);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00008BF4 File Offset: 0x00006DF4
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

		// Token: 0x060001D2 RID: 466 RVA: 0x00008CB0 File Offset: 0x00006EB0
		public void Sort()
		{
			if (base.Count > 0 && this._isSortDirty)
			{
				this.VerifySortedDates();
				this._isSortDirty = false;
				this.Reinitialize(this._sortedDates);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00008CDC File Offset: 0x00006EDC
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

		// Token: 0x060001D4 RID: 468 RVA: 0x00008D5D File Offset: 0x00006F5D
		protected virtual void OnDatesChanged(global::System.Collections.Generic.IList<global::System.DateTime> added, global::System.Collections.Generic.IList<global::System.DateTime> removed)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00008D5F File Offset: 0x00006F5F
		protected virtual void VerifyNewDateCount(ref int newItemCount, bool validate)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00008D61 File Offset: 0x00006F61
		bool global::System.Collections.Generic.ICollection<global::System.DateTime>.Contains(global::System.DateTime date)
		{
			return this.ContainsDate(date);
		}

		// Token: 0x0400006E RID: 110
		private bool _isSortDirty;

		// Token: 0x0400006F RID: 111
		private global::System.DateTime[] _sortedDates;

		// Token: 0x04000070 RID: 112
		private global::Infragistics.DateRange _allowedRange = global::Infragistics.DateRange.Infinite;
	}
}
