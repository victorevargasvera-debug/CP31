using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001F7 RID: 503
	internal class RecursiveRecordsEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
	{
		// Token: 0x06001F37 RID: 7991 RVA: 0x00088722 File Offset: 0x00086922
		internal RecursiveRecordsEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, global::Infragistics.Windows.DataPresenter.FieldLayout lowestLevelFieldLayout, bool visibleRecordsOnly)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(records);
			this._records = records;
			this._lowestLevelFieldLayout = lowestLevelFieldLayout;
			this._visibleRecordsOnly = visibleRecordsOnly;
			this.Reset();
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x0008874B File Offset: 0x0008694B
		public void Reset()
		{
			this._recordsEnumerator = new global::Infragistics.Windows.DataPresenter.RecursiveRecordsEnumerator.FlatRecordsEnumerator(this._records, this._visibleRecordsOnly);
			this._child = null;
			this._currentRecord = null;
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00088774 File Offset: 0x00086974
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

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x000888A6 File Offset: 0x00086AA6
		public global::Infragistics.Windows.DataPresenter.Record Current
		{
			get
			{
				return this._currentRecord;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x000888AE File Offset: 0x00086AAE
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				return this._currentRecord;
			}
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x000888B6 File Offset: 0x00086AB6
		public void Dispose()
		{
		}

		// Token: 0x04000D1C RID: 3356
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _records;

		// Token: 0x04000D1D RID: 3357
		private global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> _recordsEnumerator;

		// Token: 0x04000D1E RID: 3358
		private global::Infragistics.Windows.DataPresenter.FieldLayout _lowestLevelFieldLayout;

		// Token: 0x04000D1F RID: 3359
		private global::Infragistics.Windows.DataPresenter.RecursiveRecordsEnumerator _child;

		// Token: 0x04000D20 RID: 3360
		private global::Infragistics.Windows.DataPresenter.Record _currentRecord;

		// Token: 0x04000D21 RID: 3361
		private bool _visibleRecordsOnly;

		// Token: 0x020001F8 RID: 504
		internal class Enumerable : global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.IEnumerable
		{
			// Token: 0x06001F3D RID: 7997 RVA: 0x000888B8 File Offset: 0x00086AB8
			internal Enumerable(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, global::Infragistics.Windows.DataPresenter.FieldLayout lowestLevelFieldLayout, bool visibleRecordsOnly)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(records);
				this._records = records;
				this._lowestLevelFieldLayout = lowestLevelFieldLayout;
				this._visibleRecordsOnly = visibleRecordsOnly;
			}

			// Token: 0x06001F3E RID: 7998 RVA: 0x000888DB File Offset: 0x00086ADB
			public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.RecursiveRecordsEnumerator(this._records, this._lowestLevelFieldLayout, this._visibleRecordsOnly);
			}

			// Token: 0x06001F3F RID: 7999 RVA: 0x000888F4 File Offset: 0x00086AF4
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000D22 RID: 3362
			private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _records;

			// Token: 0x04000D23 RID: 3363
			private global::Infragistics.Windows.DataPresenter.FieldLayout _lowestLevelFieldLayout;

			// Token: 0x04000D24 RID: 3364
			private bool _visibleRecordsOnly;
		}

		// Token: 0x020001F9 RID: 505
		internal class FlatRecordsEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06001F40 RID: 8000 RVA: 0x000888FC File Offset: 0x00086AFC
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

			// Token: 0x06001F41 RID: 8001 RVA: 0x0008895A File Offset: 0x00086B5A
			public void Reset()
			{
				this._current = null;
				this._child.Reset();
			}

			// Token: 0x06001F42 RID: 8002 RVA: 0x0008896E File Offset: 0x00086B6E
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

			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x06001F43 RID: 8003 RVA: 0x0008899D File Offset: 0x00086B9D
			public global::Infragistics.Windows.DataPresenter.Record Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x06001F44 RID: 8004 RVA: 0x000889A5 File Offset: 0x00086BA5
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x06001F45 RID: 8005 RVA: 0x000889AD File Offset: 0x00086BAD
			public void Dispose()
			{
			}

			// Token: 0x04000D25 RID: 3365
			private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _records;

			// Token: 0x04000D26 RID: 3366
			private global::Infragistics.Windows.DataPresenter.Record _current;

			// Token: 0x04000D27 RID: 3367
			private bool _visibleOnly;

			// Token: 0x04000D28 RID: 3368
			private global::System.Collections.IEnumerator _child;
		}
	}
}
