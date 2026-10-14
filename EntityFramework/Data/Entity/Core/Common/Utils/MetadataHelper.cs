using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Security.Cryptography;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005FA RID: 1530
	internal static class MetadataHelper
	{
		// Token: 0x06004AD0 RID: 19152 RVA: 0x001082F0 File Offset: 0x001064F0
		internal static bool TryGetFunctionImportReturnType<T>(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, int resultSetIndex, out T returnType) where T : global::System.Data.Entity.Core.Metadata.Edm.EdmType
		{
			T t;
			if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetWrappedReturnEdmTypeFromFunctionImport<T>(functionImport, resultSetIndex, out t) && ((typeof(global::System.Data.Entity.Core.Metadata.Edm.EntityType).Equals(typeof(T)) && t is global::System.Data.Entity.Core.Metadata.Edm.EntityType) || (typeof(global::System.Data.Entity.Core.Metadata.Edm.ComplexType).Equals(typeof(T)) && t is global::System.Data.Entity.Core.Metadata.Edm.ComplexType) || (typeof(global::System.Data.Entity.Core.Metadata.Edm.StructuralType).Equals(typeof(T)) && t is global::System.Data.Entity.Core.Metadata.Edm.StructuralType) || (typeof(global::System.Data.Entity.Core.Metadata.Edm.EdmType).Equals(typeof(T)) && t != null)))
			{
				returnType = t;
				return true;
			}
			returnType = default(T);
			return false;
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x001083B8 File Offset: 0x001065B8
		private static bool TryGetWrappedReturnEdmTypeFromFunctionImport<T>(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, int resultSetIndex, out T resultType) where T : global::System.Data.Entity.Core.Metadata.Edm.EdmType
		{
			resultType = default(T);
			global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType;
			if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnCollectionType(functionImport, resultSetIndex, out collectionType))
			{
				resultType = (collectionType.TypeUsage.EdmType as T);
				return true;
			}
			return false;
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x001083F8 File Offset: 0x001065F8
		internal static bool TryGetFunctionImportReturnCollectionType(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, int resultSetIndex, out global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter returnParameter = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetReturnParameter(functionImport, resultSetIndex);
			if (returnParameter != null && returnParameter.TypeUsage.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
			{
				collectionType = (global::System.Data.Entity.Core.Metadata.Edm.CollectionType)returnParameter.TypeUsage.EdmType;
				return true;
			}
			collectionType = null;
			return false;
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x0010843B File Offset: 0x0010663B
		internal static global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter GetReturnParameter(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, int resultSetIndex)
		{
			if (functionImport.ReturnParameters.Count <= resultSetIndex)
			{
				return null;
			}
			return functionImport.ReturnParameters[resultSetIndex];
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x00108459 File Offset: 0x00106659
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmFunction GetFunctionImport(string functionName, string defaultContainerName, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, out string containerName, out string functionImportName)
		{
			global::System.Data.Entity.Core.Common.Utils.CommandHelper.ParseFunctionImportCommandText(functionName, defaultContainerName, out containerName, out functionImportName);
			return global::System.Data.Entity.Core.Common.Utils.CommandHelper.FindFunctionImport(workspace, containerName, functionImportName);
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x00108470 File Offset: 0x00106670
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmType GetAndCheckFunctionImportReturnType<TElement>(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, int resultSetIndex, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (!global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(functionImport, resultSetIndex, out edmType))
			{
				throw global::System.Data.Entity.Core.EntityUtil.ExecuteFunctionCalledWithNonReaderFunction(functionImport);
			}
			global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CheckFunctionImportReturnType<TElement>(edmType, workspace);
			return edmType;
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x00108498 File Offset: 0x00106698
		internal static void CheckFunctionImportReturnType<TElement>(global::System.Data.Entity.Core.Metadata.Edm.EdmType expectedEdmType, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType item = expectedEdmType;
			bool flag;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(expectedEdmType, out flag))
			{
				item = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(flag ? global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography : global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (!workspace.TryDetermineCSpaceModelType<TElement>(out edmType) || !edmType.EdmEquals(item))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_ExecuteFunctionTypeMismatch(typeof(TElement).FullName, expectedEdmType.FullName));
			}
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x001084F3 File Offset: 0x001066F3
		internal static global::System.Data.ParameterDirection ParameterModeToParameterDirection(global::System.Data.Entity.Core.Metadata.Edm.ParameterMode mode)
		{
			switch (mode)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In:
				return global::System.Data.ParameterDirection.Input;
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.Out:
				return global::System.Data.ParameterDirection.Output;
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.InOut:
				return global::System.Data.ParameterDirection.InputOutput;
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue:
				return global::System.Data.ParameterDirection.ReturnValue;
			default:
				return (global::System.Data.ParameterDirection)0;
			}
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x00108518 File Offset: 0x00106718
		internal static bool DoesMemberExist(global::System.Data.Entity.Core.Metadata.Edm.StructuralType type, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Enumerator enumerator = type.Members.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Equals(member))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x00108574 File Offset: 0x00106774
		internal static bool IsNonRefSimpleMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return member.TypeUsage.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType || member.TypeUsage.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType;
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x001085A0 File Offset: 0x001067A0
		internal static bool HasDiscreteDomain(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = edmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
			return primitiveType != null && primitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean;
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x001085C2 File Offset: 0x001067C2
		internal static global::System.Data.Entity.Core.Metadata.Edm.EntityType GetEntityTypeForEnd(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember end)
		{
			return (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)end.TypeUsage.EdmType).ElementType;
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x001085DE File Offset: 0x001067DE
		internal static global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySetAtEnd(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endMember)
		{
			return associationSet.AssociationSetEnds[endMember.Name].EntitySet;
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x001085F8 File Offset: 0x001067F8
		internal static global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember GetOtherAssociationEnd(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endMember)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> members = endMember.DeclaringType.Members;
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = members[0];
			if (endMember != edmMember)
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)edmMember;
			}
			return (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)members[1];
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x00108630 File Offset: 0x00106830
		internal static bool IsEveryOtherEndAtLeastOne(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember member)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSet.AssociationSetEnds)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember correspondingAssociationEndMember = associationSetEnd.CorrespondingAssociationEndMember;
				if (!correspondingAssociationEndMember.Equals(member) && global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetLowerBoundOfMultiplicity(correspondingAssociationEndMember.RelationshipMultiplicity) == 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x001086A0 File Offset: 0x001068A0
		internal static bool IsAssociationValidForEntityType(global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd toEnd, global::System.Data.Entity.Core.Metadata.Edm.EntityType type)
		{
			return global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetOppositeEnd(toEnd).CorrespondingAssociationEndMember).IsAssignableFrom(type);
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x001086B8 File Offset: 0x001068B8
		internal static global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd GetOppositeEnd(global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd end)
		{
			return (from e in end.ParentAssociationSet.AssociationSetEnds
			where !e.EdmEquals(end)
			select e).Single<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>();
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x001086F8 File Offset: 0x001068F8
		internal static bool IsComposable(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty;
			if (function.MetadataProperties.TryGetValue("IsComposableAttribute", false, out metadataProperty))
			{
				return (bool)metadataProperty.Value;
			}
			return !function.IsFunctionImport;
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x0010872F File Offset: 0x0010692F
		internal static bool IsMemberNullable(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEdmProperty(member) && ((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)member).Nullable;
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x00108748 File Offset: 0x00106948
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> GetInfluencingEntitySetsForTable(global::System.Data.Entity.Core.Metadata.Edm.EntitySet table, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection = null;
			workspace.TryGetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace, out itemCollection);
			global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> <>9__3;
			global::System.Func<global::System.Data.Entity.Core.Mapping.TypeMapping, bool> <>9__2;
			return (from m in global::System.Data.Entity.Core.Metadata.Edm.MappingMetadataHelper.GetEntityContainerMap((global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection)itemCollection, table.EntityContainer).EntitySetMaps.Where(delegate(global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping map)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.TypeMapping> typeMappings = map.TypeMappings;
				global::System.Func<global::System.Data.Entity.Core.Mapping.TypeMapping, bool> predicate;
				if ((predicate = <>9__2) == null)
				{
					predicate = (<>9__2 = delegate(global::System.Data.Entity.Core.Mapping.TypeMapping typeMap)
					{
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> mappingFragments = typeMap.MappingFragments;
						global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> predicate2;
						if ((predicate2 = <>9__3) == null)
						{
							predicate2 = (<>9__3 = ((global::System.Data.Entity.Core.Mapping.MappingFragment mappingFrag) => mappingFrag.TableSet.EdmEquals(table)));
						}
						return mappingFragments.Any(predicate2);
					});
				}
				return typeMappings.Any(predicate);
			})
			select m.Set).Cast<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>().Distinct<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x001087C8 File Offset: 0x001069C8
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> GetTypeAndSubtypesOf(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, bool includeAbstractTypes)
		{
			return global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(type, workspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace), includeAbstractTypes);
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x001087D8 File Offset: 0x001069D8
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> GetTypeAndSubtypesOf(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection, bool includeAbstractTypes)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(type))
			{
				type = ((global::System.Data.Entity.Core.Metadata.Edm.RefType)type).ElementType;
			}
			if (includeAbstractTypes || !type.Abstract)
			{
				yield return type;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(type, itemCollection, includeAbstractTypes))
			{
				yield return edmType;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmType> enumerator = null;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 in global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(type, itemCollection, includeAbstractTypes))
			{
				yield return edmType2;
			}
			enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x001087F6 File Offset: 0x001069F6
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> GetTypeAndSubtypesOf<T_EdmType>(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection, bool includeAbstractTypes) where T_EdmType : global::System.Data.Entity.Core.Metadata.Edm.EdmType
		{
			T_EdmType specificType = type as T_EdmType;
			if (specificType != null)
			{
				global::System.Collections.Generic.IEnumerable<T_EdmType> items = itemCollection.GetItems<T_EdmType>();
				foreach (T_EdmType t_EdmType in items)
				{
					if (!specificType.Equals(t_EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSubtypeOf(t_EdmType, specificType) && (includeAbstractTypes || !t_EdmType.Abstract))
					{
						yield return t_EdmType;
					}
				}
				global::System.Collections.Generic.IEnumerator<T_EdmType> enumerator = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x00108814 File Offset: 0x00106A14
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> GetTypeAndParentTypesOf(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, bool includeAbstractTypes)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(type))
			{
				type = ((global::System.Data.Entity.Core.Metadata.Edm.RefType)type).ElementType;
			}
			for (global::System.Data.Entity.Core.Metadata.Edm.EdmType specificType = type; specificType != null; specificType = (specificType.BaseType as global::System.Data.Entity.Core.Metadata.Edm.EntityType))
			{
				if (includeAbstractTypes || !specificType.Abstract)
				{
					yield return specificType;
				}
			}
			yield break;
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x0010882C File Offset: 0x00106A2C
		internal static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>> BuildUndirectedGraphOfTypes(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType in ((global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType>)edmItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityType>()))
			{
				if (entityType.BaseType != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = entityType.BaseType as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
					global::System.Data.Entity.Core.Common.Utils.MetadataHelper.AddDirectedEdgeBetweenEntityTypes(dictionary, entityType, entityType2);
					global::System.Data.Entity.Core.Common.Utils.MetadataHelper.AddDirectedEdgeBetweenEntityTypes(dictionary, entityType2, entityType);
				}
			}
			return dictionary;
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x001088A0 File Offset: 0x00106AA0
		internal static bool IsParentOf(global::System.Data.Entity.Core.Metadata.Edm.EntityType a, global::System.Data.Entity.Core.Metadata.Edm.EntityType b)
		{
			for (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = b.BaseType as global::System.Data.Entity.Core.Metadata.Edm.EntityType; entityType != null; entityType = (entityType.BaseType as global::System.Data.Entity.Core.Metadata.Edm.EntityType))
			{
				if (entityType.EdmEquals(a))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x001088D8 File Offset: 0x00106AD8
		private static void AddDirectedEdgeBetweenEntityTypes(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>> graph, global::System.Data.Entity.Core.Metadata.Edm.EntityType a, global::System.Data.Entity.Core.Metadata.Edm.EntityType b)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> set;
			if (graph.ContainsKey(a))
			{
				set = graph[a];
			}
			else
			{
				set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
				graph.Add(a, set);
			}
			set.Add(b);
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x00108910 File Offset: 0x00106B10
		internal static bool DoesEndKeySubsumeAssociationSetKey(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet assocSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember thisEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> associationkeys)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType elementType = assocSet.ElementType;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType thisEndsEntityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)thisEnd.TypeUsage.EdmType).ElementType;
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> other = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Metadata.Edm.EntityType>>(from edmMember in thisEndsEntityType.KeyMembers
			select new global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(edmMember, thisEndsEntityType));
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in elementType.ReferentialConstraints)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> enumerable;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType second;
				if (thisEnd.Equals(referentialConstraint.ToRole))
				{
					enumerable = global::System.Data.Entity.Core.Common.Utils.Helpers.AsSuperTypeList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(referentialConstraint.FromProperties);
					second = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)referentialConstraint.FromRole.TypeUsage.EdmType).ElementType;
				}
				else
				{
					if (!thisEnd.Equals(referentialConstraint.FromRole))
					{
						continue;
					}
					enumerable = global::System.Data.Entity.Core.Common.Utils.Helpers.AsSuperTypeList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(referentialConstraint.ToProperties);
					second = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)referentialConstraint.ToRole.TypeUsage.EdmType).ElementType;
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember first in enumerable)
				{
					associationkeys.Remove(new global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(first, second));
				}
			}
			return associationkeys.IsSubsetOf(other);
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x00108A78 File Offset: 0x00106C78
		internal static bool DoesEndFormKey(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember end)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in associationSet.ElementType.Members)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)edmMember;
				if (!associationEndMember.Equals(end) && associationEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x00108AE8 File Offset: 0x00106CE8
		internal static bool IsExtentAtSomeRelationshipEnd(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet relationshipSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntitySet(extent) && global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetSomeEndForEntitySet(relationshipSet, extent) != null;
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x00108B00 File Offset: 0x00106D00
		internal static global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember GetSomeEndForEntitySet(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSet.AssociationSetEnds)
			{
				if (associationSetEnd.EntitySet.Equals(entitySet))
				{
					return associationSetEnd.CorrespondingAssociationEndMember;
				}
			}
			return null;
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x00108B68 File Offset: 0x00106D68
		internal static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> GetAssociationsForEntitySets(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet1, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet2)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entitySet1.EntityContainer.BaseEntitySets)
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRelationshipSet(entitySetBase))
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)entitySetBase;
					if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsExtentAtSomeRelationshipEnd(associationSet, entitySet1) && global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsExtentAtSomeRelationshipEnd(associationSet, entitySet2))
					{
						list.Add(associationSet);
					}
				}
			}
			return list;
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x00108BE8 File Offset: 0x00106DE8
		internal static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> GetAssociationsForEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entitySet.EntityContainer.BaseEntitySets)
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRelationshipSet(entitySetBase))
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)entitySetBase;
					if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsExtentAtSomeRelationshipEnd(associationSet, entitySet))
					{
						list.Add(associationSet);
					}
				}
			}
			return list;
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x00108C60 File Offset: 0x00106E60
		internal static bool IsSuperTypeOf(global::System.Data.Entity.Core.Metadata.Edm.EdmType superType, global::System.Data.Entity.Core.Metadata.Edm.EdmType subType)
		{
			for (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = subType; edmType != null; edmType = edmType.BaseType)
			{
				if (edmType.Equals(superType))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x00108C87 File Offset: 0x00106E87
		internal static bool IsPartOfEntityTypeKey(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(member.DeclaringType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEdmProperty(member) && ((global::System.Data.Entity.Core.Metadata.Edm.EntityType)member.DeclaringType).KeyMembers.Contains(member);
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x00108CB6 File Offset: 0x00106EB6
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetElementType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType == typeUsage.EdmType.BuiltInTypeKind)
			{
				return global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetElementType(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)typeUsage.EdmType).TypeUsage);
			}
			return typeUsage;
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x00108CDD File Offset: 0x00106EDD
		internal static int GetLowerBoundOfMultiplicity(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity multiplicity)
		{
			if (multiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many || multiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x00108CEC File Offset: 0x00106EEC
		internal static int? GetUpperBoundOfMultiplicity(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity multiplicity)
		{
			if (multiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One || multiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)
			{
				return new int?(1);
			}
			return null;
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x00108D10 File Offset: 0x00106F10
		internal static global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> GetConcurrencyMembersForTypeHierarchy(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase superType, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(superType, edmItemCollection, true))
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in ((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)edmType).Members)
				{
					if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetConcurrencyMode(edmMember) == global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed)
					{
						set.Add(edmMember);
					}
				}
			}
			return set;
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x00108DB0 File Offset: 0x00106FB0
		internal static global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode GetConcurrencyMode(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetConcurrencyMode(member.TypeUsage);
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x00108DC0 File Offset: 0x00106FC0
		internal static global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode GetConcurrencyMode(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (typeUsage.Facets.TryGetValue("ConcurrencyMode", false, out facet) && facet.Value != null)
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode)facet.Value;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.None;
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x00108DF8 File Offset: 0x00106FF8
		internal static global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern GetStoreGeneratedPattern(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (member.TypeUsage.Facets.TryGetValue("StoreGeneratedPattern", false, out facet) && facet.Value != null)
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern)facet.Value;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.None;
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x00108E34 File Offset: 0x00107034
		internal static bool CheckIfAllErrorsAreWarnings(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> schemaErrors)
		{
			int count = schemaErrors.Count;
			for (int i = 0; i < count; i++)
			{
				if (schemaErrors[i].Severity != global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Warning)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x00108E68 File Offset: 0x00107068
		internal static global::System.Security.Cryptography.HashAlgorithm CreateMetadataHashAlgorithm(double schemaVersion)
		{
			global::System.Security.Cryptography.HashAlgorithm result;
			if (schemaVersion < 2.0)
			{
				result = new global::System.Security.Cryptography.MD5CryptoServiceProvider();
			}
			else
			{
				result = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CreateSHA256HashAlgorithm();
			}
			return result;
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x00108E90 File Offset: 0x00107090
		internal static global::System.Security.Cryptography.SHA256 CreateSHA256HashAlgorithm()
		{
			global::System.Security.Cryptography.SHA256 result;
			try
			{
				result = new global::System.Security.Cryptography.SHA256CryptoServiceProvider();
			}
			catch (global::System.PlatformNotSupportedException)
			{
				result = new global::System.Security.Cryptography.SHA256Managed();
			}
			return result;
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x00108EC0 File Offset: 0x001070C0
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ConvertStoreTypeUsageToEdmTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeTypeUsage)
		{
			return storeTypeUsage.ModelTypeUsage.ShallowCopy(global::System.Data.Entity.Core.Metadata.Edm.FacetValues.NullFacetValues);
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x00108ED2 File Offset: 0x001070D2
		internal static byte GetPrecision(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type.GetFacetValue("Precision");
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x00108EDF File Offset: 0x001070DF
		internal static byte GetScale(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type.GetFacetValue("Scale");
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x00108EEC File Offset: 0x001070EC
		internal static int GetMaxLength(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type.GetFacetValue("MaxLength");
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x00108EF9 File Offset: 0x001070F9
		internal static T GetFacetValue<T>(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string facetName)
		{
			return (T)((object)type.Facets[facetName].Value);
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x00108F11 File Offset: 0x00107111
		internal static global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor GetNavigationPropertyAccessor(global::System.Data.Entity.Core.Metadata.Edm.EntityType sourceEntityType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember)
		{
			return global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetNavigationPropertyAccessor(sourceEntityType, sourceMember.DeclaringType.FullName, sourceMember.Name, targetMember.Name);
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x00108F30 File Offset: 0x00107130
		internal static global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor GetNavigationPropertyAccessor(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, string relationshipType, string fromName, string toName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty;
			if (entityType.TryGetNavigationProperty(relationshipType, fromName, toName, out navigationProperty))
			{
				return navigationProperty.Accessor;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor.NoNavigationProperty;
		}
	}
}
