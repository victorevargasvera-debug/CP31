using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002CF RID: 719
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AnimationDgmElement
	{
		// Token: 0x06001C6A RID: 7274 RVA: 0x0004DF37 File Offset: 0x0004C137
		public CT_AnimationDgmElement()
		{
			this.idField = "{00000000-0000-0000-0000-000000000000}";
			this.bldStepField = global::NPOI.OpenXmlFormats.Dml.ST_DgmBuildStep.sp;
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x0004DF51 File Offset: 0x0004C151
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x0004DF59 File Offset: 0x0004C159
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		[global::System.ComponentModel.DefaultValue("{00000000-0000-0000-0000-000000000000}")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x0004DF62 File Offset: 0x0004C162
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x0004DF6A File Offset: 0x0004C16A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_DgmBuildStep.sp)]
		public global::NPOI.OpenXmlFormats.Dml.ST_DgmBuildStep bldStep
		{
			get
			{
				return this.bldStepField;
			}
			set
			{
				this.bldStepField = value;
			}
		}

		// Token: 0x04001631 RID: 5681
		private string idField;

		// Token: 0x04001632 RID: 5682
		private global::NPOI.OpenXmlFormats.Dml.ST_DgmBuildStep bldStepField;
	}
}
