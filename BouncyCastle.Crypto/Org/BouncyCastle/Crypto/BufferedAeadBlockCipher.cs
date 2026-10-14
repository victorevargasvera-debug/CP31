using System;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002B6 RID: 694
	public class BufferedAeadBlockCipher : global::Org.BouncyCastle.Crypto.BufferedCipherBase
	{
		// Token: 0x06001EEE RID: 7918 RVA: 0x0008F207 File Offset: 0x0008D407
		public BufferedAeadBlockCipher(global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher cipher)
		{
			if (cipher == null)
			{
				throw new global::System.ArgumentNullException("cipher");
			}
			this.cipher = cipher;
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0008F224 File Offset: 0x0008D424
		public override string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName;
			}
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x0008F231 File Offset: 0x0008D431
		public override void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				parameters = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			this.cipher.Init(forEncryption, parameters);
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x0008F255 File Offset: 0x0008D455
		public override int GetBlockSize()
		{
			return this.cipher.GetBlockSize();
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x0008F262 File Offset: 0x0008D462
		public override int GetUpdateOutputSize(int length)
		{
			return this.cipher.GetUpdateOutputSize(length);
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x0008F270 File Offset: 0x0008D470
		public override int GetOutputSize(int length)
		{
			return this.cipher.GetOutputSize(length);
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x0008F27E File Offset: 0x0008D47E
		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			return this.cipher.ProcessByte(input, output, outOff);
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x0008F290 File Offset: 0x0008D490
		public override byte[] ProcessByte(byte input)
		{
			int outLength = this.GetUpdateOutputSize(1);
			byte[] outBytes = (outLength > 0) ? new byte[outLength] : null;
			int pos = this.ProcessByte(input, outBytes, 0);
			if (outLength > 0 && pos < outLength)
			{
				byte[] tmp = new byte[pos];
				global::System.Array.Copy(outBytes, 0, tmp, 0, pos);
				outBytes = tmp;
			}
			return outBytes;
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x0008F2DC File Offset: 0x0008D4DC
		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input");
			}
			if (length < 1)
			{
				return null;
			}
			int outLength = this.GetUpdateOutputSize(length);
			byte[] outBytes = (outLength > 0) ? new byte[outLength] : null;
			int pos = this.ProcessBytes(input, inOff, length, outBytes, 0);
			if (outLength > 0 && pos < outLength)
			{
				byte[] tmp = new byte[pos];
				global::System.Array.Copy(outBytes, 0, tmp, 0, pos);
				outBytes = tmp;
			}
			return outBytes;
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0008F33B File Offset: 0x0008D53B
		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return this.cipher.ProcessBytes(input, inOff, length, output, outOff);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0008F350 File Offset: 0x0008D550
		public override byte[] DoFinal()
		{
			byte[] outBytes = new byte[this.GetOutputSize(0)];
			int pos = this.DoFinal(outBytes, 0);
			if (pos < outBytes.Length)
			{
				byte[] tmp = new byte[pos];
				global::System.Array.Copy(outBytes, 0, tmp, 0, pos);
				outBytes = tmp;
			}
			return outBytes;
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0008F390 File Offset: 0x0008D590
		public override byte[] DoFinal(byte[] input, int inOff, int inLen)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input");
			}
			byte[] outBytes = new byte[this.GetOutputSize(inLen)];
			int pos = (inLen > 0) ? this.ProcessBytes(input, inOff, inLen, outBytes, 0) : 0;
			pos += this.DoFinal(outBytes, pos);
			if (pos < outBytes.Length)
			{
				byte[] tmp = new byte[pos];
				global::System.Array.Copy(outBytes, 0, tmp, 0, pos);
				outBytes = tmp;
			}
			return outBytes;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0008F3F0 File Offset: 0x0008D5F0
		public override int DoFinal(byte[] output, int outOff)
		{
			return this.cipher.DoFinal(output, outOff);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0008F3FF File Offset: 0x0008D5FF
		public override void Reset()
		{
			this.cipher.Reset();
		}

		// Token: 0x04000B1D RID: 2845
		private readonly global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher cipher;
	}
}
