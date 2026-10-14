using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000398 RID: 920
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_When
	{
		// Token: 0x06002474 RID: 9332 RVA: 0x0005D63C File Offset: 0x0005B83C
		public CT_When()
		{
			this.stepField = new global::System.Collections.Generic.List<int>();
			this.cntField = new global::System.Collections.Generic.List<uint>();
			this.stField = new global::System.Collections.Generic.List<int>();
			this.hideLastTransField = new global::System.Collections.Generic.List<bool>();
			this.ptTypeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType>();
			this.axisField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AxisType>();
			this.itemsField = new global::System.Collections.Generic.List<object>();
			this.nameField = "";
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
			this.argField = "none";
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x0005D729 File Offset: 0x0005B929
		// (set) Token: 0x06002476 RID: 9334 RVA: 0x0005D731 File Offset: 0x0005B931
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

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x0005D73A File Offset: 0x0005B93A
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x0005D742 File Offset: 0x0005B942
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

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x0005D74B File Offset: 0x0005B94B
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x0005D753 File Offset: 0x0005B953
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

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x0005D75C File Offset: 0x0005B95C
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x0005D764 File Offset: 0x0005B964
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

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x0005D76D File Offset: 0x0005B96D
		// (set) Token: 0x0600247E RID: 9342 RVA: 0x0005D775 File Offset: 0x0005B975
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

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x0005D77E File Offset: 0x0005B97E
		// (set) Token: 0x06002480 RID: 9344 RVA: 0x0005D786 File Offset: 0x0005B986
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

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x0005D78F File Offset: 0x0005B98F
		// (set) Token: 0x06002482 RID: 9346 RVA: 0x0005D797 File Offset: 0x0005B997
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

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x0005D7A0 File Offset: 0x0005B9A0
		// (set) Token: 0x06002484 RID: 9348 RVA: 0x0005D7A8 File Offset: 0x0005B9A8
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

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x0005D7B1 File Offset: 0x0005B9B1
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x0005D7B9 File Offset: 0x0005B9B9
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_FunctionType func
		{
			get
			{
				return this.funcField;
			}
			set
			{
				this.funcField = value;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x0005D7C2 File Offset: 0x0005B9C2
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x0005D7CA File Offset: 0x0005B9CA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("none")]
		public string arg
		{
			get
			{
				return this.argField;
			}
			set
			{
				this.argField = value;
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x0005D7D3 File Offset: 0x0005B9D3
		// (set) Token: 0x0600248A RID: 9354 RVA: 0x0005D7DB File Offset: 0x0005B9DB
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_FunctionOperator op
		{
			get
			{
				return this.opField;
			}
			set
			{
				this.opField = value;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x0005D7E4 File Offset: 0x0005B9E4
		// (set) Token: 0x0600248C RID: 9356 RVA: 0x0005D7EC File Offset: 0x0005B9EC
		[global::System.Xml.Serialization.XmlAttribute]
		public string val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x04001B2B RID: 6955
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04001B2C RID: 6956
		private string nameField;

		// Token: 0x04001B2D RID: 6957
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AxisType> axisField;

		// Token: 0x04001B2E RID: 6958
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ElementType> ptTypeField;

		// Token: 0x04001B2F RID: 6959
		private global::System.Collections.Generic.List<bool> hideLastTransField;

		// Token: 0x04001B30 RID: 6960
		private global::System.Collections.Generic.List<int> stField;

		// Token: 0x04001B31 RID: 6961
		private global::System.Collections.Generic.List<uint> cntField;

		// Token: 0x04001B32 RID: 6962
		private global::System.Collections.Generic.List<int> stepField;

		// Token: 0x04001B33 RID: 6963
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_FunctionType funcField;

		// Token: 0x04001B34 RID: 6964
		private string argField;

		// Token: 0x04001B35 RID: 6965
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_FunctionOperator opField;

		// Token: 0x04001B36 RID: 6966
		private string valField;
	}
}
