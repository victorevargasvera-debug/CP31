using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000576 RID: 1398
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PageSetUpPr
	{
		// Token: 0x06003CD9 RID: 15577 RVA: 0x00093DCC File Offset: 0x00091FCC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr
			{
				autoPageBreaks = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoPageBreaks"]),
				fitToPage = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fitToPage"])
			};
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x00093E1C File Offset: 0x0009201C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoPageBreaks", this.autoPageBreaks, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fitToPage", this.fitToPage, false);
			sw.Write("/>");
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x00093E69 File Offset: 0x00092069
		public CT_PageSetUpPr()
		{
			this.autoPageBreaksField = true;
			this.fitToPageField = false;
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x00093E7F File Offset: 0x0009207F
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr Clone()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr
			{
				autoPageBreaksField = this.autoPageBreaksField,
				fitToPageField = this.fitToPageField
			};
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06003CDD RID: 15581 RVA: 0x00093E9E File Offset: 0x0009209E
		// (set) Token: 0x06003CDE RID: 15582 RVA: 0x00093EA6 File Offset: 0x000920A6
		[global::System.ComponentModel.DefaultValue(true)]
		public bool autoPageBreaks
		{
			get
			{
				return this.autoPageBreaksField;
			}
			set
			{
				this.autoPageBreaksField = value;
			}
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06003CDF RID: 15583 RVA: 0x00093EAF File Offset: 0x000920AF
		// (set) Token: 0x06003CE0 RID: 15584 RVA: 0x00093EB7 File Offset: 0x000920B7
		[global::System.ComponentModel.DefaultValue(false)]
		public bool fitToPage
		{
			get
			{
				return this.fitToPageField;
			}
			set
			{
				this.fitToPageField = value;
			}
		}

		// Token: 0x040026EB RID: 9963
		private bool autoPageBreaksField;

		// Token: 0x040026EC RID: 9964
		private bool fitToPageField;
	}
}
