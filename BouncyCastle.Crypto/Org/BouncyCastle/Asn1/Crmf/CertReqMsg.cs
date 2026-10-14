using System;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000728 RID: 1832
	public class CertReqMsg : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060041C8 RID: 16840 RVA: 0x00129A88 File Offset: 0x00127C88
		private CertReqMsg(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.certReq = global::Org.BouncyCastle.Asn1.Crmf.CertRequest.GetInstance(seq[0]);
			for (int pos = 1; pos < seq.Count; pos++)
			{
				object o = seq[pos];
				if (o is global::Org.BouncyCastle.Asn1.Asn1TaggedObject || o is global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession)
				{
					this.popo = global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession.GetInstance(o);
				}
				else
				{
					this.regInfo = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(o);
				}
			}
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x00129AF0 File Offset: 0x00127CF0
		public static global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x00129B11 File Offset: 0x00127D11
		public static global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x00129B20 File Offset: 0x00127D20
		public CertReqMsg(global::Org.BouncyCastle.Asn1.Crmf.CertRequest certReq, global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession popo, global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue[] regInfo)
		{
			if (certReq == null)
			{
				throw new global::System.ArgumentNullException("certReq");
			}
			this.certReq = certReq;
			this.popo = popo;
			if (regInfo != null)
			{
				this.regInfo = new global::Org.BouncyCastle.Asn1.DerSequence(regInfo);
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060041CC RID: 16844 RVA: 0x00129B60 File Offset: 0x00127D60
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertRequest CertReq
		{
			get
			{
				return this.certReq;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x00129B68 File Offset: 0x00127D68
		public virtual global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession Popo
		{
			get
			{
				return this.popo;
			}
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x00129B70 File Offset: 0x00127D70
		public virtual global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue[] GetRegInfo()
		{
			if (this.regInfo == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue[] results = new global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue[this.regInfo.Count];
			for (int i = 0; i != results.Length; i++)
			{
				results[i] = global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue.GetInstance(this.regInfo[i]);
			}
			return results;
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x00129BBC File Offset: 0x00127DBC
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certReq
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.popo,
				this.regInfo
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001FA2 RID: 8098
		private readonly global::Org.BouncyCastle.Asn1.Crmf.CertRequest certReq;

		// Token: 0x04001FA3 RID: 8099
		private readonly global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession popo;

		// Token: 0x04001FA4 RID: 8100
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence regInfo;
	}
}
