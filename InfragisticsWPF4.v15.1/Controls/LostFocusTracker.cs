using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls
{
	// Token: 0x02000072 RID: 114
	internal class LostFocusTracker
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x000123A8 File Offset: 0x000105A8
		internal LostFocusTracker(global::System.Windows.UIElement element, global::System.Action callback)
		{
			this._element = element;
			this._callback = callback;
			this.VerfiyIsFocusWithin();
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x000123C4 File Offset: 0x000105C4
		internal global::System.Windows.DependencyObject ElementWithFocus
		{
			get
			{
				return this._elementWithFocus as global::System.Windows.DependencyObject;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x000123D1 File Offset: 0x000105D1
		internal bool IsActive
		{
			get
			{
				return null != this._elementWithFocus;
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000123E0 File Offset: 0x000105E0
		internal void Deactivate(bool forceLostFocusBindingUpdates)
		{
			if (this._elementWithFocus != null)
			{
				if (forceLostFocusBindingUpdates)
				{
					global::Infragistics.Controls.PresentationUtilities.ForceLostFocusBindingUpdate(this._element, this._elementWithFocus as global::System.Windows.DependencyObject);
				}
				this._elementWithFocus.LostKeyboardFocus -= this.OnElementWithFocus_LostFocus;
				this._elementWithFocus = null;
			}
			this._element = null;
			this._callback = null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0001243A File Offset: 0x0001063A
		private void OnElementWithFocus_LostFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (this._elementWithFocus != null)
			{
				this._elementWithFocus.LostKeyboardFocus -= this.OnElementWithFocus_LostFocus;
				this.VerfiyIsFocusWithin();
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00012464 File Offset: 0x00010664
		private void VerfiyIsFocusWithin()
		{
			global::System.Windows.DependencyObject elementWithKeyboardFocus = global::Infragistics.Controls.PresentationUtilities.GetElementWithKeyboardFocus();
			bool flag = elementWithKeyboardFocus != null && global::Infragistics.Controls.PresentationUtilities.IsAncestorOf(this._element, elementWithKeyboardFocus);
			if (flag)
			{
				this._elementWithFocus = (elementWithKeyboardFocus as global::System.Windows.IInputElement);
				if (this._elementWithFocus != null)
				{
					this._elementWithFocus.LostKeyboardFocus += this.OnElementWithFocus_LostFocus;
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (this._callback != null)
				{
					global::System.Action callback = this._callback;
					this._callback = null;
					callback();
				}
				this._element = null;
			}
		}

		// Token: 0x040001A9 RID: 425
		private global::System.Action _callback;

		// Token: 0x040001AA RID: 426
		private global::System.Windows.UIElement _element;

		// Token: 0x040001AB RID: 427
		private global::System.Windows.IInputElement _elementWithFocus;
	}
}
