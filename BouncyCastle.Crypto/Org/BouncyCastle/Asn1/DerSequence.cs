using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000615 RID: 1557
	public class DerSequence : global::Org.BouncyCastle.Asn1.Asn1Sequence
	{
		// Token: 0x06003A2E RID: 14894 RVA: 0x0010E5B4 File Offset: 0x0010C7B4
		public static global::Org.BouncyCastle.Asn1.DerSequence FromVector(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector)
		{
			if (elementVector.Count >= 1)
			{
				return new global::Org.BouncyCastle.Asn1.DerSequence(elementVector);
			}
			return global::Org.BouncyCastle.Asn1.DerSequence.Empty;
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x0010E5CB File Offset: 0x0010C7CB
		public DerSequence()
		{
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x0010E5D3 File Offset: 0x0010C7D3
		public DerSequence(global::Org.BouncyCastle.Asn1.Asn1Encodable element) : base(element)
		{
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x0010E5DC File Offset: 0x0010C7DC
		public DerSequence(params global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements) : base(elements)
		{
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x0010E5E5 File Offset: 0x0010C7E5
		public DerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector) : base(elementVector)
		{
		}

		// Token: 0x06003A33 RID: 14899 RVA: 0x0010E5EE File Offset: 0x0010C7EE
		internal override int EncodedLength(bool withID)
		{
			throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("DerSequence.EncodedLength");
		}

		// Token: 0x06003A34 RID: 14900 RVA: 0x0010E5FC File Offset: 0x0010C7FC
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			if (this.Count < 1)
			{
				asn1Out.WriteEncodingDL(withID, 48, global::Org.BouncyCastle.Asn1.Asn1OctetString.EmptyOctets);
				return;
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Asn1.Asn1OutputStream dOut = global::Org.BouncyCastle.Asn1.Asn1OutputStream.Create(memoryStream, "DER");
			dOut.WriteElements(this.elements);
			dOut.Flush();
			byte[] bytes = memoryStream.GetBuffer();
			int length = (int)memoryStream.Position;
			asn1Out.WriteEncodingDL(withID, 48, bytes, 0, length);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(dOut);
		}

		// Token: 0x040019A6 RID: 6566
		public static readonly global::Org.BouncyCastle.Asn1.DerSequence Empty = new global::Org.BouncyCastle.Asn1.DerSequence();
	}
}
