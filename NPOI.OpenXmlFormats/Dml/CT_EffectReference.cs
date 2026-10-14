using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200033C RID: 828
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EffectReference
	{
		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x00056512 File Offset: 0x00054712
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x0005651A File Offset: 0x0005471A
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x04001944 RID: 6468
		private string refField;
	}
}
