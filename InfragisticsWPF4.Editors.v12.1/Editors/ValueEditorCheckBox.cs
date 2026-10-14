using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000070 RID: 112
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ValueEditorCheckBox : global::System.Windows.Controls.CheckBox
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x000188CC File Offset: 0x00016ACC
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
