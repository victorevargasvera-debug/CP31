using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200048A RID: 1162
	public class AssociationType : global::System.Data.Entity.Core.Metadata.Edm.RelationshipType
	{
		// Token: 0x060039C7 RID: 14791 RVA: 0x000BD417 File Offset: 0x000BB617
		internal AssociationType(string name, string namespaceName, bool foreignKey, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace) : base(name, namespaceName, dataSpace)
		{
			this._referentialConstraints = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>(new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>());
			this._isForeignKey = foreignKey;
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x000BD443 File Offset: 0x000BB643
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x060039C9 RID: 14793 RVA: 0x000BD446 File Offset: 0x000BB646
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> AssociationEndMembers
		{
			get
			{
				if (this._associationEndMembers == null)
				{
					global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>>(ref this._associationEndMembers, new global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(this.KeyMembers, new global::System.Predicate<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssociationEndMember)), null);
				}
				return this._associationEndMembers;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x000BD47A File Offset: 0x000BB67A
		// (set) Token: 0x060039CB RID: 14795 RVA: 0x000BD488 File Offset: 0x000BB688
		public global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint Constraint
		{
			get
			{
				return this.ReferentialConstraints.SingleOrDefault<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint = this.Constraint;
				if (constraint != null)
				{
					this.ReferentialConstraints.Source.Remove(constraint);
				}
				this.AddReferentialConstraint(value);
				this._isForeignKey = true;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x000BD4D1 File Offset: 0x000BB6D1
		// (set) Token: 0x060039CD RID: 14797 RVA: 0x000BD4E3 File Offset: 0x000BB6E3
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember SourceEnd
		{
			get
			{
				return this.KeyMembers.FirstOrDefault<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>() as global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				if (this.KeyMembers.Count == 0)
				{
					base.AddKeyMember(value);
					return;
				}
				this.SetKeyMember(0, value);
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x000BD508 File Offset: 0x000BB708
		// (set) Token: 0x060039CF RID: 14799 RVA: 0x000BD51B File Offset: 0x000BB71B
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember TargetEnd
		{
			get
			{
				return this.KeyMembers.ElementAtOrDefault(1) as global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				if (this.KeyMembers.Count == 1)
				{
					base.AddKeyMember(value);
					return;
				}
				this.SetKeyMember(1, value);
			}
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x000BD544 File Offset: 0x000BB744
		private void SetKeyMember(int index, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember member)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember value = this.KeyMembers.Source[index];
			int num = base.Members.IndexOf(value);
			if (num >= 0)
			{
				base.Members.Source[num] = member;
			}
			this.KeyMembers.Source[index] = member;
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x060039D1 RID: 14801 RVA: 0x000BD598 File Offset: 0x000BB798
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ReferentialConstraint, true)]
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> ReferentialConstraints
		{
			get
			{
				return this._referentialConstraints;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x000BD5A0 File Offset: 0x000BB7A0
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, false)]
		public bool IsForeignKey
		{
			get
			{
				return this._isForeignKey;
			}
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x000BD5A8 File Offset: 0x000BB7A8
		internal override void ValidateMemberForAdd(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x000BD5AA File Offset: 0x000BB7AA
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
				this.ReferentialConstraints.Source.SetReadOnly();
			}
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x000BD5CB File Offset: 0x000BB7CB
		internal void AddReferentialConstraint(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint)
		{
			this.ReferentialConstraints.Source.Add(referentialConstraint);
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x000BD5E0 File Offset: 0x000BB7E0
		public static global::System.Data.Entity.Core.Metadata.Edm.AssociationType Create(string name, string namespaceName, bool foreignKey, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceEnd, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetEnd, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(namespaceName, "namespaceName");
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = new global::System.Data.Entity.Core.Metadata.Edm.AssociationType(name, namespaceName, foreignKey, dataSpace);
			if (sourceEnd != null)
			{
				associationType.SourceEnd = sourceEnd;
			}
			if (targetEnd != null)
			{
				associationType.TargetEnd = targetEnd;
			}
			if (constraint != null)
			{
				associationType.AddReferentialConstraint(constraint);
			}
			if (metadataProperties != null)
			{
				associationType.AddMetadataProperties(metadataProperties);
			}
			associationType.SetReadOnly();
			return associationType;
		}

		// Token: 0x0400131E RID: 4894
		internal volatile int Index = -1;

		// Token: 0x0400131F RID: 4895
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> _referentialConstraints;

		// Token: 0x04001320 RID: 4896
		private global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.Metadata.Edm.EdmMember> _associationEndMembers;

		// Token: 0x04001321 RID: 4897
		private bool _isForeignKey;
	}
}
