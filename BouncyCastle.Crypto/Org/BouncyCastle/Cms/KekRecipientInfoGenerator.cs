using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Kisa;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000546 RID: 1350
	internal class KekRecipientInfoGenerator : global::Org.BouncyCastle.Cms.RecipientInfoGenerator
	{
		// Token: 0x0600340F RID: 13327 RVA: 0x000F9057 File Offset: 0x000F7257
		internal KekRecipientInfoGenerator()
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (set) Token: 0x06003410 RID: 13328 RVA: 0x000F905F File Offset: 0x000F725F
		internal global::Org.BouncyCastle.Asn1.Cms.KekIdentifier KekIdentifier
		{
			set
			{
				this.kekIdentifier = value;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (set) Token: 0x06003411 RID: 13329 RVA: 0x000F9068 File Offset: 0x000F7268
		internal global::Org.BouncyCastle.Crypto.Parameters.KeyParameter KeyEncryptionKey
		{
			set
			{
				this.keyEncryptionKey = value;
				this.keyEncryptionAlgorithm = global::Org.BouncyCastle.Cms.KekRecipientInfoGenerator.DetermineKeyEncAlg(this.keyEncryptionKeyOID, this.keyEncryptionKey);
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (set) Token: 0x06003412 RID: 13330 RVA: 0x000F9088 File Offset: 0x000F7288
		internal string KeyEncryptionKeyOID
		{
			set
			{
				this.keyEncryptionKeyOID = value;
			}
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x000F9094 File Offset: 0x000F7294
		public global::Org.BouncyCastle.Asn1.Cms.RecipientInfo Generate(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter contentEncryptionKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			byte[] keyBytes = contentEncryptionKey.GetKey();
			global::Org.BouncyCastle.Crypto.IWrapper wrapper = global::Org.BouncyCastle.Cms.KekRecipientInfoGenerator.Helper.CreateWrapper(this.keyEncryptionAlgorithm.Algorithm.Id);
			wrapper.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(this.keyEncryptionKey, random));
			global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey = new global::Org.BouncyCastle.Asn1.DerOctetString(wrapper.Wrap(keyBytes, 0, keyBytes.Length));
			return new global::Org.BouncyCastle.Asn1.Cms.RecipientInfo(new global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo(this.kekIdentifier, this.keyEncryptionAlgorithm, encryptedKey));
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x000F90FC File Offset: 0x000F72FC
		private static global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DetermineKeyEncAlg(string algorithm, global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key)
		{
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(algorithm, "DES"))
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgCms3DesWrap, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			}
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(algorithm, "RC2"))
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgCmsRC2Wrap, new global::Org.BouncyCastle.Asn1.DerInteger(58));
			}
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(algorithm, "AES"))
			{
				int length = key.GetKey().Length * 8;
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier wrapOid;
				if (length == 128)
				{
					wrapOid = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Wrap;
				}
				else if (length == 192)
				{
					wrapOid = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Wrap;
				}
				else
				{
					if (length != 256)
					{
						throw new global::System.ArgumentException("illegal keysize in AES");
					}
					wrapOid = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Wrap;
				}
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(wrapOid);
			}
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(algorithm, "SEED"))
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdNpkiAppCmsSeedWrap);
			}
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(algorithm, "CAMELLIA"))
			{
				int length2 = key.GetKey().Length * 8;
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier wrapOid2;
				if (length2 == 128)
				{
					wrapOid2 = global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Wrap;
				}
				else if (length2 == 192)
				{
					wrapOid2 = global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Wrap;
				}
				else
				{
					if (length2 != 256)
					{
						throw new global::System.ArgumentException("illegal keysize in Camellia");
					}
					wrapOid2 = global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Wrap;
				}
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(wrapOid2);
			}
			throw new global::System.ArgumentException("unknown algorithm");
		}

		// Token: 0x0400174A RID: 5962
		private static readonly global::Org.BouncyCastle.Cms.CmsEnvelopedHelper Helper = global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.Instance;

		// Token: 0x0400174B RID: 5963
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyEncryptionKey;

		// Token: 0x0400174C RID: 5964
		private string keyEncryptionKeyOID;

		// Token: 0x0400174D RID: 5965
		private global::Org.BouncyCastle.Asn1.Cms.KekIdentifier kekIdentifier;

		// Token: 0x0400174E RID: 5966
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm;
	}
}
