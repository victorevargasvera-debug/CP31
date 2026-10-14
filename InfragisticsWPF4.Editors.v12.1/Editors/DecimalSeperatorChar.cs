using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000079 RID: 121
	internal sealed class DecimalSeperatorChar : global::Infragistics.Windows.Editors.LiteralChar
	{
		// Token: 0x06000764 RID: 1892 RVA: 0x0001FC7E File Offset: 0x0001DE7E
		internal DecimalSeperatorChar(char decimalSeperatorChar) : base(decimalSeperatorChar)
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0001FC87 File Offset: 0x0001DE87
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x0001FCA3 File Offset: 0x0001DEA3
		public override char Char
		{
			get
			{
				if (base.Section != null)
				{
					return base.Section.DecimalSeperatorChar;
				}
				return base.Char;
			}
			set
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_3"));
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0001FCB4 File Offset: 0x0001DEB4
		public override bool MatchChar(char c)
		{
			return c == base.Section.DecimalSeperatorChar || base.MatchChar(c);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0001FCD0 File Offset: 0x0001DED0
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.DecimalSeperatorChar decimalSeperatorChar = new global::Infragistics.Windows.Editors.DecimalSeperatorChar(this.literal);
			this.InternalCopy(decimalSeperatorChar);
			decimalSeperatorChar.Initialize(section);
			return decimalSeperatorChar;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0001FCF8 File Offset: 0x0001DEF8
		internal override char GetDrawChar()
		{
			char c = base.GetDrawChar();
			if (c == '\0')
			{
				global::Infragistics.Windows.Editors.MaskInfo maskInfo = base.MaskInfo;
				if (maskInfo != null && maskInfo.IsBeingEditedAndFocused)
				{
					c = this.Char;
				}
			}
			return c;
		}
	}
}
