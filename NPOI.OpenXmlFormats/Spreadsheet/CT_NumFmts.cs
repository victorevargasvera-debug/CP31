using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000509 RID: 1289
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_NumFmts
	{
		// Token: 0x06003748 RID: 14152 RVA: 0x00089F5C File Offset: 0x0008815C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmts Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmts ct_NumFmts = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmts();
			ct_NumFmts.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_NumFmts.numFmt = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "numFmt")
				{
					ct_NumFmts.numFmt.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_NumFmts;
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x0008A004 File Offset: 0x00088204
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, true);
			sw.Write(">");
			if (this.numFmt != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt ct_NumFmt in this.numFmt)
				{
					ct_NumFmt.Write(sw, "numFmt");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x0008A0A4 File Offset: 0x000882A4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt AddNewNumFmt()
		{
			if (this.numFmtField == null)
			{
				this.numFmtField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt ct_NumFmt = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt();
			this.numFmtField.Add(ct_NumFmt);
			return ct_NumFmt;
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x0600374B RID: 14155 RVA: 0x0008A0D7 File Offset: 0x000882D7
		// (set) Token: 0x0600374C RID: 14156 RVA: 0x0008A0DF File Offset: 0x000882DF
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt> numFmt
		{
			get
			{
				return this.numFmtField;
			}
			set
			{
				this.numFmtField = value;
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x0600374D RID: 14157 RVA: 0x0008A0E8 File Offset: 0x000882E8
		// (set) Token: 0x0600374E RID: 14158 RVA: 0x0008A0F0 File Offset: 0x000882F0
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
				this.countFieldSpecified = (value > 0U);
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x0600374F RID: 14159 RVA: 0x0008A103 File Offset: 0x00088303
		// (set) Token: 0x06003750 RID: 14160 RVA: 0x0008A10B File Offset: 0x0008830B
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

		// Token: 0x0400240D RID: 9229
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt> numFmtField;

		// Token: 0x0400240E RID: 9230
		private uint countField;

		// Token: 0x0400240F RID: 9231
		private bool countFieldSpecified;
	}
}
