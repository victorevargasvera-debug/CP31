using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000082 RID: 130
	public sealed class HexDigitChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x00020243 File Offset: 0x0001E443
		internal HexDigitChar()
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0002024B File Offset: 0x0001E44B
		internal HexDigitChar(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00020254 File Offset: 0x0001E454
		public override bool MatchChar(char c)
		{
			char value = base.Filter(c);
			return "0123456789ABCDEFabcdef".IndexOf(value) >= 0;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0002027C File Offset: 0x0001E47C
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.HexDigitChar hexDigitChar = new global::Infragistics.Windows.Editors.HexDigitChar(section);
			this.InternalCopy(hexDigitChar);
			return hexDigitChar;
		}

		// Token: 0x0400029E RID: 670
		internal const string HEX_DIGITS = "0123456789ABCDEFabcdef";
	}
}
