using System;
using System.Collections;
using System.IO;
using System.Xml;
using ICSharpCode.SharpZipLib.Zip;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.Util;

namespace NPOI.OpenXml4Net.OPC.Internal.Unmarshallers
{
	// Token: 0x0200002A RID: 42
	public class PackagePropertiesUnmarshaller : global::NPOI.OpenXml4Net.OPC.Internal.PartUnmarshaller
	{
		// Token: 0x060001DE RID: 478 RVA: 0x000087A4 File Offset: 0x000069A4
		public global::NPOI.OpenXml4Net.OPC.PackagePart Unmarshall(global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.UnmarshallContext context, global::System.IO.Stream in1)
		{
			global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart packagePropertiesPart = new global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart(context.Package, context.PartName);
			if (in1 == null)
			{
				if (context.ZipEntry != null)
				{
					in1 = ((global::NPOI.OpenXml4Net.OPC.ZipPackage)context.Package).ZipArchive.GetInputStream(context.ZipEntry);
				}
				else
				{
					if (context.Package == null)
					{
						throw new global::System.IO.IOException("Error while trying to get the part input stream.");
					}
					global::ICSharpCode.SharpZipLib.Zip.ZipEntry corePropertiesZipEntry;
					try
					{
						corePropertiesZipEntry = global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.GetCorePropertiesZipEntry((global::NPOI.OpenXml4Net.OPC.ZipPackage)context.Package);
					}
					catch (global::NPOI.OpenXml4Net.OpenXml4NetException)
					{
						throw new global::System.IO.IOException("Error while trying to get the part input stream.");
					}
					in1 = ((global::NPOI.OpenXml4Net.OPC.ZipPackage)context.Package).ZipArchive.GetInputStream(corePropertiesZipEntry);
				}
			}
			global::System.Xml.XmlDocument xmlDocument = null;
			try
			{
				xmlDocument = global::NPOI.Util.DocumentHelper.LoadDocument(in1);
				this.nsmgr = new global::System.Xml.XmlNamespaceManager(xmlDocument.NameTable);
				this.nsmgr.AddNamespace("cp", global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.namespaceCP);
				this.nsmgr.AddNamespace("dc", global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.namespaceDC);
				this.nsmgr.AddNamespace("dcterms", global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.namespaceDcTerms);
				this.nsmgr.AddNamespace("xsi", global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.namespaceXSI);
				this.nsmgr.AddNamespace("cml", "http://schemas.openxmlformats.org/markup-compatibility/2006");
				this.nsmgr.AddNamespace("dcmitype", "http://purl.org/dc/dcmitype/");
				this.CheckElementForOPCCompliance(xmlDocument.DocumentElement);
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message, ex);
			}
			if (xmlDocument != null && xmlDocument.DocumentElement != null)
			{
				packagePropertiesPart.SetCategoryProperty(this.LoadCategory(xmlDocument));
				packagePropertiesPart.SetContentStatusProperty(this.LoadContentStatus(xmlDocument));
				packagePropertiesPart.SetContentTypeProperty(this.LoadContentType(xmlDocument));
				packagePropertiesPart.SetCreatedProperty(this.LoadCreated(xmlDocument));
				packagePropertiesPart.SetCreatorProperty(this.LoadCreator(xmlDocument));
				packagePropertiesPart.SetDescriptionProperty(this.LoadDescription(xmlDocument));
				packagePropertiesPart.SetIdentifierProperty(this.LoadIdentifier(xmlDocument));
				packagePropertiesPart.SetKeywordsProperty(this.LoadKeywords(xmlDocument));
				packagePropertiesPart.SetLanguageProperty(this.LoadLanguage(xmlDocument));
				packagePropertiesPart.SetLastModifiedByProperty(this.LoadLastModifiedBy(xmlDocument));
				packagePropertiesPart.SetLastPrintedProperty(this.LoadLastPrinted(xmlDocument));
				packagePropertiesPart.SetModifiedProperty(this.LoadModified(xmlDocument));
				packagePropertiesPart.SetRevisionProperty(this.LoadRevision(xmlDocument));
				packagePropertiesPart.SetSubjectProperty(this.LoadSubject(xmlDocument));
				packagePropertiesPart.SetTitleProperty(this.LoadTitle(xmlDocument));
				packagePropertiesPart.SetVersionProperty(this.LoadVersion(xmlDocument));
			}
			return packagePropertiesPart;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000089EC File Offset: 0x00006BEC
		private string LoadCategory(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("cp:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_CATEGORY, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00008A2C File Offset: 0x00006C2C
		private string LoadContentStatus(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("cp:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_CONTENT_STATUS, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00008A6C File Offset: 0x00006C6C
		private string LoadContentType(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("cp:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_CONTENT_TYPE, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00008AAC File Offset: 0x00006CAC
		private string LoadCreated(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("dcterms:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_CREATED, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00008AEC File Offset: 0x00006CEC
		private string LoadCreator(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("dc:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_CREATOR, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00008B2C File Offset: 0x00006D2C
		private string LoadDescription(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("dc:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_DESCRIPTION, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00008B6C File Offset: 0x00006D6C
		private string LoadIdentifier(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("dc:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_IDENTIFIER, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00008BAC File Offset: 0x00006DAC
		private string LoadKeywords(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("cp:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_KEYWORDS, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00008BEC File Offset: 0x00006DEC
		private string LoadLanguage(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("dc:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_LANGUAGE, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00008C2C File Offset: 0x00006E2C
		private string LoadLastModifiedBy(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("cp:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_LAST_MODIFIED_BY, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00008C6C File Offset: 0x00006E6C
		private string LoadLastPrinted(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("cp:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_LAST_PRINTED, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00008CAC File Offset: 0x00006EAC
		private string LoadModified(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("dcterms:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_MODIFIED, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00008CEC File Offset: 0x00006EEC
		private string LoadRevision(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("cp:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_REVISION, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00008D2C File Offset: 0x00006F2C
		private string LoadSubject(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("dc:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_SUBJECT, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00008D6C File Offset: 0x00006F6C
		private string LoadTitle(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("dc:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_TITLE, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00008DAC File Offset: 0x00006FAC
		private string LoadVersion(global::System.Xml.XmlDocument xmlDoc)
		{
			global::System.Xml.XmlNode xmlNode = xmlDoc.DocumentElement.SelectNodes("cp:" + global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_VERSION, this.nsmgr)[0];
			if (xmlNode == null)
			{
				return null;
			}
			return xmlNode.InnerText;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00008DEC File Offset: 0x00006FEC
		public void CheckElementForOPCCompliance(global::System.Xml.XmlElement el)
		{
			global::System.Xml.XmlAttributeCollection attributes = el.Attributes;
			int count = attributes.Count;
			for (int i = 0; i < count; i++)
			{
				global::System.Xml.XmlAttribute xmlAttribute = attributes[i];
				if (xmlAttribute.NamespaceURI.Equals(global::NPOI.Util.XMLConstants.XMLNS_ATTRIBUTE_NS_URI) && xmlAttribute.Value.Equals("http://schemas.openxmlformats.org/markup-compatibility/2006"))
				{
					throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("OPC Compliance error [M4.2]: A format consumer shall consider the use of the Markup Compatibility namespace to be an error.");
				}
			}
			string localName = el.LocalName;
			if (el.NamespaceURI.Equals("http://purl.org/dc/terms/") && !localName.Equals(global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_CREATED) && !localName.Equals(global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_MODIFIED))
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("OPC Compliance error [M4.3]: Producers shall not create a document element that contains refinements to the Dublin Core elements, except for the two specified in the schema: <dcterms:created> and <dcterms:modified> Consumers shall consider a document element that violates this constraint to be an error.");
			}
			if (el.Attributes["lang", global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.namespaceXML] != null)
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("OPC Compliance error [M4.4]: Producers shall not create a document element that contains the xml:lang attribute. Consumers shall consider a document element that violates this constraint to be an error.");
			}
			if (el.NamespaceURI.Equals("http://purl.org/dc/terms/"))
			{
				if (!localName.Equals(global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_CREATED) && !localName.Equals(global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.KEYWORD_MODIFIED))
				{
					throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("Namespace error : " + localName + " shouldn't have the following naemspace -> http://purl.org/dc/terms/");
				}
				global::System.Xml.XmlNode xmlNode = el.Attributes["type", global::NPOI.Util.XMLConstants.W3C_XML_SCHEMA_INSTANCE_NS_URI];
				if (xmlNode == null)
				{
					throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(string.Concat(new string[]
					{
						"The element '",
						localName,
						"' must have the '",
						this.nsmgr.LookupPrefix(global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.namespaceXSI),
						":type' attribute present !"
					}));
				}
				if (!xmlNode.Value.Equals(el.Prefix + ":W3CDTF"))
				{
					throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(string.Concat(new string[]
					{
						"The element '",
						localName,
						"' must have the '",
						this.nsmgr.LookupPrefix(global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller.namespaceXSI),
						":type' attribute with the value '",
						el.Prefix,
						":W3CDTF', but had '",
						xmlNode.Value,
						"' !"
					}));
				}
			}
			global::System.Collections.IEnumerator enumerator = el.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Current is global::System.Xml.XmlElement)
				{
					this.CheckElementForOPCCompliance((global::System.Xml.XmlElement)enumerator.Current);
				}
			}
		}

		// Token: 0x040000C7 RID: 199
		private static string namespaceDC = "http://purl.org/dc/elements/1.1/";

		// Token: 0x040000C8 RID: 200
		private static string namespaceCP = "http://schemas.openxmlformats.org/package/2006/metadata/core-properties";

		// Token: 0x040000C9 RID: 201
		private static string namespaceDcTerms = "http://purl.org/dc/terms/";

		// Token: 0x040000CA RID: 202
		private static string namespaceXML = "http://www.w3.org/XML/1998/namespace";

		// Token: 0x040000CB RID: 203
		private static string namespaceXSI = "http://www.w3.org/2001/XMLSchema-instance";

		// Token: 0x040000CC RID: 204
		protected static string KEYWORD_CATEGORY = "category";

		// Token: 0x040000CD RID: 205
		protected static string KEYWORD_CONTENT_STATUS = "contentStatus";

		// Token: 0x040000CE RID: 206
		protected static string KEYWORD_CONTENT_TYPE = "contentType";

		// Token: 0x040000CF RID: 207
		protected static string KEYWORD_CREATED = "created";

		// Token: 0x040000D0 RID: 208
		protected static string KEYWORD_CREATOR = "creator";

		// Token: 0x040000D1 RID: 209
		protected static string KEYWORD_DESCRIPTION = "description";

		// Token: 0x040000D2 RID: 210
		protected static string KEYWORD_IDENTIFIER = "identifier";

		// Token: 0x040000D3 RID: 211
		protected static string KEYWORD_KEYWORDS = "keywords";

		// Token: 0x040000D4 RID: 212
		protected static string KEYWORD_LANGUAGE = "language";

		// Token: 0x040000D5 RID: 213
		protected static string KEYWORD_LAST_MODIFIED_BY = "lastModifiedBy";

		// Token: 0x040000D6 RID: 214
		protected static string KEYWORD_LAST_PRINTED = "lastPrinted";

		// Token: 0x040000D7 RID: 215
		protected static string KEYWORD_MODIFIED = "modified";

		// Token: 0x040000D8 RID: 216
		protected static string KEYWORD_REVISION = "revision";

		// Token: 0x040000D9 RID: 217
		protected static string KEYWORD_SUBJECT = "subject";

		// Token: 0x040000DA RID: 218
		protected static string KEYWORD_TITLE = "title";

		// Token: 0x040000DB RID: 219
		protected static string KEYWORD_VERSION = "version";

		// Token: 0x040000DC RID: 220
		protected global::System.Xml.XmlNamespaceManager nsmgr;
	}
}
