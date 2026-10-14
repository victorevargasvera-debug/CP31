using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005FB RID: 1531
	public class BerSetParser : global::Org.BouncyCastle.Asn1.Asn1SetParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x0600391F RID: 14623 RVA: 0x0010B4BD File Offset: 0x001096BD
		internal BerSetParser(global::Org.BouncyCastle.Asn1.Asn1StreamParser parser)
		{
			this._parser = parser;
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x0010B4CC File Offset: 0x001096CC
		public global::Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
		{
			return this._parser.ReadObject();
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x0010B4D9 File Offset: 0x001096D9
		public global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return global::Org.BouncyCastle.Asn1.BerSetParser.Parse(this._parser);
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x0010B4E6 File Offset: 0x001096E6
		internal static global::Org.BouncyCastle.Asn1.BerSet Parse(global::Org.BouncyCastle.Asn1.Asn1StreamParser sp)
		{
			return new global::Org.BouncyCastle.Asn1.BerSet(sp.ReadVector());
		}

		// Token: 0x04001975 RID: 6517
		private readonly global::Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
	}
}
