using System;

namespace Org.BouncyCastle.Tls.Crypto.Impl
{
	// Token: 0x02000161 RID: 353
	public class TlsNullCipher : global::Org.BouncyCastle.Tls.Crypto.TlsCipher
	{
		// Token: 0x06000DC6 RID: 3526 RVA: 0x00033A90 File Offset: 0x00031C90
		public TlsNullCipher(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, global::Org.BouncyCastle.Tls.Crypto.TlsHmac clientMac, global::Org.BouncyCastle.Tls.Crypto.TlsHmac serverMac)
		{
			if (global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsTlsV13(cryptoParams))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.m_cryptoParams = cryptoParams;
			int key_block_size = clientMac.MacLength + serverMac.MacLength;
			byte[] key_block = global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.CalculateKeyBlock(cryptoParams, key_block_size);
			int offset = 0;
			clientMac.SetKey(key_block, offset, clientMac.MacLength);
			offset += clientMac.MacLength;
			serverMac.SetKey(key_block, offset, serverMac.MacLength);
			offset += serverMac.MacLength;
			if (offset != key_block_size)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			if (cryptoParams.IsServer)
			{
				this.m_writeMac = new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteHmac(cryptoParams, serverMac);
				this.m_readMac = new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteHmac(cryptoParams, clientMac);
				return;
			}
			this.m_writeMac = new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteHmac(cryptoParams, clientMac);
			this.m_readMac = new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteHmac(cryptoParams, serverMac);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00033B49 File Offset: 0x00031D49
		public virtual int GetCiphertextDecodeLimit(int plaintextLimit)
		{
			return plaintextLimit + this.m_writeMac.Size;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00033B58 File Offset: 0x00031D58
		public virtual int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
		{
			return plaintextLength + this.m_writeMac.Size;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00033B67 File Offset: 0x00031D67
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			return ciphertextLimit - this.m_writeMac.Size;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00033B78 File Offset: 0x00031D78
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsEncodeResult EncodePlaintext(long seqNo, short contentType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len)
		{
			byte[] mac = this.m_writeMac.CalculateMac(seqNo, contentType, plaintext, offset, len);
			byte[] ciphertext = new byte[headerAllocation + len + mac.Length];
			global::System.Array.Copy(plaintext, offset, ciphertext, headerAllocation, len);
			global::System.Array.Copy(mac, 0, ciphertext, headerAllocation + len, mac.Length);
			return new global::Org.BouncyCastle.Tls.Crypto.TlsEncodeResult(ciphertext, 0, ciphertext.Length, contentType);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00033BD4 File Offset: 0x00031DD4
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len)
		{
			int macSize = this.m_readMac.Size;
			if (len < macSize)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			int macInputLen = len - macSize;
			byte[] expectedMac = this.m_readMac.CalculateMac(seqNo, recordType, ciphertext, offset, macInputLen);
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.ConstantTimeAreEqual(macSize, expectedMac, 0, ciphertext, offset + macInputLen))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(20);
			}
			return new global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult(ciphertext, offset, macInputLen, recordType);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00033C38 File Offset: 0x00031E38
		public virtual void RekeyDecoder()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00033C41 File Offset: 0x00031E41
		public virtual void RekeyEncoder()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00033C4A File Offset: 0x00031E4A
		public virtual bool UsesOpaqueRecordType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040007F7 RID: 2039
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters m_cryptoParams;

		// Token: 0x040007F8 RID: 2040
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteHmac m_readMac;

		// Token: 0x040007F9 RID: 2041
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteHmac m_writeMac;
	}
}
