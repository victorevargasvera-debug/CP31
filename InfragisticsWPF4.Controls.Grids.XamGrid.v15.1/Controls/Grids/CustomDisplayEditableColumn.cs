using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000235 RID: 565
	public abstract class CustomDisplayEditableColumn : global::Infragistics.Controls.Grids.EditableColumn
	{
		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x0003E39E File Offset: 0x0003C59E
		// (set) Token: 0x060010C9 RID: 4297 RVA: 0x0003E3B0 File Offset: 0x0003C5B0
		public global::Infragistics.Controls.Grids.EditorDisplayBehaviors EditorDisplayBehavior
		{
			get
			{
				return (global::Infragistics.Controls.Grids.EditorDisplayBehaviors)base.GetValue(global::Infragistics.Controls.Grids.CustomDisplayEditableColumn.EditorDisplayBehaviorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.CustomDisplayEditableColumn.EditorDisplayBehaviorProperty, value);
			}
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0003E3C4 File Offset: 0x0003C5C4
		private static void EditorDisplayBehaviorChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.CustomDisplayEditableColumn customDisplayEditableColumn = (global::Infragistics.Controls.Grids.CustomDisplayEditableColumn)obj;
			customDisplayEditableColumn.OnPropertyChanged("EditorDisplayBehavior");
			customDisplayEditableColumn.RedrawGrid();
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0003E3E9 File Offset: 0x0003C5E9
		private void RedrawGrid()
		{
			if (base.ColumnLayout != null && base.ColumnLayout.Grid != null && base.ColumnLayout.Grid.IsLoaded)
			{
				base.ColumnLayout.Grid.ResetPanelRows(true);
			}
		}

		// Token: 0x04000548 RID: 1352
		public static readonly global::System.Windows.DependencyProperty EditorDisplayBehaviorProperty = global::System.Windows.DependencyProperty.Register("EditorDisplayBehavior", typeof(global::Infragistics.Controls.Grids.EditorDisplayBehaviors), typeof(global::Infragistics.Controls.Grids.CustomDisplayEditableColumn), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.EditorDisplayBehaviors.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.CustomDisplayEditableColumn.EditorDisplayBehaviorChanged)));
	}
}
