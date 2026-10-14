using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200032D RID: 813
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FillEffect
	{
		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x0005608B File Offset: 0x0005428B
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x00056093 File Offset: 0x00054293
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFill
		{
			get
			{
				return this.noFillField;
			}
			set
			{
				this.noFillField = value;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x0005609C File Offset: 0x0005429C
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x000560A4 File Offset: 0x000542A4
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFill
		{
			get
			{
				return this.solidFillField;
			}
			set
			{
				this.solidFillField = value;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x000560AD File Offset: 0x000542AD
		// (set) Token: 0x06002067 RID: 8295 RVA: 0x000560B5 File Offset: 0x000542B5
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFill
		{
			get
			{
				return this.gradFillField;
			}
			set
			{
				this.gradFillField = value;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x000560BE File Offset: 0x000542BE
		// (set) Token: 0x06002069 RID: 8297 RVA: 0x000560C6 File Offset: 0x000542C6
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFill
		{
			get
			{
				return this.blipFillField;
			}
			set
			{
				this.blipFillField = value;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x000560CF File Offset: 0x000542CF
		// (set) Token: 0x0600206B RID: 8299 RVA: 0x000560D7 File Offset: 0x000542D7
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFill
		{
			get
			{
				return this.pattFillField;
			}
			set
			{
				this.pattFillField = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x000560E0 File Offset: 0x000542E0
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x000560E8 File Offset: 0x000542E8
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFill
		{
			get
			{
				return this.grpFillField;
			}
			set
			{
				this.grpFillField = value;
			}
		}

		// Token: 0x04001922 RID: 6434
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x04001923 RID: 6435
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x04001924 RID: 6436
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x04001925 RID: 6437
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x04001926 RID: 6438
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x04001927 RID: 6439
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;
	}
}
