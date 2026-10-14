using System;
using System.Collections;
using System.Collections.Generic;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x02000197 RID: 407
	internal sealed class LogMessageCollection : global::System.Collections.Generic.IList<global::Gibraltar.Monitor.LogMessage>, global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.LogMessage>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.LogMessage>, global::System.Collections.IEnumerable, global::System.Collections.IList, global::System.Collections.ICollection
	{
		// Token: 0x14000065 RID: 101
		// (add) Token: 0x06001178 RID: 4472 RVA: 0x000323EC File Offset: 0x000305EC
		// (remove) Token: 0x06001179 RID: 4473 RVA: 0x00032428 File Offset: 0x00030628
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.LogMessageCollection, global::Gibraltar.Monitor.LogMessage>> CollectionChanged;

		// Token: 0x0600117A RID: 4474 RVA: 0x00032464 File Offset: 0x00030664
		internal LogMessageCollection(global::Gibraltar.Monitor.Session session)
		{
			this.m_Session = session;
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0003248C File Offset: 0x0003068C
		private void GenerateTrees()
		{
			this.m_ClassTree = new global::Gibraltar.Monitor.LogMessageTree("class", "Classes", "Log Messages by class", new global::Gibraltar.Monitor.LogMessageTree.LogMessageGroupFullNameDelegate(global::Gibraltar.Monitor.LogMessageCollection.ClassTreeFullName), new global::Gibraltar.Monitor.LogMessageTree.LogMessageGroupDelegate(global::Gibraltar.Monitor.LogMessageCollection.ClassTreeMessageGroup));
			this.m_CategoryTree = new global::Gibraltar.Monitor.LogMessageTree("category", "Categories", "Log Messages by category", new global::Gibraltar.Monitor.LogMessageTree.LogMessageGroupFullNameDelegate(global::Gibraltar.Monitor.LogMessageCollection.CategoryTreeFullName), new global::Gibraltar.Monitor.LogMessageTree.LogMessageGroupDelegate(global::Gibraltar.Monitor.LogMessageCollection.CategoryTreeMessageGroup));
			foreach (global::Gibraltar.Monitor.LogMessage logMessage in this.m_List.Values)
			{
				if (logMessage.HasMethodInfo)
				{
					this.m_ClassTree.AddMessage(logMessage);
				}
				if (!string.IsNullOrEmpty(logMessage.CategoryName))
				{
					this.m_CategoryTree.AddMessage(logMessage);
				}
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00032578 File Offset: 0x00030778
		private static string[] CategoryTreeMessageGroup(global::Gibraltar.Monitor.LogMessage message)
		{
			return message.CategoryNames;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00032580 File Offset: 0x00030780
		private static string CategoryTreeFullName(global::Gibraltar.Monitor.LogMessage message)
		{
			return message.CategoryName;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00032588 File Offset: 0x00030788
		private static string[] ClassTreeMessageGroup(global::Gibraltar.Monitor.LogMessage message)
		{
			return message.ClassNames;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00032590 File Offset: 0x00030790
		private static string ClassTreeFullName(global::Gibraltar.Monitor.LogMessage message)
		{
			return message.ClassName;
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00032598 File Offset: 0x00030798
		private void EnsureSorted()
		{
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0003259C File Offset: 0x0003079C
		private void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.LogMessageCollection, global::Gibraltar.Monitor.LogMessage> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.LogMessageCollection, global::Gibraltar.Monitor.LogMessage>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x000325C4 File Offset: 0x000307C4
		private global::Gibraltar.Monitor.MetricValueCollection OnCalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset startDateTime, global::System.DateTimeOffset endDateTime)
		{
			this.EnsureSorted();
			global::Gibraltar.Monitor.MetricValueCollection metricValueCollection = new global::Gibraltar.Monitor.MetricValueCollection("Log Messages", "The number of log messages recorded per interval.", interval, intervals, "Messages");
			global::System.DateTimeOffset dateTimeOffset = startDateTime;
			global::System.DateTimeOffset dateTimeOffset2 = this.CalculateOffset(dateTimeOffset, interval, intervals);
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].Timestamp >= startDateTime)
				{
					IL_A4:
					while (dateTimeOffset2 <= endDateTime)
					{
						int num = 0;
						while (i < this.Count && !(this[i].Timestamp >= dateTimeOffset2))
						{
							num++;
							i++;
						}
						new global::Gibraltar.Monitor.MetricValue(metricValueCollection, dateTimeOffset, (double)num);
						dateTimeOffset = dateTimeOffset2;
						dateTimeOffset2 = this.CalculateOffset(dateTimeOffset, interval, intervals);
					}
					return metricValueCollection;
				}
			}
			goto IL_A4;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00032684 File Offset: 0x00030884
		private global::System.DateTimeOffset CalculateOffset(global::System.DateTimeOffset baseline, global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals)
		{
			if (intervals == 0 && interval != global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest)
			{
				throw new global::System.ArgumentOutOfRangeException("intervals", intervals, "The number of intervals can't be zero if the interval isn't set to Shortest.");
			}
			global::System.DateTimeOffset result;
			switch (interval)
			{
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Default:
				result = this.CalculateOffset(baseline, global::Loupe.Extensibility.Data.MetricSampleInterval.Second, intervals);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest:
				result = baseline.AddMilliseconds(16.0);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Millisecond:
				result = baseline.AddMilliseconds((double)intervals);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Second:
				result = baseline.AddSeconds((double)intervals);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Minute:
				result = baseline.AddMinutes((double)intervals);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Hour:
				result = baseline.AddHours((double)intervals);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Day:
				result = baseline.AddDays((double)intervals);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Week:
				result = baseline.AddDays((double)(intervals * 7));
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Month:
				result = baseline.AddMonths(intervals);
				break;
			default:
				throw new global::System.ArgumentOutOfRangeException("interval");
			}
			return result;
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x00032784 File Offset: 0x00030984
		public global::Gibraltar.Monitor.Session Session
		{
			get
			{
				return this.m_Session;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x0003278C File Offset: 0x0003098C
		public global::Gibraltar.Monitor.LogMessageTree CategoryTree
		{
			get
			{
				if (this.m_CategoryTree == null)
				{
					this.GenerateTrees();
				}
				return this.m_CategoryTree;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x000327A8 File Offset: 0x000309A8
		public global::Gibraltar.Monitor.LogMessageTree ClassTree
		{
			get
			{
				if (this.m_ClassTree == null)
				{
					this.GenerateTrees();
				}
				return this.m_ClassTree;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x000327C4 File Offset: 0x000309C4
		public global::Gibraltar.Monitor.LogMessage First
		{
			get
			{
				this.EnsureSorted();
				return this.m_List.Values[0];
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x000327E0 File Offset: 0x000309E0
		public global::Gibraltar.Monitor.LogMessage Last
		{
			get
			{
				this.EnsureSorted();
				return this.m_List.Values[this.m_List.Count - 1];
			}
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00032814 File Offset: 0x00030A14
		public global::Gibraltar.Monitor.MetricValueCollection CalculateValues()
		{
			return this.CalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval.Second, 1, new global::System.DateTimeOffset?(this.m_Session.Summary.StartDateTime), new global::System.DateTimeOffset?(this.m_Session.Summary.EndDateTime));
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00032858 File Offset: 0x00030A58
		public global::Gibraltar.Monitor.MetricValueCollection CalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals)
		{
			return this.CalculateValues(interval, intervals, new global::System.DateTimeOffset?(this.m_Session.Summary.StartDateTime), new global::System.DateTimeOffset?(this.m_Session.Summary.EndDateTime));
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0003289C File Offset: 0x00030A9C
		public global::Gibraltar.Monitor.MetricValueCollection CalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset? startDateTime, global::System.DateTimeOffset? endDateTime)
		{
			global::System.DateTimeOffset startDateTime2 = (startDateTime == null) ? this.m_Session.Summary.StartDateTime : startDateTime.Value;
			global::System.DateTimeOffset endDateTime2 = (endDateTime == null) ? this.m_Session.Summary.EndDateTime : endDateTime.Value;
			if (intervals < 0 || (interval != global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest && intervals == 0))
			{
				throw new global::System.ArgumentOutOfRangeException("intervals", intervals, "Negative intervals are not supported for calculating values.  Specify an interval count greater than zero, except for the Shortest interval where the interval count is ignored.");
			}
			if (interval == global::Loupe.Extensibility.Data.MetricSampleInterval.Millisecond && intervals < 16)
			{
				intervals = 16;
			}
			return this.OnCalculateValues(interval, intervals, startDateTime2, endDateTime2);
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00032948 File Offset: 0x00030B48
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.LogMessage> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.LogMessage>.GetEnumerator()
		{
			this.EnsureSorted();
			return this.m_List.Values.GetEnumerator();
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00032960 File Offset: 0x00030B60
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			this.EnsureSorted();
			return this.m_List.Values.GetEnumerator();
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00032978 File Offset: 0x00030B78
		public int IndexOf(global::Gibraltar.Monitor.LogMessage item)
		{
			this.EnsureSorted();
			return this.m_List.Values.IndexOf(item);
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00032994 File Offset: 0x00030B94
		public void Insert(int index, global::Gibraltar.Monitor.LogMessage item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0003299C File Offset: 0x00030B9C
		public void Remove(object value)
		{
			this.Remove((global::Gibraltar.Monitor.LogMessage)value);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x000329AC File Offset: 0x00030BAC
		public void RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000629 RID: 1577
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				this.EnsureSorted();
				return this.m_List.Values[index];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x1700062A RID: 1578
		public global::Gibraltar.Monitor.LogMessage this[int index]
		{
			get
			{
				this.EnsureSorted();
				return this.m_List.Values[index];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x000329FC File Offset: 0x00030BFC
		public int Add(object value)
		{
			global::Gibraltar.Monitor.LogMessage item = (global::Gibraltar.Monitor.LogMessage)value;
			this.Add(item);
			return this.m_List.Values.IndexOf(item);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00032A2C File Offset: 0x00030C2C
		public bool Contains(object value)
		{
			return this.m_List.Values.Contains((global::Gibraltar.Monitor.LogMessage)value);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00032A44 File Offset: 0x00030C44
		public bool ContainsKey(long key)
		{
			return this.m_List.ContainsKey(key);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00032A54 File Offset: 0x00030C54
		public void Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00032A5C File Offset: 0x00030C5C
		public int IndexOf(object value)
		{
			this.EnsureSorted();
			return this.m_List.Values.IndexOf((global::Gibraltar.Monitor.LogMessage)value);
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00032A7C File Offset: 0x00030C7C
		public void Insert(int index, object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00032A84 File Offset: 0x00030C84
		public void Add(global::Gibraltar.Monitor.LogMessage item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A new LogMessage item must be provided to add it to the collection.");
			}
			this.m_List.Add(item.Sequence, item);
			if (!this.m_HasDetails)
			{
				this.m_HasDetails = !string.IsNullOrEmpty(item.Details);
			}
			if (!this.m_HasExceptionInfos)
			{
				this.m_HasExceptionInfos = item.HasException;
			}
			if (!this.m_HasSourceLocation)
			{
				this.m_HasSourceLocation = item.HasSourceLocation;
			}
			if (!this.m_HasMultipleUsers)
			{
				if (string.IsNullOrEmpty(this.m_ReferenceUser))
				{
					this.m_ReferenceUser = item.UserName;
				}
				else if (!string.IsNullOrEmpty(item.UserName))
				{
					this.m_HasMultipleUsers = !this.m_ReferenceUser.Equals(item.UserName, global::System.StringComparison.OrdinalIgnoreCase);
				}
			}
			if (!this.m_HasMultipleLogSystems)
			{
				if (string.IsNullOrEmpty(this.m_ReferenceLogSystem))
				{
					this.m_ReferenceLogSystem = item.LogSystem;
				}
				else if (!string.IsNullOrEmpty(item.LogSystem))
				{
					this.m_HasMultipleLogSystems = !this.m_ReferenceLogSystem.Equals(item.UserName, global::System.StringComparison.OrdinalIgnoreCase);
				}
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.LogMessageCollection, global::Gibraltar.Monitor.LogMessage>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x00032BCC File Offset: 0x00030DCC
		public bool HasDetail
		{
			get
			{
				return this.m_HasDetails;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x00032BD4 File Offset: 0x00030DD4
		public bool HasExceptionInfo
		{
			get
			{
				return this.m_HasExceptionInfos;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x00032BDC File Offset: 0x00030DDC
		public bool HasMultipleUsers
		{
			get
			{
				return this.m_HasMultipleUsers;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00032BE4 File Offset: 0x00030DE4
		public bool HasMultipleLogSystems
		{
			get
			{
				return this.m_HasMultipleLogSystems;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00032BEC File Offset: 0x00030DEC
		public bool HasSourceLocation
		{
			get
			{
				return this.m_HasSourceLocation;
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00032BF4 File Offset: 0x00030DF4
		public bool Contains(global::Gibraltar.Monitor.LogMessage item)
		{
			return this.m_List.Values.Contains(item);
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00032C08 File Offset: 0x00030E08
		public void CopyTo(global::Gibraltar.Monitor.LogMessage[] array, int arrayIndex)
		{
			this.EnsureSorted();
			this.m_List.Values.CopyTo(array, arrayIndex);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00032C24 File Offset: 0x00030E24
		public void CopyTo(global::System.Array array, int index)
		{
			this.EnsureSorted();
			global::Gibraltar.Monitor.LogMessage[] array2 = new global::Gibraltar.Monitor.LogMessage[this.m_List.Count];
			this.m_List.Values.CopyTo(array2, index);
			array2.CopyTo(array, index);
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00032C68 File Offset: 0x00030E68
		public int Count
		{
			get
			{
				return this.m_List.Count;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00032C78 File Offset: 0x00030E78
		public object SyncRoot
		{
			get
			{
				return this.m_Lock;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00032C80 File Offset: 0x00030E80
		public bool IsSynchronized
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00032C84 File Offset: 0x00030E84
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00032C88 File Offset: 0x00030E88
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00032C8C File Offset: 0x00030E8C
		public bool Remove(global::Gibraltar.Monitor.LogMessage item)
		{
			return false;
		}

		// Token: 0x040005EB RID: 1515
		private readonly global::System.Collections.Generic.SortedList<long, global::Gibraltar.Monitor.LogMessage> m_List = new global::System.Collections.Generic.SortedList<long, global::Gibraltar.Monitor.LogMessage>();

		// Token: 0x040005EC RID: 1516
		private readonly global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x040005ED RID: 1517
		private readonly object m_Lock = new object();

		// Token: 0x040005EE RID: 1518
		private global::Gibraltar.Monitor.LogMessageTree m_ClassTree;

		// Token: 0x040005EF RID: 1519
		private global::Gibraltar.Monitor.LogMessageTree m_CategoryTree;

		// Token: 0x040005F0 RID: 1520
		private bool m_HasDetails;

		// Token: 0x040005F1 RID: 1521
		private bool m_HasExceptionInfos;

		// Token: 0x040005F2 RID: 1522
		private bool m_HasMultipleUsers;

		// Token: 0x040005F3 RID: 1523
		private bool m_HasMultipleLogSystems;

		// Token: 0x040005F4 RID: 1524
		private bool m_HasSourceLocation;

		// Token: 0x040005F5 RID: 1525
		private string m_ReferenceUser;

		// Token: 0x040005F6 RID: 1526
		private string m_ReferenceLogSystem;
	}
}
