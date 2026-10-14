using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000678 RID: 1656
	public class V2TbsCertListGenerator
	{
		// Token: 0x06003D13 RID: 15635 RVA: 0x00116622 File Offset: 0x00114822
		public void SetSignature(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature)
		{
			this.signature = signature;
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x0011662B File Offset: 0x0011482B
		public void SetIssuer(global::Org.BouncyCastle.Asn1.X509.X509Name issuer)
		{
			this.issuer = issuer;
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x00116634 File Offset: 0x00114834
		public void SetThisUpdate(global::Org.BouncyCastle.Asn1.DerUtcTime thisUpdate)
		{
			this.thisUpdate = new global::Org.BouncyCastle.Asn1.X509.Time(thisUpdate);
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x00116642 File Offset: 0x00114842
		public void SetNextUpdate(global::Org.BouncyCastle.Asn1.DerUtcTime nextUpdate)
		{
			this.nextUpdate = ((nextUpdate != null) ? new global::Org.BouncyCastle.Asn1.X509.Time(nextUpdate) : null);
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x00116656 File Offset: 0x00114856
		public void SetThisUpdate(global::Org.BouncyCastle.Asn1.X509.Time thisUpdate)
		{
			this.thisUpdate = thisUpdate;
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x0011665F File Offset: 0x0011485F
		public void SetNextUpdate(global::Org.BouncyCastle.Asn1.X509.Time nextUpdate)
		{
			this.nextUpdate = nextUpdate;
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x00116668 File Offset: 0x00114868
		public void AddCrlEntry(global::Org.BouncyCastle.Asn1.Asn1Sequence crlEntry)
		{
			if (this.crlEntries == null)
			{
				this.crlEntries = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			}
			this.crlEntries.Add(crlEntry);
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x0011668A File Offset: 0x0011488A
		public void AddCrlEntry(global::Org.BouncyCastle.Asn1.DerInteger userCertificate, global::Org.BouncyCastle.Asn1.DerUtcTime revocationDate, int reason)
		{
			this.AddCrlEntry(userCertificate, new global::Org.BouncyCastle.Asn1.X509.Time(revocationDate), reason);
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x0011669A File Offset: 0x0011489A
		public void AddCrlEntry(global::Org.BouncyCastle.Asn1.DerInteger userCertificate, global::Org.BouncyCastle.Asn1.X509.Time revocationDate, int reason)
		{
			this.AddCrlEntry(userCertificate, revocationDate, reason, null);
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x001166A8 File Offset: 0x001148A8
		public void AddCrlEntry(global::Org.BouncyCastle.Asn1.DerInteger userCertificate, global::Org.BouncyCastle.Asn1.X509.Time revocationDate, int reason, global::Org.BouncyCastle.Asn1.DerGeneralizedTime invalidityDate)
		{
			global::System.Collections.IList extOids = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::System.Collections.IList extValues = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (reason != 0)
			{
				global::Org.BouncyCastle.Asn1.X509.CrlReason crlReason = new global::Org.BouncyCastle.Asn1.X509.CrlReason(reason);
				try
				{
					extOids.Add(global::Org.BouncyCastle.Asn1.X509.X509Extensions.ReasonCode);
					extValues.Add(new global::Org.BouncyCastle.Asn1.X509.X509Extension(false, new global::Org.BouncyCastle.Asn1.DerOctetString(crlReason.GetEncoded())));
				}
				catch (global::System.IO.IOException e)
				{
					string str = "error encoding reason: ";
					global::System.IO.IOException ex = e;
					throw new global::System.ArgumentException(str + ((ex != null) ? ex.ToString() : null));
				}
			}
			if (invalidityDate != null)
			{
				try
				{
					extOids.Add(global::Org.BouncyCastle.Asn1.X509.X509Extensions.InvalidityDate);
					extValues.Add(new global::Org.BouncyCastle.Asn1.X509.X509Extension(false, new global::Org.BouncyCastle.Asn1.DerOctetString(invalidityDate.GetEncoded())));
				}
				catch (global::System.IO.IOException e2)
				{
					string str2 = "error encoding invalidityDate: ";
					global::System.IO.IOException ex2 = e2;
					throw new global::System.ArgumentException(str2 + ((ex2 != null) ? ex2.ToString() : null));
				}
			}
			if (extOids.Count != 0)
			{
				this.AddCrlEntry(userCertificate, revocationDate, new global::Org.BouncyCastle.Asn1.X509.X509Extensions(extOids, extValues));
				return;
			}
			this.AddCrlEntry(userCertificate, revocationDate, null);
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x00116798 File Offset: 0x00114998
		public void AddCrlEntry(global::Org.BouncyCastle.Asn1.DerInteger userCertificate, global::Org.BouncyCastle.Asn1.X509.Time revocationDate, global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				userCertificate,
				revocationDate
			});
			if (extensions != null)
			{
				v.Add(extensions);
			}
			this.AddCrlEntry(new global::Org.BouncyCastle.Asn1.DerSequence(v));
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x001167CF File Offset: 0x001149CF
		public void SetExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			this.extensions = extensions;
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x001167D8 File Offset: 0x001149D8
		public global::Org.BouncyCastle.Asn1.X509.TbsCertificateList GenerateTbsCertList()
		{
			if (this.signature == null || this.issuer == null || this.thisUpdate == null)
			{
				throw new global::System.InvalidOperationException("Not all mandatory fields set in V2 TbsCertList generator.");
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.signature,
				this.issuer,
				this.thisUpdate
			});
			if (this.nextUpdate != null)
			{
				v.Add(this.nextUpdate);
			}
			if (this.crlEntries != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence[] certs = new global::Org.BouncyCastle.Asn1.Asn1Sequence[this.crlEntries.Count];
				for (int i = 0; i < this.crlEntries.Count; i++)
				{
					certs[i] = (global::Org.BouncyCastle.Asn1.Asn1Sequence)this.crlEntries[i];
				}
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = v;
				global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements = certs;
				asn1EncodableVector.Add(new global::Org.BouncyCastle.Asn1.DerSequence(elements));
			}
			if (this.extensions != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(0, this.extensions));
			}
			return new global::Org.BouncyCastle.Asn1.X509.TbsCertificateList(new global::Org.BouncyCastle.Asn1.DerSequence(v));
		}

		// Token: 0x04001AF9 RID: 6905
		private global::Org.BouncyCastle.Asn1.DerInteger version = new global::Org.BouncyCastle.Asn1.DerInteger(1);

		// Token: 0x04001AFA RID: 6906
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature;

		// Token: 0x04001AFB RID: 6907
		private global::Org.BouncyCastle.Asn1.X509.X509Name issuer;

		// Token: 0x04001AFC RID: 6908
		private global::Org.BouncyCastle.Asn1.X509.Time thisUpdate;

		// Token: 0x04001AFD RID: 6909
		private global::Org.BouncyCastle.Asn1.X509.Time nextUpdate;

		// Token: 0x04001AFE RID: 6910
		private global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;

		// Token: 0x04001AFF RID: 6911
		private global::System.Collections.IList crlEntries;
	}
}
