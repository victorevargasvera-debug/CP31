using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Infragistics.Controls.Primitives;
using Infragistics.Windows.Helpers;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000048 RID: 72
	internal static class Utils
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00011BAA File Offset: 0x0000FDAA
		internal static bool AreEqual(object x, object y)
		{
			return x == y || (x != null && y != null && x.GetType() == y.GetType() && object.Equals(x, y));
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00011BD4 File Offset: 0x0000FDD4
		internal static int CompareStrings(string x, string y, bool ignoreCase, global::System.Globalization.CultureInfo culture = null)
		{
			return string.Compare(x, y, culture ?? global::System.Globalization.CultureInfo.CurrentCulture, ignoreCase ? global::System.Globalization.CompareOptions.IgnoreCase : global::System.Globalization.CompareOptions.None);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00011BF0 File Offset: 0x0000FDF0
		public static bool Exists(global::System.Collections.IEnumerable e, object item)
		{
			foreach (object objB in e)
			{
				if (object.Equals(item, objB))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00011C68 File Offset: 0x0000FE68
		internal static global::System.Windows.FrameworkElement GetAncestorFromName(global::System.Windows.DependencyObject elem, string name, global::System.Windows.FrameworkElement ceiling = null)
		{
			return global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::System.Windows.FrameworkElement>(elem, (global::System.Windows.FrameworkElement ii) => ii != null && ii.Name == name, ceiling);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00011C95 File Offset: 0x0000FE95
		internal static string GetClipboardText()
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.GetText();
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00011C9C File Offset: 0x0000FE9C
		internal static global::System.Globalization.CultureInfo GetCultureInfo(global::System.Windows.FrameworkElement elem)
		{
			return global::System.Globalization.CultureInfo.CurrentCulture;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00011CC4 File Offset: 0x0000FEC4
		internal static global::System.Windows.FrameworkElement GetDescendantFromName(global::System.Windows.DependencyObject elem, string name)
		{
			return global::Infragistics.Controls.PresentationUtilities.GetVisualDescendant<global::System.Windows.FrameworkElement>(elem, (global::System.Windows.FrameworkElement ii) => ii != null && ii.Name == name, null);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00011CF1 File Offset: 0x0000FEF1
		internal static string GetString(string name)
		{
			return global::Infragistics.Controls.Editors.Primitives.Utils.GetString(name, null);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00011CFA File Offset: 0x0000FEFA
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00011D04 File Offset: 0x0000FF04
		internal static global::System.Exception GetTextToValueConversionError(global::System.Type targetType, string text)
		{
			bool flag = string.IsNullOrEmpty(text) || 0 == text.Trim().Length;
			string @string;
			if (typeof(global::System.DateTime) == targetType)
			{
				@string = global::Infragistics.Controls.Editors.Primitives.Utils.GetString(flag ? "LMSG_EnteredDateEmpty" : "LMSG_EnteredDateInvalid", new object[]
				{
					text
				});
			}
			else if (global::Infragistics.Controls.Editors.Primitives.Utils.IsNumericType(targetType))
			{
				@string = global::Infragistics.Controls.Editors.Primitives.Utils.GetString(flag ? "LMSG_EnteredNumberEmpty" : "LMSG_EnteredNumberInvalid", new object[]
				{
					text
				});
			}
			else
			{
				@string = global::Infragistics.Controls.Editors.Primitives.Utils.GetString(flag ? "LMSG_EnteredValueEmpty" : "LMSG_EnteredValueInvalid", new object[]
				{
					text
				});
			}
			return new global::System.Exception(@string);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00011DB5 File Offset: 0x0000FFB5
		internal static bool IsFocusable(global::Infragistics.Controls.Editors.ValueInput editor)
		{
			return global::Infragistics.Controls.Primitives.XamlHelper.GetFocusable(editor);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		internal static bool IsInfinityOrNaN(object val)
		{
			if (val is double)
			{
				double d = (double)val;
				return double.IsNaN(d) || double.IsInfinity(d);
			}
			if (val is float)
			{
				float f = (float)val;
				return float.IsNaN(f) || float.IsInfinity(f);
			}
			return false;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00011E10 File Offset: 0x00010010
		internal static bool IsMouseOverButton(global::Infragistics.Controls.Editors.ValueInput editor, global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				global::System.Windows.Controls.Primitives.ButtonBase visualAncestor = global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::System.Windows.Controls.Primitives.ButtonBase>(dependencyObject, null, editor);
				if (visualAncestor != null)
				{
					return true;
				}
				if (global::Infragistics.Controls.Editors.Primitives.Utils.GetAncestorFromName(dependencyObject, "PART_SpinButtons", null) != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00011E4C File Offset: 0x0001004C
		public static bool IsMouseOverElement(global::System.Windows.DependencyObject element, global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.FrameworkElement frameworkElement = element as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				global::System.Windows.Point position = e.GetPosition(frameworkElement);
				global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, frameworkElement.ActualWidth, frameworkElement.ActualHeight);
				if (rect.Contains(position))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00011EA0 File Offset: 0x000100A0
		public static bool IsNumericType(global::System.Type type)
		{
			return (type.IsPrimitive || type == typeof(decimal)) && (type != typeof(bool) && type != typeof(char));
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00011EF0 File Offset: 0x000100F0
		public static bool IsValueEmpty(object val)
		{
			return val == null || global::System.DBNull.Value == val || string.Empty == val as string || global::System.Windows.DependencyProperty.UnsetValue == val;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00011F19 File Offset: 0x00010119
		internal static bool IsValuePropertySet(global::System.Windows.DependencyProperty prop, global::System.Windows.DependencyObject obj)
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(obj, prop);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00011F22 File Offset: 0x00010122
		internal static bool SetClipboardText(string text)
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetText(text);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00011F2A File Offset: 0x0001012A
		internal static void ShowMessageBox(global::System.Windows.DependencyObject owner, string message, string title, global::System.Windows.MessageBoxButton buttons, global::System.Windows.MessageBoxImage messageBoxImage)
		{
			global::System.Windows.MessageBox.Show(message, title, buttons, messageBoxImage);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00011F38 File Offset: 0x00010138
		internal static global::System.Windows.TextAlignment ToTextAlignment(global::System.Windows.HorizontalAlignment horizAlign)
		{
			switch (horizAlign)
			{
			case global::System.Windows.HorizontalAlignment.Center:
				return global::System.Windows.TextAlignment.Center;
			case global::System.Windows.HorizontalAlignment.Right:
				return global::System.Windows.TextAlignment.Right;
			case global::System.Windows.HorizontalAlignment.Stretch:
				return global::System.Windows.TextAlignment.Justify;
			}
			return global::System.Windows.TextAlignment.Left;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00011F68 File Offset: 0x00010168
		private static bool IsEnumFlags(global::System.Type enumType)
		{
			object[] customAttributes = enumType.GetCustomAttributes(typeof(global::System.FlagsAttribute), true);
			return customAttributes != null && customAttributes.Length > 0;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00011F92 File Offset: 0x00010192
		internal static void ValidateEnum(string argumentName, global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.Controls.Editors.Primitives.Utils.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(argumentName, (int)enumVal, enumType);
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00011FB3 File Offset: 0x000101B3
		internal static void ValidateNull(string paramName, object val)
		{
			if (val == null)
			{
				throw new global::System.ArgumentNullException(paramName);
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00011FBF File Offset: 0x000101BF
		internal static void ValidateNull(object val)
		{
			if (val == null)
			{
				throw new global::System.ArgumentNullException();
			}
		}

		// Token: 0x02000049 RID: 73
		internal class Range
		{
			// Token: 0x06000359 RID: 857 RVA: 0x00011FCA File Offset: 0x000101CA
			internal Range(int start, int length)
			{
				this._start = start;
				this._length = length;
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x0600035A RID: 858 RVA: 0x00011FE0 File Offset: 0x000101E0
			// (set) Token: 0x0600035B RID: 859 RVA: 0x00011FE8 File Offset: 0x000101E8
			internal int Start
			{
				get
				{
					return this._start;
				}
				set
				{
					this._start = value;
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x0600035C RID: 860 RVA: 0x00011FF1 File Offset: 0x000101F1
			// (set) Token: 0x0600035D RID: 861 RVA: 0x00011FF9 File Offset: 0x000101F9
			internal int Length
			{
				get
				{
					return this._length;
				}
				set
				{
					this._length = value;
				}
			}

			// Token: 0x04000123 RID: 291
			private int _start;

			// Token: 0x04000124 RID: 292
			private int _length;
		}
	}
}
