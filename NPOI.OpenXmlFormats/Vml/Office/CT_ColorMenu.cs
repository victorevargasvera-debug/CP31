using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000215 RID: 533
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ColorMenu
	{
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00041AA0 File Offset: 0x0003FCA0
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00041AA8 File Offset: 0x0003FCA8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.ST_Ext ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x00041AB1 File Offset: 0x0003FCB1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x00041ABC File Offset: 0x0003FCBC
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x00041AC4 File Offset: 0x0003FCC4
		[global::System.Xml.Serialization.XmlAttribute]
		public string strokecolor
		{
			get
			{
				return this.strokecolorField;
			}
			set
			{
				this.strokecolorField = value;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00041ACD File Offset: 0x0003FCCD
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x00041AD5 File Offset: 0x0003FCD5
		[global::System.Xml.Serialization.XmlAttribute]
		public string fillcolor
		{
			get
			{
				return this.fillcolorField;
			}
			set
			{
				this.fillcolorField = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x00041ADE File Offset: 0x0003FCDE
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x00041AE6 File Offset: 0x0003FCE6
		[global::System.Xml.Serialization.XmlAttribute]
		public string shadowcolor
		{
			get
			{
				return this.shadowcolorField;
			}
			set
			{
				this.shadowcolorField = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x00041AEF File Offset: 0x0003FCEF
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x00041AF7 File Offset: 0x0003FCF7
		[global::System.Xml.Serialization.XmlAttribute]
		public string extrusioncolor
		{
			get
			{
				return this.extrusioncolorField;
			}
			set
			{
				this.extrusioncolorField = value;
			}
		}

		// Token: 0x04001146 RID: 4422
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x04001147 RID: 4423
		private string strokecolorField;

		// Token: 0x04001148 RID: 4424
		private string fillcolorField;

		// Token: 0x04001149 RID: 4425
		private string shadowcolorField;

		// Token: 0x0400114A RID: 4426
		private string extrusioncolorField;
	}
}
