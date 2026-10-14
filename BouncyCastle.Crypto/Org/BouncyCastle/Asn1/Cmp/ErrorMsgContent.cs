using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000776 RID: 1910
	public class ErrorMsgContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600440F RID: 17423 RVA: 0x0012FDB4 File Offset: 0x0012DFB4
		private ErrorMsgContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.pkiStatusInfo = global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo.GetInstance(seq[0]);
			for (int pos = 1; pos < seq.Count; pos++)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = seq[pos];
				if (ae is global::Org.BouncyCastle.Asn1.DerInteger)
				{
					this.errorCode = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(ae);
				}
				else
				{
					this.errorDetails = global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText.GetInstance(ae);
				}
			}
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x0012FE14 File Offset: 0x0012E014
		public static global::Org.BouncyCastle.Asn1.Cmp.ErrorMsgContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.ErrorMsgContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.ErrorMsgContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.ErrorMsgContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x0012FE53 File Offset: 0x0012E053
		public ErrorMsgContent(global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo pkiStatusInfo) : this(pkiStatusInfo, null, null)
		{
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x0012FE5E File Offset: 0x0012E05E
		public ErrorMsgContent(global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo pkiStatusInfo, global::Org.BouncyCastle.Asn1.DerInteger errorCode, global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText errorDetails)
		{
			if (pkiStatusInfo == null)
			{
				throw new global::System.ArgumentNullException("pkiStatusInfo");
			}
			this.pkiStatusInfo = pkiStatusInfo;
			this.errorCode = errorCode;
			this.errorDetails = errorDetails;
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06004413 RID: 17427 RVA: 0x0012FE89 File Offset: 0x0012E089
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo PkiStatusInfo
		{
			get
			{
				return this.pkiStatusInfo;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06004414 RID: 17428 RVA: 0x0012FE91 File Offset: 0x0012E091
		public virtual global::Org.BouncyCastle.Asn1.DerInteger ErrorCode
		{
			get
			{
				return this.errorCode;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06004415 RID: 17429 RVA: 0x0012FE99 File Offset: 0x0012E099
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText ErrorDetails
		{
			get
			{
				return this.errorDetails;
			}
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x0012FEA4 File Offset: 0x0012E0A4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.pkiStatusInfo
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.errorCode,
				this.errorDetails
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x040020CA RID: 8394
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo pkiStatusInfo;

		// Token: 0x040020CB RID: 8395
		private readonly global::Org.BouncyCastle.Asn1.DerInteger errorCode;

		// Token: 0x040020CC RID: 8396
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText errorDetails;
	}
}
