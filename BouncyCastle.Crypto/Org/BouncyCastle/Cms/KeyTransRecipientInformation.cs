using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200054B RID: 1355
	public class KeyTransRecipientInformation : global::Org.BouncyCastle.Cms.RecipientInformation
	{
		// Token: 0x06003430 RID: 13360 RVA: 0x000F9B44 File Offset: 0x000F7D44
		internal KeyTransRecipientInformation(global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo info, global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable) : base(info.KeyEncryptionAlgorithm, secureReadable)
		{
			this.info = info;
			this.rid = new global::Org.BouncyCastle.Cms.RecipientID();
			global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier r = info.RecipientIdentifier;
			try
			{
				if (r.IsTagged)
				{
					global::Org.BouncyCastle.Asn1.Asn1OctetString octs = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(r.ID);
					this.rid.SubjectKeyIdentifier = octs.GetOctets();
				}
				else
				{
					global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber iAnds = global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber.GetInstance(r.ID);
					this.rid.Issuer = iAnds.Name;
					this.rid.SerialNumber = iAnds.SerialNumber.Value;
				}
			}
			catch (global::System.IO.IOException)
			{
				throw new global::System.ArgumentException("invalid rid in KeyTransRecipientInformation");
			}
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x000F9BF0 File Offset: 0x000F7DF0
		private string GetExchangeEncryptionAlgorithmName(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algo)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = algo.Algorithm;
			if (global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption.Equals(oid))
			{
				return "RSA//PKCS1Padding";
			}
			if (global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsaesOaep.Equals(oid))
			{
				global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters rsaParams = global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.GetInstance(algo.Parameters);
				return "RSA//OAEPWITH" + global::Org.BouncyCastle.Security.DigestUtilities.GetAlgorithmName(rsaParams.HashAlgorithm.Algorithm) + "ANDMGF1Padding";
			}
			return oid.Id;
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x000F9C58 File Offset: 0x000F7E58
		internal global::Org.BouncyCastle.Crypto.Parameters.KeyParameter UnwrapKey(global::Org.BouncyCastle.Crypto.ICipherParameters key)
		{
			byte[] encryptedKey = this.info.EncryptedKey.GetOctets();
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter result;
			try
			{
				if (this.keyEncAlg.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsaesOaep))
				{
					global::Org.BouncyCastle.Crypto.IKeyUnwrapper keyWrapper = new global::Org.BouncyCastle.Crypto.Operators.Asn1KeyUnwrapper(this.keyEncAlg.Algorithm, this.keyEncAlg.Parameters, key);
					result = global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(base.GetContentAlgorithmName(), keyWrapper.Unwrap(encryptedKey, 0, encryptedKey.Length).Collect());
				}
				else
				{
					global::Org.BouncyCastle.Crypto.IWrapper keyWrapper2 = global::Org.BouncyCastle.Security.WrapperUtilities.GetWrapper(this.GetExchangeEncryptionAlgorithmName(this.keyEncAlg));
					keyWrapper2.Init(false, key);
					result = global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(base.GetContentAlgorithmName(), keyWrapper2.Unwrap(encryptedKey, 0, encryptedKey.Length));
				}
			}
			catch (global::Org.BouncyCastle.Security.SecurityUtilityException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("couldn't create cipher.", e);
			}
			catch (global::Org.BouncyCastle.Security.InvalidKeyException e2)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("key invalid in message.", e2);
			}
			catch (global::Org.BouncyCastle.Crypto.DataLengthException e3)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("illegal blocksize in message.", e3);
			}
			catch (global::Org.BouncyCastle.Crypto.InvalidCipherTextException e4)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("bad padding in message.", e4);
			}
			return result;
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x000F9D6C File Offset: 0x000F7F6C
		public override global::Org.BouncyCastle.Cms.CmsTypedStream GetContentStream(global::Org.BouncyCastle.Crypto.ICipherParameters key)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter sKey = this.UnwrapKey(key);
			return base.GetContentFromSessionKey(sKey);
		}

		// Token: 0x0400175D RID: 5981
		private global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo info;
	}
}
