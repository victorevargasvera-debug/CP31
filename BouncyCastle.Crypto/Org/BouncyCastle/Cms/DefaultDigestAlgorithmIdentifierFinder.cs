using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200053B RID: 1339
	public class DefaultDigestAlgorithmIdentifierFinder
	{
		// Token: 0x060033C1 RID: 13249 RVA: 0x000F7320 File Offset: 0x000F5520
		static DefaultDigestAlgorithmIdentifierFinder()
		{
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD4WithRsaEncryption, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD4WithRsa, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD5WithRsa, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.Sha1WithRsa, global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1, global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_224, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_256, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_384, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_512, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4WithRsaEncryption, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption, global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1, global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1, global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94, global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001, global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA-1", global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA-224", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA-256", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA-384", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA-512", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA-512/224", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA-512(224)", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA-512/256", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA-512(256)", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA1", global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA224", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA256", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA384", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA512", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA512/224", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA512(224)", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA512/256", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA512(256)", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA3-224", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA3-256", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA3-384", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHA3-512", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHAKE-128", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake128);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("SHAKE-256", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake256);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("GOST3411", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("MD2", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("MD4", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("MD5", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("RIPEMD128", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("RIPEMD160", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160);
			global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids.Add("RIPEMD256", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256);
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x000F7858 File Offset: 0x000F5A58
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier find(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgId;
			if (sigAlgId.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss))
			{
				digAlgId = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.GetInstance(sigAlgId.Parameters).HashAlgorithm;
			}
			else
			{
				digAlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestOids[sigAlgId.Algorithm], global::Org.BouncyCastle.Asn1.DerNull.Instance);
			}
			return digAlgId;
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x000F78AB File Offset: 0x000F5AAB
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier find(string digAlgName)
		{
			return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder.digestNameToOids[digAlgName], global::Org.BouncyCastle.Asn1.DerNull.Instance);
		}

		// Token: 0x0400171A RID: 5914
		private static readonly global::System.Collections.IDictionary digestOids = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400171B RID: 5915
		private static readonly global::System.Collections.IDictionary digestNameToOids = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
