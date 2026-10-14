using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000602 RID: 1538
	public class DerBmpString : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x0600395F RID: 14687 RVA: 0x0010C3C3 File Offset: 0x0010A5C3
		public static global::Org.BouncyCastle.Asn1.DerBmpString GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerBmpString)
			{
				return (global::Org.BouncyCastle.Asn1.DerBmpString)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x0010C3EC File Offset: 0x0010A5EC
		public static global::Org.BouncyCastle.Asn1.DerBmpString GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerBmpString)
			{
				return global::Org.BouncyCastle.Asn1.DerBmpString.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerBmpString(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o).GetOctets());
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x0010C424 File Offset: 0x0010A624
		[global::System.Obsolete("Will become internal")]
		public DerBmpString(byte[] str)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			int byteLen = str.Length;
			if ((byteLen & 1) != 0)
			{
				throw new global::System.ArgumentException("malformed BMPString encoding encountered", "str");
			}
			int charLen = byteLen / 2;
			char[] cs = new char[charLen];
			for (int i = 0; i != charLen; i++)
			{
				cs[i] = (char)((int)str[2 * i] << 8 | (int)(str[2 * i + 1] & byte.MaxValue));
			}
			this.str = new string(cs);
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x0010C49A File Offset: 0x0010A69A
		internal DerBmpString(char[] str)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			this.str = new string(str);
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x0010C4BC File Offset: 0x0010A6BC
		public DerBmpString(string str)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			this.str = str;
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x0010C4D9 File Offset: 0x0010A6D9
		public override string GetString()
		{
			return this.str;
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x0010C4E4 File Offset: 0x0010A6E4
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerBmpString other = asn1Object as global::Org.BouncyCastle.Asn1.DerBmpString;
			return other != null && this.str.Equals(other.str);
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x0010C50E File Offset: 0x0010A70E
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.str.Length * 2);
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x0010C524 File Offset: 0x0010A724
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			char[] c = this.str.ToCharArray();
			byte[] b = new byte[c.Length * 2];
			for (int i = 0; i != c.Length; i++)
			{
				b[2 * i] = (byte)(c[i] >> 8);
				b[2 * i + 1] = (byte)c[i];
			}
			asn1Out.WriteEncodingDL(withID, 30, b);
		}

		// Token: 0x04001984 RID: 6532
		private readonly string str;
	}
}
