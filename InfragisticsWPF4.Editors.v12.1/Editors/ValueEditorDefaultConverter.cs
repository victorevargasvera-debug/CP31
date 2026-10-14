using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000013 RID: 19
	internal class ValueEditorDefaultConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00004715 File Offset: 0x00002915
		protected ValueEditorDefaultConverter(bool isDisplayTextConverter)
		{
			this._isDisplayTextConverter = isDisplayTextConverter;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00004724 File Offset: 0x00002924
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
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000473D File Offset: 0x0000293D
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

		// Token: 0x060000C1 RID: 193 RVA: 0x00004758 File Offset: 0x00002958
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

		// Token: 0x060000C2 RID: 194 RVA: 0x000047B8 File Offset: 0x000029B8
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

		// Token: 0x060000C3 RID: 195 RVA: 0x00004870 File Offset: 0x00002A70
		protected virtual object ConvertHelper(bool convertingBack, object value, global::System.Type targetType, global::Infragistics.Windows.Editors.ValueEditor editor, global::System.IFormatProvider formatProvider, string format)
		{
			object result;
			if (this.HandleNullValueHelper(convertingBack, value, targetType, editor, out result))
			{
				return result;
			}
			return global::Infragistics.CoreUtilities.ConvertDataValue(value, targetType, formatProvider, format);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004899 File Offset: 0x00002A99
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.ConvertHelper(false, value, targetType, parameter, culture);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000048A7 File Offset: 0x00002AA7
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.ConvertHelper(true, value, targetType, parameter, culture);
		}

		// Token: 0x0400001B RID: 27
		private static global::Infragistics.Windows.Editors.ValueEditorDefaultConverter _valueToDisplayTextConverter;

		// Token: 0x0400001C RID: 28
		private static global::Infragistics.Windows.Editors.ValueEditorDefaultConverter _valueToTextConverter;

		// Token: 0x0400001D RID: 29
		protected bool _isDisplayTextConverter;
	}
}
