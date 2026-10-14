using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls
{
	// Token: 0x0200005C RID: 92
	internal class LostFocusTracker
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x000100E4 File Offset: 0x0000E2E4
		internal LostFocusTracker(global::System.Windows.UIElement element, global::System.Action callback)
		{
			this._element = element;
			this._callback = callback;
			this.VerfiyIsFocusWithin();
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00010100 File Offset: 0x0000E300
		internal global::System.Windows.DependencyObject ElementWithFocus
		{
			get
			{
				return this._elementWithFocus as global::System.Windows.DependencyObject;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0001010D File Offset: 0x0000E30D
		internal bool IsActive
		{
			get
			{
				return null != this._elementWithFocus;
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0001011C File Offset: 0x0000E31C
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

		// Token: 0x060003AB RID: 939 RVA: 0x00010176 File Offset: 0x0000E376
		private void OnElementWithFocus_LostFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (this._elementWithFocus != null)
			{
				this._elementWithFocus.LostKeyboardFocus -= this.OnElementWithFocus_LostFocus;
				this.VerfiyIsFocusWithin();
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000101A0 File Offset: 0x0000E3A0
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

		// Token: 0x0400013F RID: 319
		private global::System.Action _callback;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.UIElement _element;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.IInputElement _elementWithFocus;
	}
}
