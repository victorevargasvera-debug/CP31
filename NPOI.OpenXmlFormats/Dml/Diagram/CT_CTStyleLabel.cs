using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000381 RID: 897
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.17379")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CTStyleLabel
	{
		// Token: 0x060023DB RID: 9179 RVA: 0x0005CF58 File Offset: 0x0005B158
		public CT_CTStyleLabel()
		{
			this.txEffectClrLstField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors();
			this.txFillClrLstField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors();
			this.txLinClrLstField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors();
			this.effectClrLstField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors();
			this.linClrLstField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors();
			this.fillClrLstField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors();
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x0005CFAD File Offset: 0x0005B1AD
		// (set) Token: 0x060023DD RID: 9181 RVA: 0x0005CFB5 File Offset: 0x0005B1B5
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors fillClrLst
		{
			get
			{
				return this.fillClrLstField;
			}
			set
			{
				this.fillClrLstField = value;
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x0005CFBE File Offset: 0x0005B1BE
		// (set) Token: 0x060023DF RID: 9183 RVA: 0x0005CFC6 File Offset: 0x0005B1C6
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors linClrLst
		{
			get
			{
				return this.linClrLstField;
			}
			set
			{
				this.linClrLstField = value;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x0005CFCF File Offset: 0x0005B1CF
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x0005CFD7 File Offset: 0x0005B1D7
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors effectClrLst
		{
			get
			{
				return this.effectClrLstField;
			}
			set
			{
				this.effectClrLstField = value;
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x0005CFE0 File Offset: 0x0005B1E0
		// (set) Token: 0x060023E3 RID: 9187 RVA: 0x0005CFE8 File Offset: 0x0005B1E8
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors txLinClrLst
		{
			get
			{
				return this.txLinClrLstField;
			}
			set
			{
				this.txLinClrLstField = value;
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x0005CFF1 File Offset: 0x0005B1F1
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x0005CFF9 File Offset: 0x0005B1F9
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors txFillClrLst
		{
			get
			{
				return this.txFillClrLstField;
			}
			set
			{
				this.txFillClrLstField = value;
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x0005D002 File Offset: 0x0005B202
		// (set) Token: 0x060023E7 RID: 9191 RVA: 0x0005D00A File Offset: 0x0005B20A
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors txEffectClrLst
		{
			get
			{
				return this.txEffectClrLstField;
			}
			set
			{
				this.txEffectClrLstField = value;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x0005D013 File Offset: 0x0005B213
		// (set) Token: 0x060023E9 RID: 9193 RVA: 0x0005D01B File Offset: 0x0005B21B
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x0005D024 File Offset: 0x0005B224
		// (set) Token: 0x060023EB RID: 9195 RVA: 0x0005D02C File Offset: 0x0005B22C
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x04001A99 RID: 6809
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors fillClrLstField;

		// Token: 0x04001A9A RID: 6810
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors linClrLstField;

		// Token: 0x04001A9B RID: 6811
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors effectClrLstField;

		// Token: 0x04001A9C RID: 6812
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors txLinClrLstField;

		// Token: 0x04001A9D RID: 6813
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors txFillClrLstField;

		// Token: 0x04001A9E RID: 6814
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Colors txEffectClrLstField;

		// Token: 0x04001A9F RID: 6815
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001AA0 RID: 6816
		private string nameField;
	}
}
