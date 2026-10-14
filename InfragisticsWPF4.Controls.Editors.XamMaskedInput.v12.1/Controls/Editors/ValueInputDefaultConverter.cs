using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000057 RID: 87
	internal class ValueInputDefaultConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x0001463B File Offset: 0x0001283B
		protected ValueInputDefaultConverter(bool isDisplayTextConverter)
		{
			this._isDisplayTextConverter = isDisplayTextConverter;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0001464A File Offset: 0x0001284A
		public static global::Infragistics.Controls.Editors.ValueInputDefaultConverter ValueToTextConverter
		{
			get
			{
				if (global::Infragistics.Controls.Editors.ValueInputDefaultConverter._valueToTextConverter == null)
				{
					global::Infragistics.Controls.Editors.ValueInputDefaultConverter._valueToTextConverter = new global::Infragistics.Controls.Editors.ValueInputDefaultConverter(false);
				}
				return global::Infragistics.Controls.Editors.ValueInputDefaultConverter._valueToTextConverter;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00014663 File Offset: 0x00012863
		public static global::Infragistics.Controls.Editors.ValueInputDefaultConverter ValueToDisplayTextConverter
		{
			get
			{
				if (global::Infragistics.Controls.Editors.ValueInputDefaultConverter._valueToDisplayTextConverter == null)
				{
					global::Infragistics.Controls.Editors.ValueInputDefaultConverter._valueToDisplayTextConverter = new global::Infragistics.Controls.Editors.ValueInputDefaultConverter(true);
				}
				return global::Infragistics.Controls.Editors.ValueInputDefaultConverter._valueToDisplayTextConverter;
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001467C File Offset: 0x0001287C
		private object ConvertHelper(bool convertingBack, object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = parameter as global::Infragistics.Controls.Editors.ValueInput;
			string format = null;
			global::System.IFormatProvider formatProvider;
			if (valueInput != null)
			{
				formatProvider = valueInput.FormatProviderResolved;
				if (this._isDisplayTextConverter)
				{
					format = valueInput.Format;
				}
			}
			else
			{
				formatProvider = culture;
			}
			if (valueInput != null)
			{
				return this.ConvertHelper(convertingBack, value, targetType, valueInput, formatProvider, format);
			}
			object result;
			if (this.HandleNullValueHelper(convertingBack, value, targetType, valueInput, out result))
			{
				return result;
			}
			return global::Infragistics.CoreUtilities.ConvertDataValue(value, targetType, formatProvider, format);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000146DC File Offset: 0x000128DC
		private bool HandleNullValueHelper(bool convertingBack, object value, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueInput editor, out object convertedValue)
		{
			bool flag = value == null || global::System.DBNull.Value == value;
			if (convertingBack)
			{
				if (this._isDisplayTextConverter)
				{
					global::Infragistics.Controls.Editors.TextInputBase textInputBase = editor as global::Infragistics.Controls.Editors.TextInputBase;
					if (textInputBase != null && object.Equals(value, textInputBase.NullText))
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
					global::Infragistics.Controls.Editors.TextInputBase textInputBase2 = editor as global::Infragistics.Controls.Editors.TextInputBase;
					if (textInputBase2 != null)
					{
						text = textInputBase2.NullText;
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

		// Token: 0x060003EF RID: 1007 RVA: 0x00014794 File Offset: 0x00012994
		protected virtual object ConvertHelper(bool convertingBack, object value, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueInput editor, global::System.IFormatProvider formatProvider, string format)
		{
			object result;
			if (this.HandleNullValueHelper(convertingBack, value, targetType, editor, out result))
			{
				return result;
			}
			return global::Infragistics.CoreUtilities.ConvertDataValue(value, targetType, formatProvider, format);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000147BD File Offset: 0x000129BD
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.ConvertHelper(false, value, targetType, parameter, culture);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000147CB File Offset: 0x000129CB
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.ConvertHelper(true, value, targetType, parameter, culture);
		}

		// Token: 0x0400017B RID: 379
		private static global::Infragistics.Controls.Editors.ValueInputDefaultConverter _valueToDisplayTextConverter;

		// Token: 0x0400017C RID: 380
		private static global::Infragistics.Controls.Editors.ValueInputDefaultConverter _valueToTextConverter;

		// Token: 0x0400017D RID: 381
		protected bool _isDisplayTextConverter;
	}
}
