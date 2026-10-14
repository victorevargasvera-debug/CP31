using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200019C RID: 412
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AutoCaption
	{
		// Token: 0x06000F7E RID: 3966 RVA: 0x000327E0 File Offset: 0x000309E0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_AutoCaption Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_AutoCaption
			{
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:name"]),
				caption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:caption"])
			};
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00032830 File Offset: 0x00030A30
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:caption", this.caption);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0003288C File Offset: 0x00030A8C
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x00032894 File Offset: 0x00030A94
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0003289D File Offset: 0x00030A9D
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x000328A5 File Offset: 0x00030AA5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string caption
		{
			get
			{
				return this.captionField;
			}
			set
			{
				this.captionField = value;
			}
		}

		// Token: 0x04000CA5 RID: 3237
		private string nameField;

		// Token: 0x04000CA6 RID: 3238
		private string captionField;
	}
}
