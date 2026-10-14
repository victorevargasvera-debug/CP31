using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000010 RID: 16
	public sealed class SubjectPublicKeyInfoFactory
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00005E28 File Offset: 0x00004028
		private SubjectPublicKeyInfoFactory()
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005E30 File Offset: 0x00004030
		public static global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo CreateSubjectPublicKeyInfo(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			if (publicKey == null)
			{
				throw new global::System.ArgumentNullException("publicKey");
			}
			if (publicKey.IsPrivate)
			{
				throw new global::System.ArgumentException("Private key passed - public key expected.", "publicKey");
			}
			if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters _key = (global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters)publicKey;
				global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters kp = _key.Parameters;
				return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.ElGamalAlgorithm, new global::Org.BouncyCastle.Asn1.Oiw.ElGamalParameter(kp.P, kp.G).ToAsn1Object()), new global::Org.BouncyCastle.Asn1.DerInteger(_key.Y));
			}
			if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters _key2 = (global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters)publicKey;
				global::Org.BouncyCastle.Crypto.Parameters.DsaParameters kp2 = _key2.Parameters;
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (kp2 == null) ? null : new global::Org.BouncyCastle.Asn1.X509.DsaParameter(kp2.P, kp2.Q, kp2.G).ToAsn1Object();
				return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsa, ae), new global::Org.BouncyCastle.Asn1.DerInteger(_key2.Y));
			}
			if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters _key3 = (global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)publicKey;
				global::Org.BouncyCastle.Crypto.Parameters.DHParameters kp3 = _key3.Parameters;
				return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(_key3.AlgorithmOid, new global::Org.BouncyCastle.Asn1.Pkcs.DHParameter(kp3.P, kp3.G, kp3.L).ToAsn1Object()), new global::Org.BouncyCastle.Asn1.DerInteger(_key3.Y));
			}
			if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters _key4 = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)publicKey;
				return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption, global::Org.BouncyCastle.Asn1.DerNull.Instance), new global::Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure(_key4.Modulus, _key4.Exponent).ToAsn1Object());
			}
			if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters _key5 = (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)publicKey;
				if (_key5.Parameters is global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters)
				{
					global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters gostParams = (global::Org.BouncyCastle.Crypto.Parameters.ECGost3410Parameters)_key5.Parameters;
					global::Org.BouncyCastle.Math.BigInteger bX = _key5.Q.AffineXCoord.ToBigInteger();
					global::Org.BouncyCastle.Math.BigInteger bY = _key5.Q.AffineYCoord.ToBigInteger();
					bool flag = bX.BitLength > 256;
					global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters parameters = new global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters(gostParams.PublicKeyParamSet, gostParams.DigestParamSet, gostParams.EncryptionParamSet);
					int encKeySize;
					int offset;
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier algIdentifier;
					if (flag)
					{
						encKeySize = 128;
						offset = 64;
						algIdentifier = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512;
					}
					else
					{
						encKeySize = 64;
						offset = 32;
						algIdentifier = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256;
					}
					byte[] encKey = new byte[encKeySize];
					global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.ExtractBytes(encKey, encKeySize / 2, 0, bX);
					global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.ExtractBytes(encKey, encKeySize / 2, offset, bY);
					return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algIdentifier, parameters), new global::Org.BouncyCastle.Asn1.DerOctetString(encKey));
				}
				if (!(_key5.AlgorithmName == "ECGOST3410"))
				{
					global::Org.BouncyCastle.Asn1.X9.X962Parameters x962;
					if (_key5.PublicKeyParamSet == null)
					{
						global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters kp4 = _key5.Parameters;
						x962 = new global::Org.BouncyCastle.Asn1.X9.X962Parameters(new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(kp4.Curve, kp4.G, kp4.N, kp4.H, kp4.GetSeed()));
					}
					else
					{
						x962 = new global::Org.BouncyCastle.Asn1.X9.X962Parameters(_key5.PublicKeyParamSet);
					}
					byte[] pubKey = _key5.Q.GetEncoded(false);
					return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdECPublicKey, x962.ToAsn1Object()), pubKey);
				}
				if (_key5.PublicKeyParamSet == null)
				{
					throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("Not a CryptoPro parameter set");
				}
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = _key5.Q.Normalize();
				global::Org.BouncyCastle.Math.BigInteger bX2 = ecpoint.AffineXCoord.ToBigInteger();
				global::Org.BouncyCastle.Math.BigInteger bY2 = ecpoint.AffineYCoord.ToBigInteger();
				byte[] encKey2 = new byte[64];
				global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.ExtractBytes(encKey2, 0, bX2);
				global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.ExtractBytes(encKey2, 32, bY2);
				global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters gostParams2 = new global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters(_key5.PublicKeyParamSet, global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94CryptoProParamSet);
				return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001, gostParams2.ToAsn1Object()), new global::Org.BouncyCastle.Asn1.DerOctetString(encKey2));
			}
			else if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.Gost3410PublicKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.Gost3410PublicKeyParameters _key6 = (global::Org.BouncyCastle.Crypto.Parameters.Gost3410PublicKeyParameters)publicKey;
				if (_key6.PublicKeyParamSet == null)
				{
					throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("Not a CryptoPro parameter set");
				}
				byte[] keyEnc = _key6.Y.ToByteArrayUnsigned();
				byte[] keyBytes = new byte[keyEnc.Length];
				for (int i = 0; i != keyBytes.Length; i++)
				{
					keyBytes[i] = keyEnc[keyEnc.Length - 1 - i];
				}
				global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters algParams = new global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters(_key6.PublicKeyParamSet, global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94CryptoProParamSet);
				return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94, algParams.ToAsn1Object()), new global::Org.BouncyCastle.Asn1.DerOctetString(keyBytes));
			}
			else
			{
				if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters)
				{
					global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters key = (global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters)publicKey;
					return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X448), key.GetEncoded());
				}
				if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters)
				{
					global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters key2 = (global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters)publicKey;
					return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X25519), key2.GetEncoded());
				}
				if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters)
				{
					global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters key3 = (global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters)publicKey;
					return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed448), key3.GetEncoded());
				}
				if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters)
				{
					global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters key4 = (global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters)publicKey;
					return new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed25519), key4.GetEncoded());
				}
				throw new global::System.ArgumentException("Class provided no convertible: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(publicKey));
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000062D4 File Offset: 0x000044D4
		private static void ExtractBytes(byte[] encKey, int offset, global::Org.BouncyCastle.Math.BigInteger bI)
		{
			byte[] val = bI.ToByteArray();
			int i = (bI.BitLength + 7) / 8;
			for (int j = 0; j < i; j++)
			{
				encKey[offset + j] = val[val.Length - 1 - j];
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00006310 File Offset: 0x00004510
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
