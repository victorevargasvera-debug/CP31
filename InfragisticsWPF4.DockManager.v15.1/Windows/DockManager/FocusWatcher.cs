using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Collections;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200000C RID: 12
	internal class FocusWatcher : global::System.IDisposable
	{
		// Token: 0x0600007D RID: 125 RVA: 0x0000453C File Offset: 0x0000273C
		static FocusWatcher()
		{
			global::System.Windows.Input.KeyboardFocusChangedEventHandler handler = new global::System.Windows.Input.KeyboardFocusChangedEventHandler(global::Infragistics.Windows.DockManager.FocusWatcher.OnGlobalGotFocus);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.UIElement), global::System.Windows.Input.Keyboard.GotKeyboardFocusEvent, handler, true);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.ContentElement), global::System.Windows.Input.Keyboard.GotKeyboardFocusEvent, handler, true);
			global::System.Type type = global::System.Type.GetType("System.Windows.UIElement3D, " + typeof(global::System.Windows.UIElement).Assembly.FullName, false);
			if (type != null)
			{
				global::System.Windows.EventManager.RegisterClassHandler(type, global::System.Windows.Input.Keyboard.GotKeyboardFocusEvent, handler, true);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000045D1 File Offset: 0x000027D1
		internal FocusWatcher()
		{
			this.HookElementImpl(global::System.Windows.Input.Keyboard.FocusedElement);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000045E4 File Offset: 0x000027E4
		public global::System.Windows.IInputElement FocusedElement
		{
			get
			{
				return this._focusedElement;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000045EC File Offset: 0x000027EC
		private void CheckFocusedElement()
		{
			global::Infragistics.Windows.DockManager.FocusWatcher.UnregisterGlobalGotFocus(this);
			this.HookElementImpl(global::System.Windows.Input.Keyboard.FocusedElement);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004600 File Offset: 0x00002800
		private void HookElementImpl(global::System.Windows.IInputElement element)
		{
			this.UnhookElementImpl();
			if (this._isDisposed)
			{
				return;
			}
			if (element != null)
			{
				global::Infragistics.Windows.DockManager.FocusWatcher.UnregisterGlobalGotFocus(this);
				this._focusedElement = element;
				this._focusedElement.LostKeyboardFocus += this.OnFocusedElementLostFocus;
				this.HookElement(element);
				return;
			}
			global::Infragistics.Windows.DockManager.FocusWatcher.RegisterGlobalGotFocus(this);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004651 File Offset: 0x00002851
		protected virtual void HookElement(global::System.Windows.IInputElement element)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004653 File Offset: 0x00002853
		protected virtual void OnFocusElementChanged(global::System.Windows.IInputElement oldElement, global::System.Windows.IInputElement newElement)
		{
			if (this.FocusedElementChanged != null)
			{
				this.FocusedElementChanged(this, new global::System.Windows.RoutedPropertyChangedEventArgs<global::System.Windows.IInputElement>(oldElement, newElement));
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004670 File Offset: 0x00002870
		private void OnFocusedElementLostFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::System.Windows.IInputElement focusedElement = this._focusedElement;
			this.HookElementImpl(e.NewFocus);
			this.OnFocusElementChanged(focusedElement, e.NewFocus);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000469D File Offset: 0x0000289D
		private static void OnGlobalGotFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (e.OriginalSource == sender && e.OldFocus == null && e.NewFocus != null)
			{
				global::Infragistics.Windows.DockManager.FocusWatcher.ProcessGlobalGotFocus(e.NewFocus);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000046C4 File Offset: 0x000028C4
		private static void ProcessGlobalGotFocus(global::System.Windows.IInputElement newFocus)
		{
			lock (global::Infragistics.Windows.DockManager.FocusWatcher.GlobalLock)
			{
				int count = global::Infragistics.Windows.DockManager.FocusWatcher._gotFocusList.Count;
				if (count > 0)
				{
					global::Infragistics.Windows.DockManager.FocusWatcher[] array = new global::Infragistics.Windows.DockManager.FocusWatcher[count];
					global::Infragistics.Windows.DockManager.FocusWatcher._gotFocusList.CopyTo(array, 0);
					global::Infragistics.Windows.DockManager.FocusWatcher._gotFocusList.Clear();
					foreach (global::Infragistics.Windows.DockManager.FocusWatcher focusWatcher in array)
					{
						if (focusWatcher != null && !focusWatcher._isDisposed)
						{
							focusWatcher.HookElement(newFocus);
						}
					}
				}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000475C File Offset: 0x0000295C
		private static void RegisterGlobalGotFocus(global::Infragistics.Windows.DockManager.FocusWatcher watcher)
		{
			lock (global::Infragistics.Windows.DockManager.FocusWatcher.GlobalLock)
			{
				global::Infragistics.Windows.DockManager.FocusWatcher._gotFocusList.Add(watcher);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000047A4 File Offset: 0x000029A4
		private void UnhookElementImpl()
		{
			if (this._focusedElement != null)
			{
				global::System.Windows.IInputElement focusedElement = this._focusedElement;
				this._focusedElement = null;
				focusedElement.LostKeyboardFocus -= this.OnFocusedElementLostFocus;
				this.UnhookElement(focusedElement);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000047E0 File Offset: 0x000029E0
		protected virtual void UnhookElement(global::System.Windows.IInputElement element)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000047E4 File Offset: 0x000029E4
		private static void UnregisterGlobalGotFocus(global::Infragistics.Windows.DockManager.FocusWatcher watcher)
		{
			lock (global::Infragistics.Windows.DockManager.FocusWatcher.GlobalLock)
			{
				global::Infragistics.Windows.DockManager.FocusWatcher._gotFocusList.Remove(watcher);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600008B RID: 139 RVA: 0x0000482C File Offset: 0x00002A2C
		// (remove) Token: 0x0600008C RID: 140 RVA: 0x00004864 File Offset: 0x00002A64
		public event global::System.Windows.RoutedPropertyChangedEventHandler<global::System.Windows.IInputElement> FocusedElementChanged;

		// Token: 0x0600008D RID: 141 RVA: 0x0000489C File Offset: 0x00002A9C
		public void Dispose()
		{
			this._isDisposed = true;
			global::Infragistics.Windows.DockManager.FocusWatcher.UnregisterGlobalGotFocus(this);
			if (this._focusedElement != null)
			{
				global::System.Windows.IInputElement focusedElement = this._focusedElement;
				this.UnhookElementImpl();
				this.OnFocusElementChanged(focusedElement, null);
			}
		}

		// Token: 0x0400002E RID: 46
		private global::System.Windows.IInputElement _focusedElement;

		// Token: 0x0400002F RID: 47
		private static object GlobalLock = new object();

		// Token: 0x04000030 RID: 48
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DockManager.FocusWatcher> _gotFocusList = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DockManager.FocusWatcher>();

		// Token: 0x04000031 RID: 49
		private bool _isDisposed;
	}
}
