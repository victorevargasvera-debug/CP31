using System;

namespace CommonUtility
{
	// Token: 0x02000057 RID: 87
	public class VersionUtility
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x0002F26C File Offset: 0x0002D46C
		public static int Major(string Version)
		{
			short num = (short)1323827200;
			short num2 = num;
			num = (short)2080374785;
			if (num != 0)
			{
			}
			num = (short)1683320916;
			short num3 = num;
			num = (short)673345620;
			switch (num3 == num)
			{
			}
			num = (short)1650262016;
			if (num != 0)
			{
			}
			return (int)global::System.Convert.ToInt16(Version.Substring(1, 2), 10);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0002F328 File Offset: 0x0002D528
		public static int Minor(string Version)
		{
			short num = (short)321850688;
			short num2 = num;
			num = (short)328928576;
			switch (num2 == num)
			{
			}
			num = (short)489226240;
			short num3 = num;
			num = (short)418512897;
			if (num != 0)
			{
			}
			num = (short)1239875584;
			if (num != 0)
			{
			}
			return (int)global::System.Convert.ToInt16(Version.Substring(4, 2), 10);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0002F3E4 File Offset: 0x0002D5E4
		public static bool NoSignificantChange(string sourceVer, string targetVer)
		{
			while (global::CommonUtility.VersionUtility.Major(sourceVer) == global::CommonUtility.VersionUtility.Major(targetVer))
			{
				short num = (short)2132596816;
				short num2 = num;
				num = (short)1316542544;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1042087936;
					short num3 = num;
					num = (short)538181633;
					if (num != 0)
					{
					}
					num = (short)151126016;
					if (num != 0)
					{
					}
					return global::CommonUtility.VersionUtility.Minor(sourceVer) == global::CommonUtility.VersionUtility.Minor(targetVer);
				}
				}
			}
			return false;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0002F4B0 File Offset: 0x0002D6B0
		public static bool CpNoLessThanFW_Major(string CodeplugVersion, string FirmwareVersion)
		{
			short num = (short)2072604129;
			short num2 = num;
			num = (short)971861473;
			switch (num2 == num)
			{
			}
			num = (short)578224128;
			short num3 = num;
			num = (short)1279262721;
			if (num != 0)
			{
			}
			num = (short)694616064;
			if (num != 0)
			{
			}
			return global::CommonUtility.VersionUtility.Major(CodeplugVersion) >= global::CommonUtility.VersionUtility.Major(FirmwareVersion);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0002F580 File Offset: 0x0002D780
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(498716465 + A_1) + (global::System.IntPtr)33 + (global::System.IntPtr)92 + (global::System.IntPtr)7 + (global::System.IntPtr)56 + (global::System.IntPtr)67);
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
