using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Kisa;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Nsri;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001C1 RID: 449
	public sealed class CipherUtilities
	{
		// Token: 0x060010BC RID: 4284 RVA: 0x000445B8 File Offset: 0x000427B8
		static CipherUtilities()
		{
			((global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm)global::Org.BouncyCastle.Utilities.Enums.GetArbitraryValue(typeof(global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm))).ToString();
			((global::Org.BouncyCastle.Security.CipherUtilities.CipherMode)global::Org.BouncyCastle.Utilities.Enums.GetArbitraryValue(typeof(global::Org.BouncyCastle.Security.CipherUtilities.CipherMode))).ToString();
			((global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding)global::Org.BouncyCastle.Utilities.Enums.GetArbitraryValue(typeof(global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding))).ToString();
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc.Id] = "AES/CBC/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc.Id] = "AES/CBC/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc.Id] = "AES/CBC/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ccm.Id] = "AES/CCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ccm.Id] = "AES/CCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ccm.Id] = "AES/CCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cfb.Id] = "AES/CFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cfb.Id] = "AES/CFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cfb.Id] = "AES/CFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ecb.Id] = "AES/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ecb.Id] = "AES/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ecb.Id] = "AES/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["AES//PKCS7"] = "AES/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["AES//PKCS7PADDING"] = "AES/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["AES//PKCS5"] = "AES/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["AES//PKCS5PADDING"] = "AES/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Gcm.Id] = "AES/GCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Gcm.Id] = "AES/GCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Gcm.Id] = "AES/GCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ofb.Id] = "AES/OFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ofb.Id] = "AES/OFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ofb.Id] = "AES/OFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_cbc.Id] = "ARIA/CBC/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_cbc.Id] = "ARIA/CBC/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_cbc.Id] = "ARIA/CBC/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_ccm.Id] = "ARIA/CCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_ccm.Id] = "ARIA/CCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_ccm.Id] = "ARIA/CCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_cfb.Id] = "ARIA/CFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_cfb.Id] = "ARIA/CFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_cfb.Id] = "ARIA/CFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_ctr.Id] = "ARIA/CTR/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_ctr.Id] = "ARIA/CTR/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_ctr.Id] = "ARIA/CTR/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_ecb.Id] = "ARIA/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_ecb.Id] = "ARIA/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_ecb.Id] = "ARIA/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["ARIA//PKCS7"] = "ARIA/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["ARIA//PKCS7PADDING"] = "ARIA/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["ARIA//PKCS5"] = "ARIA/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["ARIA//PKCS5PADDING"] = "ARIA/ECB/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_gcm.Id] = "ARIA/GCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_gcm.Id] = "ARIA/GCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_gcm.Id] = "ARIA/GCM/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_ofb.Id] = "ARIA/OFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_ofb.Id] = "ARIA/OFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_ofb.Id] = "ARIA/OFB/NOPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["RSA/ECB/PKCS1"] = "RSA//PKCS1PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["RSA/ECB/PKCS1PADDING"] = "RSA//PKCS1PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption.Id] = "RSA//PKCS1PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsaesOaep.Id] = "RSA//OAEPPADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCbc.Id] = "DES/CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCfb.Id] = "DES/CFB";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesEcb.Id] = "DES/ECB";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesOfb.Id] = "DES/OFB";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesEde.Id] = "DESEDE";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["TDEA"] = "DESEDE";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc.Id] = "DESEDE/CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc.Id] = "RC2/CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["1.3.6.1.4.1.188.7.1.1.2"] = "IDEA/CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["1.2.840.113533.7.66.10"] = "CAST5/CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["RC4"] = "ARC4";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["ARCFOUR"] = "ARC4";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["1.2.840.113549.3.4"] = "ARC4";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1AND128BITRC4"] = "PBEWITHSHAAND128BITRC4";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd128BitRC4.Id] = "PBEWITHSHAAND128BITRC4";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1AND40BITRC4"] = "PBEWITHSHAAND40BITRC4";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd40BitRC4.Id] = "PBEWITHSHAAND40BITRC4";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1ANDDES"] = "PBEWITHSHA1ANDDES-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithSha1AndDesCbc.Id] = "PBEWITHSHA1ANDDES-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1ANDRC2"] = "PBEWITHSHA1ANDRC2-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithSha1AndRC2Cbc.Id] = "PBEWITHSHA1ANDRC2-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1AND3-KEYTRIPLEDES-CBC"] = "PBEWITHSHAAND3-KEYTRIPLEDES-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHAAND3KEYTRIPLEDES"] = "PBEWITHSHAAND3-KEYTRIPLEDES-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd3KeyTripleDesCbc.Id] = "PBEWITHSHAAND3-KEYTRIPLEDES-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1ANDDESEDE"] = "PBEWITHSHAAND3-KEYTRIPLEDES-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1AND2-KEYTRIPLEDES-CBC"] = "PBEWITHSHAAND2-KEYTRIPLEDES-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd2KeyTripleDesCbc.Id] = "PBEWITHSHAAND2-KEYTRIPLEDES-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1AND128BITRC2-CBC"] = "PBEWITHSHAAND128BITRC2-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd128BitRC2Cbc.Id] = "PBEWITHSHAAND128BITRC2-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1AND40BITRC2-CBC"] = "PBEWITHSHAAND40BITRC2-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbewithShaAnd40BitRC2Cbc.Id] = "PBEWITHSHAAND40BITRC2-CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1AND128BITAES-CBC-BC"] = "PBEWITHSHAAND128BITAES-CBC-BC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA-1AND128BITAES-CBC-BC"] = "PBEWITHSHAAND128BITAES-CBC-BC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1AND192BITAES-CBC-BC"] = "PBEWITHSHAAND192BITAES-CBC-BC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA-1AND192BITAES-CBC-BC"] = "PBEWITHSHAAND192BITAES-CBC-BC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA1AND256BITAES-CBC-BC"] = "PBEWITHSHAAND256BITAES-CBC-BC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA-1AND256BITAES-CBC-BC"] = "PBEWITHSHAAND256BITAES-CBC-BC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA-256AND128BITAES-CBC-BC"] = "PBEWITHSHA256AND128BITAES-CBC-BC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA-256AND192BITAES-CBC-BC"] = "PBEWITHSHA256AND192BITAES-CBC-BC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["PBEWITHSHA-256AND256BITAES-CBC-BC"] = "PBEWITHSHA256AND256BITAES-CBC-BC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["GOST"] = "GOST28147";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["GOST-28147"] = "GOST28147";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR28147Cbc.Id] = "GOST28147/CBC/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["RC5-32"] = "RC5";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Cbc.Id] = "CAMELLIA/CBC/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Cbc.Id] = "CAMELLIA/CBC/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Cbc.Id] = "CAMELLIA/CBC/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdSeedCbc.Id] = "SEED/CBC/PKCS7PADDING";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["1.3.6.1.4.1.3029.1.2"] = "BLOWFISH/CBC";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms["CHACHA20"] = "CHACHA7539";
			global::Org.BouncyCastle.Security.CipherUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgAeadChaCha20Poly1305.Id] = "CHACHA20-POLY1305";
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00044F70 File Offset: 0x00043170
		private CipherUtilities()
		{
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00044F78 File Offset: 0x00043178
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetObjectIdentifier(string mechanism)
		{
			if (mechanism == null)
			{
				throw new global::System.ArgumentNullException("mechanism");
			}
			mechanism = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(mechanism);
			string aliased = (string)global::Org.BouncyCastle.Security.CipherUtilities.algorithms[mechanism];
			if (aliased != null)
			{
				mechanism = aliased;
			}
			return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Security.CipherUtilities.oids[mechanism];
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x00044FC2 File Offset: 0x000431C2
		public static global::System.Collections.ICollection Algorithms
		{
			get
			{
				return global::Org.BouncyCastle.Security.CipherUtilities.oids.Keys;
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00044FCE File Offset: 0x000431CE
		public static global::Org.BouncyCastle.Crypto.IBufferedCipher GetCipher(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(oid.Id);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00044FDC File Offset: 0x000431DC
		public static global::Org.BouncyCastle.Crypto.IBufferedCipher GetCipher(string algorithm)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			algorithm = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm);
			string aliased = (string)global::Org.BouncyCastle.Security.CipherUtilities.algorithms[algorithm];
			if (aliased != null)
			{
				algorithm = aliased;
			}
			global::Org.BouncyCastle.Crypto.IBasicAgreement iesAgreement = null;
			if (algorithm == "IES")
			{
				iesAgreement = new global::Org.BouncyCastle.Crypto.Agreement.DHBasicAgreement();
			}
			else if (algorithm == "ECIES")
			{
				iesAgreement = new global::Org.BouncyCastle.Crypto.Agreement.ECDHBasicAgreement();
			}
			if (iesAgreement != null)
			{
				return new global::Org.BouncyCastle.Crypto.BufferedIesCipher(new global::Org.BouncyCastle.Crypto.Engines.IesEngine(iesAgreement, new global::Org.BouncyCastle.Crypto.Generators.Kdf2BytesGenerator(new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest()), new global::Org.BouncyCastle.Crypto.Macs.HMac(new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest())));
			}
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(algorithm, "PBE"))
			{
				if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(algorithm, "-CBC"))
				{
					if (algorithm == "PBEWITHSHA1ANDDES-CBC")
					{
						return new global::Org.BouncyCastle.Crypto.Paddings.PaddedBufferedBlockCipher(new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.DesEngine()));
					}
					if (algorithm == "PBEWITHSHA1ANDRC2-CBC")
					{
						return new global::Org.BouncyCastle.Crypto.Paddings.PaddedBufferedBlockCipher(new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.RC2Engine()));
					}
					if (global::Org.BouncyCastle.Utilities.Strings.IsOneOf(algorithm, new string[]
					{
						"PBEWITHSHAAND2-KEYTRIPLEDES-CBC",
						"PBEWITHSHAAND3-KEYTRIPLEDES-CBC"
					}))
					{
						return new global::Org.BouncyCastle.Crypto.Paddings.PaddedBufferedBlockCipher(new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine()));
					}
					if (global::Org.BouncyCastle.Utilities.Strings.IsOneOf(algorithm, new string[]
					{
						"PBEWITHSHAAND128BITRC2-CBC",
						"PBEWITHSHAAND40BITRC2-CBC"
					}))
					{
						return new global::Org.BouncyCastle.Crypto.Paddings.PaddedBufferedBlockCipher(new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.RC2Engine()));
					}
				}
				else if ((global::Org.BouncyCastle.Utilities.Platform.EndsWith(algorithm, "-BC") || global::Org.BouncyCastle.Utilities.Platform.EndsWith(algorithm, "-OPENSSL")) && global::Org.BouncyCastle.Utilities.Strings.IsOneOf(algorithm, new string[]
				{
					"PBEWITHSHAAND128BITAES-CBC-BC",
					"PBEWITHSHAAND192BITAES-CBC-BC",
					"PBEWITHSHAAND256BITAES-CBC-BC",
					"PBEWITHSHA256AND128BITAES-CBC-BC",
					"PBEWITHSHA256AND192BITAES-CBC-BC",
					"PBEWITHSHA256AND256BITAES-CBC-BC",
					"PBEWITHMD5AND128BITAES-CBC-OPENSSL",
					"PBEWITHMD5AND192BITAES-CBC-OPENSSL",
					"PBEWITHMD5AND256BITAES-CBC-OPENSSL"
				}))
				{
					return new global::Org.BouncyCastle.Crypto.Paddings.PaddedBufferedBlockCipher(new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.AesEngine()));
				}
			}
			string[] parts = algorithm.Split(new char[]
			{
				'/'
			});
			global::Org.BouncyCastle.Crypto.Modes.IAeadCipher aeadCipher = null;
			global::Org.BouncyCastle.Crypto.IBlockCipher blockCipher = null;
			global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher asymBlockCipher = null;
			global::Org.BouncyCastle.Crypto.IStreamCipher streamCipher = null;
			string algorithmName = parts[0];
			string aliased2 = (string)global::Org.BouncyCastle.Security.CipherUtilities.algorithms[algorithmName];
			if (aliased2 != null)
			{
				algorithmName = aliased2;
			}
			global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm cipherAlgorithm;
			try
			{
				cipherAlgorithm = (global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm)global::Org.BouncyCastle.Utilities.Enums.GetEnumValue(typeof(global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm), algorithmName);
			}
			catch (global::System.ArgumentException)
			{
				throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Cipher " + algorithm + " not recognised.");
			}
			switch (cipherAlgorithm)
			{
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.AES:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.AesEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.ARC4:
				streamCipher = new global::Org.BouncyCastle.Crypto.Engines.RC4Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.ARIA:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.AriaEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.BLOWFISH:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.BlowfishEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.CAMELLIA:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.CamelliaEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.CAST5:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.Cast5Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.CAST6:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.Cast6Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.CHACHA:
				streamCipher = new global::Org.BouncyCastle.Crypto.Engines.ChaChaEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.CHACHA20_POLY1305:
				aeadCipher = new global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.CHACHA7539:
				streamCipher = new global::Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.DES:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.DesEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.DESEDE:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.ELGAMAL:
				asymBlockCipher = new global::Org.BouncyCastle.Crypto.Engines.ElGamalEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.GOST28147:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.HC128:
				streamCipher = new global::Org.BouncyCastle.Crypto.Engines.HC128Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.HC256:
				streamCipher = new global::Org.BouncyCastle.Crypto.Engines.HC256Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.IDEA:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.IdeaEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.NOEKEON:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.NoekeonEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.PBEWITHSHAAND128BITRC4:
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.PBEWITHSHAAND40BITRC4:
				streamCipher = new global::Org.BouncyCastle.Crypto.Engines.RC4Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.RC2:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.RC2Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.RC5:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.RC532Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.RC5_64:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.RC564Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.RC6:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.RC6Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.RIJNDAEL:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.RijndaelEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.RSA:
				asymBlockCipher = new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.SALSA20:
				streamCipher = new global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.SEED:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.SeedEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.SERPENT:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.SerpentEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.SKIPJACK:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.SM4:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.SM4Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.TEA:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.TeaEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.THREEFISH_256:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine(256);
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.THREEFISH_512:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine(512);
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.THREEFISH_1024:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine(1024);
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.TNEPRES:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.TnepresEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.TWOFISH:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.TwofishEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.VMPC:
				streamCipher = new global::Org.BouncyCastle.Crypto.Engines.VmpcEngine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.VMPC_KSA3:
				streamCipher = new global::Org.BouncyCastle.Crypto.Engines.VmpcKsa3Engine();
				break;
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.XTEA:
				blockCipher = new global::Org.BouncyCastle.Crypto.Engines.XteaEngine();
				break;
			default:
				throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Cipher " + algorithm + " not recognised.");
			}
			if (aeadCipher != null)
			{
				if (parts.Length > 1)
				{
					throw new global::System.ArgumentException("Modes and paddings cannot be applied to AEAD ciphers");
				}
				return new global::Org.BouncyCastle.Crypto.BufferedAeadCipher(aeadCipher);
			}
			else if (streamCipher != null)
			{
				if (parts.Length > 1)
				{
					throw new global::System.ArgumentException("Modes and paddings not used for stream ciphers");
				}
				return new global::Org.BouncyCastle.Crypto.BufferedStreamCipher(streamCipher);
			}
			else
			{
				bool cts = false;
				bool padded = true;
				global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding = null;
				global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher aeadBlockCipher = null;
				if (parts.Length > 2)
				{
					if (streamCipher != null)
					{
						throw new global::System.ArgumentException("Paddings not used for stream ciphers");
					}
					string paddingName = parts[2];
					global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding cipherPadding;
					if (paddingName == "")
					{
						cipherPadding = global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.RAW;
					}
					else if (paddingName == "X9.23PADDING")
					{
						cipherPadding = global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.X923PADDING;
					}
					else
					{
						try
						{
							cipherPadding = (global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding)global::Org.BouncyCastle.Utilities.Enums.GetEnumValue(typeof(global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding), paddingName);
						}
						catch (global::System.ArgumentException)
						{
							throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Cipher " + algorithm + " not recognised.");
						}
					}
					switch (cipherPadding)
					{
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.NOPADDING:
						padded = false;
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.RAW:
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.ISO10126PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.ISO10126D2PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.ISO10126_2PADDING:
						padding = new global::Org.BouncyCastle.Crypto.Paddings.ISO10126d2Padding();
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.ISO7816_4PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.ISO9797_1PADDING:
						padding = new global::Org.BouncyCastle.Crypto.Paddings.ISO7816d4Padding();
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.ISO9796_1:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.ISO9796_1PADDING:
						asymBlockCipher = new global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding(asymBlockCipher);
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEP:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPPADDING:
						asymBlockCipher = new global::Org.BouncyCastle.Crypto.Encodings.OaepEncoding(asymBlockCipher);
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHMD5ANDMGF1PADDING:
						asymBlockCipher = new global::Org.BouncyCastle.Crypto.Encodings.OaepEncoding(asymBlockCipher, new global::Org.BouncyCastle.Crypto.Digests.MD5Digest());
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA1ANDMGF1PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA_1ANDMGF1PADDING:
						asymBlockCipher = new global::Org.BouncyCastle.Crypto.Encodings.OaepEncoding(asymBlockCipher, new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest());
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA224ANDMGF1PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA_224ANDMGF1PADDING:
						asymBlockCipher = new global::Org.BouncyCastle.Crypto.Encodings.OaepEncoding(asymBlockCipher, new global::Org.BouncyCastle.Crypto.Digests.Sha224Digest());
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA256ANDMGF1PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA_256ANDMGF1PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA256ANDMGF1WITHSHA256PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA_256ANDMGF1WITHSHA_256PADDING:
						asymBlockCipher = new global::Org.BouncyCastle.Crypto.Encodings.OaepEncoding(asymBlockCipher, new global::Org.BouncyCastle.Crypto.Digests.Sha256Digest());
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA256ANDMGF1WITHSHA1PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA_256ANDMGF1WITHSHA_1PADDING:
						asymBlockCipher = new global::Org.BouncyCastle.Crypto.Encodings.OaepEncoding(asymBlockCipher, new global::Org.BouncyCastle.Crypto.Digests.Sha256Digest(), new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest(), null);
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA384ANDMGF1PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA_384ANDMGF1PADDING:
						asymBlockCipher = new global::Org.BouncyCastle.Crypto.Encodings.OaepEncoding(asymBlockCipher, new global::Org.BouncyCastle.Crypto.Digests.Sha384Digest());
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA512ANDMGF1PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.OAEPWITHSHA_512ANDMGF1PADDING:
						asymBlockCipher = new global::Org.BouncyCastle.Crypto.Encodings.OaepEncoding(asymBlockCipher, new global::Org.BouncyCastle.Crypto.Digests.Sha512Digest());
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.PKCS1:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.PKCS1PADDING:
						asymBlockCipher = new global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(asymBlockCipher);
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.PKCS5:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.PKCS5PADDING:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.PKCS7:
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.PKCS7PADDING:
						padding = new global::Org.BouncyCastle.Crypto.Paddings.Pkcs7Padding();
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.TBCPADDING:
						padding = new global::Org.BouncyCastle.Crypto.Paddings.TbcPadding();
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.WITHCTS:
						cts = true;
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.X923PADDING:
						padding = new global::Org.BouncyCastle.Crypto.Paddings.X923Padding();
						break;
					case global::Org.BouncyCastle.Security.CipherUtilities.CipherPadding.ZEROBYTEPADDING:
						padding = new global::Org.BouncyCastle.Crypto.Paddings.ZeroBytePadding();
						break;
					default:
						throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Cipher " + algorithm + " not recognised.");
					}
				}
				if (parts.Length > 1)
				{
					string mode = parts[1];
					int di = global::Org.BouncyCastle.Security.CipherUtilities.GetDigitIndex(mode);
					string modeName = (di >= 0) ? mode.Substring(0, di) : mode;
					try
					{
						switch ((modeName == "") ? global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.NONE : ((global::Org.BouncyCastle.Security.CipherUtilities.CipherMode)global::Org.BouncyCastle.Utilities.Enums.GetEnumValue(typeof(global::Org.BouncyCastle.Security.CipherUtilities.CipherMode), modeName)))
						{
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.ECB:
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.NONE:
							break;
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.CBC:
							blockCipher = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(blockCipher);
							break;
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.CCM:
							aeadBlockCipher = new global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher(blockCipher);
							break;
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.CFB:
						{
							int bits = (di < 0) ? (8 * blockCipher.GetBlockSize()) : int.Parse(mode.Substring(di));
							blockCipher = new global::Org.BouncyCastle.Crypto.Modes.CfbBlockCipher(blockCipher, bits);
							break;
						}
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.CTR:
							blockCipher = new global::Org.BouncyCastle.Crypto.Modes.SicBlockCipher(blockCipher);
							break;
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.CTS:
							cts = true;
							blockCipher = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(blockCipher);
							break;
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.EAX:
							aeadBlockCipher = new global::Org.BouncyCastle.Crypto.Modes.EaxBlockCipher(blockCipher);
							break;
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.GCM:
							aeadBlockCipher = new global::Org.BouncyCastle.Crypto.Modes.GcmBlockCipher(blockCipher);
							break;
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.GOFB:
							blockCipher = new global::Org.BouncyCastle.Crypto.Modes.GOfbBlockCipher(blockCipher);
							break;
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.OCB:
							aeadBlockCipher = new global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher(blockCipher, global::Org.BouncyCastle.Security.CipherUtilities.CreateBlockCipher(cipherAlgorithm));
							break;
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.OFB:
						{
							int bits2 = (di < 0) ? (8 * blockCipher.GetBlockSize()) : int.Parse(mode.Substring(di));
							blockCipher = new global::Org.BouncyCastle.Crypto.Modes.OfbBlockCipher(blockCipher, bits2);
							break;
						}
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.OPENPGPCFB:
							blockCipher = new global::Org.BouncyCastle.Crypto.Modes.OpenPgpCfbBlockCipher(blockCipher);
							break;
						case global::Org.BouncyCastle.Security.CipherUtilities.CipherMode.SIC:
							if (blockCipher.GetBlockSize() < 16)
							{
								throw new global::System.ArgumentException("Warning: SIC-Mode can become a twotime-pad if the blocksize of the cipher is too small. Use a cipher with a block size of at least 128 bits (e.g. AES)");
							}
							blockCipher = new global::Org.BouncyCastle.Crypto.Modes.SicBlockCipher(blockCipher);
							break;
						default:
							throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Cipher " + algorithm + " not recognised.");
						}
					}
					catch (global::System.ArgumentException)
					{
						throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Cipher " + algorithm + " not recognised.");
					}
				}
				if (aeadBlockCipher != null)
				{
					if (cts)
					{
						throw new global::Org.BouncyCastle.Security.SecurityUtilityException("CTS mode not valid for AEAD ciphers.");
					}
					if (padded && parts.Length > 2 && parts[2] != "")
					{
						throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Bad padding specified for AEAD cipher.");
					}
					return new global::Org.BouncyCastle.Crypto.BufferedAeadBlockCipher(aeadBlockCipher);
				}
				else if (blockCipher != null)
				{
					if (cts)
					{
						return new global::Org.BouncyCastle.Crypto.Modes.CtsBlockCipher(blockCipher);
					}
					if (padding != null)
					{
						return new global::Org.BouncyCastle.Crypto.Paddings.PaddedBufferedBlockCipher(blockCipher, padding);
					}
					if (!padded || blockCipher.IsPartialBlockOkay)
					{
						return new global::Org.BouncyCastle.Crypto.BufferedBlockCipher(blockCipher);
					}
					return new global::Org.BouncyCastle.Crypto.Paddings.PaddedBufferedBlockCipher(blockCipher);
				}
				else
				{
					if (asymBlockCipher != null)
					{
						return new global::Org.BouncyCastle.Crypto.BufferedAsymmetricBlockCipher(asymBlockCipher);
					}
					throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Cipher " + algorithm + " not recognised.");
				}
			}
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00045968 File Offset: 0x00043B68
		public static string GetAlgorithmName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Security.CipherUtilities.algorithms[oid.Id];
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00045980 File Offset: 0x00043B80
		private static int GetDigitIndex(string s)
		{
			for (int i = 0; i < s.Length; i++)
			{
				if (char.IsDigit(s[i]))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x000459B0 File Offset: 0x00043BB0
		private static global::Org.BouncyCastle.Crypto.IBlockCipher CreateBlockCipher(global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm cipherAlgorithm)
		{
			switch (cipherAlgorithm)
			{
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.AES:
				return new global::Org.BouncyCastle.Crypto.Engines.AesEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.ARIA:
				return new global::Org.BouncyCastle.Crypto.Engines.AriaEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.BLOWFISH:
				return new global::Org.BouncyCastle.Crypto.Engines.BlowfishEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.CAMELLIA:
				return new global::Org.BouncyCastle.Crypto.Engines.CamelliaEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.CAST5:
				return new global::Org.BouncyCastle.Crypto.Engines.Cast5Engine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.CAST6:
				return new global::Org.BouncyCastle.Crypto.Engines.Cast6Engine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.DES:
				return new global::Org.BouncyCastle.Crypto.Engines.DesEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.DESEDE:
				return new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.GOST28147:
				return new global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.IDEA:
				return new global::Org.BouncyCastle.Crypto.Engines.IdeaEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.NOEKEON:
				return new global::Org.BouncyCastle.Crypto.Engines.NoekeonEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.RC2:
				return new global::Org.BouncyCastle.Crypto.Engines.RC2Engine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.RC5:
				return new global::Org.BouncyCastle.Crypto.Engines.RC532Engine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.RC5_64:
				return new global::Org.BouncyCastle.Crypto.Engines.RC564Engine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.RC6:
				return new global::Org.BouncyCastle.Crypto.Engines.RC6Engine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.RIJNDAEL:
				return new global::Org.BouncyCastle.Crypto.Engines.RijndaelEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.SEED:
				return new global::Org.BouncyCastle.Crypto.Engines.SeedEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.SERPENT:
				return new global::Org.BouncyCastle.Crypto.Engines.SerpentEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.SKIPJACK:
				return new global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.SM4:
				return new global::Org.BouncyCastle.Crypto.Engines.SM4Engine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.TEA:
				return new global::Org.BouncyCastle.Crypto.Engines.TeaEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.THREEFISH_256:
				return new global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine(256);
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.THREEFISH_512:
				return new global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine(512);
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.THREEFISH_1024:
				return new global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine(1024);
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.TNEPRES:
				return new global::Org.BouncyCastle.Crypto.Engines.TnepresEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.TWOFISH:
				return new global::Org.BouncyCastle.Crypto.Engines.TwofishEngine();
			case global::Org.BouncyCastle.Security.CipherUtilities.CipherAlgorithm.XTEA:
				return new global::Org.BouncyCastle.Crypto.Engines.XteaEngine();
			}
			throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Cipher " + cipherAlgorithm.ToString() + " not recognised or not a block cipher");
		}

		// Token: 0x040008C8 RID: 2248
		private static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008C9 RID: 2249
		private static readonly global::System.Collections.IDictionary oids = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x020007B3 RID: 1971
		private enum CipherAlgorithm
		{
			// Token: 0x04002346 RID: 9030
			AES,
			// Token: 0x04002347 RID: 9031
			ARC4,
			// Token: 0x04002348 RID: 9032
			ARIA,
			// Token: 0x04002349 RID: 9033
			BLOWFISH,
			// Token: 0x0400234A RID: 9034
			CAMELLIA,
			// Token: 0x0400234B RID: 9035
			CAST5,
			// Token: 0x0400234C RID: 9036
			CAST6,
			// Token: 0x0400234D RID: 9037
			CHACHA,
			// Token: 0x0400234E RID: 9038
			CHACHA20_POLY1305,
			// Token: 0x0400234F RID: 9039
			CHACHA7539,
			// Token: 0x04002350 RID: 9040
			DES,
			// Token: 0x04002351 RID: 9041
			DESEDE,
			// Token: 0x04002352 RID: 9042
			ELGAMAL,
			// Token: 0x04002353 RID: 9043
			GOST28147,
			// Token: 0x04002354 RID: 9044
			HC128,
			// Token: 0x04002355 RID: 9045
			HC256,
			// Token: 0x04002356 RID: 9046
			IDEA,
			// Token: 0x04002357 RID: 9047
			NOEKEON,
			// Token: 0x04002358 RID: 9048
			PBEWITHSHAAND128BITRC4,
			// Token: 0x04002359 RID: 9049
			PBEWITHSHAAND40BITRC4,
			// Token: 0x0400235A RID: 9050
			RC2,
			// Token: 0x0400235B RID: 9051
			RC5,
			// Token: 0x0400235C RID: 9052
			RC5_64,
			// Token: 0x0400235D RID: 9053
			RC6,
			// Token: 0x0400235E RID: 9054
			RIJNDAEL,
			// Token: 0x0400235F RID: 9055
			RSA,
			// Token: 0x04002360 RID: 9056
			SALSA20,
			// Token: 0x04002361 RID: 9057
			SEED,
			// Token: 0x04002362 RID: 9058
			SERPENT,
			// Token: 0x04002363 RID: 9059
			SKIPJACK,
			// Token: 0x04002364 RID: 9060
			SM4,
			// Token: 0x04002365 RID: 9061
			TEA,
			// Token: 0x04002366 RID: 9062
			THREEFISH_256,
			// Token: 0x04002367 RID: 9063
			THREEFISH_512,
			// Token: 0x04002368 RID: 9064
			THREEFISH_1024,
			// Token: 0x04002369 RID: 9065
			TNEPRES,
			// Token: 0x0400236A RID: 9066
			TWOFISH,
			// Token: 0x0400236B RID: 9067
			VMPC,
			// Token: 0x0400236C RID: 9068
			VMPC_KSA3,
			// Token: 0x0400236D RID: 9069
			XTEA
		}

		// Token: 0x020007B4 RID: 1972
		private enum CipherMode
		{
			// Token: 0x0400236F RID: 9071
			ECB,
			// Token: 0x04002370 RID: 9072
			NONE,
			// Token: 0x04002371 RID: 9073
			CBC,
			// Token: 0x04002372 RID: 9074
			CCM,
			// Token: 0x04002373 RID: 9075
			CFB,
			// Token: 0x04002374 RID: 9076
			CTR,
			// Token: 0x04002375 RID: 9077
			CTS,
			// Token: 0x04002376 RID: 9078
			EAX,
			// Token: 0x04002377 RID: 9079
			GCM,
			// Token: 0x04002378 RID: 9080
			GOFB,
			// Token: 0x04002379 RID: 9081
			OCB,
			// Token: 0x0400237A RID: 9082
			OFB,
			// Token: 0x0400237B RID: 9083
			OPENPGPCFB,
			// Token: 0x0400237C RID: 9084
			SIC
		}

		// Token: 0x020007B5 RID: 1973
		private enum CipherPadding
		{
			// Token: 0x0400237E RID: 9086
			NOPADDING,
			// Token: 0x0400237F RID: 9087
			RAW,
			// Token: 0x04002380 RID: 9088
			ISO10126PADDING,
			// Token: 0x04002381 RID: 9089
			ISO10126D2PADDING,
			// Token: 0x04002382 RID: 9090
			ISO10126_2PADDING,
			// Token: 0x04002383 RID: 9091
			ISO7816_4PADDING,
			// Token: 0x04002384 RID: 9092
			ISO9797_1PADDING,
			// Token: 0x04002385 RID: 9093
			ISO9796_1,
			// Token: 0x04002386 RID: 9094
			ISO9796_1PADDING,
			// Token: 0x04002387 RID: 9095
			OAEP,
			// Token: 0x04002388 RID: 9096
			OAEPPADDING,
			// Token: 0x04002389 RID: 9097
			OAEPWITHMD5ANDMGF1PADDING,
			// Token: 0x0400238A RID: 9098
			OAEPWITHSHA1ANDMGF1PADDING,
			// Token: 0x0400238B RID: 9099
			OAEPWITHSHA_1ANDMGF1PADDING,
			// Token: 0x0400238C RID: 9100
			OAEPWITHSHA224ANDMGF1PADDING,
			// Token: 0x0400238D RID: 9101
			OAEPWITHSHA_224ANDMGF1PADDING,
			// Token: 0x0400238E RID: 9102
			OAEPWITHSHA256ANDMGF1PADDING,
			// Token: 0x0400238F RID: 9103
			OAEPWITHSHA_256ANDMGF1PADDING,
			// Token: 0x04002390 RID: 9104
			OAEPWITHSHA256ANDMGF1WITHSHA256PADDING,
			// Token: 0x04002391 RID: 9105
			OAEPWITHSHA_256ANDMGF1WITHSHA_256PADDING,
			// Token: 0x04002392 RID: 9106
			OAEPWITHSHA256ANDMGF1WITHSHA1PADDING,
			// Token: 0x04002393 RID: 9107
			OAEPWITHSHA_256ANDMGF1WITHSHA_1PADDING,
			// Token: 0x04002394 RID: 9108
			OAEPWITHSHA384ANDMGF1PADDING,
			// Token: 0x04002395 RID: 9109
			OAEPWITHSHA_384ANDMGF1PADDING,
			// Token: 0x04002396 RID: 9110
			OAEPWITHSHA512ANDMGF1PADDING,
			// Token: 0x04002397 RID: 9111
			OAEPWITHSHA_512ANDMGF1PADDING,
			// Token: 0x04002398 RID: 9112
			PKCS1,
			// Token: 0x04002399 RID: 9113
			PKCS1PADDING,
			// Token: 0x0400239A RID: 9114
			PKCS5,
			// Token: 0x0400239B RID: 9115
			PKCS5PADDING,
			// Token: 0x0400239C RID: 9116
			PKCS7,
			// Token: 0x0400239D RID: 9117
			PKCS7PADDING,
			// Token: 0x0400239E RID: 9118
			TBCPADDING,
			// Token: 0x0400239F RID: 9119
			WITHCTS,
			// Token: 0x040023A0 RID: 9120
			X923PADDING,
			// Token: 0x040023A1 RID: 9121
			ZEROBYTEPADDING
		}
	}
}
