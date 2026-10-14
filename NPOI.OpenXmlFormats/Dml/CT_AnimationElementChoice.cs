using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002D1 RID: 721
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AnimationElementChoice
	{
		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x0004DFBC File Offset: 0x0004C1BC
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x0004DFC4 File Offset: 0x0004C1C4
		[global::System.Xml.Serialization.XmlElement("chart", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AnimationChartElement), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("dgm", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AnimationDgmElement), Order = 0)]
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

		// Token: 0x04001636 RID: 5686
		private object itemField;
	}
}
