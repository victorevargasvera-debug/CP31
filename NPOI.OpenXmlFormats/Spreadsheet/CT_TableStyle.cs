using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004EA RID: 1258
	public class CT_TableStyle
	{
		// Token: 0x06003504 RID: 13572 RVA: 0x00084C34 File Offset: 0x00082E34
		public CT_TableStyle()
		{
			this.pivotField = true;
			this.tableField = true;
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x00084C4C File Offset: 0x00082E4C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyle Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyle ct_TableStyle = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyle();
			ct_TableStyle.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_TableStyle.pivot = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["pivot"]);
			ct_TableStyle.table = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["table"]);
			ct_TableStyle.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_TableStyle.tableStyleElement = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleElement>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tableStyleElement")
				{
					ct_TableStyle.tableStyleElement.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleElement.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_TableStyle;
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x00084D48 File Offset: 0x00082F48
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pivot", this.pivot);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "table", this.table);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.tableStyleElement != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleElement ct_TableStyleElement in this.tableStyleElement)
				{
					ct_TableStyleElement.Write(sw, "tableStyleElement");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06003507 RID: 13575 RVA: 0x00084E18 File Offset: 0x00083018
		// (set) Token: 0x06003508 RID: 13576 RVA: 0x00084E20 File Offset: 0x00083020
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleElement> tableStyleElement
		{
			get
			{
				return this.tableStyleElementField;
			}
			set
			{
				this.tableStyleElementField = value;
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x00084E29 File Offset: 0x00083029
		// (set) Token: 0x0600350A RID: 13578 RVA: 0x00084E31 File Offset: 0x00083031
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x00084E3A File Offset: 0x0008303A
		// (set) Token: 0x0600350C RID: 13580 RVA: 0x00084E42 File Offset: 0x00083042
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool pivot
		{
			get
			{
				return this.pivotField;
			}
			set
			{
				this.pivotField = value;
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x00084E4B File Offset: 0x0008304B
		// (set) Token: 0x0600350E RID: 13582 RVA: 0x00084E53 File Offset: 0x00083053
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool table
		{
			get
			{
				return this.tableField;
			}
			set
			{
				this.tableField = value;
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x00084E5C File Offset: 0x0008305C
		// (set) Token: 0x06003510 RID: 13584 RVA: 0x00084E64 File Offset: 0x00083064
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

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x00084E6D File Offset: 0x0008306D
		// (set) Token: 0x06003512 RID: 13586 RVA: 0x00084E75 File Offset: 0x00083075
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

		// Token: 0x0400233B RID: 9019
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleElement> tableStyleElementField;

		// Token: 0x0400233C RID: 9020
		private string nameField;

		// Token: 0x0400233D RID: 9021
		private bool pivotField;

		// Token: 0x0400233E RID: 9022
		private bool tableField;

		// Token: 0x0400233F RID: 9023
		private uint countField;

		// Token: 0x04002340 RID: 9024
		private bool countFieldSpecified;
	}
}
