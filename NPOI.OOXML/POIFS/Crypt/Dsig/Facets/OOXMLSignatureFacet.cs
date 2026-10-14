using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Xml;
using NPOI.OpenXml4Net.OPC;

namespace NPOI.POIFS.Crypt.Dsig.Facets
{
	// Token: 0x0200010F RID: 271
	public class OOXMLSignatureFacet : global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet
	{
		// Token: 0x06000F83 RID: 3971 RVA: 0x000364F9 File Offset: 0x000346F9
		public override void preSign(global::System.Xml.XmlDocument document, global::System.Collections.Generic.List<global::System.Security.Cryptography.Xml.Reference> references, global::System.Collections.Generic.List<global::System.Xml.XmlNode> objects)
		{
			this.AddManifestObject(document, references, objects);
			this.AddSignatureInfo(document, references, objects);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00036510 File Offset: 0x00034710
		protected void AddManifestObject(global::System.Xml.XmlDocument document, global::System.Collections.Generic.List<global::System.Security.Cryptography.Xml.Reference> references, global::System.Collections.Generic.List<global::System.Xml.XmlNode> objects)
		{
			global::System.Collections.Generic.List<global::System.Security.Cryptography.Xml.Reference> manifestReferences = new global::System.Collections.Generic.List<global::System.Security.Cryptography.Xml.Reference>();
			this.AddManifestReferences(manifestReferences);
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0003652F File Offset: 0x0003472F
		protected void AddManifestReferences(global::System.Collections.Generic.List<global::System.Security.Cryptography.Xml.Reference> manifestReferences)
		{
			this.signatureConfig.GetOpcPackage().GetPartsByContentType(global::NPOI.OpenXml4Net.OPC.ContentTypes.RELATIONSHIPS_PART);
			new global::System.Collections.Generic.HashSet<string>();
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000065E4 File Offset: 0x000047E4
		protected void AddSignatureTime(global::System.Xml.XmlDocument document, global::System.Collections.Generic.List<global::System.Xml.XmlNode> objectContent)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000065E4 File Offset: 0x000047E4
		protected void AddSignatureInfo(global::System.Xml.XmlDocument document, global::System.Collections.Generic.List<global::System.Security.Cryptography.Xml.Reference> references, global::System.Collections.Generic.List<global::System.Xml.XmlNode> objects)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00036552 File Offset: 0x00034752
		protected static string GetRelationshipReferenceURI(string zipEntryName)
		{
			return "/" + zipEntryName + "?ContentType=application/vnd.Openxmlformats-package.relationships+xml";
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00036564 File Offset: 0x00034764
		protected static string GetResourceReferenceURI(string resourceName, string contentType)
		{
			return "/" + resourceName + "?ContentType=" + contentType;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00036578 File Offset: 0x00034778
		protected static bool IsSignedRelationship(string relationshipType)
		{
			foreach (string value in global::NPOI.POIFS.Crypt.Dsig.Facets.OOXMLSignatureFacet.signed)
			{
				if (relationshipType.EndsWith(value))
				{
					return true;
				}
			}
			return relationshipType.EndsWith("customXml");
		}

		// Token: 0x040004C0 RID: 1216
		public static string[] contentTypes = new string[]
		{
			"application/vnd.Openxmlformats-officedocument.wordProcessingml.document.main+xml",
			"application/vnd.Openxmlformats-officedocument.wordProcessingml.fontTable+xml",
			"application/vnd.Openxmlformats-officedocument.wordProcessingml.Settings+xml",
			"application/vnd.Openxmlformats-officedocument.wordProcessingml.styles+xml",
			"application/vnd.Openxmlformats-officedocument.theme+xml",
			"application/vnd.Openxmlformats-officedocument.wordProcessingml.webSettings+xml",
			"application/vnd.Openxmlformats-officedocument.wordProcessingml.numbering+xml",
			"application/vnd.ms-word.stylesWithEffects+xml",
			"application/vnd.Openxmlformats-officedocument.spreadsheetml.sharedStrings+xml",
			"application/vnd.Openxmlformats-officedocument.spreadsheetml.worksheet+xml",
			"application/vnd.Openxmlformats-officedocument.spreadsheetml.styles+xml",
			"application/vnd.Openxmlformats-officedocument.spreadsheetml.sheet.main+xml",
			"application/vnd.Openxmlformats-officedocument.presentationml.presentation.main+xml",
			"application/vnd.Openxmlformats-officedocument.presentationml.slideLayout+xml",
			"application/vnd.Openxmlformats-officedocument.presentationml.slideMaster+xml",
			"application/vnd.Openxmlformats-officedocument.presentationml.slide+xml",
			"application/vnd.Openxmlformats-officedocument.presentationml.tableStyles+xml",
			"application/vnd.Openxmlformats-officedocument.presentationml.viewProps+xml",
			"application/vnd.Openxmlformats-officedocument.presentationml.presProps+xml"
		};

		// Token: 0x040004C1 RID: 1217
		public static string[] signed = new string[]
		{
			"powerPivotData",
			"activeXControlBinary",
			"attachedToolbars",
			"connectorXml",
			"downRev",
			"functionPrototypes",
			"graphicFrameDoc",
			"groupShapeXml",
			"ink",
			"keyMapCustomizations",
			"legacyDiagramText",
			"legacyDocTextInfo",
			"officeDocument",
			"pictureXml",
			"shapeXml",
			"smartTags",
			"ui/altText",
			"ui/buttonSize",
			"ui/controlID",
			"ui/description",
			"ui/enabled",
			"ui/extensibility",
			"ui/helperText",
			"ui/imageID",
			"ui/imageMso",
			"ui/keyTip",
			"ui/label",
			"ui/lcid",
			"ui/loud",
			"ui/pressed",
			"ui/progID",
			"ui/ribbonID",
			"ui/ShowImage",
			"ui/ShowLabel",
			"ui/supertip",
			"ui/target",
			"ui/text",
			"ui/title",
			"ui/tooltip",
			"ui/userCustomization",
			"ui/visible",
			"userXmlData",
			"vbaProject",
			"wordVbaData",
			"wsSortMap",
			"xlBinaryIndex",
			"xlExternalLinkPath/xlAlternateStartup",
			"xlExternalLinkPath/xlLibrary",
			"xlExternalLinkPath/xlPathMissing",
			"xlExternalLinkPath/xlStartup",
			"xlIntlMacrosheet",
			"xlMacrosheet",
			"customData",
			"diagramDrawing",
			"hdphoto",
			"inkXml",
			"media",
			"slicer",
			"slicerCache",
			"stylesWithEffects",
			"ui/extensibility",
			"chartColorStyle",
			"chartLayout",
			"chartStyle",
			"dictionary",
			"timeline",
			"timelineCache",
			"aFChunk",
			"attachedTemplate",
			"audio",
			"calcChain",
			"chart",
			"chartsheet",
			"chartUserShapes",
			"commentAuthors",
			"comments",
			"connections",
			"control",
			"customProperty",
			"customXml",
			"diagramColors",
			"diagramData",
			"diagramLayout",
			"diagramQuickStyle",
			"dialogsheet",
			"drawing",
			"endnotes",
			"externalLink",
			"externalLinkPath",
			"font",
			"fontTable",
			"footer",
			"footnotes",
			"glossaryDocument",
			"handoutMaster",
			"header",
			"hyperlink",
			"image",
			"mailMergeHeaderSource",
			"mailMergeRecipientData",
			"mailMergeSource",
			"notesMaster",
			"notesSlide",
			"numbering",
			"officeDocument",
			"oleObject",
			"package",
			"pivotCacheDefInition",
			"pivotCacheRecords",
			"pivotTable",
			"presProps",
			"printerSettings",
			"queryTable",
			"recipientData",
			"settings",
			"sharedStrings",
			"sheetMetadata",
			"slide",
			"slideLayout",
			"slideMaster",
			"slideUpdateInfo",
			"slideUpdateUrl",
			"styles",
			"table",
			"tableSingleCells",
			"tableStyles",
			"tags",
			"theme",
			"themeOverride",
			"transform",
			"video",
			"viewProps",
			"volatileDependencies",
			"webSettings",
			"worksheet",
			"xmlMaps",
			"ctrlProp",
			"customData",
			"diagram",
			"diagramColorsHeader",
			"diagramLayoutHeader",
			"diagramQuickStyleHeader",
			"documentParts",
			"slicer",
			"slicerCache",
			"vmlDrawing"
		};
	}
}
