using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004F1 RID: 1265
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_BorderPr
	{
		// Token: 0x0600356E RID: 13678 RVA: 0x00085A28 File Offset: 0x00083C28
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr();
			if (node.Attributes["style"] != null)
			{
				ct_BorderPr.style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle), node.Attributes["style"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "color")
				{
					ct_BorderPr.color = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_BorderPr;
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x00085AE8 File Offset: 0x00083CE8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.style != global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "style", this.style.ToString());
			}
			if (this.color != null)
			{
				sw.Write(">");
				this.color.Write(sw, "color");
				sw.Write(string.Format("</{0}>", nodeName));
				return;
			}
			sw.Write("/>");
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x00085B6E File Offset: 0x00083D6E
		public CT_BorderPr()
		{
			this.styleField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle.none;
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x00085B7D File Offset: 0x00083D7D
		public void SetColor(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color)
		{
			this.colorField = color;
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00085B86 File Offset: 0x00083D86
		public bool IsSetColor()
		{
			return this.colorField != null;
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x00085B91 File Offset: 0x00083D91
		public void UnsetColor()
		{
			this.colorField = null;
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x00085B9A File Offset: 0x00083D9A
		public bool IsSetStyle()
		{
			return this.styleField > global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle.none;
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06003575 RID: 13685 RVA: 0x00085BA5 File Offset: 0x00083DA5
		// (set) Token: 0x06003576 RID: 13686 RVA: 0x00085B7D File Offset: 0x00083D7D
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06003577 RID: 13687 RVA: 0x00085BAD File Offset: 0x00083DAD
		// (set) Token: 0x06003578 RID: 13688 RVA: 0x00085BB5 File Offset: 0x00083DB5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle.none)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle style
		{
			get
			{
				return this.styleField;
			}
			set
			{
				this.styleField = value;
			}
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x00085BBE File Offset: 0x00083DBE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr Copy()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr
			{
				colorField = ((this.colorField == null) ? null : this.colorField.Copy()),
				style = this.style
			};
		}

		// Token: 0x0400238B RID: 9099
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color colorField;

		// Token: 0x0400238C RID: 9100
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle styleField;
	}
}
