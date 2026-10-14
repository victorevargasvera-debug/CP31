using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000131 RID: 305
	public class BaseNumberUtils
	{
		// Token: 0x06000A02 RID: 2562 RVA: 0x00019CE4 File Offset: 0x00017EE4
		public static double ConvertToDecimal(string value, int base1, int maxNumberOfPlaces)
		{
			if (string.IsNullOrEmpty(value))
			{
				return 0.0;
			}
			long num = (long)value.Length;
			if (num > (long)maxNumberOfPlaces)
			{
				throw new global::System.ArgumentException();
			}
			double num2 = 0.0;
			long num3 = 0L;
			bool flag = true;
			foreach (char c in value.ToCharArray())
			{
				long num4;
				if ('0' <= c && c <= '9')
				{
					num4 = (long)(c - '0');
				}
				else if ('A' <= c && c <= 'Z')
				{
					num4 = (long)('\n' + (c - 'A'));
				}
				else if ('a' <= c && c <= 'z')
				{
					num4 = (long)('\n' + (c - 'a'));
				}
				else
				{
					num4 = (long)base1;
				}
				if (num4 >= (long)base1)
				{
					throw new global::System.ArgumentException("character not allowed");
				}
				if (flag)
				{
					flag = false;
					num3 = num4;
				}
				num2 = num2 * (double)base1 + (double)num4;
			}
			if (!flag && num == (long)maxNumberOfPlaces && num3 >= (long)(base1 / 2))
			{
				num2 = global::NPOI.SS.Formula.Functions.BaseNumberUtils.GetTwoComplement((double)base1, (double)maxNumberOfPlaces, num2);
				num2 *= -1.0;
			}
			return num2;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00019DE9 File Offset: 0x00017FE9
		private static double GetTwoComplement(double base1, double maxNumberOfPlaces, double decimalValue)
		{
			return global::System.Math.Pow(base1, maxNumberOfPlaces) - decimalValue;
		}
	}
}
