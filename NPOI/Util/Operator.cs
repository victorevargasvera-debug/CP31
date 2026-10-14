using System;

namespace NPOI.Util
{
	// Token: 0x02000284 RID: 644
	public static class Operator
	{
		// Token: 0x06001153 RID: 4435 RVA: 0x000344EB File Offset: 0x000326EB
		public static int UnsignedRightShift(int operand, int val)
		{
			if (operand > 0)
			{
				return operand >> val;
			}
			return (int)((uint)operand >> val);
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x000344FE File Offset: 0x000326FE
		public static long UnsignedRightShift(long operand, int val)
		{
			if (operand > 0L)
			{
				return operand >> val;
			}
			return (long)((ulong)operand >> val);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00034512 File Offset: 0x00032712
		public static short UnsignedRightShift(short operand, int val)
		{
			if (operand > 0)
			{
				return (short)(operand >> val);
			}
			return (short)((ushort)operand >> val);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00034528 File Offset: 0x00032728
		public static sbyte UnsignedRightShift(sbyte operand, int val)
		{
			if (operand > 0)
			{
				return (sbyte)(operand >> val);
			}
			return (sbyte)((byte)operand >> val);
		}
	}
}
