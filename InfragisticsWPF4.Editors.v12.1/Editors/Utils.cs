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
	// Token: 0x02000062 RID: 98
	internal static class Utils
	{
		// Token: 0x060005A8 RID: 1448 RVA: 0x000173C0 File Offset: 0x000155C0
		static Utils()
		{
			global::Infragistics.Windows.Editors.Utils.UIElement3DType = global::System.Type.GetType("System.Windows.UIElement3D, " + typeof(global::System.Windows.UIElement).Assembly.FullName, false);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0001741E File Offset: 0x0001561E
		internal static bool AreEqual(object x, object y)
		{
			return x == y || (x != null && y != null && x.GetType() == y.GetType() && object.Equals(x, y));
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00017448 File Offset: 0x00015648
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

		// Token: 0x060005AB RID: 1451 RVA: 0x000174FC File Offset: 0x000156FC
		internal static global::System.Windows.DependencyObject HitTest(global::System.Windows.UIElement elem, global::System.Windows.Point location, global::System.Type elementType, bool allowSubclassOfType)
		{
			global::System.Windows.Media.HitTestResult hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(elem, location);
			if (hitTestResult != null && hitTestResult.VisualHit != null)
			{
				return global::Infragistics.Windows.Utilities.GetAncestorFromType(hitTestResult.VisualHit, elementType, allowSubclassOfType, elem);
			}
			return null;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0001752C File Offset: 0x0001572C
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

		// Token: 0x060005AD RID: 1453 RVA: 0x0001757C File Offset: 0x0001577C
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

		// Token: 0x060005AE RID: 1454 RVA: 0x000175C8 File Offset: 0x000157C8
		public static bool IsNumericType(global::System.Type type)
		{
			return (type.IsPrimitive || type == typeof(decimal)) && (type != typeof(bool) && type != typeof(char));
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00017618 File Offset: 0x00015818
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

		// Token: 0x060005B0 RID: 1456 RVA: 0x00017670 File Offset: 0x00015870
		internal static void SendLeftMouseButtonDownHelper(global::System.Windows.IInputElement elem, global::System.Windows.Input.MouseEventArgs templateMouseArgs)
		{
			elem.RaiseEvent(new global::System.Windows.Input.MouseButtonEventArgs(templateMouseArgs.MouseDevice, templateMouseArgs.Timestamp, global::System.Windows.Input.MouseButton.Left, templateMouseArgs.StylusDevice)
			{
				RoutedEvent = global::System.Windows.UIElement.MouseLeftButtonDownEvent
			});
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000176A8 File Offset: 0x000158A8
		private static bool IsEnumFlags(global::System.Type enumType)
		{
			object[] customAttributes = enumType.GetCustomAttributes(typeof(global::System.FlagsAttribute), true);
			return customAttributes != null && customAttributes.Length > 0;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000176D2 File Offset: 0x000158D2
		internal static void ValidateEnum(string argumentName, global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.Windows.Editors.Utils.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(argumentName, (int)enumVal, enumType);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000176F3 File Offset: 0x000158F3
		internal static void ValidateNull(string paramName, object val)
		{
			if (val == null)
			{
				throw new global::System.ArgumentNullException(paramName);
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x000176FF File Offset: 0x000158FF
		internal static void ValidateNull(object val)
		{
			if (val == null)
			{
				throw new global::System.ArgumentNullException();
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0001770C File Offset: 0x0001590C
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

		// Token: 0x060005B6 RID: 1462 RVA: 0x0001773C File Offset: 0x0001593C
		internal static double GetLineHeight(global::System.Windows.Controls.Control ctrl)
		{
			global::System.Windows.Media.FontFamily fontFamily = ctrl.FontFamily;
			double fontSize = ctrl.FontSize;
			return fontFamily.LineSpacing * fontSize;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00017760 File Offset: 0x00015960
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

		// Token: 0x060005B8 RID: 1464 RVA: 0x000177B1 File Offset: 0x000159B1
		public static bool IsValueEmpty(object val)
		{
			return val == null || global::System.DBNull.Value == val || string.Empty == val as string || global::System.Windows.DependencyProperty.UnsetValue == val;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000177DA File Offset: 0x000159DA
		internal static bool IsValuePropertySet(global::System.Windows.DependencyProperty prop, global::System.Windows.DependencyObject obj)
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(prop, obj);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000177E3 File Offset: 0x000159E3
		internal static object DictionaryKey(object o)
		{
			if (o != null)
			{
				return o;
			}
			return global::Infragistics.Windows.Editors.Utils.NULL_KEY;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000177EF File Offset: 0x000159EF
		internal static bool ValidateIntZeroOrMore(object value)
		{
			return value is int && (int)value >= 0;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00017807 File Offset: 0x00015A07
		internal static bool IsUIElementOrUIElement3D(global::System.Windows.DependencyObject d)
		{
			return d is global::System.Windows.UIElement || (d != null && null != global::Infragistics.Windows.Editors.Utils.UIElement3DType && global::Infragistics.Windows.Editors.Utils.UIElement3DType.IsAssignableFrom(d.GetType()));
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00017838 File Offset: 0x00015A38
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.Editors.Utils.GetString(name, null);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00017841 File Offset: 0x00015A41
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x040001EC RID: 492
		internal const int MouseWheelScrollDelta = 120;

		// Token: 0x040001ED RID: 493
		internal static readonly object ZeroInt = 0;

		// Token: 0x040001EE RID: 494
		internal static readonly object ZeroDouble = 0.0;

		// Token: 0x040001EF RID: 495
		private static readonly global::System.Type UIElement3DType;

		// Token: 0x040001F0 RID: 496
		private static readonly object NULL_KEY = new object();

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060005C0 RID: 1472
		internal delegate void MethodInvoker();

		// Token: 0x02000064 RID: 100
		internal class Range
		{
			// Token: 0x060005C3 RID: 1475 RVA: 0x0001784A File Offset: 0x00015A4A
			internal Range(int start, int length)
			{
				this._start = start;
				this._length = length;
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00017860 File Offset: 0x00015A60
			// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00017868 File Offset: 0x00015A68
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

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00017871 File Offset: 0x00015A71
			// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00017879 File Offset: 0x00015A79
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

			// Token: 0x040001F1 RID: 497
			private int _start;

			// Token: 0x040001F2 RID: 498
			private int _length;
		}
	}
}
