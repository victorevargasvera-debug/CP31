using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000778 RID: 1912
	public class GenRepContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600441C RID: 17436 RVA: 0x0012FFA5 File Offset: 0x0012E1A5
		private GenRepContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.content = seq;
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x0012FFB4 File Offset: 0x0012E1B4
		public static global::Org.BouncyCastle.Asn1.Cmp.GenRepContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.GenRepContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.GenRepContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.GenRepContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x0012FFF4 File Offset: 0x0012E1F4
		public GenRepContent(params global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[] itv)
		{
			this.content = new global::Org.BouncyCastle.Asn1.DerSequence(itv);
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x00130018 File Offset: 0x0012E218
		public virtual global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[] ToInfoTypeAndValueArray()
		{
			global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[] result = new global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[this.content.Count];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue.GetInstance(this.content[i]);
			}
			return result;
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x00130059 File Offset: 0x0012E259
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.content;
		}

		// Token: 0x040020CE RID: 8398
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence content;
	}
}
