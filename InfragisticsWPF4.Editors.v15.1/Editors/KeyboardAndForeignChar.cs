using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000089 RID: 137
	internal sealed class KeyboardAndForeignChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x060007EE RID: 2030 RVA: 0x00021D00 File Offset: 0x0001FF00
		internal KeyboardAndForeignChar()
		{
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00021D08 File Offset: 0x0001FF08
		internal KeyboardAndForeignChar(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00021D14 File Offset: 0x0001FF14
		public override bool MatchChar(char c)
		{
			char c2 = this.Filter(c);
			int num = (int)c2;
			return num > 31 && num != 127;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00021D3C File Offset: 0x0001FF3C
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.KeyboardAndForeignChar keyboardAndForeignChar = new global::Infragistics.Windows.Editors.KeyboardAndForeignChar(section);
			this.InternalCopy(keyboardAndForeignChar);
			return keyboardAndForeignChar;
		}
	}
}
