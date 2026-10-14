using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Vml;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000375 RID: 885
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	public class CT_OneCellAnchor : global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor
	{
		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x0005BF04 File Offset: 0x0005A104
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x0005BF0C File Offset: 0x0005A10C
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker from
		{
			get
			{
				return this.fromField;
			}
			set
			{
				this.fromField = value;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x0005BF15 File Offset: 0x0005A115
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x0005BF1D File Offset: 0x0005A11D
		public global::NPOI.OpenXmlFormats.Vml.CT_AlternateContent alternateContent
		{
			get
			{
				return this.alternateContentField;
			}
			set
			{
				this.alternateContentField = value;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x0005BF26 File Offset: 0x0005A126
		// (set) Token: 0x0600234C RID: 9036 RVA: 0x0005BF2E File Offset: 0x0005A12E
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0005BF37 File Offset: 0x0005A137
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData AddNewClientData()
		{
			this.clientDataField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData();
			return this.clientDataField;
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x0005BF4A File Offset: 0x0005A14A
		// (set) Token: 0x0600234F RID: 9039 RVA: 0x0005BF52 File Offset: 0x0005A152
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData clientData
		{
			get
			{
				return this.clientDataField;
			}
			set
			{
				this.clientDataField = value;
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x0005BF5B File Offset: 0x0005A15B
		// (set) Token: 0x06002351 RID: 9041 RVA: 0x0005BF63 File Offset: 0x0005A163
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape sp
		{
			get
			{
				return this.shapeField;
			}
			set
			{
				this.shapeField = value;
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x0005BF6C File Offset: 0x0005A16C
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x0005BF74 File Offset: 0x0005A174
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape groupShape
		{
			get
			{
				return this.groupShapeField;
			}
			set
			{
				this.groupShapeField = value;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x0005BF7D File Offset: 0x0005A17D
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x0005BF85 File Offset: 0x0005A185
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame graphicFrame
		{
			get
			{
				return this.graphicalObjectField;
			}
			set
			{
				this.graphicalObjectField = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x0005BF8E File Offset: 0x0005A18E
		// (set) Token: 0x06002357 RID: 9047 RVA: 0x0005BF96 File Offset: 0x0005A196
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector connector
		{
			get
			{
				return this.connectorField;
			}
			set
			{
				this.connectorField = value;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x0005BF9F File Offset: 0x0005A19F
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x0005BFA7 File Offset: 0x0005A1A7
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture picture
		{
			get
			{
				return this.pictureField;
			}
			set
			{
				this.pictureField = value;
			}
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x0005BFB0 File Offset: 0x0005A1B0
		public void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<xdr:oneCellAnchor>");
			this.from.Write(sw, "xdr:from");
			this.ext.Write(sw, "xdr:ext");
			if (this.sp != null)
			{
				this.sp.Write(sw, "sp");
			}
			else if (this.connector != null)
			{
				this.connector.Write(sw, "cxnSp");
			}
			else if (this.groupShape != null)
			{
				this.groupShape.Write(sw, "grpSp");
			}
			else if (this.graphicalObjectField != null)
			{
				this.graphicalObjectField.Write(sw, "graphicFrame");
			}
			else if (this.pictureField != null)
			{
				this.picture.Write(sw, "pic");
			}
			if (this.alternateContent != null)
			{
				this.alternateContent.Write(sw, "AlternateContent");
			}
			if (this.clientData != null)
			{
				this.clientData.Write(sw, "clientData");
			}
			sw.Write("</xdr:oneCellAnchor>");
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x0005C0AC File Offset: 0x0005A2AC
		internal static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_OneCellAnchor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_OneCellAnchor ct_OneCellAnchor = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_OneCellAnchor();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "from")
				{
					ct_OneCellAnchor.from = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ext")
				{
					ct_OneCellAnchor.ext = global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sp")
				{
					ct_OneCellAnchor.sp = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pic")
				{
					ct_OneCellAnchor.picture = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cxnSp")
				{
					ct_OneCellAnchor.connector = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grpSp")
				{
					ct_OneCellAnchor.groupShape = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "graphicFrame")
				{
					ct_OneCellAnchor.graphicFrame = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "AlternateContent")
				{
					ct_OneCellAnchor.alternateContent = global::NPOI.OpenXmlFormats.Vml.CT_AlternateContent.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "clientData")
				{
					ct_OneCellAnchor.clientData = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_OneCellAnchor;
		}

		// Token: 0x04001A61 RID: 6753
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker fromField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker();

		// Token: 0x04001A62 RID: 6754
		private global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D extField;

		// Token: 0x04001A63 RID: 6755
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData clientDataField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData();

		// Token: 0x04001A64 RID: 6756
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape shapeField;

		// Token: 0x04001A65 RID: 6757
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape groupShapeField;

		// Token: 0x04001A66 RID: 6758
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame graphicalObjectField;

		// Token: 0x04001A67 RID: 6759
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector connectorField;

		// Token: 0x04001A68 RID: 6760
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture pictureField;

		// Token: 0x04001A69 RID: 6761
		private global::NPOI.OpenXmlFormats.Vml.CT_AlternateContent alternateContentField;
	}
}
