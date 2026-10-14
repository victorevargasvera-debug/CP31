using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000620 RID: 1568
	public class DerUtf8String : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x06003A7E RID: 14974 RVA: 0x0010EECB File Offset: 0x0010D0CB
		public static global::Org.BouncyCastle.Asn1.DerUtf8String GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerUtf8String)
			{
				return (global::Org.BouncyCastle.Asn1.DerUtf8String)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x0010EEF4 File Offset: 0x0010D0F4
		public static global::Org.BouncyCastle.Asn1.DerUtf8String GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerUtf8String)
			{
				return global::Org.BouncyCastle.Asn1.DerUtf8String.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerUtf8String(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o).GetOctets());
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x0010EF2A File Offset: 0x0010D12A
		public DerUtf8String(byte[] str) : this(global::System.Text.Encoding.UTF8.GetString(str, 0, str.Length))
		{
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x0010EF41 File Offset: 0x0010D141
		public DerUtf8String(string str)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			this.str = str;
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x0010EF5E File Offset: 0x0010D15E
		public override string GetString()
		{
			return this.str;
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x0010EF68 File Offset: 0x0010D168
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerUtf8String other = asn1Object as global::Org.BouncyCastle.Asn1.DerUtf8String;
			return other != null && this.str.Equals(other.str);
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x0010EF92 File Offset: 0x0010D192
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, global::System.Text.Encoding.UTF8.GetByteCount(this.str));
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x0010EFAA File Offset: 0x0010D1AA
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 12, global::System.Text.Encoding.UTF8.GetBytes(this.str));
		}

		// Token: 0x040019B0 RID: 6576
		private readonly string str;
	}
}
