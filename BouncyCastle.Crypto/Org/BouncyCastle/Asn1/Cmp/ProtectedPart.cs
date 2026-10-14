using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200078C RID: 1932
	public class ProtectedPart : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060044AF RID: 17583 RVA: 0x00131685 File Offset: 0x0012F885
		private ProtectedPart(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.header = global::Org.BouncyCastle.Asn1.Cmp.PkiHeader.GetInstance(seq[0]);
			this.body = global::Org.BouncyCastle.Asn1.Cmp.PkiBody.GetInstance(seq[1]);
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x001316B1 File Offset: 0x0012F8B1
		public static global::Org.BouncyCastle.Asn1.Cmp.ProtectedPart GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.ProtectedPart)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.ProtectedPart)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.ProtectedPart((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x001316F0 File Offset: 0x0012F8F0
		public ProtectedPart(global::Org.BouncyCastle.Asn1.Cmp.PkiHeader header, global::Org.BouncyCastle.Asn1.Cmp.PkiBody body)
		{
			this.header = header;
			this.body = body;
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060044B2 RID: 17586 RVA: 0x00131706 File Offset: 0x0012F906
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeader Header
		{
			get
			{
				return this.header;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060044B3 RID: 17587 RVA: 0x0013170E File Offset: 0x0012F90E
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiBody Body
		{
			get
			{
				return this.body;
			}
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x00131716 File Offset: 0x0012F916
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.header,
				this.body
			});
		}

		// Token: 0x0400214E RID: 8526
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiHeader header;

		// Token: 0x0400214F RID: 8527
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiBody body;
	}
}
