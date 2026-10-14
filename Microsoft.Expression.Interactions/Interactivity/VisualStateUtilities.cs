using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Microsoft.Expression.Interactivity
{
	// Token: 0x0200002F RID: 47
	public static class VisualStateUtilities
	{
		// Token: 0x060001BE RID: 446 RVA: 0x00009A30 File Offset: 0x00007C30
		public static bool GoToState(global::System.Windows.FrameworkElement element, string stateName, bool useTransitions)
		{
			bool result = false;
			if (!string.IsNullOrEmpty(stateName))
			{
				global::System.Windows.Controls.Control control = element as global::System.Windows.Controls.Control;
				if (control != null)
				{
					control.ApplyTemplate();
					result = global::System.Windows.VisualStateManager.GoToState(control, stateName, useTransitions);
				}
				else
				{
					result = global::System.Windows.VisualStateManager.GoToElementState(element, stateName, useTransitions);
				}
			}
			return result;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00009A70 File Offset: 0x00007C70
		public static global::System.Collections.IList GetVisualStateGroups(global::System.Windows.FrameworkElement targetObject)
		{
			global::System.Collections.IList list = new global::System.Collections.Generic.List<global::System.Windows.VisualStateGroup>();
			if (targetObject != null)
			{
				list = global::System.Windows.VisualStateManager.GetVisualStateGroups(targetObject);
				if (list.Count == 0)
				{
					int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(targetObject);
					if (childrenCount > 0)
					{
						global::System.Windows.FrameworkElement obj = global::System.Windows.Media.VisualTreeHelper.GetChild(targetObject, 0) as global::System.Windows.FrameworkElement;
						list = global::System.Windows.VisualStateManager.GetVisualStateGroups(obj);
					}
				}
				if (list.Count == 0)
				{
					global::System.Windows.Controls.UserControl userControl = targetObject as global::System.Windows.Controls.UserControl;
					if (userControl != null)
					{
						global::System.Windows.FrameworkElement frameworkElement = userControl.Content as global::System.Windows.FrameworkElement;
						if (frameworkElement != null)
						{
							list = global::System.Windows.VisualStateManager.GetVisualStateGroups(frameworkElement);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00009AE0 File Offset: 0x00007CE0
		public static bool TryFindNearestStatefulControl(global::System.Windows.FrameworkElement contextElement, out global::System.Windows.FrameworkElement resolvedControl)
		{
			global::System.Windows.FrameworkElement frameworkElement = contextElement;
			if (frameworkElement == null)
			{
				resolvedControl = null;
				return false;
			}
			global::System.Windows.FrameworkElement frameworkElement2 = frameworkElement.Parent as global::System.Windows.FrameworkElement;
			bool result = true;
			while (!global::Microsoft.Expression.Interactivity.VisualStateUtilities.HasVisualStateGroupsDefined(frameworkElement) && global::Microsoft.Expression.Interactivity.VisualStateUtilities.ShouldContinueTreeWalk(frameworkElement2))
			{
				frameworkElement = frameworkElement2;
				frameworkElement2 = (frameworkElement2.Parent as global::System.Windows.FrameworkElement);
			}
			if (global::Microsoft.Expression.Interactivity.VisualStateUtilities.HasVisualStateGroupsDefined(frameworkElement))
			{
				if (frameworkElement.TemplatedParent != null && frameworkElement.TemplatedParent is global::System.Windows.Controls.Control)
				{
					frameworkElement = (frameworkElement.TemplatedParent as global::System.Windows.FrameworkElement);
				}
				else if (frameworkElement2 != null && frameworkElement2 is global::System.Windows.Controls.UserControl)
				{
					frameworkElement = frameworkElement2;
				}
			}
			else
			{
				result = false;
			}
			resolvedControl = frameworkElement;
			return result;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00009B65 File Offset: 0x00007D65
		private static bool HasVisualStateGroupsDefined(global::System.Windows.FrameworkElement frameworkElement)
		{
			return frameworkElement != null && global::System.Windows.VisualStateManager.GetVisualStateGroups(frameworkElement).Count != 0;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00009B80 File Offset: 0x00007D80
		internal static global::System.Windows.FrameworkElement FindNearestStatefulControl(global::System.Windows.FrameworkElement contextElement)
		{
			global::System.Windows.FrameworkElement result = null;
			global::Microsoft.Expression.Interactivity.VisualStateUtilities.TryFindNearestStatefulControl(contextElement, out result);
			return result;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00009B9C File Offset: 0x00007D9C
		private static bool ShouldContinueTreeWalk(global::System.Windows.FrameworkElement element)
		{
			if (element == null)
			{
				return false;
			}
			if (element is global::System.Windows.Controls.UserControl)
			{
				return false;
			}
			if (element.Parent == null)
			{
				global::System.Windows.FrameworkElement frameworkElement = global::Microsoft.Expression.Interactivity.VisualStateUtilities.FindTemplatedParent(element);
				if (frameworkElement == null || (!(frameworkElement is global::System.Windows.Controls.Control) && !(frameworkElement is global::System.Windows.Controls.ContentPresenter)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00009BDD File Offset: 0x00007DDD
		private static global::System.Windows.FrameworkElement FindTemplatedParent(global::System.Windows.FrameworkElement parent)
		{
			return parent.TemplatedParent as global::System.Windows.FrameworkElement;
		}
	}
}
