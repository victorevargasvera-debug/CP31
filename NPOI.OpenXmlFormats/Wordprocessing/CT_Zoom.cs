using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000179 RID: 377
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Zoom
	{
		// Token: 0x06000DB7 RID: 3511 RVA: 0x0002E5AE File Offset: 0x0002C7AE
		public CT_Zoom()
		{
			this.valField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Zoom.none;
			this.percent = "100";
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0002E5C8 File Offset: 0x0002C7C8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Zoom Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Zoom ct_Zoom = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Zoom();
			if (node.Attributes["w:val"] != null)
			{
				ct_Zoom.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Zoom)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Zoom), node.Attributes["w:val"].Value);
			}
			ct_Zoom.percent = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:percent"]);
			return ct_Zoom;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0002E640 File Offset: 0x0002C840
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (this.val != global::NPOI.OpenXmlFormats.Wordprocessing.ST_Zoom.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:percent", this.percent);
			sw.Write("/>");
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x0002E6A1 File Offset: 0x0002C8A1
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x0002E6A9 File Offset: 0x0002C8A9
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Zoom val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0002E6B2 File Offset: 0x0002C8B2
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x0002E6BA File Offset: 0x0002C8BA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valSpecified
		{
			get
			{
				return this.valFieldSpecified;
			}
			set
			{
				this.valFieldSpecified = value;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x0002E6C3 File Offset: 0x0002C8C3
		// (set) Token: 0x06000DBF RID: 3519 RVA: 0x0002E6CB File Offset: 0x0002C8CB
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
			}
		}

		// Token: 0x04000B9C RID: 2972
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Zoom valField;

		// Token: 0x04000B9D RID: 2973
		private bool valFieldSpecified;

		// Token: 0x04000B9E RID: 2974
		private string percentField;
	}
}
