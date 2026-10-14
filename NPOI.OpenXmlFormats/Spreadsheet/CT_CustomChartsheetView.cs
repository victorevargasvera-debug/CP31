using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005C1 RID: 1473
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CustomChartsheetView
	{
		// Token: 0x060040D3 RID: 16595 RVA: 0x0009D51D File Offset: 0x0009B71D
		public CT_CustomChartsheetView()
		{
			this.scaleField = 100U;
			this.stateField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState.visible;
			this.zoomToFitField = false;
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x060040D4 RID: 16596 RVA: 0x0009D53B File Offset: 0x0009B73B
		// (set) Token: 0x060040D5 RID: 16597 RVA: 0x0009D543 File Offset: 0x0009B743
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins pageMargins
		{
			get
			{
				return this.pageMarginsField;
			}
			set
			{
				this.pageMarginsField = value;
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x060040D6 RID: 16598 RVA: 0x0009D54C File Offset: 0x0009B74C
		// (set) Token: 0x060040D7 RID: 16599 RVA: 0x0009D554 File Offset: 0x0009B754
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CsPageSetup pageSetup
		{
			get
			{
				return this.pageSetupField;
			}
			set
			{
				this.pageSetupField = value;
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x0009D55D File Offset: 0x0009B75D
		// (set) Token: 0x060040D9 RID: 16601 RVA: 0x0009D565 File Offset: 0x0009B765
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooter
		{
			get
			{
				return this.headerFooterField;
			}
			set
			{
				this.headerFooterField = value;
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x060040DA RID: 16602 RVA: 0x0009D56E File Offset: 0x0009B76E
		// (set) Token: 0x060040DB RID: 16603 RVA: 0x0009D576 File Offset: 0x0009B776
		public string guid
		{
			get
			{
				return this.guidField;
			}
			set
			{
				this.guidField = value;
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x060040DC RID: 16604 RVA: 0x0009D57F File Offset: 0x0009B77F
		// (set) Token: 0x060040DD RID: 16605 RVA: 0x0009D587 File Offset: 0x0009B787
		[global::System.ComponentModel.DefaultValue(typeof(uint), "100")]
		public uint scale
		{
			get
			{
				return this.scaleField;
			}
			set
			{
				this.scaleField = value;
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x060040DE RID: 16606 RVA: 0x0009D590 File Offset: 0x0009B790
		// (set) Token: 0x060040DF RID: 16607 RVA: 0x0009D598 File Offset: 0x0009B798
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState.visible)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x060040E0 RID: 16608 RVA: 0x0009D5A1 File Offset: 0x0009B7A1
		// (set) Token: 0x060040E1 RID: 16609 RVA: 0x0009D5A9 File Offset: 0x0009B7A9
		[global::System.ComponentModel.DefaultValue(false)]
		public bool zoomToFit
		{
			get
			{
				return this.zoomToFitField;
			}
			set
			{
				this.zoomToFitField = value;
			}
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x0009D5B4 File Offset: 0x0009B7B4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetView Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetView ct_CustomChartsheetView = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomChartsheetView();
			ct_CustomChartsheetView.guid = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["guid"]);
			if (node.Attributes["scale"] != null)
			{
				ct_CustomChartsheetView.scale = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["scale"]);
			}
			if (node.Attributes["state"] != null)
			{
				ct_CustomChartsheetView.state = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState), node.Attributes["state"].Value);
			}
			if (node.Attributes["zoomToFit"] != null)
			{
				ct_CustomChartsheetView.zoomToFit = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["zoomToFit"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pageMargins")
				{
					ct_CustomChartsheetView.pageMargins = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageSetup")
				{
					ct_CustomChartsheetView.pageSetup = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CsPageSetup.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "headerFooter")
				{
					ct_CustomChartsheetView.headerFooter = global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_CustomChartsheetView;
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x0009D72C File Offset: 0x0009B92C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "guid", this.guid);
			if (this.scale != 100U)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "scale", this.scale, false);
			}
			if (this.state != global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState.visible)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "state", this.state.ToString());
			}
			if (this.zoomToFit)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "zoomToFit", this.zoomToFit);
			}
			sw.Write(">");
			if (this.pageMargins != null)
			{
				this.pageMargins.Write(sw, "pageMargins");
			}
			if (this.pageSetup != null)
			{
				this.pageSetup.Write(sw, "pageSetup");
			}
			if (this.headerFooter != null)
			{
				this.headerFooter.Write(sw, "headerFooter");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002908 RID: 10504
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins pageMarginsField;

		// Token: 0x04002909 RID: 10505
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CsPageSetup pageSetupField;

		// Token: 0x0400290A RID: 10506
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooterField;

		// Token: 0x0400290B RID: 10507
		private string guidField;

		// Token: 0x0400290C RID: 10508
		private uint scaleField;

		// Token: 0x0400290D RID: 10509
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState stateField;

		// Token: 0x0400290E RID: 10510
		private bool zoomToFitField;
	}
}
