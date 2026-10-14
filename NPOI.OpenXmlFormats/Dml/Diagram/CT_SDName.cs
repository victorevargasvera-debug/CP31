using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003C1 RID: 961
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SDName
	{
		// Token: 0x060025D6 RID: 9686 RVA: 0x0005E82F File Offset: 0x0005CA2F
		public CT_SDName()
		{
			this.langField = "";
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x0005E842 File Offset: 0x0005CA42
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x0005E84A File Offset: 0x0005CA4A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string lang
		{
			get
			{
				return this.langField;
			}
			set
			{
				this.langField = value;
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x0005E853 File Offset: 0x0005CA53
		// (set) Token: 0x060025DA RID: 9690 RVA: 0x0005E85B File Offset: 0x0005CA5B
		[global::System.Xml.Serialization.XmlAttribute]
		public string val
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

		// Token: 0x04001C58 RID: 7256
		private string langField;

		// Token: 0x04001C59 RID: 7257
		private string valField;
	}
}
