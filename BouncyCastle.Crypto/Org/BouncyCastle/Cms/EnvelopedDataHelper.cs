using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000544 RID: 1348
	internal class EnvelopedDataHelper
	{
		// Token: 0x06003409 RID: 13321 RVA: 0x000F8F54 File Offset: 0x000F7154
		static EnvelopedDataHelper()
		{
			global::Org.BouncyCastle.Cms.EnvelopedDataHelper.BaseCipherNames.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc, "DESEDE");
			global::Org.BouncyCastle.Cms.EnvelopedDataHelper.BaseCipherNames.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc, "AES");
			global::Org.BouncyCastle.Cms.EnvelopedDataHelper.BaseCipherNames.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc, "AES");
			global::Org.BouncyCastle.Cms.EnvelopedDataHelper.BaseCipherNames.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc, "AES");
			global::Org.BouncyCastle.Cms.EnvelopedDataHelper.MacAlgNames.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc, "DESEDEMac");
			global::Org.BouncyCastle.Cms.EnvelopedDataHelper.MacAlgNames.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc, "AESMac");
			global::Org.BouncyCastle.Cms.EnvelopedDataHelper.MacAlgNames.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc, "AESMac");
			global::Org.BouncyCastle.Cms.EnvelopedDataHelper.MacAlgNames.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc, "AESMac");
			global::Org.BouncyCastle.Cms.EnvelopedDataHelper.MacAlgNames.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc, "RC2Mac");
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x000F9029 File Offset: 0x000F7229
		public static object CreateContentCipher(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters encKey, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier encryptionAlgID)
		{
			return global::Org.BouncyCastle.Crypto.Utilities.CipherFactory.CreateContentCipher(forEncryption, encKey, encryptionAlgID);
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x000F9033 File Offset: 0x000F7233
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GenerateEncryptionAlgID(global::Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionOID, global::Org.BouncyCastle.Crypto.Parameters.KeyParameter encKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			return global::Org.BouncyCastle.Crypto.Utilities.AlgorithmIdentifierFactory.GenerateEncryptionAlgID(encryptionOID, encKey.GetKey().Length * 8, random);
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x000F9046 File Offset: 0x000F7246
		public global::Org.BouncyCastle.Crypto.CipherKeyGenerator CreateKeyGenerator(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			return global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateKeyGenerator(algorithm, random);
		}

		// Token: 0x04001748 RID: 5960
		private static readonly global::System.Collections.IDictionary BaseCipherNames = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001749 RID: 5961
		private static readonly global::System.Collections.IDictionary MacAlgNames = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
