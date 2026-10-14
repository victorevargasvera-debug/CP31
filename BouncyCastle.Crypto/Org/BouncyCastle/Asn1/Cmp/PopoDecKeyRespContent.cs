using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200078B RID: 1931
	public class PopoDecKeyRespContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060044AB RID: 17579 RVA: 0x001315ED File Offset: 0x0012F7ED
		private PopoDecKeyRespContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.content = seq;
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x001315FC File Offset: 0x0012F7FC
		public static global::Org.BouncyCastle.Asn1.Cmp.PopoDecKeyRespContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PopoDecKeyRespContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PopoDecKeyRespContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PopoDecKeyRespContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x0013163C File Offset: 0x0012F83C
		public virtual global::Org.BouncyCastle.Asn1.DerInteger[] ToDerIntegerArray()
		{
			global::Org.BouncyCastle.Asn1.DerInteger[] result = new global::Org.BouncyCastle.Asn1.DerInteger[this.content.Count];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(this.content[i]);
			}
			return result;
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x0013167D File Offset: 0x0012F87D
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.content;
		}

		// Token: 0x0400214D RID: 8525
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence content;
	}
}
