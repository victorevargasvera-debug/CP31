using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000614 RID: 1556
	public class DerPrintableString : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x06003A23 RID: 14883 RVA: 0x0010E400 File Offset: 0x0010C600
		public static global::Org.BouncyCastle.Asn1.DerPrintableString GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerPrintableString)
			{
				return (global::Org.BouncyCastle.Asn1.DerPrintableString)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x0010E42C File Offset: 0x0010C62C
		public static global::Org.BouncyCastle.Asn1.DerPrintableString GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerPrintableString)
			{
				return global::Org.BouncyCastle.Asn1.DerPrintableString.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerPrintableString(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o).GetOctets());
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x0010E462 File Offset: 0x0010C662
		public DerPrintableString(byte[] str) : this(global::Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(str), false)
		{
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x0010E471 File Offset: 0x0010C671
		public DerPrintableString(string str) : this(str, false)
		{
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x0010E47B File Offset: 0x0010C67B
		public DerPrintableString(string str, bool validate)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			if (validate && !global::Org.BouncyCastle.Asn1.DerPrintableString.IsPrintableString(str))
			{
				throw new global::System.ArgumentException("string contains illegal characters", "str");
			}
			this.str = str;
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x0010E4B3 File Offset: 0x0010C6B3
		public override string GetString()
		{
			return this.str;
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x0010E4BB File Offset: 0x0010C6BB
		public byte[] GetOctets()
		{
			return global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(this.str);
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x0010E4C8 File Offset: 0x0010C6C8
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.str.Length);
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x0010E4DB File Offset: 0x0010C6DB
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 19, this.GetOctets());
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x0010E4EC File Offset: 0x0010C6EC
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerPrintableString other = asn1Object as global::Org.BouncyCastle.Asn1.DerPrintableString;
			return other != null && this.str.Equals(other.str);
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x0010E518 File Offset: 0x0010C718
		public static bool IsPrintableString(string str)
		{
			foreach (char ch in str)
			{
				if (ch > '\u007f')
				{
					return false;
				}
				if (!char.IsLetterOrDigit(ch))
				{
					if (ch <= ':')
					{
						switch (ch)
						{
						case ' ':
						case '\'':
						case '(':
						case ')':
						case '+':
						case ',':
						case '-':
						case '.':
						case '/':
							goto IL_7E;
						case '!':
						case '"':
						case '#':
						case '$':
						case '%':
						case '&':
						case '*':
							break;
						default:
							if (ch == ':')
							{
								goto IL_7E;
							}
							break;
						}
					}
					else if (ch == '=' || ch == '?')
					{
						goto IL_7E;
					}
					return false;
				}
				IL_7E:;
			}
			return true;
		}

		// Token: 0x040019A5 RID: 6565
		private readonly string str;
	}
}
