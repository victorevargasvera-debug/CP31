using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200014F RID: 335
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal enum ClientRepositoryStatusXml
	{
		// Token: 0x04000497 RID: 1175
		active,
		// Token: 0x04000498 RID: 1176
		pending,
		// Token: 0x04000499 RID: 1177
		inactive
	}
}
