using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002E5 RID: 741
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AdjustHandleList
	{
		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x0004E8CA File Offset: 0x0004CACA
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x0004E8D2 File Offset: 0x0004CAD2
		[global::System.Xml.Serialization.XmlElement("ahPolar", typeof(global::NPOI.OpenXmlFormats.Dml.CT_PolarAdjustHandle), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("ahXY", typeof(global::NPOI.OpenXmlFormats.Dml.CT_XYAdjustHandle), Order = 0)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x0400174C RID: 5964
		private object[] itemsField;
	}
}
