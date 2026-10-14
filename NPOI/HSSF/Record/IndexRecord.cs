using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003EC RID: 1004
	public class IndexRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002435 RID: 9269 RVA: 0x0005FE49 File Offset: 0x0005E049
		public IndexRecord()
		{
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x0006D35C File Offset: 0x0006B55C
		public IndexRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_zero = in1.ReadInt();
			if (this.field_1_zero != 0)
			{
				throw new global::NPOI.Util.RecordFormatException("Expected zero for field 1 but got " + this.field_1_zero.ToString());
			}
			this.field_2_first_row = in1.ReadInt();
			this.field_3_last_row_add1 = in1.ReadInt();
			this.field_4_zero = in1.ReadInt();
			int num = in1.Remaining / 4;
			this.field_5_dbcells = new global::NPOI.Util.IntList(num);
			for (int i = 0; i < num; i++)
			{
				this.field_5_dbcells.Add(in1.ReadInt());
			}
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x0006D3F5 File Offset: 0x0006B5F5
		public void AddDbcell(int cell)
		{
			if (this.field_5_dbcells == null)
			{
				this.field_5_dbcells = new global::NPOI.Util.IntList();
			}
			this.field_5_dbcells.Add(cell);
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x0006D417 File Offset: 0x0006B617
		public void SetDbcell(int cell, int value)
		{
			this.field_5_dbcells.Set(cell, value);
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002439 RID: 9273 RVA: 0x0006D427 File Offset: 0x0006B627
		// (set) Token: 0x0600243A RID: 9274 RVA: 0x0006D42F File Offset: 0x0006B62F
		public int FirstRow
		{
			get
			{
				return this.field_2_first_row;
			}
			set
			{
				this.field_2_first_row = value;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x0006D438 File Offset: 0x0006B638
		// (set) Token: 0x0600243C RID: 9276 RVA: 0x0006D440 File Offset: 0x0006B640
		public int LastRowAdd1
		{
			get
			{
				return this.field_3_last_row_add1;
			}
			set
			{
				this.field_3_last_row_add1 = value;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x0006D449 File Offset: 0x0006B649
		public int NumDbcells
		{
			get
			{
				if (this.field_5_dbcells == null)
				{
					return 0;
				}
				return this.field_5_dbcells.Count;
			}
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x0006D460 File Offset: 0x0006B660
		public int GetDbcellAt(int cellnum)
		{
			return this.field_5_dbcells.Get(cellnum);
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0006D470 File Offset: 0x0006B670
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[INDEX]\n");
			stringBuilder.Append("    .firstrow       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FirstRow)).Append("\n");
			stringBuilder.Append("    .lastrowadd1    = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.LastRowAdd1)).Append("\n");
			for (int i = 0; i < this.NumDbcells; i++)
			{
				stringBuilder.Append("    .dbcell_" + i.ToString() + "       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.GetDbcellAt(i))).Append("\n");
			}
			stringBuilder.Append("[/INDEX]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x0006D538 File Offset: 0x0006B738
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(0);
			out1.WriteInt(this.FirstRow);
			out1.WriteInt(this.LastRowAdd1);
			out1.WriteInt(this.field_4_zero);
			for (int i = 0; i < this.NumDbcells; i++)
			{
				out1.WriteInt(this.GetDbcellAt(i));
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x0006D58E File Offset: 0x0006B78E
		protected override int DataSize
		{
			get
			{
				return 16 + this.NumDbcells * 4;
			}
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0006D59B File Offset: 0x0006B79B
		public static int GetRecordSizeForBlockCount(int blockCount)
		{
			return 20 + 4 * blockCount;
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x0006D5A3 File Offset: 0x0006B7A3
		public override short Sid
		{
			get
			{
				return 523;
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x0006D5AC File Offset: 0x0006B7AC
		public override object Clone()
		{
			global::NPOI.HSSF.Record.IndexRecord indexRecord = new global::NPOI.HSSF.Record.IndexRecord();
			indexRecord.field_1_zero = this.field_1_zero;
			indexRecord.field_2_first_row = this.field_2_first_row;
			indexRecord.field_3_last_row_add1 = this.field_3_last_row_add1;
			indexRecord.field_4_zero = this.field_4_zero;
			indexRecord.field_5_dbcells = new global::NPOI.Util.IntList();
			indexRecord.field_5_dbcells.AddAll(this.field_5_dbcells);
			return indexRecord;
		}

		// Token: 0x04000F3B RID: 3899
		public const short sid = 523;

		// Token: 0x04000F3C RID: 3900
		public int field_1_zero;

		// Token: 0x04000F3D RID: 3901
		public int field_2_first_row;

		// Token: 0x04000F3E RID: 3902
		public int field_3_last_row_add1;

		// Token: 0x04000F3F RID: 3903
		public int field_4_zero;

		// Token: 0x04000F40 RID: 3904
		public global::NPOI.Util.IntList field_5_dbcells;
	}
}
