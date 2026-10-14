using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003C0 RID: 960
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot("styleDef", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
	[global::System.Serializable]
	public class CT_StyleDefinition
	{
		// Token: 0x060025C5 RID: 9669 RVA: 0x0005E73C File Offset: 0x0005C93C
		public CT_StyleDefinition()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
			this.styleLblField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_StyleLabel>();
			this.scene3dField = new global::NPOI.OpenXmlFormats.Dml.CT_Scene3D();
			this.catLstField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDCategory>();
			this.descField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDDescription>();
			this.titleField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDName>();
			this.uniqueIdField = "";
			this.minVerField = "http://schemas.openxmlformats.org/drawingml/2006/diagram";
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x060025C6 RID: 9670 RVA: 0x0005E7A7 File Offset: 0x0005C9A7
		// (set) Token: 0x060025C7 RID: 9671 RVA: 0x0005E7AF File Offset: 0x0005C9AF
		[global::System.Xml.Serialization.XmlElement("title", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDName> title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x0005E7B8 File Offset: 0x0005C9B8
		// (set) Token: 0x060025C9 RID: 9673 RVA: 0x0005E7C0 File Offset: 0x0005C9C0
		[global::System.Xml.Serialization.XmlElement("desc", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDDescription> desc
		{
			get
			{
				return this.descField;
			}
			set
			{
				this.descField = value;
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x0005E7C9 File Offset: 0x0005C9C9
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x0005E7D1 File Offset: 0x0005C9D1
		[global::System.Xml.Serialization.XmlArray(Order = 2)]
		[global::System.Xml.Serialization.XmlArrayItem("cat", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDCategory> catLst
		{
			get
			{
				return this.catLstField;
			}
			set
			{
				this.catLstField = value;
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x0005E7DA File Offset: 0x0005C9DA
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x0005E7E2 File Offset: 0x0005C9E2
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x0005E7EB File Offset: 0x0005C9EB
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x0005E7F3 File Offset: 0x0005C9F3
		[global::System.Xml.Serialization.XmlElement("styleLbl", Order = 4)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_StyleLabel> styleLbl
		{
			get
			{
				return this.styleLblField;
			}
			set
			{
				this.styleLblField = value;
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x0005E7FC File Offset: 0x0005C9FC
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x0005E804 File Offset: 0x0005CA04
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x0005E80D File Offset: 0x0005CA0D
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x0005E815 File Offset: 0x0005CA15
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string uniqueId
		{
			get
			{
				return this.uniqueIdField;
			}
			set
			{
				this.uniqueIdField = value;
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x0005E81E File Offset: 0x0005CA1E
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x0005E826 File Offset: 0x0005CA26
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("http://schemas.openxmlformats.org/drawingml/2006/diagram")]
		public string minVer
		{
			get
			{
				return this.minVerField;
			}
			set
			{
				this.minVerField = value;
			}
		}

		// Token: 0x04001C50 RID: 7248
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDName> titleField;

		// Token: 0x04001C51 RID: 7249
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDDescription> descField;

		// Token: 0x04001C52 RID: 7250
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDCategory> catLstField;

		// Token: 0x04001C53 RID: 7251
		private global::NPOI.OpenXmlFormats.Dml.CT_Scene3D scene3dField;

		// Token: 0x04001C54 RID: 7252
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_StyleLabel> styleLblField;

		// Token: 0x04001C55 RID: 7253
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001C56 RID: 7254
		private string uniqueIdField;

		// Token: 0x04001C57 RID: 7255
		private string minVerField;
	}
}
