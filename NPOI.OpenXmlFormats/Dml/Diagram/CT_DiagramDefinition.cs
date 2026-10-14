using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003AC RID: 940
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot("layoutDef", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
	[global::System.Serializable]
	public class CT_DiagramDefinition
	{
		// Token: 0x06002502 RID: 9474 RVA: 0x0005DF0C File Offset: 0x0005C10C
		public CT_DiagramDefinition()
		{
			this.layoutNodeField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_LayoutNode();
			this.clrDataField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SampleData();
			this.styleDataField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SampleData();
			this.sampDataField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SampleData();
			this.catLstField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Category>();
			this.descField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Description>();
			this.titleField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Name>();
			this.uniqueIdField = "";
			this.minVerField = "http://schemas.openxmlformats.org/drawingml/2006/diagram";
			this.defStyleField = "";
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x0005DF8D File Offset: 0x0005C18D
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x0005DF95 File Offset: 0x0005C195
		[global::System.Xml.Serialization.XmlElement("title", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Name> title
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

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x0005DF9E File Offset: 0x0005C19E
		// (set) Token: 0x06002506 RID: 9478 RVA: 0x0005DFA6 File Offset: 0x0005C1A6
		[global::System.Xml.Serialization.XmlElement("desc", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Description> desc
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

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x0005DFAF File Offset: 0x0005C1AF
		// (set) Token: 0x06002508 RID: 9480 RVA: 0x0005DFB7 File Offset: 0x0005C1B7
		[global::System.Xml.Serialization.XmlArray(Order = 2)]
		[global::System.Xml.Serialization.XmlArrayItem("cat", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Category> catLst
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

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x0005DFC0 File Offset: 0x0005C1C0
		// (set) Token: 0x0600250A RID: 9482 RVA: 0x0005DFC8 File Offset: 0x0005C1C8
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SampleData sampData
		{
			get
			{
				return this.sampDataField;
			}
			set
			{
				this.sampDataField = value;
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x0005DFD1 File Offset: 0x0005C1D1
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x0005DFD9 File Offset: 0x0005C1D9
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SampleData styleData
		{
			get
			{
				return this.styleDataField;
			}
			set
			{
				this.styleDataField = value;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x0005DFE2 File Offset: 0x0005C1E2
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x0005DFEA File Offset: 0x0005C1EA
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SampleData clrData
		{
			get
			{
				return this.clrDataField;
			}
			set
			{
				this.clrDataField = value;
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x0005DFF3 File Offset: 0x0005C1F3
		// (set) Token: 0x06002510 RID: 9488 RVA: 0x0005DFFB File Offset: 0x0005C1FB
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_LayoutNode layoutNode
		{
			get
			{
				return this.layoutNodeField;
			}
			set
			{
				this.layoutNodeField = value;
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x0005E004 File Offset: 0x0005C204
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x0005E00C File Offset: 0x0005C20C
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
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

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x0005E015 File Offset: 0x0005C215
		// (set) Token: 0x06002514 RID: 9492 RVA: 0x0005E01D File Offset: 0x0005C21D
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

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x0005E026 File Offset: 0x0005C226
		// (set) Token: 0x06002516 RID: 9494 RVA: 0x0005E02E File Offset: 0x0005C22E
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

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x0005E037 File Offset: 0x0005C237
		// (set) Token: 0x06002518 RID: 9496 RVA: 0x0005E03F File Offset: 0x0005C23F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string defStyle
		{
			get
			{
				return this.defStyleField;
			}
			set
			{
				this.defStyleField = value;
			}
		}

		// Token: 0x04001BE2 RID: 7138
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Name> titleField;

		// Token: 0x04001BE3 RID: 7139
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Description> descField;

		// Token: 0x04001BE4 RID: 7140
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Category> catLstField;

		// Token: 0x04001BE5 RID: 7141
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SampleData sampDataField;

		// Token: 0x04001BE6 RID: 7142
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SampleData styleDataField;

		// Token: 0x04001BE7 RID: 7143
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SampleData clrDataField;

		// Token: 0x04001BE8 RID: 7144
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_LayoutNode layoutNodeField;

		// Token: 0x04001BE9 RID: 7145
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001BEA RID: 7146
		private string uniqueIdField;

		// Token: 0x04001BEB RID: 7147
		private string minVerField;

		// Token: 0x04001BEC RID: 7148
		private string defStyleField;
	}
}
