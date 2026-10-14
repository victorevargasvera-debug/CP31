using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000604 RID: 1540
	public class DerEnumerated : global::Org.BouncyCastle.Asn1.Asn1Object
	{
		// Token: 0x06003975 RID: 14709 RVA: 0x0010C700 File Offset: 0x0010A900
		public static global::Org.BouncyCastle.Asn1.DerEnumerated GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerEnumerated)
			{
				return (global::Org.BouncyCastle.Asn1.DerEnumerated)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x0010C72C File Offset: 0x0010A92C
		public static global::Org.BouncyCastle.Asn1.DerEnumerated GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerEnumerated)
			{
				return global::Org.BouncyCastle.Asn1.DerEnumerated.GetInstance(o);
			}
			return global::Org.BouncyCastle.Asn1.DerEnumerated.FromOctetString(((global::Org.BouncyCastle.Asn1.Asn1OctetString)o).GetOctets());
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x0010C762 File Offset: 0x0010A962
		public DerEnumerated(int val)
		{
			if (val < 0)
			{
				throw new global::System.ArgumentException("enumerated must be non-negative", "val");
			}
			this.bytes = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)val).ToByteArray();
			this.start = 0;
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x0010C797 File Offset: 0x0010A997
		public DerEnumerated(long val)
		{
			if (val < 0L)
			{
				throw new global::System.ArgumentException("enumerated must be non-negative", "val");
			}
			this.bytes = global::Org.BouncyCastle.Math.BigInteger.ValueOf(val).ToByteArray();
			this.start = 0;
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x0010C7CC File Offset: 0x0010A9CC
		public DerEnumerated(global::Org.BouncyCastle.Math.BigInteger val)
		{
			if (val.SignValue < 0)
			{
				throw new global::System.ArgumentException("enumerated must be non-negative", "val");
			}
			this.bytes = val.ToByteArray();
			this.start = 0;
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x0010C800 File Offset: 0x0010AA00
		public DerEnumerated(byte[] bytes)
		{
			if (global::Org.BouncyCastle.Asn1.DerInteger.IsMalformed(bytes))
			{
				throw new global::System.ArgumentException("malformed enumerated", "bytes");
			}
			if ((bytes[0] & 128) != 0)
			{
				throw new global::System.ArgumentException("enumerated must be non-negative", "bytes");
			}
			this.bytes = global::Org.BouncyCastle.Utilities.Arrays.Clone(bytes);
			this.start = global::Org.BouncyCastle.Asn1.DerInteger.SignBytesToSkip(bytes);
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x0010C85E File Offset: 0x0010AA5E
		public global::Org.BouncyCastle.Math.BigInteger Value
		{
			get
			{
				return new global::Org.BouncyCastle.Math.BigInteger(this.bytes);
			}
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x0010C86B File Offset: 0x0010AA6B
		public bool HasValue(int x)
		{
			return this.bytes.Length - this.start <= 4 && global::Org.BouncyCastle.Asn1.DerInteger.IntValue(this.bytes, this.start, -1) == x;
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x0010C896 File Offset: 0x0010AA96
		public bool HasValue(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return x != null && global::Org.BouncyCastle.Asn1.DerInteger.IntValue(this.bytes, this.start, -1) == x.IntValue && this.Value.Equals(x);
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600397E RID: 14718 RVA: 0x0010C8C3 File Offset: 0x0010AAC3
		public int IntValueExact
		{
			get
			{
				if (this.bytes.Length - this.start > 4)
				{
					throw new global::System.ArithmeticException("ASN.1 Enumerated out of int range");
				}
				return global::Org.BouncyCastle.Asn1.DerInteger.IntValue(this.bytes, this.start, -1);
			}
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x0010C8F4 File Offset: 0x0010AAF4
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.bytes.Length);
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x0010C904 File Offset: 0x0010AB04
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 10, this.bytes);
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x0010C918 File Offset: 0x0010AB18
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerEnumerated other = asn1Object as global::Org.BouncyCastle.Asn1.DerEnumerated;
			return other != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.bytes, other.bytes);
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x0010C942 File Offset: 0x0010AB42
		protected override int Asn1GetHashCode()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.bytes);
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x0010C950 File Offset: 0x0010AB50
		internal static global::Org.BouncyCastle.Asn1.DerEnumerated FromOctetString(byte[] enc)
		{
			if (enc.Length > 1)
			{
				return new global::Org.BouncyCastle.Asn1.DerEnumerated(enc);
			}
			if (enc.Length == 0)
			{
				throw new global::System.ArgumentException("ENUMERATED has zero length", "enc");
			}
			int value = (int)enc[0];
			if (value >= global::Org.BouncyCastle.Asn1.DerEnumerated.cache.Length)
			{
				return new global::Org.BouncyCastle.Asn1.DerEnumerated(enc);
			}
			global::Org.BouncyCastle.Asn1.DerEnumerated possibleMatch = global::Org.BouncyCastle.Asn1.DerEnumerated.cache[value];
			if (possibleMatch == null)
			{
				possibleMatch = (global::Org.BouncyCastle.Asn1.DerEnumerated.cache[value] = new global::Org.BouncyCastle.Asn1.DerEnumerated(enc));
			}
			return possibleMatch;
		}

		// Token: 0x04001988 RID: 6536
		private readonly byte[] bytes;

		// Token: 0x04001989 RID: 6537
		private readonly int start;

		// Token: 0x0400198A RID: 6538
		private static readonly global::Org.BouncyCastle.Asn1.DerEnumerated[] cache = new global::Org.BouncyCastle.Asn1.DerEnumerated[12];
	}
}
