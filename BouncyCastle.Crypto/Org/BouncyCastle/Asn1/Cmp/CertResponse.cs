using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000770 RID: 1904
	public class CertResponse : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060043EE RID: 17390 RVA: 0x0012F6DC File Offset: 0x0012D8DC
		private CertResponse(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.certReqId = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.status = global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo.GetInstance(seq[1]);
			if (seq.Count >= 3)
			{
				if (seq.Count == 3)
				{
					global::Org.BouncyCastle.Asn1.Asn1Encodable o = seq[2];
					if (o is global::Org.BouncyCastle.Asn1.Asn1OctetString)
					{
						this.rspInfo = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o);
						return;
					}
					this.certifiedKeyPair = global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair.GetInstance(o);
					return;
				}
				else
				{
					this.certifiedKeyPair = global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair.GetInstance(seq[2]);
					this.rspInfo = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[3]);
				}
			}
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x0012F773 File Offset: 0x0012D973
		public static global::Org.BouncyCastle.Asn1.Cmp.CertResponse GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.CertResponse)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.CertResponse)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.CertResponse((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x0012F7B2 File Offset: 0x0012D9B2
		public CertResponse(global::Org.BouncyCastle.Asn1.DerInteger certReqId, global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo status) : this(certReqId, status, null, null)
		{
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x0012F7C0 File Offset: 0x0012D9C0
		public CertResponse(global::Org.BouncyCastle.Asn1.DerInteger certReqId, global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo status, global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair certifiedKeyPair, global::Org.BouncyCastle.Asn1.Asn1OctetString rspInfo)
		{
			if (certReqId == null)
			{
				throw new global::System.ArgumentNullException("certReqId");
			}
			if (status == null)
			{
				throw new global::System.ArgumentNullException("status");
			}
			this.certReqId = certReqId;
			this.status = status;
			this.certifiedKeyPair = certifiedKeyPair;
			this.rspInfo = rspInfo;
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x060043F2 RID: 17394 RVA: 0x0012F80C File Offset: 0x0012DA0C
		public virtual global::Org.BouncyCastle.Asn1.DerInteger CertReqID
		{
			get
			{
				return this.certReqId;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x0012F814 File Offset: 0x0012DA14
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo Status
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x060043F4 RID: 17396 RVA: 0x0012F81C File Offset: 0x0012DA1C
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair CertifiedKeyPair
		{
			get
			{
				return this.certifiedKeyPair;
			}
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x0012F824 File Offset: 0x0012DA24
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certReqId,
				this.status
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certifiedKeyPair,
				this.rspInfo
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x040020A3 RID: 8355
		private readonly global::Org.BouncyCastle.Asn1.DerInteger certReqId;

		// Token: 0x040020A4 RID: 8356
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo status;

		// Token: 0x040020A5 RID: 8357
		private readonly global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair certifiedKeyPair;

		// Token: 0x040020A6 RID: 8358
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString rspInfo;
	}
}
