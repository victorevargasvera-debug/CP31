using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000027 RID: 39
	public class DataGridCheckBoxColumn : global::Microsoft.Windows.Controls.DataGridBoundColumn
	{
		// Token: 0x0600022D RID: 557 RVA: 0x00009034 File Offset: 0x00007234
		static DataGridCheckBoxColumn()
		{
			global::Microsoft.Windows.Controls.DataGridBoundColumn.ElementStyleProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridCheckBoxColumn), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridCheckBoxColumn.DefaultElementStyle));
			global::Microsoft.Windows.Controls.DataGridBoundColumn.EditingElementStyleProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridCheckBoxColumn), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridCheckBoxColumn.DefaultEditingElementStyle));
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600022E RID: 558 RVA: 0x000090B0 File Offset: 0x000072B0
		public static global::System.Windows.Style DefaultElementStyle
		{
			get
			{
				if (global::Microsoft.Windows.Controls.DataGridCheckBoxColumn._defaultElementStyle == null)
				{
					global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::System.Windows.Controls.CheckBox));
					style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.UIElement.IsHitTestVisibleProperty, false));
					style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.UIElement.FocusableProperty, false));
					style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.FrameworkElement.HorizontalAlignmentProperty, global::System.Windows.HorizontalAlignment.Center));
					style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.FrameworkElement.VerticalAlignmentProperty, global::System.Windows.VerticalAlignment.Top));
					style.Seal();
					global::Microsoft.Windows.Controls.DataGridCheckBoxColumn._defaultElementStyle = style;
				}
				return global::Microsoft.Windows.Controls.DataGridCheckBoxColumn._defaultElementStyle;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00009154 File Offset: 0x00007354
		public static global::System.Windows.Style DefaultEditingElementStyle
		{
			get
			{
				if (global::Microsoft.Windows.Controls.DataGridCheckBoxColumn._defaultEditingElementStyle == null)
				{
					global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::System.Windows.Controls.CheckBox));
					style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.FrameworkElement.HorizontalAlignmentProperty, global::System.Windows.HorizontalAlignment.Center));
					style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.FrameworkElement.VerticalAlignmentProperty, global::System.Windows.VerticalAlignment.Top));
					style.Seal();
					global::Microsoft.Windows.Controls.DataGridCheckBoxColumn._defaultEditingElementStyle = style;
				}
				return global::Microsoft.Windows.Controls.DataGridCheckBoxColumn._defaultEditingElementStyle;
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000091BF File Offset: 0x000073BF
		protected override global::System.Windows.FrameworkElement GenerateElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem)
		{
			return this.GenerateCheckBox(false, cell);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000091C9 File Offset: 0x000073C9
		protected override global::System.Windows.FrameworkElement GenerateEditingElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem)
		{
			return this.GenerateCheckBox(true, cell);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000091D4 File Offset: 0x000073D4
		private global::System.Windows.Controls.CheckBox GenerateCheckBox(bool isEditing, global::Microsoft.Windows.Controls.DataGridCell cell)
		{
			global::System.Windows.Controls.CheckBox checkBox = (cell != null) ? (cell.Content as global::System.Windows.Controls.CheckBox) : null;
			if (checkBox == null)
			{
				checkBox = new global::System.Windows.Controls.CheckBox();
			}
			checkBox.IsThreeState = this.IsThreeState;
			base.ApplyStyle(isEditing, true, checkBox);
			base.ApplyBinding(checkBox, global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty);
			return checkBox;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00009220 File Offset: 0x00007420
		protected internal override void RefreshCellContent(global::System.Windows.FrameworkElement element, string propertyName)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = element as global::Microsoft.Windows.Controls.DataGridCell;
			if (dataGridCell != null && string.Compare(propertyName, "IsThreeState", global::System.StringComparison.Ordinal) == 0)
			{
				global::System.Windows.Controls.CheckBox checkBox = dataGridCell.Content as global::System.Windows.Controls.CheckBox;
				if (checkBox != null)
				{
					checkBox.IsThreeState = this.IsThreeState;
					return;
				}
			}
			else
			{
				base.RefreshCellContent(element, propertyName);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00009269 File Offset: 0x00007469
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0000927B File Offset: 0x0000747B
		public bool IsThreeState
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridCheckBoxColumn.IsThreeStateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridCheckBoxColumn.IsThreeStateProperty, value);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00009290 File Offset: 0x00007490
		protected override object PrepareCellForEdit(global::System.Windows.FrameworkElement editingElement, global::System.Windows.RoutedEventArgs editingEventArgs)
		{
			global::System.Windows.Controls.CheckBox checkBox = editingElement as global::System.Windows.Controls.CheckBox;
			if (checkBox != null)
			{
				checkBox.Focus();
				bool? isChecked = checkBox.IsChecked;
				if ((global::Microsoft.Windows.Controls.DataGridCheckBoxColumn.IsMouseLeftButtonDown(editingEventArgs) && global::Microsoft.Windows.Controls.DataGridCheckBoxColumn.IsMouseOver(checkBox, editingEventArgs)) || global::Microsoft.Windows.Controls.DataGridCheckBoxColumn.IsSpaceKeyDown(editingEventArgs))
				{
					checkBox.IsChecked = new bool?(isChecked != true);
				}
				return isChecked;
			}
			return new bool?(false);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00009304 File Offset: 0x00007504
		protected override bool CommitCellEdit(global::System.Windows.FrameworkElement editingElement)
		{
			global::System.Windows.Controls.CheckBox checkBox = editingElement as global::System.Windows.Controls.CheckBox;
			if (checkBox != null)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.UpdateSource(checkBox, global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty);
				return !global::System.Windows.Controls.Validation.GetHasError(checkBox);
			}
			return true;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00009334 File Offset: 0x00007534
		protected override void CancelCellEdit(global::System.Windows.FrameworkElement editingElement, object uneditedValue)
		{
			global::System.Windows.Controls.CheckBox checkBox = editingElement as global::System.Windows.Controls.CheckBox;
			if (checkBox != null)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.UpdateTarget(checkBox, global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00009356 File Offset: 0x00007556
		internal override void OnInput(global::System.Windows.Input.InputEventArgs e)
		{
			if (global::Microsoft.Windows.Controls.DataGridCheckBoxColumn.IsSpaceKeyDown(e))
			{
				base.BeginEdit(e);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00009368 File Offset: 0x00007568
		private static bool IsMouseLeftButtonDown(global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Input.MouseButtonEventArgs mouseButtonEventArgs = e as global::System.Windows.Input.MouseButtonEventArgs;
			return mouseButtonEventArgs != null && mouseButtonEventArgs.ChangedButton == global::System.Windows.Input.MouseButton.Left && mouseButtonEventArgs.ButtonState == global::System.Windows.Input.MouseButtonState.Pressed;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00009392 File Offset: 0x00007592
		private static bool IsMouseOver(global::System.Windows.Controls.CheckBox checkBox, global::System.Windows.RoutedEventArgs e)
		{
			return checkBox.InputHitTest(((global::System.Windows.Input.MouseButtonEventArgs)e).GetPosition(checkBox)) != null;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000093AC File Offset: 0x000075AC
		private static bool IsSpaceKeyDown(global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Input.KeyEventArgs keyEventArgs = e as global::System.Windows.Input.KeyEventArgs;
			return keyEventArgs != null && (byte)(keyEventArgs.KeyStates & global::System.Windows.Input.KeyStates.Down) == 1 && keyEventArgs.Key == global::System.Windows.Input.Key.Space;
		}

		// Token: 0x04000088 RID: 136
		public static readonly global::System.Windows.DependencyProperty IsThreeStateProperty = global::System.Windows.Controls.Primitives.ToggleButton.IsThreeStateProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridCheckBoxColumn), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x04000089 RID: 137
		private static global::System.Windows.Style _defaultElementStyle;

		// Token: 0x0400008A RID: 138
		private static global::System.Windows.Style _defaultEditingElementStyle;
	}
}
