using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000080 RID: 128
	public class DigitChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x060007CB RID: 1995 RVA: 0x00021751 File Offset: 0x0001F951
		internal DigitChar()
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00021759 File Offset: 0x0001F959
		internal DigitChar(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00021764 File Offset: 0x0001F964
		public override bool MatchChar(char c)
		{
			char c2 = this.Filter(c);
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

		// Token: 0x060007CE RID: 1998 RVA: 0x0002189C File Offset: 0x0001FA9C
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

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x0002190B File Offset: 0x0001FB0B
		internal override bool DrawComma
		{
			get
			{
				return base.MaskInfo != null && this.ShouldIncludeComma(base.MaskInfo.IsBeingEditedAndFocused ? global::Infragistics.Windows.Editors.MaskMode.IncludeBoth : base.MaskInfo.DisplayMode);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00021938 File Offset: 0x0001FB38
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00021940 File Offset: 0x0001FB40
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

		// Token: 0x060007D2 RID: 2002 RVA: 0x0002194C File Offset: 0x0001FB4C
		internal override void InternalCopy(global::Infragistics.Windows.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Windows.Editors.DigitChar digitChar = (global::Infragistics.Windows.Editors.DigitChar)dest;
			digitChar.hasComma = this.hasComma;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00021974 File Offset: 0x0001FB74
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.DigitChar digitChar = new global::Infragistics.Windows.Editors.DigitChar(section);
			this.InternalCopy(digitChar);
			return digitChar;
		}

		// Token: 0x040002CB RID: 715
		private bool hasComma;
	}
}
