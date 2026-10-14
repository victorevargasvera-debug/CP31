using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000564 RID: 1380
	public class CT_RevisionDefinedName
	{
		// Token: 0x06003BF9 RID: 15353 RVA: 0x00093280 File Offset: 0x00091480
		public CT_RevisionDefinedName()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.uaField = false;
			this.raField = false;
			this.customViewField = false;
			this.functionField = false;
			this.oldFunctionField = false;
			this.hiddenField = false;
			this.oldHiddenField = false;
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06003BFA RID: 15354 RVA: 0x000932CF File Offset: 0x000914CF
		// (set) Token: 0x06003BFB RID: 15355 RVA: 0x000932D7 File Offset: 0x000914D7
		public string formula
		{
			get
			{
				return this.formulaField;
			}
			set
			{
				this.formulaField = value;
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06003BFC RID: 15356 RVA: 0x000932E0 File Offset: 0x000914E0
		// (set) Token: 0x06003BFD RID: 15357 RVA: 0x000932E8 File Offset: 0x000914E8
		public string oldFormula
		{
			get
			{
				return this.oldFormulaField;
			}
			set
			{
				this.oldFormulaField = value;
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06003BFE RID: 15358 RVA: 0x000932F1 File Offset: 0x000914F1
		// (set) Token: 0x06003BFF RID: 15359 RVA: 0x000932F9 File Offset: 0x000914F9
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
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

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x06003C00 RID: 15360 RVA: 0x00093302 File Offset: 0x00091502
		// (set) Token: 0x06003C01 RID: 15361 RVA: 0x0009330A File Offset: 0x0009150A
		public uint rId
		{
			get
			{
				return this.rIdField;
			}
			set
			{
				this.rIdField = value;
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06003C02 RID: 15362 RVA: 0x00093313 File Offset: 0x00091513
		// (set) Token: 0x06003C03 RID: 15363 RVA: 0x0009331B File Offset: 0x0009151B
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ua
		{
			get
			{
				return this.uaField;
			}
			set
			{
				this.uaField = value;
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06003C04 RID: 15364 RVA: 0x00093324 File Offset: 0x00091524
		// (set) Token: 0x06003C05 RID: 15365 RVA: 0x0009332C File Offset: 0x0009152C
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ra
		{
			get
			{
				return this.raField;
			}
			set
			{
				this.raField = value;
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06003C06 RID: 15366 RVA: 0x00093335 File Offset: 0x00091535
		// (set) Token: 0x06003C07 RID: 15367 RVA: 0x0009333D File Offset: 0x0009153D
		public uint localSheetId
		{
			get
			{
				return this.localSheetIdField;
			}
			set
			{
				this.localSheetIdField = value;
			}
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06003C08 RID: 15368 RVA: 0x00093346 File Offset: 0x00091546
		// (set) Token: 0x06003C09 RID: 15369 RVA: 0x0009334E File Offset: 0x0009154E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool localSheetIdSpecified
		{
			get
			{
				return this.localSheetIdFieldSpecified;
			}
			set
			{
				this.localSheetIdFieldSpecified = value;
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06003C0A RID: 15370 RVA: 0x00093357 File Offset: 0x00091557
		// (set) Token: 0x06003C0B RID: 15371 RVA: 0x0009335F File Offset: 0x0009155F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool customView
		{
			get
			{
				return this.customViewField;
			}
			set
			{
				this.customViewField = value;
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06003C0C RID: 15372 RVA: 0x00093368 File Offset: 0x00091568
		// (set) Token: 0x06003C0D RID: 15373 RVA: 0x00093370 File Offset: 0x00091570
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

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06003C0E RID: 15374 RVA: 0x00093379 File Offset: 0x00091579
		// (set) Token: 0x06003C0F RID: 15375 RVA: 0x00093381 File Offset: 0x00091581
		[global::System.ComponentModel.DefaultValue(false)]
		public bool function
		{
			get
			{
				return this.functionField;
			}
			set
			{
				this.functionField = value;
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06003C10 RID: 15376 RVA: 0x0009338A File Offset: 0x0009158A
		// (set) Token: 0x06003C11 RID: 15377 RVA: 0x00093392 File Offset: 0x00091592
		[global::System.ComponentModel.DefaultValue(false)]
		public bool oldFunction
		{
			get
			{
				return this.oldFunctionField;
			}
			set
			{
				this.oldFunctionField = value;
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06003C12 RID: 15378 RVA: 0x0009339B File Offset: 0x0009159B
		// (set) Token: 0x06003C13 RID: 15379 RVA: 0x000933A3 File Offset: 0x000915A3
		public byte functionGroupId
		{
			get
			{
				return this.functionGroupIdField;
			}
			set
			{
				this.functionGroupIdField = value;
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x000933AC File Offset: 0x000915AC
		// (set) Token: 0x06003C15 RID: 15381 RVA: 0x000933B4 File Offset: 0x000915B4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool functionGroupIdSpecified
		{
			get
			{
				return this.functionGroupIdFieldSpecified;
			}
			set
			{
				this.functionGroupIdFieldSpecified = value;
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06003C16 RID: 15382 RVA: 0x000933BD File Offset: 0x000915BD
		// (set) Token: 0x06003C17 RID: 15383 RVA: 0x000933C5 File Offset: 0x000915C5
		public byte oldFunctionGroupId
		{
			get
			{
				return this.oldFunctionGroupIdField;
			}
			set
			{
				this.oldFunctionGroupIdField = value;
			}
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06003C18 RID: 15384 RVA: 0x000933CE File Offset: 0x000915CE
		// (set) Token: 0x06003C19 RID: 15385 RVA: 0x000933D6 File Offset: 0x000915D6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool oldFunctionGroupIdSpecified
		{
			get
			{
				return this.oldFunctionGroupIdFieldSpecified;
			}
			set
			{
				this.oldFunctionGroupIdFieldSpecified = value;
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06003C1A RID: 15386 RVA: 0x000933DF File Offset: 0x000915DF
		// (set) Token: 0x06003C1B RID: 15387 RVA: 0x000933E7 File Offset: 0x000915E7
		public byte shortcutKey
		{
			get
			{
				return this.shortcutKeyField;
			}
			set
			{
				this.shortcutKeyField = value;
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x000933F0 File Offset: 0x000915F0
		// (set) Token: 0x06003C1D RID: 15389 RVA: 0x000933F8 File Offset: 0x000915F8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool shortcutKeySpecified
		{
			get
			{
				return this.shortcutKeyFieldSpecified;
			}
			set
			{
				this.shortcutKeyFieldSpecified = value;
			}
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x00093401 File Offset: 0x00091601
		// (set) Token: 0x06003C1F RID: 15391 RVA: 0x00093409 File Offset: 0x00091609
		public byte oldShortcutKey
		{
			get
			{
				return this.oldShortcutKeyField;
			}
			set
			{
				this.oldShortcutKeyField = value;
			}
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06003C20 RID: 15392 RVA: 0x00093412 File Offset: 0x00091612
		// (set) Token: 0x06003C21 RID: 15393 RVA: 0x0009341A File Offset: 0x0009161A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool oldShortcutKeySpecified
		{
			get
			{
				return this.oldShortcutKeyFieldSpecified;
			}
			set
			{
				this.oldShortcutKeyFieldSpecified = value;
			}
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06003C22 RID: 15394 RVA: 0x00093423 File Offset: 0x00091623
		// (set) Token: 0x06003C23 RID: 15395 RVA: 0x0009342B File Offset: 0x0009162B
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
			}
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x00093434 File Offset: 0x00091634
		// (set) Token: 0x06003C25 RID: 15397 RVA: 0x0009343C File Offset: 0x0009163C
		[global::System.ComponentModel.DefaultValue(false)]
		public bool oldHidden
		{
			get
			{
				return this.oldHiddenField;
			}
			set
			{
				this.oldHiddenField = value;
			}
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x00093445 File Offset: 0x00091645
		// (set) Token: 0x06003C27 RID: 15399 RVA: 0x0009344D File Offset: 0x0009164D
		public string customMenu
		{
			get
			{
				return this.customMenuField;
			}
			set
			{
				this.customMenuField = value;
			}
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06003C28 RID: 15400 RVA: 0x00093456 File Offset: 0x00091656
		// (set) Token: 0x06003C29 RID: 15401 RVA: 0x0009345E File Offset: 0x0009165E
		public string oldCustomMenu
		{
			get
			{
				return this.oldCustomMenuField;
			}
			set
			{
				this.oldCustomMenuField = value;
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06003C2A RID: 15402 RVA: 0x00093467 File Offset: 0x00091667
		// (set) Token: 0x06003C2B RID: 15403 RVA: 0x0009346F File Offset: 0x0009166F
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06003C2C RID: 15404 RVA: 0x00093478 File Offset: 0x00091678
		// (set) Token: 0x06003C2D RID: 15405 RVA: 0x00093480 File Offset: 0x00091680
		public string oldDescription
		{
			get
			{
				return this.oldDescriptionField;
			}
			set
			{
				this.oldDescriptionField = value;
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06003C2E RID: 15406 RVA: 0x00093489 File Offset: 0x00091689
		// (set) Token: 0x06003C2F RID: 15407 RVA: 0x00093491 File Offset: 0x00091691
		public string help
		{
			get
			{
				return this.helpField;
			}
			set
			{
				this.helpField = value;
			}
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x0009349A File Offset: 0x0009169A
		// (set) Token: 0x06003C31 RID: 15409 RVA: 0x000934A2 File Offset: 0x000916A2
		public string oldHelp
		{
			get
			{
				return this.oldHelpField;
			}
			set
			{
				this.oldHelpField = value;
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06003C32 RID: 15410 RVA: 0x000934AB File Offset: 0x000916AB
		// (set) Token: 0x06003C33 RID: 15411 RVA: 0x000934B3 File Offset: 0x000916B3
		public string statusBar
		{
			get
			{
				return this.statusBarField;
			}
			set
			{
				this.statusBarField = value;
			}
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06003C34 RID: 15412 RVA: 0x000934BC File Offset: 0x000916BC
		// (set) Token: 0x06003C35 RID: 15413 RVA: 0x000934C4 File Offset: 0x000916C4
		public string oldStatusBar
		{
			get
			{
				return this.oldStatusBarField;
			}
			set
			{
				this.oldStatusBarField = value;
			}
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06003C36 RID: 15414 RVA: 0x000934CD File Offset: 0x000916CD
		// (set) Token: 0x06003C37 RID: 15415 RVA: 0x000934D5 File Offset: 0x000916D5
		public string comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06003C38 RID: 15416 RVA: 0x000934DE File Offset: 0x000916DE
		// (set) Token: 0x06003C39 RID: 15417 RVA: 0x000934E6 File Offset: 0x000916E6
		public string oldComment
		{
			get
			{
				return this.oldCommentField;
			}
			set
			{
				this.oldCommentField = value;
			}
		}

		// Token: 0x0400266E RID: 9838
		private string formulaField;

		// Token: 0x0400266F RID: 9839
		private string oldFormulaField;

		// Token: 0x04002670 RID: 9840
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002671 RID: 9841
		private uint rIdField;

		// Token: 0x04002672 RID: 9842
		private bool uaField;

		// Token: 0x04002673 RID: 9843
		private bool raField;

		// Token: 0x04002674 RID: 9844
		private uint localSheetIdField;

		// Token: 0x04002675 RID: 9845
		private bool localSheetIdFieldSpecified;

		// Token: 0x04002676 RID: 9846
		private bool customViewField;

		// Token: 0x04002677 RID: 9847
		private string nameField;

		// Token: 0x04002678 RID: 9848
		private bool functionField;

		// Token: 0x04002679 RID: 9849
		private bool oldFunctionField;

		// Token: 0x0400267A RID: 9850
		private byte functionGroupIdField;

		// Token: 0x0400267B RID: 9851
		private bool functionGroupIdFieldSpecified;

		// Token: 0x0400267C RID: 9852
		private byte oldFunctionGroupIdField;

		// Token: 0x0400267D RID: 9853
		private bool oldFunctionGroupIdFieldSpecified;

		// Token: 0x0400267E RID: 9854
		private byte shortcutKeyField;

		// Token: 0x0400267F RID: 9855
		private bool shortcutKeyFieldSpecified;

		// Token: 0x04002680 RID: 9856
		private byte oldShortcutKeyField;

		// Token: 0x04002681 RID: 9857
		private bool oldShortcutKeyFieldSpecified;

		// Token: 0x04002682 RID: 9858
		private bool hiddenField;

		// Token: 0x04002683 RID: 9859
		private bool oldHiddenField;

		// Token: 0x04002684 RID: 9860
		private string customMenuField;

		// Token: 0x04002685 RID: 9861
		private string oldCustomMenuField;

		// Token: 0x04002686 RID: 9862
		private string descriptionField;

		// Token: 0x04002687 RID: 9863
		private string oldDescriptionField;

		// Token: 0x04002688 RID: 9864
		private string helpField;

		// Token: 0x04002689 RID: 9865
		private string oldHelpField;

		// Token: 0x0400268A RID: 9866
		private string statusBarField;

		// Token: 0x0400268B RID: 9867
		private string oldStatusBarField;

		// Token: 0x0400268C RID: 9868
		private string commentField;

		// Token: 0x0400268D RID: 9869
		private string oldCommentField;
	}
}
