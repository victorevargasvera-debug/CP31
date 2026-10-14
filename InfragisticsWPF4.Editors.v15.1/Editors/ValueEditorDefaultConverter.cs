using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000013 RID: 19
	internal class ValueEditorDefaultConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00004761 File Offset: 0x00002961
		protected ValueEditorDefaultConverter(bool isDisplayTextConverter)
		{
			this._isDisplayTextConverter = isDisplayTextConverter;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004770 File Offset: 0x00002970
		public static global::Infragistics.Windows.Editors.ValueEditorDefaultConverter ValueToTextConverter
		{
			get
			{
				if (global::Infragistics.Windows.Editors.ValueEditorDefaultConverter._valueToTextConverter == null)
				{
					global::Infragistics.Windows.Editors.ValueEditorDefaultConverter._valueToTextConverter = new global::Infragistics.Windows.Editors.ValueEditorDefaultConverter(false);
				}
				return global::Infragistics.Windows.Editors.ValueEditorDefaultConverter._valueToTextConverter;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00004789 File Offset: 0x00002989
		public static global::Infragistics.Windows.Editors.ValueEditorDefaultConverter ValueToDisplayTextConverter
		{
			get
			{
				if (global::Infragistics.Windows.Editors.ValueEditorDefaultConverter._valueToDisplayTextConverter == null)
				{
					global::Infragistics.Windows.Editors.ValueEditorDefaultConverter._valueToDisplayTextConverter = new global::Infragistics.Windows.Editors.ValueEditorDefaultConverter(true);
				}
				return global::Infragistics.Windows.Editors.ValueEditorDefaultConverter._valueToDisplayTextConverter;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000047A4 File Offset: 0x000029A4
		private object ConvertHelper(bool convertingBack, object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = parameter as global::Infragistics.Windows.Editors.ValueEditor;
			string format = null;
			global::System.IFormatProvider formatProvider;
			if (valueEditor != null)
			{
				formatProvider = valueEditor.FormatProviderResolved;
				if (this._isDisplayTextConverter)
				{
					format = valueEditor.Format;
				}
			}
			else
			{
				formatProvider = culture;
			}
			if (valueEditor != null)
			{
				return this.ConvertHelper(convertingBack, value, targetType, valueEditor, formatProvider, format);
			}
			object result;
			if (this.HandleNullValueHelper(convertingBack, value, targetType, valueEditor, out result))
			{
				return result;
			}
			return global::Infragistics.CoreUtilities.ConvertDataValue(value, targetType, formatProvider, format);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004804 File Offset: 0x00002A04
		private bool HandleNullValueHelper(bool convertingBack, object value, global::System.Type targetType, global::Infragistics.Windows.Editors.ValueEditor editor, out object convertedValue)
		{
			bool flag = value == null || global::System.DBNull.Value == value;
			if (convertingBack)
			{
				if (this._isDisplayTextConverter)
				{
					global::Infragistics.Windows.Editors.TextEditorBase textEditorBase = editor as global::Infragistics.Windows.Editors.TextEditorBase;
					if (textEditorBase != null && object.Equals(value, textEditorBase.NullText))
					{
						convertedValue = null;
						return true;
					}
				}
				bool flag2 = value is string && 0 == ((string)value).Length;
				if (flag2)
				{
					convertedValue = null;
					return true;
				}
			}
			else if (flag)
			{
				string text = string.Empty;
				if (this._isDisplayTextConverter)
				{
					global::Infragistics.Windows.Editors.TextEditorBase textEditorBase2 = editor as global::Infragistics.Windows.Editors.TextEditorBase;
					if (textEditorBase2 != null)
					{
						text = textEditorBase2.NullText;
					}
				}
				convertedValue = ((typeof(string) == targetType) ? text : null);
				return true;
			}
			if (flag)
			{
				convertedValue = value;
				return true;
			}
			convertedValue = null;
			return false;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000048BC File Offset: 0x00002ABC
		protected virtual object ConvertHelper(bool convertingBack, object value, global::System.Type targetType, global::Infragistics.Windows.Editors.ValueEditor editor, global::System.IFormatProvider formatProvider, string format)
		{
			object result;
			if (this.HandleNullValueHelper(convertingBack, value, targetType, editor, out result))
			{
				return result;
			}
			return global::Infragistics.CoreUtilities.ConvertDataValue(value, targetType, formatProvider, format);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000048E5 File Offset: 0x00002AE5
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.ConvertHelper(false, value, targetType, parameter, culture);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000048F3 File Offset: 0x00002AF3
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.ConvertHelper(true, value, targetType, parameter, culture);
		}

		// Token: 0x0400001C RID: 28
		private static global::Infragistics.Windows.Editors.ValueEditorDefaultConverter _valueToDisplayTextConverter;

		// Token: 0x0400001D RID: 29
		private static global::Infragistics.Windows.Editors.ValueEditorDefaultConverter _valueToTextConverter;

		// Token: 0x0400001E RID: 30
		protected bool _isDisplayTextConverter;
	}
}
