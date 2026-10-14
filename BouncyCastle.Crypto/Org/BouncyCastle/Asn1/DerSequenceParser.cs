using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000617 RID: 1559
	public class DerSequenceParser : global::Org.BouncyCastle.Asn1.Asn1SequenceParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x06003A3C RID: 14908 RVA: 0x0010E6DD File Offset: 0x0010C8DD
		internal DerSequenceParser(global::Org.BouncyCastle.Asn1.Asn1StreamParser parser)
		{
			this._parser = parser;
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x0010E6EC File Offset: 0x0010C8EC
		public global::Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
		{
			return this._parser.ReadObject();
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x0010E6F9 File Offset: 0x0010C8F9
		public global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(this._parser.ReadVector());
		}

		// Token: 0x040019A8 RID: 6568
		private readonly global::Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
	}
}
