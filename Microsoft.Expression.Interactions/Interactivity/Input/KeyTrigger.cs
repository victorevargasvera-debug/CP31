using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace Microsoft.Expression.Interactivity.Input
{
	// Token: 0x02000020 RID: 32
	public class KeyTrigger : global::System.Windows.Interactivity.EventTriggerBase<global::System.Windows.UIElement>
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000077AC File Offset: 0x000059AC
		// (set) Token: 0x06000127 RID: 295 RVA: 0x000077BE File Offset: 0x000059BE
		public global::System.Windows.Input.Key Key
		{
			get
			{
				return (global::System.Windows.Input.Key)base.GetValue(global::Microsoft.Expression.Interactivity.Input.KeyTrigger.KeyProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Input.KeyTrigger.KeyProperty, value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000077D1 File Offset: 0x000059D1
		// (set) Token: 0x06000129 RID: 297 RVA: 0x000077E3 File Offset: 0x000059E3
		public global::System.Windows.Input.ModifierKeys Modifiers
		{
			get
			{
				return (global::System.Windows.Input.ModifierKeys)base.GetValue(global::Microsoft.Expression.Interactivity.Input.KeyTrigger.ModifiersProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Input.KeyTrigger.ModifiersProperty, value);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000077F6 File Offset: 0x000059F6
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00007808 File Offset: 0x00005A08
		public bool ActiveOnFocus
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Expression.Interactivity.Input.KeyTrigger.ActiveOnFocusProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Input.KeyTrigger.ActiveOnFocusProperty, value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000781B File Offset: 0x00005A1B
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0000782D File Offset: 0x00005A2D
		public global::Microsoft.Expression.Interactivity.Input.KeyTriggerFiredOn FiredOn
		{
			get
			{
				return (global::Microsoft.Expression.Interactivity.Input.KeyTriggerFiredOn)base.GetValue(global::Microsoft.Expression.Interactivity.Input.KeyTrigger.FiredOnProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Input.KeyTrigger.FiredOnProperty, value);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00007840 File Offset: 0x00005A40
		protected override string GetEventName()
		{
			return "Loaded";
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00007847 File Offset: 0x00005A47
		private void OnKeyPress(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == this.Key && global::System.Windows.Input.Keyboard.Modifiers == global::Microsoft.Expression.Interactivity.Input.KeyTrigger.GetActualModifiers(e.Key, this.Modifiers))
			{
				base.InvokeActions(e);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00007876 File Offset: 0x00005A76
		private static global::System.Windows.Input.ModifierKeys GetActualModifiers(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifiers)
		{
			if (key == global::System.Windows.Input.Key.LeftCtrl || key == global::System.Windows.Input.Key.RightCtrl)
			{
				modifiers |= global::System.Windows.Input.ModifierKeys.Control;
			}
			else if (key == global::System.Windows.Input.Key.LeftAlt || key == global::System.Windows.Input.Key.RightAlt || key == global::System.Windows.Input.Key.System)
			{
				modifiers |= global::System.Windows.Input.ModifierKeys.Alt;
			}
			else if (key == global::System.Windows.Input.Key.LeftShift || key == global::System.Windows.Input.Key.RightShift)
			{
				modifiers |= global::System.Windows.Input.ModifierKeys.Shift;
			}
			return modifiers;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000078B4 File Offset: 0x00005AB4
		protected override void OnEvent(global::System.EventArgs eventArgs)
		{
			if (this.ActiveOnFocus)
			{
				this.targetElement = base.Source;
			}
			else
			{
				this.targetElement = global::Microsoft.Expression.Interactivity.Input.KeyTrigger.GetRoot(base.Source);
			}
			if (this.FiredOn == global::Microsoft.Expression.Interactivity.Input.KeyTriggerFiredOn.KeyDown)
			{
				this.targetElement.KeyDown += this.OnKeyPress;
				return;
			}
			this.targetElement.KeyUp += this.OnKeyPress;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00007920 File Offset: 0x00005B20
		protected override void OnDetaching()
		{
			if (this.targetElement != null)
			{
				if (this.FiredOn == global::Microsoft.Expression.Interactivity.Input.KeyTriggerFiredOn.KeyDown)
				{
					this.targetElement.KeyDown -= this.OnKeyPress;
				}
				else
				{
					this.targetElement.KeyUp -= this.OnKeyPress;
				}
			}
			base.OnDetaching();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00007974 File Offset: 0x00005B74
		private static global::System.Windows.UIElement GetRoot(global::System.Windows.DependencyObject current)
		{
			global::System.Windows.UIElement result = null;
			while (current != null)
			{
				result = (current as global::System.Windows.UIElement);
				current = global::System.Windows.Media.VisualTreeHelper.GetParent(current);
			}
			return result;
		}

		// Token: 0x04000065 RID: 101
		public static readonly global::System.Windows.DependencyProperty KeyProperty = global::System.Windows.DependencyProperty.Register("Key", typeof(global::System.Windows.Input.Key), typeof(global::Microsoft.Expression.Interactivity.Input.KeyTrigger));

		// Token: 0x04000066 RID: 102
		public static readonly global::System.Windows.DependencyProperty ModifiersProperty = global::System.Windows.DependencyProperty.Register("Modifiers", typeof(global::System.Windows.Input.ModifierKeys), typeof(global::Microsoft.Expression.Interactivity.Input.KeyTrigger));

		// Token: 0x04000067 RID: 103
		public static readonly global::System.Windows.DependencyProperty ActiveOnFocusProperty = global::System.Windows.DependencyProperty.Register("ActiveOnFocus", typeof(bool), typeof(global::Microsoft.Expression.Interactivity.Input.KeyTrigger));

		// Token: 0x04000068 RID: 104
		public static readonly global::System.Windows.DependencyProperty FiredOnProperty = global::System.Windows.DependencyProperty.Register("FiredOn", typeof(global::Microsoft.Expression.Interactivity.Input.KeyTriggerFiredOn), typeof(global::Microsoft.Expression.Interactivity.Input.KeyTrigger));

		// Token: 0x04000069 RID: 105
		private global::System.Windows.UIElement targetElement;
	}
}
