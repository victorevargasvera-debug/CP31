using System;
using System.Collections;

namespace NPOI.Util
{
	// Token: 0x02000281 RID: 641
	public class Number
	{
		// Token: 0x06001144 RID: 4420 RVA: 0x00034188 File Offset: 0x00032388
		public static int BitCount(int i)
		{
			global::System.Collections.BitArray bitArray = new global::System.Collections.BitArray(global::System.BitConverter.GetBytes(i));
			int num = 0;
			for (int j = 0; j < bitArray.Count; j++)
			{
				if (bitArray.Get(j))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x000341C4 File Offset: 0x000323C4
		public static bool IsNumber(object value)
		{
			if (value == null)
			{
				return false;
			}
			global::System.Type type = value.GetType();
			return (type.IsPrimitive || type == global::NPOI.Util.Number.DecimalType) && (type != global::NPOI.Util.Number.BoolType && type != global::NPOI.Util.Number.CharType && type != global::NPOI.Util.Number.IntPtrType) && type != global::NPOI.Util.Number.UIntPtrType;
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00034228 File Offset: 0x00032428
		public static bool IsInteger(object value)
		{
			return value != null && (value is int || value is uint || value is long || value is ulong || value is sbyte || value is byte || value is short || value is ushort);
		}

		// Token: 0x04000751 RID: 1873
		private static global::System.Type BoolType = typeof(bool);

		// Token: 0x04000752 RID: 1874
		private static global::System.Type CharType = typeof(char);

		// Token: 0x04000753 RID: 1875
		private static global::System.Type IntPtrType = typeof(global::System.IntPtr);

		// Token: 0x04000754 RID: 1876
		private static global::System.Type UIntPtrType = typeof(global::System.UIntPtr);

		// Token: 0x04000755 RID: 1877
		private static global::System.Type DecimalType = typeof(decimal);
	}
}
