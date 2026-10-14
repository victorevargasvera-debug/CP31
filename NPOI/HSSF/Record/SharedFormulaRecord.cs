using System;
using System.Text;
using NPOI.SS;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200041D RID: 1053
	public class SharedFormulaRecord : global::NPOI.HSSF.Record.SharedValueRecordBase
	{
		// Token: 0x060026A1 RID: 9889 RVA: 0x000741A3 File Offset: 0x000723A3
		public SharedFormulaRecord() : this(new global::NPOI.SS.Util.CellRangeAddress8Bit(0, 0, 0, 0))
		{
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x000741B4 File Offset: 0x000723B4
		private SharedFormulaRecord(global::NPOI.SS.Util.CellRangeAddress8Bit range) : base(range)
		{
			this.field_7_parsed_expr = global::NPOI.SS.Formula.Formula.Create(global::NPOI.SS.Formula.PTG.Ptg.EMPTY_PTG_ARRAY);
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x000741D0 File Offset: 0x000723D0
		public SharedFormulaRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
			this.field_5_reserved = (int)in1.ReadShort();
			int encodedTokenLen = (int)in1.ReadShort();
			int totalEncodedLen = in1.Available();
			this.field_7_parsed_expr = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen, in1, totalEncodedLen);
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x0007420C File Offset: 0x0007240C
		protected override int ExtraDataSize
		{
			get
			{
				return 2 + this.field_7_parsed_expr.EncodedSize;
			}
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x0007421C File Offset: 0x0007241C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SHARED FORMULA (").Append(global::NPOI.Util.HexDump.IntToHex(1212)).Append("]\n");
			stringBuilder.Append("    .range      = ").Append(base.Range.ToString()).Append("\n");
			stringBuilder.Append("    .reserved    = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.field_5_reserved)).Append("\n");
			global::NPOI.SS.Formula.PTG.Ptg[] tokens = this.field_7_parsed_expr.Tokens;
			for (int i = 0; i < tokens.Length; i++)
			{
				stringBuilder.Append("Formula[").Append(i).Append("]");
				global::NPOI.SS.Formula.PTG.Ptg ptg = tokens[i];
				stringBuilder.Append(ptg.ToString()).Append(ptg.RVAType).Append("\n");
			}
			stringBuilder.Append("[/SHARED FORMULA]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x0007430E File Offset: 0x0007250E
		public override short Sid
		{
			get
			{
				return 1212;
			}
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00074315 File Offset: 0x00072515
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.SharedFormulaRecord(base.Range)
			{
				field_5_reserved = this.field_5_reserved,
				field_7_parsed_expr = this.field_7_parsed_expr.Copy()
			};
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x0007433F File Offset: 0x0007253F
		protected override void SerializeExtraData(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.field_5_reserved);
			this.field_7_parsed_expr.Serialize(out1);
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x0007435C File Offset: 0x0007255C
		public global::NPOI.SS.Formula.PTG.Ptg[] GetFormulaTokens(global::NPOI.HSSF.Record.FormulaRecord formula)
		{
			int row = formula.Row;
			int column = formula.Column;
			if (!base.IsInRange(row, column))
			{
				throw new global::System.Exception("Shared Formula Conversion: Coding Error");
			}
			return new global::NPOI.SS.Formula.PTG.SharedFormula(global::NPOI.SS.SpreadsheetVersion.EXCEL97).ConvertSharedFormulas(this.field_7_parsed_expr.Tokens, row, column);
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x000743A8 File Offset: 0x000725A8
		public bool IsFormulaSame(global::NPOI.HSSF.Record.SharedFormulaRecord other)
		{
			return this.field_7_parsed_expr.IsSame(other.field_7_parsed_expr);
		}

		// Token: 0x04001029 RID: 4137
		public const short sid = 1212;

		// Token: 0x0400102A RID: 4138
		private int field_5_reserved;

		// Token: 0x0400102B RID: 4139
		private global::NPOI.SS.Formula.Formula field_7_parsed_expr;
	}
}
