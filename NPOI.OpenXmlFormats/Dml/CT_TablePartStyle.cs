using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000257 RID: 599
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TablePartStyle
	{
		// Token: 0x06001854 RID: 6228 RVA: 0x00043ACB File Offset: 0x00041CCB
		public CT_TablePartStyle()
		{
			this.tcStyleField = new global::NPOI.OpenXmlFormats.Dml.CT_TableStyleCellStyle();
			this.tcTxStyleField = new global::NPOI.OpenXmlFormats.Dml.CT_TableStyleTextStyle();
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x00043AE9 File Offset: 0x00041CE9
		// (set) Token: 0x06001856 RID: 6230 RVA: 0x00043AF1 File Offset: 0x00041CF1
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TableStyleTextStyle tcTxStyle
		{
			get
			{
				return this.tcTxStyleField;
			}
			set
			{
				this.tcTxStyleField = value;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x00043AFA File Offset: 0x00041CFA
		// (set) Token: 0x06001858 RID: 6232 RVA: 0x00043B02 File Offset: 0x00041D02
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TableStyleCellStyle tcStyle
		{
			get
			{
				return this.tcStyleField;
			}
			set
			{
				this.tcStyleField = value;
			}
		}

		// Token: 0x040012AC RID: 4780
		private global::NPOI.OpenXmlFormats.Dml.CT_TableStyleTextStyle tcTxStyleField;

		// Token: 0x040012AD RID: 4781
		private global::NPOI.OpenXmlFormats.Dml.CT_TableStyleCellStyle tcStyleField;
	}
}
