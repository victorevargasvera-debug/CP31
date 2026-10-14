using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200073D RID: 1853
	public class AttributeTable
	{
		// Token: 0x0600425E RID: 16990 RVA: 0x0012B069 File Offset: 0x00129269
		[global::System.Obsolete]
		public AttributeTable(global::System.Collections.Hashtable attrs)
		{
			this.attributes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(attrs);
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x0012B07D File Offset: 0x0012927D
		public AttributeTable(global::System.Collections.IDictionary attrs)
		{
			this.attributes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(attrs);
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x0012B094 File Offset: 0x00129294
		public AttributeTable(global::Org.BouncyCastle.Asn1.Asn1EncodableVector v)
		{
			this.attributes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(v.Count);
			foreach (object obj in v)
			{
				global::Org.BouncyCastle.Asn1.Cms.Attribute a = global::Org.BouncyCastle.Asn1.Cms.Attribute.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj);
				this.AddAttribute(a);
			}
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x0012B104 File Offset: 0x00129304
		public AttributeTable(global::Org.BouncyCastle.Asn1.Asn1Set s)
		{
			this.attributes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(s.Count);
			for (int i = 0; i != s.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.Cms.Attribute a = global::Org.BouncyCastle.Asn1.Cms.Attribute.GetInstance(s[i]);
				this.AddAttribute(a);
			}
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x0012B14D File Offset: 0x0012934D
		public AttributeTable(global::Org.BouncyCastle.Asn1.Cms.Attributes attrs) : this(global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(attrs.ToAsn1Object()))
		{
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x0012B160 File Offset: 0x00129360
		private void AddAttribute(global::Org.BouncyCastle.Asn1.Cms.Attribute a)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = a.AttrType;
			object obj = this.attributes[oid];
			if (obj == null)
			{
				this.attributes[oid] = a;
				return;
			}
			global::System.Collections.IList v;
			if (obj is global::Org.BouncyCastle.Asn1.Cms.Attribute)
			{
				v = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				v.Add(obj);
				v.Add(a);
			}
			else
			{
				v = (global::System.Collections.IList)obj;
				v.Add(a);
			}
			this.attributes[oid] = v;
		}

		// Token: 0x170009A2 RID: 2466
		public global::Org.BouncyCastle.Asn1.Cms.Attribute this[global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid]
		{
			get
			{
				object obj = this.attributes[oid];
				if (obj is global::System.Collections.IList)
				{
					return (global::Org.BouncyCastle.Asn1.Cms.Attribute)((global::System.Collections.IList)obj)[0];
				}
				return (global::Org.BouncyCastle.Asn1.Cms.Attribute)obj;
			}
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x0012B20A File Offset: 0x0012940A
		[global::System.Obsolete("Use 'object[oid]' syntax instead")]
		public global::Org.BouncyCastle.Asn1.Cms.Attribute Get(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return this[oid];
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x0012B214 File Offset: 0x00129414
		public global::Org.BouncyCastle.Asn1.Asn1EncodableVector GetAll(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			object obj = this.attributes[oid];
			if (obj is global::System.Collections.IList)
			{
				using (global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IList)obj).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj2 = enumerator.Current;
						global::Org.BouncyCastle.Asn1.Cms.Attribute a = (global::Org.BouncyCastle.Asn1.Cms.Attribute)obj2;
						v.Add(a);
					}
					return v;
				}
			}
			if (obj != null)
			{
				v.Add((global::Org.BouncyCastle.Asn1.Cms.Attribute)obj);
			}
			return v;
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06004267 RID: 16999 RVA: 0x0012B29C File Offset: 0x0012949C
		public int Count
		{
			get
			{
				int total = 0;
				foreach (object o in this.attributes.Values)
				{
					if (o is global::System.Collections.IList)
					{
						total += ((global::System.Collections.IList)o).Count;
					}
					else
					{
						total++;
					}
				}
				return total;
			}
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x0012B310 File Offset: 0x00129510
		public global::System.Collections.IDictionary ToDictionary()
		{
			return global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(this.attributes);
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x0012B31D File Offset: 0x0012951D
		[global::System.Obsolete("Use 'ToDictionary' instead")]
		public global::System.Collections.Hashtable ToHashtable()
		{
			return new global::System.Collections.Hashtable(this.attributes);
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x0012B32C File Offset: 0x0012952C
		public global::Org.BouncyCastle.Asn1.Asn1EncodableVector ToAsn1EncodableVector()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in this.attributes.Values)
			{
				if (obj is global::System.Collections.IList)
				{
					using (global::System.Collections.IEnumerator enumerator2 = ((global::System.Collections.IList)obj).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							object el = enumerator2.Current;
							v.Add(global::Org.BouncyCastle.Asn1.Cms.Attribute.GetInstance(el));
						}
						continue;
					}
				}
				v.Add(global::Org.BouncyCastle.Asn1.Cms.Attribute.GetInstance(obj));
			}
			return v;
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x0012B3EC File Offset: 0x001295EC
		public global::Org.BouncyCastle.Asn1.Cms.Attributes ToAttributes()
		{
			return new global::Org.BouncyCastle.Asn1.Cms.Attributes(this.ToAsn1EncodableVector());
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x0012B3F9 File Offset: 0x001295F9
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable Add(global::Org.BouncyCastle.Asn1.DerObjectIdentifier attrType, global::Org.BouncyCastle.Asn1.Asn1Encodable attrValue)
		{
			global::Org.BouncyCastle.Asn1.Cms.AttributeTable attributeTable = new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(this.attributes);
			attributeTable.AddAttribute(new global::Org.BouncyCastle.Asn1.Cms.Attribute(attrType, new global::Org.BouncyCastle.Asn1.DerSet(attrValue)));
			return attributeTable;
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x0012B418 File Offset: 0x00129618
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable Remove(global::Org.BouncyCastle.Asn1.DerObjectIdentifier attrType)
		{
			global::Org.BouncyCastle.Asn1.Cms.AttributeTable attributeTable = new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(this.attributes);
			attributeTable.attributes.Remove(attrType);
			return attributeTable;
		}

		// Token: 0x04001FF4 RID: 8180
		private readonly global::System.Collections.IDictionary attributes;
	}
}
