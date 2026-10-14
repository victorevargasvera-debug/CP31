using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000529 RID: 1321
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SmartTagPr
	{
		// Token: 0x06003A19 RID: 14873 RVA: 0x00090460 File Offset: 0x0008E660
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagPr ct_SmartTagPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagPr();
			ct_SmartTagPr.embed = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["embed"]);
			if (node.Attributes["show"] != null)
			{
				ct_SmartTagPr.show = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_SmartTagShow)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SmartTagShow), node.Attributes["show"].Value);
			}
			return ct_SmartTagPr;
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x000904D8 File Offset: 0x0008E6D8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "embed", this.embed);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "show", this.show.ToString());
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x00090542 File Offset: 0x0008E742
		public CT_SmartTagPr()
		{
			this.embedField = false;
			this.showField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_SmartTagShow.all;
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06003A1C RID: 14876 RVA: 0x00090558 File Offset: 0x0008E758
		// (set) Token: 0x06003A1D RID: 14877 RVA: 0x00090560 File Offset: 0x0008E760
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool embed
		{
			get
			{
				return this.embedField;
			}
			set
			{
				this.embedField = value;
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06003A1E RID: 14878 RVA: 0x00090569 File Offset: 0x0008E769
		// (set) Token: 0x06003A1F RID: 14879 RVA: 0x00090571 File Offset: 0x0008E771
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SmartTagShow.all)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_SmartTagShow show
		{
			get
			{
				return this.showField;
			}
			set
			{
				this.showField = value;
			}
		}

		// Token: 0x0400250B RID: 9483
		private bool embedField;

		// Token: 0x0400250C RID: 9484
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_SmartTagShow showField;
	}
}
