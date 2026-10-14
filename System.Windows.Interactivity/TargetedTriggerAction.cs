using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Windows.Interactivity
{
	// Token: 0x02000016 RID: 22
	public abstract class TargetedTriggerAction : global::System.Windows.Interactivity.TriggerAction
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00003CE6 File Offset: 0x00001EE6
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00003CF3 File Offset: 0x00001EF3
		public object TargetObject
		{
			get
			{
				return base.GetValue(global::System.Windows.Interactivity.TargetedTriggerAction.TargetObjectProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Interactivity.TargetedTriggerAction.TargetObjectProperty, value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00003D01 File Offset: 0x00001F01
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00003D13 File Offset: 0x00001F13
		public string TargetName
		{
			get
			{
				return (string)base.GetValue(global::System.Windows.Interactivity.TargetedTriggerAction.TargetNameProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Interactivity.TargetedTriggerAction.TargetNameProperty, value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003D24 File Offset: 0x00001F24
		protected object Target
		{
			get
			{
				object obj = base.AssociatedObject;
				if (this.TargetObject != null)
				{
					obj = this.TargetObject;
				}
				else if (this.IsTargetNameSet)
				{
					obj = this.TargetResolver.Object;
				}
				if (obj != null && !this.TargetTypeConstraint.IsAssignableFrom(obj.GetType()))
				{
					throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.RetargetedTypeConstraintViolatedExceptionMessage, new object[]
					{
						base.GetType().Name,
						obj.GetType(),
						this.TargetTypeConstraint,
						"Target"
					}));
				}
				return obj;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00003DBC File Offset: 0x00001FBC
		protected sealed override global::System.Type AssociatedObjectTypeConstraint
		{
			get
			{
				global::System.ComponentModel.AttributeCollection attributes = global::System.ComponentModel.TypeDescriptor.GetAttributes(base.GetType());
				global::System.Windows.Interactivity.TypeConstraintAttribute typeConstraintAttribute = attributes[typeof(global::System.Windows.Interactivity.TypeConstraintAttribute)] as global::System.Windows.Interactivity.TypeConstraintAttribute;
				if (typeConstraintAttribute != null)
				{
					return typeConstraintAttribute.Constraint;
				}
				return typeof(global::System.Windows.DependencyObject);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003DFF File Offset: 0x00001FFF
		protected global::System.Type TargetTypeConstraint
		{
			get
			{
				base.ReadPreamble();
				return this.targetTypeConstraint;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00003E0D File Offset: 0x0000200D
		private bool IsTargetNameSet
		{
			get
			{
				return !string.IsNullOrEmpty(this.TargetName) || base.ReadLocalValue(global::System.Windows.Interactivity.TargetedTriggerAction.TargetNameProperty) != global::System.Windows.DependencyProperty.UnsetValue;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00003E33 File Offset: 0x00002033
		private global::System.Windows.Interactivity.NameResolver TargetResolver
		{
			get
			{
				return this.targetResolver;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00003E3B File Offset: 0x0000203B
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00003E43 File Offset: 0x00002043
		private bool IsTargetChangedRegistered
		{
			get
			{
				return this.isTargetChangedRegistered;
			}
			set
			{
				this.isTargetChangedRegistered = value;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003E4C File Offset: 0x0000204C
		internal TargetedTriggerAction(global::System.Type targetTypeConstraint) : base(typeof(global::System.Windows.DependencyObject))
		{
			this.targetTypeConstraint = targetTypeConstraint;
			this.targetResolver = new global::System.Windows.Interactivity.NameResolver();
			this.RegisterTargetChanged();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003E76 File Offset: 0x00002076
		internal virtual void OnTargetChangedImpl(object oldTarget, object newTarget)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003E78 File Offset: 0x00002078
		protected override void OnAttached()
		{
			base.OnAttached();
			global::System.Windows.DependencyObject associatedObject = base.AssociatedObject;
			global::System.Windows.Interactivity.Behavior behavior = associatedObject as global::System.Windows.Interactivity.Behavior;
			this.RegisterTargetChanged();
			if (behavior != null)
			{
				associatedObject = ((global::System.Windows.Interactivity.IAttachedObject)behavior).AssociatedObject;
				behavior.AssociatedObjectChanged += this.OnBehaviorHostChanged;
			}
			this.TargetResolver.NameScopeReferenceElement = (associatedObject as global::System.Windows.FrameworkElement);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003ECC File Offset: 0x000020CC
		protected override void OnDetaching()
		{
			global::System.Windows.Interactivity.Behavior behavior = base.AssociatedObject as global::System.Windows.Interactivity.Behavior;
			base.OnDetaching();
			this.OnTargetChangedImpl(this.TargetResolver.Object, null);
			this.UnregisterTargetChanged();
			if (behavior != null)
			{
				behavior.AssociatedObjectChanged -= this.OnBehaviorHostChanged;
			}
			this.TargetResolver.NameScopeReferenceElement = null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00003F24 File Offset: 0x00002124
		private void OnBehaviorHostChanged(object sender, global::System.EventArgs e)
		{
			this.TargetResolver.NameScopeReferenceElement = (((global::System.Windows.Interactivity.IAttachedObject)sender).AssociatedObject as global::System.Windows.FrameworkElement);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003F41 File Offset: 0x00002141
		private void RegisterTargetChanged()
		{
			if (!this.IsTargetChangedRegistered)
			{
				this.TargetResolver.ResolvedElementChanged += this.OnTargetChanged;
				this.IsTargetChangedRegistered = true;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003F69 File Offset: 0x00002169
		private void UnregisterTargetChanged()
		{
			if (this.IsTargetChangedRegistered)
			{
				this.TargetResolver.ResolvedElementChanged -= this.OnTargetChanged;
				this.IsTargetChangedRegistered = false;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003F94 File Offset: 0x00002194
		private static void OnTargetObjectChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::System.Windows.Interactivity.TargetedTriggerAction targetedTriggerAction = (global::System.Windows.Interactivity.TargetedTriggerAction)obj;
			targetedTriggerAction.OnTargetChanged(obj, new global::System.Windows.Interactivity.NameResolvedEventArgs(args.OldValue, args.NewValue));
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003FC4 File Offset: 0x000021C4
		private static void OnTargetNameChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::System.Windows.Interactivity.TargetedTriggerAction targetedTriggerAction = (global::System.Windows.Interactivity.TargetedTriggerAction)obj;
			targetedTriggerAction.TargetResolver.Name = (string)args.NewValue;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003FEF File Offset: 0x000021EF
		private void OnTargetChanged(object sender, global::System.Windows.Interactivity.NameResolvedEventArgs e)
		{
			if (base.AssociatedObject != null)
			{
				this.OnTargetChangedImpl(e.OldObject, e.NewObject);
			}
		}

		// Token: 0x04000032 RID: 50
		private global::System.Type targetTypeConstraint;

		// Token: 0x04000033 RID: 51
		private bool isTargetChangedRegistered;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Interactivity.NameResolver targetResolver;

		// Token: 0x04000035 RID: 53
		public static readonly global::System.Windows.DependencyProperty TargetObjectProperty = global::System.Windows.DependencyProperty.Register("TargetObject", typeof(object), typeof(global::System.Windows.Interactivity.TargetedTriggerAction), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Interactivity.TargetedTriggerAction.OnTargetObjectChanged)));

		// Token: 0x04000036 RID: 54
		public static readonly global::System.Windows.DependencyProperty TargetNameProperty = global::System.Windows.DependencyProperty.Register("TargetName", typeof(string), typeof(global::System.Windows.Interactivity.TargetedTriggerAction), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Interactivity.TargetedTriggerAction.OnTargetNameChanged)));
	}
}
