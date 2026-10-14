using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001A0 RID: 416
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryButton : global::System.Windows.Controls.Primitives.ToggleButton
	{
		// Token: 0x06001706 RID: 5894 RVA: 0x00065E04 File Offset: 0x00064004
		static SummaryButton()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryButton)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryButton), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.SummaryButton.OnCoerceIsChecked)));
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00065EA1 File Offset: 0x000640A1
		public SummaryButton()
		{
			base.AddHandler(global::System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new global::System.Windows.RoutedEventHandler(this.OnButtonClick));
			global::System.Windows.Input.CommandManager.AddPreviewCanExecuteHandler(this, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.OnPreviewCanExecuteCommandHandler));
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00065ED4 File Offset: 0x000640D4
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Point position = e.GetPosition(this);
			global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
			if (!rect.Contains(position))
			{
				e.Handled = true;
				return;
			}
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x00065F0F File Offset: 0x0006410F
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x00065F21 File Offset: 0x00064121
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Field)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryButton.FieldProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryButton.FieldProperty, value);
			}
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00065F30 File Offset: 0x00064130
		private static object OnCoerceIsChecked(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			global::Infragistics.Windows.DataPresenter.SummaryButton summaryButton = (global::Infragistics.Windows.DataPresenter.SummaryButton)dependencyObject;
			bool flag = ((bool?)valueAsObject) ?? false;
			bool flag2 = summaryButton.IsChecked ?? false;
			if (flag != flag2)
			{
				global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl summaryCalculatorSelectionControl = (global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl)global::Infragistics.Windows.DataPresenter.GridUtilities.GetTrivialDescendantOfType(summaryButton, typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), true);
				if (summaryCalculatorSelectionControl != null)
				{
					if (flag)
					{
						summaryButton._isCanceled = false;
						if (!summaryCalculatorSelectionControl.OnOpenning())
						{
							return false;
						}
					}
					else
					{
						summaryCalculatorSelectionControl.OnClosed(summaryButton._isCanceled);
					}
				}
			}
			return valueAsObject;
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00065FC0 File Offset: 0x000641C0
		private void OnButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Controls.Button button = e.OriginalSource as global::System.Windows.Controls.Button;
			if (button != null)
			{
				this._isCanceled = false;
				if (button.IsCancel || button.Name == "RowSummaryCancelButton")
				{
					this._isCanceled = true;
					base.IsChecked = new bool?(false);
					return;
				}
				if (button.IsDefault || button.Name == "RowSummaryOkButton")
				{
					this._isCanceled = false;
					base.IsChecked = new bool?(false);
				}
			}
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00066040 File Offset: 0x00064240
		private void OnPreviewCanExecuteCommandHandler(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
			if (routedCommand != null && "DialogCancel" == routedCommand.Name)
			{
				e.CanExecute = false;
				e.ContinueRouting = false;
				e.Handled = true;
			}
		}

		// Token: 0x04000902 RID: 2306
		private bool _isCanceled;

		// Token: 0x04000903 RID: 2307
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.SummaryButton), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
