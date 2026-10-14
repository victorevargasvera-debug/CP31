using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000FA RID: 250
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EastAsianLayout
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x00015A7C File Offset: 0x00013C7C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout ct_EastAsianLayout = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout();
			ct_EastAsianLayout.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			if (node.Attributes["w:combine"] != null)
			{
				ct_EastAsianLayout.combine = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:combine"].Value, true);
			}
			if (node.Attributes["w:combineBrackets"] != null)
			{
				ct_EastAsianLayout.combineBrackets = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_CombineBrackets)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_CombineBrackets), node.Attributes["w:combineBrackets"].Value);
			}
			if (node.Attributes["w:vert"] != null)
			{
				ct_EastAsianLayout.vert = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:vert"].Value, true);
			}
			if (node.Attributes["w:vertCompress"] != null)
			{
				ct_EastAsianLayout.vertCompress = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:vertCompress"].Value, true);
			}
			return ct_EastAsianLayout;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00015BB8 File Offset: 0x00013DB8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:combine", this.combine.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:combineBrackets", this.combineBrackets.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:vert", this.vert.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:vertCompress", this.vertCompress.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00015C7F File Offset: 0x00013E7F
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x00015C87 File Offset: 0x00013E87
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00015C90 File Offset: 0x00013E90
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x00015C98 File Offset: 0x00013E98
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff combine
		{
			get
			{
				return this.combineField;
			}
			set
			{
				this.combineField = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00015CA1 File Offset: 0x00013EA1
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00015CA9 File Offset: 0x00013EA9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool combineSpecified
		{
			get
			{
				return this.combineFieldSpecified;
			}
			set
			{
				this.combineFieldSpecified = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00015CB2 File Offset: 0x00013EB2
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00015CBA File Offset: 0x00013EBA
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_CombineBrackets combineBrackets
		{
			get
			{
				return this.combineBracketsField;
			}
			set
			{
				this.combineBracketsField = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00015CC3 File Offset: 0x00013EC3
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00015CCB File Offset: 0x00013ECB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool combineBracketsSpecified
		{
			get
			{
				return this.combineBracketsFieldSpecified;
			}
			set
			{
				this.combineBracketsFieldSpecified = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00015CD4 File Offset: 0x00013ED4
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00015CDC File Offset: 0x00013EDC
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff vert
		{
			get
			{
				return this.vertField;
			}
			set
			{
				this.vertField = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00015CE5 File Offset: 0x00013EE5
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00015CED File Offset: 0x00013EED
		[global::System.Xml.Serialization.XmlIgnore]
		public bool vertSpecified
		{
			get
			{
				return this.vertFieldSpecified;
			}
			set
			{
				this.vertFieldSpecified = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00015CF6 File Offset: 0x00013EF6
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00015CFE File Offset: 0x00013EFE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff vertCompress
		{
			get
			{
				return this.vertCompressField;
			}
			set
			{
				this.vertCompressField = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00015D07 File Offset: 0x00013F07
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00015D0F File Offset: 0x00013F0F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool vertCompressSpecified
		{
			get
			{
				return this.vertCompressFieldSpecified;
			}
			set
			{
				this.vertCompressFieldSpecified = value;
			}
		}

		// Token: 0x04000610 RID: 1552
		private string idField;

		// Token: 0x04000611 RID: 1553
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff combineField;

		// Token: 0x04000612 RID: 1554
		private bool combineFieldSpecified;

		// Token: 0x04000613 RID: 1555
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_CombineBrackets combineBracketsField;

		// Token: 0x04000614 RID: 1556
		private bool combineBracketsFieldSpecified;

		// Token: 0x04000615 RID: 1557
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff vertField;

		// Token: 0x04000616 RID: 1558
		private bool vertFieldSpecified;

		// Token: 0x04000617 RID: 1559
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff vertCompressField;

		// Token: 0x04000618 RID: 1560
		private bool vertCompressFieldSpecified;
	}
}
