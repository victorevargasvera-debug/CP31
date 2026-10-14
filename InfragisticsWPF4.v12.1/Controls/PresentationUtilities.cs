using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Infragistics.Controls
{
	// Token: 0x02000061 RID: 97
	internal static class PresentationUtilities
	{
		// Token: 0x060003DB RID: 987 RVA: 0x00010C38 File Offset: 0x0000EE38
		internal static global::System.Windows.Data.Binding CreateBinding(params global::Infragistics.Controls.BindingPart[] parts)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
			for (int i = 0; i < parts.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append('.');
				}
				global::Infragistics.Controls.BindingPart bindingPart = parts[i];
				stringBuilder.AppendFormat("({0})", i);
				stringBuilder.Append(bindingPart.Path);
				list.Add(bindingPart.PathParameter);
			}
			global::System.Windows.PropertyPath path = new global::System.Windows.PropertyPath(stringBuilder.ToString(), list.ToArray());
			return new global::System.Windows.Data.Binding
			{
				Path = path
			};
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00010CC0 File Offset: 0x0000EEC0
		internal static global::System.Windows.Data.Binding CreateBinding(string pathWithoutAttachedProperties)
		{
			return new global::System.Windows.Data.Binding(pathWithoutAttachedProperties);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		internal static bool Focus(global::System.Windows.UIElement element)
		{
			return global::Infragistics.Controls.PresentationUtilities.FocusImpl(element) ?? false;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00010CF0 File Offset: 0x0000EEF0
		private static bool? FocusImpl(global::System.Windows.UIElement element)
		{
			if (element == null || element.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				return null;
			}
			if (element.Visibility == global::System.Windows.Visibility.Hidden)
			{
				return null;
			}
			if (!element.IsEnabled)
			{
				return null;
			}
			if (element.Focusable)
			{
				return new bool?(element.Focus());
			}
			int i = 0;
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(element);
			while (i < childrenCount)
			{
				global::System.Windows.UIElement element2 = global::System.Windows.Media.VisualTreeHelper.GetChild(element, i) as global::System.Windows.UIElement;
				bool? flag = global::Infragistics.Controls.PresentationUtilities.FocusImpl(element2);
				if (flag != null)
				{
					return new bool?(flag.Value);
				}
				i++;
			}
			return null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00010D96 File Offset: 0x0000EF96
		internal static void ForceLostFocusBindingUpdate(global::System.Windows.DependencyObject ancestorScope, global::System.Windows.DependencyObject element)
		{
			global::Infragistics.Controls.PresentationUtilities.ForceLostFocusBindingUpdateImpl(ancestorScope, element);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		private static void ForceLostFocusBindingUpdateImpl(global::System.Windows.DependencyObject ancestorScope, global::System.Windows.DependencyObject descendant)
		{
			while (descendant != null)
			{
				foreach (object obj in global::System.ComponentModel.TypeDescriptor.GetProperties(descendant))
				{
					global::System.ComponentModel.PropertyDescriptor property = (global::System.ComponentModel.PropertyDescriptor)obj;
					global::System.ComponentModel.DependencyPropertyDescriptor dependencyPropertyDescriptor = global::System.ComponentModel.DependencyPropertyDescriptor.FromProperty(property);
					if (dependencyPropertyDescriptor != null)
					{
						global::System.Windows.Data.BindingExpressionBase bindingExpressionBase = global::System.Windows.Data.BindingOperations.GetBindingExpressionBase(descendant, dependencyPropertyDescriptor.DependencyProperty);
						if (bindingExpressionBase != null && global::Infragistics.Controls.PresentationUtilities.IsLostFocusBinding(bindingExpressionBase, dependencyPropertyDescriptor.Metadata))
						{
							bindingExpressionBase.UpdateSource();
						}
					}
				}
				if (!(descendant is global::System.Windows.Media.Visual) && !(descendant is global::System.Windows.Media.Media3D.Visual3D))
				{
					break;
				}
				descendant = global::System.Windows.Media.VisualTreeHelper.GetParent(descendant);
				if (descendant == ancestorScope)
				{
					return;
				}
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00010E4C File Offset: 0x0000F04C
		private static bool IsLostFocusBinding(global::System.Windows.Data.BindingExpressionBase expression, global::System.Windows.PropertyMetadata metadata)
		{
			if (expression == null)
			{
				return false;
			}
			global::System.Windows.Data.Binding binding = expression.ParentBindingBase as global::System.Windows.Data.Binding;
			global::System.Windows.Data.UpdateSourceTrigger updateSourceTrigger;
			global::System.Windows.Data.BindingMode mode;
			if (binding != null)
			{
				updateSourceTrigger = binding.UpdateSourceTrigger;
				mode = binding.Mode;
			}
			else
			{
				global::System.Windows.Data.MultiBinding multiBinding = expression.ParentBindingBase as global::System.Windows.Data.MultiBinding;
				if (multiBinding == null)
				{
					return false;
				}
				updateSourceTrigger = multiBinding.UpdateSourceTrigger;
				mode = multiBinding.Mode;
			}
			if (updateSourceTrigger == global::System.Windows.Data.UpdateSourceTrigger.Default)
			{
				global::System.Windows.FrameworkPropertyMetadata frameworkPropertyMetadata = metadata as global::System.Windows.FrameworkPropertyMetadata;
				if (frameworkPropertyMetadata != null)
				{
					updateSourceTrigger = frameworkPropertyMetadata.DefaultUpdateSourceTrigger;
				}
			}
			return updateSourceTrigger == global::System.Windows.Data.UpdateSourceTrigger.LostFocus && (mode == global::System.Windows.Data.BindingMode.OneWayToSource || mode == global::System.Windows.Data.BindingMode.TwoWay);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00010EC3 File Offset: 0x0000F0C3
		internal static global::System.Windows.DependencyObject GetElementWithKeyboardFocus()
		{
			return global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.DependencyObject;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00010ED0 File Offset: 0x0000F0D0
		internal static global::System.Windows.DependencyObject GetElementWithFocus(global::System.Windows.UIElement referenceElement)
		{
			global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(referenceElement);
			if (focusScope == null)
			{
				return null;
			}
			return global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope) as global::System.Windows.DependencyObject;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00010EF4 File Offset: 0x0000F0F4
		internal static global::System.Windows.Input.Key GetKey(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.System)
			{
				return e.SystemKey;
			}
			return e.Key;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00010F10 File Offset: 0x0000F110
		internal static global::System.Windows.DependencyObject GetRootVisual(global::System.Windows.DependencyObject element)
		{
			while (element is global::System.Windows.ContentElement)
			{
				element = global::System.Windows.LogicalTreeHelper.GetParent(element);
			}
			while (element != null)
			{
				global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(element);
				if (parent == null)
				{
					return element;
				}
				element = parent;
			}
			return null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00010F44 File Offset: 0x0000F144
		internal static global::System.Windows.Controls.Primitives.Thumb GetScrollThumb(global::System.Windows.Controls.Primitives.ScrollBar scrollBar)
		{
			global::System.Windows.Controls.Primitives.Track track = scrollBar.Track;
			if (track == null)
			{
				return null;
			}
			return track.Thumb;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00010F63 File Offset: 0x0000F163
		internal static global::System.Windows.DependencyObject GetTemplatedParent(global::System.Windows.FrameworkElement fe)
		{
			return fe.TemplatedParent;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00010F6C File Offset: 0x0000F16C
		internal static T GetVisualAncestor<T>(global::System.Windows.DependencyObject element, global::System.Predicate<T> match, global::System.Windows.DependencyObject ceiling = null) where T : global::System.Windows.DependencyObject
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(element, "element");
			global::System.Windows.DependencyObject dependencyObject = element;
			T t;
			for (;;)
			{
				dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
				t = (dependencyObject as T);
				if (t != null && (match == null || match(t)))
				{
					break;
				}
				if (dependencyObject == null || (ceiling != null && dependencyObject == ceiling))
				{
					goto IL_40;
				}
			}
			return t;
			IL_40:
			return default(T);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00010FC4 File Offset: 0x0000F1C4
		internal static T GetVisualDescendant<T>(global::System.Windows.DependencyObject element, global::System.Predicate<T> match, global::System.Predicate<global::System.Windows.DependencyObject> skipDescend = null) where T : global::System.Windows.DependencyObject
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(element, "element");
			int i = 0;
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(element);
			while (i < childrenCount)
			{
				global::System.Windows.DependencyObject child = global::System.Windows.Media.VisualTreeHelper.GetChild(element, i);
				if (child != null)
				{
					T t = child as T;
					if ((t == null || (match != null && !match(t))) && (skipDescend == null || !skipDescend(child)))
					{
						t = global::Infragistics.Controls.PresentationUtilities.GetVisualDescendant<T>(child, match, skipDescend);
					}
					if (t != null)
					{
						return t;
					}
				}
				i++;
			}
			return default(T);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00011043 File Offset: 0x0000F243
		internal static T GetVisualDescendantFromPoint<T>(global::System.Windows.UIElement subTree, global::System.Windows.Point pt, global::System.Predicate<T> match) where T : global::System.Windows.DependencyObject
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(subTree, "subTree");
			return global::Infragistics.Controls.PresentationUtilities.GetVisualDescendantFromPointHelper<T>(subTree, pt, match);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0001109C File Offset: 0x0000F29C
		private static T GetVisualDescendantFromPointHelper<T>(global::System.Windows.UIElement subTree, global::System.Windows.Point pt, global::System.Predicate<T> match) where T : global::System.Windows.DependencyObject
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(subTree, "subTree");
			global::System.Windows.DependencyObject htResult = null;
			global::System.Windows.Media.HitTestResultCallback resultCallback = delegate(global::System.Windows.Media.HitTestResult result)
			{
				htResult = result.VisualHit;
				return global::System.Windows.Media.HitTestResultBehavior.Stop;
			};
			global::System.Windows.Media.HitTestFilterCallback filterCallback = delegate(global::System.Windows.DependencyObject target)
			{
				global::System.Windows.Media.HitTestFilterBehavior result = global::System.Windows.Media.HitTestFilterBehavior.Continue;
				global::System.Windows.UIElement uielement2 = target as global::System.Windows.UIElement;
				if (uielement2 != null && (!uielement2.IsVisible || !uielement2.IsHitTestVisible))
				{
					result = global::System.Windows.Media.HitTestFilterBehavior.ContinueSkipSelfAndChildren;
				}
				return result;
			};
			global::System.Windows.Media.VisualTreeHelper.HitTest(subTree, filterCallback, resultCallback, new global::System.Windows.Media.PointHitTestParameters(pt));
			if (htResult == null)
			{
				return default(T);
			}
			global::System.Windows.UIElement uielement = htResult as global::System.Windows.UIElement;
			if (uielement == null && htResult != null)
			{
				uielement = global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::System.Windows.UIElement>(htResult, null, null);
			}
			global::System.Windows.DependencyObject dependencyObject = uielement;
			T t;
			for (;;)
			{
				dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
				t = (dependencyObject as T);
				if (t != null && (match == null || match(t)))
				{
					break;
				}
				if (dependencyObject == null)
				{
					goto Block_6;
				}
			}
			return t;
			Block_6:
			return default(T);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00011164 File Offset: 0x0000F364
		internal static global::System.Windows.DependencyObject GetImmediateDescendant(global::System.Windows.DependencyObject descendant, global::System.Windows.DependencyObject ancestor)
		{
			while (descendant is global::System.Windows.ContentElement)
			{
				descendant = global::System.Windows.LogicalTreeHelper.GetParent(descendant);
			}
			while (descendant != null)
			{
				global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(descendant);
				if (parent == ancestor)
				{
					return descendant;
				}
				descendant = parent;
			}
			return null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001119C File Offset: 0x0000F39C
		internal static bool HasFocus(global::System.Windows.UIElement element)
		{
			global::System.Windows.DependencyObject elementWithFocus = global::Infragistics.Controls.PresentationUtilities.GetElementWithFocus(element);
			return elementWithFocus != null && global::Infragistics.Controls.PresentationUtilities.IsAncestorOf(element, elementWithFocus);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000111BF File Offset: 0x0000F3BF
		internal static bool HasNoOtherModifiers(global::System.Windows.Input.ModifierKeys modifiersToIgnore = global::System.Windows.Input.ModifierKeys.Shift)
		{
			return global::Infragistics.Controls.PresentationUtilities.IsModifierPressed(global::System.Windows.Input.ModifierKeys.None, modifiersToIgnore);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000111C8 File Offset: 0x0000F3C8
		internal static bool IsAncestorOf(global::System.Windows.Media.Visual ancestor, global::System.Windows.DependencyObject descendant)
		{
			if (ancestor == null)
			{
				return false;
			}
			while (descendant is global::System.Windows.ContentElement)
			{
				descendant = global::System.Windows.LogicalTreeHelper.GetParent(descendant);
			}
			return descendant != null && ancestor.IsAncestorOf(descendant);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000111EC File Offset: 0x0000F3EC
		internal static bool IsModifierPressed(global::System.Windows.Input.ModifierKeys modifier, global::System.Windows.Input.ModifierKeys modifiersToIgnore = global::System.Windows.Input.ModifierKeys.None)
		{
			global::System.Windows.Input.ModifierKeys modifierKeys = global::System.Windows.Input.Keyboard.Modifiers & ~modifiersToIgnore;
			return modifierKeys == modifier;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00011206 File Offset: 0x0000F406
		internal static bool MayBeVisible(global::System.Windows.FrameworkElement element)
		{
			return element != null && element.Visibility != global::System.Windows.Visibility.Collapsed && element.IsVisible && element.IsLoaded;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00011229 File Offset: 0x0000F429
		internal static void ReparentElement(global::System.Windows.Controls.Panel panel, global::System.Windows.FrameworkElement child, bool add)
		{
			if (child != null && panel != null)
			{
				if (add)
				{
					if (global::System.Windows.Media.VisualTreeHelper.GetParent(child) == null)
					{
						panel.Children.Add(child);
						return;
					}
				}
				else if (global::System.Windows.Media.VisualTreeHelper.GetParent(child) == panel)
				{
					panel.Children.Remove(child);
				}
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00011260 File Offset: 0x0000F460
		internal static bool TryTransformToRoot(global::System.Windows.FrameworkElement source, global::System.Windows.FrameworkElement wpfTarget, out global::System.Windows.Media.GeneralTransform transform)
		{
			bool result;
			try
			{
				if (source.FindCommonVisualAncestor(wpfTarget) == null)
				{
					global::System.Windows.Point point = source.PointToScreen(default(global::System.Windows.Point));
					point = wpfTarget.PointFromScreen(point);
					transform = new global::System.Windows.Media.TranslateTransform(point.X, point.Y);
					transform.Freeze();
				}
				else
				{
					transform = source.TransformToVisual(wpfTarget);
				}
				result = true;
			}
			catch (global::System.Exception)
			{
				transform = null;
				result = false;
			}
			return result;
		}

		// Token: 0x0400014F RID: 335
		internal const global::System.Windows.Input.ModifierKeys AllModifiers = global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift | global::System.Windows.Input.ModifierKeys.Windows;

		// Token: 0x04000150 RID: 336
		internal static global::System.Windows.Data.RelativeSource RelativeSourceSelf = global::System.Windows.Data.RelativeSource.Self;

		// Token: 0x04000151 RID: 337
		internal static global::System.Windows.Data.RelativeSource RelativeSourceTemplatedParent = global::System.Windows.Data.RelativeSource.TemplatedParent;
	}
}
