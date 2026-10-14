using System;
using System.Text;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000B5 RID: 181
	public class FractionPart : global::Infragistics.Windows.Editors.EditSectionBase
	{
		// Token: 0x060009DC RID: 2524 RVA: 0x0002DFAE File Offset: 0x0002C1AE
		internal FractionPart(int digits)
		{
			this.digits = digits;
			this.ResetMaxValue();
			this.CreateDisplayChars();
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0002DFD0 File Offset: 0x0002C1D0
		public int NumberOfDigits
		{
			get
			{
				return this.digits;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x0002DFE0 File Offset: 0x0002C1E0
		internal double MinValue
		{
			get
			{
				return this.minValue;
			}
			set
			{
				this.minValue = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0002DFE9 File Offset: 0x0002C1E9
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x0002DFF1 File Offset: 0x0002C1F1
		internal double MaxValue
		{
			get
			{
				return this.maxValue;
			}
			set
			{
				this.maxValue = value;
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002DFFA File Offset: 0x0002C1FA
		internal void ResetMaxValue()
		{
			this.maxValue = 1.0 - global::System.Math.Pow(10.0, (double)(-(double)this.digits));
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002E022 File Offset: 0x0002C222
		internal void ResetMinValue()
		{
			this.minValue = 0.0;
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0002E034 File Offset: 0x0002C234
		internal double DeltaValue
		{
			get
			{
				return global::System.Math.Pow(10.0, (double)(-(double)this.digits));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0002E059 File Offset: 0x0002C259
		internal virtual bool ContinuousEditing
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0002E05C File Offset: 0x0002C25C
		internal override bool CanInsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[pos];
			return displayCharBase != null && displayCharBase.IsEditable && displayCharBase.MatchChar(c) && (base.LastDisplayChar.IsEmpty || '0' == base.LastDisplayChar.Char);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0002E0C4 File Offset: 0x0002C2C4
		internal override bool InsertCharAt(int pos, char c)
		{
			if (c == '\0')
			{
				return false;
			}
			if (this.CanInsertCharAt(pos, c))
			{
				for (int i = base.DisplayChars.Count - 1; i > pos; i--)
				{
					base.DisplayChars[i].Char = base.DisplayChars[i - 1].Char;
				}
				base.DisplayChars[pos].Char = c;
				return true;
			}
			return false;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0002E131 File Offset: 0x0002C331
		internal override bool DeleteCharAndShift(int pos)
		{
			return this.DeleteCharsAndShift(pos, 1);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0002E13C File Offset: 0x0002C33C
		internal override bool DeleteCharsAndShift(int pos, int count)
		{
			int count2 = base.DisplayChars.Count;
			if (pos < 0 || pos >= count2)
			{
				return false;
			}
			for (int i = pos; i < count2; i++)
			{
				char @char = '\0';
				if (count + i < count2)
				{
					@char = base.DisplayChars[count + i].Char;
				}
				base.DisplayChars[i].Char = @char;
			}
			for (int j = 0; j < count; j++)
			{
				base.DisplayChars[count2 - j - 1].Char = '\0';
			}
			return true;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0002E1BC File Offset: 0x0002C3BC
		public override void SetText(string text)
		{
			int num = 0;
			global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			int count = displayChars.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
				if (displayCharBase.IsEditable)
				{
					char @char = '\0';
					if (num >= 0 && num < text.Length)
					{
						@char = text[num++];
					}
					displayCharBase.Char = @char;
				}
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0002E21D File Offset: 0x0002C41D
		internal override bool IsInputFull()
		{
			return base.IsInputFull() || (!base.LastDisplayChar.IsEmpty && '0' != base.LastDisplayChar.Char);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0002E248 File Offset: 0x0002C448
		internal override void EraseChars(int startIndex, int endIndex)
		{
			if (startIndex > endIndex)
			{
				int num = startIndex;
				startIndex = endIndex;
				endIndex = num;
			}
			int num2 = 1 + endIndex - startIndex;
			for (int i = startIndex; i < base.DisplayChars.Count; i++)
			{
				if (i < base.DisplayChars.Count)
				{
					char @char = '\0';
					if (i + num2 < base.DisplayChars.Count)
					{
						@char = base.DisplayChars[i + num2].Char;
					}
					if (base.DisplayChars[i].IsEditable)
					{
						base.DisplayChars[i].Char = @char;
					}
				}
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0002E2D6 File Offset: 0x0002C4D6
		private char NumberDecimalSeparator
		{
			get
			{
				return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar('.', base.MaskInfo.FormatProvider, false);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0002E2EC File Offset: 0x0002C4EC
		internal double GetFractionValue()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("0" + base.DecimalSeperatorChar, 5 + base.DisplayChars.Count);
			global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			int count = displayChars.Count;
			for (int i = 0; i < count; i++)
			{
				char c = displayChars[i].Char;
				if (c == '\0' && this.ContinuousEditing)
				{
					c = '0';
				}
				if (c != '\0')
				{
					bool flag = char.IsDigit(c);
					if (flag)
					{
						stringBuilder.Append(c);
					}
				}
			}
			stringBuilder.Append('0');
			return double.Parse(stringBuilder.ToString(), base.MaskInfo.FormatProvider);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0002E392 File Offset: 0x0002C592
		internal override bool CanShiftRight(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0002E395 File Offset: 0x0002C595
		internal override bool CanShiftLeft(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0002E398 File Offset: 0x0002C598
		internal override bool ShiftLeft(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0002E39B File Offset: 0x0002C59B
		internal override bool ShiftRight(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002E39E File Offset: 0x0002C59E
		internal override bool DeleteCharWithNoShift(int pos)
		{
			return false;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002E3A4 File Offset: 0x0002C5A4
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			if (contentModificationsAllowed)
			{
				int count = base.DisplayChars.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
					if (displayCharBase.IsEmpty)
					{
						if (this.LastFilledChar == null || displayCharBase.Index >= this.LastFilledChar.Index)
						{
							break;
						}
						this.DeleteCharAndShift(i);
						i--;
					}
				}
			}
			return true;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002E40C File Offset: 0x0002C60C
		internal virtual void PadWithZero()
		{
			int count = base.DisplayChars.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
				if (displayCharBase != null)
				{
					if (!displayCharBase.IsEmpty)
					{
						break;
					}
					displayCharBase.Char = '0';
				}
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0002E454 File Offset: 0x0002C654
		internal virtual void TrimInsignificantZeros()
		{
			global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			int count = displayChars.Count;
			bool flag = false;
			for (int i = count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
				if (flag || !displayCharBase.IsEmpty)
				{
					flag = true;
					if ('0' != displayCharBase.Char)
					{
						break;
					}
					displayCharBase.Char = '\0';
				}
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0002E4A9 File Offset: 0x0002C6A9
		public override global::Infragistics.Windows.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Windows.Editors.EditOrientation.LeftToRight;
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0002E4AC File Offset: 0x0002C6AC
		public override bool ValidateString(ref string str)
		{
			str = global::Infragistics.Windows.Editors.NumberSection.StripOutPadPromptCharacters(str, this);
			for (int i = 0; i < str.Length; i++)
			{
				if (!char.IsDigit(str, i))
				{
					return false;
				}
			}
			if (str.Length > base.DisplayChars.Count)
			{
				str = str.Substring(0, base.DisplayChars.Count);
			}
			return true;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0002E50C File Offset: 0x0002C70C
		private void CreateDisplayChars()
		{
			base.DisplayChars.Clear();
			for (int i = 0; i < this.digits; i++)
			{
				base.DisplayChars.Add(new global::Infragistics.Windows.Editors.DigitChar(this));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0002E546 File Offset: 0x0002C746
		internal override bool SupportsSpinning
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0002E54C File Offset: 0x0002C74C
		internal override bool CanSpin(bool up)
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
			if (up && (text == null || text.Length == 0))
			{
				return true;
			}
			double fractionValue;
			try
			{
				fractionValue = this.GetFractionValue();
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
				return this.DeltaValue + fractionValue <= this.MaxValue;
			}
			return fractionValue - this.DeltaValue >= this.MinValue;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0002E5D0 File Offset: 0x0002C7D0
		internal void SetFractionValue(double fractionValue)
		{
			fractionValue -= global::System.Math.Floor(fractionValue);
			try
			{
				long n = (long)global::System.Math.Round(fractionValue * global::System.Math.Pow(10.0, (double)this.digits), 0);
				string text = global::Infragistics.Windows.Editors.NumberSection.PadNumber(n, this.digits);
				global::Infragistics.Windows.Editors.XamMaskedEditor maskedEdit = base.MaskedEdit;
				if (maskedEdit.TrimFractionalZeros && !(this is global::Infragistics.Windows.Editors.FractionPartContinuous))
				{
					text = text.TrimEnd(new char[]
					{
						'0'
					});
				}
				this.SetText(text);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0002E65C File Offset: 0x0002C85C
		internal global::Infragistics.Windows.Editors.NumberSection NumberSection
		{
			get
			{
				return this.PreviousEditSection as global::Infragistics.Windows.Editors.NumberSection;
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0002E66C File Offset: 0x0002C86C
		internal override bool Spin(bool up, bool setLimit)
		{
			try
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor maskedEdit = base.MaskedEdit;
				double num;
				if (setLimit)
				{
					num = (up ? this.MaxValue : this.MinValue);
				}
				else
				{
					string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
					if (string.IsNullOrEmpty(text) || !base.IsInt(text))
					{
						num = (up ? this.MinValue : this.MaxValue);
						if (up && 0.0 == num && maskedEdit.TrimFractionalZeros)
						{
							num += this.DeltaValue;
						}
					}
					else
					{
						num = double.Parse("0" + this.NumberDecimalSeparator + text, base.MaskInfo.FormatProvider);
						num += (up ? this.DeltaValue : (-this.DeltaValue));
					}
				}
				if (maskedEdit.SpinWrap)
				{
					if (up)
					{
						if (num <= this.MaxValue)
						{
							this.SetFractionValue(num);
						}
						else if (num > this.MaxValue)
						{
							this.SetFractionValue(this.MinValue);
						}
					}
					else if (num >= this.MinValue)
					{
						this.SetFractionValue(num);
					}
					else if (num < this.MinValue)
					{
						this.SetFractionValue(this.MaxValue);
					}
					return true;
				}
				if (num >= this.MinValue && num <= this.MaxValue)
				{
					this.SetFractionValue(num);
					return true;
				}
				return false;
			}
			catch (global::System.Exception)
			{
			}
			return false;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0002E7C8 File Offset: 0x0002C9C8
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.FractionPart fractionPart = new global::Infragistics.Windows.Editors.FractionPart(this.digits);
			this.InternalCopy(fractionPart);
			fractionPart.InitSectionsCollection(sections);
			return fractionPart;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002E7F0 File Offset: 0x0002C9F0
		internal override void InternalCopy(global::Infragistics.Windows.Editors.SectionBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Windows.Editors.FractionPart fractionPart = (global::Infragistics.Windows.Editors.FractionPart)dest;
		}

		// Token: 0x040003A0 RID: 928
		private int digits = 2;

		// Token: 0x040003A1 RID: 929
		private double minValue;

		// Token: 0x040003A2 RID: 930
		private double maxValue;
	}
}
