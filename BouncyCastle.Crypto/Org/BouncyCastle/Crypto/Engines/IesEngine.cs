using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004A1 RID: 1185
	public class IesEngine
	{
		// Token: 0x06002DB9 RID: 11705 RVA: 0x000CDA84 File Offset: 0x000CBC84
		public IesEngine(global::Org.BouncyCastle.Crypto.IBasicAgreement agree, global::Org.BouncyCastle.Crypto.IDerivationFunction kdf, global::Org.BouncyCastle.Crypto.IMac mac)
		{
			this.agree = agree;
			this.kdf = kdf;
			this.mac = mac;
			this.macBuf = new byte[mac.GetMacSize()];
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000CDAB2 File Offset: 0x000CBCB2
		public IesEngine(global::Org.BouncyCastle.Crypto.IBasicAgreement agree, global::Org.BouncyCastle.Crypto.IDerivationFunction kdf, global::Org.BouncyCastle.Crypto.IMac mac, global::Org.BouncyCastle.Crypto.BufferedBlockCipher cipher)
		{
			this.agree = agree;
			this.kdf = kdf;
			this.mac = mac;
			this.macBuf = new byte[mac.GetMacSize()];
			this.cipher = cipher;
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x000CDAE8 File Offset: 0x000CBCE8
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters privParameters, global::Org.BouncyCastle.Crypto.ICipherParameters pubParameters, global::Org.BouncyCastle.Crypto.ICipherParameters iesParameters)
		{
			this.forEncryption = forEncryption;
			this.privParam = privParameters;
			this.pubParam = pubParameters;
			this.param = (global::Org.BouncyCastle.Crypto.Parameters.IesParameters)iesParameters;
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x000CDB0C File Offset: 0x000CBD0C
		private byte[] DecryptBlock(byte[] in_enc, int inOff, int inLen, byte[] z)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KdfParameters kParam = new global::Org.BouncyCastle.Crypto.Parameters.KdfParameters(z, this.param.GetDerivationV());
			int macKeySize = this.param.MacKeySize;
			this.kdf.Init(kParam);
			if (inLen < this.mac.GetMacSize())
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("Length of input must be greater than the MAC");
			}
			inLen -= this.mac.GetMacSize();
			byte[] M;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter macKey;
			if (this.cipher == null)
			{
				byte[] Buffer = this.GenerateKdfBytes(kParam, inLen + macKeySize / 8);
				M = new byte[inLen];
				for (int i = 0; i != inLen; i++)
				{
					M[i] = (in_enc[inOff + i] ^ Buffer[i]);
				}
				macKey = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(Buffer, inLen, macKeySize / 8);
			}
			else
			{
				int cipherKeySize = ((global::Org.BouncyCastle.Crypto.Parameters.IesWithCipherParameters)this.param).CipherKeySize;
				byte[] Buffer2 = this.GenerateKdfBytes(kParam, cipherKeySize / 8 + macKeySize / 8);
				this.cipher.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(Buffer2, 0, cipherKeySize / 8));
				M = this.cipher.DoFinal(in_enc, inOff, inLen);
				macKey = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(Buffer2, cipherKeySize / 8, macKeySize / 8);
			}
			byte[] macIV = this.param.GetEncodingV();
			this.mac.Init(macKey);
			this.mac.BlockUpdate(in_enc, inOff, inLen);
			this.mac.BlockUpdate(macIV, 0, macIV.Length);
			this.mac.DoFinal(this.macBuf, 0);
			inOff += inLen;
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(in_enc, inOff, inOff + this.macBuf.Length), this.macBuf))
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("Invalid MAC.");
			}
			return M;
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x000CDC90 File Offset: 0x000CBE90
		private byte[] EncryptBlock(byte[] input, int inOff, int inLen, byte[] z)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KdfParameters kParam = new global::Org.BouncyCastle.Crypto.Parameters.KdfParameters(z, this.param.GetDerivationV());
			int macKeySize = this.param.MacKeySize;
			byte[] C;
			int c_text_length;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter macKey;
			if (this.cipher == null)
			{
				byte[] Buffer = this.GenerateKdfBytes(kParam, inLen + macKeySize / 8);
				C = new byte[inLen + this.mac.GetMacSize()];
				c_text_length = inLen;
				for (int i = 0; i != inLen; i++)
				{
					C[i] = (input[inOff + i] ^ Buffer[i]);
				}
				macKey = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(Buffer, inLen, macKeySize / 8);
			}
			else
			{
				int cipherKeySize = ((global::Org.BouncyCastle.Crypto.Parameters.IesWithCipherParameters)this.param).CipherKeySize;
				byte[] Buffer2 = this.GenerateKdfBytes(kParam, cipherKeySize / 8 + macKeySize / 8);
				this.cipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(Buffer2, 0, cipherKeySize / 8));
				c_text_length = this.cipher.GetOutputSize(inLen);
				byte[] tmp = new byte[c_text_length];
				int len = this.cipher.ProcessBytes(input, inOff, inLen, tmp, 0);
				len += this.cipher.DoFinal(tmp, len);
				C = new byte[len + this.mac.GetMacSize()];
				c_text_length = len;
				global::System.Array.Copy(tmp, 0, C, 0, len);
				macKey = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(Buffer2, cipherKeySize / 8, macKeySize / 8);
			}
			byte[] macIV = this.param.GetEncodingV();
			this.mac.Init(macKey);
			this.mac.BlockUpdate(C, 0, c_text_length);
			this.mac.BlockUpdate(macIV, 0, macIV.Length);
			this.mac.DoFinal(C, c_text_length);
			return C;
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x000CDE18 File Offset: 0x000CC018
		private byte[] GenerateKdfBytes(global::Org.BouncyCastle.Crypto.Parameters.KdfParameters kParam, int length)
		{
			byte[] buf = new byte[length];
			this.kdf.Init(kParam);
			this.kdf.GenerateBytes(buf, 0, buf.Length);
			return buf;
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x000CDE4C File Offset: 0x000CC04C
		public virtual byte[] ProcessBlock(byte[] input, int inOff, int inLen)
		{
			this.agree.Init(this.privParam);
			global::Org.BouncyCastle.Math.BigInteger z = this.agree.CalculateAgreement(this.pubParam);
			byte[] zBytes = global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(this.agree.GetFieldSize(), z);
			byte[] result;
			try
			{
				result = (this.forEncryption ? this.EncryptBlock(input, inOff, inLen, zBytes) : this.DecryptBlock(input, inOff, inLen, zBytes));
			}
			finally
			{
				global::System.Array.Clear(zBytes, 0, zBytes.Length);
			}
			return result;
		}

		// Token: 0x0400134D RID: 4941
		private readonly global::Org.BouncyCastle.Crypto.IBasicAgreement agree;

		// Token: 0x0400134E RID: 4942
		private readonly global::Org.BouncyCastle.Crypto.IDerivationFunction kdf;

		// Token: 0x0400134F RID: 4943
		private readonly global::Org.BouncyCastle.Crypto.IMac mac;

		// Token: 0x04001350 RID: 4944
		private readonly global::Org.BouncyCastle.Crypto.BufferedBlockCipher cipher;

		// Token: 0x04001351 RID: 4945
		private readonly byte[] macBuf;

		// Token: 0x04001352 RID: 4946
		private bool forEncryption;

		// Token: 0x04001353 RID: 4947
		private global::Org.BouncyCastle.Crypto.ICipherParameters privParam;

		// Token: 0x04001354 RID: 4948
		private global::Org.BouncyCastle.Crypto.ICipherParameters pubParam;

		// Token: 0x04001355 RID: 4949
		private global::Org.BouncyCastle.Crypto.Parameters.IesParameters param;
	}
}
