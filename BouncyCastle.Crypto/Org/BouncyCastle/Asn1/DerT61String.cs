using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200061C RID: 1564
	public class DerT61String : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x06003A56 RID: 14934 RVA: 0x0010E8B1 File Offset: 0x0010CAB1
		public static global::Org.BouncyCastle.Asn1.DerT61String GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerT61String)
			{
				return (global::Org.BouncyCastle.Asn1.DerT61String)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x0010E8DC File Offset: 0x0010CADC
		public static global::Org.BouncyCastle.Asn1.DerT61String GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerT61String)
			{
				return global::Org.BouncyCastle.Asn1.DerT61String.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerT61String(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o).GetOctets());
		}

		// Token: 0x06003A58 RID: 14936 RVA: 0x0010E912 File Offset: 0x0010CB12
		public DerT61String(byte[] str) : this(global::Org.BouncyCastle.Utilities.Strings.FromByteArray(str))
		{
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x0010E920 File Offset: 0x0010CB20
		public DerT61String(string str)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			this.str = str;
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x0010E93D File Offset: 0x0010CB3D
		public override string GetString()
		{
			return this.str;
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x0010E945 File Offset: 0x0010CB45
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.str.Length);
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x0010E958 File Offset: 0x0010CB58
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 20, this.GetOctets());
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x0010E969 File Offset: 0x0010CB69
		public byte[] GetOctets()
		{
			return global::Org.BouncyCastle.Utilities.Strings.ToByteArray(this.str);
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x0010E978 File Offset: 0x0010CB78
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerT61String other = asn1Object as global::Org.BouncyCastle.Asn1.DerT61String;
			return other != null && this.str.Equals(other.str);
		}

		// Token: 0x040019AC RID: 6572
		private readonly string str;
	}
}
