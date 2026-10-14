using System;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200012A RID: 298
	public class TblPtg : global::NPOI.SS.Formula.PTG.ControlPtg
	{
		// Token: 0x060009D3 RID: 2515 RVA: 0x000198EF File Offset: 0x00017AEF
		public TblPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_first_row = in1.ReadUShort();
			this.field_2_first_col = in1.ReadUShort();
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0001990F File Offset: 0x00017B0F
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(2 + base.PtgClass));
			out1.WriteShort(this.field_1_first_row);
			out1.WriteShort(this.field_2_first_col);
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x000181D5 File Offset: 0x000163D5
		public override int Size
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x00019937 File Offset: 0x00017B37
		public int Row
		{
			get
			{
				return this.field_1_first_row;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0001993F File Offset: 0x00017B3F
		public int Column
		{
			get
			{
				return this.field_2_first_col;
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00019947 File Offset: 0x00017B47
		public override string ToFormulaString()
		{
			throw new global::NPOI.Util.RecordFormatException("Table and Arrays are not yet supported");
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00019954 File Offset: 0x00017B54
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("[Data Table - Parent cell is an interior cell in a data table]\n");
			stringBuilder.Append("top left row = ").Append(this.Row).Append("\n");
			stringBuilder.Append("top left col = ").Append(this.Column).Append("\n");
			return stringBuilder.ToString();
		}

		// Token: 0x040004F5 RID: 1269
		private const int SIZE = 5;

		// Token: 0x040004F6 RID: 1270
		public const byte sid = 2;

		// Token: 0x040004F7 RID: 1271
		private int field_1_first_row;

		// Token: 0x040004F8 RID: 1272
		private int field_2_first_col;
	}
}
