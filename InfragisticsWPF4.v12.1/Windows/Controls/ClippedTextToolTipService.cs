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
	// Token: 0x02000107 RID: 263
	public static class ClippedTextToolTipService
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x000207A8 File Offset: 0x0001E9A8
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

		// Token: 0x060009E8 RID: 2536 RVA: 0x00020991 File Offset: 0x0001EB91
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Controls.TextBlock))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Controls.ContentPresenter))]
		public static bool GetShowToolTipWhenClipped(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ShowToolTipWhenClippedProperty);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000209A3 File Offset: 0x0001EBA3
		public static void SetShowToolTipWhenClipped(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ShowToolTipWhenClippedProperty, value);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000209B6 File Offset: 0x0001EBB6
		public static global::System.Type GetAncestorTypeForToolTip(global::System.Windows.DependencyObject d)
		{
			return (global::System.Type)d.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.AncestorTypeForToolTipProperty);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000209C8 File Offset: 0x0001EBC8
		public static void SetAncestorTypeForToolTip(global::System.Windows.DependencyObject d, global::System.Type value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.AncestorTypeForToolTipProperty, value);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000209D6 File Offset: 0x0001EBD6
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Controls.TextBlock))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Controls.ContentPresenter))]
		public static global::System.Windows.ResourceKey GetToolTipStyleKey(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.ResourceKey)d.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipStyleKeyProperty);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x000209E8 File Offset: 0x0001EBE8
		public static void SetToolTipStyleKey(global::System.Windows.DependencyObject d, global::System.Windows.ResourceKey value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipStyleKeyProperty, value);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000209F6 File Offset: 0x0001EBF6
		private static global::System.Windows.UIElement GetToolTipSource(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.UIElement)d.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipSourceProperty);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00020A08 File Offset: 0x0001EC08
		private static void SetToolTipSource(global::System.Windows.DependencyObject d, global::System.Windows.UIElement value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipSourceProperty, value);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00020A16 File Offset: 0x0001EC16
		private static global::System.Windows.UIElement GetToolTipTarget(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.UIElement)d.GetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipTargetProperty);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00020A28 File Offset: 0x0001EC28
		private static void SetToolTipTarget(global::System.Windows.DependencyObject d, global::System.Windows.UIElement value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.ClippedTextToolTipService.ToolTipTargetProperty, value);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00020A36 File Offset: 0x0001EC36
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

		// Token: 0x060009F3 RID: 2547 RVA: 0x00020A70 File Offset: 0x0001EC70
		private static object CoerceCanApplyPropertyToDependencyObject(global::System.Windows.DependencyObject d, object newValue)
		{
			if (!(d is global::System.Windows.Controls.TextBlock) && !(d is global::System.Windows.Controls.ContentPresenter))
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_CannotSetClippedTextToolTipService"));
			}
			return newValue;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00020A93 File Offset: 0x0001EC93
		private static bool HasServiceToolTip(global::System.Windows.DependencyObject toolTipTarget)
		{
			return toolTipTarget != null && global::Infragistics.Windows.Controls.ClippedTextToolTipService.IsServiceToolTip(toolTipTarget.GetValue(global::System.Windows.FrameworkElement.ToolTipProperty));
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00020AAC File Offset: 0x0001ECAC
		private static bool IsServiceToolTip(object tooltip)
		{
			global::System.Windows.Controls.ToolTip toolTip = tooltip as global::System.Windows.Controls.ToolTip;
			return toolTip != null && toolTip.Tag == global::Infragistics.Windows.Controls.ClippedTextToolTipService.ServiceToolTipId;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00020AD4 File Offset: 0x0001ECD4
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

		// Token: 0x060009F7 RID: 2551 RVA: 0x00020B34 File Offset: 0x0001ED34
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

		// Token: 0x060009F8 RID: 2552 RVA: 0x00020D50 File Offset: 0x0001EF50
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

		// Token: 0x060009F9 RID: 2553 RVA: 0x00020E6C File Offset: 0x0001F06C
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

		// Token: 0x060009FA RID: 2554 RVA: 0x00020EC0 File Offset: 0x0001F0C0
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

		// Token: 0x060009FB RID: 2555 RVA: 0x00020FD8 File Offset: 0x0001F1D8
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

		// Token: 0x060009FC RID: 2556 RVA: 0x00021080 File Offset: 0x0001F280
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

		// Token: 0x060009FD RID: 2557 RVA: 0x000210D4 File Offset: 0x0001F2D4
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

		// Token: 0x060009FE RID: 2558 RVA: 0x00021184 File Offset: 0x0001F384
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

		// Token: 0x060009FF RID: 2559 RVA: 0x000211EC File Offset: 0x0001F3EC
		private static bool SkipTarget(global::System.Windows.DependencyObject d)
		{
			object obj = d.ReadLocalValue(global::System.Windows.Controls.ToolTipService.ToolTipProperty);
			return obj != global::System.Windows.DependencyProperty.UnsetValue && !global::Infragistics.Windows.Controls.ClippedTextToolTipService.IsServiceToolTip(obj);
		}

		// Token: 0x040003ED RID: 1005
		private static object ServiceToolTipId = new object();

		// Token: 0x040003EE RID: 1006
		private static bool UsingFindToolTipEvent;

		// Token: 0x040003EF RID: 1007
		public static readonly global::System.Windows.DependencyProperty ShowToolTipWhenClippedProperty = global::System.Windows.DependencyProperty.RegisterAttached("ShowToolTipWhenClipped", typeof(bool), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.OnShowToolTipWhenClippedChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.CoerceCanApplyPropertyToDependencyObject)));

		// Token: 0x040003F0 RID: 1008
		public static readonly global::System.Windows.DependencyProperty AncestorTypeForToolTipProperty = global::System.Windows.DependencyProperty.RegisterAttached("AncestorTypeForToolTip", typeof(global::System.Type), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.OnAncestorTypeForToolTipChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.CoerceCanApplyPropertyToDependencyObject)));

		// Token: 0x040003F1 RID: 1009
		public static readonly global::System.Windows.DependencyProperty ToolTipStyleKeyProperty = global::System.Windows.DependencyProperty.RegisterAttached("ToolTipStyleKey", typeof(global::System.Windows.ResourceKey), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.OnToolTipStyleKeyChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.CoerceCanApplyPropertyToDependencyObject)));

		// Token: 0x040003F2 RID: 1010
		private static readonly global::System.Windows.DependencyProperty ToolTipSourceProperty = global::System.Windows.DependencyProperty.RegisterAttached("ToolTipSource", typeof(global::System.Windows.UIElement), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040003F3 RID: 1011
		private static readonly global::System.Windows.DependencyProperty ToolTipTargetProperty = global::System.Windows.DependencyProperty.RegisterAttached("ToolTipTarget", typeof(global::System.Windows.UIElement), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040003F4 RID: 1012
		private static readonly global::System.Windows.DependencyProperty CurrentToolTipOfTargetProperty = global::System.Windows.DependencyProperty.RegisterAttached("CurrentToolTipOfTarget", typeof(object), typeof(global::Infragistics.Windows.Controls.ClippedTextToolTipService), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ClippedTextToolTipService.OnCurrentToolTipOfTargetChanged)));

		// Token: 0x02000108 RID: 264
		private class FEClass : global::System.Windows.FrameworkElement
		{
			// Token: 0x040003F5 RID: 1013
			internal static global::System.Windows.DependencyProperty DefaultStyleKeyPropertyInternal = global::System.Windows.FrameworkElement.DefaultStyleKeyProperty;
		}

		// Token: 0x02000109 RID: 265
		private class ObjectToTextFilterConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06000A02 RID: 2562 RVA: 0x0002122C File Offset: 0x0001F42C
			private ObjectToTextFilterConverter()
			{
			}

			// Token: 0x06000A03 RID: 2563 RVA: 0x00021234 File Offset: 0x0001F434
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

			// Token: 0x06000A04 RID: 2564 RVA: 0x00021270 File Offset: 0x0001F470
			object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return global::System.Windows.Data.Binding.DoNothing;
			}

			// Token: 0x040003F6 RID: 1014
			internal static readonly global::System.Windows.Data.IValueConverter Instance = new global::Infragistics.Windows.Controls.ClippedTextToolTipService.ObjectToTextFilterConverter();
		}
	}
}
