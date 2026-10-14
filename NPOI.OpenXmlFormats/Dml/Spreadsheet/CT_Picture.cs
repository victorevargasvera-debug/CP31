using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000366 RID: 870
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_Picture
	{
		// Token: 0x0600227B RID: 8827 RVA: 0x0005A040 File Offset: 0x00058240
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture ct_Picture = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture();
			ct_Picture.macro = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["macro"]);
			ct_Picture.fPublished = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fPublished"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "nvPicPr")
				{
					ct_Picture.nvPicPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_PictureNonVisual.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "blipFill")
				{
					ct_Picture.blipFill = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_Picture.spPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "style")
				{
					ct_Picture.style = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Picture;
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x0005A15C File Offset: 0x0005835C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "macro", this.macro);
			if (this.fPublished)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fPublished", this.fPublished);
			}
			sw.Write(">");
			if (this.nvPicPr != null)
			{
				this.nvPicPr.Write(sw, "nvPicPr");
			}
			if (this.blipFill != null)
			{
				this.blipFill.Write(sw, "blipFill");
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

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x0005A224 File Offset: 0x00058424
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x0005A22C File Offset: 0x0005842C
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_PictureNonVisual nvPicPr
		{
			get
			{
				return this.nvPicPrField;
			}
			set
			{
				this.nvPicPrField = value;
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x0005A235 File Offset: 0x00058435
		// (set) Token: 0x06002280 RID: 8832 RVA: 0x0005A23D File Offset: 0x0005843D
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties blipFill
		{
			get
			{
				return this.blipFillField;
			}
			set
			{
				this.blipFillField = value;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x0005A246 File Offset: 0x00058446
		// (set) Token: 0x06002282 RID: 8834 RVA: 0x0005A24E File Offset: 0x0005844E
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x0005A257 File Offset: 0x00058457
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x0005A25F File Offset: 0x0005845F
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x0005A268 File Offset: 0x00058468
		// (set) Token: 0x06002286 RID: 8838 RVA: 0x0005A270 File Offset: 0x00058470
		[global::System.Xml.Serialization.XmlIgnore]
		public bool styleSpecified
		{
			get
			{
				return this.styleSpecifiedField;
			}
			set
			{
				this.styleSpecifiedField = value;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x0005A279 File Offset: 0x00058479
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x0005A281 File Offset: 0x00058481
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

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x0005A28A File Offset: 0x0005848A
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x0005A292 File Offset: 0x00058492
		[global::System.Xml.Serialization.XmlIgnore]
		public bool macroSpecified
		{
			get
			{
				return this.macroSpecifiedField;
			}
			set
			{
				this.macroSpecifiedField = value;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x0005A29B File Offset: 0x0005849B
		// (set) Token: 0x0600228C RID: 8844 RVA: 0x0005A2A3 File Offset: 0x000584A3
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

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x0005A2AC File Offset: 0x000584AC
		// (set) Token: 0x0600228E RID: 8846 RVA: 0x0005A2B4 File Offset: 0x000584B4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fPublishedSpecified
		{
			get
			{
				return this.fPublishedSpecifiedField;
			}
			set
			{
				this.fPublishedSpecifiedField = value;
			}
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x0005A2BD File Offset: 0x000584BD
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_PictureNonVisual AddNewNvPicPr()
		{
			this.nvPicPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_PictureNonVisual();
			return this.nvPicPrField;
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x0005A2D0 File Offset: 0x000584D0
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties AddNewBlipFill()
		{
			this.blipFillField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties();
			return this.blipFillField;
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x0005A2E3 File Offset: 0x000584E3
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties AddNewSpPr()
		{
			this.spPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties();
			return this.spPrField;
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x0005A2F8 File Offset: 0x000584F8
		public void Set(global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture pict)
		{
			this.nvPicPr = pict.nvPicPr;
			this.spPr = pict.spPr;
			this.macro = pict.macro;
			this.macroSpecified = this.macroSpecified;
			this.style = pict.style;
			this.styleSpecified = pict.styleSpecified;
			this.fPublished = pict.fPublished;
			this.fPublishedSpecified = pict.fPublishedSpecified;
			this.blipFill = pict.blipFill;
		}

		// Token: 0x04001A1C RID: 6684
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_PictureNonVisual nvPicPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_PictureNonVisual();

		// Token: 0x04001A1D RID: 6685
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties blipFillField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties();

		// Token: 0x04001A1E RID: 6686
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties spPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties();

		// Token: 0x04001A1F RID: 6687
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle styleField;

		// Token: 0x04001A20 RID: 6688
		private string macroField;

		// Token: 0x04001A21 RID: 6689
		private bool fPublishedField;

		// Token: 0x04001A22 RID: 6690
		private bool styleSpecifiedField;

		// Token: 0x04001A23 RID: 6691
		private bool macroSpecifiedField;

		// Token: 0x04001A24 RID: 6692
		private bool fPublishedSpecifiedField;
	}
}
