using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000D7 RID: 215
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtDropDownList
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x000116F4 File Offset: 0x0000F8F4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDropDownList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDropDownList ct_SdtDropDownList = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDropDownList();
			ct_SdtDropDownList.lastValue = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:lastValue"]);
			ct_SdtDropDownList.listItem = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtListItem>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "listItem")
				{
					ct_SdtDropDownList.listItem.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtListItem.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SdtDropDownList;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001179C File Offset: 0x0000F99C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:lastValue", this.lastValue);
			sw.Write(">");
			if (this.listItem != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtListItem ct_SdtListItem in this.listItem)
				{
					ct_SdtListItem.Write(sw, "listItem");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00011838 File Offset: 0x0000FA38
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x00011840 File Offset: 0x0000FA40
		[global::System.Xml.Serialization.XmlElement("listItem", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtListItem> listItem
		{
			get
			{
				return this.listItemField;
			}
			set
			{
				this.listItemField = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00011849 File Offset: 0x0000FA49
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00011851 File Offset: 0x0000FA51
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string lastValue
		{
			get
			{
				return this.lastValueField;
			}
			set
			{
				this.lastValueField = value;
			}
		}

		// Token: 0x04000528 RID: 1320
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtListItem> listItemField;

		// Token: 0x04000529 RID: 1321
		private string lastValueField;
	}
}
