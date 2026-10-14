using System;

namespace NPOI.HSSF.Util
{
	// Token: 0x02000344 RID: 836
	public class RKUtil
	{
		// Token: 0x06001908 RID: 6408 RVA: 0x0004CDF4 File Offset: 0x0004AFF4
		public static double DecodeNumber(int number)
		{
			long num = (long)number;
			num >>= 2;
			double num2;
			if ((number & 2) == 2)
			{
				num2 = (double)num;
			}
			else
			{
				num2 = global::System.BitConverter.Int64BitsToDouble(num << 34);
			}
			if ((number & 1) == 1)
			{
				num2 /= 100.0;
			}
			return num2;
		}
	}
}
