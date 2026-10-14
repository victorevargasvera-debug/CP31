using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000096 RID: 150
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FFHelpText
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
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

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000C8B1 File Offset: 0x0000AAB1
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x0000C8B9 File Offset: 0x0000AAB9
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

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000C8C2 File Offset: 0x0000AAC2
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x0000C8CA File Offset: 0x0000AACA
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

		// Token: 0x06000435 RID: 1077 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFHelpText Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFHelpText ct_FFHelpText = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFHelpText();
			if (node.Attributes["w:type"] != null)
			{
				ct_FFHelpText.typeFieldSpecified = true;
				ct_FFHelpText.typeField = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_InfoTextType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_InfoTextType), node.Attributes["w:type"].Value);
			}
			ct_FFHelpText.valField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"]);
			return ct_FFHelpText;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000C950 File Offset: 0x0000AB50
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

		// Token: 0x040003A8 RID: 936
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_InfoTextType typeField;

		// Token: 0x040003A9 RID: 937
		private bool typeFieldSpecified;

		// Token: 0x040003AA RID: 938
		private string valField;
	}
}
