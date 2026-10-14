using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000388 RID: 904
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Pt
	{
		// Token: 0x06002416 RID: 9238 RVA: 0x0005D21C File Offset: 0x0005B41C
		public CT_Pt()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
			this.tField = new global::NPOI.OpenXmlFormats.Dml.CT_TextBody();
			this.spPrField = new global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties();
			this.prSetField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ElemPropSet();
			this.typeField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_PtType.node;
			this.cxnIdField = "0";
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x0005D26D File Offset: 0x0005B46D
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x0005D275 File Offset: 0x0005B475
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ElemPropSet prSet
		{
			get
			{
				return this.prSetField;
			}
			set
			{
				this.prSetField = value;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x0005D27E File Offset: 0x0005B47E
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x0005D286 File Offset: 0x0005B486
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPr
		{
			get
			{
				return this.spPrField;
			}
			set
			{
				this.spPrField = value;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x0005D28F File Offset: 0x0005B48F
		// (set) Token: 0x0600241C RID: 9244 RVA: 0x0005D297 File Offset: 0x0005B497
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBody t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x0005D2A0 File Offset: 0x0005B4A0
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x0005D2A8 File Offset: 0x0005B4A8
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x0005D2B1 File Offset: 0x0005B4B1
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x0005D2B9 File Offset: 0x0005B4B9
		[global::System.Xml.Serialization.XmlAttribute]
		public string modelId
		{
			get
			{
				return this.modelIdField;
			}
			set
			{
				this.modelIdField = value;
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x0005D2C2 File Offset: 0x0005B4C2
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x0005D2CA File Offset: 0x0005B4CA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_PtType.node)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_PtType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x0005D2D3 File Offset: 0x0005B4D3
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x0005D2DB File Offset: 0x0005B4DB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("0")]
		public string cxnId
		{
			get
			{
				return this.cxnIdField;
			}
			set
			{
				this.cxnIdField = value;
			}
		}

		// Token: 0x04001AB3 RID: 6835
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ElemPropSet prSetField;

		// Token: 0x04001AB4 RID: 6836
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPrField;

		// Token: 0x04001AB5 RID: 6837
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBody tField;

		// Token: 0x04001AB6 RID: 6838
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001AB7 RID: 6839
		private string modelIdField;

		// Token: 0x04001AB8 RID: 6840
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_PtType typeField;

		// Token: 0x04001AB9 RID: 6841
		private string cxnIdField;
	}
}
