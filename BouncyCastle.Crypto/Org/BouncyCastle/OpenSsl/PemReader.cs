using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.EC;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.Utilities.IO.Pem;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.OpenSsl
{
	// Token: 0x020001BA RID: 442
	public class PemReader : global::Org.BouncyCastle.Utilities.IO.Pem.PemReader
	{
		// Token: 0x06001093 RID: 4243 RVA: 0x000436F5 File Offset: 0x000418F5
		public PemReader(global::System.IO.TextReader reader) : this(reader, null)
		{
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x000436FF File Offset: 0x000418FF
		public PemReader(global::System.IO.TextReader reader, global::Org.BouncyCastle.OpenSsl.IPasswordFinder pFinder) : base(reader)
		{
			this.pFinder = pFinder;
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00043710 File Offset: 0x00041910
		public object ReadObject()
		{
			global::Org.BouncyCastle.Utilities.IO.Pem.PemObject obj = base.ReadPemObject();
			if (obj == null)
			{
				return null;
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(obj.Type, "PRIVATE KEY"))
			{
				return this.ReadPrivateKey(obj);
			}
			string type = obj.Type;
			uint num = global::<PrivateImplementationDetails>.ComputeStringHash(type);
			if (num > 1592636440U)
			{
				if (num <= 2201027889U)
				{
					if (num != 1951606473U)
					{
						if (num != 2201027889U)
						{
							goto IL_1A8;
						}
						if (!(type == "CERTIFICATE REQUEST"))
						{
							goto IL_1A8;
						}
					}
					else
					{
						if (!(type == "RSA PUBLIC KEY"))
						{
							goto IL_1A8;
						}
						return this.ReadRsaPublicKey(obj);
					}
				}
				else if (num != 2369105439U)
				{
					if (num != 2389505242U)
					{
						if (num != 4194211595U)
						{
							goto IL_1A8;
						}
						if (!(type == "NEW CERTIFICATE REQUEST"))
						{
							goto IL_1A8;
						}
					}
					else
					{
						if (!(type == "CMS"))
						{
							goto IL_1A8;
						}
						goto IL_190;
					}
				}
				else
				{
					if (!(type == "PUBLIC KEY"))
					{
						goto IL_1A8;
					}
					return this.ReadPublicKey(obj);
				}
				return this.ReadCertificateRequest(obj);
			}
			if (num <= 479209360U)
			{
				if (num != 368575810U)
				{
					if (num != 479209360U)
					{
						goto IL_1A8;
					}
					if (!(type == "CERTIFICATE"))
					{
						goto IL_1A8;
					}
				}
				else if (!(type == "X509 CERTIFICATE"))
				{
					goto IL_1A8;
				}
				return this.ReadCertificate(obj);
			}
			if (num != 1514293038U)
			{
				if (num != 1517936775U)
				{
					if (num != 1592636440U)
					{
						goto IL_1A8;
					}
					if (!(type == "ATTRIBUTE CERTIFICATE"))
					{
						goto IL_1A8;
					}
					return this.ReadAttributeCertificate(obj);
				}
				else if (!(type == "PKCS7"))
				{
					goto IL_1A8;
				}
			}
			else
			{
				if (!(type == "X509 CRL"))
				{
					goto IL_1A8;
				}
				return this.ReadCrl(obj);
			}
			IL_190:
			return this.ReadPkcs7(obj);
			IL_1A8:
			throw new global::System.IO.IOException("unrecognised object: " + obj.Type);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x000438DC File Offset: 0x00041ADC
		private global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter ReadRsaPublicKey(global::Org.BouncyCastle.Utilities.IO.Pem.PemObject pemObject)
		{
			global::Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure rsaPubStructure = global::Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(pemObject.Content));
			return new global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(false, rsaPubStructure.Modulus, rsaPubStructure.PublicExponent);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0004390C File Offset: 0x00041B0C
		private global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter ReadPublicKey(global::Org.BouncyCastle.Utilities.IO.Pem.PemObject pemObject)
		{
			return global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(pemObject.Content);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0004391C File Offset: 0x00041B1C
		private global::Org.BouncyCastle.X509.X509Certificate ReadCertificate(global::Org.BouncyCastle.Utilities.IO.Pem.PemObject pemObject)
		{
			global::Org.BouncyCastle.X509.X509Certificate result;
			try
			{
				result = new global::Org.BouncyCastle.X509.X509CertificateParser().ReadCertificate(pemObject.Content);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.OpenSsl.PemException("problem parsing cert: " + e.ToString());
			}
			return result;
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00043964 File Offset: 0x00041B64
		private global::Org.BouncyCastle.X509.X509Crl ReadCrl(global::Org.BouncyCastle.Utilities.IO.Pem.PemObject pemObject)
		{
			global::Org.BouncyCastle.X509.X509Crl result;
			try
			{
				result = new global::Org.BouncyCastle.X509.X509CrlParser().ReadCrl(pemObject.Content);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.OpenSsl.PemException("problem parsing cert: " + e.ToString());
			}
			return result;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x000439AC File Offset: 0x00041BAC
		private global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest ReadCertificateRequest(global::Org.BouncyCastle.Utilities.IO.Pem.PemObject pemObject)
		{
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest result;
			try
			{
				result = new global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest(pemObject.Content);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.OpenSsl.PemException("problem parsing cert: " + e.ToString());
			}
			return result;
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x000439F0 File Offset: 0x00041BF0
		private global::Org.BouncyCastle.X509.IX509AttributeCertificate ReadAttributeCertificate(global::Org.BouncyCastle.Utilities.IO.Pem.PemObject pemObject)
		{
			return new global::Org.BouncyCastle.X509.X509V2AttributeCertificate(pemObject.Content);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00043A00 File Offset: 0x00041C00
		private global::Org.BouncyCastle.Asn1.Cms.ContentInfo ReadPkcs7(global::Org.BouncyCastle.Utilities.IO.Pem.PemObject pemObject)
		{
			global::Org.BouncyCastle.Asn1.Cms.ContentInfo instance;
			try
			{
				instance = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(pemObject.Content));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.OpenSsl.PemException("problem parsing PKCS7 object: " + e.ToString());
			}
			return instance;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00043A48 File Offset: 0x00041C48
		private object ReadPrivateKey(global::Org.BouncyCastle.Utilities.IO.Pem.PemObject pemObject)
		{
			string type = pemObject.Type.Substring(0, pemObject.Type.Length - "PRIVATE KEY".Length).Trim();
			byte[] keyBytes = pemObject.Content;
			global::System.Collections.IDictionary fields = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			foreach (object obj in pemObject.Headers)
			{
				global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader header = (global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader)obj;
				fields[header.Name] = header.Value;
			}
			if ((string)fields["Proc-Type"] == "4,ENCRYPTED")
			{
				if (this.pFinder == null)
				{
					throw new global::Org.BouncyCastle.Security.PasswordException("No password finder specified, but a password is required");
				}
				char[] password = this.pFinder.GetPassword();
				if (password == null)
				{
					throw new global::Org.BouncyCastle.Security.PasswordException("Password is null, but a password is required");
				}
				string[] array = ((string)fields["DEK-Info"]).Split(new char[]
				{
					','
				});
				string dekAlgName = array[0].Trim();
				byte[] iv = global::Org.BouncyCastle.Utilities.Encoders.Hex.Decode(array[1].Trim());
				keyBytes = global::Org.BouncyCastle.OpenSsl.PemUtilities.Crypt(false, keyBytes, password, dekAlgName, iv);
			}
			object result;
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence seq = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(keyBytes);
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privSpec;
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubSpec;
				if (!(type == "RSA"))
				{
					if (!(type == "DSA"))
					{
						if (!(type == "EC"))
						{
							if (!(type == "ENCRYPTED"))
							{
								if (type != null)
								{
									if (type.Length == 0)
									{
										return global::Org.BouncyCastle.Security.PrivateKeyFactory.CreateKey(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo.GetInstance(seq));
									}
								}
								throw new global::System.ArgumentException("Unknown key type: " + type, "type");
							}
							char[] password2 = this.pFinder.GetPassword();
							if (password2 == null)
							{
								throw new global::Org.BouncyCastle.Security.PasswordException("Password is null, but a password is required");
							}
							return global::Org.BouncyCastle.Security.PrivateKeyFactory.DecryptKey(password2, global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo.GetInstance(seq));
						}
						else
						{
							global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure pKey = global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure.GetInstance(seq);
							global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdECPublicKey, pKey.GetParameters());
							privSpec = global::Org.BouncyCastle.Security.PrivateKeyFactory.CreateKey(new global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo(algId, pKey.ToAsn1Object()));
							global::Org.BouncyCastle.Asn1.DerBitString pubKey = pKey.GetPublicKey();
							if (pubKey != null)
							{
								pubSpec = global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(new global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(algId, pubKey.GetBytes()));
							}
							else
							{
								pubSpec = global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.GetCorrespondingPublicKey((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)privSpec);
							}
						}
					}
					else
					{
						if (seq.Count != 6)
						{
							throw new global::Org.BouncyCastle.OpenSsl.PemException("malformed sequence in DSA private key");
						}
						global::Org.BouncyCastle.Asn1.DerInteger p = (global::Org.BouncyCastle.Asn1.DerInteger)seq[1];
						global::Org.BouncyCastle.Asn1.DerInteger q = (global::Org.BouncyCastle.Asn1.DerInteger)seq[2];
						global::Org.BouncyCastle.Asn1.DerInteger g = (global::Org.BouncyCastle.Asn1.DerInteger)seq[3];
						global::Org.BouncyCastle.Asn1.DerInteger derInteger = (global::Org.BouncyCastle.Asn1.DerInteger)seq[4];
						global::Org.BouncyCastle.Asn1.DerInteger derInteger2 = (global::Org.BouncyCastle.Asn1.DerInteger)seq[5];
						global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters = new global::Org.BouncyCastle.Crypto.Parameters.DsaParameters(p.Value, q.Value, g.Value);
						privSpec = new global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters(derInteger2.Value, parameters);
						pubSpec = new global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters(derInteger.Value, parameters);
					}
				}
				else
				{
					if (seq.Count != 9)
					{
						throw new global::Org.BouncyCastle.OpenSsl.PemException("malformed sequence in RSA private key");
					}
					global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure rsa = global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure.GetInstance(seq);
					pubSpec = new global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(false, rsa.Modulus, rsa.PublicExponent);
					privSpec = new global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters(rsa.Modulus, rsa.PublicExponent, rsa.PrivateExponent, rsa.Prime1, rsa.Prime2, rsa.Exponent1, rsa.Exponent2, rsa.Coefficient);
				}
				result = new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(pubSpec, privSpec);
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.OpenSsl.PemException("problem creating " + type + " private key: " + e.ToString());
			}
			return result;
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00043E08 File Offset: 0x00042008
		private static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetCurveParameters(string name)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecP = global::Org.BouncyCastle.Crypto.EC.CustomNamedCurves.GetByName(name);
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.X9.ECNamedCurveTable.GetByName(name);
			}
			if (ecP == null)
			{
				throw new global::System.Exception("unknown curve name: " + name);
			}
			return ecP;
		}

		// Token: 0x040008BB RID: 2235
		private readonly global::Org.BouncyCastle.OpenSsl.IPasswordFinder pFinder;
	}
}
