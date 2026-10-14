using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000529 RID: 1321
	public class CmsEnvelopedDataGenerator : global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator
	{
		// Token: 0x0600330A RID: 13066 RVA: 0x000F397B File Offset: 0x000F1B7B
		public CmsEnvelopedDataGenerator()
		{
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x000F3983 File Offset: 0x000F1B83
		public CmsEnvelopedDataGenerator(global::Org.BouncyCastle.Security.SecureRandom rand) : base(rand)
		{
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000F398C File Offset: 0x000F1B8C
		private global::Org.BouncyCastle.Cms.CmsEnvelopedData Generate(global::Org.BouncyCastle.Cms.CmsProcessable content, string encryptionOid, global::Org.BouncyCastle.Crypto.CipherKeyGenerator keyGen)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier encAlgId = null;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter encKey;
			global::Org.BouncyCastle.Asn1.Asn1OctetString encContent;
			try
			{
				byte[] encKeyBytes = keyGen.GenerateKey();
				encKey = global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(encryptionOid, encKeyBytes);
				global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Params = this.GenerateAsn1Parameters(encryptionOid, encKeyBytes);
				global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters;
				encAlgId = this.GetAlgorithmIdentifier(encryptionOid, encKey, asn1Params, out cipherParameters);
				global::Org.BouncyCastle.Crypto.IBufferedCipher cipher = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(encryptionOid);
				cipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(cipherParameters, this.rand));
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				global::Org.BouncyCastle.Crypto.IO.CipherStream cOut = new global::Org.BouncyCastle.Crypto.IO.CipherStream(memoryStream, null, cipher);
				content.Write(cOut);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(cOut);
				encContent = new global::Org.BouncyCastle.Asn1.BerOctetString(memoryStream.ToArray());
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
				throw new global::Org.BouncyCastle.Cms.CmsException("exception decoding algorithm parameters.", e3);
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector recipientInfos = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in this.recipientInfoGenerators)
			{
				global::Org.BouncyCastle.Cms.RecipientInfoGenerator rig = (global::Org.BouncyCastle.Cms.RecipientInfoGenerator)obj;
				try
				{
					recipientInfos.Add(rig.Generate(encKey, this.rand));
				}
				catch (global::Org.BouncyCastle.Security.InvalidKeyException e4)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("key inappropriate for algorithm.", e4);
				}
				catch (global::Org.BouncyCastle.Security.GeneralSecurityException e5)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("error making encrypted content.", e5);
				}
			}
			global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo eci = new global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data, encAlgId, encContent);
			global::Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrSet = null;
			if (this.unprotectedAttributeGenerator != null)
			{
				unprotectedAttrSet = new global::Org.BouncyCastle.Asn1.BerSet(this.unprotectedAttributeGenerator.GetAttributes(global::Org.BouncyCastle.Utilities.Platform.CreateHashtable()).ToAsn1EncodableVector());
			}
			return new global::Org.BouncyCastle.Cms.CmsEnvelopedData(new global::Org.BouncyCastle.Asn1.Cms.ContentInfo(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.EnvelopedData, new global::Org.BouncyCastle.Asn1.Cms.EnvelopedData(null, new global::Org.BouncyCastle.Asn1.DerSet(recipientInfos), eci, unprotectedAttrSet)));
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x000F3B54 File Offset: 0x000F1D54
		public global::Org.BouncyCastle.Cms.CmsEnvelopedData Generate(global::Org.BouncyCastle.Cms.CmsProcessable content, string encryptionOid)
		{
			global::Org.BouncyCastle.Cms.CmsEnvelopedData result;
			try
			{
				global::Org.BouncyCastle.Crypto.CipherKeyGenerator keyGen = global::Org.BouncyCastle.Security.GeneratorUtilities.GetKeyGenerator(encryptionOid);
				keyGen.Init(new global::Org.BouncyCastle.Crypto.KeyGenerationParameters(this.rand, keyGen.DefaultStrength));
				result = this.Generate(content, encryptionOid, keyGen);
			}
			catch (global::Org.BouncyCastle.Security.SecurityUtilityException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("can't find key generation algorithm.", e);
			}
			return result;
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x000F3BAC File Offset: 0x000F1DAC
		public global::Org.BouncyCastle.Cms.CmsEnvelopedData Generate(global::Org.BouncyCastle.Cms.CmsProcessable content, global::Org.BouncyCastle.Crypto.ICipherBuilderWithKey cipherBuilder)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter encKey;
			global::Org.BouncyCastle.Asn1.Asn1OctetString encContent;
			try
			{
				encKey = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)cipherBuilder.Key;
				global::System.IO.MemoryStream collector = new global::System.IO.MemoryStream();
				global::System.IO.Stream bOut = cipherBuilder.BuildCipher(collector).Stream;
				content.Write(bOut);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(bOut);
				encContent = new global::Org.BouncyCastle.Asn1.BerOctetString(collector.ToArray());
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
				throw new global::Org.BouncyCastle.Cms.CmsException("exception decoding algorithm parameters.", e3);
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector recipientInfos = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in this.recipientInfoGenerators)
			{
				global::Org.BouncyCastle.Cms.RecipientInfoGenerator rig = (global::Org.BouncyCastle.Cms.RecipientInfoGenerator)obj;
				try
				{
					recipientInfos.Add(rig.Generate(encKey, this.rand));
				}
				catch (global::Org.BouncyCastle.Security.InvalidKeyException e4)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("key inappropriate for algorithm.", e4);
				}
				catch (global::Org.BouncyCastle.Security.GeneralSecurityException e5)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("error making encrypted content.", e5);
				}
			}
			global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo eci = new global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data, (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)cipherBuilder.AlgorithmDetails, encContent);
			global::Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrSet = null;
			if (this.unprotectedAttributeGenerator != null)
			{
				unprotectedAttrSet = new global::Org.BouncyCastle.Asn1.BerSet(this.unprotectedAttributeGenerator.GetAttributes(global::Org.BouncyCastle.Utilities.Platform.CreateHashtable()).ToAsn1EncodableVector());
			}
			return new global::Org.BouncyCastle.Cms.CmsEnvelopedData(new global::Org.BouncyCastle.Asn1.Cms.ContentInfo(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.EnvelopedData, new global::Org.BouncyCastle.Asn1.Cms.EnvelopedData(null, new global::Org.BouncyCastle.Asn1.DerSet(recipientInfos), eci, unprotectedAttrSet)));
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x000F3D48 File Offset: 0x000F1F48
		public global::Org.BouncyCastle.Cms.CmsEnvelopedData Generate(global::Org.BouncyCastle.Cms.CmsProcessable content, string encryptionOid, int keySize)
		{
			global::Org.BouncyCastle.Cms.CmsEnvelopedData result;
			try
			{
				global::Org.BouncyCastle.Crypto.CipherKeyGenerator keyGen = global::Org.BouncyCastle.Security.GeneratorUtilities.GetKeyGenerator(encryptionOid);
				keyGen.Init(new global::Org.BouncyCastle.Crypto.KeyGenerationParameters(this.rand, keySize));
				result = this.Generate(content, encryptionOid, keyGen);
			}
			catch (global::Org.BouncyCastle.Security.SecurityUtilityException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("can't find key generation algorithm.", e);
			}
			return result;
		}
	}
}
