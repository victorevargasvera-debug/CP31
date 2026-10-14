using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Sec
{
	// Token: 0x020006A4 RID: 1700
	public class ECPrivateKeyStructure : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E64 RID: 15972 RVA: 0x0011C8CF File Offset: 0x0011AACF
		public static global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure GetInstance(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure)
			{
				return (global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure)obj;
			}
			return new global::Org.BouncyCastle.Asn1.Sec.ECPrivateKeyStructure(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x0011C8F0 File Offset: 0x0011AAF0
		[global::System.Obsolete("Use 'GetInstance' instead")]
		public ECPrivateKeyStructure(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			this.seq = seq;
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x0011C90D File Offset: 0x0011AB0D
		[global::System.Obsolete("Use constructor which takes 'orderBitLength' instead, to guarantee correct encoding")]
		public ECPrivateKeyStructure(global::Org.BouncyCastle.Math.BigInteger key)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			this.seq = new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger(1),
				new global::Org.BouncyCastle.Asn1.DerOctetString(key.ToByteArrayUnsigned())
			});
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x0011C94B File Offset: 0x0011AB4B
		public ECPrivateKeyStructure(int orderBitLength, global::Org.BouncyCastle.Math.BigInteger key) : this(orderBitLength, key, null)
		{
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x0011C956 File Offset: 0x0011AB56
		[global::System.Obsolete("Use constructor which takes 'orderBitLength' instead, to guarantee correct encoding")]
		public ECPrivateKeyStructure(global::Org.BouncyCastle.Math.BigInteger key, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters) : this(key, null, parameters)
		{
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x0011C964 File Offset: 0x0011AB64
		[global::System.Obsolete("Use constructor which takes 'orderBitLength' instead, to guarantee correct encoding")]
		public ECPrivateKeyStructure(global::Org.BouncyCastle.Math.BigInteger key, global::Org.BouncyCastle.Asn1.DerBitString publicKey, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger(1),
				new global::Org.BouncyCastle.Asn1.DerOctetString(key.ToByteArrayUnsigned())
			});
			if (parameters != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, parameters));
			}
			if (publicKey != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, publicKey));
			}
			this.seq = new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x0011C9D6 File Offset: 0x0011ABD6
		public ECPrivateKeyStructure(int orderBitLength, global::Org.BouncyCastle.Math.BigInteger key, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters) : this(orderBitLength, key, null, parameters)
		{
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x0011C9E4 File Offset: 0x0011ABE4
		public ECPrivateKeyStructure(int orderBitLength, global::Org.BouncyCastle.Math.BigInteger key, global::Org.BouncyCastle.Asn1.DerBitString publicKey, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			if (orderBitLength < key.BitLength)
			{
				throw new global::System.ArgumentException("must be >= key bitlength", "orderBitLength");
			}
			byte[] bytes = global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray((orderBitLength + 7) / 8, key);
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger(1),
				new global::Org.BouncyCastle.Asn1.DerOctetString(bytes)
			});
			if (parameters != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, parameters));
			}
			if (publicKey != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, publicKey));
			}
			this.seq = new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x0011CA78 File Offset: 0x0011AC78
		public virtual global::Org.BouncyCastle.Math.BigInteger GetKey()
		{
			global::Org.BouncyCastle.Asn1.Asn1OctetString octs = (global::Org.BouncyCastle.Asn1.Asn1OctetString)this.seq[1];
			return new global::Org.BouncyCastle.Math.BigInteger(1, octs.GetOctets());
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x0011CAA3 File Offset: 0x0011ACA3
		public virtual global::Org.BouncyCastle.Asn1.DerBitString GetPublicKey()
		{
			return (global::Org.BouncyCastle.Asn1.DerBitString)this.GetObjectInTag(1);
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x0011CAB1 File Offset: 0x0011ACB1
		public virtual global::Org.BouncyCastle.Asn1.Asn1Object GetParameters()
		{
			return this.GetObjectInTag(0);
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x0011CABC File Offset: 0x0011ACBC
		private global::Org.BouncyCastle.Asn1.Asn1Object GetObjectInTag(int tagNo)
		{
			foreach (object obj2 in this.seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object obj = ((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2).ToAsn1Object();
				if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
				{
					global::Org.BouncyCastle.Asn1.Asn1TaggedObject tag = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
					if (tag.TagNo == tagNo)
					{
						return tag.GetObject();
					}
				}
			}
			return null;
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x0011CB3C File Offset: 0x0011AD3C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.seq;
		}

		// Token: 0x04001C27 RID: 7207
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence seq;
	}
}
