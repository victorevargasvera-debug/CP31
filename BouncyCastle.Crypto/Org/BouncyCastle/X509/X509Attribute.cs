using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000012 RID: 18
	public class X509Attribute : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x000065DA File Offset: 0x000047DA
		internal X509Attribute(global::Org.BouncyCastle.Asn1.Asn1Encodable at)
		{
			this.attr = global::Org.BouncyCastle.Asn1.X509.AttributeX509.GetInstance(at);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000065EE File Offset: 0x000047EE
		public X509Attribute(string oid, global::Org.BouncyCastle.Asn1.Asn1Encodable value)
		{
			this.attr = new global::Org.BouncyCastle.Asn1.X509.AttributeX509(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid), new global::Org.BouncyCastle.Asn1.DerSet(value));
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000660D File Offset: 0x0000480D
		public X509Attribute(string oid, global::Org.BouncyCastle.Asn1.Asn1EncodableVector value)
		{
			this.attr = new global::Org.BouncyCastle.Asn1.X509.AttributeX509(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid), new global::Org.BouncyCastle.Asn1.DerSet(value));
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000662C File Offset: 0x0000482C
		public string Oid
		{
			get
			{
				return this.attr.AttrType.Id;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006640 File Offset: 0x00004840
		public global::Org.BouncyCastle.Asn1.Asn1Encodable[] GetValues()
		{
			global::Org.BouncyCastle.Asn1.Asn1Set s = this.attr.AttrValues;
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] values = new global::Org.BouncyCastle.Asn1.Asn1Encodable[s.Count];
			for (int i = 0; i != s.Count; i++)
			{
				values[i] = s[i];
			}
			return values;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006681 File Offset: 0x00004881
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.attr.ToAsn1Object();
		}

		// Token: 0x0400007C RID: 124
		private readonly global::Org.BouncyCastle.Asn1.X509.AttributeX509 attr;
	}
}
