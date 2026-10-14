using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000B6 RID: 182
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MultiLevelType
	{
		// Token: 0x06000512 RID: 1298 RVA: 0x0000E67C File Offset: 0x0000C87C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_MultiLevelType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_MultiLevelType ct_MultiLevelType = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_MultiLevelType();
			if (node.Attributes["w:val"] != null)
			{
				ct_MultiLevelType.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_MultiLevelType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_MultiLevelType), node.Attributes["w:val"].Value);
			}
			return ct_MultiLevelType;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000E6D8 File Offset: 0x0000C8D8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0000E720 File Offset: 0x0000C920
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x0000E728 File Offset: 0x0000C928
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_MultiLevelType val
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

		// Token: 0x0400047A RID: 1146
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_MultiLevelType valField;
	}
}
