using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Infragistics.Controls;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000068 RID: 104
	internal class SpinInfo
	{
		// Token: 0x060005D3 RID: 1491 RVA: 0x0001797A File Offset: 0x00015B7A
		private SpinInfo()
		{
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00017984 File Offset: 0x00015B84
		public bool CanSpin(bool up)
		{
			object obj;
			return this.SpinHelper(up, out obj);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0001799C File Offset: 0x00015B9C
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

		// Token: 0x060005D6 RID: 1494 RVA: 0x000179F4 File Offset: 0x00015BF4
		private object ConvertDataValue(object val, global::System.Type type)
		{
			return global::Infragistics.CoreUtilities.ConvertDataValue(val, type, this._valueEditor.FormatProvider, null);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00017A09 File Offset: 0x00015C09
		private object ConvertToDecimal(object val)
		{
			if (val != null && val.GetType() != typeof(global::System.DateTime))
			{
				return this.ConvertDataValue(val, typeof(decimal));
			}
			return null;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00017A38 File Offset: 0x00015C38
		private object ConvertToEditorValueType(object value)
		{
			global::System.Type valueType = this._valueEditor.ValueType;
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = this._valueEditor as global::Infragistics.Windows.Editors.XamMaskedEditor;
			if (xamMaskedEditor != null && value is global::System.DateTime && typeof(string) == xamMaskedEditor.ValueType)
			{
				return global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter.ValueToTextConverter.ConvertToTextBasedOnMask(xamMaskedEditor, value, true);
			}
			return this.ConvertDataValue(value, valueType);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00017A98 File Offset: 0x00015C98
		private global::System.Globalization.Calendar GetCalendar()
		{
			global::System.IFormatProvider formatProviderResolved = this._valueEditor.FormatProviderResolved;
			if (this._cachedCalendar == null || formatProviderResolved != this._cachedCalendar_lastFormatProvider)
			{
				this._cachedCalendar_lastFormatProvider = formatProviderResolved;
				this._cachedCalendar = global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureCalendar(formatProviderResolved);
			}
			return this._cachedCalendar;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00017ADC File Offset: 0x00015CDC
		private bool GetCurrentValueAsDate(out global::System.DateTime val)
		{
			object obj = this.ConvertDataValue(this._valueEditor.Value, typeof(global::System.DateTime));
			if (obj is global::System.DateTime)
			{
				val = (global::System.DateTime)obj;
				return true;
			}
			val = global::System.DateTime.MinValue;
			return false;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00017B28 File Offset: 0x00015D28
		internal static global::System.DateTime GetDefaultMinMaxDate(bool min)
		{
			global::Infragistics.Windows.Editors.CalendarManager currentCulture = global::Infragistics.Windows.Editors.CalendarManager.CurrentCulture;
			global::System.Globalization.Calendar calendar = currentCulture.Calendar;
			if (calendar != null)
			{
				if (!min)
				{
					return calendar.MaxSupportedDateTime;
				}
				return calendar.MinSupportedDateTime;
			}
			else
			{
				if (!min)
				{
					return global::System.DateTime.MaxValue;
				}
				return global::System.DateTime.MinValue;
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00017B64 File Offset: 0x00015D64
		private void GetResolvedMinMax(out object min, out object max, ref global::System.Type valueType)
		{
			object obj;
			max = (obj = null);
			min = obj;
			global::Infragistics.Windows.Editors.ValueConstraint valueConstraint = this._valueEditor.ValueConstraint;
			if (valueConstraint != null)
			{
				min = valueConstraint.MinInclusive;
				max = valueConstraint.MaxExclusive;
			}
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = this._valueEditor as global::Infragistics.Windows.Editors.XamMaskedEditor;
			if (xamMaskedEditor != null && (null == valueType || typeof(object) == valueType || typeof(string) == valueType))
			{
				global::System.Type type = global::Infragistics.Windows.Editors.XamMaskedEditor.DeduceEditAsType(xamMaskedEditor.Sections);
				if (null != type)
				{
					valueType = type;
				}
			}
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(valueType);
			if (global::Infragistics.Windows.Utilities.IsNumericType(underlyingType))
			{
				if (xamMaskedEditor != null)
				{
					global::Infragistics.Windows.Editors.NumberSection numberSection = (xamMaskedEditor.Sections != null) ? ((global::Infragistics.Windows.Editors.NumberSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(xamMaskedEditor.Sections, typeof(global::Infragistics.Windows.Editors.NumberSection))) : null;
					if (numberSection != null)
					{
						numberSection.VerifyMinMaxCache(true);
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
					min = global::Infragistics.Windows.Editors.SpinInfo.GetDefaultMinMaxDate(true);
				}
				if (max == null)
				{
					max = global::Infragistics.Windows.Editors.SpinInfo.GetDefaultMinMaxDate(false);
				}
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00017C8C File Offset: 0x00015E8C
		private void GetResolvedMinMaxAsDecimal(out object min, out object max)
		{
			global::System.Type valueType = this._valueEditor.ValueType;
			this.GetResolvedMinMax(out min, out max, ref valueType);
			min = this.ConvertToDecimal(min);
			max = this.ConvertToDecimal(max);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00017CC4 File Offset: 0x00015EC4
		private object GetStartValue(bool up, bool wrapping)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(this._valueEditor.ValueType);
			object obj;
			object obj2;
			this.GetResolvedMinMax(out obj, out obj2, ref underlyingType);
			if (global::Infragistics.Windows.Utilities.IsNumericType(underlyingType))
			{
				object obj3 = (obj != null) ? this.ConvertDataValue(obj, typeof(decimal)) : null;
				object obj4 = (obj2 != null) ? this.ConvertDataValue(obj2, typeof(decimal)) : null;
				if (!wrapping && (obj3 == null || (obj3 is decimal && (decimal)obj3 < 0m)) && (obj4 == null || (obj4 is decimal && 0m < (decimal)obj4)))
				{
					return 0m;
				}
			}
			else if (typeof(global::System.DateTime) == underlyingType)
			{
				object obj5 = this.ConvertDataValue(obj, typeof(global::System.DateTime));
				object obj6 = this.ConvertDataValue(obj2, typeof(global::System.DateTime));
				if (!wrapping)
				{
					global::System.DateTime now = global::System.DateTime.Now;
					if ((global::Infragistics.Windows.Editors.Utils.IsValueEmpty(obj5) || (global::System.DateTime)obj5 <= now) && (global::Infragistics.Windows.Editors.Utils.IsValueEmpty(obj6) || now <= (global::System.DateTime)obj6))
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

		// Token: 0x060005DF RID: 1503 RVA: 0x00017E30 File Offset: 0x00016030
		private bool IsIncrementTypeForDateTime()
		{
			switch (this._incrementType)
			{
			case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Day:
			case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Month:
			case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Year:
			case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.TimeSpan:
			case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Hour:
			case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Minute:
			case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Second:
			case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.MonthOrMinute:
				return true;
			}
			return false;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00017E77 File Offset: 0x00016077
		internal bool IsSameSpinIncrement(object amount)
		{
			return global::Infragistics.Windows.Editors.Utils.AreEqual(amount, this._origSpinIncrement);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00017E88 File Offset: 0x00016088
		private bool ValidateAgainstMinMax(object value)
		{
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

		// Token: 0x060005E2 RID: 1506 RVA: 0x00017EE4 File Offset: 0x000160E4
		private bool IsValueValid(object value)
		{
			global::System.Exception ex;
			return this.ValidateAgainstMinMax(value) && this._valueEditor.ValidateValue(value, out ex);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00017F10 File Offset: 0x00016110
		internal static global::Infragistics.Windows.Editors.SpinInfo Parse(global::Infragistics.Windows.Editors.ValueEditor valueEditor, object spinIncrement)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull(valueEditor);
			global::Infragistics.Windows.Editors.SpinInfo spinInfo = new global::Infragistics.Windows.Editors.SpinInfo();
			spinInfo._valueEditor = valueEditor;
			if (spinInfo.Parse(spinIncrement))
			{
				return spinInfo;
			}
			return null;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00017F3C File Offset: 0x0001613C
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
						global::Infragistics.Windows.Editors.SpinInfo.IncrementType incrementType;
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
										incrementType = global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Second;
									}
									else
									{
										incrementType = global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Hour;
									}
								}
								else
								{
									incrementType = global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Day;
								}
							}
							else
							{
								incrementType = global::Infragistics.Windows.Editors.SpinInfo.IncrementType.MonthOrMinute;
							}
						}
						else
						{
							incrementType = global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Year;
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
						this._incrementType = global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Log10;
						return true;
					}
				}
			}
			else if (spinIncrement is global::System.TimeSpan)
			{
				this._incrementType = global::Infragistics.Windows.Editors.SpinInfo.IncrementType.TimeSpan;
				this._incrementAmountTimeSpan = (global::System.TimeSpan)spinIncrement;
				return true;
			}
			object obj = this.ConvertDataValue(spinIncrement, typeof(decimal));
			if (obj is decimal)
			{
				this._incrementType = global::Infragistics.Windows.Editors.SpinInfo.IncrementType.NumbericAmount;
				this._incrementAmountNumeric = (decimal)obj;
				return true;
			}
			return false;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000180B7 File Offset: 0x000162B7
		internal void ResetAcceleration()
		{
			this._acceleration_SpinCount = 0;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000180C0 File Offset: 0x000162C0
		public bool Spin(bool up)
		{
			this.CheckElapsedTimeHelper();
			object value;
			if (this.SpinHelper(up, out value))
			{
				this._valueEditor.Value = value;
				this._acceleration_SpinCount++;
				return true;
			}
			return false;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000180FC File Offset: 0x000162FC
		private bool SpinHelper(bool up, out object newValue)
		{
			object value = this._valueEditor.Value;
			newValue = null;
			if (global::Infragistics.Windows.Editors.Utils.IsValueEmpty(value))
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
					case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Day:
						dateTime = global::Infragistics.Controls.CalendarHelper.AddDays(dateTime, (int)value2, calendar);
						break;
					case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Month:
						dateTime = global::Infragistics.Controls.CalendarHelper.AddMonths(dateTime, (int)value2, calendar);
						break;
					case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Year:
						dateTime = global::Infragistics.Controls.CalendarHelper.AddYears(dateTime, (int)value2, calendar);
						break;
					case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.TimeSpan:
						dateTime = (up ? dateTime.Add(this._incrementAmountTimeSpan) : dateTime.Subtract(this._incrementAmountTimeSpan));
						break;
					case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Hour:
						dateTime = dateTime.AddHours((double)value2);
						break;
					case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Minute:
						dateTime = dateTime.AddMinutes((double)value2);
						break;
					case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Second:
						dateTime = dateTime.AddSeconds((double)value2);
						break;
					case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.MonthOrMinute:
					{
						bool flag = false;
						global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = this._valueEditor as global::Infragistics.Windows.Editors.XamMaskedEditor;
						if (xamMaskedEditor != null)
						{
							bool flag2;
							bool flag3;
							global::Infragistics.Windows.Editors.XamMaskedEditor.DeduceEditAsType(xamMaskedEditor.Sections, out flag2, out flag3);
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
			case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.Log10:
				break;
			case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.TimeSpan:
				goto IL_2EC;
			case global::Infragistics.Windows.Editors.SpinInfo.IncrementType.NumbericAmount:
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
						num3 = global::System.Math.Floor(num3 / num2) * num2;
						obj3 = newValue;
						newValue = this.ConvertDataValue(num3, this._valueEditor.ValueType);
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
			if (this._valueEditor is global::Infragistics.Windows.Editors.XamMaskedEditor && ((global::Infragistics.Windows.Editors.XamMaskedEditor)this._valueEditor).SpinWrap)
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

		// Token: 0x040001F5 RID: 501
		private global::System.TimeSpan _incrementAmountTimeSpan;

		// Token: 0x040001F6 RID: 502
		private decimal _incrementAmountNumeric;

		// Token: 0x040001F7 RID: 503
		private global::Infragistics.Windows.Editors.SpinInfo.IncrementType _incrementType;

		// Token: 0x040001F8 RID: 504
		private global::Infragistics.Windows.Editors.ValueEditor _valueEditor;

		// Token: 0x040001F9 RID: 505
		private object _origSpinIncrement;

		// Token: 0x040001FA RID: 506
		private int _acceleration_SpinCount;

		// Token: 0x040001FB RID: 507
		private global::System.DateTime? _lastSpinTime;

		// Token: 0x040001FC RID: 508
		private global::System.IFormatProvider _cachedCalendar_lastFormatProvider;

		// Token: 0x040001FD RID: 509
		private global::System.Globalization.Calendar _cachedCalendar;

		// Token: 0x02000069 RID: 105
		private enum IncrementType
		{
			// Token: 0x040001FF RID: 511
			Day,
			// Token: 0x04000200 RID: 512
			Month,
			// Token: 0x04000201 RID: 513
			Year,
			// Token: 0x04000202 RID: 514
			Log10,
			// Token: 0x04000203 RID: 515
			TimeSpan,
			// Token: 0x04000204 RID: 516
			NumbericAmount,
			// Token: 0x04000205 RID: 517
			Hour,
			// Token: 0x04000206 RID: 518
			Minute,
			// Token: 0x04000207 RID: 519
			Second,
			// Token: 0x04000208 RID: 520
			MonthOrMinute
		}
	}
}
