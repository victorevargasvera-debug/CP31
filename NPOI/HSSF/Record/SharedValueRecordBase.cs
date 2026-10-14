using System;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200041E RID: 1054
	public abstract class SharedValueRecordBase : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060026AB RID: 9899 RVA: 0x000743BB File Offset: 0x000725BB
		protected SharedValueRecordBase(global::NPOI.SS.Util.CellRangeAddress8Bit range)
		{
			this._range = range;
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x000743CA File Offset: 0x000725CA
		protected SharedValueRecordBase() : this(new global::NPOI.SS.Util.CellRangeAddress8Bit(0, 0, 0, 0))
		{
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x000743DB File Offset: 0x000725DB
		public SharedValueRecordBase(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._range = new global::NPOI.SS.Util.CellRangeAddress8Bit(in1);
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x000743EF File Offset: 0x000725EF
		public global::NPOI.SS.Util.CellRangeAddress8Bit Range
		{
			get
			{
				return this._range;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x000743F7 File Offset: 0x000725F7
		public virtual int FirstRow
		{
			get
			{
				return this._range.FirstRow;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x00074404 File Offset: 0x00072604
		public virtual int LastRow
		{
			get
			{
				return this._range.LastRow;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x00074411 File Offset: 0x00072611
		public virtual int FirstColumn
		{
			get
			{
				return (int)((short)this._range.FirstColumn);
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x0007441F File Offset: 0x0007261F
		public virtual int LastColumn
		{
			get
			{
				return (int)((short)this._range.LastColumn);
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x0007442D File Offset: 0x0007262D
		protected override int DataSize
		{
			get
			{
				return 6 + this.ExtraDataSize;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060026B4 RID: 9908
		protected abstract int ExtraDataSize { get; }

		// Token: 0x060026B5 RID: 9909
		protected abstract void SerializeExtraData(global::NPOI.Util.ILittleEndianOutput out1);

		// Token: 0x060026B6 RID: 9910 RVA: 0x00074437 File Offset: 0x00072637
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			this._range.Serialize(out1);
			this.SerializeExtraData(out1);
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x0007444C File Offset: 0x0007264C
		public bool IsInRange(int rowIx, int colIx)
		{
			global::NPOI.SS.Util.CellRangeAddress8Bit range = this._range;
			return range.FirstRow <= rowIx && range.LastRow >= rowIx && range.FirstColumn <= colIx && range.LastColumn >= colIx;
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0007448C File Offset: 0x0007268C
		public bool IsFirstCell(int rowIx, int colIx)
		{
			global::NPOI.SS.Util.CellRangeAddress8Bit range = this.Range;
			return range.FirstRow == rowIx && range.FirstColumn == colIx;
		}

		// Token: 0x0400102C RID: 4140
		private global::NPOI.SS.Util.CellRangeAddress8Bit _range;
	}
}
