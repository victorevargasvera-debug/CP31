using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Common.Utils.Boolean;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000543 RID: 1347
	internal sealed class FunctionImportStructuralTypeMappingKB
	{
		// Token: 0x06004219 RID: 16921 RVA: 0x000DEE58 File Offset: 0x000DD058
		internal FunctionImportStructuralTypeMappingKB(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping> structuralTypeMappings, global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection)
		{
			this.m_itemCollection = itemCollection;
			if (structuralTypeMappings.Count<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>() == 0)
			{
				this.ReturnTypeColumnsRenameMapping = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping>();
				this.NormalizedEntityTypeMappings = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping>());
				this.DiscriminatorColumns = new global::System.Collections.ObjectModel.ReadOnlyCollection<string>(new global::System.Collections.Generic.List<string>());
				this.MappedEntityTypes = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType>());
				return;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping> enumerable = structuralTypeMappings.OfType<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping>();
			if (enumerable != null && enumerable.FirstOrDefault<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping>() != null)
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>>();
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>> dictionary2 = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>>();
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping>();
				this.MappedEntityTypes = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(enumerable.SelectMany((global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping mapping) => mapping.GetMappedEntityTypes(this.m_itemCollection)).Distinct<global::System.Data.Entity.Core.Metadata.Edm.EntityType>().ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>());
				this.DiscriminatorColumns = new global::System.Collections.ObjectModel.ReadOnlyCollection<string>(enumerable.SelectMany((global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping mapping) => mapping.GetDiscriminatorColumns()).Distinct<string>().ToList<string>());
				this.m_entityTypeLineInfos = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntityType>.Default);
				this.m_isTypeOfLineInfos = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntityType>.Default);
				foreach (global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping functionImportEntityTypeMapping in enumerable)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType key in functionImportEntityTypeMapping.EntityTypes)
					{
						this.m_entityTypeLineInfos.Add(key, functionImportEntityTypeMapping.LineInfo);
					}
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType key2 in functionImportEntityTypeMapping.IsOfTypeEntityTypes)
					{
						this.m_isTypeOfLineInfos.Add(key2, functionImportEntityTypeMapping.LineInfo);
					}
					global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> dictionary3 = functionImportEntityTypeMapping.Conditions.ToDictionary((global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition condition) => condition.ColumnName, (global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition condition) => condition);
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition>(this.DiscriminatorColumns.Count);
					for (int i = 0; i < this.DiscriminatorColumns.Count; i++)
					{
						string key3 = this.DiscriminatorColumns[i];
						global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition item;
						if (dictionary3.TryGetValue(key3, out item))
						{
							list2.Add(item);
						}
						else
						{
							list2.Add(null);
						}
					}
					bool[] array = new bool[this.MappedEntityTypes.Count];
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(functionImportEntityTypeMapping.GetMappedEntityTypes(this.m_itemCollection));
					for (int j = 0; j < this.MappedEntityTypes.Count; j++)
					{
						array[j] = set.Contains(this.MappedEntityTypes[j]);
					}
					list.Add(new global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping(this, list2, new global::System.Collections.BitArray(array)));
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType in functionImportEntityTypeMapping.IsOfTypeEntityTypes)
					{
						if (!dictionary.Keys.Contains(entityType))
						{
							dictionary.Add(entityType, new global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>());
						}
						foreach (global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping item2 in functionImportEntityTypeMapping.ColumnsRenameList)
						{
							dictionary[entityType].Add(item2);
						}
					}
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 in functionImportEntityTypeMapping.EntityTypes)
					{
						if (!dictionary2.Keys.Contains(entityType2))
						{
							dictionary2.Add(entityType2, new global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>());
						}
						foreach (global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping item3 in functionImportEntityTypeMapping.ColumnsRenameList)
						{
							dictionary2[entityType2].Add(item3);
						}
					}
				}
				this.ReturnTypeColumnsRenameMapping = new global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeEntityTypeColumnsRenameBuilder(dictionary, dictionary2).ColumnRenameMapping;
				this.NormalizedEntityTypeMappings = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping>(list);
				return;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportComplexTypeMapping> source = structuralTypeMappings.Cast<global::System.Data.Entity.Core.Mapping.FunctionImportComplexTypeMapping>();
			this.ReturnTypeColumnsRenameMapping = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping>();
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping functionImportReturnTypePropertyMapping in source.First<global::System.Data.Entity.Core.Mapping.FunctionImportComplexTypeMapping>().ColumnsRenameList)
			{
				global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping functionImportReturnTypeStructuralTypeColumnRenameMapping = new global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping(functionImportReturnTypePropertyMapping.CMember);
				functionImportReturnTypeStructuralTypeColumnRenameMapping.AddRename(new global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn(functionImportReturnTypePropertyMapping.SColumn, source.First<global::System.Data.Entity.Core.Mapping.FunctionImportComplexTypeMapping>().ReturnType, false, functionImportReturnTypePropertyMapping.LineInfo));
				this.ReturnTypeColumnsRenameMapping.Add(functionImportReturnTypePropertyMapping.CMember, functionImportReturnTypeStructuralTypeColumnRenameMapping);
			}
			this.NormalizedEntityTypeMappings = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping>());
			this.DiscriminatorColumns = new global::System.Collections.ObjectModel.ReadOnlyCollection<string>(new global::System.Collections.Generic.List<string>());
			this.MappedEntityTypes = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType>());
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x000DF3E8 File Offset: 0x000DD5E8
		internal bool ValidateTypeConditions(bool validateAmbiguity, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors, string sourceLocation)
		{
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo> keyToListMap;
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo> keyToListMap2;
			this.GetUnreachableTypes(validateAmbiguity, out keyToListMap, out keyToListMap2);
			bool result = true;
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.LineInfo>> keyValuePair in keyToListMap.KeyValuePairs)
			{
				global::System.Data.Entity.Core.Mapping.LineInfo lineInfo = keyValuePair.Value.First<global::System.Data.Entity.Core.Mapping.LineInfo>();
				string p = global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(from li in keyValuePair.Value
				select li.LineNumber);
				global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_UnreachableType(keyValuePair.Key.FullName, p), 2076, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, sourceLocation, lineInfo.LineNumber, lineInfo.LinePosition);
				errors.Add(item);
				result = false;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.LineInfo>> keyValuePair2 in keyToListMap2.KeyValuePairs)
			{
				global::System.Data.Entity.Core.Mapping.LineInfo lineInfo2 = keyValuePair2.Value.First<global::System.Data.Entity.Core.Mapping.LineInfo>();
				string p2 = global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(from li in keyValuePair2.Value
				select li.LineNumber);
				global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item2 = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_UnreachableIsTypeOf("IsTypeOf(" + keyValuePair2.Key.FullName + ")", p2), 2076, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, sourceLocation, lineInfo2.LineNumber, lineInfo2.LinePosition);
				errors.Add(item2);
				result = false;
			}
			return result;
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x000DF580 File Offset: 0x000DD780
		private void GetUnreachableTypes(bool validateAmbiguity, out global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo> unreachableEntityTypes, out global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo> unreachableIsTypeOfs)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<string, global::System.Data.Entity.Core.Mapping.ValueCondition>[] variables = this.ConstructDomainVariables();
			global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraintConversionContext<string, global::System.Data.Entity.Core.Mapping.ValueCondition> converter = new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraintConversionContext<string, global::System.Data.Entity.Core.Mapping.ValueCondition>();
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] mappingConditions = this.ConvertMappingConditionsToVertices(converter, variables);
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> reachableTypes = validateAmbiguity ? this.FindUnambiguouslyReachableTypes(converter, mappingConditions) : this.FindReachableTypes(converter, mappingConditions);
			this.CollectUnreachableTypes(reachableTypes, out unreachableEntityTypes, out unreachableIsTypeOfs);
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x000DF5C4 File Offset: 0x000DD7C4
		private global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<string, global::System.Data.Entity.Core.Mapping.ValueCondition>[] ConstructDomainVariables()
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ValueCondition>[] array = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ValueCondition>[this.DiscriminatorColumns.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ValueCondition>();
				array[i].Add(global::System.Data.Entity.Core.Mapping.ValueCondition.IsOther);
				array[i].Add(global::System.Data.Entity.Core.Mapping.ValueCondition.IsNull);
			}
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping functionImportNormalizedEntityTypeMapping in this.NormalizedEntityTypeMappings)
			{
				for (int j = 0; j < this.DiscriminatorColumns.Count; j++)
				{
					global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition functionImportEntityTypeMappingCondition = functionImportNormalizedEntityTypeMapping.ColumnConditions[j];
					if (functionImportEntityTypeMappingCondition != null && !functionImportEntityTypeMappingCondition.ConditionValue.IsNotNullCondition)
					{
						array[j].Add(functionImportEntityTypeMappingCondition.ConditionValue);
					}
				}
			}
			global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<string, global::System.Data.Entity.Core.Mapping.ValueCondition>[] array2 = new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<string, global::System.Data.Entity.Core.Mapping.ValueCondition>[array.Length];
			for (int k = 0; k < array2.Length; k++)
			{
				array2[k] = new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<string, global::System.Data.Entity.Core.Mapping.ValueCondition>(this.DiscriminatorColumns[k], array[k].MakeReadOnly());
			}
			return array2;
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x000DF6D4 File Offset: 0x000DD8D4
		private global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] ConvertMappingConditionsToVertices(global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<string, global::System.Data.Entity.Core.Mapping.ValueCondition>> converter, global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<string, global::System.Data.Entity.Core.Mapping.ValueCondition>[] variables)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] array = new global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[this.NormalizedEntityTypeMappings.Count];
			for (int i = 0; i < array.Length; i++)
			{
				global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping functionImportNormalizedEntityTypeMapping = this.NormalizedEntityTypeMappings[i];
				global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex = global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One;
				for (int j = 0; j < this.DiscriminatorColumns.Count; j++)
				{
					global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition functionImportEntityTypeMappingCondition = functionImportNormalizedEntityTypeMapping.ColumnConditions[j];
					if (functionImportEntityTypeMappingCondition != null)
					{
						global::System.Data.Entity.Core.Mapping.ValueCondition conditionValue = functionImportEntityTypeMappingCondition.ConditionValue;
						if (conditionValue.IsNotNullCondition)
						{
							global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<string, global::System.Data.Entity.Core.Mapping.ValueCondition>> term = new global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<string, global::System.Data.Entity.Core.Mapping.ValueCondition>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<string, global::System.Data.Entity.Core.Mapping.ValueCondition>(variables[j], global::System.Data.Entity.Core.Mapping.ValueCondition.IsNull));
							global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex2 = converter.TranslateTermToVertex(term);
							vertex = converter.Solver.And(vertex, converter.Solver.Not(vertex2));
						}
						else
						{
							global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<string, global::System.Data.Entity.Core.Mapping.ValueCondition>> term2 = new global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<string, global::System.Data.Entity.Core.Mapping.ValueCondition>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<string, global::System.Data.Entity.Core.Mapping.ValueCondition>(variables[j], conditionValue));
							vertex = converter.Solver.And(vertex, converter.TranslateTermToVertex(term2));
						}
					}
				}
				array[i] = vertex;
			}
			return array;
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x000DF7C8 File Offset: 0x000DD9C8
		private global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> FindReachableTypes(global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraintConversionContext<string, global::System.Data.Entity.Core.Mapping.ValueCondition> converter, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] mappingConditions)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] array = new global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[this.MappedEntityTypes.Count];
			for (int k = 0; k < array.Length; k++)
			{
				global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex = global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One;
				for (int j = 0; j < this.NormalizedEntityTypeMappings.Count; j++)
				{
					if (this.NormalizedEntityTypeMappings[j].ImpliedEntityTypes[k])
					{
						vertex = converter.Solver.And(vertex, mappingConditions[j]);
					}
					else
					{
						vertex = converter.Solver.And(vertex, converter.Solver.Not(mappingConditions[j]));
					}
				}
				array[k] = vertex;
			}
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			int i;
			global::System.Func<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, int, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex> <>9__0;
			int i2;
			for (i = 0; i < array.Length; i = i2 + 1)
			{
				global::System.Data.Entity.Core.Common.Utils.Boolean.Solver solver = converter.Solver;
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex> source = array;
				global::System.Func<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, int, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex> selector;
				if ((selector = <>9__0) == null)
				{
					selector = (<>9__0 = delegate(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex typeCondition, int ordinal)
					{
						if (ordinal != i)
						{
							return converter.Solver.Not(typeCondition);
						}
						return typeCondition;
					});
				}
				if (!solver.And(source.Select(selector)).IsZero())
				{
					set.Add(this.MappedEntityTypes[i]);
				}
				i2 = i;
			}
			return set;
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x000DF90C File Offset: 0x000DDB0C
		private global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> FindUnambiguouslyReachableTypes(global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraintConversionContext<string, global::System.Data.Entity.Core.Mapping.ValueCondition> converter, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] mappingConditions)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] array = new global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[this.MappedEntityTypes.Count];
			for (int i = 0; i < array.Length; i++)
			{
				global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex = global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One;
				for (int j = 0; j < this.NormalizedEntityTypeMappings.Count; j++)
				{
					if (this.NormalizedEntityTypeMappings[j].ImpliedEntityTypes[i])
					{
						vertex = converter.Solver.And(vertex, mappingConditions[j]);
					}
				}
				array[i] = vertex;
			}
			global::System.Collections.BitArray bitArray = new global::System.Collections.BitArray(array.Length, true);
			for (int k = 0; k < array.Length; k++)
			{
				if (array[k].IsZero())
				{
					bitArray[k] = false;
				}
				else
				{
					for (int l = k + 1; l < array.Length; l++)
					{
						if (!converter.Solver.And(array[k], array[l]).IsZero())
						{
							bitArray[k] = false;
							bitArray[l] = false;
						}
					}
				}
			}
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			for (int m = 0; m < array.Length; m++)
			{
				if (bitArray[m])
				{
					set.Add(this.MappedEntityTypes[m]);
				}
			}
			return set;
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x000DFA34 File Offset: 0x000DDC34
		private void CollectUnreachableTypes(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> reachableTypes, out global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo> entityTypes, out global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo> isTypeOfEntityTypes)
		{
			entityTypes = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntityType>.Default);
			isTypeOfEntityTypes = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntityType>.Default);
			if (reachableTypes.Count == this.MappedEntityTypes.Count)
			{
				return;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType in this.m_isTypeOfLineInfos.Keys)
			{
				if (!global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(entityType, this.m_itemCollection, false).Cast<global::System.Data.Entity.Core.Metadata.Edm.EntityType>().Intersect(reachableTypes).Any<global::System.Data.Entity.Core.Metadata.Edm.EntityType>())
				{
					isTypeOfEntityTypes.AddRange(entityType, this.m_isTypeOfLineInfos.EnumerateValues(entityType));
				}
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 in this.m_entityTypeLineInfos.Keys)
			{
				if (!reachableTypes.Contains(entityType2))
				{
					entityTypes.AddRange(entityType2, this.m_entityTypeLineInfos.EnumerateValues(entityType2));
				}
			}
		}

		// Token: 0x040016F0 RID: 5872
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ItemCollection m_itemCollection;

		// Token: 0x040016F1 RID: 5873
		private readonly global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo> m_entityTypeLineInfos;

		// Token: 0x040016F2 RID: 5874
		private readonly global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.LineInfo> m_isTypeOfLineInfos;

		// Token: 0x040016F3 RID: 5875
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType> MappedEntityTypes;

		// Token: 0x040016F4 RID: 5876
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<string> DiscriminatorColumns;

		// Token: 0x040016F5 RID: 5877
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping> NormalizedEntityTypeMappings;

		// Token: 0x040016F6 RID: 5878
		internal readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping> ReturnTypeColumnsRenameMapping;
	}
}
