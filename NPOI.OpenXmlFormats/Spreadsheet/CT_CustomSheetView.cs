using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000591 RID: 1425
	[global::System.Xml.Serialization.XmlType("customSheetView", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CustomSheetView
	{
		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06003E98 RID: 16024 RVA: 0x00097C6E File Offset: 0x00095E6E
		// (set) Token: 0x06003E99 RID: 16025 RVA: 0x00097C76 File Offset: 0x00095E76
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane pane
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

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06003E9A RID: 16026 RVA: 0x00097C7F File Offset: 0x00095E7F
		// (set) Token: 0x06003E9B RID: 16027 RVA: 0x00097C87 File Offset: 0x00095E87
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection selection
		{
			get
			{
				return this.selectionField;
			}
			set
			{
				this.selectionField = value;
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06003E9C RID: 16028 RVA: 0x00097C90 File Offset: 0x00095E90
		// (set) Token: 0x06003E9D RID: 16029 RVA: 0x00097C98 File Offset: 0x00095E98
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak rowBreaks
		{
			get
			{
				return this.rowBreaksField;
			}
			set
			{
				this.rowBreaksField = value;
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06003E9E RID: 16030 RVA: 0x00097CA1 File Offset: 0x00095EA1
		// (set) Token: 0x06003E9F RID: 16031 RVA: 0x00097CA9 File Offset: 0x00095EA9
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak colBreaks
		{
			get
			{
				return this.colBreaksField;
			}
			set
			{
				this.colBreaksField = value;
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x00097CB2 File Offset: 0x00095EB2
		// (set) Token: 0x06003EA1 RID: 16033 RVA: 0x00097CBA File Offset: 0x00095EBA
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins pageMargins
		{
			get
			{
				return this.pageMarginsField;
			}
			set
			{
				this.pageMarginsField = value;
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x00097CC3 File Offset: 0x00095EC3
		// (set) Token: 0x06003EA3 RID: 16035 RVA: 0x00097CCB File Offset: 0x00095ECB
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions printOptions
		{
			get
			{
				return this.printOptionsField;
			}
			set
			{
				this.printOptionsField = value;
			}
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06003EA4 RID: 16036 RVA: 0x00097CD4 File Offset: 0x00095ED4
		// (set) Token: 0x06003EA5 RID: 16037 RVA: 0x00097CDC File Offset: 0x00095EDC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup pageSetup
		{
			get
			{
				return this.pageSetupField;
			}
			set
			{
				this.pageSetupField = value;
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06003EA6 RID: 16038 RVA: 0x00097CE5 File Offset: 0x00095EE5
		// (set) Token: 0x06003EA7 RID: 16039 RVA: 0x00097CED File Offset: 0x00095EED
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooter
		{
			get
			{
				return this.headerFooterField;
			}
			set
			{
				this.headerFooterField = value;
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06003EA8 RID: 16040 RVA: 0x00097CF6 File Offset: 0x00095EF6
		// (set) Token: 0x06003EA9 RID: 16041 RVA: 0x00097CFE File Offset: 0x00095EFE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter autoFilter
		{
			get
			{
				return this.autoFilterField;
			}
			set
			{
				this.autoFilterField = value;
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06003EAA RID: 16042 RVA: 0x00097D07 File Offset: 0x00095F07
		// (set) Token: 0x06003EAB RID: 16043 RVA: 0x00097D0F File Offset: 0x00095F0F
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06003EAC RID: 16044 RVA: 0x00097D18 File Offset: 0x00095F18
		// (set) Token: 0x06003EAD RID: 16045 RVA: 0x00097D20 File Offset: 0x00095F20
		public string guid
		{
			get
			{
				return this.guidField;
			}
			set
			{
				this.guidField = value;
			}
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x06003EAE RID: 16046 RVA: 0x00097D29 File Offset: 0x00095F29
		// (set) Token: 0x06003EAF RID: 16047 RVA: 0x00097D31 File Offset: 0x00095F31
		[global::System.ComponentModel.DefaultValue(typeof(uint), "100")]
		public uint scale
		{
			get
			{
				return this.scaleField;
			}
			set
			{
				this.scaleField = value;
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x06003EB0 RID: 16048 RVA: 0x00097D3A File Offset: 0x00095F3A
		// (set) Token: 0x06003EB1 RID: 16049 RVA: 0x00097D42 File Offset: 0x00095F42
		[global::System.ComponentModel.DefaultValue(typeof(uint), "64")]
		public uint colorId
		{
			get
			{
				return this.colorIdField;
			}
			set
			{
				this.colorIdField = value;
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x06003EB2 RID: 16050 RVA: 0x00097D4B File Offset: 0x00095F4B
		// (set) Token: 0x06003EB3 RID: 16051 RVA: 0x00097D53 File Offset: 0x00095F53
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showPageBreaks
		{
			get
			{
				return this.showPageBreaksField;
			}
			set
			{
				this.showPageBreaksField = value;
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06003EB4 RID: 16052 RVA: 0x00097D5C File Offset: 0x00095F5C
		// (set) Token: 0x06003EB5 RID: 16053 RVA: 0x00097D64 File Offset: 0x00095F64
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showFormulas
		{
			get
			{
				return this.showFormulasField;
			}
			set
			{
				this.showFormulasField = value;
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06003EB6 RID: 16054 RVA: 0x00097D6D File Offset: 0x00095F6D
		// (set) Token: 0x06003EB7 RID: 16055 RVA: 0x00097D75 File Offset: 0x00095F75
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showGridLines
		{
			get
			{
				return this.showGridLinesField;
			}
			set
			{
				this.showGridLinesField = value;
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06003EB8 RID: 16056 RVA: 0x00097D7E File Offset: 0x00095F7E
		// (set) Token: 0x06003EB9 RID: 16057 RVA: 0x00097D86 File Offset: 0x00095F86
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showRowCol
		{
			get
			{
				return this.showRowColField;
			}
			set
			{
				this.showRowColField = value;
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06003EBA RID: 16058 RVA: 0x00097D8F File Offset: 0x00095F8F
		// (set) Token: 0x06003EBB RID: 16059 RVA: 0x00097D97 File Offset: 0x00095F97
		[global::System.ComponentModel.DefaultValue(true)]
		public bool outlineSymbols
		{
			get
			{
				return this.outlineSymbolsField;
			}
			set
			{
				this.outlineSymbolsField = value;
			}
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06003EBC RID: 16060 RVA: 0x00097DA0 File Offset: 0x00095FA0
		// (set) Token: 0x06003EBD RID: 16061 RVA: 0x00097DA8 File Offset: 0x00095FA8
		[global::System.ComponentModel.DefaultValue(true)]
		public bool zeroValues
		{
			get
			{
				return this.zeroValuesField;
			}
			set
			{
				this.zeroValuesField = value;
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x06003EBE RID: 16062 RVA: 0x00097DB1 File Offset: 0x00095FB1
		// (set) Token: 0x06003EBF RID: 16063 RVA: 0x00097DB9 File Offset: 0x00095FB9
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

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x06003EC0 RID: 16064 RVA: 0x00097DC2 File Offset: 0x00095FC2
		// (set) Token: 0x06003EC1 RID: 16065 RVA: 0x00097DCA File Offset: 0x00095FCA
		[global::System.ComponentModel.DefaultValue(false)]
		public bool printArea
		{
			get
			{
				return this.printAreaField;
			}
			set
			{
				this.printAreaField = value;
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06003EC2 RID: 16066 RVA: 0x00097DD3 File Offset: 0x00095FD3
		// (set) Token: 0x06003EC3 RID: 16067 RVA: 0x00097DDB File Offset: 0x00095FDB
		[global::System.ComponentModel.DefaultValue(false)]
		public bool filter
		{
			get
			{
				return this.filterField;
			}
			set
			{
				this.filterField = value;
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06003EC4 RID: 16068 RVA: 0x00097DE4 File Offset: 0x00095FE4
		// (set) Token: 0x06003EC5 RID: 16069 RVA: 0x00097DEC File Offset: 0x00095FEC
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showAutoFilter
		{
			get
			{
				return this.showAutoFilterField;
			}
			set
			{
				this.showAutoFilterField = value;
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06003EC6 RID: 16070 RVA: 0x00097DF5 File Offset: 0x00095FF5
		// (set) Token: 0x06003EC7 RID: 16071 RVA: 0x00097DFD File Offset: 0x00095FFD
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hiddenRows
		{
			get
			{
				return this.hiddenRowsField;
			}
			set
			{
				this.hiddenRowsField = value;
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x00097E06 File Offset: 0x00096006
		// (set) Token: 0x06003EC9 RID: 16073 RVA: 0x00097E0E File Offset: 0x0009600E
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hiddenColumns
		{
			get
			{
				return this.hiddenColumnsField;
			}
			set
			{
				this.hiddenColumnsField = value;
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06003ECA RID: 16074 RVA: 0x00097E17 File Offset: 0x00096017
		// (set) Token: 0x06003ECB RID: 16075 RVA: 0x00097E1F File Offset: 0x0009601F
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState.visible)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState state
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

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06003ECC RID: 16076 RVA: 0x00097E28 File Offset: 0x00096028
		// (set) Token: 0x06003ECD RID: 16077 RVA: 0x00097E30 File Offset: 0x00096030
		[global::System.ComponentModel.DefaultValue(false)]
		public bool filterUnique
		{
			get
			{
				return this.filterUniqueField;
			}
			set
			{
				this.filterUniqueField = value;
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06003ECE RID: 16078 RVA: 0x00097E39 File Offset: 0x00096039
		// (set) Token: 0x06003ECF RID: 16079 RVA: 0x00097E41 File Offset: 0x00096041
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetViewType.normal)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetViewType view
		{
			get
			{
				return this.viewField;
			}
			set
			{
				this.viewField = value;
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06003ED0 RID: 16080 RVA: 0x00097E4A File Offset: 0x0009604A
		// (set) Token: 0x06003ED1 RID: 16081 RVA: 0x00097E52 File Offset: 0x00096052
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showRuler
		{
			get
			{
				return this.showRulerField;
			}
			set
			{
				this.showRulerField = value;
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06003ED2 RID: 16082 RVA: 0x00097E5B File Offset: 0x0009605B
		// (set) Token: 0x06003ED3 RID: 16083 RVA: 0x00097E63 File Offset: 0x00096063
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

		// Token: 0x06003ED4 RID: 16084 RVA: 0x00097E6C File Offset: 0x0009606C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView ct_CustomSheetView = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetView();
			ct_CustomSheetView.guid = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["guid"]);
			ct_CustomSheetView.scale = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["scale"]);
			ct_CustomSheetView.colorId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["colorId"]);
			ct_CustomSheetView.showPageBreaks = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showPageBreaks"]);
			ct_CustomSheetView.showFormulas = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showFormulas"]);
			if (node.Attributes["showGridLines"] == null)
			{
				ct_CustomSheetView.showGridLines = true;
			}
			else
			{
				ct_CustomSheetView.showGridLines = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showGridLines"]);
			}
			ct_CustomSheetView.showRowCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showRowCol"]);
			ct_CustomSheetView.outlineSymbols = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["outlineSymbols"]);
			ct_CustomSheetView.zeroValues = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["zeroValues"]);
			ct_CustomSheetView.fitToPage = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fitToPage"]);
			ct_CustomSheetView.printArea = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["printArea"]);
			ct_CustomSheetView.filter = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["filter"]);
			ct_CustomSheetView.showAutoFilter = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showAutoFilter"]);
			ct_CustomSheetView.hiddenRows = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hiddenRows"]);
			ct_CustomSheetView.hiddenColumns = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hiddenColumns"]);
			if (node.Attributes["state"] != null)
			{
				ct_CustomSheetView.state = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState), node.Attributes["state"].Value);
			}
			ct_CustomSheetView.filterUnique = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["filterUnique"]);
			if (node.Attributes["view"] != null)
			{
				ct_CustomSheetView.view = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetViewType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetViewType), node.Attributes["view"].Value);
			}
			ct_CustomSheetView.showRuler = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showRuler"]);
			ct_CustomSheetView.topLeftCell = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["topLeftCell"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pane")
				{
					ct_CustomSheetView.pane = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "selection")
				{
					ct_CustomSheetView.selection = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rowBreaks")
				{
					ct_CustomSheetView.rowBreaks = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "colBreaks")
				{
					ct_CustomSheetView.colBreaks = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageMargins")
				{
					ct_CustomSheetView.pageMargins = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "printOptions")
				{
					ct_CustomSheetView.printOptions = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageSetup")
				{
					ct_CustomSheetView.pageSetup = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "headerFooter")
				{
					ct_CustomSheetView.headerFooter = global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoFilter")
				{
					ct_CustomSheetView.autoFilter = global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_CustomSheetView.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_CustomSheetView;
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x000982BC File Offset: 0x000964BC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "guid", this.guid);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "scale", this.scale, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "colorId", this.colorId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showPageBreaks", this.showPageBreaks, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showFormulas", this.showFormulas, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showGridLines", this.showGridLines, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showRowCol", this.showRowCol, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "outlineSymbols", this.outlineSymbols);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "zeroValues", this.zeroValues);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fitToPage", this.fitToPage, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "printArea", this.printArea, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "filter", this.filter, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showAutoFilter", this.showAutoFilter, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hiddenRows", this.hiddenRows, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hiddenColumns", this.hiddenColumns, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "state", this.state.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "filterUnique", this.filterUnique, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "view", this.view.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showRuler", this.showRuler, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "topLeftCell", this.topLeftCell);
			sw.Write(">");
			if (this.pane != null)
			{
				this.pane.Write(sw, "pane");
			}
			if (this.selection != null)
			{
				this.selection.Write(sw, "selection");
			}
			if (this.rowBreaks != null)
			{
				this.rowBreaks.Write(sw, "rowBreaks");
			}
			if (this.colBreaks != null)
			{
				this.colBreaks.Write(sw, "colBreaks");
			}
			if (this.pageMargins != null)
			{
				this.pageMargins.Write(sw, "pageMargins");
			}
			if (this.printOptions != null)
			{
				this.printOptions.Write(sw, "printOptions");
			}
			if (this.pageSetup != null)
			{
				this.pageSetup.Write(sw, "pageSetup");
			}
			if (this.headerFooter != null)
			{
				this.headerFooter.Write(sw, "headerFooter");
			}
			if (this.autoFilter != null)
			{
				this.autoFilter.Write(sw, "autoFilter");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040027B8 RID: 10168
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane paneField;

		// Token: 0x040027B9 RID: 10169
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection selectionField;

		// Token: 0x040027BA RID: 10170
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak rowBreaksField;

		// Token: 0x040027BB RID: 10171
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak colBreaksField;

		// Token: 0x040027BC RID: 10172
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins pageMarginsField;

		// Token: 0x040027BD RID: 10173
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions printOptionsField;

		// Token: 0x040027BE RID: 10174
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup pageSetupField;

		// Token: 0x040027BF RID: 10175
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooterField;

		// Token: 0x040027C0 RID: 10176
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter autoFilterField;

		// Token: 0x040027C1 RID: 10177
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040027C2 RID: 10178
		private string guidField = string.Empty;

		// Token: 0x040027C3 RID: 10179
		private uint scaleField;

		// Token: 0x040027C4 RID: 10180
		private uint colorIdField;

		// Token: 0x040027C5 RID: 10181
		private bool showPageBreaksField;

		// Token: 0x040027C6 RID: 10182
		private bool showFormulasField;

		// Token: 0x040027C7 RID: 10183
		private bool showGridLinesField;

		// Token: 0x040027C8 RID: 10184
		private bool showRowColField;

		// Token: 0x040027C9 RID: 10185
		private bool outlineSymbolsField;

		// Token: 0x040027CA RID: 10186
		private bool zeroValuesField;

		// Token: 0x040027CB RID: 10187
		private bool fitToPageField;

		// Token: 0x040027CC RID: 10188
		private bool printAreaField;

		// Token: 0x040027CD RID: 10189
		private bool filterField;

		// Token: 0x040027CE RID: 10190
		private bool showAutoFilterField;

		// Token: 0x040027CF RID: 10191
		private bool hiddenRowsField;

		// Token: 0x040027D0 RID: 10192
		private bool hiddenColumnsField;

		// Token: 0x040027D1 RID: 10193
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState stateField;

		// Token: 0x040027D2 RID: 10194
		private bool filterUniqueField;

		// Token: 0x040027D3 RID: 10195
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetViewType viewField;

		// Token: 0x040027D4 RID: 10196
		private bool showRulerField;

		// Token: 0x040027D5 RID: 10197
		private string topLeftCellField;
	}
}
