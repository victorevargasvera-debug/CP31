using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003A2 RID: 930
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Rules
	{
		// Token: 0x060024CB RID: 9419 RVA: 0x0005DC4F File Offset: 0x0005BE4F
		public CT_Rules()
		{
			this.ruleField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_NumericRule>();
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x0005DC62 File Offset: 0x0005BE62
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x0005DC6A File Offset: 0x0005BE6A
		[global::System.Xml.Serialization.XmlElement("rule", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_NumericRule> rule
		{
			get
			{
				return this.ruleField;
			}
			set
			{
				this.ruleField = value;
			}
		}

		// Token: 0x04001BB7 RID: 7095
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_NumericRule> ruleField;
	}
}
