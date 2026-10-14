using System;
using System.Collections.Generic;
using Infragistics.Collections;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E1 RID: 481
	public class VisibleDataBlock
	{
		// Token: 0x06001B8D RID: 7053 RVA: 0x00075A80 File Offset: 0x00073C80
		private VisibleDataBlock()
		{
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00075A88 File Offset: 0x00073C88
		internal static void CacheVisibleBlockInfo(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> blocks)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock.VisibleDataBlockCache> list = dp._lastVisibleDataBlocks;
			if (list == null)
			{
				list = (dp._lastVisibleDataBlocks = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock.VisibleDataBlockCache>());
			}
			int i = 0;
			int count = blocks.Count;
			while (i < count)
			{
				if (i == list.Count)
				{
					list.Add(new global::Infragistics.Windows.DataPresenter.VisibleDataBlock.VisibleDataBlockCache());
				}
				list[i].Initialize(blocks[i]);
				i++;
			}
			int j = blocks.Count;
			int count2 = list.Count;
			while (j < count2)
			{
				list[j].ClearLists();
				j++;
			}
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00075B0C File Offset: 0x00073D0C
		internal static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> Create(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordPresentersInView = dp.GetRecordPresentersInView(true, false);
			return global::Infragistics.Windows.DataPresenter.VisibleDataBlock.Create(recordPresentersInView);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00075B28 File Offset: 0x00073D28
		internal static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> Create(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordPresenters)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock>();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordManager, global::Infragistics.Windows.DataPresenter.VisibleDataBlock> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordManager, global::Infragistics.Windows.DataPresenter.VisibleDataBlock>();
			global::Infragistics.Windows.DataPresenter.VisibleDataBlock visibleDataBlock = null;
			int i = 0;
			int count = recordPresenters.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = recordPresenters[i];
				if (recordPresenter is global::Infragistics.Windows.DataPresenter.DataRecordPresenter)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = recordPresenter.Record as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord != null && dataRecord.IsDataRecord)
					{
						global::Infragistics.Windows.DataPresenter.RecordManager recordManager = dataRecord.RecordManager;
						if ((visibleDataBlock == null || visibleDataBlock._recordManager != recordManager) && !dictionary.TryGetValue(recordManager, out visibleDataBlock))
						{
							visibleDataBlock = new global::Infragistics.Windows.DataPresenter.VisibleDataBlock();
							visibleDataBlock._recordManager = recordManager;
							list.Add(visibleDataBlock);
							dictionary[recordManager] = visibleDataBlock;
						}
						if (visibleDataBlock._records == null)
						{
							visibleDataBlock._records = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
						}
						visibleDataBlock._records.Add(dataRecord);
						if (visibleDataBlock._fields == null)
						{
							global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = null;
							global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = recordPresenter as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
							if (dataRecordPresenter != null)
							{
								virtualizingDataRecordCellPanel = dataRecordPresenter.AssociatedVirtualizingDataRecordCellPanel;
							}
							if (virtualizingDataRecordCellPanel == null)
							{
								virtualizingDataRecordCellPanel = global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel>(recordPresenter, true, null);
							}
							if (virtualizingDataRecordCellPanel != null)
							{
								visibleDataBlock._fields = virtualizingDataRecordCellPanel.GetFieldsInView();
							}
						}
					}
				}
				i++;
			}
			return list;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00075C38 File Offset: 0x00073E38
		internal static void RaiseCellsInViewChanged(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> list = global::Infragistics.Windows.DataPresenter.VisibleDataBlock.Create(dp);
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock.VisibleDataBlockCache> lastVisibleDataBlocks = dp._lastVisibleDataBlocks;
			if (lastVisibleDataBlocks != null && lastVisibleDataBlocks.Count == list.Count)
			{
				bool flag = false;
				int i = 0;
				int count = lastVisibleDataBlocks.Count;
				while (i < count)
				{
					if (!lastVisibleDataBlocks[i].IsSame(list[i]))
					{
						flag = true;
						break;
					}
					i++;
				}
				if (!flag)
				{
					return;
				}
			}
			global::Infragistics.Windows.DataPresenter.VisibleDataBlock.CacheVisibleBlockInfo(dp, list);
			global::Infragistics.Windows.DataPresenter.Events.CellsInViewChangedEventArgs eventArgs = new global::Infragistics.Windows.DataPresenter.Events.CellsInViewChangedEventArgs(list);
			dp.RaiseCellsInViewChanged(eventArgs);
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x00075CAF File Offset: 0x00073EAF
		public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> Fields
		{
			get
			{
				return this._fields;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x00075CB7 File Offset: 0x00073EB7
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x00075CBF File Offset: 0x00073EBF
		public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> Records
		{
			get
			{
				return this._records;
			}
		}

		// Token: 0x04000B5F RID: 2911
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> _records;

		// Token: 0x04000B60 RID: 2912
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _fields;

		// Token: 0x04000B61 RID: 2913
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x04000B62 RID: 2914
		private static int g_CreateCount;

		// Token: 0x020001E2 RID: 482
		internal class VisibleDataBlockCache
		{
			// Token: 0x06001B96 RID: 7062 RVA: 0x00075CC9 File Offset: 0x00073EC9
			internal VisibleDataBlockCache()
			{
				this._records = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.DataRecord>();
				this._fields = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.Field>();
			}

			// Token: 0x06001B97 RID: 7063 RVA: 0x00075CE7 File Offset: 0x00073EE7
			internal void ClearLists()
			{
				this._records.Clear();
				this._fields.Clear();
			}

			// Token: 0x06001B98 RID: 7064 RVA: 0x00075CFF File Offset: 0x00073EFF
			internal void Initialize(global::Infragistics.Windows.DataPresenter.VisibleDataBlock block)
			{
				this.ClearLists();
				this._records.AddRange(block._records);
				this._fields.AddRange(block._fields);
			}

			// Token: 0x06001B99 RID: 7065 RVA: 0x00075D29 File Offset: 0x00073F29
			internal bool IsSame(global::Infragistics.Windows.DataPresenter.VisibleDataBlock block)
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.CompareLists(this._records, block._records) && global::Infragistics.Windows.DataPresenter.GridUtilities.CompareLists(this._fields, block._fields);
			}

			// Token: 0x04000B63 RID: 2915
			private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.DataRecord> _records;

			// Token: 0x04000B64 RID: 2916
			private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.Field> _fields;
		}
	}
}
