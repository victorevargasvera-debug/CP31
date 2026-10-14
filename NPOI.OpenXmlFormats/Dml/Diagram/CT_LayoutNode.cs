using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000392 RID: 914
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LayoutNode
	{
		// Token: 0x06002454 RID: 9300 RVA: 0x0005D4CE File Offset: 0x0005B6CE
		public CT_LayoutNode()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
			this.nameField = "";
			this.styleLblField = "";
			this.chOrderField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ChildOrderType.b;
			this.moveWithField = "";
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x0005D509 File Offset: 0x0005B709
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x0005D511 File Offset: 0x0005B711
		[global::System.Xml.Serialization.XmlElement("alg", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Algorithm), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("choose", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Choose), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("constrLst", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Constraints), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("extLst", typeof(global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("forEach", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ForEach), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("layoutNode", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_LayoutNode), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("presOf", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_PresentationOf), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("ruleLst", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Rules), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("shape", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Shape), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("varLst", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_LayoutVariablePropertySet), Order = 0)]
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x0005D51A File Offset: 0x0005B71A
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x0005D522 File Offset: 0x0005B722
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
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

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x0005D52B File Offset: 0x0005B72B
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x0005D533 File Offset: 0x0005B733
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string styleLbl
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

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x0005D53C File Offset: 0x0005B73C
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x0005D544 File Offset: 0x0005B744
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ChildOrderType.b)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ChildOrderType chOrder
		{
			get
			{
				return this.chOrderField;
			}
			set
			{
				this.chOrderField = value;
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x0005D54D File Offset: 0x0005B74D
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x0005D555 File Offset: 0x0005B755
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string moveWith
		{
			get
			{
				return this.moveWithField;
			}
			set
			{
				this.moveWithField = value;
			}
		}

		// Token: 0x04001ADA RID: 6874
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04001ADB RID: 6875
		private string nameField;

		// Token: 0x04001ADC RID: 6876
		private string styleLblField;

		// Token: 0x04001ADD RID: 6877
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ChildOrderType chOrderField;

		// Token: 0x04001ADE RID: 6878
		private string moveWithField;
	}
}
