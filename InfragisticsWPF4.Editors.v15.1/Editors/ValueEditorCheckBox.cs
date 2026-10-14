using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000076 RID: 118
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ValueEditorCheckBox : global::System.Windows.Controls.CheckBox
	{
		// Token: 0x06000654 RID: 1620 RVA: 0x00019FAC File Offset: 0x000181AC
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.Editors.ValueEditor), true);
			if (valueEditor != null && !valueEditor.IsInEditMode)
			{
				return;
			}
			base.OnMouseLeftButtonDown(e);
		}
	}
}
