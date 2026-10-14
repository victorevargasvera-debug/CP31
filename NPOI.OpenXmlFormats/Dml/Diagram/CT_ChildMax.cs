using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003B2 RID: 946
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ChildMax
	{
		// Token: 0x0600259A RID: 9626 RVA: 0x0005E52B File Offset: 0x0005C72B
		public CT_ChildMax()
		{
			this.valField = -1;
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x0005E53A File Offset: 0x0005C73A
		// (set) Token: 0x0600259C RID: 9628 RVA: 0x0005E542 File Offset: 0x0005C742
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(-1)]
		public int val
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

		// Token: 0x04001C2B RID: 7211
		private int valField;
	}
}
