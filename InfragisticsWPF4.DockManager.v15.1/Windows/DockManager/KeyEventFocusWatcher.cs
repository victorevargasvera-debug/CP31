using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000072 RID: 114
	internal class KeyEventFocusWatcher : global::Infragistics.Windows.DockManager.FocusWatcher
	{
		// Token: 0x060003E4 RID: 996 RVA: 0x0001514C File Offset: 0x0001334C
		internal KeyEventFocusWatcher()
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00015154 File Offset: 0x00013354
		protected override void HookElement(global::System.Windows.IInputElement element)
		{
			base.HookElement(element);
			global::System.Windows.Input.KeyEventHandler value = new global::System.Windows.Input.KeyEventHandler(this.OnElementKeyEvent);
			element.PreviewKeyDown += value;
			element.PreviewKeyUp += value;
			element.KeyDown += value;
			element.KeyUp += value;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00015194 File Offset: 0x00013394
		protected override void UnhookElement(global::System.Windows.IInputElement element)
		{
			base.UnhookElement(element);
			global::System.Windows.Input.KeyEventHandler value = new global::System.Windows.Input.KeyEventHandler(this.OnElementKeyEvent);
			element.PreviewKeyDown -= value;
			element.PreviewKeyUp -= value;
			element.KeyDown -= value;
			element.KeyUp -= value;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000151D1 File Offset: 0x000133D1
		private void OnElementKeyEvent(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (this.KeyEvent != null)
			{
				this.KeyEvent(this, e);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060003E8 RID: 1000 RVA: 0x000151E8 File Offset: 0x000133E8
		// (remove) Token: 0x060003E9 RID: 1001 RVA: 0x00015220 File Offset: 0x00013420
		public event global::System.Windows.Input.KeyEventHandler KeyEvent;
	}
}
