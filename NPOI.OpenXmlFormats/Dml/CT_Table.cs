using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000249 RID: 585
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("tbl", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Table
	{
		// Token: 0x06001797 RID: 6039 RVA: 0x000432F6 File Offset: 0x000414F6
		public CT_Table()
		{
			this.trField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableRow>();
			this.tblGridField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableCol>();
			this.tblPrField = new global::NPOI.OpenXmlFormats.Dml.CT_TableProperties();
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x0004331F File Offset: 0x0004151F
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x00043327 File Offset: 0x00041527
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TableProperties tblPr
		{
			get
			{
				return this.tblPrField;
			}
			set
			{
				this.tblPrField = value;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x00043330 File Offset: 0x00041530
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x00043338 File Offset: 0x00041538
		[global::System.Xml.Serialization.XmlArray(Order = 1)]
		[global::System.Xml.Serialization.XmlArrayItem("gridCol", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableCol> tblGrid
		{
			get
			{
				return this.tblGridField;
			}
			set
			{
				this.tblGridField = value;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00043341 File Offset: 0x00041541
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x00043349 File Offset: 0x00041549
		[global::System.Xml.Serialization.XmlElement("tr", Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableRow> tr
		{
			get
			{
				return this.trField;
			}
			set
			{
				this.trField = value;
			}
		}

		// Token: 0x04001250 RID: 4688
		private global::NPOI.OpenXmlFormats.Dml.CT_TableProperties tblPrField;

		// Token: 0x04001251 RID: 4689
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableCol> tblGridField;

		// Token: 0x04001252 RID: 4690
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableRow> trField;
	}
}
