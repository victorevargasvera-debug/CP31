using System;
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
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001B5 RID: 437
	public sealed class PrivateKeyInfoFactory
	{
		// Token: 0x0600107D RID: 4221 RVA: 0x00042C0E File Offset: 0x00040E0E
		private PrivateKeyInfoFactory()
		{
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00042C16 File Offset: 0x00040E16
		public static global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo CreatePrivateKeyInfo(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			return global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.CreatePrivateKeyInfo(privateKey, null);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00042C20 File Offset: 0x00040E20
		public static global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo CreatePrivateKeyInfo(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Asn1.Asn1Set attributes)
		{
			if (privateKey == null)
			{
				throw new global::System.ArgumentNullException("privateKey");
			}
			if (!privateKey.IsPrivate)
			{
				throw new global::System.ArgumentException("Public key passed - private key expected", "privateKey");
			}
			if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters _key = (global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters)privateKey;
				global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters egp = _key.Parameters;
				return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.ElGamalAlgorithm, new global::Org.BouncyCastle.Asn1.Oiw.ElGamalParameter(egp.P, egp.G).ToAsn1Object()), new global::Org.BouncyCastle.Asn1.DerInteger(_key.X), attributes);
			}
			if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters _key2 = (global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters)privateKey;
				global::Org.BouncyCastle.Crypto.Parameters.DsaParameters dp = _key2.Parameters;
				return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsa, new global::Org.BouncyCastle.Asn1.X509.DsaParameter(dp.P, dp.Q, dp.G).ToAsn1Object()), new global::Org.BouncyCastle.Asn1.DerInteger(_key2.X), attributes);
			}
			if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters _key3 = (global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)privateKey;
				global::Org.BouncyCastle.Asn1.Pkcs.DHParameter p = new global::Org.BouncyCastle.Asn1.Pkcs.DHParameter(_key3.Parameters.P, _key3.Parameters.G, _key3.Parameters.L);
				return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(_key3.AlgorithmOid, p.ToAsn1Object()), new global::Org.BouncyCastle.Asn1.DerInteger(_key3.X), attributes);
			}
			if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)
			{
				global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier privateKeyAlgorithm = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption, global::Org.BouncyCastle.Asn1.DerNull.Instance);
				global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure keyStruct;
				if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters)
				{
					global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters _key4 = (global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters)privateKey;
					keyStruct = new global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure(_key4.Modulus, _key4.PublicExponent, _key4.Exponent, _key4.P, _key4.Q, _key4.DP, _key4.DQ, _key4.QInv);
				}
				else
				{
					global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters _key5 = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)privateKey;
					keyStruct = new global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure(_key5.Modulus, global::Org.BouncyCastle.Math.BigInteger.Zero, _key5.Exponent, global::Org.BouncyCastle.Math.BigInteger.Zero, global::Org.BouncyCastle.Math.BigInteger.Zero, global::Org.BouncyCastle.Math.BigInteger.Zero, global::Org.BouncyCastle.Math.BigInteger.Zero, global::Org.BouncyCastle.Math.BigInteger.Zero);
				}
				return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(privateKeyAlgorithm, keyStruct.ToAsn1Object(), attributes);
			}
			if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters priv = (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)privateKey;
				global::Org.BouncyCastle.Asn1.DerBitString publicKey = new global::Org.BouncyCastle.Asn1.DerBitString(global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.GetCorrespondingPublicKey(priv).Q.GetEncoded(false));
				global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters dp2 = priv.Parameters;
				if (dp2 is global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters)
				{
					global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters domainParameters = (global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters)dp2;
					global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters gostParams = new global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters(domainParameters.PublicKeyParamSet, domainParameters.DigestParamSet, domainParameters.EncryptionParamSet);
					bool flag = priv.D.BitLength > 256;
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier identifier = flag ? global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512 : global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256;
					int size = flag ? 64 : 32;
					byte[] encKey = new byte[size];
					global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.ExtractBytes(encKey, size, 0, priv.D);
					return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(identifier, gostParams), new global::Org.BouncyCastle.Asn1.DerOctetString(encKey));
				}
				int orderBitLength = dp2.N.BitLength;
				global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID;
				global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure ec;
				if (priv.AlgorithmName == "ECGOST3410")
				{
					if (priv.PublicKeyParamSet == null)
					{
						throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("Not a CryptoPro parameter set");
					}
					global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters gostParams2 = new global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters(priv.PublicKeyParamSet, global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94CryptoProParamSet);
					algID = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001, gostParams2);
					ec = new global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure(orderBitLength, priv.D, publicKey, null);
				}
				else
				{
					global::Org.BouncyCastle.Asn1.X9.X962Parameters x962;
					if (priv.PublicKeyParamSet == null)
					{
						x962 = new global::Org.BouncyCastle.Asn1.X9.X962Parameters(new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(dp2.Curve, dp2.G, dp2.N, dp2.H, dp2.GetSeed()));
					}
					else
					{
						x962 = new global::Org.BouncyCastle.Asn1.X9.X962Parameters(priv.PublicKeyParamSet);
					}
					ec = new global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure(orderBitLength, priv.D, publicKey, x962);
					algID = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdECPublicKey, x962);
				}
				return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(algID, ec, attributes);
			}
			else if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.Gost3410PrivateKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.Gost3410PrivateKeyParameters _key6 = (global::Org.BouncyCastle.Crypto.Parameters.Gost3410PrivateKeyParameters)privateKey;
				if (_key6.PublicKeyParamSet == null)
				{
					throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("Not a CryptoPro parameter set");
				}
				byte[] keyEnc = _key6.X.ToByteArrayUnsigned();
				byte[] keyBytes = new byte[keyEnc.Length];
				for (int i = 0; i != keyBytes.Length; i++)
				{
					keyBytes[i] = keyEnc[keyEnc.Length - 1 - i];
				}
				global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters algParams = new global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters(_key6.PublicKeyParamSet, global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94CryptoProParamSet, null);
				return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94, algParams.ToAsn1Object()), new global::Org.BouncyCastle.Asn1.DerOctetString(keyBytes), attributes);
			}
			else
			{
				if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters)
				{
					global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters key = (global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters)privateKey;
					return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X448), new global::Org.BouncyCastle.Asn1.DerOctetString(key.GetEncoded()), attributes, key.GeneratePublicKey().GetEncoded());
				}
				if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters)
				{
					global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters key2 = (global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters)privateKey;
					return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X25519), new global::Org.BouncyCastle.Asn1.DerOctetString(key2.GetEncoded()), attributes, key2.GeneratePublicKey().GetEncoded());
				}
				if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters)
				{
					global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters key3 = (global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters)privateKey;
					return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed448), new global::Org.BouncyCastle.Asn1.DerOctetString(key3.GetEncoded()), attributes, key3.GeneratePublicKey().GetEncoded());
				}
				if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters)
				{
					global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters key4 = (global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters)privateKey;
					return new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed25519), new global::Org.BouncyCastle.Asn1.DerOctetString(key4.GetEncoded()), attributes, key4.GeneratePublicKey().GetEncoded());
				}
				throw new global::System.ArgumentException("Class provided is not convertible: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(privateKey));
			}
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00043132 File Offset: 0x00041332
		public static global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo CreatePrivateKeyInfo(char[] passPhrase, global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo encInfo)
		{
			return global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.CreatePrivateKeyInfo(passPhrase, false, encInfo);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0004313C File Offset: 0x0004133C
		public static global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo CreatePrivateKeyInfo(char[] passPhrase, bool wrongPkcs12Zero, global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo encInfo)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID = encInfo.EncryptionAlgorithm;
			global::Org.BouncyCastle.Crypto.IBufferedCipher bufferedCipher = global::Org.BouncyCastle.Security.PbeUtilities.CreateEngine(algID) as global::Org.BouncyCastle.Crypto.IBufferedCipher;
			if (bufferedCipher == null)
			{
				string str = "Unknown encryption algorithm: ";
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm = algID.Algorithm;
				throw new global::System.Exception(str + ((algorithm != null) ? algorithm.ToString() : null));
			}
			global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters = global::Org.BouncyCastle.Security.PbeUtilities.GenerateCipherParameters(algID, passPhrase, wrongPkcs12Zero);
			bufferedCipher.Init(false, cipherParameters);
			return global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo.GetInstance(bufferedCipher.DoFinal(encInfo.GetEncryptedData()));
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000431A4 File Offset: 0x000413A4
		private static void ExtractBytes(byte[] encKey, int size, int offSet, global::Org.BouncyCastle.Math.BigInteger bI)
		{
			byte[] val = bI.ToByteArray();
			if (val.Length < size)
			{
				byte[] tmp = new byte[size];
				global::System.Array.Copy(val, 0, tmp, tmp.Length - val.Length, val.Length);
				val = tmp;
			}
			for (int i = 0; i != size; i++)
			{
				encKey[offSet + i] = val[val.Length - 1 - i];
			}
		}
	}
}
