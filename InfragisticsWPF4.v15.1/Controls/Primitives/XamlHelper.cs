using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.Windows.Themes;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000C1 RID: 193
	public class XamlHelper : global::System.Windows.DependencyObject
	{
		// Token: 0x0600071B RID: 1819 RVA: 0x0001A98F File Offset: 0x00018B8F
		private XamlHelper()
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0001A997 File Offset: 0x00018B97
		public static bool GetCanContentScroll(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.CanContentScrollProperty);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0001A9A9 File Offset: 0x00018BA9
		public static void SetCanContentScroll(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.CanContentScrollProperty, value);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001A9BC File Offset: 0x00018BBC
		public static bool GetFocusable(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.FocusableProperty);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0001A9CE File Offset: 0x00018BCE
		public static void SetFocusable(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.FocusableProperty, value);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0001A9E1 File Offset: 0x00018BE1
		public static bool GetStaysOpen(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.StaysOpenProperty);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0001A9F3 File Offset: 0x00018BF3
		public static void SetStaysOpen(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.StaysOpenProperty, value);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0001AA06 File Offset: 0x00018C06
		public static bool GetAllowsTransparency(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.AllowsTransparencyProperty);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0001AA18 File Offset: 0x00018C18
		public static void SetAllowsTransparency(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.AllowsTransparencyProperty, value);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0001AA2B File Offset: 0x00018C2B
		public static void SetIsExcludedFromWash(global::System.Windows.DependencyObject element, bool value)
		{
			global::Infragistics.Windows.Themes.ResourceWasher.SetIsExcludedFromWash(element, value);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0001AA34 File Offset: 0x00018C34
		public static bool GetIsExcludedFromWash(global::System.Windows.DependencyObject element)
		{
			return global::Infragistics.Windows.Themes.ResourceWasher.GetIsExcludedFromWash(element);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0001AA3C File Offset: 0x00018C3C
		public static void SetWashGroup(global::System.Windows.DependencyObject element, string value)
		{
			global::Infragistics.Windows.Themes.ResourceWasher.SetWashGroup(element, value);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0001AA45 File Offset: 0x00018C45
		public static string GetWashGroup(global::System.Windows.DependencyObject element)
		{
			return global::Infragistics.Windows.Themes.ResourceWasher.GetWashGroup(element);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0001AA4D File Offset: 0x00018C4D
		public static bool GetSnapsToDevicePixels(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.SnapsToDevicePixelsProperty);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0001AA5F File Offset: 0x00018C5F
		public static void SetSnapsToDevicePixels(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.SnapsToDevicePixelsProperty, value);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0001AA72 File Offset: 0x00018C72
		public static global::System.Windows.Input.KeyboardNavigationMode GetTabNavigation(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Input.KeyboardNavigationMode)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.TabNavigationProperty);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0001AA84 File Offset: 0x00018C84
		public static void SetTabNavigation(global::System.Windows.DependencyObject d, global::System.Windows.Input.KeyboardNavigationMode value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.TabNavigationProperty, value);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001AA97 File Offset: 0x00018C97
		private static void OnUpdateBindingOnTextPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (d is global::System.Windows.Controls.TextBox)
			{
				new global::Infragistics.Controls.Primitives.XamlHelper.TextBoxTextChangedListener((global::System.Windows.Controls.TextBox)d);
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0001AAAD File Offset: 0x00018CAD
		public static bool GetUpdateBindingOnTextPropertyChanged(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Controls.Primitives.XamlHelper.UpdateBindingOnTextPropertyChangedProperty);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0001AABF File Offset: 0x00018CBF
		public static void SetUpdateBindingOnTextPropertyChanged(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Controls.Primitives.XamlHelper.UpdateBindingOnTextPropertyChangedProperty, value);
		}

		// Token: 0x0400039F RID: 927
		public static readonly global::System.Windows.DependencyProperty CanContentScrollProperty = global::System.Windows.Controls.ScrollViewer.CanContentScrollProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x040003A0 RID: 928
		public static readonly global::System.Windows.DependencyProperty FocusableProperty = global::System.Windows.UIElement.FocusableProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x040003A1 RID: 929
		public static readonly global::System.Windows.DependencyProperty StaysOpenProperty = global::System.Windows.Controls.Primitives.Popup.StaysOpenProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x040003A2 RID: 930
		public static readonly global::System.Windows.DependencyProperty AllowsTransparencyProperty = global::System.Windows.Controls.Primitives.Popup.AllowsTransparencyProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x040003A3 RID: 931
		public static readonly global::System.Windows.DependencyProperty IsExcludedFromWashProperty = global::Infragistics.Windows.Themes.ResourceWasher.IsExcludedFromWashProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x040003A4 RID: 932
		public static readonly global::System.Windows.DependencyProperty WashGroupProperty = global::Infragistics.Windows.Themes.ResourceWasher.WashGroupProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x040003A5 RID: 933
		public static readonly global::System.Windows.DependencyProperty SnapsToDevicePixelsProperty = global::System.Windows.UIElement.SnapsToDevicePixelsProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x040003A6 RID: 934
		public static readonly global::System.Windows.DependencyProperty TabNavigationProperty = global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.AddOwner(typeof(global::Infragistics.Controls.Primitives.XamlHelper));

		// Token: 0x040003A7 RID: 935
		public static readonly global::System.Windows.DependencyProperty UpdateBindingOnTextPropertyChangedProperty = global::Infragistics.DependencyPropertyUtilities.RegisterAttached("UpdateBindingOnTextPropertyChanged", typeof(bool), typeof(global::Infragistics.Controls.Primitives.XamlHelper), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.XamlHelper.OnUpdateBindingOnTextPropertyChanged)));

		// Token: 0x020000C2 RID: 194
		private class TextBoxTextChangedListener
		{
			// Token: 0x0600072F RID: 1839 RVA: 0x0001AAD2 File Offset: 0x00018CD2
			internal TextBoxTextChangedListener(global::System.Windows.Controls.TextBox textBox)
			{
				textBox.TextChanged += global::Infragistics.Controls.Primitives.XamlHelper.TextBoxTextChangedListener.TextBoxTextChanged;
			}

			// Token: 0x06000730 RID: 1840 RVA: 0x0001AAEC File Offset: 0x00018CEC
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
