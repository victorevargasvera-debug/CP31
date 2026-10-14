using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200049F RID: 1183
	public class HC256Engine : global::Org.BouncyCastle.Crypto.IStreamCipher
	{
		// Token: 0x06002D9E RID: 11678 RVA: 0x000CCF44 File Offset: 0x000CB144
		private uint Step()
		{
			uint i = this.cnt & 1023U;
			uint ret;
			if (this.cnt < 1024U)
			{
				uint x = this.p[(int)(i - 3U & 1023U)];
				uint y = this.p[(int)(i - 1023U & 1023U)];
				this.p[(int)i] += this.p[(int)(i - 10U & 1023U)] + (global::Org.BouncyCastle.Crypto.Engines.HC256Engine.RotateRight(x, 10) ^ global::Org.BouncyCastle.Crypto.Engines.HC256Engine.RotateRight(y, 23)) + this.q[(int)((x ^ y) & 1023U)];
				x = this.p[(int)(i - 12U & 1023U)];
				ret = (this.q[(int)(x & 255U)] + this.q[(int)((x >> 8 & 255U) + 256U)] + this.q[(int)((x >> 16 & 255U) + 512U)] + this.q[(int)((x >> 24 & 255U) + 768U)] ^ this.p[(int)i]);
			}
			else
			{
				uint x2 = this.q[(int)(i - 3U & 1023U)];
				uint y2 = this.q[(int)(i - 1023U & 1023U)];
				this.q[(int)i] += this.q[(int)(i - 10U & 1023U)] + (global::Org.BouncyCastle.Crypto.Engines.HC256Engine.RotateRight(x2, 10) ^ global::Org.BouncyCastle.Crypto.Engines.HC256Engine.RotateRight(y2, 23)) + this.p[(int)((x2 ^ y2) & 1023U)];
				x2 = this.q[(int)(i - 12U & 1023U)];
				ret = (this.p[(int)(x2 & 255U)] + this.p[(int)((x2 >> 8 & 255U) + 256U)] + this.p[(int)((x2 >> 16 & 255U) + 512U)] + this.p[(int)((x2 >> 24 & 255U) + 768U)] ^ this.q[(int)i]);
			}
			this.cnt = (this.cnt + 1U & 2047U);
			return ret;
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x000CD14C File Offset: 0x000CB34C
		private void Init()
		{
			if (this.key.Length != 32 && this.key.Length != 16)
			{
				throw new global::System.ArgumentException("The key must be 128/256 bits long");
			}
			if (this.iv.Length < 16)
			{
				throw new global::System.ArgumentException("The IV must be at least 128 bits long");
			}
			if (this.key.Length != 32)
			{
				byte[] i = new byte[32];
				global::System.Array.Copy(this.key, 0, i, 0, this.key.Length);
				global::System.Array.Copy(this.key, 0, i, 16, this.key.Length);
				this.key = i;
			}
			if (this.iv.Length < 32)
			{
				byte[] newIV = new byte[32];
				global::System.Array.Copy(this.iv, 0, newIV, 0, this.iv.Length);
				global::System.Array.Copy(this.iv, 0, newIV, this.iv.Length, newIV.Length - this.iv.Length);
				this.iv = newIV;
			}
			this.idx = 0;
			this.cnt = 0U;
			uint[] w = new uint[2560];
			for (int j = 0; j < 32; j++)
			{
				w[j >> 2] |= (uint)((uint)this.key[j] << 8 * (j & 3));
			}
			for (int k = 0; k < 32; k++)
			{
				w[(k >> 2) + 8] |= (uint)((uint)this.iv[k] << 8 * (k & 3));
			}
			for (uint l = 16U; l < 2560U; l += 1U)
			{
				uint x = w[(int)(l - 2U)];
				uint y = w[(int)(l - 15U)];
				w[(int)l] = (global::Org.BouncyCastle.Crypto.Engines.HC256Engine.RotateRight(x, 17) ^ global::Org.BouncyCastle.Crypto.Engines.HC256Engine.RotateRight(x, 19) ^ x >> 10) + w[(int)(l - 7U)] + (global::Org.BouncyCastle.Crypto.Engines.HC256Engine.RotateRight(y, 7) ^ global::Org.BouncyCastle.Crypto.Engines.HC256Engine.RotateRight(y, 18) ^ y >> 3) + w[(int)(l - 16U)] + l;
			}
			global::System.Array.Copy(w, 512, this.p, 0, 1024);
			global::System.Array.Copy(w, 1536, this.q, 0, 1024);
			for (int m = 0; m < 4096; m++)
			{
				this.Step();
			}
			this.cnt = 0U;
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x000CD362 File Offset: 0x000CB562
		public virtual string AlgorithmName
		{
			get
			{
				return "HC-256";
			}
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x000CD36C File Offset: 0x000CB56C
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
			throw new global::System.ArgumentException("Invalid parameter passed to HC256 init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters), "parameters");
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000CD3F1 File Offset: 0x000CB5F1
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

		// Token: 0x06002DA3 RID: 11683 RVA: 0x000CD42C File Offset: 0x000CB62C
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

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000CD493 File Offset: 0x000CB693
		public virtual void Reset()
		{
			this.Init();
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x000CD49B File Offset: 0x000CB69B
		public virtual byte ReturnByte(byte input)
		{
			return input ^ this.GetByte();
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x000CD4A6 File Offset: 0x000CB6A6
		private static uint RotateRight(uint x, int bits)
		{
			return x >> bits | x << -bits;
		}

		// Token: 0x04001341 RID: 4929
		private uint[] p = new uint[1024];

		// Token: 0x04001342 RID: 4930
		private uint[] q = new uint[1024];

		// Token: 0x04001343 RID: 4931
		private uint cnt;

		// Token: 0x04001344 RID: 4932
		private byte[] key;

		// Token: 0x04001345 RID: 4933
		private byte[] iv;

		// Token: 0x04001346 RID: 4934
		private bool initialised;

		// Token: 0x04001347 RID: 4935
		private byte[] buf = new byte[4];

		// Token: 0x04001348 RID: 4936
		private int idx;
	}
}
