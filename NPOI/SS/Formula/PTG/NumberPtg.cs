using System;
using System.Globalization;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000119 RID: 281
	public class NumberPtg : global::NPOI.SS.Formula.PTG.ScalarConstantPtg
	{
		// Token: 0x0600094B RID: 2379 RVA: 0x000189C3 File Offset: 0x00016BC3
		public NumberPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_value = in1.ReadDouble();
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000189D7 File Offset: 0x00016BD7
		public NumberPtg(string value) : this(double.Parse(value, global::System.Globalization.CultureInfo.InvariantCulture))
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000189EA File Offset: 0x00016BEA
		public NumberPtg(double value)
		{
			this.field_1_value = value;
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x000189F9 File Offset: 0x00016BF9
		public double Value
		{
			get
			{
				return this.field_1_value;
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00018A01 File Offset: 0x00016C01
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(31 + base.PtgClass));
			out1.WriteDouble(this.Value);
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00016AA5 File Offset: 0x00014CA5
		public override int Size
		{
			get
			{
				return 9;
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00018A1E File Offset: 0x00016C1E
		public override string ToFormulaString()
		{
			return global::NPOI.SS.Util.NumberToTextConverter.ToText(this.Value);
		}

		// Token: 0x040004C5 RID: 1221
		public const int SIZE = 9;

		// Token: 0x040004C6 RID: 1222
		public const byte sid = 31;

		// Token: 0x040004C7 RID: 1223
		private double field_1_value;
	}
}
