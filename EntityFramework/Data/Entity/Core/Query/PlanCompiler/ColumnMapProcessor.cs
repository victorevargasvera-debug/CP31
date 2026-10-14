using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000335 RID: 821
	internal class ColumnMapProcessor
	{
		// Token: 0x06002717 RID: 10007 RVA: 0x00070554 File Offset: 0x0006E754
		internal global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap ExpandColumnMap()
		{
			if (this.m_varInfo.Kind == global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind.CollectionVarInfo)
			{
				return new global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap(this.m_columnMap.Var.Type, this.m_columnMap.Name, ((global::System.Data.Entity.Core.Query.PlanCompiler.CollectionVarInfo)this.m_varInfo).NewVar);
			}
			if (this.m_varInfo.Kind == global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind.PrimitiveTypeVarInfo)
			{
				return new global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap(this.m_columnMap.Var.Type, this.m_columnMap.Name, ((global::System.Data.Entity.Core.Query.PlanCompiler.PrimitiveTypeVarInfo)this.m_varInfo).NewVar);
			}
			return this.CreateColumnMap(this.m_columnMap.Var.Type, this.m_columnMap.Name);
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00070600 File Offset: 0x0006E800
		internal ColumnMapProcessor(global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo, global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo typeInfo)
		{
			this.m_columnMap = columnMap;
			this.m_varInfo = varInfo;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varInfo.NewVars != null && varInfo.NewVars.Count > 0, "No new Vars specified");
			this.m_varList = varInfo.NewVars.GetEnumerator();
			this.m_typeInfo = typeInfo;
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00070661 File Offset: 0x0006E861
		private global::System.Data.Entity.Core.Query.InternalTrees.Var GetNextVar()
		{
			if (this.m_varList.MoveNext())
			{
				return this.m_varList.Current;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "Could not GetNextVar");
			return null;
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x00070688 File Offset: 0x0006E888
		private global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap CreateColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name)
		{
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type))
			{
				return this.CreateSimpleColumnMap(type, name);
			}
			return this.CreateStructuralColumnMap(type, name);
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000706A4 File Offset: 0x0006E8A4
		private global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap CreateComplexTypeColumnMap(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, string name, global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap superTypeColumnMap, global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> discriminatorMap, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> allMaps)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>();
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap nullSentinel = null;
			if (typeInfo.HasNullSentinelProperty)
			{
				nullSentinel = this.CreateSimpleColumnMap(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(typeInfo.NullSentinelProperty), "__NullSentinel");
			}
			global::System.Collections.IEnumerable enumerable;
			if (superTypeColumnMap != null)
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap item in superTypeColumnMap.Properties)
				{
					list.Add(item);
				}
				enumerable = global::System.Data.Entity.Core.Common.TypeHelpers.GetDeclaredStructuralMembers(typeInfo.Type);
			}
			else
			{
				enumerable = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(typeInfo.Type);
			}
			foreach (object obj in enumerable)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
				global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap item2 = this.CreateColumnMap(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(edmMember), edmMember.Name);
				list.Add(item2);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap complexTypeColumnMap = new global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap(typeInfo.Type, name, list.ToArray(), nullSentinel);
			if (discriminatorMap != null)
			{
				discriminatorMap[typeInfo.TypeId] = complexTypeColumnMap;
			}
			if (allMaps != null)
			{
				allMaps.Add(complexTypeColumnMap);
			}
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 in typeInfo.ImmediateSubTypes)
			{
				this.CreateComplexTypeColumnMap(typeInfo2, name, complexTypeColumnMap, discriminatorMap, allMaps);
			}
			return complexTypeColumnMap;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00070808 File Offset: 0x0006EA08
		private global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap CreateEntityColumnMap(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, string name, global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap superTypeColumnMap, global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> discriminatorMap, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> allMaps, bool handleRelProperties)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap entityColumnMap = null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>();
			if (superTypeColumnMap != null)
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap item in superTypeColumnMap.Properties)
				{
					list.Add(item);
				}
				foreach (object obj in global::System.Data.Entity.Core.Common.TypeHelpers.GetDeclaredStructuralMembers(typeInfo.Type))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
					global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap item2 = this.CreateColumnMap(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(edmMember), edmMember.Name);
					list.Add(item2);
				}
				entityColumnMap = new global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap(typeInfo.Type, name, list.ToArray(), superTypeColumnMap.EntityIdentity);
			}
			else
			{
				global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap entitySetIdColumnMap = null;
				if (typeInfo.HasEntitySetIdProperty)
				{
					entitySetIdColumnMap = this.CreateEntitySetIdColumnMap(typeInfo.EntitySetIdProperty);
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>();
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>();
				foreach (object obj2 in global::System.Data.Entity.Core.Common.TypeHelpers.GetDeclaredStructuralMembers(typeInfo.Type))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember2 = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj2;
					global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap = this.CreateColumnMap(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(edmMember2), edmMember2.Name);
					list.Add(columnMap);
					if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPartOfKey(edmMember2))
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = edmMember2 as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty;
						global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(edmProperty != null, "EntityType key member is not property?");
						dictionary[edmProperty] = columnMap;
					}
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember3 in global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(typeInfo.Type).KeyMembers)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 = edmMember3 as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty;
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(edmProperty2 != null, "EntityType key member is not property?");
					global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap simpleColumnMap = dictionary[edmProperty2] as global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap;
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(simpleColumnMap != null, "keyColumnMap is null");
					list2.Add(simpleColumnMap);
				}
				global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity = this.CreateEntityIdentity((global::System.Data.Entity.Core.Metadata.Edm.EntityType)typeInfo.Type.EdmType, entitySetIdColumnMap, list2.ToArray());
				entityColumnMap = new global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap(typeInfo.Type, name, list.ToArray(), entityIdentity);
			}
			if (discriminatorMap != null && typeInfo.TypeId != null)
			{
				discriminatorMap[typeInfo.TypeId] = entityColumnMap;
			}
			if (allMaps != null)
			{
				allMaps.Add(entityColumnMap);
			}
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 in typeInfo.ImmediateSubTypes)
			{
				this.CreateEntityColumnMap(typeInfo2, name, entityColumnMap, discriminatorMap, allMaps, false);
			}
			if (handleRelProperties)
			{
				this.BuildRelPropertyColumnMaps(typeInfo, true);
			}
			return entityColumnMap;
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00070ACC File Offset: 0x0006ECCC
		private void BuildRelPropertyColumnMaps(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, bool includeSupertypeRelProperties)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> enumerable;
			if (includeSupertypeRelProperties)
			{
				enumerable = this.m_typeInfo.RelPropertyHelper.GetRelProperties(typeInfo.Type.EdmType as global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase);
			}
			else
			{
				enumerable = this.m_typeInfo.RelPropertyHelper.GetDeclaredOnlyRelProperties(typeInfo.Type.EdmType as global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase);
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty in enumerable)
			{
				this.CreateColumnMap(relProperty.ToEnd.TypeUsage, relProperty.ToString());
			}
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 in typeInfo.ImmediateSubTypes)
			{
				this.BuildRelPropertyColumnMaps(typeInfo2, false);
			}
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00070BB4 File Offset: 0x0006EDB4
		private global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap CreateEntitySetIdColumnMap(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty prop)
		{
			return this.CreateSimpleColumnMap(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(prop), "__EntitySetId");
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00070BC8 File Offset: 0x0006EDC8
		private global::System.Data.Entity.Core.Query.InternalTrees.SimplePolymorphicColumnMap CreatePolymorphicColumnMap(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, string name)
		{
			global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> dictionary = new global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap>((typeInfo.RootType.DiscriminatorMap == null) ? null : global::System.Data.Entity.Core.Common.Utils.TrailingSpaceComparer.Instance);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap>();
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo rootType = typeInfo.RootType;
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap typeDiscriminator = this.CreateTypeIdColumnMap(rootType.TypeIdProperty);
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(typeInfo.Type))
			{
				this.CreateComplexTypeColumnMap(rootType, name, null, dictionary, list);
			}
			else
			{
				this.CreateEntityColumnMap(rootType, name, null, dictionary, list, true);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap typedColumnMap = null;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap typedColumnMap2 in list)
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqual(typedColumnMap2.Type, typeInfo.Type))
				{
					typedColumnMap = typedColumnMap2;
					break;
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(typedColumnMap != null, "Didn't find requested type in polymorphic type hierarchy?");
			return new global::System.Data.Entity.Core.Query.InternalTrees.SimplePolymorphicColumnMap(typeInfo.Type, name, typedColumnMap.Properties, typeDiscriminator, dictionary);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00070CB0 File Offset: 0x0006EEB0
		private global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap CreateRecordColumnMap(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, string name)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(typeInfo.Type.EdmType is global::System.Data.Entity.Core.Metadata.Edm.RowType, "not RowType");
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap nullSentinel = null;
			if (typeInfo.HasNullSentinelProperty)
			{
				nullSentinel = this.CreateSimpleColumnMap(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(typeInfo.NullSentinelProperty), "__NullSentinel");
			}
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties = global::System.Data.Entity.Core.Common.TypeHelpers.GetProperties(typeInfo.Type);
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] array = new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[properties.Count];
			for (int i = 0; i < array.Length; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = properties[i];
				array[i] = this.CreateColumnMap(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(edmMember), edmMember.Name);
			}
			return new global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap(typeInfo.Type, name, array, nullSentinel);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00070D50 File Offset: 0x0006EF50
		private global::System.Data.Entity.Core.Query.InternalTrees.RefColumnMap CreateRefColumnMap(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, string name)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap entitySetIdColumnMap = null;
			if (typeInfo.HasEntitySetIdProperty)
			{
				entitySetIdColumnMap = this.CreateSimpleColumnMap(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(typeInfo.EntitySetIdProperty), "__EntitySetId");
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(typeInfo.Type).ElementType;
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] array = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[entityType.KeyMembers.Count];
			for (int i = 0; i < array.Length; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = entityType.KeyMembers[i];
				array[i] = this.CreateSimpleColumnMap(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(edmMember), edmMember.Name);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity = this.CreateEntityIdentity(entityType, entitySetIdColumnMap, array);
			return new global::System.Data.Entity.Core.Query.InternalTrees.RefColumnMap(typeInfo.Type, name, entityIdentity);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00070DF8 File Offset: 0x0006EFF8
		private global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap CreateSimpleColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var nextVar = this.GetNextVar();
			return new global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap(type, name, nextVar);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00070E14 File Offset: 0x0006F014
		private global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap CreateTypeIdColumnMap(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty prop)
		{
			return this.CreateSimpleColumnMap(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(prop), "__TypeId");
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00070E28 File Offset: 0x0006F028
		private global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap CreateStructuralColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(type);
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(type))
			{
				return this.CreateRecordColumnMap(typeInfo, name);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(type))
			{
				return this.CreateRefColumnMap(typeInfo, name);
			}
			if (typeInfo.HasTypeIdProperty)
			{
				return this.CreatePolymorphicColumnMap(typeInfo, name);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(type))
			{
				return this.CreateComplexTypeColumnMap(typeInfo, name, null, null, null);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(type))
			{
				return this.CreateEntityColumnMap(typeInfo, name, null, null, null, true);
			}
			throw new global::System.NotSupportedException(type.Identity);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x00070EAC File Offset: 0x0006F0AC
		private global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity CreateEntityIdentity(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap entitySetIdColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keyColumnMaps)
		{
			if (entitySetIdColumnMap != null)
			{
				return new global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity(entitySetIdColumnMap, this.m_typeInfo.EntitySetIdToEntitySetMap, keyColumnMaps);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = this.m_typeInfo.GetEntitySet(entityType);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(entitySet != null, "Expected non-null entitySet when no entity set ID is required. Entity type = " + ((entityType != null) ? entityType.ToString() : null));
			return new global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity(entitySet, keyColumnMaps);
		}

		// Token: 0x04000DA4 RID: 3492
		private readonly global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> m_varList;

		// Token: 0x04000DA5 RID: 3493
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo m_varInfo;

		// Token: 0x04000DA6 RID: 3494
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap m_columnMap;

		// Token: 0x04000DA7 RID: 3495
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo m_typeInfo;

		// Token: 0x04000DA8 RID: 3496
		private const string c_TypeIdColumnName = "__TypeId";

		// Token: 0x04000DA9 RID: 3497
		private const string c_EntitySetIdColumnName = "__EntitySetId";

		// Token: 0x04000DAA RID: 3498
		private const string c_NullSentinelColumnName = "__NullSentinel";
	}
}
