using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000E0 RID: 224
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtListItem
	{
		// Token: 0x06000667 RID: 1639 RVA: 0x00014C44 File Offset: 0x00012E44
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtListItem Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtListItem
			{
				displayText = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:displayText"]),
				value = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:value"])
			};
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00014C94 File Offset: 0x00012E94
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:displayText", this.displayText);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:value", this.value);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00014CF0 File Offset: 0x00012EF0
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00014CF8 File Offset: 0x00012EF8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string displayText
		{
			get
			{
				return this.displayTextField;
			}
			set
			{
				this.displayTextField = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00014D01 File Offset: 0x00012F01
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00014D09 File Offset: 0x00012F09
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string value
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

		// Token: 0x04000588 RID: 1416
		private string displayTextField;

		// Token: 0x04000589 RID: 1417
		private string valueField;
	}
}
