using System;
using System.Collections;
using Org.BouncyCastle.Asn1.Cms;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200055D RID: 1373
	public class SimpleAttributeTableGenerator : global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator
	{
		// Token: 0x0600349C RID: 13468 RVA: 0x000FB78A File Offset: 0x000F998A
		public SimpleAttributeTableGenerator(global::Org.BouncyCastle.Asn1.Cms.AttributeTable attributes)
		{
			this.attributes = attributes;
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x000FB799 File Offset: 0x000F9999
		public virtual global::Org.BouncyCastle.Asn1.Cms.AttributeTable GetAttributes(global::System.Collections.IDictionary parameters)
		{
			return this.attributes;
		}

		// Token: 0x04001787 RID: 6023
		private readonly global::Org.BouncyCastle.Asn1.Cms.AttributeTable attributes;
	}
}
