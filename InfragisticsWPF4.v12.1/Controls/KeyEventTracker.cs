using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls
{
	// Token: 0x02000059 RID: 89
	internal class KeyEventTracker
	{
		// Token: 0x06000378 RID: 888 RVA: 0x0000F97F File Offset: 0x0000DB7F
		internal KeyEventTracker()
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000F987 File Offset: 0x0000DB87
		internal global::System.Windows.DependencyObject FocusedElement
		{
			get
			{
				return this._focusedElement;
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000F98F File Offset: 0x0000DB8F
		internal void Activate()
		{
			if (this._focusedElement != null)
			{
				return;
			}
			this.Hook(global::Infragistics.Controls.PresentationUtilities.GetElementWithKeyboardFocus());
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000F9A5 File Offset: 0x0000DBA5
		internal void Deactivate()
		{
			if (this._focusedElement == null)
			{
				return;
			}
			this.Unhook(this._focusedElement, true);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
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

		// Token: 0x0600037D RID: 893 RVA: 0x0000FA60 File Offset: 0x0000DC60
		private void OnElementKey(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.KeyEventHandler keyEvent = this.KeyEvent;
			if (keyEvent != null)
			{
				keyEvent(this, e);
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000FA7F File Offset: 0x0000DC7F
		private void OnElementLostKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (e.OriginalSource == this._focusedElement && e.OldFocus == this._focusedElement)
			{
				this.Hook(e.NewFocus as global::System.Windows.DependencyObject);
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		private void RaiseFocusedElementChange()
		{
			global::System.EventHandler focusedElementChanged = this.FocusedElementChanged;
			if (focusedElementChanged != null)
			{
				focusedElementChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
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
		// (add) Token: 0x06000381 RID: 897 RVA: 0x0000FB64 File Offset: 0x0000DD64
		// (remove) Token: 0x06000382 RID: 898 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		internal event global::System.EventHandler FocusedElementChanged;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000383 RID: 899 RVA: 0x0000FBD4 File Offset: 0x0000DDD4
		// (remove) Token: 0x06000384 RID: 900 RVA: 0x0000FC0C File Offset: 0x0000DE0C
		internal event global::System.Windows.Input.KeyEventHandler KeyEvent;

		// Token: 0x04000121 RID: 289
		private global::System.Windows.DependencyObject _focusedElement;
	}
}
