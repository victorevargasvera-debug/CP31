using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005FD RID: 1533
	public class BerTaggedObjectParser : global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x06003928 RID: 14632 RVA: 0x0010B670 File Offset: 0x00109870
		[global::System.Obsolete]
		internal BerTaggedObjectParser(int baseTag, int tagNumber, global::System.IO.Stream contentStream) : this((baseTag & 32) != 0, tagNumber, new global::Org.BouncyCastle.Asn1.Asn1StreamParser(contentStream))
		{
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0010B686 File Offset: 0x00109886
		internal BerTaggedObjectParser(bool constructed, int tagNumber, global::Org.BouncyCastle.Asn1.Asn1StreamParser parser)
		{
			this._constructed = constructed;
			this._tagNumber = tagNumber;
			this._parser = parser;
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x0600392A RID: 14634 RVA: 0x0010B6A3 File Offset: 0x001098A3
		public bool IsConstructed
		{
			get
			{
				return this._constructed;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x0010B6AB File Offset: 0x001098AB
		public int TagNo
		{
			get
			{
				return this._tagNumber;
			}
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x0010B6B3 File Offset: 0x001098B3
		public global::Org.BouncyCastle.Asn1.IAsn1Convertible GetObjectParser(int tag, bool isExplicit)
		{
			if (!isExplicit)
			{
				return this._parser.ReadImplicit(this._constructed, tag);
			}
			if (!this._constructed)
			{
				throw new global::System.IO.IOException("Explicit tags must be constructed (see X.690 8.14.2)");
			}
			return this._parser.ReadObject();
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x0010B6EC File Offset: 0x001098EC
		public global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1Object result;
			try
			{
				result = this._parser.ReadTaggedObject(this._constructed, this._tagNumber);
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::Org.BouncyCastle.Asn1.Asn1ParsingException(ex.Message);
			}
			return result;
		}

		// Token: 0x04001976 RID: 6518
		private bool _constructed;

		// Token: 0x04001977 RID: 6519
		private int _tagNumber;

		// Token: 0x04001978 RID: 6520
		private global::Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
	}
}
