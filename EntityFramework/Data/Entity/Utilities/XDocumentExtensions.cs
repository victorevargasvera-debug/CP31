using System;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations.Edm;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000086 RID: 134
	internal static class XDocumentExtensions
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
		public static global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection GetStorageMappingItemCollection(this global::System.Xml.Linq.XDocument model, out global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmCollection = new global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection(new global::System.Xml.XmlReader[]
			{
				model.Descendants(global::System.Data.Entity.Migrations.Edm.EdmXNames.Csdl.SchemaNames).Single<global::System.Xml.Linq.XElement>().CreateReader()
			});
			global::System.Xml.Linq.XElement xelement = model.Descendants(global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.SchemaNames).Single<global::System.Xml.Linq.XElement>();
			providerInfo = new global::System.Data.Entity.Infrastructure.DbProviderInfo(xelement.ProviderAttribute(), xelement.ProviderManifestTokenAttribute());
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeCollection = new global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection(new global::System.Xml.XmlReader[]
			{
				xelement.CreateReader()
			});
			return new global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection(edmCollection, storeCollection, new global::System.Xml.XmlReader[]
			{
				new global::System.Xml.Linq.XElement(model.Descendants(global::System.Data.Entity.Migrations.Edm.EdmXNames.Msl.MappingNames).Single<global::System.Xml.Linq.XElement>()).CreateReader()
			});
		}
	}
}
