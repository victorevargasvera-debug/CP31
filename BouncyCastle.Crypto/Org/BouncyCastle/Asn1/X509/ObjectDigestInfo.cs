using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000660 RID: 1632
	public class ObjectDigestInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C57 RID: 15447 RVA: 0x00114788 File Offset: 0x00112988
		public static global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo)
			{
				return (global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x001147D5 File Offset: 0x001129D5
		public static global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x001147E3 File Offset: 0x001129E3
		public ObjectDigestInfo(int digestedObjectType, string otherObjectTypeID, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithm, byte[] objectDigest)
		{
			this.digestedObjectType = new global::Org.BouncyCastle.Asn1.DerEnumerated(digestedObjectType);
			if (digestedObjectType == 2)
			{
				this.otherObjectTypeID = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(otherObjectTypeID);
			}
			this.digestAlgorithm = digestAlgorithm;
			this.objectDigest = new global::Org.BouncyCastle.Asn1.DerBitString(objectDigest);
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x0011481C File Offset: 0x00112A1C
		private ObjectDigestInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count > 4 || seq.Count < 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.digestedObjectType = global::Org.BouncyCastle.Asn1.DerEnumerated.GetInstance(seq[0]);
			int offset = 0;
			if (seq.Count == 4)
			{
				this.otherObjectTypeID = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[1]);
				offset++;
			}
			this.digestAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[1 + offset]);
			this.objectDigest = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[2 + offset]);
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06003C5B RID: 15451 RVA: 0x001148BA File Offset: 0x00112ABA
		public global::Org.BouncyCastle.Asn1.DerEnumerated DigestedObjectType
		{
			get
			{
				return this.digestedObjectType;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06003C5C RID: 15452 RVA: 0x001148C2 File Offset: 0x00112AC2
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier OtherObjectTypeID
		{
			get
			{
				return this.otherObjectTypeID;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x001148CA File Offset: 0x00112ACA
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestAlgorithm
		{
			get
			{
				return this.digestAlgorithm;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06003C5E RID: 15454 RVA: 0x001148D2 File Offset: 0x00112AD2
		public global::Org.BouncyCastle.Asn1.DerBitString ObjectDigest
		{
			get
			{
				return this.objectDigest;
			}
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x001148DC File Offset: 0x00112ADC
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.digestedObjectType
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.otherObjectTypeID
			});
			v.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.digestAlgorithm,
				this.objectDigest
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001AA1 RID: 6817
		public const int PublicKey = 0;

		// Token: 0x04001AA2 RID: 6818
		public const int PublicKeyCert = 1;

		// Token: 0x04001AA3 RID: 6819
		public const int OtherObjectDigest = 2;

		// Token: 0x04001AA4 RID: 6820
		internal readonly global::Org.BouncyCastle.Asn1.DerEnumerated digestedObjectType;

		// Token: 0x04001AA5 RID: 6821
		internal readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier otherObjectTypeID;

		// Token: 0x04001AA6 RID: 6822
		internal readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithm;

		// Token: 0x04001AA7 RID: 6823
		internal readonly global::Org.BouncyCastle.Asn1.DerBitString objectDigest;
	}
}
