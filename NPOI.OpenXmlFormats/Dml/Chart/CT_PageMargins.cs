using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003F7 RID: 1015
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PageMargins
	{
		// Token: 0x0600289D RID: 10397 RVA: 0x0006649C File Offset: 0x0006469C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageMargins Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageMargins ct_PageMargins = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageMargins();
			if (node.Attributes["l"] != null)
			{
				ct_PageMargins.l = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["l"]);
			}
			if (node.Attributes["r"] != null)
			{
				ct_PageMargins.r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["r"]);
			}
			if (node.Attributes["t"] != null)
			{
				ct_PageMargins.t = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["t"]);
			}
			if (node.Attributes["b"] != null)
			{
				ct_PageMargins.b = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["b"]);
			}
			if (node.Attributes["header"] != null)
			{
				ct_PageMargins.header = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["header"]);
			}
			if (node.Attributes["footer"] != null)
			{
				ct_PageMargins.footer = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["footer"]);
			}
			return ct_PageMargins;
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x000665C4 File Offset: 0x000647C4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "l", this.l);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.r);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "t", this.t);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "b", this.b);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "header", this.header);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "footer", this.footer);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x00066664 File Offset: 0x00064864
		// (set) Token: 0x060028A0 RID: 10400 RVA: 0x0006666C File Offset: 0x0006486C
		[global::System.Xml.Serialization.XmlAttribute]
		public double l
		{
			get
			{
				return this.lField;
			}
			set
			{
				this.lField = value;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x00066675 File Offset: 0x00064875
		// (set) Token: 0x060028A2 RID: 10402 RVA: 0x0006667D File Offset: 0x0006487D
		[global::System.Xml.Serialization.XmlAttribute]
		public double r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x00066686 File Offset: 0x00064886
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x0006668E File Offset: 0x0006488E
		[global::System.Xml.Serialization.XmlAttribute]
		public double t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x00066697 File Offset: 0x00064897
		// (set) Token: 0x060028A6 RID: 10406 RVA: 0x0006669F File Offset: 0x0006489F
		[global::System.Xml.Serialization.XmlAttribute]
		public double b
		{
			get
			{
				return this.bField;
			}
			set
			{
				this.bField = value;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000666A8 File Offset: 0x000648A8
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x000666B0 File Offset: 0x000648B0
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

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x000666B9 File Offset: 0x000648B9
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x000666C1 File Offset: 0x000648C1
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

		// Token: 0x04001D85 RID: 7557
		private double lField;

		// Token: 0x04001D86 RID: 7558
		private double rField;

		// Token: 0x04001D87 RID: 7559
		private double tField;

		// Token: 0x04001D88 RID: 7560
		private double bField;

		// Token: 0x04001D89 RID: 7561
		private double headerField;

		// Token: 0x04001D8A RID: 7562
		private double footerField;
	}
}
