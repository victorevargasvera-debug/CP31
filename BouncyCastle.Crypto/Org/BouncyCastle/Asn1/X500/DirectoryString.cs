using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X500
{
	// Token: 0x02000690 RID: 1680
	public class DirectoryString : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice, global::Org.BouncyCastle.Asn1.IAsn1String
	{
		// Token: 0x06003DDF RID: 15839 RVA: 0x0011A09C File Offset: 0x0011829C
		public static global::Org.BouncyCastle.Asn1.X500.DirectoryString GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X500.DirectoryString)
			{
				return (global::Org.BouncyCastle.Asn1.X500.DirectoryString)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerStringBase && (obj is global::Org.BouncyCastle.Asn1.DerT61String || obj is global::Org.BouncyCastle.Asn1.DerPrintableString || obj is global::Org.BouncyCastle.Asn1.DerUniversalString || obj is global::Org.BouncyCastle.Asn1.DerUtf8String || obj is global::Org.BouncyCastle.Asn1.DerBmpString))
			{
				return new global::Org.BouncyCastle.Asn1.X500.DirectoryString((global::Org.BouncyCastle.Asn1.DerStringBase)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x0011A111 File Offset: 0x00118311
		public static global::Org.BouncyCastle.Asn1.X500.DirectoryString GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			if (!isExplicit)
			{
				throw new global::System.ArgumentException("choice item must be explicitly tagged");
			}
			return global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(obj.GetObject());
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x0011A12C File Offset: 0x0011832C
		private DirectoryString(global::Org.BouncyCastle.Asn1.DerStringBase str)
		{
			this.str = str;
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x0011A13B File Offset: 0x0011833B
		public DirectoryString(string str)
		{
			this.str = new global::Org.BouncyCastle.Asn1.DerUtf8String(str);
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x0011A14F File Offset: 0x0011834F
		public string GetString()
		{
			return this.str.GetString();
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x0011A15C File Offset: 0x0011835C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.str.ToAsn1Object();
		}

		// Token: 0x04001BA9 RID: 7081
		private readonly global::Org.BouncyCastle.Asn1.DerStringBase str;
	}
}
