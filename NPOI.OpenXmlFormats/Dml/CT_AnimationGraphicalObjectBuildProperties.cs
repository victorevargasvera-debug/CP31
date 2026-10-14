using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002D7 RID: 727
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AnimationGraphicalObjectBuildProperties
	{
		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0004E045 File Offset: 0x0004C245
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x0004E04D File Offset: 0x0004C24D
		[global::System.Xml.Serialization.XmlElement("bldChart", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AnimationChartBuildProperties))]
		[global::System.Xml.Serialization.XmlElement("bldDgm", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AnimationDgmBuildProperties))]
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

		// Token: 0x04001646 RID: 5702
		private object itemField;
	}
}
