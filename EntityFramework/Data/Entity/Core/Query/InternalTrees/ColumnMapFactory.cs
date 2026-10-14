using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000389 RID: 905
	internal class ColumnMapFactory
	{
		// Token: 0x06002BEE RID: 11246 RVA: 0x0008D4C4 File Offset: 0x0008B6C4
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.CollectionColumnMap CreateFunctionImportStructuralTypeColumnMap(global::System.Data.Common.DbDataReader storeDataReader, global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable mapping, int resultSetIndex, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.StructuralType baseStructuralType)
		{
			global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB resultMapping = mapping.GetResultMapping(resultSetIndex);
			if (resultMapping.NormalizedEntityTypeMappings.Count == 0)
			{
				return this.CreateColumnMapFromReaderAndType(storeDataReader, baseStructuralType, entitySet, resultMapping.ReturnTypeColumnsRenameMapping);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType item = baseStructuralType as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
			global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap[] array = global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.CreateDiscriminatorColumnMaps(storeDataReader, mapping, resultSetIndex);
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityType> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(resultMapping.MappedEntityTypes);
			hashSet.Add(item);
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap>(hashSet.Count);
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] array2 = null;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType in hashSet)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] columnMapsForType = global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.GetColumnMapsForType(storeDataReader, entityType, resultMapping.ReturnTypeColumnsRenameMapping);
				global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap value = global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.CreateEntityTypeElementColumnMap(storeDataReader, entityType, entitySet, columnMapsForType, resultMapping.ReturnTypeColumnsRenameMapping);
				if (!entityType.Abstract)
				{
					dictionary.Add(entityType, value);
				}
				if (entityType == baseStructuralType)
				{
					array2 = columnMapsForType;
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(baseStructuralType);
			string name = baseStructuralType.Name;
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] baseTypeColumns = array2;
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] typeDiscriminators = array;
			global::System.Data.Entity.Core.Query.InternalTrees.MultipleDiscriminatorPolymorphicColumnMap elementMap = new global::System.Data.Entity.Core.Query.InternalTrees.MultipleDiscriminatorPolymorphicColumnMap(type, name, baseTypeColumns, typeDiscriminators, dictionary, (object[] discriminatorValues) => mapping.Discriminate(discriminatorValues, resultSetIndex));
			return new global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap(baseStructuralType.GetCollectionType().TypeUsage, baseStructuralType.Name, elementMap, null, null);
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0008D618 File Offset: 0x0008B818
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.CollectionColumnMap CreateColumnMapFromReaderAndType(global::System.Data.Common.DbDataReader storeDataReader, global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping> renameList)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] columnMapsForType = global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.GetColumnMapsForType(storeDataReader, edmType, renameList);
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap elementMap = null;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(edmType))
			{
				elementMap = new global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType), edmType.Name, columnMapsForType, null);
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(edmType))
			{
				elementMap = new global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType), edmType.Name, columnMapsForType, null);
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsScalarType(edmType))
			{
				if (storeDataReader.FieldCount != 1)
				{
					throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataReaderFieldCountForScalarType);
				}
				elementMap = new global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType), edmType.Name, 0, 0);
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType))
			{
				elementMap = global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.CreateEntityTypeElementColumnMap(storeDataReader, edmType, entitySet, columnMapsForType, null);
			}
			return new global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap(edmType.GetCollectionType().TypeUsage, edmType.Name, elementMap, null, null);
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x0008D6CC File Offset: 0x0008B8CC
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.CollectionColumnMap CreateColumnMapFromReaderAndClrType(global::System.Data.Common.DbDataReader reader, global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			global::System.Reflection.ConstructorInfo declaredConstructor = type.GetDeclaredConstructor(new global::System.Type[0]);
			if (type.IsAbstract() || (null == declaredConstructor && !type.IsValueType()))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidTypeForStoreQuery(type));
			}
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Linq.Expressions.MemberAssignment, int, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> list = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Linq.Expressions.MemberAssignment, int, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>();
			foreach (global::System.Reflection.PropertyInfo propertyInfo in from p in type.GetInstanceProperties()
			select p.GetPropertyInfoForSet())
			{
				global::System.Type type2 = global::System.Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;
				global::System.Type type3 = type2.IsEnum() ? type2.GetEnumUnderlyingType() : propertyInfo.PropertyType;
				int item;
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
				if (global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.TryGetColumnOrdinalFromReader(reader, propertyInfo.Name, out item) && workspace.TryDetermineCSpaceModelType(type3, out edmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsScalarType(edmType) && propertyInfo.CanWriteExtended() && propertyInfo.GetIndexParameters().Length == 0 && null != propertyInfo.Setter())
				{
					list.Add(global::System.Tuple.Create<global::System.Linq.Expressions.MemberAssignment, int, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(global::System.Linq.Expressions.Expression.Bind(propertyInfo, global::System.Linq.Expressions.Expression.Parameter(propertyInfo.PropertyType, "placeholder")), item, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(propertyInfo.Name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType))));
				}
			}
			global::System.Reflection.MemberInfo[] array = new global::System.Reflection.MemberInfo[list.Count];
			global::System.Linq.Expressions.MemberBinding[] array2 = new global::System.Linq.Expressions.MemberBinding[list.Count];
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] array3 = new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[list.Count];
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] array4 = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[list.Count];
			int num = 0;
			foreach (global::System.Linq.IGrouping<int, global::System.Tuple<global::System.Linq.Expressions.MemberAssignment, int, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> grouping in from tuple in list
			group tuple by tuple.Item2 into tuple
			orderby tuple.Key
			select tuple)
			{
				if (grouping.Count<global::System.Tuple<global::System.Linq.Expressions.MemberAssignment, int, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>() != 1)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_TwoPropertiesMappedToSameColumn(reader.GetName(grouping.Key), string.Join(", ", grouping.Select((global::System.Tuple<global::System.Linq.Expressions.MemberAssignment, int, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> tuple) => tuple.Item3.Name).ToArray<string>())));
				}
				global::System.Tuple<global::System.Linq.Expressions.MemberAssignment, int, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> tuple2 = grouping.Single<global::System.Tuple<global::System.Linq.Expressions.MemberAssignment, int, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>();
				global::System.Linq.Expressions.MemberAssignment item2 = tuple2.Item1;
				int item3 = tuple2.Item2;
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty item4 = tuple2.Item3;
				array[num] = item2.Member;
				array2[num] = item2;
				array3[num] = new global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap(item4.TypeUsage, item4.Name, 0, item3);
				array4[num] = item4;
				num++;
			}
			global::System.Linq.Expressions.MemberInitExpression initExpression = global::System.Linq.Expressions.Expression.MemberInit((null == declaredConstructor) ? global::System.Linq.Expressions.Expression.New(type) : global::System.Linq.Expressions.Expression.New(declaredConstructor), array2);
			global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata = global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.CreateProjectionInitializer((global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection)workspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace), initExpression);
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = new global::System.Data.Entity.Core.Metadata.Edm.RowType(array4, initializerMetadata);
			global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap elementMap = new global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(rowType), "DefaultTypeProjection", array3, null);
			return new global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap(rowType.GetCollectionType().TypeUsage, rowType.Name, elementMap, null, null);
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x0008DA08 File Offset: 0x0008BC08
		private static global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap CreateEntityTypeElementColumnMap(global::System.Data.Common.DbDataReader storeDataReader, global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] propertyColumnMaps, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping> renameList)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmType;
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] array = new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[storeDataReader.FieldCount];
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap in propertyColumnMaps)
			{
				int columnPos = ((global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap)columnMap).ColumnPos;
				array[columnPos] = columnMap;
			}
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers = entityType.KeyMembers;
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] array2 = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[((global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>)keyMembers).Count];
			int num = 0;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember member in ((global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>)keyMembers))
			{
				int memberOrdinalFromReader = global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.GetMemberOrdinalFromReader(storeDataReader, member, edmType, renameList);
				global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap2 = array[memberOrdinalFromReader];
				array2[num] = (global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap)columnMap2;
				num++;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity entityIdentity = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity(entitySet, array2);
			return new global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType), edmType.Name, propertyColumnMaps, entityIdentity);
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x0008DAE4 File Offset: 0x0008BCE4
		private static global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] GetColumnMapsForType(global::System.Data.Common.DbDataReader storeDataReader, global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping> renameList)
		{
			global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> allStructuralMembers = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(edmType);
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] array = new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[allStructuralMembers.Count];
			int num = 0;
			foreach (object obj in allStructuralMembers)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
				if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsScalarType(edmMember.TypeUsage.EdmType))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataReaderUnableToMaterializeNonScalarType(edmMember.Name, edmMember.TypeUsage.EdmType.FullName));
				}
				int memberOrdinalFromReader = global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.GetMemberOrdinalFromReader(storeDataReader, edmMember, edmType, renameList);
				array[num] = new global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap(edmMember.TypeUsage, edmMember.Name, 0, memberOrdinalFromReader);
				num++;
			}
			return array;
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x0008DBA4 File Offset: 0x0008BDA4
		private static global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap[] CreateDiscriminatorColumnMaps(global::System.Data.Common.DbDataReader storeDataReader, global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable mapping, int resultIndex)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String));
			global::System.Collections.Generic.IList<string> discriminatorColumns = mapping.GetDiscriminatorColumns(resultIndex);
			global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap[] array = new global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap[discriminatorColumns.Count];
			for (int i = 0; i < array.Length; i++)
			{
				string text = discriminatorColumns[i];
				global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap scalarColumnMap = new global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap(type, text, 0, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.GetDiscriminatorOrdinalFromReader(storeDataReader, text, mapping.FunctionImport));
				array[i] = scalarColumnMap;
			}
			return array;
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x0008DC10 File Offset: 0x0008BE10
		private static int GetMemberOrdinalFromReader(global::System.Data.Common.DbDataReader storeDataReader, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, global::System.Data.Entity.Core.Metadata.Edm.EdmType currentType, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping> renameList)
		{
			string renameForMember = global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.GetRenameForMember(member, currentType, renameList);
			int result;
			if (!global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.TryGetColumnOrdinalFromReader(storeDataReader, renameForMember, out result))
			{
				throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataReaderMissingColumnForType(currentType.FullName, member.Name));
			}
			return result;
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x0008DC4C File Offset: 0x0008BE4C
		private static string GetRenameForMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, global::System.Data.Entity.Core.Metadata.Edm.EdmType currentType, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping> renameList)
		{
			if (renameList != null && renameList.Count != 0 && renameList.Any((global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping> m) => m.Key == member.Name))
			{
				return renameList[member.Name].GetRename(currentType);
			}
			return member.Name;
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x0008DCA8 File Offset: 0x0008BEA8
		private static int GetDiscriminatorOrdinalFromReader(global::System.Data.Common.DbDataReader storeDataReader, string columnName, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport)
		{
			int result;
			if (!global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory.TryGetColumnOrdinalFromReader(storeDataReader, columnName, out result))
			{
				throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataReaderMissingDiscriminatorColumn(columnName, functionImport.FullName));
			}
			return result;
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x0008DCD4 File Offset: 0x0008BED4
		private static bool TryGetColumnOrdinalFromReader(global::System.Data.Common.DbDataReader storeDataReader, string columnName, out int ordinal)
		{
			if (storeDataReader.FieldCount == 0)
			{
				ordinal = 0;
				return false;
			}
			bool result;
			try
			{
				ordinal = storeDataReader.GetOrdinal(columnName);
				result = true;
			}
			catch (global::System.IndexOutOfRangeException)
			{
				ordinal = 0;
				result = false;
			}
			return result;
		}
	}
}
