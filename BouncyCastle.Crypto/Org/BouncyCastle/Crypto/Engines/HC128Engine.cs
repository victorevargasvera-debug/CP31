using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200049E RID: 1182
	public class HC128Engine : global::Org.BouncyCastle.Crypto.IStreamCipher
	{
		// Token: 0x06002D8A RID: 11658 RVA: 0x000CCA70 File Offset: 0x000CAC70
		private static uint F1(uint x)
		{
			return global::Org.BouncyCastle.Crypto.Engines.HC128Engine.RotateRight(x, 7) ^ global::Org.BouncyCastle.Crypto.Engines.HC128Engine.RotateRight(x, 18) ^ x >> 3;
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x000CCA86 File Offset: 0x000CAC86
		private static uint F2(uint x)
		{
			return global::Org.BouncyCastle.Crypto.Engines.HC128Engine.RotateRight(x, 17) ^ global::Org.BouncyCastle.Crypto.Engines.HC128Engine.RotateRight(x, 19) ^ x >> 10;
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x000CCA9E File Offset: 0x000CAC9E
		private uint G1(uint x, uint y, uint z)
		{
			return (global::Org.BouncyCastle.Crypto.Engines.HC128Engine.RotateRight(x, 10) ^ global::Org.BouncyCastle.Crypto.Engines.HC128Engine.RotateRight(z, 23)) + global::Org.BouncyCastle.Crypto.Engines.HC128Engine.RotateRight(y, 8);
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x000CCAB9 File Offset: 0x000CACB9
		private uint G2(uint x, uint y, uint z)
		{
			return (global::Org.BouncyCastle.Crypto.Engines.HC128Engine.RotateLeft(x, 10) ^ global::Org.BouncyCastle.Crypto.Engines.HC128Engine.RotateLeft(z, 23)) + global::Org.BouncyCastle.Crypto.Engines.HC128Engine.RotateLeft(y, 8);
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x000CCAD4 File Offset: 0x000CACD4
		private static uint RotateLeft(uint x, int bits)
		{
			return x << bits | x >> -bits;
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x000CCAE4 File Offset: 0x000CACE4
		private static uint RotateRight(uint x, int bits)
		{
			return x >> bits | x << -bits;
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x000CCAF4 File Offset: 0x000CACF4
		private uint H1(uint x)
		{
			return this.q[(int)(x & 255U)] + this.q[(int)((x >> 16 & 255U) + 256U)];
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x000CCB1C File Offset: 0x000CAD1C
		private uint H2(uint x)
		{
			return this.p[(int)(x & 255U)] + this.p[(int)((x >> 16 & 255U) + 256U)];
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x000CCB44 File Offset: 0x000CAD44
		private static uint Mod1024(uint x)
		{
			return x & 1023U;
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x000CCB4D File Offset: 0x000CAD4D
		private static uint Mod512(uint x)
		{
			return x & 511U;
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x000CCB56 File Offset: 0x000CAD56
		private static uint Dim(uint x, uint y)
		{
			return global::Org.BouncyCastle.Crypto.Engines.HC128Engine.Mod512(x - y);
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x000CCB60 File Offset: 0x000CAD60
		private uint Step()
		{
			uint i = global::Org.BouncyCastle.Crypto.Engines.HC128Engine.Mod512(this.cnt);
			uint ret;
			if (this.cnt < 512U)
			{
				this.p[(int)i] += this.G1(this.p[(int)global::Org.BouncyCastle.Crypto.Engines.HC128Engine.Dim(i, 3U)], this.p[(int)global::Org.BouncyCastle.Crypto.Engines.HC128Engine.Dim(i, 10U)], this.p[(int)global::Org.BouncyCastle.Crypto.Engines.HC128Engine.Dim(i, 511U)]);
				ret = (this.H1(this.p[(int)global::Org.BouncyCastle.Crypto.Engines.HC128Engine.Dim(i, 12U)]) ^ this.p[(int)i]);
			}
			else
			{
				this.q[(int)i] += this.G2(this.q[(int)global::Org.BouncyCastle.Crypto.Engines.HC128Engine.Dim(i, 3U)], this.q[(int)global::Org.BouncyCastle.Crypto.Engines.HC128Engine.Dim(i, 10U)], this.q[(int)global::Org.BouncyCastle.Crypto.Engines.HC128Engine.Dim(i, 511U)]);
				ret = (this.H2(this.q[(int)global::Org.BouncyCastle.Crypto.Engines.HC128Engine.Dim(i, 12U)]) ^ this.q[(int)i]);
			}
			this.cnt = global::Org.BouncyCastle.Crypto.Engines.HC128Engine.Mod1024(this.cnt + 1U);
			return ret;
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x000CCC64 File Offset: 0x000CAE64
		private void Init()
		{
			if (this.key.Length != 16)
			{
				throw new global::System.ArgumentException("The key must be 128 bits long");
			}
			this.idx = 0;
			this.cnt = 0U;
			uint[] w = new uint[1280];
			for (int i = 0; i < 16; i++)
			{
				w[i >> 2] |= (uint)((uint)this.key[i] << 8 * (i & 3));
			}
			global::System.Array.Copy(w, 0, w, 4, 4);
			int j = 0;
			while (j < this.iv.Length && j < 16)
			{
				w[(j >> 2) + 8] |= (uint)((uint)this.iv[j] << 8 * (j & 3));
				j++;
			}
			global::System.Array.Copy(w, 8, w, 12, 4);
			for (uint k = 16U; k < 1280U; k += 1U)
			{
				w[(int)k] = global::Org.BouncyCastle.Crypto.Engines.HC128Engine.F2(w[(int)(k - 2U)]) + w[(int)(k - 7U)] + global::Org.BouncyCastle.Crypto.Engines.HC128Engine.F1(w[(int)(k - 15U)]) + w[(int)(k - 16U)] + k;
			}
			global::System.Array.Copy(w, 256, this.p, 0, 512);
			global::System.Array.Copy(w, 768, this.q, 0, 512);
			for (int l = 0; l < 512; l++)
			{
				this.p[l] = this.Step();
			}
			for (int m = 0; m < 512; m++)
			{
				this.q[m] = this.Step();
			}
			this.cnt = 0U;
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x000CCDCD File Offset: 0x000CAFCD
		public virtual string AlgorithmName
		{
			get
			{
				return "HC-128";
			}
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x000CCDD4 File Offset: 0x000CAFD4
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.ICipherParameters keyParam = parameters;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				this.iv = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters).GetIV();
				keyParam = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters).Parameters;
			}
			else
			{
				this.iv = new byte[0];
			}
			if (keyParam is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
			{
				this.key = ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)keyParam).GetKey();
				this.Init();
				this.initialised = true;
				return;
			}
			throw new global::System.ArgumentException("Invalid parameter passed to HC128 init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters), "parameters");
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x000CCE59 File Offset: 0x000CB059
		private byte GetByte()
		{
			if (this.idx == 0)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(this.Step(), this.buf);
			}
			byte result = this.buf[this.idx];
			this.idx = (this.idx + 1 & 3);
			return result;
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x000CCE94 File Offset: 0x000CB094
		public virtual void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
			if (!this.initialised)
			{
				throw new global::System.InvalidOperationException(this.AlgorithmName + " not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, len, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, len, "output buffer too short");
			for (int i = 0; i < len; i++)
			{
				output[outOff + i] = (input[inOff + i] ^ this.GetByte());
			}
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x000CCEFB File Offset: 0x000CB0FB
		public virtual void Reset()
		{
			this.Init();
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x000CCF03 File Offset: 0x000CB103
		public virtual byte ReturnByte(byte input)
		{
			return input ^ this.GetByte();
		}

		// Token: 0x04001339 RID: 4921
		private uint[] p = new uint[512];

		// Token: 0x0400133A RID: 4922
		private uint[] q = new uint[512];

		// Token: 0x0400133B RID: 4923
		private uint cnt;

		// Token: 0x0400133C RID: 4924
		private byte[] key;

		// Token: 0x0400133D RID: 4925
		private byte[] iv;

		// Token: 0x0400133E RID: 4926
		private bool initialised;

		// Token: 0x0400133F RID: 4927
		private byte[] buf = new byte[4];

		// Token: 0x04001340 RID: 4928
		private int idx;
	}
}
