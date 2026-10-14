using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005F8 RID: 1528
	public class BerSequenceParser : global::Org.BouncyCastle.Asn1.Asn1SequenceParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x06003910 RID: 14608 RVA: 0x0010B3D5 File Offset: 0x001095D5
		internal BerSequenceParser(global::Org.BouncyCastle.Asn1.Asn1StreamParser parser)
		{
			this._parser = parser;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x0010B3E4 File Offset: 0x001095E4
		public global::Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
		{
			return this._parser.ReadObject();
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x0010B3F1 File Offset: 0x001095F1
		public global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return global::Org.BouncyCastle.Asn1.BerSequenceParser.Parse(this._parser);
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x0010B3FE File Offset: 0x001095FE
		internal static global::Org.BouncyCastle.Asn1.BerSequence Parse(global::Org.BouncyCastle.Asn1.Asn1StreamParser sp)
		{
			return new global::Org.BouncyCastle.Asn1.BerSequence(sp.ReadVector());
		}

		// Token: 0x04001973 RID: 6515
		private readonly global::Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
	}
}
