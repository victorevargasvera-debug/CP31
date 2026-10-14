using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004B9 RID: 1209
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("pivotTableDefinition", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public class CT_PivotTableDefinition
	{
		// Token: 0x06003172 RID: 12658 RVA: 0x0007BF54 File Offset: 0x0007A154
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableDefinition Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableDefinition ct_PivotTableDefinition = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableDefinition();
			ct_PivotTableDefinition.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			if (node.Attributes["cacheId"] != null)
			{
				ct_PivotTableDefinition.cacheId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["cacheId"]);
			}
			if (node.Attributes["dataOnRows"] != null)
			{
				ct_PivotTableDefinition.dataOnRows = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dataOnRows"]);
			}
			if (node.Attributes["dataPosition"] != null)
			{
				ct_PivotTableDefinition.dataPosition = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dataPosition"]);
			}
			if (node.Attributes["autoFormatId"] != null)
			{
				ct_PivotTableDefinition.autoFormatId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["autoFormatId"]);
			}
			if (node.Attributes["applyNumberFormats"] != null)
			{
				ct_PivotTableDefinition.applyNumberFormats = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyNumberFormats"]);
			}
			if (node.Attributes["applyBorderFormats"] != null)
			{
				ct_PivotTableDefinition.applyBorderFormats = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyBorderFormats"]);
			}
			if (node.Attributes["applyFontFormats"] != null)
			{
				ct_PivotTableDefinition.applyFontFormats = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyFontFormats"]);
			}
			if (node.Attributes["applyPatternFormats"] != null)
			{
				ct_PivotTableDefinition.applyPatternFormats = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyPatternFormats"]);
			}
			if (node.Attributes["applyAlignmentFormats"] != null)
			{
				ct_PivotTableDefinition.applyAlignmentFormats = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyAlignmentFormats"]);
			}
			if (node.Attributes["applyWidthHeightFormats"] != null)
			{
				ct_PivotTableDefinition.applyWidthHeightFormats = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyWidthHeightFormats"]);
			}
			ct_PivotTableDefinition.dataCaption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["dataCaption"]);
			ct_PivotTableDefinition.grandTotalCaption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["grandTotalCaption"]);
			ct_PivotTableDefinition.errorCaption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["errorCaption"]);
			if (node.Attributes["showError"] != null)
			{
				ct_PivotTableDefinition.showError = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showError"]);
			}
			ct_PivotTableDefinition.missingCaption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["missingCaption"]);
			if (node.Attributes["showMissing"] != null)
			{
				ct_PivotTableDefinition.showMissing = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showMissing"]);
			}
			ct_PivotTableDefinition.pageStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["pageStyle"]);
			ct_PivotTableDefinition.pivotTableStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["pivotTableStyle"]);
			ct_PivotTableDefinition.vacatedStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["vacatedStyle"]);
			ct_PivotTableDefinition.tag = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["tag"]);
			if (node.Attributes["updatedVersion"] != null)
			{
				ct_PivotTableDefinition.updatedVersion = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["updatedVersion"]);
			}
			if (node.Attributes["minRefreshableVersion"] != null)
			{
				ct_PivotTableDefinition.minRefreshableVersion = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["minRefreshableVersion"]);
			}
			if (node.Attributes["asteriskTotals"] != null)
			{
				ct_PivotTableDefinition.asteriskTotals = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["asteriskTotals"]);
			}
			if (node.Attributes["showItems"] != null)
			{
				ct_PivotTableDefinition.showItems = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showItems"]);
			}
			if (node.Attributes["editData"] != null)
			{
				ct_PivotTableDefinition.editData = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["editData"]);
			}
			if (node.Attributes["disableFieldList"] != null)
			{
				ct_PivotTableDefinition.disableFieldList = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["disableFieldList"]);
			}
			if (node.Attributes["showCalcMbrs"] != null)
			{
				ct_PivotTableDefinition.showCalcMbrs = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showCalcMbrs"]);
			}
			if (node.Attributes["visualTotals"] != null)
			{
				ct_PivotTableDefinition.visualTotals = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["visualTotals"]);
			}
			if (node.Attributes["showMultipleLabel"] != null)
			{
				ct_PivotTableDefinition.showMultipleLabel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showMultipleLabel"]);
			}
			if (node.Attributes["showDataDropDown"] != null)
			{
				ct_PivotTableDefinition.showDataDropDown = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showDataDropDown"]);
			}
			if (node.Attributes["showDrill"] != null)
			{
				ct_PivotTableDefinition.showDrill = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showDrill"]);
			}
			if (node.Attributes["printDrill"] != null)
			{
				ct_PivotTableDefinition.printDrill = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["printDrill"]);
			}
			if (node.Attributes["showMemberPropertyTips"] != null)
			{
				ct_PivotTableDefinition.showMemberPropertyTips = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showMemberPropertyTips"]);
			}
			if (node.Attributes["showDataTips"] != null)
			{
				ct_PivotTableDefinition.showDataTips = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showDataTips"]);
			}
			if (node.Attributes["enableWizard"] != null)
			{
				ct_PivotTableDefinition.enableWizard = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["enableWizard"]);
			}
			if (node.Attributes["enableDrill"] != null)
			{
				ct_PivotTableDefinition.enableDrill = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["enableDrill"]);
			}
			if (node.Attributes["enableFieldProperties"] != null)
			{
				ct_PivotTableDefinition.enableFieldProperties = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["enableFieldProperties"]);
			}
			if (node.Attributes["preserveFormatting"] != null)
			{
				ct_PivotTableDefinition.preserveFormatting = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["preserveFormatting"]);
			}
			if (node.Attributes["useAutoFormatting"] != null)
			{
				ct_PivotTableDefinition.useAutoFormatting = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["useAutoFormatting"]);
			}
			if (node.Attributes["pageWrap"] != null)
			{
				ct_PivotTableDefinition.pageWrap = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["pageWrap"]);
			}
			if (node.Attributes["pageOverThenDown"] != null)
			{
				ct_PivotTableDefinition.pageOverThenDown = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["pageOverThenDown"]);
			}
			if (node.Attributes["subtotalHiddenItems"] != null)
			{
				ct_PivotTableDefinition.subtotalHiddenItems = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["subtotalHiddenItems"]);
			}
			if (node.Attributes["rowGrandTotals"] != null)
			{
				ct_PivotTableDefinition.rowGrandTotals = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["rowGrandTotals"]);
			}
			if (node.Attributes["colGrandTotals"] != null)
			{
				ct_PivotTableDefinition.colGrandTotals = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["colGrandTotals"]);
			}
			if (node.Attributes["fieldPrintTitles"] != null)
			{
				ct_PivotTableDefinition.fieldPrintTitles = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fieldPrintTitles"]);
			}
			if (node.Attributes["itemPrintTitles"] != null)
			{
				ct_PivotTableDefinition.itemPrintTitles = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["itemPrintTitles"]);
			}
			if (node.Attributes["mergeItem"] != null)
			{
				ct_PivotTableDefinition.mergeItem = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["mergeItem"]);
			}
			if (node.Attributes["showDropZones"] != null)
			{
				ct_PivotTableDefinition.showDropZones = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showDropZones"]);
			}
			if (node.Attributes["createdVersion"] != null)
			{
				ct_PivotTableDefinition.createdVersion = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["createdVersion"]);
			}
			if (node.Attributes["indent"] != null)
			{
				ct_PivotTableDefinition.indent = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["indent"]);
			}
			if (node.Attributes["showEmptyRow"] != null)
			{
				ct_PivotTableDefinition.showEmptyRow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showEmptyRow"]);
			}
			if (node.Attributes["showEmptyCol"] != null)
			{
				ct_PivotTableDefinition.showEmptyCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showEmptyCol"]);
			}
			if (node.Attributes["showHeaders"] != null)
			{
				ct_PivotTableDefinition.showHeaders = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showHeaders"]);
			}
			if (node.Attributes["compact"] != null)
			{
				ct_PivotTableDefinition.compact = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["compact"]);
			}
			if (node.Attributes["outline"] != null)
			{
				ct_PivotTableDefinition.outline = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["outline"]);
			}
			if (node.Attributes["outlineData"] != null)
			{
				ct_PivotTableDefinition.outlineData = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["outlineData"]);
			}
			if (node.Attributes["compactData"] != null)
			{
				ct_PivotTableDefinition.compactData = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["compactData"]);
			}
			if (node.Attributes["published"] != null)
			{
				ct_PivotTableDefinition.published = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["published"]);
			}
			if (node.Attributes["gridDropZones"] != null)
			{
				ct_PivotTableDefinition.gridDropZones = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["gridDropZones"]);
			}
			if (node.Attributes["immersive"] != null)
			{
				ct_PivotTableDefinition.immersive = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["immersive"]);
			}
			if (node.Attributes["multipleFieldFilters"] != null)
			{
				ct_PivotTableDefinition.multipleFieldFilters = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["multipleFieldFilters"]);
			}
			if (node.Attributes["chartFormat"] != null)
			{
				ct_PivotTableDefinition.chartFormat = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["chartFormat"]);
			}
			ct_PivotTableDefinition.rowHeaderCaption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["rowHeaderCaption"]);
			ct_PivotTableDefinition.colHeaderCaption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["colHeaderCaption"]);
			if (node.Attributes["fieldListSortAscending"] != null)
			{
				ct_PivotTableDefinition.fieldListSortAscending = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fieldListSortAscending"]);
			}
			if (node.Attributes["mdxSubqueries"] != null)
			{
				ct_PivotTableDefinition.mdxSubqueries = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["mdxSubqueries"]);
			}
			if (node.Attributes["customListSort"] != null)
			{
				ct_PivotTableDefinition.customListSort = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["customListSort"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "location")
				{
					ct_PivotTableDefinition.location = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Location.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pivotFields")
				{
					ct_PivotTableDefinition.pivotFields = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFields.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rowFields")
				{
					ct_PivotTableDefinition.rowFields = global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowFields.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rowItems")
				{
					ct_PivotTableDefinition.rowItems = global::NPOI.OpenXmlFormats.Spreadsheet.CT_rowItems.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "colFields")
				{
					ct_PivotTableDefinition.colFields = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColFields.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "colItems")
				{
					ct_PivotTableDefinition.colItems = global::NPOI.OpenXmlFormats.Spreadsheet.CT_colItems.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageFields")
				{
					ct_PivotTableDefinition.pageFields = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageFields.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dataFields")
				{
					ct_PivotTableDefinition.dataFields = global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataFields.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "formats")
				{
					ct_PivotTableDefinition.formats = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Formats.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "conditionalFormats")
				{
					ct_PivotTableDefinition.conditionalFormats = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormats.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "chartFormats")
				{
					ct_PivotTableDefinition.chartFormats = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormats.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pivotHierarchies")
				{
					ct_PivotTableDefinition.pivotHierarchies = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchies.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pivotTableStyleInfo")
				{
					ct_PivotTableDefinition.pivotTableStyleInfo = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableStyle.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "filters")
				{
					ct_PivotTableDefinition.filters = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilters.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rowHierarchiesUsage")
				{
					ct_PivotTableDefinition.rowHierarchiesUsage = global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowHierarchiesUsage.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "colHierarchiesUsage")
				{
					ct_PivotTableDefinition.colHierarchiesUsage = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColHierarchiesUsage.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_PivotTableDefinition.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PivotTableDefinition;
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x0007CD48 File Offset: 0x0007AF48
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<pivotTableDefinition xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" ");
			sw.Write("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" ");
			sw.Write("xmlns:s=\"http://schemas.openxmlformats.org/officeDocument/2006/sharedTypes\" ");
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cacheId", this.cacheId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dataOnRows", this.dataOnRows);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dataPosition", this.dataPosition, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoFormatId", this.autoFormatId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyNumberFormats", this.applyNumberFormats);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyBorderFormats", this.applyBorderFormats);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyFontFormats", this.applyFontFormats);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyPatternFormats", this.applyPatternFormats);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyAlignmentFormats", this.applyAlignmentFormats);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyWidthHeightFormats", this.applyWidthHeightFormats);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dataCaption", this.dataCaption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "grandTotalCaption", this.grandTotalCaption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "errorCaption", this.errorCaption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showError", this.showError);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "missingCaption", this.missingCaption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showMissing", this.showMissing);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pageStyle", this.pageStyle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pivotTableStyle", this.pivotTableStyle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "vacatedStyle", this.vacatedStyle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tag", this.tag);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "updatedVersion", (int)this.updatedVersion);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "minRefreshableVersion", (int)this.minRefreshableVersion);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "asteriskTotals", this.asteriskTotals);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showItems", this.showItems);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "editData", this.editData);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "disableFieldList", this.disableFieldList);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showCalcMbrs", this.showCalcMbrs);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "visualTotals", this.visualTotals);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showMultipleLabel", this.showMultipleLabel);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showDataDropDown", this.showDataDropDown);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showDrill", this.showDrill);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "printDrill", this.printDrill);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showMemberPropertyTips", this.showMemberPropertyTips);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showDataTips", this.showDataTips);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "enableWizard", this.enableWizard);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "enableDrill", this.enableDrill);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "enableFieldProperties", this.enableFieldProperties);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "preserveFormatting", this.preserveFormatting);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "useAutoFormatting", this.useAutoFormatting);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pageWrap", this.pageWrap, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pageOverThenDown", this.pageOverThenDown);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "subtotalHiddenItems", this.subtotalHiddenItems);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rowGrandTotals", this.rowGrandTotals);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "colGrandTotals", this.colGrandTotals);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fieldPrintTitles", this.fieldPrintTitles);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "itemPrintTitles", this.itemPrintTitles);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "mergeItem", this.mergeItem);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showDropZones", this.showDropZones);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "createdVersion", (int)this.createdVersion);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "indent", this.indent, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showEmptyRow", this.showEmptyRow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showEmptyCol", this.showEmptyCol);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showHeaders", this.showHeaders);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "compact", this.compact);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "outline", this.outline);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "outlineData", this.outlineData);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "compactData", this.compactData);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "published", this.published);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "gridDropZones", this.gridDropZones);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "immersive", this.immersive);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "multipleFieldFilters", this.multipleFieldFilters);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "chartFormat", this.chartFormat, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rowHeaderCaption", this.rowHeaderCaption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "colHeaderCaption", this.colHeaderCaption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fieldListSortAscending", this.fieldListSortAscending);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "mdxSubqueries", this.mdxSubqueries);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "customListSort", this.customListSort);
			sw.Write(">");
			if (this.location != null)
			{
				this.location.Write(sw, "location");
			}
			if (this.pivotFields != null)
			{
				this.pivotFields.Write(sw, "pivotFields");
			}
			if (this.rowFields != null)
			{
				this.rowFields.Write(sw, "rowFields");
			}
			if (this.rowItems != null)
			{
				this.rowItems.Write(sw, "rowItems");
			}
			if (this.colFields != null)
			{
				this.colFields.Write(sw, "colFields");
			}
			if (this.colItems != null)
			{
				this.colItems.Write(sw, "colItems");
			}
			if (this.pageFields != null)
			{
				this.pageFields.Write(sw, "pageFields");
			}
			if (this.dataFields != null)
			{
				this.dataFields.Write(sw, "dataFields");
			}
			if (this.formats != null)
			{
				this.formats.Write(sw, "formats");
			}
			if (this.conditionalFormats != null)
			{
				this.conditionalFormats.Write(sw, "conditionalFormats");
			}
			if (this.chartFormats != null)
			{
				this.chartFormats.Write(sw, "chartFormats");
			}
			if (this.pivotHierarchies != null)
			{
				this.pivotHierarchies.Write(sw, "pivotHierarchies");
			}
			if (this.pivotTableStyleInfo != null)
			{
				this.pivotTableStyleInfo.Write(sw, "pivotTableStyleInfo");
			}
			if (this.filters != null)
			{
				this.filters.Write(sw, "filters");
			}
			if (this.rowHierarchiesUsage != null)
			{
				this.rowHierarchiesUsage.Write(sw, "rowHierarchiesUsage");
			}
			if (this.colHierarchiesUsage != null)
			{
				this.colHierarchiesUsage.Write(sw, "colHierarchiesUsage");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</pivotTableDefinition>", new object[0]));
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x0007D3D8 File Offset: 0x0007B5D8
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.Write(streamWriter);
			}
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x0007D410 File Offset: 0x0007B610
		public CT_PivotTableDefinition()
		{
			this.dataOnRowsField = false;
			this.showErrorField = false;
			this.showMissingField = true;
			this.updatedVersionField = 0;
			this.minRefreshableVersionField = 0;
			this.asteriskTotalsField = false;
			this.showItemsField = true;
			this.editDataField = false;
			this.disableFieldListField = false;
			this.showCalcMbrsField = true;
			this.visualTotalsField = true;
			this.showMultipleLabelField = true;
			this.showDataDropDownField = true;
			this.showDrillField = true;
			this.printDrillField = false;
			this.showMemberPropertyTipsField = true;
			this.showDataTipsField = true;
			this.enableWizardField = true;
			this.enableDrillField = true;
			this.enableFieldPropertiesField = true;
			this.preserveFormattingField = true;
			this.useAutoFormattingField = false;
			this.pageWrapField = 0U;
			this.pageOverThenDownField = false;
			this.subtotalHiddenItemsField = false;
			this.rowGrandTotalsField = true;
			this.colGrandTotalsField = true;
			this.fieldPrintTitlesField = false;
			this.itemPrintTitlesField = false;
			this.mergeItemField = false;
			this.showDropZonesField = true;
			this.createdVersionField = 0;
			this.indentField = 1U;
			this.showEmptyRowField = false;
			this.showEmptyColField = false;
			this.showHeadersField = true;
			this.compactField = true;
			this.outlineField = false;
			this.outlineDataField = false;
			this.compactDataField = true;
			this.publishedField = false;
			this.gridDropZonesField = false;
			this.immersiveField = true;
			this.multipleFieldFiltersField = true;
			this.chartFormatField = 0U;
			this.fieldListSortAscendingField = false;
			this.mdxSubqueriesField = false;
			this.customListSortField = true;
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x0007D573 File Offset: 0x0007B773
		// (set) Token: 0x06003177 RID: 12663 RVA: 0x0007D57B File Offset: 0x0007B77B
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Location location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x0007D584 File Offset: 0x0007B784
		// (set) Token: 0x06003179 RID: 12665 RVA: 0x0007D58C File Offset: 0x0007B78C
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFields pivotFields
		{
			get
			{
				return this.pivotFieldsField;
			}
			set
			{
				this.pivotFieldsField = value;
			}
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x0600317A RID: 12666 RVA: 0x0007D595 File Offset: 0x0007B795
		// (set) Token: 0x0600317B RID: 12667 RVA: 0x0007D59D File Offset: 0x0007B79D
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowFields rowFields
		{
			get
			{
				return this.rowFieldsField;
			}
			set
			{
				this.rowFieldsField = value;
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x0007D5A6 File Offset: 0x0007B7A6
		// (set) Token: 0x0600317D RID: 12669 RVA: 0x0007D5AE File Offset: 0x0007B7AE
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_rowItems rowItems
		{
			get
			{
				return this.rowItemsField;
			}
			set
			{
				this.rowItemsField = value;
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x0007D5B7 File Offset: 0x0007B7B7
		// (set) Token: 0x0600317F RID: 12671 RVA: 0x0007D5BF File Offset: 0x0007B7BF
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColFields colFields
		{
			get
			{
				return this.colFieldsField;
			}
			set
			{
				this.colFieldsField = value;
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06003180 RID: 12672 RVA: 0x0007D5C8 File Offset: 0x0007B7C8
		// (set) Token: 0x06003181 RID: 12673 RVA: 0x0007D5D0 File Offset: 0x0007B7D0
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_colItems colItems
		{
			get
			{
				return this.colItemsField;
			}
			set
			{
				this.colItemsField = value;
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x0007D5D9 File Offset: 0x0007B7D9
		// (set) Token: 0x06003183 RID: 12675 RVA: 0x0007D5E1 File Offset: 0x0007B7E1
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageFields pageFields
		{
			get
			{
				return this.pageFieldsField;
			}
			set
			{
				this.pageFieldsField = value;
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x0007D5EA File Offset: 0x0007B7EA
		// (set) Token: 0x06003185 RID: 12677 RVA: 0x0007D5F2 File Offset: 0x0007B7F2
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataFields dataFields
		{
			get
			{
				return this.dataFieldsField;
			}
			set
			{
				this.dataFieldsField = value;
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x0007D5FB File Offset: 0x0007B7FB
		// (set) Token: 0x06003187 RID: 12679 RVA: 0x0007D603 File Offset: 0x0007B803
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Formats formats
		{
			get
			{
				return this.formatsField;
			}
			set
			{
				this.formatsField = value;
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x0007D60C File Offset: 0x0007B80C
		// (set) Token: 0x06003189 RID: 12681 RVA: 0x0007D614 File Offset: 0x0007B814
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormats conditionalFormats
		{
			get
			{
				return this.conditionalFormatsField;
			}
			set
			{
				this.conditionalFormatsField = value;
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x0007D61D File Offset: 0x0007B81D
		// (set) Token: 0x0600318B RID: 12683 RVA: 0x0007D625 File Offset: 0x0007B825
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormats chartFormats
		{
			get
			{
				return this.chartFormatsField;
			}
			set
			{
				this.chartFormatsField = value;
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x0007D62E File Offset: 0x0007B82E
		// (set) Token: 0x0600318D RID: 12685 RVA: 0x0007D636 File Offset: 0x0007B836
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchies pivotHierarchies
		{
			get
			{
				return this.pivotHierarchiesField;
			}
			set
			{
				this.pivotHierarchiesField = value;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x0007D63F File Offset: 0x0007B83F
		// (set) Token: 0x0600318F RID: 12687 RVA: 0x0007D647 File Offset: 0x0007B847
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableStyle pivotTableStyleInfo
		{
			get
			{
				return this.pivotTableStyleInfoField;
			}
			set
			{
				this.pivotTableStyleInfoField = value;
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x0007D650 File Offset: 0x0007B850
		// (set) Token: 0x06003191 RID: 12689 RVA: 0x0007D658 File Offset: 0x0007B858
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilters filters
		{
			get
			{
				return this.filtersField;
			}
			set
			{
				this.filtersField = value;
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x0007D661 File Offset: 0x0007B861
		// (set) Token: 0x06003193 RID: 12691 RVA: 0x0007D669 File Offset: 0x0007B869
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowHierarchiesUsage rowHierarchiesUsage
		{
			get
			{
				return this.rowHierarchiesUsageField;
			}
			set
			{
				this.rowHierarchiesUsageField = value;
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x0007D672 File Offset: 0x0007B872
		// (set) Token: 0x06003195 RID: 12693 RVA: 0x0007D67A File Offset: 0x0007B87A
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColHierarchiesUsage colHierarchiesUsage
		{
			get
			{
				return this.colHierarchiesUsageField;
			}
			set
			{
				this.colHierarchiesUsageField = value;
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x0007D683 File Offset: 0x0007B883
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x0007D68B File Offset: 0x0007B88B
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
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

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x0007D694 File Offset: 0x0007B894
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x0007D69C File Offset: 0x0007B89C
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

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x0007D6A5 File Offset: 0x0007B8A5
		// (set) Token: 0x0600319B RID: 12699 RVA: 0x0007D6AD File Offset: 0x0007B8AD
		[global::System.Xml.Serialization.XmlAttribute]
		public uint cacheId
		{
			get
			{
				return this.cacheIdField;
			}
			set
			{
				this.cacheIdField = value;
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x0600319C RID: 12700 RVA: 0x0007D6B6 File Offset: 0x0007B8B6
		// (set) Token: 0x0600319D RID: 12701 RVA: 0x0007D6BE File Offset: 0x0007B8BE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool dataOnRows
		{
			get
			{
				return this.dataOnRowsField;
			}
			set
			{
				this.dataOnRowsField = value;
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x0007D6C7 File Offset: 0x0007B8C7
		// (set) Token: 0x0600319F RID: 12703 RVA: 0x0007D6CF File Offset: 0x0007B8CF
		[global::System.Xml.Serialization.XmlAttribute]
		public uint dataPosition
		{
			get
			{
				return this.dataPositionField;
			}
			set
			{
				this.dataPositionField = value;
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x0007D6D8 File Offset: 0x0007B8D8
		// (set) Token: 0x060031A1 RID: 12705 RVA: 0x0007D6E0 File Offset: 0x0007B8E0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dataPositionSpecified
		{
			get
			{
				return this.dataPositionFieldSpecified;
			}
			set
			{
				this.dataPositionFieldSpecified = value;
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x060031A2 RID: 12706 RVA: 0x0007D6E9 File Offset: 0x0007B8E9
		// (set) Token: 0x060031A3 RID: 12707 RVA: 0x0007D6F1 File Offset: 0x0007B8F1
		[global::System.Xml.Serialization.XmlAttribute]
		public uint autoFormatId
		{
			get
			{
				return this.autoFormatIdField;
			}
			set
			{
				this.autoFormatIdField = value;
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x060031A4 RID: 12708 RVA: 0x0007D6FA File Offset: 0x0007B8FA
		// (set) Token: 0x060031A5 RID: 12709 RVA: 0x0007D702 File Offset: 0x0007B902
		[global::System.Xml.Serialization.XmlIgnore]
		public bool autoFormatIdSpecified
		{
			get
			{
				return this.autoFormatIdFieldSpecified;
			}
			set
			{
				this.autoFormatIdFieldSpecified = value;
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x060031A6 RID: 12710 RVA: 0x0007D70B File Offset: 0x0007B90B
		// (set) Token: 0x060031A7 RID: 12711 RVA: 0x0007D713 File Offset: 0x0007B913
		[global::System.Xml.Serialization.XmlAttribute]
		public bool applyNumberFormats
		{
			get
			{
				return this.applyNumberFormatsField;
			}
			set
			{
				this.applyNumberFormatsField = value;
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x0007D71C File Offset: 0x0007B91C
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x0007D724 File Offset: 0x0007B924
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyNumberFormatsSpecified
		{
			get
			{
				return this.applyNumberFormatsFieldSpecified;
			}
			set
			{
				this.applyNumberFormatsFieldSpecified = value;
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x0007D72D File Offset: 0x0007B92D
		// (set) Token: 0x060031AB RID: 12715 RVA: 0x0007D735 File Offset: 0x0007B935
		[global::System.Xml.Serialization.XmlAttribute]
		public bool applyBorderFormats
		{
			get
			{
				return this.applyBorderFormatsField;
			}
			set
			{
				this.applyBorderFormatsField = value;
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x0007D73E File Offset: 0x0007B93E
		// (set) Token: 0x060031AD RID: 12717 RVA: 0x0007D746 File Offset: 0x0007B946
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyBorderFormatsSpecified
		{
			get
			{
				return this.applyBorderFormatsFieldSpecified;
			}
			set
			{
				this.applyBorderFormatsFieldSpecified = value;
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x0007D74F File Offset: 0x0007B94F
		// (set) Token: 0x060031AF RID: 12719 RVA: 0x0007D757 File Offset: 0x0007B957
		[global::System.Xml.Serialization.XmlAttribute]
		public bool applyFontFormats
		{
			get
			{
				return this.applyFontFormatsField;
			}
			set
			{
				this.applyFontFormatsField = value;
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x060031B0 RID: 12720 RVA: 0x0007D760 File Offset: 0x0007B960
		// (set) Token: 0x060031B1 RID: 12721 RVA: 0x0007D768 File Offset: 0x0007B968
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyFontFormatsSpecified
		{
			get
			{
				return this.applyFontFormatsFieldSpecified;
			}
			set
			{
				this.applyFontFormatsFieldSpecified = value;
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x060031B2 RID: 12722 RVA: 0x0007D771 File Offset: 0x0007B971
		// (set) Token: 0x060031B3 RID: 12723 RVA: 0x0007D779 File Offset: 0x0007B979
		[global::System.Xml.Serialization.XmlAttribute]
		public bool applyPatternFormats
		{
			get
			{
				return this.applyPatternFormatsField;
			}
			set
			{
				this.applyPatternFormatsField = value;
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x0007D782 File Offset: 0x0007B982
		// (set) Token: 0x060031B5 RID: 12725 RVA: 0x0007D78A File Offset: 0x0007B98A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyPatternFormatsSpecified
		{
			get
			{
				return this.applyPatternFormatsFieldSpecified;
			}
			set
			{
				this.applyPatternFormatsFieldSpecified = value;
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x060031B6 RID: 12726 RVA: 0x0007D793 File Offset: 0x0007B993
		// (set) Token: 0x060031B7 RID: 12727 RVA: 0x0007D79B File Offset: 0x0007B99B
		[global::System.Xml.Serialization.XmlAttribute]
		public bool applyAlignmentFormats
		{
			get
			{
				return this.applyAlignmentFormatsField;
			}
			set
			{
				this.applyAlignmentFormatsField = value;
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x060031B8 RID: 12728 RVA: 0x0007D7A4 File Offset: 0x0007B9A4
		// (set) Token: 0x060031B9 RID: 12729 RVA: 0x0007D7AC File Offset: 0x0007B9AC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyAlignmentFormatsSpecified
		{
			get
			{
				return this.applyAlignmentFormatsFieldSpecified;
			}
			set
			{
				this.applyAlignmentFormatsFieldSpecified = value;
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x060031BA RID: 12730 RVA: 0x0007D7B5 File Offset: 0x0007B9B5
		// (set) Token: 0x060031BB RID: 12731 RVA: 0x0007D7BD File Offset: 0x0007B9BD
		[global::System.Xml.Serialization.XmlAttribute]
		public bool applyWidthHeightFormats
		{
			get
			{
				return this.applyWidthHeightFormatsField;
			}
			set
			{
				this.applyWidthHeightFormatsField = value;
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x0007D7C6 File Offset: 0x0007B9C6
		// (set) Token: 0x060031BD RID: 12733 RVA: 0x0007D7CE File Offset: 0x0007B9CE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyWidthHeightFormatsSpecified
		{
			get
			{
				return this.applyWidthHeightFormatsFieldSpecified;
			}
			set
			{
				this.applyWidthHeightFormatsFieldSpecified = value;
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x060031BE RID: 12734 RVA: 0x0007D7D7 File Offset: 0x0007B9D7
		// (set) Token: 0x060031BF RID: 12735 RVA: 0x0007D7DF File Offset: 0x0007B9DF
		[global::System.Xml.Serialization.XmlAttribute]
		public string dataCaption
		{
			get
			{
				return this.dataCaptionField;
			}
			set
			{
				this.dataCaptionField = value;
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060031C0 RID: 12736 RVA: 0x0007D7E8 File Offset: 0x0007B9E8
		// (set) Token: 0x060031C1 RID: 12737 RVA: 0x0007D7F0 File Offset: 0x0007B9F0
		[global::System.Xml.Serialization.XmlAttribute]
		public string grandTotalCaption
		{
			get
			{
				return this.grandTotalCaptionField;
			}
			set
			{
				this.grandTotalCaptionField = value;
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060031C2 RID: 12738 RVA: 0x0007D7F9 File Offset: 0x0007B9F9
		// (set) Token: 0x060031C3 RID: 12739 RVA: 0x0007D801 File Offset: 0x0007BA01
		[global::System.Xml.Serialization.XmlAttribute]
		public string errorCaption
		{
			get
			{
				return this.errorCaptionField;
			}
			set
			{
				this.errorCaptionField = value;
			}
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x060031C4 RID: 12740 RVA: 0x0007D80A File Offset: 0x0007BA0A
		// (set) Token: 0x060031C5 RID: 12741 RVA: 0x0007D812 File Offset: 0x0007BA12
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showError
		{
			get
			{
				return this.showErrorField;
			}
			set
			{
				this.showErrorField = value;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x0007D81B File Offset: 0x0007BA1B
		// (set) Token: 0x060031C7 RID: 12743 RVA: 0x0007D823 File Offset: 0x0007BA23
		[global::System.Xml.Serialization.XmlAttribute]
		public string missingCaption
		{
			get
			{
				return this.missingCaptionField;
			}
			set
			{
				this.missingCaptionField = value;
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x060031C8 RID: 12744 RVA: 0x0007D82C File Offset: 0x0007BA2C
		// (set) Token: 0x060031C9 RID: 12745 RVA: 0x0007D834 File Offset: 0x0007BA34
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showMissing
		{
			get
			{
				return this.showMissingField;
			}
			set
			{
				this.showMissingField = value;
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x0007D83D File Offset: 0x0007BA3D
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x0007D845 File Offset: 0x0007BA45
		[global::System.Xml.Serialization.XmlAttribute]
		public string pageStyle
		{
			get
			{
				return this.pageStyleField;
			}
			set
			{
				this.pageStyleField = value;
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x0007D84E File Offset: 0x0007BA4E
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x0007D856 File Offset: 0x0007BA56
		[global::System.Xml.Serialization.XmlAttribute]
		public string pivotTableStyle
		{
			get
			{
				return this.pivotTableStyleField;
			}
			set
			{
				this.pivotTableStyleField = value;
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x0007D85F File Offset: 0x0007BA5F
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x0007D867 File Offset: 0x0007BA67
		[global::System.Xml.Serialization.XmlAttribute]
		public string vacatedStyle
		{
			get
			{
				return this.vacatedStyleField;
			}
			set
			{
				this.vacatedStyleField = value;
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x0007D870 File Offset: 0x0007BA70
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x0007D878 File Offset: 0x0007BA78
		[global::System.Xml.Serialization.XmlAttribute]
		public string tag
		{
			get
			{
				return this.tagField;
			}
			set
			{
				this.tagField = value;
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x0007D881 File Offset: 0x0007BA81
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x0007D889 File Offset: 0x0007BA89
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		public byte updatedVersion
		{
			get
			{
				return this.updatedVersionField;
			}
			set
			{
				this.updatedVersionField = value;
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x0007D892 File Offset: 0x0007BA92
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x0007D89A File Offset: 0x0007BA9A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		public byte minRefreshableVersion
		{
			get
			{
				return this.minRefreshableVersionField;
			}
			set
			{
				this.minRefreshableVersionField = value;
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x0007D8A3 File Offset: 0x0007BAA3
		// (set) Token: 0x060031D7 RID: 12759 RVA: 0x0007D8AB File Offset: 0x0007BAAB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool asteriskTotals
		{
			get
			{
				return this.asteriskTotalsField;
			}
			set
			{
				this.asteriskTotalsField = value;
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x0007D8B4 File Offset: 0x0007BAB4
		// (set) Token: 0x060031D9 RID: 12761 RVA: 0x0007D8BC File Offset: 0x0007BABC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showItems
		{
			get
			{
				return this.showItemsField;
			}
			set
			{
				this.showItemsField = value;
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060031DA RID: 12762 RVA: 0x0007D8C5 File Offset: 0x0007BAC5
		// (set) Token: 0x060031DB RID: 12763 RVA: 0x0007D8CD File Offset: 0x0007BACD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool editData
		{
			get
			{
				return this.editDataField;
			}
			set
			{
				this.editDataField = value;
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x060031DC RID: 12764 RVA: 0x0007D8D6 File Offset: 0x0007BAD6
		// (set) Token: 0x060031DD RID: 12765 RVA: 0x0007D8DE File Offset: 0x0007BADE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool disableFieldList
		{
			get
			{
				return this.disableFieldListField;
			}
			set
			{
				this.disableFieldListField = value;
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x060031DE RID: 12766 RVA: 0x0007D8E7 File Offset: 0x0007BAE7
		// (set) Token: 0x060031DF RID: 12767 RVA: 0x0007D8EF File Offset: 0x0007BAEF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showCalcMbrs
		{
			get
			{
				return this.showCalcMbrsField;
			}
			set
			{
				this.showCalcMbrsField = value;
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x0007D8F8 File Offset: 0x0007BAF8
		// (set) Token: 0x060031E1 RID: 12769 RVA: 0x0007D900 File Offset: 0x0007BB00
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool visualTotals
		{
			get
			{
				return this.visualTotalsField;
			}
			set
			{
				this.visualTotalsField = value;
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x060031E2 RID: 12770 RVA: 0x0007D909 File Offset: 0x0007BB09
		// (set) Token: 0x060031E3 RID: 12771 RVA: 0x0007D911 File Offset: 0x0007BB11
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showMultipleLabel
		{
			get
			{
				return this.showMultipleLabelField;
			}
			set
			{
				this.showMultipleLabelField = value;
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x0007D91A File Offset: 0x0007BB1A
		// (set) Token: 0x060031E5 RID: 12773 RVA: 0x0007D922 File Offset: 0x0007BB22
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showDataDropDown
		{
			get
			{
				return this.showDataDropDownField;
			}
			set
			{
				this.showDataDropDownField = value;
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x060031E6 RID: 12774 RVA: 0x0007D92B File Offset: 0x0007BB2B
		// (set) Token: 0x060031E7 RID: 12775 RVA: 0x0007D933 File Offset: 0x0007BB33
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showDrill
		{
			get
			{
				return this.showDrillField;
			}
			set
			{
				this.showDrillField = value;
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x060031E8 RID: 12776 RVA: 0x0007D93C File Offset: 0x0007BB3C
		// (set) Token: 0x060031E9 RID: 12777 RVA: 0x0007D944 File Offset: 0x0007BB44
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool printDrill
		{
			get
			{
				return this.printDrillField;
			}
			set
			{
				this.printDrillField = value;
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x0007D94D File Offset: 0x0007BB4D
		// (set) Token: 0x060031EB RID: 12779 RVA: 0x0007D955 File Offset: 0x0007BB55
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showMemberPropertyTips
		{
			get
			{
				return this.showMemberPropertyTipsField;
			}
			set
			{
				this.showMemberPropertyTipsField = value;
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x0007D95E File Offset: 0x0007BB5E
		// (set) Token: 0x060031ED RID: 12781 RVA: 0x0007D966 File Offset: 0x0007BB66
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showDataTips
		{
			get
			{
				return this.showDataTipsField;
			}
			set
			{
				this.showDataTipsField = value;
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x060031EE RID: 12782 RVA: 0x0007D96F File Offset: 0x0007BB6F
		// (set) Token: 0x060031EF RID: 12783 RVA: 0x0007D977 File Offset: 0x0007BB77
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool enableWizard
		{
			get
			{
				return this.enableWizardField;
			}
			set
			{
				this.enableWizardField = value;
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x0007D980 File Offset: 0x0007BB80
		// (set) Token: 0x060031F1 RID: 12785 RVA: 0x0007D988 File Offset: 0x0007BB88
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool enableDrill
		{
			get
			{
				return this.enableDrillField;
			}
			set
			{
				this.enableDrillField = value;
			}
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x0007D991 File Offset: 0x0007BB91
		// (set) Token: 0x060031F3 RID: 12787 RVA: 0x0007D999 File Offset: 0x0007BB99
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool enableFieldProperties
		{
			get
			{
				return this.enableFieldPropertiesField;
			}
			set
			{
				this.enableFieldPropertiesField = value;
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x0007D9A2 File Offset: 0x0007BBA2
		// (set) Token: 0x060031F5 RID: 12789 RVA: 0x0007D9AA File Offset: 0x0007BBAA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool preserveFormatting
		{
			get
			{
				return this.preserveFormattingField;
			}
			set
			{
				this.preserveFormattingField = value;
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x060031F6 RID: 12790 RVA: 0x0007D9B3 File Offset: 0x0007BBB3
		// (set) Token: 0x060031F7 RID: 12791 RVA: 0x0007D9BB File Offset: 0x0007BBBB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool useAutoFormatting
		{
			get
			{
				return this.useAutoFormattingField;
			}
			set
			{
				this.useAutoFormattingField = value;
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x060031F8 RID: 12792 RVA: 0x0007D9C4 File Offset: 0x0007BBC4
		// (set) Token: 0x060031F9 RID: 12793 RVA: 0x0007D9CC File Offset: 0x0007BBCC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint pageWrap
		{
			get
			{
				return this.pageWrapField;
			}
			set
			{
				this.pageWrapField = value;
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x060031FA RID: 12794 RVA: 0x0007D9D5 File Offset: 0x0007BBD5
		// (set) Token: 0x060031FB RID: 12795 RVA: 0x0007D9DD File Offset: 0x0007BBDD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pageOverThenDown
		{
			get
			{
				return this.pageOverThenDownField;
			}
			set
			{
				this.pageOverThenDownField = value;
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x0007D9E6 File Offset: 0x0007BBE6
		// (set) Token: 0x060031FD RID: 12797 RVA: 0x0007D9EE File Offset: 0x0007BBEE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool subtotalHiddenItems
		{
			get
			{
				return this.subtotalHiddenItemsField;
			}
			set
			{
				this.subtotalHiddenItemsField = value;
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x0007D9F7 File Offset: 0x0007BBF7
		// (set) Token: 0x060031FF RID: 12799 RVA: 0x0007D9FF File Offset: 0x0007BBFF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool rowGrandTotals
		{
			get
			{
				return this.rowGrandTotalsField;
			}
			set
			{
				this.rowGrandTotalsField = value;
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x0007DA08 File Offset: 0x0007BC08
		// (set) Token: 0x06003201 RID: 12801 RVA: 0x0007DA10 File Offset: 0x0007BC10
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool colGrandTotals
		{
			get
			{
				return this.colGrandTotalsField;
			}
			set
			{
				this.colGrandTotalsField = value;
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06003202 RID: 12802 RVA: 0x0007DA19 File Offset: 0x0007BC19
		// (set) Token: 0x06003203 RID: 12803 RVA: 0x0007DA21 File Offset: 0x0007BC21
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool fieldPrintTitles
		{
			get
			{
				return this.fieldPrintTitlesField;
			}
			set
			{
				this.fieldPrintTitlesField = value;
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06003204 RID: 12804 RVA: 0x0007DA2A File Offset: 0x0007BC2A
		// (set) Token: 0x06003205 RID: 12805 RVA: 0x0007DA32 File Offset: 0x0007BC32
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool itemPrintTitles
		{
			get
			{
				return this.itemPrintTitlesField;
			}
			set
			{
				this.itemPrintTitlesField = value;
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06003206 RID: 12806 RVA: 0x0007DA3B File Offset: 0x0007BC3B
		// (set) Token: 0x06003207 RID: 12807 RVA: 0x0007DA43 File Offset: 0x0007BC43
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool mergeItem
		{
			get
			{
				return this.mergeItemField;
			}
			set
			{
				this.mergeItemField = value;
			}
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06003208 RID: 12808 RVA: 0x0007DA4C File Offset: 0x0007BC4C
		// (set) Token: 0x06003209 RID: 12809 RVA: 0x0007DA54 File Offset: 0x0007BC54
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showDropZones
		{
			get
			{
				return this.showDropZonesField;
			}
			set
			{
				this.showDropZonesField = value;
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x0007DA5D File Offset: 0x0007BC5D
		// (set) Token: 0x0600320B RID: 12811 RVA: 0x0007DA65 File Offset: 0x0007BC65
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		public byte createdVersion
		{
			get
			{
				return this.createdVersionField;
			}
			set
			{
				this.createdVersionField = value;
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x0007DA6E File Offset: 0x0007BC6E
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x0007DA76 File Offset: 0x0007BC76
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint indent
		{
			get
			{
				return this.indentField;
			}
			set
			{
				this.indentField = value;
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x0007DA7F File Offset: 0x0007BC7F
		// (set) Token: 0x0600320F RID: 12815 RVA: 0x0007DA87 File Offset: 0x0007BC87
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showEmptyRow
		{
			get
			{
				return this.showEmptyRowField;
			}
			set
			{
				this.showEmptyRowField = value;
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x0007DA90 File Offset: 0x0007BC90
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x0007DA98 File Offset: 0x0007BC98
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showEmptyCol
		{
			get
			{
				return this.showEmptyColField;
			}
			set
			{
				this.showEmptyColField = value;
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06003212 RID: 12818 RVA: 0x0007DAA1 File Offset: 0x0007BCA1
		// (set) Token: 0x06003213 RID: 12819 RVA: 0x0007DAA9 File Offset: 0x0007BCA9
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showHeaders
		{
			get
			{
				return this.showHeadersField;
			}
			set
			{
				this.showHeadersField = value;
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x0007DAB2 File Offset: 0x0007BCB2
		// (set) Token: 0x06003215 RID: 12821 RVA: 0x0007DABA File Offset: 0x0007BCBA
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

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06003216 RID: 12822 RVA: 0x0007DAC3 File Offset: 0x0007BCC3
		// (set) Token: 0x06003217 RID: 12823 RVA: 0x0007DACB File Offset: 0x0007BCCB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
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

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06003218 RID: 12824 RVA: 0x0007DAD4 File Offset: 0x0007BCD4
		// (set) Token: 0x06003219 RID: 12825 RVA: 0x0007DADC File Offset: 0x0007BCDC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool outlineData
		{
			get
			{
				return this.outlineDataField;
			}
			set
			{
				this.outlineDataField = value;
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x0007DAE5 File Offset: 0x0007BCE5
		// (set) Token: 0x0600321B RID: 12827 RVA: 0x0007DAED File Offset: 0x0007BCED
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool compactData
		{
			get
			{
				return this.compactDataField;
			}
			set
			{
				this.compactDataField = value;
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x0600321C RID: 12828 RVA: 0x0007DAF6 File Offset: 0x0007BCF6
		// (set) Token: 0x0600321D RID: 12829 RVA: 0x0007DAFE File Offset: 0x0007BCFE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool published
		{
			get
			{
				return this.publishedField;
			}
			set
			{
				this.publishedField = value;
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x0600321E RID: 12830 RVA: 0x0007DB07 File Offset: 0x0007BD07
		// (set) Token: 0x0600321F RID: 12831 RVA: 0x0007DB0F File Offset: 0x0007BD0F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool gridDropZones
		{
			get
			{
				return this.gridDropZonesField;
			}
			set
			{
				this.gridDropZonesField = value;
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06003220 RID: 12832 RVA: 0x0007DB18 File Offset: 0x0007BD18
		// (set) Token: 0x06003221 RID: 12833 RVA: 0x0007DB20 File Offset: 0x0007BD20
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool immersive
		{
			get
			{
				return this.immersiveField;
			}
			set
			{
				this.immersiveField = value;
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06003222 RID: 12834 RVA: 0x0007DB29 File Offset: 0x0007BD29
		// (set) Token: 0x06003223 RID: 12835 RVA: 0x0007DB31 File Offset: 0x0007BD31
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool multipleFieldFilters
		{
			get
			{
				return this.multipleFieldFiltersField;
			}
			set
			{
				this.multipleFieldFiltersField = value;
			}
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06003224 RID: 12836 RVA: 0x0007DB3A File Offset: 0x0007BD3A
		// (set) Token: 0x06003225 RID: 12837 RVA: 0x0007DB42 File Offset: 0x0007BD42
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint chartFormat
		{
			get
			{
				return this.chartFormatField;
			}
			set
			{
				this.chartFormatField = value;
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x0007DB4B File Offset: 0x0007BD4B
		// (set) Token: 0x06003227 RID: 12839 RVA: 0x0007DB53 File Offset: 0x0007BD53
		[global::System.Xml.Serialization.XmlAttribute]
		public string rowHeaderCaption
		{
			get
			{
				return this.rowHeaderCaptionField;
			}
			set
			{
				this.rowHeaderCaptionField = value;
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x0007DB5C File Offset: 0x0007BD5C
		// (set) Token: 0x06003229 RID: 12841 RVA: 0x0007DB64 File Offset: 0x0007BD64
		[global::System.Xml.Serialization.XmlAttribute]
		public string colHeaderCaption
		{
			get
			{
				return this.colHeaderCaptionField;
			}
			set
			{
				this.colHeaderCaptionField = value;
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x0600322A RID: 12842 RVA: 0x0007DB6D File Offset: 0x0007BD6D
		// (set) Token: 0x0600322B RID: 12843 RVA: 0x0007DB75 File Offset: 0x0007BD75
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool fieldListSortAscending
		{
			get
			{
				return this.fieldListSortAscendingField;
			}
			set
			{
				this.fieldListSortAscendingField = value;
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x0600322C RID: 12844 RVA: 0x0007DB7E File Offset: 0x0007BD7E
		// (set) Token: 0x0600322D RID: 12845 RVA: 0x0007DB86 File Offset: 0x0007BD86
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool mdxSubqueries
		{
			get
			{
				return this.mdxSubqueriesField;
			}
			set
			{
				this.mdxSubqueriesField = value;
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x0600322E RID: 12846 RVA: 0x0007DB8F File Offset: 0x0007BD8F
		// (set) Token: 0x0600322F RID: 12847 RVA: 0x0007DB97 File Offset: 0x0007BD97
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool customListSort
		{
			get
			{
				return this.customListSortField;
			}
			set
			{
				this.customListSortField = value;
			}
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x0007DBA0 File Offset: 0x0007BDA0
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableStyle AddNewPivotTableStyleInfo()
		{
			this.pivotTableStyleInfoField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableStyle();
			return this.pivotTableStyleInfoField;
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x0007DBB3 File Offset: 0x0007BDB3
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowFields AddNewRowFields()
		{
			this.rowFieldsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowFields();
			return this.rowFieldsField;
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x0007DBC6 File Offset: 0x0007BDC6
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColFields AddNewColFields()
		{
			this.colFieldsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColFields();
			return this.colFieldsField;
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x0007DBD9 File Offset: 0x0007BDD9
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataFields AddNewDataFields()
		{
			this.dataFieldsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataFields();
			return this.dataFieldsField;
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x0007DBEC File Offset: 0x0007BDEC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageFields AddNewPageFields()
		{
			this.pageFieldsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageFields();
			return this.pageFieldsField;
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x0007DBFF File Offset: 0x0007BDFF
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFields AddNewPivotFields()
		{
			this.pivotFieldsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFields();
			return this.pivotFieldsField;
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x0007DC12 File Offset: 0x0007BE12
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Location AddNewLocation()
		{
			this.locationField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Location();
			return this.locationField;
		}

		// Token: 0x04002152 RID: 8530
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Location locationField;

		// Token: 0x04002153 RID: 8531
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFields pivotFieldsField;

		// Token: 0x04002154 RID: 8532
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowFields rowFieldsField;

		// Token: 0x04002155 RID: 8533
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_rowItems rowItemsField;

		// Token: 0x04002156 RID: 8534
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColFields colFieldsField;

		// Token: 0x04002157 RID: 8535
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_colItems colItemsField;

		// Token: 0x04002158 RID: 8536
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageFields pageFieldsField;

		// Token: 0x04002159 RID: 8537
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataFields dataFieldsField;

		// Token: 0x0400215A RID: 8538
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Formats formatsField;

		// Token: 0x0400215B RID: 8539
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormats conditionalFormatsField;

		// Token: 0x0400215C RID: 8540
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormats chartFormatsField;

		// Token: 0x0400215D RID: 8541
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchies pivotHierarchiesField;

		// Token: 0x0400215E RID: 8542
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableStyle pivotTableStyleInfoField;

		// Token: 0x0400215F RID: 8543
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilters filtersField;

		// Token: 0x04002160 RID: 8544
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowHierarchiesUsage rowHierarchiesUsageField;

		// Token: 0x04002161 RID: 8545
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColHierarchiesUsage colHierarchiesUsageField;

		// Token: 0x04002162 RID: 8546
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002163 RID: 8547
		private string nameField;

		// Token: 0x04002164 RID: 8548
		private uint cacheIdField;

		// Token: 0x04002165 RID: 8549
		private bool dataOnRowsField;

		// Token: 0x04002166 RID: 8550
		private uint dataPositionField;

		// Token: 0x04002167 RID: 8551
		private bool dataPositionFieldSpecified;

		// Token: 0x04002168 RID: 8552
		private uint autoFormatIdField;

		// Token: 0x04002169 RID: 8553
		private bool autoFormatIdFieldSpecified;

		// Token: 0x0400216A RID: 8554
		private bool applyNumberFormatsField;

		// Token: 0x0400216B RID: 8555
		private bool applyNumberFormatsFieldSpecified;

		// Token: 0x0400216C RID: 8556
		private bool applyBorderFormatsField;

		// Token: 0x0400216D RID: 8557
		private bool applyBorderFormatsFieldSpecified;

		// Token: 0x0400216E RID: 8558
		private bool applyFontFormatsField;

		// Token: 0x0400216F RID: 8559
		private bool applyFontFormatsFieldSpecified;

		// Token: 0x04002170 RID: 8560
		private bool applyPatternFormatsField;

		// Token: 0x04002171 RID: 8561
		private bool applyPatternFormatsFieldSpecified;

		// Token: 0x04002172 RID: 8562
		private bool applyAlignmentFormatsField;

		// Token: 0x04002173 RID: 8563
		private bool applyAlignmentFormatsFieldSpecified;

		// Token: 0x04002174 RID: 8564
		private bool applyWidthHeightFormatsField;

		// Token: 0x04002175 RID: 8565
		private bool applyWidthHeightFormatsFieldSpecified;

		// Token: 0x04002176 RID: 8566
		private string dataCaptionField;

		// Token: 0x04002177 RID: 8567
		private string grandTotalCaptionField;

		// Token: 0x04002178 RID: 8568
		private string errorCaptionField;

		// Token: 0x04002179 RID: 8569
		private bool showErrorField;

		// Token: 0x0400217A RID: 8570
		private string missingCaptionField;

		// Token: 0x0400217B RID: 8571
		private bool showMissingField;

		// Token: 0x0400217C RID: 8572
		private string pageStyleField;

		// Token: 0x0400217D RID: 8573
		private string pivotTableStyleField;

		// Token: 0x0400217E RID: 8574
		private string vacatedStyleField;

		// Token: 0x0400217F RID: 8575
		private string tagField;

		// Token: 0x04002180 RID: 8576
		private byte updatedVersionField;

		// Token: 0x04002181 RID: 8577
		private byte minRefreshableVersionField;

		// Token: 0x04002182 RID: 8578
		private bool asteriskTotalsField;

		// Token: 0x04002183 RID: 8579
		private bool showItemsField;

		// Token: 0x04002184 RID: 8580
		private bool editDataField;

		// Token: 0x04002185 RID: 8581
		private bool disableFieldListField;

		// Token: 0x04002186 RID: 8582
		private bool showCalcMbrsField;

		// Token: 0x04002187 RID: 8583
		private bool visualTotalsField;

		// Token: 0x04002188 RID: 8584
		private bool showMultipleLabelField;

		// Token: 0x04002189 RID: 8585
		private bool showDataDropDownField;

		// Token: 0x0400218A RID: 8586
		private bool showDrillField;

		// Token: 0x0400218B RID: 8587
		private bool printDrillField;

		// Token: 0x0400218C RID: 8588
		private bool showMemberPropertyTipsField;

		// Token: 0x0400218D RID: 8589
		private bool showDataTipsField;

		// Token: 0x0400218E RID: 8590
		private bool enableWizardField;

		// Token: 0x0400218F RID: 8591
		private bool enableDrillField;

		// Token: 0x04002190 RID: 8592
		private bool enableFieldPropertiesField;

		// Token: 0x04002191 RID: 8593
		private bool preserveFormattingField;

		// Token: 0x04002192 RID: 8594
		private bool useAutoFormattingField;

		// Token: 0x04002193 RID: 8595
		private uint pageWrapField;

		// Token: 0x04002194 RID: 8596
		private bool pageOverThenDownField;

		// Token: 0x04002195 RID: 8597
		private bool subtotalHiddenItemsField;

		// Token: 0x04002196 RID: 8598
		private bool rowGrandTotalsField;

		// Token: 0x04002197 RID: 8599
		private bool colGrandTotalsField;

		// Token: 0x04002198 RID: 8600
		private bool fieldPrintTitlesField;

		// Token: 0x04002199 RID: 8601
		private bool itemPrintTitlesField;

		// Token: 0x0400219A RID: 8602
		private bool mergeItemField;

		// Token: 0x0400219B RID: 8603
		private bool showDropZonesField;

		// Token: 0x0400219C RID: 8604
		private byte createdVersionField;

		// Token: 0x0400219D RID: 8605
		private uint indentField;

		// Token: 0x0400219E RID: 8606
		private bool showEmptyRowField;

		// Token: 0x0400219F RID: 8607
		private bool showEmptyColField;

		// Token: 0x040021A0 RID: 8608
		private bool showHeadersField;

		// Token: 0x040021A1 RID: 8609
		private bool compactField;

		// Token: 0x040021A2 RID: 8610
		private bool outlineField;

		// Token: 0x040021A3 RID: 8611
		private bool outlineDataField;

		// Token: 0x040021A4 RID: 8612
		private bool compactDataField;

		// Token: 0x040021A5 RID: 8613
		private bool publishedField;

		// Token: 0x040021A6 RID: 8614
		private bool gridDropZonesField;

		// Token: 0x040021A7 RID: 8615
		private bool immersiveField;

		// Token: 0x040021A8 RID: 8616
		private bool multipleFieldFiltersField;

		// Token: 0x040021A9 RID: 8617
		private uint chartFormatField;

		// Token: 0x040021AA RID: 8618
		private string rowHeaderCaptionField;

		// Token: 0x040021AB RID: 8619
		private string colHeaderCaptionField;

		// Token: 0x040021AC RID: 8620
		private bool fieldListSortAscendingField;

		// Token: 0x040021AD RID: 8621
		private bool mdxSubqueriesField;

		// Token: 0x040021AE RID: 8622
		private bool customListSortField;
	}
}
