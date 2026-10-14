using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004B8 RID: 1208
	public class EntityContainer : global::System.Data.Entity.Core.Metadata.Edm.GlobalItem
	{
		// Token: 0x06003BC7 RID: 15303 RVA: 0x000C5710 File Offset: 0x000C3910
		internal EntityContainer()
		{
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x000C5724 File Offset: 0x000C3924
		public EntityContainer(string name, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._name = name;
			this.DataSpace = dataSpace;
			this._baseEntitySets = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(new global::System.Data.Entity.Core.Metadata.Edm.EntitySetBaseCollection(this));
			this._functionImports = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>());
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06003BC9 RID: 15305 RVA: 0x000C577D File Offset: 0x000C397D
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityContainer;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06003BCA RID: 15306 RVA: 0x000C5781 File Offset: 0x000C3981
		internal override string Identity
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06003BCB RID: 15307 RVA: 0x000C5789 File Offset: 0x000C3989
		// (set) Token: 0x06003BCC RID: 15308 RVA: 0x000C5791 File Offset: 0x000C3991
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._name = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06003BCD RID: 15309 RVA: 0x000C57AC File Offset: 0x000C39AC
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySetBase, true)]
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> BaseEntitySets
		{
			get
			{
				return this._baseEntitySets;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06003BCE RID: 15310 RVA: 0x000C57B4 File Offset: 0x000C39B4
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> AssociationSets
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> associationSetsCache = this._associationSetsCache;
				if (associationSetsCache == null)
				{
					object baseEntitySetsLock = this._baseEntitySetsLock;
					lock (baseEntitySetsLock)
					{
						if (this._associationSetsCache == null)
						{
							this._baseEntitySets.SourceAccessed += this.ResetAssociationSetsCache;
							this._associationSetsCache = new global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(this._baseEntitySets, new global::System.Predicate<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssociationSet));
						}
						associationSetsCache = this._associationSetsCache;
					}
				}
				return associationSetsCache;
			}
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x000C583C File Offset: 0x000C3A3C
		private void ResetAssociationSetsCache(object sender, global::System.EventArgs e)
		{
			if (this._associationSetsCache != null)
			{
				object baseEntitySetsLock = this._baseEntitySetsLock;
				lock (baseEntitySetsLock)
				{
					if (this._associationSetsCache != null)
					{
						this._associationSetsCache = null;
						this._baseEntitySets.SourceAccessed -= this.ResetAssociationSetsCache;
					}
				}
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x000C58A4 File Offset: 0x000C3AA4
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> EntitySets
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySetsCache = this._entitySetsCache;
				if (entitySetsCache == null)
				{
					object baseEntitySetsLock = this._baseEntitySetsLock;
					lock (baseEntitySetsLock)
					{
						if (this._entitySetsCache == null)
						{
							this._baseEntitySets.SourceAccessed += this.ResetEntitySetsCache;
							this._entitySetsCache = new global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(this._baseEntitySets, new global::System.Predicate<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntitySet));
						}
						entitySetsCache = this._entitySetsCache;
					}
				}
				return entitySetsCache;
			}
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x000C592C File Offset: 0x000C3B2C
		private void ResetEntitySetsCache(object sender, global::System.EventArgs e)
		{
			if (this._entitySetsCache != null)
			{
				object baseEntitySetsLock = this._baseEntitySetsLock;
				lock (baseEntitySetsLock)
				{
					if (this._entitySetsCache != null)
					{
						this._entitySetsCache = null;
						this._baseEntitySets.SourceAccessed -= this.ResetEntitySetsCache;
					}
				}
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06003BD2 RID: 15314 RVA: 0x000C5994 File Offset: 0x000C3B94
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmFunction, true)]
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> FunctionImports
		{
			get
			{
				return this._functionImports;
			}
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x000C599C File Offset: 0x000C3B9C
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
				this.BaseEntitySets.Source.SetReadOnly();
				this.FunctionImports.Source.SetReadOnly();
			}
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x000C59D0 File Offset: 0x000C3BD0
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySetByName(string name, bool ignoreCase)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = this.BaseEntitySets.GetValue(name, ignoreCase) as global::System.Data.Entity.Core.Metadata.Edm.EntitySet;
			if (entitySet != null)
			{
				return entitySet;
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidEntitySetName(name));
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x000C5A00 File Offset: 0x000C3C00
		public bool TryGetEntitySetByName(string name, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase = null;
			entitySet = null;
			if (this.BaseEntitySets.TryGetValue(name, ignoreCase, out entitySetBase) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntitySet(entitySetBase))
			{
				entitySet = (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)entitySetBase;
				return true;
			}
			return false;
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x000C5A44 File Offset: 0x000C3C44
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet GetRelationshipSetByName(string name, bool ignoreCase)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet result;
			if (!this.TryGetRelationshipSetByName(name, ignoreCase, out result))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidRelationshipSetName(name));
			}
			return result;
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x000C5A6C File Offset: 0x000C3C6C
		public bool TryGetRelationshipSetByName(string name, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase = null;
			relationshipSet = null;
			if (this.BaseEntitySets.TryGetValue(name, ignoreCase, out entitySetBase) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRelationshipSet(entitySetBase))
			{
				relationshipSet = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet)entitySetBase;
				return true;
			}
			return false;
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x000C5AAE File Offset: 0x000C3CAE
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x000C5AB6 File Offset: 0x000C3CB6
		public void AddEntitySetBase(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(entitySetBase, "entitySetBase");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			this._baseEntitySets.Source.Add(entitySetBase);
			entitySetBase.ChangeEntityContainerWithoutCollectionFixup(this);
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x000C5AE2 File Offset: 0x000C3CE2
		public void RemoveEntitySetBase(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(entitySetBase, "entitySetBase");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			this._baseEntitySets.Source.Remove(entitySetBase);
			entitySetBase.ChangeEntityContainerWithoutCollectionFixup(null);
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x000C5B0F File Offset: 0x000C3D0F
		public void AddFunctionImport(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(function, "function");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			if (!function.IsFunctionImport)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.OnlyFunctionImportsCanBeAddedToEntityContainer(function.Name));
			}
			this._functionImports.Source.Add(function);
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x000C5B50 File Offset: 0x000C3D50
		public static global::System.Data.Entity.Core.Metadata.Edm.EntityContainer Create(string name, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> entitySets, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionImports, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer = new global::System.Data.Entity.Core.Metadata.Edm.EntityContainer(name, dataSpace);
			if (entitySets != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entitySets)
				{
					entityContainer.AddEntitySetBase(entitySetBase);
				}
			}
			if (functionImports != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction in functionImports)
				{
					if (!edmFunction.IsFunctionImport)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.OnlyFunctionImportsCanBeAddedToEntityContainer(edmFunction.Name));
					}
					entityContainer.AddFunctionImport(edmFunction);
				}
			}
			if (metadataProperties != null)
			{
				entityContainer.AddMetadataProperties(metadataProperties);
			}
			entityContainer.SetReadOnly();
			return entityContainer;
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x000C5C1C File Offset: 0x000C3E1C
		internal virtual void NotifyItemIdentityChanged(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase item, string initialIdentity)
		{
			this._baseEntitySets.Source.HandleIdentityChange(item, initialIdentity);
		}

		// Token: 0x04001496 RID: 5270
		private string _name;

		// Token: 0x04001497 RID: 5271
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> _baseEntitySets;

		// Token: 0x04001498 RID: 5272
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> _functionImports;

		// Token: 0x04001499 RID: 5273
		private readonly object _baseEntitySetsLock = new object();

		// Token: 0x0400149A RID: 5274
		private global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> _associationSetsCache;

		// Token: 0x0400149B RID: 5275
		private global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> _entitySetsCache;
	}
}
