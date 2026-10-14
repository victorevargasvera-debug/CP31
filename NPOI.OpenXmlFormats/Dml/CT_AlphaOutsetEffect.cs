using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000339 RID: 825
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AlphaOutsetEffect
	{
		// Token: 0x060020AF RID: 8367 RVA: 0x000564CF File Offset: 0x000546CF
		public CT_AlphaOutsetEffect()
		{
			this.radField = 0L;
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x000564DF File Offset: 0x000546DF
		// (set) Token: 0x060020B1 RID: 8369 RVA: 0x000564E7 File Offset: 0x000546E7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long rad
		{
			get
			{
				return this.radField;
			}
			set
			{
				this.radField = value;
			}
		}

		// Token: 0x04001941 RID: 6465
		private long radField;
	}
}
