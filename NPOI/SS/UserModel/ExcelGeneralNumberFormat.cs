using System;
using System.Globalization;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200003B RID: 59
	public class ExcelGeneralNumberFormat : global::NPOI.SS.Util.FormatBase
	{
		// Token: 0x06000232 RID: 562 RVA: 0x0000975C File Offset: 0x0000795C
		public ExcelGeneralNumberFormat(global::System.Globalization.CultureInfo culture)
		{
			this.decimalSymbols = culture.NumberFormat;
			this.scientificFormat = new global::NPOI.SS.Util.DecimalFormat("0.#####E0", this.decimalSymbols);
			this.integerFormat = new global::NPOI.SS.Util.DecimalFormat("#", this.decimalSymbols);
			this.decimalFormat = new global::NPOI.SS.Util.DecimalFormat("#.##########", this.decimalSymbols);
			this.culture = culture;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000097C4 File Offset: 0x000079C4
		protected override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, int pos)
		{
			return this.Format(obj, toAppendTo, this.culture);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000097D4 File Offset: 0x000079D4
		public override global::System.Text.StringBuilder Format(object number, global::System.Text.StringBuilder toAppendTo, global::System.Globalization.CultureInfo culture)
		{
			if (!global::NPOI.Util.Number.IsNumber(number))
			{
				return this.integerFormat.Format(number, toAppendTo, culture);
			}
			double num = double.Parse(number.ToString());
			if (double.IsInfinity(num) || double.IsNaN(num))
			{
				return this.integerFormat.Format(number, toAppendTo, culture);
			}
			double num2 = global::System.Math.Abs(num);
			if (num2 >= 100000000000.0 || (num2 <= 1E-10 && num2 > 0.0))
			{
				return this.scientificFormat.Format(number, toAppendTo, culture);
			}
			if (global::System.Math.Floor(num) == num || num2 >= 10000000000.0)
			{
				return this.integerFormat.Format(number, toAppendTo, culture);
			}
			int num3 = 10;
			if (global::System.Math.Abs(num) > 1.0)
			{
				int num4 = (int)global::System.Math.Log10((double)((int)global::System.Math.Abs(num))) + 1;
				num3 -= num4;
			}
			double num5 = global::System.Math.Round(num, num3, global::System.MidpointRounding.AwayFromZero);
			return this.decimalFormat.Format(num5, toAppendTo, culture);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000098C8 File Offset: 0x00007AC8
		public override object ParseObject(string source, int pos)
		{
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x040000E6 RID: 230
		private static long serialVersionUID = 1L;

		// Token: 0x040000E7 RID: 231
		private global::System.Globalization.NumberFormatInfo decimalSymbols;

		// Token: 0x040000E8 RID: 232
		private global::NPOI.SS.Util.DecimalFormat integerFormat;

		// Token: 0x040000E9 RID: 233
		private global::NPOI.SS.Util.DecimalFormat decimalFormat;

		// Token: 0x040000EA RID: 234
		private global::NPOI.SS.Util.DecimalFormat scientificFormat;

		// Token: 0x040000EB RID: 235
		private global::System.Globalization.CultureInfo culture;
	}
}
