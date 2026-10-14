using System;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000547 RID: 1351
	public class KekRecipientInformation : global::Org.BouncyCastle.Cms.RecipientInformation
	{
		// Token: 0x06003416 RID: 13334 RVA: 0x000F9228 File Offset: 0x000F7428
		internal KekRecipientInformation(global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo info, global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable) : base(info.KeyEncryptionAlgorithm, secureReadable)
		{
			this.info = info;
			this.rid = new global::Org.BouncyCastle.Cms.RecipientID();
			global::Org.BouncyCastle.Asn1.Cms.KekIdentifier kekId = info.KekID;
			this.rid.KeyIdentifier = kekId.KeyIdentifier.GetOctets();
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x000F9274 File Offset: 0x000F7474
		public override global::Org.BouncyCastle.Cms.CmsTypedStream GetContentStream(global::Org.BouncyCastle.Crypto.ICipherParameters key)
		{
			global::Org.BouncyCastle.Cms.CmsTypedStream contentFromSessionKey;
			try
			{
				byte[] encryptedKey = this.info.EncryptedKey.GetOctets();
				global::Org.BouncyCastle.Crypto.IWrapper keyWrapper = global::Org.BouncyCastle.Security.WrapperUtilities.GetWrapper(this.keyEncAlg.Algorithm.Id);
				keyWrapper.Init(false, key);
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

		// Token: 0x0400174F RID: 5967
		private global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo info;
	}
}
