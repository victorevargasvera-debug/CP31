using System;
using NPOI.OpenXmlFormats.Encryption;

namespace NPOI.POIFS.Crypt.Agile
{
	// Token: 0x02000114 RID: 276
	public class AgileEncryptionHeader : global::NPOI.POIFS.Crypt.EncryptionHeader
	{
		// Token: 0x06000FA7 RID: 4007 RVA: 0x0003722C File Offset: 0x0003542C
		public AgileEncryptionHeader(string descriptor) : this(global::NPOI.POIFS.Crypt.Agile.AgileEncryptionInfoBuilder.ParseDescriptor(descriptor))
		{
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0003723C File Offset: 0x0003543C
		protected internal AgileEncryptionHeader(global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument ed)
		{
			global::NPOI.OpenXmlFormats.Encryption.CT_KeyData keyData;
			try
			{
				keyData = ed.GetEncryption().keyData;
				if (keyData == null)
				{
					throw new global::System.NullReferenceException("keyData not Set");
				}
			}
			catch (global::System.Exception)
			{
				throw new global::NPOI.EncryptedDocumentException("Unable to parse keyData");
			}
			base.KeySize = (int)keyData.keyBits;
			base.Flags = 0;
			base.SizeExtra = 0;
			base.CspName = null;
			base.BlockSize = (int)keyData.blockSize;
			int keyBits = (int)keyData.keyBits;
			global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm = global::NPOI.POIFS.Crypt.CipherAlgorithm.FromXmlId(keyData.cipherAlgorithm.ToString(), keyBits);
			base.CipherAlgorithm = cipherAlgorithm;
			base.CipherProvider = cipherAlgorithm.provider;
			global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining cipherChaining = keyData.cipherChaining;
			if (cipherChaining != global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining.ChainingModeCBC)
			{
				if (cipherChaining != global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining.ChainingModeCFB)
				{
					throw new global::NPOI.EncryptedDocumentException("Unsupported chaining mode - " + keyData.cipherChaining.ToString());
				}
				base.ChainingMode = global::NPOI.POIFS.Crypt.ChainingMode.cfb;
			}
			else
			{
				base.ChainingMode = global::NPOI.POIFS.Crypt.ChainingMode.cbc;
			}
			int hashSize = (int)keyData.hashSize;
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = global::NPOI.POIFS.Crypt.HashAlgorithm.FromEcmaId(keyData.hashAlgorithm.ToString());
			base.HashAlgorithm = hashAlgorithm;
			if (base.HashAlgorithm.hashSize != hashSize)
			{
				throw new global::NPOI.EncryptedDocumentException(string.Concat(new string[]
				{
					"Unsupported hash algorithm: ",
					keyData.hashAlgorithm.ToString(),
					" @ ",
					hashSize.ToString(),
					" bytes"
				}));
			}
			int saltSize = (int)keyData.saltSize;
			this.SetKeySalt(keyData.saltValue);
			if (base.KeySalt.Length != saltSize)
			{
				throw new global::NPOI.EncryptedDocumentException("Invalid salt length");
			}
			global::NPOI.OpenXmlFormats.Encryption.CT_DataIntegrity dataIntegrity = ed.GetEncryption().dataIntegrity;
			this.SetEncryptedHmacKey(dataIntegrity.encryptedHmacKey);
			this.SetEncryptedHmacValue(dataIntegrity.encryptedHmacValue);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00037414 File Offset: 0x00035614
		public AgileEncryptionHeader(global::NPOI.POIFS.Crypt.CipherAlgorithm algorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode)
		{
			base.CipherAlgorithm = algorithm;
			base.HashAlgorithm = hashAlgorithm;
			base.KeySize = keyBits;
			base.BlockSize = blockSize;
			base.ChainingMode = chainingMode;
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00037441 File Offset: 0x00035641
		protected void SetKeySalt(byte[] salt)
		{
			if (salt == null || salt.Length != base.BlockSize)
			{
				throw new global::NPOI.EncryptedDocumentException("invalid verifier salt");
			}
			base.KeySalt = salt;
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00037463 File Offset: 0x00035663
		public byte[] GetEncryptedHmacKey()
		{
			return this.encryptedHmacKey;
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0003746B File Offset: 0x0003566B
		public void SetEncryptedHmacKey(byte[] encryptedHmacKey)
		{
			this.encryptedHmacKey = encryptedHmacKey;
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00037474 File Offset: 0x00035674
		public byte[] GetEncryptedHmacValue()
		{
			return this.encryptedHmacValue;
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x0003747C File Offset: 0x0003567C
		public void SetEncryptedHmacValue(byte[] encryptedHmacValue)
		{
			this.encryptedHmacValue = encryptedHmacValue;
		}

		// Token: 0x040004D1 RID: 1233
		private byte[] encryptedHmacKey;

		// Token: 0x040004D2 RID: 1234
		private byte[] encryptedHmacValue;
	}
}
