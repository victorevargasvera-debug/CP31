using System;
using System.Drawing;
using System.Windows.Forms;
using SourceGrid.Cells.Models;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x020003E8 RID: 1000
	internal class ToolTipText : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x000961A4 File Offset: 0x000943A4
		public static global::SourceGrid.Cells.Controllers.ToolTipText Default
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.ToolTipText.t_Default == null)
				{
					global::SourceGrid.Cells.Controllers.ToolTipText.t_Default = new global::SourceGrid.Cells.Controllers.ToolTipText();
				}
				return global::SourceGrid.Cells.Controllers.ToolTipText.t_Default;
			}
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000961C0 File Offset: 0x000943C0
		public override void OnMouseEnter(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnMouseEnter(sender, e);
			this.ApplyToolTipText(sender, e);
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000961D4 File Offset: 0x000943D4
		public override void OnMouseLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnMouseLeave(sender, e);
			this.ResetToolTipText(sender, e);
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06002CA1 RID: 11425 RVA: 0x000961E8 File Offset: 0x000943E8
		// (set) Token: 0x06002CA2 RID: 11426 RVA: 0x000961F0 File Offset: 0x000943F0
		public string ToolTipTitle
		{
			get
			{
				return this.mToolTipTitle;
			}
			set
			{
				this.mToolTipTitle = value;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06002CA3 RID: 11427 RVA: 0x000961FC File Offset: 0x000943FC
		// (set) Token: 0x06002CA4 RID: 11428 RVA: 0x00096204 File Offset: 0x00094404
		public global::System.Windows.Forms.ToolTipIcon ToolTipIcon
		{
			get
			{
				return this.mToolTipIcon;
			}
			set
			{
				this.mToolTipIcon = value;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x00096210 File Offset: 0x00094410
		// (set) Token: 0x06002CA6 RID: 11430 RVA: 0x00096218 File Offset: 0x00094418
		public bool IsBalloon
		{
			get
			{
				return this.mIsBalloon;
			}
			set
			{
				this.mIsBalloon = value;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x00096224 File Offset: 0x00094424
		// (set) Token: 0x06002CA8 RID: 11432 RVA: 0x0009622C File Offset: 0x0009442C
		public global::System.Drawing.Color BackColor
		{
			get
			{
				return this.mBackColor;
			}
			set
			{
				this.mBackColor = value;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x00096238 File Offset: 0x00094438
		// (set) Token: 0x06002CAA RID: 11434 RVA: 0x00096240 File Offset: 0x00094440
		public global::System.Drawing.Color ForeColor
		{
			get
			{
				return this.mForeColor;
			}
			set
			{
				this.mForeColor = value;
			}
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x0009624C File Offset: 0x0009444C
		protected virtual void ApplyToolTipText(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			global::SourceGrid.Cells.Models.IToolTipText toolTipText;
			if ((toolTipText = (global::SourceGrid.Cells.Models.IToolTipText)sender.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.IToolTipText))) != null)
			{
				string toolTipText2 = toolTipText.GetToolTipText(sender);
				if (toolTipText2 != null && toolTipText2.Length > 0)
				{
					sender.Grid.ToolTipText = toolTipText2;
					sender.Grid.ToolTip.ToolTipTitle = this.ToolTipTitle;
					sender.Grid.ToolTip.ToolTipIcon = this.ToolTipIcon;
					sender.Grid.ToolTip.IsBalloon = this.IsBalloon;
					if (!this.BackColor.IsEmpty)
					{
						sender.Grid.ToolTip.BackColor = this.BackColor;
					}
					if (!this.ForeColor.IsEmpty)
					{
						sender.Grid.ToolTip.ForeColor = this.ForeColor;
					}
				}
			}
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x00096344 File Offset: 0x00094544
		protected virtual void ResetToolTipText(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if ((global::SourceGrid.Cells.Models.IToolTipText)sender.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.IToolTipText)) != null)
			{
				sender.Grid.ToolTipText = null;
			}
		}

		// Token: 0x04000F26 RID: 3878
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.ToolTipText t_Default;

		// Token: 0x04000F27 RID: 3879
		private string mToolTipTitle = string.Empty;

		// Token: 0x04000F28 RID: 3880
		private global::System.Windows.Forms.ToolTipIcon mToolTipIcon;

		// Token: 0x04000F29 RID: 3881
		private bool mIsBalloon;

		// Token: 0x04000F2A RID: 3882
		private global::System.Drawing.Color mBackColor = global::System.Drawing.Color.Empty;

		// Token: 0x04000F2B RID: 3883
		private global::System.Drawing.Color mForeColor = global::System.Drawing.Color.Empty;
	}
}
