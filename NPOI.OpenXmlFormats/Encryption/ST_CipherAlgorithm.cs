using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x02000683 RID: 1667
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3761.0")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.microsoft.com/office/2006/encryption")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.microsoft.com/office/2006/encryption", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_CipherAlgorithm
	{
		// Token: 0x04002C84 RID: 11396
		AES,
		// Token: 0x04002C85 RID: 11397
		RC2,
		// Token: 0x04002C86 RID: 11398
		RC4,
		// Token: 0x04002C87 RID: 11399
		DES,
		// Token: 0x04002C88 RID: 11400
		DESX,
		// Token: 0x04002C89 RID: 11401
		[global::System.Xml.Serialization.XmlEnum("3DES")]
		Item3DES,
		// Token: 0x04002C8A RID: 11402
		[global::System.Xml.Serialization.XmlEnum("3DES_112")]
		Item3DES_112
	}
}
