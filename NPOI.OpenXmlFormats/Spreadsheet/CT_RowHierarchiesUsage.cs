using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004E1 RID: 1249
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_RowHierarchiesUsage
	{
		// Token: 0x0600344A RID: 13386 RVA: 0x0008323C File Offset: 0x0008143C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowHierarchiesUsage Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowHierarchiesUsage ct_RowHierarchiesUsage = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowHierarchiesUsage();
			if (node.Attributes["count"] != null)
			{
				ct_RowHierarchiesUsage.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_RowHierarchiesUsage.rowHierarchyUsage = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rowHierarchyUsage")
				{
					ct_RowHierarchiesUsage.rowHierarchyUsage.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_RowHierarchiesUsage;
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x000832F8 File Offset: 0x000814F8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.rowHierarchyUsage != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage ct_HierarchyUsage in this.rowHierarchyUsage)
				{
					ct_HierarchyUsage.Write(sw, "rowHierarchyUsage");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x00083398 File Offset: 0x00081598
		public CT_RowHierarchiesUsage()
		{
			this.rowHierarchyUsageField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage>();
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x000833AB File Offset: 0x000815AB
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x000833B3 File Offset: 0x000815B3
		[global::System.Xml.Serialization.XmlElement("rowHierarchyUsage", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage> rowHierarchyUsage
		{
			get
			{
				return this.rowHierarchyUsageField;
			}
			set
			{
				this.rowHierarchyUsageField = value;
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x000833BC File Offset: 0x000815BC
		// (set) Token: 0x06003450 RID: 13392 RVA: 0x000833C4 File Offset: 0x000815C4
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

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x000833CD File Offset: 0x000815CD
		// (set) Token: 0x06003452 RID: 13394 RVA: 0x000833D5 File Offset: 0x000815D5
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

		// Token: 0x040022EF RID: 8943
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage> rowHierarchyUsageField;

		// Token: 0x040022F0 RID: 8944
		private uint countField;

		// Token: 0x040022F1 RID: 8945
		private bool countFieldSpecified;
	}
}
