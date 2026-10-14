using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Cms.Ecc;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000548 RID: 1352
	internal class KeyAgreeRecipientInfoGenerator : global::Org.BouncyCastle.Cms.RecipientInfoGenerator
	{
		// Token: 0x06003418 RID: 13336 RVA: 0x000F930C File Offset: 0x000F750C
		internal KeyAgreeRecipientInfoGenerator()
		{
		}

		// Token: 0x170006D5 RID: 1749
		// (set) Token: 0x06003419 RID: 13337 RVA: 0x000F9314 File Offset: 0x000F7514
		internal global::Org.BouncyCastle.Asn1.DerObjectIdentifier KeyAgreementOID
		{
			set
			{
				this.keyAgreementOID = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (set) Token: 0x0600341A RID: 13338 RVA: 0x000F931D File Offset: 0x000F751D
		internal global::Org.BouncyCastle.Asn1.DerObjectIdentifier KeyEncryptionOID
		{
			set
			{
				this.keyEncryptionOID = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (set) Token: 0x0600341B RID: 13339 RVA: 0x000F9326 File Offset: 0x000F7526
		internal global::System.Collections.ICollection RecipientCerts
		{
			set
			{
				this.recipientCerts = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(value);
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (set) Token: 0x0600341C RID: 13340 RVA: 0x000F9334 File Offset: 0x000F7534
		internal global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair SenderKeyPair
		{
			set
			{
				this.senderKeyPair = value;
			}
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x000F9340 File Offset: 0x000F7540
		public global::Org.BouncyCastle.Asn1.Cms.RecipientInfo Generate(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter contentEncryptionKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			byte[] keyBytes = contentEncryptionKey.GetKey();
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter senderPublicKey = this.senderKeyPair.Public;
			global::Org.BouncyCastle.Crypto.ICipherParameters senderPrivateParams = this.senderKeyPair.Private;
			global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey originator;
			try
			{
				originator = new global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey(global::Org.BouncyCastle.Cms.KeyAgreeRecipientInfoGenerator.CreateOriginatorPublicKey(senderPublicKey));
			}
			catch (global::System.IO.IOException e)
			{
				string str = "cannot extract originator public key: ";
				global::System.IO.IOException ex = e;
				throw new global::Org.BouncyCastle.Security.InvalidKeyException(str + ((ex != null) ? ex.ToString() : null));
			}
			global::Org.BouncyCastle.Asn1.Asn1OctetString ukm = null;
			if (this.keyAgreementOID.Id.Equals(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.ECMqvSha1Kdf))
			{
				try
				{
					global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator keyPairGenerator = global::Org.BouncyCastle.Security.GeneratorUtilities.GetKeyPairGenerator(this.keyAgreementOID);
					keyPairGenerator.Init(((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)senderPublicKey).CreateKeyGenerationParameters(random));
					global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair ephemKP = keyPairGenerator.GenerateKeyPair();
					ukm = new global::Org.BouncyCastle.Asn1.DerOctetString(new global::Org.BouncyCastle.Asn1.Cms.Ecc.MQVuserKeyingMaterial(global::Org.BouncyCastle.Cms.KeyAgreeRecipientInfoGenerator.CreateOriginatorPublicKey(ephemKP.Public), null));
					senderPrivateParams = new global::Org.BouncyCastle.Crypto.Parameters.MqvPrivateParameters((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)senderPrivateParams, (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)ephemKP.Private, (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)ephemKP.Public);
				}
				catch (global::System.IO.IOException e2)
				{
					string str2 = "cannot extract MQV ephemeral public key: ";
					global::System.IO.IOException ex2 = e2;
					throw new global::Org.BouncyCastle.Security.InvalidKeyException(str2 + ((ex2 != null) ? ex2.ToString() : null));
				}
				catch (global::Org.BouncyCastle.Security.SecurityUtilityException e3)
				{
					string str3 = "cannot determine MQV ephemeral key pair parameters from public key: ";
					global::Org.BouncyCastle.Security.SecurityUtilityException ex3 = e3;
					throw new global::Org.BouncyCastle.Security.InvalidKeyException(str3 + ((ex3 != null) ? ex3.ToString() : null));
				}
			}
			global::Org.BouncyCastle.Asn1.DerSequence paramSeq = new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.keyEncryptionOID,
				global::Org.BouncyCastle.Asn1.DerNull.Instance
			});
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncAlg = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(this.keyAgreementOID, paramSeq);
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector recipientEncryptedKeys = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in this.recipientCerts)
			{
				global::Org.BouncyCastle.X509.X509Certificate recipientCert = (global::Org.BouncyCastle.X509.X509Certificate)obj;
				global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert;
				try
				{
					tbsCert = global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(recipientCert.GetTbsCertificate()));
				}
				catch (global::System.Exception)
				{
					throw new global::System.ArgumentException("can't extract TBS structure from certificate");
				}
				global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier karid = new global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier(new global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber(tbsCert.Issuer, tbsCert.SerialNumber.Value));
				global::Org.BouncyCastle.Crypto.ICipherParameters recipientPublicParams = recipientCert.GetPublicKey();
				if (this.keyAgreementOID.Id.Equals(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.ECMqvSha1Kdf))
				{
					recipientPublicParams = new global::Org.BouncyCastle.Crypto.Parameters.MqvPublicParameters((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)recipientPublicParams, (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)recipientPublicParams);
				}
				global::Org.BouncyCastle.Crypto.IBasicAgreement basicAgreementWithKdf = global::Org.BouncyCastle.Security.AgreementUtilities.GetBasicAgreementWithKdf(this.keyAgreementOID, this.keyEncryptionOID.Id);
				basicAgreementWithKdf.Init(new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(senderPrivateParams, random));
				global::Org.BouncyCastle.Math.BigInteger s = basicAgreementWithKdf.CalculateAgreement(recipientPublicParams);
				int keyEncryptionKeySize = global::Org.BouncyCastle.Security.GeneratorUtilities.GetDefaultKeySize(this.keyEncryptionOID) / 8;
				byte[] keyEncryptionKeyBytes = global::Org.BouncyCastle.Asn1.X9.X9IntegerConverter.IntegerToBytes(s, keyEncryptionKeySize);
				global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyEncryptionKey = global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(this.keyEncryptionOID, keyEncryptionKeyBytes);
				global::Org.BouncyCastle.Crypto.IWrapper wrapper = global::Org.BouncyCastle.Cms.KeyAgreeRecipientInfoGenerator.Helper.CreateWrapper(this.keyEncryptionOID.Id);
				wrapper.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(keyEncryptionKey, random));
				global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey = new global::Org.BouncyCastle.Asn1.DerOctetString(wrapper.Wrap(keyBytes, 0, keyBytes.Length));
				recipientEncryptedKeys.Add(new global::Org.BouncyCastle.Asn1.Cms.RecipientEncryptedKey(karid, encryptedKey));
			}
			return new global::Org.BouncyCastle.Asn1.Cms.RecipientInfo(new global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo(originator, ukm, keyEncAlg, new global::Org.BouncyCastle.Asn1.DerSequence(recipientEncryptedKeys)));
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x000F9670 File Offset: 0x000F7870
		private static global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey CreateOriginatorPublicKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo spki = global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(publicKey);
			return new global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(spki.AlgorithmID.Algorithm, global::Org.BouncyCastle.Asn1.DerNull.Instance), spki.PublicKeyData.GetBytes());
		}

		// Token: 0x04001750 RID: 5968
		private static readonly global::Org.BouncyCastle.Cms.CmsEnvelopedHelper Helper = global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.Instance;

		// Token: 0x04001751 RID: 5969
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyAgreementOID;

		// Token: 0x04001752 RID: 5970
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyEncryptionOID;

		// Token: 0x04001753 RID: 5971
		private global::System.Collections.IList recipientCerts;

		// Token: 0x04001754 RID: 5972
		private global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair senderKeyPair;
	}
}
