using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000594 RID: 1428
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PageMargins
	{
		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06003EF0 RID: 16112 RVA: 0x0009893A File Offset: 0x00096B3A
		// (set) Token: 0x06003EF1 RID: 16113 RVA: 0x00098942 File Offset: 0x00096B42
		[global::System.Xml.Serialization.XmlAttribute]
		public double left
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

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06003EF2 RID: 16114 RVA: 0x0009894B File Offset: 0x00096B4B
		// (set) Token: 0x06003EF3 RID: 16115 RVA: 0x00098953 File Offset: 0x00096B53
		[global::System.Xml.Serialization.XmlAttribute]
		public double right
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

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06003EF4 RID: 16116 RVA: 0x0009895C File Offset: 0x00096B5C
		// (set) Token: 0x06003EF5 RID: 16117 RVA: 0x00098964 File Offset: 0x00096B64
		[global::System.Xml.Serialization.XmlAttribute]
		public double top
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

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06003EF6 RID: 16118 RVA: 0x0009896D File Offset: 0x00096B6D
		// (set) Token: 0x06003EF7 RID: 16119 RVA: 0x00098975 File Offset: 0x00096B75
		[global::System.Xml.Serialization.XmlAttribute]
		public double bottom
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

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06003EF8 RID: 16120 RVA: 0x0009897E File Offset: 0x00096B7E
		// (set) Token: 0x06003EF9 RID: 16121 RVA: 0x00098986 File Offset: 0x00096B86
		[global::System.Xml.Serialization.XmlAttribute]
		public double header
		{
			get
			{
				return this.headerField;
			}
			set
			{
				this.headerField = value;
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06003EFA RID: 16122 RVA: 0x0009898F File Offset: 0x00096B8F
		// (set) Token: 0x06003EFB RID: 16123 RVA: 0x00098997 File Offset: 0x00096B97
		[global::System.Xml.Serialization.XmlAttribute]
		public double footer
		{
			get
			{
				return this.footerField;
			}
			set
			{
				this.footerField = value;
			}
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x000989A0 File Offset: 0x00096BA0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins
			{
				left = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["left"]),
				right = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["right"]),
				top = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["top"]),
				bottom = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["bottom"]),
				header = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["header"]),
				footer = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["footer"])
			};
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x00098A5C File Offset: 0x00096C5C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "left", this.left, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "right", this.right, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "top", this.top, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "bottom", this.bottom, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "header", this.header, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "footer", this.footer, true);
			sw.Write("/>");
		}

		// Token: 0x040027DE RID: 10206
		private double leftField;

		// Token: 0x040027DF RID: 10207
		private double rightField;

		// Token: 0x040027E0 RID: 10208
		private double topField;

		// Token: 0x040027E1 RID: 10209
		private double bottomField;

		// Token: 0x040027E2 RID: 10210
		private double headerField;

		// Token: 0x040027E3 RID: 10211
		private double footerField;
	}
}
