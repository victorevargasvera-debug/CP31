using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000243 RID: 579
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_VideoFile
	{
		// Token: 0x06001769 RID: 5993 RVA: 0x0004311B File Offset: 0x0004131B
		public CT_VideoFile()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x0004312E File Offset: 0x0004132E
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x00043136 File Offset: 0x00041336
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

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x0004313F File Offset: 0x0004133F
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x00043147 File Offset: 0x00041347
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

		// Token: 0x0400123C RID: 4668
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x0400123D RID: 4669
		private string linkField;
	}
}
