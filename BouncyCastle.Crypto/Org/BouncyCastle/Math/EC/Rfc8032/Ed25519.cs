using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Rfc8032
{
	// Token: 0x0200021E RID: 542
	public abstract class Ed25519
	{
		// Token: 0x060015C6 RID: 5574 RVA: 0x00066D20 File Offset: 0x00064F20
		private static byte[] CalculateS(byte[] r, byte[] k, byte[] s)
		{
			uint[] t = new uint[16];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.DecodeScalar(r, 0, t);
			uint[] u = new uint[8];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.DecodeScalar(k, 0, u);
			uint[] v = new uint[8];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.DecodeScalar(s, 0, v);
			global::Org.BouncyCastle.Math.Raw.Nat256.MulAddTo(u, v, t);
			byte[] result = new byte[64];
			for (int i = 0; i < t.Length; i++)
			{
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Encode32(t[i], result, i * 4);
			}
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ReduceScalar(result);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00066D92 File Offset: 0x00064F92
		private static bool CheckContextVar(byte[] ctx, byte phflag)
		{
			return (ctx == null && phflag == 0) || (ctx != null && ctx.Length < 256);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00066DAC File Offset: 0x00064FAC
		private static int CheckPoint(int[] x, int[] y)
		{
			int[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] u = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] v = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(y, v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(u, v, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sub(v, u, v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(t, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.C_d, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.AddOne(t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sub(t, v, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(t);
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.IsZero(t);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00066E10 File Offset: 0x00065010
		private static int CheckPoint(int[] x, int[] y, int[] z)
		{
			int[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] u = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] v = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] w = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(y, v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(z, w);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(u, v, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sub(v, u, v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(v, w, v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(w, w);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(t, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.C_d, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(t, w, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sub(t, v, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(t);
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.IsZero(t);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00066E94 File Offset: 0x00065094
		private static bool CheckPointVar(byte[] p)
		{
			uint[] t = new uint[8];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(p, 0, t, 0, 8);
			t[7] &= 2147483647U;
			return !global::Org.BouncyCastle.Math.Raw.Nat256.Gte(t, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.P);
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00066ED0 File Offset: 0x000650D0
		private static bool CheckScalarVar(byte[] s, uint[] n)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.DecodeScalar(s, 0, n);
			return !global::Org.BouncyCastle.Math.Raw.Nat256.Gte(n, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.L);
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00066EE8 File Offset: 0x000650E8
		private static byte[] Copy(byte[] buf, int off, int len)
		{
			byte[] result = new byte[len];
			global::System.Array.Copy(buf, off, result, 0, len);
			return result;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00066F07 File Offset: 0x00065107
		private static global::Org.BouncyCastle.Crypto.IDigest CreateDigest()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Sha512Digest();
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00066F0E File Offset: 0x0006510E
		public static global::Org.BouncyCastle.Crypto.IDigest CreatePrehash()
		{
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CreateDigest();
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00066F15 File Offset: 0x00065115
		private static uint Decode24(byte[] bs, int off)
		{
			return (uint)((int)bs[off] | (int)bs[++off] << 8 | (int)bs[++off] << 16);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00066F31 File Offset: 0x00065131
		private static uint Decode32(byte[] bs, int off)
		{
			return (uint)((int)bs[off] | (int)bs[++off] << 8 | (int)bs[++off] << 16 | (int)bs[++off] << 24);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00066F5C File Offset: 0x0006515C
		private static void Decode32(byte[] bs, int bsOff, uint[] n, int nOff, int nLen)
		{
			for (int i = 0; i < nLen; i++)
			{
				n[nOff + i] = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(bs, bsOff + i * 4);
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00066F88 File Offset: 0x00065188
		private static bool DecodePointVar(byte[] p, int pOff, bool negate, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine r)
		{
			byte[] py = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Copy(p, pOff, 32);
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CheckPointVar(py))
			{
				return false;
			}
			int x_0 = (py[31] & 128) >> 7;
			byte[] array = py;
			int num = 31;
			array[num] &= 127;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode(py, 0, r.y);
			int[] u = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] v = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(r.y, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.C_d, u, v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.SubOne(u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.AddOne(v);
			if (!global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.SqrtRatioVar(u, v, r.x))
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(r.x);
			if (x_0 == 1 && global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.IsZeroVar(r.x))
			{
				return false;
			}
			if (negate ^ x_0 != (r.x[0] & 1))
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Negate(r.x, r.x);
			}
			return true;
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00067057 File Offset: 0x00065257
		private static void DecodeScalar(byte[] k, int kOff, uint[] n)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(k, kOff, n, 0, 8);
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00067064 File Offset: 0x00065264
		private static void Dom2(global::Org.BouncyCastle.Crypto.IDigest d, byte phflag, byte[] ctx)
		{
			if (ctx != null)
			{
				int i = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Dom2Prefix.Length;
				byte[] t = new byte[i + 2 + ctx.Length];
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Dom2Prefix.CopyTo(t, 0);
				t[i] = phflag;
				t[i + 1] = (byte)ctx.Length;
				ctx.CopyTo(t, i + 2);
				d.BlockUpdate(t, 0, t.Length);
			}
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000670B7 File Offset: 0x000652B7
		private static void Encode24(uint n, byte[] bs, int off)
		{
			bs[off] = (byte)n;
			bs[++off] = (byte)(n >> 8);
			bs[++off] = (byte)(n >> 16);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x000670D7 File Offset: 0x000652D7
		private static void Encode32(uint n, byte[] bs, int off)
		{
			bs[off] = (byte)n;
			bs[++off] = (byte)(n >> 8);
			bs[++off] = (byte)(n >> 16);
			bs[++off] = (byte)(n >> 24);
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00067104 File Offset: 0x00065304
		private static void Encode56(ulong n, byte[] bs, int off)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Encode32((uint)n, bs, off);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Encode24((uint)(n >> 32), bs, off + 4);
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00067120 File Offset: 0x00065320
		private static int EncodePoint(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum p, byte[] r, int rOff)
		{
			int[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] y = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Inv(p.z, y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(p.x, y, x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(p.y, y, y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(y);
			int result = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CheckPoint(x, y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode(y, r, rOff);
			int num = rOff + 32 - 1;
			r[num] |= (byte)((x[0] & 1) << 7);
			return result;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00067193 File Offset: 0x00065393
		public static void GeneratePrivateKey(global::Org.BouncyCastle.Security.SecureRandom random, byte[] k)
		{
			random.NextBytes(k);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x0006719C File Offset: 0x0006539C
		public static void GeneratePublicKey(byte[] sk, int skOff, byte[] pk, int pkOff)
		{
			global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CreateDigest();
			byte[] h = new byte[digest.GetDigestSize()];
			digest.BlockUpdate(sk, skOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.SecretKeySize);
			digest.DoFinal(h, 0);
			byte[] s = new byte[32];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PruneScalar(h, 0, s);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ScalarMultBaseEncoded(s, pk, pkOff);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x000671E8 File Offset: 0x000653E8
		private static uint GetWindow4(uint[] x, int n)
		{
			int w = (int)((uint)n >> 3);
			int b = (n & 7) << 2;
			return x[w] >> b & 15U;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0006720C File Offset: 0x0006540C
		private static sbyte[] GetWnafVar(uint[] n, int width)
		{
			uint[] t = new uint[16];
			uint c = 0U;
			int tPos = t.Length;
			int i = 8;
			while (--i >= 0)
			{
				uint next = n[i];
				t[--tPos] = (next >> 16 | c << 16);
				c = (t[--tPos] = next);
			}
			sbyte[] ws = new sbyte[253];
			int lead = 32 - width;
			uint carry = 0U;
			int j = 0;
			int k = 0;
			while (k < t.Length)
			{
				uint word = t[k];
				while (j < 16)
				{
					uint word2 = word >> j;
					if ((word2 & 1U) == carry)
					{
						j++;
					}
					else
					{
						uint digit = (word2 | 1U) << lead;
						carry = digit >> 31;
						ws[(k << 4) + j] = (sbyte)((int)digit >> lead);
						j += width;
					}
				}
				k++;
				j -= 16;
			}
			return ws;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x000672E0 File Offset: 0x000654E0
		private static void ImplSign(global::Org.BouncyCastle.Crypto.IDigest d, byte[] h, byte[] s, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Dom2(d, phflag, ctx);
			d.BlockUpdate(h, 32, 32);
			d.BlockUpdate(m, mOff, mLen);
			d.DoFinal(h, 0);
			byte[] array = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ReduceScalar(h);
			byte[] R = new byte[32];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ScalarMultBaseEncoded(array, R, 0);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Dom2(d, phflag, ctx);
			d.BlockUpdate(R, 0, 32);
			d.BlockUpdate(pk, pkOff, 32);
			d.BlockUpdate(m, mOff, mLen);
			d.DoFinal(h, 0);
			byte[] i = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ReduceScalar(h);
			global::System.Array sourceArray = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CalculateS(array, i, s);
			global::System.Array.Copy(R, 0, sig, sigOff, 32);
			global::System.Array.Copy(sourceArray, 0, sig, sigOff + 32, 32);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0006738C File Offset: 0x0006558C
		private static void ImplSign(byte[] sk, int skOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CheckContextVar(ctx, phflag))
			{
				throw new global::System.ArgumentException("ctx");
			}
			global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CreateDigest();
			byte[] h = new byte[digest.GetDigestSize()];
			digest.BlockUpdate(sk, skOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.SecretKeySize);
			digest.DoFinal(h, 0);
			byte[] s = new byte[32];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PruneScalar(h, 0, s);
			byte[] pk = new byte[32];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ScalarMultBaseEncoded(s, pk, 0);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplSign(digest, h, s, pk, 0, ctx, phflag, m, mOff, mLen, sig, sigOff);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x0006740C File Offset: 0x0006560C
		private static void ImplSign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CheckContextVar(ctx, phflag))
			{
				throw new global::System.ArgumentException("ctx");
			}
			global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CreateDigest();
			byte[] h = new byte[digest.GetDigestSize()];
			digest.BlockUpdate(sk, skOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.SecretKeySize);
			digest.DoFinal(h, 0);
			byte[] s = new byte[32];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PruneScalar(h, 0, s);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplSign(digest, h, s, pk, pkOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00067480 File Offset: 0x00065680
		private static bool ImplVerify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen)
		{
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CheckContextVar(ctx, phflag))
			{
				throw new global::System.ArgumentException("ctx");
			}
			byte[] R = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Copy(sig, sigOff, 32);
			byte[] S = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Copy(sig, sigOff + 32, 32);
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CheckPointVar(R))
			{
				return false;
			}
			uint[] nS = new uint[8];
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CheckScalarVar(S, nS))
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine pA = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine();
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.DecodePointVar(pk, pkOff, true, pA))
			{
				return false;
			}
			global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CreateDigest();
			byte[] h = new byte[digest.GetDigestSize()];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Dom2(digest, phflag, ctx);
			digest.BlockUpdate(R, 0, 32);
			digest.BlockUpdate(pk, pkOff, 32);
			digest.BlockUpdate(m, mOff, mLen);
			digest.DoFinal(h, 0);
			byte[] k = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ReduceScalar(h);
			uint[] nA = new uint[8];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.DecodeScalar(k, 0, nA);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum pR = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ScalarMultStrausVar(nS, nA, pA, pR);
			byte[] check = new byte[32];
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.EncodePoint(pR, check, 0) != 0 && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(check, R);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00067576 File Offset: 0x00065776
		private static bool IsNeutralElementVar(int[] x, int[] y)
		{
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.IsZeroVar(x) && global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.IsOneVar(y);
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00067588 File Offset: 0x00065788
		private static bool IsNeutralElementVar(int[] x, int[] y, int[] z)
		{
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.IsZeroVar(x) && global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.AreEqualVar(y, z);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x0006759C File Offset: 0x0006579C
		private static void PointAdd(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum r)
		{
			int[] a = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] c = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] d = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] e = r.u;
			int[] f = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] g = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] h = r.v;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(r.y, r.x, b, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(p.y, p.x, d, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(a, c, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(b, d, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(r.u, r.v, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(c, p.t, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(c, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.C_d2, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(r.z, p.z, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(d, d, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(b, a, h, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(d, c, g, f);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Carry(g);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(e, f, r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(g, h, r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(f, g, r.z);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x000676A4 File Offset: 0x000658A4
		private static void PointAdd(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt r)
		{
			int[] a = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] c = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] d = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] e = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] f = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] g = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] h = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(p.y, p.x, b, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(r.y, r.x, d, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(a, c, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(b, d, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(p.t, r.t, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(c, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.C_d2, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(p.z, r.z, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(d, d, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(b, a, h, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(d, c, g, f);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Carry(g);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(e, f, r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(g, h, r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(f, g, r.z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(e, h, r.t);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x000677AC File Offset: 0x000659AC
		private static void PointAddVar(bool negate, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum r)
		{
			int[] a = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] c = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] d = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] e = r.u;
			int[] f = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] g = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] h = r.v;
			int[] nc;
			int[] nd;
			int[] nf;
			int[] ng;
			if (negate)
			{
				nc = d;
				nd = c;
				nf = g;
				ng = f;
			}
			else
			{
				nc = c;
				nd = d;
				nf = f;
				ng = g;
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(r.y, r.x, b, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(p.y, p.x, nd, nc);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(a, c, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(b, d, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(r.u, r.v, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(c, p.t, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(c, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.C_d2, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(r.z, p.z, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(d, d, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(b, a, h, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(d, c, ng, nf);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Carry(ng);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(e, f, r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(g, h, r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(f, g, r.z);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x000678D8 File Offset: 0x00065AD8
		private static void PointAddVar(bool negate, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt q, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt r)
		{
			int[] a = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] c = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] d = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] e = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] f = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] g = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] h = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] nc;
			int[] nd;
			int[] nf;
			int[] ng;
			if (negate)
			{
				nc = d;
				nd = c;
				nf = g;
				ng = f;
			}
			else
			{
				nc = c;
				nd = d;
				nf = f;
				ng = g;
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(p.y, p.x, b, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(q.y, q.x, nd, nc);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(a, c, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(b, d, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(p.t, q.t, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(c, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.C_d2, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(p.z, q.z, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(d, d, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(b, a, h, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(d, c, ng, nf);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Carry(ng);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(e, f, r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(g, h, r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(f, g, r.z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(e, h, r.t);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00067A04 File Offset: 0x00065C04
		private static void PointAddPrecomp(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointPrecomp p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum r)
		{
			int[] a = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] c = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] e = r.u;
			int[] f = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] g = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] h = r.v;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(r.y, r.x, b, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(a, p.ymx_h, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(b, p.ypx_h, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(r.u, r.v, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(c, p.xyd, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(b, a, h, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(r.z, c, g, f);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Carry(g);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(e, f, r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(g, h, r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(f, g, r.z);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00067ADC File Offset: 0x00065CDC
		private static global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt PointCopy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum p)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt r = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.x, 0, r.x, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.y, 0, r.y, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.z, 0, r.z, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(p.u, p.v, r.t);
			return r;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00067B40 File Offset: 0x00065D40
		private static global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt PointCopy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine p)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt r = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.x, 0, r.x, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.y, 0, r.y, 0);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExtendXY(r);
			return r;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00067B80 File Offset: 0x00065D80
		private static global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt PointCopy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt p)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt r = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointCopy(p, r);
			return r;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00067B9B File Offset: 0x00065D9B
		private static void PointCopy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum r)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.x, 0, r.x, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.y, 0, r.y, 0);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExtendXY(r);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00067BCC File Offset: 0x00065DCC
		private static void PointCopy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt r)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.x, 0, r.x, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.y, 0, r.y, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.z, 0, r.z, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.t, 0, r.t, 0);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00067C28 File Offset: 0x00065E28
		private static void PointDouble(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum r)
		{
			int[] a = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] c = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] e = r.u;
			int[] f = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] g = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] h = r.v;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(r.x, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(r.y, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(r.z, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(c, c, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(a, b, h, g);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(r.x, r.y, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(e, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sub(h, e, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(c, g, f);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Carry(f);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(e, f, r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(g, h, r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(f, g, r.z);
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00067CFA File Offset: 0x00065EFA
		private static void PointExtendXY(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum p)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.One(p.z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.x, 0, p.u, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.y, 0, p.v, 0);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00067D2D File Offset: 0x00065F2D
		private static void PointExtendXY(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt p)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.One(p.z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(p.x, p.y, p.t);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00067D54 File Offset: 0x00065F54
		private static void PointLookup(int block, int index, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointPrecomp p)
		{
			int off = block * 8 * 3 * 10;
			for (int i = 0; i < 8; i++)
			{
				int cond = (i ^ index) - 1 >> 31;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CMov(cond, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.precompBase, off, p.ypx_h, 0);
				off += 10;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CMov(cond, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.precompBase, off, p.ymx_h, 0);
				off += 10;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CMov(cond, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.precompBase, off, p.xyd, 0);
				off += 10;
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00067DC8 File Offset: 0x00065FC8
		private static void PointLookup(uint[] x, int n, int[] table, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt r)
		{
			uint window = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.GetWindow4(x, n);
			int sign = (int)(window >> 3 ^ 1U);
			int abs = (int)((window ^ (uint)(-(uint)sign)) & 7U);
			int i = 0;
			int off = 0;
			while (i < 8)
			{
				int cond = (i ^ abs) - 1 >> 31;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CMov(cond, table, off, r.x, 0);
				off += 10;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CMov(cond, table, off, r.y, 0);
				off += 10;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CMov(cond, table, off, r.z, 0);
				off += 10;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CMov(cond, table, off, r.t, 0);
				off += 10;
				i++;
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CNegate(sign, r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CNegate(sign, r.t);
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00067E68 File Offset: 0x00066068
		private static void PointLookup(int[] table, int index, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt r)
		{
			int off = 40 * index;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(table, off, r.x, 0);
			off += 10;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(table, off, r.y, 0);
			off += 10;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(table, off, r.z, 0);
			off += 10;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(table, off, r.t, 0);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00067EC4 File Offset: 0x000660C4
		private static int[] PointPrecompute(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine p, int count)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt q = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointCopy(p);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt d = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointCopy(q);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAdd(q, d);
			int[] table = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CreateTable(count * 4);
			int off = 0;
			int i = 0;
			for (;;)
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(q.x, 0, table, off);
				off += 10;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(q.y, 0, table, off);
				off += 10;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(q.z, 0, table, off);
				off += 10;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(q.t, 0, table, off);
				off += 10;
				if (++i == count)
				{
					break;
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAdd(d, q);
			}
			return table;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00067F54 File Offset: 0x00066154
		private static global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt[] PointPrecomputeVar(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt p, int count)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt d = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAddVar(false, p, p, d);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt[] table = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt[count];
			table[0] = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointCopy(p);
			for (int i = 1; i < count; i++)
			{
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAddVar(false, table[i - 1], d, table[i] = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt());
			}
			return table;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00067FA4 File Offset: 0x000661A4
		private static void PointSetNeutral(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum p)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Zero(p.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.One(p.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.One(p.z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Zero(p.u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.One(p.v);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00067FDD File Offset: 0x000661DD
		private static void PointSetNeutral(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt p)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Zero(p.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.One(p.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.One(p.z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Zero(p.t);
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x0006800C File Offset: 0x0006620C
		public static void Precompute()
		{
			object obj = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.precompLock;
			lock (obj)
			{
				if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.precompBase == null)
				{
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt b = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt();
					global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.B_x, 0, b.x, 0);
					global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.B_y, 0, b.y, 0);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExtendXY(b);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.precompBaseTable = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointPrecomputeVar(b, 32);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum();
					global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.B_x, 0, p.x, 0);
					global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.B_y, 0, p.y, 0);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExtendXY(p);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.precompBase = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CreateTable(192);
					int off = 0;
					for (int b2 = 0; b2 < 8; b2++)
					{
						global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt[] ds = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt[4];
						global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt sum = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt();
						global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointSetNeutral(sum);
						for (int t = 0; t < 4; t++)
						{
							global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt q = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointCopy(p);
							global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAddVar(true, sum, q, sum);
							global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointDouble(p);
							ds[t] = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointCopy(p);
							if (b2 + t != 10)
							{
								for (int s = 1; s < 8; s++)
								{
									global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointDouble(p);
								}
							}
						}
						global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt[] points = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt[8];
						int i = 0;
						points[i++] = sum;
						for (int t2 = 0; t2 < 3; t2++)
						{
							int size = 1 << t2;
							int j = 0;
							while (j < size)
							{
								global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAddVar(false, points[i - size], ds[t2], points[i] = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt());
								j++;
								i++;
							}
						}
						int[] cs = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CreateTable(8);
						int[] u = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
						global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(points[0].z, 0, u, 0);
						global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(u, 0, cs, 0);
						int k = 0;
						while (++k < 8)
						{
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(u, points[k].z, u);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(u, 0, cs, k * 10);
						}
						global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(u, u, u);
						global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.InvVar(u, u);
						k--;
						int[] t3 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
						while (k > 0)
						{
							int l = k--;
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(cs, k * 10, t3, 0);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(t3, u, t3);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(t3, 0, cs, l * 10);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(u, points[l].z, u);
						}
						global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(u, 0, cs, 0);
						for (int m = 0; m < 8; m++)
						{
							global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt pointExt = points[m];
							int[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
							int[] y = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(cs, m * 10, y, 0);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(pointExt.x, y, x);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(pointExt.y, y, y);
							global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointPrecomp r = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointPrecomp();
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(y, x, r.ypx_h, r.ymx_h);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x, y, r.xyd);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(r.xyd, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.C_d4, r.xyd);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(r.ypx_h);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(r.ymx_h);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(r.ypx_h, 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.precompBase, off);
							off += 10;
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(r.ymx_h, 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.precompBase, off);
							off += 10;
							global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(r.xyd, 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.precompBase, off);
							off += 10;
						}
					}
				}
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x0006839C File Offset: 0x0006659C
		private static void PruneScalar(byte[] n, int nOff, byte[] r)
		{
			global::System.Array.Copy(n, nOff, r, 0, 32);
			int num = 0;
			r[num] &= 248;
			int num2 = 31;
			r[num2] &= 127;
			int num3 = 31;
			r[num3] |= 64;
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x000683D8 File Offset: 0x000665D8
		private static byte[] ReduceScalar(byte[] n)
		{
			long x0 = (long)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(n, 0) & (ulong)-1);
			long x = (long)((ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode24(n, 4) << 4) & (ulong)-1);
			long x2 = (long)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(n, 7) & (ulong)-1);
			long x3 = (long)((ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode24(n, 11) << 4) & (ulong)-1);
			long x4 = (long)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(n, 14) & (ulong)-1);
			long x5 = (long)((ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode24(n, 18) << 4) & (ulong)-1);
			long x6 = (long)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(n, 21) & (ulong)-1);
			long x7 = (long)((ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode24(n, 25) << 4) & (ulong)-1);
			long x8 = (long)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(n, 28) & (ulong)-1);
			long x9 = (long)((ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode24(n, 32) << 4) & (ulong)-1);
			long x10 = (long)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(n, 35) & (ulong)-1);
			long x11 = (long)((ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode24(n, 39) << 4) & (ulong)-1);
			long x12 = (long)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(n, 42) & (ulong)-1);
			long x13 = (long)((ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode24(n, 46) << 4) & (ulong)-1);
			long x14 = (long)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(n, 49) & (ulong)-1);
			long x15 = (long)((ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode24(n, 53) << 4) & (ulong)-1);
			long x16 = (long)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode32(n, 56) & (ulong)-1);
			long x17 = (long)((ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Decode24(n, 60) << 4) & (ulong)-1);
			long x18 = (long)((ulong)n[63] & 255UL);
			x9 -= x18 * -50998291L;
			x10 -= x18 * 19280294L;
			x11 -= x18 * 127719000L;
			x12 -= x18 * -6428113L;
			x13 -= x18 * 5343L;
			x17 += x16 >> 28;
			x16 &= 268435455L;
			x8 -= x17 * -50998291L;
			x9 -= x17 * 19280294L;
			x10 -= x17 * 127719000L;
			x11 -= x17 * -6428113L;
			x12 -= x17 * 5343L;
			x7 -= x16 * -50998291L;
			x8 -= x16 * 19280294L;
			x9 -= x16 * 127719000L;
			x10 -= x16 * -6428113L;
			x11 -= x16 * 5343L;
			x15 += x14 >> 28;
			x14 &= 268435455L;
			x6 -= x15 * -50998291L;
			x7 -= x15 * 19280294L;
			x8 -= x15 * 127719000L;
			x9 -= x15 * -6428113L;
			x10 -= x15 * 5343L;
			x5 -= x14 * -50998291L;
			x6 -= x14 * 19280294L;
			x7 -= x14 * 127719000L;
			x8 -= x14 * -6428113L;
			x9 -= x14 * 5343L;
			x13 += x12 >> 28;
			x12 &= 268435455L;
			x4 -= x13 * -50998291L;
			x5 -= x13 * 19280294L;
			x6 -= x13 * 127719000L;
			x7 -= x13 * -6428113L;
			x8 -= x13 * 5343L;
			x12 += x11 >> 28;
			x11 &= 268435455L;
			x3 -= x12 * -50998291L;
			x4 -= x12 * 19280294L;
			x5 -= x12 * 127719000L;
			x6 -= x12 * -6428113L;
			x7 -= x12 * 5343L;
			x11 += x10 >> 28;
			x10 &= 268435455L;
			x2 -= x11 * -50998291L;
			x3 -= x11 * 19280294L;
			x4 -= x11 * 127719000L;
			x5 -= x11 * -6428113L;
			x6 -= x11 * 5343L;
			x10 += x9 >> 28;
			x9 &= 268435455L;
			x -= x10 * -50998291L;
			x2 -= x10 * 19280294L;
			x3 -= x10 * 127719000L;
			x4 -= x10 * -6428113L;
			x5 -= x10 * 5343L;
			x8 += x7 >> 28;
			x7 &= 268435455L;
			x9 += x8 >> 28;
			x8 &= 268435455L;
			long t = x8 >> 27 & 1L;
			x9 += t;
			x0 -= x9 * -50998291L;
			x -= x9 * 19280294L;
			x2 -= x9 * 127719000L;
			x3 -= x9 * -6428113L;
			x4 -= x9 * 5343L;
			x += x0 >> 28;
			x0 &= 268435455L;
			x2 += x >> 28;
			x &= 268435455L;
			x3 += x2 >> 28;
			x2 &= 268435455L;
			x4 += x3 >> 28;
			x3 &= 268435455L;
			x5 += x4 >> 28;
			x4 &= 268435455L;
			x6 += x5 >> 28;
			x5 &= 268435455L;
			x7 += x6 >> 28;
			x6 &= 268435455L;
			x8 += x7 >> 28;
			x7 &= 268435455L;
			x9 = x8 >> 28;
			x8 &= 268435455L;
			x9 -= t;
			x0 += (x9 & -50998291L);
			x += (x9 & 19280294L);
			x2 += (x9 & 127719000L);
			x3 += (x9 & -6428113L);
			x4 += (x9 & 5343L);
			x += x0 >> 28;
			x0 &= 268435455L;
			x2 += x >> 28;
			x &= 268435455L;
			x3 += x2 >> 28;
			x2 &= 268435455L;
			x4 += x3 >> 28;
			x3 &= 268435455L;
			x5 += x4 >> 28;
			x4 &= 268435455L;
			x6 += x5 >> 28;
			x5 &= 268435455L;
			x7 += x6 >> 28;
			x6 &= 268435455L;
			x8 += x7 >> 28;
			x7 &= 268435455L;
			byte[] r = new byte[32];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Encode56((ulong)(x0 | x << 28), r, 0);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Encode56((ulong)(x2 | x3 << 28), r, 7);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Encode56((ulong)(x4 | x5 << 28), r, 14);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Encode56((ulong)(x6 | x7 << 28), r, 21);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Encode32((uint)x8, r, 28);
			return r;
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00068A34 File Offset: 0x00066C34
		private static void ScalarMult(byte[] k, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum r)
		{
			uint[] i = new uint[8];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.DecodeScalar(k, 0, i);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBits(8, i, 3, 1U);
			global::Org.BouncyCastle.Math.Raw.Nat.CAdd(8, (int)(~i[0] & 1U), i, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.L, i);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(8, i, 0U);
			int[] table = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointPrecompute(p, 8);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt q = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointCopy(p, r);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointLookup(table, 7, q);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAdd(q, r);
			int w = 62;
			for (;;)
			{
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointLookup(i, w, table, q);
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAdd(q, r);
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointDouble(r);
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointDouble(r);
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointDouble(r);
				if (--w < 0)
				{
					break;
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointDouble(r);
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00068AD0 File Offset: 0x00066CD0
		private static void ScalarMultBase(byte[] k, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum r)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Precompute();
			uint[] i = new uint[8];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.DecodeScalar(k, 0, i);
			global::Org.BouncyCastle.Math.Raw.Nat.CAdd(8, (int)(~i[0] & 1U), i, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.L, i);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(8, i, 1U);
			for (int j = 0; j < 8; j++)
			{
				i[j] = global::Org.BouncyCastle.Math.Raw.Interleave.Shuffle2(i[j]);
			}
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointPrecomp p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointPrecomp();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointSetNeutral(r);
			int cOff = 28;
			for (;;)
			{
				for (int b = 0; b < 8; b++)
				{
					uint num = i[b] >> cOff;
					int sign = (int)(num >> 3 & 1U);
					int abs = (int)((num ^ (uint)(-(uint)sign)) & 7U);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointLookup(b, abs, p);
					global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CSwap(sign, p.ypx_h, p.ymx_h);
					global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CNegate(sign, p.xyd);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAddPrecomp(p, r);
				}
				if ((cOff -= 4) < 0)
				{
					break;
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointDouble(r);
			}
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00068BA0 File Offset: 0x00066DA0
		private static void ScalarMultBaseEncoded(byte[] k, byte[] r, int rOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ScalarMultBase(k, p);
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.EncodePoint(p, r, rOff) == 0)
			{
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00068BCC File Offset: 0x00066DCC
		internal static void ScalarMultBaseYZ(byte[] k, int kOff, int[] y, int[] z)
		{
			byte[] i = new byte[32];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PruneScalar(k, kOff, i);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ScalarMultBase(i, p);
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CheckPoint(p.x, p.y, p.z) == 0)
			{
				throw new global::System.InvalidOperationException();
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.y, 0, y, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(p.z, 0, z, 0);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00068C34 File Offset: 0x00066E34
		private static void ScalarMultOrderVar(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum r)
		{
			int width = 5;
			sbyte[] ws_p = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.GetWnafVar(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.L, width);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt[] tp = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointPrecomputeVar(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointCopy(p), 1 << width - 2);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointSetNeutral(r);
			int bit = 252;
			for (;;)
			{
				int wp = (int)ws_p[bit];
				if (wp != 0)
				{
					int sign = wp >> 31;
					int index = (wp ^ sign) >> 1;
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAddVar(sign != 0, tp[index], r);
				}
				if (--bit < 0)
				{
					break;
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointDouble(r);
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00068CA8 File Offset: 0x00066EA8
		private static void ScalarMultStrausVar(uint[] nb, uint[] np, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum r)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Precompute();
			int width = 5;
			sbyte[] ws_b = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.GetWnafVar(nb, 7);
			sbyte[] ws_p = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.GetWnafVar(np, width);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt[] tp = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointPrecomputeVar(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointCopy(p), 1 << width - 2);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointSetNeutral(r);
			int bit = 252;
			for (;;)
			{
				int wb = (int)ws_b[bit];
				if (wb != 0)
				{
					int sign = wb >> 31;
					int index = (wb ^ sign) >> 1;
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAddVar(sign != 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.precompBaseTable[index], r);
				}
				int wp = (int)ws_p[bit];
				if (wp != 0)
				{
					int sign2 = wp >> 31;
					int index2 = (wp ^ sign2) >> 1;
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAddVar(sign2 != 0, tp[index2], r);
				}
				if (--bit < 0)
				{
					break;
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointDouble(r);
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00068D58 File Offset: 0x00066F58
		public static void Sign(byte[] sk, int skOff, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			byte[] ctx = null;
			byte phflag = 0;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplSign(sk, skOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00068D7C File Offset: 0x00066F7C
		public static void Sign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			byte[] ctx = null;
			byte phflag = 0;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplSign(sk, skOff, pk, pkOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00068DA4 File Offset: 0x00066FA4
		public static void Sign(byte[] sk, int skOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			byte phflag = 0;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplSign(sk, skOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00068DC8 File Offset: 0x00066FC8
		public static void Sign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			byte phflag = 0;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplSign(sk, skOff, pk, pkOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00068DF0 File Offset: 0x00066FF0
		public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, byte[] ph, int phOff, byte[] sig, int sigOff)
		{
			byte phflag = 1;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplSign(sk, skOff, ctx, phflag, ph, phOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize, sig, sigOff);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00068E14 File Offset: 0x00067014
		public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte[] ph, int phOff, byte[] sig, int sigOff)
		{
			byte phflag = 1;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplSign(sk, skOff, pk, pkOff, ctx, phflag, ph, phOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize, sig, sigOff);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00068E3C File Offset: 0x0006703C
		public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, global::Org.BouncyCastle.Crypto.IDigest ph, byte[] sig, int sigOff)
		{
			byte[] i = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize];
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize != ph.DoFinal(i, 0))
			{
				throw new global::System.ArgumentException("ph");
			}
			byte phflag = 1;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplSign(sk, skOff, ctx, phflag, i, 0, i.Length, sig, sigOff);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00068E84 File Offset: 0x00067084
		public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, global::Org.BouncyCastle.Crypto.IDigest ph, byte[] sig, int sigOff)
		{
			byte[] i = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize];
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize != ph.DoFinal(i, 0))
			{
				throw new global::System.ArgumentException("ph");
			}
			byte phflag = 1;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplSign(sk, skOff, pk, pkOff, ctx, phflag, i, 0, i.Length, sig, sigOff);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00068ED0 File Offset: 0x000670D0
		public static bool ValidatePublicKeyFull(byte[] pk, int pkOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine();
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.DecodePointVar(pk, pkOff, false, p))
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(p.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(p.y);
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.IsNeutralElementVar(p.x, p.y))
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum r = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAccum();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ScalarMultOrderVar(p, r);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(r.z);
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.IsNeutralElementVar(r.x, r.y, r.z);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00068F60 File Offset: 0x00067160
		public static bool ValidatePublicKeyPartial(byte[] pk, int pkOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointAffine();
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.DecodePointVar(pk, pkOff, false, p);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00068F7C File Offset: 0x0006717C
		public static bool Verify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] m, int mOff, int mLen)
		{
			byte[] ctx = null;
			byte phflag = 0;
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, m, mOff, mLen);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00068FA0 File Offset: 0x000671A0
		public static bool Verify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen)
		{
			byte phflag = 0;
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, m, mOff, mLen);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00068FC4 File Offset: 0x000671C4
		public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte[] ph, int phOff)
		{
			byte phflag = 1;
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, ph, phOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize);
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00068FE8 File Offset: 0x000671E8
		public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, global::Org.BouncyCastle.Crypto.IDigest ph)
		{
			byte[] i = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize];
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize != ph.DoFinal(i, 0))
			{
				throw new global::System.ArgumentException("ph");
			}
			byte phflag = 1;
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, i, 0, i.Length);
		}

		// Token: 0x04000975 RID: 2421
		private const long M08L = 255L;

		// Token: 0x04000976 RID: 2422
		private const long M28L = 268435455L;

		// Token: 0x04000977 RID: 2423
		private const long M32L = 4294967295L;

		// Token: 0x04000978 RID: 2424
		private const int CoordUints = 8;

		// Token: 0x04000979 RID: 2425
		private const int PointBytes = 32;

		// Token: 0x0400097A RID: 2426
		private const int ScalarUints = 8;

		// Token: 0x0400097B RID: 2427
		private const int ScalarBytes = 32;

		// Token: 0x0400097C RID: 2428
		public static readonly int PrehashSize = 64;

		// Token: 0x0400097D RID: 2429
		public static readonly int PublicKeySize = 32;

		// Token: 0x0400097E RID: 2430
		public static readonly int SecretKeySize = 32;

		// Token: 0x0400097F RID: 2431
		public static readonly int SignatureSize = 64;

		// Token: 0x04000980 RID: 2432
		private static readonly byte[] Dom2Prefix = new byte[]
		{
			83,
			105,
			103,
			69,
			100,
			50,
			53,
			53,
			49,
			57,
			32,
			110,
			111,
			32,
			69,
			100,
			50,
			53,
			53,
			49,
			57,
			32,
			99,
			111,
			108,
			108,
			105,
			115,
			105,
			111,
			110,
			115
		};

		// Token: 0x04000981 RID: 2433
		private static readonly uint[] P = new uint[]
		{
			4294967277U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			2147483647U
		};

		// Token: 0x04000982 RID: 2434
		private static readonly uint[] L = new uint[]
		{
			1559614445U,
			1477600026U,
			2734136534U,
			350157278U,
			0U,
			0U,
			0U,
			268435456U
		};

		// Token: 0x04000983 RID: 2435
		private const int L0 = -50998291;

		// Token: 0x04000984 RID: 2436
		private const int L1 = 19280294;

		// Token: 0x04000985 RID: 2437
		private const int L2 = 127719000;

		// Token: 0x04000986 RID: 2438
		private const int L3 = -6428113;

		// Token: 0x04000987 RID: 2439
		private const int L4 = 5343;

		// Token: 0x04000988 RID: 2440
		private static readonly int[] B_x = new int[]
		{
			52811034,
			25909283,
			8072341,
			50637101,
			13785486,
			30858332,
			20483199,
			20966410,
			43936626,
			4379245
		};

		// Token: 0x04000989 RID: 2441
		private static readonly int[] B_y = new int[]
		{
			40265304,
			26843545,
			6710886,
			53687091,
			13421772,
			40265318,
			26843545,
			6710886,
			53687091,
			13421772
		};

		// Token: 0x0400098A RID: 2442
		private static readonly int[] C_d = new int[]
		{
			56195235,
			47411844,
			25868126,
			40503822,
			57364,
			58321048,
			30416477,
			31930572,
			57760639,
			10749657
		};

		// Token: 0x0400098B RID: 2443
		private static readonly int[] C_d2 = new int[]
		{
			45281625,
			27714825,
			18181821,
			13898781,
			114729,
			49533232,
			60832955,
			30306712,
			48412415,
			4722099
		};

		// Token: 0x0400098C RID: 2444
		private static readonly int[] C_d4 = new int[]
		{
			23454386,
			55429651,
			2809210,
			27797563,
			229458,
			31957600,
			54557047,
			27058993,
			29715967,
			9444199
		};

		// Token: 0x0400098D RID: 2445
		private const int WnafWidthBase = 7;

		// Token: 0x0400098E RID: 2446
		private const int PrecompBlocks = 8;

		// Token: 0x0400098F RID: 2447
		private const int PrecompTeeth = 4;

		// Token: 0x04000990 RID: 2448
		private const int PrecompSpacing = 8;

		// Token: 0x04000991 RID: 2449
		private const int PrecompPoints = 8;

		// Token: 0x04000992 RID: 2450
		private const int PrecompMask = 7;

		// Token: 0x04000993 RID: 2451
		private static readonly object precompLock = new object();

		// Token: 0x04000994 RID: 2452
		private static global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PointExt[] precompBaseTable = null;

		// Token: 0x04000995 RID: 2453
		private static int[] precompBase = null;

		// Token: 0x020007C1 RID: 1985
		public enum Algorithm
		{
			// Token: 0x040023F3 RID: 9203
			Ed25519,
			// Token: 0x040023F4 RID: 9204
			Ed25519ctx,
			// Token: 0x040023F5 RID: 9205
			Ed25519ph
		}

		// Token: 0x020007C2 RID: 1986
		private class F : global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field
		{
		}

		// Token: 0x020007C3 RID: 1987
		private class PointAccum
		{
			// Token: 0x040023F6 RID: 9206
			internal int[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();

			// Token: 0x040023F7 RID: 9207
			internal int[] y = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();

			// Token: 0x040023F8 RID: 9208
			internal int[] z = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();

			// Token: 0x040023F9 RID: 9209
			internal int[] u = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();

			// Token: 0x040023FA RID: 9210
			internal int[] v = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
		}

		// Token: 0x020007C4 RID: 1988
		private class PointAffine
		{
			// Token: 0x040023FB RID: 9211
			internal int[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();

			// Token: 0x040023FC RID: 9212
			internal int[] y = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
		}

		// Token: 0x020007C5 RID: 1989
		private class PointExt
		{
			// Token: 0x040023FD RID: 9213
			internal int[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();

			// Token: 0x040023FE RID: 9214
			internal int[] y = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();

			// Token: 0x040023FF RID: 9215
			internal int[] z = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();

			// Token: 0x04002400 RID: 9216
			internal int[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
		}

		// Token: 0x020007C6 RID: 1990
		private class PointPrecomp
		{
			// Token: 0x04002401 RID: 9217
			internal int[] ypx_h = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();

			// Token: 0x04002402 RID: 9218
			internal int[] ymx_h = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();

			// Token: 0x04002403 RID: 9219
			internal int[] xyd = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
		}
	}
}
