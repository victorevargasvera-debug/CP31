using System;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000107 RID: 263
	public class ExpPtg : global::NPOI.SS.Formula.PTG.ControlPtg
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x00018175 File Offset: 0x00016375
		public ExpPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_first_row = in1.ReadShort();
			this.field_2_first_col = in1.ReadShort();
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00018195 File Offset: 0x00016395
		public ExpPtg(int firstRow, int firstCol)
		{
			this.field_1_first_row = (short)firstRow;
			this.field_2_first_col = (short)firstCol;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000181AD File Offset: 0x000163AD
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(1 + base.PtgClass));
			out1.WriteShort((int)this.field_1_first_row);
			out1.WriteShort((int)this.field_2_first_col);
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x000181D5 File Offset: 0x000163D5
		public override int Size
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x000181D8 File Offset: 0x000163D8
		public short Row
		{
			get
			{
				return this.field_1_first_row;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x000181E0 File Offset: 0x000163E0
		public short Column
		{
			get
			{
				return this.field_2_first_col;
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000181E8 File Offset: 0x000163E8
		public override string ToFormulaString()
		{
			throw new global::NPOI.Util.RecordFormatException("Coding Error: Expected ExpPtg to be Converted from Shared to Non-Shared Formula by ValueRecordsAggregate, but it wasn't");
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000181F4 File Offset: 0x000163F4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("[Array Formula or Shared Formula]\n");
			stringBuilder.Append("row = ").Append(this.Row).Append("\n");
			stringBuilder.Append("col = ").Append(this.Column).Append("\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04000491 RID: 1169
		private const int SIZE = 5;

		// Token: 0x04000492 RID: 1170
		public const byte sid = 1;

		// Token: 0x04000493 RID: 1171
		private short field_1_first_row;

		// Token: 0x04000494 RID: 1172
		private short field_2_first_col;
	}
}
