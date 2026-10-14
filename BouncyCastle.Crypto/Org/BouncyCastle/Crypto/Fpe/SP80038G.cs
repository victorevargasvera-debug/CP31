using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Fpe
{
	// Token: 0x02000489 RID: 1161
	internal class SP80038G
	{
		// Token: 0x06002C60 RID: 11360 RVA: 0x000BFB34 File Offset: 0x000BDD34
		public static byte[] DecryptFF1(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak, byte[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkArgs(cipher, true, radix, buf, off, len);
			int u = len / 2;
			int v = len - u;
			ushort[] A = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toShort(buf, off, u);
			ushort[] B = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toShort(buf, off + u, v);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toByte(global::Org.BouncyCastle.Crypto.Fpe.SP80038G.decFF1(cipher, radix, tweak, len, u, v, A, B));
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x000BFB84 File Offset: 0x000BDD84
		public static ushort[] DecryptFF1w(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak, ushort[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkArgs(cipher, true, radix, buf, off, len);
			int u = len / 2;
			int v = len - u;
			ushort[] A = new ushort[u];
			ushort[] B = new ushort[v];
			global::System.Array.Copy(buf, off, A, 0, u);
			global::System.Array.Copy(buf, off + u, B, 0, v);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.decFF1(cipher, radix, tweak, len, u, v, A, B);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x000BFBE0 File Offset: 0x000BDDE0
		private static ushort[] decFF1(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] T, int n, int u, int v, ushort[] A, ushort[] B)
		{
			int t = T.Length;
			int b = (global::Org.BouncyCastle.Crypto.Fpe.SP80038G.Ceil(global::System.Math.Log((double)radix) * (double)v / global::Org.BouncyCastle.Crypto.Fpe.SP80038G.LOG2) + 7) / 8;
			int d = (b + 3) / 4 * 4 + 4;
			byte[] P = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateP_FF1(radix, (byte)u, n, t);
			global::Org.BouncyCastle.Math.BigInteger bigRadix = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)radix);
			global::Org.BouncyCastle.Math.BigInteger[] modUV = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateModUV(bigRadix, u, v);
			int i = u;
			for (int j = 9; j >= 0; j--)
			{
				global::Org.BouncyCastle.Math.BigInteger y = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateY_FF1(cipher, bigRadix, T, b, d, j, P, A);
				i = n - i;
				global::Org.BouncyCastle.Math.BigInteger modulus = modUV[j & 1];
				global::Org.BouncyCastle.Math.BigInteger c = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.num(bigRadix, B).Subtract(y).Mod(modulus);
				ushort[] C = B;
				B = A;
				A = C;
				global::Org.BouncyCastle.Crypto.Fpe.SP80038G.str(bigRadix, c, i, C, 0);
			}
			return global::Org.BouncyCastle.Utilities.Arrays.Concatenate(A, B);
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x000BFCAA File Offset: 0x000BDEAA
		public static byte[] DecryptFF3(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkArgs(cipher, false, radix, buf, off, len);
			if (tweak64.Length != 8)
			{
				throw new global::System.ArgumentException();
			}
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.implDecryptFF3(cipher, radix, tweak64, buf, off, len);
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x000BFCD4 File Offset: 0x000BDED4
		public static byte[] DecryptFF3_1(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak56, byte[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkArgs(cipher, false, radix, buf, off, len);
			if (tweak56.Length != 7)
			{
				throw new global::System.ArgumentException("tweak should be 56 bits");
			}
			byte[] tweak57 = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateTweak64_FF3_1(tweak56);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.implDecryptFF3(cipher, radix, tweak57, buf, off, len);
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x000BFD14 File Offset: 0x000BDF14
		public static ushort[] DecryptFF3_1w(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak56, ushort[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkArgs(cipher, false, radix, buf, off, len);
			if (tweak56.Length != 7)
			{
				throw new global::System.ArgumentException("tweak should be 56 bits");
			}
			byte[] tweak57 = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateTweak64_FF3_1(tweak56);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.implDecryptFF3w(cipher, radix, tweak57, buf, off, len);
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000BFD54 File Offset: 0x000BDF54
		public static byte[] EncryptFF1(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak, byte[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkArgs(cipher, true, radix, buf, off, len);
			int u = len / 2;
			int v = len - u;
			ushort[] A = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toShort(buf, off, u);
			ushort[] B = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toShort(buf, off + u, v);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toByte(global::Org.BouncyCastle.Crypto.Fpe.SP80038G.encFF1(cipher, radix, tweak, len, u, v, A, B));
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x000BFDA4 File Offset: 0x000BDFA4
		public static ushort[] EncryptFF1w(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak, ushort[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkArgs(cipher, true, radix, buf, off, len);
			int u = len / 2;
			int v = len - u;
			ushort[] A = new ushort[u];
			ushort[] B = new ushort[v];
			global::System.Array.Copy(buf, off, A, 0, u);
			global::System.Array.Copy(buf, off + u, B, 0, v);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.encFF1(cipher, radix, tweak, len, u, v, A, B);
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x000BFE00 File Offset: 0x000BE000
		private static ushort[] encFF1(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] T, int n, int u, int v, ushort[] A, ushort[] B)
		{
			int t = T.Length;
			int b = (global::Org.BouncyCastle.Crypto.Fpe.SP80038G.Ceil(global::System.Math.Log((double)radix) * (double)v / global::Org.BouncyCastle.Crypto.Fpe.SP80038G.LOG2) + 7) / 8;
			int d = (b + 3) / 4 * 4 + 4;
			byte[] P = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateP_FF1(radix, (byte)u, n, t);
			global::Org.BouncyCastle.Math.BigInteger bigRadix = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)radix);
			global::Org.BouncyCastle.Math.BigInteger[] modUV = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateModUV(bigRadix, u, v);
			int i = v;
			for (int j = 0; j < 10; j++)
			{
				global::Org.BouncyCastle.Math.BigInteger y = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateY_FF1(cipher, bigRadix, T, b, d, j, P, B);
				i = n - i;
				global::Org.BouncyCastle.Math.BigInteger modulus = modUV[j & 1];
				global::Org.BouncyCastle.Math.BigInteger c = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.num(bigRadix, A).Add(y).Mod(modulus);
				ushort[] C = A;
				A = B;
				B = C;
				global::Org.BouncyCastle.Crypto.Fpe.SP80038G.str(bigRadix, c, i, C, 0);
			}
			return global::Org.BouncyCastle.Utilities.Arrays.Concatenate(A, B);
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x000BFECA File Offset: 0x000BE0CA
		public static byte[] EncryptFF3(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkArgs(cipher, false, radix, buf, off, len);
			if (tweak64.Length != 8)
			{
				throw new global::System.ArgumentException();
			}
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.implEncryptFF3(cipher, radix, tweak64, buf, off, len);
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x000BFEF2 File Offset: 0x000BE0F2
		public static ushort[] EncryptFF3w(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak64, ushort[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkArgs(cipher, false, radix, buf, off, len);
			if (tweak64.Length != 8)
			{
				throw new global::System.ArgumentException();
			}
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.implEncryptFF3w(cipher, radix, tweak64, buf, off, len);
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x000BFF1C File Offset: 0x000BE11C
		public static ushort[] EncryptFF3_1w(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak56, ushort[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkArgs(cipher, false, radix, buf, off, len);
			if (tweak56.Length != 7)
			{
				throw new global::System.ArgumentException("tweak should be 56 bits");
			}
			byte[] tweak57 = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateTweak64_FF3_1(tweak56);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.EncryptFF3w(cipher, radix, tweak57, buf, off, len);
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x000BFF5C File Offset: 0x000BE15C
		public static byte[] EncryptFF3_1(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak56, byte[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkArgs(cipher, false, radix, buf, off, len);
			if (tweak56.Length != 7)
			{
				throw new global::System.ArgumentException("tweak should be 56 bits");
			}
			byte[] tweak57 = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateTweak64_FF3_1(tweak56);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.EncryptFF3(cipher, radix, tweak57, buf, off, len);
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x000BFF9C File Offset: 0x000BE19C
		protected static global::Org.BouncyCastle.Math.BigInteger[] calculateModUV(global::Org.BouncyCastle.Math.BigInteger bigRadix, int u, int v)
		{
			global::Org.BouncyCastle.Math.BigInteger[] modUV = new global::Org.BouncyCastle.Math.BigInteger[2];
			modUV[0] = bigRadix.Pow(u);
			modUV[1] = modUV[0];
			if (v != u)
			{
				modUV[1] = modUV[1].Multiply(bigRadix);
			}
			return modUV;
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x000BFFD4 File Offset: 0x000BE1D4
		protected static byte[] calculateP_FF1(int radix, byte uLow, int n, int t)
		{
			byte[] P = new byte[global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE];
			P[0] = 1;
			P[1] = 2;
			P[2] = 1;
			P[3] = 0;
			P[4] = (byte)(radix >> 8);
			P[5] = (byte)radix;
			P[6] = 10;
			P[7] = uLow;
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)n, P, 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)t, P, 12);
			return P;
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x000C0024 File Offset: 0x000BE224
		protected static byte[] calculateTweak64_FF3_1(byte[] tweak56)
		{
			return new byte[]
			{
				tweak56[0],
				tweak56[1],
				tweak56[2],
				tweak56[3] & 240,
				tweak56[4],
				tweak56[5],
				tweak56[6],
				(byte)(tweak56[3] << 4)
			};
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x000C0074 File Offset: 0x000BE274
		protected static global::Org.BouncyCastle.Math.BigInteger calculateY_FF1(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, global::Org.BouncyCastle.Math.BigInteger bigRadix, byte[] T, int b, int d, int round, byte[] P, ushort[] AB)
		{
			int t = T.Length;
			byte[] bytesAB = global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(global::Org.BouncyCastle.Crypto.Fpe.SP80038G.num(bigRadix, AB));
			int zeroes = -(t + b + 1) & 15;
			byte[] Q = new byte[t + zeroes + 1 + b];
			global::System.Array.Copy(T, 0, Q, 0, t);
			Q[t + zeroes] = (byte)round;
			global::System.Array.Copy(bytesAB, 0, Q, Q.Length - bytesAB.Length, bytesAB.Length);
			byte[] R = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.prf(cipher, global::Org.BouncyCastle.Utilities.Arrays.Concatenate(P, Q));
			byte[] sBlocks = R;
			if (d > global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE)
			{
				int sBlocksLen = (d + global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE - 1) / global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE;
				sBlocks = new byte[sBlocksLen * global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE];
				global::System.Array.Copy(R, 0, sBlocks, 0, global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE);
				byte[] uint32 = new byte[4];
				uint i = 1U;
				while ((ulong)i < (ulong)((long)sBlocksLen))
				{
					int sOff = (int)((ulong)i * (ulong)((long)global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE));
					global::System.Array.Copy(R, 0, sBlocks, sOff, global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE);
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(i, uint32, 0);
					global::Org.BouncyCastle.Crypto.Fpe.SP80038G.xor(uint32, 0, sBlocks, sOff + global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE - 4, 4);
					cipher.ProcessBlock(sBlocks, sOff, sBlocks, sOff);
					i += 1U;
				}
			}
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.num(sBlocks, 0, d);
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x000C0190 File Offset: 0x000BE390
		protected static global::Org.BouncyCastle.Math.BigInteger calculateY_FF3(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, global::Org.BouncyCastle.Math.BigInteger bigRadix, byte[] T, int wOff, uint round, ushort[] AB)
		{
			byte[] P = new byte[global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(round, P, 0);
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.xor(T, wOff, P, 0, 4);
			byte[] bytesAB = global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(global::Org.BouncyCastle.Crypto.Fpe.SP80038G.num(bigRadix, AB));
			if (P.Length - bytesAB.Length < 4)
			{
				throw new global::System.InvalidOperationException("input out of range");
			}
			global::System.Array.Copy(bytesAB, 0, P, P.Length - bytesAB.Length, bytesAB.Length);
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.rev(P);
			cipher.ProcessBlock(P, 0, P, 0);
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.rev(P);
			byte[] S = P;
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.num(S, 0, S.Length);
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x000C0213 File Offset: 0x000BE413
		protected static void checkArgs(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, bool isFF1, int radix, ushort[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkCipher(cipher);
			if (radix < 2 || radix > 65536)
			{
				throw new global::System.ArgumentException();
			}
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkData(isFF1, radix, buf, off, len);
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x000C0239 File Offset: 0x000BE439
		protected static void checkArgs(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, bool isFF1, int radix, byte[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkCipher(cipher);
			if (radix < 2 || radix > 256)
			{
				throw new global::System.ArgumentException();
			}
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkData(isFF1, radix, buf, off, len);
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x000C025F File Offset: 0x000BE45F
		protected static void checkCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			if (global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE != cipher.GetBlockSize())
			{
				throw new global::System.ArgumentException();
			}
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x000C0274 File Offset: 0x000BE474
		protected static void checkData(bool isFF1, int radix, ushort[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkLength(isFF1, radix, len);
			for (int i = 0; i < len; i++)
			{
				if ((int)(buf[off + i] & 65535) >= radix)
				{
					throw new global::System.ArgumentException("input data outside of radix");
				}
			}
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x000C02B0 File Offset: 0x000BE4B0
		protected static void checkData(bool isFF1, int radix, byte[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.checkLength(isFF1, radix, len);
			for (int i = 0; i < len; i++)
			{
				if ((int)(buf[off + i] & 255) >= radix)
				{
					throw new global::System.ArgumentException("input data outside of radix");
				}
			}
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x000C02EC File Offset: 0x000BE4EC
		private static void checkLength(bool isFF1, int radix, int len)
		{
			if (len < 2 || global::System.Math.Pow((double)radix, (double)len) < 1000000.0)
			{
				throw new global::System.ArgumentException("input too short");
			}
			if (!isFF1)
			{
				int maxLen = 2 * (int)global::System.Math.Floor(global::System.Math.Log(global::Org.BouncyCastle.Crypto.Fpe.SP80038G.TWO_TO_96) / global::System.Math.Log((double)radix));
				if (len > maxLen)
				{
					throw new global::System.ArgumentException("maximum input length is " + maxLen.ToString());
				}
			}
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x000C0358 File Offset: 0x000BE558
		protected static byte[] implDecryptFF3(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
		{
			int v = len / 2;
			int u = len - v;
			ushort[] A = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toShort(buf, off, u);
			ushort[] B = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toShort(buf, off + u, v);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toByte(global::Org.BouncyCastle.Crypto.Fpe.SP80038G.decFF3_1(cipher, radix, tweak64, len, v, u, A, B));
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x000C03A0 File Offset: 0x000BE5A0
		protected static ushort[] implDecryptFF3w(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak64, ushort[] buf, int off, int len)
		{
			int v = len / 2;
			int u = len - v;
			ushort[] A = new ushort[u];
			ushort[] B = new ushort[v];
			global::System.Array.Copy(buf, off, A, 0, u);
			global::System.Array.Copy(buf, off + u, B, 0, v);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.decFF3_1(cipher, radix, tweak64, len, v, u, A, B);
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x000C03F4 File Offset: 0x000BE5F4
		private static ushort[] decFF3_1(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] T, int n, int v, int u, ushort[] A, ushort[] B)
		{
			global::Org.BouncyCastle.Math.BigInteger bigRadix = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)radix);
			global::Org.BouncyCastle.Math.BigInteger[] modVU = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateModUV(bigRadix, v, u);
			int i = u;
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.rev(A);
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.rev(B);
			for (int j = 7; j >= 0; j--)
			{
				i = n - i;
				global::Org.BouncyCastle.Math.BigInteger modulus = modVU[1 - (j & 1)];
				int wOff = 4 - (j & 1) * 4;
				global::Org.BouncyCastle.Math.BigInteger y = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateY_FF3(cipher, bigRadix, T, wOff, (uint)j, A);
				global::Org.BouncyCastle.Math.BigInteger c = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.num(bigRadix, B).Subtract(y).Mod(modulus);
				ushort[] C = B;
				B = A;
				A = C;
				global::Org.BouncyCastle.Crypto.Fpe.SP80038G.str(bigRadix, c, i, C, 0);
			}
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.rev(A);
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.rev(B);
			return global::Org.BouncyCastle.Utilities.Arrays.Concatenate(A, B);
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x000C04A0 File Offset: 0x000BE6A0
		protected static byte[] implEncryptFF3(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
		{
			int v = len / 2;
			int u = len - v;
			ushort[] A = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toShort(buf, off, u);
			ushort[] B = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toShort(buf, off + u, v);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.toByte(global::Org.BouncyCastle.Crypto.Fpe.SP80038G.encFF3_1(cipher, radix, tweak64, len, v, u, A, B));
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x000C04E8 File Offset: 0x000BE6E8
		protected static ushort[] implEncryptFF3w(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] tweak64, ushort[] buf, int off, int len)
		{
			int v = len / 2;
			int u = len - v;
			ushort[] A = new ushort[u];
			ushort[] B = new ushort[v];
			global::System.Array.Copy(buf, off, A, 0, u);
			global::System.Array.Copy(buf, off + u, B, 0, v);
			return global::Org.BouncyCastle.Crypto.Fpe.SP80038G.encFF3_1(cipher, radix, tweak64, len, v, u, A, B);
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000C053C File Offset: 0x000BE73C
		private static ushort[] encFF3_1(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int radix, byte[] t, int n, int v, int u, ushort[] a, ushort[] b)
		{
			global::Org.BouncyCastle.Math.BigInteger bigRadix = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)radix);
			global::Org.BouncyCastle.Math.BigInteger[] modVU = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateModUV(bigRadix, v, u);
			int i = v;
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.rev(a);
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.rev(b);
			for (uint j = 0U; j < 8U; j += 1U)
			{
				i = n - i;
				global::Org.BouncyCastle.Math.BigInteger modulus = modVU[(int)(1U - (j & 1U))];
				int wOff = (int)(4U - (j & 1U) * 4U);
				global::Org.BouncyCastle.Math.BigInteger y = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.calculateY_FF3(cipher, bigRadix, t, wOff, j, b);
				global::Org.BouncyCastle.Math.BigInteger c = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.num(bigRadix, a).Add(y).Mod(modulus);
				ushort[] C = a;
				a = b;
				b = C;
				global::Org.BouncyCastle.Crypto.Fpe.SP80038G.str(bigRadix, c, i, C, 0);
			}
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.rev(a);
			global::Org.BouncyCastle.Crypto.Fpe.SP80038G.rev(b);
			return global::Org.BouncyCastle.Utilities.Arrays.Concatenate(a, b);
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x000C05E5 File Offset: 0x000BE7E5
		protected static global::Org.BouncyCastle.Math.BigInteger num(byte[] buf, int off, int len)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(buf, off, off + len));
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x000C05F8 File Offset: 0x000BE7F8
		protected static global::Org.BouncyCastle.Math.BigInteger num(global::Org.BouncyCastle.Math.BigInteger R, ushort[] x)
		{
			global::Org.BouncyCastle.Math.BigInteger result = global::Org.BouncyCastle.Math.BigInteger.Zero;
			for (int i = 0; i < x.Length; i++)
			{
				result = result.Multiply(R).Add(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)(x[i] & ushort.MaxValue)));
			}
			return result;
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x000C0638 File Offset: 0x000BE838
		protected static byte[] prf(global::Org.BouncyCastle.Crypto.IBlockCipher c, byte[] x)
		{
			if (x.Length % global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE != 0)
			{
				throw new global::System.ArgumentException();
			}
			int i = x.Length / global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE;
			byte[] y = new byte[global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE];
			for (int j = 0; j < i; j++)
			{
				global::Org.BouncyCastle.Crypto.Fpe.SP80038G.xor(x, j * global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE, y, 0, global::Org.BouncyCastle.Crypto.Fpe.SP80038G.BLOCK_SIZE);
				c.ProcessBlock(y, 0, y, 0);
			}
			return y;
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x000C0698 File Offset: 0x000BE898
		protected static void rev(byte[] x)
		{
			int half = x.Length / 2;
			int end = x.Length - 1;
			for (int i = 0; i < half; i++)
			{
				byte tmp = x[i];
				x[i] = x[end - i];
				x[end - i] = tmp;
			}
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x000C06D0 File Offset: 0x000BE8D0
		protected static void rev(ushort[] x)
		{
			int half = x.Length / 2;
			int end = x.Length - 1;
			for (int i = 0; i < half; i++)
			{
				ushort tmp = x[i];
				x[i] = x[end - i];
				x[end - i] = tmp;
			}
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x000C0708 File Offset: 0x000BE908
		protected static void str(global::Org.BouncyCastle.Math.BigInteger R, global::Org.BouncyCastle.Math.BigInteger x, int m, ushort[] output, int off)
		{
			if (x.SignValue < 0)
			{
				throw new global::System.ArgumentException();
			}
			for (int i = 1; i <= m; i++)
			{
				global::Org.BouncyCastle.Math.BigInteger[] qr = x.DivideAndRemainder(R);
				output[off + m - i] = (ushort)qr[1].IntValue;
				x = qr[0];
			}
			if (x.SignValue != 0)
			{
				throw new global::System.ArgumentException();
			}
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x000C075C File Offset: 0x000BE95C
		protected static void xor(byte[] x, int xOff, byte[] y, int yOff, int len)
		{
			for (int i = 0; i < len; i++)
			{
				int num = yOff + i;
				y[num] ^= x[xOff + i];
			}
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x000C078C File Offset: 0x000BE98C
		private static byte[] toByte(ushort[] buf)
		{
			byte[] s = new byte[buf.Length];
			for (int i = 0; i != s.Length; i++)
			{
				s[i] = (byte)buf[i];
			}
			return s;
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000C07B8 File Offset: 0x000BE9B8
		private static ushort[] toShort(byte[] buf, int off, int len)
		{
			ushort[] s = new ushort[len];
			for (int i = 0; i != s.Length; i++)
			{
				s[i] = (ushort)(buf[off + i] & byte.MaxValue);
			}
			return s;
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x000C07EC File Offset: 0x000BE9EC
		private static int Ceil(double v)
		{
			int rv = (int)v;
			if ((double)rv < v)
			{
				return rv + 1;
			}
			return rv;
		}

		// Token: 0x0400127E RID: 4734
		internal static readonly string FPE_DISABLED = "Org.BouncyCastle.Fpe.Disable";

		// Token: 0x0400127F RID: 4735
		internal static readonly string FF1_DISABLED = "Org.BouncyCastle.Fpe.Disable_Ff1";

		// Token: 0x04001280 RID: 4736
		protected static readonly int BLOCK_SIZE = 16;

		// Token: 0x04001281 RID: 4737
		protected static readonly double LOG2 = global::System.Math.Log(2.0);

		// Token: 0x04001282 RID: 4738
		protected static readonly double TWO_TO_96 = global::System.Math.Pow(2.0, 96.0);
	}
}
