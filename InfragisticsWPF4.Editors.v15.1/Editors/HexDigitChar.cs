using System;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000088 RID: 136
	public sealed class HexDigitChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x060007E9 RID: 2025 RVA: 0x00021C6B File Offset: 0x0001FE6B
		internal HexDigitChar()
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00021C73 File Offset: 0x0001FE73
		internal HexDigitChar(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00021C7C File Offset: 0x0001FE7C
		internal override char Filter(char c)
		{
			c = base.Filter(c);
			int num = global::System.Globalization.CultureInfo.CurrentCulture.CompareInfo.IndexOf("0123456789ABCDEFabcdef", c, global::System.Globalization.CompareOptions.IgnoreWidth);
			if (num >= 0)
			{
				c = "0123456789ABCDEFabcdef"[num];
			}
			return c;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00021CBC File Offset: 0x0001FEBC
		public override bool MatchChar(char c)
		{
			char value = this.Filter(c);
			return "0123456789ABCDEFabcdef".IndexOf(value) >= 0;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00021CE4 File Offset: 0x0001FEE4
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.HexDigitChar hexDigitChar = new global::Infragistics.Windows.Editors.HexDigitChar(section);
			this.InternalCopy(hexDigitChar);
			return hexDigitChar;
		}

		// Token: 0x040002D1 RID: 721
		internal const string HEX_DIGITS = "0123456789ABCDEFabcdef";
	}
}
