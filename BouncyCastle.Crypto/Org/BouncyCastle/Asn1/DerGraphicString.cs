using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200060A RID: 1546
	public class DerGraphicString : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x060039BD RID: 14781 RVA: 0x0010D480 File Offset: 0x0010B680
		public static global::Org.BouncyCastle.Asn1.DerGraphicString GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerGraphicString)
			{
				return (global::Org.BouncyCastle.Asn1.DerGraphicString)obj;
			}
			if (obj is byte[])
			{
				try
				{
					return (global::Org.BouncyCastle.Asn1.DerGraphicString)global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray((byte[])obj);
				}
				catch (global::System.Exception e)
				{
					throw new global::System.ArgumentException("encoding error in GetInstance: " + e.ToString(), "obj");
				}
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x0010D504 File Offset: 0x0010B704
		public static global::Org.BouncyCastle.Asn1.DerGraphicString GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerGraphicString)
			{
				return global::Org.BouncyCastle.Asn1.DerGraphicString.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerGraphicString(((global::Org.BouncyCastle.Asn1.Asn1OctetString)o).GetOctets());
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x0010D53A File Offset: 0x0010B73A
		public DerGraphicString(byte[] encoding)
		{
			this.mString = global::Org.BouncyCastle.Utilities.Arrays.Clone(encoding);
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x0010D54E File Offset: 0x0010B74E
		public override string GetString()
		{
			return global::Org.BouncyCastle.Utilities.Strings.FromByteArray(this.mString);
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x0010D55B File Offset: 0x0010B75B
		public byte[] GetOctets()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mString);
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x0010D568 File Offset: 0x0010B768
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.mString.Length);
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x0010D578 File Offset: 0x0010B778
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 25, this.mString);
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x0010D589 File Offset: 0x0010B789
		protected override int Asn1GetHashCode()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.mString);
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x0010D598 File Offset: 0x0010B798
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerGraphicString other = asn1Object as global::Org.BouncyCastle.Asn1.DerGraphicString;
			return other != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.mString, other.mString);
		}

		// Token: 0x04001996 RID: 6550
		private readonly byte[] mString;
	}
}
