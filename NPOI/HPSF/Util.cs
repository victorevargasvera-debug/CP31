using System;
using System.Collections;

namespace NPOI.HPSF
{
	// Token: 0x02000522 RID: 1314
	public class Util
	{
		// Token: 0x0600316E RID: 12654 RVA: 0x00094CD0 File Offset: 0x00092ED0
		public static void Copy(byte[] src, int srcOffSet, int Length, byte[] dst, int dstOffSet)
		{
			for (int i = 0; i < Length; i++)
			{
				dst[dstOffSet + i] = src[srcOffSet + i];
			}
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x00094CF4 File Offset: 0x00092EF4
		public static byte[] Cat(byte[][] byteArrays)
		{
			int num = 0;
			for (int i = 0; i < byteArrays.Length; i++)
			{
				num += byteArrays[i].Length;
			}
			byte[] array = new byte[num];
			int num2 = 0;
			for (int j = 0; j < byteArrays.Length; j++)
			{
				for (int k = 0; k < byteArrays[j].Length; k++)
				{
					array[num2++] = byteArrays[j][k];
				}
			}
			return array;
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x00094D58 File Offset: 0x00092F58
		public static byte[] Copy(byte[] src, int offset, int Length)
		{
			byte[] array = new byte[Length];
			global::NPOI.HPSF.Util.Copy(src, offset, Length, array, 0);
			return array;
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x00094D77 File Offset: 0x00092F77
		public static global::System.DateTime FiletimeToDate(int high, int low)
		{
			return global::NPOI.HPSF.Util.FiletimeToDate((long)high << 32 | ((long)low & (long)((ulong)-1)));
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x00094D89 File Offset: 0x00092F89
		public static global::System.DateTime FiletimeToDate(long filetime)
		{
			return global::System.DateTime.FromFileTime(filetime);
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x00094D91 File Offset: 0x00092F91
		public static long DateToFileTime(global::System.DateTime dateTime)
		{
			return dateTime.ToFileTime();
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x00094D9A File Offset: 0x00092F9A
		public static bool AreEqual(global::System.Collections.IList c1, global::System.Collections.IList c2)
		{
			return global::NPOI.HPSF.Util.internalEquals(c1, c2);
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x00094DA4 File Offset: 0x00092FA4
		private static bool internalEquals(global::System.Collections.IList c1, global::System.Collections.IList c2)
		{
			foreach (object obj in c1)
			{
				bool flag = false;
				global::System.Collections.IEnumerator enumerator2 = c2.GetEnumerator();
				while (!flag && enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					if (obj.Equals(obj2))
					{
						flag = true;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x00094DFC File Offset: 0x00092FFC
		public static byte[] Pad4(byte[] ba)
		{
			int num = 4;
			int num2 = ba.Length % num;
			byte[] array;
			if (num2 == 0)
			{
				array = ba;
			}
			else
			{
				num2 = num - num2;
				array = new byte[ba.Length + num2];
				global::System.Array.Copy(ba, array, ba.Length);
			}
			return array;
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x00094E34 File Offset: 0x00093034
		public static char[] Pad4(char[] ca)
		{
			int num = 4;
			int num2 = ca.Length % num;
			char[] array;
			if (num2 == 0)
			{
				array = ca;
			}
			else
			{
				num2 = num - num2;
				array = new char[ca.Length + num2];
				global::System.Array.Copy(ca, array, ca.Length);
			}
			return array;
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x00094E6A File Offset: 0x0009306A
		public static char[] Pad4(string s)
		{
			return global::NPOI.HPSF.Util.Pad4(s.ToCharArray());
		}

		// Token: 0x040015AD RID: 5549
		public static readonly long EPOCH_DIFF = new global::System.DateTime(1970, 1, 1).Ticks;
	}
}
