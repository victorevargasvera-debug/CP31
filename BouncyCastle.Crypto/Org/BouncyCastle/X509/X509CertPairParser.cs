using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000016 RID: 22
	public class X509CertPairParser
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00007632 File Offset: 0x00005832
		private global::Org.BouncyCastle.X509.X509CertificatePair ReadDerCrossCertificatePair(global::System.IO.Stream inStream)
		{
			return new global::Org.BouncyCastle.X509.X509CertificatePair(global::Org.BouncyCastle.Asn1.X509.CertificatePair.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Sequence)new global::Org.BouncyCastle.Asn1.Asn1InputStream(inStream).ReadObject()));
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000764E File Offset: 0x0000584E
		public global::Org.BouncyCastle.X509.X509CertificatePair ReadCertPair(byte[] input)
		{
			return this.ReadCertPair(new global::System.IO.MemoryStream(input, false));
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000765D File Offset: 0x0000585D
		public global::System.Collections.ICollection ReadCertPairs(byte[] input)
		{
			return this.ReadCertPairs(new global::System.IO.MemoryStream(input, false));
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000766C File Offset: 0x0000586C
		public global::Org.BouncyCastle.X509.X509CertificatePair ReadCertPair(global::System.IO.Stream inStream)
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
			}
			else if (this.currentStream != inStream)
			{
				this.currentStream = inStream;
			}
			global::Org.BouncyCastle.X509.X509CertificatePair result;
			try
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
					result = this.ReadDerCrossCertificatePair(pis);
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateException(ex.ToString());
			}
			return result;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00007704 File Offset: 0x00005904
		public global::System.Collections.ICollection ReadCertPairs(global::System.IO.Stream inStream)
		{
			global::System.Collections.IList certPairs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.X509.X509CertificatePair certPair;
			while ((certPair = this.ReadCertPair(inStream)) != null)
			{
				certPairs.Add(certPair);
			}
			return certPairs;
		}

		// Token: 0x0400008D RID: 141
		private global::System.IO.Stream currentStream;
	}
}
