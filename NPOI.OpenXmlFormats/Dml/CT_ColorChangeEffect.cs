using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000330 RID: 816
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ColorChangeEffect
	{
		// Token: 0x0600207E RID: 8318 RVA: 0x0005617B File Offset: 0x0005437B
		public CT_ColorChangeEffect()
		{
			this.clrToField = new global::NPOI.OpenXmlFormats.Dml.CT_Color();
			this.clrFromField = new global::NPOI.OpenXmlFormats.Dml.CT_Color();
			this.useAField = true;
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x000561A0 File Offset: 0x000543A0
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x000561A8 File Offset: 0x000543A8
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color clrFrom
		{
			get
			{
				return this.clrFromField;
			}
			set
			{
				this.clrFromField = value;
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x000561B1 File Offset: 0x000543B1
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x000561B9 File Offset: 0x000543B9
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color clrTo
		{
			get
			{
				return this.clrToField;
			}
			set
			{
				this.clrToField = value;
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x000561C2 File Offset: 0x000543C2
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x000561CA File Offset: 0x000543CA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool useA
		{
			get
			{
				return this.useAField;
			}
			set
			{
				this.useAField = value;
			}
		}

		// Token: 0x0400192F RID: 6447
		private global::NPOI.OpenXmlFormats.Dml.CT_Color clrFromField;

		// Token: 0x04001930 RID: 6448
		private global::NPOI.OpenXmlFormats.Dml.CT_Color clrToField;

		// Token: 0x04001931 RID: 6449
		private bool useAField;
	}
}
