using System;
using System.Data.Entity.Internal;
using System.Data.Entity.Utilities;
using System.Xml;
using System.Xml.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000240 RID: 576
	public static class EdmxReader
	{
		// Token: 0x06001E3F RID: 7743 RVA: 0x000536B4 File Offset: 0x000518B4
		public static global::System.Data.Entity.Infrastructure.DbCompiledModel Read(global::System.Xml.XmlReader reader, string defaultSchema)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Xml.XmlReader>(reader, "reader");
			global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo;
			return new global::System.Data.Entity.Infrastructure.DbCompiledModel(global::System.Data.Entity.Internal.CodeFirstCachedMetadataWorkspace.Create(global::System.Xml.Linq.XDocument.Load(reader).GetStorageMappingItemCollection(out providerInfo), providerInfo), defaultSchema);
		}
	}
}
