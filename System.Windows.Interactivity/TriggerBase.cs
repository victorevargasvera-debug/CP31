using System;
using System.Globalization;
using System.Windows.Markup;
using System.Windows.Media.Animation;

namespace System.Windows.Interactivity
{
	// Token: 0x0200000C RID: 12
	[global::System.Windows.Markup.ContentProperty("Actions")]
	public abstract class TriggerBase : global::System.Windows.Media.Animation.Animatable, global::System.Windows.Interactivity.IAttachedObject
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000029DC File Offset: 0x00000BDC
		internal TriggerBase(global::System.Type associatedObjectTypeConstraint)
		{
			this.associatedObjectTypeConstraint = associatedObjectTypeConstraint;
			global::System.Windows.Interactivity.TriggerActionCollection value = new global::System.Windows.Interactivity.TriggerActionCollection();
			base.SetValue(global::System.Windows.Interactivity.TriggerBase.ActionsPropertyKey, value);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002A08 File Offset: 0x00000C08
		protected global::System.Windows.DependencyObject AssociatedObject
		{
			get
			{
				base.ReadPreamble();
				return this.associatedObject;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002A16 File Offset: 0x00000C16
		protected virtual global::System.Type AssociatedObjectTypeConstraint
		{
			get
			{
				base.ReadPreamble();
				return this.associatedObjectTypeConstraint;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002A24 File Offset: 0x00000C24
		public global::System.Windows.Interactivity.TriggerActionCollection Actions
		{
			get
			{
				return (global::System.Windows.Interactivity.TriggerActionCollection)base.GetValue(global::System.Windows.Interactivity.TriggerBase.ActionsProperty);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000034 RID: 52 RVA: 0x00002A38 File Offset: 0x00000C38
		// (remove) Token: 0x06000035 RID: 53 RVA: 0x00002A70 File Offset: 0x00000C70
		public event global::System.EventHandler<global::System.Windows.Interactivity.PreviewInvokeEventArgs> PreviewInvoke;

		// Token: 0x06000036 RID: 54 RVA: 0x00002AA8 File Offset: 0x00000CA8
		protected void InvokeActions(object parameter)
		{
			if (this.PreviewInvoke != null)
			{
				global::System.Windows.Interactivity.PreviewInvokeEventArgs previewInvokeEventArgs = new global::System.Windows.Interactivity.PreviewInvokeEventArgs();
				this.PreviewInvoke(this, previewInvokeEventArgs);
				if (previewInvokeEventArgs.Cancelling)
				{
					return;
				}
			}
			foreach (global::System.Windows.Interactivity.TriggerAction triggerAction in this.Actions)
			{
				triggerAction.CallInvoke(parameter);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002B20 File Offset: 0x00000D20
		protected virtual void OnAttached()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002B22 File Offset: 0x00000D22
		protected virtual void OnDetaching()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002B24 File Offset: 0x00000D24
		protected override global::System.Windows.Freezable CreateInstanceCore()
		{
			global::System.Type type = base.GetType();
			return (global::System.Windows.Freezable)global::System.Activator.CreateInstance(type);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002B43 File Offset: 0x00000D43
		global::System.Windows.DependencyObject global::System.Windows.Interactivity.IAttachedObject.AssociatedObject
		{
			get
			{
				return this.AssociatedObject;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002B4C File Offset: 0x00000D4C
		public void Attach(global::System.Windows.DependencyObject dependencyObject)
		{
			if (dependencyObject != this.AssociatedObject)
			{
				if (this.AssociatedObject != null)
				{
					throw new global::System.InvalidOperationException(global::ExceptionStringTable.CannotHostTriggerMultipleTimesExceptionMessage);
				}
				if (dependencyObject != null && !this.AssociatedObjectTypeConstraint.IsAssignableFrom(dependencyObject.GetType()))
				{
					throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.TypeConstraintViolatedExceptionMessage, new object[]
					{
						base.GetType().Name,
						dependencyObject.GetType().Name,
						this.AssociatedObjectTypeConstraint.Name
					}));
				}
				base.WritePreamble();
				this.associatedObject = dependencyObject;
				base.WritePostscript();
				this.Actions.Attach(dependencyObject);
				this.OnAttached();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002BFA File Offset: 0x00000DFA
		public void Detach()
		{
			this.OnDetaching();
			base.WritePreamble();
			this.associatedObject = null;
			base.WritePostscript();
			this.Actions.Detach();
		}

		// Token: 0x04000013 RID: 19
		private global::System.Windows.DependencyObject associatedObject;

		// Token: 0x04000014 RID: 20
		private global::System.Type associatedObjectTypeConstraint;

		// Token: 0x04000015 RID: 21
		private static readonly global::System.Windows.DependencyPropertyKey ActionsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Actions", typeof(global::System.Windows.Interactivity.TriggerActionCollection), typeof(global::System.Windows.Interactivity.TriggerBase), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000016 RID: 22
		public static readonly global::System.Windows.DependencyProperty ActionsProperty = global::System.Windows.Interactivity.TriggerBase.ActionsPropertyKey.DependencyProperty;
	}
}
