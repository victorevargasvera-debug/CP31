using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000377 RID: 887
	public class CT_AbsoluteCellAnchor : global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor
	{
		// Token: 0x0600236A RID: 9066 RVA: 0x0005C270 File Offset: 0x0005A470
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AbsoluteCellAnchor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AbsoluteCellAnchor ct_AbsoluteCellAnchor = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AbsoluteCellAnchor();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pos")
				{
					ct_AbsoluteCellAnchor.pos = global::NPOI.OpenXmlFormats.Dml.CT_Point2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ext")
				{
					ct_AbsoluteCellAnchor.ext = global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sp")
				{
					ct_AbsoluteCellAnchor.sp = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pic")
				{
					ct_AbsoluteCellAnchor.picture = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cxnSp")
				{
					ct_AbsoluteCellAnchor.connector = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grpSp")
				{
					ct_AbsoluteCellAnchor.groupShape = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "graphicFrame")
				{
					ct_AbsoluteCellAnchor.graphicFrame = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "clientData")
				{
					ct_AbsoluteCellAnchor.clientData = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_AbsoluteCellAnchor;
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x0005C3F0 File Offset: 0x0005A5F0
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x0005C3F8 File Offset: 0x0005A5F8
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

		// Token: 0x0600236D RID: 9069 RVA: 0x0005C401 File Offset: 0x0005A601
		public global::NPOI.OpenXmlFormats.Dml.CT_Point2D AddNewOff()
		{
			this.posField = new global::NPOI.OpenXmlFormats.Dml.CT_Point2D();
			return this.posField;
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x0005C414 File Offset: 0x0005A614
		// (set) Token: 0x0600236F RID: 9071 RVA: 0x0005C41C File Offset: 0x0005A61C
		public global::NPOI.OpenXmlFormats.Dml.CT_Point2D pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x0005C425 File Offset: 0x0005A625
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x0005C42D File Offset: 0x0005A62D
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

		// Token: 0x06002372 RID: 9074 RVA: 0x0005C436 File Offset: 0x0005A636
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData AddNewClientData()
		{
			this.clientDataField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData();
			return this.clientDataField;
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x0005C449 File Offset: 0x0005A649
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x0005C451 File Offset: 0x0005A651
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

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x0005C45A File Offset: 0x0005A65A
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x0005C462 File Offset: 0x0005A662
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

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x0005C46B File Offset: 0x0005A66B
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x0005C473 File Offset: 0x0005A673
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

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x0005C47C File Offset: 0x0005A67C
		// (set) Token: 0x0600237A RID: 9082 RVA: 0x0005C484 File Offset: 0x0005A684
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

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x0005C48D File Offset: 0x0005A68D
		// (set) Token: 0x0600237C RID: 9084 RVA: 0x0005C495 File Offset: 0x0005A695
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

		// Token: 0x0600237D RID: 9085 RVA: 0x0005C4A0 File Offset: 0x0005A6A0
		public void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<xdr:absCellAnchor>");
			if (this.pos != null)
			{
				this.pos.Write(sw, "pos");
			}
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
			if (this.clientData != null)
			{
				this.clientData.Write(sw, "clientData");
			}
			sw.Write("</xdr:absCellAnchor>");
		}

		// Token: 0x04001A6A RID: 6762
		private global::NPOI.OpenXmlFormats.Dml.CT_Point2D posField;

		// Token: 0x04001A6B RID: 6763
		private global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D extField;

		// Token: 0x04001A6C RID: 6764
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData clientDataField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData();

		// Token: 0x04001A6D RID: 6765
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape shapeField;

		// Token: 0x04001A6E RID: 6766
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape groupShapeField;

		// Token: 0x04001A6F RID: 6767
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame graphicalObjectField;

		// Token: 0x04001A70 RID: 6768
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector connectorField;

		// Token: 0x04001A71 RID: 6769
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture pictureField;
	}
}
