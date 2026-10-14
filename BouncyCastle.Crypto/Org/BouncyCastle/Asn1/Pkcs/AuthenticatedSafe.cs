using System;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006A9 RID: 1705
	public class AuthenticatedSafe : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E87 RID: 16007 RVA: 0x0011D631 File Offset: 0x0011B831
		private static global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo[] Copy(global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo[] info)
		{
			return (global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo[])info.Clone();
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x0011D63E File Offset: 0x0011B83E
		public static global::Org.BouncyCastle.Asn1.Pkcs.AuthenticatedSafe GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.AuthenticatedSafe)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.AuthenticatedSafe)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Pkcs.AuthenticatedSafe(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x0011D660 File Offset: 0x0011B860
		private AuthenticatedSafe(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.info = new global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo[seq.Count];
			for (int i = 0; i != this.info.Length; i++)
			{
				this.info[i] = global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo.GetInstance(seq[i]);
			}
			this.isBer = (seq is global::Org.BouncyCastle.Asn1.BerSequence);
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x0011D6BA File Offset: 0x0011B8BA
		public AuthenticatedSafe(global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo[] info)
		{
			this.info = global::Org.BouncyCastle.Asn1.Pkcs.AuthenticatedSafe.Copy(info);
			this.isBer = true;
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x0011D6D5 File Offset: 0x0011B8D5
		public global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo[] GetContentInfo()
		{
			return global::Org.BouncyCastle.Asn1.Pkcs.AuthenticatedSafe.Copy(this.info);
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x0011D6E4 File Offset: 0x0011B8E4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements;
			if (this.isBer)
			{
				elements = this.info;
				return new global::Org.BouncyCastle.Asn1.BerSequence(elements);
			}
			elements = this.info;
			return new global::Org.BouncyCastle.Asn1.DerSequence(elements);
		}

		// Token: 0x04001C63 RID: 7267
		private readonly global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo[] info;

		// Token: 0x04001C64 RID: 7268
		private readonly bool isBer;
	}
}
