using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000550 RID: 1360
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", ElementName = "phoneticPr", IsNullable = false)]
	[global::System.Serializable]
	public class CT_PhoneticPr
	{
		// Token: 0x06003B34 RID: 15156 RVA: 0x00092974 File Offset: 0x00090B74
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr ct_PhoneticPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr();
			ct_PhoneticPr.fontId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["fontId"]);
			if (node.Attributes["type"] != null)
			{
				ct_PhoneticPr.type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticType), node.Attributes["type"].Value);
			}
			if (node.Attributes["alignment"] != null)
			{
				ct_PhoneticPr.alignment = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticAlignment)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticAlignment), node.Attributes["alignment"].Value);
			}
			return ct_PhoneticPr;
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x00092A2C File Offset: 0x00090C2C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fontId", this.fontId, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			if (this.alignment != global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticAlignment.left)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "alignment", this.alignment.ToString());
			}
			sw.Write("/>");
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x00092AAE File Offset: 0x00090CAE
		public CT_PhoneticPr()
		{
			this.typeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticType.fullwidthKatakana;
			this.alignmentField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticAlignment.left;
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06003B37 RID: 15159 RVA: 0x00092AC4 File Offset: 0x00090CC4
		// (set) Token: 0x06003B38 RID: 15160 RVA: 0x00092ACC File Offset: 0x00090CCC
		[global::System.Xml.Serialization.XmlAttribute]
		public uint fontId
		{
			get
			{
				return this.fontIdField;
			}
			set
			{
				this.fontIdField = value;
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06003B39 RID: 15161 RVA: 0x00092AD5 File Offset: 0x00090CD5
		// (set) Token: 0x06003B3A RID: 15162 RVA: 0x00092ADD File Offset: 0x00090CDD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticType.fullwidthKatakana)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06003B3B RID: 15163 RVA: 0x00092AE6 File Offset: 0x00090CE6
		// (set) Token: 0x06003B3C RID: 15164 RVA: 0x00092AEE File Offset: 0x00090CEE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticAlignment.left)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticAlignment alignment
		{
			get
			{
				return this.alignmentField;
			}
			set
			{
				this.alignmentField = value;
			}
		}

		// Token: 0x040025DF RID: 9695
		private uint fontIdField;

		// Token: 0x040025E0 RID: 9696
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticType typeField;

		// Token: 0x040025E1 RID: 9697
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_PhoneticAlignment alignmentField;
	}
}
