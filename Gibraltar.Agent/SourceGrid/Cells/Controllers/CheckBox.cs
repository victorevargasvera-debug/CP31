using System;
using System.Windows.Forms;
using SourceGrid.Cells.Models;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x0200034D RID: 845
	internal class CheckBox : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x0008DEE8 File Offset: 0x0008C0E8
		public static global::SourceGrid.Cells.Controllers.CheckBox Default
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.CheckBox.t_Default == null)
				{
					global::SourceGrid.Cells.Controllers.CheckBox.t_Default = new global::SourceGrid.Cells.Controllers.CheckBox();
				}
				return global::SourceGrid.Cells.Controllers.CheckBox.t_Default;
			}
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x0008DF04 File Offset: 0x0008C104
		public CheckBox()
		{
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x0008DF0C File Offset: 0x0008C10C
		public CheckBox(bool p_bAutoChangeValueOfSelectedCells)
		{
			this.m_bAutoChangeValueOfSelectedCells = p_bAutoChangeValueOfSelectedCells;
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x0008DF1C File Offset: 0x0008C11C
		public override void OnKeyPress(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyPressEventArgs e)
		{
			base.OnKeyPress(sender, e);
			if (e.KeyChar == ' ')
			{
				this.UIChangeChecked(sender, e);
			}
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x0008DF3C File Offset: 0x0008C13C
		public override void OnMouseDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseDown(sender, e);
			this.mLastButton = e.Button;
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x0008DF54 File Offset: 0x0008C154
		public override void OnClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnClick(sender, e);
			if (this.mLastButton == global::System.Windows.Forms.MouseButtons.Left)
			{
				this.UIChangeChecked(sender, e);
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x0008DF78 File Offset: 0x0008C178
		public bool AutoChangeValueOfSelectedCells
		{
			get
			{
				return this.m_bAutoChangeValueOfSelectedCells;
			}
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x0008DF80 File Offset: 0x0008C180
		private void UIChangeChecked(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			global::SourceGrid.Cells.Models.ICheckBox checkBox = (global::SourceGrid.Cells.Models.ICheckBox)sender.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ICheckBox));
			if (checkBox == null)
			{
				throw new global::SourceGrid.SourceGridException("Models.ICheckBox not found");
			}
			global::SourceGrid.Cells.Models.CheckBoxStatus checkBoxStatus = checkBox.GetCheckBoxStatus(sender);
			if (checkBoxStatus.CheckEnable)
			{
				bool value = true;
				if (checkBoxStatus.Checked != null)
				{
					value = !checkBoxStatus.Checked.Value;
				}
				sender.StartEdit();
				try
				{
					checkBox.SetCheckedValue(sender, new bool?(value));
					sender.EndEdit(false);
				}
				catch (global::System.Exception)
				{
					sender.EndEdit(true);
					throw;
				}
				if (this.AutoChangeValueOfSelectedCells)
				{
					foreach (global::SourceGrid.Position position in sender.Grid.Selection.GetSelectionRegion().GetCellsPositions())
					{
						global::SourceGrid.Cells.ICellVirtual cell = sender.Grid.GetCell(position);
						global::SourceGrid.Cells.Models.ICheckBox checkBox2;
						if (cell != this && cell != null && (checkBox2 = (global::SourceGrid.Cells.Models.ICheckBox)cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ICheckBox))) != null)
						{
							global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(sender.Grid, position, cell);
							cellContext.StartEdit();
							try
							{
								checkBox2.SetCheckedValue(cellContext, new bool?(value));
								cellContext.EndEdit(false);
							}
							catch (global::System.Exception)
							{
								cellContext.EndEdit(true);
								throw;
							}
						}
					}
				}
			}
		}

		// Token: 0x04000E2C RID: 3628
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.CheckBox t_Default;

		// Token: 0x04000E2D RID: 3629
		private global::System.Windows.Forms.MouseButtons mLastButton;

		// Token: 0x04000E2E RID: 3630
		private bool m_bAutoChangeValueOfSelectedCells;
	}
}
