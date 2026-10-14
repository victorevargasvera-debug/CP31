using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000610 RID: 1552
	public class DerOctetString : global::Org.BouncyCastle.Asn1.Asn1OctetString
	{
		// Token: 0x06003A13 RID: 14867 RVA: 0x0010E2C5 File Offset: 0x0010C4C5
		public DerOctetString(byte[] str) : base(str)
		{
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x0010E2CE File Offset: 0x0010C4CE
		public DerOctetString(global::Org.BouncyCastle.Asn1.IAsn1Convertible obj) : this(obj.ToAsn1Object())
		{
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x0010E2DC File Offset: 0x0010C4DC
		public DerOctetString(global::Org.BouncyCastle.Asn1.Asn1Encodable obj) : base(obj.GetEncoded("DER"))
		{
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x0010E2EF File Offset: 0x0010C4EF
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.str.Length);
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x0010E2FF File Offset: 0x0010C4FF
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 4, this.str);
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x0010E30F File Offset: 0x0010C50F
		internal static void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID, byte[] buf, int off, int len)
		{
			asn1Out.WriteEncodingDL(withID, 4, buf, off, len);
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x0010E31D File Offset: 0x0010C51D
		internal static int EncodedLength(bool withID, int contentsLength)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, contentsLength);
		}
	}
}
