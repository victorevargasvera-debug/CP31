using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000501 RID: 1281
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Colors
	{
		// Token: 0x06003691 RID: 13969 RVA: 0x00087F4C File Offset: 0x0008614C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Colors Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Colors ct_Colors = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Colors();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "indexedColors")
				{
					ct_Colors.indexedColors = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RgbColor>();
					using (global::System.Collections.IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj2;
							ct_Colors.indexedColors.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_RgbColor.Parse(node2, namespaceManager));
						}
						continue;
					}
				}
				if (xmlNode.LocalName == "mruColors")
				{
					ct_Colors.mruColors = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color>();
					foreach (object obj3 in xmlNode.ChildNodes)
					{
						global::System.Xml.XmlNode node3 = (global::System.Xml.XmlNode)obj3;
						ct_Colors.mruColors.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color.Parse(node3, namespaceManager));
					}
				}
			}
			return ct_Colors;
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x000880A0 File Offset: 0x000862A0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}>", nodeName));
			if (this.indexedColors != null)
			{
				sw.Write("<indexedColors>");
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_RgbColor ct_RgbColor in this.indexedColors)
				{
					ct_RgbColor.Write(sw, "rgbColor");
				}
				sw.Write("</indexedColors>");
			}
			if (this.mruColors != null)
			{
				sw.Write("<mruColors>");
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color in this.mruColors)
				{
					ct_Color.Write(sw, "color");
				}
				sw.Write("</mruColors>");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06003693 RID: 13971 RVA: 0x0008819C File Offset: 0x0008639C
		// (set) Token: 0x06003694 RID: 13972 RVA: 0x000881A4 File Offset: 0x000863A4
		[global::System.Xml.Serialization.XmlArray(Order = 0)]
		[global::System.Xml.Serialization.XmlArrayItem("rgbColor", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RgbColor> indexedColors
		{
			get
			{
				return this.indexedColorsField;
			}
			set
			{
				this.indexedColorsField = value;
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x000881AD File Offset: 0x000863AD
		// (set) Token: 0x06003696 RID: 13974 RVA: 0x000881B5 File Offset: 0x000863B5
		[global::System.Xml.Serialization.XmlArray(Order = 1)]
		[global::System.Xml.Serialization.XmlArrayItem("color", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color> mruColors
		{
			get
			{
				return this.mruColorsField;
			}
			set
			{
				this.mruColorsField = value;
			}
		}

		// Token: 0x040023E6 RID: 9190
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RgbColor> indexedColorsField;

		// Token: 0x040023E7 RID: 9191
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color> mruColorsField;
	}
}
