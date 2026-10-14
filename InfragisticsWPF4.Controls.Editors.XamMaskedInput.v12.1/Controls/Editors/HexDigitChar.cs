using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000019 RID: 25
	public sealed class HexDigitChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00004513 File Offset: 0x00002713
		internal HexDigitChar()
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000451B File Offset: 0x0000271B
		internal HexDigitChar(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004524 File Offset: 0x00002724
		public override bool MatchChar(char c)
		{
			char value = base.Filter(c);
			return "0123456789ABCDEFabcdef".IndexOf(value) >= 0;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000454C File Offset: 0x0000274C
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.HexDigitChar hexDigitChar = new global::Infragistics.Controls.Editors.HexDigitChar(section);
			this.InternalCopy(hexDigitChar);
			return hexDigitChar;
		}

		// Token: 0x04000052 RID: 82
		internal const string HEX_DIGITS = "0123456789ABCDEFabcdef";
	}
}
