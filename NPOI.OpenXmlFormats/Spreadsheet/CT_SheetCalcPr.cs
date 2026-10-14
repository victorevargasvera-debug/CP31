using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000588 RID: 1416
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SheetCalcPr
	{
		// Token: 0x06003E08 RID: 15880 RVA: 0x000968E0 File Offset: 0x00094AE0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetCalcPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetCalcPr
			{
				fullCalcOnLoad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fullCalcOnLoad"])
			};
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x00096907 File Offset: 0x00094B07
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fullCalcOnLoad", this.fullCalcOnLoad);
			sw.Write("/>");
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x00096936 File Offset: 0x00094B36
		public CT_SheetCalcPr()
		{
			this.fullCalcOnLoadField = false;
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06003E0B RID: 15883 RVA: 0x00096945 File Offset: 0x00094B45
		// (set) Token: 0x06003E0C RID: 15884 RVA: 0x0009694D File Offset: 0x00094B4D
		[global::System.ComponentModel.DefaultValue(false)]
		public bool fullCalcOnLoad
		{
			get
			{
				return this.fullCalcOnLoadField;
			}
			set
			{
				this.fullCalcOnLoadField = value;
			}
		}

		// Token: 0x0400277E RID: 10110
		private bool fullCalcOnLoadField;
	}
}
