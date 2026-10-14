using System;
using System.Data.Entity.Utilities;
using System.Runtime.Serialization;
using System.Xml;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200042C RID: 1068
	public class ProxyDataContractResolver : global::System.Runtime.Serialization.DataContractResolver
	{
		// Token: 0x06003402 RID: 13314 RVA: 0x000A71C3 File Offset: 0x000A53C3
		public override global::System.Type ResolveName(string typeName, string typeNamespace, global::System.Type declaredType, global::System.Runtime.Serialization.DataContractResolver knownTypeResolver)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(typeName, "typeName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(typeNamespace, "typeNamespace");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(declaredType, "declaredType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Runtime.Serialization.DataContractResolver>(knownTypeResolver, "knownTypeResolver");
			return knownTypeResolver.ResolveName(typeName, typeNamespace, declaredType, null);
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x000A7204 File Offset: 0x000A5404
		public override bool TryResolveType(global::System.Type type, global::System.Type declaredType, global::System.Runtime.Serialization.DataContractResolver knownTypeResolver, out global::System.Xml.XmlDictionaryString typeName, out global::System.Xml.XmlDictionaryString typeNamespace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(declaredType, "declaredType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Runtime.Serialization.DataContractResolver>(knownTypeResolver, "knownTypeResolver");
			global::System.Type objectType = global::System.Data.Entity.Core.Objects.ObjectContext.GetObjectType(type);
			if (objectType != type)
			{
				global::System.Xml.XmlQualifiedName schemaTypeName = this._exporter.GetSchemaTypeName(objectType);
				global::System.Xml.XmlDictionary dictionary = new global::System.Xml.XmlDictionary(2);
				typeName = new global::System.Xml.XmlDictionaryString(dictionary, schemaTypeName.Name, 0);
				typeNamespace = new global::System.Xml.XmlDictionaryString(dictionary, schemaTypeName.Namespace, 1);
				return true;
			}
			return knownTypeResolver.TryResolveType(type, declaredType, null, out typeName, out typeNamespace);
		}

		// Token: 0x040010D0 RID: 4304
		private readonly global::System.Runtime.Serialization.XsdDataContractExporter _exporter = new global::System.Runtime.Serialization.XsdDataContractExporter();
	}
}
