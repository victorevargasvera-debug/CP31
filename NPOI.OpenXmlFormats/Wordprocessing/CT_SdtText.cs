using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000E7 RID: 231
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtText
	{
		// Token: 0x06000694 RID: 1684 RVA: 0x000152A4 File Offset: 0x000134A4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtText Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtText ct_SdtText = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtText();
			if (node.Attributes["w:multiLine"] != null)
			{
				ct_SdtText.multiLine = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:multiLine"].Value, true);
			}
			return ct_SdtText;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00015300 File Offset: 0x00013500
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:multiLine", this.multiLine.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00015359 File Offset: 0x00013559
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00015361 File Offset: 0x00013561
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff multiLine
		{
			get
			{
				return this.multiLineField;
			}
			set
			{
				this.multiLineField = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0001536A File Offset: 0x0001356A
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x00015372 File Offset: 0x00013572
		[global::System.Xml.Serialization.XmlIgnore]
		public bool multiLineSpecified
		{
			get
			{
				return this.multiLineFieldSpecified;
			}
			set
			{
				this.multiLineFieldSpecified = value;
			}
		}

		// Token: 0x040005A6 RID: 1446
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff multiLineField;

		// Token: 0x040005A7 RID: 1447
		private bool multiLineFieldSpecified;
	}
}
