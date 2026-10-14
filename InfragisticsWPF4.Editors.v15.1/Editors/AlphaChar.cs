using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000081 RID: 129
	public sealed class AlphaChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x00021990 File Offset: 0x0001FB90
		internal AlphaChar()
		{
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00021998 File Offset: 0x0001FB98
		internal AlphaChar(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000219A4 File Offset: 0x0001FBA4
		public override bool MatchChar(char c)
		{
			char c2 = this.Filter(c);
			return char.IsLetter(c2);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000219C0 File Offset: 0x0001FBC0
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.AlphaChar alphaChar = new global::Infragistics.Windows.Editors.AlphaChar(section);
			this.InternalCopy(alphaChar);
			return alphaChar;
		}
	}
}
