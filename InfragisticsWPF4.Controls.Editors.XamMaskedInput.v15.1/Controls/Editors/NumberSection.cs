using System;
using System.Text;
using System.Windows;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000037 RID: 55
	public class NumberSection : global::Infragistics.Controls.Editors.EditSectionBase
	{
		// Token: 0x060001DF RID: 479 RVA: 0x0000C9E2 File Offset: 0x0000ABE2
		internal NumberSection(int digits) : this(digits, null, global::Infragistics.Controls.Editors.SignDisplayType.None)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		internal NumberSection(int digits, int[] commaPositions, global::Infragistics.Controls.Editors.SignDisplayType signType)
		{
			this.InternalInitialize(digits, commaPositions, signType);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		private void InternalInitialize(int digits, int[] commaPositions, global::Infragistics.Controls.Editors.SignDisplayType signType)
		{
			if (digits <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("digits", global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentOutOfRangeException_1"));
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
			if (signType != global::Infragistics.Controls.Editors.SignDisplayType.None)
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000CB8C File Offset: 0x0000AD8C
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x0000CB94 File Offset: 0x0000AD94
		internal global::Infragistics.Controls.Editors.SignDisplayType SignType
		{
			get
			{
				return this.signType;
			}
			set
			{
				global::Infragistics.Controls.Editors.Primitives.Utils.ValidateEnum("SignType", typeof(global::Infragistics.Controls.Editors.SignDisplayType), value);
				this.signType = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		internal bool IsNegative
		{
			get
			{
				global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
				int count = displayChars.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000CC05 File Offset: 0x0000AE05
		internal global::Infragistics.Controls.Editors.FractionPart FractionPart
		{
			get
			{
				return this.NextEditSection as global::Infragistics.Controls.Editors.FractionPart;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000CC14 File Offset: 0x0000AE14
		internal bool IsFractionPartNonEmpty
		{
			get
			{
				global::Infragistics.Controls.Editors.FractionPart fractionPart = this.FractionPart;
				return fractionPart != null && !fractionPart.IsEmpty;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000CC38 File Offset: 0x0000AE38
		internal bool SetNumberSign(bool negative)
		{
			if (this.IsNegative == negative)
			{
				return true;
			}
			global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			int count = displayChars.Count;
			global::Infragistics.Controls.Editors.DisplayCharBase firstFilledChar = this.FirstFilledChar;
			if (firstFilledChar == null)
			{
				if (negative)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase lastDisplayChar = base.LastDisplayChar;
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
			global::Infragistics.Controls.Editors.DisplayCharBase prevDisplayChar = firstFilledChar.PrevDisplayChar;
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

		// Token: 0x060001E8 RID: 488 RVA: 0x0000CCE0 File Offset: 0x0000AEE0
		internal bool VerifyMinMaxCache(bool verifyMin)
		{
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = base.MaskInfo;
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
			global::Infragistics.Controls.Editors.FractionPart fractionPart = this.NextEditSection as global::Infragistics.Controls.Editors.FractionPart;
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

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000CEBD File Offset: 0x0000B0BD
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		public decimal MinValue
		{
			get
			{
				this.VerifyMinMaxCache(true);
				return this._lastCalculatedMinValue;
			}
			set
			{
				if (value < 0m && typeof(global::Infragistics.Controls.Editors.NumberSection) != base.GetType())
				{
					throw new global::System.ArgumentOutOfRangeException("MinValue", global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentOutOfRangeException_2"));
				}
				this.minValue = value;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000CF1E File Offset: 0x0000B11E
		private static bool EqualsHelper(object o1, object o2)
		{
			return o1 == o2 || (o1 != null && o2 != null && o1.GetType() == o2.GetType() && o1.Equals(o2));
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000CF48 File Offset: 0x0000B148
		private object ConvertToDecimalHelper(object val)
		{
			if (global::Infragistics.CoreUtilities.IsNull(val) || val is global::System.DateTime)
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
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = base.MaskInfo;
			return global::Infragistics.CoreUtilities.ConvertDataValue(val, typeof(decimal), maskInfo.FormatProvider, maskInfo.Format);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000D00E File Offset: 0x0000B20E
		// (set) Token: 0x060001EE RID: 494 RVA: 0x0000D020 File Offset: 0x0000B220
		public decimal MaxValue
		{
			get
			{
				this.VerifyMinMaxCache(false);
				return this._lastCalculatedMaxValue;
			}
			set
			{
				if (value < 0m && typeof(global::Infragistics.Controls.Editors.NumberSection) != base.GetType())
				{
					throw new global::System.ArgumentOutOfRangeException("MaxValue", global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentOutOfRangeException_3"));
				}
				this.maxValue = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000D06E File Offset: 0x0000B26E
		internal int NumberOfDigits
		{
			get
			{
				return this.digits;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000D076 File Offset: 0x0000B276
		internal override bool SupportsSpinning
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000D07C File Offset: 0x0000B27C
		internal override bool CanSpin(bool up)
		{
			string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
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
			if (base.MaskInfo.MaskedInput.SpinWrap)
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

		// Token: 0x060001F2 RID: 498 RVA: 0x0000D134 File Offset: 0x0000B334
		internal override bool Spin(bool up, bool setLimit)
		{
			return this.Spin(up, setLimit, this.MinValue, this.MaxValue);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000D14C File Offset: 0x0000B34C
		internal bool Spin(bool up, bool setLimit, decimal minValue, decimal maxValue)
		{
			decimal num;
			if (setLimit)
			{
				num = (up ? maxValue : minValue);
			}
			else
			{
				string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
				if (text != null && text.Length > 0 && base.IsInt(text))
				{
					num = this.ToDecimal();
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

		// Token: 0x060001F4 RID: 500 RVA: 0x0000D1D8 File Offset: 0x0000B3D8
		internal bool Spin(bool up, bool setLimit, decimal val, decimal minValue, decimal maxValue)
		{
			if (up)
			{
				if (val <= maxValue)
				{
					this.SetText(global::Infragistics.Controls.Editors.NumberSection.DecimalToString(val));
				}
				else if (val > maxValue && base.MaskedEdit.SpinWrap)
				{
					this.SetText(global::Infragistics.Controls.Editors.NumberSection.DecimalToString(minValue));
				}
			}
			else if (val >= minValue)
			{
				this.SetText(global::Infragistics.Controls.Editors.NumberSection.DecimalToString(val));
			}
			else if (val < minValue && base.MaskedEdit.SpinWrap)
			{
				this.SetText(global::Infragistics.Controls.Editors.NumberSection.DecimalToString(maxValue));
			}
			return true;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000D264 File Offset: 0x0000B464
		internal static string PadNumber(long n, int totalWidthOfResultingString)
		{
			string text = n.ToString();
			if (text.Length >= totalWidthOfResultingString)
			{
				return text;
			}
			return new string('0', totalWidthOfResultingString - text.Length) + text;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000D29C File Offset: 0x0000B49C
		internal override bool IsInputFull()
		{
			if (this.SignType != global::Infragistics.Controls.Editors.SignDisplayType.None && base.DisplayChars.Count > 1)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase nextDisplayChar = base.FirstDisplayChar.NextDisplayChar;
				if (nextDisplayChar != null && !nextDisplayChar.IsEmpty && '0' != nextDisplayChar.Char && base.PlusSignChar != nextDisplayChar.Char && base.MinusSignChar != nextDisplayChar.Char)
				{
					return true;
				}
			}
			return !base.FirstDisplayChar.IsEmpty && '0' != base.FirstDisplayChar.Char;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000D320 File Offset: 0x0000B520
		internal bool HasOnlySignSymbol
		{
			get
			{
				string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
				if (1 == text.Length)
				{
					char c = text[0];
					if (base.PlusSignChar == c || base.MinusSignChar == c)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000D35C File Offset: 0x0000B55C
		public override void SetText(string text)
		{
			int num = text.Length - 1;
			base.EraseAllChars();
			char commaChar = base.CommaChar;
			global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			for (int i = displayChars.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
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

		// Token: 0x060001F9 RID: 505 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		internal void SetText(string text, bool autoExpand)
		{
			if (autoExpand && text.Length > 0 && text.Length > base.DisplayChars.Count - 1)
			{
				char c = text[0];
				bool flag = !char.IsDigit(c) && (base.PlusSignChar == c || base.MinusSignChar == c);
				int num = text.Length - (flag ? 1 : 0);
				global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
				bool flag2 = this.MinValue < 0m;
				int num2 = displayChars.Count - (flag2 ? 1 : 0);
				if (num > num2)
				{
					global::System.IFormatProvider formatProvider = base.MaskInfo.FormatProvider;
					global::Infragistics.Controls.Editors.SectionsCollection sectionsCollection;
					global::Infragistics.Controls.Editors.MaskParser.Parse(global::Infragistics.Controls.Editors.XamMaskedInput.CalcDefaultDoubleMask(formatProvider, num, 0, '-'), out sectionsCollection, formatProvider);
					global::Infragistics.Controls.Editors.NumberSection numberSection = (sectionsCollection != null && sectionsCollection.Count > 0) ? (sectionsCollection[0] as global::Infragistics.Controls.Editors.NumberSection) : null;
					if (numberSection != null)
					{
						if (base.Sections != null)
						{
							base.Sections._isCacheInvalid = true;
						}
						base.DisplayChars.Clear();
						this.InternalInitialize(num, numberSection.commaPositions, this.signType);
					}
				}
			}
			this.SetText(text);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000D4FA File Offset: 0x0000B6FA
		internal int ToInt()
		{
			return (int)this.ToDecimal();
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000D508 File Offset: 0x0000B708
		internal decimal ToDecimal()
		{
			decimal result;
			if (!this.ParseToInt(out result))
			{
				throw new global::System.FormatException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_Exception_72"));
			}
			return result;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000D530 File Offset: 0x0000B730
		internal bool TryToDecimal(out decimal value)
		{
			return this.ParseToInt(out value);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000D53C File Offset: 0x0000B73C
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

		// Token: 0x060001FE RID: 510 RVA: 0x0000D564 File Offset: 0x0000B764
		internal virtual bool ParseToInt(out decimal val)
		{
			val = 0m;
			string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
			return !string.IsNullOrEmpty(text) && base.IsInt(text) && decimal.TryParse(text, out val);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000D59F File Offset: 0x0000B79F
		internal static string DecimalToString(decimal val)
		{
			return val.ToString();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		internal static decimal StringToDecimal(string val)
		{
			return decimal.Parse(val);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
		internal override string GetText(global::Infragistics.Controls.Editors.InputMaskMode maskMode)
		{
			if (base.DisplayChars == null || base.DisplayChars.Count <= 0)
			{
				return null;
			}
			int count = base.DisplayChars.Count;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(string.Empty, 1 + this.digits);
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Controls.Editors.DigitChar digitChar = base.DisplayChars[i] as global::Infragistics.Controls.Editors.DigitChar;
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

		// Token: 0x06000202 RID: 514 RVA: 0x0000D64E File Offset: 0x0000B84E
		internal override bool CanShiftRight(int from, int positionsToShift)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_InvalidOperationException_4"));
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000D65F File Offset: 0x0000B85F
		internal override bool CanShiftLeft(int from, int positionsToShift)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_InvalidOperationException_5"));
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000D670 File Offset: 0x0000B870
		internal override bool ShiftLeft(int from, int positionsToShift)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_InvalidOperationException_6"));
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000D681 File Offset: 0x0000B881
		internal override bool ShiftRight(int from, int positionsToShift)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_InvalidOperationException_7"));
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000D692 File Offset: 0x0000B892
		internal override bool DeleteCharWithNoShift(int pos)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_InvalidOperationException_8"));
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000D6A3 File Offset: 0x0000B8A3
		internal bool IgnoreStrictSignChecking
		{
			get
			{
				return this.ignoreStrictSignChecking;
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000D6AC File Offset: 0x0000B8AC
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
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.SafeDisplayCharAt(i);
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase2 = base.SafeDisplayCharAt(i - count);
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

		// Token: 0x06000209 RID: 521 RVA: 0x0000D758 File Offset: 0x0000B958
		internal override bool DeleteCharAndShift(int pos)
		{
			return this.DeleteCharsAndShift(pos, 1);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000D764 File Offset: 0x0000B964
		private bool GetIntValueIfInserted(int pos, char c, out decimal newVal)
		{
			int count = base.DisplayChars.Count;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int i;
			for (i = 0; i < count; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
				if (!(displayCharBase is global::Infragistics.Controls.Editors.DigitChar))
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

		// Token: 0x0600020B RID: 523 RVA: 0x0000D7F0 File Offset: 0x0000B9F0
		internal override bool CanInsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.SafeDisplayCharAt(pos);
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
			return base.FirstDisplayChar.IsEmpty || displayCharBase.IsEmpty || ('0' == base.FirstDisplayChar.Char && base.GetType() == typeof(global::Infragistics.Controls.Editors.NumberSection) && this.NextEditSection is global::Infragistics.Controls.Editors.FractionPart);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
		internal override bool InsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.SafeDisplayCharAt(pos);
			if (!this.CanInsertCharAt(pos, c))
			{
				return false;
			}
			for (int i = 0; i < pos; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase2 = base.SafeDisplayCharAt(i);
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase3 = base.SafeDisplayCharAt(i + 1);
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

		// Token: 0x0600020D RID: 525 RVA: 0x0000D95C File Offset: 0x0000BB5C
		internal static string StripOutPadPromptCharacters(string str, global::Infragistics.Controls.Editors.SectionBase section)
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

		// Token: 0x0600020E RID: 526 RVA: 0x0000DA04 File Offset: 0x0000BC04
		public override bool ValidateString(ref string str)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(str.Length);
			char commaChar = base.CommaChar;
			str = global::Infragistics.Controls.Editors.NumberSection.StripOutPadPromptCharacters(str, this);
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

		// Token: 0x0600020F RID: 527 RVA: 0x0000DABC File Offset: 0x0000BCBC
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
			if (!base.IsInt(text))
			{
				return false;
			}
			string text2;
			if (!this.ValidateAgainstMinMaxHelper(out text2))
			{
				return false;
			}
			if (contentModificationsAllowed)
			{
				this.SetText(text);
			}
			return true;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		internal bool ValidateAgainstMinMaxHelper(out string error)
		{
			error = null;
			decimal d;
			if (!this.ParseToInt(out d))
			{
				d = 0m;
			}
			if (d < this.minValue)
			{
				error = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_MinInclusive", new object[]
				{
					this.minValue
				});
				return false;
			}
			if (d > this.maxValue)
			{
				error = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_MaxInclusive", new object[]
				{
					this.maxValue
				});
				return false;
			}
			return true;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000DB7E File Offset: 0x0000BD7E
		public override global::Infragistics.Controls.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Controls.Editors.EditOrientation.RightToLeft;
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000DB84 File Offset: 0x0000BD84
		protected void CreateDisplayChars()
		{
			int num = this.digits;
			if (this.signType != global::Infragistics.Controls.Editors.SignDisplayType.None)
			{
				num++;
			}
			for (int i = 0; i < num; i++)
			{
				global::Infragistics.Controls.Editors.DigitChar digitChar = new global::Infragistics.Controls.Editors.DigitChar(this);
				base.DisplayChars.Add(digitChar);
				if (this.commaPositions != null && -1 != global::System.Array.IndexOf<int>(this.commaPositions, (this.signType != global::Infragistics.Controls.Editors.SignDisplayType.None) ? (i - 1) : i))
				{
					digitChar.HasComma = true;
				}
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		internal override void InternalCopy(global::Infragistics.Controls.Editors.SectionBase dest)
		{
			if (base.GetType() != dest.GetType())
			{
				throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentException_2"), "dest");
			}
			base.InternalCopy(dest);
			global::Infragistics.Controls.Editors.NumberSection numberSection = (global::Infragistics.Controls.Editors.NumberSection)dest;
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

		// Token: 0x06000214 RID: 532 RVA: 0x0000DC9C File Offset: 0x0000BE9C
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.NumberSection numberSection = new global::Infragistics.Controls.Editors.NumberSection(this.digits, this.commaPositions, this.signType);
			this.InternalCopy(numberSection);
			numberSection.InitSectionsCollection(sections);
			return numberSection;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		private decimal GetResolvedMinMaxValueHelper(bool calculatingMin, object val, object exclusive, out bool isExclusive, out bool isDefaultBasedOnSection)
		{
			object obj = null;
			object obj2 = null;
			if (!global::Infragistics.Controls.Editors.XamMaskedInput.IsDateTimeSection(this))
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

		// Token: 0x040000D4 RID: 212
		private int digits;

		// Token: 0x040000D5 RID: 213
		private int[] commaPositions;

		// Token: 0x040000D6 RID: 214
		private decimal minValue;

		// Token: 0x040000D7 RID: 215
		private decimal maxValue = 2147483647m;

		// Token: 0x040000D8 RID: 216
		private global::Infragistics.Controls.Editors.SignDisplayType signType;

		// Token: 0x040000D9 RID: 217
		private bool ignoreStrictSignChecking;

		// Token: 0x040000DA RID: 218
		private object _lastMinValue = global::System.Windows.DependencyProperty.UnsetValue;

		// Token: 0x040000DB RID: 219
		private object _lastMaxValue;

		// Token: 0x040000DC RID: 220
		private object _lastMinValueExclusive;

		// Token: 0x040000DD RID: 221
		private object _lastMaxValueExclusive;

		// Token: 0x040000DE RID: 222
		private decimal _lastCalculatedMinValue;

		// Token: 0x040000DF RID: 223
		private decimal _lastCalculatedMaxValue;

		// Token: 0x040000E0 RID: 224
		internal decimal lastConvertedMinValWithFractionPart = decimal.MinValue;

		// Token: 0x040000E1 RID: 225
		internal decimal lastConvertedMaxValWithFractionPart = decimal.MaxValue;

		// Token: 0x040000E2 RID: 226
		private bool isMinValueExclusive;

		// Token: 0x040000E3 RID: 227
		private bool isMaxValueExclusive;

		// Token: 0x040000E4 RID: 228
		private decimal defaultMinValue;
	}
}
