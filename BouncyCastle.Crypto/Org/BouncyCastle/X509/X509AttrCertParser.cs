using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000011 RID: 17
	public class X509AttrCertParser
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00006360 File Offset: 0x00004560
		private global::Org.BouncyCastle.X509.IX509AttributeCertificate ReadDerCertificate(global::Org.BouncyCastle.Asn1.Asn1InputStream dIn)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence seq = (global::Org.BouncyCastle.Asn1.Asn1Sequence)dIn.ReadObject();
			if (seq.Count > 1 && seq[0] is global::Org.BouncyCastle.Asn1.DerObjectIdentifier && seq[0].Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.SignedData))
			{
				this.sData = global::Org.BouncyCastle.Asn1.Pkcs.SignedData.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1], true)).Certificates;
				return this.GetCertificate();
			}
			return new global::Org.BouncyCastle.X509.X509V2AttributeCertificate(global::Org.BouncyCastle.Asn1.X509.AttributeCertificate.GetInstance(seq));
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000063D8 File Offset: 0x000045D8
		private global::Org.BouncyCastle.X509.IX509AttributeCertificate GetCertificate()
		{
			if (this.sData != null)
			{
				while (this.sDataObjectCount < this.sData.Count)
				{
					global::Org.BouncyCastle.Asn1.Asn1Set asn1Set = this.sData;
					int num = this.sDataObjectCount;
					this.sDataObjectCount = num + 1;
					object obj = asn1Set[num];
					if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject && ((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj).TagNo == 2)
					{
						return new global::Org.BouncyCastle.X509.X509V2AttributeCertificate(global::Org.BouncyCastle.Asn1.X509.AttributeCertificate.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj, false)));
					}
				}
			}
			return null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00006450 File Offset: 0x00004650
		private global::Org.BouncyCastle.X509.IX509AttributeCertificate ReadPemCertificate(global::System.IO.Stream inStream)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence seq = global::Org.BouncyCastle.X509.X509AttrCertParser.PemAttrCertParser.ReadPemObject(inStream);
			if (seq != null)
			{
				return new global::Org.BouncyCastle.X509.X509V2AttributeCertificate(global::Org.BouncyCastle.Asn1.X509.AttributeCertificate.GetInstance(seq));
			}
			return null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006479 File Offset: 0x00004679
		public global::Org.BouncyCastle.X509.IX509AttributeCertificate ReadAttrCert(byte[] input)
		{
			return this.ReadAttrCert(new global::System.IO.MemoryStream(input, false));
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006488 File Offset: 0x00004688
		public global::System.Collections.ICollection ReadAttrCerts(byte[] input)
		{
			return this.ReadAttrCerts(new global::System.IO.MemoryStream(input, false));
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00006498 File Offset: 0x00004698
		public global::Org.BouncyCastle.X509.IX509AttributeCertificate ReadAttrCert(global::System.IO.Stream inStream)
		{
			if (inStream == null)
			{
				throw new global::System.ArgumentNullException("inStream");
			}
			if (!inStream.CanRead)
			{
				throw new global::System.ArgumentException("inStream must be read-able", "inStream");
			}
			if (this.currentStream == null)
			{
				this.currentStream = inStream;
				this.sData = null;
				this.sDataObjectCount = 0;
			}
			else if (this.currentStream != inStream)
			{
				this.currentStream = inStream;
				this.sData = null;
				this.sDataObjectCount = 0;
			}
			global::Org.BouncyCastle.X509.IX509AttributeCertificate result;
			try
			{
				if (this.sData != null)
				{
					if (this.sDataObjectCount != this.sData.Count)
					{
						result = this.GetCertificate();
					}
					else
					{
						this.sData = null;
						this.sDataObjectCount = 0;
						result = null;
					}
				}
				else
				{
					global::Org.BouncyCastle.Utilities.IO.PushbackStream pis = new global::Org.BouncyCastle.Utilities.IO.PushbackStream(inStream);
					int tag = pis.ReadByte();
					if (tag < 0)
					{
						result = null;
					}
					else
					{
						pis.Unread(tag);
						if (tag != 48)
						{
							result = this.ReadPemCertificate(pis);
						}
						else
						{
							result = this.ReadDerCertificate(new global::Org.BouncyCastle.Asn1.Asn1InputStream(pis));
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateException(ex.ToString());
			}
			return result;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006598 File Offset: 0x00004798
		public global::System.Collections.ICollection ReadAttrCerts(global::System.IO.Stream inStream)
		{
			global::System.Collections.IList attrCerts = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert;
			while ((attrCert = this.ReadAttrCert(inStream)) != null)
			{
				attrCerts.Add(attrCert);
			}
			return attrCerts;
		}

		// Token: 0x04000078 RID: 120
		private static readonly global::Org.BouncyCastle.X509.PemParser PemAttrCertParser = new global::Org.BouncyCastle.X509.PemParser("ATTRIBUTE CERTIFICATE");

		// Token: 0x04000079 RID: 121
		private global::Org.BouncyCastle.Asn1.Asn1Set sData;

		// Token: 0x0400007A RID: 122
		private int sDataObjectCount;

		// Token: 0x0400007B RID: 123
		private global::System.IO.Stream currentStream;
	}
}
