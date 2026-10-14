using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A2 RID: 162
	public sealed class LiteralSection : global::Infragistics.Windows.Editors.SectionBase
	{
		// Token: 0x060008D7 RID: 2263 RVA: 0x0002927D File Offset: 0x0002747D
		internal override void SetFilterToAllChars(global::Infragistics.Windows.Editors.FilterType filter)
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00029280 File Offset: 0x00027480
		public override bool ValidateString(ref string str)
		{
			global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			if (str == null || displayChars.Count != str.Length)
			{
				return false;
			}
			for (int i = 0; i < displayChars.Count; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
				if (!displayCharBase.MatchChar(str[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x000292D8 File Offset: 0x000274D8
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.LiteralSection literalSection = new global::Infragistics.Windows.Editors.LiteralSection();
			this.InternalCopy(literalSection);
			literalSection.InitSectionsCollection(sections);
			return literalSection;
		}
	}
}
