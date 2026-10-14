using System;
using System.Collections.Generic;
using Infragistics.Collections;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200020B RID: 523
	public class VisibleDataBlock
	{
		// Token: 0x06001FA7 RID: 8103 RVA: 0x00089A63 File Offset: 0x00087C63
		private VisibleDataBlock()
		{
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00089A6C File Offset: 0x00087C6C
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

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00089AF0 File Offset: 0x00087CF0
		internal static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> Create(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordPresentersInView = dp.GetRecordPresentersInView(true, false, false, true);
			return global::Infragistics.Windows.DataPresenter.VisibleDataBlock.Create(recordPresentersInView);
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00089B10 File Offset: 0x00087D10
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
							else
							{
								visibleDataBlock._fields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
							}
						}
					}
				}
				i++;
			}
			return list;
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00089C2C File Offset: 0x00087E2C
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

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x00089CA3 File Offset: 0x00087EA3
		public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> Fields
		{
			get
			{
				return this._fields;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x00089CAB File Offset: 0x00087EAB
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x00089CB3 File Offset: 0x00087EB3
		public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> Records
		{
			get
			{
				return this._records;
			}
		}

		// Token: 0x04000D51 RID: 3409
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> _records;

		// Token: 0x04000D52 RID: 3410
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _fields;

		// Token: 0x04000D53 RID: 3411
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x04000D54 RID: 3412
		private static int g_CreateCount;

		// Token: 0x0200020C RID: 524
		internal class VisibleDataBlockCache
		{
			// Token: 0x06001FB0 RID: 8112 RVA: 0x00089CBD File Offset: 0x00087EBD
			internal VisibleDataBlockCache()
			{
				this._records = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.DataRecord>();
				this._fields = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.Field>();
			}

			// Token: 0x06001FB1 RID: 8113 RVA: 0x00089CDB File Offset: 0x00087EDB
			internal void ClearLists()
			{
				this._records.Clear();
				this._fields.Clear();
			}

			// Token: 0x06001FB2 RID: 8114 RVA: 0x00089CF3 File Offset: 0x00087EF3
			internal void Initialize(global::Infragistics.Windows.DataPresenter.VisibleDataBlock block)
			{
				this.ClearLists();
				this._records.AddRange(block._records);
				this._fields.AddRange(block._fields);
			}

			// Token: 0x06001FB3 RID: 8115 RVA: 0x00089D1D File Offset: 0x00087F1D
			internal bool IsSame(global::Infragistics.Windows.DataPresenter.VisibleDataBlock block)
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.CompareLists(this._records, block._records) && global::Infragistics.Windows.DataPresenter.GridUtilities.CompareLists(this._fields, block._fields);
			}

			// Token: 0x04000D55 RID: 3413
			private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.DataRecord> _records;

			// Token: 0x04000D56 RID: 3414
			private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.Field> _fields;
		}
	}
}
