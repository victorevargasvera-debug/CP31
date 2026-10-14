using System;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000760 RID: 1888
	public class ScvpReqRes : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004377 RID: 17271 RVA: 0x0012E03E File Offset: 0x0012C23E
		public static global::Org.BouncyCastle.Asn1.Cms.ScvpReqRes GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cms.ScvpReqRes)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.ScvpReqRes)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.ScvpReqRes(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x0012E060 File Offset: 0x0012C260
		private ScvpReqRes(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq[0] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.request = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[0]), true);
				this.response = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(seq[1]);
				return;
			}
			this.request = null;
			this.response = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(seq[0]);
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x0012E0C5 File Offset: 0x0012C2C5
		public ScvpReqRes(global::Org.BouncyCastle.Asn1.Cms.ContentInfo response) : this(null, response)
		{
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x0012E0CF File Offset: 0x0012C2CF
		public ScvpReqRes(global::Org.BouncyCastle.Asn1.Cms.ContentInfo request, global::Org.BouncyCastle.Asn1.Cms.ContentInfo response)
		{
			this.request = request;
			this.response = response;
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x0012E0E5 File Offset: 0x0012C2E5
		public virtual global::Org.BouncyCastle.Asn1.Cms.ContentInfo Request
		{
			get
			{
				return this.request;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x0600437C RID: 17276 RVA: 0x0012E0ED File Offset: 0x0012C2ED
		public virtual global::Org.BouncyCastle.Asn1.Cms.ContentInfo Response
		{
			get
			{
				return this.response;
			}
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x0012E0F5 File Offset: 0x0012C2F5
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(true, 0, this.request);
			asn1EncodableVector.Add(this.response);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x0400206C RID: 8300
		private readonly global::Org.BouncyCastle.Asn1.Cms.ContentInfo request;

		// Token: 0x0400206D RID: 8301
		private readonly global::Org.BouncyCastle.Asn1.Cms.ContentInfo response;
	}
}
