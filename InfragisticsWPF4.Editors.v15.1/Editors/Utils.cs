using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000068 RID: 104
	internal static class Utils
	{
		// Token: 0x060005FE RID: 1534 RVA: 0x00018970 File Offset: 0x00016B70
		static Utils()
		{
			global::Infragistics.Windows.Editors.Utils.UIElement3DType = global::System.Type.GetType("System.Windows.UIElement3D, " + typeof(global::System.Windows.UIElement).Assembly.FullName, false);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000189CE File Offset: 0x00016BCE
		internal static bool AreEqual(object x, object y)
		{
			return x == y || (x != null && y != null && x.GetType() == y.GetType() && object.Equals(x, y));
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x000189F8 File Offset: 0x00016BF8
		internal static global::System.Exception GetTextToValueConversionError(global::System.Type targetType, string text)
		{
			bool flag = string.IsNullOrEmpty(text) || 0 == text.Trim().Length;
			string @string;
			if (typeof(global::System.DateTime) == targetType)
			{
				@string = global::Infragistics.Windows.Editors.Utils.GetString(flag ? "LMSG_EnteredDateEmpty" : "LMSG_EnteredDateInvalid", new object[]
				{
					text
				});
			}
			else if (global::Infragistics.Windows.Editors.Utils.IsNumericType(targetType))
			{
				@string = global::Infragistics.Windows.Editors.Utils.GetString(flag ? "LMSG_EnteredNumberEmpty" : "LMSG_EnteredNumberInvalid", new object[]
				{
					text
				});
			}
			else
			{
				@string = global::Infragistics.Windows.Editors.Utils.GetString(flag ? "LMSG_EnteredValueEmpty" : "LMSG_EnteredValueInvalid", new object[]
				{
					text
				});
			}
			return new global::System.Exception(@string);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00018AAC File Offset: 0x00016CAC
		internal static global::System.Windows.DependencyObject HitTest(global::System.Windows.UIElement elem, global::System.Windows.Point location, global::System.Type elementType, bool allowSubclassOfType)
		{
			global::System.Windows.Media.HitTestResult hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(elem, location);
			if (hitTestResult != null && hitTestResult.VisualHit != null)
			{
				return global::Infragistics.Windows.Utilities.GetAncestorFromType(hitTestResult.VisualHit, elementType, allowSubclassOfType, elem);
			}
			return null;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00018ADC File Offset: 0x00016CDC
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

		// Token: 0x06000603 RID: 1539 RVA: 0x00018B2C File Offset: 0x00016D2C
		internal static bool IsMouseOverButton(global::Infragistics.Windows.Editors.ValueEditor editor, global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = e.Source as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				global::System.Windows.Controls.Primitives.ButtonBase buttonBase = (global::System.Windows.Controls.Primitives.ButtonBase)global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::System.Windows.Controls.Primitives.ButtonBase), true, editor);
				if (buttonBase != null)
				{
					return true;
				}
				if (global::Infragistics.Windows.Utilities.GetAncestorFromName(dependencyObject, "PART_SpinButtons") != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00018B78 File Offset: 0x00016D78
		public static bool IsNumericType(global::System.Type type)
		{
			return (type.IsPrimitive || type == typeof(decimal)) && (type != typeof(bool) && type != typeof(char));
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00018BC8 File Offset: 0x00016DC8
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

		// Token: 0x06000606 RID: 1542 RVA: 0x00018C20 File Offset: 0x00016E20
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

		// Token: 0x06000607 RID: 1543 RVA: 0x00018C94 File Offset: 0x00016E94
		internal static void RoundAndSplitHelper(double val, int fractionDigitsToRoundTo, out double integerPart, out double fractionPart)
		{
			if (val >= -7.922816251426434E+28 && val <= 7.922816251426434E+28)
			{
				decimal value;
				decimal value2;
				global::Infragistics.Windows.Editors.Utils.RoundAndSplitHelper((decimal)val, fractionDigitsToRoundTo, out value, out value2);
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

		// Token: 0x06000608 RID: 1544 RVA: 0x00018D2C File Offset: 0x00016F2C
		internal static void SendLeftMouseButtonDownHelper(global::System.Windows.IInputElement elem, global::System.Windows.Input.MouseEventArgs templateMouseArgs)
		{
			elem.RaiseEvent(new global::System.Windows.Input.MouseButtonEventArgs(templateMouseArgs.MouseDevice, templateMouseArgs.Timestamp, global::System.Windows.Input.MouseButton.Left, templateMouseArgs.StylusDevice)
			{
				RoutedEvent = global::System.Windows.UIElement.MouseLeftButtonDownEvent
			});
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00018D64 File Offset: 0x00016F64
		private static bool IsEnumFlags(global::System.Type enumType)
		{
			object[] customAttributes = enumType.GetCustomAttributes(typeof(global::System.FlagsAttribute), true);
			return customAttributes != null && customAttributes.Length > 0;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00018D8E File Offset: 0x00016F8E
		internal static void ValidateEnum(string argumentName, global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.Windows.Editors.Utils.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(argumentName, (int)enumVal, enumType);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00018DAF File Offset: 0x00016FAF
		internal static void ValidateNull(string paramName, object val)
		{
			if (val == null)
			{
				throw new global::System.ArgumentNullException(paramName);
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00018DBB File Offset: 0x00016FBB
		internal static void ValidateNull(object val)
		{
			if (val == null)
			{
				throw new global::System.ArgumentNullException();
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00018DC8 File Offset: 0x00016FC8
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

		// Token: 0x0600060E RID: 1550 RVA: 0x00018DF8 File Offset: 0x00016FF8
		internal static double GetLineHeight(global::System.Windows.Controls.Control ctrl)
		{
			global::System.Windows.Media.FontFamily fontFamily = ctrl.FontFamily;
			double fontSize = ctrl.FontSize;
			return fontFamily.LineSpacing * fontSize;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00018E1C File Offset: 0x0001701C
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

		// Token: 0x06000610 RID: 1552 RVA: 0x00018E6D File Offset: 0x0001706D
		public static bool IsValueEmpty(object val)
		{
			return val == null || global::System.DBNull.Value == val || string.Empty == val as string || global::System.Windows.DependencyProperty.UnsetValue == val;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00018E96 File Offset: 0x00017096
		internal static bool IsValuePropertySet(global::System.Windows.DependencyProperty prop, global::System.Windows.DependencyObject obj)
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(prop, obj);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00018E9F File Offset: 0x0001709F
		internal static object DictionaryKey(object o)
		{
			if (o != null)
			{
				return o;
			}
			return global::Infragistics.Windows.Editors.Utils.NULL_KEY;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00018EAB File Offset: 0x000170AB
		internal static bool ValidateIntZeroOrMore(object value)
		{
			return value is int && (int)value >= 0;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00018EC3 File Offset: 0x000170C3
		internal static bool IsUIElementOrUIElement3D(global::System.Windows.DependencyObject d)
		{
			return d is global::System.Windows.UIElement || (d != null && null != global::Infragistics.Windows.Editors.Utils.UIElement3DType && global::Infragistics.Windows.Editors.Utils.UIElement3DType.IsAssignableFrom(d.GetType()));
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00018EF4 File Offset: 0x000170F4
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.Editors.Utils.GetString(name, null);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00018EFD File Offset: 0x000170FD
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x0400021F RID: 543
		internal const int MouseWheelScrollDelta = 120;

		// Token: 0x04000220 RID: 544
		internal static readonly object ZeroInt = 0;

		// Token: 0x04000221 RID: 545
		internal static readonly object ZeroDouble = 0.0;

		// Token: 0x04000222 RID: 546
		private static readonly global::System.Type UIElement3DType;

		// Token: 0x04000223 RID: 547
		private static readonly object NULL_KEY = new object();

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x06000618 RID: 1560
		internal delegate void MethodInvoker();

		// Token: 0x0200006A RID: 106
		internal class Range
		{
			// Token: 0x0600061B RID: 1563 RVA: 0x00018F06 File Offset: 0x00017106
			internal Range(int start, int length)
			{
				this._start = start;
				this._length = length;
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x0600061C RID: 1564 RVA: 0x00018F1C File Offset: 0x0001711C
			// (set) Token: 0x0600061D RID: 1565 RVA: 0x00018F24 File Offset: 0x00017124
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

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x0600061E RID: 1566 RVA: 0x00018F2D File Offset: 0x0001712D
			// (set) Token: 0x0600061F RID: 1567 RVA: 0x00018F35 File Offset: 0x00017135
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

			// Token: 0x04000224 RID: 548
			private int _start;

			// Token: 0x04000225 RID: 549
			private int _length;
		}
	}
}
