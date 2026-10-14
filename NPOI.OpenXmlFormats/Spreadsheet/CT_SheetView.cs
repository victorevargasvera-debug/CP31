using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000579 RID: 1401
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SheetView
	{
		// Token: 0x06003CF1 RID: 15601 RVA: 0x000940FC File Offset: 0x000922FC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView ct_SheetView = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView();
			ct_SheetView.windowProtection = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["windowProtection"]);
			ct_SheetView.showFormulas = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showFormulas"]);
			if (node.Attributes["showGridLines"] == null)
			{
				ct_SheetView.showGridLines = true;
			}
			else
			{
				ct_SheetView.showGridLines = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showGridLines"]);
			}
			if (node.Attributes["showRowColHeaders"] == null)
			{
				ct_SheetView.showRowColHeaders = true;
			}
			else
			{
				ct_SheetView.showRowColHeaders = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showRowColHeaders"]);
			}
			if (node.Attributes["showZeros"] == null)
			{
				ct_SheetView.showZeros = true;
			}
			else
			{
				ct_SheetView.showZeros = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showZeros"]);
			}
			ct_SheetView.rightToLeft = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["rightToLeft"]);
			ct_SheetView.tabSelected = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["tabSelected"]);
			ct_SheetView.showRuler = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showRuler"]);
			ct_SheetView.showOutlineSymbols = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showOutlineSymbols"]);
			ct_SheetView.defaultGridColor = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["defaultGridColor"]);
			if (node.Attributes["showWhiteSpace"] == null)
			{
				ct_SheetView.showWhiteSpace = true;
			}
			else
			{
				ct_SheetView.showWhiteSpace = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showWhiteSpace"]);
			}
			if (node.Attributes["view"] != null)
			{
				ct_SheetView.view = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetViewType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetViewType), node.Attributes["view"].Value);
			}
			ct_SheetView.topLeftCell = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["topLeftCell"]);
			ct_SheetView.colorId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["colorId"]);
			ct_SheetView.zoomScale = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["zoomScale"]);
			ct_SheetView.zoomScaleNormal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["zoomScaleNormal"]);
			ct_SheetView.zoomScaleSheetLayoutView = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["zoomScaleSheetLayoutView"]);
			ct_SheetView.zoomScalePageLayoutView = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["zoomScalePageLayoutView"]);
			ct_SheetView.workbookViewId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["workbookViewId"]);
			ct_SheetView.selection = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection>();
			ct_SheetView.pivotSelection = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotSelection>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pane")
				{
					ct_SheetView.pane = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_SheetView.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "selection")
				{
					ct_SheetView.selection.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "pivotSelection")
				{
					ct_SheetView.pivotSelection.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotSelection.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SheetView;
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x00094498 File Offset: 0x00092698
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "windowProtection", this.windowProtection, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showFormulas", this.showFormulas, false);
			if (!this.showGridLines)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showGridLines", this.showGridLines);
			}
			if (!this.showRowColHeaders)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showRowColHeaders", this.showRowColHeaders);
			}
			if (!this.showZeros)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showZeros", this.showZeros);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rightToLeft", this.rightToLeft, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tabSelected", this.tabSelected, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showRuler", this.showRuler, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showOutlineSymbols", this.showOutlineSymbols, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "defaultGridColor", this.defaultGridColor, false);
			if (!this.showWhiteSpace)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showWhiteSpace", this.showWhiteSpace);
			}
			if (this.view != global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetViewType.normal)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "view", this.view.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "topLeftCell", this.topLeftCell);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "colorId", this.colorId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "zoomScale", this.zoomScale, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "zoomScaleNormal", this.zoomScaleNormal, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "zoomScaleSheetLayoutView", this.zoomScaleSheetLayoutView, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "zoomScalePageLayoutView", this.zoomScalePageLayoutView, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "workbookViewId", this.workbookViewId, true);
			sw.Write(">");
			if (this.pane != null)
			{
				this.pane.Write(sw, "pane");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.selection != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection ct_Selection in this.selection)
				{
					ct_Selection.Write(sw, "selection");
				}
			}
			if (this.pivotSelection != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotSelection ct_PivotSelection in this.pivotSelection)
				{
					ct_PivotSelection.Write(sw, "pivotSelection");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x00094728 File Offset: 0x00092928
		public CT_SheetView()
		{
			this.pivotSelectionField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotSelection>();
			this.selectionField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection>();
			this.windowProtectionField = false;
			this.showFormulasField = false;
			this.showGridLinesField = true;
			this.showRowColHeadersField = true;
			this.showZerosField = true;
			this.rightToLeftField = false;
			this.tabSelectedField = false;
			this.showRulerField = true;
			this.showOutlineSymbolsField = true;
			this.defaultGridColorField = true;
			this.showWhiteSpaceField = true;
			this.viewField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetViewType.normal;
			this.colorIdField = 64U;
			this.zoomScaleField = 100U;
			this.zoomScaleNormalField = 0U;
			this.zoomScaleSheetLayoutViewField = 0U;
			this.zoomScalePageLayoutViewField = 0U;
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x000947CA File Offset: 0x000929CA
		public bool IsSetPane()
		{
			return this.paneField != null;
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x000947D5 File Offset: 0x000929D5
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane AddNewPane()
		{
			this.paneField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane();
			return this.paneField;
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x000947E8 File Offset: 0x000929E8
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection AddNewSelection()
		{
			if (this.selectionField == null)
			{
				this.selectionField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection ct_Selection = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection();
			this.selectionField.Add(ct_Selection);
			return ct_Selection;
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x0009481B File Offset: 0x00092A1B
		public void UnsetPane()
		{
			this.paneField = null;
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x00094824 File Offset: 0x00092A24
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection GetSelectionArray(int index)
		{
			return this.selectionField[index];
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x00094834 File Offset: 0x00092A34
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection InsertNewSelection(int index)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection ct_Selection = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection();
			this.selectionField.Insert(index, ct_Selection);
			return ct_Selection;
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x00094855 File Offset: 0x00092A55
		public int SizeOfSelectionArray()
		{
			return this.selectionField.Count;
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x00094862 File Offset: 0x00092A62
		public void SetSelectionArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection> selectionArray)
		{
			this.selectionField = selectionArray;
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06003CFC RID: 15612 RVA: 0x0009486B File Offset: 0x00092A6B
		// (set) Token: 0x06003CFD RID: 15613 RVA: 0x00094873 File Offset: 0x00092A73
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06003CFE RID: 15614 RVA: 0x0009487C File Offset: 0x00092A7C
		// (set) Token: 0x06003CFF RID: 15615 RVA: 0x00094862 File Offset: 0x00092A62
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection> selection
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

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06003D00 RID: 15616 RVA: 0x00094884 File Offset: 0x00092A84
		// (set) Token: 0x06003D01 RID: 15617 RVA: 0x0009488C File Offset: 0x00092A8C
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotSelection> pivotSelection
		{
			get
			{
				return this.pivotSelectionField;
			}
			set
			{
				this.pivotSelectionField = value;
			}
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06003D02 RID: 15618 RVA: 0x00094895 File Offset: 0x00092A95
		// (set) Token: 0x06003D03 RID: 15619 RVA: 0x0009489D File Offset: 0x00092A9D
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06003D04 RID: 15620 RVA: 0x000948A6 File Offset: 0x00092AA6
		// (set) Token: 0x06003D05 RID: 15621 RVA: 0x000948AE File Offset: 0x00092AAE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool windowProtection
		{
			get
			{
				return this.windowProtectionField;
			}
			set
			{
				this.windowProtectionField = value;
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06003D06 RID: 15622 RVA: 0x000948B7 File Offset: 0x00092AB7
		// (set) Token: 0x06003D07 RID: 15623 RVA: 0x000948BF File Offset: 0x00092ABF
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06003D08 RID: 15624 RVA: 0x000948C8 File Offset: 0x00092AC8
		// (set) Token: 0x06003D09 RID: 15625 RVA: 0x000948D0 File Offset: 0x00092AD0
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06003D0A RID: 15626 RVA: 0x000948D9 File Offset: 0x00092AD9
		// (set) Token: 0x06003D0B RID: 15627 RVA: 0x000948E1 File Offset: 0x00092AE1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showRowColHeaders
		{
			get
			{
				return this.showRowColHeadersField;
			}
			set
			{
				this.showRowColHeadersField = value;
			}
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06003D0C RID: 15628 RVA: 0x000948EA File Offset: 0x00092AEA
		// (set) Token: 0x06003D0D RID: 15629 RVA: 0x000948F2 File Offset: 0x00092AF2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showZeros
		{
			get
			{
				return this.showZerosField;
			}
			set
			{
				this.showZerosField = value;
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06003D0E RID: 15630 RVA: 0x000948FB File Offset: 0x00092AFB
		// (set) Token: 0x06003D0F RID: 15631 RVA: 0x00094903 File Offset: 0x00092B03
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool rightToLeft
		{
			get
			{
				return this.rightToLeftField;
			}
			set
			{
				this.rightToLeftField = value;
			}
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06003D10 RID: 15632 RVA: 0x0009490C File Offset: 0x00092B0C
		// (set) Token: 0x06003D11 RID: 15633 RVA: 0x00094914 File Offset: 0x00092B14
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool tabSelected
		{
			get
			{
				return this.tabSelectedField;
			}
			set
			{
				this.tabSelectedField = value;
			}
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06003D12 RID: 15634 RVA: 0x0009491D File Offset: 0x00092B1D
		// (set) Token: 0x06003D13 RID: 15635 RVA: 0x00094925 File Offset: 0x00092B25
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06003D14 RID: 15636 RVA: 0x0009492E File Offset: 0x00092B2E
		// (set) Token: 0x06003D15 RID: 15637 RVA: 0x00094936 File Offset: 0x00092B36
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showOutlineSymbols
		{
			get
			{
				return this.showOutlineSymbolsField;
			}
			set
			{
				this.showOutlineSymbolsField = value;
			}
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06003D16 RID: 15638 RVA: 0x0009493F File Offset: 0x00092B3F
		// (set) Token: 0x06003D17 RID: 15639 RVA: 0x00094947 File Offset: 0x00092B47
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool defaultGridColor
		{
			get
			{
				return this.defaultGridColorField;
			}
			set
			{
				this.defaultGridColorField = value;
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06003D18 RID: 15640 RVA: 0x00094950 File Offset: 0x00092B50
		// (set) Token: 0x06003D19 RID: 15641 RVA: 0x00094958 File Offset: 0x00092B58
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showWhiteSpace
		{
			get
			{
				return this.showWhiteSpaceField;
			}
			set
			{
				this.showWhiteSpaceField = value;
			}
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06003D1A RID: 15642 RVA: 0x00094961 File Offset: 0x00092B61
		// (set) Token: 0x06003D1B RID: 15643 RVA: 0x00094969 File Offset: 0x00092B69
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06003D1C RID: 15644 RVA: 0x00094972 File Offset: 0x00092B72
		// (set) Token: 0x06003D1D RID: 15645 RVA: 0x0009497A File Offset: 0x00092B7A
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

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06003D1E RID: 15646 RVA: 0x00094983 File Offset: 0x00092B83
		// (set) Token: 0x06003D1F RID: 15647 RVA: 0x0009498B File Offset: 0x00092B8B
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06003D20 RID: 15648 RVA: 0x00094994 File Offset: 0x00092B94
		// (set) Token: 0x06003D21 RID: 15649 RVA: 0x0009499C File Offset: 0x00092B9C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "100")]
		public uint zoomScale
		{
			get
			{
				return this.zoomScaleField;
			}
			set
			{
				this.zoomScaleField = value;
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06003D22 RID: 15650 RVA: 0x000949A5 File Offset: 0x00092BA5
		// (set) Token: 0x06003D23 RID: 15651 RVA: 0x000949AD File Offset: 0x00092BAD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint zoomScaleNormal
		{
			get
			{
				return this.zoomScaleNormalField;
			}
			set
			{
				this.zoomScaleNormalField = value;
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06003D24 RID: 15652 RVA: 0x000949B6 File Offset: 0x00092BB6
		// (set) Token: 0x06003D25 RID: 15653 RVA: 0x000949BE File Offset: 0x00092BBE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint zoomScaleSheetLayoutView
		{
			get
			{
				return this.zoomScaleSheetLayoutViewField;
			}
			set
			{
				this.zoomScaleSheetLayoutViewField = value;
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06003D26 RID: 15654 RVA: 0x000949C7 File Offset: 0x00092BC7
		// (set) Token: 0x06003D27 RID: 15655 RVA: 0x000949CF File Offset: 0x00092BCF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint zoomScalePageLayoutView
		{
			get
			{
				return this.zoomScalePageLayoutViewField;
			}
			set
			{
				this.zoomScalePageLayoutViewField = value;
			}
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06003D28 RID: 15656 RVA: 0x000949D8 File Offset: 0x00092BD8
		// (set) Token: 0x06003D29 RID: 15657 RVA: 0x000949E0 File Offset: 0x00092BE0
		[global::System.Xml.Serialization.XmlAttribute]
		public uint workbookViewId
		{
			get
			{
				return this.workbookViewIdField;
			}
			set
			{
				this.workbookViewIdField = value;
			}
		}

		// Token: 0x040026F0 RID: 9968
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane paneField;

		// Token: 0x040026F1 RID: 9969
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection> selectionField;

		// Token: 0x040026F2 RID: 9970
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotSelection> pivotSelectionField;

		// Token: 0x040026F3 RID: 9971
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040026F4 RID: 9972
		private bool windowProtectionField;

		// Token: 0x040026F5 RID: 9973
		private bool showFormulasField;

		// Token: 0x040026F6 RID: 9974
		private bool showGridLinesField;

		// Token: 0x040026F7 RID: 9975
		private bool showRowColHeadersField;

		// Token: 0x040026F8 RID: 9976
		private bool showZerosField;

		// Token: 0x040026F9 RID: 9977
		private bool rightToLeftField;

		// Token: 0x040026FA RID: 9978
		private bool tabSelectedField;

		// Token: 0x040026FB RID: 9979
		private bool showRulerField;

		// Token: 0x040026FC RID: 9980
		private bool showOutlineSymbolsField;

		// Token: 0x040026FD RID: 9981
		private bool defaultGridColorField;

		// Token: 0x040026FE RID: 9982
		private bool showWhiteSpaceField;

		// Token: 0x040026FF RID: 9983
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetViewType viewField;

		// Token: 0x04002700 RID: 9984
		private string topLeftCellField;

		// Token: 0x04002701 RID: 9985
		private uint colorIdField;

		// Token: 0x04002702 RID: 9986
		private uint zoomScaleField;

		// Token: 0x04002703 RID: 9987
		private uint zoomScaleNormalField;

		// Token: 0x04002704 RID: 9988
		private uint zoomScaleSheetLayoutViewField;

		// Token: 0x04002705 RID: 9989
		private uint zoomScalePageLayoutViewField;

		// Token: 0x04002706 RID: 9990
		private uint workbookViewIdField;
	}
}
