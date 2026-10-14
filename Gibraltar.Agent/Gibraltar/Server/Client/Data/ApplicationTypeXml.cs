using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000143 RID: 323
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal enum ApplicationTypeXml
	{
		// Token: 0x0400044A RID: 1098
		unknown,
		// Token: 0x0400044B RID: 1099
		console,
		// Token: 0x0400044C RID: 1100
		windows,
		// Token: 0x0400044D RID: 1101
		service,
		// Token: 0x0400044E RID: 1102
		aspnet
	}
}
