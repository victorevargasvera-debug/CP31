using System;
using System.Text;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000040 RID: 64
	public class FractionPart : global::Infragistics.Controls.Editors.EditSectionBase
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0000EEBE File Offset: 0x0000D0BE
		internal FractionPart(int digits)
		{
			this.digits = digits;
			this.ResetMaxValue();
			this.CreateDisplayChars();
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		public int NumberOfDigits
		{
			get
			{
				return this.digits;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000EEE8 File Offset: 0x0000D0E8
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0000EEF0 File Offset: 0x0000D0F0
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000EEF9 File Offset: 0x0000D0F9
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0000EF01 File Offset: 0x0000D101
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

		// Token: 0x06000258 RID: 600 RVA: 0x0000EF0A File Offset: 0x0000D10A
		internal void ResetMaxValue()
		{
			this.maxValue = 1.0 - global::System.Math.Pow(10.0, (double)(-(double)this.digits));
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000EF32 File Offset: 0x0000D132
		internal void ResetMinValue()
		{
			this.minValue = 0.0;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000EF44 File Offset: 0x0000D144
		internal double DeltaValue
		{
			get
			{
				return global::System.Math.Pow(10.0, (double)(-(double)this.digits));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000EF69 File Offset: 0x0000D169
		internal virtual bool ContinuousEditing
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000EF6C File Offset: 0x0000D16C
		internal override bool CanInsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[pos];
			return displayCharBase != null && displayCharBase.IsEditable && displayCharBase.MatchChar(c) && (base.LastDisplayChar.IsEmpty || '0' == base.LastDisplayChar.Char);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000EFD4 File Offset: 0x0000D1D4
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

		// Token: 0x0600025E RID: 606 RVA: 0x0000F041 File Offset: 0x0000D241
		internal override bool DeleteCharAndShift(int pos)
		{
			return this.DeleteCharsAndShift(pos, 1);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000F04C File Offset: 0x0000D24C
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

		// Token: 0x06000260 RID: 608 RVA: 0x0000F0CC File Offset: 0x0000D2CC
		public override void SetText(string text)
		{
			int num = 0;
			global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			int count = displayChars.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
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

		// Token: 0x06000261 RID: 609 RVA: 0x0000F12D File Offset: 0x0000D32D
		internal override bool IsInputFull()
		{
			return base.IsInputFull() || (!base.LastDisplayChar.IsEmpty && '0' != base.LastDisplayChar.Char);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000F158 File Offset: 0x0000D358
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

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000F1E6 File Offset: 0x0000D3E6
		private char NumberDecimalSeparator
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar('.', base.MaskInfo.FormatProvider, false);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000F1FC File Offset: 0x0000D3FC
		internal double GetFractionValue()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("0" + base.DecimalSeperatorChar, 5 + base.DisplayChars.Count);
			global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
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

		// Token: 0x06000265 RID: 613 RVA: 0x0000F2A2 File Offset: 0x0000D4A2
		internal override bool CanShiftRight(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000F2A5 File Offset: 0x0000D4A5
		internal override bool CanShiftLeft(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000F2A8 File Offset: 0x0000D4A8
		internal override bool ShiftLeft(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000F2AB File Offset: 0x0000D4AB
		internal override bool ShiftRight(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000F2AE File Offset: 0x0000D4AE
		internal override bool DeleteCharWithNoShift(int pos)
		{
			return false;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000F2B4 File Offset: 0x0000D4B4
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			if (contentModificationsAllowed)
			{
				int count = base.DisplayChars.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
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

		// Token: 0x0600026B RID: 619 RVA: 0x0000F31C File Offset: 0x0000D51C
		internal virtual void PadWithZero()
		{
			int count = base.DisplayChars.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
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

		// Token: 0x0600026C RID: 620 RVA: 0x0000F364 File Offset: 0x0000D564
		internal virtual void TrimInsignificantZeros()
		{
			global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			int count = displayChars.Count;
			bool flag = false;
			for (int i = count - 1; i >= 0; i--)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
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

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000F3B9 File Offset: 0x0000D5B9
		public override global::Infragistics.Controls.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Controls.Editors.EditOrientation.LeftToRight;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000F3BC File Offset: 0x0000D5BC
		public override bool ValidateString(ref string str)
		{
			str = global::Infragistics.Controls.Editors.NumberSection.StripOutPadPromptCharacters(str, this);
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

		// Token: 0x0600026F RID: 623 RVA: 0x0000F41C File Offset: 0x0000D61C
		private void CreateDisplayChars()
		{
			base.DisplayChars.Clear();
			for (int i = 0; i < this.digits; i++)
			{
				base.DisplayChars.Add(new global::Infragistics.Controls.Editors.DigitChar(this));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000F456 File Offset: 0x0000D656
		internal override bool SupportsSpinning
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000F45C File Offset: 0x0000D65C
		internal override bool CanSpin(bool up)
		{
			string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
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
			if (base.MaskInfo.MaskedInput.SpinWrap)
			{
				return true;
			}
			if (up)
			{
				return this.DeltaValue + fractionValue <= this.MaxValue;
			}
			return fractionValue - this.DeltaValue >= this.MinValue;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		internal void SetFractionValue(double fractionValue)
		{
			fractionValue -= global::System.Math.Floor(fractionValue);
			try
			{
				long n = (long)global::System.Math.Round(fractionValue * global::System.Math.Pow(10.0, (double)this.digits), 0);
				string text = global::Infragistics.Controls.Editors.NumberSection.PadNumber(n, this.digits);
				global::Infragistics.Controls.Editors.XamMaskedInput maskedEdit = base.MaskedEdit;
				if (maskedEdit.TrimFractionalZeros && !(this is global::Infragistics.Controls.Editors.FractionPartContinuous))
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

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000F56C File Offset: 0x0000D76C
		internal global::Infragistics.Controls.Editors.NumberSection NumberSection
		{
			get
			{
				return this.PreviousEditSection as global::Infragistics.Controls.Editors.NumberSection;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000F57C File Offset: 0x0000D77C
		internal override bool Spin(bool up, bool setLimit)
		{
			try
			{
				global::Infragistics.Controls.Editors.XamMaskedInput maskedEdit = base.MaskedEdit;
				double num;
				if (setLimit)
				{
					num = (up ? this.MaxValue : this.MinValue);
				}
				else
				{
					string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
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

		// Token: 0x06000275 RID: 629 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.FractionPart fractionPart = new global::Infragistics.Controls.Editors.FractionPart(this.digits);
			this.InternalCopy(fractionPart);
			fractionPart.InitSectionsCollection(sections);
			return fractionPart;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000F700 File Offset: 0x0000D900
		internal override void InternalCopy(global::Infragistics.Controls.Editors.SectionBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Controls.Editors.FractionPart fractionPart = (global::Infragistics.Controls.Editors.FractionPart)dest;
		}

		// Token: 0x040000E9 RID: 233
		private int digits = 2;

		// Token: 0x040000EA RID: 234
		private double minValue;

		// Token: 0x040000EB RID: 235
		private double maxValue;
	}
}
