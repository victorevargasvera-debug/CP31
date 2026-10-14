using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000485 RID: 1157
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Consolidation
	{
		// Token: 0x06002E5D RID: 11869 RVA: 0x00074598 File Offset: 0x00072798
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Consolidation Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Consolidation ct_Consolidation = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Consolidation();
			if (node.Attributes["autoPage"] != null)
			{
				ct_Consolidation.autoPage = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoPage"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pages")
				{
					ct_Consolidation.pages = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pages.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rangeSets")
				{
					ct_Consolidation.rangeSets = global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSets.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Consolidation;
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x00074664 File Offset: 0x00072864
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoPage", this.autoPage);
			sw.Write(">");
			if (this.pages != null)
			{
				this.pages.Write(sw, "pages");
			}
			if (this.rangeSets != null)
			{
				this.rangeSets.Write(sw, "rangeSets");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000746E1 File Offset: 0x000728E1
		public CT_Consolidation()
		{
			this.rangeSetsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSets();
			this.pagesField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pages();
			this.autoPageField = true;
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06002E60 RID: 11872 RVA: 0x00074706 File Offset: 0x00072906
		// (set) Token: 0x06002E61 RID: 11873 RVA: 0x0007470E File Offset: 0x0007290E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pages pages
		{
			get
			{
				return this.pagesField;
			}
			set
			{
				this.pagesField = value;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x00074717 File Offset: 0x00072917
		// (set) Token: 0x06002E63 RID: 11875 RVA: 0x0007471F File Offset: 0x0007291F
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSets rangeSets
		{
			get
			{
				return this.rangeSetsField;
			}
			set
			{
				this.rangeSetsField = value;
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x00074728 File Offset: 0x00072928
		// (set) Token: 0x06002E65 RID: 11877 RVA: 0x00074730 File Offset: 0x00072930
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool autoPage
		{
			get
			{
				return this.autoPageField;
			}
			set
			{
				this.autoPageField = value;
			}
		}

		// Token: 0x04001FFD RID: 8189
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pages pagesField;

		// Token: 0x04001FFE RID: 8190
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSets rangeSetsField;

		// Token: 0x04001FFF RID: 8191
		private bool autoPageField;
	}
}
