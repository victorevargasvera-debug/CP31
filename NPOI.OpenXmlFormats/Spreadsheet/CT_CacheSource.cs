using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000488 RID: 1160
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_CacheSource
	{
		// Token: 0x06002E71 RID: 11889 RVA: 0x00074884 File Offset: 0x00072A84
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheSource Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheSource ct_CacheSource = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheSource();
			if (node.Attributes["type"] != null)
			{
				ct_CacheSource.type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_SourceType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SourceType), node.Attributes["type"].Value);
			}
			if (node.Attributes["connectionId"] != null)
			{
				ct_CacheSource.connectionId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["connectionId"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "worksheetSource")
				{
					ct_CacheSource.worksheetSource = global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "consolidation")
				{
					ct_CacheSource.consolidation = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Consolidation.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_CacheSource.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_CacheSource;
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000749B4 File Offset: 0x00072BB4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "connectionId", this.connectionId, false);
			sw.Write(">");
			if (this.worksheetSource != null)
			{
				this.worksheetSource.Write(sw, "worksheetSource");
			}
			if (this.consolidation != null)
			{
				this.consolidation.Write(sw, "consolidation");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x00074A6A File Offset: 0x00072C6A
		public CT_CacheSource()
		{
			this.connectionIdField = 0U;
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06002E74 RID: 11892 RVA: 0x00074A79 File Offset: 0x00072C79
		// (set) Token: 0x06002E75 RID: 11893 RVA: 0x00074A81 File Offset: 0x00072C81
		[global::System.Xml.Serialization.XmlElement("consolidation", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Consolidation), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("extLst", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("worksheetSource", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource), Order = 0)]
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

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06002E76 RID: 11894 RVA: 0x00074A8A File Offset: 0x00072C8A
		// (set) Token: 0x06002E77 RID: 11895 RVA: 0x00074A92 File Offset: 0x00072C92
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_SourceType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x00074A9B File Offset: 0x00072C9B
		// (set) Token: 0x06002E79 RID: 11897 RVA: 0x00074AA3 File Offset: 0x00072CA3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint connectionId
		{
			get
			{
				return this.connectionIdField;
			}
			set
			{
				this.connectionIdField = value;
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06002E7A RID: 11898 RVA: 0x00074AAC File Offset: 0x00072CAC
		// (set) Token: 0x06002E7B RID: 11899 RVA: 0x00074AB4 File Offset: 0x00072CB4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource worksheetSource
		{
			get
			{
				return this.worksheetSourceField;
			}
			set
			{
				this.worksheetSourceField = value;
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06002E7C RID: 11900 RVA: 0x00074ABD File Offset: 0x00072CBD
		// (set) Token: 0x06002E7D RID: 11901 RVA: 0x00074AC5 File Offset: 0x00072CC5
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Consolidation consolidation
		{
			get
			{
				return this.consolidationField;
			}
			set
			{
				this.consolidationField = value;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06002E7E RID: 11902 RVA: 0x00074ACE File Offset: 0x00072CCE
		// (set) Token: 0x06002E7F RID: 11903 RVA: 0x00074AD6 File Offset: 0x00072CD6
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

		// Token: 0x06002E80 RID: 11904 RVA: 0x00074ADF File Offset: 0x00072CDF
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource AddNewWorksheetSource()
		{
			this.worksheetSourceField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource();
			return this.worksheetSourceField;
		}

		// Token: 0x04002009 RID: 8201
		private object itemField;

		// Token: 0x0400200A RID: 8202
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_SourceType typeField;

		// Token: 0x0400200B RID: 8203
		private uint connectionIdField;

		// Token: 0x0400200C RID: 8204
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource worksheetSourceField;

		// Token: 0x0400200D RID: 8205
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x0400200E RID: 8206
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Consolidation consolidationField;
	}
}
