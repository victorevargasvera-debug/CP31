using System;
using System.Text;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200039C RID: 924
	public class OldFormulaRecord : global::NPOI.HSSF.Record.OldCellRecord
	{
		// Token: 0x06001FD2 RID: 8146 RVA: 0x00061CD4 File Offset: 0x0005FED4
		public OldFormulaRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris, ris.Sid == 6)
		{
			if (this.IsBiff2)
			{
				this.field_4_value = ris.ReadDouble();
			}
			else
			{
				long num = ris.ReadLong();
				this.specialCachedValue = global::NPOI.HSSF.Record.SpecialCachedValue.Create(num);
				if (this.specialCachedValue == null)
				{
					this.field_4_value = global::System.BitConverter.Int64BitsToDouble(num);
				}
			}
			if (this.IsBiff2)
			{
				this.field_5_options = (short)ris.ReadUByte();
			}
			else
			{
				this.field_5_options = ris.ReadShort();
			}
			int encodedTokenLen = (int)ris.ReadShort();
			int totalEncodedLen = ris.Available();
			this.field_6_Parsed_expr = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen, ris, totalEncodedLen);
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00061D6D File Offset: 0x0005FF6D
		public global::NPOI.SS.UserModel.CellType GetCachedResultType()
		{
			if (this.specialCachedValue == null)
			{
				return global::NPOI.SS.UserModel.CellType.Numeric;
			}
			return this.specialCachedValue.GetValueType();
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00061D84 File Offset: 0x0005FF84
		public bool GetCachedBooleanValue()
		{
			return this.specialCachedValue.GetBooleanValue();
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00061D91 File Offset: 0x0005FF91
		public int GetCachedErrorValue()
		{
			return this.specialCachedValue.GetErrorValue();
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x00061D9E File Offset: 0x0005FF9E
		public double Value
		{
			get
			{
				return this.field_4_value;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x00061DA6 File Offset: 0x0005FFA6
		public short Options
		{
			get
			{
				return this.field_5_options;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x00061DAE File Offset: 0x0005FFAE
		public global::NPOI.SS.Formula.PTG.Ptg[] ParsedExpression
		{
			get
			{
				return this.field_6_Parsed_expr.Tokens;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x00061DBB File Offset: 0x0005FFBB
		public global::NPOI.SS.Formula.Formula Formula
		{
			get
			{
				return this.field_6_Parsed_expr;
			}
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00061DC3 File Offset: 0x0005FFC3
		protected override void AppendValueText(global::System.Text.StringBuilder sb)
		{
			sb.Append("    .value       = ").Append(this.Value).Append("\n");
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00061DE6 File Offset: 0x0005FFE6
		protected override string RecordName
		{
			get
			{
				return "Old Formula";
			}
		}

		// Token: 0x04000C4A RID: 3146
		public const short biff2_sid = 6;

		// Token: 0x04000C4B RID: 3147
		public const short biff3_sid = 518;

		// Token: 0x04000C4C RID: 3148
		public const short biff4_sid = 1030;

		// Token: 0x04000C4D RID: 3149
		public const short biff5_sid = 6;

		// Token: 0x04000C4E RID: 3150
		private global::NPOI.HSSF.Record.SpecialCachedValue specialCachedValue;

		// Token: 0x04000C4F RID: 3151
		private double field_4_value;

		// Token: 0x04000C50 RID: 3152
		private short field_5_options;

		// Token: 0x04000C51 RID: 3153
		private global::NPOI.SS.Formula.Formula field_6_Parsed_expr;
	}
}
