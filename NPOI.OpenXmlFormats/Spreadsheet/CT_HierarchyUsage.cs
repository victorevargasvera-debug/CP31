using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004E2 RID: 1250
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_HierarchyUsage
	{
		// Token: 0x06003453 RID: 13395 RVA: 0x000833E0 File Offset: 0x000815E0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage ct_HierarchyUsage = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage();
			if (node.Attributes["hierarchyUsage"] != null)
			{
				ct_HierarchyUsage.hierarchyUsage = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["hierarchyUsage"]);
			}
			return ct_HierarchyUsage;
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00083426 File Offset: 0x00081626
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hierarchyUsage", this.hierarchyUsage);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x00083466 File Offset: 0x00081666
		// (set) Token: 0x06003456 RID: 13398 RVA: 0x0008346E File Offset: 0x0008166E
		[global::System.Xml.Serialization.XmlAttribute]
		public int hierarchyUsage
		{
			get
			{
				return this.hierarchyUsageField;
			}
			set
			{
				this.hierarchyUsageField = value;
			}
		}

		// Token: 0x040022F2 RID: 8946
		private int hierarchyUsageField;
	}
}
