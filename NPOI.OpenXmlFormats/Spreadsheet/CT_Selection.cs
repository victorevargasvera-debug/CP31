using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200057D RID: 1405
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Selection
	{
		// Token: 0x06003D3D RID: 15677 RVA: 0x00094C5D File Offset: 0x00092E5D
		public CT_Selection()
		{
			this.paneField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane.topLeft;
			this.activeCellIdField = 0U;
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x00094C74 File Offset: 0x00092E74
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection ct_Selection = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection();
			if (node.Attributes["pane"] != null)
			{
				ct_Selection.pane = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane), node.Attributes["pane"].Value);
			}
			ct_Selection.activeCell = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["activeCell"]);
			ct_Selection.activeCellId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["activeCellId"]);
			ct_Selection.sqref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sqref"]);
			return ct_Selection;
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x00094D20 File Offset: 0x00092F20
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.pane != global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane.topLeft)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pane", this.pane.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "activeCell", this.activeCell);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "activeCellId", this.activeCellId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sqref", this.sqref);
			sw.Write("/>");
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x00094DA5 File Offset: 0x00092FA5
		public void SetSqref(string[] array)
		{
			if (array.Length != 0)
			{
				this.sqrefField = array[0];
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x00094DB4 File Offset: 0x00092FB4
		// (set) Token: 0x06003D42 RID: 15682 RVA: 0x00094DBC File Offset: 0x00092FBC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane.topLeft)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane pane
		{
			get
			{
				return this.paneField;
			}
			set
			{
				this.paneField = value;
			}
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x00094DC5 File Offset: 0x00092FC5
		// (set) Token: 0x06003D44 RID: 15684 RVA: 0x00094DCD File Offset: 0x00092FCD
		[global::System.Xml.Serialization.XmlAttribute]
		public string activeCell
		{
			get
			{
				return this.activeCellField;
			}
			set
			{
				this.activeCellField = value;
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06003D45 RID: 15685 RVA: 0x00094DD6 File Offset: 0x00092FD6
		// (set) Token: 0x06003D46 RID: 15686 RVA: 0x00094DDE File Offset: 0x00092FDE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint activeCellId
		{
			get
			{
				return this.activeCellIdField;
			}
			set
			{
				this.activeCellIdField = value;
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x00094DE7 File Offset: 0x00092FE7
		// (set) Token: 0x06003D48 RID: 15688 RVA: 0x00094DEF File Offset: 0x00092FEF
		[global::System.Xml.Serialization.XmlAttribute]
		public string sqref
		{
			get
			{
				return this.sqrefField;
			}
			set
			{
				this.sqrefField = value;
			}
		}

		// Token: 0x04002715 RID: 10005
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane paneField;

		// Token: 0x04002716 RID: 10006
		private string activeCellField;

		// Token: 0x04002717 RID: 10007
		private uint activeCellIdField;

		// Token: 0x04002718 RID: 10008
		private string sqrefField;
	}
}
