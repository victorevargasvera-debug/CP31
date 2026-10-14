using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000514 RID: 1300
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", ElementName = "worksheet", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Worksheet
	{
		// Token: 0x0600381D RID: 14365 RVA: 0x0008BD90 File Offset: 0x00089F90
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet ct_Worksheet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet();
			ct_Worksheet.cols = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols>();
			ct_Worksheet.conditionalFormatting = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sheetPr")
				{
					ct_Worksheet.sheetPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dimension")
				{
					ct_Worksheet.dimension = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetDimension.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sheetViews")
				{
					ct_Worksheet.sheetViews = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sheetFormatPr")
				{
					ct_Worksheet.sheetFormatPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sheetData")
				{
					ct_Worksheet.sheetData = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetData.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sheetCalcPr")
				{
					ct_Worksheet.sheetCalcPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetCalcPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sheetProtection")
				{
					ct_Worksheet.sheetProtection = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "protectedRanges")
				{
					ct_Worksheet.protectedRanges = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRanges.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "scenarios")
				{
					ct_Worksheet.scenarios = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenarios.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoFilter")
				{
					ct_Worksheet.autoFilter = global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sortState")
				{
					ct_Worksheet.sortState = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dataConsolidate")
				{
					ct_Worksheet.dataConsolidate = global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataConsolidate.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "customSheetViews")
				{
					ct_Worksheet.customSheetViews = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetViews.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mergeCells")
				{
					ct_Worksheet.mergeCells = global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "phoneticPr")
				{
					ct_Worksheet.phoneticPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dataValidations")
				{
					ct_Worksheet.dataValidations = global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidations.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hyperlinks")
				{
					ct_Worksheet.hyperlinks = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlinks.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "printOptions")
				{
					ct_Worksheet.printOptions = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageMargins")
				{
					ct_Worksheet.pageMargins = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageSetup")
				{
					ct_Worksheet.pageSetup = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "headerFooter")
				{
					ct_Worksheet.headerFooter = global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rowBreaks")
				{
					ct_Worksheet.rowBreaks = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "colBreaks")
				{
					ct_Worksheet.colBreaks = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "customProperties")
				{
					ct_Worksheet.customProperties = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cellWatches")
				{
					ct_Worksheet.cellWatches = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatches.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ignoredErrors")
				{
					ct_Worksheet.ignoredErrors = global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredErrors.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "smartTags")
				{
					ct_Worksheet.smartTags = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTags.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "drawing")
				{
					ct_Worksheet.drawing = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "legacyDrawing")
				{
					ct_Worksheet.legacyDrawing = global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "legacyDrawingHF")
				{
					ct_Worksheet.legacyDrawingHF = global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "picture")
				{
					ct_Worksheet.picture = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetBackgroundPicture.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "oleObjects")
				{
					ct_Worksheet.oleObjects = global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObjects.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "controls")
				{
					ct_Worksheet.controls = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Controls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "webPublishItems")
				{
					ct_Worksheet.webPublishItems = global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItems.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tableParts")
				{
					ct_Worksheet.tableParts = global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableParts.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Worksheet.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cols")
				{
					ct_Worksheet.cols.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "conditionalFormatting")
				{
					ct_Worksheet.conditionalFormatting.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Worksheet;
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x0008C36C File Offset: 0x0008A56C
		internal void Write(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				streamWriter.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
				streamWriter.Write("<worksheet xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\"");
				streamWriter.Write(" xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" mc:Ignorable=\"x14ac xr xr2 xr3\" xmlns:x14ac=\"http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac\"");
				streamWriter.Write(" xmlns:xr=\"http://schemas.microsoft.com/office/spreadsheetml/2014/revision\" xmlns:xr2=\"http://schemas.microsoft.com/office/spreadsheetml/2015/revision2\" xmlns:xr3=\"http://schemas.microsoft.com/office/spreadsheetml/2016/revision3\"");
				streamWriter.Write(">");
				if (this.sheetPr != null)
				{
					this.sheetPr.Write(streamWriter, "sheetPr");
				}
				if (this.dimension != null)
				{
					this.dimension.Write(streamWriter, "dimension");
				}
				if (this.sheetViews != null)
				{
					this.sheetViews.Write(streamWriter, "sheetViews");
				}
				if (this.sheetFormatPr != null)
				{
					this.sheetFormatPr.Write(streamWriter, "sheetFormatPr");
				}
				if (this.cols != null)
				{
					foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols ct_Cols in this.cols)
					{
						ct_Cols.Write(streamWriter, "cols");
					}
				}
				if (this.sheetData != null)
				{
					this.sheetData.Write(streamWriter, "sheetData");
				}
				if (this.sheetCalcPr != null)
				{
					this.sheetCalcPr.Write(streamWriter, "sheetCalcPr");
				}
				if (this.sheetProtection != null)
				{
					this.sheetProtection.Write(streamWriter, "sheetProtection");
				}
				if (this.protectedRanges != null)
				{
					this.protectedRanges.Write(streamWriter, "protectedRanges");
				}
				if (this.scenarios != null)
				{
					this.scenarios.Write(streamWriter, "scenarios");
				}
				if (this.autoFilter != null)
				{
					this.autoFilter.Write(streamWriter, "autoFilter");
				}
				if (this.sortState != null)
				{
					this.sortState.Write(streamWriter, "sortState");
				}
				if (this.dataConsolidate != null)
				{
					this.dataConsolidate.Write(streamWriter, "dataConsolidate");
				}
				if (this.customSheetViews != null)
				{
					this.customSheetViews.Write(streamWriter, "customSheetViews");
				}
				if (this.mergeCells != null)
				{
					this.mergeCells.Write(streamWriter, "mergeCells");
				}
				if (this.phoneticPr != null)
				{
					this.phoneticPr.Write(streamWriter, "phoneticPr");
				}
				if (this.conditionalFormatting != null)
				{
					foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting ct_ConditionalFormatting in this.conditionalFormatting)
					{
						ct_ConditionalFormatting.Write(streamWriter, "conditionalFormatting");
					}
				}
				if (this.dataValidations != null)
				{
					this.dataValidations.Write(streamWriter, "dataValidations");
				}
				if (this.hyperlinks != null)
				{
					this.hyperlinks.Write(streamWriter, "hyperlinks");
				}
				if (this.printOptions != null)
				{
					this.printOptions.Write(streamWriter, "printOptions");
				}
				if (this.pageMargins != null)
				{
					this.pageMargins.Write(streamWriter, "pageMargins");
				}
				if (this.pageSetup != null)
				{
					this.pageSetup.Write(streamWriter, "pageSetup");
				}
				if (this.headerFooter != null)
				{
					this.headerFooter.Write(streamWriter, "headerFooter");
				}
				if (this.rowBreaks != null)
				{
					this.rowBreaks.Write(streamWriter, "rowBreaks");
				}
				if (this.colBreaks != null)
				{
					this.colBreaks.Write(streamWriter, "colBreaks");
				}
				if (this.customProperties != null)
				{
					this.customProperties.Write(streamWriter, "customProperties");
				}
				if (this.cellWatches != null)
				{
					this.cellWatches.Write(streamWriter, "cellWatches");
				}
				if (this.ignoredErrors != null)
				{
					this.ignoredErrors.Write(streamWriter, "ignoredErrors");
				}
				if (this.smartTags != null)
				{
					this.smartTags.Write(streamWriter, "smartTags");
				}
				if (this.drawing != null)
				{
					this.drawing.Write(streamWriter, "drawing");
				}
				if (this.legacyDrawing != null)
				{
					this.legacyDrawing.Write(streamWriter, "legacyDrawing");
				}
				if (this.legacyDrawingHF != null)
				{
					this.legacyDrawingHF.Write(streamWriter, "legacyDrawingHF");
				}
				if (this.picture != null)
				{
					this.picture.Write(streamWriter, "picture");
				}
				if (this.oleObjects != null)
				{
					this.oleObjects.Write(streamWriter, "oleObjects");
				}
				if (this.controls != null)
				{
					this.controls.Write(streamWriter, "controls");
				}
				if (this.webPublishItems != null)
				{
					this.webPublishItems.Write(streamWriter, "webPublishItems");
				}
				if (this.tableParts != null)
				{
					this.tableParts.Write(streamWriter, "tableParts");
				}
				if (this.extLst != null)
				{
					this.extLst.Write(streamWriter, "extLst");
				}
				streamWriter.Write("</worksheet>");
			}
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x0008C820 File Offset: 0x0008AA20
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter AddNewAutoFilter()
		{
			this.autoFilterField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter();
			return this.autoFilterField;
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x0008C833 File Offset: 0x0008AA33
		public bool IsSetRowBreaks()
		{
			return this.rowBreaksField != null;
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x0008C83E File Offset: 0x0008AA3E
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing AddNewDrawing()
		{
			this.drawingField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing();
			return this.drawingField;
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x0008C851 File Offset: 0x0008AA51
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing AddNewLegacyDrawing()
		{
			this.legacyDrawing = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing();
			return this.legacyDrawing;
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x0008C864 File Offset: 0x0008AA64
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak AddNewRowBreaks()
		{
			this.rowBreaksField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak();
			return this.rowBreaksField;
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x0008C877 File Offset: 0x0008AA77
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak AddNewColBreaks()
		{
			this.colBreaksField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak();
			return this.colBreaksField;
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x0008C88A File Offset: 0x0008AA8A
		public bool IsSetSheetFormatPr()
		{
			return this.sheetFormatPrField != null;
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x0008C895 File Offset: 0x0008AA95
		public bool IsSetPrintOptions()
		{
			return this.printOptionsField != null;
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x0008C8A0 File Offset: 0x0008AAA0
		public void UnsetMergeCells()
		{
			this.mergeCellsField = null;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x0008C8A9 File Offset: 0x0008AAA9
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions AddNewPrintOptions()
		{
			this.printOptionsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions();
			return this.printOptionsField;
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x0008C8BC File Offset: 0x0008AABC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidations AddNewDataValidations()
		{
			this.dataValidationsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidations();
			return this.dataValidationsField;
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x0008C8CF File Offset: 0x0008AACF
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews AddNewSheetViews()
		{
			this.sheetViewsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews();
			return this.sheetViewsField;
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x0008C8E2 File Offset: 0x0008AAE2
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlinks AddNewHyperlinks()
		{
			this.hyperlinksField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlinks();
			return this.hyperlinksField;
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x0008C8F8 File Offset: 0x0008AAF8
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting AddNewConditionalFormatting()
		{
			if (this.conditionalFormattingField == null)
			{
				this.conditionalFormattingField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting ct_ConditionalFormatting = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting();
			this.conditionalFormattingField.Add(ct_ConditionalFormatting);
			return ct_ConditionalFormatting;
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x0008C92B File Offset: 0x0008AB2B
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting GetConditionalFormattingArray(int index)
		{
			if (this.conditionalFormattingField != null)
			{
				return this.conditionalFormattingField[index];
			}
			return null;
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x0008C943 File Offset: 0x0008AB43
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells AddNewMergeCells()
		{
			this.mergeCellsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells();
			return this.mergeCellsField;
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x0008C956 File Offset: 0x0008AB56
		public bool IsSetColBreaks()
		{
			return this.colBreaksField != null;
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x0008C961 File Offset: 0x0008AB61
		public bool IsSetHyperlinks()
		{
			return this.hyperlinksField != null;
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x0008C96C File Offset: 0x0008AB6C
		public bool IsSetMergeCells()
		{
			return this.mergeCellsField != null;
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x0008C977 File Offset: 0x0008AB77
		public bool IsSetSheetProtection()
		{
			return this.sheetProtectionField != null;
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x0008C982 File Offset: 0x0008AB82
		public bool IsSetDrawing()
		{
			return this.drawingField != null;
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x0008C98D File Offset: 0x0008AB8D
		public void UnsetDrawing()
		{
			this.drawingField = null;
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x0008C996 File Offset: 0x0008AB96
		public bool IsSetLegacyDrawing()
		{
			return this.legacyDrawingField != null;
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x0008C9A1 File Offset: 0x0008ABA1
		public void UnsetLegacyDrawing()
		{
			this.legacyDrawingField = null;
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x0008C9AA File Offset: 0x0008ABAA
		public bool IsSetPageSetup()
		{
			return this.pageSetupField != null;
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x0008C9B5 File Offset: 0x0008ABB5
		public bool IsSetTableParts()
		{
			return this.tablePartsField != null;
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x0008C9C0 File Offset: 0x0008ABC0
		public bool IsSetSheetCalcPr()
		{
			return this.sheetCalcPrField != null;
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x0008C9CB File Offset: 0x0008ABCB
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection AddNewSheetProtection()
		{
			this.sheetProtectionField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection();
			return this.sheetProtectionField;
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x0008C9DE File Offset: 0x0008ABDE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableParts AddNewTableParts()
		{
			this.tablePartsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableParts();
			return this.tablePartsField;
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x0008C9F1 File Offset: 0x0008ABF1
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins AddNewPageMargins()
		{
			this.pageMarginsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins();
			return this.pageMarginsField;
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x0008CA04 File Offset: 0x0008AC04
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup AddNewPageSetup()
		{
			this.pageSetupField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup();
			return this.pageSetupField;
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x0008CA17 File Offset: 0x0008AC17
		public void SetColsArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols> a)
		{
			this.colsField = a;
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x0008CA20 File Offset: 0x0008AC20
		public int sizeOfColsArray()
		{
			if (this.colsField != null)
			{
				return this.colsField.Count;
			}
			return 0;
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x0008CA37 File Offset: 0x0008AC37
		public void RemoveCols(int index)
		{
			this.colsField.RemoveAt(index);
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x0008CA48 File Offset: 0x0008AC48
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols AddNewCols()
		{
			if (this.colsField == null)
			{
				this.colsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols ct_Cols = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols();
			this.colsField.Add(ct_Cols);
			return ct_Cols;
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x0008CA7B File Offset: 0x0008AC7B
		public void SetColsArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols newCols)
		{
			if (this.colsField == null)
			{
				this.colsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols>();
			}
			else
			{
				this.colsField.Clear();
			}
			this.colsField.Insert(index, newCols);
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x0008CAAA File Offset: 0x0008ACAA
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols GetColsArray(int index)
		{
			if (this.colsField == null)
			{
				this.colsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols>();
				this.colsField.Add(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols());
			}
			return this.colsField[index];
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x0008CADB File Offset: 0x0008ACDB
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols> GetColsList()
		{
			return this.colsField;
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x0008CAE3 File Offset: 0x0008ACE3
		public bool IsSetPageMargins()
		{
			return this.pageMarginsField != null;
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x0008C961 File Offset: 0x0008AB61
		public bool IsSetHyperLinks()
		{
			return this.hyperlinksField != null;
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x0008CAEE File Offset: 0x0008ACEE
		public bool IsSetSheetPr()
		{
			return this.sheetPrField != null;
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x0008CAF9 File Offset: 0x0008ACF9
		public int SizeOfConditionalFormattingArray()
		{
			if (this.conditionalFormattingField != null)
			{
				return this.conditionalFormatting.Count;
			}
			return 0;
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x0008CB10 File Offset: 0x0008AD10
		public void UnsetSheetProtection()
		{
			this.sheetProtectionField = null;
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x0008CB19 File Offset: 0x0008AD19
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr AddNewSheetFormatPr()
		{
			this.sheetFormatPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr();
			return this.sheetFormatPrField;
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x0008CB2C File Offset: 0x0008AD2C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetCalcPr AddNewSheetCalcPr()
		{
			this.sheetCalcPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetCalcPr();
			return this.sheetCalcPrField;
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x0008CB3F File Offset: 0x0008AD3F
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr AddNewSheetPr()
		{
			this.sheetPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr();
			return this.sheetPrField;
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x0008CB52 File Offset: 0x0008AD52
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetDimension AddNewDimension()
		{
			this.dimensionField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetDimension();
			return this.dimensionField;
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x0008CB65 File Offset: 0x0008AD65
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetData AddNewSheetData()
		{
			this.sheetDataField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetData();
			return this.sheetDataField;
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x0600384F RID: 14415 RVA: 0x0008CB78 File Offset: 0x0008AD78
		// (set) Token: 0x06003850 RID: 14416 RVA: 0x0008CB80 File Offset: 0x0008AD80
		[global::System.Xml.Serialization.XmlElement("sheetPr")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetPr
		{
			get
			{
				return this.sheetPrField;
			}
			set
			{
				this.sheetPrField = value;
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06003851 RID: 14417 RVA: 0x0008CB89 File Offset: 0x0008AD89
		// (set) Token: 0x06003852 RID: 14418 RVA: 0x0008CB91 File Offset: 0x0008AD91
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetDimension dimension
		{
			get
			{
				return this.dimensionField;
			}
			set
			{
				this.dimensionField = value;
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06003853 RID: 14419 RVA: 0x0008CB9A File Offset: 0x0008AD9A
		// (set) Token: 0x06003854 RID: 14420 RVA: 0x0008CBA2 File Offset: 0x0008ADA2
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews sheetViews
		{
			get
			{
				return this.sheetViewsField;
			}
			set
			{
				this.sheetViewsField = value;
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x0008CBAB File Offset: 0x0008ADAB
		// (set) Token: 0x06003856 RID: 14422 RVA: 0x0008CBB3 File Offset: 0x0008ADB3
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr sheetFormatPr
		{
			get
			{
				return this.sheetFormatPrField;
			}
			set
			{
				this.sheetFormatPrField = value;
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06003857 RID: 14423 RVA: 0x0008CADB File Offset: 0x0008ACDB
		// (set) Token: 0x06003858 RID: 14424 RVA: 0x0008CA17 File Offset: 0x0008AC17
		[global::System.Xml.Serialization.XmlElement("cols")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols> cols
		{
			get
			{
				return this.colsField;
			}
			set
			{
				this.colsField = value;
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06003859 RID: 14425 RVA: 0x0008CBBC File Offset: 0x0008ADBC
		// (set) Token: 0x0600385A RID: 14426 RVA: 0x0008CBC4 File Offset: 0x0008ADC4
		[global::System.Xml.Serialization.XmlElement("sheetData", IsNullable = false)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetData sheetData
		{
			get
			{
				return this.sheetDataField;
			}
			set
			{
				this.sheetDataField = value;
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x0600385B RID: 14427 RVA: 0x0008CBCD File Offset: 0x0008ADCD
		// (set) Token: 0x0600385C RID: 14428 RVA: 0x0008CBD5 File Offset: 0x0008ADD5
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetCalcPr sheetCalcPr
		{
			get
			{
				return this.sheetCalcPrField;
			}
			set
			{
				this.sheetCalcPrField = value;
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x0600385D RID: 14429 RVA: 0x0008CBDE File Offset: 0x0008ADDE
		// (set) Token: 0x0600385E RID: 14430 RVA: 0x0008CBE6 File Offset: 0x0008ADE6
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection sheetProtection
		{
			get
			{
				return this.sheetProtectionField;
			}
			set
			{
				this.sheetProtectionField = value;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x0600385F RID: 14431 RVA: 0x0008CBEF File Offset: 0x0008ADEF
		// (set) Token: 0x06003860 RID: 14432 RVA: 0x0008CBF7 File Offset: 0x0008ADF7
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRanges protectedRanges
		{
			get
			{
				return this.protectedRangesField;
			}
			set
			{
				this.protectedRangesField = value;
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06003861 RID: 14433 RVA: 0x0008CC00 File Offset: 0x0008AE00
		// (set) Token: 0x06003862 RID: 14434 RVA: 0x0008CC08 File Offset: 0x0008AE08
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenarios scenarios
		{
			get
			{
				return this.scenariosField;
			}
			set
			{
				this.scenariosField = value;
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06003863 RID: 14435 RVA: 0x0008CC11 File Offset: 0x0008AE11
		// (set) Token: 0x06003864 RID: 14436 RVA: 0x0008CC19 File Offset: 0x0008AE19
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

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x0008CC22 File Offset: 0x0008AE22
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x0008CC2A File Offset: 0x0008AE2A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState sortState
		{
			get
			{
				return this.sortStateField;
			}
			set
			{
				this.sortStateField = value;
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x0008CC33 File Offset: 0x0008AE33
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x0008CC3B File Offset: 0x0008AE3B
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataConsolidate dataConsolidate
		{
			get
			{
				return this.dataConsolidateField;
			}
			set
			{
				this.dataConsolidateField = value;
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x0008CC44 File Offset: 0x0008AE44
		// (set) Token: 0x0600386A RID: 14442 RVA: 0x0008CC4C File Offset: 0x0008AE4C
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetViews customSheetViews
		{
			get
			{
				return this.customSheetViewsField;
			}
			set
			{
				this.customSheetViewsField = value;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x0008CC55 File Offset: 0x0008AE55
		// (set) Token: 0x0600386C RID: 14444 RVA: 0x0008CC5D File Offset: 0x0008AE5D
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells mergeCells
		{
			get
			{
				return this.mergeCellsField;
			}
			set
			{
				this.mergeCellsField = value;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x0600386D RID: 14445 RVA: 0x0008CC66 File Offset: 0x0008AE66
		// (set) Token: 0x0600386E RID: 14446 RVA: 0x0008CC6E File Offset: 0x0008AE6E
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr phoneticPr
		{
			get
			{
				return this.phoneticPrField;
			}
			set
			{
				this.phoneticPrField = value;
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x0600386F RID: 14447 RVA: 0x0008CC77 File Offset: 0x0008AE77
		// (set) Token: 0x06003870 RID: 14448 RVA: 0x0008CC92 File Offset: 0x0008AE92
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting> conditionalFormatting
		{
			get
			{
				if (this.conditionalFormattingField == null)
				{
					this.conditionalFormattingField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting>();
				}
				return this.conditionalFormattingField;
			}
			set
			{
				this.conditionalFormattingField = value;
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06003871 RID: 14449 RVA: 0x0008CC9B File Offset: 0x0008AE9B
		// (set) Token: 0x06003872 RID: 14450 RVA: 0x0008CCA3 File Offset: 0x0008AEA3
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidations dataValidations
		{
			get
			{
				return this.dataValidationsField;
			}
			set
			{
				this.dataValidationsField = value;
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06003873 RID: 14451 RVA: 0x0008CCAC File Offset: 0x0008AEAC
		// (set) Token: 0x06003874 RID: 14452 RVA: 0x0008CCB4 File Offset: 0x0008AEB4
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlinks hyperlinks
		{
			get
			{
				return this.hyperlinksField;
			}
			set
			{
				this.hyperlinksField = value;
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06003875 RID: 14453 RVA: 0x0008CCBD File Offset: 0x0008AEBD
		// (set) Token: 0x06003876 RID: 14454 RVA: 0x0008CCC5 File Offset: 0x0008AEC5
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x0008CCCE File Offset: 0x0008AECE
		// (set) Token: 0x06003878 RID: 14456 RVA: 0x0008CCD6 File Offset: 0x0008AED6
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x0008CCDF File Offset: 0x0008AEDF
		// (set) Token: 0x0600387A RID: 14458 RVA: 0x0008CCE7 File Offset: 0x0008AEE7
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x0008CCF0 File Offset: 0x0008AEF0
		// (set) Token: 0x0600387C RID: 14460 RVA: 0x0008CCF8 File Offset: 0x0008AEF8
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x0008CD01 File Offset: 0x0008AF01
		// (set) Token: 0x0600387E RID: 14462 RVA: 0x0008CD09 File Offset: 0x0008AF09
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x0008CD12 File Offset: 0x0008AF12
		// (set) Token: 0x06003880 RID: 14464 RVA: 0x0008CD1A File Offset: 0x0008AF1A
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x0008CD23 File Offset: 0x0008AF23
		// (set) Token: 0x06003882 RID: 14466 RVA: 0x0008CD2B File Offset: 0x0008AF2B
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperties customProperties
		{
			get
			{
				return this.customPropertiesField;
			}
			set
			{
				this.customPropertiesField = value;
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06003883 RID: 14467 RVA: 0x0008CD34 File Offset: 0x0008AF34
		// (set) Token: 0x06003884 RID: 14468 RVA: 0x0008CD3C File Offset: 0x0008AF3C
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatches cellWatches
		{
			get
			{
				return this.cellWatchesField;
			}
			set
			{
				this.cellWatchesField = value;
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x0008CD45 File Offset: 0x0008AF45
		// (set) Token: 0x06003886 RID: 14470 RVA: 0x0008CD4D File Offset: 0x0008AF4D
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredErrors ignoredErrors
		{
			get
			{
				return this.ignoredErrorsField;
			}
			set
			{
				this.ignoredErrorsField = value;
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06003887 RID: 14471 RVA: 0x0008CD56 File Offset: 0x0008AF56
		// (set) Token: 0x06003888 RID: 14472 RVA: 0x0008CD5E File Offset: 0x0008AF5E
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTags smartTags
		{
			get
			{
				return this.smartTagsField;
			}
			set
			{
				this.smartTagsField = value;
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06003889 RID: 14473 RVA: 0x0008CD67 File Offset: 0x0008AF67
		// (set) Token: 0x0600388A RID: 14474 RVA: 0x0008CD6F File Offset: 0x0008AF6F
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing drawing
		{
			get
			{
				return this.drawingField;
			}
			set
			{
				this.drawingField = value;
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x0600388B RID: 14475 RVA: 0x0008CD78 File Offset: 0x0008AF78
		// (set) Token: 0x0600388C RID: 14476 RVA: 0x0008CD80 File Offset: 0x0008AF80
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawing
		{
			get
			{
				return this.legacyDrawingField;
			}
			set
			{
				this.legacyDrawingField = value;
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x0600388D RID: 14477 RVA: 0x0008CD89 File Offset: 0x0008AF89
		// (set) Token: 0x0600388E RID: 14478 RVA: 0x0008CD91 File Offset: 0x0008AF91
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawingHF
		{
			get
			{
				return this.legacyDrawingHFField;
			}
			set
			{
				this.legacyDrawingHFField = value;
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x0600388F RID: 14479 RVA: 0x0008CD9A File Offset: 0x0008AF9A
		// (set) Token: 0x06003890 RID: 14480 RVA: 0x0008CDA2 File Offset: 0x0008AFA2
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetBackgroundPicture picture
		{
			get
			{
				return this.pictureField;
			}
			set
			{
				this.pictureField = value;
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06003891 RID: 14481 RVA: 0x0008CDAB File Offset: 0x0008AFAB
		// (set) Token: 0x06003892 RID: 14482 RVA: 0x0008CDB3 File Offset: 0x0008AFB3
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObjects oleObjects
		{
			get
			{
				return this.oleObjectsField;
			}
			set
			{
				this.oleObjectsField = value;
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06003893 RID: 14483 RVA: 0x0008CDBC File Offset: 0x0008AFBC
		// (set) Token: 0x06003894 RID: 14484 RVA: 0x0008CDC4 File Offset: 0x0008AFC4
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Controls controls
		{
			get
			{
				return this.controlsField;
			}
			set
			{
				this.controlsField = value;
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06003895 RID: 14485 RVA: 0x0008CDCD File Offset: 0x0008AFCD
		// (set) Token: 0x06003896 RID: 14486 RVA: 0x0008CDD5 File Offset: 0x0008AFD5
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItems webPublishItems
		{
			get
			{
				return this.webPublishItemsField;
			}
			set
			{
				this.webPublishItemsField = value;
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06003897 RID: 14487 RVA: 0x0008CDDE File Offset: 0x0008AFDE
		// (set) Token: 0x06003898 RID: 14488 RVA: 0x0008CDE6 File Offset: 0x0008AFE6
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableParts tableParts
		{
			get
			{
				return this.tablePartsField;
			}
			set
			{
				this.tablePartsField = value;
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06003899 RID: 14489 RVA: 0x0008CDEF File Offset: 0x0008AFEF
		// (set) Token: 0x0600389A RID: 14490 RVA: 0x0008CDF7 File Offset: 0x0008AFF7
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

		// Token: 0x0600389B RID: 14491 RVA: 0x0008CE00 File Offset: 0x0008B000
		public void UnsetPageSetup()
		{
			this.pageSetup = null;
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x0008CE09 File Offset: 0x0008B009
		public bool IsSetIgnoredErrors()
		{
			return this.ignoredErrors != null;
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x0008CE14 File Offset: 0x0008B014
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredErrors AddNewIgnoredErrors()
		{
			this.ignoredErrorsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredErrors();
			return this.ignoredErrorsField;
		}

		// Token: 0x04002448 RID: 9288
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetPrField;

		// Token: 0x04002449 RID: 9289
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetDimension dimensionField;

		// Token: 0x0400244A RID: 9290
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews sheetViewsField;

		// Token: 0x0400244B RID: 9291
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr sheetFormatPrField;

		// Token: 0x0400244C RID: 9292
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols> colsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols>();

		// Token: 0x0400244D RID: 9293
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetData sheetDataField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetData();

		// Token: 0x0400244E RID: 9294
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetCalcPr sheetCalcPrField;

		// Token: 0x0400244F RID: 9295
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection sheetProtectionField;

		// Token: 0x04002450 RID: 9296
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRanges protectedRangesField;

		// Token: 0x04002451 RID: 9297
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenarios scenariosField;

		// Token: 0x04002452 RID: 9298
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter autoFilterField;

		// Token: 0x04002453 RID: 9299
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState sortStateField;

		// Token: 0x04002454 RID: 9300
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataConsolidate dataConsolidateField;

		// Token: 0x04002455 RID: 9301
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomSheetViews customSheetViewsField;

		// Token: 0x04002456 RID: 9302
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells mergeCellsField;

		// Token: 0x04002457 RID: 9303
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr phoneticPrField;

		// Token: 0x04002458 RID: 9304
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting> conditionalFormattingField;

		// Token: 0x04002459 RID: 9305
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidations dataValidationsField;

		// Token: 0x0400245A RID: 9306
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlinks hyperlinksField;

		// Token: 0x0400245B RID: 9307
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions printOptionsField;

		// Token: 0x0400245C RID: 9308
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins pageMarginsField;

		// Token: 0x0400245D RID: 9309
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup pageSetupField;

		// Token: 0x0400245E RID: 9310
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooterField;

		// Token: 0x0400245F RID: 9311
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak rowBreaksField;

		// Token: 0x04002460 RID: 9312
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak colBreaksField;

		// Token: 0x04002461 RID: 9313
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperties customPropertiesField;

		// Token: 0x04002462 RID: 9314
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatches cellWatchesField;

		// Token: 0x04002463 RID: 9315
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredErrors ignoredErrorsField;

		// Token: 0x04002464 RID: 9316
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTags smartTagsField;

		// Token: 0x04002465 RID: 9317
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing drawingField;

		// Token: 0x04002466 RID: 9318
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawingField;

		// Token: 0x04002467 RID: 9319
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing legacyDrawingHFField;

		// Token: 0x04002468 RID: 9320
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetBackgroundPicture pictureField;

		// Token: 0x04002469 RID: 9321
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObjects oleObjectsField;

		// Token: 0x0400246A RID: 9322
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Controls controlsField;

		// Token: 0x0400246B RID: 9323
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItems webPublishItemsField;

		// Token: 0x0400246C RID: 9324
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableParts tablePartsField;

		// Token: 0x0400246D RID: 9325
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
