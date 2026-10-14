using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000481 RID: 1153
	[global::System.Serializable]
	internal class RelationshipFixer<TSourceEntity, TTargetEntity> : global::System.Data.Entity.Core.Objects.DataClasses.IRelationshipFixer where TSourceEntity : class where TTargetEntity : class
	{
		// Token: 0x060038F7 RID: 14583 RVA: 0x000BADB6 File Offset: 0x000B8FB6
		internal RelationshipFixer(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity sourceRoleMultiplicity, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity targetRoleMultiplicity)
		{
			this._sourceRoleMultiplicity = sourceRoleMultiplicity;
			this._targetRoleMultiplicity = targetRoleMultiplicity;
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x000BADCC File Offset: 0x000B8FCC
		global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd global::System.Data.Entity.Core.Objects.DataClasses.IRelationshipFixer.CreateSourceEnd(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager)
		{
			return relationshipManager.CreateRelatedEnd<TTargetEntity, TSourceEntity>(navigation, this._targetRoleMultiplicity, this._sourceRoleMultiplicity, null);
		}

		// Token: 0x04001300 RID: 4864
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity _sourceRoleMultiplicity;

		// Token: 0x04001301 RID: 4865
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity _targetRoleMultiplicity;
	}
}
