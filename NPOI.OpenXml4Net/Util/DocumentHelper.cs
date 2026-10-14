using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

namespace NPOI.Util
{
	// Token: 0x02000002 RID: 2
	public class DocumentHelper
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private DocumentHelper()
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public static global::System.Xml.XPath.XPathDocument ReadDocument(global::System.IO.Stream stream)
		{
			return new global::System.Xml.XPath.XPathDocument(global::System.Xml.XmlReader.Create(stream, new global::System.Xml.XmlReaderSettings
			{
				ValidationFlags = global::System.Xml.Schema.XmlSchemaValidationFlags.None,
				ValidationType = global::System.Xml.ValidationType.None,
				XmlResolver = null,
				DtdProcessing = global::System.Xml.DtdProcessing.Ignore
			}));
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002094 File Offset: 0x00000294
		public static global::System.Xml.XmlDocument LoadDocument(global::System.IO.Stream stream)
		{
			global::System.Xml.XmlReaderSettings xmlReaderSettings = new global::System.Xml.XmlReaderSettings();
			xmlReaderSettings.ValidationFlags = global::System.Xml.Schema.XmlSchemaValidationFlags.None;
			xmlReaderSettings.ValidationType = global::System.Xml.ValidationType.Schema;
			xmlReaderSettings.XmlResolver = null;
			xmlReaderSettings.DtdProcessing = global::System.Xml.DtdProcessing.Ignore;
			xmlReaderSettings.ConformanceLevel = global::System.Xml.ConformanceLevel.Auto;
			xmlReaderSettings.IgnoreProcessingInstructions = true;
			global::System.Xml.XmlDocument result;
			try
			{
				global::System.Xml.XmlReader reader = global::System.Xml.XmlReader.Create(stream, xmlReaderSettings);
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.XmlResolver = null;
				xmlDocument.PreserveWhitespace = true;
				xmlDocument.Load(reader);
				result = xmlDocument;
			}
			catch (global::System.Xml.XmlException)
			{
				stream.Position = 0L;
				using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(stream))
				{
					global::System.Xml.XmlDocument xmlDocument2 = new global::System.Xml.XmlDocument();
					xmlDocument2.XmlResolver = null;
					xmlDocument2.PreserveWhitespace = true;
					xmlDocument2.LoadXml(streamReader.ReadToEnd());
					result = xmlDocument2;
				}
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002150 File Offset: 0x00000350
		public static global::System.Xml.XPath.XPathDocument CreateDocument()
		{
			throw new global::System.NotImplementedException();
		}
	}
}
