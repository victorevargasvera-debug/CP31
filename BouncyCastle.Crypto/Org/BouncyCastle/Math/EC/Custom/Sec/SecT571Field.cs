using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020002A1 RID: 673
	internal class SecT571Field
	{
		// Token: 0x06001DAC RID: 7596 RVA: 0x00089B98 File Offset: 0x00087D98
		public static void Add(ulong[] x, ulong[] y, ulong[] z)
		{
			for (int i = 0; i < 9; i++)
			{
				z[i] = (x[i] ^ y[i]);
			}
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00089BBC File Offset: 0x00087DBC
		private static void Add(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z, int zOff)
		{
			for (int i = 0; i < 9; i++)
			{
				z[zOff + i] = (x[xOff + i] ^ y[yOff + i]);
			}
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00089BE8 File Offset: 0x00087DE8
		public static void AddBothTo(ulong[] x, ulong[] y, ulong[] z)
		{
			for (int i = 0; i < 9; i++)
			{
				z[i] ^= (x[i] ^ y[i]);
			}
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00089C14 File Offset: 0x00087E14
		private static void AddBothTo(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z, int zOff)
		{
			for (int i = 0; i < 9; i++)
			{
				z[zOff + i] ^= (x[xOff + i] ^ y[yOff + i]);
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00089C48 File Offset: 0x00087E48
		public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
		{
			for (int i = 0; i < 18; i++)
			{
				zz[i] = (xx[i] ^ yy[i]);
			}
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00089C6C File Offset: 0x00087E6C
		public static void AddOne(ulong[] x, ulong[] z)
		{
			z[0] = (x[0] ^ 1UL);
			for (int i = 1; i < 9; i++)
			{
				z[i] = x[i];
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00089C98 File Offset: 0x00087E98
		private static void AddTo(ulong[] x, ulong[] z)
		{
			for (int i = 0; i < 9; i++)
			{
				z[i] ^= x[i];
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00089CC0 File Offset: 0x00087EC0
		public static ulong[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger64(571, x);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00089CD0 File Offset: 0x00087ED0
		public static void HalfTrace(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
			global::Org.BouncyCastle.Math.Raw.Nat576.Copy64(x, z);
			for (int i = 1; i < 571; i += 2)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddTo(x, z);
			}
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00089D20 File Offset: 0x00087F20
		public static void Invert(ulong[] x, ulong[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat576.IsZero64(x))
			{
				throw new global::System.InvalidOperationException();
			}
			ulong[] t0 = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			ulong[] t = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			ulong[] t2 = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Square(x, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Square(t2, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Square(t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(t0, 2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t2, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(t0, 5, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(t, 5, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(t0, 15, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(t2, 30, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(t0, 30, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(t0, 60, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(t, 60, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(t0, 180, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(t, 180, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(t0, t2, z);
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00089E20 File Offset: 0x00088020
		public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(tt, z);
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00089E44 File Offset: 0x00088044
		public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00089E68 File Offset: 0x00088068
		public static void MultiplyPrecomp(ulong[] x, ulong[] precomp, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMultiplyPrecomp(x, precomp, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(tt, z);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00089E8C File Offset: 0x0008808C
		public static void MultiplyPrecompAddToExt(ulong[] x, ulong[] precomp, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMultiplyPrecomp(x, precomp, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00089EB0 File Offset: 0x000880B0
		public static ulong[] PrecompMultiplicand(ulong[] x)
		{
			int len = 144;
			ulong[] t = new ulong[len << 1];
			global::System.Array.Copy(x, 0, t, 9, 9);
			int tOff = 0;
			for (int i = 7; i > 0; i--)
			{
				tOff += 18;
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit64(9, t, tOff >> 1, 0UL, t, tOff);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce5(t, tOff);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Add(t, 9, t, tOff, t, tOff + 9);
			}
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits64(len, t, 0, 4, 0UL, t, len);
			return t;
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00089F20 File Offset: 0x00088120
		public static void Reduce(ulong[] xx, ulong[] z)
		{
			ulong xx2 = xx[9];
			ulong u = xx[17];
			ulong v = xx2;
			xx2 = (v ^ u >> 59 ^ u >> 57 ^ u >> 54 ^ u >> 49);
			v = (xx[8] ^ u << 5 ^ u << 7 ^ u << 10 ^ u << 15);
			for (int i = 16; i >= 10; i--)
			{
				u = xx[i];
				z[i - 8] = (v ^ u >> 59 ^ u >> 57 ^ u >> 54 ^ u >> 49);
				v = (xx[i - 9] ^ u << 5 ^ u << 7 ^ u << 10 ^ u << 15);
			}
			u = xx2;
			z[1] = (v ^ u >> 59 ^ u >> 57 ^ u >> 54 ^ u >> 49);
			v = (xx[0] ^ u << 5 ^ u << 7 ^ u << 10 ^ u << 15);
			ulong x8 = z[8];
			ulong t = x8 >> 59;
			z[0] = (v ^ t ^ t << 2 ^ t << 5 ^ t << 10);
			z[8] = (x8 & 576460752303423487UL);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0008A010 File Offset: 0x00088210
		public static void Reduce5(ulong[] z, int zOff)
		{
			ulong z2 = z[zOff + 8];
			ulong t = z2 >> 59;
			z[zOff] ^= (t ^ t << 2 ^ t << 5 ^ t << 10);
			z[zOff + 8] = (z2 & 576460752303423487UL);
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x0008A054 File Offset: 0x00088254
		public static void Sqrt(ulong[] x, ulong[] z)
		{
			ulong[] evn = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			ulong[] odd = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			int pos = 0;
			for (int i = 0; i < 4; i++)
			{
				ulong u0 = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[pos++]);
				ulong u = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[pos++]);
				evn[i] = ((u0 & (ulong)-1) | u << 32);
				odd[i] = (u0 >> 32 | (u & 18446744069414584320UL));
			}
			ulong u2 = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[pos]);
			evn[4] = (u2 & (ulong)-1);
			odd[4] = u2 >> 32;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(odd, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ROOT_Z, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Add(z, evn, z);
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0008A0E8 File Offset: 0x000882E8
		public static void Square(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(tt, z);
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0008A10C File Offset: 0x0008830C
		public static void SquareAddToExt(ulong[] x, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0008A130 File Offset: 0x00088330
		public static void SquareN(ulong[] x, int n, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0008A16A File Offset: 0x0008836A
		public static uint Trace(ulong[] x)
		{
			return (uint)(x[0] ^ x[8] >> 49 ^ x[8] >> 57) & 1U;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x0008A180 File Offset: 0x00088380
		protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] u = new ulong[16];
			for (int i = 0; i < 9; i++)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[i], y[i], zz, i << 1);
			}
			ulong v0 = zz[0];
			ulong v = zz[1];
			v0 ^= zz[2];
			zz[1] = (v0 ^ v);
			v ^= zz[3];
			v0 ^= zz[4];
			zz[2] = (v0 ^ v);
			v ^= zz[5];
			v0 ^= zz[6];
			zz[3] = (v0 ^ v);
			v ^= zz[7];
			v0 ^= zz[8];
			zz[4] = (v0 ^ v);
			v ^= zz[9];
			v0 ^= zz[10];
			zz[5] = (v0 ^ v);
			v ^= zz[11];
			v0 ^= zz[12];
			zz[6] = (v0 ^ v);
			v ^= zz[13];
			v0 ^= zz[14];
			zz[7] = (v0 ^ v);
			v ^= zz[15];
			v0 ^= zz[16];
			zz[8] = (v0 ^ v);
			v ^= zz[17];
			ulong w = v0 ^ v;
			zz[9] = (zz[0] ^ w);
			zz[10] = (zz[1] ^ w);
			zz[11] = (zz[2] ^ w);
			zz[12] = (zz[3] ^ w);
			zz[13] = (zz[4] ^ w);
			zz[14] = (zz[5] ^ w);
			zz[15] = (zz[6] ^ w);
			zz[16] = (zz[7] ^ w);
			zz[17] = (zz[8] ^ w);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[0] ^ x[1], y[0] ^ y[1], zz, 1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[0] ^ x[2], y[0] ^ y[2], zz, 2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[0] ^ x[3], y[0] ^ y[3], zz, 3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[1] ^ x[2], y[1] ^ y[2], zz, 3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[0] ^ x[4], y[0] ^ y[4], zz, 4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[1] ^ x[3], y[1] ^ y[3], zz, 4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[0] ^ x[5], y[0] ^ y[5], zz, 5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[1] ^ x[4], y[1] ^ y[4], zz, 5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[2] ^ x[3], y[2] ^ y[3], zz, 5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[0] ^ x[6], y[0] ^ y[6], zz, 6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[1] ^ x[5], y[1] ^ y[5], zz, 6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[2] ^ x[4], y[2] ^ y[4], zz, 6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[0] ^ x[7], y[0] ^ y[7], zz, 7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[1] ^ x[6], y[1] ^ y[6], zz, 7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[2] ^ x[5], y[2] ^ y[5], zz, 7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[3] ^ x[4], y[3] ^ y[4], zz, 7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[0] ^ x[8], y[0] ^ y[8], zz, 8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[1] ^ x[7], y[1] ^ y[7], zz, 8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[2] ^ x[6], y[2] ^ y[6], zz, 8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[3] ^ x[5], y[3] ^ y[5], zz, 8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[1] ^ x[8], y[1] ^ y[8], zz, 9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[2] ^ x[7], y[2] ^ y[7], zz, 9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[3] ^ x[6], y[3] ^ y[6], zz, 9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[4] ^ x[5], y[4] ^ y[5], zz, 9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[2] ^ x[8], y[2] ^ y[8], zz, 10);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[3] ^ x[7], y[3] ^ y[7], zz, 10);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[4] ^ x[6], y[4] ^ y[6], zz, 10);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[3] ^ x[8], y[3] ^ y[8], zz, 11);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[4] ^ x[7], y[4] ^ y[7], zz, 11);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[5] ^ x[6], y[5] ^ y[6], zz, 11);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[4] ^ x[8], y[4] ^ y[8], zz, 12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[5] ^ x[7], y[5] ^ y[7], zz, 12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[5] ^ x[8], y[5] ^ y[8], zz, 13);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[6] ^ x[7], y[6] ^ y[7], zz, 13);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[6] ^ x[8], y[6] ^ y[8], zz, 14);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMulwAcc(u, x[7] ^ x[8], y[7] ^ y[8], zz, 15);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x0008A5D8 File Offset: 0x000887D8
		protected static void ImplMultiplyPrecomp(ulong[] x, ulong[] precomp, ulong[] zz)
		{
			uint MASK = 15U;
			for (int i = 56; i >= 0; i -= 8)
			{
				for (int j = 1; j < 9; j += 2)
				{
					uint num = (uint)(x[j] >> i);
					uint u = num & MASK;
					uint v = num >> 4 & MASK;
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddBothTo(precomp, (int)(9U * u), precomp, (int)(9U * (v + 16U)), zz, j - 1);
				}
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits64(16, zz, 0, 8, 0UL);
			}
			for (int k = 56; k >= 0; k -= 8)
			{
				for (int l = 0; l < 9; l += 2)
				{
					uint num2 = (uint)(x[l] >> k);
					uint u2 = num2 & MASK;
					uint v2 = num2 >> 4 & MASK;
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddBothTo(precomp, (int)(9U * u2), precomp, (int)(9U * (v2 + 16U)), zz, l);
				}
				if (k > 0)
				{
					global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits64(18, zz, 0, 8, 0UL);
				}
			}
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x0008A69C File Offset: 0x0008889C
		protected static void ImplMulwAcc(ulong[] u, ulong x, ulong y, ulong[] z, int zOff)
		{
			u[1] = y;
			for (int i = 2; i < 16; i += 2)
			{
				u[i] = u[i >> 1] << 1;
				u[i + 1] = (u[i] ^ y);
			}
			uint j = (uint)x;
			ulong h = 0UL;
			ulong k = u[(int)(j & 15U)] ^ u[(int)(j >> 4 & 15U)] << 4;
			int l = 56;
			do
			{
				j = (uint)(x >> l);
				ulong g = u[(int)(j & 15U)] ^ u[(int)(j >> 4 & 15U)] << 4;
				k ^= g << l;
				h ^= g >> -l;
			}
			while ((l -= 8) > 0);
			for (int p = 0; p < 7; p++)
			{
				x = (x & 18374403900871474942UL) >> 1;
				h ^= (x & y << p >> 63);
			}
			z[zOff] ^= k;
			z[zOff + 1] ^= h;
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0008A776 File Offset: 0x00088976
		protected static void ImplSquare(ulong[] x, ulong[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x, 0, 9, zz, 0);
		}

		// Token: 0x04000AE2 RID: 2786
		private const ulong M59 = 576460752303423487UL;

		// Token: 0x04000AE3 RID: 2787
		private static readonly ulong[] ROOT_Z = new ulong[]
		{
			3161836309350906777UL,
			10804290191530228771UL,
			14625517132619890193UL,
			7312758566309945096UL,
			17890083061325672324UL,
			8945041530681231562UL,
			13695892802195391589UL,
			6847946401097695794UL,
			541669439031730457UL
		};
	}
}
