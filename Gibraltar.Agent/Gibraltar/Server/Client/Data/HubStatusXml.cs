using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000150 RID: 336
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal enum HubStatusXml
	{
		// Token: 0x0400049B RID: 1179
		available,
		// Token: 0x0400049C RID: 1180
		maintenance,
		// Token: 0x0400049D RID: 1181
		expired
	}
}
