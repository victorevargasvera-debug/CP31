using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x0200070F RID: 1807
	public class OcspResponsesID : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004121 RID: 16673 RVA: 0x0012710C File Offset: 0x0012530C
		public static global::Org.BouncyCastle.Asn1.Esf.OcspResponsesID GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.OcspResponsesID)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.OcspResponsesID)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.OcspResponsesID((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'OcspResponsesID' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x0012715C File Offset: 0x0012535C
		private OcspResponsesID(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.ocspIdentifier = global::Org.BouncyCastle.Asn1.Esf.OcspIdentifier.GetInstance(seq[0].ToAsn1Object());
			if (seq.Count > 1)
			{
				this.ocspRepHash = global::Org.BouncyCastle.Asn1.Esf.OtherHash.GetInstance(seq[1].ToAsn1Object());
			}
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x001271E9 File Offset: 0x001253E9
		public OcspResponsesID(global::Org.BouncyCastle.Asn1.Esf.OcspIdentifier ocspIdentifier) : this(ocspIdentifier, null)
		{
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x001271F3 File Offset: 0x001253F3
		public OcspResponsesID(global::Org.BouncyCastle.Asn1.Esf.OcspIdentifier ocspIdentifier, global::Org.BouncyCastle.Asn1.Esf.OtherHash ocspRepHash)
		{
			if (ocspIdentifier == null)
			{
				throw new global::System.ArgumentNullException("ocspIdentifier");
			}
			this.ocspIdentifier = ocspIdentifier;
			this.ocspRepHash = ocspRepHash;
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x00127217 File Offset: 0x00125417
		public global::Org.BouncyCastle.Asn1.Esf.OcspIdentifier OcspIdentifier
		{
			get
			{
				return this.ocspIdentifier;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06004126 RID: 16678 RVA: 0x0012721F File Offset: 0x0012541F
		public global::Org.BouncyCastle.Asn1.Esf.OtherHash OcspRepHash
		{
			get
			{
				return this.ocspRepHash;
			}
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x00127228 File Offset: 0x00125428
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.ocspIdentifier.ToAsn1Object()
			});
			if (this.ocspRepHash != null)
			{
				v.Add(this.ocspRepHash.ToAsn1Object());
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F38 RID: 7992
		private readonly global::Org.BouncyCastle.Asn1.Esf.OcspIdentifier ocspIdentifier;

		// Token: 0x04001F39 RID: 7993
		private readonly global::Org.BouncyCastle.Asn1.Esf.OtherHash ocspRepHash;
	}
}
