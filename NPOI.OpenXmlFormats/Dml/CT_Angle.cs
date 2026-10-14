using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002A6 RID: 678
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Angle
	{
		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x0004A5A8 File Offset: 0x000487A8
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x0004A5B0 File Offset: 0x000487B0
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

		// Token: 0x040014DF RID: 5343
		private int valField;
	}
}
