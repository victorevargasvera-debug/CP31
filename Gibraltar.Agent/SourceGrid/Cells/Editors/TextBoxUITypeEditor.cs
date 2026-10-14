using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using DevAge.Drawing;
using DevAge.Windows.Forms;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x02000351 RID: 849
	[global::System.ComponentModel.ToolboxItem(false)]
	internal class TextBoxUITypeEditor : global::SourceGrid.Cells.Editors.TextBoxButton
	{
		// Token: 0x0600297C RID: 10620 RVA: 0x0008E3D4 File Offset: 0x0008C5D4
		public TextBoxUITypeEditor(global::System.Type p_Type) : base(p_Type)
		{
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x0008E3E0 File Offset: 0x0008C5E0
		protected override global::System.Windows.Forms.Control CreateControl()
		{
			global::DevAge.Windows.Forms.TextBoxUITypeEditor textBoxUITypeEditor = new global::DevAge.Windows.Forms.TextBoxUITypeEditor();
			textBoxUITypeEditor.BorderStyle = global::DevAge.Drawing.BorderStyle.None;
			textBoxUITypeEditor.Validator = this;
			object editor = global::System.ComponentModel.TypeDescriptor.GetEditor(base.ValueType, typeof(global::System.Drawing.Design.UITypeEditor));
			global::System.Drawing.Design.UITypeEditor uitypeEditor = null;
			if (textBoxUITypeEditor != null)
			{
				uitypeEditor = (global::System.Drawing.Design.UITypeEditor)editor;
			}
			textBoxUITypeEditor.UITypeEditor = uitypeEditor;
			return textBoxUITypeEditor;
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x0008E434 File Offset: 0x0008C634
		public new global::DevAge.Windows.Forms.TextBoxUITypeEditor Control
		{
			get
			{
				return (global::DevAge.Windows.Forms.TextBoxUITypeEditor)base.Control;
			}
		}
	}
}
