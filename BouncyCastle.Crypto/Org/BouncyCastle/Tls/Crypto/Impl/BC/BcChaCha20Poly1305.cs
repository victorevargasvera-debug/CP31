using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000164 RID: 356
	public sealed class BcChaCha20Poly1305 : global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipherImpl
	{
		// Token: 0x06000DD9 RID: 3545 RVA: 0x00033E1A File Offset: 0x0003201A
		public BcChaCha20Poly1305(bool isEncrypting)
		{
			this.m_isEncrypting = isEncrypting;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00033E40 File Offset: 0x00032040
		public int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset)
		{
			if (this.m_isEncrypting)
			{
				this.m_cipher.ProcessBytes(input, inputOffset, inputLength, output, outputOffset);
				if (inputLength != inputLength)
				{
					throw new global::System.InvalidOperationException();
				}
				this.UpdateMac(output, outputOffset, inputLength);
				byte[] lengths = new byte[16];
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE((ulong)((long)this.m_additionalDataLength), lengths, 0);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE((ulong)((long)inputLength), lengths, 8);
				this.m_mac.BlockUpdate(lengths, 0, 16);
				this.m_mac.DoFinal(output, outputOffset + inputLength);
				return inputLength + 16;
			}
			else
			{
				int ciphertextLength = inputLength - 16;
				this.UpdateMac(input, inputOffset, ciphertextLength);
				byte[] expectedMac = new byte[16];
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE((ulong)((long)this.m_additionalDataLength), expectedMac, 0);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE((ulong)((long)ciphertextLength), expectedMac, 8);
				this.m_mac.BlockUpdate(expectedMac, 0, 16);
				this.m_mac.DoFinal(expectedMac, 0);
				if (!global::Org.BouncyCastle.Tls.TlsUtilities.ConstantTimeAreEqual(16, expectedMac, 0, input, inputOffset + ciphertextLength))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(20);
				}
				this.m_cipher.ProcessBytes(input, inputOffset, ciphertextLength, output, outputOffset);
				int outputLength = ciphertextLength;
				if (ciphertextLength != outputLength)
				{
					throw new global::System.InvalidOperationException();
				}
				return ciphertextLength;
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00033F50 File Offset: 0x00032150
		public int GetOutputSize(int inputLength)
		{
			if (!this.m_isEncrypting)
			{
				return inputLength - 16;
			}
			return inputLength + 16;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00033F64 File Offset: 0x00032164
		public void Init(byte[] nonce, int macSize, byte[] additionalData)
		{
			if (nonce == null || nonce.Length != 12 || macSize != 16)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.m_cipher.Init(this.m_isEncrypting, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(null, nonce));
			this.InitMac();
			if (additionalData == null)
			{
				this.m_additionalDataLength = 0;
				return;
			}
			this.m_additionalDataLength = additionalData.Length;
			this.UpdateMac(additionalData, 0, additionalData.Length);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00033FC8 File Offset: 0x000321C8
		public void SetKey(byte[] key, int keyOff, int keyLen)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter cipherKey = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key, keyOff, keyLen);
			this.m_cipher.Init(this.m_isEncrypting, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(cipherKey, global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcChaCha20Poly1305.Zeroes, 0, 12));
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00034000 File Offset: 0x00032200
		private void InitMac()
		{
			byte[] firstBlock = new byte[64];
			this.m_cipher.ProcessBytes(firstBlock, 0, 64, firstBlock, 0);
			this.m_mac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(firstBlock, 0, 32));
			global::System.Array.Clear(firstBlock, 0, firstBlock.Length);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00034044 File Offset: 0x00032244
		private void UpdateMac(byte[] buf, int off, int len)
		{
			this.m_mac.BlockUpdate(buf, off, len);
			int partial = len % 16;
			if (partial != 0)
			{
				this.m_mac.BlockUpdate(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcChaCha20Poly1305.Zeroes, 0, 16 - partial);
			}
		}

		// Token: 0x040007FF RID: 2047
		private static readonly byte[] Zeroes = new byte[15];

		// Token: 0x04000800 RID: 2048
		private readonly global::Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine m_cipher = new global::Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine();

		// Token: 0x04000801 RID: 2049
		private readonly global::Org.BouncyCastle.Crypto.Macs.Poly1305 m_mac = new global::Org.BouncyCastle.Crypto.Macs.Poly1305();

		// Token: 0x04000802 RID: 2050
		private readonly bool m_isEncrypting;

		// Token: 0x04000803 RID: 2051
		private int m_additionalDataLength;
	}
}
