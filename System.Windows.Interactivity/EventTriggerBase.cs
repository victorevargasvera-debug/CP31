using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace System.Windows.Interactivity
{
	// Token: 0x0200000D RID: 13
	public abstract class EventTriggerBase : global::System.Windows.Interactivity.TriggerBase
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002C5C File Offset: 0x00000E5C
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002C9F File Offset: 0x00000E9F
		protected global::System.Type SourceTypeConstraint
		{
			get
			{
				return this.sourceTypeConstraint;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002CA7 File Offset: 0x00000EA7
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public object SourceObject
		{
			get
			{
				return base.GetValue(global::System.Windows.Interactivity.EventTriggerBase.SourceObjectProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Interactivity.EventTriggerBase.SourceObjectProperty, value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002CC2 File Offset: 0x00000EC2
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002CD4 File Offset: 0x00000ED4
		public string SourceName
		{
			get
			{
				return (string)base.GetValue(global::System.Windows.Interactivity.EventTriggerBase.SourceNameProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Interactivity.EventTriggerBase.SourceNameProperty, value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public object Source
		{
			get
			{
				object obj = base.AssociatedObject;
				if (this.SourceObject != null)
				{
					obj = this.SourceObject;
				}
				else if (this.IsSourceNameSet)
				{
					obj = this.SourceNameResolver.Object;
					if (obj != null && !this.SourceTypeConstraint.IsAssignableFrom(obj.GetType()))
					{
						throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.RetargetedTypeConstraintViolatedExceptionMessage, new object[]
						{
							base.GetType().Name,
							obj.GetType(),
							this.SourceTypeConstraint,
							"Source"
						}));
					}
				}
				return obj;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002D79 File Offset: 0x00000F79
		private global::System.Windows.Interactivity.NameResolver SourceNameResolver
		{
			get
			{
				return this.sourceNameResolver;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002D81 File Offset: 0x00000F81
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002D89 File Offset: 0x00000F89
		private bool IsSourceChangedRegistered
		{
			get
			{
				return this.isSourceChangedRegistered;
			}
			set
			{
				this.isSourceChangedRegistered = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002D92 File Offset: 0x00000F92
		private bool IsSourceNameSet
		{
			get
			{
				return !string.IsNullOrEmpty(this.SourceName) || base.ReadLocalValue(global::System.Windows.Interactivity.EventTriggerBase.SourceNameProperty) != global::System.Windows.DependencyProperty.UnsetValue;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002DB8 File Offset: 0x00000FB8
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002DC0 File Offset: 0x00000FC0
		private bool IsLoadedRegistered { get; set; }

		// Token: 0x0600004B RID: 75 RVA: 0x00002DC9 File Offset: 0x00000FC9
		internal EventTriggerBase(global::System.Type sourceTypeConstraint) : base(typeof(global::System.Windows.DependencyObject))
		{
			this.sourceTypeConstraint = sourceTypeConstraint;
			this.sourceNameResolver = new global::System.Windows.Interactivity.NameResolver();
			this.RegisterSourceChanged();
		}

		// Token: 0x0600004C RID: 76
		protected abstract string GetEventName();

		// Token: 0x0600004D RID: 77 RVA: 0x00002DF3 File Offset: 0x00000FF3
		protected virtual void OnEvent(global::System.EventArgs eventArgs)
		{
			base.InvokeActions(eventArgs);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002DFC File Offset: 0x00000FFC
		private void OnSourceChanged(object oldSource, object newSource)
		{
			if (base.AssociatedObject != null)
			{
				this.OnSourceChangedImpl(oldSource, newSource);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002E10 File Offset: 0x00001010
		internal virtual void OnSourceChangedImpl(object oldSource, object newSource)
		{
			if (string.IsNullOrEmpty(this.GetEventName()))
			{
				return;
			}
			if (string.Compare(this.GetEventName(), "Loaded", global::System.StringComparison.Ordinal) != 0)
			{
				if (oldSource != null && this.SourceTypeConstraint.IsAssignableFrom(oldSource.GetType()))
				{
					this.UnregisterEvent(oldSource, this.GetEventName());
				}
				if (newSource != null && this.SourceTypeConstraint.IsAssignableFrom(newSource.GetType()))
				{
					this.RegisterEvent(newSource, this.GetEventName());
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002E84 File Offset: 0x00001084
		protected override void OnAttached()
		{
			base.OnAttached();
			global::System.Windows.DependencyObject associatedObject = base.AssociatedObject;
			global::System.Windows.Interactivity.Behavior behavior = associatedObject as global::System.Windows.Interactivity.Behavior;
			global::System.Windows.FrameworkElement frameworkElement = associatedObject as global::System.Windows.FrameworkElement;
			this.RegisterSourceChanged();
			if (behavior != null)
			{
				associatedObject = ((global::System.Windows.Interactivity.IAttachedObject)behavior).AssociatedObject;
				behavior.AssociatedObjectChanged += this.OnBehaviorHostChanged;
			}
			else
			{
				if (this.SourceObject == null)
				{
					if (frameworkElement != null)
					{
						goto IL_5C;
					}
				}
				try
				{
					this.OnSourceChanged(null, this.Source);
					goto IL_68;
				}
				catch (global::System.InvalidOperationException)
				{
					goto IL_68;
				}
				IL_5C:
				this.SourceNameResolver.NameScopeReferenceElement = frameworkElement;
			}
			IL_68:
			bool flag = string.Compare(this.GetEventName(), "Loaded", global::System.StringComparison.Ordinal) == 0;
			if (flag && frameworkElement != null && !global::System.Windows.Interactivity.Interaction.IsElementLoaded(frameworkElement))
			{
				this.RegisterLoaded(frameworkElement);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002F34 File Offset: 0x00001134
		protected override void OnDetaching()
		{
			base.OnDetaching();
			global::System.Windows.Interactivity.Behavior behavior = base.AssociatedObject as global::System.Windows.Interactivity.Behavior;
			global::System.Windows.FrameworkElement frameworkElement = base.AssociatedObject as global::System.Windows.FrameworkElement;
			try
			{
				this.OnSourceChanged(this.Source, null);
			}
			catch (global::System.InvalidOperationException)
			{
			}
			this.UnregisterSourceChanged();
			if (behavior != null)
			{
				behavior.AssociatedObjectChanged -= this.OnBehaviorHostChanged;
			}
			this.SourceNameResolver.NameScopeReferenceElement = null;
			bool flag = string.Compare(this.GetEventName(), "Loaded", global::System.StringComparison.Ordinal) == 0;
			if (flag && frameworkElement != null)
			{
				this.UnregisterLoaded(frameworkElement);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002FCC File Offset: 0x000011CC
		private void OnBehaviorHostChanged(object sender, global::System.EventArgs e)
		{
			this.SourceNameResolver.NameScopeReferenceElement = (((global::System.Windows.Interactivity.IAttachedObject)sender).AssociatedObject as global::System.Windows.FrameworkElement);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002FEC File Offset: 0x000011EC
		private static void OnSourceObjectChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::System.Windows.Interactivity.EventTriggerBase eventTriggerBase = (global::System.Windows.Interactivity.EventTriggerBase)obj;
			object @object = eventTriggerBase.SourceNameResolver.Object;
			if (args.NewValue == null)
			{
				eventTriggerBase.OnSourceChanged(args.OldValue, @object);
				return;
			}
			if (args.OldValue == null && @object != null)
			{
				eventTriggerBase.UnregisterEvent(@object, eventTriggerBase.GetEventName());
			}
			eventTriggerBase.OnSourceChanged(args.OldValue, args.NewValue);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003054 File Offset: 0x00001254
		private static void OnSourceNameChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::System.Windows.Interactivity.EventTriggerBase eventTriggerBase = (global::System.Windows.Interactivity.EventTriggerBase)obj;
			eventTriggerBase.SourceNameResolver.Name = (string)args.NewValue;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000307F File Offset: 0x0000127F
		private void RegisterSourceChanged()
		{
			if (!this.IsSourceChangedRegistered)
			{
				this.SourceNameResolver.ResolvedElementChanged += this.OnSourceNameResolverElementChanged;
				this.IsSourceChangedRegistered = true;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000030A7 File Offset: 0x000012A7
		private void UnregisterSourceChanged()
		{
			if (this.IsSourceChangedRegistered)
			{
				this.SourceNameResolver.ResolvedElementChanged -= this.OnSourceNameResolverElementChanged;
				this.IsSourceChangedRegistered = false;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000030CF File Offset: 0x000012CF
		private void OnSourceNameResolverElementChanged(object sender, global::System.Windows.Interactivity.NameResolvedEventArgs e)
		{
			if (this.SourceObject == null)
			{
				this.OnSourceChanged(e.OldObject, e.NewObject);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000030EB File Offset: 0x000012EB
		private void RegisterLoaded(global::System.Windows.FrameworkElement associatedElement)
		{
			if (!this.IsLoadedRegistered && associatedElement != null)
			{
				associatedElement.Loaded += new global::System.Windows.RoutedEventHandler(this.OnEventImpl);
				this.IsLoadedRegistered = true;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003111 File Offset: 0x00001311
		private void UnregisterLoaded(global::System.Windows.FrameworkElement associatedElement)
		{
			if (this.IsLoadedRegistered && associatedElement != null)
			{
				associatedElement.Loaded -= new global::System.Windows.RoutedEventHandler(this.OnEventImpl);
				this.IsLoadedRegistered = false;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003138 File Offset: 0x00001338
		private void RegisterEvent(object obj, string eventName)
		{
			global::System.Type type = obj.GetType();
			global::System.Reflection.EventInfo @event = type.GetEvent(eventName);
			if (@event == null)
			{
				if (this.SourceObject != null)
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.EventTriggerCannotFindEventNameExceptionMessage, new object[]
					{
						eventName,
						obj.GetType().Name
					}));
				}
				return;
			}
			else
			{
				if (global::System.Windows.Interactivity.EventTriggerBase.IsValidEvent(@event))
				{
					this.eventHandlerMethodInfo = typeof(global::System.Windows.Interactivity.EventTriggerBase).GetMethod("OnEventImpl", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
					@event.AddEventHandler(obj, global::System.Delegate.CreateDelegate(@event.EventHandlerType, this, this.eventHandlerMethodInfo));
					return;
				}
				if (this.SourceObject != null)
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.EventTriggerBaseInvalidEventExceptionMessage, new object[]
					{
						eventName,
						obj.GetType().Name
					}));
				}
				return;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000320C File Offset: 0x0000140C
		private static bool IsValidEvent(global::System.Reflection.EventInfo eventInfo)
		{
			global::System.Type eventHandlerType = eventInfo.EventHandlerType;
			if (typeof(global::System.Delegate).IsAssignableFrom(eventInfo.EventHandlerType))
			{
				global::System.Reflection.MethodInfo method = eventHandlerType.GetMethod("Invoke");
				global::System.Reflection.ParameterInfo[] parameters = method.GetParameters();
				return parameters.Length == 2 && typeof(object).IsAssignableFrom(parameters[0].ParameterType) && typeof(global::System.EventArgs).IsAssignableFrom(parameters[1].ParameterType);
			}
			return false;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003284 File Offset: 0x00001484
		private void UnregisterEvent(object obj, string eventName)
		{
			if (string.Compare(eventName, "Loaded", global::System.StringComparison.Ordinal) == 0)
			{
				global::System.Windows.FrameworkElement frameworkElement = obj as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					this.UnregisterLoaded(frameworkElement);
					return;
				}
			}
			else
			{
				this.UnregisterEventImpl(obj, eventName);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000032BC File Offset: 0x000014BC
		private void UnregisterEventImpl(object obj, string eventName)
		{
			global::System.Type type = obj.GetType();
			if (this.eventHandlerMethodInfo == null)
			{
				return;
			}
			global::System.Reflection.EventInfo @event = type.GetEvent(eventName);
			@event.RemoveEventHandler(obj, global::System.Delegate.CreateDelegate(@event.EventHandlerType, this, this.eventHandlerMethodInfo));
			this.eventHandlerMethodInfo = null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003307 File Offset: 0x00001507
		private void OnEventImpl(object sender, global::System.EventArgs eventArgs)
		{
			this.OnEvent(eventArgs);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003310 File Offset: 0x00001510
		internal void OnEventNameChanged(string oldEventName, string newEventName)
		{
			if (base.AssociatedObject != null)
			{
				global::System.Windows.FrameworkElement frameworkElement = this.Source as global::System.Windows.FrameworkElement;
				if (frameworkElement != null && string.Compare(oldEventName, "Loaded", global::System.StringComparison.Ordinal) == 0)
				{
					this.UnregisterLoaded(frameworkElement);
				}
				else if (!string.IsNullOrEmpty(oldEventName))
				{
					this.UnregisterEvent(this.Source, oldEventName);
				}
				if (frameworkElement != null && string.Compare(newEventName, "Loaded", global::System.StringComparison.Ordinal) == 0)
				{
					this.RegisterLoaded(frameworkElement);
					return;
				}
				if (!string.IsNullOrEmpty(newEventName))
				{
					this.RegisterEvent(this.Source, newEventName);
				}
			}
		}

		// Token: 0x04000018 RID: 24
		private global::System.Type sourceTypeConstraint;

		// Token: 0x04000019 RID: 25
		private bool isSourceChangedRegistered;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Interactivity.NameResolver sourceNameResolver;

		// Token: 0x0400001B RID: 27
		private global::System.Reflection.MethodInfo eventHandlerMethodInfo;

		// Token: 0x0400001C RID: 28
		public static readonly global::System.Windows.DependencyProperty SourceObjectProperty = global::System.Windows.DependencyProperty.Register("SourceObject", typeof(object), typeof(global::System.Windows.Interactivity.EventTriggerBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Interactivity.EventTriggerBase.OnSourceObjectChanged)));

		// Token: 0x0400001D RID: 29
		public static readonly global::System.Windows.DependencyProperty SourceNameProperty = global::System.Windows.DependencyProperty.Register("SourceName", typeof(string), typeof(global::System.Windows.Interactivity.EventTriggerBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Interactivity.EventTriggerBase.OnSourceNameChanged)));
	}
}
