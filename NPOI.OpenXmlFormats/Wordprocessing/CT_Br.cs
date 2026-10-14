using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200016D RID: 365
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Br
	{
		// Token: 0x06000CA4 RID: 3236 RVA: 0x0002BA88 File Offset: 0x00029C88
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br ct_Br = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br();
			if (node.Attributes["w:type"] != null)
			{
				ct_Br.type = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrType), node.Attributes["w:type"].Value);
			}
			if (node.Attributes["w:clear"] != null)
			{
				ct_Br.clear = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrClear)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrClear), node.Attributes["w:clear"].Value);
			}
			return ct_Br;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0002BB24 File Offset: 0x00029D24
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:clear", this.clear.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x0002BB9C File Offset: 0x00029D9C
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x0002BBA4 File Offset: 0x00029DA4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.typeFieldSpecified = true;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0002BBB4 File Offset: 0x00029DB4
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x0002BBBC File Offset: 0x00029DBC
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

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0002BBC5 File Offset: 0x00029DC5
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x0002BBCD File Offset: 0x00029DCD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrClear clear
		{
			get
			{
				return this.clearField;
			}
			set
			{
				this.clearField = value;
				this.clearFieldSpecified = true;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x0002BBDD File Offset: 0x00029DDD
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x0002BBE5 File Offset: 0x00029DE5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool clearSpecified
		{
			get
			{
				return this.clearFieldSpecified;
			}
			set
			{
				this.clearFieldSpecified = value;
			}
		}

		// Token: 0x04000AF8 RID: 2808
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrType typeField;

		// Token: 0x04000AF9 RID: 2809
		private bool typeFieldSpecified;

		// Token: 0x04000AFA RID: 2810
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrClear clearField;

		// Token: 0x04000AFB RID: 2811
		private bool clearFieldSpecified;
	}
}
