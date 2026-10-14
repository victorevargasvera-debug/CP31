using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Encryption;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;

namespace NPOI.POIFS.Crypt.Agile
{
	// Token: 0x02000116 RID: 278
	public class AgileEncryptionVerifier : global::NPOI.POIFS.Crypt.EncryptionVerifier
	{
		// Token: 0x06000FBD RID: 4029 RVA: 0x000376C8 File Offset: 0x000358C8
		public AgileEncryptionVerifier(string descriptor) : this(global::NPOI.POIFS.Crypt.Agile.AgileEncryptionInfoBuilder.ParseDescriptor(descriptor))
		{
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x000376D8 File Offset: 0x000358D8
		protected internal AgileEncryptionVerifier(global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument ed)
		{
			this.certList = new global::System.Collections.Generic.List<global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry>();
			base..ctor();
			global::System.Collections.Generic.IEnumerator<global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor> enumerator = ed.GetEncryption().keyEncryptors.keyEncryptor.GetEnumerator();
			global::NPOI.OpenXmlFormats.Encryption.CT_PasswordKeyEncryptor ct_PasswordKeyEncryptor;
			try
			{
				enumerator.MoveNext();
				ct_PasswordKeyEncryptor = (enumerator.Current.Item as global::NPOI.OpenXmlFormats.Encryption.CT_PasswordKeyEncryptor);
				if (ct_PasswordKeyEncryptor == null)
				{
					throw new global::System.NullReferenceException("encryptedKey not Set");
				}
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException("Unable to parse keyData", cause);
			}
			int keyBits = (int)ct_PasswordKeyEncryptor.keyBits;
			global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm = global::NPOI.POIFS.Crypt.CipherAlgorithm.FromXmlId(ct_PasswordKeyEncryptor.cipherAlgorithm.ToString(), keyBits);
			base.CipherAlgorithm = cipherAlgorithm;
			int hashSize = (int)ct_PasswordKeyEncryptor.hashSize;
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = global::NPOI.POIFS.Crypt.HashAlgorithm.FromEcmaId(ct_PasswordKeyEncryptor.hashAlgorithm.ToString());
			base.HashAlgorithm = hashAlgorithm;
			if (base.HashAlgorithm.hashSize != hashSize)
			{
				throw new global::NPOI.EncryptedDocumentException(string.Concat(new string[]
				{
					"Unsupported hash algorithm: ",
					ct_PasswordKeyEncryptor.hashAlgorithm.ToString(),
					" @ ",
					hashSize.ToString(),
					" bytes"
				}));
			}
			base.SpinCount = (int)ct_PasswordKeyEncryptor.spinCount;
			base.EncryptedVerifier = ct_PasswordKeyEncryptor.encryptedVerifierHashInput;
			base.Salt = ct_PasswordKeyEncryptor.saltValue;
			base.EncryptedKey = ct_PasswordKeyEncryptor.encryptedKeyValue;
			base.EncryptedVerifierHash = ct_PasswordKeyEncryptor.encryptedVerifierHashValue;
			if (ct_PasswordKeyEncryptor.saltSize != (uint)base.Salt.Length)
			{
				throw new global::NPOI.EncryptedDocumentException("Invalid salt size");
			}
			global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining cipherChaining = ct_PasswordKeyEncryptor.cipherChaining;
			if (cipherChaining != global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining.ChainingModeCBC)
			{
				if (cipherChaining != global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining.ChainingModeCFB)
				{
					throw new global::NPOI.EncryptedDocumentException("Unsupported chaining mode - " + ct_PasswordKeyEncryptor.cipherChaining.ToString());
				}
				base.ChainingMode = global::NPOI.POIFS.Crypt.ChainingMode.cfb;
			}
			else
			{
				base.ChainingMode = global::NPOI.POIFS.Crypt.ChainingMode.cbc;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor ct_KeyEncryptor = enumerator.Current;
					global::NPOI.OpenXmlFormats.Encryption.CT_CertificateKeyEncryptor ct_CertificateKeyEncryptor = ct_KeyEncryptor.Item as global::NPOI.OpenXmlFormats.Encryption.CT_CertificateKeyEncryptor;
					global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry agileCertificateEntry = new global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry();
					agileCertificateEntry.certVerifier = ct_CertificateKeyEncryptor.certVerifier;
					agileCertificateEntry.encryptedKey = ct_CertificateKeyEncryptor.encryptedKeyValue;
					agileCertificateEntry.x509 = new global::Org.BouncyCastle.X509.X509Certificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(ct_CertificateKeyEncryptor.X509Certificate));
					this.certList.Add(agileCertificateEntry);
				}
			}
			catch (global::System.Exception cause2)
			{
				throw new global::NPOI.EncryptedDocumentException("can't parse X509 certificate", cause2);
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00037934 File Offset: 0x00035B34
		public AgileEncryptionVerifier(global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode)
		{
			this.certList = new global::System.Collections.Generic.List<global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry>();
			base..ctor();
			base.CipherAlgorithm = cipherAlgorithm;
			base.HashAlgorithm = hashAlgorithm;
			base.ChainingMode = chainingMode;
			base.SpinCount = 100000;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00037968 File Offset: 0x00035B68
		protected void SetSalt(byte[] salt)
		{
			if (salt == null || salt.Length != base.CipherAlgorithm.blockSize)
			{
				throw new global::NPOI.EncryptedDocumentException("invalid verifier salt");
			}
			base.Salt = salt;
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0003798F File Offset: 0x00035B8F
		protected void SetEncryptedVerifier(byte[] encryptedVerifier)
		{
			base.EncryptedVerifier = encryptedVerifier;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00037998 File Offset: 0x00035B98
		protected void SetEncryptedVerifierHash(byte[] encryptedVerifierHash)
		{
			base.EncryptedVerifierHash = encryptedVerifierHash;
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000379A1 File Offset: 0x00035BA1
		protected void SetEncryptedKey(byte[] encryptedKey)
		{
			base.EncryptedKey = encryptedKey;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x000379AC File Offset: 0x00035BAC
		public void AddCertificate(global::Org.BouncyCastle.X509.X509Certificate x509)
		{
			global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry agileCertificateEntry = new global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry();
			agileCertificateEntry.x509 = x509;
			this.certList.Add(agileCertificateEntry);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000379D2 File Offset: 0x00035BD2
		public global::System.Collections.Generic.List<global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry> GetCertificates()
		{
			return this.certList;
		}

		// Token: 0x040004D8 RID: 1240
		private global::System.Collections.Generic.List<global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry> certList;

		// Token: 0x02000150 RID: 336
		public class AgileCertificateEntry
		{
			// Token: 0x0400053B RID: 1339
			internal global::Org.BouncyCastle.X509.X509Certificate x509;

			// Token: 0x0400053C RID: 1340
			internal byte[] encryptedKey;

			// Token: 0x0400053D RID: 1341
			internal byte[] certVerifier;
		}
	}
}
