using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005BD RID: 1469
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ChartsheetPr
	{
		// Token: 0x060040AD RID: 16557 RVA: 0x0009CE5D File Offset: 0x0009B05D
		public CT_ChartsheetPr()
		{
			this.publishedField = true;
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x0009CE6C File Offset: 0x0009B06C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetPr ct_ChartsheetPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetPr();
			if (node.Attributes["published"] != null)
			{
				ct_ChartsheetPr.published = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["published"]);
			}
			ct_ChartsheetPr.codeName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["codeName"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tabColor")
				{
					ct_ChartsheetPr.tabColor = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ChartsheetPr;
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x0009CF34 File Offset: 0x0009B134
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (!this.published)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "published", this.published);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "codeName", this.codeName);
			sw.Write(">");
			if (this.tabColor != null)
			{
				this.tabColor.Write(sw, "tabColor");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x060040B0 RID: 16560 RVA: 0x0009CFB1 File Offset: 0x0009B1B1
		// (set) Token: 0x060040B1 RID: 16561 RVA: 0x0009CFB9 File Offset: 0x0009B1B9
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color tabColor
		{
			get
			{
				return this.tabColorField;
			}
			set
			{
				this.tabColorField = value;
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x060040B2 RID: 16562 RVA: 0x0009CFC2 File Offset: 0x0009B1C2
		// (set) Token: 0x060040B3 RID: 16563 RVA: 0x0009CFCA File Offset: 0x0009B1CA
		[global::System.ComponentModel.DefaultValue(true)]
		public bool published
		{
			get
			{
				return this.publishedField;
			}
			set
			{
				this.publishedField = value;
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x0009CFD3 File Offset: 0x0009B1D3
		// (set) Token: 0x060040B5 RID: 16565 RVA: 0x0009CFDB File Offset: 0x0009B1DB
		public string codeName
		{
			get
			{
				return this.codeNameField;
			}
			set
			{
				this.codeNameField = value;
			}
		}

		// Token: 0x040028FB RID: 10491
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color tabColorField;

		// Token: 0x040028FC RID: 10492
		private bool publishedField;

		// Token: 0x040028FD RID: 10493
		private string codeNameField;
	}
}
