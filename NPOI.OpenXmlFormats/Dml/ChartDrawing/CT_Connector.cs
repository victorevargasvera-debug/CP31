using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x02000473 RID: 1139
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Connector
	{
		// Token: 0x06002D7D RID: 11645 RVA: 0x00072ABE File Offset: 0x00070CBE
		public CT_Connector()
		{
			this.nvCxnSpPrField = new global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_ConnectorNonVisual();
			this.fPublishedField = false;
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x00072AD8 File Offset: 0x00070CD8
		// (set) Token: 0x06002D7F RID: 11647 RVA: 0x00072AE0 File Offset: 0x00070CE0
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_ConnectorNonVisual nvCxnSpPr
		{
			get
			{
				return this.nvCxnSpPrField;
			}
			set
			{
				this.nvCxnSpPrField = value;
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06002D80 RID: 11648 RVA: 0x00072AE9 File Offset: 0x00070CE9
		// (set) Token: 0x06002D81 RID: 11649 RVA: 0x00072AF1 File Offset: 0x00070CF1
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

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06002D82 RID: 11650 RVA: 0x00072AFA File Offset: 0x00070CFA
		// (set) Token: 0x06002D83 RID: 11651 RVA: 0x00072B02 File Offset: 0x00070D02
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle style
		{
			get
			{
				return this.styleField;
			}
			set
			{
				this.styleField = value;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x00072B0B File Offset: 0x00070D0B
		// (set) Token: 0x06002D85 RID: 11653 RVA: 0x00072B13 File Offset: 0x00070D13
		[global::System.Xml.Serialization.XmlAttribute]
		public string macro
		{
			get
			{
				return this.macroField;
			}
			set
			{
				this.macroField = value;
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x00072B1C File Offset: 0x00070D1C
		// (set) Token: 0x06002D87 RID: 11655 RVA: 0x00072B24 File Offset: 0x00070D24
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool fPublished
		{
			get
			{
				return this.fPublishedField;
			}
			set
			{
				this.fPublishedField = value;
			}
		}

		// Token: 0x04001F9F RID: 8095
		private global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_ConnectorNonVisual nvCxnSpPrField;

		// Token: 0x04001FA0 RID: 8096
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPrField;

		// Token: 0x04001FA1 RID: 8097
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle styleField;

		// Token: 0x04001FA2 RID: 8098
		private string macroField;

		// Token: 0x04001FA3 RID: 8099
		private bool fPublishedField;
	}
}
