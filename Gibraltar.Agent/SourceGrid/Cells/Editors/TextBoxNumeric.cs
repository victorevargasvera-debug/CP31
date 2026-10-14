using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.Windows.Forms;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x020003B5 RID: 949
	[global::System.ComponentModel.ToolboxItem(false)]
	internal class TextBoxNumeric : global::SourceGrid.Cells.Editors.TextBox
	{
		// Token: 0x06002B95 RID: 11157 RVA: 0x00092538 File Offset: 0x00090738
		public TextBoxNumeric(global::System.Type p_Type) : base(p_Type)
		{
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x00092544 File Offset: 0x00090744
		protected override global::System.Windows.Forms.Control CreateControl()
		{
			return new global::DevAge.Windows.Forms.DevAgeTextBox
			{
				BorderStyle = global::System.Windows.Forms.BorderStyle.None,
				AutoSize = false,
				Validator = this
			};
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002B97 RID: 11159 RVA: 0x00092574 File Offset: 0x00090774
		public new global::DevAge.Windows.Forms.DevAgeTextBox Control
		{
			get
			{
				return base.Control;
			}
		}
	}
}
