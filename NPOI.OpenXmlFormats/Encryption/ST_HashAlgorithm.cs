using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x02000685 RID: 1669
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3761.0")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.microsoft.com/office/2006/encryption")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.microsoft.com/office/2006/encryption", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_HashAlgorithm
	{
		// Token: 0x04002C8F RID: 11407
		SHA1,
		// Token: 0x04002C90 RID: 11408
		SHA256,
		// Token: 0x04002C91 RID: 11409
		SHA384,
		// Token: 0x04002C92 RID: 11410
		SHA512,
		// Token: 0x04002C93 RID: 11411
		MD5,
		// Token: 0x04002C94 RID: 11412
		MD4,
		// Token: 0x04002C95 RID: 11413
		MD2,
		// Token: 0x04002C96 RID: 11414
		[global::System.Xml.Serialization.XmlEnum("RIPEMD-128")]
		RIPEMD128,
		// Token: 0x04002C97 RID: 11415
		[global::System.Xml.Serialization.XmlEnum("RIPEMD-160")]
		RIPEMD160,
		// Token: 0x04002C98 RID: 11416
		WHIRLPOOL
	}
}
