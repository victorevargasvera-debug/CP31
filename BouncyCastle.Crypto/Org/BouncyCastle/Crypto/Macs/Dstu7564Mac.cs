using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x0200044F RID: 1103
	public class Dstu7564Mac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002AB8 RID: 10936 RVA: 0x000B6E86 File Offset: 0x000B5086
		public string AlgorithmName
		{
			get
			{
				return "DSTU7564Mac";
			}
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x000B6E8D File Offset: 0x000B508D
		public Dstu7564Mac(int macSizeBits)
		{
			this.engine = new global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest(macSizeBits);
			this.macSize = macSizeBits / 8;
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x000B6EAC File Offset: 0x000B50AC
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
			{
				byte[] key = ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey();
				this.invertedKey = new byte[key.Length];
				this.paddedKey = this.PadKey(key);
				for (int byteIndex = 0; byteIndex < this.invertedKey.Length; byteIndex++)
				{
					this.invertedKey[byteIndex] = (key[byteIndex] ^ byte.MaxValue);
				}
				this.engine.BlockUpdate(this.paddedKey, 0, this.paddedKey.Length);
				return;
			}
			throw new global::System.ArgumentException("Bad parameter passed");
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x000B6F34 File Offset: 0x000B5134
		public int GetMacSize()
		{
			return this.macSize;
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x000B6F3C File Offset: 0x000B513C
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, len, "Input buffer too short");
			if (this.paddedKey == null)
			{
				throw new global::System.InvalidOperationException(this.AlgorithmName + " not initialised");
			}
			this.engine.BlockUpdate(input, inOff, len);
			this.inputLength += (ulong)((long)len);
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x000B6F91 File Offset: 0x000B5191
		public void Update(byte input)
		{
			this.engine.Update(input);
			this.inputLength += 1UL;
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x000B6FB0 File Offset: 0x000B51B0
		public int DoFinal(byte[] output, int outOff)
		{
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, this.macSize, "Output buffer too short");
			if (this.paddedKey == null)
			{
				throw new global::System.InvalidOperationException(this.AlgorithmName + " not initialised");
			}
			this.Pad();
			this.engine.BlockUpdate(this.invertedKey, 0, this.invertedKey.Length);
			this.inputLength = 0UL;
			return this.engine.DoFinal(output, outOff);
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x000B7022 File Offset: 0x000B5222
		public void Reset()
		{
			this.inputLength = 0UL;
			this.engine.Reset();
			if (this.paddedKey != null)
			{
				this.engine.BlockUpdate(this.paddedKey, 0, this.paddedKey.Length);
			}
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x000B705C File Offset: 0x000B525C
		private void Pad()
		{
			int extra = this.engine.GetByteLength() - (int)(this.inputLength % (ulong)((long)this.engine.GetByteLength()));
			if (extra < 13)
			{
				extra += this.engine.GetByteLength();
			}
			byte[] padded = new byte[extra];
			padded[0] = 128;
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(this.inputLength * 8UL, padded, padded.Length - 12);
			this.engine.BlockUpdate(padded, 0, padded.Length);
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x000B70D4 File Offset: 0x000B52D4
		private byte[] PadKey(byte[] input)
		{
			int paddedLen = (input.Length + this.engine.GetByteLength() - 1) / this.engine.GetByteLength() * this.engine.GetByteLength();
			if (this.engine.GetByteLength() - input.Length % this.engine.GetByteLength() < 13)
			{
				paddedLen += this.engine.GetByteLength();
			}
			byte[] padded = new byte[paddedLen];
			global::System.Array.Copy(input, 0, padded, 0, input.Length);
			padded[input.Length] = 128;
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(input.Length * 8), padded, padded.Length - 12);
			return padded;
		}

		// Token: 0x0400118C RID: 4492
		private global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest engine;

		// Token: 0x0400118D RID: 4493
		private int macSize;

		// Token: 0x0400118E RID: 4494
		private ulong inputLength;

		// Token: 0x0400118F RID: 4495
		private byte[] paddedKey;

		// Token: 0x04001190 RID: 4496
		private byte[] invertedKey;
	}
}
