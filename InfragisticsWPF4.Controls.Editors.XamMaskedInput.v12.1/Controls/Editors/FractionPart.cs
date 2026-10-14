using System;
using System.Text;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000041 RID: 65
	public class FractionPart : global::Infragistics.Controls.Editors.EditSectionBase
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0000F0F6 File Offset: 0x0000D2F6
		internal FractionPart(int digits)
		{
			this.digits = digits;
			this.ResetMaxValue();
			this.CreateDisplayChars();
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000F118 File Offset: 0x0000D318
		public int NumberOfDigits
		{
			get
			{
				return this.digits;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000F120 File Offset: 0x0000D320
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0000F128 File Offset: 0x0000D328
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

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000F131 File Offset: 0x0000D331
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0000F139 File Offset: 0x0000D339
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

		// Token: 0x06000258 RID: 600 RVA: 0x0000F142 File Offset: 0x0000D342
		internal void ResetMaxValue()
		{
			this.maxValue = 1.0 - global::System.Math.Pow(10.0, (double)(-(double)this.digits));
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000F16A File Offset: 0x0000D36A
		internal void ResetMinValue()
		{
			this.minValue = 0.0;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000F17C File Offset: 0x0000D37C
		internal double DeltaValue
		{
			get
			{
				return global::System.Math.Pow(10.0, (double)(-(double)this.digits));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000F1A1 File Offset: 0x0000D3A1
		internal virtual bool ContinuousEditing
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000F1A4 File Offset: 0x0000D3A4
		internal override bool CanInsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[pos];
			return displayCharBase != null && displayCharBase.IsEditable && displayCharBase.MatchChar(c) && (base.LastDisplayChar.IsEmpty || '0' == base.LastDisplayChar.Char);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000F20C File Offset: 0x0000D40C
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

		// Token: 0x0600025E RID: 606 RVA: 0x0000F279 File Offset: 0x0000D479
		internal override bool DeleteCharAndShift(int pos)
		{
			return this.DeleteCharsAndShift(pos, 1);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000F284 File Offset: 0x0000D484
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

		// Token: 0x06000260 RID: 608 RVA: 0x0000F304 File Offset: 0x0000D504
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

		// Token: 0x06000261 RID: 609 RVA: 0x0000F365 File Offset: 0x0000D565
		internal override bool IsInputFull()
		{
			return base.IsInputFull() || (!base.LastDisplayChar.IsEmpty && '0' != base.LastDisplayChar.Char);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000F390 File Offset: 0x0000D590
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000F41E File Offset: 0x0000D61E
		private char NumberDecimalSeparator
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar('.', base.MaskInfo.FormatProvider, false);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000F434 File Offset: 0x0000D634
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

		// Token: 0x06000265 RID: 613 RVA: 0x0000F4DA File Offset: 0x0000D6DA
		internal override bool CanShiftRight(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000F4DD File Offset: 0x0000D6DD
		internal override bool CanShiftLeft(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		internal override bool ShiftLeft(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000F4E3 File Offset: 0x0000D6E3
		internal override bool ShiftRight(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000F4E6 File Offset: 0x0000D6E6
		internal override bool DeleteCharWithNoShift(int pos)
		{
			return false;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000F4EC File Offset: 0x0000D6EC
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

		// Token: 0x0600026B RID: 619 RVA: 0x0000F554 File Offset: 0x0000D754
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

		// Token: 0x0600026C RID: 620 RVA: 0x0000F59C File Offset: 0x0000D79C
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000F5F1 File Offset: 0x0000D7F1
		public override global::Infragistics.Controls.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Controls.Editors.EditOrientation.LeftToRight;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
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

		// Token: 0x0600026F RID: 623 RVA: 0x0000F654 File Offset: 0x0000D854
		private void CreateDisplayChars()
		{
			base.DisplayChars.Clear();
			for (int i = 0; i < this.digits; i++)
			{
				base.DisplayChars.Add(new global::Infragistics.Controls.Editors.DigitChar(this));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000F68E File Offset: 0x0000D88E
		internal override bool SupportsSpinning
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000F694 File Offset: 0x0000D894
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

		// Token: 0x06000272 RID: 626 RVA: 0x0000F718 File Offset: 0x0000D918
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

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
		internal global::Infragistics.Controls.Editors.NumberSection NumberSection
		{
			get
			{
				return this.PreviousEditSection as global::Infragistics.Controls.Editors.NumberSection;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000F7B4 File Offset: 0x0000D9B4
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

		// Token: 0x06000275 RID: 629 RVA: 0x0000F910 File Offset: 0x0000DB10
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.FractionPart fractionPart = new global::Infragistics.Controls.Editors.FractionPart(this.digits);
			this.InternalCopy(fractionPart);
			fractionPart.InitSectionsCollection(sections);
			return fractionPart;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000F938 File Offset: 0x0000DB38
		internal override void InternalCopy(global::Infragistics.Controls.Editors.SectionBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Controls.Editors.FractionPart fractionPart = (global::Infragistics.Controls.Editors.FractionPart)dest;
		}

		// Token: 0x040000E5 RID: 229
		private int digits = 2;

		// Token: 0x040000E6 RID: 230
		private double minValue;

		// Token: 0x040000E7 RID: 231
		private double maxValue;
	}
}
