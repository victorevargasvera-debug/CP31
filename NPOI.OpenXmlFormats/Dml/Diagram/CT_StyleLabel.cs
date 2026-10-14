using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003C3 RID: 963
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_StyleLabel
	{
		// Token: 0x060025E0 RID: 9696 RVA: 0x0005E899 File Offset: 0x0005CA99
		public CT_StyleLabel()
		{
			this.txPrField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_TextProps();
			this.scene3dField = new global::NPOI.OpenXmlFormats.Dml.CT_Scene3D();
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x0005E8B7 File Offset: 0x0005CAB7
		// (set) Token: 0x060025E2 RID: 9698 RVA: 0x0005E8BF File Offset: 0x0005CABF
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Scene3D scene3d
		{
			get
			{
				return this.scene3dField;
			}
			set
			{
				this.scene3dField = value;
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x0005E8C8 File Offset: 0x0005CAC8
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x0005E8D0 File Offset: 0x0005CAD0
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Shape3D sp3d
		{
			get
			{
				return this.sp3dField;
			}
			set
			{
				this.sp3dField = value;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x0005E8D9 File Offset: 0x0005CAD9
		// (set) Token: 0x060025E6 RID: 9702 RVA: 0x0005E8E1 File Offset: 0x0005CAE1
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_TextProps txPr
		{
			get
			{
				return this.txPrField;
			}
			set
			{
				this.txPrField = value;
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x0005E8EA File Offset: 0x0005CAEA
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x0005E8F2 File Offset: 0x0005CAF2
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle style
		{
			get
			{
				return this.styleField;
			}
			set
			{
				this.styleField = value;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x0005E8FB File Offset: 0x0005CAFB
		// (set) Token: 0x060025EA RID: 9706 RVA: 0x0005E903 File Offset: 0x0005CB03
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x0005E90C File Offset: 0x0005CB0C
		// (set) Token: 0x060025EC RID: 9708 RVA: 0x0005E914 File Offset: 0x0005CB14
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

		// Token: 0x04001C5C RID: 7260
		private global::NPOI.OpenXmlFormats.Dml.CT_Scene3D scene3dField;

		// Token: 0x04001C5D RID: 7261
		private global::NPOI.OpenXmlFormats.Dml.CT_Shape3D sp3dField;

		// Token: 0x04001C5E RID: 7262
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_TextProps txPrField;

		// Token: 0x04001C5F RID: 7263
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle styleField;

		// Token: 0x04001C60 RID: 7264
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001C61 RID: 7265
		private string nameField;
	}
}
