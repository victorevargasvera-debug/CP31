using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005E2 RID: 1506
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MetadataBlock
	{
		// Token: 0x0600422E RID: 16942 RVA: 0x0009F2B5 File Offset: 0x0009D4B5
		public CT_MetadataBlock()
		{
			this.rcField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataRecord>();
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x0600422F RID: 16943 RVA: 0x0009F2C8 File Offset: 0x0009D4C8
		// (set) Token: 0x06004230 RID: 16944 RVA: 0x0009F2D0 File Offset: 0x0009D4D0
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataRecord> rc
		{
			get
			{
				return this.rcField;
			}
			set
			{
				this.rcField = value;
			}
		}

		// Token: 0x040029B1 RID: 10673
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataRecord> rcField;
	}
}
