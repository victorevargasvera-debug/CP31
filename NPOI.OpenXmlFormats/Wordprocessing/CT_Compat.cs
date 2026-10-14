using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000194 RID: 404
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Compat
	{
		// Token: 0x06000E96 RID: 3734 RVA: 0x00030550 File Offset: 0x0002E750
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Compat Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Compat ct_Compat = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Compat();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "useSingleBorderforContiguousCells")
				{
					ct_Compat.useSingleBorderforContiguousCells = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "wpJustification")
				{
					ct_Compat.wpJustification = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noTabHangInd")
				{
					ct_Compat.noTabHangInd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noLeading")
				{
					ct_Compat.noLeading = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spaceForUL")
				{
					ct_Compat.spaceForUL = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noColumnBalance")
				{
					ct_Compat.noColumnBalance = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "balanceSingleByteDoubleByteWidth")
				{
					ct_Compat.balanceSingleByteDoubleByteWidth = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noExtraLineSpacing")
				{
					ct_Compat.noExtraLineSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotLeaveBackslashAlone")
				{
					ct_Compat.doNotLeaveBackslashAlone = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ulTrailSpace")
				{
					ct_Compat.ulTrailSpace = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotExpandShiftReturn")
				{
					ct_Compat.doNotExpandShiftReturn = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spacingInWholePoints")
				{
					ct_Compat.spacingInWholePoints = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lineWrapLikeWord6")
				{
					ct_Compat.lineWrapLikeWord6 = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "printBodyTextBeforeHeader")
				{
					ct_Compat.printBodyTextBeforeHeader = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "printColBlack")
				{
					ct_Compat.printColBlack = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "wpSpaceWidth")
				{
					ct_Compat.wpSpaceWidth = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showBreaksInFrames")
				{
					ct_Compat.showBreaksInFrames = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "subFontBySize")
				{
					ct_Compat.subFontBySize = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suppressBottomSpacing")
				{
					ct_Compat.suppressBottomSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suppressTopSpacing")
				{
					ct_Compat.suppressTopSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suppressSpacingAtTopOfPage")
				{
					ct_Compat.suppressSpacingAtTopOfPage = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suppressTopSpacingWP")
				{
					ct_Compat.suppressTopSpacingWP = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suppressSpBfAfterPgBrk")
				{
					ct_Compat.suppressSpBfAfterPgBrk = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "swapBordersFacingPages")
				{
					ct_Compat.swapBordersFacingPages = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "convMailMergeEsc")
				{
					ct_Compat.convMailMergeEsc = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "truncateFontHeightsLikeWP6")
				{
					ct_Compat.truncateFontHeightsLikeWP6 = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mwSmallCaps")
				{
					ct_Compat.mwSmallCaps = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "usePrinterMetrics")
				{
					ct_Compat.usePrinterMetrics = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotSuppressParagraphBorders")
				{
					ct_Compat.doNotSuppressParagraphBorders = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "wrapTrailSpaces")
				{
					ct_Compat.wrapTrailSpaces = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "footnoteLayoutLikeWW8")
				{
					ct_Compat.footnoteLayoutLikeWW8 = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shapeLayoutLikeWW8")
				{
					ct_Compat.shapeLayoutLikeWW8 = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "alignTablesRowByRow")
				{
					ct_Compat.alignTablesRowByRow = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "forgetLastTabAlignment")
				{
					ct_Compat.forgetLastTabAlignment = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "adjustLineHeightInTable")
				{
					ct_Compat.adjustLineHeightInTable = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoSpaceLikeWord95")
				{
					ct_Compat.autoSpaceLikeWord95 = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noSpaceRaiseLower")
				{
					ct_Compat.noSpaceRaiseLower = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotUseHTMLParagraphAutoSpacing")
				{
					ct_Compat.doNotUseHTMLParagraphAutoSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "layoutRawTableWidth")
				{
					ct_Compat.layoutRawTableWidth = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "layoutTableRowsApart")
				{
					ct_Compat.layoutTableRowsApart = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "useWord97LineBreakRules")
				{
					ct_Compat.useWord97LineBreakRules = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotBreakWrappedTables")
				{
					ct_Compat.doNotBreakWrappedTables = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotSnapToGridInCell")
				{
					ct_Compat.doNotSnapToGridInCell = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "selectFldWithFirstOrLastChar")
				{
					ct_Compat.selectFldWithFirstOrLastChar = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "applyBreakingRules")
				{
					ct_Compat.applyBreakingRules = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotWrapTextWithPunct")
				{
					ct_Compat.doNotWrapTextWithPunct = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotUseEastAsianBreakRules")
				{
					ct_Compat.doNotUseEastAsianBreakRules = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "useWord2002TableStyleRules")
				{
					ct_Compat.useWord2002TableStyleRules = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "growAutofit")
				{
					ct_Compat.growAutofit = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "useFELayout")
				{
					ct_Compat.useFELayout = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "useNormalStyleForList")
				{
					ct_Compat.useNormalStyleForList = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotUseIndentAsNumberingTabStop")
				{
					ct_Compat.doNotUseIndentAsNumberingTabStop = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "useAltKinsokuLineBreakRules")
				{
					ct_Compat.useAltKinsokuLineBreakRules = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "allowSpaceOfSameStyleInTable")
				{
					ct_Compat.allowSpaceOfSameStyleInTable = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotSuppressIndentation")
				{
					ct_Compat.doNotSuppressIndentation = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotAutofitConstrainedTables")
				{
					ct_Compat.doNotAutofitConstrainedTables = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autofitToFirstFixedWidthCell")
				{
					ct_Compat.autofitToFirstFixedWidthCell = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "underlineTabInNumList")
				{
					ct_Compat.underlineTabInNumList = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "displayHangulFixedWidth")
				{
					ct_Compat.displayHangulFixedWidth = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "splitPgBreakAndParaMark")
				{
					ct_Compat.splitPgBreakAndParaMark = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotVertAlignCellWithSp")
				{
					ct_Compat.doNotVertAlignCellWithSp = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotBreakConstrainedForcedTable")
				{
					ct_Compat.doNotBreakConstrainedForcedTable = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotVertAlignInTxbx")
				{
					ct_Compat.doNotVertAlignInTxbx = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "useAnsiKerningPairs")
				{
					ct_Compat.useAnsiKerningPairs = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cachedColBalance")
				{
					ct_Compat.cachedColBalance = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Compat;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00030ED8 File Offset: 0x0002F0D8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.useSingleBorderforContiguousCells != null)
			{
				this.useSingleBorderforContiguousCells.Write(sw, "useSingleBorderforContiguousCells");
			}
			if (this.wpJustification != null)
			{
				this.wpJustification.Write(sw, "wpJustification");
			}
			if (this.noTabHangInd != null)
			{
				this.noTabHangInd.Write(sw, "noTabHangInd");
			}
			if (this.noLeading != null)
			{
				this.noLeading.Write(sw, "noLeading");
			}
			if (this.spaceForUL != null)
			{
				this.spaceForUL.Write(sw, "spaceForUL");
			}
			if (this.noColumnBalance != null)
			{
				this.noColumnBalance.Write(sw, "noColumnBalance");
			}
			if (this.balanceSingleByteDoubleByteWidth != null)
			{
				this.balanceSingleByteDoubleByteWidth.Write(sw, "balanceSingleByteDoubleByteWidth");
			}
			if (this.noExtraLineSpacing != null)
			{
				this.noExtraLineSpacing.Write(sw, "noExtraLineSpacing");
			}
			if (this.doNotLeaveBackslashAlone != null)
			{
				this.doNotLeaveBackslashAlone.Write(sw, "doNotLeaveBackslashAlone");
			}
			if (this.ulTrailSpace != null)
			{
				this.ulTrailSpace.Write(sw, "ulTrailSpace");
			}
			if (this.doNotExpandShiftReturn != null)
			{
				this.doNotExpandShiftReturn.Write(sw, "doNotExpandShiftReturn");
			}
			if (this.spacingInWholePoints != null)
			{
				this.spacingInWholePoints.Write(sw, "spacingInWholePoints");
			}
			if (this.lineWrapLikeWord6 != null)
			{
				this.lineWrapLikeWord6.Write(sw, "lineWrapLikeWord6");
			}
			if (this.printBodyTextBeforeHeader != null)
			{
				this.printBodyTextBeforeHeader.Write(sw, "printBodyTextBeforeHeader");
			}
			if (this.printColBlack != null)
			{
				this.printColBlack.Write(sw, "printColBlack");
			}
			if (this.wpSpaceWidth != null)
			{
				this.wpSpaceWidth.Write(sw, "wpSpaceWidth");
			}
			if (this.showBreaksInFrames != null)
			{
				this.showBreaksInFrames.Write(sw, "showBreaksInFrames");
			}
			if (this.subFontBySize != null)
			{
				this.subFontBySize.Write(sw, "subFontBySize");
			}
			if (this.suppressBottomSpacing != null)
			{
				this.suppressBottomSpacing.Write(sw, "suppressBottomSpacing");
			}
			if (this.suppressTopSpacing != null)
			{
				this.suppressTopSpacing.Write(sw, "suppressTopSpacing");
			}
			if (this.suppressSpacingAtTopOfPage != null)
			{
				this.suppressSpacingAtTopOfPage.Write(sw, "suppressSpacingAtTopOfPage");
			}
			if (this.suppressTopSpacingWP != null)
			{
				this.suppressTopSpacingWP.Write(sw, "suppressTopSpacingWP");
			}
			if (this.suppressSpBfAfterPgBrk != null)
			{
				this.suppressSpBfAfterPgBrk.Write(sw, "suppressSpBfAfterPgBrk");
			}
			if (this.swapBordersFacingPages != null)
			{
				this.swapBordersFacingPages.Write(sw, "swapBordersFacingPages");
			}
			if (this.convMailMergeEsc != null)
			{
				this.convMailMergeEsc.Write(sw, "convMailMergeEsc");
			}
			if (this.truncateFontHeightsLikeWP6 != null)
			{
				this.truncateFontHeightsLikeWP6.Write(sw, "truncateFontHeightsLikeWP6");
			}
			if (this.mwSmallCaps != null)
			{
				this.mwSmallCaps.Write(sw, "mwSmallCaps");
			}
			if (this.usePrinterMetrics != null)
			{
				this.usePrinterMetrics.Write(sw, "usePrinterMetrics");
			}
			if (this.doNotSuppressParagraphBorders != null)
			{
				this.doNotSuppressParagraphBorders.Write(sw, "doNotSuppressParagraphBorders");
			}
			if (this.wrapTrailSpaces != null)
			{
				this.wrapTrailSpaces.Write(sw, "wrapTrailSpaces");
			}
			if (this.footnoteLayoutLikeWW8 != null)
			{
				this.footnoteLayoutLikeWW8.Write(sw, "footnoteLayoutLikeWW8");
			}
			if (this.shapeLayoutLikeWW8 != null)
			{
				this.shapeLayoutLikeWW8.Write(sw, "shapeLayoutLikeWW8");
			}
			if (this.alignTablesRowByRow != null)
			{
				this.alignTablesRowByRow.Write(sw, "alignTablesRowByRow");
			}
			if (this.forgetLastTabAlignment != null)
			{
				this.forgetLastTabAlignment.Write(sw, "forgetLastTabAlignment");
			}
			if (this.adjustLineHeightInTable != null)
			{
				this.adjustLineHeightInTable.Write(sw, "adjustLineHeightInTable");
			}
			if (this.autoSpaceLikeWord95 != null)
			{
				this.autoSpaceLikeWord95.Write(sw, "autoSpaceLikeWord95");
			}
			if (this.noSpaceRaiseLower != null)
			{
				this.noSpaceRaiseLower.Write(sw, "noSpaceRaiseLower");
			}
			if (this.doNotUseHTMLParagraphAutoSpacing != null)
			{
				this.doNotUseHTMLParagraphAutoSpacing.Write(sw, "doNotUseHTMLParagraphAutoSpacing");
			}
			if (this.layoutRawTableWidth != null)
			{
				this.layoutRawTableWidth.Write(sw, "layoutRawTableWidth");
			}
			if (this.layoutTableRowsApart != null)
			{
				this.layoutTableRowsApart.Write(sw, "layoutTableRowsApart");
			}
			if (this.useWord97LineBreakRules != null)
			{
				this.useWord97LineBreakRules.Write(sw, "useWord97LineBreakRules");
			}
			if (this.doNotBreakWrappedTables != null)
			{
				this.doNotBreakWrappedTables.Write(sw, "doNotBreakWrappedTables");
			}
			if (this.doNotSnapToGridInCell != null)
			{
				this.doNotSnapToGridInCell.Write(sw, "doNotSnapToGridInCell");
			}
			if (this.selectFldWithFirstOrLastChar != null)
			{
				this.selectFldWithFirstOrLastChar.Write(sw, "selectFldWithFirstOrLastChar");
			}
			if (this.applyBreakingRules != null)
			{
				this.applyBreakingRules.Write(sw, "applyBreakingRules");
			}
			if (this.doNotWrapTextWithPunct != null)
			{
				this.doNotWrapTextWithPunct.Write(sw, "doNotWrapTextWithPunct");
			}
			if (this.doNotUseEastAsianBreakRules != null)
			{
				this.doNotUseEastAsianBreakRules.Write(sw, "doNotUseEastAsianBreakRules");
			}
			if (this.useWord2002TableStyleRules != null)
			{
				this.useWord2002TableStyleRules.Write(sw, "useWord2002TableStyleRules");
			}
			if (this.growAutofit != null)
			{
				this.growAutofit.Write(sw, "growAutofit");
			}
			if (this.useFELayout != null)
			{
				this.useFELayout.Write(sw, "useFELayout");
			}
			if (this.useNormalStyleForList != null)
			{
				this.useNormalStyleForList.Write(sw, "useNormalStyleForList");
			}
			if (this.doNotUseIndentAsNumberingTabStop != null)
			{
				this.doNotUseIndentAsNumberingTabStop.Write(sw, "doNotUseIndentAsNumberingTabStop");
			}
			if (this.useAltKinsokuLineBreakRules != null)
			{
				this.useAltKinsokuLineBreakRules.Write(sw, "useAltKinsokuLineBreakRules");
			}
			if (this.allowSpaceOfSameStyleInTable != null)
			{
				this.allowSpaceOfSameStyleInTable.Write(sw, "allowSpaceOfSameStyleInTable");
			}
			if (this.doNotSuppressIndentation != null)
			{
				this.doNotSuppressIndentation.Write(sw, "doNotSuppressIndentation");
			}
			if (this.doNotAutofitConstrainedTables != null)
			{
				this.doNotAutofitConstrainedTables.Write(sw, "doNotAutofitConstrainedTables");
			}
			if (this.autofitToFirstFixedWidthCell != null)
			{
				this.autofitToFirstFixedWidthCell.Write(sw, "autofitToFirstFixedWidthCell");
			}
			if (this.underlineTabInNumList != null)
			{
				this.underlineTabInNumList.Write(sw, "underlineTabInNumList");
			}
			if (this.displayHangulFixedWidth != null)
			{
				this.displayHangulFixedWidth.Write(sw, "displayHangulFixedWidth");
			}
			if (this.splitPgBreakAndParaMark != null)
			{
				this.splitPgBreakAndParaMark.Write(sw, "splitPgBreakAndParaMark");
			}
			if (this.doNotVertAlignCellWithSp != null)
			{
				this.doNotVertAlignCellWithSp.Write(sw, "doNotVertAlignCellWithSp");
			}
			if (this.doNotBreakConstrainedForcedTable != null)
			{
				this.doNotBreakConstrainedForcedTable.Write(sw, "doNotBreakConstrainedForcedTable");
			}
			if (this.doNotVertAlignInTxbx != null)
			{
				this.doNotVertAlignInTxbx.Write(sw, "doNotVertAlignInTxbx");
			}
			if (this.useAnsiKerningPairs != null)
			{
				this.useAnsiKerningPairs.Write(sw, "useAnsiKerningPairs");
			}
			if (this.cachedColBalance != null)
			{
				this.cachedColBalance.Write(sw, "cachedColBalance");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0003156C File Offset: 0x0002F76C
		public CT_Compat()
		{
			this.useFELayoutField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.adjustLineHeightInTableField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.doNotExpandShiftReturnField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.ulTrailSpaceField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.doNotLeaveBackslashAloneField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.balanceSingleByteDoubleByteWidthField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.spaceForULField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000315CC File Offset: 0x0002F7CC
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x000315D4 File Offset: 0x0002F7D4
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useSingleBorderforContiguousCells
		{
			get
			{
				return this.useSingleBorderforContiguousCellsField;
			}
			set
			{
				this.useSingleBorderforContiguousCellsField = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x000315DD File Offset: 0x0002F7DD
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x000315E5 File Offset: 0x0002F7E5
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff wpJustification
		{
			get
			{
				return this.wpJustificationField;
			}
			set
			{
				this.wpJustificationField = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x000315EE File Offset: 0x0002F7EE
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x000315F6 File Offset: 0x0002F7F6
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noTabHangInd
		{
			get
			{
				return this.noTabHangIndField;
			}
			set
			{
				this.noTabHangIndField = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x000315FF File Offset: 0x0002F7FF
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x00031607 File Offset: 0x0002F807
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noLeading
		{
			get
			{
				return this.noLeadingField;
			}
			set
			{
				this.noLeadingField = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00031610 File Offset: 0x0002F810
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x00031618 File Offset: 0x0002F818
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff spaceForUL
		{
			get
			{
				return this.spaceForULField;
			}
			set
			{
				this.spaceForULField = value;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x00031621 File Offset: 0x0002F821
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x00031629 File Offset: 0x0002F829
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noColumnBalance
		{
			get
			{
				return this.noColumnBalanceField;
			}
			set
			{
				this.noColumnBalanceField = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00031632 File Offset: 0x0002F832
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x0003163A File Offset: 0x0002F83A
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff balanceSingleByteDoubleByteWidth
		{
			get
			{
				return this.balanceSingleByteDoubleByteWidthField;
			}
			set
			{
				this.balanceSingleByteDoubleByteWidthField = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00031643 File Offset: 0x0002F843
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x0003164B File Offset: 0x0002F84B
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noExtraLineSpacing
		{
			get
			{
				return this.noExtraLineSpacingField;
			}
			set
			{
				this.noExtraLineSpacingField = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00031654 File Offset: 0x0002F854
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x0003165C File Offset: 0x0002F85C
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotLeaveBackslashAlone
		{
			get
			{
				return this.doNotLeaveBackslashAloneField;
			}
			set
			{
				this.doNotLeaveBackslashAloneField = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00031665 File Offset: 0x0002F865
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x0003166D File Offset: 0x0002F86D
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ulTrailSpace
		{
			get
			{
				return this.ulTrailSpaceField;
			}
			set
			{
				this.ulTrailSpaceField = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00031676 File Offset: 0x0002F876
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x0003167E File Offset: 0x0002F87E
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotExpandShiftReturn
		{
			get
			{
				return this.doNotExpandShiftReturnField;
			}
			set
			{
				this.doNotExpandShiftReturnField = value;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00031687 File Offset: 0x0002F887
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x0003168F File Offset: 0x0002F88F
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff spacingInWholePoints
		{
			get
			{
				return this.spacingInWholePointsField;
			}
			set
			{
				this.spacingInWholePointsField = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00031698 File Offset: 0x0002F898
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x000316A0 File Offset: 0x0002F8A0
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff lineWrapLikeWord6
		{
			get
			{
				return this.lineWrapLikeWord6Field;
			}
			set
			{
				this.lineWrapLikeWord6Field = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x000316A9 File Offset: 0x0002F8A9
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x000316B1 File Offset: 0x0002F8B1
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printBodyTextBeforeHeader
		{
			get
			{
				return this.printBodyTextBeforeHeaderField;
			}
			set
			{
				this.printBodyTextBeforeHeaderField = value;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x000316BA File Offset: 0x0002F8BA
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x000316C2 File Offset: 0x0002F8C2
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printColBlack
		{
			get
			{
				return this.printColBlackField;
			}
			set
			{
				this.printColBlackField = value;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x000316CB File Offset: 0x0002F8CB
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x000316D3 File Offset: 0x0002F8D3
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff wpSpaceWidth
		{
			get
			{
				return this.wpSpaceWidthField;
			}
			set
			{
				this.wpSpaceWidthField = value;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x000316DC File Offset: 0x0002F8DC
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x000316E4 File Offset: 0x0002F8E4
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff showBreaksInFrames
		{
			get
			{
				return this.showBreaksInFramesField;
			}
			set
			{
				this.showBreaksInFramesField = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x000316ED File Offset: 0x0002F8ED
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x000316F5 File Offset: 0x0002F8F5
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff subFontBySize
		{
			get
			{
				return this.subFontBySizeField;
			}
			set
			{
				this.subFontBySizeField = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x000316FE File Offset: 0x0002F8FE
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x00031706 File Offset: 0x0002F906
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressBottomSpacing
		{
			get
			{
				return this.suppressBottomSpacingField;
			}
			set
			{
				this.suppressBottomSpacingField = value;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0003170F File Offset: 0x0002F90F
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x00031717 File Offset: 0x0002F917
		[global::System.Xml.Serialization.XmlElement(Order = 19)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressTopSpacing
		{
			get
			{
				return this.suppressTopSpacingField;
			}
			set
			{
				this.suppressTopSpacingField = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x00031720 File Offset: 0x0002F920
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00031728 File Offset: 0x0002F928
		[global::System.Xml.Serialization.XmlElement(Order = 20)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressSpacingAtTopOfPage
		{
			get
			{
				return this.suppressSpacingAtTopOfPageField;
			}
			set
			{
				this.suppressSpacingAtTopOfPageField = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00031731 File Offset: 0x0002F931
		// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x00031739 File Offset: 0x0002F939
		[global::System.Xml.Serialization.XmlElement(Order = 21)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressTopSpacingWP
		{
			get
			{
				return this.suppressTopSpacingWPField;
			}
			set
			{
				this.suppressTopSpacingWPField = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00031742 File Offset: 0x0002F942
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x0003174A File Offset: 0x0002F94A
		[global::System.Xml.Serialization.XmlElement(Order = 22)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressSpBfAfterPgBrk
		{
			get
			{
				return this.suppressSpBfAfterPgBrkField;
			}
			set
			{
				this.suppressSpBfAfterPgBrkField = value;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x00031753 File Offset: 0x0002F953
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x0003175B File Offset: 0x0002F95B
		[global::System.Xml.Serialization.XmlElement(Order = 23)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff swapBordersFacingPages
		{
			get
			{
				return this.swapBordersFacingPagesField;
			}
			set
			{
				this.swapBordersFacingPagesField = value;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00031764 File Offset: 0x0002F964
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x0003176C File Offset: 0x0002F96C
		[global::System.Xml.Serialization.XmlElement(Order = 24)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff convMailMergeEsc
		{
			get
			{
				return this.convMailMergeEscField;
			}
			set
			{
				this.convMailMergeEscField = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00031775 File Offset: 0x0002F975
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x0003177D File Offset: 0x0002F97D
		[global::System.Xml.Serialization.XmlElement(Order = 25)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff truncateFontHeightsLikeWP6
		{
			get
			{
				return this.truncateFontHeightsLikeWP6Field;
			}
			set
			{
				this.truncateFontHeightsLikeWP6Field = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x00031786 File Offset: 0x0002F986
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x0003178E File Offset: 0x0002F98E
		[global::System.Xml.Serialization.XmlElement(Order = 26)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff mwSmallCaps
		{
			get
			{
				return this.mwSmallCapsField;
			}
			set
			{
				this.mwSmallCapsField = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x00031797 File Offset: 0x0002F997
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x0003179F File Offset: 0x0002F99F
		[global::System.Xml.Serialization.XmlElement(Order = 27)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff usePrinterMetrics
		{
			get
			{
				return this.usePrinterMetricsField;
			}
			set
			{
				this.usePrinterMetricsField = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x000317A8 File Offset: 0x0002F9A8
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x000317B0 File Offset: 0x0002F9B0
		[global::System.Xml.Serialization.XmlElement(Order = 28)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotSuppressParagraphBorders
		{
			get
			{
				return this.doNotSuppressParagraphBordersField;
			}
			set
			{
				this.doNotSuppressParagraphBordersField = value;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x000317B9 File Offset: 0x0002F9B9
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x000317C1 File Offset: 0x0002F9C1
		[global::System.Xml.Serialization.XmlElement(Order = 29)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff wrapTrailSpaces
		{
			get
			{
				return this.wrapTrailSpacesField;
			}
			set
			{
				this.wrapTrailSpacesField = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x000317CA File Offset: 0x0002F9CA
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x000317D2 File Offset: 0x0002F9D2
		[global::System.Xml.Serialization.XmlElement(Order = 30)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff footnoteLayoutLikeWW8
		{
			get
			{
				return this.footnoteLayoutLikeWW8Field;
			}
			set
			{
				this.footnoteLayoutLikeWW8Field = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x000317DB File Offset: 0x0002F9DB
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x000317E3 File Offset: 0x0002F9E3
		[global::System.Xml.Serialization.XmlElement(Order = 31)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff shapeLayoutLikeWW8
		{
			get
			{
				return this.shapeLayoutLikeWW8Field;
			}
			set
			{
				this.shapeLayoutLikeWW8Field = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x000317EC File Offset: 0x0002F9EC
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x000317F4 File Offset: 0x0002F9F4
		[global::System.Xml.Serialization.XmlElement(Order = 32)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff alignTablesRowByRow
		{
			get
			{
				return this.alignTablesRowByRowField;
			}
			set
			{
				this.alignTablesRowByRowField = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x000317FD File Offset: 0x0002F9FD
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x00031805 File Offset: 0x0002FA05
		[global::System.Xml.Serialization.XmlElement(Order = 33)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff forgetLastTabAlignment
		{
			get
			{
				return this.forgetLastTabAlignmentField;
			}
			set
			{
				this.forgetLastTabAlignmentField = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x0003180E File Offset: 0x0002FA0E
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x00031816 File Offset: 0x0002FA16
		[global::System.Xml.Serialization.XmlElement(Order = 34)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff adjustLineHeightInTable
		{
			get
			{
				return this.adjustLineHeightInTableField;
			}
			set
			{
				this.adjustLineHeightInTableField = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0003181F File Offset: 0x0002FA1F
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x00031827 File Offset: 0x0002FA27
		[global::System.Xml.Serialization.XmlElement(Order = 35)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoSpaceLikeWord95
		{
			get
			{
				return this.autoSpaceLikeWord95Field;
			}
			set
			{
				this.autoSpaceLikeWord95Field = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00031830 File Offset: 0x0002FA30
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00031838 File Offset: 0x0002FA38
		[global::System.Xml.Serialization.XmlElement(Order = 36)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noSpaceRaiseLower
		{
			get
			{
				return this.noSpaceRaiseLowerField;
			}
			set
			{
				this.noSpaceRaiseLowerField = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00031841 File Offset: 0x0002FA41
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00031849 File Offset: 0x0002FA49
		[global::System.Xml.Serialization.XmlElement(Order = 37)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotUseHTMLParagraphAutoSpacing
		{
			get
			{
				return this.doNotUseHTMLParagraphAutoSpacingField;
			}
			set
			{
				this.doNotUseHTMLParagraphAutoSpacingField = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00031852 File Offset: 0x0002FA52
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x0003185A File Offset: 0x0002FA5A
		[global::System.Xml.Serialization.XmlElement(Order = 38)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff layoutRawTableWidth
		{
			get
			{
				return this.layoutRawTableWidthField;
			}
			set
			{
				this.layoutRawTableWidthField = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00031863 File Offset: 0x0002FA63
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x0003186B File Offset: 0x0002FA6B
		[global::System.Xml.Serialization.XmlElement(Order = 39)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff layoutTableRowsApart
		{
			get
			{
				return this.layoutTableRowsApartField;
			}
			set
			{
				this.layoutTableRowsApartField = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00031874 File Offset: 0x0002FA74
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x0003187C File Offset: 0x0002FA7C
		[global::System.Xml.Serialization.XmlElement(Order = 40)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useWord97LineBreakRules
		{
			get
			{
				return this.useWord97LineBreakRulesField;
			}
			set
			{
				this.useWord97LineBreakRulesField = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00031885 File Offset: 0x0002FA85
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x0003188D File Offset: 0x0002FA8D
		[global::System.Xml.Serialization.XmlElement(Order = 41)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotBreakWrappedTables
		{
			get
			{
				return this.doNotBreakWrappedTablesField;
			}
			set
			{
				this.doNotBreakWrappedTablesField = value;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x00031896 File Offset: 0x0002FA96
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x0003189E File Offset: 0x0002FA9E
		[global::System.Xml.Serialization.XmlElement(Order = 42)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotSnapToGridInCell
		{
			get
			{
				return this.doNotSnapToGridInCellField;
			}
			set
			{
				this.doNotSnapToGridInCellField = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x000318A7 File Offset: 0x0002FAA7
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x000318AF File Offset: 0x0002FAAF
		[global::System.Xml.Serialization.XmlElement(Order = 43)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff selectFldWithFirstOrLastChar
		{
			get
			{
				return this.selectFldWithFirstOrLastCharField;
			}
			set
			{
				this.selectFldWithFirstOrLastCharField = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000318B8 File Offset: 0x0002FAB8
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x000318C0 File Offset: 0x0002FAC0
		[global::System.Xml.Serialization.XmlElement(Order = 44)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff applyBreakingRules
		{
			get
			{
				return this.applyBreakingRulesField;
			}
			set
			{
				this.applyBreakingRulesField = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x000318C9 File Offset: 0x0002FAC9
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x000318D1 File Offset: 0x0002FAD1
		[global::System.Xml.Serialization.XmlElement(Order = 45)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotWrapTextWithPunct
		{
			get
			{
				return this.doNotWrapTextWithPunctField;
			}
			set
			{
				this.doNotWrapTextWithPunctField = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x000318DA File Offset: 0x0002FADA
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x000318E2 File Offset: 0x0002FAE2
		[global::System.Xml.Serialization.XmlElement(Order = 46)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotUseEastAsianBreakRules
		{
			get
			{
				return this.doNotUseEastAsianBreakRulesField;
			}
			set
			{
				this.doNotUseEastAsianBreakRulesField = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x000318EB File Offset: 0x0002FAEB
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x000318F3 File Offset: 0x0002FAF3
		[global::System.Xml.Serialization.XmlElement(Order = 47)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useWord2002TableStyleRules
		{
			get
			{
				return this.useWord2002TableStyleRulesField;
			}
			set
			{
				this.useWord2002TableStyleRulesField = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x000318FC File Offset: 0x0002FAFC
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x00031904 File Offset: 0x0002FB04
		[global::System.Xml.Serialization.XmlElement(Order = 48)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff growAutofit
		{
			get
			{
				return this.growAutofitField;
			}
			set
			{
				this.growAutofitField = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x0003190D File Offset: 0x0002FB0D
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x00031915 File Offset: 0x0002FB15
		[global::System.Xml.Serialization.XmlElement(Order = 49)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useFELayout
		{
			get
			{
				return this.useFELayoutField;
			}
			set
			{
				this.useFELayoutField = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0003191E File Offset: 0x0002FB1E
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00031926 File Offset: 0x0002FB26
		[global::System.Xml.Serialization.XmlElement(Order = 50)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useNormalStyleForList
		{
			get
			{
				return this.useNormalStyleForListField;
			}
			set
			{
				this.useNormalStyleForListField = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x0003192F File Offset: 0x0002FB2F
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x00031937 File Offset: 0x0002FB37
		[global::System.Xml.Serialization.XmlElement(Order = 51)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotUseIndentAsNumberingTabStop
		{
			get
			{
				return this.doNotUseIndentAsNumberingTabStopField;
			}
			set
			{
				this.doNotUseIndentAsNumberingTabStopField = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00031940 File Offset: 0x0002FB40
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00031948 File Offset: 0x0002FB48
		[global::System.Xml.Serialization.XmlElement(Order = 52)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useAltKinsokuLineBreakRules
		{
			get
			{
				return this.useAltKinsokuLineBreakRulesField;
			}
			set
			{
				this.useAltKinsokuLineBreakRulesField = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00031951 File Offset: 0x0002FB51
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00031959 File Offset: 0x0002FB59
		[global::System.Xml.Serialization.XmlElement(Order = 53)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff allowSpaceOfSameStyleInTable
		{
			get
			{
				return this.allowSpaceOfSameStyleInTableField;
			}
			set
			{
				this.allowSpaceOfSameStyleInTableField = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00031962 File Offset: 0x0002FB62
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x0003196A File Offset: 0x0002FB6A
		[global::System.Xml.Serialization.XmlElement(Order = 54)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotSuppressIndentation
		{
			get
			{
				return this.doNotSuppressIndentationField;
			}
			set
			{
				this.doNotSuppressIndentationField = value;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x00031973 File Offset: 0x0002FB73
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x0003197B File Offset: 0x0002FB7B
		[global::System.Xml.Serialization.XmlElement(Order = 55)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotAutofitConstrainedTables
		{
			get
			{
				return this.doNotAutofitConstrainedTablesField;
			}
			set
			{
				this.doNotAutofitConstrainedTablesField = value;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00031984 File Offset: 0x0002FB84
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x0003198C File Offset: 0x0002FB8C
		[global::System.Xml.Serialization.XmlElement(Order = 56)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autofitToFirstFixedWidthCell
		{
			get
			{
				return this.autofitToFirstFixedWidthCellField;
			}
			set
			{
				this.autofitToFirstFixedWidthCellField = value;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x00031995 File Offset: 0x0002FB95
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x0003199D File Offset: 0x0002FB9D
		[global::System.Xml.Serialization.XmlElement(Order = 57)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff underlineTabInNumList
		{
			get
			{
				return this.underlineTabInNumListField;
			}
			set
			{
				this.underlineTabInNumListField = value;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x000319A6 File Offset: 0x0002FBA6
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x000319AE File Offset: 0x0002FBAE
		[global::System.Xml.Serialization.XmlElement(Order = 58)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff displayHangulFixedWidth
		{
			get
			{
				return this.displayHangulFixedWidthField;
			}
			set
			{
				this.displayHangulFixedWidthField = value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x000319B7 File Offset: 0x0002FBB7
		// (set) Token: 0x06000F10 RID: 3856 RVA: 0x000319BF File Offset: 0x0002FBBF
		[global::System.Xml.Serialization.XmlElement(Order = 59)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff splitPgBreakAndParaMark
		{
			get
			{
				return this.splitPgBreakAndParaMarkField;
			}
			set
			{
				this.splitPgBreakAndParaMarkField = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x000319C8 File Offset: 0x0002FBC8
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x000319D0 File Offset: 0x0002FBD0
		[global::System.Xml.Serialization.XmlElement(Order = 60)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotVertAlignCellWithSp
		{
			get
			{
				return this.doNotVertAlignCellWithSpField;
			}
			set
			{
				this.doNotVertAlignCellWithSpField = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x000319D9 File Offset: 0x0002FBD9
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x000319E1 File Offset: 0x0002FBE1
		[global::System.Xml.Serialization.XmlElement(Order = 61)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotBreakConstrainedForcedTable
		{
			get
			{
				return this.doNotBreakConstrainedForcedTableField;
			}
			set
			{
				this.doNotBreakConstrainedForcedTableField = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x000319EA File Offset: 0x0002FBEA
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x000319F2 File Offset: 0x0002FBF2
		[global::System.Xml.Serialization.XmlElement(Order = 62)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotVertAlignInTxbx
		{
			get
			{
				return this.doNotVertAlignInTxbxField;
			}
			set
			{
				this.doNotVertAlignInTxbxField = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x000319FB File Offset: 0x0002FBFB
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00031A03 File Offset: 0x0002FC03
		[global::System.Xml.Serialization.XmlElement(Order = 63)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useAnsiKerningPairs
		{
			get
			{
				return this.useAnsiKerningPairsField;
			}
			set
			{
				this.useAnsiKerningPairsField = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x00031A0C File Offset: 0x0002FC0C
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00031A14 File Offset: 0x0002FC14
		[global::System.Xml.Serialization.XmlElement(Order = 64)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff cachedColBalance
		{
			get
			{
				return this.cachedColBalanceField;
			}
			set
			{
				this.cachedColBalanceField = value;
			}
		}

		// Token: 0x04000C28 RID: 3112
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useSingleBorderforContiguousCellsField;

		// Token: 0x04000C29 RID: 3113
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff wpJustificationField;

		// Token: 0x04000C2A RID: 3114
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noTabHangIndField;

		// Token: 0x04000C2B RID: 3115
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noLeadingField;

		// Token: 0x04000C2C RID: 3116
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff spaceForULField;

		// Token: 0x04000C2D RID: 3117
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noColumnBalanceField;

		// Token: 0x04000C2E RID: 3118
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff balanceSingleByteDoubleByteWidthField;

		// Token: 0x04000C2F RID: 3119
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noExtraLineSpacingField;

		// Token: 0x04000C30 RID: 3120
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotLeaveBackslashAloneField;

		// Token: 0x04000C31 RID: 3121
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ulTrailSpaceField;

		// Token: 0x04000C32 RID: 3122
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotExpandShiftReturnField;

		// Token: 0x04000C33 RID: 3123
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff spacingInWholePointsField;

		// Token: 0x04000C34 RID: 3124
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff lineWrapLikeWord6Field;

		// Token: 0x04000C35 RID: 3125
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printBodyTextBeforeHeaderField;

		// Token: 0x04000C36 RID: 3126
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printColBlackField;

		// Token: 0x04000C37 RID: 3127
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff wpSpaceWidthField;

		// Token: 0x04000C38 RID: 3128
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff showBreaksInFramesField;

		// Token: 0x04000C39 RID: 3129
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff subFontBySizeField;

		// Token: 0x04000C3A RID: 3130
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressBottomSpacingField;

		// Token: 0x04000C3B RID: 3131
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressTopSpacingField;

		// Token: 0x04000C3C RID: 3132
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressSpacingAtTopOfPageField;

		// Token: 0x04000C3D RID: 3133
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressTopSpacingWPField;

		// Token: 0x04000C3E RID: 3134
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressSpBfAfterPgBrkField;

		// Token: 0x04000C3F RID: 3135
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff swapBordersFacingPagesField;

		// Token: 0x04000C40 RID: 3136
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff convMailMergeEscField;

		// Token: 0x04000C41 RID: 3137
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff truncateFontHeightsLikeWP6Field;

		// Token: 0x04000C42 RID: 3138
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff mwSmallCapsField;

		// Token: 0x04000C43 RID: 3139
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff usePrinterMetricsField;

		// Token: 0x04000C44 RID: 3140
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotSuppressParagraphBordersField;

		// Token: 0x04000C45 RID: 3141
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff wrapTrailSpacesField;

		// Token: 0x04000C46 RID: 3142
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff footnoteLayoutLikeWW8Field;

		// Token: 0x04000C47 RID: 3143
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff shapeLayoutLikeWW8Field;

		// Token: 0x04000C48 RID: 3144
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff alignTablesRowByRowField;

		// Token: 0x04000C49 RID: 3145
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff forgetLastTabAlignmentField;

		// Token: 0x04000C4A RID: 3146
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff adjustLineHeightInTableField;

		// Token: 0x04000C4B RID: 3147
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoSpaceLikeWord95Field;

		// Token: 0x04000C4C RID: 3148
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noSpaceRaiseLowerField;

		// Token: 0x04000C4D RID: 3149
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotUseHTMLParagraphAutoSpacingField;

		// Token: 0x04000C4E RID: 3150
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff layoutRawTableWidthField;

		// Token: 0x04000C4F RID: 3151
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff layoutTableRowsApartField;

		// Token: 0x04000C50 RID: 3152
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useWord97LineBreakRulesField;

		// Token: 0x04000C51 RID: 3153
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotBreakWrappedTablesField;

		// Token: 0x04000C52 RID: 3154
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotSnapToGridInCellField;

		// Token: 0x04000C53 RID: 3155
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff selectFldWithFirstOrLastCharField;

		// Token: 0x04000C54 RID: 3156
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff applyBreakingRulesField;

		// Token: 0x04000C55 RID: 3157
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotWrapTextWithPunctField;

		// Token: 0x04000C56 RID: 3158
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotUseEastAsianBreakRulesField;

		// Token: 0x04000C57 RID: 3159
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useWord2002TableStyleRulesField;

		// Token: 0x04000C58 RID: 3160
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff growAutofitField;

		// Token: 0x04000C59 RID: 3161
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useFELayoutField;

		// Token: 0x04000C5A RID: 3162
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useNormalStyleForListField;

		// Token: 0x04000C5B RID: 3163
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotUseIndentAsNumberingTabStopField;

		// Token: 0x04000C5C RID: 3164
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useAltKinsokuLineBreakRulesField;

		// Token: 0x04000C5D RID: 3165
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff allowSpaceOfSameStyleInTableField;

		// Token: 0x04000C5E RID: 3166
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotSuppressIndentationField;

		// Token: 0x04000C5F RID: 3167
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotAutofitConstrainedTablesField;

		// Token: 0x04000C60 RID: 3168
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autofitToFirstFixedWidthCellField;

		// Token: 0x04000C61 RID: 3169
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff underlineTabInNumListField;

		// Token: 0x04000C62 RID: 3170
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff displayHangulFixedWidthField;

		// Token: 0x04000C63 RID: 3171
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff splitPgBreakAndParaMarkField;

		// Token: 0x04000C64 RID: 3172
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotVertAlignCellWithSpField;

		// Token: 0x04000C65 RID: 3173
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotBreakConstrainedForcedTableField;

		// Token: 0x04000C66 RID: 3174
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotVertAlignInTxbxField;

		// Token: 0x04000C67 RID: 3175
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useAnsiKerningPairsField;

		// Token: 0x04000C68 RID: 3176
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff cachedColBalanceField;
	}
}
