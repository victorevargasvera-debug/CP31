using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Eac;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200053D RID: 1341
	internal class CmsSignedHelper
	{
		// Token: 0x060033D6 RID: 13270 RVA: 0x000F7C08 File Offset: 0x000F5E08
		private static void AddEntries(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, string digest, string encryption)
		{
			string alias = oid.Id;
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(alias, digest);
			global::Org.BouncyCastle.Cms.CmsSignedHelper.encryptionAlgs.Add(alias, encryption);
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x000F7C34 File Offset: 0x000F5E34
		static CmsSignedHelper()
		{
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224, "SHA224", "DSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256, "SHA256", "DSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384, "SHA384", "DSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512, "SHA512", "DSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1, "SHA1", "DSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD4WithRsa, "MD4", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD4WithRsaEncryption, "MD4", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD5WithRsa, "MD5", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.Sha1WithRsa, "SHA1", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption, "MD2", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4WithRsaEncryption, "MD4", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption, "MD5", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption, "SHA1", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption, "SHA224", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption, "SHA256", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption, "SHA384", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption, "SHA512", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption, "SHA512(224)", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption, "SHA512(256)", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_224, "SHA3-224", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_256, "SHA3-256", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_384, "SHA3-384", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_512, "SHA3-512", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1, "SHA1", "ECDSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224, "SHA224", "ECDSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256, "SHA256", "ECDSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384, "SHA384", "ECDSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512, "SHA512", "ECDSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1, "SHA1", "DSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_1, "SHA1", "ECDSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_224, "SHA224", "ECDSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_256, "SHA256", "ECDSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_384, "SHA384", "ECDSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_512, "SHA512", "ECDSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA_v1_5_SHA_1, "SHA1", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA_v1_5_SHA_256, "SHA256", "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA_PSS_SHA_1, "SHA1", "RSAandMGF1");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.AddEntries(global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA_PSS_SHA_256, "SHA256", "RSAandMGF1");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.encryptionAlgs.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsa.Id, "DSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.encryptionAlgs.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption.Id, "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.encryptionAlgs.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTRsaSignatureAlgorithm.Id, "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.encryptionAlgs.Add(global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdEARsa.Id, "RSA");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.encryptionAlgs.Add(global::Org.BouncyCastle.Cms.CmsSignedGenerator.EncryptionRsaPss, "RSAandMGF1");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.encryptionAlgs.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94.Id, "GOST3410");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.encryptionAlgs.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001.Id, "ECGOST3410");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.encryptionAlgs.Add("1.3.6.1.4.1.5849.1.6.2", "ECGOST3410");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.encryptionAlgs.Add("1.3.6.1.4.1.5849.1.1.5", "GOST3410");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2.Id, "MD2");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4.Id, "MD4");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5.Id, "MD5");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1.Id, "SHA1");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224.Id, "SHA224");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Id, "SHA256");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384.Id, "SHA384");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512.Id, "SHA512");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224.Id, "SHA512(224)");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256.Id, "SHA512(256)");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224.Id, "SHA3-224");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256.Id, "SHA3-256");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384.Id, "SHA3-384");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512.Id, "SHA3-512");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128.Id, "RIPEMD128");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160.Id, "RIPEMD160");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256.Id, "RIPEMD256");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411.Id, "GOST3411");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs.Add("1.3.6.1.4.1.5849.1.2.1", "GOST3411");
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAliases.Add("SHA1", new string[]
			{
				"SHA-1"
			});
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAliases.Add("SHA224", new string[]
			{
				"SHA-224"
			});
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAliases.Add("SHA256", new string[]
			{
				"SHA-256"
			});
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAliases.Add("SHA384", new string[]
			{
				"SHA-384"
			});
			global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAliases.Add("SHA512", new string[]
			{
				"SHA-512"
			});
			global::Org.BouncyCastle.Cms.CmsSignedHelper.noParams.Add(global::Org.BouncyCastle.Cms.CmsSignedGenerator.EncryptionDsa);
			global::Org.BouncyCastle.Cms.CmsSignedHelper.noParams.Add(global::Org.BouncyCastle.Cms.CmsSignedHelper.EncryptionECDsaWithSha1);
			global::Org.BouncyCastle.Cms.CmsSignedHelper.noParams.Add(global::Org.BouncyCastle.Cms.CmsSignedHelper.EncryptionECDsaWithSha224);
			global::Org.BouncyCastle.Cms.CmsSignedHelper.noParams.Add(global::Org.BouncyCastle.Cms.CmsSignedHelper.EncryptionECDsaWithSha256);
			global::Org.BouncyCastle.Cms.CmsSignedHelper.noParams.Add(global::Org.BouncyCastle.Cms.CmsSignedHelper.EncryptionECDsaWithSha384);
			global::Org.BouncyCastle.Cms.CmsSignedHelper.noParams.Add(global::Org.BouncyCastle.Cms.CmsSignedHelper.EncryptionECDsaWithSha512);
			global::Org.BouncyCastle.Cms.CmsSignedHelper.ecAlgorithms.Add(global::Org.BouncyCastle.Cms.CmsSignedGenerator.DigestSha1, global::Org.BouncyCastle.Cms.CmsSignedHelper.EncryptionECDsaWithSha1);
			global::Org.BouncyCastle.Cms.CmsSignedHelper.ecAlgorithms.Add(global::Org.BouncyCastle.Cms.CmsSignedGenerator.DigestSha224, global::Org.BouncyCastle.Cms.CmsSignedHelper.EncryptionECDsaWithSha224);
			global::Org.BouncyCastle.Cms.CmsSignedHelper.ecAlgorithms.Add(global::Org.BouncyCastle.Cms.CmsSignedGenerator.DigestSha256, global::Org.BouncyCastle.Cms.CmsSignedHelper.EncryptionECDsaWithSha256);
			global::Org.BouncyCastle.Cms.CmsSignedHelper.ecAlgorithms.Add(global::Org.BouncyCastle.Cms.CmsSignedGenerator.DigestSha384, global::Org.BouncyCastle.Cms.CmsSignedHelper.EncryptionECDsaWithSha384);
			global::Org.BouncyCastle.Cms.CmsSignedHelper.ecAlgorithms.Add(global::Org.BouncyCastle.Cms.CmsSignedGenerator.DigestSha512, global::Org.BouncyCastle.Cms.CmsSignedHelper.EncryptionECDsaWithSha512);
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x000F83B8 File Offset: 0x000F65B8
		internal string GetDigestAlgName(string digestAlgOid)
		{
			string algName = (string)global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAlgs[digestAlgOid];
			if (algName != null)
			{
				return algName;
			}
			return digestAlgOid;
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x000F83DC File Offset: 0x000F65DC
		internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetEncAlgorithmIdentifier(global::Org.BouncyCastle.Asn1.DerObjectIdentifier encOid, global::Org.BouncyCastle.Asn1.Asn1Encodable sigX509Parameters)
		{
			if (global::Org.BouncyCastle.Cms.CmsSignedHelper.noParams.Contains(encOid.Id))
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(encOid);
			}
			return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(encOid, sigX509Parameters);
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x000F8400 File Offset: 0x000F6600
		internal string[] GetDigestAliases(string algName)
		{
			string[] aliases = (string[])global::Org.BouncyCastle.Cms.CmsSignedHelper.digestAliases[algName];
			if (aliases != null)
			{
				return (string[])aliases.Clone();
			}
			return new string[0];
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x000F8434 File Offset: 0x000F6634
		internal string GetEncryptionAlgName(string encryptionAlgOid)
		{
			string algName = (string)global::Org.BouncyCastle.Cms.CmsSignedHelper.encryptionAlgs[encryptionAlgOid];
			if (algName != null)
			{
				return algName;
			}
			return encryptionAlgOid;
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x000F8458 File Offset: 0x000F6658
		internal global::Org.BouncyCastle.Crypto.IDigest GetDigestInstance(string algorithm)
		{
			global::Org.BouncyCastle.Crypto.IDigest digest;
			try
			{
				digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(algorithm);
			}
			catch (global::Org.BouncyCastle.Security.SecurityUtilityException e)
			{
				foreach (string alias in this.GetDigestAliases(algorithm))
				{
					try
					{
						return global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(alias);
					}
					catch (global::Org.BouncyCastle.Security.SecurityUtilityException)
					{
					}
				}
				throw e;
			}
			return digest;
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x000F84B8 File Offset: 0x000F66B8
		internal global::Org.BouncyCastle.Crypto.ISigner GetSignatureInstance(string algorithm)
		{
			return global::Org.BouncyCastle.Security.SignerUtilities.GetSigner(algorithm);
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x000F84C0 File Offset: 0x000F66C0
		internal global::Org.BouncyCastle.X509.Store.IX509Store CreateAttributeStore(string type, global::Org.BouncyCastle.Asn1.Asn1Set certSet)
		{
			global::System.Collections.IList certs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (certSet != null)
			{
				foreach (object obj2 in certSet)
				{
					global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2;
					try
					{
						global::Org.BouncyCastle.Asn1.Asn1Object obj = ae.ToAsn1Object();
						if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
						{
							global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
							if (tagged.TagNo == 2)
							{
								certs.Add(new global::Org.BouncyCastle.X509.X509V2AttributeCertificate(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(tagged, false).GetEncoded()));
							}
						}
					}
					catch (global::System.Exception ex)
					{
						throw new global::Org.BouncyCastle.Cms.CmsException("can't re-encode attribute certificate!", ex);
					}
				}
			}
			global::Org.BouncyCastle.X509.Store.IX509Store result;
			try
			{
				result = global::Org.BouncyCastle.X509.Store.X509StoreFactory.Create("AttributeCertificate/" + type, new global::Org.BouncyCastle.X509.Store.X509CollectionStoreParameters(certs));
			}
			catch (global::System.ArgumentException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("can't setup the X509Store", e);
			}
			return result;
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x000F85A8 File Offset: 0x000F67A8
		internal global::Org.BouncyCastle.X509.Store.IX509Store CreateCertificateStore(string type, global::Org.BouncyCastle.Asn1.Asn1Set certSet)
		{
			global::System.Collections.IList certs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (certSet != null)
			{
				this.AddCertsFromSet(certs, certSet);
			}
			global::Org.BouncyCastle.X509.Store.IX509Store result;
			try
			{
				result = global::Org.BouncyCastle.X509.Store.X509StoreFactory.Create("Certificate/" + type, new global::Org.BouncyCastle.X509.Store.X509CollectionStoreParameters(certs));
			}
			catch (global::System.ArgumentException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("can't setup the X509Store", e);
			}
			return result;
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x000F8600 File Offset: 0x000F6800
		internal global::Org.BouncyCastle.X509.Store.IX509Store CreateCrlStore(string type, global::Org.BouncyCastle.Asn1.Asn1Set crlSet)
		{
			global::System.Collections.IList crls = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (crlSet != null)
			{
				this.AddCrlsFromSet(crls, crlSet);
			}
			global::Org.BouncyCastle.X509.Store.IX509Store result;
			try
			{
				result = global::Org.BouncyCastle.X509.Store.X509StoreFactory.Create("CRL/" + type, new global::Org.BouncyCastle.X509.Store.X509CollectionStoreParameters(crls));
			}
			catch (global::System.ArgumentException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("can't setup the X509Store", e);
			}
			return result;
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x000F8658 File Offset: 0x000F6858
		private void AddCertsFromSet(global::System.Collections.IList certs, global::Org.BouncyCastle.Asn1.Asn1Set certSet)
		{
			global::Org.BouncyCastle.X509.X509CertificateParser cf = new global::Org.BouncyCastle.X509.X509CertificateParser();
			foreach (object obj2 in certSet)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2;
				try
				{
					global::Org.BouncyCastle.Asn1.Asn1Object obj = ae.ToAsn1Object();
					if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
					{
						certs.Add(cf.ReadCertificate(obj.GetEncoded()));
					}
				}
				catch (global::System.Exception ex)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("can't re-encode certificate!", ex);
				}
			}
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x000F86F0 File Offset: 0x000F68F0
		private void AddCrlsFromSet(global::System.Collections.IList crls, global::Org.BouncyCastle.Asn1.Asn1Set crlSet)
		{
			global::Org.BouncyCastle.X509.X509CrlParser cf = new global::Org.BouncyCastle.X509.X509CrlParser();
			foreach (object obj in crlSet)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
				try
				{
					crls.Add(cf.ReadCrl(ae.GetEncoded()));
				}
				catch (global::System.Exception ex)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("can't re-encode CRL!", ex);
				}
			}
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x000F8774 File Offset: 0x000F6974
		internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier FixAlgID(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId)
		{
			if (algId.Parameters == null)
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algId.Algorithm, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			}
			return algId;
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x000F8790 File Offset: 0x000F6990
		internal string GetEncOid(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key, string digestOID)
		{
			string encOID;
			if (key is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)
			{
				if (!((global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)key).IsPrivate)
				{
					throw new global::System.ArgumentException("Expected RSA private key");
				}
				encOID = global::Org.BouncyCastle.Cms.CmsSignedGenerator.EncryptionRsa;
			}
			else if (key is global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters)
			{
				if (digestOID.Equals(global::Org.BouncyCastle.Cms.CmsSignedGenerator.DigestSha1))
				{
					encOID = global::Org.BouncyCastle.Cms.CmsSignedGenerator.EncryptionDsa;
				}
				else if (digestOID.Equals(global::Org.BouncyCastle.Cms.CmsSignedGenerator.DigestSha224))
				{
					encOID = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224.Id;
				}
				else if (digestOID.Equals(global::Org.BouncyCastle.Cms.CmsSignedGenerator.DigestSha256))
				{
					encOID = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256.Id;
				}
				else if (digestOID.Equals(global::Org.BouncyCastle.Cms.CmsSignedGenerator.DigestSha384))
				{
					encOID = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384.Id;
				}
				else
				{
					if (!digestOID.Equals(global::Org.BouncyCastle.Cms.CmsSignedGenerator.DigestSha512))
					{
						throw new global::System.ArgumentException("can't mix DSA with anything but SHA1/SHA2");
					}
					encOID = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512.Id;
				}
			}
			else if (key is global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)
			{
				if (((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)key).AlgorithmName == "ECGOST3410")
				{
					encOID = global::Org.BouncyCastle.Cms.CmsSignedGenerator.EncryptionECGost3410;
				}
				else
				{
					encOID = (string)global::Org.BouncyCastle.Cms.CmsSignedHelper.ecAlgorithms[digestOID];
					if (encOID == null)
					{
						throw new global::System.ArgumentException("can't mix ECDSA with anything but SHA family digests");
					}
				}
			}
			else
			{
				if (!(key is global::Org.BouncyCastle.Crypto.Parameters.Gost3410PrivateKeyParameters))
				{
					throw new global::System.ArgumentException("Unknown algorithm in CmsSignedGenerator.GetEncOid");
				}
				encOID = global::Org.BouncyCastle.Cms.CmsSignedGenerator.EncryptionGost3410;
			}
			return encOID;
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x000F88CC File Offset: 0x000F6ACC
		public global::Org.BouncyCastle.X509.Store.IX509Store GetCertificates(global::Org.BouncyCastle.Asn1.Asn1Set certificates)
		{
			global::System.Collections.IList certList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (certificates != null)
			{
				foreach (object obj in certificates)
				{
					global::Org.BouncyCastle.Asn1.Asn1Encodable enc = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
					certList.Add(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(enc));
				}
			}
			return new global::Org.BouncyCastle.X509.Store.X509CollectionStore(certList);
		}

		// Token: 0x04001736 RID: 5942
		internal static readonly global::Org.BouncyCastle.Cms.CmsSignedHelper Instance = new global::Org.BouncyCastle.Cms.CmsSignedHelper();

		// Token: 0x04001737 RID: 5943
		private static readonly string EncryptionECDsaWithSha1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1.Id;

		// Token: 0x04001738 RID: 5944
		private static readonly string EncryptionECDsaWithSha224 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224.Id;

		// Token: 0x04001739 RID: 5945
		private static readonly string EncryptionECDsaWithSha256 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256.Id;

		// Token: 0x0400173A RID: 5946
		private static readonly string EncryptionECDsaWithSha384 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384.Id;

		// Token: 0x0400173B RID: 5947
		private static readonly string EncryptionECDsaWithSha512 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512.Id;

		// Token: 0x0400173C RID: 5948
		private static readonly global::System.Collections.IDictionary encryptionAlgs = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400173D RID: 5949
		private static readonly global::System.Collections.IDictionary digestAlgs = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400173E RID: 5950
		private static readonly global::System.Collections.IDictionary digestAliases = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400173F RID: 5951
		private static readonly global::Org.BouncyCastle.Utilities.Collections.ISet noParams = new global::Org.BouncyCastle.Utilities.Collections.HashSet();

		// Token: 0x04001740 RID: 5952
		private static readonly global::System.Collections.IDictionary ecAlgorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
