using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000095 RID: 149
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FFDDList
	{
		// Token: 0x06000426 RID: 1062 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		public CT_FFDDList()
		{
			this.listEntryField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String>();
			this.defaultField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			this.resultField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0000C6FD File Offset: 0x0000A8FD
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x0000C705 File Offset: 0x0000A905
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber result
		{
			get
			{
				return this.resultField;
			}
			set
			{
				this.resultField = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0000C70E File Offset: 0x0000A90E
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x0000C716 File Offset: 0x0000A916
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber @default
		{
			get
			{
				return this.defaultField;
			}
			set
			{
				this.defaultField = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0000C71F File Offset: 0x0000A91F
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0000C727 File Offset: 0x0000A927
		[global::System.Xml.Serialization.XmlElement("listEntry", Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String> listEntry
		{
			get
			{
				return this.listEntryField;
			}
			set
			{
				this.listEntryField = value;
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000C730 File Offset: 0x0000A930
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFDDList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFDDList ct_FFDDList = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFDDList();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "result")
				{
					ct_FFDDList.resultField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "default")
				{
					ct_FFDDList.defaultField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "listEntry")
				{
					ct_FFDDList.listEntryField.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_FFDDList;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}>", nodeName));
			if (this.defaultField != null)
			{
				this.defaultField.Write(sw, "default");
			}
			if (this.resultField != null)
			{
				this.resultField.Write(sw, "result");
			}
			foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_String ct_String in this.listEntry)
			{
				ct_String.Write(sw, "listEntry");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x040003A5 RID: 933
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber resultField;

		// Token: 0x040003A6 RID: 934
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber defaultField;

		// Token: 0x040003A7 RID: 935
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String> listEntryField;
	}
}
