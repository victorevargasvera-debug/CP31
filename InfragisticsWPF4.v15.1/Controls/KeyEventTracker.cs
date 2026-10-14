using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls
{
	// Token: 0x0200006D RID: 109
	internal class KeyEventTracker
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x000115E7 File Offset: 0x0000F7E7
		internal KeyEventTracker()
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x000115EF File Offset: 0x0000F7EF
		internal global::System.Windows.DependencyObject FocusedElement
		{
			get
			{
				return this._focusedElement;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000115F7 File Offset: 0x0000F7F7
		internal void Activate()
		{
			if (this._focusedElement != null)
			{
				return;
			}
			this.Hook(global::Infragistics.Controls.PresentationUtilities.GetElementWithKeyboardFocus());
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0001160D File Offset: 0x0000F80D
		internal void Deactivate()
		{
			if (this._focusedElement == null)
			{
				return;
			}
			this.Unhook(this._focusedElement, true);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00011628 File Offset: 0x0000F828
		private void Hook(global::System.Windows.DependencyObject element)
		{
			if (element == this._focusedElement)
			{
				return;
			}
			if (this._focusedElement != null)
			{
				this.Unhook(this._focusedElement, false);
			}
			global::System.Windows.IInputElement inputElement = element as global::System.Windows.IInputElement;
			if (inputElement != null)
			{
				this._focusedElement = element;
				inputElement.LostKeyboardFocus += this.OnElementLostKeyboardFocus;
				inputElement.KeyDown += this.OnElementKey;
				inputElement.KeyUp += this.OnElementKey;
				inputElement.PreviewKeyDown += this.OnElementKey;
				inputElement.PreviewKeyUp += this.OnElementKey;
			}
			this.RaiseFocusedElementChange();
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000116C8 File Offset: 0x0000F8C8
		private void OnElementKey(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.KeyEventHandler keyEvent = this.KeyEvent;
			if (keyEvent != null)
			{
				keyEvent(this, e);
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000116E7 File Offset: 0x0000F8E7
		private void OnElementLostKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (e.OriginalSource == this._focusedElement && e.OldFocus == this._focusedElement)
			{
				this.Hook(e.NewFocus as global::System.Windows.DependencyObject);
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00011718 File Offset: 0x0000F918
		private void RaiseFocusedElementChange()
		{
			global::System.EventHandler focusedElementChanged = this.FocusedElementChanged;
			if (focusedElementChanged != null)
			{
				focusedElementChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001173C File Offset: 0x0000F93C
		private void Unhook(global::System.Windows.DependencyObject element, bool raiseEvents)
		{
			if (element != this._focusedElement || element == null)
			{
				return;
			}
			this._focusedElement = null;
			global::System.Windows.IInputElement inputElement = element as global::System.Windows.IInputElement;
			if (inputElement != null)
			{
				inputElement.LostKeyboardFocus -= this.OnElementLostKeyboardFocus;
				inputElement.KeyDown -= this.OnElementKey;
				inputElement.KeyUp += this.OnElementKey;
				inputElement.PreviewKeyDown -= this.OnElementKey;
				inputElement.PreviewKeyUp -= this.OnElementKey;
			}
			if (raiseEvents)
			{
				this.RaiseFocusedElementChange();
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000416 RID: 1046 RVA: 0x000117CC File Offset: 0x0000F9CC
		// (remove) Token: 0x06000417 RID: 1047 RVA: 0x00011804 File Offset: 0x0000FA04
		internal event global::System.EventHandler FocusedElementChanged;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000418 RID: 1048 RVA: 0x0001183C File Offset: 0x0000FA3C
		// (remove) Token: 0x06000419 RID: 1049 RVA: 0x00011874 File Offset: 0x0000FA74
		internal event global::System.Windows.Input.KeyEventHandler KeyEvent;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.DependencyObject _focusedElement;
	}
}
