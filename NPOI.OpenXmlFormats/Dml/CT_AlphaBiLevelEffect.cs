using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200030F RID: 783
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AlphaBiLevelEffect
	{
		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x000536FE File Offset: 0x000518FE
		// (set) Token: 0x06001F13 RID: 7955 RVA: 0x00053706 File Offset: 0x00051906
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

		// Token: 0x04001844 RID: 6212
		private int threshField;
	}
}
