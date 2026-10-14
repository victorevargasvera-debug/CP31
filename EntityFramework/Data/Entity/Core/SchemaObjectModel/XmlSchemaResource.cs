using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000327 RID: 807
	internal struct XmlSchemaResource
	{
		// Token: 0x06002668 RID: 9832 RVA: 0x0006DACB File Offset: 0x0006BCCB
		public XmlSchemaResource(string namespaceUri, string resourceName, global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[] importedSchemas)
		{
			this.NamespaceUri = namespaceUri;
			this.ResourceName = resourceName;
			this.ImportedSchemas = importedSchemas;
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x0006DAE2 File Offset: 0x0006BCE2
		public XmlSchemaResource(string namespaceUri, string resourceName)
		{
			this.NamespaceUri = namespaceUri;
			this.ResourceName = resourceName;
			this.ImportedSchemas = global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource._emptyImportList;
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x0006DAFD File Offset: 0x0006BCFD
		internal static global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource> GetMetadataSchemaResourceMap(double schemaVersion)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource>(global::System.StringComparer.Ordinal);
			global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource.AddEdmSchemaResourceMapEntries(dictionary, schemaVersion);
			global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource.AddStoreSchemaResourceMapEntries(dictionary, schemaVersion);
			return dictionary;
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x0006DB18 File Offset: 0x0006BD18
		internal static void AddStoreSchemaResourceMapEntries(global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource> schemaResourceMap, double schemaVersion)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[] importedSchemas = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[]
			{
				new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2007/12/edm/EntityStoreSchemaGenerator", "System.Data.Resources.EntityStoreSchemaGenerator.xsd")
			};
			global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2006/04/edm/ssdl", "System.Data.Resources.SSDLSchema.xsd", importedSchemas);
			schemaResourceMap.Add(xmlSchemaResource.NamespaceUri, xmlSchemaResource);
			if (schemaVersion >= 2.0)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource2 = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2009/02/edm/ssdl", "System.Data.Resources.SSDLSchema_2.xsd", importedSchemas);
				schemaResourceMap.Add(xmlSchemaResource2.NamespaceUri, xmlSchemaResource2);
			}
			if (schemaVersion >= 3.0)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource3 = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2009/11/edm/ssdl", "System.Data.Resources.SSDLSchema_3.xsd", importedSchemas);
				schemaResourceMap.Add(xmlSchemaResource3.NamespaceUri, xmlSchemaResource3);
			}
			global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource4 = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2006/04/edm/providermanifest", "System.Data.Resources.ProviderServices.ProviderManifest.xsd");
			schemaResourceMap.Add(xmlSchemaResource4.NamespaceUri, xmlSchemaResource4);
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x0006DBD8 File Offset: 0x0006BDD8
		internal static void AddMappingSchemaResourceMapEntries(global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource> schemaResourceMap, double schemaVersion)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("urn:schemas-microsoft-com:windows:storage:mapping:CS", "System.Data.Resources.CSMSL_1.xsd");
			schemaResourceMap.Add(xmlSchemaResource.NamespaceUri, xmlSchemaResource);
			if (schemaVersion >= 2.0)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource2 = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2008/09/mapping/cs", "System.Data.Resources.CSMSL_2.xsd");
				schemaResourceMap.Add(xmlSchemaResource2.NamespaceUri, xmlSchemaResource2);
			}
			if (schemaVersion >= 3.0)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource3 = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2009/11/mapping/cs", "System.Data.Resources.CSMSL_3.xsd");
				schemaResourceMap.Add(xmlSchemaResource3.NamespaceUri, xmlSchemaResource3);
			}
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x0006DC58 File Offset: 0x0006BE58
		internal static void AddEdmSchemaResourceMapEntries(global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource> schemaResourceMap, double schemaVersion)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[] importedSchemas = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[]
			{
				new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2006/04/codegeneration", "System.Data.Resources.CodeGenerationSchema.xsd")
			};
			global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[] importedSchemas2 = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[]
			{
				new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2006/04/codegeneration", "System.Data.Resources.CodeGenerationSchema.xsd"),
				new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2009/02/edm/annotation", "System.Data.Resources.AnnotationSchema.xsd")
			};
			global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[] importedSchemas3 = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[]
			{
				new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2006/04/codegeneration", "System.Data.Resources.CodeGenerationSchema.xsd"),
				new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2009/02/edm/annotation", "System.Data.Resources.AnnotationSchema.xsd")
			};
			global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2006/04/edm", "System.Data.Resources.CSDLSchema_1.xsd", importedSchemas);
			schemaResourceMap.Add(xmlSchemaResource.NamespaceUri, xmlSchemaResource);
			global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource2 = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2007/05/edm", "System.Data.Resources.CSDLSchema_1_1.xsd", importedSchemas);
			schemaResourceMap.Add(xmlSchemaResource2.NamespaceUri, xmlSchemaResource2);
			if (schemaVersion >= 2.0)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource3 = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2008/09/edm", "System.Data.Resources.CSDLSchema_2.xsd", importedSchemas2);
				schemaResourceMap.Add(xmlSchemaResource3.NamespaceUri, xmlSchemaResource3);
			}
			if (schemaVersion >= 3.0)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource4 = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource("http://schemas.microsoft.com/ado/2009/11/edm", "System.Data.Resources.CSDLSchema_3.xsd", importedSchemas3);
				schemaResourceMap.Add(xmlSchemaResource4.NamespaceUri, xmlSchemaResource4);
			}
		}

		// Token: 0x04000D6C RID: 3436
		private static readonly global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[] _emptyImportList = new global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[0];

		// Token: 0x04000D6D RID: 3437
		internal string NamespaceUri;

		// Token: 0x04000D6E RID: 3438
		internal string ResourceName;

		// Token: 0x04000D6F RID: 3439
		internal global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource[] ImportedSchemas;
	}
}
