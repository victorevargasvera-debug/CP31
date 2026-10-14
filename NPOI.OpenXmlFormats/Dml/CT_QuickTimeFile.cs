using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000244 RID: 580
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_QuickTimeFile
	{
		// Token: 0x0600176E RID: 5998 RVA: 0x00043150 File Offset: 0x00041350
		public CT_QuickTimeFile()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x0600176F RID: 5999 RVA: 0x00043163 File Offset: 0x00041363
		// (set) Token: 0x06001770 RID: 6000 RVA: 0x0004316B File Offset: 0x0004136B
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
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

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x00043174 File Offset: 0x00041374
		// (set) Token: 0x06001772 RID: 6002 RVA: 0x0004317C File Offset: 0x0004137C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string link
		{
			get
			{
				return this.linkField;
			}
			set
			{
				this.linkField = value;
			}
		}

		// Token: 0x0400123E RID: 4670
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x0400123F RID: 4671
		private string linkField;
	}
}
