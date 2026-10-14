using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x0200068A RID: 1674
	public class EncryptionDocument
	{
		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x0600473C RID: 18236 RVA: 0x000AC15C File Offset: 0x000AA35C
		public static global::System.Xml.XmlNamespaceManager EncryptionNamespaceManager
		{
			get
			{
				if (global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.nsm == null)
				{
					global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.nsm = global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.CreateEncryptionNSM();
				}
				return global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.nsm;
			}
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x000AC174 File Offset: 0x000AA374
		internal static global::System.Xml.XmlNamespaceManager CreateEncryptionNSM()
		{
			global::System.Xml.XmlNamespaceManager xmlNamespaceManager = new global::System.Xml.XmlNamespaceManager(new global::System.Xml.NameTable());
			xmlNamespaceManager.AddNamespace(string.Empty, global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.ENCRYPTION_DEFAULT);
			xmlNamespaceManager.AddNamespace("p", global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.ENCRYPTION_PASSWORD);
			xmlNamespaceManager.AddNamespace("c", global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.ENCRYPTION_CERTIFICATE);
			xmlNamespaceManager.AddNamespace("xsd", "http://www.w3.org/2001/XMLSchema");
			return xmlNamespaceManager;
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x0000205F File Offset: 0x0000025F
		public EncryptionDocument()
		{
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x000AC1CB File Offset: 0x000AA3CB
		public EncryptionDocument(global::NPOI.OpenXmlFormats.Encryption.CT_Encryption encryption)
		{
			this.ctEncryption = encryption;
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x000AC1DA File Offset: 0x000AA3DA
		public static global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument Parse(global::System.Xml.XmlDocument xmlDoc, global::System.Xml.XmlNamespaceManager NameSpaceManager)
		{
			return new global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument(global::NPOI.OpenXmlFormats.Encryption.CT_Encryption.Parse(xmlDoc.DocumentElement, NameSpaceManager));
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x000AC1ED File Offset: 0x000AA3ED
		public global::NPOI.OpenXmlFormats.Encryption.CT_Encryption GetEncryption()
		{
			return this.ctEncryption;
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x000AC1F5 File Offset: 0x000AA3F5
		public void SetEncryption(global::NPOI.OpenXmlFormats.Encryption.CT_Encryption encryption)
		{
			this.ctEncryption = encryption;
		}

		// Token: 0x06004743 RID: 18243 RVA: 0x000AC1FE File Offset: 0x000AA3FE
		public global::NPOI.OpenXmlFormats.Encryption.CT_Encryption AddNewEncryption()
		{
			this.ctEncryption = new global::NPOI.OpenXmlFormats.Encryption.CT_Encryption();
			return this.ctEncryption;
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x000AC211 File Offset: 0x000AA411
		public void Save(global::System.IO.Stream stream)
		{
			global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream);
			streamWriter.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\" ?>");
			streamWriter.Flush();
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x000024E5 File Offset: 0x000006E5
		public static global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument NewInstance()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x000024E5 File Offset: 0x000006E5
		public static global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument Parse(string descriptor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x000AC22E File Offset: 0x000AA42E
		public static global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument Parse(global::System.Xml.XmlDocument xmlDoc)
		{
			return global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.Parse(xmlDoc, global::NPOI.OpenXmlFormats.Encryption.EncryptionDocument.EncryptionNamespaceManager);
		}

		// Token: 0x04002CA2 RID: 11426
		public static string ENCRYPTION_DEFAULT = "http://schemas.microsoft.com/office/2006/encryption";

		// Token: 0x04002CA3 RID: 11427
		public static string ENCRYPTION_PASSWORD = "http://schemas.microsoft.com/office/2006/keyEncryptor/password";

		// Token: 0x04002CA4 RID: 11428
		public static string ENCRYPTION_CERTIFICATE = "http://schemas.microsoft.com/office/2006/keyEncryptor/certificate";

		// Token: 0x04002CA5 RID: 11429
		private static global::System.Xml.XmlNamespaceManager nsm = null;

		// Token: 0x04002CA6 RID: 11430
		private global::NPOI.OpenXmlFormats.Encryption.CT_Encryption ctEncryption;
	}
}
