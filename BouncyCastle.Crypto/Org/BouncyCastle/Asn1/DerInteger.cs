using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200060C RID: 1548
	public class DerInteger : global::Org.BouncyCastle.Asn1.Asn1Object
	{
		// Token: 0x060039D2 RID: 14802 RVA: 0x0010D718 File Offset: 0x0010B918
		internal static bool AllowUnsafe()
		{
			string allowUnsafeValue = global::Org.BouncyCastle.Utilities.Platform.GetEnvironmentVariable("Org.BouncyCastle.Asn1.AllowUnsafeInteger");
			return allowUnsafeValue != null && global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase("true", allowUnsafeValue);
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x0010D740 File Offset: 0x0010B940
		public static global::Org.BouncyCastle.Asn1.DerInteger GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				return (global::Org.BouncyCastle.Asn1.DerInteger)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x0010D76C File Offset: 0x0010B96C
		public static global::Org.BouncyCastle.Asn1.DerInteger GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			if (obj == null)
			{
				throw new global::System.ArgumentNullException("obj");
			}
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				return global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerInteger(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o).GetOctets());
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x0010D7B0 File Offset: 0x0010B9B0
		public DerInteger(int value)
		{
			this.bytes = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)value).ToByteArray();
			this.start = 0;
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x0010D7D1 File Offset: 0x0010B9D1
		public DerInteger(long value)
		{
			this.bytes = global::Org.BouncyCastle.Math.BigInteger.ValueOf(value).ToByteArray();
			this.start = 0;
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x0010D7F1 File Offset: 0x0010B9F1
		public DerInteger(global::Org.BouncyCastle.Math.BigInteger value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			this.bytes = value.ToByteArray();
			this.start = 0;
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x0010D81A File Offset: 0x0010BA1A
		public DerInteger(byte[] bytes) : this(bytes, true)
		{
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x0010D824 File Offset: 0x0010BA24
		internal DerInteger(byte[] bytes, bool clone)
		{
			if (global::Org.BouncyCastle.Asn1.DerInteger.IsMalformed(bytes))
			{
				throw new global::System.ArgumentException("malformed integer", "bytes");
			}
			this.bytes = (clone ? global::Org.BouncyCastle.Utilities.Arrays.Clone(bytes) : bytes);
			this.start = global::Org.BouncyCastle.Asn1.DerInteger.SignBytesToSkip(bytes);
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060039DA RID: 14810 RVA: 0x0010D862 File Offset: 0x0010BA62
		public global::Org.BouncyCastle.Math.BigInteger PositiveValue
		{
			get
			{
				return new global::Org.BouncyCastle.Math.BigInteger(1, this.bytes);
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060039DB RID: 14811 RVA: 0x0010D870 File Offset: 0x0010BA70
		public global::Org.BouncyCastle.Math.BigInteger Value
		{
			get
			{
				return new global::Org.BouncyCastle.Math.BigInteger(this.bytes);
			}
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x0010D87D File Offset: 0x0010BA7D
		public bool HasValue(int x)
		{
			return this.bytes.Length - this.start <= 4 && global::Org.BouncyCastle.Asn1.DerInteger.IntValue(this.bytes, this.start, -1) == x;
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x0010D8A8 File Offset: 0x0010BAA8
		public bool HasValue(long x)
		{
			return this.bytes.Length - this.start <= 8 && global::Org.BouncyCastle.Asn1.DerInteger.LongValue(this.bytes, this.start, -1) == x;
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x0010D8D3 File Offset: 0x0010BAD3
		public bool HasValue(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return x != null && global::Org.BouncyCastle.Asn1.DerInteger.IntValue(this.bytes, this.start, -1) == x.IntValue && this.Value.Equals(x);
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060039DF RID: 14815 RVA: 0x0010D900 File Offset: 0x0010BB00
		public int IntPositiveValueExact
		{
			get
			{
				int count = this.bytes.Length - this.start;
				if (count > 4 || (count == 4 && (this.bytes[this.start] & 128) != 0))
				{
					throw new global::System.ArithmeticException("ASN.1 Integer out of positive int range");
				}
				return global::Org.BouncyCastle.Asn1.DerInteger.IntValue(this.bytes, this.start, 255);
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x0010D95B File Offset: 0x0010BB5B
		public int IntValueExact
		{
			get
			{
				if (this.bytes.Length - this.start > 4)
				{
					throw new global::System.ArithmeticException("ASN.1 Integer out of int range");
				}
				return global::Org.BouncyCastle.Asn1.DerInteger.IntValue(this.bytes, this.start, -1);
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060039E1 RID: 14817 RVA: 0x0010D98C File Offset: 0x0010BB8C
		public long LongValueExact
		{
			get
			{
				if (this.bytes.Length - this.start > 8)
				{
					throw new global::System.ArithmeticException("ASN.1 Integer out of long range");
				}
				return global::Org.BouncyCastle.Asn1.DerInteger.LongValue(this.bytes, this.start, -1);
			}
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x0010D9BD File Offset: 0x0010BBBD
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.bytes.Length);
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x0010D9CD File Offset: 0x0010BBCD
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 2, this.bytes);
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x0010D9DD File Offset: 0x0010BBDD
		protected override int Asn1GetHashCode()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.bytes);
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x0010D9EC File Offset: 0x0010BBEC
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerInteger other = asn1Object as global::Org.BouncyCastle.Asn1.DerInteger;
			return other != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.bytes, other.bytes);
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x0010DA16 File Offset: 0x0010BC16
		public override string ToString()
		{
			return this.Value.ToString();
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x0010DA24 File Offset: 0x0010BC24
		internal static int IntValue(byte[] bytes, int start, int signExt)
		{
			int length = bytes.Length;
			int pos = global::System.Math.Max(start, length - 4);
			int val = (int)((sbyte)bytes[pos]) & signExt;
			while (++pos < length)
			{
				val = (val << 8 | (int)bytes[pos]);
			}
			return val;
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x0010DA5C File Offset: 0x0010BC5C
		internal static long LongValue(byte[] bytes, int start, int signExt)
		{
			int length = bytes.Length;
			int pos = global::System.Math.Max(start, length - 8);
			long val = (long)((int)((sbyte)bytes[pos]) & signExt);
			while (++pos < length)
			{
				val = (val << 8 | (long)((ulong)bytes[pos]));
			}
			return val;
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x0010DA94 File Offset: 0x0010BC94
		internal static bool IsMalformed(byte[] bytes)
		{
			int num = bytes.Length;
			return num == 0 || (num != 1 && (int)((sbyte)bytes[0]) == (sbyte)bytes[1] >> 7 && !global::Org.BouncyCastle.Asn1.DerInteger.AllowUnsafe());
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x0010DAC8 File Offset: 0x0010BCC8
		internal static int SignBytesToSkip(byte[] bytes)
		{
			int pos = 0;
			int last = bytes.Length - 1;
			while (pos < last && (int)((sbyte)bytes[pos]) == (sbyte)bytes[pos + 1] >> 7)
			{
				pos++;
			}
			return pos;
		}

		// Token: 0x04001998 RID: 6552
		public const string AllowUnsafeProperty = "Org.BouncyCastle.Asn1.AllowUnsafeInteger";

		// Token: 0x04001999 RID: 6553
		internal const int SignExtSigned = -1;

		// Token: 0x0400199A RID: 6554
		internal const int SignExtUnsigned = 255;

		// Token: 0x0400199B RID: 6555
		private readonly byte[] bytes;

		// Token: 0x0400199C RID: 6556
		private readonly int start;
	}
}
