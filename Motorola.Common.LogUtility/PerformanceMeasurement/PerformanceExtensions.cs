using System;
using System.Text.RegularExpressions;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x02000025 RID: 37
	public static class PerformanceExtensions
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00012D8C File Offset: 0x00010F8C
		public static string LogFormat(this string text)
		{
			int a_ = 13;
			short num = (short)793532592;
			short num2 = num;
			num = (short)1537628336;
			switch (num2 == num)
			{
			}
			num = (short)75366401;
			if (num != 0)
			{
			}
			num = (short)596312064;
			if (num != 0)
			{
			}
			num = (short)2064711680;
			short num3 = num;
			return global::System.Text.RegularExpressions.Regex.Replace(global::System.Text.RegularExpressions.Regex.Replace(text, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䥠㡢Ѥ䩦፨㙪䑬䝮⩰㉲塴⵶⑸剺", a_), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䕠剢䕤䍦孨", a_)), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ㅠ٢ᝤѦ౨ժᥬ๮ᙰᙲ", a_), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䑠", a_));
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00012E84 File Offset: 0x00011084
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(587882665 + A_1) + (global::System.IntPtr)97 + (global::System.IntPtr)93 + (global::System.IntPtr)90 + (global::System.IntPtr)56 + (global::System.IntPtr)90);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}
	}
}
