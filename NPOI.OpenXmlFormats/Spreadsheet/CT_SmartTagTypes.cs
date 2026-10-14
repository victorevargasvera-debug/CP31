using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000527 RID: 1319
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SmartTagTypes
	{
		// Token: 0x06003A0C RID: 14860 RVA: 0x00090228 File Offset: 0x0008E428
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagTypes Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagTypes ct_SmartTagTypes = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagTypes();
			ct_SmartTagTypes.smartTagType = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagType>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "smartTagType")
				{
					ct_SmartTagTypes.smartTagType.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagType.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SmartTagTypes;
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x000902B8 File Offset: 0x0008E4B8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.smartTagType != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagType ct_SmartTagType in this.smartTagType)
				{
					ct_SmartTagType.Write(sw, "smartTagType");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06003A0E RID: 14862 RVA: 0x00090344 File Offset: 0x0008E544
		// (set) Token: 0x06003A0F RID: 14863 RVA: 0x0009034C File Offset: 0x0008E54C
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagType> smartTagType
		{
			get
			{
				return this.smartTagTypeField;
			}
			set
			{
				this.smartTagTypeField = value;
			}
		}

		// Token: 0x04002507 RID: 9479
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagType> smartTagTypeField;
	}
}
