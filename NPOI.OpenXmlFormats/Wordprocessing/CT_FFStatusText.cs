using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000098 RID: 152
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FFStatusText
	{
		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0000C9AE File Offset: 0x0000ABAE
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0000C9B6 File Offset: 0x0000ABB6
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_InfoTextType type
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

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0000C9BF File Offset: 0x0000ABBF
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0000C9C7 File Offset: 0x0000ABC7
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

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string val
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

		// Token: 0x0600043E RID: 1086 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFStatusText Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFStatusText ct_FFStatusText = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFStatusText();
			if (node.Attributes["w:type"] != null)
			{
				ct_FFStatusText.typeFieldSpecified = true;
				ct_FFStatusText.typeField = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_InfoTextType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_InfoTextType), node.Attributes["w:type"].Value);
			}
			ct_FFStatusText.valField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"]);
			return ct_FFStatusText;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000CA60 File Offset: 0x0000AC60
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.valField);
			if (this.typeFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:type", this.typeField.ToString());
			}
			sw.Write("/>");
		}

		// Token: 0x040003AE RID: 942
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_InfoTextType typeField;

		// Token: 0x040003AF RID: 943
		private bool typeFieldSpecified;

		// Token: 0x040003B0 RID: 944
		private string valField;
	}
}
