using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x02000684 RID: 1668
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3761.0")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.microsoft.com/office/2006/encryption")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.microsoft.com/office/2006/encryption", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_CipherChaining
	{
		// Token: 0x04002C8C RID: 11404
		ChainingModeCBC,
		// Token: 0x04002C8D RID: 11405
		ChainingModeCFB
	}
}
