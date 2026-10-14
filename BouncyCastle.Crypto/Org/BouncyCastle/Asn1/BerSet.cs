using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005F9 RID: 1529
	public class BerSet : global::Org.BouncyCastle.Asn1.DerSet
	{
		// Token: 0x06003914 RID: 14612 RVA: 0x0010B40B File Offset: 0x0010960B
		public new static global::Org.BouncyCastle.Asn1.BerSet FromVector(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector)
		{
			if (elementVector.Count >= 1)
			{
				return new global::Org.BouncyCastle.Asn1.BerSet(elementVector);
			}
			return global::Org.BouncyCastle.Asn1.BerSet.Empty;
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x0010B422 File Offset: 0x00109622
		internal new static global::Org.BouncyCastle.Asn1.BerSet FromVector(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector, bool needsSorting)
		{
			if (elementVector.Count >= 1)
			{
				return new global::Org.BouncyCastle.Asn1.BerSet(elementVector, needsSorting);
			}
			return global::Org.BouncyCastle.Asn1.BerSet.Empty;
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x0010B43A File Offset: 0x0010963A
		public BerSet()
		{
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x0010B442 File Offset: 0x00109642
		public BerSet(global::Org.BouncyCastle.Asn1.Asn1Encodable element) : base(element)
		{
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x0010B44B File Offset: 0x0010964B
		public BerSet(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector) : base(elementVector, false)
		{
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x0010B455 File Offset: 0x00109655
		internal BerSet(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector, bool needsSorting) : base(elementVector, needsSorting)
		{
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x0010B45F File Offset: 0x0010965F
		internal override int EncodedLength(bool withID)
		{
			throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("BerSet.EncodedLength");
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x0010B46B File Offset: 0x0010966B
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			if (asn1Out.IsBer)
			{
				asn1Out.WriteEncodingIL(withID, 49, this.elements);
				return;
			}
			base.Encode(asn1Out, withID);
		}

		// Token: 0x04001974 RID: 6516
		public new static readonly global::Org.BouncyCastle.Asn1.BerSet Empty = new global::Org.BouncyCastle.Asn1.BerSet();
	}
}
