using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200001E RID: 30
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Sources
	{
		// Token: 0x06000133 RID: 307 RVA: 0x000031C4 File Offset: 0x000013C4
		public CT_Sources()
		{
			this.sourceField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_SourceType>();
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000031D7 File Offset: 0x000013D7
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000031DF File Offset: 0x000013DF
		[global::System.Xml.Serialization.XmlElement("Source")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_SourceType> Source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000031E8 File Offset: 0x000013E8
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000031F0 File Offset: 0x000013F0
		[global::System.Xml.Serialization.XmlAttribute]
		public string SelectedStyle
		{
			get
			{
				return this.selectedStyleField;
			}
			set
			{
				this.selectedStyleField = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000031F9 File Offset: 0x000013F9
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00003201 File Offset: 0x00001401
		[global::System.Xml.Serialization.XmlAttribute]
		public string StyleName
		{
			get
			{
				return this.styleNameField;
			}
			set
			{
				this.styleNameField = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000320A File Offset: 0x0000140A
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00003212 File Offset: 0x00001412
		[global::System.Xml.Serialization.XmlAttribute]
		public string URI
		{
			get
			{
				return this.uRIField;
			}
			set
			{
				this.uRIField = value;
			}
		}

		// Token: 0x040000C6 RID: 198
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_SourceType> sourceField;

		// Token: 0x040000C7 RID: 199
		private string selectedStyleField;

		// Token: 0x040000C8 RID: 200
		private string styleNameField;

		// Token: 0x040000C9 RID: 201
		private string uRIField;
	}
}
