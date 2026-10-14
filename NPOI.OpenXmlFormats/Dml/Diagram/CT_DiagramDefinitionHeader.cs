using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003AD RID: 941
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot("layoutDefHdr", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
	[global::System.Serializable]
	public class CT_DiagramDefinitionHeader
	{
		// Token: 0x06002519 RID: 9497 RVA: 0x0005E048 File Offset: 0x0005C248
		public CT_DiagramDefinitionHeader()
		{
			this.catLstField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Category>();
			this.descField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Description>();
			this.titleField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Name>();
			this.minVerField = "http://schemas.openxmlformats.org/drawingml/2006/diagram";
			this.defStyleField = "";
			this.resIdField = 0;
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x0005E099 File Offset: 0x0005C299
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x0005E0A1 File Offset: 0x0005C2A1
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

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x0005E0AA File Offset: 0x0005C2AA
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x0005E0B2 File Offset: 0x0005C2B2
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

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x0005E0BB File Offset: 0x0005C2BB
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x0005E0C3 File Offset: 0x0005C2C3
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

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x0005E0CC File Offset: 0x0005C2CC
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x0005E0D4 File Offset: 0x0005C2D4
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x0005E0DD File Offset: 0x0005C2DD
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x0005E0E5 File Offset: 0x0005C2E5
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x0005E0EE File Offset: 0x0005C2EE
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x0005E0F6 File Offset: 0x0005C2F6
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

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x0005E0FF File Offset: 0x0005C2FF
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x0005E107 File Offset: 0x0005C307
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

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x0005E110 File Offset: 0x0005C310
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x0005E118 File Offset: 0x0005C318
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int resId
		{
			get
			{
				return this.resIdField;
			}
			set
			{
				this.resIdField = value;
			}
		}

		// Token: 0x04001BED RID: 7149
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Name> titleField;

		// Token: 0x04001BEE RID: 7150
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Description> descField;

		// Token: 0x04001BEF RID: 7151
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Category> catLstField;

		// Token: 0x04001BF0 RID: 7152
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001BF1 RID: 7153
		private string uniqueIdField;

		// Token: 0x04001BF2 RID: 7154
		private string minVerField;

		// Token: 0x04001BF3 RID: 7155
		private string defStyleField;

		// Token: 0x04001BF4 RID: 7156
		private int resIdField;
	}
}
