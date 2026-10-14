using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x0200036C RID: 876
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BlipFillProperties
	{
		// Token: 0x060022CA RID: 8906 RVA: 0x0005ABDA File Offset: 0x00058DDA
		public global::NPOI.OpenXmlFormats.Dml.CT_Blip AddNewBlip()
		{
			this.blipField = new global::NPOI.OpenXmlFormats.Dml.CT_Blip();
			return this.blipField;
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x0005ABED File Offset: 0x00058DED
		public global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties AddNewStretch()
		{
			this.stretchField = new global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties();
			return this.stretchField;
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0005AC00 File Offset: 0x00058E00
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties ct_BlipFillProperties = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties();
			ct_BlipFillProperties.dpi = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dpi"]);
			ct_BlipFillProperties.rotWithShape = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["rotWithShape"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "blip")
				{
					ct_BlipFillProperties.blip = global::NPOI.OpenXmlFormats.Dml.CT_Blip.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srcRect")
				{
					ct_BlipFillProperties.srcRect = global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tile")
				{
					ct_BlipFillProperties.tile = global::NPOI.OpenXmlFormats.Dml.CT_TileInfoProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "stretch")
				{
					ct_BlipFillProperties.stretch = global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_BlipFillProperties;
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0005AD1C File Offset: 0x00058F1C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dpi", this.dpi, false);
			if (this.rotWithShape)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rotWithShape", this.rotWithShape);
			}
			sw.Write(">");
			if (this.blip != null)
			{
				this.blip.Write(sw, "blip");
			}
			if (this.srcRect != null)
			{
				this.srcRect.Write(sw, "srcRect");
			}
			if (this.tile != null)
			{
				this.tile.Write(sw, "tile");
			}
			if (this.stretch != null)
			{
				this.stretch.Write(sw, "stretch");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x0005ADE5 File Offset: 0x00058FE5
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x0005ADED File Offset: 0x00058FED
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Blip blip
		{
			get
			{
				return this.blipField;
			}
			set
			{
				this.blipField = value;
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x0005ADF6 File Offset: 0x00058FF6
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x0005ADFE File Offset: 0x00058FFE
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect srcRect
		{
			get
			{
				return this.srcRectField;
			}
			set
			{
				this.srcRectField = value;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x0005AE07 File Offset: 0x00059007
		// (set) Token: 0x060022D3 RID: 8915 RVA: 0x0005AE0F File Offset: 0x0005900F
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TileInfoProperties tile
		{
			get
			{
				return this.tileField;
			}
			set
			{
				this.tileField = value;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x0005AE18 File Offset: 0x00059018
		// (set) Token: 0x060022D5 RID: 8917 RVA: 0x0005AE20 File Offset: 0x00059020
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties stretch
		{
			get
			{
				return this.stretchField;
			}
			set
			{
				this.stretchField = value;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x0005AE29 File Offset: 0x00059029
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x0005AE31 File Offset: 0x00059031
		[global::System.Xml.Serialization.XmlAttribute]
		public uint dpi
		{
			get
			{
				return this.dpiField;
			}
			set
			{
				this.dpiField = value;
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x0005AE3A File Offset: 0x0005903A
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x0005AE42 File Offset: 0x00059042
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dpiSpecified
		{
			get
			{
				return this.dpiFieldSpecified;
			}
			set
			{
				this.dpiFieldSpecified = value;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x0005AE4B File Offset: 0x0005904B
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x0005AE53 File Offset: 0x00059053
		[global::System.Xml.Serialization.XmlAttribute]
		public bool rotWithShape
		{
			get
			{
				return this.rotWithShapeField;
			}
			set
			{
				this.rotWithShapeField = value;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x0005AE5C File Offset: 0x0005905C
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x0005AE64 File Offset: 0x00059064
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rotWithShapeSpecified
		{
			get
			{
				return this.rotWithShapeFieldSpecified;
			}
			set
			{
				this.rotWithShapeFieldSpecified = value;
			}
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x0005AE6D File Offset: 0x0005906D
		public bool IsSetBlip()
		{
			return this.blipField != null;
		}

		// Token: 0x04001A35 RID: 6709
		private global::NPOI.OpenXmlFormats.Dml.CT_Blip blipField;

		// Token: 0x04001A36 RID: 6710
		private global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect srcRectField;

		// Token: 0x04001A37 RID: 6711
		private global::NPOI.OpenXmlFormats.Dml.CT_TileInfoProperties tileField;

		// Token: 0x04001A38 RID: 6712
		private global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties stretchField;

		// Token: 0x04001A39 RID: 6713
		private uint dpiField;

		// Token: 0x04001A3A RID: 6714
		private bool dpiFieldSpecified;

		// Token: 0x04001A3B RID: 6715
		private bool rotWithShapeField;

		// Token: 0x04001A3C RID: 6716
		private bool rotWithShapeFieldSpecified;
	}
}
