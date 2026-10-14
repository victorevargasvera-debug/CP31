using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000255 RID: 597
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TableBackgroundStyle
	{
		// Token: 0x06001842 RID: 6210 RVA: 0x000439DB File Offset: 0x00041BDB
		public CT_TableBackgroundStyle()
		{
			this.effectRefField = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference();
			this.effectField = new global::NPOI.OpenXmlFormats.Dml.CT_EffectProperties();
			this.fillRefField = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference();
			this.fillField = new global::NPOI.OpenXmlFormats.Dml.CT_FillProperties();
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00043A0F File Offset: 0x00041C0F
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x00043A17 File Offset: 0x00041C17
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FillProperties fill
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

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00043A20 File Offset: 0x00041C20
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x00043A28 File Offset: 0x00041C28
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference fillRef
		{
			get
			{
				return this.fillRefField;
			}
			set
			{
				this.fillRefField = value;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x00043A31 File Offset: 0x00041C31
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x00043A39 File Offset: 0x00041C39
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EffectProperties effect
		{
			get
			{
				return this.effectField;
			}
			set
			{
				this.effectField = value;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x00043A42 File Offset: 0x00041C42
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x00043A4A File Offset: 0x00041C4A
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference effectRef
		{
			get
			{
				return this.effectRefField;
			}
			set
			{
				this.effectRefField = value;
			}
		}

		// Token: 0x040012A4 RID: 4772
		private global::NPOI.OpenXmlFormats.Dml.CT_FillProperties fillField;

		// Token: 0x040012A5 RID: 4773
		private global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference fillRefField;

		// Token: 0x040012A6 RID: 4774
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectProperties effectField;

		// Token: 0x040012A7 RID: 4775
		private global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference effectRefField;
	}
}
