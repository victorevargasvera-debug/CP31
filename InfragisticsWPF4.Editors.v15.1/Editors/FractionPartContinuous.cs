using System;
using System.Text;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000B6 RID: 182
	public sealed class FractionPartContinuous : global::Infragistics.Windows.Editors.FractionPart
	{
		// Token: 0x06000A01 RID: 2561 RVA: 0x0002E800 File Offset: 0x0002CA00
		internal FractionPartContinuous(int digits) : base(digits)
		{
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0002E809 File Offset: 0x0002CA09
		internal override bool ContinuousEditing
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0002E80C File Offset: 0x0002CA0C
		internal override bool CanInsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos > base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.SafeDisplayCharAt(pos);
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase2 = (displayCharBase != null) ? displayCharBase : base.LastDisplayChar;
			if (!displayCharBase2.MatchChar(c))
			{
				return false;
			}
			global::Infragistics.Windows.Editors.NumberSection numberSection = base.NumberSection;
			return !this.IsInputFull() || numberSection == null || numberSection.CanInsertCharAt(numberSection.LastDisplayChar.Index, base.FirstDisplayChar.Char);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0002E880 File Offset: 0x0002CA80
		internal override bool InsertCharAt(int pos, char c)
		{
			if (c == '\0')
			{
				return false;
			}
			global::Infragistics.Windows.Editors.NumberSection numberSection = base.NumberSection;
			if (this.CanInsertCharAt(pos, c) && (base.FirstDisplayChar.IsEmpty || (numberSection != null && numberSection.InsertCharAt(numberSection.LastDisplayChar.Index, base.FirstDisplayChar.Char))))
			{
				for (int i = 1; i <= pos; i++)
				{
					base.DisplayChars[i - 1].Char = base.DisplayChars[i].Char;
				}
				base.DisplayChars[pos].Char = c;
				return true;
			}
			return false;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0002E918 File Offset: 0x0002CB18
		internal override bool DeleteCharsAndShift(int pos, int count)
		{
			for (int i = 0; i < count; i++)
			{
				if (!this.DeleteCharHelper(pos))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0002E940 File Offset: 0x0002CB40
		private bool DeleteCharHelper(int pos)
		{
			int count = base.DisplayChars.Count;
			if (pos < 0 || pos >= count)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.NumberSection numberSection = base.NumberSection;
			for (int i = pos; i > 0; i--)
			{
				base.DisplayChars[i].Char = base.DisplayChars[i - 1].Char;
			}
			char c = (numberSection != null) ? numberSection.LastDisplayChar.Char : '\0';
			if (c != '\0' && (!base.DisplayChars[0].MatchChar(c) || !numberSection.DeleteCharAndShift(numberSection.LastDisplayChar.Index)))
			{
				c = '\0';
			}
			base.DisplayChars[0].Char = c;
			return true;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0002E9EC File Offset: 0x0002CBEC
		internal override string GetText(global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			int count = displayChars.Count;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(count);
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
				stringBuilder.Append((!displayCharBase.IsEmpty) ? displayCharBase.Char : '0');
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0002EA44 File Offset: 0x0002CC44
		internal override bool IsInputFull()
		{
			return base.IsInputFull() && (base.NumberSection == null || base.NumberSection.IsInputFull());
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0002EA68 File Offset: 0x0002CC68
		internal override void EraseChars(int startIndex, int endIndex)
		{
			if (startIndex > endIndex)
			{
				int num = startIndex;
				startIndex = endIndex;
				endIndex = num;
			}
			int pos = endIndex;
			int count = 1 + endIndex - startIndex;
			this.DeleteCharsAndShift(pos, count);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0002EA92 File Offset: 0x0002CC92
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			if (contentModificationsAllowed && (!this.IsEmpty || (base.NumberSection != null && !base.NumberSection.IsEmpty)))
			{
				this.PadWithZeroHelper(true);
			}
			return true;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0002EABC File Offset: 0x0002CCBC
		internal override void PadWithZero()
		{
			this.PadWithZeroHelper(false);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
		private void PadWithZeroHelper(bool force)
		{
			int count = base.DisplayChars.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
				if (displayCharBase.IsEmpty)
				{
					if (i == count - 1 && !force)
					{
						return;
					}
					displayCharBase.Char = '0';
				}
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0002EB16 File Offset: 0x0002CD16
		public override global::Infragistics.Windows.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Windows.Editors.EditOrientation.RightToLeft;
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0002EB1C File Offset: 0x0002CD1C
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.FractionPart fractionPart = new global::Infragistics.Windows.Editors.FractionPartContinuous(base.NumberOfDigits);
			this.InternalCopy(fractionPart);
			fractionPart.InitSectionsCollection(sections);
			return fractionPart;
		}
	}
}
