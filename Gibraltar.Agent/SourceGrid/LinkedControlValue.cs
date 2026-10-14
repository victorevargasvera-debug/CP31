using System;
using System.Windows.Forms;

namespace SourceGrid
{
	// Token: 0x020003D0 RID: 976
	internal class LinkedControlValue
	{
		// Token: 0x06002C42 RID: 11330 RVA: 0x00094B70 File Offset: 0x00092D70
		public LinkedControlValue(global::System.Windows.Forms.Control control, global::SourceGrid.Position position)
		{
			this.mControl = control;
			this.mPosition = position;
			this.m_bUseCellBorder = true;
			this.mScrollMode = global::SourceGrid.LinkedControlScrollMode.BasedOnPosition;
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x00094B94 File Offset: 0x00092D94
		public global::System.Windows.Forms.Control Control
		{
			get
			{
				return this.mControl;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x00094B9C File Offset: 0x00092D9C
		// (set) Token: 0x06002C45 RID: 11333 RVA: 0x00094BA4 File Offset: 0x00092DA4
		public global::SourceGrid.Position Position
		{
			get
			{
				return this.mPosition;
			}
			set
			{
				this.mPosition = value;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x00094BB0 File Offset: 0x00092DB0
		// (set) Token: 0x06002C47 RID: 11335 RVA: 0x00094BB8 File Offset: 0x00092DB8
		public bool UseCellBorder
		{
			get
			{
				return this.m_bUseCellBorder;
			}
			set
			{
				this.m_bUseCellBorder = value;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x00094BC4 File Offset: 0x00092DC4
		// (set) Token: 0x06002C49 RID: 11337 RVA: 0x00094BCC File Offset: 0x00092DCC
		public global::SourceGrid.LinkedControlScrollMode ScrollMode
		{
			get
			{
				return this.mScrollMode;
			}
			set
			{
				this.mScrollMode = value;
			}
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x00094BD8 File Offset: 0x00092DD8
		public override string ToString()
		{
			return this.Position.ToString();
		}

		// Token: 0x04000EBB RID: 3771
		private global::System.Windows.Forms.Control mControl;

		// Token: 0x04000EBC RID: 3772
		private global::SourceGrid.Position mPosition;

		// Token: 0x04000EBD RID: 3773
		private bool m_bUseCellBorder;

		// Token: 0x04000EBE RID: 3774
		private global::SourceGrid.LinkedControlScrollMode mScrollMode;
	}
}
