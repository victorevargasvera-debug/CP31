using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001F3 RID: 499
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RoundRect
	{
		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0003FF9F File Offset: 0x0003E19F
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x0003FFA7 File Offset: 0x0003E1A7
		[global::System.Xml.Serialization.XmlAttribute]
		public string arcsize
		{
			get
			{
				return this.arcsizeField;
			}
			set
			{
				this.arcsizeField = value;
			}
		}

		// Token: 0x04000F7C RID: 3964
		private string arcsizeField;
	}
}
