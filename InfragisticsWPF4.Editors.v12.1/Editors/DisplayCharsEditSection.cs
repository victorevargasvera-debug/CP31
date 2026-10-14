using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A4 RID: 164
	public class DisplayCharsEditSection : global::Infragistics.Windows.Editors.EditSectionBase
	{
		// Token: 0x060008F6 RID: 2294 RVA: 0x00029987 File Offset: 0x00027B87
		internal DisplayCharsEditSection()
		{
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0002998F File Offset: 0x00027B8F
		public override global::Infragistics.Windows.Editors.EditOrientation Orientation
		{
			get
			{
				return global::Infragistics.Windows.Editors.EditOrientation.LeftToRight;
			}
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00029994 File Offset: 0x00027B94
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

		// Token: 0x060008F9 RID: 2297 RVA: 0x000299EC File Offset: 0x00027BEC
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

		// Token: 0x060008FA RID: 2298 RVA: 0x00029A88 File Offset: 0x00027C88
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

		// Token: 0x060008FB RID: 2299 RVA: 0x00029AF4 File Offset: 0x00027CF4
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.DisplayCharsEditSection displayCharsEditSection = new global::Infragistics.Windows.Editors.DisplayCharsEditSection();
			this.InternalCopy(displayCharsEditSection);
			displayCharsEditSection.InitSectionsCollection(sections);
			return displayCharsEditSection;
		}
	}
}
