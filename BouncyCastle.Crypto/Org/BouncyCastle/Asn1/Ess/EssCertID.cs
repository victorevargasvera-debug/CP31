using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ess
{
	// Token: 0x020006FC RID: 1788
	public class EssCertID : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040A7 RID: 16551 RVA: 0x00125478 File Offset: 0x00123678
		public static global::Org.BouncyCastle.Asn1.Ess.EssCertID GetInstance(object o)
		{
			if (o == null || o is global::Org.BouncyCastle.Asn1.Ess.EssCertID)
			{
				return (global::Org.BouncyCastle.Asn1.Ess.EssCertID)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ess.EssCertID((global::Org.BouncyCastle.Asn1.Asn1Sequence)o);
			}
			throw new global::System.ArgumentException("unknown object in 'EssCertID' factory : " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o) + ".");
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x001254C8 File Offset: 0x001236C8
		public EssCertID(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.certHash = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]);
			if (seq.Count > 1)
			{
				this.issuerSerial = global::Org.BouncyCastle.Asn1.X509.IssuerSerial.GetInstance(seq[1]);
			}
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x00125538 File Offset: 0x00123738
		public EssCertID(byte[] hash)
		{
			this.certHash = new global::Org.BouncyCastle.Asn1.DerOctetString(hash);
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x0012554C File Offset: 0x0012374C
		public EssCertID(byte[] hash, global::Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial)
		{
			this.certHash = new global::Org.BouncyCastle.Asn1.DerOctetString(hash);
			this.issuerSerial = issuerSerial;
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x00125567 File Offset: 0x00123767
		public byte[] GetCertHash()
		{
			return this.certHash.GetOctets();
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060040AC RID: 16556 RVA: 0x00125574 File Offset: 0x00123774
		public global::Org.BouncyCastle.Asn1.X509.IssuerSerial IssuerSerial
		{
			get
			{
				return this.issuerSerial;
			}
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x0012557C File Offset: 0x0012377C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certHash
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.issuerSerial
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F03 RID: 7939
		private global::Org.BouncyCastle.Asn1.Asn1OctetString certHash;

		// Token: 0x04001F04 RID: 7940
		private global::Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial;
	}
}
