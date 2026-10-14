using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005E7 RID: 1511
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("singleXmlCells", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SingleXmlCells
	{
		// Token: 0x0600423E RID: 16958 RVA: 0x0009F51A File Offset: 0x0009D71A
		public CT_SingleXmlCells()
		{
			this.singleXmlCellField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCell>();
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x0600423F RID: 16959 RVA: 0x0009F52D File Offset: 0x0009D72D
		// (set) Token: 0x06004240 RID: 16960 RVA: 0x0009F535 File Offset: 0x0009D735
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCell> singleXmlCell
		{
			get
			{
				return this.singleXmlCellField;
			}
			set
			{
				this.singleXmlCellField = value;
			}
		}

		// Token: 0x040029F4 RID: 10740
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCell> singleXmlCellField;
	}
}
