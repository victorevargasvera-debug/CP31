using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003A6 RID: 934
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Shape
	{
		// Token: 0x060024E7 RID: 9447 RVA: 0x0005DDB0 File Offset: 0x0005BFB0
		public CT_Shape()
		{
			this.adjLstField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Adj>();
			this.rotField = 0.0;
			this.typeField = "none";
			this.blipField = "";
			this.zOrderOffField = 0;
			this.hideGeomField = false;
			this.lkTxEntryField = false;
			this.blipPhldrField = false;
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x0005DE0F File Offset: 0x0005C00F
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x0005DE17 File Offset: 0x0005C017
		[global::System.Xml.Serialization.XmlArray(Order = 0)]
		[global::System.Xml.Serialization.XmlArrayItem("adj", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Adj> adjLst
		{
			get
			{
				return this.adjLstField;
			}
			set
			{
				this.adjLstField = value;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x0005DE20 File Offset: 0x0005C020
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x0005DE28 File Offset: 0x0005C028
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x0005DE31 File Offset: 0x0005C031
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x0005DE39 File Offset: 0x0005C039
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0.0)]
		public double rot
		{
			get
			{
				return this.rotField;
			}
			set
			{
				this.rotField = value;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x0005DE42 File Offset: 0x0005C042
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x0005DE4A File Offset: 0x0005C04A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("none")]
		public string type
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

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x0005DE53 File Offset: 0x0005C053
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x0005DE5B File Offset: 0x0005C05B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		[global::System.ComponentModel.DefaultValue("")]
		public string blip
		{
			get
			{
				return this.blipField;
			}
			set
			{
				this.blipField = value;
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x0005DE64 File Offset: 0x0005C064
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x0005DE6C File Offset: 0x0005C06C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int zOrderOff
		{
			get
			{
				return this.zOrderOffField;
			}
			set
			{
				this.zOrderOffField = value;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x0005DE75 File Offset: 0x0005C075
		// (set) Token: 0x060024F5 RID: 9461 RVA: 0x0005DE7D File Offset: 0x0005C07D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hideGeom
		{
			get
			{
				return this.hideGeomField;
			}
			set
			{
				this.hideGeomField = value;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x0005DE86 File Offset: 0x0005C086
		// (set) Token: 0x060024F7 RID: 9463 RVA: 0x0005DE8E File Offset: 0x0005C08E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool lkTxEntry
		{
			get
			{
				return this.lkTxEntryField;
			}
			set
			{
				this.lkTxEntryField = value;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x0005DE97 File Offset: 0x0005C097
		// (set) Token: 0x060024F9 RID: 9465 RVA: 0x0005DE9F File Offset: 0x0005C09F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool blipPhldr
		{
			get
			{
				return this.blipPhldrField;
			}
			set
			{
				this.blipPhldrField = value;
			}
		}

		// Token: 0x04001BC3 RID: 7107
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Adj> adjLstField;

		// Token: 0x04001BC4 RID: 7108
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001BC5 RID: 7109
		private double rotField;

		// Token: 0x04001BC6 RID: 7110
		private string typeField;

		// Token: 0x04001BC7 RID: 7111
		private string blipField;

		// Token: 0x04001BC8 RID: 7112
		private int zOrderOffField;

		// Token: 0x04001BC9 RID: 7113
		private bool hideGeomField;

		// Token: 0x04001BCA RID: 7114
		private bool lkTxEntryField;

		// Token: 0x04001BCB RID: 7115
		private bool blipPhldrField;
	}
}
