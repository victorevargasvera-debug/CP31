using System;
using System.Text;
using NPOI.SS.Formula.PTG;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003F3 RID: 1011
	public class LinkedDataFormulaField
	{
		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x0006DBC0 File Offset: 0x0006BDC0
		public int Size
		{
			get
			{
				return 2 + global::NPOI.SS.Formula.PTG.Ptg.GetEncodedSize(this.formulaTokens);
			}
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x0006DBD0 File Offset: 0x0006BDD0
		public int FillField(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			short num = in1.ReadShort();
			this.formulaTokens = global::NPOI.SS.Formula.PTG.Ptg.ReadTokens((int)num, in1);
			return (int)(num + 2);
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0006DBF4 File Offset: 0x0006BDF4
		public void toString(global::System.Text.StringBuilder buffer)
		{
			for (int i = 0; i < this.formulaTokens.Length; i++)
			{
				buffer.Append("Formula ").Append(i).Append("=").Append(this.formulaTokens[i].ToString()).Append("\n");
			}
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0006DC4C File Offset: 0x0006BE4C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			this.toString(stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0006DC6C File Offset: 0x0006BE6C
		public int SerializeField(int offset, byte[] data)
		{
			int size = this.Size;
			global::NPOI.Util.LittleEndian.PutShort(data, offset, (short)(size - 2));
			int num = offset + 2;
			num += global::NPOI.SS.Formula.PTG.Ptg.SerializePtgs(this.formulaTokens, data, num);
			return size;
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x0006DCA0 File Offset: 0x0006BEA0
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x0006DCB2 File Offset: 0x0006BEB2
		public global::NPOI.SS.Formula.PTG.Ptg[] FormulaTokens
		{
			get
			{
				return (global::NPOI.SS.Formula.PTG.Ptg[])this.formulaTokens.Clone();
			}
			set
			{
				this.formulaTokens = (global::NPOI.SS.Formula.PTG.Ptg[])value.Clone();
			}
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x0006DCC5 File Offset: 0x0006BEC5
		public global::NPOI.HSSF.Record.LinkedDataFormulaField Copy()
		{
			return new global::NPOI.HSSF.Record.LinkedDataFormulaField
			{
				formulaTokens = this.FormulaTokens
			};
		}

		// Token: 0x04000F55 RID: 3925
		private global::NPOI.SS.Formula.PTG.Ptg[] formulaTokens;
	}
}
