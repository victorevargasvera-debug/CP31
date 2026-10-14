using System;
using System.Collections.Generic;

namespace NPOI.HSSF.Util
{
	// Token: 0x0200033D RID: 829
	public class LazilyConcatenatedByteArray
	{
		// Token: 0x060018AC RID: 6316 RVA: 0x0004B6F8 File Offset: 0x000498F8
		public void Clear()
		{
			this.arrays.Clear();
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0004B705 File Offset: 0x00049905
		public void Concatenate(byte[] array)
		{
			if (array == null)
			{
				throw new global::System.ArgumentException("array cannot be null");
			}
			this.arrays.Add(array);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0004B724 File Offset: 0x00049924
		public byte[] ToArray()
		{
			if (this.arrays.Count == 0)
			{
				return null;
			}
			if (this.arrays.Count > 1)
			{
				int num = 0;
				foreach (byte[] array in this.arrays)
				{
					num += array.Length;
				}
				byte[] array2 = new byte[num];
				int num2 = 0;
				foreach (byte[] array3 in this.arrays)
				{
					global::System.Array.Copy(array3, 0, array2, num2, array3.Length);
					num2 += array3.Length;
				}
				this.arrays.Clear();
				this.arrays.Add(array2);
			}
			return this.arrays[0];
		}

		// Token: 0x040009EB RID: 2539
		private global::System.Collections.Generic.List<byte[]> arrays = new global::System.Collections.Generic.List<byte[]>(1);
	}
}
