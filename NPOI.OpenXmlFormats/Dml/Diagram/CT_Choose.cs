using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000397 RID: 919
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Choose
	{
		// Token: 0x0600246D RID: 9325 RVA: 0x0005D5DE File Offset: 0x0005B7DE
		public CT_Choose()
		{
			this.elseField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Otherwise();
			this.ifField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_When>();
			this.nameField = "";
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x0005D607 File Offset: 0x0005B807
		// (set) Token: 0x0600246F RID: 9327 RVA: 0x0005D60F File Offset: 0x0005B80F
		[global::System.Xml.Serialization.XmlElement("if", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_When> @if
		{
			get
			{
				return this.ifField;
			}
			set
			{
				this.ifField = value;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x0005D618 File Offset: 0x0005B818
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x0005D620 File Offset: 0x0005B820
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Otherwise @else
		{
			get
			{
				return this.elseField;
			}
			set
			{
				this.elseField = value;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x0005D629 File Offset: 0x0005B829
		// (set) Token: 0x06002473 RID: 9331 RVA: 0x0005D631 File Offset: 0x0005B831
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

		// Token: 0x04001B28 RID: 6952
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_When> ifField;

		// Token: 0x04001B29 RID: 6953
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Otherwise elseField;

		// Token: 0x04001B2A RID: 6954
		private string nameField;
	}
}
