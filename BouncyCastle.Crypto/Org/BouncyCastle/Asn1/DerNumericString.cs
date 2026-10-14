using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200060E RID: 1550
	public class DerNumericString : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x060039F1 RID: 14833 RVA: 0x0010DB3B File Offset: 0x0010BD3B
		public static global::Org.BouncyCastle.Asn1.DerNumericString GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerNumericString)
			{
				return (global::Org.BouncyCastle.Asn1.DerNumericString)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x0010DB64 File Offset: 0x0010BD64
		public static global::Org.BouncyCastle.Asn1.DerNumericString GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerNumericString)
			{
				return global::Org.BouncyCastle.Asn1.DerNumericString.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerNumericString(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o).GetOctets());
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x0010DB9A File Offset: 0x0010BD9A
		public DerNumericString(byte[] str) : this(global::Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(str), false)
		{
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x0010DBA9 File Offset: 0x0010BDA9
		public DerNumericString(string str) : this(str, false)
		{
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x0010DBB3 File Offset: 0x0010BDB3
		public DerNumericString(string str, bool validate)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			if (validate && !global::Org.BouncyCastle.Asn1.DerNumericString.IsNumericString(str))
			{
				throw new global::System.ArgumentException("string contains illegal characters", "str");
			}
			this.str = str;
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x0010DBEB File Offset: 0x0010BDEB
		public override string GetString()
		{
			return this.str;
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x0010DBF3 File Offset: 0x0010BDF3
		public byte[] GetOctets()
		{
			return global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(this.str);
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x0010DC00 File Offset: 0x0010BE00
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.str.Length);
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x0010DC13 File Offset: 0x0010BE13
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 18, this.GetOctets());
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x0010DC24 File Offset: 0x0010BE24
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerNumericString other = asn1Object as global::Org.BouncyCastle.Asn1.DerNumericString;
			return other != null && this.str.Equals(other.str);
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x0010DC50 File Offset: 0x0010BE50
		public static bool IsNumericString(string str)
		{
			foreach (char ch in str)
			{
				if (ch > '\u007f' || (ch != ' ' && !char.IsDigit(ch)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400199F RID: 6559
		private readonly string str;
	}
}
