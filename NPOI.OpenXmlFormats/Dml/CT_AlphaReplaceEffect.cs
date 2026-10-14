using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200033A RID: 826
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AlphaReplaceEffect
	{
		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x000564F0 File Offset: 0x000546F0
		// (set) Token: 0x060020B3 RID: 8371 RVA: 0x000564F8 File Offset: 0x000546F8
		[global::System.Xml.Serialization.XmlAttribute]
		public int a
		{
			get
			{
				return this.aField;
			}
			set
			{
				this.aField = value;
			}
		}

		// Token: 0x04001942 RID: 6466
		private int aField;
	}
}
