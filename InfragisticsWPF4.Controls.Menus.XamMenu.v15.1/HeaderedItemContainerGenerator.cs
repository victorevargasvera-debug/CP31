using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Controls;
using Infragistics.Controls.Menus.Primitives;

namespace Infragistics
{
	// Token: 0x02000011 RID: 17
	internal sealed class HeaderedItemContainerGenerator : global::Infragistics.IHeaderedItemContainerGenerator
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000317E File Offset: 0x0000137E
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00003186 File Offset: 0x00001386
		private global::System.Windows.Controls.ItemsControl _itemsControl { get; set; }

		// Token: 0x06000064 RID: 100 RVA: 0x0000318F File Offset: 0x0000138F
		internal HeaderedItemContainerGenerator(global::System.Windows.Controls.ItemsControl control)
		{
			this._itemsControl = control;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000031A0 File Offset: 0x000013A0
		public global::System.Windows.Controls.Panel ItemsHost
		{
			get
			{
				if (this._itemsHost == null)
				{
					if (this._itemsControl.Items.Count <= 0)
					{
						return null;
					}
					global::System.Windows.DependencyObject dependencyObject = this._itemsControl.ItemContainerGenerator.ContainerFromIndex(0);
					if (dependencyObject == null)
					{
						return null;
					}
					this._itemsHost = (global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject) as global::System.Windows.Controls.Panel);
				}
				return this._itemsHost;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000031F8 File Offset: 0x000013F8
		public global::System.Windows.Controls.ScrollViewer ScrollHost
		{
			get
			{
				if (this._scrollHost == null)
				{
					global::System.Windows.Controls.Panel itemsHost = this.ItemsHost;
					if (itemsHost != null)
					{
						global::System.Windows.DependencyObject dependencyObject = itemsHost;
						while (dependencyObject != this._itemsControl && dependencyObject != null)
						{
							global::System.Windows.Controls.ScrollViewer scrollViewer = dependencyObject as global::System.Windows.Controls.ScrollViewer;
							if (scrollViewer != null)
							{
								this._scrollHost = scrollViewer;
								break;
							}
							dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
						}
					}
				}
				return this._scrollHost;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003247 File Offset: 0x00001447
		public void OnApplyTemplate()
		{
			this._itemsHost = null;
			this._scrollHost = null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003258 File Offset: 0x00001458
		public void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item, global::System.Windows.Style parentItemContainerStyle)
		{
			global::System.Windows.Controls.Control control = element as global::System.Windows.Controls.Control;
			if (parentItemContainerStyle != null && control != null && control.Style == null)
			{
				control.SetValue(global::System.Windows.FrameworkElement.StyleProperty, parentItemContainerStyle);
			}
			global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl xamHeaderedItemsControl = element as global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl;
			if (xamHeaderedItemsControl != null)
			{
				global::Infragistics.Controls.HierarchicalDataTemplate hierarchicalTemplate = null;
				global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl xamHeaderedItemsControl2 = this._itemsControl as global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl;
				if (xamHeaderedItemsControl2 != null)
				{
					hierarchicalTemplate = xamHeaderedItemsControl2.HierarchicalItemTemplate;
					if (xamHeaderedItemsControl.DefaultItemsContainer == null && xamHeaderedItemsControl2.DefaultItemsContainer != null)
					{
						xamHeaderedItemsControl.SetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.DefaultItemsContainerProperty, xamHeaderedItemsControl.DefaultItemsContainer);
					}
				}
				global::Infragistics.HeaderedItemContainerGenerator.PrepareHeaderedItemsControlContainer(xamHeaderedItemsControl, item, this._itemsControl, parentItemContainerStyle, hierarchicalTemplate);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000032D8 File Offset: 0x000014D8
		private static bool HasDefaultValue(global::System.Windows.Controls.Control control, global::System.Windows.DependencyProperty property)
		{
			return control.ReadLocalValue(property) == global::System.Windows.DependencyProperty.UnsetValue;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000032E8 File Offset: 0x000014E8
		private static void PrepareHeaderedItemsControlContainer(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl control, object item, global::System.Windows.Controls.ItemsControl parentItemsControl, global::System.Windows.Style parentItemContainerStyle, global::Infragistics.Controls.HierarchicalDataTemplate hierarchicalTemplate)
		{
			if (control != item)
			{
				global::System.Windows.DataTemplate itemTemplate = parentItemsControl.ItemTemplate;
				if (itemTemplate != null)
				{
					control.SetValue(global::System.Windows.Controls.ItemsControl.ItemTemplateProperty, itemTemplate);
				}
				if (parentItemContainerStyle != null && global::Infragistics.HeaderedItemContainerGenerator.HasDefaultValue(control, global::System.Windows.Controls.ItemsControl.ItemContainerStyleProperty))
				{
					control.SetValue(global::System.Windows.Controls.ItemsControl.ItemContainerStyleProperty, parentItemContainerStyle);
				}
				if (control.HeaderIsItem || global::Infragistics.HeaderedItemContainerGenerator.HasDefaultValue(control, global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HeaderProperty))
				{
					if (!string.IsNullOrEmpty(control.DisplayMemberPath))
					{
						global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(control.DisplayMemberPath);
						binding.Source = item;
						binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
						control.SetBinding(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HeaderProperty, binding);
					}
					else if (!string.IsNullOrEmpty(parentItemsControl.DisplayMemberPath))
					{
						global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding(parentItemsControl.DisplayMemberPath);
						binding2.Source = item;
						binding2.Mode = global::System.Windows.Data.BindingMode.OneWay;
						control.SetBinding(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HeaderProperty, binding2);
					}
					else
					{
						control.Header = item;
					}
					control.HeaderIsItem = true;
				}
				if (itemTemplate != null)
				{
					control.SetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HeaderTemplateProperty, itemTemplate);
				}
				if (parentItemContainerStyle != null && control.Style == null)
				{
					control.SetValue(global::System.Windows.FrameworkElement.StyleProperty, parentItemContainerStyle);
				}
				if (hierarchicalTemplate != null)
				{
					if (hierarchicalTemplate.ItemsSource != null && global::Infragistics.HeaderedItemContainerGenerator.HasDefaultValue(control, global::System.Windows.Controls.ItemsControl.ItemsSourceProperty))
					{
						control.SetBinding(global::System.Windows.Controls.ItemsControl.ItemsSourceProperty, new global::System.Windows.Data.Binding
						{
							Converter = hierarchicalTemplate.ItemsSource.Converter,
							ConverterCulture = hierarchicalTemplate.ItemsSource.ConverterCulture,
							ConverterParameter = hierarchicalTemplate.ItemsSource.ConverterParameter,
							Mode = hierarchicalTemplate.ItemsSource.Mode,
							NotifyOnValidationError = hierarchicalTemplate.ItemsSource.NotifyOnValidationError,
							Path = hierarchicalTemplate.ItemsSource.Path,
							Source = control.Header,
							ValidatesOnExceptions = hierarchicalTemplate.ItemsSource.ValidatesOnExceptions
						});
					}
					if (hierarchicalTemplate.HierarchicalItemTemplate != null)
					{
						control.SetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HierarchicalItemTemplateProperty, hierarchicalTemplate.HierarchicalItemTemplate);
					}
					else
					{
						control.SetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HierarchicalItemTemplateProperty, hierarchicalTemplate);
					}
					if (hierarchicalTemplate.ItemTemplate != null && control.ItemTemplate == itemTemplate)
					{
						control.ClearValue(global::System.Windows.Controls.ItemsControl.ItemTemplateProperty);
						if (hierarchicalTemplate.ItemTemplate != null)
						{
							control.ItemTemplate = hierarchicalTemplate.ItemTemplate;
						}
					}
					if (hierarchicalTemplate.ItemContainerStyle != null && control.ItemContainerStyle == parentItemContainerStyle)
					{
						control.ClearValue(global::System.Windows.Controls.ItemsControl.ItemContainerStyleProperty);
						if (hierarchicalTemplate.ItemContainerStyle != null)
						{
							control.ItemContainerStyle = hierarchicalTemplate.ItemContainerStyle;
						}
					}
					if (control.DefaultItemsContainer == null && hierarchicalTemplate.DefaultItemsContainer != null)
					{
						control.SetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.DefaultItemsContainerProperty, hierarchicalTemplate.DefaultItemsContainer);
					}
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000354F File Offset: 0x0000174F
		public void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003554 File Offset: 0x00001754
		public void UpdateItemContainerStyle(global::System.Windows.Style itemContainerStyle)
		{
			if (itemContainerStyle == null)
			{
				return;
			}
			global::System.Windows.Controls.Panel itemsHost = this.ItemsHost;
			if (itemsHost == null || itemsHost.Children == null)
			{
				return;
			}
			foreach (object obj in itemsHost.Children)
			{
				global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
				global::System.Windows.FrameworkElement frameworkElement = uielement as global::System.Windows.FrameworkElement;
				frameworkElement.Style = itemContainerStyle;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000035D0 File Offset: 0x000017D0
		public void ScrollIntoView(global::System.Windows.FrameworkElement element)
		{
			global::System.Windows.Controls.ScrollViewer scrollHost = this.ScrollHost;
			if (scrollHost == null)
			{
				return;
			}
			global::System.Windows.Media.GeneralTransform generalTransform = null;
			try
			{
				generalTransform = element.TransformToVisual(scrollHost);
			}
			catch (global::System.InvalidOperationException)
			{
				return;
			}
			global::System.Windows.Rect rect = new global::System.Windows.Rect(generalTransform.Transform(default(global::System.Windows.Point)), generalTransform.Transform(new global::System.Windows.Point(element.ActualWidth, element.ActualHeight)));
			double num = scrollHost.VerticalOffset;
			double num2 = 0.0;
			double viewportHeight = scrollHost.ViewportHeight;
			double bottom = rect.Bottom;
			if (viewportHeight < bottom)
			{
				num2 = bottom - viewportHeight;
				num += num2;
			}
			double top = rect.Top;
			if (top - num2 < 0.0)
			{
				num -= num2 - top;
			}
			scrollHost.ScrollToVerticalOffset(num);
			double num3 = scrollHost.HorizontalOffset;
			double num4 = 0.0;
			double viewportWidth = scrollHost.ViewportWidth;
			double right = rect.Right;
			if (viewportWidth < right)
			{
				num4 = right - viewportWidth;
				num3 += num4;
			}
			double left = rect.Left;
			if (left - num4 < 0.0)
			{
				num3 -= num4 - left;
			}
			scrollHost.ScrollToHorizontalOffset(num3);
		}

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Controls.Panel _itemsHost;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Controls.ScrollViewer _scrollHost;
	}
}
