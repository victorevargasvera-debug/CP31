using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200007A RID: 122
	public class DigitChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x0600076A RID: 1898 RVA: 0x0001FD29 File Offset: 0x0001DF29
		internal DigitChar()
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0001FD31 File Offset: 0x0001DF31
		internal DigitChar(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0001FD3C File Offset: 0x0001DF3C
		public override bool MatchChar(char c)
		{
			char c2 = base.Filter(c);
			global::Infragistics.Windows.Editors.NumberSection numberSection = base.Section as global::Infragistics.Windows.Editors.NumberSection;
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
							global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = numberSection.DisplayChars[i];
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
								global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase2 = numberSection.DisplayChars[j];
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

		// Token: 0x0600076D RID: 1901 RVA: 0x0001FE74 File Offset: 0x0001E074
		internal virtual bool ShouldIncludeComma(global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			if (!this.HasComma)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.NumberSection numberSection = base.Section as global::Infragistics.Windows.Editors.NumberSection;
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
			case global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals:
			case global::Infragistics.Windows.Editors.MaskMode.IncludeBoth:
			case global::Infragistics.Windows.Editors.MaskMode.IncludeLiteralsWithPadding:
				return true;
			}
			return false;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0001FEE3 File Offset: 0x0001E0E3
		internal override bool DrawComma
		{
			get
			{
				return base.MaskInfo != null && this.ShouldIncludeComma(base.MaskInfo.IsBeingEditedAndFocused ? global::Infragistics.Windows.Editors.MaskMode.IncludeBoth : base.MaskInfo.DisplayMode);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x0001FF10 File Offset: 0x0001E110
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x0001FF18 File Offset: 0x0001E118
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

		// Token: 0x06000771 RID: 1905 RVA: 0x0001FF24 File Offset: 0x0001E124
		internal override void InternalCopy(global::Infragistics.Windows.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Windows.Editors.DigitChar digitChar = (global::Infragistics.Windows.Editors.DigitChar)dest;
			digitChar.hasComma = this.hasComma;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0001FF4C File Offset: 0x0001E14C
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.DigitChar digitChar = new global::Infragistics.Windows.Editors.DigitChar(section);
			this.InternalCopy(digitChar);
			return digitChar;
		}

		// Token: 0x04000298 RID: 664
		private bool hasComma;
	}
}
