using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Rfc8032
{
	// Token: 0x0200021F RID: 543
	public abstract class Ed448
	{
		// Token: 0x06001610 RID: 5648 RVA: 0x00069130 File Offset: 0x00067330
		private static byte[] CalculateS(byte[] r, byte[] k, byte[] s)
		{
			uint[] t = new uint[28];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.DecodeScalar(r, 0, t);
			uint[] u = new uint[14];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.DecodeScalar(k, 0, u);
			uint[] v = new uint[14];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.DecodeScalar(s, 0, v);
			global::Org.BouncyCastle.Math.Raw.Nat.MulAddTo(14, u, v, t);
			byte[] result = new byte[114];
			for (int i = 0; i < t.Length; i++)
			{
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Encode32(t[i], result, i * 4);
			}
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ReduceScalar(result);
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000691A6 File Offset: 0x000673A6
		private static bool CheckContextVar(byte[] ctx)
		{
			return ctx != null && ctx.Length < 256;
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000691B8 File Offset: 0x000673B8
		private static int CheckPoint(uint[] x, uint[] y)
		{
			uint[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] u = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] v = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(y, v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(u, v, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(u, v, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(t, 39081U, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.SubOne(t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(t, u, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(t);
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.IsZero(t);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x0006921C File Offset: 0x0006741C
		private static int CheckPoint(uint[] x, uint[] y, uint[] z)
		{
			uint[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] u = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] v = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] w = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(y, v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(z, w);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(u, v, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(u, v, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(u, w, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(w, w);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(t, 39081U, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(t, w, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(t, u, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(t);
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.IsZero(t);
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000692A0 File Offset: 0x000674A0
		private static bool CheckPointVar(byte[] p)
		{
			if ((p[56] & 127) != 0)
			{
				return false;
			}
			uint[] t = new uint[14];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(p, 0, t, 0, 14);
			return !global::Org.BouncyCastle.Math.Raw.Nat.Gte(14, t, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.P);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x000692DB File Offset: 0x000674DB
		private static bool CheckScalarVar(byte[] s, uint[] n)
		{
			if (s[56] != 0)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.DecodeScalar(s, 0, n);
			return !global::Org.BouncyCastle.Math.Raw.Nat.Gte(14, n, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.L);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00069300 File Offset: 0x00067500
		private static byte[] Copy(byte[] buf, int off, int len)
		{
			byte[] result = new byte[len];
			global::System.Array.Copy(buf, off, result, 0, len);
			return result;
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0006931F File Offset: 0x0006751F
		public static global::Org.BouncyCastle.Crypto.IXof CreatePrehash()
		{
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CreateXof();
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00069326 File Offset: 0x00067526
		private static global::Org.BouncyCastle.Crypto.IXof CreateXof()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.ShakeDigest(256);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00069332 File Offset: 0x00067532
		private static uint Decode16(byte[] bs, int off)
		{
			return (uint)((int)bs[off] | (int)bs[++off] << 8);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00069342 File Offset: 0x00067542
		private static uint Decode24(byte[] bs, int off)
		{
			return (uint)((int)bs[off] | (int)bs[++off] << 8 | (int)bs[++off] << 16);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0006935E File Offset: 0x0006755E
		private static uint Decode32(byte[] bs, int off)
		{
			return (uint)((int)bs[off] | (int)bs[++off] << 8 | (int)bs[++off] << 16 | (int)bs[++off] << 24);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00069388 File Offset: 0x00067588
		private static void Decode32(byte[] bs, int bsOff, uint[] n, int nOff, int nLen)
		{
			for (int i = 0; i < nLen; i++)
			{
				n[nOff + i] = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(bs, bsOff + i * 4);
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000693B4 File Offset: 0x000675B4
		private static bool DecodePointVar(byte[] p, int pOff, bool negate, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r)
		{
			byte[] py = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Copy(p, pOff, 57);
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CheckPointVar(py))
			{
				return false;
			}
			int x_0 = (py[56] & 128) >> 7;
			byte[] array = py;
			int num = 56;
			array[num] &= 127;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode(py, 0, r.y);
			uint[] u = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] v = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(r.y, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(u, 39081U, v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Negate(u, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.AddOne(u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.AddOne(v);
			if (!global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.SqrtRatioVar(u, v, r.x))
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(r.x);
			if (x_0 == 1 && global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.IsZeroVar(r.x))
			{
				return false;
			}
			if (negate ^ (long)x_0 != (long)((ulong)(r.x[0] & 1U)))
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Negate(r.x, r.x);
			}
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExtendXY(r);
			return true;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00069492 File Offset: 0x00067692
		private static void DecodeScalar(byte[] k, int kOff, uint[] n)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(k, kOff, n, 0, 14);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000694A0 File Offset: 0x000676A0
		private static void Dom4(global::Org.BouncyCastle.Crypto.IXof d, byte phflag, byte[] ctx)
		{
			int i = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Dom4Prefix.Length;
			byte[] t = new byte[i + 2 + ctx.Length];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Dom4Prefix.CopyTo(t, 0);
			t[i] = phflag;
			t[i + 1] = (byte)ctx.Length;
			ctx.CopyTo(t, i + 2);
			d.BlockUpdate(t, 0, t.Length);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000694F0 File Offset: 0x000676F0
		private static void Encode24(uint n, byte[] bs, int off)
		{
			bs[off] = (byte)n;
			bs[++off] = (byte)(n >> 8);
			bs[++off] = (byte)(n >> 16);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00069510 File Offset: 0x00067710
		private static void Encode32(uint n, byte[] bs, int off)
		{
			bs[off] = (byte)n;
			bs[++off] = (byte)(n >> 8);
			bs[++off] = (byte)(n >> 16);
			bs[++off] = (byte)(n >> 24);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0006953D File Offset: 0x0006773D
		private static void Encode56(ulong n, byte[] bs, int off)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Encode32((uint)n, bs, off);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Encode24((uint)(n >> 32), bs, off + 4);
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00069558 File Offset: 0x00067758
		private static int EncodePoint(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p, byte[] r, int rOff)
		{
			uint[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] y = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Inv(p.z, y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(p.x, y, x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(p.y, y, y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(y);
			int result = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CheckPoint(x, y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode(y, r, rOff);
			r[rOff + 57 - 1] = (byte)((x[0] & 1U) << 7);
			return result;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x000695C2 File Offset: 0x000677C2
		public static void GeneratePrivateKey(global::Org.BouncyCastle.Security.SecureRandom random, byte[] k)
		{
			random.NextBytes(k);
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x000695CC File Offset: 0x000677CC
		public static void GeneratePublicKey(byte[] sk, int skOff, byte[] pk, int pkOff)
		{
			global::Org.BouncyCastle.Crypto.IXof xof = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CreateXof();
			byte[] h = new byte[114];
			xof.BlockUpdate(sk, skOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.SecretKeySize);
			xof.DoFinal(h, 0, h.Length);
			byte[] s = new byte[57];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PruneScalar(h, 0, s);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ScalarMultBaseEncoded(s, pk, pkOff);
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00069618 File Offset: 0x00067818
		private static uint GetWindow4(uint[] x, int n)
		{
			int w = (int)((uint)n >> 3);
			int b = (n & 7) << 2;
			return x[w] >> b & 15U;
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0006963C File Offset: 0x0006783C
		private static sbyte[] GetWnafVar(uint[] n, int width)
		{
			uint[] t = new uint[28];
			uint c = 0U;
			int tPos = t.Length;
			int i = 14;
			while (--i >= 0)
			{
				uint next = n[i];
				t[--tPos] = (next >> 16 | c << 16);
				c = (t[--tPos] = next);
			}
			sbyte[] ws = new sbyte[447];
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

		// Token: 0x06001628 RID: 5672 RVA: 0x00069710 File Offset: 0x00067910
		private static void ImplSign(global::Org.BouncyCastle.Crypto.IXof d, byte[] h, byte[] s, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Dom4(d, phflag, ctx);
			d.BlockUpdate(h, 57, 57);
			d.BlockUpdate(m, mOff, mLen);
			d.DoFinal(h, 0, h.Length);
			byte[] array = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ReduceScalar(h);
			byte[] R = new byte[57];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ScalarMultBaseEncoded(array, R, 0);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Dom4(d, phflag, ctx);
			d.BlockUpdate(R, 0, 57);
			d.BlockUpdate(pk, pkOff, 57);
			d.BlockUpdate(m, mOff, mLen);
			d.DoFinal(h, 0, h.Length);
			byte[] i = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ReduceScalar(h);
			global::System.Array sourceArray = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CalculateS(array, i, s);
			global::System.Array.Copy(R, 0, sig, sigOff, 57);
			global::System.Array.Copy(sourceArray, 0, sig, sigOff + 57, 57);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x000697C4 File Offset: 0x000679C4
		private static void ImplSign(byte[] sk, int skOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CheckContextVar(ctx))
			{
				throw new global::System.ArgumentException("ctx");
			}
			global::Org.BouncyCastle.Crypto.IXof xof = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CreateXof();
			byte[] h = new byte[114];
			xof.BlockUpdate(sk, skOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.SecretKeySize);
			xof.DoFinal(h, 0, h.Length);
			byte[] s = new byte[57];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PruneScalar(h, 0, s);
			byte[] pk = new byte[57];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ScalarMultBaseEncoded(s, pk, 0);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ImplSign(xof, h, s, pk, 0, ctx, phflag, m, mOff, mLen, sig, sigOff);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00069840 File Offset: 0x00067A40
		private static void ImplSign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CheckContextVar(ctx))
			{
				throw new global::System.ArgumentException("ctx");
			}
			global::Org.BouncyCastle.Crypto.IXof xof = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CreateXof();
			byte[] h = new byte[114];
			xof.BlockUpdate(sk, skOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.SecretKeySize);
			xof.DoFinal(h, 0, h.Length);
			byte[] s = new byte[57];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PruneScalar(h, 0, s);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ImplSign(xof, h, s, pk, pkOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000698B0 File Offset: 0x00067AB0
		private static bool ImplVerify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen)
		{
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CheckContextVar(ctx))
			{
				throw new global::System.ArgumentException("ctx");
			}
			byte[] R = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Copy(sig, sigOff, 57);
			byte[] S = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Copy(sig, sigOff + 57, 57);
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CheckPointVar(R))
			{
				return false;
			}
			uint[] nS = new uint[14];
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CheckScalarVar(S, nS))
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt pA = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt();
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.DecodePointVar(pk, pkOff, true, pA))
			{
				return false;
			}
			global::Org.BouncyCastle.Crypto.IXof xof = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CreateXof();
			byte[] h = new byte[114];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Dom4(xof, phflag, ctx);
			xof.BlockUpdate(R, 0, 57);
			xof.BlockUpdate(pk, pkOff, 57);
			xof.BlockUpdate(m, mOff, mLen);
			xof.DoFinal(h, 0, h.Length);
			byte[] k = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ReduceScalar(h);
			uint[] nA = new uint[14];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.DecodeScalar(k, 0, nA);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt pR = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ScalarMultStrausVar(nS, nA, pA, pR);
			byte[] check = new byte[57];
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.EncodePoint(pR, check, 0) != 0 && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(check, R);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000699A6 File Offset: 0x00067BA6
		private static bool IsNeutralElementVar(uint[] x, uint[] y)
		{
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.IsZeroVar(x) && global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.IsOneVar(y);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000699B8 File Offset: 0x00067BB8
		private static bool IsNeutralElementVar(uint[] x, uint[] y, uint[] z)
		{
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.IsZeroVar(x) && global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.AreEqualVar(y, z);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000699CC File Offset: 0x00067BCC
		private static void PointAdd(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r)
		{
			uint[] a = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] c = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] d = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] e = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] f = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] g = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] h = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(p.z, r.z, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(a, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(p.x, r.x, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(p.y, r.y, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(c, d, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(e, 39081U, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(b, e, f);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(b, e, g);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(p.x, p.y, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(r.x, r.y, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(b, e, h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(d, c, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(d, c, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Carry(b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(h, b, h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(h, a, h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(e, a, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(f, h, r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(e, g, r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(f, g, r.z);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00069B08 File Offset: 0x00067D08
		private static void PointAddVar(bool negate, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r)
		{
			uint[] a = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] c = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] d = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] e = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] f = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] g = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] h = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] nb;
			uint[] ne;
			uint[] nf;
			uint[] ng;
			if (negate)
			{
				nb = e;
				ne = b;
				nf = g;
				ng = f;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(p.y, p.x, h);
			}
			else
			{
				nb = b;
				ne = e;
				nf = f;
				ng = g;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(p.y, p.x, h);
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(p.z, r.z, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(a, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(p.x, r.x, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(p.y, r.y, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(c, d, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(e, 39081U, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(b, e, nf);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(b, e, ng);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(r.x, r.y, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(h, e, h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(d, c, nb);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(d, c, ne);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Carry(nb);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(h, b, h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(h, a, h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(e, a, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(f, h, r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(e, g, r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(f, g, r.z);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00069C7C File Offset: 0x00067E7C
		private static void PointAddPrecomp(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointPrecomp p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r)
		{
			uint[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] c = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] d = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] e = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] f = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] g = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] h = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(r.z, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(p.x, r.x, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(p.y, r.y, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(c, d, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(e, 39081U, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(b, e, f);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(b, e, g);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(p.x, p.y, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(r.x, r.y, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(b, e, h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(d, c, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(d, c, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Carry(b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(h, b, h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(h, r.z, h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(e, r.z, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(f, h, r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(e, g, r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(f, g, r.z);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00069DA4 File Offset: 0x00067FA4
		private static global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt PointCopy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointCopy(p, r);
			return r;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00069DBF File Offset: 0x00067FBF
		private static void PointCopy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(p.x, 0, r.x, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(p.y, 0, r.y, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(p.z, 0, r.z, 0);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00069DFC File Offset: 0x00067FFC
		private static void PointDouble(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r)
		{
			uint[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] c = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] d = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] e = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] h = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] i = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(r.x, r.y, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(b, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(r.x, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(r.y, d);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(c, d, e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Carry(e);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(r.z, h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(h, h, h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Carry(h);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(e, h, i);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(b, e, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(c, d, c);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(b, i, r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(e, c, r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(e, i, r.z);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00069ED0 File Offset: 0x000680D0
		private static void PointExtendXY(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.One(p.z);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00069EE0 File Offset: 0x000680E0
		private static void PointLookup(int block, int index, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointPrecomp p)
		{
			int off = block * 16 * 2 * 16;
			for (int i = 0; i < 16; i++)
			{
				int cond = (i ^ index) - 1 >> 31;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CMov(cond, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.precompBase, off, p.x, 0);
				off += 16;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CMov(cond, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.precompBase, off, p.y, 0);
				off += 16;
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00069F3C File Offset: 0x0006813C
		private static void PointLookup(uint[] x, int n, uint[] table, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r)
		{
			uint window = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.GetWindow4(x, n);
			int sign = (int)(window >> 3 ^ 1U);
			int abs = (int)((window ^ (uint)(-(uint)sign)) & 7U);
			int i = 0;
			int off = 0;
			while (i < 8)
			{
				int cond = (i ^ abs) - 1 >> 31;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CMov(cond, table, off, r.x, 0);
				off += 16;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CMov(cond, table, off, r.y, 0);
				off += 16;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CMov(cond, table, off, r.z, 0);
				off += 16;
				i++;
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CNegate(sign, r.x);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00069FBC File Offset: 0x000681BC
		private static uint[] PointPrecompute(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p, int count)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt q = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointCopy(p);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt d = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointCopy(q);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointDouble(d);
			uint[] table = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CreateTable(count * 3);
			int off = 0;
			int i = 0;
			for (;;)
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(q.x, 0, table, off);
				off += 16;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(q.y, 0, table, off);
				off += 16;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(q.z, 0, table, off);
				off += 16;
				if (++i == count)
				{
					break;
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointAdd(d, q);
			}
			return table;
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0006A038 File Offset: 0x00068238
		private static global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt[] PointPrecomputeVar(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p, int count)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt d = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointCopy(p);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointDouble(d);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt[] table = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt[count];
			table[0] = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointCopy(p);
			for (int i = 1; i < count; i++)
			{
				table[i] = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointCopy(table[i - 1]);
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointAddVar(false, d, table[i]);
			}
			return table;
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0006A086 File Offset: 0x00068286
		private static void PointSetNeutral(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Zero(p.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.One(p.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.One(p.z);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0006A0AC File Offset: 0x000682AC
		public static void Precompute()
		{
			object obj = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.precompLock;
			lock (obj)
			{
				if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.precompBase == null)
				{
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt();
					global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.B_x, 0, p.x, 0);
					global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.B_y, 0, p.y, 0);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExtendXY(p);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.precompBaseTable = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointPrecomputeVar(p, 32);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.precompBase = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CreateTable(160);
					int off = 0;
					for (int b = 0; b < 5; b++)
					{
						global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt[] ds = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt[5];
						global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt sum = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt();
						global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointSetNeutral(sum);
						for (int t = 0; t < 5; t++)
						{
							global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointAddVar(true, p, sum);
							global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointDouble(p);
							ds[t] = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointCopy(p);
							if (b + t != 8)
							{
								for (int s = 1; s < 18; s++)
								{
									global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointDouble(p);
								}
							}
						}
						global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt[] points = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt[16];
						int i = 0;
						points[i++] = sum;
						for (int t2 = 0; t2 < 4; t2++)
						{
							int size = 1 << t2;
							int j = 0;
							while (j < size)
							{
								points[i] = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointCopy(points[i - size]);
								global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointAddVar(false, ds[t2], points[i]);
								j++;
								i++;
							}
						}
						uint[] cs = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CreateTable(16);
						uint[] u = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
						global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(points[0].z, 0, u, 0);
						global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(u, 0, cs, 0);
						int k = 0;
						while (++k < 16)
						{
							global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(u, points[k].z, u);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(u, 0, cs, k * 16);
						}
						global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.InvVar(u, u);
						k--;
						uint[] t3 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
						while (k > 0)
						{
							int l = k--;
							global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(cs, k * 16, t3, 0);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(t3, u, t3);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(t3, 0, cs, l * 16);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(u, points[l].z, u);
						}
						global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(u, 0, cs, 0);
						for (int m = 0; m < 16; m++)
						{
							global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt q = points[m];
							global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(cs, m * 16, q.z, 0);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(q.x, q.z, q.x);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(q.y, q.z, q.y);
							global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(q.x, 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.precompBase, off);
							off += 16;
							global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(q.y, 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.precompBase, off);
							off += 16;
						}
					}
				}
			}
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0006A38C File Offset: 0x0006858C
		private static void PruneScalar(byte[] n, int nOff, byte[] r)
		{
			global::System.Array.Copy(n, nOff, r, 0, 56);
			int num = 0;
			r[num] &= 252;
			int num2 = 55;
			r[num2] |= 128;
			r[56] = 0;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x0006A3C4 File Offset: 0x000685C4
		private static byte[] ReduceScalar(byte[] n)
		{
			ulong x0 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 0);
			ulong x = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 4) << 4);
			ulong x2 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 7);
			ulong x3 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 11) << 4);
			ulong x4 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 14);
			ulong x5 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 18) << 4);
			ulong x6 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 21);
			ulong x7 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 25) << 4);
			ulong x8 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 28);
			ulong x9 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 32) << 4);
			ulong x10 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 35);
			ulong x11 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 39) << 4);
			ulong x12 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 42);
			ulong x13 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 46) << 4);
			ulong x14 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 49);
			ulong x15 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 53) << 4);
			ulong x16 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 56);
			ulong x17 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 60) << 4);
			ulong x18 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 63);
			ulong x19 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 67) << 4);
			ulong x20 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 70);
			ulong x21 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 74) << 4);
			ulong x22 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 77);
			ulong x23 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 81) << 4);
			ulong x24 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 84);
			ulong x25 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 88) << 4);
			ulong x26 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 91);
			ulong x27 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 95) << 4);
			ulong x28 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 98);
			ulong x29 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 102) << 4);
			ulong x30 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode32(n, 105);
			ulong x31 = (ulong)((ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode24(n, 109) << 4);
			ulong x32 = (ulong)global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Decode16(n, 112);
			x16 += x32 * 43969588UL;
			x17 += x32 * 30366549UL;
			x18 += x32 * 163752818UL;
			x19 += x32 * 258169998UL;
			x20 += x32 * 96434764UL;
			x21 += x32 * 227822194UL;
			x22 += x32 * 149865618UL;
			x23 += x32 * 550336261UL;
			x31 += x30 >> 28;
			x30 &= 268435455UL;
			x15 += x31 * 43969588UL;
			x16 += x31 * 30366549UL;
			x17 += x31 * 163752818UL;
			x18 += x31 * 258169998UL;
			x19 += x31 * 96434764UL;
			x20 += x31 * 227822194UL;
			x21 += x31 * 149865618UL;
			x22 += x31 * 550336261UL;
			x14 += x30 * 43969588UL;
			x15 += x30 * 30366549UL;
			x16 += x30 * 163752818UL;
			x17 += x30 * 258169998UL;
			x18 += x30 * 96434764UL;
			x19 += x30 * 227822194UL;
			x20 += x30 * 149865618UL;
			x21 += x30 * 550336261UL;
			x29 += x28 >> 28;
			x28 &= 268435455UL;
			x13 += x29 * 43969588UL;
			x14 += x29 * 30366549UL;
			x15 += x29 * 163752818UL;
			x16 += x29 * 258169998UL;
			x17 += x29 * 96434764UL;
			x18 += x29 * 227822194UL;
			x19 += x29 * 149865618UL;
			x20 += x29 * 550336261UL;
			x12 += x28 * 43969588UL;
			x13 += x28 * 30366549UL;
			x14 += x28 * 163752818UL;
			x15 += x28 * 258169998UL;
			x16 += x28 * 96434764UL;
			x17 += x28 * 227822194UL;
			x18 += x28 * 149865618UL;
			x19 += x28 * 550336261UL;
			x27 += x26 >> 28;
			x26 &= 268435455UL;
			x11 += x27 * 43969588UL;
			x12 += x27 * 30366549UL;
			x13 += x27 * 163752818UL;
			x14 += x27 * 258169998UL;
			x15 += x27 * 96434764UL;
			x16 += x27 * 227822194UL;
			x17 += x27 * 149865618UL;
			x18 += x27 * 550336261UL;
			x10 += x26 * 43969588UL;
			x11 += x26 * 30366549UL;
			x12 += x26 * 163752818UL;
			x13 += x26 * 258169998UL;
			x14 += x26 * 96434764UL;
			x15 += x26 * 227822194UL;
			x16 += x26 * 149865618UL;
			x17 += x26 * 550336261UL;
			x25 += x24 >> 28;
			x24 &= 268435455UL;
			x9 += x25 * 43969588UL;
			x10 += x25 * 30366549UL;
			x11 += x25 * 163752818UL;
			x12 += x25 * 258169998UL;
			x13 += x25 * 96434764UL;
			x14 += x25 * 227822194UL;
			x15 += x25 * 149865618UL;
			x16 += x25 * 550336261UL;
			x21 += x20 >> 28;
			x20 &= 268435455UL;
			x22 += x21 >> 28;
			x21 &= 268435455UL;
			x23 += x22 >> 28;
			x22 &= 268435455UL;
			x24 += x23 >> 28;
			x23 &= 268435455UL;
			x8 += x24 * 43969588UL;
			x9 += x24 * 30366549UL;
			x10 += x24 * 163752818UL;
			x11 += x24 * 258169998UL;
			x12 += x24 * 96434764UL;
			x13 += x24 * 227822194UL;
			x14 += x24 * 149865618UL;
			x15 += x24 * 550336261UL;
			x7 += x23 * 43969588UL;
			x8 += x23 * 30366549UL;
			x9 += x23 * 163752818UL;
			x10 += x23 * 258169998UL;
			x11 += x23 * 96434764UL;
			x12 += x23 * 227822194UL;
			x13 += x23 * 149865618UL;
			x14 += x23 * 550336261UL;
			x6 += x22 * 43969588UL;
			x7 += x22 * 30366549UL;
			x8 += x22 * 163752818UL;
			x9 += x22 * 258169998UL;
			x10 += x22 * 96434764UL;
			x11 += x22 * 227822194UL;
			x12 += x22 * 149865618UL;
			x13 += x22 * 550336261UL;
			x18 += x17 >> 28;
			x17 &= 268435455UL;
			x19 += x18 >> 28;
			x18 &= 268435455UL;
			x20 += x19 >> 28;
			x19 &= 268435455UL;
			x21 += x20 >> 28;
			x20 &= 268435455UL;
			x5 += x21 * 43969588UL;
			x6 += x21 * 30366549UL;
			x7 += x21 * 163752818UL;
			x8 += x21 * 258169998UL;
			x9 += x21 * 96434764UL;
			x10 += x21 * 227822194UL;
			x11 += x21 * 149865618UL;
			x12 += x21 * 550336261UL;
			x4 += x20 * 43969588UL;
			x5 += x20 * 30366549UL;
			x6 += x20 * 163752818UL;
			x7 += x20 * 258169998UL;
			x8 += x20 * 96434764UL;
			x9 += x20 * 227822194UL;
			x10 += x20 * 149865618UL;
			x11 += x20 * 550336261UL;
			x3 += x19 * 43969588UL;
			x4 += x19 * 30366549UL;
			x5 += x19 * 163752818UL;
			x6 += x19 * 258169998UL;
			x7 += x19 * 96434764UL;
			x8 += x19 * 227822194UL;
			x9 += x19 * 149865618UL;
			x10 += x19 * 550336261UL;
			x15 += x14 >> 28;
			x14 &= 268435455UL;
			x16 += x15 >> 28;
			x15 &= 268435455UL;
			x17 += x16 >> 28;
			x16 &= 268435455UL;
			x18 += x17 >> 28;
			x17 &= 268435455UL;
			x2 += x18 * 43969588UL;
			x3 += x18 * 30366549UL;
			x4 += x18 * 163752818UL;
			x5 += x18 * 258169998UL;
			x6 += x18 * 96434764UL;
			x7 += x18 * 227822194UL;
			x8 += x18 * 149865618UL;
			x9 += x18 * 550336261UL;
			x += x17 * 43969588UL;
			x2 += x17 * 30366549UL;
			x3 += x17 * 163752818UL;
			x4 += x17 * 258169998UL;
			x5 += x17 * 96434764UL;
			x6 += x17 * 227822194UL;
			x7 += x17 * 149865618UL;
			x8 += x17 * 550336261UL;
			x16 *= 4UL;
			x16 += x15 >> 26;
			x15 &= 67108863UL;
			x16 += 1UL;
			x0 += x16 * 78101261UL;
			x += x16 * 141809365UL;
			x2 += x16 * 175155932UL;
			x3 += x16 * 64542499UL;
			x4 += x16 * 158326419UL;
			x5 += x16 * 191173276UL;
			x6 += x16 * 104575268UL;
			x7 += x16 * 137584065UL;
			x += x0 >> 28;
			x0 &= 268435455UL;
			x2 += x >> 28;
			x &= 268435455UL;
			x3 += x2 >> 28;
			x2 &= 268435455UL;
			x4 += x3 >> 28;
			x3 &= 268435455UL;
			x5 += x4 >> 28;
			x4 &= 268435455UL;
			x6 += x5 >> 28;
			x5 &= 268435455UL;
			x7 += x6 >> 28;
			x6 &= 268435455UL;
			x8 += x7 >> 28;
			x7 &= 268435455UL;
			x9 += x8 >> 28;
			x8 &= 268435455UL;
			x10 += x9 >> 28;
			x9 &= 268435455UL;
			x11 += x10 >> 28;
			x10 &= 268435455UL;
			x12 += x11 >> 28;
			x11 &= 268435455UL;
			x13 += x12 >> 28;
			x12 &= 268435455UL;
			x14 += x13 >> 28;
			x13 &= 268435455UL;
			x15 += x14 >> 28;
			x14 &= 268435455UL;
			x16 = x15 >> 26;
			x15 &= 67108863UL;
			x16 -= 1UL;
			x0 -= (x16 & 78101261UL);
			x -= (x16 & 141809365UL);
			x2 -= (x16 & 175155932UL);
			x3 -= (x16 & 64542499UL);
			x4 -= (x16 & 158326419UL);
			x5 -= (x16 & 191173276UL);
			x6 -= (x16 & 104575268UL);
			x7 -= (x16 & 137584065UL);
			x += x0 >> 28;
			x0 &= 268435455UL;
			x2 += x >> 28;
			x &= 268435455UL;
			x3 += x2 >> 28;
			x2 &= 268435455UL;
			x4 += x3 >> 28;
			x3 &= 268435455UL;
			x5 += x4 >> 28;
			x4 &= 268435455UL;
			x6 += x5 >> 28;
			x5 &= 268435455UL;
			x7 += x6 >> 28;
			x6 &= 268435455UL;
			x8 += x7 >> 28;
			x7 &= 268435455UL;
			x9 += x8 >> 28;
			x8 &= 268435455UL;
			x10 += x9 >> 28;
			x9 &= 268435455UL;
			x11 += x10 >> 28;
			x10 &= 268435455UL;
			x12 += x11 >> 28;
			x11 &= 268435455UL;
			x13 += x12 >> 28;
			x12 &= 268435455UL;
			x14 += x13 >> 28;
			x13 &= 268435455UL;
			x15 += x14 >> 28;
			x14 &= 268435455UL;
			byte[] r = new byte[57];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Encode56(x0 | x << 28, r, 0);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Encode56(x2 | x3 << 28, r, 7);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Encode56(x4 | x5 << 28, r, 14);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Encode56(x6 | x7 << 28, r, 21);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Encode56(x8 | x9 << 28, r, 28);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Encode56(x10 | x11 << 28, r, 35);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Encode56(x12 | x13 << 28, r, 42);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Encode56(x14 | x15 << 28, r, 49);
			return r;
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0006B184 File Offset: 0x00069384
		private static void ScalarMult(byte[] k, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r)
		{
			uint[] i = new uint[14];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.DecodeScalar(k, 0, i);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBits(14, i, 2, 0U);
			global::Org.BouncyCastle.Math.Raw.Nat.CAdd(14, (int)(~i[0] & 1U), i, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.L, i);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(14, i, 1U);
			uint[] table = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointPrecompute(p, 8);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt q = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointLookup(i, 111, table, r);
			for (int w = 110; w >= 0; w--)
			{
				for (int j = 0; j < 4; j++)
				{
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointDouble(r);
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointLookup(i, w, table, q);
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointAdd(q, r);
			}
			for (int l = 0; l < 2; l++)
			{
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointDouble(r);
			}
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0006B22C File Offset: 0x0006942C
		private static void ScalarMultBase(byte[] k, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Precompute();
			uint[] i = new uint[15];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.DecodeScalar(k, 0, i);
			i[14] = 4U + global::Org.BouncyCastle.Math.Raw.Nat.CAdd(14, (int)(~i[0] & 1U), i, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.L, i);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(i.Length, i, 0U);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointPrecomp p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointPrecomp();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointSetNeutral(r);
			int cOff = 17;
			for (;;)
			{
				int tPos = cOff;
				for (int b = 0; b < 5; b++)
				{
					uint w = 0U;
					for (int t = 0; t < 5; t++)
					{
						uint tBit = i[tPos >> 5] >> tPos;
						w &= ~(1U << t);
						w ^= tBit << t;
						tPos += 18;
					}
					int sign = (int)(w >> 4 & 1U);
					int abs = (int)((w ^ (uint)(-(uint)sign)) & 15U);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointLookup(b, abs, p);
					global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CNegate(sign, p.x);
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointAddPrecomp(p, r);
				}
				if (--cOff < 0)
				{
					break;
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointDouble(r);
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0006B31C File Offset: 0x0006951C
		private static void ScalarMultBaseEncoded(byte[] k, byte[] r, int rOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ScalarMultBase(k, p);
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.EncodePoint(p, r, rOff) == 0)
			{
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0006B348 File Offset: 0x00069548
		internal static void ScalarMultBaseXY(byte[] k, int kOff, uint[] x, uint[] y)
		{
			byte[] i = new byte[57];
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PruneScalar(k, kOff, i);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ScalarMultBase(i, p);
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CheckPoint(p.x, p.y, p.z) == 0)
			{
				throw new global::System.InvalidOperationException();
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(p.x, 0, x, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(p.y, 0, y, 0);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0006B3B0 File Offset: 0x000695B0
		private static void ScalarMultOrderVar(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r)
		{
			int width = 5;
			sbyte[] ws_p = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.GetWnafVar(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.L, width);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt[] tp = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointPrecomputeVar(p, 1 << width - 2);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointSetNeutral(r);
			int bit = 446;
			for (;;)
			{
				int wp = (int)ws_p[bit];
				if (wp != 0)
				{
					int sign = wp >> 31;
					int index = (wp ^ sign) >> 1;
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointAddVar(sign != 0, tp[index], r);
				}
				if (--bit < 0)
				{
					break;
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointDouble(r);
			}
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0006B420 File Offset: 0x00069620
		private static void ScalarMultStrausVar(uint[] nb, uint[] np, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Precompute();
			int width = 5;
			sbyte[] ws_b = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.GetWnafVar(nb, 7);
			sbyte[] ws_p = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.GetWnafVar(np, width);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt[] tp = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointPrecomputeVar(p, 1 << width - 2);
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointSetNeutral(r);
			int bit = 446;
			for (;;)
			{
				int wb = (int)ws_b[bit];
				if (wb != 0)
				{
					int sign = wb >> 31;
					int index = (wb ^ sign) >> 1;
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointAddVar(sign != 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.precompBaseTable[index], r);
				}
				int wp = (int)ws_p[bit];
				if (wp != 0)
				{
					int sign2 = wp >> 31;
					int index2 = (wp ^ sign2) >> 1;
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointAddVar(sign2 != 0, tp[index2], r);
				}
				if (--bit < 0)
				{
					break;
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointDouble(r);
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0006B4C8 File Offset: 0x000696C8
		public static void Sign(byte[] sk, int skOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			byte phflag = 0;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ImplSign(sk, skOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0006B4EC File Offset: 0x000696EC
		public static void Sign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
		{
			byte phflag = 0;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ImplSign(sk, skOff, pk, pkOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0006B514 File Offset: 0x00069714
		public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, byte[] ph, int phOff, byte[] sig, int sigOff)
		{
			byte phflag = 1;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ImplSign(sk, skOff, ctx, phflag, ph, phOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize, sig, sigOff);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0006B538 File Offset: 0x00069738
		public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte[] ph, int phOff, byte[] sig, int sigOff)
		{
			byte phflag = 1;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ImplSign(sk, skOff, pk, pkOff, ctx, phflag, ph, phOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize, sig, sigOff);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0006B560 File Offset: 0x00069760
		public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, global::Org.BouncyCastle.Crypto.IXof ph, byte[] sig, int sigOff)
		{
			byte[] i = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize];
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize != ph.DoFinal(i, 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize))
			{
				throw new global::System.ArgumentException("ph");
			}
			byte phflag = 1;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ImplSign(sk, skOff, ctx, phflag, i, 0, i.Length, sig, sigOff);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0006B5AC File Offset: 0x000697AC
		public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, global::Org.BouncyCastle.Crypto.IXof ph, byte[] sig, int sigOff)
		{
			byte[] i = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize];
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize != ph.DoFinal(i, 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize))
			{
				throw new global::System.ArgumentException("ph");
			}
			byte phflag = 1;
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ImplSign(sk, skOff, pk, pkOff, ctx, phflag, i, 0, i.Length, sig, sigOff);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0006B5FC File Offset: 0x000697FC
		public static bool ValidatePublicKeyFull(byte[] pk, int pkOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt();
			if (!global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.DecodePointVar(pk, pkOff, false, p))
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(p.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(p.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(p.z);
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.IsNeutralElementVar(p.x, p.y, p.z))
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt r = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ScalarMultOrderVar(p, r);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(r.x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(r.y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(r.z);
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.IsNeutralElementVar(r.x, r.y, r.z);
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0006B6A0 File Offset: 0x000698A0
		public static bool ValidatePublicKeyPartial(byte[] pk, int pkOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt p = new global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt();
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.DecodePointVar(pk, pkOff, false, p);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0006B6BC File Offset: 0x000698BC
		public static bool Verify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen)
		{
			byte phflag = 0;
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, m, mOff, mLen);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0006B6E0 File Offset: 0x000698E0
		public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte[] ph, int phOff)
		{
			byte phflag = 1;
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, ph, phOff, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0006B704 File Offset: 0x00069904
		public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, global::Org.BouncyCastle.Crypto.IXof ph)
		{
			byte[] i = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize];
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize != ph.DoFinal(i, 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize))
			{
				throw new global::System.ArgumentException("ph");
			}
			byte phflag = 1;
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, i, 0, i.Length);
		}

		// Token: 0x04000996 RID: 2454
		private const ulong M26UL = 67108863UL;

		// Token: 0x04000997 RID: 2455
		private const ulong M28UL = 268435455UL;

		// Token: 0x04000998 RID: 2456
		private const int CoordUints = 14;

		// Token: 0x04000999 RID: 2457
		private const int PointBytes = 57;

		// Token: 0x0400099A RID: 2458
		private const int ScalarUints = 14;

		// Token: 0x0400099B RID: 2459
		private const int ScalarBytes = 57;

		// Token: 0x0400099C RID: 2460
		public static readonly int PrehashSize = 64;

		// Token: 0x0400099D RID: 2461
		public static readonly int PublicKeySize = 57;

		// Token: 0x0400099E RID: 2462
		public static readonly int SecretKeySize = 57;

		// Token: 0x0400099F RID: 2463
		public static readonly int SignatureSize = 114;

		// Token: 0x040009A0 RID: 2464
		private static readonly byte[] Dom4Prefix = new byte[]
		{
			83,
			105,
			103,
			69,
			100,
			52,
			52,
			56
		};

		// Token: 0x040009A1 RID: 2465
		private static readonly uint[] P = new uint[]
		{
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x040009A2 RID: 2466
		private static readonly uint[] L = new uint[]
		{
			2874688755U,
			595116690U,
			2378534741U,
			560775794U,
			2933274256U,
			3293502281U,
			2093622249U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			1073741823U
		};

		// Token: 0x040009A3 RID: 2467
		private const int L_0 = 78101261;

		// Token: 0x040009A4 RID: 2468
		private const int L_1 = 141809365;

		// Token: 0x040009A5 RID: 2469
		private const int L_2 = 175155932;

		// Token: 0x040009A6 RID: 2470
		private const int L_3 = 64542499;

		// Token: 0x040009A7 RID: 2471
		private const int L_4 = 158326419;

		// Token: 0x040009A8 RID: 2472
		private const int L_5 = 191173276;

		// Token: 0x040009A9 RID: 2473
		private const int L_6 = 104575268;

		// Token: 0x040009AA RID: 2474
		private const int L_7 = 137584065;

		// Token: 0x040009AB RID: 2475
		private const int L4_0 = 43969588;

		// Token: 0x040009AC RID: 2476
		private const int L4_1 = 30366549;

		// Token: 0x040009AD RID: 2477
		private const int L4_2 = 163752818;

		// Token: 0x040009AE RID: 2478
		private const int L4_3 = 258169998;

		// Token: 0x040009AF RID: 2479
		private const int L4_4 = 96434764;

		// Token: 0x040009B0 RID: 2480
		private const int L4_5 = 227822194;

		// Token: 0x040009B1 RID: 2481
		private const int L4_6 = 149865618;

		// Token: 0x040009B2 RID: 2482
		private const int L4_7 = 550336261;

		// Token: 0x040009B3 RID: 2483
		private static readonly uint[] B_x = new uint[]
		{
			118276190U,
			40534716U,
			9670182U,
			135141552U,
			85017403U,
			259173222U,
			68333082U,
			171784774U,
			174973732U,
			15824510U,
			73756743U,
			57518561U,
			94773951U,
			248652241U,
			107736333U,
			82941708U
		};

		// Token: 0x040009B4 RID: 2484
		private static readonly uint[] B_y = new uint[]
		{
			36764180U,
			8885695U,
			130592152U,
			20104429U,
			163904957U,
			30304195U,
			121295871U,
			5901357U,
			125344798U,
			171541512U,
			175338348U,
			209069246U,
			3626697U,
			38307682U,
			24032956U,
			110359655U
		};

		// Token: 0x040009B5 RID: 2485
		private const int C_d = -39081;

		// Token: 0x040009B6 RID: 2486
		private const int WnafWidthBase = 7;

		// Token: 0x040009B7 RID: 2487
		private const int PrecompBlocks = 5;

		// Token: 0x040009B8 RID: 2488
		private const int PrecompTeeth = 5;

		// Token: 0x040009B9 RID: 2489
		private const int PrecompSpacing = 18;

		// Token: 0x040009BA RID: 2490
		private const int PrecompPoints = 16;

		// Token: 0x040009BB RID: 2491
		private const int PrecompMask = 15;

		// Token: 0x040009BC RID: 2492
		private static readonly object precompLock = new object();

		// Token: 0x040009BD RID: 2493
		private static global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PointExt[] precompBaseTable = null;

		// Token: 0x040009BE RID: 2494
		private static uint[] precompBase = null;

		// Token: 0x020007C7 RID: 1991
		public enum Algorithm
		{
			// Token: 0x04002405 RID: 9221
			Ed448,
			// Token: 0x04002406 RID: 9222
			Ed448ph
		}

		// Token: 0x020007C8 RID: 1992
		private class F : global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field
		{
		}

		// Token: 0x020007C9 RID: 1993
		private class PointExt
		{
			// Token: 0x04002407 RID: 9223
			internal uint[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();

			// Token: 0x04002408 RID: 9224
			internal uint[] y = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();

			// Token: 0x04002409 RID: 9225
			internal uint[] z = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
		}

		// Token: 0x020007CA RID: 1994
		private class PointPrecomp
		{
			// Token: 0x0400240A RID: 9226
			internal uint[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();

			// Token: 0x0400240B RID: 9227
			internal uint[] y = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
		}
	}
}
