using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x0200035F RID: 863
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_Shape
	{
		// Token: 0x0600221C RID: 8732 RVA: 0x00059090 File Offset: 0x00057290
		public void Set(global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape obj)
		{
			this.macroField = obj.macro;
			this.textlinkField = obj.textlink;
			this.fLocksTextField = obj.fLocksText;
			this.fPublishedField = obj.fPublished;
			this.nvSpPrField = obj.nvSpPr;
			this.spPrField = obj.spPr;
			this.styleField = obj.style;
			this.txBodyField = obj.txBody;
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00059100 File Offset: 0x00057300
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ct_Shape = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape();
			ct_Shape.macro = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["macro"]);
			ct_Shape.textlink = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["textlink"]);
			ct_Shape.fLocksText = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fLocksText"]);
			ct_Shape.fPublished = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fPublished"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "nvSpPr")
				{
					ct_Shape.nvSpPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeNonVisual.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_Shape.spPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txBody")
				{
					ct_Shape.txBody = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "style")
				{
					ct_Shape.style = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Shape;
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x00059254 File Offset: 0x00057454
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "macro", this.macro, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "textlink", this.textlink, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fLocksText", this.fLocksText, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fPublished", this.fPublished, false);
			sw.Write(">");
			if (this.nvSpPr != null)
			{
				this.nvSpPr.Write(sw, "nvSpPr");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.style != null)
			{
				this.style.Write(sw, "style");
			}
			if (this.txBody != null)
			{
				this.txBody.Write(sw, "txBody");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x0005933A File Offset: 0x0005753A
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeNonVisual AddNewNvSpPr()
		{
			this.nvSpPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeNonVisual();
			return this.nvSpPrField;
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0005934D File Offset: 0x0005754D
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties AddNewSpPr()
		{
			this.spPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties();
			return this.spPrField;
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x00059360 File Offset: 0x00057560
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle AddNewStyle()
		{
			this.styleField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle();
			return this.styleField;
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x00059373 File Offset: 0x00057573
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TextBody AddNewTxBody()
		{
			this.txBodyField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TextBody();
			return this.txBodyField;
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x00059386 File Offset: 0x00057586
		// (set) Token: 0x06002224 RID: 8740 RVA: 0x0005938E File Offset: 0x0005758E
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeNonVisual nvSpPr
		{
			get
			{
				return this.nvSpPrField;
			}
			set
			{
				this.nvSpPrField = value;
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x00059397 File Offset: 0x00057597
		// (set) Token: 0x06002226 RID: 8742 RVA: 0x0005939F File Offset: 0x0005759F
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

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x000593A8 File Offset: 0x000575A8
		// (set) Token: 0x06002228 RID: 8744 RVA: 0x000593B0 File Offset: 0x000575B0
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TextBody txBody
		{
			get
			{
				return this.txBodyField;
			}
			set
			{
				this.txBodyField = value;
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x000593B9 File Offset: 0x000575B9
		// (set) Token: 0x0600222A RID: 8746 RVA: 0x000593C1 File Offset: 0x000575C1
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

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x000593CA File Offset: 0x000575CA
		// (set) Token: 0x0600222C RID: 8748 RVA: 0x000593D2 File Offset: 0x000575D2
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

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x000593DB File Offset: 0x000575DB
		// (set) Token: 0x0600222E RID: 8750 RVA: 0x000593E3 File Offset: 0x000575E3
		[global::System.Xml.Serialization.XmlAttribute]
		public string textlink
		{
			get
			{
				return this.textlinkField;
			}
			set
			{
				this.textlinkField = value;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x000593EC File Offset: 0x000575EC
		// (set) Token: 0x06002230 RID: 8752 RVA: 0x000593F4 File Offset: 0x000575F4
		[global::System.Xml.Serialization.XmlAttribute]
		public bool fLocksText
		{
			get
			{
				return this.fLocksTextField;
			}
			set
			{
				this.fLocksTextField = value;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x000593FD File Offset: 0x000575FD
		// (set) Token: 0x06002232 RID: 8754 RVA: 0x00059405 File Offset: 0x00057605
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

		// Token: 0x04001A01 RID: 6657
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeNonVisual nvSpPrField;

		// Token: 0x04001A02 RID: 6658
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties spPrField;

		// Token: 0x04001A03 RID: 6659
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle styleField;

		// Token: 0x04001A04 RID: 6660
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TextBody txBodyField;

		// Token: 0x04001A05 RID: 6661
		private string macroField;

		// Token: 0x04001A06 RID: 6662
		private string textlinkField;

		// Token: 0x04001A07 RID: 6663
		private bool fLocksTextField;

		// Token: 0x04001A08 RID: 6664
		private bool fPublishedField;
	}
}
