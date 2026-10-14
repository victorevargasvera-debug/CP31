using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000488 RID: 1160
	public sealed class AssociationSet : global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet
	{
		// Token: 0x060039AF RID: 14767 RVA: 0x000BD0BC File Offset: 0x000BB2BC
		internal AssociationSet(string name, global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType) : base(name, null, null, null, associationType)
		{
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060039B0 RID: 14768 RVA: 0x000BD0D9 File Offset: 0x000BB2D9
		public new global::System.Data.Entity.Core.Metadata.Edm.AssociationType ElementType
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)base.ElementType;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060039B1 RID: 14769 RVA: 0x000BD0E6 File Offset: 0x000BB2E6
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSetEnd, true)]
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> AssociationSetEnds
		{
			get
			{
				return this._associationSetEnds;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060039B2 RID: 14770 RVA: 0x000BD0F0 File Offset: 0x000BB2F0
		// (set) Token: 0x060039B3 RID: 14771 RVA: 0x000BD114 File Offset: 0x000BB314
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet SourceSet
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = this.AssociationSetEnds.FirstOrDefault<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>();
				if (associationSetEnd == null)
				{
					return null;
				}
				return associationSetEnd.EntitySet;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = new global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd(value, this, this.ElementType.SourceEnd);
				if (this.AssociationSetEnds.Count == 0)
				{
					this.AddAssociationSetEnd(associationSetEnd);
					return;
				}
				this.AssociationSetEnds.Source[0] = associationSetEnd;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060039B4 RID: 14772 RVA: 0x000BD164 File Offset: 0x000BB364
		// (set) Token: 0x060039B5 RID: 14773 RVA: 0x000BD18C File Offset: 0x000BB38C
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet TargetSet
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = this.AssociationSetEnds.ElementAtOrDefault(1);
				if (associationSetEnd == null)
				{
					return null;
				}
				return associationSetEnd.EntitySet;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = new global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd(value, this, this.ElementType.TargetEnd);
				if (this.AssociationSetEnds.Count == 1)
				{
					this.AddAssociationSetEnd(associationSetEnd);
					return;
				}
				this.AssociationSetEnds.Source[1] = associationSetEnd;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060039B6 RID: 14774 RVA: 0x000BD1DC File Offset: 0x000BB3DC
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember SourceEnd
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = this.AssociationSetEnds.FirstOrDefault<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>();
				if (associationSetEnd == null)
				{
					return null;
				}
				return this.ElementType.KeyMembers.OfType<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>().SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember e) => e.Name == associationSetEnd.Name);
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060039B7 RID: 14775 RVA: 0x000BD22C File Offset: 0x000BB42C
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember TargetEnd
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = this.AssociationSetEnds.ElementAtOrDefault(1);
				if (associationSetEnd == null)
				{
					return null;
				}
				return this.ElementType.KeyMembers.OfType<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>().SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember e) => e.Name == associationSetEnd.Name);
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060039B8 RID: 14776 RVA: 0x000BD27C File Offset: 0x000BB47C
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet;
			}
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x000BD27F File Offset: 0x000BB47F
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
				this.AssociationSetEnds.Source.SetReadOnly();
			}
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x000BD2A0 File Offset: 0x000BB4A0
		internal void AddAssociationSetEnd(global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd)
		{
			this.AssociationSetEnds.Source.Add(associationSetEnd);
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x000BD2B4 File Offset: 0x000BB4B4
		public static global::System.Data.Entity.Core.Metadata.Edm.AssociationSet Create(string name, global::System.Data.Entity.Core.Metadata.Edm.AssociationType type, global::System.Data.Entity.Core.Metadata.Edm.EntitySet sourceSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet targetSet, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(type, "type");
			if (!global::System.Data.Entity.Core.Metadata.Edm.AssociationSet.CheckEntitySetAgainstEndMember(sourceSet, type.SourceEnd) || !global::System.Data.Entity.Core.Metadata.Edm.AssociationSet.CheckEntitySetAgainstEndMember(targetSet, type.TargetEnd))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.AssociationSet_EndEntityTypeMismatch);
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = new global::System.Data.Entity.Core.Metadata.Edm.AssociationSet(name, type);
			if (sourceSet != null)
			{
				associationSet.SourceSet = sourceSet;
			}
			if (targetSet != null)
			{
				associationSet.TargetSet = targetSet;
			}
			if (metadataProperties != null)
			{
				associationSet.AddMetadataProperties(metadataProperties);
			}
			associationSet.SetReadOnly();
			return associationSet;
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x000BD32F File Offset: 0x000BB52F
		private static bool CheckEntitySetAgainstEndMember(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endMember)
		{
			return (entitySet == null && endMember == null) || (entitySet != null && endMember != null && entitySet.ElementType == endMember.GetEntityType());
		}

		// Token: 0x0400131A RID: 4890
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> _associationSetEnds = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>(new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>());
	}
}
