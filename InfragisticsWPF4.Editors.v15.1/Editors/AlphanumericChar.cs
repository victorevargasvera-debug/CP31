using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000082 RID: 130
	public sealed class AlphanumericChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x060007D8 RID: 2008 RVA: 0x000219DC File Offset: 0x0001FBDC
		internal AlphanumericChar()
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000219E4 File Offset: 0x0001FBE4
		internal AlphanumericChar(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000219F0 File Offset: 0x0001FBF0
		public override bool MatchChar(char c)
		{
			char c2 = this.Filter(c);
			return char.IsLetterOrDigit(c2);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00021A0C File Offset: 0x0001FC0C
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.AlphanumericChar alphanumericChar = new global::Infragistics.Windows.Editors.AlphanumericChar(section);
			this.InternalCopy(alphanumericChar);
			return alphanumericChar;
		}
	}
}
