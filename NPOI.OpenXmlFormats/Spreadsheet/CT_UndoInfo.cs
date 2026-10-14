using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000568 RID: 1384
	public class CT_UndoInfo
	{
		// Token: 0x06003C6D RID: 15469 RVA: 0x000936FC File Offset: 0x000918FC
		public CT_UndoInfo()
		{
			this.ref3DField = false;
			this.arrayField = false;
			this.vField = false;
			this.nfField = false;
			this.csField = false;
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06003C6E RID: 15470 RVA: 0x00093727 File Offset: 0x00091927
		// (set) Token: 0x06003C6F RID: 15471 RVA: 0x0009372F File Offset: 0x0009192F
		public uint index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06003C70 RID: 15472 RVA: 0x00093738 File Offset: 0x00091938
		// (set) Token: 0x06003C71 RID: 15473 RVA: 0x00093740 File Offset: 0x00091940
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_FormulaExpression exp
		{
			get
			{
				return this.expField;
			}
			set
			{
				this.expField = value;
			}
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06003C72 RID: 15474 RVA: 0x00093749 File Offset: 0x00091949
		// (set) Token: 0x06003C73 RID: 15475 RVA: 0x00093751 File Offset: 0x00091951
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ref3D
		{
			get
			{
				return this.ref3DField;
			}
			set
			{
				this.ref3DField = value;
			}
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06003C74 RID: 15476 RVA: 0x0009375A File Offset: 0x0009195A
		// (set) Token: 0x06003C75 RID: 15477 RVA: 0x00093762 File Offset: 0x00091962
		[global::System.ComponentModel.DefaultValue(false)]
		public bool array
		{
			get
			{
				return this.arrayField;
			}
			set
			{
				this.arrayField = value;
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06003C76 RID: 15478 RVA: 0x0009376B File Offset: 0x0009196B
		// (set) Token: 0x06003C77 RID: 15479 RVA: 0x00093773 File Offset: 0x00091973
		[global::System.ComponentModel.DefaultValue(false)]
		public bool v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06003C78 RID: 15480 RVA: 0x0009377C File Offset: 0x0009197C
		// (set) Token: 0x06003C79 RID: 15481 RVA: 0x00093784 File Offset: 0x00091984
		[global::System.ComponentModel.DefaultValue(false)]
		public bool nf
		{
			get
			{
				return this.nfField;
			}
			set
			{
				this.nfField = value;
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06003C7A RID: 15482 RVA: 0x0009378D File Offset: 0x0009198D
		// (set) Token: 0x06003C7B RID: 15483 RVA: 0x00093795 File Offset: 0x00091995
		[global::System.ComponentModel.DefaultValue(false)]
		public bool cs
		{
			get
			{
				return this.csField;
			}
			set
			{
				this.csField = value;
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06003C7C RID: 15484 RVA: 0x0009379E File Offset: 0x0009199E
		// (set) Token: 0x06003C7D RID: 15485 RVA: 0x000937A6 File Offset: 0x000919A6
		public string dr
		{
			get
			{
				return this.drField;
			}
			set
			{
				this.drField = value;
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06003C7E RID: 15486 RVA: 0x000937AF File Offset: 0x000919AF
		// (set) Token: 0x06003C7F RID: 15487 RVA: 0x000937B7 File Offset: 0x000919B7
		public string dn
		{
			get
			{
				return this.dnField;
			}
			set
			{
				this.dnField = value;
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06003C80 RID: 15488 RVA: 0x000937C0 File Offset: 0x000919C0
		// (set) Token: 0x06003C81 RID: 15489 RVA: 0x000937C8 File Offset: 0x000919C8
		public string r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06003C82 RID: 15490 RVA: 0x000937D1 File Offset: 0x000919D1
		// (set) Token: 0x06003C83 RID: 15491 RVA: 0x000937D9 File Offset: 0x000919D9
		public uint sId
		{
			get
			{
				return this.sIdField;
			}
			set
			{
				this.sIdField = value;
			}
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06003C84 RID: 15492 RVA: 0x000937E2 File Offset: 0x000919E2
		// (set) Token: 0x06003C85 RID: 15493 RVA: 0x000937EA File Offset: 0x000919EA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool sIdSpecified
		{
			get
			{
				return this.sIdFieldSpecified;
			}
			set
			{
				this.sIdFieldSpecified = value;
			}
		}

		// Token: 0x040026A6 RID: 9894
		private uint indexField;

		// Token: 0x040026A7 RID: 9895
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_FormulaExpression expField;

		// Token: 0x040026A8 RID: 9896
		private bool ref3DField;

		// Token: 0x040026A9 RID: 9897
		private bool arrayField;

		// Token: 0x040026AA RID: 9898
		private bool vField;

		// Token: 0x040026AB RID: 9899
		private bool nfField;

		// Token: 0x040026AC RID: 9900
		private bool csField;

		// Token: 0x040026AD RID: 9901
		private string drField;

		// Token: 0x040026AE RID: 9902
		private string dnField;

		// Token: 0x040026AF RID: 9903
		private string rField;

		// Token: 0x040026B0 RID: 9904
		private uint sIdField;

		// Token: 0x040026B1 RID: 9905
		private bool sIdFieldSpecified;
	}
}
