using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Utilities;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004B9 RID: 1209
	public class EntitySet : global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase
	{
		// Token: 0x06003BDE RID: 15326 RVA: 0x000C5C30 File Offset: 0x000C3E30
		internal EntitySet()
		{
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x000C5C38 File Offset: 0x000C3E38
		internal EntitySet(string name, string schema, string table, string definingQuery, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType) : base(name, schema, table, definingQuery, entityType)
		{
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06003BE0 RID: 15328 RVA: 0x000C5C47 File Offset: 0x000C3E47
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x000C5C4B File Offset: 0x000C3E4B
		public new virtual global::System.Data.Entity.Core.Metadata.Edm.EntityType ElementType
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.EntityType)base.ElementType;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06003BE2 RID: 15330 RVA: 0x000C5C58 File Offset: 0x000C3E58
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> ForeignKeyDependents
		{
			get
			{
				if (this._foreignKeyDependents == null)
				{
					this.InitializeForeignKeyLists();
				}
				return this._foreignKeyDependents;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06003BE3 RID: 15331 RVA: 0x000C5C6E File Offset: 0x000C3E6E
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> ForeignKeyPrincipals
		{
			get
			{
				if (this._foreignKeyPrincipals == null)
				{
					this.InitializeForeignKeyLists();
				}
				return this._foreignKeyPrincipals;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x000C5C84 File Offset: 0x000C3E84
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> AssociationSets
		{
			get
			{
				if (this._foreignKeyPrincipals == null)
				{
					this.InitializeForeignKeyLists();
				}
				return this._associationSets;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06003BE5 RID: 15333 RVA: 0x000C5C9A File Offset: 0x000C3E9A
		internal bool HasForeignKeyRelationships
		{
			get
			{
				if (this._foreignKeyPrincipals == null)
				{
					this.InitializeForeignKeyLists();
				}
				return this._hasForeignKeyRelationships;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x000C5CB2 File Offset: 0x000C3EB2
		internal bool HasIndependentRelationships
		{
			get
			{
				if (this._foreignKeyPrincipals == null)
				{
					this.InitializeForeignKeyLists();
				}
				return this._hasIndependentRelationships;
			}
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x000C5CCC File Offset: 0x000C3ECC
		private void InitializeForeignKeyLists()
		{
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> list = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>>();
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> list2 = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>>();
			bool hasForeignKeyRelationships = false;
			bool hasIndependentRelationships = false;
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> readOnlyCollection = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetAssociationsForEntitySet(this));
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in readOnlyCollection)
			{
				if (associationSet.ElementType.IsForeignKey)
				{
					hasForeignKeyRelationships = true;
					global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = associationSet.ElementType.ReferentialConstraints[0];
					if (referentialConstraint.ToRole.GetEntityType().IsAssignableFrom(this.ElementType) || this.ElementType.IsAssignableFrom(referentialConstraint.ToRole.GetEntityType()))
					{
						list.Add(new global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>(associationSet, referentialConstraint));
					}
					if (referentialConstraint.FromRole.GetEntityType().IsAssignableFrom(this.ElementType) || this.ElementType.IsAssignableFrom(referentialConstraint.FromRole.GetEntityType()))
					{
						list2.Add(new global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>(associationSet, referentialConstraint));
					}
				}
				else
				{
					hasIndependentRelationships = true;
				}
			}
			this._hasForeignKeyRelationships = hasForeignKeyRelationships;
			this._hasIndependentRelationships = hasIndependentRelationships;
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> value = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>>(list);
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> value2 = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>>(list2);
			global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>>>(ref this._foreignKeyDependents, value, null);
			global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>>>(ref this._foreignKeyPrincipals, value2, null);
			global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>>(ref this._associationSets, readOnlyCollection, null);
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x000C5E34 File Offset: 0x000C4034
		public static global::System.Data.Entity.Core.Metadata.Edm.EntitySet Create(string name, string schema, string table, string definingQuery, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityType, "entityType");
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = new global::System.Data.Entity.Core.Metadata.Edm.EntitySet(name, schema, table, definingQuery, entityType);
			if (metadataProperties != null)
			{
				entitySet.AddMetadataProperties(metadataProperties);
			}
			entitySet.SetReadOnly();
			return entitySet;
		}

		// Token: 0x0400149C RID: 5276
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> _foreignKeyDependents;

		// Token: 0x0400149D RID: 5277
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> _foreignKeyPrincipals;

		// Token: 0x0400149E RID: 5278
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> _associationSets;

		// Token: 0x0400149F RID: 5279
		private volatile bool _hasForeignKeyRelationships;

		// Token: 0x040014A0 RID: 5280
		private volatile bool _hasIndependentRelationships;
	}
}
