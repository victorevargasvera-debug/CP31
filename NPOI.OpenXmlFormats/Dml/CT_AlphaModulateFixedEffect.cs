using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000338 RID: 824
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AlphaModulateFixedEffect
	{
		// Token: 0x060020AC RID: 8364 RVA: 0x000564AB File Offset: 0x000546AB
		public CT_AlphaModulateFixedEffect()
		{
			this.amtField = 100000;
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x000564BE File Offset: 0x000546BE
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x000564C6 File Offset: 0x000546C6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(100000)]
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

		// Token: 0x04001940 RID: 6464
		private int amtField;
	}
}
