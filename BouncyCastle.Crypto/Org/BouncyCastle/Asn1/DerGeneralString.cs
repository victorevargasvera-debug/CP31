using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000608 RID: 1544
	public class DerGeneralString : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x060039AE RID: 14766 RVA: 0x0010D25F File Offset: 0x0010B45F
		public static global::Org.BouncyCastle.Asn1.DerGeneralString GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerGeneralString)
			{
				return (global::Org.BouncyCastle.Asn1.DerGeneralString)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x0010D288 File Offset: 0x0010B488
		public static global::Org.BouncyCastle.Asn1.DerGeneralString GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerGeneralString)
			{
				return global::Org.BouncyCastle.Asn1.DerGeneralString.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerGeneralString(((global::Org.BouncyCastle.Asn1.Asn1OctetString)o).GetOctets());
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x0010D2BE File Offset: 0x0010B4BE
		public DerGeneralString(byte[] str) : this(global::Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(str))
		{
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x0010D2CC File Offset: 0x0010B4CC
		public DerGeneralString(string str)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			this.str = str;
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x0010D2E9 File Offset: 0x0010B4E9
		public override string GetString()
		{
			return this.str;
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x0010D2F1 File Offset: 0x0010B4F1
		public byte[] GetOctets()
		{
			return global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(this.str);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x0010D2FE File Offset: 0x0010B4FE
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.str.Length);
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x0010D311 File Offset: 0x0010B511
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 27, this.GetOctets());
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x0010D324 File Offset: 0x0010B524
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerGeneralString other = asn1Object as global::Org.BouncyCastle.Asn1.DerGeneralString;
			return other != null && this.str.Equals(other.str);
		}

		// Token: 0x04001992 RID: 6546
		private readonly string str;
	}
}
