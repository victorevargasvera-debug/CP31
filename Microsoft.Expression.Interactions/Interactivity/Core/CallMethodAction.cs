using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Interactivity;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x02000003 RID: 3
	public class CallMethodAction : global::System.Windows.Interactivity.TriggerAction<global::System.Windows.DependencyObject>
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002194 File Offset: 0x00000394
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000021A1 File Offset: 0x000003A1
		public object TargetObject
		{
			get
			{
				return base.GetValue(global::Microsoft.Expression.Interactivity.Core.CallMethodAction.TargetObjectProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.CallMethodAction.TargetObjectProperty, value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000021AF File Offset: 0x000003AF
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000021C1 File Offset: 0x000003C1
		public string MethodName
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Expression.Interactivity.Core.CallMethodAction.MethodNameProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.CallMethodAction.MethodNameProperty, value);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021CF File Offset: 0x000003CF
		public CallMethodAction()
		{
			this.methodDescriptors = new global::System.Collections.Generic.List<global::Microsoft.Expression.Interactivity.Core.CallMethodAction.MethodDescriptor>();
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000021E2 File Offset: 0x000003E2
		private object Target
		{
			get
			{
				return this.TargetObject ?? base.AssociatedObject;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021F4 File Offset: 0x000003F4
		protected override void Invoke(object parameter)
		{
			if (base.AssociatedObject != null)
			{
				global::Microsoft.Expression.Interactivity.Core.CallMethodAction.MethodDescriptor methodDescriptor = this.FindBestMethod(parameter);
				if (methodDescriptor != null)
				{
					global::System.Reflection.ParameterInfo[] parameters = methodDescriptor.Parameters;
					if (parameters.Length == 0)
					{
						methodDescriptor.MethodInfo.Invoke(this.Target, null);
						return;
					}
					if (parameters.Length == 2 && base.AssociatedObject != null && parameter != null && parameters[0].ParameterType.IsAssignableFrom(base.AssociatedObject.GetType()) && parameters[1].ParameterType.IsAssignableFrom(parameter.GetType()))
					{
						methodDescriptor.MethodInfo.Invoke(this.Target, new object[]
						{
							base.AssociatedObject,
							parameter
						});
						return;
					}
				}
				else if (this.TargetObject != null)
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.CallMethodActionValidMethodNotFoundExceptionMessage, new object[]
					{
						this.MethodName,
						this.TargetObject.GetType().Name
					}));
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022EC File Offset: 0x000004EC
		protected override void OnAttached()
		{
			base.OnAttached();
			this.UpdateMethodInfo();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022FA File Offset: 0x000004FA
		protected override void OnDetaching()
		{
			this.methodDescriptors.Clear();
			base.OnDetaching();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002344 File Offset: 0x00000544
		private global::Microsoft.Expression.Interactivity.Core.CallMethodAction.MethodDescriptor FindBestMethod(object parameter)
		{
			if (parameter != null)
			{
				parameter.GetType();
			}
			return this.methodDescriptors.FirstOrDefault((global::Microsoft.Expression.Interactivity.Core.CallMethodAction.MethodDescriptor methodDescriptor) => !methodDescriptor.HasParameters || (parameter != null && methodDescriptor.SecondParameterType.IsAssignableFrom(parameter.GetType())));
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023D4 File Offset: 0x000005D4
		private void UpdateMethodInfo()
		{
			this.methodDescriptors.Clear();
			if (this.Target != null && !string.IsNullOrEmpty(this.MethodName))
			{
				global::System.Type type = this.Target.GetType();
				foreach (global::System.Reflection.MethodInfo methodInfo in type.GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public))
				{
					if (this.IsMethodValid(methodInfo))
					{
						global::System.Reflection.ParameterInfo[] parameters = methodInfo.GetParameters();
						if (global::Microsoft.Expression.Interactivity.Core.CallMethodAction.AreMethodParamsValid(parameters))
						{
							this.methodDescriptors.Add(new global::Microsoft.Expression.Interactivity.Core.CallMethodAction.MethodDescriptor(methodInfo, parameters));
						}
					}
				}
				this.methodDescriptors = this.methodDescriptors.OrderByDescending(delegate(global::Microsoft.Expression.Interactivity.Core.CallMethodAction.MethodDescriptor methodDescriptor)
				{
					int num = 0;
					if (methodDescriptor.HasParameters)
					{
						global::System.Type type2 = methodDescriptor.SecondParameterType;
						while (type2 != typeof(global::System.EventArgs))
						{
							num++;
							type2 = type2.BaseType;
						}
					}
					return methodDescriptor.ParameterCount + num;
				}).ToList<global::Microsoft.Expression.Interactivity.Core.CallMethodAction.MethodDescriptor>();
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000248E File Offset: 0x0000068E
		private bool IsMethodValid(global::System.Reflection.MethodInfo method)
		{
			return string.Equals(method.Name, this.MethodName, global::System.StringComparison.Ordinal) && !(method.ReturnType != typeof(void));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000024C0 File Offset: 0x000006C0
		private static bool AreMethodParamsValid(global::System.Reflection.ParameterInfo[] methodParams)
		{
			if (methodParams.Length == 2)
			{
				if (methodParams[0].ParameterType != typeof(object))
				{
					return false;
				}
				if (!typeof(global::System.EventArgs).IsAssignableFrom(methodParams[1].ParameterType))
				{
					return false;
				}
			}
			else if (methodParams.Length != 0)
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002514 File Offset: 0x00000714
		private static void OnMethodNameChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Core.CallMethodAction callMethodAction = (global::Microsoft.Expression.Interactivity.Core.CallMethodAction)sender;
			callMethodAction.UpdateMethodInfo();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002530 File Offset: 0x00000730
		private static void OnTargetObjectChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Core.CallMethodAction callMethodAction = (global::Microsoft.Expression.Interactivity.Core.CallMethodAction)sender;
			callMethodAction.UpdateMethodInfo();
		}

		// Token: 0x04000004 RID: 4
		private global::System.Collections.Generic.List<global::Microsoft.Expression.Interactivity.Core.CallMethodAction.MethodDescriptor> methodDescriptors;

		// Token: 0x04000005 RID: 5
		public static readonly global::System.Windows.DependencyProperty TargetObjectProperty = global::System.Windows.DependencyProperty.Register("TargetObject", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Core.CallMethodAction), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Core.CallMethodAction.OnTargetObjectChanged)));

		// Token: 0x04000006 RID: 6
		public static readonly global::System.Windows.DependencyProperty MethodNameProperty = global::System.Windows.DependencyProperty.Register("MethodName", typeof(string), typeof(global::Microsoft.Expression.Interactivity.Core.CallMethodAction), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Core.CallMethodAction.OnMethodNameChanged)));

		// Token: 0x02000004 RID: 4
		private class MethodDescriptor
		{
			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600001A RID: 26 RVA: 0x000025C1 File Offset: 0x000007C1
			// (set) Token: 0x0600001B RID: 27 RVA: 0x000025C9 File Offset: 0x000007C9
			public global::System.Reflection.MethodInfo MethodInfo { get; private set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600001C RID: 28 RVA: 0x000025D2 File Offset: 0x000007D2
			public bool HasParameters
			{
				get
				{
					return this.Parameters.Length > 0;
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600001D RID: 29 RVA: 0x000025DF File Offset: 0x000007DF
			public int ParameterCount
			{
				get
				{
					return this.Parameters.Length;
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600001E RID: 30 RVA: 0x000025E9 File Offset: 0x000007E9
			// (set) Token: 0x0600001F RID: 31 RVA: 0x000025F1 File Offset: 0x000007F1
			public global::System.Reflection.ParameterInfo[] Parameters { get; private set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000020 RID: 32 RVA: 0x000025FA File Offset: 0x000007FA
			public global::System.Type SecondParameterType
			{
				get
				{
					if (this.Parameters.Length >= 2)
					{
						return this.Parameters[1].ParameterType;
					}
					return null;
				}
			}

			// Token: 0x06000021 RID: 33 RVA: 0x00002616 File Offset: 0x00000816
			public MethodDescriptor(global::System.Reflection.MethodInfo methodInfo, global::System.Reflection.ParameterInfo[] methodParams)
			{
				this.MethodInfo = methodInfo;
				this.Parameters = methodParams;
			}
		}
	}
}
