using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002A9 RID: 681
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PositivePercentage
	{
		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x0004A5DB File Offset: 0x000487DB
		// (set) Token: 0x06001B83 RID: 7043 RVA: 0x0004A5E3 File Offset: 0x000487E3
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

		// Token: 0x040014E2 RID: 5346
		private int valField;
	}
}
