using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000618 RID: 1560
	public class DerSet : global::Org.BouncyCastle.Asn1.Asn1Set
	{
		// Token: 0x06003A3F RID: 14911 RVA: 0x0010E70B File Offset: 0x0010C90B
		public static global::Org.BouncyCastle.Asn1.DerSet FromVector(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector)
		{
			if (elementVector.Count >= 1)
			{
				return new global::Org.BouncyCastle.Asn1.DerSet(elementVector);
			}
			return global::Org.BouncyCastle.Asn1.DerSet.Empty;
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x0010E722 File Offset: 0x0010C922
		internal static global::Org.BouncyCastle.Asn1.DerSet FromVector(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector, bool needsSorting)
		{
			if (elementVector.Count >= 1)
			{
				return new global::Org.BouncyCastle.Asn1.DerSet(elementVector, needsSorting);
			}
			return global::Org.BouncyCastle.Asn1.DerSet.Empty;
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x0010E73A File Offset: 0x0010C93A
		public DerSet()
		{
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x0010E742 File Offset: 0x0010C942
		public DerSet(global::Org.BouncyCastle.Asn1.Asn1Encodable element) : base(element)
		{
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x0010E74B File Offset: 0x0010C94B
		public DerSet(params global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements) : base(elements)
		{
			base.Sort();
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x0010E75A File Offset: 0x0010C95A
		public DerSet(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector) : this(elementVector, true)
		{
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x0010E764 File Offset: 0x0010C964
		internal DerSet(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector, bool needsSorting) : base(elementVector)
		{
			if (needsSorting)
			{
				base.Sort();
			}
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x0010E776 File Offset: 0x0010C976
		internal override int EncodedLength(bool withID)
		{
			throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("DerSet.EncodedLength");
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x0010E784 File Offset: 0x0010C984
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			if (this.Count < 1)
			{
				asn1Out.WriteEncodingDL(withID, 49, global::Org.BouncyCastle.Asn1.Asn1OctetString.EmptyOctets);
				return;
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Asn1.Asn1OutputStream dOut = global::Org.BouncyCastle.Asn1.Asn1OutputStream.Create(memoryStream, "DER");
			dOut.WriteElements(this.elements);
			dOut.Flush();
			byte[] bytes = memoryStream.GetBuffer();
			int length = (int)memoryStream.Position;
			asn1Out.WriteEncodingDL(withID, 49, bytes, 0, length);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(dOut);
		}

		// Token: 0x040019A9 RID: 6569
		public static readonly global::Org.BouncyCastle.Asn1.DerSet Empty = new global::Org.BouncyCastle.Asn1.DerSet();
	}
}
