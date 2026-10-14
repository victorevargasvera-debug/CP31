using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000242 RID: 578
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AudioFile
	{
		// Token: 0x06001764 RID: 5988 RVA: 0x000430E6 File Offset: 0x000412E6
		public CT_AudioFile()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x000430F9 File Offset: 0x000412F9
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x00043101 File Offset: 0x00041301
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

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x0004310A File Offset: 0x0004130A
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x00043112 File Offset: 0x00041312
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

		// Token: 0x0400123A RID: 4666
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x0400123B RID: 4667
		private string linkField;
	}
}
