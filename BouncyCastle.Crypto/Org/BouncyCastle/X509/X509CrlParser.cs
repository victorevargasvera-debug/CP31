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
	// Token: 0x02000019 RID: 25
	public class X509CrlParser
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00008484 File Offset: 0x00006684
		public X509CrlParser() : this(false)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000848D File Offset: 0x0000668D
		public X509CrlParser(bool lazyAsn1)
		{
			this.lazyAsn1 = lazyAsn1;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000849C File Offset: 0x0000669C
		private global::Org.BouncyCastle.X509.X509Crl ReadPemCrl(global::System.IO.Stream inStream)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence seq = global::Org.BouncyCastle.X509.X509CrlParser.PemCrlParser.ReadPemObject(inStream);
			if (seq != null)
			{
				return this.CreateX509Crl(global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(seq));
			}
			return null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000084C8 File Offset: 0x000066C8
		private global::Org.BouncyCastle.X509.X509Crl ReadDerCrl(global::Org.BouncyCastle.Asn1.Asn1InputStream dIn)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence seq = (global::Org.BouncyCastle.Asn1.Asn1Sequence)dIn.ReadObject();
			if (seq.Count > 1 && seq[0] is global::Org.BouncyCastle.Asn1.DerObjectIdentifier && seq[0].Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.SignedData))
			{
				this.sCrlData = global::Org.BouncyCastle.Asn1.Pkcs.SignedData.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1], true)).Crls;
				return this.GetCrl();
			}
			return this.CreateX509Crl(global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(seq));
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00008540 File Offset: 0x00006740
		private global::Org.BouncyCastle.X509.X509Crl GetCrl()
		{
			if (this.sCrlData == null || this.sCrlDataObjectCount >= this.sCrlData.Count)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Asn1Set asn1Set = this.sCrlData;
			int num = this.sCrlDataObjectCount;
			this.sCrlDataObjectCount = num + 1;
			return this.CreateX509Crl(global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(asn1Set[num]));
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00008591 File Offset: 0x00006791
		protected virtual global::Org.BouncyCastle.X509.X509Crl CreateX509Crl(global::Org.BouncyCastle.Asn1.X509.CertificateList c)
		{
			return new global::Org.BouncyCastle.X509.X509Crl(c);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00008599 File Offset: 0x00006799
		public global::Org.BouncyCastle.X509.X509Crl ReadCrl(byte[] input)
		{
			return this.ReadCrl(new global::System.IO.MemoryStream(input, false));
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000085A8 File Offset: 0x000067A8
		public global::System.Collections.ICollection ReadCrls(byte[] input)
		{
			return this.ReadCrls(new global::System.IO.MemoryStream(input, false));
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000085B8 File Offset: 0x000067B8
		public global::Org.BouncyCastle.X509.X509Crl ReadCrl(global::System.IO.Stream inStream)
		{
			if (inStream == null)
			{
				throw new global::System.ArgumentNullException("inStream");
			}
			if (!inStream.CanRead)
			{
				throw new global::System.ArgumentException("inStream must be read-able", "inStream");
			}
			if (this.currentCrlStream == null)
			{
				this.currentCrlStream = inStream;
				this.sCrlData = null;
				this.sCrlDataObjectCount = 0;
			}
			else if (this.currentCrlStream != inStream)
			{
				this.currentCrlStream = inStream;
				this.sCrlData = null;
				this.sCrlDataObjectCount = 0;
			}
			global::Org.BouncyCastle.X509.X509Crl result;
			try
			{
				if (this.sCrlData != null)
				{
					if (this.sCrlDataObjectCount != this.sCrlData.Count)
					{
						result = this.GetCrl();
					}
					else
					{
						this.sCrlData = null;
						this.sCrlDataObjectCount = 0;
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
							result = this.ReadPemCrl(pis);
						}
						else
						{
							global::Org.BouncyCastle.Asn1.Asn1InputStream asn = this.lazyAsn1 ? new global::Org.BouncyCastle.Asn1.LazyAsn1InputStream(pis) : new global::Org.BouncyCastle.Asn1.Asn1InputStream(pis);
							result = this.ReadDerCrl(asn);
						}
					}
				}
			}
			catch (global::Org.BouncyCastle.Security.Certificates.CrlException ex)
			{
				throw ex;
			}
			catch (global::System.Exception ex2)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CrlException(ex2.ToString());
			}
			return result;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000086D8 File Offset: 0x000068D8
		public global::System.Collections.ICollection ReadCrls(global::System.IO.Stream inStream)
		{
			global::System.Collections.IList crls = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.X509.X509Crl crl;
			while ((crl = this.ReadCrl(inStream)) != null)
			{
				crls.Add(crl);
			}
			return crls;
		}

		// Token: 0x0400009C RID: 156
		private static readonly global::Org.BouncyCastle.X509.PemParser PemCrlParser = new global::Org.BouncyCastle.X509.PemParser("CRL");

		// Token: 0x0400009D RID: 157
		private readonly bool lazyAsn1;

		// Token: 0x0400009E RID: 158
		private global::Org.BouncyCastle.Asn1.Asn1Set sCrlData;

		// Token: 0x0400009F RID: 159
		private int sCrlDataObjectCount;

		// Token: 0x040000A0 RID: 160
		private global::System.IO.Stream currentCrlStream;
	}
}
