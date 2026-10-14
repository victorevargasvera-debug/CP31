using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000169 RID: 361
	internal sealed class BcTlsAeadCipherImpl : global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipherImpl
	{
		// Token: 0x06000DF6 RID: 3574 RVA: 0x000345BE File Offset: 0x000327BE
		internal BcTlsAeadCipherImpl(global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher cipher, bool isEncrypting)
		{
			this.m_cipher = cipher;
			this.m_isEncrypting = isEncrypting;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x000345D4 File Offset: 0x000327D4
		public void SetKey(byte[] key, int keyOff, int keyLen)
		{
			this.key = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key, keyOff, keyLen);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x000345E4 File Offset: 0x000327E4
		public void Init(byte[] nonce, int macSize, byte[] additionalData)
		{
			this.m_cipher.Init(this.m_isEncrypting, new global::Org.BouncyCastle.Crypto.Parameters.AeadParameters(this.key, macSize * 8, nonce, additionalData));
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00034607 File Offset: 0x00032807
		public int GetOutputSize(int inputLength)
		{
			return this.m_cipher.GetOutputSize(inputLength);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00034618 File Offset: 0x00032818
		public int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset)
		{
			int len = this.m_cipher.ProcessBytes(input, inputOffset, inputLength, output, outputOffset);
			try
			{
				len += this.m_cipher.DoFinal(output, outputOffset + len);
			}
			catch (global::Org.BouncyCastle.Crypto.InvalidCipherTextException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(20, e);
			}
			return len;
		}

		// Token: 0x0400080F RID: 2063
		private readonly bool m_isEncrypting;

		// Token: 0x04000810 RID: 2064
		private readonly global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher m_cipher;

		// Token: 0x04000811 RID: 2065
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key;
	}
}
