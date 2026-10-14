using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200016A RID: 362
	internal sealed class BcTlsBlockCipherImpl : global::Org.BouncyCastle.Tls.Crypto.Impl.TlsBlockCipherImpl
	{
		// Token: 0x06000DFB RID: 3579 RVA: 0x0003466C File Offset: 0x0003286C
		internal BcTlsBlockCipherImpl(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, bool isEncrypting)
		{
			this.m_cipher = cipher;
			this.m_isEncrypting = isEncrypting;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00034682 File Offset: 0x00032882
		public void SetKey(byte[] key, int keyOff, int keyLen)
		{
			this.key = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key, keyOff, keyLen);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00034692 File Offset: 0x00032892
		public void Init(byte[] iv, int ivOff, int ivLen)
		{
			this.m_cipher.Init(this.m_isEncrypting, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.key, iv, ivOff, ivLen));
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x000346B4 File Offset: 0x000328B4
		public int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset)
		{
			int blockSize = this.m_cipher.GetBlockSize();
			for (int i = 0; i < inputLength; i += blockSize)
			{
				this.m_cipher.ProcessBlock(input, inputOffset + i, output, outputOffset + i);
			}
			return inputLength;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x000346F0 File Offset: 0x000328F0
		public int GetBlockSize()
		{
			return this.m_cipher.GetBlockSize();
		}

		// Token: 0x04000812 RID: 2066
		private readonly bool m_isEncrypting;

		// Token: 0x04000813 RID: 2067
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher m_cipher;

		// Token: 0x04000814 RID: 2068
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key;
	}
}
