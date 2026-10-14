using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NPOI.OpenXmlFormats.Encryption;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.Agile
{
	// Token: 0x02000118 RID: 280
	public class AgileEncryptor : global::NPOI.POIFS.Crypt.Encryptor
	{
		// Token: 0x06000FC9 RID: 4041 RVA: 0x000379DA File Offset: 0x00035BDA
		protected internal AgileEncryptor(global::NPOI.POIFS.Crypt.Agile.AgileEncryptionInfoBuilder builder)
		{
			this.builder = builder;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000379F0 File Offset: 0x00035BF0
		public override void ConfirmPassword(string password)
		{
			global::System.Random random = new global::System.Random();
			int blockSize = this.builder.GetHeader().BlockSize;
			int num = this.builder.GetHeader().KeySize / 8;
			int hashSize = this.builder.GetHeader().HashAlgorithm.hashSize;
			byte[] array = new byte[blockSize];
			byte[] array2 = new byte[blockSize];
			byte[] array3 = new byte[blockSize];
			byte[] array4 = new byte[num];
			byte[] buffer = new byte[hashSize];
			random.NextBytes(array);
			random.NextBytes(array2);
			random.NextBytes(array3);
			random.NextBytes(array4);
			random.NextBytes(buffer);
			this.ConfirmPassword(password, array4, array3, array, array2, buffer);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00037A94 File Offset: 0x00035C94
		public override void ConfirmPassword(string password, byte[] keySpec, byte[] keySalt, byte[] verifier, byte[] verifierSalt, byte[] integritySalt)
		{
			global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier verifier2 = this.builder.GetVerifier();
			verifier2.Salt = verifierSalt;
			global::NPOI.POIFS.Crypt.Agile.AgileEncryptionHeader header = this.builder.GetHeader();
			header.KeySalt = keySalt;
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = verifier2.HashAlgorithm;
			int blockSize = header.BlockSize;
			this.pwHash = global::NPOI.POIFS.Crypt.CryptoFunctions.HashPassword(password, hashAlgorithm, verifierSalt, verifier2.SpinCount);
			byte[] encryptedVerifier = global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.hashInput(this.builder, this.pwHash, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kVerifierInputBlock, verifier, global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE);
			verifier2.EncryptedVerifier = encryptedVerifier;
			byte[] inputKey = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(hashAlgorithm).Digest(verifier);
			byte[] encryptedVerifierHash = global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.hashInput(this.builder, this.pwHash, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kHashedVerifierBlock, inputKey, global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE);
			verifier2.EncryptedVerifierHash = encryptedVerifierHash;
			byte[] encryptedKey = global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.hashInput(this.builder, this.pwHash, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kCryptoKeyBlock, keySpec, global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE);
			verifier2.EncryptedKey = encryptedKey;
			global::NPOI.POIFS.Crypt.ISecretKey secretKey = new global::NPOI.POIFS.Crypt.SecretKeySpec(keySpec, verifier2.CipherAlgorithm.jceId);
			base.SetSecretKey(secretKey);
			this.integritySalt = integritySalt;
			try
			{
				byte[] vec = global::NPOI.POIFS.Crypt.CryptoFunctions.GenerateIv(hashAlgorithm, header.KeySalt, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kIntegrityKeyBlock, header.BlockSize);
				global::NPOI.POIFS.Crypt.Cipher cipher = global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(secretKey, verifier2.CipherAlgorithm, verifier2.ChainingMode, vec, global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE);
				byte[] block = global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock0(integritySalt, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.GetNextBlockSize(integritySalt.Length, blockSize));
				byte[] encryptedHmacKey = cipher.DoFinal(block);
				header.SetEncryptedHmacKey(encryptedHmacKey);
				cipher = global::NPOI.POIFS.Crypt.Cipher.GetInstance("RSA");
				foreach (global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry agileCertificateEntry in verifier2.GetCertificates())
				{
					cipher.Init(global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE, agileCertificateEntry.x509.GetPublicKey());
					agileCertificateEntry.encryptedKey = cipher.DoFinal(base.GetSecretKey().GetEncoded());
					global::NPOI.POIFS.Crypt.CryptoFunctions.Mac mac = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMac(hashAlgorithm);
					mac.Init(base.GetSecretKey());
					agileCertificateEntry.certVerifier = mac.DoFinal(agileCertificateEntry.x509.GetEncoded());
				}
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException(cause);
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00037CB0 File Offset: 0x00035EB0
		public override global::NPOI.Util.OutputStream GetDataStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			new global::NPOI.POIFS.Crypt.Agile.AgileEncryptor.AgileCipherOutputStream(dir, this.builder, base.GetSecretKey(), this);
			throw new global::System.NotImplementedException("AgileCipherOutputStream should be derived from OutputStream");
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00037CD0 File Offset: 0x00035ED0
		protected void UpdateIntegrityHMAC(global::System.IO.FileInfo tmpFile, int oleStreamSize)
		{
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = this.builder.GetVerifier().HashAlgorithm;
			global::NPOI.POIFS.Crypt.CryptoFunctions.Mac mac = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMac(hashAlgorithm);
			mac.Init(new global::NPOI.POIFS.Crypt.SecretKeySpec(this.integritySalt, hashAlgorithm.jceHmacId));
			byte[] array = new byte[1024];
			global::NPOI.Util.LittleEndian.PutLong(array, 0, (long)oleStreamSize);
			mac.Update(array, 0, 8);
			global::System.IO.FileStream fileStream = tmpFile.Create();
			try
			{
				int readBytes;
				while ((readBytes = fileStream.Read(array, 0, array.Length)) > 0)
				{
					mac.Update(array, 0, readBytes);
				}
			}
			finally
			{
				fileStream.Close();
			}
			byte[] array2 = mac.DoFinal();
			global::NPOI.POIFS.Crypt.Agile.AgileEncryptionHeader header = this.builder.GetHeader();
			int blockSize = header.BlockSize;
			byte[] vec = global::NPOI.POIFS.Crypt.CryptoFunctions.GenerateIv(header.HashAlgorithm, header.KeySalt, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kIntegrityValueBlock, blockSize);
			global::NPOI.POIFS.Crypt.Cipher cipher = global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(base.GetSecretKey(), header.CipherAlgorithm, header.ChainingMode, vec, global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE);
			byte[] block = global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock0(array2, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.GetNextBlockSize(array2.Length, blockSize));
			byte[] encryptedHmacValue = cipher.DoFinal(block);
			header.SetEncryptedHmacValue(encryptedHmacValue);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00037DE8 File Offset: 0x00035FE8
		protected global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument CreateEncryptionDocument()
		{
			global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier verifier = this.builder.GetVerifier();
			global::NPOI.POIFS.Crypt.Agile.AgileEncryptionHeader header = this.builder.GetHeader();
			global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument encryptionDocument = global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.NewInstance();
			global::NPOI.OpenXmlFormats.Encryption.CT_Encryption ct_Encryption = encryptionDocument.AddNewEncryption();
			global::NPOI.OpenXmlFormats.Encryption.CT_KeyData ct_KeyData = ct_Encryption.AddNewKeyData();
			global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptors ct_KeyEncryptors = ct_Encryption.AddNewKeyEncryptors();
			global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor ct_KeyEncryptor = ct_KeyEncryptors.AddNewKeyEncryptor();
			ct_KeyEncryptor.uri = this.passwordUri;
			global::NPOI.OpenXmlFormats.Encryption.CT_PasswordKeyEncryptor ct_PasswordKeyEncryptor = ct_KeyEncryptor.AddNewEncryptedPasswordKey();
			ct_PasswordKeyEncryptor.spinCount = (uint)verifier.SpinCount;
			ct_KeyData.saltSize = (uint)header.BlockSize;
			ct_PasswordKeyEncryptor.saltSize = (uint)header.BlockSize;
			ct_KeyData.blockSize = (uint)header.BlockSize;
			ct_PasswordKeyEncryptor.blockSize = (uint)header.BlockSize;
			ct_KeyData.keyBits = (uint)header.KeySize;
			ct_PasswordKeyEncryptor.keyBits = (uint)header.KeySize;
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = header.HashAlgorithm;
			ct_KeyData.hashSize = (uint)hashAlgorithm.hashSize;
			ct_PasswordKeyEncryptor.hashSize = (uint)hashAlgorithm.hashSize;
			global::NPOI.OpenXmlFormats.Encryption.ST_CipherAlgorithm? st_CipherAlgorithm = (global::NPOI.OpenXmlFormats.Encryption.ST_CipherAlgorithm?)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Encryption.ST_CipherAlgorithm), header.CipherAlgorithm.xmlId);
			if (st_CipherAlgorithm == null)
			{
				string str = "CipherAlgorithm ";
				global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm = header.CipherAlgorithm;
				throw new global::NPOI.EncryptedDocumentException(str + ((cipherAlgorithm != null) ? cipherAlgorithm.ToString() : null) + " not supported.");
			}
			ct_KeyData.cipherAlgorithm = st_CipherAlgorithm.Value;
			ct_PasswordKeyEncryptor.cipherAlgorithm = st_CipherAlgorithm.Value;
			string jceId = header.ChainingMode.jceId;
			if (!(jceId == "cbc"))
			{
				if (!(jceId == "cfb"))
				{
					string str2 = "ChainingMode ";
					global::NPOI.POIFS.Crypt.ChainingMode chainingMode = header.ChainingMode;
					throw new global::NPOI.EncryptedDocumentException(str2 + ((chainingMode != null) ? chainingMode.ToString() : null) + " not supported.");
				}
				ct_KeyData.cipherChaining = global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining.ChainingModeCFB;
				ct_PasswordKeyEncryptor.cipherChaining = global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining.ChainingModeCFB;
			}
			else
			{
				ct_KeyData.cipherChaining = global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining.ChainingModeCBC;
				ct_PasswordKeyEncryptor.cipherChaining = global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining.ChainingModeCBC;
			}
			global::NPOI.OpenXmlFormats.Encryption.ST_HashAlgorithm? st_HashAlgorithm = (global::NPOI.OpenXmlFormats.Encryption.ST_HashAlgorithm?)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Encryption.ST_HashAlgorithm), hashAlgorithm.ecmaString);
			if (st_HashAlgorithm == null)
			{
				string str3 = "HashAlgorithm ";
				global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm2 = hashAlgorithm;
				throw new global::NPOI.EncryptedDocumentException(str3 + ((hashAlgorithm2 != null) ? hashAlgorithm2.ToString() : null) + " not supported.");
			}
			ct_KeyData.hashAlgorithm = st_HashAlgorithm.Value;
			ct_PasswordKeyEncryptor.hashAlgorithm = st_HashAlgorithm.Value;
			ct_KeyData.saltValue = header.KeySalt;
			ct_PasswordKeyEncryptor.saltValue = verifier.Salt;
			ct_PasswordKeyEncryptor.encryptedVerifierHashInput = verifier.EncryptedVerifier;
			ct_PasswordKeyEncryptor.encryptedVerifierHashValue = verifier.EncryptedVerifierHash;
			ct_PasswordKeyEncryptor.encryptedKeyValue = verifier.EncryptedKey;
			global::NPOI.OpenXmlFormats.Encryption.CT_DataIntegrity ct_DataIntegrity = ct_Encryption.AddNewDataIntegrity();
			ct_DataIntegrity.encryptedHmacKey = header.GetEncryptedHmacKey();
			ct_DataIntegrity.encryptedHmacValue = header.GetEncryptedHmacValue();
			foreach (global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry agileCertificateEntry in verifier.GetCertificates())
			{
				global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor ct_KeyEncryptor2 = ct_KeyEncryptors.AddNewKeyEncryptor();
				ct_KeyEncryptor2.uri = this.certificateUri;
				global::NPOI.OpenXmlFormats.Encryption.CT_CertificateKeyEncryptor ct_CertificateKeyEncryptor = ct_KeyEncryptor2.AddNewEncryptedCertificateKey();
				try
				{
					ct_CertificateKeyEncryptor.X509Certificate = agileCertificateEntry.x509.GetEncoded();
				}
				catch (global::System.Exception cause)
				{
					throw new global::NPOI.EncryptedDocumentException(cause);
				}
				ct_CertificateKeyEncryptor.encryptedKeyValue = agileCertificateEntry.encryptedKey;
				ct_CertificateKeyEncryptor.certVerifier = agileCertificateEntry.certVerifier;
			}
			return encryptionDocument;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00038108 File Offset: 0x00036308
		protected void marshallEncryptionDocument(global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument ed, global::NPOI.Util.LittleEndianByteArrayOutputStream os)
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
			dictionary.Add(this.passwordUri.ToString(), "p");
			dictionary.Add(this.certificateUri.ToString(), "c");
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			try
			{
				byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>\r\n");
				memoryStream.Write(bytes, 0, bytes.Length);
				ed.Save(memoryStream);
				os.Write(memoryStream.ToArray());
			}
			catch (global::System.IO.IOException cause)
			{
				throw new global::NPOI.EncryptedDocumentException("error marshalling encryption info document", cause);
			}
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x000381A4 File Offset: 0x000363A4
		protected void CreateEncryptionInfoEntry(global::NPOI.POIFS.FileSystem.DirectoryNode dir, global::System.IO.FileInfo tmpFile)
		{
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.AddDefaultDataSpace(dir);
			this.builder.GetInfo();
		}

		// Token: 0x040004D9 RID: 1241
		private global::NPOI.POIFS.Crypt.Agile.AgileEncryptionInfoBuilder builder;

		// Token: 0x040004DA RID: 1242
		private byte[] integritySalt;

		// Token: 0x040004DB RID: 1243
		private byte[] pwHash;

		// Token: 0x040004DC RID: 1244
		private global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptorUri passwordUri;

		// Token: 0x040004DD RID: 1245
		private global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptorUri certificateUri = global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptorUri.httpschemasmicrosoftcomoffice2006keyEncryptorcertificate;

		// Token: 0x02000151 RID: 337
		private class AgileCipherOutputStream : global::NPOI.POIFS.Crypt.ChunkedCipherOutputStream
		{
			// Token: 0x06001080 RID: 4224 RVA: 0x00039518 File Offset: 0x00037718
			public AgileCipherOutputStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir, global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder, global::NPOI.POIFS.Crypt.ISecretKey skey, global::NPOI.POIFS.Crypt.Agile.AgileEncryptor encryptor) : base(dir, 4096, builder, encryptor)
			{
				this.builder = builder;
				this.skey = skey;
				this.encryptor = encryptor;
			}

			// Token: 0x06001081 RID: 4225 RVA: 0x0003953F File Offset: 0x0003773F
			protected override global::NPOI.POIFS.Crypt.Cipher InitCipherForBlock(global::NPOI.POIFS.Crypt.Cipher existing, int block, bool lastChunk)
			{
				return global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.InitCipherForBlock(existing, block, lastChunk, this.builder, this.skey, global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE);
			}

			// Token: 0x06001082 RID: 4226 RVA: 0x0003955A File Offset: 0x0003775A
			protected override void CalculateChecksum(global::System.IO.FileInfo fileOut, int oleStreamSize)
			{
				((global::NPOI.POIFS.Crypt.Agile.AgileEncryptor)this.encryptor).UpdateIntegrityHMAC(fileOut, oleStreamSize);
			}

			// Token: 0x06001083 RID: 4227 RVA: 0x0003956E File Offset: 0x0003776E
			protected override void CreateEncryptionInfoEntry(global::NPOI.POIFS.FileSystem.DirectoryNode dir, global::System.IO.FileInfo tmpFile)
			{
				((global::NPOI.POIFS.Crypt.Agile.AgileEncryptor)this.encryptor).CreateEncryptionInfoEntry(dir, tmpFile);
			}

			// Token: 0x0400053E RID: 1342
			private global::NPOI.POIFS.Crypt.ISecretKey skey;
		}
	}
}
