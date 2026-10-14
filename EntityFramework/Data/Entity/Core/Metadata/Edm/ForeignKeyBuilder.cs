using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004C7 RID: 1223
	internal class ForeignKeyBuilder : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem, global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem
	{
		// Token: 0x06003C82 RID: 15490 RVA: 0x000C7D32 File Offset: 0x000C5F32
		internal ForeignKeyBuilder()
		{
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x000C7D3C File Offset: 0x000C5F3C
		public ForeignKeyBuilder(global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, string name)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>(database, "database");
			this._database = database;
			this._associationType = new global::System.Data.Entity.Core.Metadata.Edm.AssociationType(name, "CodeFirstDatabaseSchema", true, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
			this._associationSet = new global::System.Data.Entity.Core.Metadata.Edm.AssociationSet(this._associationType.Name, this._associationType);
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06003C84 RID: 15492 RVA: 0x000C7D91 File Offset: 0x000C5F91
		// (set) Token: 0x06003C85 RID: 15493 RVA: 0x000C7D9E File Offset: 0x000C5F9E
		public string Name
		{
			get
			{
				return this._associationType.Name;
			}
			set
			{
				this._associationType.Name = value;
				this._associationSet.Name = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06003C86 RID: 15494 RVA: 0x000C7DB8 File Offset: 0x000C5FB8
		// (set) Token: 0x06003C87 RID: 15495 RVA: 0x000C7DCC File Offset: 0x000C5FCC
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EntityType PrincipalTable
		{
			get
			{
				return this._associationType.SourceEnd.GetEntityType();
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._associationType.SourceEnd = new global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember(value.Name, value);
				this._associationSet.SourceSet = this._database.GetEntitySet(value);
				if (this._associationType.TargetEnd != null && value.Name == this._associationType.TargetEnd.Name)
				{
					this._associationType.TargetEnd.Name = value.Name + "Self";
				}
			}
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x000C7E64 File Offset: 0x000C6064
		public virtual void SetOwner(global::System.Data.Entity.Core.Metadata.Edm.EntityType owner)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			if (owner == null)
			{
				this._database.RemoveAssociationType(this._associationType);
				return;
			}
			this._associationType.TargetEnd = new global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember((owner != this.PrincipalTable) ? owner.Name : (owner.Name + "Self"), owner);
			this._associationSet.TargetSet = this._database.GetEntitySet(owner);
			if (!this._database.AssociationTypes.Contains(this._associationType))
			{
				this._database.AddAssociationType(this._associationType);
				this._database.AddAssociationSet(this._associationSet);
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06003C89 RID: 15497 RVA: 0x000C7F10 File Offset: 0x000C6110
		// (set) Token: 0x06003C8A RID: 15498 RVA: 0x000C7F44 File Offset: 0x000C6144
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> DependentColumns
		{
			get
			{
				if (this._associationType.Constraint == null)
				{
					return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				}
				return this._associationType.Constraint.ToProperties;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._associationType.Constraint = new global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint(this._associationType.SourceEnd, this._associationType.TargetEnd, this.PrincipalTable.KeyProperties, value);
				this.SetMultiplicities();
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06003C8B RID: 15499 RVA: 0x000C7F9B File Offset: 0x000C619B
		// (set) Token: 0x06003C8C RID: 15500 RVA: 0x000C7FBC File Offset: 0x000C61BC
		public global::System.Data.Entity.Core.Metadata.Edm.OperationAction DeleteAction
		{
			get
			{
				if (this._associationType.SourceEnd == null)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None;
				}
				return this._associationType.SourceEnd.DeleteBehavior;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._associationType.SourceEnd.DeleteBehavior = value;
			}
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x000C7FD8 File Offset: 0x000C61D8
		private void SetMultiplicities()
		{
			this._associationType.SourceEnd.RelationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne;
			this._associationType.TargetEnd.RelationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentTable = this._associationType.TargetEnd.GetEntityType();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = (from key in dependentTable.KeyProperties
			where dependentTable.DeclaredMembers.Contains(key)
			select key).ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			if (list.Count == this.DependentColumns.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() && list.All(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool>(this.DependentColumns.Contains<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>)))
			{
				this._associationType.SourceEnd.RelationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
				this._associationType.TargetEnd.RelationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne;
				return;
			}
			if (!this.DependentColumns.Any((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Nullable))
			{
				this._associationType.SourceEnd.RelationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06003C8E RID: 15502 RVA: 0x000C80D1 File Offset: 0x000C62D1
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06003C8F RID: 15503 RVA: 0x000C80D8 File Offset: 0x000C62D8
		string global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem.Identity
		{
			get
			{
				return this.Identity;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06003C90 RID: 15504 RVA: 0x000C80E0 File Offset: 0x000C62E0
		internal override string Identity
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x040014D5 RID: 5333
		private const string SelfRefSuffix = "Self";

		// Token: 0x040014D6 RID: 5334
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModel _database;

		// Token: 0x040014D7 RID: 5335
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationType _associationType;

		// Token: 0x040014D8 RID: 5336
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationSet _associationSet;
	}
}
