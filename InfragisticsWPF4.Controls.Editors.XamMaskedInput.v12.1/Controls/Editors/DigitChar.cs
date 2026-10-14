using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000011 RID: 17
	public class DigitChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x06000061 RID: 97 RVA: 0x0000400D File Offset: 0x0000220D
		internal DigitChar()
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004015 File Offset: 0x00002215
		internal DigitChar(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004020 File Offset: 0x00002220
		public override bool MatchChar(char c)
		{
			char c2 = base.Filter(c);
			global::Infragistics.Controls.Editors.NumberSection numberSection = base.Section as global::Infragistics.Controls.Editors.NumberSection;
			if (numberSection != null && (numberSection.MinValue < 0m || numberSection.lastConvertedMinValWithFractionPart < 0m))
			{
				char plusSignChar = numberSection.PlusSignChar;
				char minusSignChar = numberSection.MinusSignChar;
				if (plusSignChar == c || minusSignChar == c)
				{
					if (!numberSection.IgnoreStrictSignChecking)
					{
						for (int i = 0; i < numberSection.DisplayChars.Count; i++)
						{
							global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = numberSection.DisplayChars[i];
							if (!displayCharBase.IsEmpty && plusSignChar != displayCharBase.Char && minusSignChar != displayCharBase.Char)
							{
								return false;
							}
							if (this == displayCharBase)
							{
								break;
							}
						}
					}
					return true;
				}
				if (char.IsDigit(c))
				{
					if (!numberSection.IgnoreStrictSignChecking)
					{
						int index = base.Index;
						if (index >= 0)
						{
							int count = numberSection.DisplayChars.Count;
							for (int j = 1 + index; j < count; j++)
							{
								global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase2 = numberSection.DisplayChars[j];
								if (displayCharBase2 != null && !displayCharBase2.IsEmpty && (plusSignChar == displayCharBase2.Char || minusSignChar == displayCharBase2.Char))
								{
									return false;
								}
							}
						}
					}
					return true;
				}
			}
			return char.IsDigit(c2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004158 File Offset: 0x00002358
		internal virtual bool ShouldIncludeComma(global::Infragistics.Controls.Editors.InputMaskMode maskMode)
		{
			if (!this.HasComma)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.NumberSection numberSection = base.Section as global::Infragistics.Controls.Editors.NumberSection;
			if (numberSection == null)
			{
				return false;
			}
			if (this.Char == '\0')
			{
				return false;
			}
			if (numberSection.MinusSignChar == this.Char || numberSection.PlusSignChar == this.Char)
			{
				return false;
			}
			switch (maskMode)
			{
			case global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiterals:
			case global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth:
			case global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiteralsWithPadding:
				return true;
			}
			return false;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000041C7 File Offset: 0x000023C7
		internal override bool DrawComma
		{
			get
			{
				return base.MaskInfo != null && this.ShouldIncludeComma(base.MaskInfo.IsBeingEditedAndFocused ? global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth : base.MaskInfo.DisplayMode);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000041F4 File Offset: 0x000023F4
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000041FC File Offset: 0x000023FC
		internal virtual bool HasComma
		{
			get
			{
				return this.hasComma;
			}
			set
			{
				this.hasComma = value;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004208 File Offset: 0x00002408
		internal override void InternalCopy(global::Infragistics.Controls.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Controls.Editors.DigitChar digitChar = (global::Infragistics.Controls.Editors.DigitChar)dest;
			digitChar.hasComma = this.hasComma;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004230 File Offset: 0x00002430
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.DigitChar digitChar = new global::Infragistics.Controls.Editors.DigitChar(section);
			this.InternalCopy(digitChar);
			return digitChar;
		}

		// Token: 0x0400004C RID: 76
		private bool hasComma;
	}
}
