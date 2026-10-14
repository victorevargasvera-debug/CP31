using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200076B RID: 1899
	public class CAKeyUpdAnnContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060043CF RID: 17359 RVA: 0x0012F187 File Offset: 0x0012D387
		private CAKeyUpdAnnContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.oldWithNew = global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate.GetInstance(seq[0]);
			this.newWithOld = global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate.GetInstance(seq[1]);
			this.newWithNew = global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate.GetInstance(seq[2]);
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x0012F1C5 File Offset: 0x0012D3C5
		public static global::Org.BouncyCastle.Asn1.Cmp.CAKeyUpdAnnContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.CAKeyUpdAnnContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.CAKeyUpdAnnContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.CAKeyUpdAnnContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x0012F204 File Offset: 0x0012D404
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate OldWithNew
		{
			get
			{
				return this.oldWithNew;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x060043D2 RID: 17362 RVA: 0x0012F20C File Offset: 0x0012D40C
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate NewWithOld
		{
			get
			{
				return this.newWithOld;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x0012F214 File Offset: 0x0012D414
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate NewWithNew
		{
			get
			{
				return this.newWithNew;
			}
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x0012F21C File Offset: 0x0012D41C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.oldWithNew,
				this.newWithOld,
				this.newWithNew
			});
		}

		// Token: 0x04002098 RID: 8344
		private readonly global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate oldWithNew;

		// Token: 0x04002099 RID: 8345
		private readonly global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate newWithOld;

		// Token: 0x0400209A RID: 8346
		private readonly global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate newWithNew;
	}
}
