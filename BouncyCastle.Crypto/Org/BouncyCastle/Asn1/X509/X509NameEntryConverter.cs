using System;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000681 RID: 1665
	public abstract class X509NameEntryConverter
	{
		// Token: 0x06003D89 RID: 15753 RVA: 0x00118F1A File Offset: 0x0011711A
		protected global::Org.BouncyCastle.Asn1.Asn1Object ConvertHexEncoded(string hexString, int offset)
		{
			return global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(hexString, offset, hexString.Length - offset));
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x00118F30 File Offset: 0x00117130
		protected bool CanBePrintable(string str)
		{
			return global::Org.BouncyCastle.Asn1.DerPrintableString.IsPrintableString(str);
		}

		// Token: 0x06003D8B RID: 15755
		public abstract global::Org.BouncyCastle.Asn1.Asn1Object GetConvertedValue(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, string value);
	}
}
