using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000146 RID: 326
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal enum BootModeXml
	{
		// Token: 0x0400045A RID: 1114
		unknown,
		// Token: 0x0400045B RID: 1115
		normal,
		// Token: 0x0400045C RID: 1116
		failsafe,
		// Token: 0x0400045D RID: 1117
		failsafewithnetwork
	}
}
