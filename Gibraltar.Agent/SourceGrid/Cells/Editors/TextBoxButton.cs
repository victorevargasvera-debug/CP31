using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.Drawing;
using DevAge.Windows.Forms;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x02000350 RID: 848
	[global::System.ComponentModel.ToolboxItem(false)]
	internal class TextBoxButton : global::SourceGrid.Cells.Editors.EditorControlBase
	{
		// Token: 0x06002975 RID: 10613 RVA: 0x0008E2B4 File Offset: 0x0008C4B4
		public TextBoxButton(global::System.Type p_Type) : base(p_Type)
		{
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x0008E2C0 File Offset: 0x0008C4C0
		protected override global::System.Windows.Forms.Control CreateControl()
		{
			return new global::DevAge.Windows.Forms.DevAgeTextBoxButton
			{
				BorderStyle = global::DevAge.Drawing.BorderStyle.None,
				Validator = this
			};
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x0008E2E8 File Offset: 0x0008C4E8
		public new global::DevAge.Windows.Forms.DevAgeTextBoxButton Control
		{
			get
			{
				return (global::DevAge.Windows.Forms.DevAgeTextBoxButton)base.Control;
			}
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x0008E2F8 File Offset: 0x0008C4F8
		protected override void OnStartingEdit(global::SourceGrid.CellContext cellContext, global::System.Windows.Forms.Control editorControl)
		{
			base.OnStartingEdit(cellContext, editorControl);
			global::DevAge.Windows.Forms.DevAgeTextBoxButton devAgeTextBoxButton = (global::DevAge.Windows.Forms.DevAgeTextBoxButton)editorControl;
			devAgeTextBoxButton.TextBox.SelectionStart = 0;
			devAgeTextBoxButton.TextBox.SelectionLength = 0;
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x0008E330 File Offset: 0x0008C530
		public override void SetEditValue(object editValue)
		{
			this.Control.Value = editValue;
			this.Control.TextBox.SelectAll();
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0008E360 File Offset: 0x0008C560
		public override object GetEditedValue()
		{
			return this.Control.Value;
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x0008E370 File Offset: 0x0008C570
		protected override void OnSendCharToEditor(char key)
		{
			this.Control.TextBox.Text = key.ToString();
			if (this.Control.TextBox.Text != null)
			{
				this.Control.TextBox.SelectionStart = this.Control.TextBox.Text.Length;
			}
		}
	}
}
