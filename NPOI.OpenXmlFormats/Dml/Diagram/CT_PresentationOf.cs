using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003A0 RID: 928
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PresentationOf
	{
		// Token: 0x060024BC RID: 9404 RVA: 0x0005DB0C File Offset: 0x0005BD0C
		public CT_PresentationOf()
		{
			this.stepField = new global::System.Collections.Generic.List<int>();
			this.cntField = new global::System.Collections.Generic.List<uint>();
			this.stField = new global::System.Collections.Generic.List<int>();
			this.hideLastTransField = new global::System.Collections.Generic.List<bool>();
			this.ptTypeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType>();
			this.axisField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AxisType>();
			this.axisField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AxisType>(new global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AxisType[]
			{
				global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AxisType.none
			});
			this.ptTypeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType>(new global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType[1]);
			this.hideLastTransField = new global::System.Collections.Generic.List<bool>(new bool[]
			{
				true
			});
			this.stField = new global::System.Collections.Generic.List<int>(new int[]
			{
				1
			});
			this.cntField = new global::System.Collections.Generic.List<uint>(new uint[1]);
			this.stepField = new global::System.Collections.Generic.List<int>(new int[]
			{
				1
			});
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x0005DBD8 File Offset: 0x0005BDD8
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x0005DBE0 File Offset: 0x0005BDE0
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

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x0005DBE9 File Offset: 0x0005BDE9
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x0005DBF1 File Offset: 0x0005BDF1
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AxisType> axis
		{
			get
			{
				return this.axisField;
			}
			set
			{
				this.axisField = value;
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x0005DBFA File Offset: 0x0005BDFA
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x0005DC02 File Offset: 0x0005BE02
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType> ptType
		{
			get
			{
				return this.ptTypeField;
			}
			set
			{
				this.ptTypeField = value;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x0005DC0B File Offset: 0x0005BE0B
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x0005DC13 File Offset: 0x0005BE13
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.Collections.Generic.List<bool> hideLastTrans
		{
			get
			{
				return this.hideLastTransField;
			}
			set
			{
				this.hideLastTransField = value;
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x060024C5 RID: 9413 RVA: 0x0005DC1C File Offset: 0x0005BE1C
		// (set) Token: 0x060024C6 RID: 9414 RVA: 0x0005DC24 File Offset: 0x0005BE24
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.Collections.Generic.List<int> st
		{
			get
			{
				return this.stField;
			}
			set
			{
				this.stField = value;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060024C7 RID: 9415 RVA: 0x0005DC2D File Offset: 0x0005BE2D
		// (set) Token: 0x060024C8 RID: 9416 RVA: 0x0005DC35 File Offset: 0x0005BE35
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.Collections.Generic.List<uint> cnt
		{
			get
			{
				return this.cntField;
			}
			set
			{
				this.cntField = value;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060024C9 RID: 9417 RVA: 0x0005DC3E File Offset: 0x0005BE3E
		// (set) Token: 0x060024CA RID: 9418 RVA: 0x0005DC46 File Offset: 0x0005BE46
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.Collections.Generic.List<int> step
		{
			get
			{
				return this.stepField;
			}
			set
			{
				this.stepField = value;
			}
		}

		// Token: 0x04001BA2 RID: 7074
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001BA3 RID: 7075
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AxisType> axisField;

		// Token: 0x04001BA4 RID: 7076
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType> ptTypeField;

		// Token: 0x04001BA5 RID: 7077
		private global::System.Collections.Generic.List<bool> hideLastTransField;

		// Token: 0x04001BA6 RID: 7078
		private global::System.Collections.Generic.List<int> stField;

		// Token: 0x04001BA7 RID: 7079
		private global::System.Collections.Generic.List<uint> cntField;

		// Token: 0x04001BA8 RID: 7080
		private global::System.Collections.Generic.List<int> stepField;
	}
}
