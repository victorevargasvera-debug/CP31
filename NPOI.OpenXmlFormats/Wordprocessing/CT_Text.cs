using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200010F RID: 271
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Text
	{
		// Token: 0x06000766 RID: 1894 RVA: 0x00017390 File Offset: 0x00015590
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text
			{
				space = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["xml:space"]),
				Value = node.InnerText
			};
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000173C4 File Offset: 0x000155C4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			this.space = "preserve";
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xml:space", this.space);
			sw.Write(">");
			if (this.valueField != null)
			{
				sw.Write(global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.valueField));
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00017433 File Offset: 0x00015633
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x0001743B File Offset: 0x0001563B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
		public string space
		{
			get
			{
				return this.spaceField;
			}
			set
			{
				this.spaceField = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00017444 File Offset: 0x00015644
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x0001744C File Offset: 0x0001564C
		[global::System.Xml.Serialization.XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x0400067C RID: 1660
		private string spaceField;

		// Token: 0x0400067D RID: 1661
		private string valueField;
	}
}
