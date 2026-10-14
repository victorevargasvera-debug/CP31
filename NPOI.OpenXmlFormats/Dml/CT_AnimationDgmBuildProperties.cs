using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002D4 RID: 724
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AnimationDgmBuildProperties
	{
		// Token: 0x06001C79 RID: 7289 RVA: 0x0004DFCD File Offset: 0x0004C1CD
		public CT_AnimationDgmBuildProperties()
		{
			this.bldField = "allAtOnce";
			this.revField = false;
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x0004DFE7 File Offset: 0x0004C1E7
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x0004DFEF File Offset: 0x0004C1EF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("allAtOnce")]
		public string bld
		{
			get
			{
				return this.bldField;
			}
			set
			{
				this.bldField = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x0004DFF8 File Offset: 0x0004C1F8
		// (set) Token: 0x06001C7D RID: 7293 RVA: 0x0004E000 File Offset: 0x0004C200
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool rev
		{
			get
			{
				return this.revField;
			}
			set
			{
				this.revField = value;
			}
		}

		// Token: 0x0400163D RID: 5693
		private string bldField;

		// Token: 0x0400163E RID: 5694
		private bool revField;
	}
}
