using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005FB RID: 1531
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true, ElementName = "externalLink")]
	[global::System.Serializable]
	public class CT_ExternalLink
	{
		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x0600432F RID: 17199 RVA: 0x000A0078 File Offset: 0x0009E278
		// (set) Token: 0x06004330 RID: 17200 RVA: 0x000A0080 File Offset: 0x0009E280
		public global::NPOI.OpenXmlFormats.Spreadsheet.ExternalLinkItem itemType { get; set; }

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06004331 RID: 17201 RVA: 0x000A0089 File Offset: 0x0009E289
		// (set) Token: 0x06004332 RID: 17202 RVA: 0x000A0091 File Offset: 0x0009E291
		[global::System.Xml.Serialization.XmlElement("ddeLink", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeLink))]
		[global::System.Xml.Serialization.XmlElement("extLst", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList))]
		[global::System.Xml.Serialization.XmlElement("externalBook", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalBook))]
		[global::System.Xml.Serialization.XmlElement("oleLink", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleLink))]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x000A009A File Offset: 0x0009E29A
		// (set) Token: 0x06004334 RID: 17204 RVA: 0x000A00A2 File Offset: 0x0009E2A2
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalBook externalBook
		{
			get
			{
				return this.externalBookField;
			}
			set
			{
				this.externalBookField = value;
			}
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x000A00AB File Offset: 0x0009E2AB
		// (set) Token: 0x06004336 RID: 17206 RVA: 0x000A00B3 File Offset: 0x0009E2B3
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeLink ddlLink
		{
			get
			{
				return this.ddeLinkField;
			}
			set
			{
				this.ddeLinkField = value;
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x000A00BC File Offset: 0x0009E2BC
		// (set) Token: 0x06004338 RID: 17208 RVA: 0x000A00C4 File Offset: 0x0009E2C4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleLink oleLink
		{
			get
			{
				return this.oleLinkField;
			}
			set
			{
				this.oleLinkField = value;
			}
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06004339 RID: 17209 RVA: 0x000A00CD File Offset: 0x0009E2CD
		// (set) Token: 0x0600433A RID: 17210 RVA: 0x000A00D5 File Offset: 0x0009E2D5
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x000A00E0 File Offset: 0x0009E2E0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalLink Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalLink ct_ExternalLink = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalLink();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "externalBook")
				{
					ct_ExternalLink.externalBookField = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalBook.Parse(xmlNode, namespaceManager);
					ct_ExternalLink.itemField = ct_ExternalLink.externalBookField;
					ct_ExternalLink.itemType = global::NPOI.OpenXmlFormats.Spreadsheet.ExternalLinkItem.externalBook;
				}
				else if (xmlNode.LocalName == "ddeLink")
				{
					ct_ExternalLink.ddeLinkField = global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeLink.Parse(xmlNode, namespaceManager);
					ct_ExternalLink.itemField = ct_ExternalLink.ddeLinkField;
					ct_ExternalLink.itemType = global::NPOI.OpenXmlFormats.Spreadsheet.ExternalLinkItem.ddeLink;
				}
				else if (xmlNode.LocalName == "oleLink")
				{
					ct_ExternalLink.oleLinkField = global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleLink.Parse(xmlNode, namespaceManager);
					ct_ExternalLink.itemField = ct_ExternalLink.oleLinkField;
					ct_ExternalLink.itemType = global::NPOI.OpenXmlFormats.Spreadsheet.ExternalLinkItem.oleLink;
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_ExternalLink.extLstField = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
					ct_ExternalLink.itemField = ct_ExternalLink.extLstField;
					ct_ExternalLink.itemType = global::NPOI.OpenXmlFormats.Spreadsheet.ExternalLinkItem.extLst;
				}
			}
			return ct_ExternalLink;
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x000A0218 File Offset: 0x0009E418
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<externalLink xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" mc:Ignorable=\"x14\" xmlns:x14=\"http://schemas.microsoft.com/office/spreadsheetml/2009/9/main\">");
			if (this.externalBookField != null)
			{
				this.externalBookField.Write(sw, "externalBook");
			}
			if (this.ddeLinkField != null)
			{
				this.ddeLinkField.Write(sw, "ddeLink");
			}
			if (this.extLstField != null)
			{
				this.extLstField.Write(sw, "extLst");
			}
			if (this.oleLinkField != null)
			{
				this.oleLinkField.Write(sw, "oleLink");
			}
			sw.Write("</externalLink>");
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x000A02AA File Offset: 0x0009E4AA
		public void AddNewExternalBook()
		{
			this.externalBookField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalBook();
		}

		// Token: 0x04002A67 RID: 10855
		private object itemField;

		// Token: 0x04002A69 RID: 10857
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalBook externalBookField;

		// Token: 0x04002A6A RID: 10858
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeLink ddeLinkField;

		// Token: 0x04002A6B RID: 10859
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleLink oleLinkField;

		// Token: 0x04002A6C RID: 10860
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
