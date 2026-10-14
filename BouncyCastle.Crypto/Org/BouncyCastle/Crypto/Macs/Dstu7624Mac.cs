using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000450 RID: 1104
	public class Dstu7624Mac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002AC2 RID: 10946 RVA: 0x000B7168 File Offset: 0x000B5368
		public Dstu7624Mac(int blockSizeBits, int q)
		{
			this.engine = new global::Org.BouncyCastle.Crypto.Engines.Dstu7624Engine(blockSizeBits);
			this.blockSize = blockSizeBits / 8;
			this.macSize = q / 8;
			this.c = new byte[this.blockSize];
			this.cTemp = new byte[this.blockSize];
			this.kDelta = new byte[this.blockSize];
			this.buf = new byte[this.blockSize];
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x000B71E0 File Offset: 0x000B53E0
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
			{
				this.engine.Init(true, (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters);
				this.engine.ProcessBlock(this.kDelta, 0, this.kDelta, 0);
				return;
			}
			throw new global::System.ArgumentException("invalid parameter passed to Dstu7624Mac init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x000B7237 File Offset: 0x000B5437
		public string AlgorithmName
		{
			get
			{
				return "Dstu7624Mac";
			}
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x000B723E File Offset: 0x000B543E
		public int GetMacSize()
		{
			return this.macSize;
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x000B7248 File Offset: 0x000B5448
		public void Update(byte input)
		{
			if (this.bufOff == this.buf.Length)
			{
				this.processBlock(this.buf, 0);
				this.bufOff = 0;
			}
			byte[] array = this.buf;
			int num = this.bufOff;
			this.bufOff = num + 1;
			array[num] = input;
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x000B7294 File Offset: 0x000B5494
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
			if (len < 0)
			{
				throw new global::System.ArgumentException("Can't have a negative input length!");
			}
			int blockSize = this.engine.GetBlockSize();
			int gapLen = blockSize - this.bufOff;
			if (len > gapLen)
			{
				global::System.Array.Copy(input, inOff, this.buf, this.bufOff, gapLen);
				this.processBlock(this.buf, 0);
				this.bufOff = 0;
				len -= gapLen;
				inOff += gapLen;
				while (len > blockSize)
				{
					this.processBlock(input, inOff);
					len -= blockSize;
					inOff += blockSize;
				}
			}
			global::System.Array.Copy(input, inOff, this.buf, this.bufOff, len);
			this.bufOff += len;
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x000B7335 File Offset: 0x000B5535
		private void processBlock(byte[] input, int inOff)
		{
			this.Xor(this.c, 0, input, inOff, this.cTemp);
			this.engine.ProcessBlock(this.cTemp, 0, this.c, 0);
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x000B7368 File Offset: 0x000B5568
		private void Xor(byte[] c, int cOff, byte[] input, int inOff, byte[] xorResult)
		{
			for (int byteIndex = 0; byteIndex < this.blockSize; byteIndex++)
			{
				xorResult[byteIndex] = (c[byteIndex + cOff] ^ input[byteIndex + inOff]);
			}
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x000B7398 File Offset: 0x000B5598
		public int DoFinal(byte[] output, int outOff)
		{
			if (this.bufOff % this.buf.Length != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Input must be a multiple of blocksize");
			}
			this.Xor(this.c, 0, this.buf, 0, this.cTemp);
			this.Xor(this.cTemp, 0, this.kDelta, 0, this.c);
			this.engine.ProcessBlock(this.c, 0, this.c, 0);
			if (this.macSize + outOff > output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Output buffer too short");
			}
			global::System.Array.Copy(this.c, 0, output, outOff, this.macSize);
			return this.macSize;
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x000B7444 File Offset: 0x000B5644
		public void Reset()
		{
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.c, 0);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.cTemp, 0);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.kDelta, 0);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.buf, 0);
			this.engine.Reset();
			this.engine.ProcessBlock(this.kDelta, 0, this.kDelta, 0);
			this.bufOff = 0;
		}

		// Token: 0x04001191 RID: 4497
		private int macSize;

		// Token: 0x04001192 RID: 4498
		private global::Org.BouncyCastle.Crypto.Engines.Dstu7624Engine engine;

		// Token: 0x04001193 RID: 4499
		private int blockSize;

		// Token: 0x04001194 RID: 4500
		private byte[] c;

		// Token: 0x04001195 RID: 4501
		private byte[] cTemp;

		// Token: 0x04001196 RID: 4502
		private byte[] kDelta;

		// Token: 0x04001197 RID: 4503
		private byte[] buf;

		// Token: 0x04001198 RID: 4504
		private int bufOff;
	}
}
