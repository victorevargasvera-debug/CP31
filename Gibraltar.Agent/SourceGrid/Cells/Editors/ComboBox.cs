using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.Windows.Forms;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x020003E0 RID: 992
	[global::System.ComponentModel.ToolboxItem(false)]
	internal class ComboBox : global::SourceGrid.Cells.Editors.EditorControlBase
	{
		// Token: 0x06002C4B RID: 11339 RVA: 0x00094C00 File Offset: 0x00092E00
		public ComboBox(global::System.Type p_Type) : base(p_Type)
		{
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x00094C0C File Offset: 0x00092E0C
		public ComboBox(global::System.Type p_Type, global::System.Collections.ICollection p_StandardValues, bool p_StandardValueExclusive) : base(p_Type)
		{
			base.StandardValues = p_StandardValues;
			base.StandardValuesExclusive = p_StandardValueExclusive;
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x00094C24 File Offset: 0x00092E24
		protected override global::System.Windows.Forms.Control CreateControl()
		{
			return new global::DevAge.Windows.Forms.DevAgeComboBox
			{
				Validator = this
			};
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x00094C44 File Offset: 0x00092E44
		public new global::DevAge.Windows.Forms.DevAgeComboBox Control
		{
			get
			{
				return (global::DevAge.Windows.Forms.DevAgeComboBox)base.Control;
			}
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x00094C54 File Offset: 0x00092E54
		public override void SetEditValue(object editValue)
		{
			if (!(editValue is string) || !this.IsStringConversionSupported() || this.Control.DropDownStyle != global::System.Windows.Forms.ComboBoxStyle.DropDown)
			{
				this.Control.SelectedIndex = -1;
				this.Control.Value = editValue;
				this.Control.SelectAll();
				return;
			}
			this.Control.SelectedIndex = -1;
			this.Control.Text = (string)editValue;
			this.Control.SelectionLength = 0;
			if (this.Control.Text != null)
			{
				this.Control.SelectionStart = this.Control.Text.Length;
				return;
			}
			this.Control.SelectionStart = 0;
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x00094D14 File Offset: 0x00092F14
		public override object GetEditedValue()
		{
			return this.Control.Value;
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x00094D24 File Offset: 0x00092F24
		protected override void OnSendCharToEditor(char key)
		{
			if (this.Control.DropDownStyle == global::System.Windows.Forms.ComboBoxStyle.DropDown)
			{
				this.Control.Text = key.ToString();
				if (this.Control.Text != null)
				{
					this.Control.SelectionStart = this.Control.Text.Length;
				}
			}
		}
	}
}
