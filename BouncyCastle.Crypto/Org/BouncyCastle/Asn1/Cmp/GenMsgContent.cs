using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000777 RID: 1911
	public class GenMsgContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004417 RID: 17431 RVA: 0x0012FEEA File Offset: 0x0012E0EA
		private GenMsgContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.content = seq;
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x0012FEF9 File Offset: 0x0012E0F9
		public static global::Org.BouncyCastle.Asn1.Cmp.GenMsgContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.GenMsgContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.GenMsgContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.GenMsgContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x0012FF38 File Offset: 0x0012E138
		public GenMsgContent(params global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[] itv)
		{
			this.content = new global::Org.BouncyCastle.Asn1.DerSequence(itv);
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x0012FF5C File Offset: 0x0012E15C
		public virtual global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[] ToInfoTypeAndValueArray()
		{
			global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[] result = new global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[this.content.Count];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue.GetInstance(this.content[i]);
			}
			return result;
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x0012FF9D File Offset: 0x0012E19D
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.content;
		}

		// Token: 0x040020CD RID: 8397
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence content;
	}
}
