using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002AA RID: 682
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FixedPercentage
	{
		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x0004A5EC File Offset: 0x000487EC
		// (set) Token: 0x06001B86 RID: 7046 RVA: 0x0004A5F4 File Offset: 0x000487F4
		[global::System.Xml.Serialization.XmlAttribute]
		public int val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x040014E3 RID: 5347
		private int valField;
	}
}
