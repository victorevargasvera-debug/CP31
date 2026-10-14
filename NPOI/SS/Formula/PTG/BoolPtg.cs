using System;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000FF RID: 255
	public class BoolPtg : global::NPOI.SS.Formula.PTG.ScalarConstantPtg
	{
		// Token: 0x060008AC RID: 2220 RVA: 0x00017D84 File Offset: 0x00015F84
		public BoolPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_value = (in1.ReadByte() == 1);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00017D9B File Offset: 0x00015F9B
		public BoolPtg(string formulaToken)
		{
			this.field_1_value = formulaToken.Equals("TRUE");
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00017DB4 File Offset: 0x00015FB4
		public bool Value
		{
			get
			{
				return this.field_1_value;
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00017DBC File Offset: 0x00015FBC
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(29 + base.PtgClass));
			out1.WriteByte(this.field_1_value ? 1 : 0);
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int Size
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00017DDF File Offset: 0x00015FDF
		public override string ToFormulaString()
		{
			if (!this.field_1_value)
			{
				return "FALSE";
			}
			return "TRUE";
		}

		// Token: 0x04000476 RID: 1142
		public const int SIZE = 2;

		// Token: 0x04000477 RID: 1143
		public const byte sid = 29;

		// Token: 0x04000478 RID: 1144
		private bool field_1_value;
	}
}
