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
	// Token: 0x02000015 RID: 21
	public class X509CertificateParser
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x000073C8 File Offset: 0x000055C8
		private global::Org.BouncyCastle.X509.X509Certificate ReadDerCertificate(global::Org.BouncyCastle.Asn1.Asn1InputStream dIn)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence seq = (global::Org.BouncyCastle.Asn1.Asn1Sequence)dIn.ReadObject();
			if (seq.Count > 1 && seq[0] is global::Org.BouncyCastle.Asn1.DerObjectIdentifier && seq[0].Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.SignedData))
			{
				this.sData = global::Org.BouncyCastle.Asn1.Pkcs.SignedData.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1], true)).Certificates;
				return this.GetCertificate();
			}
			return this.CreateX509Certificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(seq));
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007440 File Offset: 0x00005640
		private global::Org.BouncyCastle.X509.X509Certificate GetCertificate()
		{
			if (this.sData != null)
			{
				while (this.sDataObjectCount < this.sData.Count)
				{
					global::Org.BouncyCastle.Asn1.Asn1Set asn1Set = this.sData;
					int num = this.sDataObjectCount;
					this.sDataObjectCount = num + 1;
					object obj = asn1Set[num];
					if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
					{
						return this.CreateX509Certificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(obj));
					}
				}
			}
			return null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000074A0 File Offset: 0x000056A0
		private global::Org.BouncyCastle.X509.X509Certificate ReadPemCertificate(global::System.IO.Stream inStream)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence seq = global::Org.BouncyCastle.X509.X509CertificateParser.PemCertParser.ReadPemObject(inStream);
			if (seq != null)
			{
				return this.CreateX509Certificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(seq));
			}
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000074CA File Offset: 0x000056CA
		protected virtual global::Org.BouncyCastle.X509.X509Certificate CreateX509Certificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure c)
		{
			return new global::Org.BouncyCastle.X509.X509Certificate(c);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000074D2 File Offset: 0x000056D2
		public global::Org.BouncyCastle.X509.X509Certificate ReadCertificate(byte[] input)
		{
			return this.ReadCertificate(new global::System.IO.MemoryStream(input, false));
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000074E1 File Offset: 0x000056E1
		public global::System.Collections.ICollection ReadCertificates(byte[] input)
		{
			return this.ReadCertificates(new global::System.IO.MemoryStream(input, false));
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000074F0 File Offset: 0x000056F0
		public global::Org.BouncyCastle.X509.X509Certificate ReadCertificate(global::System.IO.Stream inStream)
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
			global::Org.BouncyCastle.X509.X509Certificate result;
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
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateException("Failed to read certificate", e);
			}
			return result;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000075F0 File Offset: 0x000057F0
		public global::System.Collections.ICollection ReadCertificates(global::System.IO.Stream inStream)
		{
			global::System.Collections.IList certs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.X509.X509Certificate cert;
			while ((cert = this.ReadCertificate(inStream)) != null)
			{
				certs.Add(cert);
			}
			return certs;
		}

		// Token: 0x04000089 RID: 137
		private static readonly global::Org.BouncyCastle.X509.PemParser PemCertParser = new global::Org.BouncyCastle.X509.PemParser("CERTIFICATE");

		// Token: 0x0400008A RID: 138
		private global::Org.BouncyCastle.Asn1.Asn1Set sData;

		// Token: 0x0400008B RID: 139
		private int sDataObjectCount;

		// Token: 0x0400008C RID: 140
		private global::System.IO.Stream currentStream;
	}
}
