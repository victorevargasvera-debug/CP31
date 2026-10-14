using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000489 RID: 1161
	public sealed class AssociationSetEnd : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x060039BD RID: 14781 RVA: 0x000BD34F File Offset: 0x000BB54F
		internal AssociationSetEnd(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet parentSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endMember)
		{
			this._entitySet = global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySet, "entitySet");
			this._parentSet = global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(parentSet, "parentSet");
			this._endMember = global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>(endMember, "endMember");
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x000BD38A File Offset: 0x000BB58A
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSetEnd;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060039BF RID: 14783 RVA: 0x000BD38D File Offset: 0x000BB58D
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.AssociationSet ParentAssociationSet
		{
			get
			{
				return this._parentSet;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x000BD395 File Offset: 0x000BB595
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationEndMember, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember CorrespondingAssociationEndMember
		{
			get
			{
				return this._endMember;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060039C1 RID: 14785 RVA: 0x000BD39D File Offset: 0x000BB59D
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public string Name
		{
			get
			{
				return this.CorrespondingAssociationEndMember.Name;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x000BD3AA File Offset: 0x000BB5AA
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		[global::System.Obsolete("This property is going away, please use the Name property instead")]
		public string Role
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060039C3 RID: 14787 RVA: 0x000BD3B2 File Offset: 0x000BB5B2
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
		{
			get
			{
				return this._entitySet;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x000BD3BA File Offset: 0x000BB5BA
		internal override string Identity
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x000BD3C2 File Offset: 0x000BB5C2
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x000BD3CC File Offset: 0x000BB5CC
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet parentAssociationSet = this.ParentAssociationSet;
				if (parentAssociationSet != null)
				{
					parentAssociationSet.SetReadOnly();
				}
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember correspondingAssociationEndMember = this.CorrespondingAssociationEndMember;
				if (correspondingAssociationEndMember != null)
				{
					correspondingAssociationEndMember.SetReadOnly();
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = this.EntitySet;
				if (entitySet != null)
				{
					entitySet.SetReadOnly();
				}
			}
		}

		// Token: 0x0400131B RID: 4891
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet _entitySet;

		// Token: 0x0400131C RID: 4892
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationSet _parentSet;

		// Token: 0x0400131D RID: 4893
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember _endMember;
	}
}
