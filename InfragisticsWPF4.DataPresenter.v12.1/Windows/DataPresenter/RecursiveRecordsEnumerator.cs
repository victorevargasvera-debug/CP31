using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001CF RID: 463
	internal class RecursiveRecordsEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
	{
		// Token: 0x06001B20 RID: 6944 RVA: 0x000746F6 File Offset: 0x000728F6
		internal RecursiveRecordsEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, global::Infragistics.Windows.DataPresenter.FieldLayout lowestLevelFieldLayout, bool visibleRecordsOnly)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(records);
			this._records = records;
			this._lowestLevelFieldLayout = lowestLevelFieldLayout;
			this._visibleRecordsOnly = visibleRecordsOnly;
			this.Reset();
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0007471F File Offset: 0x0007291F
		public void Reset()
		{
			this._recordsEnumerator = new global::Infragistics.Windows.DataPresenter.RecursiveRecordsEnumerator.FlatRecordsEnumerator(this._records, this._visibleRecordsOnly);
			this._child = null;
			this._currentRecord = null;
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x00074748 File Offset: 0x00072948
		public bool MoveNext()
		{
			while (this._child == null || !this._child.MoveNext())
			{
				if (this._currentRecord == null)
				{
					goto IL_DE;
				}
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase = null;
				bool flag = false;
				if (this._lowestLevelFieldLayout == null || this._lowestLevelFieldLayout != this._currentRecord.FieldLayout || (this._currentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord && (recordCollectionBase = this._currentRecord.ChildRecordsIfNeeded) != null && this._lowestLevelFieldLayout == recordCollectionBase.FieldLayout))
				{
					flag = true;
					if (recordCollectionBase == null)
					{
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._currentRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
						if (dataRecord != null)
						{
							recordCollectionBase = dataRecord.ChildRecordsIfAllocated;
							if (recordCollectionBase == null && dataRecord.HasChildrenInternal)
							{
								recordCollectionBase = dataRecord.ChildRecordsInternal;
							}
						}
						else
						{
							recordCollectionBase = this._currentRecord.ChildRecordsIfNeeded;
						}
					}
				}
				if (!flag || recordCollectionBase == null)
				{
					goto IL_DE;
				}
				this._child = new global::Infragistics.Windows.DataPresenter.RecursiveRecordsEnumerator(recordCollectionBase, this._lowestLevelFieldLayout, this._visibleRecordsOnly);
				this._currentRecord = null;
				IL_10E:
				if (this._currentRecord != null)
				{
					goto IL_119;
				}
				continue;
				IL_DE:
				if (this._recordsEnumerator.MoveNext())
				{
					this._currentRecord = this._recordsEnumerator.Current;
					this._child = null;
					goto IL_10E;
				}
				this._currentRecord = null;
				IL_119:
				return null != this._currentRecord;
			}
			this._currentRecord = this._child.Current;
			return true;
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x0007487A File Offset: 0x00072A7A
		public global::Infragistics.Windows.DataPresenter.Record Current
		{
			get
			{
				return this._currentRecord;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x00074882 File Offset: 0x00072A82
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				return this._currentRecord;
			}
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0007488A File Offset: 0x00072A8A
		public void Dispose()
		{
		}

		// Token: 0x04000B2C RID: 2860
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _records;

		// Token: 0x04000B2D RID: 2861
		private global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> _recordsEnumerator;

		// Token: 0x04000B2E RID: 2862
		private global::Infragistics.Windows.DataPresenter.FieldLayout _lowestLevelFieldLayout;

		// Token: 0x04000B2F RID: 2863
		private global::Infragistics.Windows.DataPresenter.RecursiveRecordsEnumerator _child;

		// Token: 0x04000B30 RID: 2864
		private global::Infragistics.Windows.DataPresenter.Record _currentRecord;

		// Token: 0x04000B31 RID: 2865
		private bool _visibleRecordsOnly;

		// Token: 0x020001D0 RID: 464
		internal class Enumerable : global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.IEnumerable
		{
			// Token: 0x06001B26 RID: 6950 RVA: 0x0007488C File Offset: 0x00072A8C
			internal Enumerable(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, global::Infragistics.Windows.DataPresenter.FieldLayout lowestLevelFieldLayout, bool visibleRecordsOnly)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(records);
				this._records = records;
				this._lowestLevelFieldLayout = lowestLevelFieldLayout;
				this._visibleRecordsOnly = visibleRecordsOnly;
			}

			// Token: 0x06001B27 RID: 6951 RVA: 0x000748AF File Offset: 0x00072AAF
			public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.RecursiveRecordsEnumerator(this._records, this._lowestLevelFieldLayout, this._visibleRecordsOnly);
			}

			// Token: 0x06001B28 RID: 6952 RVA: 0x000748C8 File Offset: 0x00072AC8
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000B32 RID: 2866
			private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _records;

			// Token: 0x04000B33 RID: 2867
			private global::Infragistics.Windows.DataPresenter.FieldLayout _lowestLevelFieldLayout;

			// Token: 0x04000B34 RID: 2868
			private bool _visibleRecordsOnly;
		}

		// Token: 0x020001D1 RID: 465
		internal class FlatRecordsEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06001B29 RID: 6953 RVA: 0x000748D0 File Offset: 0x00072AD0
			internal FlatRecordsEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, bool visibleOnly)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(records);
				this._records = records;
				this._visibleOnly = visibleOnly;
				if (visibleOnly)
				{
					this._child = new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaEnumerator<global::Infragistics.Windows.DataPresenter.Record>(((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this._records).GetEnumerator(), new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_RecordVisible());
				}
				else
				{
					this._child = ((global::System.Collections.IEnumerable)this._records).GetEnumerator();
				}
				this.Reset();
			}

			// Token: 0x06001B2A RID: 6954 RVA: 0x0007492E File Offset: 0x00072B2E
			public void Reset()
			{
				this._current = null;
				this._child.Reset();
			}

			// Token: 0x06001B2B RID: 6955 RVA: 0x00074942 File Offset: 0x00072B42
			public bool MoveNext()
			{
				if (this._child.MoveNext())
				{
					this._current = (global::Infragistics.Windows.DataPresenter.Record)this._child.Current;
					return true;
				}
				this._current = null;
				return false;
			}

			// Token: 0x17000776 RID: 1910
			// (get) Token: 0x06001B2C RID: 6956 RVA: 0x00074971 File Offset: 0x00072B71
			public global::Infragistics.Windows.DataPresenter.Record Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x17000777 RID: 1911
			// (get) Token: 0x06001B2D RID: 6957 RVA: 0x00074979 File Offset: 0x00072B79
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x06001B2E RID: 6958 RVA: 0x00074981 File Offset: 0x00072B81
			public void Dispose()
			{
			}

			// Token: 0x04000B35 RID: 2869
			private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _records;

			// Token: 0x04000B36 RID: 2870
			private global::Infragistics.Windows.DataPresenter.Record _current;

			// Token: 0x04000B37 RID: 2871
			private bool _visibleOnly;

			// Token: 0x04000B38 RID: 2872
			private global::System.Collections.IEnumerator _child;
		}
	}
}
