using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.Windows.Forms;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x02000395 RID: 917
	[global::System.ComponentModel.ToolboxItem(false)]
	internal class TextBox : global::SourceGrid.Cells.Editors.EditorControlBase
	{
		// Token: 0x06002B13 RID: 11027 RVA: 0x000914EC File Offset: 0x0008F6EC
		public TextBox(global::System.Type p_Type) : base(p_Type)
		{
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x000914F8 File Offset: 0x0008F6F8
		protected override global::System.Windows.Forms.Control CreateControl()
		{
			return new global::DevAge.Windows.Forms.DevAgeTextBox
			{
				BorderStyle = global::System.Windows.Forms.BorderStyle.None,
				AutoSize = false,
				Validator = this
			};
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x00091528 File Offset: 0x0008F728
		public new global::DevAge.Windows.Forms.DevAgeTextBox Control
		{
			get
			{
				return (global::DevAge.Windows.Forms.DevAgeTextBox)base.Control;
			}
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00091538 File Offset: 0x0008F738
		protected override void OnStartingEdit(global::SourceGrid.CellContext cellContext, global::System.Windows.Forms.Control editorControl)
		{
			base.OnStartingEdit(cellContext, editorControl);
			global::DevAge.Windows.Forms.DevAgeTextBox devAgeTextBox = (global::DevAge.Windows.Forms.DevAgeTextBox)editorControl;
			devAgeTextBox.WordWrap = cellContext.Cell.View.WordWrap;
			devAgeTextBox.TextAlign = global::DevAge.Windows.Forms.Utilities.ContentToHorizontalAlignment(cellContext.Cell.View.TextAlignment);
			devAgeTextBox.SelectionStart = 0;
			devAgeTextBox.SelectionLength = 0;
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x0009159C File Offset: 0x0008F79C
		public override void SetEditValue(object editValue)
		{
			this.Control.Value = editValue;
			this.Control.SelectAll();
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000915B8 File Offset: 0x0008F7B8
		public override object GetEditedValue()
		{
			return this.Control.Value;
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x000915C8 File Offset: 0x0008F7C8
		protected override void OnSendCharToEditor(char key)
		{
			this.Control.Text = key.ToString();
			if (this.Control.Text != null)
			{
				this.Control.SelectionStart = this.Control.Text.Length;
			}
		}
	}
}
