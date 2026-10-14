using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005B1 RID: 1457
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellSmartTag
	{
		// Token: 0x06004037 RID: 16439 RVA: 0x0009BCB4 File Offset: 0x00099EB4
		public CT_CellSmartTag()
		{
			this.cellSmartTagPrField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTagPr>();
			this.deletedField = false;
			this.xmlBasedField = false;
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06004038 RID: 16440 RVA: 0x0009BCD5 File Offset: 0x00099ED5
		// (set) Token: 0x06004039 RID: 16441 RVA: 0x0009BCDD File Offset: 0x00099EDD
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTagPr> cellSmartTagPr
		{
			get
			{
				return this.cellSmartTagPrField;
			}
			set
			{
				this.cellSmartTagPrField = value;
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x0600403A RID: 16442 RVA: 0x0009BCE6 File Offset: 0x00099EE6
		// (set) Token: 0x0600403B RID: 16443 RVA: 0x0009BCEE File Offset: 0x00099EEE
		public uint type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x0600403C RID: 16444 RVA: 0x0009BCF7 File Offset: 0x00099EF7
		// (set) Token: 0x0600403D RID: 16445 RVA: 0x0009BCFF File Offset: 0x00099EFF
		[global::System.ComponentModel.DefaultValue(false)]
		public bool deleted
		{
			get
			{
				return this.deletedField;
			}
			set
			{
				this.deletedField = value;
			}
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x0600403E RID: 16446 RVA: 0x0009BD08 File Offset: 0x00099F08
		// (set) Token: 0x0600403F RID: 16447 RVA: 0x0009BD10 File Offset: 0x00099F10
		[global::System.ComponentModel.DefaultValue(false)]
		public bool xmlBased
		{
			get
			{
				return this.xmlBasedField;
			}
			set
			{
				this.xmlBasedField = value;
			}
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x0009BD1C File Offset: 0x00099F1C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTag Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTag ct_CellSmartTag = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTag();
			ct_CellSmartTag.type = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["type"]);
			ct_CellSmartTag.deleted = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["deleted"]);
			ct_CellSmartTag.xmlBased = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["xmlBased"]);
			ct_CellSmartTag.cellSmartTagPr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTagPr>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cellSmartTagPr")
				{
					ct_CellSmartTag.cellSmartTagPr.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTagPr.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CellSmartTag;
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x0009BDFC File Offset: 0x00099FFC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "deleted", this.deleted);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xmlBased", this.xmlBased);
			sw.Write(">");
			if (this.cellSmartTagPr != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTagPr ct_CellSmartTagPr in this.cellSmartTagPr)
				{
					ct_CellSmartTagPr.Write(sw, "cellSmartTagPr");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040028BF RID: 10431
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTagPr> cellSmartTagPrField;

		// Token: 0x040028C0 RID: 10432
		private uint typeField;

		// Token: 0x040028C1 RID: 10433
		private bool deletedField;

		// Token: 0x040028C2 RID: 10434
		private bool xmlBasedField;
	}
}
