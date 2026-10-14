using System;
using System.Collections.Generic;
using System.Data.Entity.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004B4 RID: 1204
	internal sealed class EdmSerializationVisitor : global::System.Data.Entity.Edm.EdmModelVisitor
	{
		// Token: 0x06003B4D RID: 15181 RVA: 0x000C2F83 File Offset: 0x000C1183
		public EdmSerializationVisitor(global::System.Xml.XmlWriter xmlWriter, double edmVersion, bool serializeDefaultNullability = false) : this(new global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter(xmlWriter, edmVersion, serializeDefaultNullability, null))
		{
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x000C2F94 File Offset: 0x000C1194
		public EdmSerializationVisitor(global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter schemaWriter)
		{
			this._schemaWriter = schemaWriter;
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x000C2FA4 File Offset: 0x000C11A4
		public void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmModel edmModel, string modelNamespace)
		{
			string schemaNamespace = modelNamespace ?? edmModel.NamespaceNames.DefaultIfEmpty("Empty").Single<string>();
			this._schemaWriter.WriteSchemaElementHeader(schemaNamespace);
			this.VisitEdmModel(edmModel);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x000C2FEA File Offset: 0x000C11EA
		public void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmModel edmModel, string provider, string providerManifestToken)
		{
			this.Visit(edmModel, edmModel.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().Name + "Schema", provider, providerManifestToken);
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x000C3010 File Offset: 0x000C1210
		public void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmModel edmModel, string namespaceName, string provider, string providerManifestToken)
		{
			bool writeStoreSchemaGenNamespace = edmModel.Container.BaseEntitySets.Any((global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase e) => e.MetadataProperties.Any((global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty p) => p.Name.StartsWith("http://schemas.microsoft.com/ado/2007/12/edm/EntityStoreSchemaGenerator", global::System.StringComparison.Ordinal)));
			this._schemaWriter.WriteSchemaElementHeader(namespaceName, provider, providerManifestToken, writeStoreSchemaGenNamespace);
			this.VisitEdmModel(edmModel);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x000C306F File Offset: 0x000C126F
		protected override void VisitEdmEntityContainer(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer item)
		{
			this._schemaWriter.WriteEntityContainerElementHeader(item);
			base.VisitEdmEntityContainer(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x000C308F File Offset: 0x000C128F
		protected internal override void VisitEdmFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction item)
		{
			this._schemaWriter.WriteFunctionElementHeader(item);
			base.VisitEdmFunction(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x000C30AF File Offset: 0x000C12AF
		protected internal override void VisitFunctionParameter(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter)
		{
			this._schemaWriter.WriteFunctionParameterHeader(functionParameter);
			base.VisitFunctionParameter(functionParameter);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x000C30CF File Offset: 0x000C12CF
		protected internal override void VisitFunctionReturnParameter(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter returnParameter)
		{
			if (returnParameter.TypeUsage.EdmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
			{
				this._schemaWriter.WriteFunctionReturnTypeElementHeader();
				base.VisitFunctionReturnParameter(returnParameter);
				this._schemaWriter.WriteEndElement();
				return;
			}
			base.VisitFunctionReturnParameter(returnParameter);
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x000C310A File Offset: 0x000C130A
		protected internal override void VisitCollectionType(global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType)
		{
			this._schemaWriter.WriteCollectionTypeElementHeader();
			base.VisitCollectionType(collectionType);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x000C312C File Offset: 0x000C132C
		protected override void VisitEdmAssociationSet(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet item)
		{
			this._schemaWriter.WriteAssociationSetElementHeader(item);
			base.VisitEdmAssociationSet(item);
			if (item.SourceSet != null)
			{
				this._schemaWriter.WriteAssociationSetEndElement(item.SourceSet, item.SourceEnd.Name);
			}
			if (item.TargetSet != null)
			{
				this._schemaWriter.WriteAssociationSetEndElement(item.TargetSet, item.TargetEnd.Name);
			}
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x000C319F File Offset: 0x000C139F
		protected internal override void VisitEdmEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySet item)
		{
			this._schemaWriter.WriteEntitySetElementHeader(item);
			this._schemaWriter.WriteDefiningQuery(item);
			base.VisitEdmEntitySet(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x000C31CC File Offset: 0x000C13CC
		protected internal override void VisitFunctionImport(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport)
		{
			this._schemaWriter.WriteFunctionImportElementHeader(functionImport);
			if (functionImport.ReturnParameters.Count == 1)
			{
				this._schemaWriter.WriteFunctionImportReturnTypeAttributes(functionImport.ReturnParameter, functionImport.EntitySet, true);
				this.VisitFunctionImportReturnParameter(functionImport.ReturnParameter);
			}
			base.VisitFunctionImport(functionImport);
			if (functionImport.ReturnParameters.Count > 1)
			{
				this.VisitFunctionImportReturnParameters(functionImport);
			}
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x000C323E File Offset: 0x000C143E
		protected internal override void VisitFunctionImportParameter(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter parameter)
		{
			this._schemaWriter.WriteFunctionImportParameterElementHeader(parameter);
			base.VisitFunctionImportParameter(parameter);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x000C3260 File Offset: 0x000C1460
		private void VisitFunctionImportReturnParameters(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport)
		{
			for (int i = 0; i < functionImport.ReturnParameters.Count; i++)
			{
				this._schemaWriter.WriteFunctionReturnTypeElementHeader();
				this._schemaWriter.WriteFunctionImportReturnTypeAttributes(functionImport.ReturnParameters[i], functionImport.EntitySets[i], false);
				this.VisitFunctionImportReturnParameter(functionImport.ReturnParameter);
				this._schemaWriter.WriteEndElement();
			}
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x000C32C9 File Offset: 0x000C14C9
		protected internal override void VisitRowType(global::System.Data.Entity.Core.Metadata.Edm.RowType rowType)
		{
			this._schemaWriter.WriteRowTypeElementHeader();
			base.VisitRowType(rowType);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x000C32E8 File Offset: 0x000C14E8
		protected internal override void VisitEdmEntityType(global::System.Data.Entity.Core.Metadata.Edm.EntityType item)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Data.Entity.Core.Metadata.Edm.EdmSerializationVisitor.AppendSchemaErrors(stringBuilder, item);
			if (global::System.Data.Entity.Core.Metadata.Edm.MetadataItemHelper.IsInvalid(item))
			{
				this.AppendMetadataItem<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(stringBuilder, item, delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmSerializationVisitor v, global::System.Data.Entity.Core.Metadata.Edm.EntityType i)
				{
					v.InternalVisitEdmEntityType(i);
				});
				this.WriteComment(stringBuilder.ToString());
				return;
			}
			this.WriteComment(stringBuilder.ToString());
			this.InternalVisitEdmEntityType(item);
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x000C3351 File Offset: 0x000C1551
		protected override void VisitEdmEnumType(global::System.Data.Entity.Core.Metadata.Edm.EnumType item)
		{
			this._schemaWriter.WriteEnumTypeElementHeader(item);
			base.VisitEdmEnumType(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x000C3371 File Offset: 0x000C1571
		protected override void VisitEdmEnumTypeMember(global::System.Data.Entity.Core.Metadata.Edm.EnumMember item)
		{
			this._schemaWriter.WriteEnumTypeMemberElementHeader(item);
			base.VisitEdmEnumTypeMember(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x000C3394 File Offset: 0x000C1594
		protected override void VisitKeyProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties)
		{
			if (properties.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				this._schemaWriter.WriteDeclaredKeyPropertiesElementHeader();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property in properties)
				{
					this._schemaWriter.WriteDeclaredKeyPropertyRefElement(property);
				}
				this._schemaWriter.WriteEndElement();
			}
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x000C3400 File Offset: 0x000C1600
		protected internal override void VisitEdmProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty item)
		{
			this._schemaWriter.WritePropertyElementHeader(item);
			base.VisitEdmProperty(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x000C3420 File Offset: 0x000C1620
		protected override void VisitEdmNavigationProperty(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty item)
		{
			this._schemaWriter.WriteNavigationPropertyElementHeader(item);
			base.VisitEdmNavigationProperty(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x000C3440 File Offset: 0x000C1640
		protected override void VisitComplexType(global::System.Data.Entity.Core.Metadata.Edm.ComplexType item)
		{
			this._schemaWriter.WriteComplexTypeElementHeader(item);
			base.VisitComplexType(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x000C3460 File Offset: 0x000C1660
		protected internal override void VisitEdmAssociationType(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Data.Entity.Core.Metadata.Edm.EdmSerializationVisitor.AppendSchemaErrors(stringBuilder, item);
			if (global::System.Data.Entity.Core.Metadata.Edm.MetadataItemHelper.IsInvalid(item))
			{
				this.AppendMetadataItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(stringBuilder, item, delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmSerializationVisitor v, global::System.Data.Entity.Core.Metadata.Edm.AssociationType i)
				{
					v.InternalVisitEdmAssociationType(i);
				});
				this.WriteComment(stringBuilder.ToString());
				return;
			}
			this.WriteComment(stringBuilder.ToString());
			this.InternalVisitEdmAssociationType(item);
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x000C34C9 File Offset: 0x000C16C9
		protected override void VisitEdmAssociationEnd(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember item)
		{
			this._schemaWriter.WriteAssociationEndElementHeader(item);
			if (item.DeleteBehavior != global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None)
			{
				this._schemaWriter.WriteOperationActionElement("OnDelete", item.DeleteBehavior);
			}
			this.VisitMetadataItem(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x000C3508 File Offset: 0x000C1708
		protected override void VisitEdmAssociationConstraint(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint item)
		{
			this._schemaWriter.WriteReferentialConstraintElementHeader();
			this._schemaWriter.WriteReferentialConstraintRoleElement("Principal", item.FromRole, item.FromProperties);
			this._schemaWriter.WriteReferentialConstraintRoleElement("Dependent", item.ToRole, item.ToProperties);
			this.VisitMetadataItem(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x000C356A File Offset: 0x000C176A
		private void InternalVisitEdmEntityType(global::System.Data.Entity.Core.Metadata.Edm.EntityType item)
		{
			this._schemaWriter.WriteEntityTypeElementHeader(item);
			base.VisitEdmEntityType(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x000C358A File Offset: 0x000C178A
		private void InternalVisitEdmAssociationType(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item)
		{
			this._schemaWriter.WriteAssociationTypeElementHeader(item);
			base.VisitEdmAssociationType(item);
			this._schemaWriter.WriteEndElement();
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x000C35AC File Offset: 0x000C17AC
		private static void AppendSchemaErrors(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.MetadataItemHelper.HasSchemaErrors(item))
			{
				builder.Append(global::System.Data.Entity.Resources.Strings.MetadataItemErrorsFoundDuringGeneration);
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError edmSchemaError in global::System.Data.Entity.Core.Metadata.Edm.MetadataItemHelper.GetSchemaErrors(item))
				{
					builder.AppendLine();
					builder.Append(edmSchemaError.ToString());
				}
			}
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x000C361C File Offset: 0x000C181C
		private void AppendMetadataItem<T>(global::System.Text.StringBuilder builder, T item, global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmSerializationVisitor, T> visitAction) where T : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
		{
			global::System.Xml.XmlWriterSettings xmlWriterSettings = new global::System.Xml.XmlWriterSettings
			{
				ConformanceLevel = global::System.Xml.ConformanceLevel.Fragment,
				Indent = true
			};
			global::System.Xml.XmlWriterSettings xmlWriterSettings2 = xmlWriterSettings;
			xmlWriterSettings2.NewLineChars += "        ";
			builder.Append(xmlWriterSettings.NewLineChars);
			using (global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(builder, xmlWriterSettings))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmSerializationVisitor arg = new global::System.Data.Entity.Core.Metadata.Edm.EdmSerializationVisitor(this._schemaWriter.Replicate(xmlWriter));
				visitAction(arg, item);
			}
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x000C36A0 File Offset: 0x000C18A0
		private void WriteComment(string comment)
		{
			this._schemaWriter.WriteComment(comment.Replace("--", "- -"));
		}

		// Token: 0x04001483 RID: 5251
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter _schemaWriter;
	}
}
