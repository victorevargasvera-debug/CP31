using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001F7 RID: 503
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Background
	{
		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0003FFB0 File Offset: 0x0003E1B0
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x0003FFB8 File Offset: 0x0003E1B8
		public global::NPOI.OpenXmlFormats.Vml.CT_Fill fill
		{
			get
			{
				return this.fillField;
			}
			set
			{
				this.fillField = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x0003FFC1 File Offset: 0x0003E1C1
		// (set) Token: 0x06001480 RID: 5248 RVA: 0x0003FFC9 File Offset: 0x0003E1C9
		[global::System.Xml.Serialization.XmlAttribute]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0003FFD2 File Offset: 0x0003E1D2
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x0003FFDA File Offset: 0x0003E1DA
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse filled
		{
			get
			{
				return this.filledField;
			}
			set
			{
				this.filledField = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0003FFE3 File Offset: 0x0003E1E3
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x0003FFEB File Offset: 0x0003E1EB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool filledSpecified
		{
			get
			{
				return this.filledFieldSpecified;
			}
			set
			{
				this.filledFieldSpecified = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0003FFF4 File Offset: 0x0003E1F4
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x0003FFFC File Offset: 0x0003E1FC
		[global::System.Xml.Serialization.XmlAttribute]
		public string fillcolor
		{
			get
			{
				return this.fillcolorField;
			}
			set
			{
				this.fillcolorField = value;
			}
		}

		// Token: 0x04000FB4 RID: 4020
		private global::NPOI.OpenXmlFormats.Vml.CT_Fill fillField;

		// Token: 0x04000FB5 RID: 4021
		private string idField;

		// Token: 0x04000FB6 RID: 4022
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse filledField;

		// Token: 0x04000FB7 RID: 4023
		private bool filledFieldSpecified;

		// Token: 0x04000FB8 RID: 4024
		private string fillcolorField;
	}
}
