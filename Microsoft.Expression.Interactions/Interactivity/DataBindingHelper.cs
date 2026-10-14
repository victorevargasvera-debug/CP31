using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Data;
using System.Windows.Interactivity;

namespace Microsoft.Expression.Interactivity
{
	// Token: 0x0200000E RID: 14
	internal static class DataBindingHelper
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000034E8 File Offset: 0x000016E8
		public static void EnsureDataBindingUpToDateOnMembers(global::System.Windows.DependencyObject dpObject)
		{
			global::System.Collections.Generic.IList<global::System.Windows.DependencyProperty> list = null;
			if (!global::Microsoft.Expression.Interactivity.DataBindingHelper.DependenciesPropertyCache.TryGetValue(dpObject.GetType(), out list))
			{
				list = new global::System.Collections.Generic.List<global::System.Windows.DependencyProperty>();
				global::System.Type type = dpObject.GetType();
				while (type != null)
				{
					global::System.Reflection.FieldInfo[] fields = type.GetFields();
					foreach (global::System.Reflection.FieldInfo fieldInfo in fields)
					{
						if (fieldInfo.IsPublic && fieldInfo.FieldType == typeof(global::System.Windows.DependencyProperty))
						{
							global::System.Windows.DependencyProperty dependencyProperty = fieldInfo.GetValue(null) as global::System.Windows.DependencyProperty;
							if (dependencyProperty != null)
							{
								list.Add(dependencyProperty);
							}
						}
					}
					type = type.BaseType;
				}
				global::Microsoft.Expression.Interactivity.DataBindingHelper.DependenciesPropertyCache[dpObject.GetType()] = list;
			}
			if (list == null)
			{
				return;
			}
			foreach (global::System.Windows.DependencyProperty dp in list)
			{
				global::Microsoft.Expression.Interactivity.DataBindingHelper.EnsureBindingUpToDate(dpObject, dp);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000035E0 File Offset: 0x000017E0
		public static void EnsureDataBindingOnActionsUpToDate(global::System.Windows.Interactivity.TriggerBase<global::System.Windows.DependencyObject> trigger)
		{
			foreach (global::System.Windows.Interactivity.TriggerAction dpObject in trigger.Actions)
			{
				global::Microsoft.Expression.Interactivity.DataBindingHelper.EnsureDataBindingUpToDateOnMembers(dpObject);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003634 File Offset: 0x00001834
		public static void EnsureBindingUpToDate(global::System.Windows.DependencyObject target, global::System.Windows.DependencyProperty dp)
		{
			global::System.Windows.Data.BindingExpression bindingExpression = global::System.Windows.Data.BindingOperations.GetBindingExpression(target, dp);
			if (bindingExpression != null)
			{
				bindingExpression.UpdateTarget();
			}
		}

		// Token: 0x0400001E RID: 30
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.IList<global::System.Windows.DependencyProperty>> DependenciesPropertyCache = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.IList<global::System.Windows.DependencyProperty>>();
	}
}
