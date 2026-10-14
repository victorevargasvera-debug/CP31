using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001E7 RID: 487
	public class RespData : global::Org.BouncyCastle.X509.X509ExtensionBase
	{
		// Token: 0x060011EC RID: 4588 RVA: 0x0004F2D2 File Offset: 0x0004D4D2
		public RespData(global::Org.BouncyCastle.Asn1.Ocsp.ResponseData data)
		{
			this.data = data;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x0004F2E1 File Offset: 0x0004D4E1
		public int Version
		{
			get
			{
				return this.data.Version.IntValueExact + 1;
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0004F2F5 File Offset: 0x0004D4F5
		public global::Org.BouncyCastle.Ocsp.RespID GetResponderId()
		{
			return new global::Org.BouncyCastle.Ocsp.RespID(this.data.ResponderID);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x0004F307 File Offset: 0x0004D507
		public global::System.DateTime ProducedAt
		{
			get
			{
				return this.data.ProducedAt.ToDateTime();
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0004F31C File Offset: 0x0004D51C
		public global::Org.BouncyCastle.Ocsp.SingleResp[] GetResponses()
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence s = this.data.Responses;
			global::Org.BouncyCastle.Ocsp.SingleResp[] rs = new global::Org.BouncyCastle.Ocsp.SingleResp[s.Count];
			for (int i = 0; i != rs.Length; i++)
			{
				rs[i] = new global::Org.BouncyCastle.Ocsp.SingleResp(global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse.GetInstance(s[i]));
			}
			return rs;
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0004F364 File Offset: 0x0004D564
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions ResponseExtensions
		{
			get
			{
				return this.data.ResponseExtensions;
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0004F371 File Offset: 0x0004D571
		protected override global::Org.BouncyCastle.Asn1.X509.X509Extensions GetX509Extensions()
		{
			return this.ResponseExtensions;
		}

		// Token: 0x040008FD RID: 2301
		internal readonly global::Org.BouncyCastle.Asn1.Ocsp.ResponseData data;
	}
}
