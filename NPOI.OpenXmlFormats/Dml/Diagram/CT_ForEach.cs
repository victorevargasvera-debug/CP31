using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200039F RID: 927
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ForEach
	{
		// Token: 0x060024A9 RID: 9385 RVA: 0x0005D984 File Offset: 0x0005BB84
		public CT_ForEach()
		{
			this.stepField = new global::System.Collections.Generic.List<int>();
			this.cntField = new global::System.Collections.Generic.List<uint>();
			this.stField = new global::System.Collections.Generic.List<int>();
			this.hideLastTransField = new global::System.Collections.Generic.List<bool>();
			this.ptTypeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType>();
			this.axisField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AxisType>();
			this.itemsField = new global::System.Collections.Generic.List<object>();
			this.nameField = "";
			this.refField = "";
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

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x0005DA71 File Offset: 0x0005BC71
		// (set) Token: 0x060024AB RID: 9387 RVA: 0x0005DA79 File Offset: 0x0005BC79
		[global::System.Xml.Serialization.XmlElement("alg", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Algorithm), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("choose", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Choose), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("constrLst", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Constraints), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("extLst", typeof(global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("forEach", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ForEach), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("layoutNode", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_LayoutNode), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("presOf", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_PresentationOf), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("ruleLst", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Rules), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("shape", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Shape), Order = 0)]
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x0005DA82 File Offset: 0x0005BC82
		// (set) Token: 0x060024AD RID: 9389 RVA: 0x0005DA8A File Offset: 0x0005BC8A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
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

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x0005DA93 File Offset: 0x0005BC93
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x0005DA9B File Offset: 0x0005BC9B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x0005DAA4 File Offset: 0x0005BCA4
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x0005DAAC File Offset: 0x0005BCAC
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

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x0005DAB5 File Offset: 0x0005BCB5
		// (set) Token: 0x060024B3 RID: 9395 RVA: 0x0005DABD File Offset: 0x0005BCBD
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

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x0005DAC6 File Offset: 0x0005BCC6
		// (set) Token: 0x060024B5 RID: 9397 RVA: 0x0005DACE File Offset: 0x0005BCCE
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

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x0005DAD7 File Offset: 0x0005BCD7
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x0005DADF File Offset: 0x0005BCDF
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

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x0005DAE8 File Offset: 0x0005BCE8
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x0005DAF0 File Offset: 0x0005BCF0
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

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x0005DAF9 File Offset: 0x0005BCF9
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x0005DB01 File Offset: 0x0005BD01
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

		// Token: 0x04001B99 RID: 7065
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04001B9A RID: 7066
		private string nameField;

		// Token: 0x04001B9B RID: 7067
		private string refField;

		// Token: 0x04001B9C RID: 7068
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AxisType> axisField;

		// Token: 0x04001B9D RID: 7069
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType> ptTypeField;

		// Token: 0x04001B9E RID: 7070
		private global::System.Collections.Generic.List<bool> hideLastTransField;

		// Token: 0x04001B9F RID: 7071
		private global::System.Collections.Generic.List<int> stField;

		// Token: 0x04001BA0 RID: 7072
		private global::System.Collections.Generic.List<uint> cntField;

		// Token: 0x04001BA1 RID: 7073
		private global::System.Collections.Generic.List<int> stepField;
	}
}
