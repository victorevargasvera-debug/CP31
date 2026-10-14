using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000389 RID: 905
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Cxn
	{
		// Token: 0x06002425 RID: 9253 RVA: 0x0005D2E4 File Offset: 0x0005B4E4
		public CT_Cxn()
		{
			this.typeField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_CxnType.parOf;
			this.parTransIdField = "0";
			this.sibTransIdField = "0";
			this.presIdField = "";
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06002426 RID: 9254 RVA: 0x0005D314 File Offset: 0x0005B514
		// (set) Token: 0x06002427 RID: 9255 RVA: 0x0005D31C File Offset: 0x0005B51C
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x0005D325 File Offset: 0x0005B525
		// (set) Token: 0x06002429 RID: 9257 RVA: 0x0005D32D File Offset: 0x0005B52D
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

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x0600242A RID: 9258 RVA: 0x0005D336 File Offset: 0x0005B536
		// (set) Token: 0x0600242B RID: 9259 RVA: 0x0005D33E File Offset: 0x0005B53E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_CxnType.parOf)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_CxnType type
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

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x0600242C RID: 9260 RVA: 0x0005D347 File Offset: 0x0005B547
		// (set) Token: 0x0600242D RID: 9261 RVA: 0x0005D34F File Offset: 0x0005B54F
		[global::System.Xml.Serialization.XmlAttribute]
		public string srcId
		{
			get
			{
				return this.srcIdField;
			}
			set
			{
				this.srcIdField = value;
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x0005D358 File Offset: 0x0005B558
		// (set) Token: 0x0600242F RID: 9263 RVA: 0x0005D360 File Offset: 0x0005B560
		[global::System.Xml.Serialization.XmlAttribute]
		public string destId
		{
			get
			{
				return this.destIdField;
			}
			set
			{
				this.destIdField = value;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x0005D369 File Offset: 0x0005B569
		// (set) Token: 0x06002431 RID: 9265 RVA: 0x0005D371 File Offset: 0x0005B571
		[global::System.Xml.Serialization.XmlAttribute]
		public uint srcOrd
		{
			get
			{
				return this.srcOrdField;
			}
			set
			{
				this.srcOrdField = value;
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002432 RID: 9266 RVA: 0x0005D37A File Offset: 0x0005B57A
		// (set) Token: 0x06002433 RID: 9267 RVA: 0x0005D382 File Offset: 0x0005B582
		[global::System.Xml.Serialization.XmlAttribute]
		public uint destOrd
		{
			get
			{
				return this.destOrdField;
			}
			set
			{
				this.destOrdField = value;
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x0005D38B File Offset: 0x0005B58B
		// (set) Token: 0x06002435 RID: 9269 RVA: 0x0005D393 File Offset: 0x0005B593
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("0")]
		public string parTransId
		{
			get
			{
				return this.parTransIdField;
			}
			set
			{
				this.parTransIdField = value;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x0005D39C File Offset: 0x0005B59C
		// (set) Token: 0x06002437 RID: 9271 RVA: 0x0005D3A4 File Offset: 0x0005B5A4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("0")]
		public string sibTransId
		{
			get
			{
				return this.sibTransIdField;
			}
			set
			{
				this.sibTransIdField = value;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x0005D3AD File Offset: 0x0005B5AD
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x0005D3B5 File Offset: 0x0005B5B5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string presId
		{
			get
			{
				return this.presIdField;
			}
			set
			{
				this.presIdField = value;
			}
		}

		// Token: 0x04001ABA RID: 6842
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001ABB RID: 6843
		private string modelIdField;

		// Token: 0x04001ABC RID: 6844
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_CxnType typeField;

		// Token: 0x04001ABD RID: 6845
		private string srcIdField;

		// Token: 0x04001ABE RID: 6846
		private string destIdField;

		// Token: 0x04001ABF RID: 6847
		private uint srcOrdField;

		// Token: 0x04001AC0 RID: 6848
		private uint destOrdField;

		// Token: 0x04001AC1 RID: 6849
		private string parTransIdField;

		// Token: 0x04001AC2 RID: 6850
		private string sibTransIdField;

		// Token: 0x04001AC3 RID: 6851
		private string presIdField;
	}
}
