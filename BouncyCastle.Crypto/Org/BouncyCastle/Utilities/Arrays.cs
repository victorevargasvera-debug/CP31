using System;
using System.Text;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Utilities
{
	// Token: 0x02000032 RID: 50
	public abstract class Arrays
	{
		// Token: 0x06000225 RID: 549 RVA: 0x0000B4CC File Offset: 0x000096CC
		public static bool AreAllZeroes(byte[] buf, int off, int len)
		{
			uint bits = 0U;
			for (int i = 0; i < len; i++)
			{
				bits |= (uint)buf[off + i];
			}
			return bits == 0U;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000B4F3 File Offset: 0x000096F3
		public static bool AreEqual(bool[] a, bool[] b)
		{
			return a == b || (a != null && b != null && global::Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a, b));
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000B50A File Offset: 0x0000970A
		public static bool AreEqual(char[] a, char[] b)
		{
			return a == b || (a != null && b != null && global::Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a, b));
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000B521 File Offset: 0x00009721
		public static bool AreEqual(byte[] a, byte[] b)
		{
			return a == b || (a != null && b != null && global::Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a, b));
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000B538 File Offset: 0x00009738
		public static bool AreEqual(byte[] a, int aFromIndex, int aToIndex, byte[] b, int bFromIndex, int bToIndex)
		{
			int aLength = aToIndex - aFromIndex;
			int bLength = bToIndex - bFromIndex;
			if (aLength != bLength)
			{
				return false;
			}
			for (int i = 0; i < aLength; i++)
			{
				if (a[aFromIndex + i] != b[bFromIndex + i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000B571 File Offset: 0x00009771
		[global::System.Obsolete("Use 'AreEqual' method instead")]
		public static bool AreSame(byte[] a, byte[] b)
		{
			return global::Org.BouncyCastle.Utilities.Arrays.AreEqual(a, b);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000B57C File Offset: 0x0000977C
		public static bool ConstantTimeAreEqual(byte[] a, byte[] b)
		{
			if (a == null || b == null)
			{
				return false;
			}
			if (a == b)
			{
				return true;
			}
			int len = global::System.Math.Min(a.Length, b.Length);
			int nonEqual = a.Length ^ b.Length;
			for (int i = 0; i < len; i++)
			{
				nonEqual |= (int)(a[i] ^ b[i]);
			}
			for (int j = len; j < b.Length; j++)
			{
				nonEqual |= (int)(b[j] ^ ~(int)b[j]);
			}
			return nonEqual == 0;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000B5E0 File Offset: 0x000097E0
		public static bool ConstantTimeAreEqual(int len, byte[] a, int aOff, byte[] b, int bOff)
		{
			if (a == null)
			{
				throw new global::System.ArgumentNullException("a");
			}
			if (b == null)
			{
				throw new global::System.ArgumentNullException("b");
			}
			if (len < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "len");
			}
			if (aOff > a.Length - len)
			{
				throw new global::System.IndexOutOfRangeException("'aOff' value invalid for specified length");
			}
			if (bOff > b.Length - len)
			{
				throw new global::System.IndexOutOfRangeException("'bOff' value invalid for specified length");
			}
			int d = 0;
			for (int i = 0; i < len; i++)
			{
				d |= (int)(a[aOff + i] ^ b[bOff + i]);
			}
			return d == 0;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000B665 File Offset: 0x00009865
		public static bool AreEqual(int[] a, int[] b)
		{
			return a == b || (a != null && b != null && global::Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a, b));
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000B67C File Offset: 0x0000987C
		[global::System.CLSCompliant(false)]
		public static bool AreEqual(uint[] a, uint[] b)
		{
			return a == b || (a != null && b != null && global::Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a, b));
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000B693 File Offset: 0x00009893
		public static bool AreEqual(long[] a, long[] b)
		{
			return a == b || (a != null && b != null && global::Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a, b));
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000B6AA File Offset: 0x000098AA
		[global::System.CLSCompliant(false)]
		public static bool AreEqual(ulong[] a, ulong[] b)
		{
			return a == b || (a != null && b != null && global::Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a, b));
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000B6C4 File Offset: 0x000098C4
		private static bool HaveSameContents(bool[] a, bool[] b)
		{
			int i = a.Length;
			if (i != b.Length)
			{
				return false;
			}
			while (i != 0)
			{
				i--;
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000B6F0 File Offset: 0x000098F0
		private static bool HaveSameContents(char[] a, char[] b)
		{
			int i = a.Length;
			if (i != b.Length)
			{
				return false;
			}
			while (i != 0)
			{
				i--;
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000B71C File Offset: 0x0000991C
		private static bool HaveSameContents(byte[] a, byte[] b)
		{
			int i = a.Length;
			if (i != b.Length)
			{
				return false;
			}
			while (i != 0)
			{
				i--;
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000B748 File Offset: 0x00009948
		private static bool HaveSameContents(int[] a, int[] b)
		{
			int i = a.Length;
			if (i != b.Length)
			{
				return false;
			}
			while (i != 0)
			{
				i--;
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000B774 File Offset: 0x00009974
		private static bool HaveSameContents(uint[] a, uint[] b)
		{
			int i = a.Length;
			if (i != b.Length)
			{
				return false;
			}
			while (i != 0)
			{
				i--;
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000B7A0 File Offset: 0x000099A0
		private static bool HaveSameContents(long[] a, long[] b)
		{
			int i = a.Length;
			if (i != b.Length)
			{
				return false;
			}
			while (i != 0)
			{
				i--;
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000B7CC File Offset: 0x000099CC
		private static bool HaveSameContents(ulong[] a, ulong[] b)
		{
			int i = a.Length;
			if (i != b.Length)
			{
				return false;
			}
			while (i != 0)
			{
				i--;
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000B7F8 File Offset: 0x000099F8
		public static string ToString(object[] a)
		{
			global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder("[");
			if (a.Length != 0)
			{
				sb.Append(a[0]);
				for (int index = 1; index < a.Length; index++)
				{
					sb.Append(", ").Append(a[index]);
				}
			}
			sb.Append(']');
			return sb.ToString();
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000B850 File Offset: 0x00009A50
		public static int GetHashCode(byte[] data)
		{
			if (data == null)
			{
				return 0;
			}
			int i = data.Length;
			int hc = i + 1;
			while (--i >= 0)
			{
				hc *= 257;
				hc ^= (int)data[i];
			}
			return hc;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000B884 File Offset: 0x00009A84
		public static int GetHashCode(byte[] data, int off, int len)
		{
			if (data == null)
			{
				return 0;
			}
			int i = len;
			int hc = i + 1;
			while (--i >= 0)
			{
				hc *= 257;
				hc ^= (int)data[off + i];
			}
			return hc;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		public static int GetHashCode(int[] data)
		{
			if (data == null)
			{
				return 0;
			}
			int i = data.Length;
			int hc = i + 1;
			while (--i >= 0)
			{
				hc *= 257;
				hc ^= data[i];
			}
			return hc;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000B8EC File Offset: 0x00009AEC
		[global::System.CLSCompliant(false)]
		public static int GetHashCode(ushort[] data)
		{
			if (data == null)
			{
				return 0;
			}
			int i = data.Length;
			int hc = i + 1;
			while (--i >= 0)
			{
				hc *= 257;
				hc ^= (int)data[i];
			}
			return hc;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000B920 File Offset: 0x00009B20
		public static int GetHashCode(int[] data, int off, int len)
		{
			if (data == null)
			{
				return 0;
			}
			int i = len;
			int hc = i + 1;
			while (--i >= 0)
			{
				hc *= 257;
				hc ^= data[off + i];
			}
			return hc;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000B954 File Offset: 0x00009B54
		[global::System.CLSCompliant(false)]
		public static int GetHashCode(uint[] data)
		{
			if (data == null)
			{
				return 0;
			}
			int i = data.Length;
			int hc = i + 1;
			while (--i >= 0)
			{
				hc *= 257;
				hc ^= (int)data[i];
			}
			return hc;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000B988 File Offset: 0x00009B88
		[global::System.CLSCompliant(false)]
		public static int GetHashCode(uint[] data, int off, int len)
		{
			if (data == null)
			{
				return 0;
			}
			int i = len;
			int hc = i + 1;
			while (--i >= 0)
			{
				hc *= 257;
				hc ^= (int)data[off + i];
			}
			return hc;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000B9BC File Offset: 0x00009BBC
		[global::System.CLSCompliant(false)]
		public static int GetHashCode(ulong[] data)
		{
			if (data == null)
			{
				return 0;
			}
			int i = data.Length;
			int hc = i + 1;
			while (--i >= 0)
			{
				ulong di = data[i];
				hc *= 257;
				hc ^= (int)di;
				hc *= 257;
				hc ^= (int)(di >> 32);
			}
			return hc;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000BA04 File Offset: 0x00009C04
		[global::System.CLSCompliant(false)]
		public static int GetHashCode(ulong[] data, int off, int len)
		{
			if (data == null)
			{
				return 0;
			}
			int i = len;
			int hc = i + 1;
			while (--i >= 0)
			{
				ulong di = data[off + i];
				hc *= 257;
				hc ^= (int)di;
				hc *= 257;
				hc ^= (int)(di >> 32);
			}
			return hc;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000BA4A File Offset: 0x00009C4A
		public static bool[] Clone(bool[] data)
		{
			if (data != null)
			{
				return (bool[])data.Clone();
			}
			return null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000BA5C File Offset: 0x00009C5C
		public static byte[] Clone(byte[] data)
		{
			if (data != null)
			{
				return (byte[])data.Clone();
			}
			return null;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000BA6E File Offset: 0x00009C6E
		public static short[] Clone(short[] data)
		{
			if (data != null)
			{
				return (short[])data.Clone();
			}
			return null;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000BA80 File Offset: 0x00009C80
		[global::System.CLSCompliant(false)]
		public static ushort[] Clone(ushort[] data)
		{
			if (data != null)
			{
				return (ushort[])data.Clone();
			}
			return null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000BA92 File Offset: 0x00009C92
		public static int[] Clone(int[] data)
		{
			if (data != null)
			{
				return (int[])data.Clone();
			}
			return null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000BAA4 File Offset: 0x00009CA4
		[global::System.CLSCompliant(false)]
		public static uint[] Clone(uint[] data)
		{
			if (data != null)
			{
				return (uint[])data.Clone();
			}
			return null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000BAB6 File Offset: 0x00009CB6
		public static long[] Clone(long[] data)
		{
			if (data != null)
			{
				return (long[])data.Clone();
			}
			return null;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		[global::System.CLSCompliant(false)]
		public static ulong[] Clone(ulong[] data)
		{
			if (data != null)
			{
				return (ulong[])data.Clone();
			}
			return null;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000BADA File Offset: 0x00009CDA
		public static byte[] Clone(byte[] data, byte[] existing)
		{
			if (data == null)
			{
				return null;
			}
			if (existing == null || existing.Length != data.Length)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(data);
			}
			global::System.Array.Copy(data, 0, existing, 0, existing.Length);
			return existing;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000BB00 File Offset: 0x00009D00
		[global::System.CLSCompliant(false)]
		public static ulong[] Clone(ulong[] data, ulong[] existing)
		{
			if (data == null)
			{
				return null;
			}
			if (existing == null || existing.Length != data.Length)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(data);
			}
			global::System.Array.Copy(data, 0, existing, 0, existing.Length);
			return existing;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000BB28 File Offset: 0x00009D28
		public static bool Contains(byte[] a, byte n)
		{
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] == n)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000BB4C File Offset: 0x00009D4C
		public static bool Contains(short[] a, short n)
		{
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] == n)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000BB70 File Offset: 0x00009D70
		public static bool Contains(int[] a, int n)
		{
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] == n)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000BB94 File Offset: 0x00009D94
		public static void Fill(byte[] buf, byte b)
		{
			int i = buf.Length;
			while (i > 0)
			{
				buf[--i] = b;
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000BBB4 File Offset: 0x00009DB4
		public static void Fill(byte[] buf, int from, int to, byte b)
		{
			for (int i = from; i < to; i++)
			{
				buf[i] = b;
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		public static byte[] CopyOf(byte[] data, int newLength)
		{
			byte[] tmp = new byte[newLength];
			global::System.Array.Copy(data, 0, tmp, 0, global::System.Math.Min(newLength, data.Length));
			return tmp;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000BBFC File Offset: 0x00009DFC
		public static char[] CopyOf(char[] data, int newLength)
		{
			char[] tmp = new char[newLength];
			global::System.Array.Copy(data, 0, tmp, 0, global::System.Math.Min(newLength, data.Length));
			return tmp;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000BC24 File Offset: 0x00009E24
		public static int[] CopyOf(int[] data, int newLength)
		{
			int[] tmp = new int[newLength];
			global::System.Array.Copy(data, 0, tmp, 0, global::System.Math.Min(newLength, data.Length));
			return tmp;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000BC4C File Offset: 0x00009E4C
		public static long[] CopyOf(long[] data, int newLength)
		{
			long[] tmp = new long[newLength];
			global::System.Array.Copy(data, 0, tmp, 0, global::System.Math.Min(newLength, data.Length));
			return tmp;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000BC74 File Offset: 0x00009E74
		public static global::Org.BouncyCastle.Math.BigInteger[] CopyOf(global::Org.BouncyCastle.Math.BigInteger[] data, int newLength)
		{
			global::Org.BouncyCastle.Math.BigInteger[] tmp = new global::Org.BouncyCastle.Math.BigInteger[newLength];
			global::System.Array.Copy(data, 0, tmp, 0, global::System.Math.Min(newLength, data.Length));
			return tmp;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000BC9C File Offset: 0x00009E9C
		public static byte[] CopyOfRange(byte[] data, int from, int to)
		{
			int newLength = global::Org.BouncyCastle.Utilities.Arrays.GetLength(from, to);
			byte[] tmp = new byte[newLength];
			global::System.Array.Copy(data, from, tmp, 0, global::System.Math.Min(newLength, data.Length - from));
			return tmp;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		public static int[] CopyOfRange(int[] data, int from, int to)
		{
			int newLength = global::Org.BouncyCastle.Utilities.Arrays.GetLength(from, to);
			int[] tmp = new int[newLength];
			global::System.Array.Copy(data, from, tmp, 0, global::System.Math.Min(newLength, data.Length - from));
			return tmp;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000BD04 File Offset: 0x00009F04
		public static long[] CopyOfRange(long[] data, int from, int to)
		{
			int newLength = global::Org.BouncyCastle.Utilities.Arrays.GetLength(from, to);
			long[] tmp = new long[newLength];
			global::System.Array.Copy(data, from, tmp, 0, global::System.Math.Min(newLength, data.Length - from));
			return tmp;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000BD38 File Offset: 0x00009F38
		public static global::Org.BouncyCastle.Math.BigInteger[] CopyOfRange(global::Org.BouncyCastle.Math.BigInteger[] data, int from, int to)
		{
			int newLength = global::Org.BouncyCastle.Utilities.Arrays.GetLength(from, to);
			global::Org.BouncyCastle.Math.BigInteger[] tmp = new global::Org.BouncyCastle.Math.BigInteger[newLength];
			global::System.Array.Copy(data, from, tmp, 0, global::System.Math.Min(newLength, data.Length - from));
			return tmp;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000BD69 File Offset: 0x00009F69
		private static int GetLength(int from, int to)
		{
			int num = to - from;
			if (num < 0)
			{
				throw new global::System.ArgumentException(from.ToString() + " > " + to.ToString());
			}
			return num;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000BD90 File Offset: 0x00009F90
		public static byte[] Append(byte[] a, byte b)
		{
			if (a == null)
			{
				return new byte[]
				{
					b
				};
			}
			int length = a.Length;
			byte[] result = new byte[length + 1];
			global::System.Array.Copy(a, 0, result, 0, length);
			result[length] = b;
			return result;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		public static short[] Append(short[] a, short b)
		{
			if (a == null)
			{
				return new short[]
				{
					b
				};
			}
			int length = a.Length;
			short[] result = new short[length + 1];
			global::System.Array.Copy(a, 0, result, 0, length);
			result[length] = b;
			return result;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000BE00 File Offset: 0x0000A000
		public static int[] Append(int[] a, int b)
		{
			if (a == null)
			{
				return new int[]
				{
					b
				};
			}
			int length = a.Length;
			int[] result = new int[length + 1];
			global::System.Array.Copy(a, 0, result, 0, length);
			result[length] = b;
			return result;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000BE38 File Offset: 0x0000A038
		public static byte[] Concatenate(byte[] a, byte[] b)
		{
			if (a == null)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(b);
			}
			if (b == null)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(a);
			}
			byte[] rv = new byte[a.Length + b.Length];
			global::System.Array.Copy(a, 0, rv, 0, a.Length);
			global::System.Array.Copy(b, 0, rv, a.Length, b.Length);
			return rv;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000BE84 File Offset: 0x0000A084
		[global::System.CLSCompliant(false)]
		public static ushort[] Concatenate(ushort[] a, ushort[] b)
		{
			if (a == null)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(b);
			}
			if (b == null)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(a);
			}
			ushort[] rv = new ushort[a.Length + b.Length];
			global::System.Array.Copy(a, 0, rv, 0, a.Length);
			global::System.Array.Copy(b, 0, rv, a.Length, b.Length);
			return rv;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000BED0 File Offset: 0x0000A0D0
		public static byte[] ConcatenateAll(params byte[][] vs)
		{
			byte[][] nonNull = new byte[vs.Length][];
			int count = 0;
			int totalLength = 0;
			foreach (byte[] v in vs)
			{
				if (v != null)
				{
					nonNull[count++] = v;
					totalLength += v.Length;
				}
			}
			byte[] result = new byte[totalLength];
			int pos = 0;
			for (int j = 0; j < count; j++)
			{
				byte[] v2 = nonNull[j];
				global::System.Array.Copy(v2, 0, result, pos, v2.Length);
				pos += v2.Length;
			}
			return result;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000BF50 File Offset: 0x0000A150
		public static int[] Concatenate(int[] a, int[] b)
		{
			if (a == null)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(b);
			}
			if (b == null)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(a);
			}
			int[] rv = new int[a.Length + b.Length];
			global::System.Array.Copy(a, 0, rv, 0, a.Length);
			global::System.Array.Copy(b, 0, rv, a.Length, b.Length);
			return rv;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000BF9C File Offset: 0x0000A19C
		public static byte[] Prepend(byte[] a, byte b)
		{
			if (a == null)
			{
				return new byte[]
				{
					b
				};
			}
			int length = a.Length;
			byte[] result = new byte[length + 1];
			global::System.Array.Copy(a, 0, result, 1, length);
			result[0] = b;
			return result;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000BFD4 File Offset: 0x0000A1D4
		public static short[] Prepend(short[] a, short b)
		{
			if (a == null)
			{
				return new short[]
				{
					b
				};
			}
			int length = a.Length;
			short[] result = new short[length + 1];
			global::System.Array.Copy(a, 0, result, 1, length);
			result[0] = b;
			return result;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000C00C File Offset: 0x0000A20C
		public static int[] Prepend(int[] a, int b)
		{
			if (a == null)
			{
				return new int[]
				{
					b
				};
			}
			int length = a.Length;
			int[] result = new int[length + 1];
			global::System.Array.Copy(a, 0, result, 1, length);
			result[0] = b;
			return result;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000C044 File Offset: 0x0000A244
		public static byte[] Reverse(byte[] a)
		{
			if (a == null)
			{
				return null;
			}
			int p = 0;
			int p2 = a.Length;
			byte[] result = new byte[p2];
			while (--p2 >= 0)
			{
				result[p2] = a[p++];
			}
			return result;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000C078 File Offset: 0x0000A278
		public static int[] Reverse(int[] a)
		{
			if (a == null)
			{
				return null;
			}
			int p = 0;
			int p2 = a.Length;
			int[] result = new int[p2];
			while (--p2 >= 0)
			{
				result[p2] = a[p++];
			}
			return result;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		public static byte[] ReverseInPlace(byte[] a)
		{
			if (a == null)
			{
				return null;
			}
			int p = 0;
			int p2 = a.Length - 1;
			while (p < p2)
			{
				byte t = a[p];
				byte t2 = a[p2];
				a[p++] = t2;
				a[p2--] = t;
			}
			return a;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
		public static int[] ReverseInPlace(int[] a)
		{
			if (a == null)
			{
				return null;
			}
			int p = 0;
			int p2 = a.Length - 1;
			while (p < p2)
			{
				int t = a[p];
				int t2 = a[p2];
				a[p++] = t2;
				a[p2--] = t;
			}
			return a;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000C121 File Offset: 0x0000A321
		public static void Clear(byte[] data)
		{
			if (data != null)
			{
				global::System.Array.Clear(data, 0, data.Length);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000C130 File Offset: 0x0000A330
		public static void Clear(int[] data)
		{
			if (data != null)
			{
				global::System.Array.Clear(data, 0, data.Length);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000C140 File Offset: 0x0000A340
		public static bool IsNullOrContainsNull(object[] array)
		{
			if (array == null)
			{
				return true;
			}
			int count = array.Length;
			for (int i = 0; i < count; i++)
			{
				if (array[i] == null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000C16A File Offset: 0x0000A36A
		public static bool IsNullOrEmpty(byte[] array)
		{
			return array == null || array.Length < 1;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000C177 File Offset: 0x0000A377
		public static bool IsNullOrEmpty(object[] array)
		{
			return array == null || array.Length < 1;
		}

		// Token: 0x040000EB RID: 235
		public static readonly byte[] EmptyBytes = new byte[0];

		// Token: 0x040000EC RID: 236
		public static readonly int[] EmptyInts = new int[0];
	}
}
