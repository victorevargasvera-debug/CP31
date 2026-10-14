using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200061A RID: 1562
	public class DerSetParser : global::Org.BouncyCastle.Asn1.Asn1SetParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x06003A4F RID: 14927 RVA: 0x0010E865 File Offset: 0x0010CA65
		internal DerSetParser(global::Org.BouncyCastle.Asn1.Asn1StreamParser parser)
		{
			this._parser = parser;
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x0010E874 File Offset: 0x0010CA74
		public global::Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
		{
			return this._parser.ReadObject();
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x0010E881 File Offset: 0x0010CA81
		public global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSet(this._parser.ReadVector(), false);
		}

		// Token: 0x040019AB RID: 6571
		private readonly global::Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
	}
}
