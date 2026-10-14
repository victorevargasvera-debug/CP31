using System;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200003B RID: 59
	public class SpecialFieldsConstant
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x0001CED4 File Offset: 0x0001B0D4
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1532872299 + A_1) + (global::System.IntPtr)26 + (global::System.IntPtr)56);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
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
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}

		// Token: 0x04000152 RID: 338
		public const ushort CFS_BlockType = 4400;

		// Token: 0x04000153 RID: 339
		public const ushort CFS_BlockID = 0;

		// Token: 0x04000154 RID: 340
		public const byte CFS_PartitionID = 135;

		// Token: 0x04000155 RID: 341
		public const uint CFS_Digital_OffsetInBits = 66U;

		// Token: 0x04000156 RID: 342
		public const uint CFS_Digital_LengthInBits = 2U;

		// Token: 0x04000157 RID: 343
		public const uint CFS_DPatch_OffsetInBits = 116U;

		// Token: 0x04000158 RID: 344
		public const uint CFS_DPatch_LengthInBits = 2U;
	}
}
