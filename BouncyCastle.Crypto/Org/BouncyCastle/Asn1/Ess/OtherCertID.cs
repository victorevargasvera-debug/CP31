using System;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ess
{
	// Token: 0x020006FE RID: 1790
	[global::System.Obsolete("Use version in Asn1.Esf instead")]
	public class OtherCertID : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040B9 RID: 16569 RVA: 0x00125784 File Offset: 0x00123984
		public static global::Org.BouncyCastle.Asn1.Ess.OtherCertID GetInstance(object o)
		{
			if (o == null || o is global::Org.BouncyCastle.Asn1.Ess.OtherCertID)
			{
				return (global::Org.BouncyCastle.Asn1.Ess.OtherCertID)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ess.OtherCertID((global::Org.BouncyCastle.Asn1.Asn1Sequence)o);
			}
			throw new global::System.ArgumentException("unknown object in 'OtherCertID' factory : " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o) + ".");
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x001257D4 File Offset: 0x001239D4
		public OtherCertID(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			if (seq[0].ToAsn1Object() is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				this.otherCertHash = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]);
			}
			else
			{
				this.otherCertHash = global::Org.BouncyCastle.Asn1.X509.DigestInfo.GetInstance(seq[0]);
			}
			if (seq.Count > 1)
			{
				this.issuerSerial = global::Org.BouncyCastle.Asn1.X509.IssuerSerial.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[1]));
			}
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x00125870 File Offset: 0x00123A70
		public OtherCertID(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId, byte[] digest)
		{
			this.otherCertHash = new global::Org.BouncyCastle.Asn1.X509.DigestInfo(algId, digest);
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x00125885 File Offset: 0x00123A85
		public OtherCertID(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId, byte[] digest, global::Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial)
		{
			this.otherCertHash = new global::Org.BouncyCastle.Asn1.X509.DigestInfo(algId, digest);
			this.issuerSerial = issuerSerial;
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060040BD RID: 16573 RVA: 0x001258A1 File Offset: 0x00123AA1
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmHash
		{
			get
			{
				if (this.otherCertHash.ToAsn1Object() is global::Org.BouncyCastle.Asn1.Asn1OctetString)
				{
					return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1);
				}
				return global::Org.BouncyCastle.Asn1.X509.DigestInfo.GetInstance(this.otherCertHash).AlgorithmID;
			}
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x001258D0 File Offset: 0x00123AD0
		public byte[] GetCertHash()
		{
			if (this.otherCertHash.ToAsn1Object() is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				return ((global::Org.BouncyCastle.Asn1.Asn1OctetString)this.otherCertHash.ToAsn1Object()).GetOctets();
			}
			return global::Org.BouncyCastle.Asn1.X509.DigestInfo.GetInstance(this.otherCertHash).GetDigest();
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060040BF RID: 16575 RVA: 0x0012590A File Offset: 0x00123B0A
		public global::Org.BouncyCastle.Asn1.X509.IssuerSerial IssuerSerial
		{
			get
			{
				return this.issuerSerial;
			}
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x00125914 File Offset: 0x00123B14
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.otherCertHash
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.issuerSerial
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F09 RID: 7945
		private global::Org.BouncyCastle.Asn1.Asn1Encodable otherCertHash;

		// Token: 0x04001F0A RID: 7946
		private global::Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial;
	}
}
