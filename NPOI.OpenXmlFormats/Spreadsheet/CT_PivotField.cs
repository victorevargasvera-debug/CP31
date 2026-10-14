using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004BC RID: 1212
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PivotField
	{
		// Token: 0x06003253 RID: 12883 RVA: 0x0007E08C File Offset: 0x0007C28C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField ct_PivotField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField();
			ct_PivotField.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			if (node.Attributes["axis"] != null)
			{
				ct_PivotField.axis = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis), node.Attributes["axis"].Value);
			}
			if (node.Attributes["dataField"] != null)
			{
				ct_PivotField.dataField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dataField"]);
			}
			ct_PivotField.subtotalCaption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["subtotalCaption"]);
			if (node.Attributes["showDropDowns"] != null)
			{
				ct_PivotField.showDropDowns = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showDropDowns"]);
			}
			if (node.Attributes["hiddenLevel"] != null)
			{
				ct_PivotField.hiddenLevel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hiddenLevel"]);
			}
			ct_PivotField.uniqueMemberProperty = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uniqueMemberProperty"]);
			if (node.Attributes["compact"] != null)
			{
				ct_PivotField.compact = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["compact"]);
			}
			if (node.Attributes["allDrilled"] != null)
			{
				ct_PivotField.allDrilled = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["allDrilled"]);
			}
			if (node.Attributes["numFmtId"] != null)
			{
				ct_PivotField.numFmtId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["numFmtId"]);
			}
			if (node.Attributes["outline"] != null)
			{
				ct_PivotField.outline = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["outline"]);
			}
			if (node.Attributes["subtotalTop"] != null)
			{
				ct_PivotField.subtotalTop = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["subtotalTop"]);
			}
			if (node.Attributes["dragToRow"] != null)
			{
				ct_PivotField.dragToRow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dragToRow"]);
			}
			if (node.Attributes["dragToCol"] != null)
			{
				ct_PivotField.dragToCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dragToCol"]);
			}
			if (node.Attributes["multipleItemSelectionAllowed"] != null)
			{
				ct_PivotField.multipleItemSelectionAllowed = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["multipleItemSelectionAllowed"]);
			}
			if (node.Attributes["dragToPage"] != null)
			{
				ct_PivotField.dragToPage = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dragToPage"]);
			}
			if (node.Attributes["dragToData"] != null)
			{
				ct_PivotField.dragToData = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dragToData"]);
			}
			if (node.Attributes["dragOff"] != null)
			{
				ct_PivotField.dragOff = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dragOff"]);
			}
			if (node.Attributes["showAll"] != null)
			{
				ct_PivotField.showAll = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showAll"]);
			}
			if (node.Attributes["insertBlankRow"] != null)
			{
				ct_PivotField.insertBlankRow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["insertBlankRow"]);
			}
			if (node.Attributes["serverField"] != null)
			{
				ct_PivotField.serverField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["serverField"]);
			}
			if (node.Attributes["insertPageBreak"] != null)
			{
				ct_PivotField.insertPageBreak = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["insertPageBreak"]);
			}
			if (node.Attributes["autoShow"] != null)
			{
				ct_PivotField.autoShow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoShow"]);
			}
			if (node.Attributes["topAutoShow"] != null)
			{
				ct_PivotField.topAutoShow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["topAutoShow"]);
			}
			if (node.Attributes["hideNewItems"] != null)
			{
				ct_PivotField.hideNewItems = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hideNewItems"]);
			}
			if (node.Attributes["measureFilter"] != null)
			{
				ct_PivotField.measureFilter = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["measureFilter"]);
			}
			if (node.Attributes["includeNewItemsInFilter"] != null)
			{
				ct_PivotField.includeNewItemsInFilter = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["includeNewItemsInFilter"]);
			}
			if (node.Attributes["itemPageCount"] != null)
			{
				ct_PivotField.itemPageCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["itemPageCount"]);
			}
			if (node.Attributes["sortType"] != null)
			{
				ct_PivotField.sortType = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_FieldSortType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_FieldSortType), node.Attributes["sortType"].Value);
			}
			if (node.Attributes["dataSourceSort"] != null)
			{
				ct_PivotField.dataSourceSort = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dataSourceSort"]);
			}
			if (node.Attributes["nonAutoSortDefault"] != null)
			{
				ct_PivotField.nonAutoSortDefault = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["nonAutoSortDefault"]);
			}
			if (node.Attributes["rankBy"] != null)
			{
				ct_PivotField.rankBy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["rankBy"]);
			}
			if (node.Attributes["defaultSubtotal"] != null)
			{
				ct_PivotField.defaultSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["defaultSubtotal"]);
			}
			if (node.Attributes["sumSubtotal"] != null)
			{
				ct_PivotField.sumSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["sumSubtotal"]);
			}
			if (node.Attributes["countASubtotal"] != null)
			{
				ct_PivotField.countASubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["countASubtotal"]);
			}
			if (node.Attributes["avgSubtotal"] != null)
			{
				ct_PivotField.avgSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["avgSubtotal"]);
			}
			if (node.Attributes["maxSubtotal"] != null)
			{
				ct_PivotField.maxSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["maxSubtotal"]);
			}
			if (node.Attributes["minSubtotal"] != null)
			{
				ct_PivotField.minSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["minSubtotal"]);
			}
			if (node.Attributes["productSubtotal"] != null)
			{
				ct_PivotField.productSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["productSubtotal"]);
			}
			if (node.Attributes["countSubtotal"] != null)
			{
				ct_PivotField.countSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["countSubtotal"]);
			}
			if (node.Attributes["stdDevSubtotal"] != null)
			{
				ct_PivotField.stdDevSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["stdDevSubtotal"]);
			}
			if (node.Attributes["stdDevPSubtotal"] != null)
			{
				ct_PivotField.stdDevPSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["stdDevPSubtotal"]);
			}
			if (node.Attributes["varSubtotal"] != null)
			{
				ct_PivotField.varSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["varSubtotal"]);
			}
			if (node.Attributes["varPSubtotal"] != null)
			{
				ct_PivotField.varPSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["varPSubtotal"]);
			}
			if (node.Attributes["showPropCell"] != null)
			{
				ct_PivotField.showPropCell = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showPropCell"]);
			}
			if (node.Attributes["showPropTip"] != null)
			{
				ct_PivotField.showPropTip = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showPropTip"]);
			}
			if (node.Attributes["showPropAsCaption"] != null)
			{
				ct_PivotField.showPropAsCaption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showPropAsCaption"]);
			}
			if (node.Attributes["defaultAttributeDrillState"] != null)
			{
				ct_PivotField.defaultAttributeDrillState = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["defaultAttributeDrillState"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "items")
				{
					ct_PivotField.items = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Items.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoSortScope")
				{
					ct_PivotField.autoSortScope = global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoSortScope.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_PivotField.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PivotField;
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x0007E9B0 File Offset: 0x0007CBB0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "axis", this.axis.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dataField", this.dataField);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "subtotalCaption", this.subtotalCaption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showDropDowns", this.showDropDowns);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hiddenLevel", this.hiddenLevel);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uniqueMemberProperty", this.uniqueMemberProperty);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "compact", this.compact);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "allDrilled", this.allDrilled);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "numFmtId", this.numFmtId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "outline", this.outline);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "subtotalTop", this.subtotalTop);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dragToRow", this.dragToRow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dragToCol", this.dragToCol);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "multipleItemSelectionAllowed", this.multipleItemSelectionAllowed);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dragToPage", this.dragToPage);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dragToData", this.dragToData);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dragOff", this.dragOff);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showAll", this.showAll);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "insertBlankRow", this.insertBlankRow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "serverField", this.serverField);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "insertPageBreak", this.insertPageBreak);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoShow", this.autoShow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "topAutoShow", this.topAutoShow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hideNewItems", this.hideNewItems);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "measureFilter", this.measureFilter);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "includeNewItemsInFilter", this.includeNewItemsInFilter);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "itemPageCount", this.itemPageCount, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sortType", this.sortType.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dataSourceSort", this.dataSourceSort);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "nonAutoSortDefault", this.nonAutoSortDefault);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rankBy", this.rankBy, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "defaultSubtotal", this.defaultSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sumSubtotal", this.sumSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "countASubtotal", this.countASubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "avgSubtotal", this.avgSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "maxSubtotal", this.maxSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "minSubtotal", this.minSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "productSubtotal", this.productSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "countSubtotal", this.countSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "stdDevSubtotal", this.stdDevSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "stdDevPSubtotal", this.stdDevPSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "varSubtotal", this.varSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "varPSubtotal", this.varPSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showPropCell", this.showPropCell);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showPropTip", this.showPropTip);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showPropAsCaption", this.showPropAsCaption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "defaultAttributeDrillState", this.defaultAttributeDrillState);
			sw.Write(">");
			if (this.items != null)
			{
				this.items.Write(sw, "items");
			}
			if (this.autoSortScope != null)
			{
				this.autoSortScope.Write(sw, "autoSortScope");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x0007ED84 File Offset: 0x0007CF84
		public CT_PivotField()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.autoSortScopeField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoSortScope();
			this.itemsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Items();
			this.dataFieldField = false;
			this.showDropDownsField = true;
			this.hiddenLevelField = false;
			this.compactField = true;
			this.allDrilledField = false;
			this.outlineField = true;
			this.subtotalTopField = true;
			this.dragToRowField = true;
			this.dragToColField = true;
			this.multipleItemSelectionAllowedField = false;
			this.dragToPageField = true;
			this.dragToDataField = true;
			this.dragOffField = true;
			this.showAllField = true;
			this.insertBlankRowField = false;
			this.serverFieldField = false;
			this.insertPageBreakField = false;
			this.autoShowField = false;
			this.topAutoShowField = true;
			this.hideNewItemsField = false;
			this.measureFilterField = false;
			this.includeNewItemsInFilterField = false;
			this.itemPageCountField = 10U;
			this.sortTypeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_FieldSortType.manual;
			this.nonAutoSortDefaultField = false;
			this.defaultSubtotalField = true;
			this.sumSubtotalField = false;
			this.countASubtotalField = false;
			this.avgSubtotalField = false;
			this.maxSubtotalField = false;
			this.minSubtotalField = false;
			this.productSubtotalField = false;
			this.countSubtotalField = false;
			this.stdDevSubtotalField = false;
			this.stdDevPSubtotalField = false;
			this.varSubtotalField = false;
			this.varPSubtotalField = false;
			this.showPropCellField = false;
			this.showPropTipField = false;
			this.showPropAsCaptionField = false;
			this.defaultAttributeDrillStateField = false;
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x0007EED8 File Offset: 0x0007D0D8
		// (set) Token: 0x06003257 RID: 12887 RVA: 0x0007EEE0 File Offset: 0x0007D0E0
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Items items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x0007EEE9 File Offset: 0x0007D0E9
		// (set) Token: 0x06003259 RID: 12889 RVA: 0x0007EEF1 File Offset: 0x0007D0F1
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoSortScope autoSortScope
		{
			get
			{
				return this.autoSortScopeField;
			}
			set
			{
				this.autoSortScopeField = value;
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x0007EEFA File Offset: 0x0007D0FA
		// (set) Token: 0x0600325B RID: 12891 RVA: 0x0007EF02 File Offset: 0x0007D102
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x0007EF0B File Offset: 0x0007D10B
		// (set) Token: 0x0600325D RID: 12893 RVA: 0x0007EF13 File Offset: 0x0007D113
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x0007EF1C File Offset: 0x0007D11C
		// (set) Token: 0x0600325F RID: 12895 RVA: 0x0007EF24 File Offset: 0x0007D124
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis axis
		{
			get
			{
				return this.axisField;
			}
			set
			{
				this.axisField = value;
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06003260 RID: 12896 RVA: 0x0007EF2D File Offset: 0x0007D12D
		// (set) Token: 0x06003261 RID: 12897 RVA: 0x0007EF35 File Offset: 0x0007D135
		[global::System.Xml.Serialization.XmlIgnore]
		public bool axisSpecified
		{
			get
			{
				return this.axisFieldSpecified;
			}
			set
			{
				this.axisFieldSpecified = value;
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06003262 RID: 12898 RVA: 0x0007EF3E File Offset: 0x0007D13E
		// (set) Token: 0x06003263 RID: 12899 RVA: 0x0007EF46 File Offset: 0x0007D146
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool dataField
		{
			get
			{
				return this.dataFieldField;
			}
			set
			{
				this.dataFieldField = value;
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06003264 RID: 12900 RVA: 0x0007EF4F File Offset: 0x0007D14F
		// (set) Token: 0x06003265 RID: 12901 RVA: 0x0007EF57 File Offset: 0x0007D157
		[global::System.Xml.Serialization.XmlAttribute]
		public string subtotalCaption
		{
			get
			{
				return this.subtotalCaptionField;
			}
			set
			{
				this.subtotalCaptionField = value;
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06003266 RID: 12902 RVA: 0x0007EF60 File Offset: 0x0007D160
		// (set) Token: 0x06003267 RID: 12903 RVA: 0x0007EF68 File Offset: 0x0007D168
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showDropDowns
		{
			get
			{
				return this.showDropDownsField;
			}
			set
			{
				this.showDropDownsField = value;
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06003268 RID: 12904 RVA: 0x0007EF71 File Offset: 0x0007D171
		// (set) Token: 0x06003269 RID: 12905 RVA: 0x0007EF79 File Offset: 0x0007D179
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hiddenLevel
		{
			get
			{
				return this.hiddenLevelField;
			}
			set
			{
				this.hiddenLevelField = value;
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x0600326A RID: 12906 RVA: 0x0007EF82 File Offset: 0x0007D182
		// (set) Token: 0x0600326B RID: 12907 RVA: 0x0007EF8A File Offset: 0x0007D18A
		[global::System.Xml.Serialization.XmlAttribute]
		public string uniqueMemberProperty
		{
			get
			{
				return this.uniqueMemberPropertyField;
			}
			set
			{
				this.uniqueMemberPropertyField = value;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x0600326C RID: 12908 RVA: 0x0007EF93 File Offset: 0x0007D193
		// (set) Token: 0x0600326D RID: 12909 RVA: 0x0007EF9B File Offset: 0x0007D19B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool compact
		{
			get
			{
				return this.compactField;
			}
			set
			{
				this.compactField = value;
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x0600326E RID: 12910 RVA: 0x0007EFA4 File Offset: 0x0007D1A4
		// (set) Token: 0x0600326F RID: 12911 RVA: 0x0007EFAC File Offset: 0x0007D1AC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool allDrilled
		{
			get
			{
				return this.allDrilledField;
			}
			set
			{
				this.allDrilledField = value;
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06003270 RID: 12912 RVA: 0x0007EFB5 File Offset: 0x0007D1B5
		// (set) Token: 0x06003271 RID: 12913 RVA: 0x0007EFBD File Offset: 0x0007D1BD
		[global::System.Xml.Serialization.XmlAttribute]
		public uint numFmtId
		{
			get
			{
				return this.numFmtIdField;
			}
			set
			{
				this.numFmtIdField = value;
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06003272 RID: 12914 RVA: 0x0007EFC6 File Offset: 0x0007D1C6
		// (set) Token: 0x06003273 RID: 12915 RVA: 0x0007EFCE File Offset: 0x0007D1CE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool numFmtIdSpecified
		{
			get
			{
				return this.numFmtIdFieldSpecified;
			}
			set
			{
				this.numFmtIdFieldSpecified = value;
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06003274 RID: 12916 RVA: 0x0007EFD7 File Offset: 0x0007D1D7
		// (set) Token: 0x06003275 RID: 12917 RVA: 0x0007EFDF File Offset: 0x0007D1DF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool outline
		{
			get
			{
				return this.outlineField;
			}
			set
			{
				this.outlineField = value;
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06003276 RID: 12918 RVA: 0x0007EFE8 File Offset: 0x0007D1E8
		// (set) Token: 0x06003277 RID: 12919 RVA: 0x0007EFF0 File Offset: 0x0007D1F0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool subtotalTop
		{
			get
			{
				return this.subtotalTopField;
			}
			set
			{
				this.subtotalTopField = value;
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x0007EFF9 File Offset: 0x0007D1F9
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x0007F001 File Offset: 0x0007D201
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dragToRow
		{
			get
			{
				return this.dragToRowField;
			}
			set
			{
				this.dragToRowField = value;
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x0007F00A File Offset: 0x0007D20A
		// (set) Token: 0x0600327B RID: 12923 RVA: 0x0007F012 File Offset: 0x0007D212
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dragToCol
		{
			get
			{
				return this.dragToColField;
			}
			set
			{
				this.dragToColField = value;
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x0600327C RID: 12924 RVA: 0x0007F01B File Offset: 0x0007D21B
		// (set) Token: 0x0600327D RID: 12925 RVA: 0x0007F023 File Offset: 0x0007D223
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool multipleItemSelectionAllowed
		{
			get
			{
				return this.multipleItemSelectionAllowedField;
			}
			set
			{
				this.multipleItemSelectionAllowedField = value;
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x0007F02C File Offset: 0x0007D22C
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x0007F034 File Offset: 0x0007D234
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dragToPage
		{
			get
			{
				return this.dragToPageField;
			}
			set
			{
				this.dragToPageField = value;
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x0007F03D File Offset: 0x0007D23D
		// (set) Token: 0x06003281 RID: 12929 RVA: 0x0007F045 File Offset: 0x0007D245
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dragToData
		{
			get
			{
				return this.dragToDataField;
			}
			set
			{
				this.dragToDataField = value;
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x0007F04E File Offset: 0x0007D24E
		// (set) Token: 0x06003283 RID: 12931 RVA: 0x0007F056 File Offset: 0x0007D256
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dragOff
		{
			get
			{
				return this.dragOffField;
			}
			set
			{
				this.dragOffField = value;
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06003284 RID: 12932 RVA: 0x0007F05F File Offset: 0x0007D25F
		// (set) Token: 0x06003285 RID: 12933 RVA: 0x0007F067 File Offset: 0x0007D267
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showAll
		{
			get
			{
				return this.showAllField;
			}
			set
			{
				this.showAllField = value;
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x0007F070 File Offset: 0x0007D270
		// (set) Token: 0x06003287 RID: 12935 RVA: 0x0007F078 File Offset: 0x0007D278
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool insertBlankRow
		{
			get
			{
				return this.insertBlankRowField;
			}
			set
			{
				this.insertBlankRowField = value;
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x0007F081 File Offset: 0x0007D281
		// (set) Token: 0x06003289 RID: 12937 RVA: 0x0007F089 File Offset: 0x0007D289
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool serverField
		{
			get
			{
				return this.serverFieldField;
			}
			set
			{
				this.serverFieldField = value;
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x0600328A RID: 12938 RVA: 0x0007F092 File Offset: 0x0007D292
		// (set) Token: 0x0600328B RID: 12939 RVA: 0x0007F09A File Offset: 0x0007D29A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool insertPageBreak
		{
			get
			{
				return this.insertPageBreakField;
			}
			set
			{
				this.insertPageBreakField = value;
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x0600328C RID: 12940 RVA: 0x0007F0A3 File Offset: 0x0007D2A3
		// (set) Token: 0x0600328D RID: 12941 RVA: 0x0007F0AB File Offset: 0x0007D2AB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool autoShow
		{
			get
			{
				return this.autoShowField;
			}
			set
			{
				this.autoShowField = value;
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x0007F0B4 File Offset: 0x0007D2B4
		// (set) Token: 0x0600328F RID: 12943 RVA: 0x0007F0BC File Offset: 0x0007D2BC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool topAutoShow
		{
			get
			{
				return this.topAutoShowField;
			}
			set
			{
				this.topAutoShowField = value;
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x0007F0C5 File Offset: 0x0007D2C5
		// (set) Token: 0x06003291 RID: 12945 RVA: 0x0007F0CD File Offset: 0x0007D2CD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hideNewItems
		{
			get
			{
				return this.hideNewItemsField;
			}
			set
			{
				this.hideNewItemsField = value;
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x0007F0D6 File Offset: 0x0007D2D6
		// (set) Token: 0x06003293 RID: 12947 RVA: 0x0007F0DE File Offset: 0x0007D2DE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool measureFilter
		{
			get
			{
				return this.measureFilterField;
			}
			set
			{
				this.measureFilterField = value;
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06003294 RID: 12948 RVA: 0x0007F0E7 File Offset: 0x0007D2E7
		// (set) Token: 0x06003295 RID: 12949 RVA: 0x0007F0EF File Offset: 0x0007D2EF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool includeNewItemsInFilter
		{
			get
			{
				return this.includeNewItemsInFilterField;
			}
			set
			{
				this.includeNewItemsInFilterField = value;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06003296 RID: 12950 RVA: 0x0007F0F8 File Offset: 0x0007D2F8
		// (set) Token: 0x06003297 RID: 12951 RVA: 0x0007F100 File Offset: 0x0007D300
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "10")]
		public uint itemPageCount
		{
			get
			{
				return this.itemPageCountField;
			}
			set
			{
				this.itemPageCountField = value;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06003298 RID: 12952 RVA: 0x0007F109 File Offset: 0x0007D309
		// (set) Token: 0x06003299 RID: 12953 RVA: 0x0007F111 File Offset: 0x0007D311
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_FieldSortType.manual)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_FieldSortType sortType
		{
			get
			{
				return this.sortTypeField;
			}
			set
			{
				this.sortTypeField = value;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x0600329A RID: 12954 RVA: 0x0007F11A File Offset: 0x0007D31A
		// (set) Token: 0x0600329B RID: 12955 RVA: 0x0007F122 File Offset: 0x0007D322
		[global::System.Xml.Serialization.XmlAttribute]
		public bool dataSourceSort
		{
			get
			{
				return this.dataSourceSortField;
			}
			set
			{
				this.dataSourceSortField = value;
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x0600329C RID: 12956 RVA: 0x0007F12B File Offset: 0x0007D32B
		// (set) Token: 0x0600329D RID: 12957 RVA: 0x0007F133 File Offset: 0x0007D333
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dataSourceSortSpecified
		{
			get
			{
				return this.dataSourceSortFieldSpecified;
			}
			set
			{
				this.dataSourceSortFieldSpecified = value;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x0600329E RID: 12958 RVA: 0x0007F13C File Offset: 0x0007D33C
		// (set) Token: 0x0600329F RID: 12959 RVA: 0x0007F144 File Offset: 0x0007D344
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool nonAutoSortDefault
		{
			get
			{
				return this.nonAutoSortDefaultField;
			}
			set
			{
				this.nonAutoSortDefaultField = value;
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x060032A0 RID: 12960 RVA: 0x0007F14D File Offset: 0x0007D34D
		// (set) Token: 0x060032A1 RID: 12961 RVA: 0x0007F155 File Offset: 0x0007D355
		[global::System.Xml.Serialization.XmlAttribute]
		public uint rankBy
		{
			get
			{
				return this.rankByField;
			}
			set
			{
				this.rankByField = value;
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x060032A2 RID: 12962 RVA: 0x0007F15E File Offset: 0x0007D35E
		// (set) Token: 0x060032A3 RID: 12963 RVA: 0x0007F166 File Offset: 0x0007D366
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rankBySpecified
		{
			get
			{
				return this.rankByFieldSpecified;
			}
			set
			{
				this.rankByFieldSpecified = value;
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x0007F16F File Offset: 0x0007D36F
		// (set) Token: 0x060032A5 RID: 12965 RVA: 0x0007F177 File Offset: 0x0007D377
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool defaultSubtotal
		{
			get
			{
				return this.defaultSubtotalField;
			}
			set
			{
				this.defaultSubtotalField = value;
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x060032A6 RID: 12966 RVA: 0x0007F180 File Offset: 0x0007D380
		// (set) Token: 0x060032A7 RID: 12967 RVA: 0x0007F188 File Offset: 0x0007D388
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool sumSubtotal
		{
			get
			{
				return this.sumSubtotalField;
			}
			set
			{
				this.sumSubtotalField = value;
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x0007F191 File Offset: 0x0007D391
		// (set) Token: 0x060032A9 RID: 12969 RVA: 0x0007F199 File Offset: 0x0007D399
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool countASubtotal
		{
			get
			{
				return this.countASubtotalField;
			}
			set
			{
				this.countASubtotalField = value;
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x0007F1A2 File Offset: 0x0007D3A2
		// (set) Token: 0x060032AB RID: 12971 RVA: 0x0007F1AA File Offset: 0x0007D3AA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool avgSubtotal
		{
			get
			{
				return this.avgSubtotalField;
			}
			set
			{
				this.avgSubtotalField = value;
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x0007F1B3 File Offset: 0x0007D3B3
		// (set) Token: 0x060032AD RID: 12973 RVA: 0x0007F1BB File Offset: 0x0007D3BB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool maxSubtotal
		{
			get
			{
				return this.maxSubtotalField;
			}
			set
			{
				this.maxSubtotalField = value;
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x0007F1C4 File Offset: 0x0007D3C4
		// (set) Token: 0x060032AF RID: 12975 RVA: 0x0007F1CC File Offset: 0x0007D3CC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool minSubtotal
		{
			get
			{
				return this.minSubtotalField;
			}
			set
			{
				this.minSubtotalField = value;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x0007F1D5 File Offset: 0x0007D3D5
		// (set) Token: 0x060032B1 RID: 12977 RVA: 0x0007F1DD File Offset: 0x0007D3DD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool productSubtotal
		{
			get
			{
				return this.productSubtotalField;
			}
			set
			{
				this.productSubtotalField = value;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x0007F1E6 File Offset: 0x0007D3E6
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x0007F1EE File Offset: 0x0007D3EE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool countSubtotal
		{
			get
			{
				return this.countSubtotalField;
			}
			set
			{
				this.countSubtotalField = value;
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x0007F1F7 File Offset: 0x0007D3F7
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x0007F1FF File Offset: 0x0007D3FF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool stdDevSubtotal
		{
			get
			{
				return this.stdDevSubtotalField;
			}
			set
			{
				this.stdDevSubtotalField = value;
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x0007F208 File Offset: 0x0007D408
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x0007F210 File Offset: 0x0007D410
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool stdDevPSubtotal
		{
			get
			{
				return this.stdDevPSubtotalField;
			}
			set
			{
				this.stdDevPSubtotalField = value;
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x0007F219 File Offset: 0x0007D419
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x0007F221 File Offset: 0x0007D421
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool varSubtotal
		{
			get
			{
				return this.varSubtotalField;
			}
			set
			{
				this.varSubtotalField = value;
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x0007F22A File Offset: 0x0007D42A
		// (set) Token: 0x060032BB RID: 12987 RVA: 0x0007F232 File Offset: 0x0007D432
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool varPSubtotal
		{
			get
			{
				return this.varPSubtotalField;
			}
			set
			{
				this.varPSubtotalField = value;
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x0007F23B File Offset: 0x0007D43B
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x0007F243 File Offset: 0x0007D443
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showPropCell
		{
			get
			{
				return this.showPropCellField;
			}
			set
			{
				this.showPropCellField = value;
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x0007F24C File Offset: 0x0007D44C
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x0007F254 File Offset: 0x0007D454
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showPropTip
		{
			get
			{
				return this.showPropTipField;
			}
			set
			{
				this.showPropTipField = value;
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x0007F25D File Offset: 0x0007D45D
		// (set) Token: 0x060032C1 RID: 12993 RVA: 0x0007F265 File Offset: 0x0007D465
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showPropAsCaption
		{
			get
			{
				return this.showPropAsCaptionField;
			}
			set
			{
				this.showPropAsCaptionField = value;
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x0007F26E File Offset: 0x0007D46E
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x0007F276 File Offset: 0x0007D476
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool defaultAttributeDrillState
		{
			get
			{
				return this.defaultAttributeDrillStateField;
			}
			set
			{
				this.defaultAttributeDrillStateField = value;
			}
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x0007F27F File Offset: 0x0007D47F
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Items AddNewItems()
		{
			this.itemsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Items();
			return this.itemsField;
		}

		// Token: 0x040021B8 RID: 8632
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Items itemsField;

		// Token: 0x040021B9 RID: 8633
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoSortScope autoSortScopeField;

		// Token: 0x040021BA RID: 8634
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040021BB RID: 8635
		private string nameField;

		// Token: 0x040021BC RID: 8636
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis axisField;

		// Token: 0x040021BD RID: 8637
		private bool axisFieldSpecified;

		// Token: 0x040021BE RID: 8638
		private bool dataFieldField;

		// Token: 0x040021BF RID: 8639
		private string subtotalCaptionField;

		// Token: 0x040021C0 RID: 8640
		private bool showDropDownsField;

		// Token: 0x040021C1 RID: 8641
		private bool hiddenLevelField;

		// Token: 0x040021C2 RID: 8642
		private string uniqueMemberPropertyField;

		// Token: 0x040021C3 RID: 8643
		private bool compactField;

		// Token: 0x040021C4 RID: 8644
		private bool allDrilledField;

		// Token: 0x040021C5 RID: 8645
		private uint numFmtIdField;

		// Token: 0x040021C6 RID: 8646
		private bool numFmtIdFieldSpecified;

		// Token: 0x040021C7 RID: 8647
		private bool outlineField;

		// Token: 0x040021C8 RID: 8648
		private bool subtotalTopField;

		// Token: 0x040021C9 RID: 8649
		private bool dragToRowField;

		// Token: 0x040021CA RID: 8650
		private bool dragToColField;

		// Token: 0x040021CB RID: 8651
		private bool multipleItemSelectionAllowedField;

		// Token: 0x040021CC RID: 8652
		private bool dragToPageField;

		// Token: 0x040021CD RID: 8653
		private bool dragToDataField;

		// Token: 0x040021CE RID: 8654
		private bool dragOffField;

		// Token: 0x040021CF RID: 8655
		private bool showAllField;

		// Token: 0x040021D0 RID: 8656
		private bool insertBlankRowField;

		// Token: 0x040021D1 RID: 8657
		private bool serverFieldField;

		// Token: 0x040021D2 RID: 8658
		private bool insertPageBreakField;

		// Token: 0x040021D3 RID: 8659
		private bool autoShowField;

		// Token: 0x040021D4 RID: 8660
		private bool topAutoShowField;

		// Token: 0x040021D5 RID: 8661
		private bool hideNewItemsField;

		// Token: 0x040021D6 RID: 8662
		private bool measureFilterField;

		// Token: 0x040021D7 RID: 8663
		private bool includeNewItemsInFilterField;

		// Token: 0x040021D8 RID: 8664
		private uint itemPageCountField;

		// Token: 0x040021D9 RID: 8665
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_FieldSortType sortTypeField;

		// Token: 0x040021DA RID: 8666
		private bool dataSourceSortField;

		// Token: 0x040021DB RID: 8667
		private bool dataSourceSortFieldSpecified;

		// Token: 0x040021DC RID: 8668
		private bool nonAutoSortDefaultField;

		// Token: 0x040021DD RID: 8669
		private uint rankByField;

		// Token: 0x040021DE RID: 8670
		private bool rankByFieldSpecified;

		// Token: 0x040021DF RID: 8671
		private bool defaultSubtotalField;

		// Token: 0x040021E0 RID: 8672
		private bool sumSubtotalField;

		// Token: 0x040021E1 RID: 8673
		private bool countASubtotalField;

		// Token: 0x040021E2 RID: 8674
		private bool avgSubtotalField;

		// Token: 0x040021E3 RID: 8675
		private bool maxSubtotalField;

		// Token: 0x040021E4 RID: 8676
		private bool minSubtotalField;

		// Token: 0x040021E5 RID: 8677
		private bool productSubtotalField;

		// Token: 0x040021E6 RID: 8678
		private bool countSubtotalField;

		// Token: 0x040021E7 RID: 8679
		private bool stdDevSubtotalField;

		// Token: 0x040021E8 RID: 8680
		private bool stdDevPSubtotalField;

		// Token: 0x040021E9 RID: 8681
		private bool varSubtotalField;

		// Token: 0x040021EA RID: 8682
		private bool varPSubtotalField;

		// Token: 0x040021EB RID: 8683
		private bool showPropCellField;

		// Token: 0x040021EC RID: 8684
		private bool showPropTipField;

		// Token: 0x040021ED RID: 8685
		private bool showPropAsCaptionField;

		// Token: 0x040021EE RID: 8686
		private bool defaultAttributeDrillStateField;
	}
}
