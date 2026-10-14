using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000157 RID: 343
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal enum SessionSynchronizationModeXml
	{
		// Token: 0x040004C1 RID: 1217
		manual,
		// Token: 0x040004C2 RID: 1218
		summaryOnly,
		// Token: 0x040004C3 RID: 1219
		automatic
	}
}
