using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200004F RID: 79
	internal class SpinInfo
	{
		// Token: 0x06000376 RID: 886 RVA: 0x00012103 File Offset: 0x00010303
		private SpinInfo()
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0001210C File Offset: 0x0001030C
		public bool CanSpin(bool up)
		{
			object obj;
			return this.SpinHelper(up, out obj);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00012124 File Offset: 0x00010324
		internal void CheckElapsedTimeHelper()
		{
			global::System.DateTime now = global::System.DateTime.Now;
			if (this._lastSpinTime != null)
			{
				global::System.DateTime value = this._lastSpinTime.Value;
				if ((now - value).TotalMilliseconds > 500.0)
				{
					this.ResetAcceleration();
				}
			}
			this._lastSpinTime = new global::System.DateTime?(now);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0001217C File Offset: 0x0001037C
		private object ConvertDataValue(object val, global::System.Type type)
		{
			return global::Infragistics.CoreUtilities.ConvertDataValue(val, type, this._valueInput.FormatProvider, null);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00012191 File Offset: 0x00010391
		private object ConvertToDecimal(object val)
		{
			if (val != null && val.GetType() != typeof(global::System.DateTime))
			{
				return this.ConvertDataValue(val, typeof(decimal));
			}
			return null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000121C0 File Offset: 0x000103C0
		private object ConvertToEditorValueType(object value)
		{
			global::System.Type valueTypeResolved = this._valueInput.ValueTypeResolved;
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = this._valueInput as global::Infragistics.Controls.Editors.XamMaskedInput;
			if (xamMaskedInput != null && value is global::System.DateTime && typeof(string) == xamMaskedInput.ValueTypeResolved)
			{
				return global::Infragistics.Controls.Editors.MaskedInputDefaultConverter.ValueToTextConverter.ConvertToTextBasedOnMask(xamMaskedInput, value, true);
			}
			return this.ConvertDataValue(value, valueTypeResolved);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00012220 File Offset: 0x00010420
		private global::System.Globalization.Calendar GetCalendar()
		{
			global::System.IFormatProvider formatProviderResolved = this._valueInput.FormatProviderResolved;
			if (this._cachedCalendar == null || formatProviderResolved != this._cachedCalendar_lastFormatProvider)
			{
				this._cachedCalendar_lastFormatProvider = formatProviderResolved;
				this._cachedCalendar = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetCultureCalendar(formatProviderResolved);
			}
			return this._cachedCalendar;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00012264 File Offset: 0x00010464
		private bool GetCurrentValueAsDate(out global::System.DateTime val)
		{
			object obj = this.ConvertDataValue(this._valueInput.Value, typeof(global::System.DateTime));
			if (obj is global::System.DateTime)
			{
				val = (global::System.DateTime)obj;
				return true;
			}
			val = global::System.DateTime.MinValue;
			return false;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000122AF File Offset: 0x000104AF
		internal static global::System.DateTime GetDefaultMinMaxDate(bool min)
		{
			return global::Infragistics.Controls.CalendarHelper.GetMinMax(global::System.Globalization.CultureInfo.CurrentCulture.Calendar, min);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000122C4 File Offset: 0x000104C4
		private void GetResolvedMinMax(out object min, out object max, ref global::System.Type valueType)
		{
			object obj;
			max = (obj = null);
			min = obj;
			global::Infragistics.Controls.Editors.ValueConstraint valueConstraint = this._valueInput.ValueConstraint;
			if (valueConstraint != null)
			{
				min = valueConstraint.MinInclusive;
				max = valueConstraint.MaxExclusive;
			}
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = this._valueInput as global::Infragistics.Controls.Editors.XamMaskedInput;
			if (xamMaskedInput != null && (null == valueType || typeof(object) == valueType || typeof(string) == valueType))
			{
				global::System.Type type = global::Infragistics.Controls.Editors.XamMaskedInput.DeduceEditAsType(xamMaskedInput.Sections);
				if (null != type)
				{
					valueType = type;
				}
			}
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(valueType);
			if (global::Infragistics.Controls.Editors.Primitives.Utils.IsNumericType(underlyingType))
			{
				if (xamMaskedInput != null)
				{
					global::Infragistics.Controls.Editors.NumberSection numberSection = (xamMaskedInput.Sections != null) ? ((global::Infragistics.Controls.Editors.NumberSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(xamMaskedInput.Sections, typeof(global::Infragistics.Controls.Editors.NumberSection))) : null;
					if (numberSection != null)
					{
						if (!numberSection.VerifyMinMaxCache(true))
						{
							numberSection.VerifyMinMaxCache(false);
						}
						min = numberSection.lastConvertedMinValWithFractionPart;
						max = numberSection.lastConvertedMaxValWithFractionPart;
						return;
					}
				}
			}
			else if (typeof(global::System.DateTime) == underlyingType)
			{
				if (min == null)
				{
					min = global::Infragistics.Controls.Editors.Primitives.SpinInfo.GetDefaultMinMaxDate(true);
				}
				if (max == null)
				{
					max = global::Infragistics.Controls.Editors.Primitives.SpinInfo.GetDefaultMinMaxDate(false);
				}
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000123F8 File Offset: 0x000105F8
		private void GetResolvedMinMaxAsDecimal(out object min, out object max)
		{
			global::System.Type valueTypeResolved = this._valueInput.ValueTypeResolved;
			this.GetResolvedMinMax(out min, out max, ref valueTypeResolved);
			min = this.ConvertToDecimal(min);
			max = this.ConvertToDecimal(max);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00012430 File Offset: 0x00010630
		private object GetStartValue(bool up, bool wrapping)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(this._valueInput.ValueTypeResolved);
			object obj;
			object obj2;
			this.GetResolvedMinMax(out obj, out obj2, ref underlyingType);
			if (global::Infragistics.Controls.Editors.Primitives.Utils.IsNumericType(underlyingType))
			{
				object obj3 = (obj != null) ? this.ConvertDataValue(obj, typeof(decimal)) : null;
				object obj4 = (obj2 != null) ? this.ConvertDataValue(obj2, typeof(decimal)) : null;
				if (!wrapping && (obj3 == null || (obj3 is decimal && (decimal)obj3 < 0m)) && (obj4 == null || (obj4 is decimal && 0m < (decimal)obj4)))
				{
					return this.ConvertToEditorValueType(0m);
				}
			}
			else if (typeof(global::System.DateTime) == underlyingType)
			{
				object obj5 = this.ConvertDataValue(obj, typeof(global::System.DateTime));
				object obj6 = this.ConvertDataValue(obj2, typeof(global::System.DateTime));
				if (!wrapping)
				{
					global::System.DateTime now = global::System.DateTime.Now;
					if ((global::Infragistics.Controls.Editors.Primitives.Utils.IsValueEmpty(obj5) || (global::System.DateTime)obj5 <= now) && (global::Infragistics.Controls.Editors.Primitives.Utils.IsValueEmpty(obj6) || now <= (global::System.DateTime)obj6))
					{
						return now;
					}
				}
			}
			object obj7 = up ? obj : obj2;
			if (obj7 != null && !underlyingType.IsInstanceOfType(obj7))
			{
				object obj8 = this.ConvertDataValue(obj7, underlyingType);
				if (obj8 != null)
				{
					obj7 = obj8;
				}
			}
			return obj7;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000125A4 File Offset: 0x000107A4
		private bool IsIncrementTypeForDateTime()
		{
			switch (this._incrementType)
			{
			case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Day:
			case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Month:
			case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Year:
			case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.TimeSpan:
			case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Hour:
			case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Minute:
			case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Second:
			case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.MonthOrMinute:
				return true;
			}
			return false;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000125EB File Offset: 0x000107EB
		internal bool IsSameSpinIncrement(object amount)
		{
			return global::Infragistics.Controls.Editors.Primitives.Utils.AreEqual(amount, this._origSpinIncrement);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000125FC File Offset: 0x000107FC
		private bool IsValueValid(object value)
		{
			global::System.Exception ex;
			if (!this._valueInput.ValidateValue(value, out ex))
			{
				return false;
			}
			if (!this.IsIncrementTypeForDateTime())
			{
				object obj = this.ConvertToDecimal(value);
				if (obj != null)
				{
					object obj2;
					object obj3;
					this.GetResolvedMinMaxAsDecimal(out obj2, out obj3);
					if (obj2 != null && (decimal)obj < (decimal)obj2)
					{
						return false;
					}
					if (obj3 != null && (decimal)obj > (decimal)obj3)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0001266C File Offset: 0x0001086C
		internal static global::Infragistics.Controls.Editors.Primitives.SpinInfo Parse(global::Infragistics.Controls.Editors.ValueInput valueInput, object spinIncrement)
		{
			global::Infragistics.Controls.Editors.Primitives.Utils.ValidateNull(valueInput);
			global::Infragistics.Controls.Editors.Primitives.SpinInfo spinInfo = new global::Infragistics.Controls.Editors.Primitives.SpinInfo();
			spinInfo._valueInput = valueInput;
			if (spinInfo.Parse(spinIncrement))
			{
				return spinInfo;
			}
			return null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00012698 File Offset: 0x00010898
		private bool Parse(object spinIncrement)
		{
			this._origSpinIncrement = spinIncrement;
			if (spinIncrement is string)
			{
				string input = ((string)spinIncrement).Trim();
				global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(input, "^([\\-\\+]?)(\\d+)\\s*([Dd]|[Mm]|[Yy]|[Hh]|[Ss])$");
				if (match != null && match.Success)
				{
					"-" == match.Groups[1].Value;
					if (!decimal.TryParse(match.Groups[2].Value, out this._incrementAmountNumeric))
					{
						return false;
					}
					string text = match.Groups[3].Value;
					text = text.ToLower();
					string a;
					if ((a = text) != null)
					{
						global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType incrementType;
						if (!(a == "y"))
						{
							if (!(a == "m"))
							{
								if (!(a == "d"))
								{
									if (!(a == "h"))
									{
										if (!(a == "s"))
										{
											return false;
										}
										incrementType = global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Second;
									}
									else
									{
										incrementType = global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Hour;
									}
								}
								else
								{
									incrementType = global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Day;
								}
							}
							else
							{
								incrementType = global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.MonthOrMinute;
							}
						}
						else
						{
							incrementType = global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Year;
						}
						this._incrementType = incrementType;
						return true;
					}
					return false;
				}
				else
				{
					match = global::System.Text.RegularExpressions.Regex.Match(input, "^log$");
					if (match != null && match.Success)
					{
						this._incrementType = global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Log10;
						return true;
					}
				}
			}
			else if (spinIncrement is global::System.TimeSpan)
			{
				this._incrementType = global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.TimeSpan;
				this._incrementAmountTimeSpan = (global::System.TimeSpan)spinIncrement;
				return true;
			}
			object obj = this.ConvertDataValue(spinIncrement, typeof(decimal));
			if (obj is decimal)
			{
				this._incrementType = global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.NumbericAmount;
				this._incrementAmountNumeric = (decimal)obj;
				return true;
			}
			return false;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00012813 File Offset: 0x00010A13
		internal void ResetAcceleration()
		{
			this._acceleration_SpinCount = 0;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0001281C File Offset: 0x00010A1C
		public bool Spin(bool up)
		{
			this.CheckElapsedTimeHelper();
			object value;
			if (this.SpinHelper(up, out value))
			{
				this._valueInput.Value = value;
				this._acceleration_SpinCount++;
				return true;
			}
			return false;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00012858 File Offset: 0x00010A58
		private bool SpinHelper(bool up, out object newValue)
		{
			object value = this._valueInput.Value;
			newValue = null;
			if (global::Infragistics.Controls.Editors.Primitives.Utils.IsValueEmpty(value))
			{
				newValue = this.GetStartValue(up, false);
				return true;
			}
			if (this.IsIncrementTypeForDateTime())
			{
				global::System.DateTime dateTime;
				if (!this.GetCurrentValueAsDate(out dateTime))
				{
					goto IL_2EC;
				}
				decimal value2 = up ? this._incrementAmountNumeric : (-this._incrementAmountNumeric);
				try
				{
					global::System.Globalization.Calendar calendar = this.GetCalendar();
					global::System.DateTime d = dateTime;
					switch (this._incrementType)
					{
					case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Day:
						dateTime = global::Infragistics.Controls.CalendarHelper.AddDays(dateTime, (int)value2, calendar);
						break;
					case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Month:
						dateTime = global::Infragistics.Controls.CalendarHelper.AddMonths(dateTime, (int)value2, calendar);
						break;
					case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Year:
						dateTime = global::Infragistics.Controls.CalendarHelper.AddYears(dateTime, (int)value2, calendar);
						break;
					case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.TimeSpan:
						dateTime = (up ? dateTime.Add(this._incrementAmountTimeSpan) : dateTime.Subtract(this._incrementAmountTimeSpan));
						break;
					case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Hour:
						dateTime = dateTime.AddHours((double)value2);
						break;
					case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Minute:
						dateTime = dateTime.AddMinutes((double)value2);
						break;
					case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Second:
						dateTime = dateTime.AddSeconds((double)value2);
						break;
					case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.MonthOrMinute:
					{
						bool flag = false;
						global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = this._valueInput as global::Infragistics.Controls.Editors.XamMaskedInput;
						if (xamMaskedInput != null)
						{
							bool flag2;
							bool flag3;
							global::Infragistics.Controls.Editors.XamMaskedInput.DeduceEditAsType(xamMaskedInput.Sections, out flag2, out flag3);
							if (!flag2 && flag3)
							{
								flag = true;
							}
						}
						if (flag)
						{
							dateTime = dateTime.AddMinutes((double)value2);
						}
						else
						{
							dateTime = global::Infragistics.Controls.CalendarHelper.AddMonths(dateTime, (int)value2, calendar);
						}
						break;
					}
					}
					if (d != dateTime)
					{
						newValue = dateTime;
					}
					goto IL_2EC;
				}
				catch
				{
					goto IL_2EC;
				}
			}
			switch (this._incrementType)
			{
			case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.Log10:
				break;
			case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.TimeSpan:
				goto IL_2EC;
			case global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType.NumbericAmount:
			{
				object obj = this.ConvertDataValue(value, typeof(decimal));
				if (!(obj is decimal))
				{
					goto IL_2EC;
				}
				try
				{
					newValue = (decimal)obj + (up ? this._incrementAmountNumeric : (-this._incrementAmountNumeric));
					goto IL_2EC;
				}
				catch
				{
					goto IL_2EC;
				}
				break;
			}
			default:
				goto IL_2EC;
			}
			object obj2 = this.ConvertDataValue(value, typeof(decimal));
			if (obj2 is decimal)
			{
				try
				{
					int num = global::System.Math.Min(10, this._acceleration_SpinCount / 40);
					decimal num3;
					object obj3;
					do
					{
						decimal num2 = (decimal)global::System.Math.Pow(10.0, (double)num);
						num3 = (decimal)obj2 + (up ? num2 : (-num2));
						num3 = decimal.Floor(num3 / num2) * num2;
						obj3 = newValue;
						newValue = this.ConvertDataValue(num3, this._valueInput.ValueTypeResolved);
						num--;
					}
					while (num >= 0 && newValue != null && (!this.IsValueValid(newValue) || (num > 0 && 0m == num3)));
					if (newValue == null)
					{
						newValue = obj3;
					}
				}
				catch
				{
				}
			}
			IL_2EC:
			if (newValue != null)
			{
				newValue = this.ConvertToEditorValueType(newValue);
				if (newValue != null && this.IsValueValid(newValue))
				{
					return true;
				}
			}
			if (this._valueInput is global::Infragistics.Controls.Editors.XamMaskedInput && ((global::Infragistics.Controls.Editors.XamMaskedInput)this._valueInput).SpinWrap)
			{
				object startValue = this.GetStartValue(up, true);
				if (this.IsValueValid(startValue))
				{
					newValue = startValue;
					return true;
				}
			}
			return false;
		}

		// Token: 0x0400012F RID: 303
		private global::System.TimeSpan _incrementAmountTimeSpan;

		// Token: 0x04000130 RID: 304
		private decimal _incrementAmountNumeric;

		// Token: 0x04000131 RID: 305
		private global::Infragistics.Controls.Editors.Primitives.SpinInfo.IncrementType _incrementType;

		// Token: 0x04000132 RID: 306
		private global::Infragistics.Controls.Editors.ValueInput _valueInput;

		// Token: 0x04000133 RID: 307
		private object _origSpinIncrement;

		// Token: 0x04000134 RID: 308
		private int _acceleration_SpinCount;

		// Token: 0x04000135 RID: 309
		private global::System.DateTime? _lastSpinTime;

		// Token: 0x04000136 RID: 310
		private global::System.IFormatProvider _cachedCalendar_lastFormatProvider;

		// Token: 0x04000137 RID: 311
		private global::System.Globalization.Calendar _cachedCalendar;

		// Token: 0x02000050 RID: 80
		private enum IncrementType
		{
			// Token: 0x04000139 RID: 313
			Day,
			// Token: 0x0400013A RID: 314
			Month,
			// Token: 0x0400013B RID: 315
			Year,
			// Token: 0x0400013C RID: 316
			Log10,
			// Token: 0x0400013D RID: 317
			TimeSpan,
			// Token: 0x0400013E RID: 318
			NumbericAmount,
			// Token: 0x0400013F RID: 319
			Hour,
			// Token: 0x04000140 RID: 320
			Minute,
			// Token: 0x04000141 RID: 321
			Second,
			// Token: 0x04000142 RID: 322
			MonthOrMinute
		}
	}
}
