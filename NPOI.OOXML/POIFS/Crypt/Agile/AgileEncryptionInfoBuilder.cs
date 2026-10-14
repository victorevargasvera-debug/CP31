using System;
using System.Text;
using System.Xml;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Encryption;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.Agile
{
	// Token: 0x02000115 RID: 277
	public class AgileEncryptionInfoBuilder : global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder
	{
		// Token: 0x06000FAF RID: 4015 RVA: 0x00037488 File Offset: 0x00035688
		public void Initialize(global::NPOI.POIFS.Crypt.EncryptionInfo info, global::NPOI.Util.ILittleEndianInput dis)
		{
			this.info = info;
			global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument ed = global::NPOI.POIFS.Crypt.Agile.AgileEncryptionInfoBuilder.ParseDescriptor((global::NPOI.POIFS.FileSystem.DocumentInputStream)dis);
			this.header = new global::NPOI.POIFS.Crypt.Agile.AgileEncryptionHeader(ed);
			this.verifier = new global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier(ed);
			if (info.VersionMajor == global::NPOI.POIFS.Crypt.EncryptionMode.Agile.VersionMajor && info.VersionMinor == global::NPOI.POIFS.Crypt.EncryptionMode.Agile.VersionMinor)
			{
				this.decryptor = new global::NPOI.POIFS.Crypt.Agile.AgileDecryptor(this);
				this.encryptor = new global::NPOI.POIFS.Crypt.Agile.AgileEncryptor(this);
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000374FC File Offset: 0x000356FC
		public void Initialize(global::NPOI.POIFS.Crypt.EncryptionInfo info, global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode)
		{
			this.info = info;
			if (cipherAlgorithm == null)
			{
				cipherAlgorithm = global::NPOI.POIFS.Crypt.CipherAlgorithm.aes128;
			}
			if (cipherAlgorithm == global::NPOI.POIFS.Crypt.CipherAlgorithm.rc4)
			{
				throw new global::NPOI.EncryptedDocumentException("RC4 must not be used with agile encryption.");
			}
			if (hashAlgorithm == null)
			{
				hashAlgorithm = global::NPOI.POIFS.Crypt.HashAlgorithm.sha1;
			}
			if (chainingMode == null)
			{
				chainingMode = global::NPOI.POIFS.Crypt.ChainingMode.cbc;
			}
			if (chainingMode != global::NPOI.POIFS.Crypt.ChainingMode.cbc && chainingMode != global::NPOI.POIFS.Crypt.ChainingMode.cfb)
			{
				throw new global::NPOI.EncryptedDocumentException("Agile encryption only supports CBC/CFB chaining.");
			}
			if (keyBits == -1)
			{
				keyBits = cipherAlgorithm.defaultKeySize;
			}
			if (blockSize == -1)
			{
				blockSize = cipherAlgorithm.blockSize;
			}
			bool flag = false;
			foreach (int num in cipherAlgorithm.allowedKeySize)
			{
				flag |= (num == keyBits);
			}
			if (!flag)
			{
				throw new global::NPOI.EncryptedDocumentException("KeySize " + keyBits.ToString() + " not allowed for Cipher " + cipherAlgorithm.ToString());
			}
			this.header = new global::NPOI.POIFS.Crypt.Agile.AgileEncryptionHeader(cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode);
			this.verifier = new global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier(cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode);
			this.decryptor = new global::NPOI.POIFS.Crypt.Agile.AgileDecryptor(this);
			this.encryptor = new global::NPOI.POIFS.Crypt.Agile.AgileEncryptor(this);
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x000375FF File Offset: 0x000357FF
		public global::NPOI.POIFS.Crypt.Agile.AgileEncryptionHeader GetHeader()
		{
			return this.header;
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00037607 File Offset: 0x00035807
		public global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier GetVerifier()
		{
			return this.verifier;
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0003760F File Offset: 0x0003580F
		public global::NPOI.POIFS.Crypt.Agile.AgileDecryptor GetDecryptor()
		{
			return this.decryptor;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00037617 File Offset: 0x00035817
		public global::NPOI.POIFS.Crypt.Agile.AgileEncryptor GetEncryptor()
		{
			return this.encryptor;
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0003761F File Offset: 0x0003581F
		public global::NPOI.POIFS.Crypt.EncryptionInfo GetInfo()
		{
			return this.info;
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00037628 File Offset: 0x00035828
		public static global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument ParseDescriptor(string descriptor)
		{
			global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument result;
			try
			{
				result = global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.Parse(descriptor);
			}
			catch (global::System.Xml.XmlException cause)
			{
				throw new global::NPOI.EncryptedDocumentException("Unable to parse encryption descriptor", cause);
			}
			return result;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0003765C File Offset: 0x0003585C
		protected static global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument ParseDescriptor(global::NPOI.POIFS.FileSystem.DocumentInputStream descriptor)
		{
			global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument result;
			try
			{
				global::System.Xml.XmlDocument xmlDoc = new global::System.Xml.XmlDocument();
				byte[] array = new byte[descriptor.Length - descriptor.Position];
				descriptor.ReadFully(array);
				string @string = global::System.Text.Encoding.UTF8.GetString(array);
				global::NPOI.OpenXml4Net.Util.XmlHelper.LoadXmlSafe(xmlDoc, @string, global::System.Text.Encoding.UTF8);
				result = global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.Parse(xmlDoc);
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException("Unable to parse encryption descriptor", cause);
			}
			return result;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x000375FF File Offset: 0x000357FF
		global::NPOI.POIFS.Crypt.EncryptionHeader global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetHeader()
		{
			return this.header;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00037607 File Offset: 0x00035807
		global::NPOI.POIFS.Crypt.EncryptionVerifier global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetVerifier()
		{
			return this.verifier;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0003760F File Offset: 0x0003580F
		global::NPOI.POIFS.Crypt.Decryptor global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetDecryptor()
		{
			return this.decryptor;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00037617 File Offset: 0x00035817
		global::NPOI.POIFS.Crypt.Encryptor global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetEncryptor()
		{
			return this.encryptor;
		}

		// Token: 0x040004D3 RID: 1235
		private global::NPOI.POIFS.Crypt.EncryptionInfo info;

		// Token: 0x040004D4 RID: 1236
		private global::NPOI.POIFS.Crypt.Agile.AgileEncryptionHeader header;

		// Token: 0x040004D5 RID: 1237
		private global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier verifier;

		// Token: 0x040004D6 RID: 1238
		private global::NPOI.POIFS.Crypt.Agile.AgileDecryptor decryptor;

		// Token: 0x040004D7 RID: 1239
		private global::NPOI.POIFS.Crypt.Agile.AgileEncryptor encryptor;
	}
}
