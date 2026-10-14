using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000010 RID: 16
	internal sealed class DecimalSeperatorChar : global::Infragistics.Controls.Editors.LiteralChar
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00003F62 File Offset: 0x00002162
		internal DecimalSeperatorChar(char decimalSeperatorChar) : base(decimalSeperatorChar)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003F6B File Offset: 0x0000216B
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00003F87 File Offset: 0x00002187
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

		// Token: 0x0600005E RID: 94 RVA: 0x00003F98 File Offset: 0x00002198
		public override bool MatchChar(char c)
		{
			return c == base.Section.DecimalSeperatorChar || base.MatchChar(c);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003FB4 File Offset: 0x000021B4
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.DecimalSeperatorChar decimalSeperatorChar = new global::Infragistics.Controls.Editors.DecimalSeperatorChar(this.literal);
			this.InternalCopy(decimalSeperatorChar);
			decimalSeperatorChar.Initialize(section);
			return decimalSeperatorChar;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003FDC File Offset: 0x000021DC
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
