using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000251 RID: 593
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ThemeableLineStyle
	{
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x000437FD File Offset: 0x000419FD
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x00043805 File Offset: 0x00041A05
		[global::System.Xml.Serialization.XmlElement("ln", typeof(global::NPOI.OpenXmlFormats.Dml.CT_LineProperties), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("lnRef", typeof(global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x0400128B RID: 4747
		private object itemField;
	}
}
