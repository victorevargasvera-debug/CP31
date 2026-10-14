using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001AD RID: 429
	public abstract class Pkcs12Entry
	{
		// Token: 0x06001045 RID: 4165 RVA: 0x00040ED8 File Offset: 0x0003F0D8
		protected internal Pkcs12Entry(global::System.Collections.IDictionary attributes)
		{
			this.attributes = attributes;
			foreach (object obj in attributes)
			{
				global::System.Collections.DictionaryEntry entry = (global::System.Collections.DictionaryEntry)obj;
				if (!(entry.Key is string))
				{
					throw new global::System.ArgumentException("Attribute keys must be of type: " + typeof(string).FullName, "attributes");
				}
				if (!(entry.Value is global::Org.BouncyCastle.Asn1.Asn1Encodable))
				{
					throw new global::System.ArgumentException("Attribute values must be of type: " + typeof(global::Org.BouncyCastle.Asn1.Asn1Encodable).FullName, "attributes");
				}
			}
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00040F98 File Offset: 0x0003F198
		[global::System.Obsolete("Use 'object[index]' syntax instead")]
		public global::Org.BouncyCastle.Asn1.Asn1Encodable GetBagAttribute(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (global::Org.BouncyCastle.Asn1.Asn1Encodable)this.attributes[oid.Id];
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00040FB0 File Offset: 0x0003F1B0
		[global::System.Obsolete("Use 'object[index]' syntax instead")]
		public global::Org.BouncyCastle.Asn1.Asn1Encodable GetBagAttribute(string oid)
		{
			return (global::Org.BouncyCastle.Asn1.Asn1Encodable)this.attributes[oid];
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00040FC3 File Offset: 0x0003F1C3
		[global::System.Obsolete("Use 'BagAttributeKeys' property")]
		public global::System.Collections.IEnumerator GetBagAttributeKeys()
		{
			return this.attributes.Keys.GetEnumerator();
		}

		// Token: 0x17000235 RID: 565
		public global::Org.BouncyCastle.Asn1.Asn1Encodable this[global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid]
		{
			get
			{
				return (global::Org.BouncyCastle.Asn1.Asn1Encodable)this.attributes[oid.Id];
			}
		}

		// Token: 0x17000236 RID: 566
		public global::Org.BouncyCastle.Asn1.Asn1Encodable this[string oid]
		{
			get
			{
				return (global::Org.BouncyCastle.Asn1.Asn1Encodable)this.attributes[oid];
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x00041000 File Offset: 0x0003F200
		public global::System.Collections.IEnumerable BagAttributeKeys
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.attributes.Keys);
			}
		}

		// Token: 0x040008A0 RID: 2208
		private readonly global::System.Collections.IDictionary attributes;
	}
}
