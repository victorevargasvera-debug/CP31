using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005FC RID: 1532
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DdeLink
	{
		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x0600433F RID: 17215 RVA: 0x000A02B7 File Offset: 0x0009E4B7
		// (set) Token: 0x06004340 RID: 17216 RVA: 0x000A02BF File Offset: 0x0009E4BF
		[global::System.Xml.Serialization.XmlArray("ddeItems")]
		[global::System.Xml.Serialization.XmlArrayItem("ddeItem")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeItem> ddeItems
		{
			get
			{
				return this.ddeItemsField;
			}
			set
			{
				this.ddeItemsField = value;
			}
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06004341 RID: 17217 RVA: 0x000A02C8 File Offset: 0x0009E4C8
		// (set) Token: 0x06004342 RID: 17218 RVA: 0x000A02D0 File Offset: 0x0009E4D0
		[global::System.Xml.Serialization.XmlAttribute]
		public string ddeService
		{
			get
			{
				return this.ddeServiceField;
			}
			set
			{
				this.ddeServiceField = value;
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06004343 RID: 17219 RVA: 0x000A02D9 File Offset: 0x0009E4D9
		// (set) Token: 0x06004344 RID: 17220 RVA: 0x000A02E1 File Offset: 0x0009E4E1
		[global::System.Xml.Serialization.XmlAttribute]
		public string ddeTopic
		{
			get
			{
				return this.ddeTopicField;
			}
			set
			{
				this.ddeTopicField = value;
			}
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x000024E5 File Offset: 0x000006E5
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeLink Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x000024E5 File Offset: 0x000006E5
		internal void Write(global::System.IO.StreamWriter sw, string p)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04002A6D RID: 10861
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeItem> ddeItemsField;

		// Token: 0x04002A6E RID: 10862
		private string ddeServiceField;

		// Token: 0x04002A6F RID: 10863
		private string ddeTopicField;
	}
}
