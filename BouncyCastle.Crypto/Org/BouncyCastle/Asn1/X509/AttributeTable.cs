using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000644 RID: 1604
	public class AttributeTable
	{
		// Token: 0x06003B68 RID: 15208 RVA: 0x001118C5 File Offset: 0x0010FAC5
		public AttributeTable(global::System.Collections.IDictionary attrs)
		{
			this.attributes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(attrs);
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x001118D9 File Offset: 0x0010FAD9
		[global::System.Obsolete]
		public AttributeTable(global::System.Collections.Hashtable attrs)
		{
			this.attributes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(attrs);
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x001118F0 File Offset: 0x0010FAF0
		public AttributeTable(global::Org.BouncyCastle.Asn1.Asn1EncodableVector v)
		{
			this.attributes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(v.Count);
			for (int i = 0; i != v.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.X509.AttributeX509 a = global::Org.BouncyCastle.Asn1.X509.AttributeX509.GetInstance(v[i]);
				this.attributes.Add(a.AttrType, a);
			}
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x00111944 File Offset: 0x0010FB44
		public AttributeTable(global::Org.BouncyCastle.Asn1.Asn1Set s)
		{
			this.attributes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(s.Count);
			for (int i = 0; i != s.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.X509.AttributeX509 a = global::Org.BouncyCastle.Asn1.X509.AttributeX509.GetInstance(s[i]);
				this.attributes.Add(a.AttrType, a);
			}
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x00111998 File Offset: 0x0010FB98
		public global::Org.BouncyCastle.Asn1.X509.AttributeX509 Get(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (global::Org.BouncyCastle.Asn1.X509.AttributeX509)this.attributes[oid];
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x001119AB File Offset: 0x0010FBAB
		[global::System.Obsolete("Use 'ToDictionary' instead")]
		public global::System.Collections.Hashtable ToHashtable()
		{
			return new global::System.Collections.Hashtable(this.attributes);
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x001119B8 File Offset: 0x0010FBB8
		public global::System.Collections.IDictionary ToDictionary()
		{
			return global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(this.attributes);
		}

		// Token: 0x04001A36 RID: 6710
		private readonly global::System.Collections.IDictionary attributes;
	}
}
