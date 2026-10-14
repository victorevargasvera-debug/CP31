using System;
using System.Globalization;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;

namespace System.Windows.Interactivity
{
	// Token: 0x02000011 RID: 17
	[global::System.Windows.Interactivity.DefaultTrigger(typeof(global::System.Windows.UIElement), typeof(global::System.Windows.Interactivity.EventTrigger), "MouseLeftButtonDown")]
	[global::System.Windows.Interactivity.DefaultTrigger(typeof(global::System.Windows.Controls.Primitives.ButtonBase), typeof(global::System.Windows.Interactivity.EventTrigger), "Click")]
	public abstract class TriggerAction : global::System.Windows.Media.Animation.Animatable, global::System.Windows.Interactivity.IAttachedObject
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003699 File Offset: 0x00001899
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000036AB File Offset: 0x000018AB
		public bool IsEnabled
		{
			get
			{
				return (bool)base.GetValue(global::System.Windows.Interactivity.TriggerAction.IsEnabledProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Interactivity.TriggerAction.IsEnabledProperty, value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000036BE File Offset: 0x000018BE
		protected global::System.Windows.DependencyObject AssociatedObject
		{
			get
			{
				base.ReadPreamble();
				return this.associatedObject;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000036CC File Offset: 0x000018CC
		protected virtual global::System.Type AssociatedObjectTypeConstraint
		{
			get
			{
				base.ReadPreamble();
				return this.associatedObjectTypeConstraint;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000036DA File Offset: 0x000018DA
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000036E8 File Offset: 0x000018E8
		internal bool IsHosted
		{
			get
			{
				base.ReadPreamble();
				return this.isHosted;
			}
			set
			{
				base.WritePreamble();
				this.isHosted = value;
				base.WritePostscript();
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000036FD File Offset: 0x000018FD
		internal TriggerAction(global::System.Type associatedObjectTypeConstraint)
		{
			this.associatedObjectTypeConstraint = associatedObjectTypeConstraint;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000370C File Offset: 0x0000190C
		internal void CallInvoke(object parameter)
		{
			if (this.IsEnabled)
			{
				this.Invoke(parameter);
			}
		}

		// Token: 0x0600007C RID: 124
		protected abstract void Invoke(object parameter);

		// Token: 0x0600007D RID: 125 RVA: 0x0000371D File Offset: 0x0000191D
		protected virtual void OnAttached()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000371F File Offset: 0x0000191F
		protected virtual void OnDetaching()
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003724 File Offset: 0x00001924
		protected override global::System.Windows.Freezable CreateInstanceCore()
		{
			global::System.Type type = base.GetType();
			return (global::System.Windows.Freezable)global::System.Activator.CreateInstance(type);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003743 File Offset: 0x00001943
		global::System.Windows.DependencyObject global::System.Windows.Interactivity.IAttachedObject.AssociatedObject
		{
			get
			{
				return this.AssociatedObject;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000374C File Offset: 0x0000194C
		public void Attach(global::System.Windows.DependencyObject dependencyObject)
		{
			if (dependencyObject != this.AssociatedObject)
			{
				if (this.AssociatedObject != null)
				{
					throw new global::System.InvalidOperationException(global::ExceptionStringTable.CannotHostTriggerActionMultipleTimesExceptionMessage);
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
				this.OnAttached();
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000037EE File Offset: 0x000019EE
		public void Detach()
		{
			this.OnDetaching();
			base.WritePreamble();
			this.associatedObject = null;
			base.WritePostscript();
		}

		// Token: 0x04000023 RID: 35
		private bool isHosted;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.DependencyObject associatedObject;

		// Token: 0x04000025 RID: 37
		private global::System.Type associatedObjectTypeConstraint;

		// Token: 0x04000026 RID: 38
		public static readonly global::System.Windows.DependencyProperty IsEnabledProperty = global::System.Windows.DependencyProperty.Register("IsEnabled", typeof(bool), typeof(global::System.Windows.Interactivity.TriggerAction), new global::System.Windows.FrameworkPropertyMetadata(true));
	}
}
