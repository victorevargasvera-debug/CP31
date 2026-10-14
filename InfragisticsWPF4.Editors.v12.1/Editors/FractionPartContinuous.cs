using System;
using System.Text;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000AF RID: 175
	public sealed class FractionPartContinuous : global::Infragistics.Windows.Editors.FractionPart
	{
		// Token: 0x06000993 RID: 2451 RVA: 0x0002C7F8 File Offset: 0x0002A9F8
		internal FractionPartContinuous(int digits) : base(digits)
		{
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0002C801 File Offset: 0x0002AA01
		internal override bool ContinuousEditing
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0002C804 File Offset: 0x0002AA04
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

		// Token: 0x06000996 RID: 2454 RVA: 0x0002C878 File Offset: 0x0002AA78
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

		// Token: 0x06000997 RID: 2455 RVA: 0x0002C910 File Offset: 0x0002AB10
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

		// Token: 0x06000998 RID: 2456 RVA: 0x0002C938 File Offset: 0x0002AB38
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

		// Token: 0x06000999 RID: 2457 RVA: 0x0002C9E4 File Offset: 0x0002ABE4
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

		// Token: 0x0600099A RID: 2458 RVA: 0x0002CA3C File Offset: 0x0002AC3C
		internal override bool IsInputFull()
		{
			return base.IsInputFull() && (base.NumberSection == null || base.NumberSection.IsInputFull());
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0002CA60 File Offset: 0x0002AC60
		internal override void EraseChars(int startIndex, int endIndex)
		{
			if (startIndex > endIndex)
			{
				int num = startIndex;
				startIndex = endIndex;
				endIndex = num;
			}
			this.DeleteCharsAndShift(startIndex, 1 + endIndex - startIndex);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0002CA86 File Offset: 0x0002AC86
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			if (contentModificationsAllowed && (!this.IsEmpty || (base.NumberSection != null && !base.NumberSection.IsEmpty)))
			{
				this.PadWithZeroHelper(true);
			}
			return true;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0002CAB0 File Offset: 0x0002ACB0
		internal override void PadWithZero()
		{
			this.PadWithZeroHelper(false);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0002CABC File Offset: 0x0002ACBC
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

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0002CB0A File Offset: 0x0002AD0A
		public override global::Infragistics.Windows.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Windows.Editors.EditOrientation.RightToLeft;
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0002CB10 File Offset: 0x0002AD10
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.FractionPart fractionPart = new global::Infragistics.Windows.Editors.FractionPartContinuous(base.NumberOfDigits);
			this.InternalCopy(fractionPart);
			fractionPart.InitSectionsCollection(sections);
			return fractionPart;
		}
	}
}
