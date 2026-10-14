using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200037C RID: 892
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.17379")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot("colorsDef", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
	[global::System.Serializable]
	public class CT_ColorTransform
	{
		// Token: 0x060023C0 RID: 9152 RVA: 0x0005CDF8 File Offset: 0x0005AFF8
		public CT_ColorTransform()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
			this.styleLblField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTStyleLabel>();
			this.catLstField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTCategory>();
			this.descField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTDescription>();
			this.titleField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTName>();
			this.uniqueIdField = "";
			this.minVerField = "http://schemas.openxmlformats.org/drawingml/2006/diagram";
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x0005CE58 File Offset: 0x0005B058
		// (set) Token: 0x060023C2 RID: 9154 RVA: 0x0005CE60 File Offset: 0x0005B060
		[global::System.Xml.Serialization.XmlElement("title", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTName> title
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

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x0005CE69 File Offset: 0x0005B069
		// (set) Token: 0x060023C4 RID: 9156 RVA: 0x0005CE71 File Offset: 0x0005B071
		[global::System.Xml.Serialization.XmlElement("desc", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTDescription> desc
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

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x0005CE7A File Offset: 0x0005B07A
		// (set) Token: 0x060023C6 RID: 9158 RVA: 0x0005CE82 File Offset: 0x0005B082
		[global::System.Xml.Serialization.XmlArray(Order = 2)]
		[global::System.Xml.Serialization.XmlArrayItem("cat", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTCategory> catLst
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

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x0005CE8B File Offset: 0x0005B08B
		// (set) Token: 0x060023C8 RID: 9160 RVA: 0x0005CE93 File Offset: 0x0005B093
		[global::System.Xml.Serialization.XmlElement("styleLbl", Order = 3)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTStyleLabel> styleLbl
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

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x0005CE9C File Offset: 0x0005B09C
		// (set) Token: 0x060023CA RID: 9162 RVA: 0x0005CEA4 File Offset: 0x0005B0A4
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

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x0005CEAD File Offset: 0x0005B0AD
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x0005CEB5 File Offset: 0x0005B0B5
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

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x0005CEBE File Offset: 0x0005B0BE
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x0005CEC6 File Offset: 0x0005B0C6
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

		// Token: 0x04001A86 RID: 6790
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTName> titleField;

		// Token: 0x04001A87 RID: 6791
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTDescription> descField;

		// Token: 0x04001A88 RID: 6792
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTCategory> catLstField;

		// Token: 0x04001A89 RID: 6793
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTStyleLabel> styleLblField;

		// Token: 0x04001A8A RID: 6794
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001A8B RID: 6795
		private string uniqueIdField;

		// Token: 0x04001A8C RID: 6796
		private string minVerField;
	}
}
