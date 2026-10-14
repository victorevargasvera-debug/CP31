using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000003 RID: 3
	public abstract class VisualStateBehavior
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000212E File Offset: 0x0000032E
		public static global::Microsoft.Windows.Controls.VisualStateBehavior GetVisualStateBehavior(global::System.Windows.DependencyObject obj)
		{
			return (global::Microsoft.Windows.Controls.VisualStateBehavior)obj.GetValue(global::Microsoft.Windows.Controls.VisualStateBehavior.VisualStateBehaviorProperty);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002140 File Offset: 0x00000340
		public static void SetVisualStateBehavior(global::System.Windows.DependencyObject obj, global::Microsoft.Windows.Controls.VisualStateBehavior value)
		{
			obj.SetValue(global::Microsoft.Windows.Controls.VisualStateBehavior.VisualStateBehaviorProperty, value);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002150 File Offset: 0x00000350
		private static void OnVisualStateBehaviorChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Control control = sender as global::System.Windows.Controls.Control;
			if (control != null)
			{
				global::Microsoft.Windows.Controls.VisualStateBehavior visualStateBehavior = (global::Microsoft.Windows.Controls.VisualStateBehavior)e.NewValue;
				if (visualStateBehavior != null)
				{
					visualStateBehavior.Attach(control);
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002180 File Offset: 0x00000380
		private void Attach(global::System.Windows.Controls.Control control)
		{
			if (global::Microsoft.Windows.Controls.VisualStateBehavior.GetIsVisualStateBehaviorAttached(control))
			{
				throw new global::System.InvalidOperationException("VisualStateBehavior is already attached.");
			}
			global::Microsoft.Windows.Controls.VisualStateBehavior.SetIsVisualStateBehaviorAttached(control, true);
			this.OnAttach(control);
			control.Unloaded += this.DetachHandler;
			control.Loaded -= this.AttachHandler;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021D4 File Offset: 0x000003D4
		private void Detach(global::System.Windows.Controls.Control control)
		{
			if (!global::Microsoft.Windows.Controls.VisualStateBehavior.GetIsVisualStateBehaviorAttached(control))
			{
				throw new global::System.InvalidOperationException("VisualStateBehavior is not attached.");
			}
			global::Microsoft.Windows.Controls.VisualStateBehavior.SetIsVisualStateBehaviorAttached(control, false);
			this.OnDetach(control);
			control.Loaded += this.AttachHandler;
			control.Unloaded -= this.DetachHandler;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002226 File Offset: 0x00000426
		private static bool GetIsVisualStateBehaviorAttached(global::System.Windows.DependencyObject obj)
		{
			return (bool)obj.GetValue(global::Microsoft.Windows.Controls.VisualStateBehavior.IsVisualStateBehaviorAttachedProperty);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002238 File Offset: 0x00000438
		private static void SetIsVisualStateBehaviorAttached(global::System.Windows.DependencyObject obj, bool value)
		{
			obj.SetValue(global::Microsoft.Windows.Controls.VisualStateBehavior.IsVisualStateBehaviorAttachedProperty, value);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000224B File Offset: 0x0000044B
		public static void RegisterBehavior(global::Microsoft.Windows.Controls.VisualStateBehavior behavior)
		{
			global::Microsoft.Windows.Controls.VisualStateBehaviorFactory.RegisterControlBehavior(behavior);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15
		protected internal abstract global::System.Type TargetType { get; }

		// Token: 0x06000010 RID: 16
		protected abstract void OnAttach(global::System.Windows.Controls.Control control);

		// Token: 0x06000011 RID: 17
		protected abstract void OnDetach(global::System.Windows.Controls.Control control);

		// Token: 0x06000012 RID: 18
		protected abstract void UpdateStateHandler(object o, global::System.EventArgs e);

		// Token: 0x06000013 RID: 19 RVA: 0x00002254 File Offset: 0x00000454
		private void DetachHandler(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Controls.Control control = sender as global::System.Windows.Controls.Control;
			if (control == null)
			{
				throw new global::System.InvalidOperationException("This Handler should only be on a control.");
			}
			this.Detach(control);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002280 File Offset: 0x00000480
		private void AttachHandler(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Controls.Control control = sender as global::System.Windows.Controls.Control;
			if (control == null)
			{
				throw new global::System.InvalidOperationException("This Handler should only be on a control.");
			}
			this.Attach(control);
		}

		// Token: 0x06000015 RID: 21
		protected abstract void UpdateState(global::System.Windows.Controls.Control control, bool useTransitions);

		// Token: 0x06000016 RID: 22 RVA: 0x000022AC File Offset: 0x000004AC
		protected static bool AddValueChanged(global::System.Windows.DependencyProperty dp, global::System.Type targetType, object instance, global::System.EventHandler handler)
		{
			if (dp == null)
			{
				throw new global::System.ArgumentNullException("dp");
			}
			if (targetType == null)
			{
				throw new global::System.ArgumentNullException("targetType");
			}
			if (instance == null)
			{
				throw new global::System.ArgumentNullException("instance");
			}
			if (handler == null)
			{
				throw new global::System.ArgumentNullException("handler");
			}
			global::System.ComponentModel.DependencyPropertyDescriptor dependencyPropertyDescriptor = global::System.ComponentModel.DependencyPropertyDescriptor.FromProperty(dp, targetType);
			if (dependencyPropertyDescriptor != null)
			{
				dependencyPropertyDescriptor.AddValueChanged(instance, handler);
				return true;
			}
			return false;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002308 File Offset: 0x00000508
		protected static bool RemoveValueChanged(global::System.Windows.DependencyProperty dp, global::System.Type targetType, object instance, global::System.EventHandler handler)
		{
			if (dp == null)
			{
				throw new global::System.ArgumentNullException("dp");
			}
			if (targetType == null)
			{
				throw new global::System.ArgumentNullException("targetType");
			}
			if (instance == null)
			{
				throw new global::System.ArgumentNullException("instance");
			}
			if (handler == null)
			{
				throw new global::System.ArgumentNullException("handler");
			}
			global::System.ComponentModel.DependencyPropertyDescriptor dependencyPropertyDescriptor = global::System.ComponentModel.DependencyPropertyDescriptor.FromProperty(dp, targetType);
			if (dependencyPropertyDescriptor != null)
			{
				dependencyPropertyDescriptor.RemoveValueChanged(instance, handler);
				return true;
			}
			return false;
		}

		// Token: 0x04000003 RID: 3
		public static readonly global::System.Windows.DependencyProperty VisualStateBehaviorProperty = global::System.Windows.DependencyProperty.RegisterAttached("VisualStateBehavior", typeof(global::Microsoft.Windows.Controls.VisualStateBehavior), typeof(global::Microsoft.Windows.Controls.VisualStateBehavior), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.VisualStateBehavior.OnVisualStateBehaviorChanged)));

		// Token: 0x04000004 RID: 4
		private static readonly global::System.Windows.DependencyProperty IsVisualStateBehaviorAttachedProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsVisualStateBehaviorAttached", typeof(bool), typeof(global::Microsoft.Windows.Controls.VisualStateBehavior), new global::System.Windows.FrameworkPropertyMetadata(false));
	}
}
