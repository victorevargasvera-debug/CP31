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
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200051D RID: 1309
	public class CmsAuthenticatedDataGenerator : global::Org.BouncyCastle.Cms.CmsAuthenticatedGenerator
	{
		// Token: 0x060032D3 RID: 13011 RVA: 0x000F2D11 File Offset: 0x000F0F11
		public CmsAuthenticatedDataGenerator()
		{
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x000F2D19 File Offset: 0x000F0F19
		public CmsAuthenticatedDataGenerator(global::Org.BouncyCastle.Security.SecureRandom rand) : base(rand)
		{
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x000F2D24 File Offset: 0x000F0F24
		private global::Org.BouncyCastle.Cms.CmsAuthenticatedData Generate(global::Org.BouncyCastle.Cms.CmsProcessable content, string macOid, global::Org.BouncyCastle.Crypto.CipherKeyGenerator keyGen)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter encKey;
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlgId;
			global::Org.BouncyCastle.Asn1.Asn1OctetString encContent;
			global::Org.BouncyCastle.Asn1.Asn1OctetString macResult;
			try
			{
				byte[] encKeyBytes = keyGen.GenerateKey();
				encKey = global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(macOid, encKeyBytes);
				global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Params = this.GenerateAsn1Parameters(macOid, encKeyBytes);
				global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters;
				macAlgId = this.GetAlgorithmIdentifier(macOid, encKey, asn1Params, out cipherParameters);
				global::Org.BouncyCastle.Crypto.IMac mac = global::Org.BouncyCastle.Security.MacUtilities.GetMac(macOid);
				mac.Init(encKey);
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				global::System.IO.Stream mOut = new global::Org.BouncyCastle.Utilities.IO.TeeOutputStream(memoryStream, new global::Org.BouncyCastle.Crypto.IO.MacSink(mac));
				content.Write(mOut);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(mOut);
				encContent = new global::Org.BouncyCastle.Asn1.BerOctetString(memoryStream.ToArray());
				macResult = new global::Org.BouncyCastle.Asn1.DerOctetString(global::Org.BouncyCastle.Security.MacUtilities.DoFinal(mac));
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
			global::Org.BouncyCastle.Asn1.Cms.ContentInfo eci = new global::Org.BouncyCastle.Asn1.Cms.ContentInfo(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data, encContent);
			return new global::Org.BouncyCastle.Cms.CmsAuthenticatedData(new global::Org.BouncyCastle.Asn1.Cms.ContentInfo(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.AuthenticatedData, new global::Org.BouncyCastle.Asn1.Cms.AuthenticatedData(null, new global::Org.BouncyCastle.Asn1.DerSet(recipientInfos), macAlgId, null, eci, null, macResult, null)));
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x000F2ECC File Offset: 0x000F10CC
		public global::Org.BouncyCastle.Cms.CmsAuthenticatedData Generate(global::Org.BouncyCastle.Cms.CmsProcessable content, string encryptionOid)
		{
			global::Org.BouncyCastle.Cms.CmsAuthenticatedData result;
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
	}
}
