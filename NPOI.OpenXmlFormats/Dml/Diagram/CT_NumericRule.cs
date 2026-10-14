using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003A3 RID: 931
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NumericRule
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x0005DC74 File Offset: 0x0005BE74
		public CT_NumericRule()
		{
			this.ptTypeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType>();
			this.forField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintRelationship.self;
			this.forNameField = "";
			this.ptTypeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType>(new global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType[1]);
			this.valField = double.NaN;
			this.factField = double.NaN;
			this.maxField = double.NaN;
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060024CF RID: 9423 RVA: 0x0005DCE2 File Offset: 0x0005BEE2
		// (set) Token: 0x060024D0 RID: 9424 RVA: 0x0005DCEA File Offset: 0x0005BEEA
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060024D1 RID: 9425 RVA: 0x0005DCF3 File Offset: 0x0005BEF3
		// (set) Token: 0x060024D2 RID: 9426 RVA: 0x0005DCFB File Offset: 0x0005BEFB
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060024D3 RID: 9427 RVA: 0x0005DD04 File Offset: 0x0005BF04
		// (set) Token: 0x060024D4 RID: 9428 RVA: 0x0005DD0C File Offset: 0x0005BF0C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintRelationship.self)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintRelationship @for
		{
			get
			{
				return this.forField;
			}
			set
			{
				this.forField = value;
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060024D5 RID: 9429 RVA: 0x0005DD15 File Offset: 0x0005BF15
		// (set) Token: 0x060024D6 RID: 9430 RVA: 0x0005DD1D File Offset: 0x0005BF1D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string forName
		{
			get
			{
				return this.forNameField;
			}
			set
			{
				this.forNameField = value;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060024D7 RID: 9431 RVA: 0x0005DD26 File Offset: 0x0005BF26
		// (set) Token: 0x060024D8 RID: 9432 RVA: 0x0005DD2E File Offset: 0x0005BF2E
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType> ptType
		{
			get
			{
				return this.ptTypeField;
			}
			set
			{
				this.ptTypeField = value;
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060024D9 RID: 9433 RVA: 0x0005DD37 File Offset: 0x0005BF37
		// (set) Token: 0x060024DA RID: 9434 RVA: 0x0005DD3F File Offset: 0x0005BF3F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(double.NaN)]
		public double val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x0005DD48 File Offset: 0x0005BF48
		// (set) Token: 0x060024DC RID: 9436 RVA: 0x0005DD50 File Offset: 0x0005BF50
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(double.NaN)]
		public double fact
		{
			get
			{
				return this.factField;
			}
			set
			{
				this.factField = value;
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x0005DD59 File Offset: 0x0005BF59
		// (set) Token: 0x060024DE RID: 9438 RVA: 0x0005DD61 File Offset: 0x0005BF61
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(double.NaN)]
		public double max
		{
			get
			{
				return this.maxField;
			}
			set
			{
				this.maxField = value;
			}
		}

		// Token: 0x04001BB8 RID: 7096
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001BB9 RID: 7097
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintType typeField;

		// Token: 0x04001BBA RID: 7098
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintRelationship forField;

		// Token: 0x04001BBB RID: 7099
		private string forNameField;

		// Token: 0x04001BBC RID: 7100
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType> ptTypeField;

		// Token: 0x04001BBD RID: 7101
		private double valField;

		// Token: 0x04001BBE RID: 7102
		private double factField;

		// Token: 0x04001BBF RID: 7103
		private double maxField;
	}
}
