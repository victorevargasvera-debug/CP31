using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005F6 RID: 1526
	public class BerSequence : global::Org.BouncyCastle.Asn1.DerSequence
	{
		// Token: 0x06003906 RID: 14598 RVA: 0x0010B33D File Offset: 0x0010953D
		public new static global::Org.BouncyCastle.Asn1.BerSequence FromVector(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector)
		{
			if (elementVector.Count >= 1)
			{
				return new global::Org.BouncyCastle.Asn1.BerSequence(elementVector);
			}
			return global::Org.BouncyCastle.Asn1.BerSequence.Empty;
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x0010B354 File Offset: 0x00109554
		public BerSequence()
		{
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x0010B35C File Offset: 0x0010955C
		public BerSequence(global::Org.BouncyCastle.Asn1.Asn1Encodable element) : base(element)
		{
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x0010B365 File Offset: 0x00109565
		public BerSequence(params global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements) : base(elements)
		{
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x0010B36E File Offset: 0x0010956E
		public BerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector) : base(elementVector)
		{
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x0010B377 File Offset: 0x00109577
		internal override int EncodedLength(bool withID)
		{
			throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("BerSequence.EncodedLength");
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x0010B383 File Offset: 0x00109583
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			if (asn1Out.IsBer)
			{
				asn1Out.WriteEncodingIL(withID, 48, this.elements);
				return;
			}
			base.Encode(asn1Out, withID);
		}

		// Token: 0x04001972 RID: 6514
		public new static readonly global::Org.BouncyCastle.Asn1.BerSequence Empty = new global::Org.BouncyCastle.Asn1.BerSequence();
	}
}
