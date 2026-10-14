using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004CC RID: 1228
	public class Gost3411Digest : global::Org.BouncyCastle.Crypto.IDigest, global::Org.BouncyCastle.Utilities.IMemoable
	{
		// Token: 0x06002FBE RID: 12222 RVA: 0x000DF0E8 File Offset: 0x000DD2E8
		private static byte[][] MakeC()
		{
			byte[][] c = new byte[4][];
			for (int i = 0; i < 4; i++)
			{
				c[i] = new byte[32];
			}
			return c;
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x000DF114 File Offset: 0x000DD314
		public Gost3411Digest()
		{
			this.sBox = global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.GetSBox("D-A");
			this.cipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox(null, this.sBox));
			this.Reset();
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x000DF214 File Offset: 0x000DD414
		public Gost3411Digest(byte[] sBoxParam)
		{
			this.sBox = global::Org.BouncyCastle.Utilities.Arrays.Clone(sBoxParam);
			this.cipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox(null, this.sBox));
			this.Reset();
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x000DF310 File Offset: 0x000DD510
		public Gost3411Digest(global::Org.BouncyCastle.Crypto.Digests.Gost3411Digest t)
		{
			this.Reset(t);
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002FC2 RID: 12226 RVA: 0x000DF3E8 File Offset: 0x000DD5E8
		public string AlgorithmName
		{
			get
			{
				return "Gost3411";
			}
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x000DF3EF File Offset: 0x000DD5EF
		public int GetDigestSize()
		{
			return 32;
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x000DF3F4 File Offset: 0x000DD5F4
		public void Update(byte input)
		{
			byte[] array = this.xBuf;
			int num = this.xBufOff;
			this.xBufOff = num + 1;
			array[num] = input;
			if (this.xBufOff == this.xBuf.Length)
			{
				this.sumByteArray(this.xBuf);
				this.processBlock(this.xBuf, 0);
				this.xBufOff = 0;
			}
			this.byteCount += 1UL;
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x000DF45C File Offset: 0x000DD65C
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
			while (this.xBufOff != 0)
			{
				if (length <= 0)
				{
					break;
				}
				this.Update(input[inOff]);
				inOff++;
				length--;
			}
			while (length > this.xBuf.Length)
			{
				global::System.Array.Copy(input, inOff, this.xBuf, 0, this.xBuf.Length);
				this.sumByteArray(this.xBuf);
				this.processBlock(this.xBuf, 0);
				inOff += this.xBuf.Length;
				length -= this.xBuf.Length;
				this.byteCount += (ulong)this.xBuf.Length;
			}
			while (length > 0)
			{
				this.Update(input[inOff]);
				inOff++;
				length--;
			}
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x000DF510 File Offset: 0x000DD710
		private byte[] P(byte[] input)
		{
			int fourK = 0;
			for (int i = 0; i < 8; i++)
			{
				this.K[fourK++] = input[i];
				this.K[fourK++] = input[8 + i];
				this.K[fourK++] = input[16 + i];
				this.K[fourK++] = input[24 + i];
			}
			return this.K;
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x000DF578 File Offset: 0x000DD778
		private byte[] A(byte[] input)
		{
			for (int i = 0; i < 8; i++)
			{
				this.a[i] = (input[i] ^ input[i + 8]);
			}
			global::System.Array.Copy(input, 8, input, 0, 24);
			global::System.Array.Copy(this.a, 0, input, 24, 8);
			return input;
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x000DF5BF File Offset: 0x000DD7BF
		private void E(byte[] key, byte[] s, int sOff, byte[] input, int inOff)
		{
			this.cipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key));
			this.cipher.ProcessBlock(input, inOff, s, sOff);
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x000DF5E8 File Offset: 0x000DD7E8
		private void fw(byte[] input)
		{
			global::Org.BouncyCastle.Crypto.Digests.Gost3411Digest.cpyBytesToShort(input, this.wS);
			this.w_S[15] = (this.wS[0] ^ this.wS[1] ^ this.wS[2] ^ this.wS[3] ^ this.wS[12] ^ this.wS[15]);
			global::System.Array.Copy(this.wS, 1, this.w_S, 0, 15);
			global::Org.BouncyCastle.Crypto.Digests.Gost3411Digest.cpyShortToBytes(this.w_S, input);
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x000DF664 File Offset: 0x000DD864
		private void processBlock(byte[] input, int inOff)
		{
			global::System.Array.Copy(input, inOff, this.M, 0, 32);
			this.H.CopyTo(this.U, 0);
			this.M.CopyTo(this.V, 0);
			for (int i = 0; i < 32; i++)
			{
				this.W[i] = (this.U[i] ^ this.V[i]);
			}
			this.E(this.P(this.W), this.S, 0, this.H, 0);
			for (int j = 1; j < 4; j++)
			{
				byte[] tmpA = this.A(this.U);
				for (int k = 0; k < 32; k++)
				{
					this.U[k] = (tmpA[k] ^ this.C[j][k]);
				}
				this.V = this.A(this.A(this.V));
				for (int l = 0; l < 32; l++)
				{
					this.W[l] = (this.U[l] ^ this.V[l]);
				}
				this.E(this.P(this.W), this.S, j * 8, this.H, j * 8);
			}
			for (int m = 0; m < 12; m++)
			{
				this.fw(this.S);
			}
			for (int n = 0; n < 32; n++)
			{
				this.S[n] = (this.S[n] ^ this.M[n]);
			}
			this.fw(this.S);
			for (int n2 = 0; n2 < 32; n2++)
			{
				this.S[n2] = (this.H[n2] ^ this.S[n2]);
			}
			for (int n3 = 0; n3 < 61; n3++)
			{
				this.fw(this.S);
			}
			global::System.Array.Copy(this.S, 0, this.H, 0, this.H.Length);
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x000DF858 File Offset: 0x000DDA58
		private void finish()
		{
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(this.byteCount * 8UL, this.L);
			while (this.xBufOff != 0)
			{
				this.Update(0);
			}
			this.processBlock(this.L, 0);
			this.processBlock(this.Sum, 0);
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x000DF8A4 File Offset: 0x000DDAA4
		public int DoFinal(byte[] output, int outOff)
		{
			this.finish();
			this.H.CopyTo(output, outOff);
			this.Reset();
			return 32;
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x000DF8C4 File Offset: 0x000DDAC4
		public void Reset()
		{
			this.byteCount = 0UL;
			this.xBufOff = 0;
			global::System.Array.Clear(this.H, 0, this.H.Length);
			global::System.Array.Clear(this.L, 0, this.L.Length);
			global::System.Array.Clear(this.M, 0, this.M.Length);
			global::System.Array.Clear(this.C[1], 0, this.C[1].Length);
			global::System.Array.Clear(this.C[3], 0, this.C[3].Length);
			global::System.Array.Clear(this.Sum, 0, this.Sum.Length);
			global::System.Array.Clear(this.xBuf, 0, this.xBuf.Length);
			global::Org.BouncyCastle.Crypto.Digests.Gost3411Digest.C2.CopyTo(this.C[2], 0);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x000DF988 File Offset: 0x000DDB88
		private void sumByteArray(byte[] input)
		{
			int carry = 0;
			for (int i = 0; i != this.Sum.Length; i++)
			{
				int sum = (int)((this.Sum[i] & byte.MaxValue) + (input[i] & byte.MaxValue)) + carry;
				this.Sum[i] = (byte)sum;
				carry = sum >> 8;
			}
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x000DF9D4 File Offset: 0x000DDBD4
		private static void cpyBytesToShort(byte[] S, short[] wS)
		{
			for (int i = 0; i < S.Length / 2; i++)
			{
				wS[i] = (short)(((int)S[i * 2 + 1] << 8 & 65280) | (int)(S[i * 2] & byte.MaxValue));
			}
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x000DFA10 File Offset: 0x000DDC10
		private static void cpyShortToBytes(short[] wS, byte[] S)
		{
			for (int i = 0; i < S.Length / 2; i++)
			{
				S[i * 2 + 1] = (byte)(wS[i] >> 8);
				S[i * 2] = (byte)wS[i];
			}
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x000DFA43 File Offset: 0x000DDC43
		public int GetByteLength()
		{
			return 32;
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x000DFA47 File Offset: 0x000DDC47
		public global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Gost3411Digest(this);
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x000DFA50 File Offset: 0x000DDC50
		public void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.Gost3411Digest t = (global::Org.BouncyCastle.Crypto.Digests.Gost3411Digest)other;
			this.sBox = t.sBox;
			this.cipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox(null, this.sBox));
			this.Reset();
			global::System.Array.Copy(t.H, 0, this.H, 0, t.H.Length);
			global::System.Array.Copy(t.L, 0, this.L, 0, t.L.Length);
			global::System.Array.Copy(t.M, 0, this.M, 0, t.M.Length);
			global::System.Array.Copy(t.Sum, 0, this.Sum, 0, t.Sum.Length);
			global::System.Array.Copy(t.C[1], 0, this.C[1], 0, t.C[1].Length);
			global::System.Array.Copy(t.C[2], 0, this.C[2], 0, t.C[2].Length);
			global::System.Array.Copy(t.C[3], 0, this.C[3], 0, t.C[3].Length);
			global::System.Array.Copy(t.xBuf, 0, this.xBuf, 0, t.xBuf.Length);
			this.xBufOff = t.xBufOff;
			this.byteCount = t.byteCount;
		}

		// Token: 0x04001499 RID: 5273
		private const int DIGEST_LENGTH = 32;

		// Token: 0x0400149A RID: 5274
		private byte[] H = new byte[32];

		// Token: 0x0400149B RID: 5275
		private byte[] L = new byte[32];

		// Token: 0x0400149C RID: 5276
		private byte[] M = new byte[32];

		// Token: 0x0400149D RID: 5277
		private byte[] Sum = new byte[32];

		// Token: 0x0400149E RID: 5278
		private byte[][] C = global::Org.BouncyCastle.Crypto.Digests.Gost3411Digest.MakeC();

		// Token: 0x0400149F RID: 5279
		private byte[] xBuf = new byte[32];

		// Token: 0x040014A0 RID: 5280
		private int xBufOff;

		// Token: 0x040014A1 RID: 5281
		private ulong byteCount;

		// Token: 0x040014A2 RID: 5282
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher = new global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine();

		// Token: 0x040014A3 RID: 5283
		private byte[] sBox;

		// Token: 0x040014A4 RID: 5284
		private byte[] K = new byte[32];

		// Token: 0x040014A5 RID: 5285
		private byte[] a = new byte[8];

		// Token: 0x040014A6 RID: 5286
		internal short[] wS = new short[16];

		// Token: 0x040014A7 RID: 5287
		internal short[] w_S = new short[16];

		// Token: 0x040014A8 RID: 5288
		internal byte[] S = new byte[32];

		// Token: 0x040014A9 RID: 5289
		internal byte[] U = new byte[32];

		// Token: 0x040014AA RID: 5290
		internal byte[] V = new byte[32];

		// Token: 0x040014AB RID: 5291
		internal byte[] W = new byte[32];

		// Token: 0x040014AC RID: 5292
		private static readonly byte[] C2 = new byte[]
		{
			0,
			byte.MaxValue,
			0,
			byte.MaxValue,
			0,
			byte.MaxValue,
			0,
			byte.MaxValue,
			byte.MaxValue,
			0,
			byte.MaxValue,
			0,
			byte.MaxValue,
			0,
			byte.MaxValue,
			0,
			0,
			byte.MaxValue,
			byte.MaxValue,
			0,
			byte.MaxValue,
			0,
			0,
			byte.MaxValue,
			byte.MaxValue,
			0,
			0,
			0,
			byte.MaxValue,
			byte.MaxValue,
			0,
			byte.MaxValue
		};
	}
}
