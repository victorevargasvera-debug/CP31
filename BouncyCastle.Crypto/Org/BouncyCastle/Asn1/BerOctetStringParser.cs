using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005F4 RID: 1524
	public class BerOctetStringParser : global::Org.BouncyCastle.Asn1.Asn1OctetStringParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x060038FF RID: 14591 RVA: 0x0010B29C File Offset: 0x0010949C
		internal BerOctetStringParser(global::Org.BouncyCastle.Asn1.Asn1StreamParser parser)
		{
			this._parser = parser;
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x0010B2AB File Offset: 0x001094AB
		public global::System.IO.Stream GetOctetStream()
		{
			return new global::Org.BouncyCastle.Asn1.ConstructedOctetStream(this._parser);
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x0010B2B8 File Offset: 0x001094B8
		public global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1Object result;
			try
			{
				result = global::Org.BouncyCastle.Asn1.BerOctetStringParser.Parse(this._parser);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Asn1.Asn1ParsingException("IOException converting stream to byte array: " + e.Message, e);
			}
			return result;
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x0010B2FC File Offset: 0x001094FC
		internal static global::Org.BouncyCastle.Asn1.BerOctetString Parse(global::Org.BouncyCastle.Asn1.Asn1StreamParser sp)
		{
			return new global::Org.BouncyCastle.Asn1.BerOctetString(global::Org.BouncyCastle.Utilities.IO.Streams.ReadAll(new global::Org.BouncyCastle.Asn1.ConstructedOctetStream(sp)));
		}

		// Token: 0x04001971 RID: 6513
		private readonly global::Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
	}
}
