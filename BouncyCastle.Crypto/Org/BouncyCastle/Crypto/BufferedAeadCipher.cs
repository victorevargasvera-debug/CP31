using System;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002B7 RID: 695
	public class BufferedAeadCipher : global::Org.BouncyCastle.Crypto.BufferedCipherBase
	{
		// Token: 0x06001EFC RID: 7932 RVA: 0x0008F40C File Offset: 0x0008D60C
		public BufferedAeadCipher(global::Org.BouncyCastle.Crypto.Modes.IAeadCipher cipher)
		{
			if (cipher == null)
			{
				throw new global::System.ArgumentNullException("cipher");
			}
			this.cipher = cipher;
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x0008F429 File Offset: 0x0008D629
		public override string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName;
			}
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x0008F436 File Offset: 0x0008D636
		public override void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				parameters = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			this.cipher.Init(forEncryption, parameters);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x0008F45A File Offset: 0x0008D65A
		public override int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x0008F45D File Offset: 0x0008D65D
		public override int GetUpdateOutputSize(int length)
		{
			return this.cipher.GetUpdateOutputSize(length);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x0008F46B File Offset: 0x0008D66B
		public override int GetOutputSize(int length)
		{
			return this.cipher.GetOutputSize(length);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0008F479 File Offset: 0x0008D679
		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			return this.cipher.ProcessByte(input, output, outOff);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x0008F48C File Offset: 0x0008D68C
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

		// Token: 0x06001F04 RID: 7940 RVA: 0x0008F4D8 File Offset: 0x0008D6D8
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

		// Token: 0x06001F05 RID: 7941 RVA: 0x0008F537 File Offset: 0x0008D737
		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return this.cipher.ProcessBytes(input, inOff, length, output, outOff);
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x0008F54C File Offset: 0x0008D74C
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

		// Token: 0x06001F07 RID: 7943 RVA: 0x0008F58C File Offset: 0x0008D78C
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

		// Token: 0x06001F08 RID: 7944 RVA: 0x0008F5EC File Offset: 0x0008D7EC
		public override int DoFinal(byte[] output, int outOff)
		{
			return this.cipher.DoFinal(output, outOff);
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x0008F5FB File Offset: 0x0008D7FB
		public override void Reset()
		{
			this.cipher.Reset();
		}

		// Token: 0x04000B1E RID: 2846
		private readonly global::Org.BouncyCastle.Crypto.Modes.IAeadCipher cipher;
	}
}
