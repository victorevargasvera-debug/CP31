using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Globalization;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200036A RID: 874
	internal class StructuredTypeInfo
	{
		// Token: 0x06002A5B RID: 10843 RVA: 0x00089991 File Offset: 0x00087B91
		private StructuredTypeInfo(global::System.Collections.Generic.HashSet<string> typesNeedingNullSentinel)
		{
			this.m_typeInfoMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo>(global::System.Data.Entity.Core.Query.PlanCompiler.TypeUsageEqualityComparer.Instance);
			this.m_typeInfoMapPopulated = false;
			this.m_typesNeedingNullSentinel = typesNeedingNullSentinel;
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x000899B7 File Offset: 0x00087BB7
		internal static void Process(global::System.Data.Entity.Core.Query.InternalTrees.Command itree, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> referencedTypes, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> referencedEntitySets, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityType> freeFloatingEntityConstructorTypes, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Query.PlanCompiler.DiscriminatorMapInfo> discriminatorMaps, global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyHelper relPropertyHelper, global::System.Collections.Generic.HashSet<string> typesNeedingNullSentinel, out global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo structuredTypeInfo)
		{
			structuredTypeInfo = new global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo(typesNeedingNullSentinel);
			structuredTypeInfo.Process(itree, referencedTypes, referencedEntitySets, freeFloatingEntityConstructorTypes, discriminatorMaps, relPropertyHelper);
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x000899D4 File Offset: 0x00087BD4
		private void Process(global::System.Data.Entity.Core.Query.InternalTrees.Command itree, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> referencedTypes, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> referencedEntitySets, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityType> freeFloatingEntityConstructorTypes, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Query.PlanCompiler.DiscriminatorMapInfo> discriminatorMaps, global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyHelper relPropertyHelper)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(itree != null, "null itree?");
			this.m_stringType = itree.StringType;
			this.m_intType = itree.IntegerType;
			this.m_relPropertyHelper = relPropertyHelper;
			this.ProcessEntitySets(referencedEntitySets, freeFloatingEntityConstructorTypes);
			this.ProcessDiscriminatorMaps(discriminatorMaps);
			this.ProcessTypes(referencedTypes);
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x00089A27 File Offset: 0x00087C27
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet[] EntitySetIdToEntitySetMap
		{
			get
			{
				return this.m_entitySetIdToEntitySetMap;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x00089A2F File Offset: 0x00087C2F
		internal global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyHelper RelPropertyHelper
		{
			get
			{
				return this.m_relPropertyHelper;
			}
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x00089A38 File Offset: 0x00087C38
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase rootType = global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo.GetRootType(type);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet result;
			if (!this.m_entityTypeToEntitySetMap.TryGetValue(rootType, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x00089A60 File Offset: 0x00087C60
		internal int GetEntitySetId(global::System.Data.Entity.Core.Metadata.Edm.EntitySet e)
		{
			int result = 0;
			if (!this.m_entitySetToEntitySetIdMap.TryGetValue(e, out result))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "no such entity set?");
			}
			return result;
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00089A8B File Offset: 0x00087C8B
		internal global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> GetEntitySets()
		{
			return new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(this.m_entitySetIdToEntitySetMap).MakeReadOnly();
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x00089AA0 File Offset: 0x00087CA0
		internal global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo GetTypeInfo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type))
			{
				return null;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo result = null;
			if (!this.m_typeInfoMap.TryGetValue(type, out result))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type) || !this.m_typeInfoMapPopulated, "cannot find typeInfo for type " + ((type != null) ? type.ToString() : null));
			}
			return result;
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x00089AFC File Offset: 0x00087CFC
		private void AddEntityTypeToSetEntry(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase rootType = global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo.GetRootType(entityType);
			bool flag = true;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet2;
			if (entitySet == null)
			{
				flag = false;
			}
			else if (this.m_entityTypeToEntitySetMap.TryGetValue(rootType, out entitySet2) && entitySet2 != entitySet)
			{
				flag = false;
			}
			if (flag)
			{
				this.m_entityTypeToEntitySetMap[rootType] = entitySet;
				return;
			}
			this.m_entityTypeToEntitySetMap[rootType] = null;
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00089B50 File Offset: 0x00087D50
		private void ProcessEntitySets(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> referencedEntitySets, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityType> freeFloatingEntityConstructorTypes)
		{
			this.AssignEntitySetIds(referencedEntitySets);
			this.m_entityTypeToEntitySetMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet in referencedEntitySets)
			{
				this.AddEntityTypeToSetEntry(entitySet.ElementType, entitySet);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType in freeFloatingEntityConstructorTypes)
			{
				this.AddEntityTypeToSetEntry(entityType, null);
			}
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x00089BF4 File Offset: 0x00087DF4
		private void ProcessDiscriminatorMaps(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Query.PlanCompiler.DiscriminatorMapInfo> discriminatorMaps)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap> dictionary = null;
			if (discriminatorMaps != null)
			{
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap>(discriminatorMaps.Count, discriminatorMaps.Comparer);
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Query.PlanCompiler.DiscriminatorMapInfo> keyValuePair in discriminatorMaps)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase key = keyValuePair.Key;
					global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap discriminatorMap = keyValuePair.Value.DiscriminatorMap;
					if (discriminatorMap != null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase rootType = global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo.GetRootType(key.ElementType);
						if (this.GetEntitySet(rootType) != null)
						{
							dictionary.Add(key, discriminatorMap);
						}
					}
				}
				if (dictionary.Count == 0)
				{
					dictionary = null;
				}
			}
			this.m_discriminatorMaps = dictionary;
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00089CA4 File Offset: 0x00087EA4
		private void AssignEntitySetIds(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> referencedEntitySets)
		{
			this.m_entitySetIdToEntitySetMap = new global::System.Data.Entity.Core.Metadata.Edm.EntitySet[referencedEntitySets.Count];
			this.m_entitySetToEntitySetIdMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, int>();
			int num = 0;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet in referencedEntitySets)
			{
				if (!this.m_entitySetToEntitySetIdMap.ContainsKey(entitySet))
				{
					this.m_entitySetIdToEntitySetMap[num] = entitySet;
					this.m_entitySetToEntitySetIdMap[entitySet] = num;
					num++;
				}
			}
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00089D34 File Offset: 0x00087F34
		private void ProcessTypes(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> referencedTypes)
		{
			this.PopulateTypeInfoMap(referencedTypes);
			this.AssignTypeIds();
			this.ExplodeTypes();
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00089D4C File Offset: 0x00087F4C
		private void PopulateTypeInfoMap(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> referencedTypes)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type in referencedTypes)
			{
				this.CreateTypeInfoForType(type);
			}
			this.m_typeInfoMapPopulated = true;
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x00089DA4 File Offset: 0x00087FA4
		private bool TryGetDiscriminatorMap(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, out global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap discriminatorMap)
		{
			discriminatorMap = null;
			if (this.m_discriminatorMaps == null)
			{
				return false;
			}
			if (type.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
			{
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase rootType = global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo.GetRootType((global::System.Data.Entity.Core.Metadata.Edm.EntityType)type);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			return this.m_entityTypeToEntitySetMap.TryGetValue(rootType, out entitySet) && entitySet != null && this.m_discriminatorMaps.TryGetValue(entitySet, out discriminatorMap);
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x00089DFC File Offset: 0x00087FFC
		private void CreateTypeInfoForType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			while (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsCollectionType(type))
			{
				type = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(type).TypeUsage;
			}
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type))
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap discriminatorMap;
				this.TryGetDiscriminatorMap(type.EdmType, out discriminatorMap);
				this.CreateTypeInfoForStructuredType(type, discriminatorMap);
			}
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x00089E40 File Offset: 0x00088040
		private global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo CreateTypeInfoForStructuredType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap discriminatorMap)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type), "expected structured type. Found " + ((type != null) ? type.ToString() : null));
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.GetTypeInfo(type);
			if (typeInfo != null)
			{
				return typeInfo;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo superTypeInfo = null;
			global::System.Data.Entity.Core.Metadata.Edm.RefType refType;
			if (type.EdmType.BaseType != null)
			{
				superTypeInfo = this.CreateTypeInfoForStructuredType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(type.EdmType.BaseType), discriminatorMap);
			}
			else if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(type, out refType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = refType.ElementType as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
				if (entityType != null && entityType.BaseType != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2 = global::System.Data.Entity.Core.Common.TypeHelpers.CreateReferenceTypeUsage(entityType.BaseType as global::System.Data.Entity.Core.Metadata.Edm.EntityType);
					superTypeInfo = this.CreateTypeInfoForStructuredType(type2, discriminatorMap);
				}
			}
			foreach (object obj in global::System.Data.Entity.Core.Common.TypeHelpers.GetDeclaredStructuralMembers(type))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
				this.CreateTypeInfoForType(edmMember.TypeUsage);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType2;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(type, out entityType2))
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty in this.m_relPropertyHelper.GetDeclaredOnlyRelProperties(entityType2))
				{
					this.CreateTypeInfoForType(relProperty.ToEnd.TypeUsage);
				}
			}
			typeInfo = global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo.Create(type, superTypeInfo, discriminatorMap);
			this.m_typeInfoMap.Add(type, typeInfo);
			return typeInfo;
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x00089FB4 File Offset: 0x000881B4
		private void AssignTypeIds()
		{
			int num = 0;
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo> keyValuePair in this.m_typeInfoMap)
			{
				if (keyValuePair.Value.RootType.DiscriminatorMap != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)keyValuePair.Key.EdmType;
					keyValuePair.Value.TypeId = keyValuePair.Value.RootType.DiscriminatorMap.GetTypeId(entityType);
				}
				else if (keyValuePair.Value.IsRootType && (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(keyValuePair.Key) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(keyValuePair.Key)))
				{
					this.AssignRootTypeId(keyValuePair.Value, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}X", new object[]
					{
						num
					}));
					num++;
				}
			}
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x0008A0AC File Offset: 0x000882AC
		private void AssignRootTypeId(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, string typeId)
		{
			typeInfo.TypeId = typeId;
			this.AssignTypeIdsToSubTypes(typeInfo);
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x0008A0BC File Offset: 0x000882BC
		private void AssignTypeIdsToSubTypes(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo)
		{
			int num = 0;
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 in typeInfo.ImmediateSubTypes)
			{
				this.AssignTypeId(typeInfo2, num);
				num++;
			}
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x0008A118 File Offset: 0x00088318
		private void AssignTypeId(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, int subtypeNum)
		{
			typeInfo.TypeId = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}{1}X", new object[]
			{
				typeInfo.SuperType.TypeId,
				subtypeNum
			});
			this.AssignTypeIdsToSubTypes(typeInfo);
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x0008A153 File Offset: 0x00088353
		private static bool NeedsTypeIdProperty(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo)
		{
			return typeInfo.ImmediateSubTypes.Count > 0 && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(typeInfo.Type);
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x0008A173 File Offset: 0x00088373
		private bool NeedsNullSentinelProperty(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo)
		{
			return this.m_typesNeedingNullSentinel.Contains(typeInfo.Type.EdmType.Identity);
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x0008A190 File Offset: 0x00088390
		private bool NeedsEntitySetIdProperty(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RefType refType = typeInfo.Type.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RefType;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType;
			if (refType != null)
			{
				entityType = (refType.ElementType as global::System.Data.Entity.Core.Metadata.Edm.EntityType);
			}
			else
			{
				entityType = (typeInfo.Type.EdmType as global::System.Data.Entity.Core.Metadata.Edm.EntityType);
			}
			return entityType != null && this.GetEntitySet(entityType) == null;
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x0008A1E0 File Offset: 0x000883E0
		private void ExplodeTypes()
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo> keyValuePair in this.m_typeInfoMap)
			{
				if (keyValuePair.Value.IsRootType)
				{
					this.ExplodeType(keyValuePair.Value);
				}
			}
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x0008A248 File Offset: 0x00088448
		private global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo ExplodeType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.GetTypeInfo(type);
				this.ExplodeType(typeInfo);
				return typeInfo;
			}
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsCollectionType(type))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(type).TypeUsage;
				this.ExplodeType(typeUsage);
				return null;
			}
			return null;
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x0008A28D File Offset: 0x0008848D
		private void ExplodeType(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo)
		{
			this.ExplodeRootStructuredType(typeInfo.RootType);
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x0008A29C File Offset: 0x0008849C
		private void ExplodeRootStructuredType(global::System.Data.Entity.Core.Query.PlanCompiler.RootTypeInfo rootType)
		{
			if (rootType.FlattenedType != null)
			{
				return;
			}
			if (global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo.NeedsTypeIdProperty(rootType))
			{
				rootType.AddPropertyRef(global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdPropertyRef.Instance);
				if (rootType.DiscriminatorMap != null)
				{
					rootType.TypeIdKind = global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdKind.UserSpecified;
					rootType.TypeIdType = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(rootType.DiscriminatorMap.DiscriminatorProperty);
				}
				else
				{
					rootType.TypeIdKind = global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdKind.Generated;
					rootType.TypeIdType = this.m_stringType;
				}
			}
			if (this.NeedsEntitySetIdProperty(rootType))
			{
				rootType.AddPropertyRef(global::System.Data.Entity.Core.Query.PlanCompiler.EntitySetIdPropertyRef.Instance);
			}
			if (this.NeedsNullSentinelProperty(rootType))
			{
				rootType.AddPropertyRef(global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef.Instance);
			}
			this.ExplodeRootStructuredTypeHelper(rootType);
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(rootType.Type))
			{
				this.AddRelProperties(rootType);
			}
			this.CreateFlattenedRecordType(rootType);
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x0008A34C File Offset: 0x0008854C
		private void ExplodeRootStructuredTypeHelper(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.RootTypeInfo rootType = typeInfo.RootType;
			global::System.Data.Entity.Core.Metadata.Edm.RefType refType;
			global::System.Collections.IEnumerable enumerable;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(typeInfo.Type, out refType))
			{
				if (!typeInfo.IsRootType)
				{
					return;
				}
				enumerable = refType.ElementType.KeyMembers;
			}
			else
			{
				enumerable = global::System.Data.Entity.Core.Common.TypeHelpers.GetDeclaredStructuralMembers(typeInfo.Type);
			}
			foreach (object obj in enumerable)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
				global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 = this.ExplodeType(edmMember.TypeUsage);
				if (typeInfo2 == null)
				{
					rootType.AddPropertyRef(new global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef(edmMember));
				}
				else
				{
					foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in typeInfo2.PropertyRefList)
					{
						rootType.AddPropertyRef(propertyRef.CreateNestedPropertyRef(edmMember));
					}
				}
			}
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo3 in typeInfo.ImmediateSubTypes)
			{
				this.ExplodeRootStructuredTypeHelper(typeInfo3);
			}
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x0008A48C File Offset: 0x0008868C
		private void AddRelProperties(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase)typeInfo.Type.EdmType;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty in this.m_relPropertyHelper.GetDeclaredOnlyRelProperties(entityType))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 = this.GetTypeInfo(relProperty.ToEnd.TypeUsage);
				this.ExplodeType(typeInfo2);
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in typeInfo2.PropertyRefList)
				{
					typeInfo.RootType.AddPropertyRef(propertyRef.CreateNestedPropertyRef(relProperty));
				}
			}
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo3 in typeInfo.ImmediateSubTypes)
			{
				this.AddRelProperties(typeInfo3);
			}
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x0008A598 File Offset: 0x00088798
		private void CreateFlattenedRecordType(global::System.Data.Entity.Core.Query.PlanCompiler.RootTypeInfo type)
		{
			bool flag = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(type.Type) && type.ImmediateSubTypes.Count == 0;
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>();
			global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>();
			int num = 0;
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in type.PropertyRefList)
			{
				string text = null;
				if (flag)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef simplePropertyRef = propertyRef as global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef;
					if (simplePropertyRef != null)
					{
						text = simplePropertyRef.Property.Name;
					}
				}
				if (text == null)
				{
					text = "F" + num.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
					num++;
				}
				while (hashSet.Contains(text))
				{
					text = "F" + num.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
					num++;
				}
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage propertyType = this.GetPropertyType(type, propertyRef);
				list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(text, propertyType));
				hashSet.Add(text);
			}
			type.FlattenedType = global::System.Data.Entity.Core.Common.TypeHelpers.CreateRowType(list);
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> enumerator2 = type.PropertyRefList.GetEnumerator();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty newProperty in type.FlattenedType.Properties)
			{
				if (!enumerator2.MoveNext())
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "property refs count and flattened type member count mismatch?");
				}
				type.AddPropertyMapping(enumerator2.Current, newProperty);
			}
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x0008A724 File Offset: 0x00088924
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetNewType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type))
			{
				return this.GetTypeInfo(type).FlattenedTypeUsage;
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetCollectionElementType(type, out typeUsage))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage newType = this.GetNewType(typeUsage);
				if (newType.EdmEquals(typeUsage))
				{
					return type;
				}
				return global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionTypeUsage(newType);
			}
			else
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsEnumerationType(type))
				{
					return global::System.Data.Entity.Core.Common.TypeHelpers.CreateEnumUnderlyingTypeUsage(type);
				}
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStrongSpatialType(type))
				{
					return global::System.Data.Entity.Core.Common.TypeHelpers.CreateSpatialUnionTypeUsage(type);
				}
				return type;
			}
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x0008A78C File Offset: 0x0008898C
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetPropertyType(global::System.Data.Entity.Core.Query.PlanCompiler.RootTypeInfo typeInfo, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef p)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = null;
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef = null;
			while (p is global::System.Data.Entity.Core.Query.PlanCompiler.NestedPropertyRef)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.NestedPropertyRef nestedPropertyRef = (global::System.Data.Entity.Core.Query.PlanCompiler.NestedPropertyRef)p;
				p = nestedPropertyRef.OuterProperty;
				propertyRef = nestedPropertyRef.InnerProperty;
			}
			if (p is global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdPropertyRef)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef simplePropertyRef = (global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef)propertyRef;
				if (simplePropertyRef != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage2 = simplePropertyRef.Property.TypeUsage;
					typeUsage = this.GetTypeInfo(typeUsage2).RootType.TypeIdType;
				}
				else
				{
					typeUsage = typeInfo.TypeIdType;
				}
			}
			else if (p is global::System.Data.Entity.Core.Query.PlanCompiler.EntitySetIdPropertyRef || p is global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef)
			{
				typeUsage = this.m_intType;
			}
			else if (p is global::System.Data.Entity.Core.Query.PlanCompiler.RelPropertyRef)
			{
				typeUsage = ((global::System.Data.Entity.Core.Query.PlanCompiler.RelPropertyRef)p).Property.ToEnd.TypeUsage;
			}
			else
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef simplePropertyRef2 = p as global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef;
				if (simplePropertyRef2 != null)
				{
					typeUsage = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(simplePropertyRef2.Property);
				}
			}
			typeUsage = this.GetNewType(typeUsage);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(typeUsage != null, "unrecognized property type?");
			return typeUsage;
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x0008A85F File Offset: 0x00088A5F
		private static global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase GetRootType(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase type)
		{
			while (type.BaseType != null)
			{
				type = (global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase)type.BaseType;
			}
			return type;
		}

		// Token: 0x04000E9B RID: 3739
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_stringType;

		// Token: 0x04000E9C RID: 3740
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_intType;

		// Token: 0x04000E9D RID: 3741
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo> m_typeInfoMap;

		// Token: 0x04000E9E RID: 3742
		private bool m_typeInfoMapPopulated;

		// Token: 0x04000E9F RID: 3743
		private global::System.Data.Entity.Core.Metadata.Edm.EntitySet[] m_entitySetIdToEntitySetMap;

		// Token: 0x04000EA0 RID: 3744
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, int> m_entitySetToEntitySetIdMap;

		// Token: 0x04000EA1 RID: 3745
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> m_entityTypeToEntitySetMap;

		// Token: 0x04000EA2 RID: 3746
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap> m_discriminatorMaps;

		// Token: 0x04000EA3 RID: 3747
		private global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyHelper m_relPropertyHelper;

		// Token: 0x04000EA4 RID: 3748
		private readonly global::System.Collections.Generic.HashSet<string> m_typesNeedingNullSentinel;
	}
}
