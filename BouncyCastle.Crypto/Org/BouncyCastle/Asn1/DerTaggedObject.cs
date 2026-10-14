using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200061D RID: 1565
	public class DerTaggedObject : global::Org.BouncyCastle.Asn1.Asn1TaggedObject
	{
		// Token: 0x06003A5F RID: 14943 RVA: 0x0010E9A2 File Offset: 0x0010CBA2
		public DerTaggedObject(int tagNo, global::Org.BouncyCastle.Asn1.Asn1Encodable obj) : base(tagNo, obj)
		{
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x0010E9AC File Offset: 0x0010CBAC
		public DerTaggedObject(bool explicitly, int tagNo, global::Org.BouncyCastle.Asn1.Asn1Encodable obj) : base(explicitly, tagNo, obj)
		{
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x0010E9B7 File Offset: 0x0010CBB7
		public DerTaggedObject(int tagNo) : base(false, tagNo, global::Org.BouncyCastle.Asn1.DerSequence.Empty)
		{
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x0010E9C6 File Offset: 0x0010CBC6
		internal override int EncodedLength(bool withID)
		{
			throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("DerTaggedObject.EncodedLength");
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x0010E9D4 File Offset: 0x0010CBD4
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			if (base.IsEmpty())
			{
				asn1Out.WriteEncodingDL(withID, 160, this.tagNo, global::Org.BouncyCastle.Asn1.Asn1OctetString.EmptyOctets);
				return;
			}
			byte[] bytes = this.obj.GetDerEncoded();
			if (this.explicitly)
			{
				asn1Out.WriteEncodingDL(withID, 160, this.tagNo, bytes);
				return;
			}
			if (withID)
			{
				int flags = (int)((bytes[0] & 32) | 128);
				asn1Out.WriteIdentifier(true, flags, this.tagNo);
			}
			asn1Out.Write(bytes, 1, bytes.Length - 1);
		}
	}
}
