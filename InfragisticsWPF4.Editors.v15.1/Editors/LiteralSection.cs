using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A9 RID: 169
	public sealed class LiteralSection : global::Infragistics.Windows.Editors.SectionBase
	{
		// Token: 0x06000945 RID: 2373 RVA: 0x0002B265 File Offset: 0x00029465
		internal override void SetFilterToAllChars(global::Infragistics.Windows.Editors.FilterType filter)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0002B268 File Offset: 0x00029468
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

		// Token: 0x06000947 RID: 2375 RVA: 0x0002B2C0 File Offset: 0x000294C0
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.LiteralSection literalSection = new global::Infragistics.Windows.Editors.LiteralSection();
			this.InternalCopy(literalSection);
			literalSection.InitSectionsCollection(sections);
			return literalSection;
		}
	}
}
