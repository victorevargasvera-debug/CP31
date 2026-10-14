using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200060B RID: 1547
	public class DerIA5String : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x060039C6 RID: 14790 RVA: 0x0010D5C2 File Offset: 0x0010B7C2
		public static global::Org.BouncyCastle.Asn1.DerIA5String GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerIA5String)
			{
				return (global::Org.BouncyCastle.Asn1.DerIA5String)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x0010D5EC File Offset: 0x0010B7EC
		public static global::Org.BouncyCastle.Asn1.DerIA5String GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerIA5String)
			{
				return global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerIA5String(((global::Org.BouncyCastle.Asn1.Asn1OctetString)o).GetOctets());
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x0010D622 File Offset: 0x0010B822
		public DerIA5String(byte[] str) : this(global::Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(str), false)
		{
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x0010D631 File Offset: 0x0010B831
		public DerIA5String(string str) : this(str, false)
		{
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x0010D63B File Offset: 0x0010B83B
		public DerIA5String(string str, bool validate)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			if (validate && !global::Org.BouncyCastle.Asn1.DerIA5String.IsIA5String(str))
			{
				throw new global::System.ArgumentException("string contains illegal characters", "str");
			}
			this.str = str;
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x0010D673 File Offset: 0x0010B873
		public override string GetString()
		{
			return this.str;
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x0010D67B File Offset: 0x0010B87B
		public byte[] GetOctets()
		{
			return global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(this.str);
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x0010D688 File Offset: 0x0010B888
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.str.Length);
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x0010D69B File Offset: 0x0010B89B
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 22, this.GetOctets());
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x0010D6AC File Offset: 0x0010B8AC
		protected override int Asn1GetHashCode()
		{
			return this.str.GetHashCode();
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x0010D6BC File Offset: 0x0010B8BC
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerIA5String other = asn1Object as global::Org.BouncyCastle.Asn1.DerIA5String;
			return other != null && this.str.Equals(other.str);
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x0010D6E8 File Offset: 0x0010B8E8
		public static bool IsIA5String(string str)
		{
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] > '\u007f')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04001997 RID: 6551
		private readonly string str;
	}
}
