using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200021E RID: 542
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Proxy
	{
		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x000426C3 File Offset: 0x000408C3
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x000426CB File Offset: 0x000408CB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@false)]
		public global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x000426D4 File Offset: 0x000408D4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startSpecified
		{
			get
			{
				return this.startField > global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x000426DF File Offset: 0x000408DF
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x000426E7 File Offset: 0x000408E7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@false)]
		public global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank end
		{
			get
			{
				return this.endField;
			}
			set
			{
				this.endField = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x000426F0 File Offset: 0x000408F0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endSpecified
		{
			get
			{
				return this.endField > global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x000426FB File Offset: 0x000408FB
		// (set) Token: 0x06001650 RID: 5712 RVA: 0x00042703 File Offset: 0x00040903
		[global::System.Xml.Serialization.XmlAttribute]
		public string idref
		{
			get
			{
				return this.idrefField;
			}
			set
			{
				this.idrefField = value;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x0004270C File Offset: 0x0004090C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool idrefSpecified
		{
			get
			{
				return this.idrefField != null;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x00042717 File Offset: 0x00040917
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x00042724 File Offset: 0x00040924
		[global::System.Xml.Serialization.XmlAttribute]
		public int connectloc
		{
			get
			{
				return this.connectlocField.Value;
			}
			set
			{
				this.connectlocField = new int?(value);
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x00042732 File Offset: 0x00040932
		[global::System.Xml.Serialization.XmlIgnore]
		public bool connectlocSpecified
		{
			get
			{
				return this.connectlocField != null;
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00042740 File Offset: 0x00040940
		public static global::NPOI.OpenXmlFormats.Vml.Office.CT_Proxy Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.Office.CT_Proxy ct_Proxy = new global::NPOI.OpenXmlFormats.Vml.Office.CT_Proxy();
			if (node.Attributes["start"] != null)
			{
				ct_Proxy.start = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalseBlank(node.Attributes["start"]);
			}
			if (node.Attributes["end"] != null)
			{
				ct_Proxy.end = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalseBlank(node.Attributes["end"]);
			}
			ct_Proxy.idref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["idref"]);
			if (node.Attributes["connectloc"] != null)
			{
				ct_Proxy.connectloc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["connectloc"]);
			}
			return ct_Proxy;
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000427FC File Offset: 0x000409FC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<o:{0}", nodeName));
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "start", this.start);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "end", this.end);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "idref", this.idref);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "connectloc", this.connectloc);
			sw.Write(">");
			sw.Write(string.Format("</o:{0}>", nodeName));
		}

		// Token: 0x04001170 RID: 4464
		private global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank startField;

		// Token: 0x04001171 RID: 4465
		private global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank endField;

		// Token: 0x04001172 RID: 4466
		private string idrefField;

		// Token: 0x04001173 RID: 4467
		private int? connectlocField;
	}
}
