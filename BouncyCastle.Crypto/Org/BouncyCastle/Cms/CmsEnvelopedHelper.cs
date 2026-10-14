using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200052D RID: 1325
	internal class CmsEnvelopedHelper
	{
		// Token: 0x0600332F RID: 13103 RVA: 0x000F45F8 File Offset: 0x000F27F8
		static CmsEnvelopedHelper()
		{
			global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.KeySizes.Add(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.DesEde3Cbc, 192);
			global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.KeySizes.Add(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.Aes128Cbc, 128);
			global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.KeySizes.Add(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.Aes192Cbc, 192);
			global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.KeySizes.Add(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.Aes256Cbc, 256);
			global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.BaseCipherNames.Add(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.DesEde3Cbc, "DESEDE");
			global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.BaseCipherNames.Add(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.Aes128Cbc, "AES");
			global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.BaseCipherNames.Add(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.Aes192Cbc, "AES");
			global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.BaseCipherNames.Add(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.Aes256Cbc, "AES");
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x000F46D7 File Offset: 0x000F28D7
		private string GetAsymmetricEncryptionAlgName(string encryptionAlgOid)
		{
			if (global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption.Id.Equals(encryptionAlgOid))
			{
				return "RSA/ECB/PKCS1Padding";
			}
			return encryptionAlgOid;
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x000F46F4 File Offset: 0x000F28F4
		internal global::Org.BouncyCastle.Crypto.IBufferedCipher CreateAsymmetricCipher(string encryptionOid)
		{
			string asymName = this.GetAsymmetricEncryptionAlgName(encryptionOid);
			if (!asymName.Equals(encryptionOid))
			{
				try
				{
					return global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(asymName);
				}
				catch (global::Org.BouncyCastle.Security.SecurityUtilityException)
				{
				}
			}
			return global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(encryptionOid);
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x000F4738 File Offset: 0x000F2938
		internal global::Org.BouncyCastle.Crypto.IWrapper CreateWrapper(string encryptionOid)
		{
			global::Org.BouncyCastle.Crypto.IWrapper wrapper;
			try
			{
				wrapper = global::Org.BouncyCastle.Security.WrapperUtilities.GetWrapper(encryptionOid);
			}
			catch (global::Org.BouncyCastle.Security.SecurityUtilityException)
			{
				wrapper = global::Org.BouncyCastle.Security.WrapperUtilities.GetWrapper(this.GetAsymmetricEncryptionAlgName(encryptionOid));
			}
			return wrapper;
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x000F4770 File Offset: 0x000F2970
		internal string GetRfc3211WrapperName(string oid)
		{
			if (oid == null)
			{
				throw new global::System.ArgumentNullException("oid");
			}
			string text = (string)global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.BaseCipherNames[oid];
			if (text == null)
			{
				throw new global::System.ArgumentException("no name for " + oid, "oid");
			}
			return text + "RFC3211Wrap";
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x000F47BE File Offset: 0x000F29BE
		internal int GetKeySize(string oid)
		{
			if (!global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.KeySizes.Contains(oid))
			{
				throw new global::System.ArgumentException("no keysize for " + oid, "oid");
			}
			return (int)global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.KeySizes[oid];
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x000F47F4 File Offset: 0x000F29F4
		internal static global::Org.BouncyCastle.Cms.RecipientInformationStore BuildRecipientInformationStore(global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos, global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable)
		{
			global::System.Collections.IList infos = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			for (int i = 0; i != recipientInfos.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.Cms.RecipientInfo info = global::Org.BouncyCastle.Asn1.Cms.RecipientInfo.GetInstance(recipientInfos[i]);
				global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.ReadRecipientInfo(infos, info, secureReadable);
			}
			return new global::Org.BouncyCastle.Cms.RecipientInformationStore(infos);
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x000F4834 File Offset: 0x000F2A34
		private static void ReadRecipientInfo(global::System.Collections.IList infos, global::Org.BouncyCastle.Asn1.Cms.RecipientInfo info, global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable)
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable recipInfo = info.Info;
			if (recipInfo is global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo)
			{
				infos.Add(new global::Org.BouncyCastle.Cms.KeyTransRecipientInformation((global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo)recipInfo, secureReadable));
				return;
			}
			if (recipInfo is global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo)
			{
				infos.Add(new global::Org.BouncyCastle.Cms.KekRecipientInformation((global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo)recipInfo, secureReadable));
				return;
			}
			if (recipInfo is global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo)
			{
				global::Org.BouncyCastle.Cms.KeyAgreeRecipientInformation.ReadRecipientInfo(infos, (global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo)recipInfo, secureReadable);
				return;
			}
			if (recipInfo is global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo)
			{
				infos.Add(new global::Org.BouncyCastle.Cms.PasswordRecipientInformation((global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo)recipInfo, secureReadable));
			}
		}

		// Token: 0x040016E0 RID: 5856
		internal static readonly global::Org.BouncyCastle.Cms.CmsEnvelopedHelper Instance = new global::Org.BouncyCastle.Cms.CmsEnvelopedHelper();

		// Token: 0x040016E1 RID: 5857
		private static readonly global::System.Collections.IDictionary KeySizes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040016E2 RID: 5858
		private static readonly global::System.Collections.IDictionary BaseCipherNames = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0200083C RID: 2108
		internal class CmsAuthenticatedSecureReadable : global::Org.BouncyCastle.Cms.CmsSecureReadable
		{
			// Token: 0x06004716 RID: 18198 RVA: 0x0013A15B File Offset: 0x0013835B
			internal CmsAuthenticatedSecureReadable(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithm, global::Org.BouncyCastle.Cms.CmsReadable readable)
			{
				this.algorithm = algorithm;
				this.readable = readable;
			}

			// Token: 0x17000AB3 RID: 2739
			// (get) Token: 0x06004717 RID: 18199 RVA: 0x0013A171 File Offset: 0x00138371
			public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Algorithm
			{
				get
				{
					return this.algorithm;
				}
			}

			// Token: 0x17000AB4 RID: 2740
			// (get) Token: 0x06004718 RID: 18200 RVA: 0x0013A179 File Offset: 0x00138379
			public object CryptoObject
			{
				get
				{
					return this.mac;
				}
			}

			// Token: 0x06004719 RID: 18201 RVA: 0x0013A184 File Offset: 0x00138384
			public global::Org.BouncyCastle.Cms.CmsReadable GetReadable(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter sKey)
			{
				string macAlg = this.algorithm.Algorithm.Id;
				try
				{
					this.mac = global::Org.BouncyCastle.Security.MacUtilities.GetMac(macAlg);
					this.mac.Init(sKey);
				}
				catch (global::Org.BouncyCastle.Security.SecurityUtilityException e)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("couldn't create cipher.", e);
				}
				catch (global::Org.BouncyCastle.Security.InvalidKeyException e2)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("key invalid in message.", e2);
				}
				catch (global::System.IO.IOException e3)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("error decoding algorithm parameters.", e3);
				}
				global::Org.BouncyCastle.Cms.CmsReadable result;
				try
				{
					result = new global::Org.BouncyCastle.Cms.CmsProcessableInputStream(new global::Org.BouncyCastle.Utilities.IO.TeeInputStream(this.readable.GetInputStream(), new global::Org.BouncyCastle.Crypto.IO.MacSink(this.mac)));
				}
				catch (global::System.IO.IOException e4)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("error reading content.", e4);
				}
				return result;
			}

			// Token: 0x0400258A RID: 9610
			private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithm;

			// Token: 0x0400258B RID: 9611
			private global::Org.BouncyCastle.Crypto.IMac mac;

			// Token: 0x0400258C RID: 9612
			private global::Org.BouncyCastle.Cms.CmsReadable readable;
		}

		// Token: 0x0200083D RID: 2109
		internal class CmsEnvelopedSecureReadable : global::Org.BouncyCastle.Cms.CmsSecureReadable
		{
			// Token: 0x0600471A RID: 18202 RVA: 0x0013A250 File Offset: 0x00138450
			internal CmsEnvelopedSecureReadable(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithm, global::Org.BouncyCastle.Cms.CmsReadable readable)
			{
				this.algorithm = algorithm;
				this.readable = readable;
			}

			// Token: 0x17000AB5 RID: 2741
			// (get) Token: 0x0600471B RID: 18203 RVA: 0x0013A266 File Offset: 0x00138466
			public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Algorithm
			{
				get
				{
					return this.algorithm;
				}
			}

			// Token: 0x17000AB6 RID: 2742
			// (get) Token: 0x0600471C RID: 18204 RVA: 0x0013A26E File Offset: 0x0013846E
			public object CryptoObject
			{
				get
				{
					return this.cipher;
				}
			}

			// Token: 0x0600471D RID: 18205 RVA: 0x0013A278 File Offset: 0x00138478
			public global::Org.BouncyCastle.Cms.CmsReadable GetReadable(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter sKey)
			{
				try
				{
					this.cipher = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(this.algorithm.Algorithm);
					global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Enc = this.algorithm.Parameters;
					global::Org.BouncyCastle.Asn1.Asn1Object asn1Params = (asn1Enc == null) ? null : asn1Enc.ToAsn1Object();
					global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters = sKey;
					if (asn1Params != null && !(asn1Params is global::Org.BouncyCastle.Asn1.Asn1Null))
					{
						cipherParameters = global::Org.BouncyCastle.Security.ParameterUtilities.GetCipherParameters(this.algorithm.Algorithm, cipherParameters, asn1Params);
					}
					else
					{
						string alg = this.algorithm.Algorithm.Id;
						if (alg.Equals(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.DesEde3Cbc) || alg.Equals("1.3.6.1.4.1.188.7.1.1.2") || alg.Equals("1.2.840.113533.7.66.10"))
						{
							cipherParameters = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(cipherParameters, new byte[8]);
						}
					}
					this.cipher.Init(false, cipherParameters);
				}
				catch (global::Org.BouncyCastle.Security.SecurityUtilityException e)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("couldn't create cipher.", e);
				}
				catch (global::Org.BouncyCastle.Security.InvalidKeyException e2)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("key invalid in message.", e2);
				}
				catch (global::System.IO.IOException e3)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("error decoding algorithm parameters.", e3);
				}
				global::Org.BouncyCastle.Cms.CmsReadable result;
				try
				{
					result = new global::Org.BouncyCastle.Cms.CmsProcessableInputStream(new global::Org.BouncyCastle.Crypto.IO.CipherStream(this.readable.GetInputStream(), this.cipher, null));
				}
				catch (global::System.IO.IOException e4)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("error reading content.", e4);
				}
				return result;
			}

			// Token: 0x0400258D RID: 9613
			private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithm;

			// Token: 0x0400258E RID: 9614
			private global::Org.BouncyCastle.Crypto.IBufferedCipher cipher;

			// Token: 0x0400258F RID: 9615
			private global::Org.BouncyCastle.Cms.CmsReadable readable;
		}
	}
}
