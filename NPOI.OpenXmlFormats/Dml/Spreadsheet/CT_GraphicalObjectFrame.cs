using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x0200036E RID: 878
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_GraphicalObjectFrame
	{
		// Token: 0x0600230D RID: 8973 RVA: 0x0005B49C File Offset: 0x0005969C
		public void Set(global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame obj)
		{
			this.xfrmField = obj.xfrmField;
			this.graphicField = obj.graphicField;
			this.nvGraphicFramePrField = obj.nvGraphicFramePrField;
			this.macroField = obj.macroField;
			this.fPublishedField = obj.fPublishedField;
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x0005B4DA File Offset: 0x000596DA
		public global::NPOI.OpenXmlFormats.Dml.CT_Transform2D AddNewXfrm()
		{
			this.xfrmField = new global::NPOI.OpenXmlFormats.Dml.CT_Transform2D();
			return this.xfrmField;
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x0005B4ED File Offset: 0x000596ED
		public global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject AddNewGraphic()
		{
			this.graphicField = new global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject();
			return this.graphicField;
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x0005B500 File Offset: 0x00059700
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrameNonVisual AddNewNvGraphicFramePr()
		{
			this.nvGraphicFramePr = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrameNonVisual();
			return this.nvGraphicFramePr;
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x0005B513 File Offset: 0x00059713
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x0005B51B File Offset: 0x0005971B
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrameNonVisual nvGraphicFramePr
		{
			get
			{
				return this.nvGraphicFramePrField;
			}
			set
			{
				this.nvGraphicFramePrField = value;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x0005B524 File Offset: 0x00059724
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x0005B52C File Offset: 0x0005972C
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.CT_Transform2D xfrm
		{
			get
			{
				return this.xfrmField;
			}
			set
			{
				this.xfrmField = value;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x0005B535 File Offset: 0x00059735
		// (set) Token: 0x06002316 RID: 8982 RVA: 0x0005B53D File Offset: 0x0005973D
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

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x0005B546 File Offset: 0x00059746
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x0005B54E File Offset: 0x0005974E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
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

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x0005B557 File Offset: 0x00059757
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x0005B55F File Offset: 0x0005975F
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject graphic
		{
			get
			{
				return this.graphicField;
			}
			set
			{
				this.graphicField = value;
			}
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0005B568 File Offset: 0x00059768
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame ct_GraphicalObjectFrame = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame();
			ct_GraphicalObjectFrame.macro = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["macro"]);
			ct_GraphicalObjectFrame.fPublished = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fPublished"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "nvGraphicFramePr")
				{
					ct_GraphicalObjectFrame.nvGraphicFramePr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrameNonVisual.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "xfrm")
				{
					ct_GraphicalObjectFrame.xfrm = global::NPOI.OpenXmlFormats.Dml.CT_Transform2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "graphic")
				{
					ct_GraphicalObjectFrame.graphic = global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GraphicalObjectFrame;
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0005B660 File Offset: 0x00059860
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "macro", this.macro, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fPublished", this.fPublished, false);
			sw.Write(">");
			if (this.nvGraphicFramePr != null)
			{
				this.nvGraphicFramePr.Write(sw, "nvGraphicFramePr");
			}
			if (this.xfrm != null)
			{
				this.xfrm.Write(sw, "xdr:xfrm");
			}
			if (this.graphic != null)
			{
				this.graphic.Write(sw, "graphic");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x04001A4D RID: 6733
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrameNonVisual nvGraphicFramePrField;

		// Token: 0x04001A4E RID: 6734
		private global::NPOI.OpenXmlFormats.Dml.CT_Transform2D xfrmField;

		// Token: 0x04001A4F RID: 6735
		private global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject graphicField;

		// Token: 0x04001A50 RID: 6736
		private string macroField;

		// Token: 0x04001A51 RID: 6737
		private bool fPublishedField;
	}
}
