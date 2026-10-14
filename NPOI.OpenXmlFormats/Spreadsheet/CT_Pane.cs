using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200057A RID: 1402
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Pane
	{
		// Token: 0x06003D2A RID: 15658 RVA: 0x000949E9 File Offset: 0x00092BE9
		public CT_Pane()
		{
			this.xSplitField = 0.0;
			this.ySplitField = 0.0;
			this.activePaneField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane.topLeft;
			this.stateField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_PaneState.split;
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x00094A20 File Offset: 0x00092C20
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane ct_Pane = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane();
			ct_Pane.xSplit = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["xSplit"]);
			ct_Pane.ySplit = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["ySplit"]);
			ct_Pane.topLeftCell = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["topLeftCell"]);
			if (node.Attributes["activePane"] != null)
			{
				ct_Pane.activePane = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane), node.Attributes["activePane"].Value);
			}
			if (node.Attributes["state"] != null)
			{
				ct_Pane.state = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_PaneState)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PaneState), node.Attributes["state"].Value);
			}
			return ct_Pane;
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x00094B0C File Offset: 0x00092D0C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xSplit", this.xSplit);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ySplit", this.ySplit);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "topLeftCell", this.topLeftCell);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "activePane", this.activePane.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "state", this.state.ToString());
			sw.Write("/>");
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x00094BA6 File Offset: 0x00092DA6
		public bool IsSetTopLeftCell()
		{
			return this.topLeftCellField != null;
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x00094BB1 File Offset: 0x00092DB1
		public void UnsetTopLeftCell()
		{
			this.topLeftCellField = null;
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x00094BBA File Offset: 0x00092DBA
		public void UnsetYSplit()
		{
			this.ySplitField = 0.0;
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00094BCB File Offset: 0x00092DCB
		public void UnsetXSplit()
		{
			this.xSplitField = 0.0;
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x00094BDC File Offset: 0x00092DDC
		public bool IsSetXSplit()
		{
			return this.xSplitField != 0.0;
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00094BF2 File Offset: 0x00092DF2
		public bool IsSetYSplit()
		{
			return this.ySplitField != 0.0;
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06003D33 RID: 15667 RVA: 0x00094C08 File Offset: 0x00092E08
		// (set) Token: 0x06003D34 RID: 15668 RVA: 0x00094C10 File Offset: 0x00092E10
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0.0)]
		public double xSplit
		{
			get
			{
				return this.xSplitField;
			}
			set
			{
				this.xSplitField = value;
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06003D35 RID: 15669 RVA: 0x00094C19 File Offset: 0x00092E19
		// (set) Token: 0x06003D36 RID: 15670 RVA: 0x00094C21 File Offset: 0x00092E21
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0.0)]
		public double ySplit
		{
			get
			{
				return this.ySplitField;
			}
			set
			{
				this.ySplitField = value;
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06003D37 RID: 15671 RVA: 0x00094C2A File Offset: 0x00092E2A
		// (set) Token: 0x06003D38 RID: 15672 RVA: 0x00094C32 File Offset: 0x00092E32
		[global::System.Xml.Serialization.XmlAttribute]
		public string topLeftCell
		{
			get
			{
				return this.topLeftCellField;
			}
			set
			{
				this.topLeftCellField = value;
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x00094C3B File Offset: 0x00092E3B
		// (set) Token: 0x06003D3A RID: 15674 RVA: 0x00094C43 File Offset: 0x00092E43
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane.topLeft)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane activePane
		{
			get
			{
				return this.activePaneField;
			}
			set
			{
				this.activePaneField = value;
			}
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06003D3B RID: 15675 RVA: 0x00094C4C File Offset: 0x00092E4C
		// (set) Token: 0x06003D3C RID: 15676 RVA: 0x00094C54 File Offset: 0x00092E54
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PaneState.split)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_PaneState state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}

		// Token: 0x04002707 RID: 9991
		private double xSplitField;

		// Token: 0x04002708 RID: 9992
		private double ySplitField;

		// Token: 0x04002709 RID: 9993
		private string topLeftCellField;

		// Token: 0x0400270A RID: 9994
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane activePaneField;

		// Token: 0x0400270B RID: 9995
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_PaneState stateField;
	}
}
