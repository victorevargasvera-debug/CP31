using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005BC RID: 1468
	public class PgpSecretKey
	{
		// Token: 0x060036E8 RID: 14056 RVA: 0x00104368 File Offset: 0x00102568
		internal PgpSecretKey(global::Org.BouncyCastle.Bcpg.SecretKeyPacket secret, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pub)
		{
			this.secret = secret;
			this.pub = pub;
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00104380 File Offset: 0x00102580
		internal PgpSecretKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey privKey, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, bool useSha1, global::Org.BouncyCastle.Security.SecureRandom rand, bool isMasterKey)
		{
			this.pub = pubKey;
			global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm = pubKey.Algorithm;
			global::Org.BouncyCastle.Bcpg.BcpgObject secKey;
			if (algorithm - global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral > 2)
			{
				switch (algorithm)
				{
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalEncrypt:
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral:
					secKey = new global::Org.BouncyCastle.Bcpg.ElGamalSecretBcpgKey(((global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters)privKey.Key).X);
					break;
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.Dsa:
					secKey = new global::Org.BouncyCastle.Bcpg.DsaSecretBcpgKey(((global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters)privKey.Key).X);
					break;
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EC:
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ECDsa:
					secKey = new global::Org.BouncyCastle.Bcpg.ECSecretBcpgKey(((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)privKey.Key).D);
					break;
				default:
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown key class");
				}
			}
			else
			{
				global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters rsK = (global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters)privKey.Key;
				secKey = new global::Org.BouncyCastle.Bcpg.RsaSecretBcpgKey(rsK.Exponent, rsK.P, rsK.Q);
			}
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(memoryStream).WriteObject(secKey);
				byte[] keyData = memoryStream.ToArray();
				byte[] checksumData = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.Checksum(useSha1, keyData, keyData.Length);
				keyData = global::Org.BouncyCastle.Utilities.Arrays.Concatenate(keyData, checksumData);
				if (encAlgorithm == global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Null)
				{
					if (isMasterKey)
					{
						this.secret = new global::Org.BouncyCastle.Bcpg.SecretKeyPacket(this.pub.publicPk, encAlgorithm, null, null, keyData);
					}
					else
					{
						this.secret = new global::Org.BouncyCastle.Bcpg.SecretSubkeyPacket(this.pub.publicPk, encAlgorithm, null, null, keyData);
					}
				}
				else
				{
					global::Org.BouncyCastle.Bcpg.S2k s2k;
					byte[] iv;
					byte[] encData;
					if (this.pub.Version >= 4)
					{
						encData = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.EncryptKeyDataV4(keyData, encAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha1, rawPassPhrase, clearPassPhrase, rand, out s2k, out iv);
					}
					else
					{
						encData = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.EncryptKeyDataV3(keyData, encAlgorithm, rawPassPhrase, clearPassPhrase, rand, out s2k, out iv);
					}
					int s2kUsage = useSha1 ? 254 : 255;
					if (isMasterKey)
					{
						this.secret = new global::Org.BouncyCastle.Bcpg.SecretKeyPacket(this.pub.publicPk, encAlgorithm, s2kUsage, s2k, iv, encData);
					}
					else
					{
						this.secret = new global::Org.BouncyCastle.Bcpg.SecretSubkeyPacket(this.pub.publicPk, encAlgorithm, s2kUsage, s2k, iv, encData);
					}
				}
			}
			catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception encrypting key", e);
			}
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00104588 File Offset: 0x00102788
		[global::System.Obsolete("Use the constructor taking an explicit 'useSha1' parameter instead")]
		public PgpSecretKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, keyPair, id, encAlgorithm, passPhrase, false, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x001045AC File Offset: 0x001027AC
		public PgpSecretKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, keyPair, id, encAlgorithm, false, passPhrase, useSha1, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x001045D0 File Offset: 0x001027D0
		public PgpSecretKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, bool utf8PassPhrase, char[] passPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, keyPair, id, encAlgorithm, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, utf8PassPhrase), true, useSha1, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x001045FC File Offset: 0x001027FC
		public PgpSecretKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, keyPair, id, encAlgorithm, rawPassPhrase, false, useSha1, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00104620 File Offset: 0x00102820
		internal PgpSecretKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(keyPair.PrivateKey, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.CertifiedPublicKey(certificationLevel, keyPair, id, hashedPackets, unhashedPackets), encAlgorithm, rawPassPhrase, clearPassPhrase, useSha1, rand, true)
		{
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00104650 File Offset: 0x00102850
		public PgpSecretKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, char[] passPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, keyPair, id, encAlgorithm, hashAlgorithm, false, passPhrase, useSha1, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00104678 File Offset: 0x00102878
		public PgpSecretKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, bool utf8PassPhrase, char[] passPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, keyPair, id, encAlgorithm, hashAlgorithm, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, utf8PassPhrase), true, useSha1, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x001046A4 File Offset: 0x001028A4
		public PgpSecretKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, byte[] rawPassPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, keyPair, id, encAlgorithm, hashAlgorithm, rawPassPhrase, false, useSha1, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x001046CC File Offset: 0x001028CC
		internal PgpSecretKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(keyPair.PrivateKey, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.CertifiedPublicKey(certificationLevel, keyPair, id, hashedPackets, unhashedPackets, hashAlgorithm), encAlgorithm, rawPassPhrase, clearPassPhrase, useSha1, rand, true)
		{
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00104700 File Offset: 0x00102900
		private static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey CertifiedPublicKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, string id, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets)
		{
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator sGen;
			try
			{
				sGen = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator(keyPair.PublicKey.Algorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha1);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Creating signature generator: " + e.Message, e);
			}
			sGen.InitSign(certificationLevel, keyPair.PrivateKey);
			sGen.SetHashedSubpackets(hashedPackets);
			sGen.SetUnhashedSubpackets(unhashedPackets);
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey result;
			try
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature certification = sGen.GenerateCertification(id, keyPair.PublicKey);
				result = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.AddCertification(keyPair.PublicKey, id, certification);
			}
			catch (global::System.Exception e2)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception doing certification: " + e2.Message, e2);
			}
			return result;
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x001047AC File Offset: 0x001029AC
		private static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey CertifiedPublicKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, string id, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm)
		{
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator sGen;
			try
			{
				sGen = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator(keyPair.PublicKey.Algorithm, hashAlgorithm);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Creating signature generator: " + e.Message, e);
			}
			sGen.InitSign(certificationLevel, keyPair.PrivateKey);
			sGen.SetHashedSubpackets(hashedPackets);
			sGen.SetUnhashedSubpackets(unhashedPackets);
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey result;
			try
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature certification = sGen.GenerateCertification(id, keyPair.PublicKey);
				result = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.AddCertification(keyPair.PublicKey, id, certification);
			}
			catch (global::System.Exception e2)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception doing certification: " + e2.Message, e2);
			}
			return result;
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00104858 File Offset: 0x00102A58
		public PgpSecretKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privKey, global::System.DateTime time, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair(algorithm, pubKey, privKey, time), id, encAlgorithm, passPhrase, false, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x00104884 File Offset: 0x00102A84
		public PgpSecretKey(int certificationLevel, global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privKey, global::System.DateTime time, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair(algorithm, pubKey, privKey, time), id, encAlgorithm, passPhrase, useSha1, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x060036F7 RID: 14071 RVA: 0x001048B4 File Offset: 0x00102AB4
		public bool IsSigningKey
		{
			get
			{
				global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm = this.pub.Algorithm;
				if (algorithm != global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral && algorithm != global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaSign)
				{
					switch (algorithm)
					{
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.Dsa:
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ECDsa:
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral:
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EdDsa:
						return true;
					}
					return false;
				}
				return true;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x001048FB File Offset: 0x00102AFB
		public bool IsMasterKey
		{
			get
			{
				return this.pub.IsMasterKey;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060036F9 RID: 14073 RVA: 0x00104908 File Offset: 0x00102B08
		public bool IsPrivateKeyEmpty
		{
			get
			{
				byte[] secKeyData = this.secret.GetSecretKeyData();
				return secKeyData == null || secKeyData.Length < 1;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x0010492C File Offset: 0x00102B2C
		public global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag KeyEncryptionAlgorithm
		{
			get
			{
				return this.secret.EncAlgorithm;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060036FB RID: 14075 RVA: 0x00104939 File Offset: 0x00102B39
		public long KeyId
		{
			get
			{
				return this.pub.KeyId;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x00104946 File Offset: 0x00102B46
		public int S2kUsage
		{
			get
			{
				return this.secret.S2kUsage;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060036FD RID: 14077 RVA: 0x00104953 File Offset: 0x00102B53
		public global::Org.BouncyCastle.Bcpg.S2k S2k
		{
			get
			{
				return this.secret.S2k;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060036FE RID: 14078 RVA: 0x00104960 File Offset: 0x00102B60
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey PublicKey
		{
			get
			{
				return this.pub;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060036FF RID: 14079 RVA: 0x00104968 File Offset: 0x00102B68
		public global::System.Collections.IEnumerable UserIds
		{
			get
			{
				return this.pub.GetUserIds();
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x00104975 File Offset: 0x00102B75
		public global::System.Collections.IEnumerable UserAttributes
		{
			get
			{
				return this.pub.GetUserAttributes();
			}
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x00104984 File Offset: 0x00102B84
		private byte[] ExtractKeyData(byte[] rawPassPhrase, bool clearPassPhrase)
		{
			global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm = this.secret.EncAlgorithm;
			byte[] encData = this.secret.GetSecretKeyData();
			if (encAlgorithm == global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Null)
			{
				return encData;
			}
			byte[] result;
			try
			{
				global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.DoMakeKeyFromPassPhrase(this.secret.EncAlgorithm, this.secret.S2k, rawPassPhrase, clearPassPhrase);
				byte[] iv = this.secret.GetIV();
				byte[] data;
				if (this.secret.PublicKeyPacket.Version >= 4)
				{
					data = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.RecoverKeyData(encAlgorithm, "/CFB/NoPadding", key, iv, encData, 0, encData.Length);
					bool useSha = this.secret.S2kUsage == 254;
					byte[] check = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.Checksum(useSha, data, useSha ? (data.Length - 20) : (data.Length - 2));
					for (int i = 0; i != check.Length; i++)
					{
						if (check[i] != data[data.Length - check.Length + i])
						{
							throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Checksum mismatch at " + i.ToString() + " of " + check.Length.ToString());
						}
					}
				}
				else
				{
					data = new byte[encData.Length];
					iv = global::Org.BouncyCastle.Utilities.Arrays.Clone(iv);
					int pos = 0;
					for (int j = 0; j != 4; j++)
					{
						int encLen = (((int)(encData[pos] & byte.MaxValue) << 8 | (int)(encData[pos + 1] & byte.MaxValue)) + 7) / 8;
						data[pos] = encData[pos];
						data[pos + 1] = encData[pos + 1];
						pos += 2;
						if (encLen > encData.Length - pos)
						{
							throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("out of range encLen found in encData");
						}
						global::System.Array.Copy(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.RecoverKeyData(encAlgorithm, "/CFB/NoPadding", key, iv, encData, pos, encLen), 0, data, pos, encLen);
						pos += encLen;
						if (j != 3)
						{
							global::System.Array.Copy(encData, pos - iv.Length, iv, 0, iv.Length);
						}
					}
					data[pos] = encData[pos];
					data[pos + 1] = encData[pos + 1];
					int cs = ((int)encData[pos] << 8 & 65280) | (int)(encData[pos + 1] & byte.MaxValue);
					int calcCs = 0;
					for (int k = 0; k < pos; k++)
					{
						calcCs += (int)(data[k] & byte.MaxValue);
					}
					calcCs &= 65535;
					if (calcCs != cs)
					{
						throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Checksum mismatch: passphrase wrong, expected " + cs.ToString("X") + " found " + calcCs.ToString("X"));
					}
				}
				result = data;
			}
			catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception decrypting key", e);
			}
			return result;
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x00104C20 File Offset: 0x00102E20
		private static byte[] RecoverKeyData(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, string modeAndPadding, global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key, byte[] iv, byte[] keyData, int keyOff, int keyLen)
		{
			global::Org.BouncyCastle.Crypto.IBufferedCipher c;
			try
			{
				c = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSymmetricCipherName(encAlgorithm) + modeAndPadding);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception creating cipher", e);
			}
			c.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(key, iv));
			return c.DoFinal(keyData, keyOff, keyLen);
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x00104C78 File Offset: 0x00102E78
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey ExtractPrivateKey(char[] passPhrase)
		{
			return this.DoExtractPrivateKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, false), true);
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00104C88 File Offset: 0x00102E88
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey ExtractPrivateKeyUtf8(char[] passPhrase)
		{
			return this.DoExtractPrivateKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, true), true);
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x00104C98 File Offset: 0x00102E98
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey ExtractPrivateKeyRaw(byte[] rawPassPhrase)
		{
			return this.DoExtractPrivateKey(rawPassPhrase, false);
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00104CA4 File Offset: 0x00102EA4
		internal global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey DoExtractPrivateKey(byte[] rawPassPhrase, bool clearPassPhrase)
		{
			if (this.IsPrivateKeyEmpty)
			{
				return null;
			}
			global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubPk = this.secret.PublicKeyPacket;
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey result;
			try
			{
				global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn = global::Org.BouncyCastle.Bcpg.BcpgInputStream.Wrap(new global::System.IO.MemoryStream(this.ExtractKeyData(rawPassPhrase, clearPassPhrase), false));
				global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm = pubPk.Algorithm;
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey;
				if (algorithm - global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral > 2)
				{
					switch (algorithm)
					{
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalEncrypt:
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral:
					{
						global::Org.BouncyCastle.Bcpg.ElGamalPublicBcpgKey elPub = (global::Org.BouncyCastle.Bcpg.ElGamalPublicBcpgKey)pubPk.Key;
						global::Org.BouncyCastle.Bcpg.ElGamalSecretBcpgKey elGamalSecretBcpgKey = new global::Org.BouncyCastle.Bcpg.ElGamalSecretBcpgKey(bcpgIn);
						global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters elParams = new global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters(elPub.P, elPub.G);
						privateKey = new global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters(elGamalSecretBcpgKey.X, elParams);
						break;
					}
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.Dsa:
					{
						global::Org.BouncyCastle.Bcpg.DsaPublicBcpgKey dsaPub = (global::Org.BouncyCastle.Bcpg.DsaPublicBcpgKey)pubPk.Key;
						global::Org.BouncyCastle.Bcpg.DsaSecretBcpgKey dsaSecretBcpgKey = new global::Org.BouncyCastle.Bcpg.DsaSecretBcpgKey(bcpgIn);
						global::Org.BouncyCastle.Crypto.Parameters.DsaParameters dsaParams = new global::Org.BouncyCastle.Crypto.Parameters.DsaParameters(dsaPub.P, dsaPub.Q, dsaPub.G);
						privateKey = new global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters(dsaSecretBcpgKey.X, dsaParams);
						break;
					}
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EC:
						privateKey = this.GetECKey("ECDH", bcpgIn);
						break;
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ECDsa:
						privateKey = this.GetECKey("ECDSA", bcpgIn);
						break;
					default:
						throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown public key algorithm encountered");
					}
				}
				else
				{
					global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey rsaPub = (global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey)pubPk.Key;
					global::Org.BouncyCastle.Bcpg.RsaSecretBcpgKey rsaPriv = new global::Org.BouncyCastle.Bcpg.RsaSecretBcpgKey(bcpgIn);
					privateKey = new global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters(rsaPriv.Modulus, rsaPub.PublicExponent, rsaPriv.PrivateExponent, rsaPriv.PrimeP, rsaPriv.PrimeQ, rsaPriv.PrimeExponentP, rsaPriv.PrimeExponentQ, rsaPriv.CrtCoefficient);
				}
				result = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey(this.KeyId, pubPk, privateKey);
			}
			catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception constructing key", e);
			}
			return result;
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x00104E58 File Offset: 0x00103058
		private global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters GetECKey(string algorithm, global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			global::Org.BouncyCastle.Bcpg.ECPublicBcpgKey ecdsaPub = (global::Org.BouncyCastle.Bcpg.ECPublicBcpgKey)this.secret.PublicKeyPacket.Key;
			global::Org.BouncyCastle.Bcpg.ECSecretBcpgKey ecdsaPriv = new global::Org.BouncyCastle.Bcpg.ECSecretBcpgKey(bcpgIn);
			return new global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters(algorithm, ecdsaPriv.X, ecdsaPub.CurveOid);
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x00104E94 File Offset: 0x00103094
		private static byte[] Checksum(bool useSha1, byte[] bytes, int length)
		{
			if (useSha1)
			{
				try
				{
					global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest("SHA1");
					digest.BlockUpdate(bytes, 0, length);
					return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
				}
				catch (global::System.Exception e)
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Can't find SHA-1", e);
				}
			}
			int Checksum = 0;
			for (int i = 0; i != length; i++)
			{
				Checksum += (int)bytes[i];
			}
			return new byte[]
			{
				(byte)(Checksum >> 8),
				(byte)Checksum
			};
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x00104F04 File Offset: 0x00103104
		public byte[] GetEncoded()
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			this.Encode(bOut);
			return bOut.ToArray();
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x00104F24 File Offset: 0x00103124
		public void Encode(global::System.IO.Stream outStr)
		{
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut = global::Org.BouncyCastle.Bcpg.BcpgOutputStream.Wrap(outStr);
			bcpgOut.WritePacket(this.secret);
			if (this.pub.trustPk != null)
			{
				bcpgOut.WritePacket(this.pub.trustPk);
			}
			if (this.pub.subSigs == null)
			{
				foreach (object obj in this.pub.keySigs)
				{
					((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature)obj).Encode(bcpgOut);
				}
				for (int i = 0; i != this.pub.ids.Count; i++)
				{
					object pubID = this.pub.ids[i];
					if (pubID is string)
					{
						string id = (string)pubID;
						bcpgOut.WritePacket(new global::Org.BouncyCastle.Bcpg.UserIdPacket(id));
					}
					else
					{
						global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector v = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector)pubID;
						bcpgOut.WritePacket(new global::Org.BouncyCastle.Bcpg.UserAttributePacket(v.ToSubpacketArray()));
					}
					if (this.pub.idTrusts[i] != null)
					{
						bcpgOut.WritePacket((global::Org.BouncyCastle.Bcpg.ContainedPacket)this.pub.idTrusts[i]);
					}
					foreach (object obj2 in ((global::System.Collections.IList)this.pub.idSigs[i]))
					{
						((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature)obj2).Encode(bcpgOut);
					}
				}
				return;
			}
			foreach (object obj3 in this.pub.subSigs)
			{
				((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature)obj3).Encode(bcpgOut);
			}
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x00105104 File Offset: 0x00103304
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey CopyWithNewPassword(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey key, char[] oldPassPhrase, char[] newPassPhrase, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag newEncAlgorithm, global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.DoCopyWithNewPassword(key, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(oldPassPhrase, false), global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(newPassPhrase, false), true, newEncAlgorithm, rand);
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x0010511E File Offset: 0x0010331E
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey CopyWithNewPasswordUtf8(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey key, char[] oldPassPhrase, char[] newPassPhrase, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag newEncAlgorithm, global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.DoCopyWithNewPassword(key, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(oldPassPhrase, true), global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(newPassPhrase, true), true, newEncAlgorithm, rand);
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00105138 File Offset: 0x00103338
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey CopyWithNewPasswordRaw(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey key, byte[] rawOldPassPhrase, byte[] rawNewPassPhrase, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag newEncAlgorithm, global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.DoCopyWithNewPassword(key, rawOldPassPhrase, rawNewPassPhrase, false, newEncAlgorithm, rand);
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00105148 File Offset: 0x00103348
		internal static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey DoCopyWithNewPassword(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey key, byte[] rawOldPassPhrase, byte[] rawNewPassPhrase, bool clearPassPhrase, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag newEncAlgorithm, global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			if (key.IsPrivateKeyEmpty)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("no private key in this SecretKey - public key present only.");
			}
			byte[] rawKeyData = key.ExtractKeyData(rawOldPassPhrase, clearPassPhrase);
			int s2kUsage = key.secret.S2kUsage;
			byte[] iv = null;
			global::Org.BouncyCastle.Bcpg.S2k s2k = null;
			global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubKeyPacket = key.secret.PublicKeyPacket;
			byte[] keyData;
			if (newEncAlgorithm == global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Null)
			{
				s2kUsage = 0;
				if (key.secret.S2kUsage == 254)
				{
					keyData = new byte[rawKeyData.Length - 18];
					global::System.Array.Copy(rawKeyData, 0, keyData, 0, keyData.Length - 2);
					byte[] check = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.Checksum(false, keyData, keyData.Length - 2);
					keyData[keyData.Length - 2] = check[0];
					keyData[keyData.Length - 1] = check[1];
				}
				else
				{
					keyData = rawKeyData;
				}
			}
			else
			{
				if (s2kUsage == 0)
				{
					s2kUsage = 255;
				}
				try
				{
					if (pubKeyPacket.Version >= 4)
					{
						keyData = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.EncryptKeyDataV4(rawKeyData, newEncAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha1, rawNewPassPhrase, clearPassPhrase, rand, out s2k, out iv);
					}
					else
					{
						keyData = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.EncryptKeyDataV3(rawKeyData, newEncAlgorithm, rawNewPassPhrase, clearPassPhrase, rand, out s2k, out iv);
					}
				}
				catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex)
				{
					throw ex;
				}
				catch (global::System.Exception e)
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception encrypting key", e);
				}
			}
			global::Org.BouncyCastle.Bcpg.SecretKeyPacket secret;
			if (key.secret is global::Org.BouncyCastle.Bcpg.SecretSubkeyPacket)
			{
				secret = new global::Org.BouncyCastle.Bcpg.SecretSubkeyPacket(pubKeyPacket, newEncAlgorithm, s2kUsage, s2k, iv, keyData);
			}
			else
			{
				secret = new global::Org.BouncyCastle.Bcpg.SecretKeyPacket(pubKeyPacket, newEncAlgorithm, s2kUsage, s2k, iv, keyData);
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey(secret, key.pub);
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x0010529C File Offset: 0x0010349C
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey ReplacePublicKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey secretKey, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey publicKey)
		{
			if (publicKey.KeyId != secretKey.KeyId)
			{
				throw new global::System.ArgumentException("KeyId's do not match");
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey(secretKey.secret, publicKey);
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x001052C4 File Offset: 0x001034C4
		private static byte[] EncryptKeyDataV3(byte[] rawKeyData, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, global::Org.BouncyCastle.Security.SecureRandom random, out global::Org.BouncyCastle.Bcpg.S2k s2k, out byte[] iv)
		{
			s2k = null;
			iv = null;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter encKey = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.DoMakeKeyFromPassPhrase(encAlgorithm, s2k, rawPassPhrase, clearPassPhrase);
			byte[] keyData = new byte[rawKeyData.Length];
			int pos = 0;
			for (int i = 0; i != 4; i++)
			{
				int encLen = (((int)(rawKeyData[pos] & byte.MaxValue) << 8 | (int)(rawKeyData[pos + 1] & byte.MaxValue)) + 7) / 8;
				keyData[pos] = rawKeyData[pos];
				keyData[pos + 1] = rawKeyData[pos + 1];
				if (encLen > rawKeyData.Length - (pos + 2))
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("out of range encLen found in rawKeyData");
				}
				byte[] tmp;
				if (i == 0)
				{
					tmp = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.EncryptData(encAlgorithm, encKey, rawKeyData, pos + 2, encLen, random, ref iv);
				}
				else
				{
					byte[] tmpIv = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(keyData, pos - iv.Length, pos);
					tmp = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.EncryptData(encAlgorithm, encKey, rawKeyData, pos + 2, encLen, random, ref tmpIv);
				}
				global::System.Array.Copy(tmp, 0, keyData, pos + 2, tmp.Length);
				pos += 2 + encLen;
			}
			keyData[pos] = rawKeyData[pos];
			keyData[pos + 1] = rawKeyData[pos + 1];
			return keyData;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x001053A8 File Offset: 0x001035A8
		private static byte[] EncryptKeyDataV4(byte[] rawKeyData, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, global::Org.BouncyCastle.Security.SecureRandom random, out global::Org.BouncyCastle.Bcpg.S2k s2k, out byte[] iv)
		{
			s2k = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GenerateS2k(hashAlgorithm, 96, random);
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.DoMakeKeyFromPassPhrase(encAlgorithm, s2k, rawPassPhrase, clearPassPhrase);
			iv = null;
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.EncryptData(encAlgorithm, key, rawKeyData, 0, rawKeyData.Length, random, ref iv);
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x001053E4 File Offset: 0x001035E4
		private static byte[] EncryptData(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key, byte[] data, int dataOff, int dataLen, global::Org.BouncyCastle.Security.SecureRandom random, ref byte[] iv)
		{
			global::Org.BouncyCastle.Crypto.IBufferedCipher c;
			try
			{
				c = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSymmetricCipherName(encAlgorithm) + "/CFB/NoPadding");
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception creating cipher", e);
			}
			if (iv == null)
			{
				iv = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GenerateIV(c.GetBlockSize(), random);
			}
			c.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(key, iv), random));
			return c.DoFinal(data, dataOff, dataLen);
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x0010545C File Offset: 0x0010365C
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey ParseSecretKeyFromSExpr(global::System.IO.Stream inputStream, char[] passPhrase, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.DoParseSecretKeyFromSExpr(inputStream, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, false), true, pubKey);
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x0010546D File Offset: 0x0010366D
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey ParseSecretKeyFromSExprUtf8(global::System.IO.Stream inputStream, char[] passPhrase, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.DoParseSecretKeyFromSExpr(inputStream, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, true), true, pubKey);
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x0010547E File Offset: 0x0010367E
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey ParseSecretKeyFromSExprRaw(global::System.IO.Stream inputStream, byte[] rawPassPhrase, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.DoParseSecretKeyFromSExpr(inputStream, rawPassPhrase, false, pubKey);
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x0010548C File Offset: 0x0010368C
		internal static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey DoParseSecretKeyFromSExpr(global::System.IO.Stream inputStream, byte[] rawPassPhrase, bool clearPassPhrase, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(inputStream);
			if (!global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("protected-private-key"))
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown key type found");
			}
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(inputStream);
			if (!global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("ecc"))
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("no curve details found");
			}
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(inputStream);
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte());
			string curveName = global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte());
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipCloseParenthesis(inputStream);
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(inputStream);
			if (global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("q"))
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadBytes(inputStream, inputStream.ReadByte());
				global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipCloseParenthesis(inputStream);
				byte[] dValue = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.GetDValue(inputStream, rawPassPhrase, clearPassPhrase, curveName);
				return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey(new global::Org.BouncyCastle.Bcpg.SecretKeyPacket(pubKey.PublicKeyPacket, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Null, null, null, new global::Org.BouncyCastle.Bcpg.ECSecretBcpgKey(new global::Org.BouncyCastle.Math.BigInteger(1, dValue)).GetEncoded()), pubKey);
			}
			throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("no q value found");
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00105583 File Offset: 0x00103783
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey ParseSecretKeyFromSExpr(global::System.IO.Stream inputStream, char[] passPhrase)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.DoParseSecretKeyFromSExpr(inputStream, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, false), true);
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00105593 File Offset: 0x00103793
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey ParseSecretKeyFromSExprUtf8(global::System.IO.Stream inputStream, char[] passPhrase)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.DoParseSecretKeyFromSExpr(inputStream, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, true), true);
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x001055A3 File Offset: 0x001037A3
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey ParseSecretKeyFromSExprRaw(global::System.IO.Stream inputStream, byte[] rawPassPhrase)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.DoParseSecretKeyFromSExpr(inputStream, rawPassPhrase, false);
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x001055B0 File Offset: 0x001037B0
		internal static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey DoParseSecretKeyFromSExpr(global::System.IO.Stream inputStream, byte[] rawPassPhrase, bool clearPassPhrase)
		{
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(inputStream);
			if (!global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("protected-private-key"))
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown key type found");
			}
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(inputStream);
			if (!global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("ecc"))
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("no curve details found");
			}
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(inputStream);
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte());
			string curveName = global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte());
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(curveName, "NIST "))
			{
				curveName = curveName.Substring("NIST ".Length);
			}
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipCloseParenthesis(inputStream);
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(inputStream);
			if (global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("q"))
			{
				byte[] qVal = global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadBytes(inputStream, inputStream.ReadByte());
				global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubPacket = new global::Org.BouncyCastle.Bcpg.PublicKeyPacket(global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ECDsa, global::System.DateTime.UtcNow, new global::Org.BouncyCastle.Bcpg.ECDsaPublicBcpgKey(global::Org.BouncyCastle.Asn1.X9.ECNamedCurveTable.GetOid(curveName), new global::Org.BouncyCastle.Math.BigInteger(1, qVal)));
				global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipCloseParenthesis(inputStream);
				byte[] dValue = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.GetDValue(inputStream, rawPassPhrase, clearPassPhrase, curveName);
				return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey(new global::Org.BouncyCastle.Bcpg.SecretKeyPacket(pubPacket, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Null, null, null, new global::Org.BouncyCastle.Bcpg.ECSecretBcpgKey(new global::Org.BouncyCastle.Math.BigInteger(1, dValue)).GetEncoded()), new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(pubPacket));
			}
			throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("no q value found");
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x001056E4 File Offset: 0x001038E4
		private static byte[] GetDValue(global::System.IO.Stream inputStream, byte[] rawPassPhrase, bool clearPassPhrase, string curveName)
		{
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(inputStream);
			if (global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("protected"))
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(inputStream, inputStream.ReadByte());
				global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(inputStream);
				global::Org.BouncyCastle.Bcpg.S2k s2k = global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ParseS2k(inputStream);
				byte[] iv = global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadBytes(inputStream, inputStream.ReadByte());
				global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipCloseParenthesis(inputStream);
				byte[] secKeyData = global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadBytes(inputStream, inputStream.ReadByte());
				global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.DoMakeKeyFromPassPhrase(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes128, s2k, rawPassPhrase, clearPassPhrase);
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.RecoverKeyData(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes128, "/CBC/NoPadding", key, iv, secKeyData, 0, secKeyData.Length), false);
				global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(memoryStream);
				global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(memoryStream);
				global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(memoryStream);
				global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(memoryStream, memoryStream.ReadByte());
				return global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadBytes(memoryStream, memoryStream.ReadByte());
			}
			throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("protected block not found");
		}

		// Token: 0x040018E9 RID: 6377
		private readonly global::Org.BouncyCastle.Bcpg.SecretKeyPacket secret;

		// Token: 0x040018EA RID: 6378
		private readonly global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pub;
	}
}
