using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003B0 RID: 944
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ElemPropSet
	{
		// Token: 0x06002536 RID: 9526 RVA: 0x0005E1BD File Offset: 0x0005C3BD
		public CT_ElemPropSet()
		{
			this.styleField = new global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle();
			this.presLayoutVarsField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_LayoutVariablePropertySet();
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x0005E1DB File Offset: 0x0005C3DB
		// (set) Token: 0x06002538 RID: 9528 RVA: 0x0005E1E3 File Offset: 0x0005C3E3
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_LayoutVariablePropertySet presLayoutVars
		{
			get
			{
				return this.presLayoutVarsField;
			}
			set
			{
				this.presLayoutVarsField = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x0005E1EC File Offset: 0x0005C3EC
		// (set) Token: 0x0600253A RID: 9530 RVA: 0x0005E1F4 File Offset: 0x0005C3F4
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x0005E1FD File Offset: 0x0005C3FD
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x0005E205 File Offset: 0x0005C405
		[global::System.Xml.Serialization.XmlAttribute]
		public string presAssocID
		{
			get
			{
				return this.presAssocIDField;
			}
			set
			{
				this.presAssocIDField = value;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x0005E20E File Offset: 0x0005C40E
		// (set) Token: 0x0600253E RID: 9534 RVA: 0x0005E216 File Offset: 0x0005C416
		[global::System.Xml.Serialization.XmlAttribute]
		public string presName
		{
			get
			{
				return this.presNameField;
			}
			set
			{
				this.presNameField = value;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x0005E21F File Offset: 0x0005C41F
		// (set) Token: 0x06002540 RID: 9536 RVA: 0x0005E227 File Offset: 0x0005C427
		[global::System.Xml.Serialization.XmlAttribute]
		public string presStyleLbl
		{
			get
			{
				return this.presStyleLblField;
			}
			set
			{
				this.presStyleLblField = value;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x0005E230 File Offset: 0x0005C430
		// (set) Token: 0x06002542 RID: 9538 RVA: 0x0005E238 File Offset: 0x0005C438
		[global::System.Xml.Serialization.XmlAttribute]
		public int presStyleIdx
		{
			get
			{
				return this.presStyleIdxField;
			}
			set
			{
				this.presStyleIdxField = value;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x0005E241 File Offset: 0x0005C441
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x0005E249 File Offset: 0x0005C449
		[global::System.Xml.Serialization.XmlIgnore]
		public bool presStyleIdxSpecified
		{
			get
			{
				return this.presStyleIdxFieldSpecified;
			}
			set
			{
				this.presStyleIdxFieldSpecified = value;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x0005E252 File Offset: 0x0005C452
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x0005E25A File Offset: 0x0005C45A
		[global::System.Xml.Serialization.XmlAttribute]
		public int presStyleCnt
		{
			get
			{
				return this.presStyleCntField;
			}
			set
			{
				this.presStyleCntField = value;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x0005E263 File Offset: 0x0005C463
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x0005E26B File Offset: 0x0005C46B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool presStyleCntSpecified
		{
			get
			{
				return this.presStyleCntFieldSpecified;
			}
			set
			{
				this.presStyleCntFieldSpecified = value;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x0005E274 File Offset: 0x0005C474
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x0005E27C File Offset: 0x0005C47C
		[global::System.Xml.Serialization.XmlAttribute]
		public string loTypeId
		{
			get
			{
				return this.loTypeIdField;
			}
			set
			{
				this.loTypeIdField = value;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x0005E285 File Offset: 0x0005C485
		// (set) Token: 0x0600254C RID: 9548 RVA: 0x0005E28D File Offset: 0x0005C48D
		[global::System.Xml.Serialization.XmlAttribute]
		public string loCatId
		{
			get
			{
				return this.loCatIdField;
			}
			set
			{
				this.loCatIdField = value;
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x0005E296 File Offset: 0x0005C496
		// (set) Token: 0x0600254E RID: 9550 RVA: 0x0005E29E File Offset: 0x0005C49E
		[global::System.Xml.Serialization.XmlAttribute]
		public string qsTypeId
		{
			get
			{
				return this.qsTypeIdField;
			}
			set
			{
				this.qsTypeIdField = value;
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x0005E2A7 File Offset: 0x0005C4A7
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x0005E2AF File Offset: 0x0005C4AF
		[global::System.Xml.Serialization.XmlAttribute]
		public string qsCatId
		{
			get
			{
				return this.qsCatIdField;
			}
			set
			{
				this.qsCatIdField = value;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x0005E2B8 File Offset: 0x0005C4B8
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x0005E2C0 File Offset: 0x0005C4C0
		[global::System.Xml.Serialization.XmlAttribute]
		public string csTypeId
		{
			get
			{
				return this.csTypeIdField;
			}
			set
			{
				this.csTypeIdField = value;
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x0005E2C9 File Offset: 0x0005C4C9
		// (set) Token: 0x06002554 RID: 9556 RVA: 0x0005E2D1 File Offset: 0x0005C4D1
		[global::System.Xml.Serialization.XmlAttribute]
		public string csCatId
		{
			get
			{
				return this.csCatIdField;
			}
			set
			{
				this.csCatIdField = value;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x0005E2DA File Offset: 0x0005C4DA
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x0005E2E2 File Offset: 0x0005C4E2
		[global::System.Xml.Serialization.XmlAttribute]
		public bool coherent3DOff
		{
			get
			{
				return this.coherent3DOffField;
			}
			set
			{
				this.coherent3DOffField = value;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x0005E2EB File Offset: 0x0005C4EB
		// (set) Token: 0x06002558 RID: 9560 RVA: 0x0005E2F3 File Offset: 0x0005C4F3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool coherent3DOffSpecified
		{
			get
			{
				return this.coherent3DOffFieldSpecified;
			}
			set
			{
				this.coherent3DOffFieldSpecified = value;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x0005E2FC File Offset: 0x0005C4FC
		// (set) Token: 0x0600255A RID: 9562 RVA: 0x0005E304 File Offset: 0x0005C504
		[global::System.Xml.Serialization.XmlAttribute]
		public string phldrT
		{
			get
			{
				return this.phldrTField;
			}
			set
			{
				this.phldrTField = value;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x0005E30D File Offset: 0x0005C50D
		// (set) Token: 0x0600255C RID: 9564 RVA: 0x0005E315 File Offset: 0x0005C515
		[global::System.Xml.Serialization.XmlAttribute]
		public bool phldr
		{
			get
			{
				return this.phldrField;
			}
			set
			{
				this.phldrField = value;
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x0005E31E File Offset: 0x0005C51E
		// (set) Token: 0x0600255E RID: 9566 RVA: 0x0005E326 File Offset: 0x0005C526
		[global::System.Xml.Serialization.XmlIgnore]
		public bool phldrSpecified
		{
			get
			{
				return this.phldrFieldSpecified;
			}
			set
			{
				this.phldrFieldSpecified = value;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x0005E32F File Offset: 0x0005C52F
		// (set) Token: 0x06002560 RID: 9568 RVA: 0x0005E337 File Offset: 0x0005C537
		[global::System.Xml.Serialization.XmlAttribute]
		public int custAng
		{
			get
			{
				return this.custAngField;
			}
			set
			{
				this.custAngField = value;
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x0005E340 File Offset: 0x0005C540
		// (set) Token: 0x06002562 RID: 9570 RVA: 0x0005E348 File Offset: 0x0005C548
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custAngSpecified
		{
			get
			{
				return this.custAngFieldSpecified;
			}
			set
			{
				this.custAngFieldSpecified = value;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x0005E351 File Offset: 0x0005C551
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x0005E359 File Offset: 0x0005C559
		[global::System.Xml.Serialization.XmlAttribute]
		public bool custFlipVert
		{
			get
			{
				return this.custFlipVertField;
			}
			set
			{
				this.custFlipVertField = value;
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x0005E362 File Offset: 0x0005C562
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x0005E36A File Offset: 0x0005C56A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custFlipVertSpecified
		{
			get
			{
				return this.custFlipVertFieldSpecified;
			}
			set
			{
				this.custFlipVertFieldSpecified = value;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x0005E373 File Offset: 0x0005C573
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x0005E37B File Offset: 0x0005C57B
		[global::System.Xml.Serialization.XmlAttribute]
		public bool custFlipHor
		{
			get
			{
				return this.custFlipHorField;
			}
			set
			{
				this.custFlipHorField = value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x0005E384 File Offset: 0x0005C584
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x0005E38C File Offset: 0x0005C58C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custFlipHorSpecified
		{
			get
			{
				return this.custFlipHorFieldSpecified;
			}
			set
			{
				this.custFlipHorFieldSpecified = value;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x0005E395 File Offset: 0x0005C595
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x0005E39D File Offset: 0x0005C59D
		[global::System.Xml.Serialization.XmlAttribute]
		public int custSzX
		{
			get
			{
				return this.custSzXField;
			}
			set
			{
				this.custSzXField = value;
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x0005E3A6 File Offset: 0x0005C5A6
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x0005E3AE File Offset: 0x0005C5AE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custSzXSpecified
		{
			get
			{
				return this.custSzXFieldSpecified;
			}
			set
			{
				this.custSzXFieldSpecified = value;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x0005E3B7 File Offset: 0x0005C5B7
		// (set) Token: 0x06002570 RID: 9584 RVA: 0x0005E3BF File Offset: 0x0005C5BF
		[global::System.Xml.Serialization.XmlAttribute]
		public int custSzY
		{
			get
			{
				return this.custSzYField;
			}
			set
			{
				this.custSzYField = value;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x0005E3C8 File Offset: 0x0005C5C8
		// (set) Token: 0x06002572 RID: 9586 RVA: 0x0005E3D0 File Offset: 0x0005C5D0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custSzYSpecified
		{
			get
			{
				return this.custSzYFieldSpecified;
			}
			set
			{
				this.custSzYFieldSpecified = value;
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x0005E3D9 File Offset: 0x0005C5D9
		// (set) Token: 0x06002574 RID: 9588 RVA: 0x0005E3E1 File Offset: 0x0005C5E1
		[global::System.Xml.Serialization.XmlAttribute]
		public int custScaleX
		{
			get
			{
				return this.custScaleXField;
			}
			set
			{
				this.custScaleXField = value;
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x0005E3EA File Offset: 0x0005C5EA
		// (set) Token: 0x06002576 RID: 9590 RVA: 0x0005E3F2 File Offset: 0x0005C5F2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custScaleXSpecified
		{
			get
			{
				return this.custScaleXFieldSpecified;
			}
			set
			{
				this.custScaleXFieldSpecified = value;
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x0005E3FB File Offset: 0x0005C5FB
		// (set) Token: 0x06002578 RID: 9592 RVA: 0x0005E403 File Offset: 0x0005C603
		[global::System.Xml.Serialization.XmlAttribute]
		public int custScaleY
		{
			get
			{
				return this.custScaleYField;
			}
			set
			{
				this.custScaleYField = value;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002579 RID: 9593 RVA: 0x0005E40C File Offset: 0x0005C60C
		// (set) Token: 0x0600257A RID: 9594 RVA: 0x0005E414 File Offset: 0x0005C614
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custScaleYSpecified
		{
			get
			{
				return this.custScaleYFieldSpecified;
			}
			set
			{
				this.custScaleYFieldSpecified = value;
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x0005E41D File Offset: 0x0005C61D
		// (set) Token: 0x0600257C RID: 9596 RVA: 0x0005E425 File Offset: 0x0005C625
		[global::System.Xml.Serialization.XmlAttribute]
		public bool custT
		{
			get
			{
				return this.custTField;
			}
			set
			{
				this.custTField = value;
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x0005E42E File Offset: 0x0005C62E
		// (set) Token: 0x0600257E RID: 9598 RVA: 0x0005E436 File Offset: 0x0005C636
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custTSpecified
		{
			get
			{
				return this.custTFieldSpecified;
			}
			set
			{
				this.custTFieldSpecified = value;
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x0005E43F File Offset: 0x0005C63F
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x0005E447 File Offset: 0x0005C647
		[global::System.Xml.Serialization.XmlAttribute]
		public int custLinFactX
		{
			get
			{
				return this.custLinFactXField;
			}
			set
			{
				this.custLinFactXField = value;
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x0005E450 File Offset: 0x0005C650
		// (set) Token: 0x06002582 RID: 9602 RVA: 0x0005E458 File Offset: 0x0005C658
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custLinFactXSpecified
		{
			get
			{
				return this.custLinFactXFieldSpecified;
			}
			set
			{
				this.custLinFactXFieldSpecified = value;
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x0005E461 File Offset: 0x0005C661
		// (set) Token: 0x06002584 RID: 9604 RVA: 0x0005E469 File Offset: 0x0005C669
		[global::System.Xml.Serialization.XmlAttribute]
		public int custLinFactY
		{
			get
			{
				return this.custLinFactYField;
			}
			set
			{
				this.custLinFactYField = value;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x0005E472 File Offset: 0x0005C672
		// (set) Token: 0x06002586 RID: 9606 RVA: 0x0005E47A File Offset: 0x0005C67A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custLinFactYSpecified
		{
			get
			{
				return this.custLinFactYFieldSpecified;
			}
			set
			{
				this.custLinFactYFieldSpecified = value;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x0005E483 File Offset: 0x0005C683
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x0005E48B File Offset: 0x0005C68B
		[global::System.Xml.Serialization.XmlAttribute]
		public int custLinFactNeighborX
		{
			get
			{
				return this.custLinFactNeighborXField;
			}
			set
			{
				this.custLinFactNeighborXField = value;
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x0005E494 File Offset: 0x0005C694
		// (set) Token: 0x0600258A RID: 9610 RVA: 0x0005E49C File Offset: 0x0005C69C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custLinFactNeighborXSpecified
		{
			get
			{
				return this.custLinFactNeighborXFieldSpecified;
			}
			set
			{
				this.custLinFactNeighborXFieldSpecified = value;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x0005E4A5 File Offset: 0x0005C6A5
		// (set) Token: 0x0600258C RID: 9612 RVA: 0x0005E4AD File Offset: 0x0005C6AD
		[global::System.Xml.Serialization.XmlAttribute]
		public int custLinFactNeighborY
		{
			get
			{
				return this.custLinFactNeighborYField;
			}
			set
			{
				this.custLinFactNeighborYField = value;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x0005E4B6 File Offset: 0x0005C6B6
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x0005E4BE File Offset: 0x0005C6BE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custLinFactNeighborYSpecified
		{
			get
			{
				return this.custLinFactNeighborYFieldSpecified;
			}
			set
			{
				this.custLinFactNeighborYFieldSpecified = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x0005E4C7 File Offset: 0x0005C6C7
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x0005E4CF File Offset: 0x0005C6CF
		[global::System.Xml.Serialization.XmlAttribute]
		public int custRadScaleRad
		{
			get
			{
				return this.custRadScaleRadField;
			}
			set
			{
				this.custRadScaleRadField = value;
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x0005E4D8 File Offset: 0x0005C6D8
		// (set) Token: 0x06002592 RID: 9618 RVA: 0x0005E4E0 File Offset: 0x0005C6E0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custRadScaleRadSpecified
		{
			get
			{
				return this.custRadScaleRadFieldSpecified;
			}
			set
			{
				this.custRadScaleRadFieldSpecified = value;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x0005E4E9 File Offset: 0x0005C6E9
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x0005E4F1 File Offset: 0x0005C6F1
		[global::System.Xml.Serialization.XmlAttribute]
		public int custRadScaleInc
		{
			get
			{
				return this.custRadScaleIncField;
			}
			set
			{
				this.custRadScaleIncField = value;
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x0005E4FA File Offset: 0x0005C6FA
		// (set) Token: 0x06002596 RID: 9622 RVA: 0x0005E502 File Offset: 0x0005C702
		[global::System.Xml.Serialization.XmlIgnore]
		public bool custRadScaleIncSpecified
		{
			get
			{
				return this.custRadScaleIncFieldSpecified;
			}
			set
			{
				this.custRadScaleIncFieldSpecified = value;
			}
		}

		// Token: 0x04001BFA RID: 7162
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_LayoutVariablePropertySet presLayoutVarsField;

		// Token: 0x04001BFB RID: 7163
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle styleField;

		// Token: 0x04001BFC RID: 7164
		private string presAssocIDField;

		// Token: 0x04001BFD RID: 7165
		private string presNameField;

		// Token: 0x04001BFE RID: 7166
		private string presStyleLblField;

		// Token: 0x04001BFF RID: 7167
		private int presStyleIdxField;

		// Token: 0x04001C00 RID: 7168
		private bool presStyleIdxFieldSpecified;

		// Token: 0x04001C01 RID: 7169
		private int presStyleCntField;

		// Token: 0x04001C02 RID: 7170
		private bool presStyleCntFieldSpecified;

		// Token: 0x04001C03 RID: 7171
		private string loTypeIdField;

		// Token: 0x04001C04 RID: 7172
		private string loCatIdField;

		// Token: 0x04001C05 RID: 7173
		private string qsTypeIdField;

		// Token: 0x04001C06 RID: 7174
		private string qsCatIdField;

		// Token: 0x04001C07 RID: 7175
		private string csTypeIdField;

		// Token: 0x04001C08 RID: 7176
		private string csCatIdField;

		// Token: 0x04001C09 RID: 7177
		private bool coherent3DOffField;

		// Token: 0x04001C0A RID: 7178
		private bool coherent3DOffFieldSpecified;

		// Token: 0x04001C0B RID: 7179
		private string phldrTField;

		// Token: 0x04001C0C RID: 7180
		private bool phldrField;

		// Token: 0x04001C0D RID: 7181
		private bool phldrFieldSpecified;

		// Token: 0x04001C0E RID: 7182
		private int custAngField;

		// Token: 0x04001C0F RID: 7183
		private bool custAngFieldSpecified;

		// Token: 0x04001C10 RID: 7184
		private bool custFlipVertField;

		// Token: 0x04001C11 RID: 7185
		private bool custFlipVertFieldSpecified;

		// Token: 0x04001C12 RID: 7186
		private bool custFlipHorField;

		// Token: 0x04001C13 RID: 7187
		private bool custFlipHorFieldSpecified;

		// Token: 0x04001C14 RID: 7188
		private int custSzXField;

		// Token: 0x04001C15 RID: 7189
		private bool custSzXFieldSpecified;

		// Token: 0x04001C16 RID: 7190
		private int custSzYField;

		// Token: 0x04001C17 RID: 7191
		private bool custSzYFieldSpecified;

		// Token: 0x04001C18 RID: 7192
		private int custScaleXField;

		// Token: 0x04001C19 RID: 7193
		private bool custScaleXFieldSpecified;

		// Token: 0x04001C1A RID: 7194
		private int custScaleYField;

		// Token: 0x04001C1B RID: 7195
		private bool custScaleYFieldSpecified;

		// Token: 0x04001C1C RID: 7196
		private bool custTField;

		// Token: 0x04001C1D RID: 7197
		private bool custTFieldSpecified;

		// Token: 0x04001C1E RID: 7198
		private int custLinFactXField;

		// Token: 0x04001C1F RID: 7199
		private bool custLinFactXFieldSpecified;

		// Token: 0x04001C20 RID: 7200
		private int custLinFactYField;

		// Token: 0x04001C21 RID: 7201
		private bool custLinFactYFieldSpecified;

		// Token: 0x04001C22 RID: 7202
		private int custLinFactNeighborXField;

		// Token: 0x04001C23 RID: 7203
		private bool custLinFactNeighborXFieldSpecified;

		// Token: 0x04001C24 RID: 7204
		private int custLinFactNeighborYField;

		// Token: 0x04001C25 RID: 7205
		private bool custLinFactNeighborYFieldSpecified;

		// Token: 0x04001C26 RID: 7206
		private int custRadScaleRadField;

		// Token: 0x04001C27 RID: 7207
		private bool custRadScaleRadFieldSpecified;

		// Token: 0x04001C28 RID: 7208
		private int custRadScaleIncField;

		// Token: 0x04001C29 RID: 7209
		private bool custRadScaleIncFieldSpecified;
	}
}
