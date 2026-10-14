using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000378 RID: 888
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_TwoCellAnchor : global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor
	{
		// Token: 0x0600237F RID: 9087 RVA: 0x0005C58D File Offset: 0x0005A78D
		public CT_TwoCellAnchor()
		{
			this.clientDataField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData();
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0005C5B6 File Offset: 0x0005A7B6
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape AddNewSp()
		{
			this.shapeField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape();
			return this.shapeField;
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x0005C5C9 File Offset: 0x0005A7C9
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape AddNewGrpSp()
		{
			this.groupShapeField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape();
			return this.groupShapeField;
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0005C5DC File Offset: 0x0005A7DC
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame AddNewGraphicFrame()
		{
			this.graphicalObjectField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame();
			return this.graphicalObjectField;
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0005C5EF File Offset: 0x0005A7EF
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector AddNewCxnSp()
		{
			this.connectorField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector();
			return this.connectorField;
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x0005C602 File Offset: 0x0005A802
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture AddNewPic()
		{
			this.pictureField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture();
			return this.pictureField;
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x0005C615 File Offset: 0x0005A815
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData AddNewClientData()
		{
			this.clientDataField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData();
			return this.clientDataField;
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x0005C628 File Offset: 0x0005A828
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x0005C630 File Offset: 0x0005A830
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

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x0005C639 File Offset: 0x0005A839
		// (set) Token: 0x06002389 RID: 9097 RVA: 0x0005C641 File Offset: 0x0005A841
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs editAs
		{
			get
			{
				return this.editAsField;
			}
			set
			{
				this.editAsField = value;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x0005C64A File Offset: 0x0005A84A
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x0005C652 File Offset: 0x0005A852
		[global::System.Xml.Serialization.XmlIgnore]
		public bool editAsSpecified
		{
			get
			{
				return this.editAsSpecifiedField;
			}
			set
			{
				this.editAsSpecifiedField = value;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x0005C65B File Offset: 0x0005A85B
		// (set) Token: 0x0600238D RID: 9101 RVA: 0x0005C663 File Offset: 0x0005A863
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

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x0005C66C File Offset: 0x0005A86C
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x0005C674 File Offset: 0x0005A874
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker to
		{
			get
			{
				return this.toField;
			}
			set
			{
				this.toField = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x0005C67D File Offset: 0x0005A87D
		// (set) Token: 0x06002391 RID: 9105 RVA: 0x0005C685 File Offset: 0x0005A885
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x0005C68E File Offset: 0x0005A88E
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x0005C696 File Offset: 0x0005A896
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x0005C69F File Offset: 0x0005A89F
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x0005C6A7 File Offset: 0x0005A8A7
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x0005C6B0 File Offset: 0x0005A8B0
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x0005C6B8 File Offset: 0x0005A8B8
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x0005C6C1 File Offset: 0x0005A8C1
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x0005C6C9 File Offset: 0x0005A8C9
		[global::System.Xml.Serialization.XmlElement("pic")]
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

		// Token: 0x0600239A RID: 9114 RVA: 0x0005C6D4 File Offset: 0x0005A8D4
		public void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<xdr:twoCellAnchor");
			if (this.editAsField != global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs.NONE)
			{
				sw.Write(string.Format(" editAs=\"{0}\"", this.editAsField.ToString()));
			}
			sw.Write(">");
			this.from.Write(sw, "xdr:from");
			this.to.Write(sw, "xdr:to");
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
			sw.Write("</xdr:twoCellAnchor>");
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x0005C7EC File Offset: 0x0005A9EC
		internal static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor ct_TwoCellAnchor = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor();
			if (node.Attributes["editAs"] != null)
			{
				ct_TwoCellAnchor.editAs = (global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs), node.Attributes["editAs"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "from")
				{
					ct_TwoCellAnchor.from = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "to")
				{
					ct_TwoCellAnchor.to = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sp")
				{
					ct_TwoCellAnchor.sp = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pic")
				{
					ct_TwoCellAnchor.picture = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cxnSp")
				{
					ct_TwoCellAnchor.connector = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grpSp")
				{
					ct_TwoCellAnchor.groupShape = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "graphicFrame")
				{
					ct_TwoCellAnchor.graphicFrame = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "clientData")
				{
					ct_TwoCellAnchor.clientData = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TwoCellAnchor;
		}

		// Token: 0x04001A72 RID: 6770
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker fromField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker();

		// Token: 0x04001A73 RID: 6771
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker toField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker();

		// Token: 0x04001A74 RID: 6772
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape shapeField;

		// Token: 0x04001A75 RID: 6773
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape groupShapeField;

		// Token: 0x04001A76 RID: 6774
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame graphicalObjectField;

		// Token: 0x04001A77 RID: 6775
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector connectorField;

		// Token: 0x04001A78 RID: 6776
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture pictureField;

		// Token: 0x04001A79 RID: 6777
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData clientDataField;

		// Token: 0x04001A7A RID: 6778
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs editAsField;

		// Token: 0x04001A7B RID: 6779
		private bool editAsSpecifiedField;
	}
}
