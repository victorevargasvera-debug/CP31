using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Shared;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000172 RID: 370
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("settings", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Settings
	{
		// Token: 0x06000CBE RID: 3262 RVA: 0x0002BE78 File Offset: 0x0002A078
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Settings Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Settings ct_Settings = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Settings();
			ct_Settings.activeWritingStyle = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_WritingStyle>();
			ct_Settings.docVars = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocVar>();
			ct_Settings.attachedSchema = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String>();
			ct_Settings.smartTagType = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagType>();
			ct_Settings.schemaLibrary = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Schema>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "writeProtection")
				{
					ct_Settings.writeProtection = global::NPOI.OpenXmlFormats.Wordprocessing.CT_WriteProtection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "view")
				{
					ct_Settings.view = global::NPOI.OpenXmlFormats.Wordprocessing.CT_View.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "zoom")
				{
					ct_Settings.zoom = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Zoom.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "removePersonalInformation")
				{
					ct_Settings.removePersonalInformation = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "removeDateAndTime")
				{
					ct_Settings.removeDateAndTime = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotDisplayPageBoundaries")
				{
					ct_Settings.doNotDisplayPageBoundaries = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "displayBackgroundShape")
				{
					ct_Settings.displayBackgroundShape = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "printPostScriptOverText")
				{
					ct_Settings.printPostScriptOverText = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "printFractionalCharacterWidth")
				{
					ct_Settings.printFractionalCharacterWidth = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "printFormsData")
				{
					ct_Settings.printFormsData = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "embedTrueTypeFonts")
				{
					ct_Settings.embedTrueTypeFonts = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "embedSystemFonts")
				{
					ct_Settings.embedSystemFonts = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "saveSubsetFonts")
				{
					ct_Settings.saveSubsetFonts = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "saveFormsData")
				{
					ct_Settings.saveFormsData = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mirrorMargins")
				{
					ct_Settings.mirrorMargins = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "alignBordersAndEdges")
				{
					ct_Settings.alignBordersAndEdges = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bordersDoNotSurroundHeader")
				{
					ct_Settings.bordersDoNotSurroundHeader = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bordersDoNotSurroundFooter")
				{
					ct_Settings.bordersDoNotSurroundFooter = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gutterAtTop")
				{
					ct_Settings.gutterAtTop = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hideSpellingErrors")
				{
					ct_Settings.hideSpellingErrors = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hideGrammaticalErrors")
				{
					ct_Settings.hideGrammaticalErrors = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "proofState")
				{
					ct_Settings.proofState = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Proof.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "formsDesign")
				{
					ct_Settings.formsDesign = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "attachedTemplate")
				{
					ct_Settings.attachedTemplate = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "linkStyles")
				{
					ct_Settings.linkStyles = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "stylePaneFormatFilter")
				{
					ct_Settings.stylePaneFormatFilter = global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "stylePaneSortMethod")
				{
					ct_Settings.stylePaneSortMethod = global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "documentType")
				{
					ct_Settings.documentType = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mailMerge")
				{
					ct_Settings.mailMerge = global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMerge.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "revisionView")
				{
					ct_Settings.revisionView = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangesView.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "trackRevisions")
				{
					ct_Settings.trackRevisions = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotTrackMoves")
				{
					ct_Settings.doNotTrackMoves = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotTrackFormatting")
				{
					ct_Settings.doNotTrackFormatting = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "documentProtection")
				{
					ct_Settings.documentProtection = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocProtect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoFormatOverride")
				{
					ct_Settings.autoFormatOverride = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "styleLockTheme")
				{
					ct_Settings.styleLockTheme = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "styleLockQFSet")
				{
					ct_Settings.styleLockQFSet = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "defaultTabStop")
				{
					ct_Settings.defaultTabStop = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoHyphenation")
				{
					ct_Settings.autoHyphenation = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "consecutiveHyphenLimit")
				{
					ct_Settings.consecutiveHyphenLimit = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hyphenationZone")
				{
					ct_Settings.hyphenationZone = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotHyphenateCaps")
				{
					ct_Settings.doNotHyphenateCaps = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showEnvelope")
				{
					ct_Settings.showEnvelope = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "summaryLength")
				{
					ct_Settings.summaryLength = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "clickAndTypeStyle")
				{
					ct_Settings.clickAndTypeStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "defaultTableStyle")
				{
					ct_Settings.defaultTableStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "evenAndOddHeaders")
				{
					ct_Settings.evenAndOddHeaders = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bookFoldRevPrinting")
				{
					ct_Settings.bookFoldRevPrinting = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bookFoldPrinting")
				{
					ct_Settings.bookFoldPrinting = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bookFoldPrintingSheets")
				{
					ct_Settings.bookFoldPrintingSheets = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "drawingGridHorizontalSpacing")
				{
					ct_Settings.drawingGridHorizontalSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "drawingGridVerticalSpacing")
				{
					ct_Settings.drawingGridVerticalSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "displayHorizontalDrawingGridEvery")
				{
					ct_Settings.displayHorizontalDrawingGridEvery = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "displayVerticalDrawingGridEvery")
				{
					ct_Settings.displayVerticalDrawingGridEvery = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotUseMarginsForDrawingGridOrigin")
				{
					ct_Settings.doNotUseMarginsForDrawingGridOrigin = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "drawingGridHorizontalOrigin")
				{
					ct_Settings.drawingGridHorizontalOrigin = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "drawingGridVerticalOrigin")
				{
					ct_Settings.drawingGridVerticalOrigin = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotShadeFormData")
				{
					ct_Settings.doNotShadeFormData = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noPunctuationKerning")
				{
					ct_Settings.noPunctuationKerning = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "characterSpacingControl")
				{
					ct_Settings.characterSpacingControl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_CharacterSpacing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "printTwoOnOne")
				{
					ct_Settings.printTwoOnOne = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "strictFirstAndLastChars")
				{
					ct_Settings.strictFirstAndLastChars = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noLineBreaksAfter")
				{
					ct_Settings.noLineBreaksAfter = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Kinsoku.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noLineBreaksBefore")
				{
					ct_Settings.noLineBreaksBefore = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Kinsoku.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "savePreviewPicture")
				{
					ct_Settings.savePreviewPicture = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotValidateAgainstSchema")
				{
					ct_Settings.doNotValidateAgainstSchema = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "saveInvalidXml")
				{
					ct_Settings.saveInvalidXml = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ignoreMixedContent")
				{
					ct_Settings.ignoreMixedContent = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "alwaysShowPlaceholderText")
				{
					ct_Settings.alwaysShowPlaceholderText = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotDemarcateInvalidXml")
				{
					ct_Settings.doNotDemarcateInvalidXml = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "saveXmlDataOnly")
				{
					ct_Settings.saveXmlDataOnly = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "useXSLTWhenSaving")
				{
					ct_Settings.useXSLTWhenSaving = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "saveThroughXslt")
				{
					ct_Settings.saveThroughXslt = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SaveThroughXslt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showXMLTags")
				{
					ct_Settings.showXMLTags = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "alwaysMergeEmptyNamespace")
				{
					ct_Settings.alwaysMergeEmptyNamespace = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "updateFields")
				{
					ct_Settings.updateFields = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "footnotePr")
				{
					ct_Settings.footnotePr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnDocProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "endnotePr")
				{
					ct_Settings.endnotePr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnDocProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "compat")
				{
					ct_Settings.compat = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Compat.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rsids")
				{
					ct_Settings.rsids = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocRsids.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mathPr")
				{
					ct_Settings.mathPr = global::NPOI.OpenXmlFormats.Shared.CT_MathPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "uiCompat97To2003")
				{
					ct_Settings.uiCompat97To2003 = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "themeFontLang")
				{
					ct_Settings.themeFontLang = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "clrSchemeMapping")
				{
					ct_Settings.clrSchemeMapping = global::NPOI.OpenXmlFormats.Wordprocessing.CT_ColorSchemeMapping.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotIncludeSubdocsInStats")
				{
					ct_Settings.doNotIncludeSubdocsInStats = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotAutoCompressPictures")
				{
					ct_Settings.doNotAutoCompressPictures = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "forceUpgrade")
				{
					ct_Settings.forceUpgrade = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty();
				}
				else if (xmlNode.LocalName == "captions")
				{
					ct_Settings.captions = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Captions.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "readModeInkLockDown")
				{
					ct_Settings.readModeInkLockDown = global::NPOI.OpenXmlFormats.Wordprocessing.CT_ReadingModeInkLockDown.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotEmbedSmartTags")
				{
					ct_Settings.doNotEmbedSmartTags = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "decimalSymbol")
				{
					ct_Settings.decimalSymbol = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "listSeparator")
				{
					ct_Settings.listSeparator = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "activeWritingStyle")
				{
					ct_Settings.activeWritingStyle.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_WritingStyle.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "docVars")
				{
					ct_Settings.docVars.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocVar.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "attachedSchema")
				{
					ct_Settings.attachedSchema.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "smartTagType")
				{
					ct_Settings.smartTagType.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagType.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "schemaLibrary")
				{
					ct_Settings.schemaLibrary.Add(global::NPOI.OpenXmlFormats.CT_Schema.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Settings;
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0002CCCC File Offset: 0x0002AECC
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<w:settings xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" xmlns:m=\"http://schemas.openxmlformats.org/officeDocument/2006/math\" ");
			sw.Write("xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:w10=\"urn:schemas-microsoft-com:office:word\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" xmlns:sl=\"http://schemas.openxmlformats.org/schemaLibrary/2006/main\">");
			if (this.writeProtection != null)
			{
				this.writeProtection.Write(sw, "writeProtection");
			}
			if (this.view != null)
			{
				this.view.Write(sw, "view");
			}
			if (this.zoom != null)
			{
				this.zoom.Write(sw, "zoom");
			}
			if (this.removePersonalInformation != null)
			{
				this.removePersonalInformation.Write(sw, "removePersonalInformation");
			}
			if (this.removeDateAndTime != null)
			{
				this.removeDateAndTime.Write(sw, "removeDateAndTime");
			}
			if (this.doNotDisplayPageBoundaries != null)
			{
				this.doNotDisplayPageBoundaries.Write(sw, "doNotDisplayPageBoundaries");
			}
			if (this.displayBackgroundShape != null)
			{
				this.displayBackgroundShape.Write(sw, "displayBackgroundShape");
			}
			if (this.printPostScriptOverText != null)
			{
				this.printPostScriptOverText.Write(sw, "printPostScriptOverText");
			}
			if (this.printFractionalCharacterWidth != null)
			{
				this.printFractionalCharacterWidth.Write(sw, "printFractionalCharacterWidth");
			}
			if (this.printFormsData != null)
			{
				this.printFormsData.Write(sw, "printFormsData");
			}
			if (this.embedTrueTypeFonts != null)
			{
				this.embedTrueTypeFonts.Write(sw, "embedTrueTypeFonts");
			}
			if (this.embedSystemFonts != null)
			{
				this.embedSystemFonts.Write(sw, "embedSystemFonts");
			}
			if (this.saveSubsetFonts != null)
			{
				this.saveSubsetFonts.Write(sw, "saveSubsetFonts");
			}
			if (this.saveFormsData != null)
			{
				this.saveFormsData.Write(sw, "saveFormsData");
			}
			if (this.mirrorMargins != null)
			{
				this.mirrorMargins.Write(sw, "mirrorMargins");
			}
			if (this.alignBordersAndEdges != null)
			{
				this.alignBordersAndEdges.Write(sw, "alignBordersAndEdges");
			}
			if (this.bordersDoNotSurroundHeader != null)
			{
				this.bordersDoNotSurroundHeader.Write(sw, "bordersDoNotSurroundHeader");
			}
			if (this.bordersDoNotSurroundFooter != null)
			{
				this.bordersDoNotSurroundFooter.Write(sw, "bordersDoNotSurroundFooter");
			}
			if (this.gutterAtTop != null)
			{
				this.gutterAtTop.Write(sw, "gutterAtTop");
			}
			if (this.hideSpellingErrors != null)
			{
				this.hideSpellingErrors.Write(sw, "hideSpellingErrors");
			}
			if (this.hideGrammaticalErrors != null)
			{
				this.hideGrammaticalErrors.Write(sw, "hideGrammaticalErrors");
			}
			if (this.proofState != null)
			{
				this.proofState.Write(sw, "proofState");
			}
			if (this.formsDesign != null)
			{
				this.formsDesign.Write(sw, "formsDesign");
			}
			if (this.attachedTemplate != null)
			{
				this.attachedTemplate.Write(sw, "attachedTemplate");
			}
			if (this.linkStyles != null)
			{
				this.linkStyles.Write(sw, "linkStyles");
			}
			if (this.stylePaneFormatFilter != null)
			{
				this.stylePaneFormatFilter.Write(sw, "stylePaneFormatFilter");
			}
			if (this.stylePaneSortMethod != null)
			{
				this.stylePaneSortMethod.Write(sw, "stylePaneSortMethod");
			}
			if (this.documentType != null)
			{
				this.documentType.Write(sw, "documentType");
			}
			if (this.mailMerge != null)
			{
				this.mailMerge.Write(sw, "mailMerge");
			}
			if (this.revisionView != null)
			{
				this.revisionView.Write(sw, "revisionView");
			}
			if (this.trackRevisions != null)
			{
				this.trackRevisions.Write(sw, "trackRevisions");
			}
			if (this.doNotTrackMoves != null)
			{
				this.doNotTrackMoves.Write(sw, "doNotTrackMoves");
			}
			if (this.doNotTrackFormatting != null)
			{
				this.doNotTrackFormatting.Write(sw, "doNotTrackFormatting");
			}
			if (this.documentProtection != null)
			{
				this.documentProtection.Write(sw, "documentProtection");
			}
			if (this.autoFormatOverride != null)
			{
				this.autoFormatOverride.Write(sw, "autoFormatOverride");
			}
			if (this.styleLockTheme != null)
			{
				this.styleLockTheme.Write(sw, "styleLockTheme");
			}
			if (this.styleLockQFSet != null)
			{
				this.styleLockQFSet.Write(sw, "styleLockQFSet");
			}
			if (this.defaultTabStop != null)
			{
				this.defaultTabStop.Write(sw, "defaultTabStop");
			}
			if (this.autoHyphenation != null)
			{
				this.autoHyphenation.Write(sw, "autoHyphenation");
			}
			if (this.consecutiveHyphenLimit != null)
			{
				this.consecutiveHyphenLimit.Write(sw, "consecutiveHyphenLimit");
			}
			if (this.hyphenationZone != null)
			{
				this.hyphenationZone.Write(sw, "hyphenationZone");
			}
			if (this.doNotHyphenateCaps != null)
			{
				this.doNotHyphenateCaps.Write(sw, "doNotHyphenateCaps");
			}
			if (this.showEnvelope != null)
			{
				this.showEnvelope.Write(sw, "showEnvelope");
			}
			if (this.summaryLength != null)
			{
				this.summaryLength.Write(sw, "summaryLength");
			}
			if (this.clickAndTypeStyle != null)
			{
				this.clickAndTypeStyle.Write(sw, "clickAndTypeStyle");
			}
			if (this.defaultTableStyle != null)
			{
				this.defaultTableStyle.Write(sw, "defaultTableStyle");
			}
			if (this.evenAndOddHeaders != null)
			{
				this.evenAndOddHeaders.Write(sw, "evenAndOddHeaders");
			}
			if (this.bookFoldRevPrinting != null)
			{
				this.bookFoldRevPrinting.Write(sw, "bookFoldRevPrinting");
			}
			if (this.bookFoldPrinting != null)
			{
				this.bookFoldPrinting.Write(sw, "bookFoldPrinting");
			}
			if (this.bookFoldPrintingSheets != null)
			{
				this.bookFoldPrintingSheets.Write(sw, "bookFoldPrintingSheets");
			}
			if (this.drawingGridHorizontalSpacing != null)
			{
				this.drawingGridHorizontalSpacing.Write(sw, "drawingGridHorizontalSpacing");
			}
			if (this.drawingGridVerticalSpacing != null)
			{
				this.drawingGridVerticalSpacing.Write(sw, "drawingGridVerticalSpacing");
			}
			if (this.displayHorizontalDrawingGridEvery != null)
			{
				this.displayHorizontalDrawingGridEvery.Write(sw, "displayHorizontalDrawingGridEvery");
			}
			if (this.displayVerticalDrawingGridEvery != null)
			{
				this.displayVerticalDrawingGridEvery.Write(sw, "displayVerticalDrawingGridEvery");
			}
			if (this.doNotUseMarginsForDrawingGridOrigin != null)
			{
				this.doNotUseMarginsForDrawingGridOrigin.Write(sw, "doNotUseMarginsForDrawingGridOrigin");
			}
			if (this.drawingGridHorizontalOrigin != null)
			{
				this.drawingGridHorizontalOrigin.Write(sw, "drawingGridHorizontalOrigin");
			}
			if (this.drawingGridVerticalOrigin != null)
			{
				this.drawingGridVerticalOrigin.Write(sw, "drawingGridVerticalOrigin");
			}
			if (this.doNotShadeFormData != null)
			{
				this.doNotShadeFormData.Write(sw, "doNotShadeFormData");
			}
			if (this.noPunctuationKerning != null)
			{
				this.noPunctuationKerning.Write(sw, "noPunctuationKerning");
			}
			if (this.characterSpacingControl != null)
			{
				this.characterSpacingControl.Write(sw, "characterSpacingControl");
			}
			if (this.printTwoOnOne != null)
			{
				this.printTwoOnOne.Write(sw, "printTwoOnOne");
			}
			if (this.strictFirstAndLastChars != null)
			{
				this.strictFirstAndLastChars.Write(sw, "strictFirstAndLastChars");
			}
			if (this.noLineBreaksAfter != null)
			{
				this.noLineBreaksAfter.Write(sw, "noLineBreaksAfter");
			}
			if (this.noLineBreaksBefore != null)
			{
				this.noLineBreaksBefore.Write(sw, "noLineBreaksBefore");
			}
			if (this.savePreviewPicture != null)
			{
				this.savePreviewPicture.Write(sw, "savePreviewPicture");
			}
			if (this.doNotValidateAgainstSchema != null)
			{
				this.doNotValidateAgainstSchema.Write(sw, "doNotValidateAgainstSchema");
			}
			if (this.saveInvalidXml != null)
			{
				this.saveInvalidXml.Write(sw, "saveInvalidXml");
			}
			if (this.ignoreMixedContent != null)
			{
				this.ignoreMixedContent.Write(sw, "ignoreMixedContent");
			}
			if (this.alwaysShowPlaceholderText != null)
			{
				this.alwaysShowPlaceholderText.Write(sw, "alwaysShowPlaceholderText");
			}
			if (this.doNotDemarcateInvalidXml != null)
			{
				this.doNotDemarcateInvalidXml.Write(sw, "doNotDemarcateInvalidXml");
			}
			if (this.saveXmlDataOnly != null)
			{
				this.saveXmlDataOnly.Write(sw, "saveXmlDataOnly");
			}
			if (this.useXSLTWhenSaving != null)
			{
				this.useXSLTWhenSaving.Write(sw, "useXSLTWhenSaving");
			}
			if (this.saveThroughXslt != null)
			{
				this.saveThroughXslt.Write(sw, "saveThroughXslt");
			}
			if (this.showXMLTags != null)
			{
				this.showXMLTags.Write(sw, "showXMLTags");
			}
			if (this.alwaysMergeEmptyNamespace != null)
			{
				this.alwaysMergeEmptyNamespace.Write(sw, "alwaysMergeEmptyNamespace");
			}
			if (this.updateFields != null)
			{
				this.updateFields.Write(sw, "updateFields");
			}
			if (this.footnotePr != null)
			{
				this.footnotePr.Write(sw, "footnotePr");
			}
			if (this.endnotePr != null)
			{
				this.endnotePr.Write(sw, "endnotePr");
			}
			if (this.compat != null)
			{
				this.compat.Write(sw, "compat");
			}
			if (this.rsids != null)
			{
				this.rsids.Write(sw, "rsids");
			}
			if (this.mathPr != null)
			{
				this.mathPr.Write(sw, "mathPr");
			}
			if (this.uiCompat97To2003 != null)
			{
				this.uiCompat97To2003.Write(sw, "uiCompat97To2003");
			}
			if (this.themeFontLang != null)
			{
				this.themeFontLang.Write(sw, "themeFontLang");
			}
			if (this.clrSchemeMapping != null)
			{
				this.clrSchemeMapping.Write(sw, "clrSchemeMapping");
			}
			if (this.doNotIncludeSubdocsInStats != null)
			{
				this.doNotIncludeSubdocsInStats.Write(sw, "doNotIncludeSubdocsInStats");
			}
			if (this.doNotAutoCompressPictures != null)
			{
				this.doNotAutoCompressPictures.Write(sw, "doNotAutoCompressPictures");
			}
			if (this.forceUpgrade != null)
			{
				sw.Write("<w:forceUpgrade/>");
			}
			if (this.captions != null)
			{
				this.captions.Write(sw, "captions");
			}
			if (this.readModeInkLockDown != null)
			{
				this.readModeInkLockDown.Write(sw, "readModeInkLockDown");
			}
			if (this.doNotEmbedSmartTags != null)
			{
				this.doNotEmbedSmartTags.Write(sw, "doNotEmbedSmartTags");
			}
			if (this.decimalSymbol != null)
			{
				this.decimalSymbol.Write(sw, "decimalSymbol");
			}
			if (this.listSeparator != null)
			{
				this.listSeparator.Write(sw, "listSeparator");
			}
			if (this.activeWritingStyle != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_WritingStyle ct_WritingStyle in this.activeWritingStyle)
				{
					ct_WritingStyle.Write(sw, "activeWritingStyle");
				}
			}
			if (this.docVars != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocVar ct_DocVar in this.docVars)
				{
					ct_DocVar.Write(sw, "docVars");
				}
			}
			if (this.attachedSchema != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_String ct_String in this.attachedSchema)
				{
					ct_String.Write(sw, "attachedSchema");
				}
			}
			if (this.smartTagType != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagType ct_SmartTagType in this.smartTagType)
				{
					ct_SmartTagType.Write(sw, "smartTagType");
				}
			}
			if (this.schemaLibrary != null)
			{
				foreach (global::NPOI.OpenXmlFormats.CT_Schema ct_Schema in this.schemaLibrary)
				{
					ct_Schema.Write(sw, "schemaLibrary");
				}
			}
			sw.Write("</w:settings>");
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0002D784 File Offset: 0x0002B984
		public CT_Settings()
		{
			this.listSeparatorField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
			this.listSeparator.val = ",";
			this.decimalSymbolField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
			this.decimalSymbol.val = ".";
			this.shapeDefaultsField = new global::System.Xml.XmlElement[0];
			this.clrSchemeMappingField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_ColorSchemeMapping();
			this.clrSchemeMapping.bg1 = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.light1;
			this.clrSchemeMapping.t1 = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.dark1;
			this.clrSchemeMapping.bg2 = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.light2;
			this.clrSchemeMapping.t2 = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.dark2;
			this.clrSchemeMapping.accent1 = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.accent1;
			this.clrSchemeMapping.accent2 = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.accent2;
			this.clrSchemeMapping.accent3 = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.accent3;
			this.clrSchemeMapping.accent4 = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.accent4;
			this.clrSchemeMapping.accent5 = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.accent5;
			this.clrSchemeMapping.accent6 = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.accent6;
			this.clrSchemeMapping.hyperlink = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.hyperlink;
			this.clrSchemeMapping.followedHyperlink = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex.followedHyperlink;
			this.themeFontLangField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language();
			this.themeFontLang.val = "en-US";
			this.themeFontLang.eastAsia = "zh-CN";
			this.mathPrField = new global::NPOI.OpenXmlFormats.Shared.CT_MathPr();
			this.rsidsField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocRsids();
			this.compatField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Compat();
			this.characterSpacingControlField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_CharacterSpacing();
			this.characterSpacingControl.val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_CharacterSpacing.compressPunctuation;
			this.displayVerticalDrawingGridEveryField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			this.displayVerticalDrawingGridEvery.val = "2";
			this.displayHorizontalDrawingGridEveryField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			this.displayHorizontalDrawingGridEvery.val = "0";
			this.drawingGridVerticalSpacingField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure();
			this.drawingGridVerticalSpacing.val = 156UL;
			this.defaultTabStopField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure();
			this.defaultTabStopField.val = 420UL;
			this.bordersDoNotSurroundFooterField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.bordersDoNotSurroundHeaderField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.zoomField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Zoom();
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x0002D969 File Offset: 0x0002BB69
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x0002D971 File Offset: 0x0002BB71
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_WriteProtection writeProtection
		{
			get
			{
				return this.writeProtectionField;
			}
			set
			{
				this.writeProtectionField = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0002D97A File Offset: 0x0002BB7A
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x0002D982 File Offset: 0x0002BB82
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_View view
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

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0002D98B File Offset: 0x0002BB8B
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x0002D993 File Offset: 0x0002BB93
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Zoom zoom
		{
			get
			{
				return this.zoomField;
			}
			set
			{
				this.zoomField = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x0002D99C File Offset: 0x0002BB9C
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x0002D9A4 File Offset: 0x0002BBA4
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff removePersonalInformation
		{
			get
			{
				return this.removePersonalInformationField;
			}
			set
			{
				this.removePersonalInformationField = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x0002D9AD File Offset: 0x0002BBAD
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x0002D9B5 File Offset: 0x0002BBB5
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff removeDateAndTime
		{
			get
			{
				return this.removeDateAndTimeField;
			}
			set
			{
				this.removeDateAndTimeField = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x0002D9BE File Offset: 0x0002BBBE
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x0002D9C6 File Offset: 0x0002BBC6
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotDisplayPageBoundaries
		{
			get
			{
				return this.doNotDisplayPageBoundariesField;
			}
			set
			{
				this.doNotDisplayPageBoundariesField = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x0002D9CF File Offset: 0x0002BBCF
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x0002D9D7 File Offset: 0x0002BBD7
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff displayBackgroundShape
		{
			get
			{
				return this.displayBackgroundShapeField;
			}
			set
			{
				this.displayBackgroundShapeField = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x0002D9E0 File Offset: 0x0002BBE0
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x0002D9E8 File Offset: 0x0002BBE8
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printPostScriptOverText
		{
			get
			{
				return this.printPostScriptOverTextField;
			}
			set
			{
				this.printPostScriptOverTextField = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x0002D9F1 File Offset: 0x0002BBF1
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x0002D9F9 File Offset: 0x0002BBF9
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printFractionalCharacterWidth
		{
			get
			{
				return this.printFractionalCharacterWidthField;
			}
			set
			{
				this.printFractionalCharacterWidthField = value;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x0002DA02 File Offset: 0x0002BC02
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x0002DA0A File Offset: 0x0002BC0A
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printFormsData
		{
			get
			{
				return this.printFormsDataField;
			}
			set
			{
				this.printFormsDataField = value;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x0002DA13 File Offset: 0x0002BC13
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x0002DA1B File Offset: 0x0002BC1B
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff embedTrueTypeFonts
		{
			get
			{
				return this.embedTrueTypeFontsField;
			}
			set
			{
				this.embedTrueTypeFontsField = value;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x0002DA24 File Offset: 0x0002BC24
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x0002DA2C File Offset: 0x0002BC2C
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff embedSystemFonts
		{
			get
			{
				return this.embedSystemFontsField;
			}
			set
			{
				this.embedSystemFontsField = value;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x0002DA35 File Offset: 0x0002BC35
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x0002DA3D File Offset: 0x0002BC3D
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff saveSubsetFonts
		{
			get
			{
				return this.saveSubsetFontsField;
			}
			set
			{
				this.saveSubsetFontsField = value;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0002DA46 File Offset: 0x0002BC46
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x0002DA4E File Offset: 0x0002BC4E
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff saveFormsData
		{
			get
			{
				return this.saveFormsDataField;
			}
			set
			{
				this.saveFormsDataField = value;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0002DA57 File Offset: 0x0002BC57
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x0002DA5F File Offset: 0x0002BC5F
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff mirrorMargins
		{
			get
			{
				return this.mirrorMarginsField;
			}
			set
			{
				this.mirrorMarginsField = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0002DA68 File Offset: 0x0002BC68
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x0002DA70 File Offset: 0x0002BC70
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff alignBordersAndEdges
		{
			get
			{
				return this.alignBordersAndEdgesField;
			}
			set
			{
				this.alignBordersAndEdgesField = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0002DA79 File Offset: 0x0002BC79
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x0002DA81 File Offset: 0x0002BC81
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bordersDoNotSurroundHeader
		{
			get
			{
				return this.bordersDoNotSurroundHeaderField;
			}
			set
			{
				this.bordersDoNotSurroundHeaderField = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0002DA8A File Offset: 0x0002BC8A
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x0002DA92 File Offset: 0x0002BC92
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bordersDoNotSurroundFooter
		{
			get
			{
				return this.bordersDoNotSurroundFooterField;
			}
			set
			{
				this.bordersDoNotSurroundFooterField = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0002DA9B File Offset: 0x0002BC9B
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x0002DAA3 File Offset: 0x0002BCA3
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff gutterAtTop
		{
			get
			{
				return this.gutterAtTopField;
			}
			set
			{
				this.gutterAtTopField = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0002DAAC File Offset: 0x0002BCAC
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x0002DAB4 File Offset: 0x0002BCB4
		[global::System.Xml.Serialization.XmlElement(Order = 19)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff hideSpellingErrors
		{
			get
			{
				return this.hideSpellingErrorsField;
			}
			set
			{
				this.hideSpellingErrorsField = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0002DABD File Offset: 0x0002BCBD
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x0002DAC5 File Offset: 0x0002BCC5
		[global::System.Xml.Serialization.XmlElement(Order = 20)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff hideGrammaticalErrors
		{
			get
			{
				return this.hideGrammaticalErrorsField;
			}
			set
			{
				this.hideGrammaticalErrorsField = value;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x0002DACE File Offset: 0x0002BCCE
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x0002DAD6 File Offset: 0x0002BCD6
		[global::System.Xml.Serialization.XmlElement("activeWritingStyle", Order = 21)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_WritingStyle> activeWritingStyle
		{
			get
			{
				return this.activeWritingStyleField;
			}
			set
			{
				this.activeWritingStyleField = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0002DADF File Offset: 0x0002BCDF
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x0002DAE7 File Offset: 0x0002BCE7
		[global::System.Xml.Serialization.XmlElement(Order = 22)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Proof proofState
		{
			get
			{
				return this.proofStateField;
			}
			set
			{
				this.proofStateField = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x0002DAF0 File Offset: 0x0002BCF0
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x0002DAF8 File Offset: 0x0002BCF8
		[global::System.Xml.Serialization.XmlElement(Order = 23)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff formsDesign
		{
			get
			{
				return this.formsDesignField;
			}
			set
			{
				this.formsDesignField = value;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x0002DB01 File Offset: 0x0002BD01
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x0002DB09 File Offset: 0x0002BD09
		[global::System.Xml.Serialization.XmlElement(Order = 24)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel attachedTemplate
		{
			get
			{
				return this.attachedTemplateField;
			}
			set
			{
				this.attachedTemplateField = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x0002DB12 File Offset: 0x0002BD12
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x0002DB1A File Offset: 0x0002BD1A
		[global::System.Xml.Serialization.XmlElement(Order = 25)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff linkStyles
		{
			get
			{
				return this.linkStylesField;
			}
			set
			{
				this.linkStylesField = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0002DB23 File Offset: 0x0002BD23
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x0002DB2B File Offset: 0x0002BD2B
		[global::System.Xml.Serialization.XmlElement(Order = 26)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber stylePaneFormatFilter
		{
			get
			{
				return this.stylePaneFormatFilterField;
			}
			set
			{
				this.stylePaneFormatFilterField = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0002DB34 File Offset: 0x0002BD34
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x0002DB3C File Offset: 0x0002BD3C
		[global::System.Xml.Serialization.XmlElement(Order = 27)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber stylePaneSortMethod
		{
			get
			{
				return this.stylePaneSortMethodField;
			}
			set
			{
				this.stylePaneSortMethodField = value;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0002DB45 File Offset: 0x0002BD45
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x0002DB4D File Offset: 0x0002BD4D
		[global::System.Xml.Serialization.XmlElement(Order = 28)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocType documentType
		{
			get
			{
				return this.documentTypeField;
			}
			set
			{
				this.documentTypeField = value;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0002DB56 File Offset: 0x0002BD56
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x0002DB5E File Offset: 0x0002BD5E
		[global::System.Xml.Serialization.XmlElement(Order = 29)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMerge mailMerge
		{
			get
			{
				return this.mailMergeField;
			}
			set
			{
				this.mailMergeField = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0002DB67 File Offset: 0x0002BD67
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x0002DB6F File Offset: 0x0002BD6F
		[global::System.Xml.Serialization.XmlElement(Order = 30)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangesView revisionView
		{
			get
			{
				return this.revisionViewField;
			}
			set
			{
				this.revisionViewField = value;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0002DB78 File Offset: 0x0002BD78
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x0002DB80 File Offset: 0x0002BD80
		[global::System.Xml.Serialization.XmlElement(Order = 31)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff trackRevisions
		{
			get
			{
				return this.trackRevisionsField;
			}
			set
			{
				this.trackRevisionsField = value;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0002DB89 File Offset: 0x0002BD89
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x0002DB91 File Offset: 0x0002BD91
		[global::System.Xml.Serialization.XmlElement(Order = 32)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotTrackMoves
		{
			get
			{
				return this.doNotTrackMovesField;
			}
			set
			{
				this.doNotTrackMovesField = value;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x0002DB9A File Offset: 0x0002BD9A
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x0002DBA2 File Offset: 0x0002BDA2
		[global::System.Xml.Serialization.XmlElement(Order = 33)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotTrackFormatting
		{
			get
			{
				return this.doNotTrackFormattingField;
			}
			set
			{
				this.doNotTrackFormattingField = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x0002DBAB File Offset: 0x0002BDAB
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x0002DBB3 File Offset: 0x0002BDB3
		[global::System.Xml.Serialization.XmlElement(Order = 34)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocProtect documentProtection
		{
			get
			{
				return this.documentProtectionField;
			}
			set
			{
				this.documentProtectionField = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x0002DBBC File Offset: 0x0002BDBC
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x0002DBC4 File Offset: 0x0002BDC4
		[global::System.Xml.Serialization.XmlElement(Order = 35)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoFormatOverride
		{
			get
			{
				return this.autoFormatOverrideField;
			}
			set
			{
				this.autoFormatOverrideField = value;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x0002DBCD File Offset: 0x0002BDCD
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x0002DBD5 File Offset: 0x0002BDD5
		[global::System.Xml.Serialization.XmlElement(Order = 36)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff styleLockTheme
		{
			get
			{
				return this.styleLockThemeField;
			}
			set
			{
				this.styleLockThemeField = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0002DBDE File Offset: 0x0002BDDE
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x0002DBE6 File Offset: 0x0002BDE6
		[global::System.Xml.Serialization.XmlElement(Order = 37)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff styleLockQFSet
		{
			get
			{
				return this.styleLockQFSetField;
			}
			set
			{
				this.styleLockQFSetField = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0002DBEF File Offset: 0x0002BDEF
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x0002DBF7 File Offset: 0x0002BDF7
		[global::System.Xml.Serialization.XmlElement(Order = 38)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure defaultTabStop
		{
			get
			{
				return this.defaultTabStopField;
			}
			set
			{
				this.defaultTabStopField = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0002DC00 File Offset: 0x0002BE00
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x0002DC08 File Offset: 0x0002BE08
		[global::System.Xml.Serialization.XmlElement(Order = 39)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoHyphenation
		{
			get
			{
				return this.autoHyphenationField;
			}
			set
			{
				this.autoHyphenationField = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0002DC11 File Offset: 0x0002BE11
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x0002DC19 File Offset: 0x0002BE19
		[global::System.Xml.Serialization.XmlElement(Order = 40)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber consecutiveHyphenLimit
		{
			get
			{
				return this.consecutiveHyphenLimitField;
			}
			set
			{
				this.consecutiveHyphenLimitField = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0002DC22 File Offset: 0x0002BE22
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x0002DC2A File Offset: 0x0002BE2A
		[global::System.Xml.Serialization.XmlElement(Order = 41)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure hyphenationZone
		{
			get
			{
				return this.hyphenationZoneField;
			}
			set
			{
				this.hyphenationZoneField = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x0002DC33 File Offset: 0x0002BE33
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x0002DC3B File Offset: 0x0002BE3B
		[global::System.Xml.Serialization.XmlElement(Order = 42)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotHyphenateCaps
		{
			get
			{
				return this.doNotHyphenateCapsField;
			}
			set
			{
				this.doNotHyphenateCapsField = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0002DC44 File Offset: 0x0002BE44
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x0002DC4C File Offset: 0x0002BE4C
		[global::System.Xml.Serialization.XmlElement(Order = 43)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff showEnvelope
		{
			get
			{
				return this.showEnvelopeField;
			}
			set
			{
				this.showEnvelopeField = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x0002DC55 File Offset: 0x0002BE55
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x0002DC5D File Offset: 0x0002BE5D
		[global::System.Xml.Serialization.XmlElement(Order = 44)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber summaryLength
		{
			get
			{
				return this.summaryLengthField;
			}
			set
			{
				this.summaryLengthField = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x0002DC66 File Offset: 0x0002BE66
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x0002DC6E File Offset: 0x0002BE6E
		[global::System.Xml.Serialization.XmlElement(Order = 45)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String clickAndTypeStyle
		{
			get
			{
				return this.clickAndTypeStyleField;
			}
			set
			{
				this.clickAndTypeStyleField = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0002DC77 File Offset: 0x0002BE77
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x0002DC7F File Offset: 0x0002BE7F
		[global::System.Xml.Serialization.XmlElement(Order = 46)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String defaultTableStyle
		{
			get
			{
				return this.defaultTableStyleField;
			}
			set
			{
				this.defaultTableStyleField = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0002DC88 File Offset: 0x0002BE88
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x0002DC90 File Offset: 0x0002BE90
		[global::System.Xml.Serialization.XmlElement(Order = 47)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff evenAndOddHeaders
		{
			get
			{
				return this.evenAndOddHeadersField;
			}
			set
			{
				this.evenAndOddHeadersField = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0002DC99 File Offset: 0x0002BE99
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x0002DCA1 File Offset: 0x0002BEA1
		[global::System.Xml.Serialization.XmlElement(Order = 48)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bookFoldRevPrinting
		{
			get
			{
				return this.bookFoldRevPrintingField;
			}
			set
			{
				this.bookFoldRevPrintingField = value;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x0002DCAA File Offset: 0x0002BEAA
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x0002DCB2 File Offset: 0x0002BEB2
		[global::System.Xml.Serialization.XmlElement(Order = 49)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bookFoldPrinting
		{
			get
			{
				return this.bookFoldPrintingField;
			}
			set
			{
				this.bookFoldPrintingField = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0002DCBB File Offset: 0x0002BEBB
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x0002DCC3 File Offset: 0x0002BEC3
		[global::System.Xml.Serialization.XmlElement(Order = 50)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber bookFoldPrintingSheets
		{
			get
			{
				return this.bookFoldPrintingSheetsField;
			}
			set
			{
				this.bookFoldPrintingSheetsField = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x0002DCCC File Offset: 0x0002BECC
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x0002DCD4 File Offset: 0x0002BED4
		[global::System.Xml.Serialization.XmlElement(Order = 51)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure drawingGridHorizontalSpacing
		{
			get
			{
				return this.drawingGridHorizontalSpacingField;
			}
			set
			{
				this.drawingGridHorizontalSpacingField = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x0002DCDD File Offset: 0x0002BEDD
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x0002DCE5 File Offset: 0x0002BEE5
		[global::System.Xml.Serialization.XmlElement(Order = 52)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure drawingGridVerticalSpacing
		{
			get
			{
				return this.drawingGridVerticalSpacingField;
			}
			set
			{
				this.drawingGridVerticalSpacingField = value;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0002DCEE File Offset: 0x0002BEEE
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x0002DCF6 File Offset: 0x0002BEF6
		[global::System.Xml.Serialization.XmlElement(Order = 53)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber displayHorizontalDrawingGridEvery
		{
			get
			{
				return this.displayHorizontalDrawingGridEveryField;
			}
			set
			{
				this.displayHorizontalDrawingGridEveryField = value;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0002DCFF File Offset: 0x0002BEFF
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x0002DD07 File Offset: 0x0002BF07
		[global::System.Xml.Serialization.XmlElement(Order = 54)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber displayVerticalDrawingGridEvery
		{
			get
			{
				return this.displayVerticalDrawingGridEveryField;
			}
			set
			{
				this.displayVerticalDrawingGridEveryField = value;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0002DD10 File Offset: 0x0002BF10
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x0002DD18 File Offset: 0x0002BF18
		[global::System.Xml.Serialization.XmlElement(Order = 55)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotUseMarginsForDrawingGridOrigin
		{
			get
			{
				return this.doNotUseMarginsForDrawingGridOriginField;
			}
			set
			{
				this.doNotUseMarginsForDrawingGridOriginField = value;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0002DD21 File Offset: 0x0002BF21
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x0002DD29 File Offset: 0x0002BF29
		[global::System.Xml.Serialization.XmlElement(Order = 56)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure drawingGridHorizontalOrigin
		{
			get
			{
				return this.drawingGridHorizontalOriginField;
			}
			set
			{
				this.drawingGridHorizontalOriginField = value;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x0002DD32 File Offset: 0x0002BF32
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x0002DD3A File Offset: 0x0002BF3A
		[global::System.Xml.Serialization.XmlElement(Order = 57)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure drawingGridVerticalOrigin
		{
			get
			{
				return this.drawingGridVerticalOriginField;
			}
			set
			{
				this.drawingGridVerticalOriginField = value;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x0002DD43 File Offset: 0x0002BF43
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x0002DD4B File Offset: 0x0002BF4B
		[global::System.Xml.Serialization.XmlElement(Order = 58)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotShadeFormData
		{
			get
			{
				return this.doNotShadeFormDataField;
			}
			set
			{
				this.doNotShadeFormDataField = value;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0002DD54 File Offset: 0x0002BF54
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x0002DD5C File Offset: 0x0002BF5C
		[global::System.Xml.Serialization.XmlElement(Order = 59)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noPunctuationKerning
		{
			get
			{
				return this.noPunctuationKerningField;
			}
			set
			{
				this.noPunctuationKerningField = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x0002DD65 File Offset: 0x0002BF65
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x0002DD6D File Offset: 0x0002BF6D
		[global::System.Xml.Serialization.XmlElement(Order = 60)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_CharacterSpacing characterSpacingControl
		{
			get
			{
				return this.characterSpacingControlField;
			}
			set
			{
				this.characterSpacingControlField = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0002DD76 File Offset: 0x0002BF76
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x0002DD7E File Offset: 0x0002BF7E
		[global::System.Xml.Serialization.XmlElement(Order = 61)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printTwoOnOne
		{
			get
			{
				return this.printTwoOnOneField;
			}
			set
			{
				this.printTwoOnOneField = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x0002DD87 File Offset: 0x0002BF87
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x0002DD8F File Offset: 0x0002BF8F
		[global::System.Xml.Serialization.XmlElement(Order = 62)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff strictFirstAndLastChars
		{
			get
			{
				return this.strictFirstAndLastCharsField;
			}
			set
			{
				this.strictFirstAndLastCharsField = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0002DD98 File Offset: 0x0002BF98
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x0002DDA0 File Offset: 0x0002BFA0
		[global::System.Xml.Serialization.XmlElement(Order = 63)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Kinsoku noLineBreaksAfter
		{
			get
			{
				return this.noLineBreaksAfterField;
			}
			set
			{
				this.noLineBreaksAfterField = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0002DDA9 File Offset: 0x0002BFA9
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x0002DDB1 File Offset: 0x0002BFB1
		[global::System.Xml.Serialization.XmlElement(Order = 64)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Kinsoku noLineBreaksBefore
		{
			get
			{
				return this.noLineBreaksBeforeField;
			}
			set
			{
				this.noLineBreaksBeforeField = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x0002DDBA File Offset: 0x0002BFBA
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x0002DDC2 File Offset: 0x0002BFC2
		[global::System.Xml.Serialization.XmlElement(Order = 65)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff savePreviewPicture
		{
			get
			{
				return this.savePreviewPictureField;
			}
			set
			{
				this.savePreviewPictureField = value;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0002DDCB File Offset: 0x0002BFCB
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x0002DDD3 File Offset: 0x0002BFD3
		[global::System.Xml.Serialization.XmlElement(Order = 66)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotValidateAgainstSchema
		{
			get
			{
				return this.doNotValidateAgainstSchemaField;
			}
			set
			{
				this.doNotValidateAgainstSchemaField = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0002DDDC File Offset: 0x0002BFDC
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x0002DDE4 File Offset: 0x0002BFE4
		[global::System.Xml.Serialization.XmlElement(Order = 67)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff saveInvalidXml
		{
			get
			{
				return this.saveInvalidXmlField;
			}
			set
			{
				this.saveInvalidXmlField = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x0002DDED File Offset: 0x0002BFED
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x0002DDF5 File Offset: 0x0002BFF5
		[global::System.Xml.Serialization.XmlElement(Order = 68)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ignoreMixedContent
		{
			get
			{
				return this.ignoreMixedContentField;
			}
			set
			{
				this.ignoreMixedContentField = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x0002DDFE File Offset: 0x0002BFFE
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x0002DE06 File Offset: 0x0002C006
		[global::System.Xml.Serialization.XmlElement(Order = 69)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff alwaysShowPlaceholderText
		{
			get
			{
				return this.alwaysShowPlaceholderTextField;
			}
			set
			{
				this.alwaysShowPlaceholderTextField = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x0002DE0F File Offset: 0x0002C00F
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x0002DE17 File Offset: 0x0002C017
		[global::System.Xml.Serialization.XmlElement(Order = 70)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotDemarcateInvalidXml
		{
			get
			{
				return this.doNotDemarcateInvalidXmlField;
			}
			set
			{
				this.doNotDemarcateInvalidXmlField = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x0002DE20 File Offset: 0x0002C020
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x0002DE28 File Offset: 0x0002C028
		[global::System.Xml.Serialization.XmlElement(Order = 71)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff saveXmlDataOnly
		{
			get
			{
				return this.saveXmlDataOnlyField;
			}
			set
			{
				this.saveXmlDataOnlyField = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0002DE31 File Offset: 0x0002C031
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x0002DE39 File Offset: 0x0002C039
		[global::System.Xml.Serialization.XmlElement(Order = 72)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useXSLTWhenSaving
		{
			get
			{
				return this.useXSLTWhenSavingField;
			}
			set
			{
				this.useXSLTWhenSavingField = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x0002DE42 File Offset: 0x0002C042
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x0002DE4A File Offset: 0x0002C04A
		[global::System.Xml.Serialization.XmlElement(Order = 73)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SaveThroughXslt saveThroughXslt
		{
			get
			{
				return this.saveThroughXsltField;
			}
			set
			{
				this.saveThroughXsltField = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x0002DE53 File Offset: 0x0002C053
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x0002DE5B File Offset: 0x0002C05B
		[global::System.Xml.Serialization.XmlElement(Order = 74)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff showXMLTags
		{
			get
			{
				return this.showXMLTagsField;
			}
			set
			{
				this.showXMLTagsField = value;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x0002DE64 File Offset: 0x0002C064
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x0002DE6C File Offset: 0x0002C06C
		[global::System.Xml.Serialization.XmlElement(Order = 75)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff alwaysMergeEmptyNamespace
		{
			get
			{
				return this.alwaysMergeEmptyNamespaceField;
			}
			set
			{
				this.alwaysMergeEmptyNamespaceField = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x0002DE75 File Offset: 0x0002C075
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x0002DE7D File Offset: 0x0002C07D
		[global::System.Xml.Serialization.XmlElement(Order = 76)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff updateFields
		{
			get
			{
				return this.updateFieldsField;
			}
			set
			{
				this.updateFieldsField = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0002DE86 File Offset: 0x0002C086
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x0002DE8E File Offset: 0x0002C08E
		[global::System.Xml.Serialization.XmlArray(Order = 77)]
		[global::System.Xml.Serialization.XmlArrayItem("", Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
		public global::System.Xml.XmlElement[] hdrShapeDefaults
		{
			get
			{
				return this.hdrShapeDefaultsField;
			}
			set
			{
				this.hdrShapeDefaultsField = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0002DE97 File Offset: 0x0002C097
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x0002DE9F File Offset: 0x0002C09F
		[global::System.Xml.Serialization.XmlElement(Order = 78)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnDocProps footnotePr
		{
			get
			{
				return this.footnotePrField;
			}
			set
			{
				this.footnotePrField = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0002DEA8 File Offset: 0x0002C0A8
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x0002DEB0 File Offset: 0x0002C0B0
		[global::System.Xml.Serialization.XmlElement(Order = 79)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnDocProps endnotePr
		{
			get
			{
				return this.endnotePrField;
			}
			set
			{
				this.endnotePrField = value;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x0002DEB9 File Offset: 0x0002C0B9
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x0002DEC1 File Offset: 0x0002C0C1
		[global::System.Xml.Serialization.XmlElement(Order = 80)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Compat compat
		{
			get
			{
				return this.compatField;
			}
			set
			{
				this.compatField = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x0002DECA File Offset: 0x0002C0CA
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x0002DED2 File Offset: 0x0002C0D2
		[global::System.Xml.Serialization.XmlArray(Order = 81)]
		[global::System.Xml.Serialization.XmlArrayItem("docVar", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocVar> docVars
		{
			get
			{
				return this.docVarsField;
			}
			set
			{
				this.docVarsField = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x0002DEDB File Offset: 0x0002C0DB
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x0002DEE3 File Offset: 0x0002C0E3
		[global::System.Xml.Serialization.XmlElement(Order = 82)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocRsids rsids
		{
			get
			{
				return this.rsidsField;
			}
			set
			{
				this.rsidsField = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x0002DEEC File Offset: 0x0002C0EC
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x0002DEF4 File Offset: 0x0002C0F4
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 83)]
		public global::NPOI.OpenXmlFormats.Shared.CT_MathPr mathPr
		{
			get
			{
				return this.mathPrField;
			}
			set
			{
				this.mathPrField = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0002DEFD File Offset: 0x0002C0FD
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x0002DF05 File Offset: 0x0002C105
		[global::System.Xml.Serialization.XmlElement(Order = 84)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff uiCompat97To2003
		{
			get
			{
				return this.uiCompat97To2003Field;
			}
			set
			{
				this.uiCompat97To2003Field = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x0002DF0E File Offset: 0x0002C10E
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x0002DF16 File Offset: 0x0002C116
		[global::System.Xml.Serialization.XmlElement("attachedSchema", Order = 85)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String> attachedSchema
		{
			get
			{
				return this.attachedSchemaField;
			}
			set
			{
				this.attachedSchemaField = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0002DF1F File Offset: 0x0002C11F
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x0002DF27 File Offset: 0x0002C127
		[global::System.Xml.Serialization.XmlElement(Order = 86)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language themeFontLang
		{
			get
			{
				return this.themeFontLangField;
			}
			set
			{
				this.themeFontLangField = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0002DF30 File Offset: 0x0002C130
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x0002DF38 File Offset: 0x0002C138
		[global::System.Xml.Serialization.XmlElement(Order = 87)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_ColorSchemeMapping clrSchemeMapping
		{
			get
			{
				return this.clrSchemeMappingField;
			}
			set
			{
				this.clrSchemeMappingField = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0002DF41 File Offset: 0x0002C141
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x0002DF49 File Offset: 0x0002C149
		[global::System.Xml.Serialization.XmlElement(Order = 88)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotIncludeSubdocsInStats
		{
			get
			{
				return this.doNotIncludeSubdocsInStatsField;
			}
			set
			{
				this.doNotIncludeSubdocsInStatsField = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x0002DF52 File Offset: 0x0002C152
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x0002DF5A File Offset: 0x0002C15A
		[global::System.Xml.Serialization.XmlElement(Order = 89)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotAutoCompressPictures
		{
			get
			{
				return this.doNotAutoCompressPicturesField;
			}
			set
			{
				this.doNotAutoCompressPicturesField = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0002DF63 File Offset: 0x0002C163
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x0002DF6B File Offset: 0x0002C16B
		[global::System.Xml.Serialization.XmlElement(Order = 90)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty forceUpgrade
		{
			get
			{
				return this.forceUpgradeField;
			}
			set
			{
				this.forceUpgradeField = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x0002DF74 File Offset: 0x0002C174
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x0002DF7C File Offset: 0x0002C17C
		[global::System.Xml.Serialization.XmlElement(Order = 91)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Captions captions
		{
			get
			{
				return this.captionsField;
			}
			set
			{
				this.captionsField = value;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x0002DF85 File Offset: 0x0002C185
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x0002DF8D File Offset: 0x0002C18D
		[global::System.Xml.Serialization.XmlElement(Order = 92)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_ReadingModeInkLockDown readModeInkLockDown
		{
			get
			{
				return this.readModeInkLockDownField;
			}
			set
			{
				this.readModeInkLockDownField = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x0002DF96 File Offset: 0x0002C196
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x0002DF9E File Offset: 0x0002C19E
		[global::System.Xml.Serialization.XmlElement("smartTagType", Order = 93)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagType> smartTagType
		{
			get
			{
				return this.smartTagTypeField;
			}
			set
			{
				this.smartTagTypeField = value;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x0002DFA7 File Offset: 0x0002C1A7
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x0002DFAF File Offset: 0x0002C1AF
		[global::System.Xml.Serialization.XmlArray(Namespace = "http://schemas.openxmlformats.org/schemaLibrary/2006/main", Order = 94)]
		[global::System.Xml.Serialization.XmlArrayItem("schema", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Schema> schemaLibrary
		{
			get
			{
				return this.schemaLibraryField;
			}
			set
			{
				this.schemaLibraryField = value;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0002DFB8 File Offset: 0x0002C1B8
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x0002DFC0 File Offset: 0x0002C1C0
		[global::System.Xml.Serialization.XmlArray(Order = 95)]
		[global::System.Xml.Serialization.XmlArrayItem("", Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
		public global::System.Xml.XmlElement[] shapeDefaults
		{
			get
			{
				return this.shapeDefaultsField;
			}
			set
			{
				this.shapeDefaultsField = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0002DFC9 File Offset: 0x0002C1C9
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x0002DFD1 File Offset: 0x0002C1D1
		[global::System.Xml.Serialization.XmlElement(Order = 96)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotEmbedSmartTags
		{
			get
			{
				return this.doNotEmbedSmartTagsField;
			}
			set
			{
				this.doNotEmbedSmartTagsField = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0002DFDA File Offset: 0x0002C1DA
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x0002DFE2 File Offset: 0x0002C1E2
		[global::System.Xml.Serialization.XmlElement(Order = 97)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String decimalSymbol
		{
			get
			{
				return this.decimalSymbolField;
			}
			set
			{
				this.decimalSymbolField = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0002DFEB File Offset: 0x0002C1EB
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x0002DFF3 File Offset: 0x0002C1F3
		[global::System.Xml.Serialization.XmlElement(Order = 98)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String listSeparator
		{
			get
			{
				return this.listSeparatorField;
			}
			set
			{
				this.listSeparatorField = value;
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0002DFFC File Offset: 0x0002C1FC
		public bool IsSetZoom()
		{
			return this.zoom != null;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0002E007 File Offset: 0x0002C207
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Zoom AddNewZoom()
		{
			this.zoom = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Zoom();
			return this.zoom;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0002E01A File Offset: 0x0002C21A
		public bool IsSetUpdateFields()
		{
			return this.updateFieldsField != null;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0002E025 File Offset: 0x0002C225
		public bool IsSetTrackRevisions()
		{
			return this.trackRevisionsField != null && this.trackRevisionsField.val;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0002E03C File Offset: 0x0002C23C
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewTrackRevisions()
		{
			this.trackRevisionsField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.trackRevisionsField.val = true;
			return this.trackRevisionsField;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0002E05B File Offset: 0x0002C25B
		public void UnsetTrackRevisions()
		{
			this.trackRevisionsField = null;
		}

		// Token: 0x04000B19 RID: 2841
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_WriteProtection writeProtectionField;

		// Token: 0x04000B1A RID: 2842
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_View viewField;

		// Token: 0x04000B1B RID: 2843
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Zoom zoomField;

		// Token: 0x04000B1C RID: 2844
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff removePersonalInformationField;

		// Token: 0x04000B1D RID: 2845
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff removeDateAndTimeField;

		// Token: 0x04000B1E RID: 2846
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotDisplayPageBoundariesField;

		// Token: 0x04000B1F RID: 2847
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff displayBackgroundShapeField;

		// Token: 0x04000B20 RID: 2848
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printPostScriptOverTextField;

		// Token: 0x04000B21 RID: 2849
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printFractionalCharacterWidthField;

		// Token: 0x04000B22 RID: 2850
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printFormsDataField;

		// Token: 0x04000B23 RID: 2851
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff embedTrueTypeFontsField;

		// Token: 0x04000B24 RID: 2852
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff embedSystemFontsField;

		// Token: 0x04000B25 RID: 2853
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff saveSubsetFontsField;

		// Token: 0x04000B26 RID: 2854
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff saveFormsDataField;

		// Token: 0x04000B27 RID: 2855
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff mirrorMarginsField;

		// Token: 0x04000B28 RID: 2856
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff alignBordersAndEdgesField;

		// Token: 0x04000B29 RID: 2857
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bordersDoNotSurroundHeaderField;

		// Token: 0x04000B2A RID: 2858
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bordersDoNotSurroundFooterField;

		// Token: 0x04000B2B RID: 2859
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff gutterAtTopField;

		// Token: 0x04000B2C RID: 2860
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff hideSpellingErrorsField;

		// Token: 0x04000B2D RID: 2861
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff hideGrammaticalErrorsField;

		// Token: 0x04000B2E RID: 2862
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_WritingStyle> activeWritingStyleField;

		// Token: 0x04000B2F RID: 2863
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Proof proofStateField;

		// Token: 0x04000B30 RID: 2864
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff formsDesignField;

		// Token: 0x04000B31 RID: 2865
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel attachedTemplateField;

		// Token: 0x04000B32 RID: 2866
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff linkStylesField;

		// Token: 0x04000B33 RID: 2867
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber stylePaneFormatFilterField;

		// Token: 0x04000B34 RID: 2868
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber stylePaneSortMethodField;

		// Token: 0x04000B35 RID: 2869
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocType documentTypeField;

		// Token: 0x04000B36 RID: 2870
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMerge mailMergeField;

		// Token: 0x04000B37 RID: 2871
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangesView revisionViewField;

		// Token: 0x04000B38 RID: 2872
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff trackRevisionsField;

		// Token: 0x04000B39 RID: 2873
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotTrackMovesField;

		// Token: 0x04000B3A RID: 2874
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotTrackFormattingField;

		// Token: 0x04000B3B RID: 2875
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocProtect documentProtectionField;

		// Token: 0x04000B3C RID: 2876
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoFormatOverrideField;

		// Token: 0x04000B3D RID: 2877
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff styleLockThemeField;

		// Token: 0x04000B3E RID: 2878
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff styleLockQFSetField;

		// Token: 0x04000B3F RID: 2879
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure defaultTabStopField;

		// Token: 0x04000B40 RID: 2880
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoHyphenationField;

		// Token: 0x04000B41 RID: 2881
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber consecutiveHyphenLimitField;

		// Token: 0x04000B42 RID: 2882
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure hyphenationZoneField;

		// Token: 0x04000B43 RID: 2883
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotHyphenateCapsField;

		// Token: 0x04000B44 RID: 2884
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff showEnvelopeField;

		// Token: 0x04000B45 RID: 2885
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber summaryLengthField;

		// Token: 0x04000B46 RID: 2886
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String clickAndTypeStyleField;

		// Token: 0x04000B47 RID: 2887
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String defaultTableStyleField;

		// Token: 0x04000B48 RID: 2888
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff evenAndOddHeadersField;

		// Token: 0x04000B49 RID: 2889
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bookFoldRevPrintingField;

		// Token: 0x04000B4A RID: 2890
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bookFoldPrintingField;

		// Token: 0x04000B4B RID: 2891
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber bookFoldPrintingSheetsField;

		// Token: 0x04000B4C RID: 2892
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure drawingGridHorizontalSpacingField;

		// Token: 0x04000B4D RID: 2893
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure drawingGridVerticalSpacingField;

		// Token: 0x04000B4E RID: 2894
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber displayHorizontalDrawingGridEveryField;

		// Token: 0x04000B4F RID: 2895
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber displayVerticalDrawingGridEveryField;

		// Token: 0x04000B50 RID: 2896
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotUseMarginsForDrawingGridOriginField;

		// Token: 0x04000B51 RID: 2897
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure drawingGridHorizontalOriginField;

		// Token: 0x04000B52 RID: 2898
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure drawingGridVerticalOriginField;

		// Token: 0x04000B53 RID: 2899
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotShadeFormDataField;

		// Token: 0x04000B54 RID: 2900
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noPunctuationKerningField;

		// Token: 0x04000B55 RID: 2901
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_CharacterSpacing characterSpacingControlField;

		// Token: 0x04000B56 RID: 2902
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff printTwoOnOneField;

		// Token: 0x04000B57 RID: 2903
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff strictFirstAndLastCharsField;

		// Token: 0x04000B58 RID: 2904
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Kinsoku noLineBreaksAfterField;

		// Token: 0x04000B59 RID: 2905
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Kinsoku noLineBreaksBeforeField;

		// Token: 0x04000B5A RID: 2906
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff savePreviewPictureField;

		// Token: 0x04000B5B RID: 2907
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotValidateAgainstSchemaField;

		// Token: 0x04000B5C RID: 2908
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff saveInvalidXmlField;

		// Token: 0x04000B5D RID: 2909
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ignoreMixedContentField;

		// Token: 0x04000B5E RID: 2910
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff alwaysShowPlaceholderTextField;

		// Token: 0x04000B5F RID: 2911
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotDemarcateInvalidXmlField;

		// Token: 0x04000B60 RID: 2912
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff saveXmlDataOnlyField;

		// Token: 0x04000B61 RID: 2913
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff useXSLTWhenSavingField;

		// Token: 0x04000B62 RID: 2914
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SaveThroughXslt saveThroughXsltField;

		// Token: 0x04000B63 RID: 2915
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff showXMLTagsField;

		// Token: 0x04000B64 RID: 2916
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff alwaysMergeEmptyNamespaceField;

		// Token: 0x04000B65 RID: 2917
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff updateFieldsField;

		// Token: 0x04000B66 RID: 2918
		private global::System.Xml.XmlElement[] hdrShapeDefaultsField;

		// Token: 0x04000B67 RID: 2919
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnDocProps footnotePrField;

		// Token: 0x04000B68 RID: 2920
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnDocProps endnotePrField;

		// Token: 0x04000B69 RID: 2921
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Compat compatField;

		// Token: 0x04000B6A RID: 2922
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocVar> docVarsField;

		// Token: 0x04000B6B RID: 2923
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocRsids rsidsField;

		// Token: 0x04000B6C RID: 2924
		private global::NPOI.OpenXmlFormats.Shared.CT_MathPr mathPrField;

		// Token: 0x04000B6D RID: 2925
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff uiCompat97To2003Field;

		// Token: 0x04000B6E RID: 2926
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String> attachedSchemaField;

		// Token: 0x04000B6F RID: 2927
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language themeFontLangField;

		// Token: 0x04000B70 RID: 2928
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_ColorSchemeMapping clrSchemeMappingField;

		// Token: 0x04000B71 RID: 2929
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotIncludeSubdocsInStatsField;

		// Token: 0x04000B72 RID: 2930
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotAutoCompressPicturesField;

		// Token: 0x04000B73 RID: 2931
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty forceUpgradeField;

		// Token: 0x04000B74 RID: 2932
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Captions captionsField;

		// Token: 0x04000B75 RID: 2933
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_ReadingModeInkLockDown readModeInkLockDownField;

		// Token: 0x04000B76 RID: 2934
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagType> smartTagTypeField;

		// Token: 0x04000B77 RID: 2935
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Schema> schemaLibraryField;

		// Token: 0x04000B78 RID: 2936
		private global::System.Xml.XmlElement[] shapeDefaultsField;

		// Token: 0x04000B79 RID: 2937
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotEmbedSmartTagsField;

		// Token: 0x04000B7A RID: 2938
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String decimalSymbolField;

		// Token: 0x04000B7B RID: 2939
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String listSeparatorField;
	}
}
