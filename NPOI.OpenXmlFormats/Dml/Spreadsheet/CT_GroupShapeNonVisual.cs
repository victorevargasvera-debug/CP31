using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000365 RID: 869
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_GroupShapeNonVisual
	{
		// Token: 0x06002272 RID: 8818 RVA: 0x00059EEC File Offset: 0x000580EC
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShapeNonVisual Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShapeNonVisual ct_GroupShapeNonVisual = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShapeNonVisual();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cNvPr")
				{
					ct_GroupShapeNonVisual.cNvPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cNvGrpSpPr")
				{
					ct_GroupShapeNonVisual.cNvGrpSpPr = global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GroupShapeNonVisual;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00059F8C File Offset: 0x0005818C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.cNvPr != null)
			{
				this.cNvPr.Write(sw, "cNvPr");
			}
			if (this.cNvGrpSpPr != null)
			{
				this.cNvGrpSpPr.Write(sw, "xdr:cNvGrpSpPr");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x00059FF8 File Offset: 0x000581F8
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps AddNewCNvGrpSpPr()
		{
			this.cNvGrpSpPrField = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps();
			return this.cNvGrpSpPrField;
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x0005A00B File Offset: 0x0005820B
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps AddNewCNvPr()
		{
			this.cNvPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps();
			return this.cNvPrField;
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x0005A01E File Offset: 0x0005821E
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x0005A026 File Offset: 0x00058226
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

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x0005A02F File Offset: 0x0005822F
		// (set) Token: 0x06002279 RID: 8825 RVA: 0x0005A037 File Offset: 0x00058237
		public global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps cNvGrpSpPr
		{
			get
			{
				return this.cNvGrpSpPrField;
			}
			set
			{
				this.cNvGrpSpPrField = value;
			}
		}

		// Token: 0x04001A1A RID: 6682
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001A1B RID: 6683
		private global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps cNvGrpSpPrField;
	}
}
