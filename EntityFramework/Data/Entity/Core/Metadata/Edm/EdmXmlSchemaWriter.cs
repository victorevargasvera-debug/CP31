using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004B7 RID: 1207
	internal class EdmXmlSchemaWriter : global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter
	{
		// Token: 0x06003B9F RID: 15263 RVA: 0x000C4080 File Offset: 0x000C2280
		private static string SyndicationItemPropertyToString(object value)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter._syndicationItemToTargetPath[(int)value];
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x000C408E File Offset: 0x000C228E
		private static string SyndicationTextContentKindToString(object value)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter._syndicationTextContentKindToString[(int)value];
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x000C409C File Offset: 0x000C229C
		public EdmXmlSchemaWriter()
		{
			this._resolver = global::System.Data.Entity.DbConfiguration.DependencyResolver;
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x000C40AF File Offset: 0x000C22AF
		internal EdmXmlSchemaWriter(global::System.Xml.XmlWriter xmlWriter, double edmVersion, bool serializeDefaultNullability, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver = null)
		{
			this._resolver = (resolver ?? global::System.Data.Entity.DbConfiguration.DependencyResolver);
			this._serializeDefaultNullability = serializeDefaultNullability;
			this._xmlWriter = xmlWriter;
			this._version = edmVersion;
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x000C40E0 File Offset: 0x000C22E0
		internal virtual void WriteSchemaElementHeader(string schemaNamespace)
		{
			string csdlNamespace = global::System.Data.Entity.Core.Metadata.Edm.XmlConstants.GetCsdlNamespace(this._version);
			this._xmlWriter.WriteStartElement("Schema", csdlNamespace);
			this._xmlWriter.WriteAttributeString("Namespace", schemaNamespace);
			this._xmlWriter.WriteAttributeString("Alias", "Self");
			if (this._version == 3.0)
			{
				this._xmlWriter.WriteAttributeString("annotation", "UseStrongSpatialTypes", "http://schemas.microsoft.com/ado/2009/02/edm/annotation", "false");
			}
			this._xmlWriter.WriteAttributeString("xmlns", "annotation", null, "http://schemas.microsoft.com/ado/2009/02/edm/annotation");
			this._xmlWriter.WriteAttributeString("xmlns", "customannotation", null, "http://schemas.microsoft.com/ado/2013/11/edm/customannotation");
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x000C4198 File Offset: 0x000C2398
		internal virtual void WriteSchemaElementHeader(string schemaNamespace, string provider, string providerManifestToken, bool writeStoreSchemaGenNamespace)
		{
			string ssdlNamespace = global::System.Data.Entity.Core.Metadata.Edm.XmlConstants.GetSsdlNamespace(this._version);
			this._xmlWriter.WriteStartElement("Schema", ssdlNamespace);
			this._xmlWriter.WriteAttributeString("Namespace", schemaNamespace);
			this._xmlWriter.WriteAttributeString("Provider", provider);
			this._xmlWriter.WriteAttributeString("ProviderManifestToken", providerManifestToken);
			this._xmlWriter.WriteAttributeString("Alias", "Self");
			if (writeStoreSchemaGenNamespace)
			{
				this._xmlWriter.WriteAttributeString("xmlns", "store", null, "http://schemas.microsoft.com/ado/2007/12/edm/EntityStoreSchemaGenerator");
			}
			this._xmlWriter.WriteAttributeString("xmlns", "customannotation", null, "http://schemas.microsoft.com/ado/2013/11/edm/customannotation");
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x000C4244 File Offset: 0x000C2444
		private void WritePolymorphicTypeAttributes(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			if (edmType.BaseType != null)
			{
				this._xmlWriter.WriteAttributeString("BaseType", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetQualifiedTypeName("Self", edmType.BaseType.Name));
			}
			if (edmType.Abstract)
			{
				this._xmlWriter.WriteAttributeString("Abstract", "true");
			}
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x000C429C File Offset: 0x000C249C
		public virtual void WriteFunctionElementHeader(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			this._xmlWriter.WriteStartElement("Function");
			this._xmlWriter.WriteAttributeString("Name", function.Name);
			this._xmlWriter.WriteAttributeString("Aggregate", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetLowerCaseStringFromBoolValue(function.AggregateAttribute));
			this._xmlWriter.WriteAttributeString("BuiltIn", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetLowerCaseStringFromBoolValue(function.BuiltInAttribute));
			this._xmlWriter.WriteAttributeString("NiladicFunction", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetLowerCaseStringFromBoolValue(function.NiladicFunctionAttribute));
			this._xmlWriter.WriteAttributeString("IsComposable", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetLowerCaseStringFromBoolValue(function.IsComposableAttribute));
			this._xmlWriter.WriteAttributeString("ParameterTypeSemantics", function.ParameterTypeSemanticsAttribute.ToString());
			this._xmlWriter.WriteAttributeString("Schema", function.Schema);
			if (function.StoreFunctionNameAttribute != null && function.StoreFunctionNameAttribute != function.Name)
			{
				this._xmlWriter.WriteAttributeString("StoreFunctionName", function.StoreFunctionNameAttribute);
			}
			if (function.ReturnParameters != null && function.ReturnParameters.Any<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>())
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = function.ReturnParameters.First<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>().TypeUsage.EdmType;
				if (edmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
				{
					this._xmlWriter.WriteAttributeString("ReturnType", global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter.GetTypeName(edmType));
				}
			}
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x000C43F4 File Offset: 0x000C25F4
		public virtual void WriteFunctionParameterHeader(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter)
		{
			this._xmlWriter.WriteStartElement("Parameter");
			this._xmlWriter.WriteAttributeString("Name", functionParameter.Name);
			this._xmlWriter.WriteAttributeString("Type", functionParameter.TypeName);
			this._xmlWriter.WriteAttributeString("Mode", functionParameter.Mode.ToString());
			if (functionParameter.IsMaxLength)
			{
				this._xmlWriter.WriteAttributeString("MaxLength", "Max");
			}
			else if (!functionParameter.IsMaxLengthConstant && functionParameter.MaxLength != null)
			{
				this._xmlWriter.WriteAttributeString("MaxLength", functionParameter.MaxLength.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			}
			if (!functionParameter.IsPrecisionConstant && functionParameter.Precision != null)
			{
				this._xmlWriter.WriteAttributeString("Precision", functionParameter.Precision.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			}
			if (!functionParameter.IsScaleConstant && functionParameter.Scale != null)
			{
				this._xmlWriter.WriteAttributeString("Scale", functionParameter.Scale.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			}
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x000C454B File Offset: 0x000C274B
		internal virtual void WriteFunctionReturnTypeElementHeader()
		{
			this._xmlWriter.WriteStartElement("ReturnType");
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x000C4560 File Offset: 0x000C2760
		internal void WriteEntityTypeElementHeader(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			this._xmlWriter.WriteStartElement("EntityType");
			this._xmlWriter.WriteAttributeString("Name", entityType.Name);
			this.WriteExtendedProperties(entityType);
			if (entityType.Annotations.GetClrAttributes() != null)
			{
				foreach (global::System.Attribute attribute in entityType.Annotations.GetClrAttributes())
				{
					if (attribute.GetType().FullName.Equals("System.Data.Services.Common.HasStreamAttribute", global::System.StringComparison.Ordinal))
					{
						this._xmlWriter.WriteAttributeString("m", "HasStream", "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", "true");
					}
					else if (attribute.GetType().FullName.Equals("System.Data.Services.MimeTypeAttribute", global::System.StringComparison.Ordinal))
					{
						string propertyName = attribute.GetType().GetDeclaredProperty("MemberName").GetValue(attribute, null) as string;
						global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter.AddAttributeAnnotation(entityType.Properties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Name.Equals(propertyName, global::System.StringComparison.Ordinal)), attribute);
					}
					else if (attribute.GetType().FullName.Equals("System.Data.Services.Common.EntityPropertyMappingAttribute", global::System.StringComparison.Ordinal))
					{
						string text = attribute.GetType().GetDeclaredProperty("SourcePath").GetValue(attribute, null) as string;
						int num = text.IndexOf("/", global::System.StringComparison.Ordinal);
						string propertyName;
						if (num == -1)
						{
							propertyName = text;
						}
						else
						{
							propertyName = text.Substring(0, num);
						}
						global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter.AddAttributeAnnotation(entityType.Properties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Name.Equals(propertyName, global::System.StringComparison.Ordinal)), attribute);
					}
				}
			}
			this.WritePolymorphicTypeAttributes(entityType);
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x000C4728 File Offset: 0x000C2928
		internal void WriteEnumTypeElementHeader(global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType)
		{
			this._xmlWriter.WriteStartElement("EnumType");
			this._xmlWriter.WriteAttributeString("Name", enumType.Name);
			this._xmlWriter.WriteAttributeString("IsFlags", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetLowerCaseStringFromBoolValue(enumType.IsFlags));
			this.WriteExtendedProperties(enumType);
			if (enumType.UnderlyingType != null)
			{
				this._xmlWriter.WriteAttributeString("UnderlyingType", enumType.UnderlyingType.PrimitiveTypeKind.ToString());
			}
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x000C47B0 File Offset: 0x000C29B0
		internal void WriteEnumTypeMemberElementHeader(global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumTypeMember)
		{
			this._xmlWriter.WriteStartElement("Member");
			this._xmlWriter.WriteAttributeString("Name", enumTypeMember.Name);
			this._xmlWriter.WriteAttributeString("Value", enumTypeMember.Value.ToString());
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x000C4800 File Offset: 0x000C2A00
		private static void AddAttributeAnnotation(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, global::System.Attribute a)
		{
			if (property != null)
			{
				global::System.Collections.Generic.IList<global::System.Attribute> clrAttributes = property.Annotations.GetClrAttributes();
				if (clrAttributes != null)
				{
					if (!clrAttributes.Contains(a))
					{
						clrAttributes.Add(a);
						return;
					}
				}
				else
				{
					property.GetMetadataProperties().SetClrAttributes(new global::System.Collections.Generic.List<global::System.Attribute>
					{
						a
					});
				}
			}
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x000C4847 File Offset: 0x000C2A47
		internal void WriteComplexTypeElementHeader(global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
		{
			this._xmlWriter.WriteStartElement("ComplexType");
			this._xmlWriter.WriteAttributeString("Name", complexType.Name);
			this.WriteExtendedProperties(complexType);
			this.WritePolymorphicTypeAttributes(complexType);
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x000C487D File Offset: 0x000C2A7D
		internal virtual void WriteCollectionTypeElementHeader()
		{
			this._xmlWriter.WriteStartElement("CollectionType");
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x000C488F File Offset: 0x000C2A8F
		internal virtual void WriteRowTypeElementHeader()
		{
			this._xmlWriter.WriteStartElement("RowType");
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x000C48A1 File Offset: 0x000C2AA1
		internal void WriteAssociationTypeElementHeader(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			this._xmlWriter.WriteStartElement("Association");
			this._xmlWriter.WriteAttributeString("Name", associationType.Name);
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x000C48CC File Offset: 0x000C2ACC
		internal void WriteAssociationEndElementHeader(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember associationEnd)
		{
			this._xmlWriter.WriteStartElement("End");
			this._xmlWriter.WriteAttributeString("Role", associationEnd.Name);
			string name = associationEnd.GetEntityType().Name;
			this._xmlWriter.WriteAttributeString("Type", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetQualifiedTypeName("Self", name));
			this._xmlWriter.WriteAttributeString("Multiplicity", global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicityConverter.MultiplicityToString(associationEnd.RelationshipMultiplicity));
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x000C4941 File Offset: 0x000C2B41
		internal void WriteOperationActionElement(string elementName, global::System.Data.Entity.Core.Metadata.Edm.OperationAction operationAction)
		{
			this._xmlWriter.WriteStartElement(elementName);
			this._xmlWriter.WriteAttributeString("Action", operationAction.ToString());
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x000C4977 File Offset: 0x000C2B77
		internal void WriteReferentialConstraintElementHeader()
		{
			this._xmlWriter.WriteStartElement("ReferentialConstraint");
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x000C4989 File Offset: 0x000C2B89
		internal void WriteDeclaredKeyPropertiesElementHeader()
		{
			this._xmlWriter.WriteStartElement("Key");
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x000C499B File Offset: 0x000C2B9B
		internal void WriteDeclaredKeyPropertyRefElement(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			this._xmlWriter.WriteStartElement("PropertyRef");
			this._xmlWriter.WriteAttributeString("Name", property.Name);
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x000C49D0 File Offset: 0x000C2BD0
		internal void WritePropertyElementHeader(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			this._xmlWriter.WriteStartElement("Property");
			this._xmlWriter.WriteAttributeString("Name", property.Name);
			this._xmlWriter.WriteAttributeString("Type", global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter.GetTypeReferenceName(property));
			if (property.CollectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
			{
				this._xmlWriter.WriteAttributeString("CollectionKind", property.CollectionKind.ToString());
			}
			if (property.ConcurrencyMode == global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed)
			{
				this._xmlWriter.WriteAttributeString("ConcurrencyMode", "Fixed");
			}
			this.WriteExtendedProperties(property);
			if (property.Annotations.GetClrAttributes() != null)
			{
				int num = 0;
				foreach (global::System.Attribute attribute in property.Annotations.GetClrAttributes())
				{
					if (attribute.GetType().FullName.Equals("System.Data.Services.MimeTypeAttribute", global::System.StringComparison.Ordinal))
					{
						string value = attribute.GetType().GetDeclaredProperty("MimeType").GetValue(attribute, null) as string;
						this._xmlWriter.WriteAttributeString("m", "MimeType", "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", value);
					}
					else if (attribute.GetType().FullName.Equals("System.Data.Services.Common.EntityPropertyMappingAttribute", global::System.StringComparison.Ordinal))
					{
						string str = (num == 0) ? string.Empty : string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "_{0}", new object[]
						{
							num
						});
						string text = attribute.GetType().GetDeclaredProperty("SourcePath").GetValue(attribute, null) as string;
						int num2 = text.IndexOf("/", global::System.StringComparison.Ordinal);
						if (num2 != -1 && num2 + 1 < text.Length)
						{
							this._xmlWriter.WriteAttributeString("m", "FC_SourcePath" + str, "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", text.Substring(num2 + 1));
						}
						object value2 = attribute.GetType().GetDeclaredProperty("TargetSyndicationItem").GetValue(attribute, null);
						string value3 = attribute.GetType().GetDeclaredProperty("KeepInContent").GetValue(attribute, null).ToString();
						global::System.Reflection.PropertyInfo declaredProperty = attribute.GetType().GetDeclaredProperty("CriteriaValue");
						string text2 = null;
						if (declaredProperty != null)
						{
							text2 = (declaredProperty.GetValue(attribute, null) as string);
						}
						if (text2 != null)
						{
							this._xmlWriter.WriteAttributeString("m", "FC_TargetPath" + str, "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter.SyndicationItemPropertyToString(value2));
							this._xmlWriter.WriteAttributeString("m", "FC_KeepInContent" + str, "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", value3);
							this._xmlWriter.WriteAttributeString("m", "FC_CriteriaValue" + str, "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", text2);
						}
						else if (string.Equals(value2.ToString(), "CustomProperty", global::System.StringComparison.Ordinal))
						{
							string value4 = attribute.GetType().GetDeclaredProperty("TargetPath").GetValue(attribute, null).ToString();
							string value5 = attribute.GetType().GetDeclaredProperty("TargetNamespacePrefix").GetValue(attribute, null).ToString();
							string value6 = attribute.GetType().GetDeclaredProperty("TargetNamespaceUri").GetValue(attribute, null).ToString();
							this._xmlWriter.WriteAttributeString("m", "FC_TargetPath" + str, "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", value4);
							this._xmlWriter.WriteAttributeString("m", "FC_NsUri" + str, "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", value6);
							this._xmlWriter.WriteAttributeString("m", "FC_NsPrefix" + str, "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", value5);
							this._xmlWriter.WriteAttributeString("m", "FC_KeepInContent" + str, "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", value3);
						}
						else
						{
							object value7 = attribute.GetType().GetDeclaredProperty("TargetTextContentKind").GetValue(attribute, null);
							this._xmlWriter.WriteAttributeString("m", "FC_TargetPath" + str, "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter.SyndicationItemPropertyToString(value2));
							this._xmlWriter.WriteAttributeString("m", "FC_ContentKind" + str, "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter.SyndicationTextContentKindToString(value7));
							this._xmlWriter.WriteAttributeString("m", "FC_KeepInContent" + str, "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", value3);
						}
						num++;
					}
				}
			}
			if (property.IsMaxLength)
			{
				this._xmlWriter.WriteAttributeString("MaxLength", "Max");
			}
			else if (!property.IsMaxLengthConstant && property.MaxLength != null)
			{
				this._xmlWriter.WriteAttributeString("MaxLength", property.MaxLength.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			}
			if (!property.IsFixedLengthConstant && property.IsFixedLength != null)
			{
				this._xmlWriter.WriteAttributeString("FixedLength", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetLowerCaseStringFromBoolValue(property.IsFixedLength.Value));
			}
			if (!property.IsUnicodeConstant && property.IsUnicode != null)
			{
				this._xmlWriter.WriteAttributeString("Unicode", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetLowerCaseStringFromBoolValue(property.IsUnicode.Value));
			}
			if (!property.IsPrecisionConstant && property.Precision != null)
			{
				this._xmlWriter.WriteAttributeString("Precision", property.Precision.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			}
			if (!property.IsScaleConstant && property.Scale != null)
			{
				this._xmlWriter.WriteAttributeString("Scale", property.Scale.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			}
			if (property.StoreGeneratedPattern != global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.None)
			{
				this._xmlWriter.WriteAttributeString("StoreGeneratedPattern", (property.StoreGeneratedPattern == global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Computed) ? "Computed" : "Identity");
			}
			if (this._serializeDefaultNullability || !property.Nullable)
			{
				this._xmlWriter.WriteAttributeString("Nullable", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetLowerCaseStringFromBoolValue(property.Nullable));
			}
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty;
			if (property.MetadataProperties.TryGetValue("http://schemas.microsoft.com/ado/2009/02/edm/annotation:StoreGeneratedPattern", false, out metadataProperty))
			{
				this._xmlWriter.WriteAttributeString("StoreGeneratedPattern", "http://schemas.microsoft.com/ado/2009/02/edm/annotation", metadataProperty.Value.ToString());
			}
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x000C5050 File Offset: 0x000C3250
		private static string GetTypeReferenceName(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			if (property.IsPrimitiveType)
			{
				return property.TypeName;
			}
			if (property.IsComplexType)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetQualifiedTypeName("Self", property.ComplexType.Name);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetQualifiedTypeName("Self", property.EnumType.Name);
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x000C50A0 File Offset: 0x000C32A0
		internal void WriteNavigationPropertyElementHeader(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty member)
		{
			this._xmlWriter.WriteStartElement("NavigationProperty");
			this._xmlWriter.WriteAttributeString("Name", member.Name);
			this._xmlWriter.WriteAttributeString("Relationship", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetQualifiedTypeName("Self", member.Association.Name));
			this._xmlWriter.WriteAttributeString("FromRole", member.GetFromEnd().Name);
			this._xmlWriter.WriteAttributeString("ToRole", member.ToEndMember.Name);
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x000C5130 File Offset: 0x000C3330
		internal void WriteReferentialConstraintRoleElement(string roleName, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember edmAssociationEnd, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties)
		{
			this._xmlWriter.WriteStartElement(roleName);
			this._xmlWriter.WriteAttributeString("Role", edmAssociationEnd.Name);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in properties)
			{
				this._xmlWriter.WriteStartElement("PropertyRef");
				this._xmlWriter.WriteAttributeString("Name", edmProperty.Name);
				this._xmlWriter.WriteEndElement();
			}
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x000C51D0 File Offset: 0x000C33D0
		internal virtual void WriteEntityContainerElementHeader(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container)
		{
			this._xmlWriter.WriteStartElement("EntityContainer");
			this._xmlWriter.WriteAttributeString("Name", container.Name);
			this.WriteExtendedProperties(container);
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x000C5200 File Offset: 0x000C3400
		internal void WriteAssociationSetElementHeader(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet)
		{
			this._xmlWriter.WriteStartElement("AssociationSet");
			this._xmlWriter.WriteAttributeString("Name", associationSet.Name);
			this._xmlWriter.WriteAttributeString("Association", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetQualifiedTypeName("Self", associationSet.ElementType.Name));
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x000C5258 File Offset: 0x000C3458
		internal void WriteAssociationSetEndElement(global::System.Data.Entity.Core.Metadata.Edm.EntitySet end, string roleName)
		{
			this._xmlWriter.WriteStartElement("End");
			this._xmlWriter.WriteAttributeString("Role", roleName);
			this._xmlWriter.WriteAttributeString("EntitySet", end.Name);
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x000C52A8 File Offset: 0x000C34A8
		internal virtual void WriteEntitySetElementHeader(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			this._xmlWriter.WriteStartElement("EntitySet");
			this._xmlWriter.WriteAttributeString("Name", entitySet.Name);
			this._xmlWriter.WriteAttributeString("EntityType", global::System.Data.Entity.Core.Metadata.Edm.XmlSchemaWriter.GetQualifiedTypeName("Self", entitySet.ElementType.Name));
			if (!string.IsNullOrWhiteSpace(entitySet.Schema))
			{
				this._xmlWriter.WriteAttributeString("Schema", entitySet.Schema);
			}
			if (!string.IsNullOrWhiteSpace(entitySet.Table))
			{
				this._xmlWriter.WriteAttributeString("Table", entitySet.Table);
			}
			this.WriteExtendedProperties(entitySet);
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x000C5350 File Offset: 0x000C3550
		internal virtual void WriteFunctionImportElementHeader(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport)
		{
			this._xmlWriter.WriteStartElement("FunctionImport");
			this._xmlWriter.WriteAttributeString("Name", functionImport.Name);
			if (functionImport.IsComposableAttribute)
			{
				this._xmlWriter.WriteAttributeString("IsComposable", "true");
			}
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x000C53A0 File Offset: 0x000C35A0
		internal virtual void WriteFunctionImportReturnTypeAttributes(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter returnParameter, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, bool inline)
		{
			this._xmlWriter.WriteAttributeString(inline ? "ReturnType" : "Type", global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter.GetTypeName(returnParameter.TypeUsage.EdmType));
			if (entitySet != null)
			{
				this._xmlWriter.WriteAttributeString("EntitySet", entitySet.Name);
			}
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x000C53F0 File Offset: 0x000C35F0
		internal virtual void WriteFunctionImportParameterElementHeader(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter parameter)
		{
			this._xmlWriter.WriteStartElement("Parameter");
			this._xmlWriter.WriteAttributeString("Name", parameter.Name);
			this._xmlWriter.WriteAttributeString("Mode", parameter.Mode.ToString());
			this._xmlWriter.WriteAttributeString("Type", global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter.GetTypeName(parameter.TypeUsage.EdmType));
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x000C5467 File Offset: 0x000C3667
		internal void WriteDefiningQuery(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			if (!string.IsNullOrWhiteSpace(entitySet.DefiningQuery))
			{
				this._xmlWriter.WriteElementString("DefiningQuery", entitySet.DefiningQuery);
			}
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x000C548C File Offset: 0x000C368C
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter Replicate(global::System.Xml.XmlWriter xmlWriter)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter(xmlWriter, this._version, this._serializeDefaultNullability, null);
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x000C54A4 File Offset: 0x000C36A4
		internal void WriteExtendedProperties(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty in from p in item.MetadataProperties
			where p.PropertyKind == global::System.Data.Entity.Core.Metadata.Edm.PropertyKind.Extended
			select p)
			{
				string ns;
				string text;
				if (global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter.TrySplitExtendedMetadataPropertyName(metadataProperty.Name, out ns, out text) && metadataProperty.Name != "http://schemas.microsoft.com/ado/2009/02/edm/annotation:StoreGeneratedPattern")
				{
					global::System.Func<global::System.Data.Entity.Infrastructure.IMetadataAnnotationSerializer> service = this._resolver.GetService(text);
					string value = (service == null) ? metadataProperty.Value.ToString() : service().Serialize(text, metadataProperty.Value);
					this._xmlWriter.WriteAttributeString(text, ns, value);
				}
			}
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x000C5574 File Offset: 0x000C3774
		private static bool TrySplitExtendedMetadataPropertyName(string name, out string xmlNamespaceUri, out string attributeName)
		{
			int num = name.LastIndexOf(':');
			if (num < 1 || name.Length <= num + 1)
			{
				xmlNamespaceUri = null;
				attributeName = null;
				return false;
			}
			xmlNamespaceUri = name.Substring(0, num);
			attributeName = name.Substring(num + 1, name.Length - 1 - num);
			return true;
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x000C55C4 File Offset: 0x000C37C4
		private static string GetTypeName(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			if (type.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
			{
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Collection({0})", new object[]
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmXmlSchemaWriter.GetTypeName(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)type).TypeUsage.EdmType)
				});
			}
			if (type.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
			{
				return type.FullName;
			}
			return type.Name;
		}

		// Token: 0x0400148A RID: 5258
		private readonly bool _serializeDefaultNullability;

		// Token: 0x0400148B RID: 5259
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver _resolver;

		// Token: 0x0400148C RID: 5260
		private const string AnnotationNamespacePrefix = "annotation";

		// Token: 0x0400148D RID: 5261
		private const string CustomAnnotationNamespacePrefix = "customannotation";

		// Token: 0x0400148E RID: 5262
		private const string StoreSchemaGenNamespacePrefix = "store";

		// Token: 0x0400148F RID: 5263
		private const string DataServicesPrefix = "m";

		// Token: 0x04001490 RID: 5264
		private const string DataServicesNamespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata";

		// Token: 0x04001491 RID: 5265
		private const string DataServicesMimeTypeAttribute = "System.Data.Services.MimeTypeAttribute";

		// Token: 0x04001492 RID: 5266
		private const string DataServicesHasStreamAttribute = "System.Data.Services.Common.HasStreamAttribute";

		// Token: 0x04001493 RID: 5267
		private const string DataServicesEntityPropertyMappingAttribute = "System.Data.Services.Common.EntityPropertyMappingAttribute";

		// Token: 0x04001494 RID: 5268
		private static readonly string[] _syndicationItemToTargetPath = new string[]
		{
			string.Empty,
			"SyndicationAuthorEmail",
			"SyndicationAuthorName",
			"SyndicationAuthorUri",
			"SyndicationContributorEmail",
			"SyndicationContributorName",
			"SyndicationContributorUri",
			"SyndicationUpdated",
			"SyndicationPublished",
			"SyndicationRights",
			"SyndicationSummary",
			"SyndicationTitle",
			"SyndicationCategoryLabel",
			"SyndicationCategoryScheme",
			"SyndicationCategoryTerm",
			"SyndicationLinkHref",
			"SyndicationLinkHrefLang",
			"SyndicationLinkLength",
			"SyndicationLinkRel",
			"SyndicationLinkTitle",
			"SyndicationLinkType"
		};

		// Token: 0x04001495 RID: 5269
		private static readonly string[] _syndicationTextContentKindToString = new string[]
		{
			"text",
			"html",
			"xhtml"
		};

		// Token: 0x02000AE1 RID: 2785
		internal static class SyndicationXmlConstants
		{
			// Token: 0x04002BEA RID: 11242
			internal const string SyndAuthorEmail = "SyndicationAuthorEmail";

			// Token: 0x04002BEB RID: 11243
			internal const string SyndAuthorName = "SyndicationAuthorName";

			// Token: 0x04002BEC RID: 11244
			internal const string SyndAuthorUri = "SyndicationAuthorUri";

			// Token: 0x04002BED RID: 11245
			internal const string SyndPublished = "SyndicationPublished";

			// Token: 0x04002BEE RID: 11246
			internal const string SyndRights = "SyndicationRights";

			// Token: 0x04002BEF RID: 11247
			internal const string SyndSummary = "SyndicationSummary";

			// Token: 0x04002BF0 RID: 11248
			internal const string SyndTitle = "SyndicationTitle";

			// Token: 0x04002BF1 RID: 11249
			internal const string SyndContributorEmail = "SyndicationContributorEmail";

			// Token: 0x04002BF2 RID: 11250
			internal const string SyndContributorName = "SyndicationContributorName";

			// Token: 0x04002BF3 RID: 11251
			internal const string SyndContributorUri = "SyndicationContributorUri";

			// Token: 0x04002BF4 RID: 11252
			internal const string SyndCategoryLabel = "SyndicationCategoryLabel";

			// Token: 0x04002BF5 RID: 11253
			internal const string SyndContentKindPlaintext = "text";

			// Token: 0x04002BF6 RID: 11254
			internal const string SyndContentKindHtml = "html";

			// Token: 0x04002BF7 RID: 11255
			internal const string SyndContentKindXHtml = "xhtml";

			// Token: 0x04002BF8 RID: 11256
			internal const string SyndUpdated = "SyndicationUpdated";

			// Token: 0x04002BF9 RID: 11257
			internal const string SyndLinkHref = "SyndicationLinkHref";

			// Token: 0x04002BFA RID: 11258
			internal const string SyndLinkRel = "SyndicationLinkRel";

			// Token: 0x04002BFB RID: 11259
			internal const string SyndLinkType = "SyndicationLinkType";

			// Token: 0x04002BFC RID: 11260
			internal const string SyndLinkHrefLang = "SyndicationLinkHrefLang";

			// Token: 0x04002BFD RID: 11261
			internal const string SyndLinkTitle = "SyndicationLinkTitle";

			// Token: 0x04002BFE RID: 11262
			internal const string SyndLinkLength = "SyndicationLinkLength";

			// Token: 0x04002BFF RID: 11263
			internal const string SyndCategoryTerm = "SyndicationCategoryTerm";

			// Token: 0x04002C00 RID: 11264
			internal const string SyndCategoryScheme = "SyndicationCategoryScheme";
		}
	}
}
