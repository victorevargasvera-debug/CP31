using System;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000056 RID: 86
	internal class ValueInputDefaultConverter : global::Infragistics.ValueConverterBase
	{
		// Token: 0x060003EF RID: 1007 RVA: 0x0001455F File Offset: 0x0001275F
		protected ValueInputDefaultConverter(bool isDisplayTextConverter)
		{
			this._isDisplayTextConverter = isDisplayTextConverter;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0001456E File Offset: 0x0001276E
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

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00014587 File Offset: 0x00012787
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

		// Token: 0x060003F2 RID: 1010 RVA: 0x000145A0 File Offset: 0x000127A0
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

		// Token: 0x060003F3 RID: 1011 RVA: 0x00014600 File Offset: 0x00012800
		private bool HandleNullValueHelper(bool convertingBack, object value, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueInput editor, out object convertedValue)
		{
			bool flag = global::Infragistics.CoreUtilities.IsNull(value);
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

		// Token: 0x060003F4 RID: 1012 RVA: 0x000146B0 File Offset: 0x000128B0
		protected virtual object ConvertHelper(bool convertingBack, object value, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueInput editor, global::System.IFormatProvider formatProvider, string format)
		{
			object result;
			if (this.HandleNullValueHelper(convertingBack, value, targetType, editor, out result))
			{
				return result;
			}
			return global::Infragistics.CoreUtilities.ConvertDataValue(value, targetType, formatProvider, format);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000146D9 File Offset: 0x000128D9
		public override object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.ConvertHelper(false, value, targetType, parameter, culture);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000146E7 File Offset: 0x000128E7
		public override object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.ConvertHelper(true, value, targetType, parameter, culture);
		}

		// Token: 0x0400017F RID: 383
		private static global::Infragistics.Controls.Editors.ValueInputDefaultConverter _valueToDisplayTextConverter;

		// Token: 0x04000180 RID: 384
		private static global::Infragistics.Controls.Editors.ValueInputDefaultConverter _valueToTextConverter;

		// Token: 0x04000181 RID: 385
		protected bool _isDisplayTextConverter;
	}
}
