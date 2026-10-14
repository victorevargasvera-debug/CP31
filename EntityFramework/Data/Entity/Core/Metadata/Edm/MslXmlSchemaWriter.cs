using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004E4 RID: 1252
	internal class MslXmlSchemaWriter : global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter
	{
		// Token: 0x06003E65 RID: 15973 RVA: 0x000CE550 File Offset: 0x000CC750
		internal MslXmlSchemaWriter(global::System.Xml.XmlWriter xmlWriter, double version)
		{
			this._xmlWriter = xmlWriter;
			this._version = version;
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x000CE566 File Offset: 0x000CC766
		internal void WriteSchema(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			this.WriteSchemaElementHeader();
			this.WriteDbModelElement(databaseMapping);
			this.WriteEndElement();
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x000CE57C File Offset: 0x000CC77C
		private void WriteSchemaElementHeader()
		{
			string mslNamespace = global::System.Data.Entity.Core.Mapping.MslConstructs.GetMslNamespace(this._version);
			this._xmlWriter.WriteStartElement("Mapping", mslNamespace);
			this._xmlWriter.WriteAttributeString("Space", "C-S");
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x000CE5BC File Offset: 0x000CC7BC
		private void WriteDbModelElement(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			this._entityTypeNamespace = databaseMapping.Model.NamespaceNames.SingleOrDefault<string>();
			this._dbSchemaName = databaseMapping.Database.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().Name;
			this.WriteEntityContainerMappingElement(databaseMapping.EntityContainerMappings.First<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>());
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x000CE60C File Offset: 0x000CC80C
		internal void WriteEntityContainerMappingElement(global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping)
		{
			this._xmlWriter.WriteStartElement("EntityContainerMapping");
			this._xmlWriter.WriteAttributeString("StorageEntityContainer", this._dbSchemaName);
			this._xmlWriter.WriteAttributeString("CdmEntityContainer", containerMapping.EdmEntityContainer.Name);
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping in containerMapping.EntitySetMappings)
			{
				this.WriteEntitySetMappingElement(entitySetMapping);
			}
			foreach (global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping in containerMapping.AssociationSetMappings)
			{
				this.WriteAssociationSetMappingElement(associationSetMapping);
			}
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable functionImportMapping in containerMapping.FunctionImportMappings.OfType<global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable>())
			{
				this.WriteFunctionImportMappingElement(functionImportMapping);
			}
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable functionImportMapping2 in containerMapping.FunctionImportMappings.OfType<global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable>())
			{
				this.WriteFunctionImportMappingElement(functionImportMapping2);
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x000CE774 File Offset: 0x000CC974
		public void WriteEntitySetMappingElement(global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping)
		{
			this._xmlWriter.WriteStartElement("EntitySetMapping");
			this._xmlWriter.WriteAttributeString("Name", entitySetMapping.EntitySet.Name);
			foreach (global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping in entitySetMapping.EntityTypeMappings)
			{
				this.WriteEntityTypeMappingElement(entityTypeMapping);
			}
			foreach (global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeModificationFunctionMapping in entitySetMapping.ModificationFunctionMappings)
			{
				this._xmlWriter.WriteStartElement("EntityTypeMapping");
				this._xmlWriter.WriteAttributeString("TypeName", global::System.Data.Entity.Core.Metadata.Edm.MslXmlSchemaWriter.GetEntityTypeName(this._entityTypeNamespace + "." + entityTypeModificationFunctionMapping.EntityType.Name, false));
				this.WriteModificationFunctionMapping(entityTypeModificationFunctionMapping);
				this._xmlWriter.WriteEndElement();
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x000CE880 File Offset: 0x000CCA80
		public void WriteAssociationSetMappingElement(global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping)
		{
			this._xmlWriter.WriteStartElement("AssociationSetMapping");
			this._xmlWriter.WriteAttributeString("Name", associationSetMapping.AssociationSet.Name);
			this._xmlWriter.WriteAttributeString("TypeName", this._entityTypeNamespace + "." + associationSetMapping.AssociationSet.ElementType.Name);
			this._xmlWriter.WriteAttributeString("StoreEntitySet", associationSetMapping.Table.Name);
			this.WriteAssociationEndMappingElement(associationSetMapping.SourceEndMapping);
			this.WriteAssociationEndMappingElement(associationSetMapping.TargetEndMapping);
			if (associationSetMapping.ModificationFunctionMapping != null)
			{
				this.WriteModificationFunctionMapping(associationSetMapping.ModificationFunctionMapping);
			}
			foreach (global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition in associationSetMapping.Conditions)
			{
				this.WriteConditionElement(condition);
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x000CE97C File Offset: 0x000CCB7C
		private void WriteAssociationEndMappingElement(global::System.Data.Entity.Core.Mapping.EndPropertyMapping endMapping)
		{
			this._xmlWriter.WriteStartElement("EndProperty");
			this._xmlWriter.WriteAttributeString("Name", endMapping.AssociationEnd.Name);
			foreach (global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping in endMapping.PropertyMappings)
			{
				this.WriteScalarPropertyElement(scalarPropertyMapping.Property.Name, scalarPropertyMapping.Column.Name);
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x000CEA14 File Offset: 0x000CCC14
		private void WriteEntityTypeMappingElement(global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping)
		{
			this._xmlWriter.WriteStartElement("EntityTypeMapping");
			this._xmlWriter.WriteAttributeString("TypeName", global::System.Data.Entity.Core.Metadata.Edm.MslXmlSchemaWriter.GetEntityTypeName(this._entityTypeNamespace + "." + entityTypeMapping.EntityType.Name, entityTypeMapping.IsHierarchyMapping));
			foreach (global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment in entityTypeMapping.MappingFragments)
			{
				this.WriteMappingFragmentElement(mappingFragment);
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x000CEAB4 File Offset: 0x000CCCB4
		internal void WriteMappingFragmentElement(global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment)
		{
			this._xmlWriter.WriteStartElement("MappingFragment");
			this._xmlWriter.WriteAttributeString("StoreEntitySet", mappingFragment.TableSet.Name);
			foreach (global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping in mappingFragment.PropertyMappings)
			{
				this.WritePropertyMapping(propertyMapping);
			}
			foreach (global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition in mappingFragment.ColumnConditions)
			{
				this.WriteConditionElement(condition);
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x000CEB74 File Offset: 0x000CCD74
		public void WriteFunctionImportMappingElement(global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable functionImportMapping)
		{
			this.WriteFunctionImportMappingStartElement(functionImportMapping);
			if (functionImportMapping.StructuralTypeMappings != null)
			{
				this._xmlWriter.WriteStartElement("ResultMapping");
				global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>> tuple = functionImportMapping.StructuralTypeMappings.Single<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>>>();
				if (tuple.Item1.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
				{
					this._xmlWriter.WriteStartElement("ComplexTypeMapping");
					this._xmlWriter.WriteAttributeString("TypeName", tuple.Item1.FullName);
				}
				else
				{
					this._xmlWriter.WriteStartElement("EntityTypeMapping");
					this._xmlWriter.WriteAttributeString("TypeName", tuple.Item1.FullName);
					foreach (global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition in tuple.Item2)
					{
						this.WriteConditionElement(condition);
					}
				}
				foreach (global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping in tuple.Item3)
				{
					this.WritePropertyMapping(propertyMapping);
				}
				this._xmlWriter.WriteEndElement();
				this._xmlWriter.WriteEndElement();
			}
			this.WriteFunctionImportEndElement();
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x000CECBC File Offset: 0x000CCEBC
		public void WriteFunctionImportMappingElement(global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable functionImportMapping)
		{
			this.WriteFunctionImportMappingStartElement(functionImportMapping);
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping resultMapping in functionImportMapping.ResultMappings)
			{
				this.WriteFunctionImportResultMappingElement(resultMapping);
			}
			this.WriteFunctionImportEndElement();
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x000CED18 File Offset: 0x000CCF18
		private void WriteFunctionImportMappingStartElement(global::System.Data.Entity.Core.Mapping.FunctionImportMapping functionImportMapping)
		{
			this._xmlWriter.WriteStartElement("FunctionImportMapping");
			this._xmlWriter.WriteAttributeString("FunctionName", functionImportMapping.TargetFunction.FullName);
			this._xmlWriter.WriteAttributeString("FunctionImportName", functionImportMapping.FunctionImport.Name);
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x000CED6C File Offset: 0x000CCF6C
		private void WriteFunctionImportResultMappingElement(global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping resultMapping)
		{
			this._xmlWriter.WriteStartElement("ResultMapping");
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping functionImportStructuralTypeMapping in resultMapping.TypeMappings)
			{
				global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping functionImportEntityTypeMapping = functionImportStructuralTypeMapping as global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping;
				if (functionImportEntityTypeMapping != null)
				{
					this.WriteFunctionImportEntityTypeMappingElement(functionImportEntityTypeMapping);
				}
				else
				{
					this.WriteFunctionImportComplexTypeMappingElement((global::System.Data.Entity.Core.Mapping.FunctionImportComplexTypeMapping)functionImportStructuralTypeMapping);
				}
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x000CEDEC File Offset: 0x000CCFEC
		private void WriteFunctionImportEntityTypeMappingElement(global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping entityTypeMapping)
		{
			this._xmlWriter.WriteStartElement("EntityTypeMapping");
			string value = global::System.Data.Entity.Core.Metadata.Edm.MslXmlSchemaWriter.CreateFunctionImportEntityTypeMappingTypeName(entityTypeMapping);
			this._xmlWriter.WriteAttributeString("TypeName", value);
			this.WriteFunctionImportPropertyMappingElements(entityTypeMapping.PropertyMappings.Cast<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeScalarPropertyMapping>());
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition condition in entityTypeMapping.Conditions)
			{
				this.WriteFunctionImportConditionElement(condition);
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x000CEE80 File Offset: 0x000CD080
		internal static string CreateFunctionImportEntityTypeMappingTypeName(global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping entityTypeMapping)
		{
			return string.Join(";", (from e in entityTypeMapping.EntityTypes
			select global::System.Data.Entity.Core.Metadata.Edm.MslXmlSchemaWriter.GetEntityTypeName(e.FullName, false)).Concat(from e in entityTypeMapping.IsOfTypeEntityTypes
			select global::System.Data.Entity.Core.Metadata.Edm.MslXmlSchemaWriter.GetEntityTypeName(e.FullName, true)));
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x000CEEF0 File Offset: 0x000CD0F0
		private void WriteFunctionImportComplexTypeMappingElement(global::System.Data.Entity.Core.Mapping.FunctionImportComplexTypeMapping complexTypeMapping)
		{
			this._xmlWriter.WriteStartElement("ComplexTypeMapping");
			this._xmlWriter.WriteAttributeString("TypeName", complexTypeMapping.ReturnType.FullName);
			this.WriteFunctionImportPropertyMappingElements(complexTypeMapping.PropertyMappings.Cast<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeScalarPropertyMapping>());
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x000CEF44 File Offset: 0x000CD144
		private void WriteFunctionImportPropertyMappingElements(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeScalarPropertyMapping> propertyMappings)
		{
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeScalarPropertyMapping functionImportReturnTypeScalarPropertyMapping in propertyMappings)
			{
				this.WriteScalarPropertyElement(functionImportReturnTypeScalarPropertyMapping.PropertyName, functionImportReturnTypeScalarPropertyMapping.ColumnName);
			}
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x000CEF98 File Offset: 0x000CD198
		private void WriteFunctionImportConditionElement(global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition condition)
		{
			this._xmlWriter.WriteStartElement("Condition");
			this._xmlWriter.WriteAttributeString("ColumnName", condition.ColumnName);
			global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingConditionIsNull functionImportEntityTypeMappingConditionIsNull = condition as global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingConditionIsNull;
			if (functionImportEntityTypeMappingConditionIsNull != null)
			{
				this.WriteIsNullConditionAttribute(functionImportEntityTypeMappingConditionIsNull.IsNull);
			}
			else
			{
				this.WriteConditionValue(((global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingConditionValue)condition).Value);
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x000CEFFF File Offset: 0x000CD1FF
		private void WriteFunctionImportEndElement()
		{
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x000CF00C File Offset: 0x000CD20C
		private void WriteModificationFunctionMapping(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationFunctionMapping)
		{
			this._xmlWriter.WriteStartElement("ModificationFunctionMapping");
			this.WriteFunctionMapping("InsertFunction", modificationFunctionMapping.InsertFunctionMapping, false);
			this.WriteFunctionMapping("UpdateFunction", modificationFunctionMapping.UpdateFunctionMapping, false);
			this.WriteFunctionMapping("DeleteFunction", modificationFunctionMapping.DeleteFunctionMapping, false);
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x000CF06C File Offset: 0x000CD26C
		private void WriteModificationFunctionMapping(global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping modificationFunctionMapping)
		{
			this._xmlWriter.WriteStartElement("ModificationFunctionMapping");
			this.WriteFunctionMapping("InsertFunction", modificationFunctionMapping.InsertFunctionMapping, true);
			this.WriteFunctionMapping("DeleteFunction", modificationFunctionMapping.DeleteFunctionMapping, true);
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x000CF0B8 File Offset: 0x000CD2B8
		public void WriteFunctionMapping(string functionElement, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping functionMapping, bool associationSetMapping = false)
		{
			this._xmlWriter.WriteStartElement(functionElement);
			this._xmlWriter.WriteAttributeString("FunctionName", functionMapping.Function.FullName);
			if (functionMapping.RowsAffectedParameter != null)
			{
				this._xmlWriter.WriteAttributeString("RowsAffectedParameter", functionMapping.RowsAffectedParameter.Name);
			}
			if (!associationSetMapping)
			{
				this.WritePropertyParameterBindings(functionMapping.ParameterBindings, 0);
				this.WriteAssociationParameterBindings(functionMapping.ParameterBindings);
				if (functionMapping.ResultBindings != null)
				{
					this.WriteResultBindings(functionMapping.ResultBindings);
				}
			}
			else
			{
				this.WriteAssociationSetMappingParameterBindings(functionMapping.ParameterBindings);
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x000CF158 File Offset: 0x000CD358
		private void WriteAssociationSetMappingParameterBindings(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> parameterBindings)
		{
			foreach (global::System.Linq.IGrouping<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> grouping in from pm in parameterBindings
			where pm.MemberPath.AssociationSetEnd != null
			group pm by pm.MemberPath.AssociationSetEnd)
			{
				this._xmlWriter.WriteStartElement("EndProperty");
				this._xmlWriter.WriteAttributeString("Name", grouping.Key.Name);
				foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding in grouping)
				{
					this.WriteScalarParameterElement(modificationFunctionParameterBinding.MemberPath.Members.First<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(), modificationFunctionParameterBinding);
				}
				this._xmlWriter.WriteEndElement();
			}
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x000CF260 File Offset: 0x000CD460
		private void WritePropertyParameterBindings(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> parameterBindings, int level = 0)
		{
			foreach (global::System.Linq.IGrouping<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> grouping in from pm in parameterBindings
			where pm.MemberPath.AssociationSetEnd == null && pm.MemberPath.Members.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>() > level
			group pm by pm.MemberPath.Members.ElementAt(level))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)grouping.Key;
				if (edmProperty.IsComplexType)
				{
					this._xmlWriter.WriteStartElement("ComplexProperty");
					this._xmlWriter.WriteAttributeString("Name", edmProperty.Name);
					this._xmlWriter.WriteAttributeString("TypeName", this._entityTypeNamespace + "." + edmProperty.ComplexType.Name);
					this.WritePropertyParameterBindings(grouping, level + 1);
					this._xmlWriter.WriteEndElement();
				}
				else
				{
					foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding parameterBinding in grouping)
					{
						this.WriteScalarParameterElement(edmProperty, parameterBinding);
					}
				}
			}
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x000CF398 File Offset: 0x000CD598
		private void WriteAssociationParameterBindings(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> parameterBindings)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Linq.IGrouping<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>> enumerator = (from pm in parameterBindings
			where pm.MemberPath.AssociationSetEnd != null
			group pm by pm.MemberPath.AssociationSetEnd).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Linq.IGrouping<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> group = enumerator.Current;
					this._xmlWriter.WriteStartElement("AssociationEnd");
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSet parentAssociationSet = group.Key.ParentAssociationSet;
					this._xmlWriter.WriteAttributeString("AssociationSet", parentAssociationSet.Name);
					this._xmlWriter.WriteAttributeString("From", group.Key.Name);
					this._xmlWriter.WriteAttributeString("To", parentAssociationSet.AssociationSetEnds.Single((global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd ae) => ae != group.Key).Name);
					foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding in group)
					{
						this.WriteScalarParameterElement(modificationFunctionParameterBinding.MemberPath.Members.First<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(), modificationFunctionParameterBinding);
					}
					this._xmlWriter.WriteEndElement();
				}
			}
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x000CF510 File Offset: 0x000CD710
		private void WriteResultBindings(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> resultBindings)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding modificationFunctionResultBinding in resultBindings)
			{
				this._xmlWriter.WriteStartElement("ResultBinding");
				this._xmlWriter.WriteAttributeString("Name", modificationFunctionResultBinding.Property.Name);
				this._xmlWriter.WriteAttributeString("ColumnName", modificationFunctionResultBinding.ColumnName);
				this._xmlWriter.WriteEndElement();
			}
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x000CF5A0 File Offset: 0x000CD7A0
		private void WriteScalarParameterElement(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding parameterBinding)
		{
			this._xmlWriter.WriteStartElement("ScalarProperty");
			this._xmlWriter.WriteAttributeString("Name", member.Name);
			this._xmlWriter.WriteAttributeString("ParameterName", parameterBinding.Parameter.Name);
			this._xmlWriter.WriteAttributeString("Version", parameterBinding.IsCurrent ? "Current" : "Original");
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x000CF620 File Offset: 0x000CD820
		private void WritePropertyMapping(global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping)
		{
			global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping;
			if (scalarPropertyMapping != null)
			{
				this.WritePropertyMapping(scalarPropertyMapping);
				return;
			}
			global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping;
			if (complexPropertyMapping != null)
			{
				this.WritePropertyMapping(complexPropertyMapping);
			}
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x000CF650 File Offset: 0x000CD850
		private void WritePropertyMapping(global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping)
		{
			this.WriteScalarPropertyElement(scalarPropertyMapping.Property.Name, scalarPropertyMapping.Column.Name);
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x000CF670 File Offset: 0x000CD870
		private void WritePropertyMapping(global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping)
		{
			this._xmlWriter.WriteStartElement("ComplexProperty");
			this._xmlWriter.WriteAttributeString("Name", complexPropertyMapping.Property.Name);
			this._xmlWriter.WriteAttributeString("TypeName", this._entityTypeNamespace + "." + complexPropertyMapping.Property.ComplexType.Name);
			foreach (global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping in complexPropertyMapping.TypeMappings.Single<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping>().PropertyMappings)
			{
				this.WritePropertyMapping(propertyMapping);
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x000CF730 File Offset: 0x000CD930
		private static string GetEntityTypeName(string fullyQualifiedEntityTypeName, bool isHierarchyMapping)
		{
			if (isHierarchyMapping)
			{
				return "IsTypeOf(" + fullyQualifiedEntityTypeName + ")";
			}
			return fullyQualifiedEntityTypeName;
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x000CF748 File Offset: 0x000CD948
		private void WriteConditionElement(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition)
		{
			this._xmlWriter.WriteStartElement("Condition");
			if (condition.IsNull != null)
			{
				this.WriteIsNullConditionAttribute(condition.IsNull.Value);
			}
			else
			{
				this.WriteConditionValue(condition.Value);
			}
			this._xmlWriter.WriteAttributeString("ColumnName", condition.Column.Name);
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x000CF7BD File Offset: 0x000CD9BD
		private void WriteIsNullConditionAttribute(bool isNullValue)
		{
			this._xmlWriter.WriteAttributeString("IsNull", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetLowerCaseStringFromBoolValue(isNullValue));
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x000CF7D8 File Offset: 0x000CD9D8
		private void WriteConditionValue(object conditionValue)
		{
			if (conditionValue is bool)
			{
				this._xmlWriter.WriteAttributeString("Value", ((bool)conditionValue) ? "1" : "0");
				return;
			}
			this._xmlWriter.WriteAttributeString("Value", conditionValue.ToString());
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x000CF828 File Offset: 0x000CDA28
		private void WriteScalarPropertyElement(string propertyName, string columnName)
		{
			this._xmlWriter.WriteStartElement("ScalarProperty");
			this._xmlWriter.WriteAttributeString("Name", propertyName);
			this._xmlWriter.WriteAttributeString("ColumnName", columnName);
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x0400152E RID: 5422
		private string _entityTypeNamespace;

		// Token: 0x0400152F RID: 5423
		private string _dbSchemaName;
	}
}
