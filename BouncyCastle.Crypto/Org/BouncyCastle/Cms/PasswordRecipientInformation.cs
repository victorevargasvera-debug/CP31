using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000550 RID: 1360
	public class PasswordRecipientInformation : global::Org.BouncyCastle.Cms.RecipientInformation
	{
		// Token: 0x06003445 RID: 13381 RVA: 0x000FA125 File Offset: 0x000F8325
		internal PasswordRecipientInformation(global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo info, global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable) : base(info.KeyEncryptionAlgorithm, secureReadable)
		{
			this.info = info;
			this.rid = new global::Org.BouncyCastle.Cms.RecipientID();
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x000FA146 File Offset: 0x000F8346
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyDerivationAlgorithm
		{
			get
			{
				return this.info.KeyDerivationAlgorithm;
			}
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x000FA154 File Offset: 0x000F8354
		public override global::Org.BouncyCastle.Cms.CmsTypedStream GetContentStream(global::Org.BouncyCastle.Crypto.ICipherParameters key)
		{
			global::Org.BouncyCastle.Cms.CmsTypedStream contentFromSessionKey;
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence asn1Sequence = (global::Org.BouncyCastle.Asn1.Asn1Sequence)global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(this.info.KeyEncryptionAlgorithm).Parameters;
				byte[] encryptedKey = this.info.EncryptedKey.GetOctets();
				string kekAlgName = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(asn1Sequence[0]).Id;
				global::Org.BouncyCastle.Crypto.IWrapper keyWrapper = global::Org.BouncyCastle.Security.WrapperUtilities.GetWrapper(global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.Instance.GetRfc3211WrapperName(kekAlgName));
				byte[] iv = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(asn1Sequence[1]).GetOctets();
				global::Org.BouncyCastle.Crypto.ICipherParameters parameters = ((global::Org.BouncyCastle.Cms.CmsPbeKey)key).GetEncoded(kekAlgName);
				parameters = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters, iv);
				keyWrapper.Init(false, parameters);
				global::Org.BouncyCastle.Crypto.Parameters.KeyParameter sKey = global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(base.GetContentAlgorithmName(), keyWrapper.Unwrap(encryptedKey, 0, encryptedKey.Length));
				contentFromSessionKey = base.GetContentFromSessionKey(sKey);
			}
			catch (global::Org.BouncyCastle.Security.SecurityUtilityException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("couldn't create cipher.", e);
			}
			catch (global::Org.BouncyCastle.Security.InvalidKeyException e2)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("key invalid in message.", e2);
			}
			return contentFromSessionKey;
		}

		// Token: 0x04001765 RID: 5989
		private readonly global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo info;
	}
}
