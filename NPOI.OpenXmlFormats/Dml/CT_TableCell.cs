using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200024D RID: 589
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TableCell
	{
		// Token: 0x060017CD RID: 6093 RVA: 0x000434F9 File Offset: 0x000416F9
		public CT_TableCell()
		{
			this.rowSpanField = 1;
			this.gridSpanField = 1;
			this.hMergeField = false;
			this.vMergeField = false;
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x0004351D File Offset: 0x0004171D
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x00043525 File Offset: 0x00041725
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBody txBody
		{
			get
			{
				return this.txBodyField;
			}
			set
			{
				this.txBodyField = value;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0004352E File Offset: 0x0004172E
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x00043536 File Offset: 0x00041736
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TableCellProperties tcPr
		{
			get
			{
				return this.tcPrField;
			}
			set
			{
				this.tcPrField = value;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0004353F File Offset: 0x0004173F
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x00043547 File Offset: 0x00041747
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
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

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00043550 File Offset: 0x00041750
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x00043558 File Offset: 0x00041758
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(1)]
		public int rowSpan
		{
			get
			{
				return this.rowSpanField;
			}
			set
			{
				this.rowSpanField = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00043561 File Offset: 0x00041761
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x00043569 File Offset: 0x00041769
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(1)]
		public int gridSpan
		{
			get
			{
				return this.gridSpanField;
			}
			set
			{
				this.gridSpanField = value;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x00043572 File Offset: 0x00041772
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0004357A File Offset: 0x0004177A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hMerge
		{
			get
			{
				return this.hMergeField;
			}
			set
			{
				this.hMergeField = value;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x00043583 File Offset: 0x00041783
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x0004358B File Offset: 0x0004178B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool vMerge
		{
			get
			{
				return this.vMergeField;
			}
			set
			{
				this.vMergeField = value;
			}
		}

		// Token: 0x04001269 RID: 4713
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBody txBodyField;

		// Token: 0x0400126A RID: 4714
		private global::NPOI.OpenXmlFormats.Dml.CT_TableCellProperties tcPrField;

		// Token: 0x0400126B RID: 4715
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x0400126C RID: 4716
		private int rowSpanField;

		// Token: 0x0400126D RID: 4717
		private int gridSpanField;

		// Token: 0x0400126E RID: 4718
		private bool hMergeField;

		// Token: 0x0400126F RID: 4719
		private bool vMergeField;
	}
}
