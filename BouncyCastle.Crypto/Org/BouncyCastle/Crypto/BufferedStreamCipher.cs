using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002BC RID: 700
	public class BufferedStreamCipher : global::Org.BouncyCastle.Crypto.BufferedCipherBase
	{
		// Token: 0x06001F44 RID: 8004 RVA: 0x0008FE7C File Offset: 0x0008E07C
		public BufferedStreamCipher(global::Org.BouncyCastle.Crypto.IStreamCipher cipher)
		{
			if (cipher == null)
			{
				throw new global::System.ArgumentNullException("cipher");
			}
			this.cipher = cipher;
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x0008FE99 File Offset: 0x0008E099
		public override string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName;
			}
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0008FEA6 File Offset: 0x0008E0A6
		public override void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				parameters = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			this.cipher.Init(forEncryption, parameters);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0008FECA File Offset: 0x0008E0CA
		public override int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x0008FECD File Offset: 0x0008E0CD
		public override int GetOutputSize(int inputLen)
		{
			return inputLen;
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x0008FED0 File Offset: 0x0008E0D0
		public override int GetUpdateOutputSize(int inputLen)
		{
			return inputLen;
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x0008FED3 File Offset: 0x0008E0D3
		public override byte[] ProcessByte(byte input)
		{
			return new byte[]
			{
				this.cipher.ReturnByte(input)
			};
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0008FEEA File Offset: 0x0008E0EA
		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			if (outOff >= output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too short");
			}
			output[outOff] = this.cipher.ReturnByte(input);
			return 1;
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0008FF10 File Offset: 0x0008E110
		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			if (length < 1)
			{
				return null;
			}
			byte[] output = new byte[length];
			this.cipher.ProcessBytes(input, inOff, length, output, 0);
			return output;
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x0008FF3B File Offset: 0x0008E13B
		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			if (length < 1)
			{
				return 0;
			}
			if (length > 0)
			{
				this.cipher.ProcessBytes(input, inOff, length, output, outOff);
			}
			return length;
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x0008FF5A File Offset: 0x0008E15A
		public override byte[] DoFinal()
		{
			this.Reset();
			return global::Org.BouncyCastle.Crypto.BufferedCipherBase.EmptyBuffer;
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x0008FF67 File Offset: 0x0008E167
		public override byte[] DoFinal(byte[] input, int inOff, int length)
		{
			if (length < 1)
			{
				return global::Org.BouncyCastle.Crypto.BufferedCipherBase.EmptyBuffer;
			}
			byte[] result = this.ProcessBytes(input, inOff, length);
			this.Reset();
			return result;
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x0008FF82 File Offset: 0x0008E182
		public override void Reset()
		{
			this.cipher.Reset();
		}

		// Token: 0x04000B2A RID: 2858
		private readonly global::Org.BouncyCastle.Crypto.IStreamCipher cipher;
	}
}
