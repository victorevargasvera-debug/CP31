using System;
using System.Text;
using System.Windows;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000AC RID: 172
	public class NumberSection : global::Infragistics.Windows.Editors.EditSectionBase
	{
		// Token: 0x0600096A RID: 2410 RVA: 0x0002BAFE File Offset: 0x00029CFE
		internal NumberSection(int digits) : this(digits, null, global::Infragistics.Windows.Editors.SignDisplayType.None)
		{
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0002BB0C File Offset: 0x00029D0C
		internal NumberSection(int digits, int[] commaPositions, global::Infragistics.Windows.Editors.SignDisplayType signType)
		{
			this.InternalInitialize(digits, commaPositions, signType);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0002BB68 File Offset: 0x00029D68
		private void InternalInitialize(int digits, int[] commaPositions, global::Infragistics.Windows.Editors.SignDisplayType signType)
		{
			if (digits <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("digits", global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentOutOfRangeException_1"));
			}
			this.digits = digits;
			this.commaPositions = commaPositions;
			this.signType = signType;
			decimal num;
			try
			{
				num = ++(-(decimal)global::System.Math.Pow(10.0, (double)digits));
			}
			catch (global::System.OverflowException)
			{
				num = decimal.MinValue;
			}
			if (num != decimal.Floor(num))
			{
				num = ++decimal.Floor(num);
			}
			this.defaultMinValue = num;
			decimal num2;
			if (signType != global::Infragistics.Windows.Editors.SignDisplayType.None)
			{
				num2 = num;
				this.lastConvertedMinValWithFractionPart = ((num == decimal.MinValue) ? num : (--num));
			}
			else
			{
				num2 = 0m;
				this.lastConvertedMinValWithFractionPart = 0m;
			}
			decimal num3;
			try
			{
				num3 = decimal.Floor(--(decimal)global::System.Math.Pow(10.0, (double)digits));
			}
			catch (global::System.OverflowException)
			{
				num3 = decimal.MaxValue;
			}
			this.minValue = num2;
			this.maxValue = num3;
			this.lastConvertedMinValWithFractionPart = this.maxValue;
			this.CreateDisplayChars();
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0002BCA8 File Offset: 0x00029EA8
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x0002BCB0 File Offset: 0x00029EB0
		internal global::Infragistics.Windows.Editors.SignDisplayType SignType
		{
			get
			{
				return this.signType;
			}
			set
			{
				global::Infragistics.Windows.Editors.Utils.ValidateEnum("SignType", typeof(global::Infragistics.Windows.Editors.SignDisplayType), value);
				this.signType = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x0002BCD4 File Offset: 0x00029ED4
		internal bool IsNegative
		{
			get
			{
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
				int count = displayChars.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
					if (displayCharBase != null)
					{
						if (base.MinusSignChar == displayCharBase.Char)
						{
							return true;
						}
						if (!displayCharBase.IsEmpty)
						{
							return false;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0002BD24 File Offset: 0x00029F24
		internal bool SetNumberSign(bool negative)
		{
			if (this.IsNegative == negative)
			{
				return true;
			}
			global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			int count = displayChars.Count;
			global::Infragistics.Windows.Editors.DisplayCharBase firstFilledChar = this.FirstFilledChar;
			if (firstFilledChar == null)
			{
				if (negative)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase lastDisplayChar = base.LastDisplayChar;
					if (lastDisplayChar != null)
					{
						lastDisplayChar.Char = base.MinusSignChar;
					}
				}
				return true;
			}
			if (base.MinusSignChar == firstFilledChar.Char || base.PlusSignChar == firstFilledChar.Char)
			{
				if (negative)
				{
					firstFilledChar.Char = base.MinusSignChar;
				}
				else
				{
					firstFilledChar.Char = '\0';
				}
				return true;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase prevDisplayChar = firstFilledChar.PrevDisplayChar;
			if (prevDisplayChar == null || this != prevDisplayChar.Section)
			{
				return false;
			}
			if (negative)
			{
				prevDisplayChar.Char = base.MinusSignChar;
			}
			return true;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0002BDCC File Offset: 0x00029FCC
		internal bool VerifyMinMaxCache(bool verifyMin)
		{
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = base.MaskInfo;
			if (global::System.Windows.DependencyProperty.UnsetValue != this._lastMinValue && (verifyMin ? (object.Equals(maskInfo.MinValue, this._lastMinValue) && object.Equals(maskInfo.MinExclusive, this._lastMinValueExclusive)) : (object.Equals(maskInfo.MaxValue, this._lastMaxValue) && object.Equals(maskInfo.MaxExclusive, this._lastMaxValueExclusive))))
			{
				return false;
			}
			this._lastMinValue = maskInfo.MinValue;
			this._lastMaxValue = maskInfo.MaxValue;
			this._lastMinValueExclusive = maskInfo.MinExclusive;
			this._lastMaxValueExclusive = maskInfo.MaxExclusive;
			bool flag;
			decimal resolvedMinMaxValueHelper = this.GetResolvedMinMaxValueHelper(true, this._lastMinValue, this._lastMinValueExclusive, out this.isMinValueExclusive, out flag);
			bool flag2;
			decimal resolvedMinMaxValueHelper2 = this.GetResolvedMinMaxValueHelper(false, this._lastMaxValue, this._lastMaxValueExclusive, out this.isMaxValueExclusive, out flag2);
			decimal num = global::System.Math.Max(decimal.Truncate(resolvedMinMaxValueHelper), this.defaultMinValue);
			decimal num2 = global::System.Math.Min(decimal.Truncate(resolvedMinMaxValueHelper2), this.maxValue);
			global::Infragistics.Windows.Editors.FractionPart fractionPart = this.NextEditSection as global::Infragistics.Windows.Editors.FractionPart;
			if (fractionPart != null)
			{
				if (num == num2)
				{
					fractionPart.MinValue = (double)(global::System.Math.Abs(resolvedMinMaxValueHelper) - global::System.Math.Abs(num));
					fractionPart.MaxValue = (double)(global::System.Math.Abs(resolvedMinMaxValueHelper2) - global::System.Math.Abs(num2));
				}
				else
				{
					fractionPart.ResetMinValue();
					fractionPart.ResetMaxValue();
				}
			}
			this._lastCalculatedMinValue = num;
			this._lastCalculatedMaxValue = num2;
			this.lastConvertedMinValWithFractionPart = ((!flag) ? resolvedMinMaxValueHelper : (num + ((fractionPart != null) ? ((decimal)fractionPart.MinValue) : 0m)));
			this.lastConvertedMaxValWithFractionPart = ((!flag2) ? resolvedMinMaxValueHelper2 : (num2 + ((fractionPart != null) ? ((decimal)fractionPart.MaxValue) : 0m)));
			return true;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0002BFA9 File Offset: 0x0002A1A9
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0002BFBC File Offset: 0x0002A1BC
		public decimal MinValue
		{
			get
			{
				this.VerifyMinMaxCache(true);
				return this._lastCalculatedMinValue;
			}
			set
			{
				if (value < 0m && typeof(global::Infragistics.Windows.Editors.NumberSection) != base.GetType())
				{
					throw new global::System.ArgumentOutOfRangeException("MinValue", global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentOutOfRangeException_2"));
				}
				this.minValue = value;
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0002C00A File Offset: 0x0002A20A
		private static bool EqualsHelper(object o1, object o2)
		{
			return o1 == o2 || (o1 != null && o2 != null && o1.GetType() == o2.GetType() && o1.Equals(o2));
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0002C034 File Offset: 0x0002A234
		private object ConvertToDecimalHelper(object val)
		{
			if (val == null || global::System.DBNull.Value == val || val is global::System.DateTime)
			{
				return null;
			}
			if ((val is double && (double)val < -7.922816251426434E+28) || (val is float && (float)val < -7.9228163E+28f))
			{
				val = decimal.MinValue;
			}
			else if ((val is double && (double)val > 7.922816251426434E+28) || (val is float && (float)val > 7.9228163E+28f))
			{
				val = decimal.MaxValue;
			}
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = base.MaskInfo;
			return global::Infragistics.CoreUtilities.ConvertDataValue(val, typeof(decimal), maskInfo.FormatProvider, maskInfo.Format);
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0002C0FD File Offset: 0x0002A2FD
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x0002C110 File Offset: 0x0002A310
		public decimal MaxValue
		{
			get
			{
				this.VerifyMinMaxCache(false);
				return this._lastCalculatedMaxValue;
			}
			set
			{
				if (value < 0m && typeof(global::Infragistics.Windows.Editors.NumberSection) != base.GetType())
				{
					throw new global::System.ArgumentOutOfRangeException("MaxValue", global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentOutOfRangeException_3"));
				}
				this.maxValue = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0002C15E File Offset: 0x0002A35E
		internal int NumberOfDigits
		{
			get
			{
				return this.digits;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0002C166 File Offset: 0x0002A366
		internal override bool SupportsSpinning
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0002C16C File Offset: 0x0002A36C
		internal override bool CanSpin(bool up)
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
			if (text == null || text.Length == 0)
			{
				return true;
			}
			decimal d;
			try
			{
				if (!this.TryToDecimal(out d))
				{
					return false;
				}
			}
			catch (global::System.Exception)
			{
				return false;
			}
			if (base.MaskInfo.MaskEditor.SpinWrap)
			{
				return true;
			}
			if (up)
			{
				if (!this.isMaxValueExclusive)
				{
					return ++d <= this.MaxValue;
				}
				return ++d < this.MaxValue;
			}
			else
			{
				if (!this.isMinValueExclusive)
				{
					return --d >= this.MinValue;
				}
				return --d > this.MinValue;
			}
			bool result;
			return result;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0002C224 File Offset: 0x0002A424
		internal override bool Spin(bool up, bool setLimit)
		{
			return this.Spin(up, setLimit, this.MinValue, this.MaxValue);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0002C23C File Offset: 0x0002A43C
		internal bool Spin(bool up, bool setLimit, decimal minValue, decimal maxValue)
		{
			decimal num;
			if (setLimit)
			{
				num = (up ? maxValue : minValue);
			}
			else
			{
				string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
				if (text != null && text.Length > 0 && base.IsInt(text))
				{
					num = this.ToDecimal(text);
					num = (up ? (++num) : (--num));
				}
				else
				{
					num = (up ? minValue : maxValue);
					if (minValue < 0m && 0m < maxValue)
					{
						num = 0m;
					}
				}
			}
			return this.Spin(up, setLimit, num, minValue, maxValue);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0002C2CC File Offset: 0x0002A4CC
		internal bool Spin(bool up, bool setLimit, decimal val, decimal minValue, decimal maxValue)
		{
			if (up)
			{
				if (val <= maxValue)
				{
					this.SetText(global::Infragistics.Windows.Editors.NumberSection.DecimalToString(val));
				}
				else if (val > maxValue && base.MaskedEdit.SpinWrap)
				{
					this.SetText(global::Infragistics.Windows.Editors.NumberSection.DecimalToString(minValue));
				}
			}
			else if (val >= minValue)
			{
				this.SetText(global::Infragistics.Windows.Editors.NumberSection.DecimalToString(val));
			}
			else if (val < minValue && base.MaskedEdit.SpinWrap)
			{
				this.SetText(global::Infragistics.Windows.Editors.NumberSection.DecimalToString(maxValue));
			}
			return true;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0002C358 File Offset: 0x0002A558
		internal static string PadNumber(long n, int totalWidthOfResultingString)
		{
			string text = n.ToString();
			if (text.Length >= totalWidthOfResultingString)
			{
				return text;
			}
			return new string('0', totalWidthOfResultingString - text.Length) + text;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0002C390 File Offset: 0x0002A590
		internal override bool IsInputFull()
		{
			if (this.SignType != global::Infragistics.Windows.Editors.SignDisplayType.None && base.DisplayChars.Count > 1)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase nextDisplayChar = base.FirstDisplayChar.NextDisplayChar;
				if (nextDisplayChar != null && !nextDisplayChar.IsEmpty && '0' != nextDisplayChar.Char && base.PlusSignChar != nextDisplayChar.Char && base.MinusSignChar != nextDisplayChar.Char)
				{
					return true;
				}
			}
			return !base.FirstDisplayChar.IsEmpty && '0' != base.FirstDisplayChar.Char;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0002C414 File Offset: 0x0002A614
		public override void SetText(string text)
		{
			int num = text.Length - 1;
			base.EraseAllChars();
			char commaChar = base.CommaChar;
			global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			for (int i = displayChars.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
				if (displayCharBase.IsEditable)
				{
					while (num >= 0 && commaChar == text[num])
					{
						num--;
					}
					char @char = '\0';
					if (num >= 0)
					{
						@char = text[num--];
					}
					displayCharBase.Char = @char;
				}
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0002C494 File Offset: 0x0002A694
		internal void SetText(string text, bool autoExpand)
		{
			if (autoExpand && text.Length > 0 && text.Length > base.DisplayChars.Count - 1)
			{
				char c = text[0];
				bool flag = !char.IsDigit(c) && (base.PlusSignChar == c || base.MinusSignChar == c);
				int num = text.Length - (flag ? 1 : 0);
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
				bool flag2 = this.MinValue < 0m;
				int num2 = displayChars.Count - (flag2 ? 1 : 0);
				if (num > num2)
				{
					global::System.IFormatProvider formatProvider = base.MaskInfo.FormatProvider;
					global::Infragistics.Windows.Editors.SectionsCollection sectionsCollection;
					global::Infragistics.Windows.Editors.MaskParser.Parse(global::Infragistics.Windows.Editors.XamMaskedEditor.CalcDefaultDoubleMask(formatProvider, num, 0, '-'), out sectionsCollection, formatProvider);
					global::Infragistics.Windows.Editors.NumberSection numberSection = (sectionsCollection != null && sectionsCollection.Count > 0) ? (sectionsCollection[0] as global::Infragistics.Windows.Editors.NumberSection) : null;
					if (numberSection != null)
					{
						if (base.Sections != null)
						{
							base.Sections._isCacheInvalid = true;
						}
						this._lastMinValue = global::System.Windows.DependencyProperty.UnsetValue;
						base.DisplayChars.Clear();
						this.InternalInitialize(num, numberSection.commaPositions, this.signType);
					}
				}
			}
			this.SetText(text);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0002C5C0 File Offset: 0x0002A7C0
		internal int ToInt()
		{
			return (int)this.ToDecimal();
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0002C5CD File Offset: 0x0002A7CD
		internal decimal ToDecimal()
		{
			return this.ToDecimal(this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw));
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0002C5DC File Offset: 0x0002A7DC
		internal decimal ToDecimal(string rawText)
		{
			decimal result;
			if (!this.ParseToInt(rawText, out result))
			{
				throw new global::System.FormatException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_Exception_72"));
			}
			return result;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0002C605 File Offset: 0x0002A805
		internal bool TryToDecimal(out decimal value)
		{
			return this.ParseToInt(out value);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0002C610 File Offset: 0x0002A810
		internal bool TryToInt(out int value)
		{
			decimal value2;
			if (this.ParseToInt(out value2))
			{
				value = (int)value2;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0002C635 File Offset: 0x0002A835
		internal bool ParseToInt(out decimal val)
		{
			return this.ParseToInt(this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw), out val);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0002C648 File Offset: 0x0002A848
		internal virtual bool ParseToInt(string rawText, out decimal val)
		{
			if (string.IsNullOrEmpty(rawText))
			{
				val = 0m;
				return false;
			}
			if (!decimal.TryParse(rawText, out val) || val % 1m != 0m)
			{
				val = 0m;
				return false;
			}
			return true;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0002C6A1 File Offset: 0x0002A8A1
		internal static string DecimalToString(decimal val)
		{
			return val.ToString();
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0002C6AA File Offset: 0x0002A8AA
		internal static decimal StringToDecimal(string val)
		{
			return decimal.Parse(val);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0002C6B4 File Offset: 0x0002A8B4
		internal override string GetText(global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			if (base.DisplayChars == null || base.DisplayChars.Count <= 0)
			{
				return null;
			}
			int count = base.DisplayChars.Count;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(string.Empty, 1 + this.digits);
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Editors.DigitChar digitChar = base.DisplayChars[i] as global::Infragistics.Windows.Editors.DigitChar;
				if (digitChar != null && digitChar.Char != '\0')
				{
					stringBuilder.Append(digitChar.Char);
					if (digitChar.ShouldIncludeComma(maskMode))
					{
						char commaChar = base.CommaChar;
						if (commaChar != '\0')
						{
							stringBuilder.Append(commaChar);
						}
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0002C752 File Offset: 0x0002A952
		internal override bool CanShiftRight(int from, int positionsToShift)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_4"));
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0002C763 File Offset: 0x0002A963
		internal override bool CanShiftLeft(int from, int positionsToShift)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_5"));
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0002C774 File Offset: 0x0002A974
		internal override bool ShiftLeft(int from, int positionsToShift)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_6"));
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0002C785 File Offset: 0x0002A985
		internal override bool ShiftRight(int from, int positionsToShift)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_7"));
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0002C796 File Offset: 0x0002A996
		internal override bool DeleteCharWithNoShift(int pos)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_8"));
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0002C7A7 File Offset: 0x0002A9A7
		internal bool IgnoreStrictSignChecking
		{
			get
			{
				return this.ignoreStrictSignChecking;
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0002C7B0 File Offset: 0x0002A9B0
		internal override bool DeleteCharsAndShift(int pos, int count)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			this.ignoreStrictSignChecking = true;
			try
			{
				for (int i = pos; i >= 0; i--)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.SafeDisplayCharAt(i);
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase2 = base.SafeDisplayCharAt(i - count);
					if (displayCharBase == null || displayCharBase.IsEditable)
					{
						if (displayCharBase2 != null && !displayCharBase2.IsEditable)
						{
							int num = count + 1;
							while (displayCharBase2 != null && !displayCharBase2.IsEditable)
							{
								displayCharBase2 = base.SafeDisplayCharAt(i - num);
								num++;
							}
						}
						if (displayCharBase != null)
						{
							displayCharBase.Char = ((displayCharBase2 != null) ? displayCharBase2.Char : '\0');
						}
					}
				}
			}
			finally
			{
				this.ignoreStrictSignChecking = false;
			}
			return true;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0002C85C File Offset: 0x0002AA5C
		internal override bool DeleteCharAndShift(int pos)
		{
			return this.DeleteCharsAndShift(pos, 1);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0002C868 File Offset: 0x0002AA68
		private bool GetIntValueIfInserted(int pos, char c, out decimal newVal)
		{
			int count = base.DisplayChars.Count;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int i;
			for (i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
				if (!(displayCharBase is global::Infragistics.Windows.Editors.DigitChar))
				{
					break;
				}
				if (displayCharBase.Char != '\0')
				{
					stringBuilder.Append(displayCharBase.Char);
				}
				if (i == pos && c != '\0')
				{
					stringBuilder.Append(c);
				}
			}
			if (i == pos && c != '\0')
			{
				stringBuilder.Append(c);
			}
			newVal = 0m;
			return decimal.TryParse(stringBuilder.ToString(), out newVal);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0002C8F4 File Offset: 0x0002AAF4
		internal override bool CanInsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.SafeDisplayCharAt(pos);
			if (c == '\0')
			{
				return false;
			}
			if (!displayCharBase.MatchChar(c))
			{
				return false;
			}
			if (this.IsInputFull())
			{
				return false;
			}
			if (char.IsDigit(c))
			{
				decimal d;
				if (!this.GetIntValueIfInserted(pos, c, out d))
				{
					return false;
				}
				if (d >= 0m)
				{
					if (d > this.MaxValue)
					{
						return false;
					}
				}
				else if (d < this.MinValue)
				{
					return false;
				}
			}
			return base.FirstDisplayChar.IsEmpty || displayCharBase.IsEmpty || ('0' == base.FirstDisplayChar.Char && base.GetType() == typeof(global::Infragistics.Windows.Editors.NumberSection) && this.NextEditSection is global::Infragistics.Windows.Editors.FractionPart);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0002C9C8 File Offset: 0x0002ABC8
		internal override bool InsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.SafeDisplayCharAt(pos);
			if (!this.CanInsertCharAt(pos, c))
			{
				return false;
			}
			for (int i = 0; i < pos; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase2 = base.SafeDisplayCharAt(i);
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase3 = base.SafeDisplayCharAt(i + 1);
				if (displayCharBase2.IsEditable)
				{
					if (!displayCharBase3.IsEditable)
					{
						int num = 2;
						while (displayCharBase3 != null && !displayCharBase3.IsEditable)
						{
							displayCharBase3 = base.SafeDisplayCharAt(i + num);
							num++;
						}
					}
					displayCharBase2.Char = displayCharBase3.Char;
				}
			}
			displayCharBase.Char = c;
			return true;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0002CA60 File Offset: 0x0002AC60
		internal static string StripOutPadPromptCharacters(string str, global::Infragistics.Windows.Editors.SectionBase section)
		{
			char c = (section.Sections.MaskInfo != null) ? section.Sections.MaskInfo.PadChar : ' ';
			char c2 = (section.Sections.MaskInfo != null) ? section.Sections.MaskInfo.PromptChar : '_';
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(str.Length);
			bool flag = false;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] != c && str[i] != c2)
				{
					stringBuilder.Append(str[i]);
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				return str;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0002CB08 File Offset: 0x0002AD08
		public override bool ValidateString(ref string str)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(str.Length);
			char commaChar = base.CommaChar;
			str = global::Infragistics.Windows.Editors.NumberSection.StripOutPadPromptCharacters(str, this);
			for (int i = 0; i < str.Length; i++)
			{
				if (commaChar != str[i])
				{
					stringBuilder.Append(str[i]);
				}
			}
			if (base.IsInt(stringBuilder.ToString()))
			{
				try
				{
					decimal d;
					if (!decimal.TryParse(stringBuilder.ToString(), out d))
					{
						return false;
					}
					if (d < this.MinValue || d > this.MaxValue)
					{
						return false;
					}
				}
				catch (global::System.Exception)
				{
					return false;
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0002CBC0 File Offset: 0x0002ADC0
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
			if (!base.IsInt(text))
			{
				return false;
			}
			string text2;
			if (!this.ValidateAgainstMinMaxHelper(text, out text2))
			{
				return false;
			}
			if (contentModificationsAllowed)
			{
				this.SetText(text);
			}
			return true;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0002CBFC File Offset: 0x0002ADFC
		internal bool ValidateAgainstMinMaxHelper(string rawText, out string error)
		{
			error = null;
			decimal d;
			if (!this.ParseToInt(rawText, out d))
			{
				d = 0m;
			}
			if (d < this.minValue)
			{
				error = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_MinInclusive", new object[]
				{
					this.minValue
				});
				return false;
			}
			if (d > this.maxValue)
			{
				error = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_MaxInclusive", new object[]
				{
					this.maxValue
				});
				return false;
			}
			return true;
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0002CC83 File Offset: 0x0002AE83
		public override global::Infragistics.Windows.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Windows.Editors.EditOrientation.RightToLeft;
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0002CC88 File Offset: 0x0002AE88
		protected void CreateDisplayChars()
		{
			int num = this.digits;
			if (this.signType != global::Infragistics.Windows.Editors.SignDisplayType.None)
			{
				num++;
			}
			for (int i = 0; i < num; i++)
			{
				global::Infragistics.Windows.Editors.DigitChar digitChar = new global::Infragistics.Windows.Editors.DigitChar(this);
				base.DisplayChars.Add(digitChar);
				if (this.commaPositions != null && -1 != global::System.Array.IndexOf<int>(this.commaPositions, (this.signType != global::Infragistics.Windows.Editors.SignDisplayType.None) ? (i - 1) : i))
				{
					digitChar.HasComma = true;
				}
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0002CCF4 File Offset: 0x0002AEF4
		internal override void InternalCopy(global::Infragistics.Windows.Editors.SectionBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Windows.Editors.NumberSection numberSection = (global::Infragistics.Windows.Editors.NumberSection)dest;
			if (this.commaPositions != null)
			{
				numberSection.commaPositions = new int[this.commaPositions.Length];
				this.commaPositions.CopyTo(numberSection.commaPositions, 0);
			}
			numberSection.digits = this.digits;
			numberSection.maxValue = this.maxValue;
			numberSection.minValue = this.minValue;
			numberSection.defaultMinValue = this.defaultMinValue;
			numberSection.signType = this.signType;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0002CD78 File Offset: 0x0002AF78
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.NumberSection numberSection = new global::Infragistics.Windows.Editors.NumberSection(this.digits, this.commaPositions, this.signType);
			this.InternalCopy(numberSection);
			numberSection.InitSectionsCollection(sections);
			return numberSection;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0002CDAC File Offset: 0x0002AFAC
		private decimal GetResolvedMinMaxValueHelper(bool calculatingMin, object val, object exclusive, out bool isExclusive, out bool isDefaultBasedOnSection)
		{
			object obj = null;
			object obj2 = null;
			if (!global::Infragistics.Windows.Editors.XamMaskedEditor.IsDateTimeSection(this))
			{
				obj = this.ConvertToDecimalHelper(val);
				obj2 = this.ConvertToDecimalHelper(exclusive);
			}
			object obj3 = obj;
			isExclusive = false;
			if (obj2 != null && (obj == null || (calculatingMin ? ((decimal)obj2 >= (decimal)obj) : ((decimal)obj2 <= (decimal)obj))))
			{
				obj3 = obj2;
				isExclusive = true;
			}
			isDefaultBasedOnSection = (null == obj3);
			if (obj3 != null)
			{
				return (decimal)obj3;
			}
			if (!calculatingMin)
			{
				return this.maxValue;
			}
			return this.minValue;
		}

		// Token: 0x0400038B RID: 907
		private int digits;

		// Token: 0x0400038C RID: 908
		private int[] commaPositions;

		// Token: 0x0400038D RID: 909
		private decimal minValue;

		// Token: 0x0400038E RID: 910
		private decimal maxValue = 2147483647m;

		// Token: 0x0400038F RID: 911
		private global::Infragistics.Windows.Editors.SignDisplayType signType;

		// Token: 0x04000390 RID: 912
		private bool ignoreStrictSignChecking;

		// Token: 0x04000391 RID: 913
		private object _lastMinValue = global::System.Windows.DependencyProperty.UnsetValue;

		// Token: 0x04000392 RID: 914
		private object _lastMaxValue;

		// Token: 0x04000393 RID: 915
		private object _lastMinValueExclusive;

		// Token: 0x04000394 RID: 916
		private object _lastMaxValueExclusive;

		// Token: 0x04000395 RID: 917
		private decimal _lastCalculatedMinValue;

		// Token: 0x04000396 RID: 918
		private decimal _lastCalculatedMaxValue;

		// Token: 0x04000397 RID: 919
		internal decimal lastConvertedMinValWithFractionPart = decimal.MinValue;

		// Token: 0x04000398 RID: 920
		internal decimal lastConvertedMaxValWithFractionPart = decimal.MaxValue;

		// Token: 0x04000399 RID: 921
		private bool isMinValueExclusive;

		// Token: 0x0400039A RID: 922
		private bool isMaxValueExclusive;

		// Token: 0x0400039B RID: 923
		private decimal defaultMinValue;
	}
}
