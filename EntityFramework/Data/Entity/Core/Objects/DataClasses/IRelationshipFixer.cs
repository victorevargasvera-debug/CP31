using System;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x0200047F RID: 1151
	internal interface IRelationshipFixer
	{
		// Token: 0x06003870 RID: 14448
		global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd CreateSourceEnd(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager);
	}
}
