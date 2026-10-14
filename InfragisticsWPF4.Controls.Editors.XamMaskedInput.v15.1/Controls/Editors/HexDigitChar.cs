using System;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000018 RID: 24
	public sealed class HexDigitChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00003EAF File Offset: 0x000020AF
		internal HexDigitChar()
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003EB7 File Offset: 0x000020B7
		internal HexDigitChar(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003EC0 File Offset: 0x000020C0
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

		// Token: 0x0600007F RID: 127 RVA: 0x00003F00 File Offset: 0x00002100
		public override bool MatchChar(char c)
		{
			char value = this.Filter(c);
			return "0123456789ABCDEFabcdef".IndexOf(value) >= 0;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003F28 File Offset: 0x00002128
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.HexDigitChar hexDigitChar = new global::Infragistics.Controls.Editors.HexDigitChar(section);
			this.InternalCopy(hexDigitChar);
			return hexDigitChar;
		}

		// Token: 0x04000054 RID: 84
		internal const string HEX_DIGITS = "0123456789ABCDEFabcdef";
	}
}
