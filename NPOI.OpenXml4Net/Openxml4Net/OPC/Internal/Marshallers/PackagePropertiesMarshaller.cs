using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXml4Net.OPC.Internal.Marshallers
{
	// Token: 0x0200002D RID: 45
	public class PackagePropertiesMarshaller : global::NPOI.OpenXml4Net.OPC.Internal.PartMarshaller
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00009138 File Offset: 0x00007338
		public virtual bool Marshall(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::System.IO.Stream out1)
		{
			if (!(part is global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart))
			{
				throw new global::System.ArgumentException("'part' must be a PackagePropertiesPart instance.");
			}
			this.propsPart = (global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart)part;
			this.xmlDoc = new global::System.Xml.XmlDocument();
			global::System.Xml.XmlElement xmlElement = this.xmlDoc.CreateElement("coreProperties", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
			this.nsmgr = new global::System.Xml.XmlNamespaceManager(this.xmlDoc.NameTable);
			this.nsmgr.AddNamespace("cp", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_CP_URI);
			this.nsmgr.AddNamespace("dc", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_DC_URI);
			this.nsmgr.AddNamespace("dcterms", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_DCTERMS_URI);
			this.nsmgr.AddNamespace("xsi", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_XSI_URI);
			xmlElement.SetAttribute("xmlns:cp", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_CP_URI);
			xmlElement.SetAttribute("xmlns:dc", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_DC_URI);
			xmlElement.SetAttribute("xmlns:dcterms", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_DCTERMS_URI);
			xmlElement.SetAttribute("xmlns:xsi", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_XSI_URI);
			this.xmlDoc.AppendChild(xmlElement);
			this.AddCategory();
			this.AddContentStatus();
			this.AddContentType();
			this.AddCreated();
			this.AddCreator();
			this.AddDescription();
			this.AddIdentifier();
			this.AddKeywords();
			this.AddLanguage();
			this.AddLastModifiedBy();
			this.AddLastPrinted();
			this.AddModified();
			this.AddRevision();
			this.AddSubject();
			this.AddTitle();
			this.AddVersion();
			return true;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000092A0 File Offset: 0x000074A0
		private void AddCategory()
		{
			if (this.propsPart.GetCategoryProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_CATEGORY, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
			global::System.Xml.XmlNode xmlNode;
			if (elementsByTagName.Count == 0)
			{
				xmlNode = this.xmlDoc.CreateElement("cp", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_CATEGORY, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
				this.xmlDoc.DocumentElement.AppendChild(xmlNode);
			}
			else
			{
				xmlNode = elementsByTagName[0];
				xmlNode.InnerXml = "";
			}
			xmlNode.InnerText = this.propsPart.GetCategoryProperty();
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00009334 File Offset: 0x00007534
		private void AddContentStatus()
		{
			if (this.propsPart.GetContentStatusProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_CONTENT_STATUS, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
			global::System.Xml.XmlNode xmlNode;
			if (elementsByTagName.Count == 0)
			{
				xmlNode = this.xmlDoc.CreateElement("cp", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_CONTENT_STATUS, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
				this.xmlDoc.DocumentElement.AppendChild(xmlNode);
			}
			else
			{
				xmlNode = elementsByTagName[0];
				xmlNode.InnerXml = "";
			}
			xmlNode.InnerText = this.propsPart.GetContentStatusProperty();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000093C8 File Offset: 0x000075C8
		private void AddContentType()
		{
			if (this.propsPart.GetContentTypeProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_CONTENT_TYPE, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
			global::System.Xml.XmlNode xmlNode;
			if (elementsByTagName.Count == 0)
			{
				xmlNode = this.xmlDoc.CreateElement("cp", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_CONTENT_TYPE, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
				this.xmlDoc.DocumentElement.AppendChild(xmlNode);
			}
			else
			{
				xmlNode = elementsByTagName[0];
				xmlNode.InnerXml = "";
			}
			xmlNode.InnerText = this.propsPart.GetContentTypeProperty();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000945C File Offset: 0x0000765C
		private void AddCreated()
		{
			if (this.propsPart.GetCreatedProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_CREATED, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDcTerms);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("dcterms", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_CREATED, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDcTerms);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.SetAttribute("type", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceXSI, "dcterms:W3CDTF");
			xmlElement.InnerText = this.propsPart.GetCreatedPropertyString();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00009514 File Offset: 0x00007714
		private void AddCreator()
		{
			if (this.propsPart.GetCreatorProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_CREATOR, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("dc", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_CREATOR, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetCreatorProperty();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000095AC File Offset: 0x000077AC
		private void AddDescription()
		{
			if (this.propsPart.GetDescriptionProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_DESCRIPTION, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("dc", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_DESCRIPTION, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetDescriptionProperty();
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00009644 File Offset: 0x00007844
		private void AddIdentifier()
		{
			if (this.propsPart.GetIdentifierProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_IDENTIFIER, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("dc", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_IDENTIFIER, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetIdentifierProperty();
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000096DC File Offset: 0x000078DC
		private void AddKeywords()
		{
			if (this.propsPart.GetKeywordsProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_KEYWORDS, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("cp", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_KEYWORDS, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetKeywordsProperty();
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00009774 File Offset: 0x00007974
		private void AddLanguage()
		{
			if (this.propsPart.GetLanguageProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_LANGUAGE, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("dc", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_LANGUAGE, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetLanguageProperty();
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000980C File Offset: 0x00007A0C
		private void AddLastModifiedBy()
		{
			if (this.propsPart.GetLastModifiedByProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_LAST_MODIFIED_BY, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("cp", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_LAST_MODIFIED_BY, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetLastModifiedByProperty();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000098A4 File Offset: 0x00007AA4
		private void AddLastPrinted()
		{
			if (this.propsPart.GetLastPrintedProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_LAST_PRINTED, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("cp", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_LAST_PRINTED, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetLastPrintedPropertyString();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00009944 File Offset: 0x00007B44
		private void AddModified()
		{
			if (this.propsPart.GetModifiedProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_MODIFIED, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDcTerms);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("dcterms", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_MODIFIED, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDcTerms);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetModifiedPropertyString();
			xmlElement.SetAttribute("type", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceXSI, "dcterms:W3CDTF");
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000099FC File Offset: 0x00007BFC
		private void AddRevision()
		{
			if (this.propsPart.GetRevisionProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_REVISION, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("cp", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_REVISION, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetRevisionProperty();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00009A94 File Offset: 0x00007C94
		private void AddSubject()
		{
			if (this.propsPart.GetSubjectProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_SUBJECT, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("dc", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_SUBJECT, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetSubjectProperty();
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00009B2C File Offset: 0x00007D2C
		private void AddTitle()
		{
			if (this.propsPart.GetTitleProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_TITLE, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("dc", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_TITLE, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceDC);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetTitleProperty();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00009BC4 File Offset: 0x00007DC4
		private void AddVersion()
		{
			if (this.propsPart.GetVersionProperty() == null)
			{
				return;
			}
			global::System.Xml.XmlNodeList elementsByTagName = this.xmlDoc.DocumentElement.GetElementsByTagName(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_VERSION, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
			global::System.Xml.XmlElement xmlElement;
			if (elementsByTagName.Count == 0)
			{
				xmlElement = this.xmlDoc.CreateElement("cp", global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.KEYWORD_VERSION, global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller.namespaceCoreProperties);
				this.xmlDoc.DocumentElement.AppendChild(xmlElement);
			}
			else
			{
				xmlElement = (global::System.Xml.XmlElement)elementsByTagName[0];
				xmlElement.InnerXml = "";
			}
			xmlElement.InnerText = this.propsPart.GetVersionProperty();
		}

		// Token: 0x040000E0 RID: 224
		private static string namespaceDC = global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_DC_URI;

		// Token: 0x040000E1 RID: 225
		private static string namespaceCoreProperties = global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_CP_URI;

		// Token: 0x040000E2 RID: 226
		private static string namespaceDcTerms = global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_DCTERMS_URI;

		// Token: 0x040000E3 RID: 227
		private static string namespaceXSI = global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_XSI_URI;

		// Token: 0x040000E4 RID: 228
		protected static string KEYWORD_CATEGORY = "category";

		// Token: 0x040000E5 RID: 229
		protected static string KEYWORD_CONTENT_STATUS = "contentStatus";

		// Token: 0x040000E6 RID: 230
		protected static string KEYWORD_CONTENT_TYPE = "contentType";

		// Token: 0x040000E7 RID: 231
		protected static string KEYWORD_CREATED = "created";

		// Token: 0x040000E8 RID: 232
		protected static string KEYWORD_CREATOR = "creator";

		// Token: 0x040000E9 RID: 233
		protected static string KEYWORD_DESCRIPTION = "description";

		// Token: 0x040000EA RID: 234
		protected static string KEYWORD_IDENTIFIER = "identifier";

		// Token: 0x040000EB RID: 235
		protected static string KEYWORD_KEYWORDS = "keywords";

		// Token: 0x040000EC RID: 236
		protected static string KEYWORD_LANGUAGE = "language";

		// Token: 0x040000ED RID: 237
		protected static string KEYWORD_LAST_MODIFIED_BY = "lastModifiedBy";

		// Token: 0x040000EE RID: 238
		protected static string KEYWORD_LAST_PRINTED = "lastPrinted";

		// Token: 0x040000EF RID: 239
		protected static string KEYWORD_MODIFIED = "modified";

		// Token: 0x040000F0 RID: 240
		protected static string KEYWORD_REVISION = "revision";

		// Token: 0x040000F1 RID: 241
		protected static string KEYWORD_SUBJECT = "subject";

		// Token: 0x040000F2 RID: 242
		protected static string KEYWORD_TITLE = "title";

		// Token: 0x040000F3 RID: 243
		protected static string KEYWORD_VERSION = "version";

		// Token: 0x040000F4 RID: 244
		private global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart propsPart;

		// Token: 0x040000F5 RID: 245
		protected global::System.Xml.XmlDocument xmlDoc;

		// Token: 0x040000F6 RID: 246
		protected global::System.Xml.XmlNamespaceManager nsmgr;
	}
}
