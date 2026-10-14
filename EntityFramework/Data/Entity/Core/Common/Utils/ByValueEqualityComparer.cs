using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005F3 RID: 1523
	internal sealed class ByValueEqualityComparer : global::System.Collections.Generic.IEqualityComparer<object>
	{
		// Token: 0x06004AA2 RID: 19106 RVA: 0x00107A09 File Offset: 0x00105C09
		private ByValueEqualityComparer()
		{
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x00107A14 File Offset: 0x00105C14
		public bool Equals(object x, object y)
		{
			if (object.Equals(x, y))
			{
				return true;
			}
			byte[] array = x as byte[];
			byte[] array2 = y as byte[];
			return array != null && array2 != null && global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.CompareBinaryValues(array, array2);
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x00107A4C File Offset: 0x00105C4C
		public int GetHashCode(object obj)
		{
			if (obj == null)
			{
				return 0;
			}
			byte[] array = obj as byte[];
			if (array != null)
			{
				return global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.ComputeBinaryHashCode(array);
			}
			return obj.GetHashCode();
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x00107A78 File Offset: 0x00105C78
		internal static int ComputeBinaryHashCode(byte[] bytes)
		{
			int num = 0;
			int i = 0;
			int num2 = global::System.Math.Min(bytes.Length, 7);
			while (i < num2)
			{
				num = (num << 5 ^ (int)bytes[i]);
				i++;
			}
			return num;
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x00107AA8 File Offset: 0x00105CA8
		internal static bool CompareBinaryValues(byte[] first, byte[] second)
		{
			if (first.Length != second.Length)
			{
				return false;
			}
			for (int i = 0; i < first.Length; i++)
			{
				if (first[i] != second[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04001A44 RID: 6724
		internal static readonly global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer Default = new global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer();
	}
}
