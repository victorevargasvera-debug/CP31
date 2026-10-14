using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000527 RID: 1319
	internal class DefaultObjectMappingItemCollection : global::System.Data.Entity.Core.Mapping.MappingItemCollection
	{
		// Token: 0x0600410F RID: 16655 RVA: 0x000DAEB4 File Offset: 0x000D90B4
		public DefaultObjectMappingItemCollection(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmCollection, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection objectCollection) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OCSpace)
		{
			this._edmCollection = edmCollection;
			this._objectCollection = objectCollection;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType in this._edmCollection.GetPrimitiveTypes())
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType mappedPrimitiveType = this._objectCollection.GetMappedPrimitiveType(primitiveType.PrimitiveTypeKind);
				this.AddInternalMapping(new global::System.Data.Entity.Core.Mapping.ObjectTypeMapping(mappedPrimitiveType, primitiveType), this._clrTypeIndexes, this._edmTypeIndexes);
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06004110 RID: 16656 RVA: 0x000DAF6C File Offset: 0x000D916C
		public global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection ObjectItemCollection
		{
			get
			{
				return this._objectCollection;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06004111 RID: 16657 RVA: 0x000DAF74 File Offset: 0x000D9174
		public global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection EdmItemCollection
		{
			get
			{
				return this._edmCollection;
			}
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x000DAF7C File Offset: 0x000D917C
		internal override global::System.Data.Entity.Core.Mapping.MappingBase GetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace, bool ignoreCase)
		{
			global::System.Data.Entity.Core.Mapping.MappingBase result;
			if (!this.TryGetMap(identity, typeSpace, ignoreCase, out result))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Mapping_Object_InvalidType(identity));
			}
			return result;
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x000DAFA4 File Offset: 0x000D91A4
		internal override bool TryGetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace, bool ignoreCase, out global::System.Data.Entity.Core.Mapping.MappingBase map)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = null;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = null;
			if (typeSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				if (ignoreCase)
				{
					if (!this._edmCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(identity, true, out edmType))
					{
						map = null;
						return false;
					}
					identity = edmType.Identity;
				}
				int index;
				if (this._edmTypeIndexes.TryGetValue(identity, out index))
				{
					map = (global::System.Data.Entity.Core.Mapping.MappingBase)base[index];
					return true;
				}
				if (edmType != null || this._edmCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(identity, ignoreCase, out edmType))
				{
					this._objectCollection.TryGetOSpaceType(edmType, out edmType2);
				}
			}
			else if (typeSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)
			{
				if (ignoreCase)
				{
					if (!this._objectCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(identity, true, out edmType2))
					{
						map = null;
						return false;
					}
					identity = edmType2.Identity;
				}
				int index2;
				if (this._clrTypeIndexes.TryGetValue(identity, out index2))
				{
					map = (global::System.Data.Entity.Core.Mapping.MappingBase)base[index2];
					return true;
				}
				if (edmType2 != null || this._objectCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(identity, ignoreCase, out edmType2))
				{
					string identity2 = global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection.TryGetMappingCSpaceTypeIdentity(edmType2);
					this._edmCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(identity2, out edmType);
				}
			}
			if (edmType2 == null || edmType == null)
			{
				map = null;
				return false;
			}
			map = this.GetDefaultMapping(edmType, edmType2);
			return true;
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x000DB0AE File Offset: 0x000D92AE
		internal override global::System.Data.Entity.Core.Mapping.MappingBase GetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace)
		{
			return this.GetMap(identity, typeSpace, false);
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x000DB0B9 File Offset: 0x000D92B9
		internal override bool TryGetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace, out global::System.Data.Entity.Core.Mapping.MappingBase map)
		{
			return this.TryGetMap(identity, typeSpace, false, out map);
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x000DB0C8 File Offset: 0x000D92C8
		internal override global::System.Data.Entity.Core.Mapping.MappingBase GetMap(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item)
		{
			global::System.Data.Entity.Core.Mapping.MappingBase result;
			if (!this.TryGetMap(item, out result))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Mapping_Object_InvalidType(item.Identity));
			}
			return result;
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x000DB0F4 File Offset: 0x000D92F4
		internal override bool TryGetMap(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item, out global::System.Data.Entity.Core.Mapping.MappingBase map)
		{
			if (item == null)
			{
				map = null;
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace = item.DataSpace;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = item as global::System.Data.Entity.Core.Metadata.Edm.EdmType;
			if (edmType != null && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsTransientType(edmType))
			{
				map = this.GetOCMapForTransientType(edmType, dataSpace);
				return map != null;
			}
			return this.TryGetMap(item.Identity, dataSpace, out map);
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x000DB142 File Offset: 0x000D9342
		private global::System.Data.Entity.Core.Mapping.MappingBase GetDefaultMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmType cdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType clrType)
		{
			return global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.LoadObjectMapping(cdmType, clrType, this);
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x000DB14C File Offset: 0x000D934C
		private global::System.Data.Entity.Core.Mapping.MappingBase GetOCMapForTransientType(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = null;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType3 = null;
			int index = -1;
			if (typeSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)
			{
				if (this._edmTypeIndexes.TryGetValue(edmType.Identity, out index))
				{
					return (global::System.Data.Entity.Core.Mapping.MappingBase)base[index];
				}
				edmType3 = edmType;
				edmType2 = this.ConvertCSpaceToOSpaceType(edmType);
			}
			else if (typeSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)
			{
				if (this._clrTypeIndexes.TryGetValue(edmType.Identity, out index))
				{
					return (global::System.Data.Entity.Core.Mapping.MappingBase)base[index];
				}
				edmType2 = edmType;
				edmType3 = this.ConvertOSpaceToCSpaceType(edmType2);
			}
			global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectTypeMapping = new global::System.Data.Entity.Core.Mapping.ObjectTypeMapping(edmType2, edmType3);
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType == edmType.BuiltInTypeKind)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType2;
				global::System.Data.Entity.Core.Metadata.Edm.RowType rowType2 = (global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType3;
				for (int i = 0; i < rowType.Properties.Count; i++)
				{
					objectTypeMapping.AddMemberMap(new global::System.Data.Entity.Core.Mapping.ObjectPropertyMapping(rowType2.Properties[i], rowType.Properties[i]));
				}
			}
			if (!this._edmTypeIndexes.ContainsKey(edmType3.Identity) && !this._clrTypeIndexes.ContainsKey(edmType2.Identity))
			{
				object @lock = this._lock;
				lock (@lock)
				{
					global::System.Collections.Generic.Dictionary<string, int> clrTypeIndexes = new global::System.Collections.Generic.Dictionary<string, int>(this._clrTypeIndexes);
					global::System.Collections.Generic.Dictionary<string, int> edmTypeIndexes = new global::System.Collections.Generic.Dictionary<string, int>(this._edmTypeIndexes);
					objectTypeMapping = this.AddInternalMapping(objectTypeMapping, clrTypeIndexes, edmTypeIndexes);
					this._clrTypeIndexes = clrTypeIndexes;
					this._edmTypeIndexes = edmTypeIndexes;
				}
			}
			return objectTypeMapping;
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x000DB2B4 File Offset: 0x000D94B4
		private global::System.Data.Entity.Core.Metadata.Edm.EdmType ConvertCSpaceToOSpaceType(global::System.Data.Entity.Core.Metadata.Edm.EdmType cdmType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType result;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(cdmType))
			{
				result = new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(this.ConvertCSpaceToOSpaceType(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)cdmType).TypeUsage.EdmType));
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(cdmType))
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)cdmType;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in rowType.Properties)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = this.ConvertCSpaceToOSpaceType(edmProperty.TypeUsage.EdmType);
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty item = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(edmProperty.Name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType));
					list.Add(item);
				}
				result = new global::System.Data.Entity.Core.Metadata.Edm.RowType(list, rowType.InitializerMetadata);
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(cdmType))
			{
				result = new global::System.Data.Entity.Core.Metadata.Edm.RefType((global::System.Data.Entity.Core.Metadata.Edm.EntityType)this.ConvertCSpaceToOSpaceType(((global::System.Data.Entity.Core.Metadata.Edm.RefType)cdmType).ElementType));
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(cdmType))
			{
				result = this._objectCollection.GetMappedPrimitiveType(((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)cdmType).PrimitiveTypeKind);
			}
			else
			{
				result = ((global::System.Data.Entity.Core.Mapping.ObjectTypeMapping)this.GetMap(cdmType)).ClrType;
			}
			return result;
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x000DB3DC File Offset: 0x000D95DC
		private global::System.Data.Entity.Core.Metadata.Edm.EdmType ConvertOSpaceToCSpaceType(global::System.Data.Entity.Core.Metadata.Edm.EdmType clrType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType result;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(clrType))
			{
				result = new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(this.ConvertOSpaceToCSpaceType(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)clrType).TypeUsage.EdmType));
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(clrType))
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)clrType;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in rowType.Properties)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = this.ConvertOSpaceToCSpaceType(edmProperty.TypeUsage.EdmType);
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty item = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(edmProperty.Name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType));
					list.Add(item);
				}
				result = new global::System.Data.Entity.Core.Metadata.Edm.RowType(list, rowType.InitializerMetadata);
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(clrType))
			{
				result = new global::System.Data.Entity.Core.Metadata.Edm.RefType((global::System.Data.Entity.Core.Metadata.Edm.EntityType)this.ConvertOSpaceToCSpaceType(((global::System.Data.Entity.Core.Metadata.Edm.RefType)clrType).ElementType));
			}
			else
			{
				result = ((global::System.Data.Entity.Core.Mapping.ObjectTypeMapping)this.GetMap(clrType)).EdmType;
			}
			return result;
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x000DB4E4 File Offset: 0x000D96E4
		private void AddInternalMappings(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ObjectTypeMapping> typeMappings)
		{
			object @lock = this._lock;
			lock (@lock)
			{
				global::System.Collections.Generic.Dictionary<string, int> clrTypeIndexes = new global::System.Collections.Generic.Dictionary<string, int>(this._clrTypeIndexes);
				global::System.Collections.Generic.Dictionary<string, int> edmTypeIndexes = new global::System.Collections.Generic.Dictionary<string, int>(this._edmTypeIndexes);
				foreach (global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectMap in typeMappings)
				{
					this.AddInternalMapping(objectMap, clrTypeIndexes, edmTypeIndexes);
				}
				this._clrTypeIndexes = clrTypeIndexes;
				this._edmTypeIndexes = edmTypeIndexes;
			}
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x000DB588 File Offset: 0x000D9788
		private global::System.Data.Entity.Core.Mapping.ObjectTypeMapping AddInternalMapping(global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectMap, global::System.Collections.Generic.Dictionary<string, int> clrTypeIndexes, global::System.Collections.Generic.Dictionary<string, int> edmTypeIndexes)
		{
			if (base.Source.ContainsIdentity(objectMap.Identity))
			{
				return (global::System.Data.Entity.Core.Mapping.ObjectTypeMapping)base.Source[objectMap.Identity];
			}
			objectMap.DataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OCSpace;
			int count = base.Count;
			base.AddInternal(objectMap);
			string identity = objectMap.ClrType.Identity;
			if (!clrTypeIndexes.ContainsKey(identity))
			{
				clrTypeIndexes.Add(identity, count);
			}
			string identity2 = objectMap.EdmType.Identity;
			if (!edmTypeIndexes.ContainsKey(identity2))
			{
				edmTypeIndexes.Add(identity2, count);
			}
			return objectMap;
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x000DB610 File Offset: 0x000D9810
		internal static global::System.Data.Entity.Core.Mapping.ObjectTypeMapping LoadObjectMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmType cdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType objectType, global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection ocItemCollection)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping>(global::System.StringComparer.Ordinal);
			global::System.Data.Entity.Core.Mapping.ObjectTypeMapping result = global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.LoadObjectMapping(cdmType, objectType, ocItemCollection, dictionary);
			if (ocItemCollection != null)
			{
				ocItemCollection.AddInternalMappings(dictionary.Values);
			}
			return result;
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x000DB640 File Offset: 0x000D9840
		private static global::System.Data.Entity.Core.Mapping.ObjectTypeMapping LoadObjectMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType objectType, global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection ocItemCollection, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping> typeMappings)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmType) ^ global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(objectType))
			{
				throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_EnumTypeMappingToNonEnumType(edmType.FullName, objectType.FullName));
			}
			if (edmType.Abstract != objectType.Abstract)
			{
				throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_AbstractTypeMappingToNonAbstractType(edmType.FullName, objectType.FullName));
			}
			global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectTypeMapping = new global::System.Data.Entity.Core.Mapping.ObjectTypeMapping(objectType, edmType);
			typeMappings.Add(edmType.FullName, objectTypeMapping);
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(edmType))
			{
				global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.LoadEntityTypeOrComplexTypeMapping(objectTypeMapping, edmType, objectType, ocItemCollection, typeMappings);
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmType))
			{
				global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.ValidateEnumTypeMapping((global::System.Data.Entity.Core.Metadata.Edm.EnumType)edmType, (global::System.Data.Entity.Core.Metadata.Edm.EnumType)objectType);
			}
			else
			{
				global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.LoadAssociationTypeMapping(objectTypeMapping, edmType, objectType, ocItemCollection, typeMappings);
			}
			return objectTypeMapping;
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x000DB6F0 File Offset: 0x000D98F0
		private static global::System.Data.Entity.Core.Metadata.Edm.EdmMember GetObjectMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember, global::System.Data.Entity.Core.Metadata.Edm.StructuralType objectType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember result;
			if (!objectType.Members.TryGetValue(edmMember.Name, false, out result))
			{
				throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Default_OCMapping_Clr_Member(edmMember.Name, edmMember.DeclaringType.FullName, objectType.FullName));
			}
			return result;
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x000DB738 File Offset: 0x000D9938
		private static void ValidateMembersMatch(global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember, global::System.Data.Entity.Core.Metadata.Edm.EdmMember objectMember)
		{
			if (edmMember.BuiltInTypeKind != objectMember.BuiltInTypeKind)
			{
				throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Default_OCMapping_MemberKind_Mismatch(edmMember.Name, edmMember.DeclaringType.FullName, edmMember.BuiltInTypeKind, objectMember.Name, objectMember.DeclaringType.FullName, objectMember.BuiltInTypeKind));
			}
			if (edmMember.TypeUsage.EdmType.BuiltInTypeKind != objectMember.TypeUsage.EdmType.BuiltInTypeKind)
			{
				throw global::System.Data.Entity.Resources.Error.Mapping_Default_OCMapping_Member_Type_Mismatch(edmMember.TypeUsage.EdmType.Name, edmMember.TypeUsage.EdmType.BuiltInTypeKind, edmMember.Name, edmMember.DeclaringType.FullName, objectMember.TypeUsage.EdmType.Name, objectMember.TypeUsage.EdmType.BuiltInTypeKind, objectMember.Name, objectMember.DeclaringType.FullName);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmMember.TypeUsage.EdmType))
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.GetSpatialNormalizedPrimitiveType(edmMember.TypeUsage.EdmType).PrimitiveTypeKind != ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)objectMember.TypeUsage.EdmType).PrimitiveTypeKind)
				{
					throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Default_OCMapping_Invalid_MemberType(edmMember.TypeUsage.EdmType.FullName, edmMember.Name, edmMember.DeclaringType.FullName, objectMember.TypeUsage.EdmType.FullName, objectMember.Name, objectMember.DeclaringType.FullName));
				}
			}
			else
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmMember.TypeUsage.EdmType))
				{
					global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.ValidateEnumTypeMapping((global::System.Data.Entity.Core.Metadata.Edm.EnumType)edmMember.TypeUsage.EdmType, (global::System.Data.Entity.Core.Metadata.Edm.EnumType)objectMember.TypeUsage.EdmType);
					return;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2;
				if (edmMember.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationEndMember)
				{
					edmType = ((global::System.Data.Entity.Core.Metadata.Edm.RefType)edmMember.TypeUsage.EdmType).ElementType;
					edmType2 = ((global::System.Data.Entity.Core.Metadata.Edm.RefType)objectMember.TypeUsage.EdmType).ElementType;
				}
				else if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.NavigationProperty == edmMember.BuiltInTypeKind && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(edmMember.TypeUsage.EdmType))
				{
					edmType = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)edmMember.TypeUsage.EdmType).TypeUsage.EdmType;
					edmType2 = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)objectMember.TypeUsage.EdmType).TypeUsage.EdmType;
				}
				else
				{
					edmType = edmMember.TypeUsage.EdmType;
					edmType2 = objectMember.TypeUsage.EdmType;
				}
				if (edmType.Identity != global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection.TryGetMappingCSpaceTypeIdentity(edmType2))
				{
					throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Default_OCMapping_Invalid_MemberType(edmMember.TypeUsage.EdmType.FullName, edmMember.Name, edmMember.DeclaringType.FullName, objectMember.TypeUsage.EdmType.FullName, objectMember.Name, objectMember.DeclaringType.FullName));
				}
			}
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x000DB9F2 File Offset: 0x000D9BF2
		private static global::System.Data.Entity.Core.Mapping.ObjectPropertyMapping LoadScalarPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty objectProperty)
		{
			return new global::System.Data.Entity.Core.Mapping.ObjectPropertyMapping(edmProperty, objectProperty);
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x000DB9FC File Offset: 0x000D9BFC
		private static void LoadEntityTypeOrComplexTypeMapping(global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectMapping, global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType objectType, global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection ocItemCollection, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping> typeMappings)
		{
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = (global::System.Data.Entity.Core.Metadata.Edm.StructuralType)edmType;
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType2 = (global::System.Data.Entity.Core.Metadata.Edm.StructuralType)objectType;
			global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.ValidateAllMembersAreMapped(structuralType, structuralType2);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in structuralType.Members)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember objectMember = global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.GetObjectMember(edmMember, structuralType2);
				global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.ValidateMembersMatch(edmMember, objectMember);
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEdmProperty(edmMember))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)edmMember;
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)objectMember;
					if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(edmMember.TypeUsage.EdmType))
					{
						objectMapping.AddMemberMap(global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.LoadComplexMemberMapping(edmProperty, edmProperty2, ocItemCollection, typeMappings));
					}
					else
					{
						objectMapping.AddMemberMap(global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.LoadScalarPropertyMapping(edmProperty, edmProperty2));
					}
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)edmMember;
					global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty2 = (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)objectMember;
					global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.LoadTypeMapping(navigationProperty.RelationshipType, navigationProperty2.RelationshipType, ocItemCollection, typeMappings);
					objectMapping.AddMemberMap(new global::System.Data.Entity.Core.Mapping.ObjectNavigationPropertyMapping(navigationProperty, navigationProperty2));
				}
			}
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x000DBAF8 File Offset: 0x000D9CF8
		private static void ValidateAllMembersAreMapped(global::System.Data.Entity.Core.Metadata.Edm.StructuralType cdmStructuralType, global::System.Data.Entity.Core.Metadata.Edm.StructuralType objectStructuralType)
		{
			if (cdmStructuralType.Members.Count != objectStructuralType.Members.Count)
			{
				throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Default_OCMapping_Member_Count_Mismatch(cdmStructuralType.FullName, objectStructuralType.FullName));
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in objectStructuralType.Members)
			{
				if (!cdmStructuralType.Members.Contains(edmMember.Identity))
				{
					throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Default_OCMapping_Clr_Member2(edmMember.Name, objectStructuralType.FullName, cdmStructuralType.FullName));
				}
			}
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x000DBBA4 File Offset: 0x000D9DA4
		private static void ValidateEnumTypeMapping(global::System.Data.Entity.Core.Metadata.Edm.EnumType edmEnumType, global::System.Data.Entity.Core.Metadata.Edm.EnumType objectEnumType)
		{
			if (edmEnumType.UnderlyingType.PrimitiveTypeKind != objectEnumType.UnderlyingType.PrimitiveTypeKind)
			{
				throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Enum_OCMapping_UnderlyingTypesMismatch(edmEnumType.UnderlyingType.Name, edmEnumType.FullName, objectEnumType.UnderlyingType.Name, objectEnumType.FullName));
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EnumMember> enumerator = (from m in edmEnumType.Members
			orderby global::System.Convert.ToInt64(m.Value, global::System.Globalization.CultureInfo.InvariantCulture), m.Name
			select m).GetEnumerator();
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EnumMember> enumerator2 = (from m in objectEnumType.Members
			orderby global::System.Convert.ToInt64(m.Value, global::System.Globalization.CultureInfo.InvariantCulture), m.Name
			select m).GetEnumerator();
			if (enumerator.MoveNext())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator.Current.Name == enumerator2.Current.Name && enumerator.Current.Value.Equals(enumerator2.Current.Value) && !enumerator.MoveNext())
					{
						return;
					}
				}
				throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Enum_OCMapping_MemberMismatch(objectEnumType.FullName, enumerator.Current.Name, enumerator.Current.Value, edmEnumType.FullName));
			}
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x000DBD20 File Offset: 0x000D9F20
		private static void LoadAssociationTypeMapping(global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectMapping, global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType objectType, global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection ocItemCollection, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping> typeMappings)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)edmType;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType2 = (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)objectType;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember in associationType.AssociationEndMembers)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2 = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.GetObjectMember(associationEndMember, associationType2);
				global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.ValidateMembersMatch(associationEndMember, associationEndMember2);
				if (associationEndMember.RelationshipMultiplicity != associationEndMember2.RelationshipMultiplicity)
				{
					throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Default_OCMapping_MultiplicityMismatch(associationEndMember.RelationshipMultiplicity, associationEndMember.Name, associationType.FullName, associationEndMember2.RelationshipMultiplicity, associationEndMember2.Name, associationType2.FullName));
				}
				global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.LoadTypeMapping(((global::System.Data.Entity.Core.Metadata.Edm.RefType)associationEndMember.TypeUsage.EdmType).ElementType, ((global::System.Data.Entity.Core.Metadata.Edm.RefType)associationEndMember2.TypeUsage.EdmType).ElementType, ocItemCollection, typeMappings);
				objectMapping.AddMemberMap(new global::System.Data.Entity.Core.Mapping.ObjectAssociationEndMapping(associationEndMember, associationEndMember2));
			}
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x000DBE24 File Offset: 0x000DA024
		private static global::System.Data.Entity.Core.Mapping.ObjectComplexPropertyMapping LoadComplexMemberMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty containingEdmMember, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty containingClrMember, global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection ocItemCollection, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping> typeMappings)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)containingEdmMember.TypeUsage.EdmType;
			global::System.Data.Entity.Core.Metadata.Edm.ComplexType objectType = (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)containingClrMember.TypeUsage.EdmType;
			global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.LoadTypeMapping(edmType, objectType, ocItemCollection, typeMappings);
			return new global::System.Data.Entity.Core.Mapping.ObjectComplexPropertyMapping(containingEdmMember, containingClrMember);
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x000DBE64 File Offset: 0x000DA064
		private static global::System.Data.Entity.Core.Mapping.ObjectTypeMapping LoadTypeMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType objectType, global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection ocItemCollection, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping> typeMappings)
		{
			global::System.Data.Entity.Core.Mapping.ObjectTypeMapping result;
			if (typeMappings.TryGetValue(edmType.FullName, out result))
			{
				return result;
			}
			global::System.Data.Entity.Core.Mapping.ObjectTypeMapping result2;
			if (ocItemCollection != null && ocItemCollection.ContainsMap(edmType, out result2))
			{
				return result2;
			}
			return global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.LoadObjectMapping(edmType, objectType, ocItemCollection, typeMappings);
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x000DBE9C File Offset: 0x000DA09C
		private bool ContainsMap(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem cspaceItem, out global::System.Data.Entity.Core.Mapping.ObjectTypeMapping map)
		{
			int index;
			if (this._edmTypeIndexes.TryGetValue(cspaceItem.Identity, out index))
			{
				map = (global::System.Data.Entity.Core.Mapping.ObjectTypeMapping)base[index];
				return true;
			}
			map = null;
			return false;
		}

		// Token: 0x04001692 RID: 5778
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection _objectCollection;

		// Token: 0x04001693 RID: 5779
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection _edmCollection;

		// Token: 0x04001694 RID: 5780
		private global::System.Collections.Generic.Dictionary<string, int> _clrTypeIndexes = new global::System.Collections.Generic.Dictionary<string, int>(global::System.StringComparer.Ordinal);

		// Token: 0x04001695 RID: 5781
		private global::System.Collections.Generic.Dictionary<string, int> _edmTypeIndexes = new global::System.Collections.Generic.Dictionary<string, int>(global::System.StringComparer.Ordinal);

		// Token: 0x04001696 RID: 5782
		private readonly object _lock = new object();
	}
}
