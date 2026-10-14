using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000788 RID: 1928
	public class PollRepContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600449A RID: 17562 RVA: 0x00131354 File Offset: 0x0012F554
		private PollRepContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.certReqId = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.checkAfter = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
			if (seq.Count > 2)
			{
				this.reason = global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText.GetInstance(seq[2]);
			}
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x001313A6 File Offset: 0x0012F5A6
		public static global::Org.BouncyCastle.Asn1.Cmp.PollRepContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PollRepContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PollRepContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PollRepContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x001313E5 File Offset: 0x0012F5E5
		public PollRepContent(global::Org.BouncyCastle.Asn1.DerInteger certReqId, global::Org.BouncyCastle.Asn1.DerInteger checkAfter)
		{
			this.certReqId = certReqId;
			this.checkAfter = checkAfter;
			this.reason = null;
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x00131402 File Offset: 0x0012F602
		public PollRepContent(global::Org.BouncyCastle.Asn1.DerInteger certReqId, global::Org.BouncyCastle.Asn1.DerInteger checkAfter, global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText reason)
		{
			this.certReqId = certReqId;
			this.checkAfter = checkAfter;
			this.reason = reason;
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x0600449E RID: 17566 RVA: 0x0013141F File Offset: 0x0012F61F
		public virtual global::Org.BouncyCastle.Asn1.DerInteger CertReqID
		{
			get
			{
				return this.certReqId;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x0600449F RID: 17567 RVA: 0x00131427 File Offset: 0x0012F627
		public virtual global::Org.BouncyCastle.Asn1.DerInteger CheckAfter
		{
			get
			{
				return this.checkAfter;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060044A0 RID: 17568 RVA: 0x0013142F File Offset: 0x0012F62F
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText Reason
		{
			get
			{
				return this.reason;
			}
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x00131438 File Offset: 0x0012F638
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certReqId,
				this.checkAfter
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.reason
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04002148 RID: 8520
		private readonly global::Org.BouncyCastle.Asn1.DerInteger certReqId;

		// Token: 0x04002149 RID: 8521
		private readonly global::Org.BouncyCastle.Asn1.DerInteger checkAfter;

		// Token: 0x0400214A RID: 8522
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText reason;
	}
}
