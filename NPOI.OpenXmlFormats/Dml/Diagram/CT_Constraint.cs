using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200039A RID: 922
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Constraint
	{
		// Token: 0x06002490 RID: 9360 RVA: 0x0005D81C File Offset: 0x0005BA1C
		public CT_Constraint()
		{
			this.refPtTypeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType>();
			this.ptTypeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType>();
			this.forField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintRelationship.self;
			this.forNameField = "";
			this.ptTypeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType>(new global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType[1]);
			this.refTypeField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintType.none;
			this.refForField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintRelationship.self;
			this.refForNameField = "";
			this.refPtTypeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType>(new global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType[1]);
			this.opField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_BoolOperator.none;
			this.valField = 0.0;
			this.factField = 1.0;
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x0005D8B7 File Offset: 0x0005BAB7
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x0005D8BF File Offset: 0x0005BABF
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

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x0005D8C8 File Offset: 0x0005BAC8
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x0005D8D0 File Offset: 0x0005BAD0
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

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x0005D8D9 File Offset: 0x0005BAD9
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x0005D8E1 File Offset: 0x0005BAE1
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

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x0005D8EA File Offset: 0x0005BAEA
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0005D8F2 File Offset: 0x0005BAF2
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

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x0005D8FB File Offset: 0x0005BAFB
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0005D903 File Offset: 0x0005BB03
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

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x0005D90C File Offset: 0x0005BB0C
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x0005D914 File Offset: 0x0005BB14
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintType.none)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintType refType
		{
			get
			{
				return this.refTypeField;
			}
			set
			{
				this.refTypeField = value;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x0005D91D File Offset: 0x0005BB1D
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x0005D925 File Offset: 0x0005BB25
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintRelationship.self)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintRelationship refFor
		{
			get
			{
				return this.refForField;
			}
			set
			{
				this.refForField = value;
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x0005D92E File Offset: 0x0005BB2E
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x0005D936 File Offset: 0x0005BB36
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string refForName
		{
			get
			{
				return this.refForNameField;
			}
			set
			{
				this.refForNameField = value;
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x0005D93F File Offset: 0x0005BB3F
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x0005D947 File Offset: 0x0005BB47
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType> refPtType
		{
			get
			{
				return this.refPtTypeField;
			}
			set
			{
				this.refPtTypeField = value;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x0005D950 File Offset: 0x0005BB50
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x0005D958 File Offset: 0x0005BB58
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_BoolOperator.none)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_BoolOperator op
		{
			get
			{
				return this.opField;
			}
			set
			{
				this.opField = value;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x0005D961 File Offset: 0x0005BB61
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x0005D969 File Offset: 0x0005BB69
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0.0)]
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

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x0005D972 File Offset: 0x0005BB72
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x0005D97A File Offset: 0x0005BB7A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(1.0)]
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

		// Token: 0x04001B38 RID: 6968
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001B39 RID: 6969
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintType typeField;

		// Token: 0x04001B3A RID: 6970
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintRelationship forField;

		// Token: 0x04001B3B RID: 6971
		private string forNameField;

		// Token: 0x04001B3C RID: 6972
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType> ptTypeField;

		// Token: 0x04001B3D RID: 6973
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintType refTypeField;

		// Token: 0x04001B3E RID: 6974
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ConstraintRelationship refForField;

		// Token: 0x04001B3F RID: 6975
		private string refForNameField;

		// Token: 0x04001B40 RID: 6976
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType> refPtTypeField;

		// Token: 0x04001B41 RID: 6977
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_BoolOperator opField;

		// Token: 0x04001B42 RID: 6978
		private double valField;

		// Token: 0x04001B43 RID: 6979
		private double factField;
	}
}
