using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000B1 RID: 177
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NumRestart
	{
		// Token: 0x060004E1 RID: 1249 RVA: 0x0000DE1C File Offset: 0x0000C01C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumRestart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumRestart ct_NumRestart = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumRestart();
			if (node.Attributes["w:val"] != null)
			{
				ct_NumRestart.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_RestartNumber)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_RestartNumber), node.Attributes["w:val"].Value);
			}
			return ct_NumRestart;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000DE78 File Offset: 0x0000C078
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0000DED1 File Offset: 0x0000C0D1
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0000DED9 File Offset: 0x0000C0D9
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_RestartNumber val
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

		// Token: 0x04000467 RID: 1127
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_RestartNumber valField;
	}
}
