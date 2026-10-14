using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001CE RID: 462
	public sealed class PublicKeyFactory
	{
		// Token: 0x06001143 RID: 4419 RVA: 0x0004ACA9 File Offset: 0x00048EA9
		private PublicKeyFactory()
		{
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0004ACB1 File Offset: 0x00048EB1
		public static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter CreateKey(byte[] keyInfoData)
		{
			return global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(keyInfoData)));
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0004ACC3 File Offset: 0x00048EC3
		public static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter CreateKey(global::System.IO.Stream inStr)
		{
			return global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromStream(inStr)));
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0004ACD8 File Offset: 0x00048ED8
		public static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter CreateKey(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo keyInfo)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID = keyInfo.AlgorithmID;
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier algOid = algID.Algorithm;
			if (algOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption) || algOid.Equals(global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdEARsa) || algOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss) || algOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsaesOaep))
			{
				global::Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure pubKey = global::Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure.GetInstance(keyInfo.ParsePublicKey());
				return new global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(false, pubKey.Modulus, pubKey.PublicExponent);
			}
			if (algOid.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHPublicNumber))
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence seq = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(algID.Parameters.ToAsn1Object());
				global::Org.BouncyCastle.Math.BigInteger y = global::Org.BouncyCastle.Asn1.X9.DHPublicKey.GetInstance(keyInfo.ParsePublicKey()).Y.Value;
				if (global::Org.BouncyCastle.Security.PublicKeyFactory.IsPkcsDHParam(seq))
				{
					return global::Org.BouncyCastle.Security.PublicKeyFactory.ReadPkcsDHParam(algOid, y, seq);
				}
				global::Org.BouncyCastle.Asn1.X9.DHDomainParameters dhParams = global::Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetInstance(seq);
				global::Org.BouncyCastle.Math.BigInteger p = dhParams.P.Value;
				global::Org.BouncyCastle.Math.BigInteger g = dhParams.G.Value;
				global::Org.BouncyCastle.Math.BigInteger q = dhParams.Q.Value;
				global::Org.BouncyCastle.Math.BigInteger i = null;
				if (dhParams.J != null)
				{
					i = dhParams.J.Value;
				}
				global::Org.BouncyCastle.Crypto.Parameters.DHValidationParameters validation = null;
				global::Org.BouncyCastle.Asn1.X9.DHValidationParms dhValidationParms = dhParams.ValidationParms;
				if (dhValidationParms != null)
				{
					byte[] seed = dhValidationParms.Seed.GetBytes();
					global::Org.BouncyCastle.Math.BigInteger pgenCounter = dhValidationParms.PgenCounter.Value;
					validation = new global::Org.BouncyCastle.Crypto.Parameters.DHValidationParameters(seed, pgenCounter.IntValue);
				}
				return new global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(y, new global::Org.BouncyCastle.Crypto.Parameters.DHParameters(p, g, q, i, validation));
			}
			else
			{
				if (algOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DhKeyAgreement))
				{
					global::Org.BouncyCastle.Asn1.Asn1Sequence seq2 = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(algID.Parameters.ToAsn1Object());
					global::Org.BouncyCastle.Asn1.DerInteger derY = (global::Org.BouncyCastle.Asn1.DerInteger)keyInfo.ParsePublicKey();
					return global::Org.BouncyCastle.Security.PublicKeyFactory.ReadPkcsDHParam(algOid, derY.Value, seq2);
				}
				if (algOid.Equals(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.ElGamalAlgorithm))
				{
					global::Org.BouncyCastle.Asn1.Oiw.ElGamalParameter para = new global::Org.BouncyCastle.Asn1.Oiw.ElGamalParameter(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(algID.Parameters.ToAsn1Object()));
					return new global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters(((global::Org.BouncyCastle.Asn1.DerInteger)keyInfo.ParsePublicKey()).Value, new global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters(para.P, para.G));
				}
				if (algOid.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsa) || algOid.Equals(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1))
				{
					global::Org.BouncyCastle.Asn1.DerInteger derInteger = (global::Org.BouncyCastle.Asn1.DerInteger)keyInfo.ParsePublicKey();
					global::Org.BouncyCastle.Asn1.Asn1Encodable ae = algID.Parameters;
					global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters = null;
					if (ae != null)
					{
						global::Org.BouncyCastle.Asn1.X509.DsaParameter para2 = global::Org.BouncyCastle.Asn1.X509.DsaParameter.GetInstance(ae.ToAsn1Object());
						parameters = new global::Org.BouncyCastle.Crypto.Parameters.DsaParameters(para2.P, para2.Q, para2.G);
					}
					return new global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters(derInteger.Value, parameters);
				}
				if (algOid.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdECPublicKey))
				{
					global::Org.BouncyCastle.Asn1.X9.X962Parameters para3 = global::Org.BouncyCastle.Asn1.X9.X962Parameters.GetInstance(algID.Parameters.ToAsn1Object());
					global::Org.BouncyCastle.Asn1.X9.X9ECParameters x9;
					if (para3.IsNamedCurve)
					{
						x9 = global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.FindECCurveByOid((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)para3.Parameters);
					}
					else
					{
						x9 = new global::Org.BouncyCastle.Asn1.X9.X9ECParameters((global::Org.BouncyCastle.Asn1.Asn1Sequence)para3.Parameters);
					}
					global::Org.BouncyCastle.Asn1.Asn1OctetString key = new global::Org.BouncyCastle.Asn1.DerOctetString(keyInfo.PublicKeyData.GetBytes());
					global::Org.BouncyCastle.Math.EC.ECPoint q2 = new global::Org.BouncyCastle.Asn1.X9.X9ECPoint(x9.Curve, key).Point;
					if (para3.IsNamedCurve)
					{
						return new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters("EC", q2, (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)para3.Parameters);
					}
					global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters dParams = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(x9);
					return new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(q2, dParams);
				}
				else if (algOid.Equals(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001))
				{
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet = global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters.GetInstance(algID.Parameters).PublicKeyParamSet;
					global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecP = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.GetByOidX9(publicKeyParamSet);
					if (ecP == null)
					{
						return null;
					}
					global::Org.BouncyCastle.Asn1.Asn1OctetString key2;
					try
					{
						key2 = (global::Org.BouncyCastle.Asn1.Asn1OctetString)keyInfo.ParsePublicKey();
					}
					catch (global::System.IO.IOException e)
					{
						throw new global::System.ArgumentException("error recovering GOST3410_2001 public key", e);
					}
					int fieldSize = 32;
					int keySize = 2 * fieldSize;
					byte[] keyEnc = key2.GetOctets();
					if (keyEnc.Length != keySize)
					{
						throw new global::System.ArgumentException("invalid length for GOST3410_2001 public key");
					}
					byte[] x9Encoding = new byte[1 + keySize];
					x9Encoding[0] = 4;
					for (int j = 1; j <= fieldSize; j++)
					{
						x9Encoding[j] = keyEnc[fieldSize - j];
						x9Encoding[j + fieldSize] = keyEnc[keySize - j];
					}
					global::Org.BouncyCastle.Math.EC.ECPoint q3 = ecP.Curve.DecodePoint(x9Encoding);
					return new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters("ECGOST3410", q3, publicKeyParamSet);
				}
				else
				{
					if (algOid.Equals(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94))
					{
						global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters algParams = global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters.GetInstance(algID.Parameters);
						global::Org.BouncyCastle.Asn1.Asn1OctetString key3;
						try
						{
							key3 = (global::Org.BouncyCastle.Asn1.Asn1OctetString)keyInfo.ParsePublicKey();
						}
						catch (global::System.IO.IOException e2)
						{
							throw new global::System.ArgumentException("error recovering GOST3410_94 public key", e2);
						}
						byte[] keyBytes = global::Org.BouncyCastle.Utilities.Arrays.Reverse(key3.GetOctets());
						return new global::Org.BouncyCastle.Crypto.Parameters.Gost3410PublicKeyParameters(new global::Org.BouncyCastle.Math.BigInteger(1, keyBytes), algParams.PublicKeyParamSet);
					}
					if (algOid.Equals(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X25519))
					{
						return new global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters(global::Org.BouncyCastle.Security.PublicKeyFactory.GetRawKey(keyInfo));
					}
					if (algOid.Equals(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X448))
					{
						return new global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters(global::Org.BouncyCastle.Security.PublicKeyFactory.GetRawKey(keyInfo));
					}
					if (algOid.Equals(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed25519))
					{
						return new global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters(global::Org.BouncyCastle.Security.PublicKeyFactory.GetRawKey(keyInfo));
					}
					if (algOid.Equals(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed448))
					{
						return new global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters(global::Org.BouncyCastle.Security.PublicKeyFactory.GetRawKey(keyInfo));
					}
					if (!algOid.Equals(global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256) && !algOid.Equals(global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512))
					{
						string str = "algorithm identifier in public key not recognised: ";
						global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier = algOid;
						throw new global::Org.BouncyCastle.Security.SecurityUtilityException(str + ((derObjectIdentifier != null) ? derObjectIdentifier.ToString() : null));
					}
					global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters gostParams = global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters.GetInstance(algID.Parameters);
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet2 = gostParams.PublicKeyParamSet;
					global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters ecDomainParameters = new global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters(new global::Org.BouncyCastle.Crypto.Parameters.ECNamedDomainParameters(publicKeyParamSet2, global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.GetByOidX9(publicKeyParamSet2)), publicKeyParamSet2, gostParams.DigestParamSet, gostParams.EncryptionParamSet);
					global::Org.BouncyCastle.Asn1.Asn1OctetString key4;
					try
					{
						key4 = (global::Org.BouncyCastle.Asn1.Asn1OctetString)keyInfo.ParsePublicKey();
					}
					catch (global::System.IO.IOException e3)
					{
						throw new global::System.ArgumentException("error recovering GOST3410_2012 public key", e3);
					}
					int fieldSize2 = 32;
					if (algOid.Equals(global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512))
					{
						fieldSize2 = 64;
					}
					int keySize2 = 2 * fieldSize2;
					byte[] keyEnc2 = key4.GetOctets();
					if (keyEnc2.Length != keySize2)
					{
						throw new global::System.ArgumentException("invalid length for GOST3410_2012 public key");
					}
					byte[] x9Encoding2 = new byte[1 + keySize2];
					x9Encoding2[0] = 4;
					for (int k = 1; k <= fieldSize2; k++)
					{
						x9Encoding2[k] = keyEnc2[fieldSize2 - k];
						x9Encoding2[k + fieldSize2] = keyEnc2[keySize2 - k];
					}
					return new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(ecDomainParameters.Curve.DecodePoint(x9Encoding2), ecDomainParameters);
				}
			}
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0004B2AC File Offset: 0x000494AC
		private static byte[] GetRawKey(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo keyInfo)
		{
			return keyInfo.PublicKeyData.GetOctets();
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0004B2BC File Offset: 0x000494BC
		private static bool IsPkcsDHParam(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count == 2)
			{
				return true;
			}
			if (seq.Count > 3)
			{
				return false;
			}
			global::Org.BouncyCastle.Asn1.DerInteger instance = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[2]);
			global::Org.BouncyCastle.Asn1.DerInteger p = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			return instance.Value.CompareTo(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)p.Value.BitLength)) <= 0;
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0004B31C File Offset: 0x0004951C
		private static global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters ReadPkcsDHParam(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algOid, global::Org.BouncyCastle.Math.BigInteger y, global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::Org.BouncyCastle.Asn1.Pkcs.DHParameter para = new global::Org.BouncyCastle.Asn1.Pkcs.DHParameter(seq);
			global::Org.BouncyCastle.Math.BigInteger lVal = para.L;
			int i = (lVal == null) ? 0 : lVal.IntValue;
			global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams = new global::Org.BouncyCastle.Crypto.Parameters.DHParameters(para.P, para.G, null, i);
			return new global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(y, dhParams, algOid);
		}
	}
}
