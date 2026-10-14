using System;
using System.Globalization;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200010E RID: 270
	public class IntPtg : global::NPOI.SS.Formula.PTG.ScalarConstantPtg
	{
		// Token: 0x06000902 RID: 2306 RVA: 0x0001857D File Offset: 0x0001677D
		public static bool IsInRange(int i)
		{
			return i >= 0 && i <= 65535;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00018590 File Offset: 0x00016790
		public IntPtg(global::NPOI.Util.ILittleEndianInput in1) : this(in1.ReadUShort())
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0001859E File Offset: 0x0001679E
		public IntPtg(int value)
		{
			if (!global::NPOI.SS.Formula.PTG.IntPtg.IsInRange(value))
			{
				throw new global::System.ArgumentException("value is out of range: " + value.ToString());
			}
			this.field_1_value = value;
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x000185CC File Offset: 0x000167CC
		public int Value
		{
			get
			{
				return this.field_1_value;
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000185D4 File Offset: 0x000167D4
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(30 + base.PtgClass));
			out1.WriteShort(this.Value);
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x000169FF File Offset: 0x00014BFF
		public override int Size
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000185F4 File Offset: 0x000167F4
		public override string ToFormulaString()
		{
			return this.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00018614 File Offset: 0x00016814
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.field_1_value);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x040004A2 RID: 1186
		private const int MIN_VALUE = 0;

		// Token: 0x040004A3 RID: 1187
		private const int MAX_VALUE = 65535;

		// Token: 0x040004A4 RID: 1188
		public const int SIZE = 3;

		// Token: 0x040004A5 RID: 1189
		public const byte sid = 30;

		// Token: 0x040004A6 RID: 1190
		private int field_1_value;
	}
}
