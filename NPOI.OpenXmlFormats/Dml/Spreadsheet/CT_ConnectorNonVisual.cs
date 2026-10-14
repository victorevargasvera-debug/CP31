using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x0200036F RID: 879
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_ConnectorNonVisual
	{
		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x0005B709 File Offset: 0x00059909
		// (set) Token: 0x0600231F RID: 8991 RVA: 0x0005B711 File Offset: 0x00059911
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties cNvCxnSpPr
		{
			get
			{
				return this.cNvCxnSpPrField;
			}
			set
			{
				this.cNvCxnSpPrField = value;
			}
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x0005B71A File Offset: 0x0005991A
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps AddNewCNvPr()
		{
			this.cNvPr = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps();
			return this.cNvPr;
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x0005B72D File Offset: 0x0005992D
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties AddNewCNvCxnSpPr()
		{
			this.cNvCxnSpPr = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties();
			return this.cNvCxnSpPr;
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x0005B740 File Offset: 0x00059940
		// (set) Token: 0x06002323 RID: 8995 RVA: 0x0005B748 File Offset: 0x00059948
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps cNvPr
		{
			get
			{
				return this.cNvPrField;
			}
			set
			{
				this.cNvPrField = value;
			}
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x0005B754 File Offset: 0x00059954
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ConnectorNonVisual Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ConnectorNonVisual ct_ConnectorNonVisual = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ConnectorNonVisual();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cNvCxnSpPr")
				{
					ct_ConnectorNonVisual.cNvCxnSpPr = global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cNvPr")
				{
					ct_ConnectorNonVisual.cNvPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ConnectorNonVisual;
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0005B7F4 File Offset: 0x000599F4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			sw.Write(">");
			if (this.cNvPr != null)
			{
				this.cNvPr.Write(sw, "cNvPr");
			}
			if (this.cNvCxnSpPr != null)
			{
				this.cNvCxnSpPr.Write(sw, "cNvCxnSpPr");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x04001A52 RID: 6738
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001A53 RID: 6739
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties cNvCxnSpPrField;
	}
}
