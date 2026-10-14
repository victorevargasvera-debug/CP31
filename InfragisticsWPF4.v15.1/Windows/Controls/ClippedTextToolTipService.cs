using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000125 RID: 293
	public static class ClippedTextToolTipService
	{
		// Token: 0x06000AE6 RID: 2790 RVA: 0x00024370 File Offset: 0x00022570
		static ClippedTextToolTipService()
		{
			global::System.Windows.RoutedEvent[] routedEventsForOwner = global::System.Windows.EventManager.GetRoutedEventsForOwner(typeof(global::System.Windows.Controls.ToolTipService));
			if (routedEventsForOwner != null)
			{
				foreach (global::System.Windows.RoutedEvent routedEvent in routedEventsForOwner)
				{
					if (routedEvent.Name == "FindToolTip")
					{
						global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.FrameworkElement), routedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.Controls.ClippedTextToolTipService.OnFindToolTip));
						global::Infragistics.Windows.Controls.ClippedTextToolTipService.UsingFindToolTipEvent = true;
						break;
					}
				}
			}
			if (!global::Infragistics.Windows.Controls.ClippedTextToolTipService.UsingFindToolTipEvent)
			{
				global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.FrameworkElement), global::System.Windows.Controls.ToolTipService.ToolTipOpeningEvent, new global::System.Windows.Controls.ToolTipEventHandler(global::Infragistics.Windows.Controls.ClippedTextToolTipService.OnToolTipOpening));
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00024559 File Offset: 0x00022759
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Controls.ContentPresenter))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Controls.TextBlock))]
		public static bool GetShowToolTipWhenClipped(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ShowToolTipWhenClippedProperty);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0002456B File Offset: 0x0002276B
		public static void SetShowToolTipWhenClipped(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ShowToolTipWhenClippedProperty, value);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0002457E File Offset: 0x0002277E
		public static global::System.Type GetAncestorTypeForToolTip(global::System.Windows.DependencyObject d)
		{
			return (global::System.Type)d.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.AncestorTypeForToolTipProperty);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00024590 File Offset: 0x00022790
		public static void SetAncestorTypeForToolTip(global::System.Windows.DependencyObject d, global::System.Type value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.AncestorTypeForToolTipProperty, value);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0002459E File Offset: 0x0002279E
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Controls.ContentPresenter))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Controls.TextBlock))]
		public static global::System.Windows.ResourceKey GetToolTipStyleKey(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.ResourceKey)d.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipStyleKeyProperty);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x000245B0 File Offset: 0x000227B0
		public static void SetToolTipStyleKey(global::System.Windows.DependencyObject d, global::System.Windows.ResourceKey value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipStyleKeyProperty, value);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x000245BE File Offset: 0x000227BE
		private static global::System.Windows.UIElement GetToolTipSource(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.UIElement)d.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipSourceProperty);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000245D0 File Offset: 0x000227D0
		private static void SetToolTipSource(global::System.Windows.DependencyObject d, global::System.Windows.UIElement value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipSourceProperty, value);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x000245DE File Offset: 0x000227DE
		private static global::System.Windows.UIElement GetToolTipTarget(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.UIElement)d.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipTargetProperty);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x000245F0 File Offset: 0x000227F0
		private static void SetToolTipTarget(global::System.Windows.DependencyObject d, global::System.Windows.UIElement value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipTargetProperty, value);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x000245FE File Offset: 0x000227FE
		private static void OnCurrentToolTipOfTargetChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (global::Infragistics.Windows.Controls.ClippedTextToolTipService.IsServiceToolTip(e.NewValue))
			{
				d.SetValue(global::System.Windows.Controls.ToolTipService.IsEnabledProperty, global::Infragistics.KnownBoxes.TrueBox);
				return;
			}
			if (global::Infragistics.Windows.Controls.ClippedTextToolTipService.IsServiceToolTip(e.OldValue))
			{
				d.ClearValue(global::System.Windows.Controls.ToolTipService.IsEnabledProperty);
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00024638 File Offset: 0x00022838
		private static object CoerceCanApplyPropertyToDependencyObject(global::System.Windows.DependencyObject d, object newValue)
		{
			if (!(d is global::System.Windows.Controls.TextBlock) && !(d is global::System.Windows.Controls.ContentPresenter))
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_CannotSetClippedTextToolTipService"));
			}
			return newValue;
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0002465B File Offset: 0x0002285B
		private static bool HasServiceToolTip(global::System.Windows.DependencyObject toolTipTarget)
		{
			return toolTipTarget != null && global::Infragistics.Windows.Controls.ClippedTextToolTipService.IsServiceToolTip(toolTipTarget.GetValue(global::System.Windows.FrameworkElement.ToolTipProperty));
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00024674 File Offset: 0x00022874
		private static bool IsServiceToolTip(object tooltip)
		{
			global::System.Windows.Controls.ToolTip toolTip = tooltip as global::System.Windows.Controls.ToolTip;
			return toolTip != null && toolTip.Tag == global::Infragistics.Windows.Controls.ClippedTextToolTipService.ServiceToolTipId;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0002469C File Offset: 0x0002289C
		private static bool IsToolTipNeeded(global::System.Windows.FrameworkElement toolTipSource)
		{
			global::System.Windows.Controls.TextBlock textBlock = toolTipSource as global::System.Windows.Controls.TextBlock;
			if (textBlock == null)
			{
				global::System.Windows.Controls.ContentPresenter contentPresenter = toolTipSource as global::System.Windows.Controls.ContentPresenter;
				if (contentPresenter != null && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(contentPresenter) == 1)
				{
					global::System.Windows.DependencyObject child = global::System.Windows.Media.VisualTreeHelper.GetChild(contentPresenter, 0);
					if (child is global::System.Windows.Controls.AccessText && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(child) == 1)
					{
						textBlock = (global::System.Windows.Media.VisualTreeHelper.GetChild(child, 0) as global::System.Windows.Controls.TextBlock);
					}
					else
					{
						textBlock = (child as global::System.Windows.Controls.TextBlock);
					}
				}
			}
			return global::Infragistics.Windows.Controls.ClippedTextToolTipService.IsToolTipNeeded(textBlock);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x000246FC File Offset: 0x000228FC
		private static bool IsToolTipNeeded(global::System.Windows.Controls.TextBlock tb)
		{
			if (tb == null)
			{
				return false;
			}
			bool result = false;
			global::System.Windows.Rect rect2;
			global::System.Windows.Rect rect;
			if (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(tb) == 0 || tb.ContentStart == null || tb.ContentEnd == null)
			{
				rect = (rect2 = global::System.Windows.Rect.Empty);
			}
			else
			{
				rect2 = tb.ContentStart.DocumentStart.GetCharacterRect(tb.ContentStart.LogicalDirection);
				rect = tb.ContentEnd.DocumentEnd.GetCharacterRect(tb.ContentEnd.LogicalDirection);
			}
			if (!rect2.IsEmpty && !rect.IsEmpty)
			{
				global::System.Windows.Rect rect3 = global::System.Windows.Rect.Union(rect2, rect);
				global::System.Windows.Size size = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(tb).Size;
				global::System.Windows.Thickness margin = tb.Margin;
				rect3.Width = global::System.Math.Max(0.0, rect3.Width + margin.Left + margin.Right);
				rect3.Height = global::System.Math.Max(0.0, rect3.Height + margin.Top + margin.Bottom);
				if ((!global::Infragistics.CoreUtilities.AreClose(rect3.Width, size.Width) && rect3.Width > size.Width) || (!global::Infragistics.CoreUtilities.AreClose(rect3.Height, size.Height) && rect3.Height > size.Height))
				{
					result = true;
				}
			}
			else
			{
				tb.UpdateLayout();
				if (global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutClip(tb) != null)
				{
					result = true;
				}
				else
				{
					try
					{
						global::System.Windows.Controls.AccessText accessText = global::System.Windows.Media.VisualTreeHelper.GetParent(tb) as global::System.Windows.Controls.AccessText;
						global::System.Windows.FrameworkElement element = accessText ?? tb;
						string textToFormat = (accessText != null) ? accessText.Text : tb.Text;
						global::System.Globalization.CultureInfo nonNeutralCulture = global::Infragistics.Windows.Utilities.GetNonNeutralCulture(element);
						global::System.Windows.Media.Typeface typeface = new global::System.Windows.Media.Typeface(tb.FontFamily, tb.FontStyle, tb.FontWeight, tb.FontStretch);
						if (new global::System.Windows.Media.FormattedText(textToFormat, nonNeutralCulture, tb.FlowDirection, typeface, tb.FontSize, tb.Foreground)
						{
							MaxTextWidth = tb.ActualWidth,
							Trimming = global::System.Windows.TextTrimming.None
						}.Height > tb.ActualHeight)
						{
							result = true;
						}
					}
					catch (global::System.Exception)
					{
					}
				}
			}
			return result;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00024918 File Offset: 0x00022B18
		private static void InitializeToolTip(global::System.Windows.DependencyObject toolTipSource)
		{
			global::System.Windows.Controls.ToolTip toolTip = new global::System.Windows.Controls.ToolTip();
			global::System.Windows.DependencyProperty dp = (toolTipSource is global::System.Windows.Controls.TextBlock) ? global::System.Windows.Controls.TextBlock.TextProperty : global::System.Windows.Controls.ContentPresenter.ContentProperty;
			toolTip.SetBinding(global::System.Windows.Controls.ContentControl.ContentProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(dp, global::System.Windows.Data.BindingMode.OneWay, toolTipSource, global::Infragistics.Windows.Controls.ClippedTextToolTipService.ObjectToTextFilterConverter.Instance));
			toolTip.Tag = global::Infragistics.Windows.Controls.ClippedTextToolTipService.ServiceToolTipId;
			global::System.Windows.ResourceKey resourceKey = toolTipSource.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipStyleKeyProperty) as global::System.Windows.ResourceKey;
			if (resourceKey != null)
			{
				toolTip.SetResourceReference(global::System.Windows.FrameworkElement.StyleProperty, resourceKey);
				toolTip.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.FEClass.DefaultStyleKeyPropertyInternal, resourceKey);
			}
			global::System.Type type = toolTipSource.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.AncestorTypeForToolTipProperty) as global::System.Type;
			global::System.Windows.DependencyObject dependencyObject = null;
			if (type != null)
			{
				dependencyObject = global::Infragistics.Windows.Utilities.GetAncestorFromType(toolTipSource, type, true);
			}
			if (dependencyObject == null)
			{
				dependencyObject = toolTipSource;
			}
			dependencyObject.SetValue(global::System.Windows.FrameworkElement.ToolTipProperty, toolTip);
			global::System.Windows.Data.BindingOperations.SetBinding(dependencyObject, global::Infragistics.Windows.Controls.ClippedTextToolTipService.CurrentToolTipOfTargetProperty, new global::System.Windows.Data.Binding
			{
				Source = dependencyObject,
				Path = new global::System.Windows.PropertyPath(global::System.Windows.Controls.ToolTipService.ToolTipProperty)
			});
			if (dependencyObject != toolTipSource)
			{
				global::System.Windows.UIElement toolTipSource2 = global::Infragistics.Windows.Controls.ClippedTextToolTipService.GetToolTipSource(dependencyObject);
				if (toolTipSource2 != null)
				{
					toolTipSource2.ClearValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipTargetProperty);
				}
				dependencyObject.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipSourceProperty, toolTipSource);
				toolTipSource.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipTargetProperty, dependencyObject);
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00024A34 File Offset: 0x00022C34
		private static void OnShowToolTipWhenClippedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.FrameworkElement frameworkElement = d as global::System.Windows.FrameworkElement;
			if (frameworkElement is global::System.Windows.Controls.TextBlock || frameworkElement is global::System.Windows.Controls.ContentPresenter)
			{
				if (!(bool)e.NewValue)
				{
					global::Infragistics.Windows.Controls.ClippedTextToolTipService.RemoveToolTip(frameworkElement);
					return;
				}
				if (!global::Infragistics.Windows.Controls.ClippedTextToolTipService.UsingFindToolTipEvent || global::Infragistics.Windows.Controls.ClippedTextToolTipService.GetAncestorTypeForToolTip(d) != null)
				{
					global::Infragistics.Windows.Controls.ClippedTextToolTipService.InitializeToolTip(frameworkElement);
				}
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00024A88 File Offset: 0x00022C88
		private static void OnAncestorTypeForToolTipChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = global::Infragistics.Windows.Controls.ClippedTextToolTipService.GetToolTipTarget(d);
			global::System.Windows.FrameworkElement frameworkElement = d as global::System.Windows.FrameworkElement;
			if (dependencyObject == null)
			{
				dependencyObject = frameworkElement;
			}
			global::System.Windows.Controls.ToolTip toolTip = dependencyObject.GetValue(global::System.Windows.FrameworkElement.ToolTipProperty) as global::System.Windows.Controls.ToolTip;
			if (toolTip != null)
			{
				global::System.Windows.DependencyObject dependencyObject2 = null;
				if (e.NewValue != null)
				{
					dependencyObject2 = global::Infragistics.Windows.Utilities.GetAncestorFromType(frameworkElement, (global::System.Type)e.NewValue, true);
				}
				if (dependencyObject2 == null)
				{
					dependencyObject2 = frameworkElement;
				}
				bool flag = toolTip.Tag == global::Infragistics.Windows.Controls.ClippedTextToolTipService.ServiceToolTipId;
				if (dependencyObject2 != dependencyObject)
				{
					if (flag)
					{
						dependencyObject.ClearValue(global::System.Windows.FrameworkElement.ToolTipProperty);
					}
					dependencyObject.ClearValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.CurrentToolTipOfTargetProperty);
					dependencyObject.ClearValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipSourceProperty);
					if (dependencyObject2 != frameworkElement)
					{
						dependencyObject2.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipSourceProperty, frameworkElement);
						frameworkElement.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipTargetProperty, dependencyObject2);
					}
					else
					{
						frameworkElement.ClearValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipTargetProperty);
					}
					if (flag)
					{
						dependencyObject2.SetValue(global::System.Windows.FrameworkElement.ToolTipProperty, toolTip);
						global::System.Windows.Data.BindingOperations.SetBinding(dependencyObject2, global::Infragistics.Windows.Controls.ClippedTextToolTipService.CurrentToolTipOfTargetProperty, new global::System.Windows.Data.Binding
						{
							Source = dependencyObject2,
							Path = new global::System.Windows.PropertyPath(global::System.Windows.Controls.ToolTipService.ToolTipProperty)
						});
						return;
					}
				}
			}
			else if (global::Infragistics.Windows.Controls.ClippedTextToolTipService.GetShowToolTipWhenClipped(frameworkElement) && e.NewValue != null)
			{
				global::Infragistics.Windows.Controls.ClippedTextToolTipService.InitializeToolTip(frameworkElement);
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00024BA0 File Offset: 0x00022DA0
		private static void OnFindToolTip(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = sender as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				global::System.Windows.FrameworkElement frameworkElement = (dependencyObject.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipSourceProperty) ?? dependencyObject) as global::System.Windows.FrameworkElement;
				if ((frameworkElement is global::System.Windows.Controls.TextBlock || frameworkElement is global::System.Windows.Controls.ContentPresenter) && global::Infragistics.Windows.Controls.ClippedTextToolTipService.GetShowToolTipWhenClipped(frameworkElement))
				{
					global::System.Windows.FrameworkElement frameworkElement2 = frameworkElement.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipTargetProperty) as global::System.Windows.FrameworkElement;
					if (!global::Infragistics.Windows.Controls.ClippedTextToolTipService.SkipTarget(frameworkElement2 ?? dependencyObject) && global::Infragistics.Windows.Controls.ClippedTextToolTipService.IsToolTipNeeded(frameworkElement))
					{
						if (global::Infragistics.Windows.Controls.ClippedTextToolTipService.HasServiceToolTip(dependencyObject))
						{
							dependencyObject.SetValue(global::System.Windows.Controls.ToolTipService.IsEnabledProperty, global::Infragistics.KnownBoxes.TrueBox);
							return;
						}
						global::Infragistics.Windows.Controls.ClippedTextToolTipService.InitializeToolTip(frameworkElement);
						return;
					}
					else if (global::Infragistics.Windows.Controls.ClippedTextToolTipService.HasServiceToolTip(dependencyObject))
					{
						dependencyObject.SetValue(global::System.Windows.Controls.ToolTipService.IsEnabledProperty, global::Infragistics.KnownBoxes.FalseBox);
					}
				}
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00024C48 File Offset: 0x00022E48
		private static void OnToolTipOpening(object sender, global::System.Windows.Controls.ToolTipEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = sender as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				global::System.Windows.FrameworkElement frameworkElement = (dependencyObject.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipSourceProperty) ?? dependencyObject) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null && (bool)frameworkElement.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ShowToolTipWhenClippedProperty) && !global::Infragistics.Windows.Controls.ClippedTextToolTipService.IsToolTipNeeded(frameworkElement))
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00024C9C File Offset: 0x00022E9C
		private static void OnToolTipStyleKeyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = global::Infragistics.Windows.Controls.ClippedTextToolTipService.GetToolTipTarget(d);
			if (dependencyObject == null)
			{
				dependencyObject = d;
			}
			if (dependencyObject != null)
			{
				global::System.Windows.Controls.ToolTip toolTip = dependencyObject.GetValue(global::System.Windows.FrameworkElement.ToolTipProperty) as global::System.Windows.Controls.ToolTip;
				if (toolTip != null && toolTip.Tag == global::Infragistics.Windows.Controls.ClippedTextToolTipService.ServiceToolTipId)
				{
					if (e.NewValue == null)
					{
						toolTip.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
						toolTip.ClearValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.FEClass.DefaultStyleKeyPropertyInternal);
						return;
					}
					if (e.NewValue is global::System.Windows.Style)
					{
						toolTip.SetValue(global::System.Windows.FrameworkElement.StyleProperty, e.NewValue);
						toolTip.ClearValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.FEClass.DefaultStyleKeyPropertyInternal);
						return;
					}
					toolTip.SetResourceReference(global::System.Windows.FrameworkElement.StyleProperty, e.NewValue);
					toolTip.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.FEClass.DefaultStyleKeyPropertyInternal, e.NewValue);
				}
			}
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00024D4C File Offset: 0x00022F4C
		private static void RemoveToolTip(global::System.Windows.DependencyObject toolTipSource)
		{
			global::System.Windows.DependencyObject dependencyObject = global::Infragistics.Windows.Controls.ClippedTextToolTipService.GetToolTipTarget(toolTipSource);
			if (dependencyObject != null)
			{
				dependencyObject.ClearValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipSourceProperty);
			}
			else
			{
				dependencyObject = toolTipSource;
			}
			global::System.Windows.Controls.ToolTip toolTip = dependencyObject.GetValue(global::System.Windows.FrameworkElement.ToolTipProperty) as global::System.Windows.Controls.ToolTip;
			if (toolTip != null && toolTip.Tag == global::Infragistics.Windows.Controls.ClippedTextToolTipService.ServiceToolTipId)
			{
				dependencyObject.ClearValue(global::System.Windows.FrameworkElement.ToolTipProperty);
			}
			dependencyObject.ClearValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.CurrentToolTipOfTargetProperty);
			toolTipSource.ClearValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipTargetProperty);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00024DB4 File Offset: 0x00022FB4
		private static bool SkipTarget(global::System.Windows.DependencyObject d)
		{
			object obj = d.ReadLocalValue(global::System.Windows.Controls.ToolTipService.ToolTipProperty);
			return obj != global::System.Windows.DependencyProperty.UnsetValue && !global::Infragistics.Windows.Controls.ClippedTextToolTipService.IsServiceToolTip(obj);
		}

		// Token: 0x040004A0 RID: 1184
		private static object ServiceToolTipId = new object();

		// Token: 0x040004A1 RID: 1185
		private static bool UsingFindToolTipEvent;

		// Token: 0x040004A2 RID: 1186
		public static readonly global::System.Windows.DependencyProperty ShowToolTipWhenClippedProperty = global::System.Windows.DependencyProperty.RegisterAttached("ShowToolTipWhenClipped", typeof(bool), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.OnShowToolTipWhenClippedChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.CoerceCanApplyPropertyToDependencyObject)));

		// Token: 0x040004A3 RID: 1187
		public static readonly global::System.Windows.DependencyProperty AncestorTypeForToolTipProperty = global::System.Windows.DependencyProperty.RegisterAttached("AncestorTypeForToolTip", typeof(global::System.Type), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.OnAncestorTypeForToolTipChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.CoerceCanApplyPropertyToDependencyObject)));

		// Token: 0x040004A4 RID: 1188
		public static readonly global::System.Windows.DependencyProperty ToolTipStyleKeyProperty = global::System.Windows.DependencyProperty.RegisterAttached("ToolTipStyleKey", typeof(global::System.Windows.ResourceKey), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.OnToolTipStyleKeyChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.CoerceCanApplyPropertyToDependencyObject)));

		// Token: 0x040004A5 RID: 1189
		private static readonly global::System.Windows.DependencyProperty ToolTipSourceProperty = global::System.Windows.DependencyProperty.RegisterAttached("ToolTipSource", typeof(global::System.Windows.UIElement), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040004A6 RID: 1190
		private static readonly global::System.Windows.DependencyProperty ToolTipTargetProperty = global::System.Windows.DependencyProperty.RegisterAttached("ToolTipTarget", typeof(global::System.Windows.UIElement), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040004A7 RID: 1191
		private static readonly global::System.Windows.DependencyProperty CurrentToolTipOfTargetProperty = global::System.Windows.DependencyProperty.RegisterAttached("CurrentToolTipOfTarget", typeof(object), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.OnCurrentToolTipOfTargetChanged)));

		// Token: 0x02000126 RID: 294
		private class FEClass : global::System.Windows.FrameworkElement
		{
			// Token: 0x040004A8 RID: 1192
			internal static global::System.Windows.DependencyProperty DefaultStyleKeyPropertyInternal = global::System.Windows.FrameworkElement.DefaultStyleKeyProperty;
		}

		// Token: 0x02000127 RID: 295
		private class ObjectToTextFilterConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06000B01 RID: 2817 RVA: 0x00024DF4 File Offset: 0x00022FF4
			private ObjectToTextFilterConverter()
			{
			}

			// Token: 0x06000B02 RID: 2818 RVA: 0x00024DFC File Offset: 0x00022FFC
			object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				if (value is global::System.Windows.ContentElement || value is global::System.Windows.Media.Visual || value is global::System.Windows.Media.Media3D.Visual3D)
				{
					return global::System.Windows.Data.Binding.DoNothing;
				}
				if (value is global::System.Windows.DependencyObject && global::System.Windows.LogicalTreeHelper.GetParent((global::System.Windows.DependencyObject)value) != null)
				{
					return global::System.Windows.Data.Binding.DoNothing;
				}
				return value;
			}

			// Token: 0x06000B03 RID: 2819 RVA: 0x00024E38 File Offset: 0x00023038
			object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return global::System.Windows.Data.Binding.DoNothing;
			}

			// Token: 0x040004A9 RID: 1193
			internal static readonly global::System.Windows.Data.IValueConverter Instance = new global::Infragistics.Windows.Controls.ClippedTextToolTipService.ObjectToTextFilterConverter();
		}
	}
}
