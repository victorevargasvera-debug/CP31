using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000565 RID: 1381
	public class CT_RevisionFormatting
	{
		// Token: 0x06003C3A RID: 15418 RVA: 0x000934EF File Offset: 0x000916EF
		public CT_RevisionFormatting()
		{
			this.sqrefField = new global::System.Collections.Generic.List<string>();
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.dxfField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf();
			this.xfDxfField = false;
			this.sField = false;
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x00093526 File Offset: 0x00091726
		// (set) Token: 0x06003C3C RID: 15420 RVA: 0x0009352E File Offset: 0x0009172E
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf dxf
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

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x00093537 File Offset: 0x00091737
		// (set) Token: 0x06003C3E RID: 15422 RVA: 0x0009353F File Offset: 0x0009173F
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

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x00093548 File Offset: 0x00091748
		// (set) Token: 0x06003C40 RID: 15424 RVA: 0x00093550 File Offset: 0x00091750
		public uint sheetId
		{
			get
			{
				return this.sheetIdField;
			}
			set
			{
				this.sheetIdField = value;
			}
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06003C41 RID: 15425 RVA: 0x00093559 File Offset: 0x00091759
		// (set) Token: 0x06003C42 RID: 15426 RVA: 0x00093561 File Offset: 0x00091761
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

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x0009356A File Offset: 0x0009176A
		// (set) Token: 0x06003C44 RID: 15428 RVA: 0x00093572 File Offset: 0x00091772
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

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06003C45 RID: 15429 RVA: 0x0009357B File Offset: 0x0009177B
		// (set) Token: 0x06003C46 RID: 15430 RVA: 0x00093583 File Offset: 0x00091783
		public global::System.Collections.Generic.List<string> sqref
		{
			get
			{
				return this.sqrefField;
			}
			set
			{
				this.sqrefField = value;
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06003C47 RID: 15431 RVA: 0x0009358C File Offset: 0x0009178C
		// (set) Token: 0x06003C48 RID: 15432 RVA: 0x00093594 File Offset: 0x00091794
		public uint start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
			}
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06003C49 RID: 15433 RVA: 0x0009359D File Offset: 0x0009179D
		// (set) Token: 0x06003C4A RID: 15434 RVA: 0x000935A5 File Offset: 0x000917A5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startSpecified
		{
			get
			{
				return this.startFieldSpecified;
			}
			set
			{
				this.startFieldSpecified = value;
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06003C4B RID: 15435 RVA: 0x000935AE File Offset: 0x000917AE
		// (set) Token: 0x06003C4C RID: 15436 RVA: 0x000935B6 File Offset: 0x000917B6
		public uint length
		{
			get
			{
				return this.lengthField;
			}
			set
			{
				this.lengthField = value;
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06003C4D RID: 15437 RVA: 0x000935BF File Offset: 0x000917BF
		// (set) Token: 0x06003C4E RID: 15438 RVA: 0x000935C7 File Offset: 0x000917C7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool lengthSpecified
		{
			get
			{
				return this.lengthFieldSpecified;
			}
			set
			{
				this.lengthFieldSpecified = value;
			}
		}

		// Token: 0x0400268E RID: 9870
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf dxfField;

		// Token: 0x0400268F RID: 9871
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002690 RID: 9872
		private uint sheetIdField;

		// Token: 0x04002691 RID: 9873
		private bool xfDxfField;

		// Token: 0x04002692 RID: 9874
		private bool sField;

		// Token: 0x04002693 RID: 9875
		private global::System.Collections.Generic.List<string> sqrefField;

		// Token: 0x04002694 RID: 9876
		private uint startField;

		// Token: 0x04002695 RID: 9877
		private bool startFieldSpecified;

		// Token: 0x04002696 RID: 9878
		private uint lengthField;

		// Token: 0x04002697 RID: 9879
		private bool lengthFieldSpecified;
	}
}
