using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Kisa;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200052C RID: 1324
	public class CmsEnvelopedGenerator
	{
		// Token: 0x06003320 RID: 13088 RVA: 0x000F41E7 File Offset: 0x000F23E7
		public CmsEnvelopedGenerator() : this(new global::Org.BouncyCastle.Security.SecureRandom())
		{
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x000F41F4 File Offset: 0x000F23F4
		public CmsEnvelopedGenerator(global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			this.rand = rand;
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x000F420E File Offset: 0x000F240E
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x000F4216 File Offset: 0x000F2416
		public global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator UnprotectedAttributeGenerator
		{
			get
			{
				return this.unprotectedAttributeGenerator;
			}
			set
			{
				this.unprotectedAttributeGenerator = value;
			}
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x000F4220 File Offset: 0x000F2420
		public void AddKeyTransRecipient(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo info = global::Org.BouncyCastle.Cms.CmsUtilities.GetTbsCertificateStructure(cert).SubjectPublicKeyInfo;
			this.AddRecipientInfoGenerator(new global::Org.BouncyCastle.Cms.KeyTransRecipientInfoGenerator(cert, new global::Org.BouncyCastle.Crypto.Operators.Asn1KeyWrapper(info.AlgorithmID.Algorithm, info.AlgorithmID.Parameters, cert)));
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x000F4264 File Offset: 0x000F2464
		public void AddKeyTransRecipient(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey, byte[] subKeyId)
		{
			global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo info = global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(pubKey);
			this.AddRecipientInfoGenerator(new global::Org.BouncyCastle.Cms.KeyTransRecipientInfoGenerator(subKeyId, new global::Org.BouncyCastle.Crypto.Operators.Asn1KeyWrapper(info.AlgorithmID.Algorithm, info.AlgorithmID.Parameters, pubKey)));
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x000F42A0 File Offset: 0x000F24A0
		public void AddKekRecipient(string keyAlgorithm, global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key, byte[] keyIdentifier)
		{
			this.AddKekRecipient(keyAlgorithm, key, new global::Org.BouncyCastle.Asn1.Cms.KekIdentifier(keyIdentifier, null, null));
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x000F42B4 File Offset: 0x000F24B4
		public void AddKekRecipient(string keyAlgorithm, global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key, global::Org.BouncyCastle.Asn1.Cms.KekIdentifier kekIdentifier)
		{
			global::Org.BouncyCastle.Cms.KekRecipientInfoGenerator kekrig = new global::Org.BouncyCastle.Cms.KekRecipientInfoGenerator();
			kekrig.KekIdentifier = kekIdentifier;
			kekrig.KeyEncryptionKeyOID = keyAlgorithm;
			kekrig.KeyEncryptionKey = key;
			this.recipientInfoGenerators.Add(kekrig);
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x000F42EC File Offset: 0x000F24EC
		public void AddPasswordRecipient(global::Org.BouncyCastle.Cms.CmsPbeKey pbeKey, string kekAlgorithmOid)
		{
			global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params p = new global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params(pbeKey.Salt, pbeKey.IterationCount);
			global::Org.BouncyCastle.Cms.PasswordRecipientInfoGenerator prig = new global::Org.BouncyCastle.Cms.PasswordRecipientInfoGenerator();
			prig.KeyDerivationAlgorithm = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdPbkdf2, p);
			prig.KeyEncryptionKeyOID = kekAlgorithmOid;
			prig.KeyEncryptionKey = pbeKey.GetEncoded(kekAlgorithmOid);
			this.recipientInfoGenerators.Add(prig);
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x000F4344 File Offset: 0x000F2544
		public void AddKeyAgreementRecipient(string agreementAlgorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter senderPrivateKey, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter senderPublicKey, global::Org.BouncyCastle.X509.X509Certificate recipientCert, string cekWrapAlgorithm)
		{
			global::System.Collections.IList recipientCerts = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(1);
			recipientCerts.Add(recipientCert);
			this.AddKeyAgreementRecipients(agreementAlgorithm, senderPrivateKey, senderPublicKey, recipientCerts, cekWrapAlgorithm);
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x000F4370 File Offset: 0x000F2570
		public void AddKeyAgreementRecipients(string agreementAlgorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter senderPrivateKey, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter senderPublicKey, global::System.Collections.ICollection recipientCerts, string cekWrapAlgorithm)
		{
			if (!senderPrivateKey.IsPrivate)
			{
				throw new global::System.ArgumentException("Expected private key", "senderPrivateKey");
			}
			if (senderPublicKey.IsPrivate)
			{
				throw new global::System.ArgumentException("Expected public key", "senderPublicKey");
			}
			global::Org.BouncyCastle.Cms.KeyAgreeRecipientInfoGenerator karig = new global::Org.BouncyCastle.Cms.KeyAgreeRecipientInfoGenerator();
			karig.KeyAgreementOID = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(agreementAlgorithm);
			karig.KeyEncryptionOID = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(cekWrapAlgorithm);
			karig.RecipientCerts = recipientCerts;
			karig.SenderKeyPair = new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(senderPublicKey, senderPrivateKey);
			this.recipientInfoGenerators.Add(karig);
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x000F43EE File Offset: 0x000F25EE
		public void AddRecipientInfoGenerator(global::Org.BouncyCastle.Cms.RecipientInfoGenerator recipientInfoGenerator)
		{
			this.recipientInfoGenerators.Add(recipientInfoGenerator);
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x000F4400 File Offset: 0x000F2600
		protected internal virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetAlgorithmIdentifier(string encryptionOid, global::Org.BouncyCastle.Crypto.Parameters.KeyParameter encKey, global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Params, out global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object asn1Object;
			if (asn1Params != null)
			{
				asn1Object = asn1Params.ToAsn1Object();
				cipherParameters = global::Org.BouncyCastle.Security.ParameterUtilities.GetCipherParameters(encryptionOid, encKey, asn1Object);
			}
			else
			{
				asn1Object = global::Org.BouncyCastle.Asn1.DerNull.Instance;
				cipherParameters = encKey;
			}
			return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(encryptionOid), asn1Object);
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x000F443C File Offset: 0x000F263C
		protected internal virtual global::Org.BouncyCastle.Asn1.Asn1Encodable GenerateAsn1Parameters(string encryptionOid, byte[] encKeyBytes)
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Params = null;
			try
			{
				if (encryptionOid.Equals(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.RC2Cbc))
				{
					byte[] iv = new byte[8];
					this.rand.NextBytes(iv);
					int effKeyBits = encKeyBytes.Length * 8;
					int parameterVersion;
					if (effKeyBits < 256)
					{
						parameterVersion = (int)global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator.rc2Table[effKeyBits];
					}
					else
					{
						parameterVersion = effKeyBits;
					}
					asn1Params = new global::Org.BouncyCastle.Asn1.Pkcs.RC2CbcParameter(parameterVersion, iv);
				}
				else
				{
					asn1Params = global::Org.BouncyCastle.Security.ParameterUtilities.GenerateParameters(encryptionOid, this.rand);
				}
			}
			catch (global::Org.BouncyCastle.Security.SecurityUtilityException)
			{
			}
			return asn1Params;
		}

		// Token: 0x040016C7 RID: 5831
		internal static readonly short[] rc2Table = new short[]
		{
			189,
			86,
			234,
			242,
			162,
			241,
			172,
			42,
			176,
			147,
			209,
			156,
			27,
			51,
			253,
			208,
			48,
			4,
			182,
			220,
			125,
			223,
			50,
			75,
			247,
			203,
			69,
			155,
			49,
			187,
			33,
			90,
			65,
			159,
			225,
			217,
			74,
			77,
			158,
			218,
			160,
			104,
			44,
			195,
			39,
			95,
			128,
			54,
			62,
			238,
			251,
			149,
			26,
			254,
			206,
			168,
			52,
			169,
			19,
			240,
			166,
			63,
			216,
			12,
			120,
			36,
			175,
			35,
			82,
			193,
			103,
			23,
			245,
			102,
			144,
			231,
			232,
			7,
			184,
			96,
			72,
			230,
			30,
			83,
			243,
			146,
			164,
			114,
			140,
			8,
			21,
			110,
			134,
			0,
			132,
			250,
			244,
			127,
			138,
			66,
			25,
			246,
			219,
			205,
			20,
			141,
			80,
			18,
			186,
			60,
			6,
			78,
			236,
			179,
			53,
			17,
			161,
			136,
			142,
			43,
			148,
			153,
			183,
			113,
			116,
			211,
			228,
			191,
			58,
			222,
			150,
			14,
			188,
			10,
			237,
			119,
			252,
			55,
			107,
			3,
			121,
			137,
			98,
			198,
			215,
			192,
			210,
			124,
			106,
			139,
			34,
			163,
			91,
			5,
			93,
			2,
			117,
			213,
			97,
			227,
			24,
			143,
			85,
			81,
			173,
			31,
			11,
			94,
			133,
			229,
			194,
			87,
			99,
			202,
			61,
			108,
			180,
			197,
			204,
			112,
			178,
			145,
			89,
			13,
			71,
			32,
			200,
			79,
			88,
			224,
			1,
			226,
			22,
			56,
			196,
			111,
			59,
			15,
			101,
			70,
			190,
			126,
			45,
			123,
			130,
			249,
			64,
			181,
			29,
			115,
			248,
			235,
			38,
			199,
			135,
			151,
			37,
			84,
			177,
			40,
			170,
			152,
			157,
			165,
			100,
			109,
			122,
			212,
			16,
			129,
			68,
			239,
			73,
			214,
			174,
			46,
			221,
			118,
			92,
			47,
			167,
			28,
			201,
			9,
			105,
			154,
			131,
			207,
			41,
			57,
			185,
			233,
			76,
			255,
			67,
			171
		};

		// Token: 0x040016C8 RID: 5832
		public static readonly string DesEde3Cbc = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc.Id;

		// Token: 0x040016C9 RID: 5833
		public static readonly string RC2Cbc = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc.Id;

		// Token: 0x040016CA RID: 5834
		public const string IdeaCbc = "1.3.6.1.4.1.188.7.1.1.2";

		// Token: 0x040016CB RID: 5835
		public const string Cast5Cbc = "1.2.840.113533.7.66.10";

		// Token: 0x040016CC RID: 5836
		public static readonly string Aes128Cbc = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc.Id;

		// Token: 0x040016CD RID: 5837
		public static readonly string Aes192Cbc = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc.Id;

		// Token: 0x040016CE RID: 5838
		public static readonly string Aes256Cbc = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc.Id;

		// Token: 0x040016CF RID: 5839
		public static readonly string Camellia128Cbc = global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Cbc.Id;

		// Token: 0x040016D0 RID: 5840
		public static readonly string Camellia192Cbc = global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Cbc.Id;

		// Token: 0x040016D1 RID: 5841
		public static readonly string Camellia256Cbc = global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Cbc.Id;

		// Token: 0x040016D2 RID: 5842
		public static readonly string SeedCbc = global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdSeedCbc.Id;

		// Token: 0x040016D3 RID: 5843
		public static readonly string DesEde3Wrap = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgCms3DesWrap.Id;

		// Token: 0x040016D4 RID: 5844
		public static readonly string Aes128Wrap = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Wrap.Id;

		// Token: 0x040016D5 RID: 5845
		public static readonly string Aes192Wrap = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Wrap.Id;

		// Token: 0x040016D6 RID: 5846
		public static readonly string Aes256Wrap = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Wrap.Id;

		// Token: 0x040016D7 RID: 5847
		public static readonly string Camellia128Wrap = global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Wrap.Id;

		// Token: 0x040016D8 RID: 5848
		public static readonly string Camellia192Wrap = global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Wrap.Id;

		// Token: 0x040016D9 RID: 5849
		public static readonly string Camellia256Wrap = global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Wrap.Id;

		// Token: 0x040016DA RID: 5850
		public static readonly string SeedWrap = global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdNpkiAppCmsSeedWrap.Id;

		// Token: 0x040016DB RID: 5851
		public static readonly string ECDHSha1Kdf = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHSinglePassStdDHSha1KdfScheme.Id;

		// Token: 0x040016DC RID: 5852
		public static readonly string ECMqvSha1Kdf = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.MqvSinglePassSha1KdfScheme.Id;

		// Token: 0x040016DD RID: 5853
		internal readonly global::System.Collections.IList recipientInfoGenerators = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040016DE RID: 5854
		internal readonly global::Org.BouncyCastle.Security.SecureRandom rand;

		// Token: 0x040016DF RID: 5855
		internal global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unprotectedAttributeGenerator;
	}
}
