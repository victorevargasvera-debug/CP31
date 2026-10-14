using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200055F RID: 1375
	public class CT_RevisionCellChange
	{
		// Token: 0x06003BA9 RID: 15273 RVA: 0x00092F14 File Offset: 0x00091114
		public CT_RevisionCellChange()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.ndxfField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf();
			this.odxfField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf();
			this.ncField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell();
			this.ocField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell();
			this.uaField = false;
			this.raField = false;
			this.odxf1Field = false;
			this.xfDxfField = false;
			this.sField = false;
			this.dxfField = false;
			this.quotePrefixField = false;
			this.oldQuotePrefixField = false;
			this.phField = false;
			this.oldPhField = false;
			this.endOfListFormulaUpdateField = false;
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06003BAA RID: 15274 RVA: 0x00092FAB File Offset: 0x000911AB
		// (set) Token: 0x06003BAB RID: 15275 RVA: 0x00092FB3 File Offset: 0x000911B3
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell oc
		{
			get
			{
				return this.ocField;
			}
			set
			{
				this.ocField = value;
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06003BAC RID: 15276 RVA: 0x00092FBC File Offset: 0x000911BC
		// (set) Token: 0x06003BAD RID: 15277 RVA: 0x00092FC4 File Offset: 0x000911C4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell nc
		{
			get
			{
				return this.ncField;
			}
			set
			{
				this.ncField = value;
			}
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x00092FCD File Offset: 0x000911CD
		// (set) Token: 0x06003BAF RID: 15279 RVA: 0x00092FD5 File Offset: 0x000911D5
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf odxf
		{
			get
			{
				return this.odxfField;
			}
			set
			{
				this.odxfField = value;
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x00092FDE File Offset: 0x000911DE
		// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x00092FE6 File Offset: 0x000911E6
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf ndxf
		{
			get
			{
				return this.ndxfField;
			}
			set
			{
				this.ndxfField = value;
			}
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06003BB2 RID: 15282 RVA: 0x00092FEF File Offset: 0x000911EF
		// (set) Token: 0x06003BB3 RID: 15283 RVA: 0x00092FF7 File Offset: 0x000911F7
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

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x00093000 File Offset: 0x00091200
		// (set) Token: 0x06003BB5 RID: 15285 RVA: 0x00093008 File Offset: 0x00091208
		public uint rId
		{
			get
			{
				return this.rIdField;
			}
			set
			{
				this.rIdField = value;
			}
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x00093011 File Offset: 0x00091211
		// (set) Token: 0x06003BB7 RID: 15287 RVA: 0x00093019 File Offset: 0x00091219
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ua
		{
			get
			{
				return this.uaField;
			}
			set
			{
				this.uaField = value;
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06003BB8 RID: 15288 RVA: 0x00093022 File Offset: 0x00091222
		// (set) Token: 0x06003BB9 RID: 15289 RVA: 0x0009302A File Offset: 0x0009122A
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ra
		{
			get
			{
				return this.raField;
			}
			set
			{
				this.raField = value;
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06003BBA RID: 15290 RVA: 0x00093033 File Offset: 0x00091233
		// (set) Token: 0x06003BBB RID: 15291 RVA: 0x0009303B File Offset: 0x0009123B
		public uint sId
		{
			get
			{
				return this.sIdField;
			}
			set
			{
				this.sIdField = value;
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06003BBC RID: 15292 RVA: 0x00093044 File Offset: 0x00091244
		// (set) Token: 0x06003BBD RID: 15293 RVA: 0x0009304C File Offset: 0x0009124C
		[global::System.ComponentModel.DefaultValue(false)]
		public bool odxf1
		{
			get
			{
				return this.odxf1Field;
			}
			set
			{
				this.odxf1Field = value;
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06003BBE RID: 15294 RVA: 0x00093055 File Offset: 0x00091255
		// (set) Token: 0x06003BBF RID: 15295 RVA: 0x0009305D File Offset: 0x0009125D
		[global::System.ComponentModel.DefaultValue(false)]
		public bool xfDxf
		{
			get
			{
				return this.xfDxfField;
			}
			set
			{
				this.xfDxfField = value;
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x00093066 File Offset: 0x00091266
		// (set) Token: 0x06003BC1 RID: 15297 RVA: 0x0009306E File Offset: 0x0009126E
		[global::System.ComponentModel.DefaultValue(false)]
		public bool s
		{
			get
			{
				return this.sField;
			}
			set
			{
				this.sField = value;
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06003BC2 RID: 15298 RVA: 0x00093077 File Offset: 0x00091277
		// (set) Token: 0x06003BC3 RID: 15299 RVA: 0x0009307F File Offset: 0x0009127F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool dxf
		{
			get
			{
				return this.dxfField;
			}
			set
			{
				this.dxfField = value;
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x00093088 File Offset: 0x00091288
		// (set) Token: 0x06003BC5 RID: 15301 RVA: 0x00093090 File Offset: 0x00091290
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

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x00093099 File Offset: 0x00091299
		// (set) Token: 0x06003BC7 RID: 15303 RVA: 0x000930A1 File Offset: 0x000912A1
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

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x000930AA File Offset: 0x000912AA
		// (set) Token: 0x06003BC9 RID: 15305 RVA: 0x000930B2 File Offset: 0x000912B2
		[global::System.ComponentModel.DefaultValue(false)]
		public bool quotePrefix
		{
			get
			{
				return this.quotePrefixField;
			}
			set
			{
				this.quotePrefixField = value;
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06003BCA RID: 15306 RVA: 0x000930BB File Offset: 0x000912BB
		// (set) Token: 0x06003BCB RID: 15307 RVA: 0x000930C3 File Offset: 0x000912C3
		[global::System.ComponentModel.DefaultValue(false)]
		public bool oldQuotePrefix
		{
			get
			{
				return this.oldQuotePrefixField;
			}
			set
			{
				this.oldQuotePrefixField = value;
			}
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06003BCC RID: 15308 RVA: 0x000930CC File Offset: 0x000912CC
		// (set) Token: 0x06003BCD RID: 15309 RVA: 0x000930D4 File Offset: 0x000912D4
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ph
		{
			get
			{
				return this.phField;
			}
			set
			{
				this.phField = value;
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06003BCE RID: 15310 RVA: 0x000930DD File Offset: 0x000912DD
		// (set) Token: 0x06003BCF RID: 15311 RVA: 0x000930E5 File Offset: 0x000912E5
		[global::System.ComponentModel.DefaultValue(false)]
		public bool oldPh
		{
			get
			{
				return this.oldPhField;
			}
			set
			{
				this.oldPhField = value;
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x000930EE File Offset: 0x000912EE
		// (set) Token: 0x06003BD1 RID: 15313 RVA: 0x000930F6 File Offset: 0x000912F6
		[global::System.ComponentModel.DefaultValue(false)]
		public bool endOfListFormulaUpdate
		{
			get
			{
				return this.endOfListFormulaUpdateField;
			}
			set
			{
				this.endOfListFormulaUpdateField = value;
			}
		}

		// Token: 0x04002645 RID: 9797
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell ocField;

		// Token: 0x04002646 RID: 9798
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell ncField;

		// Token: 0x04002647 RID: 9799
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf odxfField;

		// Token: 0x04002648 RID: 9800
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf ndxfField;

		// Token: 0x04002649 RID: 9801
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x0400264A RID: 9802
		private uint rIdField;

		// Token: 0x0400264B RID: 9803
		private bool uaField;

		// Token: 0x0400264C RID: 9804
		private bool raField;

		// Token: 0x0400264D RID: 9805
		private uint sIdField;

		// Token: 0x0400264E RID: 9806
		private bool odxf1Field;

		// Token: 0x0400264F RID: 9807
		private bool xfDxfField;

		// Token: 0x04002650 RID: 9808
		private bool sField;

		// Token: 0x04002651 RID: 9809
		private bool dxfField;

		// Token: 0x04002652 RID: 9810
		private uint numFmtIdField;

		// Token: 0x04002653 RID: 9811
		private bool numFmtIdFieldSpecified;

		// Token: 0x04002654 RID: 9812
		private bool quotePrefixField;

		// Token: 0x04002655 RID: 9813
		private bool oldQuotePrefixField;

		// Token: 0x04002656 RID: 9814
		private bool phField;

		// Token: 0x04002657 RID: 9815
		private bool oldPhField;

		// Token: 0x04002658 RID: 9816
		private bool endOfListFormulaUpdateField;
	}
}
