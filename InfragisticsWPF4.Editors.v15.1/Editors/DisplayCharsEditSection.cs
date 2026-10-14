using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000AB RID: 171
	public class DisplayCharsEditSection : global::Infragistics.Windows.Editors.EditSectionBase
	{
		// Token: 0x06000964 RID: 2404 RVA: 0x0002B96F File Offset: 0x00029B6F
		internal DisplayCharsEditSection()
		{
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0002B977 File Offset: 0x00029B77
		public override global::Infragistics.Windows.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Windows.Editors.EditOrientation.LeftToRight;
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0002B97C File Offset: 0x00029B7C
		public override void SetText(string text)
		{
			int num = 0;
			for (int i = 0; i < base.DisplayChars.Count; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
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

		// Token: 0x06000967 RID: 2407 RVA: 0x0002B9D4 File Offset: 0x00029BD4
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
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
				if (!displayCharBase.MatchChar(str[i]) && ((padChar != str[i] && promptChar != str[i]) || !displayCharBase.IsEditable || displayCharBase.Required))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0002BA70 File Offset: 0x00029C70
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			int num = 0;
			while (num < base.DisplayChars.Count && this == base.DisplayChars[num].Section)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[num];
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

		// Token: 0x06000969 RID: 2409 RVA: 0x0002BADC File Offset: 0x00029CDC
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.DisplayCharsEditSection displayCharsEditSection = new global::Infragistics.Windows.Editors.DisplayCharsEditSection();
			this.InternalCopy(displayCharsEditSection);
			displayCharsEditSection.InitSectionsCollection(sections);
			return displayCharsEditSection;
		}
	}
}
