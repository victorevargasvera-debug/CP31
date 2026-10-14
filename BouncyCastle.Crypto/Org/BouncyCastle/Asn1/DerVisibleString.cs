using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000622 RID: 1570
	public class DerVisibleString : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x06003A8F RID: 14991 RVA: 0x0010F10C File Offset: 0x0010D30C
		public static global::Org.BouncyCastle.Asn1.DerVisibleString GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerVisibleString)
			{
				return (global::Org.BouncyCastle.Asn1.DerVisibleString)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				return new global::Org.BouncyCastle.Asn1.DerVisibleString(((global::Org.BouncyCastle.Asn1.Asn1OctetString)obj).GetOctets());
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return global::Org.BouncyCastle.Asn1.DerVisibleString.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj).GetObject());
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x0010F172 File Offset: 0x0010D372
		public static global::Org.BouncyCastle.Asn1.DerVisibleString GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.DerVisibleString.GetInstance(obj.GetObject());
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x0010F17F File Offset: 0x0010D37F
		public DerVisibleString(byte[] str) : this(global::Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(str))
		{
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x0010F18D File Offset: 0x0010D38D
		public DerVisibleString(string str)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			this.str = str;
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x0010F1AA File Offset: 0x0010D3AA
		public override string GetString()
		{
			return this.str;
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x0010F1B2 File Offset: 0x0010D3B2
		public byte[] GetOctets()
		{
			return global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(this.str);
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x0010F1BF File Offset: 0x0010D3BF
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.str.Length);
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x0010F1D2 File Offset: 0x0010D3D2
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 26, this.GetOctets());
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x0010F1E4 File Offset: 0x0010D3E4
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerVisibleString other = asn1Object as global::Org.BouncyCastle.Asn1.DerVisibleString;
			return other != null && this.str.Equals(other.str);
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x0010F20E File Offset: 0x0010D40E
		protected override int Asn1GetHashCode()
		{
			return this.str.GetHashCode();
		}

		// Token: 0x040019B2 RID: 6578
		private readonly string str;
	}
}
