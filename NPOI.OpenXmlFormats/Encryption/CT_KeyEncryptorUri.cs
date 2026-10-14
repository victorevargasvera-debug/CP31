using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x02000687 RID: 1671
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3761.0")]
	[global::System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/office/2006/encryption")]
	[global::System.Serializable]
	public enum CT_KeyEncryptorUri
	{
		// Token: 0x04002C9D RID: 11421
		[global::System.Xml.Serialization.XmlEnum("http://schemas.microsoft.com/office/2006/keyEncryptor/password")]
		httpschemasmicrosoftcomoffice2006keyEncryptorpassword,
		// Token: 0x04002C9E RID: 11422
		[global::System.Xml.Serialization.XmlEnum("http://schemas.microsoft.com/office/2006/keyEncryptor/certificate")]
		httpschemasmicrosoftcomoffice2006keyEncryptorcertificate
	}
}
