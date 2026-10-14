using System;
using System.ComponentModel;
using System.Drawing;
using DevAge.ComponentModel.Validator;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x02000346 RID: 838
	[global::System.ComponentModel.ToolboxItem(false)]
	internal class EditorBase : global::DevAge.ComponentModel.Validator.ValidatorTypeConverter
	{
		// Token: 0x0600289C RID: 10396 RVA: 0x0008CB84 File Offset: 0x0008AD84
		public EditorBase(global::System.Type p_Type) : base(p_Type)
		{
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x0008CBC0 File Offset: 0x0008ADC0
		public global::SourceGrid.CellContext EditCellContext
		{
			get
			{
				return this.mEditCellContext;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x0008CBC8 File Offset: 0x0008ADC8
		public global::SourceGrid.Cells.ICellVirtual EditCell
		{
			get
			{
				return this.mEditCellContext.Cell;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x0008CBD8 File Offset: 0x0008ADD8
		public global::SourceGrid.Position EditPosition
		{
			get
			{
				return this.mEditCellContext.Position;
			}
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x0008CBE8 File Offset: 0x0008ADE8
		protected void SetEditCell(global::SourceGrid.CellContext cellContext)
		{
			this.mEditCellContext = cellContext;
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x0008CBF4 File Offset: 0x0008ADF4
		public bool IsErrorString(string p_str)
		{
			return p_str == this.ErrorString;
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x0008CC0C File Offset: 0x0008AE0C
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x0008CC14 File Offset: 0x0008AE14
		public string ErrorString
		{
			get
			{
				return this.m_ErrorString;
			}
			set
			{
				this.m_ErrorString = value;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x0008CC20 File Offset: 0x0008AE20
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0008CC28 File Offset: 0x0008AE28
		public bool EnableEdit
		{
			get
			{
				return this.m_bEnableEdit;
			}
			set
			{
				this.m_bEnableEdit = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x0008CC34 File Offset: 0x0008AE34
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x0008CC3C File Offset: 0x0008AE3C
		public global::SourceGrid.EditableMode EditableMode
		{
			get
			{
				return this.m_EditableMode;
			}
			set
			{
				this.m_EditableMode = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x0008CC48 File Offset: 0x0008AE48
		// (set) Token: 0x060028A9 RID: 10409 RVA: 0x0008CC50 File Offset: 0x0008AE50
		public virtual bool EnableCellDrawOnEdit
		{
			get
			{
				return this.m_bEnableCellDrawOnEdit;
			}
			set
			{
				this.m_bEnableCellDrawOnEdit = value;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x0008CC5C File Offset: 0x0008AE5C
		// (set) Token: 0x060028AB RID: 10411 RVA: 0x0008CC64 File Offset: 0x0008AE64
		public virtual bool UseCellViewProperties
		{
			get
			{
				return this.mUseCellViewProperties;
			}
			set
			{
				this.mUseCellViewProperties = value;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x0008CC70 File Offset: 0x0008AE70
		public bool IsEditing
		{
			get
			{
				return this.EditCell != null;
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x0008CC80 File Offset: 0x0008AE80
		internal virtual void InternalStartEdit(global::SourceGrid.CellContext cellContext)
		{
			if (cellContext.Cell == null)
			{
				throw new global::System.ArgumentNullException("cellContext.Cell");
			}
			if (cellContext.Grid == null)
			{
				throw new global::System.ArgumentNullException("cellContext.Grid");
			}
			if (cellContext.Grid.Selection.ActivePosition != cellContext.Position)
			{
				throw new global::SourceGrid.SourceGridException("Cell must have the focus");
			}
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x0008CCEC File Offset: 0x0008AEEC
		public virtual bool ApplyEdit()
		{
			return true;
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0008CCF0 File Offset: 0x0008AEF0
		internal virtual bool InternalEndEdit(bool cancel)
		{
			return true;
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x0008CCF4 File Offset: 0x0008AEF4
		public virtual object GetEditedValue()
		{
			throw new global::SourceGrid.SourceGridException("No valid cell editor found");
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x0008CD00 File Offset: 0x0008AF00
		public virtual void ClearCell(global::SourceGrid.CellContext cellContext)
		{
			this.SetCellValue(cellContext, base.DefaultValue);
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x0008CD10 File Offset: 0x0008AF10
		public virtual bool SetCellValue(global::SourceGrid.CellContext cellContext, object p_NewValue)
		{
			if (!this.EnableEdit)
			{
				return false;
			}
			if (cellContext.Cell == null)
			{
				throw new global::SourceGrid.SourceGridException("Invalid CellContext, cell is null");
			}
			global::SourceGrid.ValidatingCellEventArgs validatingCellEventArgs = new global::SourceGrid.ValidatingCellEventArgs(cellContext, p_NewValue);
			this.OnValidating(validatingCellEventArgs);
			if (!validatingCellEventArgs.Cancel)
			{
				object value = cellContext.Cell.Model.ValueModel.GetValue(cellContext);
				try
				{
					cellContext.Cell.Model.ValueModel.SetValue(cellContext, base.ObjectToValue(validatingCellEventArgs.NewValue));
					this.OnValidated(new global::SourceGrid.CellContextEventArgs(cellContext));
				}
				catch (global::System.Exception p_Exception)
				{
					this.OnEditException(new global::SourceGrid.ExceptionEventArgs(p_Exception));
					cellContext.Cell.Model.ValueModel.SetValue(cellContext, value);
					validatingCellEventArgs.Cancel = true;
				}
			}
			return !validatingCellEventArgs.Cancel;
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x0008CDF4 File Offset: 0x0008AFF4
		protected void OnValidated(global::SourceGrid.CellContextEventArgs e)
		{
			if (this.m_Validated != null)
			{
				this.m_Validated(this, e);
			}
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x0008CE10 File Offset: 0x0008B010
		protected void OnValidating(global::SourceGrid.ValidatingCellEventArgs e)
		{
			if (this.m_Validating != null)
			{
				this.m_Validating(this, e);
			}
		}

		// Token: 0x140000B9 RID: 185
		// (add) Token: 0x060028B5 RID: 10421 RVA: 0x0008CE2C File Offset: 0x0008B02C
		// (remove) Token: 0x060028B6 RID: 10422 RVA: 0x0008CE48 File Offset: 0x0008B048
		private event global::SourceGrid.ValidatingCellEventHandler m_Validating;

		// Token: 0x140000BA RID: 186
		// (add) Token: 0x060028B7 RID: 10423 RVA: 0x0008CE64 File Offset: 0x0008B064
		// (remove) Token: 0x060028B8 RID: 10424 RVA: 0x0008CE80 File Offset: 0x0008B080
		private event global::SourceGrid.CellContextEventHandler m_Validated;

		// Token: 0x140000BB RID: 187
		// (add) Token: 0x060028B9 RID: 10425 RVA: 0x0008CE9C File Offset: 0x0008B09C
		// (remove) Token: 0x060028BA RID: 10426 RVA: 0x0008CEB8 File Offset: 0x0008B0B8
		[global::System.Obsolete("You should use the Control.Validating event")]
		public event global::SourceGrid.ValidatingCellEventHandler Validating
		{
			add
			{
				this.m_Validating = (global::SourceGrid.ValidatingCellEventHandler)global::System.Delegate.Combine(this.m_Validating, value);
			}
			remove
			{
				this.m_Validating = (global::SourceGrid.ValidatingCellEventHandler)global::System.Delegate.Remove(this.m_Validating, value);
			}
		}

		// Token: 0x140000BC RID: 188
		// (add) Token: 0x060028BB RID: 10427 RVA: 0x0008CED4 File Offset: 0x0008B0D4
		// (remove) Token: 0x060028BC RID: 10428 RVA: 0x0008CEF0 File Offset: 0x0008B0F0
		[global::System.Obsolete("You should use the Control.Validated event")]
		public event global::SourceGrid.CellContextEventHandler Validated
		{
			add
			{
				this.m_Validated = (global::SourceGrid.CellContextEventHandler)global::System.Delegate.Combine(this.m_Validated, value);
			}
			remove
			{
				this.m_Validated = (global::SourceGrid.CellContextEventHandler)global::System.Delegate.Remove(this.m_Validated, value);
			}
		}

		// Token: 0x140000BD RID: 189
		// (add) Token: 0x060028BD RID: 10429 RVA: 0x0008CF0C File Offset: 0x0008B10C
		// (remove) Token: 0x060028BE RID: 10430 RVA: 0x0008CF28 File Offset: 0x0008B128
		public event global::SourceGrid.ExceptionEventHandler EditException;

		// Token: 0x060028BF RID: 10431 RVA: 0x0008CF44 File Offset: 0x0008B144
		protected virtual void OnEditException(global::SourceGrid.ExceptionEventArgs e)
		{
			if (this.EditException != null)
			{
				this.EditException(this, e);
			}
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0008CF60 File Offset: 0x0008B160
		public virtual void SendCharToEditor(char key)
		{
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0008CF64 File Offset: 0x0008B164
		public virtual global::System.Drawing.Size GetMinimumSize(global::SourceGrid.CellContext cellContext)
		{
			return global::System.Drawing.Size.Empty;
		}

		// Token: 0x04000E06 RID: 3590
		private global::SourceGrid.CellContext mEditCellContext = global::SourceGrid.CellContext.Empty;

		// Token: 0x04000E07 RID: 3591
		private string m_ErrorString = "#ERROR!";

		// Token: 0x04000E08 RID: 3592
		private bool m_bEnableEdit = true;

		// Token: 0x04000E09 RID: 3593
		private global::SourceGrid.EditableMode m_EditableMode = global::SourceGrid.EditableMode.Default;

		// Token: 0x04000E0A RID: 3594
		private bool m_bEnableCellDrawOnEdit = true;

		// Token: 0x04000E0B RID: 3595
		private bool mUseCellViewProperties = true;
	}
}
