using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C3 RID: 451
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryButton : global::System.Windows.Controls.Primitives.ToggleButton
	{
		// Token: 0x06001AC3 RID: 6851 RVA: 0x0007899C File Offset: 0x00076B9C
		static SummaryButton()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryButton)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryButton), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.SummaryButton.OnCoerceIsChecked)));
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00078A39 File Offset: 0x00076C39
		public SummaryButton()
		{
			base.AddHandler(global::System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new global::System.Windows.RoutedEventHandler(this.OnButtonClick));
			global::System.Windows.Input.CommandManager.AddPreviewCanExecuteHandler(this, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.OnPreviewCanExecuteCommandHandler));
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00078A6C File Offset: 0x00076C6C
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

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x00078AA7 File Offset: 0x00076CA7
		// (set) Token: 0x06001AC7 RID: 6855 RVA: 0x00078AB9 File Offset: 0x00076CB9
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00078AC8 File Offset: 0x00076CC8
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

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00078B58 File Offset: 0x00076D58
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

		// Token: 0x06001ACA RID: 6858 RVA: 0x00078BD8 File Offset: 0x00076DD8
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

		// Token: 0x04000ACC RID: 2764
		private bool _isCanceled;

		// Token: 0x04000ACD RID: 2765
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.SummaryButton), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
