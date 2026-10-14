using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004A6 RID: 1190
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_TupleCache
	{
		// Token: 0x060030B6 RID: 12470 RVA: 0x0007A05C File Offset: 0x0007825C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_TupleCache Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_TupleCache ct_TupleCache = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TupleCache();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "entries")
				{
					ct_TupleCache.entries = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSDTCEntries.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sets")
				{
					ct_TupleCache.sets = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sets.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "queryCache")
				{
					ct_TupleCache.queryCache = global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryCache.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "serverFormats")
				{
					ct_TupleCache.serverFormats = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormats.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_TupleCache.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TupleCache;
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x0007A168 File Offset: 0x00078368
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.entries != null)
			{
				this.entries.Write(sw, "entries");
			}
			if (this.sets != null)
			{
				this.sets.Write(sw, "sets");
			}
			if (this.queryCache != null)
			{
				this.queryCache.Write(sw, "queryCache");
			}
			if (this.serverFormats != null)
			{
				this.serverFormats.Write(sw, "serverFormats");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x0007A21F File Offset: 0x0007841F
		public CT_TupleCache()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.serverFormatsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormats();
			this.queryCacheField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryCache();
			this.setsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sets();
			this.entriesField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSDTCEntries();
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060030B9 RID: 12473 RVA: 0x0007A25E File Offset: 0x0007845E
		// (set) Token: 0x060030BA RID: 12474 RVA: 0x0007A266 File Offset: 0x00078466
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSDTCEntries entries
		{
			get
			{
				return this.entriesField;
			}
			set
			{
				this.entriesField = value;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x0007A26F File Offset: 0x0007846F
		// (set) Token: 0x060030BC RID: 12476 RVA: 0x0007A277 File Offset: 0x00078477
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sets sets
		{
			get
			{
				return this.setsField;
			}
			set
			{
				this.setsField = value;
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x0007A280 File Offset: 0x00078480
		// (set) Token: 0x060030BE RID: 12478 RVA: 0x0007A288 File Offset: 0x00078488
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryCache queryCache
		{
			get
			{
				return this.queryCacheField;
			}
			set
			{
				this.queryCacheField = value;
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x0007A291 File Offset: 0x00078491
		// (set) Token: 0x060030C0 RID: 12480 RVA: 0x0007A299 File Offset: 0x00078499
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormats serverFormats
		{
			get
			{
				return this.serverFormatsField;
			}
			set
			{
				this.serverFormatsField = value;
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x0007A2A2 File Offset: 0x000784A2
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x0007A2AA File Offset: 0x000784AA
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x04002107 RID: 8455
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSDTCEntries entriesField;

		// Token: 0x04002108 RID: 8456
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sets setsField;

		// Token: 0x04002109 RID: 8457
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryCache queryCacheField;

		// Token: 0x0400210A RID: 8458
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormats serverFormatsField;

		// Token: 0x0400210B RID: 8459
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
