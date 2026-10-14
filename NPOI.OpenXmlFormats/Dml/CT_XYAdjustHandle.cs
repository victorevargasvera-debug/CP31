using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002E2 RID: 738
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_XYAdjustHandle
	{
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x0004E6BD File Offset: 0x0004C8BD
		// (set) Token: 0x06001CBA RID: 7354 RVA: 0x0004E6C5 File Offset: 0x0004C8C5
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x0004E6CE File Offset: 0x0004C8CE
		// (set) Token: 0x06001CBC RID: 7356 RVA: 0x0004E6D6 File Offset: 0x0004C8D6
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string gdRefX
		{
			get
			{
				return this.gdRefXField;
			}
			set
			{
				this.gdRefXField = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0004E6DF File Offset: 0x0004C8DF
		// (set) Token: 0x06001CBE RID: 7358 RVA: 0x0004E6E7 File Offset: 0x0004C8E7
		[global::System.Xml.Serialization.XmlAttribute]
		public string minX
		{
			get
			{
				return this.minXField;
			}
			set
			{
				this.minXField = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x0004E6F0 File Offset: 0x0004C8F0
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x0004E6F8 File Offset: 0x0004C8F8
		[global::System.Xml.Serialization.XmlAttribute]
		public string maxX
		{
			get
			{
				return this.maxXField;
			}
			set
			{
				this.maxXField = value;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x0004E701 File Offset: 0x0004C901
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x0004E709 File Offset: 0x0004C909
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string gdRefY
		{
			get
			{
				return this.gdRefYField;
			}
			set
			{
				this.gdRefYField = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x0004E712 File Offset: 0x0004C912
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x0004E71A File Offset: 0x0004C91A
		[global::System.Xml.Serialization.XmlAttribute]
		public string minY
		{
			get
			{
				return this.minYField;
			}
			set
			{
				this.minYField = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x0004E723 File Offset: 0x0004C923
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x0004E72B File Offset: 0x0004C92B
		[global::System.Xml.Serialization.XmlAttribute]
		public string maxY
		{
			get
			{
				return this.maxYField;
			}
			set
			{
				this.maxYField = value;
			}
		}

		// Token: 0x0400173C RID: 5948
		private global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D posField;

		// Token: 0x0400173D RID: 5949
		private string gdRefXField;

		// Token: 0x0400173E RID: 5950
		private string minXField;

		// Token: 0x0400173F RID: 5951
		private string maxXField;

		// Token: 0x04001740 RID: 5952
		private string gdRefYField;

		// Token: 0x04001741 RID: 5953
		private string minYField;

		// Token: 0x04001742 RID: 5954
		private string maxYField;
	}
}
