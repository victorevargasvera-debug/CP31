using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000507 RID: 1287
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(ElementName = "fonts", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public class CT_Fonts
	{
		// Token: 0x06003737 RID: 14135 RVA: 0x00089CF4 File Offset: 0x00087EF4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fonts Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fonts ct_Fonts = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fonts();
			ct_Fonts.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_Fonts.knownFontsField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["x14ac:knownFonts"]);
			ct_Fonts.font = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "font")
				{
					ct_Fonts.font.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Fonts;
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x00089DB8 File Offset: 0x00087FB8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "x14ac:knownFonts", this.knownFontsField, false);
			sw.Write(">");
			if (this.font != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font ct_Font in this.font)
				{
					ct_Font.Write(sw, "font");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x00089E68 File Offset: 0x00088068
		public void SetFontArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font> array)
		{
			this.fontField = array;
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x0600373A RID: 14138 RVA: 0x00089E71 File Offset: 0x00088071
		// (set) Token: 0x0600373B RID: 14139 RVA: 0x00089E68 File Offset: 0x00088068
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font> font
		{
			get
			{
				return this.fontField;
			}
			set
			{
				this.fontField = value;
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x0600373C RID: 14140 RVA: 0x00089E79 File Offset: 0x00088079
		// (set) Token: 0x0600373D RID: 14141 RVA: 0x00089E81 File Offset: 0x00088081
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

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x0600373E RID: 14142 RVA: 0x00089E8A File Offset: 0x0008808A
		// (set) Token: 0x0600373F RID: 14143 RVA: 0x00089E92 File Offset: 0x00088092
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

		// Token: 0x04002407 RID: 9223
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font> fontField;

		// Token: 0x04002408 RID: 9224
		private uint countField;

		// Token: 0x04002409 RID: 9225
		private bool countFieldSpecified;

		// Token: 0x0400240A RID: 9226
		private uint knownFontsField;
	}
}
