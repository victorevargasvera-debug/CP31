using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000543 RID: 1347
	public class DefaultSignedAttributeTableGenerator : global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator
	{
		// Token: 0x06003404 RID: 13316 RVA: 0x000F8E1A File Offset: 0x000F701A
		public DefaultSignedAttributeTableGenerator()
		{
			this.table = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x000F8E2D File Offset: 0x000F702D
		public DefaultSignedAttributeTableGenerator(global::Org.BouncyCastle.Asn1.Cms.AttributeTable attributeTable)
		{
			if (attributeTable != null)
			{
				this.table = attributeTable.ToDictionary();
				return;
			}
			this.table = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x000F8E50 File Offset: 0x000F7050
		protected virtual global::System.Collections.Hashtable createStandardAttributeTable(global::System.Collections.IDictionary parameters)
		{
			global::System.Collections.Hashtable std = new global::System.Collections.Hashtable(this.table);
			this.DoCreateStandardAttributeTable(parameters, std);
			return std;
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x000F8E74 File Offset: 0x000F7074
		private void DoCreateStandardAttributeTable(global::System.Collections.IDictionary parameters, global::System.Collections.IDictionary std)
		{
			if (parameters.Contains(global::Org.BouncyCastle.Cms.CmsAttributeTableParameter.ContentType) && !std.Contains(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.ContentType))
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)parameters[global::Org.BouncyCastle.Cms.CmsAttributeTableParameter.ContentType];
				global::Org.BouncyCastle.Asn1.Cms.Attribute attr = new global::Org.BouncyCastle.Asn1.Cms.Attribute(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.ContentType, new global::Org.BouncyCastle.Asn1.DerSet(contentType));
				std[attr.AttrType] = attr;
			}
			if (!std.Contains(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.SigningTime))
			{
				global::Org.BouncyCastle.Asn1.Cms.Attribute attr2 = new global::Org.BouncyCastle.Asn1.Cms.Attribute(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.SigningTime, new global::Org.BouncyCastle.Asn1.DerSet(new global::Org.BouncyCastle.Asn1.Cms.Time(global::System.DateTime.UtcNow)));
				std[attr2.AttrType] = attr2;
			}
			if (!std.Contains(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.MessageDigest))
			{
				byte[] messageDigest = (byte[])parameters[global::Org.BouncyCastle.Cms.CmsAttributeTableParameter.Digest];
				global::Org.BouncyCastle.Asn1.Cms.Attribute attr3 = new global::Org.BouncyCastle.Asn1.Cms.Attribute(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.MessageDigest, new global::Org.BouncyCastle.Asn1.DerSet(new global::Org.BouncyCastle.Asn1.DerOctetString(messageDigest)));
				std[attr3.AttrType] = attr3;
			}
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x000F8F45 File Offset: 0x000F7145
		public virtual global::Org.BouncyCastle.Asn1.Cms.AttributeTable GetAttributes(global::System.Collections.IDictionary parameters)
		{
			return new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(this.createStandardAttributeTable(parameters));
		}

		// Token: 0x04001747 RID: 5959
		private readonly global::System.Collections.IDictionary table;
	}
}
