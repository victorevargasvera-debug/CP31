using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Utilities
{
	// Token: 0x02000033 RID: 51
	public abstract class BigIntegers
	{
		// Token: 0x06000270 RID: 624 RVA: 0x0000C1A4 File Offset: 0x0000A3A4
		public static byte[] AsUnsignedByteArray(global::Org.BouncyCastle.Math.BigInteger n)
		{
			return n.ToByteArrayUnsigned();
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000C1AC File Offset: 0x0000A3AC
		public static byte[] AsUnsignedByteArray(int length, global::Org.BouncyCastle.Math.BigInteger n)
		{
			byte[] bytes = n.ToByteArrayUnsigned();
			if (bytes.Length > length)
			{
				throw new global::System.ArgumentException("standard length exceeded", "n");
			}
			if (bytes.Length == length)
			{
				return bytes;
			}
			byte[] tmp = new byte[length];
			global::System.Array.Copy(bytes, 0, tmp, tmp.Length - bytes.Length, bytes.Length);
			return tmp;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		public static void AsUnsignedByteArray(global::Org.BouncyCastle.Math.BigInteger value, byte[] buf, int off, int len)
		{
			byte[] bytes = value.ToByteArrayUnsigned();
			if (bytes.Length == len)
			{
				global::System.Array.Copy(bytes, 0, buf, off, len);
				return;
			}
			int start = (bytes[0] == 0) ? 1 : 0;
			int count = bytes.Length - start;
			if (count > len)
			{
				throw new global::System.ArgumentException("standard length exceeded for value");
			}
			int padLen = len - count;
			global::Org.BouncyCastle.Utilities.Arrays.Fill(buf, off, off + padLen, 0);
			global::System.Array.Copy(bytes, start, buf, off + padLen, count);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000C257 File Offset: 0x0000A457
		public static global::Org.BouncyCastle.Math.BigInteger CreateRandomBigInteger(int bitLength, global::Org.BouncyCastle.Security.SecureRandom secureRandom)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(bitLength, secureRandom);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000C260 File Offset: 0x0000A460
		public static global::Org.BouncyCastle.Math.BigInteger CreateRandomInRange(global::Org.BouncyCastle.Math.BigInteger min, global::Org.BouncyCastle.Math.BigInteger max, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			int cmp = min.CompareTo(max);
			if (cmp >= 0)
			{
				if (cmp > 0)
				{
					throw new global::System.ArgumentException("'min' may not be greater than 'max'");
				}
				return min;
			}
			else
			{
				if (min.BitLength > max.BitLength / 2)
				{
					return global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(global::Org.BouncyCastle.Math.BigInteger.Zero, max.Subtract(min), random).Add(min);
				}
				for (int i = 0; i < 1000; i++)
				{
					global::Org.BouncyCastle.Math.BigInteger x = new global::Org.BouncyCastle.Math.BigInteger(max.BitLength, random);
					if (x.CompareTo(min) >= 0 && x.CompareTo(max) <= 0)
					{
						return x;
					}
				}
				return new global::Org.BouncyCastle.Math.BigInteger(max.Subtract(min).BitLength - 1, random).Add(min);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000C300 File Offset: 0x0000A500
		public static global::Org.BouncyCastle.Math.BigInteger ModOddInverse(global::Org.BouncyCastle.Math.BigInteger M, global::Org.BouncyCastle.Math.BigInteger X)
		{
			if (!M.TestBit(0))
			{
				throw new global::System.ArgumentException("must be odd", "M");
			}
			if (M.SignValue != 1)
			{
				throw new global::System.ArithmeticException("BigInteger: modulus not positive");
			}
			if (X.SignValue < 0 || X.CompareTo(M) >= 0)
			{
				X = X.Mod(M);
			}
			int bitLength = M.BitLength;
			uint[] i = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(bitLength, M);
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(bitLength, X);
			int len = i.Length;
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(len);
			if (global::Org.BouncyCastle.Math.Raw.Mod.ModOddInverse(i, x, z) == 0U)
			{
				throw new global::System.ArithmeticException("BigInteger not invertible");
			}
			return global::Org.BouncyCastle.Math.Raw.Nat.ToBigInteger(len, z);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000C390 File Offset: 0x0000A590
		public static global::Org.BouncyCastle.Math.BigInteger ModOddInverseVar(global::Org.BouncyCastle.Math.BigInteger M, global::Org.BouncyCastle.Math.BigInteger X)
		{
			if (!M.TestBit(0))
			{
				throw new global::System.ArgumentException("must be odd", "M");
			}
			if (M.SignValue != 1)
			{
				throw new global::System.ArithmeticException("BigInteger: modulus not positive");
			}
			if (M.Equals(global::Org.BouncyCastle.Utilities.BigIntegers.One))
			{
				return global::Org.BouncyCastle.Utilities.BigIntegers.Zero;
			}
			if (X.SignValue < 0 || X.CompareTo(M) >= 0)
			{
				X = X.Mod(M);
			}
			if (X.Equals(global::Org.BouncyCastle.Utilities.BigIntegers.One))
			{
				return global::Org.BouncyCastle.Utilities.BigIntegers.One;
			}
			int bitLength = M.BitLength;
			uint[] i = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(bitLength, M);
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(bitLength, X);
			int len = i.Length;
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(len);
			if (!global::Org.BouncyCastle.Math.Raw.Mod.ModOddInverseVar(i, x, z))
			{
				throw new global::System.ArithmeticException("BigInteger not invertible");
			}
			return global::Org.BouncyCastle.Math.Raw.Nat.ToBigInteger(len, z);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000C446 File Offset: 0x0000A646
		public static int GetUnsignedByteLength(global::Org.BouncyCastle.Math.BigInteger n)
		{
			return (n.BitLength + 7) / 8;
		}

		// Token: 0x040000ED RID: 237
		public static readonly global::Org.BouncyCastle.Math.BigInteger Zero = global::Org.BouncyCastle.Math.BigInteger.Zero;

		// Token: 0x040000EE RID: 238
		public static readonly global::Org.BouncyCastle.Math.BigInteger One = global::Org.BouncyCastle.Math.BigInteger.One;

		// Token: 0x040000EF RID: 239
		private const int MaxIterations = 1000;
	}
}
