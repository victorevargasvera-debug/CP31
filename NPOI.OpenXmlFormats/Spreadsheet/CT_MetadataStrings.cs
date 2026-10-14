using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005E1 RID: 1505
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MetadataStrings
	{
		// Token: 0x06004229 RID: 16937 RVA: 0x0009F279 File Offset: 0x0009D479
		public CT_MetadataStrings()
		{
			this.sField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_XStringElement>();
			this.countField = 0U;
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x0009F293 File Offset: 0x0009D493
		// (set) Token: 0x0600422B RID: 16939 RVA: 0x0009F29B File Offset: 0x0009D49B
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_XStringElement> s
		{
			get
			{
				return this.sField;
			}
			set
			{
				this.sField = value;
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x0600422C RID: 16940 RVA: 0x0009F2A4 File Offset: 0x0009D4A4
		// (set) Token: 0x0600422D RID: 16941 RVA: 0x0009F2AC File Offset: 0x0009D4AC
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x040029AF RID: 10671
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_XStringElement> sField;

		// Token: 0x040029B0 RID: 10672
		private uint countField;
	}
}
