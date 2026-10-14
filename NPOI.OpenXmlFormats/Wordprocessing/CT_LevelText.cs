using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000BB RID: 187
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LevelText
	{
		// Token: 0x0600053F RID: 1343 RVA: 0x0000EDAC File Offset: 0x0000CFAC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelText Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelText ct_LevelText = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelText();
			ct_LevelText.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"]);
			if (node.Attributes["w:null"] != null)
			{
				ct_LevelText.@null = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:null"].Value, true);
			}
			return ct_LevelText;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000EE24 File Offset: 0x0000D024
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val);
			if (this.@null != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:null", this.@null.ToString());
			}
			sw.Write("/>");
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0000EE85 File Offset: 0x0000D085
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x0000EE8D File Offset: 0x0000D08D
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

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0000EE96 File Offset: 0x0000D096
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x0000EE9E File Offset: 0x0000D09E
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff @null
		{
			get
			{
				return this.nullField;
			}
			set
			{
				this.nullField = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0000EEA7 File Offset: 0x0000D0A7
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x0000EEAF File Offset: 0x0000D0AF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool nullSpecified
		{
			get
			{
				return this.nullFieldSpecified;
			}
			set
			{
				this.nullFieldSpecified = value;
			}
		}

		// Token: 0x04000494 RID: 1172
		private string valField;

		// Token: 0x04000495 RID: 1173
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff nullField;

		// Token: 0x04000496 RID: 1174
		private bool nullFieldSpecified;
	}
}
