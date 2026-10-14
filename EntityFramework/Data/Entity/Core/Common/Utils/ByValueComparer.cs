using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005F2 RID: 1522
	internal class ByValueComparer : global::System.Collections.IComparer
	{
		// Token: 0x06004A9F RID: 19103 RVA: 0x00107963 File Offset: 0x00105B63
		private ByValueComparer(global::System.Collections.IComparer comparer)
		{
			this.nonByValueComparer = comparer;
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x00107974 File Offset: 0x00105B74
		int global::System.Collections.IComparer.Compare(object x, object y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x == global::System.DBNull.Value)
			{
				x = null;
			}
			if (y == global::System.DBNull.Value)
			{
				y = null;
			}
			if (x != null && y != null)
			{
				byte[] array = x as byte[];
				byte[] array2 = y as byte[];
				if (array != null && array2 != null)
				{
					int num = array.Length - array2.Length;
					if (num == 0)
					{
						int num2 = 0;
						while (num == 0 && num2 < array.Length)
						{
							byte b = array[num2];
							byte b2 = array2[num2];
							if (b != b2)
							{
								num = (int)(b - b2);
							}
							num2++;
						}
					}
					return num;
				}
			}
			return this.nonByValueComparer.Compare(x, y);
		}

		// Token: 0x04001A42 RID: 6722
		internal static readonly global::System.Collections.IComparer Default = new global::System.Data.Entity.Core.Common.Utils.ByValueComparer(global::System.Collections.Generic.Comparer<object>.Default);

		// Token: 0x04001A43 RID: 6723
		private readonly global::System.Collections.IComparer nonByValueComparer;
	}
}
