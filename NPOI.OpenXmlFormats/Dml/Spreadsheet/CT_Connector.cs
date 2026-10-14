using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000379 RID: 889
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_Connector
	{
		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x0005C9AC File Offset: 0x0005ABAC
		// (set) Token: 0x0600239D RID: 9117 RVA: 0x0005C9B4 File Offset: 0x0005ABB4
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ConnectorNonVisual nvCxnSpPr
		{
			get
			{
				return this.nvCxnSpPrField;
			}
			set
			{
				this.nvCxnSpPrField = value;
			}
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0005C9C0 File Offset: 0x0005ABC0
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector ct_Connector = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector();
			ct_Connector.macro = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["macro"]);
			ct_Connector.fPublished = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fPublished"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "nvCxnSpPr")
				{
					ct_Connector.nvCxnSpPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ConnectorNonVisual.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_Connector.spPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "style")
				{
					ct_Connector.style = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Connector;
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x0005CAB8 File Offset: 0x0005ACB8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "macro", this.macro, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fPublished", this.fPublished, false);
			sw.Write(">");
			if (this.nvCxnSpPr != null)
			{
				this.nvCxnSpPr.Write(sw, "nvCxnSpPr");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.style != null)
			{
				this.style.Write(sw, "style");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x0005CB61 File Offset: 0x0005AD61
		public void Set(global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector obj)
		{
			this.macroField = obj.macro;
			this.fPublishedField = obj.fPublished;
			this.spPrField = obj.spPr;
			this.styleField = obj.style;
			this.nvCxnSpPrField = obj.nvCxnSpPr;
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x0005CB9F File Offset: 0x0005AD9F
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ConnectorNonVisual AddNewNvCxnSpPr()
		{
			this.nvCxnSpPr = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ConnectorNonVisual();
			return this.nvCxnSpPr;
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x0005CBB2 File Offset: 0x0005ADB2
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties AddNewSpPr()
		{
			this.spPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties();
			return this.spPrField;
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0005CBC5 File Offset: 0x0005ADC5
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle AddNewStyle()
		{
			this.styleField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle();
			return this.styleField;
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x0005CBD8 File Offset: 0x0005ADD8
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x0005CBE0 File Offset: 0x0005ADE0
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties spPr
		{
			get
			{
				return this.spPrField;
			}
			set
			{
				this.spPrField = value;
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x0005CBE9 File Offset: 0x0005ADE9
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x0005CBF1 File Offset: 0x0005ADF1
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle style
		{
			get
			{
				return this.styleField;
			}
			set
			{
				this.styleField = value;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x060023A8 RID: 9128 RVA: 0x0005CBFA File Offset: 0x0005ADFA
		// (set) Token: 0x060023A9 RID: 9129 RVA: 0x0005CC02 File Offset: 0x0005AE02
		[global::System.Xml.Serialization.XmlAttribute]
		public string macro
		{
			get
			{
				return this.macroField;
			}
			set
			{
				this.macroField = value;
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x0005CC0B File Offset: 0x0005AE0B
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x0005CC13 File Offset: 0x0005AE13
		[global::System.Xml.Serialization.XmlAttribute]
		public bool fPublished
		{
			get
			{
				return this.fPublishedField;
			}
			set
			{
				this.fPublishedField = value;
			}
		}

		// Token: 0x04001A7C RID: 6780
		private string macroField;

		// Token: 0x04001A7D RID: 6781
		private bool fPublishedField;

		// Token: 0x04001A7E RID: 6782
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties spPrField;

		// Token: 0x04001A7F RID: 6783
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle styleField;

		// Token: 0x04001A80 RID: 6784
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ConnectorNonVisual nvCxnSpPrField;
	}
}
