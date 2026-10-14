using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000606 RID: 1542
	public class DerExternalParser : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003998 RID: 14744 RVA: 0x0010CD4E File Offset: 0x0010AF4E
		[global::System.Obsolete("Will be removed")]
		public DerExternalParser(global::Org.BouncyCastle.Asn1.Asn1StreamParser parser)
		{
			this._parser = parser;
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0010CD5D File Offset: 0x0010AF5D
		public global::Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
		{
			return this._parser.ReadObject();
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x0010CD6A File Offset: 0x0010AF6A
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return global::Org.BouncyCastle.Asn1.DerExternalParser.Parse(this._parser);
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x0010CD77 File Offset: 0x0010AF77
		internal static global::Org.BouncyCastle.Asn1.DerExternal Parse(global::Org.BouncyCastle.Asn1.Asn1StreamParser sp)
		{
			return new global::Org.BouncyCastle.Asn1.DerExternal(sp.ReadVector());
		}

		// Token: 0x04001990 RID: 6544
		private readonly global::Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
	}
}
