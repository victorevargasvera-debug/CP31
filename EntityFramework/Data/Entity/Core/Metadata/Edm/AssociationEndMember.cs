using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Utilities;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000487 RID: 1159
	public sealed class AssociationEndMember : global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember
	{
		// Token: 0x060039A9 RID: 14761 RVA: 0x000BD03E File Offset: 0x000BB23E
		internal AssociationEndMember(string name, global::System.Data.Entity.Core.Metadata.Edm.RefType endRefType, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity multiplicity) : base(name, endRefType, multiplicity)
		{
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x000BD049 File Offset: 0x000BB249
		internal AssociationEndMember(string name, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType) : base(name, new global::System.Data.Entity.Core.Metadata.Edm.RefType(entityType), global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)
		{
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060039AB RID: 14763 RVA: 0x000BD059 File Offset: 0x000BB259
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationEndMember;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060039AC RID: 14764 RVA: 0x000BD05C File Offset: 0x000BB25C
		// (set) Token: 0x060039AD RID: 14765 RVA: 0x000BD064 File Offset: 0x000BB264
		internal global::System.Func<global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd> GetRelatedEnd
		{
			get
			{
				return this._getRelatedEndMethod;
			}
			set
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Func<global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd>>(ref this._getRelatedEndMethod, value, null);
			}
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x000BD074 File Offset: 0x000BB274
		public static global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember Create(string name, global::System.Data.Entity.Core.Metadata.Edm.RefType endRefType, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity multiplicity, global::System.Data.Entity.Core.Metadata.Edm.OperationAction deleteAction, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.RefType>(endRefType, "endRefType");
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = new global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember(name, endRefType, multiplicity);
			associationEndMember.DeleteBehavior = deleteAction;
			if (metadataProperties != null)
			{
				associationEndMember.AddMetadataProperties(metadataProperties);
			}
			associationEndMember.SetReadOnly();
			return associationEndMember;
		}

		// Token: 0x04001319 RID: 4889
		private global::System.Func<global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd> _getRelatedEndMethod;
	}
}
