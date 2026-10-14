using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000E3 RID: 227
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CalendarType
	{
		// Token: 0x06000675 RID: 1653 RVA: 0x00014DEC File Offset: 0x00012FEC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_CalendarType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_CalendarType ct_CalendarType = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_CalendarType();
			if (node.Attributes["w:val"] != null)
			{
				ct_CalendarType.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_CalendarType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_CalendarType), node.Attributes["w:val"].Value);
			}
			return ct_CalendarType;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00014E48 File Offset: 0x00013048
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00014EA1 File Offset: 0x000130A1
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00014EA9 File Offset: 0x000130A9
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_CalendarType val
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

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00014EB2 File Offset: 0x000130B2
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00014EBA File Offset: 0x000130BA
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

		// Token: 0x04000590 RID: 1424
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_CalendarType valField;

		// Token: 0x04000591 RID: 1425
		private bool valFieldSpecified;
	}
}
