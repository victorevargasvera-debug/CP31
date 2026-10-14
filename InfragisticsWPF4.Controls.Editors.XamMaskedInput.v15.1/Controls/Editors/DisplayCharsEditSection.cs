using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000036 RID: 54
	public class DisplayCharsEditSection : global::Infragistics.Controls.Editors.EditSectionBase
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x0000C853 File Offset: 0x0000AA53
		internal DisplayCharsEditSection()
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000C85B File Offset: 0x0000AA5B
		public override global::Infragistics.Controls.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Controls.Editors.EditOrientation.LeftToRight;
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000C860 File Offset: 0x0000AA60
		public override void SetText(string text)
		{
			int num = 0;
			for (int i = 0; i < base.DisplayChars.Count; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
				if (displayCharBase.IsEditable)
				{
					char @char = '\0';
					if (num < text.Length)
					{
						@char = text[num++];
					}
					displayCharBase.Char = @char;
				}
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		public override bool ValidateString(ref string str)
		{
			if (str == null || base.DisplayChars.Count != str.Length)
			{
				return false;
			}
			char padChar = base.MaskInfo.PadChar;
			char promptChar = base.MaskInfo.PromptChar;
			for (int i = 0; i < base.DisplayChars.Count; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
				if (!displayCharBase.MatchChar(str[i]) && ((padChar != str[i] && promptChar != str[i]) || !displayCharBase.IsEditable || displayCharBase.Required))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000C954 File Offset: 0x0000AB54
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			int num = 0;
			while (num < base.DisplayChars.Count && this == base.DisplayChars[num].Section)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[num];
				if (displayCharBase != null)
				{
					if (displayCharBase.Char != '\0')
					{
						if (!displayCharBase.MatchChar(displayCharBase.Char))
						{
							return false;
						}
					}
					else if (displayCharBase.Required)
					{
						return false;
					}
				}
				num++;
			}
			return true;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.DisplayCharsEditSection displayCharsEditSection = new global::Infragistics.Controls.Editors.DisplayCharsEditSection();
			this.InternalCopy(displayCharsEditSection);
			displayCharsEditSection.InitSectionsCollection(sections);
			return displayCharsEditSection;
		}
	}
}
