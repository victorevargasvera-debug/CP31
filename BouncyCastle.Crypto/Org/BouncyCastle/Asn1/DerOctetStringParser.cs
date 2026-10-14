using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000611 RID: 1553
	public class DerOctetStringParser : global::Org.BouncyCastle.Asn1.Asn1OctetStringParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x06003A1A RID: 14874 RVA: 0x0010E326 File Offset: 0x0010C526
		internal DerOctetStringParser(global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream stream)
		{
			this.stream = stream;
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x0010E335 File Offset: 0x0010C535
		public global::System.IO.Stream GetOctetStream()
		{
			return this.stream;
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x0010E340 File Offset: 0x0010C540
		public global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1Object result;
			try
			{
				result = new global::Org.BouncyCastle.Asn1.DerOctetString(this.stream.ToArray());
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::System.InvalidOperationException("IOException converting stream to byte array: " + e.Message, e);
			}
			return result;
		}

		// Token: 0x040019A4 RID: 6564
		private readonly global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream stream;
	}
}
