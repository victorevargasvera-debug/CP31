using System;
using System.Data.Entity.Utilities;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004E3 RID: 1251
	internal class MslSerializer
	{
		// Token: 0x06003E63 RID: 15971 RVA: 0x000CE516 File Offset: 0x000CC716
		public virtual bool Serialize(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Xml.XmlWriter xmlWriter)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping>(databaseMapping, "databaseMapping");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Xml.XmlWriter>(xmlWriter, "xmlWriter");
			new global::System.Data.Entity.Core.Metadata.Edm.MslXmlSchemaWriter(xmlWriter, databaseMapping.Model.SchemaVersion).WriteSchema(databaseMapping);
			return true;
		}
	}
}
