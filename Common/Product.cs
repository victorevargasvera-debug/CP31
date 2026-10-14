using System;
using Motorola.Common.Communication.CommonUtil;

namespace Common
{
	// Token: 0x0200000E RID: 14
	public static class Product
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00003D14 File Offset: 0x00001F14
		public static bool IsVertex()
		{
			short num = (short)1125449729;
			if (num != 0)
			{
			}
			num = (short)1128286367;
			short num2 = num;
			num = (short)137185439;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1654849536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)518782976;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.CommonUtil.DFlagInfo.IsDFlagExisted(global::Motorola.Common.Communication.CommonUtil.DFlagType.DASTRO);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003DC4 File Offset: 0x00001FC4
		public static bool IsAll()
		{
			short num = (short)1196810174;
			short num2 = num;
			num = (short)1030021054;
			switch (num2 == num)
			{
			}
			num = (short)1407451136;
			short num3 = num;
			num = (short)358219777;
			if (num != 0)
			{
			}
			num = (short)2134310912;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.CommonUtil.DFlagInfo.IsDFlagExisted(global::Motorola.Common.Communication.CommonUtil.DFlagType.ALL);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003E74 File Offset: 0x00002074
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(311597333 + A_1) + (global::System.IntPtr)30 + (global::System.IntPtr)16 + (global::System.IntPtr)55 + (global::System.IntPtr)94 + (global::System.IntPtr)80);
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
