using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005D2 RID: 1490
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MetadataType
	{
		// Token: 0x06004199 RID: 16793 RVA: 0x0009EC7C File Offset: 0x0009CE7C
		public CT_MetadataType()
		{
			this.ghostRowField = false;
			this.ghostColField = false;
			this.editField = false;
			this.deleteField = false;
			this.copyField = false;
			this.pasteAllField = false;
			this.pasteFormulasField = false;
			this.pasteValuesField = false;
			this.pasteFormatsField = false;
			this.pasteCommentsField = false;
			this.pasteDataValidationField = false;
			this.pasteBordersField = false;
			this.pasteColWidthsField = false;
			this.pasteNumberFormatsField = false;
			this.mergeField = false;
			this.splitFirstField = false;
			this.splitAllField = false;
			this.rowColShiftField = false;
			this.clearAllField = false;
			this.clearFormatsField = false;
			this.clearContentsField = false;
			this.clearCommentsField = false;
			this.assignField = false;
			this.coerceField = false;
			this.adjustField = false;
			this.cellMetaField = false;
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x0600419A RID: 16794 RVA: 0x0009ED45 File Offset: 0x0009CF45
		// (set) Token: 0x0600419B RID: 16795 RVA: 0x0009ED4D File Offset: 0x0009CF4D
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

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x0600419C RID: 16796 RVA: 0x0009ED56 File Offset: 0x0009CF56
		// (set) Token: 0x0600419D RID: 16797 RVA: 0x0009ED5E File Offset: 0x0009CF5E
		public uint minSupportedVersion
		{
			get
			{
				return this.minSupportedVersionField;
			}
			set
			{
				this.minSupportedVersionField = value;
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x0600419E RID: 16798 RVA: 0x0009ED67 File Offset: 0x0009CF67
		// (set) Token: 0x0600419F RID: 16799 RVA: 0x0009ED6F File Offset: 0x0009CF6F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ghostRow
		{
			get
			{
				return this.ghostRowField;
			}
			set
			{
				this.ghostRowField = value;
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x060041A0 RID: 16800 RVA: 0x0009ED78 File Offset: 0x0009CF78
		// (set) Token: 0x060041A1 RID: 16801 RVA: 0x0009ED80 File Offset: 0x0009CF80
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ghostCol
		{
			get
			{
				return this.ghostColField;
			}
			set
			{
				this.ghostColField = value;
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x060041A2 RID: 16802 RVA: 0x0009ED89 File Offset: 0x0009CF89
		// (set) Token: 0x060041A3 RID: 16803 RVA: 0x0009ED91 File Offset: 0x0009CF91
		[global::System.ComponentModel.DefaultValue(false)]
		public bool edit
		{
			get
			{
				return this.editField;
			}
			set
			{
				this.editField = value;
			}
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x060041A4 RID: 16804 RVA: 0x0009ED9A File Offset: 0x0009CF9A
		// (set) Token: 0x060041A5 RID: 16805 RVA: 0x0009EDA2 File Offset: 0x0009CFA2
		[global::System.ComponentModel.DefaultValue(false)]
		public bool delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x060041A6 RID: 16806 RVA: 0x0009EDAB File Offset: 0x0009CFAB
		// (set) Token: 0x060041A7 RID: 16807 RVA: 0x0009EDB3 File Offset: 0x0009CFB3
		[global::System.ComponentModel.DefaultValue(false)]
		public bool copy
		{
			get
			{
				return this.copyField;
			}
			set
			{
				this.copyField = value;
			}
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x060041A8 RID: 16808 RVA: 0x0009EDBC File Offset: 0x0009CFBC
		// (set) Token: 0x060041A9 RID: 16809 RVA: 0x0009EDC4 File Offset: 0x0009CFC4
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pasteAll
		{
			get
			{
				return this.pasteAllField;
			}
			set
			{
				this.pasteAllField = value;
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x060041AA RID: 16810 RVA: 0x0009EDCD File Offset: 0x0009CFCD
		// (set) Token: 0x060041AB RID: 16811 RVA: 0x0009EDD5 File Offset: 0x0009CFD5
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pasteFormulas
		{
			get
			{
				return this.pasteFormulasField;
			}
			set
			{
				this.pasteFormulasField = value;
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x060041AC RID: 16812 RVA: 0x0009EDDE File Offset: 0x0009CFDE
		// (set) Token: 0x060041AD RID: 16813 RVA: 0x0009EDE6 File Offset: 0x0009CFE6
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pasteValues
		{
			get
			{
				return this.pasteValuesField;
			}
			set
			{
				this.pasteValuesField = value;
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x060041AE RID: 16814 RVA: 0x0009EDEF File Offset: 0x0009CFEF
		// (set) Token: 0x060041AF RID: 16815 RVA: 0x0009EDF7 File Offset: 0x0009CFF7
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pasteFormats
		{
			get
			{
				return this.pasteFormatsField;
			}
			set
			{
				this.pasteFormatsField = value;
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x060041B0 RID: 16816 RVA: 0x0009EE00 File Offset: 0x0009D000
		// (set) Token: 0x060041B1 RID: 16817 RVA: 0x0009EE08 File Offset: 0x0009D008
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pasteComments
		{
			get
			{
				return this.pasteCommentsField;
			}
			set
			{
				this.pasteCommentsField = value;
			}
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x060041B2 RID: 16818 RVA: 0x0009EE11 File Offset: 0x0009D011
		// (set) Token: 0x060041B3 RID: 16819 RVA: 0x0009EE19 File Offset: 0x0009D019
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pasteDataValidation
		{
			get
			{
				return this.pasteDataValidationField;
			}
			set
			{
				this.pasteDataValidationField = value;
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x060041B4 RID: 16820 RVA: 0x0009EE22 File Offset: 0x0009D022
		// (set) Token: 0x060041B5 RID: 16821 RVA: 0x0009EE2A File Offset: 0x0009D02A
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pasteBorders
		{
			get
			{
				return this.pasteBordersField;
			}
			set
			{
				this.pasteBordersField = value;
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x060041B6 RID: 16822 RVA: 0x0009EE33 File Offset: 0x0009D033
		// (set) Token: 0x060041B7 RID: 16823 RVA: 0x0009EE3B File Offset: 0x0009D03B
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pasteColWidths
		{
			get
			{
				return this.pasteColWidthsField;
			}
			set
			{
				this.pasteColWidthsField = value;
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x060041B8 RID: 16824 RVA: 0x0009EE44 File Offset: 0x0009D044
		// (set) Token: 0x060041B9 RID: 16825 RVA: 0x0009EE4C File Offset: 0x0009D04C
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pasteNumberFormats
		{
			get
			{
				return this.pasteNumberFormatsField;
			}
			set
			{
				this.pasteNumberFormatsField = value;
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x060041BA RID: 16826 RVA: 0x0009EE55 File Offset: 0x0009D055
		// (set) Token: 0x060041BB RID: 16827 RVA: 0x0009EE5D File Offset: 0x0009D05D
		[global::System.ComponentModel.DefaultValue(false)]
		public bool merge
		{
			get
			{
				return this.mergeField;
			}
			set
			{
				this.mergeField = value;
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x060041BC RID: 16828 RVA: 0x0009EE66 File Offset: 0x0009D066
		// (set) Token: 0x060041BD RID: 16829 RVA: 0x0009EE6E File Offset: 0x0009D06E
		[global::System.ComponentModel.DefaultValue(false)]
		public bool splitFirst
		{
			get
			{
				return this.splitFirstField;
			}
			set
			{
				this.splitFirstField = value;
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x060041BE RID: 16830 RVA: 0x0009EE77 File Offset: 0x0009D077
		// (set) Token: 0x060041BF RID: 16831 RVA: 0x0009EE7F File Offset: 0x0009D07F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool splitAll
		{
			get
			{
				return this.splitAllField;
			}
			set
			{
				this.splitAllField = value;
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x060041C0 RID: 16832 RVA: 0x0009EE88 File Offset: 0x0009D088
		// (set) Token: 0x060041C1 RID: 16833 RVA: 0x0009EE90 File Offset: 0x0009D090
		[global::System.ComponentModel.DefaultValue(false)]
		public bool rowColShift
		{
			get
			{
				return this.rowColShiftField;
			}
			set
			{
				this.rowColShiftField = value;
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x060041C2 RID: 16834 RVA: 0x0009EE99 File Offset: 0x0009D099
		// (set) Token: 0x060041C3 RID: 16835 RVA: 0x0009EEA1 File Offset: 0x0009D0A1
		[global::System.ComponentModel.DefaultValue(false)]
		public bool clearAll
		{
			get
			{
				return this.clearAllField;
			}
			set
			{
				this.clearAllField = value;
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x060041C4 RID: 16836 RVA: 0x0009EEAA File Offset: 0x0009D0AA
		// (set) Token: 0x060041C5 RID: 16837 RVA: 0x0009EEB2 File Offset: 0x0009D0B2
		[global::System.ComponentModel.DefaultValue(false)]
		public bool clearFormats
		{
			get
			{
				return this.clearFormatsField;
			}
			set
			{
				this.clearFormatsField = value;
			}
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x060041C6 RID: 16838 RVA: 0x0009EEBB File Offset: 0x0009D0BB
		// (set) Token: 0x060041C7 RID: 16839 RVA: 0x0009EEC3 File Offset: 0x0009D0C3
		[global::System.ComponentModel.DefaultValue(false)]
		public bool clearContents
		{
			get
			{
				return this.clearContentsField;
			}
			set
			{
				this.clearContentsField = value;
			}
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x060041C8 RID: 16840 RVA: 0x0009EECC File Offset: 0x0009D0CC
		// (set) Token: 0x060041C9 RID: 16841 RVA: 0x0009EED4 File Offset: 0x0009D0D4
		[global::System.ComponentModel.DefaultValue(false)]
		public bool clearComments
		{
			get
			{
				return this.clearCommentsField;
			}
			set
			{
				this.clearCommentsField = value;
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x060041CA RID: 16842 RVA: 0x0009EEDD File Offset: 0x0009D0DD
		// (set) Token: 0x060041CB RID: 16843 RVA: 0x0009EEE5 File Offset: 0x0009D0E5
		[global::System.ComponentModel.DefaultValue(false)]
		public bool assign
		{
			get
			{
				return this.assignField;
			}
			set
			{
				this.assignField = value;
			}
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x060041CC RID: 16844 RVA: 0x0009EEEE File Offset: 0x0009D0EE
		// (set) Token: 0x060041CD RID: 16845 RVA: 0x0009EEF6 File Offset: 0x0009D0F6
		[global::System.ComponentModel.DefaultValue(false)]
		public bool coerce
		{
			get
			{
				return this.coerceField;
			}
			set
			{
				this.coerceField = value;
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x060041CE RID: 16846 RVA: 0x0009EEFF File Offset: 0x0009D0FF
		// (set) Token: 0x060041CF RID: 16847 RVA: 0x0009EF07 File Offset: 0x0009D107
		[global::System.ComponentModel.DefaultValue(false)]
		public bool adjust
		{
			get
			{
				return this.adjustField;
			}
			set
			{
				this.adjustField = value;
			}
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x060041D0 RID: 16848 RVA: 0x0009EF10 File Offset: 0x0009D110
		// (set) Token: 0x060041D1 RID: 16849 RVA: 0x0009EF18 File Offset: 0x0009D118
		[global::System.ComponentModel.DefaultValue(false)]
		public bool cellMeta
		{
			get
			{
				return this.cellMetaField;
			}
			set
			{
				this.cellMetaField = value;
			}
		}

		// Token: 0x04002956 RID: 10582
		private string nameField;

		// Token: 0x04002957 RID: 10583
		private uint minSupportedVersionField;

		// Token: 0x04002958 RID: 10584
		private bool ghostRowField;

		// Token: 0x04002959 RID: 10585
		private bool ghostColField;

		// Token: 0x0400295A RID: 10586
		private bool editField;

		// Token: 0x0400295B RID: 10587
		private bool deleteField;

		// Token: 0x0400295C RID: 10588
		private bool copyField;

		// Token: 0x0400295D RID: 10589
		private bool pasteAllField;

		// Token: 0x0400295E RID: 10590
		private bool pasteFormulasField;

		// Token: 0x0400295F RID: 10591
		private bool pasteValuesField;

		// Token: 0x04002960 RID: 10592
		private bool pasteFormatsField;

		// Token: 0x04002961 RID: 10593
		private bool pasteCommentsField;

		// Token: 0x04002962 RID: 10594
		private bool pasteDataValidationField;

		// Token: 0x04002963 RID: 10595
		private bool pasteBordersField;

		// Token: 0x04002964 RID: 10596
		private bool pasteColWidthsField;

		// Token: 0x04002965 RID: 10597
		private bool pasteNumberFormatsField;

		// Token: 0x04002966 RID: 10598
		private bool mergeField;

		// Token: 0x04002967 RID: 10599
		private bool splitFirstField;

		// Token: 0x04002968 RID: 10600
		private bool splitAllField;

		// Token: 0x04002969 RID: 10601
		private bool rowColShiftField;

		// Token: 0x0400296A RID: 10602
		private bool clearAllField;

		// Token: 0x0400296B RID: 10603
		private bool clearFormatsField;

		// Token: 0x0400296C RID: 10604
		private bool clearContentsField;

		// Token: 0x0400296D RID: 10605
		private bool clearCommentsField;

		// Token: 0x0400296E RID: 10606
		private bool assignField;

		// Token: 0x0400296F RID: 10607
		private bool coerceField;

		// Token: 0x04002970 RID: 10608
		private bool adjustField;

		// Token: 0x04002971 RID: 10609
		private bool cellMetaField;
	}
}
