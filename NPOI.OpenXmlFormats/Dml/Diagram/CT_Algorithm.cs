using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000393 RID: 915
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Algorithm
	{
		// Token: 0x0600245F RID: 9311 RVA: 0x0005D55E File Offset: 0x0005B75E
		public CT_Algorithm()
		{
			this.paramField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Parameter>();
			this.revField = 0U;
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x0005D578 File Offset: 0x0005B778
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x0005D580 File Offset: 0x0005B780
		[global::System.Xml.Serialization.XmlElement("param", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Parameter> param
		{
			get
			{
				return this.paramField;
			}
			set
			{
				this.paramField = value;
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x0005D589 File Offset: 0x0005B789
		// (set) Token: 0x06002463 RID: 9315 RVA: 0x0005D591 File Offset: 0x0005B791
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

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x0005D59A File Offset: 0x0005B79A
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x0005D5A2 File Offset: 0x0005B7A2
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AlgorithmType type
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

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06002466 RID: 9318 RVA: 0x0005D5AB File Offset: 0x0005B7AB
		// (set) Token: 0x06002467 RID: 9319 RVA: 0x0005D5B3 File Offset: 0x0005B7B3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint rev
		{
			get
			{
				return this.revField;
			}
			set
			{
				this.revField = value;
			}
		}

		// Token: 0x04001ADF RID: 6879
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Parameter> paramField;

		// Token: 0x04001AE0 RID: 6880
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001AE1 RID: 6881
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AlgorithmType typeField;

		// Token: 0x04001AE2 RID: 6882
		private uint revField;
	}
}
