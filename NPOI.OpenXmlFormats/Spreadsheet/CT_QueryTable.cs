using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005EC RID: 1516
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_QueryTable
	{
		// Token: 0x0600426D RID: 17005 RVA: 0x0009F6F4 File Offset: 0x0009D8F4
		public CT_QueryTable()
		{
			this.headersField = true;
			this.rowNumbersField = false;
			this.disableRefreshField = false;
			this.backgroundRefreshField = true;
			this.firstBackgroundRefreshField = false;
			this.refreshOnLoadField = false;
			this.growShrinkTypeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_GrowShrinkType.insertDelete;
			this.fillFormulasField = false;
			this.removeDataOnSaveField = false;
			this.disableEditField = false;
			this.preserveFormattingField = true;
			this.adjustColumnWidthField = true;
			this.intermediateField = false;
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x0009F762 File Offset: 0x0009D962
		// (set) Token: 0x0600426F RID: 17007 RVA: 0x0009F76A File Offset: 0x0009D96A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryTableRefresh queryTableRefresh
		{
			get
			{
				return this.queryTableRefreshField;
			}
			set
			{
				this.queryTableRefreshField = value;
			}
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x06004270 RID: 17008 RVA: 0x0009F773 File Offset: 0x0009D973
		// (set) Token: 0x06004271 RID: 17009 RVA: 0x0009F77B File Offset: 0x0009D97B
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

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x06004272 RID: 17010 RVA: 0x0009F784 File Offset: 0x0009D984
		// (set) Token: 0x06004273 RID: 17011 RVA: 0x0009F78C File Offset: 0x0009D98C
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

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x06004274 RID: 17012 RVA: 0x0009F795 File Offset: 0x0009D995
		// (set) Token: 0x06004275 RID: 17013 RVA: 0x0009F79D File Offset: 0x0009D99D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool headers
		{
			get
			{
				return this.headersField;
			}
			set
			{
				this.headersField = value;
			}
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x06004276 RID: 17014 RVA: 0x0009F7A6 File Offset: 0x0009D9A6
		// (set) Token: 0x06004277 RID: 17015 RVA: 0x0009F7AE File Offset: 0x0009D9AE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool rowNumbers
		{
			get
			{
				return this.rowNumbersField;
			}
			set
			{
				this.rowNumbersField = value;
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x06004278 RID: 17016 RVA: 0x0009F7B7 File Offset: 0x0009D9B7
		// (set) Token: 0x06004279 RID: 17017 RVA: 0x0009F7BF File Offset: 0x0009D9BF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool disableRefresh
		{
			get
			{
				return this.disableRefreshField;
			}
			set
			{
				this.disableRefreshField = value;
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x0600427A RID: 17018 RVA: 0x0009F7C8 File Offset: 0x0009D9C8
		// (set) Token: 0x0600427B RID: 17019 RVA: 0x0009F7D0 File Offset: 0x0009D9D0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool backgroundRefresh
		{
			get
			{
				return this.backgroundRefreshField;
			}
			set
			{
				this.backgroundRefreshField = value;
			}
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x0600427C RID: 17020 RVA: 0x0009F7D9 File Offset: 0x0009D9D9
		// (set) Token: 0x0600427D RID: 17021 RVA: 0x0009F7E1 File Offset: 0x0009D9E1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool firstBackgroundRefresh
		{
			get
			{
				return this.firstBackgroundRefreshField;
			}
			set
			{
				this.firstBackgroundRefreshField = value;
			}
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x0600427E RID: 17022 RVA: 0x0009F7EA File Offset: 0x0009D9EA
		// (set) Token: 0x0600427F RID: 17023 RVA: 0x0009F7F2 File Offset: 0x0009D9F2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool refreshOnLoad
		{
			get
			{
				return this.refreshOnLoadField;
			}
			set
			{
				this.refreshOnLoadField = value;
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x06004280 RID: 17024 RVA: 0x0009F7FB File Offset: 0x0009D9FB
		// (set) Token: 0x06004281 RID: 17025 RVA: 0x0009F803 File Offset: 0x0009DA03
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_GrowShrinkType.insertDelete)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_GrowShrinkType growShrinkType
		{
			get
			{
				return this.growShrinkTypeField;
			}
			set
			{
				this.growShrinkTypeField = value;
			}
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x06004282 RID: 17026 RVA: 0x0009F80C File Offset: 0x0009DA0C
		// (set) Token: 0x06004283 RID: 17027 RVA: 0x0009F814 File Offset: 0x0009DA14
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool fillFormulas
		{
			get
			{
				return this.fillFormulasField;
			}
			set
			{
				this.fillFormulasField = value;
			}
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x06004284 RID: 17028 RVA: 0x0009F81D File Offset: 0x0009DA1D
		// (set) Token: 0x06004285 RID: 17029 RVA: 0x0009F825 File Offset: 0x0009DA25
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool removeDataOnSave
		{
			get
			{
				return this.removeDataOnSaveField;
			}
			set
			{
				this.removeDataOnSaveField = value;
			}
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x06004286 RID: 17030 RVA: 0x0009F82E File Offset: 0x0009DA2E
		// (set) Token: 0x06004287 RID: 17031 RVA: 0x0009F836 File Offset: 0x0009DA36
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool disableEdit
		{
			get
			{
				return this.disableEditField;
			}
			set
			{
				this.disableEditField = value;
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x06004288 RID: 17032 RVA: 0x0009F83F File Offset: 0x0009DA3F
		// (set) Token: 0x06004289 RID: 17033 RVA: 0x0009F847 File Offset: 0x0009DA47
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

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x0009F850 File Offset: 0x0009DA50
		// (set) Token: 0x0600428B RID: 17035 RVA: 0x0009F858 File Offset: 0x0009DA58
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool adjustColumnWidth
		{
			get
			{
				return this.adjustColumnWidthField;
			}
			set
			{
				this.adjustColumnWidthField = value;
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x0600428C RID: 17036 RVA: 0x0009F861 File Offset: 0x0009DA61
		// (set) Token: 0x0600428D RID: 17037 RVA: 0x0009F869 File Offset: 0x0009DA69
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool intermediate
		{
			get
			{
				return this.intermediateField;
			}
			set
			{
				this.intermediateField = value;
			}
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x0600428E RID: 17038 RVA: 0x0009F872 File Offset: 0x0009DA72
		// (set) Token: 0x0600428F RID: 17039 RVA: 0x0009F87A File Offset: 0x0009DA7A
		[global::System.Xml.Serialization.XmlAttribute]
		public uint connectionId
		{
			get
			{
				return this.connectionIdField;
			}
			set
			{
				this.connectionIdField = value;
			}
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x0009F883 File Offset: 0x0009DA83
		// (set) Token: 0x06004291 RID: 17041 RVA: 0x0009F88B File Offset: 0x0009DA8B
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

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x0009F894 File Offset: 0x0009DA94
		// (set) Token: 0x06004293 RID: 17043 RVA: 0x0009F89C File Offset: 0x0009DA9C
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

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x0009F8A5 File Offset: 0x0009DAA5
		// (set) Token: 0x06004295 RID: 17045 RVA: 0x0009F8AD File Offset: 0x0009DAAD
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

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x0009F8B6 File Offset: 0x0009DAB6
		// (set) Token: 0x06004297 RID: 17047 RVA: 0x0009F8BE File Offset: 0x0009DABE
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

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06004298 RID: 17048 RVA: 0x0009F8C7 File Offset: 0x0009DAC7
		// (set) Token: 0x06004299 RID: 17049 RVA: 0x0009F8CF File Offset: 0x0009DACF
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

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x0600429A RID: 17050 RVA: 0x0009F8D8 File Offset: 0x0009DAD8
		// (set) Token: 0x0600429B RID: 17051 RVA: 0x0009F8E0 File Offset: 0x0009DAE0
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

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x0600429C RID: 17052 RVA: 0x0009F8E9 File Offset: 0x0009DAE9
		// (set) Token: 0x0600429D RID: 17053 RVA: 0x0009F8F1 File Offset: 0x0009DAF1
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

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x0009F8FA File Offset: 0x0009DAFA
		// (set) Token: 0x0600429F RID: 17055 RVA: 0x0009F902 File Offset: 0x0009DB02
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

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x060042A0 RID: 17056 RVA: 0x0009F90B File Offset: 0x0009DB0B
		// (set) Token: 0x060042A1 RID: 17057 RVA: 0x0009F913 File Offset: 0x0009DB13
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

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x0009F91C File Offset: 0x0009DB1C
		// (set) Token: 0x060042A3 RID: 17059 RVA: 0x0009F924 File Offset: 0x0009DB24
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

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x0009F92D File Offset: 0x0009DB2D
		// (set) Token: 0x060042A5 RID: 17061 RVA: 0x0009F935 File Offset: 0x0009DB35
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

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x060042A6 RID: 17062 RVA: 0x0009F93E File Offset: 0x0009DB3E
		// (set) Token: 0x060042A7 RID: 17063 RVA: 0x0009F946 File Offset: 0x0009DB46
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

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x0009F94F File Offset: 0x0009DB4F
		// (set) Token: 0x060042A9 RID: 17065 RVA: 0x0009F957 File Offset: 0x0009DB57
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

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x060042AA RID: 17066 RVA: 0x0009F960 File Offset: 0x0009DB60
		// (set) Token: 0x060042AB RID: 17067 RVA: 0x0009F968 File Offset: 0x0009DB68
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

		// Token: 0x04002A09 RID: 10761
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryTableRefresh queryTableRefreshField;

		// Token: 0x04002A0A RID: 10762
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002A0B RID: 10763
		private string nameField;

		// Token: 0x04002A0C RID: 10764
		private bool headersField;

		// Token: 0x04002A0D RID: 10765
		private bool rowNumbersField;

		// Token: 0x04002A0E RID: 10766
		private bool disableRefreshField;

		// Token: 0x04002A0F RID: 10767
		private bool backgroundRefreshField;

		// Token: 0x04002A10 RID: 10768
		private bool firstBackgroundRefreshField;

		// Token: 0x04002A11 RID: 10769
		private bool refreshOnLoadField;

		// Token: 0x04002A12 RID: 10770
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_GrowShrinkType growShrinkTypeField;

		// Token: 0x04002A13 RID: 10771
		private bool fillFormulasField;

		// Token: 0x04002A14 RID: 10772
		private bool removeDataOnSaveField;

		// Token: 0x04002A15 RID: 10773
		private bool disableEditField;

		// Token: 0x04002A16 RID: 10774
		private bool preserveFormattingField;

		// Token: 0x04002A17 RID: 10775
		private bool adjustColumnWidthField;

		// Token: 0x04002A18 RID: 10776
		private bool intermediateField;

		// Token: 0x04002A19 RID: 10777
		private uint connectionIdField;

		// Token: 0x04002A1A RID: 10778
		private uint autoFormatIdField;

		// Token: 0x04002A1B RID: 10779
		private bool autoFormatIdFieldSpecified;

		// Token: 0x04002A1C RID: 10780
		private bool applyNumberFormatsField;

		// Token: 0x04002A1D RID: 10781
		private bool applyNumberFormatsFieldSpecified;

		// Token: 0x04002A1E RID: 10782
		private bool applyBorderFormatsField;

		// Token: 0x04002A1F RID: 10783
		private bool applyBorderFormatsFieldSpecified;

		// Token: 0x04002A20 RID: 10784
		private bool applyFontFormatsField;

		// Token: 0x04002A21 RID: 10785
		private bool applyFontFormatsFieldSpecified;

		// Token: 0x04002A22 RID: 10786
		private bool applyPatternFormatsField;

		// Token: 0x04002A23 RID: 10787
		private bool applyPatternFormatsFieldSpecified;

		// Token: 0x04002A24 RID: 10788
		private bool applyAlignmentFormatsField;

		// Token: 0x04002A25 RID: 10789
		private bool applyAlignmentFormatsFieldSpecified;

		// Token: 0x04002A26 RID: 10790
		private bool applyWidthHeightFormatsField;

		// Token: 0x04002A27 RID: 10791
		private bool applyWidthHeightFormatsFieldSpecified;
	}
}
