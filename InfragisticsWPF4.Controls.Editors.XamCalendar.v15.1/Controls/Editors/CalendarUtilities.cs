using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000048 RID: 72
	internal static class CalendarUtilities
	{
		// Token: 0x06000301 RID: 769 RVA: 0x0000EB54 File Offset: 0x0000CD54
		static CalendarUtilities()
		{
			global::Infragistics.Controls.Editors.CalendarUtilities.UIElement3DType = global::System.Type.GetType("System.Windows.UIElement3D, " + typeof(global::System.Windows.UIElement).Assembly.FullName, false);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000EBB2 File Offset: 0x0000CDB2
		internal static bool AreEqual(object x, object y)
		{
			return x == y || (x != null && y != null && x.GetType() == y.GetType() && object.Equals(x, y));
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		internal static global::Infragistics.Controls.Editors.CalendarBase GetCalendar(global::System.Windows.UIElement element)
		{
			bool flag;
			return global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(element, out flag);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
		internal static global::Infragistics.Controls.Editors.CalendarBase GetCalendar(global::System.Windows.UIElement element, out bool initialized)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(element);
			initialized = false;
			if (calendarBase == null)
			{
				calendarBase = global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::Infragistics.Controls.Editors.CalendarBase>(element, null, null);
				if (calendarBase != null)
				{
					global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(element, calendarBase);
					initialized = true;
				}
			}
			return calendarBase;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000EC3B File Offset: 0x0000CE3B
		internal static global::System.Collections.Generic.List<T> GetEnumValues<T>() where T : struct
		{
			return (from f in typeof(T).GetFields(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public)
			where f.IsLiteral
			select (T)((object)f.GetValue(null))).ToList<T>();
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000EC78 File Offset: 0x0000CE78
		internal static global::System.Exception GetTextToValueConversionError(global::System.Type targetType, string text)
		{
			bool flag = string.IsNullOrEmpty(text) || 0 == text.Trim().Length;
			string @string;
			if (typeof(global::System.DateTime) == targetType)
			{
				@string = global::Infragistics.Controls.Editors.CalendarUtilities.GetString(flag ? "LMSG_EnteredDateEmpty" : "LMSG_EnteredDateInvalid", new object[]
				{
					text
				});
			}
			else if (global::Infragistics.Controls.Editors.CalendarUtilities.IsNumericType(targetType))
			{
				@string = global::Infragistics.Controls.Editors.CalendarUtilities.GetString(flag ? "LMSG_EnteredNumberEmpty" : "LMSG_EnteredNumberInvalid", new object[]
				{
					text
				});
			}
			else
			{
				@string = global::Infragistics.Controls.Editors.CalendarUtilities.GetString(flag ? "LMSG_EnteredValueEmpty" : "LMSG_EnteredValueInvalid", new object[]
				{
					text
				});
			}
			return new global::System.Exception(@string);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000ED2C File Offset: 0x0000CF2C
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

		// Token: 0x06000308 RID: 776 RVA: 0x0000ED7C File Offset: 0x0000CF7C
		public static bool IsNumericType(global::System.Type type)
		{
			return (type.IsPrimitive || type == typeof(decimal)) && (type != typeof(bool) && type != typeof(char));
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000EDD0 File Offset: 0x0000CFD0
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

		// Token: 0x0600030A RID: 778 RVA: 0x0000EE28 File Offset: 0x0000D028
		private static bool IsEnumFlags(global::System.Type enumType)
		{
			object[] customAttributes = enumType.GetCustomAttributes(typeof(global::System.FlagsAttribute), true);
			return customAttributes != null && customAttributes.Length > 0;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000EE52 File Offset: 0x0000D052
		internal static void ValidateEnum(string argumentName, global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.Controls.Editors.CalendarUtilities.IsEnumFlags(enumType))
			{
				throw new global::System.ArgumentException(argumentName);
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000EE6C File Offset: 0x0000D06C
		internal static void ValidateNull(string paramName, object val)
		{
			if (val == null)
			{
				throw new global::System.ArgumentNullException(paramName);
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000EE78 File Offset: 0x0000D078
		internal static void ValidateNull(object val)
		{
			if (val == null)
			{
				throw new global::System.ArgumentNullException();
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000EE84 File Offset: 0x0000D084
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

		// Token: 0x0600030F RID: 783 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
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

		// Token: 0x06000310 RID: 784 RVA: 0x0000EF05 File Offset: 0x0000D105
		public static bool IsValueEmpty(object val)
		{
			return global::Infragistics.CoreUtilities.IsNull(val) || string.Empty == val as string || global::System.Windows.DependencyProperty.UnsetValue == val;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000EF2B File Offset: 0x0000D12B
		internal static object DictionaryKey(object o)
		{
			if (o != null)
			{
				return o;
			}
			return global::Infragistics.Controls.Editors.CalendarUtilities.NULL_KEY;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000EF37 File Offset: 0x0000D137
		internal static bool IsUIElementOrUIElement3D(global::System.Windows.DependencyObject d)
		{
			return d is global::System.Windows.UIElement || (d != null && null != global::Infragistics.Controls.Editors.CalendarUtilities.UIElement3DType && global::Infragistics.Controls.Editors.CalendarUtilities.UIElement3DType.IsAssignableFrom(d.GetType()));
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000EF68 File Offset: 0x0000D168
		internal static string GetString(string name)
		{
			return global::Infragistics.Controls.Editors.CalendarUtilities.GetString(name, null);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000EF71 File Offset: 0x0000D171
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000EF7A File Offset: 0x0000D17A
		internal static void SetBoolProperty(global::System.Windows.DependencyObject item, global::System.Windows.DependencyProperty dp, bool newValue, bool oldValue, bool defaultValue)
		{
			if (oldValue == newValue)
			{
				return;
			}
			if (newValue == defaultValue)
			{
				item.ClearValue(dp);
				return;
			}
			item.SetValue(dp, global::Infragistics.KnownBoxes.FromValue(newValue));
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000EF9B File Offset: 0x0000D19B
		internal static void SetBoolProperty(global::System.Windows.DependencyObject item, global::System.Windows.DependencyPropertyKey dpk, bool newValue, bool oldValue, bool defaultValue)
		{
			if (oldValue == newValue)
			{
				return;
			}
			if (newValue == defaultValue)
			{
				item.ClearValue(dpk);
				return;
			}
			item.SetValue(dpk, global::Infragistics.KnownBoxes.FromValue(newValue));
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		internal static bool ValidateNonHiddenVisibility(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Visibility visibility = (global::System.Windows.Visibility)e.NewValue;
			switch (visibility)
			{
			case global::System.Windows.Visibility.Visible:
			case global::System.Windows.Visibility.Collapsed:
				return visibility == global::System.Windows.Visibility.Visible;
			}
			throw new global::System.NotSupportedException(global::Infragistics.Controls.Editors.CalendarUtilities.GetString("LE_HiddenNotSupported", new object[]
			{
				global::Infragistics.DependencyPropertyUtilities.GetName(e.Property),
				visibility
			}));
		}

		// Token: 0x040001BF RID: 447
		internal const int MouseWheelScrollDelta = 120;

		// Token: 0x040001C0 RID: 448
		internal static readonly object ZeroInt = 0;

		// Token: 0x040001C1 RID: 449
		internal static readonly object ZeroDouble = 0.0;

		// Token: 0x040001C2 RID: 450
		private static readonly global::System.Type UIElement3DType;

		// Token: 0x040001C3 RID: 451
		private static readonly object NULL_KEY = new object();

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600031B RID: 795
		internal delegate void MethodInvoker();

		// Token: 0x0200004A RID: 74
		internal class Range
		{
			// Token: 0x0600031E RID: 798 RVA: 0x0000F020 File Offset: 0x0000D220
			internal Range(int start, int length)
			{
				this._start = start;
				this._length = length;
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x0600031F RID: 799 RVA: 0x0000F036 File Offset: 0x0000D236
			// (set) Token: 0x06000320 RID: 800 RVA: 0x0000F03E File Offset: 0x0000D23E
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

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000321 RID: 801 RVA: 0x0000F047 File Offset: 0x0000D247
			// (set) Token: 0x06000322 RID: 802 RVA: 0x0000F04F File Offset: 0x0000D24F
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

			// Token: 0x040001C4 RID: 452
			private int _start;

			// Token: 0x040001C5 RID: 453
			private int _length;
		}
	}
}
