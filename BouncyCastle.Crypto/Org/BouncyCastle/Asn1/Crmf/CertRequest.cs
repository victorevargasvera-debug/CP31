using System;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000729 RID: 1833
	public class CertRequest : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060041D0 RID: 16848 RVA: 0x00129C04 File Offset: 0x00127E04
		private CertRequest(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.certReqId = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.certTemplate = global::Org.BouncyCastle.Asn1.Crmf.CertTemplate.GetInstance(seq[1]);
			if (seq.Count > 2)
			{
				this.controls = global::Org.BouncyCastle.Asn1.Crmf.Controls.GetInstance(seq[2]);
			}
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x00129C56 File Offset: 0x00127E56
		public static global::Org.BouncyCastle.Asn1.Crmf.CertRequest GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.CertRequest)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.CertRequest)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.CertRequest(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x00129C77 File Offset: 0x00127E77
		public CertRequest(int certReqId, global::Org.BouncyCastle.Asn1.Crmf.CertTemplate certTemplate, global::Org.BouncyCastle.Asn1.Crmf.Controls controls) : this(new global::Org.BouncyCastle.Asn1.DerInteger(certReqId), certTemplate, controls)
		{
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x00129C87 File Offset: 0x00127E87
		public CertRequest(global::Org.BouncyCastle.Asn1.DerInteger certReqId, global::Org.BouncyCastle.Asn1.Crmf.CertTemplate certTemplate, global::Org.BouncyCastle.Asn1.Crmf.Controls controls)
		{
			this.certReqId = certReqId;
			this.certTemplate = certTemplate;
			this.controls = controls;
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060041D4 RID: 16852 RVA: 0x00129CA4 File Offset: 0x00127EA4
		public virtual global::Org.BouncyCastle.Asn1.DerInteger CertReqID
		{
			get
			{
				return this.certReqId;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x00129CAC File Offset: 0x00127EAC
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplate CertTemplate
		{
			get
			{
				return this.certTemplate;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060041D6 RID: 16854 RVA: 0x00129CB4 File Offset: 0x00127EB4
		public virtual global::Org.BouncyCastle.Asn1.Crmf.Controls Controls
		{
			get
			{
				return this.controls;
			}
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x00129CBC File Offset: 0x00127EBC
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certReqId,
				this.certTemplate
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.controls
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001FA5 RID: 8101
		private readonly global::Org.BouncyCastle.Asn1.DerInteger certReqId;

		// Token: 0x04001FA6 RID: 8102
		private readonly global::Org.BouncyCastle.Asn1.Crmf.CertTemplate certTemplate;

		// Token: 0x04001FA7 RID: 8103
		private readonly global::Org.BouncyCastle.Asn1.Crmf.Controls controls;
	}
}
