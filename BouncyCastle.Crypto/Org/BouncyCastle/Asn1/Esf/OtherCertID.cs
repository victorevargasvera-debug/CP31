using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000710 RID: 1808
	public class OtherCertID : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004128 RID: 16680 RVA: 0x00127270 File Offset: 0x00125470
		public static global::Org.BouncyCastle.Asn1.Esf.OtherCertID GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.OtherCertID)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.OtherCertID)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.OtherCertID((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'OtherCertID' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x001272C0 File Offset: 0x001254C0
		private OtherCertID(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.otherCertHash = global::Org.BouncyCastle.Asn1.Esf.OtherHash.GetInstance(seq[0].ToAsn1Object());
			if (seq.Count > 1)
			{
				this.issuerSerial = global::Org.BouncyCastle.Asn1.X509.IssuerSerial.GetInstance(seq[1].ToAsn1Object());
			}
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x0012734D File Offset: 0x0012554D
		public OtherCertID(global::Org.BouncyCastle.Asn1.Esf.OtherHash otherCertHash) : this(otherCertHash, null)
		{
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00127357 File Offset: 0x00125557
		public OtherCertID(global::Org.BouncyCastle.Asn1.Esf.OtherHash otherCertHash, global::Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial)
		{
			if (otherCertHash == null)
			{
				throw new global::System.ArgumentNullException("otherCertHash");
			}
			this.otherCertHash = otherCertHash;
			this.issuerSerial = issuerSerial;
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x0012737B File Offset: 0x0012557B
		public global::Org.BouncyCastle.Asn1.Esf.OtherHash OtherCertHash
		{
			get
			{
				return this.otherCertHash;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x0600412D RID: 16685 RVA: 0x00127383 File Offset: 0x00125583
		public global::Org.BouncyCastle.Asn1.X509.IssuerSerial IssuerSerial
		{
			get
			{
				return this.issuerSerial;
			}
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x0012738C File Offset: 0x0012558C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.otherCertHash.ToAsn1Object()
			});
			if (this.issuerSerial != null)
			{
				v.Add(this.issuerSerial.ToAsn1Object());
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F3A RID: 7994
		private readonly global::Org.BouncyCastle.Asn1.Esf.OtherHash otherCertHash;

		// Token: 0x04001F3B RID: 7995
		private readonly global::Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial;
	}
}
