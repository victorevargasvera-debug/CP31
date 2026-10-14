using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200033B RID: 827
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BiLevelEffect
	{
		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x00056501 File Offset: 0x00054701
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x00056509 File Offset: 0x00054709
		[global::System.Xml.Serialization.XmlAttribute]
		public int thresh
		{
			get
			{
				return this.threshField;
			}
			set
			{
				this.threshField = value;
			}
		}

		// Token: 0x04001943 RID: 6467
		private int threshField;
	}
}
