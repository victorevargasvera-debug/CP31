using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.Windows.Themes;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000A7 RID: 167
	public class XamlHelper : global::System.Windows.DependencyObject
	{
		// Token: 0x06000637 RID: 1591 RVA: 0x0001726F File Offset: 0x0001546F
		private XamlHelper()
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00017277 File Offset: 0x00015477
		public static bool GetCanContentScroll(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.CanContentScrollProperty);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00017289 File Offset: 0x00015489
		public static void SetCanContentScroll(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.CanContentScrollProperty, value);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001729C File Offset: 0x0001549C
		public static bool GetFocusable(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.FocusableProperty);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000172AE File Offset: 0x000154AE
		public static void SetFocusable(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.FocusableProperty, value);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000172C1 File Offset: 0x000154C1
		public static bool GetStaysOpen(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.StaysOpenProperty);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000172D3 File Offset: 0x000154D3
		public static void SetStaysOpen(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.StaysOpenProperty, value);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000172E6 File Offset: 0x000154E6
		public static bool GetAllowsTransparency(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.AllowsTransparencyProperty);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000172F8 File Offset: 0x000154F8
		public static void SetAllowsTransparency(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.AllowsTransparencyProperty, value);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001730B File Offset: 0x0001550B
		public static void SetIsExcludedFromWash(global::System.Windows.DependencyObject element, bool value)
		{
			global::Infragistics.Windows.Themes.ResourceWasher.SetIsExcludedFromWash(element, value);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00017314 File Offset: 0x00015514
		public static bool GetIsExcludedFromWash(global::System.Windows.DependencyObject element)
		{
			return global::Infragistics.Windows.Themes.ResourceWasher.GetIsExcludedFromWash(element);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0001731C File Offset: 0x0001551C
		public static void SetWashGroup(global::System.Windows.DependencyObject element, string value)
		{
			global::Infragistics.Windows.Themes.ResourceWasher.SetWashGroup(element, value);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00017325 File Offset: 0x00015525
		public static string GetWashGroup(global::System.Windows.DependencyObject element)
		{
			return global::Infragistics.Windows.Themes.ResourceWasher.GetWashGroup(element);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0001732D File Offset: 0x0001552D
		public static bool GetSnapsToDevicePixels(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.SnapsToDevicePixelsProperty);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0001733F File Offset: 0x0001553F
		public static void SetSnapsToDevicePixels(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.SnapsToDevicePixelsProperty, value);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00017352 File Offset: 0x00015552
		public static global::System.Windows.Input.KeyboardNavigationMode GetTabNavigation(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Input.KeyboardNavigationMode)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.TabNavigationProperty);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00017364 File Offset: 0x00015564
		public static void SetTabNavigation(global::System.Windows.DependencyObject d, global::System.Windows.Input.KeyboardNavigationMode value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.TabNavigationProperty, value);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00017377 File Offset: 0x00015577
		private static void OnUpdateBindingOnTextPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (d is global::System.Windows.Controls.TextBox)
			{
				new global::Infragistics.Controls.Primitives.XamlHelper.TextBoxTextChangedListener((global::System.Windows.Controls.TextBox)d);
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0001738D File Offset: 0x0001558D
		public static bool GetUpdateBindingOnTextPropertyChanged(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.UpdateBindingOnTextPropertyChangedProperty);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001739F File Offset: 0x0001559F
		public static void SetUpdateBindingOnTextPropertyChanged(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.UpdateBindingOnTextPropertyChangedProperty, value);
		}

		// Token: 0x040002FD RID: 765
		public static readonly global::System.Windows.DependencyProperty CanContentScrollProperty = global::System.Windows.Controls.ScrollViewer.CanContentScrollProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x040002FE RID: 766
		public static readonly global::System.Windows.DependencyProperty FocusableProperty = global::System.Windows.UIElement.FocusableProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x040002FF RID: 767
		public static readonly global::System.Windows.DependencyProperty StaysOpenProperty = global::System.Windows.Controls.Primitives.Popup.StaysOpenProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x04000300 RID: 768
		public static readonly global::System.Windows.DependencyProperty AllowsTransparencyProperty = global::System.Windows.Controls.Primitives.Popup.AllowsTransparencyProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x04000301 RID: 769
		public static readonly global::System.Windows.DependencyProperty IsExcludedFromWashProperty = global::Infragistics.Windows.Themes.ResourceWasher.IsExcludedFromWashProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x04000302 RID: 770
		public static readonly global::System.Windows.DependencyProperty WashGroupProperty = global::Infragistics.Windows.Themes.ResourceWasher.WashGroupProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x04000303 RID: 771
		public static readonly global::System.Windows.DependencyProperty SnapsToDevicePixelsProperty = global::System.Windows.UIElement.SnapsToDevicePixelsProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x04000304 RID: 772
		public static readonly global::System.Windows.DependencyProperty TabNavigationProperty = global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x04000305 RID: 773
		public static readonly global::System.Windows.DependencyProperty UpdateBindingOnTextPropertyChangedProperty = global::Infragistics.DependencyPropertyUtilities.RegisterAttached("UpdateBindingOnTextPropertyChanged", typeof(bool), typeof(global::Infragistics.Controls.Primitives.XamlHelper), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.XamlHelper.OnUpdateBindingOnTextPropertyChanged)));

		// Token: 0x020000A8 RID: 168
		private class TextBoxTextChangedListener
		{
			// Token: 0x0600064B RID: 1611 RVA: 0x000173B2 File Offset: 0x000155B2
			internal TextBoxTextChangedListener(global::System.Windows.Controls.TextBox textBox)
			{
				textBox.TextChanged += global::Infragistics.Controls.Primitives.XamlHelper.TextBoxTextChangedListener.TextBoxTextChanged;
			}

			// Token: 0x0600064C RID: 1612 RVA: 0x000173CC File Offset: 0x000155CC
			private static void TextBoxTextChanged(object sender, global::System.Windows.Controls.TextChangedEventArgs e)
			{
				if (sender is global::System.Windows.DependencyObject)
				{
					global::System.Windows.Data.BindingExpression bindingExpression = global::System.Windows.Data.BindingOperations.GetBindingExpression(sender as global::System.Windows.DependencyObject, global::System.Windows.Controls.TextBox.TextProperty);
					if (bindingExpression != null && (bindingExpression.ParentBinding.Mode == global::System.Windows.Data.BindingMode.Default || bindingExpression.ParentBinding.Mode == global::System.Windows.Data.BindingMode.TwoWay || bindingExpression.ParentBinding.Mode == global::System.Windows.Data.BindingMode.OneWayToSource))
					{
						bindingExpression.UpdateSource();
					}
				}
			}
		}
	}
}
