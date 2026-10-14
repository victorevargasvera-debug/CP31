using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002EC RID: 748
	public class StreamBlockCipher : global::Org.BouncyCastle.Crypto.IStreamCipher
	{
		// Token: 0x06001FFE RID: 8190 RVA: 0x000902C8 File Offset: 0x0008E4C8
		public StreamBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			if (cipher == null)
			{
				throw new global::System.ArgumentNullException("cipher");
			}
			if (cipher.GetBlockSize() != 1)
			{
				throw new global::System.ArgumentException("block cipher block size != 1.", "cipher");
			}
			this.cipher = cipher;
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00090315 File Offset: 0x0008E515
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.cipher.Init(forEncryption, parameters);
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x00090324 File Offset: 0x0008E524
		public string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName;
			}
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00090331 File Offset: 0x0008E531
		public byte ReturnByte(byte input)
		{
			this.oneByte[0] = input;
			this.cipher.ProcessBlock(this.oneByte, 0, this.oneByte, 0);
			return this.oneByte[0];
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00090360 File Offset: 0x0008E560
		public void ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			if (outOff + length > output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too small in ProcessBytes()");
			}
			for (int i = 0; i != length; i++)
			{
				this.cipher.ProcessBlock(input, inOff + i, output, outOff + i);
			}
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x000903A4 File Offset: 0x0008E5A4
		public void Reset()
		{
			this.cipher.Reset();
		}

		// Token: 0x04000B35 RID: 2869
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher;

		// Token: 0x04000B36 RID: 2870
		private readonly byte[] oneByte = new byte[1];
	}
}
