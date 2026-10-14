using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x02000197 RID: 407
	public class PkixCertPath
	{
		// Token: 0x06000F04 RID: 3844 RVA: 0x00037624 File Offset: 0x00035824
		static PkixCertPath()
		{
			global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			list.Add("PkiPath");
			list.Add("PEM");
			list.Add("PKCS7");
			global::Org.BouncyCastle.Pkix.PkixCertPath.certPathEncodings = global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ReadOnly(list);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0003765C File Offset: 0x0003585C
		private static global::System.Collections.IList SortCerts(global::System.Collections.IList certs)
		{
			if (certs.Count < 2)
			{
				return certs;
			}
			global::Org.BouncyCastle.Asn1.X509.X509Name issuer = ((global::Org.BouncyCastle.X509.X509Certificate)certs[0]).IssuerDN;
			bool okay = true;
			for (int i = 1; i != certs.Count; i++)
			{
				global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certs[i];
				if (!issuer.Equivalent(cert.SubjectDN, true))
				{
					okay = false;
					break;
				}
				issuer = ((global::Org.BouncyCastle.X509.X509Certificate)certs[i]).IssuerDN;
			}
			if (okay)
			{
				return certs;
			}
			global::System.Collections.IList retList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(certs.Count);
			global::System.Collections.IList orig = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(certs);
			for (int j = 0; j < certs.Count; j++)
			{
				global::Org.BouncyCastle.X509.X509Certificate cert2 = (global::Org.BouncyCastle.X509.X509Certificate)certs[j];
				bool found = false;
				global::Org.BouncyCastle.Asn1.X509.X509Name subject = cert2.SubjectDN;
				using (global::System.Collections.IEnumerator enumerator = certs.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((global::Org.BouncyCastle.X509.X509Certificate)enumerator.Current).IssuerDN.Equivalent(subject, true))
						{
							found = true;
							break;
						}
					}
				}
				if (!found)
				{
					retList.Add(cert2);
					certs.RemoveAt(j);
				}
			}
			if (retList.Count > 1)
			{
				return orig;
			}
			for (int k = 0; k != retList.Count; k++)
			{
				issuer = ((global::Org.BouncyCastle.X509.X509Certificate)retList[k]).IssuerDN;
				for (int l = 0; l < certs.Count; l++)
				{
					global::Org.BouncyCastle.X509.X509Certificate c = (global::Org.BouncyCastle.X509.X509Certificate)certs[l];
					if (issuer.Equivalent(c.SubjectDN, true))
					{
						retList.Add(c);
						certs.RemoveAt(l);
						break;
					}
				}
			}
			if (certs.Count > 0)
			{
				return orig;
			}
			return retList;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00037818 File Offset: 0x00035A18
		public PkixCertPath(global::System.Collections.ICollection certificates)
		{
			this.certificates = global::Org.BouncyCastle.Pkix.PkixCertPath.SortCerts(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(certificates));
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00037831 File Offset: 0x00035A31
		public PkixCertPath(global::System.IO.Stream inStream) : this(inStream, "PkiPath")
		{
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00037840 File Offset: 0x00035A40
		public PkixCertPath(global::System.IO.Stream inStream, string encoding)
		{
			string upper = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(encoding);
			global::System.Collections.IList certs;
			try
			{
				if (upper.Equals(global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant("PkiPath")))
				{
					global::Org.BouncyCastle.Asn1.Asn1Object asn1Object = new global::Org.BouncyCastle.Asn1.Asn1InputStream(inStream).ReadObject();
					if (!(asn1Object is global::Org.BouncyCastle.Asn1.Asn1Sequence))
					{
						throw new global::Org.BouncyCastle.Security.Certificates.CertificateException("input stream does not contain a ASN1 SEQUENCE while reading PkiPath encoded data to load CertPath");
					}
					certs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
					using (global::System.Collections.IEnumerator enumerator = ((global::Org.BouncyCastle.Asn1.Asn1Sequence)asn1Object).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							global::System.IO.Stream certInStream = new global::System.IO.MemoryStream(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).GetEncoded("DER"), false);
							certs.Insert(0, new global::Org.BouncyCastle.X509.X509CertificateParser().ReadCertificate(certInStream));
						}
						goto IL_DA;
					}
				}
				if (!upper.Equals("PKCS7") && !upper.Equals("PEM"))
				{
					throw new global::Org.BouncyCastle.Security.Certificates.CertificateException("unsupported encoding: " + encoding);
				}
				certs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(new global::Org.BouncyCastle.X509.X509CertificateParser().ReadCertificates(inStream));
				IL_DA:;
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateException("IOException throw while decoding CertPath:\n" + ex.ToString());
			}
			this.certificates = global::Org.BouncyCastle.Pkix.PkixCertPath.SortCerts(certs);
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x0003796C File Offset: 0x00035B6C
		public virtual global::System.Collections.IEnumerable Encodings
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.Pkix.PkixCertPath.certPathEncodings);
			}
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00037978 File Offset: 0x00035B78
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			global::Org.BouncyCastle.Pkix.PkixCertPath other = obj as global::Org.BouncyCastle.Pkix.PkixCertPath;
			if (other == null)
			{
				return false;
			}
			global::System.Collections.IList thisCerts = this.Certificates;
			global::System.Collections.IList otherCerts = other.Certificates;
			if (thisCerts.Count != otherCerts.Count)
			{
				return false;
			}
			global::System.Collections.IEnumerator e = thisCerts.GetEnumerator();
			global::System.Collections.IEnumerator e2 = otherCerts.GetEnumerator();
			while (e.MoveNext())
			{
				e2.MoveNext();
				if (!object.Equals(e.Current, e2.Current))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x000379ED File Offset: 0x00035BED
		public override int GetHashCode()
		{
			return this.Certificates.GetHashCode();
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x000379FC File Offset: 0x00035BFC
		public virtual byte[] GetEncoded()
		{
			foreach (object enc in this.Encodings)
			{
				if (enc is string)
				{
					return this.GetEncoded((string)enc);
				}
			}
			return null;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00037A64 File Offset: 0x00035C64
		public virtual byte[] GetEncoded(string encoding)
		{
			if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(encoding, "PkiPath"))
			{
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
				for (int i = this.certificates.Count - 1; i >= 0; i--)
				{
					v.Add(this.ToAsn1Object((global::Org.BouncyCastle.X509.X509Certificate)this.certificates[i]));
				}
				return this.ToDerEncoded(new global::Org.BouncyCastle.Asn1.DerSequence(v));
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(encoding, "PKCS7"))
			{
				global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo encInfo = new global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Data, null);
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector v2 = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
				for (int j = 0; j != this.certificates.Count; j++)
				{
					v2.Add(this.ToAsn1Object((global::Org.BouncyCastle.X509.X509Certificate)this.certificates[j]));
				}
				global::Org.BouncyCastle.Asn1.Pkcs.SignedData sd = new global::Org.BouncyCastle.Asn1.Pkcs.SignedData(new global::Org.BouncyCastle.Asn1.DerInteger(1), new global::Org.BouncyCastle.Asn1.DerSet(), encInfo, new global::Org.BouncyCastle.Asn1.DerSet(v2), null, new global::Org.BouncyCastle.Asn1.DerSet());
				return this.ToDerEncoded(new global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.SignedData, sd));
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(encoding, "PEM"))
			{
				global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
				global::Org.BouncyCastle.OpenSsl.PemWriter pWrt = new global::Org.BouncyCastle.OpenSsl.PemWriter(new global::System.IO.StreamWriter(bOut));
				try
				{
					for (int k = 0; k != this.certificates.Count; k++)
					{
						pWrt.WriteObject(this.certificates[k]);
					}
					global::Org.BouncyCastle.Utilities.Platform.Dispose(pWrt.Writer);
				}
				catch (global::System.Exception)
				{
					throw new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException("can't encode certificate for PEM encoded path");
				}
				return bOut.ToArray();
			}
			throw new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException("unsupported encoding: " + encoding);
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00037BE4 File Offset: 0x00035DE4
		public virtual global::System.Collections.IList Certificates
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ReadOnly(this.certificates);
			}
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00037BF4 File Offset: 0x00035DF4
		private global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object result;
			try
			{
				result = global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(cert.GetEncoded());
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException("Exception while encoding certificate", e);
			}
			return result;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00037C30 File Offset: 0x00035E30
		private byte[] ToDerEncoded(global::Org.BouncyCastle.Asn1.Asn1Encodable obj)
		{
			byte[] encoded;
			try
			{
				encoded = obj.GetEncoded("DER");
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException("Exception thrown", e);
			}
			return encoded;
		}

		// Token: 0x04000853 RID: 2131
		internal static readonly global::System.Collections.IList certPathEncodings;

		// Token: 0x04000854 RID: 2132
		private readonly global::System.Collections.IList certificates;
	}
}
