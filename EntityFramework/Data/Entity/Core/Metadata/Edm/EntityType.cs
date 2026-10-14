using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004BC RID: 1212
	public class EntityType : global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase
	{
		// Token: 0x06003C04 RID: 15364 RVA: 0x000C6096 File Offset: 0x000C4296
		internal EntityType(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace) : base(name, namespaceName, dataSpace)
		{
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x000C60B7 File Offset: 0x000C42B7
		internal EntityType(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Collections.Generic.IEnumerable<string> keyMemberNames, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> members) : base(name, namespaceName, dataSpace)
		{
			if (members != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase.CheckAndAddMembers(members, this);
			}
			if (keyMemberNames != null)
			{
				base.CheckAndAddKeyMembers(keyMemberNames);
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06003C06 RID: 15366 RVA: 0x000C60F0 File Offset: 0x000C42F0
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> ForeignKeyBuilders
		{
			get
			{
				return this._foreignKeyBuilders;
			}
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x000C60F8 File Offset: 0x000C42F8
		internal void RemoveForeignKey(global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder foreignKeyBuilder)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			foreignKeyBuilder.SetOwner(null);
			this._foreignKeyBuilders.Remove(foreignKeyBuilder);
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x000C6114 File Offset: 0x000C4314
		internal void AddForeignKey(global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder foreignKeyBuilder)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			foreignKeyBuilder.SetOwner(this);
			this._foreignKeyBuilders.Add(foreignKeyBuilder);
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x000C612F File Offset: 0x000C432F
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType;
			}
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x000C6133 File Offset: 0x000C4333
		internal override void ValidateMemberForAdd(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06003C0B RID: 15371 RVA: 0x000C6135 File Offset: 0x000C4335
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> DeclaredNavigationProperties
		{
			get
			{
				return base.GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>();
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06003C0C RID: 15372 RVA: 0x000C6140 File Offset: 0x000C4340
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> NavigationProperties
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> navigationPropertiesCache = this._navigationPropertiesCache;
				if (navigationPropertiesCache == null)
				{
					object navigationPropertiesCacheLock = this._navigationPropertiesCacheLock;
					lock (navigationPropertiesCacheLock)
					{
						if (this._navigationPropertiesCache == null)
						{
							base.Members.SourceAccessed += this.ResetNavigationProperties;
							this._navigationPropertiesCache = new global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(base.Members, new global::System.Predicate<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsNavigationProperty));
						}
						navigationPropertiesCache = this._navigationPropertiesCache;
					}
				}
				return navigationPropertiesCache;
			}
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x000C61C8 File Offset: 0x000C43C8
		private void ResetNavigationProperties(object sender, global::System.EventArgs e)
		{
			if (this._navigationPropertiesCache != null)
			{
				object navigationPropertiesCacheLock = this._navigationPropertiesCacheLock;
				lock (navigationPropertiesCacheLock)
				{
					if (this._navigationPropertiesCache != null)
					{
						this._navigationPropertiesCache = null;
						base.Members.SourceAccessed -= this.ResetNavigationProperties;
					}
				}
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06003C0E RID: 15374 RVA: 0x000C6230 File Offset: 0x000C4430
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> DeclaredProperties
		{
			get
			{
				return base.GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06003C0F RID: 15375 RVA: 0x000C6238 File Offset: 0x000C4438
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> DeclaredMembers
		{
			get
			{
				return base.GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06003C10 RID: 15376 RVA: 0x000C6240 File Offset: 0x000C4440
		public virtual global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> Properties
		{
			get
			{
				if (!base.IsReadOnly)
				{
					return new global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(base.Members, new global::System.Predicate<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEdmProperty));
				}
				if (this._properties == null)
				{
					global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>(ref this._properties, new global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(base.Members, new global::System.Predicate<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEdmProperty)), null);
				}
				return this._properties;
			}
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x000C629F File Offset: 0x000C449F
		public global::System.Data.Entity.Core.Metadata.Edm.RefType GetReferenceType()
		{
			if (this._referenceType == null)
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.RefType>(ref this._referenceType, new global::System.Data.Entity.Core.Metadata.Edm.RefType(this), null);
			}
			return this._referenceType;
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x000C62C4 File Offset: 0x000C44C4
		internal global::System.Data.Entity.Core.Metadata.Edm.RowType GetKeyRowType()
		{
			if (this._keyRow == null)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(this.KeyMembers.Count);
				list.AddRange(from keyMember in this.KeyMembers
				select new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(keyMember.Name, global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(keyMember)));
				global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.RowType>(ref this._keyRow, new global::System.Data.Entity.Core.Metadata.Edm.RowType(list), null);
			}
			return this._keyRow;
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x000C6334 File Offset: 0x000C4534
		internal bool TryGetNavigationProperty(string relationshipType, string fromName, string toName, out global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty2 in this.NavigationProperties)
			{
				if (navigationProperty2.RelationshipType.FullName == relationshipType && navigationProperty2.FromEndMember.Name == fromName && navigationProperty2.ToEndMember.Name == toName)
				{
					navigationProperty = navigationProperty2;
					return true;
				}
			}
			navigationProperty = null;
			return false;
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x000C63C8 File Offset: 0x000C45C8
		public static global::System.Data.Entity.Core.Metadata.Edm.EntityType Create(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Collections.Generic.IEnumerable<string> keyMemberNames, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> members, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(namespaceName, "namespaceName");
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = new global::System.Data.Entity.Core.Metadata.Edm.EntityType(name, namespaceName, dataSpace, keyMemberNames, members);
			if (metadataProperties != null)
			{
				entityType.AddMetadataProperties(metadataProperties);
			}
			entityType.SetReadOnly();
			return entityType;
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x000C640C File Offset: 0x000C460C
		public static global::System.Data.Entity.Core.Metadata.Edm.EntityType Create(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Metadata.Edm.EntityType baseType, global::System.Collections.Generic.IEnumerable<string> keyMemberNames, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> members, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(namespaceName, "namespaceName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(baseType, "baseType");
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = new global::System.Data.Entity.Core.Metadata.Edm.EntityType(name, namespaceName, dataSpace, keyMemberNames, members)
			{
				BaseType = baseType
			};
			if (metadataProperties != null)
			{
				entityType.AddMetadataProperties(metadataProperties);
			}
			entityType.SetReadOnly();
			return entityType;
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x000C6464 File Offset: 0x000C4664
		public void AddNavigationProperty(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty property)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(property, "property");
			base.AddMember(property, true);
		}

		// Token: 0x040014A8 RID: 5288
		private global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> _properties;

		// Token: 0x040014A9 RID: 5289
		private global::System.Data.Entity.Core.Metadata.Edm.RefType _referenceType;

		// Token: 0x040014AA RID: 5290
		private global::System.Data.Entity.Core.Metadata.Edm.RowType _keyRow;

		// Token: 0x040014AB RID: 5291
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> _foreignKeyBuilders = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder>();

		// Token: 0x040014AC RID: 5292
		private readonly object _navigationPropertiesCacheLock = new object();

		// Token: 0x040014AD RID: 5293
		private global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> _navigationPropertiesCache;
	}
}
