using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001CD RID: 461
	public sealed class PrivateKeyFactory
	{
		// Token: 0x06001138 RID: 4408 RVA: 0x0004A636 File Offset: 0x00048836
		private PrivateKeyFactory()
		{
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0004A63E File Offset: 0x0004883E
		public static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter CreateKey(byte[] privateKeyInfoData)
		{
			return global::Org.BouncyCastle.Security.PrivateKeyFactory.CreateKey(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(privateKeyInfoData)));
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0004A650 File Offset: 0x00048850
		public static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter CreateKey(global::System.IO.Stream inStr)
		{
			return global::Org.BouncyCastle.Security.PrivateKeyFactory.CreateKey(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromStream(inStr)));
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0004A664 File Offset: 0x00048864
		public static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter CreateKey(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo keyInfo)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID = keyInfo.PrivateKeyAlgorithm;
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier algOid = algID.Algorithm;
			if (algOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption) || algOid.Equals(global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdEARsa) || algOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss) || algOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsaesOaep))
			{
				global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure keyStructure = global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure.GetInstance(keyInfo.ParsePrivateKey());
				return new global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters(keyStructure.Modulus, keyStructure.PublicExponent, keyStructure.PrivateExponent, keyStructure.Prime1, keyStructure.Prime2, keyStructure.Exponent1, keyStructure.Exponent2, keyStructure.Coefficient);
			}
			if (algOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DhKeyAgreement))
			{
				global::Org.BouncyCastle.Asn1.Pkcs.DHParameter para = new global::Org.BouncyCastle.Asn1.Pkcs.DHParameter(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(algID.Parameters.ToAsn1Object()));
				global::Org.BouncyCastle.Asn1.DerInteger derInteger = (global::Org.BouncyCastle.Asn1.DerInteger)keyInfo.ParsePrivateKey();
				global::Org.BouncyCastle.Math.BigInteger lVal = para.L;
				int i = (lVal == null) ? 0 : lVal.IntValue;
				global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams = new global::Org.BouncyCastle.Crypto.Parameters.DHParameters(para.P, para.G, null, i);
				return new global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters(derInteger.Value, dhParams, algOid);
			}
			if (algOid.Equals(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.ElGamalAlgorithm))
			{
				global::Org.BouncyCastle.Asn1.Oiw.ElGamalParameter para2 = new global::Org.BouncyCastle.Asn1.Oiw.ElGamalParameter(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(algID.Parameters.ToAsn1Object()));
				return new global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters(((global::Org.BouncyCastle.Asn1.DerInteger)keyInfo.ParsePrivateKey()).Value, new global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters(para2.P, para2.G));
			}
			if (algOid.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsa))
			{
				global::Org.BouncyCastle.Asn1.DerInteger derInteger2 = (global::Org.BouncyCastle.Asn1.DerInteger)keyInfo.ParsePrivateKey();
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = algID.Parameters;
				global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters = null;
				if (ae != null)
				{
					global::Org.BouncyCastle.Asn1.X509.DsaParameter para3 = global::Org.BouncyCastle.Asn1.X509.DsaParameter.GetInstance(ae.ToAsn1Object());
					parameters = new global::Org.BouncyCastle.Crypto.Parameters.DsaParameters(para3.P, para3.Q, para3.G);
				}
				return new global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters(derInteger2.Value, parameters);
			}
			if (algOid.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdECPublicKey))
			{
				global::Org.BouncyCastle.Asn1.X9.X962Parameters para4 = global::Org.BouncyCastle.Asn1.X9.X962Parameters.GetInstance(algID.Parameters.ToAsn1Object());
				global::Org.BouncyCastle.Asn1.X9.X9ECParameters x9;
				if (para4.IsNamedCurve)
				{
					x9 = global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.FindECCurveByOid((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)para4.Parameters);
				}
				else
				{
					x9 = new global::Org.BouncyCastle.Asn1.X9.X9ECParameters((global::Org.BouncyCastle.Asn1.Asn1Sequence)para4.Parameters);
				}
				global::Org.BouncyCastle.Math.BigInteger d = global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure.GetInstance(keyInfo.ParsePrivateKey()).GetKey();
				if (para4.IsNamedCurve)
				{
					return new global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters("EC", d, (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)para4.Parameters);
				}
				global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters dParams = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(x9.Curve, x9.G, x9.N, x9.H, x9.GetSeed());
				return new global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters(d, dParams);
			}
			else if (algOid.Equals(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001))
			{
				global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters gostParams = global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters.GetInstance(algID.Parameters.ToAsn1Object());
				global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecP = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.GetByOidX9(gostParams.PublicKeyParamSet);
				if (ecP == null)
				{
					throw new global::System.ArgumentException("Unrecognized curve OID for GostR3410x2001 private key");
				}
				global::Org.BouncyCastle.Asn1.Asn1Object privKey = keyInfo.ParsePrivateKey();
				global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure ec;
				if (privKey is global::Org.BouncyCastle.Asn1.DerInteger)
				{
					ec = new global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure(ecP.N.BitLength, ((global::Org.BouncyCastle.Asn1.DerInteger)privKey).PositiveValue);
				}
				else
				{
					ec = global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure.GetInstance(privKey);
				}
				return new global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters("ECGOST3410", ec.GetKey(), gostParams.PublicKeyParamSet);
			}
			else
			{
				if (algOid.Equals(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94))
				{
					global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters gostParams2 = global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters.GetInstance(algID.Parameters);
					global::Org.BouncyCastle.Asn1.Asn1Object privKey2 = keyInfo.ParsePrivateKey();
					global::Org.BouncyCastle.Math.BigInteger x10;
					if (privKey2 is global::Org.BouncyCastle.Asn1.DerInteger)
					{
						x10 = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(privKey2).PositiveValue;
					}
					else
					{
						x10 = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Arrays.Reverse(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(privKey2).GetOctets()));
					}
					return new global::Org.BouncyCastle.Crypto.Parameters.Gost3410PrivateKeyParameters(x10, gostParams2.PublicKeyParamSet);
				}
				if (algOid.Equals(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X25519))
				{
					return new global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters(global::Org.BouncyCastle.Security.PrivateKeyFactory.GetRawKey(keyInfo));
				}
				if (algOid.Equals(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X448))
				{
					return new global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters(global::Org.BouncyCastle.Security.PrivateKeyFactory.GetRawKey(keyInfo));
				}
				if (algOid.Equals(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed25519))
				{
					return new global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters(global::Org.BouncyCastle.Security.PrivateKeyFactory.GetRawKey(keyInfo));
				}
				if (algOid.Equals(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed448))
				{
					return new global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters(global::Org.BouncyCastle.Security.PrivateKeyFactory.GetRawKey(keyInfo));
				}
				if (algOid.Equals(global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512) || algOid.Equals(global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256))
				{
					global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters gostParams3 = global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters.GetInstance(keyInfo.PrivateKeyAlgorithm.Parameters);
					global::Org.BouncyCastle.Asn1.Asn1Object p = keyInfo.PrivateKeyAlgorithm.Parameters.ToAsn1Object();
					global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters ecSpec;
					global::Org.BouncyCastle.Math.BigInteger d2;
					if (p is global::Org.BouncyCastle.Asn1.Asn1Sequence && (global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(p).Count == 2 || global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(p).Count == 3))
					{
						global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecP2 = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.GetByOidX9(gostParams3.PublicKeyParamSet);
						ecSpec = new global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters(new global::Org.BouncyCastle.Crypto.Parameters.ECNamedDomainParameters(gostParams3.PublicKeyParamSet, ecP2), gostParams3.PublicKeyParamSet, gostParams3.DigestParamSet, gostParams3.EncryptionParamSet);
						global::Org.BouncyCastle.Asn1.Asn1OctetString privEnc = keyInfo.PrivateKeyData;
						if (privEnc.GetOctets().Length == 32 || privEnc.GetOctets().Length == 64)
						{
							byte[] dVal = global::Org.BouncyCastle.Utilities.Arrays.Reverse(privEnc.GetOctets());
							d2 = new global::Org.BouncyCastle.Math.BigInteger(1, dVal);
						}
						else
						{
							global::Org.BouncyCastle.Asn1.Asn1Encodable privKey3 = keyInfo.ParsePrivateKey();
							if (privKey3 is global::Org.BouncyCastle.Asn1.DerInteger)
							{
								d2 = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(privKey3).PositiveValue;
							}
							else
							{
								byte[] dVal2 = global::Org.BouncyCastle.Utilities.Arrays.Reverse(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(privKey3).GetOctets());
								d2 = new global::Org.BouncyCastle.Math.BigInteger(1, dVal2);
							}
						}
					}
					else
					{
						global::Org.BouncyCastle.Asn1.X9.X962Parameters parameters2 = global::Org.BouncyCastle.Asn1.X9.X962Parameters.GetInstance(keyInfo.PrivateKeyAlgorithm.Parameters);
						if (parameters2.IsNamedCurve)
						{
							global::Org.BouncyCastle.Asn1.DerObjectIdentifier instance = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(parameters2.Parameters);
							global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecP3 = global::Org.BouncyCastle.Asn1.X9.ECNamedCurveTable.GetByOid(instance);
							ecSpec = new global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters(new global::Org.BouncyCastle.Crypto.Parameters.ECNamedDomainParameters(instance, ecP3), gostParams3.PublicKeyParamSet, gostParams3.DigestParamSet, gostParams3.EncryptionParamSet);
						}
						else if (parameters2.IsImplicitlyCA)
						{
							ecSpec = null;
						}
						else
						{
							global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecP4 = global::Org.BouncyCastle.Asn1.X9.X9ECParameters.GetInstance(parameters2.Parameters);
							ecSpec = new global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters(new global::Org.BouncyCastle.Crypto.Parameters.ECNamedDomainParameters(algOid, ecP4), gostParams3.PublicKeyParamSet, gostParams3.DigestParamSet, gostParams3.EncryptionParamSet);
						}
						global::Org.BouncyCastle.Asn1.Asn1Encodable privKey4 = keyInfo.ParsePrivateKey();
						if (privKey4 is global::Org.BouncyCastle.Asn1.DerInteger)
						{
							d2 = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(privKey4).Value;
						}
						else
						{
							d2 = global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure.GetInstance(privKey4).GetKey();
						}
					}
					return new global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters(d2, new global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters(ecSpec, gostParams3.PublicKeyParamSet, gostParams3.DigestParamSet, gostParams3.EncryptionParamSet));
				}
				throw new global::Org.BouncyCastle.Security.SecurityUtilityException("algorithm identifier in private key not recognised");
			}
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0004AC3B File Offset: 0x00048E3B
		private static byte[] GetRawKey(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo keyInfo)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(keyInfo.ParsePrivateKey()).GetOctets();
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0004AC4D File Offset: 0x00048E4D
		public static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter DecryptKey(char[] passPhrase, global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo encInfo)
		{
			return global::Org.BouncyCastle.Security.PrivateKeyFactory.CreateKey(global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.CreatePrivateKeyInfo(passPhrase, encInfo));
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0004AC5B File Offset: 0x00048E5B
		public static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter DecryptKey(char[] passPhrase, byte[] encryptedPrivateKeyInfoData)
		{
			return global::Org.BouncyCastle.Security.PrivateKeyFactory.DecryptKey(passPhrase, global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(encryptedPrivateKeyInfoData));
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0004AC69 File Offset: 0x00048E69
		public static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter DecryptKey(char[] passPhrase, global::System.IO.Stream encryptedPrivateKeyInfoStream)
		{
			return global::Org.BouncyCastle.Security.PrivateKeyFactory.DecryptKey(passPhrase, global::Org.BouncyCastle.Asn1.Asn1Object.FromStream(encryptedPrivateKeyInfoStream));
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0004AC77 File Offset: 0x00048E77
		private static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter DecryptKey(char[] passPhrase, global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			return global::Org.BouncyCastle.Security.PrivateKeyFactory.DecryptKey(passPhrase, global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo.GetInstance(asn1Object));
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0004AC85 File Offset: 0x00048E85
		public static byte[] EncryptKey(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, char[] passPhrase, byte[] salt, int iterationCount, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key)
		{
			return global::Org.BouncyCastle.Pkcs.EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(algorithm, passPhrase, salt, iterationCount, key).GetEncoded();
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0004AC97 File Offset: 0x00048E97
		public static byte[] EncryptKey(string algorithm, char[] passPhrase, byte[] salt, int iterationCount, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key)
		{
			return global::Org.BouncyCastle.Pkcs.EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(algorithm, passPhrase, salt, iterationCount, key).GetEncoded();
		}
	}
}
