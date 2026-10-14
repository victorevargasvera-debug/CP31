using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Ess;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Tsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x0200007E RID: 126
	public class TimeStampToken
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x00016F3C File Offset: 0x0001513C
		public TimeStampToken(global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo) : this(new global::Org.BouncyCastle.Cms.CmsSignedData(contentInfo))
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00016F4C File Offset: 0x0001514C
		public TimeStampToken(global::Org.BouncyCastle.Cms.CmsSignedData signedData)
		{
			this.tsToken = signedData;
			if (!this.tsToken.SignedContentType.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCTTstInfo))
			{
				throw new global::Org.BouncyCastle.Tsp.TspValidationException("ContentInfo object not for a time stamp.");
			}
			global::System.Collections.ICollection signers = this.tsToken.GetSignerInfos().GetSigners();
			if (signers.Count != 1)
			{
				throw new global::System.ArgumentException("Time-stamp token signed by " + signers.Count.ToString() + " signers, but it must contain just the TSA signature.");
			}
			global::System.Collections.IEnumerator signerEnum = signers.GetEnumerator();
			signerEnum.MoveNext();
			this.tsaSignerInfo = (global::Org.BouncyCastle.Cms.SignerInformation)signerEnum.Current;
			try
			{
				global::Org.BouncyCastle.Cms.CmsProcessable signedContent = this.tsToken.SignedContent;
				global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
				signedContent.Write(bOut);
				this.tstInfo = new global::Org.BouncyCastle.Tsp.TimeStampTokenInfo(global::Org.BouncyCastle.Asn1.Tsp.TstInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(bOut.ToArray())));
				global::Org.BouncyCastle.Asn1.Cms.Attribute attr = this.tsaSignerInfo.SignedAttributes[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAASigningCertificate];
				if (attr != null)
				{
					if (attr.AttrValues[0] is global::Org.BouncyCastle.Asn1.Ess.SigningCertificateV2)
					{
						global::Org.BouncyCastle.Asn1.Ess.SigningCertificateV2 signCert = global::Org.BouncyCastle.Asn1.Ess.SigningCertificateV2.GetInstance(attr.AttrValues[0]);
						this.certID = new global::Org.BouncyCastle.Tsp.TimeStampToken.CertID(global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2.GetInstance(signCert.GetCerts()[0]));
					}
					else
					{
						global::Org.BouncyCastle.Asn1.Ess.SigningCertificate signCert2 = global::Org.BouncyCastle.Asn1.Ess.SigningCertificate.GetInstance(attr.AttrValues[0]);
						this.certID = new global::Org.BouncyCastle.Tsp.TimeStampToken.CertID(global::Org.BouncyCastle.Asn1.Ess.EssCertID.GetInstance(signCert2.GetCerts()[0]));
					}
				}
				else
				{
					attr = this.tsaSignerInfo.SignedAttributes[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAASigningCertificateV2];
					if (attr == null)
					{
						throw new global::Org.BouncyCastle.Tsp.TspValidationException("no signing certificate attribute found, time stamp invalid.");
					}
					global::Org.BouncyCastle.Asn1.Ess.SigningCertificateV2 signCertV2 = global::Org.BouncyCastle.Asn1.Ess.SigningCertificateV2.GetInstance(attr.AttrValues[0]);
					this.certID = new global::Org.BouncyCastle.Tsp.TimeStampToken.CertID(global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2.GetInstance(signCertV2.GetCerts()[0]));
				}
			}
			catch (global::Org.BouncyCastle.Cms.CmsException e)
			{
				throw new global::Org.BouncyCastle.Tsp.TspException(e.Message, e.InnerException);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00017130 File Offset: 0x00015330
		public global::Org.BouncyCastle.Tsp.TimeStampTokenInfo TimeStampInfo
		{
			get
			{
				return this.tstInfo;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00017138 File Offset: 0x00015338
		public global::Org.BouncyCastle.Cms.SignerID SignerID
		{
			get
			{
				return this.tsaSignerInfo.SignerID;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00017145 File Offset: 0x00015345
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable SignedAttributes
		{
			get
			{
				return this.tsaSignerInfo.SignedAttributes;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00017152 File Offset: 0x00015352
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable UnsignedAttributes
		{
			get
			{
				return this.tsaSignerInfo.UnsignedAttributes;
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001715F File Offset: 0x0001535F
		public global::Org.BouncyCastle.X509.Store.IX509Store GetCertificates(string type)
		{
			return this.tsToken.GetCertificates(type);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0001716D File Offset: 0x0001536D
		public global::Org.BouncyCastle.X509.Store.IX509Store GetCrls(string type)
		{
			return this.tsToken.GetCrls(type);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0001717B File Offset: 0x0001537B
		public global::Org.BouncyCastle.X509.Store.IX509Store GetCertificates()
		{
			return this.tsToken.GetCertificates();
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00017188 File Offset: 0x00015388
		public global::Org.BouncyCastle.X509.Store.IX509Store GetAttributeCertificates(string type)
		{
			return this.tsToken.GetAttributeCertificates(type);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00017198 File Offset: 0x00015398
		public void Validate(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			try
			{
				byte[] hash = global::Org.BouncyCastle.Security.DigestUtilities.CalculateDigest(this.certID.GetHashAlgorithmName(), cert.GetEncoded());
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.certID.GetCertHash(), hash))
				{
					throw new global::Org.BouncyCastle.Tsp.TspValidationException("certificate hash does not match certID hash.");
				}
				if (this.certID.IssuerSerial != null)
				{
					if (!this.certID.IssuerSerial.Serial.HasValue(cert.SerialNumber))
					{
						throw new global::Org.BouncyCastle.Tsp.TspValidationException("certificate serial number does not match certID for signature.");
					}
					global::Org.BouncyCastle.Asn1.X509.GeneralName[] names = this.certID.IssuerSerial.Issuer.GetNames();
					global::Org.BouncyCastle.Asn1.X509.X509Name principal = global::Org.BouncyCastle.X509.PrincipalUtilities.GetIssuerX509Principal(cert);
					bool found = false;
					for (int i = 0; i != names.Length; i++)
					{
						if (names[i].TagNo == 4 && global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(names[i].Name).Equivalent(principal))
						{
							found = true;
							break;
						}
					}
					if (!found)
					{
						throw new global::Org.BouncyCastle.Tsp.TspValidationException("certificate name does not match certID for signature. ");
					}
				}
				global::Org.BouncyCastle.Tsp.TspUtil.ValidateCertificate(cert);
				cert.CheckValidity(this.tstInfo.GenTime);
				if (!this.tsaSignerInfo.Verify(cert))
				{
					throw new global::Org.BouncyCastle.Tsp.TspValidationException("signature not created by certificate.");
				}
			}
			catch (global::Org.BouncyCastle.Cms.CmsException e)
			{
				if (e.InnerException != null)
				{
					throw new global::Org.BouncyCastle.Tsp.TspException(e.Message, e.InnerException);
				}
				string str = "CMS exception: ";
				global::Org.BouncyCastle.Cms.CmsException ex = e;
				throw new global::Org.BouncyCastle.Tsp.TspException(str + ((ex != null) ? ex.ToString() : null), e);
			}
			catch (global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException e2)
			{
				string str2 = "problem processing certificate: ";
				global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException ex2 = e2;
				throw new global::Org.BouncyCastle.Tsp.TspException(str2 + ((ex2 != null) ? ex2.ToString() : null), e2);
			}
			catch (global::Org.BouncyCastle.Security.SecurityUtilityException e3)
			{
				throw new global::Org.BouncyCastle.Tsp.TspException("cannot find algorithm: " + e3.Message, e3);
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00017374 File Offset: 0x00015574
		public global::Org.BouncyCastle.Cms.CmsSignedData ToCmsSignedData()
		{
			return this.tsToken;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001737C File Offset: 0x0001557C
		public byte[] GetEncoded()
		{
			return this.tsToken.GetEncoded("DER");
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001738E File Offset: 0x0001558E
		public byte[] GetEncoded(string encoding)
		{
			return this.tsToken.GetEncoded(encoding);
		}

		// Token: 0x040002B8 RID: 696
		private readonly global::Org.BouncyCastle.Cms.CmsSignedData tsToken;

		// Token: 0x040002B9 RID: 697
		private readonly global::Org.BouncyCastle.Cms.SignerInformation tsaSignerInfo;

		// Token: 0x040002BA RID: 698
		private readonly global::Org.BouncyCastle.Tsp.TimeStampTokenInfo tstInfo;

		// Token: 0x040002BB RID: 699
		private readonly global::Org.BouncyCastle.Tsp.TimeStampToken.CertID certID;

		// Token: 0x0200079D RID: 1949
		private class CertID
		{
			// Token: 0x060044F8 RID: 17656 RVA: 0x001324F8 File Offset: 0x001306F8
			internal CertID(global::Org.BouncyCastle.Asn1.Ess.EssCertID certID)
			{
				this.certID = certID;
				this.certIDv2 = null;
			}

			// Token: 0x060044F9 RID: 17657 RVA: 0x0013250E File Offset: 0x0013070E
			internal CertID(global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2 certID)
			{
				this.certIDv2 = certID;
				this.certID = null;
			}

			// Token: 0x060044FA RID: 17658 RVA: 0x00132524 File Offset: 0x00130724
			public string GetHashAlgorithmName()
			{
				if (this.certID != null)
				{
					return "SHA-1";
				}
				if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Equals(this.certIDv2.HashAlgorithm.Algorithm))
				{
					return "SHA-256";
				}
				return this.certIDv2.HashAlgorithm.Algorithm.Id;
			}

			// Token: 0x060044FB RID: 17659 RVA: 0x00132576 File Offset: 0x00130776
			public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetHashAlgorithm()
			{
				if (this.certID == null)
				{
					return this.certIDv2.HashAlgorithm;
				}
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1);
			}

			// Token: 0x060044FC RID: 17660 RVA: 0x00132596 File Offset: 0x00130796
			public byte[] GetCertHash()
			{
				if (this.certID == null)
				{
					return this.certIDv2.GetCertHash();
				}
				return this.certID.GetCertHash();
			}

			// Token: 0x17000A6A RID: 2666
			// (get) Token: 0x060044FD RID: 17661 RVA: 0x001325B7 File Offset: 0x001307B7
			public global::Org.BouncyCastle.Asn1.X509.IssuerSerial IssuerSerial
			{
				get
				{
					if (this.certID == null)
					{
						return this.certIDv2.IssuerSerial;
					}
					return this.certID.IssuerSerial;
				}
			}

			// Token: 0x040022E5 RID: 8933
			private global::Org.BouncyCastle.Asn1.Ess.EssCertID certID;

			// Token: 0x040022E6 RID: 8934
			private global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2 certIDv2;
		}
	}
}
