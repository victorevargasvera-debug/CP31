using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.Utilities.IO.Pem;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.OpenSsl
{
	// Token: 0x020001B8 RID: 440
	public class MiscPemGenerator : global::Org.BouncyCastle.Utilities.IO.Pem.PemObjectGenerator
	{
		// Token: 0x0600108A RID: 4234 RVA: 0x00043268 File Offset: 0x00041468
		public MiscPemGenerator(object obj)
		{
			this.obj = obj;
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00043277 File Offset: 0x00041477
		public MiscPemGenerator(object obj, string algorithm, char[] password, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.obj = obj;
			this.algorithm = algorithm;
			this.password = password;
			this.random = random;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0004329C File Offset: 0x0004149C
		private static global::Org.BouncyCastle.Utilities.IO.Pem.PemObject CreatePemObject(object obj)
		{
			if (obj == null)
			{
				throw new global::System.ArgumentNullException("obj");
			}
			if (obj is global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)
			{
				return global::Org.BouncyCastle.OpenSsl.MiscPemGenerator.CreatePemObject(((global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)obj).Private);
			}
			if (obj is global::Org.BouncyCastle.Utilities.IO.Pem.PemObject)
			{
				return (global::Org.BouncyCastle.Utilities.IO.Pem.PemObject)obj;
			}
			if (obj is global::Org.BouncyCastle.Utilities.IO.Pem.PemObjectGenerator)
			{
				return ((global::Org.BouncyCastle.Utilities.IO.Pem.PemObjectGenerator)obj).Generate();
			}
			string type;
			byte[] encoding;
			if (obj is global::Org.BouncyCastle.X509.X509Certificate)
			{
				type = "CERTIFICATE";
				try
				{
					encoding = ((global::Org.BouncyCastle.X509.X509Certificate)obj).GetEncoded();
					goto IL_15A;
				}
				catch (global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException e)
				{
					throw new global::System.IO.IOException("Cannot Encode object: " + e.ToString());
				}
			}
			if (obj is global::Org.BouncyCastle.X509.X509Crl)
			{
				type = "X509 CRL";
				try
				{
					encoding = ((global::Org.BouncyCastle.X509.X509Crl)obj).GetEncoded();
					goto IL_15A;
				}
				catch (global::Org.BouncyCastle.Security.Certificates.CrlException e2)
				{
					throw new global::System.IO.IOException("Cannot Encode object: " + e2.ToString());
				}
			}
			if (obj is global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)
			{
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter akp = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)obj;
				if (akp.IsPrivate)
				{
					encoding = global::Org.BouncyCastle.OpenSsl.MiscPemGenerator.EncodePrivateKey(akp, out type);
				}
				else
				{
					type = "PUBLIC KEY";
					encoding = global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(akp).GetDerEncoded();
				}
			}
			else if (obj is global::Org.BouncyCastle.X509.IX509AttributeCertificate)
			{
				type = "ATTRIBUTE CERTIFICATE";
				encoding = ((global::Org.BouncyCastle.X509.X509V2AttributeCertificate)obj).GetEncoded();
			}
			else if (obj is global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest)
			{
				type = "CERTIFICATE REQUEST";
				encoding = ((global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest)obj).GetEncoded();
			}
			else
			{
				if (!(obj is global::Org.BouncyCastle.Asn1.Cms.ContentInfo))
				{
					throw new global::Org.BouncyCastle.Utilities.IO.Pem.PemGenerationException("Object type not supported: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
				}
				type = "PKCS7";
				encoding = ((global::Org.BouncyCastle.Asn1.Cms.ContentInfo)obj).GetEncoded();
			}
			IL_15A:
			return new global::Org.BouncyCastle.Utilities.IO.Pem.PemObject(type, encoding);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00043428 File Offset: 0x00041628
		private static global::Org.BouncyCastle.Utilities.IO.Pem.PemObject CreatePemObject(object obj, string algorithm, char[] password, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (obj == null)
			{
				throw new global::System.ArgumentNullException("obj");
			}
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			if (password == null)
			{
				throw new global::System.ArgumentNullException("password");
			}
			if (random == null)
			{
				throw new global::System.ArgumentNullException("random");
			}
			if (obj is global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)
			{
				return global::Org.BouncyCastle.OpenSsl.MiscPemGenerator.CreatePemObject(((global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)obj).Private, algorithm, password, random);
			}
			string type = null;
			byte[] keyData = null;
			if (obj is global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)
			{
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter akp = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)obj;
				if (akp.IsPrivate)
				{
					keyData = global::Org.BouncyCastle.OpenSsl.MiscPemGenerator.EncodePrivateKey(akp, out type);
				}
			}
			if (type == null || keyData == null)
			{
				throw new global::Org.BouncyCastle.Utilities.IO.Pem.PemGenerationException("Object type not supported: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
			}
			string dekAlgName = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm);
			if (dekAlgName == "DESEDE")
			{
				dekAlgName = "DES-EDE3-CBC";
			}
			byte[] iv = new byte[global::Org.BouncyCastle.Utilities.Platform.StartsWith(dekAlgName, "AES-") ? 16 : 8];
			random.NextBytes(iv);
			byte[] encData = global::Org.BouncyCastle.OpenSsl.PemUtilities.Crypt(true, keyData, password, dekAlgName, iv);
			global::System.Collections.IList headers = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(2);
			headers.Add(new global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader("Proc-Type", "4,ENCRYPTED"));
			headers.Add(new global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader("DEK-Info", dekAlgName + "," + global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(iv)));
			return new global::Org.BouncyCastle.Utilities.IO.Pem.PemObject(type, headers, encData);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00043560 File Offset: 0x00041760
		private static byte[] EncodePrivateKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter akp, out string keyType)
		{
			global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo info = global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.CreatePrivateKeyInfo(akp);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID = info.PrivateKeyAlgorithm;
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = algID.Algorithm;
			if (oid.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsa))
			{
				keyType = "DSA PRIVATE KEY";
				global::Org.BouncyCastle.Asn1.X509.DsaParameter p = global::Org.BouncyCastle.Asn1.X509.DsaParameter.GetInstance(algID.Parameters);
				global::Org.BouncyCastle.Math.BigInteger x = ((global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters)akp).X;
				global::Org.BouncyCastle.Math.BigInteger y = p.G.ModPow(x, p.P);
				return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
				{
					new global::Org.BouncyCastle.Asn1.DerInteger(0),
					new global::Org.BouncyCastle.Asn1.DerInteger(p.P),
					new global::Org.BouncyCastle.Asn1.DerInteger(p.Q),
					new global::Org.BouncyCastle.Asn1.DerInteger(p.G),
					new global::Org.BouncyCastle.Asn1.DerInteger(y),
					new global::Org.BouncyCastle.Asn1.DerInteger(x)
				}).GetEncoded();
			}
			if (oid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption))
			{
				keyType = "RSA PRIVATE KEY";
				return info.ParsePrivateKey().GetEncoded();
			}
			if (oid.Equals(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001) || oid.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdECPublicKey))
			{
				keyType = "EC PRIVATE KEY";
				return info.ParsePrivateKey().GetEncoded();
			}
			keyType = "PRIVATE KEY";
			return info.GetEncoded();
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0004367C File Offset: 0x0004187C
		public global::Org.BouncyCastle.Utilities.IO.Pem.PemObject Generate()
		{
			global::Org.BouncyCastle.Utilities.IO.Pem.PemObject result;
			try
			{
				if (this.algorithm != null)
				{
					result = global::Org.BouncyCastle.OpenSsl.MiscPemGenerator.CreatePemObject(this.obj, this.algorithm, this.password, this.random);
				}
				else
				{
					result = global::Org.BouncyCastle.OpenSsl.MiscPemGenerator.CreatePemObject(this.obj);
				}
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Utilities.IO.Pem.PemGenerationException("encoding exception", e);
			}
			return result;
		}

		// Token: 0x040008B7 RID: 2231
		private object obj;

		// Token: 0x040008B8 RID: 2232
		private string algorithm;

		// Token: 0x040008B9 RID: 2233
		private char[] password;

		// Token: 0x040008BA RID: 2234
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
