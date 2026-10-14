using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Interactivity;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x0200000F RID: 15
	public class DataStateBehavior : global::System.Windows.Interactivity.Behavior<global::System.Windows.FrameworkElement>
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000365E File Offset: 0x0000185E
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000366B File Offset: 0x0000186B
		public object Binding
		{
			get
			{
				return base.GetValue(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.BindingProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.BindingProperty, value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003679 File Offset: 0x00001879
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00003686 File Offset: 0x00001886
		public object Value
		{
			get
			{
				return base.GetValue(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.ValueProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.ValueProperty, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003694 File Offset: 0x00001894
		// (set) Token: 0x0600005D RID: 93 RVA: 0x000036A6 File Offset: 0x000018A6
		public string TrueState
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.TrueStateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.TrueStateProperty, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000036B4 File Offset: 0x000018B4
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000036C6 File Offset: 0x000018C6
		public string FalseState
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.FalseStateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.FalseStateProperty, value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000036D4 File Offset: 0x000018D4
		private global::System.Windows.FrameworkElement TargetObject
		{
			get
			{
				return global::Microsoft.Expression.Interactivity.VisualStateUtilities.FindNearestStatefulControl(base.AssociatedObject);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000036E1 File Offset: 0x000018E1
		protected override void OnAttached()
		{
			base.OnAttached();
			this.ValidateStateNamesDeferred();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000036F8 File Offset: 0x000018F8
		private void ValidateStateNamesDeferred()
		{
			global::System.Windows.FrameworkElement frameworkElement = base.AssociatedObject.Parent as global::System.Windows.FrameworkElement;
			if (frameworkElement != null && global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.IsElementLoaded(frameworkElement))
			{
				this.ValidateStateNames();
				return;
			}
			base.AssociatedObject.Loaded += delegate(object o, global::System.Windows.RoutedEventArgs e)
			{
				this.ValidateStateNames();
			};
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003746 File Offset: 0x00001946
		internal static bool IsElementLoaded(global::System.Windows.FrameworkElement element)
		{
			return element.IsLoaded;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000374E File Offset: 0x0000194E
		private void ValidateStateNames()
		{
			this.ValidateStateName(this.TrueState);
			this.ValidateStateName(this.FalseState);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003768 File Offset: 0x00001968
		private void ValidateStateName(string stateName)
		{
			if (base.AssociatedObject != null && !string.IsNullOrEmpty(stateName))
			{
				foreach (global::System.Windows.VisualState visualState in this.TargetedVisualStates)
				{
					if (stateName == visualState.Name)
					{
						return;
					}
				}
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.DataStateBehaviorStateNameNotFoundExceptionMessage, new object[]
				{
					stateName,
					(this.TargetObject != null) ? this.TargetObject.GetType().Name : "null"
				}));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00003814 File Offset: 0x00001A14
		private global::System.Collections.Generic.IEnumerable<global::System.Windows.VisualState> TargetedVisualStates
		{
			get
			{
				global::System.Collections.Generic.List<global::System.Windows.VisualState> list = new global::System.Collections.Generic.List<global::System.Windows.VisualState>();
				if (this.TargetObject != null)
				{
					global::System.Collections.IList visualStateGroups = global::Microsoft.Expression.Interactivity.VisualStateUtilities.GetVisualStateGroups(this.TargetObject);
					foreach (object obj in visualStateGroups)
					{
						global::System.Windows.VisualStateGroup visualStateGroup = (global::System.Windows.VisualStateGroup)obj;
						foreach (object obj2 in visualStateGroup.States)
						{
							global::System.Windows.VisualState item = (global::System.Windows.VisualState)obj2;
							list.Add(item);
						}
					}
				}
				return list;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000038D8 File Offset: 0x00001AD8
		private static void OnBindingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Core.DataStateBehavior dataStateBehavior = (global::Microsoft.Expression.Interactivity.Core.DataStateBehavior)obj;
			dataStateBehavior.Evaluate();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000038F4 File Offset: 0x00001AF4
		private static void OnValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Core.DataStateBehavior dataStateBehavior = (global::Microsoft.Expression.Interactivity.Core.DataStateBehavior)obj;
			dataStateBehavior.Evaluate();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003910 File Offset: 0x00001B10
		private static void OnTrueStateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Core.DataStateBehavior dataStateBehavior = (global::Microsoft.Expression.Interactivity.Core.DataStateBehavior)obj;
			dataStateBehavior.ValidateStateName(dataStateBehavior.TrueState);
			dataStateBehavior.Evaluate();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003938 File Offset: 0x00001B38
		private static void OnFalseStateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Core.DataStateBehavior dataStateBehavior = (global::Microsoft.Expression.Interactivity.Core.DataStateBehavior)obj;
			dataStateBehavior.ValidateStateName(dataStateBehavior.FalseState);
			dataStateBehavior.Evaluate();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003960 File Offset: 0x00001B60
		private void Evaluate()
		{
			if (this.TargetObject != null)
			{
				string stateName;
				if (global::Microsoft.Expression.Interactivity.ComparisonLogic.EvaluateImpl(this.Binding, global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.Equal, this.Value))
				{
					stateName = this.TrueState;
				}
				else
				{
					stateName = this.FalseState;
				}
				global::Microsoft.Expression.Interactivity.VisualStateUtilities.GoToState(this.TargetObject, stateName, true);
			}
		}

		// Token: 0x0400001F RID: 31
		public static readonly global::System.Windows.DependencyProperty BindingProperty = global::System.Windows.DependencyProperty.Register("Binding", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.OnBindingChanged)));

		// Token: 0x04000020 RID: 32
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.OnValueChanged)));

		// Token: 0x04000021 RID: 33
		public static readonly global::System.Windows.DependencyProperty TrueStateProperty = global::System.Windows.DependencyProperty.Register("TrueState", typeof(string), typeof(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.OnTrueStateChanged)));

		// Token: 0x04000022 RID: 34
		public static readonly global::System.Windows.DependencyProperty FalseStateProperty = global::System.Windows.DependencyProperty.Register("FalseState", typeof(string), typeof(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Core.DataStateBehavior.OnFalseStateChanged)));
	}
}
