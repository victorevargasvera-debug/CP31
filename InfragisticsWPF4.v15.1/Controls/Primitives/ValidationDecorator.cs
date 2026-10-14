using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Infragistics.Windows.Internal;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x0200009F RID: 159
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "NoError", GroupName = "ErrorStates")]
	[global::System.Windows.TemplateVisualState(Name = "Closed", GroupName = "OpenStates")]
	[global::System.Windows.TemplateVisualState(Name = "Error", GroupName = "ErrorStates")]
	[global::System.Windows.TemplateVisualState(Name = "Open", GroupName = "OpenStates")]
	public class ValidationDecorator : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06000611 RID: 1553 RVA: 0x00017A00 File Offset: 0x00015C00
		static ValidationDecorator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Primitives.ValidationDecorator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Primitives.ValidationDecorator)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Primitives.ValidationDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00017B40 File Offset: 0x00015D40
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.Controls.PresentationUtilities.GetTemplatedParent(this) as global::System.Windows.FrameworkElement;
			if (frameworkElement != this._templatedParent)
			{
				if (this._errorEventHandler != null)
				{
					this._errorEventHandler.Detach();
					this._errorEventHandler = null;
				}
				this.ClearErrorState();
				this._hasValidationErrorTracker = null;
				this._focusTracker = null;
				this._templatedParent = frameworkElement;
				if (this._templatedParent != null)
				{
					this._focusTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._templatedParent, global::System.Windows.UIElement.IsKeyboardFocusWithinProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFocusChanged));
					this._hasValidationErrorTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._templatedParent, global::System.Windows.Controls.Validation.HasErrorProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnHasValidationErrorChanged));
					this._errorEventHandler = new global::Infragistics.WeakEventHandler<global::Infragistics.Controls.Primitives.ValidationDecorator, global::System.Windows.FrameworkElement, global::System.Windows.Controls.ValidationErrorEventArgs>(this, this._templatedParent, delegate(global::Infragistics.Controls.Primitives.ValidationDecorator instance, object s, global::System.Windows.Controls.ValidationErrorEventArgs e)
					{
						instance.OnBindingValidationError(s, e);
					}, delegate(global::Infragistics.WeakEventHandler<global::Infragistics.Controls.Primitives.ValidationDecorator, global::System.Windows.FrameworkElement, global::System.Windows.Controls.ValidationErrorEventArgs> weakHandler, global::System.Windows.FrameworkElement eventSource)
					{
						global::System.Windows.Controls.Validation.RemoveErrorHandler(eventSource, new global::System.EventHandler<global::System.Windows.Controls.ValidationErrorEventArgs>(weakHandler.OnEvent));
					});
					global::System.Windows.Controls.Validation.AddErrorHandler(this._templatedParent, new global::System.EventHandler<global::System.Windows.Controls.ValidationErrorEventArgs>(this._errorEventHandler.OnEvent));
				}
				global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::System.Windows.Controls.ValidationError> errors = global::System.Windows.Controls.Validation.GetErrors(this._templatedParent);
				if (errors != null && errors.Count != 0)
				{
					this.UpdateForValidationError(errors[errors.Count - 1]);
				}
			}
			this.UpdateVisualStates(false);
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00017C89 File Offset: 0x00015E89
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00017C96 File Offset: 0x00015E96
		public object ErrorContent
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Primitives.ValidationDecorator.ErrorContentProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.ValidationDecorator.ErrorContentPropertyKey, value);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00017CA4 File Offset: 0x00015EA4
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00017CB6 File Offset: 0x00015EB6
		public global::System.Windows.Media.Brush ErrorForeground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Primitives.ValidationDecorator.ErrorForegroundProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.ValidationDecorator.ErrorForegroundProperty, value);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00017CC4 File Offset: 0x00015EC4
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00017CD6 File Offset: 0x00015ED6
		public bool HasError
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Primitives.ValidationDecorator.HasErrorProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.ValidationDecorator.HasErrorPropertyKey, value);
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00017CEC File Offset: 0x00015EEC
		private static void OnIsToolTipOpenChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Primitives.ValidationDecorator validationDecorator = target as global::Infragistics.Controls.Primitives.ValidationDecorator;
			if (validationDecorator != null)
			{
				validationDecorator.VerifyIsTooltipOpen(true, true);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00017D0B File Offset: 0x00015F0B
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00017D1D File Offset: 0x00015F1D
		public bool IsToolTipOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Primitives.ValidationDecorator.IsToolTipOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.ValidationDecorator.IsToolTipOpenProperty, value);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00017D30 File Offset: 0x00015F30
		private void ClearErrorState()
		{
			base.ClearValue(global::Infragistics.Controls.Primitives.ValidationDecorator.ErrorContentPropertyKey);
			base.ClearValue(global::Infragistics.Controls.Primitives.ValidationDecorator.HasErrorPropertyKey);
			base.SetValue(global::Infragistics.Controls.Primitives.ValidationDecorator.IsToolTipOpenProperty, global::Infragistics.KnownBoxes.FalseBox);
			this.UpdateVisualStates(false);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00017D60 File Offset: 0x00015F60
		private void OnBindingValidationError(object sender, global::System.Windows.Controls.ValidationErrorEventArgs e)
		{
			global::System.Windows.Controls.ValidationError error = null;
			if (e.Action == global::System.Windows.Controls.ValidationErrorEventAction.Added)
			{
				error = e.Error;
			}
			else
			{
				global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::System.Windows.Controls.ValidationError> errors = global::System.Windows.Controls.Validation.GetErrors(this._templatedParent);
				if (errors != null && errors.Count != 0)
				{
					error = errors[errors.Count - 1];
				}
			}
			this.UpdateForValidationError(error);
			this.UpdateVisualStates(true);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00017DB4 File Offset: 0x00015FB4
		private void OnFocusChanged()
		{
			this.VerifyIsTooltipOpen(true, false);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00017DC0 File Offset: 0x00015FC0
		private void OnHasValidationErrorChanged()
		{
			global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::System.Windows.Controls.ValidationError> readOnlyObservableCollection = (this._templatedParent == null) ? null : global::System.Windows.Controls.Validation.GetErrors(this._templatedParent);
			if (readOnlyObservableCollection == null || readOnlyObservableCollection.Count == 0)
			{
				this.ClearErrorState();
				return;
			}
			this.UpdateForValidationError(readOnlyObservableCollection[readOnlyObservableCollection.Count - 1]);
			this.UpdateVisualStates(false);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00017E11 File Offset: 0x00016011
		private void UpdateForValidationError(global::System.Windows.Controls.ValidationError error)
		{
			if (error != null)
			{
				this.HasError = true;
				this.ErrorContent = error.ErrorContent;
			}
			else
			{
				base.ClearValue(global::Infragistics.Controls.Primitives.ValidationDecorator.HasErrorPropertyKey);
				base.ClearValue(global::Infragistics.Controls.Primitives.ValidationDecorator.ErrorContentPropertyKey);
			}
			this.VerifyIsTooltipOpen(false, false);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00017E4C File Offset: 0x0001604C
		private void UpdateVisualStates(bool transition)
		{
			if (this.HasError)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, transition, new string[]
				{
					"Error"
				});
			}
			else
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, transition, new string[]
				{
					"NoError"
				});
			}
			if (this.IsToolTipOpen)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, transition, new string[]
				{
					"Open"
				});
				return;
			}
			global::Infragistics.VisualStateUtilities.GoToState(this, transition, new string[]
			{
				"Closed"
			});
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00017EC8 File Offset: 0x000160C8
		private void VerifyIsTooltipOpen(bool updateVisualStates, bool calledFronIsOpneChanged)
		{
			bool flag = false;
			global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.Controls.PresentationUtilities.GetElementWithKeyboardFocus() as global::System.Windows.FrameworkElement;
			if (frameworkElement != null && (this._templatedParent == frameworkElement || global::Infragistics.Controls.PresentationUtilities.IsAncestorOf(this._templatedParent, frameworkElement)))
			{
				flag = this.HasError;
			}
			if (flag || !calledFronIsOpneChanged)
			{
				this.IsToolTipOpen = flag;
			}
			if (updateVisualStates)
			{
				this.UpdateVisualStates(true);
			}
		}

		// Token: 0x04000269 RID: 617
		private global::System.Windows.FrameworkElement _templatedParent;

		// Token: 0x0400026A RID: 618
		private global::Infragistics.WeakEventHandler<global::Infragistics.Controls.Primitives.ValidationDecorator, global::System.Windows.FrameworkElement, global::System.Windows.Controls.ValidationErrorEventArgs> _errorEventHandler;

		// Token: 0x0400026B RID: 619
		private global::Infragistics.Windows.Internal.PropertyValueTracker _focusTracker;

		// Token: 0x0400026C RID: 620
		private global::Infragistics.Windows.Internal.PropertyValueTracker _hasValidationErrorTracker;

		// Token: 0x0400026D RID: 621
		private static readonly global::System.Windows.DependencyPropertyKey ErrorContentPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ErrorContent", typeof(object), typeof(global::Infragistics.Controls.Primitives.ValidationDecorator), null, null);

		// Token: 0x0400026E RID: 622
		public static readonly global::System.Windows.DependencyProperty ErrorContentProperty = global::Infragistics.Controls.Primitives.ValidationDecorator.ErrorContentPropertyKey.DependencyProperty;

		// Token: 0x0400026F RID: 623
		public static readonly global::System.Windows.DependencyProperty ErrorForegroundProperty = global::Infragistics.DependencyPropertyUtilities.Register("ErrorForeground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Primitives.ValidationDecorator), null, null);

		// Token: 0x04000270 RID: 624
		private static readonly global::System.Windows.DependencyPropertyKey HasErrorPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("HasError", typeof(bool), typeof(global::Infragistics.Controls.Primitives.ValidationDecorator), global::Infragistics.KnownBoxes.FalseBox, null);

		// Token: 0x04000271 RID: 625
		public static readonly global::System.Windows.DependencyProperty HasErrorProperty = global::Infragistics.Controls.Primitives.ValidationDecorator.HasErrorPropertyKey.DependencyProperty;

		// Token: 0x04000272 RID: 626
		public static readonly global::System.Windows.DependencyProperty IsToolTipOpenProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsToolTipOpen", typeof(bool), typeof(global::Infragistics.Controls.Primitives.ValidationDecorator), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.ValidationDecorator.OnIsToolTipOpenChanged)));
	}
}
