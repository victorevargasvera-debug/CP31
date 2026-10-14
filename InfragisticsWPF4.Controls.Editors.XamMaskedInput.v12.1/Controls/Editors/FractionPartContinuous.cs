using System;
using System.Text;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000042 RID: 66
	public sealed class FractionPartContinuous : global::Infragistics.Controls.Editors.FractionPart
	{
		// Token: 0x06000277 RID: 631 RVA: 0x0000F948 File Offset: 0x0000DB48
		internal FractionPartContinuous(int digits) : base(digits)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000F951 File Offset: 0x0000DB51
		internal override bool ContinuousEditing
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000F954 File Offset: 0x0000DB54
		internal override bool CanInsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos > base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.SafeDisplayCharAt(pos);
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase2 = (displayCharBase != null) ? displayCharBase : base.LastDisplayChar;
			if (!displayCharBase2.MatchChar(c))
			{
				return false;
			}
			global::Infragistics.Controls.Editors.NumberSection numberSection = base.NumberSection;
			return !this.IsInputFull() || numberSection == null || numberSection.CanInsertCharAt(numberSection.LastDisplayChar.Index, base.FirstDisplayChar.Char);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000F9C8 File Offset: 0x0000DBC8
		internal override bool InsertCharAt(int pos, char c)
		{
			if (c == '\0')
			{
				return false;
			}
			global::Infragistics.Controls.Editors.NumberSection numberSection = base.NumberSection;
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

		// Token: 0x0600027B RID: 635 RVA: 0x0000FA60 File Offset: 0x0000DC60
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

		// Token: 0x0600027C RID: 636 RVA: 0x0000FA88 File Offset: 0x0000DC88
		private bool DeleteCharHelper(int pos)
		{
			int count = base.DisplayChars.Count;
			if (pos < 0 || pos >= count)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.NumberSection numberSection = base.NumberSection;
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

		// Token: 0x0600027D RID: 637 RVA: 0x0000FB34 File Offset: 0x0000DD34
		internal override string GetText(global::Infragistics.Controls.Editors.InputMaskMode maskMode)
		{
			global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			int count = displayChars.Count;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(count);
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
				stringBuilder.Append((!displayCharBase.IsEmpty) ? displayCharBase.Char : '0');
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000FB8C File Offset: 0x0000DD8C
		internal override bool IsInputFull()
		{
			return base.IsInputFull() && (base.NumberSection == null || base.NumberSection.IsInputFull());
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000FBB0 File Offset: 0x0000DDB0
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

		// Token: 0x06000280 RID: 640 RVA: 0x0000FBD6 File Offset: 0x0000DDD6
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			if (contentModificationsAllowed && (!this.IsEmpty || (base.NumberSection != null && !base.NumberSection.IsEmpty)))
			{
				this.PadWithZeroHelper(true);
			}
			return true;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000FC00 File Offset: 0x0000DE00
		internal override void PadWithZero()
		{
			this.PadWithZeroHelper(false);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000FC0C File Offset: 0x0000DE0C
		private void PadWithZeroHelper(bool force)
		{
			int count = base.DisplayChars.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000FC5A File Offset: 0x0000DE5A
		public override global::Infragistics.Controls.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Controls.Editors.EditOrientation.RightToLeft;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000FC60 File Offset: 0x0000DE60
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.FractionPart fractionPart = new global::Infragistics.Controls.Editors.FractionPartContinuous(base.NumberOfDigits);
			this.InternalCopy(fractionPart);
			fractionPart.InitSectionsCollection(sections);
			return fractionPart;
		}
	}
}
