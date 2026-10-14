using System;
using System.Text;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000AE RID: 174
	public class FractionPart : global::Infragistics.Windows.Editors.EditSectionBase
	{
		// Token: 0x0600096E RID: 2414 RVA: 0x0002BFA6 File Offset: 0x0002A1A6
		internal FractionPart(int digits)
		{
			this.digits = digits;
			this.ResetMaxValue();
			this.CreateDisplayChars();
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x0002BFC8 File Offset: 0x0002A1C8
		public int NumberOfDigits
		{
			get
			{
				return this.digits;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0002BFD0 File Offset: 0x0002A1D0
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x0002BFD8 File Offset: 0x0002A1D8
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

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0002BFE1 File Offset: 0x0002A1E1
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0002BFE9 File Offset: 0x0002A1E9
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

		// Token: 0x06000974 RID: 2420 RVA: 0x0002BFF2 File Offset: 0x0002A1F2
		internal void ResetMaxValue()
		{
			this.maxValue = 1.0 - global::System.Math.Pow(10.0, (double)(-(double)this.digits));
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0002C01A File Offset: 0x0002A21A
		internal void ResetMinValue()
		{
			this.minValue = 0.0;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0002C02C File Offset: 0x0002A22C
		internal double DeltaValue
		{
			get
			{
				return global::System.Math.Pow(10.0, (double)(-(double)this.digits));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0002C051 File Offset: 0x0002A251
		internal virtual bool ContinuousEditing
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0002C054 File Offset: 0x0002A254
		internal override bool CanInsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[pos];
			return displayCharBase != null && displayCharBase.IsEditable && displayCharBase.MatchChar(c) && (base.LastDisplayChar.IsEmpty || '0' == base.LastDisplayChar.Char);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0002C0BC File Offset: 0x0002A2BC
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

		// Token: 0x0600097A RID: 2426 RVA: 0x0002C129 File Offset: 0x0002A329
		internal override bool DeleteCharAndShift(int pos)
		{
			return this.DeleteCharsAndShift(pos, 1);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0002C134 File Offset: 0x0002A334
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

		// Token: 0x0600097C RID: 2428 RVA: 0x0002C1B4 File Offset: 0x0002A3B4
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

		// Token: 0x0600097D RID: 2429 RVA: 0x0002C215 File Offset: 0x0002A415
		internal override bool IsInputFull()
		{
			return base.IsInputFull() || (!base.LastDisplayChar.IsEmpty && '0' != base.LastDisplayChar.Char);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0002C240 File Offset: 0x0002A440
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

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0002C2CE File Offset: 0x0002A4CE
		private char NumberDecimalSeparator
		{
			get
			{
				return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar('.', base.MaskInfo.FormatProvider, false);
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0002C2E4 File Offset: 0x0002A4E4
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

		// Token: 0x06000981 RID: 2433 RVA: 0x0002C38A File Offset: 0x0002A58A
		internal override bool CanShiftRight(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0002C38D File Offset: 0x0002A58D
		internal override bool CanShiftLeft(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0002C390 File Offset: 0x0002A590
		internal override bool ShiftLeft(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0002C393 File Offset: 0x0002A593
		internal override bool ShiftRight(int from, int positionsToShift)
		{
			return false;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0002C396 File Offset: 0x0002A596
		internal override bool DeleteCharWithNoShift(int pos)
		{
			return false;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0002C39C File Offset: 0x0002A59C
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

		// Token: 0x06000987 RID: 2439 RVA: 0x0002C404 File Offset: 0x0002A604
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

		// Token: 0x06000988 RID: 2440 RVA: 0x0002C44C File Offset: 0x0002A64C
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

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0002C4A1 File Offset: 0x0002A6A1
		public override global::Infragistics.Windows.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Windows.Editors.EditOrientation.LeftToRight;
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0002C4A4 File Offset: 0x0002A6A4
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

		// Token: 0x0600098B RID: 2443 RVA: 0x0002C504 File Offset: 0x0002A704
		private void CreateDisplayChars()
		{
			base.DisplayChars.Clear();
			for (int i = 0; i < this.digits; i++)
			{
				base.DisplayChars.Add(new global::Infragistics.Windows.Editors.DigitChar(this));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0002C53E File Offset: 0x0002A73E
		internal override bool SupportsSpinning
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0002C544 File Offset: 0x0002A744
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

		// Token: 0x0600098E RID: 2446 RVA: 0x0002C5C8 File Offset: 0x0002A7C8
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

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0002C654 File Offset: 0x0002A854
		internal global::Infragistics.Windows.Editors.NumberSection NumberSection
		{
			get
			{
				return this.PreviousEditSection as global::Infragistics.Windows.Editors.NumberSection;
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0002C664 File Offset: 0x0002A864
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

		// Token: 0x06000991 RID: 2449 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.FractionPart fractionPart = new global::Infragistics.Windows.Editors.FractionPart(this.digits);
			this.InternalCopy(fractionPart);
			fractionPart.InitSectionsCollection(sections);
			return fractionPart;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0002C7E8 File Offset: 0x0002A9E8
		internal override void InternalCopy(global::Infragistics.Windows.Editors.SectionBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Windows.Editors.FractionPart fractionPart = (global::Infragistics.Windows.Editors.FractionPart)dest;
		}

		// Token: 0x04000369 RID: 873
		private int digits = 2;

		// Token: 0x0400036A RID: 874
		private double minValue;

		// Token: 0x0400036B RID: 875
		private double maxValue;
	}
}
