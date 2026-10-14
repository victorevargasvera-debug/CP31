using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Xml;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000539 RID: 1337
	internal class FunctionImportMappingComposableHelper
	{
		// Token: 0x060041E6 RID: 16870 RVA: 0x000DDBBC File Offset: 0x000DBDBC
		internal FunctionImportMappingComposableHelper(global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping, string sourceLocation, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> parsingErrors)
		{
			this._entityContainerMapping = entityContainerMapping;
			this.m_sourceLocation = sourceLocation;
			this.m_parsingErrors = parsingErrors;
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x000DDBDC File Offset: 0x000DBDDC
		internal bool TryCreateFunctionImportMappingComposableWithStructuralResult(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction cTypeTargetFunction, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping> typeMappings, global::System.Data.Entity.Core.Metadata.Edm.RowType cTypeTvfElementType, global::System.Data.Entity.Core.Metadata.Edm.RowType sTypeTvfElementType, global::System.Xml.IXmlLineInfo lineInfo, out global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable mapping)
		{
			mapping = null;
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType;
			if (typeMappings.Count == 0 && global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>(functionImport, 0, out structuralType))
			{
				if (structuralType.Abstract)
				{
					global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ImplicitMappingForAbstractReturnType), structuralType.FullName, functionImport.Identity, global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingOfAbstractType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
					return false;
				}
				if (structuralType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
				{
					typeMappings.Add(new global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping(global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(), new global::System.Data.Entity.Core.Metadata.Edm.EntityType[]
					{
						(global::System.Data.Entity.Core.Metadata.Edm.EntityType)structuralType
					}, global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition>(), new global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>(), new global::System.Data.Entity.Core.Mapping.LineInfo(lineInfo)));
				}
				else
				{
					typeMappings.Add(new global::System.Data.Entity.Core.Mapping.FunctionImportComplexTypeMapping((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)structuralType, new global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>(), new global::System.Data.Entity.Core.Mapping.LineInfo(lineInfo)));
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection = (this._entityContainerMapping.StorageMappingItemCollection != null) ? this._entityContainerMapping.StorageMappingItemCollection.EdmItemCollection : new global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection(new global::System.Data.Entity.Core.Metadata.Edm.EdmModel(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, 3.0));
			global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB functionImportStructuralTypeMappingKB = new global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB(typeMappings, itemCollection);
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>>> list = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>>>();
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] targetFunctionKeys = null;
			global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType;
			if (functionImportStructuralTypeMappingKB.MappedEntityTypes.Count > 0)
			{
				if (!functionImportStructuralTypeMappingKB.ValidateTypeConditions(true, this.m_parsingErrors, this.m_sourceLocation))
				{
					return false;
				}
				for (int i = 0; i < functionImportStructuralTypeMappingKB.MappedEntityTypes.Count; i++)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> item;
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping> item2;
					if (this.TryConvertToEntityTypeConditionsAndPropertyMappings(functionImport, functionImportStructuralTypeMappingKB, i, cTypeTvfElementType, sTypeTvfElementType, lineInfo, out item, out item2))
					{
						list.Add(global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>>(functionImportStructuralTypeMappingKB.MappedEntityTypes[i], item, item2));
					}
				}
				if (list.Count < functionImportStructuralTypeMappingKB.MappedEntityTypes.Count)
				{
					return false;
				}
				if (!global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.TryInferTVFKeys(list, out targetFunctionKeys))
				{
					global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_CannotInferTargetFunctionKeys), functionImport.Identity, global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportCannotInferTargetFunctionKeys, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
					return false;
				}
			}
			else if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(functionImport, 0, out complexType))
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping> item3;
				if (!this.TryConvertToPropertyMappings(complexType, cTypeTvfElementType, sTypeTvfElementType, functionImport, functionImportStructuralTypeMappingKB, lineInfo, out item3))
				{
					return false;
				}
				list.Add(global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>>(complexType, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(), item3));
			}
			mapping = new global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable(functionImport, cTypeTargetFunction, list, targetFunctionKeys, this._entityContainerMapping);
			return true;
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x000DDDEC File Offset: 0x000DBFEC
		internal bool TryCreateFunctionImportMappingComposableWithScalarResult(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction cTypeTargetFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction sTypeTargetFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmType scalarResultType, global::System.Data.Entity.Core.Metadata.Edm.RowType cTypeTvfElementType, global::System.Xml.IXmlLineInfo lineInfo, out global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable mapping)
		{
			mapping = null;
			if (cTypeTvfElementType.Properties.Count > 1)
			{
				global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ScalarMappingToMulticolumnTVF(functionImport.Identity, sTypeTargetFunction.Identity), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportScalarMappingToMulticolumnTVF, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return false;
			}
			if (!global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.ValidateFunctionImportMappingResultTypeCompatibility(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(scalarResultType), cTypeTvfElementType.Properties[0].TypeUsage))
			{
				global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ScalarMappingTypeMismatch(functionImport.ReturnParameter.TypeUsage.EdmType.FullName, functionImport.Identity, sTypeTargetFunction.ReturnParameter.TypeUsage.EdmType.FullName, sTypeTargetFunction.Identity), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportScalarMappingTypeMismatch, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return false;
			}
			mapping = new global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable(functionImport, cTypeTargetFunction, null, null, this._entityContainerMapping);
			return true;
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x000DDEC0 File Offset: 0x000DC0C0
		private bool TryConvertToEntityTypeConditionsAndPropertyMappings(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB functionImportKB, int typeID, global::System.Data.Entity.Core.Metadata.Edm.RowType cTypeTvfElementType, global::System.Data.Entity.Core.Metadata.Edm.RowType sTypeTvfElementType, global::System.Xml.IXmlLineInfo navLineInfo, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> typeConditions, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping> propertyMappings)
		{
			global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.<>c__DisplayClass6_0 CS$<>8__locals1 = new global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.<>c__DisplayClass6_0();
			CS$<>8__locals1.typeID = typeID;
			CS$<>8__locals1.<>4__this = this;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType structuralType = functionImportKB.MappedEntityTypes[CS$<>8__locals1.typeID];
			typeConditions = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>();
			bool flag = false;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping> normalizedEntityTypeMappings = functionImportKB.NormalizedEntityTypeMappings;
			global::System.Func<global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping, bool> predicate;
			if ((predicate = CS$<>8__locals1.<>9__0) == null)
			{
				predicate = (CS$<>8__locals1.<>9__0 = ((global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping f) => f.ImpliedEntityTypes[CS$<>8__locals1.typeID]));
			}
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping functionImportNormalizedEntityTypeMapping in normalizedEntityTypeMappings.Where(predicate))
			{
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> enumerator2 = (from c in functionImportNormalizedEntityTypeMapping.ColumnConditions
				where c != null
				select c).GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.<>c__DisplayClass6_1 CS$<>8__locals2 = new global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.<>c__DisplayClass6_1();
						CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
						CS$<>8__locals2.condition = enumerator2.Current;
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column;
						if (sTypeTvfElementType.Properties.TryGetValue(CS$<>8__locals2.condition.ColumnName, false, out column))
						{
							object obj;
							bool? flag2;
							if (CS$<>8__locals2.condition.ConditionValue.IsSentinel)
							{
								obj = null;
								if (CS$<>8__locals2.condition.ConditionValue == global::System.Data.Entity.Core.Mapping.ValueCondition.IsNull)
								{
									flag2 = new bool?(true);
								}
								else
								{
									flag2 = new bool?(false);
								}
							}
							else
							{
								global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)cTypeTvfElementType.Properties[column.Name].TypeUsage.EdmType;
								obj = ((global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingConditionValue)CS$<>8__locals2.condition).GetConditionValue(primitiveType.ClrEquivalentType, delegate()
								{
									global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ConditionMapping_InvalidPrimitiveTypeKind), column.Name, column.TypeUsage.EdmType.FullName, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, CS$<>8__locals2.CS$<>8__locals1.<>4__this.m_sourceLocation, CS$<>8__locals2.condition.LineInfo, CS$<>8__locals2.CS$<>8__locals1.<>4__this.m_parsingErrors);
								}, delegate()
								{
									global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_ConditionValueTypeMismatch, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, CS$<>8__locals2.CS$<>8__locals1.<>4__this.m_sourceLocation, CS$<>8__locals2.condition.LineInfo, CS$<>8__locals2.CS$<>8__locals1.<>4__this.m_parsingErrors);
								});
								if (obj == null)
								{
									flag = true;
									continue;
								}
								flag2 = null;
							}
							typeConditions.Add((obj != null) ? new global::System.Data.Entity.Core.Mapping.ValueConditionMapping(column, obj) : new global::System.Data.Entity.Core.Mapping.IsNullConditionMapping(column, flag2.Value));
						}
						else
						{
							global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Column), CS$<>8__locals2.condition.ColumnName, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidStorageMember, this.m_sourceLocation, CS$<>8__locals2.condition.LineInfo, this.m_parsingErrors);
						}
					}
				}
			}
			flag |= !this.TryConvertToPropertyMappings(structuralType, cTypeTvfElementType, sTypeTvfElementType, functionImport, functionImportKB, navLineInfo, out propertyMappings);
			return !flag;
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x000DE17C File Offset: 0x000DC37C
		private bool TryConvertToPropertyMappings(global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType, global::System.Data.Entity.Core.Metadata.Edm.RowType cTypeTvfElementType, global::System.Data.Entity.Core.Metadata.Edm.RowType sTypeTvfElementType, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB functionImportKB, global::System.Xml.IXmlLineInfo navLineInfo, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping> propertyMappings)
		{
			propertyMappings = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>();
			bool flag = false;
			foreach (object obj in global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(structuralType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)obj;
				if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsScalarType(edmProperty.TypeUsage.EdmType))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_Invalid_CSide_ScalarProperty(edmProperty.Name), 2085, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this.m_sourceLocation, navLineInfo.LineNumber, navLineInfo.LinePosition);
					this.m_parsingErrors.Add(item);
					flag = true;
				}
				else
				{
					global::System.Xml.IXmlLineInfo xmlLineInfo = null;
					global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping functionImportReturnTypeStructuralTypeColumnRenameMapping;
					bool flag2;
					string text;
					if (functionImportKB.ReturnTypeColumnsRenameMapping.TryGetValue(edmProperty.Name, out functionImportReturnTypeStructuralTypeColumnRenameMapping))
					{
						flag2 = true;
						text = functionImportReturnTypeStructuralTypeColumnRenameMapping.GetRename(structuralType, out xmlLineInfo);
					}
					else
					{
						flag2 = false;
						text = edmProperty.Name;
					}
					xmlLineInfo = ((xmlLineInfo != null && xmlLineInfo.HasLineInfo()) ? xmlLineInfo : navLineInfo);
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2;
					if (sTypeTvfElementType.Properties.TryGetValue(text, false, out edmProperty2))
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty3 = cTypeTvfElementType.Properties[text];
						if (global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.ValidateFunctionImportMappingResultTypeCompatibility(edmProperty.TypeUsage, edmProperty3.TypeUsage))
						{
							propertyMappings.Add(new global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping(edmProperty, edmProperty2));
						}
						else
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item2 = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.GetInvalidMemberMappingErrorMessage(edmProperty, edmProperty2), 2019, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this.m_sourceLocation, xmlLineInfo.LineNumber, xmlLineInfo.LinePosition);
							this.m_parsingErrors.Add(item2);
							flag = true;
						}
					}
					else if (flag2)
					{
						global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Column), text, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidStorageMember, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
						flag = true;
					}
					else
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item3 = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_PropertyNotMapped(edmProperty.Name, structuralType.FullName, functionImport.Identity), 2104, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this.m_sourceLocation, xmlLineInfo.LineNumber, xmlLineInfo.LinePosition);
						this.m_parsingErrors.Add(item3);
						flag = true;
					}
				}
			}
			return !flag;
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x000DE384 File Offset: 0x000DC584
		private static bool TryInferTVFKeys(global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>>> structuralTypeMappings, out global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] keys)
		{
			keys = null;
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>> tuple in structuralTypeMappings)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] array;
				if (!global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.TryInferTVFKeysForEntityType((global::System.Data.Entity.Core.Metadata.Edm.EntityType)tuple.Item1, tuple.Item3, out array))
				{
					keys = null;
					return false;
				}
				if (keys == null)
				{
					keys = array;
				}
				else
				{
					for (int i = 0; i < keys.Length; i++)
					{
						if (!keys[i].EdmEquals(array[i]))
						{
							keys = null;
							return false;
						}
					}
				}
			}
			for (int j = 0; j < keys.Length; j++)
			{
				if (keys[j].Nullable)
				{
					keys = null;
					return false;
				}
			}
			return true;
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x000DE44C File Offset: 0x000DC64C
		private static bool TryInferTVFKeysForEntityType(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping> propertyMappings, out global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] keys)
		{
			keys = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[entityType.KeyMembers.Count];
			for (int i = 0; i < keys.Length; i++)
			{
				global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = propertyMappings[entityType.Properties.IndexOf((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)entityType.KeyMembers[i])] as global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping;
				if (scalarPropertyMapping == null)
				{
					keys = null;
					return false;
				}
				keys[i] = scalarPropertyMapping.Column;
			}
			return true;
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x000DE4B8 File Offset: 0x000DC6B8
		private static bool ValidateFunctionImportMappingResultTypeCompatibility(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage cSpaceMemberType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage sSpaceMemberType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper.ResolveTypeUsageForEnums(cSpaceMemberType);
			bool flag = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(sSpaceMemberType, typeUsage);
			bool flag2 = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(typeUsage, sSpaceMemberType);
			return flag || flag2;
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x000DE4DF File Offset: 0x000DC6DF
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ResolveTypeUsageForEnums(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			return global::System.Data.Entity.Core.Mapping.MappingItemLoader.ResolveTypeUsageForEnums(typeUsage);
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x000DE4E7 File Offset: 0x000DC6E7
		private static void AddToSchemaErrors(string message, global::System.Data.Entity.Core.Mapping.MappingErrorCode errorCode, string location, global::System.Xml.IXmlLineInfo lineInfo, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> parsingErrors)
		{
			global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(message, errorCode, location, lineInfo, parsingErrors);
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x000DE4F4 File Offset: 0x000DC6F4
		private static void AddToSchemaErrorsWithMemberInfo(global::System.Func<object, string> messageFormat, string errorMember, global::System.Data.Entity.Core.Mapping.MappingErrorCode errorCode, string location, global::System.Xml.IXmlLineInfo lineInfo, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> parsingErrors)
		{
			global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(messageFormat, errorMember, errorCode, location, lineInfo, parsingErrors);
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x000DE504 File Offset: 0x000DC704
		private static void AddToSchemaErrorWithMemberAndStructure(global::System.Func<object, object, string> messageFormat, string errorMember, string errorStructure, global::System.Data.Entity.Core.Mapping.MappingErrorCode errorCode, string location, global::System.Xml.IXmlLineInfo lineInfo, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> parsingErrors)
		{
			global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(messageFormat, errorMember, errorStructure, errorCode, location, lineInfo, parsingErrors);
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x000DE515 File Offset: 0x000DC715
		private static string GetInvalidMemberMappingErrorMessage(global::System.Data.Entity.Core.Metadata.Edm.EdmMember cSpaceMember, global::System.Data.Entity.Core.Metadata.Edm.EdmMember sSpaceMember)
		{
			return global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetInvalidMemberMappingErrorMessage(cSpaceMember, sSpaceMember);
		}

		// Token: 0x040016D8 RID: 5848
		private readonly global::System.Data.Entity.Core.Mapping.EntityContainerMapping _entityContainerMapping;

		// Token: 0x040016D9 RID: 5849
		private readonly string m_sourceLocation;

		// Token: 0x040016DA RID: 5850
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> m_parsingErrors;
	}
}
