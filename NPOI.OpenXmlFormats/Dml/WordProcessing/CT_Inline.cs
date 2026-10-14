using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x0200034F RID: 847
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot("inline", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Inline
	{
		// Token: 0x06002158 RID: 8536 RVA: 0x00057C58 File Offset: 0x00055E58
		public static global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline ct_Inline = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline();
			ct_Inline.distT = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["wp:distT"]);
			ct_Inline.distB = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["wp:distB"]);
			ct_Inline.distL = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["wp:distL"]);
			ct_Inline.distR = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["wp:distR"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extent")
				{
					ct_Inline.extent = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PositiveSize2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "effectExtent")
				{
					ct_Inline.effectExtent = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "docPr")
				{
					ct_Inline.docPr = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cNvGraphicFramePr")
				{
					ct_Inline.cNvGraphicFramePr = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualGraphicFrameProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "graphic")
				{
					ct_Inline.graphic = global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Inline;
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00057DD0 File Offset: 0x00055FD0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<wp:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "distT", this.distT, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "distB", this.distB, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "distL", this.distL, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "distR", this.distR, true);
			sw.Write(">");
			if (this.extent != null)
			{
				this.extent.Write(sw, "extent");
			}
			if (this.effectExtent != null)
			{
				this.effectExtent.Write(sw, "effectExtent");
			}
			if (this.docPr != null)
			{
				this.docPr.Write(sw, "docPr");
			}
			if (this.cNvGraphicFramePr != null)
			{
				this.cNvGraphicFramePr.Write(sw, "cNvGraphicFramePr");
			}
			if (this.graphic != null)
			{
				this.graphic.Write(sw, "graphic");
			}
			sw.Write(string.Format("</wp:{0}>", nodeName));
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x00057ECF File Offset: 0x000560CF
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x00057ED7 File Offset: 0x000560D7
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PositiveSize2D extent
		{
			get
			{
				return this.extentField;
			}
			set
			{
				this.extentField = value;
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x00057EE0 File Offset: 0x000560E0
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x00057EE8 File Offset: 0x000560E8
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent effectExtent
		{
			get
			{
				return this.effectExtentField;
			}
			set
			{
				this.effectExtentField = value;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x00057EF1 File Offset: 0x000560F1
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x00057EF9 File Offset: 0x000560F9
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps docPr
		{
			get
			{
				return this.docPrField;
			}
			set
			{
				this.docPrField = value;
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x00057F02 File Offset: 0x00056102
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x00057F0A File Offset: 0x0005610A
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualGraphicFrameProperties cNvGraphicFramePr
		{
			get
			{
				return this.cNvGraphicFramePrField;
			}
			set
			{
				this.cNvGraphicFramePrField = value;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x00057F13 File Offset: 0x00056113
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x00057F1B File Offset: 0x0005611B
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 4)]
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

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x00057F24 File Offset: 0x00056124
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x00057F2C File Offset: 0x0005612C
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distT
		{
			get
			{
				return this.distTField;
			}
			set
			{
				this.distTField = value;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x00057F35 File Offset: 0x00056135
		// (set) Token: 0x06002168 RID: 8552 RVA: 0x00057F3D File Offset: 0x0005613D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distTSpecified
		{
			get
			{
				return this.distTFieldSpecified;
			}
			set
			{
				this.distTFieldSpecified = value;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x00057F46 File Offset: 0x00056146
		// (set) Token: 0x0600216A RID: 8554 RVA: 0x00057F4E File Offset: 0x0005614E
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distB
		{
			get
			{
				return this.distBField;
			}
			set
			{
				this.distBField = value;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x00057F57 File Offset: 0x00056157
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x00057F5F File Offset: 0x0005615F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distBSpecified
		{
			get
			{
				return this.distBFieldSpecified;
			}
			set
			{
				this.distBFieldSpecified = value;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x00057F68 File Offset: 0x00056168
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x00057F70 File Offset: 0x00056170
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distL
		{
			get
			{
				return this.distLField;
			}
			set
			{
				this.distLField = value;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x00057F79 File Offset: 0x00056179
		// (set) Token: 0x06002170 RID: 8560 RVA: 0x00057F81 File Offset: 0x00056181
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distLSpecified
		{
			get
			{
				return this.distLFieldSpecified;
			}
			set
			{
				this.distLFieldSpecified = value;
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x00057F8A File Offset: 0x0005618A
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x00057F92 File Offset: 0x00056192
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distR
		{
			get
			{
				return this.distRField;
			}
			set
			{
				this.distRField = value;
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x00057F9B File Offset: 0x0005619B
		// (set) Token: 0x06002174 RID: 8564 RVA: 0x00057FA3 File Offset: 0x000561A3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distRSpecified
		{
			get
			{
				return this.distRFieldSpecified;
			}
			set
			{
				this.distRFieldSpecified = value;
			}
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00057FAC File Offset: 0x000561AC
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PositiveSize2D AddNewExtent()
		{
			if (this.extentField == null)
			{
				this.extentField = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PositiveSize2D();
			}
			return this.extentField;
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00057FC7 File Offset: 0x000561C7
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps AddNewDocPr()
		{
			if (this.docPrField == null)
			{
				this.docPrField = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps();
			}
			return this.docPrField;
		}

		// Token: 0x04001988 RID: 6536
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PositiveSize2D extentField;

		// Token: 0x04001989 RID: 6537
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent effectExtentField;

		// Token: 0x0400198A RID: 6538
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps docPrField;

		// Token: 0x0400198B RID: 6539
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualGraphicFrameProperties cNvGraphicFramePrField;

		// Token: 0x0400198C RID: 6540
		private global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject graphicField;

		// Token: 0x0400198D RID: 6541
		private uint distTField;

		// Token: 0x0400198E RID: 6542
		private bool distTFieldSpecified;

		// Token: 0x0400198F RID: 6543
		private uint distBField;

		// Token: 0x04001990 RID: 6544
		private bool distBFieldSpecified;

		// Token: 0x04001991 RID: 6545
		private uint distLField;

		// Token: 0x04001992 RID: 6546
		private bool distLFieldSpecified;

		// Token: 0x04001993 RID: 6547
		private uint distRField;

		// Token: 0x04001994 RID: 6548
		private bool distRFieldSpecified;
	}
}
