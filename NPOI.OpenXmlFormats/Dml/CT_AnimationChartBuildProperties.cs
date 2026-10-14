using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002D6 RID: 726
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AnimationChartBuildProperties
	{
		// Token: 0x06001C7E RID: 7294 RVA: 0x0004E009 File Offset: 0x0004C209
		public CT_AnimationChartBuildProperties()
		{
			this.bldField = "allAtOnce";
			this.animBgField = true;
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0004E023 File Offset: 0x0004C223
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x0004E02B File Offset: 0x0004C22B
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

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x0004E034 File Offset: 0x0004C234
		// (set) Token: 0x06001C82 RID: 7298 RVA: 0x0004E03C File Offset: 0x0004C23C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool animBg
		{
			get
			{
				return this.animBgField;
			}
			set
			{
				this.animBgField = value;
			}
		}

		// Token: 0x04001644 RID: 5700
		private string bldField;

		// Token: 0x04001645 RID: 5701
		private bool animBgField;
	}
}
