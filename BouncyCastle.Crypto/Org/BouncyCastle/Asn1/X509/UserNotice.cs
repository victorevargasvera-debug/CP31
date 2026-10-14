using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000674 RID: 1652
	public class UserNotice : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003CE9 RID: 15593 RVA: 0x00116080 File Offset: 0x00114280
		public UserNotice(global::Org.BouncyCastle.Asn1.X509.NoticeReference noticeRef, global::Org.BouncyCastle.Asn1.X509.DisplayText explicitText)
		{
			this.noticeRef = noticeRef;
			this.explicitText = explicitText;
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x00116096 File Offset: 0x00114296
		public UserNotice(global::Org.BouncyCastle.Asn1.X509.NoticeReference noticeRef, string str) : this(noticeRef, new global::Org.BouncyCastle.Asn1.X509.DisplayText(str))
		{
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x001160A8 File Offset: 0x001142A8
		[global::System.Obsolete("Use GetInstance() instead")]
		public UserNotice(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count == 2)
			{
				this.noticeRef = global::Org.BouncyCastle.Asn1.X509.NoticeReference.GetInstance(seq[0]);
				this.explicitText = global::Org.BouncyCastle.Asn1.X509.DisplayText.GetInstance(seq[1]);
				return;
			}
			if (seq.Count == 1)
			{
				if (seq[0].ToAsn1Object() is global::Org.BouncyCastle.Asn1.Asn1Sequence)
				{
					this.noticeRef = global::Org.BouncyCastle.Asn1.X509.NoticeReference.GetInstance(seq[0]);
					this.explicitText = null;
					return;
				}
				this.noticeRef = null;
				this.explicitText = global::Org.BouncyCastle.Asn1.X509.DisplayText.GetInstance(seq[0]);
				return;
			}
			else
			{
				if (seq.Count == 0)
				{
					this.noticeRef = null;
					this.explicitText = null;
					return;
				}
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x0011616D File Offset: 0x0011436D
		public static global::Org.BouncyCastle.Asn1.X509.UserNotice GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.UserNotice)
			{
				return (global::Org.BouncyCastle.Asn1.X509.UserNotice)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.UserNotice(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06003CED RID: 15597 RVA: 0x0011618E File Offset: 0x0011438E
		public virtual global::Org.BouncyCastle.Asn1.X509.NoticeReference NoticeRef
		{
			get
			{
				return this.noticeRef;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06003CEE RID: 15598 RVA: 0x00116196 File Offset: 0x00114396
		public virtual global::Org.BouncyCastle.Asn1.X509.DisplayText ExplicitText
		{
			get
			{
				return this.explicitText;
			}
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x001161A0 File Offset: 0x001143A0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.noticeRef,
				this.explicitText
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001AE2 RID: 6882
		private readonly global::Org.BouncyCastle.Asn1.X509.NoticeReference noticeRef;

		// Token: 0x04001AE3 RID: 6883
		private readonly global::Org.BouncyCastle.Asn1.X509.DisplayText explicitText;
	}
}
