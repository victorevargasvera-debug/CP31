using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000621 RID: 1569
	public class DerVideotexString : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x06003A86 RID: 14982 RVA: 0x0010EFC8 File Offset: 0x0010D1C8
		public static global::Org.BouncyCastle.Asn1.DerVideotexString GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerVideotexString)
			{
				return (global::Org.BouncyCastle.Asn1.DerVideotexString)obj;
			}
			if (obj is byte[])
			{
				try
				{
					return (global::Org.BouncyCastle.Asn1.DerVideotexString)global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray((byte[])obj);
				}
				catch (global::System.Exception e)
				{
					throw new global::System.ArgumentException("encoding error in GetInstance: " + e.ToString(), "obj");
				}
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x0010F04C File Offset: 0x0010D24C
		public static global::Org.BouncyCastle.Asn1.DerVideotexString GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerVideotexString)
			{
				return global::Org.BouncyCastle.Asn1.DerVideotexString.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerVideotexString(((global::Org.BouncyCastle.Asn1.Asn1OctetString)o).GetOctets());
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x0010F082 File Offset: 0x0010D282
		public DerVideotexString(byte[] encoding)
		{
			this.mString = global::Org.BouncyCastle.Utilities.Arrays.Clone(encoding);
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x0010F096 File Offset: 0x0010D296
		public override string GetString()
		{
			return global::Org.BouncyCastle.Utilities.Strings.FromByteArray(this.mString);
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x0010F0A3 File Offset: 0x0010D2A3
		public byte[] GetOctets()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mString);
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x0010F0B0 File Offset: 0x0010D2B0
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.mString.Length);
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x0010F0C0 File Offset: 0x0010D2C0
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 21, this.mString);
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x0010F0D1 File Offset: 0x0010D2D1
		protected override int Asn1GetHashCode()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.mString);
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x0010F0E0 File Offset: 0x0010D2E0
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerVideotexString other = asn1Object as global::Org.BouncyCastle.Asn1.DerVideotexString;
			return other != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.mString, other.mString);
		}

		// Token: 0x040019B1 RID: 6577
		private readonly byte[] mString;
	}
}
