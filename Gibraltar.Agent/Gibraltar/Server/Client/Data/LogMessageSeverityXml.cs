using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200013F RID: 319
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal enum LogMessageSeverityXml
	{
		// Token: 0x04000403 RID: 1027
		verbose,
		// Token: 0x04000404 RID: 1028
		information,
		// Token: 0x04000405 RID: 1029
		warning,
		// Token: 0x04000406 RID: 1030
		error,
		// Token: 0x04000407 RID: 1031
		critical
	}
}
