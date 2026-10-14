using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004E7 RID: 1255
	public class ObjectItemCollection : global::System.Data.Entity.Core.Metadata.Edm.ItemCollection
	{
		// Token: 0x06003EA5 RID: 16037 RVA: 0x000CFAF8 File Offset: 0x000CDCF8
		public ObjectItemCollection() : this(null)
		{
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x000CFB04 File Offset: 0x000CDD04
		internal ObjectItemCollection(global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet knownAssembliesSet = null) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)
		{
			this._knownAssemblies = (knownAssembliesSet ?? new global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet());
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType in global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.Instance.GetStoreTypes())
			{
				base.AddInternal(primitiveType);
				this._primitiveTypeMaps.Add(primitiveType);
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06003EA7 RID: 16039 RVA: 0x000CFBA4 File Offset: 0x000CDDA4
		// (set) Token: 0x06003EA8 RID: 16040 RVA: 0x000CFBAC File Offset: 0x000CDDAC
		internal bool OSpaceTypesLoaded { get; set; }

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06003EA9 RID: 16041 RVA: 0x000CFBB5 File Offset: 0x000CDDB5
		internal object LoadAssemblyLock
		{
			get
			{
				return this._loadAssemblyLock;
			}
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x000CFBBD File Offset: 0x000CDDBD
		internal void ImplicitLoadAllReferencedAssemblies(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.ShouldFilterAssembly(assembly))
			{
				this.LoadAssemblyFromCache(assembly, true, edmItemCollection, null);
			}
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x000CFBD2 File Offset: 0x000CDDD2
		public void LoadFromAssembly(global::System.Reflection.Assembly assembly)
		{
			this.ExplicitLoadFromAssembly(assembly, null, null);
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x000CFBDD File Offset: 0x000CDDDD
		public void LoadFromAssembly(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Action<string> logLoadMessage)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.Assembly>(assembly, "assembly");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection>(edmItemCollection, "edmItemCollection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<string>>(logLoadMessage, "logLoadMessage");
			this.ExplicitLoadFromAssembly(assembly, edmItemCollection, logLoadMessage);
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x000CFC0C File Offset: 0x000CDE0C
		public void LoadFromAssembly(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.Assembly>(assembly, "assembly");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection>(edmItemCollection, "edmItemCollection");
			this.ExplicitLoadFromAssembly(assembly, edmItemCollection, null);
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x000CFC2F File Offset: 0x000CDE2F
		internal void ExplicitLoadFromAssembly(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Action<string> logLoadMessage)
		{
			this.LoadAssemblyFromCache(assembly, false, edmItemCollection, logLoadMessage);
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x000CFC3C File Offset: 0x000CDE3C
		internal bool ImplicitLoadAssemblyForType(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			bool flag = false;
			if (!global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.ShouldFilterAssembly(type.Assembly()))
			{
				flag = this.LoadAssemblyFromCache(type.Assembly(), false, edmItemCollection, null);
			}
			if (type.IsGenericType())
			{
				foreach (global::System.Type type2 in type.GetGenericArguments())
				{
					flag |= this.ImplicitLoadAssemblyForType(type2, edmItemCollection);
				}
			}
			return flag;
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x000CFC98 File Offset: 0x000CDE98
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationType GetRelationshipType(string relationshipName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType result;
			if (base.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(relationshipName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x000CFCB4 File Offset: 0x000CDEB4
		private bool LoadAssemblyFromCache(global::System.Reflection.Assembly assembly, bool loadReferencedAssemblies, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Action<string> logLoadMessage)
		{
			if (this.OSpaceTypesLoaded)
			{
				return true;
			}
			object loadAssemblyLock;
			if (edmItemCollection != null)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> items = edmItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>();
				if (items.Any<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>())
				{
					if (items.All((global::System.Data.Entity.Core.Metadata.Edm.EntityContainer c) => c.Annotations.Any((global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty a) => a.Name == "http://schemas.microsoft.com/ado/2013/11/edm/customannotation:UseClrTypes" && ((string)a.Value).ToUpperInvariant() == "TRUE")))
					{
						loadAssemblyLock = this.LoadAssemblyLock;
						lock (loadAssemblyLock)
						{
							if (!this.OSpaceTypesLoaded)
							{
								new global::System.Data.Entity.Core.Metadata.Edm.CodeFirstOSpaceLoader(null).LoadTypes(edmItemCollection, this);
							}
							return true;
						}
					}
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry knownAssemblyEntry;
			if (this._knownAssemblies.TryGetKnownAssembly(assembly, this._loaderCookie, edmItemCollection, out knownAssemblyEntry))
			{
				if (!loadReferencedAssemblies)
				{
					return knownAssemblyEntry.CacheEntry.TypesInAssembly.Count != 0;
				}
				if (knownAssemblyEntry.ReferencedAssembliesAreLoaded)
				{
					return true;
				}
			}
			loadAssemblyLock = this.LoadAssemblyLock;
			bool result;
			lock (loadAssemblyLock)
			{
				if (this._knownAssemblies.TryGetKnownAssembly(assembly, this._loaderCookie, edmItemCollection, out knownAssemblyEntry) && (!loadReferencedAssemblies || knownAssemblyEntry.ReferencedAssembliesAreLoaded))
				{
					result = true;
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet knownAssemblies = new global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet(this._knownAssemblies);
					global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> dictionary;
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> list;
					global::System.Data.Entity.Core.Metadata.Edm.AssemblyCache.LoadAssembly(assembly, loadReferencedAssemblies, knownAssemblies, edmItemCollection, logLoadMessage, ref this._loaderCookie, out dictionary, out list);
					if (list.Count != 0)
					{
						throw global::System.Data.Entity.Core.EntityUtil.InvalidSchemaEncountered(global::System.Data.Entity.Core.Metadata.Edm.Helper.CombineErrorMessage(list));
					}
					if (dictionary.Count != 0)
					{
						this.AddLoadedTypes(dictionary);
					}
					this._knownAssemblies = knownAssemblies;
					result = (dictionary.Count != 0);
				}
			}
			return result;
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x000CFE34 File Offset: 0x000CE034
		internal virtual void AddLoadedTypes(global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> typesInLoading)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in typesInLoading.Values)
			{
				list.Add(edmType);
				string text = "";
				try
				{
					if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType))
					{
						text = ((global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType)edmType).CSpaceTypeName;
						this._ocMapping.Add(text, edmType);
					}
					else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(edmType))
					{
						text = ((global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType)edmType).CSpaceTypeName;
						this._ocMapping.Add(text, edmType);
					}
					else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmType))
					{
						text = ((global::System.Data.Entity.Core.Metadata.Edm.ClrEnumType)edmType).CSpaceTypeName;
						this._ocMapping.Add(text, edmType);
					}
				}
				catch (global::System.ArgumentException innerException)
				{
					throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_CannotMapCLRTypeMultipleTimes(text), innerException);
				}
			}
			base.AddRange(list);
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x000CFF28 File Offset: 0x000CE128
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetPrimitiveTypes()
		{
			return this._primitiveTypeMaps.GetTypes();
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x000CFF35 File Offset: 0x000CE135
		public global::System.Type GetClrType(global::System.Data.Entity.Core.Metadata.Edm.StructuralType objectSpaceType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection.GetClrType(objectSpaceType);
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x000CFF3D File Offset: 0x000CE13D
		public bool TryGetClrType(global::System.Data.Entity.Core.Metadata.Edm.StructuralType objectSpaceType, out global::System.Type clrType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection.TryGetClrType(objectSpaceType, out clrType);
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x000CFF46 File Offset: 0x000CE146
		public global::System.Type GetClrType(global::System.Data.Entity.Core.Metadata.Edm.EnumType objectSpaceType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection.GetClrType(objectSpaceType);
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x000CFF4E File Offset: 0x000CE14E
		public bool TryGetClrType(global::System.Data.Entity.Core.Metadata.Edm.EnumType objectSpaceType, out global::System.Type clrType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection.TryGetClrType(objectSpaceType, out clrType);
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x000CFF58 File Offset: 0x000CE158
		private static global::System.Type GetClrType(global::System.Data.Entity.Core.Metadata.Edm.EdmType objectSpaceType)
		{
			global::System.Type result;
			if (!global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection.TryGetClrType(objectSpaceType, out result))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.FailedToFindClrTypeMapping(objectSpaceType.Identity));
			}
			return result;
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x000CFF84 File Offset: 0x000CE184
		private static bool TryGetClrType(global::System.Data.Entity.Core.Metadata.Edm.EdmType objectSpaceType, out global::System.Type clrType)
		{
			if (objectSpaceType.DataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ArgumentMustBeOSpaceType, "objectSpaceType");
			}
			clrType = null;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(objectSpaceType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(objectSpaceType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(objectSpaceType))
			{
				clrType = objectSpaceType.ClrType;
			}
			return clrType != null;
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x000CFFD4 File Offset: 0x000CE1D4
		internal override global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType GetMappedPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind modelType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeometricTypeKind(modelType))
			{
				modelType = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry;
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicTypeKind(modelType))
			{
				modelType = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography;
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType result = null;
			this._primitiveTypeMaps.TryGetType(modelType, null, out result);
			return result;
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x000D000E File Offset: 0x000CE20E
		internal bool TryGetOSpaceType(global::System.Data.Entity.Core.Metadata.Edm.EdmType cspaceType, out global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(cspaceType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(cspaceType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(cspaceType))
			{
				return this._ocMapping.TryGetValue(cspaceType.Identity, out edmType);
			}
			return base.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(cspaceType.Identity, out edmType);
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x000D0048 File Offset: 0x000CE248
		internal static string TryGetMappingCSpaceTypeIdentity(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType))
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType)edmType).CSpaceTypeName;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(edmType))
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType)edmType).CSpaceTypeName;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmType))
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.ClrEnumType)edmType).CSpaceTypeName;
			}
			return edmType.Identity;
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x000D0097 File Offset: 0x000CE297
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<T> GetItems<T>()
		{
			return base.InternalGetItems(typeof(T)) as global::System.Collections.ObjectModel.ReadOnlyCollection<T>;
		}

		// Token: 0x0400153C RID: 5436
		private readonly global::System.Data.Entity.Core.Metadata.Edm.CacheForPrimitiveTypes _primitiveTypeMaps = new global::System.Data.Entity.Core.Metadata.Edm.CacheForPrimitiveTypes();

		// Token: 0x0400153D RID: 5437
		private global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet _knownAssemblies = new global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet();

		// Token: 0x0400153E RID: 5438
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> _ocMapping = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType>();

		// Token: 0x0400153F RID: 5439
		private object _loaderCookie;

		// Token: 0x04001540 RID: 5440
		private readonly object _loadAssemblyLock = new object();
	}
}
