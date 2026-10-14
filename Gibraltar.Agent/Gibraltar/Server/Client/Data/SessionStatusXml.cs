using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000144 RID: 324
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal enum SessionStatusXml
	{
		// Token: 0x04000450 RID: 1104
		unknown,
		// Token: 0x04000451 RID: 1105
		running,
		// Token: 0x04000452 RID: 1106
		normal,
		// Token: 0x04000453 RID: 1107
		crashed
	}
}
