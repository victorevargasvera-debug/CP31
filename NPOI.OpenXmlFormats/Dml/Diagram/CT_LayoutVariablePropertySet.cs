using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003BF RID: 959
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LayoutVariablePropertySet
	{
		// Token: 0x060025B2 RID: 9650 RVA: 0x0005E62C File Offset: 0x0005C82C
		public CT_LayoutVariablePropertySet()
		{
			this.resizeHandlesField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ResizeHandles();
			this.animLvlField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_AnimLvl();
			this.animOneField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_AnimOne();
			this.hierBranchField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_HierBranchStyle();
			this.dirField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Direction();
			this.bulletEnabledField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_BulletEnabled();
			this.chPrefField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ChildPref();
			this.chMaxField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ChildMax();
			this.orgChartField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_OrgChart();
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x0005E6A2 File Offset: 0x0005C8A2
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x0005E6AA File Offset: 0x0005C8AA
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_OrgChart orgChart
		{
			get
			{
				return this.orgChartField;
			}
			set
			{
				this.orgChartField = value;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x0005E6B3 File Offset: 0x0005C8B3
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x0005E6BB File Offset: 0x0005C8BB
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ChildMax chMax
		{
			get
			{
				return this.chMaxField;
			}
			set
			{
				this.chMaxField = value;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x0005E6C4 File Offset: 0x0005C8C4
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x0005E6CC File Offset: 0x0005C8CC
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ChildPref chPref
		{
			get
			{
				return this.chPrefField;
			}
			set
			{
				this.chPrefField = value;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x0005E6D5 File Offset: 0x0005C8D5
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x0005E6DD File Offset: 0x0005C8DD
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_BulletEnabled bulletEnabled
		{
			get
			{
				return this.bulletEnabledField;
			}
			set
			{
				this.bulletEnabledField = value;
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x0005E6E6 File Offset: 0x0005C8E6
		// (set) Token: 0x060025BC RID: 9660 RVA: 0x0005E6EE File Offset: 0x0005C8EE
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Direction dir
		{
			get
			{
				return this.dirField;
			}
			set
			{
				this.dirField = value;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x0005E6F7 File Offset: 0x0005C8F7
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x0005E6FF File Offset: 0x0005C8FF
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_HierBranchStyle hierBranch
		{
			get
			{
				return this.hierBranchField;
			}
			set
			{
				this.hierBranchField = value;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x0005E708 File Offset: 0x0005C908
		// (set) Token: 0x060025C0 RID: 9664 RVA: 0x0005E710 File Offset: 0x0005C910
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_AnimOne animOne
		{
			get
			{
				return this.animOneField;
			}
			set
			{
				this.animOneField = value;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x0005E719 File Offset: 0x0005C919
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x0005E721 File Offset: 0x0005C921
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_AnimLvl animLvl
		{
			get
			{
				return this.animLvlField;
			}
			set
			{
				this.animLvlField = value;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x060025C3 RID: 9667 RVA: 0x0005E72A File Offset: 0x0005C92A
		// (set) Token: 0x060025C4 RID: 9668 RVA: 0x0005E732 File Offset: 0x0005C932
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ResizeHandles resizeHandles
		{
			get
			{
				return this.resizeHandlesField;
			}
			set
			{
				this.resizeHandlesField = value;
			}
		}

		// Token: 0x04001C47 RID: 7239
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_OrgChart orgChartField;

		// Token: 0x04001C48 RID: 7240
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ChildMax chMaxField;

		// Token: 0x04001C49 RID: 7241
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ChildPref chPrefField;

		// Token: 0x04001C4A RID: 7242
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_BulletEnabled bulletEnabledField;

		// Token: 0x04001C4B RID: 7243
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Direction dirField;

		// Token: 0x04001C4C RID: 7244
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_HierBranchStyle hierBranchField;

		// Token: 0x04001C4D RID: 7245
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_AnimOne animOneField;

		// Token: 0x04001C4E RID: 7246
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_AnimLvl animLvlField;

		// Token: 0x04001C4F RID: 7247
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ResizeHandles resizeHandlesField;
	}
}
