using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000542 RID: 1346
	public class DefaultAuthenticatedAttributeTableGenerator : global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator
	{
		// Token: 0x06003400 RID: 13312 RVA: 0x000F8D39 File Offset: 0x000F6F39
		public DefaultAuthenticatedAttributeTableGenerator()
		{
			this.table = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x000F8D4C File Offset: 0x000F6F4C
		public DefaultAuthenticatedAttributeTableGenerator(global::Org.BouncyCastle.Asn1.Cms.AttributeTable attributeTable)
		{
			if (attributeTable != null)
			{
				this.table = attributeTable.ToDictionary();
				return;
			}
			this.table = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x000F8D70 File Offset: 0x000F6F70
		protected virtual global::System.Collections.IDictionary CreateStandardAttributeTable(global::System.Collections.IDictionary parameters)
		{
			global::System.Collections.IDictionary std = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(this.table);
			if (!std.Contains(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.ContentType))
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)parameters[global::Org.BouncyCastle.Cms.CmsAttributeTableParameter.ContentType];
				global::Org.BouncyCastle.Asn1.Cms.Attribute attr = new global::Org.BouncyCastle.Asn1.Cms.Attribute(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.ContentType, new global::Org.BouncyCastle.Asn1.DerSet(contentType));
				std[attr.AttrType] = attr;
			}
			if (!std.Contains(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.MessageDigest))
			{
				byte[] messageDigest = (byte[])parameters[global::Org.BouncyCastle.Cms.CmsAttributeTableParameter.Digest];
				global::Org.BouncyCastle.Asn1.Cms.Attribute attr2 = new global::Org.BouncyCastle.Asn1.Cms.Attribute(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.MessageDigest, new global::Org.BouncyCastle.Asn1.DerSet(new global::Org.BouncyCastle.Asn1.DerOctetString(messageDigest)));
				std[attr2.AttrType] = attr2;
			}
			return std;
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x000F8E0C File Offset: 0x000F700C
		public virtual global::Org.BouncyCastle.Asn1.Cms.AttributeTable GetAttributes(global::System.Collections.IDictionary parameters)
		{
			return new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(this.CreateStandardAttributeTable(parameters));
		}

		// Token: 0x04001746 RID: 5958
		private readonly global::System.Collections.IDictionary table;
	}
}
