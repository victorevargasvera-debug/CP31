using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200076C RID: 1900
	public class CertConfirmContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060043D5 RID: 17365 RVA: 0x0012F244 File Offset: 0x0012D444
		private CertConfirmContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.content = seq;
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x0012F253 File Offset: 0x0012D453
		public static global::Org.BouncyCastle.Asn1.Cmp.CertConfirmContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.CertConfirmContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.CertConfirmContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.CertConfirmContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x0012F294 File Offset: 0x0012D494
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CertStatus[] ToCertStatusArray()
		{
			global::Org.BouncyCastle.Asn1.Cmp.CertStatus[] result = new global::Org.BouncyCastle.Asn1.Cmp.CertStatus[this.content.Count];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Cmp.CertStatus.GetInstance(this.content[i]);
			}
			return result;
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x0012F2D5 File Offset: 0x0012D4D5
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.content;
		}

		// Token: 0x0400209B RID: 8347
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence content;
	}
}
