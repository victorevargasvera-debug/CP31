using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005CB RID: 1483
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellWatches
	{
		// Token: 0x0600416C RID: 16748 RVA: 0x0009E570 File Offset: 0x0009C770
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatches Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatches ct_CellWatches = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatches();
			ct_CellWatches.cellWatch = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatch>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cellWatch")
				{
					ct_CellWatches.cellWatch.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatch.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CellWatches;
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x0009E600 File Offset: 0x0009C800
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.cellWatch != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatch ct_CellWatch in this.cellWatch)
				{
					ct_CellWatch.Write(sw, "cellWatch");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x0600416F RID: 16751 RVA: 0x0009E68C File Offset: 0x0009C88C
		// (set) Token: 0x06004170 RID: 16752 RVA: 0x0009E694 File Offset: 0x0009C894
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatch> cellWatch
		{
			get
			{
				return this.cellWatchField;
			}
			set
			{
				this.cellWatchField = value;
			}
		}

		// Token: 0x04002948 RID: 10568
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatch> cellWatchField;
	}
}
