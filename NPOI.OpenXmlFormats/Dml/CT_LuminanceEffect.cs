using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000318 RID: 792
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LuminanceEffect
	{
		// Token: 0x06001F86 RID: 8070 RVA: 0x00054534 File Offset: 0x00052734
		public CT_LuminanceEffect()
		{
			this.brightField = 0;
			this.contrastField = 0;
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x0005454A File Offset: 0x0005274A
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x00054552 File Offset: 0x00052752
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int bright
		{
			get
			{
				return this.brightField;
			}
			set
			{
				this.brightField = value;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0005455B File Offset: 0x0005275B
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x00054563 File Offset: 0x00052763
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int contrast
		{
			get
			{
				return this.contrastField;
			}
			set
			{
				this.contrastField = value;
			}
		}

		// Token: 0x0400188B RID: 6283
		private int brightField;

		// Token: 0x0400188C RID: 6284
		private int contrastField;
	}
}
