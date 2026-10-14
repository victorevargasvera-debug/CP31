using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Controls.Primitives;
using Infragistics.Windows.Helpers;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000047 RID: 71
	internal static class Utils
	{
		// Token: 0x06000343 RID: 835 RVA: 0x0001199A File Offset: 0x0000FB9A
		internal static bool AreEqual(object x, object y)
		{
			return x == y || (x != null && y != null && x.GetType() == y.GetType() && object.Equals(x, y));
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000119C4 File Offset: 0x0000FBC4
		internal static int CompareStrings(string x, string y, bool ignoreCase, global::System.Globalization.CultureInfo culture = null)
		{
			return (culture ?? global::System.Globalization.CultureInfo.CurrentCulture).CompareInfo.Compare(x, y, ignoreCase ? global::System.Globalization.CompareOptions.IgnoreCase : global::System.Globalization.CompareOptions.None);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000119E4 File Offset: 0x0000FBE4
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

		// Token: 0x06000346 RID: 838 RVA: 0x00011A5C File Offset: 0x0000FC5C
		internal static global::System.Windows.FrameworkElement GetAncestorFromName(global::System.Windows.DependencyObject elem, string name, global::System.Windows.FrameworkElement ceiling = null)
		{
			return global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::System.Windows.FrameworkElement>(elem, (global::System.Windows.FrameworkElement ii) => ii != null && ii.Name == name, ceiling);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00011A89 File Offset: 0x0000FC89
		internal static string GetClipboardText()
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.GetText();
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00011A90 File Offset: 0x0000FC90
		internal static global::System.Globalization.CultureInfo GetCultureInfo(global::System.Windows.FrameworkElement elem)
		{
			return global::System.Globalization.CultureInfo.CurrentCulture;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00011AB8 File Offset: 0x0000FCB8
		internal static global::System.Windows.FrameworkElement GetDescendantFromName(global::System.Windows.DependencyObject elem, string name)
		{
			return global::Infragistics.Controls.PresentationUtilities.GetVisualDescendant<global::System.Windows.FrameworkElement>(elem, (global::System.Windows.FrameworkElement ii) => ii != null && ii.Name == name, null);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00011AE8 File Offset: 0x0000FCE8
		internal static bool? GetIsInEditModeHelper(global::System.Windows.DependencyObject elem)
		{
			while (elem != null)
			{
				bool? isInEditMode = global::Infragistics.EditUtilities.GetIsInEditMode(elem);
				if (isInEditMode != null)
				{
					return isInEditMode;
				}
				elem = global::System.Windows.Media.VisualTreeHelper.GetParent(elem);
			}
			return null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00011B1D File Offset: 0x0000FD1D
		internal static string GetString(string name)
		{
			return global::Infragistics.Controls.Editors.Primitives.Utils.GetString(name, null);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00011B26 File Offset: 0x0000FD26
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00011B30 File Offset: 0x0000FD30
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

		// Token: 0x0600034E RID: 846 RVA: 0x00011BE1 File Offset: 0x0000FDE1
		internal static bool IsFocusable(global::Infragistics.Controls.Editors.ValueInput editor)
		{
			return global::Infragistics.Controls.Primitives.XamlHelper.GetFocusable(editor);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00011BEC File Offset: 0x0000FDEC
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

		// Token: 0x06000350 RID: 848 RVA: 0x00011C3C File Offset: 0x0000FE3C
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

		// Token: 0x06000351 RID: 849 RVA: 0x00011C78 File Offset: 0x0000FE78
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

		// Token: 0x06000352 RID: 850 RVA: 0x00011CCC File Offset: 0x0000FECC
		public static bool IsNumericType(global::System.Type type)
		{
			return (type.IsPrimitive || type == typeof(decimal)) && (type != typeof(bool) && type != typeof(char));
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00011D1E File Offset: 0x0000FF1E
		public static bool IsValueEmpty(object val)
		{
			return global::Infragistics.CoreUtilities.IsNull(val) || string.Empty == val as string || global::System.Windows.DependencyProperty.UnsetValue == val;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00011D44 File Offset: 0x0000FF44
		internal static bool IsValuePropertySet(global::System.Windows.DependencyProperty prop, global::System.Windows.DependencyObject obj)
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(obj, prop);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00011D50 File Offset: 0x0000FF50
		internal static void RoundAndSplitHelper(decimal val, int fractionDigitsToRoundTo, out decimal integerPart, out decimal fractionPart)
		{
			decimal num = decimal.Truncate(val);
			int value = global::System.Math.Sign(val);
			decimal d = value * (val - num);
			decimal num2 = global::System.Math.Round(d, global::System.Math.Min(fractionDigitsToRoundTo, 28));
			if (num2 >= 1.0m)
			{
				num2 = --num2;
				num += value;
			}
			integerPart = num;
			fractionPart = num2;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00011DC4 File Offset: 0x0000FFC4
		internal static void RoundAndSplitHelper(double val, int fractionDigitsToRoundTo, out double integerPart, out double fractionPart)
		{
			if (val >= -7.922816251426434E+28 && val <= 7.922816251426434E+28)
			{
				decimal value;
				decimal value2;
				global::Infragistics.Controls.Editors.Primitives.Utils.RoundAndSplitHelper((decimal)val, fractionDigitsToRoundTo, out value, out value2);
				integerPart = (double)value;
				fractionPart = (double)value2;
				return;
			}
			double num = global::System.Math.Truncate(val);
			double num2 = (double)global::System.Math.Sign(val);
			double value3 = num2 * (val - num);
			double num3 = global::System.Math.Round(value3, global::System.Math.Min(fractionDigitsToRoundTo, 15));
			if (num3 >= 1.0)
			{
				num3 -= 1.0;
				num += num2;
			}
			integerPart = num;
			fractionPart = num3;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00011E5A File Offset: 0x0001005A
		internal static bool SetClipboardText(string text)
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetText(text);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00011E62 File Offset: 0x00010062
		internal static void ShowMessageBox(global::System.Windows.DependencyObject owner, string message, string title, global::System.Windows.MessageBoxButton buttons, global::System.Windows.MessageBoxImage messageBoxImage)
		{
			global::System.Windows.MessageBox.Show(message, title, buttons, messageBoxImage);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00011E70 File Offset: 0x00010070
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

		// Token: 0x0600035A RID: 858 RVA: 0x00011EA0 File Offset: 0x000100A0
		private static bool IsEnumFlags(global::System.Type enumType)
		{
			object[] customAttributes = enumType.GetCustomAttributes(typeof(global::System.FlagsAttribute), true);
			return customAttributes != null && customAttributes.Length > 0;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00011ECA File Offset: 0x000100CA
		internal static void ValidateEnum(string argumentName, global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.Controls.Editors.Primitives.Utils.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(argumentName, (int)enumVal, enumType);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00011EEB File Offset: 0x000100EB
		internal static void ValidateNull(string paramName, object val)
		{
			if (val == null)
			{
				throw new global::System.ArgumentNullException(paramName);
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00011EF7 File Offset: 0x000100F7
		internal static void ValidateNull(object val)
		{
			if (val == null)
			{
				throw new global::System.ArgumentNullException();
			}
		}

		// Token: 0x02000048 RID: 72
		internal class Range
		{
			// Token: 0x0600035E RID: 862 RVA: 0x00011F02 File Offset: 0x00010102
			internal Range(int start, int length)
			{
				this._start = start;
				this._length = length;
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x0600035F RID: 863 RVA: 0x00011F18 File Offset: 0x00010118
			// (set) Token: 0x06000360 RID: 864 RVA: 0x00011F20 File Offset: 0x00010120
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

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x06000361 RID: 865 RVA: 0x00011F29 File Offset: 0x00010129
			// (set) Token: 0x06000362 RID: 866 RVA: 0x00011F31 File Offset: 0x00010131
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

			// Token: 0x04000128 RID: 296
			private int _start;

			// Token: 0x04000129 RID: 297
			private int _length;
		}
	}
}
