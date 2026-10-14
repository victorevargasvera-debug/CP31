using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001AA RID: 426
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblWidth
	{
		// Token: 0x06000FF5 RID: 4085 RVA: 0x00034604 File Offset: 0x00032804
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth ct_TblWidth = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth();
			ct_TblWidth.w = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:w"]);
			if (node.Attributes["w:type"] != null)
			{
				ct_TblWidth.type = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblWidth)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblWidth), node.Attributes["w:type"].Value);
			}
			return ct_TblWidth;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0003467C File Offset: 0x0003287C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:w", this.w);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:type", this.type.ToString());
			sw.Write("/>");
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x000346D5 File Offset: 0x000328D5
		// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x000346DD File Offset: 0x000328DD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x000346E6 File Offset: 0x000328E6
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x000346EE File Offset: 0x000328EE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblWidth type
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

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x000346F7 File Offset: 0x000328F7
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x000346FF File Offset: 0x000328FF
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

		// Token: 0x04000CDD RID: 3293
		private string wField;

		// Token: 0x04000CDE RID: 3294
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblWidth typeField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblWidth.auto;

		// Token: 0x04000CDF RID: 3295
		private bool typeFieldSpecified = true;
	}
}
