using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003AF RID: 943
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot("relIds", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
	[global::System.Serializable]
	public class CT_RelIds
	{
		// Token: 0x0600252D RID: 9517 RVA: 0x0005E145 File Offset: 0x0005C345
		public CT_RelIds()
		{
			this.dmField = "";
			this.loField = "";
			this.qsField = "";
			this.csField = "";
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x0005E179 File Offset: 0x0005C379
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x0005E181 File Offset: 0x0005C381
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		[global::System.ComponentModel.DefaultValue("")]
		public string dm
		{
			get
			{
				return this.dmField;
			}
			set
			{
				this.dmField = value;
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x0005E18A File Offset: 0x0005C38A
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x0005E192 File Offset: 0x0005C392
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		[global::System.ComponentModel.DefaultValue("")]
		public string lo
		{
			get
			{
				return this.loField;
			}
			set
			{
				this.loField = value;
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x0005E19B File Offset: 0x0005C39B
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x0005E1A3 File Offset: 0x0005C3A3
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		[global::System.ComponentModel.DefaultValue("")]
		public string qs
		{
			get
			{
				return this.qsField;
			}
			set
			{
				this.qsField = value;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x0005E1AC File Offset: 0x0005C3AC
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x0005E1B4 File Offset: 0x0005C3B4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		[global::System.ComponentModel.DefaultValue("")]
		public string cs
		{
			get
			{
				return this.csField;
			}
			set
			{
				this.csField = value;
			}
		}

		// Token: 0x04001BF6 RID: 7158
		private string dmField;

		// Token: 0x04001BF7 RID: 7159
		private string loField;

		// Token: 0x04001BF8 RID: 7160
		private string qsField;

		// Token: 0x04001BF9 RID: 7161
		private string csField;
	}
}
