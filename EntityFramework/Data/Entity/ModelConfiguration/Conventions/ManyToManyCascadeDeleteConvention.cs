using System;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001A4 RID: 420
	public class ManyToManyCascadeDeleteConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IDbMappingConvention, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001765 RID: 5989 RVA: 0x0003DCE8 File Offset: 0x0003BEE8
		void global::System.Data.Entity.ModelConfiguration.Conventions.IDbMappingConvention.Apply(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping>(databaseMapping, "databaseMapping");
			(from asm in databaseMapping.EntityContainerMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityContainerMapping ecm) => ecm.AssociationSetMappings)
			where asm.AssociationSet.ElementType.IsManyToMany() && !asm.AssociationSet.ElementType.IsSelfReferencing()
			select asm).SelectMany((global::System.Data.Entity.Core.Mapping.AssociationSetMapping asm) => asm.Table.ForeignKeyBuilders).Each((global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk) => fk.DeleteAction = global::System.Data.Entity.Core.Metadata.Edm.OperationAction.Cascade);
		}
	}
}
