using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002D0 RID: 720
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AnimationChartElement
	{
		// Token: 0x06001C6F RID: 7279 RVA: 0x0004DF73 File Offset: 0x0004C173
		public CT_AnimationChartElement()
		{
			this.seriesIdxField = -1;
			this.categoryIdxField = -1;
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x0004DF89 File Offset: 0x0004C189
		// (set) Token: 0x06001C71 RID: 7281 RVA: 0x0004DF91 File Offset: 0x0004C191
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(-1)]
		public int seriesIdx
		{
			get
			{
				return this.seriesIdxField;
			}
			set
			{
				this.seriesIdxField = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x0004DF9A File Offset: 0x0004C19A
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x0004DFA2 File Offset: 0x0004C1A2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(-1)]
		public int categoryIdx
		{
			get
			{
				return this.categoryIdxField;
			}
			set
			{
				this.categoryIdxField = value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x0004DFAB File Offset: 0x0004C1AB
		// (set) Token: 0x06001C75 RID: 7285 RVA: 0x0004DFB3 File Offset: 0x0004C1B3
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ChartBuildStep bldStep
		{
			get
			{
				return this.bldStepField;
			}
			set
			{
				this.bldStepField = value;
			}
		}

		// Token: 0x04001633 RID: 5683
		private int seriesIdxField;

		// Token: 0x04001634 RID: 5684
		private int categoryIdxField;

		// Token: 0x04001635 RID: 5685
		private global::NPOI.OpenXmlFormats.Dml.ST_ChartBuildStep bldStepField;
	}
}
