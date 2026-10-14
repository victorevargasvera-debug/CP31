using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005D5 RID: 1493
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FutureMetadataBlock
	{
		// Token: 0x060041DC RID: 16860 RVA: 0x0009EF7F File Offset: 0x0009D17F
		public CT_FutureMetadataBlock()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x060041DD RID: 16861 RVA: 0x0009EF92 File Offset: 0x0009D192
		// (set) Token: 0x060041DE RID: 16862 RVA: 0x0009EF9A File Offset: 0x0009D19A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x04002976 RID: 10614
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
