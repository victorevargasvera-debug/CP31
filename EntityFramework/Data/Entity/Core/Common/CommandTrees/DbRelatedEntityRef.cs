using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006DC RID: 1756
	internal sealed class DbRelatedEntityRef
	{
		// Token: 0x06005191 RID: 20881 RVA: 0x001231BC File Offset: 0x001213BC
		internal DbRelatedEntityRef(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember sourceEnd, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember targetEnd, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression targetEntityRef)
		{
			if (sourceEnd.DeclaringType != targetEnd.DeclaringType)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_RelatedEntityRef_TargetEndFromDifferentRelationship, "targetEnd");
			}
			if (sourceEnd == targetEnd)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_RelatedEntityRef_TargetEndSameAsSourceEnd, "targetEnd");
			}
			if (targetEnd.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One && targetEnd.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_RelatedEntityRef_TargetEndMustBeAtMostOne, "targetEnd");
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(targetEntityRef.ResultType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_RelatedEntityRef_TargetEntityNotRef, "targetEntityRef");
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(targetEnd.TypeUsage).ElementType;
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType2 = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(targetEntityRef.ResultType).ElementType;
			if (!elementType.EdmEquals(elementType2) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(elementType2, elementType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_RelatedEntityRef_TargetEntityNotCompatible, "targetEntityRef");
			}
			this._targetEntityRef = targetEntityRef;
			this._targetEnd = targetEnd;
			this._sourceEnd = sourceEnd;
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06005192 RID: 20882 RVA: 0x00123298 File Offset: 0x00121498
		internal global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember SourceEnd
		{
			get
			{
				return this._sourceEnd;
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06005193 RID: 20883 RVA: 0x001232A0 File Offset: 0x001214A0
		internal global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember TargetEnd
		{
			get
			{
				return this._targetEnd;
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06005194 RID: 20884 RVA: 0x001232A8 File Offset: 0x001214A8
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TargetEntityReference
		{
			get
			{
				return this._targetEntityRef;
			}
		}

		// Token: 0x04001DC9 RID: 7625
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember _sourceEnd;

		// Token: 0x04001DCA RID: 7626
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember _targetEnd;

		// Token: 0x04001DCB RID: 7627
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _targetEntityRef;
	}
}
