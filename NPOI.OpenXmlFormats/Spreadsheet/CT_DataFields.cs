using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004CA RID: 1226
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_DataFields
	{
		// Token: 0x06003344 RID: 13124 RVA: 0x00080830 File Offset: 0x0007EA30
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataFields Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataFields ct_DataFields = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataFields();
			if (node.Attributes["count"] != null)
			{
				ct_DataFields.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_DataFields.dataField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "dataField")
				{
					ct_DataFields.dataField.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DataFields;
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x000808EC File Offset: 0x0007EAEC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.dataField != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField ct_DataField in this.dataField)
				{
					ct_DataField.Write(sw, "dataField");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x0008098C File Offset: 0x0007EB8C
		public CT_DataFields()
		{
			this.dataFieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField>();
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06003347 RID: 13127 RVA: 0x0008099F File Offset: 0x0007EB9F
		// (set) Token: 0x06003348 RID: 13128 RVA: 0x000809A7 File Offset: 0x0007EBA7
		[global::System.Xml.Serialization.XmlElement("dataField", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField> dataField
		{
			get
			{
				return this.dataFieldField;
			}
			set
			{
				this.dataFieldField = value;
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06003349 RID: 13129 RVA: 0x000809B0 File Offset: 0x0007EBB0
		// (set) Token: 0x0600334A RID: 13130 RVA: 0x000809B8 File Offset: 0x0007EBB8
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

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x000809C1 File Offset: 0x0007EBC1
		// (set) Token: 0x0600334C RID: 13132 RVA: 0x000809C9 File Offset: 0x0007EBC9
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

		// Token: 0x0600334D RID: 13133 RVA: 0x000809D4 File Offset: 0x0007EBD4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField AddNewDataField()
		{
			if (this.dataFieldField == null)
			{
				this.dataFieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField ct_DataField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField();
			this.dataFieldField.Add(ct_DataField);
			return ct_DataField;
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x00080A07 File Offset: 0x0007EC07
		public uint SizeOfDataFieldArray()
		{
			return (uint)this.dataFieldField.Count;
		}

		// Token: 0x0400222D RID: 8749
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField> dataFieldField;

		// Token: 0x0400222E RID: 8750
		private uint countField;

		// Token: 0x0400222F RID: 8751
		private bool countFieldSpecified;
	}
}
