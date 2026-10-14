using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002E3 RID: 739
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PolarAdjustHandle
	{
		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0004E734 File Offset: 0x0004C934
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0004E73C File Offset: 0x0004C93C
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

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x0004E745 File Offset: 0x0004C945
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x0004E74D File Offset: 0x0004C94D
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string gdRefR
		{
			get
			{
				return this.gdRefRField;
			}
			set
			{
				this.gdRefRField = value;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x0004E756 File Offset: 0x0004C956
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x0004E75E File Offset: 0x0004C95E
		[global::System.Xml.Serialization.XmlAttribute]
		public string minR
		{
			get
			{
				return this.minRField;
			}
			set
			{
				this.minRField = value;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x0004E767 File Offset: 0x0004C967
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x0004E76F File Offset: 0x0004C96F
		[global::System.Xml.Serialization.XmlAttribute]
		public string maxR
		{
			get
			{
				return this.maxRField;
			}
			set
			{
				this.maxRField = value;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x0004E778 File Offset: 0x0004C978
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x0004E780 File Offset: 0x0004C980
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string gdRefAng
		{
			get
			{
				return this.gdRefAngField;
			}
			set
			{
				this.gdRefAngField = value;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x0004E789 File Offset: 0x0004C989
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x0004E791 File Offset: 0x0004C991
		[global::System.Xml.Serialization.XmlAttribute]
		public string minAng
		{
			get
			{
				return this.minAngField;
			}
			set
			{
				this.minAngField = value;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0004E79A File Offset: 0x0004C99A
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x0004E7A2 File Offset: 0x0004C9A2
		[global::System.Xml.Serialization.XmlAttribute]
		public string maxAng
		{
			get
			{
				return this.maxAngField;
			}
			set
			{
				this.maxAngField = value;
			}
		}

		// Token: 0x04001743 RID: 5955
		private global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D posField;

		// Token: 0x04001744 RID: 5956
		private string gdRefRField;

		// Token: 0x04001745 RID: 5957
		private string minRField;

		// Token: 0x04001746 RID: 5958
		private string maxRField;

		// Token: 0x04001747 RID: 5959
		private string gdRefAngField;

		// Token: 0x04001748 RID: 5960
		private string minAngField;

		// Token: 0x04001749 RID: 5961
		private string maxAngField;
	}
}
