using System;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000747 RID: 1863
	public class ContentInfoParser
	{
		// Token: 0x060042B2 RID: 17074 RVA: 0x0012C346 File Offset: 0x0012A546
		public ContentInfoParser(global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq)
		{
			this.contentType = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq.ReadObject();
			this.content = (global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)seq.ReadObject();
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060042B3 RID: 17075 RVA: 0x0012C370 File Offset: 0x0012A570
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType
		{
			get
			{
				return this.contentType;
			}
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x0012C378 File Offset: 0x0012A578
		public global::Org.BouncyCastle.Asn1.IAsn1Convertible GetContent(int tag)
		{
			if (this.content == null)
			{
				return null;
			}
			return this.content.GetObjectParser(tag, true);
		}

		// Token: 0x04002028 RID: 8232
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType;

		// Token: 0x04002029 RID: 8233
		private global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser content;
	}
}
