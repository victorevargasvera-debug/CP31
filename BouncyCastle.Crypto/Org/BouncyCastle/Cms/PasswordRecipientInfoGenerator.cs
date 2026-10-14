using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200054F RID: 1359
	internal class PasswordRecipientInfoGenerator : global::Org.BouncyCastle.Cms.RecipientInfoGenerator
	{
		// Token: 0x0600343F RID: 13375 RVA: 0x000FA034 File Offset: 0x000F8234
		internal PasswordRecipientInfoGenerator()
		{
		}

		// Token: 0x170006DA RID: 1754
		// (set) Token: 0x06003440 RID: 13376 RVA: 0x000FA03C File Offset: 0x000F823C
		internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyDerivationAlgorithm
		{
			set
			{
				this.keyDerivationAlgorithm = value;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (set) Token: 0x06003441 RID: 13377 RVA: 0x000FA045 File Offset: 0x000F8245
		internal global::Org.BouncyCastle.Crypto.Parameters.KeyParameter KeyEncryptionKey
		{
			set
			{
				this.keyEncryptionKey = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (set) Token: 0x06003442 RID: 13378 RVA: 0x000FA04E File Offset: 0x000F824E
		internal string KeyEncryptionKeyOID
		{
			set
			{
				this.keyEncryptionKeyOID = value;
			}
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x000FA058 File Offset: 0x000F8258
		public global::Org.BouncyCastle.Asn1.Cms.RecipientInfo Generate(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter contentEncryptionKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			byte[] keyBytes = contentEncryptionKey.GetKey();
			string rfc3211WrapperName = global::Org.BouncyCastle.Cms.PasswordRecipientInfoGenerator.Helper.GetRfc3211WrapperName(this.keyEncryptionKeyOID);
			global::Org.BouncyCastle.Crypto.IWrapper wrapper = global::Org.BouncyCastle.Cms.PasswordRecipientInfoGenerator.Helper.CreateWrapper(rfc3211WrapperName);
			byte[] iv = new byte[global::Org.BouncyCastle.Utilities.Platform.StartsWith(rfc3211WrapperName, "DESEDE") ? 8 : 16];
			random.NextBytes(iv);
			global::Org.BouncyCastle.Crypto.ICipherParameters parameters = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.keyEncryptionKey, iv);
			wrapper.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(parameters, random));
			global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey = new global::Org.BouncyCastle.Asn1.DerOctetString(wrapper.Wrap(keyBytes, 0, keyBytes.Length));
			global::Org.BouncyCastle.Asn1.DerSequence seq = new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(this.keyEncryptionKeyOID),
				new global::Org.BouncyCastle.Asn1.DerOctetString(iv)
			});
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgPwriKek, seq);
			return new global::Org.BouncyCastle.Asn1.Cms.RecipientInfo(new global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo(this.keyDerivationAlgorithm, keyEncryptionAlgorithm, encryptedKey));
		}

		// Token: 0x04001761 RID: 5985
		private static readonly global::Org.BouncyCastle.Cms.CmsEnvelopedHelper Helper = global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.Instance;

		// Token: 0x04001762 RID: 5986
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm;

		// Token: 0x04001763 RID: 5987
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyEncryptionKey;

		// Token: 0x04001764 RID: 5988
		private string keyEncryptionKeyOID;
	}
}
