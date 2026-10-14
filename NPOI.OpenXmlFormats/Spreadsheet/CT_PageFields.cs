using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004C8 RID: 1224
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PageFields
	{
		// Token: 0x06003326 RID: 13094 RVA: 0x000803B8 File Offset: 0x0007E5B8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageFields Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageFields ct_PageFields = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageFields();
			if (node.Attributes["count"] != null)
			{
				ct_PageFields.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_PageFields.pageField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pageField")
				{
					ct_PageFields.pageField.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PageFields;
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x00080474 File Offset: 0x0007E674
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.pageField != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField ct_PageField in this.pageField)
				{
					ct_PageField.Write(sw, "pageField");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x00080514 File Offset: 0x0007E714
		public CT_PageFields()
		{
			this.pageFieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField>();
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06003329 RID: 13097 RVA: 0x00080527 File Offset: 0x0007E727
		// (set) Token: 0x0600332A RID: 13098 RVA: 0x0008052F File Offset: 0x0007E72F
		[global::System.Xml.Serialization.XmlElement("pageField", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField> pageField
		{
			get
			{
				return this.pageFieldField;
			}
			set
			{
				this.pageFieldField = value;
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x00080538 File Offset: 0x0007E738
		// (set) Token: 0x0600332C RID: 13100 RVA: 0x00080540 File Offset: 0x0007E740
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x0600332D RID: 13101 RVA: 0x00080549 File Offset: 0x0007E749
		// (set) Token: 0x0600332E RID: 13102 RVA: 0x00080551 File Offset: 0x0007E751
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x0008055C File Offset: 0x0007E75C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField AddNewPageField()
		{
			if (this.pageFieldField == null)
			{
				this.pageFieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField ct_PageField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField();
			this.pageFieldField.Add(ct_PageField);
			return ct_PageField;
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x0008058F File Offset: 0x0007E78F
		public uint SizeOfPageFieldArray()
		{
			if (this.pageFieldField == null)
			{
				this.pageFieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField>();
			}
			return (uint)this.pageFieldField.Count;
		}

		// Token: 0x04002222 RID: 8738
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField> pageFieldField;

		// Token: 0x04002223 RID: 8739
		private uint countField;

		// Token: 0x04002224 RID: 8740
		private bool countFieldSpecified;
	}
}
