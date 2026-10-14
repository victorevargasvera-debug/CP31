using System;
using System.IO;
using System.Xml;

namespace AcpCryptoLib
{
	// Token: 0x02000016 RID: 22
	public interface IAcpXMLEncryptDecrypt
	{
		// Token: 0x0600004F RID: 79
		void EncryptXMLFile(string inputFileName, string outputFileName);

		// Token: 0x06000050 RID: 80
		void EncryptXMLDoc(global::System.Xml.XmlDocument Doc, string outputFileName);

		// Token: 0x06000051 RID: 81
		global::System.Xml.XmlDocument DecryptXMLFile(string inputFileName);

		// Token: 0x06000052 RID: 82
		global::System.Xml.XmlDocument DecryptXMLFile(global::System.IO.Stream inputStream);
	}
}
