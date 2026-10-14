using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003F5 RID: 1013
	internal abstract class TypedColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.StructuredColumnMap
	{
		// Token: 0x06002F58 RID: 12120 RVA: 0x00094D0A File Offset: 0x00092F0A
		internal TypedColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties) : base(type, name, properties)
		{
		}
	}
}
