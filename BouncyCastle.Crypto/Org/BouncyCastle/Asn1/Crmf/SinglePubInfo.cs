using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000739 RID: 1849
	public class SinglePubInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600424C RID: 16972 RVA: 0x0012AE0E File Offset: 0x0012900E
		private SinglePubInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.pubMethod = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			if (seq.Count == 2)
			{
				this.pubLocation = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(seq[1]);
			}
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x0012AE43 File Offset: 0x00129043
		public static global::Org.BouncyCastle.Asn1.Crmf.SinglePubInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.SinglePubInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.SinglePubInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.SinglePubInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600424E RID: 16974 RVA: 0x0012AE82 File Offset: 0x00129082
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralName PubLocation
		{
			get
			{
				return this.pubLocation;
			}
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x0012AE8C File Offset: 0x0012908C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.pubMethod
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.pubLocation
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001FED RID: 8173
		private readonly global::Org.BouncyCastle.Asn1.DerInteger pubMethod;

		// Token: 0x04001FEE RID: 8174
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName pubLocation;
	}
}
