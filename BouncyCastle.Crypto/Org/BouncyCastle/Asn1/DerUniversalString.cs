using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200061E RID: 1566
	public class DerUniversalString : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x06003A64 RID: 14948 RVA: 0x0010EA54 File Offset: 0x0010CC54
		public static global::Org.BouncyCastle.Asn1.DerUniversalString GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerUniversalString)
			{
				return (global::Org.BouncyCastle.Asn1.DerUniversalString)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x0010EA80 File Offset: 0x0010CC80
		public static global::Org.BouncyCastle.Asn1.DerUniversalString GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerUniversalString)
			{
				return global::Org.BouncyCastle.Asn1.DerUniversalString.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerUniversalString(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o).GetOctets());
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x0010EAB6 File Offset: 0x0010CCB6
		public DerUniversalString(byte[] str)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			this.str = str;
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x0010EAD4 File Offset: 0x0010CCD4
		public override string GetString()
		{
			global::System.Text.StringBuilder buffer = new global::System.Text.StringBuilder("#");
			byte[] enc = base.GetDerEncoded();
			for (int i = 0; i != enc.Length; i++)
			{
				uint ubyte = (uint)enc[i];
				buffer.Append(global::Org.BouncyCastle.Asn1.DerUniversalString.table[(int)(ubyte >> 4 & 15U)]);
				buffer.Append(global::Org.BouncyCastle.Asn1.DerUniversalString.table[(int)(enc[i] & 15)]);
			}
			return buffer.ToString();
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x0010EB31 File Offset: 0x0010CD31
		public byte[] GetOctets()
		{
			return (byte[])this.str.Clone();
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x0010EB43 File Offset: 0x0010CD43
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.str.Length);
		}

		// Token: 0x06003A6A RID: 14954 RVA: 0x0010EB53 File Offset: 0x0010CD53
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 28, this.str);
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x0010EB64 File Offset: 0x0010CD64
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerUniversalString other = asn1Object as global::Org.BouncyCastle.Asn1.DerUniversalString;
			return other != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.str, other.str);
		}

		// Token: 0x040019AD RID: 6573
		private static readonly char[] table = new char[]
		{
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'A',
			'B',
			'C',
			'D',
			'E',
			'F'
		};

		// Token: 0x040019AE RID: 6574
		private readonly byte[] str;
	}
}
