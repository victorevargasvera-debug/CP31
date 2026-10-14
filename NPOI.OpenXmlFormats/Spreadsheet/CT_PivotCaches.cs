using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000525 RID: 1317
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PivotCaches
	{
		// Token: 0x060039FE RID: 14846 RVA: 0x0008FFC4 File Offset: 0x0008E1C4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCaches Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCaches ct_PivotCaches = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCaches();
			ct_PivotCaches.pivotCache = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pivotCache")
				{
					ct_PivotCaches.pivotCache.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PivotCaches;
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x00090054 File Offset: 0x0008E254
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.pivotCache != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache ct_PivotCache in this.pivotCache)
				{
					ct_PivotCache.Write(sw, "pivotCache");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06003A00 RID: 14848 RVA: 0x000900E0 File Offset: 0x0008E2E0
		// (set) Token: 0x06003A01 RID: 14849 RVA: 0x000900E8 File Offset: 0x0008E2E8
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache> pivotCache
		{
			get
			{
				return this.pivotCacheField;
			}
			set
			{
				this.pivotCacheField = value;
			}
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x000900F4 File Offset: 0x0008E2F4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache AddNewPivotCache()
		{
			if (this.pivotCacheField == null)
			{
				this.pivotCacheField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache ct_PivotCache = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache();
			this.pivotCacheField.Add(ct_PivotCache);
			return ct_PivotCache;
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x00090127 File Offset: 0x0008E327
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache GetPivotCacheArray(int p)
		{
			if (this.pivotCacheField == null || p < 0 || p >= this.pivotCacheField.Count)
			{
				return null;
			}
			return this.pivotCacheField[p];
		}

		// Token: 0x04002504 RID: 9476
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache> pivotCacheField;
	}
}
