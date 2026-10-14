using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000254 RID: 596
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TableCellBorderStyle
	{
		// Token: 0x0600182F RID: 6191 RVA: 0x000438CC File Offset: 0x00041ACC
		public CT_TableCellBorderStyle()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
			this.tr2blField = new global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle();
			this.tl2brField = new global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle();
			this.insideVField = new global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle();
			this.insideHField = new global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle();
			this.bottomField = new global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle();
			this.topField = new global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle();
			this.rightField = new global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle();
			this.leftField = new global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle();
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x00043942 File Offset: 0x00041B42
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x0004394A File Offset: 0x00041B4A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle left
		{
			get
			{
				return this.leftField;
			}
			set
			{
				this.leftField = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x00043953 File Offset: 0x00041B53
		// (set) Token: 0x06001833 RID: 6195 RVA: 0x0004395B File Offset: 0x00041B5B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle right
		{
			get
			{
				return this.rightField;
			}
			set
			{
				this.rightField = value;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x00043964 File Offset: 0x00041B64
		// (set) Token: 0x06001835 RID: 6197 RVA: 0x0004396C File Offset: 0x00041B6C
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle top
		{
			get
			{
				return this.topField;
			}
			set
			{
				this.topField = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x00043975 File Offset: 0x00041B75
		// (set) Token: 0x06001837 RID: 6199 RVA: 0x0004397D File Offset: 0x00041B7D
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle bottom
		{
			get
			{
				return this.bottomField;
			}
			set
			{
				this.bottomField = value;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x00043986 File Offset: 0x00041B86
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x0004398E File Offset: 0x00041B8E
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle insideH
		{
			get
			{
				return this.insideHField;
			}
			set
			{
				this.insideHField = value;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x00043997 File Offset: 0x00041B97
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x0004399F File Offset: 0x00041B9F
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle insideV
		{
			get
			{
				return this.insideVField;
			}
			set
			{
				this.insideVField = value;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x000439A8 File Offset: 0x00041BA8
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x000439B0 File Offset: 0x00041BB0
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle tl2br
		{
			get
			{
				return this.tl2brField;
			}
			set
			{
				this.tl2brField = value;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x000439B9 File Offset: 0x00041BB9
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x000439C1 File Offset: 0x00041BC1
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle tr2bl
		{
			get
			{
				return this.tr2blField;
			}
			set
			{
				this.tr2blField = value;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x000439CA File Offset: 0x00041BCA
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x000439D2 File Offset: 0x00041BD2
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
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

		// Token: 0x0400129B RID: 4763
		private global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle leftField;

		// Token: 0x0400129C RID: 4764
		private global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle rightField;

		// Token: 0x0400129D RID: 4765
		private global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle topField;

		// Token: 0x0400129E RID: 4766
		private global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle bottomField;

		// Token: 0x0400129F RID: 4767
		private global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle insideHField;

		// Token: 0x040012A0 RID: 4768
		private global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle insideVField;

		// Token: 0x040012A1 RID: 4769
		private global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle tl2brField;

		// Token: 0x040012A2 RID: 4770
		private global::NPOI.OpenXmlFormats.Dml.CT_ThemeableLineStyle tr2blField;

		// Token: 0x040012A3 RID: 4771
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
