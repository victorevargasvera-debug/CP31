using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x02000347 RID: 839
	[global::System.ComponentModel.ToolboxItem(false)]
	internal abstract class EditorControlBase : global::SourceGrid.Cells.Editors.EditorBase
	{
		// Token: 0x060028C2 RID: 10434 RVA: 0x0008CF6C File Offset: 0x0008B16C
		public EditorControlBase(global::System.Type p_Type) : base(p_Type)
		{
			this.mControl = this.CreateControl();
			if (this.Control == null)
			{
				throw new global::SourceGrid.SourceGridException("Control cannot be null");
			}
			this.Control.Hide();
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x0008CFB4 File Offset: 0x0008B1B4
		public global::System.Windows.Forms.Control Control
		{
			get
			{
				return this.mControl;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x0008CFBC File Offset: 0x0008B1BC
		public global::SourceGrid.GridVirtual Grid
		{
			get
			{
				return this.mGrid;
			}
		}

		// Token: 0x060028C5 RID: 10437
		protected abstract global::System.Windows.Forms.Control CreateControl();

		// Token: 0x060028C6 RID: 10438 RVA: 0x0008CFC4 File Offset: 0x0008B1C4
		private bool IsControlAttached()
		{
			return this.mGrid != null;
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0008CFD4 File Offset: 0x0008B1D4
		private void AttachControl(global::SourceGrid.GridVirtual grid)
		{
			this.mGrid = grid;
			this.mLinkedControl = new global::SourceGrid.LinkedControlValue(this.Control, global::SourceGrid.Position.Empty);
			this.Control.Hide();
			grid.LinkedControls.Add(this.mLinkedControl);
			this.Control.Validated += this.InnerControl_Validated;
			this.Control.KeyPress += this.InnerControl_KeyPress;
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0008D04C File Offset: 0x0008B24C
		internal override void InternalStartEdit(global::SourceGrid.CellContext cellContext)
		{
			base.InternalStartEdit(cellContext);
			if (this.Control == null)
			{
				throw new global::SourceGrid.SourceGridException("Control cannot be null");
			}
			if (!base.IsEditing && base.EnableEdit)
			{
				if (base.EditCell != null)
				{
					throw new global::SourceGrid.SourceGridException("There is already a Cell in edit state");
				}
				if (!this.IsControlAttached())
				{
					this.AttachControl(cellContext.Grid);
				}
				this.mLinkedControl.Position = cellContext.Position;
				cellContext.Grid.ArrangeLinkedControls();
				this.OnStartingEdit(cellContext, this.Control);
				base.SetEditCell(cellContext);
				this.SafeSetEditValue(cellContext.Cell.Model.ValueModel.GetValue(cellContext));
				this.ShowControl(this.Control);
			}
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0008D11C File Offset: 0x0008B31C
		protected virtual void OnStartingEdit(global::SourceGrid.CellContext cellContext, global::System.Windows.Forms.Control editorControl)
		{
			if (this.UseCellViewProperties)
			{
				editorControl.BackColor = cellContext.Cell.View.BackColor;
				editorControl.ForeColor = cellContext.Cell.View.ForeColor;
				editorControl.Font = cellContext.Cell.View.Font;
			}
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x0008D180 File Offset: 0x0008B380
		protected virtual void ShowControl(global::System.Windows.Forms.Control editorControl)
		{
			editorControl.Show();
			editorControl.BringToFront();
			editorControl.Focus();
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x0008D198 File Offset: 0x0008B398
		public override bool ApplyEdit()
		{
			if (base.IsEditing)
			{
				try
				{
					return this.SetCellValue(base.EditCellContext, this.GetEditedValue());
				}
				catch (global::System.Exception p_Exception)
				{
					this.OnEditException(new global::SourceGrid.ExceptionEventArgs(p_Exception));
					return false;
				}
			}
			return true;
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x0008D1F0 File Offset: 0x0008B3F0
		internal override bool InternalEndEdit(bool cancel)
		{
			if (!base.IsEditing)
			{
				return true;
			}
			if (this.mIsInsideEndEdit)
			{
				return false;
			}
			this.mIsInsideEndEdit = true;
			bool result;
			try
			{
				bool flag = true;
				if (cancel)
				{
					this.UndoEditValue();
				}
				if (this.Control.ContainsFocus && !base.EditCellContext.Grid.Focus())
				{
					flag = false;
				}
				if (flag && !cancel)
				{
					flag = this.ApplyEdit();
				}
				if (flag)
				{
					this.Control.Hide();
					this.mLinkedControl.Position = global::SourceGrid.Position.Empty;
					base.SetEditCell(global::SourceGrid.CellContext.Empty);
				}
				else if (!this.Control.ContainsFocus)
				{
					this.Control.Focus();
				}
				result = flag;
			}
			finally
			{
				this.mIsInsideEndEdit = false;
			}
			return result;
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0008D2D4 File Offset: 0x0008B4D4
		private void InnerControl_Validated(object sender, global::System.EventArgs e)
		{
			try
			{
				if (base.IsEditing)
				{
					base.EditCellContext.EndEdit(false);
				}
			}
			catch (global::System.Exception p_Exception)
			{
				this.OnEditException(new global::SourceGrid.ExceptionEventArgs(p_Exception));
			}
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x0008D324 File Offset: 0x0008B524
		private void InnerControl_KeyPress(object sender, global::System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.Handled)
			{
				return;
			}
			this.OnKeyPress(e);
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x0008D33C File Offset: 0x0008B53C
		public virtual void UndoEditValue()
		{
			if (base.EditCell == null)
			{
				throw new global::SourceGrid.SourceGridException("Not in edit state");
			}
			this.SafeSetEditValue(base.EditCell.Model.ValueModel.GetValue(base.EditCellContext));
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0008D384 File Offset: 0x0008B584
		public void SafeSetEditValue(object editValue)
		{
			try
			{
				this.SetEditValue(editValue);
			}
			catch (global::System.Exception innerException)
			{
				base.EditCellContext.Grid.OnUserException(new global::SourceGrid.ExceptionEventArgs(new global::SourceGrid.EditingCellException(innerException)));
				this.SetEditValue(base.DefaultValue);
			}
		}

		// Token: 0x060028D1 RID: 10449
		public abstract override object GetEditedValue();

		// Token: 0x060028D2 RID: 10450
		public abstract void SetEditValue(object editValue);

		// Token: 0x140000BE RID: 190
		// (add) Token: 0x060028D3 RID: 10451 RVA: 0x0008D3DC File Offset: 0x0008B5DC
		// (remove) Token: 0x060028D4 RID: 10452 RVA: 0x0008D3F8 File Offset: 0x0008B5F8
		public event global::System.Windows.Forms.KeyPressEventHandler KeyPress;

		// Token: 0x060028D5 RID: 10453 RVA: 0x0008D414 File Offset: 0x0008B614
		protected virtual void OnKeyPress(global::System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.Handled)
			{
				return;
			}
			if (this.KeyPress != null)
			{
				this.KeyPress(this, e);
			}
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x0008D43C File Offset: 0x0008B63C
		public sealed override void SendCharToEditor(char key)
		{
			global::System.Windows.Forms.KeyPressEventArgs keyPressEventArgs = new global::System.Windows.Forms.KeyPressEventArgs(key);
			this.OnKeyPress(keyPressEventArgs);
			if (keyPressEventArgs.Handled)
			{
				return;
			}
			this.OnSendCharToEditor(keyPressEventArgs.KeyChar);
		}

		// Token: 0x060028D7 RID: 10455
		protected abstract void OnSendCharToEditor(char key);

		// Token: 0x060028D8 RID: 10456 RVA: 0x0008D474 File Offset: 0x0008B674
		public override global::System.Drawing.Size GetMinimumSize(global::SourceGrid.CellContext cellContext)
		{
			return this.Control.GetPreferredSize(global::System.Drawing.Size.Empty);
		}

		// Token: 0x04000E0F RID: 3599
		private global::System.Windows.Forms.Control mControl;

		// Token: 0x04000E10 RID: 3600
		private global::SourceGrid.GridVirtual mGrid;

		// Token: 0x04000E11 RID: 3601
		private global::SourceGrid.LinkedControlValue mLinkedControl;

		// Token: 0x04000E12 RID: 3602
		private bool mIsInsideEndEdit;
	}
}
