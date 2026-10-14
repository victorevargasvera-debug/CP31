using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000035 RID: 53
	public sealed class LiteralSection : global::Infragistics.Controls.Editors.SectionBase
	{
		// Token: 0x060001BA RID: 442 RVA: 0x0000C39D File Offset: 0x0000A59D
		internal override void SetFilterToAllChars(global::Infragistics.Controls.Editors.FilterType filter)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
		public override bool ValidateString(ref string str)
		{
			global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			if (str == null || displayChars.Count != str.Length)
			{
				return false;
			}
			for (int i = 0; i < displayChars.Count; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
				if (!displayCharBase.MatchChar(str[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000C3F8 File Offset: 0x0000A5F8
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.LiteralSection literalSection = new global::Infragistics.Controls.Editors.LiteralSection();
			this.InternalCopy(literalSection);
			literalSection.InitSectionsCollection(sections);
			return literalSection;
		}
	}
}
