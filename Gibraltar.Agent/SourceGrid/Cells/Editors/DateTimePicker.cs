using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x02000348 RID: 840
	[global::System.ComponentModel.ToolboxItem(false)]
	internal class DateTimePicker : global::SourceGrid.Cells.Editors.EditorControlBase
	{
		// Token: 0x060028D9 RID: 10457 RVA: 0x0008D488 File Offset: 0x0008B688
		public DateTimePicker() : base(typeof(global::System.DateTime))
		{
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0008D49C File Offset: 0x0008B69C
		protected override global::System.Windows.Forms.Control CreateControl()
		{
			return new global::System.Windows.Forms.DateTimePicker
			{
				Format = global::System.Windows.Forms.DateTimePickerFormat.Short,
				ShowCheckBox = base.AllowNull
			};
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0008D4C8 File Offset: 0x0008B6C8
		protected override void OnChanged(global::System.EventArgs e)
		{
			base.OnChanged(e);
			if (this.Control != null)
			{
				this.Control.ShowCheckBox = base.AllowNull;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060028DC RID: 10460 RVA: 0x0008D4FC File Offset: 0x0008B6FC
		public new global::System.Windows.Forms.DateTimePicker Control
		{
			get
			{
				return (global::System.Windows.Forms.DateTimePicker)base.Control;
			}
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0008D50C File Offset: 0x0008B70C
		protected override void OnStartingEdit(global::SourceGrid.CellContext cellContext, global::System.Windows.Forms.Control editorControl)
		{
			base.OnStartingEdit(cellContext, editorControl);
			global::System.Windows.Forms.DateTimePicker dateTimePicker = (global::System.Windows.Forms.DateTimePicker)editorControl;
			dateTimePicker.Font = cellContext.Cell.View.Font;
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x0008D544 File Offset: 0x0008B744
		public override void SetEditValue(object editValue)
		{
			if (editValue is global::System.DateTime)
			{
				this.Control.Value = (global::System.DateTime)editValue;
				return;
			}
			if (editValue == null)
			{
				this.Control.Checked = false;
				return;
			}
			throw new global::SourceGrid.SourceGridException("Invalid edit value, expected DateTime");
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x0008D580 File Offset: 0x0008B780
		public override object GetEditedValue()
		{
			if (this.Control.Checked)
			{
				return this.Control.Value;
			}
			return null;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0008D5A4 File Offset: 0x0008B7A4
		protected override void OnSendCharToEditor(char key)
		{
		}
	}
}
