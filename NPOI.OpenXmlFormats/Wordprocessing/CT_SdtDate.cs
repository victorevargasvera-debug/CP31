using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000E5 RID: 229
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtDate
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x00014EC4 File Offset: 0x000130C4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDate Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDate ct_SdtDate = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDate();
			ct_SdtDate.fullDateField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w.fullDate"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "dateFormat")
				{
					ct_SdtDate.dateFormat = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lid")
				{
					ct_SdtDate.lid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lang.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "storeMappedDataAs")
				{
					ct_SdtDate.storeMappedDataAs = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDateMappingType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "calendar")
				{
					ct_SdtDate.calendar = global::NPOI.OpenXmlFormats.Wordprocessing.CT_CalendarType.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SdtDate;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00014FC8 File Offset: 0x000131C8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:fullDate", this.fullDateField);
			sw.Write(">");
			if (this.dateFormat != null)
			{
				this.dateFormat.Write(sw, "dateFormat");
			}
			if (this.lid != null)
			{
				this.lid.Write(sw, "lid");
			}
			if (this.storeMappedDataAs != null)
			{
				this.storeMappedDataAs.Write(sw, "storeMappedDataAs");
			}
			if (this.calendar != null)
			{
				this.calendar.Write(sw, "calendar");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00015077 File Offset: 0x00013277
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x0001507F File Offset: 0x0001327F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String dateFormat
		{
			get
			{
				return this.dateFormatField;
			}
			set
			{
				this.dateFormatField = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x00015088 File Offset: 0x00013288
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00015090 File Offset: 0x00013290
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lang lid
		{
			get
			{
				return this.lidField;
			}
			set
			{
				this.lidField = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00015099 File Offset: 0x00013299
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x000150A1 File Offset: 0x000132A1
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDateMappingType storeMappedDataAs
		{
			get
			{
				return this.storeMappedDataAsField;
			}
			set
			{
				this.storeMappedDataAsField = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x000150AA File Offset: 0x000132AA
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x000150B2 File Offset: 0x000132B2
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_CalendarType calendar
		{
			get
			{
				return this.calendarField;
			}
			set
			{
				this.calendarField = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x000150BB File Offset: 0x000132BB
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x000150C3 File Offset: 0x000132C3
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string fullDate
		{
			get
			{
				return this.fullDateField;
			}
			set
			{
				this.fullDateField = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x000150CC File Offset: 0x000132CC
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x000150D4 File Offset: 0x000132D4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fullDateSpecified
		{
			get
			{
				return this.fullDateFieldSpecified;
			}
			set
			{
				this.fullDateFieldSpecified = value;
			}
		}

		// Token: 0x0400059D RID: 1437
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String dateFormatField;

		// Token: 0x0400059E RID: 1438
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lang lidField;

		// Token: 0x0400059F RID: 1439
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDateMappingType storeMappedDataAsField;

		// Token: 0x040005A0 RID: 1440
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_CalendarType calendarField;

		// Token: 0x040005A1 RID: 1441
		private string fullDateField;

		// Token: 0x040005A2 RID: 1442
		private bool fullDateFieldSpecified;
	}
}
