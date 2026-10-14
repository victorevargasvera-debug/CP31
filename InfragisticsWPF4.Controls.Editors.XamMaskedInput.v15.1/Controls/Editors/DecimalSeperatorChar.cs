using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200000F RID: 15
	internal sealed class DecimalSeperatorChar : global::Infragistics.Controls.Editors.LiteralChar
	{
		// Token: 0x06000058 RID: 88 RVA: 0x000038FE File Offset: 0x00001AFE
		internal DecimalSeperatorChar(char decimalSeperatorChar) : base(decimalSeperatorChar)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00003907 File Offset: 0x00001B07
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00003923 File Offset: 0x00001B23
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
				throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_InvalidOperationException_3"));
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003934 File Offset: 0x00001B34
		public override bool MatchChar(char c)
		{
			return c == base.Section.DecimalSeperatorChar || base.MatchChar(c);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003950 File Offset: 0x00001B50
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.DecimalSeperatorChar decimalSeperatorChar = new global::Infragistics.Controls.Editors.DecimalSeperatorChar(this.literal);
			this.InternalCopy(decimalSeperatorChar);
			decimalSeperatorChar.Initialize(section);
			return decimalSeperatorChar;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003978 File Offset: 0x00001B78
		internal override char GetDrawChar()
		{
			char c = base.GetDrawChar();
			if (c == '\0')
			{
				global::Infragistics.Controls.Editors.MaskInfo maskInfo = base.MaskInfo;
				if (maskInfo != null && maskInfo.IsBeingEditedAndFocused)
				{
					c = this.Char;
				}
			}
			return c;
		}
	}
}
