using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x0200047A RID: 1146
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Marker
	{
		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x00072D38 File Offset: 0x00070F38
		// (set) Token: 0x06002DB7 RID: 11703 RVA: 0x00072D40 File Offset: 0x00070F40
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public double x
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x00072D49 File Offset: 0x00070F49
		// (set) Token: 0x06002DB9 RID: 11705 RVA: 0x00072D51 File Offset: 0x00070F51
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public double y
		{
			get
			{
				return this.yField;
			}
			set
			{
				this.yField = value;
			}
		}

		// Token: 0x04001FB8 RID: 8120
		private double xField;

		// Token: 0x04001FB9 RID: 8121
		private double yField;
	}
}
