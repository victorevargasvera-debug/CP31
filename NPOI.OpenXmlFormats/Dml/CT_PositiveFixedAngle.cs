using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002A7 RID: 679
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PositiveFixedAngle
	{
		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x0004A5B9 File Offset: 0x000487B9
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0004A5C1 File Offset: 0x000487C1
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

		// Token: 0x040014E0 RID: 5344
		private int valField;
	}
}
