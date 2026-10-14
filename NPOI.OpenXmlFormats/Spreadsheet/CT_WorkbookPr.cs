using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000623 RID: 1571
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_WorkbookPr
	{
		// Token: 0x06004458 RID: 17496 RVA: 0x000A264C File Offset: 0x000A084C
		public bool IsSetDate1904()
		{
			return this.date1904FieldSpecifiedField;
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x000A2654 File Offset: 0x000A0854
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookPr ct_WorkbookPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookPr();
			ct_WorkbookPr.date1904 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["date1904"]);
			ct_WorkbookPr.date1904Specified = (node.Attributes["date1904"] != null);
			if (node.Attributes["showObjects"] != null)
			{
				ct_WorkbookPr.showObjects = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects), node.Attributes["showObjects"].Value);
			}
			ct_WorkbookPr.showBorderUnselectedTables = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showBorderUnselectedTables"], true);
			ct_WorkbookPr.filterPrivacy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["filterPrivacy"]);
			ct_WorkbookPr.promptedSolutions = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["promptedSolutions"]);
			ct_WorkbookPr.showInkAnnotation = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showInkAnnotation"], true);
			ct_WorkbookPr.backupFile = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["backupFile"]);
			ct_WorkbookPr.saveExternalLinkValues = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["saveExternalLinkValues"], true);
			if (node.Attributes["updateLinks"] != null)
			{
				ct_WorkbookPr.updateLinks = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_UpdateLinks)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_UpdateLinks), node.Attributes["updateLinks"].Value);
			}
			ct_WorkbookPr.codeName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["codeName"]);
			ct_WorkbookPr.hidePivotFieldList = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidePivotFieldList"]);
			ct_WorkbookPr.showPivotChartFilter = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showPivotChartFilter"]);
			ct_WorkbookPr.allowRefreshQuery = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["allowRefreshQuery"]);
			ct_WorkbookPr.publishItems = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["publishItems"]);
			ct_WorkbookPr.checkCompatibility = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["checkCompatibility"]);
			ct_WorkbookPr.autoCompressPictures = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoCompressPictures"], false);
			ct_WorkbookPr.refreshAllConnections = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["refreshAllConnections"]);
			ct_WorkbookPr.defaultThemeVersion = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["defaultThemeVersion"]);
			return ct_WorkbookPr;
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x000A28BC File Offset: 0x000A0ABC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "date1904", this.date1904, false);
			if (this.showObjects != global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects.all)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showObjects", this.showObjects.ToString());
			}
			if (!this.showBorderUnselectedTables)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showBorderUnselectedTables", this.showBorderUnselectedTables);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "filterPrivacy", this.filterPrivacy, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "promptedSolutions", this.promptedSolutions, false);
			if (!this.showInkAnnotationField)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showInkAnnotation", this.showInkAnnotation, false);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "backupFile", this.backupFile, false);
			if (!this.saveExternalLinkValues)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "saveExternalLinkValues", this.saveExternalLinkValues);
			}
			if (this.updateLinks != global::NPOI.OpenXmlFormats.Spreadsheet.ST_UpdateLinks.userSet)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "updateLinks", this.updateLinks.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "codeName", this.codeName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidePivotFieldList", this.hidePivotFieldList, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showPivotChartFilter", this.showPivotChartFilter, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "allowRefreshQuery", this.allowRefreshQuery, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "publishItems", this.publishItems, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "checkCompatibility", this.checkCompatibility, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoCompressPictures", this.autoCompressPictures, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "refreshAllConnections", this.refreshAllConnections, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "defaultThemeVersion", this.defaultThemeVersion, false);
			sw.Write("/>");
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x000A2A68 File Offset: 0x000A0C68
		public CT_WorkbookPr()
		{
			this.date1904Field = false;
			this.showObjectsField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects.all;
			this.showBorderUnselectedTablesField = true;
			this.filterPrivacyField = false;
			this.promptedSolutionsField = false;
			this.showInkAnnotationField = true;
			this.backupFileField = false;
			this.saveExternalLinkValuesField = true;
			this.updateLinksField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_UpdateLinks.userSet;
			this.hidePivotFieldListField = false;
			this.showPivotChartFilterField = false;
			this.allowRefreshQueryField = false;
			this.publishItemsField = false;
			this.checkCompatibilityField = false;
			this.autoCompressPicturesField = true;
			this.refreshAllConnectionsField = false;
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x0600445C RID: 17500 RVA: 0x000A2AF2 File Offset: 0x000A0CF2
		// (set) Token: 0x0600445D RID: 17501 RVA: 0x000A2AFA File Offset: 0x000A0CFA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool date1904
		{
			get
			{
				return this.date1904Field;
			}
			set
			{
				this.date1904Field = value;
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x0600445E RID: 17502 RVA: 0x000A264C File Offset: 0x000A084C
		// (set) Token: 0x0600445F RID: 17503 RVA: 0x000A2B03 File Offset: 0x000A0D03
		[global::System.Xml.Serialization.XmlIgnore]
		public bool date1904Specified
		{
			get
			{
				return this.date1904FieldSpecifiedField;
			}
			set
			{
				this.date1904FieldSpecifiedField = value;
			}
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06004460 RID: 17504 RVA: 0x000A2B0C File Offset: 0x000A0D0C
		// (set) Token: 0x06004461 RID: 17505 RVA: 0x000A2B14 File Offset: 0x000A0D14
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects.all)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects showObjects
		{
			get
			{
				return this.showObjectsField;
			}
			set
			{
				this.showObjectsField = value;
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06004462 RID: 17506 RVA: 0x000A2B1D File Offset: 0x000A0D1D
		// (set) Token: 0x06004463 RID: 17507 RVA: 0x000A2B25 File Offset: 0x000A0D25
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showBorderUnselectedTables
		{
			get
			{
				return this.showBorderUnselectedTablesField;
			}
			set
			{
				this.showBorderUnselectedTablesField = value;
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06004464 RID: 17508 RVA: 0x000A2B2E File Offset: 0x000A0D2E
		// (set) Token: 0x06004465 RID: 17509 RVA: 0x000A2B36 File Offset: 0x000A0D36
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool filterPrivacy
		{
			get
			{
				return this.filterPrivacyField;
			}
			set
			{
				this.filterPrivacyField = value;
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x06004466 RID: 17510 RVA: 0x000A2B3F File Offset: 0x000A0D3F
		// (set) Token: 0x06004467 RID: 17511 RVA: 0x000A2B47 File Offset: 0x000A0D47
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool promptedSolutions
		{
			get
			{
				return this.promptedSolutionsField;
			}
			set
			{
				this.promptedSolutionsField = value;
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06004468 RID: 17512 RVA: 0x000A2B50 File Offset: 0x000A0D50
		// (set) Token: 0x06004469 RID: 17513 RVA: 0x000A2B58 File Offset: 0x000A0D58
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showInkAnnotation
		{
			get
			{
				return this.showInkAnnotationField;
			}
			set
			{
				this.showInkAnnotationField = value;
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x0600446A RID: 17514 RVA: 0x000A2B61 File Offset: 0x000A0D61
		// (set) Token: 0x0600446B RID: 17515 RVA: 0x000A2B69 File Offset: 0x000A0D69
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool backupFile
		{
			get
			{
				return this.backupFileField;
			}
			set
			{
				this.backupFileField = value;
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x0600446C RID: 17516 RVA: 0x000A2B72 File Offset: 0x000A0D72
		// (set) Token: 0x0600446D RID: 17517 RVA: 0x000A2B7A File Offset: 0x000A0D7A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool saveExternalLinkValues
		{
			get
			{
				return this.saveExternalLinkValuesField;
			}
			set
			{
				this.saveExternalLinkValuesField = value;
			}
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x0600446E RID: 17518 RVA: 0x000A2B83 File Offset: 0x000A0D83
		// (set) Token: 0x0600446F RID: 17519 RVA: 0x000A2B8B File Offset: 0x000A0D8B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_UpdateLinks.userSet)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_UpdateLinks updateLinks
		{
			get
			{
				return this.updateLinksField;
			}
			set
			{
				this.updateLinksField = value;
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06004470 RID: 17520 RVA: 0x000A2B94 File Offset: 0x000A0D94
		// (set) Token: 0x06004471 RID: 17521 RVA: 0x000A2B9C File Offset: 0x000A0D9C
		[global::System.Xml.Serialization.XmlAttribute]
		public string codeName
		{
			get
			{
				return this.codeNameField;
			}
			set
			{
				this.codeNameField = value;
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06004472 RID: 17522 RVA: 0x000A2BA5 File Offset: 0x000A0DA5
		// (set) Token: 0x06004473 RID: 17523 RVA: 0x000A2BAD File Offset: 0x000A0DAD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hidePivotFieldList
		{
			get
			{
				return this.hidePivotFieldListField;
			}
			set
			{
				this.hidePivotFieldListField = value;
			}
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x06004474 RID: 17524 RVA: 0x000A2BB6 File Offset: 0x000A0DB6
		// (set) Token: 0x06004475 RID: 17525 RVA: 0x000A2BBE File Offset: 0x000A0DBE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showPivotChartFilter
		{
			get
			{
				return this.showPivotChartFilterField;
			}
			set
			{
				this.showPivotChartFilterField = value;
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x06004476 RID: 17526 RVA: 0x000A2BC7 File Offset: 0x000A0DC7
		// (set) Token: 0x06004477 RID: 17527 RVA: 0x000A2BCF File Offset: 0x000A0DCF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool allowRefreshQuery
		{
			get
			{
				return this.allowRefreshQueryField;
			}
			set
			{
				this.allowRefreshQueryField = value;
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x06004478 RID: 17528 RVA: 0x000A2BD8 File Offset: 0x000A0DD8
		// (set) Token: 0x06004479 RID: 17529 RVA: 0x000A2BE0 File Offset: 0x000A0DE0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool publishItems
		{
			get
			{
				return this.publishItemsField;
			}
			set
			{
				this.publishItemsField = value;
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x0600447A RID: 17530 RVA: 0x000A2BE9 File Offset: 0x000A0DE9
		// (set) Token: 0x0600447B RID: 17531 RVA: 0x000A2BF1 File Offset: 0x000A0DF1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool checkCompatibility
		{
			get
			{
				return this.checkCompatibilityField;
			}
			set
			{
				this.checkCompatibilityField = value;
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x0600447C RID: 17532 RVA: 0x000A2BFA File Offset: 0x000A0DFA
		// (set) Token: 0x0600447D RID: 17533 RVA: 0x000A2C02 File Offset: 0x000A0E02
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool autoCompressPictures
		{
			get
			{
				return this.autoCompressPicturesField;
			}
			set
			{
				this.autoCompressPicturesField = value;
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x000A2C0B File Offset: 0x000A0E0B
		// (set) Token: 0x0600447F RID: 17535 RVA: 0x000A2C13 File Offset: 0x000A0E13
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool refreshAllConnections
		{
			get
			{
				return this.refreshAllConnectionsField;
			}
			set
			{
				this.refreshAllConnectionsField = value;
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06004480 RID: 17536 RVA: 0x000A2C1C File Offset: 0x000A0E1C
		// (set) Token: 0x06004481 RID: 17537 RVA: 0x000A2C24 File Offset: 0x000A0E24
		[global::System.Xml.Serialization.XmlAttribute]
		public uint defaultThemeVersion
		{
			get
			{
				return this.defaultThemeVersionField;
			}
			set
			{
				this.defaultThemeVersionField = value;
			}
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x06004482 RID: 17538 RVA: 0x000A2C2D File Offset: 0x000A0E2D
		// (set) Token: 0x06004483 RID: 17539 RVA: 0x000A2C35 File Offset: 0x000A0E35
		[global::System.Xml.Serialization.XmlIgnore]
		public bool defaultThemeVersionSpecified
		{
			get
			{
				return this.defaultThemeVersionFieldSpecified;
			}
			set
			{
				this.defaultThemeVersionFieldSpecified = value;
			}
		}

		// Token: 0x04002AEA RID: 10986
		private bool date1904Field;

		// Token: 0x04002AEB RID: 10987
		private bool date1904FieldSpecifiedField = true;

		// Token: 0x04002AEC RID: 10988
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects showObjectsField;

		// Token: 0x04002AED RID: 10989
		private bool showBorderUnselectedTablesField;

		// Token: 0x04002AEE RID: 10990
		private bool filterPrivacyField;

		// Token: 0x04002AEF RID: 10991
		private bool promptedSolutionsField;

		// Token: 0x04002AF0 RID: 10992
		private bool showInkAnnotationField;

		// Token: 0x04002AF1 RID: 10993
		private bool backupFileField;

		// Token: 0x04002AF2 RID: 10994
		private bool saveExternalLinkValuesField;

		// Token: 0x04002AF3 RID: 10995
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_UpdateLinks updateLinksField;

		// Token: 0x04002AF4 RID: 10996
		private string codeNameField;

		// Token: 0x04002AF5 RID: 10997
		private bool hidePivotFieldListField;

		// Token: 0x04002AF6 RID: 10998
		private bool showPivotChartFilterField;

		// Token: 0x04002AF7 RID: 10999
		private bool allowRefreshQueryField;

		// Token: 0x04002AF8 RID: 11000
		private bool publishItemsField;

		// Token: 0x04002AF9 RID: 11001
		private bool checkCompatibilityField;

		// Token: 0x04002AFA RID: 11002
		private bool autoCompressPicturesField;

		// Token: 0x04002AFB RID: 11003
		private bool refreshAllConnectionsField;

		// Token: 0x04002AFC RID: 11004
		private uint defaultThemeVersionField;

		// Token: 0x04002AFD RID: 11005
		private bool defaultThemeVersionFieldSpecified;
	}
}
