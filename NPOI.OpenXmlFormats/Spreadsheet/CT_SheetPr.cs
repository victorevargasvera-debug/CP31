using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000515 RID: 1301
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SheetPr
	{
		// Token: 0x0600389F RID: 14495 RVA: 0x0008CE48 File Offset: 0x0008B048
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr ct_SheetPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr();
			ct_SheetPr.syncHorizontal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["syncHorizontal"]);
			ct_SheetPr.syncVertical = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["syncVertical"]);
			ct_SheetPr.syncRef = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["syncRef"]);
			ct_SheetPr.transitionEvaluation = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["transitionEvaluation"]);
			ct_SheetPr.transitionEntry = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["transitionEntry"]);
			ct_SheetPr.published = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["published"]);
			ct_SheetPr.codeName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["codeName"]);
			ct_SheetPr.filterMode = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["filterMode"]);
			ct_SheetPr.enableFormatConditionsCalculation = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["enableFormatConditionsCalculation"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tabColor")
				{
					ct_SheetPr.tabColor = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "outlinePr")
				{
					ct_SheetPr.outlinePr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageSetUpPr")
				{
					ct_SheetPr.pageSetUpPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SheetPr;
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x0008CFFC File Offset: 0x0008B1FC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "syncHorizontal", this.syncHorizontal, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "syncVertical", this.syncVertical, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "syncRef", this.syncRef);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "transitionEvaluation", this.transitionEvaluation, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "transitionEntry", this.transitionEntry, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "published", this.published, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "codeName", this.codeName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "filterMode", this.filterMode, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "enableFormatConditionsCalculation", this.enableFormatConditionsCalculation, false);
			sw.Write(">");
			if (this.tabColor != null)
			{
				this.tabColor.Write(sw, "tabColor");
			}
			if (this.outlinePr != null)
			{
				this.outlinePr.Write(sw, "outlinePr");
			}
			if (this.pageSetUpPr != null)
			{
				this.pageSetUpPr.Write(sw, "pageSetUpPr");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x0008D121 File Offset: 0x0008B321
		public CT_SheetPr()
		{
			this.syncHorizontalField = false;
			this.syncVerticalField = false;
			this.transitionEvaluationField = false;
			this.transitionEntryField = false;
			this.publishedField = true;
			this.filterModeField = false;
			this.enableFormatConditionsCalculationField = true;
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x0008D15C File Offset: 0x0008B35C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr Clone()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr ct_SheetPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr();
			ct_SheetPr.codeNameField = this.codeNameField;
			ct_SheetPr.enableFormatConditionsCalculationField = this.enableFormatConditionsCalculationField;
			ct_SheetPr.filterModeField = this.filterModeField;
			ct_SheetPr.publishedField = this.publishedField;
			ct_SheetPr.syncHorizontalField = this.syncHorizontalField;
			ct_SheetPr.syncRefField = this.syncRefField;
			ct_SheetPr.syncVerticalField = this.syncVerticalField;
			ct_SheetPr.transitionEntryField = this.transitionEntryField;
			ct_SheetPr.transitionEvaluationField = this.transitionEvaluationField;
			if (this.outlinePrField != null)
			{
				ct_SheetPr.outlinePrField = this.outlinePrField.Clone();
			}
			if (this.pageSetUpPrField != null)
			{
				ct_SheetPr.pageSetUpPrField = this.pageSetUpPrField.Clone();
			}
			if (this.tabColorField != null)
			{
				ct_SheetPr.tabColorField = this.tabColorField.Copy();
			}
			return ct_SheetPr;
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x0008D227 File Offset: 0x0008B427
		public bool IsSetOutlinePr()
		{
			return this.outlinePrField != null;
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x0008D232 File Offset: 0x0008B432
		public bool IsSetPageSetUpPr()
		{
			return this.pageSetUpPrField != null;
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x0008D23D File Offset: 0x0008B43D
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr AddNewPageSetUpPr()
		{
			this.pageSetUpPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr();
			return this.pageSetUpPrField;
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x0008D250 File Offset: 0x0008B450
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr AddNewOutlinePr()
		{
			this.outlinePrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr();
			return this.outlinePrField;
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x060038A7 RID: 14503 RVA: 0x0008D263 File Offset: 0x0008B463
		// (set) Token: 0x060038A8 RID: 14504 RVA: 0x0008D26B File Offset: 0x0008B46B
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color tabColor
		{
			get
			{
				return this.tabColorField;
			}
			set
			{
				this.tabColorField = value;
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x060038A9 RID: 14505 RVA: 0x0008D274 File Offset: 0x0008B474
		// (set) Token: 0x060038AA RID: 14506 RVA: 0x0008D27C File Offset: 0x0008B47C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr outlinePr
		{
			get
			{
				return this.outlinePrField;
			}
			set
			{
				this.outlinePrField = value;
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x060038AB RID: 14507 RVA: 0x0008D285 File Offset: 0x0008B485
		// (set) Token: 0x060038AC RID: 14508 RVA: 0x0008D28D File Offset: 0x0008B48D
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr pageSetUpPr
		{
			get
			{
				return this.pageSetUpPrField;
			}
			set
			{
				this.pageSetUpPrField = value;
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x060038AD RID: 14509 RVA: 0x0008D296 File Offset: 0x0008B496
		// (set) Token: 0x060038AE RID: 14510 RVA: 0x0008D29E File Offset: 0x0008B49E
		[global::System.ComponentModel.DefaultValue(false)]
		public bool syncHorizontal
		{
			get
			{
				return this.syncHorizontalField;
			}
			set
			{
				this.syncHorizontalField = value;
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x060038AF RID: 14511 RVA: 0x0008D2A7 File Offset: 0x0008B4A7
		// (set) Token: 0x060038B0 RID: 14512 RVA: 0x0008D2AF File Offset: 0x0008B4AF
		[global::System.ComponentModel.DefaultValue(false)]
		public bool syncVertical
		{
			get
			{
				return this.syncVerticalField;
			}
			set
			{
				this.syncVerticalField = value;
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x060038B1 RID: 14513 RVA: 0x0008D2B8 File Offset: 0x0008B4B8
		// (set) Token: 0x060038B2 RID: 14514 RVA: 0x0008D2C0 File Offset: 0x0008B4C0
		public string syncRef
		{
			get
			{
				return this.syncRefField;
			}
			set
			{
				this.syncRefField = value;
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x060038B3 RID: 14515 RVA: 0x0008D2C9 File Offset: 0x0008B4C9
		// (set) Token: 0x060038B4 RID: 14516 RVA: 0x0008D2D1 File Offset: 0x0008B4D1
		[global::System.ComponentModel.DefaultValue(false)]
		public bool transitionEvaluation
		{
			get
			{
				return this.transitionEvaluationField;
			}
			set
			{
				this.transitionEvaluationField = value;
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x060038B5 RID: 14517 RVA: 0x0008D2DA File Offset: 0x0008B4DA
		// (set) Token: 0x060038B6 RID: 14518 RVA: 0x0008D2E2 File Offset: 0x0008B4E2
		[global::System.ComponentModel.DefaultValue(false)]
		public bool transitionEntry
		{
			get
			{
				return this.transitionEntryField;
			}
			set
			{
				this.transitionEntryField = value;
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x060038B7 RID: 14519 RVA: 0x0008D2EB File Offset: 0x0008B4EB
		// (set) Token: 0x060038B8 RID: 14520 RVA: 0x0008D2F3 File Offset: 0x0008B4F3
		[global::System.ComponentModel.DefaultValue(true)]
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

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x060038B9 RID: 14521 RVA: 0x0008D2FC File Offset: 0x0008B4FC
		// (set) Token: 0x060038BA RID: 14522 RVA: 0x0008D304 File Offset: 0x0008B504
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

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x060038BB RID: 14523 RVA: 0x0008D30D File Offset: 0x0008B50D
		// (set) Token: 0x060038BC RID: 14524 RVA: 0x0008D315 File Offset: 0x0008B515
		[global::System.ComponentModel.DefaultValue(false)]
		public bool filterMode
		{
			get
			{
				return this.filterModeField;
			}
			set
			{
				this.filterModeField = value;
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x060038BD RID: 14525 RVA: 0x0008D31E File Offset: 0x0008B51E
		// (set) Token: 0x060038BE RID: 14526 RVA: 0x0008D326 File Offset: 0x0008B526
		[global::System.ComponentModel.DefaultValue(true)]
		public bool enableFormatConditionsCalculation
		{
			get
			{
				return this.enableFormatConditionsCalculationField;
			}
			set
			{
				this.enableFormatConditionsCalculationField = value;
			}
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x0008D32F File Offset: 0x0008B52F
		public bool IsSetTabColor()
		{
			return this.tabColor != null;
		}

		// Token: 0x0400246E RID: 9326
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color tabColorField;

		// Token: 0x0400246F RID: 9327
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr outlinePrField;

		// Token: 0x04002470 RID: 9328
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr pageSetUpPrField;

		// Token: 0x04002471 RID: 9329
		private bool syncHorizontalField;

		// Token: 0x04002472 RID: 9330
		private bool syncVerticalField;

		// Token: 0x04002473 RID: 9331
		private string syncRefField;

		// Token: 0x04002474 RID: 9332
		private bool transitionEvaluationField;

		// Token: 0x04002475 RID: 9333
		private bool transitionEntryField;

		// Token: 0x04002476 RID: 9334
		private bool publishedField;

		// Token: 0x04002477 RID: 9335
		private string codeNameField;

		// Token: 0x04002478 RID: 9336
		private bool filterModeField;

		// Token: 0x04002479 RID: 9337
		private bool enableFormatConditionsCalculationField;
	}
}
