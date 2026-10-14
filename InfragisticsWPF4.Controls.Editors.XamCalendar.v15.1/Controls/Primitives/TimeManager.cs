using System;
using System.Collections.Generic;
using System.Windows.Threading;
using Infragistics.Collections;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000003 RID: 3
	internal class TimeManager
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000233C File Offset: 0x0000053C
		private TimeManager()
		{
			this._nextTaskTime = null;
			this._tasks = new global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Primitives.TimeManager.Task>();
			this._timer = new global::System.Windows.Threading.DispatcherTimer();
			this._timer.Tick += this.OnTimerTick;
			this._exitRanges = new global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Primitives.TimeManager.TimeRangeItem>();
			this._enterRanges = new global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Primitives.TimeManager.TimeRangeItem>();
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000023AE File Offset: 0x000005AE
		internal static global::Infragistics.Controls.Primitives.TimeManager Instance
		{
			get
			{
				if (global::Infragistics.Controls.Primitives.TimeManager._instance == null)
				{
					global::Infragistics.Controls.Primitives.TimeManager._instance = new global::Infragistics.Controls.Primitives.TimeManager();
				}
				return global::Infragistics.Controls.Primitives.TimeManager._instance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000023C6 File Offset: 0x000005C6
		private bool IsTimerNeeded
		{
			get
			{
				return this._tasks.Count > 0 || this._exitRanges.Count > 0 || this._enterRanges.Count > 0;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023FC File Offset: 0x000005FC
		public object AddTask(global::System.DateTime time, global::System.Action action)
		{
			global::Infragistics.Controls.Primitives.TimeManager.Task task = new global::Infragistics.Controls.Primitives.TimeManager.Task(time, action);
			if (this._tasks.Count == 0)
			{
				this._tasks.Add(task);
				this._nextTaskTime = new global::System.DateTime?(task.Time);
			}
			else if (this._nextTaskTime != null && this._nextTaskTime > task.Time)
			{
				this._tasks.Insert(0, task);
				this._nextTaskTime = new global::System.DateTime?(task.Time);
			}
			else
			{
				this._isNextTaskTimeSortDirty = true;
				this._tasks.Add(task);
			}
			if (!this._isInvoking)
			{
				this.StartTimer(global::Infragistics.Controls.Primitives.CurrentTime.Now);
			}
			return task;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000024BC File Offset: 0x000006BC
		public object AddTimeRange(global::Infragistics.DateRange timeRange, bool isEnterAction, global::System.Action action)
		{
			global::Infragistics.Controls.Primitives.TimeManager.TimeRangeItem timeRangeItem = new global::Infragistics.Controls.Primitives.TimeManager.TimeRangeItem(timeRange, isEnterAction, action);
			if (timeRangeItem.IsEnterAction)
			{
				if (this._enterRanges.Count == 0)
				{
					this._combinedEnterRanges = new global::Infragistics.DateRange[]
					{
						timeRangeItem.Range
					};
				}
				else
				{
					this._combinedEnterRanges = null;
				}
				this._enterRanges.Add(timeRangeItem);
			}
			else
			{
				this._exitRanges.Add(timeRangeItem);
				if (this._smallestExitRange != null)
				{
					global::Infragistics.DateRange value = this._smallestExitRange.Value;
					if (value.Intersect(timeRangeItem.Range))
					{
						this._smallestExitRange = new global::Infragistics.DateRange?(value);
					}
					else
					{
						this._smallestExitRange = null;
					}
				}
			}
			if (!this._isInvoking)
			{
				this.StartTimer(global::Infragistics.Controls.Primitives.CurrentTime.Now);
			}
			return timeRangeItem;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002582 File Offset: 0x00000782
		public void Remove(object token)
		{
			this.RemoveItem(token as global::Infragistics.Controls.Primitives.TimeManager.TimeItem);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002590 File Offset: 0x00000790
		public void SnoozeTask(object item, global::System.DateTime newTime)
		{
			global::Infragistics.Controls.Primitives.TimeManager.Task task = item as global::Infragistics.Controls.Primitives.TimeManager.Task;
			if (task != null && task.Time < newTime)
			{
				this._isNextTaskTimeSortDirty = true;
				task.Time = newTime;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000025C4 File Offset: 0x000007C4
		private void InvokeItems(global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.TimeManager.TimeItem> itemsToProcess)
		{
			bool isInvoking = this._isInvoking;
			this._isInvoking = false;
			try
			{
				foreach (global::Infragistics.Controls.Primitives.TimeManager.TimeItem timeItem in itemsToProcess)
				{
					timeItem.Invoke();
				}
			}
			finally
			{
				this._isInvoking = isInvoking;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002638 File Offset: 0x00000838
		private void InvokeRanges(global::System.DateTime now)
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.TimeManager.TimeItem> list = null;
			if (this._exitRanges.Count > 0 && (this._smallestExitRange == null || !this._smallestExitRange.Value.ContainsExclusive(now)))
			{
				this._smallestExitRange = null;
				if (list == null)
				{
					list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.TimeManager.TimeItem>();
				}
				bool flag = false;
				global::Infragistics.DateRange value = global::Infragistics.DateRange.Infinite;
				int i = 0;
				int count = this._exitRanges.Count;
				while (i < count)
				{
					global::Infragistics.Controls.Primitives.TimeManager.TimeRangeItem timeRangeItem = this._exitRanges[i];
					if (timeRangeItem != null)
					{
						global::Infragistics.DateRange range = timeRangeItem.Range;
						if (!range.ContainsExclusive(now))
						{
							this._exitRanges[i] = null;
							list.Add(timeRangeItem);
						}
						else if (!flag)
						{
							flag = true;
							value = range;
						}
						else
						{
							value.Intersect(range);
						}
					}
					i++;
				}
				if (flag)
				{
					this._smallestExitRange = new global::Infragistics.DateRange?(value);
				}
				if (this._smallestExitRange == null)
				{
					this._exitRanges.Clear();
				}
			}
			if (this._enterRanges.Count > 0 && (this._combinedEnterRanges == null || global::Infragistics.CoreUtilities.BinarySearch(this._combinedEnterRanges, now) >= 0))
			{
				global::System.Collections.Generic.List<global::Infragistics.DateRange> list2 = new global::System.Collections.Generic.List<global::Infragistics.DateRange>();
				if (list == null)
				{
					list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.TimeManager.TimeItem>();
				}
				int j = 0;
				int count2 = this._enterRanges.Count;
				while (j < count2)
				{
					global::Infragistics.Controls.Primitives.TimeManager.TimeRangeItem timeRangeItem2 = this._enterRanges[j];
					if (timeRangeItem2 != null)
					{
						global::Infragistics.DateRange range2 = timeRangeItem2.Range;
						if (range2.ContainsExclusive(now))
						{
							this._enterRanges[j] = null;
							list.Add(timeRangeItem2);
						}
						else
						{
							list2.Add(timeRangeItem2.Range);
						}
					}
					j++;
				}
				if (list2.Count == 0)
				{
					this._combinedEnterRanges = null;
					this._enterRanges.Clear();
				}
				else
				{
					this._combinedEnterRanges = global::Infragistics.DateRange.CombineRanges(new global::System.Collections.Generic.ICollection<global::Infragistics.DateRange>[]
					{
						list2
					});
				}
			}
			if (list != null)
			{
				this.InvokeItems(list);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002814 File Offset: 0x00000A14
		private bool InvokeTasks(global::System.DateTime now)
		{
			if (this._nextTaskTime == null)
			{
				return false;
			}
			if (now < this._nextTaskTime)
			{
				return false;
			}
			if (this._isNextTaskTimeSortDirty)
			{
				this.RebuildTaskList();
				if (this._nextTaskTime == null || now < this._nextTaskTime)
				{
					return true;
				}
			}
			this._nextTaskTime = null;
			global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.TimeManager.TimeItem> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.TimeManager.TimeItem>();
			int i = 0;
			int count = this._tasks.Count;
			while (i < count)
			{
				global::Infragistics.Controls.Primitives.TimeManager.Task task = this._tasks[i];
				if (task != null)
				{
					if (task.Time > now)
					{
						this._nextTaskTime = new global::System.DateTime?(task.Time);
						break;
					}
					this._tasks[i] = null;
					list.Add(task);
				}
				i++;
			}
			if (this._nextTaskTime == null)
			{
				this._tasks.Clear();
			}
			else if (count > 0)
			{
				this._tasks.RemoveRange(0, i);
			}
			this.InvokeItems(list);
			return true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002940 File Offset: 0x00000B40
		private void OnTimerTick(object sender, global::System.EventArgs e)
		{
			global::System.DateTime now = global::Infragistics.Controls.Primitives.CurrentTime.Now;
			if (this._tasks.Count > 0)
			{
				this.InvokeTasks(now);
			}
			if (this._exitRanges.Count > 0 || this._enterRanges.Count > 0)
			{
				this.InvokeRanges(now);
			}
			this.VerifyTimer(now);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002994 File Offset: 0x00000B94
		private void RebuildTaskList()
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.TimeManager.Task> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.TimeManager.Task>();
			foreach (global::Infragistics.Controls.Primitives.TimeManager.Task item in this._tasks)
			{
				list.Add(item);
			}
			this._tasks.Clear();
			if (list.Count > 0)
			{
				list.Sort();
				this._nextTaskTime = new global::System.DateTime?(list[0].Time);
				this._tasks.AddRange(list);
			}
			else
			{
				this._nextTaskTime = null;
			}
			this._isNextTaskTimeSortDirty = false;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002A3C File Offset: 0x00000C3C
		private void RemoveItem(global::Infragistics.Controls.Primitives.TimeManager.TimeItem item)
		{
			global::Infragistics.Controls.Primitives.TimeManager.Task task = item as global::Infragistics.Controls.Primitives.TimeManager.Task;
			if (task != null)
			{
				this._tasks.Remove(task);
				if (this._tasks.Count == 0)
				{
					this._nextTaskTime = null;
				}
			}
			else
			{
				global::Infragistics.Controls.Primitives.TimeManager.TimeRangeItem timeRangeItem = item as global::Infragistics.Controls.Primitives.TimeManager.TimeRangeItem;
				if (timeRangeItem != null)
				{
					if (!timeRangeItem.IsEnterAction)
					{
						this._exitRanges.Remove(timeRangeItem);
						if (this._exitRanges.Count == 0)
						{
							this._smallestExitRange = null;
						}
					}
					else
					{
						this._enterRanges.Remove(timeRangeItem);
						if (this._enterRanges.Count == 0)
						{
							this._combinedEnterRanges = null;
						}
					}
				}
			}
			if (!this._isInvoking && !this.IsTimerNeeded)
			{
				this.StopTimer();
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002AEC File Offset: 0x00000CEC
		private void StartTimer(global::System.DateTime now)
		{
			if (this._isInvoking)
			{
				return;
			}
			long num;
			if (this._nextTaskTime != null)
			{
				num = this._nextTaskTime.Value.Subtract(now).Ticks;
			}
			else
			{
				num = long.MaxValue;
			}
			if (this._exitRanges.Count > 0)
			{
				if (this._smallestExitRange == null)
				{
					num = 0L;
				}
				else
				{
					num = global::System.Math.Min(num, this._smallestExitRange.Value.End.Subtract(now).Ticks);
				}
			}
			if (num > 0L && this._enterRanges.Count > 0)
			{
				if (this._combinedEnterRanges == null)
				{
					num = 0L;
				}
				else
				{
					int num2 = global::Infragistics.CoreUtilities.BinarySearch(this._combinedEnterRanges, now);
					if (num2 >= 0)
					{
						num = 0L;
					}
					else
					{
						num2 = ~num2;
						if (num2 < this._combinedEnterRanges.Length)
						{
							num = global::System.Math.Min(num, this._combinedEnterRanges[num2].Start.Subtract(now).Ticks);
						}
						else
						{
							num = global::System.Math.Min(num, 30000000L);
						}
					}
				}
			}
			if (num > 30000000L)
			{
				num = 30000000L;
			}
			num = global::System.Math.Min(21474836470000L, global::System.Math.Max(100000L, num));
			this._timer.Interval = global::System.TimeSpan.FromTicks(num);
			if (!this._timer.IsEnabled)
			{
				this._timer.Start();
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002C62 File Offset: 0x00000E62
		private void StopTimer()
		{
			this._timer.Stop();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002C6F File Offset: 0x00000E6F
		private void VerifyTimer(global::System.DateTime now)
		{
			if (this._isInvoking)
			{
				return;
			}
			bool isTimerNeeded = this.IsTimerNeeded;
			if (this.IsTimerNeeded)
			{
				this.StartTimer(now);
				return;
			}
			this.StopTimer();
		}

		// Token: 0x04000003 RID: 3
		private const long MinTimerInterval = 100000L;

		// Token: 0x04000004 RID: 4
		private const long MaxTimerInterval = 21474836470000L;

		// Token: 0x04000005 RID: 5
		private const long SystemTimeMaxInterval = 30000000L;

		// Token: 0x04000006 RID: 6
		[global::System.ThreadStatic]
		private static global::Infragistics.Controls.Primitives.TimeManager _instance;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Threading.DispatcherTimer _timer;

		// Token: 0x04000008 RID: 8
		private global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Primitives.TimeManager.Task> _tasks;

		// Token: 0x04000009 RID: 9
		private global::System.DateTime? _nextTaskTime;

		// Token: 0x0400000A RID: 10
		private bool _isNextTaskTimeSortDirty;

		// Token: 0x0400000B RID: 11
		private global::Infragistics.DateRange? _smallestExitRange = new global::Infragistics.DateRange?(global::Infragistics.DateRange.Infinite);

		// Token: 0x0400000C RID: 12
		private global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Primitives.TimeManager.TimeRangeItem> _exitRanges;

		// Token: 0x0400000D RID: 13
		private global::Infragistics.DateRange[] _combinedEnterRanges;

		// Token: 0x0400000E RID: 14
		private global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Primitives.TimeManager.TimeRangeItem> _enterRanges;

		// Token: 0x0400000F RID: 15
		private bool _isInvoking;

		// Token: 0x02000004 RID: 4
		private class TimeItem
		{
			// Token: 0x06000017 RID: 23 RVA: 0x00002C97 File Offset: 0x00000E97
			protected TimeItem(global::System.Action action)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(action, "action");
				this._action = action;
			}

			// Token: 0x06000018 RID: 24 RVA: 0x00002CB1 File Offset: 0x00000EB1
			internal void Invoke()
			{
				this._action();
			}

			// Token: 0x04000010 RID: 16
			private global::System.Action _action;
		}

		// Token: 0x02000005 RID: 5
		private class Task : global::Infragistics.Controls.Primitives.TimeManager.TimeItem, global::System.IComparable<global::Infragistics.Controls.Primitives.TimeManager.Task>
		{
			// Token: 0x06000019 RID: 25 RVA: 0x00002CBE File Offset: 0x00000EBE
			internal Task(global::System.DateTime time, global::System.Action action) : base(action)
			{
				this.Time = time;
			}

			// Token: 0x0600001A RID: 26 RVA: 0x00002CCE File Offset: 0x00000ECE
			int global::System.IComparable<global::Infragistics.Controls.Primitives.TimeManager.Task>.CompareTo(global::Infragistics.Controls.Primitives.TimeManager.Task other)
			{
				if (other == null)
				{
					return 1;
				}
				return this.Time.CompareTo(other.Time);
			}

			// Token: 0x04000011 RID: 17
			internal global::System.DateTime Time;
		}

		// Token: 0x02000006 RID: 6
		private class TimeRangeItem : global::Infragistics.Controls.Primitives.TimeManager.TimeItem
		{
			// Token: 0x0600001B RID: 27 RVA: 0x00002CE6 File Offset: 0x00000EE6
			internal TimeRangeItem(global::Infragistics.DateRange range, bool isEnterAction, global::System.Action action) : base(action)
			{
				this.Range = range;
				this.IsEnterAction = isEnterAction;
			}

			// Token: 0x04000012 RID: 18
			internal global::Infragistics.DateRange Range;

			// Token: 0x04000013 RID: 19
			internal readonly bool IsEnterAction;
		}
	}
}
