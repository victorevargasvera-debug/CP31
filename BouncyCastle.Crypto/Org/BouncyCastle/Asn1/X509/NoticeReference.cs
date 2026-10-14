using System;
using System.Collections;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200065F RID: 1631
	public class NoticeReference : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C4E RID: 15438 RVA: 0x001145CC File Offset: 0x001127CC
		private static global::Org.BouncyCastle.Asn1.Asn1EncodableVector ConvertVector(global::System.Collections.IList numbers)
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector av = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object o in numbers)
			{
				global::Org.BouncyCastle.Asn1.DerInteger di;
				if (o is global::Org.BouncyCastle.Math.BigInteger)
				{
					di = new global::Org.BouncyCastle.Asn1.DerInteger((global::Org.BouncyCastle.Math.BigInteger)o);
				}
				else
				{
					if (!(o is int))
					{
						throw new global::System.ArgumentException();
					}
					di = new global::Org.BouncyCastle.Asn1.DerInteger((int)o);
				}
				av.Add(di);
			}
			return av;
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x00114658 File Offset: 0x00112858
		public NoticeReference(string organization, global::System.Collections.IList numbers) : this(organization, global::Org.BouncyCastle.Asn1.X509.NoticeReference.ConvertVector(numbers))
		{
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x00114667 File Offset: 0x00112867
		public NoticeReference(string organization, global::Org.BouncyCastle.Asn1.Asn1EncodableVector noticeNumbers) : this(new global::Org.BouncyCastle.Asn1.X509.DisplayText(organization), noticeNumbers)
		{
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x00114676 File Offset: 0x00112876
		public NoticeReference(global::Org.BouncyCastle.Asn1.X509.DisplayText organization, global::Org.BouncyCastle.Asn1.Asn1EncodableVector noticeNumbers)
		{
			this.organization = organization;
			this.noticeNumbers = new global::Org.BouncyCastle.Asn1.DerSequence(noticeNumbers);
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x00114694 File Offset: 0x00112894
		private NoticeReference(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.organization = global::Org.BouncyCastle.Asn1.X509.DisplayText.GetInstance(seq[0]);
			this.noticeNumbers = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[1]);
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x001146F7 File Offset: 0x001128F7
		public static global::Org.BouncyCastle.Asn1.X509.NoticeReference GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.NoticeReference)
			{
				return (global::Org.BouncyCastle.Asn1.X509.NoticeReference)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.NoticeReference(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x00114718 File Offset: 0x00112918
		public virtual global::Org.BouncyCastle.Asn1.X509.DisplayText Organization
		{
			get
			{
				return this.organization;
			}
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x00114720 File Offset: 0x00112920
		public virtual global::Org.BouncyCastle.Asn1.DerInteger[] GetNoticeNumbers()
		{
			global::Org.BouncyCastle.Asn1.DerInteger[] tmp = new global::Org.BouncyCastle.Asn1.DerInteger[this.noticeNumbers.Count];
			for (int i = 0; i != this.noticeNumbers.Count; i++)
			{
				tmp[i] = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(this.noticeNumbers[i]);
			}
			return tmp;
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x00114769 File Offset: 0x00112969
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.organization,
				this.noticeNumbers
			});
		}

		// Token: 0x04001A9F RID: 6815
		private readonly global::Org.BouncyCastle.Asn1.X509.DisplayText organization;

		// Token: 0x04001AA0 RID: 6816
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence noticeNumbers;
	}
}
