using System;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000432 RID: 1074
	public class TableRecord : global::NPOI.HSSF.Record.SharedValueRecordBase
	{
		// Token: 0x0600278F RID: 10127 RVA: 0x000770E8 File Offset: 0x000752E8
		public TableRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
			this.field_5_flags = in1.ReadByte();
			this.field_6_res = in1.ReadByte();
			this.field_7_rowInputRow = (int)in1.ReadShort();
			this.field_8_colInputRow = (int)in1.ReadShort();
			this.field_9_rowInputCol = (int)in1.ReadShort();
			this.field_10_colInputCol = (int)in1.ReadShort();
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x00077144 File Offset: 0x00075344
		public TableRecord(global::NPOI.SS.Util.CellRangeAddress8Bit range) : base(range)
		{
			this.field_6_res = 0;
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x00077154 File Offset: 0x00075354
		// (set) Token: 0x06002792 RID: 10130 RVA: 0x0007715C File Offset: 0x0007535C
		public int Flags
		{
			get
			{
				return this.field_5_flags;
			}
			set
			{
				this.field_5_flags = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x00077165 File Offset: 0x00075365
		// (set) Token: 0x06002794 RID: 10132 RVA: 0x0007716D File Offset: 0x0007536D
		public int RowInputRow
		{
			get
			{
				return this.field_7_rowInputRow;
			}
			set
			{
				this.field_7_rowInputRow = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x00077176 File Offset: 0x00075376
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x0007717E File Offset: 0x0007537E
		public int ColInputRow
		{
			get
			{
				return this.field_8_colInputRow;
			}
			set
			{
				this.field_8_colInputRow = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06002797 RID: 10135 RVA: 0x00077187 File Offset: 0x00075387
		// (set) Token: 0x06002798 RID: 10136 RVA: 0x0007718F File Offset: 0x0007538F
		public int RowInputCol
		{
			get
			{
				return this.field_9_rowInputCol;
			}
			set
			{
				this.field_9_rowInputCol = value;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002799 RID: 10137 RVA: 0x00077198 File Offset: 0x00075398
		// (set) Token: 0x0600279A RID: 10138 RVA: 0x000771A0 File Offset: 0x000753A0
		public int ColInputCol
		{
			get
			{
				return this.field_10_colInputCol;
			}
			set
			{
				this.field_10_colInputCol = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x000771A9 File Offset: 0x000753A9
		// (set) Token: 0x0600279C RID: 10140 RVA: 0x000771BB File Offset: 0x000753BB
		public bool IsAlwaysCalc
		{
			get
			{
				return global::NPOI.HSSF.Record.TableRecord.alwaysCalc.IsSet(this.field_5_flags);
			}
			set
			{
				this.field_5_flags = global::NPOI.HSSF.Record.TableRecord.alwaysCalc.SetBoolean(this.field_5_flags, value);
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x000771D4 File Offset: 0x000753D4
		// (set) Token: 0x0600279E RID: 10142 RVA: 0x000771E6 File Offset: 0x000753E6
		public bool IsRowOrColInpCell
		{
			get
			{
				return global::NPOI.HSSF.Record.TableRecord.rowOrColInpCell.IsSet(this.field_5_flags);
			}
			set
			{
				this.field_5_flags = global::NPOI.HSSF.Record.TableRecord.rowOrColInpCell.SetBoolean(this.field_5_flags, value);
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x000771FF File Offset: 0x000753FF
		// (set) Token: 0x060027A0 RID: 10144 RVA: 0x00077211 File Offset: 0x00075411
		public bool IsOneNotTwoVar
		{
			get
			{
				return global::NPOI.HSSF.Record.TableRecord.oneOrTwoVar.IsSet(this.field_5_flags);
			}
			set
			{
				this.field_5_flags = global::NPOI.HSSF.Record.TableRecord.oneOrTwoVar.SetBoolean(this.field_5_flags, value);
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x0007722A File Offset: 0x0007542A
		// (set) Token: 0x060027A2 RID: 10146 RVA: 0x0007723C File Offset: 0x0007543C
		public bool IsColDeleted
		{
			get
			{
				return global::NPOI.HSSF.Record.TableRecord.colDeleted.IsSet(this.field_5_flags);
			}
			set
			{
				this.field_5_flags = global::NPOI.HSSF.Record.TableRecord.colDeleted.SetBoolean(this.field_5_flags, value);
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x00077255 File Offset: 0x00075455
		// (set) Token: 0x060027A4 RID: 10148 RVA: 0x00077267 File Offset: 0x00075467
		public bool IsRowDeleted
		{
			get
			{
				return global::NPOI.HSSF.Record.TableRecord.rowDeleted.IsSet(this.field_5_flags);
			}
			set
			{
				this.field_5_flags = global::NPOI.HSSF.Record.TableRecord.rowDeleted.SetBoolean(this.field_5_flags, value);
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x00077280 File Offset: 0x00075480
		public override short Sid
		{
			get
			{
				return 566;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x00018662 File Offset: 0x00016862
		protected override int ExtraDataSize
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00077288 File Offset: 0x00075488
		protected override void SerializeExtraData(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte(this.field_5_flags);
			out1.WriteByte(this.field_6_res);
			out1.WriteShort(this.field_7_rowInputRow);
			out1.WriteShort(this.field_8_colInputRow);
			out1.WriteShort(this.field_9_rowInputCol);
			out1.WriteShort(this.field_10_colInputCol);
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x000772E0 File Offset: 0x000754E0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[TABLE]\n");
			stringBuilder.Append("    .range    = ").Append(base.Range.ToString()).Append("\n");
			stringBuilder.Append("    .flags    = ").Append(global::NPOI.Util.HexDump.ByteToHex(this.field_5_flags)).Append("\n");
			stringBuilder.Append("    .alwaysClc= ").Append(this.IsAlwaysCalc).Append("\n");
			stringBuilder.Append("    .reserved = ").Append(global::NPOI.Util.HexDump.IntToHex(this.field_6_res)).Append("\n");
			global::NPOI.SS.Util.CellReference cellReference = global::NPOI.HSSF.Record.TableRecord.cr(this.field_7_rowInputRow, this.field_8_colInputRow);
			global::NPOI.SS.Util.CellReference cellReference2 = global::NPOI.HSSF.Record.TableRecord.cr(this.field_9_rowInputCol, this.field_10_colInputCol);
			stringBuilder.Append("    .rowInput = ").Append(cellReference.FormatAsString()).Append("\n");
			stringBuilder.Append("    .colInput = ").Append(cellReference2.FormatAsString()).Append("\n");
			stringBuilder.Append("[/TABLE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00077408 File Offset: 0x00075608
		private static global::NPOI.SS.Util.CellReference cr(int rowIx, int colIxAndFlags)
		{
			int pCol = colIxAndFlags & 255;
			bool pAbsRow = (colIxAndFlags & 32768) == 0;
			bool pAbsCol = (colIxAndFlags & 16384) == 0;
			return new global::NPOI.SS.Util.CellReference(rowIx, pCol, pAbsRow, pAbsCol);
		}

		// Token: 0x040010C0 RID: 4288
		public const short sid = 566;

		// Token: 0x040010C1 RID: 4289
		private static global::NPOI.Util.BitField alwaysCalc = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040010C2 RID: 4290
		private static global::NPOI.Util.BitField calcOnOpen = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x040010C3 RID: 4291
		private static global::NPOI.Util.BitField rowOrColInpCell = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x040010C4 RID: 4292
		private static global::NPOI.Util.BitField oneOrTwoVar = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x040010C5 RID: 4293
		private static global::NPOI.Util.BitField rowDeleted = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x040010C6 RID: 4294
		private static global::NPOI.Util.BitField colDeleted = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x040010C7 RID: 4295
		private int field_5_flags;

		// Token: 0x040010C8 RID: 4296
		private int field_6_res;

		// Token: 0x040010C9 RID: 4297
		private int field_7_rowInputRow;

		// Token: 0x040010CA RID: 4298
		private int field_8_colInputRow;

		// Token: 0x040010CB RID: 4299
		private int field_9_rowInputCol;

		// Token: 0x040010CC RID: 4300
		private int field_10_colInputCol;
	}
}
