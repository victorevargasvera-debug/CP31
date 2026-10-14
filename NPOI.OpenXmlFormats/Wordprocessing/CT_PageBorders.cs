using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000C7 RID: 199
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PageBorders
	{
		// Token: 0x060005B1 RID: 1457 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageBorders Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageBorders ct_PageBorders = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageBorders();
			if (node.Attributes["w:zOrder"] != null)
			{
				ct_PageBorders.zOrder = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderZOrder)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderZOrder), node.Attributes["w:zOrder"].Value);
			}
			if (node.Attributes["w:display"] != null)
			{
				ct_PageBorders.display = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderDisplay)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderDisplay), node.Attributes["w:display"].Value);
			}
			if (node.Attributes["w:offsetFrom"] != null)
			{
				ct_PageBorders.offsetFrom = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderOffset)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderOffset), node.Attributes["w:offsetFrom"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "top")
				{
					ct_PageBorders.top = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "left")
				{
					ct_PageBorders.left = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bottom")
				{
					ct_PageBorders.bottom = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "right")
				{
					ct_PageBorders.right = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PageBorders;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0000FD70 File Offset: 0x0000DF70
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:zOrder", this.zOrder.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:display", this.display.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:offsetFrom", this.offsetFrom.ToString());
			sw.Write(">");
			if (this.top != null)
			{
				this.top.Write(sw, "top");
			}
			if (this.left != null)
			{
				this.left.Write(sw, "left");
			}
			if (this.bottom != null)
			{
				this.bottom.Write(sw, "bottom");
			}
			if (this.right != null)
			{
				this.right.Write(sw, "right");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0000FE6B File Offset: 0x0000E06B
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x0000FE73 File Offset: 0x0000E073
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border top
		{
			get
			{
				return this.topField;
			}
			set
			{
				this.topField = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0000FE7C File Offset: 0x0000E07C
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x0000FE84 File Offset: 0x0000E084
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border left
		{
			get
			{
				return this.leftField;
			}
			set
			{
				this.leftField = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0000FE8D File Offset: 0x0000E08D
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0000FE95 File Offset: 0x0000E095
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bottom
		{
			get
			{
				return this.bottomField;
			}
			set
			{
				this.bottomField = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0000FE9E File Offset: 0x0000E09E
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x0000FEA6 File Offset: 0x0000E0A6
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border right
		{
			get
			{
				return this.rightField;
			}
			set
			{
				this.rightField = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0000FEAF File Offset: 0x0000E0AF
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x0000FEB7 File Offset: 0x0000E0B7
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderZOrder zOrder
		{
			get
			{
				return this.zOrderField;
			}
			set
			{
				this.zOrderField = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0000FEC0 File Offset: 0x0000E0C0
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool zOrderSpecified
		{
			get
			{
				return this.zOrderFieldSpecified;
			}
			set
			{
				this.zOrderFieldSpecified = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0000FED1 File Offset: 0x0000E0D1
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x0000FED9 File Offset: 0x0000E0D9
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderDisplay display
		{
			get
			{
				return this.displayField;
			}
			set
			{
				this.displayField = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0000FEE2 File Offset: 0x0000E0E2
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x0000FEEA File Offset: 0x0000E0EA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool displaySpecified
		{
			get
			{
				return this.displayFieldSpecified;
			}
			set
			{
				this.displayFieldSpecified = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0000FEF3 File Offset: 0x0000E0F3
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0000FEFB File Offset: 0x0000E0FB
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderOffset offsetFrom
		{
			get
			{
				return this.offsetFromField;
			}
			set
			{
				this.offsetFromField = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0000FF04 File Offset: 0x0000E104
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x0000FF0C File Offset: 0x0000E10C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool offsetFromSpecified
		{
			get
			{
				return this.offsetFromFieldSpecified;
			}
			set
			{
				this.offsetFromFieldSpecified = value;
			}
		}

		// Token: 0x040004CF RID: 1231
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border topField;

		// Token: 0x040004D0 RID: 1232
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border leftField;

		// Token: 0x040004D1 RID: 1233
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bottomField;

		// Token: 0x040004D2 RID: 1234
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border rightField;

		// Token: 0x040004D3 RID: 1235
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderZOrder zOrderField;

		// Token: 0x040004D4 RID: 1236
		private bool zOrderFieldSpecified;

		// Token: 0x040004D5 RID: 1237
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderDisplay displayField;

		// Token: 0x040004D6 RID: 1238
		private bool displayFieldSpecified;

		// Token: 0x040004D7 RID: 1239
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageBorderOffset offsetFromField;

		// Token: 0x040004D8 RID: 1240
		private bool offsetFromFieldSpecified;
	}
}
