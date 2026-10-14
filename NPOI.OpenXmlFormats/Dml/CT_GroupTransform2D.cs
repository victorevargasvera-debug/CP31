using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002C1 RID: 705
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GroupTransform2D
	{
		// Token: 0x06001BF3 RID: 7155 RVA: 0x0004D003 File Offset: 0x0004B203
		public CT_GroupTransform2D()
		{
			this.rotField = 0;
			this.flipHField = false;
			this.flipVField = false;
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0004D020 File Offset: 0x0004B220
		public static global::NPOI.OpenXmlFormats.Dml.CT_GroupTransform2D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_GroupTransform2D ct_GroupTransform2D = new global::NPOI.OpenXmlFormats.Dml.CT_GroupTransform2D();
			ct_GroupTransform2D.rot = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["rot"]);
			ct_GroupTransform2D.flipH = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["flipH"]);
			ct_GroupTransform2D.flipV = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["flipV"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "off")
				{
					ct_GroupTransform2D.off = global::NPOI.OpenXmlFormats.Dml.CT_Point2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ext")
				{
					ct_GroupTransform2D.ext = global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "chOff")
				{
					ct_GroupTransform2D.chOff = global::NPOI.OpenXmlFormats.Dml.CT_Point2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "chExt")
				{
					ct_GroupTransform2D.chExt = global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GroupTransform2D;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0004D158 File Offset: 0x0004B358
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rot", this.rot);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "flipH", this.flipH, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "flipV", this.flipV, false);
			sw.Write(">");
			if (this.off != null)
			{
				this.off.Write(sw, "off");
			}
			if (this.ext != null)
			{
				this.ext.Write(sw, "a:ext");
			}
			if (this.chOff != null)
			{
				this.chOff.Write(sw, "chOff");
			}
			if (this.chExt != null)
			{
				this.chExt.Write(sw, "a:chExt");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0004D22B File Offset: 0x0004B42B
		public global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D AddNewExt()
		{
			this.extField = new global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D();
			return this.extField;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0004D23E File Offset: 0x0004B43E
		public global::NPOI.OpenXmlFormats.Dml.CT_Point2D AddNewOff()
		{
			this.offField = new global::NPOI.OpenXmlFormats.Dml.CT_Point2D();
			return this.offField;
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0004D251 File Offset: 0x0004B451
		public global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D AddNewChExt()
		{
			this.chExtField = new global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D();
			return this.chExtField;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0004D264 File Offset: 0x0004B464
		public global::NPOI.OpenXmlFormats.Dml.CT_Point2D AddNewChOff()
		{
			this.chOffField = new global::NPOI.OpenXmlFormats.Dml.CT_Point2D();
			return this.chOffField;
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x0004D277 File Offset: 0x0004B477
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x0004D27F File Offset: 0x0004B47F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Point2D off
		{
			get
			{
				return this.offField;
			}
			set
			{
				this.offField = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x0004D288 File Offset: 0x0004B488
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x0004D290 File Offset: 0x0004B490
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x0004D299 File Offset: 0x0004B499
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x0004D2A1 File Offset: 0x0004B4A1
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Point2D chOff
		{
			get
			{
				return this.chOffField;
			}
			set
			{
				this.chOffField = value;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x0004D2AA File Offset: 0x0004B4AA
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x0004D2B2 File Offset: 0x0004B4B2
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D chExt
		{
			get
			{
				return this.chExtField;
			}
			set
			{
				this.chExtField = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x0004D2BB File Offset: 0x0004B4BB
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x0004D2C3 File Offset: 0x0004B4C3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int rot
		{
			get
			{
				return this.rotField;
			}
			set
			{
				this.rotField = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x0004D2CC File Offset: 0x0004B4CC
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x0004D2D4 File Offset: 0x0004B4D4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool flipH
		{
			get
			{
				return this.flipHField;
			}
			set
			{
				this.flipHField = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x0004D2DD File Offset: 0x0004B4DD
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x0004D2E5 File Offset: 0x0004B4E5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool flipV
		{
			get
			{
				return this.flipVField;
			}
			set
			{
				this.flipVField = value;
			}
		}

		// Token: 0x040015E7 RID: 5607
		private global::NPOI.OpenXmlFormats.Dml.CT_Point2D offField;

		// Token: 0x040015E8 RID: 5608
		private global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D extField;

		// Token: 0x040015E9 RID: 5609
		private global::NPOI.OpenXmlFormats.Dml.CT_Point2D chOffField;

		// Token: 0x040015EA RID: 5610
		private global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D chExtField;

		// Token: 0x040015EB RID: 5611
		private int rotField;

		// Token: 0x040015EC RID: 5612
		private bool flipHField;

		// Token: 0x040015ED RID: 5613
		private bool flipVField;
	}
}
