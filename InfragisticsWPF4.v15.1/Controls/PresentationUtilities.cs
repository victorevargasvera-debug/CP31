using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Threading;

namespace Infragistics.Controls
{
	// Token: 0x02000078 RID: 120
	internal static class PresentationUtilities
	{
		// Token: 0x06000490 RID: 1168 RVA: 0x000132B8 File Offset: 0x000114B8
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

		// Token: 0x06000491 RID: 1169 RVA: 0x00013340 File Offset: 0x00011540
		internal static global::System.Windows.Data.Binding CreateBinding(string pathWithoutAttachedProperties)
		{
			return new global::System.Windows.Data.Binding(pathWithoutAttachedProperties);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00013348 File Offset: 0x00011548
		internal static string CreateXmlNamespace(string prefix, string clrNamespace, global::System.Reflection.Assembly assembly)
		{
			string fullName = assembly.FullName;
			return string.Format("xmlns:{0}=\"clr-namespace:{1};assembly={2}\"", prefix, clrNamespace, fullName);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0001336C File Offset: 0x0001156C
		internal static bool Focus(global::System.Windows.UIElement element)
		{
			return global::Infragistics.Controls.PresentationUtilities.FocusImpl(element) ?? false;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00013394 File Offset: 0x00011594
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

		// Token: 0x06000495 RID: 1173 RVA: 0x0001343A File Offset: 0x0001163A
		internal static void ForceLostFocusBindingUpdate(global::System.Windows.DependencyObject ancestorScope, global::System.Windows.DependencyObject element)
		{
			global::Infragistics.Controls.PresentationUtilities.ForceLostFocusBindingUpdateImpl(ancestorScope, element);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00013444 File Offset: 0x00011644
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

		// Token: 0x06000497 RID: 1175 RVA: 0x000134F0 File Offset: 0x000116F0
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

		// Token: 0x06000498 RID: 1176 RVA: 0x00013567 File Offset: 0x00011767
		internal static global::System.Windows.Threading.Dispatcher GetDispatcher(this global::System.Windows.DependencyObject element)
		{
			if (element == null)
			{
				return null;
			}
			return element.Dispatcher;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00013574 File Offset: 0x00011774
		internal static global::System.Windows.DependencyObject GetElementWithKeyboardFocus()
		{
			return global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.DependencyObject;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00013580 File Offset: 0x00011780
		internal static global::System.Windows.DependencyObject GetElementWithFocus(global::System.Windows.UIElement referenceElement)
		{
			global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(referenceElement);
			if (focusScope == null)
			{
				return null;
			}
			return global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope) as global::System.Windows.DependencyObject;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000135A4 File Offset: 0x000117A4
		internal static global::System.Windows.Input.Key GetKey(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.System)
			{
				return e.SystemKey;
			}
			return e.Key;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000135C0 File Offset: 0x000117C0
		internal static global::System.Windows.Input.ModifierKeys GetCurrentModifierKeys(global::System.Windows.Input.MouseEventArgs e)
		{
			return global::System.Windows.Input.Keyboard.Modifiers;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x000135C7 File Offset: 0x000117C7
		internal static global::System.Windows.Input.ModifierKeys GetCurrentModifierKeys()
		{
			return global::System.Windows.Input.Keyboard.Modifiers;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000135D0 File Offset: 0x000117D0
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

		// Token: 0x0600049F RID: 1183 RVA: 0x00013604 File Offset: 0x00011804
		internal static global::System.Windows.Controls.Primitives.Thumb GetScrollThumb(global::System.Windows.Controls.Primitives.ScrollBar scrollBar)
		{
			global::System.Windows.Controls.Primitives.Track track = scrollBar.Track;
			if (track == null)
			{
				return null;
			}
			return track.Thumb;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00013623 File Offset: 0x00011823
		internal static global::System.Windows.DependencyObject GetTemplatedParent(global::System.Windows.FrameworkElement fe)
		{
			return fe.TemplatedParent;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0001362C File Offset: 0x0001182C
		internal static T GetVisualAncestor<T>(global::System.Windows.DependencyObject element, global::System.Predicate<T> match, global::System.Windows.DependencyObject ceiling = null) where T : global::System.Windows.DependencyObject
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(element, "element");
			while (element is global::System.Windows.ContentElement)
			{
				element = global::System.Windows.LogicalTreeHelper.GetParent(element);
			}
			if (element == null)
			{
				return default(T);
			}
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
					goto IL_5F;
				}
			}
			return t;
			IL_5F:
			return default(T);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000136A4 File Offset: 0x000118A4
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

		// Token: 0x060004A3 RID: 1187 RVA: 0x00013724 File Offset: 0x00011924
		internal static T GetVisualDescendantFromPoint<T>(global::System.Windows.UIElement subTree, global::System.Windows.Input.MouseEventArgs e, global::System.Predicate<T> match) where T : global::System.Windows.DependencyObject
		{
			if (subTree == null)
			{
				return default(T);
			}
			global::System.Windows.Point position = e.GetPosition(subTree);
			return global::Infragistics.Controls.PresentationUtilities.GetVisualDescendantFromPoint<T>(subTree, position, match);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00013750 File Offset: 0x00011950
		internal static T GetVisualDescendantFromRelativePoint<T>(global::System.Windows.UIElement subTree, global::System.Windows.Point subTreeRelativePoint, global::System.Predicate<T> match) where T : global::System.Windows.DependencyObject
		{
			if (subTree == null)
			{
				return default(T);
			}
			return global::Infragistics.Controls.PresentationUtilities.GetVisualDescendantFromPoint<T>(subTree, subTreeRelativePoint, match);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00013774 File Offset: 0x00011974
		internal static T GetVisualDescendantFromPoint<T>(global::System.Windows.UIElement subTree, global::System.Windows.Point pt, global::System.Predicate<T> match) where T : global::System.Windows.DependencyObject
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(subTree, "subTree");
			return global::Infragistics.Controls.PresentationUtilities.GetVisualDescendantFromPointHelper<T>(subTree, pt, match);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000137CC File Offset: 0x000119CC
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

		// Token: 0x060004A7 RID: 1191 RVA: 0x00013894 File Offset: 0x00011A94
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

		// Token: 0x060004A8 RID: 1192 RVA: 0x000138CC File Offset: 0x00011ACC
		internal static bool HasFocus(global::System.Windows.UIElement element)
		{
			global::System.Windows.DependencyObject elementWithFocus = global::Infragistics.Controls.PresentationUtilities.GetElementWithFocus(element);
			return elementWithFocus != null && global::Infragistics.Controls.PresentationUtilities.IsAncestorOf(element, elementWithFocus);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000138EF File Offset: 0x00011AEF
		internal static bool HasNoOtherModifiers(global::System.Windows.Input.ModifierKeys modifiersToIgnore = global::System.Windows.Input.ModifierKeys.Shift)
		{
			return global::Infragistics.Controls.PresentationUtilities.IsModifierPressed(global::System.Windows.Input.ModifierKeys.None, modifiersToIgnore);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000138F8 File Offset: 0x00011AF8
		internal static bool IsAltKey(global::System.Windows.Input.Key key)
		{
			return key == global::System.Windows.Input.Key.LeftAlt || key == global::System.Windows.Input.Key.RightAlt;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00013906 File Offset: 0x00011B06
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

		// Token: 0x060004AC RID: 1196 RVA: 0x0001392C File Offset: 0x00011B2C
		internal static bool IsModifierPressed(global::System.Windows.Input.ModifierKeys modifier, global::System.Windows.Input.ModifierKeys modifiersToIgnore = global::System.Windows.Input.ModifierKeys.None)
		{
			global::System.Windows.Input.ModifierKeys modifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys() & ~modifiersToIgnore;
			return modifierKeys == modifier;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00013946 File Offset: 0x00011B46
		internal static object LoadXaml(string xaml)
		{
			return global::System.Windows.Markup.XamlReader.Parse(xaml);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0001394E File Offset: 0x00011B4E
		internal static bool MayBeVisible(global::System.Windows.FrameworkElement element)
		{
			return element != null && element.Visibility != global::System.Windows.Visibility.Collapsed && element.IsVisible && element.IsLoaded;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00013971 File Offset: 0x00011B71
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

		// Token: 0x060004B0 RID: 1200 RVA: 0x000139A8 File Offset: 0x00011BA8
		internal static global::System.Windows.MessageBoxResult ShowMessageBox(global::System.Windows.DependencyObject element, string messageBoxText, string caption, global::System.Windows.MessageBoxButton button = global::System.Windows.MessageBoxButton.OK)
		{
			global::System.Windows.Window window = null;
			if (element != null)
			{
				window = global::System.Windows.Window.GetWindow(element);
			}
			if (window != null)
			{
				return global::System.Windows.MessageBox.Show(window, messageBoxText, caption, button);
			}
			return global::System.Windows.MessageBox.Show(messageBoxText, caption, button);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000139D8 File Offset: 0x00011BD8
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

		// Token: 0x060004B2 RID: 1202 RVA: 0x00013A4C File Offset: 0x00011C4C
		internal static bool IsTouchDeviceEvent(global::System.Windows.Input.MouseEventArgs args)
		{
			return false;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00013A50 File Offset: 0x00011C50
		internal static void AddHandler(global::System.Windows.UIElement eventSource, global::System.Windows.DependencyObject owner, global::System.Windows.RoutedEvent routedEvent, global::System.Delegate handler, bool handledEventsToo)
		{
			eventSource.AddHandler(routedEvent, handler, handledEventsToo);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00013A6C File Offset: 0x00011C6C
		internal static void RemoveHandler(global::System.Windows.UIElement eventSource, global::System.Windows.DependencyObject owner, global::System.Windows.RoutedEvent routedEvent, global::System.Delegate handler)
		{
			eventSource.RemoveHandler(routedEvent, handler);
		}

		// Token: 0x040001BD RID: 445
		internal const global::System.Windows.Input.ModifierKeys AllModifiers = global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift | global::System.Windows.Input.ModifierKeys.Windows;

		// Token: 0x040001BE RID: 446
		internal const global::System.Windows.Input.ModifierKeys AltModifier = global::System.Windows.Input.ModifierKeys.Alt;

		// Token: 0x040001BF RID: 447
		internal static global::System.Windows.Data.RelativeSource RelativeSourceSelf = global::System.Windows.Data.RelativeSource.Self;

		// Token: 0x040001C0 RID: 448
		internal static global::System.Windows.Data.RelativeSource RelativeSourceTemplatedParent = global::System.Windows.Data.RelativeSource.TemplatedParent;
	}
}
