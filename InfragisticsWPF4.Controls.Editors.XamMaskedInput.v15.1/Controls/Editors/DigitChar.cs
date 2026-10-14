using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000010 RID: 16
	public class DigitChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000039A9 File Offset: 0x00001BA9
		internal DigitChar()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000039B1 File Offset: 0x00001BB1
		internal DigitChar(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000039BC File Offset: 0x00001BBC
		public override bool MatchChar(char c)
		{
			char c2 = this.Filter(c);
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

		// Token: 0x06000061 RID: 97 RVA: 0x00003AF4 File Offset: 0x00001CF4
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00003B63 File Offset: 0x00001D63
		internal override bool DrawComma
		{
			get
			{
				return base.MaskInfo != null && this.ShouldIncludeComma(base.MaskInfo.IsBeingEditedAndFocused ? global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth : base.MaskInfo.DisplayMode);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00003B90 File Offset: 0x00001D90
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00003B98 File Offset: 0x00001D98
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

		// Token: 0x06000065 RID: 101 RVA: 0x00003BA4 File Offset: 0x00001DA4
		internal override void InternalCopy(global::Infragistics.Controls.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Controls.Editors.DigitChar digitChar = (global::Infragistics.Controls.Editors.DigitChar)dest;
			digitChar.hasComma = this.hasComma;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003BCC File Offset: 0x00001DCC
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.DigitChar digitChar = new global::Infragistics.Controls.Editors.DigitChar(section);
			this.InternalCopy(digitChar);
			return digitChar;
		}

		// Token: 0x0400004E RID: 78
		private bool hasComma;
	}
}
