using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005EE RID: 1518
	public class BerApplicationSpecificParser : global::Org.BouncyCastle.Asn1.IAsn1ApplicationSpecificParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x060038D0 RID: 14544 RVA: 0x0010ABF6 File Offset: 0x00108DF6
		internal BerApplicationSpecificParser(int tag, global::Org.BouncyCastle.Asn1.Asn1StreamParser parser)
		{
			this.tag = tag;
			this.parser = parser;
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x0010AC0C File Offset: 0x00108E0C
		public global::Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
		{
			return this.parser.ReadObject();
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x0010AC19 File Offset: 0x00108E19
		public global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.BerApplicationSpecific(this.tag, this.parser.ReadVector());
		}

		// Token: 0x04001965 RID: 6501
		private readonly int tag;

		// Token: 0x04001966 RID: 6502
		private readonly global::Org.BouncyCastle.Asn1.Asn1StreamParser parser;
	}
}
