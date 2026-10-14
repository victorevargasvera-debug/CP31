using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000311 RID: 785
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TintEffect
	{
		// Token: 0x06001F22 RID: 7970 RVA: 0x000537B1 File Offset: 0x000519B1
		public CT_TintEffect()
		{
			this.hueField = 0;
			this.amtField = 0;
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x000537C7 File Offset: 0x000519C7
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x000537CF File Offset: 0x000519CF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int hue
		{
			get
			{
				return this.hueField;
			}
			set
			{
				this.hueField = value;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x000537D8 File Offset: 0x000519D8
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x000537E0 File Offset: 0x000519E0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int amt
		{
			get
			{
				return this.amtField;
			}
			set
			{
				this.amtField = value;
			}
		}

		// Token: 0x0400184B RID: 6219
		private int hueField;

		// Token: 0x0400184C RID: 6220
		private int amtField;
	}
}
