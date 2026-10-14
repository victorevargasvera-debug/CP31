using System;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Cms;

namespace Org.BouncyCastle.Asn1.Tsp
{
	// Token: 0x0200069A RID: 1690
	public class TimeStampResp : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E29 RID: 15913 RVA: 0x0011BAA6 File Offset: 0x00119CA6
		public static global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp)
			{
				return (global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x0011BAC7 File Offset: 0x00119CC7
		private TimeStampResp(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.pkiStatusInfo = global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo.GetInstance(seq[0]);
			if (seq.Count > 1)
			{
				this.timeStampToken = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(seq[1]);
			}
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x0011BAFC File Offset: 0x00119CFC
		public TimeStampResp(global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo pkiStatusInfo, global::Org.BouncyCastle.Asn1.Cms.ContentInfo timeStampToken)
		{
			this.pkiStatusInfo = pkiStatusInfo;
			this.timeStampToken = timeStampToken;
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06003E2C RID: 15916 RVA: 0x0011BB12 File Offset: 0x00119D12
		public global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo Status
		{
			get
			{
				return this.pkiStatusInfo;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06003E2D RID: 15917 RVA: 0x0011BB1A File Offset: 0x00119D1A
		public global::Org.BouncyCastle.Asn1.Cms.ContentInfo TimeStampToken
		{
			get
			{
				return this.timeStampToken;
			}
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x0011BB24 File Offset: 0x00119D24
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.pkiStatusInfo
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.timeStampToken
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001BE5 RID: 7141
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo pkiStatusInfo;

		// Token: 0x04001BE6 RID: 7142
		private readonly global::Org.BouncyCastle.Asn1.Cms.ContentInfo timeStampToken;
	}
}
