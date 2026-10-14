using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000340 RID: 832
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FillProperties
	{
		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x00056664 File Offset: 0x00054864
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x0005666C File Offset: 0x0005486C
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

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x00056675 File Offset: 0x00054875
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x0005667D File Offset: 0x0005487D
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

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x00056686 File Offset: 0x00054886
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x0005668E File Offset: 0x0005488E
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

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x00056697 File Offset: 0x00054897
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x0005669F File Offset: 0x0005489F
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

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x000566A8 File Offset: 0x000548A8
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x000566B0 File Offset: 0x000548B0
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

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x000566B9 File Offset: 0x000548B9
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x000566C1 File Offset: 0x000548C1
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

		// Token: 0x0400194F RID: 6479
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x04001950 RID: 6480
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x04001951 RID: 6481
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x04001952 RID: 6482
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x04001953 RID: 6483
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x04001954 RID: 6484
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;
	}
}
