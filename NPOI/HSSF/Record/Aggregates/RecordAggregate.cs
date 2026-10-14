using System;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004D6 RID: 1238
	[global::System.Serializable]
	public abstract class RecordAggregate : global::NPOI.HSSF.Record.RecordBase
	{
		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002F10 RID: 12048 RVA: 0x0008BB6B File Offset: 0x00089D6B
		public virtual short Sid
		{
			get
			{
				throw new global::System.NotImplementedException("Should not be called");
			}
		}

		// Token: 0x06002F11 RID: 12049
		public abstract void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv);

		// Token: 0x06002F12 RID: 12050 RVA: 0x0008BB78 File Offset: 0x00089D78
		public override int Serialize(int offset, byte[] data)
		{
			global::NPOI.HSSF.Record.Aggregates.RecordAggregate.SerializingRecordVisitor serializingRecordVisitor = new global::NPOI.HSSF.Record.Aggregates.RecordAggregate.SerializingRecordVisitor(data, offset);
			this.VisitContainedRecords(serializingRecordVisitor);
			return serializingRecordVisitor.CountBytesWritten();
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x0008BB9C File Offset: 0x00089D9C
		public override int RecordSize
		{
			get
			{
				global::NPOI.HSSF.Record.Aggregates.RecordAggregate.RecordSizingVisitor recordSizingVisitor = new global::NPOI.HSSF.Record.Aggregates.RecordAggregate.RecordSizingVisitor();
				this.VisitContainedRecords(recordSizingVisitor);
				return recordSizingVisitor.TotalSize;
			}
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x0008BBBC File Offset: 0x00089DBC
		public virtual global::NPOI.HSSF.Record.Record CloneViaReserialise()
		{
			throw new global::System.NotImplementedException("Please implement it in subclass");
		}

		// Token: 0x0200061E RID: 1566
		private class SerializingRecordVisitor : global::NPOI.HSSF.Record.Aggregates.RecordVisitor
		{
			// Token: 0x060036B2 RID: 14002 RVA: 0x000A6E4C File Offset: 0x000A504C
			public SerializingRecordVisitor(byte[] data, int startOffset)
			{
				this._data = data;
				this._startOffset = startOffset;
				this._countBytesWritten = 0;
			}

			// Token: 0x060036B3 RID: 14003 RVA: 0x000A6E69 File Offset: 0x000A5069
			public int CountBytesWritten()
			{
				return this._countBytesWritten;
			}

			// Token: 0x060036B4 RID: 14004 RVA: 0x000A6E74 File Offset: 0x000A5074
			public void VisitRecord(global::NPOI.HSSF.Record.Record r)
			{
				int offset = this._startOffset + this._countBytesWritten;
				this._countBytesWritten += r.Serialize(offset, this._data);
			}

			// Token: 0x04001A9B RID: 6811
			private byte[] _data;

			// Token: 0x04001A9C RID: 6812
			private int _startOffset;

			// Token: 0x04001A9D RID: 6813
			private int _countBytesWritten;
		}

		// Token: 0x0200061F RID: 1567
		private class RecordSizingVisitor : global::NPOI.HSSF.Record.Aggregates.RecordVisitor
		{
			// Token: 0x060036B5 RID: 14005 RVA: 0x000A6EA9 File Offset: 0x000A50A9
			public RecordSizingVisitor()
			{
				this._totalSize = 0;
			}

			// Token: 0x17000E29 RID: 3625
			// (get) Token: 0x060036B6 RID: 14006 RVA: 0x000A6EB8 File Offset: 0x000A50B8
			public int TotalSize
			{
				get
				{
					return this._totalSize;
				}
			}

			// Token: 0x060036B7 RID: 14007 RVA: 0x000A6EC0 File Offset: 0x000A50C0
			public void VisitRecord(global::NPOI.HSSF.Record.Record r)
			{
				this._totalSize += r.RecordSize;
			}

			// Token: 0x04001A9E RID: 6814
			private int _totalSize;
		}
	}
}
