using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000592 RID: 1426
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PageBreak
	{
		// Token: 0x06003ED7 RID: 16087 RVA: 0x00098581 File Offset: 0x00096781
		public CT_PageBreak()
		{
			this.brkField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break>();
			this.countField = 0U;
			this.manualBreakCountField = 0U;
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x000985A2 File Offset: 0x000967A2
		public int sizeOfBrkArray()
		{
			return this.brkField.Count;
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x000985B0 File Offset: 0x000967B0
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break AddNewBrk()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break ct_Break = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break();
			this.brkField.Add(ct_Break);
			return ct_Break;
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x000985D0 File Offset: 0x000967D0
		public void RemoveBrk(int index)
		{
			this.brkField.RemoveAt(index);
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06003EDB RID: 16091 RVA: 0x000985DE File Offset: 0x000967DE
		// (set) Token: 0x06003EDC RID: 16092 RVA: 0x000985E6 File Offset: 0x000967E6
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break> brk
		{
			get
			{
				return this.brkField;
			}
			set
			{
				this.brkField = value;
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06003EDD RID: 16093 RVA: 0x000985EF File Offset: 0x000967EF
		// (set) Token: 0x06003EDE RID: 16094 RVA: 0x000985F7 File Offset: 0x000967F7
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
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

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06003EDF RID: 16095 RVA: 0x00098600 File Offset: 0x00096800
		// (set) Token: 0x06003EE0 RID: 16096 RVA: 0x00098608 File Offset: 0x00096808
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint manualBreakCount
		{
			get
			{
				return this.manualBreakCountField;
			}
			set
			{
				this.manualBreakCountField = value;
			}
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x00098614 File Offset: 0x00096814
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak ct_PageBreak = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak();
			ct_PageBreak.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_PageBreak.manualBreakCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["manualBreakCount"]);
			ct_PageBreak.brk = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "brk")
				{
					ct_PageBreak.brk.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PageBreak;
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x000986D8 File Offset: 0x000968D8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "manualBreakCount", this.manualBreakCount, false);
			sw.Write(">");
			if (this.brk != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break ct_Break in this.brk)
				{
					ct_Break.Write(sw, "brk");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040027D6 RID: 10198
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break> brkField;

		// Token: 0x040027D7 RID: 10199
		private uint countField;

		// Token: 0x040027D8 RID: 10200
		private uint manualBreakCountField;
	}
}
