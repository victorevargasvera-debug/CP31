using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200007F RID: 127
	internal sealed class DecimalSeperatorChar : global::Infragistics.Windows.Editors.LiteralChar
	{
		// Token: 0x060007C5 RID: 1989 RVA: 0x000216A6 File Offset: 0x0001F8A6
		internal DecimalSeperatorChar(char decimalSeperatorChar) : base(decimalSeperatorChar)
		{
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x000216AF File Offset: 0x0001F8AF
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x000216CB File Offset: 0x0001F8CB
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

		// Token: 0x060007C8 RID: 1992 RVA: 0x000216DC File Offset: 0x0001F8DC
		public override bool MatchChar(char c)
		{
			return c == base.Section.DecimalSeperatorChar || base.MatchChar(c);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000216F8 File Offset: 0x0001F8F8
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.DecimalSeperatorChar decimalSeperatorChar = new global::Infragistics.Windows.Editors.DecimalSeperatorChar(this.literal);
			this.InternalCopy(decimalSeperatorChar);
			decimalSeperatorChar.Initialize(section);
			return decimalSeperatorChar;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00021720 File Offset: 0x0001F920
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
