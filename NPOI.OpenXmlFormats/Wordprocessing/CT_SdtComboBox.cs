using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000D5 RID: 213
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtComboBox
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x000113F8 File Offset: 0x0000F5F8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtComboBox Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtComboBox ct_SdtComboBox = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtComboBox();
			ct_SdtComboBox.lastValue = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:lastValue"]);
			ct_SdtComboBox.listItem = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtListItem>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "listItem")
				{
					ct_SdtComboBox.listItem.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtListItem.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SdtComboBox;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000114A0 File Offset: 0x0000F6A0
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

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0001153C File Offset: 0x0000F73C
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00011544 File Offset: 0x0000F744
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

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001154D File Offset: 0x0000F74D
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00011555 File Offset: 0x0000F755
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

		// Token: 0x04000523 RID: 1315
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtListItem> listItemField;

		// Token: 0x04000524 RID: 1316
		private string lastValueField;
	}
}
