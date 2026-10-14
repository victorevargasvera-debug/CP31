using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001DB RID: 475
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Shadow
	{
		// Token: 0x060012C9 RID: 4809 RVA: 0x0003D460 File Offset: 0x0003B660
		public static global::NPOI.OpenXmlFormats.Vml.CT_Shadow Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_Shadow ct_Shadow = new global::NPOI.OpenXmlFormats.Vml.CT_Shadow();
			ct_Shadow.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]);
			if (node.Attributes["on"] != null)
			{
				ct_Shadow.on = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["on"]);
			}
			if (node.Attributes["type"] != null)
			{
				ct_Shadow.type = (global::NPOI.OpenXmlFormats.Vml.ST_ShadowType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_ShadowType), node.Attributes["type"].Value);
			}
			if (node.Attributes["obscured"] != null)
			{
				ct_Shadow.obscured = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["obscured"]);
			}
			ct_Shadow.color = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["color"]);
			ct_Shadow.opacity = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["opacity"]);
			ct_Shadow.offset = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["offset"]);
			ct_Shadow.color2 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["color2"]);
			ct_Shadow.offset2 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["offset2"]);
			ct_Shadow.origin = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["origin"]);
			ct_Shadow.matrix = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["matrix"]);
			return ct_Shadow;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0003D5EC File Offset: 0x0003B7EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "on", this.on);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "obscured", this.obscured);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "color", this.color);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "opacity", this.opacity);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "offset", this.offset);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "color2", this.color2);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "offset2", this.offset2);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "origin", this.origin);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "matrix", this.matrix);
			sw.Write(">");
			sw.Write(string.Format("</v:{0}>", nodeName));
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x0003D6EF File Offset: 0x0003B8EF
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x0003D6F7 File Offset: 0x0003B8F7
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x0003D700 File Offset: 0x0003B900
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x0003D708 File Offset: 0x0003B908
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse on
		{
			get
			{
				return this.onField;
			}
			set
			{
				this.onField = value;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x0003D711 File Offset: 0x0003B911
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x0003D719 File Offset: 0x0003B919
		[global::System.Xml.Serialization.XmlIgnore]
		public bool onSpecified
		{
			get
			{
				return this.onFieldSpecified;
			}
			set
			{
				this.onFieldSpecified = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x0003D722 File Offset: 0x0003B922
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x0003D72A File Offset: 0x0003B92A
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_ShadowType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0003D733 File Offset: 0x0003B933
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x0003D73B File Offset: 0x0003B93B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x0003D744 File Offset: 0x0003B944
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x0003D74C File Offset: 0x0003B94C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse obscured
		{
			get
			{
				return this.obscuredField;
			}
			set
			{
				this.obscuredField = value;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x0003D755 File Offset: 0x0003B955
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x0003D75D File Offset: 0x0003B95D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool obscuredSpecified
		{
			get
			{
				return this.obscuredFieldSpecified;
			}
			set
			{
				this.obscuredFieldSpecified = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x0003D766 File Offset: 0x0003B966
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x0003D76E File Offset: 0x0003B96E
		[global::System.Xml.Serialization.XmlAttribute]
		public string color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x0003D777 File Offset: 0x0003B977
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x0003D77F File Offset: 0x0003B97F
		[global::System.Xml.Serialization.XmlAttribute]
		public string opacity
		{
			get
			{
				return this.opacityField;
			}
			set
			{
				this.opacityField = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x0003D788 File Offset: 0x0003B988
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x0003D790 File Offset: 0x0003B990
		[global::System.Xml.Serialization.XmlAttribute]
		public string offset
		{
			get
			{
				return this.offsetField;
			}
			set
			{
				this.offsetField = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x0003D799 File Offset: 0x0003B999
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x0003D7A1 File Offset: 0x0003B9A1
		[global::System.Xml.Serialization.XmlAttribute]
		public string color2
		{
			get
			{
				return this.color2Field;
			}
			set
			{
				this.color2Field = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x0003D7AA File Offset: 0x0003B9AA
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x0003D7B2 File Offset: 0x0003B9B2
		[global::System.Xml.Serialization.XmlAttribute]
		public string offset2
		{
			get
			{
				return this.offset2Field;
			}
			set
			{
				this.offset2Field = value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x0003D7BB File Offset: 0x0003B9BB
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x0003D7C3 File Offset: 0x0003B9C3
		[global::System.Xml.Serialization.XmlAttribute]
		public string origin
		{
			get
			{
				return this.originField;
			}
			set
			{
				this.originField = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x0003D7CC File Offset: 0x0003B9CC
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x0003D7D4 File Offset: 0x0003B9D4
		[global::System.Xml.Serialization.XmlAttribute]
		public string matrix
		{
			get
			{
				return this.matrixField;
			}
			set
			{
				this.matrixField = value;
			}
		}

		// Token: 0x04000E4C RID: 3660
		private string idField;

		// Token: 0x04000E4D RID: 3661
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse onField;

		// Token: 0x04000E4E RID: 3662
		private bool onFieldSpecified;

		// Token: 0x04000E4F RID: 3663
		private global::NPOI.OpenXmlFormats.Vml.ST_ShadowType typeField;

		// Token: 0x04000E50 RID: 3664
		private bool typeFieldSpecified;

		// Token: 0x04000E51 RID: 3665
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse obscuredField;

		// Token: 0x04000E52 RID: 3666
		private bool obscuredFieldSpecified;

		// Token: 0x04000E53 RID: 3667
		private string colorField;

		// Token: 0x04000E54 RID: 3668
		private string opacityField;

		// Token: 0x04000E55 RID: 3669
		private string offsetField;

		// Token: 0x04000E56 RID: 3670
		private string color2Field;

		// Token: 0x04000E57 RID: 3671
		private string offset2Field;

		// Token: 0x04000E58 RID: 3672
		private string originField;

		// Token: 0x04000E59 RID: 3673
		private string matrixField;
	}
}
