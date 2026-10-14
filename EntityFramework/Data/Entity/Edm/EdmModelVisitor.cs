using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.Edm
{
	// Token: 0x020002CA RID: 714
	internal abstract class EdmModelVisitor
	{
		// Token: 0x0600225A RID: 8794 RVA: 0x000602A0 File Offset: 0x0005E4A0
		protected static void VisitCollection<T>(global::System.Collections.Generic.IEnumerable<T> collection, global::System.Action<T> visitMethod)
		{
			if (collection != null)
			{
				foreach (T obj in collection)
				{
					visitMethod(obj);
				}
			}
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x000602EC File Offset: 0x0005E4EC
		protected internal virtual void VisitEdmModel(global::System.Data.Entity.Core.Metadata.Edm.EdmModel item)
		{
			if (item != null)
			{
				this.VisitComplexTypes(item.ComplexTypes);
				this.VisitEntityTypes(item.EntityTypes);
				this.VisitEnumTypes(item.EnumTypes);
				this.VisitAssociationTypes(item.AssociationTypes);
				this.VisitFunctions(item.Functions);
				this.VisitEntityContainers(item.Containers);
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00060344 File Offset: 0x0005E544
		protected virtual void VisitAnnotations(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> annotations)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty>(annotations, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty>(this.VisitAnnotation));
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00060359 File Offset: 0x0005E559
		protected virtual void VisitAnnotation(global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty item)
		{
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0006035B File Offset: 0x0005E55B
		protected internal virtual void VisitMetadataItem(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			if (item != null && item.Annotations.Any<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty>())
			{
				this.VisitAnnotations(item, item.Annotations);
			}
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x0006037A File Offset: 0x0005E57A
		protected virtual void VisitEntityContainers(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> entityContainers)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(entityContainers, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(this.VisitEdmEntityContainer));
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00060390 File Offset: 0x0005E590
		protected virtual void VisitEdmEntityContainer(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer item)
		{
			this.VisitMetadataItem(item);
			if (item != null)
			{
				if (item.EntitySets.Count > 0)
				{
					this.VisitEntitySets(item, item.EntitySets);
				}
				if (item.AssociationSets.Count > 0)
				{
					this.VisitAssociationSets(item, item.AssociationSets);
				}
				if (item.FunctionImports.Count > 0)
				{
					this.VisitFunctionImports(item, item.FunctionImports);
				}
			}
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x000603F8 File Offset: 0x0005E5F8
		protected internal virtual void VisitEdmFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			this.VisitMetadataItem(function);
			if (function != null)
			{
				if (function.Parameters != null)
				{
					this.VisitFunctionParameters(function.Parameters);
				}
				if (function.ReturnParameters != null)
				{
					this.VisitFunctionReturnParameters(function.ReturnParameters);
				}
			}
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x0006042C File Offset: 0x0005E62C
		protected virtual void VisitEntitySets(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySets, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(this.VisitEdmEntitySet));
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00060441 File Offset: 0x0005E641
		protected internal virtual void VisitEdmEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySet item)
		{
			this.VisitMetadataItem(item);
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0006044A File Offset: 0x0005E64A
		protected virtual void VisitAssociationSets(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> associationSets)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(associationSets, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(this.VisitEdmAssociationSet));
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0006045F File Offset: 0x0005E65F
		protected virtual void VisitEdmAssociationSet(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet item)
		{
			this.VisitMetadataItem(item);
			if (item.SourceSet != null)
			{
				this.VisitEdmAssociationSetEnd(item.SourceSet);
			}
			if (item.TargetSet != null)
			{
				this.VisitEdmAssociationSetEnd(item.TargetSet);
			}
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00060490 File Offset: 0x0005E690
		protected virtual void VisitEdmAssociationSetEnd(global::System.Data.Entity.Core.Metadata.Edm.EntitySet item)
		{
			this.VisitMetadataItem(item);
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00060499 File Offset: 0x0005E699
		protected internal virtual void VisitFunctionImports(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionImports)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(functionImports, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(this.VisitFunctionImport));
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x000604AE File Offset: 0x0005E6AE
		protected internal virtual void VisitFunctionImport(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport)
		{
			this.VisitMetadataItem(functionImport);
			if (functionImport.Parameters != null)
			{
				this.VisitFunctionImportParameters(functionImport.Parameters);
			}
			if (functionImport.ReturnParameters != null)
			{
				this.VisitFunctionImportReturnParameters(functionImport.ReturnParameters);
			}
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x000604DF File Offset: 0x0005E6DF
		protected internal virtual void VisitFunctionImportParameters(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> parameters)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(parameters, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(this.VisitFunctionImportParameter));
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x000604F4 File Offset: 0x0005E6F4
		protected internal virtual void VisitFunctionImportParameter(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter parameter)
		{
			this.VisitMetadataItem(parameter);
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x000604FD File Offset: 0x0005E6FD
		protected internal virtual void VisitFunctionImportReturnParameters(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> parameters)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(parameters, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(this.VisitFunctionImportReturnParameter));
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x00060512 File Offset: 0x0005E712
		protected internal virtual void VisitFunctionImportReturnParameter(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter parameter)
		{
			this.VisitMetadataItem(parameter);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0006051B File Offset: 0x0005E71B
		protected virtual void VisitComplexTypes(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> complexTypes)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(complexTypes, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(this.VisitComplexType));
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00060530 File Offset: 0x0005E730
		protected virtual void VisitComplexType(global::System.Data.Entity.Core.Metadata.Edm.ComplexType item)
		{
			this.VisitMetadataItem(item);
			if (item.Properties.Count > 0)
			{
				global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(item.Properties, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(this.VisitEdmProperty));
			}
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x0006055F File Offset: 0x0005E75F
		protected virtual void VisitDeclaredProperties(global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(properties, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(this.VisitEdmProperty));
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00060574 File Offset: 0x0005E774
		protected virtual void VisitEntityTypes(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> entityTypes)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityTypes, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(this.VisitEdmEntityType));
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00060589 File Offset: 0x0005E789
		protected virtual void VisitEnumTypes(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EnumType> enumTypes)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EnumType>(enumTypes, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EnumType>(this.VisitEdmEnumType));
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x0006059E File Offset: 0x0005E79E
		protected internal virtual void VisitFunctions(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functions)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(functions, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(this.VisitEdmFunction));
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x000605B3 File Offset: 0x0005E7B3
		protected virtual void VisitFunctionParameters(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> parameters)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(parameters, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(this.VisitFunctionParameter));
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x000605C8 File Offset: 0x0005E7C8
		protected internal virtual void VisitFunctionParameter(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter)
		{
			this.VisitMetadataItem(functionParameter);
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x000605D1 File Offset: 0x0005E7D1
		protected internal virtual void VisitFunctionReturnParameters(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> returnParameters)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(returnParameters, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(this.VisitFunctionReturnParameter));
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000605E6 File Offset: 0x0005E7E6
		protected internal virtual void VisitFunctionReturnParameter(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter returnParameter)
		{
			this.VisitMetadataItem(returnParameter);
			this.VisitEdmType(returnParameter.TypeUsage.EdmType);
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x00060600 File Offset: 0x0005E800
		protected internal virtual void VisitEdmType(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = edmType.BuiltInTypeKind;
			if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
			{
				this.VisitCollectionType((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)edmType);
				return;
			}
			if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
			{
				this.VisitPrimitiveType((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)edmType);
				return;
			}
			if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
			{
				return;
			}
			this.VisitRowType((global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType);
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00060649 File Offset: 0x0005E849
		protected internal virtual void VisitCollectionType(global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType)
		{
			this.VisitMetadataItem(collectionType);
			this.VisitEdmType(collectionType.TypeUsage.EdmType);
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00060663 File Offset: 0x0005E863
		protected internal virtual void VisitRowType(global::System.Data.Entity.Core.Metadata.Edm.RowType rowType)
		{
			this.VisitMetadataItem(rowType);
			if (rowType.DeclaredProperties.Count > 0)
			{
				global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(rowType.DeclaredProperties, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(this.VisitEdmProperty));
			}
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00060692 File Offset: 0x0005E892
		protected internal virtual void VisitPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
			this.VisitMetadataItem(primitiveType);
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x0006069B File Offset: 0x0005E89B
		protected virtual void VisitEdmEnumType(global::System.Data.Entity.Core.Metadata.Edm.EnumType item)
		{
			this.VisitMetadataItem(item);
			if (item != null && item.Members.Count > 0)
			{
				this.VisitEnumMembers(item, item.Members);
			}
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x000606C2 File Offset: 0x0005E8C2
		protected virtual void VisitEnumMembers(global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EnumMember> members)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EnumMember>(members, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EnumMember>(this.VisitEdmEnumTypeMember));
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x000606D8 File Offset: 0x0005E8D8
		protected internal virtual void VisitEdmEntityType(global::System.Data.Entity.Core.Metadata.Edm.EntityType item)
		{
			this.VisitMetadataItem(item);
			if (item != null)
			{
				if (item.BaseType == null && item.KeyProperties.Count > 0)
				{
					this.VisitKeyProperties(item, item.KeyProperties);
				}
				if (item.DeclaredProperties.Count > 0)
				{
					this.VisitDeclaredProperties(item, item.DeclaredProperties);
				}
				if (item.DeclaredNavigationProperties.Count > 0)
				{
					this.VisitDeclaredNavigationProperties(item, item.DeclaredNavigationProperties);
				}
			}
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00060748 File Offset: 0x0005E948
		protected virtual void VisitKeyProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(properties, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(this.VisitEdmProperty));
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x0006075D File Offset: 0x0005E95D
		protected virtual void VisitDeclaredProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(properties, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(this.VisitEdmProperty));
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00060772 File Offset: 0x0005E972
		protected virtual void VisitDeclaredNavigationProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> navigationProperties)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(navigationProperties, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(this.VisitEdmNavigationProperty));
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00060787 File Offset: 0x0005E987
		protected virtual void VisitAssociationTypes(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> associationTypes)
		{
			global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(associationTypes, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(this.VisitEdmAssociationType));
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x0006079C File Offset: 0x0005E99C
		protected internal virtual void VisitEdmAssociationType(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item)
		{
			this.VisitMetadataItem(item);
			if (item != null)
			{
				if (item.SourceEnd != null)
				{
					this.VisitEdmAssociationEnd(item.SourceEnd);
				}
				if (item.TargetEnd != null)
				{
					this.VisitEdmAssociationEnd(item.TargetEnd);
				}
			}
			if (item.Constraint != null)
			{
				this.VisitEdmAssociationConstraint(item.Constraint);
			}
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x000607EF File Offset: 0x0005E9EF
		protected internal virtual void VisitEdmProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty item)
		{
			this.VisitMetadataItem(item);
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x000607F8 File Offset: 0x0005E9F8
		protected virtual void VisitEdmEnumTypeMember(global::System.Data.Entity.Core.Metadata.Edm.EnumMember item)
		{
			this.VisitMetadataItem(item);
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x00060801 File Offset: 0x0005EA01
		protected virtual void VisitEdmAssociationEnd(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember item)
		{
			this.VisitMetadataItem(item);
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x0006080A File Offset: 0x0005EA0A
		protected virtual void VisitEdmAssociationConstraint(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint item)
		{
			if (item != null)
			{
				this.VisitMetadataItem(item);
				if (item.ToRole != null)
				{
					this.VisitEdmAssociationEnd(item.ToRole);
				}
				global::System.Data.Entity.Edm.EdmModelVisitor.VisitCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(item.ToProperties, new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(this.VisitEdmProperty));
			}
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x00060842 File Offset: 0x0005EA42
		protected virtual void VisitEdmNavigationProperty(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty item)
		{
			this.VisitMetadataItem(item);
		}
	}
}
