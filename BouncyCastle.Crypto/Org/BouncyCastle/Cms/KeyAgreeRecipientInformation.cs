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
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000549 RID: 1353
	public class KeyAgreeRecipientInformation : global::Org.BouncyCastle.Cms.RecipientInformation
	{
		// Token: 0x06003420 RID: 13344 RVA: 0x000F96B8 File Offset: 0x000F78B8
		internal static void ReadRecipientInfo(global::System.Collections.IList infos, global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo info, global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable)
		{
			try
			{
				foreach (object obj in info.RecipientEncryptedKeys)
				{
					global::Org.BouncyCastle.Asn1.Cms.RecipientEncryptedKey id = global::Org.BouncyCastle.Asn1.Cms.RecipientEncryptedKey.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object());
					global::Org.BouncyCastle.Cms.RecipientID rid = new global::Org.BouncyCastle.Cms.RecipientID();
					global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier karid = id.Identifier;
					global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber iAndSN = karid.IssuerAndSerialNumber;
					if (iAndSN != null)
					{
						rid.Issuer = iAndSN.Name;
						rid.SerialNumber = iAndSN.SerialNumber.Value;
					}
					else
					{
						global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier rKeyID = karid.RKeyID;
						rid.SubjectKeyIdentifier = rKeyID.SubjectKeyIdentifier.GetOctets();
					}
					infos.Add(new global::Org.BouncyCastle.Cms.KeyAgreeRecipientInformation(info, rid, id.EncryptedKey, secureReadable));
				}
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::System.ArgumentException("invalid rid in KeyAgreeRecipientInformation", e);
			}
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x000F97A0 File Offset: 0x000F79A0
		internal KeyAgreeRecipientInformation(global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo info, global::Org.BouncyCastle.Cms.RecipientID rid, global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey, global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable) : base(info.KeyEncryptionAlgorithm, secureReadable)
		{
			this.info = info;
			this.rid = rid;
			this.encryptedKey = encryptedKey;
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x000F97C8 File Offset: 0x000F79C8
		private global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter GetSenderPublicKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter receiverPrivateKey, global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey originator)
		{
			global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey opk = originator.OriginatorPublicKey;
			if (opk != null)
			{
				return this.GetPublicKeyFromOriginatorPublicKey(receiverPrivateKey, opk);
			}
			global::Org.BouncyCastle.Cms.OriginatorID origID = new global::Org.BouncyCastle.Cms.OriginatorID();
			global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber iAndSN = originator.IssuerAndSerialNumber;
			if (iAndSN != null)
			{
				origID.Issuer = iAndSN.Name;
				origID.SerialNumber = iAndSN.SerialNumber.Value;
			}
			else
			{
				global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier ski = originator.SubjectKeyIdentifier;
				origID.SubjectKeyIdentifier = ski.GetKeyIdentifier();
			}
			return this.GetPublicKeyFromOriginatorID(origID);
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x000F9831 File Offset: 0x000F7A31
		private global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter GetPublicKeyFromOriginatorPublicKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter receiverPrivateKey, global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey originatorPublicKey)
		{
			return global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.CreatePrivateKeyInfo(receiverPrivateKey).PrivateKeyAlgorithm, originatorPublicKey.PublicKey.GetBytes()));
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x000F9853 File Offset: 0x000F7A53
		private global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter GetPublicKeyFromOriginatorID(global::Org.BouncyCastle.Cms.OriginatorID origID)
		{
			throw new global::Org.BouncyCastle.Cms.CmsException("No support for 'originator' as IssuerAndSerialNumber or SubjectKeyIdentifier");
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x000F9860 File Offset: 0x000F7A60
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter CalculateAgreedWrapKey(string wrapAlg, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter senderPublicKey, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter receiverPrivateKey)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm = this.keyEncAlg.Algorithm;
			global::Org.BouncyCastle.Crypto.ICipherParameters senderPublicParams = senderPublicKey;
			global::Org.BouncyCastle.Crypto.ICipherParameters receiverPrivateParams = receiverPrivateKey;
			if (algorithm.Id.Equals(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.ECMqvSha1Kdf))
			{
				global::Org.BouncyCastle.Asn1.Cms.Ecc.MQVuserKeyingMaterial ukm = global::Org.BouncyCastle.Asn1.Cms.Ecc.MQVuserKeyingMaterial.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(this.info.UserKeyingMaterial.GetOctets()));
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter ephemeralKey = this.GetPublicKeyFromOriginatorPublicKey(receiverPrivateKey, ukm.EphemeralPublicKey);
				senderPublicParams = new global::Org.BouncyCastle.Crypto.Parameters.MqvPublicParameters((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)senderPublicParams, (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)ephemeralKey);
				receiverPrivateParams = new global::Org.BouncyCastle.Crypto.Parameters.MqvPrivateParameters((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)receiverPrivateParams, (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)receiverPrivateParams);
			}
			global::Org.BouncyCastle.Crypto.IBasicAgreement basicAgreementWithKdf = global::Org.BouncyCastle.Security.AgreementUtilities.GetBasicAgreementWithKdf(algorithm, wrapAlg);
			basicAgreementWithKdf.Init(receiverPrivateParams);
			global::Org.BouncyCastle.Math.BigInteger s = basicAgreementWithKdf.CalculateAgreement(senderPublicParams);
			int wrapKeySize = global::Org.BouncyCastle.Security.GeneratorUtilities.GetDefaultKeySize(wrapAlg) / 8;
			byte[] wrapKeyBytes = global::Org.BouncyCastle.Asn1.X9.X9IntegerConverter.IntegerToBytes(s, wrapKeySize);
			return global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(wrapAlg, wrapKeyBytes);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x000F990C File Offset: 0x000F7B0C
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter UnwrapSessionKey(string wrapAlg, global::Org.BouncyCastle.Crypto.Parameters.KeyParameter agreedKey)
		{
			byte[] encKeyOctets = this.encryptedKey.GetOctets();
			global::Org.BouncyCastle.Crypto.IWrapper wrapper = global::Org.BouncyCastle.Security.WrapperUtilities.GetWrapper(wrapAlg);
			wrapper.Init(false, agreedKey);
			byte[] sKeyBytes = wrapper.Unwrap(encKeyOctets, 0, encKeyOctets.Length);
			return global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(base.GetContentAlgorithmName(), sKeyBytes);
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x000F994C File Offset: 0x000F7B4C
		internal global::Org.BouncyCastle.Crypto.Parameters.KeyParameter GetSessionKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter receiverPrivateKey)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter result;
			try
			{
				string wrapAlg = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(this.keyEncAlg.Parameters)[0]).Id;
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter senderPublicKey = this.GetSenderPublicKey(receiverPrivateKey, this.info.Originator);
				global::Org.BouncyCastle.Crypto.Parameters.KeyParameter agreedWrapKey = this.CalculateAgreedWrapKey(wrapAlg, senderPublicKey, receiverPrivateKey);
				result = this.UnwrapSessionKey(wrapAlg, agreedWrapKey);
			}
			catch (global::Org.BouncyCastle.Security.SecurityUtilityException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("couldn't create cipher.", e);
			}
			catch (global::Org.BouncyCastle.Security.InvalidKeyException e2)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("key invalid in message.", e2);
			}
			catch (global::System.Exception e3)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("originator key invalid.", e3);
			}
			return result;
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x000F99F8 File Offset: 0x000F7BF8
		public override global::Org.BouncyCastle.Cms.CmsTypedStream GetContentStream(global::Org.BouncyCastle.Crypto.ICipherParameters key)
		{
			if (!(key is global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter))
			{
				throw new global::System.ArgumentException("KeyAgreement requires asymmetric key", "key");
			}
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter receiverPrivateKey = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)key;
			if (!receiverPrivateKey.IsPrivate)
			{
				throw new global::System.ArgumentException("Expected private key", "key");
			}
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter sKey = this.GetSessionKey(receiverPrivateKey);
			return base.GetContentFromSessionKey(sKey);
		}

		// Token: 0x04001755 RID: 5973
		private global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo info;

		// Token: 0x04001756 RID: 5974
		private global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey;
	}
}
