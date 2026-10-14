using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000386 RID: 902
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.17379")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CTCategories
	{
		// Token: 0x06002408 RID: 9224 RVA: 0x0005D162 File Offset: 0x0005B362
		public CT_CTCategories()
		{
			this.catField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTCategory>();
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x0005D175 File Offset: 0x0005B375
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x0005D17D File Offset: 0x0005B37D
		[global::System.Xml.Serialization.XmlElement("cat", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTCategory> cat
		{
			get
			{
				return this.catField;
			}
			set
			{
				this.catField = value;
			}
		}

		// Token: 0x04001AAD RID: 6829
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTCategory> catField;
	}
}
